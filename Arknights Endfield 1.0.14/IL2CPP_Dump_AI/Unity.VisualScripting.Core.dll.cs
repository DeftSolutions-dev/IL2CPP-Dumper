// ========================================================
// Dumped by @desirepro
// Assembly: Unity.VisualScripting.Core.dll
// Classes:  260
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  private           System.Collections.Generic.Dictionary.Enumerator<System.Type,Unity.VisualScripting.IKeyedCollection<TKey,TItem>>collectionsEnumerator  // 0x0
  private           TItem                           currentItem  // 0x0
  private           Unity.VisualScripting.IKeyedCollection<TKey,TItem>currentCollection  // 0x0
  private           System.Int32                    indexInCurrentCollection  // 0x0
  private           System.Boolean                  exceeded  // 0x0
METHODS:
  System.Void .ctor(Unity.VisualScripting.MergedKeyedCollection<TKey,TItem> merged)
  System.Void Dispose()
  System.Boolean MoveNext()
  TItem get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: AttributeCache
TYPE:  class
TOKEN: 0x200004E
FIELDS:
  private   readonly System.Collections.Generic.List<System.Attribute><inheritedAttributes>k__BackingField  // 0x10
  private   readonly System.Collections.Generic.List<System.Attribute><definedAttributes>k__BackingField  // 0x18
METHODS:
  System.Collections.Generic.List<System.Attribute> get_inheritedAttributes()
  System.Collections.Generic.List<System.Attribute> get_definedAttributes()
  System.Void .ctor(System.Reflection.MemberInfo element)
  System.Void Cache(System.Attribute[] attributeObjects, System.Collections.Generic.List<System.Attribute> cache)
  System.Boolean HasAttribute(System.Type attributeType, System.Collections.Generic.List<System.Attribute> cache)
  System.Attribute GetAttribute(System.Type attributeType, System.Collections.Generic.List<System.Attribute> cache)
  System.Boolean HasAttribute(System.Type attributeType, System.Boolean inherit)
  System.Attribute GetAttribute(System.Type attributeType, System.Boolean inherit)
  System.Boolean HasAttribute(System.Boolean inherit)
  TAttribute GetAttribute(System.Boolean inherit)
END_CLASS

CLASS: ConversionType
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeImpossible  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeIdentity  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeUpcast  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeDowncast  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeNumericImplicit  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeNumericExplicit  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeUserDefinedImplicit  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeUserDefinedExplicit  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeUserDefinedThenNumericImplicit  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeUserDefinedThenNumericExplicit  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeUnityHierarchy  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeEnumerableToArray  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeEnumerableToList  // 0x0
  public    static  Unity.VisualScripting.ConversionUtility.ConversionTypeToString  // 0x0
METHODS:
END_CLASS

CLASS: ConversionQuery
TYPE:  struct
TOKEN: 0x2000051
FIELDS:
  public    readonly System.Type                     source  // 0x10
  public    readonly System.Type                     destination  // 0x18
METHODS:
  System.Void .ctor(System.Type source, System.Type destination)
  System.Boolean Equals(Unity.VisualScripting.ConversionUtility.ConversionQuery other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: ConversionQueryComparer
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
METHODS:
  System.Boolean Equals(Unity.VisualScripting.ConversionUtility.ConversionQuery x, Unity.VisualScripting.ConversionUtility.ConversionQuery y)
  System.Int32 GetHashCode(Unity.VisualScripting.ConversionUtility.ConversionQuery obj)
END_CLASS

CLASS: Collection
TYPE:  class
TOKEN: 0x200005C
EXTENDS: KeyedCollection`2
FIELDS:
METHODS:
  System.String GetKeyForItem(Unity.VisualScripting.Namespace item)
  System.Boolean TryGetValue(System.String key, Unity.VisualScripting.Namespace& value)
  System.Void .ctor()
  Unity.VisualScripting.Namespace Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.Namespace>.get_Item(System.String key)
  System.Boolean Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.Namespace>.Contains(System.String key)
END_CLASS

CLASS: ParseState
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.VisualScripting.TypeName.ParseStateName  // 0x0
  public    static  Unity.VisualScripting.TypeName.ParseStateArray  // 0x0
  public    static  Unity.VisualScripting.TypeName.ParseStateGenerics  // 0x0
  public    static  Unity.VisualScripting.TypeName.ParseStateAssembly  // 0x0
METHODS:
END_CLASS

CLASS: AotCompilation
TYPE:  struct
TOKEN: 0x20000D9
FIELDS:
  public            System.Type                     Type  // 0x10
  public            Unity.VisualScripting.FullSerializer.fsMetaProperty[]Members  // 0x18
  public            System.Boolean                  IsConstructorPublic  // 0x20
METHODS:
END_CLASS

CLASS: fsLazyCycleDefinitionWriter
TYPE:  class
TOKEN: 0x20000F3
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,Unity.VisualScripting.FullSerializer.fsData>_pendingDefinitions  // 0x10
  private           System.Collections.Generic.HashSet<System.Int32>_references  // 0x18
METHODS:
  System.Void WriteDefinition(System.Int32 id, Unity.VisualScripting.FullSerializer.fsData data)
  System.Void WriteReference(System.Int32 id, System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> dict)
  System.Void Clear()
  System.Void .ctor()
END_CLASS

CLASS: ObjectReferenceEqualityComparator
TYPE:  class
TOKEN: 0x20000FB
FIELDS:
  public    static readonly System.Collections.Generic.IEqualityComparer<System.Object>Instance  // 0x0
METHODS:
  System.Boolean System.Collections.Generic.IEqualityComparer<System.Object>.Equals(System.Object x, System.Object y)
  System.Int32 System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(System.Object obj)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: AttributeQuery
TYPE:  struct
TOKEN: 0x20000FF
FIELDS:
  public            System.Reflection.MemberInfo    MemberInfo  // 0x10
  public            System.Type                     AttributeType  // 0x18
METHODS:
END_CLASS

CLASS: AttributeQueryComparator
TYPE:  class
TOKEN: 0x2000100
FIELDS:
METHODS:
  System.Boolean Equals(Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery x, Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery y)
  System.Int32 GetHashCode(Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery obj)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.Cloner`1
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean Handles(System.Type type)
  System.Void Unity.VisualScripting.ICloner.BeforeClone(System.Type type, System.Object original)
  System.Void BeforeClone(System.Type type, T original)
  System.Object Unity.VisualScripting.ICloner.ConstructClone(System.Type type, System.Object original)
  T ConstructClone(System.Type type, T original)
  System.Void Unity.VisualScripting.ICloner.FillClone(System.Type type, System.Object& clone, System.Object original, Unity.VisualScripting.CloningContext context)
  System.Void FillClone(System.Type type, T& clone, T original, Unity.VisualScripting.CloningContext context)
  System.Void Unity.VisualScripting.ICloner.AfterClone(System.Type type, System.Object clone)
  System.Void AfterClone(System.Type type, T clone)
END_CLASS

CLASS: Unity.VisualScripting.AnimationCurveCloner
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Cloner`1
FIELDS:
METHODS:
  System.Boolean Handles(System.Type type)
  UnityEngine.AnimationCurve ConstructClone(System.Type type, UnityEngine.AnimationCurve original)
  System.Void FillClone(System.Type type, UnityEngine.AnimationCurve& clone, UnityEngine.AnimationCurve original, Unity.VisualScripting.CloningContext context)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.ArrayCloner
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Cloner`1
FIELDS:
METHODS:
  System.Boolean Handles(System.Type type)
  System.Array ConstructClone(System.Type type, System.Array original)
  System.Void FillClone(System.Type type, System.Array& clone, System.Array original, Unity.VisualScripting.CloningContext context)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.DictionaryCloner
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Cloner`1
FIELDS:
METHODS:
  System.Boolean Handles(System.Type type)
  System.Void FillClone(System.Type type, System.Collections.IDictionary& clone, System.Collections.IDictionary original, Unity.VisualScripting.CloningContext context)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.EnumerableCloner
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Cloner`1
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.IOptimizedInvoker>addMethods  // 0x10
METHODS:
  System.Boolean Handles(System.Type type)
  System.Void FillClone(System.Type type, System.Collections.IEnumerable& clone, System.Collections.IEnumerable original, Unity.VisualScripting.CloningContext context)
  Unity.VisualScripting.IOptimizedInvoker GetAddMethod(System.Type type)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FakeSerializationCloner
TYPE:  class
TOKEN: 0x2000007
EXTENDS: ReflectedCloner
FIELDS:
  private           Unity.VisualScripting.FullSerializer.fsConfig<config>k__BackingField  // 0x20
METHODS:
  Unity.VisualScripting.FullSerializer.fsConfig get_config()
  System.Void BeforeClone(System.Type type, System.Object original)
  System.Void AfterClone(System.Type type, System.Object clone)
  System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetMembers(System.Type type)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FieldsCloner
TYPE:  class
TOKEN: 0x2000009
EXTENDS: ReflectedCloner
FIELDS:
METHODS:
  System.Boolean IncludeField(System.Reflection.FieldInfo field)
  System.Boolean IncludeProperty(System.Reflection.PropertyInfo property)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.GradientCloner
TYPE:  class
TOKEN: 0x200000A
EXTENDS: Cloner`1
FIELDS:
METHODS:
  System.Boolean Handles(System.Type type)
  UnityEngine.Gradient ConstructClone(System.Type type, UnityEngine.Gradient original)
  System.Void FillClone(System.Type type, UnityEngine.Gradient& clone, UnityEngine.Gradient original, Unity.VisualScripting.CloningContext context)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.ListCloner
TYPE:  class
TOKEN: 0x200000B
EXTENDS: Cloner`1
FIELDS:
METHODS:
  System.Boolean Handles(System.Type type)
  System.Void FillClone(System.Type type, System.Collections.IList& clone, System.Collections.IList original, Unity.VisualScripting.CloningContext context)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.ReflectedCloner
TYPE:  class
TOKEN: 0x200000C
EXTENDS: Cloner`1
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Type,System.Reflection.MemberInfo[]>accessors  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.IOptimizedAccessor[]>optimizedAccessors  // 0x18
METHODS:
  System.Boolean Handles(System.Type type)
  System.Void FillClone(System.Type type, System.Object& clone, System.Object original, Unity.VisualScripting.CloningContext context)
  System.Reflection.MemberInfo[] GetAccessors(System.Type type)
  Unity.VisualScripting.IOptimizedAccessor[] GetOptimizedAccessors(System.Type type)
  System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetMembers(System.Type type)
  System.Boolean IncludeField(System.Reflection.FieldInfo field)
  System.Boolean IncludeProperty(System.Reflection.PropertyInfo property)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.Cloning
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Boolean>skippable  // 0x0
  private   static readonly System.Collections.Generic.HashSet<Unity.VisualScripting.ICloner><cloners>k__BackingField  // 0x8
  private   static readonly Unity.VisualScripting.ArrayCloner<arrayCloner>k__BackingField  // 0x10
  private   static readonly Unity.VisualScripting.DictionaryCloner<dictionaryCloner>k__BackingField  // 0x18
  private   static readonly Unity.VisualScripting.EnumerableCloner<enumerableCloner>k__BackingField  // 0x20
  private   static readonly Unity.VisualScripting.ListCloner<listCloner>k__BackingField  // 0x28
  private   static readonly Unity.VisualScripting.AnimationCurveCloner<animationCurveCloner>k__BackingField  // 0x30
  private   static readonly Unity.VisualScripting.GradientCloner<gradientCloner>k__BackingField  // 0x38
  private   static readonly Unity.VisualScripting.FieldsCloner<fieldsCloner>k__BackingField  // 0x40
  private   static readonly Unity.VisualScripting.FakeSerializationCloner<fakeSerializationCloner>k__BackingField  // 0x48
METHODS:
  System.Void .cctor()
  System.Collections.Generic.HashSet<Unity.VisualScripting.ICloner> get_cloners()
  Unity.VisualScripting.ArrayCloner get_arrayCloner()
  Unity.VisualScripting.DictionaryCloner get_dictionaryCloner()
  Unity.VisualScripting.EnumerableCloner get_enumerableCloner()
  Unity.VisualScripting.ListCloner get_listCloner()
  Unity.VisualScripting.AnimationCurveCloner get_animationCurveCloner()
  Unity.VisualScripting.GradientCloner get_gradientCloner()
  Unity.VisualScripting.FakeSerializationCloner get_fakeSerializationCloner()
  System.Object Clone(System.Object original, Unity.VisualScripting.ICloner fallbackCloner, System.Boolean tryPreserveInstances)
  System.Object CloneViaFakeSerialization(System.Object original)
  T CloneViaFakeSerialization(T original)
  System.Object Clone(Unity.VisualScripting.CloningContext context, System.Object original)
  System.Void CloneInto(Unity.VisualScripting.CloningContext context, System.Object& clone, System.Object original)
  Unity.VisualScripting.ICloner GetCloner(System.Object original, System.Type type)
  Unity.VisualScripting.ICloner GetCloner(System.Object original, System.Type type, Unity.VisualScripting.ICloner fallbackCloner)
  System.Boolean Skippable(System.Type type)
END_CLASS

CLASS: Unity.VisualScripting.CloningContext
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Object,System.Object><clonings>k__BackingField  // 0x10
  private           Unity.VisualScripting.ICloner   <fallbackCloner>k__BackingField  // 0x18
  private           System.Boolean                  <tryPreserveInstances>k__BackingField  // 0x20
  private           System.Boolean                  disposed  // 0x21
METHODS:
  System.Collections.Generic.Dictionary<System.Object,System.Object> get_clonings()
  Unity.VisualScripting.ICloner get_fallbackCloner()
  System.Void set_fallbackCloner(Unity.VisualScripting.ICloner value)
  System.Boolean get_tryPreserveInstances()
  System.Void set_tryPreserveInstances(System.Boolean value)
  System.Void Unity.VisualScripting.IPoolable.New()
  System.Void Unity.VisualScripting.IPoolable.Free()
  System.Void Dispose()
  Unity.VisualScripting.CloningContext New(Unity.VisualScripting.ICloner fallbackCloner, System.Boolean tryPreserveInstances)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.ICloner
TYPE:  interface
TOKEN: 0x2000011
FIELDS:
METHODS:
  System.Boolean Handles(System.Type type)
  System.Object ConstructClone(System.Type type, System.Object original)
  System.Void BeforeClone(System.Type type, System.Object original)
  System.Void FillClone(System.Type type, System.Object& clone, System.Object original, Unity.VisualScripting.CloningContext context)
  System.Void AfterClone(System.Type type, System.Object clone)
END_CLASS

CLASS: Unity.VisualScripting.ISpecifiesCloner
TYPE:  interface
TOKEN: 0x2000012
FIELDS:
METHODS:
  Unity.VisualScripting.ICloner get_cloner()
END_CLASS

CLASS: Unity.VisualScripting.AotDictionary
TYPE:  class
TOKEN: 0x2000013
EXTENDS: OrderedDictionary
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void AotStubs()
END_CLASS

CLASS: Unity.VisualScripting.AotList
TYPE:  class
TOKEN: 0x2000014
EXTENDS: ArrayList
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void AotStubs()
END_CLASS

CLASS: Unity.VisualScripting.GuidCollection`1
TYPE:  class
TOKEN: 0x2000015
EXTENDS: KeyedCollection`2
FIELDS:
METHODS:
  System.Guid GetKeyForItem(T item)
END_CLASS

CLASS: Unity.VisualScripting.IKeyedCollection`2
TYPE:  interface
TOKEN: 0x2000016
FIELDS:
METHODS:
  TItem get_Item(TKey key)
  TItem get_Item(System.Int32 index)
  System.Boolean Contains(TKey key)
END_CLASS

CLASS: Unity.VisualScripting.MergedKeyedCollection`2
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  protected readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.IKeyedCollection<TKey,TItem>>collections  // 0x0
  protected readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.IKeyedCollection<TKey,TItem>>collectionsLookup  // 0x0
METHODS:
  Unity.VisualScripting.IKeyedCollection<TKey,TItem> GetCollectionForItem(TItem item)
  Unity.VisualScripting.IKeyedCollection<TKey,TItem> GetCollectionForType(System.Type type, System.Boolean throwOnFail)
  System.Void Add(TItem item)
  System.Void Clear()
  System.Boolean Contains(TItem item)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerator<TItem> System.Collections.Generic.IEnumerable<TItem>.GetEnumerator()
  Unity.VisualScripting.MergedKeyedCollection.Enumerator<TKey,TItem> GetEnumerator()
END_CLASS

CLASS: Unity.VisualScripting.ConnectionCollection`3
TYPE:  class
TOKEN: 0x2000019
EXTENDS: ConnectionCollectionBase`4
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.ConnectionCollectionBase`4
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<TDestination,System.Collections.Generic.List<TConnection>>byDestination  // 0x0
  private   readonly System.Collections.Generic.Dictionary<TSource,System.Collections.Generic.List<TConnection>>bySource  // 0x0
  protected readonly TCollection                     collection  // 0x0
METHODS:
  System.Void .ctor(TCollection collection)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Collections.Generic.IEnumerator<TConnection> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerable<TConnection> WithSource(TSource source)
  System.Collections.Generic.List<TConnection> WithSourceNoAlloc(TSource source)
  TConnection SingleOrDefaultWithSource(TSource source)
  System.Collections.Generic.IEnumerable<TConnection> WithDestination(TDestination destination)
  System.Collections.Generic.List<TConnection> WithDestinationNoAlloc(TDestination destination)
  TConnection SingleOrDefaultWithDestination(TDestination destination)
  System.Void Add(TConnection item)
  System.Void Clear()
  System.Boolean Contains(TConnection item)
  System.Void CopyTo(TConnection[] array, System.Int32 arrayIndex)
  System.Boolean Remove(TConnection item)
  System.Void BeforeAdd(TConnection item)
  System.Void AfterAdd(TConnection item)
  System.Void BeforeRemove(TConnection item)
  System.Void AfterRemove(TConnection item)
  System.Void AddToDictionaries(TConnection item)
  System.Void RemoveFromDictionaries(TConnection item)
END_CLASS

CLASS: Unity.VisualScripting.GraphConnectionCollection`3
TYPE:  class
TOKEN: 0x200001B
EXTENDS: ConnectionCollectionBase`4
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IConnection`2
TYPE:  interface
TOKEN: 0x200001C
FIELDS:
METHODS:
  TSource get_source()
  TDestination get_destination()
END_CLASS

CLASS: Unity.VisualScripting.IConnectionCollection`3
TYPE:  interface
TOKEN: 0x200001D
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.InvalidConnectionException
TYPE:  class
TOKEN: 0x200001E
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
END_CLASS

CLASS: Unity.VisualScripting.ValueAttribute
TYPE:  class
TOKEN: 0x200001F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.DisableAnnotationAttribute
TYPE:  class
TOKEN: 0x2000020
EXTENDS: Attribute
FIELDS:
  private           System.Boolean                  <disableIcon>k__BackingField  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.EditorTimeBinding
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  public    static  System.Func<System.Int32>       frameBinding  // 0x0
  public    static  System.Func<System.Single>      timeBinding  // 0x8
METHODS:
  System.Int32 get_frame()
  System.Single get_time()
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.IncludeInSettingsAttribute
TYPE:  class
TOKEN: 0x2000023
EXTENDS: Attribute
FIELDS:
  private           System.Boolean                  <include>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Boolean include)
  System.Void set_include(System.Boolean value)
