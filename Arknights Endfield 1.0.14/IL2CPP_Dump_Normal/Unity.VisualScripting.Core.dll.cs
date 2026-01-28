// ========================================================
// Dumped by @desirepro
// Assembly: Unity.VisualScripting.Core.dll
// Classes:  260
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000018
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private System.Collections.Generic.Dictionary.Enumerator<System.Type,Unity.VisualScripting.IKeyedCollection<TKey,TItem>> collectionsEnumerator;        // 0x0
        private TItem currentItem;        // 0x0
        private Unity.VisualScripting.IKeyedCollection<TKey,TItem> currentCollection;        // 0x0
        private System.Int32 indexInCurrentCollection;        // 0x0
        private System.Boolean exceeded;        // 0x0

        // Methods
        private System.Void .ctor(Unity.VisualScripting.MergedKeyedCollection<TKey,TItem> merged) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private TItem get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200004E
    public class AttributeCache
    {
        // Fields
        private readonly System.Collections.Generic.List<System.Attribute> <inheritedAttributes>k__BackingField;        // 0x10
        private readonly System.Collections.Generic.List<System.Attribute> <definedAttributes>k__BackingField;        // 0x18

        // Methods
        private System.Collections.Generic.List<System.Attribute> get_inheritedAttributes() { }
        private System.Collections.Generic.List<System.Attribute> get_definedAttributes() { }
        private System.Void .ctor(System.Reflection.MemberInfo element) { }
        private System.Void Cache(System.Attribute[] attributeObjects, System.Collections.Generic.List<System.Attribute> cache) { }
        private System.Boolean HasAttribute(System.Type attributeType, System.Collections.Generic.List<System.Attribute> cache) { }
        private System.Attribute GetAttribute(System.Type attributeType, System.Collections.Generic.List<System.Attribute> cache) { }
        private System.Boolean HasAttribute(System.Type attributeType, System.Boolean inherit) { }
        private System.Attribute GetAttribute(System.Type attributeType, System.Boolean inherit) { }
        private System.Boolean HasAttribute(System.Boolean inherit) { }
        private TAttribute GetAttribute(System.Boolean inherit) { }

    }

    // TypeToken: 0x2000050
    public struct ConversionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.VisualScripting.ConversionUtility.ConversionType Impossible;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType Identity;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType Upcast;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType Downcast;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType NumericImplicit;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType NumericExplicit;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType UserDefinedImplicit;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType UserDefinedExplicit;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType UserDefinedThenNumericImplicit;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType UserDefinedThenNumericExplicit;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType UnityHierarchy;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType EnumerableToArray;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType EnumerableToList;        // 0x0
        public static Unity.VisualScripting.ConversionUtility.ConversionType ToString;        // 0x0

    }

    // TypeToken: 0x2000051
    public struct ConversionQuery, IEquatable`1
    {
        // Fields
        public readonly System.Type source;        // 0x10
        public readonly System.Type destination;        // 0x18

        // Methods
        private System.Void .ctor(System.Type source, System.Type destination) { }
        private System.Boolean Equals(Unity.VisualScripting.ConversionUtility.ConversionQuery other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000052
    public struct ConversionQueryComparer, IEqualityComparer`1
    {
        // Methods
        private System.Boolean Equals(Unity.VisualScripting.ConversionUtility.ConversionQuery x, Unity.VisualScripting.ConversionUtility.ConversionQuery y) { }
        private System.Int32 GetHashCode(Unity.VisualScripting.ConversionUtility.ConversionQuery obj) { }

    }

    // TypeToken: 0x200005C
    public class Collection : KeyedCollection`2, IKeyedCollection`2, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Methods
        private System.String GetKeyForItem(Unity.VisualScripting.Namespace item) { }
        private System.Boolean TryGetValue(System.String key, Unity.VisualScripting.Namespace& value) { }
        private System.Void .ctor() { }
        private Unity.VisualScripting.Namespace Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.Namespace>.get_Item(System.String key) { }
        private System.Boolean Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.Namespace>.Contains(System.String key) { }

    }

    // TypeToken: 0x2000093
    public struct ParseState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.VisualScripting.TypeName.ParseState Name;        // 0x0
        public static Unity.VisualScripting.TypeName.ParseState Array;        // 0x0
        public static Unity.VisualScripting.TypeName.ParseState Generics;        // 0x0
        public static Unity.VisualScripting.TypeName.ParseState Assembly;        // 0x0

    }

    // TypeToken: 0x20000D9
    public struct AotCompilation
    {
        // Fields
        public System.Type Type;        // 0x10
        public Unity.VisualScripting.FullSerializer.fsMetaProperty[] Members;        // 0x18
        public System.Boolean IsConstructorPublic;        // 0x20

    }

    // TypeToken: 0x20000F3
    public class fsLazyCycleDefinitionWriter
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Int32,Unity.VisualScripting.FullSerializer.fsData> _pendingDefinitions;        // 0x10
        private System.Collections.Generic.HashSet<System.Int32> _references;        // 0x18

        // Methods
        private System.Void WriteDefinition(System.Int32 id, Unity.VisualScripting.FullSerializer.fsData data) { }
        private System.Void WriteReference(System.Int32 id, System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> dict) { }
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FB
    public class ObjectReferenceEqualityComparator, IEqualityComparer`1
    {
        // Fields
        public static readonly System.Collections.Generic.IEqualityComparer<System.Object> Instance;        // 0x0

        // Methods
        private System.Boolean System.Collections.Generic.IEqualityComparer<System.Object>.Equals(System.Object x, System.Object y) { }
        private System.Int32 System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(System.Object obj) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000FF
    public struct AttributeQuery
    {
        // Fields
        public System.Reflection.MemberInfo MemberInfo;        // 0x10
        public System.Type AttributeType;        // 0x18

    }

    // TypeToken: 0x2000100
    public class AttributeQueryComparator, IEqualityComparer`1
    {
        // Methods
        private System.Boolean Equals(Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery x, Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery y) { }
        private System.Int32 GetHashCode(Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery obj) { }
        private System.Void .ctor() { }

    }

namespace Unity.VisualScripting
{

