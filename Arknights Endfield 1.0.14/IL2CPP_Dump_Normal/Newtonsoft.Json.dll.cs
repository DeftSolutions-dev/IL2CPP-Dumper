// ========================================================
// Dumped by @desirepro
// Assembly: Newtonsoft.Json.dll
// Classes:  309
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000D
    public class Entry
    {
        // Fields
        private readonly System.String Value;        // 0x10
        private readonly System.Int32 HashCode;        // 0x18
        private Newtonsoft.Json.DefaultJsonNameTable.Entry Next;        // 0x20

        // Methods
        private System.Void .ctor(System.String value, System.Int32 hashCode, Newtonsoft.Json.DefaultJsonNameTable.Entry next) { }

    }

    // TypeToken: 0x2000026
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.JsonReader.State Start;        // 0x0
        public static Newtonsoft.Json.JsonReader.State Complete;        // 0x0
        public static Newtonsoft.Json.JsonReader.State Property;        // 0x0
        public static Newtonsoft.Json.JsonReader.State ObjectStart;        // 0x0
        public static Newtonsoft.Json.JsonReader.State Object;        // 0x0
        public static Newtonsoft.Json.JsonReader.State ArrayStart;        // 0x0
        public static Newtonsoft.Json.JsonReader.State Array;        // 0x0
        public static Newtonsoft.Json.JsonReader.State Closed;        // 0x0
        public static Newtonsoft.Json.JsonReader.State PostValue;        // 0x0
        public static Newtonsoft.Json.JsonReader.State ConstructorStart;        // 0x0
        public static Newtonsoft.Json.JsonReader.State Constructor;        // 0x0
        public static Newtonsoft.Json.JsonReader.State Error;        // 0x0
        public static Newtonsoft.Json.JsonReader.State Finished;        // 0x0

    }

    // TypeToken: 0x2000031
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.JsonWriter.State Start;        // 0x0
        public static Newtonsoft.Json.JsonWriter.State Property;        // 0x0
        public static Newtonsoft.Json.JsonWriter.State ObjectStart;        // 0x0
        public static Newtonsoft.Json.JsonWriter.State Object;        // 0x0
        public static Newtonsoft.Json.JsonWriter.State ArrayStart;        // 0x0
        public static Newtonsoft.Json.JsonWriter.State Array;        // 0x0
        public static Newtonsoft.Json.JsonWriter.State ConstructorStart;        // 0x0
        public static Newtonsoft.Json.JsonWriter.State Constructor;        // 0x0
        public static Newtonsoft.Json.JsonWriter.State Closed;        // 0x0
        public static Newtonsoft.Json.JsonWriter.State Error;        // 0x0

    }

    // TypeToken: 0x2000045
    public class EmptyArrayContainer`1
    {
        // Fields
        public static readonly T[] Empty;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004C
    public struct ConvertResult
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult Success;        // 0x0
        public static Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult CannotConvertNull;        // 0x0
        public static Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult NotInstantiableType;        // 0x0
        public static Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult NoValidConversion;        // 0x0

    }

    // TypeToken: 0x2000053
    public struct DictionaryEnumerator`2, IDictionaryEnumerator, IEnumerator
    {
        // Fields
        private readonly System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> _e;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }
        private System.Collections.DictionaryEntry get_Entry() { }
        private System.Object get_Key() { }
        private System.Object get_Value() { }
        private System.Object get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000057
    public class Fallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Dynamic.DynamicMetaObject Invoke(System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x2000058
    public class GetBinderAdapter : GetMemberBinder
    {
        // Methods
        private System.Void .ctor(System.Dynamic.InvokeMemberBinder binder) { }
        private System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x2000067
    public class BinderWrapper
    {
        // Fields
        private static System.Object _getCSharpArgumentInfoArray;        // 0x0
        private static System.Object _setCSharpArgumentInfoArray;        // 0x8
        private static Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _getMemberCall;        // 0x10
        private static Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _setMemberCall;        // 0x18
        private static System.Boolean _init;        // 0x20

        // Methods
        private System.Void Init() { }
        private System.Object CreateSharpArgumentInfoArray(System.Int32[] values) { }
        private System.Void CreateMemberCalls() { }
        private System.Runtime.CompilerServices.CallSiteBinder GetMember(System.String name, System.Type context) { }
        private System.Runtime.CompilerServices.CallSiteBinder SetMember(System.String name, System.Type context) { }

    }

    // TypeToken: 0x2000074
    public class ImmutableCollectionTypeInfo
    {
        // Fields
        private System.String <ContractTypeName>k__BackingField;        // 0x10
        private System.String <CreatedTypeName>k__BackingField;        // 0x18
        private System.String <BuilderTypeName>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.String contractTypeName, System.String createdTypeName, System.String builderTypeName) { }
        private System.String get_ContractTypeName() { }
        private System.Void set_ContractTypeName(System.String value) { }
        private System.String get_CreatedTypeName() { }
        private System.Void set_CreatedTypeName(System.String value) { }
        private System.String get_BuilderTypeName() { }
        private System.Void set_BuilderTypeName(System.String value) { }

    }

    // TypeToken: 0x2000096
    public struct SeparatedCaseState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState Start;        // 0x0
        public static Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState Lower;        // 0x0
        public static Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState Upper;        // 0x0
        public static Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseState NewWord;        // 0x0

    }

    // TypeToken: 0x200009F
    public class EnumerableDictionaryWrapper`2, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> _e;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x20000C9
    public class ReferenceEqualsEqualityComparer, IEqualityComparer`1
    {
        // Methods
        private System.Boolean System.Collections.Generic.IEqualityComparer<System.Object>.Equals(System.Object x, System.Object y) { }
        private System.Int32 System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(System.Object obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CB
    public struct PropertyPresence
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence None;        // 0x0
        public static Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence Null;        // 0x0
        public static Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence Value;        // 0x0

    }

    // TypeToken: 0x20000CC
    public class CreatorPropertyContext
    {
        // Fields
        public readonly System.String Name;        // 0x10
        public Newtonsoft.Json.Serialization.JsonProperty Property;        // 0x18
        public Newtonsoft.Json.Serialization.JsonProperty ConstructorProperty;        // 0x20
        public System.Nullable<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> Presence;        // 0x28
        public System.Object Value;        // 0x30
        public System.Boolean Used;        // 0x38

        // Methods
        private System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x20000E6
    public class JObjectDynamicProxy : DynamicProxy`1
    {
        // Methods
        private System.Boolean TryGetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.GetMemberBinder binder, System.Object& result) { }
        private System.Boolean TrySetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.SetMemberBinder binder, System.Object value) { }
        private System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(Newtonsoft.Json.Linq.JObject instance) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EA
    public class JPropertyList, IList`1, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private Newtonsoft.Json.Linq.JToken _token;        // 0x10

        // Methods
        private System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Add(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex) { }
        private System.Boolean Remove(Newtonsoft.Json.Linq.JToken item) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Int32 IndexOf(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private Newtonsoft.Json.Linq.JToken get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, Newtonsoft.Json.Linq.JToken value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F2
    public class LineInfoAnnotation
    {
        // Fields
        private readonly System.Int32 LineNumber;        // 0x10
        private readonly System.Int32 LinePosition;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition) { }

    }

    // TypeToken: 0x20000F7
    public class JValueDynamicProxy : DynamicProxy`1
    {
        // Methods
        private System.Boolean TryConvert(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.ConvertBinder binder, System.Object& result) { }
        private System.Boolean TryBinaryOperation(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.BinaryOperationBinder binder, System.Object arg, System.Object& result) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000100
    public class Union
    {
        // Fields
        public readonly Newtonsoft.Json.Utilities.FSharpFunction TagReader;        // 0x10
        public readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases;        // 0x18

        // Methods
        private System.Void .ctor(Newtonsoft.Json.Utilities.FSharpFunction tagReader, System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases) { }

    }

    // TypeToken: 0x2000101
    public class UnionCase
    {
        // Fields
        public readonly System.Int32 Tag;        // 0x10
        public readonly System.String Name;        // 0x18
        public readonly System.Reflection.PropertyInfo[] Fields;        // 0x20
        public readonly Newtonsoft.Json.Utilities.FSharpFunction FieldReader;        // 0x28
        public readonly Newtonsoft.Json.Utilities.FSharpFunction Constructor;        // 0x30

        // Methods
        private System.Void .ctor(System.Int32 tag, System.String name, System.Reflection.PropertyInfo[] fields, Newtonsoft.Json.Utilities.FSharpFunction fieldReader, Newtonsoft.Json.Utilities.FSharpFunction constructor) { }

    }

    // TypeToken: 0x200012D
    public struct __StaticArrayInitTypeSize=10
    {
    }

    // TypeToken: 0x200012E
    public struct __StaticArrayInitTypeSize=16
    {
    }

    // TypeToken: 0x200012F
    public struct __StaticArrayInitTypeSize=20
    {
    }

    // TypeToken: 0x2000130
    public struct __StaticArrayInitTypeSize=24
    {
    }

    // TypeToken: 0x2000131
    public struct __StaticArrayInitTypeSize=28
    {
    }

    // TypeToken: 0x2000132
    public struct __StaticArrayInitTypeSize=36
    {
    }

    // TypeToken: 0x2000133
    public struct __StaticArrayInitTypeSize=40
    {
    }

    // TypeToken: 0x2000134
    public struct __StaticArrayInitTypeSize=44
    {
    }

    // TypeToken: 0x2000135
    public struct __StaticArrayInitTypeSize=52
    {
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

namespace Newtonsoft.Json
{

    // TypeToken: 0x2000008
    public struct ConstructorHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.ConstructorHandling Default;        // 0x0
        public static Newtonsoft.Json.ConstructorHandling AllowNonPublicDefaultConstructor;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct DateFormatHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.DateFormatHandling IsoDateFormat;        // 0x0
        public static Newtonsoft.Json.DateFormatHandling MicrosoftDateFormat;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct DateParseHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.DateParseHandling None;        // 0x0
        public static Newtonsoft.Json.DateParseHandling DateTime;        // 0x0
        public static Newtonsoft.Json.DateParseHandling DateTimeOffset;        // 0x0

    }

    // TypeToken: 0x200000B
    public struct DateTimeZoneHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.DateTimeZoneHandling Local;        // 0x0
        public static Newtonsoft.Json.DateTimeZoneHandling Utc;        // 0x0
        public static Newtonsoft.Json.DateTimeZoneHandling Unspecified;        // 0x0
        public static Newtonsoft.Json.DateTimeZoneHandling RoundtripKind;        // 0x0

    }

    // TypeToken: 0x200000C
    public class DefaultJsonNameTable : JsonNameTable
    {
        // Fields
        private static readonly System.Int32 HashCodeRandomizer;        // 0x0
        private System.Int32 _count;        // 0x10
        private Newtonsoft.Json.DefaultJsonNameTable.Entry[] _entries;        // 0x18
        private System.Int32 _mask;        // 0x20

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor() { }
        private System.String Get(System.Char[] key, System.Int32 start, System.Int32 length) { }
        private System.String Add(System.String key) { }
        private System.String AddEntry(System.String str, System.Int32 hashCode) { }
        private System.Void Grow() { }
        private System.Boolean TextEquals(System.String str1, System.Char[] str2, System.Int32 str2Start, System.Int32 str2Length) { }

    }

    // TypeToken: 0x200000E
    public struct DefaultValueHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.DefaultValueHandling Include;        // 0x0
        public static Newtonsoft.Json.DefaultValueHandling Ignore;        // 0x0
        public static Newtonsoft.Json.DefaultValueHandling Populate;        // 0x0
        public static Newtonsoft.Json.DefaultValueHandling IgnoreAndPopulate;        // 0x0

    }

    // TypeToken: 0x200000F
    public struct FloatFormatHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.FloatFormatHandling String;        // 0x0
        public static Newtonsoft.Json.FloatFormatHandling Symbol;        // 0x0
        public static Newtonsoft.Json.FloatFormatHandling DefaultValue;        // 0x0

    }

    // TypeToken: 0x2000010
    public struct FloatParseHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.FloatParseHandling Double;        // 0x0
        public static Newtonsoft.Json.FloatParseHandling Decimal;        // 0x0

    }

    // TypeToken: 0x2000011
    public struct Formatting
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Formatting None;        // 0x0
        public static Newtonsoft.Json.Formatting Indented;        // 0x0

    }

    // TypeToken: 0x2000012
    public interface IArrayPool`1
    {
        // Methods
        private T[] Rent(System.Int32 minimumLength) { }
        private System.Void Return(T[] array) { }

    }

    // TypeToken: 0x2000013
    public interface IJsonLineInfo
    {
        // Methods
        private System.Boolean HasLineInfo() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }

    }

    // TypeToken: 0x2000014
    public class JsonArrayAttribute : JsonContainerAttribute
    {
    }

    // TypeToken: 0x2000015
    public class JsonConstructorAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class JsonContainerAttribute : Attribute
    {
        // Fields
        private System.Type <ItemConverterType>k__BackingField;        // 0x10
        private System.Object[] <ItemConverterParameters>k__BackingField;        // 0x18
        private Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategyInstance>k__BackingField;        // 0x20
        private System.Nullable<System.Boolean> _isReference;        // 0x28
        private System.Nullable<System.Boolean> _itemIsReference;        // 0x2A
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _itemReferenceLoopHandling;        // 0x2C
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> _itemTypeNameHandling;        // 0x34
        private System.Type _namingStrategyType;        // 0x40
        private System.Object[] _namingStrategyParameters;        // 0x48

        // Methods
        private System.Type get_ItemConverterType() { }
        private System.Object[] get_ItemConverterParameters() { }
        private System.Type get_NamingStrategyType() { }
        private System.Object[] get_NamingStrategyParameters() { }
        private Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategyInstance() { }
        private System.Void set_NamingStrategyInstance(Newtonsoft.Json.Serialization.NamingStrategy value) { }

    }

    // TypeToken: 0x2000017
    public class JsonConvert
    {
        // Fields
        private static System.Func<Newtonsoft.Json.JsonSerializerSettings> <DefaultSettings>k__BackingField;        // 0x0
        public static readonly System.String True;        // 0x8
        public static readonly System.String False;        // 0x10
        public static readonly System.String Null;        // 0x18
        public static readonly System.String Undefined;        // 0x20
        public static readonly System.String PositiveInfinity;        // 0x28
        public static readonly System.String NegativeInfinity;        // 0x30
        public static readonly System.String NaN;        // 0x38

        // Methods
        private System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings() { }
        private System.String ToString(System.Boolean value) { }
        private System.String ToString(System.Char value) { }
        private System.String ToString(System.Single value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable) { }
        private System.String EnsureFloatFormat(System.Double value, System.String text, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable) { }
        private System.String ToString(System.Double value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable) { }
        private System.String EnsureDecimalPlace(System.Double value, System.String text) { }
        private System.String EnsureDecimalPlace(System.String text) { }
        private System.String ToString(System.Decimal value) { }
        private System.String ToString(System.String value) { }
        private System.String ToString(System.String value, System.Char delimiter) { }
        private System.String ToString(System.String value, System.Char delimiter, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling) { }
        private System.String SerializeObject(System.Object value) { }
        private System.String SerializeObject(System.Object value, Newtonsoft.Json.Formatting formatting) { }
        private System.String SerializeObject(System.Object value, Newtonsoft.Json.JsonSerializerSettings settings) { }
        private System.String SerializeObject(System.Object value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings) { }
        private System.String SerializeObject(System.Object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings) { }
        private System.String SerializeObject(System.Object value, System.Type type, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings) { }
        private System.String SerializeObjectInternal(System.Object value, System.Type type, Newtonsoft.Json.JsonSerializer jsonSerializer) { }
        private System.Object DeserializeObject(System.String value) { }
        private System.Object DeserializeObject(System.String value, System.Type type) { }
        private T DeserializeObject(System.String value) { }
        private T DeserializeObject(System.String value, Newtonsoft.Json.JsonSerializerSettings settings) { }
        private System.Object DeserializeObject(System.String value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings) { }
        private System.Void PopulateObject(System.String value, System.Object target, Newtonsoft.Json.JsonSerializerSettings settings) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000018
    public class JsonConverter
    {
        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanWrite() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class JsonConverter`1 : JsonConverter
    {
        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, T value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private T ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, T existingValue, System.Boolean hasExistingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public class JsonConverterAttribute : Attribute
    {
        // Fields
        private readonly System.Type _converterType;        // 0x10
        private readonly System.Object[] <ConverterParameters>k__BackingField;        // 0x18

        // Methods
        private System.Type get_ConverterType() { }
        private System.Object[] get_ConverterParameters() { }

    }

    // TypeToken: 0x200001B
    public class JsonConverterCollection : Collection`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001C
    public class JsonDictionaryAttribute : JsonContainerAttribute
    {
    }

    // TypeToken: 0x200001D
    public class JsonException : Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }

    }

    // TypeToken: 0x200001E
    public class JsonExtensionDataAttribute : Attribute
    {
        // Fields
        private System.Boolean <WriteData>k__BackingField;        // 0x10
        private System.Boolean <ReadData>k__BackingField;        // 0x11

        // Methods
        private System.Boolean get_WriteData() { }
        private System.Boolean get_ReadData() { }

    }

    // TypeToken: 0x200001F
    public class JsonIgnoreAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class JsonNameTable
    {
        // Methods
        private System.String Get(System.Char[] key, System.Int32 start, System.Int32 length) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class JsonObjectAttribute : JsonContainerAttribute
    {
        // Fields
        private Newtonsoft.Json.MemberSerialization _memberSerialization;        // 0x50
        private System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling;        // 0x54
        private System.Nullable<Newtonsoft.Json.Required> _itemRequired;        // 0x5C
        private System.Nullable<Newtonsoft.Json.NullValueHandling> _itemNullValueHandling;        // 0x64

        // Methods
        private Newtonsoft.Json.MemberSerialization get_MemberSerialization() { }

    }

    // TypeToken: 0x2000022
    public struct JsonContainerType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.JsonContainerType None;        // 0x0
        public static Newtonsoft.Json.JsonContainerType Object;        // 0x0
        public static Newtonsoft.Json.JsonContainerType Array;        // 0x0
        public static Newtonsoft.Json.JsonContainerType Constructor;        // 0x0

    }

    // TypeToken: 0x2000023
    public struct JsonPosition
    {
        // Fields
        private static readonly System.Char[] SpecialCharacters;        // 0x0
        private Newtonsoft.Json.JsonContainerType Type;        // 0x10
        private System.Int32 Position;        // 0x14
        private System.String PropertyName;        // 0x18
        private System.Boolean HasIndex;        // 0x20

        // Methods
        private System.Void .ctor(Newtonsoft.Json.JsonContainerType type) { }
        private System.Int32 CalculateLength() { }
        private System.Void WriteTo(System.Text.StringBuilder sb, System.IO.StringWriter& writer, System.Char[]& buffer) { }
        private System.Boolean TypeHasIndex(Newtonsoft.Json.JsonContainerType type) { }
        private System.String BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition) { }
        private System.String FormatMessage(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000024
    public class JsonPropertyAttribute : Attribute
    {
        // Fields
        private System.Nullable<Newtonsoft.Json.NullValueHandling> _nullValueHandling;        // 0x10
        private System.Nullable<Newtonsoft.Json.DefaultValueHandling> _defaultValueHandling;        // 0x18
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _referenceLoopHandling;        // 0x20
        private System.Nullable<Newtonsoft.Json.ObjectCreationHandling> _objectCreationHandling;        // 0x28
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> _typeNameHandling;        // 0x30
        private System.Nullable<System.Boolean> _isReference;        // 0x38
        private System.Nullable<System.Int32> _order;        // 0x3C
        private System.Nullable<Newtonsoft.Json.Required> _required;        // 0x44
        private System.Nullable<System.Boolean> _itemIsReference;        // 0x4C
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _itemReferenceLoopHandling;        // 0x50
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> _itemTypeNameHandling;        // 0x58
        private System.Type <ItemConverterType>k__BackingField;        // 0x60
        private System.Object[] <ItemConverterParameters>k__BackingField;        // 0x68
        private System.Type <NamingStrategyType>k__BackingField;        // 0x70
        private System.Object[] <NamingStrategyParameters>k__BackingField;        // 0x78
        private System.String <PropertyName>k__BackingField;        // 0x80

        // Methods
        private System.Type get_ItemConverterType() { }
        private System.Object[] get_ItemConverterParameters() { }
        private System.Type get_NamingStrategyType() { }
        private System.Object[] get_NamingStrategyParameters() { }
        private System.Void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value) { }
        private System.Void set_Order(System.Int32 value) { }
        private System.String get_PropertyName() { }
        private System.Void set_PropertyName(System.String value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String propertyName) { }

    }

    // TypeToken: 0x2000025
    public class JsonReader, IDisposable
    {
        // Fields
        private Newtonsoft.Json.JsonToken _tokenType;        // 0x10
        private System.Object _value;        // 0x18
        private System.Char _quoteChar;        // 0x20
        private Newtonsoft.Json.JsonReader.State _currentState;        // 0x24
        private Newtonsoft.Json.JsonPosition _currentPosition;        // 0x28
        private System.Globalization.CultureInfo _culture;        // 0x40
        private Newtonsoft.Json.DateTimeZoneHandling _dateTimeZoneHandling;        // 0x48
        private System.Nullable<System.Int32> _maxDepth;        // 0x4C
        private System.Boolean _hasExceededMaxDepth;        // 0x54
        private Newtonsoft.Json.DateParseHandling _dateParseHandling;        // 0x58
        private Newtonsoft.Json.FloatParseHandling _floatParseHandling;        // 0x5C
        private System.String _dateFormatString;        // 0x60
        private System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> _stack;        // 0x68
        private System.Boolean <CloseInput>k__BackingField;        // 0x70
        private System.Boolean <SupportMultipleContent>k__BackingField;        // 0x71

        // Methods
        private Newtonsoft.Json.JsonReader.State get_CurrentState() { }
        private System.Boolean get_CloseInput() { }
        private System.Void set_CloseInput(System.Boolean value) { }
        private System.Boolean get_SupportMultipleContent() { }
        private System.Void set_SupportMultipleContent(System.Boolean value) { }
        private Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling() { }
        private System.Void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value) { }
        private Newtonsoft.Json.DateParseHandling get_DateParseHandling() { }
        private System.Void set_DateParseHandling(Newtonsoft.Json.DateParseHandling value) { }
        private Newtonsoft.Json.FloatParseHandling get_FloatParseHandling() { }
        private System.Void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling value) { }
        private System.String get_DateFormatString() { }
        private System.Void set_DateFormatString(System.String value) { }
        private System.Nullable<System.Int32> get_MaxDepth() { }
        private System.Void set_MaxDepth(System.Nullable<System.Int32> value) { }
        private Newtonsoft.Json.JsonToken get_TokenType() { }
        private System.Object get_Value() { }
        private System.Type get_ValueType() { }
        private System.Int32 get_Depth() { }
        private System.String get_Path() { }
        private System.Globalization.CultureInfo get_Culture() { }
        private System.Void set_Culture(System.Globalization.CultureInfo value) { }
        private Newtonsoft.Json.JsonPosition GetPosition(System.Int32 depth) { }
        private System.Void .ctor() { }
        private System.Void Push(Newtonsoft.Json.JsonContainerType value) { }
        private Newtonsoft.Json.JsonContainerType Pop() { }
        private Newtonsoft.Json.JsonContainerType Peek() { }
        private System.Boolean Read() { }
        private System.Nullable<System.Int32> ReadAsInt32() { }
        private System.Nullable<System.Int32> ReadInt32String(System.String s) { }
        private System.String ReadAsString() { }
        private System.Byte[] ReadAsBytes() { }
        private System.Byte[] ReadArrayIntoByteArray() { }
        private System.Boolean ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<System.Byte> buffer) { }
        private System.Nullable<System.Double> ReadAsDouble() { }
        private System.Nullable<System.Double> ReadDoubleString(System.String s) { }
        private System.Nullable<System.Boolean> ReadAsBoolean() { }
        private System.Nullable<System.Boolean> ReadBooleanString(System.String s) { }
        private System.Nullable<System.Decimal> ReadAsDecimal() { }
        private System.Nullable<System.Decimal> ReadDecimalString(System.String s) { }
        private System.Nullable<System.DateTime> ReadAsDateTime() { }
        private System.Nullable<System.DateTime> ReadDateTimeString(System.String s) { }
        private System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }
        private System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(System.String s) { }
        private System.Void ReaderReadAndAssert() { }
        private Newtonsoft.Json.JsonReaderException CreateUnexpectedEndException() { }
        private System.Void ReadIntoWrappedTypeObject() { }
        private System.Void Skip() { }
        private System.Void SetToken(Newtonsoft.Json.JsonToken newToken) { }
        private System.Void SetToken(Newtonsoft.Json.JsonToken newToken, System.Object value) { }
        private System.Void SetToken(Newtonsoft.Json.JsonToken newToken, System.Object value, System.Boolean updateIndex) { }
        private System.Void SetPostValueState(System.Boolean updateIndex) { }
        private System.Void UpdateScopeWithFinishedValue() { }
        private System.Void ValidateEnd(Newtonsoft.Json.JsonToken endToken) { }
        private System.Void SetStateBasedOnCurrent() { }
        private System.Void SetFinished() { }
        private Newtonsoft.Json.JsonContainerType GetTypeForCloseToken(Newtonsoft.Json.JsonToken token) { }
        private System.Void System.IDisposable.Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Close() { }
        private System.Void ReadAndAssert() { }
        private System.Void ReadForTypeAndAssert(Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean hasConverter) { }
        private System.Boolean ReadForType(Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean hasConverter) { }
        private System.Boolean ReadAndMoveToContent() { }
        private System.Boolean MoveToContent() { }
        private Newtonsoft.Json.JsonToken GetContentToken() { }

    }

    // TypeToken: 0x2000027
    public class JsonReaderException : JsonException
    {
        // Fields
        private readonly System.Int32 <LineNumber>k__BackingField;        // 0x90
        private readonly System.Int32 <LinePosition>k__BackingField;        // 0x94
        private readonly System.String <Path>k__BackingField;        // 0x98

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor(System.String message, System.String path, System.Int32 lineNumber, System.Int32 linePosition, System.Exception innerException) { }
        private Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, System.String message) { }
        private Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, System.String message, System.Exception ex) { }
        private Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message, System.Exception ex) { }

    }

    // TypeToken: 0x2000028
    public class JsonRequiredAttribute : Attribute
    {
    }

    // TypeToken: 0x2000029
    public class JsonSerializationException : JsonException
    {
        // Fields
        private readonly System.Int32 <LineNumber>k__BackingField;        // 0x90
        private readonly System.Int32 <LinePosition>k__BackingField;        // 0x94
        private readonly System.String <Path>k__BackingField;        // 0x98

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor(System.String message, System.String path, System.Int32 lineNumber, System.Int32 linePosition, System.Exception innerException) { }
        private Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, System.String message) { }
        private Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, System.String message, System.Exception ex) { }
        private Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message, System.Exception ex) { }

    }

    // TypeToken: 0x200002A
    public class JsonSerializer
    {
        // Fields
        private Newtonsoft.Json.TypeNameHandling _typeNameHandling;        // 0x10
        private Newtonsoft.Json.TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling;        // 0x14
        private Newtonsoft.Json.PreserveReferencesHandling _preserveReferencesHandling;        // 0x18
        private Newtonsoft.Json.ReferenceLoopHandling _referenceLoopHandling;        // 0x1C
        private Newtonsoft.Json.MissingMemberHandling _missingMemberHandling;        // 0x20
        private Newtonsoft.Json.ObjectCreationHandling _objectCreationHandling;        // 0x24
        private Newtonsoft.Json.NullValueHandling _nullValueHandling;        // 0x28
        private Newtonsoft.Json.DefaultValueHandling _defaultValueHandling;        // 0x2C
        private Newtonsoft.Json.ConstructorHandling _constructorHandling;        // 0x30
        private Newtonsoft.Json.MetadataPropertyHandling _metadataPropertyHandling;        // 0x34
        private Newtonsoft.Json.JsonConverterCollection _converters;        // 0x38
        private Newtonsoft.Json.Serialization.IContractResolver _contractResolver;        // 0x40
        private Newtonsoft.Json.Serialization.ITraceWriter _traceWriter;        // 0x48
        private System.Collections.IEqualityComparer _equalityComparer;        // 0x50
        private Newtonsoft.Json.Serialization.ISerializationBinder _serializationBinder;        // 0x58
        private System.Runtime.Serialization.StreamingContext _context;        // 0x60
        private Newtonsoft.Json.Serialization.IReferenceResolver _referenceResolver;        // 0x70
        private System.Nullable<Newtonsoft.Json.Formatting> _formatting;        // 0x78
        private System.Nullable<Newtonsoft.Json.DateFormatHandling> _dateFormatHandling;        // 0x80
        private System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> _dateTimeZoneHandling;        // 0x88
        private System.Nullable<Newtonsoft.Json.DateParseHandling> _dateParseHandling;        // 0x90
        private System.Nullable<Newtonsoft.Json.FloatFormatHandling> _floatFormatHandling;        // 0x98
        private System.Nullable<Newtonsoft.Json.FloatParseHandling> _floatParseHandling;        // 0xA0
        private System.Nullable<Newtonsoft.Json.StringEscapeHandling> _stringEscapeHandling;        // 0xA8
        private System.Globalization.CultureInfo _culture;        // 0xB0
        private System.Nullable<System.Int32> _maxDepth;        // 0xB8
        private System.Boolean _maxDepthSet;        // 0xC0
        private System.Nullable<System.Boolean> _checkAdditionalContent;        // 0xC1
        private System.String _dateFormatString;        // 0xC8
        private System.Boolean _dateFormatStringSet;        // 0xD0
        private System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error;        // 0xD8

        // Methods
        private System.Void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }
        private System.Void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }
        private System.Void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value) { }
        private System.Void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value) { }
        private Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter() { }
        private System.Void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value) { }
        private System.Void set_EqualityComparer(System.Collections.IEqualityComparer value) { }
        private System.Void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value) { }
        private System.Void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value) { }
        private System.Void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value) { }
        private System.Void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value) { }
        private System.Void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value) { }
        private Newtonsoft.Json.NullValueHandling get_NullValueHandling() { }
        private System.Void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value) { }
        private System.Void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value) { }
        private System.Void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value) { }
        private System.Void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value) { }
        private Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling() { }
        private System.Void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value) { }
        private Newtonsoft.Json.JsonConverterCollection get_Converters() { }
        private Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver() { }
        private System.Void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value) { }
        private System.Runtime.Serialization.StreamingContext get_Context() { }
        private System.Void set_Context(System.Runtime.Serialization.StreamingContext value) { }
        private Newtonsoft.Json.Formatting get_Formatting() { }
        private System.Void set_Formatting(Newtonsoft.Json.Formatting value) { }
        private System.Nullable<System.Int32> get_MaxDepth() { }
        private System.Boolean get_CheckAdditionalContent() { }
        private System.Void set_CheckAdditionalContent(System.Boolean value) { }
        private System.Boolean IsCheckAdditionalContentSet() { }
        private System.Void .ctor() { }
        private Newtonsoft.Json.JsonSerializer Create() { }
        private Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings settings) { }
        private Newtonsoft.Json.JsonSerializer CreateDefault() { }
        private Newtonsoft.Json.JsonSerializer CreateDefault(Newtonsoft.Json.JsonSerializerSettings settings) { }
        private System.Void ApplySerializerSettings(Newtonsoft.Json.JsonSerializer serializer, Newtonsoft.Json.JsonSerializerSettings settings) { }
        private System.Void Populate(Newtonsoft.Json.JsonReader reader, System.Object target) { }
        private System.Void PopulateInternal(Newtonsoft.Json.JsonReader reader, System.Object target) { }
        private T Deserialize(Newtonsoft.Json.JsonReader reader) { }
        private System.Object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType) { }
        private System.Object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType) { }
        private System.Void SetupReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo& previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>& previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling>& previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling>& previousFloatParseHandling, System.Nullable<System.Int32>& previousMaxDepth, System.String& previousDateFormatString) { }
        private System.Void ResetReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<System.Int32> previousMaxDepth, System.String previousDateFormatString) { }
        private System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType) { }
        private System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value) { }
        private Newtonsoft.Json.Serialization.TraceJsonReader CreateTraceJsonReader(Newtonsoft.Json.JsonReader reader) { }
        private System.Void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType) { }
        private Newtonsoft.Json.Serialization.IReferenceResolver GetReferenceResolver() { }
        private Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Type type) { }
        private Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, System.Type objectType) { }
        private System.Void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e) { }

    }

    // TypeToken: 0x200002B
    public class JsonSerializerSettings
    {
        // Fields
        private static Newtonsoft.Json.ReferenceLoopHandling DefaultReferenceLoopHandling;        // 0x0
        private static Newtonsoft.Json.MissingMemberHandling DefaultMissingMemberHandling;        // 0x0
        private static Newtonsoft.Json.NullValueHandling DefaultNullValueHandling;        // 0x0
        private static Newtonsoft.Json.DefaultValueHandling DefaultDefaultValueHandling;        // 0x0
        private static Newtonsoft.Json.ObjectCreationHandling DefaultObjectCreationHandling;        // 0x0
        private static Newtonsoft.Json.PreserveReferencesHandling DefaultPreserveReferencesHandling;        // 0x0
        private static Newtonsoft.Json.ConstructorHandling DefaultConstructorHandling;        // 0x0
        private static Newtonsoft.Json.TypeNameHandling DefaultTypeNameHandling;        // 0x0
        private static Newtonsoft.Json.MetadataPropertyHandling DefaultMetadataPropertyHandling;        // 0x0
        private static readonly System.Runtime.Serialization.StreamingContext DefaultContext;        // 0x0
        private static Newtonsoft.Json.Formatting DefaultFormatting;        // 0x0
        private static Newtonsoft.Json.DateFormatHandling DefaultDateFormatHandling;        // 0x0
        private static Newtonsoft.Json.DateTimeZoneHandling DefaultDateTimeZoneHandling;        // 0x0
        private static Newtonsoft.Json.DateParseHandling DefaultDateParseHandling;        // 0x0
        private static Newtonsoft.Json.FloatParseHandling DefaultFloatParseHandling;        // 0x0
        private static Newtonsoft.Json.FloatFormatHandling DefaultFloatFormatHandling;        // 0x0
        private static Newtonsoft.Json.StringEscapeHandling DefaultStringEscapeHandling;        // 0x0
        private static Newtonsoft.Json.TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling;        // 0x0
        private static readonly System.Globalization.CultureInfo DefaultCulture;        // 0x10
        private static System.Boolean DefaultCheckAdditionalContent;        // 0x0
        private static System.String DefaultDateFormatString;        // 0x0
        private static System.Int32 DefaultMaxDepth;        // 0x0
        private System.Nullable<Newtonsoft.Json.Formatting> _formatting;        // 0x10
        private System.Nullable<Newtonsoft.Json.DateFormatHandling> _dateFormatHandling;        // 0x18
        private System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> _dateTimeZoneHandling;        // 0x20
        private System.Nullable<Newtonsoft.Json.DateParseHandling> _dateParseHandling;        // 0x28
        private System.Nullable<Newtonsoft.Json.FloatFormatHandling> _floatFormatHandling;        // 0x30
        private System.Nullable<Newtonsoft.Json.FloatParseHandling> _floatParseHandling;        // 0x38
        private System.Nullable<Newtonsoft.Json.StringEscapeHandling> _stringEscapeHandling;        // 0x40
        private System.Globalization.CultureInfo _culture;        // 0x48
        private System.Nullable<System.Boolean> _checkAdditionalContent;        // 0x50
        private System.Nullable<System.Int32> _maxDepth;        // 0x54
        private System.Boolean _maxDepthSet;        // 0x5C
        private System.String _dateFormatString;        // 0x60
        private System.Boolean _dateFormatStringSet;        // 0x68
        private System.Nullable<Newtonsoft.Json.TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling;        // 0x6C
        private System.Nullable<Newtonsoft.Json.DefaultValueHandling> _defaultValueHandling;        // 0x74
        private System.Nullable<Newtonsoft.Json.PreserveReferencesHandling> _preserveReferencesHandling;        // 0x7C
        private System.Nullable<Newtonsoft.Json.NullValueHandling> _nullValueHandling;        // 0x84
        private System.Nullable<Newtonsoft.Json.ObjectCreationHandling> _objectCreationHandling;        // 0x8C
        private System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling;        // 0x94
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _referenceLoopHandling;        // 0x9C
        private System.Nullable<System.Runtime.Serialization.StreamingContext> _context;        // 0xA8
        private System.Nullable<Newtonsoft.Json.ConstructorHandling> _constructorHandling;        // 0xC0
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> _typeNameHandling;        // 0xC8
        private System.Nullable<Newtonsoft.Json.MetadataPropertyHandling> _metadataPropertyHandling;        // 0xD0
        private System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> <Converters>k__BackingField;        // 0xD8
        private Newtonsoft.Json.Serialization.IContractResolver <ContractResolver>k__BackingField;        // 0xE0
        private System.Collections.IEqualityComparer <EqualityComparer>k__BackingField;        // 0xE8
        private System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> <ReferenceResolverProvider>k__BackingField;        // 0xF0
        private Newtonsoft.Json.Serialization.ITraceWriter <TraceWriter>k__BackingField;        // 0xF8
        private Newtonsoft.Json.Serialization.ISerializationBinder <SerializationBinder>k__BackingField;        // 0x100
        private System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> <Error>k__BackingField;        // 0x108

        // Methods
        private Newtonsoft.Json.ReferenceLoopHandling get_ReferenceLoopHandling() { }
        private System.Void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value) { }
        private Newtonsoft.Json.MissingMemberHandling get_MissingMemberHandling() { }
        private Newtonsoft.Json.ObjectCreationHandling get_ObjectCreationHandling() { }
        private System.Void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value) { }
        private Newtonsoft.Json.NullValueHandling get_NullValueHandling() { }
        private System.Void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value) { }
        private Newtonsoft.Json.DefaultValueHandling get_DefaultValueHandling() { }
        private System.Void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value) { }
        private System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters() { }
        private System.Void set_Converters(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> value) { }
        private Newtonsoft.Json.PreserveReferencesHandling get_PreserveReferencesHandling() { }
        private Newtonsoft.Json.TypeNameHandling get_TypeNameHandling() { }
        private System.Void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value) { }
        private Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling() { }
        private Newtonsoft.Json.TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }
        private System.Void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value) { }
        private Newtonsoft.Json.ConstructorHandling get_ConstructorHandling() { }
        private System.Void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value) { }
        private Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver() { }
        private System.Void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value) { }
        private System.Collections.IEqualityComparer get_EqualityComparer() { }
        private System.Void set_EqualityComparer(System.Collections.IEqualityComparer value) { }
        private System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider() { }
        private System.Void set_ReferenceResolverProvider(System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> value) { }
        private Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter() { }
        private System.Void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value) { }
        private Newtonsoft.Json.Serialization.ISerializationBinder get_SerializationBinder() { }
        private System.Void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value) { }
        private System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error() { }
        private System.Void set_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }
        private System.Runtime.Serialization.StreamingContext get_Context() { }
        private System.Void set_MaxDepth(System.Nullable<System.Int32> value) { }
        private System.Void set_Formatting(Newtonsoft.Json.Formatting value) { }
        private System.Boolean get_CheckAdditionalContent() { }
        private System.Void .cctor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Newtonsoft.Json.JsonSerializerSettings original) { }

    }

    // TypeToken: 0x200002C
    public class JsonTextReader : JsonReader, IJsonLineInfo
    {
        // Fields
        private readonly System.Boolean _safeAsync;        // 0x78
        private readonly System.IO.TextReader _reader;        // 0x80
        private System.Char[] _chars;        // 0x88
        private System.Int32 _charsUsed;        // 0x90
        private System.Int32 _charPos;        // 0x94
        private System.Int32 _lineStartPos;        // 0x98
        private System.Int32 _lineNumber;        // 0x9C
        private System.Boolean _isEndOfFile;        // 0xA0
        private Newtonsoft.Json.Utilities.StringBuffer _stringBuffer;        // 0xA8
        private Newtonsoft.Json.Utilities.StringReference _stringReference;        // 0xB8
        private Newtonsoft.Json.IArrayPool<System.Char> _arrayPool;        // 0xC8
        private Newtonsoft.Json.JsonNameTable <PropertyNameTable>k__BackingField;        // 0xD0

        // Methods
        private System.Void .ctor(System.IO.TextReader reader) { }
        private Newtonsoft.Json.JsonNameTable get_PropertyNameTable() { }
        private System.Void set_PropertyNameTable(Newtonsoft.Json.JsonNameTable value) { }
        private System.Void EnsureBufferNotEmpty() { }
        private System.Void SetNewLine(System.Boolean hasNextChar) { }
        private System.Void OnNewLine(System.Int32 pos) { }
        private System.Void ParseString(System.Char quote, Newtonsoft.Json.ReadType readType) { }
        private System.Void ParseReadString(System.Char quote, Newtonsoft.Json.ReadType readType) { }
        private System.Void BlockCopyChars(System.Char[] src, System.Int32 srcOffset, System.Char[] dst, System.Int32 dstOffset, System.Int32 count) { }
        private System.Void ShiftBufferIfNeeded() { }
        private System.Int32 ReadData(System.Boolean append) { }
        private System.Void PrepareBufferForReadData(System.Boolean append, System.Int32 charsRequired) { }
        private System.Int32 ReadData(System.Boolean append, System.Int32 charsRequired) { }
        private System.Boolean EnsureChars(System.Int32 relativePosition, System.Boolean append) { }
        private System.Boolean ReadChars(System.Int32 relativePosition, System.Boolean append) { }
        private System.Boolean Read() { }
        private System.Nullable<System.Int32> ReadAsInt32() { }
        private System.Nullable<System.DateTime> ReadAsDateTime() { }
        private System.String ReadAsString() { }
        private System.Byte[] ReadAsBytes() { }
        private System.Object ReadStringValue(Newtonsoft.Json.ReadType readType) { }
        private System.Object FinishReadQuotedStringValue(Newtonsoft.Json.ReadType readType) { }
        private Newtonsoft.Json.JsonReaderException CreateUnexpectedCharacterException(System.Char c) { }
        private System.Nullable<System.Boolean> ReadAsBoolean() { }
        private System.Void ProcessValueComma() { }
        private System.Object ReadNumberValue(Newtonsoft.Json.ReadType readType) { }
        private System.Object FinishReadQuotedNumber(Newtonsoft.Json.ReadType readType) { }
        private System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }
        private System.Nullable<System.Decimal> ReadAsDecimal() { }
        private System.Nullable<System.Double> ReadAsDouble() { }
        private System.Void HandleNull() { }
        private System.Void ReadFinished() { }
        private System.Boolean ReadNullChar() { }
        private System.Void EnsureBuffer() { }
        private System.Void ReadStringIntoBuffer(System.Char quote) { }
        private System.Void FinishReadStringIntoBuffer(System.Int32 charPos, System.Int32 initialPosition, System.Int32 lastWritePosition) { }
        private System.Void WriteCharToBuffer(System.Char writeChar, System.Int32 lastWritePosition, System.Int32 writeToPosition) { }
        private System.Char ConvertUnicode(System.Boolean enoughChars) { }
        private System.Char ParseUnicode() { }
        private System.Void ReadNumberIntoBuffer() { }
        private System.Boolean ReadNumberCharIntoBuffer(System.Char currentChar, System.Int32 charPos) { }
        private System.Void ClearRecentString() { }
        private System.Boolean ParsePostValue(System.Boolean ignoreComments) { }
        private System.Boolean ParseObject() { }
        private System.Boolean ParseProperty() { }
        private System.Boolean ValidIdentifierChar(System.Char value) { }
        private System.Void ParseUnquotedProperty() { }
        private System.Boolean ReadUnquotedPropertyReportIfDone(System.Char currentChar, System.Int32 initialPosition) { }
        private System.Boolean ParseValue() { }
        private System.Void ProcessLineFeed() { }
        private System.Void ProcessCarriageReturn(System.Boolean append) { }
        private System.Void EatWhitespace() { }
        private System.Void ParseConstructor() { }
        private System.Void ParseNumber(Newtonsoft.Json.ReadType readType) { }
        private System.Void ParseReadNumber(Newtonsoft.Json.ReadType readType, System.Char firstChar, System.Int32 initialPosition) { }
        private Newtonsoft.Json.JsonReaderException ThrowReaderError(System.String message, System.Exception ex) { }
        private System.Object BigIntegerParse(System.String number, System.Globalization.CultureInfo culture) { }
        private System.Void ParseComment(System.Boolean setToken) { }
        private System.Void EndComment(System.Boolean setToken, System.Int32 initialPosition, System.Int32 endPosition) { }
        private System.Boolean MatchValue(System.String value) { }
        private System.Boolean MatchValue(System.Boolean enoughChars, System.String value) { }
        private System.Boolean MatchValueWithTrailingSeparator(System.String value) { }
        private System.Boolean IsSeparator(System.Char c) { }
        private System.Void ParseTrue() { }
        private System.Void ParseNull() { }
        private System.Void ParseUndefined() { }
        private System.Void ParseFalse() { }
        private System.Object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType) { }
        private System.Object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType, System.Boolean matched) { }
        private System.Object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType) { }
        private System.Object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType, System.Boolean matched) { }
        private System.Object ParseNumberNaN(Newtonsoft.Json.ReadType readType) { }
        private System.Object ParseNumberNaN(Newtonsoft.Json.ReadType readType, System.Boolean matched) { }
        private System.Void Close() { }
        private System.Boolean HasLineInfo() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }

    }

    // TypeToken: 0x200002D
    public struct ReadType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.ReadType Read;        // 0x0
        public static Newtonsoft.Json.ReadType ReadAsInt32;        // 0x0
        public static Newtonsoft.Json.ReadType ReadAsInt64;        // 0x0
        public static Newtonsoft.Json.ReadType ReadAsBytes;        // 0x0
        public static Newtonsoft.Json.ReadType ReadAsString;        // 0x0
        public static Newtonsoft.Json.ReadType ReadAsDecimal;        // 0x0
        public static Newtonsoft.Json.ReadType ReadAsDateTime;        // 0x0
        public static Newtonsoft.Json.ReadType ReadAsDateTimeOffset;        // 0x0
        public static Newtonsoft.Json.ReadType ReadAsDouble;        // 0x0
        public static Newtonsoft.Json.ReadType ReadAsBoolean;        // 0x0

    }

    // TypeToken: 0x200002E
    public class JsonTextWriter : JsonWriter
    {
        // Fields
        private readonly System.Boolean _safeAsync;        // 0x60
        private readonly System.IO.TextWriter _writer;        // 0x68
        private Newtonsoft.Json.Utilities.Base64Encoder _base64Encoder;        // 0x70
        private System.Char _indentChar;        // 0x78
        private System.Int32 _indentation;        // 0x7C
        private System.Char _quoteChar;        // 0x80
        private System.Boolean _quoteName;        // 0x82
        private System.Boolean[] _charEscapeFlags;        // 0x88
        private System.Char[] _writeBuffer;        // 0x90
        private Newtonsoft.Json.IArrayPool<System.Char> _arrayPool;        // 0x98
        private System.Char[] _indentChars;        // 0xA0

        // Methods
        private Newtonsoft.Json.Utilities.Base64Encoder get_Base64Encoder() { }
        private System.Char get_QuoteChar() { }
        private System.Void .ctor(System.IO.TextWriter textWriter) { }
        private System.Void Close() { }
        private System.Void CloseBufferAndWriter() { }
        private System.Void WriteStartObject() { }
        private System.Void WriteStartArray() { }
        private System.Void WriteStartConstructor(System.String name) { }
        private System.Void WriteEnd(Newtonsoft.Json.JsonToken token) { }
        private System.Void WritePropertyName(System.String name) { }
        private System.Void WritePropertyName(System.String name, System.Boolean escape) { }
        private System.Void OnStringEscapeHandlingChanged() { }
        private System.Void UpdateCharEscapeFlags() { }
        private System.Void WriteIndent() { }
        private System.Int32 SetIndentChars() { }
        private System.Void WriteValueDelimiter() { }
        private System.Void WriteIndentSpace() { }
        private System.Void WriteValueInternal(System.String value, Newtonsoft.Json.JsonToken token) { }
        private System.Void WriteValue(System.Object value) { }
        private System.Void WriteNull() { }
        private System.Void WriteUndefined() { }
        private System.Void WriteRaw(System.String json) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void WriteEscapedString(System.String value, System.Boolean quote) { }
        private System.Void WriteValue(System.Int32 value) { }
        private System.Void WriteValue(System.UInt32 value) { }
        private System.Void WriteValue(System.Int64 value) { }
        private System.Void WriteValue(System.UInt64 value) { }
        private System.Void WriteValue(System.Single value) { }
        private System.Void WriteValue(System.Nullable<System.Single> value) { }
        private System.Void WriteValue(System.Double value) { }
        private System.Void WriteValue(System.Nullable<System.Double> value) { }
        private System.Void WriteValue(System.Boolean value) { }
        private System.Void WriteValue(System.Int16 value) { }
        private System.Void WriteValue(System.UInt16 value) { }
        private System.Void WriteValue(System.Char value) { }
        private System.Void WriteValue(System.Byte value) { }
        private System.Void WriteValue(System.SByte value) { }
        private System.Void WriteValue(System.Decimal value) { }
        private System.Void WriteValue(System.DateTime value) { }
        private System.Int32 WriteValueToBuffer(System.DateTime value) { }
        private System.Void WriteValue(System.Byte[] value) { }
        private System.Void WriteValue(System.DateTimeOffset value) { }
        private System.Int32 WriteValueToBuffer(System.DateTimeOffset value) { }
        private System.Void WriteValue(System.Guid value) { }
        private System.Void WriteValue(System.TimeSpan value) { }
        private System.Void WriteValue(System.Uri value) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void EnsureWriteBuffer() { }
        private System.Void WriteIntegerValue(System.Int64 value) { }
        private System.Void WriteIntegerValue(System.UInt64 value, System.Boolean negative) { }
        private System.Int32 WriteNumberToBuffer(System.UInt64 value, System.Boolean negative) { }
        private System.Void WriteIntegerValue(System.Int32 value) { }
        private System.Void WriteIntegerValue(System.UInt32 value, System.Boolean negative) { }
        private System.Int32 WriteNumberToBuffer(System.UInt32 value, System.Boolean negative) { }

    }

    // TypeToken: 0x200002F
    public struct JsonToken
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.JsonToken None;        // 0x0
        public static Newtonsoft.Json.JsonToken StartObject;        // 0x0
        public static Newtonsoft.Json.JsonToken StartArray;        // 0x0
        public static Newtonsoft.Json.JsonToken StartConstructor;        // 0x0
        public static Newtonsoft.Json.JsonToken PropertyName;        // 0x0
        public static Newtonsoft.Json.JsonToken Comment;        // 0x0
        public static Newtonsoft.Json.JsonToken Raw;        // 0x0
        public static Newtonsoft.Json.JsonToken Integer;        // 0x0
        public static Newtonsoft.Json.JsonToken Float;        // 0x0
        public static Newtonsoft.Json.JsonToken String;        // 0x0
        public static Newtonsoft.Json.JsonToken Boolean;        // 0x0
        public static Newtonsoft.Json.JsonToken Null;        // 0x0
        public static Newtonsoft.Json.JsonToken Undefined;        // 0x0
        public static Newtonsoft.Json.JsonToken EndObject;        // 0x0
        public static Newtonsoft.Json.JsonToken EndArray;        // 0x0
        public static Newtonsoft.Json.JsonToken EndConstructor;        // 0x0
        public static Newtonsoft.Json.JsonToken Date;        // 0x0
        public static Newtonsoft.Json.JsonToken Bytes;        // 0x0

    }

    // TypeToken: 0x2000030
    public class JsonWriter, IDisposable
    {
        // Fields
        private static readonly Newtonsoft.Json.JsonWriter.State[][] StateArray;        // 0x0
        private static readonly Newtonsoft.Json.JsonWriter.State[][] StateArrayTemplate;        // 0x8
        private System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> _stack;        // 0x10
        private Newtonsoft.Json.JsonPosition _currentPosition;        // 0x18
        private Newtonsoft.Json.JsonWriter.State _currentState;        // 0x30
        private Newtonsoft.Json.Formatting _formatting;        // 0x34
        private System.Boolean <CloseOutput>k__BackingField;        // 0x38
        private System.Boolean <AutoCompleteOnClose>k__BackingField;        // 0x39
        private Newtonsoft.Json.DateFormatHandling _dateFormatHandling;        // 0x3C
        private Newtonsoft.Json.DateTimeZoneHandling _dateTimeZoneHandling;        // 0x40
        private Newtonsoft.Json.StringEscapeHandling _stringEscapeHandling;        // 0x44
        private Newtonsoft.Json.FloatFormatHandling _floatFormatHandling;        // 0x48
        private System.String _dateFormatString;        // 0x50
        private System.Globalization.CultureInfo _culture;        // 0x58

        // Methods
        private Newtonsoft.Json.JsonWriter.State[][] BuildStateArray() { }
        private System.Void .cctor() { }
        private System.Boolean get_CloseOutput() { }
        private System.Void set_CloseOutput(System.Boolean value) { }
        private System.Boolean get_AutoCompleteOnClose() { }
        private System.Void set_AutoCompleteOnClose(System.Boolean value) { }
        private System.Int32 get_Top() { }
        private Newtonsoft.Json.WriteState get_WriteState() { }
        private System.String get_ContainerPath() { }
        private System.String get_Path() { }
        private Newtonsoft.Json.Formatting get_Formatting() { }
        private System.Void set_Formatting(Newtonsoft.Json.Formatting value) { }
        private Newtonsoft.Json.DateFormatHandling get_DateFormatHandling() { }
        private System.Void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling value) { }
        private Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling() { }
        private System.Void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value) { }
        private Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling() { }
        private System.Void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling value) { }
        private System.Void OnStringEscapeHandlingChanged() { }
        private Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling() { }
        private System.Void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling value) { }
        private System.String get_DateFormatString() { }
        private System.Void set_DateFormatString(System.String value) { }
        private System.Globalization.CultureInfo get_Culture() { }
        private System.Void set_Culture(System.Globalization.CultureInfo value) { }
        private System.Void .ctor() { }
        private System.Void UpdateScopeWithFinishedValue() { }
        private System.Void Push(Newtonsoft.Json.JsonContainerType value) { }
        private Newtonsoft.Json.JsonContainerType Pop() { }
        private Newtonsoft.Json.JsonContainerType Peek() { }
        private System.Void Close() { }
        private System.Void WriteStartObject() { }
        private System.Void WriteEndObject() { }
        private System.Void WriteStartArray() { }
        private System.Void WriteEndArray() { }
        private System.Void WriteStartConstructor(System.String name) { }
        private System.Void WriteEndConstructor() { }
        private System.Void WritePropertyName(System.String name) { }
        private System.Void WritePropertyName(System.String name, System.Boolean escape) { }
        private System.Void WriteEnd() { }
        private System.Void WriteToken(Newtonsoft.Json.JsonReader reader) { }
        private System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren) { }
        private System.Void WriteToken(Newtonsoft.Json.JsonToken token, System.Object value) { }
        private System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Boolean writeDateConstructorAsDate, System.Boolean writeComments) { }
        private System.Boolean IsWriteTokenIncomplete(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Int32 initialDepth) { }
        private System.Int32 CalculateWriteTokenInitialDepth(Newtonsoft.Json.JsonReader reader) { }
        private System.Int32 CalculateWriteTokenFinalDepth(Newtonsoft.Json.JsonReader reader) { }
        private System.Void WriteConstructorDate(Newtonsoft.Json.JsonReader reader) { }
        private System.Void WriteEnd(Newtonsoft.Json.JsonContainerType type) { }
        private System.Void AutoCompleteAll() { }
        private Newtonsoft.Json.JsonToken GetCloseTokenForType(Newtonsoft.Json.JsonContainerType type) { }
        private System.Void AutoCompleteClose(Newtonsoft.Json.JsonContainerType type) { }
        private System.Int32 CalculateLevelsToComplete(Newtonsoft.Json.JsonContainerType type) { }
        private System.Void UpdateCurrentState() { }
        private System.Void WriteEnd(Newtonsoft.Json.JsonToken token) { }
        private System.Void WriteIndent() { }
        private System.Void WriteValueDelimiter() { }
        private System.Void WriteIndentSpace() { }
        private System.Void AutoComplete(Newtonsoft.Json.JsonToken tokenBeingWritten) { }
        private System.Void WriteNull() { }
        private System.Void WriteUndefined() { }
        private System.Void WriteRaw(System.String json) { }
        private System.Void WriteRawValue(System.String json) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void WriteValue(System.Int32 value) { }
        private System.Void WriteValue(System.UInt32 value) { }
        private System.Void WriteValue(System.Int64 value) { }
        private System.Void WriteValue(System.UInt64 value) { }
        private System.Void WriteValue(System.Single value) { }
        private System.Void WriteValue(System.Double value) { }
        private System.Void WriteValue(System.Boolean value) { }
        private System.Void WriteValue(System.Int16 value) { }
        private System.Void WriteValue(System.UInt16 value) { }
        private System.Void WriteValue(System.Char value) { }
        private System.Void WriteValue(System.Byte value) { }
        private System.Void WriteValue(System.SByte value) { }
        private System.Void WriteValue(System.Decimal value) { }
        private System.Void WriteValue(System.DateTime value) { }
        private System.Void WriteValue(System.DateTimeOffset value) { }
        private System.Void WriteValue(System.Guid value) { }
        private System.Void WriteValue(System.TimeSpan value) { }
        private System.Void WriteValue(System.Nullable<System.Int32> value) { }
        private System.Void WriteValue(System.Nullable<System.UInt32> value) { }
        private System.Void WriteValue(System.Nullable<System.Int64> value) { }
        private System.Void WriteValue(System.Nullable<System.UInt64> value) { }
        private System.Void WriteValue(System.Nullable<System.Single> value) { }
        private System.Void WriteValue(System.Nullable<System.Double> value) { }
        private System.Void WriteValue(System.Nullable<System.Boolean> value) { }
        private System.Void WriteValue(System.Nullable<System.Int16> value) { }
        private System.Void WriteValue(System.Nullable<System.UInt16> value) { }
        private System.Void WriteValue(System.Nullable<System.Char> value) { }
        private System.Void WriteValue(System.Nullable<System.Byte> value) { }
        private System.Void WriteValue(System.Nullable<System.SByte> value) { }
        private System.Void WriteValue(System.Nullable<System.Decimal> value) { }
        private System.Void WriteValue(System.Nullable<System.DateTime> value) { }
        private System.Void WriteValue(System.Nullable<System.DateTimeOffset> value) { }
        private System.Void WriteValue(System.Nullable<System.Guid> value) { }
        private System.Void WriteValue(System.Nullable<System.TimeSpan> value) { }
        private System.Void WriteValue(System.Byte[] value) { }
        private System.Void WriteValue(System.Uri value) { }
        private System.Void WriteValue(System.Object value) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void System.IDisposable.Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void WriteValue(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, System.Object value) { }
        private System.Void ResolveConvertibleValue(System.IConvertible convertible, Newtonsoft.Json.Utilities.PrimitiveTypeCode& typeCode, System.Object& value) { }
        private Newtonsoft.Json.JsonWriterException CreateUnsupportedTypeException(Newtonsoft.Json.JsonWriter writer, System.Object value) { }
        private System.Void SetWriteState(Newtonsoft.Json.JsonToken token, System.Object value) { }
        private System.Void InternalWriteEnd(Newtonsoft.Json.JsonContainerType container) { }
        private System.Void InternalWritePropertyName(System.String name) { }
        private System.Void InternalWriteRaw() { }
        private System.Void InternalWriteStart(Newtonsoft.Json.JsonToken token, Newtonsoft.Json.JsonContainerType container) { }
        private System.Void InternalWriteValue(Newtonsoft.Json.JsonToken token) { }
        private System.Void InternalWriteComment() { }

    }

    // TypeToken: 0x2000032
    public class JsonWriterException : JsonException
    {
        // Fields
        private readonly System.String <Path>k__BackingField;        // 0x90

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor(System.String message, System.String path, System.Exception innerException) { }
        private Newtonsoft.Json.JsonWriterException Create(Newtonsoft.Json.JsonWriter writer, System.String message, System.Exception ex) { }
        private Newtonsoft.Json.JsonWriterException Create(System.String path, System.String message, System.Exception ex) { }

    }

    // TypeToken: 0x2000033
    public struct MemberSerialization
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.MemberSerialization OptOut;        // 0x0
        public static Newtonsoft.Json.MemberSerialization OptIn;        // 0x0
        public static Newtonsoft.Json.MemberSerialization Fields;        // 0x0

    }

    // TypeToken: 0x2000034
    public struct MetadataPropertyHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.MetadataPropertyHandling Default;        // 0x0
        public static Newtonsoft.Json.MetadataPropertyHandling ReadAhead;        // 0x0
        public static Newtonsoft.Json.MetadataPropertyHandling Ignore;        // 0x0

    }

    // TypeToken: 0x2000035
    public struct MissingMemberHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.MissingMemberHandling Ignore;        // 0x0
        public static Newtonsoft.Json.MissingMemberHandling Error;        // 0x0

    }

    // TypeToken: 0x2000036
    public struct NullValueHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.NullValueHandling Include;        // 0x0
        public static Newtonsoft.Json.NullValueHandling Ignore;        // 0x0

    }

    // TypeToken: 0x2000037
    public struct ObjectCreationHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.ObjectCreationHandling Auto;        // 0x0
        public static Newtonsoft.Json.ObjectCreationHandling Reuse;        // 0x0
        public static Newtonsoft.Json.ObjectCreationHandling Replace;        // 0x0

    }

    // TypeToken: 0x2000038
    public struct PreserveReferencesHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.PreserveReferencesHandling None;        // 0x0
        public static Newtonsoft.Json.PreserveReferencesHandling Objects;        // 0x0
        public static Newtonsoft.Json.PreserveReferencesHandling Arrays;        // 0x0
        public static Newtonsoft.Json.PreserveReferencesHandling All;        // 0x0

    }

    // TypeToken: 0x2000039
    public struct ReferenceLoopHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.ReferenceLoopHandling Error;        // 0x0
        public static Newtonsoft.Json.ReferenceLoopHandling Ignore;        // 0x0
        public static Newtonsoft.Json.ReferenceLoopHandling Serialize;        // 0x0

    }

    // TypeToken: 0x200003A
    public struct Required
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Required Default;        // 0x0
        public static Newtonsoft.Json.Required AllowNull;        // 0x0
        public static Newtonsoft.Json.Required Always;        // 0x0
        public static Newtonsoft.Json.Required DisallowNull;        // 0x0

    }

    // TypeToken: 0x200003B
    public struct StringEscapeHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.StringEscapeHandling Default;        // 0x0
        public static Newtonsoft.Json.StringEscapeHandling EscapeNonAscii;        // 0x0
        public static Newtonsoft.Json.StringEscapeHandling EscapeHtml;        // 0x0

    }

    // TypeToken: 0x200003C
    public struct TypeNameAssemblyFormatHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.TypeNameAssemblyFormatHandling Simple;        // 0x0
        public static Newtonsoft.Json.TypeNameAssemblyFormatHandling Full;        // 0x0

    }

    // TypeToken: 0x200003D
    public struct TypeNameHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.TypeNameHandling None;        // 0x0
        public static Newtonsoft.Json.TypeNameHandling Objects;        // 0x0
        public static Newtonsoft.Json.TypeNameHandling Arrays;        // 0x0
        public static Newtonsoft.Json.TypeNameHandling All;        // 0x0
        public static Newtonsoft.Json.TypeNameHandling Auto;        // 0x0

    }

    // TypeToken: 0x200003E
    public struct WriteState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.WriteState Error;        // 0x0
        public static Newtonsoft.Json.WriteState Closed;        // 0x0
        public static Newtonsoft.Json.WriteState Object;        // 0x0
        public static Newtonsoft.Json.WriteState Array;        // 0x0
        public static Newtonsoft.Json.WriteState Constructor;        // 0x0
        public static Newtonsoft.Json.WriteState Property;        // 0x0
        public static Newtonsoft.Json.WriteState Start;        // 0x0

    }

}