END_CLASS

CLASS: Unity.VisualScripting.InspectableAttribute
TYPE:  class
TOKEN: 0x2000024
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.InspectorWideAttribute
TYPE:  class
TOKEN: 0x2000025
EXTENDS: Attribute
FIELDS:
  private           System.Boolean                  <toEdge>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Boolean toEdge)
  System.Void set_toEdge(System.Boolean value)
END_CLASS

CLASS: Unity.VisualScripting.Ensure
TYPE:  class
TOKEN: 0x2000026
FIELDS:
  private   static readonly Unity.VisualScripting.EnsureThatinstance  // 0x0
  private   static  System.Boolean                  <IsActive>k__BackingField  // 0x8
METHODS:
  System.Boolean get_IsActive()
  System.Void set_IsActive(System.Boolean value)
  Unity.VisualScripting.EnsureThat That(System.String paramName)
  System.Void OnRuntimeMethodLoad()
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.EnsureThat
TYPE:  class
TOKEN: 0x2000027
FIELDS:
  private           System.String                   paramName  // 0x10
METHODS:
  System.Void IsNotNull(T value)
  System.Void IsNotNull(System.String value)
  System.Void IsOfType(T param, System.Type expectedType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.ExceptionMessages
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  private   static readonly System.String                   <Common_IsNull_Failed>k__BackingField  // 0x0
  private   static readonly System.String                   <Common_IsNotNull_Failed>k__BackingField  // 0x8
  private   static readonly System.String                   <Booleans_IsTrueFailed>k__BackingField  // 0x10
  private   static readonly System.String                   <Booleans_IsFalseFailed>k__BackingField  // 0x18
  private   static readonly System.String                   <Collections_Any_Failed>k__BackingField  // 0x20
  private   static readonly System.String                   <Collections_ContainsKey_Failed>k__BackingField  // 0x28
  private   static readonly System.String                   <Collections_HasItemsFailed>k__BackingField  // 0x30
  private   static readonly System.String                   <Collections_HasNoNullItemFailed>k__BackingField  // 0x38
  private   static readonly System.String                   <Collections_SizeIs_Failed>k__BackingField  // 0x40
  private   static readonly System.String                   <Comp_Is_Failed>k__BackingField  // 0x48
  private   static readonly System.String                   <Comp_IsNot_Failed>k__BackingField  // 0x50
  private   static readonly System.String                   <Comp_IsNotLt>k__BackingField  // 0x58
  private   static readonly System.String                   <Comp_IsNotLte>k__BackingField  // 0x60
  private   static readonly System.String                   <Comp_IsNotGt>k__BackingField  // 0x68
  private   static readonly System.String                   <Comp_IsNotGte>k__BackingField  // 0x70
  private   static readonly System.String                   <Comp_IsNotInRange_ToLow>k__BackingField  // 0x78
  private   static readonly System.String                   <Comp_IsNotInRange_ToHigh>k__BackingField  // 0x80
  private   static readonly System.String                   <Guids_IsNotEmpty_Failed>k__BackingField  // 0x88
  private   static readonly System.String                   <Strings_IsEqualTo_Failed>k__BackingField  // 0x90
  private   static readonly System.String                   <Strings_IsNotEqualTo_Failed>k__BackingField  // 0x98
  private   static readonly System.String                   <Strings_SizeIs_Failed>k__BackingField  // 0xA0
  private   static readonly System.String                   <Strings_IsNotNullOrWhiteSpace_Failed>k__BackingField  // 0xA8
  private   static readonly System.String                   <Strings_IsNotNullOrEmpty_Failed>k__BackingField  // 0xB0
  private   static readonly System.String                   <Strings_HasLengthBetween_Failed_ToShort>k__BackingField  // 0xB8
  private   static readonly System.String                   <Strings_HasLengthBetween_Failed_ToLong>k__BackingField  // 0xC0
  private   static readonly System.String                   <Strings_Matches_Failed>k__BackingField  // 0xC8
  private   static readonly System.String                   <Strings_IsNotEmpty_Failed>k__BackingField  // 0xD0
  private   static readonly System.String                   <Strings_IsGuid_Failed>k__BackingField  // 0xD8
  private   static readonly System.String                   <Types_IsOfType_Failed>k__BackingField  // 0xE0
  private   static readonly System.String                   <Reflection_HasAttribute_Failed>k__BackingField  // 0xE8
  private   static readonly System.String                   <Reflection_HasConstructor_Failed>k__BackingField  // 0xF0
  private   static readonly System.String                   <Reflection_HasPublicConstructor_Failed>k__BackingField  // 0xF8
  private   static readonly System.String                   <ValueTypes_IsNotDefault_Failed>k__BackingField  // 0x100
METHODS:
  System.String get_Common_IsNotNull_Failed()
  System.String get_Types_IsOfType_Failed()
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.XString
TYPE:  class
TOKEN: 0x2000029
FIELDS:
METHODS:
  System.String Inject(System.String format, System.String[] formattingArgs)
END_CLASS

CLASS: Unity.VisualScripting.EmptyEventArgs
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.InvalidConversionException
TYPE:  class
TOKEN: 0x200002C
EXTENDS: InvalidCastException
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
END_CLASS

CLASS: Unity.VisualScripting.InvalidImplementationException
TYPE:  class
TOKEN: 0x200002D
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor(System.String message)
END_CLASS

CLASS: Unity.VisualScripting.UnexpectedEnumValueException`1
TYPE:  class
TOKEN: 0x200002E
EXTENDS: Exception
FIELDS:
  private           T                               <Value>k__BackingField  // 0x0
METHODS:
  System.Void .ctor(T value)
  System.Void set_Value(T value)
END_CLASS

CLASS: Unity.VisualScripting.Graph
TYPE:  class
TOKEN: 0x200002F
FIELDS:
  private           System.Collections.Generic.List<Unity.VisualScripting.IGraphElement>_elements  // 0x10
  private   readonly Unity.VisualScripting.MergedGraphElementCollection<elements>k__BackingField  // 0x18
METHODS:
  Unity.VisualScripting.MergedGraphElementCollection get_elements()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies()
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.Void OnAfterDependenciesDeserialized()
  System.Void Dispose()
END_CLASS

CLASS: Unity.VisualScripting.GraphElement`1
TYPE:  class
TOKEN: 0x2000031
FIELDS:
  private           System.Guid                     <guid>k__BackingField  // 0x0
  private           TGraph                          <graph>k__BackingField  // 0x0
METHODS:
  System.Guid get_guid()
  System.Void Dispose()
  System.Int32 get_dependencyOrder()
  System.Boolean HandleDependencies()
  TGraph get_graph()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies()
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.GraphElementCollection`1
TYPE:  class
TOKEN: 0x2000032
EXTENDS: GuidCollection`1
FIELDS:
METHODS:
  TElement Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.get_Item(System.Guid key)
  System.Boolean Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.Contains(System.Guid key)
END_CLASS

CLASS: Unity.VisualScripting.GraphPointer
TYPE:  class
TOKEN: 0x2000033
FIELDS:
  private           Unity.VisualScripting.IGraphRoot<root>k__BackingField  // 0x10
  private           UnityEngine.GameObject          <gameObject>k__BackingField  // 0x18
  protected readonly System.Collections.Generic.List<Unity.VisualScripting.IGraphParent>parentStack  // 0x20
  protected readonly System.Collections.Generic.List<Unity.VisualScripting.IGraphParentElement>parentElementStack  // 0x28
  protected readonly System.Collections.Generic.List<Unity.VisualScripting.IGraph>graphStack  // 0x30
  protected readonly System.Collections.Generic.List<Unity.VisualScripting.IGraphData>dataStack  // 0x38
  protected readonly System.Collections.Generic.List<Unity.VisualScripting.IGraphDebugData>debugDataStack  // 0x40
METHODS:
  System.Void .ctor()
  Unity.VisualScripting.GraphReference AsReference()
  System.Void CopyFrom(Unity.VisualScripting.GraphPointer other)
  Unity.VisualScripting.IGraphRoot get_root()
  System.Void set_root(Unity.VisualScripting.IGraphRoot value)
  UnityEngine.Object get_rootObject()
  UnityEngine.GameObject get_gameObject()
  System.Void set_gameObject(UnityEngine.GameObject value)
  UnityEngine.GameObject get_self()
  UnityEngine.Object get_serializedObject()
  System.Int32 get_depth()
  System.Boolean get_isRoot()
  System.Boolean get_isChild()
  System.Void EnsureChild()
  Unity.VisualScripting.IGraphParent get_parent()
  Unity.VisualScripting.IGraphParentElement get_parentElement()
  Unity.VisualScripting.IGraph get_rootGraph()
  System.Boolean get_hasDebugData()
  System.Void EnsureDebugDataAvailable()
  Unity.VisualScripting.IGraphDebugData get__debugData()
  Unity.VisualScripting.IGraphDebugData get_debugData()
  T GetElementDebugData(Unity.VisualScripting.IGraphElementWithDebugData element)
  System.Void ExitParentElement()
  System.Boolean get_isValid()
  System.Boolean InstanceEquals(Unity.VisualScripting.GraphPointer other)
  System.Boolean DefinitionEquals(Unity.VisualScripting.GraphPointer other)
  System.Int32 ComputeHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.VisualScripting.GraphPointerException
TYPE:  class
TOKEN: 0x2000034
EXTENDS: Exception
FIELDS:
  private   readonly Unity.VisualScripting.GraphPointer<pointer>k__BackingField  // 0x90
METHODS:
  System.Void .ctor(System.String message, Unity.VisualScripting.GraphPointer pointer)
END_CLASS

CLASS: Unity.VisualScripting.GraphReference
TYPE:  class
TOKEN: 0x2000035
EXTENDS: GraphPointer
FIELDS:
  private           System.Int32                    hashCode  // 0x48
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<Unity.VisualScripting.GraphReference>>internPool  // 0x0
METHODS:
  System.Void .cctor()
  System.Void .ctor()
  Unity.VisualScripting.GraphReference New(Unity.VisualScripting.GraphPointer model)
  System.Void CopyFrom(Unity.VisualScripting.GraphPointer other)
  Unity.VisualScripting.GraphReference Clone()
  Unity.VisualScripting.GraphReference AsReference()
  Unity.VisualScripting.GraphStack ToStackPooled()
  System.Boolean Equals(System.Object obj)
  System.Void Hash()
  System.Int32 GetHashCode()
  Unity.VisualScripting.GraphReference ParentReference(System.Boolean ensureValid)
  Unity.VisualScripting.GraphReference Intern(Unity.VisualScripting.GraphPointer pointer)
  System.Void FreeInvalidInterns()
END_CLASS

CLASS: Unity.VisualScripting.GraphsExceptionUtility
TYPE:  class
TOKEN: 0x2000036
FIELDS:
METHODS:
  System.Void SetException(Unity.VisualScripting.IGraphElementWithDebugData element, Unity.VisualScripting.GraphPointer pointer, System.Exception ex)
  System.Void HandleException(Unity.VisualScripting.IGraphElementWithDebugData element, Unity.VisualScripting.GraphPointer pointer, System.Exception ex)
  System.Boolean HandledIn(System.Exception ex, Unity.VisualScripting.GraphReference reference)
END_CLASS

CLASS: Unity.VisualScripting.GraphStack
TYPE:  class
TOKEN: 0x2000037
EXTENDS: GraphPointer
FIELDS:
METHODS:
  System.Void .ctor()
  Unity.VisualScripting.GraphStack New(Unity.VisualScripting.GraphPointer model)
  System.Void Dispose()
  System.Void Unity.VisualScripting.IPoolable.New()
  System.Void Unity.VisualScripting.IPoolable.Free()
  Unity.VisualScripting.GraphReference AsReference()
  Unity.VisualScripting.GraphReference ToReference()
END_CLASS

CLASS: Unity.VisualScripting.IGraph
TYPE:  interface
TOKEN: 0x2000039
FIELDS:
METHODS:
  Unity.VisualScripting.MergedGraphElementCollection get_elements()
END_CLASS

CLASS: Unity.VisualScripting.IGraphData
TYPE:  interface
TOKEN: 0x200003A
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IGraphDebugData
TYPE:  interface
TOKEN: 0x200003B
FIELDS:
METHODS:
  Unity.VisualScripting.IGraphElementDebugData GetOrCreateElementData(Unity.VisualScripting.IGraphElementWithDebugData element)
END_CLASS

CLASS: Unity.VisualScripting.IGraphElement
TYPE:  interface
TOKEN: 0x200003C
FIELDS:
METHODS:
  System.Boolean HandleDependencies()
  System.Int32 get_dependencyOrder()
  System.Guid get_guid()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies()
END_CLASS

CLASS: Unity.VisualScripting.IGraphElementDebugData
TYPE:  interface
TOKEN: 0x200003D
FIELDS:
METHODS:
  System.Void set_runtimeException(System.Exception value)
END_CLASS

CLASS: Unity.VisualScripting.IGraphElementWithDebugData
TYPE:  interface
TOKEN: 0x200003E
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IGraphParent
TYPE:  interface
TOKEN: 0x200003F
FIELDS:
METHODS:
  Unity.VisualScripting.IGraph get_childGraph()
  System.Boolean get_isSerializationRoot()
  UnityEngine.Object get_serializedObject()
END_CLASS

CLASS: Unity.VisualScripting.IGraphParentElement
TYPE:  interface
TOKEN: 0x2000040
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IGraphRoot
TYPE:  interface
TOKEN: 0x2000041
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.MergedGraphElementCollection
TYPE:  class
TOKEN: 0x2000042
EXTENDS: MergedKeyedCollection`2
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.PlatformUtility
TYPE:  class
TOKEN: 0x2000043
FIELDS:
  public    static readonly System.Boolean                  supportsJit  // 0x0
METHODS:
  System.Void .cctor()
  System.Boolean CheckJitSupport()
END_CLASS

CLASS: Unity.VisualScripting.GenericPool`1
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  private   static readonly System.Object                   lock  // 0x0
  private   static readonly System.Collections.Generic.Stack<T>free  // 0x0
  private   static readonly System.Collections.Generic.HashSet<T>busy  // 0x0
METHODS:
  T New(System.Func<T> constructor)
  System.Void Free(T item)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.IPoolable
TYPE:  interface
TOKEN: 0x2000045
FIELDS:
METHODS:
  System.Void New()
  System.Void Free()
END_CLASS

CLASS: Unity.VisualScripting.ListPool`1
TYPE:  class
TOKEN: 0x2000046
FIELDS:
  private   static readonly System.Object                   lock  // 0x0
  private   static readonly System.Collections.Generic.Stack<System.Collections.Generic.List<T>>free  // 0x0
  private   static readonly System.Collections.Generic.HashSet<System.Collections.Generic.List<T>>busy  // 0x0
METHODS:
  System.Collections.Generic.List<T> New()
  System.Void Free(System.Collections.Generic.List<T> list)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.XListPool
TYPE:  class
TOKEN: 0x2000047
FIELDS:
METHODS:
  System.Void Free(System.Collections.Generic.List<T> list)
END_CLASS

CLASS: Unity.VisualScripting.ProfiledSegment
TYPE:  class
TOKEN: 0x2000048
FIELDS:
  private           System.String                   <name>k__BackingField  // 0x10
  private           System.Diagnostics.Stopwatch    <stopwatch>k__BackingField  // 0x18
  private           Unity.VisualScripting.ProfiledSegment<parent>k__BackingField  // 0x20
  private           Unity.VisualScripting.ProfiledSegmentCollection<children>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(Unity.VisualScripting.ProfiledSegment parent, System.String name)
  System.String get_name()
  System.Void set_name(System.String value)
  System.Void set_stopwatch(System.Diagnostics.Stopwatch value)
  System.Void set_parent(Unity.VisualScripting.ProfiledSegment value)
  System.Void set_children(Unity.VisualScripting.ProfiledSegmentCollection value)
END_CLASS

CLASS: Unity.VisualScripting.ProfiledSegmentCollection
TYPE:  class
TOKEN: 0x2000049
EXTENDS: KeyedCollection`2
FIELDS:
METHODS:
  System.String GetKeyForItem(Unity.VisualScripting.ProfiledSegment item)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.ProfilingScope
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
METHODS:
  System.Void .ctor(System.String name)
  System.Void Dispose()
END_CLASS

CLASS: Unity.VisualScripting.ProfilingUtility
TYPE:  class
TOKEN: 0x200004B
FIELDS:
  private   static readonly System.Object                   lock  // 0x0
  private   static  Unity.VisualScripting.ProfiledSegment<rootSegment>k__BackingField  // 0x8
  private   static  Unity.VisualScripting.ProfiledSegment<currentSegment>k__BackingField  // 0x10
METHODS:
  System.Void .cctor()
  System.Void set_rootSegment(Unity.VisualScripting.ProfiledSegment value)
  System.Void set_currentSegment(Unity.VisualScripting.ProfiledSegment value)
  Unity.VisualScripting.ProfilingScope SampleBlock(System.String name)
END_CLASS

CLASS: Unity.VisualScripting.ActionDirection
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.VisualScripting.ActionDirectionAny  // 0x0
  public    static  Unity.VisualScripting.ActionDirectionGet  // 0x0
  public    static  Unity.VisualScripting.ActionDirectionSet  // 0x0
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.AttributeUtility
TYPE:  class
TOKEN: 0x200004D
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Object,Unity.VisualScripting.AttributeUtility.AttributeCache>optimizedCaches  // 0x0
METHODS:
  Unity.VisualScripting.AttributeUtility.AttributeCache GetAttributeCache(System.Reflection.MemberInfo element)
  System.Collections.Generic.IEnumerable<T> GetAttributeOfEnumMember(System.Enum enumVal)
  System.Boolean HasAttribute(System.Reflection.MemberInfo element, System.Boolean inherit)
  TAttribute GetAttribute(System.Reflection.MemberInfo element, System.Boolean inherit)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.ConversionUtility
TYPE:  class
TOKEN: 0x200004F
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<Unity.VisualScripting.ConversionUtility.ConversionQuery,Unity.VisualScripting.ConversionUtility.ConversionType>conversionTypesCache  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<Unity.VisualScripting.ConversionUtility.ConversionQuery,System.Reflection.MethodInfo[]>userConversionMethodsCache  // 0x8
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.HashSet<System.Type>>implicitNumericConversions  // 0x10
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.HashSet<System.Type>>explicitNumericConversions  // 0x18
METHODS:
  System.Boolean RespectsIdentity(System.Type source, System.Type destination)
  System.Boolean IsUpcast(System.Type source, System.Type destination)
  System.Boolean IsDowncast(System.Type source, System.Type destination)
  System.Boolean HasImplicitNumericConversion(System.Type source, System.Type destination)
  System.Boolean HasExplicitNumericConversion(System.Type source, System.Type destination)
  System.Boolean HasNumericConversion(System.Type source, System.Type destination)
  System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> FindUserDefinedConversionMethods(Unity.VisualScripting.ConversionUtility.ConversionQuery query)
  System.Reflection.MethodInfo[] GetUserDefinedConversionMethods(System.Type source, System.Type destination)
  Unity.VisualScripting.ConversionUtility.ConversionType GetUserDefinedConversionType(System.Type source, System.Type destination)
  System.Boolean HasEnumerableToArrayConversion(System.Type source, System.Type destination)
  System.Boolean HasEnumerableToListConversion(System.Type source, System.Type destination)
  System.Boolean HasUnityHierarchyConversion(System.Type source, System.Type destination)
  System.Boolean IsValidConversion(Unity.VisualScripting.ConversionUtility.ConversionType conversionType, System.Boolean guaranteed)
  System.Boolean CanConvert(System.Object value, System.Type type, System.Boolean guaranteed)
  System.Boolean CanConvert(System.Type source, System.Type destination, System.Boolean guaranteed)
  System.Object Convert(System.Object value, System.Type type)
  System.Boolean IsConvertibleTo(System.Type source, System.Type destination, System.Boolean guaranteed)
  System.Boolean IsConvertibleTo(System.Object source, System.Type type, System.Boolean guaranteed)
  Unity.VisualScripting.ConversionUtility.ConversionType GetRequiredConversion(System.Type source, System.Type destination)
  Unity.VisualScripting.ConversionUtility.ConversionType DetermineConversionType(Unity.VisualScripting.ConversionUtility.ConversionQuery query)
  Unity.VisualScripting.ConversionUtility.ConversionType GetRequiredConversion(System.Object value, System.Type type)
  System.Object NumericConversion(System.Object value, System.Type type)
  System.Object UserDefinedConversion(Unity.VisualScripting.ConversionUtility.ConversionType conversion, System.Object value, System.Type type)
  System.Object EnumerableToArrayConversion(System.Object value, System.Type arrayType)
  System.Object EnumerableToListConversion(System.Object value, System.Type listType)
  System.Object UnityHierarchyConversion(System.Object value, System.Type type)
  System.Object Convert(System.Object value, System.Type type, Unity.VisualScripting.ConversionUtility.ConversionType conversionType)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.LooseAssemblyName
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  public    readonly System.String                   name  // 0x10
METHODS:
  System.Void .ctor(System.String name)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.VisualScripting.MemberUtility
TYPE:  class
TOKEN: 0x2000057
FIELDS:
  private   static readonly System.Lazy<Unity.VisualScripting.ExtensionMethodCache>ExtensionMethodsCache  // 0x0
  private   static readonly System.Lazy<System.Collections.Generic.Dictionary<System.Type,System.Reflection.MethodInfo[]>>InheritedExtensionMethodsCache  // 0x8
  private   static readonly System.Lazy<System.Collections.Generic.HashSet<System.Reflection.MethodInfo>>GenericExtensionMethods  // 0x10
METHODS:
  System.Void .cctor()
  System.Boolean IsUserDefinedConversion(System.Reflection.MethodInfo method)
  System.Boolean IsExtension(System.Reflection.MethodInfo methodInfo)
  System.Boolean IsStatic(System.Reflection.PropertyInfo propertyInfo)
  System.Boolean IsStatic(System.Reflection.MemberInfo memberInfo)
  System.Boolean CanWrite(System.Reflection.FieldInfo fieldInfo)
END_CLASS

CLASS: Unity.VisualScripting.ExtensionMethodCache
TYPE:  class
TOKEN: 0x2000059
FIELDS:
  private   readonly System.Reflection.MethodInfo[]  Cache  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.Namespace
TYPE:  class
TOKEN: 0x200005B
FIELDS:
  private   readonly Unity.VisualScripting.Namespace <Root>k__BackingField  // 0x10
  private   readonly Unity.VisualScripting.Namespace <Parent>k__BackingField  // 0x18
  private   readonly System.String                   <FullName>k__BackingField  // 0x20
  private   readonly System.String                   <Name>k__BackingField  // 0x28
  private   readonly System.Boolean                  <IsRoot>k__BackingField  // 0x30
  private   readonly System.Boolean                  <IsGlobal>k__BackingField  // 0x31
  private   static readonly Unity.VisualScripting.Namespace.Collectioncollection  // 0x0
  private   static readonly Unity.VisualScripting.Namespace <Global>k__BackingField  // 0x8
METHODS:
  System.Void .ctor(System.String fullName)
  System.String get_FullName()
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void .cctor()
  Unity.VisualScripting.Namespace get_Global()
  Unity.VisualScripting.Namespace FromFullName(System.String fullName)
  System.Boolean Equals(System.Object obj)
  Unity.VisualScripting.Namespace op_Implicit(System.String fullName)
  System.Boolean op_Equality(Unity.VisualScripting.Namespace a, Unity.VisualScripting.Namespace b)
END_CLASS

CLASS: Unity.VisualScripting.Action`5
TYPE:  class
TOKEN: 0x200005D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
END_CLASS

CLASS: Unity.VisualScripting.Action`6
TYPE:  class
TOKEN: 0x200005E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
END_CLASS

CLASS: Unity.VisualScripting.Func`6
TYPE:  class
TOKEN: 0x200005F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
END_CLASS

CLASS: Unity.VisualScripting.Func`7
TYPE:  class
TOKEN: 0x2000060
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
END_CLASS

CLASS: Unity.VisualScripting.InstanceActionInvokerBase`1
TYPE:  class
TOKEN: 0x2000061
EXTENDS: InstanceInvokerBase`1
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
END_CLASS

CLASS: Unity.VisualScripting.InstanceActionInvoker`1
TYPE:  class
TOKEN: 0x2000062
EXTENDS: InstanceActionInvokerBase`1
FIELDS:
  private           System.Action<TTarget>          invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceActionInvoker`2
TYPE:  class
TOKEN: 0x2000063
EXTENDS: InstanceActionInvokerBase`1
FIELDS:
  private           System.Action<TTarget,TParam0>  invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Object Invoke(System.Object target, System.Object arg0)
  System.Object InvokeUnsafe(System.Object target, System.Object arg0)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceActionInvoker`3
TYPE:  class
TOKEN: 0x2000064
EXTENDS: InstanceActionInvokerBase`1
FIELDS:
  private           System.Action<TTarget,TParam0,TParam1>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceActionInvoker`4
TYPE:  class
TOKEN: 0x2000065
EXTENDS: InstanceActionInvokerBase`1
FIELDS:
  private           System.Action<TTarget,TParam0,TParam1,TParam2>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceActionInvoker`5
TYPE:  class
TOKEN: 0x2000066
EXTENDS: InstanceActionInvokerBase`1
FIELDS:
  private           Unity.VisualScripting.Action<TTarget,TParam0,TParam1,TParam2,TParam3>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceActionInvoker`6
TYPE:  class
TOKEN: 0x2000067
EXTENDS: InstanceActionInvokerBase`1
FIELDS:
  private           Unity.VisualScripting.Action<TTarget,TParam0,TParam1,TParam2,TParam3,TParam4>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceFieldAccessor`2
TYPE:  class
TOKEN: 0x2000068
FIELDS:
  private   readonly System.Reflection.FieldInfo     fieldInfo  // 0x0
  private           System.Func<TTarget,TField>     getter  // 0x0
  private           System.Action<TTarget,TField>   setter  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.FieldInfo fieldInfo)
  System.Void Compile()
  System.Object GetValue(System.Object target)
  System.Object GetValueUnsafe(System.Object target)
  System.Void SetValue(System.Object target, System.Object value)
  System.Void SetValueUnsafe(System.Object target, System.Object value)
  TField <Compile>b__4_0(TTarget instance)
  System.Void <Compile>b__4_1(TTarget instance, TField value)
END_CLASS

CLASS: Unity.VisualScripting.InstanceFunctionInvokerBase`2
TYPE:  class
TOKEN: 0x2000069
EXTENDS: InstanceInvokerBase`1
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
END_CLASS

CLASS: Unity.VisualScripting.InstanceFunctionInvoker`2
TYPE:  class
TOKEN: 0x200006A
EXTENDS: InstanceFunctionInvokerBase`2
FIELDS:
  private           System.Func<TTarget,TResult>    invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceFunctionInvoker`3
TYPE:  class
TOKEN: 0x200006B
EXTENDS: InstanceFunctionInvokerBase`2
FIELDS:
  private           System.Func<TTarget,TParam0,TResult>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Object Invoke(System.Object target, System.Object arg0)
  System.Object InvokeUnsafe(System.Object target, System.Object arg0)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceFunctionInvoker`4
TYPE:  class
TOKEN: 0x200006C
EXTENDS: InstanceFunctionInvokerBase`2
FIELDS:
  private           System.Func<TTarget,TParam0,TParam1,TResult>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceFunctionInvoker`5
TYPE:  class
TOKEN: 0x200006D
EXTENDS: InstanceFunctionInvokerBase`2
FIELDS:
  private           System.Func<TTarget,TParam0,TParam1,TParam2,TResult>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceFunctionInvoker`6
TYPE:  class
TOKEN: 0x200006E
EXTENDS: InstanceFunctionInvokerBase`2
FIELDS:
  private           Unity.VisualScripting.Func<TTarget,TParam0,TParam1,TParam2,TParam3,TResult>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceFunctionInvoker`7
TYPE:  class
TOKEN: 0x200006F
EXTENDS: InstanceFunctionInvokerBase`2
FIELDS:
  private           Unity.VisualScripting.Func<TTarget,TParam0,TParam1,TParam2,TParam3,TParam4,TResult>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
END_CLASS

CLASS: Unity.VisualScripting.InstanceInvokerBase`1
TYPE:  class
TOKEN: 0x2000070
EXTENDS: InvokerBase
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Void CompileExpression()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void VerifyTarget(System.Object target)
END_CLASS

CLASS: Unity.VisualScripting.InstancePropertyAccessor`2
TYPE:  class
TOKEN: 0x2000071
FIELDS:
  private   readonly System.Reflection.PropertyInfo  propertyInfo  // 0x0
  private           System.Func<TTarget,TProperty>  getter  // 0x0
  private           System.Action<TTarget,TProperty>setter  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.PropertyInfo propertyInfo)
  System.Void Compile()
  System.Object GetValue(System.Object target)
  System.Object GetValueUnsafe(System.Object target)
  System.Void SetValue(System.Object target, System.Object value)
  System.Void SetValueUnsafe(System.Object target, System.Object value)
END_CLASS

CLASS: Unity.VisualScripting.InvokerBase
TYPE:  class
TOKEN: 0x2000072
FIELDS:
  protected readonly System.Type                     targetType  // 0x10
  protected readonly System.Reflection.MethodInfo    methodInfo  // 0x18
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Void VerifyArgument(System.Reflection.MethodInfo methodInfo, System.Int32 argIndex, System.Object arg)
  System.Void Compile()
  System.Linq.Expressions.ParameterExpression[] GetParameterExpressions()
  System.Type[] GetParameterTypes()
  System.Object Invoke(System.Object target, System.Object arg0)
  System.Void CompileExpression()
  System.Void CreateDelegate()
  System.Void VerifyTarget(System.Object target)
END_CLASS

CLASS: Unity.VisualScripting.IOptimizedAccessor
TYPE:  interface
TOKEN: 0x2000073
FIELDS:
METHODS:
  System.Void Compile()
  System.Object GetValue(System.Object target)
  System.Void SetValue(System.Object target, System.Object value)
END_CLASS

CLASS: Unity.VisualScripting.IOptimizedInvoker
TYPE:  interface
TOKEN: 0x2000074
FIELDS:
METHODS:
  System.Void Compile()
  System.Object Invoke(System.Object target, System.Object arg0)
END_CLASS

CLASS: Unity.VisualScripting.OptimizedReflection
TYPE:  class
TOKEN: 0x2000075
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Reflection.FieldInfo,Unity.VisualScripting.IOptimizedAccessor>fieldAccessors  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.Reflection.PropertyInfo,Unity.VisualScripting.IOptimizedAccessor>propertyAccessors  // 0x8
  private   static readonly System.Collections.Generic.Dictionary<System.Reflection.MethodInfo,Unity.VisualScripting.IOptimizedInvoker>methodInvokers  // 0x10
  public    static readonly System.Boolean                  jitAvailable  // 0x18
  private   static  System.Boolean                  _useJitIfAvailable  // 0x19
  private   static  System.Boolean                  <safeMode>k__BackingField  // 0x1A
METHODS:
  System.Void .cctor()
  System.Boolean get_useJit()
  System.Boolean get_useJitIfAvailable()
  System.Boolean get_safeMode()
  System.Void set_safeMode(System.Boolean value)
  System.Void OnRuntimeMethodLoad()
  System.Void VerifyStaticTarget(System.Type targetType, System.Object target)
  System.Void VerifyInstanceTarget(System.Object target)
  System.Void VerifyTarget(System.Type targetType, System.Object target, System.Boolean static)
  System.Boolean SupportsOptimization(System.Reflection.MemberInfo memberInfo)
  Unity.VisualScripting.IOptimizedAccessor Prewarm(System.Reflection.FieldInfo fieldInfo)
  System.Void SetValueOptimized(System.Reflection.FieldInfo fieldInfo, System.Object target, System.Object value)
  System.Boolean SupportsOptimization(System.Reflection.FieldInfo fieldInfo)
  Unity.VisualScripting.IOptimizedAccessor GetFieldAccessor(System.Reflection.FieldInfo fieldInfo)
  Unity.VisualScripting.IOptimizedAccessor Prewarm(System.Reflection.PropertyInfo propertyInfo)
  System.Void SetValueOptimized(System.Reflection.PropertyInfo propertyInfo, System.Object target, System.Object value)
  System.Boolean SupportsOptimization(System.Reflection.PropertyInfo propertyInfo)
  Unity.VisualScripting.IOptimizedAccessor GetPropertyAccessor(System.Reflection.PropertyInfo propertyInfo)
  Unity.VisualScripting.IOptimizedInvoker Prewarm(System.Reflection.MethodInfo methodInfo)
  System.Object InvokeOptimized(System.Reflection.MethodInfo methodInfo, System.Object target, System.Object arg0)
  System.Boolean SupportsOptimization(System.Reflection.MethodInfo methodInfo)
  Unity.VisualScripting.IOptimizedInvoker GetMethodInvoker(System.Reflection.MethodInfo methodInfo)
END_CLASS

CLASS: Unity.VisualScripting.ReflectionFieldAccessor
TYPE:  class
TOKEN: 0x2000077
FIELDS:
  private   readonly System.Reflection.FieldInfo     fieldInfo  // 0x10
METHODS:
  System.Void .ctor(System.Reflection.FieldInfo fieldInfo)
  System.Void Compile()
  System.Object GetValue(System.Object target)
  System.Void SetValue(System.Object target, System.Object value)
END_CLASS

CLASS: Unity.VisualScripting.ReflectionInvoker
TYPE:  class
TOKEN: 0x2000078
FIELDS:
  private   readonly System.Reflection.MethodInfo    methodInfo  // 0x10
  private   static readonly System.Object[]                 EmptyObjects  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Void Compile()
  System.Object Invoke(System.Object target, System.Object arg0)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.ReflectionPropertyAccessor
TYPE:  class
TOKEN: 0x2000079
FIELDS:
  private   readonly System.Reflection.PropertyInfo  propertyInfo  // 0x10
METHODS:
  System.Void .ctor(System.Reflection.PropertyInfo propertyInfo)
  System.Void Compile()
  System.Object GetValue(System.Object target)
  System.Void SetValue(System.Object target, System.Object value)
END_CLASS

CLASS: Unity.VisualScripting.StaticActionInvokerBase
TYPE:  class
TOKEN: 0x200007A
EXTENDS: StaticInvokerBase
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
END_CLASS

CLASS: Unity.VisualScripting.StaticActionInvoker
TYPE:  class
TOKEN: 0x200007B
EXTENDS: StaticActionInvokerBase
FIELDS:
  private           System.Action                   invoke  // 0x20
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  System.Void <CreateDelegate>b__7_0()
END_CLASS

CLASS: Unity.VisualScripting.StaticActionInvoker`1
TYPE:  class
TOKEN: 0x200007C
EXTENDS: StaticActionInvokerBase
FIELDS:
  private           System.Action<TParam0>          invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Object Invoke(System.Object target, System.Object arg0)
  System.Object InvokeUnsafe(System.Object target, System.Object arg0)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  System.Void <CreateDelegate>b__7_0(TParam0 param0)
END_CLASS

CLASS: Unity.VisualScripting.StaticActionInvoker`2
TYPE:  class
TOKEN: 0x200007D
EXTENDS: StaticActionInvokerBase
FIELDS:
  private           System.Action<TParam0,TParam1>  invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  System.Void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1)
END_CLASS

CLASS: Unity.VisualScripting.StaticActionInvoker`3
TYPE:  class
TOKEN: 0x200007E
EXTENDS: StaticActionInvokerBase
FIELDS:
  private           System.Action<TParam0,TParam1,TParam2>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  System.Void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2)