    // TypeToken: 0x2000002
    public class Cloner`1, ICloner
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean Handles(System.Type type) { }
        private System.Void Unity.VisualScripting.ICloner.BeforeClone(System.Type type, System.Object original) { }
        private System.Void BeforeClone(System.Type type, T original) { }
        private System.Object Unity.VisualScripting.ICloner.ConstructClone(System.Type type, System.Object original) { }
        private T ConstructClone(System.Type type, T original) { }
        private System.Void Unity.VisualScripting.ICloner.FillClone(System.Type type, System.Object& clone, System.Object original, Unity.VisualScripting.CloningContext context) { }
        private System.Void FillClone(System.Type type, T& clone, T original, Unity.VisualScripting.CloningContext context) { }
        private System.Void Unity.VisualScripting.ICloner.AfterClone(System.Type type, System.Object clone) { }
        private System.Void AfterClone(System.Type type, T clone) { }

    }

    // TypeToken: 0x2000003
    public class AnimationCurveCloner : Cloner`1
    {
        // Methods
        private System.Boolean Handles(System.Type type) { }
        private UnityEngine.AnimationCurve ConstructClone(System.Type type, UnityEngine.AnimationCurve original) { }
        private System.Void FillClone(System.Type type, UnityEngine.AnimationCurve& clone, UnityEngine.AnimationCurve original, Unity.VisualScripting.CloningContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class ArrayCloner : Cloner`1
    {
        // Methods
        private System.Boolean Handles(System.Type type) { }
        private System.Array ConstructClone(System.Type type, System.Array original) { }
        private System.Void FillClone(System.Type type, System.Array& clone, System.Array original, Unity.VisualScripting.CloningContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class DictionaryCloner : Cloner`1
    {
        // Methods
        private System.Boolean Handles(System.Type type) { }
        private System.Void FillClone(System.Type type, System.Collections.IDictionary& clone, System.Collections.IDictionary original, Unity.VisualScripting.CloningContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class EnumerableCloner : Cloner`1
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.IOptimizedInvoker> addMethods;        // 0x10

        // Methods
        private System.Boolean Handles(System.Type type) { }
        private System.Void FillClone(System.Type type, System.Collections.IEnumerable& clone, System.Collections.IEnumerable original, Unity.VisualScripting.CloningContext context) { }
        private Unity.VisualScripting.IOptimizedInvoker GetAddMethod(System.Type type) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class FakeSerializationCloner : ReflectedCloner
    {
        // Fields
        private Unity.VisualScripting.FullSerializer.fsConfig <config>k__BackingField;        // 0x20

        // Methods
        private Unity.VisualScripting.FullSerializer.fsConfig get_config() { }
        private System.Void BeforeClone(System.Type type, System.Object original) { }
        private System.Void AfterClone(System.Type type, System.Object clone) { }
        private System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetMembers(System.Type type) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class FieldsCloner : ReflectedCloner
    {
        // Methods
        private System.Boolean IncludeField(System.Reflection.FieldInfo field) { }
        private System.Boolean IncludeProperty(System.Reflection.PropertyInfo property) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class GradientCloner : Cloner`1
    {
        // Methods
        private System.Boolean Handles(System.Type type) { }
        private UnityEngine.Gradient ConstructClone(System.Type type, UnityEngine.Gradient original) { }
        private System.Void FillClone(System.Type type, UnityEngine.Gradient& clone, UnityEngine.Gradient original, Unity.VisualScripting.CloningContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class ListCloner : Cloner`1
    {
        // Methods
        private System.Boolean Handles(System.Type type) { }
        private System.Void FillClone(System.Type type, System.Collections.IList& clone, System.Collections.IList original, Unity.VisualScripting.CloningContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class ReflectedCloner : Cloner`1
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Type,System.Reflection.MemberInfo[]> accessors;        // 0x10
        private readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.IOptimizedAccessor[]> optimizedAccessors;        // 0x18

        // Methods
        private System.Boolean Handles(System.Type type) { }
        private System.Void FillClone(System.Type type, System.Object& clone, System.Object original, Unity.VisualScripting.CloningContext context) { }
        private System.Reflection.MemberInfo[] GetAccessors(System.Type type) { }
        private Unity.VisualScripting.IOptimizedAccessor[] GetOptimizedAccessors(System.Type type) { }
        private System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetMembers(System.Type type) { }
        private System.Boolean IncludeField(System.Reflection.FieldInfo field) { }
        private System.Boolean IncludeProperty(System.Reflection.PropertyInfo property) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class Cloning
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Boolean> skippable;        // 0x0
        private static readonly System.Collections.Generic.HashSet<Unity.VisualScripting.ICloner> <cloners>k__BackingField;        // 0x8
        private static readonly Unity.VisualScripting.ArrayCloner <arrayCloner>k__BackingField;        // 0x10
        private static readonly Unity.VisualScripting.DictionaryCloner <dictionaryCloner>k__BackingField;        // 0x18
        private static readonly Unity.VisualScripting.EnumerableCloner <enumerableCloner>k__BackingField;        // 0x20
        private static readonly Unity.VisualScripting.ListCloner <listCloner>k__BackingField;        // 0x28
        private static readonly Unity.VisualScripting.AnimationCurveCloner <animationCurveCloner>k__BackingField;        // 0x30
        private static readonly Unity.VisualScripting.GradientCloner <gradientCloner>k__BackingField;        // 0x38
        private static readonly Unity.VisualScripting.FieldsCloner <fieldsCloner>k__BackingField;        // 0x40
        private static readonly Unity.VisualScripting.FakeSerializationCloner <fakeSerializationCloner>k__BackingField;        // 0x48

        // Methods
        private System.Void .cctor() { }
        private System.Collections.Generic.HashSet<Unity.VisualScripting.ICloner> get_cloners() { }
        private Unity.VisualScripting.ArrayCloner get_arrayCloner() { }
        private Unity.VisualScripting.DictionaryCloner get_dictionaryCloner() { }
        private Unity.VisualScripting.EnumerableCloner get_enumerableCloner() { }
        private Unity.VisualScripting.ListCloner get_listCloner() { }
        private Unity.VisualScripting.AnimationCurveCloner get_animationCurveCloner() { }
        private Unity.VisualScripting.GradientCloner get_gradientCloner() { }
        private Unity.VisualScripting.FakeSerializationCloner get_fakeSerializationCloner() { }
        private System.Object Clone(System.Object original, Unity.VisualScripting.ICloner fallbackCloner, System.Boolean tryPreserveInstances) { }
        private System.Object CloneViaFakeSerialization(System.Object original) { }
        private T CloneViaFakeSerialization(T original) { }
        private System.Object Clone(Unity.VisualScripting.CloningContext context, System.Object original) { }
        private System.Void CloneInto(Unity.VisualScripting.CloningContext context, System.Object& clone, System.Object original) { }
        private Unity.VisualScripting.ICloner GetCloner(System.Object original, System.Type type) { }
        private Unity.VisualScripting.ICloner GetCloner(System.Object original, System.Type type, Unity.VisualScripting.ICloner fallbackCloner) { }
        private System.Boolean Skippable(System.Type type) { }

    }

    // TypeToken: 0x200000F
    public class CloningContext, IPoolable, IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Object,System.Object> <clonings>k__BackingField;        // 0x10
        private Unity.VisualScripting.ICloner <fallbackCloner>k__BackingField;        // 0x18
        private System.Boolean <tryPreserveInstances>k__BackingField;        // 0x20
        private System.Boolean disposed;        // 0x21

        // Methods
        private System.Collections.Generic.Dictionary<System.Object,System.Object> get_clonings() { }
        private Unity.VisualScripting.ICloner get_fallbackCloner() { }
        private System.Void set_fallbackCloner(Unity.VisualScripting.ICloner value) { }
        private System.Boolean get_tryPreserveInstances() { }
        private System.Void set_tryPreserveInstances(System.Boolean value) { }
        private System.Void Unity.VisualScripting.IPoolable.New() { }
        private System.Void Unity.VisualScripting.IPoolable.Free() { }
        private System.Void Dispose() { }
        private Unity.VisualScripting.CloningContext New(Unity.VisualScripting.ICloner fallbackCloner, System.Boolean tryPreserveInstances) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public interface ICloner
    {
        // Methods
        private System.Boolean Handles(System.Type type) { }
        private System.Object ConstructClone(System.Type type, System.Object original) { }
        private System.Void BeforeClone(System.Type type, System.Object original) { }
        private System.Void FillClone(System.Type type, System.Object& clone, System.Object original, Unity.VisualScripting.CloningContext context) { }
        private System.Void AfterClone(System.Type type, System.Object clone) { }

    }

    // TypeToken: 0x2000012
    public interface ISpecifiesCloner
    {
        // Methods
        private Unity.VisualScripting.ICloner get_cloner() { }

    }

    // TypeToken: 0x2000013
    public class AotDictionary : OrderedDictionary
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void AotStubs() { }

    }

    // TypeToken: 0x2000014
    public class AotList : ArrayList
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void AotStubs() { }

    }

    // TypeToken: 0x2000015
    public class GuidCollection`1 : KeyedCollection`2, ICollection`1, IEnumerable`1
    {
        // Methods
        private System.Guid GetKeyForItem(T item) { }

    }

    // TypeToken: 0x2000016
    public interface IKeyedCollection`2 : ICollection`1, IEnumerable`1, IEnumerable
    {
        // Methods
        private TItem get_Item(TKey key) { }
        private TItem get_Item(System.Int32 index) { }
        private System.Boolean Contains(TKey key) { }

    }

    // TypeToken: 0x2000017
    public class MergedKeyedCollection`2, IEnumerable`1, IEnumerable
    {
        // Fields
        protected readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.IKeyedCollection<TKey,TItem>> collections;        // 0x0
        protected readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.IKeyedCollection<TKey,TItem>> collectionsLookup;        // 0x0

        // Methods
        private Unity.VisualScripting.IKeyedCollection<TKey,TItem> GetCollectionForItem(TItem item) { }
        private Unity.VisualScripting.IKeyedCollection<TKey,TItem> GetCollectionForType(System.Type type, System.Boolean throwOnFail) { }
        private System.Void Add(TItem item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(TItem item) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<TItem> System.Collections.Generic.IEnumerable<TItem>.GetEnumerator() { }
        private Unity.VisualScripting.MergedKeyedCollection.Enumerator<TKey,TItem> GetEnumerator() { }

    }

    // TypeToken: 0x2000019
    public class ConnectionCollection`3 : ConnectionCollectionBase`4
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public class ConnectionCollectionBase`4, IConnectionCollection`3, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<TDestination,System.Collections.Generic.List<TConnection>> byDestination;        // 0x0
        private readonly System.Collections.Generic.Dictionary<TSource,System.Collections.Generic.List<TConnection>> bySource;        // 0x0
        protected readonly TCollection collection;        // 0x0

        // Methods
        private System.Void .ctor(TCollection collection) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Collections.Generic.IEnumerator<TConnection> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerable<TConnection> WithSource(TSource source) { }
        private System.Collections.Generic.List<TConnection> WithSourceNoAlloc(TSource source) { }
        private TConnection SingleOrDefaultWithSource(TSource source) { }
        private System.Collections.Generic.IEnumerable<TConnection> WithDestination(TDestination destination) { }
        private System.Collections.Generic.List<TConnection> WithDestinationNoAlloc(TDestination destination) { }
        private TConnection SingleOrDefaultWithDestination(TDestination destination) { }
        private System.Void Add(TConnection item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(TConnection item) { }
        private System.Void CopyTo(TConnection[] array, System.Int32 arrayIndex) { }
        private System.Boolean Remove(TConnection item) { }
        private System.Void BeforeAdd(TConnection item) { }
        private System.Void AfterAdd(TConnection item) { }
        private System.Void BeforeRemove(TConnection item) { }
        private System.Void AfterRemove(TConnection item) { }
        private System.Void AddToDictionaries(TConnection item) { }
        private System.Void RemoveFromDictionaries(TConnection item) { }

    }

    // TypeToken: 0x200001B
    public class GraphConnectionCollection`3 : ConnectionCollectionBase`4, ICollection`1, IEnumerable`1
    {
    }

    // TypeToken: 0x200001C
    public interface IConnection`2
    {
        // Methods
        private TSource get_source() { }
        private TDestination get_destination() { }

    }

    // TypeToken: 0x200001D
    public interface IConnectionCollection`3 : ICollection`1, IEnumerable`1, IEnumerable
    {
    }

    // TypeToken: 0x200001E
    public class InvalidConnectionException : Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }

    }

    // TypeToken: 0x200001F
    public class ValueAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class DisableAnnotationAttribute : Attribute
    {
        // Fields
        private System.Boolean <disableIcon>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class EditorTimeBinding
    {
        // Fields
        public static System.Func<System.Int32> frameBinding;        // 0x0
        public static System.Func<System.Single> timeBinding;        // 0x8

        // Methods
        private System.Int32 get_frame() { }
        private System.Single get_time() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000023
    public class IncludeInSettingsAttribute : Attribute
    {
        // Fields
        private System.Boolean <include>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean include) { }
        private System.Void set_include(System.Boolean value) { }

    }

    // TypeToken: 0x2000024
    public class InspectableAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class InspectorWideAttribute : Attribute
    {
        // Fields
        private System.Boolean <toEdge>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean toEdge) { }
        private System.Void set_toEdge(System.Boolean value) { }

    }

    // TypeToken: 0x2000026
    public class Ensure
    {
        // Fields
        private static readonly Unity.VisualScripting.EnsureThat instance;        // 0x0
        private static System.Boolean <IsActive>k__BackingField;        // 0x8

        // Methods
        private System.Boolean get_IsActive() { }
        private System.Void set_IsActive(System.Boolean value) { }
        private Unity.VisualScripting.EnsureThat That(System.String paramName) { }
        private System.Void OnRuntimeMethodLoad() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000027
    public class EnsureThat
    {
        // Fields
        private System.String paramName;        // 0x10

        // Methods
        private System.Void IsNotNull(T value) { }
        private System.Void IsNotNull(System.String value) { }
        private System.Void IsOfType(T param, System.Type expectedType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000028
    public class ExceptionMessages
    {
        // Fields
        private static readonly System.String <Common_IsNull_Failed>k__BackingField;        // 0x0
        private static readonly System.String <Common_IsNotNull_Failed>k__BackingField;        // 0x8
        private static readonly System.String <Booleans_IsTrueFailed>k__BackingField;        // 0x10
        private static readonly System.String <Booleans_IsFalseFailed>k__BackingField;        // 0x18
        private static readonly System.String <Collections_Any_Failed>k__BackingField;        // 0x20
        private static readonly System.String <Collections_ContainsKey_Failed>k__BackingField;        // 0x28
        private static readonly System.String <Collections_HasItemsFailed>k__BackingField;        // 0x30
        private static readonly System.String <Collections_HasNoNullItemFailed>k__BackingField;        // 0x38
        private static readonly System.String <Collections_SizeIs_Failed>k__BackingField;        // 0x40
        private static readonly System.String <Comp_Is_Failed>k__BackingField;        // 0x48
        private static readonly System.String <Comp_IsNot_Failed>k__BackingField;        // 0x50
        private static readonly System.String <Comp_IsNotLt>k__BackingField;        // 0x58
        private static readonly System.String <Comp_IsNotLte>k__BackingField;        // 0x60
        private static readonly System.String <Comp_IsNotGt>k__BackingField;        // 0x68
        private static readonly System.String <Comp_IsNotGte>k__BackingField;        // 0x70
        private static readonly System.String <Comp_IsNotInRange_ToLow>k__BackingField;        // 0x78
        private static readonly System.String <Comp_IsNotInRange_ToHigh>k__BackingField;        // 0x80
        private static readonly System.String <Guids_IsNotEmpty_Failed>k__BackingField;        // 0x88
        private static readonly System.String <Strings_IsEqualTo_Failed>k__BackingField;        // 0x90
        private static readonly System.String <Strings_IsNotEqualTo_Failed>k__BackingField;        // 0x98
        private static readonly System.String <Strings_SizeIs_Failed>k__BackingField;        // 0xA0
        private static readonly System.String <Strings_IsNotNullOrWhiteSpace_Failed>k__BackingField;        // 0xA8
        private static readonly System.String <Strings_IsNotNullOrEmpty_Failed>k__BackingField;        // 0xB0
        private static readonly System.String <Strings_HasLengthBetween_Failed_ToShort>k__BackingField;        // 0xB8
        private static readonly System.String <Strings_HasLengthBetween_Failed_ToLong>k__BackingField;        // 0xC0
        private static readonly System.String <Strings_Matches_Failed>k__BackingField;        // 0xC8
        private static readonly System.String <Strings_IsNotEmpty_Failed>k__BackingField;        // 0xD0
        private static readonly System.String <Strings_IsGuid_Failed>k__BackingField;        // 0xD8
        private static readonly System.String <Types_IsOfType_Failed>k__BackingField;        // 0xE0
        private static readonly System.String <Reflection_HasAttribute_Failed>k__BackingField;        // 0xE8
        private static readonly System.String <Reflection_HasConstructor_Failed>k__BackingField;        // 0xF0
        private static readonly System.String <Reflection_HasPublicConstructor_Failed>k__BackingField;        // 0xF8
        private static readonly System.String <ValueTypes_IsNotDefault_Failed>k__BackingField;        // 0x100

        // Methods
        private System.String get_Common_IsNotNull_Failed() { }
        private System.String get_Types_IsOfType_Failed() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000029
    public class XString
    {
        // Methods
        private System.String Inject(System.String format, System.String[] formattingArgs) { }

    }

    // TypeToken: 0x200002B
    public struct EmptyEventArgs
    {
    }

    // TypeToken: 0x200002C
    public class InvalidConversionException : InvalidCastException
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }

    }

    // TypeToken: 0x200002D
    public class InvalidImplementationException : Exception
    {
        // Methods
        private System.Void .ctor(System.String message) { }

    }

    // TypeToken: 0x200002E
    public class UnexpectedEnumValueException`1 : Exception
    {
        // Fields
        private T <Value>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor(T value) { }
        private System.Void set_Value(T value) { }

    }

    // TypeToken: 0x200002F
    public class Graph, IGraph
    {
        // Fields
        private System.Collections.Generic.List<Unity.VisualScripting.IGraphElement> _elements;        // 0x10
        private readonly Unity.VisualScripting.MergedGraphElementCollection <elements>k__BackingField;        // 0x18

        // Methods
        private Unity.VisualScripting.MergedGraphElementCollection get_elements() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies() { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void OnAfterDependenciesDeserialized() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000031
    public class GraphElement`1, IGraphElement, IDisposable, IIdentifiable
    {
        // Fields
        private System.Guid <guid>k__BackingField;        // 0x0
        private TGraph <graph>k__BackingField;        // 0x0

        // Methods
        private System.Guid get_guid() { }
        private System.Void Dispose() { }
        private System.Int32 get_dependencyOrder() { }
        private System.Boolean HandleDependencies() { }
        private TGraph get_graph() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies() { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000032
    public class GraphElementCollection`1 : GuidCollection`1, IKeyedCollection`2, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Methods
        private TElement Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.get_Item(System.Guid key) { }
        private System.Boolean Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.Contains(System.Guid key) { }

    }

    // TypeToken: 0x2000033
    public class GraphPointer
    {
        // Fields
        private Unity.VisualScripting.IGraphRoot <root>k__BackingField;        // 0x10
        private UnityEngine.GameObject <gameObject>k__BackingField;        // 0x18
        protected readonly System.Collections.Generic.List<Unity.VisualScripting.IGraphParent> parentStack;        // 0x20
        protected readonly System.Collections.Generic.List<Unity.VisualScripting.IGraphParentElement> parentElementStack;        // 0x28
        protected readonly System.Collections.Generic.List<Unity.VisualScripting.IGraph> graphStack;        // 0x30
        protected readonly System.Collections.Generic.List<Unity.VisualScripting.IGraphData> dataStack;        // 0x38
        protected readonly System.Collections.Generic.List<Unity.VisualScripting.IGraphDebugData> debugDataStack;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private Unity.VisualScripting.GraphReference AsReference() { }
        private System.Void CopyFrom(Unity.VisualScripting.GraphPointer other) { }
        private Unity.VisualScripting.IGraphRoot get_root() { }
        private System.Void set_root(Unity.VisualScripting.IGraphRoot value) { }
        private UnityEngine.Object get_rootObject() { }
        private UnityEngine.GameObject get_gameObject() { }
        private System.Void set_gameObject(UnityEngine.GameObject value) { }
        private UnityEngine.GameObject get_self() { }
        private UnityEngine.Object get_serializedObject() { }
        private System.Int32 get_depth() { }
        private System.Boolean get_isRoot() { }
        private System.Boolean get_isChild() { }
        private System.Void EnsureChild() { }
        private Unity.VisualScripting.IGraphParent get_parent() { }
        private Unity.VisualScripting.IGraphParentElement get_parentElement() { }
        private Unity.VisualScripting.IGraph get_rootGraph() { }
        private System.Boolean get_hasDebugData() { }
        private System.Void EnsureDebugDataAvailable() { }
        private Unity.VisualScripting.IGraphDebugData get__debugData() { }
        private Unity.VisualScripting.IGraphDebugData get_debugData() { }
        private T GetElementDebugData(Unity.VisualScripting.IGraphElementWithDebugData element) { }
        private System.Void ExitParentElement() { }
        private System.Boolean get_isValid() { }
        private System.Boolean InstanceEquals(Unity.VisualScripting.GraphPointer other) { }
        private System.Boolean DefinitionEquals(Unity.VisualScripting.GraphPointer other) { }
        private System.Int32 ComputeHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000034
    public class GraphPointerException : Exception
    {
        // Fields
        private readonly Unity.VisualScripting.GraphPointer <pointer>k__BackingField;        // 0x90

        // Methods
        private System.Void .ctor(System.String message, Unity.VisualScripting.GraphPointer pointer) { }

    }

    // TypeToken: 0x2000035
    public class GraphReference : GraphPointer
    {
        // Fields
        private System.Int32 hashCode;        // 0x48
        private static readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<Unity.VisualScripting.GraphReference>> internPool;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor() { }
        private Unity.VisualScripting.GraphReference New(Unity.VisualScripting.GraphPointer model) { }
        private System.Void CopyFrom(Unity.VisualScripting.GraphPointer other) { }
        private Unity.VisualScripting.GraphReference Clone() { }
        private Unity.VisualScripting.GraphReference AsReference() { }
        private Unity.VisualScripting.GraphStack ToStackPooled() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Void Hash() { }
        private System.Int32 GetHashCode() { }
        private Unity.VisualScripting.GraphReference ParentReference(System.Boolean ensureValid) { }
        private Unity.VisualScripting.GraphReference Intern(Unity.VisualScripting.GraphPointer pointer) { }
        private System.Void FreeInvalidInterns() { }

    }

    // TypeToken: 0x2000036
    public class GraphsExceptionUtility
    {
        // Methods
        private System.Void SetException(Unity.VisualScripting.IGraphElementWithDebugData element, Unity.VisualScripting.GraphPointer pointer, System.Exception ex) { }
        private System.Void HandleException(Unity.VisualScripting.IGraphElementWithDebugData element, Unity.VisualScripting.GraphPointer pointer, System.Exception ex) { }
        private System.Boolean HandledIn(System.Exception ex, Unity.VisualScripting.GraphReference reference) { }

    }

    // TypeToken: 0x2000037
    public class GraphStack : GraphPointer, IPoolable, IDisposable
    {
        // Methods
        private System.Void .ctor() { }
        private Unity.VisualScripting.GraphStack New(Unity.VisualScripting.GraphPointer model) { }
        private System.Void Dispose() { }
        private System.Void Unity.VisualScripting.IPoolable.New() { }
        private System.Void Unity.VisualScripting.IPoolable.Free() { }
        private Unity.VisualScripting.GraphReference AsReference() { }
        private Unity.VisualScripting.GraphReference ToReference() { }

    }

    // TypeToken: 0x2000039
    public interface IGraph : IDisposable, ISerializationDepender, ISerializationCallbackReceiver
    {
        // Methods
        private Unity.VisualScripting.MergedGraphElementCollection get_elements() { }

    }

    // TypeToken: 0x200003A
    public interface IGraphData
    {
    }

    // TypeToken: 0x200003B
    public interface IGraphDebugData
    {
        // Methods
        private Unity.VisualScripting.IGraphElementDebugData GetOrCreateElementData(Unity.VisualScripting.IGraphElementWithDebugData element) { }

    }

    // TypeToken: 0x200003C
    public interface IGraphElement : IDisposable, IIdentifiable
    {
        // Methods
        private System.Boolean HandleDependencies() { }
        private System.Int32 get_dependencyOrder() { }
        private System.Guid get_guid() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies() { }

    }

    // TypeToken: 0x200003D
    public interface IGraphElementDebugData
    {
        // Methods
        private System.Void set_runtimeException(System.Exception value) { }

    }

    // TypeToken: 0x200003E
    public interface IGraphElementWithDebugData : IGraphElement, IDisposable, IIdentifiable
    {
    }

    // TypeToken: 0x200003F
    public interface IGraphParent
    {
        // Methods
        private Unity.VisualScripting.IGraph get_childGraph() { }
        private System.Boolean get_isSerializationRoot() { }
        private UnityEngine.Object get_serializedObject() { }

    }

    // TypeToken: 0x2000040
    public interface IGraphParentElement : IGraphElement, IDisposable, IIdentifiable, IGraphParent
    {
    }

    // TypeToken: 0x2000041
    public interface IGraphRoot : IGraphParent
    {
    }

    // TypeToken: 0x2000042
    public class MergedGraphElementCollection : MergedKeyedCollection`2
    {
    }

    // TypeToken: 0x2000043
    public class PlatformUtility
    {
        // Fields
        public static readonly System.Boolean supportsJit;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Boolean CheckJitSupport() { }

    }

    // TypeToken: 0x2000044
    public class GenericPool`1
    {
        // Fields
        private static readonly System.Object lock;        // 0x0
        private static readonly System.Collections.Generic.Stack<T> free;        // 0x0
        private static readonly System.Collections.Generic.HashSet<T> busy;        // 0x0

        // Methods
        private T New(System.Func<T> constructor) { }
        private System.Void Free(T item) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000045
    public interface IPoolable
    {
        // Methods
        private System.Void New() { }
        private System.Void Free() { }

    }

    // TypeToken: 0x2000046
    public class ListPool`1
    {
        // Fields
        private static readonly System.Object lock;        // 0x0
        private static readonly System.Collections.Generic.Stack<System.Collections.Generic.List<T>> free;        // 0x0
        private static readonly System.Collections.Generic.HashSet<System.Collections.Generic.List<T>> busy;        // 0x0

        // Methods
        private System.Collections.Generic.List<T> New() { }
        private System.Void Free(System.Collections.Generic.List<T> list) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000047
    public class XListPool
    {
        // Methods
        private System.Void Free(System.Collections.Generic.List<T> list) { }

    }

    // TypeToken: 0x2000048
    public class ProfiledSegment
    {
        // Fields
        private System.String <name>k__BackingField;        // 0x10
        private System.Diagnostics.Stopwatch <stopwatch>k__BackingField;        // 0x18
        private Unity.VisualScripting.ProfiledSegment <parent>k__BackingField;        // 0x20
        private Unity.VisualScripting.ProfiledSegmentCollection <children>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(Unity.VisualScripting.ProfiledSegment parent, System.String name) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Void set_stopwatch(System.Diagnostics.Stopwatch value) { }
        private System.Void set_parent(Unity.VisualScripting.ProfiledSegment value) { }
        private System.Void set_children(Unity.VisualScripting.ProfiledSegmentCollection value) { }

    }

    // TypeToken: 0x2000049
    public class ProfiledSegmentCollection : KeyedCollection`2
    {
        // Methods
        private System.String GetKeyForItem(Unity.VisualScripting.ProfiledSegment item) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004A
    public struct ProfilingScope, IDisposable
    {
        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200004B
    public class ProfilingUtility
    {
        // Fields
        private static readonly System.Object lock;        // 0x0
        private static Unity.VisualScripting.ProfiledSegment <rootSegment>k__BackingField;        // 0x8
        private static Unity.VisualScripting.ProfiledSegment <currentSegment>k__BackingField;        // 0x10

        // Methods
        private System.Void .cctor() { }
        private System.Void set_rootSegment(Unity.VisualScripting.ProfiledSegment value) { }
        private System.Void set_currentSegment(Unity.VisualScripting.ProfiledSegment value) { }
        private Unity.VisualScripting.ProfilingScope SampleBlock(System.String name) { }

    }

    // TypeToken: 0x200004C
    public struct ActionDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.VisualScripting.ActionDirection Any;        // 0x0
        public static Unity.VisualScripting.ActionDirection Get;        // 0x0
        public static Unity.VisualScripting.ActionDirection Set;        // 0x0

    }

    // TypeToken: 0x200004D
    public class AttributeUtility
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Object,Unity.VisualScripting.AttributeUtility.AttributeCache> optimizedCaches;        // 0x0

        // Methods
        private Unity.VisualScripting.AttributeUtility.AttributeCache GetAttributeCache(System.Reflection.MemberInfo element) { }
        private System.Collections.Generic.IEnumerable<T> GetAttributeOfEnumMember(System.Enum enumVal) { }
        private System.Boolean HasAttribute(System.Reflection.MemberInfo element, System.Boolean inherit) { }
        private TAttribute GetAttribute(System.Reflection.MemberInfo element, System.Boolean inherit) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004F
    public class ConversionUtility
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<Unity.VisualScripting.ConversionUtility.ConversionQuery,Unity.VisualScripting.ConversionUtility.ConversionType> conversionTypesCache;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<Unity.VisualScripting.ConversionUtility.ConversionQuery,System.Reflection.MethodInfo[]> userConversionMethodsCache;        // 0x8
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.HashSet<System.Type>> implicitNumericConversions;        // 0x10
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.HashSet<System.Type>> explicitNumericConversions;        // 0x18

        // Methods
        private System.Boolean RespectsIdentity(System.Type source, System.Type destination) { }
        private System.Boolean IsUpcast(System.Type source, System.Type destination) { }
        private System.Boolean IsDowncast(System.Type source, System.Type destination) { }
        private System.Boolean HasImplicitNumericConversion(System.Type source, System.Type destination) { }
        private System.Boolean HasExplicitNumericConversion(System.Type source, System.Type destination) { }
        private System.Boolean HasNumericConversion(System.Type source, System.Type destination) { }
        private System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> FindUserDefinedConversionMethods(Unity.VisualScripting.ConversionUtility.ConversionQuery query) { }
        private System.Reflection.MethodInfo[] GetUserDefinedConversionMethods(System.Type source, System.Type destination) { }
        private Unity.VisualScripting.ConversionUtility.ConversionType GetUserDefinedConversionType(System.Type source, System.Type destination) { }
        private System.Boolean HasEnumerableToArrayConversion(System.Type source, System.Type destination) { }
        private System.Boolean HasEnumerableToListConversion(System.Type source, System.Type destination) { }
        private System.Boolean HasUnityHierarchyConversion(System.Type source, System.Type destination) { }
        private System.Boolean IsValidConversion(Unity.VisualScripting.ConversionUtility.ConversionType conversionType, System.Boolean guaranteed) { }
        private System.Boolean CanConvert(System.Object value, System.Type type, System.Boolean guaranteed) { }
        private System.Boolean CanConvert(System.Type source, System.Type destination, System.Boolean guaranteed) { }
        private System.Object Convert(System.Object value, System.Type type) { }
        private System.Boolean IsConvertibleTo(System.Type source, System.Type destination, System.Boolean guaranteed) { }
        private System.Boolean IsConvertibleTo(System.Object source, System.Type type, System.Boolean guaranteed) { }
        private Unity.VisualScripting.ConversionUtility.ConversionType GetRequiredConversion(System.Type source, System.Type destination) { }
        private Unity.VisualScripting.ConversionUtility.ConversionType DetermineConversionType(Unity.VisualScripting.ConversionUtility.ConversionQuery query) { }
        private Unity.VisualScripting.ConversionUtility.ConversionType GetRequiredConversion(System.Object value, System.Type type) { }
        private System.Object NumericConversion(System.Object value, System.Type type) { }
        private System.Object UserDefinedConversion(Unity.VisualScripting.ConversionUtility.ConversionType conversion, System.Object value, System.Type type) { }
        private System.Object EnumerableToArrayConversion(System.Object value, System.Type arrayType) { }
        private System.Object EnumerableToListConversion(System.Object value, System.Type listType) { }
        private System.Object UnityHierarchyConversion(System.Object value, System.Type type) { }
        private System.Object Convert(System.Object value, System.Type type, Unity.VisualScripting.ConversionUtility.ConversionType conversionType) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000056
    public struct LooseAssemblyName
    {
        // Fields
        public readonly System.String name;        // 0x10

        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000057
    public class MemberUtility
    {
        // Fields
        private static readonly System.Lazy<Unity.VisualScripting.ExtensionMethodCache> ExtensionMethodsCache;        // 0x0
        private static readonly System.Lazy<System.Collections.Generic.Dictionary<System.Type,System.Reflection.MethodInfo[]>> InheritedExtensionMethodsCache;        // 0x8
        private static readonly System.Lazy<System.Collections.Generic.HashSet<System.Reflection.MethodInfo>> GenericExtensionMethods;        // 0x10

        // Methods
        private System.Void .cctor() { }
        private System.Boolean IsUserDefinedConversion(System.Reflection.MethodInfo method) { }
        private System.Boolean IsExtension(System.Reflection.MethodInfo methodInfo) { }
        private System.Boolean IsStatic(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Boolean IsStatic(System.Reflection.MemberInfo memberInfo) { }
        private System.Boolean CanWrite(System.Reflection.FieldInfo fieldInfo) { }

    }

    // TypeToken: 0x2000059
    public class ExtensionMethodCache
    {
        // Fields
        private readonly System.Reflection.MethodInfo[] Cache;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class Namespace
    {
        // Fields
        private readonly Unity.VisualScripting.Namespace <Root>k__BackingField;        // 0x10
        private readonly Unity.VisualScripting.Namespace <Parent>k__BackingField;        // 0x18
        private readonly System.String <FullName>k__BackingField;        // 0x20
        private readonly System.String <Name>k__BackingField;        // 0x28
        private readonly System.Boolean <IsRoot>k__BackingField;        // 0x30
        private readonly System.Boolean <IsGlobal>k__BackingField;        // 0x31
        private static readonly Unity.VisualScripting.Namespace.Collection collection;        // 0x0
        private static readonly Unity.VisualScripting.Namespace <Global>k__BackingField;        // 0x8

        // Methods
        private System.Void .ctor(System.String fullName) { }
        private System.String get_FullName() { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void .cctor() { }
        private Unity.VisualScripting.Namespace get_Global() { }
        private Unity.VisualScripting.Namespace FromFullName(System.String fullName) { }
        private System.Boolean Equals(System.Object obj) { }
        private Unity.VisualScripting.Namespace op_Implicit(System.String fullName) { }
        private System.Boolean op_Equality(Unity.VisualScripting.Namespace a, Unity.VisualScripting.Namespace b) { }

    }

    // TypeToken: 0x200005D
    public class Action`5 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

    }

    // TypeToken: 0x200005E
    public class Action`6 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

    }

    // TypeToken: 0x200005F
    public class Func`6 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

    }

    // TypeToken: 0x2000060
    public class Func`7 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

    }

    // TypeToken: 0x2000061
    public class InstanceActionInvokerBase`1 : InstanceInvokerBase`1
    {
        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }

    }

    // TypeToken: 0x2000062
    public class InstanceActionInvoker`1 : InstanceActionInvokerBase`1
    {
        // Fields
        private System.Action<TTarget> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x2000063
    public class InstanceActionInvoker`2 : InstanceActionInvokerBase`1
    {
        // Fields
        private System.Action<TTarget,TParam0> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Object Invoke(System.Object target, System.Object arg0) { }
        private System.Object InvokeUnsafe(System.Object target, System.Object arg0) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x2000064
    public class InstanceActionInvoker`3 : InstanceActionInvokerBase`1
    {
        // Fields
        private System.Action<TTarget,TParam0,TParam1> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x2000065
    public class InstanceActionInvoker`4 : InstanceActionInvokerBase`1
    {
        // Fields
        private System.Action<TTarget,TParam0,TParam1,TParam2> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x2000066
    public class InstanceActionInvoker`5 : InstanceActionInvokerBase`1
    {
        // Fields
        private Unity.VisualScripting.Action<TTarget,TParam0,TParam1,TParam2,TParam3> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x2000067
    public class InstanceActionInvoker`6 : InstanceActionInvokerBase`1
    {
        // Fields
        private Unity.VisualScripting.Action<TTarget,TParam0,TParam1,TParam2,TParam3,TParam4> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x2000068
    public class InstanceFieldAccessor`2, IOptimizedAccessor
    {
        // Fields
        private readonly System.Reflection.FieldInfo fieldInfo;        // 0x0
        private System.Func<TTarget,TField> getter;        // 0x0
        private System.Action<TTarget,TField> setter;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.FieldInfo fieldInfo) { }
        private System.Void Compile() { }
        private System.Object GetValue(System.Object target) { }
        private System.Object GetValueUnsafe(System.Object target) { }
        private System.Void SetValue(System.Object target, System.Object value) { }
        private System.Void SetValueUnsafe(System.Object target, System.Object value) { }
        private TField <Compile>b__4_0(TTarget instance) { }
        private System.Void <Compile>b__4_1(TTarget instance, TField value) { }

    }

    // TypeToken: 0x2000069
    public class InstanceFunctionInvokerBase`2 : InstanceInvokerBase`1
    {
        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }

    }

    // TypeToken: 0x200006A
    public class InstanceFunctionInvoker`2 : InstanceFunctionInvokerBase`2
    {
        // Fields
        private System.Func<TTarget,TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x200006B
    public class InstanceFunctionInvoker`3 : InstanceFunctionInvokerBase`2
    {
        // Fields
        private System.Func<TTarget,TParam0,TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Object Invoke(System.Object target, System.Object arg0) { }
        private System.Object InvokeUnsafe(System.Object target, System.Object arg0) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x200006C
    public class InstanceFunctionInvoker`4 : InstanceFunctionInvokerBase`2
    {
        // Fields
        private System.Func<TTarget,TParam0,TParam1,TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x200006D
    public class InstanceFunctionInvoker`5 : InstanceFunctionInvokerBase`2
    {
        // Fields
        private System.Func<TTarget,TParam0,TParam1,TParam2,TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x200006E
    public class InstanceFunctionInvoker`6 : InstanceFunctionInvokerBase`2
    {
        // Fields
        private Unity.VisualScripting.Func<TTarget,TParam0,TParam1,TParam2,TParam3,TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x200006F
    public class InstanceFunctionInvoker`7 : InstanceFunctionInvokerBase`2
    {
        // Fields
        private Unity.VisualScripting.Func<TTarget,TParam0,TParam1,TParam2,TParam3,TParam4,TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }

    }

    // TypeToken: 0x2000070
    public class InstanceInvokerBase`1 : InvokerBase
    {
        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Void CompileExpression() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void VerifyTarget(System.Object target) { }

    }

    // TypeToken: 0x2000071
    public class InstancePropertyAccessor`2, IOptimizedAccessor
    {
        // Fields
        private readonly System.Reflection.PropertyInfo propertyInfo;        // 0x0
        private System.Func<TTarget,TProperty> getter;        // 0x0
        private System.Action<TTarget,TProperty> setter;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Void Compile() { }
        private System.Object GetValue(System.Object target) { }
        private System.Object GetValueUnsafe(System.Object target) { }
        private System.Void SetValue(System.Object target, System.Object value) { }
        private System.Void SetValueUnsafe(System.Object target, System.Object value) { }

    }

    // TypeToken: 0x2000072
    public class InvokerBase, IOptimizedInvoker
    {
        // Fields
        protected readonly System.Type targetType;        // 0x10
        protected readonly System.Reflection.MethodInfo methodInfo;        // 0x18

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Void VerifyArgument(System.Reflection.MethodInfo methodInfo, System.Int32 argIndex, System.Object arg) { }
        private System.Void Compile() { }
        private System.Linq.Expressions.ParameterExpression[] GetParameterExpressions() { }
        private System.Type[] GetParameterTypes() { }
        private System.Object Invoke(System.Object target, System.Object arg0) { }
        private System.Void CompileExpression() { }
        private System.Void CreateDelegate() { }
        private System.Void VerifyTarget(System.Object target) { }

    }

    // TypeToken: 0x2000073
    public interface IOptimizedAccessor
    {
        // Methods
        private System.Void Compile() { }
        private System.Object GetValue(System.Object target) { }
        private System.Void SetValue(System.Object target, System.Object value) { }

    }

    // TypeToken: 0x2000074
    public interface IOptimizedInvoker
    {
        // Methods
        private System.Void Compile() { }
        private System.Object Invoke(System.Object target, System.Object arg0) { }

    }

    // TypeToken: 0x2000075
    public class OptimizedReflection
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Reflection.FieldInfo,Unity.VisualScripting.IOptimizedAccessor> fieldAccessors;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.Reflection.PropertyInfo,Unity.VisualScripting.IOptimizedAccessor> propertyAccessors;        // 0x8
        private static readonly System.Collections.Generic.Dictionary<System.Reflection.MethodInfo,Unity.VisualScripting.IOptimizedInvoker> methodInvokers;        // 0x10
        public static readonly System.Boolean jitAvailable;        // 0x18
        private static System.Boolean _useJitIfAvailable;        // 0x19
        private static System.Boolean <safeMode>k__BackingField;        // 0x1A

        // Methods
        private System.Void .cctor() { }
        private System.Boolean get_useJit() { }
        private System.Boolean get_useJitIfAvailable() { }
        private System.Boolean get_safeMode() { }
        private System.Void set_safeMode(System.Boolean value) { }
        private System.Void OnRuntimeMethodLoad() { }
        private System.Void VerifyStaticTarget(System.Type targetType, System.Object target) { }
        private System.Void VerifyInstanceTarget(System.Object target) { }
        private System.Void VerifyTarget(System.Type targetType, System.Object target, System.Boolean static) { }
        private System.Boolean SupportsOptimization(System.Reflection.MemberInfo memberInfo) { }
        private Unity.VisualScripting.IOptimizedAccessor Prewarm(System.Reflection.FieldInfo fieldInfo) { }
        private System.Void SetValueOptimized(System.Reflection.FieldInfo fieldInfo, System.Object target, System.Object value) { }
        private System.Boolean SupportsOptimization(System.Reflection.FieldInfo fieldInfo) { }
        private Unity.VisualScripting.IOptimizedAccessor GetFieldAccessor(System.Reflection.FieldInfo fieldInfo) { }
        private Unity.VisualScripting.IOptimizedAccessor Prewarm(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Void SetValueOptimized(System.Reflection.PropertyInfo propertyInfo, System.Object target, System.Object value) { }
        private System.Boolean SupportsOptimization(System.Reflection.PropertyInfo propertyInfo) { }
        private Unity.VisualScripting.IOptimizedAccessor GetPropertyAccessor(System.Reflection.PropertyInfo propertyInfo) { }
        private Unity.VisualScripting.IOptimizedInvoker Prewarm(System.Reflection.MethodInfo methodInfo) { }
        private System.Object InvokeOptimized(System.Reflection.MethodInfo methodInfo, System.Object target, System.Object arg0) { }
        private System.Boolean SupportsOptimization(System.Reflection.MethodInfo methodInfo) { }
        private Unity.VisualScripting.IOptimizedInvoker GetMethodInvoker(System.Reflection.MethodInfo methodInfo) { }

    }

    // TypeToken: 0x2000077
    public class ReflectionFieldAccessor, IOptimizedAccessor
    {
        // Fields
        private readonly System.Reflection.FieldInfo fieldInfo;        // 0x10

        // Methods
        private System.Void .ctor(System.Reflection.FieldInfo fieldInfo) { }
        private System.Void Compile() { }
        private System.Object GetValue(System.Object target) { }
        private System.Void SetValue(System.Object target, System.Object value) { }

    }

    // TypeToken: 0x2000078
    public class ReflectionInvoker, IOptimizedInvoker
    {
        // Fields
        private readonly System.Reflection.MethodInfo methodInfo;        // 0x10
        private static readonly System.Object[] EmptyObjects;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Void Compile() { }
        private System.Object Invoke(System.Object target, System.Object arg0) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000079
    public class ReflectionPropertyAccessor, IOptimizedAccessor
    {
        // Fields
        private readonly System.Reflection.PropertyInfo propertyInfo;        // 0x10

        // Methods
        private System.Void .ctor(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Void Compile() { }
        private System.Object GetValue(System.Object target) { }
        private System.Void SetValue(System.Object target, System.Object value) { }

    }

    // TypeToken: 0x200007A
    public class StaticActionInvokerBase : StaticInvokerBase
    {
        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }

    }

    // TypeToken: 0x200007B
    public class StaticActionInvoker : StaticActionInvokerBase
    {
        // Fields
        private System.Action invoke;        // 0x20

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private System.Void <CreateDelegate>b__7_0() { }

    }

    // TypeToken: 0x200007C
    public class StaticActionInvoker`1 : StaticActionInvokerBase
    {
        // Fields
        private System.Action<TParam0> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Object Invoke(System.Object target, System.Object arg0) { }
        private System.Object InvokeUnsafe(System.Object target, System.Object arg0) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private System.Void <CreateDelegate>b__7_0(TParam0 param0) { }

    }

    // TypeToken: 0x200007D
    public class StaticActionInvoker`2 : StaticActionInvokerBase
    {
        // Fields
        private System.Action<TParam0,TParam1> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private System.Void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1) { }

    }

    // TypeToken: 0x200007E
    public class StaticActionInvoker`3 : StaticActionInvokerBase
    {
        // Fields
        private System.Action<TParam0,TParam1,TParam2> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private System.Void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2) { }

    }

    // TypeToken: 0x200007F
    public class StaticActionInvoker`4 : StaticActionInvokerBase
    {
        // Fields
        private System.Action<TParam0,TParam1,TParam2,TParam3> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private System.Void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3) { }

    }

    // TypeToken: 0x2000080
    public class StaticActionInvoker`5 : StaticActionInvokerBase
    {
        // Fields
        private Unity.VisualScripting.Action<TParam0,TParam1,TParam2,TParam3,TParam4> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private System.Void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4) { }

    }

    // TypeToken: 0x2000081
    public class StaticFieldAccessor`1, IOptimizedAccessor
    {
        // Fields
        private readonly System.Reflection.FieldInfo fieldInfo;        // 0x0
        private System.Func<TField> getter;        // 0x0
        private System.Action<TField> setter;        // 0x0
        private System.Type targetType;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.FieldInfo fieldInfo) { }
        private System.Void Compile() { }
        private System.Object GetValue(System.Object target) { }
        private System.Object GetValueUnsafe(System.Object target) { }
        private System.Void SetValue(System.Object target, System.Object value) { }
        private System.Void SetValueUnsafe(System.Object target, System.Object value) { }
        private TField <Compile>b__5_0() { }
        private System.Void <Compile>b__5_1(TField value) { }

    }

    // TypeToken: 0x2000083
    public class StaticFunctionInvokerBase`1 : StaticInvokerBase
    {
        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }

    }

    // TypeToken: 0x2000084
    public class StaticFunctionInvoker`1 : StaticFunctionInvokerBase`1
    {
        // Fields
        private System.Func<TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private TResult <CreateDelegate>b__7_0() { }

    }

    // TypeToken: 0x2000085
    public class StaticFunctionInvoker`2 : StaticFunctionInvokerBase`1
    {
        // Fields
        private System.Func<TParam0,TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Object Invoke(System.Object target, System.Object arg0) { }
        private System.Object InvokeUnsafe(System.Object target, System.Object arg0) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private TResult <CreateDelegate>b__7_0(TParam0 param0) { }

    }

    // TypeToken: 0x2000086
    public class StaticFunctionInvoker`3 : StaticFunctionInvokerBase`1
    {
        // Fields
        private System.Func<TParam0,TParam1,TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1) { }

    }

    // TypeToken: 0x2000087
    public class StaticFunctionInvoker`4 : StaticFunctionInvokerBase`1
    {
        // Fields
        private System.Func<TParam0,TParam1,TParam2,TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2) { }

    }

    // TypeToken: 0x2000088
    public class StaticFunctionInvoker`5 : StaticFunctionInvokerBase`1
    {
        // Fields
        private System.Func<TParam0,TParam1,TParam2,TParam3,TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3) { }

    }

    // TypeToken: 0x2000089
    public class StaticFunctionInvoker`6 : StaticFunctionInvokerBase`1
    {
        // Fields
        private Unity.VisualScripting.Func<TParam0,TParam1,TParam2,TParam3,TParam4,TResult> invoke;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Type[] GetParameterTypes() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void CreateDelegate() { }
        private TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4) { }

    }

    // TypeToken: 0x200008A
    public class StaticInvokerBase : InvokerBase
    {
        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo methodInfo) { }
        private System.Void CompileExpression() { }
        private System.Void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions) { }
        private System.Void VerifyTarget(System.Object target) { }

    }

    // TypeToken: 0x200008B
    public class StaticPropertyAccessor`1, IOptimizedAccessor
    {
        // Fields
        private readonly System.Reflection.PropertyInfo propertyInfo;        // 0x0
        private System.Func<TProperty> getter;        // 0x0
        private System.Action<TProperty> setter;        // 0x0
        private System.Type targetType;        // 0x0

        // Methods
        private System.Void .ctor(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Void Compile() { }
        private System.Object GetValue(System.Object target) { }
        private System.Object GetValueUnsafe(System.Object target) { }
        private System.Void SetValue(System.Object target, System.Object value) { }
        private System.Void SetValueUnsafe(System.Object target, System.Object value) { }

    }

    // TypeToken: 0x200008C
    public class RenamedAssemblyAttribute : Attribute
    {
        // Fields
        private readonly System.String <previousName>k__BackingField;        // 0x10
        private readonly System.String <newName>k__BackingField;        // 0x18

        // Methods
        private System.String get_previousName() { }
        private System.String get_newName() { }

    }

    // TypeToken: 0x200008D
    public class RenamedFromAttribute : Attribute
    {
        // Fields
        private readonly System.String <previousName>k__BackingField;        // 0x10

        // Methods
        private System.String get_previousName() { }

    }

    // TypeToken: 0x200008E
    public class RenamedNamespaceAttribute : Attribute
    {
        // Fields
        private readonly System.String <previousName>k__BackingField;        // 0x10
        private readonly System.String <newName>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.String previousName, System.String newName) { }
        private System.String get_previousName() { }
        private System.String get_newName() { }

    }

    // TypeToken: 0x200008F
    public class RuntimeCodebase
    {
        // Fields
        private static readonly System.Object lock;        // 0x0
        private static readonly System.Collections.Generic.List<System.Type> _types;        // 0x8
        private static readonly System.Collections.Generic.List<System.Reflection.Assembly> _assemblies;        // 0x10
        public static System.Collections.Generic.HashSet<System.String> disallowedAssemblies;        // 0x18
        private static readonly System.Collections.Generic.Dictionary<System.String,System.Type> typeSerializations;        // 0x20
        private static System.Collections.Generic.Dictionary<System.String,System.Type> _renamedTypes;        // 0x28
        private static System.Collections.Generic.Dictionary<System.String,System.String> _renamedNamespaces;        // 0x30
        private static System.Collections.Generic.Dictionary<System.String,System.String> _renamedAssemblies;        // 0x38
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.String>> _renamedMembers;        // 0x40

        // Methods
        private System.Collections.Generic.IEnumerable<System.Type> get_types() { }
        private System.Collections.Generic.IEnumerable<System.Reflection.Assembly> get_assemblies() { }
        private System.Void .cctor() { }
        private System.Collections.Generic.IEnumerable<System.Attribute> GetAssemblyAttributes(System.Type attributeType) { }
        private System.Collections.Generic.IEnumerable<System.Attribute> GetAssemblyAttributes(System.Type attributeType, System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies) { }
        private System.Collections.Generic.IEnumerable<TAttribute> GetAssemblyAttributes() { }
        private System.String SerializeType(System.Type type) { }
        private System.Boolean TryDeserializeType(System.String typeName, System.Type& type) { }
        private System.Type DeserializeType(System.String typeName) { }
        private System.Boolean TryCachedTypeLookup(System.String typeName, System.Type& type) { }
        private System.Boolean TrySystemTypeLookup(System.String typeName, System.Type& type) { }
        private System.Boolean TrySystemTypeLookup(Unity.VisualScripting.TypeName typeName, System.Type& type) { }
        private System.Boolean TryRenamedTypeLookup(System.String previousTypeName, System.Type& type) { }
        private System.Collections.Generic.Dictionary<System.String,System.String> get_renamedNamespaces() { }
        private System.Collections.Generic.Dictionary<System.String,System.String> get_renamedAssemblies() { }
        private System.Collections.Generic.Dictionary<System.String,System.Type> get_renamedTypes() { }
        private System.Collections.Generic.Dictionary<System.String,System.String> FetchRenamedNamespaces() { }
        private System.Collections.Generic.Dictionary<System.String,System.String> FetchRenamedAssemblies() { }
        private System.Collections.Generic.Dictionary<System.String,System.Type> FetchRenamedTypes() { }

    }

    // TypeToken: 0x2000092
    public class TypeName
    {
        // Fields
        private System.String <AssemblyDescription>k__BackingField;        // 0x10
        private System.String <AssemblyName>k__BackingField;        // 0x18
        private System.String <AssemblyVersion>k__BackingField;        // 0x20
        private System.String <AssemblyCulture>k__BackingField;        // 0x28
        private System.String <AssemblyPublicKeyToken>k__BackingField;        // 0x30
        private readonly System.Collections.Generic.List<Unity.VisualScripting.TypeName> <GenericParameters>k__BackingField;        // 0x38
        private readonly System.Collections.Generic.List<System.String> names;        // 0x40
        private readonly System.Collections.Generic.List<System.Int32> genericarities;        // 0x48
        private System.String <Name>k__BackingField;        // 0x50

        // Methods
        private System.String get_AssemblyDescription() { }
        private System.Void set_AssemblyDescription(System.String value) { }
        private System.String get_AssemblyName() { }
        private System.Void set_AssemblyName(System.String value) { }
        private System.Void set_AssemblyVersion(System.String value) { }
        private System.Void set_AssemblyCulture(System.String value) { }
        private System.Void set_AssemblyPublicKeyToken(System.String value) { }
        private System.Collections.Generic.List<Unity.VisualScripting.TypeName> get_GenericParameters() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_IsArray() { }
        private Unity.VisualScripting.TypeName Parse(System.String s) { }
        private System.Void .ctor(System.String s, System.Int32& index) { }
        private System.String LookForPairThenRemove(System.Collections.Generic.List<System.String> strings, System.String Name) { }
        private System.Void ReplaceNamespace(System.String oldNamespace, System.String newNamespace) { }
        private System.Void ReplaceAssembly(System.String oldAssembly, System.String newAssembly) { }
        private System.Void ReplaceName(System.String oldTypeName, System.Type newType) { }
        private System.Void ReplaceName(System.String oldTypeName, System.String newTypeName, System.Reflection.AssemblyName newAssemblyName) { }
        private System.String ToElementTypeName(System.String s) { }
        private System.String ToArrayOrType(System.String oldType, System.String newType) { }
        private System.Void SetAssemblyName(System.Reflection.AssemblyName newAssemblyName) { }
        private System.Void UpdateName() { }
        private System.String ToString(Unity.VisualScripting.TypeNameDetail specification, Unity.VisualScripting.TypeNameDetail genericsSpecification) { }
        private System.String ToString() { }
        private System.String ToLooseString() { }

    }

    // TypeToken: 0x2000095
    public struct TypeNameDetail
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.VisualScripting.TypeNameDetail Name;        // 0x0
        public static Unity.VisualScripting.TypeNameDetail NameAndAssembly;        // 0x0
        public static Unity.VisualScripting.TypeNameDetail Full;        // 0x0

    }

    // TypeToken: 0x2000096
    public class TypeUtility
    {
        // Fields
        private static readonly System.Collections.Generic.HashSet<System.Type> _numericTypes;        // 0x0
        private static readonly System.Collections.Generic.HashSet<System.Type> _numericConstructTypes;        // 0x8
        private static readonly System.Collections.Generic.HashSet<System.Type> typesWithShortStrings;        // 0x10
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Object> defaultPrimitives;        // 0x18

        // Methods
        private System.Boolean IsBasic(System.Type type) { }
        private System.Boolean IsStatic(System.Type type) { }
        private System.Boolean IsNullable(System.Type type) { }
        private System.Boolean IsReferenceType(System.Type type) { }
        private System.Boolean IsAssignableFrom(System.Type type, System.Object value) { }
        private System.Collections.Generic.IEnumerable<System.Type> GetTypesSafely(System.Reflection.Assembly assembly) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000099
    public class LooseAssemblyNameConverter : fsDirectConverter
    {
        // Methods
        private System.Type get_ModelType() { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009A
    public class NamespaceConverter : fsDirectConverter
    {
        // Methods
        private System.Type get_ModelType() { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009B
    public class Ray2DConverter : fsDirectConverter`1
    {
        // Methods
        private Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.Ray2D model, System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> serialized) { }
        private Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, UnityEngine.Ray2D& model) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009C
    public class RayConverter : fsDirectConverter`1
    {
        // Methods
        private Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.Ray model, System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> serialized) { }
        private Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, UnityEngine.Ray& model) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009D
    public class UnityObjectConverter : fsConverter
    {
        // Methods
        private System.Collections.Generic.List<UnityEngine.Object> get_objectReferences() { }
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData storage, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009E
    public class DoNotSerializeAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009F
    public interface ISerializationDependency : ISerializationCallbackReceiver
    {
        // Methods
        private System.Boolean get_IsDeserialized() { }

    }

    // TypeToken: 0x20000A0
    public interface ISerializationDepender : ISerializationCallbackReceiver
    {
        // Methods
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies() { }
        private System.Void OnAfterDependenciesDeserialized() { }

    }

    // TypeToken: 0x20000A1
    public class Serialization
    {
        // Fields
        private static readonly System.Collections.Generic.HashSet<Unity.VisualScripting.SerializationOperation> freeOperations;        // 0x0
        private static readonly System.Collections.Generic.HashSet<Unity.VisualScripting.SerializationOperation> busyOperations;        // 0x8
        private static readonly System.Object lock;        // 0x10
        private static System.Boolean <isUnitySerializing>k__BackingField;        // 0x18
        private static readonly System.Collections.Generic.HashSet<Unity.VisualScripting.ISerializationDepender> awaitingDependers;        // 0x20

        // Methods
        private System.Void .cctor() { }
        private System.Boolean get_isUnitySerializing() { }
        private System.Void set_isUnitySerializing(System.Boolean value) { }
        private System.Boolean get_isCustomSerializing() { }
        private Unity.VisualScripting.SerializationOperation StartOperation() { }
        private System.Void EndOperation(Unity.VisualScripting.SerializationOperation operation) { }
        private Unity.VisualScripting.SerializationData Serialize(System.Object value, System.Boolean forceReflected) { }
        private System.Void DeserializeInto(Unity.VisualScripting.SerializationData data, System.Object& instance, System.Boolean forceReflected) { }
        private System.Object Deserialize(Unity.VisualScripting.SerializationData data, System.Boolean forceReflected) { }
        private System.String SerializeJson(Unity.VisualScripting.FullSerializer.fsSerializer serializer, System.Object instance, System.Boolean forceReflected) { }
        private Unity.VisualScripting.FullSerializer.fsResult DeserializeJsonUtil(Unity.VisualScripting.FullSerializer.fsSerializer serializer, System.String json, System.Object& instance, System.Boolean forceReflected) { }
        private System.Void DeserializeJson(Unity.VisualScripting.FullSerializer.fsSerializer serializer, System.String json, System.Object& instance, System.Boolean forceReflected) { }
        private System.Void HandleResult(System.String label, Unity.VisualScripting.FullSerializer.fsResult result, UnityEngine.Object context) { }
        private System.String PrettyPrint(System.String json) { }
        private System.Void AwaitDependencies(Unity.VisualScripting.ISerializationDepender depender) { }
        private System.Void CheckIfDependenciesMet(Unity.VisualScripting.ISerializationDepender depender) { }

    }

    // TypeToken: 0x20000A2
    public struct SerializationData
    {
        // Fields
        private System.String _json;        // 0x10
        private UnityEngine.Object[] _objectReferences;        // 0x18

        // Methods
        private System.String get_json() { }
        private UnityEngine.Object[] get_objectReferences() { }
        private System.Void .ctor(System.String json, System.Collections.Generic.IEnumerable<UnityEngine.Object> objectReferences) { }
        private System.Void .ctor(System.String json, UnityEngine.Object[] objectReferences) { }
        private System.Void Clear() { }
        private System.String ToString(System.String title) { }
        private System.String ToString() { }
        private System.Void ShowString(System.String title) { }

    }

    // TypeToken: 0x20000A3
    public class SerializationOperation
    {
        // Fields
        private Unity.VisualScripting.FullSerializer.fsSerializer <serializer>k__BackingField;        // 0x10
        private System.Collections.Generic.List<UnityEngine.Object> <objectReferences>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private Unity.VisualScripting.FullSerializer.fsSerializer get_serializer() { }
        private System.Void set_serializer(Unity.VisualScripting.FullSerializer.fsSerializer value) { }
        private System.Collections.Generic.List<UnityEngine.Object> get_objectReferences() { }
        private System.Void set_objectReferences(System.Collections.Generic.List<UnityEngine.Object> value) { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x20000A4
    public class SerializationVersionAttribute : fsObjectAttribute
    {
        // Methods
        private System.Void .ctor(System.String versionString, System.Type[] previousModels) { }

    }

    // TypeToken: 0x20000A5
    public class SerializeAsAttribute : fsPropertyAttribute
    {
        // Methods
        private System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x20000A6
    public class SerializeAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A7
    public interface ISingleton
    {
    }

    // TypeToken: 0x20000A8
    public class LudiqScriptableObject : ScriptableObject, ISerializationCallbackReceiver
    {
        // Fields
        protected Unity.VisualScripting.SerializationData _data;        // 0x18
        private System.Action OnDestroyActions;        // 0x28

        // Methods
        private System.Void add_OnDestroyActions(System.Action value) { }
        private System.Void remove_OnDestroyActions(System.Action value) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterSerialize() { }
        private System.Void OnBeforeDeserialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void OnPostDeserializeInEditor() { }
        private System.Void OnDestroy() { }
        private System.Void ShowData() { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A9
    public class Singleton`1
    {
        // Fields
        private static readonly Unity.VisualScripting.SingletonAttribute attribute;        // 0x0
        private static readonly System.Object _lock;        // 0x0
        private static readonly System.Collections.Generic.HashSet<T> awoken;        // 0x0
        private static T _instance;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Boolean get_persistent() { }
        private System.Boolean get_automatic() { }
        private System.String get_name() { }
        private UnityEngine.HideFlags get_hideFlags() { }
        private T get_instance() { }
        private T[] FindObjectsOfType() { }
        private T[] FindInstances() { }
        private T Instantiate() { }
        private System.Void Awake(T instance) { }
        private System.Void OnDestroy(T instance) { }

    }

    // TypeToken: 0x20000AA
    public class SingletonAttribute : Attribute
    {
        // Fields
        private System.Boolean <Persistent>k__BackingField;        // 0x10
        private System.Boolean <Automatic>k__BackingField;        // 0x11
        private UnityEngine.HideFlags <HideFlags>k__BackingField;        // 0x14
        private System.String <Name>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_Persistent() { }
        private System.Void set_Persistent(System.Boolean value) { }
        private System.Boolean get_Automatic() { }
        private System.Void set_Automatic(System.Boolean value) { }
        private UnityEngine.HideFlags get_HideFlags() { }
        private System.Void set_HideFlags(UnityEngine.HideFlags value) { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }

    }

    // TypeToken: 0x20000AB
    public class UnityThread
    {
        // Fields
        public static System.Threading.Thread thread;        // 0x0
        public static System.Collections.Concurrent.ConcurrentQueue<System.Action> pendingQueue;        // 0x8

        // Methods
        private System.Boolean get_allowsAPI() { }
        private System.Void RuntimeInitialize() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AC
    public class Empty`1
    {
        // Fields
        public static readonly T[] array;        // 0x0
        public static readonly System.Collections.Generic.List<T> list;        // 0x0
        public static readonly System.Collections.Generic.HashSet<T> hashSet;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AD
    public class HashUtility
    {
        // Methods
        private System.Int32 GetHashCode(T a) { }
        private System.Int32 GetHashCode(T1 a, T2 b) { }

    }

    // TypeToken: 0x20000AE
    public interface IIdentifiable
    {
        // Methods
        private System.Guid get_guid() { }

    }

    // TypeToken: 0x20000AF
    public class LinqUtility
    {
        // Methods
        private System.Collections.Generic.IEnumerable<T> Concat(System.Collections.IEnumerable[] enumerables) { }
        private System.Collections.Generic.IEnumerable<T> NotNull(System.Collections.Generic.IEnumerable<T> enumerable) { }

    }

    // TypeToken: 0x20000B2
    public class Recursion`1, IPoolable, IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.Stack<T> traversedOrder;        // 0x0
        private readonly System.Collections.Generic.Dictionary<T,System.Int32> traversedCount;        // 0x0
        private System.Boolean disposed;        // 0x0
        protected System.Int32 maxDepth;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Enter(T o) { }
        private System.Boolean TryEnter(T o) { }
        private System.Void Exit(T o) { }
        private System.Void Dispose() { }
        private System.Void Free() { }
        private System.Void Unity.VisualScripting.IPoolable.New() { }
        private System.Void Unity.VisualScripting.IPoolable.Free() { }
        private Unity.VisualScripting.Recursion<T> New() { }
        private Unity.VisualScripting.Recursion<T> New(System.Int32 maxDepth) { }

    }

    // TypeToken: 0x20000B4
    public class Recursion : Recursion`1
    {
        // Fields
        private static System.Int32 <defaultMaxDepth>k__BackingField;        // 0x0
        private static System.Boolean <safeMode>k__BackingField;        // 0x4

        // Methods
        private System.Int32 get_defaultMaxDepth() { }
        private System.Boolean get_safeMode() { }
        private System.Void set_safeMode(System.Boolean value) { }
        private System.Void OnRuntimeMethodLoad() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B5
    public class ReferenceCollector
    {
        // Fields
        private static System.Action onSceneUnloaded;        // 0x0

        // Methods
        private System.Void add_onSceneUnloaded(System.Action value) { }
        private System.Void remove_onSceneUnloaded(System.Action value) { }
        private System.Void Initialize() { }

    }

    // TypeToken: 0x20000B7
    public class ReferenceEqualityComparer, IEqualityComparer`1
    {
        // Fields
        public static readonly Unity.VisualScripting.ReferenceEqualityComparer Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Boolean System.Collections.Generic.IEqualityComparer<System.Object>.Equals(System.Object a, System.Object b) { }
        private System.Int32 System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(System.Object a) { }
        private System.Int32 GetHashCode(System.Object a) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B8
    public class ReferenceEqualityComparer`1, IEqualityComparer`1
    {
        // Fields
        public static readonly Unity.VisualScripting.ReferenceEqualityComparer<T> Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Boolean System.Collections.Generic.IEqualityComparer<T>.Equals(T a, T b) { }
        private System.Int32 System.Collections.Generic.IEqualityComparer<T>.GetHashCode(T a) { }
        private System.Int32 GetHashCode(T a) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B9
    public class RuntimeVSUsageUtility
    {
        // Methods
        private System.Void RuntimeInitializeOnLoadBeforeSceneLoad() { }

    }

    // TypeToken: 0x20000BA
    public class StringUtility
    {
        // Fields
        private static readonly System.Text.RegularExpressions.Regex guidRegex;        // 0x0

        // Methods
        private System.String TrimStart(System.String source, System.String value) { }
        private System.Void PartsAround(System.String s, System.Char c, System.String& before, System.String& after) { }
        private System.String ToHexString(System.Byte[] bytes) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BB
    public class UnityObjectUtility
    {
        // Methods
        private System.Boolean IsUnityNull(System.Object obj) { }
        private System.String ToSafeString(UnityEngine.Object uo) { }
        private T AsUnityNull(T obj) { }
        private System.Boolean TrulyEqual(UnityEngine.Object a, UnityEngine.Object b) { }

    }

    // TypeToken: 0x20000BC
    public class ApplicationVariables
    {
        // Fields
        private static Unity.VisualScripting.VariablesAsset _asset;        // 0x0
        private static Unity.VisualScripting.VariableDeclarations <runtime>k__BackingField;        // 0x8

        // Methods
        private Unity.VisualScripting.VariablesAsset get_asset() { }
        private System.Void Load() { }
        private System.Void set_runtime(Unity.VisualScripting.VariableDeclarations value) { }
        private System.Void OnEnterPlayMode() { }
        private System.Void OnExitPlayMode() { }
        private System.Void CreateRuntimeDeclarations() { }

    }

    // TypeToken: 0x20000BD
    public class InspectorVariableNameAttribute : Attribute
    {
        // Fields
        private Unity.VisualScripting.ActionDirection <direction>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(Unity.VisualScripting.ActionDirection direction) { }
        private System.Void set_direction(Unity.VisualScripting.ActionDirection value) { }

    }

    // TypeToken: 0x20000BE
    public class SavedVariables
    {
        // Fields
        private static Unity.VisualScripting.VariablesAsset _asset;        // 0x0
        private static Unity.VisualScripting.VariableDeclarations <saved>k__BackingField;        // 0x8
        private static Unity.VisualScripting.VariableDeclarations <merged>k__BackingField;        // 0x10

        // Methods
        private Unity.VisualScripting.VariablesAsset get_asset() { }
        private System.Void Load() { }
        private System.Void OnEnterPlayMode() { }
        private System.Void OnExitPlayMode() { }
        private Unity.VisualScripting.VariableDeclarations get_initial() { }
        private Unity.VisualScripting.VariableDeclarations get_saved() { }
        private System.Void set_saved(Unity.VisualScripting.VariableDeclarations value) { }
        private Unity.VisualScripting.VariableDeclarations get_merged() { }
        private System.Void set_merged(Unity.VisualScripting.VariableDeclarations value) { }
        private System.Void SaveDeclarations(Unity.VisualScripting.VariableDeclarations declarations) { }
        private System.Void FetchSavedDeclarations() { }
        private System.Void MergeInitialAndSavedDeclarations() { }
        private System.Void WarnAndNullifyUnityObjectReferences(Unity.VisualScripting.VariableDeclarations declarations) { }

    }

    // TypeToken: 0x20000C0
    public class VariableDeclaration
    {
        // Fields
        private System.String <name>k__BackingField;        // 0x10
        private System.Object <value>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.String name, System.Object value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Object get_value() { }
        private System.Void set_value(System.Object value) { }

    }

    // TypeToken: 0x20000C1
    public class VariableDeclarationCollection : KeyedCollection`2, IKeyedCollection`2, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Methods
        private System.String GetKeyForItem(Unity.VisualScripting.VariableDeclaration item) { }
        private System.Boolean TryGetValue(System.String key, Unity.VisualScripting.VariableDeclaration& value) { }
        private System.Void .ctor() { }
        private Unity.VisualScripting.VariableDeclaration Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.get_Item(System.String key) { }
        private System.Boolean Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.Contains(System.String key) { }

    }

    // TypeToken: 0x20000C2
    public class VariableDeclarations, IEnumerable`1, IEnumerable, ISpecifiesCloner
    {
        // Fields
        public Unity.VisualScripting.VariableKind Kind;        // 0x10
        private Unity.VisualScripting.VariableDeclarationCollection collection;        // 0x18
        private System.Action OnVariableChanged;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Object get_Item(System.String variable) { }
        private System.Void set_Item(System.String variable, System.Object value) { }
        private System.Void Set(System.String variable, System.Object value) { }
        private System.Object Get(System.String variable) { }
        private System.Void Clear() { }
        private System.Boolean IsDefined(System.String variable) { }
        private System.Collections.Generic.IEnumerator<Unity.VisualScripting.VariableDeclaration> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private Unity.VisualScripting.ICloner Unity.VisualScripting.ISpecifiesCloner.get_cloner() { }

    }

    // TypeToken: 0x20000C3
    public class VariableDeclarationsCloner : Cloner`1
    {
        // Fields
        public static readonly Unity.VisualScripting.VariableDeclarationsCloner instance;        // 0x0

        // Methods
        private System.Boolean Handles(System.Type type) { }
        private Unity.VisualScripting.VariableDeclarations ConstructClone(System.Type type, Unity.VisualScripting.VariableDeclarations original) { }
        private System.Void FillClone(System.Type type, Unity.VisualScripting.VariableDeclarations& clone, Unity.VisualScripting.VariableDeclarations original, Unity.VisualScripting.CloningContext context) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C4
    public struct VariableKind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.VisualScripting.VariableKind Flow;        // 0x0
        public static Unity.VisualScripting.VariableKind Graph;        // 0x0
        public static Unity.VisualScripting.VariableKind Object;        // 0x0
        public static Unity.VisualScripting.VariableKind Scene;        // 0x0
        public static Unity.VisualScripting.VariableKind Application;        // 0x0
        public static Unity.VisualScripting.VariableKind Saved;        // 0x0

    }

    // TypeToken: 0x20000C5
    public class VariablesAsset : LudiqScriptableObject
    {
        // Fields
        private Unity.VisualScripting.VariableDeclarations <declarations>k__BackingField;        // 0x30

        // Methods
        private Unity.VisualScripting.VariableDeclarations get_declarations() { }
        private System.Void set_declarations(Unity.VisualScripting.VariableDeclarations value) { }
        private System.Void ShowData() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C6
    public class VariablesSaver : MonoBehaviour, ISingleton
    {
        // Methods
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void OnApplicationQuit() { }
        private System.Void OnApplicationPause(System.Boolean isPaused) { }
        private Unity.VisualScripting.VariablesSaver get_instance() { }
        private System.Void Instantiate() { }
        private System.Void .ctor() { }

    }

}

namespace Unity.VisualScripting.FullSerializer
{

    // TypeToken: 0x20000C7
    public class fsArrayConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C8
    public class fsDateConverter : fsConverter
    {
        // Methods
        private System.String get_DateTimeFormatString() { }
        private System.Boolean CanProcess(System.Type type) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C9
    public class fsDictionaryConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance_, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance_, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult AddItemToDictionary(System.Collections.IDictionary dictionary, System.Object key, System.Object value) { }
        private System.Void GetKeyValueTypes(System.Type dictionaryType, System.Type& keyStorageType, System.Type& valueStorageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CA
    public class fsEnumConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Boolean ArrayContains(T[] values, T value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CD
    public class fsForwardAttribute : Attribute
    {
        // Fields
        public System.String MemberName;        // 0x10

    }

    // TypeToken: 0x20000CE
    public class fsForwardConverter : fsConverter
    {
        // Fields
        private System.String _memberName;        // 0x18

        // Methods
        private System.Void .ctor(Unity.VisualScripting.FullSerializer.fsForwardAttribute attribute) { }
        private System.Boolean CanProcess(System.Type type) { }
        private Unity.VisualScripting.FullSerializer.fsResult GetProperty(System.Object instance, Unity.VisualScripting.FullSerializer.fsMetaProperty& property) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }

    }

    // TypeToken: 0x20000CF
    public class fsGuidConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D0
    public class fsIEnumerableConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance_, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private System.Boolean IsStack(System.Type type) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance_, System.Type storageType) { }
        private System.Int32 HintSize(System.Collections.IEnumerable collection) { }
        private System.Type GetElementType(System.Type objectType) { }
        private System.Void TryClear(System.Type type, System.Object instance) { }
        private System.Reflection.MethodInfo GetAddMethod(System.Type type) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D1
    public class fsKeyValuePairConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D2
    public class fsNullableConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D3
    public class fsPrimitiveConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData storage, System.Object& instance, System.Type storageType) { }
        private System.Boolean UseBool(System.Type type) { }
        private System.Boolean UseInt64(System.Type type) { }
        private System.Boolean UseDouble(System.Type type) { }
        private System.Boolean UseString(System.Type type) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D4
    public class fsReflectedConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D5
    public class fsTypeConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type type) { }
        private System.Boolean RequestInheritanceSupport(System.Type type) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D6
    public class fsWeakReferenceConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7
    public class fsConverterRegistrar
    {
        // Fields
        public static System.Collections.Generic.List<System.Type> Converters;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D8
    public class fsAotCompilationManager
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type,System.String> _computedAotCompilations;        // 0x0
        private static System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsAotCompilationManager.AotCompilation> _uncomputedAotCompilations;        // 0x8

        // Methods
        private System.Void AddAotCompilation(System.Type type, Unity.VisualScripting.FullSerializer.fsMetaProperty[] members, System.Boolean isConstructorPublic) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000DA
    public class fsBaseConverter
    {
        // Fields
        public Unity.VisualScripting.FullSerializer.fsSerializer Serializer;        // 0x10

        // Methods
        private System.Object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult FailExpectedType(Unity.VisualScripting.FullSerializer.fsData data, Unity.VisualScripting.FullSerializer.fsDataType[] types) { }
        private Unity.VisualScripting.FullSerializer.fsResult CheckType(Unity.VisualScripting.FullSerializer.fsData data, Unity.VisualScripting.FullSerializer.fsDataType type) { }
        private Unity.VisualScripting.FullSerializer.fsResult CheckKey(Unity.VisualScripting.FullSerializer.fsData data, System.String key, Unity.VisualScripting.FullSerializer.fsData& subitem) { }
        private Unity.VisualScripting.FullSerializer.fsResult CheckKey(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, System.String key, Unity.VisualScripting.FullSerializer.fsData& subitem) { }
        private Unity.VisualScripting.FullSerializer.fsResult SerializeMember(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, System.Type overrideConverterType, System.String name, T value) { }
        private Unity.VisualScripting.FullSerializer.fsResult DeserializeMember(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, System.Type overrideConverterType, System.String name, T& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DC
    public class fsGlobalConfig
    {
        // Fields
        public static System.Boolean IsCaseSensitive;        // 0x0
        public static System.Boolean AllowInternalExceptions;        // 0x1
        public static System.String InternalFieldPrefix;        // 0x8

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000DD
    public class fsConfig
    {
        // Fields
        public System.Type[] SerializeAttributes;        // 0x10
        public System.Type[] IgnoreSerializeAttributes;        // 0x18
        public Unity.VisualScripting.FullSerializer.fsMemberSerialization DefaultMemberSerialization;        // 0x20
        public System.Func<System.String,System.Reflection.MemberInfo,System.String> GetJsonNameFromMemberName;        // 0x28
        public System.Boolean EnablePropertySerialization;        // 0x30
        public System.Boolean SerializeNonAutoProperties;        // 0x31
        public System.Boolean SerializeNonPublicSetProperties;        // 0x32
        public System.String CustomDateTimeFormatString;        // 0x38
        public System.Boolean Serialize64BitIntegerAsString;        // 0x40
        public System.Boolean SerializeEnumsAsInteger;        // 0x41

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DF
    public class fsContext
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Type,System.Object> _contextObjects;        // 0x10

        // Methods
        private System.Void Set(T obj) { }
        private T Get() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E0
    public class fsConverter : fsBaseConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E1
    public struct fsDataType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.VisualScripting.FullSerializer.fsDataType Array;        // 0x0
        public static Unity.VisualScripting.FullSerializer.fsDataType Object;        // 0x0
        public static Unity.VisualScripting.FullSerializer.fsDataType Double;        // 0x0
        public static Unity.VisualScripting.FullSerializer.fsDataType Int64;        // 0x0
        public static Unity.VisualScripting.FullSerializer.fsDataType Boolean;        // 0x0
        public static Unity.VisualScripting.FullSerializer.fsDataType String;        // 0x0
        public static Unity.VisualScripting.FullSerializer.fsDataType Null;        // 0x0

    }

    // TypeToken: 0x20000E2
    public class fsData
    {
        // Fields
        private System.Object _value;        // 0x10
        public static readonly Unity.VisualScripting.FullSerializer.fsData True;        // 0x0
        public static readonly Unity.VisualScripting.FullSerializer.fsData False;        // 0x8
        public static readonly Unity.VisualScripting.FullSerializer.fsData Null;        // 0x10

        // Methods
        private System.String ToString() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean boolean) { }
        private System.Void .ctor(System.Double f) { }
        private System.Void .ctor(System.Int64 i) { }
        private System.Void .ctor(System.String str) { }
        private System.Void .ctor(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> dict) { }
        private System.Void .ctor(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsData> list) { }
        private Unity.VisualScripting.FullSerializer.fsData CreateDictionary() { }
        private Unity.VisualScripting.FullSerializer.fsData CreateList(System.Int32 capacity) { }
        private System.Void BecomeDictionary() { }
        private Unity.VisualScripting.FullSerializer.fsData Clone() { }
        private Unity.VisualScripting.FullSerializer.fsDataType get_Type() { }
        private System.Boolean get_IsNull() { }
        private System.Boolean get_IsDouble() { }
        private System.Boolean get_IsInt64() { }
        private System.Boolean get_IsBool() { }
        private System.Boolean get_IsString() { }
        private System.Boolean get_IsDictionary() { }
        private System.Boolean get_IsList() { }
        private System.Double get_AsDouble() { }
        private System.Int64 get_AsInt64() { }
        private System.Boolean get_AsBool() { }
        private System.String get_AsString() { }
        private System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> get_AsDictionary() { }
        private System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsData> get_AsList() { }
        private T Cast() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(Unity.VisualScripting.FullSerializer.fsData other) { }
        private System.Boolean op_Equality(Unity.VisualScripting.FullSerializer.fsData a, Unity.VisualScripting.FullSerializer.fsData b) { }
        private System.Boolean op_Inequality(Unity.VisualScripting.FullSerializer.fsData a, Unity.VisualScripting.FullSerializer.fsData b) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E3
    public class fsDirectConverter : fsBaseConverter
    {
        // Methods
        private System.Type get_ModelType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E4
    public class fsDirectConverter`1 : fsDirectConverter
    {
        // Methods
        private System.Type get_ModelType() { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult DoSerialize(TModel model, System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> serialized) { }
        private Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,Unity.VisualScripting.FullSerializer.fsData> data, TModel& model) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E5
    public class fsMissingVersionConstructorException : Exception
    {
        // Methods
        private System.Void .ctor(System.Type versionedType, System.Type constructorType) { }

    }

    // TypeToken: 0x20000E6
    public class fsDuplicateVersionNameException : Exception
    {
        // Methods
        private System.Void .ctor(System.Type typeA, System.Type typeB, System.String version) { }

    }

    // TypeToken: 0x20000E7
    public class fsIgnoreAttribute : Attribute
    {
    }

    // TypeToken: 0x20000E8
    public interface fsISerializationCallbacks
    {
        // Methods
        private System.Void OnBeforeSerialize(System.Type storageType) { }
        private System.Void OnAfterSerialize(System.Type storageType, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Void OnBeforeDeserialize(System.Type storageType, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Void OnAfterDeserialize(System.Type storageType) { }

    }

    // TypeToken: 0x20000E9
    public class fsSerializationCallbackProcessor : fsObjectProcessor
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Void OnBeforeSerialize(System.Type storageType, System.Object instance) { }
        private System.Void OnAfterSerialize(System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Void OnAfterDeserialize(System.Type storageType, System.Object instance) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EA
    public class fsSerializationCallbackReceiverProcessor : fsObjectProcessor
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Void OnBeforeSerialize(System.Type storageType, System.Object instance) { }
        private System.Void OnAfterDeserialize(System.Type storageType, System.Object instance) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EB
    public class fsJsonParser
    {
        // Fields
        private readonly System.Text.StringBuilder _cachedStringBuilder;        // 0x10
        private System.Int32 _start;        // 0x18
        private System.String _input;        // 0x20

        // Methods
        private System.Void .ctor(System.String input) { }
        private Unity.VisualScripting.FullSerializer.fsResult MakeFailure(System.String message) { }
        private System.Boolean TryMoveNext() { }
        private System.Boolean HasValue() { }
        private System.Boolean HasValue(System.Int32 offset) { }
        private System.Char Character() { }
        private System.Char Character(System.Int32 offset) { }
        private System.Void SkipSpace() { }
        private Unity.VisualScripting.FullSerializer.fsResult TryParseExact(System.String content) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryParseTrue(Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryParseFalse(Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryParseNull(Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Boolean IsSeparator(System.Char c) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryParseNumber(Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryParseString(System.String& str) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryParseArray(Unity.VisualScripting.FullSerializer.fsData& arr) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryParseObject(Unity.VisualScripting.FullSerializer.fsData& obj) { }
        private Unity.VisualScripting.FullSerializer.fsResult RunParse(Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsResult Parse(System.String input, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsData Parse(System.String input) { }
        private System.Boolean IsHex(System.Char c) { }
        private System.UInt32 ParseSingleChar(System.Char c1, System.UInt32 multipliyer) { }
        private System.UInt32 ParseUnicode(System.Char c1, System.Char c2, System.Char c3, System.Char c4) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryUnescapeChar(System.Char& escaped) { }

    }

    // TypeToken: 0x20000EC
    public class fsJsonPrinter
    {
        // Methods
        private System.Void InsertSpacing(System.IO.TextWriter stream, System.Int32 count) { }
        private System.String EscapeString(System.String str) { }
        private System.Void BuildCompressedString(Unity.VisualScripting.FullSerializer.fsData data, System.IO.TextWriter stream) { }
        private System.Void BuildPrettyString(Unity.VisualScripting.FullSerializer.fsData data, System.IO.TextWriter stream, System.Int32 depth) { }
        private System.String PrettyJson(Unity.VisualScripting.FullSerializer.fsData data) { }
        private System.String CompressedJson(Unity.VisualScripting.FullSerializer.fsData data) { }
        private System.String ConvertDoubleToString(System.Double d) { }

    }

    // TypeToken: 0x20000ED
    public struct fsMemberSerialization
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.VisualScripting.FullSerializer.fsMemberSerialization OptIn;        // 0x0
        public static Unity.VisualScripting.FullSerializer.fsMemberSerialization OptOut;        // 0x0
        public static Unity.VisualScripting.FullSerializer.fsMemberSerialization Default;        // 0x0

    }

    // TypeToken: 0x20000EE
    public class fsObjectAttribute : Attribute
    {
        // Fields
        public System.Type[] PreviousModels;        // 0x10
        public System.String VersionString;        // 0x18
        public Unity.VisualScripting.FullSerializer.fsMemberSerialization MemberSerialization;        // 0x20
        public System.Type Converter;        // 0x28
        public System.Type Processor;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String versionString, System.Type[] previousModels) { }

    }

    // TypeToken: 0x20000EF
    public class fsObjectProcessor
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Void OnBeforeSerialize(System.Type storageType, System.Object instance) { }
        private System.Void OnAfterSerialize(System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Void OnBeforeDeserialize(System.Type storageType, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Void OnAfterDeserialize(System.Type storageType, System.Object instance) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F0
    public class fsPropertyAttribute : Attribute
    {
        // Fields
        public System.String Name;        // 0x10
        public System.Type Converter;        // 0x18

        // Methods
        private System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x20000F1
    public struct fsResult
    {
        // Fields
        private static readonly System.String[] EmptyStringArray;        // 0x0
        private System.Boolean _success;        // 0x10
        private System.Collections.Generic.List<System.String> _messages;        // 0x18
        public static Unity.VisualScripting.FullSerializer.fsResult Success;        // 0x8

        // Methods
        private System.Void AddMessage(System.String message) { }
        private System.Void AddMessages(Unity.VisualScripting.FullSerializer.fsResult result) { }
        private Unity.VisualScripting.FullSerializer.fsResult Merge(Unity.VisualScripting.FullSerializer.fsResult other) { }
        private Unity.VisualScripting.FullSerializer.fsResult Warn(System.String warning) { }
        private Unity.VisualScripting.FullSerializer.fsResult Fail(System.String warning) { }
        private Unity.VisualScripting.FullSerializer.fsResult op_Addition(Unity.VisualScripting.FullSerializer.fsResult a, Unity.VisualScripting.FullSerializer.fsResult b) { }
        private System.Boolean get_Failed() { }
        private System.Boolean get_Succeeded() { }
        private System.Boolean get_HasWarnings() { }
        private Unity.VisualScripting.FullSerializer.fsResult AssertSuccess() { }
        private System.Exception get_AsException() { }
        private System.Collections.Generic.IEnumerable<System.String> get_RawMessages() { }
        private System.String get_FormattedMessages() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000F2
    public class fsSerializer
    {
        // Fields
        private readonly System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsConverter> _availableConverters;        // 0x10
        private readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.FullSerializer.fsDirectConverter> _availableDirectConverters;        // 0x18
        private readonly System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> _processors;        // 0x20
        private readonly Unity.VisualScripting.FullSerializer.Internal.fsCyclicReferenceManager _references;        // 0x28
        private readonly Unity.VisualScripting.FullSerializer.fsSerializer.fsLazyCycleDefinitionWriter _lazyReferenceWriter;        // 0x30
        private readonly System.Collections.Generic.Dictionary<System.Type,System.Type> _abstractTypeRemap;        // 0x38
        private System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.FullSerializer.fsBaseConverter> _cachedConverterTypeInstances;        // 0x40
        private System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.FullSerializer.fsBaseConverter> _cachedConverters;        // 0x48
        private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor>> _cachedProcessors;        // 0x50
        public Unity.VisualScripting.FullSerializer.fsContext Context;        // 0x58
        public Unity.VisualScripting.FullSerializer.fsConfig Config;        // 0x60
        private static System.Collections.Generic.HashSet<System.String> _reservedKeywords;        // 0x0
        private static readonly System.String Key_ObjectReference;        // 0x8
        private static readonly System.String Key_ObjectDefinition;        // 0x10
        private static readonly System.String Key_InstanceType;        // 0x18
        private static readonly System.String Key_Version;        // 0x20
        private static readonly System.String Key_Content;        // 0x28
        private static readonly System.String Key_UnitDefault;        // 0x30
        private static readonly System.String Key_UnitPosition;        // 0x38
        private static readonly System.String Key_UnitGuid;        // 0x40
        private static readonly System.String Key_UnitFormerType;        // 0x48
        private static readonly System.String Key_UnitFormerValue;        // 0x50
        private static readonly System.String TypeName_Unit;        // 0x58
        private static readonly System.Type Type_Unit;        // 0x60
        private static readonly System.String TypeName_MissingType;        // 0x68
        private static readonly System.Type Type_MissingType;        // 0x70

        // Methods
        private System.Void .ctor() { }
        private System.Void RemapAbstractStorageTypeToDefaultType(System.Type& storageType) { }
        private System.Void SetDefaultStorageType(System.Type abstractType, System.Type defaultStorageType) { }
        private System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> GetProcessors(System.Type type) { }
        private System.Void AddConverter(Unity.VisualScripting.FullSerializer.fsBaseConverter converter) { }
        private Unity.VisualScripting.FullSerializer.fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(T instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, T& instance) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Type storageType, System.Type overrideConverterType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_1_ProcessCycles(System.Type storageType, System.Type overrideConverterType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_2_Inheritance(System.Type storageType, System.Type overrideConverterType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_3_ProcessVersioning(System.Type overrideConverterType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_4_Converter(System.Type overrideConverterType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, System.Object& result) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, System.Type overrideConverterType, System.Object& result) { }
        private Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_1_CycleReference(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, System.Object& result, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor>& processors) { }
        private Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_2_Version(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, System.Object& result, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor>& processors) { }
        private Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_3_Inheritance(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, System.Object& result, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor>& processors) { }
        private Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_4_Cycles(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type resultType, System.Object& result) { }
        private Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_5_Converter(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type resultType, System.Object& result) { }
        private System.Type GetDataType(Unity.VisualScripting.FullSerializer.fsData& data, System.Type defaultType, Unity.VisualScripting.FullSerializer.fsResult& deserializeResult) { }
        private System.Void EnsureDictionary(Unity.VisualScripting.FullSerializer.fsData data) { }
        private System.Void .cctor() { }
        private System.Boolean IsReservedKeyword(System.String key) { }
        private System.Boolean IsObjectReference(Unity.VisualScripting.FullSerializer.fsData data) { }
        private System.Boolean IsObjectDefinition(Unity.VisualScripting.FullSerializer.fsData data) { }
        private System.Boolean IsVersioned(Unity.VisualScripting.FullSerializer.fsData data) { }
        private System.Boolean IsTypeSpecified(Unity.VisualScripting.FullSerializer.fsData data) { }
        private System.Boolean IsWrappedData(Unity.VisualScripting.FullSerializer.fsData data) { }
        private System.Boolean IsVisualScriptingUnit(Unity.VisualScripting.FullSerializer.fsData data) { }
        private System.Void ConvertLegacyData(Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Void Invoke_OnBeforeSerialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance) { }
        private System.Void Invoke_OnAfterSerialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Void Invoke_OnBeforeDeserialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Void Invoke_OnBeforeDeserializeAfterInstanceCreation(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance, Unity.VisualScripting.FullSerializer.fsData& data) { }
        private System.Void Invoke_OnAfterDeserialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance) { }

    }

    // TypeToken: 0x20000F4
    public class fsMetaProperty
    {
        // Fields
        private System.Reflection.MemberInfo _memberInfo;        // 0x10
        private System.Type <StorageType>k__BackingField;        // 0x18
        private System.Type <OverrideConverterType>k__BackingField;        // 0x20
        private System.Boolean <CanRead>k__BackingField;        // 0x28
        private System.Boolean <CanWrite>k__BackingField;        // 0x29
        private System.String <JsonName>k__BackingField;        // 0x30
        private System.String <MemberName>k__BackingField;        // 0x38
        private System.Boolean <IsPublic>k__BackingField;        // 0x40
        private System.Boolean <IsReadOnly>k__BackingField;        // 0x41

        // Methods
        private System.Void .ctor(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.FieldInfo field) { }
        private System.Void .ctor(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.PropertyInfo property) { }
        private System.Type get_StorageType() { }
        private System.Void set_StorageType(System.Type value) { }
        private System.Type get_OverrideConverterType() { }
        private System.Void set_OverrideConverterType(System.Type value) { }
        private System.Boolean get_CanRead() { }
        private System.Void set_CanRead(System.Boolean value) { }
        private System.Boolean get_CanWrite() { }
        private System.Void set_CanWrite(System.Boolean value) { }
        private System.String get_JsonName() { }
        private System.Void set_JsonName(System.String value) { }
        private System.String get_MemberName() { }
        private System.Void set_MemberName(System.String value) { }
        private System.Boolean get_IsPublic() { }
        private System.Void set_IsPublic(System.Boolean value) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Void set_IsReadOnly(System.Boolean value) { }
        private System.Void CommonInitialize(Unity.VisualScripting.FullSerializer.fsConfig config) { }
        private System.Void Write(System.Object context, System.Object value) { }
        private System.Object Read(System.Object context) { }

    }

    // TypeToken: 0x20000F5
    public class fsMetaType
    {
        // Fields
        public System.Type ReflectedType;        // 0x10
        private System.Boolean _hasEmittedAotData;        // 0x18
        private System.Nullable<System.Boolean> _hasDefaultConstructorCache;        // 0x19
        private System.Boolean _isDefaultConstructorPublic;        // 0x1B
        private Unity.VisualScripting.FullSerializer.fsMetaProperty[] <Properties>k__BackingField;        // 0x20
        private static System.Collections.Generic.Dictionary<Unity.VisualScripting.FullSerializer.fsConfig,System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.FullSerializer.fsMetaType>> _configMetaTypes;        // 0x0

        // Methods
        private System.Void .ctor(Unity.VisualScripting.FullSerializer.fsConfig config, System.Type reflectedType) { }
        private Unity.VisualScripting.FullSerializer.fsMetaProperty[] get_Properties() { }
        private System.Void set_Properties(Unity.VisualScripting.FullSerializer.fsMetaProperty[] value) { }
        private System.Boolean get_HasDefaultConstructor() { }
        private System.Boolean EmitAotData() { }
        private System.Object CreateInstance() { }
        private Unity.VisualScripting.FullSerializer.fsMetaType Get(Unity.VisualScripting.FullSerializer.fsConfig config, System.Type type) { }
        private System.Void CollectProperties(Unity.VisualScripting.FullSerializer.fsConfig config, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsMetaProperty> properties, System.Type reflectedType) { }
        private System.Boolean IsAutoProperty(System.Reflection.PropertyInfo property, System.Reflection.MemberInfo[] members) { }
        private System.Boolean CanSerializeProperty(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.PropertyInfo property, System.Reflection.MemberInfo[] members, System.Boolean annotationFreeValue) { }
        private System.Boolean CanSerializeField(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.FieldInfo field, System.Boolean annotationFreeValue) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000F9
    public class fsReflectionUtility
    {
        // Methods
        private System.Type GetInterface(System.Type type, System.Type interfaceType) { }

    }

}

namespace Unity.VisualScripting.FullSerializer.Internal
{

    // TypeToken: 0x20000FA
    public class fsCyclicReferenceManager
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Object,System.Int32> _objectIds;        // 0x10
        private System.Int32 _nextId;        // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,System.Object> _marked;        // 0x20
        private System.Int32 _depth;        // 0x28

        // Methods
        private System.Void Enter() { }
        private System.Boolean Exit() { }
        private System.Object GetReferenceObject(System.Int32 id) { }
        private System.Void AddReferenceWithId(System.Int32 id, System.Object reference) { }
        private System.Int32 GetReferenceId(System.Object item) { }
        private System.Boolean IsReference(System.Object item) { }
        private System.Void MarkSerialized(System.Object item) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FC
    public struct fsOption`1
    {
        // Fields
        private System.Boolean _hasValue;        // 0x0
        private T _value;        // 0x0

        // Methods
        private System.Boolean get_HasValue() { }
        private System.Boolean get_IsEmpty() { }
        private T get_Value() { }
        private System.Void .ctor(T value) { }

    }

    // TypeToken: 0x20000FD
    public class fsOption
    {
        // Methods
        private Unity.VisualScripting.FullSerializer.Internal.fsOption<T> Just(T value) { }

    }

    // TypeToken: 0x20000FE
    public class fsPortableReflection
    {
        // Fields
        public static System.Type[] EmptyTypes;        // 0x0
        private static System.Collections.Generic.IDictionary<Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery,System.Attribute> _cachedAttributeQueries;        // 0x8
        private static System.Reflection.BindingFlags DeclaredFlags;        // 0x10

        // Methods
        private System.Boolean HasAttribute(System.Reflection.MemberInfo element, System.Type attributeType) { }
        private System.Boolean HasAttribute(System.Reflection.MemberInfo element, System.Type attributeType, System.Boolean shouldCache) { }
        private System.Attribute GetAttribute(System.Reflection.MemberInfo element, System.Type attributeType, System.Boolean shouldCache) { }
        private TAttribute GetAttribute(System.Reflection.MemberInfo element, System.Boolean shouldCache) { }
        private TAttribute GetAttribute(System.Reflection.MemberInfo element) { }
        private System.Reflection.PropertyInfo GetDeclaredProperty(System.Type type, System.String propertyName) { }
        private System.Reflection.MethodInfo GetDeclaredMethod(System.Type type, System.String methodName) { }
        private System.Reflection.ConstructorInfo GetDeclaredConstructor(System.Type type, System.Type[] parameters) { }
        private System.Reflection.ConstructorInfo[] GetDeclaredConstructors(System.Type type) { }
        private System.Reflection.MethodInfo GetFlattenedMethod(System.Type type, System.String methodName) { }
        private System.Reflection.MethodInfo[] GetDeclaredMethods(System.Type type) { }
        private System.Reflection.PropertyInfo[] GetDeclaredProperties(System.Type type) { }
        private System.Reflection.FieldInfo[] GetDeclaredFields(System.Type type) { }
        private System.Reflection.MemberInfo[] GetDeclaredMembers(System.Type type) { }
        private System.Type Resolve(System.Type type) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000101
    public class fsTypeExtensions
    {
        // Methods
        private System.String CSharpName(System.Type type) { }
        private System.String CSharpName(System.Type type, System.Boolean includeNamespace) { }

    }

    // TypeToken: 0x2000103
    public struct fsVersionedType
    {
        // Fields
        public Unity.VisualScripting.FullSerializer.Internal.fsVersionedType[] Ancestors;        // 0x10
        public System.String VersionString;        // 0x18
        public System.Type ModelType;        // 0x20

        // Methods
        private System.Object Migrate(System.Object ancestorInstance) { }
        private System.String ToString() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000104
    public class fsVersionManager
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.Type,Unity.VisualScripting.FullSerializer.Internal.fsOption<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType>> _cache;        // 0x0

        // Methods
        private Unity.VisualScripting.FullSerializer.fsResult GetVersionImportPath(System.String currentVersion, Unity.VisualScripting.FullSerializer.Internal.fsVersionedType targetVersion, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType>& path) { }
        private System.Boolean GetVersionImportPathRecursive(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType> path, System.String currentVersion, Unity.VisualScripting.FullSerializer.Internal.fsVersionedType current) { }
        private Unity.VisualScripting.FullSerializer.Internal.fsOption<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType> GetVersionedType(System.Type type) { }
        private System.Void VerifyConstructors(Unity.VisualScripting.FullSerializer.Internal.fsVersionedType type) { }
        private System.Void VerifyUniqueVersionStrings(Unity.VisualScripting.FullSerializer.Internal.fsVersionedType type) { }
        private System.Void .cctor() { }

    }

}

