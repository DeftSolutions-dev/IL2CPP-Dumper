// ========================================================
// Dumped by @desirepro
// Assembly: Newtonsoft.Json.dll
// Classes:  309
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Entry
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private   readonly System.String                   Value  // 0x10
  private   readonly System.Int32                    HashCode  // 0x18
  private           Newtonsoft.Json.DefaultJsonNameTable.EntryNext  // 0x20
METHODS:
  System.Void .ctor(System.String value, System.Int32 hashCode, Newtonsoft.Json.DefaultJsonNameTable.Entry next)
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.JsonReader.StateStart  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StateComplete  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StateProperty  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StateObjectStart  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StateObject  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StateArrayStart  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StateArray  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StateClosed  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StatePostValue  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StateConstructorStart  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StateConstructor  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StateError  // 0x0
  public    static  Newtonsoft.Json.JsonReader.StateFinished  // 0x0
METHODS:
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.JsonWriter.StateStart  // 0x0
  public    static  Newtonsoft.Json.JsonWriter.StateProperty  // 0x0
  public    static  Newtonsoft.Json.JsonWriter.StateObjectStart  // 0x0
  public    static  Newtonsoft.Json.JsonWriter.StateObject  // 0x0
  public    static  Newtonsoft.Json.JsonWriter.StateArrayStart  // 0x0
  public    static  Newtonsoft.Json.JsonWriter.StateArray  // 0x0
  public    static  Newtonsoft.Json.JsonWriter.StateConstructorStart  // 0x0
  public    static  Newtonsoft.Json.JsonWriter.StateConstructor  // 0x0
  public    static  Newtonsoft.Json.JsonWriter.StateClosed  // 0x0
  public    static  Newtonsoft.Json.JsonWriter.StateError  // 0x0
METHODS:
END_CLASS

CLASS: EmptyArrayContainer`1
TYPE:  class
TOKEN: 0x2000045
FIELDS:
  public    static readonly T[]                             Empty  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: ConvertResult
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Utilities.ConvertUtils.ConvertResultSuccess  // 0x0
  public    static  Newtonsoft.Json.Utilities.ConvertUtils.ConvertResultCannotConvertNull  // 0x0
  public    static  Newtonsoft.Json.Utilities.ConvertUtils.ConvertResultNotInstantiableType  // 0x0
  public    static  Newtonsoft.Json.Utilities.ConvertUtils.ConvertResultNoValidConversion  // 0x0
METHODS:
END_CLASS

CLASS: DictionaryEnumerator`2
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  private   readonly System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>>_e  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e)
  System.Collections.DictionaryEntry get_Entry()
  System.Object get_Key()
  System.Object get_Value()
  System.Object get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: Fallback
TYPE:  class
TOKEN: 0x2000057
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Dynamic.DynamicMetaObject Invoke(System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: GetBinderAdapter
TYPE:  class
TOKEN: 0x2000058
EXTENDS: GetMemberBinder
FIELDS:
METHODS:
  System.Void .ctor(System.Dynamic.InvokeMemberBinder binder)
  System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: BinderWrapper
TYPE:  class
TOKEN: 0x2000067
FIELDS:
  private   static  System.Object                   _getCSharpArgumentInfoArray  // 0x0
  private   static  System.Object                   _setCSharpArgumentInfoArray  // 0x8
  private   static  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>_getMemberCall  // 0x10
  private   static  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>_setMemberCall  // 0x18
  private   static  System.Boolean                  _init  // 0x20
METHODS:
  System.Void Init()
  System.Object CreateSharpArgumentInfoArray(System.Int32[] values)
  System.Void CreateMemberCalls()
  System.Runtime.CompilerServices.CallSiteBinder GetMember(System.String name, System.Type context)
  System.Runtime.CompilerServices.CallSiteBinder SetMember(System.String name, System.Type context)
END_CLASS

CLASS: ImmutableCollectionTypeInfo
TYPE:  class
TOKEN: 0x2000074
FIELDS:
  private           System.String                   <ContractTypeName>k__BackingField  // 0x10
  private           System.String                   <CreatedTypeName>k__BackingField  // 0x18
  private           System.String                   <BuilderTypeName>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.String contractTypeName, System.String createdTypeName, System.String builderTypeName)
  System.String get_ContractTypeName()
  System.Void set_ContractTypeName(System.String value)
  System.String get_CreatedTypeName()
  System.Void set_CreatedTypeName(System.String value)
  System.String get_BuilderTypeName()
  System.Void set_BuilderTypeName(System.String value)
END_CLASS

CLASS: SeparatedCaseState
TYPE:  struct
TOKEN: 0x2000096
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseStateStart  // 0x0
  public    static  Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseStateLower  // 0x0
  public    static  Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseStateUpper  // 0x0
  public    static  Newtonsoft.Json.Utilities.StringUtils.SeparatedCaseStateNewWord  // 0x0
METHODS:
END_CLASS

CLASS: EnumerableDictionaryWrapper`2
TYPE:  class
TOKEN: 0x200009F
FIELDS:
  private   readonly System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>>_e  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e)
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: ReferenceEqualsEqualityComparer
TYPE:  class
TOKEN: 0x20000C9
FIELDS:
METHODS:
  System.Boolean System.Collections.Generic.IEqualityComparer<System.Object>.Equals(System.Object x, System.Object y)
  System.Int32 System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(System.Object obj)
  System.Void .ctor()
END_CLASS

CLASS: PropertyPresence
TYPE:  struct
TOKEN: 0x20000CB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresenceNone  // 0x0
  public    static  Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresenceNull  // 0x0
  public    static  Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresenceValue  // 0x0
METHODS:
END_CLASS

CLASS: CreatorPropertyContext
TYPE:  class
TOKEN: 0x20000CC
FIELDS:
  public    readonly System.String                   Name  // 0x10
  public            Newtonsoft.Json.Serialization.JsonPropertyProperty  // 0x18
  public            Newtonsoft.Json.Serialization.JsonPropertyConstructorProperty  // 0x20
  public            System.Nullable<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence>Presence  // 0x28
  public            System.Object                   Value  // 0x30
  public            System.Boolean                  Used  // 0x38
METHODS:
  System.Void .ctor(System.String name)
END_CLASS

CLASS: JObjectDynamicProxy
TYPE:  class
TOKEN: 0x20000E6
EXTENDS: DynamicProxy`1
FIELDS:
METHODS:
  System.Boolean TryGetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.GetMemberBinder binder, System.Object& result)
  System.Boolean TrySetMember(Newtonsoft.Json.Linq.JObject instance, System.Dynamic.SetMemberBinder binder, System.Object value)
  System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(Newtonsoft.Json.Linq.JObject instance)
  System.Void .ctor()
END_CLASS

CLASS: JPropertyList
TYPE:  class
TOKEN: 0x20000EA
FIELDS:
  private           Newtonsoft.Json.Linq.JToken     _token  // 0x10
METHODS:
  System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Add(Newtonsoft.Json.Linq.JToken item)
  System.Void Clear()
  System.Boolean Contains(Newtonsoft.Json.Linq.JToken item)
  System.Void CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex)
  System.Boolean Remove(Newtonsoft.Json.Linq.JToken item)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Int32 IndexOf(Newtonsoft.Json.Linq.JToken item)
  System.Void Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  System.Void RemoveAt(System.Int32 index)
  Newtonsoft.Json.Linq.JToken get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, Newtonsoft.Json.Linq.JToken value)
  System.Void .ctor()
END_CLASS

CLASS: LineInfoAnnotation
TYPE:  class
TOKEN: 0x20000F2
FIELDS:
  private   readonly System.Int32                    LineNumber  // 0x10
  private   readonly System.Int32                    LinePosition  // 0x14
METHODS:
  System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition)
END_CLASS

CLASS: JValueDynamicProxy
TYPE:  class
TOKEN: 0x20000F7
EXTENDS: DynamicProxy`1
FIELDS:
METHODS:
  System.Boolean TryConvert(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.ConvertBinder binder, System.Object& result)
  System.Boolean TryBinaryOperation(Newtonsoft.Json.Linq.JValue instance, System.Dynamic.BinaryOperationBinder binder, System.Object arg, System.Object& result)
  System.Void .ctor()
END_CLASS

CLASS: Union
TYPE:  class
TOKEN: 0x2000100
FIELDS:
  public    readonly Newtonsoft.Json.Utilities.FSharpFunctionTagReader  // 0x10
  public    readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase>Cases  // 0x18
METHODS:
  System.Void .ctor(Newtonsoft.Json.Utilities.FSharpFunction tagReader, System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases)
END_CLASS

CLASS: UnionCase
TYPE:  class
TOKEN: 0x2000101
FIELDS:
  public    readonly System.Int32                    Tag  // 0x10
  public    readonly System.String                   Name  // 0x18
  public    readonly System.Reflection.PropertyInfo[]Fields  // 0x20
  public    readonly Newtonsoft.Json.Utilities.FSharpFunctionFieldReader  // 0x28
  public    readonly Newtonsoft.Json.Utilities.FSharpFunctionConstructor  // 0x30
METHODS:
  System.Void .ctor(System.Int32 tag, System.String name, System.Reflection.PropertyInfo[] fields, Newtonsoft.Json.Utilities.FSharpFunction fieldReader, Newtonsoft.Json.Utilities.FSharpFunction constructor)
END_CLASS

CLASS: __StaticArrayInitTypeSize=10
TYPE:  struct
TOKEN: 0x200012D
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=16
TYPE:  struct
TOKEN: 0x200012E
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=20
TYPE:  struct
TOKEN: 0x200012F
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=24
TYPE:  struct
TOKEN: 0x2000130
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=28
TYPE:  struct
TOKEN: 0x2000131
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=36
TYPE:  struct
TOKEN: 0x2000132
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=40
TYPE:  struct
TOKEN: 0x2000133
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=44
TYPE:  struct
TOKEN: 0x2000134
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=52
TYPE:  struct
TOKEN: 0x2000135
FIELDS:
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

CLASS: Newtonsoft.Json.ConstructorHandling
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.ConstructorHandlingDefault  // 0x0
  public    static  Newtonsoft.Json.ConstructorHandlingAllowNonPublicDefaultConstructor  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.DateFormatHandling
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.DateFormatHandlingIsoDateFormat  // 0x0
  public    static  Newtonsoft.Json.DateFormatHandlingMicrosoftDateFormat  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.DateParseHandling
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.DateParseHandlingNone  // 0x0
  public    static  Newtonsoft.Json.DateParseHandlingDateTime  // 0x0
  public    static  Newtonsoft.Json.DateParseHandlingDateTimeOffset  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.DateTimeZoneHandling
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.DateTimeZoneHandlingLocal  // 0x0
  public    static  Newtonsoft.Json.DateTimeZoneHandlingUtc  // 0x0
  public    static  Newtonsoft.Json.DateTimeZoneHandlingUnspecified  // 0x0
  public    static  Newtonsoft.Json.DateTimeZoneHandlingRoundtripKind  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.DefaultJsonNameTable
TYPE:  class
TOKEN: 0x200000C
EXTENDS: JsonNameTable
FIELDS:
  private   static readonly System.Int32                    HashCodeRandomizer  // 0x0
  private           System.Int32                    _count  // 0x10
  private           Newtonsoft.Json.DefaultJsonNameTable.Entry[]_entries  // 0x18
  private           System.Int32                    _mask  // 0x20
METHODS:
  System.Void .cctor()
  System.Void .ctor()
  System.String Get(System.Char[] key, System.Int32 start, System.Int32 length)
  System.String Add(System.String key)
  System.String AddEntry(System.String str, System.Int32 hashCode)
  System.Void Grow()
  System.Boolean TextEquals(System.String str1, System.Char[] str2, System.Int32 str2Start, System.Int32 str2Length)
END_CLASS

CLASS: Newtonsoft.Json.DefaultValueHandling
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.DefaultValueHandlingInclude  // 0x0
  public    static  Newtonsoft.Json.DefaultValueHandlingIgnore  // 0x0
  public    static  Newtonsoft.Json.DefaultValueHandlingPopulate  // 0x0
  public    static  Newtonsoft.Json.DefaultValueHandlingIgnoreAndPopulate  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.FloatFormatHandling
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.FloatFormatHandlingString  // 0x0
  public    static  Newtonsoft.Json.FloatFormatHandlingSymbol  // 0x0
  public    static  Newtonsoft.Json.FloatFormatHandlingDefaultValue  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.FloatParseHandling
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.FloatParseHandlingDouble  // 0x0
  public    static  Newtonsoft.Json.FloatParseHandlingDecimal  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Formatting
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Formatting      None  // 0x0
  public    static  Newtonsoft.Json.Formatting      Indented  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.IArrayPool`1
TYPE:  interface
TOKEN: 0x2000012
FIELDS:
METHODS:
  T[] Rent(System.Int32 minimumLength)
  System.Void Return(T[] array)
END_CLASS

CLASS: Newtonsoft.Json.IJsonLineInfo
TYPE:  interface
TOKEN: 0x2000013
FIELDS:
METHODS:
  System.Boolean HasLineInfo()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
END_CLASS

CLASS: Newtonsoft.Json.JsonArrayAttribute
TYPE:  class
TOKEN: 0x2000014
EXTENDS: JsonContainerAttribute
FIELDS:
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonConstructorAttribute
TYPE:  class
TOKEN: 0x2000015
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonContainerAttribute
TYPE:  class
TOKEN: 0x2000016
EXTENDS: Attribute
FIELDS:
  private           System.Type                     <ItemConverterType>k__BackingField  // 0x10
  private           System.Object[]                 <ItemConverterParameters>k__BackingField  // 0x18
  private           Newtonsoft.Json.Serialization.NamingStrategy<NamingStrategyInstance>k__BackingField  // 0x20
  private           System.Nullable<System.Boolean> _isReference  // 0x28
  private           System.Nullable<System.Boolean> _itemIsReference  // 0x2A
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>_itemReferenceLoopHandling  // 0x2C
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling>_itemTypeNameHandling  // 0x34
  private           System.Type                     _namingStrategyType  // 0x40
  private           System.Object[]                 _namingStrategyParameters  // 0x48
METHODS:
  System.Type get_ItemConverterType()
  System.Object[] get_ItemConverterParameters()
  System.Type get_NamingStrategyType()
  System.Object[] get_NamingStrategyParameters()
  Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategyInstance()
  System.Void set_NamingStrategyInstance(Newtonsoft.Json.Serialization.NamingStrategy value)
END_CLASS

CLASS: Newtonsoft.Json.JsonConvert
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private   static  System.Func<Newtonsoft.Json.JsonSerializerSettings><DefaultSettings>k__BackingField  // 0x0
  public    static readonly System.String                   True  // 0x8
  public    static readonly System.String                   False  // 0x10
  public    static readonly System.String                   Null  // 0x18
  public    static readonly System.String                   Undefined  // 0x20
  public    static readonly System.String                   PositiveInfinity  // 0x28
  public    static readonly System.String                   NegativeInfinity  // 0x30
  public    static readonly System.String                   NaN  // 0x38
METHODS:
  System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings()
  System.String ToString(System.Boolean value)
  System.String ToString(System.Char value)
  System.String ToString(System.Single value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable)
  System.String EnsureFloatFormat(System.Double value, System.String text, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable)
  System.String ToString(System.Double value, Newtonsoft.Json.FloatFormatHandling floatFormatHandling, System.Char quoteChar, System.Boolean nullable)
  System.String EnsureDecimalPlace(System.Double value, System.String text)
  System.String EnsureDecimalPlace(System.String text)
  System.String ToString(System.Decimal value)
  System.String ToString(System.String value)
  System.String ToString(System.String value, System.Char delimiter)
  System.String ToString(System.String value, System.Char delimiter, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling)
  System.String SerializeObject(System.Object value)
  System.String SerializeObject(System.Object value, Newtonsoft.Json.Formatting formatting)
  System.String SerializeObject(System.Object value, Newtonsoft.Json.JsonSerializerSettings settings)
  System.String SerializeObject(System.Object value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings)
  System.String SerializeObject(System.Object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings)
  System.String SerializeObject(System.Object value, System.Type type, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings)
  System.String SerializeObjectInternal(System.Object value, System.Type type, Newtonsoft.Json.JsonSerializer jsonSerializer)
  System.Object DeserializeObject(System.String value)
  System.Object DeserializeObject(System.String value, System.Type type)
  T DeserializeObject(System.String value)
  T DeserializeObject(System.String value, Newtonsoft.Json.JsonSerializerSettings settings)
  System.Object DeserializeObject(System.String value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings)
  System.Void PopulateObject(System.String value, System.Object target, Newtonsoft.Json.JsonSerializerSettings settings)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonConverter
TYPE:  class
TOKEN: 0x2000018
FIELDS:
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Boolean CanConvert(System.Type objectType)
  System.Boolean get_CanRead()
  System.Boolean get_CanWrite()
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonConverter`1
TYPE:  class
TOKEN: 0x2000019
EXTENDS: JsonConverter
FIELDS:
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, T value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  T ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, T existingValue, System.Boolean hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Boolean CanConvert(System.Type objectType)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonConverterAttribute
TYPE:  class
TOKEN: 0x200001A
EXTENDS: Attribute
FIELDS:
  private   readonly System.Type                     _converterType  // 0x10
  private   readonly System.Object[]                 <ConverterParameters>k__BackingField  // 0x18
METHODS:
  System.Type get_ConverterType()
  System.Object[] get_ConverterParameters()
END_CLASS

CLASS: Newtonsoft.Json.JsonConverterCollection
TYPE:  class
TOKEN: 0x200001B
EXTENDS: Collection`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonDictionaryAttribute
TYPE:  class
TOKEN: 0x200001C
EXTENDS: JsonContainerAttribute
FIELDS:
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonException
TYPE:  class
TOKEN: 0x200001D
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: Newtonsoft.Json.JsonExtensionDataAttribute
TYPE:  class
TOKEN: 0x200001E
EXTENDS: Attribute
FIELDS:
  private           System.Boolean                  <WriteData>k__BackingField  // 0x10
  private           System.Boolean                  <ReadData>k__BackingField  // 0x11
METHODS:
  System.Boolean get_WriteData()
  System.Boolean get_ReadData()
END_CLASS

CLASS: Newtonsoft.Json.JsonIgnoreAttribute
TYPE:  class
TOKEN: 0x200001F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonNameTable
TYPE:  class
TOKEN: 0x2000020
FIELDS:
METHODS:
  System.String Get(System.Char[] key, System.Int32 start, System.Int32 length)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonObjectAttribute
TYPE:  class
TOKEN: 0x2000021
EXTENDS: JsonContainerAttribute
FIELDS:
  private           Newtonsoft.Json.MemberSerialization_memberSerialization  // 0x50
  private           System.Nullable<Newtonsoft.Json.MissingMemberHandling>_missingMemberHandling  // 0x54
  private           System.Nullable<Newtonsoft.Json.Required>_itemRequired  // 0x5C
  private           System.Nullable<Newtonsoft.Json.NullValueHandling>_itemNullValueHandling  // 0x64
METHODS:
  Newtonsoft.Json.MemberSerialization get_MemberSerialization()
END_CLASS

CLASS: Newtonsoft.Json.JsonContainerType
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.JsonContainerTypeNone  // 0x0
  public    static  Newtonsoft.Json.JsonContainerTypeObject  // 0x0
  public    static  Newtonsoft.Json.JsonContainerTypeArray  // 0x0
  public    static  Newtonsoft.Json.JsonContainerTypeConstructor  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonPosition
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  private   static readonly System.Char[]                   SpecialCharacters  // 0x0
  private           Newtonsoft.Json.JsonContainerTypeType  // 0x10
  private           System.Int32                    Position  // 0x14
  private           System.String                   PropertyName  // 0x18
  private           System.Boolean                  HasIndex  // 0x20
METHODS:
  System.Void .ctor(Newtonsoft.Json.JsonContainerType type)
  System.Int32 CalculateLength()
  System.Void WriteTo(System.Text.StringBuilder sb, System.IO.StringWriter& writer, System.Char[]& buffer)
  System.Boolean TypeHasIndex(Newtonsoft.Json.JsonContainerType type)
  System.String BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition)
  System.String FormatMessage(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.JsonPropertyAttribute
TYPE:  class
TOKEN: 0x2000024
EXTENDS: Attribute
FIELDS:
  private           System.Nullable<Newtonsoft.Json.NullValueHandling>_nullValueHandling  // 0x10
  private           System.Nullable<Newtonsoft.Json.DefaultValueHandling>_defaultValueHandling  // 0x18
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>_referenceLoopHandling  // 0x20
  private           System.Nullable<Newtonsoft.Json.ObjectCreationHandling>_objectCreationHandling  // 0x28
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling>_typeNameHandling  // 0x30
  private           System.Nullable<System.Boolean> _isReference  // 0x38
  private           System.Nullable<System.Int32>   _order  // 0x3C
  private           System.Nullable<Newtonsoft.Json.Required>_required  // 0x44
  private           System.Nullable<System.Boolean> _itemIsReference  // 0x4C
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>_itemReferenceLoopHandling  // 0x50
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling>_itemTypeNameHandling  // 0x58
  private           System.Type                     <ItemConverterType>k__BackingField  // 0x60
  private           System.Object[]                 <ItemConverterParameters>k__BackingField  // 0x68
  private           System.Type                     <NamingStrategyType>k__BackingField  // 0x70
  private           System.Object[]                 <NamingStrategyParameters>k__BackingField  // 0x78
  private           System.String                   <PropertyName>k__BackingField  // 0x80
METHODS:
  System.Type get_ItemConverterType()
  System.Object[] get_ItemConverterParameters()
  System.Type get_NamingStrategyType()
  System.Object[] get_NamingStrategyParameters()
  System.Void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value)
  System.Void set_Order(System.Int32 value)
  System.String get_PropertyName()
  System.Void set_PropertyName(System.String value)
  System.Void .ctor()
  System.Void .ctor(System.String propertyName)
END_CLASS

CLASS: Newtonsoft.Json.JsonReader
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  private           Newtonsoft.Json.JsonToken       _tokenType  // 0x10
  private           System.Object                   _value  // 0x18
  private           System.Char                     _quoteChar  // 0x20
  private           Newtonsoft.Json.JsonReader.State_currentState  // 0x24
  private           Newtonsoft.Json.JsonPosition    _currentPosition  // 0x28
  private           System.Globalization.CultureInfo_culture  // 0x40
  private           Newtonsoft.Json.DateTimeZoneHandling_dateTimeZoneHandling  // 0x48
  private           System.Nullable<System.Int32>   _maxDepth  // 0x4C
  private           System.Boolean                  _hasExceededMaxDepth  // 0x54
  private           Newtonsoft.Json.DateParseHandling_dateParseHandling  // 0x58
  private           Newtonsoft.Json.FloatParseHandling_floatParseHandling  // 0x5C
  private           System.String                   _dateFormatString  // 0x60
  private           System.Collections.Generic.List<Newtonsoft.Json.JsonPosition>_stack  // 0x68
  private           System.Boolean                  <CloseInput>k__BackingField  // 0x70
  private           System.Boolean                  <SupportMultipleContent>k__BackingField  // 0x71
METHODS:
  Newtonsoft.Json.JsonReader.State get_CurrentState()
  System.Boolean get_CloseInput()
  System.Void set_CloseInput(System.Boolean value)
  System.Boolean get_SupportMultipleContent()
  System.Void set_SupportMultipleContent(System.Boolean value)
  Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling()
  System.Void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value)
  Newtonsoft.Json.DateParseHandling get_DateParseHandling()
  System.Void set_DateParseHandling(Newtonsoft.Json.DateParseHandling value)
  Newtonsoft.Json.FloatParseHandling get_FloatParseHandling()
  System.Void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling value)
  System.String get_DateFormatString()
  System.Void set_DateFormatString(System.String value)
  System.Nullable<System.Int32> get_MaxDepth()
  System.Void set_MaxDepth(System.Nullable<System.Int32> value)
  Newtonsoft.Json.JsonToken get_TokenType()
  System.Object get_Value()
  System.Type get_ValueType()
  System.Int32 get_Depth()
  System.String get_Path()
  System.Globalization.CultureInfo get_Culture()
  System.Void set_Culture(System.Globalization.CultureInfo value)
  Newtonsoft.Json.JsonPosition GetPosition(System.Int32 depth)
  System.Void .ctor()
  System.Void Push(Newtonsoft.Json.JsonContainerType value)
  Newtonsoft.Json.JsonContainerType Pop()
  Newtonsoft.Json.JsonContainerType Peek()
  System.Boolean Read()
  System.Nullable<System.Int32> ReadAsInt32()
  System.Nullable<System.Int32> ReadInt32String(System.String s)
  System.String ReadAsString()
  System.Byte[] ReadAsBytes()
  System.Byte[] ReadArrayIntoByteArray()
  System.Boolean ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<System.Byte> buffer)
  System.Nullable<System.Double> ReadAsDouble()
  System.Nullable<System.Double> ReadDoubleString(System.String s)
  System.Nullable<System.Boolean> ReadAsBoolean()
  System.Nullable<System.Boolean> ReadBooleanString(System.String s)
  System.Nullable<System.Decimal> ReadAsDecimal()
  System.Nullable<System.Decimal> ReadDecimalString(System.String s)
  System.Nullable<System.DateTime> ReadAsDateTime()
  System.Nullable<System.DateTime> ReadDateTimeString(System.String s)
  System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset()
  System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(System.String s)
  System.Void ReaderReadAndAssert()
  Newtonsoft.Json.JsonReaderException CreateUnexpectedEndException()
  System.Void ReadIntoWrappedTypeObject()
  System.Void Skip()
  System.Void SetToken(Newtonsoft.Json.JsonToken newToken)
  System.Void SetToken(Newtonsoft.Json.JsonToken newToken, System.Object value)
  System.Void SetToken(Newtonsoft.Json.JsonToken newToken, System.Object value, System.Boolean updateIndex)
  System.Void SetPostValueState(System.Boolean updateIndex)
  System.Void UpdateScopeWithFinishedValue()
  System.Void ValidateEnd(Newtonsoft.Json.JsonToken endToken)
  System.Void SetStateBasedOnCurrent()
  System.Void SetFinished()
  Newtonsoft.Json.JsonContainerType GetTypeForCloseToken(Newtonsoft.Json.JsonToken token)
  System.Void System.IDisposable.Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Close()
  System.Void ReadAndAssert()
  System.Void ReadForTypeAndAssert(Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean hasConverter)
  System.Boolean ReadForType(Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean hasConverter)
  System.Boolean ReadAndMoveToContent()
  System.Boolean MoveToContent()
  Newtonsoft.Json.JsonToken GetContentToken()