namespace Newtonsoft.Json.Bson
{

    // TypeToken: 0x2000122
    public class BsonObjectId
    {
        // Fields
        private readonly System.Byte[] <Value>k__BackingField;        // 0x10

        // Methods
        private System.Byte[] get_Value() { }
        private System.Void .ctor(System.Byte[] value) { }

    }

    // TypeToken: 0x2000123
    public class BsonToken
    {
        // Fields
        private Newtonsoft.Json.Bson.BsonToken <Parent>k__BackingField;        // 0x10

        // Methods
        private Newtonsoft.Json.Bson.BsonType get_Type() { }
        private System.Void set_Parent(Newtonsoft.Json.Bson.BsonToken value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000124
    public class BsonObject : BsonToken
    {
        // Fields
        private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children;        // 0x18

        // Methods
        private System.Void Add(System.String name, Newtonsoft.Json.Bson.BsonToken token) { }
        private Newtonsoft.Json.Bson.BsonType get_Type() { }

    }

    // TypeToken: 0x2000125
    public class BsonArray : BsonToken
    {
        // Fields
        private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children;        // 0x18

        // Methods
        private System.Void Add(Newtonsoft.Json.Bson.BsonToken token) { }
        private Newtonsoft.Json.Bson.BsonType get_Type() { }

    }

    // TypeToken: 0x2000126
    public class BsonValue : BsonToken
    {
        // Fields
        private readonly System.Object _value;        // 0x18
        private readonly Newtonsoft.Json.Bson.BsonType _type;        // 0x20

        // Methods
        private System.Void .ctor(System.Object value, Newtonsoft.Json.Bson.BsonType type) { }
        private Newtonsoft.Json.Bson.BsonType get_Type() { }

    }

    // TypeToken: 0x2000127
    public class BsonString : BsonValue
    {
        // Fields
        private readonly System.Boolean <IncludeLength>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.Object value, System.Boolean includeLength) { }

    }