END_CLASS

CLASS: Unity.VisualScripting.StaticActionInvoker`4
TYPE:  class
TOKEN: 0x200007F
EXTENDS: StaticActionInvokerBase
FIELDS:
  private           System.Action<TParam0,TParam1,TParam2,TParam3>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  System.Void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3)
END_CLASS

CLASS: Unity.VisualScripting.StaticActionInvoker`5
TYPE:  class
TOKEN: 0x2000080
EXTENDS: StaticActionInvokerBase
FIELDS:
  private           Unity.VisualScripting.Action<TParam0,TParam1,TParam2,TParam3,TParam4>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  System.Void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
END_CLASS

CLASS: Unity.VisualScripting.StaticFieldAccessor`1
TYPE:  class
TOKEN: 0x2000081
FIELDS:
  private   readonly System.Reflection.FieldInfo     fieldInfo  // 0x0
  private           System.Func<TField>             getter  // 0x0
  private           System.Action<TField>           setter  // 0x0
  private           System.Type                     targetType  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.FieldInfo fieldInfo)
  System.Void Compile()
  System.Object GetValue(System.Object target)
  System.Object GetValueUnsafe(System.Object target)
  System.Void SetValue(System.Object target, System.Object value)
  System.Void SetValueUnsafe(System.Object target, System.Object value)
  TField <Compile>b__5_0()
  System.Void <Compile>b__5_1(TField value)
END_CLASS

CLASS: Unity.VisualScripting.StaticFunctionInvokerBase`1
TYPE:  class
TOKEN: 0x2000083
EXTENDS: StaticInvokerBase
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
END_CLASS