END_CLASS

CLASS: Newtonsoft.Json.JsonReaderException
TYPE:  class
TOKEN: 0x2000027
EXTENDS: JsonException
FIELDS:
  private   readonly System.Int32                    <LineNumber>k__BackingField  // 0x90
  private   readonly System.Int32                    <LinePosition>k__BackingField  // 0x94
  private   readonly System.String                   <Path>k__BackingField  // 0x98
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor(System.String message, System.String path, System.Int32 lineNumber, System.Int32 linePosition, System.Exception innerException)
  Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, System.String message)
  Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.JsonReader reader, System.String message, System.Exception ex)
  Newtonsoft.Json.JsonReaderException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message, System.Exception ex)
END_CLASS

CLASS: Newtonsoft.Json.JsonRequiredAttribute
TYPE:  class
TOKEN: 0x2000028
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonSerializationException
TYPE:  class
TOKEN: 0x2000029
EXTENDS: JsonException
FIELDS:
  private   readonly System.Int32                    <LineNumber>k__BackingField  // 0x90
  private   readonly System.Int32                    <LinePosition>k__BackingField  // 0x94
  private   readonly System.String                   <Path>k__BackingField  // 0x98
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor(System.String message, System.String path, System.Int32 lineNumber, System.Int32 linePosition, System.Exception innerException)
  Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, System.String message)
  Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.JsonReader reader, System.String message, System.Exception ex)
  Newtonsoft.Json.JsonSerializationException Create(Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.String message, System.Exception ex)
END_CLASS

CLASS: Newtonsoft.Json.JsonSerializer
TYPE:  class
TOKEN: 0x200002A
FIELDS:
  private           Newtonsoft.Json.TypeNameHandling_typeNameHandling  // 0x10
  private           Newtonsoft.Json.TypeNameAssemblyFormatHandling_typeNameAssemblyFormatHandling  // 0x14
  private           Newtonsoft.Json.PreserveReferencesHandling_preserveReferencesHandling  // 0x18
  private           Newtonsoft.Json.ReferenceLoopHandling_referenceLoopHandling  // 0x1C
  private           Newtonsoft.Json.MissingMemberHandling_missingMemberHandling  // 0x20
  private           Newtonsoft.Json.ObjectCreationHandling_objectCreationHandling  // 0x24
  private           Newtonsoft.Json.NullValueHandling_nullValueHandling  // 0x28
  private           Newtonsoft.Json.DefaultValueHandling_defaultValueHandling  // 0x2C
  private           Newtonsoft.Json.ConstructorHandling_constructorHandling  // 0x30
  private           Newtonsoft.Json.MetadataPropertyHandling_metadataPropertyHandling  // 0x34
  private           Newtonsoft.Json.JsonConverterCollection_converters  // 0x38
  private           Newtonsoft.Json.Serialization.IContractResolver_contractResolver  // 0x40
  private           Newtonsoft.Json.Serialization.ITraceWriter_traceWriter  // 0x48
  private           System.Collections.IEqualityComparer_equalityComparer  // 0x50
  private           Newtonsoft.Json.Serialization.ISerializationBinder_serializationBinder  // 0x58
  private           System.Runtime.Serialization.StreamingContext_context  // 0x60
  private           Newtonsoft.Json.Serialization.IReferenceResolver_referenceResolver  // 0x70
  private           System.Nullable<Newtonsoft.Json.Formatting>_formatting  // 0x78
  private           System.Nullable<Newtonsoft.Json.DateFormatHandling>_dateFormatHandling  // 0x80
  private           System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>_dateTimeZoneHandling  // 0x88
  private           System.Nullable<Newtonsoft.Json.DateParseHandling>_dateParseHandling  // 0x90
  private           System.Nullable<Newtonsoft.Json.FloatFormatHandling>_floatFormatHandling  // 0x98
  private           System.Nullable<Newtonsoft.Json.FloatParseHandling>_floatParseHandling  // 0xA0
  private           System.Nullable<Newtonsoft.Json.StringEscapeHandling>_stringEscapeHandling  // 0xA8
  private           System.Globalization.CultureInfo_culture  // 0xB0
  private           System.Nullable<System.Int32>   _maxDepth  // 0xB8
  private           System.Boolean                  _maxDepthSet  // 0xC0
  private           System.Nullable<System.Boolean> _checkAdditionalContent  // 0xC1
  private           System.String                   _dateFormatString  // 0xC8
  private           System.Boolean                  _dateFormatStringSet  // 0xD0
  private           System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>Error  // 0xD8
METHODS:
  System.Void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value)
  System.Void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value)
  System.Void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value)
  System.Void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value)
  Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter()
  System.Void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value)
  System.Void set_EqualityComparer(System.Collections.IEqualityComparer value)
  System.Void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value)
  System.Void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value)
  System.Void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value)
  System.Void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value)
  System.Void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value)
  Newtonsoft.Json.NullValueHandling get_NullValueHandling()
  System.Void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value)
  System.Void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value)
  System.Void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value)
  System.Void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value)
  Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling()
  System.Void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value)
  Newtonsoft.Json.JsonConverterCollection get_Converters()
  Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver()
  System.Void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value)
  System.Runtime.Serialization.StreamingContext get_Context()
  System.Void set_Context(System.Runtime.Serialization.StreamingContext value)
  Newtonsoft.Json.Formatting get_Formatting()
  System.Void set_Formatting(Newtonsoft.Json.Formatting value)
  System.Nullable<System.Int32> get_MaxDepth()
  System.Boolean get_CheckAdditionalContent()
  System.Void set_CheckAdditionalContent(System.Boolean value)
  System.Boolean IsCheckAdditionalContentSet()
  System.Void .ctor()
  Newtonsoft.Json.JsonSerializer Create()
  Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings settings)
  Newtonsoft.Json.JsonSerializer CreateDefault()
  Newtonsoft.Json.JsonSerializer CreateDefault(Newtonsoft.Json.JsonSerializerSettings settings)
  System.Void ApplySerializerSettings(Newtonsoft.Json.JsonSerializer serializer, Newtonsoft.Json.JsonSerializerSettings settings)
  System.Void Populate(Newtonsoft.Json.JsonReader reader, System.Object target)
  System.Void PopulateInternal(Newtonsoft.Json.JsonReader reader, System.Object target)
  T Deserialize(Newtonsoft.Json.JsonReader reader)
  System.Object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType)
  System.Object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType)
  System.Void SetupReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo& previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>& previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling>& previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling>& previousFloatParseHandling, System.Nullable<System.Int32>& previousMaxDepth, System.String& previousDateFormatString)
  System.Void ResetReader(Newtonsoft.Json.JsonReader reader, System.Globalization.CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<System.Int32> previousMaxDepth, System.String previousDateFormatString)
  System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType)
  System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value)
  Newtonsoft.Json.Serialization.TraceJsonReader CreateTraceJsonReader(Newtonsoft.Json.JsonReader reader)
  System.Void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType)
  Newtonsoft.Json.Serialization.IReferenceResolver GetReferenceResolver()
  Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Type type)
  Newtonsoft.Json.JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, System.Type objectType)
  System.Void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e)
END_CLASS

CLASS: Newtonsoft.Json.JsonSerializerSettings
TYPE:  class
TOKEN: 0x200002B
FIELDS:
  private   static  Newtonsoft.Json.ReferenceLoopHandlingDefaultReferenceLoopHandling  // 0x0
  private   static  Newtonsoft.Json.MissingMemberHandlingDefaultMissingMemberHandling  // 0x0
  private   static  Newtonsoft.Json.NullValueHandlingDefaultNullValueHandling  // 0x0
  private   static  Newtonsoft.Json.DefaultValueHandlingDefaultDefaultValueHandling  // 0x0
  private   static  Newtonsoft.Json.ObjectCreationHandlingDefaultObjectCreationHandling  // 0x0
  private   static  Newtonsoft.Json.PreserveReferencesHandlingDefaultPreserveReferencesHandling  // 0x0
  private   static  Newtonsoft.Json.ConstructorHandlingDefaultConstructorHandling  // 0x0
  private   static  Newtonsoft.Json.TypeNameHandlingDefaultTypeNameHandling  // 0x0
  private   static  Newtonsoft.Json.MetadataPropertyHandlingDefaultMetadataPropertyHandling  // 0x0
  private   static readonly System.Runtime.Serialization.StreamingContextDefaultContext  // 0x0
  private   static  Newtonsoft.Json.Formatting      DefaultFormatting  // 0x0
  private   static  Newtonsoft.Json.DateFormatHandlingDefaultDateFormatHandling  // 0x0
  private   static  Newtonsoft.Json.DateTimeZoneHandlingDefaultDateTimeZoneHandling  // 0x0
  private   static  Newtonsoft.Json.DateParseHandlingDefaultDateParseHandling  // 0x0
  private   static  Newtonsoft.Json.FloatParseHandlingDefaultFloatParseHandling  // 0x0
  private   static  Newtonsoft.Json.FloatFormatHandlingDefaultFloatFormatHandling  // 0x0
  private   static  Newtonsoft.Json.StringEscapeHandlingDefaultStringEscapeHandling  // 0x0
  private   static  Newtonsoft.Json.TypeNameAssemblyFormatHandlingDefaultTypeNameAssemblyFormatHandling  // 0x0
  private   static readonly System.Globalization.CultureInfoDefaultCulture  // 0x10
  private   static  System.Boolean                  DefaultCheckAdditionalContent  // 0x0
  private   static  System.String                   DefaultDateFormatString  // 0x0
  private   static  System.Int32                    DefaultMaxDepth  // 0x0
  private           System.Nullable<Newtonsoft.Json.Formatting>_formatting  // 0x10
  private           System.Nullable<Newtonsoft.Json.DateFormatHandling>_dateFormatHandling  // 0x18
  private           System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>_dateTimeZoneHandling  // 0x20
  private           System.Nullable<Newtonsoft.Json.DateParseHandling>_dateParseHandling  // 0x28
  private           System.Nullable<Newtonsoft.Json.FloatFormatHandling>_floatFormatHandling  // 0x30
  private           System.Nullable<Newtonsoft.Json.FloatParseHandling>_floatParseHandling  // 0x38
  private           System.Nullable<Newtonsoft.Json.StringEscapeHandling>_stringEscapeHandling  // 0x40
  private           System.Globalization.CultureInfo_culture  // 0x48
  private           System.Nullable<System.Boolean> _checkAdditionalContent  // 0x50
  private           System.Nullable<System.Int32>   _maxDepth  // 0x54
  private           System.Boolean                  _maxDepthSet  // 0x5C
  private           System.String                   _dateFormatString  // 0x60
  private           System.Boolean                  _dateFormatStringSet  // 0x68
  private           System.Nullable<Newtonsoft.Json.TypeNameAssemblyFormatHandling>_typeNameAssemblyFormatHandling  // 0x6C
  private           System.Nullable<Newtonsoft.Json.DefaultValueHandling>_defaultValueHandling  // 0x74
  private           System.Nullable<Newtonsoft.Json.PreserveReferencesHandling>_preserveReferencesHandling  // 0x7C
  private           System.Nullable<Newtonsoft.Json.NullValueHandling>_nullValueHandling  // 0x84
  private           System.Nullable<Newtonsoft.Json.ObjectCreationHandling>_objectCreationHandling  // 0x8C
  private           System.Nullable<Newtonsoft.Json.MissingMemberHandling>_missingMemberHandling  // 0x94
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>_referenceLoopHandling  // 0x9C
  private           System.Nullable<System.Runtime.Serialization.StreamingContext>_context  // 0xA8
  private           System.Nullable<Newtonsoft.Json.ConstructorHandling>_constructorHandling  // 0xC0
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling>_typeNameHandling  // 0xC8
  private           System.Nullable<Newtonsoft.Json.MetadataPropertyHandling>_metadataPropertyHandling  // 0xD0
  private           System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter><Converters>k__BackingField  // 0xD8
  private           Newtonsoft.Json.Serialization.IContractResolver<ContractResolver>k__BackingField  // 0xE0
  private           System.Collections.IEqualityComparer<EqualityComparer>k__BackingField  // 0xE8
  private           System.Func<Newtonsoft.Json.Serialization.IReferenceResolver><ReferenceResolverProvider>k__BackingField  // 0xF0
  private           Newtonsoft.Json.Serialization.ITraceWriter<TraceWriter>k__BackingField  // 0xF8
  private           Newtonsoft.Json.Serialization.ISerializationBinder<SerializationBinder>k__BackingField  // 0x100
  private           System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs><Error>k__BackingField  // 0x108
METHODS:
  Newtonsoft.Json.ReferenceLoopHandling get_ReferenceLoopHandling()
  System.Void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value)
  Newtonsoft.Json.MissingMemberHandling get_MissingMemberHandling()
  Newtonsoft.Json.ObjectCreationHandling get_ObjectCreationHandling()
  System.Void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value)
  Newtonsoft.Json.NullValueHandling get_NullValueHandling()
  System.Void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value)
  Newtonsoft.Json.DefaultValueHandling get_DefaultValueHandling()
  System.Void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value)
  System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters()
  System.Void set_Converters(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> value)
  Newtonsoft.Json.PreserveReferencesHandling get_PreserveReferencesHandling()
  Newtonsoft.Json.TypeNameHandling get_TypeNameHandling()
  System.Void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value)
  Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling()
  Newtonsoft.Json.TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling()
  System.Void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value)
  Newtonsoft.Json.ConstructorHandling get_ConstructorHandling()
  System.Void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value)
  Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver()
  System.Void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value)
  System.Collections.IEqualityComparer get_EqualityComparer()
  System.Void set_EqualityComparer(System.Collections.IEqualityComparer value)
  System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider()
  System.Void set_ReferenceResolverProvider(System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> value)
  Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter()
  System.Void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value)
  Newtonsoft.Json.Serialization.ISerializationBinder get_SerializationBinder()
  System.Void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value)
  System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error()
  System.Void set_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value)
  System.Runtime.Serialization.StreamingContext get_Context()
  System.Void set_MaxDepth(System.Nullable<System.Int32> value)
  System.Void set_Formatting(Newtonsoft.Json.Formatting value)
  System.Boolean get_CheckAdditionalContent()
  System.Void .cctor()
  System.Void .ctor()
  System.Void .ctor(Newtonsoft.Json.JsonSerializerSettings original)
END_CLASS

CLASS: Newtonsoft.Json.JsonTextReader
TYPE:  class
TOKEN: 0x200002C
EXTENDS: JsonReader
FIELDS:
  private   readonly System.Boolean                  _safeAsync  // 0x78
  private   readonly System.IO.TextReader            _reader  // 0x80
  private           System.Char[]                   _chars  // 0x88
  private           System.Int32                    _charsUsed  // 0x90
  private           System.Int32                    _charPos  // 0x94
  private           System.Int32                    _lineStartPos  // 0x98
  private           System.Int32                    _lineNumber  // 0x9C
  private           System.Boolean                  _isEndOfFile  // 0xA0
  private           Newtonsoft.Json.Utilities.StringBuffer_stringBuffer  // 0xA8
  private           Newtonsoft.Json.Utilities.StringReference_stringReference  // 0xB8
  private           Newtonsoft.Json.IArrayPool<System.Char>_arrayPool  // 0xC8
  private           Newtonsoft.Json.JsonNameTable   <PropertyNameTable>k__BackingField  // 0xD0
METHODS:
  System.Void .ctor(System.IO.TextReader reader)
  Newtonsoft.Json.JsonNameTable get_PropertyNameTable()
  System.Void set_PropertyNameTable(Newtonsoft.Json.JsonNameTable value)
  System.Void EnsureBufferNotEmpty()
  System.Void SetNewLine(System.Boolean hasNextChar)
  System.Void OnNewLine(System.Int32 pos)
  System.Void ParseString(System.Char quote, Newtonsoft.Json.ReadType readType)
  System.Void ParseReadString(System.Char quote, Newtonsoft.Json.ReadType readType)
  System.Void BlockCopyChars(System.Char[] src, System.Int32 srcOffset, System.Char[] dst, System.Int32 dstOffset, System.Int32 count)
  System.Void ShiftBufferIfNeeded()
  System.Int32 ReadData(System.Boolean append)
  System.Void PrepareBufferForReadData(System.Boolean append, System.Int32 charsRequired)
  System.Int32 ReadData(System.Boolean append, System.Int32 charsRequired)
  System.Boolean EnsureChars(System.Int32 relativePosition, System.Boolean append)
  System.Boolean ReadChars(System.Int32 relativePosition, System.Boolean append)
  System.Boolean Read()
  System.Nullable<System.Int32> ReadAsInt32()
  System.Nullable<System.DateTime> ReadAsDateTime()
  System.String ReadAsString()
  System.Byte[] ReadAsBytes()
  System.Object ReadStringValue(Newtonsoft.Json.ReadType readType)
  System.Object FinishReadQuotedStringValue(Newtonsoft.Json.ReadType readType)
  Newtonsoft.Json.JsonReaderException CreateUnexpectedCharacterException(System.Char c)
  System.Nullable<System.Boolean> ReadAsBoolean()
  System.Void ProcessValueComma()
  System.Object ReadNumberValue(Newtonsoft.Json.ReadType readType)
  System.Object FinishReadQuotedNumber(Newtonsoft.Json.ReadType readType)
  System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset()
  System.Nullable<System.Decimal> ReadAsDecimal()
  System.Nullable<System.Double> ReadAsDouble()
  System.Void HandleNull()
  System.Void ReadFinished()
  System.Boolean ReadNullChar()
  System.Void EnsureBuffer()
  System.Void ReadStringIntoBuffer(System.Char quote)
  System.Void FinishReadStringIntoBuffer(System.Int32 charPos, System.Int32 initialPosition, System.Int32 lastWritePosition)
  System.Void WriteCharToBuffer(System.Char writeChar, System.Int32 lastWritePosition, System.Int32 writeToPosition)
  System.Char ConvertUnicode(System.Boolean enoughChars)
  System.Char ParseUnicode()
  System.Void ReadNumberIntoBuffer()
  System.Boolean ReadNumberCharIntoBuffer(System.Char currentChar, System.Int32 charPos)
  System.Void ClearRecentString()
  System.Boolean ParsePostValue(System.Boolean ignoreComments)
  System.Boolean ParseObject()
  System.Boolean ParseProperty()
  System.Boolean ValidIdentifierChar(System.Char value)
  System.Void ParseUnquotedProperty()
  System.Boolean ReadUnquotedPropertyReportIfDone(System.Char currentChar, System.Int32 initialPosition)
  System.Boolean ParseValue()
  System.Void ProcessLineFeed()
  System.Void ProcessCarriageReturn(System.Boolean append)
  System.Void EatWhitespace()
  System.Void ParseConstructor()
  System.Void ParseNumber(Newtonsoft.Json.ReadType readType)
  System.Void ParseReadNumber(Newtonsoft.Json.ReadType readType, System.Char firstChar, System.Int32 initialPosition)
  Newtonsoft.Json.JsonReaderException ThrowReaderError(System.String message, System.Exception ex)
  System.Object BigIntegerParse(System.String number, System.Globalization.CultureInfo culture)
  System.Void ParseComment(System.Boolean setToken)
  System.Void EndComment(System.Boolean setToken, System.Int32 initialPosition, System.Int32 endPosition)
  System.Boolean MatchValue(System.String value)
  System.Boolean MatchValue(System.Boolean enoughChars, System.String value)
  System.Boolean MatchValueWithTrailingSeparator(System.String value)
  System.Boolean IsSeparator(System.Char c)
  System.Void ParseTrue()
  System.Void ParseNull()
  System.Void ParseUndefined()
  System.Void ParseFalse()
  System.Object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType)
  System.Object ParseNumberNegativeInfinity(Newtonsoft.Json.ReadType readType, System.Boolean matched)
  System.Object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType)
  System.Object ParseNumberPositiveInfinity(Newtonsoft.Json.ReadType readType, System.Boolean matched)
  System.Object ParseNumberNaN(Newtonsoft.Json.ReadType readType)
  System.Object ParseNumberNaN(Newtonsoft.Json.ReadType readType, System.Boolean matched)
  System.Void Close()
  System.Boolean HasLineInfo()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
END_CLASS

CLASS: Newtonsoft.Json.ReadType
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.ReadType        Read  // 0x0
  public    static  Newtonsoft.Json.ReadType        ReadAsInt32  // 0x0
  public    static  Newtonsoft.Json.ReadType        ReadAsInt64  // 0x0
  public    static  Newtonsoft.Json.ReadType        ReadAsBytes  // 0x0
  public    static  Newtonsoft.Json.ReadType        ReadAsString  // 0x0
  public    static  Newtonsoft.Json.ReadType        ReadAsDecimal  // 0x0
  public    static  Newtonsoft.Json.ReadType        ReadAsDateTime  // 0x0
  public    static  Newtonsoft.Json.ReadType        ReadAsDateTimeOffset  // 0x0
  public    static  Newtonsoft.Json.ReadType        ReadAsDouble  // 0x0
  public    static  Newtonsoft.Json.ReadType        ReadAsBoolean  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonTextWriter
TYPE:  class
TOKEN: 0x200002E
EXTENDS: JsonWriter
FIELDS:
  private   readonly System.Boolean                  _safeAsync  // 0x60
  private   readonly System.IO.TextWriter            _writer  // 0x68
  private           Newtonsoft.Json.Utilities.Base64Encoder_base64Encoder  // 0x70
  private           System.Char                     _indentChar  // 0x78
  private           System.Int32                    _indentation  // 0x7C
  private           System.Char                     _quoteChar  // 0x80
  private           System.Boolean                  _quoteName  // 0x82
  private           System.Boolean[]                _charEscapeFlags  // 0x88
  private           System.Char[]                   _writeBuffer  // 0x90
  private           Newtonsoft.Json.IArrayPool<System.Char>_arrayPool  // 0x98
  private           System.Char[]                   _indentChars  // 0xA0
METHODS:
  Newtonsoft.Json.Utilities.Base64Encoder get_Base64Encoder()
  System.Char get_QuoteChar()
  System.Void .ctor(System.IO.TextWriter textWriter)
  System.Void Close()
  System.Void CloseBufferAndWriter()
  System.Void WriteStartObject()
  System.Void WriteStartArray()
  System.Void WriteStartConstructor(System.String name)
  System.Void WriteEnd(Newtonsoft.Json.JsonToken token)
  System.Void WritePropertyName(System.String name)
  System.Void WritePropertyName(System.String name, System.Boolean escape)
  System.Void OnStringEscapeHandlingChanged()
  System.Void UpdateCharEscapeFlags()
  System.Void WriteIndent()
  System.Int32 SetIndentChars()
  System.Void WriteValueDelimiter()
  System.Void WriteIndentSpace()
  System.Void WriteValueInternal(System.String value, Newtonsoft.Json.JsonToken token)
  System.Void WriteValue(System.Object value)
  System.Void WriteNull()
  System.Void WriteUndefined()
  System.Void WriteRaw(System.String json)
  System.Void WriteValue(System.String value)
  System.Void WriteEscapedString(System.String value, System.Boolean quote)
  System.Void WriteValue(System.Int32 value)
  System.Void WriteValue(System.UInt32 value)
  System.Void WriteValue(System.Int64 value)
  System.Void WriteValue(System.UInt64 value)
  System.Void WriteValue(System.Single value)
  System.Void WriteValue(System.Nullable<System.Single> value)
  System.Void WriteValue(System.Double value)
  System.Void WriteValue(System.Nullable<System.Double> value)
  System.Void WriteValue(System.Boolean value)
  System.Void WriteValue(System.Int16 value)
  System.Void WriteValue(System.UInt16 value)
  System.Void WriteValue(System.Char value)
  System.Void WriteValue(System.Byte value)
  System.Void WriteValue(System.SByte value)
  System.Void WriteValue(System.Decimal value)
  System.Void WriteValue(System.DateTime value)
  System.Int32 WriteValueToBuffer(System.DateTime value)
  System.Void WriteValue(System.Byte[] value)
  System.Void WriteValue(System.DateTimeOffset value)
  System.Int32 WriteValueToBuffer(System.DateTimeOffset value)
  System.Void WriteValue(System.Guid value)
  System.Void WriteValue(System.TimeSpan value)
  System.Void WriteValue(System.Uri value)
  System.Void WriteComment(System.String text)
  System.Void EnsureWriteBuffer()
  System.Void WriteIntegerValue(System.Int64 value)
  System.Void WriteIntegerValue(System.UInt64 value, System.Boolean negative)
  System.Int32 WriteNumberToBuffer(System.UInt64 value, System.Boolean negative)
  System.Void WriteIntegerValue(System.Int32 value)
  System.Void WriteIntegerValue(System.UInt32 value, System.Boolean negative)
  System.Int32 WriteNumberToBuffer(System.UInt32 value, System.Boolean negative)
END_CLASS

CLASS: Newtonsoft.Json.JsonToken
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.JsonToken       None  // 0x0
  public    static  Newtonsoft.Json.JsonToken       StartObject  // 0x0
  public    static  Newtonsoft.Json.JsonToken       StartArray  // 0x0
  public    static  Newtonsoft.Json.JsonToken       StartConstructor  // 0x0
  public    static  Newtonsoft.Json.JsonToken       PropertyName  // 0x0
  public    static  Newtonsoft.Json.JsonToken       Comment  // 0x0
  public    static  Newtonsoft.Json.JsonToken       Raw  // 0x0
  public    static  Newtonsoft.Json.JsonToken       Integer  // 0x0
  public    static  Newtonsoft.Json.JsonToken       Float  // 0x0
  public    static  Newtonsoft.Json.JsonToken       String  // 0x0
  public    static  Newtonsoft.Json.JsonToken       Boolean  // 0x0
  public    static  Newtonsoft.Json.JsonToken       Null  // 0x0
  public    static  Newtonsoft.Json.JsonToken       Undefined  // 0x0
  public    static  Newtonsoft.Json.JsonToken       EndObject  // 0x0
  public    static  Newtonsoft.Json.JsonToken       EndArray  // 0x0
  public    static  Newtonsoft.Json.JsonToken       EndConstructor  // 0x0
  public    static  Newtonsoft.Json.JsonToken       Date  // 0x0
  public    static  Newtonsoft.Json.JsonToken       Bytes  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.JsonWriter