    // TypeToken: 0x2000128
    public class BsonRegex : BsonToken
    {
        // Fields
        private Newtonsoft.Json.Bson.BsonString <Pattern>k__BackingField;        // 0x18
        private Newtonsoft.Json.Bson.BsonString <Options>k__BackingField;        // 0x20

        // Methods
        private System.Void set_Pattern(Newtonsoft.Json.Bson.BsonString value) { }
        private System.Void set_Options(Newtonsoft.Json.Bson.BsonString value) { }
        private System.Void .ctor(System.String pattern, System.String options) { }
        private Newtonsoft.Json.Bson.BsonType get_Type() { }

    }

    // TypeToken: 0x2000129
    public class BsonProperty
    {
        // Fields
        private Newtonsoft.Json.Bson.BsonString <Name>k__BackingField;        // 0x10
        private Newtonsoft.Json.Bson.BsonToken <Value>k__BackingField;        // 0x18

        // Methods
        private System.Void set_Name(Newtonsoft.Json.Bson.BsonString value) { }
        private System.Void set_Value(Newtonsoft.Json.Bson.BsonToken value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012A
    public struct BsonType
    {
        // Fields
        public System.SByte value__;        // 0x10
        public static Newtonsoft.Json.Bson.BsonType Number;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType String;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Object;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Array;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Binary;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Undefined;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Oid;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Boolean;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Date;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Null;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Regex;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Reference;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Code;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Symbol;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType CodeWScope;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Integer;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType TimeStamp;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType Long;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType MinKey;        // 0x0
        public static Newtonsoft.Json.Bson.BsonType MaxKey;        // 0x0

    }

    // TypeToken: 0x200012B
    public class BsonWriter : JsonWriter
    {
        // Fields
        private Newtonsoft.Json.Bson.BsonToken _root;        // 0x60
        private Newtonsoft.Json.Bson.BsonToken _parent;        // 0x68
        private System.String _propertyName;        // 0x70

        // Methods
        private System.Void AddValue(System.Object value, Newtonsoft.Json.Bson.BsonType type) { }
        private System.Void AddToken(Newtonsoft.Json.Bson.BsonToken token) { }
        private System.Void WriteObjectId(System.Byte[] value) { }
        private System.Void WriteRegex(System.String pattern, System.String options) { }

    }

}

namespace Newtonsoft.Json.Converters
{