CLASS: Unity.VisualScripting.StaticFunctionInvoker`1
TYPE:  class
TOKEN: 0x2000084
EXTENDS: StaticFunctionInvokerBase`1
FIELDS:
  private           System.Func<TResult>            invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  TResult <CreateDelegate>b__7_0()
END_CLASS

CLASS: Unity.VisualScripting.StaticFunctionInvoker`2
TYPE:  class
TOKEN: 0x2000085
EXTENDS: StaticFunctionInvokerBase`1
FIELDS:
  private           System.Func<TParam0,TResult>    invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Object Invoke(System.Object target, System.Object arg0)
  System.Object InvokeUnsafe(System.Object target, System.Object arg0)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  TResult <CreateDelegate>b__7_0(TParam0 param0)
END_CLASS

CLASS: Unity.VisualScripting.StaticFunctionInvoker`3
TYPE:  class
TOKEN: 0x2000086
EXTENDS: StaticFunctionInvokerBase`1
FIELDS:
  private           System.Func<TParam0,TParam1,TResult>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1)
END_CLASS

CLASS: Unity.VisualScripting.StaticFunctionInvoker`4
TYPE:  class
TOKEN: 0x2000087
EXTENDS: StaticFunctionInvokerBase`1
FIELDS:
  private           System.Func<TParam0,TParam1,TParam2,TResult>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2)