TYPE:  class
TOKEN: 0x2000030
FIELDS:
  private   static readonly Newtonsoft.Json.JsonWriter.State[][]StateArray  // 0x0
  private   static readonly Newtonsoft.Json.JsonWriter.State[][]StateArrayTemplate  // 0x8
  private           System.Collections.Generic.List<Newtonsoft.Json.JsonPosition>_stack  // 0x10
  private           Newtonsoft.Json.JsonPosition    _currentPosition  // 0x18
  private           Newtonsoft.Json.JsonWriter.State_currentState  // 0x30
  private           Newtonsoft.Json.Formatting      _formatting  // 0x34
  private           System.Boolean                  <CloseOutput>k__BackingField  // 0x38
  private           System.Boolean                  <AutoCompleteOnClose>k__BackingField  // 0x39
  private           Newtonsoft.Json.DateFormatHandling_dateFormatHandling  // 0x3C
  private           Newtonsoft.Json.DateTimeZoneHandling_dateTimeZoneHandling  // 0x40
  private           Newtonsoft.Json.StringEscapeHandling_stringEscapeHandling  // 0x44
  private           Newtonsoft.Json.FloatFormatHandling_floatFormatHandling  // 0x48
  private           System.String                   _dateFormatString  // 0x50
  private           System.Globalization.CultureInfo_culture  // 0x58
METHODS:
  Newtonsoft.Json.JsonWriter.State[][] BuildStateArray()
  System.Void .cctor()
  System.Boolean get_CloseOutput()
  System.Void set_CloseOutput(System.Boolean value)
  System.Boolean get_AutoCompleteOnClose()
  System.Void set_AutoCompleteOnClose(System.Boolean value)
  System.Int32 get_Top()
  Newtonsoft.Json.WriteState get_WriteState()
  System.String get_ContainerPath()
  System.String get_Path()
  Newtonsoft.Json.Formatting get_Formatting()
  System.Void set_Formatting(Newtonsoft.Json.Formatting value)
  Newtonsoft.Json.DateFormatHandling get_DateFormatHandling()
  System.Void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling value)
  Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling()
  System.Void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling value)
  Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling()
  System.Void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling value)
  System.Void OnStringEscapeHandlingChanged()
  Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling()
  System.Void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling value)
  System.String get_DateFormatString()
  System.Void set_DateFormatString(System.String value)
  System.Globalization.CultureInfo get_Culture()
  System.Void set_Culture(System.Globalization.CultureInfo value)
  System.Void .ctor()
  System.Void UpdateScopeWithFinishedValue()
  System.Void Push(Newtonsoft.Json.JsonContainerType value)
  Newtonsoft.Json.JsonContainerType Pop()
  Newtonsoft.Json.JsonContainerType Peek()
  System.Void Close()
  System.Void WriteStartObject()
  System.Void WriteEndObject()
  System.Void WriteStartArray()
  System.Void WriteEndArray()
  System.Void WriteStartConstructor(System.String name)
  System.Void WriteEndConstructor()
  System.Void WritePropertyName(System.String name)
  System.Void WritePropertyName(System.String name, System.Boolean escape)
  System.Void WriteEnd()
  System.Void WriteToken(Newtonsoft.Json.JsonReader reader)
  System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren)
  System.Void WriteToken(Newtonsoft.Json.JsonToken token, System.Object value)
  System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Boolean writeDateConstructorAsDate, System.Boolean writeComments)
  System.Boolean IsWriteTokenIncomplete(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Int32 initialDepth)
  System.Int32 CalculateWriteTokenInitialDepth(Newtonsoft.Json.JsonReader reader)
  System.Int32 CalculateWriteTokenFinalDepth(Newtonsoft.Json.JsonReader reader)
  System.Void WriteConstructorDate(Newtonsoft.Json.JsonReader reader)
  System.Void WriteEnd(Newtonsoft.Json.JsonContainerType type)
  System.Void AutoCompleteAll()
  Newtonsoft.Json.JsonToken GetCloseTokenForType(Newtonsoft.Json.JsonContainerType type)
  System.Void AutoCompleteClose(Newtonsoft.Json.JsonContainerType type)
  System.Int32 CalculateLevelsToComplete(Newtonsoft.Json.JsonContainerType type)
  System.Void UpdateCurrentState()
  System.Void WriteEnd(Newtonsoft.Json.JsonToken token)
  System.Void WriteIndent()
  System.Void WriteValueDelimiter()
  System.Void WriteIndentSpace()
  System.Void AutoComplete(Newtonsoft.Json.JsonToken tokenBeingWritten)
  System.Void WriteNull()
  System.Void WriteUndefined()
  System.Void WriteRaw(System.String json)
  System.Void WriteRawValue(System.String json)
  System.Void WriteValue(System.String value)
  System.Void WriteValue(System.Int32 value)
  System.Void WriteValue(System.UInt32 value)
  System.Void WriteValue(System.Int64 value)
  System.Void WriteValue(System.UInt64 value)
  System.Void WriteValue(System.Single value)
  System.Void WriteValue(System.Double value)
  System.Void WriteValue(System.Boolean value)
  System.Void WriteValue(System.Int16 value)
  System.Void WriteValue(System.UInt16 value)
  System.Void WriteValue(System.Char value)
  System.Void WriteValue(System.Byte value)
  System.Void WriteValue(System.SByte value)
  System.Void WriteValue(System.Decimal value)
  System.Void WriteValue(System.DateTime value)
  System.Void WriteValue(System.DateTimeOffset value)
  System.Void WriteValue(System.Guid value)
  System.Void WriteValue(System.TimeSpan value)
  System.Void WriteValue(System.Nullable<System.Int32> value)
  System.Void WriteValue(System.Nullable<System.UInt32> value)
  System.Void WriteValue(System.Nullable<System.Int64> value)
  System.Void WriteValue(System.Nullable<System.UInt64> value)
  System.Void WriteValue(System.Nullable<System.Single> value)
  System.Void WriteValue(System.Nullable<System.Double> value)
  System.Void WriteValue(System.Nullable<System.Boolean> value)
  System.Void WriteValue(System.Nullable<System.Int16> value)
  System.Void WriteValue(System.Nullable<System.UInt16> value)
  System.Void WriteValue(System.Nullable<System.Char> value)
  System.Void WriteValue(System.Nullable<System.Byte> value)
  System.Void WriteValue(System.Nullable<System.SByte> value)
  System.Void WriteValue(System.Nullable<System.Decimal> value)
  System.Void WriteValue(System.Nullable<System.DateTime> value)
  System.Void WriteValue(System.Nullable<System.DateTimeOffset> value)
  System.Void WriteValue(System.Nullable<System.Guid> value)
  System.Void WriteValue(System.Nullable<System.TimeSpan> value)
  System.Void WriteValue(System.Byte[] value)
  System.Void WriteValue(System.Uri value)
  System.Void WriteValue(System.Object value)
  System.Void WriteComment(System.String text)
  System.Void System.IDisposable.Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void WriteValue(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, System.Object value)
  System.Void ResolveConvertibleValue(System.IConvertible convertible, Newtonsoft.Json.Utilities.PrimitiveTypeCode& typeCode, System.Object& value)
  Newtonsoft.Json.JsonWriterException CreateUnsupportedTypeException(Newtonsoft.Json.JsonWriter writer, System.Object value)
  System.Void SetWriteState(Newtonsoft.Json.JsonToken token, System.Object value)
  System.Void InternalWriteEnd(Newtonsoft.Json.JsonContainerType container)
  System.Void InternalWritePropertyName(System.String name)
  System.Void InternalWriteRaw()
  System.Void InternalWriteStart(Newtonsoft.Json.JsonToken token, Newtonsoft.Json.JsonContainerType container)
  System.Void InternalWriteValue(Newtonsoft.Json.JsonToken token)
  System.Void InternalWriteComment()
END_CLASS

CLASS: Newtonsoft.Json.JsonWriterException
TYPE:  class
TOKEN: 0x2000032
EXTENDS: JsonException
FIELDS:
  private   readonly System.String                   <Path>k__BackingField  // 0x90
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor(System.String message, System.String path, System.Exception innerException)
  Newtonsoft.Json.JsonWriterException Create(Newtonsoft.Json.JsonWriter writer, System.String message, System.Exception ex)
  Newtonsoft.Json.JsonWriterException Create(System.String path, System.String message, System.Exception ex)
END_CLASS

CLASS: Newtonsoft.Json.MemberSerialization
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.MemberSerializationOptOut  // 0x0
  public    static  Newtonsoft.Json.MemberSerializationOptIn  // 0x0
  public    static  Newtonsoft.Json.MemberSerializationFields  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.MetadataPropertyHandling
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.MetadataPropertyHandlingDefault  // 0x0
  public    static  Newtonsoft.Json.MetadataPropertyHandlingReadAhead  // 0x0
  public    static  Newtonsoft.Json.MetadataPropertyHandlingIgnore  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.MissingMemberHandling
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.MissingMemberHandlingIgnore  // 0x0
  public    static  Newtonsoft.Json.MissingMemberHandlingError  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.NullValueHandling
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.NullValueHandlingInclude  // 0x0
  public    static  Newtonsoft.Json.NullValueHandlingIgnore  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.ObjectCreationHandling
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.ObjectCreationHandlingAuto  // 0x0
  public    static  Newtonsoft.Json.ObjectCreationHandlingReuse  // 0x0
  public    static  Newtonsoft.Json.ObjectCreationHandlingReplace  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.PreserveReferencesHandling
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.PreserveReferencesHandlingNone  // 0x0
  public    static  Newtonsoft.Json.PreserveReferencesHandlingObjects  // 0x0
  public    static  Newtonsoft.Json.PreserveReferencesHandlingArrays  // 0x0
  public    static  Newtonsoft.Json.PreserveReferencesHandlingAll  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.ReferenceLoopHandling
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.ReferenceLoopHandlingError  // 0x0
  public    static  Newtonsoft.Json.ReferenceLoopHandlingIgnore  // 0x0
  public    static  Newtonsoft.Json.ReferenceLoopHandlingSerialize  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Required
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Required        Default  // 0x0
  public    static  Newtonsoft.Json.Required        AllowNull  // 0x0
  public    static  Newtonsoft.Json.Required        Always  // 0x0
  public    static  Newtonsoft.Json.Required        DisallowNull  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.StringEscapeHandling
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.StringEscapeHandlingDefault  // 0x0
  public    static  Newtonsoft.Json.StringEscapeHandlingEscapeNonAscii  // 0x0
  public    static  Newtonsoft.Json.StringEscapeHandlingEscapeHtml  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.TypeNameAssemblyFormatHandling
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.TypeNameAssemblyFormatHandlingSimple  // 0x0
  public    static  Newtonsoft.Json.TypeNameAssemblyFormatHandlingFull  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.TypeNameHandling
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.TypeNameHandlingNone  // 0x0
  public    static  Newtonsoft.Json.TypeNameHandlingObjects  // 0x0
  public    static  Newtonsoft.Json.TypeNameHandlingArrays  // 0x0
  public    static  Newtonsoft.Json.TypeNameHandlingAll  // 0x0
  public    static  Newtonsoft.Json.TypeNameHandlingAuto  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.WriteState
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.WriteState      Error  // 0x0
  public    static  Newtonsoft.Json.WriteState      Closed  // 0x0
  public    static  Newtonsoft.Json.WriteState      Object  // 0x0
  public    static  Newtonsoft.Json.WriteState      Array  // 0x0
  public    static  Newtonsoft.Json.WriteState      Constructor  // 0x0
  public    static  Newtonsoft.Json.WriteState      Property  // 0x0
  public    static  Newtonsoft.Json.WriteState      Start  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonObjectId
TYPE:  class
TOKEN: 0x2000122
FIELDS:
  private   readonly System.Byte[]                   <Value>k__BackingField  // 0x10
METHODS:
  System.Byte[] get_Value()
  System.Void .ctor(System.Byte[] value)
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonToken
TYPE:  class
TOKEN: 0x2000123
FIELDS:
  private           Newtonsoft.Json.Bson.BsonToken  <Parent>k__BackingField  // 0x10
METHODS:
  Newtonsoft.Json.Bson.BsonType get_Type()
  System.Void set_Parent(Newtonsoft.Json.Bson.BsonToken value)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonObject
TYPE:  class
TOKEN: 0x2000124
EXTENDS: BsonToken
FIELDS:
  private   readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty>_children  // 0x18
METHODS:
  System.Void Add(System.String name, Newtonsoft.Json.Bson.BsonToken token)
  Newtonsoft.Json.Bson.BsonType get_Type()
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonArray
TYPE:  class
TOKEN: 0x2000125
EXTENDS: BsonToken
FIELDS:
  private   readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken>_children  // 0x18
METHODS:
  System.Void Add(Newtonsoft.Json.Bson.BsonToken token)
  Newtonsoft.Json.Bson.BsonType get_Type()
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonValue
TYPE:  class
TOKEN: 0x2000126
EXTENDS: BsonToken
FIELDS:
  private   readonly System.Object                   _value  // 0x18
  private   readonly Newtonsoft.Json.Bson.BsonType   _type  // 0x20
METHODS:
  System.Void .ctor(System.Object value, Newtonsoft.Json.Bson.BsonType type)
  Newtonsoft.Json.Bson.BsonType get_Type()
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonString
TYPE:  class
TOKEN: 0x2000127
EXTENDS: BsonValue
FIELDS:
  private   readonly System.Boolean                  <IncludeLength>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.Object value, System.Boolean includeLength)
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonRegex
TYPE:  class
TOKEN: 0x2000128
EXTENDS: BsonToken
FIELDS:
  private           Newtonsoft.Json.Bson.BsonString <Pattern>k__BackingField  // 0x18
  private           Newtonsoft.Json.Bson.BsonString <Options>k__BackingField  // 0x20
METHODS:
  System.Void set_Pattern(Newtonsoft.Json.Bson.BsonString value)
  System.Void set_Options(Newtonsoft.Json.Bson.BsonString value)
  System.Void .ctor(System.String pattern, System.String options)
  Newtonsoft.Json.Bson.BsonType get_Type()
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonProperty
TYPE:  class
TOKEN: 0x2000129
FIELDS:
  private           Newtonsoft.Json.Bson.BsonString <Name>k__BackingField  // 0x10
  private           Newtonsoft.Json.Bson.BsonToken  <Value>k__BackingField  // 0x18
METHODS:
  System.Void set_Name(Newtonsoft.Json.Bson.BsonString value)
  System.Void set_Value(Newtonsoft.Json.Bson.BsonToken value)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonType
TYPE:  struct
TOKEN: 0x200012A
FIELDS:
  public            System.SByte                    value__  // 0x10
  public    static  Newtonsoft.Json.Bson.BsonType   Number  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   String  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Object  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Array  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Binary  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Undefined  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Oid  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Boolean  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Date  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Null  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Regex  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Reference  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Code  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Symbol  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   CodeWScope  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Integer  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   TimeStamp  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   Long  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   MinKey  // 0x0
  public    static  Newtonsoft.Json.Bson.BsonType   MaxKey  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Bson.BsonWriter
TYPE:  class
TOKEN: 0x200012B
EXTENDS: JsonWriter
FIELDS:
  private           Newtonsoft.Json.Bson.BsonToken  _root  // 0x60
  private           Newtonsoft.Json.Bson.BsonToken  _parent  // 0x68
  private           System.String                   _propertyName  // 0x70
METHODS:
  System.Void AddValue(System.Object value, Newtonsoft.Json.Bson.BsonType type)
  System.Void AddToken(Newtonsoft.Json.Bson.BsonToken token)
  System.Void WriteObjectId(System.Byte[] value)
  System.Void WriteRegex(System.String pattern, System.String options)
END_CLASS

CLASS: Newtonsoft.Json.Converters.BinaryConverter
TYPE:  class
TOKEN: 0x20000F9
EXTENDS: JsonConverter
FIELDS:
  private   static  System.String                   BinaryTypeName  // 0x0
  private   static  System.String                   BinaryToArrayName  // 0x0
  private   static  Newtonsoft.Json.Utilities.ReflectionObject_reflectionObject  // 0x0
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Byte[] GetByteArray(System.Object value)
  System.Void EnsureReflectionObject(System.Type t)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Byte[] ReadByteArray(Newtonsoft.Json.JsonReader reader)
  System.Boolean CanConvert(System.Type objectType)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.BsonObjectIdConverter