    // TypeToken: 0x20000F9
    public class BinaryConverter : JsonConverter
    {
        // Fields
        private static System.String BinaryTypeName;        // 0x0
        private static System.String BinaryToArrayName;        // 0x0
        private static Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;        // 0x0

        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Byte[] GetByteArray(System.Object value) { }
        private System.Void EnsureReflectionObject(System.Type t) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Byte[] ReadByteArray(Newtonsoft.Json.JsonReader reader) { }
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FA
    public class BsonObjectIdConverter : JsonConverter
    {
        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FB
    public class CustomCreationConverter`1 : JsonConverter
    {
        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private T Create(System.Type objectType) { }
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Boolean get_CanWrite() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FC
    public class DataSetConverter : JsonConverter
    {
        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Boolean CanConvert(System.Type valueType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FD
    public class DataTableConverter : JsonConverter
    {
        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Void CreateRow(Newtonsoft.Json.JsonReader reader, System.Data.DataTable dt, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Type GetColumnDataType(Newtonsoft.Json.JsonReader reader) { }
        private System.Boolean CanConvert(System.Type valueType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FE
    public class DateTimeConverterBase : JsonConverter
    {
        // Methods
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FF
    public class DiscriminatedUnionConverter : JsonConverter
    {
        // Fields
        private static System.String CasePropertyName;        // 0x0
        private static System.String FieldsPropertyName;        // 0x0
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union> UnionCache;        // 0x0
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Type> UnionTypeLookupCache;        // 0x8

        // Methods
        private System.Type CreateUnionTypeLookup(System.Type t) { }
        private Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union CreateUnion(System.Type t) { }
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000104
    public class EntityKeyMemberConverter : JsonConverter
    {
        // Fields
        private static System.String EntityKeyMemberFullTypeName;        // 0x0
        private static System.String KeyPropertyName;        // 0x0
        private static System.String TypePropertyName;        // 0x0
        private static System.String ValuePropertyName;        // 0x0
        private static Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;        // 0x0

        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Void ReadAndAssertProperty(Newtonsoft.Json.JsonReader reader, System.String propertyName) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Void EnsureReflectionObject(System.Type objectType) { }
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000105
    public class ExpandoObjectConverter : JsonConverter
    {
        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadValue(Newtonsoft.Json.JsonReader reader) { }
        private System.Object ReadList(Newtonsoft.Json.JsonReader reader) { }
        private System.Object ReadObject(Newtonsoft.Json.JsonReader reader) { }
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Boolean get_CanWrite() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000106
    public class IsoDateTimeConverter : DateTimeConverterBase
    {
        // Fields
        private static System.String DefaultDateTimeFormat;        // 0x0
        private System.Globalization.DateTimeStyles _dateTimeStyles;        // 0x10
        private System.String _dateTimeFormat;        // 0x18
        private System.Globalization.CultureInfo _culture;        // 0x20

        // Methods
        private System.Globalization.DateTimeStyles get_DateTimeStyles() { }
        private System.Void set_DateTimeStyles(System.Globalization.DateTimeStyles value) { }
        private System.String get_DateTimeFormat() { }
        private System.Void set_DateTimeFormat(System.String value) { }
        private System.Globalization.CultureInfo get_Culture() { }
        private System.Void set_Culture(System.Globalization.CultureInfo value) { }
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000107
    public class JavaScriptDateTimeConverter : DateTimeConverterBase
    {
        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000108
    public class KeyValuePairConverter : JsonConverter
    {
        // Fields
        private static System.String KeyName;        // 0x0
        private static System.String ValueName;        // 0x0
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType;        // 0x0

        // Methods
        private Newtonsoft.Json.Utilities.ReflectionObject InitializeReflectionObject(System.Type t) { }
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000109
    public class RegexConverter : JsonConverter
    {
        // Fields
        private static System.String PatternName;        // 0x0
        private static System.String OptionsName;        // 0x0

        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Boolean HasFlag(System.Text.RegularExpressions.RegexOptions options, System.Text.RegularExpressions.RegexOptions flag) { }
        private System.Void WriteBson(Newtonsoft.Json.Bson.BsonWriter writer, System.Text.RegularExpressions.Regex regex) { }
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Text.RegularExpressions.Regex regex, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadRegexString(Newtonsoft.Json.JsonReader reader) { }
        private System.Text.RegularExpressions.Regex ReadRegexObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Boolean IsRegex(System.Type objectType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010A
    public class StringEnumConverter : JsonConverter
    {
        // Fields
        private Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField;        // 0x10
        private System.Boolean <AllowIntegerValues>k__BackingField;        // 0x18

        // Methods
        private System.Boolean get_CamelCaseText() { }
        private System.Void set_CamelCaseText(System.Boolean value) { }
        private Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy() { }
        private System.Void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy value) { }
        private System.Boolean get_AllowIntegerValues() { }
        private System.Void set_AllowIntegerValues(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean camelCaseText) { }
        private System.Void .ctor(Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.Boolean allowIntegerValues) { }
        private System.Void .ctor(System.Type namingStrategyType) { }
        private System.Void .ctor(System.Type namingStrategyType, System.Object[] namingStrategyParameters) { }
        private System.Void .ctor(System.Type namingStrategyType, System.Object[] namingStrategyParameters, System.Boolean allowIntegerValues) { }
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Boolean CanConvert(System.Type objectType) { }

    }

    // TypeToken: 0x200010B
    public class UnixDateTimeConverter : DateTimeConverterBase
    {
        // Fields
        private static readonly System.DateTime UnixEpoch;        // 0x0
        private System.Boolean <AllowPreEpoch>k__BackingField;        // 0x10

        // Methods
        private System.Boolean get_AllowPreEpoch() { }
        private System.Void set_AllowPreEpoch(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean allowPreEpoch) { }
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200010C
    public class VersionConverter : JsonConverter
    {
        // Methods
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Boolean CanConvert(System.Type objectType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010D
    public class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
    {
        // Fields
        private readonly System.Xml.XmlDocument _document;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XmlDocument document) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String data) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data) { }
        private Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName) { }
        private Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value) { }
        private Newtonsoft.Json.Converters.IXmlElement get_DocumentElement() { }

    }

    // TypeToken: 0x200010E
    public class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
    {
        // Fields
        private readonly System.Xml.XmlElement _element;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XmlElement element) { }
        private System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute) { }
        private System.String GetPrefixOfNamespace(System.String namespaceUri) { }
        private System.Boolean get_IsEmpty() { }

    }

    // TypeToken: 0x200010F
    public class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
    {
        // Fields
        private readonly System.Xml.XmlDeclaration _declaration;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XmlDeclaration declaration) { }
        private System.String get_Version() { }
        private System.String get_Encoding() { }
        private System.String get_Standalone() { }

    }

    // TypeToken: 0x2000110
    public class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
    {
        // Fields
        private readonly System.Xml.XmlDocumentType _documentType;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XmlDocumentType documentType) { }
        private System.String get_Name() { }
        private System.String get_System() { }
        private System.String get_Public() { }
        private System.String get_InternalSubset() { }
        private System.String get_LocalName() { }

    }

    // TypeToken: 0x2000111
    public class XmlNodeWrapper, IXmlNode
    {
        // Fields
        private readonly System.Xml.XmlNode _node;        // 0x10
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;        // 0x18
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.XmlNode node) { }
        private System.Object get_WrappedNode() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_LocalName() { }
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }
        private Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.XmlNode node) { }
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }
        private System.Boolean get_HasAttributes() { }
        private Newtonsoft.Json.Converters.IXmlNode get_ParentNode() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }
        private System.String get_NamespaceUri() { }

    }

    // TypeToken: 0x2000112
    public interface IXmlDocument : IXmlNode
    {
        // Methods
        private Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String text) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data) { }
        private Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName) { }
        private Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value) { }
        private Newtonsoft.Json.Converters.IXmlElement get_DocumentElement() { }

    }

    // TypeToken: 0x2000113
    public interface IXmlDeclaration : IXmlNode
    {
        // Methods
        private System.String get_Version() { }
        private System.String get_Encoding() { }
        private System.String get_Standalone() { }

    }

    // TypeToken: 0x2000114
    public interface IXmlDocumentType : IXmlNode
    {
        // Methods
        private System.String get_Name() { }
        private System.String get_System() { }
        private System.String get_Public() { }
        private System.String get_InternalSubset() { }

    }

    // TypeToken: 0x2000115
    public interface IXmlElement : IXmlNode
    {
        // Methods
        private System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute) { }
        private System.String GetPrefixOfNamespace(System.String namespaceUri) { }
        private System.Boolean get_IsEmpty() { }

    }

    // TypeToken: 0x2000116
    public interface IXmlNode
    {
        // Methods
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_LocalName() { }
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }
        private Newtonsoft.Json.Converters.IXmlNode get_ParentNode() { }
        private System.String get_Value() { }
        private Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }
        private System.String get_NamespaceUri() { }
        private System.Object get_WrappedNode() { }

    }

    // TypeToken: 0x2000117
    public class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
    {
        // Fields
        private readonly System.Xml.Linq.XDeclaration <Declaration>k__BackingField;        // 0x18

        // Methods
        private System.Xml.Linq.XDeclaration get_Declaration() { }
        private System.Void .ctor(System.Xml.Linq.XDeclaration declaration) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_Version() { }
        private System.String get_Encoding() { }
        private System.String get_Standalone() { }

    }

    // TypeToken: 0x2000118
    public class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
    {
        // Fields
        private readonly System.Xml.Linq.XDocumentType _documentType;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.Linq.XDocumentType documentType) { }
        private System.String get_Name() { }
        private System.String get_System() { }
        private System.String get_Public() { }
        private System.String get_InternalSubset() { }
        private System.String get_LocalName() { }

    }

    // TypeToken: 0x2000119
    public class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
    {
        // Methods
        private System.Xml.Linq.XDocument get_Document() { }
        private System.Void .ctor(System.Xml.Linq.XDocument document) { }
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }
        private System.Boolean get_HasChildNodes() { }
        private Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String text) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data) { }
        private Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName) { }
        private Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value) { }
        private Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value) { }
        private Newtonsoft.Json.Converters.IXmlElement get_DocumentElement() { }
        private Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }

    }

    // TypeToken: 0x200011A
    public class XTextWrapper : XObjectWrapper
    {
        // Methods
        private System.Xml.Linq.XText get_Text() { }
        private System.Void .ctor(System.Xml.Linq.XText text) { }
        private System.String get_Value() { }
        private Newtonsoft.Json.Converters.IXmlNode get_ParentNode() { }

    }

    // TypeToken: 0x200011B
    public class XCommentWrapper : XObjectWrapper
    {
        // Methods
        private System.Xml.Linq.XComment get_Text() { }
        private System.Void .ctor(System.Xml.Linq.XComment text) { }
        private System.String get_Value() { }
        private Newtonsoft.Json.Converters.IXmlNode get_ParentNode() { }

    }

    // TypeToken: 0x200011C
    public class XProcessingInstructionWrapper : XObjectWrapper
    {
        // Methods
        private System.Xml.Linq.XProcessingInstruction get_ProcessingInstruction() { }
        private System.Void .ctor(System.Xml.Linq.XProcessingInstruction processingInstruction) { }
        private System.String get_LocalName() { }
        private System.String get_Value() { }

    }

    // TypeToken: 0x200011D
    public class XContainerWrapper : XObjectWrapper
    {
        // Fields
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes;        // 0x18

        // Methods
        private System.Xml.Linq.XContainer get_Container() { }
        private System.Void .ctor(System.Xml.Linq.XContainer container) { }
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }
        private System.Boolean get_HasChildNodes() { }
        private Newtonsoft.Json.Converters.IXmlNode get_ParentNode() { }
        private Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.Linq.XObject node) { }
        private Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }

    }

    // TypeToken: 0x200011E
    public class XObjectWrapper, IXmlNode
    {
        // Fields
        private readonly System.Xml.Linq.XObject _xmlObject;        // 0x10

        // Methods
        private System.Void .ctor(System.Xml.Linq.XObject xmlObject) { }
        private System.Object get_WrappedNode() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_LocalName() { }
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }
        private Newtonsoft.Json.Converters.IXmlNode get_ParentNode() { }
        private System.String get_Value() { }
        private Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }
        private System.String get_NamespaceUri() { }

    }

    // TypeToken: 0x200011F
    public class XAttributeWrapper : XObjectWrapper
    {
        // Methods
        private System.Xml.Linq.XAttribute get_Attribute() { }
        private System.Void .ctor(System.Xml.Linq.XAttribute attribute) { }
        private System.String get_Value() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceUri() { }
        private Newtonsoft.Json.Converters.IXmlNode get_ParentNode() { }

    }

    // TypeToken: 0x2000120
    public class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
    {
        // Fields
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes;        // 0x20

        // Methods
        private System.Xml.Linq.XElement get_Element() { }
        private System.Void .ctor(System.Xml.Linq.XElement element) { }
        private System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute) { }
        private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }
        private System.Boolean HasImplicitNamespaceAttribute(System.String namespaceUri) { }
        private Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild) { }
        private System.String get_Value() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceUri() { }
        private System.String GetPrefixOfNamespace(System.String namespaceUri) { }
        private System.Boolean get_IsEmpty() { }

    }

    // TypeToken: 0x2000121
    public class XmlNodeConverter : JsonConverter
    {
        // Fields
        private static readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> EmptyChildNodes;        // 0x0
        private static System.String TextName;        // 0x0
        private static System.String CommentName;        // 0x0
        private static System.String CDataName;        // 0x0
        private static System.String WhitespaceName;        // 0x0
        private static System.String SignificantWhitespaceName;        // 0x0
        private static System.String DeclarationName;        // 0x0
        private static System.String JsonNamespaceUri;        // 0x0
        private System.String <DeserializeRootElementName>k__BackingField;        // 0x10
        private System.Boolean <WriteArrayAttribute>k__BackingField;        // 0x18
        private System.Boolean <OmitRootObject>k__BackingField;        // 0x19
        private System.Boolean <EncodeSpecialCharacters>k__BackingField;        // 0x1A

        // Methods
        private System.String get_DeserializeRootElementName() { }
        private System.Void set_DeserializeRootElementName(System.String value) { }
        private System.Boolean get_WriteArrayAttribute() { }
        private System.Void set_WriteArrayAttribute(System.Boolean value) { }
        private System.Boolean get_OmitRootObject() { }
        private System.Void set_OmitRootObject(System.Boolean value) { }
        private System.Boolean get_EncodeSpecialCharacters() { }
        private System.Void set_EncodeSpecialCharacters(System.Boolean value) { }
        private System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) { }
        private Newtonsoft.Json.Converters.IXmlNode WrapXml(System.Object value) { }
        private System.Void PushParentNamespaces(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager) { }
        private System.String ResolveFullName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager) { }
        private System.String GetPropertyName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager) { }
        private System.Boolean IsArray(Newtonsoft.Json.Converters.IXmlNode node) { }
        private System.Void SerializeGroupedNodes(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName) { }
        private System.Void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, System.String elementNames) { }
        private System.Void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName, Newtonsoft.Json.Converters.IXmlNode node, System.String elementNames) { }
        private System.Void SerializeNode(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName) { }
        private System.Boolean AllSameName(Newtonsoft.Json.Converters.IXmlNode node) { }
        private System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Void DeserializeValue(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, System.String propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode) { }
        private System.Void ReadElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName, System.Xml.XmlNamespaceManager manager) { }
        private System.Void CreateElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String elementName, System.Xml.XmlNamespaceManager manager, System.String elementPrefix, System.Collections.Generic.Dictionary<System.String,System.String> attributeNameValues) { }
        private System.Void AddAttribute(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName, System.String attributeName, System.Xml.XmlNamespaceManager manager, System.String attributePrefix) { }
        private System.String ConvertTokenToXmlValue(Newtonsoft.Json.JsonReader reader) { }
        private System.Void ReadArrayElements(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.String propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode, System.Xml.XmlNamespaceManager manager) { }
        private System.Void AddJsonArrayAttribute(Newtonsoft.Json.Converters.IXmlElement element, Newtonsoft.Json.Converters.IXmlDocument document) { }
        private System.Boolean ShouldReadInto(Newtonsoft.Json.JsonReader reader) { }
        private System.Collections.Generic.Dictionary<System.String,System.String> ReadAttributeElements(Newtonsoft.Json.JsonReader reader, System.Xml.XmlNamespaceManager manager) { }
        private System.Void CreateInstruction(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName) { }
        private System.Void CreateDocumentType(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode) { }
        private Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName, Newtonsoft.Json.Converters.IXmlDocument document, System.String elementPrefix, System.Xml.XmlNamespaceManager manager) { }
        private System.Void DeserializeNode(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, Newtonsoft.Json.Converters.IXmlNode currentNode) { }
        private System.Boolean IsNamespaceAttribute(System.String attributeName, System.String& prefix) { }
        private System.Boolean ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c) { }
        private System.Boolean CanConvert(System.Type valueType) { }
        private System.Boolean IsXObject(System.Type valueType) { }
        private System.Boolean IsXmlNode(System.Type valueType) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace Newtonsoft.Json.Linq
{

    // TypeToken: 0x20000DE
    public struct CommentHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Linq.CommentHandling Ignore;        // 0x0
        public static Newtonsoft.Json.Linq.CommentHandling Load;        // 0x0

    }

    // TypeToken: 0x20000DF
    public struct DuplicatePropertyNameHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Linq.DuplicatePropertyNameHandling Replace;        // 0x0
        public static Newtonsoft.Json.Linq.DuplicatePropertyNameHandling Ignore;        // 0x0
        public static Newtonsoft.Json.Linq.DuplicatePropertyNameHandling Error;        // 0x0

    }

    // TypeToken: 0x20000E0
    public class Extensions
    {
        // Methods
        private U Value(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> value) { }
        private U Value(System.Collections.Generic.IEnumerable<T> value) { }
        private U Convert(T token) { }

    }

    // TypeToken: 0x20000E1
    public class JArray : JContainer, IList`1, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values;        // 0x50

        // Methods
        private System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }
        private Newtonsoft.Json.Linq.JTokenType get_Type() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Newtonsoft.Json.Linq.JArray other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private System.Void .ctor(System.Object content) { }
        private Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        private System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        private Newtonsoft.Json.Linq.JToken get_Item(System.Object key) { }
        private Newtonsoft.Json.Linq.JToken get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, Newtonsoft.Json.Linq.JToken value) { }
        private System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item) { }
        private System.Int32 IndexOf(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }
        private System.Void Add(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean Remove(Newtonsoft.Json.Linq.JToken item) { }

    }

    // TypeToken: 0x20000E2
    public class JConstructor : JContainer
    {
        // Fields
        private System.String _name;        // 0x50
        private readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values;        // 0x58

        // Methods
        private System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }
        private System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item) { }
        private System.String get_Name() { }
        private Newtonsoft.Json.Linq.JTokenType get_Type() { }
        private System.Void .ctor(Newtonsoft.Json.Linq.JConstructor other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private System.Void .ctor(System.String name) { }
        private Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        private Newtonsoft.Json.Linq.JToken get_Item(System.Object key) { }
        private Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }

    }