END_CLASS

CLASS: Unity.VisualScripting.StaticFunctionInvoker`5
TYPE:  class
TOKEN: 0x2000088
EXTENDS: StaticFunctionInvokerBase`1
FIELDS:
  private           System.Func<TParam0,TParam1,TParam2,TParam3,TResult>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3)
END_CLASS

CLASS: Unity.VisualScripting.StaticFunctionInvoker`6
TYPE:  class
TOKEN: 0x2000089
EXTENDS: StaticFunctionInvokerBase`1
FIELDS:
  private           Unity.VisualScripting.Func<TParam0,TParam1,TParam2,TParam3,TParam4,TResult>invoke  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Type[] GetParameterTypes()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void CreateDelegate()
  TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
END_CLASS

CLASS: Unity.VisualScripting.StaticInvokerBase
TYPE:  class
TOKEN: 0x200008A
EXTENDS: InvokerBase
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo methodInfo)
  System.Void CompileExpression()
  System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions)
  System.Void VerifyTarget(System.Object target)
END_CLASS

CLASS: Unity.VisualScripting.StaticPropertyAccessor`1
TYPE:  class
TOKEN: 0x200008B
FIELDS:
  private   readonly System.Reflection.PropertyInfo  propertyInfo  // 0x0
  private           System.Func<TProperty>          getter  // 0x0
  private           System.Action<TProperty>        setter  // 0x0
  private           System.Type                     targetType  // 0x0
METHODS:
  System.Void .ctor(System.Reflection.PropertyInfo propertyInfo)
  System.Void Compile()
  System.Object GetValue(System.Object target)
  System.Object GetValueUnsafe(System.Object target)
  System.Void SetValue(System.Object target, System.Object value)
  System.Void SetValueUnsafe(System.Object target, System.Object value)
END_CLASS

CLASS: Unity.VisualScripting.RenamedAssemblyAttribute
TYPE:  class
TOKEN: 0x200008C
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   <previousName>k__BackingField  // 0x10
  private   readonly System.String                   <newName>k__BackingField  // 0x18
METHODS:
  System.String get_previousName()
  System.String get_newName()
END_CLASS

CLASS: Unity.VisualScripting.RenamedFromAttribute
TYPE:  class
TOKEN: 0x200008D
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   <previousName>k__BackingField  // 0x10
METHODS:
  System.String get_previousName()
END_CLASS

CLASS: Unity.VisualScripting.RenamedNamespaceAttribute
TYPE:  class
TOKEN: 0x200008E
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   <previousName>k__BackingField  // 0x10
  private   readonly System.String                   <newName>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.String previousName, System.String newName)
  System.String get_previousName()
  System.String get_newName()
END_CLASS

CLASS: Unity.VisualScripting.RuntimeCodebase
TYPE:  class
TOKEN: 0x200008F
FIELDS:
  private   static readonly System.Object                   lock  // 0x0
  private   static readonly System.Collections.Generic.List<System.Type>_types  // 0x8
  private   static readonly System.Collections.Generic.List<System.Reflection.Assembly>_assemblies  // 0x10
  public    static  System.Collections.Generic.HashSet<System.String>disallowedAssemblies  // 0x18
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.Type>typeSerializations  // 0x20
  private   static  System.Collections.Generic.Dictionary<System.String,System.Type>_renamedTypes  // 0x28
  private   static  System.Collections.Generic.Dictionary<System.String,System.String>_renamedNamespaces  // 0x30
  private   static  System.Collections.Generic.Dictionary<System.String,System.String>_renamedAssemblies  // 0x38
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.String>>_renamedMembers  // 0x40
METHODS:
  System.Collections.Generic.IEnumerable<System.Type> get_types()
  System.Collections.Generic.IEnumerable<System.Reflection.Assembly> get_assemblies()
  System.Void .cctor()
  System.Collections.Generic.IEnumerable<System.Attribute> GetAssemblyAttributes(System.Type attributeType)
  System.Collections.Generic.IEnumerable<System.Attribute> GetAssemblyAttributes(System.Type attributeType, System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies)
  System.Collections.Generic.IEnumerable<TAttribute> GetAssemblyAttributes()
  System.String SerializeType(System.Type type)
  System.Boolean TryDeserializeType(System.String typeName, System.Type& type)
  System.Type DeserializeType(System.String typeName)
  System.Boolean TryCachedTypeLookup(System.String typeName, System.Type& type)
  System.Boolean TrySystemTypeLookup(System.String typeName, System.Type& type)
  System.Boolean TrySystemTypeLookup(Unity.VisualScripting.TypeName typeName, System.Type& type)
  System.Boolean TryRenamedTypeLookup(System.String previousTypeName, System.Type& type)
  System.Collections.Generic.Dictionary<System.String,System.String> get_renamedNamespaces()
  System.Collections.Generic.Dictionary<System.String,System.String> get_renamedAssemblies()
  System.Collections.Generic.Dictionary<System.String,System.Type> get_renamedTypes()
  System.Collections.Generic.Dictionary<System.String,System.String> FetchRenamedNamespaces()
  System.Collections.Generic.Dictionary<System.String,System.String> FetchRenamedAssemblies()
  System.Collections.Generic.Dictionary<System.String,System.Type> FetchRenamedTypes()
END_CLASS

CLASS: Unity.VisualScripting.TypeName
TYPE:  class
TOKEN: 0x2000092
FIELDS:
  private           System.String                   <AssemblyDescription>k__BackingField  // 0x10
  private           System.String                   <AssemblyName>k__BackingField  // 0x18
  private           System.String                   <AssemblyVersion>k__BackingField  // 0x20
  private           System.String                   <AssemblyCulture>k__BackingField  // 0x28
  private           System.String                   <AssemblyPublicKeyToken>k__BackingField  // 0x30
  private   readonly System.Collections.Generic.List<Unity.VisualScripting.TypeName><GenericParameters>k__BackingField  // 0x38
  private   readonly System.Collections.Generic.List<System.String>names  // 0x40
  private   readonly System.Collections.Generic.List<System.Int32>genericarities  // 0x48
  private           System.String                   <Name>k__BackingField  // 0x50
METHODS:
  System.String get_AssemblyDescription()
  System.Void set_AssemblyDescription(System.String value)
  System.String get_AssemblyName()
  System.Void set_AssemblyName(System.String value)
  System.Void set_AssemblyVersion(System.String value)
  System.Void set_AssemblyCulture(System.String value)
  System.Void set_AssemblyPublicKeyToken(System.String value)
  System.Collections.Generic.List<Unity.VisualScripting.TypeName> get_GenericParameters()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_IsArray()
  Unity.VisualScripting.TypeName Parse(System.String s)
  System.Void .ctor(System.String s, System.Int32& index)
  System.String LookForPairThenRemove(System.Collections.Generic.List<System.String> strings, System.String Name)
  System.Void ReplaceNamespace(System.String oldNamespace, System.String newNamespace)
  System.Void ReplaceAssembly(System.String oldAssembly, System.String newAssembly)
  System.Void ReplaceName(System.String oldTypeName, System.Type newType)
  System.Void ReplaceName(System.String oldTypeName, System.String newTypeName, System.Reflection.AssemblyName newAssemblyName)
  System.String ToElementTypeName(System.String s)
  System.String ToArrayOrType(System.String oldType, System.String newType)
  System.Void SetAssemblyName(System.Reflection.AssemblyName newAssemblyName)
  System.Void UpdateName()
  System.String ToString(Unity.VisualScripting.TypeNameDetail specification, Unity.VisualScripting.TypeNameDetail genericsSpecification)
  System.String ToString()
  System.String ToLooseString()
END_CLASS

CLASS: Unity.VisualScripting.TypeNameDetail
TYPE:  struct
TOKEN: 0x2000095
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.VisualScripting.TypeNameDetailName  // 0x0
  public    static  Unity.VisualScripting.TypeNameDetailNameAndAssembly  // 0x0
  public    static  Unity.VisualScripting.TypeNameDetailFull  // 0x0
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.TypeUtility
TYPE:  class
TOKEN: 0x2000096
FIELDS:
  private   static readonly System.Collections.Generic.HashSet<System.Type>_numericTypes  // 0x0
  private   static readonly System.Collections.Generic.HashSet<System.Type>_numericConstructTypes  // 0x8
  private   static readonly System.Collections.Generic.HashSet<System.Type>typesWithShortStrings  // 0x10
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Object>defaultPrimitives  // 0x18
METHODS:
  System.Boolean IsBasic(System.Type type)
  System.Boolean IsStatic(System.Type type)
  System.Boolean IsNullable(System.Type type)
  System.Boolean IsReferenceType(System.Type type)
  System.Boolean IsAssignableFrom(System.Type type, System.Object value)
  System.Collections.Generic.IEnumerable<System.Type> GetTypesSafely(System.Reflection.Assembly assembly)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.LooseAssemblyNameConverter
TYPE:  class
TOKEN: 0x2000099
EXTENDS: fsDirectConverter
FIELDS:
METHODS:
  System.Type get_ModelType()
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.NamespaceConverter
TYPE:  class
TOKEN: 0x200009A
EXTENDS: fsDirectConverter
FIELDS:
METHODS:
  System.Type get_ModelType()
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.Ray2DConverter
TYPE:  class
TOKEN: 0x200009B
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.Ray2D model, System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> serialized)
  Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, UnityEngine.Ray2D& model)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.RayConverter
TYPE:  class
TOKEN: 0x200009C
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.Ray model, System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> serialized)
  Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, UnityEngine.Ray& model)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.UnityObjectConverter
TYPE:  class
TOKEN: 0x200009D
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Collections.Generic.List<UnityEngine.Object> get_objectReferences()
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData storage, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.DoNotSerializeAttribute
TYPE:  class
TOKEN: 0x200009E
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.ISerializationDependency
TYPE:  interface
TOKEN: 0x200009F
FIELDS:
METHODS:
  System.Boolean get_IsDeserialized()
END_CLASS

CLASS: Unity.VisualScripting.ISerializationDepender
TYPE:  interface
TOKEN: 0x20000A0
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies()
  System.Void OnAfterDependenciesDeserialized()
END_CLASS

CLASS: Unity.VisualScripting.Serialization
TYPE:  class
TOKEN: 0x20000A1
FIELDS:
  private   static readonly System.Collections.Generic.HashSet<Unity.VisualScripting.SerializationOperation>freeOperations  // 0x0
  private   static readonly System.Collections.Generic.HashSet<Unity.VisualScripting.SerializationOperation>busyOperations  // 0x8
  private   static readonly System.Object                   lock  // 0x10
  private   static  System.Boolean                  <isUnitySerializing>k__BackingField  // 0x18
  private   static readonly System.Collections.Generic.HashSet<Unity.VisualScripting.ISerializationDepender>awaitingDependers  // 0x20
METHODS:
  System.Void .cctor()
  System.Boolean get_isUnitySerializing()
  System.Void set_isUnitySerializing(System.Boolean value)
  System.Boolean get_isCustomSerializing()
  Unity.VisualScripting.SerializationOperation StartOperation()
  System.Void EndOperation(Unity.VisualScripting.SerializationOperation operation)
  Unity.VisualScripting.SerializationData Serialize(System.Object value, System.Boolean forceReflected)
  System.Void DeserializeInto(Unity.VisualScripting.SerializationData data, System.Object& instance, System.Boolean forceReflected)
  System.Object Deserialize(Unity.VisualScripting.SerializationData data, System.Boolean forceReflected)
  System.String SerializeJson(Unity.VisualScripting.FullSerializer.fsSerializer serializer, System.Object instance, System.Boolean forceReflected)
  Unity.VisualScripting.FullSerializer.fsResult DeserializeJsonUtil(Unity.VisualScripting.FullSerializer.fsSerializer serializer, System.String json, System.Object& instance, System.Boolean forceReflected)
  System.Void DeserializeJson(Unity.VisualScripting.FullSerializer.fsSerializer serializer, System.String json, System.Object& instance, System.Boolean forceReflected)
  System.Void HandleResult(System.String label, Unity.VisualScripting.FullSerializer.fsResult result, UnityEngine.Object context)
  System.String PrettyPrint(System.String json)
  System.Void AwaitDependencies(Unity.VisualScripting.ISerializationDepender depender)
  System.Void CheckIfDependenciesMet(Unity.VisualScripting.ISerializationDepender depender)
END_CLASS

CLASS: Unity.VisualScripting.SerializationData
TYPE:  struct
TOKEN: 0x20000A2
FIELDS:
  private           System.String                   _json  // 0x10
  private           UnityEngine.Object[]            _objectReferences  // 0x18
METHODS:
  System.String get_json()
  UnityEngine.Object[] get_objectReferences()
  System.Void .ctor(System.String json, System.Collections.Generic.IEnumerable<UnityEngine.Object> objectReferences)
  System.Void .ctor(System.String json, UnityEngine.Object[] objectReferences)
  System.Void Clear()
  System.String ToString(System.String title)
  System.String ToString()
  System.Void ShowString(System.String title)
END_CLASS

CLASS: Unity.VisualScripting.SerializationOperation
TYPE:  class
TOKEN: 0x20000A3
FIELDS:
  private           Unity.VisualScripting.FullSerializer.fsSerializer<serializer>k__BackingField  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Object><objectReferences>k__BackingField  // 0x18
METHODS:
  System.Void .ctor()
  Unity.VisualScripting.FullSerializer.fsSerializer get_serializer()
  System.Void set_serializer(Unity.VisualScripting.FullSerializer.fsSerializer value)
  System.Collections.Generic.List<UnityEngine.Object> get_objectReferences()
  System.Void set_objectReferences(System.Collections.Generic.List<UnityEngine.Object> value)
  System.Void Reset()
END_CLASS

CLASS: Unity.VisualScripting.SerializationVersionAttribute
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: fsObjectAttribute
FIELDS:
METHODS:
  System.Void .ctor(System.String versionString, System.Type[] previousModels)
END_CLASS

CLASS: Unity.VisualScripting.SerializeAsAttribute
TYPE:  class
TOKEN: 0x20000A5
EXTENDS: fsPropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor(System.String name)
END_CLASS

CLASS: Unity.VisualScripting.SerializeAttribute
TYPE:  class
TOKEN: 0x20000A6
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.ISingleton
TYPE:  interface
TOKEN: 0x20000A7
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.LudiqScriptableObject
TYPE:  class
TOKEN: 0x20000A8
EXTENDS: ScriptableObject
FIELDS:
  protected         Unity.VisualScripting.SerializationData_data  // 0x18
  private           System.Action                   OnDestroyActions  // 0x28
METHODS:
  System.Void add_OnDestroyActions(System.Action value)
  System.Void remove_OnDestroyActions(System.Action value)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void OnBeforeSerialize()
  System.Void OnAfterSerialize()
  System.Void OnBeforeDeserialize()
  System.Void OnAfterDeserialize()
  System.Void OnPostDeserializeInEditor()
  System.Void OnDestroy()
  System.Void ShowData()
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.Singleton`1
TYPE:  class
TOKEN: 0x20000A9
FIELDS:
  private   static readonly Unity.VisualScripting.SingletonAttributeattribute  // 0x0
  private   static readonly System.Object                   _lock  // 0x0
  private   static readonly System.Collections.Generic.HashSet<T>awoken  // 0x0
  private   static  T                               _instance  // 0x0