TYPE:  class
TOKEN: 0x20000FA
EXTENDS: JsonConverter
FIELDS:
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Boolean CanConvert(System.Type objectType)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.CustomCreationConverter`1
TYPE:  class
TOKEN: 0x20000FB
EXTENDS: JsonConverter
FIELDS:
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  T Create(System.Type objectType)
  System.Boolean CanConvert(System.Type objectType)
  System.Boolean get_CanWrite()
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.DataSetConverter
TYPE:  class
TOKEN: 0x20000FC
EXTENDS: JsonConverter
FIELDS:
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Boolean CanConvert(System.Type valueType)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.DataTableConverter
TYPE:  class
TOKEN: 0x20000FD
EXTENDS: JsonConverter
FIELDS:
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Void CreateRow(Newtonsoft.Json.JsonReader reader, System.Data.DataTable dt, Newtonsoft.Json.JsonSerializer serializer)
  System.Type GetColumnDataType(Newtonsoft.Json.JsonReader reader)
  System.Boolean CanConvert(System.Type valueType)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.DateTimeConverterBase
TYPE:  class
TOKEN: 0x20000FE
EXTENDS: JsonConverter
FIELDS:
METHODS:
  System.Boolean CanConvert(System.Type objectType)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.DiscriminatedUnionConverter
TYPE:  class
TOKEN: 0x20000FF
EXTENDS: JsonConverter
FIELDS:
  private   static  System.String                   CasePropertyName  // 0x0
  private   static  System.String                   FieldsPropertyName  // 0x0
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union>UnionCache  // 0x0
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Type>UnionTypeLookupCache  // 0x8
METHODS:
  System.Type CreateUnionTypeLookup(System.Type t)
  Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union CreateUnion(System.Type t)
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Boolean CanConvert(System.Type objectType)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.EntityKeyMemberConverter
TYPE:  class
TOKEN: 0x2000104
EXTENDS: JsonConverter
FIELDS:
  private   static  System.String                   EntityKeyMemberFullTypeName  // 0x0
  private   static  System.String                   KeyPropertyName  // 0x0
  private   static  System.String                   TypePropertyName  // 0x0
  private   static  System.String                   ValuePropertyName  // 0x0
  private   static  Newtonsoft.Json.Utilities.ReflectionObject_reflectionObject  // 0x0
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Void ReadAndAssertProperty(Newtonsoft.Json.JsonReader reader, System.String propertyName)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Void EnsureReflectionObject(System.Type objectType)
  System.Boolean CanConvert(System.Type objectType)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.ExpandoObjectConverter
TYPE:  class
TOKEN: 0x2000105
EXTENDS: JsonConverter
FIELDS:
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadValue(Newtonsoft.Json.JsonReader reader)
  System.Object ReadList(Newtonsoft.Json.JsonReader reader)
  System.Object ReadObject(Newtonsoft.Json.JsonReader reader)
  System.Boolean CanConvert(System.Type objectType)
  System.Boolean get_CanWrite()
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.IsoDateTimeConverter
TYPE:  class
TOKEN: 0x2000106
EXTENDS: DateTimeConverterBase
FIELDS:
  private   static  System.String                   DefaultDateTimeFormat  // 0x0
  private           System.Globalization.DateTimeStyles_dateTimeStyles  // 0x10
  private           System.String                   _dateTimeFormat  // 0x18
  private           System.Globalization.CultureInfo_culture  // 0x20
METHODS:
  System.Globalization.DateTimeStyles get_DateTimeStyles()
  System.Void set_DateTimeStyles(System.Globalization.DateTimeStyles value)
  System.String get_DateTimeFormat()
  System.Void set_DateTimeFormat(System.String value)
  System.Globalization.CultureInfo get_Culture()
  System.Void set_Culture(System.Globalization.CultureInfo value)
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.JavaScriptDateTimeConverter
TYPE:  class
TOKEN: 0x2000107
EXTENDS: DateTimeConverterBase
FIELDS:
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.KeyValuePairConverter
TYPE:  class
TOKEN: 0x2000108
EXTENDS: JsonConverter
FIELDS:
  private   static  System.String                   KeyName  // 0x0
  private   static  System.String                   ValueName  // 0x0
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Utilities.ReflectionObject>ReflectionObjectPerType  // 0x0
METHODS:
  Newtonsoft.Json.Utilities.ReflectionObject InitializeReflectionObject(System.Type t)
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Boolean CanConvert(System.Type objectType)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.RegexConverter
TYPE:  class
TOKEN: 0x2000109
EXTENDS: JsonConverter
FIELDS:
  private   static  System.String                   PatternName  // 0x0
  private   static  System.String                   OptionsName  // 0x0
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Boolean HasFlag(System.Text.RegularExpressions.RegexOptions options, System.Text.RegularExpressions.RegexOptions flag)
  System.Void WriteBson(Newtonsoft.Json.Bson.BsonWriter writer, System.Text.RegularExpressions.Regex regex)
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Text.RegularExpressions.Regex regex, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadRegexString(Newtonsoft.Json.JsonReader reader)
  System.Text.RegularExpressions.Regex ReadRegexObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer)
  System.Boolean CanConvert(System.Type objectType)
  System.Boolean IsRegex(System.Type objectType)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.StringEnumConverter
TYPE:  class
TOKEN: 0x200010A
EXTENDS: JsonConverter
FIELDS:
  private           Newtonsoft.Json.Serialization.NamingStrategy<NamingStrategy>k__BackingField  // 0x10
  private           System.Boolean                  <AllowIntegerValues>k__BackingField  // 0x18
METHODS:
  System.Boolean get_CamelCaseText()
  System.Void set_CamelCaseText(System.Boolean value)
  Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy()
  System.Void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy value)
  System.Boolean get_AllowIntegerValues()
  System.Void set_AllowIntegerValues(System.Boolean value)
  System.Void .ctor()
  System.Void .ctor(System.Boolean camelCaseText)
  System.Void .ctor(Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.Boolean allowIntegerValues)
  System.Void .ctor(System.Type namingStrategyType)
  System.Void .ctor(System.Type namingStrategyType, System.Object[] namingStrategyParameters)
  System.Void .ctor(System.Type namingStrategyType, System.Object[] namingStrategyParameters, System.Boolean allowIntegerValues)
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Boolean CanConvert(System.Type objectType)
END_CLASS

CLASS: Newtonsoft.Json.Converters.UnixDateTimeConverter
TYPE:  class
TOKEN: 0x200010B
EXTENDS: DateTimeConverterBase
FIELDS:
  private   static readonly System.DateTime                 UnixEpoch  // 0x0
  private           System.Boolean                  <AllowPreEpoch>k__BackingField  // 0x10
METHODS:
  System.Boolean get_AllowPreEpoch()
  System.Void set_AllowPreEpoch(System.Boolean value)
  System.Void .ctor()
  System.Void .ctor(System.Boolean allowPreEpoch)
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.VersionConverter
TYPE:  class
TOKEN: 0x200010C
EXTENDS: JsonConverter
FIELDS:
METHODS:
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Boolean CanConvert(System.Type objectType)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlDocumentWrapper
TYPE:  class
TOKEN: 0x200010D
EXTENDS: XmlNodeWrapper
FIELDS:
  private   readonly System.Xml.XmlDocument          _document  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XmlDocument document)
  Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String data)
  Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text)
  Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data)
  Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text)
  Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text)
  Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone)
  Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset)
  Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data)
  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName)
  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri)
  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value)
  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value)
  Newtonsoft.Json.Converters.IXmlElement get_DocumentElement()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlElementWrapper
TYPE:  class
TOKEN: 0x200010E
EXTENDS: XmlNodeWrapper
FIELDS:
  private   readonly System.Xml.XmlElement           _element  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XmlElement element)
  System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute)
  System.String GetPrefixOfNamespace(System.String namespaceUri)
  System.Boolean get_IsEmpty()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlDeclarationWrapper
TYPE:  class
TOKEN: 0x200010F
EXTENDS: XmlNodeWrapper
FIELDS:
  private   readonly System.Xml.XmlDeclaration       _declaration  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XmlDeclaration declaration)
  System.String get_Version()
  System.String get_Encoding()
  System.String get_Standalone()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlDocumentTypeWrapper
TYPE:  class
TOKEN: 0x2000110
EXTENDS: XmlNodeWrapper
FIELDS:
  private   readonly System.Xml.XmlDocumentType      _documentType  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XmlDocumentType documentType)
  System.String get_Name()
  System.String get_System()
  System.String get_Public()
  System.String get_InternalSubset()
  System.String get_LocalName()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlNodeWrapper
TYPE:  class
TOKEN: 0x2000111
FIELDS:
  private   readonly System.Xml.XmlNode              _node  // 0x10
  private           System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode>_childNodes  // 0x18
  private           System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode>_attributes  // 0x20
METHODS:
  System.Void .ctor(System.Xml.XmlNode node)
  System.Object get_WrappedNode()
  System.Xml.XmlNodeType get_NodeType()
  System.String get_LocalName()
  System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes()
  Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.XmlNode node)
  System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes()
  System.Boolean get_HasAttributes()
  Newtonsoft.Json.Converters.IXmlNode get_ParentNode()
  System.String get_Value()
  System.Void set_Value(System.String value)
  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
  System.String get_NamespaceUri()
END_CLASS

CLASS: Newtonsoft.Json.Converters.IXmlDocument
TYPE:  interface
TOKEN: 0x2000112
FIELDS:
METHODS:
  Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String text)
  Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text)
  Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data)
  Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text)
  Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text)
  Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone)
  Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset)
  Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data)
  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName)
  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri)
  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value)
  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value)
  Newtonsoft.Json.Converters.IXmlElement get_DocumentElement()
END_CLASS

CLASS: Newtonsoft.Json.Converters.IXmlDeclaration
TYPE:  interface
TOKEN: 0x2000113
FIELDS:
METHODS:
  System.String get_Version()
  System.String get_Encoding()
  System.String get_Standalone()
END_CLASS

CLASS: Newtonsoft.Json.Converters.IXmlDocumentType
TYPE:  interface
TOKEN: 0x2000114
FIELDS:
METHODS:
  System.String get_Name()
  System.String get_System()
  System.String get_Public()
  System.String get_InternalSubset()
END_CLASS

CLASS: Newtonsoft.Json.Converters.IXmlElement
TYPE:  interface
TOKEN: 0x2000115
FIELDS:
METHODS:
  System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute)
  System.String GetPrefixOfNamespace(System.String namespaceUri)
  System.Boolean get_IsEmpty()
END_CLASS

CLASS: Newtonsoft.Json.Converters.IXmlNode
TYPE:  interface
TOKEN: 0x2000116
FIELDS:
METHODS:
  System.Xml.XmlNodeType get_NodeType()
  System.String get_LocalName()
  System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes()
  System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes()
  Newtonsoft.Json.Converters.IXmlNode get_ParentNode()
  System.String get_Value()
  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
  System.String get_NamespaceUri()
  System.Object get_WrappedNode()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XDeclarationWrapper
TYPE:  class
TOKEN: 0x2000117
EXTENDS: XObjectWrapper
FIELDS:
  private   readonly System.Xml.Linq.XDeclaration    <Declaration>k__BackingField  // 0x18
METHODS:
  System.Xml.Linq.XDeclaration get_Declaration()
  System.Void .ctor(System.Xml.Linq.XDeclaration declaration)
  System.Xml.XmlNodeType get_NodeType()
  System.String get_Version()
  System.String get_Encoding()
  System.String get_Standalone()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XDocumentTypeWrapper
TYPE:  class
TOKEN: 0x2000118
EXTENDS: XObjectWrapper
FIELDS:
  private   readonly System.Xml.Linq.XDocumentType   _documentType  // 0x18
METHODS:
  System.Void .ctor(System.Xml.Linq.XDocumentType documentType)
  System.String get_Name()
  System.String get_System()
  System.String get_Public()
  System.String get_InternalSubset()
  System.String get_LocalName()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XDocumentWrapper
TYPE:  class
TOKEN: 0x2000119
EXTENDS: XContainerWrapper
FIELDS:
METHODS:
  System.Xml.Linq.XDocument get_Document()
  System.Void .ctor(System.Xml.Linq.XDocument document)
  System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes()
  System.Boolean get_HasChildNodes()
  Newtonsoft.Json.Converters.IXmlNode CreateComment(System.String text)
  Newtonsoft.Json.Converters.IXmlNode CreateTextNode(System.String text)
  Newtonsoft.Json.Converters.IXmlNode CreateCDataSection(System.String data)
  Newtonsoft.Json.Converters.IXmlNode CreateWhitespace(System.String text)
  Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace(System.String text)
  Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone)
  Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset)
  Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(System.String target, System.String data)
  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName)
  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String qualifiedName, System.String namespaceUri)
  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String name, System.String value)
  Newtonsoft.Json.Converters.IXmlNode CreateAttribute(System.String qualifiedName, System.String namespaceUri, System.String value)
  Newtonsoft.Json.Converters.IXmlElement get_DocumentElement()
  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XTextWrapper
TYPE:  class
TOKEN: 0x200011A
EXTENDS: XObjectWrapper
FIELDS:
METHODS:
  System.Xml.Linq.XText get_Text()
  System.Void .ctor(System.Xml.Linq.XText text)
  System.String get_Value()
  Newtonsoft.Json.Converters.IXmlNode get_ParentNode()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XCommentWrapper
TYPE:  class
TOKEN: 0x200011B
EXTENDS: XObjectWrapper
FIELDS:
METHODS:
  System.Xml.Linq.XComment get_Text()
  System.Void .ctor(System.Xml.Linq.XComment text)
  System.String get_Value()
  Newtonsoft.Json.Converters.IXmlNode get_ParentNode()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XProcessingInstructionWrapper
TYPE:  class
TOKEN: 0x200011C
EXTENDS: XObjectWrapper
FIELDS:
METHODS:
  System.Xml.Linq.XProcessingInstruction get_ProcessingInstruction()
  System.Void .ctor(System.Xml.Linq.XProcessingInstruction processingInstruction)
  System.String get_LocalName()
  System.String get_Value()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XContainerWrapper
TYPE:  class
TOKEN: 0x200011D
EXTENDS: XObjectWrapper
FIELDS:
  private           System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode>_childNodes  // 0x18
METHODS:
  System.Xml.Linq.XContainer get_Container()
  System.Void .ctor(System.Xml.Linq.XContainer container)
  System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes()
  System.Boolean get_HasChildNodes()
  Newtonsoft.Json.Converters.IXmlNode get_ParentNode()
  Newtonsoft.Json.Converters.IXmlNode WrapNode(System.Xml.Linq.XObject node)
  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
END_CLASS

CLASS: Newtonsoft.Json.Converters.XObjectWrapper
TYPE:  class
TOKEN: 0x200011E
FIELDS:
  private   readonly System.Xml.Linq.XObject         _xmlObject  // 0x10
METHODS:
  System.Void .ctor(System.Xml.Linq.XObject xmlObject)
  System.Object get_WrappedNode()
  System.Xml.XmlNodeType get_NodeType()
  System.String get_LocalName()
  System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes()
  System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes()
  Newtonsoft.Json.Converters.IXmlNode get_ParentNode()
  System.String get_Value()
  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
  System.String get_NamespaceUri()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XAttributeWrapper
TYPE:  class
TOKEN: 0x200011F
EXTENDS: XObjectWrapper
FIELDS:
METHODS:
  System.Xml.Linq.XAttribute get_Attribute()
  System.Void .ctor(System.Xml.Linq.XAttribute attribute)
  System.String get_Value()
  System.String get_LocalName()
  System.String get_NamespaceUri()
  Newtonsoft.Json.Converters.IXmlNode get_ParentNode()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XElementWrapper
TYPE:  class
TOKEN: 0x2000120
EXTENDS: XContainerWrapper
FIELDS:
  private           System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode>_attributes  // 0x20
METHODS:
  System.Xml.Linq.XElement get_Element()
  System.Void .ctor(System.Xml.Linq.XElement element)
  System.Void SetAttributeNode(Newtonsoft.Json.Converters.IXmlNode attribute)
  System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes()
  System.Boolean HasImplicitNamespaceAttribute(System.String namespaceUri)
  Newtonsoft.Json.Converters.IXmlNode AppendChild(Newtonsoft.Json.Converters.IXmlNode newChild)
  System.String get_Value()
  System.String get_LocalName()
  System.String get_NamespaceUri()
  System.String GetPrefixOfNamespace(System.String namespaceUri)
  System.Boolean get_IsEmpty()
END_CLASS

CLASS: Newtonsoft.Json.Converters.XmlNodeConverter
TYPE:  class
TOKEN: 0x2000121
EXTENDS: JsonConverter
FIELDS:
  private   static readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode>EmptyChildNodes  // 0x0
  private   static  System.String                   TextName  // 0x0
  private   static  System.String                   CommentName  // 0x0
  private   static  System.String                   CDataName  // 0x0
  private   static  System.String                   WhitespaceName  // 0x0
  private   static  System.String                   SignificantWhitespaceName  // 0x0
  private   static  System.String                   DeclarationName  // 0x0
  private   static  System.String                   JsonNamespaceUri  // 0x0
  private           System.String                   <DeserializeRootElementName>k__BackingField  // 0x10
  private           System.Boolean                  <WriteArrayAttribute>k__BackingField  // 0x18
  private           System.Boolean                  <OmitRootObject>k__BackingField  // 0x19
  private           System.Boolean                  <EncodeSpecialCharacters>k__BackingField  // 0x1A
METHODS:
  System.String get_DeserializeRootElementName()
  System.Void set_DeserializeRootElementName(System.String value)
  System.Boolean get_WriteArrayAttribute()
  System.Void set_WriteArrayAttribute(System.Boolean value)
  System.Boolean get_OmitRootObject()
  System.Void set_OmitRootObject(System.Boolean value)
  System.Boolean get_EncodeSpecialCharacters()
  System.Void set_EncodeSpecialCharacters(System.Boolean value)
  System.Void WriteJson(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
  Newtonsoft.Json.Converters.IXmlNode WrapXml(System.Object value)
  System.Void PushParentNamespaces(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager)
  System.String ResolveFullName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager)
  System.String GetPropertyName(Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager)
  System.Boolean IsArray(Newtonsoft.Json.Converters.IXmlNode node)
  System.Void SerializeGroupedNodes(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName)
  System.Void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, System.String elementNames)
  System.Void WriteGroupedNodes(Newtonsoft.Json.JsonWriter writer, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName, Newtonsoft.Json.Converters.IXmlNode node, System.String elementNames)
  System.Void SerializeNode(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Converters.IXmlNode node, System.Xml.XmlNamespaceManager manager, System.Boolean writePropertyName)
  System.Boolean AllSameName(Newtonsoft.Json.Converters.IXmlNode node)
  System.Object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
  System.Void DeserializeValue(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, System.String propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode)
  System.Void ReadElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName, System.Xml.XmlNamespaceManager manager)
  System.Void CreateElement(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String elementName, System.Xml.XmlNamespaceManager manager, System.String elementPrefix, System.Collections.Generic.Dictionary<System.String,System.String> attributeNameValues)
  System.Void AddAttribute(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName, System.String attributeName, System.Xml.XmlNamespaceManager manager, System.String attributePrefix)
  System.String ConvertTokenToXmlValue(Newtonsoft.Json.JsonReader reader)
  System.Void ReadArrayElements(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.String propertyName, Newtonsoft.Json.Converters.IXmlNode currentNode, System.Xml.XmlNamespaceManager manager)
  System.Void AddJsonArrayAttribute(Newtonsoft.Json.Converters.IXmlElement element, Newtonsoft.Json.Converters.IXmlDocument document)
  System.Boolean ShouldReadInto(Newtonsoft.Json.JsonReader reader)
  System.Collections.Generic.Dictionary<System.String,System.String> ReadAttributeElements(Newtonsoft.Json.JsonReader reader, System.Xml.XmlNamespaceManager manager)
  System.Void CreateInstruction(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode, System.String propertyName)
  System.Void CreateDocumentType(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, Newtonsoft.Json.Converters.IXmlNode currentNode)
  Newtonsoft.Json.Converters.IXmlElement CreateElement(System.String elementName, Newtonsoft.Json.Converters.IXmlDocument document, System.String elementPrefix, System.Xml.XmlNamespaceManager manager)
  System.Void DeserializeNode(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Converters.IXmlDocument document, System.Xml.XmlNamespaceManager manager, Newtonsoft.Json.Converters.IXmlNode currentNode)
  System.Boolean IsNamespaceAttribute(System.String attributeName, System.String& prefix)
  System.Boolean ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c)
  System.Boolean CanConvert(System.Type valueType)
  System.Boolean IsXObject(System.Type valueType)
  System.Boolean IsXmlNode(System.Type valueType)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Linq.CommentHandling
TYPE:  struct
TOKEN: 0x20000DE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Linq.CommentHandlingIgnore  // 0x0
  public    static  Newtonsoft.Json.Linq.CommentHandlingLoad  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Linq.DuplicatePropertyNameHandling
TYPE:  struct
TOKEN: 0x20000DF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Linq.DuplicatePropertyNameHandlingReplace  // 0x0
  public    static  Newtonsoft.Json.Linq.DuplicatePropertyNameHandlingIgnore  // 0x0
  public    static  Newtonsoft.Json.Linq.DuplicatePropertyNameHandlingError  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Linq.Extensions
TYPE:  class
TOKEN: 0x20000E0
FIELDS:
METHODS:
  U Value(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> value)
  U Value(System.Collections.Generic.IEnumerable<T> value)
  U Convert(T token)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JArray
TYPE:  class
TOKEN: 0x20000E1
EXTENDS: JContainer
FIELDS:
  private   readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken>_values  // 0x50
METHODS:
  System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens()
  Newtonsoft.Json.Linq.JTokenType get_Type()
  System.Void .ctor()
  System.Void .ctor(Newtonsoft.Json.Linq.JArray other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  System.Void .ctor(System.Object content)
  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  Newtonsoft.Json.Linq.JToken get_Item(System.Object key)
  Newtonsoft.Json.Linq.JToken get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, Newtonsoft.Json.Linq.JToken value)
  System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
  System.Int32 IndexOf(Newtonsoft.Json.Linq.JToken item)
  System.Void Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  System.Void RemoveAt(System.Int32 index)
  System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator()
  System.Void Add(Newtonsoft.Json.Linq.JToken item)
  System.Void Clear()
  System.Boolean Contains(Newtonsoft.Json.Linq.JToken item)
  System.Void CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex)
  System.Boolean get_IsReadOnly()
  System.Boolean Remove(Newtonsoft.Json.Linq.JToken item)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JConstructor
TYPE:  class
TOKEN: 0x20000E2
EXTENDS: JContainer
FIELDS:
  private           System.String                   _name  // 0x50
  private   readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken>_values  // 0x58
METHODS:
  System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens()
  System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
  System.String get_Name()
  Newtonsoft.Json.Linq.JTokenType get_Type()
  System.Void .ctor(Newtonsoft.Json.Linq.JConstructor other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  System.Void .ctor(System.String name)
  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  Newtonsoft.Json.Linq.JToken get_Item(System.Object key)
  Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JContainer
TYPE:  class
TOKEN: 0x20000E3
EXTENDS: JToken
FIELDS:
  private           System.ComponentModel.ListChangedEventHandler_listChanged  // 0x30
  private           System.Collections.Specialized.NotifyCollectionChangedEventHandler_collectionChanged  // 0x38
  private           System.Object                   _syncRoot  // 0x40
  private           System.Boolean                  _busy  // 0x48
METHODS:
  System.Void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value)
  System.Void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler value)
  System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens()
  System.Void .ctor()
  System.Void .ctor(Newtonsoft.Json.Linq.JContainer other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  System.Void CheckReentrancy()
  System.Void OnListChanged(System.ComponentModel.ListChangedEventArgs e)
  System.Void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
  System.Boolean get_HasValues()
  Newtonsoft.Json.Linq.JToken get_First()
  Newtonsoft.Json.Linq.JToken get_Last()
  Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children()
  System.Boolean IsMultiContent(System.Object content)
  Newtonsoft.Json.Linq.JToken EnsureParentToken(Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations)
  System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
  System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations)
  System.Void RemoveItemAt(System.Int32 index)
  System.Boolean RemoveItem(Newtonsoft.Json.Linq.JToken item)
  Newtonsoft.Json.Linq.JToken GetItem(System.Int32 index)
  System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  System.Void ClearItems()
  System.Void ReplaceItem(Newtonsoft.Json.Linq.JToken existing, Newtonsoft.Json.Linq.JToken replacement)
  System.Boolean ContainsItem(Newtonsoft.Json.Linq.JToken item)
  System.Void CopyItemsTo(System.Array array, System.Int32 arrayIndex)
  System.Boolean IsTokenUnchanged(Newtonsoft.Json.Linq.JToken currentValue, Newtonsoft.Json.Linq.JToken newValue)
  System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing)
  System.Void Add(System.Object content)
  System.Boolean TryAdd(System.Object content)
  System.Void AddAndSkipParentCheck(Newtonsoft.Json.Linq.JToken token)
  System.Boolean TryAddInternal(System.Int32 index, System.Object content, System.Boolean skipParentCheck, System.Boolean copyAnnotations)
  Newtonsoft.Json.Linq.JToken CreateFromContent(System.Object content)
  System.Void RemoveAll()
  System.Void ReadTokenFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings options)
  System.Void ReadContentFrom(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  Newtonsoft.Json.Linq.JProperty ReadProperty(Newtonsoft.Json.JsonReader r, Newtonsoft.Json.Linq.JsonLoadSettings settings, Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JContainer parent)
  System.Int32 System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item)
  System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(System.Int32 index)
  Newtonsoft.Json.Linq.JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(System.Int32 index)
  System.Void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(System.Int32 index, Newtonsoft.Json.Linq.JToken value)
  System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item)
  System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear()
  System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item)
  System.Void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, System.Int32 arrayIndex)
  System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly()
  System.Boolean System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item)
  Newtonsoft.Json.Linq.JToken EnsureValue(System.Object value)
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Void System.Collections.IList.Clear()
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Boolean System.Collections.IList.get_IsFixedSize()
  System.Boolean System.Collections.IList.get_IsReadOnly()
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Void System.Collections.IList.RemoveAt(System.Int32 index)
  System.Object System.Collections.IList.get_Item(System.Int32 index)
  System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Int32 get_Count()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JEnumerable`1
TYPE:  struct
TOKEN: 0x20000E4
FIELDS:
  public    static readonly Newtonsoft.Json.Linq.JEnumerable<T>Empty  // 0x0
  private   readonly System.Collections.Generic.IEnumerable<T>_enumerable  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEnumerable<T> enumerable)
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean Equals(Newtonsoft.Json.Linq.JEnumerable<T> other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JObject
TYPE:  class
TOKEN: 0x20000E5
EXTENDS: JContainer
FIELDS:
  private   readonly Newtonsoft.Json.Linq.JPropertyKeyedCollection_properties  // 0x50
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanged  // 0x58
  private           System.ComponentModel.PropertyChangingEventHandlerPropertyChanging  // 0x60
METHODS:
  System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens()
  System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void .ctor()
  System.Void .ctor(Newtonsoft.Json.Linq.JObject other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
  System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations)
  System.Void ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JToken existing)
  System.Void InternalPropertyChanged(Newtonsoft.Json.Linq.JProperty childProperty)
  System.Void InternalPropertyChanging(Newtonsoft.Json.Linq.JProperty childProperty)
  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  Newtonsoft.Json.Linq.JTokenType get_Type()
  System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties()
  Newtonsoft.Json.Linq.JProperty Property(System.String name, System.StringComparison comparison)
  Newtonsoft.Json.Linq.JToken get_Item(System.Object key)
  Newtonsoft.Json.Linq.JToken get_Item(System.String propertyName)
  System.Void set_Item(System.String propertyName, Newtonsoft.Json.Linq.JToken value)
  Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  Newtonsoft.Json.Linq.JObject Parse(System.String json)
  Newtonsoft.Json.Linq.JObject Parse(System.String json, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  Newtonsoft.Json.Linq.JObject FromObject(System.Object o)
  Newtonsoft.Json.Linq.JObject FromObject(System.Object o, Newtonsoft.Json.JsonSerializer jsonSerializer)
  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  Newtonsoft.Json.Linq.JToken GetValue(System.String propertyName)
  Newtonsoft.Json.Linq.JToken GetValue(System.String propertyName, System.StringComparison comparison)
  System.Void Add(System.String propertyName, Newtonsoft.Json.Linq.JToken value)
  System.Boolean ContainsKey(System.String propertyName)
  System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys()
  System.Boolean Remove(System.String propertyName)
  System.Boolean TryGetValue(System.String propertyName, Newtonsoft.Json.Linq.JToken& value)
  System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values()
  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item)
  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear()
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item)
  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>[] array, System.Int32 arrayIndex)
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly()
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item)
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>> GetEnumerator()
  System.Void OnPropertyChanged(System.String propertyName)
  System.Void OnPropertyChanging(System.String propertyName)
  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes)
  System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
  System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
  System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd)
  System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JProperty
TYPE:  class
TOKEN: 0x20000E9
EXTENDS: JContainer
FIELDS:
  private   readonly Newtonsoft.Json.Linq.JProperty.JPropertyList_content  // 0x50
  private   readonly System.String                   _name  // 0x58
METHODS:
  System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens()
  System.String get_Name()
  Newtonsoft.Json.Linq.JToken get_Value()
  System.Void set_Value(Newtonsoft.Json.Linq.JToken value)
  System.Void .ctor(Newtonsoft.Json.Linq.JProperty other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  Newtonsoft.Json.Linq.JToken GetItem(System.Int32 index)
  System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  System.Boolean RemoveItem(Newtonsoft.Json.Linq.JToken item)
  System.Void RemoveItemAt(System.Int32 index)
  System.Int32 IndexOfItem(Newtonsoft.Json.Linq.JToken item)
  System.Boolean InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item, System.Boolean skipParentCheck, System.Boolean copyAnnotations)
  System.Boolean ContainsItem(Newtonsoft.Json.Linq.JToken item)
  System.Void ClearItems()
  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  Newtonsoft.Json.Linq.JTokenType get_Type()
  System.Void .ctor(System.String name)
  System.Void .ctor(System.String name, System.Object content)
  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JPropertyDescriptor
TYPE:  class
TOKEN: 0x20000EC
EXTENDS: PropertyDescriptor
FIELDS:
METHODS:
  System.Void .ctor(System.String name)
  System.Boolean CanResetValue(System.Object component)
  System.Object GetValue(System.Object component)
  System.Void ResetValue(System.Object component)
  System.Void SetValue(System.Object component, System.Object value)
  System.Boolean ShouldSerializeValue(System.Object component)
  System.Type get_ComponentType()
  System.Boolean get_IsReadOnly()
  System.Type get_PropertyType()
  System.Int32 get_NameHashCode()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JPropertyKeyedCollection