    // TypeToken: 0x20000E3
    public class JContainer : JToken, IList`1, ICollection`1, IEnumerable`1, IEnumerable, IBindingList, ICollection, IList, INotifyCollectionChanged
    {
        // Fields
        private System.ComponentModel.ListChangedEventHandler _listChanged;        // 0x30
        private System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;        // 0x38
        private System.Object _syncRoot;        // 0x40
        private System.Boolean _busy;        // 0x48

        // Methods
        private System.Void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value) { }
        private System.Void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value) { }
        private System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Newtonsoft.Json.Linq.JContainer other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private System.Void CheckReentrancy() { }
        private System.Void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
        private System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
        private System.Boolean get_HasValues() { }
        private Newtonsoft.Json.Linq.JToken get_First() { }
        private Newtonsoft.Json.Linq.JToken get_Last() { }
        private Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }
        private System.Boolean IsMultiContent(System.Object content) { }
        private Newtonsoft.Json.Linq.JToken EnsureParentToken(Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations) { }
        private System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item) { }
        private System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations) { }
        private System.Void RemoveItemAt(System.Int32 index) { }
        private System.Boolean RemoveItem(Newtonsoft.Json.Linq.JToken item) { }
        private Newtonsoft.Json.Linq.JToken GetItem(System.Int32 index) { }
        private System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        private System.Void ClearItems() { }
        private System.Void ReplaceItem(Newtonsoft.Json.Linq.JToken existing, Newtonsoft.Json.Linq.JToken replacement) { }
        private System.Boolean ContainsItem(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void CopyItemsTo(System.Array array, System.Int32 arrayIndex) { }
        private System.Boolean IsTokenUnchanged(Newtonsoft.Json.Linq.JToken currentValue, Newtonsoft.Json.Linq.JToken newValue) { }
        private System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing) { }
        private System.Void Add(System.Object content) { }
        private System.Boolean TryAdd(System.Object content) { }
        private System.Void AddAndSkipParentCheck(Newtonsoft.Json.Linq.JToken token) { }
        private System.Boolean TryAddInternal(System.Int32 index, System.Object content, System.Boolean skipParentCheck, System.Boolean copyAnnotations) { }
        private Newtonsoft.Json.Linq.JToken CreateFromContent(System.Object content) { }
        private System.Void RemoveAll() { }
        private System.Void ReadTokenFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings options) { }
        private System.Void ReadContentFrom(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        private Newtonsoft.Json.Linq.JProperty ReadProperty(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings, Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JContainer parent) { }
        private System.Int32 System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        private System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(System.Int32 index) { }
        private Newtonsoft.Json.Linq.JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(System.Int32 index) { }
        private System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(System.Int32 index, Newtonsoft.Json.Linq.JToken value) { }
        private System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }
        private System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex) { }
        private System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }
        private System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item) { }
        private Newtonsoft.Json.Linq.JToken EnsureValue(System.Object value) { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Void System.Collections.IList.Clear() { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Boolean System.Collections.IList.get_IsFixedSize() { }
        private System.Boolean System.Collections.IList.get_IsReadOnly() { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Void System.Collections.IList.RemoveAt(System.Int32 index) { }
        private System.Object System.Collections.IList.get_Item(System.Int32 index) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Int32 get_Count() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }

    }

    // TypeToken: 0x20000E4
    public struct JEnumerable`1, IEnumerable`1, IEnumerable, IEquatable`1
    {
        // Fields
        public static readonly Newtonsoft.Json.Linq.JEnumerable<T> Empty;        // 0x0
        private readonly System.Collections.Generic.IEnumerable<T> _enumerable;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEnumerable<T> enumerable) { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean Equals(Newtonsoft.Json.Linq.JEnumerable<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E5
    public class JObject : JContainer, IDictionary`2, ICollection`1, IEnumerable`1, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor
    {
        // Fields
        private readonly Newtonsoft.Json.Linq.JPropertyKeyedCollection _properties;        // 0x50
        private System.ComponentModel.PropertyChangedEventHandler PropertyChanged;        // 0x58
        private System.ComponentModel.PropertyChangingEventHandler PropertyChanging;        // 0x60

        // Methods
        private System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }
        private System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(Newtonsoft.Json.Linq.JObject other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item) { }
        private System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations) { }
        private System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing) { }
        private System.Void InternalPropertyChanged(Newtonsoft.Json.Linq.JProperty childProperty) { }
        private System.Void InternalPropertyChanging(Newtonsoft.Json.Linq.JProperty childProperty) { }
        private Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private Newtonsoft.Json.Linq.JTokenType get_Type() { }
        private System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties() { }
        private Newtonsoft.Json.Linq.JProperty Property(System.String name, System.StringComparison comparison) { }
        private Newtonsoft.Json.Linq.JToken get_Item(System.Object key) { }
        private Newtonsoft.Json.Linq.JToken get_Item(System.String propertyName) { }
        private System.Void set_Item(System.String propertyName, Newtonsoft.Json.Linq.JToken value) { }
        private Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        private Newtonsoft.Json.Linq.JObject Parse(System.String json) { }
        private Newtonsoft.Json.Linq.JObject Parse(System.String json, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        private Newtonsoft.Json.Linq.JObject FromObject(System.Object o) { }
        private Newtonsoft.Json.Linq.JObject FromObject(System.Object o, Newtonsoft.Json.JsonSerializer jsonSerializer) { }
        private System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        private Newtonsoft.Json.Linq.JToken GetValue(System.String propertyName) { }
        private Newtonsoft.Json.Linq.JToken GetValue(System.String propertyName, System.StringComparison comparison) { }
        private System.Void Add(System.String propertyName, Newtonsoft.Json.Linq.JToken value) { }
        private System.Boolean ContainsKey(System.String propertyName) { }
        private System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }
        private System.Boolean Remove(System.String propertyName) { }
        private System.Boolean TryGetValue(System.String propertyName, Newtonsoft.Json.Linq.JToken& value) { }
        private System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }
        private System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }
        private System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }
        private System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>[] array, System.Int32 arrayIndex) { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>> GetEnumerator() { }
        private System.Void OnPropertyChanged(System.String propertyName) { }
        private System.Void OnPropertyChanging(System.String propertyName) { }
        private System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }
        private System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { }
        private System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }
        private System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }
        private System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { }
        private System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { }

    }

    // TypeToken: 0x20000E9
    public class JProperty : JContainer
    {
        // Fields
        private readonly Newtonsoft.Json.Linq.JProperty.JPropertyList _content;        // 0x50
        private readonly System.String _name;        // 0x58

        // Methods
        private System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }
        private System.String get_Name() { }
        private Newtonsoft.Json.Linq.JToken get_Value() { }
        private System.Void set_Value(Newtonsoft.Json.Linq.JToken value) { }
        private System.Void .ctor(Newtonsoft.Json.Linq.JProperty other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private Newtonsoft.Json.Linq.JToken GetItem(System.Int32 index) { }
        private System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        private System.Boolean RemoveItem(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void RemoveItemAt(System.Int32 index) { }
        private System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item) { }
        private System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations) { }
        private System.Boolean ContainsItem(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void ClearItems() { }
        private Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private Newtonsoft.Json.Linq.JTokenType get_Type() { }
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(System.String name, System.Object content) { }
        private System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        private Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }

    }

    // TypeToken: 0x20000EC
    public class JPropertyDescriptor : PropertyDescriptor
    {
        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Boolean CanResetValue(System.Object component) { }
        private System.Object GetValue(System.Object component) { }
        private System.Void ResetValue(System.Object component) { }
        private System.Void SetValue(System.Object component, System.Object value) { }
        private System.Boolean ShouldSerializeValue(System.Object component) { }
        private System.Type get_ComponentType() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Type get_PropertyType() { }
        private System.Int32 get_NameHashCode() { }

    }

    // TypeToken: 0x20000ED
    public class JPropertyKeyedCollection : Collection`1
    {
        // Fields
        private static readonly System.Collections.Generic.IEqualityComparer<System.String> Comparer;        // 0x0
        private System.Collections.Generic.Dictionary<System.String,Newtonsoft.Json.Linq.JToken> _dictionary;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void AddKey(System.String key, Newtonsoft.Json.Linq.JToken item) { }
        private System.Void ClearItems() { }
        private System.Boolean Contains(System.String key) { }
        private System.Void EnsureDictionary() { }
        private System.String GetKeyForItem(Newtonsoft.Json.Linq.JToken item) { }
        private System.Void InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        private System.Void RemoveItem(System.Int32 index) { }
        private System.Void RemoveKey(System.String key) { }
        private System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item) { }
        private System.Boolean TryGetValue(System.String key, Newtonsoft.Json.Linq.JToken& value) { }
        private System.Collections.Generic.ICollection<System.String> get_Keys() { }
        private System.Int32 IndexOfReference(Newtonsoft.Json.Linq.JToken t) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000EE
    public class JRaw : JValue
    {
        // Methods
        private System.Void .ctor(Newtonsoft.Json.Linq.JRaw other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private System.Void .ctor(System.Object rawJson) { }
        private Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader reader) { }
        private Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }

    }

    // TypeToken: 0x20000EF
    public class JsonCloneSettings
    {
        // Fields
        private static readonly Newtonsoft.Json.Linq.JsonCloneSettings SkipCopyAnnotations;        // 0x0
        private System.Boolean <CopyAnnotations>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_CopyAnnotations() { }
        private System.Void set_CopyAnnotations(System.Boolean value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000F0
    public class JsonLoadSettings
    {
        // Fields
        private Newtonsoft.Json.Linq.CommentHandling _commentHandling;        // 0x10
        private Newtonsoft.Json.Linq.LineInfoHandling _lineInfoHandling;        // 0x14
        private Newtonsoft.Json.Linq.DuplicatePropertyNameHandling _duplicatePropertyNameHandling;        // 0x18

        // Methods
        private Newtonsoft.Json.Linq.CommentHandling get_CommentHandling() { }
        private Newtonsoft.Json.Linq.LineInfoHandling get_LineInfoHandling() { }
        private Newtonsoft.Json.Linq.DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }

    }

    // TypeToken: 0x20000F1
    public class JToken, IEnumerable`1, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
    {
        // Fields
        private Newtonsoft.Json.Linq.JContainer _parent;        // 0x10
        private Newtonsoft.Json.Linq.JToken _previous;        // 0x18
        private Newtonsoft.Json.Linq.JToken _next;        // 0x20
        private System.Object _annotations;        // 0x28
        private static readonly Newtonsoft.Json.Linq.JTokenType[] BooleanTypes;        // 0x0
        private static readonly Newtonsoft.Json.Linq.JTokenType[] NumberTypes;        // 0x8
        private static readonly Newtonsoft.Json.Linq.JTokenType[] BigIntegerTypes;        // 0x10
        private static readonly Newtonsoft.Json.Linq.JTokenType[] StringTypes;        // 0x18
        private static readonly Newtonsoft.Json.Linq.JTokenType[] GuidTypes;        // 0x20
        private static readonly Newtonsoft.Json.Linq.JTokenType[] TimeSpanTypes;        // 0x28
        private static readonly Newtonsoft.Json.Linq.JTokenType[] UriTypes;        // 0x30
        private static readonly Newtonsoft.Json.Linq.JTokenType[] CharTypes;        // 0x38
        private static readonly Newtonsoft.Json.Linq.JTokenType[] DateTimeTypes;        // 0x40
        private static readonly Newtonsoft.Json.Linq.JTokenType[] BytesTypes;        // 0x48

        // Methods
        private Newtonsoft.Json.Linq.JContainer get_Parent() { }
        private System.Void set_Parent(Newtonsoft.Json.Linq.JContainer value) { }
        private Newtonsoft.Json.Linq.JToken get_Root() { }
        private Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private Newtonsoft.Json.Linq.JTokenType get_Type() { }
        private System.Boolean get_HasValues() { }
        private Newtonsoft.Json.Linq.JToken get_Next() { }
        private System.Void set_Next(Newtonsoft.Json.Linq.JToken value) { }
        private Newtonsoft.Json.Linq.JToken get_Previous() { }
        private System.Void set_Previous(Newtonsoft.Json.Linq.JToken value) { }
        private System.String get_Path() { }
        private System.Void .ctor() { }
        private Newtonsoft.Json.Linq.JToken get_Item(System.Object key) { }
        private Newtonsoft.Json.Linq.JToken get_First() { }
        private Newtonsoft.Json.Linq.JToken get_Last() { }
        private Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }
        private System.Void Remove() { }
        private System.Void Replace(Newtonsoft.Json.Linq.JToken value) { }
        private System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        private System.String ToString() { }
        private System.String ToString(Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters) { }
        private Newtonsoft.Json.Linq.JValue EnsureValue(Newtonsoft.Json.Linq.JToken value) { }
        private System.String GetType(Newtonsoft.Json.Linq.JToken token) { }
        private System.Boolean ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JTokenType[] validTypes, System.Boolean nullable) { }
        private System.Boolean op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.Boolean> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Int64 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.DateTime> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.DateTimeOffset> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.Decimal> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.Double> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.Char> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Int32 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Int16 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.UInt16 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Char op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Byte op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.SByte op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.Int32> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.Int16> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.UInt16> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.Byte> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.SByte> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.Int64> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.Single> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Decimal op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.UInt32> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.UInt64> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Double op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Single op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.String op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.UInt32 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.UInt64 op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.Guid> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.TimeSpan> op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken value) { }
        private System.Numerics.BigInteger ToBigInteger(Newtonsoft.Json.Linq.JToken value) { }
        private System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(Newtonsoft.Json.Linq.JToken value) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }
        private Newtonsoft.Json.JsonReader CreateReader() { }
        private Newtonsoft.Json.Linq.JToken FromObjectInternal(System.Object o, Newtonsoft.Json.JsonSerializer jsonSerializer) { }
        private Newtonsoft.Json.Linq.JToken FromObject(System.Object o) { }
        private T ToObject() { }
        private System.Object ToObject(System.Type objectType) { }
        private System.Object ToObject(System.Type objectType, Newtonsoft.Json.JsonSerializer jsonSerializer) { }
        private Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader) { }
        private Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        private Newtonsoft.Json.Linq.JToken Parse(System.String json) { }
        private Newtonsoft.Json.Linq.JToken Parse(System.String json, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        private Newtonsoft.Json.Linq.JToken Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        private System.Void SetLineInfo(Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JsonLoadSettings settings) { }
        private System.Void SetLineInfo(System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }
        private System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }
        private System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }
        private System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { }
        private System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter) { }
        private System.Object System.ICloneable.Clone() { }
        private Newtonsoft.Json.Linq.JToken DeepClone() { }
        private System.Void AddAnnotation(System.Object annotation) { }
        private T Annotation() { }
        private System.Void CopyAnnotations(Newtonsoft.Json.Linq.JToken target, Newtonsoft.Json.Linq.JToken source) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000F3
    public class JTokenReader : JsonReader, IJsonLineInfo
    {
        // Fields
        private readonly Newtonsoft.Json.Linq.JToken _root;        // 0x78
        private System.String _initialPath;        // 0x80
        private Newtonsoft.Json.Linq.JToken _parent;        // 0x88
        private Newtonsoft.Json.Linq.JToken _current;        // 0x90

        // Methods
        private Newtonsoft.Json.Linq.JToken get_CurrentToken() { }
        private System.Void .ctor(Newtonsoft.Json.Linq.JToken token) { }
        private System.Boolean Read() { }
        private System.Boolean ReadOver(Newtonsoft.Json.Linq.JToken t) { }
        private System.Boolean ReadToEnd() { }
        private System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(Newtonsoft.Json.Linq.JContainer c) { }
        private System.Boolean ReadInto(Newtonsoft.Json.Linq.JContainer c) { }
        private System.Boolean SetEnd(Newtonsoft.Json.Linq.JContainer c) { }
        private System.Void SetToken(Newtonsoft.Json.Linq.JToken token) { }
        private System.String SafeToString(System.Object value) { }
        private System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }
        private System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }
        private System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }
        private System.String get_Path() { }

    }

    // TypeToken: 0x20000F4
    public struct JTokenType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Linq.JTokenType None;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Object;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Array;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Constructor;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Property;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Comment;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Integer;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Float;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType String;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Boolean;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Null;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Undefined;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Date;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Raw;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Bytes;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Guid;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType Uri;        // 0x0
        public static Newtonsoft.Json.Linq.JTokenType TimeSpan;        // 0x0

    }

    // TypeToken: 0x20000F5
    public class JTokenWriter : JsonWriter
    {
        // Fields
        private Newtonsoft.Json.Linq.JContainer _token;        // 0x60
        private Newtonsoft.Json.Linq.JContainer _parent;        // 0x68
        private Newtonsoft.Json.Linq.JValue _value;        // 0x70
        private Newtonsoft.Json.Linq.JToken _current;        // 0x78

        // Methods
        private Newtonsoft.Json.Linq.JToken get_Token() { }
        private System.Void .ctor() { }
        private System.Void Close() { }
        private System.Void WriteStartObject() { }
        private System.Void AddParent(Newtonsoft.Json.Linq.JContainer container) { }
        private System.Void RemoveParent() { }
        private System.Void WriteStartArray() { }
        private System.Void WriteStartConstructor(System.String name) { }
        private System.Void WriteEnd(Newtonsoft.Json.JsonToken token) { }
        private System.Void WritePropertyName(System.String name) { }
        private System.Void AddRawValue(System.Object value, Newtonsoft.Json.Linq.JTokenType type, Newtonsoft.Json.JsonToken token) { }
        private System.Void AddJValue(Newtonsoft.Json.Linq.JValue value, Newtonsoft.Json.JsonToken token) { }
        private System.Void WriteValue(System.Object value) { }
        private System.Void WriteNull() { }
        private System.Void WriteUndefined() { }
        private System.Void WriteRaw(System.String json) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void WriteValue(System.Int32 value) { }
        private System.Void WriteValue(System.UInt32 value) { }
        private System.Void WriteValue(System.Int64 value) { }
        private System.Void WriteValue(System.UInt64 value) { }
        private System.Void WriteValue(System.Single value) { }
        private System.Void WriteValue(System.Double value) { }
        private System.Void WriteValue(System.Boolean value) { }
        private System.Void WriteValue(System.Int16 value) { }
        private System.Void WriteValue(System.UInt16 value) { }
        private System.Void WriteValue(System.Char value) { }
        private System.Void WriteValue(System.Byte value) { }
        private System.Void WriteValue(System.SByte value) { }
        private System.Void WriteValue(System.Decimal value) { }
        private System.Void WriteValue(System.DateTime value) { }
        private System.Void WriteValue(System.DateTimeOffset value) { }
        private System.Void WriteValue(System.Byte[] value) { }
        private System.Void WriteValue(System.TimeSpan value) { }
        private System.Void WriteValue(System.Guid value) { }
        private System.Void WriteValue(System.Uri value) { }
        private System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Boolean writeDateConstructorAsDate, System.Boolean writeComments) { }

    }

    // TypeToken: 0x20000F6
    public class JValue : JToken, IEquatable`1, IFormattable, IComparable, IComparable`1, IConvertible
    {
        // Fields
        private Newtonsoft.Json.Linq.JTokenType _valueType;        // 0x30
        private System.Object _value;        // 0x38

        // Methods
        private System.Void .ctor(System.Object value, Newtonsoft.Json.Linq.JTokenType type) { }
        private System.Void .ctor(Newtonsoft.Json.Linq.JValue other, Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private System.Void .ctor(System.Int64 value) { }
        private System.Void .ctor(System.Decimal value) { }
        private System.Void .ctor(System.UInt64 value) { }
        private System.Void .ctor(System.Double value) { }
        private System.Void .ctor(System.Single value) { }
        private System.Void .ctor(System.DateTime value) { }
        private System.Void .ctor(System.DateTimeOffset value) { }
        private System.Void .ctor(System.Boolean value) { }
        private System.Void .ctor(System.String value) { }
        private System.Void .ctor(System.Guid value) { }
        private System.Void .ctor(System.Uri value) { }
        private System.Void .ctor(System.TimeSpan value) { }
        private System.Void .ctor(System.Object value) { }
        private System.Boolean get_HasValues() { }
        private System.Int32 CompareBigInteger(System.Numerics.BigInteger i1, System.Object i2) { }
        private System.Int32 Compare(Newtonsoft.Json.Linq.JTokenType valueType, System.Object objA, System.Object objB) { }
        private System.Int32 CompareFloat(System.Object objA, System.Object objB) { }
        private System.Boolean Operation(System.Linq.Expressions.ExpressionType operation, System.Object objA, System.Object objB, System.Object& result) { }
        private Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings) { }
        private Newtonsoft.Json.Linq.JValue CreateComment(System.String value) { }
        private Newtonsoft.Json.Linq.JValue CreateNull() { }
        private Newtonsoft.Json.Linq.JValue CreateUndefined() { }
        private Newtonsoft.Json.Linq.JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, System.Object value) { }
        private Newtonsoft.Json.Linq.JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current) { }
        private Newtonsoft.Json.Linq.JTokenType get_Type() { }
        private System.Object get_Value() { }
        private System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters) { }
        private System.Boolean ValuesEquals(Newtonsoft.Json.Linq.JValue v1, Newtonsoft.Json.Linq.JValue v2) { }
        private System.Boolean Equals(Newtonsoft.Json.Linq.JValue other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.String ToString(System.IFormatProvider formatProvider) { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { }
        private System.Int32 System.IComparable.CompareTo(System.Object obj) { }
        private System.Int32 CompareTo(Newtonsoft.Json.Linq.JValue obj) { }
        private System.TypeCode System.IConvertible.GetTypeCode() { }
        private System.Boolean System.IConvertible.ToBoolean(System.IFormatProvider provider) { }
        private System.Char System.IConvertible.ToChar(System.IFormatProvider provider) { }
        private System.SByte System.IConvertible.ToSByte(System.IFormatProvider provider) { }
        private System.Byte System.IConvertible.ToByte(System.IFormatProvider provider) { }
        private System.Int16 System.IConvertible.ToInt16(System.IFormatProvider provider) { }
        private System.UInt16 System.IConvertible.ToUInt16(System.IFormatProvider provider) { }
        private System.Int32 System.IConvertible.ToInt32(System.IFormatProvider provider) { }
        private System.UInt32 System.IConvertible.ToUInt32(System.IFormatProvider provider) { }
        private System.Int64 System.IConvertible.ToInt64(System.IFormatProvider provider) { }
        private System.UInt64 System.IConvertible.ToUInt64(System.IFormatProvider provider) { }
        private System.Single System.IConvertible.ToSingle(System.IFormatProvider provider) { }
        private System.Double System.IConvertible.ToDouble(System.IFormatProvider provider) { }
        private System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { }
        private System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { }
        private System.Object System.IConvertible.ToType(System.Type conversionType, System.IFormatProvider provider) { }

    }

    // TypeToken: 0x20000F8
    public struct LineInfoHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Linq.LineInfoHandling Ignore;        // 0x0
        public static Newtonsoft.Json.Linq.LineInfoHandling Load;        // 0x0

    }

}

namespace Newtonsoft.Json.Serialization
{

    // TypeToken: 0x200009C
    public class CachedAttributeGetter`1
    {
        // Fields
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Object,T> TypeAttributeCache;        // 0x0

        // Methods
        private T GetAttribute(System.Object type) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009D
    public class CamelCaseNamingStrategy : NamingStrategy
    {
        // Methods
        private System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames) { }
        private System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames) { }
        private System.Void .ctor() { }
        private System.String ResolvePropertyName(System.String name) { }

    }

    // TypeToken: 0x200009E
    public class DefaultContractResolver, IContractResolver
    {
        // Fields
        private static readonly Newtonsoft.Json.Serialization.IContractResolver _instance;        // 0x0
        private static readonly System.String[] BlacklistedTypeNames;        // 0x8
        private static readonly Newtonsoft.Json.JsonConverter[] BuiltInConverters;        // 0x10
        private readonly Newtonsoft.Json.DefaultJsonNameTable _nameTable;        // 0x10
        private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Serialization.JsonContract> _contractCache;        // 0x18
        private System.Reflection.BindingFlags <DefaultMembersSearchFlags>k__BackingField;        // 0x20
        private System.Boolean <SerializeCompilerGeneratedMembers>k__BackingField;        // 0x24
        private System.Boolean <IgnoreSerializableInterface>k__BackingField;        // 0x25
        private System.Boolean <IgnoreSerializableAttribute>k__BackingField;        // 0x26
        private System.Boolean <IgnoreIsSpecifiedMembers>k__BackingField;        // 0x27
        private System.Boolean <IgnoreShouldSerializeMembers>k__BackingField;        // 0x28
        private Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField;        // 0x30

        // Methods
        private Newtonsoft.Json.Serialization.IContractResolver get_Instance() { }
        private System.Reflection.BindingFlags get_DefaultMembersSearchFlags() { }
        private System.Void set_DefaultMembersSearchFlags(System.Reflection.BindingFlags value) { }
        private System.Boolean get_SerializeCompilerGeneratedMembers() { }
        private System.Boolean get_IgnoreSerializableInterface() { }
        private System.Boolean get_IgnoreSerializableAttribute() { }
        private System.Void set_IgnoreSerializableAttribute(System.Boolean value) { }
        private System.Boolean get_IgnoreIsSpecifiedMembers() { }
        private System.Boolean get_IgnoreShouldSerializeMembers() { }
        private Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy() { }
        private System.Void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy value) { }
        private System.Void .ctor() { }
        private Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type) { }
        private System.Boolean FilterMembers(System.Reflection.MemberInfo member) { }
        private System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType) { }
        private System.Boolean ShouldSerializeEntityMember(System.Reflection.MemberInfo memberInfo) { }
        private Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(System.Type objectType) { }
        private System.Void ThrowUnableToSerializeError(System.Object o, System.Runtime.Serialization.StreamingContext context) { }
        private System.Reflection.MemberInfo GetExtensionDataMemberForType(System.Type type) { }
        private System.Void SetExtensionDataDelegates(Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Reflection.MemberInfo member) { }
        private System.Reflection.ConstructorInfo GetAttributeConstructor(System.Type objectType) { }
        private System.Reflection.ConstructorInfo GetImmutableConstructor(System.Type objectType, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties) { }
        private System.Reflection.ConstructorInfo GetParameterizedConstructor(System.Type objectType) { }
        private System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties) { }
        private Newtonsoft.Json.Serialization.JsonProperty MatchProperty(Newtonsoft.Json.Serialization.JsonPropertyCollection properties, System.String name, System.Type type) { }
        private Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo) { }
        private Newtonsoft.Json.JsonConverter ResolveContractConverter(System.Type objectType) { }
        private System.Func<System.Object> GetDefaultCreator(System.Type createdType) { }
        private System.Void InitializeContract(Newtonsoft.Json.Serialization.JsonContract contract) { }
        private System.Void ResolveCallbackMethods(Newtonsoft.Json.Serialization.JsonContract contract, System.Type t) { }
        private System.Void GetCallbackMethodsForType(System.Type type, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback>& onError) { }
        private System.Boolean IsConcurrentOrObservableCollection(System.Type t) { }
        private System.Boolean ShouldSkipDeserialized(System.Type t) { }
        private System.Boolean ShouldSkipSerializing(System.Type t) { }
        private System.Collections.Generic.List<System.Type> GetClassHierarchyForType(System.Type type) { }
        private Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(System.Type objectType) { }
        private Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(System.Type objectType) { }
        private Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType) { }
        private Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(System.Type objectType) { }
        private Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(System.Type objectType) { }
        private Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(System.Type objectType) { }
        private Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(System.Type objectType) { }
        private Newtonsoft.Json.Serialization.JsonContract CreateContract(System.Type objectType) { }
        private System.Boolean IsJsonPrimitiveType(System.Type t) { }
        private System.Boolean IsIConvertible(System.Type t) { }
        private System.Boolean CanConvertToString(System.Type type) { }
        private System.Boolean IsValidCallback(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Type attributeType, System.Reflection.MethodInfo currentCallback, System.Type& prevAttributeType) { }
        private System.String GetClrTypeFullName(System.Type type) { }
        private System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, Newtonsoft.Json.MemberSerialization memberSerialization) { }
        private Newtonsoft.Json.DefaultJsonNameTable GetNameTable() { }
        private Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member) { }
        private Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization) { }
        private System.Void SetPropertySettingsFromAttributes(Newtonsoft.Json.Serialization.JsonProperty property, System.Object attributeProvider, System.String name, System.Type declaringType, Newtonsoft.Json.MemberSerialization memberSerialization, System.Boolean& allowNonPublicAccess) { }
        private System.Predicate<System.Object> CreateShouldSerializeTest(System.Reflection.MemberInfo member) { }
        private System.Void SetIsSpecifiedActions(Newtonsoft.Json.Serialization.JsonProperty property, System.Reflection.MemberInfo member, System.Boolean allowNonPublicAccess) { }
        private System.String ResolvePropertyName(System.String propertyName) { }
        private System.String ResolveExtensionDataName(System.String extensionDataName) { }
        private System.String ResolveDictionaryKey(System.String dictionaryKey) { }
        private System.String GetResolvedPropertyName(System.String propertyName) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AA
    public class DefaultNamingStrategy : NamingStrategy
    {
        // Methods
        private System.String ResolvePropertyName(System.String name) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AB
    public class DefaultReferenceResolver, IReferenceResolver
    {
        // Fields
        private System.Int32 _referenceCount;        // 0x10

        // Methods
        private Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> GetMappings(System.Object context) { }
        private System.Object ResolveReference(System.Object context, System.String reference) { }
        private System.String GetReference(System.Object context, System.Object value) { }
        private System.Void AddReference(System.Object context, System.String reference, System.Object value) { }
        private System.Boolean IsReferenced(System.Object context, System.Object value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AC
    public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder
    {
        // Fields
        private static readonly Newtonsoft.Json.Serialization.DefaultSerializationBinder Instance;        // 0x0
        private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String>,System.Type> _typeCache;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }
        private System.Type GetGenericTypeFromTypeName(System.String typeName, System.Reflection.Assembly assembly) { }
        private System.Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }
        private System.Type BindToType(System.String assemblyName, System.String typeName) { }
        private System.Void BindToName(System.Type serializedType, System.String& assemblyName, System.String& typeName) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AD
    public class ErrorContext
    {
        // Fields
        private System.Boolean <Traced>k__BackingField;        // 0x10
        private readonly System.Exception <Error>k__BackingField;        // 0x18
        private readonly System.Object <OriginalObject>k__BackingField;        // 0x20
        private readonly System.Object <Member>k__BackingField;        // 0x28
        private readonly System.String <Path>k__BackingField;        // 0x30
        private System.Boolean <Handled>k__BackingField;        // 0x38

        // Methods
        private System.Void .ctor(System.Object originalObject, System.Object member, System.String path, System.Exception error) { }
        private System.Boolean get_Traced() { }
        private System.Void set_Traced(System.Boolean value) { }
        private System.Exception get_Error() { }
        private System.Boolean get_Handled() { }

    }

    // TypeToken: 0x20000AE
    public class ErrorEventArgs : EventArgs
    {
        // Fields
        private readonly System.Object <CurrentObject>k__BackingField;        // 0x10
        private readonly Newtonsoft.Json.Serialization.ErrorContext <ErrorContext>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext) { }

    }

    // TypeToken: 0x20000AF
    public interface IAttributeProvider
    {
    }

    // TypeToken: 0x20000B0
    public interface IContractResolver
    {
        // Methods
        private Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type) { }

    }

    // TypeToken: 0x20000B1
    public interface IReferenceResolver
    {
        // Methods
        private System.Object ResolveReference(System.Object context, System.String reference) { }
        private System.String GetReference(System.Object context, System.Object value) { }
        private System.Boolean IsReferenced(System.Object context, System.Object value) { }
        private System.Void AddReference(System.Object context, System.String reference, System.Object value) { }

    }

    // TypeToken: 0x20000B2
    public interface ISerializationBinder
    {
        // Methods
        private System.Type BindToType(System.String assemblyName, System.String typeName) { }
        private System.Void BindToName(System.Type serializedType, System.String& assemblyName, System.String& typeName) { }

    }

    // TypeToken: 0x20000B3
    public interface ITraceWriter
    {
        // Methods
        private System.Diagnostics.TraceLevel get_LevelFilter() { }
        private System.Void Trace(System.Diagnostics.TraceLevel level, System.String message, System.Exception ex) { }

    }

    // TypeToken: 0x20000B4
    public interface IValueProvider
    {
        // Methods
        private System.Void SetValue(System.Object target, System.Object value) { }
        private System.Object GetValue(System.Object target) { }

    }

    // TypeToken: 0x20000B5
    public class JsonArrayContract : JsonContainerContract
    {
        // Fields
        private readonly System.Type <CollectionItemType>k__BackingField;        // 0xC0
        private readonly System.Boolean <IsMultidimensionalArray>k__BackingField;        // 0xC8
        private readonly System.Type _genericCollectionDefinitionType;        // 0xD0
        private System.Type _genericWrapperType;        // 0xD8
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _genericWrapperCreator;        // 0xE0
        private System.Func<System.Object> _genericTemporaryCollectionCreator;        // 0xE8
        private readonly System.Boolean <IsArray>k__BackingField;        // 0xF0
        private readonly System.Boolean <ShouldCreateWrapper>k__BackingField;        // 0xF1
        private System.Boolean <CanDeserialize>k__BackingField;        // 0xF2
        private readonly System.Reflection.ConstructorInfo _parameterizedConstructor;        // 0xF8
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _parameterizedCreator;        // 0x100
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _overrideCreator;        // 0x108
        private System.Boolean <HasParameterizedCreator>k__BackingField;        // 0x110

        // Methods
        private System.Type get_CollectionItemType() { }
        private System.Boolean get_IsMultidimensionalArray() { }
        private System.Boolean get_IsArray() { }
        private System.Boolean get_ShouldCreateWrapper() { }
        private System.Boolean get_CanDeserialize() { }
        private System.Void set_CanDeserialize(System.Boolean value) { }
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }
        private System.Void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }
        private System.Boolean get_HasParameterizedCreator() { }
        private System.Void set_HasParameterizedCreator(System.Boolean value) { }
        private System.Boolean get_HasParameterizedCreatorInternal() { }
        private System.Void .ctor(System.Type underlyingType) { }
        private Newtonsoft.Json.Utilities.IWrappedCollection CreateWrapper(System.Object list) { }
        private System.Collections.IList CreateTemporaryCollection() { }
        private System.Void StoreFSharpListCreatorIfNecessary(System.Type underlyingType) { }

    }

    // TypeToken: 0x20000B6
    public class JsonContainerContract : JsonContract
    {
        // Fields
        private Newtonsoft.Json.Serialization.JsonContract _itemContract;        // 0x90
        private Newtonsoft.Json.Serialization.JsonContract _finalItemContract;        // 0x98
        private Newtonsoft.Json.JsonConverter <ItemConverter>k__BackingField;        // 0xA0
        private System.Nullable<System.Boolean> <ItemIsReference>k__BackingField;        // 0xA8
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField;        // 0xAC
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField;        // 0xB4

        // Methods
        private Newtonsoft.Json.Serialization.JsonContract get_ItemContract() { }
        private System.Void set_ItemContract(Newtonsoft.Json.Serialization.JsonContract value) { }
        private Newtonsoft.Json.Serialization.JsonContract get_FinalItemContract() { }
        private Newtonsoft.Json.JsonConverter get_ItemConverter() { }
        private System.Void set_ItemConverter(Newtonsoft.Json.JsonConverter value) { }
        private System.Nullable<System.Boolean> get_ItemIsReference() { }
        private System.Void set_ItemIsReference(System.Nullable<System.Boolean> value) { }
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }
        private System.Void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }
        private System.Void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }
        private System.Void .ctor(System.Type underlyingType) { }

    }

    // TypeToken: 0x20000B7
    public struct JsonContractType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Serialization.JsonContractType None;        // 0x0
        public static Newtonsoft.Json.Serialization.JsonContractType Object;        // 0x0
        public static Newtonsoft.Json.Serialization.JsonContractType Array;        // 0x0
        public static Newtonsoft.Json.Serialization.JsonContractType Primitive;        // 0x0
        public static Newtonsoft.Json.Serialization.JsonContractType String;        // 0x0
        public static Newtonsoft.Json.Serialization.JsonContractType Dictionary;        // 0x0
        public static Newtonsoft.Json.Serialization.JsonContractType Dynamic;        // 0x0
        public static Newtonsoft.Json.Serialization.JsonContractType Serializable;        // 0x0
        public static Newtonsoft.Json.Serialization.JsonContractType Linq;        // 0x0

    }

    // TypeToken: 0x20000B8
    public class SerializationCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object o, System.Runtime.Serialization.StreamingContext context) { }

    }

    // TypeToken: 0x20000B9
    public class SerializationErrorCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext) { }

    }

    // TypeToken: 0x20000BA
    public class ExtensionDataSetter : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object o, System.String key, System.Object value) { }

    }

    // TypeToken: 0x20000BB
    public class ExtensionDataGetter : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> Invoke(System.Object o) { }

    }

    // TypeToken: 0x20000BC
    public class JsonContract
    {
        // Fields
        private System.Boolean IsNullable;        // 0x10
        private System.Boolean IsConvertable;        // 0x11
        private System.Boolean IsEnum;        // 0x12
        private System.Type NonNullableUnderlyingType;        // 0x18
        private Newtonsoft.Json.ReadType InternalReadType;        // 0x20
        private Newtonsoft.Json.Serialization.JsonContractType ContractType;        // 0x24
        private System.Boolean IsReadOnlyOrFixedSize;        // 0x28
        private System.Boolean IsSealed;        // 0x29
        private System.Boolean IsInstantiable;        // 0x2A
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializedCallbacks;        // 0x30
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializingCallbacks;        // 0x38
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onSerializedCallbacks;        // 0x40
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onSerializingCallbacks;        // 0x48
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback> _onErrorCallbacks;        // 0x50
        private System.Type _createdType;        // 0x58
        private readonly System.Type <UnderlyingType>k__BackingField;        // 0x60
        private System.Nullable<System.Boolean> <IsReference>k__BackingField;        // 0x68
        private Newtonsoft.Json.JsonConverter <Converter>k__BackingField;        // 0x70
        private Newtonsoft.Json.JsonConverter <InternalConverter>k__BackingField;        // 0x78
        private System.Func<System.Object> <DefaultCreator>k__BackingField;        // 0x80
        private System.Boolean <DefaultCreatorNonPublic>k__BackingField;        // 0x88

        // Methods
        private System.Type get_UnderlyingType() { }
        private System.Type get_CreatedType() { }
        private System.Void set_CreatedType(System.Type value) { }
        private System.Nullable<System.Boolean> get_IsReference() { }
        private System.Void set_IsReference(System.Nullable<System.Boolean> value) { }
        private Newtonsoft.Json.JsonConverter get_Converter() { }
        private System.Void set_Converter(Newtonsoft.Json.JsonConverter value) { }
        private Newtonsoft.Json.JsonConverter get_InternalConverter() { }
        private System.Void set_InternalConverter(Newtonsoft.Json.JsonConverter value) { }
        private System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks() { }
        private System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks() { }
        private System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks() { }
        private System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks() { }
        private System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks() { }
        private System.Func<System.Object> get_DefaultCreator() { }
        private System.Void set_DefaultCreator(System.Func<System.Object> value) { }
        private System.Boolean get_DefaultCreatorNonPublic() { }
        private System.Void set_DefaultCreatorNonPublic(System.Boolean value) { }
        private System.Void .ctor(System.Type underlyingType) { }
        private System.Void InvokeOnSerializing(System.Object o, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void InvokeOnSerialized(System.Object o, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void InvokeOnDeserializing(System.Object o, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void InvokeOnDeserialized(System.Object o, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void InvokeOnError(System.Object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext) { }
        private Newtonsoft.Json.Serialization.SerializationCallback CreateSerializationCallback(System.Reflection.MethodInfo callbackMethodInfo) { }
        private Newtonsoft.Json.Serialization.SerializationErrorCallback CreateSerializationErrorCallback(System.Reflection.MethodInfo callbackMethodInfo) { }

    }

    // TypeToken: 0x20000BF
    public class JsonDictionaryContract : JsonContainerContract
    {
        // Fields
        private System.Func<System.String,System.String> <DictionaryKeyResolver>k__BackingField;        // 0xC0
        private readonly System.Type <DictionaryKeyType>k__BackingField;        // 0xC8
        private readonly System.Type <DictionaryValueType>k__BackingField;        // 0xD0
        private Newtonsoft.Json.Serialization.JsonContract <KeyContract>k__BackingField;        // 0xD8
        private readonly System.Type _genericCollectionDefinitionType;        // 0xE0
        private System.Type _genericWrapperType;        // 0xE8
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _genericWrapperCreator;        // 0xF0
        private System.Func<System.Object> _genericTemporaryDictionaryCreator;        // 0xF8
        private readonly System.Boolean <ShouldCreateWrapper>k__BackingField;        // 0x100
        private readonly System.Reflection.ConstructorInfo _parameterizedConstructor;        // 0x108
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _overrideCreator;        // 0x110
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _parameterizedCreator;        // 0x118
        private System.Boolean <HasParameterizedCreator>k__BackingField;        // 0x120

        // Methods
        private System.Func<System.String,System.String> get_DictionaryKeyResolver() { }
        private System.Void set_DictionaryKeyResolver(System.Func<System.String,System.String> value) { }
        private System.Type get_DictionaryKeyType() { }
        private System.Type get_DictionaryValueType() { }
        private Newtonsoft.Json.Serialization.JsonContract get_KeyContract() { }
        private System.Void set_KeyContract(Newtonsoft.Json.Serialization.JsonContract value) { }
        private System.Boolean get_ShouldCreateWrapper() { }
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }
        private System.Void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }
        private System.Boolean get_HasParameterizedCreator() { }
        private System.Void set_HasParameterizedCreator(System.Boolean value) { }
        private System.Boolean get_HasParameterizedCreatorInternal() { }
        private System.Void .ctor(System.Type underlyingType) { }
        private Newtonsoft.Json.Utilities.IWrappedDictionary CreateWrapper(System.Object dictionary) { }
        private System.Collections.IDictionary CreateTemporaryDictionary() { }

    }

    // TypeToken: 0x20000C0
    public class JsonDynamicContract : JsonContainerContract
    {
        // Fields
        private readonly Newtonsoft.Json.Serialization.JsonPropertyCollection <Properties>k__BackingField;        // 0xC0
        private System.Func<System.String,System.String> <PropertyNameResolver>k__BackingField;        // 0xC8
        private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.String,System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>>> _callSiteGetters;        // 0xD0
        private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.String,System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>>> _callSiteSetters;        // 0xD8

        // Methods
        private Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties() { }
        private System.Func<System.String,System.String> get_PropertyNameResolver() { }
        private System.Void set_PropertyNameResolver(System.Func<System.String,System.String> value) { }
        private System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>> CreateCallSiteGetter(System.String name) { }
        private System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>> CreateCallSiteSetter(System.String name) { }
        private System.Void .ctor(System.Type underlyingType) { }
        private System.Boolean TryGetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, System.String name, System.Object& value) { }
        private System.Boolean TrySetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, System.String name, System.Object value) { }

    }

    // TypeToken: 0x20000C1
    public class JsonFormatterConverter, IFormatterConverter
    {
        // Fields
        private readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader _reader;        // 0x10
        private readonly Newtonsoft.Json.Serialization.JsonISerializableContract _contract;        // 0x18
        private readonly Newtonsoft.Json.Serialization.JsonProperty _member;        // 0x20

        // Methods
        private System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member) { }
        private T GetTokenValue(System.Object value) { }
        private System.Object Convert(System.Object value, System.Type type) { }
        private System.Boolean ToBoolean(System.Object value) { }
        private System.Int32 ToInt32(System.Object value) { }
        private System.Int64 ToInt64(System.Object value) { }
        private System.Single ToSingle(System.Object value) { }
        private System.String ToString(System.Object value) { }

    }

    // TypeToken: 0x20000C2
    public class JsonISerializableContract : JsonContainerContract
    {
        // Fields
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <ISerializableCreator>k__BackingField;        // 0xC0

        // Methods
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ISerializableCreator() { }
        private System.Void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }
        private System.Void .ctor(System.Type underlyingType) { }

    }

    // TypeToken: 0x20000C3
    public class JsonLinqContract : JsonContract
    {
        // Methods
        private System.Void .ctor(System.Type underlyingType) { }

    }

    // TypeToken: 0x20000C4
    public class JsonObjectContract : JsonContainerContract
    {
        // Fields
        private Newtonsoft.Json.MemberSerialization <MemberSerialization>k__BackingField;        // 0xC0
        private System.Nullable<Newtonsoft.Json.MissingMemberHandling> <MissingMemberHandling>k__BackingField;        // 0xC4
        private System.Nullable<Newtonsoft.Json.Required> <ItemRequired>k__BackingField;        // 0xCC
        private System.Nullable<Newtonsoft.Json.NullValueHandling> <ItemNullValueHandling>k__BackingField;        // 0xD4
        private readonly Newtonsoft.Json.Serialization.JsonPropertyCollection <Properties>k__BackingField;        // 0xE0
        private Newtonsoft.Json.Serialization.ExtensionDataSetter <ExtensionDataSetter>k__BackingField;        // 0xE8
        private Newtonsoft.Json.Serialization.ExtensionDataGetter <ExtensionDataGetter>k__BackingField;        // 0xF0
        private System.Func<System.String,System.String> <ExtensionDataNameResolver>k__BackingField;        // 0xF8
        private System.Boolean ExtensionDataIsJToken;        // 0x100
        private System.Nullable<System.Boolean> _hasRequiredOrDefaultValueProperties;        // 0x101
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _overrideCreator;        // 0x108
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _parameterizedCreator;        // 0x110
        private Newtonsoft.Json.Serialization.JsonPropertyCollection _creatorParameters;        // 0x118
        private System.Type _extensionDataValueType;        // 0x120

        // Methods
        private Newtonsoft.Json.MemberSerialization get_MemberSerialization() { }
        private System.Void set_MemberSerialization(Newtonsoft.Json.MemberSerialization value) { }
        private System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling() { }
        private System.Void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value) { }
        private System.Nullable<Newtonsoft.Json.Required> get_ItemRequired() { }
        private System.Void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value) { }
        private System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling() { }
        private System.Void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }
        private Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties() { }
        private Newtonsoft.Json.Serialization.JsonPropertyCollection get_CreatorParameters() { }
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }
        private System.Void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }
        private System.Void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }
        private Newtonsoft.Json.Serialization.ExtensionDataSetter get_ExtensionDataSetter() { }
        private System.Void set_ExtensionDataSetter(Newtonsoft.Json.Serialization.ExtensionDataSetter value) { }
        private Newtonsoft.Json.Serialization.ExtensionDataGetter get_ExtensionDataGetter() { }
        private System.Void set_ExtensionDataGetter(Newtonsoft.Json.Serialization.ExtensionDataGetter value) { }
        private System.Void set_ExtensionDataValueType(System.Type value) { }
        private System.Func<System.String,System.String> get_ExtensionDataNameResolver() { }
        private System.Void set_ExtensionDataNameResolver(System.Func<System.String,System.String> value) { }
        private System.Boolean get_HasRequiredOrDefaultValueProperties() { }
        private System.Void .ctor(System.Type underlyingType) { }
        private System.Object GetUninitializedObject() { }

    }

    // TypeToken: 0x20000C5
    public class JsonPrimitiveContract : JsonContract
    {
        // Fields
        private Newtonsoft.Json.Utilities.PrimitiveTypeCode <TypeCode>k__BackingField;        // 0x90
        private static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.ReadType> ReadTypeMap;        // 0x0

        // Methods
        private Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode() { }
        private System.Void set_TypeCode(Newtonsoft.Json.Utilities.PrimitiveTypeCode value) { }
        private System.Void .ctor(System.Type underlyingType) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C6
    public class JsonProperty
    {
        // Fields
        private System.Nullable<Newtonsoft.Json.Required> _required;        // 0x10
        private System.Boolean _hasExplicitDefaultValue;        // 0x18
        private System.Object _defaultValue;        // 0x20
        private System.Boolean _hasGeneratedDefaultValue;        // 0x28
        private System.String _propertyName;        // 0x30
        private System.Boolean _skipPropertyNameEscape;        // 0x38
        private System.Type _propertyType;        // 0x40
        private Newtonsoft.Json.Serialization.JsonContract <PropertyContract>k__BackingField;        // 0x48
        private System.Type <DeclaringType>k__BackingField;        // 0x50
        private System.Nullable<System.Int32> <Order>k__BackingField;        // 0x58
        private System.String <UnderlyingName>k__BackingField;        // 0x60
        private Newtonsoft.Json.Serialization.IValueProvider <ValueProvider>k__BackingField;        // 0x68
        private Newtonsoft.Json.Serialization.IAttributeProvider <AttributeProvider>k__BackingField;        // 0x70
        private Newtonsoft.Json.JsonConverter <Converter>k__BackingField;        // 0x78
        private System.Boolean <Ignored>k__BackingField;        // 0x80
        private System.Boolean <Readable>k__BackingField;        // 0x81
        private System.Boolean <Writable>k__BackingField;        // 0x82
        private System.Boolean <HasMemberAttribute>k__BackingField;        // 0x83
        private System.Nullable<System.Boolean> <IsReference>k__BackingField;        // 0x84
        private System.Nullable<Newtonsoft.Json.NullValueHandling> <NullValueHandling>k__BackingField;        // 0x88
        private System.Nullable<Newtonsoft.Json.DefaultValueHandling> <DefaultValueHandling>k__BackingField;        // 0x90
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField;        // 0x98
        private System.Nullable<Newtonsoft.Json.ObjectCreationHandling> <ObjectCreationHandling>k__BackingField;        // 0xA0
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> <TypeNameHandling>k__BackingField;        // 0xA8
        private System.Predicate<System.Object> <ShouldSerialize>k__BackingField;        // 0xB0
        private System.Predicate<System.Object> <ShouldDeserialize>k__BackingField;        // 0xB8
        private System.Predicate<System.Object> <GetIsSpecified>k__BackingField;        // 0xC0
        private System.Action<System.Object,System.Object> <SetIsSpecified>k__BackingField;        // 0xC8
        private Newtonsoft.Json.JsonConverter <ItemConverter>k__BackingField;        // 0xD0
        private System.Nullable<System.Boolean> <ItemIsReference>k__BackingField;        // 0xD8
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField;        // 0xDC
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField;        // 0xE4

        // Methods
        private Newtonsoft.Json.Serialization.JsonContract get_PropertyContract() { }
        private System.Void set_PropertyContract(Newtonsoft.Json.Serialization.JsonContract value) { }
        private System.String get_PropertyName() { }
        private System.Void set_PropertyName(System.String value) { }
        private System.Type get_DeclaringType() { }
        private System.Void set_DeclaringType(System.Type value) { }
        private System.Nullable<System.Int32> get_Order() { }
        private System.Void set_Order(System.Nullable<System.Int32> value) { }
        private System.String get_UnderlyingName() { }
        private System.Void set_UnderlyingName(System.String value) { }
        private Newtonsoft.Json.Serialization.IValueProvider get_ValueProvider() { }
        private System.Void set_ValueProvider(Newtonsoft.Json.Serialization.IValueProvider value) { }
        private System.Void set_AttributeProvider(Newtonsoft.Json.Serialization.IAttributeProvider value) { }
        private System.Type get_PropertyType() { }
        private System.Void set_PropertyType(System.Type value) { }
        private Newtonsoft.Json.JsonConverter get_Converter() { }
        private System.Void set_Converter(Newtonsoft.Json.JsonConverter value) { }
        private System.Boolean get_Ignored() { }
        private System.Void set_Ignored(System.Boolean value) { }
        private System.Boolean get_Readable() { }
        private System.Void set_Readable(System.Boolean value) { }
        private System.Boolean get_Writable() { }
        private System.Void set_Writable(System.Boolean value) { }
        private System.Boolean get_HasMemberAttribute() { }
        private System.Void set_HasMemberAttribute(System.Boolean value) { }
        private System.Object get_DefaultValue() { }
        private System.Void set_DefaultValue(System.Object value) { }
        private System.Object GetResolvedDefaultValue() { }
        private Newtonsoft.Json.Required get_Required() { }
        private System.Nullable<System.Boolean> get_IsReference() { }
        private System.Void set_IsReference(System.Nullable<System.Boolean> value) { }
        private System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling() { }
        private System.Void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }
        private System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling() { }
        private System.Void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value) { }
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling() { }
        private System.Void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }
        private System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling() { }
        private System.Void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value) { }
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling() { }
        private System.Void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }
        private System.Predicate<System.Object> get_ShouldSerialize() { }
        private System.Void set_ShouldSerialize(System.Predicate<System.Object> value) { }
        private System.Predicate<System.Object> get_ShouldDeserialize() { }
        private System.Predicate<System.Object> get_GetIsSpecified() { }
        private System.Void set_GetIsSpecified(System.Predicate<System.Object> value) { }
        private System.Action<System.Object,System.Object> get_SetIsSpecified() { }
        private System.Void set_SetIsSpecified(System.Action<System.Object,System.Object> value) { }
        private System.String ToString() { }
        private Newtonsoft.Json.JsonConverter get_ItemConverter() { }
        private System.Void set_ItemConverter(Newtonsoft.Json.JsonConverter value) { }
        private System.Nullable<System.Boolean> get_ItemIsReference() { }
        private System.Void set_ItemIsReference(System.Nullable<System.Boolean> value) { }
        private System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }
        private System.Void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }
        private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }
        private System.Void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }
        private System.Void WritePropertyName(Newtonsoft.Json.JsonWriter writer) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C7
    public class JsonPropertyCollection : KeyedCollection`2
    {
        // Fields
        private readonly System.Type _type;        // 0x30
        private readonly System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list;        // 0x38

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.String GetKeyForItem(Newtonsoft.Json.Serialization.JsonProperty item) { }
        private System.Void AddProperty(Newtonsoft.Json.Serialization.JsonProperty property) { }
        private Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(System.String propertyName) { }
        private System.Boolean TryGetProperty(System.String key, Newtonsoft.Json.Serialization.JsonProperty& item) { }
        private Newtonsoft.Json.Serialization.JsonProperty GetProperty(System.String propertyName, System.StringComparison comparisonType) { }

    }

    // TypeToken: 0x20000C8
    public class JsonSerializerInternalBase
    {
        // Fields
        private Newtonsoft.Json.Serialization.ErrorContext _currentErrorContext;        // 0x10
        private Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> _mappings;        // 0x18
        private readonly Newtonsoft.Json.JsonSerializer Serializer;        // 0x20
        private readonly Newtonsoft.Json.Serialization.ITraceWriter TraceWriter;        // 0x28
        protected Newtonsoft.Json.Serialization.JsonSerializerProxy InternalSerializer;        // 0x30

        // Methods
        private System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer) { }
        private Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> get_DefaultReferenceMappings() { }
        private Newtonsoft.Json.NullValueHandling ResolvedNullValueHandling(Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property) { }
        private Newtonsoft.Json.Serialization.ErrorContext GetErrorContext(System.Object currentObject, System.Object member, System.String path, System.Exception error) { }
        private System.Void ClearErrorContext() { }
        private System.Boolean IsErrorHandled(System.Object currentObject, Newtonsoft.Json.Serialization.JsonContract contract, System.Object keyValue, Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.Exception ex) { }

    }

    // TypeToken: 0x20000CA
    public class JsonSerializerInternalReader : JsonSerializerInternalBase
    {
        // Methods
        private System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Void Populate(Newtonsoft.Json.JsonReader reader, System.Object target) { }
        private Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Type type) { }
        private Newtonsoft.Json.Serialization.JsonContract GetContract(System.Type type) { }
        private System.Object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Boolean checkAdditionalContent) { }
        private Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer() { }
        private Newtonsoft.Json.Linq.JToken CreateJToken(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract) { }
        private Newtonsoft.Json.Linq.JToken CreateJObject(Newtonsoft.Json.JsonReader reader) { }
        private System.Object CreateValueInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue) { }
        private System.Boolean CoerceEmptyStringToNull(System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, System.String s) { }
        private System.String GetExpectedDescription(Newtonsoft.Json.Serialization.JsonContract contract) { }
        private Newtonsoft.Json.JsonConverter GetConverter(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.JsonConverter memberConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Object CreateObject(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue) { }
        private System.Boolean ReadMetadataPropertiesToken(Newtonsoft.Json.Linq.JTokenReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue, System.Object& newValue, System.String& id) { }
        private System.Boolean ReadMetadataProperties(Newtonsoft.Json.JsonReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue, System.Object& newValue, System.String& id) { }
        private System.Void ResolveTypeName(Newtonsoft.Json.JsonReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.String qualifiedTypeName) { }
        private Newtonsoft.Json.Serialization.JsonArrayContract EnsureArrayContract(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract) { }
        private System.Object CreateList(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.Object existingValue, System.String id) { }
        private System.Boolean HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract contract) { }
        private System.Object EnsureType(Newtonsoft.Json.JsonReader reader, System.Object value, System.Globalization.CultureInfo culture, Newtonsoft.Json.Serialization.JsonContract contract, System.Type targetType) { }
        private System.Boolean SetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Object target) { }
        private System.Boolean CalculatePropertyDetails(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter& propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Object target, System.Boolean& useExistingValue, System.Object& currentValue, Newtonsoft.Json.Serialization.JsonContract& propertyContract, System.Boolean& gottenCurrentValue, System.Boolean& ignoredValue) { }
        private System.Void AddReference(Newtonsoft.Json.JsonReader reader, System.String id, System.Object value) { }
        private System.Boolean HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag) { }
        private System.Boolean ShouldSetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Object value) { }
        private System.Collections.IList CreateNewList(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, System.Boolean& createdFromNonDefaultCreator) { }
        private System.Collections.IDictionary CreateNewDictionary(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, System.Boolean& createdFromNonDefaultCreator) { }
        private System.Void OnDeserializing(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value) { }
        private System.Void OnDeserialized(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value) { }
        private System.Object PopulateDictionary(System.Collections.IDictionary dictionary, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id) { }
        private System.Object PopulateMultidimensionalArray(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id) { }
        private System.Void ThrowUnexpectedEndException(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object currentObject, System.String message) { }
        private System.Object PopulateList(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id) { }
        private System.Object CreateISerializable(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id) { }
        private System.Object CreateISerializableItem(Newtonsoft.Json.Linq.JToken token, System.Type type, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member) { }
        private System.Object CreateDynamic(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id) { }
        private System.Object CreateObjectUsingCreatorWithParameters(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator, System.String id) { }
        private System.Object DeserializeConvertable(Newtonsoft.Json.JsonConverter converter, Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue) { }
        private System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Type objectType) { }
        private System.Object CreateNewObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract objectContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id, System.Boolean& createdFromNonDefaultCreator) { }
        private System.Object PopulateObject(System.Object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id) { }
        private System.Boolean ShouldDeserialize(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target) { }
        private System.Boolean CheckPropertyName(Newtonsoft.Json.JsonReader reader, System.String memberName) { }
        private System.Void SetExtensionData(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader, System.String memberName, System.Object o) { }
        private System.Object ReadExtensionDataValue(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader) { }
        private System.Void EndProcessProperty(System.Object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Int32 initialDepth, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence presence, System.Boolean setDefaultValue) { }
        private System.Void SetPropertyPresence(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }
        private System.Void HandleError(Newtonsoft.Json.JsonReader reader, System.Boolean readPastError, System.Int32 initialDepth) { }

    }

    // TypeToken: 0x20000CF
    public class JsonSerializerInternalWriter : JsonSerializerInternalBase
    {
        // Fields
        private System.Type _rootType;        // 0x38
        private System.Int32 _rootLevel;        // 0x40
        private readonly System.Collections.Generic.List<System.Object> _serializeStack;        // 0x48

        // Methods
        private System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer) { }
        private System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType) { }
        private Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer() { }
        private Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Object value) { }
        private Newtonsoft.Json.Serialization.JsonContract GetContract(System.Object value) { }
        private System.Void SerializePrimitive(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonPrimitiveContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Void SerializeValue(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Nullable<System.Boolean> ResolveIsReference(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Boolean ShouldWriteReference(System.Object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Boolean ShouldWriteProperty(System.Object memberValue, Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property) { }
        private System.Boolean CheckForCircularReference(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Void WriteReference(Newtonsoft.Json.JsonWriter writer, System.Object value) { }
        private System.String GetReference(Newtonsoft.Json.JsonWriter writer, System.Object value) { }
        private System.Boolean TryConvertToString(System.Object value, System.Type type, System.String& s) { }
        private System.Void SerializeString(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonStringContract contract) { }
        private System.Void OnSerializing(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value) { }
        private System.Void OnSerialized(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value) { }
        private System.Void SerializeObject(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Boolean CalculatePropertyValues(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract& memberContract, System.Object& memberValue) { }
        private System.Void WriteObjectStart(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Boolean HasCreatorParameter(Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty property) { }
        private System.Void WriteReferenceIdProperty(Newtonsoft.Json.JsonWriter writer, System.Type type, System.Object value) { }
        private System.Void WriteTypeProperty(Newtonsoft.Json.JsonWriter writer, System.Type type) { }
        private System.Boolean HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag) { }
        private System.Boolean HasFlag(Newtonsoft.Json.PreserveReferencesHandling value, Newtonsoft.Json.PreserveReferencesHandling flag) { }
        private System.Boolean HasFlag(Newtonsoft.Json.TypeNameHandling value, Newtonsoft.Json.TypeNameHandling flag) { }
        private System.Void SerializeConvertable(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter converter, System.Object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Void SerializeList(Newtonsoft.Json.JsonWriter writer, System.Collections.IEnumerable values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.Int32 initialDepth, System.Int32[] indices) { }
        private System.Boolean WriteStartArray(Newtonsoft.Json.JsonWriter writer, System.Object values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Void SerializeISerializable(Newtonsoft.Json.JsonWriter writer, System.Runtime.Serialization.ISerializable value, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Void SerializeDynamic(Newtonsoft.Json.JsonWriter writer, System.Dynamic.IDynamicMetaObjectProvider value, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Boolean ShouldWriteDynamicProperty(System.Object memberValue) { }
        private System.Boolean ShouldWriteType(Newtonsoft.Json.TypeNameHandling typeNameHandlingFlag, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.Void SerializeDictionary(Newtonsoft.Json.JsonWriter writer, System.Collections.IDictionary values, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty) { }
        private System.String GetPropertyName(Newtonsoft.Json.JsonWriter writer, System.Object name, Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean& escape) { }
        private System.Void HandleError(Newtonsoft.Json.JsonWriter writer, System.Int32 initialDepth) { }
        private System.Boolean ShouldSerialize(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target) { }
        private System.Boolean IsSpecified(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target) { }

    }

    // TypeToken: 0x20000D0
    public class JsonSerializerProxy : JsonSerializer
    {
        // Fields
        private readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader _serializerReader;        // 0xE0
        private readonly Newtonsoft.Json.Serialization.JsonSerializerInternalWriter _serializerWriter;        // 0xE8
        private readonly Newtonsoft.Json.JsonSerializer _serializer;        // 0xF0

        // Methods
        private System.Void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }
        private System.Void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }
        private System.Void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value) { }
        private Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter() { }
        private System.Void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value) { }
        private System.Void set_EqualityComparer(System.Collections.IEqualityComparer value) { }
        private Newtonsoft.Json.JsonConverterCollection get_Converters() { }
        private System.Void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value) { }
        private Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver() { }
        private System.Void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value) { }
        private System.Void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value) { }
        private Newtonsoft.Json.NullValueHandling get_NullValueHandling() { }
        private System.Void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value) { }
        private System.Void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value) { }
        private System.Void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value) { }
        private System.Void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value) { }
        private System.Void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value) { }
        private Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling() { }
        private System.Void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value) { }
        private System.Void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value) { }
        private System.Void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value) { }
        private System.Void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value) { }
        private System.Runtime.Serialization.StreamingContext get_Context() { }
        private System.Void set_Context(System.Runtime.Serialization.StreamingContext value) { }
        private Newtonsoft.Json.Formatting get_Formatting() { }
        private System.Void set_Formatting(Newtonsoft.Json.Formatting value) { }
        private System.Nullable<System.Int32> get_MaxDepth() { }
        private System.Boolean get_CheckAdditionalContent() { }
        private System.Void set_CheckAdditionalContent(System.Boolean value) { }
        private Newtonsoft.Json.Serialization.JsonSerializerInternalBase GetInternalSerializer() { }
        private System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalReader serializerReader) { }
        private System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalWriter serializerWriter) { }
        private System.Object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType) { }
        private System.Void PopulateInternal(Newtonsoft.Json.JsonReader reader, System.Object target) { }
        private System.Void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type rootType) { }

    }

    // TypeToken: 0x20000D1
    public class JsonStringContract : JsonPrimitiveContract
    {
        // Methods
        private System.Void .ctor(System.Type underlyingType) { }

    }

    // TypeToken: 0x20000D2
    public class JsonTypeReflector
    {
        // Fields
        private static System.Nullable<System.Boolean> _fullyTrusted;        // 0x0
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Func<System.Object[],System.Object>> CreatorCache;        // 0x8
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Type> AssociatedMetadataTypesCache;        // 0x10
        private static Newtonsoft.Json.Utilities.ReflectionObject _metadataTypeAttributeReflectionObject;        // 0x18

        // Methods
        private T GetCachedAttribute(System.Object attributeProvider) { }
        private System.Boolean CanTypeDescriptorConvertString(System.Type type, System.ComponentModel.TypeConverter& typeConverter) { }
        private System.Runtime.Serialization.DataContractAttribute GetDataContractAttribute(System.Type type) { }
        private System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute(System.Reflection.MemberInfo memberInfo) { }
        private Newtonsoft.Json.MemberSerialization GetObjectMemberSerialization(System.Type objectType, System.Boolean ignoreSerializableAttribute) { }
        private Newtonsoft.Json.JsonConverter GetJsonConverter(System.Object attributeProvider) { }
        private Newtonsoft.Json.JsonConverter CreateJsonConverterInstance(System.Type converterType, System.Object[] args) { }
        private Newtonsoft.Json.Serialization.NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, System.Object[] args) { }
        private Newtonsoft.Json.Serialization.NamingStrategy GetContainerNamingStrategy(Newtonsoft.Json.JsonContainerAttribute containerAttribute) { }
        private System.Func<System.Object[],System.Object> GetCreator(System.Type type) { }
        private System.Type GetAssociatedMetadataType(System.Type type) { }
        private System.Type GetAssociateMetadataTypeFromAttribute(System.Type type) { }
        private T GetAttribute(System.Type type) { }
        private T GetAttribute(System.Reflection.MemberInfo memberInfo) { }
        private System.Boolean IsNonSerializable(System.Object provider) { }
        private System.Boolean IsSerializable(System.Object provider) { }
        private T GetAttribute(System.Object provider) { }
        private System.Boolean get_FullyTrusted() { }
        private Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_ReflectionDelegateFactory() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D5
    public class KebabCaseNamingStrategy : NamingStrategy
    {
        // Methods
        private System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames) { }
        private System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames) { }
        private System.Void .ctor() { }
        private System.String ResolvePropertyName(System.String name) { }

    }

    // TypeToken: 0x20000D6
    public class NamingStrategy
    {
        // Fields
        private System.Boolean <ProcessDictionaryKeys>k__BackingField;        // 0x10
        private System.Boolean <ProcessExtensionDataNames>k__BackingField;        // 0x11
        private System.Boolean <OverrideSpecifiedNames>k__BackingField;        // 0x12

        // Methods
        private System.Boolean get_ProcessDictionaryKeys() { }
        private System.Void set_ProcessDictionaryKeys(System.Boolean value) { }
        private System.Boolean get_ProcessExtensionDataNames() { }
        private System.Void set_ProcessExtensionDataNames(System.Boolean value) { }
        private System.Boolean get_OverrideSpecifiedNames() { }
        private System.Void set_OverrideSpecifiedNames(System.Boolean value) { }
        private System.String GetPropertyName(System.String name, System.Boolean hasSpecifiedName) { }
        private System.String GetExtensionDataName(System.String name) { }
        private System.String GetDictionaryKey(System.String key) { }
        private System.String ResolvePropertyName(System.String name) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(Newtonsoft.Json.Serialization.NamingStrategy other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7
    public class ObjectConstructor`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Object Invoke(System.Object[] args) { }

    }

    // TypeToken: 0x20000D8
    public class OnErrorAttribute : Attribute
    {
    }

    // TypeToken: 0x20000D9
    public class ReflectionAttributeProvider, IAttributeProvider
    {
        // Fields
        private readonly System.Object _attributeProvider;        // 0x10

        // Methods
        private System.Void .ctor(System.Object attributeProvider) { }

    }

    // TypeToken: 0x20000DA
    public class ReflectionValueProvider, IValueProvider
    {
        // Fields
        private readonly System.Reflection.MemberInfo _memberInfo;        // 0x10

        // Methods
        private System.Void .ctor(System.Reflection.MemberInfo memberInfo) { }
        private System.Void SetValue(System.Object target, System.Object value) { }
        private System.Object GetValue(System.Object target) { }

    }

    // TypeToken: 0x20000DB
    public class SnakeCaseNamingStrategy : NamingStrategy
    {
        // Methods
        private System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames) { }
        private System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames) { }
        private System.Void .ctor() { }
        private System.String ResolvePropertyName(System.String name) { }

    }

    // TypeToken: 0x20000DC
    public class TraceJsonReader : JsonReader, IJsonLineInfo
    {
        // Fields
        private readonly Newtonsoft.Json.JsonReader _innerReader;        // 0x78
        private readonly Newtonsoft.Json.JsonTextWriter _textWriter;        // 0x80
        private readonly System.IO.StringWriter _sw;        // 0x88

        // Methods
        private System.Void .ctor(Newtonsoft.Json.JsonReader innerReader) { }
        private System.String GetDeserializedJsonMessage() { }
        private System.Boolean Read() { }
        private System.Nullable<System.Int32> ReadAsInt32() { }
        private System.String ReadAsString() { }
        private System.Byte[] ReadAsBytes() { }
        private System.Nullable<System.Decimal> ReadAsDecimal() { }
        private System.Nullable<System.Double> ReadAsDouble() { }
        private System.Nullable<System.Boolean> ReadAsBoolean() { }
        private System.Nullable<System.DateTime> ReadAsDateTime() { }
        private System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }
        private System.Void WriteCurrentToken() { }
        private System.Int32 get_Depth() { }
        private System.String get_Path() { }
        private Newtonsoft.Json.JsonToken get_TokenType() { }
        private System.Object get_Value() { }
        private System.Type get_ValueType() { }
        private System.Void Close() { }
        private System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }
        private System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }
        private System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

    }

    // TypeToken: 0x20000DD
    public class TraceJsonWriter : JsonWriter
    {
        // Fields
        private readonly Newtonsoft.Json.JsonWriter _innerWriter;        // 0x60
        private readonly Newtonsoft.Json.JsonTextWriter _textWriter;        // 0x68
        private readonly System.IO.StringWriter _sw;        // 0x70

        // Methods
        private System.Void .ctor(Newtonsoft.Json.JsonWriter innerWriter) { }
        private System.String GetSerializedJsonMessage() { }
        private System.Void WriteValue(System.Decimal value) { }
        private System.Void WriteValue(System.Nullable<System.Decimal> value) { }
        private System.Void WriteValue(System.Boolean value) { }
        private System.Void WriteValue(System.Nullable<System.Boolean> value) { }
        private System.Void WriteValue(System.Byte value) { }
        private System.Void WriteValue(System.Nullable<System.Byte> value) { }
        private System.Void WriteValue(System.Char value) { }
        private System.Void WriteValue(System.Nullable<System.Char> value) { }
        private System.Void WriteValue(System.Byte[] value) { }
        private System.Void WriteValue(System.DateTime value) { }
        private System.Void WriteValue(System.Nullable<System.DateTime> value) { }
        private System.Void WriteValue(System.DateTimeOffset value) { }
        private System.Void WriteValue(System.Nullable<System.DateTimeOffset> value) { }
        private System.Void WriteValue(System.Double value) { }
        private System.Void WriteValue(System.Nullable<System.Double> value) { }
        private System.Void WriteUndefined() { }
        private System.Void WriteNull() { }
        private System.Void WriteValue(System.Single value) { }
        private System.Void WriteValue(System.Nullable<System.Single> value) { }
        private System.Void WriteValue(System.Guid value) { }
        private System.Void WriteValue(System.Nullable<System.Guid> value) { }
        private System.Void WriteValue(System.Int32 value) { }
        private System.Void WriteValue(System.Nullable<System.Int32> value) { }
        private System.Void WriteValue(System.Int64 value) { }
        private System.Void WriteValue(System.Nullable<System.Int64> value) { }
        private System.Void WriteValue(System.Object value) { }
        private System.Void WriteValue(System.SByte value) { }
        private System.Void WriteValue(System.Nullable<System.SByte> value) { }
        private System.Void WriteValue(System.Int16 value) { }
        private System.Void WriteValue(System.Nullable<System.Int16> value) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void WriteValue(System.TimeSpan value) { }
        private System.Void WriteValue(System.Nullable<System.TimeSpan> value) { }
        private System.Void WriteValue(System.UInt32 value) { }
        private System.Void WriteValue(System.Nullable<System.UInt32> value) { }
        private System.Void WriteValue(System.UInt64 value) { }
        private System.Void WriteValue(System.Nullable<System.UInt64> value) { }
        private System.Void WriteValue(System.Uri value) { }
        private System.Void WriteValue(System.UInt16 value) { }
        private System.Void WriteValue(System.Nullable<System.UInt16> value) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void WriteStartArray() { }
        private System.Void WriteEndArray() { }
        private System.Void WriteStartConstructor(System.String name) { }
        private System.Void WriteEndConstructor() { }
        private System.Void WritePropertyName(System.String name) { }
        private System.Void WritePropertyName(System.String name, System.Boolean escape) { }
        private System.Void WriteStartObject() { }
        private System.Void WriteEndObject() { }
        private System.Void WriteRawValue(System.String json) { }
        private System.Void WriteRaw(System.String json) { }
        private System.Void Close() { }

    }

}

