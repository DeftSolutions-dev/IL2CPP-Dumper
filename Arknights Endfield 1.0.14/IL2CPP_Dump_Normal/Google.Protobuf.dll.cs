// ========================================================
// Dumped by @desirepro
// Assembly: Google.Protobuf.dll
// Classes:  318
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000C
    public class OutOfSpaceException : IOException
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class ExtensionComparer, IEqualityComparer`1
    {
        // Fields
        private static Google.Protobuf.ExtensionRegistry.ExtensionComparer Instance;        // 0x0

        // Methods
        private System.Boolean Equals(Google.Protobuf.Extension a, Google.Protobuf.Extension b) { }
        private System.Int32 GetHashCode(Google.Protobuf.Extension a) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001A
    public class WrapperCodecs
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Object> Codecs;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Object> Readers;        // 0x8

        // Methods
        private Google.Protobuf.FieldCodec<T> GetCodec() { }
        private Google.Protobuf.ValueReader<System.Nullable<T>> GetReader() { }
        private T Read(Google.Protobuf.ParseContext& ctx, Google.Protobuf.FieldCodec<T> codec) { }
        private System.Void Write(Google.Protobuf.WriteContext& ctx, T value, Google.Protobuf.FieldCodec<T> codec) { }
        private System.Int32 CalculateSize(T value, Google.Protobuf.FieldCodec<T> codec) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000029
    public class InputMerger : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Google.Protobuf.ParseContext& ctx, T& value) { }
        private System.IAsyncResult BeginInvoke(Google.Protobuf.ParseContext& ctx, T& value, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(Google.Protobuf.ParseContext& ctx, T& value, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200002A
    public class ValuesMerger : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(T& value, T other) { }
        private System.IAsyncResult BeginInvoke(T& value, T other, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(T& value, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200002F
    public class Node
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.FieldMaskTree.Node> <Children>k__BackingField;        // 0x10

        // Methods
        private System.Collections.Generic.Dictionary<System.String,Google.Protobuf.FieldMaskTree.Node> get_Children() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003A
    public class Settings
    {
        // Fields
        private static readonly Google.Protobuf.JsonFormatter.Settings <Default>k__BackingField;        // 0x0
        private readonly System.Boolean <FormatDefaultValues>k__BackingField;        // 0x10
        private readonly Google.Protobuf.Reflection.TypeRegistry <TypeRegistry>k__BackingField;        // 0x18
        private readonly System.Boolean <FormatEnumsAsIntegers>k__BackingField;        // 0x20
        private readonly System.Boolean <PreserveProtoFieldNames>k__BackingField;        // 0x21

        // Methods
        private Google.Protobuf.JsonFormatter.Settings get_Default() { }
        private System.Void .cctor() { }
        private System.Boolean get_FormatDefaultValues() { }
        private Google.Protobuf.Reflection.TypeRegistry get_TypeRegistry() { }
        private System.Boolean get_FormatEnumsAsIntegers() { }
        private System.Boolean get_PreserveProtoFieldNames() { }
        private System.Void .ctor(System.Boolean formatDefaultValues) { }
        private System.Void .ctor(System.Boolean formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry) { }
        private System.Void .ctor(System.Boolean formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry, System.Boolean formatEnumsAsIntegers, System.Boolean preserveProtoFieldNames) { }
        private Google.Protobuf.JsonFormatter.Settings WithFormatDefaultValues(System.Boolean formatDefaultValues) { }
        private Google.Protobuf.JsonFormatter.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry) { }
        private Google.Protobuf.JsonFormatter.Settings WithFormatEnumsAsIntegers(System.Boolean formatEnumsAsIntegers) { }
        private Google.Protobuf.JsonFormatter.Settings WithPreserveProtoFieldNames(System.Boolean preserveProtoFieldNames) { }

    }

    // TypeToken: 0x200003B
    public class OriginalEnumValueHelper
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Object,System.String>> dictionaries;        // 0x0

        // Methods
        private System.String GetOriginalName(System.Object value) { }
        private System.Collections.Generic.Dictionary<System.Object,System.String> GetNameMapping(System.Type enumType) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003E
    public class Settings
    {
        // Fields
        private static readonly Google.Protobuf.JsonParser.Settings <Default>k__BackingField;        // 0x0
        private readonly System.Int32 <RecursionLimit>k__BackingField;        // 0x10
        private readonly Google.Protobuf.Reflection.TypeRegistry <TypeRegistry>k__BackingField;        // 0x18
        private readonly System.Boolean <IgnoreUnknownFields>k__BackingField;        // 0x20

        // Methods
        private Google.Protobuf.JsonParser.Settings get_Default() { }
        private System.Void .cctor() { }
        private System.Int32 get_RecursionLimit() { }
        private Google.Protobuf.Reflection.TypeRegistry get_TypeRegistry() { }
        private System.Boolean get_IgnoreUnknownFields() { }
        private System.Void .ctor(System.Int32 recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry, System.Boolean ignoreUnknownFields) { }
        private System.Void .ctor(System.Int32 recursionLimit) { }
        private System.Void .ctor(System.Int32 recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry) { }
        private Google.Protobuf.JsonParser.Settings WithIgnoreUnknownFields(System.Boolean ignoreUnknownFields) { }
        private Google.Protobuf.JsonParser.Settings WithRecursionLimit(System.Int32 recursionLimit) { }
        private Google.Protobuf.JsonParser.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry) { }

    }

    // TypeToken: 0x2000041
    public struct TokenType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.JsonToken.TokenType Null;        // 0x0
        public static Google.Protobuf.JsonToken.TokenType False;        // 0x0
        public static Google.Protobuf.JsonToken.TokenType True;        // 0x0
        public static Google.Protobuf.JsonToken.TokenType StringValue;        // 0x0
        public static Google.Protobuf.JsonToken.TokenType Number;        // 0x0
        public static Google.Protobuf.JsonToken.TokenType Name;        // 0x0
        public static Google.Protobuf.JsonToken.TokenType StartObject;        // 0x0
        public static Google.Protobuf.JsonToken.TokenType EndObject;        // 0x0
        public static Google.Protobuf.JsonToken.TokenType StartArray;        // 0x0
        public static Google.Protobuf.JsonToken.TokenType EndArray;        // 0x0
        public static Google.Protobuf.JsonToken.TokenType EndDocument;        // 0x0

    }

    // TypeToken: 0x2000043
    public class JsonReplayTokenizer : JsonTokenizer
    {
        // Fields
        private readonly System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens;        // 0x20
        private readonly Google.Protobuf.JsonTokenizer nextTokenizer;        // 0x28
        private System.Int32 nextTokenIndex;        // 0x30

        // Methods
        private System.Void .ctor(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer nextTokenizer) { }
        private Google.Protobuf.JsonToken NextImpl() { }

    }

    // TypeToken: 0x2000045
    public struct ContainerType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType Document;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType Object;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType Array;        // 0x0

    }

    // TypeToken: 0x2000046
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State StartOfDocument;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ExpectedEndOfDocument;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ReaderExhausted;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ObjectStart;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ObjectBeforeColon;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ObjectAfterColon;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ObjectAfterProperty;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ObjectAfterComma;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ArrayStart;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ArrayAfterValue;        // 0x0
        public static Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ArrayAfterComma;        // 0x0

    }

    // TypeToken: 0x2000047
    public class PushBackReader
    {
        // Fields
        private readonly System.IO.TextReader reader;        // 0x10
        private System.Nullable<System.Char> nextChar;        // 0x18

        // Methods
        private System.Void .ctor(System.IO.TextReader reader) { }
        private System.Nullable<System.Char> Read() { }
        private System.Char ReadOrFail(System.String messageOnFailure) { }
        private System.Void PushBack(System.Char c) { }
        private Google.Protobuf.InvalidJsonException CreateException(System.String message) { }

    }

    // TypeToken: 0x2000044
    public class JsonTextTokenizer : JsonTokenizer
    {
        // Fields
        private static readonly Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ValueStates;        // 0x0
        private readonly System.Collections.Generic.Stack<Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType> containerStack;        // 0x20
        private readonly Google.Protobuf.JsonTokenizer.JsonTextTokenizer.PushBackReader reader;        // 0x28
        private Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State state;        // 0x30

        // Methods
        private System.Void .ctor(System.IO.TextReader reader) { }
        private Google.Protobuf.JsonToken NextImpl() { }
        private System.Void ValidateState(Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State validStates, System.String errorPrefix) { }
        private System.String ReadString() { }
        private System.Char ReadEscapedCharacter() { }
        private System.Char ReadUnicodeEscape() { }
        private System.Void ConsumeLiteral(System.String text) { }
        private System.Double ReadNumber(System.Char initialCharacter) { }
        private System.Nullable<System.Char> ReadInt(System.Text.StringBuilder builder) { }
        private System.Nullable<System.Char> ReadFrac(System.Text.StringBuilder builder) { }
        private System.Nullable<System.Char> ReadExp(System.Text.StringBuilder builder) { }
        private System.Nullable<System.Char> ConsumeDigits(System.Text.StringBuilder builder, System.Int32& count) { }
        private System.Void ValidateAndModifyStateForValue(System.String errorPrefix) { }
        private System.Void PopContainer() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005A
    public struct WireType
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static Google.Protobuf.WireFormat.WireType Varint;        // 0x0
        public static Google.Protobuf.WireFormat.WireType Fixed64;        // 0x0
        public static Google.Protobuf.WireFormat.WireType LengthDelimited;        // 0x0
        public static Google.Protobuf.WireFormat.WireType StartGroup;        // 0x0
        public static Google.Protobuf.WireFormat.WireType EndGroup;        // 0x0
        public static Google.Protobuf.WireFormat.WireType Fixed32;        // 0x0

    }

    // TypeToken: 0x2000072
    public class MergeOptions
    {
        // Fields
        private System.Boolean <ReplaceMessageFields>k__BackingField;        // 0x10
        private System.Boolean <ReplaceRepeatedFields>k__BackingField;        // 0x11
        private System.Boolean <ReplacePrimitiveFields>k__BackingField;        // 0x12

        // Methods
        private System.Boolean get_ReplaceMessageFields() { }
        private System.Void set_ReplaceMessageFields(System.Boolean value) { }
        private System.Boolean get_ReplaceRepeatedFields() { }
        private System.Void set_ReplaceRepeatedFields(System.Boolean value) { }
        private System.Boolean get_ReplacePrimitiveFields() { }
        private System.Void set_ReplacePrimitiveFields(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007C
    public struct KindOneofCase
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase None;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase NullValue;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase NumberValue;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase StringValue;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase BoolValue;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase StructValue;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Value.KindOneofCase ListValue;        // 0x0

    }

    // TypeToken: 0x200008A
    public struct Kind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeUnknown;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeDouble;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeFloat;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeInt64;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeUint64;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeInt32;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeFixed64;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeFixed32;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeBool;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeString;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeGroup;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeMessage;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeBytes;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeUint32;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeEnum;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeSfixed32;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeSfixed64;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeSint32;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Kind TypeSint64;        // 0x0

    }

    // TypeToken: 0x200008B
    public struct Cardinality
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.WellKnownTypes.Field.Types.Cardinality Unknown;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Cardinality Optional;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Cardinality Required;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Field.Types.Cardinality Repeated;        // 0x0

    }

    // TypeToken: 0x2000089
    public class Types
    {
    }

    // TypeToken: 0x20000AF
    public class ExtensionRange, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private System.Int32 _hasBits0;        // 0x18
        public static System.Int32 StartFieldNumber;        // 0x0
        private static readonly System.Int32 StartDefaultValue;        // 0x8
        private System.Int32 start_;        // 0x1C
        public static System.Int32 EndFieldNumber;        // 0x0
        private static readonly System.Int32 EndDefaultValue;        // 0xC
        private System.Int32 end_;        // 0x20
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private Google.Protobuf.Reflection.ExtensionRangeOptions options_;        // 0x28

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other) { }
        private Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange Clone() { }
        private System.Int32 get_Start() { }
        private System.Void set_Start(System.Int32 value) { }
        private System.Boolean get_HasStart() { }
        private System.Void ClearStart() { }
        private System.Int32 get_End() { }
        private System.Void set_End(System.Int32 value) { }
        private System.Boolean get_HasEnd() { }
        private System.Void ClearEnd() { }
        private Google.Protobuf.Reflection.ExtensionRangeOptions get_Options() { }
        private System.Void set_Options(Google.Protobuf.Reflection.ExtensionRangeOptions value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B1
    public class ReservedRange, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private System.Int32 _hasBits0;        // 0x18
        public static System.Int32 StartFieldNumber;        // 0x0
        private static readonly System.Int32 StartDefaultValue;        // 0x8
        private System.Int32 start_;        // 0x1C
        public static System.Int32 EndFieldNumber;        // 0x0
        private static readonly System.Int32 EndDefaultValue;        // 0xC
        private System.Int32 end_;        // 0x20

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other) { }
        private Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange Clone() { }
        private System.Int32 get_Start() { }
        private System.Void set_Start(System.Int32 value) { }
        private System.Boolean get_HasStart() { }
        private System.Void ClearStart() { }
        private System.Int32 get_End() { }
        private System.Void set_End(System.Int32 value) { }
        private System.Boolean get_HasEnd() { }
        private System.Void ClearEnd() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AE
    public class Types
    {
    }

    // TypeToken: 0x20000B8
    public struct Type
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Double;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Float;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Int64;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Uint64;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Int32;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Fixed64;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Fixed32;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Bool;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type String;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Group;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Message;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Bytes;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Uint32;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Enum;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Sfixed32;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Sfixed64;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Sint32;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Sint64;        // 0x0

    }

    // TypeToken: 0x20000B9
    public struct Label
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label Optional;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label Required;        // 0x0
        public static Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label Repeated;        // 0x0

    }

    // TypeToken: 0x20000B7
    public class Types
    {
    }

    // TypeToken: 0x20000BF
    public class EnumReservedRange, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private System.Int32 _hasBits0;        // 0x18
        public static System.Int32 StartFieldNumber;        // 0x0
        private static readonly System.Int32 StartDefaultValue;        // 0x8
        private System.Int32 start_;        // 0x1C
        public static System.Int32 EndFieldNumber;        // 0x0
        private static readonly System.Int32 EndDefaultValue;        // 0xC
        private System.Int32 end_;        // 0x20

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other) { }
        private Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange Clone() { }
        private System.Int32 get_Start() { }
        private System.Void set_Start(System.Int32 value) { }
        private System.Boolean get_HasStart() { }
        private System.Void ClearStart() { }
        private System.Int32 get_End() { }
        private System.Void set_End(System.Int32 value) { }
        private System.Boolean get_HasEnd() { }
        private System.Void ClearEnd() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BE
    public class Types
    {
    }

    // TypeToken: 0x20000CA
    public struct OptimizeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode Speed;        // 0x0
        public static Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode CodeSize;        // 0x0
        public static Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode LiteRuntime;        // 0x0

    }

    // TypeToken: 0x20000C9
    public class Types
    {
    }

    // TypeToken: 0x20000D0
    public struct CType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.Reflection.FieldOptions.Types.CType String;        // 0x0
        public static Google.Protobuf.Reflection.FieldOptions.Types.CType Cord;        // 0x0
        public static Google.Protobuf.Reflection.FieldOptions.Types.CType StringPiece;        // 0x0

    }

    // TypeToken: 0x20000D1
    public struct JSType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.Reflection.FieldOptions.Types.JSType JsNormal;        // 0x0
        public static Google.Protobuf.Reflection.FieldOptions.Types.JSType JsString;        // 0x0
        public static Google.Protobuf.Reflection.FieldOptions.Types.JSType JsNumber;        // 0x0

    }

    // TypeToken: 0x20000CF
    public class Types
    {
    }

    // TypeToken: 0x20000DD
    public struct IdempotencyLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel IdempotencyUnknown;        // 0x0
        public static Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel NoSideEffects;        // 0x0
        public static Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel Idempotent;        // 0x0

    }

    // TypeToken: 0x20000DC
    public class Types
    {
    }

    // TypeToken: 0x20000E1
    public class NamePart, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private System.Int32 _hasBits0;        // 0x18
        public static System.Int32 NamePart_FieldNumber;        // 0x0
        private static readonly System.String NamePart_DefaultValue;        // 0x8
        private System.String namePart_;        // 0x20
        public static System.Int32 IsExtensionFieldNumber;        // 0x0
        private static readonly System.Boolean IsExtensionDefaultValue;        // 0x10
        private System.Boolean isExtension_;        // 0x28

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other) { }
        private Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart Clone() { }
        private System.String get_NamePart_() { }
        private System.Void set_NamePart_(System.String value) { }
        private System.Boolean get_HasNamePart_() { }
        private System.Void ClearNamePart_() { }
        private System.Boolean get_IsExtension() { }
        private System.Void set_IsExtension(System.Boolean value) { }
        private System.Boolean get_HasIsExtension() { }
        private System.Void ClearIsExtension() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E0
    public class Types
    {
    }

    // TypeToken: 0x20000E6
    public class Location, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 PathFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<System.Int32> _repeated_path_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<System.Int32> path_;        // 0x18
        public static System.Int32 SpanFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<System.Int32> _repeated_span_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<System.Int32> span_;        // 0x20
        public static System.Int32 LeadingCommentsFieldNumber;        // 0x0
        private static readonly System.String LeadingCommentsDefaultValue;        // 0x18
        private System.String leadingComments_;        // 0x28
        public static System.Int32 TrailingCommentsFieldNumber;        // 0x0
        private static readonly System.String TrailingCommentsDefaultValue;        // 0x20
        private System.String trailingComments_;        // 0x30
        public static System.Int32 LeadingDetachedCommentsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_leadingDetachedComments_codec;        // 0x28
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> leadingDetachedComments_;        // 0x38

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other) { }
        private Google.Protobuf.Reflection.SourceCodeInfo.Types.Location Clone() { }
        private Google.Protobuf.Collections.RepeatedField<System.Int32> get_Path() { }
        private Google.Protobuf.Collections.RepeatedField<System.Int32> get_Span() { }
        private System.String get_LeadingComments() { }
        private System.Void set_LeadingComments(System.String value) { }
        private System.Boolean get_HasLeadingComments() { }
        private System.Void ClearLeadingComments() { }
        private System.String get_TrailingComments() { }
        private System.Void set_TrailingComments(System.String value) { }
        private System.Boolean get_HasTrailingComments() { }
        private System.Void ClearTrailingComments() { }
        private Google.Protobuf.Collections.RepeatedField<System.String> get_LeadingDetachedComments() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E5
    public class Types
    {
    }

    // TypeToken: 0x20000EB
    public class Annotation, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private System.Int32 _hasBits0;        // 0x18
        public static System.Int32 PathFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<System.Int32> _repeated_path_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<System.Int32> path_;        // 0x20
        public static System.Int32 SourceFileFieldNumber;        // 0x0
        private static readonly System.String SourceFileDefaultValue;        // 0x10
        private System.String sourceFile_;        // 0x28
        public static System.Int32 BeginFieldNumber;        // 0x0
        private static readonly System.Int32 BeginDefaultValue;        // 0x18
        private System.Int32 begin_;        // 0x30
        public static System.Int32 EndFieldNumber;        // 0x0
        private static readonly System.Int32 EndDefaultValue;        // 0x1C
        private System.Int32 end_;        // 0x34

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other) { }
        private Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation Clone() { }
        private Google.Protobuf.Collections.RepeatedField<System.Int32> get_Path() { }
        private System.String get_SourceFile() { }
        private System.Void set_SourceFile(System.String value) { }
        private System.Boolean get_HasSourceFile() { }
        private System.Void ClearSourceFile() { }
        private System.Int32 get_Begin() { }
        private System.Void set_Begin(System.Int32 value) { }
        private System.Boolean get_HasBegin() { }
        private System.Void ClearBegin() { }
        private System.Int32 get_End() { }
        private System.Void set_End(System.Int32 value) { }
        private System.Boolean get_HasEnd() { }
        private System.Void ClearEnd() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000EA
    public class Types
    {
    }

    // TypeToken: 0x20000F2
    public class IndexedConverter`2 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TOutput Invoke(TInput element, System.Int32 index) { }
        private System.IAsyncResult BeginInvoke(TInput element, System.Int32 index, System.AsyncCallback callback, System.Object object) { }
        private TOutput EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000108
    public class FieldCollection
    {
        // Fields
        private readonly Google.Protobuf.Reflection.MessageDescriptor messageDescriptor;        // 0x10

        // Methods
        private System.Void .ctor(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor) { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InDeclarationOrder() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InFieldNumberOrder() { }
        private System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor> ByJsonName() { }
        private Google.Protobuf.Reflection.FieldDescriptor get_Item(System.Int32 number) { }
        private Google.Protobuf.Reflection.FieldDescriptor get_Item(System.String name) { }

    }

    // TypeToken: 0x2000113
    public interface IReflectionHelper
    {
        // Methods
        private System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method) { }
        private System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method) { }
        private System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method) { }
        private System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method) { }
        private System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method) { }

    }

    // TypeToken: 0x2000114
    public interface IExtensionReflectionHelper
    {
        // Methods
        private System.Object GetExtension(Google.Protobuf.IMessage message) { }
        private System.Void SetExtension(Google.Protobuf.IMessage message, System.Object value) { }
        private System.Boolean HasExtension(Google.Protobuf.IMessage message) { }
        private System.Void ClearExtension(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x2000115
    public interface IExtensionSetReflector
    {
        // Methods
        private System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller() { }

    }

    // TypeToken: 0x2000116
    public class ReflectionHelper`2, IReflectionHelper
    {
        // Methods
        private System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method) { }
        private System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method) { }
        private System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method) { }
        private System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method) { }
        private System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011D
    public class ExtensionReflectionHelper`2, IExtensionReflectionHelper
    {
        // Fields
        private readonly Google.Protobuf.Extension extension;        // 0x0

        // Methods
        private System.Void .ctor(Google.Protobuf.Extension extension) { }
        private System.Object GetExtension(Google.Protobuf.IMessage message) { }
        private System.Boolean HasExtension(Google.Protobuf.IMessage message) { }
        private System.Void SetExtension(Google.Protobuf.IMessage message, System.Object value) { }
        private System.Void ClearExtension(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x200011E
    public class ExtensionSetReflector`1, IExtensionSetReflector
    {
        // Methods
        private System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000120
    public struct SampleEnum
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.Reflection.ReflectionUtil.SampleEnum X;        // 0x0

    }

    // TypeToken: 0x200012A
    public class Builder
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor> types;        // 0x10
        private readonly System.Collections.Generic.HashSet<System.String> fileDescriptorNames;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void AddFile(Google.Protobuf.Reflection.FileDescriptor fileDescriptor) { }
        private System.Void AddMessage(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor) { }
        private Google.Protobuf.Reflection.TypeRegistry Build() { }

    }

    // TypeToken: 0x2000130
    public class DictionaryEnumerator, IDictionaryEnumerator, IEnumerator
    {
        // Fields
        private readonly System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> enumerator;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> enumerator) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Object get_Current() { }
        private System.Collections.DictionaryEntry get_Entry() { }
        private System.Object get_Key() { }
        private System.Object get_Value() { }

    }

    // TypeToken: 0x2000131
    public class Codec
    {
        // Fields
        private readonly Google.Protobuf.FieldCodec<TKey> keyCodec;        // 0x0
        private readonly Google.Protobuf.FieldCodec<TValue> valueCodec;        // 0x0
        private readonly System.UInt32 mapTag;        // 0x0

        // Methods
        private System.Void .ctor(Google.Protobuf.FieldCodec<TKey> keyCodec, Google.Protobuf.FieldCodec<TValue> valueCodec, System.UInt32 mapTag) { }
        private Google.Protobuf.FieldCodec<TKey> get_KeyCodec() { }
        private Google.Protobuf.FieldCodec<TValue> get_ValueCodec() { }
        private System.UInt32 get_MapTag() { }

    }

    // TypeToken: 0x2000132
    public class MapView`1, ICollection`1, IEnumerable`1, IEnumerable, ICollection
    {
        // Fields
        private readonly Google.Protobuf.Collections.MapField<TKey,TValue> parent;        // 0x0
        private readonly System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,T> projection;        // 0x0
        private readonly System.Func<T,System.Boolean> containsCheck;        // 0x0

        // Methods
        private System.Void .ctor(Google.Protobuf.Collections.MapField<TKey,TValue> parent, System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,T> projection, System.Func<T,System.Boolean> containsCheck) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean get_IsSynchronized() { }
        private System.Object get_SyncRoot() { }
        private System.Void Add(T item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(T item) { }
        private System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Boolean Remove(T item) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void CopyTo(System.Array array, System.Int32 index) { }

    }

    // TypeToken: 0x2000136
    public class BitwiseDoubleEqualityComparerImpl : EqualityComparer`1
    {
        // Methods
        private System.Boolean Equals(System.Double x, System.Double y) { }
        private System.Int32 GetHashCode(System.Double obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000137
    public class BitwiseSingleEqualityComparerImpl : EqualityComparer`1
    {
        // Methods
        private System.Boolean Equals(System.Single x, System.Single y) { }
        private System.Int32 GetHashCode(System.Single obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000138
    public class BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer`1
    {
        // Methods
        private System.Boolean Equals(System.Nullable<System.Double> x, System.Nullable<System.Double> y) { }
        private System.Int32 GetHashCode(System.Nullable<System.Double> obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000139
    public class BitwiseNullableSingleEqualityComparerImpl : EqualityComparer`1
    {
        // Methods
        private System.Boolean Equals(System.Nullable<System.Single> x, System.Nullable<System.Single> y) { }
        private System.Int32 GetHashCode(System.Nullable<System.Single> obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013E
    public struct __StaticArrayInitTypeSize=44
    {
    }

namespace Google.Protobuf
{

    // TypeToken: 0x2000006
    public class ByteArray
    {
        // Fields
        private static System.Int32 CopyThreshold;        // 0x0

        // Methods
        private System.Void Copy(System.Byte[] src, System.Int32 srcOffset, System.Byte[] dst, System.Int32 dstOffset, System.Int32 count) { }
        private System.Void Reverse(System.Byte[] bytes) { }

    }

    // TypeToken: 0x2000007
    public class ByteString, IEnumerable`1, IEnumerable, IEquatable`1
    {
        // Fields
        private static readonly Google.Protobuf.ByteString empty;        // 0x0
        private readonly System.ReadOnlyMemory<System.Byte> bytes;        // 0x10

        // Methods
        private Google.Protobuf.ByteString AttachBytes(System.ReadOnlyMemory<System.Byte> bytes) { }
        private Google.Protobuf.ByteString AttachBytes(System.Byte[] bytes) { }
        private System.Void .ctor(System.ReadOnlyMemory<System.Byte> bytes) { }
        private Google.Protobuf.ByteString get_Empty() { }
        private System.Int32 get_Length() { }
        private System.Boolean get_IsEmpty() { }
        private System.ReadOnlySpan<System.Byte> get_Span() { }
        private System.ReadOnlyMemory<System.Byte> get_Memory() { }
        private System.Byte[] ToByteArray() { }
        private System.String ToBase64() { }
        private Google.Protobuf.ByteString FromBase64(System.String bytes) { }
        private Google.Protobuf.ByteString FromStream(System.IO.Stream stream) { }
        private System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { }
        private Google.Protobuf.ByteString CopyFrom(System.Byte[] bytes) { }
        private Google.Protobuf.ByteString CopyFrom(System.Byte[] bytes, System.Int32 offset, System.Int32 count) { }
        private Google.Protobuf.ByteString CopyFrom(System.ReadOnlySpan<System.Byte> bytes) { }
        private Google.Protobuf.ByteString CopyFrom(System.String text, System.Text.Encoding encoding) { }
        private Google.Protobuf.ByteString CopyFromUtf8(System.String text) { }
        private System.Byte get_Item(System.Int32 index) { }
        private System.String ToString(System.Text.Encoding encoding) { }
        private System.String ToStringUtf8() { }
        private System.Collections.Generic.IEnumerator<System.Byte> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private Google.Protobuf.CodedInputStream CreateCodedInput() { }
        private System.Boolean op_Equality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs) { }
        private System.Boolean op_Inequality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(Google.Protobuf.ByteString other) { }
        private System.Void CopyTo(System.Byte[] array, System.Int32 position) { }
        private System.Void WriteTo(System.IO.Stream outputStream) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000008
    public class ByteStringAsync
    {
        // Methods
        private System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsyncCore(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken) { }

    }

    // TypeToken: 0x200000A
    public class CodedInputStream, IDisposable
    {
        // Fields
        private readonly System.Boolean leaveOpen;        // 0x10
        private readonly System.Byte[] buffer;        // 0x18
        private readonly System.IO.Stream input;        // 0x20
        private Google.Protobuf.ParserInternalState state;        // 0x28
        private static System.Int32 DefaultRecursionLimit;        // 0x0
        private static System.Int32 DefaultSizeLimit;        // 0x0
        private static System.Int32 BufferSize;        // 0x0

        // Methods
        private System.Void .ctor(System.Byte[] buffer) { }
        private System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 length) { }
        private System.Void .ctor(System.IO.Stream input) { }
        private System.Void .ctor(System.IO.Stream input, System.Boolean leaveOpen) { }
        private System.Void .ctor(System.IO.Stream input, System.Byte[] buffer, System.Int32 bufferPos, System.Int32 bufferSize, System.Boolean leaveOpen) { }
        private System.Void .ctor(System.IO.Stream input, System.Byte[] buffer, System.Int32 bufferPos, System.Int32 bufferSize, System.Int32 sizeLimit, System.Int32 recursionLimit, System.Boolean leaveOpen) { }
        private Google.Protobuf.CodedInputStream CreateWithLimits(System.IO.Stream input, System.Int32 sizeLimit, System.Int32 recursionLimit) { }
        private System.Int64 get_Position() { }
        private System.UInt32 get_LastTag() { }
        private System.Int32 get_SizeLimit() { }
        private System.Int32 get_RecursionLimit() { }
        private System.Boolean get_DiscardUnknownFields() { }
        private System.Void set_DiscardUnknownFields(System.Boolean value) { }
        private Google.Protobuf.ExtensionRegistry get_ExtensionRegistry() { }
        private System.Void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value) { }
        private System.Byte[] get_InternalBuffer() { }
        private System.IO.Stream get_InternalInputStream() { }
        private Google.Protobuf.ParserInternalState& get_InternalState() { }
        private System.Void Dispose() { }
        private System.Void CheckReadEndOfStreamTag() { }
        private System.UInt32 PeekTag() { }
        private System.UInt32 ReadTag() { }
        private System.Void SkipLastField() { }
        private System.Void SkipGroup(System.UInt32 startGroupTag) { }
        private System.Double ReadDouble() { }
        private System.Single ReadFloat() { }
        private System.UInt64 ReadUInt64() { }
        private System.Int64 ReadInt64() { }
        private System.Int32 ReadInt32() { }
        private System.UInt64 ReadFixed64() { }
        private System.UInt32 ReadFixed32() { }
        private System.Boolean ReadBool() { }
        private System.String ReadString() { }
        private System.Void ReadMessage(Google.Protobuf.IMessage builder) { }
        private System.Void ReadGroup(Google.Protobuf.IMessage builder) { }
        private Google.Protobuf.ByteString ReadBytes() { }
        private System.UInt32 ReadUInt32() { }
        private System.Int32 ReadEnum() { }
        private System.Int32 ReadSFixed32() { }
        private System.Int64 ReadSFixed64() { }
        private System.Int32 ReadSInt32() { }
        private System.Int64 ReadSInt64() { }
        private System.Int32 ReadLength() { }
        private System.Boolean MaybeConsumeTag(System.UInt32 tag) { }
        private System.UInt32 ReadRawVarint32() { }
        private System.UInt32 ReadRawVarint32(System.IO.Stream input) { }
        private System.UInt64 ReadRawVarint64() { }
        private System.UInt32 ReadRawLittleEndian32() { }
        private System.UInt64 ReadRawLittleEndian64() { }
        private System.Int32 PushLimit(System.Int32 byteLimit) { }
        private System.Void PopLimit(System.Int32 oldLimit) { }
        private System.Boolean get_ReachedLimit() { }
        private System.Boolean get_IsAtEnd() { }
        private System.Boolean RefillBuffer(System.Boolean mustSucceed) { }
        private System.Byte[] ReadRawBytes(System.Int32 size) { }
        private System.Void ReadRawMessage(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x200000B
    public class CodedOutputStream, IDisposable
    {
        // Fields
        private static System.Int32 LittleEndian64Size;        // 0x0
        private static System.Int32 LittleEndian32Size;        // 0x0
        private static System.Int32 DoubleSize;        // 0x0
        private static System.Int32 FloatSize;        // 0x0
        private static System.Int32 BoolSize;        // 0x0
        public static readonly System.Int32 DefaultBufferSize;        // 0x0
        private readonly System.Boolean leaveOpen;        // 0x10
        private readonly System.Byte[] buffer;        // 0x18
        private Google.Protobuf.WriterInternalState state;        // 0x20
        private readonly System.IO.Stream output;        // 0x38

        // Methods
        private System.Int32 ComputeDoubleSize(System.Double value) { }
        private System.Int32 ComputeFloatSize(System.Single value) { }
        private System.Int32 ComputeUInt64Size(System.UInt64 value) { }
        private System.Int32 ComputeInt64Size(System.Int64 value) { }
        private System.Int32 ComputeInt32Size(System.Int32 value) { }
        private System.Int32 ComputeFixed64Size(System.UInt64 value) { }
        private System.Int32 ComputeFixed32Size(System.UInt32 value) { }
        private System.Int32 ComputeBoolSize(System.Boolean value) { }
        private System.Int32 ComputeStringSize(System.String value) { }
        private System.Int32 ComputeGroupSize(Google.Protobuf.IMessage value) { }
        private System.Int32 ComputeMessageSize(Google.Protobuf.IMessage value) { }
        private System.Int32 ComputeBytesSize(Google.Protobuf.ByteString value) { }
        private System.Int32 ComputeUInt32Size(System.UInt32 value) { }
        private System.Int32 ComputeEnumSize(System.Int32 value) { }
        private System.Int32 ComputeSFixed32Size(System.Int32 value) { }
        private System.Int32 ComputeSFixed64Size(System.Int64 value) { }
        private System.Int32 ComputeSInt32Size(System.Int32 value) { }
        private System.Int32 ComputeSInt64Size(System.Int64 value) { }
        private System.Int32 ComputeLengthSize(System.Int32 length) { }
        private System.Int32 ComputeRawVarint32Size(System.UInt32 value) { }
        private System.Int32 ComputeRawVarint64Size(System.UInt64 value) { }
        private System.Int32 ComputeTagSize(System.Int32 fieldNumber) { }
        private System.Void .ctor(System.Byte[] flatArray) { }
        private System.Void .ctor(System.Byte[] buffer, System.Int32 offset, System.Int32 length) { }
        private System.Void .ctor(System.IO.Stream output, System.Byte[] buffer, System.Boolean leaveOpen) { }
        private System.Void .ctor(System.IO.Stream output) { }
        private System.Void .ctor(System.IO.Stream output, System.Int32 bufferSize) { }
        private System.Void .ctor(System.IO.Stream output, System.Boolean leaveOpen) { }
        private System.Void .ctor(System.IO.Stream output, System.Int32 bufferSize, System.Boolean leaveOpen) { }
        private System.Int64 get_Position() { }
        private System.Int32 get_NonOutputPosition() { }
        private System.Void WriteDouble(System.Double value) { }
        private System.Void WriteFloat(System.Single value) { }
        private System.Void WriteUInt64(System.UInt64 value) { }
        private System.Void WriteInt64(System.Int64 value) { }
        private System.Void WriteInt32(System.Int32 value) { }
        private System.Void WriteFixed64(System.UInt64 value) { }
        private System.Void WriteFixed32(System.UInt32 value) { }
        private System.Void WriteBool(System.Boolean value) { }
        private System.Void WriteString(System.String value) { }
        private System.Void WriteMessage(Google.Protobuf.IMessage value) { }
        private System.Void WriteRawMessage(Google.Protobuf.IMessage value) { }
        private System.Void WriteGroup(Google.Protobuf.IMessage value) { }
        private System.Void WriteBytes(Google.Protobuf.ByteString value) { }
        private System.Void WriteUInt32(System.UInt32 value) { }
        private System.Void WriteEnum(System.Int32 value) { }
        private System.Void WriteSFixed32(System.Int32 value) { }
        private System.Void WriteSFixed64(System.Int64 value) { }
        private System.Void WriteSInt32(System.Int32 value) { }
        private System.Void WriteSInt64(System.Int64 value) { }
        private System.Void WriteLength(System.Int32 length) { }
        private System.Void WriteTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type) { }
        private System.Void WriteTag(System.UInt32 tag) { }
        private System.Void WriteRawTag(System.Byte b1) { }
        private System.Void WriteRawTag(System.Byte b1, System.Byte b2) { }
        private System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3) { }
        private System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4) { }
        private System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5) { }
        private System.Void WriteRawVarint32(System.UInt32 value) { }
        private System.Void WriteRawVarint64(System.UInt64 value) { }
        private System.Void WriteRawLittleEndian32(System.UInt32 value) { }
        private System.Void WriteRawLittleEndian64(System.UInt64 value) { }
        private System.Void WriteRawBytes(System.Byte[] value) { }
        private System.Void WriteRawBytes(System.Byte[] value, System.Int32 offset, System.Int32 length) { }
        private System.Void Dispose() { }
        private System.Void Flush() { }
        private System.Void CheckNoSpaceLeft() { }
        private System.Int32 get_SpaceLeft() { }
        private System.Byte[] get_InternalBuffer() { }
        private System.IO.Stream get_InternalOutputStream() { }
        private Google.Protobuf.WriterInternalState& get_InternalState() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public class Extension
    {
        // Fields
        private readonly System.Int32 <FieldNumber>k__BackingField;        // 0x10

        // Methods
        private System.Type get_TargetType() { }
        private System.Void .ctor(System.Int32 fieldNumber) { }
        private Google.Protobuf.IExtensionValue CreateValue() { }
        private System.Int32 get_FieldNumber() { }
        private System.Boolean get_IsRepeated() { }

    }

    // TypeToken: 0x200000E
    public class Extension`2 : Extension
    {
        // Fields
        private readonly Google.Protobuf.FieldCodec<TValue> codec;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 fieldNumber, Google.Protobuf.FieldCodec<TValue> codec) { }
        private TValue get_DefaultValue() { }
        private System.Type get_TargetType() { }
        private System.Boolean get_IsRepeated() { }
        private Google.Protobuf.IExtensionValue CreateValue() { }

    }

    // TypeToken: 0x200000F
    public class RepeatedExtension`2 : Extension
    {
        // Fields
        private readonly Google.Protobuf.FieldCodec<TValue> codec;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 fieldNumber, Google.Protobuf.FieldCodec<TValue> codec) { }
        private System.Type get_TargetType() { }
        private System.Boolean get_IsRepeated() { }
        private Google.Protobuf.IExtensionValue CreateValue() { }

    }

    // TypeToken: 0x2000010
    public class ExtensionRegistry, ICollection`1, IEnumerable`1, IEnumerable, IDeepCloneable`1
    {
        // Fields
        private System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension> extensions;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>,Google.Protobuf.Extension> collection) { }
        private System.Int32 get_Count() { }
        private System.Boolean System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly() { }
        private System.Boolean ContainsInputField(System.UInt32 lastTag, System.Type target, Google.Protobuf.Extension& extension) { }
        private System.Void Add(Google.Protobuf.Extension extension) { }
        private System.Void AddRange(System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> extensions) { }
        private System.Void Clear() { }
        private System.Boolean Contains(Google.Protobuf.Extension item) { }
        private System.Void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(Google.Protobuf.Extension[] array, System.Int32 arrayIndex) { }
        private System.Collections.Generic.IEnumerator<Google.Protobuf.Extension> GetEnumerator() { }
        private System.Boolean Remove(Google.Protobuf.Extension item) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private Google.Protobuf.ExtensionRegistry Clone() { }

    }

    // TypeToken: 0x2000013
    public class ExtensionSet
    {
        // Methods
        private System.Boolean TryGetValue(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension extension, Google.Protobuf.IExtensionValue& value) { }
        private TValue Get(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> Get(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitialize(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension) { }
        private System.Void Set(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension, TValue value) { }
        private System.Boolean Has(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension) { }
        private System.Void Clear(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.Extension<TTarget,TValue> extension) { }
        private System.Void Clear(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.RepeatedExtension<TTarget,TValue> extension) { }
        private System.Boolean TryMergeFieldFrom(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.CodedInputStream stream) { }
        private System.Boolean TryMergeFieldFrom(Google.Protobuf.ExtensionSet<TTarget>& set, Google.Protobuf.ParseContext& ctx) { }
        private System.Void MergeFrom(Google.Protobuf.ExtensionSet<TTarget>& first, Google.Protobuf.ExtensionSet<TTarget> second) { }
        private Google.Protobuf.ExtensionSet<TTarget> Clone(Google.Protobuf.ExtensionSet<TTarget> set) { }

    }

    // TypeToken: 0x2000014
    public class ExtensionSet`1
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Int32,Google.Protobuf.IExtensionValue> <ValuesByNumber>k__BackingField;        // 0x0

        // Methods
        private System.Collections.Generic.Dictionary<System.Int32,Google.Protobuf.IExtensionValue> get_ValuesByNumber() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Int32 CalculateSize() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream stream) { }
        private System.Void WriteTo(Google.Protobuf.WriteContext& ctx) { }
        private System.Boolean IsInitialized() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public interface IExtensionValue : IEquatable`1, IDeepCloneable`1
    {
        // Methods
        private System.Void MergeFrom(Google.Protobuf.ParseContext& ctx) { }
        private System.Void MergeFrom(Google.Protobuf.IExtensionValue value) { }
        private System.Void WriteTo(Google.Protobuf.WriteContext& ctx) { }
        private System.Int32 CalculateSize() { }
        private System.Boolean IsInitialized() { }
        private System.Object GetValue() { }

    }

    // TypeToken: 0x2000017
    public class ExtensionValue`1, IExtensionValue, IEquatable`1, IDeepCloneable`1
    {
        // Fields
        private T field;        // 0x0
        private Google.Protobuf.FieldCodec<T> codec;        // 0x0

        // Methods
        private System.Void .ctor(Google.Protobuf.FieldCodec<T> codec) { }
        private System.Int32 CalculateSize() { }
        private Google.Protobuf.IExtensionValue Clone() { }
        private System.Boolean Equals(Google.Protobuf.IExtensionValue other) { }
        private System.Int32 GetHashCode() { }
        private System.Void MergeFrom(Google.Protobuf.ParseContext& ctx) { }
        private System.Void MergeFrom(Google.Protobuf.IExtensionValue value) { }
        private System.Void WriteTo(Google.Protobuf.WriteContext& ctx) { }
        private T GetValue() { }
        private System.Object Google.Protobuf.IExtensionValue.GetValue() { }
        private System.Void SetValue(T value) { }
        private System.Boolean IsInitialized() { }

    }

    // TypeToken: 0x2000018
    public class RepeatedExtensionValue`1, IExtensionValue, IEquatable`1, IDeepCloneable`1
    {
        // Fields
        private Google.Protobuf.Collections.RepeatedField<T> field;        // 0x0
        private readonly Google.Protobuf.FieldCodec<T> codec;        // 0x0

        // Methods
        private System.Void .ctor(Google.Protobuf.FieldCodec<T> codec) { }
        private System.Int32 CalculateSize() { }
        private Google.Protobuf.IExtensionValue Clone() { }
        private System.Boolean Equals(Google.Protobuf.IExtensionValue other) { }
        private System.Int32 GetHashCode() { }
        private System.Void MergeFrom(Google.Protobuf.ParseContext& ctx) { }
        private System.Void MergeFrom(Google.Protobuf.IExtensionValue value) { }
        private System.Void WriteTo(Google.Protobuf.WriteContext& ctx) { }
        private Google.Protobuf.Collections.RepeatedField<T> GetValue() { }
        private System.Object Google.Protobuf.IExtensionValue.GetValue() { }
        private System.Boolean IsInitialized() { }

    }

    // TypeToken: 0x2000019
    public class FieldCodec
    {
        // Methods
        private Google.Protobuf.FieldCodec<System.String> ForString(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.Boolean> ForBool(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.Int32> ForInt32(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.Int32> ForSInt32(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.UInt32> ForFixed32(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.Int32> ForSFixed32(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.UInt32> ForUInt32(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.Int64> ForInt64(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.Int64> ForSInt64(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.UInt64> ForFixed64(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.Int64> ForSFixed64(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.UInt64> ForUInt64(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.Single> ForFloat(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.Double> ForDouble(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<T> ForEnum(System.UInt32 tag, System.Func<T,System.Int32> toInt32, System.Func<System.Int32,T> fromInt32) { }
        private Google.Protobuf.FieldCodec<System.String> ForString(System.UInt32 tag, System.String defaultValue) { }
        private Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(System.UInt32 tag, Google.Protobuf.ByteString defaultValue) { }
        private Google.Protobuf.FieldCodec<System.Boolean> ForBool(System.UInt32 tag, System.Boolean defaultValue) { }
        private Google.Protobuf.FieldCodec<System.Int32> ForInt32(System.UInt32 tag, System.Int32 defaultValue) { }
        private Google.Protobuf.FieldCodec<System.Int32> ForSInt32(System.UInt32 tag, System.Int32 defaultValue) { }
        private Google.Protobuf.FieldCodec<System.UInt32> ForFixed32(System.UInt32 tag, System.UInt32 defaultValue) { }
        private Google.Protobuf.FieldCodec<System.Int32> ForSFixed32(System.UInt32 tag, System.Int32 defaultValue) { }
        private Google.Protobuf.FieldCodec<System.UInt32> ForUInt32(System.UInt32 tag, System.UInt32 defaultValue) { }
        private Google.Protobuf.FieldCodec<System.Int64> ForInt64(System.UInt32 tag, System.Int64 defaultValue) { }
        private Google.Protobuf.FieldCodec<System.Int64> ForSInt64(System.UInt32 tag, System.Int64 defaultValue) { }
        private Google.Protobuf.FieldCodec<System.UInt64> ForFixed64(System.UInt32 tag, System.UInt64 defaultValue) { }
        private Google.Protobuf.FieldCodec<System.Int64> ForSFixed64(System.UInt32 tag, System.Int64 defaultValue) { }
        private Google.Protobuf.FieldCodec<System.UInt64> ForUInt64(System.UInt32 tag, System.UInt64 defaultValue) { }
        private Google.Protobuf.FieldCodec<System.Single> ForFloat(System.UInt32 tag, System.Single defaultValue) { }
        private Google.Protobuf.FieldCodec<System.Double> ForDouble(System.UInt32 tag, System.Double defaultValue) { }
        private Google.Protobuf.FieldCodec<T> ForEnum(System.UInt32 tag, System.Func<T,System.Int32> toInt32, System.Func<System.Int32,T> fromInt32, T defaultValue) { }
        private Google.Protobuf.FieldCodec<T> ForMessage(System.UInt32 tag, Google.Protobuf.MessageParser<T> parser) { }
        private Google.Protobuf.FieldCodec<T> ForGroup(System.UInt32 startTag, System.UInt32 endTag, Google.Protobuf.MessageParser<T> parser) { }
        private Google.Protobuf.FieldCodec<T> ForClassWrapper(System.UInt32 tag) { }
        private Google.Protobuf.FieldCodec<System.Nullable<T>> ForStructWrapper(System.UInt32 tag) { }

    }

    // TypeToken: 0x2000026
    public class ValueReader`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TValue Invoke(Google.Protobuf.ParseContext& ctx) { }
        private System.IAsyncResult BeginInvoke(Google.Protobuf.ParseContext& ctx, System.AsyncCallback callback, System.Object object) { }
        private TValue EndInvoke(Google.Protobuf.ParseContext& ctx, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000027
    public class ValueWriter`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Google.Protobuf.WriteContext& ctx, T value) { }
        private System.IAsyncResult BeginInvoke(Google.Protobuf.WriteContext& ctx, T value, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(Google.Protobuf.WriteContext& ctx, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000028
    public class FieldCodec`1
    {
        // Fields
        private static readonly System.Collections.Generic.EqualityComparer<T> EqualityComparer;        // 0x0
        private static readonly T DefaultDefault;        // 0x0
        private static readonly System.Boolean TypeSupportsPacking;        // 0x0
        private readonly System.Boolean <PackedRepeatedField>k__BackingField;        // 0x0
        private readonly Google.Protobuf.ValueWriter<T> <ValueWriter>k__BackingField;        // 0x0
        private readonly System.Func<T,System.Int32> <ValueSizeCalculator>k__BackingField;        // 0x0
        private readonly Google.Protobuf.ValueReader<T> <ValueReader>k__BackingField;        // 0x0
        private readonly Google.Protobuf.FieldCodec.InputMerger<T> <ValueMerger>k__BackingField;        // 0x0
        private readonly Google.Protobuf.FieldCodec.ValuesMerger<T> <FieldMerger>k__BackingField;        // 0x0
        private readonly System.Int32 <FixedSize>k__BackingField;        // 0x0
        private readonly System.UInt32 <Tag>k__BackingField;        // 0x0
        private readonly System.UInt32 <EndTag>k__BackingField;        // 0x0
        private readonly T <DefaultValue>k__BackingField;        // 0x0
        private readonly System.Int32 tagSize;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Boolean IsPackedRepeatedField(System.UInt32 tag) { }
        private System.Boolean get_PackedRepeatedField() { }
        private Google.Protobuf.ValueWriter<T> get_ValueWriter() { }
        private System.Func<T,System.Int32> get_ValueSizeCalculator() { }
        private Google.Protobuf.ValueReader<T> get_ValueReader() { }
        private Google.Protobuf.FieldCodec.InputMerger<T> get_ValueMerger() { }
        private Google.Protobuf.FieldCodec.ValuesMerger<T> get_FieldMerger() { }
        private System.Int32 get_FixedSize() { }
        private System.UInt32 get_Tag() { }
        private System.UInt32 get_EndTag() { }
        private T get_DefaultValue() { }
        private System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, System.Int32 fixedSize, System.UInt32 tag, T defaultValue) { }
        private System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, T defaultValue) { }
        private System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, System.UInt32 endTag) { }
        private System.Void .ctor(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T,System.Int32> sizeCalculator, System.UInt32 tag, System.UInt32 endTag, T defaultValue) { }
        private System.Void WriteTagAndValue(Google.Protobuf.CodedOutputStream output, T value) { }
        private System.Void WriteTagAndValue(Google.Protobuf.WriteContext& ctx, T value) { }
        private T Read(Google.Protobuf.CodedInputStream input) { }
        private T Read(Google.Protobuf.ParseContext& ctx) { }
        private System.Int32 CalculateSizeWithTag(T value) { }
        private System.Int32 CalculateUnconditionalSizeWithTag(T value) { }
        private System.Boolean IsDefault(T value) { }

    }

    // TypeToken: 0x200002E
    public class FieldMaskTree
    {
        // Fields
        private static System.Char FIELD_PATH_SEPARATOR;        // 0x0
        private readonly Google.Protobuf.FieldMaskTree.Node root;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.FieldMask mask) { }
        private System.String ToString() { }
        private Google.Protobuf.FieldMaskTree AddFieldPath(System.String path) { }
        private Google.Protobuf.FieldMaskTree MergeFromFieldMask(Google.Protobuf.WellKnownTypes.FieldMask mask) { }
        private Google.Protobuf.WellKnownTypes.FieldMask ToFieldMask() { }
        private System.Void GetFieldPaths(Google.Protobuf.FieldMaskTree.Node node, System.String path, System.Collections.Generic.List<System.String> paths) { }
        private System.Void IntersectFieldPath(System.String path, Google.Protobuf.FieldMaskTree output) { }
        private System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options) { }
        private System.Void Merge(Google.Protobuf.FieldMaskTree.Node node, System.String path, Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options) { }

    }

    // TypeToken: 0x2000030
    public class FrameworkPortability
    {
        // Fields
        private static readonly System.Text.RegularExpressions.RegexOptions CompiledRegexWhereAvailable;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000031
    public interface IBufferMessage : IMessage
    {
        // Methods
        private System.Void InternalMergeFrom(Google.Protobuf.ParseContext& ctx) { }
        private System.Void InternalWriteTo(Google.Protobuf.WriteContext& ctx) { }

    }

    // TypeToken: 0x2000032
    public interface ICustomDiagnosticMessage : IMessage
    {
        // Methods
        private System.String ToDiagnosticString() { }

    }

    // TypeToken: 0x2000033
    public interface IDeepCloneable`1
    {
        // Methods
        private T Clone() { }

    }

    // TypeToken: 0x2000034
    public interface IExtendableMessage`1 : IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1
    {
        // Methods
        private TValue GetExtension(Google.Protobuf.Extension<T,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension) { }
        private System.Void SetExtension(Google.Protobuf.Extension<T,TValue> extension, TValue value) { }
        private System.Boolean HasExtension(Google.Protobuf.Extension<T,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.Extension<T,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.RepeatedExtension<T,TValue> extension) { }

    }

    // TypeToken: 0x2000035
    public interface IMessage
    {
        // Methods
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Int32 CalculateSize() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }

    }

    // TypeToken: 0x2000036
    public interface IMessage`1 : IMessage, IEquatable`1, IDeepCloneable`1
    {
        // Methods
        private System.Void MergeFrom(T message) { }

    }

    // TypeToken: 0x2000037
    public class InvalidJsonException : IOException
    {
        // Methods
        private System.Void .ctor(System.String message) { }

    }

    // TypeToken: 0x2000038
    public class InvalidProtocolBufferException : IOException
    {
        // Methods
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private Google.Protobuf.InvalidProtocolBufferException MoreDataAvailable() { }
        private Google.Protobuf.InvalidProtocolBufferException TruncatedMessage() { }
        private Google.Protobuf.InvalidProtocolBufferException NegativeSize() { }
        private Google.Protobuf.InvalidProtocolBufferException MalformedVarint() { }
        private Google.Protobuf.InvalidProtocolBufferException InvalidTag() { }
        private Google.Protobuf.InvalidProtocolBufferException InvalidWireType() { }
        private Google.Protobuf.InvalidProtocolBufferException InvalidBase64(System.Exception innerException) { }
        private Google.Protobuf.InvalidProtocolBufferException InvalidEndTag() { }
        private Google.Protobuf.InvalidProtocolBufferException RecursionLimitExceeded() { }
        private Google.Protobuf.InvalidProtocolBufferException JsonRecursionLimitExceeded() { }
        private Google.Protobuf.InvalidProtocolBufferException SizeLimitExceeded() { }
        private Google.Protobuf.InvalidProtocolBufferException InvalidMessageStreamTag() { }
        private Google.Protobuf.InvalidProtocolBufferException MissingFields() { }

    }

    // TypeToken: 0x2000039
    public class JsonFormatter
    {
        // Fields
        private static System.String AnyTypeUrlField;        // 0x0
        private static System.String AnyDiagnosticValueField;        // 0x0
        private static System.String AnyWellKnownTypeValueField;        // 0x0
        private static System.String TypeUrlPrefix;        // 0x0
        private static System.String NameValueSeparator;        // 0x0
        private static System.String PropertySeparator;        // 0x0
        private static readonly Google.Protobuf.JsonFormatter <Default>k__BackingField;        // 0x0
        private static readonly Google.Protobuf.JsonFormatter diagnosticFormatter;        // 0x8
        private static readonly System.String[] CommonRepresentations;        // 0x10
        private readonly Google.Protobuf.JsonFormatter.Settings settings;        // 0x10
        private static System.String Hex;        // 0x0

        // Methods
        private Google.Protobuf.JsonFormatter get_Default() { }
        private System.Void .cctor() { }
        private System.Boolean get_DiagnosticOnly() { }
        private System.Void .ctor(Google.Protobuf.JsonFormatter.Settings settings) { }
        private System.String Format(Google.Protobuf.IMessage message) { }
        private System.Void Format(Google.Protobuf.IMessage message, System.IO.TextWriter writer) { }
        private System.String ToDiagnosticString(Google.Protobuf.IMessage message) { }
        private System.Void WriteMessage(System.IO.TextWriter writer, Google.Protobuf.IMessage message) { }
        private System.Boolean WriteMessageFields(System.IO.TextWriter writer, Google.Protobuf.IMessage message, System.Boolean assumeFirstFieldWritten) { }
        private System.Boolean ShouldFormatFieldValue(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, System.Object value) { }
        private System.String ToJsonName(System.String name) { }
        private System.String FromJsonName(System.String name) { }
        private System.Void WriteNull(System.IO.TextWriter writer) { }
        private System.Boolean IsDefaultValue(Google.Protobuf.Reflection.FieldDescriptor descriptor, System.Object value) { }
        private System.Void WriteValue(System.IO.TextWriter writer, System.Object value) { }
        private System.Void WriteWellKnownTypeValue(System.IO.TextWriter writer, Google.Protobuf.Reflection.MessageDescriptor descriptor, System.Object value) { }
        private System.Void WriteTimestamp(System.IO.TextWriter writer, Google.Protobuf.IMessage value) { }
        private System.Void WriteDuration(System.IO.TextWriter writer, Google.Protobuf.IMessage value) { }
        private System.Void WriteFieldMask(System.IO.TextWriter writer, Google.Protobuf.IMessage value) { }
        private System.Void WriteAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value) { }
        private System.Void WriteDiagnosticOnlyAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value) { }
        private System.Void WriteStruct(System.IO.TextWriter writer, Google.Protobuf.IMessage message) { }
        private System.Void WriteStructFieldValue(System.IO.TextWriter writer, Google.Protobuf.IMessage message) { }
        private System.Void WriteList(System.IO.TextWriter writer, System.Collections.IList list) { }
        private System.Void WriteDictionary(System.IO.TextWriter writer, System.Collections.IDictionary dictionary) { }
        private System.Void WriteString(System.IO.TextWriter writer, System.String text) { }
        private System.Void HexEncodeUtf16CodeUnit(System.IO.TextWriter writer, System.Char c) { }

    }

    // TypeToken: 0x200003D
    public class JsonParser
    {
        // Fields
        private static readonly System.Text.RegularExpressions.Regex TimestampRegex;        // 0x0
        private static readonly System.Text.RegularExpressions.Regex DurationRegex;        // 0x8
        private static readonly System.Int32[] SubsecondScalingFactors;        // 0x10
        private static readonly System.Char[] FieldMaskPathSeparators;        // 0x18
        private static readonly Google.Protobuf.Reflection.EnumDescriptor NullValueDescriptor;        // 0x20
        private static readonly Google.Protobuf.JsonParser defaultInstance;        // 0x28
        private static readonly System.Collections.Generic.Dictionary<System.String,System.Action<Google.Protobuf.JsonParser,Google.Protobuf.IMessage,Google.Protobuf.JsonTokenizer>> WellKnownTypeHandlers;        // 0x30
        private readonly Google.Protobuf.JsonParser.Settings settings;        // 0x10

        // Methods
        private System.Void MergeWrapperField(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        private Google.Protobuf.JsonParser get_Default() { }
        private System.Void .ctor(Google.Protobuf.JsonParser.Settings settings) { }
        private System.Void Merge(Google.Protobuf.IMessage message, System.String json) { }
        private System.Void Merge(Google.Protobuf.IMessage message, System.IO.TextReader jsonReader) { }
        private System.Void Merge(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        private System.Void MergeField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer) { }
        private System.Void MergeRepeatedField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer) { }
        private System.Void MergeMapField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer) { }
        private System.Boolean IsGoogleProtobufValueField(Google.Protobuf.Reflection.FieldDescriptor field) { }
        private System.Boolean IsGoogleProtobufNullValueField(Google.Protobuf.Reflection.FieldDescriptor field) { }
        private System.Object ParseSingleValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer) { }
        private T Parse(System.String json) { }
        private T Parse(System.IO.TextReader jsonReader) { }
        private Google.Protobuf.IMessage Parse(System.String json, Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        private Google.Protobuf.IMessage Parse(System.IO.TextReader jsonReader, Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        private System.Void MergeStructValue(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        private System.Void MergeStruct(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        private System.Void MergeAny(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer) { }
        private System.Void MergeWellKnownTypeAnyBody(Google.Protobuf.IMessage body, Google.Protobuf.JsonTokenizer tokenizer) { }
        private System.Object ParseMapKey(Google.Protobuf.Reflection.FieldDescriptor field, System.String keyText) { }
        private System.Object ParseSingleNumberValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonToken token) { }
        private System.Void CheckInteger(System.Double value) { }
        private System.Object ParseSingleStringValue(Google.Protobuf.Reflection.FieldDescriptor field, System.String text) { }
        private Google.Protobuf.IMessage NewMessageForField(Google.Protobuf.Reflection.FieldDescriptor field) { }
        private T ParseNumericString(System.String text, System.Func<System.String,System.Globalization.NumberStyles,System.IFormatProvider,T> parser) { }
        private System.Void ValidateInfinityAndNan(System.String text, System.Boolean isPositiveInfinity, System.Boolean isNegativeInfinity, System.Boolean isNaN) { }
        private System.Void MergeTimestamp(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token) { }
        private System.Void MergeDuration(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token) { }
        private System.Void MergeFieldMask(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token) { }
        private System.String ToSnakeCase(System.String text) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000040
    public class JsonToken, IEquatable`1
    {
        // Fields
        private static readonly Google.Protobuf.JsonToken _true;        // 0x0
        private static readonly Google.Protobuf.JsonToken _false;        // 0x8
        private static readonly Google.Protobuf.JsonToken _null;        // 0x10
        private static readonly Google.Protobuf.JsonToken startObject;        // 0x18
        private static readonly Google.Protobuf.JsonToken endObject;        // 0x20
        private static readonly Google.Protobuf.JsonToken startArray;        // 0x28
        private static readonly Google.Protobuf.JsonToken endArray;        // 0x30
        private static readonly Google.Protobuf.JsonToken endDocument;        // 0x38
        private readonly Google.Protobuf.JsonToken.TokenType type;        // 0x10
        private readonly System.String stringValue;        // 0x18
        private readonly System.Double numberValue;        // 0x20

        // Methods
        private Google.Protobuf.JsonToken get_Null() { }
        private Google.Protobuf.JsonToken get_False() { }
        private Google.Protobuf.JsonToken get_True() { }
        private Google.Protobuf.JsonToken get_StartObject() { }
        private Google.Protobuf.JsonToken get_EndObject() { }
        private Google.Protobuf.JsonToken get_StartArray() { }
        private Google.Protobuf.JsonToken get_EndArray() { }
        private Google.Protobuf.JsonToken get_EndDocument() { }
        private Google.Protobuf.JsonToken Name(System.String name) { }
        private Google.Protobuf.JsonToken Value(System.String value) { }
        private Google.Protobuf.JsonToken Value(System.Double value) { }
        private Google.Protobuf.JsonToken.TokenType get_Type() { }
        private System.String get_StringValue() { }
        private System.Double get_NumberValue() { }
        private System.Void .ctor(Google.Protobuf.JsonToken.TokenType type, System.String stringValue, System.Double numberValue) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Boolean Equals(Google.Protobuf.JsonToken other) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000042
    public class JsonTokenizer
    {
        // Fields
        private Google.Protobuf.JsonToken bufferedToken;        // 0x10
        private System.Int32 <ObjectDepth>k__BackingField;        // 0x18

        // Methods
        private Google.Protobuf.JsonTokenizer FromTextReader(System.IO.TextReader reader) { }
        private Google.Protobuf.JsonTokenizer FromReplayedTokens(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer continuation) { }
        private System.Int32 get_ObjectDepth() { }
        private System.Void set_ObjectDepth(System.Int32 value) { }
        private System.Void PushBack(Google.Protobuf.JsonToken token) { }
        private Google.Protobuf.JsonToken Next() { }
        private Google.Protobuf.JsonToken NextImpl() { }
        private System.Void SkipValue() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000048
    public class LimitedInputStream : Stream
    {
        // Fields
        private readonly System.IO.Stream proxied;        // 0x28
        private System.Int32 bytesLeft;        // 0x30

        // Methods
        private System.Void .ctor(System.IO.Stream proxied, System.Int32 size) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanSeek() { }
        private System.Boolean get_CanWrite() { }
        private System.Void Flush() { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }

    }

    // TypeToken: 0x2000049
    public class MessageExtensions
    {
        // Methods
        private System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data) { }
        private System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Int32 offset, System.Int32 length) { }
        private System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data) { }
        private System.Void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input) { }
        private System.Void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<System.Byte> span) { }
        private System.Void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input) { }
        private System.Byte[] ToByteArray(Google.Protobuf.IMessage message) { }
        private System.Int32 WriteToByteArray(Google.Protobuf.IMessage message, System.Byte[] buffer, System.Int32 pos) { }
        private System.Void WriteTo(Google.Protobuf.IMessage message, System.IO.Stream output) { }
        private System.Void WriteDelimitedTo(Google.Protobuf.IMessage message, System.IO.Stream output) { }
        private Google.Protobuf.ByteString ToByteString(Google.Protobuf.IMessage message) { }
        private System.Void WriteTo(Google.Protobuf.IMessage message, System.Buffers.IBufferWriter<System.Byte> output) { }
        private System.Void WriteTo(Google.Protobuf.IMessage message, System.Span<System.Byte> output) { }
        private System.Boolean IsInitialized(Google.Protobuf.IMessage message) { }
        private System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        private System.Void MergeFrom(Google.Protobuf.IMessage message, System.Byte[] data, System.Int32 offset, System.Int32 length, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        private System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        private System.Void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        private System.Void MergeFrom(Google.Protobuf.IMessage message, System.Buffers.ReadOnlySequence<System.Byte> data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        private System.Void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<System.Byte> data, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }
        private System.Void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry registry) { }

    }

    // TypeToken: 0x200004B
    public class MessageParser
    {
        // Fields
        private System.Func<Google.Protobuf.IMessage> factory;        // 0x10
        private readonly System.Boolean <DiscardUnknownFields>k__BackingField;        // 0x18
        private readonly Google.Protobuf.ExtensionRegistry <Extensions>k__BackingField;        // 0x20

        // Methods
        private System.Boolean get_DiscardUnknownFields() { }
        private Google.Protobuf.ExtensionRegistry get_Extensions() { }
        private System.Void .ctor(System.Func<Google.Protobuf.IMessage> factory, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions) { }
        private Google.Protobuf.IMessage CreateTemplate() { }
        private Google.Protobuf.IMessage ParseFrom(System.Byte[] data) { }
        private Google.Protobuf.IMessage ParseFrom(System.Byte[] data, System.Int32 offset, System.Int32 length) { }
        private Google.Protobuf.IMessage ParseFrom(Google.Protobuf.ByteString data) { }
        private Google.Protobuf.IMessage ParseFrom(System.IO.Stream input) { }
        private Google.Protobuf.IMessage ParseFrom(System.Buffers.ReadOnlySequence<System.Byte> data) { }
        private Google.Protobuf.IMessage ParseFrom(System.ReadOnlySpan<System.Byte> data) { }
        private Google.Protobuf.IMessage ParseDelimitedFrom(System.IO.Stream input) { }
        private Google.Protobuf.IMessage ParseFrom(Google.Protobuf.CodedInputStream input) { }
        private Google.Protobuf.IMessage ParseJson(System.String json) { }
        private System.Void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.CodedInputStream codedInput) { }
        private Google.Protobuf.MessageParser WithDiscardUnknownFields(System.Boolean discardUnknownFields) { }
        private Google.Protobuf.MessageParser WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry) { }

    }

    // TypeToken: 0x200004C
    public class MessageParser`1 : MessageParser
    {
        // Fields
        private readonly System.Func<T> factory;        // 0x0

        // Methods
        private System.Void .ctor(System.Func<T> factory) { }
        private System.Void .ctor(System.Func<T> factory, System.Boolean discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions) { }
        private T CreateTemplate() { }
        private T ParseFrom(System.Byte[] data) { }
        private T ParseFrom(System.Byte[] data, System.Int32 offset, System.Int32 length) { }
        private T ParseFrom(Google.Protobuf.ByteString data) { }
        private T ParseFrom(System.IO.Stream input) { }
        private T ParseFrom(System.Buffers.ReadOnlySequence<System.Byte> data) { }
        private T ParseFrom(System.ReadOnlySpan<System.Byte> data) { }
        private T ParseDelimitedFrom(System.IO.Stream input) { }
        private T ParseFrom(Google.Protobuf.CodedInputStream input) { }
        private T ParseJson(System.String json) { }
        private Google.Protobuf.MessageParser<T> WithDiscardUnknownFields(System.Boolean discardUnknownFields) { }
        private Google.Protobuf.MessageParser<T> WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry) { }

    }

    // TypeToken: 0x200004E
    public struct ObjectIntPair`1, IEquatable`1
    {
        // Fields
        private readonly System.Int32 number;        // 0x0
        private readonly T obj;        // 0x0

        // Methods
        private System.Void .ctor(T obj, System.Int32 number) { }
        private System.Boolean Equals(Google.Protobuf.ObjectIntPair<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200004F
    public struct ParseContext
    {
        // Fields
        private static System.Int32 DefaultRecursionLimit;        // 0x0
        private static System.Int32 DefaultSizeLimit;        // 0x0
        private System.ReadOnlySpan<System.Byte> buffer;        // 0x10
        private Google.Protobuf.ParserInternalState state;        // 0x20

        // Methods
        private System.Void Initialize(System.ReadOnlySpan<System.Byte> buffer, Google.Protobuf.ParseContext& ctx) { }
        private System.Void Initialize(System.ReadOnlySpan<System.Byte> buffer, Google.Protobuf.ParserInternalState& state, Google.Protobuf.ParseContext& ctx) { }
        private System.Void Initialize(Google.Protobuf.CodedInputStream input, Google.Protobuf.ParseContext& ctx) { }
        private System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> input, Google.Protobuf.ParseContext& ctx) { }
        private System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> input, System.Int32 recursionLimit, Google.Protobuf.ParseContext& ctx) { }
        private System.UInt32 get_LastTag() { }
        private System.Boolean get_DiscardUnknownFields() { }
        private System.Void set_DiscardUnknownFields(System.Boolean value) { }
        private Google.Protobuf.ExtensionRegistry get_ExtensionRegistry() { }
        private System.Void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value) { }
        private System.UInt32 ReadTag() { }
        private System.Double ReadDouble() { }
        private System.Single ReadFloat() { }
        private System.UInt64 ReadUInt64() { }
        private System.Int64 ReadInt64() { }
        private System.Int32 ReadInt32() { }
        private System.UInt64 ReadFixed64() { }
        private System.UInt32 ReadFixed32() { }
        private System.Boolean ReadBool() { }
        private System.String ReadString() { }
        private System.Void ReadMessage(Google.Protobuf.IMessage message) { }
        private System.Void ReadGroup(Google.Protobuf.IMessage message) { }
        private Google.Protobuf.ByteString ReadBytes() { }
        private System.UInt32 ReadUInt32() { }
        private System.Int32 ReadEnum() { }
        private System.Int32 ReadSFixed32() { }
        private System.Int64 ReadSFixed64() { }
        private System.Int32 ReadSInt32() { }
        private System.Int64 ReadSInt64() { }
        private System.Int32 ReadLength() { }
        private System.Void CopyStateTo(Google.Protobuf.CodedInputStream input) { }
        private System.Void LoadStateFrom(Google.Protobuf.CodedInputStream input) { }

    }

    // TypeToken: 0x2000050
    public struct ParserInternalState
    {
        // Fields
        private System.Int32 bufferPos;        // 0x10
        private System.Int32 bufferSize;        // 0x14
        private System.Int32 bufferSizeAfterLimit;        // 0x18
        private System.Int32 currentLimit;        // 0x1C
        private System.Int32 totalBytesRetired;        // 0x20
        private System.Int32 recursionDepth;        // 0x24
        private Google.Protobuf.SegmentedBufferHelper segmentedBufferHelper;        // 0x28
        private System.UInt32 lastTag;        // 0x70
        private System.UInt32 nextTag;        // 0x74
        private System.Boolean hasNextTag;        // 0x78
        private System.Int32 sizeLimit;        // 0x7C
        private System.Int32 recursionLimit;        // 0x80
        private System.Boolean <DiscardUnknownFields>k__BackingField;        // 0x84
        private Google.Protobuf.ExtensionRegistry <ExtensionRegistry>k__BackingField;        // 0x88

        // Methods
        private Google.Protobuf.CodedInputStream get_CodedInputStream() { }
        private System.Boolean get_DiscardUnknownFields() { }
        private System.Void set_DiscardUnknownFields(System.Boolean value) { }
        private Google.Protobuf.ExtensionRegistry get_ExtensionRegistry() { }
        private System.Void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value) { }

    }

    // TypeToken: 0x2000051
    public class ParsingPrimitives
    {
        // Fields
        private static System.Int32 StackallocThreshold;        // 0x0

        // Methods
        private System.Int32 ParseLength(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.UInt32 ParseTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Boolean MaybeConsumeTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.UInt32 tag) { }
        private System.UInt32 PeekTag(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.UInt64 ParseRawVarint64(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.UInt64 ParseRawVarint64SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.UInt32 ParseRawVarint32(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.UInt32 ParseRawVarint32SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.UInt32 ParseRawLittleEndian32(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.UInt32 ParseRawLittleEndian32SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.UInt64 ParseRawLittleEndian64(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.UInt64 ParseRawLittleEndian64SlowPath(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Double ParseDouble(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Single ParseFloat(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Single ParseFloatSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Byte[] ReadRawBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        private System.Byte[] ReadRawBytesSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        private System.Void SkipRawBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        private System.String ReadString(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private Google.Protobuf.ByteString ReadBytes(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.String ReadRawString(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length) { }
        private System.String ReadStringSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length) { }
        private System.Void ValidateCurrentLimit(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        private System.Byte ReadRawByte(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.UInt32 ReadRawVarint32(System.IO.Stream input) { }
        private System.Int32 DecodeZigZag32(System.UInt32 n) { }
        private System.Int64 DecodeZigZag64(System.UInt64 n) { }
        private System.Boolean IsDataAvailable(Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        private System.Boolean IsDataAvailableInSource(Google.Protobuf.ParserInternalState& state, System.Int32 size) { }
        private System.Void ReadRawBytesIntoSpan(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Int32 length, System.Span<System.Byte> byteSpan) { }

    }

    // TypeToken: 0x2000052
    public class ParsingPrimitivesMessages
    {
        // Fields
        private static readonly System.Byte[] ZeroLengthMessageStreamData;        // 0x0

        // Methods
        private System.Void SkipLastField(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Void SkipGroup(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.UInt32 startGroupTag) { }
        private System.Void ReadMessage(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message) { }
        private System.Collections.Generic.KeyValuePair<TKey,TValue> ReadMapEntry(Google.Protobuf.ParseContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        private System.Void ReadGroup(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message) { }
        private System.Void ReadGroup(Google.Protobuf.ParseContext& ctx, System.Int32 fieldNumber, Google.Protobuf.UnknownFieldSet set) { }
        private System.Void ReadRawMessage(Google.Protobuf.ParseContext& ctx, Google.Protobuf.IMessage message) { }
        private System.Void CheckReadEndOfStreamTag(Google.Protobuf.ParserInternalState& state) { }
        private System.Void CheckLastTagWas(Google.Protobuf.ParserInternalState& state, System.UInt32 expectedTag) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000053
    public class ParsingPrimitivesWrappers
    {
        // Methods
        private System.Nullable<System.Single> ReadFloatWrapperLittleEndian(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Nullable<System.Single> ReadFloatWrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Nullable<System.Double> ReadDoubleWrapperLittleEndian(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Nullable<System.Double> ReadDoubleWrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Nullable<System.Boolean> ReadBoolWrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Nullable<System.UInt32> ReadUInt32Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Nullable<System.UInt32> ReadUInt32WrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Nullable<System.Int32> ReadInt32Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Nullable<System.UInt64> ReadUInt64Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Nullable<System.UInt64> ReadUInt64WrapperSlow(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Nullable<System.Int64> ReadInt64Wrapper(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Nullable<System.Single> ReadFloatWrapperLittleEndian(Google.Protobuf.ParseContext& ctx) { }
        private System.Nullable<System.Single> ReadFloatWrapperSlow(Google.Protobuf.ParseContext& ctx) { }
        private System.Nullable<System.Double> ReadDoubleWrapperLittleEndian(Google.Protobuf.ParseContext& ctx) { }
        private System.Nullable<System.Double> ReadDoubleWrapperSlow(Google.Protobuf.ParseContext& ctx) { }
        private System.Nullable<System.Boolean> ReadBoolWrapper(Google.Protobuf.ParseContext& ctx) { }
        private System.Nullable<System.UInt32> ReadUInt32Wrapper(Google.Protobuf.ParseContext& ctx) { }
        private System.Nullable<System.Int32> ReadInt32Wrapper(Google.Protobuf.ParseContext& ctx) { }
        private System.Nullable<System.UInt64> ReadUInt64Wrapper(Google.Protobuf.ParseContext& ctx) { }
        private System.Nullable<System.UInt64> ReadUInt64WrapperSlow(Google.Protobuf.ParseContext& ctx) { }
        private System.Nullable<System.Int64> ReadInt64Wrapper(Google.Protobuf.ParseContext& ctx) { }

    }

    // TypeToken: 0x2000054
    public class ProtoPreconditions
    {
        // Methods
        private T CheckNotNull(T value, System.String name) { }
        private T CheckNotNullUnconstrained(T value, System.String name) { }

    }

    // TypeToken: 0x2000055
    public struct SegmentedBufferHelper
    {
        // Fields
        private System.Nullable<System.Int32> totalLength;        // 0x10
        private System.Buffers.ReadOnlySequence.Enumerator<System.Byte> readOnlySequenceEnumerator;        // 0x18
        private Google.Protobuf.CodedInputStream codedInputStream;        // 0x50

        // Methods
        private System.Void Initialize(Google.Protobuf.CodedInputStream codedInputStream, Google.Protobuf.SegmentedBufferHelper& instance) { }
        private System.Void Initialize(System.Buffers.ReadOnlySequence<System.Byte> sequence, Google.Protobuf.SegmentedBufferHelper& instance, System.ReadOnlySpan<System.Byte>& firstSpan) { }
        private System.Boolean RefillBuffer(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed) { }
        private System.Nullable<System.Int32> get_TotalLength() { }
        private Google.Protobuf.CodedInputStream get_CodedInputStream() { }
        private System.Int32 PushLimit(Google.Protobuf.ParserInternalState& state, System.Int32 byteLimit) { }
        private System.Void PopLimit(Google.Protobuf.ParserInternalState& state, System.Int32 oldLimit) { }
        private System.Boolean IsReachedLimit(Google.Protobuf.ParserInternalState& state) { }
        private System.Boolean IsAtEnd(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state) { }
        private System.Boolean RefillFromReadOnlySequence(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed) { }
        private System.Boolean RefillFromCodedInputStream(System.ReadOnlySpan<System.Byte>& buffer, Google.Protobuf.ParserInternalState& state, System.Boolean mustSucceed) { }
        private System.Void RecomputeBufferSizeAfterLimit(Google.Protobuf.ParserInternalState& state) { }
        private System.Void CheckCurrentBufferIsEmpty(Google.Protobuf.ParserInternalState& state) { }

    }

    // TypeToken: 0x2000056
    public class UnknownField
    {
        // Fields
        private System.Collections.Generic.List<System.UInt64> varintList;        // 0x10
        private System.Collections.Generic.List<System.UInt32> fixed32List;        // 0x18
        private System.Collections.Generic.List<System.UInt64> fixed64List;        // 0x20
        private System.Collections.Generic.List<Google.Protobuf.ByteString> lengthDelimitedList;        // 0x28
        private System.Collections.Generic.List<Google.Protobuf.UnknownFieldSet> groupList;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Int32 GetHashCode() { }
        private System.Void WriteTo(System.Int32 fieldNumber, Google.Protobuf.WriteContext& output) { }
        private System.Int32 GetSerializedSize(System.Int32 fieldNumber) { }
        private Google.Protobuf.UnknownField MergeFrom(Google.Protobuf.UnknownField other) { }
        private System.Collections.Generic.List<T> AddAll(System.Collections.Generic.List<T> current, System.Collections.Generic.IList<T> extras) { }
        private Google.Protobuf.UnknownField AddVarint(System.UInt64 value) { }
        private Google.Protobuf.UnknownField AddFixed32(System.UInt32 value) { }
        private Google.Protobuf.UnknownField AddFixed64(System.UInt64 value) { }
        private Google.Protobuf.UnknownField AddLengthDelimited(Google.Protobuf.ByteString value) { }
        private Google.Protobuf.UnknownField AddGroup(Google.Protobuf.UnknownFieldSet value) { }
        private System.Collections.Generic.List<T> Add(System.Collections.Generic.List<T> list, T value) { }

    }

    // TypeToken: 0x2000057
    public class UnknownFieldSet
    {
        // Fields
        private readonly System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.UnknownField> fields;        // 0x10
        private System.Int32 lastFieldNumber;        // 0x18
        private Google.Protobuf.UnknownField lastField;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Boolean HasField(System.Int32 field) { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void WriteTo(Google.Protobuf.WriteContext& ctx) { }
        private System.Int32 CalculateSize() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Int32 GetHashCode() { }
        private Google.Protobuf.UnknownField GetOrAddField(System.Int32 number) { }
        private Google.Protobuf.UnknownFieldSet AddOrReplaceField(System.Int32 number, Google.Protobuf.UnknownField field) { }
        private System.Boolean MergeFieldFrom(Google.Protobuf.ParseContext& ctx) { }
        private System.Void MergeGroupFrom(Google.Protobuf.ParseContext& ctx) { }
        private Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.CodedInputStream input) { }
        private Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.ParseContext& ctx) { }
        private Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet other) { }
        private Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.UnknownFieldSet other) { }
        private Google.Protobuf.UnknownFieldSet MergeField(System.Int32 number, Google.Protobuf.UnknownField field) { }
        private Google.Protobuf.UnknownFieldSet Clone(Google.Protobuf.UnknownFieldSet other) { }

    }

    // TypeToken: 0x2000058
    public class UnsafeByteOperations
    {
        // Methods
        private Google.Protobuf.ByteString UnsafeWrap(System.ReadOnlyMemory<System.Byte> bytes) { }

    }

    // TypeToken: 0x2000059
    public class WireFormat
    {
        // Fields
        private static System.Int32 TagTypeBits;        // 0x0
        private static System.UInt32 TagTypeMask;        // 0x0

        // Methods
        private Google.Protobuf.WireFormat.WireType GetTagWireType(System.UInt32 tag) { }
        private System.Int32 GetTagFieldNumber(System.UInt32 tag) { }
        private System.UInt32 MakeTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType wireType) { }

    }

    // TypeToken: 0x200005B
    public struct WriteBufferHelper
    {
        // Fields
        private System.Buffers.IBufferWriter<System.Byte> bufferWriter;        // 0x10
        private Google.Protobuf.CodedOutputStream codedOutputStream;        // 0x18

        // Methods
        private Google.Protobuf.CodedOutputStream get_CodedOutputStream() { }
        private System.Void Initialize(Google.Protobuf.CodedOutputStream codedOutputStream, Google.Protobuf.WriteBufferHelper& instance) { }
        private System.Void Initialize(System.Buffers.IBufferWriter<System.Byte> bufferWriter, Google.Protobuf.WriteBufferHelper& instance, System.Span<System.Byte>& buffer) { }
        private System.Void InitializeNonRefreshable(Google.Protobuf.WriteBufferHelper& instance) { }
        private System.Void CheckNoSpaceLeft(Google.Protobuf.WriterInternalState& state) { }
        private System.Int32 GetSpaceLeft(Google.Protobuf.WriterInternalState& state) { }
        private System.Void RefreshBuffer(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state) { }
        private System.Void Flush(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state) { }

    }

    // TypeToken: 0x200005C
    public struct WriteContext
    {
        // Fields
        private System.Span<System.Byte> buffer;        // 0x10
        private Google.Protobuf.WriterInternalState state;        // 0x20

        // Methods
        private System.Void Initialize(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, Google.Protobuf.WriteContext& ctx) { }
        private System.Void Initialize(Google.Protobuf.CodedOutputStream output, Google.Protobuf.WriteContext& ctx) { }
        private System.Void Initialize(System.Buffers.IBufferWriter<System.Byte> output, Google.Protobuf.WriteContext& ctx) { }
        private System.Void Initialize(System.Span<System.Byte>& buffer, Google.Protobuf.WriteContext& ctx) { }
        private System.Void WriteDouble(System.Double value) { }
        private System.Void WriteFloat(System.Single value) { }
        private System.Void WriteUInt64(System.UInt64 value) { }
        private System.Void WriteInt64(System.Int64 value) { }
        private System.Void WriteInt32(System.Int32 value) { }
        private System.Void WriteFixed64(System.UInt64 value) { }
        private System.Void WriteFixed32(System.UInt32 value) { }
        private System.Void WriteBool(System.Boolean value) { }
        private System.Void WriteString(System.String value) { }
        private System.Void WriteMessage(Google.Protobuf.IMessage value) { }
        private System.Void WriteGroup(Google.Protobuf.IMessage value) { }
        private System.Void WriteBytes(Google.Protobuf.ByteString value) { }
        private System.Void WriteUInt32(System.UInt32 value) { }
        private System.Void WriteEnum(System.Int32 value) { }
        private System.Void WriteSFixed32(System.Int32 value) { }
        private System.Void WriteSFixed64(System.Int64 value) { }
        private System.Void WriteSInt32(System.Int32 value) { }
        private System.Void WriteSInt64(System.Int64 value) { }
        private System.Void WriteLength(System.Int32 length) { }
        private System.Void WriteTag(System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type) { }
        private System.Void WriteTag(System.UInt32 tag) { }
        private System.Void WriteRawTag(System.Byte b1) { }
        private System.Void WriteRawTag(System.Byte b1, System.Byte b2) { }
        private System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3) { }
        private System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4) { }
        private System.Void WriteRawTag(System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5) { }
        private System.Void Flush() { }
        private System.Void CheckNoSpaceLeft() { }
        private System.Void CopyStateTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void LoadStateFrom(Google.Protobuf.CodedOutputStream output) { }

    }

    // TypeToken: 0x200005D
    public struct WriterInternalState
    {
        // Fields
        private System.Int32 limit;        // 0x10
        private System.Int32 position;        // 0x14
        private Google.Protobuf.WriteBufferHelper writeBufferHelper;        // 0x18

        // Methods
        private Google.Protobuf.CodedOutputStream get_CodedOutputStream() { }

    }

    // TypeToken: 0x200005E
    public class WritingPrimitives
    {
        // Fields
        private static readonly System.Text.Encoding Utf8Encoding;        // 0x0

        // Methods
        private System.Void WriteDouble(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Double value) { }
        private System.Void WriteFloat(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Single value) { }
        private System.Void WriteFloatSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Single value) { }
        private System.Void WriteUInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value) { }
        private System.Void WriteInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value) { }
        private System.Void WriteInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value) { }
        private System.Void WriteFixed64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value) { }
        private System.Void WriteFixed32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value) { }
        private System.Void WriteBool(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Boolean value) { }
        private System.Void WriteString(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.String value) { }
        private System.Void WriteAsciiStringToBuffer(System.Span<System.Byte> buffer, Google.Protobuf.WriterInternalState& state, System.String value, System.Int32 length) { }
        private System.Void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(System.Byte& outputBuffer, System.UInt64 value) { }
        private System.Int32 WriteStringToBuffer(System.Span<System.Byte> buffer, Google.Protobuf.WriterInternalState& state, System.String value) { }
        private System.Void WriteBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, Google.Protobuf.ByteString value) { }
        private System.Void WriteUInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value) { }
        private System.Void WriteEnum(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value) { }
        private System.Void WriteSFixed32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value) { }
        private System.Void WriteSFixed64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value) { }
        private System.Void WriteSInt32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 value) { }
        private System.Void WriteSInt64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int64 value) { }
        private System.Void WriteLength(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 length) { }
        private System.Void WriteRawVarint32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value) { }
        private System.Void WriteRawVarint64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value) { }
        private System.Void WriteRawLittleEndian32(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value) { }
        private System.Void WriteRawLittleEndian32SlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 value) { }
        private System.Void WriteRawLittleEndian64(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value) { }
        private System.Void WriteRawLittleEndian64SlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt64 value) { }
        private System.Void WriteRawByte(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte value) { }
        private System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte[] value) { }
        private System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte[] value, System.Int32 offset, System.Int32 length) { }
        private System.Void WriteRawBytes(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.ReadOnlySpan<System.Byte> value) { }
        private System.Void WriteTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Int32 fieldNumber, Google.Protobuf.WireFormat.WireType type) { }
        private System.Void WriteTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.UInt32 tag) { }
        private System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1) { }
        private System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2) { }
        private System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2) { }
        private System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3) { }
        private System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3) { }
        private System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4) { }
        private System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4) { }
        private System.Void WriteRawTag(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5) { }
        private System.Void WriteRawTagSlowPath(System.Span<System.Byte>& buffer, Google.Protobuf.WriterInternalState& state, System.Byte b1, System.Byte b2, System.Byte b3, System.Byte b4, System.Byte b5) { }
        private System.UInt32 EncodeZigZag32(System.Int32 n) { }
        private System.UInt64 EncodeZigZag64(System.Int64 n) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005F
    public class WritingPrimitivesMessages
    {
        // Methods
        private System.Void WriteMessage(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage value) { }
        private System.Void WriteGroup(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage value) { }
        private System.Void WriteRawMessage(Google.Protobuf.WriteContext& ctx, Google.Protobuf.IMessage message) { }

    }

}

namespace Google.Protobuf.Collections
{

    // TypeToken: 0x200012E
    public class Lists
    {
        // Methods
        private System.Boolean Equals(System.Collections.Generic.List<T> left, System.Collections.Generic.List<T> right) { }
        private System.Int32 GetHashCode(System.Collections.Generic.List<T> list) { }

    }

    // TypeToken: 0x200012F
    public class MapField`2, IDeepCloneable`1, IDictionary`2, ICollection`1, IEnumerable`1, IEnumerable, IEquatable`1, IDictionary, ICollection, IReadOnlyDictionary`2, IReadOnlyCollection`1
    {
        // Fields
        private static readonly System.Collections.Generic.EqualityComparer<TValue> ValueEqualityComparer;        // 0x0
        private static readonly System.Collections.Generic.EqualityComparer<TKey> KeyEqualityComparer;        // 0x0
        private readonly System.Collections.Generic.Dictionary<TKey,System.Collections.Generic.LinkedListNode<System.Collections.Generic.KeyValuePair<TKey,TValue>>> map;        // 0x0
        private readonly System.Collections.Generic.LinkedList<System.Collections.Generic.KeyValuePair<TKey,TValue>> list;        // 0x0

        // Methods
        private Google.Protobuf.Collections.MapField<TKey,TValue> Clone() { }
        private System.Void Add(TKey key, TValue value) { }
        private System.Boolean ContainsKey(TKey key) { }
        private System.Boolean ContainsValue(TValue value) { }
        private System.Boolean Remove(TKey key) { }
        private System.Boolean TryGetValue(TKey key, TValue& value) { }
        private TValue get_Item(TKey key) { }
        private System.Void set_Item(TKey key, TValue value) { }
        private System.Collections.Generic.ICollection<TKey> get_Keys() { }
        private System.Collections.Generic.ICollection<TValue> get_Values() { }
        private System.Void Add(System.Collections.Generic.IDictionary<TKey,TValue> entries) { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        private System.Void Clear() { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        private System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex) { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(Google.Protobuf.Collections.MapField<TKey,TValue> other) { }
        private System.Void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        private System.Void AddEntriesFrom(Google.Protobuf.ParseContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        private System.Void WriteTo(Google.Protobuf.WriteContext& ctx, Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        private System.Int32 CalculateSize(Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec) { }
        private System.Int32 CalculateEntrySize(Google.Protobuf.Collections.MapField.Codec<TKey,TValue> codec, System.Collections.Generic.KeyValuePair<TKey,TValue> entry) { }
        private System.String ToString() { }
        private System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value) { }
        private System.Boolean System.Collections.IDictionary.Contains(System.Object key) { }
        private System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
        private System.Void System.Collections.IDictionary.Remove(System.Object key) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Boolean System.Collections.IDictionary.get_IsFixedSize() { }
        private System.Collections.ICollection System.Collections.IDictionary.get_Keys() { }
        private System.Collections.ICollection System.Collections.IDictionary.get_Values() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Object System.Collections.IDictionary.get_Item(System.Object key) { }
        private System.Void System.Collections.IDictionary.set_Item(System.Object key, System.Object value) { }
        private System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
        private System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000135
    public class ProtobufEqualityComparers
    {
        // Fields
        private static readonly System.Collections.Generic.EqualityComparer<System.Double> <BitwiseDoubleEqualityComparer>k__BackingField;        // 0x0
        private static readonly System.Collections.Generic.EqualityComparer<System.Single> <BitwiseSingleEqualityComparer>k__BackingField;        // 0x8
        private static readonly System.Collections.Generic.EqualityComparer<System.Nullable<System.Double>> <BitwiseNullableDoubleEqualityComparer>k__BackingField;        // 0x10
        private static readonly System.Collections.Generic.EqualityComparer<System.Nullable<System.Single>> <BitwiseNullableSingleEqualityComparer>k__BackingField;        // 0x18

        // Methods
        private System.Collections.Generic.EqualityComparer<T> GetEqualityComparer() { }
        private System.Collections.Generic.EqualityComparer<System.Double> get_BitwiseDoubleEqualityComparer() { }
        private System.Collections.Generic.EqualityComparer<System.Single> get_BitwiseSingleEqualityComparer() { }
        private System.Collections.Generic.EqualityComparer<System.Nullable<System.Double>> get_BitwiseNullableDoubleEqualityComparer() { }
        private System.Collections.Generic.EqualityComparer<System.Nullable<System.Single>> get_BitwiseNullableSingleEqualityComparer() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200013A
    public class ReadOnlyDictionary`2, IDictionary`2, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.IDictionary<TKey,TValue> wrapped;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IDictionary<TKey,TValue> wrapped) { }
        private System.Void Add(TKey key, TValue value) { }
        private System.Boolean ContainsKey(TKey key) { }
        private System.Collections.Generic.ICollection<TKey> get_Keys() { }
        private System.Boolean Remove(TKey key) { }
        private System.Boolean TryGetValue(TKey key, TValue& value) { }
        private System.Collections.Generic.ICollection<TValue> get_Values() { }
        private TValue get_Item(TKey key) { }
        private System.Void set_Item(TKey key, TValue value) { }
        private System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        private System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200013B
    public class RepeatedField`1, IList`1, ICollection`1, IEnumerable`1, IEnumerable, IList, ICollection, IDeepCloneable`1, IEquatable`1, IReadOnlyList`1, IReadOnlyCollection`1
    {
        // Fields
        private static readonly System.Collections.Generic.EqualityComparer<T> EqualityComparer;        // 0x0
        private static readonly T[] EmptyArray;        // 0x0
        private static System.Int32 MinArraySize;        // 0x0
        private T[] array;        // 0x0
        private System.Int32 count;        // 0x0

        // Methods
        private Google.Protobuf.Collections.RepeatedField<T> Clone() { }
        private System.Void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.FieldCodec<T> codec) { }
        private System.Void AddEntriesFrom(Google.Protobuf.ParseContext& ctx, Google.Protobuf.FieldCodec<T> codec) { }
        private System.Int32 CalculateSize(Google.Protobuf.FieldCodec<T> codec) { }
        private System.Int32 CalculatePackedDataSize(Google.Protobuf.FieldCodec<T> codec) { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.FieldCodec<T> codec) { }
        private System.Void WriteTo(Google.Protobuf.WriteContext& ctx, Google.Protobuf.FieldCodec<T> codec) { }
        private System.Int32 get_Capacity() { }
        private System.Void set_Capacity(System.Int32 value) { }
        private System.Void EnsureSize(System.Int32 size) { }
        private System.Void SetSize(System.Int32 size) { }
        private System.Void SetCount(System.Int32 newCount) { }
        private System.Void Add(T item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(T item) { }
        private System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        private System.Boolean Remove(T item) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Void AddRange(System.Collections.Generic.IEnumerable<T> values) { }
        private System.Void Add(System.Collections.Generic.IEnumerable<T> values) { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(Google.Protobuf.Collections.RepeatedField<T> other) { }
        private System.Int32 IndexOf(T item) { }
        private System.Void Insert(System.Int32 index, T item) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.String ToString() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.Boolean System.Collections.IList.get_IsFixedSize() { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Object System.Collections.IList.get_Item(System.Int32 index) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value) { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace Google.Protobuf.Compatibility
{

    // TypeToken: 0x200012C
    public class PropertyInfoExtensions
    {
        // Methods
        private System.Reflection.MethodInfo GetGetMethod(System.Reflection.PropertyInfo target) { }
        private System.Reflection.MethodInfo GetSetMethod(System.Reflection.PropertyInfo target) { }

    }

    // TypeToken: 0x200012D
    public class TypeExtensions
    {
        // Methods
        private System.Boolean IsAssignableFrom(System.Type target, System.Type c) { }
        private System.Reflection.PropertyInfo GetProperty(System.Type target, System.String name) { }
        private System.Reflection.MethodInfo GetMethod(System.Type target, System.String name) { }

    }

}

namespace Google.Protobuf.Reflection
{

    // TypeToken: 0x20000A6
    public class CustomOptions
    {
        // Fields
        private static System.String UnreferencedCodeMessage;        // 0x0
        private static readonly System.Object[] EmptyParameters;        // 0x0
        private readonly System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.IExtensionValue> values;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.Generic.IDictionary<System.Int32,Google.Protobuf.IExtensionValue> values) { }
        private System.Boolean TryGetBool(System.Int32 field, System.Boolean& value) { }
        private System.Boolean TryGetInt32(System.Int32 field, System.Int32& value) { }
        private System.Boolean TryGetInt64(System.Int32 field, System.Int64& value) { }
        private System.Boolean TryGetFixed32(System.Int32 field, System.UInt32& value) { }
        private System.Boolean TryGetFixed64(System.Int32 field, System.UInt64& value) { }
        private System.Boolean TryGetSFixed32(System.Int32 field, System.Int32& value) { }
        private System.Boolean TryGetSFixed64(System.Int32 field, System.Int64& value) { }
        private System.Boolean TryGetSInt32(System.Int32 field, System.Int32& value) { }
        private System.Boolean TryGetSInt64(System.Int32 field, System.Int64& value) { }
        private System.Boolean TryGetUInt32(System.Int32 field, System.UInt32& value) { }
        private System.Boolean TryGetUInt64(System.Int32 field, System.UInt64& value) { }
        private System.Boolean TryGetFloat(System.Int32 field, System.Single& value) { }
        private System.Boolean TryGetDouble(System.Int32 field, System.Double& value) { }
        private System.Boolean TryGetString(System.Int32 field, System.String& value) { }
        private System.Boolean TryGetBytes(System.Int32 field, Google.Protobuf.ByteString& value) { }
        private System.Boolean TryGetMessage(System.Int32 field, T& value) { }
        private System.Boolean TryGetPrimitiveValue(System.Int32 field, T& value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A8
    public class DescriptorReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A9
    public class FileDescriptorSet, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorSet> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 FileFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FileDescriptorProto> _repeated_file_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FileDescriptorProto> file_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorSet> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.FileDescriptorSet other) { }
        private Google.Protobuf.Reflection.FileDescriptorSet Clone() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FileDescriptorProto> get_File() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.FileDescriptorSet other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.FileDescriptorSet other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AB
    public class FileDescriptorProto, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorProto> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private static readonly System.String NameDefaultValue;        // 0x8
        private System.String name_;        // 0x18
        public static System.Int32 PackageFieldNumber;        // 0x0
        private static readonly System.String PackageDefaultValue;        // 0x10
        private System.String package_;        // 0x20
        public static System.Int32 DependencyFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_dependency_codec;        // 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> dependency_;        // 0x28
        public static System.Int32 PublicDependencyFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<System.Int32> _repeated_publicDependency_codec;        // 0x20
        private readonly Google.Protobuf.Collections.RepeatedField<System.Int32> publicDependency_;        // 0x30
        public static System.Int32 WeakDependencyFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<System.Int32> _repeated_weakDependency_codec;        // 0x28
        private readonly Google.Protobuf.Collections.RepeatedField<System.Int32> weakDependency_;        // 0x38
        public static System.Int32 MessageTypeFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto> _repeated_messageType_codec;        // 0x30
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> messageType_;        // 0x40
        public static System.Int32 EnumTypeFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto> _repeated_enumType_codec;        // 0x38
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> enumType_;        // 0x48
        public static System.Int32 ServiceFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.ServiceDescriptorProto> _repeated_service_codec;        // 0x40
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.ServiceDescriptorProto> service_;        // 0x50
        public static System.Int32 ExtensionFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_extension_codec;        // 0x48
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> extension_;        // 0x58
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private Google.Protobuf.Reflection.FileOptions options_;        // 0x60
        public static System.Int32 SourceCodeInfoFieldNumber;        // 0x0
        private Google.Protobuf.Reflection.SourceCodeInfo sourceCodeInfo_;        // 0x68
        public static System.Int32 SyntaxFieldNumber;        // 0x0
        private static readonly System.String SyntaxDefaultValue;        // 0x50
        private System.String syntax_;        // 0x70

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorProto> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.FileDescriptorProto other) { }
        private Google.Protobuf.Reflection.FileDescriptorProto Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_HasName() { }
        private System.Void ClearName() { }
        private System.String get_Package() { }
        private System.Void set_Package(System.String value) { }
        private System.Boolean get_HasPackage() { }
        private System.Void ClearPackage() { }
        private Google.Protobuf.Collections.RepeatedField<System.String> get_Dependency() { }
        private Google.Protobuf.Collections.RepeatedField<System.Int32> get_PublicDependency() { }
        private Google.Protobuf.Collections.RepeatedField<System.Int32> get_WeakDependency() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> get_MessageType() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> get_EnumType() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.ServiceDescriptorProto> get_Service() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Extension() { }
        private Google.Protobuf.Reflection.FileOptions get_Options() { }
        private System.Void set_Options(Google.Protobuf.Reflection.FileOptions value) { }
        private Google.Protobuf.Reflection.SourceCodeInfo get_SourceCodeInfo() { }
        private System.Void set_SourceCodeInfo(Google.Protobuf.Reflection.SourceCodeInfo value) { }
        private System.String get_Syntax() { }
        private System.Void set_Syntax(System.String value) { }
        private System.Boolean get_HasSyntax() { }
        private System.Void ClearSyntax() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.FileDescriptorProto other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.FileDescriptorProto other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AD
    public class DescriptorProto, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private static readonly System.String NameDefaultValue;        // 0x8
        private System.String name_;        // 0x18
        public static System.Int32 FieldFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_field_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> field_;        // 0x20
        public static System.Int32 ExtensionFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_extension_codec;        // 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> extension_;        // 0x28
        public static System.Int32 NestedTypeFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto> _repeated_nestedType_codec;        // 0x20
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> nestedType_;        // 0x30
        public static System.Int32 EnumTypeFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto> _repeated_enumType_codec;        // 0x28
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> enumType_;        // 0x38
        public static System.Int32 ExtensionRangeFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> _repeated_extensionRange_codec;        // 0x30
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> extensionRange_;        // 0x40
        public static System.Int32 OneofDeclFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.OneofDescriptorProto> _repeated_oneofDecl_codec;        // 0x38
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.OneofDescriptorProto> oneofDecl_;        // 0x48
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private Google.Protobuf.Reflection.MessageOptions options_;        // 0x50
        public static System.Int32 ReservedRangeFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> _repeated_reservedRange_codec;        // 0x40
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> reservedRange_;        // 0x58
        public static System.Int32 ReservedNameFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_reservedName_codec;        // 0x48
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> reservedName_;        // 0x60

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto other) { }
        private Google.Protobuf.Reflection.DescriptorProto Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_HasName() { }
        private System.Void ClearName() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Field() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Extension() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> get_NestedType() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> get_EnumType() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> get_ExtensionRange() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.OneofDescriptorProto> get_OneofDecl() { }
        private Google.Protobuf.Reflection.MessageOptions get_Options() { }
        private System.Void set_Options(Google.Protobuf.Reflection.MessageOptions value) { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> get_ReservedRange() { }
        private Google.Protobuf.Collections.RepeatedField<System.String> get_ReservedName() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.DescriptorProto other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.DescriptorProto other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B4
    public class ExtensionRangeOptions, IExtendableMessage`1, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ExtensionRangeOptions> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ExtensionRangeOptions> _extensions;        // 0x18
        public static System.Int32 UninterpretedOptionFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;        // 0x20

        // Methods
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ExtensionRangeOptions> get__Extensions() { }
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ExtensionRangeOptions> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.ExtensionRangeOptions other) { }
        private Google.Protobuf.Reflection.ExtensionRangeOptions Clone() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.ExtensionRangeOptions other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.ExtensionRangeOptions other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        private System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension, TValue value) { }
        private System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions,TValue> extension) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B6
    public class FieldDescriptorProto, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldDescriptorProto> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private System.Int32 _hasBits0;        // 0x18
        public static System.Int32 NameFieldNumber;        // 0x0
        private static readonly System.String NameDefaultValue;        // 0x8
        private System.String name_;        // 0x20
        public static System.Int32 NumberFieldNumber;        // 0x0
        private static readonly System.Int32 NumberDefaultValue;        // 0x10
        private System.Int32 number_;        // 0x28
        public static System.Int32 LabelFieldNumber;        // 0x0
        private static readonly Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label LabelDefaultValue;        // 0x14
        private Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label label_;        // 0x2C
        public static System.Int32 TypeFieldNumber;        // 0x0
        private static readonly Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type TypeDefaultValue;        // 0x18
        private Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type_;        // 0x30
        public static System.Int32 TypeNameFieldNumber;        // 0x0
        private static readonly System.String TypeNameDefaultValue;        // 0x20
        private System.String typeName_;        // 0x38
        public static System.Int32 ExtendeeFieldNumber;        // 0x0
        private static readonly System.String ExtendeeDefaultValue;        // 0x28
        private System.String extendee_;        // 0x40
        public static System.Int32 DefaultValueFieldNumber;        // 0x0
        private static readonly System.String DefaultValueDefaultValue;        // 0x30
        private System.String defaultValue_;        // 0x48
        public static System.Int32 OneofIndexFieldNumber;        // 0x0
        private static readonly System.Int32 OneofIndexDefaultValue;        // 0x38
        private System.Int32 oneofIndex_;        // 0x50
        public static System.Int32 JsonNameFieldNumber;        // 0x0
        private static readonly System.String JsonNameDefaultValue;        // 0x40
        private System.String jsonName_;        // 0x58
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private Google.Protobuf.Reflection.FieldOptions options_;        // 0x60
        public static System.Int32 Proto3OptionalFieldNumber;        // 0x0
        private static readonly System.Boolean Proto3OptionalDefaultValue;        // 0x48
        private System.Boolean proto3Optional_;        // 0x68

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldDescriptorProto> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptorProto other) { }
        private Google.Protobuf.Reflection.FieldDescriptorProto Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_HasName() { }
        private System.Void ClearName() { }
        private System.Int32 get_Number() { }
        private System.Void set_Number(System.Int32 value) { }
        private System.Boolean get_HasNumber() { }
        private System.Void ClearNumber() { }
        private Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label get_Label() { }
        private System.Void set_Label(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label value) { }
        private System.Boolean get_HasLabel() { }
        private System.Void ClearLabel() { }
        private Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type get_Type() { }
        private System.Void set_Type(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type value) { }
        private System.Boolean get_HasType() { }
        private System.Void ClearType() { }
        private System.String get_TypeName() { }
        private System.Void set_TypeName(System.String value) { }
        private System.Boolean get_HasTypeName() { }
        private System.Void ClearTypeName() { }
        private System.String get_Extendee() { }
        private System.Void set_Extendee(System.String value) { }
        private System.Boolean get_HasExtendee() { }
        private System.Void ClearExtendee() { }
        private System.String get_DefaultValue() { }
        private System.Void set_DefaultValue(System.String value) { }
        private System.Boolean get_HasDefaultValue() { }
        private System.Void ClearDefaultValue() { }
        private System.Int32 get_OneofIndex() { }
        private System.Void set_OneofIndex(System.Int32 value) { }
        private System.Boolean get_HasOneofIndex() { }
        private System.Void ClearOneofIndex() { }
        private System.String get_JsonName() { }
        private System.Void set_JsonName(System.String value) { }
        private System.Boolean get_HasJsonName() { }
        private System.Void ClearJsonName() { }
        private Google.Protobuf.Reflection.FieldOptions get_Options() { }
        private System.Void set_Options(Google.Protobuf.Reflection.FieldOptions value) { }
        private System.Boolean get_Proto3Optional() { }
        private System.Void set_Proto3Optional(System.Boolean value) { }
        private System.Boolean get_HasProto3Optional() { }
        private System.Void ClearProto3Optional() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.FieldDescriptorProto other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.FieldDescriptorProto other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BB
    public class OneofDescriptorProto, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofDescriptorProto> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private static readonly System.String NameDefaultValue;        // 0x8
        private System.String name_;        // 0x18
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private Google.Protobuf.Reflection.OneofOptions options_;        // 0x20

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofDescriptorProto> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptorProto other) { }
        private Google.Protobuf.Reflection.OneofDescriptorProto Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_HasName() { }
        private System.Void ClearName() { }
        private Google.Protobuf.Reflection.OneofOptions get_Options() { }
        private System.Void set_Options(Google.Protobuf.Reflection.OneofOptions value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.OneofDescriptorProto other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.OneofDescriptorProto other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BD
    public class EnumDescriptorProto, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private static readonly System.String NameDefaultValue;        // 0x8
        private System.String name_;        // 0x18
        public static System.Int32 ValueFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumValueDescriptorProto> _repeated_value_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumValueDescriptorProto> value_;        // 0x20
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private Google.Protobuf.Reflection.EnumOptions options_;        // 0x28
        public static System.Int32 ReservedRangeFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> _repeated_reservedRange_codec;        // 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> reservedRange_;        // 0x30
        public static System.Int32 ReservedNameFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_reservedName_codec;        // 0x20
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> reservedName_;        // 0x38

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto other) { }
        private Google.Protobuf.Reflection.EnumDescriptorProto Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_HasName() { }
        private System.Void ClearName() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumValueDescriptorProto> get_Value() { }
        private Google.Protobuf.Reflection.EnumOptions get_Options() { }
        private System.Void set_Options(Google.Protobuf.Reflection.EnumOptions value) { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> get_ReservedRange() { }
        private Google.Protobuf.Collections.RepeatedField<System.String> get_ReservedName() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.EnumDescriptorProto other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C2
    public class EnumValueDescriptorProto, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueDescriptorProto> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private System.Int32 _hasBits0;        // 0x18
        public static System.Int32 NameFieldNumber;        // 0x0
        private static readonly System.String NameDefaultValue;        // 0x8
        private System.String name_;        // 0x20
        public static System.Int32 NumberFieldNumber;        // 0x0
        private static readonly System.Int32 NumberDefaultValue;        // 0x10
        private System.Int32 number_;        // 0x28
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private Google.Protobuf.Reflection.EnumValueOptions options_;        // 0x30

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueDescriptorProto> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.EnumValueDescriptorProto other) { }
        private Google.Protobuf.Reflection.EnumValueDescriptorProto Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_HasName() { }
        private System.Void ClearName() { }
        private System.Int32 get_Number() { }
        private System.Void set_Number(System.Int32 value) { }
        private System.Boolean get_HasNumber() { }
        private System.Void ClearNumber() { }
        private Google.Protobuf.Reflection.EnumValueOptions get_Options() { }
        private System.Void set_Options(Google.Protobuf.Reflection.EnumValueOptions value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.EnumValueDescriptorProto other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.EnumValueDescriptorProto other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C4
    public class ServiceDescriptorProto, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceDescriptorProto> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private static readonly System.String NameDefaultValue;        // 0x8
        private System.String name_;        // 0x18
        public static System.Int32 MethodFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.MethodDescriptorProto> _repeated_method_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.MethodDescriptorProto> method_;        // 0x20
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private Google.Protobuf.Reflection.ServiceOptions options_;        // 0x28

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceDescriptorProto> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.ServiceDescriptorProto other) { }
        private Google.Protobuf.Reflection.ServiceDescriptorProto Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_HasName() { }
        private System.Void ClearName() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.MethodDescriptorProto> get_Method() { }
        private Google.Protobuf.Reflection.ServiceOptions get_Options() { }
        private System.Void set_Options(Google.Protobuf.Reflection.ServiceOptions value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.ServiceDescriptorProto other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.ServiceDescriptorProto other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C6
    public class MethodDescriptorProto, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodDescriptorProto> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private System.Int32 _hasBits0;        // 0x18
        public static System.Int32 NameFieldNumber;        // 0x0
        private static readonly System.String NameDefaultValue;        // 0x8
        private System.String name_;        // 0x20
        public static System.Int32 InputTypeFieldNumber;        // 0x0
        private static readonly System.String InputTypeDefaultValue;        // 0x10
        private System.String inputType_;        // 0x28
        public static System.Int32 OutputTypeFieldNumber;        // 0x0
        private static readonly System.String OutputTypeDefaultValue;        // 0x18
        private System.String outputType_;        // 0x30
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private Google.Protobuf.Reflection.MethodOptions options_;        // 0x38
        public static System.Int32 ClientStreamingFieldNumber;        // 0x0
        private static readonly System.Boolean ClientStreamingDefaultValue;        // 0x20
        private System.Boolean clientStreaming_;        // 0x40
        public static System.Int32 ServerStreamingFieldNumber;        // 0x0
        private static readonly System.Boolean ServerStreamingDefaultValue;        // 0x21
        private System.Boolean serverStreaming_;        // 0x41

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodDescriptorProto> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.MethodDescriptorProto other) { }
        private Google.Protobuf.Reflection.MethodDescriptorProto Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_HasName() { }
        private System.Void ClearName() { }
        private System.String get_InputType() { }
        private System.Void set_InputType(System.String value) { }
        private System.Boolean get_HasInputType() { }
        private System.Void ClearInputType() { }
        private System.String get_OutputType() { }
        private System.Void set_OutputType(System.String value) { }
        private System.Boolean get_HasOutputType() { }
        private System.Void ClearOutputType() { }
        private Google.Protobuf.Reflection.MethodOptions get_Options() { }
        private System.Void set_Options(Google.Protobuf.Reflection.MethodOptions value) { }
        private System.Boolean get_ClientStreaming() { }
        private System.Void set_ClientStreaming(System.Boolean value) { }
        private System.Boolean get_HasClientStreaming() { }
        private System.Void ClearClientStreaming() { }
        private System.Boolean get_ServerStreaming() { }
        private System.Void set_ServerStreaming(System.Boolean value) { }
        private System.Boolean get_HasServerStreaming() { }
        private System.Void ClearServerStreaming() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.MethodDescriptorProto other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.MethodDescriptorProto other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C8
    public class FileOptions, IExtendableMessage`1, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileOptions> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FileOptions> _extensions;        // 0x18
        private System.Int32 _hasBits0;        // 0x20
        public static System.Int32 JavaPackageFieldNumber;        // 0x0
        private static readonly System.String JavaPackageDefaultValue;        // 0x8
        private System.String javaPackage_;        // 0x28
        public static System.Int32 JavaOuterClassnameFieldNumber;        // 0x0
        private static readonly System.String JavaOuterClassnameDefaultValue;        // 0x10
        private System.String javaOuterClassname_;        // 0x30
        public static System.Int32 JavaMultipleFilesFieldNumber;        // 0x0
        private static readonly System.Boolean JavaMultipleFilesDefaultValue;        // 0x18
        private System.Boolean javaMultipleFiles_;        // 0x38
        public static System.Int32 JavaGenerateEqualsAndHashFieldNumber;        // 0x0
        private static readonly System.Boolean JavaGenerateEqualsAndHashDefaultValue;        // 0x19
        private System.Boolean javaGenerateEqualsAndHash_;        // 0x39
        public static System.Int32 JavaStringCheckUtf8FieldNumber;        // 0x0
        private static readonly System.Boolean JavaStringCheckUtf8DefaultValue;        // 0x1A
        private System.Boolean javaStringCheckUtf8_;        // 0x3A
        public static System.Int32 OptimizeForFieldNumber;        // 0x0
        private static readonly Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode OptimizeForDefaultValue;        // 0x1C
        private Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode optimizeFor_;        // 0x3C
        public static System.Int32 GoPackageFieldNumber;        // 0x0
        private static readonly System.String GoPackageDefaultValue;        // 0x20
        private System.String goPackage_;        // 0x40
        public static System.Int32 CcGenericServicesFieldNumber;        // 0x0
        private static readonly System.Boolean CcGenericServicesDefaultValue;        // 0x28
        private System.Boolean ccGenericServices_;        // 0x48
        public static System.Int32 JavaGenericServicesFieldNumber;        // 0x0
        private static readonly System.Boolean JavaGenericServicesDefaultValue;        // 0x29
        private System.Boolean javaGenericServices_;        // 0x49
        public static System.Int32 PyGenericServicesFieldNumber;        // 0x0
        private static readonly System.Boolean PyGenericServicesDefaultValue;        // 0x2A
        private System.Boolean pyGenericServices_;        // 0x4A
        public static System.Int32 PhpGenericServicesFieldNumber;        // 0x0
        private static readonly System.Boolean PhpGenericServicesDefaultValue;        // 0x2B
        private System.Boolean phpGenericServices_;        // 0x4B
        public static System.Int32 DeprecatedFieldNumber;        // 0x0
        private static readonly System.Boolean DeprecatedDefaultValue;        // 0x2C
        private System.Boolean deprecated_;        // 0x4C
        public static System.Int32 CcEnableArenasFieldNumber;        // 0x0
        private static readonly System.Boolean CcEnableArenasDefaultValue;        // 0x2D
        private System.Boolean ccEnableArenas_;        // 0x4D
        public static System.Int32 ObjcClassPrefixFieldNumber;        // 0x0
        private static readonly System.String ObjcClassPrefixDefaultValue;        // 0x30
        private System.String objcClassPrefix_;        // 0x50
        public static System.Int32 CsharpNamespaceFieldNumber;        // 0x0
        private static readonly System.String CsharpNamespaceDefaultValue;        // 0x38
        private System.String csharpNamespace_;        // 0x58
        public static System.Int32 SwiftPrefixFieldNumber;        // 0x0
        private static readonly System.String SwiftPrefixDefaultValue;        // 0x40
        private System.String swiftPrefix_;        // 0x60
        public static System.Int32 PhpClassPrefixFieldNumber;        // 0x0
        private static readonly System.String PhpClassPrefixDefaultValue;        // 0x48
        private System.String phpClassPrefix_;        // 0x68
        public static System.Int32 PhpNamespaceFieldNumber;        // 0x0
        private static readonly System.String PhpNamespaceDefaultValue;        // 0x50
        private System.String phpNamespace_;        // 0x70
        public static System.Int32 PhpMetadataNamespaceFieldNumber;        // 0x0
        private static readonly System.String PhpMetadataNamespaceDefaultValue;        // 0x58
        private System.String phpMetadataNamespace_;        // 0x78
        public static System.Int32 RubyPackageFieldNumber;        // 0x0
        private static readonly System.String RubyPackageDefaultValue;        // 0x60
        private System.String rubyPackage_;        // 0x80
        public static System.Int32 UninterpretedOptionFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;        // 0x68
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;        // 0x88

        // Methods
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FileOptions> get__Extensions() { }
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileOptions> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.FileOptions other) { }
        private Google.Protobuf.Reflection.FileOptions Clone() { }
        private System.String get_JavaPackage() { }
        private System.Void set_JavaPackage(System.String value) { }
        private System.Boolean get_HasJavaPackage() { }
        private System.Void ClearJavaPackage() { }
        private System.String get_JavaOuterClassname() { }
        private System.Void set_JavaOuterClassname(System.String value) { }
        private System.Boolean get_HasJavaOuterClassname() { }
        private System.Void ClearJavaOuterClassname() { }
        private System.Boolean get_JavaMultipleFiles() { }
        private System.Void set_JavaMultipleFiles(System.Boolean value) { }
        private System.Boolean get_HasJavaMultipleFiles() { }
        private System.Void ClearJavaMultipleFiles() { }
        private System.Boolean get_JavaGenerateEqualsAndHash() { }
        private System.Void set_JavaGenerateEqualsAndHash(System.Boolean value) { }
        private System.Boolean get_HasJavaGenerateEqualsAndHash() { }
        private System.Void ClearJavaGenerateEqualsAndHash() { }
        private System.Boolean get_JavaStringCheckUtf8() { }
        private System.Void set_JavaStringCheckUtf8(System.Boolean value) { }
        private System.Boolean get_HasJavaStringCheckUtf8() { }
        private System.Void ClearJavaStringCheckUtf8() { }
        private Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode get_OptimizeFor() { }
        private System.Void set_OptimizeFor(Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode value) { }
        private System.Boolean get_HasOptimizeFor() { }
        private System.Void ClearOptimizeFor() { }
        private System.String get_GoPackage() { }
        private System.Void set_GoPackage(System.String value) { }
        private System.Boolean get_HasGoPackage() { }
        private System.Void ClearGoPackage() { }
        private System.Boolean get_CcGenericServices() { }
        private System.Void set_CcGenericServices(System.Boolean value) { }
        private System.Boolean get_HasCcGenericServices() { }
        private System.Void ClearCcGenericServices() { }
        private System.Boolean get_JavaGenericServices() { }
        private System.Void set_JavaGenericServices(System.Boolean value) { }
        private System.Boolean get_HasJavaGenericServices() { }
        private System.Void ClearJavaGenericServices() { }
        private System.Boolean get_PyGenericServices() { }
        private System.Void set_PyGenericServices(System.Boolean value) { }
        private System.Boolean get_HasPyGenericServices() { }
        private System.Void ClearPyGenericServices() { }
        private System.Boolean get_PhpGenericServices() { }
        private System.Void set_PhpGenericServices(System.Boolean value) { }
        private System.Boolean get_HasPhpGenericServices() { }
        private System.Void ClearPhpGenericServices() { }
        private System.Boolean get_Deprecated() { }
        private System.Void set_Deprecated(System.Boolean value) { }
        private System.Boolean get_HasDeprecated() { }
        private System.Void ClearDeprecated() { }
        private System.Boolean get_CcEnableArenas() { }
        private System.Void set_CcEnableArenas(System.Boolean value) { }
        private System.Boolean get_HasCcEnableArenas() { }
        private System.Void ClearCcEnableArenas() { }
        private System.String get_ObjcClassPrefix() { }
        private System.Void set_ObjcClassPrefix(System.String value) { }
        private System.Boolean get_HasObjcClassPrefix() { }
        private System.Void ClearObjcClassPrefix() { }
        private System.String get_CsharpNamespace() { }
        private System.Void set_CsharpNamespace(System.String value) { }
        private System.Boolean get_HasCsharpNamespace() { }
        private System.Void ClearCsharpNamespace() { }
        private System.String get_SwiftPrefix() { }
        private System.Void set_SwiftPrefix(System.String value) { }
        private System.Boolean get_HasSwiftPrefix() { }
        private System.Void ClearSwiftPrefix() { }
        private System.String get_PhpClassPrefix() { }
        private System.Void set_PhpClassPrefix(System.String value) { }
        private System.Boolean get_HasPhpClassPrefix() { }
        private System.Void ClearPhpClassPrefix() { }
        private System.String get_PhpNamespace() { }
        private System.Void set_PhpNamespace(System.String value) { }
        private System.Boolean get_HasPhpNamespace() { }
        private System.Void ClearPhpNamespace() { }
        private System.String get_PhpMetadataNamespace() { }
        private System.Void set_PhpMetadataNamespace(System.String value) { }
        private System.Boolean get_HasPhpMetadataNamespace() { }
        private System.Void ClearPhpMetadataNamespace() { }
        private System.String get_RubyPackage() { }
        private System.Void set_RubyPackage(System.String value) { }
        private System.Boolean get_HasRubyPackage() { }
        private System.Void ClearRubyPackage() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.FileOptions other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.FileOptions other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        private System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension, TValue value) { }
        private System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,TValue> extension) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000CC
    public class MessageOptions, IExtendableMessage`1, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MessageOptions> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MessageOptions> _extensions;        // 0x18
        private System.Int32 _hasBits0;        // 0x20
        public static System.Int32 MessageSetWireFormatFieldNumber;        // 0x0
        private static readonly System.Boolean MessageSetWireFormatDefaultValue;        // 0x8
        private System.Boolean messageSetWireFormat_;        // 0x24
        public static System.Int32 NoStandardDescriptorAccessorFieldNumber;        // 0x0
        private static readonly System.Boolean NoStandardDescriptorAccessorDefaultValue;        // 0x9
        private System.Boolean noStandardDescriptorAccessor_;        // 0x25
        public static System.Int32 DeprecatedFieldNumber;        // 0x0
        private static readonly System.Boolean DeprecatedDefaultValue;        // 0xA
        private System.Boolean deprecated_;        // 0x26
        public static System.Int32 MapEntryFieldNumber;        // 0x0
        private static readonly System.Boolean MapEntryDefaultValue;        // 0xB
        private System.Boolean mapEntry_;        // 0x27
        public static System.Int32 UninterpretedOptionFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;        // 0x28

        // Methods
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MessageOptions> get__Extensions() { }
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MessageOptions> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.MessageOptions other) { }
        private Google.Protobuf.Reflection.MessageOptions Clone() { }
        private System.Boolean get_MessageSetWireFormat() { }
        private System.Void set_MessageSetWireFormat(System.Boolean value) { }
        private System.Boolean get_HasMessageSetWireFormat() { }
        private System.Void ClearMessageSetWireFormat() { }
        private System.Boolean get_NoStandardDescriptorAccessor() { }
        private System.Void set_NoStandardDescriptorAccessor(System.Boolean value) { }
        private System.Boolean get_HasNoStandardDescriptorAccessor() { }
        private System.Void ClearNoStandardDescriptorAccessor() { }
        private System.Boolean get_Deprecated() { }
        private System.Void set_Deprecated(System.Boolean value) { }
        private System.Boolean get_HasDeprecated() { }
        private System.Void ClearDeprecated() { }
        private System.Boolean get_MapEntry() { }
        private System.Void set_MapEntry(System.Boolean value) { }
        private System.Boolean get_HasMapEntry() { }
        private System.Void ClearMapEntry() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.MessageOptions other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.MessageOptions other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        private System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension, TValue value) { }
        private System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,TValue> extension) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000CE
    public class FieldOptions, IExtendableMessage`1, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldOptions> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FieldOptions> _extensions;        // 0x18
        private System.Int32 _hasBits0;        // 0x20
        public static System.Int32 CtypeFieldNumber;        // 0x0
        private static readonly Google.Protobuf.Reflection.FieldOptions.Types.CType CtypeDefaultValue;        // 0x8
        private Google.Protobuf.Reflection.FieldOptions.Types.CType ctype_;        // 0x24
        public static System.Int32 PackedFieldNumber;        // 0x0
        private static readonly System.Boolean PackedDefaultValue;        // 0xC
        private System.Boolean packed_;        // 0x28
        public static System.Int32 JstypeFieldNumber;        // 0x0
        private static readonly Google.Protobuf.Reflection.FieldOptions.Types.JSType JstypeDefaultValue;        // 0x10
        private Google.Protobuf.Reflection.FieldOptions.Types.JSType jstype_;        // 0x2C
        public static System.Int32 LazyFieldNumber;        // 0x0
        private static readonly System.Boolean LazyDefaultValue;        // 0x14
        private System.Boolean lazy_;        // 0x30
        public static System.Int32 UnverifiedLazyFieldNumber;        // 0x0
        private static readonly System.Boolean UnverifiedLazyDefaultValue;        // 0x15
        private System.Boolean unverifiedLazy_;        // 0x31
        public static System.Int32 DeprecatedFieldNumber;        // 0x0
        private static readonly System.Boolean DeprecatedDefaultValue;        // 0x16
        private System.Boolean deprecated_;        // 0x32
        public static System.Int32 WeakFieldNumber;        // 0x0
        private static readonly System.Boolean WeakDefaultValue;        // 0x17
        private System.Boolean weak_;        // 0x33
        public static System.Int32 UninterpretedOptionFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;        // 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;        // 0x38

        // Methods
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FieldOptions> get__Extensions() { }
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldOptions> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.FieldOptions other) { }
        private Google.Protobuf.Reflection.FieldOptions Clone() { }
        private Google.Protobuf.Reflection.FieldOptions.Types.CType get_Ctype() { }
        private System.Void set_Ctype(Google.Protobuf.Reflection.FieldOptions.Types.CType value) { }
        private System.Boolean get_HasCtype() { }
        private System.Void ClearCtype() { }
        private System.Boolean get_Packed() { }
        private System.Void set_Packed(System.Boolean value) { }
        private System.Boolean get_HasPacked() { }
        private System.Void ClearPacked() { }
        private Google.Protobuf.Reflection.FieldOptions.Types.JSType get_Jstype() { }
        private System.Void set_Jstype(Google.Protobuf.Reflection.FieldOptions.Types.JSType value) { }
        private System.Boolean get_HasJstype() { }
        private System.Void ClearJstype() { }
        private System.Boolean get_Lazy() { }
        private System.Void set_Lazy(System.Boolean value) { }
        private System.Boolean get_HasLazy() { }
        private System.Void ClearLazy() { }
        private System.Boolean get_UnverifiedLazy() { }
        private System.Void set_UnverifiedLazy(System.Boolean value) { }
        private System.Boolean get_HasUnverifiedLazy() { }
        private System.Void ClearUnverifiedLazy() { }
        private System.Boolean get_Deprecated() { }
        private System.Void set_Deprecated(System.Boolean value) { }
        private System.Boolean get_HasDeprecated() { }
        private System.Void ClearDeprecated() { }
        private System.Boolean get_Weak() { }
        private System.Void set_Weak(System.Boolean value) { }
        private System.Boolean get_HasWeak() { }
        private System.Void ClearWeak() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.FieldOptions other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.FieldOptions other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        private System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension, TValue value) { }
        private System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,TValue> extension) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D3
    public class OneofOptions, IExtendableMessage`1, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofOptions> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.OneofOptions> _extensions;        // 0x18
        public static System.Int32 UninterpretedOptionFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;        // 0x20

        // Methods
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.OneofOptions> get__Extensions() { }
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofOptions> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.OneofOptions other) { }
        private Google.Protobuf.Reflection.OneofOptions Clone() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.OneofOptions other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.OneofOptions other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        private System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension, TValue value) { }
        private System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,TValue> extension) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D5
    public class EnumOptions, IExtendableMessage`1, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumOptions> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumOptions> _extensions;        // 0x18
        private System.Int32 _hasBits0;        // 0x20
        public static System.Int32 AllowAliasFieldNumber;        // 0x0
        private static readonly System.Boolean AllowAliasDefaultValue;        // 0x8
        private System.Boolean allowAlias_;        // 0x24
        public static System.Int32 DeprecatedFieldNumber;        // 0x0
        private static readonly System.Boolean DeprecatedDefaultValue;        // 0x9
        private System.Boolean deprecated_;        // 0x25
        public static System.Int32 UninterpretedOptionFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;        // 0x28

        // Methods
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumOptions> get__Extensions() { }
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumOptions> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.EnumOptions other) { }
        private Google.Protobuf.Reflection.EnumOptions Clone() { }
        private System.Boolean get_AllowAlias() { }
        private System.Void set_AllowAlias(System.Boolean value) { }
        private System.Boolean get_HasAllowAlias() { }
        private System.Void ClearAllowAlias() { }
        private System.Boolean get_Deprecated() { }
        private System.Void set_Deprecated(System.Boolean value) { }
        private System.Boolean get_HasDeprecated() { }
        private System.Void ClearDeprecated() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.EnumOptions other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.EnumOptions other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        private System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension, TValue value) { }
        private System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,TValue> extension) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D7
    public class EnumValueOptions, IExtendableMessage`1, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueOptions> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumValueOptions> _extensions;        // 0x18
        private System.Int32 _hasBits0;        // 0x20
        public static System.Int32 DeprecatedFieldNumber;        // 0x0
        private static readonly System.Boolean DeprecatedDefaultValue;        // 0x8
        private System.Boolean deprecated_;        // 0x24
        public static System.Int32 UninterpretedOptionFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;        // 0x28

        // Methods
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumValueOptions> get__Extensions() { }
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueOptions> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.EnumValueOptions other) { }
        private Google.Protobuf.Reflection.EnumValueOptions Clone() { }
        private System.Boolean get_Deprecated() { }
        private System.Void set_Deprecated(System.Boolean value) { }
        private System.Boolean get_HasDeprecated() { }
        private System.Void ClearDeprecated() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.EnumValueOptions other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.EnumValueOptions other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        private System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension, TValue value) { }
        private System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,TValue> extension) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D9
    public class ServiceOptions, IExtendableMessage`1, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceOptions> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ServiceOptions> _extensions;        // 0x18
        private System.Int32 _hasBits0;        // 0x20
        public static System.Int32 DeprecatedFieldNumber;        // 0x0
        private static readonly System.Boolean DeprecatedDefaultValue;        // 0x8
        private System.Boolean deprecated_;        // 0x24
        public static System.Int32 UninterpretedOptionFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;        // 0x28

        // Methods
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ServiceOptions> get__Extensions() { }
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceOptions> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.ServiceOptions other) { }
        private Google.Protobuf.Reflection.ServiceOptions Clone() { }
        private System.Boolean get_Deprecated() { }
        private System.Void set_Deprecated(System.Boolean value) { }
        private System.Boolean get_HasDeprecated() { }
        private System.Void ClearDeprecated() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.ServiceOptions other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.ServiceOptions other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        private System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension, TValue value) { }
        private System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,TValue> extension) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000DB
    public class MethodOptions, IExtendableMessage`1, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodOptions> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MethodOptions> _extensions;        // 0x18
        private System.Int32 _hasBits0;        // 0x20
        public static System.Int32 DeprecatedFieldNumber;        // 0x0
        private static readonly System.Boolean DeprecatedDefaultValue;        // 0x8
        private System.Boolean deprecated_;        // 0x24
        public static System.Int32 IdempotencyLevelFieldNumber;        // 0x0
        private static readonly Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel IdempotencyLevelDefaultValue;        // 0xC
        private Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel idempotencyLevel_;        // 0x28
        public static System.Int32 UninterpretedOptionFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;        // 0x30

        // Methods
        private Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MethodOptions> get__Extensions() { }
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodOptions> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.MethodOptions other) { }
        private Google.Protobuf.Reflection.MethodOptions Clone() { }
        private System.Boolean get_Deprecated() { }
        private System.Void set_Deprecated(System.Boolean value) { }
        private System.Boolean get_HasDeprecated() { }
        private System.Void ClearDeprecated() { }
        private Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel get_IdempotencyLevel() { }
        private System.Void set_IdempotencyLevel(Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel value) { }
        private System.Boolean get_HasIdempotencyLevel() { }
        private System.Void ClearIdempotencyLevel() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.MethodOptions other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.MethodOptions other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private TValue GetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        private Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        private System.Void SetExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension, TValue value) { }
        private System.Boolean HasExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        private System.Void ClearExtension(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,TValue> extension) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000DF
    public class UninterpretedOption, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        private System.Int32 _hasBits0;        // 0x18
        public static System.Int32 NameFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> _repeated_name_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> name_;        // 0x20
        public static System.Int32 IdentifierValueFieldNumber;        // 0x0
        private static readonly System.String IdentifierValueDefaultValue;        // 0x10
        private System.String identifierValue_;        // 0x28
        public static System.Int32 PositiveIntValueFieldNumber;        // 0x0
        private static readonly System.UInt64 PositiveIntValueDefaultValue;        // 0x18
        private System.UInt64 positiveIntValue_;        // 0x30
        public static System.Int32 NegativeIntValueFieldNumber;        // 0x0
        private static readonly System.Int64 NegativeIntValueDefaultValue;        // 0x20
        private System.Int64 negativeIntValue_;        // 0x38
        public static System.Int32 DoubleValueFieldNumber;        // 0x0
        private static readonly System.Double DoubleValueDefaultValue;        // 0x28
        private System.Double doubleValue_;        // 0x40
        public static System.Int32 StringValueFieldNumber;        // 0x0
        private static readonly Google.Protobuf.ByteString StringValueDefaultValue;        // 0x30
        private Google.Protobuf.ByteString stringValue_;        // 0x48
        public static System.Int32 AggregateValueFieldNumber;        // 0x0
        private static readonly System.String AggregateValueDefaultValue;        // 0x38
        private System.String aggregateValue_;        // 0x50

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.UninterpretedOption other) { }
        private Google.Protobuf.Reflection.UninterpretedOption Clone() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> get_Name() { }
        private System.String get_IdentifierValue() { }
        private System.Void set_IdentifierValue(System.String value) { }
        private System.Boolean get_HasIdentifierValue() { }
        private System.Void ClearIdentifierValue() { }
        private System.UInt64 get_PositiveIntValue() { }
        private System.Void set_PositiveIntValue(System.UInt64 value) { }
        private System.Boolean get_HasPositiveIntValue() { }
        private System.Void ClearPositiveIntValue() { }
        private System.Int64 get_NegativeIntValue() { }
        private System.Void set_NegativeIntValue(System.Int64 value) { }
        private System.Boolean get_HasNegativeIntValue() { }
        private System.Void ClearNegativeIntValue() { }
        private System.Double get_DoubleValue() { }
        private System.Void set_DoubleValue(System.Double value) { }
        private System.Boolean get_HasDoubleValue() { }
        private System.Void ClearDoubleValue() { }
        private Google.Protobuf.ByteString get_StringValue() { }
        private System.Void set_StringValue(Google.Protobuf.ByteString value) { }
        private System.Boolean get_HasStringValue() { }
        private System.Void ClearStringValue() { }
        private System.String get_AggregateValue() { }
        private System.Void set_AggregateValue(System.String value) { }
        private System.Boolean get_HasAggregateValue() { }
        private System.Void ClearAggregateValue() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.UninterpretedOption other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E4
    public class SourceCodeInfo, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 LocationFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> _repeated_location_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> location_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.SourceCodeInfo other) { }
        private Google.Protobuf.Reflection.SourceCodeInfo Clone() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> get_Location() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.SourceCodeInfo other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E9
    public class GeneratedCodeInfo, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 AnnotationFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> _repeated_annotation_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> annotation_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.Reflection.GeneratedCodeInfo other) { }
        private Google.Protobuf.Reflection.GeneratedCodeInfo Clone() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> get_Annotation() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.Reflection.GeneratedCodeInfo other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000EE
    public class DescriptorBase, IDescriptor
    {
        // Fields
        private readonly System.Int32 <Index>k__BackingField;        // 0x10
        private readonly System.String <FullName>k__BackingField;        // 0x18
        private readonly Google.Protobuf.Reflection.FileDescriptor <File>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(Google.Protobuf.Reflection.FileDescriptor file, System.String fullName, System.Int32 index) { }
        private System.Int32 get_Index() { }
        private System.String get_Name() { }
        private System.String get_FullName() { }
        private Google.Protobuf.Reflection.FileDescriptor get_File() { }
        private Google.Protobuf.Reflection.DescriptorDeclaration get_Declaration() { }
        private System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber) { }

    }

    // TypeToken: 0x20000EF
    public class DescriptorDeclaration
    {
        // Fields
        private readonly Google.Protobuf.Reflection.IDescriptor <Descriptor>k__BackingField;        // 0x10
        private readonly System.Int32 <StartLine>k__BackingField;        // 0x18
        private readonly System.Int32 <StartColumn>k__BackingField;        // 0x1C
        private readonly System.Int32 <EndLine>k__BackingField;        // 0x20
        private readonly System.Int32 <EndColumn>k__BackingField;        // 0x24
        private readonly System.String <LeadingComments>k__BackingField;        // 0x28
        private readonly System.String <TrailingComments>k__BackingField;        // 0x30
        private readonly System.Collections.Generic.IReadOnlyList<System.String> <LeadingDetachedComments>k__BackingField;        // 0x38

        // Methods
        private Google.Protobuf.Reflection.IDescriptor get_Descriptor() { }
        private System.Int32 get_StartLine() { }
        private System.Int32 get_StartColumn() { }
        private System.Int32 get_EndLine() { }
        private System.Int32 get_EndColumn() { }
        private System.String get_LeadingComments() { }
        private System.String get_TrailingComments() { }
        private System.Collections.Generic.IReadOnlyList<System.String> get_LeadingDetachedComments() { }
        private System.Void .ctor(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location) { }
        private Google.Protobuf.Reflection.DescriptorDeclaration FromProto(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location) { }

    }

    // TypeToken: 0x20000F0
    public class DescriptorPool
    {
        // Fields
        private readonly System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.IDescriptor> descriptorsByName;        // 0x10
        private readonly System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>,Google.Protobuf.Reflection.FieldDescriptor> fieldsByNumber;        // 0x18
        private readonly System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>,Google.Protobuf.Reflection.EnumValueDescriptor> enumValuesByNumber;        // 0x20
        private readonly System.Collections.Generic.HashSet<Google.Protobuf.Reflection.FileDescriptor> dependencies;        // 0x28
        private static readonly System.Text.RegularExpressions.Regex ValidationRegex;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencyFiles) { }
        private System.Void ImportPublicDependencies(Google.Protobuf.Reflection.FileDescriptor file) { }
        private T FindSymbol(System.String fullName) { }
        private System.Void AddPackage(System.String fullName, Google.Protobuf.Reflection.FileDescriptor file) { }
        private System.Void AddSymbol(Google.Protobuf.Reflection.IDescriptor descriptor) { }
        private System.Void ValidateSymbolName(Google.Protobuf.Reflection.IDescriptor descriptor) { }
        private Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor, System.Int32 number) { }
        private Google.Protobuf.Reflection.EnumValueDescriptor FindEnumValueByNumber(Google.Protobuf.Reflection.EnumDescriptor enumDescriptor, System.Int32 number) { }
        private System.Void AddFieldByNumber(Google.Protobuf.Reflection.FieldDescriptor field) { }
        private System.Void AddEnumValueByNumber(Google.Protobuf.Reflection.EnumValueDescriptor enumValue) { }
        private Google.Protobuf.Reflection.IDescriptor LookupSymbol(System.String name, Google.Protobuf.Reflection.IDescriptor relativeTo) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000F1
    public class DescriptorUtil
    {
        // Methods
        private System.Collections.Generic.IList<TOutput> ConvertAndMakeReadOnly(System.Collections.Generic.IList<TInput> input, Google.Protobuf.Reflection.DescriptorUtil.IndexedConverter<TInput,TOutput> converter) { }

    }

    // TypeToken: 0x20000F3
    public class DescriptorValidationException : Exception
    {
        // Fields
        private readonly System.String name;        // 0x90
        private readonly System.String description;        // 0x98

        // Methods
        private System.String get_ProblemSymbolName() { }
        private System.String get_Description() { }
        private System.Void .ctor(Google.Protobuf.Reflection.IDescriptor problemDescriptor, System.String description) { }
        private System.Void .ctor(Google.Protobuf.Reflection.IDescriptor problemDescriptor, System.String description, System.Exception cause) { }

    }

    // TypeToken: 0x20000F4
    public class EnumDescriptor : DescriptorBase
    {
        // Fields
        private readonly Google.Protobuf.Reflection.EnumDescriptorProto proto;        // 0x28
        private readonly Google.Protobuf.Reflection.MessageDescriptor containingType;        // 0x30
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumValueDescriptor> values;        // 0x38
        private readonly System.Type clrType;        // 0x40

        // Methods
        private System.Void .ctor(Google.Protobuf.Reflection.EnumDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.Type clrType) { }
        private Google.Protobuf.Reflection.EnumDescriptorProto get_Proto() { }
        private Google.Protobuf.Reflection.EnumDescriptorProto ToProto() { }
        private System.String get_Name() { }
        private System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber) { }
        private System.Type get_ClrType() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_ContainingType() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumValueDescriptor> get_Values() { }
        private Google.Protobuf.Reflection.EnumValueDescriptor FindValueByNumber(System.Int32 number) { }
        private Google.Protobuf.Reflection.EnumValueDescriptor FindValueByName(System.String name) { }
        private Google.Protobuf.Reflection.CustomOptions get_CustomOptions() { }
        private Google.Protobuf.Reflection.EnumOptions GetOptions() { }
        private T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions,T> extension) { }
        private Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions,T> extension) { }

    }

    // TypeToken: 0x20000F6
    public class EnumValueDescriptor : DescriptorBase
    {
        // Fields
        private readonly Google.Protobuf.Reflection.EnumDescriptor enumDescriptor;        // 0x28
        private readonly Google.Protobuf.Reflection.EnumValueDescriptorProto proto;        // 0x30

        // Methods
        private System.Void .ctor(Google.Protobuf.Reflection.EnumValueDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.EnumDescriptor parent, System.Int32 index) { }
        private Google.Protobuf.Reflection.EnumValueDescriptorProto get_Proto() { }
        private Google.Protobuf.Reflection.EnumValueDescriptorProto ToProto() { }
        private System.String get_Name() { }
        private System.Int32 get_Number() { }
        private Google.Protobuf.Reflection.EnumDescriptor get_EnumDescriptor() { }
        private Google.Protobuf.Reflection.CustomOptions get_CustomOptions() { }
        private Google.Protobuf.Reflection.EnumValueOptions GetOptions() { }
        private T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions,T> extension) { }
        private Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions,T> extension) { }

    }

    // TypeToken: 0x20000F7
    public class ExtensionAccessor, IFieldAccessor
    {
        // Fields
        private readonly Google.Protobuf.Extension extension;        // 0x10
        private readonly Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper helper;        // 0x18
        private readonly Google.Protobuf.Reflection.FieldDescriptor <Descriptor>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        private Google.Protobuf.Reflection.FieldDescriptor get_Descriptor() { }
        private System.Void Clear(Google.Protobuf.IMessage message) { }
        private System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        private System.Object GetValue(Google.Protobuf.IMessage message) { }
        private System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x20000F8
    public class ExtensionCollection
    {
        // Fields
        private System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> extensionsByTypeInDeclarationOrder;        // 0x10
        private System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor,System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> extensionsByTypeInNumberOrder;        // 0x18
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <UnorderedExtensions>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Extension[] extensions) { }
        private System.Void .ctor(Google.Protobuf.Reflection.MessageDescriptor message, Google.Protobuf.Extension[] extensions) { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> get_UnorderedExtensions() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInDeclarationOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInNumberOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        private System.Void CrossLink() { }

    }

    // TypeToken: 0x20000FC
    public class FieldAccessorBase, IFieldAccessor
    {
        // Fields
        private readonly System.Func<Google.Protobuf.IMessage,System.Object> getValueDelegate;        // 0x10
        private readonly Google.Protobuf.Reflection.FieldDescriptor descriptor;        // 0x18

        // Methods
        private System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        private Google.Protobuf.Reflection.FieldDescriptor get_Descriptor() { }
        private System.Object GetValue(Google.Protobuf.IMessage message) { }
        private System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        private System.Void Clear(Google.Protobuf.IMessage message) { }
        private System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x20000FD
    public class FieldDescriptor : DescriptorBase, IComparable`1
    {
        // Fields
        private Google.Protobuf.Reflection.EnumDescriptor enumType;        // 0x28
        private Google.Protobuf.Reflection.MessageDescriptor extendeeType;        // 0x30
        private Google.Protobuf.Reflection.MessageDescriptor messageType;        // 0x38
        private Google.Protobuf.Reflection.FieldType fieldType;        // 0x40
        private Google.Protobuf.Reflection.IFieldAccessor accessor;        // 0x48
        private readonly Google.Protobuf.Reflection.MessageDescriptor <ContainingType>k__BackingField;        // 0x50
        private readonly Google.Protobuf.Reflection.OneofDescriptor <ContainingOneof>k__BackingField;        // 0x58
        private readonly System.String <JsonName>k__BackingField;        // 0x60
        private readonly System.String <PropertyName>k__BackingField;        // 0x68
        private readonly Google.Protobuf.Reflection.FieldDescriptorProto <Proto>k__BackingField;        // 0x70
        private readonly Google.Protobuf.Extension <Extension>k__BackingField;        // 0x78

        // Methods
        private Google.Protobuf.Reflection.MessageDescriptor get_ContainingType() { }
        private Google.Protobuf.Reflection.OneofDescriptor get_ContainingOneof() { }
        private Google.Protobuf.Reflection.OneofDescriptor get_RealContainingOneof() { }
        private System.String get_JsonName() { }
        private System.String get_PropertyName() { }
        private System.Boolean get_HasPresence() { }
        private Google.Protobuf.Reflection.FieldDescriptorProto get_Proto() { }
        private Google.Protobuf.Reflection.FieldDescriptorProto ToProto() { }
        private Google.Protobuf.Extension get_Extension() { }
        private System.Void .ctor(Google.Protobuf.Reflection.FieldDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.String propertyName, Google.Protobuf.Extension extension) { }
        private System.String get_Name() { }
        private Google.Protobuf.Reflection.IFieldAccessor get_Accessor() { }
        private Google.Protobuf.Reflection.FieldType GetFieldTypeFromProtoType(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type) { }
        private System.Boolean get_IsRepeated() { }
        private System.Boolean get_IsRequired() { }
        private System.Boolean get_IsMap() { }
        private System.Boolean get_IsPacked() { }
        private System.Boolean get_IsExtension() { }
        private Google.Protobuf.Reflection.FieldType get_FieldType() { }
        private System.Int32 get_FieldNumber() { }
        private System.Int32 CompareTo(Google.Protobuf.Reflection.FieldDescriptor other) { }
        private Google.Protobuf.Reflection.EnumDescriptor get_EnumType() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_MessageType() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_ExtendeeType() { }
        private Google.Protobuf.Reflection.CustomOptions get_CustomOptions() { }
        private Google.Protobuf.Reflection.FieldOptions GetOptions() { }
        private T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions,T> extension) { }
        private Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions,T> extension) { }
        private System.Void CrossLink() { }
        private Google.Protobuf.Reflection.IFieldAccessor CreateAccessor() { }

    }

    // TypeToken: 0x20000FE
    public struct FieldType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.Reflection.FieldType Double;        // 0x0
        public static Google.Protobuf.Reflection.FieldType Float;        // 0x0
        public static Google.Protobuf.Reflection.FieldType Int64;        // 0x0
        public static Google.Protobuf.Reflection.FieldType UInt64;        // 0x0
        public static Google.Protobuf.Reflection.FieldType Int32;        // 0x0
        public static Google.Protobuf.Reflection.FieldType Fixed64;        // 0x0
        public static Google.Protobuf.Reflection.FieldType Fixed32;        // 0x0
        public static Google.Protobuf.Reflection.FieldType Bool;        // 0x0
        public static Google.Protobuf.Reflection.FieldType String;        // 0x0
        public static Google.Protobuf.Reflection.FieldType Group;        // 0x0
        public static Google.Protobuf.Reflection.FieldType Message;        // 0x0
        public static Google.Protobuf.Reflection.FieldType Bytes;        // 0x0
        public static Google.Protobuf.Reflection.FieldType UInt32;        // 0x0
        public static Google.Protobuf.Reflection.FieldType SFixed32;        // 0x0
        public static Google.Protobuf.Reflection.FieldType SFixed64;        // 0x0
        public static Google.Protobuf.Reflection.FieldType SInt32;        // 0x0
        public static Google.Protobuf.Reflection.FieldType SInt64;        // 0x0
        public static Google.Protobuf.Reflection.FieldType Enum;        // 0x0

    }

    // TypeToken: 0x20000FF
    public struct Syntax
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.Reflection.Syntax Proto2;        // 0x0
        public static Google.Protobuf.Reflection.Syntax Proto3;        // 0x0
        public static Google.Protobuf.Reflection.Syntax Unknown;        // 0x0

    }

    // TypeToken: 0x2000100
    public class FileDescriptor, IDescriptor
    {
        // Fields
        private readonly System.Lazy<System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor,Google.Protobuf.Reflection.DescriptorDeclaration>> declarations;        // 0x10
        private readonly Google.Protobuf.Reflection.FileDescriptorProto <Proto>k__BackingField;        // 0x18
        private readonly Google.Protobuf.Reflection.Syntax <Syntax>k__BackingField;        // 0x20
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> <MessageTypes>k__BackingField;        // 0x28
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> <EnumTypes>k__BackingField;        // 0x30
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.ServiceDescriptor> <Services>k__BackingField;        // 0x38
        private readonly Google.Protobuf.Reflection.ExtensionCollection <Extensions>k__BackingField;        // 0x40
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> <Dependencies>k__BackingField;        // 0x48
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> <PublicDependencies>k__BackingField;        // 0x50
        private readonly Google.Protobuf.ByteString <SerializedData>k__BackingField;        // 0x58
        private readonly Google.Protobuf.Reflection.DescriptorPool <DescriptorPool>k__BackingField;        // 0x60

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, Google.Protobuf.Reflection.DescriptorPool pool, System.Boolean allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo) { }
        private System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor,Google.Protobuf.Reflection.DescriptorDeclaration> CreateDeclarationMap() { }
        private Google.Protobuf.Reflection.IDescriptor FindDescriptorForPath(System.Collections.Generic.IList<System.Int32> path) { }
        private Google.Protobuf.Reflection.DescriptorBase GetDescriptorFromList(System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> list, System.Int32 index) { }
        private System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber) { }
        private Google.Protobuf.Reflection.DescriptorDeclaration GetDeclaration(Google.Protobuf.Reflection.IDescriptor descriptor) { }
        private System.String ComputeFullName(Google.Protobuf.Reflection.MessageDescriptor parent, System.String name) { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> DeterminePublicDependencies(Google.Protobuf.Reflection.FileDescriptor this, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, System.Boolean allowUnknownDependencies) { }
        private Google.Protobuf.Reflection.FileDescriptorProto get_Proto() { }
        private Google.Protobuf.Reflection.FileDescriptorProto ToProto() { }
        private Google.Protobuf.Reflection.Syntax get_Syntax() { }
        private System.String get_Name() { }
        private System.String get_Package() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> get_MessageTypes() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> get_EnumTypes() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.ServiceDescriptor> get_Services() { }
        private Google.Protobuf.Reflection.ExtensionCollection get_Extensions() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> get_Dependencies() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> get_PublicDependencies() { }
        private Google.Protobuf.ByteString get_SerializedData() { }
        private System.String Google.Protobuf.Reflection.IDescriptor.get_FullName() { }
        private Google.Protobuf.Reflection.FileDescriptor Google.Protobuf.Reflection.IDescriptor.get_File() { }
        private Google.Protobuf.Reflection.DescriptorPool get_DescriptorPool() { }
        private T FindTypeByName(System.String name) { }
        private Google.Protobuf.Reflection.FileDescriptor BuildFrom(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor[] dependencies, System.Boolean allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo) { }
        private System.Void CrossLink() { }
        private Google.Protobuf.Reflection.FileDescriptor FromGeneratedCode(System.Byte[] descriptorData, Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo) { }
        private System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllExtensions(Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedInfo) { }
        private System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllGeneratedExtensions(Google.Protobuf.Reflection.GeneratedClrTypeInfo generated) { }
        private System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensions(Google.Protobuf.Reflection.FileDescriptor descriptor) { }
        private System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensionsFromMessage(Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        private System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData, Google.Protobuf.ExtensionRegistry registry) { }
        private System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData) { }
        private System.String ToString() { }
        private Google.Protobuf.Reflection.FileDescriptor get_DescriptorProtoFileDescriptor() { }
        private Google.Protobuf.Reflection.CustomOptions get_CustomOptions() { }
        private Google.Protobuf.Reflection.FileOptions GetOptions() { }
        private T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions,T> extension) { }
        private Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions,T> extension) { }
        private System.Void ForceReflectionInitialization() { }

    }

    // TypeToken: 0x2000103
    public class GeneratedClrTypeInfo
    {
        // Fields
        private static readonly System.String[] EmptyNames;        // 0x0
        private static readonly Google.Protobuf.Reflection.GeneratedClrTypeInfo[] EmptyCodeInfo;        // 0x8
        private static readonly Google.Protobuf.Extension[] EmptyExtensions;        // 0x10
        private static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes MessageAccessibility;        // 0x0
        private System.Type <ClrType>k__BackingField;        // 0x10
        private readonly Google.Protobuf.MessageParser <Parser>k__BackingField;        // 0x18
        private readonly System.String[] <PropertyNames>k__BackingField;        // 0x20
        private readonly Google.Protobuf.Extension[] <Extensions>k__BackingField;        // 0x28
        private readonly System.String[] <OneofNames>k__BackingField;        // 0x30
        private readonly Google.Protobuf.Reflection.GeneratedClrTypeInfo[] <NestedTypes>k__BackingField;        // 0x38
        private readonly System.Type[] <NestedEnums>k__BackingField;        // 0x40

        // Methods
        private System.Type get_ClrType() { }
        private System.Void set_ClrType(System.Type value) { }
        private Google.Protobuf.MessageParser get_Parser() { }
        private System.String[] get_PropertyNames() { }
        private Google.Protobuf.Extension[] get_Extensions() { }
        private System.String[] get_OneofNames() { }
        private Google.Protobuf.Reflection.GeneratedClrTypeInfo[] get_NestedTypes() { }
        private System.Type[] get_NestedEnums() { }
        private System.Void .ctor(System.Type clrType, Google.Protobuf.MessageParser parser, System.String[] propertyNames, System.String[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes) { }
        private System.Void .ctor(System.Type clrType, Google.Protobuf.MessageParser parser, System.String[] propertyNames, System.String[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes) { }
        private System.Void .ctor(System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes) { }
        private System.Void .ctor(System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000104
    public interface IDescriptor
    {
        // Methods
        private System.String get_Name() { }
        private System.String get_FullName() { }
        private Google.Protobuf.Reflection.FileDescriptor get_File() { }

    }

    // TypeToken: 0x2000105
    public interface IFieldAccessor
    {
        // Methods
        private Google.Protobuf.Reflection.FieldDescriptor get_Descriptor() { }
        private System.Void Clear(Google.Protobuf.IMessage message) { }
        private System.Object GetValue(Google.Protobuf.IMessage message) { }
        private System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        private System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x2000106
    public class MapFieldAccessor : FieldAccessorBase
    {
        // Methods
        private System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        private System.Void Clear(Google.Protobuf.IMessage message) { }
        private System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        private System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x2000107
    public class MessageDescriptor : DescriptorBase
    {
        // Fields
        private static readonly System.Collections.Generic.HashSet<System.String> WellKnownTypeNames;        // 0x0
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fieldsInDeclarationOrder;        // 0x28
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fieldsInNumberOrder;        // 0x30
        private readonly System.Collections.Generic.IDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor> jsonFieldMap;        // 0x38
        private System.Func<Google.Protobuf.IMessage,System.Boolean> extensionSetIsInitialized;        // 0x40
        private readonly Google.Protobuf.Reflection.DescriptorProto <Proto>k__BackingField;        // 0x48
        private readonly System.Type <ClrType>k__BackingField;        // 0x50
        private readonly Google.Protobuf.MessageParser <Parser>k__BackingField;        // 0x58
        private readonly Google.Protobuf.Reflection.MessageDescriptor <ContainingType>k__BackingField;        // 0x60
        private readonly Google.Protobuf.Reflection.MessageDescriptor.FieldCollection <Fields>k__BackingField;        // 0x68
        private readonly Google.Protobuf.Reflection.ExtensionCollection <Extensions>k__BackingField;        // 0x70
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> <NestedTypes>k__BackingField;        // 0x78
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> <EnumTypes>k__BackingField;        // 0x80
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.OneofDescriptor> <Oneofs>k__BackingField;        // 0x88
        private readonly System.Int32 <RealOneofCount>k__BackingField;        // 0x90

        // Methods
        private System.Void .ctor(Google.Protobuf.Reflection.DescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 typeIndex, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo) { }
        private System.Collections.ObjectModel.ReadOnlyDictionary<System.String,Google.Protobuf.Reflection.FieldDescriptor> CreateJsonFieldMap(System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fields) { }
        private System.String get_Name() { }
        private System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber) { }
        private Google.Protobuf.Reflection.DescriptorProto get_Proto() { }
        private Google.Protobuf.Reflection.DescriptorProto ToProto() { }
        private System.Boolean IsExtensionsInitialized(Google.Protobuf.IMessage message) { }
        private System.Type get_ClrType() { }
        private Google.Protobuf.MessageParser get_Parser() { }
        private System.Boolean get_IsWellKnownType() { }
        private System.Boolean get_IsWrapperType() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_ContainingType() { }
        private Google.Protobuf.Reflection.MessageDescriptor.FieldCollection get_Fields() { }
        private Google.Protobuf.Reflection.ExtensionCollection get_Extensions() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> get_NestedTypes() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> get_EnumTypes() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.OneofDescriptor> get_Oneofs() { }
        private System.Int32 get_RealOneofCount() { }
        private Google.Protobuf.Reflection.FieldDescriptor FindFieldByName(System.String name) { }
        private Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(System.Int32 number) { }
        private T FindDescriptor(System.String name) { }
        private Google.Protobuf.Reflection.CustomOptions get_CustomOptions() { }
        private Google.Protobuf.Reflection.MessageOptions GetOptions() { }
        private T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions,T> extension) { }
        private Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions,T> extension) { }
        private System.Void CrossLink() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200010B
    public class MethodDescriptor : DescriptorBase
    {
        // Fields
        private readonly Google.Protobuf.Reflection.MethodDescriptorProto proto;        // 0x28
        private readonly Google.Protobuf.Reflection.ServiceDescriptor service;        // 0x30
        private Google.Protobuf.Reflection.MessageDescriptor inputType;        // 0x38
        private Google.Protobuf.Reflection.MessageDescriptor outputType;        // 0x40

        // Methods
        private Google.Protobuf.Reflection.ServiceDescriptor get_Service() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_InputType() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_OutputType() { }
        private System.Boolean get_IsClientStreaming() { }
        private System.Boolean get_IsServerStreaming() { }
        private Google.Protobuf.Reflection.CustomOptions get_CustomOptions() { }
        private Google.Protobuf.Reflection.MethodOptions GetOptions() { }
        private T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions,T> extension) { }
        private Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions,T> extension) { }
        private System.Void .ctor(Google.Protobuf.Reflection.MethodDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.ServiceDescriptor parent, System.Int32 index) { }
        private Google.Protobuf.Reflection.MethodDescriptorProto get_Proto() { }
        private Google.Protobuf.Reflection.MethodDescriptorProto ToProto() { }
        private System.String get_Name() { }
        private System.Void CrossLink() { }

    }

    // TypeToken: 0x200010C
    public class OneofAccessor
    {
        // Fields
        private readonly System.Func<Google.Protobuf.IMessage,System.Int32> caseDelegate;        // 0x10
        private readonly System.Action<Google.Protobuf.IMessage> clearDelegate;        // 0x18
        private readonly Google.Protobuf.Reflection.OneofDescriptor <Descriptor>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Func<Google.Protobuf.IMessage,System.Int32> caseDelegate, System.Action<Google.Protobuf.IMessage> clearDelegate) { }
        private Google.Protobuf.Reflection.OneofAccessor ForRegularOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Reflection.PropertyInfo caseProperty, System.Reflection.MethodInfo clearMethod) { }
        private Google.Protobuf.Reflection.OneofAccessor ForSyntheticOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor) { }
        private Google.Protobuf.Reflection.OneofDescriptor get_Descriptor() { }
        private System.Void Clear(Google.Protobuf.IMessage message) { }
        private Google.Protobuf.Reflection.FieldDescriptor GetCaseFieldDescriptor(Google.Protobuf.IMessage message) { }

    }

    // TypeToken: 0x200010E
    public class OneofDescriptor : DescriptorBase
    {
        // Fields
        private Google.Protobuf.Reflection.MessageDescriptor containingType;        // 0x28
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fields;        // 0x30
        private readonly Google.Protobuf.Reflection.OneofAccessor accessor;        // 0x38
        private readonly Google.Protobuf.Reflection.OneofDescriptorProto <Proto>k__BackingField;        // 0x40
        private readonly System.Boolean <IsSynthetic>k__BackingField;        // 0x48

        // Methods
        private System.Void .ctor(Google.Protobuf.Reflection.OneofDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, System.Int32 index, System.String clrName) { }
        private System.String get_Name() { }
        private Google.Protobuf.Reflection.OneofDescriptorProto get_Proto() { }
        private Google.Protobuf.Reflection.OneofDescriptorProto ToProto() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_ContainingType() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> get_Fields() { }
        private System.Boolean get_IsSynthetic() { }
        private Google.Protobuf.Reflection.OneofAccessor get_Accessor() { }
        private Google.Protobuf.Reflection.CustomOptions get_CustomOptions() { }
        private Google.Protobuf.Reflection.OneofOptions GetOptions() { }
        private T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions,T> extension) { }
        private Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions,T> extension) { }
        private System.Void CrossLink() { }
        private Google.Protobuf.Reflection.OneofAccessor CreateAccessor(System.String clrName) { }

    }

    // TypeToken: 0x2000110
    public class OriginalNameAttribute : Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;        // 0x10
        private System.Boolean <PreferredAlias>k__BackingField;        // 0x18

        // Methods
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_PreferredAlias() { }
        private System.Void set_PreferredAlias(System.Boolean value) { }
        private System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x2000111
    public class PackageDescriptor, IDescriptor
    {
        // Fields
        private readonly System.String name;        // 0x10
        private readonly System.String fullName;        // 0x18
        private readonly Google.Protobuf.Reflection.FileDescriptor file;        // 0x20

        // Methods
        private System.Void .ctor(System.String name, System.String fullName, Google.Protobuf.Reflection.FileDescriptor file) { }
        private System.String get_Name() { }
        private System.String get_FullName() { }
        private Google.Protobuf.Reflection.FileDescriptor get_File() { }

    }

    // TypeToken: 0x2000112
    public class ReflectionUtil
    {
        // Fields
        private static readonly System.Type[] EmptyTypes;        // 0x0
        private static readonly System.Boolean <CanConvertEnumFuncToInt32Func>k__BackingField;        // 0x8

        // Methods
        private System.Void .cctor() { }
        private System.Void ForceInitialize() { }
        private System.Func<Google.Protobuf.IMessage,System.Object> CreateFuncIMessageObject(System.Reflection.MethodInfo method) { }
        private System.Func<Google.Protobuf.IMessage,System.Int32> CreateFuncIMessageInt32(System.Reflection.MethodInfo method) { }
        private System.Action<Google.Protobuf.IMessage,System.Object> CreateActionIMessageObject(System.Reflection.MethodInfo method) { }
        private System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method) { }
        private System.Func<Google.Protobuf.IMessage,System.Boolean> CreateFuncIMessageBool(System.Reflection.MethodInfo method) { }
        private System.Func<Google.Protobuf.IMessage,System.Boolean> CreateIsInitializedCaller(System.Type msg) { }
        private Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper CreateExtensionHelper(Google.Protobuf.Extension extension) { }
        private Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper GetReflectionHelper(System.Type t1, System.Type t2) { }
        private System.Boolean get_CanConvertEnumFuncToInt32Func() { }
        private System.Boolean CheckCanConvertEnumFuncToInt32Func() { }
        private Google.Protobuf.Reflection.ReflectionUtil.SampleEnum SampleEnumMethod() { }

    }

    // TypeToken: 0x2000121
    public class RepeatedFieldAccessor : FieldAccessorBase
    {
        // Methods
        private System.Void .ctor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        private System.Void Clear(Google.Protobuf.IMessage message) { }
        private System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        private System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x2000122
    public class ServiceDescriptor : DescriptorBase
    {
        // Fields
        private readonly Google.Protobuf.Reflection.ServiceDescriptorProto proto;        // 0x28
        private readonly System.Collections.Generic.IList<Google.Protobuf.Reflection.MethodDescriptor> methods;        // 0x30

        // Methods
        private System.Void .ctor(Google.Protobuf.Reflection.ServiceDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, System.Int32 index) { }
        private System.String get_Name() { }
        private System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(System.Int32 fieldNumber) { }
        private Google.Protobuf.Reflection.ServiceDescriptorProto get_Proto() { }
        private Google.Protobuf.Reflection.ServiceDescriptorProto ToProto() { }
        private System.Collections.Generic.IList<Google.Protobuf.Reflection.MethodDescriptor> get_Methods() { }
        private Google.Protobuf.Reflection.MethodDescriptor FindMethodByName(System.String name) { }
        private Google.Protobuf.Reflection.CustomOptions get_CustomOptions() { }
        private Google.Protobuf.Reflection.ServiceOptions GetOptions() { }
        private T GetOption(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions,T> extension) { }
        private Google.Protobuf.Collections.RepeatedField<T> GetOption(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions,T> extension) { }
        private System.Void CrossLink() { }

    }

    // TypeToken: 0x2000124
    public class SingleFieldAccessor : FieldAccessorBase
    {
        // Fields
        private readonly System.Action<Google.Protobuf.IMessage,System.Object> setValueDelegate;        // 0x20
        private readonly System.Action<Google.Protobuf.IMessage> clearDelegate;        // 0x28
        private readonly System.Func<Google.Protobuf.IMessage,System.Boolean> hasDelegate;        // 0x30

        // Methods
        private System.Void .ctor(System.Type messageType, System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        private System.Object GetDefaultValue(Google.Protobuf.Reflection.FieldDescriptor descriptor) { }
        private System.Void Clear(Google.Protobuf.IMessage message) { }
        private System.Boolean HasValue(Google.Protobuf.IMessage message) { }
        private System.Void SetValue(Google.Protobuf.IMessage message, System.Object value) { }

    }

    // TypeToken: 0x2000129
    public class TypeRegistry
    {
        // Fields
        private static readonly Google.Protobuf.Reflection.TypeRegistry <Empty>k__BackingField;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap;        // 0x10

        // Methods
        private Google.Protobuf.Reflection.TypeRegistry get_Empty() { }
        private System.Void .ctor(System.Collections.Generic.Dictionary<System.String,Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap) { }
        private Google.Protobuf.Reflection.MessageDescriptor Find(System.String fullName) { }
        private Google.Protobuf.Reflection.TypeRegistry FromFiles(Google.Protobuf.Reflection.FileDescriptor[] fileDescriptors) { }
        private Google.Protobuf.Reflection.TypeRegistry FromFiles(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> fileDescriptors) { }
        private Google.Protobuf.Reflection.TypeRegistry FromMessages(Google.Protobuf.Reflection.MessageDescriptor[] messageDescriptors) { }
        private Google.Protobuf.Reflection.TypeRegistry FromMessages(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.MessageDescriptor> messageDescriptors) { }
        private System.Void .cctor() { }

    }

}

namespace Google.Protobuf.WellKnownTypes
{

    // TypeToken: 0x2000060
    public class AnyReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000061
    public class Any, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Any> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 TypeUrlFieldNumber;        // 0x0
        private System.String typeUrl_;        // 0x18
        public static System.Int32 ValueFieldNumber;        // 0x0
        private Google.Protobuf.ByteString value_;        // 0x20
        private static System.String DefaultPrefix;        // 0x0

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Any> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Any other) { }
        private Google.Protobuf.WellKnownTypes.Any Clone() { }
        private System.String get_TypeUrl() { }
        private System.Void set_TypeUrl(System.String value) { }
        private Google.Protobuf.ByteString get_Value() { }
        private System.Void set_Value(Google.Protobuf.ByteString value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Any other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Any other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.String GetTypeUrl(Google.Protobuf.Reflection.MessageDescriptor descriptor, System.String prefix) { }
        private System.String GetTypeName(System.String typeUrl) { }
        private System.Boolean Is(Google.Protobuf.Reflection.MessageDescriptor descriptor) { }
        private T Unpack() { }
        private System.Boolean TryUnpack(T& result) { }
        private Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message) { }
        private Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message, System.String typeUrlPrefix) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000063
    public class ApiReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000064
    public class Api, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Api> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private System.String name_;        // 0x18
        public static System.Int32 MethodsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Method> _repeated_methods_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Method> methods_;        // 0x20
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;        // 0x28
        public static System.Int32 VersionFieldNumber;        // 0x0
        private System.String version_;        // 0x30
        public static System.Int32 SourceContextFieldNumber;        // 0x0
        private Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;        // 0x38
        public static System.Int32 MixinsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Mixin> _repeated_mixins_codec;        // 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Mixin> mixins_;        // 0x40
        public static System.Int32 SyntaxFieldNumber;        // 0x0
        private Google.Protobuf.WellKnownTypes.Syntax syntax_;        // 0x48

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Api> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Api other) { }
        private Google.Protobuf.WellKnownTypes.Api Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Method> get_Methods() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options() { }
        private System.String get_Version() { }
        private System.Void set_Version(System.String value) { }
        private Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext() { }
        private System.Void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value) { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Mixin> get_Mixins() { }
        private Google.Protobuf.WellKnownTypes.Syntax get_Syntax() { }
        private System.Void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Api other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Api other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000066
    public class Method, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Method> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private System.String name_;        // 0x18
        public static System.Int32 RequestTypeUrlFieldNumber;        // 0x0
        private System.String requestTypeUrl_;        // 0x20
        public static System.Int32 RequestStreamingFieldNumber;        // 0x0
        private System.Boolean requestStreaming_;        // 0x28
        public static System.Int32 ResponseTypeUrlFieldNumber;        // 0x0
        private System.String responseTypeUrl_;        // 0x30
        public static System.Int32 ResponseStreamingFieldNumber;        // 0x0
        private System.Boolean responseStreaming_;        // 0x38
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;        // 0x40
        public static System.Int32 SyntaxFieldNumber;        // 0x0
        private Google.Protobuf.WellKnownTypes.Syntax syntax_;        // 0x48

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Method> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Method other) { }
        private Google.Protobuf.WellKnownTypes.Method Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.String get_RequestTypeUrl() { }
        private System.Void set_RequestTypeUrl(System.String value) { }
        private System.Boolean get_RequestStreaming() { }
        private System.Void set_RequestStreaming(System.Boolean value) { }
        private System.String get_ResponseTypeUrl() { }
        private System.Void set_ResponseTypeUrl(System.String value) { }
        private System.Boolean get_ResponseStreaming() { }
        private System.Void set_ResponseStreaming(System.Boolean value) { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options() { }
        private Google.Protobuf.WellKnownTypes.Syntax get_Syntax() { }
        private System.Void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Method other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Method other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000068
    public class Mixin, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Mixin> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private System.String name_;        // 0x18
        public static System.Int32 RootFieldNumber;        // 0x0
        private System.String root_;        // 0x20

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Mixin> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Mixin other) { }
        private Google.Protobuf.WellKnownTypes.Mixin Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.String get_Root() { }
        private System.Void set_Root(System.String value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Mixin other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Mixin other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006A
    public class DurationReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006B
    public class Duration, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage, ICustomDiagnosticMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Duration> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 SecondsFieldNumber;        // 0x0
        private System.Int64 seconds_;        // 0x18
        public static System.Int32 NanosFieldNumber;        // 0x0
        private System.Int32 nanos_;        // 0x20
        public static System.Int32 NanosecondsPerSecond;        // 0x0
        public static System.Int32 NanosecondsPerTick;        // 0x0
        public static System.Int64 MaxSeconds;        // 0x0
        public static System.Int64 MinSeconds;        // 0x0
        private static System.Int32 MaxNanoseconds;        // 0x0
        private static System.Int32 MinNanoseconds;        // 0x0

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Duration> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Duration other) { }
        private Google.Protobuf.WellKnownTypes.Duration Clone() { }
        private System.Int64 get_Seconds() { }
        private System.Void set_Seconds(System.Int64 value) { }
        private System.Int32 get_Nanos() { }
        private System.Void set_Nanos(System.Int32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Duration other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Duration other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Boolean IsNormalized(System.Int64 seconds, System.Int32 nanoseconds) { }
        private System.TimeSpan ToTimeSpan() { }
        private Google.Protobuf.WellKnownTypes.Duration FromTimeSpan(System.TimeSpan timeSpan) { }
        private Google.Protobuf.WellKnownTypes.Duration op_UnaryNegation(Google.Protobuf.WellKnownTypes.Duration value) { }
        private Google.Protobuf.WellKnownTypes.Duration op_Addition(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs) { }
        private Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs) { }
        private Google.Protobuf.WellKnownTypes.Duration Normalize(System.Int64 seconds, System.Int32 nanoseconds) { }
        private System.String ToJson(System.Int64 seconds, System.Int32 nanoseconds, System.Boolean diagnosticOnly) { }
        private System.String ToDiagnosticString() { }
        private System.Void AppendNanoseconds(System.Text.StringBuilder builder, System.Int32 nanos) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006D
    public class EmptyReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006E
    public class Empty, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Empty> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Empty> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Empty other) { }
        private Google.Protobuf.WellKnownTypes.Empty Clone() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Empty other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Empty other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000070
    public class FieldMaskReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000071
    public class FieldMask, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage, ICustomDiagnosticMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FieldMask> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 PathsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_paths_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> paths_;        // 0x18
        private static System.Char FIELD_PATH_SEPARATOR;        // 0x0
        private static System.Char FIELD_SEPARATOR_REGEX;        // 0x0

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FieldMask> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.FieldMask other) { }
        private Google.Protobuf.WellKnownTypes.FieldMask Clone() { }
        private Google.Protobuf.Collections.RepeatedField<System.String> get_Paths() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.FieldMask other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.FieldMask other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.String ToJson(System.Collections.Generic.IList<System.String> paths, System.Boolean diagnosticOnly) { }
        private System.String ToDiagnosticString() { }
        private Google.Protobuf.WellKnownTypes.FieldMask FromString(System.String value) { }
        private Google.Protobuf.WellKnownTypes.FieldMask FromString(System.String value) { }
        private Google.Protobuf.WellKnownTypes.FieldMask FromStringEnumerable(System.Collections.Generic.IEnumerable<System.String> paths) { }
        private Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers(System.Int32[] fieldNumbers) { }
        private Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers(System.Collections.Generic.IEnumerable<System.Int32> fieldNumbers) { }
        private System.Boolean IsPathValid(System.String input) { }
        private System.Boolean IsValid(Google.Protobuf.WellKnownTypes.FieldMask fieldMask) { }
        private System.Boolean IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, Google.Protobuf.WellKnownTypes.FieldMask fieldMask) { }
        private System.Boolean IsValid(System.String path) { }
        private System.Boolean IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, System.String path) { }
        private Google.Protobuf.WellKnownTypes.FieldMask Normalize() { }
        private Google.Protobuf.WellKnownTypes.FieldMask Union(Google.Protobuf.WellKnownTypes.FieldMask[] otherMasks) { }
        private Google.Protobuf.WellKnownTypes.FieldMask Intersection(Google.Protobuf.WellKnownTypes.FieldMask additionalMask) { }
        private System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options) { }
        private System.Void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000074
    public class SourceContextReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000075
    public class SourceContext, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.SourceContext> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 FileNameFieldNumber;        // 0x0
        private System.String fileName_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.SourceContext> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.SourceContext other) { }
        private Google.Protobuf.WellKnownTypes.SourceContext Clone() { }
        private System.String get_FileName() { }
        private System.Void set_FileName(System.String value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.SourceContext other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.SourceContext other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000077
    public class StructReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000078
    public struct NullValue
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.WellKnownTypes.NullValue NullValue;        // 0x0

    }

    // TypeToken: 0x2000079
    public class Struct, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Struct> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 FieldsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.Collections.MapField.Codec<System.String,Google.Protobuf.WellKnownTypes.Value> _map_fields_codec;        // 0x8
        private readonly Google.Protobuf.Collections.MapField<System.String,Google.Protobuf.WellKnownTypes.Value> fields_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Struct> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Struct other) { }
        private Google.Protobuf.WellKnownTypes.Struct Clone() { }
        private Google.Protobuf.Collections.MapField<System.String,Google.Protobuf.WellKnownTypes.Value> get_Fields() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Struct other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Struct other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200007B
    public class Value, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Value> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NullValueFieldNumber;        // 0x0
        public static System.Int32 NumberValueFieldNumber;        // 0x0
        public static System.Int32 StringValueFieldNumber;        // 0x0
        public static System.Int32 BoolValueFieldNumber;        // 0x0
        public static System.Int32 StructValueFieldNumber;        // 0x0
        public static System.Int32 ListValueFieldNumber;        // 0x0
        private System.Object kind_;        // 0x18
        private Google.Protobuf.WellKnownTypes.Value.KindOneofCase kindCase_;        // 0x20

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Value> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Value other) { }
        private Google.Protobuf.WellKnownTypes.Value Clone() { }
        private Google.Protobuf.WellKnownTypes.NullValue get_NullValue() { }
        private System.Void set_NullValue(Google.Protobuf.WellKnownTypes.NullValue value) { }
        private System.Double get_NumberValue() { }
        private System.Void set_NumberValue(System.Double value) { }
        private System.String get_StringValue() { }
        private System.Void set_StringValue(System.String value) { }
        private System.Boolean get_BoolValue() { }
        private System.Void set_BoolValue(System.Boolean value) { }
        private Google.Protobuf.WellKnownTypes.Struct get_StructValue() { }
        private System.Void set_StructValue(Google.Protobuf.WellKnownTypes.Struct value) { }
        private Google.Protobuf.WellKnownTypes.ListValue get_ListValue() { }
        private System.Void set_ListValue(Google.Protobuf.WellKnownTypes.ListValue value) { }
        private Google.Protobuf.WellKnownTypes.Value.KindOneofCase get_KindCase() { }
        private System.Void ClearKind() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Value other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Value other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private Google.Protobuf.WellKnownTypes.Value ForString(System.String value) { }
        private Google.Protobuf.WellKnownTypes.Value ForNumber(System.Double value) { }
        private Google.Protobuf.WellKnownTypes.Value ForBool(System.Boolean value) { }
        private Google.Protobuf.WellKnownTypes.Value ForNull() { }
        private Google.Protobuf.WellKnownTypes.Value ForList(Google.Protobuf.WellKnownTypes.Value[] values) { }
        private Google.Protobuf.WellKnownTypes.Value ForStruct(Google.Protobuf.WellKnownTypes.Struct value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200007E
    public class ListValue, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.ListValue> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValuesFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Value> _repeated_values_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Value> values_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.ListValue> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.ListValue other) { }
        private Google.Protobuf.WellKnownTypes.ListValue Clone() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Value> get_Values() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.ListValue other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.ListValue other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000080
    public class TimeExtensions
    {
        // Methods
        private Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTime dateTime) { }
        private Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTimeOffset dateTimeOffset) { }
        private Google.Protobuf.WellKnownTypes.Duration ToDuration(System.TimeSpan timeSpan) { }

    }

    // TypeToken: 0x2000081
    public class TimestampReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000082
    public class Timestamp, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage, ICustomDiagnosticMessage, IComparable`1
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Timestamp> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 SecondsFieldNumber;        // 0x0
        private System.Int64 seconds_;        // 0x18
        public static System.Int32 NanosFieldNumber;        // 0x0
        private System.Int32 nanos_;        // 0x20
        private static readonly System.DateTime UnixEpoch;        // 0x8
        private static System.Int64 BclSecondsAtUnixEpoch;        // 0x0
        private static System.Int64 UnixSecondsAtBclMaxValue;        // 0x0
        private static System.Int64 UnixSecondsAtBclMinValue;        // 0x0
        private static System.Int32 MaxNanos;        // 0x0

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Timestamp> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Timestamp other) { }
        private Google.Protobuf.WellKnownTypes.Timestamp Clone() { }
        private System.Int64 get_Seconds() { }
        private System.Void set_Seconds(System.Int64 value) { }
        private System.Int32 get_Nanos() { }
        private System.Void set_Nanos(System.Int32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Timestamp other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Timestamp other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Boolean IsNormalized(System.Int64 seconds, System.Int32 nanoseconds) { }
        private Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Timestamp rhs) { }
        private Google.Protobuf.WellKnownTypes.Timestamp op_Addition(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs) { }
        private Google.Protobuf.WellKnownTypes.Timestamp op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs) { }
        private System.DateTime ToDateTime() { }
        private System.DateTimeOffset ToDateTimeOffset() { }
        private Google.Protobuf.WellKnownTypes.Timestamp FromDateTime(System.DateTime dateTime) { }
        private Google.Protobuf.WellKnownTypes.Timestamp FromDateTimeOffset(System.DateTimeOffset dateTimeOffset) { }
        private Google.Protobuf.WellKnownTypes.Timestamp Normalize(System.Int64 seconds, System.Int32 nanoseconds) { }
        private System.String ToJson(System.Int64 seconds, System.Int32 nanoseconds, System.Boolean diagnosticOnly) { }
        private System.Int32 CompareTo(Google.Protobuf.WellKnownTypes.Timestamp other) { }
        private System.Boolean op_LessThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        private System.Boolean op_GreaterThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        private System.Boolean op_LessThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        private System.Boolean op_GreaterThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        private System.Boolean op_Equality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        private System.Boolean op_Inequality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b) { }
        private System.String ToDiagnosticString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000084
    public class TypeReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000085
    public struct Syntax
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Google.Protobuf.WellKnownTypes.Syntax Proto2;        // 0x0
        public static Google.Protobuf.WellKnownTypes.Syntax Proto3;        // 0x0

    }

    // TypeToken: 0x2000086
    public class Type, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Type> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private System.String name_;        // 0x18
        public static System.Int32 FieldsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Field> _repeated_fields_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Field> fields_;        // 0x20
        public static System.Int32 OneofsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<System.String> _repeated_oneofs_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<System.String> oneofs_;        // 0x28
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;        // 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;        // 0x30
        public static System.Int32 SourceContextFieldNumber;        // 0x0
        private Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;        // 0x38
        public static System.Int32 SyntaxFieldNumber;        // 0x0
        private Google.Protobuf.WellKnownTypes.Syntax syntax_;        // 0x40

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Type> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Type other) { }
        private Google.Protobuf.WellKnownTypes.Type Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Field> get_Fields() { }
        private Google.Protobuf.Collections.RepeatedField<System.String> get_Oneofs() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options() { }
        private Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext() { }
        private System.Void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value) { }
        private Google.Protobuf.WellKnownTypes.Syntax get_Syntax() { }
        private System.Void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Type other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Type other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000088
    public class Field, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Field> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 KindFieldNumber;        // 0x0
        private Google.Protobuf.WellKnownTypes.Field.Types.Kind kind_;        // 0x18
        public static System.Int32 CardinalityFieldNumber;        // 0x0
        private Google.Protobuf.WellKnownTypes.Field.Types.Cardinality cardinality_;        // 0x1C
        public static System.Int32 NumberFieldNumber;        // 0x0
        private System.Int32 number_;        // 0x20
        public static System.Int32 NameFieldNumber;        // 0x0
        private System.String name_;        // 0x28
        public static System.Int32 TypeUrlFieldNumber;        // 0x0
        private System.String typeUrl_;        // 0x30
        public static System.Int32 OneofIndexFieldNumber;        // 0x0
        private System.Int32 oneofIndex_;        // 0x38
        public static System.Int32 PackedFieldNumber;        // 0x0
        private System.Boolean packed_;        // 0x3C
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;        // 0x40
        public static System.Int32 JsonNameFieldNumber;        // 0x0
        private System.String jsonName_;        // 0x48
        public static System.Int32 DefaultValueFieldNumber;        // 0x0
        private System.String defaultValue_;        // 0x50

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Field> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Field other) { }
        private Google.Protobuf.WellKnownTypes.Field Clone() { }
        private Google.Protobuf.WellKnownTypes.Field.Types.Kind get_Kind() { }
        private System.Void set_Kind(Google.Protobuf.WellKnownTypes.Field.Types.Kind value) { }
        private Google.Protobuf.WellKnownTypes.Field.Types.Cardinality get_Cardinality() { }
        private System.Void set_Cardinality(Google.Protobuf.WellKnownTypes.Field.Types.Cardinality value) { }
        private System.Int32 get_Number() { }
        private System.Void set_Number(System.Int32 value) { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.String get_TypeUrl() { }
        private System.Void set_TypeUrl(System.String value) { }
        private System.Int32 get_OneofIndex() { }
        private System.Void set_OneofIndex(System.Int32 value) { }
        private System.Boolean get_Packed() { }
        private System.Void set_Packed(System.Boolean value) { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options() { }
        private System.String get_JsonName() { }
        private System.Void set_JsonName(System.String value) { }
        private System.String get_DefaultValue() { }
        private System.Void set_DefaultValue(System.String value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Field other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Field other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200008D
    public class Enum, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Enum> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private System.String name_;        // 0x18
        public static System.Int32 EnumvalueFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.EnumValue> _repeated_enumvalue_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.EnumValue> enumvalue_;        // 0x20
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;        // 0x28
        public static System.Int32 SourceContextFieldNumber;        // 0x0
        private Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;        // 0x30
        public static System.Int32 SyntaxFieldNumber;        // 0x0
        private Google.Protobuf.WellKnownTypes.Syntax syntax_;        // 0x38

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Enum> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Enum other) { }
        private Google.Protobuf.WellKnownTypes.Enum Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.EnumValue> get_Enumvalue() { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options() { }
        private Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext() { }
        private System.Void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value) { }
        private Google.Protobuf.WellKnownTypes.Syntax get_Syntax() { }
        private System.Void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Enum other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Enum other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200008F
    public class EnumValue, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.EnumValue> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private System.String name_;        // 0x18
        public static System.Int32 NumberFieldNumber;        // 0x0
        private System.Int32 number_;        // 0x20
        public static System.Int32 OptionsFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;        // 0x28

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.EnumValue> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.EnumValue other) { }
        private Google.Protobuf.WellKnownTypes.EnumValue Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Int32 get_Number() { }
        private System.Void set_Number(System.Int32 value) { }
        private Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.EnumValue other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.EnumValue other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000091
    public class Option, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Option> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 NameFieldNumber;        // 0x0
        private System.String name_;        // 0x18
        public static System.Int32 ValueFieldNumber;        // 0x0
        private Google.Protobuf.WellKnownTypes.Any value_;        // 0x20

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Option> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Option other) { }
        private Google.Protobuf.WellKnownTypes.Option Clone() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private Google.Protobuf.WellKnownTypes.Any get_Value() { }
        private System.Void set_Value(Google.Protobuf.WellKnownTypes.Any value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Option other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Option other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000093
    public class WrappersReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0
        private static System.Int32 WrapperValueFieldNumber;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000094
    public class DoubleValue, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.DoubleValue> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValueFieldNumber;        // 0x0
        private System.Double value_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.DoubleValue> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.DoubleValue other) { }
        private Google.Protobuf.WellKnownTypes.DoubleValue Clone() { }
        private System.Double get_Value() { }
        private System.Void set_Value(System.Double value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.DoubleValue other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.DoubleValue other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000096
    public class FloatValue, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FloatValue> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValueFieldNumber;        // 0x0
        private System.Single value_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FloatValue> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.FloatValue other) { }
        private Google.Protobuf.WellKnownTypes.FloatValue Clone() { }
        private System.Single get_Value() { }
        private System.Void set_Value(System.Single value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.FloatValue other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.FloatValue other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000098
    public class Int64Value, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int64Value> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValueFieldNumber;        // 0x0
        private System.Int64 value_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int64Value> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Int64Value other) { }
        private Google.Protobuf.WellKnownTypes.Int64Value Clone() { }
        private System.Int64 get_Value() { }
        private System.Void set_Value(System.Int64 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Int64Value other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Int64Value other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009A
    public class UInt64Value, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt64Value> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValueFieldNumber;        // 0x0
        private System.UInt64 value_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt64Value> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.UInt64Value other) { }
        private Google.Protobuf.WellKnownTypes.UInt64Value Clone() { }
        private System.UInt64 get_Value() { }
        private System.Void set_Value(System.UInt64 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.UInt64Value other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.UInt64Value other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009C
    public class Int32Value, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int32Value> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValueFieldNumber;        // 0x0
        private System.Int32 value_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int32Value> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.Int32Value other) { }
        private Google.Protobuf.WellKnownTypes.Int32Value Clone() { }
        private System.Int32 get_Value() { }
        private System.Void set_Value(System.Int32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.Int32Value other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.Int32Value other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009E
    public class UInt32Value, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt32Value> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValueFieldNumber;        // 0x0
        private System.UInt32 value_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt32Value> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.UInt32Value other) { }
        private Google.Protobuf.WellKnownTypes.UInt32Value Clone() { }
        private System.UInt32 get_Value() { }
        private System.Void set_Value(System.UInt32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.UInt32Value other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.UInt32Value other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A0
    public class BoolValue, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BoolValue> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValueFieldNumber;        // 0x0
        private System.Boolean value_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BoolValue> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.BoolValue other) { }
        private Google.Protobuf.WellKnownTypes.BoolValue Clone() { }
        private System.Boolean get_Value() { }
        private System.Void set_Value(System.Boolean value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.BoolValue other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.BoolValue other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A2
    public class StringValue, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.StringValue> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValueFieldNumber;        // 0x0
        private System.String value_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.StringValue> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.StringValue other) { }
        private Google.Protobuf.WellKnownTypes.StringValue Clone() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.StringValue other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.StringValue other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A4
    public class BytesValue, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BytesValue> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValueFieldNumber;        // 0x0
        private Google.Protobuf.ByteString value_;        // 0x18

        // Methods
        private Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BytesValue> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Google.Protobuf.WellKnownTypes.BytesValue other) { }
        private Google.Protobuf.WellKnownTypes.BytesValue Clone() { }
        private Google.Protobuf.ByteString get_Value() { }
        private System.Void set_Value(Google.Protobuf.ByteString value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Google.Protobuf.WellKnownTypes.BytesValue other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Google.Protobuf.WellKnownTypes.BytesValue other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

}

namespace System.Diagnostics.CodeAnalysis
{

    // TypeToken: 0x2000002
    public class DynamicallyAccessedMembersAttribute : Attribute
    {
        // Fields
        private readonly System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes <MemberTypes>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes memberTypes) { }
        private System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes get_MemberTypes() { }

    }

    // TypeToken: 0x2000003
    public struct DynamicallyAccessedMemberTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes None;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicParameterlessConstructor;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicConstructors;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicConstructors;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicMethods;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicMethods;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicFields;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicFields;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicNestedTypes;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicNestedTypes;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicProperties;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicProperties;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes PublicEvents;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes NonPublicEvents;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes Interfaces;        // 0x0
        public static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes All;        // 0x0

    }

    // TypeToken: 0x2000004
    public class RequiresUnreferencedCodeAttribute : Attribute
    {
        // Fields
        private readonly System.String <Message>k__BackingField;        // 0x10
        private System.String <Url>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.String message) { }
        private System.String get_Message() { }
        private System.String get_Url() { }
        private System.Void set_Url(System.String value) { }

    }

    // TypeToken: 0x2000005
    public class UnconditionalSuppressMessageAttribute : Attribute
    {
        // Fields
        private readonly System.String <Category>k__BackingField;        // 0x10
        private readonly System.String <CheckId>k__BackingField;        // 0x18
        private System.String <Scope>k__BackingField;        // 0x20
        private System.String <Target>k__BackingField;        // 0x28
        private System.String <MessageId>k__BackingField;        // 0x30
        private System.String <Justification>k__BackingField;        // 0x38

        // Methods
        private System.Void .ctor(System.String category, System.String checkId) { }
        private System.String get_Category() { }
        private System.String get_CheckId() { }
        private System.String get_Scope() { }
        private System.Void set_Scope(System.String value) { }
        private System.String get_Target() { }
        private System.Void set_Target(System.String value) { }
        private System.String get_MessageId() { }
        private System.Void set_MessageId(System.String value) { }
        private System.String get_Justification() { }
        private System.Void set_Justification(System.String value) { }

    }

}