TYPE:  class
TOKEN: 0x20000ED
EXTENDS: Collection`1
FIELDS:
  private   static readonly System.Collections.Generic.IEqualityComparer<System.String>Comparer  // 0x0
  private           System.Collections.Generic.Dictionary<System.String,Newtonsoft.Json.Linq.JToken>_dictionary  // 0x18
METHODS:
  System.Void .ctor()
  System.Void AddKey(System.String key, Newtonsoft.Json.Linq.JToken item)
  System.Void ClearItems()
  System.Boolean Contains(System.String key)
  System.Void EnsureDictionary()
  System.String GetKeyForItem(Newtonsoft.Json.Linq.JToken item)
  System.Void InsertItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  System.Void RemoveItem(System.Int32 index)
  System.Void RemoveKey(System.String key)
  System.Void SetItem(System.Int32 index, Newtonsoft.Json.Linq.JToken item)
  System.Boolean TryGetValue(System.String key, Newtonsoft.Json.Linq.JToken& value)
  System.Collections.Generic.ICollection<System.String> get_Keys()
  System.Int32 IndexOfReference(Newtonsoft.Json.Linq.JToken t)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JRaw
TYPE:  class
TOKEN: 0x20000EE
EXTENDS: JValue
FIELDS:
METHODS:
  System.Void .ctor(Newtonsoft.Json.Linq.JRaw other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  System.Void .ctor(System.Object rawJson)
  Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader reader)
  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JsonCloneSettings
TYPE:  class
TOKEN: 0x20000EF
FIELDS:
  private   static readonly Newtonsoft.Json.Linq.JsonCloneSettingsSkipCopyAnnotations  // 0x0
  private           System.Boolean                  <CopyAnnotations>k__BackingField  // 0x10
METHODS:
  System.Void .ctor()
  System.Boolean get_CopyAnnotations()
  System.Void set_CopyAnnotations(System.Boolean value)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JsonLoadSettings
TYPE:  class
TOKEN: 0x20000F0
FIELDS:
  private           Newtonsoft.Json.Linq.CommentHandling_commentHandling  // 0x10
  private           Newtonsoft.Json.Linq.LineInfoHandling_lineInfoHandling  // 0x14
  private           Newtonsoft.Json.Linq.DuplicatePropertyNameHandling_duplicatePropertyNameHandling  // 0x18
METHODS:
  Newtonsoft.Json.Linq.CommentHandling get_CommentHandling()
  Newtonsoft.Json.Linq.LineInfoHandling get_LineInfoHandling()
  Newtonsoft.Json.Linq.DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JToken
TYPE:  class
TOKEN: 0x20000F1
FIELDS:
  private           Newtonsoft.Json.Linq.JContainer _parent  // 0x10
  private           Newtonsoft.Json.Linq.JToken     _previous  // 0x18
  private           Newtonsoft.Json.Linq.JToken     _next  // 0x20
  private           System.Object                   _annotations  // 0x28
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]BooleanTypes  // 0x0
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]NumberTypes  // 0x8
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]BigIntegerTypes  // 0x10
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]StringTypes  // 0x18
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]GuidTypes  // 0x20
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]TimeSpanTypes  // 0x28
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]UriTypes  // 0x30
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]CharTypes  // 0x38
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]DateTimeTypes  // 0x40
  private   static readonly Newtonsoft.Json.Linq.JTokenType[]BytesTypes  // 0x48
METHODS:
  Newtonsoft.Json.Linq.JContainer get_Parent()
  System.Void set_Parent(Newtonsoft.Json.Linq.JContainer value)
  Newtonsoft.Json.Linq.JToken get_Root()
  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  Newtonsoft.Json.Linq.JTokenType get_Type()
  System.Boolean get_HasValues()
  Newtonsoft.Json.Linq.JToken get_Next()
  System.Void set_Next(Newtonsoft.Json.Linq.JToken value)
  Newtonsoft.Json.Linq.JToken get_Previous()
  System.Void set_Previous(Newtonsoft.Json.Linq.JToken value)
  System.String get_Path()
  System.Void .ctor()
  Newtonsoft.Json.Linq.JToken get_Item(System.Object key)
  Newtonsoft.Json.Linq.JToken get_First()
  Newtonsoft.Json.Linq.JToken get_Last()
  Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children()
  System.Void Remove()
  System.Void Replace(Newtonsoft.Json.Linq.JToken value)
  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  System.String ToString()
  System.String ToString(Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonConverter[] converters)
  Newtonsoft.Json.Linq.JValue EnsureValue(Newtonsoft.Json.Linq.JToken value)
  System.String GetType(Newtonsoft.Json.Linq.JToken token)
  System.Boolean ValidateToken(Newtonsoft.Json.Linq.JToken o, Newtonsoft.Json.Linq.JTokenType[] validTypes, System.Boolean nullable)
  System.Boolean op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.Boolean> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Int64 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.DateTime> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.DateTimeOffset> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.Decimal> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.Double> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.Char> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Int32 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Int16 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.UInt16 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Char op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Byte op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.SByte op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.Int32> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.Int16> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.UInt16> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.Byte> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.SByte> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.Int64> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.Single> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Decimal op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.UInt32> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.UInt64> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Double op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Single op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.String op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.UInt32 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.UInt64 op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.Guid> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.TimeSpan> op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken value)
  System.Numerics.BigInteger ToBigInteger(Newtonsoft.Json.Linq.JToken value)
  System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(Newtonsoft.Json.Linq.JToken value)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
  Newtonsoft.Json.JsonReader CreateReader()
  Newtonsoft.Json.Linq.JToken FromObjectInternal(System.Object o, Newtonsoft.Json.JsonSerializer jsonSerializer)
  Newtonsoft.Json.Linq.JToken FromObject(System.Object o)
  T ToObject()
  System.Object ToObject(System.Type objectType)
  System.Object ToObject(System.Type objectType, Newtonsoft.Json.JsonSerializer jsonSerializer)
  Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader)
  Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  Newtonsoft.Json.Linq.JToken Parse(System.String json)
  Newtonsoft.Json.Linq.JToken Parse(System.String json, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  Newtonsoft.Json.Linq.JToken Load(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  System.Void SetLineInfo(Newtonsoft.Json.IJsonLineInfo lineInfo, Newtonsoft.Json.Linq.JsonLoadSettings settings)
  System.Void SetLineInfo(System.Int32 lineNumber, System.Int32 linePosition)
  System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
  System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LineNumber()
  System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LinePosition()
  System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
  System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter)
  System.Object System.ICloneable.Clone()
  Newtonsoft.Json.Linq.JToken DeepClone()
  System.Void AddAnnotation(System.Object annotation)
  T Annotation()
  System.Void CopyAnnotations(Newtonsoft.Json.Linq.JToken target, Newtonsoft.Json.Linq.JToken source)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JTokenReader
TYPE:  class
TOKEN: 0x20000F3
EXTENDS: JsonReader
FIELDS:
  private   readonly Newtonsoft.Json.Linq.JToken     _root  // 0x78
  private           System.String                   _initialPath  // 0x80
  private           Newtonsoft.Json.Linq.JToken     _parent  // 0x88
  private           Newtonsoft.Json.Linq.JToken     _current  // 0x90
METHODS:
  Newtonsoft.Json.Linq.JToken get_CurrentToken()
  System.Void .ctor(Newtonsoft.Json.Linq.JToken token)
  System.Boolean Read()
  System.Boolean ReadOver(Newtonsoft.Json.Linq.JToken t)
  System.Boolean ReadToEnd()
  System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(Newtonsoft.Json.Linq.JContainer c)
  System.Boolean ReadInto(Newtonsoft.Json.Linq.JContainer c)
  System.Boolean SetEnd(Newtonsoft.Json.Linq.JContainer c)
  System.Void SetToken(Newtonsoft.Json.Linq.JToken token)
  System.String SafeToString(System.Object value)
  System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
  System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LineNumber()
  System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LinePosition()
  System.String get_Path()
END_CLASS

CLASS: Newtonsoft.Json.Linq.JTokenType
TYPE:  struct
TOKEN: 0x20000F4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Linq.JTokenType None  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Object  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Array  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Constructor  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Property  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Comment  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Integer  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Float  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType String  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Boolean  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Null  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Undefined  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Date  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Raw  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Bytes  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Guid  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType Uri  // 0x0
  public    static  Newtonsoft.Json.Linq.JTokenType TimeSpan  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Linq.JTokenWriter
TYPE:  class
TOKEN: 0x20000F5
EXTENDS: JsonWriter
FIELDS:
  private           Newtonsoft.Json.Linq.JContainer _token  // 0x60
  private           Newtonsoft.Json.Linq.JContainer _parent  // 0x68
  private           Newtonsoft.Json.Linq.JValue     _value  // 0x70
  private           Newtonsoft.Json.Linq.JToken     _current  // 0x78
METHODS:
  Newtonsoft.Json.Linq.JToken get_Token()
  System.Void .ctor()
  System.Void Close()
  System.Void WriteStartObject()
  System.Void AddParent(Newtonsoft.Json.Linq.JContainer container)
  System.Void RemoveParent()
  System.Void WriteStartArray()
  System.Void WriteStartConstructor(System.String name)
  System.Void WriteEnd(Newtonsoft.Json.JsonToken token)
  System.Void WritePropertyName(System.String name)
  System.Void AddRawValue(System.Object value, Newtonsoft.Json.Linq.JTokenType type, Newtonsoft.Json.JsonToken token)
  System.Void AddJValue(Newtonsoft.Json.Linq.JValue value, Newtonsoft.Json.JsonToken token)
  System.Void WriteValue(System.Object value)
  System.Void WriteNull()
  System.Void WriteUndefined()
  System.Void WriteRaw(System.String json)
  System.Void WriteComment(System.String text)
  System.Void WriteValue(System.String value)
  System.Void WriteValue(System.Int32 value)
  System.Void WriteValue(System.UInt32 value)
  System.Void WriteValue(System.Int64 value)
  System.Void WriteValue(System.UInt64 value)
  System.Void WriteValue(System.Single value)
  System.Void WriteValue(System.Double value)
  System.Void WriteValue(System.Boolean value)
  System.Void WriteValue(System.Int16 value)
  System.Void WriteValue(System.UInt16 value)
  System.Void WriteValue(System.Char value)
  System.Void WriteValue(System.Byte value)
  System.Void WriteValue(System.SByte value)
  System.Void WriteValue(System.Decimal value)
  System.Void WriteValue(System.DateTime value)
  System.Void WriteValue(System.DateTimeOffset value)
  System.Void WriteValue(System.Byte[] value)
  System.Void WriteValue(System.TimeSpan value)
  System.Void WriteValue(System.Guid value)
  System.Void WriteValue(System.Uri value)
  System.Void WriteToken(Newtonsoft.Json.JsonReader reader, System.Boolean writeChildren, System.Boolean writeDateConstructorAsDate, System.Boolean writeComments)
END_CLASS

CLASS: Newtonsoft.Json.Linq.JValue
TYPE:  class
TOKEN: 0x20000F6
EXTENDS: JToken
FIELDS:
  private           Newtonsoft.Json.Linq.JTokenType _valueType  // 0x30
  private           System.Object                   _value  // 0x38
METHODS:
  System.Void .ctor(System.Object value, Newtonsoft.Json.Linq.JTokenType type)
  System.Void .ctor(Newtonsoft.Json.Linq.JValue other, Newtonsoft.Json.Linq.JsonCloneSettings settings)
  System.Void .ctor(System.Int64 value)
  System.Void .ctor(System.Decimal value)
  System.Void .ctor(System.UInt64 value)
  System.Void .ctor(System.Double value)
  System.Void .ctor(System.Single value)
  System.Void .ctor(System.DateTime value)
  System.Void .ctor(System.DateTimeOffset value)
  System.Void .ctor(System.Boolean value)
  System.Void .ctor(System.String value)
  System.Void .ctor(System.Guid value)
  System.Void .ctor(System.Uri value)
  System.Void .ctor(System.TimeSpan value)
  System.Void .ctor(System.Object value)
  System.Boolean get_HasValues()
  System.Int32 CompareBigInteger(System.Numerics.BigInteger i1, System.Object i2)
  System.Int32 Compare(Newtonsoft.Json.Linq.JTokenType valueType, System.Object objA, System.Object objB)
  System.Int32 CompareFloat(System.Object objA, System.Object objB)
  System.Boolean Operation(System.Linq.Expressions.ExpressionType operation, System.Object objA, System.Object objB, System.Object& result)
  Newtonsoft.Json.Linq.JToken CloneToken(Newtonsoft.Json.Linq.JsonCloneSettings settings)
  Newtonsoft.Json.Linq.JValue CreateComment(System.String value)
  Newtonsoft.Json.Linq.JValue CreateNull()
  Newtonsoft.Json.Linq.JValue CreateUndefined()
  Newtonsoft.Json.Linq.JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, System.Object value)
  Newtonsoft.Json.Linq.JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current)
  Newtonsoft.Json.Linq.JTokenType get_Type()
  System.Object get_Value()
  System.Void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter[] converters)
  System.Boolean ValuesEquals(Newtonsoft.Json.Linq.JValue v1, Newtonsoft.Json.Linq.JValue v2)
  System.Boolean Equals(Newtonsoft.Json.Linq.JValue other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.IFormatProvider formatProvider)
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
  System.Int32 System.IComparable.CompareTo(System.Object obj)
  System.Int32 CompareTo(Newtonsoft.Json.Linq.JValue obj)
  System.TypeCode System.IConvertible.GetTypeCode()
  System.Boolean System.IConvertible.ToBoolean(System.IFormatProvider provider)
  System.Char System.IConvertible.ToChar(System.IFormatProvider provider)
  System.SByte System.IConvertible.ToSByte(System.IFormatProvider provider)
  System.Byte System.IConvertible.ToByte(System.IFormatProvider provider)
  System.Int16 System.IConvertible.ToInt16(System.IFormatProvider provider)
  System.UInt16 System.IConvertible.ToUInt16(System.IFormatProvider provider)
  System.Int32 System.IConvertible.ToInt32(System.IFormatProvider provider)
  System.UInt32 System.IConvertible.ToUInt32(System.IFormatProvider provider)
  System.Int64 System.IConvertible.ToInt64(System.IFormatProvider provider)
  System.UInt64 System.IConvertible.ToUInt64(System.IFormatProvider provider)
  System.Single System.IConvertible.ToSingle(System.IFormatProvider provider)
  System.Double System.IConvertible.ToDouble(System.IFormatProvider provider)
  System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider provider)
  System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider)
  System.Object System.IConvertible.ToType(System.Type conversionType, System.IFormatProvider provider)
END_CLASS

CLASS: Newtonsoft.Json.Linq.LineInfoHandling
TYPE:  struct
TOKEN: 0x20000F8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Linq.LineInfoHandlingIgnore  // 0x0
  public    static  Newtonsoft.Json.Linq.LineInfoHandlingLoad  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Serialization.CachedAttributeGetter`1
TYPE:  class
TOKEN: 0x200009C
FIELDS:
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Object,T>TypeAttributeCache  // 0x0
METHODS:
  T GetAttribute(System.Object type)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.CamelCaseNamingStrategy
TYPE:  class
TOKEN: 0x200009D
EXTENDS: NamingStrategy
FIELDS:
METHODS:
  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames)
  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames)
  System.Void .ctor()
  System.String ResolvePropertyName(System.String name)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.DefaultContractResolver
TYPE:  class
TOKEN: 0x200009E
FIELDS:
  private   static readonly Newtonsoft.Json.Serialization.IContractResolver_instance  // 0x0
  private   static readonly System.String[]                 BlacklistedTypeNames  // 0x8
  private   static readonly Newtonsoft.Json.JsonConverter[] BuiltInConverters  // 0x10
  private   readonly Newtonsoft.Json.DefaultJsonNameTable_nameTable  // 0x10
  private   readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Serialization.JsonContract>_contractCache  // 0x18
  private           System.Reflection.BindingFlags  <DefaultMembersSearchFlags>k__BackingField  // 0x20
  private           System.Boolean                  <SerializeCompilerGeneratedMembers>k__BackingField  // 0x24
  private           System.Boolean                  <IgnoreSerializableInterface>k__BackingField  // 0x25
  private           System.Boolean                  <IgnoreSerializableAttribute>k__BackingField  // 0x26
  private           System.Boolean                  <IgnoreIsSpecifiedMembers>k__BackingField  // 0x27
  private           System.Boolean                  <IgnoreShouldSerializeMembers>k__BackingField  // 0x28
  private           Newtonsoft.Json.Serialization.NamingStrategy<NamingStrategy>k__BackingField  // 0x30
METHODS:
  Newtonsoft.Json.Serialization.IContractResolver get_Instance()
  System.Reflection.BindingFlags get_DefaultMembersSearchFlags()
  System.Void set_DefaultMembersSearchFlags(System.Reflection.BindingFlags value)
  System.Boolean get_SerializeCompilerGeneratedMembers()
  System.Boolean get_IgnoreSerializableInterface()
  System.Boolean get_IgnoreSerializableAttribute()
  System.Void set_IgnoreSerializableAttribute(System.Boolean value)
  System.Boolean get_IgnoreIsSpecifiedMembers()
  System.Boolean get_IgnoreShouldSerializeMembers()
  Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy()
  System.Void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy value)
  System.Void .ctor()
  Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type)
  System.Boolean FilterMembers(System.Reflection.MemberInfo member)
  System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType)
  System.Boolean ShouldSerializeEntityMember(System.Reflection.MemberInfo memberInfo)
  Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(System.Type objectType)
  System.Void ThrowUnableToSerializeError(System.Object o, System.Runtime.Serialization.StreamingContext context)
  System.Reflection.MemberInfo GetExtensionDataMemberForType(System.Type type)
  System.Void SetExtensionDataDelegates(Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Reflection.MemberInfo member)
  System.Reflection.ConstructorInfo GetAttributeConstructor(System.Type objectType)
  System.Reflection.ConstructorInfo GetImmutableConstructor(System.Type objectType, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties)
  System.Reflection.ConstructorInfo GetParameterizedConstructor(System.Type objectType)
  System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties)
  Newtonsoft.Json.Serialization.JsonProperty MatchProperty(Newtonsoft.Json.Serialization.JsonPropertyCollection properties, System.String name, System.Type type)
  Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo)
  Newtonsoft.Json.JsonConverter ResolveContractConverter(System.Type objectType)
  System.Func<System.Object> GetDefaultCreator(System.Type createdType)
  System.Void InitializeContract(Newtonsoft.Json.Serialization.JsonContract contract)
  System.Void ResolveCallbackMethods(Newtonsoft.Json.Serialization.JsonContract contract, System.Type t)
  System.Void GetCallbackMethodsForType(System.Type type, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback>& onError)
  System.Boolean IsConcurrentOrObservableCollection(System.Type t)
  System.Boolean ShouldSkipDeserialized(System.Type t)
  System.Boolean ShouldSkipSerializing(System.Type t)
  System.Collections.Generic.List<System.Type> GetClassHierarchyForType(System.Type type)
  Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(System.Type objectType)
  Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(System.Type objectType)
  Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType)
  Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(System.Type objectType)
  Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(System.Type objectType)
  Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(System.Type objectType)
  Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(System.Type objectType)
  Newtonsoft.Json.Serialization.JsonContract CreateContract(System.Type objectType)
  System.Boolean IsJsonPrimitiveType(System.Type t)
  System.Boolean IsIConvertible(System.Type t)
  System.Boolean CanConvertToString(System.Type type)
  System.Boolean IsValidCallback(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Type attributeType, System.Reflection.MethodInfo currentCallback, System.Type& prevAttributeType)
  System.String GetClrTypeFullName(System.Type type)
  System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, Newtonsoft.Json.MemberSerialization memberSerialization)
  Newtonsoft.Json.DefaultJsonNameTable GetNameTable()
  Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member)
  Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization)
  System.Void SetPropertySettingsFromAttributes(Newtonsoft.Json.Serialization.JsonProperty property, System.Object attributeProvider, System.String name, System.Type declaringType, Newtonsoft.Json.MemberSerialization memberSerialization, System.Boolean& allowNonPublicAccess)
  System.Predicate<System.Object> CreateShouldSerializeTest(System.Reflection.MemberInfo member)
  System.Void SetIsSpecifiedActions(Newtonsoft.Json.Serialization.JsonProperty property, System.Reflection.MemberInfo member, System.Boolean allowNonPublicAccess)
  System.String ResolvePropertyName(System.String propertyName)
  System.String ResolveExtensionDataName(System.String extensionDataName)
  System.String ResolveDictionaryKey(System.String dictionaryKey)
  System.String GetResolvedPropertyName(System.String propertyName)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.DefaultNamingStrategy
TYPE:  class
TOKEN: 0x20000AA
EXTENDS: NamingStrategy
FIELDS:
METHODS:
  System.String ResolvePropertyName(System.String name)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.DefaultReferenceResolver
TYPE:  class
TOKEN: 0x20000AB
FIELDS:
  private           System.Int32                    _referenceCount  // 0x10
METHODS:
  Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> GetMappings(System.Object context)
  System.Object ResolveReference(System.Object context, System.String reference)
  System.String GetReference(System.Object context, System.Object value)
  System.Void AddReference(System.Object context, System.String reference, System.Object value)
  System.Boolean IsReferenced(System.Object context, System.Object value)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.DefaultSerializationBinder
TYPE:  class
TOKEN: 0x20000AC
EXTENDS: SerializationBinder
FIELDS:
  private   static readonly Newtonsoft.Json.Serialization.DefaultSerializationBinderInstance  // 0x0
  private   readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String>,System.Type>_typeCache  // 0x10
METHODS:
  System.Void .ctor()
  System.Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey)
  System.Type GetGenericTypeFromTypeName(System.String typeName, System.Reflection.Assembly assembly)
  System.Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey)
  System.Type BindToType(System.String assemblyName, System.String typeName)
  System.Void BindToName(System.Type serializedType, System.String& assemblyName, System.String& typeName)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ErrorContext
TYPE:  class
TOKEN: 0x20000AD
FIELDS:
  private           System.Boolean                  <Traced>k__BackingField  // 0x10
  private   readonly System.Exception                <Error>k__BackingField  // 0x18
  private   readonly System.Object                   <OriginalObject>k__BackingField  // 0x20
  private   readonly System.Object                   <Member>k__BackingField  // 0x28
  private   readonly System.String                   <Path>k__BackingField  // 0x30
  private           System.Boolean                  <Handled>k__BackingField  // 0x38
METHODS:
  System.Void .ctor(System.Object originalObject, System.Object member, System.String path, System.Exception error)
  System.Boolean get_Traced()
  System.Void set_Traced(System.Boolean value)
  System.Exception get_Error()
  System.Boolean get_Handled()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ErrorEventArgs
TYPE:  class
TOKEN: 0x20000AE
EXTENDS: EventArgs
FIELDS:
  private   readonly System.Object                   <CurrentObject>k__BackingField  // 0x10
  private   readonly Newtonsoft.Json.Serialization.ErrorContext<ErrorContext>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.IAttributeProvider
TYPE:  interface
TOKEN: 0x20000AF
FIELDS:
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Serialization.IContractResolver
TYPE:  interface
TOKEN: 0x20000B0
FIELDS:
METHODS:
  Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.IReferenceResolver
TYPE:  interface
TOKEN: 0x20000B1
FIELDS:
METHODS:
  System.Object ResolveReference(System.Object context, System.String reference)
  System.String GetReference(System.Object context, System.Object value)
  System.Boolean IsReferenced(System.Object context, System.Object value)
  System.Void AddReference(System.Object context, System.String reference, System.Object value)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ISerializationBinder
TYPE:  interface
TOKEN: 0x20000B2
FIELDS:
METHODS:
  System.Type BindToType(System.String assemblyName, System.String typeName)
  System.Void BindToName(System.Type serializedType, System.String& assemblyName, System.String& typeName)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ITraceWriter
TYPE:  interface
TOKEN: 0x20000B3
FIELDS:
METHODS:
  System.Diagnostics.TraceLevel get_LevelFilter()
  System.Void Trace(System.Diagnostics.TraceLevel level, System.String message, System.Exception ex)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.IValueProvider
TYPE:  interface
TOKEN: 0x20000B4
FIELDS:
METHODS:
  System.Void SetValue(System.Object target, System.Object value)
  System.Object GetValue(System.Object target)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonArrayContract
TYPE:  class
TOKEN: 0x20000B5
EXTENDS: JsonContainerContract
FIELDS:
  private   readonly System.Type                     <CollectionItemType>k__BackingField  // 0xC0
  private   readonly System.Boolean                  <IsMultidimensionalArray>k__BackingField  // 0xC8
  private   readonly System.Type                     _genericCollectionDefinitionType  // 0xD0
  private           System.Type                     _genericWrapperType  // 0xD8
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_genericWrapperCreator  // 0xE0
  private           System.Func<System.Object>      _genericTemporaryCollectionCreator  // 0xE8
  private   readonly System.Boolean                  <IsArray>k__BackingField  // 0xF0
  private   readonly System.Boolean                  <ShouldCreateWrapper>k__BackingField  // 0xF1
  private           System.Boolean                  <CanDeserialize>k__BackingField  // 0xF2
  private   readonly System.Reflection.ConstructorInfo_parameterizedConstructor  // 0xF8
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_parameterizedCreator  // 0x100
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_overrideCreator  // 0x108
  private           System.Boolean                  <HasParameterizedCreator>k__BackingField  // 0x110
METHODS:
  System.Type get_CollectionItemType()
  System.Boolean get_IsMultidimensionalArray()
  System.Boolean get_IsArray()
  System.Boolean get_ShouldCreateWrapper()
  System.Boolean get_CanDeserialize()
  System.Void set_CanDeserialize(System.Boolean value)
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator()
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator()
  System.Void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value)
  System.Boolean get_HasParameterizedCreator()
  System.Void set_HasParameterizedCreator(System.Boolean value)
  System.Boolean get_HasParameterizedCreatorInternal()
  System.Void .ctor(System.Type underlyingType)
  Newtonsoft.Json.Utilities.IWrappedCollection CreateWrapper(System.Object list)
  System.Collections.IList CreateTemporaryCollection()
  System.Void StoreFSharpListCreatorIfNecessary(System.Type underlyingType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonContainerContract
TYPE:  class
TOKEN: 0x20000B6
EXTENDS: JsonContract
FIELDS:
  private           Newtonsoft.Json.Serialization.JsonContract_itemContract  // 0x90
  private           Newtonsoft.Json.Serialization.JsonContract_finalItemContract  // 0x98
  private           Newtonsoft.Json.JsonConverter   <ItemConverter>k__BackingField  // 0xA0
  private           System.Nullable<System.Boolean> <ItemIsReference>k__BackingField  // 0xA8
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling><ItemReferenceLoopHandling>k__BackingField  // 0xAC
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling><ItemTypeNameHandling>k__BackingField  // 0xB4
METHODS:
  Newtonsoft.Json.Serialization.JsonContract get_ItemContract()
  System.Void set_ItemContract(Newtonsoft.Json.Serialization.JsonContract value)
  Newtonsoft.Json.Serialization.JsonContract get_FinalItemContract()
  Newtonsoft.Json.JsonConverter get_ItemConverter()
  System.Void set_ItemConverter(Newtonsoft.Json.JsonConverter value)
  System.Nullable<System.Boolean> get_ItemIsReference()
  System.Void set_ItemIsReference(System.Nullable<System.Boolean> value)
  System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling()
  System.Void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value)
  System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling()
  System.Void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value)
  System.Void .ctor(System.Type underlyingType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonContractType
TYPE:  struct
TOKEN: 0x20000B7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeNone  // 0x0
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeObject  // 0x0
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeArray  // 0x0
  public    static  Newtonsoft.Json.Serialization.JsonContractTypePrimitive  // 0x0
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeString  // 0x0
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeDictionary  // 0x0
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeDynamic  // 0x0
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeSerializable  // 0x0
  public    static  Newtonsoft.Json.Serialization.JsonContractTypeLinq  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Serialization.SerializationCallback
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object o, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.SerializationErrorCallback
TYPE:  class
TOKEN: 0x20000B9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ExtensionDataSetter
TYPE:  class
TOKEN: 0x20000BA
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object o, System.String key, System.Object value)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ExtensionDataGetter
TYPE:  class
TOKEN: 0x20000BB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> Invoke(System.Object o)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonContract
TYPE:  class
TOKEN: 0x20000BC
FIELDS:
  private           System.Boolean                  IsNullable  // 0x10
  private           System.Boolean                  IsConvertable  // 0x11
  private           System.Boolean                  IsEnum  // 0x12
  private           System.Type                     NonNullableUnderlyingType  // 0x18
  private           Newtonsoft.Json.ReadType        InternalReadType  // 0x20
  private           Newtonsoft.Json.Serialization.JsonContractTypeContractType  // 0x24
  private           System.Boolean                  IsReadOnlyOrFixedSize  // 0x28
  private           System.Boolean                  IsSealed  // 0x29
  private           System.Boolean                  IsInstantiable  // 0x2A
  private           System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>_onDeserializedCallbacks  // 0x30
  private           System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>_onDeserializingCallbacks  // 0x38
  private           System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>_onSerializedCallbacks  // 0x40
  private           System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>_onSerializingCallbacks  // 0x48
  private           System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback>_onErrorCallbacks  // 0x50
  private           System.Type                     _createdType  // 0x58
  private   readonly System.Type                     <UnderlyingType>k__BackingField  // 0x60
  private           System.Nullable<System.Boolean> <IsReference>k__BackingField  // 0x68
  private           Newtonsoft.Json.JsonConverter   <Converter>k__BackingField  // 0x70
  private           Newtonsoft.Json.JsonConverter   <InternalConverter>k__BackingField  // 0x78
  private           System.Func<System.Object>      <DefaultCreator>k__BackingField  // 0x80
  private           System.Boolean                  <DefaultCreatorNonPublic>k__BackingField  // 0x88