namespace Newtonsoft.Json.Utilities
{

    // TypeToken: 0x200003F
    public class AotHelper
    {
        // Fields
        private static System.Boolean s_alwaysFalse;        // 0x0

        // Methods
        private System.Void Ensure(System.Action action) { }
        private System.Void EnsureList() { }
        private System.Boolean IsFalse() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000041
    public class Base64Encoder
    {
        // Fields
        private readonly System.Char[] _charsLine;        // 0x10
        private readonly System.IO.TextWriter _writer;        // 0x18
        private System.Byte[] _leftOverBytes;        // 0x20
        private System.Int32 _leftOverBytesCount;        // 0x28

        // Methods
        private System.Void .ctor(System.IO.TextWriter writer) { }
        private System.Void ValidateEncode(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void Encode(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void StoreLeftOverBytes(System.Byte[] buffer, System.Int32 index, System.Int32& count) { }
        private System.Boolean FulfillFromLeftover(System.Byte[] buffer, System.Int32 index, System.Int32& count) { }
        private System.Void Flush() { }
        private System.Void WriteChars(System.Char[] chars, System.Int32 index, System.Int32 count) { }

    }

    // TypeToken: 0x2000042
    public class BidirectionalDictionary`2
    {
        // Fields
        private readonly System.Collections.Generic.IDictionary<TFirst,TSecond> _firstToSecond;        // 0x0
        private readonly System.Collections.Generic.IDictionary<TSecond,TFirst> _secondToFirst;        // 0x0
        private readonly System.String _duplicateFirstErrorMessage;        // 0x0
        private readonly System.String _duplicateSecondErrorMessage;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, System.String duplicateFirstErrorMessage, System.String duplicateSecondErrorMessage) { }
        private System.Void Set(TFirst first, TSecond second) { }
        private System.Boolean TryGetByFirst(TFirst first, TSecond& second) { }
        private System.Boolean TryGetBySecond(TSecond second, TFirst& first) { }

    }

    // TypeToken: 0x2000043
    public class BoxedPrimitives
    {
        // Fields
        private static readonly System.Object BooleanTrue;        // 0x0
        private static readonly System.Object BooleanFalse;        // 0x8
        private static readonly System.Object Int32_M1;        // 0x10
        private static readonly System.Object Int32_0;        // 0x18
        private static readonly System.Object Int32_1;        // 0x20
        private static readonly System.Object Int32_2;        // 0x28
        private static readonly System.Object Int32_3;        // 0x30
        private static readonly System.Object Int32_4;        // 0x38
        private static readonly System.Object Int32_5;        // 0x40
        private static readonly System.Object Int32_6;        // 0x48
        private static readonly System.Object Int32_7;        // 0x50
        private static readonly System.Object Int32_8;        // 0x58
        private static readonly System.Object Int64_M1;        // 0x60
        private static readonly System.Object Int64_0;        // 0x68
        private static readonly System.Object Int64_1;        // 0x70
        private static readonly System.Object Int64_2;        // 0x78
        private static readonly System.Object Int64_3;        // 0x80
        private static readonly System.Object Int64_4;        // 0x88
        private static readonly System.Object Int64_5;        // 0x90
        private static readonly System.Object Int64_6;        // 0x98
        private static readonly System.Object Int64_7;        // 0xA0
        private static readonly System.Object Int64_8;        // 0xA8
        private static readonly System.Object DecimalZero;        // 0xB0
        private static readonly System.Object DoubleNaN;        // 0xB8
        private static readonly System.Object DoublePositiveInfinity;        // 0xC0
        private static readonly System.Object DoubleNegativeInfinity;        // 0xC8
        private static readonly System.Object DoubleZero;        // 0xD0

        // Methods
        private System.Object Get(System.Boolean value) { }
        private System.Object Get(System.Int32 value) { }
        private System.Object Get(System.Int64 value) { }
        private System.Object Get(System.Decimal value) { }
        private System.Object Get(System.Double value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000044
    public class CollectionUtils
    {
        // Methods
        private System.Boolean IsNullOrEmpty(System.Collections.Generic.ICollection<T> collection) { }
        private System.Void AddRange(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection) { }
        private System.Boolean IsDictionaryType(System.Type type) { }
        private System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType) { }
        private System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType) { }
        private System.Int32 IndexOf(System.Collections.Generic.IEnumerable<T> collection, System.Func<T,System.Boolean> predicate) { }
        private System.Boolean Contains(System.Collections.Generic.List<T> list, T value, System.Collections.IEqualityComparer comparer) { }
        private System.Int32 IndexOfReference(System.Collections.Generic.List<T> list, T item) { }
        private System.Void FastReverse(System.Collections.Generic.List<T> list) { }
        private System.Collections.Generic.IList<System.Int32> GetDimensions(System.Collections.IList values, System.Int32 dimensionsCount) { }
        private System.Void CopyFromJaggedToMultidimensionalArray(System.Collections.IList values, System.Array multidimensionalArray, System.Int32[] indices) { }
        private System.Object JaggedArrayGetValue(System.Collections.IList values, System.Int32[] indices) { }
        private System.Array ToMultidimensionalArray(System.Collections.IList values, System.Type type, System.Int32 rank) { }
        private T[] ArrayEmpty() { }

    }

    // TypeToken: 0x2000046
    public interface IWrappedCollection : IList, ICollection, IEnumerable
    {
        // Methods
        private System.Object get_UnderlyingCollection() { }

    }

    // TypeToken: 0x2000047
    public class CollectionWrapper`1, ICollection`1, IEnumerable`1, IEnumerable, IWrappedCollection, IList, ICollection
    {
        // Fields
        private readonly System.Collections.IList _list;        // 0x0
        private readonly System.Collections.Generic.ICollection<T> _genericCollection;        // 0x0
        private System.Object _syncRoot;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.IList list) { }
        private System.Void .ctor(System.Collections.Generic.ICollection<T> list) { }
        private System.Void Add(T item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(T item) { }
        private System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean Remove(T item) { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Void System.Collections.IList.RemoveAt(System.Int32 index) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Boolean System.Collections.IList.get_IsFixedSize() { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Object System.Collections.IList.get_Item(System.Int32 index) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex) { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Void VerifyValueType(System.Object value) { }
        private System.Boolean IsCompatibleObject(System.Object value) { }
        private System.Object get_UnderlyingCollection() { }

    }

    // TypeToken: 0x2000048
    public struct PrimitiveTypeCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Empty;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Object;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Char;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode CharNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Boolean;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode BooleanNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode SByte;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode SByteNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int16;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int16Nullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt16;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt16Nullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int32;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int32Nullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Byte;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode ByteNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt32;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt32Nullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int64;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Int64Nullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt64;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode UInt64Nullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Single;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode SingleNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Double;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DoubleNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DateTime;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DateTimeNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DateTimeOffset;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DateTimeOffsetNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Decimal;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DecimalNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Guid;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode GuidNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode TimeSpan;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode TimeSpanNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode BigInteger;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode BigIntegerNullable;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Uri;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode String;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode Bytes;        // 0x0
        public static Newtonsoft.Json.Utilities.PrimitiveTypeCode DBNull;        // 0x0

    }

    // TypeToken: 0x2000049
    public class TypeInformation
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x10
        private readonly Newtonsoft.Json.Utilities.PrimitiveTypeCode <TypeCode>k__BackingField;        // 0x18

        // Methods
        private System.Type get_Type() { }
        private Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode() { }
        private System.Void .ctor(System.Type type, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode) { }

    }

    // TypeToken: 0x200004A
    public struct ParseResult
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Utilities.ParseResult None;        // 0x0
        public static Newtonsoft.Json.Utilities.ParseResult Success;        // 0x0
        public static Newtonsoft.Json.Utilities.ParseResult Overflow;        // 0x0
        public static Newtonsoft.Json.Utilities.ParseResult Invalid;        // 0x0

    }