METHODS:
  System.Void .cctor()
  System.Boolean get_persistent()
  System.Boolean get_automatic()
  System.String get_name()
  UnityEngine.HideFlags get_hideFlags()
  T get_instance()
  T[] FindObjectsOfType()
  T[] FindInstances()
  T Instantiate()
  System.Void Awake(T instance)
  System.Void OnDestroy(T instance)
END_CLASS

CLASS: Unity.VisualScripting.SingletonAttribute
TYPE:  class
TOKEN: 0x20000AA
EXTENDS: Attribute
FIELDS:
  private           System.Boolean                  <Persistent>k__BackingField  // 0x10
  private           System.Boolean                  <Automatic>k__BackingField  // 0x11
  private           UnityEngine.HideFlags           <HideFlags>k__BackingField  // 0x14
  private           System.String                   <Name>k__BackingField  // 0x18
METHODS:
  System.Void .ctor()
  System.Boolean get_Persistent()
  System.Void set_Persistent(System.Boolean value)
  System.Boolean get_Automatic()
  System.Void set_Automatic(System.Boolean value)
  UnityEngine.HideFlags get_HideFlags()
  System.Void set_HideFlags(UnityEngine.HideFlags value)
  System.String get_Name()
  System.Void set_Name(System.String value)
END_CLASS

CLASS: Unity.VisualScripting.UnityThread
TYPE:  class
TOKEN: 0x20000AB
FIELDS:
  public    static  System.Threading.Thread         thread  // 0x0
  public    static  System.Collections.Concurrent.ConcurrentQueue<System.Action>pendingQueue  // 0x8
METHODS:
  System.Boolean get_allowsAPI()
  System.Void RuntimeInitialize()
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.Empty`1
TYPE:  class
TOKEN: 0x20000AC
FIELDS:
  public    static readonly T[]                             array  // 0x0
  public    static readonly System.Collections.Generic.List<T>list  // 0x0
  public    static readonly System.Collections.Generic.HashSet<T>hashSet  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.HashUtility
TYPE:  class
TOKEN: 0x20000AD
FIELDS:
METHODS:
  System.Int32 GetHashCode(T a)
  System.Int32 GetHashCode(T1 a, T2 b)
END_CLASS

CLASS: Unity.VisualScripting.IIdentifiable
TYPE:  interface
TOKEN: 0x20000AE
FIELDS:
METHODS:
  System.Guid get_guid()
END_CLASS

CLASS: Unity.VisualScripting.LinqUtility
TYPE:  class
TOKEN: 0x20000AF
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<T> Concat(System.Collections.IEnumerable[] enumerables)
  System.Collections.Generic.IEnumerable<T> NotNull(System.Collections.Generic.IEnumerable<T> enumerable)
END_CLASS

CLASS: Unity.VisualScripting.Recursion`1
TYPE:  class
TOKEN: 0x20000B2
FIELDS:
  private   readonly System.Collections.Generic.Stack<T>traversedOrder  // 0x0
  private   readonly System.Collections.Generic.Dictionary<T,System.Int32>traversedCount  // 0x0
  private           System.Boolean                  disposed  // 0x0
  protected         System.Int32                    maxDepth  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Enter(T o)
  System.Boolean TryEnter(T o)
  System.Void Exit(T o)
  System.Void Dispose()
  System.Void Free()
  System.Void Unity.VisualScripting.IPoolable.New()
  System.Void Unity.VisualScripting.IPoolable.Free()
  Unity.VisualScripting.Recursion<T> New()
  Unity.VisualScripting.Recursion<T> New(System.Int32 maxDepth)
END_CLASS

CLASS: Unity.VisualScripting.Recursion
TYPE:  class
TOKEN: 0x20000B4
EXTENDS: Recursion`1
FIELDS:
  private   static  System.Int32                    <defaultMaxDepth>k__BackingField  // 0x0
  private   static  System.Boolean                  <safeMode>k__BackingField  // 0x4
METHODS:
  System.Int32 get_defaultMaxDepth()
  System.Boolean get_safeMode()
  System.Void set_safeMode(System.Boolean value)
  System.Void OnRuntimeMethodLoad()
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.ReferenceCollector
TYPE:  class
TOKEN: 0x20000B5
FIELDS:
  private   static  System.Action                   onSceneUnloaded  // 0x0
METHODS:
  System.Void add_onSceneUnloaded(System.Action value)
  System.Void remove_onSceneUnloaded(System.Action value)
  System.Void Initialize()
END_CLASS

CLASS: Unity.VisualScripting.ReferenceEqualityComparer
TYPE:  class
TOKEN: 0x20000B7
FIELDS:
  public    static readonly Unity.VisualScripting.ReferenceEqualityComparerInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.Boolean System.Collections.Generic.IEqualityComparer<System.Object>.Equals(System.Object a, System.Object b)
  System.Int32 System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(System.Object a)
  System.Int32 GetHashCode(System.Object a)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.ReferenceEqualityComparer`1
TYPE:  class
TOKEN: 0x20000B8
FIELDS:
  public    static readonly Unity.VisualScripting.ReferenceEqualityComparer<T>Instance  // 0x0
METHODS:
  System.Void .ctor()
  System.Boolean System.Collections.Generic.IEqualityComparer<T>.Equals(T a, T b)
  System.Int32 System.Collections.Generic.IEqualityComparer<T>.GetHashCode(T a)
  System.Int32 GetHashCode(T a)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.RuntimeVSUsageUtility
TYPE:  class
TOKEN: 0x20000B9
FIELDS:
METHODS:
  System.Void RuntimeInitializeOnLoadBeforeSceneLoad()
END_CLASS

CLASS: Unity.VisualScripting.StringUtility
TYPE:  class
TOKEN: 0x20000BA
FIELDS:
  private   static readonly System.Text.RegularExpressions.RegexguidRegex  // 0x0
METHODS:
  System.String TrimStart(System.String source, System.String value)
  System.Void PartsAround(System.String s, System.Char c, System.String& before, System.String& after)
  System.String ToHexString(System.Byte[] bytes)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.UnityObjectUtility
TYPE:  class
TOKEN: 0x20000BB
FIELDS:
METHODS:
  System.Boolean IsUnityNull(System.Object obj)
  System.String ToSafeString(UnityEngine.Object uo)
  T AsUnityNull(T obj)
  System.Boolean TrulyEqual(UnityEngine.Object a, UnityEngine.Object b)
END_CLASS

CLASS: Unity.VisualScripting.ApplicationVariables
TYPE:  class
TOKEN: 0x20000BC
FIELDS:
  private   static  Unity.VisualScripting.VariablesAsset_asset  // 0x0
  private   static  Unity.VisualScripting.VariableDeclarations<runtime>k__BackingField  // 0x8
METHODS:
  Unity.VisualScripting.VariablesAsset get_asset()
  System.Void Load()
  System.Void set_runtime(Unity.VisualScripting.VariableDeclarations value)
  System.Void OnEnterPlayMode()
  System.Void OnExitPlayMode()
  System.Void CreateRuntimeDeclarations()
END_CLASS

CLASS: Unity.VisualScripting.InspectorVariableNameAttribute
TYPE:  class
TOKEN: 0x20000BD
EXTENDS: Attribute
FIELDS:
  private           Unity.VisualScripting.ActionDirection<direction>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(Unity.VisualScripting.ActionDirection direction)
  System.Void set_direction(Unity.VisualScripting.ActionDirection value)
END_CLASS

CLASS: Unity.VisualScripting.SavedVariables
TYPE:  class
TOKEN: 0x20000BE
FIELDS:
  private   static  Unity.VisualScripting.VariablesAsset_asset  // 0x0
  private   static  Unity.VisualScripting.VariableDeclarations<saved>k__BackingField  // 0x8
  private   static  Unity.VisualScripting.VariableDeclarations<merged>k__BackingField  // 0x10
METHODS:
  Unity.VisualScripting.VariablesAsset get_asset()
  System.Void Load()
  System.Void OnEnterPlayMode()
  System.Void OnExitPlayMode()
  Unity.VisualScripting.VariableDeclarations get_initial()
  Unity.VisualScripting.VariableDeclarations get_saved()
  System.Void set_saved(Unity.VisualScripting.VariableDeclarations value)
  Unity.VisualScripting.VariableDeclarations get_merged()
  System.Void set_merged(Unity.VisualScripting.VariableDeclarations value)
  System.Void SaveDeclarations(Unity.VisualScripting.VariableDeclarations declarations)
  System.Void FetchSavedDeclarations()
  System.Void MergeInitialAndSavedDeclarations()
  System.Void WarnAndNullifyUnityObjectReferences(Unity.VisualScripting.VariableDeclarations declarations)
END_CLASS

CLASS: Unity.VisualScripting.VariableDeclaration
TYPE:  class
TOKEN: 0x20000C0
FIELDS:
  private           System.String                   <name>k__BackingField  // 0x10
  private           System.Object                   <value>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.String name, System.Object value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.Object get_value()
  System.Void set_value(System.Object value)
END_CLASS

CLASS: Unity.VisualScripting.VariableDeclarationCollection
TYPE:  class
TOKEN: 0x20000C1
EXTENDS: KeyedCollection`2
FIELDS:
METHODS:
  System.String GetKeyForItem(Unity.VisualScripting.VariableDeclaration item)
  System.Boolean TryGetValue(System.String key, Unity.VisualScripting.VariableDeclaration& value)
  System.Void .ctor()
  Unity.VisualScripting.VariableDeclaration Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.get_Item(System.String key)
  System.Boolean Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.Contains(System.String key)
END_CLASS

CLASS: Unity.VisualScripting.VariableDeclarations
TYPE:  class
TOKEN: 0x20000C2
FIELDS:
  public            Unity.VisualScripting.VariableKindKind  // 0x10
  private           Unity.VisualScripting.VariableDeclarationCollectioncollection  // 0x18
  private           System.Action                   OnVariableChanged  // 0x20
METHODS:
  System.Void .ctor()
  System.Object get_Item(System.String variable)
  System.Void set_Item(System.String variable, System.Object value)
  System.Void Set(System.String variable, System.Object value)
  System.Object Get(System.String variable)
  System.Void Clear()
  System.Boolean IsDefined(System.String variable)
  System.Collections.Generic.IEnumerator<Unity.VisualScripting.VariableDeclaration> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  Unity.VisualScripting.ICloner Unity.VisualScripting.ISpecifiesCloner.get_cloner()
END_CLASS

CLASS: Unity.VisualScripting.VariableDeclarationsCloner
TYPE:  class
TOKEN: 0x20000C3
EXTENDS: Cloner`1
FIELDS:
  public    static readonly Unity.VisualScripting.VariableDeclarationsClonerinstance  // 0x0
METHODS:
  System.Boolean Handles(System.Type type)
  Unity.VisualScripting.VariableDeclarations ConstructClone(System.Type type, Unity.VisualScripting.VariableDeclarations original)
  System.Void FillClone(System.Type type, Unity.VisualScripting.VariableDeclarations& clone, Unity.VisualScripting.VariableDeclarations original, Unity.VisualScripting.CloningContext context)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.VariableKind
TYPE:  struct
TOKEN: 0x20000C4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.VisualScripting.VariableKindFlow  // 0x0
  public    static  Unity.VisualScripting.VariableKindGraph  // 0x0
  public    static  Unity.VisualScripting.VariableKindObject  // 0x0
  public    static  Unity.VisualScripting.VariableKindScene  // 0x0
  public    static  Unity.VisualScripting.VariableKindApplication  // 0x0
  public    static  Unity.VisualScripting.VariableKindSaved  // 0x0
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.VariablesAsset
TYPE:  class
TOKEN: 0x20000C5
EXTENDS: LudiqScriptableObject
FIELDS:
  private           Unity.VisualScripting.VariableDeclarations<declarations>k__BackingField  // 0x30
METHODS:
  Unity.VisualScripting.VariableDeclarations get_declarations()
  System.Void set_declarations(Unity.VisualScripting.VariableDeclarations value)
  System.Void ShowData()
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.VariablesSaver
TYPE:  class
TOKEN: 0x20000C6
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void Awake()
  System.Void OnDestroy()
  System.Void OnApplicationQuit()
  System.Void OnApplicationPause(System.Boolean isPaused)
  Unity.VisualScripting.VariablesSaver get_instance()
  System.Void Instantiate()
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsArrayConverter
TYPE:  class
TOKEN: 0x20000C7
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsDateConverter
TYPE:  class
TOKEN: 0x20000C8
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.String get_DateTimeFormatString()
  System.Boolean CanProcess(System.Type type)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsDictionaryConverter
TYPE:  class
TOKEN: 0x20000C9
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance_, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance_, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult AddItemToDictionary(System.Collections.IDictionary dictionary, System.Object key, System.Object value)
  System.Void GetKeyValueTypes(System.Type dictionaryType, System.Type& keyStorageType, System.Type& valueStorageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsEnumConverter
TYPE:  class
TOKEN: 0x20000CA
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Boolean ArrayContains(T[] values, T value)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsForwardAttribute
TYPE:  class
TOKEN: 0x20000CD
EXTENDS: Attribute
FIELDS:
  public            System.String                   MemberName  // 0x10
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsForwardConverter
TYPE:  class
TOKEN: 0x20000CE
EXTENDS: fsConverter
FIELDS:
  private           System.String                   _memberName  // 0x18
METHODS:
  System.Void .ctor(Unity.VisualScripting.FullSerializer.fsForwardAttribute attribute)
  System.Boolean CanProcess(System.Type type)
  Unity.VisualScripting.FullSerializer.fsResult GetProperty(System.Object instance, Unity.VisualScripting.FullSerializer.fsMetaProperty& property)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsGuidConverter
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsIEnumerableConverter
TYPE:  class
TOKEN: 0x20000D0
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance_, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  System.Boolean IsStack(System.Type type)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance_, System.Type storageType)
  System.Int32 HintSize(System.Collections.IEnumerable collection)
  System.Type GetElementType(System.Type objectType)
  System.Void TryClear(System.Type type, System.Object instance)
  System.Reflection.MethodInfo GetAddMethod(System.Type type)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsKeyValuePairConverter
TYPE:  class
TOKEN: 0x20000D1
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsNullableConverter
TYPE:  class
TOKEN: 0x20000D2
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsPrimitiveConverter
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData storage, System.Object& instance, System.Type storageType)
  System.Boolean UseBool(System.Type type)
  System.Boolean UseInt64(System.Type type)
  System.Boolean UseDouble(System.Type type)
  System.Boolean UseString(System.Type type)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsReflectedConverter
TYPE:  class
TOKEN: 0x20000D4
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsTypeConverter
TYPE:  class
TOKEN: 0x20000D5
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type type)
  System.Boolean RequestInheritanceSupport(System.Type type)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsWeakReferenceConverter
TYPE:  class
TOKEN: 0x20000D6
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsConverterRegistrar
TYPE:  class
TOKEN: 0x20000D7
FIELDS:
  public    static  System.Collections.Generic.List<System.Type>Converters  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsAotCompilationManager
TYPE:  class
TOKEN: 0x20000D8
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,System.String>_computedAotCompilations  // 0x0
  private   static  System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsAotCompilationManager.AotCompilation>_uncomputedAotCompilations  // 0x8
METHODS:
  System.Void AddAotCompilation(System.Type type, Unity.VisualScripting.FullSerializer.fsMetaProperty[] members, System.Boolean isConstructorPublic)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsBaseConverter
TYPE:  class
TOKEN: 0x20000DA
FIELDS:
  public            Unity.VisualScripting.FullSerializer.fsSerializerSerializer  // 0x10
METHODS:
  System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult FailExpectedType(Unity.VisualScripting.FullSerializer.fsData data, Unity.VisualScripting.FullSerializer.fsDataType[] types)
  Unity.VisualScripting.FullSerializer.fsResult CheckType(Unity.VisualScripting.FullSerializer.fsData data, Unity.VisualScripting.FullSerializer.fsDataType type)
  Unity.VisualScripting.FullSerializer.fsResult CheckKey(Unity.VisualScripting.FullSerializer.fsData data, System.String key, Unity.VisualScripting.FullSerializer.fsData& subitem)
  Unity.VisualScripting.FullSerializer.fsResult CheckKey(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, System.String key, Unity.VisualScripting.FullSerializer.fsData& subitem)
  Unity.VisualScripting.FullSerializer.fsResult SerializeMember(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, System.Type overrideConverterType, System.String name, T value)
  Unity.VisualScripting.FullSerializer.fsResult DeserializeMember(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, System.Type overrideConverterType, System.String name, T& value)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsGlobalConfig
TYPE:  class
TOKEN: 0x20000DC
FIELDS:
  public    static  System.Boolean                  IsCaseSensitive  // 0x0
  public    static  System.Boolean                  AllowInternalExceptions  // 0x1
  public    static  System.String                   InternalFieldPrefix  // 0x8
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsConfig
TYPE:  class
TOKEN: 0x20000DD
FIELDS:
  public            System.Type[]                   SerializeAttributes  // 0x10
  public            System.Type[]                   IgnoreSerializeAttributes  // 0x18
  public            Unity.VisualScripting.FullSerializer.fsMemberSerializationDefaultMemberSerialization  // 0x20
  public            System.Func<System.String,System.Reflection.MemberInfo,System.String>GetJsonNameFromMemberName  // 0x28
  public            System.Boolean                  EnablePropertySerialization  // 0x30
  public            System.Boolean                  SerializeNonAutoProperties  // 0x31
  public            System.Boolean                  SerializeNonPublicSetProperties  // 0x32
  public            System.String                   CustomDateTimeFormatString  // 0x38
  public            System.Boolean                  Serialize64BitIntegerAsString  // 0x40
  public            System.Boolean                  SerializeEnumsAsInteger  // 0x41
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsContext
TYPE:  class
TOKEN: 0x20000DF
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Type,System.Object>_contextObjects  // 0x10
METHODS:
  System.Void Set(T obj)
  T Get()
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsConverter
TYPE:  class
TOKEN: 0x20000E0
EXTENDS: fsBaseConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsDataType
TYPE:  struct
TOKEN: 0x20000E1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.VisualScripting.FullSerializer.fsDataTypeArray  // 0x0
  public    static  Unity.VisualScripting.FullSerializer.fsDataTypeObject  // 0x0
  public    static  Unity.VisualScripting.FullSerializer.fsDataTypeDouble  // 0x0
  public    static  Unity.VisualScripting.FullSerializer.fsDataTypeInt64  // 0x0
  public    static  Unity.VisualScripting.FullSerializer.fsDataTypeBoolean  // 0x0
  public    static  Unity.VisualScripting.FullSerializer.fsDataTypeString  // 0x0
  public    static  Unity.VisualScripting.FullSerializer.fsDataTypeNull  // 0x0
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsData
TYPE:  class
TOKEN: 0x20000E2
FIELDS:
  private           System.Object                   _value  // 0x10
  public    static readonly Unity.VisualScripting.FullSerializer.fsDataTrue  // 0x0
  public    static readonly Unity.VisualScripting.FullSerializer.fsDataFalse  // 0x8
  public    static readonly Unity.VisualScripting.FullSerializer.fsDataNull  // 0x10
METHODS:
  System.String ToString()
  System.Void .ctor()
  System.Void .ctor(System.Boolean boolean)
  System.Void .ctor(System.Double f)
  System.Void .ctor(System.Int64 i)
  System.Void .ctor(System.String str)
  System.Void .ctor(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> dict)
  System.Void .ctor(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsData> list)
  Unity.VisualScripting.FullSerializer.fsData CreateDictionary()
  Unity.VisualScripting.FullSerializer.fsData CreateList(System.Int32 capacity)
  System.Void BecomeDictionary()
  Unity.VisualScripting.FullSerializer.fsData Clone()
  Unity.VisualScripting.FullSerializer.fsDataType get_Type()
  System.Boolean get_IsNull()
  System.Boolean get_IsDouble()
  System.Boolean get_IsInt64()
  System.Boolean get_IsBool()
  System.Boolean get_IsString()
  System.Boolean get_IsDictionary()
  System.Boolean get_IsList()
  System.Double get_AsDouble()
  System.Int64 get_AsInt64()
  System.Boolean get_AsBool()
  System.String get_AsString()
  System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> get_AsDictionary()
  System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsData> get_AsList()
  T Cast()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(Unity.VisualScripting.FullSerializer.fsData other)
  System.Boolean op_Equality(Unity.VisualScripting.FullSerializer.fsData a, Unity.VisualScripting.FullSerializer.fsData b)
  System.Boolean op_Inequality(Unity.VisualScripting.FullSerializer.fsData a, Unity.VisualScripting.FullSerializer.fsData b)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsDirectConverter
TYPE:  class
TOKEN: 0x20000E3
EXTENDS: fsBaseConverter
FIELDS:
METHODS:
  System.Type get_ModelType()
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsDirectConverter`1
TYPE:  class
TOKEN: 0x20000E4
EXTENDS: fsDirectConverter
FIELDS:
METHODS:
  System.Type get_ModelType()
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult DoSerialize(TModel model, System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> serialized)
  Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, TModel& model)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsMissingVersionConstructorException
TYPE:  class
TOKEN: 0x20000E5
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor(System.Type versionedType, System.Type constructorType)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsDuplicateVersionNameException
TYPE:  class
TOKEN: 0x20000E6
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor(System.Type typeA, System.Type typeB, System.String version)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsIgnoreAttribute
TYPE:  class
TOKEN: 0x20000E7
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsISerializationCallbacks
TYPE:  interface
TOKEN: 0x20000E8
FIELDS:
METHODS:
  System.Void OnBeforeSerialize(System.Type storageType)
  System.Void OnAfterSerialize(System.Type storageType, Unity.VisualScripting.FullSerializer.fsData& data)
  System.Void OnBeforeDeserialize(System.Type storageType, Unity.VisualScripting.FullSerializer.fsData& data)
  System.Void OnAfterDeserialize(System.Type storageType)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsSerializationCallbackProcessor
TYPE:  class
TOKEN: 0x20000E9
EXTENDS: fsObjectProcessor
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Void OnBeforeSerialize(System.Type storageType, System.Object instance)
  System.Void OnAfterSerialize(System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  System.Void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  System.Void OnAfterDeserialize(System.Type storageType, System.Object instance)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsSerializationCallbackReceiverProcessor
TYPE:  class
TOKEN: 0x20000EA
EXTENDS: fsObjectProcessor
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Void OnBeforeSerialize(System.Type storageType, System.Object instance)
  System.Void OnAfterDeserialize(System.Type storageType, System.Object instance)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsJsonParser
TYPE:  class
TOKEN: 0x20000EB
FIELDS:
  private   readonly System.Text.StringBuilder       _cachedStringBuilder  // 0x10
  private           System.Int32                    _start  // 0x18
  private           System.String                   _input  // 0x20
METHODS:
  System.Void .ctor(System.String input)
  Unity.VisualScripting.FullSerializer.fsResult MakeFailure(System.String message)
  System.Boolean TryMoveNext()
  System.Boolean HasValue()
  System.Boolean HasValue(System.Int32 offset)
  System.Char Character()
  System.Char Character(System.Int32 offset)
  System.Void SkipSpace()
  Unity.VisualScripting.FullSerializer.fsResult TryParseExact(System.String content)
  Unity.VisualScripting.FullSerializer.fsResult TryParseTrue(Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsResult TryParseFalse(Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsResult TryParseNull(Unity.VisualScripting.FullSerializer.fsData& data)
  System.Boolean IsSeparator(System.Char c)
  Unity.VisualScripting.FullSerializer.fsResult TryParseNumber(Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsResult TryParseString(System.String& str)
  Unity.VisualScripting.FullSerializer.fsResult TryParseArray(Unity.VisualScripting.FullSerializer.fsData& arr)
  Unity.VisualScripting.FullSerializer.fsResult TryParseObject(Unity.VisualScripting.FullSerializer.fsData& obj)
  Unity.VisualScripting.FullSerializer.fsResult RunParse(Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsResult Parse(System.String input, Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsData Parse(System.String input)
  System.Boolean IsHex(System.Char c)
  System.UInt32 ParseSingleChar(System.Char c1, System.UInt32 multipliyer)
  System.UInt32 ParseUnicode(System.Char c1, System.Char c2, System.Char c3, System.Char c4)
  Unity.VisualScripting.FullSerializer.fsResult TryUnescapeChar(System.Char& escaped)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsJsonPrinter
TYPE:  class
TOKEN: 0x20000EC
FIELDS:
METHODS:
  System.Void InsertSpacing(System.IO.TextWriter stream, System.Int32 count)
  System.String EscapeString(System.String str)
  System.Void BuildCompressedString(Unity.VisualScripting.FullSerializer.fsData data, System.IO.TextWriter stream)
  System.Void BuildPrettyString(Unity.VisualScripting.FullSerializer.fsData data, System.IO.TextWriter stream, System.Int32 depth)
  System.String PrettyJson(Unity.VisualScripting.FullSerializer.fsData data)
  System.String CompressedJson(Unity.VisualScripting.FullSerializer.fsData data)
  System.String ConvertDoubleToString(System.Double d)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsMemberSerialization
TYPE:  struct
TOKEN: 0x20000ED
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.VisualScripting.FullSerializer.fsMemberSerializationOptIn  // 0x0
  public    static  Unity.VisualScripting.FullSerializer.fsMemberSerializationOptOut  // 0x0
  public    static  Unity.VisualScripting.FullSerializer.fsMemberSerializationDefault  // 0x0
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsObjectAttribute
TYPE:  class
TOKEN: 0x20000EE
EXTENDS: Attribute
FIELDS:
  public            System.Type[]                   PreviousModels  // 0x10
  public            System.String                   VersionString  // 0x18
  public            Unity.VisualScripting.FullSerializer.fsMemberSerializationMemberSerialization  // 0x20
  public            System.Type                     Converter  // 0x28
  public            System.Type                     Processor  // 0x30
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String versionString, System.Type[] previousModels)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsObjectProcessor
TYPE:  class
TOKEN: 0x20000EF
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Void OnBeforeSerialize(System.Type storageType, System.Object instance)
  System.Void OnAfterSerialize(System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  System.Void OnBeforeDeserialize(System.Type storageType, Unity.VisualScripting.FullSerializer.fsData& data)
  System.Void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  System.Void OnAfterDeserialize(System.Type storageType, System.Object instance)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsPropertyAttribute
TYPE:  class
TOKEN: 0x20000F0
EXTENDS: Attribute
FIELDS:
  public            System.String                   Name  // 0x10
  public            System.Type                     Converter  // 0x18
METHODS:
  System.Void .ctor(System.String name)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsResult
TYPE:  struct
TOKEN: 0x20000F1
FIELDS:
  private   static readonly System.String[]                 EmptyStringArray  // 0x0
  private           System.Boolean                  _success  // 0x10
  private           System.Collections.Generic.List<System.String>_messages  // 0x18
  public    static  Unity.VisualScripting.FullSerializer.fsResultSuccess  // 0x8
METHODS:
  System.Void AddMessage(System.String message)
  System.Void AddMessages(Unity.VisualScripting.FullSerializer.fsResult result)
  Unity.VisualScripting.FullSerializer.fsResult Merge(Unity.VisualScripting.FullSerializer.fsResult other)
  Unity.VisualScripting.FullSerializer.fsResult Warn(System.String warning)
  Unity.VisualScripting.FullSerializer.fsResult Fail(System.String warning)
  Unity.VisualScripting.FullSerializer.fsResult op_Addition(Unity.VisualScripting.FullSerializer.fsResult a, Unity.VisualScripting.FullSerializer.fsResult b)
  System.Boolean get_Failed()
  System.Boolean get_Succeeded()
  System.Boolean get_HasWarnings()
  Unity.VisualScripting.FullSerializer.fsResult AssertSuccess()
  System.Exception get_AsException()
  System.Collections.Generic.IEnumerable<System.String> get_RawMessages()
  System.String get_FormattedMessages()
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsSerializer
TYPE:  class
TOKEN: 0x20000F2
FIELDS:
  private   readonly System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsConverter>_availableConverters  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.FullSerializer.fsDirectConverter>_availableDirectConverters  // 0x18
  private   readonly System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor>_processors  // 0x20
  private   readonly Unity.VisualScripting.FullSerializer.Internal.fsCyclicReferenceManager_references  // 0x28
  private   readonly Unity.VisualScripting.FullSerializer.fsSerializer.fsLazyCycleDefinitionWriter_lazyReferenceWriter  // 0x30
  private   readonly System.Collections.Generic.Dictionary<System.Type,System.Type>_abstractTypeRemap  // 0x38
  private           System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.FullSerializer.fsBaseConverter>_cachedConverterTypeInstances  // 0x40
  private           System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.FullSerializer.fsBaseConverter>_cachedConverters  // 0x48
  private           System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor>>_cachedProcessors  // 0x50
  public            Unity.VisualScripting.FullSerializer.fsContextContext  // 0x58
  public            Unity.VisualScripting.FullSerializer.fsConfigConfig  // 0x60
  private   static  System.Collections.Generic.HashSet<System.String>_reservedKeywords  // 0x0
  private   static readonly System.String                   Key_ObjectReference  // 0x8
  private   static readonly System.String                   Key_ObjectDefinition  // 0x10
  private   static readonly System.String                   Key_InstanceType  // 0x18
  private   static readonly System.String                   Key_Version  // 0x20
  private   static readonly System.String                   Key_Content  // 0x28
  private   static readonly System.String                   Key_UnitDefault  // 0x30
  private   static readonly System.String                   Key_UnitPosition  // 0x38
  private   static readonly System.String                   Key_UnitGuid  // 0x40
  private   static readonly System.String                   Key_UnitFormerType  // 0x48
  private   static readonly System.String                   Key_UnitFormerValue  // 0x50
  private   static readonly System.String                   TypeName_Unit  // 0x58
  private   static readonly System.Type                     Type_Unit  // 0x60
  private   static readonly System.String                   TypeName_MissingType  // 0x68
  private   static readonly System.Type                     Type_MissingType  // 0x70
METHODS:
  System.Void .ctor()
  System.Void RemapAbstractStorageTypeToDefaultType(System.Type& storageType)
  System.Void SetDefaultStorageType(System.Type abstractType, System.Type defaultStorageType)
  System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> GetProcessors(System.Type type)
  System.Void AddConverter(Unity.VisualScripting.FullSerializer.fsBaseConverter converter)
  Unity.VisualScripting.FullSerializer.fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(T instance, Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, T& instance)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Type storageType, System.Type overrideConverterType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_1_ProcessCycles(System.Type storageType, System.Type overrideConverterType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_2_Inheritance(System.Type storageType, System.Type overrideConverterType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_3_ProcessVersioning(System.Type overrideConverterType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_4_Converter(System.Type overrideConverterType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, System.Object& result)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, System.Type overrideConverterType, System.Object& result)
  Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_1_CycleReference(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, System.Object& result, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor>& processors)
  Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_2_Version(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, System.Object& result, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor>& processors)
  Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_3_Inheritance(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, System.Object& result, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor>& processors)
  Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_4_Cycles(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type resultType, System.Object& result)
  Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_5_Converter(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type resultType, System.Object& result)
  System.Type GetDataType(Unity.VisualScripting.FullSerializer.fsData& data, System.Type defaultType, Unity.VisualScripting.FullSerializer.fsResult& deserializeResult)
  System.Void EnsureDictionary(Unity.VisualScripting.FullSerializer.fsData data)
  System.Void .cctor()
  System.Boolean IsReservedKeyword(System.String key)
  System.Boolean IsObjectReference(Unity.VisualScripting.FullSerializer.fsData data)
  System.Boolean IsObjectDefinition(Unity.VisualScripting.FullSerializer.fsData data)
  System.Boolean IsVersioned(Unity.VisualScripting.FullSerializer.fsData data)
  System.Boolean IsTypeSpecified(Unity.VisualScripting.FullSerializer.fsData data)
  System.Boolean IsWrappedData(Unity.VisualScripting.FullSerializer.fsData data)
  System.Boolean IsVisualScriptingUnit(Unity.VisualScripting.FullSerializer.fsData data)
  System.Void ConvertLegacyData(Unity.VisualScripting.FullSerializer.fsData& data)
  System.Void Invoke_OnBeforeSerialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance)
  System.Void Invoke_OnAfterSerialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  System.Void Invoke_OnBeforeDeserialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, Unity.VisualScripting.FullSerializer.fsData& data)
  System.Void Invoke_OnBeforeDeserializeAfterInstanceCreation(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data)
  System.Void Invoke_OnAfterDeserialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsMetaProperty
TYPE:  class
TOKEN: 0x20000F4
FIELDS:
  private           System.Reflection.MemberInfo    _memberInfo  // 0x10
  private           System.Type                     <StorageType>k__BackingField  // 0x18
  private           System.Type                     <OverrideConverterType>k__BackingField  // 0x20
  private           System.Boolean                  <CanRead>k__BackingField  // 0x28
  private           System.Boolean                  <CanWrite>k__BackingField  // 0x29
  private           System.String                   <JsonName>k__BackingField  // 0x30
  private           System.String                   <MemberName>k__BackingField  // 0x38
  private           System.Boolean                  <IsPublic>k__BackingField  // 0x40
  private           System.Boolean                  <IsReadOnly>k__BackingField  // 0x41
METHODS:
  System.Void .ctor(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.FieldInfo field)
  System.Void .ctor(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.PropertyInfo property)
  System.Type get_StorageType()
  System.Void set_StorageType(System.Type value)
  System.Type get_OverrideConverterType()
  System.Void set_OverrideConverterType(System.Type value)
  System.Boolean get_CanRead()
  System.Void set_CanRead(System.Boolean value)
  System.Boolean get_CanWrite()
  System.Void set_CanWrite(System.Boolean value)
  System.String get_JsonName()
  System.Void set_JsonName(System.String value)
  System.String get_MemberName()
  System.Void set_MemberName(System.String value)
  System.Boolean get_IsPublic()
  System.Void set_IsPublic(System.Boolean value)
  System.Boolean get_IsReadOnly()
  System.Void set_IsReadOnly(System.Boolean value)
  System.Void CommonInitialize(Unity.VisualScripting.FullSerializer.fsConfig config)
  System.Void Write(System.Object context, System.Object value)
  System.Object Read(System.Object context)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsMetaType
TYPE:  class
TOKEN: 0x20000F5
FIELDS:
  public            System.Type                     ReflectedType  // 0x10
  private           System.Boolean                  _hasEmittedAotData  // 0x18
  private           System.Nullable<System.Boolean> _hasDefaultConstructorCache  // 0x19
  private           System.Boolean                  _isDefaultConstructorPublic  // 0x1B
  private           Unity.VisualScripting.FullSerializer.fsMetaProperty[]<Properties>k__BackingField  // 0x20
  private   static  System.Collections.Generic.Dictionary<Unity.VisualScripting.FullSerializer.fsConfig,System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.FullSerializer.fsMetaType>>_configMetaTypes  // 0x0
METHODS:
  System.Void .ctor(Unity.VisualScripting.FullSerializer.fsConfig config, System.Type reflectedType)
  Unity.VisualScripting.FullSerializer.fsMetaProperty[] get_Properties()
  System.Void set_Properties(Unity.VisualScripting.FullSerializer.fsMetaProperty[] value)
  System.Boolean get_HasDefaultConstructor()
  System.Boolean EmitAotData()
  System.Object CreateInstance()
  Unity.VisualScripting.FullSerializer.fsMetaType Get(Unity.VisualScripting.FullSerializer.fsConfig config, System.Type type)
  System.Void CollectProperties(Unity.VisualScripting.FullSerializer.fsConfig config, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsMetaProperty> properties, System.Type reflectedType)
  System.Boolean IsAutoProperty(System.Reflection.PropertyInfo property, System.Reflection.MemberInfo[] members)
  System.Boolean CanSerializeProperty(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.PropertyInfo property, System.Reflection.MemberInfo[] members, System.Boolean annotationFreeValue)
  System.Boolean CanSerializeField(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.FieldInfo field, System.Boolean annotationFreeValue)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.fsReflectionUtility
TYPE:  class
TOKEN: 0x20000F9
FIELDS:
METHODS:
  System.Type GetInterface(System.Type type, System.Type interfaceType)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.Internal.fsCyclicReferenceManager
TYPE:  class
TOKEN: 0x20000FA
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Object,System.Int32>_objectIds  // 0x10
  private           System.Int32                    _nextId  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,System.Object>_marked  // 0x20
  private           System.Int32                    _depth  // 0x28
METHODS:
  System.Void Enter()
  System.Boolean Exit()
  System.Object GetReferenceObject(System.Int32 id)
  System.Void AddReferenceWithId(System.Int32 id, System.Object reference)
  System.Int32 GetReferenceId(System.Object item)
  System.Boolean IsReference(System.Object item)
  System.Void MarkSerialized(System.Object item)
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.Internal.fsOption`1
TYPE:  struct
TOKEN: 0x20000FC
FIELDS:
  private           System.Boolean                  _hasValue  // 0x0
  private           T                               _value  // 0x0
METHODS:
  System.Boolean get_HasValue()
  System.Boolean get_IsEmpty()
  T get_Value()
  System.Void .ctor(T value)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.Internal.fsOption
TYPE:  class
TOKEN: 0x20000FD
FIELDS:
METHODS:
  Unity.VisualScripting.FullSerializer.Internal.fsOption<T> Just(T value)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection
TYPE:  class
TOKEN: 0x20000FE
FIELDS:
  public    static  System.Type[]                   EmptyTypes  // 0x0
  private   static  System.Collections.Generic.IDictionary<Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery,System.Attribute>_cachedAttributeQueries  // 0x8
  private   static  System.Reflection.BindingFlags  DeclaredFlags  // 0x10
METHODS:
  System.Boolean HasAttribute(System.Reflection.MemberInfo element, System.Type attributeType)
  System.Boolean HasAttribute(System.Reflection.MemberInfo element, System.Type attributeType, System.Boolean shouldCache)
  System.Attribute GetAttribute(System.Reflection.MemberInfo element, System.Type attributeType, System.Boolean shouldCache)
  TAttribute GetAttribute(System.Reflection.MemberInfo element, System.Boolean shouldCache)
  TAttribute GetAttribute(System.Reflection.MemberInfo element)
  System.Reflection.PropertyInfo GetDeclaredProperty(System.Type type, System.String propertyName)
  System.Reflection.MethodInfo GetDeclaredMethod(System.Type type, System.String methodName)
  System.Reflection.ConstructorInfo GetDeclaredConstructor(System.Type type, System.Type[] parameters)
  System.Reflection.ConstructorInfo[] GetDeclaredConstructors(System.Type type)
  System.Reflection.MethodInfo GetFlattenedMethod(System.Type type, System.String methodName)
  System.Reflection.MethodInfo[] GetDeclaredMethods(System.Type type)
  System.Reflection.PropertyInfo[] GetDeclaredProperties(System.Type type)
  System.Reflection.FieldInfo[] GetDeclaredFields(System.Type type)
  System.Reflection.MemberInfo[] GetDeclaredMembers(System.Type type)
  System.Type Resolve(System.Type type)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.Internal.fsTypeExtensions
TYPE:  class
TOKEN: 0x2000101
FIELDS:
METHODS:
  System.String CSharpName(System.Type type)
  System.String CSharpName(System.Type type, System.Boolean includeNamespace)
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.Internal.fsVersionedType
TYPE:  struct
TOKEN: 0x2000103
FIELDS:
  public            Unity.VisualScripting.FullSerializer.Internal.fsVersionedType[]Ancestors  // 0x10
  public            System.String                   VersionString  // 0x18
  public            System.Type                     ModelType  // 0x20
METHODS:
  System.Object Migrate(System.Object ancestorInstance)
  System.String ToString()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: Unity.VisualScripting.FullSerializer.Internal.fsVersionManager
TYPE:  class
TOKEN: 0x2000104
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.FullSerializer.Internal.fsOption<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType>>_cache  // 0x0
METHODS:
  Unity.VisualScripting.FullSerializer.fsResult GetVersionImportPath(System.String currentVersion, Unity.VisualScripting.FullSerializer.Internal.fsVersionedType targetVersion, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType>& path)
  System.Boolean GetVersionImportPathRecursive(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType> path, System.String currentVersion, Unity.VisualScripting.FullSerializer.Internal.fsVersionedType current)
  Unity.VisualScripting.FullSerializer.Internal.fsOption<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType> GetVersionedType(System.Type type)
  System.Void VerifyConstructors(Unity.VisualScripting.FullSerializer.Internal.fsVersionedType type)
  System.Void VerifyUniqueVersionStrings(Unity.VisualScripting.FullSerializer.Internal.fsVersionedType type)
  System.Void .cctor()
END_CLASS