METHODS:
  System.Type get_UnderlyingType()
  System.Type get_CreatedType()
  System.Void set_CreatedType(System.Type value)
  System.Nullable<System.Boolean> get_IsReference()
  System.Void set_IsReference(System.Nullable<System.Boolean> value)
  Newtonsoft.Json.JsonConverter get_Converter()
  System.Void set_Converter(Newtonsoft.Json.JsonConverter value)
  Newtonsoft.Json.JsonConverter get_InternalConverter()
  System.Void set_InternalConverter(Newtonsoft.Json.JsonConverter value)
  System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks()
  System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks()
  System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks()
  System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks()
  System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks()
  System.Func<System.Object> get_DefaultCreator()
  System.Void set_DefaultCreator(System.Func<System.Object> value)
  System.Boolean get_DefaultCreatorNonPublic()
  System.Void set_DefaultCreatorNonPublic(System.Boolean value)
  System.Void .ctor(System.Type underlyingType)
  System.Void InvokeOnSerializing(System.Object o, System.Runtime.Serialization.StreamingContext context)
  System.Void InvokeOnSerialized(System.Object o, System.Runtime.Serialization.StreamingContext context)
  System.Void InvokeOnDeserializing(System.Object o, System.Runtime.Serialization.StreamingContext context)
  System.Void InvokeOnDeserialized(System.Object o, System.Runtime.Serialization.StreamingContext context)
  System.Void InvokeOnError(System.Object o, System.Runtime.Serialization.StreamingContext context, Newtonsoft.Json.Serialization.ErrorContext errorContext)
  Newtonsoft.Json.Serialization.SerializationCallback CreateSerializationCallback(System.Reflection.MethodInfo callbackMethodInfo)
  Newtonsoft.Json.Serialization.SerializationErrorCallback CreateSerializationErrorCallback(System.Reflection.MethodInfo callbackMethodInfo)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonDictionaryContract
TYPE:  class
TOKEN: 0x20000BF
EXTENDS: JsonContainerContract
FIELDS:
  private           System.Func<System.String,System.String><DictionaryKeyResolver>k__BackingField  // 0xC0
  private   readonly System.Type                     <DictionaryKeyType>k__BackingField  // 0xC8
  private   readonly System.Type                     <DictionaryValueType>k__BackingField  // 0xD0
  private           Newtonsoft.Json.Serialization.JsonContract<KeyContract>k__BackingField  // 0xD8
  private   readonly System.Type                     _genericCollectionDefinitionType  // 0xE0
  private           System.Type                     _genericWrapperType  // 0xE8
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_genericWrapperCreator  // 0xF0
  private           System.Func<System.Object>      _genericTemporaryDictionaryCreator  // 0xF8
  private   readonly System.Boolean                  <ShouldCreateWrapper>k__BackingField  // 0x100
  private   readonly System.Reflection.ConstructorInfo_parameterizedConstructor  // 0x108
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_overrideCreator  // 0x110
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_parameterizedCreator  // 0x118
  private           System.Boolean                  <HasParameterizedCreator>k__BackingField  // 0x120
METHODS:
  System.Func<System.String,System.String> get_DictionaryKeyResolver()
  System.Void set_DictionaryKeyResolver(System.Func<System.String,System.String> value)
  System.Type get_DictionaryKeyType()
  System.Type get_DictionaryValueType()
  Newtonsoft.Json.Serialization.JsonContract get_KeyContract()
  System.Void set_KeyContract(Newtonsoft.Json.Serialization.JsonContract value)
  System.Boolean get_ShouldCreateWrapper()
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator()
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator()
  System.Void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value)
  System.Boolean get_HasParameterizedCreator()
  System.Void set_HasParameterizedCreator(System.Boolean value)
  System.Boolean get_HasParameterizedCreatorInternal()
  System.Void .ctor(System.Type underlyingType)
  Newtonsoft.Json.Utilities.IWrappedDictionary CreateWrapper(System.Object dictionary)
  System.Collections.IDictionary CreateTemporaryDictionary()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonDynamicContract
TYPE:  class
TOKEN: 0x20000C0
EXTENDS: JsonContainerContract
FIELDS:
  private   readonly Newtonsoft.Json.Serialization.JsonPropertyCollection<Properties>k__BackingField  // 0xC0
  private           System.Func<System.String,System.String><PropertyNameResolver>k__BackingField  // 0xC8
  private   readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.String,System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>>>_callSiteGetters  // 0xD0
  private   readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.String,System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>>>_callSiteSetters  // 0xD8
METHODS:
  Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties()
  System.Func<System.String,System.String> get_PropertyNameResolver()
  System.Void set_PropertyNameResolver(System.Func<System.String,System.String> value)
  System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>> CreateCallSiteGetter(System.String name)
  System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>> CreateCallSiteSetter(System.String name)
  System.Void .ctor(System.Type underlyingType)
  System.Boolean TryGetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, System.String name, System.Object& value)
  System.Boolean TrySetMember(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, System.String name, System.Object value)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonFormatterConverter
TYPE:  class
TOKEN: 0x20000C1
FIELDS:
  private   readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader_reader  // 0x10
  private   readonly Newtonsoft.Json.Serialization.JsonISerializableContract_contract  // 0x18
  private   readonly Newtonsoft.Json.Serialization.JsonProperty_member  // 0x20
METHODS:
  System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member)
  T GetTokenValue(System.Object value)
  System.Object Convert(System.Object value, System.Type type)
  System.Boolean ToBoolean(System.Object value)
  System.Int32 ToInt32(System.Object value)
  System.Int64 ToInt64(System.Object value)
  System.Single ToSingle(System.Object value)
  System.String ToString(System.Object value)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonISerializableContract
TYPE:  class
TOKEN: 0x20000C2
EXTENDS: JsonContainerContract
FIELDS:
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object><ISerializableCreator>k__BackingField  // 0xC0
METHODS:
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ISerializableCreator()
  System.Void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value)
  System.Void .ctor(System.Type underlyingType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonLinqContract
TYPE:  class
TOKEN: 0x20000C3
EXTENDS: JsonContract
FIELDS:
METHODS:
  System.Void .ctor(System.Type underlyingType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonObjectContract
TYPE:  class
TOKEN: 0x20000C4
EXTENDS: JsonContainerContract
FIELDS:
  private           Newtonsoft.Json.MemberSerialization<MemberSerialization>k__BackingField  // 0xC0
  private           System.Nullable<Newtonsoft.Json.MissingMemberHandling><MissingMemberHandling>k__BackingField  // 0xC4
  private           System.Nullable<Newtonsoft.Json.Required><ItemRequired>k__BackingField  // 0xCC
  private           System.Nullable<Newtonsoft.Json.NullValueHandling><ItemNullValueHandling>k__BackingField  // 0xD4
  private   readonly Newtonsoft.Json.Serialization.JsonPropertyCollection<Properties>k__BackingField  // 0xE0
  private           Newtonsoft.Json.Serialization.ExtensionDataSetter<ExtensionDataSetter>k__BackingField  // 0xE8
  private           Newtonsoft.Json.Serialization.ExtensionDataGetter<ExtensionDataGetter>k__BackingField  // 0xF0
  private           System.Func<System.String,System.String><ExtensionDataNameResolver>k__BackingField  // 0xF8
  private           System.Boolean                  ExtensionDataIsJToken  // 0x100
  private           System.Nullable<System.Boolean> _hasRequiredOrDefaultValueProperties  // 0x101
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_overrideCreator  // 0x108
  private           Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>_parameterizedCreator  // 0x110
  private           Newtonsoft.Json.Serialization.JsonPropertyCollection_creatorParameters  // 0x118
  private           System.Type                     _extensionDataValueType  // 0x120
METHODS:
  Newtonsoft.Json.MemberSerialization get_MemberSerialization()
  System.Void set_MemberSerialization(Newtonsoft.Json.MemberSerialization value)
  System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling()
  System.Void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value)
  System.Nullable<Newtonsoft.Json.Required> get_ItemRequired()
  System.Void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value)
  System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling()
  System.Void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value)
  Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties()
  Newtonsoft.Json.Serialization.JsonPropertyCollection get_CreatorParameters()
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator()
  System.Void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value)
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator()
  System.Void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value)
  Newtonsoft.Json.Serialization.ExtensionDataSetter get_ExtensionDataSetter()
  System.Void set_ExtensionDataSetter(Newtonsoft.Json.Serialization.ExtensionDataSetter value)
  Newtonsoft.Json.Serialization.ExtensionDataGetter get_ExtensionDataGetter()
  System.Void set_ExtensionDataGetter(Newtonsoft.Json.Serialization.ExtensionDataGetter value)
  System.Void set_ExtensionDataValueType(System.Type value)
  System.Func<System.String,System.String> get_ExtensionDataNameResolver()
  System.Void set_ExtensionDataNameResolver(System.Func<System.String,System.String> value)
  System.Boolean get_HasRequiredOrDefaultValueProperties()
  System.Void .ctor(System.Type underlyingType)
  System.Object GetUninitializedObject()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonPrimitiveContract
TYPE:  class
TOKEN: 0x20000C5
EXTENDS: JsonContract
FIELDS:
  private           Newtonsoft.Json.Utilities.PrimitiveTypeCode<TypeCode>k__BackingField  // 0x90
  private   static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.ReadType>ReadTypeMap  // 0x0
METHODS:
  Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode()
  System.Void set_TypeCode(Newtonsoft.Json.Utilities.PrimitiveTypeCode value)
  System.Void .ctor(System.Type underlyingType)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonProperty
TYPE:  class
TOKEN: 0x20000C6
FIELDS:
  private           System.Nullable<Newtonsoft.Json.Required>_required  // 0x10
  private           System.Boolean                  _hasExplicitDefaultValue  // 0x18
  private           System.Object                   _defaultValue  // 0x20
  private           System.Boolean                  _hasGeneratedDefaultValue  // 0x28
  private           System.String                   _propertyName  // 0x30
  private           System.Boolean                  _skipPropertyNameEscape  // 0x38
  private           System.Type                     _propertyType  // 0x40
  private           Newtonsoft.Json.Serialization.JsonContract<PropertyContract>k__BackingField  // 0x48
  private           System.Type                     <DeclaringType>k__BackingField  // 0x50
  private           System.Nullable<System.Int32>   <Order>k__BackingField  // 0x58
  private           System.String                   <UnderlyingName>k__BackingField  // 0x60
  private           Newtonsoft.Json.Serialization.IValueProvider<ValueProvider>k__BackingField  // 0x68
  private           Newtonsoft.Json.Serialization.IAttributeProvider<AttributeProvider>k__BackingField  // 0x70
  private           Newtonsoft.Json.JsonConverter   <Converter>k__BackingField  // 0x78
  private           System.Boolean                  <Ignored>k__BackingField  // 0x80
  private           System.Boolean                  <Readable>k__BackingField  // 0x81
  private           System.Boolean                  <Writable>k__BackingField  // 0x82
  private           System.Boolean                  <HasMemberAttribute>k__BackingField  // 0x83
  private           System.Nullable<System.Boolean> <IsReference>k__BackingField  // 0x84
  private           System.Nullable<Newtonsoft.Json.NullValueHandling><NullValueHandling>k__BackingField  // 0x88
  private           System.Nullable<Newtonsoft.Json.DefaultValueHandling><DefaultValueHandling>k__BackingField  // 0x90
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling><ReferenceLoopHandling>k__BackingField  // 0x98
  private           System.Nullable<Newtonsoft.Json.ObjectCreationHandling><ObjectCreationHandling>k__BackingField  // 0xA0
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling><TypeNameHandling>k__BackingField  // 0xA8
  private           System.Predicate<System.Object> <ShouldSerialize>k__BackingField  // 0xB0
  private           System.Predicate<System.Object> <ShouldDeserialize>k__BackingField  // 0xB8
  private           System.Predicate<System.Object> <GetIsSpecified>k__BackingField  // 0xC0
  private           System.Action<System.Object,System.Object><SetIsSpecified>k__BackingField  // 0xC8
  private           Newtonsoft.Json.JsonConverter   <ItemConverter>k__BackingField  // 0xD0
  private           System.Nullable<System.Boolean> <ItemIsReference>k__BackingField  // 0xD8
  private           System.Nullable<Newtonsoft.Json.TypeNameHandling><ItemTypeNameHandling>k__BackingField  // 0xDC
  private           System.Nullable<Newtonsoft.Json.ReferenceLoopHandling><ItemReferenceLoopHandling>k__BackingField  // 0xE4
METHODS:
  Newtonsoft.Json.Serialization.JsonContract get_PropertyContract()
  System.Void set_PropertyContract(Newtonsoft.Json.Serialization.JsonContract value)
  System.String get_PropertyName()
  System.Void set_PropertyName(System.String value)
  System.Type get_DeclaringType()
  System.Void set_DeclaringType(System.Type value)
  System.Nullable<System.Int32> get_Order()
  System.Void set_Order(System.Nullable<System.Int32> value)
  System.String get_UnderlyingName()
  System.Void set_UnderlyingName(System.String value)
  Newtonsoft.Json.Serialization.IValueProvider get_ValueProvider()
  System.Void set_ValueProvider(Newtonsoft.Json.Serialization.IValueProvider value)
  System.Void set_AttributeProvider(Newtonsoft.Json.Serialization.IAttributeProvider value)
  System.Type get_PropertyType()
  System.Void set_PropertyType(System.Type value)
  Newtonsoft.Json.JsonConverter get_Converter()
  System.Void set_Converter(Newtonsoft.Json.JsonConverter value)
  System.Boolean get_Ignored()
  System.Void set_Ignored(System.Boolean value)
  System.Boolean get_Readable()
  System.Void set_Readable(System.Boolean value)
  System.Boolean get_Writable()
  System.Void set_Writable(System.Boolean value)
  System.Boolean get_HasMemberAttribute()
  System.Void set_HasMemberAttribute(System.Boolean value)
  System.Object get_DefaultValue()
  System.Void set_DefaultValue(System.Object value)
  System.Object GetResolvedDefaultValue()
  Newtonsoft.Json.Required get_Required()
  System.Nullable<System.Boolean> get_IsReference()
  System.Void set_IsReference(System.Nullable<System.Boolean> value)
  System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling()
  System.Void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value)
  System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling()
  System.Void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value)
  System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling()
  System.Void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value)
  System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling()
  System.Void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value)
  System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling()
  System.Void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value)
  System.Predicate<System.Object> get_ShouldSerialize()
  System.Void set_ShouldSerialize(System.Predicate<System.Object> value)
  System.Predicate<System.Object> get_ShouldDeserialize()
  System.Predicate<System.Object> get_GetIsSpecified()
  System.Void set_GetIsSpecified(System.Predicate<System.Object> value)
  System.Action<System.Object,System.Object> get_SetIsSpecified()
  System.Void set_SetIsSpecified(System.Action<System.Object,System.Object> value)
  System.String ToString()
  Newtonsoft.Json.JsonConverter get_ItemConverter()
  System.Void set_ItemConverter(Newtonsoft.Json.JsonConverter value)
  System.Nullable<System.Boolean> get_ItemIsReference()
  System.Void set_ItemIsReference(System.Nullable<System.Boolean> value)
  System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling()
  System.Void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value)
  System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling()
  System.Void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value)
  System.Void WritePropertyName(Newtonsoft.Json.JsonWriter writer)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonPropertyCollection
TYPE:  class
TOKEN: 0x20000C7
EXTENDS: KeyedCollection`2
FIELDS:
  private   readonly System.Type                     _type  // 0x30
  private   readonly System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty>_list  // 0x38
METHODS:
  System.Void .ctor(System.Type type)
  System.String GetKeyForItem(Newtonsoft.Json.Serialization.JsonProperty item)
  System.Void AddProperty(Newtonsoft.Json.Serialization.JsonProperty property)
  Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(System.String propertyName)
  System.Boolean TryGetProperty(System.String key, Newtonsoft.Json.Serialization.JsonProperty& item)
  Newtonsoft.Json.Serialization.JsonProperty GetProperty(System.String propertyName, System.StringComparison comparisonType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonSerializerInternalBase
TYPE:  class
TOKEN: 0x20000C8
FIELDS:
  private           Newtonsoft.Json.Serialization.ErrorContext_currentErrorContext  // 0x10
  private           Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object>_mappings  // 0x18
  private   readonly Newtonsoft.Json.JsonSerializer  Serializer  // 0x20
  private   readonly Newtonsoft.Json.Serialization.ITraceWriterTraceWriter  // 0x28
  protected         Newtonsoft.Json.Serialization.JsonSerializerProxyInternalSerializer  // 0x30
METHODS:
  System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer)
  Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> get_DefaultReferenceMappings()
  Newtonsoft.Json.NullValueHandling ResolvedNullValueHandling(Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property)
  Newtonsoft.Json.Serialization.ErrorContext GetErrorContext(System.Object currentObject, System.Object member, System.String path, System.Exception error)
  System.Void ClearErrorContext()
  System.Boolean IsErrorHandled(System.Object currentObject, Newtonsoft.Json.Serialization.JsonContract contract, System.Object keyValue, Newtonsoft.Json.IJsonLineInfo lineInfo, System.String path, System.Exception ex)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonSerializerInternalReader
TYPE:  class
TOKEN: 0x20000CA
EXTENDS: JsonSerializerInternalBase
FIELDS:
METHODS:
  System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer)
  System.Void Populate(Newtonsoft.Json.JsonReader reader, System.Object target)
  Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Type type)
  Newtonsoft.Json.Serialization.JsonContract GetContract(System.Type type)
  System.Object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Boolean checkAdditionalContent)
  Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer()
  Newtonsoft.Json.Linq.JToken CreateJToken(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract)
  Newtonsoft.Json.Linq.JToken CreateJObject(Newtonsoft.Json.JsonReader reader)
  System.Object CreateValueInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue)
  System.Boolean CoerceEmptyStringToNull(System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, System.String s)
  System.String GetExpectedDescription(Newtonsoft.Json.Serialization.JsonContract contract)
  Newtonsoft.Json.JsonConverter GetConverter(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.JsonConverter memberConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Object CreateObject(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue)
  System.Boolean ReadMetadataPropertiesToken(Newtonsoft.Json.Linq.JTokenReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue, System.Object& newValue, System.String& id)
  System.Boolean ReadMetadataProperties(Newtonsoft.Json.JsonReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.Object existingValue, System.Object& newValue, System.String& id)
  System.Void ResolveTypeName(Newtonsoft.Json.JsonReader reader, System.Type& objectType, Newtonsoft.Json.Serialization.JsonContract& contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, System.String qualifiedTypeName)
  Newtonsoft.Json.Serialization.JsonArrayContract EnsureArrayContract(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract)
  System.Object CreateList(Newtonsoft.Json.JsonReader reader, System.Type objectType, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.Object existingValue, System.String id)
  System.Boolean HasNoDefinedType(Newtonsoft.Json.Serialization.JsonContract contract)
  System.Object EnsureType(Newtonsoft.Json.JsonReader reader, System.Object value, System.Globalization.CultureInfo culture, Newtonsoft.Json.Serialization.JsonContract contract, System.Type targetType)
  System.Boolean SetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Object target)
  System.Boolean CalculatePropertyDetails(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.JsonConverter& propertyConverter, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Object target, System.Boolean& useExistingValue, System.Object& currentValue, Newtonsoft.Json.Serialization.JsonContract& propertyContract, System.Boolean& gottenCurrentValue, System.Boolean& ignoredValue)
  System.Void AddReference(Newtonsoft.Json.JsonReader reader, System.String id, System.Object value)
  System.Boolean HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag)
  System.Boolean ShouldSetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Object value)
  System.Collections.IList CreateNewList(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, System.Boolean& createdFromNonDefaultCreator)
  System.Collections.IDictionary CreateNewDictionary(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, System.Boolean& createdFromNonDefaultCreator)
  System.Void OnDeserializing(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value)
  System.Void OnDeserialized(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value)
  System.Object PopulateDictionary(System.Collections.IDictionary dictionary, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id)
  System.Object PopulateMultidimensionalArray(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id)
  System.Void ThrowUnexpectedEndException(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonContract contract, System.Object currentObject, System.String message)
  System.Object PopulateList(System.Collections.IList list, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id)
  System.Object CreateISerializable(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id)
  System.Object CreateISerializableItem(Newtonsoft.Json.Linq.JToken token, System.Type type, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member)
  System.Object CreateDynamic(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id)
  System.Object CreateObjectUsingCreatorWithParameters(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator, System.String id)
  System.Object DeserializeConvertable(Newtonsoft.Json.JsonConverter converter, Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue)
  System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty containerProperty, Newtonsoft.Json.JsonReader reader, System.Type objectType)
  System.Object CreateNewObject(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract objectContract, Newtonsoft.Json.Serialization.JsonProperty containerMember, Newtonsoft.Json.Serialization.JsonProperty containerProperty, System.String id, System.Boolean& createdFromNonDefaultCreator)
  System.Object PopulateObject(System.Object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.String id)
  System.Boolean ShouldDeserialize(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target)
  System.Boolean CheckPropertyName(Newtonsoft.Json.JsonReader reader, System.String memberName)
  System.Void SetExtensionData(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader, System.String memberName, System.Object o)
  System.Object ReadExtensionDataValue(Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.JsonReader reader)
  System.Void EndProcessProperty(System.Object newObject, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonObjectContract contract, System.Int32 initialDepth, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence presence, System.Boolean setDefaultValue)
  System.Void SetPropertyPresence(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Serialization.JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties)
  System.Void HandleError(Newtonsoft.Json.JsonReader reader, System.Boolean readPastError, System.Int32 initialDepth)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonSerializerInternalWriter
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: JsonSerializerInternalBase
FIELDS:
  private           System.Type                     _rootType  // 0x38
  private           System.Int32                    _rootLevel  // 0x40
  private   readonly System.Collections.Generic.List<System.Object>_serializeStack  // 0x48
METHODS:
  System.Void .ctor(Newtonsoft.Json.JsonSerializer serializer)
  System.Void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type objectType)
  Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer()
  Newtonsoft.Json.Serialization.JsonContract GetContractSafe(System.Object value)
  Newtonsoft.Json.Serialization.JsonContract GetContract(System.Object value)
  System.Void SerializePrimitive(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonPrimitiveContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Void SerializeValue(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Nullable<System.Boolean> ResolveIsReference(Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Boolean ShouldWriteReference(System.Object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract valueContract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Boolean ShouldWriteProperty(System.Object memberValue, Newtonsoft.Json.Serialization.JsonObjectContract containerContract, Newtonsoft.Json.Serialization.JsonProperty property)
  System.Boolean CheckForCircularReference(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Void WriteReference(Newtonsoft.Json.JsonWriter writer, System.Object value)
  System.String GetReference(Newtonsoft.Json.JsonWriter writer, System.Object value)
  System.Boolean TryConvertToString(System.Object value, System.Type type, System.String& s)
  System.Void SerializeString(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonStringContract contract)
  System.Void OnSerializing(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value)
  System.Void OnSerialized(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonContract contract, System.Object value)
  System.Void SerializeObject(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonObjectContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Boolean CalculatePropertyValues(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonProperty property, Newtonsoft.Json.Serialization.JsonContract& memberContract, System.Object& memberValue)
  System.Void WriteObjectStart(Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Boolean HasCreatorParameter(Newtonsoft.Json.Serialization.JsonContainerContract contract, Newtonsoft.Json.Serialization.JsonProperty property)
  System.Void WriteReferenceIdProperty(Newtonsoft.Json.JsonWriter writer, System.Type type, System.Object value)
  System.Void WriteTypeProperty(Newtonsoft.Json.JsonWriter writer, System.Type type)
  System.Boolean HasFlag(Newtonsoft.Json.DefaultValueHandling value, Newtonsoft.Json.DefaultValueHandling flag)
  System.Boolean HasFlag(Newtonsoft.Json.PreserveReferencesHandling value, Newtonsoft.Json.PreserveReferencesHandling flag)
  System.Boolean HasFlag(Newtonsoft.Json.TypeNameHandling value, Newtonsoft.Json.TypeNameHandling flag)
  System.Void SerializeConvertable(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.JsonConverter converter, System.Object value, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Void SerializeList(Newtonsoft.Json.JsonWriter writer, System.Collections.IEnumerable values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Void SerializeMultidimensionalArray(Newtonsoft.Json.JsonWriter writer, System.Array values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, System.Int32 initialDepth, System.Int32[] indices)
  System.Boolean WriteStartArray(Newtonsoft.Json.JsonWriter writer, System.Object values, Newtonsoft.Json.Serialization.JsonArrayContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Void SerializeISerializable(Newtonsoft.Json.JsonWriter writer, System.Runtime.Serialization.ISerializable value, Newtonsoft.Json.Serialization.JsonISerializableContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Void SerializeDynamic(Newtonsoft.Json.JsonWriter writer, System.Dynamic.IDynamicMetaObjectProvider value, Newtonsoft.Json.Serialization.JsonDynamicContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Boolean ShouldWriteDynamicProperty(System.Object memberValue)
  System.Boolean ShouldWriteType(Newtonsoft.Json.TypeNameHandling typeNameHandlingFlag, Newtonsoft.Json.Serialization.JsonContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract containerContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.Void SerializeDictionary(Newtonsoft.Json.JsonWriter writer, System.Collections.IDictionary values, Newtonsoft.Json.Serialization.JsonDictionaryContract contract, Newtonsoft.Json.Serialization.JsonProperty member, Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, Newtonsoft.Json.Serialization.JsonProperty containerProperty)
  System.String GetPropertyName(Newtonsoft.Json.JsonWriter writer, System.Object name, Newtonsoft.Json.Serialization.JsonContract contract, System.Boolean& escape)
  System.Void HandleError(Newtonsoft.Json.JsonWriter writer, System.Int32 initialDepth)
  System.Boolean ShouldSerialize(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target)
  System.Boolean IsSpecified(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Serialization.JsonProperty property, System.Object target)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonSerializerProxy
TYPE:  class
TOKEN: 0x20000D0
EXTENDS: JsonSerializer
FIELDS:
  private   readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader_serializerReader  // 0xE0
  private   readonly Newtonsoft.Json.Serialization.JsonSerializerInternalWriter_serializerWriter  // 0xE8
  private   readonly Newtonsoft.Json.JsonSerializer  _serializer  // 0xF0
METHODS:
  System.Void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value)
  System.Void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value)
  System.Void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver value)
  Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter()
  System.Void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter value)
  System.Void set_EqualityComparer(System.Collections.IEqualityComparer value)
  Newtonsoft.Json.JsonConverterCollection get_Converters()
  System.Void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling value)
  Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver()
  System.Void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver value)
  System.Void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling value)
  Newtonsoft.Json.NullValueHandling get_NullValueHandling()
  System.Void set_NullValueHandling(Newtonsoft.Json.NullValueHandling value)
  System.Void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling value)
  System.Void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling value)
  System.Void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling value)
  System.Void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling value)
  Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling()
  System.Void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling value)
  System.Void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling value)
  System.Void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling value)
  System.Void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder value)
  System.Runtime.Serialization.StreamingContext get_Context()
  System.Void set_Context(System.Runtime.Serialization.StreamingContext value)
  Newtonsoft.Json.Formatting get_Formatting()
  System.Void set_Formatting(Newtonsoft.Json.Formatting value)
  System.Nullable<System.Int32> get_MaxDepth()
  System.Boolean get_CheckAdditionalContent()
  System.Void set_CheckAdditionalContent(System.Boolean value)
  Newtonsoft.Json.Serialization.JsonSerializerInternalBase GetInternalSerializer()
  System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalReader serializerReader)
  System.Void .ctor(Newtonsoft.Json.Serialization.JsonSerializerInternalWriter serializerWriter)
  System.Object DeserializeInternal(Newtonsoft.Json.JsonReader reader, System.Type objectType)
  System.Void PopulateInternal(Newtonsoft.Json.JsonReader reader, System.Object target)
  System.Void SerializeInternal(Newtonsoft.Json.JsonWriter jsonWriter, System.Object value, System.Type rootType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonStringContract
TYPE:  class
TOKEN: 0x20000D1
EXTENDS: JsonPrimitiveContract
FIELDS:
METHODS:
  System.Void .ctor(System.Type underlyingType)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.JsonTypeReflector
TYPE:  class
TOKEN: 0x20000D2
FIELDS:
  private   static  System.Nullable<System.Boolean> _fullyTrusted  // 0x0
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Func<System.Object[],System.Object>>CreatorCache  // 0x8
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Type>AssociatedMetadataTypesCache  // 0x10
  private   static  Newtonsoft.Json.Utilities.ReflectionObject_metadataTypeAttributeReflectionObject  // 0x18
METHODS:
  T GetCachedAttribute(System.Object attributeProvider)
  System.Boolean CanTypeDescriptorConvertString(System.Type type, System.ComponentModel.TypeConverter& typeConverter)
  System.Runtime.Serialization.DataContractAttribute GetDataContractAttribute(System.Type type)
  System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute(System.Reflection.MemberInfo memberInfo)
  Newtonsoft.Json.MemberSerialization GetObjectMemberSerialization(System.Type objectType, System.Boolean ignoreSerializableAttribute)
  Newtonsoft.Json.JsonConverter GetJsonConverter(System.Object attributeProvider)
  Newtonsoft.Json.JsonConverter CreateJsonConverterInstance(System.Type converterType, System.Object[] args)
  Newtonsoft.Json.Serialization.NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, System.Object[] args)
  Newtonsoft.Json.Serialization.NamingStrategy GetContainerNamingStrategy(Newtonsoft.Json.JsonContainerAttribute containerAttribute)
  System.Func<System.Object[],System.Object> GetCreator(System.Type type)
  System.Type GetAssociatedMetadataType(System.Type type)
  System.Type GetAssociateMetadataTypeFromAttribute(System.Type type)
  T GetAttribute(System.Type type)
  T GetAttribute(System.Reflection.MemberInfo memberInfo)
  System.Boolean IsNonSerializable(System.Object provider)
  System.Boolean IsSerializable(System.Object provider)
  T GetAttribute(System.Object provider)
  System.Boolean get_FullyTrusted()
  Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_ReflectionDelegateFactory()
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.KebabCaseNamingStrategy
TYPE:  class
TOKEN: 0x20000D5
EXTENDS: NamingStrategy
FIELDS:
METHODS:
  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames)
  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames)
  System.Void .ctor()
  System.String ResolvePropertyName(System.String name)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.NamingStrategy
TYPE:  class
TOKEN: 0x20000D6
FIELDS:
  private           System.Boolean                  <ProcessDictionaryKeys>k__BackingField  // 0x10
  private           System.Boolean                  <ProcessExtensionDataNames>k__BackingField  // 0x11
  private           System.Boolean                  <OverrideSpecifiedNames>k__BackingField  // 0x12
METHODS:
  System.Boolean get_ProcessDictionaryKeys()
  System.Void set_ProcessDictionaryKeys(System.Boolean value)
  System.Boolean get_ProcessExtensionDataNames()
  System.Void set_ProcessExtensionDataNames(System.Boolean value)
  System.Boolean get_OverrideSpecifiedNames()
  System.Void set_OverrideSpecifiedNames(System.Boolean value)
  System.String GetPropertyName(System.String name, System.Boolean hasSpecifiedName)
  System.String GetExtensionDataName(System.String name)
  System.String GetDictionaryKey(System.String key)
  System.String ResolvePropertyName(System.String name)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(Newtonsoft.Json.Serialization.NamingStrategy other)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ObjectConstructor`1