    // TypeToken: 0x200004B
    public class ConvertUtils
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.Utilities.PrimitiveTypeCode> TypeCodeMap;        // 0x0
        private static readonly Newtonsoft.Json.Utilities.TypeInformation[] PrimitiveTypeCodes;        // 0x8
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type>,System.Func<System.Object,System.Object>> CastConverters;        // 0x10

        // Methods
        private Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t) { }
        private Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t, System.Boolean& isEnum) { }
        private Newtonsoft.Json.Utilities.TypeInformation GetTypeInformation(System.IConvertible convertable) { }
        private System.Boolean IsConvertible(System.Type t) { }
        private System.TimeSpan ParseTimeSpan(System.String input) { }
        private System.Func<System.Object,System.Object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type> t) { }
        private System.Numerics.BigInteger ToBigInteger(System.Object value) { }
        private System.Object FromBigInteger(System.Numerics.BigInteger i, System.Type targetType) { }
        private System.Object Convert(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType) { }
        private System.Boolean TryConvert(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, System.Object& value) { }
        private Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult TryConvertInternal(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, System.Object& value) { }
        private System.Object ConvertOrCast(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType) { }
        private System.Object EnsureTypeAssignable(System.Object value, System.Type initialType, System.Type targetType) { }
        private System.Boolean VersionTryParse(System.String input, System.Version& result) { }
        private System.Boolean IsInteger(System.Object value) { }
        private Newtonsoft.Json.Utilities.ParseResult Int32TryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Int32& value) { }
        private Newtonsoft.Json.Utilities.ParseResult Int64TryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Int64& value) { }
        private Newtonsoft.Json.Utilities.ParseResult DecimalTryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Decimal& value) { }
        private System.Boolean TryConvertGuid(System.String s, System.Guid& g) { }
        private System.Boolean TryHexTextToInt(System.Char[] text, System.Int32 start, System.Int32 end, System.Int32& value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004E
    public struct ParserTimeZone
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Newtonsoft.Json.Utilities.ParserTimeZone Unspecified;        // 0x0
        public static Newtonsoft.Json.Utilities.ParserTimeZone Utc;        // 0x0
        public static Newtonsoft.Json.Utilities.ParserTimeZone LocalWestOfUtc;        // 0x0
        public static Newtonsoft.Json.Utilities.ParserTimeZone LocalEastOfUtc;        // 0x0

    }

    // TypeToken: 0x200004F
    public struct DateTimeParser
    {
        // Fields
        public System.Int32 Year;        // 0x10
        public System.Int32 Month;        // 0x14
        public System.Int32 Day;        // 0x18
        public System.Int32 Hour;        // 0x1C
        public System.Int32 Minute;        // 0x20
        public System.Int32 Second;        // 0x24
        public System.Int32 Fraction;        // 0x28
        public System.Int32 ZoneHour;        // 0x2C
        public System.Int32 ZoneMinute;        // 0x30
        public Newtonsoft.Json.Utilities.ParserTimeZone Zone;        // 0x34
        private System.Char[] _text;        // 0x38
        private System.Int32 _end;        // 0x40
        private static readonly System.Int32[] Power10;        // 0x0
        private static readonly System.Int32 Lzyyyy;        // 0x8
        private static readonly System.Int32 Lzyyyy_;        // 0xC
        private static readonly System.Int32 Lzyyyy_MM;        // 0x10
        private static readonly System.Int32 Lzyyyy_MM_;        // 0x14
        private static readonly System.Int32 Lzyyyy_MM_dd;        // 0x18
        private static readonly System.Int32 Lzyyyy_MM_ddT;        // 0x1C
        private static readonly System.Int32 LzHH;        // 0x20
        private static readonly System.Int32 LzHH_;        // 0x24
        private static readonly System.Int32 LzHH_mm;        // 0x28
        private static readonly System.Int32 LzHH_mm_;        // 0x2C
        private static readonly System.Int32 LzHH_mm_ss;        // 0x30
        private static readonly System.Int32 Lz_;        // 0x34
        private static readonly System.Int32 Lz_zz;        // 0x38

        // Methods
        private System.Void .cctor() { }
        private System.Boolean Parse(System.Char[] text, System.Int32 startIndex, System.Int32 length) { }
        private System.Boolean ParseDate(System.Int32 start) { }
        private System.Boolean ParseTimeAndZoneAndWhitespace(System.Int32 start) { }
        private System.Boolean ParseTime(System.Int32& start) { }
        private System.Boolean ParseZone(System.Int32 start) { }
        private System.Boolean Parse4Digit(System.Int32 start, System.Int32& num) { }
        private System.Boolean Parse2Digit(System.Int32 start, System.Int32& num) { }
        private System.Boolean ParseChar(System.Int32 start, System.Char ch) { }

    }

    // TypeToken: 0x2000050
    public class DateTimeUtils
    {
        // Fields
        private static readonly System.Int64 InitialJavaScriptDateTicks;        // 0x0
        private static readonly System.Int32[] DaysToMonth365;        // 0x8
        private static readonly System.Int32[] DaysToMonth366;        // 0x10

        // Methods
        private System.Void .cctor() { }
        private System.TimeSpan GetUtcOffset(System.DateTime d) { }
        private System.Xml.XmlDateTimeSerializationMode ToSerializationMode(System.DateTimeKind kind) { }
        private System.DateTime EnsureDateTime(System.DateTime value, Newtonsoft.Json.DateTimeZoneHandling timeZone) { }
        private System.DateTime SwitchToLocalTime(System.DateTime value) { }
        private System.DateTime SwitchToUtcTime(System.DateTime value) { }
        private System.Int64 ToUniversalTicks(System.DateTime dateTime) { }
        private System.Int64 ToUniversalTicks(System.DateTime dateTime, System.TimeSpan offset) { }
        private System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.TimeSpan offset) { }
        private System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime) { }
        private System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.Boolean convertToUtc) { }
        private System.Int64 UniversalTicksToJavaScriptTicks(System.Int64 universalTicks) { }
        private System.DateTime ConvertJavaScriptTicksToDateTime(System.Int64 javaScriptTicks) { }
        private System.Boolean TryParseDateTimeIso(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.DateTime& dt) { }
        private System.Boolean TryParseDateTimeOffsetIso(Newtonsoft.Json.Utilities.StringReference text, System.DateTimeOffset& dt) { }
        private System.DateTime CreateDateTime(Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser) { }
        private System.Boolean TryParseDateTime(Newtonsoft.Json.Utilities.StringReference s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt) { }
        private System.Boolean TryParseDateTime(System.String s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt) { }
        private System.Boolean TryParseDateTimeOffset(Newtonsoft.Json.Utilities.StringReference s, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt) { }
        private System.Boolean TryParseDateTimeOffset(System.String s, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt) { }
        private System.Boolean TryParseMicrosoftDate(Newtonsoft.Json.Utilities.StringReference text, System.Int64& ticks, System.TimeSpan& offset, System.DateTimeKind& kind) { }
        private System.Boolean TryParseDateTimeMicrosoft(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.DateTime& dt) { }
        private System.Boolean TryParseDateTimeExact(System.String text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt) { }
        private System.Boolean TryParseDateTimeOffsetMicrosoft(Newtonsoft.Json.Utilities.StringReference text, System.DateTimeOffset& dt) { }
        private System.Boolean TryParseDateTimeOffsetExact(System.String text, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt) { }
        private System.Boolean TryReadOffset(Newtonsoft.Json.Utilities.StringReference offsetText, System.Int32 startIndex, System.TimeSpan& offset) { }
        private System.Void WriteDateTimeString(System.IO.TextWriter writer, System.DateTime value, Newtonsoft.Json.DateFormatHandling format, System.String formatString, System.Globalization.CultureInfo culture) { }
        private System.Int32 WriteDateTimeString(System.Char[] chars, System.Int32 start, System.DateTime value, System.Nullable<System.TimeSpan> offset, System.DateTimeKind kind, Newtonsoft.Json.DateFormatHandling format) { }
        private System.Int32 WriteDefaultIsoDate(System.Char[] chars, System.Int32 start, System.DateTime dt) { }
        private System.Void CopyIntToCharArray(System.Char[] chars, System.Int32 start, System.Int32 value, System.Int32 digits) { }
        private System.Int32 WriteDateTimeOffset(System.Char[] chars, System.Int32 start, System.TimeSpan offset, Newtonsoft.Json.DateFormatHandling format) { }
        private System.Void WriteDateTimeOffsetString(System.IO.TextWriter writer, System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format, System.String formatString, System.Globalization.CultureInfo culture) { }
        private System.Void GetDateValues(System.DateTime td, System.Int32& year, System.Int32& month, System.Int32& day) { }

    }

    // TypeToken: 0x2000051
    public interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
    {
        // Methods
        private System.Object get_UnderlyingDictionary() { }

    }

    // TypeToken: 0x2000052
    public class DictionaryWrapper`2, IDictionary`2, ICollection`1, IEnumerable`1, IEnumerable, IWrappedDictionary, IDictionary, ICollection
    {
        // Fields
        private readonly System.Collections.IDictionary _dictionary;        // 0x0
        private readonly System.Collections.Generic.IDictionary<TKey,TValue> _genericDictionary;        // 0x0
        private readonly System.Collections.Generic.IReadOnlyDictionary<TKey,TValue> _readOnlyDictionary;        // 0x0
        private System.Object _syncRoot;        // 0x0

        // Methods
        private System.Collections.Generic.IDictionary<TKey,TValue> get_GenericDictionary() { }
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
        private System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value) { }
        private System.Object System.Collections.IDictionary.get_Item(System.Object key) { }
        private System.Void System.Collections.IDictionary.set_Item(System.Object key, System.Object value) { }
        private System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
        private System.Boolean System.Collections.IDictionary.Contains(System.Object key) { }
        private System.Boolean System.Collections.IDictionary.get_IsFixedSize() { }
        private System.Collections.ICollection System.Collections.IDictionary.get_Keys() { }
        private System.Void Remove(System.Object key) { }
        private System.Collections.ICollection System.Collections.IDictionary.get_Values() { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Object get_UnderlyingDictionary() { }

    }

    // TypeToken: 0x2000055
    public class DynamicProxy`1
    {
        // Methods
        private System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(T instance) { }
        private System.Boolean TryBinaryOperation(T instance, System.Dynamic.BinaryOperationBinder binder, System.Object arg, System.Object& result) { }
        private System.Boolean TryConvert(T instance, System.Dynamic.ConvertBinder binder, System.Object& result) { }
        private System.Boolean TryCreateInstance(T instance, System.Dynamic.CreateInstanceBinder binder, System.Object[] args, System.Object& result) { }
        private System.Boolean TryDeleteIndex(T instance, System.Dynamic.DeleteIndexBinder binder, System.Object[] indexes) { }
        private System.Boolean TryDeleteMember(T instance, System.Dynamic.DeleteMemberBinder binder) { }
        private System.Boolean TryGetIndex(T instance, System.Dynamic.GetIndexBinder binder, System.Object[] indexes, System.Object& result) { }
        private System.Boolean TryGetMember(T instance, System.Dynamic.GetMemberBinder binder, System.Object& result) { }
        private System.Boolean TryInvoke(T instance, System.Dynamic.InvokeBinder binder, System.Object[] args, System.Object& result) { }
        private System.Boolean TryInvokeMember(T instance, System.Dynamic.InvokeMemberBinder binder, System.Object[] args, System.Object& result) { }
        private System.Boolean TrySetIndex(T instance, System.Dynamic.SetIndexBinder binder, System.Object[] indexes, System.Object value) { }
        private System.Boolean TrySetMember(T instance, System.Dynamic.SetMemberBinder binder, System.Object value) { }
        private System.Boolean TryUnaryOperation(T instance, System.Dynamic.UnaryOperationBinder binder, System.Object& result) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000056
    public class DynamicProxyMetaObject`1 : DynamicMetaObject
    {
        // Fields
        private readonly Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy;        // 0x0

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy) { }
        private System.Boolean IsOverridden(System.String method) { }
        private System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder) { }
        private System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value) { }
        private System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder) { }
        private System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder) { }
        private System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg) { }
        private System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder) { }
        private System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes) { }
        private System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value) { }
        private System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes) { }
        private System.Linq.Expressions.Expression[] get_NoArgs() { }
        private System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(System.Dynamic.DynamicMetaObject[] args) { }
        private System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args) { }
        private System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject value) { }
        private System.Linq.Expressions.ConstantExpression Constant(System.Dynamic.DynamicMetaObjectBinder binder) { }
        private System.Dynamic.DynamicMetaObject CallMethodWithResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
        private System.Dynamic.DynamicMetaObject BuildCallMethodWithResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, System.Dynamic.DynamicMetaObject fallbackResult, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
        private System.Dynamic.DynamicMetaObject CallMethodReturnLast(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback) { }
        private System.Dynamic.DynamicMetaObject CallMethodNoResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Linq.Expressions.Expression[] args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback) { }
        private System.Dynamic.BindingRestrictions GetRestrictions() { }
        private System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames() { }

    }

    // TypeToken: 0x2000066
    public class DynamicUtils
    {
        // Methods
        private System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider) { }

    }

    // TypeToken: 0x2000068
    public class NoThrowGetBinderMember : GetMemberBinder
    {
        // Fields
        private readonly System.Dynamic.GetMemberBinder _innerBinder;        // 0x28

        // Methods
        private System.Void .ctor(System.Dynamic.GetMemberBinder innerBinder) { }
        private System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x2000069
    public class NoThrowSetBinderMember : SetMemberBinder
    {
        // Fields
        private readonly System.Dynamic.SetMemberBinder _innerBinder;        // 0x28

        // Methods
        private System.Void .ctor(System.Dynamic.SetMemberBinder innerBinder) { }
        private System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x200006A
    public class NoThrowExpressionVisitor : ExpressionVisitor
    {
        // Fields
        private static readonly System.Object ErrorResult;        // 0x0

        // Methods
        private System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006B
    public class EnumInfo
    {
        // Fields
        public readonly System.Boolean IsFlags;        // 0x10
        public readonly System.UInt64[] Values;        // 0x18
        public readonly System.String[] Names;        // 0x20
        public readonly System.String[] ResolvedNames;        // 0x28

        // Methods
        private System.Void .ctor(System.Boolean isFlags, System.UInt64[] values, System.String[] names, System.String[] resolvedNames) { }

    }

    // TypeToken: 0x200006C
    public class EnumUtils
    {
        // Fields
        private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum;        // 0x0
        private static Newtonsoft.Json.Serialization.CamelCaseNamingStrategy _camelCaseNamingStrategy;        // 0x8

        // Methods
        private Newtonsoft.Json.Utilities.EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy> key) { }
        private System.Boolean TryToString(System.Type enumType, System.Object value, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.String& name) { }
        private System.String InternalFlagsFormat(Newtonsoft.Json.Utilities.EnumInfo entry, System.UInt64 result) { }
        private Newtonsoft.Json.Utilities.EnumInfo GetEnumValuesAndNames(System.Type enumType) { }
        private System.UInt64 ToUInt64(System.Object value) { }
        private System.Object ParseEnum(System.Type enumType, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.String value, System.Boolean disallowNumber) { }
        private System.Nullable<System.Int32> MatchName(System.String value, System.String[] enumNames, System.String[] resolvedNames, System.Int32 valueIndex, System.Int32 valueSubstringLength, System.StringComparison comparison) { }
        private System.Nullable<System.Int32> FindIndexByName(System.String[] enumNames, System.String value, System.Int32 valueIndex, System.Int32 valueSubstringLength, System.StringComparison comparison) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006E
    public class FSharpFunction
    {
        // Fields
        private readonly System.Object _instance;        // 0x10
        private readonly Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _invoker;        // 0x18

        // Methods
        private System.Void .ctor(System.Object instance, Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoker) { }
        private System.Object Invoke(System.Object[] args) { }

    }

    // TypeToken: 0x200006F
    public class FSharpUtils
    {
        // Fields
        private static readonly System.Object Lock;        // 0x0
        private static Newtonsoft.Json.Utilities.FSharpUtils _instance;        // 0x8
        private System.Reflection.MethodInfo _ofSeq;        // 0x10
        private System.Type _mapType;        // 0x18
        private System.Reflection.Assembly <FSharpCoreAssembly>k__BackingField;        // 0x20
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <IsUnion>k__BackingField;        // 0x28
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <GetUnionCases>k__BackingField;        // 0x30
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <PreComputeUnionTagReader>k__BackingField;        // 0x38
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <PreComputeUnionReader>k__BackingField;        // 0x40
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <PreComputeUnionConstructor>k__BackingField;        // 0x48
        private System.Func<System.Object,System.Object> <GetUnionCaseInfoDeclaringType>k__BackingField;        // 0x50
        private System.Func<System.Object,System.Object> <GetUnionCaseInfoName>k__BackingField;        // 0x58
        private System.Func<System.Object,System.Object> <GetUnionCaseInfoTag>k__BackingField;        // 0x60
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <GetUnionCaseInfoFields>k__BackingField;        // 0x68

        // Methods
        private System.Void .ctor(System.Reflection.Assembly fsharpCoreAssembly) { }
        private Newtonsoft.Json.Utilities.FSharpUtils get_Instance() { }
        private System.Void set_FSharpCoreAssembly(System.Reflection.Assembly value) { }
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_IsUnion() { }
        private System.Void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCases() { }
        private System.Void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionTagReader() { }
        private System.Void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionReader() { }
        private System.Void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionConstructor() { }
        private System.Void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }
        private System.Func<System.Object,System.Object> get_GetUnionCaseInfoDeclaringType() { }
        private System.Void set_GetUnionCaseInfoDeclaringType(System.Func<System.Object,System.Object> value) { }
        private System.Func<System.Object,System.Object> get_GetUnionCaseInfoName() { }
        private System.Void set_GetUnionCaseInfoName(System.Func<System.Object,System.Object> value) { }
        private System.Func<System.Object,System.Object> get_GetUnionCaseInfoTag() { }
        private System.Void set_GetUnionCaseInfoTag(System.Func<System.Object,System.Object> value) { }
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCaseInfoFields() { }
        private System.Void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }
        private System.Void EnsureInitialized(System.Reflection.Assembly fsharpCoreAssembly) { }
        private System.Reflection.MethodInfo GetMethodWithNonPublicFallback(System.Type type, System.String methodName, System.Reflection.BindingFlags bindingFlags) { }
        private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> CreateFSharpFuncCall(System.Type type, System.String methodName) { }
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateSeq(System.Type t) { }
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateMap(System.Type keyType, System.Type valueType) { }
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> BuildMapCreator() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000073
    public class ImmutableCollectionsUtils
    {
        // Fields
        private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions;        // 0x0
        private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions;        // 0x8

        // Methods
        private System.Boolean TryBuildImmutableForArrayContract(System.Type underlyingType, System.Type collectionItemType, System.Type& createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }
        private System.Boolean TryBuildImmutableForDictionaryContract(System.Type underlyingType, System.Type keyItemType, System.Type valueItemType, System.Type& createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000078
    public class BufferUtils
    {
        // Methods
        private System.Char[] RentBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 minSize) { }
        private System.Void ReturnBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[] buffer) { }
        private System.Char[] EnsureBufferSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 size, System.Char[] buffer) { }

    }

    // TypeToken: 0x2000079
    public class JavaScriptUtils
    {
        // Fields
        private static readonly System.Boolean[] SingleQuoteCharEscapeFlags;        // 0x0
        private static readonly System.Boolean[] DoubleQuoteCharEscapeFlags;        // 0x8
        private static readonly System.Boolean[] HtmlCharEscapeFlags;        // 0x10

        // Methods
        private System.Void .cctor() { }
        private System.Boolean[] GetCharEscapeFlags(Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, System.Char quoteChar) { }
        private System.Boolean ShouldEscapeJavaScriptString(System.String s, System.Boolean[] charEscapeFlags) { }
        private System.Void WriteEscapedJavaScriptString(System.IO.TextWriter writer, System.String s, System.Char delimiter, System.Boolean appendDelimiters, System.Boolean[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[]& writeBuffer) { }
        private System.String ToEscapedJavaScriptString(System.String value, System.Char delimiter, System.Boolean appendDelimiters, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling) { }
        private System.Int32 FirstCharToEscape(System.String s, System.Boolean[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling) { }
        private System.Boolean TryGetDateFromConstructorJson(Newtonsoft.Json.JsonReader reader, System.DateTime& dateTime, System.String& errorMessage) { }
        private System.Boolean TryGetDateConstructorValue(Newtonsoft.Json.JsonReader reader, System.Nullable<System.Int64>& integer, System.String& errorMessage) { }

    }

    // TypeToken: 0x200007A
    public class JsonTokenUtils
    {
        // Methods
        private System.Boolean IsEndToken(Newtonsoft.Json.JsonToken token) { }
        private System.Boolean IsStartToken(Newtonsoft.Json.JsonToken token) { }
        private System.Boolean IsPrimitiveToken(Newtonsoft.Json.JsonToken token) { }

    }

    // TypeToken: 0x200007B
    public class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
    {
        // Fields
        private static readonly Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory _instance;        // 0x0

        // Methods
        private Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_Instance() { }
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(System.Reflection.MethodBase method) { }
        private Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(System.Reflection.MethodBase method) { }
        private System.Func<T> CreateDefaultConstructor(System.Type type) { }
        private System.Func<T,System.Object> CreateGet(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Func<T,System.Object> CreateGet(System.Reflection.FieldInfo fieldInfo) { }
        private System.Action<T,System.Object> CreateSet(System.Reflection.FieldInfo fieldInfo) { }
        private System.Action<T,System.Object> CreateSet(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000083
    public class MathUtils
    {
        // Methods
        private System.Int32 IntLength(System.UInt64 i) { }
        private System.Char IntToHex(System.Int32 n) { }
        private System.Boolean ApproxEquals(System.Double d1, System.Double d2) { }

    }

    // TypeToken: 0x2000084
    public class MethodCall`2 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T target, System.Object[] args) { }

    }

    // TypeToken: 0x2000085
    public class MiscellaneousUtils
    {
        // Methods
        private System.Boolean ValueEquals(System.Object objA, System.Object objB) { }
        private System.ArgumentOutOfRangeException CreateArgumentOutOfRangeException(System.String paramName, System.Object actualValue, System.String message) { }
        private System.String ToString(System.Object value) { }
        private System.Int32 ByteArrayCompare(System.Byte[] a1, System.Byte[] a2) { }
        private System.String GetPrefix(System.String qualifiedName) { }
        private System.String GetLocalName(System.String qualifiedName) { }
        private System.Void GetQualifiedNameParts(System.String qualifiedName, System.String& prefix, System.String& localName) { }
        private System.Text.RegularExpressions.RegexOptions GetRegexOptions(System.String optionsText) { }

    }

    // TypeToken: 0x2000086
    public class ReflectionDelegateFactory
    {
        // Methods
        private System.Func<T,System.Object> CreateGet(System.Reflection.MemberInfo memberInfo) { }
        private System.Action<T,System.Object> CreateSet(System.Reflection.MemberInfo memberInfo) { }
        private Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(System.Reflection.MethodBase method) { }
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(System.Reflection.MethodBase method) { }
        private System.Func<T> CreateDefaultConstructor(System.Type type) { }
        private System.Func<T,System.Object> CreateGet(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Func<T,System.Object> CreateGet(System.Reflection.FieldInfo fieldInfo) { }
        private System.Action<T,System.Object> CreateSet(System.Reflection.FieldInfo fieldInfo) { }
        private System.Action<T,System.Object> CreateSet(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000087
    public class ReflectionMember
    {
        // Fields
        private System.Type <MemberType>k__BackingField;        // 0x10
        private System.Func<System.Object,System.Object> <Getter>k__BackingField;        // 0x18
        private System.Action<System.Object,System.Object> <Setter>k__BackingField;        // 0x20

        // Methods
        private System.Type get_MemberType() { }
        private System.Void set_MemberType(System.Type value) { }
        private System.Func<System.Object,System.Object> get_Getter() { }
        private System.Void set_Getter(System.Func<System.Object,System.Object> value) { }
        private System.Action<System.Object,System.Object> get_Setter() { }
        private System.Void set_Setter(System.Action<System.Object,System.Object> value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000088
    public class ReflectionObject
    {
        // Fields
        private readonly Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <Creator>k__BackingField;        // 0x10
        private readonly System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField;        // 0x18

        // Methods
        private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_Creator() { }
        private System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> get_Members() { }
        private System.Void .ctor(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator) { }
        private System.Object GetValue(System.Object target, System.String member) { }
        private System.Void SetValue(System.Object target, System.String member, System.Object value) { }
        private System.Type GetType(System.String member) { }
        private Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.String[] memberNames) { }
        private Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.Reflection.MethodBase creator, System.String[] memberNames) { }

    }

    // TypeToken: 0x200008C
    public class ReflectionUtils
    {
        // Fields
        public static readonly System.Type[] EmptyTypes;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Boolean IsVirtual(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Reflection.MethodInfo GetBaseDefinition(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Boolean IsPublic(System.Reflection.PropertyInfo property) { }
        private System.Type GetObjectType(System.Object v) { }
        private System.String GetTypeName(System.Type t, Newtonsoft.Json.TypeNameAssemblyFormatHandling assemblyFormat, Newtonsoft.Json.Serialization.ISerializationBinder binder) { }
        private System.String GetFullyQualifiedTypeName(System.Type t, Newtonsoft.Json.Serialization.ISerializationBinder binder) { }
        private System.String RemoveAssemblyDetails(System.String fullyQualifiedTypeName) { }
        private System.Boolean HasDefaultConstructor(System.Type t, System.Boolean nonPublic) { }
        private System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t) { }
        private System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t, System.Boolean nonPublic) { }
        private System.Boolean IsNullable(System.Type t) { }
        private System.Boolean IsNullableType(System.Type t) { }
        private System.Type EnsureNotNullableType(System.Type t) { }
        private System.Type EnsureNotByRefType(System.Type t) { }
        private System.Boolean IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition) { }
        private System.Boolean ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition) { }
        private System.Boolean ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, System.Type& implementingType) { }
        private System.Boolean InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition) { }
        private System.Boolean InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, System.Type& implementingType) { }
        private System.Boolean InheritsGenericDefinitionInternal(System.Type type, System.Type genericClassDefinition, System.Type& implementingType) { }
        private System.Type GetCollectionItemType(System.Type type) { }
        private System.Void GetDictionaryKeyValueTypes(System.Type dictionaryType, System.Type& keyType, System.Type& valueType) { }
        private System.Type GetMemberUnderlyingType(System.Reflection.MemberInfo member) { }
        private System.Boolean IsByRefLikeType(System.Type type) { }
        private System.Boolean IsIndexedProperty(System.Reflection.PropertyInfo property) { }
        private System.Object GetMemberValue(System.Reflection.MemberInfo member, System.Object target) { }
        private System.Void SetMemberValue(System.Reflection.MemberInfo member, System.Object target, System.Object value) { }
        private System.Boolean CanReadMemberValue(System.Reflection.MemberInfo member, System.Boolean nonPublic) { }
        private System.Boolean CanSetMemberValue(System.Reflection.MemberInfo member, System.Boolean nonPublic, System.Boolean canSetReadOnly) { }
        private System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(System.Type type, System.Reflection.BindingFlags bindingAttr) { }
        private System.Boolean IsOverridenGenericMember(System.Reflection.MemberInfo memberInfo, System.Reflection.BindingFlags bindingAttr) { }
        private T GetAttribute(System.Object attributeProvider) { }
        private T GetAttribute(System.Object attributeProvider, System.Boolean inherit) { }
        private T[] GetAttributes(System.Object attributeProvider, System.Boolean inherit) { }
        private System.Attribute[] GetAttributes(System.Object attributeProvider, System.Type attributeType, System.Boolean inherit) { }
        private Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> SplitFullyQualifiedTypeName(System.String fullyQualifiedTypeName) { }
        private System.Nullable<System.Int32> GetAssemblyDelimiterIndex(System.String fullyQualifiedTypeName) { }
        private System.Reflection.MemberInfo GetMemberInfoFromType(System.Type targetType, System.Reflection.MemberInfo memberInfo) { }
        private System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(System.Type targetType, System.Reflection.BindingFlags bindingAttr) { }
        private System.Void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, System.Type type, System.Reflection.BindingFlags bindingAttr) { }
        private System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(System.Type targetType, System.Reflection.BindingFlags bindingAttr) { }
        private System.Reflection.BindingFlags RemoveFlag(System.Reflection.BindingFlags bindingAttr, System.Reflection.BindingFlags flag) { }
        private System.Void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, System.Type type, System.Reflection.BindingFlags bindingAttr) { }
        private System.Boolean IsMethodOverridden(System.Type currentType, System.Type methodDeclaringType, System.String method) { }
        private System.Object GetDefaultValue(System.Type type) { }

    }

    // TypeToken: 0x2000092
    public struct StringBuffer
    {
        // Fields
        private System.Char[] _buffer;        // 0x10
        private System.Int32 _position;        // 0x18

        // Methods
        private System.Int32 get_Position() { }
        private System.Void set_Position(System.Int32 value) { }
        private System.Boolean get_IsEmpty() { }
        private System.Void .ctor(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 initalSize) { }
        private System.Void .ctor(System.Char[] buffer) { }
        private System.Void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char value) { }
        private System.Void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[] buffer, System.Int32 startIndex, System.Int32 count) { }
        private System.Void Clear(Newtonsoft.Json.IArrayPool<System.Char> bufferPool) { }
        private System.Void EnsureSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 appendLength) { }
        private System.String ToString() { }
        private System.String ToString(System.Int32 start, System.Int32 length) { }
        private System.Char[] get_InternalBuffer() { }

    }

    // TypeToken: 0x2000093
    public struct StringReference
    {
        // Fields
        private readonly System.Char[] _chars;        // 0x10
        private readonly System.Int32 _startIndex;        // 0x18
        private readonly System.Int32 _length;        // 0x1C

        // Methods
        private System.Char get_Item(System.Int32 i) { }
        private System.Char[] get_Chars() { }
        private System.Int32 get_StartIndex() { }
        private System.Int32 get_Length() { }
        private System.Void .ctor(System.Char[] chars, System.Int32 startIndex, System.Int32 length) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000094
    public class StringReferenceExtensions
    {
        // Methods
        private System.Int32 IndexOf(Newtonsoft.Json.Utilities.StringReference s, System.Char c, System.Int32 startIndex, System.Int32 length) { }
        private System.Boolean StartsWith(Newtonsoft.Json.Utilities.StringReference s, System.String text) { }
        private System.Boolean EndsWith(Newtonsoft.Json.Utilities.StringReference s, System.String text) { }

    }

    // TypeToken: 0x2000095
    public class StringUtils
    {
        // Methods
        private System.Boolean IsNullOrEmpty(System.String value) { }
        private System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0) { }
        private System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1) { }
        private System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1, System.Object arg2) { }
        private System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1, System.Object arg2, System.Object arg3) { }
        private System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object[] args) { }
        private System.IO.StringWriter CreateStringWriter(System.Int32 capacity) { }
        private System.Void ToCharAsUnicode(System.Char c, System.Char[] buffer) { }
        private TSource ForgivingCaseSensitiveFind(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.String> valueSelector, System.String testValue) { }
        private System.String ToCamelCase(System.String s) { }
        private System.Char ToLower(System.Char c) { }
        private System.String ToSnakeCase(System.String s) { }
        private System.String ToKebabCase(System.String s) { }
        private System.String ToSeparatedCase(System.String s, System.Char separator) { }
        private System.Boolean IsHighSurrogate(System.Char c) { }
        private System.Boolean IsLowSurrogate(System.Char c) { }
        private System.Int32 IndexOf(System.String s, System.Char c) { }
        private System.Boolean StartsWith(System.String source, System.Char value) { }
        private System.Boolean EndsWith(System.String source, System.Char value) { }
        private System.String Trim(System.String s, System.Int32 start, System.Int32 length) { }

    }

    // TypeToken: 0x2000098
    public struct StructMultiKey`2, IEquatable`1
    {
        // Fields
        public readonly T1 Value1;        // 0x0
        public readonly T2 Value2;        // 0x0

        // Methods
        private System.Void .ctor(T1 v1, T2 v2) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1,T2> other) { }

    }

    // TypeToken: 0x2000099
    public class ThreadSafeStore`2
    {
        // Fields
        private readonly System.Collections.Concurrent.ConcurrentDictionary<TKey,TValue> _concurrentStore;        // 0x0
        private readonly System.Func<TKey,TValue> _creator;        // 0x0

        // Methods
        private System.Void .ctor(System.Func<TKey,TValue> creator) { }
        private TValue Get(TKey key) { }

    }

    // TypeToken: 0x200009A
    public class TypeExtensions
    {
        // Methods
        private System.Reflection.MemberTypes MemberType(System.Reflection.MemberInfo memberInfo) { }
        private System.Boolean ContainsGenericParameters(System.Type type) { }
        private System.Boolean IsInterface(System.Type type) { }
        private System.Boolean IsGenericType(System.Type type) { }
        private System.Boolean IsGenericTypeDefinition(System.Type type) { }
        private System.Type BaseType(System.Type type) { }
        private System.Reflection.Assembly Assembly(System.Type type) { }
        private System.Boolean IsEnum(System.Type type) { }
        private System.Boolean IsClass(System.Type type) { }
        private System.Boolean IsSealed(System.Type type) { }
        private System.Boolean IsAbstract(System.Type type) { }
        private System.Boolean IsVisible(System.Type type) { }
        private System.Boolean IsValueType(System.Type type) { }
        private System.Boolean AssignableToTypeName(System.Type type, System.String fullTypeName, System.Boolean searchInterfaces, System.Type& match) { }
        private System.Boolean AssignableToTypeName(System.Type type, System.String fullTypeName, System.Boolean searchInterfaces) { }
        private System.Boolean ImplementInterface(System.Type type, System.Type interfaceType) { }

    }

    // TypeToken: 0x200009B
    public class ValidationUtils
    {
        // Methods
        private System.Void ArgumentNotNull(System.Object value, System.String parameterName) { }

    }

}

namespace System.Diagnostics.CodeAnalysis
{

    // TypeToken: 0x2000006
    public class NotNullAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class NotNullWhenAttribute : Attribute
    {
        // Fields
        private readonly System.Boolean <ReturnValue>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean returnValue) { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003
    public class IsReadOnlyAttribute : Attribute
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

}