TYPE:  class
TOKEN: 0x20000D7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Object Invoke(System.Object[] args)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.OnErrorAttribute
TYPE:  class
TOKEN: 0x20000D8
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ReflectionAttributeProvider
TYPE:  class
TOKEN: 0x20000D9
FIELDS:
  private   readonly System.Object                   _attributeProvider  // 0x10
METHODS:
  System.Void .ctor(System.Object attributeProvider)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.ReflectionValueProvider
TYPE:  class
TOKEN: 0x20000DA
FIELDS:
  private   readonly System.Reflection.MemberInfo    _memberInfo  // 0x10
METHODS:
  System.Void .ctor(System.Reflection.MemberInfo memberInfo)
  System.Void SetValue(System.Object target, System.Object value)
  System.Object GetValue(System.Object target)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy
TYPE:  class
TOKEN: 0x20000DB
EXTENDS: NamingStrategy
FIELDS:
METHODS:
  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames)
  System.Void .ctor(System.Boolean processDictionaryKeys, System.Boolean overrideSpecifiedNames, System.Boolean processExtensionDataNames)
  System.Void .ctor()
  System.String ResolvePropertyName(System.String name)
END_CLASS

CLASS: Newtonsoft.Json.Serialization.TraceJsonReader
TYPE:  class
TOKEN: 0x20000DC
EXTENDS: JsonReader
FIELDS:
  private   readonly Newtonsoft.Json.JsonReader      _innerReader  // 0x78
  private   readonly Newtonsoft.Json.JsonTextWriter  _textWriter  // 0x80
  private   readonly System.IO.StringWriter          _sw  // 0x88
METHODS:
  System.Void .ctor(Newtonsoft.Json.JsonReader innerReader)
  System.String GetDeserializedJsonMessage()
  System.Boolean Read()
  System.Nullable<System.Int32> ReadAsInt32()
  System.String ReadAsString()
  System.Byte[] ReadAsBytes()
  System.Nullable<System.Decimal> ReadAsDecimal()
  System.Nullable<System.Double> ReadAsDouble()
  System.Nullable<System.Boolean> ReadAsBoolean()
  System.Nullable<System.DateTime> ReadAsDateTime()
  System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset()
  System.Void WriteCurrentToken()
  System.Int32 get_Depth()
  System.String get_Path()
  Newtonsoft.Json.JsonToken get_TokenType()
  System.Object get_Value()
  System.Type get_ValueType()
  System.Void Close()
  System.Boolean Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
  System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LineNumber()
  System.Int32 Newtonsoft.Json.IJsonLineInfo.get_LinePosition()
END_CLASS

CLASS: Newtonsoft.Json.Serialization.TraceJsonWriter
TYPE:  class
TOKEN: 0x20000DD
EXTENDS: JsonWriter
FIELDS:
  private   readonly Newtonsoft.Json.JsonWriter      _innerWriter  // 0x60
  private   readonly Newtonsoft.Json.JsonTextWriter  _textWriter  // 0x68
  private   readonly System.IO.StringWriter          _sw  // 0x70
METHODS:
  System.Void .ctor(Newtonsoft.Json.JsonWriter innerWriter)
  System.String GetSerializedJsonMessage()
  System.Void WriteValue(System.Decimal value)
  System.Void WriteValue(System.Nullable<System.Decimal> value)
  System.Void WriteValue(System.Boolean value)
  System.Void WriteValue(System.Nullable<System.Boolean> value)
  System.Void WriteValue(System.Byte value)
  System.Void WriteValue(System.Nullable<System.Byte> value)
  System.Void WriteValue(System.Char value)
  System.Void WriteValue(System.Nullable<System.Char> value)
  System.Void WriteValue(System.Byte[] value)
  System.Void WriteValue(System.DateTime value)
  System.Void WriteValue(System.Nullable<System.DateTime> value)
  System.Void WriteValue(System.DateTimeOffset value)
  System.Void WriteValue(System.Nullable<System.DateTimeOffset> value)
  System.Void WriteValue(System.Double value)
  System.Void WriteValue(System.Nullable<System.Double> value)
  System.Void WriteUndefined()
  System.Void WriteNull()
  System.Void WriteValue(System.Single value)
  System.Void WriteValue(System.Nullable<System.Single> value)
  System.Void WriteValue(System.Guid value)
  System.Void WriteValue(System.Nullable<System.Guid> value)
  System.Void WriteValue(System.Int32 value)
  System.Void WriteValue(System.Nullable<System.Int32> value)
  System.Void WriteValue(System.Int64 value)
  System.Void WriteValue(System.Nullable<System.Int64> value)
  System.Void WriteValue(System.Object value)
  System.Void WriteValue(System.SByte value)
  System.Void WriteValue(System.Nullable<System.SByte> value)
  System.Void WriteValue(System.Int16 value)
  System.Void WriteValue(System.Nullable<System.Int16> value)
  System.Void WriteValue(System.String value)
  System.Void WriteValue(System.TimeSpan value)
  System.Void WriteValue(System.Nullable<System.TimeSpan> value)
  System.Void WriteValue(System.UInt32 value)
  System.Void WriteValue(System.Nullable<System.UInt32> value)
  System.Void WriteValue(System.UInt64 value)
  System.Void WriteValue(System.Nullable<System.UInt64> value)
  System.Void WriteValue(System.Uri value)
  System.Void WriteValue(System.UInt16 value)
  System.Void WriteValue(System.Nullable<System.UInt16> value)
  System.Void WriteComment(System.String text)
  System.Void WriteStartArray()
  System.Void WriteEndArray()
  System.Void WriteStartConstructor(System.String name)
  System.Void WriteEndConstructor()
  System.Void WritePropertyName(System.String name)
  System.Void WritePropertyName(System.String name, System.Boolean escape)
  System.Void WriteStartObject()
  System.Void WriteEndObject()
  System.Void WriteRawValue(System.String json)
  System.Void WriteRaw(System.String json)
  System.Void Close()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.AotHelper
TYPE:  class
TOKEN: 0x200003F
FIELDS:
  private   static  System.Boolean                  s_alwaysFalse  // 0x0
METHODS:
  System.Void Ensure(System.Action action)
  System.Void EnsureList()
  System.Boolean IsFalse()
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.Base64Encoder
TYPE:  class
TOKEN: 0x2000041
FIELDS:
  private   readonly System.Char[]                   _charsLine  // 0x10
  private   readonly System.IO.TextWriter            _writer  // 0x18
  private           System.Byte[]                   _leftOverBytes  // 0x20
  private           System.Int32                    _leftOverBytesCount  // 0x28
METHODS:
  System.Void .ctor(System.IO.TextWriter writer)
  System.Void ValidateEncode(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Void Encode(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Void StoreLeftOverBytes(System.Byte[] buffer, System.Int32 index, System.Int32& count)
  System.Boolean FulfillFromLeftover(System.Byte[] buffer, System.Int32 index, System.Int32& count)
  System.Void Flush()
  System.Void WriteChars(System.Char[] chars, System.Int32 index, System.Int32 count)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.BidirectionalDictionary`2
TYPE:  class
TOKEN: 0x2000042
FIELDS:
  private   readonly System.Collections.Generic.IDictionary<TFirst,TSecond>_firstToSecond  // 0x0
  private   readonly System.Collections.Generic.IDictionary<TSecond,TFirst>_secondToFirst  // 0x0
  private   readonly System.String                   _duplicateFirstErrorMessage  // 0x0
  private   readonly System.String                   _duplicateSecondErrorMessage  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, System.String duplicateFirstErrorMessage, System.String duplicateSecondErrorMessage)
  System.Void Set(TFirst first, TSecond second)
  System.Boolean TryGetByFirst(TFirst first, TSecond& second)
  System.Boolean TryGetBySecond(TSecond second, TFirst& first)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.BoxedPrimitives
TYPE:  class
TOKEN: 0x2000043
FIELDS:
  private   static readonly System.Object                   BooleanTrue  // 0x0
  private   static readonly System.Object                   BooleanFalse  // 0x8
  private   static readonly System.Object                   Int32_M1  // 0x10
  private   static readonly System.Object                   Int32_0  // 0x18
  private   static readonly System.Object                   Int32_1  // 0x20
  private   static readonly System.Object                   Int32_2  // 0x28
  private   static readonly System.Object                   Int32_3  // 0x30
  private   static readonly System.Object                   Int32_4  // 0x38
  private   static readonly System.Object                   Int32_5  // 0x40
  private   static readonly System.Object                   Int32_6  // 0x48
  private   static readonly System.Object                   Int32_7  // 0x50
  private   static readonly System.Object                   Int32_8  // 0x58
  private   static readonly System.Object                   Int64_M1  // 0x60
  private   static readonly System.Object                   Int64_0  // 0x68
  private   static readonly System.Object                   Int64_1  // 0x70
  private   static readonly System.Object                   Int64_2  // 0x78
  private   static readonly System.Object                   Int64_3  // 0x80
  private   static readonly System.Object                   Int64_4  // 0x88
  private   static readonly System.Object                   Int64_5  // 0x90
  private   static readonly System.Object                   Int64_6  // 0x98
  private   static readonly System.Object                   Int64_7  // 0xA0
  private   static readonly System.Object                   Int64_8  // 0xA8
  private   static readonly System.Object                   DecimalZero  // 0xB0
  private   static readonly System.Object                   DoubleNaN  // 0xB8
  private   static readonly System.Object                   DoublePositiveInfinity  // 0xC0
  private   static readonly System.Object                   DoubleNegativeInfinity  // 0xC8
  private   static readonly System.Object                   DoubleZero  // 0xD0
METHODS:
  System.Object Get(System.Boolean value)
  System.Object Get(System.Int32 value)
  System.Object Get(System.Int64 value)
  System.Object Get(System.Decimal value)
  System.Object Get(System.Double value)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.CollectionUtils
TYPE:  class
TOKEN: 0x2000044
FIELDS:
METHODS:
  System.Boolean IsNullOrEmpty(System.Collections.Generic.ICollection<T> collection)
  System.Void AddRange(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection)
  System.Boolean IsDictionaryType(System.Type type)
  System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType)
  System.Reflection.ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType)
  System.Int32 IndexOf(System.Collections.Generic.IEnumerable<T> collection, System.Func<T,System.Boolean> predicate)
  System.Boolean Contains(System.Collections.Generic.List<T> list, T value, System.Collections.IEqualityComparer comparer)
  System.Int32 IndexOfReference(System.Collections.Generic.List<T> list, T item)
  System.Void FastReverse(System.Collections.Generic.List<T> list)
  System.Collections.Generic.IList<System.Int32> GetDimensions(System.Collections.IList values, System.Int32 dimensionsCount)
  System.Void CopyFromJaggedToMultidimensionalArray(System.Collections.IList values, System.Array multidimensionalArray, System.Int32[] indices)
  System.Object JaggedArrayGetValue(System.Collections.IList values, System.Int32[] indices)
  System.Array ToMultidimensionalArray(System.Collections.IList values, System.Type type, System.Int32 rank)
  T[] ArrayEmpty()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.IWrappedCollection
TYPE:  interface
TOKEN: 0x2000046
FIELDS:
METHODS:
  System.Object get_UnderlyingCollection()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.CollectionWrapper`1
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  private   readonly System.Collections.IList        _list  // 0x0
  private   readonly System.Collections.Generic.ICollection<T>_genericCollection  // 0x0
  private           System.Object                   _syncRoot  // 0x0
METHODS:
  System.Void .ctor(System.Collections.IList list)
  System.Void .ctor(System.Collections.Generic.ICollection<T> list)
  System.Void Add(T item)
  System.Void Clear()
  System.Boolean Contains(T item)
  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Boolean Remove(T item)
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Void System.Collections.IList.RemoveAt(System.Int32 index)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Boolean System.Collections.IList.get_IsFixedSize()
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Object System.Collections.IList.get_Item(System.Int32 index)
  System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex)
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Void VerifyValueType(System.Object value)
  System.Boolean IsCompatibleObject(System.Object value)
  System.Object get_UnderlyingCollection()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.PrimitiveTypeCode
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeEmpty  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeObject  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeChar  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeCharNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeBoolean  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeBooleanNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeSByte  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeSByteNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt16  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt16Nullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt16  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt16Nullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt32  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt32Nullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeByte  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeByteNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt32  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt32Nullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt64  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeInt64Nullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt64  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUInt64Nullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeSingle  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeSingleNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDouble  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDoubleNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDateTime  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDateTimeNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDateTimeOffset  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDateTimeOffsetNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDecimal  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDecimalNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeGuid  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeGuidNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeTimeSpan  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeTimeSpanNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeBigInteger  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeBigIntegerNullable  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeUri  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeString  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeBytes  // 0x0
  public    static  Newtonsoft.Json.Utilities.PrimitiveTypeCodeDBNull  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Utilities.TypeInformation
TYPE:  class
TOKEN: 0x2000049
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x10
  private   readonly Newtonsoft.Json.Utilities.PrimitiveTypeCode<TypeCode>k__BackingField  // 0x18
METHODS:
  System.Type get_Type()
  Newtonsoft.Json.Utilities.PrimitiveTypeCode get_TypeCode()
  System.Void .ctor(System.Type type, Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ParseResult
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Utilities.ParseResultNone  // 0x0
  public    static  Newtonsoft.Json.Utilities.ParseResultSuccess  // 0x0
  public    static  Newtonsoft.Json.Utilities.ParseResultOverflow  // 0x0
  public    static  Newtonsoft.Json.Utilities.ParseResultInvalid  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ConvertUtils
TYPE:  class
TOKEN: 0x200004B
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.Utilities.PrimitiveTypeCode>TypeCodeMap  // 0x0
  private   static readonly Newtonsoft.Json.Utilities.TypeInformation[]PrimitiveTypeCodes  // 0x8
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type>,System.Func<System.Object,System.Object>>CastConverters  // 0x10
METHODS:
  Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t)
  Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(System.Type t, System.Boolean& isEnum)
  Newtonsoft.Json.Utilities.TypeInformation GetTypeInformation(System.IConvertible convertable)
  System.Boolean IsConvertible(System.Type t)
  System.TimeSpan ParseTimeSpan(System.String input)
  System.Func<System.Object,System.Object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type> t)
  System.Numerics.BigInteger ToBigInteger(System.Object value)
  System.Object FromBigInteger(System.Numerics.BigInteger i, System.Type targetType)
  System.Object Convert(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType)
  System.Boolean TryConvert(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, System.Object& value)
  Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult TryConvertInternal(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType, System.Object& value)
  System.Object ConvertOrCast(System.Object initialValue, System.Globalization.CultureInfo culture, System.Type targetType)
  System.Object EnsureTypeAssignable(System.Object value, System.Type initialType, System.Type targetType)
  System.Boolean VersionTryParse(System.String input, System.Version& result)
  System.Boolean IsInteger(System.Object value)
  Newtonsoft.Json.Utilities.ParseResult Int32TryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Int32& value)
  Newtonsoft.Json.Utilities.ParseResult Int64TryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Int64& value)
  Newtonsoft.Json.Utilities.ParseResult DecimalTryParse(System.Char[] chars, System.Int32 start, System.Int32 length, System.Decimal& value)
  System.Boolean TryConvertGuid(System.String s, System.Guid& g)
  System.Boolean TryHexTextToInt(System.Char[] text, System.Int32 start, System.Int32 end, System.Int32& value)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ParserTimeZone
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Newtonsoft.Json.Utilities.ParserTimeZoneUnspecified  // 0x0
  public    static  Newtonsoft.Json.Utilities.ParserTimeZoneUtc  // 0x0
  public    static  Newtonsoft.Json.Utilities.ParserTimeZoneLocalWestOfUtc  // 0x0
  public    static  Newtonsoft.Json.Utilities.ParserTimeZoneLocalEastOfUtc  // 0x0
METHODS:
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DateTimeParser
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public            System.Int32                    Year  // 0x10
  public            System.Int32                    Month  // 0x14
  public            System.Int32                    Day  // 0x18
  public            System.Int32                    Hour  // 0x1C
  public            System.Int32                    Minute  // 0x20
  public            System.Int32                    Second  // 0x24
  public            System.Int32                    Fraction  // 0x28
  public            System.Int32                    ZoneHour  // 0x2C
  public            System.Int32                    ZoneMinute  // 0x30
  public            Newtonsoft.Json.Utilities.ParserTimeZoneZone  // 0x34
  private           System.Char[]                   _text  // 0x38
  private           System.Int32                    _end  // 0x40
  private   static readonly System.Int32[]                  Power10  // 0x0
  private   static readonly System.Int32                    Lzyyyy  // 0x8
  private   static readonly System.Int32                    Lzyyyy_  // 0xC
  private   static readonly System.Int32                    Lzyyyy_MM  // 0x10
  private   static readonly System.Int32                    Lzyyyy_MM_  // 0x14
  private   static readonly System.Int32                    Lzyyyy_MM_dd  // 0x18
  private   static readonly System.Int32                    Lzyyyy_MM_ddT  // 0x1C
  private   static readonly System.Int32                    LzHH  // 0x20
  private   static readonly System.Int32                    LzHH_  // 0x24
  private   static readonly System.Int32                    LzHH_mm  // 0x28
  private   static readonly System.Int32                    LzHH_mm_  // 0x2C
  private   static readonly System.Int32                    LzHH_mm_ss  // 0x30
  private   static readonly System.Int32                    Lz_  // 0x34
  private   static readonly System.Int32                    Lz_zz  // 0x38
METHODS:
  System.Void .cctor()
  System.Boolean Parse(System.Char[] text, System.Int32 startIndex, System.Int32 length)
  System.Boolean ParseDate(System.Int32 start)
  System.Boolean ParseTimeAndZoneAndWhitespace(System.Int32 start)
  System.Boolean ParseTime(System.Int32& start)
  System.Boolean ParseZone(System.Int32 start)
  System.Boolean Parse4Digit(System.Int32 start, System.Int32& num)
  System.Boolean Parse2Digit(System.Int32 start, System.Int32& num)
  System.Boolean ParseChar(System.Int32 start, System.Char ch)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DateTimeUtils
TYPE:  class
TOKEN: 0x2000050
FIELDS:
  private   static readonly System.Int64                    InitialJavaScriptDateTicks  // 0x0
  private   static readonly System.Int32[]                  DaysToMonth365  // 0x8
  private   static readonly System.Int32[]                  DaysToMonth366  // 0x10
METHODS:
  System.Void .cctor()
  System.TimeSpan GetUtcOffset(System.DateTime d)
  System.Xml.XmlDateTimeSerializationMode ToSerializationMode(System.DateTimeKind kind)
  System.DateTime EnsureDateTime(System.DateTime value, Newtonsoft.Json.DateTimeZoneHandling timeZone)
  System.DateTime SwitchToLocalTime(System.DateTime value)
  System.DateTime SwitchToUtcTime(System.DateTime value)
  System.Int64 ToUniversalTicks(System.DateTime dateTime)
  System.Int64 ToUniversalTicks(System.DateTime dateTime, System.TimeSpan offset)
  System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.TimeSpan offset)
  System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime)
  System.Int64 ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, System.Boolean convertToUtc)
  System.Int64 UniversalTicksToJavaScriptTicks(System.Int64 universalTicks)
  System.DateTime ConvertJavaScriptTicksToDateTime(System.Int64 javaScriptTicks)
  System.Boolean TryParseDateTimeIso(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.DateTime& dt)
  System.Boolean TryParseDateTimeOffsetIso(Newtonsoft.Json.Utilities.StringReference text, System.DateTimeOffset& dt)
  System.DateTime CreateDateTime(Newtonsoft.Json.Utilities.DateTimeParser dateTimeParser)
  System.Boolean TryParseDateTime(Newtonsoft.Json.Utilities.StringReference s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt)
  System.Boolean TryParseDateTime(System.String s, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt)
  System.Boolean TryParseDateTimeOffset(Newtonsoft.Json.Utilities.StringReference s, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt)
  System.Boolean TryParseDateTimeOffset(System.String s, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt)
  System.Boolean TryParseMicrosoftDate(Newtonsoft.Json.Utilities.StringReference text, System.Int64& ticks, System.TimeSpan& offset, System.DateTimeKind& kind)
  System.Boolean TryParseDateTimeMicrosoft(Newtonsoft.Json.Utilities.StringReference text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.DateTime& dt)
  System.Boolean TryParseDateTimeExact(System.String text, Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTime& dt)
  System.Boolean TryParseDateTimeOffsetMicrosoft(Newtonsoft.Json.Utilities.StringReference text, System.DateTimeOffset& dt)
  System.Boolean TryParseDateTimeOffsetExact(System.String text, System.String dateFormatString, System.Globalization.CultureInfo culture, System.DateTimeOffset& dt)
  System.Boolean TryReadOffset(Newtonsoft.Json.Utilities.StringReference offsetText, System.Int32 startIndex, System.TimeSpan& offset)
  System.Void WriteDateTimeString(System.IO.TextWriter writer, System.DateTime value, Newtonsoft.Json.DateFormatHandling format, System.String formatString, System.Globalization.CultureInfo culture)
  System.Int32 WriteDateTimeString(System.Char[] chars, System.Int32 start, System.DateTime value, System.Nullable<System.TimeSpan> offset, System.DateTimeKind kind, Newtonsoft.Json.DateFormatHandling format)
  System.Int32 WriteDefaultIsoDate(System.Char[] chars, System.Int32 start, System.DateTime dt)
  System.Void CopyIntToCharArray(System.Char[] chars, System.Int32 start, System.Int32 value, System.Int32 digits)
  System.Int32 WriteDateTimeOffset(System.Char[] chars, System.Int32 start, System.TimeSpan offset, Newtonsoft.Json.DateFormatHandling format)
  System.Void WriteDateTimeOffsetString(System.IO.TextWriter writer, System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format, System.String formatString, System.Globalization.CultureInfo culture)
  System.Void GetDateValues(System.DateTime td, System.Int32& year, System.Int32& month, System.Int32& day)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.IWrappedDictionary
TYPE:  interface
TOKEN: 0x2000051
FIELDS:
METHODS:
  System.Object get_UnderlyingDictionary()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DictionaryWrapper`2
TYPE:  class
TOKEN: 0x2000052
FIELDS:
  private   readonly System.Collections.IDictionary  _dictionary  // 0x0
  private   readonly System.Collections.Generic.IDictionary<TKey,TValue>_genericDictionary  // 0x0
  private   readonly System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>_readOnlyDictionary  // 0x0
  private           System.Object                   _syncRoot  // 0x0
METHODS:
  System.Collections.Generic.IDictionary<TKey,TValue> get_GenericDictionary()
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
  System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value)
  System.Object System.Collections.IDictionary.get_Item(System.Object key)
  System.Void System.Collections.IDictionary.set_Item(System.Object key, System.Object value)
  System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
  System.Boolean System.Collections.IDictionary.Contains(System.Object key)
  System.Boolean System.Collections.IDictionary.get_IsFixedSize()
  System.Collections.ICollection System.Collections.IDictionary.get_Keys()
  System.Void Remove(System.Object key)
  System.Collections.ICollection System.Collections.IDictionary.get_Values()
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Object get_UnderlyingDictionary()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DynamicProxy`1
TYPE:  class
TOKEN: 0x2000055
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(T instance)
  System.Boolean TryBinaryOperation(T instance, System.Dynamic.BinaryOperationBinder binder, System.Object arg, System.Object& result)
  System.Boolean TryConvert(T instance, System.Dynamic.ConvertBinder binder, System.Object& result)
  System.Boolean TryCreateInstance(T instance, System.Dynamic.CreateInstanceBinder binder, System.Object[] args, System.Object& result)
  System.Boolean TryDeleteIndex(T instance, System.Dynamic.DeleteIndexBinder binder, System.Object[] indexes)
  System.Boolean TryDeleteMember(T instance, System.Dynamic.DeleteMemberBinder binder)
  System.Boolean TryGetIndex(T instance, System.Dynamic.GetIndexBinder binder, System.Object[] indexes, System.Object& result)
  System.Boolean TryGetMember(T instance, System.Dynamic.GetMemberBinder binder, System.Object& result)
  System.Boolean TryInvoke(T instance, System.Dynamic.InvokeBinder binder, System.Object[] args, System.Object& result)
  System.Boolean TryInvokeMember(T instance, System.Dynamic.InvokeMemberBinder binder, System.Object[] args, System.Object& result)
  System.Boolean TrySetIndex(T instance, System.Dynamic.SetIndexBinder binder, System.Object[] indexes, System.Object value)
  System.Boolean TrySetMember(T instance, System.Dynamic.SetMemberBinder binder, System.Object value)
  System.Boolean TryUnaryOperation(T instance, System.Dynamic.UnaryOperationBinder binder, System.Object& result)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1
TYPE:  class
TOKEN: 0x2000056
EXTENDS: DynamicMetaObject
FIELDS:
  private   readonly Newtonsoft.Json.Utilities.DynamicProxy<T>_proxy  // 0x0
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy)
  System.Boolean IsOverridden(System.String method)
  System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder)
  System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value)
  System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder)
  System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder)
  System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg)
  System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder)
  System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes)
  System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value)
  System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes)
  System.Linq.Expressions.Expression[] get_NoArgs()
  System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(System.Dynamic.DynamicMetaObject[] args)
  System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args)
  System.Linq.Expressions.Expression[] GetArgArray(System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject value)
  System.Linq.Expressions.ConstantExpression Constant(System.Dynamic.DynamicMetaObjectBinder binder)
  System.Dynamic.DynamicMetaObject CallMethodWithResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke)
  System.Dynamic.DynamicMetaObject BuildCallMethodWithResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, System.Dynamic.DynamicMetaObject fallbackResult, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallbackInvoke)
  System.Dynamic.DynamicMetaObject CallMethodReturnLast(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback)
  System.Dynamic.DynamicMetaObject CallMethodNoResult(System.String methodName, System.Dynamic.DynamicMetaObjectBinder binder, System.Linq.Expressions.Expression[] args, Newtonsoft.Json.Utilities.DynamicProxyMetaObject.Fallback<T> fallback)
  System.Dynamic.BindingRestrictions GetRestrictions()
  System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.DynamicUtils
TYPE:  class
TOKEN: 0x2000066
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(System.Dynamic.IDynamicMetaObjectProvider dynamicProvider)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.NoThrowGetBinderMember
TYPE:  class
TOKEN: 0x2000068
EXTENDS: GetMemberBinder
FIELDS:
  private   readonly System.Dynamic.GetMemberBinder  _innerBinder  // 0x28
METHODS:
  System.Void .ctor(System.Dynamic.GetMemberBinder innerBinder)
  System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.NoThrowSetBinderMember
TYPE:  class
TOKEN: 0x2000069
EXTENDS: SetMemberBinder
FIELDS:
  private   readonly System.Dynamic.SetMemberBinder  _innerBinder  // 0x28
METHODS:
  System.Void .ctor(System.Dynamic.SetMemberBinder innerBinder)
  System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.NoThrowExpressionVisitor
TYPE:  class
TOKEN: 0x200006A
EXTENDS: ExpressionVisitor
FIELDS:
  private   static readonly System.Object                   ErrorResult  // 0x0
METHODS:
  System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.EnumInfo
TYPE:  class
TOKEN: 0x200006B
FIELDS:
  public    readonly System.Boolean                  IsFlags  // 0x10
  public    readonly System.UInt64[]                 Values  // 0x18
  public    readonly System.String[]                 Names  // 0x20
  public    readonly System.String[]                 ResolvedNames  // 0x28
METHODS:
  System.Void .ctor(System.Boolean isFlags, System.UInt64[] values, System.String[] names, System.String[] resolvedNames)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.EnumUtils
TYPE:  class
TOKEN: 0x200006C
FIELDS:
  private   static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo>ValuesAndNamesPerEnum  // 0x0
  private   static  Newtonsoft.Json.Serialization.CamelCaseNamingStrategy_camelCaseNamingStrategy  // 0x8
METHODS:
  Newtonsoft.Json.Utilities.EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy> key)
  System.Boolean TryToString(System.Type enumType, System.Object value, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.String& name)
  System.String InternalFlagsFormat(Newtonsoft.Json.Utilities.EnumInfo entry, System.UInt64 result)
  Newtonsoft.Json.Utilities.EnumInfo GetEnumValuesAndNames(System.Type enumType)
  System.UInt64 ToUInt64(System.Object value)
  System.Object ParseEnum(System.Type enumType, Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, System.String value, System.Boolean disallowNumber)
  System.Nullable<System.Int32> MatchName(System.String value, System.String[] enumNames, System.String[] resolvedNames, System.Int32 valueIndex, System.Int32 valueSubstringLength, System.StringComparison comparison)
  System.Nullable<System.Int32> FindIndexByName(System.String[] enumNames, System.String value, System.Int32 valueIndex, System.Int32 valueSubstringLength, System.StringComparison comparison)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.FSharpFunction
TYPE:  class
TOKEN: 0x200006E
FIELDS:
  private   readonly System.Object                   _instance  // 0x10
  private   readonly Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object>_invoker  // 0x18
METHODS:
  System.Void .ctor(System.Object instance, Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoker)
  System.Object Invoke(System.Object[] args)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.FSharpUtils
TYPE:  class
TOKEN: 0x200006F
FIELDS:
  private   static readonly System.Object                   Lock  // 0x0
  private   static  Newtonsoft.Json.Utilities.FSharpUtils_instance  // 0x8
  private           System.Reflection.MethodInfo    _ofSeq  // 0x10
  private           System.Type                     _mapType  // 0x18
  private           System.Reflection.Assembly      <FSharpCoreAssembly>k__BackingField  // 0x20
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><IsUnion>k__BackingField  // 0x28
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><GetUnionCases>k__BackingField  // 0x30
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><PreComputeUnionTagReader>k__BackingField  // 0x38
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><PreComputeUnionReader>k__BackingField  // 0x40
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><PreComputeUnionConstructor>k__BackingField  // 0x48
  private           System.Func<System.Object,System.Object><GetUnionCaseInfoDeclaringType>k__BackingField  // 0x50
  private           System.Func<System.Object,System.Object><GetUnionCaseInfoName>k__BackingField  // 0x58
  private           System.Func<System.Object,System.Object><GetUnionCaseInfoTag>k__BackingField  // 0x60
  private           Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object><GetUnionCaseInfoFields>k__BackingField  // 0x68
METHODS:
  System.Void .ctor(System.Reflection.Assembly fsharpCoreAssembly)
  Newtonsoft.Json.Utilities.FSharpUtils get_Instance()
  System.Void set_FSharpCoreAssembly(System.Reflection.Assembly value)
  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_IsUnion()
  System.Void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value)
  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCases()
  System.Void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value)
  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionTagReader()
  System.Void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value)
  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionReader()
  System.Void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value)
  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionConstructor()
  System.Void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value)
  System.Func<System.Object,System.Object> get_GetUnionCaseInfoDeclaringType()
  System.Void set_GetUnionCaseInfoDeclaringType(System.Func<System.Object,System.Object> value)
  System.Func<System.Object,System.Object> get_GetUnionCaseInfoName()
  System.Void set_GetUnionCaseInfoName(System.Func<System.Object,System.Object> value)
  System.Func<System.Object,System.Object> get_GetUnionCaseInfoTag()
  System.Void set_GetUnionCaseInfoTag(System.Func<System.Object,System.Object> value)
  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCaseInfoFields()
  System.Void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value)
  System.Void EnsureInitialized(System.Reflection.Assembly fsharpCoreAssembly)
  System.Reflection.MethodInfo GetMethodWithNonPublicFallback(System.Type type, System.String methodName, System.Reflection.BindingFlags bindingFlags)
  Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> CreateFSharpFuncCall(System.Type type, System.String methodName)
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateSeq(System.Type t)
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateMap(System.Type keyType, System.Type valueType)
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> BuildMapCreator()
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ImmutableCollectionsUtils
TYPE:  class
TOKEN: 0x2000073
FIELDS:
  private   static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>ArrayContractImmutableCollectionDefinitions  // 0x0
  private   static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>DictionaryContractImmutableCollectionDefinitions  // 0x8
METHODS:
  System.Boolean TryBuildImmutableForArrayContract(System.Type underlyingType, System.Type collectionItemType, System.Type& createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator)
  System.Boolean TryBuildImmutableForDictionaryContract(System.Type underlyingType, System.Type keyItemType, System.Type valueItemType, System.Type& createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator)
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.BufferUtils
TYPE:  class
TOKEN: 0x2000078
FIELDS:
METHODS:
  System.Char[] RentBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 minSize)
  System.Void ReturnBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[] buffer)
  System.Char[] EnsureBufferSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 size, System.Char[] buffer)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.JavaScriptUtils
TYPE:  class
TOKEN: 0x2000079
FIELDS:
  private   static readonly System.Boolean[]                SingleQuoteCharEscapeFlags  // 0x0
  private   static readonly System.Boolean[]                DoubleQuoteCharEscapeFlags  // 0x8
  private   static readonly System.Boolean[]                HtmlCharEscapeFlags  // 0x10
METHODS:
  System.Void .cctor()
  System.Boolean[] GetCharEscapeFlags(Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, System.Char quoteChar)
  System.Boolean ShouldEscapeJavaScriptString(System.String s, System.Boolean[] charEscapeFlags)
  System.Void WriteEscapedJavaScriptString(System.IO.TextWriter writer, System.String s, System.Char delimiter, System.Boolean appendDelimiters, System.Boolean[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[]& writeBuffer)
  System.String ToEscapedJavaScriptString(System.String value, System.Char delimiter, System.Boolean appendDelimiters, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling)
  System.Int32 FirstCharToEscape(System.String s, System.Boolean[] charEscapeFlags, Newtonsoft.Json.StringEscapeHandling stringEscapeHandling)
  System.Boolean TryGetDateFromConstructorJson(Newtonsoft.Json.JsonReader reader, System.DateTime& dateTime, System.String& errorMessage)
  System.Boolean TryGetDateConstructorValue(Newtonsoft.Json.JsonReader reader, System.Nullable<System.Int64>& integer, System.String& errorMessage)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.JsonTokenUtils
TYPE:  class
TOKEN: 0x200007A
FIELDS:
METHODS:
  System.Boolean IsEndToken(Newtonsoft.Json.JsonToken token)
  System.Boolean IsStartToken(Newtonsoft.Json.JsonToken token)
  System.Boolean IsPrimitiveToken(Newtonsoft.Json.JsonToken token)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory
TYPE:  class
TOKEN: 0x200007B
EXTENDS: ReflectionDelegateFactory
FIELDS:
  private   static readonly Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory_instance  // 0x0
METHODS:
  Newtonsoft.Json.Utilities.ReflectionDelegateFactory get_Instance()
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(System.Reflection.MethodBase method)
  Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(System.Reflection.MethodBase method)
  System.Func<T> CreateDefaultConstructor(System.Type type)
  System.Func<T,System.Object> CreateGet(System.Reflection.PropertyInfo propertyInfo)
  System.Func<T,System.Object> CreateGet(System.Reflection.FieldInfo fieldInfo)
  System.Action<T,System.Object> CreateSet(System.Reflection.FieldInfo fieldInfo)
  System.Action<T,System.Object> CreateSet(System.Reflection.PropertyInfo propertyInfo)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.MathUtils
TYPE:  class
TOKEN: 0x2000083
FIELDS:
METHODS:
  System.Int32 IntLength(System.UInt64 i)
  System.Char IntToHex(System.Int32 n)
  System.Boolean ApproxEquals(System.Double d1, System.Double d2)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.MethodCall`2
TYPE:  class
TOKEN: 0x2000084
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T target, System.Object[] args)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.MiscellaneousUtils
TYPE:  class
TOKEN: 0x2000085
FIELDS:
METHODS:
  System.Boolean ValueEquals(System.Object objA, System.Object objB)
  System.ArgumentOutOfRangeException CreateArgumentOutOfRangeException(System.String paramName, System.Object actualValue, System.String message)
  System.String ToString(System.Object value)
  System.Int32 ByteArrayCompare(System.Byte[] a1, System.Byte[] a2)
  System.String GetPrefix(System.String qualifiedName)
  System.String GetLocalName(System.String qualifiedName)
  System.Void GetQualifiedNameParts(System.String qualifiedName, System.String& prefix, System.String& localName)
  System.Text.RegularExpressions.RegexOptions GetRegexOptions(System.String optionsText)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ReflectionDelegateFactory
TYPE:  class
TOKEN: 0x2000086
FIELDS:
METHODS:
  System.Func<T,System.Object> CreateGet(System.Reflection.MemberInfo memberInfo)
  System.Action<T,System.Object> CreateSet(System.Reflection.MemberInfo memberInfo)
  Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(System.Reflection.MethodBase method)
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(System.Reflection.MethodBase method)
  System.Func<T> CreateDefaultConstructor(System.Type type)
  System.Func<T,System.Object> CreateGet(System.Reflection.PropertyInfo propertyInfo)
  System.Func<T,System.Object> CreateGet(System.Reflection.FieldInfo fieldInfo)
  System.Action<T,System.Object> CreateSet(System.Reflection.FieldInfo fieldInfo)
  System.Action<T,System.Object> CreateSet(System.Reflection.PropertyInfo propertyInfo)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ReflectionMember
TYPE:  class
TOKEN: 0x2000087
FIELDS:
  private           System.Type                     <MemberType>k__BackingField  // 0x10
  private           System.Func<System.Object,System.Object><Getter>k__BackingField  // 0x18
  private           System.Action<System.Object,System.Object><Setter>k__BackingField  // 0x20
METHODS:
  System.Type get_MemberType()
  System.Void set_MemberType(System.Type value)
  System.Func<System.Object,System.Object> get_Getter()
  System.Void set_Getter(System.Func<System.Object,System.Object> value)
  System.Action<System.Object,System.Object> get_Setter()
  System.Void set_Setter(System.Action<System.Object,System.Object> value)
  System.Void .ctor()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ReflectionObject
TYPE:  class
TOKEN: 0x2000088
FIELDS:
  private   readonly Newtonsoft.Json.Serialization.ObjectConstructor<System.Object><Creator>k__BackingField  // 0x10
  private   readonly System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember><Members>k__BackingField  // 0x18
METHODS:
  Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_Creator()
  System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> get_Members()
  System.Void .ctor(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator)
  System.Object GetValue(System.Object target, System.String member)
  System.Void SetValue(System.Object target, System.String member, System.Object value)
  System.Type GetType(System.String member)
  Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.String[] memberNames)
  Newtonsoft.Json.Utilities.ReflectionObject Create(System.Type t, System.Reflection.MethodBase creator, System.String[] memberNames)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ReflectionUtils
TYPE:  class
TOKEN: 0x200008C
FIELDS:
  public    static readonly System.Type[]                   EmptyTypes  // 0x0
METHODS:
  System.Void .cctor()
  System.Boolean IsVirtual(System.Reflection.PropertyInfo propertyInfo)
  System.Reflection.MethodInfo GetBaseDefinition(System.Reflection.PropertyInfo propertyInfo)
  System.Boolean IsPublic(System.Reflection.PropertyInfo property)
  System.Type GetObjectType(System.Object v)
  System.String GetTypeName(System.Type t, Newtonsoft.Json.TypeNameAssemblyFormatHandling assemblyFormat, Newtonsoft.Json.Serialization.ISerializationBinder binder)
  System.String GetFullyQualifiedTypeName(System.Type t, Newtonsoft.Json.Serialization.ISerializationBinder binder)
  System.String RemoveAssemblyDetails(System.String fullyQualifiedTypeName)
  System.Boolean HasDefaultConstructor(System.Type t, System.Boolean nonPublic)
  System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t)
  System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type t, System.Boolean nonPublic)
  System.Boolean IsNullable(System.Type t)
  System.Boolean IsNullableType(System.Type t)
  System.Type EnsureNotNullableType(System.Type t)
  System.Type EnsureNotByRefType(System.Type t)
  System.Boolean IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition)
  System.Boolean ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition)
  System.Boolean ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, System.Type& implementingType)
  System.Boolean InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition)
  System.Boolean InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, System.Type& implementingType)
  System.Boolean InheritsGenericDefinitionInternal(System.Type type, System.Type genericClassDefinition, System.Type& implementingType)
  System.Type GetCollectionItemType(System.Type type)
  System.Void GetDictionaryKeyValueTypes(System.Type dictionaryType, System.Type& keyType, System.Type& valueType)
  System.Type GetMemberUnderlyingType(System.Reflection.MemberInfo member)
  System.Boolean IsByRefLikeType(System.Type type)
  System.Boolean IsIndexedProperty(System.Reflection.PropertyInfo property)
  System.Object GetMemberValue(System.Reflection.MemberInfo member, System.Object target)
  System.Void SetMemberValue(System.Reflection.MemberInfo member, System.Object target, System.Object value)
  System.Boolean CanReadMemberValue(System.Reflection.MemberInfo member, System.Boolean nonPublic)
  System.Boolean CanSetMemberValue(System.Reflection.MemberInfo member, System.Boolean nonPublic, System.Boolean canSetReadOnly)
  System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(System.Type type, System.Reflection.BindingFlags bindingAttr)
  System.Boolean IsOverridenGenericMember(System.Reflection.MemberInfo memberInfo, System.Reflection.BindingFlags bindingAttr)
  T GetAttribute(System.Object attributeProvider)
  T GetAttribute(System.Object attributeProvider, System.Boolean inherit)
  T[] GetAttributes(System.Object attributeProvider, System.Boolean inherit)
  System.Attribute[] GetAttributes(System.Object attributeProvider, System.Type attributeType, System.Boolean inherit)
  Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> SplitFullyQualifiedTypeName(System.String fullyQualifiedTypeName)
  System.Nullable<System.Int32> GetAssemblyDelimiterIndex(System.String fullyQualifiedTypeName)
  System.Reflection.MemberInfo GetMemberInfoFromType(System.Type targetType, System.Reflection.MemberInfo memberInfo)
  System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(System.Type targetType, System.Reflection.BindingFlags bindingAttr)
  System.Void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, System.Type type, System.Reflection.BindingFlags bindingAttr)
  System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(System.Type targetType, System.Reflection.BindingFlags bindingAttr)
  System.Reflection.BindingFlags RemoveFlag(System.Reflection.BindingFlags bindingAttr, System.Reflection.BindingFlags flag)
  System.Void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, System.Type type, System.Reflection.BindingFlags bindingAttr)
  System.Boolean IsMethodOverridden(System.Type currentType, System.Type methodDeclaringType, System.String method)
  System.Object GetDefaultValue(System.Type type)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.StringBuffer
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
  private           System.Char[]                   _buffer  // 0x10
  private           System.Int32                    _position  // 0x18
METHODS:
  System.Int32 get_Position()
  System.Void set_Position(System.Int32 value)
  System.Boolean get_IsEmpty()
  System.Void .ctor(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 initalSize)
  System.Void .ctor(System.Char[] buffer)
  System.Void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char value)
  System.Void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Char[] buffer, System.Int32 startIndex, System.Int32 count)
  System.Void Clear(Newtonsoft.Json.IArrayPool<System.Char> bufferPool)
  System.Void EnsureSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, System.Int32 appendLength)
  System.String ToString()
  System.String ToString(System.Int32 start, System.Int32 length)
  System.Char[] get_InternalBuffer()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.StringReference
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  private   readonly System.Char[]                   _chars  // 0x10
  private   readonly System.Int32                    _startIndex  // 0x18
  private   readonly System.Int32                    _length  // 0x1C
METHODS:
  System.Char get_Item(System.Int32 i)
  System.Char[] get_Chars()
  System.Int32 get_StartIndex()
  System.Int32 get_Length()
  System.Void .ctor(System.Char[] chars, System.Int32 startIndex, System.Int32 length)
  System.String ToString()
END_CLASS

CLASS: Newtonsoft.Json.Utilities.StringReferenceExtensions
TYPE:  class
TOKEN: 0x2000094
FIELDS:
METHODS:
  System.Int32 IndexOf(Newtonsoft.Json.Utilities.StringReference s, System.Char c, System.Int32 startIndex, System.Int32 length)
  System.Boolean StartsWith(Newtonsoft.Json.Utilities.StringReference s, System.String text)
  System.Boolean EndsWith(Newtonsoft.Json.Utilities.StringReference s, System.String text)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.StringUtils
TYPE:  class
TOKEN: 0x2000095
FIELDS:
METHODS:
  System.Boolean IsNullOrEmpty(System.String value)
  System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0)
  System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1)
  System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1, System.Object arg2)
  System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object arg0, System.Object arg1, System.Object arg2, System.Object arg3)
  System.String FormatWith(System.String format, System.IFormatProvider provider, System.Object[] args)
  System.IO.StringWriter CreateStringWriter(System.Int32 capacity)
  System.Void ToCharAsUnicode(System.Char c, System.Char[] buffer)
  TSource ForgivingCaseSensitiveFind(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.String> valueSelector, System.String testValue)
  System.String ToCamelCase(System.String s)
  System.Char ToLower(System.Char c)
  System.String ToSnakeCase(System.String s)
  System.String ToKebabCase(System.String s)
  System.String ToSeparatedCase(System.String s, System.Char separator)
  System.Boolean IsHighSurrogate(System.Char c)
  System.Boolean IsLowSurrogate(System.Char c)
  System.Int32 IndexOf(System.String s, System.Char c)
  System.Boolean StartsWith(System.String source, System.Char value)
  System.Boolean EndsWith(System.String source, System.Char value)
  System.String Trim(System.String s, System.Int32 start, System.Int32 length)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.StructMultiKey`2
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
  public    readonly T1                              Value1  // 0x0
  public    readonly T2                              Value2  // 0x0
METHODS:
  System.Void .ctor(T1 v1, T2 v2)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1,T2> other)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ThreadSafeStore`2
TYPE:  class
TOKEN: 0x2000099
FIELDS:
  private   readonly System.Collections.Concurrent.ConcurrentDictionary<TKey,TValue>_concurrentStore  // 0x0
  private   readonly System.Func<TKey,TValue>        _creator  // 0x0
METHODS:
  System.Void .ctor(System.Func<TKey,TValue> creator)
  TValue Get(TKey key)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.TypeExtensions
TYPE:  class
TOKEN: 0x200009A
FIELDS:
METHODS:
  System.Reflection.MemberTypes MemberType(System.Reflection.MemberInfo memberInfo)
  System.Boolean ContainsGenericParameters(System.Type type)
  System.Boolean IsInterface(System.Type type)
  System.Boolean IsGenericType(System.Type type)
  System.Boolean IsGenericTypeDefinition(System.Type type)
  System.Type BaseType(System.Type type)
  System.Reflection.Assembly Assembly(System.Type type)
  System.Boolean IsEnum(System.Type type)
  System.Boolean IsClass(System.Type type)
  System.Boolean IsSealed(System.Type type)
  System.Boolean IsAbstract(System.Type type)
  System.Boolean IsVisible(System.Type type)
  System.Boolean IsValueType(System.Type type)
  System.Boolean AssignableToTypeName(System.Type type, System.String fullTypeName, System.Boolean searchInterfaces, System.Type& match)
  System.Boolean AssignableToTypeName(System.Type type, System.String fullTypeName, System.Boolean searchInterfaces)
  System.Boolean ImplementInterface(System.Type type, System.Type interfaceType)
END_CLASS

CLASS: Newtonsoft.Json.Utilities.ValidationUtils
TYPE:  class
TOKEN: 0x200009B
FIELDS:
METHODS:
  System.Void ArgumentNotNull(System.Object value, System.String parameterName)
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.NotNullAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Diagnostics.CodeAnalysis.NotNullWhenAttribute
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
  private   readonly System.Boolean                  <ReturnValue>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Boolean returnValue)
END_CLASS

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
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

