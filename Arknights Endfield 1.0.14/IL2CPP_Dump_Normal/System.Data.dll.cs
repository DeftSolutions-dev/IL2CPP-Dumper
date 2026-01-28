// ========================================================
// Dumped by @desirepro
// Assembly: System.Data.dll
// Classes:  230
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class SR
    {
        // Methods
        private System.String GetString(System.String name) { }
        private System.String Format(System.String resourceFormat, System.Object p1) { }
        private System.String Format(System.String resourceFormat, System.Object p1, System.Object p2) { }
        private System.String Format(System.String resourceFormat, System.Object p1, System.Object p2, System.Object p3) { }

    }

    // TypeToken: 0x2000018
    public struct ColumnError
    {
        // Fields
        private System.Data.DataColumn _column;        // 0x10
        private System.String _error;        // 0x18

    }

    // TypeToken: 0x2000027
    public class DataTableRelationCollection : DataRelationCollection
    {
        // Fields
        private readonly System.Data.DataTable _table;        // 0x38
        private readonly System.Collections.ArrayList _relations;        // 0x40
        private readonly System.Boolean _fParentCollection;        // 0x48
        private System.ComponentModel.CollectionChangeEventHandler RelationPropertyChanged;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.Boolean fParentCollection) { }
        private System.Collections.ArrayList get_List() { }
        private System.Void EnsureDataSet() { }
        private System.Data.DataSet GetDataSet() { }
        private System.Data.DataRelation get_Item(System.Int32 index) { }
        private System.Data.DataRelation get_Item(System.String name) { }
        private System.Void add_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value) { }
        private System.Void remove_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value) { }
        private System.Void AddCache(System.Data.DataRelation relation) { }
        private System.Void AddCore(System.Data.DataRelation relation) { }
        private System.Void RemoveCache(System.Data.DataRelation relation) { }
        private System.Void RemoveCore(System.Data.DataRelation relation) { }

    }

    // TypeToken: 0x2000028
    public class DataSetRelationCollection : DataRelationCollection
    {
        // Fields
        private readonly System.Data.DataSet _dataSet;        // 0x38
        private readonly System.Collections.ArrayList _relations;        // 0x40
        private System.Data.DataRelation[] _delayLoadingRelations;        // 0x48

        // Methods
        private System.Void .ctor(System.Data.DataSet dataSet) { }
        private System.Collections.ArrayList get_List() { }
        private System.Void Clear() { }
        private System.Data.DataSet GetDataSet() { }
        private System.Data.DataRelation get_Item(System.Int32 index) { }
        private System.Data.DataRelation get_Item(System.String name) { }
        private System.Void AddCore(System.Data.DataRelation relation) { }
        private System.Void RemoveCore(System.Data.DataRelation relation) { }

    }

    // TypeToken: 0x2000030
    public class DataRowTree : RBTree`1
    {
        // Methods
        private System.Void .ctor() { }
        private System.Int32 CompareNode(System.Data.DataRow record1, System.Data.DataRow record2) { }
        private System.Int32 CompareSateliteTreeNode(System.Data.DataRow record1, System.Data.DataRow record2) { }

    }

    // TypeToken: 0x200003A
    public struct RowDiffIdUsageSection
    {
        // Fields
        private System.Data.DataTable _targetTable;        // 0x10

        // Methods
        private System.Void Prepare(System.Data.DataTable table) { }

    }

    // TypeToken: 0x200003B
    public struct DSRowDiffIdUsageSection
    {
        // Fields
        private System.Data.DataSet _targetDS;        // 0x10

        // Methods
        private System.Void Prepare(System.Data.DataSet ds) { }

    }

    // TypeToken: 0x2000043
    public class DataRowReferenceComparer, IEqualityComparer`1
    {
        // Fields
        private static readonly System.Data.DataView.DataRowReferenceComparer s_default;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Boolean Equals(System.Data.DataRow x, System.Data.DataRow y) { }
        private System.Int32 GetHashCode(System.Data.DataRow obj) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004D
    public struct DataTypePrecedence
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.BinaryNode.DataTypePrecedence SqlDateTime;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence DateTimeOffset;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence DateTime;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence TimeSpan;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlDouble;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence Double;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlSingle;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence Single;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlDecimal;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence Decimal;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlMoney;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence UInt64;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlInt64;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence Int64;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence UInt32;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlInt32;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence Int32;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence UInt16;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlInt16;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence Int16;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence Byte;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlByte;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SByte;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence Error;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlBoolean;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence Boolean;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlGuid;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlString;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence String;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlXml;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlChars;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence Char;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlBytes;        // 0x0
        public static System.Data.BinaryNode.DataTypePrecedence SqlBinary;        // 0x0

    }

    // TypeToken: 0x2000055
    public struct ReservedWords
    {
        // Fields
        private readonly System.String _word;        // 0x10
        private readonly System.Data.Tokens _token;        // 0x18
        private readonly System.Int32 _op;        // 0x1C

        // Methods
        private System.Void .ctor(System.String word, System.Data.Tokens token, System.Int32 op) { }

    }

    // TypeToken: 0x2000071
    public struct NodeColor
    {
        // Fields
        public System.Int32 value__;        // 0x0
        public static System.Data.RBTree.NodeColor<K> red;        // 0x0
        public static System.Data.RBTree.NodeColor<K> black;        // 0x0

    }

    // TypeToken: 0x2000072
    public struct Node
    {
        // Fields
        private System.Int32 _selfId;        // 0x0
        private System.Int32 _leftId;        // 0x0
        private System.Int32 _rightId;        // 0x0
        private System.Int32 _parentId;        // 0x0
        private System.Int32 _nextId;        // 0x0
        private System.Int32 _subTreeSize;        // 0x0
        private K _keyOfNode;        // 0x0
        private System.Data.RBTree.NodeColor<K> _nodeColor;        // 0x0

    }

    // TypeToken: 0x2000073
    public struct NodePath
    {
        // Fields
        private readonly System.Int32 _nodeID;        // 0x0
        private readonly System.Int32 _mainTreeNodeID;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 nodeID, System.Int32 mainTreeNodeID) { }

    }

    // TypeToken: 0x2000074
    public class TreePage
    {
        // Fields
        private readonly System.Data.RBTree.Node<K>[] _slots;        // 0x0
        private readonly System.Int32[] _slotMap;        // 0x0
        private System.Int32 _inUseCount;        // 0x0
        private System.Int32 _pageId;        // 0x0
        private System.Int32 _nextFreeSlotLine;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 size) { }
        private System.Int32 AllocSlot(System.Data.RBTree<K> tree) { }
        private System.Int32 get_InUseCount() { }
        private System.Void set_InUseCount(System.Int32 value) { }
        private System.Int32 get_PageId() { }
        private System.Void set_PageId(System.Int32 value) { }

    }

    // TypeToken: 0x2000075
    public struct RBTreeEnumerator, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private readonly System.Data.RBTree<K> _tree;        // 0x0
        private readonly System.Int32 _version;        // 0x0
        private System.Int32 _index;        // 0x0
        private System.Int32 _mainTreeNodeId;        // 0x0
        private K _current;        // 0x0

        // Methods
        private System.Void .ctor(System.Data.RBTree<K> tree) { }
        private System.Void .ctor(System.Data.RBTree<K> tree, System.Int32 position) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private K get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200007C
    public class ColumnInfo
    {
        // Fields
        public System.Boolean flag;        // 0x10
        public System.Boolean equalsOperator;        // 0x11
        public System.Data.BinaryNode expr;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007F
    public class IndexTree : RBTree`1
    {
        // Fields
        private readonly System.Data.Index _index;        // 0x40

        // Methods
        private System.Void .ctor(System.Data.Index index) { }
        private System.Int32 CompareNode(System.Int32 record1, System.Int32 record2) { }
        private System.Int32 CompareSateliteTreeNode(System.Int32 record1, System.Int32 record2) { }

    }

    // TypeToken: 0x2000083
    public class Action`4 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

    }

    // TypeToken: 0x2000084
    public class Func`2 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 arg1) { }

    }

    // TypeToken: 0x2000088
    public class NameType, IComparable
    {
        // Fields
        public System.String name;        // 0x10
        public System.Type type;        // 0x18

        // Methods
        private System.Void .ctor(System.String n, System.Type t) { }
        private System.Int32 CompareTo(System.Object obj) { }

    }

    // TypeToken: 0x200008D
    public class NameType, IComparable
    {
        // Fields
        public readonly System.String name;        // 0x10
        public readonly System.Type type;        // 0x18

        // Methods
        private System.Void .ctor(System.String n, System.Type t) { }
        private System.Int32 CompareTo(System.Object obj) { }

    }

    // TypeToken: 0x2000092
    public class XmlNodeIdentety
    {
        // Fields
        public System.String LocalName;        // 0x10
        public System.String NamespaceURI;        // 0x18

        // Methods
        private System.Void .ctor(System.String localName, System.String namespaceURI) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }

    }

    // TypeToken: 0x2000093
    public class XmlNodeIdHashtable : Hashtable
    {
        // Fields
        private System.Data.XmlToDatasetMap.XmlNodeIdentety _id;        // 0x50

        // Methods
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Object get_Item(System.Xml.XmlNode node) { }
        private System.Object get_Item(System.Xml.XmlReader dataReader) { }
        private System.Object get_Item(System.Data.DataTable table) { }
        private System.Object get_Item(System.String name) { }

    }

    // TypeToken: 0x2000094
    public class TableSchemaInfo
    {
        // Fields
        public System.Data.DataTable TableSchema;        // 0x10
        public System.Data.XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap;        // 0x18

        // Methods
        private System.Void .ctor(System.Data.DataTable tableSchema) { }

    }

    // TypeToken: 0x20000C5
    public struct Families
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.Common.ObjectStorage.Families DATETIME;        // 0x0
        public static System.Data.Common.ObjectStorage.Families NUMBER;        // 0x0
        public static System.Data.Common.ObjectStorage.Families STRING;        // 0x0
        public static System.Data.Common.ObjectStorage.Families BOOLEAN;        // 0x0
        public static System.Data.Common.ObjectStorage.Families ARRAY;        // 0x0

    }

    // TypeToken: 0x20000C6
    public class TempAssemblyComparer, IEqualityComparer`1
    {
        // Fields
        private static readonly System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute>> s_default;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Boolean Equals(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> y) { }
        private System.Int32 GetHashCode(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> obj) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E1
    public struct __StaticArrayInitTypeSize=36
    {
    }

    // TypeToken: 0x20000E2
    public struct __StaticArrayInitTypeSize=38
    {
    }

    // TypeToken: 0x20000E3
    public struct __StaticArrayInitTypeSize=52
    {
    }

    // TypeToken: 0x20000E4
    public struct __StaticArrayInitTypeSize=64
    {
    }

    // TypeToken: 0x20000E5
    public struct __StaticArrayInitTypeSize=152
    {
    }

    // TypeToken: 0x20000E6
    public struct __StaticArrayInitTypeSize=176
    {
    }

namespace System.Data
{

    // TypeToken: 0x2000003
    public struct AcceptRejectRule
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.AcceptRejectRule None;        // 0x0
        public static System.Data.AcceptRejectRule Cascade;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct AggregateType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.AggregateType None;        // 0x0
        public static System.Data.AggregateType Sum;        // 0x0
        public static System.Data.AggregateType Mean;        // 0x0
        public static System.Data.AggregateType Min;        // 0x0
        public static System.Data.AggregateType Max;        // 0x0
        public static System.Data.AggregateType First;        // 0x0
        public static System.Data.AggregateType Count;        // 0x0
        public static System.Data.AggregateType Var;        // 0x0
        public static System.Data.AggregateType StDev;        // 0x0

    }

    // TypeToken: 0x2000005
    public class InternalDataCollectionBase, ICollection, IEnumerable
    {
        // Fields
        private static readonly System.ComponentModel.CollectionChangeEventArgs s_refreshEventArgs;        // 0x0

        // Methods
        private System.Int32 get_Count() { }
        private System.Void CopyTo(System.Array ar, System.Int32 index) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Boolean get_IsSynchronized() { }
        private System.Int32 NamesEqual(System.String s1, System.String s2, System.Boolean fCaseSensitive, System.Globalization.CultureInfo locale) { }
        private System.Object get_SyncRoot() { }
        private System.Collections.ArrayList get_List() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000006
    public class ColumnTypeConverter : TypeConverter
    {
        // Fields
        private static readonly System.Type[] s_types;        // 0x0
        private System.ComponentModel.TypeConverter.StandardValuesCollection _values;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }
        private System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000007
    public class DataCommonEventSource : EventSource
    {
        // Fields
        private static readonly System.Data.DataCommonEventSource Log;        // 0x0
        private static System.Int64 s_nextScopeId;        // 0x8

        // Methods
        private System.Void Trace(System.String message) { }
        private System.Void Trace(System.String format, T0 arg0) { }
        private System.Void Trace(System.String format, T0 arg0, T1 arg1) { }
        private System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2) { }
        private System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
        private System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        private System.Int64 EnterScope(System.String message) { }
        private System.Int64 EnterScope(System.String format, T1 arg1) { }
        private System.Int64 EnterScope(System.String format, T1 arg1, T2 arg2) { }
        private System.Int64 EnterScope(System.String format, T1 arg1, T2 arg2, T3 arg3) { }
        private System.Int64 EnterScope(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.Void ExitScope(System.Int64 scopeId) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000008
    public class Constraint
    {
        // Fields
        private System.String _schemaName;        // 0x10
        private System.Boolean _inCollection;        // 0x18
        private System.Data.DataSet _dataSet;        // 0x20
        private System.String _name;        // 0x28
        private System.Data.PropertyCollection _extendedProperties;        // 0x30

        // Methods
        private System.String get_ConstraintName() { }
        private System.Void set_ConstraintName(System.String value) { }
        private System.String get_SchemaName() { }
        private System.Void set_SchemaName(System.String value) { }
        private System.Boolean get_InCollection() { }
        private System.Void set_InCollection(System.Boolean value) { }
        private System.Data.DataTable get_Table() { }
        private System.Data.PropertyCollection get_ExtendedProperties() { }
        private System.Boolean ContainsColumn(System.Data.DataColumn column) { }
        private System.Boolean CanEnableConstraint() { }
        private System.Data.Constraint Clone(System.Data.DataSet destination) { }
        private System.Data.Constraint Clone(System.Data.DataSet destination, System.Boolean ignoreNSforTableLookup) { }
        private System.Void CheckConstraint() { }
        private System.Void CheckCanAddToCollection(System.Data.ConstraintCollection constraint) { }
        private System.Boolean CanBeRemovedFromCollection(System.Data.ConstraintCollection constraint, System.Boolean fThrowException) { }
        private System.Void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action) { }
        private System.Void CheckState() { }
        private System.Void CheckStateForProperty() { }
        private System.Data.DataSet get__DataSet() { }
        private System.Boolean IsConstraintViolated() { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class ConstraintCollection : InternalDataCollectionBase
    {
        // Fields
        private readonly System.Data.DataTable _table;        // 0x10
        private readonly System.Collections.ArrayList _list;        // 0x18
        private System.Int32 _defaultNameIndex;        // 0x20
        private System.ComponentModel.CollectionChangeEventHandler _onCollectionChanged;        // 0x28
        private System.Data.Constraint[] _delayLoadingConstraints;        // 0x30
        private System.Boolean _fLoadForeignKeyConstraintsOnly;        // 0x38

        // Methods
        private System.Void .ctor(System.Data.DataTable table) { }
        private System.Collections.ArrayList get_List() { }
        private System.Data.Constraint get_Item(System.Int32 index) { }
        private System.Data.DataTable get_Table() { }
        private System.Data.Constraint get_Item(System.String name) { }
        private System.Void Add(System.Data.Constraint constraint) { }
        private System.Void Add(System.Data.Constraint constraint, System.Boolean addUniqueWhenAddingForeign) { }
        private System.Data.Constraint Add(System.String name, System.Data.DataColumn[] columns, System.Boolean primaryKey) { }
        private System.Void AddUniqueConstraint(System.Data.UniqueConstraint constraint) { }
        private System.Void AddForeignKeyConstraint(System.Data.ForeignKeyConstraint constraint) { }
        private System.Boolean AutoGenerated(System.Data.Constraint constraint) { }
        private System.Void ArrayAdd(System.Data.Constraint constraint) { }
        private System.Void ArrayRemove(System.Data.Constraint constraint) { }
        private System.String AssignName() { }
        private System.Void BaseAdd(System.Data.Constraint constraint) { }
        private System.Void BaseGroupSwitch(System.Data.Constraint[] oldArray, System.Int32 oldLength, System.Data.Constraint[] newArray, System.Int32 newLength) { }
        private System.Void BaseRemove(System.Data.Constraint constraint) { }
        private System.Boolean CanRemove(System.Data.Constraint constraint, System.Boolean fThrowException) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.String name) { }
        private System.Boolean Contains(System.String name, System.Boolean caseSensitive) { }
        private System.Data.Constraint FindConstraint(System.Data.Constraint constraint) { }
        private System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn[] columns) { }
        private System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn column) { }
        private System.Data.ForeignKeyConstraint FindForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
        private System.Boolean CompareArrays(System.Data.DataColumn[] a1, System.Data.DataColumn[] a2) { }
        private System.Int32 InternalIndexOf(System.String constraintName) { }
        private System.String MakeName(System.Int32 index) { }
        private System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        private System.Void RegisterName(System.String name) { }
        private System.Void Remove(System.Data.Constraint constraint) { }
        private System.Void UnregisterName(System.String name) { }

    }

    // TypeToken: 0x200000A
    public class ConstraintConverter : ExpandableObjectConverter
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }

    }

    // TypeToken: 0x200000B
    public class ConstraintEnumerator
    {
        // Fields
        private System.Collections.IEnumerator _tables;        // 0x10
        private System.Collections.IEnumerator _constraints;        // 0x18
        private System.Data.Constraint _currentObject;        // 0x20

        // Methods
        private System.Void .ctor(System.Data.DataSet dataSet) { }
        private System.Boolean GetNext() { }
        private System.Data.Constraint GetConstraint() { }
        private System.Boolean IsValidCandidate(System.Data.Constraint constraint) { }
        private System.Data.Constraint get_CurrentObject() { }

    }

    // TypeToken: 0x200000C
    public class ForeignKeyConstraintEnumerator : ConstraintEnumerator
    {
        // Methods
        private System.Void .ctor(System.Data.DataSet dataSet) { }
        private System.Boolean IsValidCandidate(System.Data.Constraint constraint) { }
        private System.Data.ForeignKeyConstraint GetForeignKeyConstraint() { }

    }

    // TypeToken: 0x200000D
    public class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
    {
        // Fields
        private readonly System.Data.DataTable _table;        // 0x28

        // Methods
        private System.Void .ctor(System.Data.DataSet dataSet, System.Data.DataTable inTable) { }
        private System.Boolean IsValidCandidate(System.Data.Constraint constraint) { }

    }

    // TypeToken: 0x200000E
    public class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
    {
        // Fields
        private readonly System.Data.DataTable _table;        // 0x28

        // Methods
        private System.Void .ctor(System.Data.DataSet dataSet, System.Data.DataTable inTable) { }
        private System.Boolean IsValidCandidate(System.Data.Constraint constraint) { }

    }

    // TypeToken: 0x200000F
    public class DataColumn : MarshalByValueComponent
    {
        // Fields
        private System.Boolean _allowNull;        // 0x20
        private System.String _caption;        // 0x28
        private System.String _columnName;        // 0x30
        private System.Type _dataType;        // 0x38
        private System.Data.Common.StorageType _storageType;        // 0x40
        private System.Object _defaultValue;        // 0x48
        private System.Data.DataSetDateTime _dateTimeMode;        // 0x50
        private System.Data.DataExpression _expression;        // 0x58
        private System.Int32 _maxLength;        // 0x60
        private System.Int32 _ordinal;        // 0x64
        private System.Boolean _readOnly;        // 0x68
        private System.Data.Index _sortIndex;        // 0x70
        private System.Data.DataTable _table;        // 0x78
        private System.Boolean _unique;        // 0x80
        private System.Data.MappingType _columnMapping;        // 0x84
        private System.Int32 _hashCode;        // 0x88
        private System.Int32 _errors;        // 0x8C
        private System.Boolean _isSqlType;        // 0x90
        private System.Boolean _implementsINullable;        // 0x91
        private System.Boolean _implementsIChangeTracking;        // 0x92
        private System.Boolean _implementsIRevertibleChangeTracking;        // 0x93
        private System.Boolean _implementsIXMLSerializable;        // 0x94
        private System.Boolean _defaultValueIsNull;        // 0x95
        private System.Collections.Generic.List<System.Data.DataColumn> _dependentColumns;        // 0x98
        private System.Data.PropertyCollection _extendedProperties;        // 0xA0
        private System.Data.Common.DataStorage _storage;        // 0xA8
        private System.Data.AutoIncrementValue _autoInc;        // 0xB0
        private System.String _columnUri;        // 0xB8
        private System.String _columnPrefix;        // 0xC0
        private System.String _encodedColumnName;        // 0xC8
        private System.Data.SimpleType _simpleType;        // 0xD0
        private static System.Int32 s_objectTypeCount;        // 0x0
        private readonly System.Int32 _objectID;        // 0xD8
        private System.String <XmlDataType>k__BackingField;        // 0xE0
        private System.ComponentModel.PropertyChangedEventHandler PropertyChanging;        // 0xE8

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String columnName, System.Type dataType) { }
        private System.Void .ctor(System.String columnName, System.Type dataType, System.String expr, System.Data.MappingType type) { }
        private System.Void UpdateColumnType(System.Type type, System.Data.Common.StorageType typeCode) { }
        private System.Boolean get_AllowDBNull() { }
        private System.Void set_AllowDBNull(System.Boolean value) { }
        private System.Boolean get_AutoIncrement() { }
        private System.Void set_AutoIncrement(System.Boolean value) { }
        private System.Object get_AutoIncrementCurrent() { }
        private System.Void set_AutoIncrementCurrent(System.Object value) { }
        private System.Data.AutoIncrementValue get_AutoInc() { }
        private System.Int64 get_AutoIncrementSeed() { }
        private System.Void set_AutoIncrementSeed(System.Int64 value) { }
        private System.Int64 get_AutoIncrementStep() { }
        private System.Void set_AutoIncrementStep(System.Int64 value) { }
        private System.String get_Caption() { }
        private System.Void set_Caption(System.String value) { }
        private System.String get_ColumnName() { }
        private System.Void set_ColumnName(System.String value) { }
        private System.String get_EncodedColumnName() { }
        private System.IFormatProvider get_FormatProvider() { }
        private System.Globalization.CultureInfo get_Locale() { }
        private System.Int32 get_ObjectID() { }
        private System.String get_Prefix() { }
        private System.Void set_Prefix(System.String value) { }
        private System.String GetColumnValueAsString(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Boolean get_Computed() { }
        private System.Data.DataExpression get_DataExpression() { }
        private System.Type get_DataType() { }
        private System.Void set_DataType(System.Type value) { }
        private System.Data.DataSetDateTime get_DateTimeMode() { }
        private System.Void set_DateTimeMode(System.Data.DataSetDateTime value) { }
        private System.Object get_DefaultValue() { }
        private System.Void set_DefaultValue(System.Object value) { }
        private System.Boolean get_DefaultValueIsNull() { }
        private System.String get_Expression() { }
        private System.Void set_Expression(System.String value) { }
        private System.Data.PropertyCollection get_ExtendedProperties() { }
        private System.Boolean get_HasData() { }
        private System.Boolean get_ImplementsINullable() { }
        private System.Boolean get_ImplementsIChangeTracking() { }
        private System.Boolean get_ImplementsIRevertibleChangeTracking() { }
        private System.Boolean get_IsValueType() { }
        private System.Boolean get_IsSqlType() { }
        private System.Void SetMaxLengthSimpleType() { }
        private System.Int32 get_MaxLength() { }
        private System.Void set_MaxLength(System.Int32 value) { }
        private System.String get_Namespace() { }
        private System.Void set_Namespace(System.String value) { }
        private System.Int32 get_Ordinal() { }
        private System.Void SetOrdinalInternal(System.Int32 ordinal) { }
        private System.Boolean get_ReadOnly() { }
        private System.Void set_ReadOnly(System.Boolean value) { }
        private System.Data.Index get_SortIndex() { }
        private System.Data.DataTable get_Table() { }
        private System.Void SetTable(System.Data.DataTable table) { }
        private System.Data.DataRow GetDataRow(System.Int32 index) { }
        private System.Object get_Item(System.Int32 record) { }
        private System.Void set_Item(System.Int32 record, System.Object value) { }
        private System.Void InitializeRecord(System.Int32 record) { }
        private System.Void SetValue(System.Int32 record, System.Object value) { }
        private System.Void FreeRecord(System.Int32 record) { }
        private System.Boolean get_Unique() { }
        private System.Void set_Unique(System.Boolean value) { }
        private System.Void InternalUnique(System.Boolean value) { }
        private System.String get_XmlDataType() { }
        private System.Void set_XmlDataType(System.String value) { }
        private System.Data.SimpleType get_SimpleType() { }
        private System.Void set_SimpleType(System.Data.SimpleType value) { }
        private System.Data.MappingType get_ColumnMapping() { }
        private System.Void set_ColumnMapping(System.Data.MappingType value) { }
        private System.Void CheckColumnConstraint(System.Data.DataRow row, System.Data.DataRowAction action) { }
        private System.Boolean CheckMaxLength() { }
        private System.Void CheckMaxLength(System.Data.DataRow dr) { }
        private System.Void CheckNotAllowNull() { }
        private System.Void CheckNullable(System.Data.DataRow row) { }
        private System.Void CheckUnique() { }
        private System.Int32 Compare(System.Int32 record1, System.Int32 record2) { }
        private System.Boolean CompareValueTo(System.Int32 record1, System.Object value, System.Boolean checkType) { }
        private System.Int32 CompareValueTo(System.Int32 record1, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 srcRecordNo, System.Int32 dstRecordNo) { }
        private System.Data.DataColumn Clone() { }
        private System.Object GetAggregateValue(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 GetStringLength(System.Int32 record) { }
        private System.Void Init(System.Int32 record) { }
        private System.Boolean IsAutoIncrementType(System.Type dataType) { }
        private System.Boolean get_IsCustomType() { }
        private System.Boolean IsValueCustomTypeInstance(System.Object value) { }
        private System.Boolean get_ImplementsIXMLSerializable() { }
        private System.Boolean IsInRelation() { }
        private System.Boolean IsMaxLengthViolated() { }
        private System.Boolean IsNotAllowDBNullViolated() { }
        private System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        private System.Void RaisePropertyChanging(System.String name) { }
        private System.Void InsureStorage() { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Void OnSetDataSet() { }
        private System.String ToString() { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib) { }
        private System.Object GetEmptyColumnStore(System.Int32 recordCount) { }
        private System.Void CopyValueIntoStore(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }
        private System.Void AddDependentColumn(System.Data.DataColumn expressionColumn) { }
        private System.Void RemoveDependentColumn(System.Data.DataColumn expressionColumn) { }
        private System.Void HandleDependentColumnList(System.Data.DataExpression oldExpression, System.Data.DataExpression newExpression) { }

    }

    // TypeToken: 0x2000010
    public class AutoIncrementValue
    {
        // Fields
        private System.Boolean <Auto>k__BackingField;        // 0x10

        // Methods
        private System.Boolean get_Auto() { }
        private System.Void set_Auto(System.Boolean value) { }
        private System.Object get_Current() { }
        private System.Void set_Current(System.Object value) { }
        private System.Int64 get_Seed() { }
        private System.Void set_Seed(System.Int64 value) { }
        private System.Int64 get_Step() { }
        private System.Void set_Step(System.Int64 value) { }
        private System.Type get_DataType() { }
        private System.Void SetCurrent(System.Object value, System.IFormatProvider formatProvider) { }
        private System.Void SetCurrentAndIncrement(System.Object value) { }
        private System.Void MoveAfter() { }
        private System.Data.AutoIncrementValue Clone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class AutoIncrementInt64 : AutoIncrementValue
    {
        // Fields
        private System.Int64 _current;        // 0x18
        private System.Int64 _seed;        // 0x20
        private System.Int64 _step;        // 0x28

        // Methods
        private System.Object get_Current() { }
        private System.Void set_Current(System.Object value) { }
        private System.Type get_DataType() { }
        private System.Int64 get_Seed() { }
        private System.Void set_Seed(System.Int64 value) { }
        private System.Int64 get_Step() { }
        private System.Void set_Step(System.Int64 value) { }
        private System.Void MoveAfter() { }
        private System.Void SetCurrent(System.Object value, System.IFormatProvider formatProvider) { }
        private System.Void SetCurrentAndIncrement(System.Object value) { }
        private System.Boolean BoundaryCheck(System.Numerics.BigInteger value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class AutoIncrementBigInteger : AutoIncrementValue
    {
        // Fields
        private System.Numerics.BigInteger _current;        // 0x18
        private System.Int64 _seed;        // 0x28
        private System.Numerics.BigInteger _step;        // 0x30

        // Methods
        private System.Object get_Current() { }
        private System.Void set_Current(System.Object value) { }
        private System.Type get_DataType() { }
        private System.Int64 get_Seed() { }
        private System.Void set_Seed(System.Int64 value) { }
        private System.Int64 get_Step() { }
        private System.Void set_Step(System.Int64 value) { }
        private System.Void MoveAfter() { }
        private System.Void SetCurrent(System.Object value, System.IFormatProvider formatProvider) { }
        private System.Void SetCurrentAndIncrement(System.Object value) { }
        private System.Boolean BoundaryCheck(System.Numerics.BigInteger value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class DataColumnChangeEventArgs : EventArgs
    {
        // Fields
        private System.Data.DataColumn _column;        // 0x10
        private readonly System.Data.DataRow <Row>k__BackingField;        // 0x18
        private System.Object <ProposedValue>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Data.DataRow row) { }
        private System.Void .ctor(System.Data.DataRow row, System.Data.DataColumn column, System.Object value) { }
        private System.Object get_ProposedValue() { }
        private System.Void set_ProposedValue(System.Object value) { }
        private System.Void InitializeColumnChangeEvent(System.Data.DataColumn column, System.Object value) { }

    }

    // TypeToken: 0x2000014
    public class DataColumnChangeEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Data.DataColumnChangeEventArgs e) { }

    }

    // TypeToken: 0x2000015
    public class DataColumnCollection : InternalDataCollectionBase
    {
        // Fields
        private readonly System.Data.DataTable _table;        // 0x10
        private readonly System.Collections.ArrayList _list;        // 0x18
        private System.Int32 _defaultNameIndex;        // 0x20
        private System.Data.DataColumn[] _delayedAddRangeColumns;        // 0x28
        private readonly System.Collections.Generic.Dictionary<System.String,System.Data.DataColumn> _columnFromName;        // 0x30
        private System.Boolean _fInClear;        // 0x38
        private System.Data.DataColumn[] _columnsImplementingIChangeTracking;        // 0x40
        private System.Int32 _nColumnsImplementingIChangeTracking;        // 0x48
        private System.Int32 _nColumnsImplementingIRevertibleChangeTracking;        // 0x4C
        private System.ComponentModel.CollectionChangeEventHandler CollectionChanged;        // 0x50
        private System.ComponentModel.CollectionChangeEventHandler CollectionChanging;        // 0x58
        private System.ComponentModel.CollectionChangeEventHandler ColumnPropertyChanged;        // 0x60

        // Methods
        private System.Void .ctor(System.Data.DataTable table) { }
        private System.Collections.ArrayList get_List() { }
        private System.Data.DataColumn[] get_ColumnsImplementingIChangeTracking() { }
        private System.Int32 get_ColumnsImplementingIChangeTrackingCount() { }
        private System.Int32 get_ColumnsImplementingIRevertibleChangeTrackingCount() { }
        private System.Data.DataColumn get_Item(System.Int32 index) { }
        private System.Data.DataColumn get_Item(System.String name) { }
        private System.Data.DataColumn get_Item(System.String name, System.String ns) { }
        private System.Void Add(System.Data.DataColumn column) { }
        private System.Void AddAt(System.Int32 index, System.Data.DataColumn column) { }
        private System.Void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value) { }
        private System.Void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value) { }
        private System.Void add_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value) { }
        private System.Void remove_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value) { }
        private System.Void ArrayAdd(System.Data.DataColumn column) { }
        private System.Void ArrayAdd(System.Int32 index, System.Data.DataColumn column) { }
        private System.Void ArrayRemove(System.Data.DataColumn column) { }
        private System.String AssignName() { }
        private System.Void BaseAdd(System.Data.DataColumn column) { }
        private System.Void BaseGroupSwitch(System.Data.DataColumn[] oldArray, System.Int32 oldLength, System.Data.DataColumn[] newArray, System.Int32 newLength) { }
        private System.Void BaseRemove(System.Data.DataColumn column) { }
        private System.Boolean CanRemove(System.Data.DataColumn column, System.Boolean fThrowException) { }
        private System.Void CheckIChangeTracking(System.Data.DataColumn column) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.String name) { }
        private System.Boolean Contains(System.String name, System.Boolean caseSensitive) { }
        private System.Int32 IndexOf(System.String columnName) { }
        private System.Int32 IndexOfCaseInsensitive(System.String name) { }
        private System.String MakeName(System.Int32 index) { }
        private System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        private System.Void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        private System.Void OnColumnPropertyChanged(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        private System.Void RegisterColumnName(System.String name, System.Data.DataColumn column) { }
        private System.Boolean CanRegisterName(System.String name) { }
        private System.Void Remove(System.Data.DataColumn column) { }
        private System.Void UnregisterName(System.String name) { }
        private System.Void AddColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn) { }
        private System.Void RemoveColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn) { }

    }

    // TypeToken: 0x2000016
    public class DataColumnPropertyDescriptor : PropertyDescriptor
    {
        // Fields
        private readonly System.Data.DataColumn <Column>k__BackingField;        // 0x88

        // Methods
        private System.Void .ctor(System.Data.DataColumn dataColumn) { }
        private System.ComponentModel.AttributeCollection get_Attributes() { }
        private System.Data.DataColumn get_Column() { }
        private System.Type get_ComponentType() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Type get_PropertyType() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean CanResetValue(System.Object component) { }
        private System.Object GetValue(System.Object component) { }
        private System.Void ResetValue(System.Object component) { }
        private System.Void SetValue(System.Object component, System.Object value) { }
        private System.Boolean ShouldSerializeValue(System.Object component) { }

    }

    // TypeToken: 0x2000017
    public class DataError
    {
        // Fields
        private System.String _rowError;        // 0x10
        private System.Int32 _count;        // 0x18
        private System.Data.DataError.ColumnError[] _errorList;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String rowError) { }
        private System.String get_Text() { }
        private System.Void set_Text(System.String value) { }
        private System.Boolean get_HasErrors() { }
        private System.Void SetColumnError(System.Data.DataColumn column, System.String error) { }
        private System.String GetColumnError(System.Data.DataColumn column) { }
        private System.Void Clear(System.Data.DataColumn column) { }
        private System.Void Clear() { }
        private System.Data.DataColumn[] GetColumnsInError() { }
        private System.Void SetText(System.String errorText) { }
        private System.Int32 IndexOf(System.Data.DataColumn column) { }

    }

    // TypeToken: 0x2000019
    public class DataException : SystemException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }
        private System.Void .ctor(System.String s, System.Exception innerException) { }

    }

    // TypeToken: 0x200001A
    public class ConstraintException : DataException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x200001B
    public class DeletedRowInaccessibleException : DataException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x200001C
    public class DuplicateNameException : DataException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x200001D
    public class InRowChangingEventException : DataException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x200001E
    public class InvalidConstraintException : DataException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x200001F
    public class NoNullAllowedException : DataException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x2000020
    public class ReadOnlyException : DataException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x2000021
    public class RowNotInTableException : DataException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x2000022
    public class VersionNotFoundException : DataException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x2000023
    public class ExceptionBuilder
    {
        // Methods
        private System.Void TraceException(System.String trace, System.Exception e) { }
        private System.Exception TraceExceptionAsReturnValue(System.Exception e) { }
        private System.Exception TraceExceptionForCapture(System.Exception e) { }
        private System.Exception TraceExceptionWithoutRethrow(System.Exception e) { }
        private System.Exception _Argument(System.String error) { }
        private System.Exception _Argument(System.String error, System.Exception innerException) { }
        private System.Exception _ArgumentNull(System.String paramName, System.String msg) { }
        private System.Exception _ArgumentOutOfRange(System.String paramName, System.String msg) { }
        private System.Exception _IndexOutOfRange(System.String error) { }
        private System.Exception _InvalidOperation(System.String error) { }
        private System.Exception _InvalidEnumArgumentException(System.String error) { }
        private System.Exception _InvalidEnumArgumentException(T value) { }
        private System.Void ThrowDataException(System.String error, System.Exception innerException) { }
        private System.Exception _Data(System.String error) { }
        private System.Exception _Constraint(System.String error) { }
        private System.Exception _InvalidConstraint(System.String error) { }
        private System.Exception _DeletedRowInaccessible(System.String error) { }
        private System.Exception _DuplicateName(System.String error) { }
        private System.Exception _InRowChangingEvent(System.String error) { }
        private System.Exception _NoNullAllowed(System.String error) { }
        private System.Exception _ReadOnly(System.String error) { }
        private System.Exception _RowNotInTable(System.String error) { }
        private System.Exception _VersionNotFound(System.String error) { }
        private System.Exception ArgumentNull(System.String paramName) { }
        private System.Exception ArgumentOutOfRange(System.String paramName) { }
        private System.Exception BadObjectPropertyAccess(System.String error) { }
        private System.Exception CaseInsensitiveNameConflict(System.String name) { }
        private System.Exception NamespaceNameConflict(System.String name) { }
        private System.Exception InvalidOffsetLength() { }
        private System.Exception ColumnNotInTheTable(System.String column, System.String table) { }
        private System.Exception ColumnNotInAnyTable() { }
        private System.Exception ColumnOutOfRange(System.Int32 index) { }
        private System.Exception ColumnOutOfRange(System.String column) { }
        private System.Exception CannotAddColumn1(System.String column) { }
        private System.Exception CannotAddColumn2(System.String column) { }
        private System.Exception CannotAddColumn3() { }
        private System.Exception CannotAddColumn4(System.String column) { }
        private System.Exception CannotAddDuplicate(System.String column) { }
        private System.Exception CannotAddDuplicate2(System.String table) { }
        private System.Exception CannotAddDuplicate3(System.String table) { }
        private System.Exception CannotRemoveColumn() { }
        private System.Exception CannotRemovePrimaryKey() { }
        private System.Exception CannotRemoveChildKey(System.String relation) { }
        private System.Exception CannotRemoveConstraint(System.String constraint, System.String table) { }
        private System.Exception CannotRemoveExpression(System.String column, System.String expression) { }
        private System.Exception AddPrimaryKeyConstraint() { }
        private System.Exception NoConstraintName() { }
        private System.Exception ConstraintViolation(System.String constraint) { }
        private System.String KeysToString(System.Object[] keys) { }
        private System.String UniqueConstraintViolationText(System.Data.DataColumn[] columns, System.Object[] values) { }
        private System.Exception ConstraintViolation(System.Data.DataColumn[] columns, System.Object[] values) { }
        private System.Exception ConstraintOutOfRange(System.Int32 index) { }
        private System.Exception DuplicateConstraint(System.String constraint) { }
        private System.Exception DuplicateConstraintName(System.String constraint) { }
        private System.Exception NeededForForeignKeyConstraint(System.Data.UniqueConstraint key, System.Data.ForeignKeyConstraint fk) { }
        private System.Exception UniqueConstraintViolation() { }
        private System.Exception ConstraintForeignTable() { }
        private System.Exception ConstraintParentValues() { }
        private System.Exception ConstraintAddFailed(System.Data.DataTable table) { }
        private System.Exception ConstraintRemoveFailed() { }
        private System.Exception FailedCascadeDelete(System.String constraint) { }
        private System.Exception FailedCascadeUpdate(System.String constraint) { }
        private System.Exception FailedClearParentTable(System.String table, System.String constraint, System.String childTable) { }
        private System.Exception ForeignKeyViolation(System.String constraint, System.Object[] keys) { }
        private System.Exception RemoveParentRow(System.Data.ForeignKeyConstraint constraint) { }
        private System.String MaxLengthViolationText(System.String columnName) { }
        private System.String NotAllowDBNullViolationText(System.String columnName) { }
        private System.Exception CantAddConstraintToMultipleNestedTable(System.String tableName) { }
        private System.Exception AutoIncrementAndExpression() { }
        private System.Exception AutoIncrementAndDefaultValue() { }
        private System.Exception AutoIncrementSeed() { }
        private System.Exception CantChangeDataType() { }
        private System.Exception NullDataType() { }
        private System.Exception ColumnNameRequired() { }
        private System.Exception DefaultValueAndAutoIncrement() { }
        private System.Exception DefaultValueDataType(System.String column, System.Type defaultType, System.Type columnType, System.Exception inner) { }
        private System.Exception DefaultValueColumnDataType(System.String column, System.Type defaultType, System.Type columnType, System.Exception inner) { }
        private System.Exception ExpressionAndUnique() { }
        private System.Exception ExpressionAndReadOnly() { }
        private System.Exception ExpressionAndConstraint(System.Data.DataColumn column, System.Data.Constraint constraint) { }
        private System.Exception ExpressionInConstraint(System.Data.DataColumn column) { }
        private System.Exception ExpressionCircular() { }
        private System.Exception NonUniqueValues(System.String column) { }
        private System.Exception NullKeyValues(System.String column) { }
        private System.Exception NullValues(System.String column) { }
        private System.Exception ReadOnlyAndExpression() { }
        private System.Exception ReadOnly(System.String column) { }
        private System.Exception UniqueAndExpression() { }
        private System.Exception SetFailed(System.Object value, System.Data.DataColumn column, System.Type type, System.Exception innerException) { }
        private System.Exception CannotSetToNull(System.Data.DataColumn column) { }
        private System.Exception LongerThanMaxLength(System.Data.DataColumn column) { }
        private System.Exception CannotSetMaxLength(System.Data.DataColumn column, System.Int32 value) { }
        private System.Exception CannotSetMaxLength2(System.Data.DataColumn column) { }
        private System.Exception CannotSetSimpleContentType(System.String columnName, System.Type type) { }
        private System.Exception CannotSetSimpleContent(System.String columnName, System.Type type) { }
        private System.Exception CannotChangeNamespace(System.String columnName) { }
        private System.Exception HasToBeStringType(System.Data.DataColumn column) { }
        private System.Exception AutoIncrementCannotSetIfHasData(System.String typeName) { }
        private System.Exception INullableUDTwithoutStaticNull(System.String typeName) { }
        private System.Exception IComparableNotImplemented(System.String typeName) { }
        private System.Exception UDTImplementsIChangeTrackingButnotIRevertible(System.String typeName) { }
        private System.Exception InvalidDataColumnMapping(System.Type type) { }
        private System.Exception CannotSetDateTimeModeForNonDateTimeColumns() { }
        private System.Exception InvalidDateTimeMode(System.Data.DataSetDateTime mode) { }
        private System.Exception CantChangeDateTimeMode(System.Data.DataSetDateTime oldValue, System.Data.DataSetDateTime newValue) { }
        private System.Exception ColumnTypeNotSupported() { }
        private System.Exception SetFailed(System.String name) { }
        private System.Exception CanNotUse() { }
        private System.Exception SetIListObject() { }
        private System.Exception AddNewNotAllowNull() { }
        private System.Exception NotOpen() { }
        private System.Exception CreateChildView() { }
        private System.Exception CanNotDelete() { }
        private System.Exception GetElementIndex(System.Int32 index) { }
        private System.Exception AddExternalObject() { }
        private System.Exception CanNotClear() { }
        private System.Exception InsertExternalObject() { }
        private System.Exception RemoveExternalObject() { }
        private System.Exception KeyTableMismatch() { }
        private System.Exception KeyNoColumns() { }
        private System.Exception KeyTooManyColumns(System.Int32 cols) { }
        private System.Exception KeyDuplicateColumns(System.String columnName) { }
        private System.Exception RelationDataSetMismatch() { }
        private System.Exception ColumnsTypeMismatch() { }
        private System.Exception KeyLengthMismatch() { }
        private System.Exception KeyLengthZero() { }
        private System.Exception ForeignRelation() { }
        private System.Exception KeyColumnsIdentical() { }
        private System.Exception RelationForeignTable(System.String t1, System.String t2) { }
        private System.Exception GetParentRowTableMismatch(System.String t1, System.String t2) { }
        private System.Exception SetParentRowTableMismatch(System.String t1, System.String t2) { }
        private System.Exception RelationForeignRow() { }
        private System.Exception RelationNestedReadOnly() { }
        private System.Exception TableCantBeNestedInTwoTables(System.String tableName) { }
        private System.Exception LoopInNestedRelations(System.String tableName) { }
        private System.Exception RelationDoesNotExist() { }
        private System.Exception ParentOrChildColumnsDoNotHaveDataSet() { }
        private System.Exception InValidNestedRelation(System.String childTableName) { }
        private System.Exception InvalidParentNamespaceinNestedRelation(System.String childTableName) { }
        private System.Exception RowNotInTheDataSet() { }
        private System.Exception RowNotInTheTable() { }
        private System.Exception EditInRowChanging() { }
        private System.Exception EndEditInRowChanging() { }
        private System.Exception BeginEditInRowChanging() { }
        private System.Exception CancelEditInRowChanging() { }
        private System.Exception DeleteInRowDeleting() { }
        private System.Exception ValueArrayLength() { }
        private System.Exception NoCurrentData() { }
        private System.Exception NoOriginalData() { }
        private System.Exception NoProposedData() { }
        private System.Exception RowRemovedFromTheTable() { }
        private System.Exception DeletedRowInaccessible() { }
        private System.Exception RowAlreadyDeleted() { }
        private System.Exception RowEmpty() { }
        private System.Exception InvalidRowVersion() { }
        private System.Exception RowOutOfRange(System.Int32 index) { }
        private System.Exception RowInsertTwice(System.Int32 index, System.String tableName) { }
        private System.Exception RowInsertMissing(System.String tableName) { }
        private System.Exception RowAlreadyRemoved() { }
        private System.Exception MultipleParents() { }
        private System.Exception InvalidRowState(System.Data.DataRowState state) { }
        private System.Exception InvalidRowBitPattern() { }
        private System.Exception SetDataSetNameToEmpty() { }
        private System.Exception SetDataSetNameConflicting(System.String name) { }
        private System.Exception DataSetUnsupportedSchema(System.String ns) { }
        private System.Exception MergeMissingDefinition(System.String obj) { }
        private System.Exception TablesInDifferentSets() { }
        private System.Exception RelationAlreadyExists() { }
        private System.Exception RowAlreadyInOtherCollection() { }
        private System.Exception RowAlreadyInTheCollection() { }
        private System.Exception RecordStateRange() { }
        private System.Exception IndexKeyLength(System.Int32 length, System.Int32 keyLength) { }
        private System.Exception RemovePrimaryKey(System.Data.DataTable table) { }
        private System.Exception RelationAlreadyInOtherDataSet() { }
        private System.Exception RelationAlreadyInTheDataSet() { }
        private System.Exception RelationNotInTheDataSet(System.String relation) { }
        private System.Exception RelationOutOfRange(System.Object index) { }
        private System.Exception DuplicateRelation(System.String relation) { }
        private System.Exception RelationTableNull() { }
        private System.Exception RelationDataSetNull() { }
        private System.Exception RelationTableWasRemoved() { }
        private System.Exception ParentTableMismatch() { }
        private System.Exception ChildTableMismatch() { }
        private System.Exception EnforceConstraint() { }
        private System.Exception CaseLocaleMismatch() { }
        private System.Exception CannotChangeCaseLocale() { }
        private System.Exception CannotChangeCaseLocale(System.Exception innerException) { }
        private System.Exception InvalidRemotingFormat(System.Data.SerializationFormat mode) { }
        private System.Exception TableForeignPrimaryKey() { }
        private System.Exception TableCannotAddToSimpleContent() { }
        private System.Exception NoTableName() { }
        private System.Exception MultipleTextOnlyColumns() { }
        private System.Exception InvalidSortString(System.String sort) { }
        private System.Exception DuplicateTableName(System.String table) { }
        private System.Exception DuplicateTableName2(System.String table, System.String ns) { }
        private System.Exception SelfnestedDatasetConflictingName(System.String table) { }
        private System.Exception DatasetConflictingName(System.String table) { }
        private System.Exception TableAlreadyInOtherDataSet() { }
        private System.Exception TableAlreadyInTheDataSet() { }
        private System.Exception TableOutOfRange(System.Int32 index) { }
        private System.Exception TableNotInTheDataSet(System.String table) { }
        private System.Exception TableInRelation() { }
        private System.Exception TableInConstraint(System.Data.DataTable table, System.Data.Constraint constraint) { }
        private System.Exception CanNotSerializeDataTableHierarchy() { }
        private System.Exception CanNotRemoteDataTable() { }
        private System.Exception CanNotSetRemotingFormat() { }
        private System.Exception CanNotSerializeDataTableWithEmptyName() { }
        private System.Exception TableNotFound(System.String tableName) { }
        private System.Exception AggregateException(System.Data.AggregateType aggregateType, System.Type type) { }
        private System.Exception InvalidStorageType(System.TypeCode typecode) { }
        private System.Exception RangeArgument(System.Int32 min, System.Int32 max) { }
        private System.Exception NullRange() { }
        private System.Exception NegativeMinimumCapacity() { }
        private System.Exception ProblematicChars(System.Char charValue) { }
        private System.Exception StorageSetFailed() { }
        private System.Exception SimpleTypeNotSupported() { }
        private System.Exception MissingAttribute(System.String attribute) { }
        private System.Exception MissingAttribute(System.String element, System.String attribute) { }
        private System.Exception InvalidAttributeValue(System.String name, System.String value) { }
        private System.Exception AttributeValues(System.String name, System.String value1, System.String value2) { }
        private System.Exception ElementTypeNotFound(System.String name) { }
        private System.Exception RelationParentNameMissing(System.String rel) { }
        private System.Exception RelationChildNameMissing(System.String rel) { }
        private System.Exception RelationTableKeyMissing(System.String rel) { }
        private System.Exception RelationChildKeyMissing(System.String rel) { }
        private System.Exception UndefinedDatatype(System.String name) { }
        private System.Exception DatatypeNotDefined() { }
        private System.Exception MismatchKeyLength() { }
        private System.Exception InvalidField(System.String name) { }
        private System.Exception InvalidSelector(System.String name) { }
        private System.Exception CircularComplexType(System.String name) { }
        private System.Exception CannotInstantiateAbstract(System.String name) { }
        private System.Exception InvalidKey(System.String name) { }
        private System.Exception DiffgramMissingTable(System.String name) { }
        private System.Exception DiffgramMissingSQL() { }
        private System.Exception DuplicateConstraintRead(System.String str) { }
        private System.Exception ColumnTypeConflict(System.String name) { }
        private System.Exception CannotConvert(System.String name, System.String type) { }
        private System.Exception MissingRefer(System.String name) { }
        private System.Exception InvalidPrefix(System.String name) { }
        private System.Exception CanNotDeserializeObjectType() { }
        private System.Exception IsDataSetAttributeMissingInSchema() { }
        private System.Exception TooManyIsDataSetAtributeInSchema() { }
        private System.Exception NestedCircular(System.String name) { }
        private System.Exception MultipleParentRows(System.String tableQName) { }
        private System.Exception PolymorphismNotSupported(System.String typeName) { }
        private System.Exception DataTableInferenceNotSupported() { }
        private System.Void ThrowMultipleTargetConverter(System.Exception innerException) { }
        private System.Exception DuplicateDeclaration(System.String name) { }
        private System.Exception FoundEntity() { }
        private System.Exception MergeFailed(System.String name) { }
        private System.Exception ConvertFailed(System.Type type1, System.Type type2) { }
        private System.Exception InvalidDuplicateNamedSimpleTypeDelaration(System.String stName, System.String errorStr) { }
        private System.Exception InternalRBTreeError(System.Data.RBTreeError internalError) { }
        private System.Exception EnumeratorModified() { }

    }

    // TypeToken: 0x2000024
    public struct DataKey
    {
        // Fields
        private readonly System.Data.DataColumn[] _columns;        // 0x10

        // Methods
        private System.Void .ctor(System.Data.DataColumn[] columns, System.Boolean copyColumns) { }
        private System.Data.DataColumn[] get_ColumnsReference() { }
        private System.Boolean get_HasValue() { }
        private System.Data.DataTable get_Table() { }
        private System.Void CheckState() { }
        private System.Boolean ColumnsEqual(System.Data.DataKey key) { }
        private System.Boolean ColumnsEqual(System.Data.DataColumn[] column1, System.Data.DataColumn[] column2) { }
        private System.Boolean ContainsColumn(System.Data.DataColumn column) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object value) { }
        private System.Boolean Equals(System.Data.DataKey value) { }
        private System.String[] GetColumnNames() { }
        private System.Data.IndexField[] GetIndexDesc() { }
        private System.Object[] GetKeyValues(System.Int32 record) { }
        private System.Data.Index GetSortIndex() { }
        private System.Data.Index GetSortIndex(System.Data.DataViewRowState recordStates) { }
        private System.Boolean RecordsEqual(System.Int32 record1, System.Int32 record2) { }
        private System.Data.DataColumn[] ToArray() { }

    }

    // TypeToken: 0x2000025
    public class DataRelation
    {
        // Fields
        private System.Data.DataSet _dataSet;        // 0x10
        private System.Data.PropertyCollection _extendedProperties;        // 0x18
        private System.String _relationName;        // 0x20
        private System.Data.DataKey _childKey;        // 0x28
        private System.Data.DataKey _parentKey;        // 0x30
        private System.Data.UniqueConstraint _parentKeyConstraint;        // 0x38
        private System.Data.ForeignKeyConstraint _childKeyConstraint;        // 0x40
        private System.String[] _parentColumnNames;        // 0x48
        private System.String[] _childColumnNames;        // 0x50
        private System.String _parentTableName;        // 0x58
        private System.String _childTableName;        // 0x60
        private System.String _parentTableNamespace;        // 0x68
        private System.String _childTableNamespace;        // 0x70
        private System.Boolean _nested;        // 0x78
        private System.Boolean _createConstraints;        // 0x79
        private System.Boolean _checkMultipleNested;        // 0x7A
        private static System.Int32 s_objectTypeCount;        // 0x0
        private readonly System.Int32 _objectID;        // 0x7C
        private System.ComponentModel.PropertyChangedEventHandler PropertyChanging;        // 0x80

        // Methods
        private System.Void .ctor(System.String relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, System.Boolean createConstraints) { }
        private System.Void .ctor(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
        private System.Void .ctor(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, System.Boolean createConstraints) { }
        private System.Void .ctor(System.String relationName, System.String parentTableName, System.String childTableName, System.String[] parentColumnNames, System.String[] childColumnNames, System.Boolean nested) { }
        private System.Void .ctor(System.String relationName, System.String parentTableName, System.String parentTableNamespace, System.String childTableName, System.String childTableNamespace, System.String[] parentColumnNames, System.String[] childColumnNames, System.Boolean nested) { }
        private System.Data.DataColumn[] get_ChildColumns() { }
        private System.Data.DataColumn[] get_ChildColumnsReference() { }
        private System.Data.DataKey get_ChildKey() { }
        private System.Data.DataTable get_ChildTable() { }
        private System.Data.DataSet get_DataSet() { }
        private System.String[] get_ParentColumnNames() { }
        private System.String[] get_ChildColumnNames() { }
        private System.Boolean IsKeyNull(System.Object[] values) { }
        private System.Data.DataRow[] GetChildRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow parentRow, System.Data.DataRowVersion version) { }
        private System.Data.DataRow[] GetParentRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version) { }
        private System.Data.DataRow GetParentRow(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version) { }
        private System.Void SetDataSet(System.Data.DataSet dataSet) { }
        private System.Data.DataColumn[] get_ParentColumns() { }
        private System.Data.DataColumn[] get_ParentColumnsReference() { }
        private System.Data.DataKey get_ParentKey() { }
        private System.Data.DataTable get_ParentTable() { }
        private System.String get_RelationName() { }
        private System.Void CheckNamespaceValidityForNestedRelations(System.String ns) { }
        private System.Void CheckNestedRelations() { }
        private System.Boolean get_Nested() { }
        private System.Void set_Nested(System.Boolean value) { }
        private System.Data.UniqueConstraint get_ParentKeyConstraint() { }
        private System.Void SetParentKeyConstraint(System.Data.UniqueConstraint value) { }
        private System.Data.ForeignKeyConstraint get_ChildKeyConstraint() { }
        private System.Data.PropertyCollection get_ExtendedProperties() { }
        private System.Boolean get_CheckMultipleNested() { }
        private System.Void set_CheckMultipleNested(System.Boolean value) { }
        private System.Void SetChildKeyConstraint(System.Data.ForeignKeyConstraint value) { }
        private System.Void CheckState() { }
        private System.Void CheckStateForProperty() { }
        private System.Void Create(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, System.Boolean createConstraints) { }
        private System.Data.DataRelation Clone(System.Data.DataSet destination) { }
        private System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        private System.Void RaisePropertyChanging(System.String name) { }
        private System.String ToString() { }
        private System.Void ValidateMultipleNestedRelations() { }
        private System.Boolean IsAutoGenerated(System.Data.DataColumn col) { }
        private System.Int32 get_ObjectID() { }

    }

    // TypeToken: 0x2000026
    public class DataRelationCollection : InternalDataCollectionBase
    {
        // Fields
        private System.Data.DataRelation _inTransition;        // 0x10
        private System.Int32 _defaultNameIndex;        // 0x18
        private System.ComponentModel.CollectionChangeEventHandler _onCollectionChangedDelegate;        // 0x20
        private System.ComponentModel.CollectionChangeEventHandler _onCollectionChangingDelegate;        // 0x28
        private static System.Int32 s_objectTypeCount;        // 0x0
        private readonly System.Int32 _objectID;        // 0x30

        // Methods
        private System.Int32 get_ObjectID() { }
        private System.Data.DataRelation get_Item(System.Int32 index) { }
        private System.Data.DataRelation get_Item(System.String name) { }
        private System.Void Add(System.Data.DataRelation relation) { }
        private System.Void AddCore(System.Data.DataRelation relation) { }
        private System.Void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value) { }
        private System.Void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value) { }
        private System.String AssignName() { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.String name) { }
        private System.Int32 InternalIndexOf(System.String name) { }
        private System.Data.DataSet GetDataSet() { }
        private System.String MakeName(System.Int32 index) { }
        private System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        private System.Void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        private System.Void RegisterName(System.String name) { }
        private System.Void Remove(System.Data.DataRelation relation) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void RemoveCore(System.Data.DataRelation relation) { }
        private System.Void UnregisterName(System.String name) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000029
    public class DataRelationPropertyDescriptor : PropertyDescriptor
    {
        // Fields
        private readonly System.Data.DataRelation <Relation>k__BackingField;        // 0x88

        // Methods
        private System.Void .ctor(System.Data.DataRelation dataRelation) { }
        private System.Data.DataRelation get_Relation() { }
        private System.Type get_ComponentType() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Type get_PropertyType() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean CanResetValue(System.Object component) { }
        private System.Object GetValue(System.Object component) { }
        private System.Void ResetValue(System.Object component) { }
        private System.Void SetValue(System.Object component, System.Object value) { }
        private System.Boolean ShouldSerializeValue(System.Object component) { }

    }

    // TypeToken: 0x200002A
    public class DataRow
    {
        // Fields
        private readonly System.Data.DataTable _table;        // 0x10
        private readonly System.Data.DataColumnCollection _columns;        // 0x18
        private System.Int32 _oldRecord;        // 0x20
        private System.Int32 _newRecord;        // 0x24
        private System.Int32 _tempRecord;        // 0x28
        private System.Int64 _rowID;        // 0x30
        private System.Data.DataRowAction _action;        // 0x38
        private System.Boolean _inChangingEvent;        // 0x3C
        private System.Boolean _inDeletingEvent;        // 0x3D
        private System.Boolean _inCascade;        // 0x3E
        private System.Data.DataColumn _lastChangedColumn;        // 0x40
        private System.Int32 _countColumnChange;        // 0x48
        private System.Data.DataError _error;        // 0x50
        private System.Int32 _rbTreeNodeId;        // 0x58
        private static System.Int32 s_objectTypeCount;        // 0x0
        private readonly System.Int32 _objectID;        // 0x5C

        // Methods
        private System.Void .ctor(System.Data.DataRowBuilder builder) { }
        private System.Data.DataColumn get_LastChangedColumn() { }
        private System.Void set_LastChangedColumn(System.Data.DataColumn value) { }
        private System.Boolean get_HasPropertyChanged() { }
        private System.Int32 get_RBTreeNodeId() { }
        private System.Void set_RBTreeNodeId(System.Int32 value) { }
        private System.String get_RowError() { }
        private System.Void set_RowError(System.String value) { }
        private System.Void RowErrorChanged() { }
        private System.Int64 get_rowID() { }
        private System.Void set_rowID(System.Int64 value) { }
        private System.Data.DataRowState get_RowState() { }
        private System.Data.DataTable get_Table() { }
        private System.Void CheckForLoops(System.Data.DataRelation rel) { }
        private System.Int32 GetNestedParentCount() { }
        private System.Void set_Item(System.String columnName, System.Object value) { }
        private System.Object get_Item(System.Data.DataColumn column) { }
        private System.Void set_Item(System.Data.DataColumn column, System.Object value) { }
        private System.Object get_Item(System.Data.DataColumn column, System.Data.DataRowVersion version) { }
        private System.Void set_ItemArray(System.Object[] value) { }
        private System.Void AcceptChanges() { }
        private System.Void BeginEdit() { }
        private System.Boolean BeginEditInternal() { }
        private System.Void CancelEdit() { }
        private System.Void CheckColumn(System.Data.DataColumn column) { }
        private System.Void CheckInTable() { }
        private System.Void Delete() { }
        private System.Void EndEdit() { }
        private System.Void SetColumnError(System.Int32 columnIndex, System.String error) { }
        private System.Void SetColumnError(System.Data.DataColumn column, System.String error) { }
        private System.String GetColumnError(System.Data.DataColumn column) { }
        private System.Void ClearErrors() { }
        private System.Void ClearError(System.Data.DataColumn column) { }
        private System.Boolean get_HasErrors() { }
        private System.Data.DataColumn[] GetColumnsInError() { }
        private System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation) { }
        private System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation, System.Data.DataRowVersion version) { }
        private System.Data.DataColumn GetDataColumn(System.String columnName) { }
        private System.Data.DataRow GetParentRow(System.Data.DataRelation relation) { }
        private System.Data.DataRow GetParentRow(System.Data.DataRelation relation, System.Data.DataRowVersion version) { }
        private System.Data.DataRow GetNestedParentRow(System.Data.DataRowVersion version) { }
        private System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation) { }
        private System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation, System.Data.DataRowVersion version) { }
        private System.Object[] GetColumnValues(System.Data.DataColumn[] columns) { }
        private System.Object[] GetColumnValues(System.Data.DataColumn[] columns, System.Data.DataRowVersion version) { }
        private System.Object[] GetKeyValues(System.Data.DataKey key) { }
        private System.Object[] GetKeyValues(System.Data.DataKey key, System.Data.DataRowVersion version) { }
        private System.Int32 GetCurrentRecordNo() { }
        private System.Int32 GetDefaultRecord() { }
        private System.Int32 GetOriginalRecordNo() { }
        private System.Int32 GetProposedRecordNo() { }
        private System.Int32 GetRecordFromVersion(System.Data.DataRowVersion version) { }
        private System.Data.DataRowVersion GetDefaultRowVersion(System.Data.DataViewRowState viewState) { }
        private System.Data.DataViewRowState GetRecordState(System.Int32 record) { }
        private System.Boolean HasKeyChanged(System.Data.DataKey key) { }
        private System.Boolean HasKeyChanged(System.Data.DataKey key, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2) { }
        private System.Boolean HasVersion(System.Data.DataRowVersion version) { }
        private System.Boolean HaveValuesChanged(System.Data.DataColumn[] columns) { }
        private System.Boolean HaveValuesChanged(System.Data.DataColumn[] columns, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2) { }
        private System.Void RejectChanges() { }
        private System.Void ResetLastChangedColumn() { }
        private System.Void SetKeyValues(System.Data.DataKey key, System.Object[] keyValues) { }
        private System.Void SetNestedParentRow(System.Data.DataRow parentRow, System.Boolean setNonNested) { }
        private System.Void SetParentRowToDBNull() { }
        private System.Void SetParentRowToDBNull(System.Data.DataRelation relation) { }
        private System.Int32 CopyValuesIntoStore(System.Collections.ArrayList storeList, System.Collections.ArrayList nullbitList, System.Int32 storeIndex) { }

    }

    // TypeToken: 0x200002B
    public class DataRowBuilder
    {
        // Fields
        private readonly System.Data.DataTable _table;        // 0x10
        private System.Int32 _record;        // 0x18

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.Int32 record) { }

    }

    // TypeToken: 0x200002C
    public struct DataRowAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.DataRowAction Nothing;        // 0x0
        public static System.Data.DataRowAction Delete;        // 0x0
        public static System.Data.DataRowAction Change;        // 0x0
        public static System.Data.DataRowAction Rollback;        // 0x0
        public static System.Data.DataRowAction Commit;        // 0x0
        public static System.Data.DataRowAction Add;        // 0x0
        public static System.Data.DataRowAction ChangeOriginal;        // 0x0
        public static System.Data.DataRowAction ChangeCurrentAndOriginal;        // 0x0

    }

    // TypeToken: 0x200002D
    public class DataRowChangeEventArgs : EventArgs
    {
        // Fields
        private readonly System.Data.DataRow <Row>k__BackingField;        // 0x10
        private readonly System.Data.DataRowAction <Action>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Data.DataRow row, System.Data.DataRowAction action) { }

    }

    // TypeToken: 0x200002E
    public class DataRowChangeEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Data.DataRowChangeEventArgs e) { }

    }

    // TypeToken: 0x200002F
    public class DataRowCollection : InternalDataCollectionBase
    {
        // Fields
        private readonly System.Data.DataTable _table;        // 0x10
        private readonly System.Data.DataRowCollection.DataRowTree _list;        // 0x18
        private System.Int32 _nullInList;        // 0x20

        // Methods
        private System.Void .ctor(System.Data.DataTable table) { }
        private System.Int32 get_Count() { }
        private System.Data.DataRow get_Item(System.Int32 index) { }
        private System.Void Add(System.Data.DataRow row) { }
        private System.Void DiffInsertAt(System.Data.DataRow row, System.Int32 pos) { }
        private System.Int32 IndexOf(System.Data.DataRow row) { }
        private System.Data.DataRow AddWithColumnEvents(System.Object[] values) { }
        private System.Void ArrayAdd(System.Data.DataRow row) { }
        private System.Void ArrayInsert(System.Data.DataRow row, System.Int32 pos) { }
        private System.Void ArrayClear() { }
        private System.Void ArrayRemove(System.Data.DataRow row) { }
        private System.Void CopyTo(System.Array ar, System.Int32 index) { }
        private System.Void CopyTo(System.Data.DataRow[] array, System.Int32 index) { }
        private System.Collections.IEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x2000031
    public class DataRowCreatedEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Data.DataRow r) { }

    }

    // TypeToken: 0x2000032
    public class DataSetClearEventhandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Data.DataTable table) { }

    }

    // TypeToken: 0x2000033
    public struct DataRowState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.DataRowState Detached;        // 0x0
        public static System.Data.DataRowState Unchanged;        // 0x0
        public static System.Data.DataRowState Added;        // 0x0
        public static System.Data.DataRowState Deleted;        // 0x0
        public static System.Data.DataRowState Modified;        // 0x0

    }

    // TypeToken: 0x2000034
    public struct DataRowVersion
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.DataRowVersion Original;        // 0x0
        public static System.Data.DataRowVersion Current;        // 0x0
        public static System.Data.DataRowVersion Proposed;        // 0x0
        public static System.Data.DataRowVersion Default;        // 0x0

    }

    // TypeToken: 0x2000035
    public class DataRowView, ICustomTypeDescriptor, INotifyPropertyChanged
    {
        // Fields
        private readonly System.Data.DataView _dataView;        // 0x10
        private readonly System.Data.DataRow _row;        // 0x18
        private System.Boolean _delayBeginEdit;        // 0x20
        private static readonly System.ComponentModel.PropertyDescriptorCollection s_zeroPropertyDescriptorCollection;        // 0x0
        private System.ComponentModel.PropertyChangedEventHandler PropertyChanged;        // 0x28

        // Methods
        private System.Void .ctor(System.Data.DataView dataView, System.Data.DataRow row) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Int32 GetHashCode() { }
        private System.Data.DataView get_DataView() { }
        private System.Data.DataRowVersion get_RowVersionDefault() { }
        private System.Int32 GetRecord() { }
        private System.Boolean HasRecord() { }
        private System.Object GetColumnValue(System.Data.DataColumn column) { }
        private System.Void SetColumnValue(System.Data.DataColumn column, System.Object value) { }
        private System.Data.DataView CreateChildView(System.Data.DataRelation relation, System.Boolean followParent) { }
        private System.Data.DataView CreateChildView(System.Data.DataRelation relation) { }
        private System.Data.DataRow get_Row() { }
        private System.Void EndEdit() { }
        private System.Boolean get_IsNew() { }
        private System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void RaisePropertyChangedEvent(System.String propName) { }
        private System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }
        private System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }
        private System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }
        private System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { }
        private System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000036
    public struct SerializationFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.SerializationFormat Xml;        // 0x0
        public static System.Data.SerializationFormat Binary;        // 0x0

    }

    // TypeToken: 0x2000037
    public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable
    {
        // Fields
        private System.Data.DataViewManager _defaultViewManager;        // 0x20
        private readonly System.Data.DataTableCollection _tableCollection;        // 0x28
        private readonly System.Data.DataRelationCollection _relationCollection;        // 0x30
        private System.Data.PropertyCollection _extendedProperties;        // 0x38
        private System.String _dataSetName;        // 0x40
        private System.String _datasetPrefix;        // 0x48
        private System.String _namespaceURI;        // 0x50
        private System.Boolean _enforceConstraints;        // 0x58
        private System.Boolean _caseSensitive;        // 0x59
        private System.Globalization.CultureInfo _culture;        // 0x60
        private System.Boolean _cultureUserSet;        // 0x68
        private System.Boolean _fInReadXml;        // 0x69
        private System.Boolean _fInLoadDiffgram;        // 0x6A
        private System.Boolean _fTopLevelTable;        // 0x6B
        private System.Boolean _fInitInProgress;        // 0x6C
        private System.Boolean _fEnableCascading;        // 0x6D
        private System.Boolean _fIsSchemaLoading;        // 0x6E
        private System.String _mainTableName;        // 0x70
        private System.Data.SerializationFormat _remotingFormat;        // 0x78
        private System.Object _defaultViewManagerLock;        // 0x80
        private static System.Int32 s_objectTypeCount;        // 0x0
        private readonly System.Int32 _objectID;        // 0x88
        private static System.Xml.Schema.XmlSchemaComplexType s_schemaTypeForWSDL;        // 0x8
        private System.Boolean _useDataSetSchemaOnly;        // 0x8C
        private System.Boolean _udtIsWrapped;        // 0x8D
        private System.ComponentModel.PropertyChangedEventHandler PropertyChanging;        // 0x90
        private System.Data.MergeFailedEventHandler MergeFailed;        // 0x98
        private System.Data.DataRowCreatedEventHandler DataRowCreated;        // 0xA0
        private System.Data.DataSetClearEventhandler ClearFunctionCalled;        // 0xA8

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String dataSetName) { }
        private System.Data.SerializationFormat get_RemotingFormat() { }
        private System.Void set_RemotingFormat(System.Data.SerializationFormat value) { }
        private System.Data.SchemaSerializationMode get_SchemaSerializationMode() { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean ConstructSchema) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void InitializeDerivedDataSet() { }
        private System.Void SerializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat) { }
        private System.Void DeserializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode) { }
        private System.Void DeserializeDataSetSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode) { }
        private System.Void DeserializeDataSetData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat) { }
        private System.Void SerializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void DeserializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void SerializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void DeserializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void FailedEnableConstraints() { }
        private System.Boolean get_CaseSensitive() { }
        private System.Void set_CaseSensitive(System.Boolean value) { }
        private System.Boolean get_EnforceConstraints() { }
        private System.Void set_EnforceConstraints(System.Boolean value) { }
        private System.Void RestoreEnforceConstraints(System.Boolean value) { }
        private System.Void EnableConstraints() { }
        private System.String get_DataSetName() { }
        private System.Void set_DataSetName(System.String value) { }
        private System.String get_Namespace() { }
        private System.Void set_Namespace(System.String value) { }
        private System.String get_Prefix() { }
        private System.Void set_Prefix(System.String value) { }
        private System.Data.PropertyCollection get_ExtendedProperties() { }
        private System.Globalization.CultureInfo get_Locale() { }
        private System.Void set_Locale(System.Globalization.CultureInfo value) { }
        private System.Void SetLocaleValue(System.Globalization.CultureInfo value, System.Boolean userSet) { }
        private System.Boolean ShouldSerializeLocale() { }
        private System.ComponentModel.ISite get_Site() { }
        private System.Data.DataRelationCollection get_Relations() { }
        private System.Data.DataTableCollection get_Tables() { }
        private System.Void Clear() { }
        private System.Data.DataSet Clone() { }
        private System.Int32 EstimatedXmlStringSize() { }
        private System.String GetRemotingDiffGram(System.Data.DataTable table) { }
        private System.String GetXmlSchemaForRemoting(System.Data.DataTable table) { }
        private System.Void ReadXmlSchema(System.Xml.XmlReader reader) { }
        private System.Void ReadXmlSchema(System.Xml.XmlReader reader, System.Boolean denyResolving) { }
        private System.Boolean MoveToElement(System.Xml.XmlReader reader, System.Int32 depth) { }
        private System.Void MoveToElement(System.Xml.XmlReader reader) { }
        private System.Void ReadEndElement(System.Xml.XmlReader reader) { }
        private System.Void ReadXSDSchema(System.Xml.XmlReader reader, System.Boolean denyResolving) { }
        private System.Void ReadXDRSchema(System.Xml.XmlReader reader) { }
        private System.Void WriteXmlSchema(System.Xml.XmlWriter writer, System.Data.SchemaFormat schemaFormat, System.Converter<System.Type,System.String> multipleTargetConverter) { }
        private System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader) { }
        private System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Boolean denyResolving) { }
        private System.Void InferSchema(System.Xml.XmlDocument xdoc, System.String[] excludedNamespaces, System.Data.XmlReadMode mode) { }
        private System.Boolean IsEmpty() { }
        private System.Void ReadXmlDiffgram(System.Xml.XmlReader reader) { }
        private System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode) { }
        private System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, System.Boolean denyResolving) { }
        private System.Void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode) { }
        private System.Void Merge(System.Data.DataSet dataSet) { }
        private System.Void Merge(System.Data.DataSet dataSet, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        private System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        private System.Void OnMergeFailed(System.Data.MergeFailedEventArgs mfevent) { }
        private System.Void RaiseMergeFailed(System.Data.DataTable table, System.String conflict, System.Data.MissingSchemaAction missingSchemaAction) { }
        private System.Void OnDataRowCreated(System.Data.DataRow row) { }
        private System.Void OnClearFunctionCalled(System.Data.DataTable table) { }
        private System.Void OnRemoveTable(System.Data.DataTable table) { }
        private System.Void OnRemovedTable(System.Data.DataTable table) { }
        private System.Void OnRemoveRelation(System.Data.DataRelation relation) { }
        private System.Void OnRemoveRelationHack(System.Data.DataRelation relation) { }
        private System.Void RaisePropertyChanging(System.String name) { }
        private System.Data.DataTable[] TopLevelTables() { }
        private System.Data.DataTable[] TopLevelTables(System.Boolean forSchema) { }
        private System.Void Reset() { }
        private System.Boolean ValidateCaseConstraint() { }
        private System.Boolean ValidateLocaleConstraint() { }
        private System.Void ReadXmlSerializable(System.Xml.XmlReader reader) { }
        private System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.String get_MainTableName() { }
        private System.Void set_MainTableName(System.String value) { }
        private System.Int32 get_ObjectID() { }

    }

    // TypeToken: 0x2000038
    public struct DataSetDateTime
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.DataSetDateTime Local;        // 0x0
        public static System.Data.DataSetDateTime Unspecified;        // 0x0
        public static System.Data.DataSetDateTime UnspecifiedLocal;        // 0x0
        public static System.Data.DataSetDateTime Utc;        // 0x0

    }

    // TypeToken: 0x2000039
    public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable
    {
        // Fields
        private System.Data.DataSet _dataSet;        // 0x20
        private System.Data.DataView _defaultView;        // 0x28
        private System.Int64 _nextRowID;        // 0x30
        private readonly System.Data.DataRowCollection _rowCollection;        // 0x38
        private readonly System.Data.DataColumnCollection _columnCollection;        // 0x40
        private readonly System.Data.ConstraintCollection _constraintCollection;        // 0x48
        private System.Int32 _elementColumnCount;        // 0x50
        private System.Data.DataRelationCollection _parentRelationsCollection;        // 0x58
        private System.Data.DataRelationCollection _childRelationsCollection;        // 0x60
        private readonly System.Data.RecordManager _recordManager;        // 0x68
        private readonly System.Collections.Generic.List<System.Data.Index> _indexes;        // 0x70
        private System.Collections.Generic.List<System.Data.Index> _shadowIndexes;        // 0x78
        private System.Int32 _shadowCount;        // 0x80
        private System.Data.PropertyCollection _extendedProperties;        // 0x88
        private System.String _tableName;        // 0x90
        private System.String _tableNamespace;        // 0x98
        private System.String _tablePrefix;        // 0xA0
        private System.Data.DataExpression _displayExpression;        // 0xA8
        private System.Boolean _fNestedInDataset;        // 0xB0
        private System.Globalization.CultureInfo _culture;        // 0xB8
        private System.Boolean _cultureUserSet;        // 0xC0
        private System.Globalization.CompareInfo _compareInfo;        // 0xC8
        private System.Globalization.CompareOptions _compareFlags;        // 0xD0
        private System.IFormatProvider _formatProvider;        // 0xD8
        private System.StringComparer _hashCodeProvider;        // 0xE0
        private System.Boolean _caseSensitive;        // 0xE8
        private System.Boolean _caseSensitiveUserSet;        // 0xE9
        private System.String _encodedTableName;        // 0xF0
        private System.Data.DataColumn _xmlText;        // 0xF8
        private System.Data.DataColumn _colUnique;        // 0x100
        private System.Decimal _minOccurs;        // 0x108
        private System.Decimal _maxOccurs;        // 0x118
        private System.Boolean _repeatableElement;        // 0x128
        private System.Object _typeName;        // 0x130
        private System.Data.UniqueConstraint _primaryKey;        // 0x138
        private System.Data.IndexField[] _primaryIndex;        // 0x140
        private System.Data.DataColumn[] _delayedSetPrimaryKey;        // 0x148
        private System.Data.Index _loadIndex;        // 0x150
        private System.Data.Index _loadIndexwithOriginalAdded;        // 0x158
        private System.Data.Index _loadIndexwithCurrentDeleted;        // 0x160
        private System.Int32 _suspendIndexEvents;        // 0x168
        private System.Boolean _inDataLoad;        // 0x16C
        private System.Boolean _schemaLoading;        // 0x16D
        private System.Boolean _enforceConstraints;        // 0x16E
        private System.Boolean _suspendEnforceConstraints;        // 0x16F
        protected internal System.Boolean fInitInProgress;        // 0x170
        private System.Boolean _inLoad;        // 0x171
        private System.Boolean _fInLoadDiffgram;        // 0x172
        private System.Byte _isTypedDataTable;        // 0x173
        private System.Data.DataRow[] _emptyDataRowArray;        // 0x178
        private System.ComponentModel.PropertyDescriptorCollection _propertyDescriptorCollectionCache;        // 0x180
        private System.Data.DataRelation[] _nestedParentRelations;        // 0x188
        private System.Collections.Generic.List<System.Data.DataColumn> _dependentColumns;        // 0x190
        private System.Boolean _mergingData;        // 0x198
        private System.Data.DataRowChangeEventHandler _onRowChangedDelegate;        // 0x1A0
        private System.Data.DataRowChangeEventHandler _onRowChangingDelegate;        // 0x1A8
        private System.Data.DataRowChangeEventHandler _onRowDeletingDelegate;        // 0x1B0
        private System.Data.DataRowChangeEventHandler _onRowDeletedDelegate;        // 0x1B8
        private System.Data.DataColumnChangeEventHandler _onColumnChangedDelegate;        // 0x1C0
        private System.Data.DataColumnChangeEventHandler _onColumnChangingDelegate;        // 0x1C8
        private System.Data.DataTableClearEventHandler _onTableClearingDelegate;        // 0x1D0
        private System.Data.DataTableClearEventHandler _onTableClearedDelegate;        // 0x1D8
        private System.Data.DataTableNewRowEventHandler _onTableNewRowDelegate;        // 0x1E0
        private System.ComponentModel.PropertyChangedEventHandler _onPropertyChangingDelegate;        // 0x1E8
        private readonly System.Data.DataRowBuilder _rowBuilder;        // 0x1F0
        private readonly System.Collections.Generic.List<System.Data.DataView> _delayedViews;        // 0x1F8
        private readonly System.Collections.Generic.List<System.Data.DataViewListener> _dataViewListeners;        // 0x200
        private System.Collections.Hashtable _rowDiffId;        // 0x208
        private readonly System.Threading.ReaderWriterLockSlim _indexesLock;        // 0x210
        private System.Int32 _ukColumnPositionForInference;        // 0x218
        private System.Data.SerializationFormat _remotingFormat;        // 0x21C
        private static System.Int32 s_objectTypeCount;        // 0x0
        private readonly System.Int32 _objectID;        // 0x220

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String tableName) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void SerializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable, System.Data.SerializationFormat remotingFormat) { }
        private System.Void DeserializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable, System.Data.SerializationFormat remotingFormat) { }
        private System.Void SerializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable) { }
        private System.Void DeserializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable) { }
        private System.Void SerializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex, System.Boolean allConstraints) { }
        private System.Void DeserializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex, System.Boolean allConstraints) { }
        private System.Void SerializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex) { }
        private System.Void DeserializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex) { }
        private System.Void SerializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex) { }
        private System.Void DeserializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex) { }
        private System.Data.DataRowState ConvertToRowState(System.Collections.BitArray bitStates, System.Int32 bitIndex) { }
        private System.Void GetRowAndColumnErrors(System.Int32 rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors) { }
        private System.Void ConvertToRowError(System.Int32 rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors) { }
        private System.Boolean get_CaseSensitive() { }
        private System.Void set_CaseSensitive(System.Boolean value) { }
        private System.Boolean get_AreIndexEventsSuspended() { }
        private System.Void RestoreIndexEvents(System.Boolean forceReset) { }
        private System.Void SuspendIndexEvents() { }
        private System.Boolean get_IsTypedDataTable() { }
        private System.Boolean SetCaseSensitiveValue(System.Boolean isCaseSensitive, System.Boolean userSet, System.Boolean resetIndexes) { }
        private System.Boolean ShouldSerializeCaseSensitive() { }
        private System.Boolean get_SelfNested() { }
        private System.Collections.Generic.List<System.Data.Index> get_LiveIndexes() { }
        private System.Data.SerializationFormat get_RemotingFormat() { }
        private System.Void set_RemotingFormat(System.Data.SerializationFormat value) { }
        private System.Int32 get_UKColumnPositionForInference() { }
        private System.Void set_UKColumnPositionForInference(System.Int32 value) { }
        private System.Data.DataRelationCollection get_ChildRelations() { }
        private System.Data.DataColumnCollection get_Columns() { }
        private System.Globalization.CompareInfo get_CompareInfo() { }
        private System.Data.ConstraintCollection get_Constraints() { }
        private System.Void ResetConstraints() { }
        private System.Data.DataSet get_DataSet() { }
        private System.Void SetDataSet(System.Data.DataSet dataSet) { }
        private System.String get_DisplayExpressionInternal() { }
        private System.Boolean get_EnforceConstraints() { }
        private System.Void set_EnforceConstraints(System.Boolean value) { }
        private System.Boolean get_SuspendEnforceConstraints() { }
        private System.Void set_SuspendEnforceConstraints(System.Boolean value) { }
        private System.Void EnableConstraints() { }
        private System.Data.PropertyCollection get_ExtendedProperties() { }
        private System.IFormatProvider get_FormatProvider() { }
        private System.Globalization.CultureInfo get_Locale() { }
        private System.Void set_Locale(System.Globalization.CultureInfo value) { }
        private System.Boolean SetLocaleValue(System.Globalization.CultureInfo culture, System.Boolean userSet, System.Boolean resetIndexes) { }
        private System.Boolean ShouldSerializeLocale() { }
        private System.Int32 get_MinimumCapacity() { }
        private System.Void set_MinimumCapacity(System.Int32 value) { }
        private System.Int32 get_RecordCapacity() { }
        private System.Int32 get_ElementColumnCount() { }
        private System.Void set_ElementColumnCount(System.Int32 value) { }
        private System.Data.DataRelationCollection get_ParentRelations() { }
        private System.Boolean get_MergingData() { }
        private System.Void set_MergingData(System.Boolean value) { }
        private System.Data.DataRelation[] get_NestedParentRelations() { }
        private System.Boolean get_SchemaLoading() { }
        private System.Void CacheNestedParent() { }
        private System.Data.DataRelation[] FindNestedParentRelations() { }
        private System.Int32 get_NestedParentsCount() { }
        private System.Data.DataColumn[] get_PrimaryKey() { }
        private System.Void set_PrimaryKey(System.Data.DataColumn[] value) { }
        private System.Data.DataRowCollection get_Rows() { }
        private System.String get_TableName() { }
        private System.Void set_TableName(System.String value) { }
        private System.String get_EncodedTableName() { }
        private System.String GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables) { }
        private System.String get_Namespace() { }
        private System.Void set_Namespace(System.String value) { }
        private System.Boolean IsNamespaceInherited() { }
        private System.Void CheckCascadingNamespaceConflict(System.String realNamespace) { }
        private System.Void CheckNamespaceValidityForNestedRelations(System.String realNamespace) { }
        private System.Void CheckNamespaceValidityForNestedParentRelations(System.String ns, System.Data.DataTable parentTable) { }
        private System.Void DoRaiseNamespaceChange() { }
        private System.String get_Prefix() { }
        private System.Void set_Prefix(System.String value) { }
        private System.Data.DataColumn get_XmlText() { }
        private System.Void set_XmlText(System.Data.DataColumn value) { }
        private System.Decimal get_MaxOccurs() { }
        private System.Void set_MaxOccurs(System.Decimal value) { }
        private System.Decimal get_MinOccurs() { }
        private System.Void set_MinOccurs(System.Decimal value) { }
        private System.Void SetKeyValues(System.Data.DataKey key, System.Object[] keyValues, System.Int32 record) { }
        private System.Data.DataRow FindByIndex(System.Data.Index ndx, System.Object[] key) { }
        private System.Data.DataRow FindMergeTarget(System.Data.DataRow row, System.Data.DataKey key, System.Data.Index ndx) { }
        private System.Void SetMergeRecords(System.Data.DataRow row, System.Int32 newRecord, System.Int32 oldRecord, System.Data.DataRowAction action) { }
        private System.Data.DataRow MergeRow(System.Data.DataRow row, System.Data.DataRow targetRow, System.Boolean preserveChanges, System.Data.Index idxSearch) { }
        private System.Data.DataTable CreateInstance() { }
        private System.Data.DataTable Clone() { }
        private System.Data.DataTable Clone(System.Data.DataSet cloneDS) { }
        private System.Data.DataTable IncrementalCloneTo(System.Data.DataTable sourceTable, System.Data.DataTable targetTable) { }
        private System.Data.DataTable CloneHierarchy(System.Data.DataTable sourceTable, System.Data.DataSet ds, System.Collections.Hashtable visitedMap) { }
        private System.Data.DataTable CloneTo(System.Data.DataTable clone, System.Data.DataSet cloneDS, System.Boolean skipExpressionColumns) { }
        private System.ComponentModel.ISite get_Site() { }
        private System.Void AddRow(System.Data.DataRow row, System.Int32 proposedID) { }
        private System.Void InsertRow(System.Data.DataRow row, System.Int32 proposedID, System.Int32 pos) { }
        private System.Void InsertRow(System.Data.DataRow row, System.Int64 proposedID, System.Int32 pos, System.Boolean fireEvent) { }
        private System.Void CheckNotModifying(System.Data.DataRow row) { }
        private System.Void Clear() { }
        private System.Void Clear(System.Boolean clearAll) { }
        private System.Void CascadeAll(System.Data.DataRow row, System.Data.DataRowAction action) { }
        private System.Void CommitRow(System.Data.DataRow row) { }
        private System.Int32 Compare(System.String s1, System.String s2) { }
        private System.Int32 Compare(System.String s1, System.String s2, System.Globalization.CompareInfo comparer) { }
        private System.Int32 IndexOf(System.String s1, System.String s2) { }
        private System.Boolean IsSuffix(System.String s1, System.String s2) { }
        private System.Object Compute(System.String expression, System.String filter) { }
        private System.Void DeleteRow(System.Data.DataRow row) { }
        private System.String FormatSortString(System.Data.IndexField[] indexDesc) { }
        private System.Void FreeRecord(System.Int32& record) { }
        private System.Data.Index GetIndex(System.String sort, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter) { }
        private System.Data.Index GetIndex(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter) { }
        private System.Collections.Generic.List<System.Data.DataViewListener> GetListeners() { }
        private System.Int32 GetSpecialHashCode(System.String name) { }
        private System.Void InsertRow(System.Data.DataRow row, System.Int64 proposedID) { }
        private System.Int32 NewRecord() { }
        private System.Int32 NewUninitializedRecord() { }
        private System.Int32 NewRecord(System.Int32 sourceRecord) { }
        private System.Data.DataRow NewEmptyRow() { }
        private System.Data.DataRow NewUninitializedRow() { }
        private System.Data.DataRow NewRow() { }
        private System.Data.DataRow CreateEmptyRow() { }
        private System.Void NewRowCreated(System.Data.DataRow row) { }
        private System.Data.DataRow NewRow(System.Int32 record) { }
        private System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) { }
        private System.Type GetRowType() { }
        private System.Data.DataRow[] NewRowArray(System.Int32 size) { }
        private System.Boolean get_NeedColumnChangeEvents() { }
        private System.Void OnColumnChanging(System.Data.DataColumnChangeEventArgs e) { }
        private System.Void OnColumnChanged(System.Data.DataColumnChangeEventArgs e) { }
        private System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        private System.Void OnRemoveColumnInternal(System.Data.DataColumn column) { }
        private System.Void OnRemoveColumn(System.Data.DataColumn column) { }
        private System.Data.DataRowChangeEventArgs OnRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction) { }
        private System.Data.DataRowChangeEventArgs OnRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction) { }
        private System.Void OnRowChanged(System.Data.DataRowChangeEventArgs e) { }
        private System.Void OnRowChanging(System.Data.DataRowChangeEventArgs e) { }
        private System.Void OnRowDeleting(System.Data.DataRowChangeEventArgs e) { }
        private System.Void OnRowDeleted(System.Data.DataRowChangeEventArgs e) { }
        private System.Void OnTableCleared(System.Data.DataTableClearEventArgs e) { }
        private System.Void OnTableClearing(System.Data.DataTableClearEventArgs e) { }
        private System.Void OnTableNewRow(System.Data.DataTableNewRowEventArgs e) { }
        private System.Data.IndexField[] ParseSortString(System.String sortString) { }
        private System.Void RaisePropertyChanging(System.String name) { }
        private System.Void RecordChanged(System.Int32 record) { }
        private System.Void RecordChanged(System.Int32[] oldIndex, System.Int32[] newIndex) { }
        private System.Void RecordStateChanged(System.Int32 record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState) { }
        private System.Void RecordStateChanged(System.Int32 record1, System.Data.DataViewRowState oldState1, System.Data.DataViewRowState newState1, System.Int32 record2, System.Data.DataViewRowState oldState2, System.Data.DataViewRowState newState2) { }
        private System.Int32[] RemoveRecordFromIndexes(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Int32[] InsertRecordToIndexes(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Void SilentlySetValue(System.Data.DataRow dr, System.Data.DataColumn dc, System.Data.DataRowVersion version, System.Object newValue) { }
        private System.Void RemoveRow(System.Data.DataRow row, System.Boolean check) { }
        private System.Void Reset() { }
        private System.Void ResetIndexes() { }
        private System.Void ResetInternalIndexes(System.Data.DataColumn column) { }
        private System.Void RollbackRow(System.Data.DataRow row) { }
        private System.Data.DataRowChangeEventArgs RaiseRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction) { }
        private System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction) { }
        private System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction, System.Boolean fireEvent) { }
        private System.Data.DataRow[] Select(System.String filterExpression, System.String sort, System.Data.DataViewRowState recordStates) { }
        private System.Void SetNewRecord(System.Data.DataRow row, System.Int32 proposedRecord, System.Data.DataRowAction action, System.Boolean isInMerge, System.Boolean fireEvent, System.Boolean suppressEnsurePropertyChanged) { }
        private System.Void SetNewRecordWorker(System.Data.DataRow row, System.Int32 proposedRecord, System.Data.DataRowAction action, System.Boolean isInMerge, System.Boolean suppressEnsurePropertyChanged, System.Int32 position, System.Boolean fireEvent, System.Exception& deferredException) { }
        private System.Void SetOldRecord(System.Data.DataRow row, System.Int32 proposedRecord) { }
        private System.Void RestoreShadowIndexes() { }
        private System.Void SetShadowIndexes() { }
        private System.Void ShadowIndexCopy() { }
        private System.String ToString() { }
        private System.Boolean UpdatingCurrent(System.Data.DataRow row, System.Data.DataRowAction action) { }
        private System.Data.DataColumn AddUniqueKey(System.Int32 position) { }
        private System.Data.DataColumn AddUniqueKey() { }
        private System.Data.DataColumn AddForeignKey(System.Data.DataColumn parentKey) { }
        private System.Void UpdatePropertyDescriptorCollectionCache() { }
        private System.ComponentModel.PropertyDescriptorCollection GetPropertyDescriptorCollection(System.Attribute[] attributes) { }
        private System.Xml.XmlQualifiedName get_TypeName() { }
        private System.Void set_TypeName(System.Xml.XmlQualifiedName value) { }
        private System.Void Merge(System.Data.DataTable table) { }
        private System.Void Merge(System.Data.DataTable table, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        private System.Void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode, System.Boolean writeHierarchy) { }
        private System.Boolean CheckForClosureOnExpressions(System.Data.DataTable dt, System.Boolean writeHierarchy) { }
        private System.Boolean CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList) { }
        private System.Void WriteXmlSchema(System.Xml.XmlWriter writer, System.Boolean writeHierarchy) { }
        private System.Void RestoreConstraint(System.Boolean originalEnforceConstraint) { }
        private System.Boolean IsEmptyXml(System.Xml.XmlReader reader) { }
        private System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, System.Boolean denyResolving) { }
        private System.Void ReadEndElement(System.Xml.XmlReader reader) { }
        private System.Void ReadXDRSchema(System.Xml.XmlReader reader) { }
        private System.Boolean MoveToElement(System.Xml.XmlReader reader, System.Int32 depth) { }
        private System.Void ReadXmlDiffgram(System.Xml.XmlReader reader) { }
        private System.Void ReadXSDSchema(System.Xml.XmlReader reader, System.Boolean denyResolving) { }
        private System.Void ReadXmlSchema(System.Xml.XmlReader reader, System.Boolean denyResolving) { }
        private System.Void CreateTableList(System.Data.DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList) { }
        private System.Void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList) { }
        private System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Xml.Schema.XmlSchema GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Void ReadXmlSerializable(System.Xml.XmlReader reader) { }
        private System.Collections.Hashtable get_RowDiffId() { }
        private System.Int32 get_ObjectID() { }
        private System.Void AddDependentColumn(System.Data.DataColumn expressionColumn) { }
        private System.Void RemoveDependentColumn(System.Data.DataColumn expressionColumn) { }
        private System.Void EvaluateExpressions() { }
        private System.Void EvaluateExpressions(System.Data.DataRow row, System.Data.DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows) { }
        private System.Void EvaluateExpressions(System.Data.DataColumn column) { }
        private System.Void EvaluateDependentExpressions(System.Data.DataColumn column) { }
        private System.Void EvaluateDependentExpressions(System.Collections.Generic.List<System.Data.DataColumn> columns, System.Data.DataRow row, System.Data.DataRowVersion version, System.Collections.Generic.List<System.Data.DataRow> cachedRows) { }

    }

    // TypeToken: 0x200003C
    public class DataTableClearEventArgs : EventArgs
    {
        // Fields
        private readonly System.Data.DataTable <Table>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Data.DataTable dataTable) { }

    }

    // TypeToken: 0x200003D
    public class DataTableClearEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Data.DataTableClearEventArgs e) { }

    }

    // TypeToken: 0x200003E
    public class DataTableCollection : InternalDataCollectionBase
    {
        // Fields
        private readonly System.Data.DataSet _dataSet;        // 0x10
        private readonly System.Collections.ArrayList _list;        // 0x18
        private System.Int32 _defaultNameIndex;        // 0x20
        private System.Data.DataTable[] _delayedAddRangeTables;        // 0x28
        private System.ComponentModel.CollectionChangeEventHandler _onCollectionChangedDelegate;        // 0x30
        private System.ComponentModel.CollectionChangeEventHandler _onCollectionChangingDelegate;        // 0x38
        private static System.Int32 s_objectTypeCount;        // 0x0
        private readonly System.Int32 _objectID;        // 0x40

        // Methods
        private System.Void .ctor(System.Data.DataSet dataSet) { }
        private System.Collections.ArrayList get_List() { }
        private System.Int32 get_ObjectID() { }
        private System.Data.DataTable get_Item(System.Int32 index) { }
        private System.Data.DataTable get_Item(System.String name) { }
        private System.Data.DataTable get_Item(System.String name, System.String tableNamespace) { }
        private System.Data.DataTable GetTable(System.String name, System.String ns) { }
        private System.Data.DataTable GetTableSmart(System.String name, System.String ns) { }
        private System.Void Add(System.Data.DataTable table) { }
        private System.Void ArrayAdd(System.Data.DataTable table) { }
        private System.String AssignName() { }
        private System.Void BaseAdd(System.Data.DataTable table) { }
        private System.Void BaseGroupSwitch(System.Data.DataTable[] oldArray, System.Int32 oldLength, System.Data.DataTable[] newArray, System.Int32 newLength) { }
        private System.Void BaseRemove(System.Data.DataTable table) { }
        private System.Boolean CanRemove(System.Data.DataTable table, System.Boolean fThrowException) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.String name) { }
        private System.Boolean Contains(System.String name, System.String tableNamespace, System.Boolean checkProperty, System.Boolean caseSensitive) { }
        private System.Boolean Contains(System.String name, System.Boolean caseSensitive) { }
        private System.Int32 IndexOf(System.Data.DataTable table) { }
        private System.Int32 IndexOf(System.String tableName) { }
        private System.Int32 IndexOf(System.String tableName, System.String tableNamespace, System.Boolean chekforNull) { }
        private System.Void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList) { }
        private System.Int32 InternalIndexOf(System.String tableName) { }
        private System.Int32 InternalIndexOf(System.String tableName, System.String tableNamespace) { }
        private System.String MakeName(System.Int32 index) { }
        private System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        private System.Void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        private System.Void RegisterName(System.String name, System.String tbNamespace) { }
        private System.Void Remove(System.Data.DataTable table) { }
        private System.Void UnregisterName(System.String name) { }

    }

    // TypeToken: 0x200003F
    public class DataTableNewRowEventArgs : EventArgs
    {
        // Fields
        private readonly System.Data.DataRow <Row>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Data.DataRow dataRow) { }

    }

    // TypeToken: 0x2000040
    public class DataTableNewRowEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Data.DataTableNewRowEventArgs e) { }

    }

    // TypeToken: 0x2000041
    public class DataTableTypeConverter : ReferenceConverter
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { }

    }

    // TypeToken: 0x2000042
    public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable
    {
        // Fields
        private System.Data.DataViewManager _dataViewManager;        // 0x20
        private System.Data.DataTable _table;        // 0x28
        private System.Boolean _locked;        // 0x30
        private System.Data.Index _index;        // 0x38
        private System.Collections.Generic.Dictionary<System.String,System.Data.Index> _findIndexes;        // 0x40
        private System.String _sort;        // 0x48
        private System.Comparison<System.Data.DataRow> _comparison;        // 0x50
        private System.Data.IFilter _rowFilter;        // 0x58
        private System.Data.DataViewRowState _recordStates;        // 0x60
        private System.Boolean _shouldOpen;        // 0x64
        private System.Boolean _open;        // 0x65
        private System.Boolean _allowNew;        // 0x66
        private System.Boolean _allowEdit;        // 0x67
        private System.Boolean _allowDelete;        // 0x68
        private System.Boolean _applyDefaultSort;        // 0x69
        private System.Data.DataRow _addNewRow;        // 0x70
        private System.ComponentModel.ListChangedEventArgs _addNewMoved;        // 0x78
        private System.ComponentModel.ListChangedEventHandler _onListChanged;        // 0x80
        private static System.ComponentModel.ListChangedEventArgs s_resetEventArgs;        // 0x0
        private System.Data.DataViewRowState _delayedRecordStates;        // 0x88
        private System.Boolean _fEndInitInProgress;        // 0x8C
        private System.Collections.Generic.Dictionary<System.Data.DataRow,System.Data.DataRowView> _rowViewCache;        // 0x90
        private readonly System.Collections.Generic.Dictionary<System.Data.DataRow,System.Data.DataRowView> _rowViewBuffer;        // 0x98
        private System.Data.DataViewListener _dvListener;        // 0xA0
        private static System.Int32 s_objectTypeCount;        // 0x8
        private readonly System.Int32 _objectID;        // 0xA8

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.Boolean locked) { }
        private System.Boolean get_AllowDelete() { }
        private System.Boolean get_AllowNew() { }
        private System.Int32 get_Count() { }
        private System.Int32 get_CountFromIndex() { }
        private System.Data.DataViewManager get_DataViewManager() { }
        private System.Boolean get_IsOpen() { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Data.DataViewRowState get_RowStateFilter() { }
        private System.String get_Sort() { }
        private System.Comparison<System.Data.DataRow> get_SortComparison() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Data.DataTable get_Table() { }
        private System.Object System.Collections.IList.get_Item(System.Int32 recordIndex) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 recordIndex, System.Object value) { }
        private System.Data.DataRowView get_Item(System.Int32 recordIndex) { }
        private System.Data.DataRowView AddNew() { }
        private System.Void CheckOpen() { }
        private System.Void Close() { }
        private System.Void CopyTo(System.Array array, System.Int32 index) { }
        private System.Void CopyTo(System.Data.DataRowView[] array, System.Int32 index) { }
        private System.Void Delete(System.Int32 index) { }
        private System.Void Delete(System.Data.DataRow row) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void FinishAddNew(System.Boolean success) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Boolean System.Collections.IList.get_IsReadOnly() { }
        private System.Boolean System.Collections.IList.get_IsFixedSize() { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Void System.Collections.IList.Clear() { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Int32 IndexOf(System.Data.DataRowView rowview) { }
        private System.Int32 IndexOfDataRowView(System.Data.DataRowView rowview) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Void System.Collections.IList.RemoveAt(System.Int32 index) { }
        private System.Data.IFilter GetFilter() { }
        private System.Int32 GetRecord(System.Int32 recordIndex) { }
        private System.Data.DataRow GetRow(System.Int32 index) { }
        private System.Data.DataRowView GetRowView(System.Int32 record) { }
        private System.Data.DataRowView GetRowView(System.Data.DataRow dr) { }
        private System.Void IndexListChanged(System.Object sender, System.ComponentModel.ListChangedEventArgs e) { }
        private System.Void IndexListChangedInternal(System.ComponentModel.ListChangedEventArgs e) { }
        private System.Void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, System.Boolean trackAddRemove) { }
        private System.Void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
        private System.Void Reset() { }
        private System.Void ResetRowViewCache() { }
        private System.Void SetDataViewManager(System.Data.DataViewManager dataViewManager) { }
        private System.Void SetIndex(System.String newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter) { }
        private System.Void SetIndex2(System.String newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter, System.Boolean fireEvent) { }
        private System.Void UpdateIndex() { }
        private System.Void UpdateIndex(System.Boolean force) { }
        private System.Void UpdateIndex(System.Boolean force, System.Boolean fireEvent) { }
        private System.Void ChildRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
        private System.Void ParentRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
        private System.Void ColumnCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
        private System.Void ColumnCollectionChangedInternal(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
        private System.Int32 get_ObjectID() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000044
    public class DataViewListener
    {
        // Fields
        private readonly System.WeakReference _dvWeak;        // 0x10
        private System.Data.DataTable _table;        // 0x18
        private System.Data.Index _index;        // 0x20
        private readonly System.Int32 _objectID;        // 0x28

        // Methods
        private System.Void .ctor(System.Data.DataView dv) { }
        private System.Void ChildRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
        private System.Void ParentRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
        private System.Void ColumnCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
        private System.Void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, System.Boolean trackAddRemove) { }
        private System.Void IndexListChanged(System.ComponentModel.ListChangedEventArgs e) { }
        private System.Void RegisterMetaDataEvents(System.Data.DataTable table) { }
        private System.Void UnregisterMetaDataEvents() { }
        private System.Void UnregisterMetaDataEvents(System.Boolean updateListeners) { }
        private System.Void RegisterListChangedEvent(System.Data.Index index) { }
        private System.Void UnregisterListChangedEvent() { }
        private System.Void CleanUp(System.Boolean updateListeners) { }
        private System.Void RegisterListener(System.Data.DataTable table) { }

    }

    // TypeToken: 0x2000045
    public class DataViewManager : MarshalByValueComponent
    {
        // Fields
        private System.Data.DataViewSettingCollection _dataViewSettingsCollection;        // 0x20
        private System.Int32 _nViews;        // 0x28
        private static System.NotSupportedException s_notSupported;        // 0x0

        // Methods
        private System.Data.DataViewSettingCollection get_DataViewSettings() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000046
    public struct DataViewRowState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.DataViewRowState None;        // 0x0
        public static System.Data.DataViewRowState Unchanged;        // 0x0
        public static System.Data.DataViewRowState Added;        // 0x0
        public static System.Data.DataViewRowState Deleted;        // 0x0
        public static System.Data.DataViewRowState ModifiedCurrent;        // 0x0
        public static System.Data.DataViewRowState ModifiedOriginal;        // 0x0
        public static System.Data.DataViewRowState OriginalRows;        // 0x0
        public static System.Data.DataViewRowState CurrentRows;        // 0x0

    }

    // TypeToken: 0x2000047
    public class DataViewSetting
    {
        // Fields
        private System.Data.DataViewManager _dataViewManager;        // 0x10
        private System.Data.DataTable _table;        // 0x18
        private System.String _sort;        // 0x20
        private System.String _rowFilter;        // 0x28
        private System.Data.DataViewRowState _rowStateFilter;        // 0x30
        private System.Boolean _applyDefaultSort;        // 0x34

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_ApplyDefaultSort() { }
        private System.Void SetDataViewManager(System.Data.DataViewManager dataViewManager) { }
        private System.Void SetDataTable(System.Data.DataTable table) { }
        private System.String get_RowFilter() { }
        private System.Data.DataViewRowState get_RowStateFilter() { }
        private System.String get_Sort() { }

    }

    // TypeToken: 0x2000048
    public class DataViewSettingCollection
    {
        // Fields
        private readonly System.Data.DataViewManager _dataViewManager;        // 0x10
        private readonly System.Collections.Hashtable _list;        // 0x18

        // Methods
        private System.Data.DataViewSetting get_Item(System.Data.DataTable table) { }
        private System.Void set_Item(System.Data.DataTable table, System.Data.DataViewSetting value) { }
        private System.Void Remove(System.Data.DataTable table) { }

    }

    // TypeToken: 0x2000049
    public class DefaultValueTypeConverter : StringConverter
    {
        // Methods
        private System.Void .ctor() { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }
        private System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value) { }

    }

    // TypeToken: 0x200004A
    public struct Aggregate
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.Aggregate None;        // 0x0
        public static System.Data.Aggregate Sum;        // 0x0
        public static System.Data.Aggregate Avg;        // 0x0
        public static System.Data.Aggregate Min;        // 0x0
        public static System.Data.Aggregate Max;        // 0x0
        public static System.Data.Aggregate Count;        // 0x0
        public static System.Data.Aggregate StDev;        // 0x0
        public static System.Data.Aggregate Var;        // 0x0

    }

    // TypeToken: 0x200004B
    public class AggregateNode : ExpressionNode
    {
        // Fields
        private readonly System.Data.AggregateType _type;        // 0x18
        private readonly System.Data.Aggregate _aggregate;        // 0x1C
        private readonly System.Boolean _local;        // 0x20
        private readonly System.String _relationName;        // 0x28
        private readonly System.String _columnName;        // 0x30
        private System.Data.DataTable _childTable;        // 0x38
        private System.Data.DataColumn _column;        // 0x40
        private System.Data.DataRelation _relation;        // 0x48

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.Data.FunctionId aggregateType, System.String columnName) { }
        private System.Void .ctor(System.Data.DataTable table, System.Data.FunctionId aggregateType, System.String columnName, System.Boolean local, System.String relationName) { }
        private System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }
        private System.Void Bind(System.Data.DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list) { }
        private System.Object Eval() { }
        private System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Object Eval(System.Int32[] records) { }
        private System.Boolean IsConstant() { }
        private System.Boolean IsTableConstant() { }
        private System.Boolean HasLocalAggregate() { }
        private System.Boolean HasRemoteAggregate() { }
        private System.Boolean DependsOn(System.Data.DataColumn column) { }
        private System.Data.ExpressionNode Optimize() { }

    }

    // TypeToken: 0x200004C
    public class BinaryNode : ExpressionNode
    {
        // Fields
        private System.Int32 _op;        // 0x18
        private System.Data.ExpressionNode _left;        // 0x20
        private System.Data.ExpressionNode _right;        // 0x28

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.Int32 op, System.Data.ExpressionNode left, System.Data.ExpressionNode right) { }
        private System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }
        private System.Object Eval() { }
        private System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Object Eval(System.Int32[] recordNos) { }
        private System.Boolean IsConstant() { }
        private System.Boolean IsTableConstant() { }
        private System.Boolean HasLocalAggregate() { }
        private System.Boolean HasRemoteAggregate() { }
        private System.Boolean DependsOn(System.Data.DataColumn column) { }
        private System.Data.ExpressionNode Optimize() { }
        private System.Void SetTypeMismatchError(System.Int32 op, System.Type left, System.Type right) { }
        private System.Object Eval(System.Data.ExpressionNode expr, System.Data.DataRow row, System.Data.DataRowVersion version, System.Int32[] recordNos) { }
        private System.Int32 BinaryCompare(System.Object vLeft, System.Object vRight, System.Data.Common.StorageType resultType, System.Int32 op) { }
        private System.Int32 BinaryCompare(System.Object vLeft, System.Object vRight, System.Data.Common.StorageType resultType, System.Int32 op, System.Globalization.CompareInfo comparer) { }
        private System.Object EvalBinaryOp(System.Int32 op, System.Data.ExpressionNode left, System.Data.ExpressionNode right, System.Data.DataRow row, System.Data.DataRowVersion version, System.Int32[] recordNos) { }
        private System.Data.BinaryNode.DataTypePrecedence GetPrecedence(System.Data.Common.StorageType storageType) { }
        private System.Data.Common.StorageType GetPrecedenceType(System.Data.BinaryNode.DataTypePrecedence code) { }
        private System.Boolean IsMixed(System.Data.Common.StorageType left, System.Data.Common.StorageType right) { }
        private System.Boolean IsMixedSql(System.Data.Common.StorageType left, System.Data.Common.StorageType right) { }
        private System.Data.Common.StorageType ResultType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, System.Boolean lc, System.Boolean rc, System.Int32 op) { }
        private System.Data.Common.StorageType ResultSqlType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, System.Boolean lc, System.Boolean rc, System.Int32 op) { }
        private System.Int32 SqlResultType(System.Int32 typeCode) { }

    }

    // TypeToken: 0x200004E
    public class LikeNode : BinaryNode
    {
        // Fields
        private System.Int32 _kind;        // 0x30
        private System.String _pattern;        // 0x38

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.Int32 op, System.Data.ExpressionNode left, System.Data.ExpressionNode right) { }
        private System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.String AnalyzePattern(System.String pat) { }

    }

    // TypeToken: 0x200004F
    public class ConstNode : ExpressionNode
    {
        // Fields
        private readonly System.Object _val;        // 0x18

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.Data.ValueType type, System.Object constant) { }
        private System.Void .ctor(System.Data.DataTable table, System.Data.ValueType type, System.Object constant, System.Boolean fParseQuotes) { }
        private System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }
        private System.Object Eval() { }
        private System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Object Eval(System.Int32[] recordNos) { }
        private System.Boolean IsConstant() { }
        private System.Boolean IsTableConstant() { }
        private System.Boolean HasLocalAggregate() { }
        private System.Boolean HasRemoteAggregate() { }
        private System.Data.ExpressionNode Optimize() { }
        private System.Object SmallestDecimal(System.Object constant) { }
        private System.Object SmallestNumeric(System.Object constant) { }

    }

    // TypeToken: 0x2000050
    public class DataExpression, IFilter
    {
        // Fields
        private System.String _originalExpression;        // 0x10
        private System.Boolean _parsed;        // 0x18
        private System.Boolean _bound;        // 0x19
        private System.Data.ExpressionNode _expr;        // 0x20
        private System.Data.DataTable _table;        // 0x28
        private readonly System.Data.Common.StorageType _storageType;        // 0x30
        private readonly System.Type _dataType;        // 0x38
        private System.Data.DataColumn[] _dependency;        // 0x40

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.String expression) { }
        private System.Void .ctor(System.Data.DataTable table, System.String expression, System.Type type) { }
        private System.String get_Expression() { }
        private System.Data.ExpressionNode get_ExpressionNode() { }
        private System.Boolean get_HasValue() { }
        private System.Void Bind(System.Data.DataTable table) { }
        private System.Boolean DependsOn(System.Data.DataColumn column) { }
        private System.Object Evaluate() { }
        private System.Object Evaluate(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Object Evaluate(System.Data.DataRow[] rows) { }
        private System.Object Evaluate(System.Data.DataRow[] rows, System.Data.DataRowVersion version) { }
        private System.Boolean Invoke(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Data.DataColumn[] GetDependency() { }
        private System.Boolean IsTableAggregate() { }
        private System.Boolean IsUnknown(System.Object value) { }
        private System.Boolean HasLocalAggregate() { }
        private System.Boolean HasRemoteAggregate() { }
        private System.Boolean ToBoolean(System.Object value) { }

    }

    // TypeToken: 0x2000051
    public class ExpressionNode
    {
        // Fields
        private System.Data.DataTable _table;        // 0x10

        // Methods
        private System.Void .ctor(System.Data.DataTable table) { }
        private System.IFormatProvider get_FormatProvider() { }
        private System.Boolean get_IsSqlColumn() { }
        private System.Data.DataTable get_table() { }
        private System.Void BindTable(System.Data.DataTable table) { }
        private System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }
        private System.Object Eval() { }
        private System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Object Eval(System.Int32[] recordNos) { }
        private System.Boolean IsConstant() { }
        private System.Boolean IsTableConstant() { }
        private System.Boolean HasLocalAggregate() { }
        private System.Boolean HasRemoteAggregate() { }
        private System.Data.ExpressionNode Optimize() { }
        private System.Boolean DependsOn(System.Data.DataColumn column) { }
        private System.Boolean IsInteger(System.Data.Common.StorageType type) { }
        private System.Boolean IsIntegerSql(System.Data.Common.StorageType type) { }
        private System.Boolean IsSigned(System.Data.Common.StorageType type) { }
        private System.Boolean IsSignedSql(System.Data.Common.StorageType type) { }
        private System.Boolean IsUnsigned(System.Data.Common.StorageType type) { }
        private System.Boolean IsUnsignedSql(System.Data.Common.StorageType type) { }
        private System.Boolean IsNumeric(System.Data.Common.StorageType type) { }
        private System.Boolean IsNumericSql(System.Data.Common.StorageType type) { }
        private System.Boolean IsFloat(System.Data.Common.StorageType type) { }
        private System.Boolean IsFloatSql(System.Data.Common.StorageType type) { }

    }

    // TypeToken: 0x2000052
    public struct ValueType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.ValueType Unknown;        // 0x0
        public static System.Data.ValueType Null;        // 0x0
        public static System.Data.ValueType Bool;        // 0x0
        public static System.Data.ValueType Numeric;        // 0x0
        public static System.Data.ValueType Str;        // 0x0
        public static System.Data.ValueType Float;        // 0x0
        public static System.Data.ValueType Decimal;        // 0x0
        public static System.Data.ValueType Object;        // 0x0
        public static System.Data.ValueType Date;        // 0x0

    }

    // TypeToken: 0x2000053
    public struct Nodes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.Nodes Noop;        // 0x0
        public static System.Data.Nodes Unop;        // 0x0
        public static System.Data.Nodes UnopSpec;        // 0x0
        public static System.Data.Nodes Binop;        // 0x0
        public static System.Data.Nodes BinopSpec;        // 0x0
        public static System.Data.Nodes Zop;        // 0x0
        public static System.Data.Nodes Call;        // 0x0
        public static System.Data.Nodes Const;        // 0x0
        public static System.Data.Nodes Name;        // 0x0
        public static System.Data.Nodes Paren;        // 0x0
        public static System.Data.Nodes Conv;        // 0x0

    }

    // TypeToken: 0x2000054
    public class ExpressionParser
    {
        // Fields
        private static readonly System.Data.ExpressionParser.ReservedWords[] s_reservedwords;        // 0x0
        private System.Char _escape;        // 0x10
        private System.Char _decimalSeparator;        // 0x12
        private System.Char _listSeparator;        // 0x14
        private System.Char _exponentL;        // 0x16
        private System.Char _exponentU;        // 0x18
        private System.Char[] _text;        // 0x20
        private System.Int32 _pos;        // 0x28
        private System.Int32 _start;        // 0x2C
        private System.Data.Tokens _token;        // 0x30
        private System.Int32 _op;        // 0x34
        private System.Data.OperatorInfo[] _ops;        // 0x38
        private System.Int32 _topOperator;        // 0x40
        private System.Int32 _topNode;        // 0x44
        private readonly System.Data.DataTable _table;        // 0x48
        private System.Data.ExpressionNode[] _nodeStack;        // 0x50
        private System.Int32 _prevOperand;        // 0x58
        private System.Data.ExpressionNode _expression;        // 0x60

        // Methods
        private System.Void .ctor(System.Data.DataTable table) { }
        private System.Void LoadExpression(System.String data) { }
        private System.Void StartScan() { }
        private System.Data.ExpressionNode Parse() { }
        private System.Data.ExpressionNode ParseAggregateArgument(System.Data.FunctionId aggregate) { }
        private System.Data.ExpressionNode NodePop() { }
        private System.Data.ExpressionNode NodePeek() { }
        private System.Void NodePush(System.Data.ExpressionNode node) { }
        private System.Void BuildExpression(System.Int32 pri) { }
        private System.Void CheckToken(System.Data.Tokens token) { }
        private System.Data.Tokens Scan() { }
        private System.Void ScanNumeric() { }
        private System.Void ScanName() { }
        private System.Void ScanName(System.Char chEnd, System.Char esc, System.String charsToEscape) { }
        private System.Void ScanDate() { }
        private System.Void ScanBinaryConstant() { }
        private System.Void ScanReserved() { }
        private System.Void ScanString(System.Char escape) { }
        private System.Void ScanToken(System.Data.Tokens token) { }
        private System.Void ScanWhite() { }
        private System.Boolean IsWhiteSpace(System.Char ch) { }
        private System.Boolean IsAlphaNumeric(System.Char ch) { }
        private System.Boolean IsDigit(System.Char ch) { }
        private System.Boolean IsAlpha(System.Char ch) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000056
    public struct Tokens
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.Tokens None;        // 0x0
        public static System.Data.Tokens Name;        // 0x0
        public static System.Data.Tokens Numeric;        // 0x0
        public static System.Data.Tokens Decimal;        // 0x0
        public static System.Data.Tokens Float;        // 0x0
        public static System.Data.Tokens BinaryConst;        // 0x0
        public static System.Data.Tokens StringConst;        // 0x0
        public static System.Data.Tokens Date;        // 0x0
        public static System.Data.Tokens ListSeparator;        // 0x0
        public static System.Data.Tokens LeftParen;        // 0x0
        public static System.Data.Tokens RightParen;        // 0x0
        public static System.Data.Tokens ZeroOp;        // 0x0
        public static System.Data.Tokens UnaryOp;        // 0x0
        public static System.Data.Tokens BinaryOp;        // 0x0
        public static System.Data.Tokens Child;        // 0x0
        public static System.Data.Tokens Parent;        // 0x0
        public static System.Data.Tokens Dot;        // 0x0
        public static System.Data.Tokens Unknown;        // 0x0
        public static System.Data.Tokens EOS;        // 0x0

    }

    // TypeToken: 0x2000057
    public class OperatorInfo
    {
        // Fields
        private System.Data.Nodes _type;        // 0x10
        private System.Int32 _op;        // 0x14
        private System.Int32 _priority;        // 0x18

        // Methods
        private System.Void .ctor(System.Data.Nodes type, System.Int32 op, System.Int32 pri) { }

    }

    // TypeToken: 0x2000058
    public class InvalidExpressionException : DataException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x2000059
    public class EvaluateException : InvalidExpressionException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x200005A
    public class SyntaxErrorException : InvalidExpressionException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String s) { }

    }

    // TypeToken: 0x200005B
    public class ExprException
    {
        // Methods
        private System.OverflowException _Overflow(System.String error) { }
        private System.Data.InvalidExpressionException _Expr(System.String error) { }
        private System.Data.SyntaxErrorException _Syntax(System.String error) { }
        private System.Data.EvaluateException _Eval(System.String error) { }
        private System.Data.EvaluateException _Eval(System.String error, System.Exception innerException) { }
        private System.Exception InvokeArgument() { }
        private System.Exception NYI(System.String moreinfo) { }
        private System.Exception MissingOperand(System.Data.OperatorInfo before) { }
        private System.Exception MissingOperator(System.String token) { }
        private System.Exception TypeMismatch(System.String expr) { }
        private System.Exception FunctionArgumentOutOfRange(System.String arg, System.String func) { }
        private System.Exception ExpressionTooComplex() { }
        private System.Exception UnboundName(System.String name) { }
        private System.Exception InvalidString(System.String str) { }
        private System.Exception UndefinedFunction(System.String name) { }
        private System.Exception SyntaxError() { }
        private System.Exception FunctionArgumentCount(System.String name) { }
        private System.Exception MissingRightParen() { }
        private System.Exception UnknownToken(System.String token, System.Int32 position) { }
        private System.Exception UnknownToken(System.Data.Tokens tokExpected, System.Data.Tokens tokCurr, System.Int32 position) { }
        private System.Exception DatatypeConvertion(System.Type type1, System.Type type2) { }
        private System.Exception DatavalueConvertion(System.Object value, System.Type type, System.Exception innerException) { }
        private System.Exception InvalidName(System.String name) { }
        private System.Exception InvalidDate(System.String date) { }
        private System.Exception NonConstantArgument() { }
        private System.Exception InvalidPattern(System.String pat) { }
        private System.Exception InWithoutParentheses() { }
        private System.Exception InWithoutList() { }
        private System.Exception InvalidIsSyntax() { }
        private System.Exception Overflow(System.Type type) { }
        private System.Exception ArgumentType(System.String function, System.Int32 arg, System.Type type) { }
        private System.Exception ArgumentTypeInteger(System.String function, System.Int32 arg) { }
        private System.Exception TypeMismatchInBinop(System.Int32 op, System.Type type1, System.Type type2) { }
        private System.Exception AmbiguousBinop(System.Int32 op, System.Type type1, System.Type type2) { }
        private System.Exception UnsupportedOperator(System.Int32 op) { }
        private System.Exception InvalidNameBracketing(System.String name) { }
        private System.Exception MissingOperandBefore(System.String op) { }
        private System.Exception TooManyRightParentheses() { }
        private System.Exception UnresolvedRelation(System.String name, System.String expr) { }
        private System.Data.EvaluateException BindFailure(System.String relationName) { }
        private System.Exception AggregateArgument() { }
        private System.Exception AggregateUnbound(System.String expr) { }
        private System.Exception EvalNoContext() { }
        private System.Exception ExpressionUnbound(System.String expr) { }
        private System.Exception ComputeNotAggregate(System.String expr) { }
        private System.Exception FilterConvertion(System.String expr) { }
        private System.Exception LookupArgument() { }
        private System.Exception InvalidType(System.String typeName) { }
        private System.Exception InvalidHoursArgument() { }
        private System.Exception InvalidMinutesArgument() { }
        private System.Exception InvalidTimeZoneRange() { }
        private System.Exception MismatchKindandTimeSpan() { }
        private System.Exception UnsupportedDataType(System.Type type) { }

    }

    // TypeToken: 0x200005C
    public class FunctionNode : ExpressionNode
    {
        // Fields
        private readonly System.String _name;        // 0x18
        private readonly System.Int32 _info;        // 0x20
        private System.Int32 _argumentCount;        // 0x24
        private System.Data.ExpressionNode[] _arguments;        // 0x28
        private static readonly System.Data.Function[] s_funcs;        // 0x0

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.String name) { }
        private System.Void AddArgument(System.Data.ExpressionNode argument) { }
        private System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }
        private System.Object Eval() { }
        private System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Object Eval(System.Int32[] recordNos) { }
        private System.Boolean IsConstant() { }
        private System.Boolean IsTableConstant() { }
        private System.Boolean HasLocalAggregate() { }
        private System.Boolean HasRemoteAggregate() { }
        private System.Boolean DependsOn(System.Data.DataColumn column) { }
        private System.Data.ExpressionNode Optimize() { }
        private System.Type GetDataType(System.Data.ExpressionNode node) { }
        private System.Object EvalFunction(System.Data.FunctionId id, System.Object[] argumentValues, System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Data.FunctionId get_Aggregate() { }
        private System.Boolean get_IsAggregate() { }
        private System.Void Check() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005D
    public struct FunctionId
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.FunctionId none;        // 0x0
        public static System.Data.FunctionId Ascii;        // 0x0
        public static System.Data.FunctionId Char;        // 0x0
        public static System.Data.FunctionId Charindex;        // 0x0
        public static System.Data.FunctionId Difference;        // 0x0
        public static System.Data.FunctionId Len;        // 0x0
        public static System.Data.FunctionId Lower;        // 0x0
        public static System.Data.FunctionId LTrim;        // 0x0
        public static System.Data.FunctionId Patindex;        // 0x0
        public static System.Data.FunctionId Replicate;        // 0x0
        public static System.Data.FunctionId Reverse;        // 0x0
        public static System.Data.FunctionId Right;        // 0x0
        public static System.Data.FunctionId RTrim;        // 0x0
        public static System.Data.FunctionId Soundex;        // 0x0
        public static System.Data.FunctionId Space;        // 0x0
        public static System.Data.FunctionId Str;        // 0x0
        public static System.Data.FunctionId Stuff;        // 0x0
        public static System.Data.FunctionId Substring;        // 0x0
        public static System.Data.FunctionId Upper;        // 0x0
        public static System.Data.FunctionId IsNull;        // 0x0
        public static System.Data.FunctionId Iif;        // 0x0
        public static System.Data.FunctionId Convert;        // 0x0
        public static System.Data.FunctionId cInt;        // 0x0
        public static System.Data.FunctionId cBool;        // 0x0
        public static System.Data.FunctionId cDate;        // 0x0
        public static System.Data.FunctionId cDbl;        // 0x0
        public static System.Data.FunctionId cStr;        // 0x0
        public static System.Data.FunctionId Abs;        // 0x0
        public static System.Data.FunctionId Acos;        // 0x0
        public static System.Data.FunctionId In;        // 0x0
        public static System.Data.FunctionId Trim;        // 0x0
        public static System.Data.FunctionId Sum;        // 0x0
        public static System.Data.FunctionId Avg;        // 0x0
        public static System.Data.FunctionId Min;        // 0x0
        public static System.Data.FunctionId Max;        // 0x0
        public static System.Data.FunctionId Count;        // 0x0
        public static System.Data.FunctionId StDev;        // 0x0
        public static System.Data.FunctionId Var;        // 0x0
        public static System.Data.FunctionId DateTimeOffset;        // 0x0

    }

    // TypeToken: 0x200005E
    public class Function
    {
        // Fields
        private readonly System.String _name;        // 0x10
        private readonly System.Data.FunctionId _id;        // 0x18
        private readonly System.Type _result;        // 0x20
        private readonly System.Boolean _isValidateArguments;        // 0x28
        private readonly System.Boolean _isVariantArgumentList;        // 0x29
        private readonly System.Int32 _argumentCount;        // 0x2C
        private readonly System.Type[] _parameters;        // 0x30
        private static System.String[] s_functionName;        // 0x0

        // Methods
        private System.Void .ctor(System.String name, System.Data.FunctionId id, System.Type result, System.Boolean IsValidateArguments, System.Boolean IsVariantArgumentList, System.Int32 argumentCount, System.Type a1, System.Type a2, System.Type a3) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005F
    public interface IFilter
    {
        // Methods
        private System.Boolean Invoke(System.Data.DataRow row, System.Data.DataRowVersion version) { }

    }

    // TypeToken: 0x2000060
    public class LookupNode : ExpressionNode
    {
        // Fields
        private readonly System.String _relationName;        // 0x18
        private readonly System.String _columnName;        // 0x20
        private System.Data.DataColumn _column;        // 0x28
        private System.Data.DataRelation _relation;        // 0x30

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.String columnName, System.String relationName) { }
        private System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }
        private System.Object Eval() { }
        private System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Object Eval(System.Int32[] recordNos) { }
        private System.Boolean IsConstant() { }
        private System.Boolean IsTableConstant() { }
        private System.Boolean HasLocalAggregate() { }
        private System.Boolean HasRemoteAggregate() { }
        private System.Boolean DependsOn(System.Data.DataColumn column) { }
        private System.Data.ExpressionNode Optimize() { }

    }

    // TypeToken: 0x2000061
    public class NameNode : ExpressionNode
    {
        // Fields
        private System.String _name;        // 0x18
        private System.Boolean _found;        // 0x20
        private System.Data.DataColumn _column;        // 0x28

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.Char[] text, System.Int32 start, System.Int32 pos) { }
        private System.Void .ctor(System.Data.DataTable table, System.String name) { }
        private System.Boolean get_IsSqlColumn() { }
        private System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }
        private System.Object Eval() { }
        private System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Object Eval(System.Int32[] records) { }
        private System.Boolean IsConstant() { }
        private System.Boolean IsTableConstant() { }
        private System.Boolean HasLocalAggregate() { }
        private System.Boolean HasRemoteAggregate() { }
        private System.Boolean DependsOn(System.Data.DataColumn column) { }
        private System.Data.ExpressionNode Optimize() { }
        private System.String ParseName(System.Char[] text, System.Int32 start, System.Int32 pos) { }

    }

    // TypeToken: 0x2000062
    public class Operators
    {
        // Fields
        private static readonly System.Int32[] s_priority;        // 0x0
        private static readonly System.String[] s_looks;        // 0x8

        // Methods
        private System.Boolean IsArithmetical(System.Int32 op) { }
        private System.Boolean IsLogical(System.Int32 op) { }
        private System.Boolean IsRelational(System.Int32 op) { }
        private System.Int32 Priority(System.Int32 op) { }
        private System.String ToString(System.Int32 op) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000063
    public class UnaryNode : ExpressionNode
    {
        // Fields
        private readonly System.Int32 _op;        // 0x18
        private System.Data.ExpressionNode _right;        // 0x20

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.Int32 op, System.Data.ExpressionNode right) { }
        private System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }
        private System.Object Eval() { }
        private System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Object Eval(System.Int32[] recordNos) { }
        private System.Object EvalUnaryOp(System.Int32 op, System.Object vl) { }
        private System.Boolean IsConstant() { }
        private System.Boolean IsTableConstant() { }
        private System.Boolean HasLocalAggregate() { }
        private System.Boolean HasRemoteAggregate() { }
        private System.Boolean DependsOn(System.Data.DataColumn column) { }
        private System.Data.ExpressionNode Optimize() { }

    }

    // TypeToken: 0x2000064
    public class ZeroOpNode : ExpressionNode
    {
        // Fields
        private readonly System.Int32 _op;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 op) { }
        private System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }
        private System.Object Eval() { }
        private System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Object Eval(System.Int32[] recordNos) { }
        private System.Boolean IsConstant() { }
        private System.Boolean IsTableConstant() { }
        private System.Boolean HasLocalAggregate() { }
        private System.Boolean HasRemoteAggregate() { }
        private System.Data.ExpressionNode Optimize() { }

    }

    // TypeToken: 0x2000065
    public class ForeignKeyConstraint : Constraint
    {
        // Fields
        private System.Data.Rule _deleteRule;        // 0x38
        private System.Data.Rule _updateRule;        // 0x3C
        private System.Data.AcceptRejectRule _acceptRejectRule;        // 0x40
        private System.Data.DataKey _childKey;        // 0x48
        private System.Data.DataKey _parentKey;        // 0x50
        private System.String _constraintName;        // 0x58
        private System.String[] _parentColumnNames;        // 0x60
        private System.String[] _childColumnNames;        // 0x68
        private System.String _parentTableName;        // 0x70

        // Methods
        private System.Void .ctor(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
        private System.Void .ctor(System.String constraintName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
        private System.Void .ctor(System.String constraintName, System.String parentTableName, System.String[] parentColumnNames, System.String[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule) { }
        private System.Data.DataKey get_ChildKey() { }
        private System.Data.DataColumn[] get_Columns() { }
        private System.Data.DataTable get_Table() { }
        private System.String[] get_ParentColumnNames() { }
        private System.String[] get_ChildColumnNames() { }
        private System.Void CheckCanAddToCollection(System.Data.ConstraintCollection constraints) { }
        private System.Boolean CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, System.Boolean fThrowException) { }
        private System.Boolean IsKeyNull(System.Object[] values) { }
        private System.Boolean IsConstraintViolated() { }
        private System.Boolean CanEnableConstraint() { }
        private System.Void CascadeCommit(System.Data.DataRow row) { }
        private System.Void CascadeDelete(System.Data.DataRow row) { }
        private System.Void CascadeRollback(System.Data.DataRow row) { }
        private System.Void CascadeUpdate(System.Data.DataRow row) { }
        private System.Void CheckCanClearParentTable(System.Data.DataTable table) { }
        private System.Void CheckCanRemoveParentRow(System.Data.DataRow row) { }
        private System.Void CheckCascade(System.Data.DataRow row, System.Data.DataRowAction action) { }
        private System.Void CheckConstraint(System.Data.DataRow childRow, System.Data.DataRowAction action) { }
        private System.Void NonVirtualCheckState() { }
        private System.Void CheckState() { }
        private System.Data.AcceptRejectRule get_AcceptRejectRule() { }
        private System.Void set_AcceptRejectRule(System.Data.AcceptRejectRule value) { }
        private System.Boolean ContainsColumn(System.Data.DataColumn column) { }
        private System.Data.Constraint Clone(System.Data.DataSet destination) { }
        private System.Data.Constraint Clone(System.Data.DataSet destination, System.Boolean ignorNSforTableLookup) { }
        private System.Data.ForeignKeyConstraint Clone(System.Data.DataTable destination) { }
        private System.Void Create(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
        private System.Data.Rule get_DeleteRule() { }
        private System.Void set_DeleteRule(System.Data.Rule value) { }
        private System.Boolean Equals(System.Object key) { }
        private System.Int32 GetHashCode() { }
        private System.Data.DataColumn[] get_RelatedColumns() { }
        private System.Data.DataColumn[] get_RelatedColumnsReference() { }
        private System.Data.DataKey get_ParentKey() { }
        private System.Data.DataRelation FindParentRelation() { }
        private System.Data.DataTable get_RelatedTable() { }
        private System.Data.Rule get_UpdateRule() { }
        private System.Void set_UpdateRule(System.Data.Rule value) { }

    }

    // TypeToken: 0x2000066
    public struct MappingType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.MappingType Element;        // 0x0
        public static System.Data.MappingType Attribute;        // 0x0
        public static System.Data.MappingType SimpleContent;        // 0x0
        public static System.Data.MappingType Hidden;        // 0x0

    }

    // TypeToken: 0x2000067
    public class MergeFailedEventArgs : EventArgs
    {
        // Fields
        private readonly System.Data.DataTable <Table>k__BackingField;        // 0x10
        private readonly System.String <Conflict>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.String conflict) { }
        private System.String get_Conflict() { }

    }

    // TypeToken: 0x2000068
    public class MergeFailedEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Data.MergeFailedEventArgs e) { }

    }

    // TypeToken: 0x2000069
    public class Merger
    {
        // Fields
        private System.Data.DataSet _dataSet;        // 0x10
        private System.Data.DataTable _dataTable;        // 0x18
        private System.Boolean _preserveChanges;        // 0x20
        private System.Data.MissingSchemaAction _missingSchemaAction;        // 0x24
        private System.Boolean _isStandAlonetable;        // 0x28
        private System.Boolean _IgnoreNSforTableLookup;        // 0x29

        // Methods
        private System.Void .ctor(System.Data.DataSet dataSet, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        private System.Void .ctor(System.Data.DataTable dataTable, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        private System.Void MergeDataSet(System.Data.DataSet source) { }
        private System.Void MergeTable(System.Data.DataTable src) { }
        private System.Void MergeTable(System.Data.DataTable src, System.Data.DataTable dst) { }
        private System.Data.DataTable MergeSchema(System.Data.DataTable table) { }
        private System.Void MergeTableData(System.Data.DataTable src) { }
        private System.Void MergeConstraints(System.Data.DataSet source) { }
        private System.Void MergeConstraints(System.Data.DataTable table) { }
        private System.Void MergeRelation(System.Data.DataRelation relation) { }
        private System.Void MergeExtendedProperties(System.Data.PropertyCollection src, System.Data.PropertyCollection dst) { }
        private System.Data.DataKey GetSrcKey(System.Data.DataTable src, System.Data.DataTable dst) { }

    }

    // TypeToken: 0x200006A
    public struct MissingSchemaAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.MissingSchemaAction Add;        // 0x0
        public static System.Data.MissingSchemaAction Ignore;        // 0x0
        public static System.Data.MissingSchemaAction Error;        // 0x0
        public static System.Data.MissingSchemaAction AddWithKey;        // 0x0

    }

    // TypeToken: 0x200006B
    public class PrimaryKeyTypeConverter : ReferenceConverter
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }

    }

    // TypeToken: 0x200006C
    public class PropertyCollection : Hashtable, ICloneable
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Object Clone() { }

    }

    // TypeToken: 0x200006D
    public struct Range
    {
        // Fields
        private System.Int32 _min;        // 0x10
        private System.Int32 _max;        // 0x14
        private System.Boolean _isNotNull;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 min, System.Int32 max) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsNull() { }
        private System.Int32 get_Min() { }
        private System.Void CheckNull() { }

    }

    // TypeToken: 0x200006E
    public struct RBTreeError
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.RBTreeError InvalidPageSize;        // 0x0
        public static System.Data.RBTreeError PagePositionInSlotInUse;        // 0x0
        public static System.Data.RBTreeError NoFreeSlots;        // 0x0
        public static System.Data.RBTreeError InvalidStateinInsert;        // 0x0
        public static System.Data.RBTreeError InvalidNextSizeInDelete;        // 0x0
        public static System.Data.RBTreeError InvalidStateinDelete;        // 0x0
        public static System.Data.RBTreeError InvalidNodeSizeinDelete;        // 0x0
        public static System.Data.RBTreeError InvalidStateinEndDelete;        // 0x0
        public static System.Data.RBTreeError CannotRotateInvalidsuccessorNodeinDelete;        // 0x0
        public static System.Data.RBTreeError IndexOutOFRangeinGetNodeByIndex;        // 0x0
        public static System.Data.RBTreeError RBDeleteFixup;        // 0x0
        public static System.Data.RBTreeError UnsupportedAccessMethod1;        // 0x0
        public static System.Data.RBTreeError UnsupportedAccessMethod2;        // 0x0
        public static System.Data.RBTreeError UnsupportedAccessMethodInNonNillRootSubtree;        // 0x0
        public static System.Data.RBTreeError AttachedNodeWithZerorbTreeNodeId;        // 0x0
        public static System.Data.RBTreeError CompareNodeInDataRowTree;        // 0x0
        public static System.Data.RBTreeError CompareSateliteTreeNodeInDataRowTree;        // 0x0
        public static System.Data.RBTreeError NestedSatelliteTreeEnumerator;        // 0x0

    }

    // TypeToken: 0x200006F
    public struct TreeAccessMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.TreeAccessMethod KEY_SEARCH_AND_INDEX;        // 0x0
        public static System.Data.TreeAccessMethod INDEX_ONLY;        // 0x0

    }

    // TypeToken: 0x2000070
    public class RBTree`1, IEnumerable
    {
        // Fields
        private System.Data.RBTree.TreePage<K>[] _pageTable;        // 0x0
        private System.Int32[] _pageTableMap;        // 0x0
        private System.Int32 _inUsePageCount;        // 0x0
        private System.Int32 _nextFreePageLine;        // 0x0
        public System.Int32 root;        // 0x0
        private System.Int32 _version;        // 0x0
        private System.Int32 _inUseNodeCount;        // 0x0
        private System.Int32 _inUseSatelliteTreeCount;        // 0x0
        private readonly System.Data.TreeAccessMethod _accessMethod;        // 0x0

        // Methods
        private System.Int32 CompareNode(K record1, K record2) { }
        private System.Int32 CompareSateliteTreeNode(K record1, K record2) { }
        private System.Void .ctor(System.Data.TreeAccessMethod accessMethod) { }
        private System.Void InitTree() { }
        private System.Void FreePage(System.Data.RBTree.TreePage<K> page) { }
        private System.Data.RBTree.TreePage<K> AllocPage(System.Int32 size) { }
        private System.Void MarkPageFull(System.Data.RBTree.TreePage<K> page) { }
        private System.Void MarkPageFree(System.Data.RBTree.TreePage<K> page) { }
        private System.Int32 GetIntValueFromBitMap(System.UInt32 bitMap) { }
        private System.Void FreeNode(System.Int32 nodeId) { }
        private System.Int32 GetIndexOfPageWithFreeSlot(System.Boolean allocatedPage) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_HasDuplicates() { }
        private System.Int32 GetNewNode(K key) { }
        private System.Int32 Successor(System.Int32 x_id) { }
        private System.Boolean Successor(System.Int32& nodeId, System.Int32& mainTreeNodeId) { }
        private System.Int32 Minimum(System.Int32 x_id) { }
        private System.Int32 LeftRotate(System.Int32 root_id, System.Int32 x_id, System.Int32 mainTreeNode) { }
        private System.Int32 RightRotate(System.Int32 root_id, System.Int32 x_id, System.Int32 mainTreeNode) { }
        private System.Int32 RBInsert(System.Int32 root_id, System.Int32 x_id, System.Int32 mainTreeNodeID, System.Int32 position, System.Boolean append) { }
        private System.Void UpdateNodeKey(K currentKey, K newKey) { }
        private K DeleteByIndex(System.Int32 i) { }
        private System.Int32 RBDelete(System.Int32 z_id) { }
        private System.Int32 RBDeleteX(System.Int32 root_id, System.Int32 z_id, System.Int32 mainTreeNodeID) { }
        private System.Int32 RBDeleteFixup(System.Int32 root_id, System.Int32 x_id, System.Int32 px_id, System.Int32 mainTreeNodeID) { }
        private System.Int32 SearchSubTree(System.Int32 root_id, K key) { }
        private K get_Item(System.Int32 index) { }
        private System.Data.RBTree.NodePath<K> GetNodeByKey(K key) { }
        private System.Int32 GetIndexByKey(K key) { }
        private System.Int32 GetIndexByNode(System.Int32 node) { }
        private System.Int32 GetIndexByNodePath(System.Data.RBTree.NodePath<K> path) { }
        private System.Int32 ComputeIndexByNode(System.Int32 nodeId) { }
        private System.Int32 ComputeIndexWithSatelliteByNode(System.Int32 nodeId) { }
        private System.Data.RBTree.NodePath<K> GetNodeByIndex(System.Int32 userIndex) { }
        private System.Int32 ComputeNodeByIndex(System.Int32 index, System.Int32& satelliteRootId) { }
        private System.Int32 ComputeNodeByIndex(System.Int32 x_id, System.Int32 index) { }
        private System.Int32 Insert(K item) { }
        private System.Int32 Add(K item) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Int32 IndexOf(System.Int32 nodeId, K item) { }
        private System.Int32 Insert(System.Int32 position, K item) { }
        private System.Int32 InsertAt(System.Int32 position, K item, System.Boolean append) { }
        private System.Void RemoveAt(System.Int32 position) { }
        private System.Void Clear() { }
        private System.Void CopyTo(System.Array array, System.Int32 index) { }
        private System.Void CopyTo(K[] array, System.Int32 index) { }
        private System.Void SetRight(System.Int32 nodeId, System.Int32 rightNodeId) { }
        private System.Void SetLeft(System.Int32 nodeId, System.Int32 leftNodeId) { }
        private System.Void SetParent(System.Int32 nodeId, System.Int32 parentNodeId) { }
        private System.Void SetColor(System.Int32 nodeId, System.Data.RBTree.NodeColor<K> color) { }
        private System.Void SetKey(System.Int32 nodeId, K key) { }
        private System.Void SetNext(System.Int32 nodeId, System.Int32 nextNodeId) { }
        private System.Void SetSubTreeSize(System.Int32 nodeId, System.Int32 size) { }
        private System.Void IncreaseSize(System.Int32 nodeId) { }
        private System.Void RecomputeSize(System.Int32 nodeId) { }
        private System.Void DecreaseSize(System.Int32 nodeId) { }
        private System.Int32 Right(System.Int32 nodeId) { }
        private System.Int32 Left(System.Int32 nodeId) { }
        private System.Int32 Parent(System.Int32 nodeId) { }
        private System.Data.RBTree.NodeColor<K> color(System.Int32 nodeId) { }
        private System.Int32 Next(System.Int32 nodeId) { }
        private System.Int32 SubTreeSize(System.Int32 nodeId) { }
        private K Key(System.Int32 nodeId) { }

    }

    // TypeToken: 0x2000076
    public class RecordManager
    {
        // Fields
        private readonly System.Data.DataTable _table;        // 0x10
        private System.Int32 _lastFreeRecord;        // 0x18
        private System.Int32 _minimumCapacity;        // 0x1C
        private System.Int32 _recordCapacity;        // 0x20
        private readonly System.Collections.Generic.List<System.Int32> _freeRecordList;        // 0x28
        private System.Data.DataRow[] _rows;        // 0x30

        // Methods
        private System.Void .ctor(System.Data.DataTable table) { }
        private System.Void GrowRecordCapacity() { }
        private System.Int32 get_LastFreeRecord() { }
        private System.Int32 get_MinimumCapacity() { }
        private System.Void set_MinimumCapacity(System.Int32 value) { }
        private System.Int32 get_RecordCapacity() { }
        private System.Void set_RecordCapacity(System.Int32 value) { }
        private System.Int32 NewCapacity(System.Int32 capacity) { }
        private System.Int32 NormalizedMinimumCapacity(System.Int32 capacity) { }
        private System.Int32 NewRecordBase() { }
        private System.Void FreeRecord(System.Int32& record) { }
        private System.Void Clear(System.Boolean clearAll) { }
        private System.Data.DataRow get_Item(System.Int32 record) { }
        private System.Void set_Item(System.Int32 record, System.Data.DataRow value) { }
        private System.Int32 ImportRecord(System.Data.DataTable src, System.Int32 record) { }
        private System.Int32 CopyRecord(System.Data.DataTable src, System.Int32 record, System.Int32 copy) { }
        private System.Void SetRowCache(System.Data.DataRow[] newRows) { }

    }

    // TypeToken: 0x2000077
    public class RelatedView : DataView, IFilter
    {
        // Fields
        private readonly System.Nullable<System.Data.DataKey> _parentKey;        // 0xB0
        private readonly System.Data.DataKey _childKey;        // 0xC0
        private readonly System.Data.DataRowView _parentRowView;        // 0xC8
        private readonly System.Object[] _filterValues;        // 0xD0

        // Methods
        private System.Void .ctor(System.Data.DataColumn[] columns, System.Object[] values) { }
        private System.Void .ctor(System.Data.DataRowView parentRowView, System.Data.DataKey parentKey, System.Data.DataColumn[] childKeyColumns) { }
        private System.Object[] GetParentValues() { }
        private System.Boolean Invoke(System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Data.IFilter GetFilter() { }
        private System.Data.DataRowView AddNew() { }
        private System.Void SetIndex(System.String newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter) { }

    }

    // TypeToken: 0x2000078
    public class RelationshipConverter : ExpandableObjectConverter
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        private System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType) { }

    }

    // TypeToken: 0x2000079
    public struct Rule
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.Rule None;        // 0x0
        public static System.Data.Rule Cascade;        // 0x0
        public static System.Data.Rule SetNull;        // 0x0
        public static System.Data.Rule SetDefault;        // 0x0

    }

    // TypeToken: 0x200007A
    public struct SchemaSerializationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.SchemaSerializationMode IncludeSchema;        // 0x0
        public static System.Data.SchemaSerializationMode ExcludeSchema;        // 0x0

    }

    // TypeToken: 0x200007B
    public class Select
    {
        // Fields
        private readonly System.Data.DataTable _table;        // 0x10
        private readonly System.Data.IndexField[] _indexFields;        // 0x18
        private System.Data.DataViewRowState _recordStates;        // 0x20
        private System.Data.DataExpression _rowFilter;        // 0x28
        private System.Data.ExpressionNode _expression;        // 0x30
        private System.Data.Index _index;        // 0x38
        private System.Int32[] _records;        // 0x40
        private System.Int32 _recordCount;        // 0x48
        private System.Data.ExpressionNode _linearExpression;        // 0x50
        private System.Boolean _candidatesForBinarySearch;        // 0x58
        private System.Data.Select.ColumnInfo[] _candidateColumns;        // 0x60
        private System.Int32 _nCandidates;        // 0x68
        private System.Int32 _matchedCandidates;        // 0x6C

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.String filterExpression, System.String sort, System.Data.DataViewRowState recordStates) { }
        private System.Boolean IsSupportedOperator(System.Int32 op) { }
        private System.Void AnalyzeExpression(System.Data.BinaryNode expr) { }
        private System.Boolean CompareSortIndexDesc(System.Data.IndexField[] fields) { }
        private System.Boolean FindSortIndex() { }
        private System.Int32 CompareClosestCandidateIndexDesc(System.Data.IndexField[] fields) { }
        private System.Boolean FindClosestCandidateIndex() { }
        private System.Void InitCandidateColumns() { }
        private System.Void CreateIndex() { }
        private System.Boolean IsOperatorIn(System.Data.ExpressionNode enode) { }
        private System.Void BuildLinearExpression() { }
        private System.Data.DataRow[] SelectRows() { }
        private System.Data.DataRow[] GetRows() { }
        private System.Boolean AcceptRecord(System.Int32 record) { }
        private System.Int32 Eval(System.Data.BinaryNode expr, System.Data.DataRow row, System.Data.DataRowVersion version) { }
        private System.Int32 Evaluate(System.Int32 record) { }
        private System.Int32 FindFirstMatchingRecord() { }
        private System.Int32 FindLastMatchingRecord(System.Int32 lo) { }
        private System.Data.Range GetBinaryFilteredRecords() { }
        private System.Int32[] GetLinearFilteredRecords(System.Data.Range range) { }
        private System.Data.DataRow[] GetLinearFilteredRows(System.Data.Range range) { }
        private System.Int32 CompareRecords(System.Int32 record1, System.Int32 record2) { }
        private System.Void Sort(System.Int32 left, System.Int32 right) { }

    }

    // TypeToken: 0x200007D
    public struct IndexField
    {
        // Fields
        public readonly System.Data.DataColumn Column;        // 0x10
        public readonly System.Boolean IsDescending;        // 0x18

        // Methods
        private System.Void .ctor(System.Data.DataColumn column, System.Boolean isDescending) { }
        private System.Boolean op_Equality(System.Data.IndexField if1, System.Data.IndexField if2) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200007E
    public class Index
    {
        // Fields
        private readonly System.Data.DataTable _table;        // 0x10
        private readonly System.Data.IndexField[] _indexFields;        // 0x18
        private readonly System.Comparison<System.Data.DataRow> _comparison;        // 0x20
        private readonly System.Data.DataViewRowState _recordStates;        // 0x28
        private System.WeakReference _rowFilter;        // 0x30
        private System.Data.Index.IndexTree _records;        // 0x38
        private System.Int32 _recordCount;        // 0x40
        private System.Int32 _refCount;        // 0x44
        private System.Data.Listeners<System.Data.DataViewListener> _listeners;        // 0x48
        private System.Boolean _suspendEvents;        // 0x50
        private readonly System.Boolean _isSharable;        // 0x51
        private readonly System.Boolean _hasRemoteAggregate;        // 0x52
        private static System.Int32 s_objectTypeCount;        // 0x0
        private readonly System.Int32 _objectID;        // 0x54

        // Methods
        private System.Void .ctor(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter) { }
        private System.Void .ctor(System.Data.DataTable table, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter) { }
        private System.Data.IndexField[] GetAllFields(System.Data.DataColumnCollection columns) { }
        private System.Void .ctor(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter) { }
        private System.Boolean Equal(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter) { }
        private System.Boolean get_HasRemoteAggregate() { }
        private System.Int32 get_ObjectID() { }
        private System.Data.DataViewRowState get_RecordStates() { }
        private System.Data.IFilter get_RowFilter() { }
        private System.Int32 GetRecord(System.Int32 recordIndex) { }
        private System.Boolean get_HasDuplicates() { }
        private System.Int32 get_RecordCount() { }
        private System.Boolean get_IsSharable() { }
        private System.Boolean AcceptRecord(System.Int32 record) { }
        private System.Boolean AcceptRecord(System.Int32 record, System.Data.IFilter filter) { }
        private System.Void ListChangedAdd(System.Data.DataViewListener listener) { }
        private System.Void ListChangedRemove(System.Data.DataViewListener listener) { }
        private System.Int32 get_RefCount() { }
        private System.Void AddRef() { }
        private System.Int32 RemoveRef() { }
        private System.Void ApplyChangeAction(System.Int32 record, System.Int32 action, System.Int32 changeRecord) { }
        private System.Boolean CheckUnique() { }
        private System.Int32 CompareRecords(System.Int32 record1, System.Int32 record2) { }
        private System.Int32 CompareDataRows(System.Int32 record1, System.Int32 record2) { }
        private System.Int32 CompareDuplicateRecords(System.Int32 record1, System.Int32 record2) { }
        private System.Int32 CompareRecordToKey(System.Int32 record1, System.Object[] vals) { }
        private System.Void DeleteRecordFromIndex(System.Int32 recordIndex) { }
        private System.Void DeleteRecord(System.Int32 recordIndex) { }
        private System.Void DeleteRecord(System.Int32 recordIndex, System.Boolean fireEvent) { }
        private System.Data.RBTree.RBTreeEnumerator<System.Int32> GetEnumerator(System.Int32 startIndex) { }
        private System.Int32 GetIndex(System.Int32 record) { }
        private System.Int32 GetIndex(System.Int32 record, System.Int32 changeRecord) { }
        private System.Object[] GetUniqueKeyValues() { }
        private System.Int32 FindNodeByKey(System.Object originalKey) { }
        private System.Int32 FindNodeByKeys(System.Object[] originalKey) { }
        private System.Int32 FindNodeByKeyRecord(System.Int32 record) { }
        private System.Data.Range GetRangeFromNode(System.Int32 nodeId) { }
        private System.Data.Range FindRecords(System.Object key) { }
        private System.Data.Range FindRecords(System.Object[] key) { }
        private System.Void FireResetEvent() { }
        private System.Int32 GetChangeAction(System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState) { }
        private System.Int32 GetReplaceAction(System.Data.DataViewRowState oldState) { }
        private System.Data.DataRow GetRow(System.Int32 i) { }
        private System.Data.DataRow[] GetRows(System.Object[] values) { }
        private System.Data.DataRow[] GetRows(System.Data.Range range) { }
        private System.Void InitRecords(System.Data.IFilter filter) { }
        private System.Int32 InsertRecordToIndex(System.Int32 record) { }
        private System.Int32 InsertRecord(System.Int32 record, System.Boolean fireEvent) { }
        private System.Boolean IsKeyInIndex(System.Object key) { }
        private System.Boolean IsKeyInIndex(System.Object[] key) { }
        private System.Boolean IsKeyRecordInIndex(System.Int32 record) { }
        private System.Boolean get_DoListChanged() { }
        private System.Void OnListChanged(System.ComponentModel.ListChangedType changedType, System.Int32 newIndex, System.Int32 oldIndex) { }
        private System.Void OnListChanged(System.ComponentModel.ListChangedType changedType, System.Int32 index) { }
        private System.Void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
        private System.Void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Int32 record, System.Boolean trackAddRemove) { }
        private System.Void Reset() { }
        private System.Void RecordChanged(System.Int32 record) { }
        private System.Void RecordChanged(System.Int32 oldIndex, System.Int32 newIndex) { }
        private System.Void RecordStateChanged(System.Int32 record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState) { }
        private System.Void RecordStateChanged(System.Int32 oldRecord, System.Data.DataViewRowState oldOldState, System.Data.DataViewRowState oldNewState, System.Int32 newRecord, System.Data.DataViewRowState newOldState, System.Data.DataViewRowState newNewState) { }
        private System.Data.DataTable get_Table() { }
        private System.Void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, System.Int32 curNodeId) { }
        private System.Int32 IndexOfReference(System.Collections.Generic.List<T> list, T item) { }

    }

    // TypeToken: 0x2000082
    public class Listeners`1
    {
        // Fields
        private readonly System.Collections.Generic.List<TElem> _listeners;        // 0x0
        private readonly System.Data.Listeners.Func<TElem,TElem,System.Boolean> _filter;        // 0x0
        private readonly System.Int32 _objectID;        // 0x0
        private System.Int32 _listenerReaderCount;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 ObjectID, System.Data.Listeners.Func<TElem,TElem,System.Boolean> notifyFilter) { }
        private System.Boolean get_HasListeners() { }
        private System.Void Add(TElem listener) { }
        private System.Int32 IndexOfReference(TElem listener) { }
        private System.Void Remove(TElem listener) { }
        private System.Void Notify(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem,TElem,T1,T2,T3> action) { }
        private System.Void RemoveNullListeners(System.Int32 nullIndex) { }

    }

    // TypeToken: 0x2000085
    public class SimpleType, ISerializable
    {
        // Fields
        private System.String _baseType;        // 0x10
        private System.Data.SimpleType _baseSimpleType;        // 0x18
        private System.Xml.XmlQualifiedName _xmlBaseType;        // 0x20
        private System.String _name;        // 0x28
        private System.Int32 _length;        // 0x30
        private System.Int32 _minLength;        // 0x34
        private System.Int32 _maxLength;        // 0x38
        private System.String _pattern;        // 0x40
        private System.String _ns;        // 0x48
        private System.String _maxExclusive;        // 0x50
        private System.String _maxInclusive;        // 0x58
        private System.String _minExclusive;        // 0x60
        private System.String _minInclusive;        // 0x68
        private System.String _enumeration;        // 0x70

        // Methods
        private System.Void .ctor(System.String baseType) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaSimpleType node) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void LoadTypeValues(System.Xml.Schema.XmlSchemaSimpleType node) { }
        private System.Boolean IsPlainString() { }
        private System.String get_BaseType() { }
        private System.Xml.XmlQualifiedName get_XmlBaseType() { }
        private System.String get_Name() { }
        private System.String get_Namespace() { }
        private System.Int32 get_Length() { }
        private System.Int32 get_MaxLength() { }
        private System.Void set_MaxLength(System.Int32 value) { }
        private System.Data.SimpleType get_BaseSimpleType() { }
        private System.String get_SimpleTypeQualifiedName() { }
        private System.String QualifiedName(System.String name) { }
        private System.Xml.XmlNode ToNode(System.Xml.XmlDocument dc, System.Collections.Hashtable prefixes, System.Boolean inRemoting) { }
        private System.Data.SimpleType CreateEnumeratedType(System.String values) { }
        private System.Data.SimpleType CreateByteArrayType(System.String encoding) { }
        private System.Data.SimpleType CreateLimitedStringType(System.Int32 length) { }
        private System.Data.SimpleType CreateSimpleType(System.Data.Common.StorageType typeCode, System.Type type) { }
        private System.String HasConflictingDefinition(System.Data.SimpleType otherSimpleType) { }
        private System.Boolean CanHaveMaxLength() { }
        private System.Void ConvertToAnnonymousSimpleType() { }

    }

    // TypeToken: 0x2000086
    public class UniqueConstraint : Constraint
    {
        // Fields
        private System.Data.DataKey _key;        // 0x38
        private System.Data.Index _constraintIndex;        // 0x40
        private System.Boolean _bPrimaryKey;        // 0x48
        private System.String _constraintName;        // 0x50
        private System.String[] _columnNames;        // 0x58

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Void .ctor(System.String name, System.Data.DataColumn[] columns) { }
        private System.Void .ctor(System.Data.DataColumn[] columns) { }
        private System.Void .ctor(System.String name, System.String[] columnNames, System.Boolean isPrimaryKey) { }
        private System.Void .ctor(System.String name, System.Data.DataColumn[] columns, System.Boolean isPrimaryKey) { }
        private System.String[] get_ColumnNames() { }
        private System.Data.Index get_ConstraintIndex() { }
        private System.Void ConstraintIndexClear() { }
        private System.Void ConstraintIndexInitialize() { }
        private System.Void CheckState() { }
        private System.Void NonVirtualCheckState() { }
        private System.Void CheckCanAddToCollection(System.Data.ConstraintCollection constraints) { }
        private System.Boolean CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, System.Boolean fThrowException) { }
        private System.Boolean CanEnableConstraint() { }
        private System.Boolean IsConstraintViolated() { }
        private System.Void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action) { }
        private System.Boolean ContainsColumn(System.Data.DataColumn column) { }
        private System.Data.Constraint Clone(System.Data.DataSet destination) { }
        private System.Data.Constraint Clone(System.Data.DataSet destination, System.Boolean ignorNSforTableLookup) { }
        private System.Data.UniqueConstraint Clone(System.Data.DataTable table) { }
        private System.Data.DataColumn[] get_Columns() { }
        private System.Data.DataColumn[] get_ColumnsReference() { }
        private System.Boolean get_IsPrimaryKey() { }
        private System.Void Create(System.String constraintName, System.Data.DataColumn[] columns) { }
        private System.Boolean Equals(System.Object key2) { }
        private System.Int32 GetHashCode() { }
        private System.Void set_InCollection(System.Boolean value) { }
        private System.Data.DataKey get_Key() { }
        private System.Data.DataTable get_Table() { }

    }

    // TypeToken: 0x2000087
    public class XDRSchema : XMLSchema
    {
        // Fields
        private System.String _schemaName;        // 0x10
        private System.String _schemaUri;        // 0x18
        private System.Xml.XmlElement _schemaRoot;        // 0x20
        private System.Data.DataSet _ds;        // 0x28
        private static readonly System.Char[] s_colonArray;        // 0x0
        private static System.Data.XDRSchema.NameType[] s_mapNameTypeXdr;        // 0x8
        private static System.Data.XDRSchema.NameType s_enumerationNameType;        // 0x10

        // Methods
        private System.Void .ctor(System.Data.DataSet ds, System.Boolean fInline) { }
        private System.Void LoadSchema(System.Xml.XmlElement schemaRoot, System.Data.DataSet ds) { }
        private System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node) { }
        private System.Boolean IsTextOnlyContent(System.Xml.XmlElement node) { }
        private System.Boolean IsXDRField(System.Xml.XmlElement node, System.Xml.XmlElement typeNode) { }
        private System.Data.DataTable HandleTable(System.Xml.XmlElement node) { }
        private System.Data.XDRSchema.NameType FindNameType(System.String name) { }
        private System.Type ParseDataType(System.String dt, System.String dtValues) { }
        private System.String GetInstanceName(System.Xml.XmlElement node) { }
        private System.Void HandleColumn(System.Xml.XmlElement node, System.Data.DataTable table) { }
        private System.Void GetMinMax(System.Xml.XmlElement elNode, System.Int32& minOccurs, System.Int32& maxOccurs) { }
        private System.Void GetMinMax(System.Xml.XmlElement elNode, System.Boolean isAttribute, System.Int32& minOccurs, System.Int32& maxOccurs) { }
        private System.Void HandleTypeNode(System.Xml.XmlElement typeNode, System.Data.DataTable table, System.Collections.ArrayList tableChildren) { }
        private System.Data.DataTable InstantiateTable(System.Data.DataSet dataSet, System.Xml.XmlElement node, System.Xml.XmlElement typeNode) { }
        private System.Data.DataTable InstantiateSimpleTable(System.Data.DataSet dataSet, System.Xml.XmlElement node) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000089
    public class XMLDiffLoader
    {
        // Fields
        private System.Collections.ArrayList _tables;        // 0x10
        private System.Data.DataSet _dataSet;        // 0x18
        private System.Data.DataTable _dataTable;        // 0x20

        // Methods
        private System.Void LoadDiffGram(System.Data.DataSet ds, System.Xml.XmlReader dataTextReader) { }
        private System.Void CreateTablesHierarchy(System.Data.DataTable dt) { }
        private System.Void LoadDiffGram(System.Data.DataTable dt, System.Xml.XmlReader dataTextReader) { }
        private System.Void ProcessDiffs(System.Data.DataSet ds, System.Xml.XmlReader ssync) { }
        private System.Void ProcessDiffs(System.Collections.ArrayList tableList, System.Xml.XmlReader ssync) { }
        private System.Void ProcessErrors(System.Data.DataSet ds, System.Xml.XmlReader ssync) { }
        private System.Void ProcessErrors(System.Collections.ArrayList dt, System.Xml.XmlReader ssync) { }
        private System.Data.DataTable GetTable(System.String tableName, System.String ns) { }
        private System.Int32 ReadOldRowData(System.Data.DataSet ds, System.Data.DataTable& table, System.Int32& pos, System.Xml.XmlReader row) { }
        private System.Void SkipWhitespaces(System.Xml.XmlReader reader) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008A
    public class XMLSchema
    {
        // Methods
        private System.ComponentModel.TypeConverter GetConverter(System.Type type) { }
        private System.Void SetProperties(System.Object instance, System.Xml.XmlAttributeCollection attrs) { }
        private System.Boolean FEqualIdentity(System.Xml.XmlNode node, System.String name, System.String ns) { }
        private System.Boolean GetBooleanAttribute(System.Xml.XmlElement element, System.String attrName, System.String attrNS, System.Boolean defVal) { }
        private System.String GenUniqueColumnName(System.String proposedName, System.Data.DataTable table) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008B
    public class ConstraintTable
    {
        // Fields
        public System.Data.DataTable table;        // 0x10
        public System.Xml.Schema.XmlSchemaIdentityConstraint constraint;        // 0x18

        // Methods
        private System.Void .ctor(System.Data.DataTable t, System.Xml.Schema.XmlSchemaIdentityConstraint c) { }

    }

    // TypeToken: 0x200008C
    public class XSDSchema : XMLSchema
    {
        // Fields
        private System.Xml.Schema.XmlSchemaSet _schemaSet;        // 0x10
        private System.Xml.Schema.XmlSchemaElement _dsElement;        // 0x18
        private System.Data.DataSet _ds;        // 0x20
        private System.String _schemaName;        // 0x28
        private System.Collections.ArrayList _columnExpressions;        // 0x30
        private System.Collections.Hashtable _constraintNodes;        // 0x38
        private System.Collections.ArrayList _refTables;        // 0x40
        private System.Collections.ArrayList _complexTypes;        // 0x48
        private System.Xml.Schema.XmlSchemaObjectCollection _annotations;        // 0x50
        private System.Xml.Schema.XmlSchemaObjectCollection _elements;        // 0x58
        private System.Collections.Hashtable _attributes;        // 0x60
        private System.Collections.Hashtable _elementsTable;        // 0x68
        private System.Collections.Hashtable _attributeGroups;        // 0x70
        private System.Collections.Hashtable _schemaTypes;        // 0x78
        private System.Collections.Hashtable _expressions;        // 0x80
        private System.Collections.Generic.Dictionary<System.Data.DataTable,System.Collections.Generic.List<System.Data.DataTable>> _tableDictionary;        // 0x88
        private System.Collections.Hashtable _udSimpleTypes;        // 0x90
        private System.Collections.Hashtable _existingSimpleTypeMap;        // 0x98
        private System.Boolean _fromInference;        // 0xA0
        private static readonly System.Data.XSDSchema.NameType[] s_mapNameTypeXsd;        // 0x0

        // Methods
        private System.Boolean get_FromInference() { }
        private System.Void set_FromInference(System.Boolean value) { }
        private System.Void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema) { }
        private System.Void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList schemaList) { }
        private System.String QualifiedName(System.String name) { }
        private System.Void SetProperties(System.Object instance, System.Xml.XmlAttribute[] attrs) { }
        private System.Void SetExtProperties(System.Object instance, System.Xml.XmlAttribute[] attrs) { }
        private System.Void HandleColumnExpression(System.Object instance, System.Xml.XmlAttribute[] attrs) { }
        private System.String GetMsdataAttribute(System.Xml.Schema.XmlSchemaAnnotated node, System.String ln) { }
        private System.Void SetExtProperties(System.Object instance, System.Xml.XmlAttributeCollection attrs) { }
        private System.Void HandleRefTableProperties(System.Collections.ArrayList RefTables, System.Xml.Schema.XmlSchemaElement element) { }
        private System.Void HandleRelation(System.Xml.XmlElement node, System.Boolean fNested) { }
        private System.Boolean HasAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes) { }
        private System.Boolean IsDatasetParticle(System.Xml.Schema.XmlSchemaParticle pt) { }
        private System.Int32 DatasetElementCount(System.Xml.Schema.XmlSchemaObjectCollection elements) { }
        private System.Xml.Schema.XmlSchemaElement FindDatasetElement(System.Xml.Schema.XmlSchemaObjectCollection elements) { }
        private System.Void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataTable dt) { }
        private System.Void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataSet ds) { }
        private System.Void HandleRelations(System.Xml.Schema.XmlSchemaAnnotation ann, System.Boolean fNested) { }
        private System.Xml.Schema.XmlSchemaObjectCollection GetParticleItems(System.Xml.Schema.XmlSchemaParticle pt) { }
        private System.Void HandleParticle(System.Xml.Schema.XmlSchemaParticle pt, System.Data.DataTable table, System.Collections.ArrayList tableChildren, System.Boolean isBase) { }
        private System.Void HandleAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Data.DataTable table, System.Boolean isBase) { }
        private System.Void HandleAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Data.DataTable table, System.Boolean isBase) { }
        private System.Void HandleComplexType(System.Xml.Schema.XmlSchemaComplexType ct, System.Data.DataTable table, System.Collections.ArrayList tableChildren, System.Boolean isNillable) { }
        private System.Xml.Schema.XmlSchemaParticle GetParticle(System.Xml.Schema.XmlSchemaComplexType ct) { }
        private System.Data.DataColumn FindField(System.Data.DataTable table, System.String field) { }
        private System.Data.DataColumn[] BuildKey(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode, System.Data.DataTable table) { }
        private System.Boolean GetBooleanAttribute(System.Xml.Schema.XmlSchemaAnnotated element, System.String attrName, System.Boolean defVal) { }
        private System.String GetStringAttribute(System.Xml.Schema.XmlSchemaAnnotated element, System.String attrName, System.String defVal) { }
        private System.Data.AcceptRejectRule TranslateAcceptRejectRule(System.String strRule) { }
        private System.Data.Rule TranslateRule(System.String strRule) { }
        private System.Void HandleKeyref(System.Xml.Schema.XmlSchemaKeyref keyref) { }
        private System.Void HandleConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode) { }
        private System.Data.DataTable InstantiateSimpleTable(System.Xml.Schema.XmlSchemaElement node) { }
        private System.String GetInstanceName(System.Xml.Schema.XmlSchemaAnnotated node) { }
        private System.Data.DataTable InstantiateTable(System.Xml.Schema.XmlSchemaElement node, System.Xml.Schema.XmlSchemaComplexType typeNode, System.Boolean isRef) { }
        private System.Type XsdtoClr(System.String xsdTypeName) { }
        private System.Data.XSDSchema.NameType FindNameType(System.String name) { }
        private System.Type ParseDataType(System.String dt) { }
        private System.Boolean IsXsdType(System.String name) { }
        private System.Xml.Schema.XmlSchemaAnnotated FindTypeNode(System.Xml.Schema.XmlSchemaAnnotated node) { }
        private System.Void HandleSimpleTypeSimpleContentColumn(System.Xml.Schema.XmlSchemaSimpleType typeNode, System.String strType, System.Data.DataTable table, System.Boolean isBase, System.Xml.XmlAttribute[] attrs, System.Boolean isNillable) { }
        private System.Void HandleSimpleContentColumn(System.String strType, System.Data.DataTable table, System.Boolean isBase, System.Xml.XmlAttribute[] attrs, System.Boolean isNillable) { }
        private System.Void HandleAttributeColumn(System.Xml.Schema.XmlSchemaAttribute attrib, System.Data.DataTable table, System.Boolean isBase) { }
        private System.Void HandleElementColumn(System.Xml.Schema.XmlSchemaElement elem, System.Data.DataTable table, System.Boolean isBase) { }
        private System.Void HandleDataSet(System.Xml.Schema.XmlSchemaElement node, System.Boolean isNewDataSet) { }
        private System.Void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Data.DataTable dt) { }
        private System.String GetPrefix(System.String ns) { }
        private System.String GetNamespaceFromPrefix(System.String prefix) { }
        private System.String GetTableNamespace(System.Xml.Schema.XmlSchemaIdentityConstraint key) { }
        private System.String GetTableName(System.Xml.Schema.XmlSchemaIdentityConstraint key) { }
        private System.Boolean IsTable(System.Xml.Schema.XmlSchemaElement node) { }
        private System.Data.DataTable HandleTable(System.Xml.Schema.XmlSchemaElement node) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200008E
    public class XmlIgnoreNamespaceReader : XmlNodeReader
    {
        // Fields
        private System.Collections.Generic.List<System.String> _namespacesToIgnore;        // 0x30

        // Methods
        private System.Void .ctor(System.Xml.XmlDocument xdoc, System.String[] namespacesToIgnore) { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }

    }

    // TypeToken: 0x200008F
    public class XmlDataLoader
    {
        // Fields
        private System.Data.DataSet _dataSet;        // 0x10
        private System.Data.XmlToDatasetMap _nodeToSchemaMap;        // 0x18
        private System.Collections.Hashtable _nodeToRowMap;        // 0x20
        private System.Collections.Stack _childRowsStack;        // 0x28
        private System.Collections.Hashtable _htableExcludedNS;        // 0x30
        private System.Boolean _fIsXdr;        // 0x38
        private System.Boolean _isDiffgram;        // 0x39
        private System.Xml.XmlElement _topMostNode;        // 0x40
        private System.Boolean _ignoreSchema;        // 0x48
        private System.Data.DataTable _dataTable;        // 0x50
        private System.Boolean _isTableLevel;        // 0x58
        private System.Boolean _fromInference;        // 0x59
        private System.Xml.XmlReader _dataReader;        // 0x60
        private System.Object _XSD_XMLNS_NS;        // 0x68
        private System.Object _XDR_SCHEMA;        // 0x70
        private System.Object _XDRNS;        // 0x78
        private System.Object _SQL_SYNC;        // 0x80
        private System.Object _UPDGNS;        // 0x88
        private System.Object _XSD_SCHEMA;        // 0x90
        private System.Object _XSDNS;        // 0x98
        private System.Object _DFFNS;        // 0xA0
        private System.Object _MSDNS;        // 0xA8
        private System.Object _DIFFID;        // 0xB0
        private System.Object _HASCHANGES;        // 0xB8
        private System.Object _ROWORDER;        // 0xC0

        // Methods
        private System.Void .ctor(System.Data.DataSet dataset, System.Boolean IsXdr, System.Boolean ignoreSchema) { }
        private System.Void .ctor(System.Data.DataSet dataset, System.Boolean IsXdr, System.Xml.XmlElement topNode, System.Boolean ignoreSchema) { }
        private System.Void .ctor(System.Data.DataTable datatable, System.Boolean IsXdr, System.Boolean ignoreSchema) { }
        private System.Void .ctor(System.Data.DataTable datatable, System.Boolean IsXdr, System.Xml.XmlElement topNode, System.Boolean ignoreSchema) { }
        private System.Boolean get_FromInference() { }
        private System.Void set_FromInference(System.Boolean value) { }
        private System.Void AttachRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement) { }
        private System.Int32 CountNonNSAttributes(System.Xml.XmlNode node) { }
        private System.String GetValueForTextOnlyColums(System.Xml.XmlNode n) { }
        private System.String GetInitialTextFromNodes(System.Xml.XmlNode& n) { }
        private System.Data.DataColumn GetTextOnlyColumn(System.Data.DataRow row) { }
        private System.Data.DataRow GetRowFromElement(System.Xml.XmlElement e) { }
        private System.Boolean FColumnElement(System.Xml.XmlElement e) { }
        private System.Boolean FExcludedNamespace(System.String ns) { }
        private System.Boolean FIgnoreNamespace(System.Xml.XmlNode node) { }
        private System.Boolean FIgnoreNamespace(System.Xml.XmlReader node) { }
        private System.Boolean IsTextLikeNode(System.Xml.XmlNodeType n) { }
        private System.Boolean IsTextOnly(System.Data.DataColumn c) { }
        private System.Void LoadData(System.Xml.XmlDocument xdoc) { }
        private System.Void LoadRowData(System.Data.DataRow row, System.Xml.XmlElement rowElement) { }
        private System.Void LoadRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement) { }
        private System.Void SetRowValueFromXmlText(System.Data.DataRow row, System.Data.DataColumn col, System.String xmlText) { }
        private System.Void InitNameTable() { }
        private System.Void LoadData(System.Xml.XmlReader reader) { }
        private System.Void LoadTopMostTable(System.Data.DataTable table) { }
        private System.Void LoadTable(System.Data.DataTable table, System.Boolean isNested) { }
        private System.Void LoadColumn(System.Data.DataColumn column, System.Object[] foundColumns) { }
        private System.Boolean ProcessXsdSchema() { }

    }

    // TypeToken: 0x2000090
    public struct XmlReadMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.XmlReadMode Auto;        // 0x0
        public static System.Data.XmlReadMode ReadSchema;        // 0x0
        public static System.Data.XmlReadMode IgnoreSchema;        // 0x0
        public static System.Data.XmlReadMode InferSchema;        // 0x0
        public static System.Data.XmlReadMode DiffGram;        // 0x0
        public static System.Data.XmlReadMode Fragment;        // 0x0
        public static System.Data.XmlReadMode InferTypedSchema;        // 0x0

    }

    // TypeToken: 0x2000091
    public class XmlToDatasetMap
    {
        // Fields
        private System.Data.XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap;        // 0x10
        private System.Data.XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo;        // 0x18

        // Methods
        private System.Void .ctor(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable) { }
        private System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet) { }
        private System.Void .ctor(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable) { }
        private System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable) { }
        private System.Boolean IsMappedColumn(System.Data.DataColumn c) { }
        private System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Data.DataTable table, System.Xml.XmlNameTable nameTable) { }
        private System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Xml.XmlNameTable nameTable, System.Data.DataTable table) { }
        private System.Boolean AddColumnSchema(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns) { }
        private System.Boolean AddColumnSchema(System.Xml.XmlNameTable nameTable, System.Data.DataColumn col, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns) { }
        private System.Void BuildIdentityMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable) { }
        private System.Void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet) { }
        private System.Void BuildIdentityMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable) { }
        private System.Void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable) { }
        private System.Collections.ArrayList GetSelfAndDescendants(System.Data.DataTable dt) { }
        private System.Object GetColumnSchema(System.Xml.XmlNode node, System.Boolean fIgnoreNamespace) { }
        private System.Object GetColumnSchema(System.Data.DataTable table, System.Xml.XmlReader dataReader, System.Boolean fIgnoreNamespace) { }
        private System.Object GetSchemaForNode(System.Xml.XmlNode node, System.Boolean fIgnoreNamespace) { }
        private System.Data.DataTable GetTableForNode(System.Xml.XmlReader node, System.Boolean fIgnoreNamespace) { }
        private System.Void HandleSpecialColumn(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns) { }

    }

    // TypeToken: 0x2000095
    public struct XmlWriteMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.XmlWriteMode WriteSchema;        // 0x0
        public static System.Data.XmlWriteMode IgnoreSchema;        // 0x0
        public static System.Data.XmlWriteMode DiffGram;        // 0x0

    }

    // TypeToken: 0x2000096
    public struct SchemaFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.SchemaFormat Public;        // 0x0
        public static System.Data.SchemaFormat Remoting;        // 0x0
        public static System.Data.SchemaFormat WebService;        // 0x0
        public static System.Data.SchemaFormat RemotingSkipSchema;        // 0x0
        public static System.Data.SchemaFormat WebServiceSkipSchema;        // 0x0

    }

    // TypeToken: 0x2000097
    public class XmlTreeGen
    {
        // Fields
        private System.Collections.ArrayList _constraintNames;        // 0x10
        private System.Collections.Hashtable _namespaces;        // 0x18
        private System.Collections.Hashtable _autogenerated;        // 0x20
        private System.Collections.Hashtable _prefixes;        // 0x28
        private System.Data.DataSet _ds;        // 0x30
        private System.Collections.ArrayList _tables;        // 0x38
        private System.Collections.ArrayList _relations;        // 0x40
        private System.Xml.XmlDocument _dc;        // 0x48
        private System.Xml.XmlElement _sRoot;        // 0x50
        private System.Int32 _prefixCount;        // 0x58
        private System.Data.SchemaFormat _schFormat;        // 0x5C
        private System.String _filePath;        // 0x60
        private System.String _fileName;        // 0x68
        private System.String _fileExt;        // 0x70
        private System.Xml.XmlElement _dsElement;        // 0x78
        private System.Xml.XmlElement _constraintSeparator;        // 0x80
        private System.Converter<System.Type,System.String> _targetConverter;        // 0x88

        // Methods
        private System.Void .ctor(System.Data.SchemaFormat format) { }
        private System.Void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node) { }
        private System.Void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node, System.Type type) { }
        private System.Void AddXdoProperties(System.Object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd) { }
        private System.Void AddXdoProperty(System.ComponentModel.PropertyDescriptor pd, System.Object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd) { }
        private System.String XmlDataTypeName(System.Type type) { }
        private System.Void GenerateConstraintNames(System.Data.DataTable table, System.Boolean fromTable) { }
        private System.Void GenerateConstraintNames(System.Collections.ArrayList tables) { }
        private System.Void GenerateConstraintNames(System.Data.DataSet ds) { }
        private System.Boolean _PropsNotEmpty(System.Data.PropertyCollection props) { }
        private System.Boolean HaveExtendedProperties(System.Data.DataSet ds) { }
        private System.Void WriteSchemaRoot(System.Xml.XmlDocument xd, System.Xml.XmlElement rootSchema, System.String targetNamespace) { }
        private System.Void ValidateColumnMapping(System.Type columnType) { }
        private System.Void SetupAutoGenerated(System.Data.DataSet ds) { }
        private System.Void SetupAutoGenerated(System.Collections.ArrayList dt) { }
        private System.Void SetupAutoGenerated(System.Data.DataTable dt) { }
        private System.Void CreateTablesHierarchy(System.Data.DataTable dt) { }
        private System.Void CreateRelations(System.Data.DataTable dt) { }
        private System.Data.DataTable[] CreateToplevelTables() { }
        private System.Void SchemaTree(System.Xml.XmlDocument xd, System.Xml.XmlWriter xmlWriter, System.Data.DataSet ds, System.Data.DataTable dt, System.Boolean writeHierarchy) { }
        private System.Xml.XmlElement SchemaTree(System.Xml.XmlDocument xd, System.Data.DataTable dt) { }
        private System.Xml.XmlElement FillDataSetElement(System.Xml.XmlDocument xd, System.Data.DataSet ds, System.Data.DataTable dt) { }
        private System.Void SetPath(System.Xml.XmlWriter xw) { }
        private System.Void Save(System.Data.DataSet ds, System.Xml.XmlWriter xw) { }
        private System.Void Save(System.Data.DataTable dt, System.Xml.XmlWriter xw) { }
        private System.Void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw) { }
        private System.Void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, System.Boolean writeHierarchy) { }
        private System.Void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, System.Boolean writeHierarchy, System.Converter<System.Type,System.String> multipleTargetConverter) { }
        private System.Xml.XmlElement HandleRelation(System.Data.DataRelation rel, System.Xml.XmlDocument dc) { }
        private System.Xml.XmlElement FindSimpleType(System.Xml.XmlElement schema, System.String name) { }
        private System.Xml.XmlElement GetSchema(System.String NamespaceURI) { }
        private System.Void HandleColumnType(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement root, System.Xml.XmlElement schema) { }
        private System.Void AddColumnProperties(System.Data.DataColumn col, System.Xml.XmlElement root) { }
        private System.String FindTargetNamespace(System.Data.DataTable table) { }
        private System.Xml.XmlElement HandleColumn(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, System.Boolean fWriteOrdinal) { }
        private System.String TranslateAcceptRejectRule(System.Data.AcceptRejectRule rule) { }
        private System.String TranslateRule(System.Data.Rule rule) { }
        private System.Void AppendChildWithoutRef(System.Xml.XmlElement node, System.String Namespace, System.Xml.XmlElement el, System.String refString) { }
        private System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node, System.String strType) { }
        private System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema) { }
        private System.Boolean HasMixedColumns(System.Data.DataTable table) { }
        private System.Boolean AutoGenerated(System.Data.DataColumn col) { }
        private System.Boolean AutoGenerated(System.Data.DataRelation rel) { }
        private System.Boolean AutoGenerated(System.Data.UniqueConstraint unique) { }
        private System.Boolean AutoGenerated(System.Data.ForeignKeyConstraint fk) { }
        private System.Boolean AutoGenerated(System.Data.ForeignKeyConstraint fk, System.Boolean checkRelation) { }
        private System.Boolean IsAutoGenerated(System.Object o) { }
        private System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, System.Boolean genNested) { }
        private System.Void SetMSDataAttribute(System.Xml.XmlElement root, System.Type type) { }

    }

    // TypeToken: 0x2000098
    public class NewDiffgramGen
    {
        // Fields
        private System.Xml.XmlDocument _doc;        // 0x10
        private System.Data.DataSet _ds;        // 0x18
        private System.Data.DataTable _dt;        // 0x20
        private System.Xml.XmlWriter _xmlw;        // 0x28
        private System.Boolean _fBefore;        // 0x30
        private System.Boolean _fErrors;        // 0x31
        private System.Collections.Hashtable _rowsOrder;        // 0x38
        private System.Collections.ArrayList _tables;        // 0x40
        private System.Boolean _writeHierarchy;        // 0x48

        // Methods
        private System.Void .ctor(System.Data.DataSet ds) { }
        private System.Void .ctor(System.Data.DataTable dt, System.Boolean writeHierarchy) { }
        private System.Void CreateTableHierarchy(System.Data.DataTable dt) { }
        private System.Void DoAssignments(System.Collections.ArrayList tables) { }
        private System.Boolean EmptyData() { }
        private System.Void Save(System.Xml.XmlWriter xmlw) { }
        private System.Void Save(System.Xml.XmlWriter xmlw, System.Data.DataTable table) { }
        private System.Void GenerateTable(System.Data.DataTable table) { }
        private System.Void GenerateTableErrors(System.Data.DataTable table) { }
        private System.Void GenerateRow(System.Data.DataRow row) { }
        private System.Void GenerateColumn(System.Data.DataRow row, System.Data.DataColumn col, System.Data.DataRowVersion version) { }
        private System.String QualifiedName(System.String prefix, System.String name) { }

    }

    // TypeToken: 0x2000099
    public class XmlDataTreeWriter
    {
        // Fields
        private System.Xml.XmlWriter _xmlw;        // 0x10
        private System.Data.DataSet _ds;        // 0x18
        private System.Data.DataTable _dt;        // 0x20
        private System.Collections.ArrayList _dTables;        // 0x28
        private System.Data.DataTable[] _topLevelTables;        // 0x30
        private System.Boolean _fFromTable;        // 0x38
        private System.Boolean _isDiffgram;        // 0x39
        private System.Collections.Hashtable _rowsOrder;        // 0x40
        private System.Boolean _writeHierarchy;        // 0x48

        // Methods
        private System.Void .ctor(System.Data.DataSet ds) { }
        private System.Void .ctor(System.Data.DataTable dt, System.Boolean writeHierarchy) { }
        private System.Data.DataTable[] CreateToplevelTables() { }
        private System.Void CreateTablesHierarchy(System.Data.DataTable dt) { }
        private System.Boolean RowHasErrors(System.Data.DataRow row) { }
        private System.Void SaveDiffgramData(System.Xml.XmlWriter xw, System.Collections.Hashtable rowsOrder) { }
        private System.Void Save(System.Xml.XmlWriter xw, System.Boolean writeSchema) { }
        private System.Collections.ArrayList GetNestedChildRelations(System.Data.DataRow row) { }
        private System.Void XmlDataRowWriter(System.Data.DataRow row, System.String encodedTableName) { }
        private System.Boolean PreserveSpace(System.Object value) { }

    }

    // TypeToken: 0x200009A
    public class DataTextWriter : XmlWriter
    {
        // Fields
        private System.Xml.XmlWriter _xmltextWriter;        // 0x18

        // Methods
        private System.Xml.XmlWriter CreateWriter(System.Xml.XmlWriter xw) { }
        private System.Void .ctor(System.Xml.XmlWriter w) { }
        private System.IO.Stream get_BaseStream() { }
        private System.Void WriteStartDocument() { }
        private System.Void WriteStartDocument(System.Boolean standalone) { }
        private System.Void WriteEndDocument() { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndElement() { }
        private System.Void WriteFullEndElement() { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndAttribute() { }
        private System.Void WriteCData(System.String text) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void WriteProcessingInstruction(System.String name, System.String text) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteWhitespace(System.String ws) { }
        private System.Void WriteString(System.String text) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.String data) { }
        private System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteBinHex(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Xml.WriteState get_WriteState() { }
        private System.Void Close() { }
        private System.Void Flush() { }
        private System.String LookupPrefix(System.String ns) { }

    }

    // TypeToken: 0x200009B
    public class DataTextReader : XmlReader
    {
        // Fields
        private System.Xml.XmlReader _xmlreader;        // 0x10

        // Methods
        private System.Xml.XmlReader CreateReader(System.Xml.XmlReader xr) { }
        private System.Void .ctor(System.Xml.XmlReader input) { }
        private System.Xml.XmlReaderSettings get_Settings() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Prefix() { }
        private System.Boolean get_HasValue() { }
        private System.String get_Value() { }
        private System.Int32 get_Depth() { }
        private System.String get_BaseURI() { }
        private System.Boolean get_IsEmptyElement() { }
        private System.Boolean get_IsDefault() { }
        private System.Char get_QuoteChar() { }
        private System.Xml.XmlSpace get_XmlSpace() { }
        private System.String get_XmlLang() { }
        private System.Int32 get_AttributeCount() { }
        private System.String GetAttribute(System.String name) { }
        private System.String GetAttribute(System.String localName, System.String namespaceURI) { }
        private System.String GetAttribute(System.Int32 i) { }
        private System.Boolean MoveToAttribute(System.String name) { }
        private System.Void MoveToAttribute(System.Int32 i) { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }
        private System.Boolean MoveToElement() { }
        private System.Boolean ReadAttributeValue() { }
        private System.Boolean Read() { }
        private System.Boolean get_EOF() { }
        private System.Void Close() { }
        private System.Xml.ReadState get_ReadState() { }
        private System.Void Skip() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.Boolean get_CanResolveEntity() { }
        private System.Void ResolveEntity() { }
        private System.Boolean get_CanReadValueChunk() { }
        private System.String ReadString() { }

    }

}

namespace System.Data.Common
{

    // TypeToken: 0x20000B6
    public class ADP
    {
        // Fields
        private static readonly System.Type s_stackOverflowType;        // 0x0
        private static readonly System.Type s_outOfMemoryType;        // 0x8
        private static readonly System.Type s_threadAbortType;        // 0x10
        private static readonly System.Type s_nullReferenceType;        // 0x18
        private static readonly System.Type s_accessViolationType;        // 0x20
        private static readonly System.Type s_securityType;        // 0x28
        private static readonly System.String StrEmpty;        // 0x30
        private static readonly System.String[] AzureSqlServerEndpoints;        // 0x38
        private static readonly System.IntPtr PtrZero;        // 0x40
        private static readonly System.Int32 PtrSize;        // 0x48

        // Methods
        private System.Void TraceException(System.String trace, System.Exception e) { }
        private System.Void TraceExceptionAsReturnValue(System.Exception e) { }
        private System.Void TraceExceptionWithoutRethrow(System.Exception e) { }
        private System.ArgumentException Argument(System.String error) { }
        private System.ArgumentOutOfRangeException ArgumentOutOfRange(System.String parameterName) { }
        private System.ArgumentOutOfRangeException ArgumentOutOfRange(System.String message, System.String parameterName) { }
        private System.InvalidOperationException InvalidOperation(System.String error) { }
        private System.NotSupportedException NotSupported(System.String error) { }
        private System.Boolean IsCatchableExceptionType(System.Exception e) { }
        private System.Boolean IsCatchableOrSecurityExceptionType(System.Exception e) { }
        private System.ArgumentOutOfRangeException InvalidEnumerationValue(System.Type type, System.Int32 value) { }
        private System.Exception InvalidSeekOrigin(System.String parameterName) { }
        private System.ArgumentOutOfRangeException InvalidAcceptRejectRule(System.Data.AcceptRejectRule value) { }
        private System.ArgumentOutOfRangeException InvalidMissingSchemaAction(System.Data.MissingSchemaAction value) { }
        private System.ArgumentOutOfRangeException InvalidRule(System.Data.Rule value) { }
        private System.Exception WrongType(System.Type got, System.Type expected) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B7
    public class BigIntegerStorage : DataStorage
    {
        // Fields
        private System.Numerics.BigInteger[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Numerics.BigInteger ConvertToBigInteger(System.Object value, System.IFormatProvider formatProvider) { }
        private System.Object ConvertFromBigInteger(System.Numerics.BigInteger value, System.Type type, System.IFormatProvider formatProvider) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000B8
    public class BooleanStorage : DataStorage
    {
        // Fields
        private System.Boolean[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000B9
    public class ByteStorage : DataStorage
    {
        // Fields
        private System.Byte[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000BA
    public class CharStorage : DataStorage
    {
        // Fields
        private System.Char[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000BB
    public struct StorageType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.Common.StorageType Empty;        // 0x0
        public static System.Data.Common.StorageType Object;        // 0x0
        public static System.Data.Common.StorageType DBNull;        // 0x0
        public static System.Data.Common.StorageType Boolean;        // 0x0
        public static System.Data.Common.StorageType Char;        // 0x0
        public static System.Data.Common.StorageType SByte;        // 0x0
        public static System.Data.Common.StorageType Byte;        // 0x0
        public static System.Data.Common.StorageType Int16;        // 0x0
        public static System.Data.Common.StorageType UInt16;        // 0x0
        public static System.Data.Common.StorageType Int32;        // 0x0
        public static System.Data.Common.StorageType UInt32;        // 0x0
        public static System.Data.Common.StorageType Int64;        // 0x0
        public static System.Data.Common.StorageType UInt64;        // 0x0
        public static System.Data.Common.StorageType Single;        // 0x0
        public static System.Data.Common.StorageType Double;        // 0x0
        public static System.Data.Common.StorageType Decimal;        // 0x0
        public static System.Data.Common.StorageType DateTime;        // 0x0
        public static System.Data.Common.StorageType TimeSpan;        // 0x0
        public static System.Data.Common.StorageType String;        // 0x0
        public static System.Data.Common.StorageType Guid;        // 0x0
        public static System.Data.Common.StorageType ByteArray;        // 0x0
        public static System.Data.Common.StorageType CharArray;        // 0x0
        public static System.Data.Common.StorageType Type;        // 0x0
        public static System.Data.Common.StorageType DateTimeOffset;        // 0x0
        public static System.Data.Common.StorageType BigInteger;        // 0x0
        public static System.Data.Common.StorageType Uri;        // 0x0
        public static System.Data.Common.StorageType SqlBinary;        // 0x0
        public static System.Data.Common.StorageType SqlBoolean;        // 0x0
        public static System.Data.Common.StorageType SqlByte;        // 0x0
        public static System.Data.Common.StorageType SqlBytes;        // 0x0
        public static System.Data.Common.StorageType SqlChars;        // 0x0
        public static System.Data.Common.StorageType SqlDateTime;        // 0x0
        public static System.Data.Common.StorageType SqlDecimal;        // 0x0
        public static System.Data.Common.StorageType SqlDouble;        // 0x0
        public static System.Data.Common.StorageType SqlGuid;        // 0x0
        public static System.Data.Common.StorageType SqlInt16;        // 0x0
        public static System.Data.Common.StorageType SqlInt32;        // 0x0
        public static System.Data.Common.StorageType SqlInt64;        // 0x0
        public static System.Data.Common.StorageType SqlMoney;        // 0x0
        public static System.Data.Common.StorageType SqlSingle;        // 0x0
        public static System.Data.Common.StorageType SqlString;        // 0x0

    }

    // TypeToken: 0x20000BC
    public class DataStorage
    {
        // Fields
        private static readonly System.Type[] s_storageClassType;        // 0x0
        private readonly System.Data.DataColumn _column;        // 0x10
        private readonly System.Data.DataTable _table;        // 0x18
        private readonly System.Type _dataType;        // 0x20
        private readonly System.Data.Common.StorageType _storageTypeCode;        // 0x28
        private System.Collections.BitArray _dbNullBits;        // 0x30
        private readonly System.Object _defaultValue;        // 0x38
        private readonly System.Object _nullValue;        // 0x40
        private readonly System.Boolean _isCloneable;        // 0x48
        private readonly System.Boolean _isCustomDefinedType;        // 0x49
        private readonly System.Boolean _isStringType;        // 0x4A
        private readonly System.Boolean _isValueType;        // 0x4B
        private static readonly System.Func<System.Type,System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean>> s_inspectTypeForInterfaces;        // 0x8
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean>> s_typeImplementsInterface;        // 0x10

        // Methods
        private System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object defaultValue, System.Data.Common.StorageType storageType) { }
        private System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object defaultValue, System.Object nullValue, System.Data.Common.StorageType storageType) { }
        private System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object defaultValue, System.Object nullValue, System.Boolean isICloneable, System.Data.Common.StorageType storageType) { }
        private System.Data.DataSetDateTime get_DateTimeMode() { }
        private System.IFormatProvider get_FormatProvider() { }
        private System.Object Aggregate(System.Int32[] recordNos, System.Data.AggregateType kind) { }
        private System.Object AggregateCount(System.Int32[] recordNos) { }
        private System.Int32 CompareBits(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo1, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void CopyBits(System.Int32 srcRecordNo, System.Int32 dstRecordNo) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 recordNo) { }
        private System.Object GetBits(System.Int32 recordNo) { }
        private System.Int32 GetStringLength(System.Int32 record) { }
        private System.Boolean HasValue(System.Int32 recordNo) { }
        private System.Boolean IsNull(System.Int32 recordNo) { }
        private System.Void Set(System.Int32 recordNo, System.Object value) { }
        private System.Void SetNullBit(System.Int32 recordNo, System.Boolean flag) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib) { }
        private System.Data.Common.DataStorage CreateStorage(System.Data.DataColumn column, System.Type dataType, System.Data.Common.StorageType typeCode) { }
        private System.Data.Common.StorageType GetStorageType(System.Type dataType) { }
        private System.Type GetTypeStorage(System.Data.Common.StorageType storageType) { }
        private System.Boolean IsTypeCustomType(System.Type type) { }
        private System.Boolean IsTypeCustomType(System.Data.Common.StorageType typeCode) { }
        private System.Boolean IsSqlType(System.Data.Common.StorageType storageType) { }
        private System.Boolean IsSqlType(System.Type dataType) { }
        private System.Boolean DetermineIfValueType(System.Data.Common.StorageType typeCode, System.Type dataType) { }
        private System.Void ImplementsInterfaces(System.Data.Common.StorageType typeCode, System.Type dataType, System.Boolean& sqlType, System.Boolean& nullable, System.Boolean& xmlSerializable, System.Boolean& changeTracking, System.Boolean& revertibleChangeTracking) { }
        private System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean> InspectTypeForInterfaces(System.Type dataType) { }
        private System.Boolean ImplementsINullableValue(System.Data.Common.StorageType typeCode, System.Type dataType) { }
        private System.Boolean IsObjectNull(System.Object value) { }
        private System.Boolean IsObjectSqlNull(System.Object value) { }
        private System.Object GetEmptyStorageInternal(System.Int32 recordCount) { }
        private System.Void CopyValueInternal(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorageInternal(System.Object store, System.Collections.BitArray nullbits) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }
        private System.Void SetNullStorage(System.Collections.BitArray nullbits) { }
        private System.Type GetType(System.String value) { }
        private System.String GetQualifiedName(System.Type type) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BD
    public class DateTimeOffsetStorage : DataStorage
    {
        // Fields
        private static readonly System.DateTimeOffset s_defaultValue;        // 0x0
        private System.DateTimeOffset[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BE
    public class DateTimeStorage : DataStorage
    {
        // Fields
        private static readonly System.DateTime s_defaultValue;        // 0x0
        private System.DateTime[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BF
    public class DecimalStorage : DataStorage
    {
        // Fields
        private static readonly System.Decimal s_defaultValue;        // 0x0
        private System.Decimal[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000C0
    public class DoubleStorage : DataStorage
    {
        // Fields
        private System.Double[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000C1
    public class Int16Storage : DataStorage
    {
        // Fields
        private System.Int16[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000C2
    public class Int32Storage : DataStorage
    {
        // Fields
        private System.Int32[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000C3
    public class Int64Storage : DataStorage
    {
        // Fields
        private System.Int64[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000C4
    public class ObjectStorage : DataStorage
    {
        // Fields
        private static readonly System.Object s_defaultValue;        // 0x0
        private System.Object[] _values;        // 0x50
        private readonly System.Boolean _implementsIXmlSerializable;        // 0x58
        private static readonly System.Object s_tempAssemblyCacheLock;        // 0x8
        private static System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute>,System.Xml.Serialization.XmlSerializer> s_tempAssemblyCache;        // 0x10
        private static readonly System.Xml.Serialization.XmlSerializerFactory s_serializerFactory;        // 0x18

        // Methods
        private System.Void .ctor(System.Data.DataColumn column, System.Type type) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo1, System.Object value) { }
        private System.Int32 CompareTo(System.Object valueNo1, System.Object valueNo2) { }
        private System.Int32 CompareWithFamilies(System.Object valueNo1, System.Object valueNo2) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 recordNo) { }
        private System.Data.Common.ObjectStorage.Families GetFamily(System.Type dataType) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 recordNo, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }
        private System.Void VerifyIDynamicMetaObjectProvider(System.Type type) { }
        private System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type) { }
        private System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute attribute) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C7
    public class SByteStorage : DataStorage
    {
        // Fields
        private System.SByte[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000C8
    public class SqlConvert
    {
        // Methods
        private System.Data.SqlTypes.SqlByte ConvertToSqlByte(System.Object value) { }
        private System.Data.SqlTypes.SqlInt16 ConvertToSqlInt16(System.Object value) { }
        private System.Data.SqlTypes.SqlInt32 ConvertToSqlInt32(System.Object value) { }
        private System.Data.SqlTypes.SqlInt64 ConvertToSqlInt64(System.Object value) { }
        private System.Data.SqlTypes.SqlDouble ConvertToSqlDouble(System.Object value) { }
        private System.Data.SqlTypes.SqlDecimal ConvertToSqlDecimal(System.Object value) { }
        private System.Data.SqlTypes.SqlSingle ConvertToSqlSingle(System.Object value) { }
        private System.Data.SqlTypes.SqlMoney ConvertToSqlMoney(System.Object value) { }
        private System.Data.SqlTypes.SqlDateTime ConvertToSqlDateTime(System.Object value) { }
        private System.Data.SqlTypes.SqlBoolean ConvertToSqlBoolean(System.Object value) { }
        private System.Data.SqlTypes.SqlGuid ConvertToSqlGuid(System.Object value) { }
        private System.Data.SqlTypes.SqlBinary ConvertToSqlBinary(System.Object value) { }
        private System.Data.SqlTypes.SqlString ConvertToSqlString(System.Object value) { }
        private System.Data.SqlTypes.SqlChars ConvertToSqlChars(System.Object value) { }
        private System.Data.SqlTypes.SqlBytes ConvertToSqlBytes(System.Object value) { }
        private System.DateTimeOffset ConvertStringToDateTimeOffset(System.String value, System.IFormatProvider formatProvider) { }
        private System.Object ChangeTypeForDefaultValue(System.Object value, System.Type type, System.IFormatProvider formatProvider) { }
        private System.Object ChangeType2(System.Object value, System.Data.Common.StorageType stype, System.Type type, System.IFormatProvider formatProvider) { }
        private System.Object ChangeTypeForXML(System.Object value, System.Type type) { }

    }

    // TypeToken: 0x20000C9
    public class SqlBinaryStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlBinary[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000CA
    public class SqlByteStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlByte[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000CB
    public class SqlBytesStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlBytes[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000CC
    public class SqlCharsStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlChars[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000CD
    public class SqlDateTimeStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlDateTime[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000CE
    public class SqlDecimalStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlDecimal[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000CF
    public class SqlDoubleStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlDouble[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000D0
    public class SqlGuidStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlGuid[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000D1
    public class SqlInt16Storage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlInt16[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000D2
    public class SqlInt32Storage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlInt32[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000D3
    public class SqlInt64Storage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlInt64[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000D4
    public class SqlMoneyStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlMoney[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000D5
    public class SqlSingleStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlSingle[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000D6
    public class SqlStringStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlString[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] recordNos, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 Compare(System.Data.SqlTypes.SqlString valueNo1, System.Data.SqlTypes.SqlString valueNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Int32 GetStringLength(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000D7
    public class SqlBooleanStorage : DataStorage
    {
        // Fields
        private System.Data.SqlTypes.SqlBoolean[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000D8
    public class SingleStorage : DataStorage
    {
        // Fields
        private System.Single[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000D9
    public class SqlUdtStorage : DataStorage
    {
        // Fields
        private System.Object[] _values;        // 0x50
        private readonly System.Boolean _implementsIXmlSerializable;        // 0x58
        private readonly System.Boolean _implementsIComparable;        // 0x59
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Object> s_typeToNull;        // 0x0

        // Methods
        private System.Void .ctor(System.Data.DataColumn column, System.Type type) { }
        private System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object nullValue) { }
        private System.Object GetStaticNullForUdtType(System.Type type) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo1, System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 recordNo) { }
        private System.Void Set(System.Int32 recordNo, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000DB
    public class StringStorage : DataStorage
    {
        // Fields
        private System.String[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] recordNos, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 recordNo) { }
        private System.Int32 GetStringLength(System.Int32 record) { }
        private System.Boolean IsNull(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000DC
    public class TimeSpanStorage : DataStorage
    {
        // Fields
        private static readonly System.TimeSpan s_defaultValue;        // 0x0
        private System.TimeSpan[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.TimeSpan ConvertToTimeSpan(System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000DD
    public class UInt16Storage : DataStorage
    {
        // Fields
        private static readonly System.UInt16 s_defaultValue;        // 0x0
        private System.UInt16[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000DE
    public class UInt32Storage : DataStorage
    {
        // Fields
        private static readonly System.UInt32 s_defaultValue;        // 0x0
        private System.UInt32[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

    // TypeToken: 0x20000DF
    public class UInt64Storage : DataStorage
    {
        // Fields
        private static readonly System.UInt64 s_defaultValue;        // 0x0
        private System.UInt64[] _values;        // 0x50

        // Methods
        private System.Void .ctor(System.Data.DataColumn column) { }
        private System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind) { }
        private System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value) { }
        private System.Object ConvertValue(System.Object value) { }
        private System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2) { }
        private System.Object Get(System.Int32 record) { }
        private System.Void Set(System.Int32 record, System.Object value) { }
        private System.Void SetCapacity(System.Int32 capacity) { }
        private System.Object ConvertXmlToObject(System.String s) { }
        private System.String ConvertObjectToXml(System.Object value) { }
        private System.Object GetEmptyStorage(System.Int32 recordCount) { }
        private System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex) { }
        private System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits) { }

    }

}

namespace System.Data.SqlTypes
{

    // TypeToken: 0x200009C
    public class SQLResource
    {
        // Methods
        private System.String get_NullString() { }
        private System.String get_ArithOverflowMessage() { }
        private System.String get_DivideByZeroMessage() { }
        private System.String get_NullValueMessage() { }
        private System.String get_TruncationMessage() { }
        private System.String get_DateTimeOverflowMessage() { }
        private System.String get_ConcatDiffCollationMessage() { }
        private System.String get_CompareDiffCollationMessage() { }
        private System.String get_ConversionOverflowMessage() { }
        private System.String get_TimeZoneSpecifiedMessage() { }
        private System.String get_InvalidPrecScaleMessage() { }
        private System.String get_FormatMessage() { }
        private System.String InvalidOpStreamClosed(System.String method) { }
        private System.String InvalidOpStreamNonWritable(System.String method) { }
        private System.String InvalidOpStreamNonReadable(System.String method) { }
        private System.String InvalidOpStreamNonSeekable(System.String method) { }

    }

    // TypeToken: 0x200009D
    public interface INullable
    {
        // Methods
        private System.Boolean get_IsNull() { }

    }

    // TypeToken: 0x200009E
    public struct SqlBinary, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.Byte[] _value;        // 0x10
        public static readonly System.Data.SqlTypes.SqlBinary Null;        // 0x0

        // Methods
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.Byte[] value) { }
        private System.Boolean get_IsNull() { }
        private System.Byte[] get_Value() { }
        private System.Data.SqlTypes.SqlBinary op_Implicit(System.Byte[] x) { }
        private System.String ToString() { }
        private System.Data.SqlTypes.EComparison PerformCompareByte(System.Byte[] x, System.Byte[] y) { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { }
        private System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { }
        private System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlBinary value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 HashByteArray(System.Byte[] rgbValue, System.Int32 length) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009F
    public struct SqlBoolean, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.Byte m_value;        // 0x10
        public static readonly System.Data.SqlTypes.SqlBoolean True;        // 0x0
        public static readonly System.Data.SqlTypes.SqlBoolean False;        // 0x1
        public static readonly System.Data.SqlTypes.SqlBoolean Null;        // 0x2
        public static readonly System.Data.SqlTypes.SqlBoolean Zero;        // 0x3
        public static readonly System.Data.SqlTypes.SqlBoolean One;        // 0x4

        // Methods
        private System.Void .ctor(System.Boolean value) { }
        private System.Void .ctor(System.Int32 value) { }
        private System.Void .ctor(System.Int32 value, System.Boolean fNull) { }
        private System.Boolean get_IsNull() { }
        private System.Boolean get_Value() { }
        private System.Boolean get_IsTrue() { }
        private System.Boolean get_IsFalse() { }
        private System.Data.SqlTypes.SqlBoolean op_Implicit(System.Boolean x) { }
        private System.Boolean op_True(System.Data.SqlTypes.SqlBoolean x) { }
        private System.Data.SqlTypes.SqlBoolean op_BitwiseAnd(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { }
        private System.Data.SqlTypes.SqlBoolean op_BitwiseOr(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { }
        private System.Byte get_ByteValue() { }
        private System.String ToString() { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { }
        private System.Data.SqlTypes.SqlBoolean And(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { }
        private System.Data.SqlTypes.SqlBoolean Or(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlBoolean value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A0
    public struct SqlByte, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.Boolean m_fNotNull;        // 0x10
        private System.Byte m_value;        // 0x11
        private static readonly System.Int32 s_iBitNotByteMax;        // 0x0
        public static readonly System.Data.SqlTypes.SqlByte Null;        // 0x4
        public static readonly System.Data.SqlTypes.SqlByte Zero;        // 0x6
        public static readonly System.Data.SqlTypes.SqlByte MinValue;        // 0x8
        public static readonly System.Data.SqlTypes.SqlByte MaxValue;        // 0xA

        // Methods
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.Byte value) { }
        private System.Boolean get_IsNull() { }
        private System.Byte get_Value() { }
        private System.Data.SqlTypes.SqlByte op_Implicit(System.Byte x) { }
        private System.String ToString() { }
        private System.Data.SqlTypes.SqlByte op_Addition(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { }
        private System.Data.SqlTypes.SqlByte op_Subtraction(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { }
        private System.Data.SqlTypes.SqlByte op_Multiply(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { }
        private System.Data.SqlTypes.SqlByte op_Division(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { }
        private System.Data.SqlTypes.SqlByte op_Explicit(System.Data.SqlTypes.SqlInt64 x) { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { }
        private System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { }
        private System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { }
        private System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { }
        private System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { }
        private System.Data.SqlTypes.SqlDouble ToSqlDouble() { }
        private System.Data.SqlTypes.SqlInt64 ToSqlInt64() { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlByte value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A1
    public struct SqlBytesCharsState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.SqlTypes.SqlBytesCharsState Null;        // 0x0
        public static System.Data.SqlTypes.SqlBytesCharsState Buffer;        // 0x0
        public static System.Data.SqlTypes.SqlBytesCharsState Stream;        // 0x0

    }

    // TypeToken: 0x20000A2
    public class SqlBytes, INullable, IXmlSerializable, ISerializable
    {
        // Fields
        private System.Byte[] _rgbBuf;        // 0x10
        private System.Int64 _lCurLen;        // 0x18
        private System.IO.Stream _stream;        // 0x20
        private System.Data.SqlTypes.SqlBytesCharsState _state;        // 0x28
        private System.Byte[] _rgbWorkBuf;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Byte[] buffer) { }
        private System.Void .ctor(System.Data.SqlTypes.SqlBinary value) { }
        private System.Boolean get_IsNull() { }
        private System.Byte[] get_Buffer() { }
        private System.Int64 get_Length() { }
        private System.Byte[] get_Value() { }
        private System.Void SetNull() { }
        private System.Void CopyStreamToBuffer() { }
        private System.Boolean FStream() { }
        private System.Void SetBuffer(System.Byte[] buffer) { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Data.SqlTypes.SqlBytes get_Null() { }

    }

    // TypeToken: 0x20000A3
    public class SqlChars, INullable, IXmlSerializable, ISerializable
    {
        // Fields
        private System.Char[] _rgchBuf;        // 0x10
        private System.Int64 _lCurLen;        // 0x18
        private System.Data.SqlTypes.SqlStreamChars _stream;        // 0x20
        private System.Data.SqlTypes.SqlBytesCharsState _state;        // 0x28
        private System.Char[] _rgchWorkBuf;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Char[] buffer) { }
        private System.Void .ctor(System.Data.SqlTypes.SqlString value) { }
        private System.Boolean get_IsNull() { }
        private System.Char[] get_Buffer() { }
        private System.Int64 get_Length() { }
        private System.Char[] get_Value() { }
        private System.Void SetNull() { }
        private System.Boolean FStream() { }
        private System.Void CopyStreamToBuffer() { }
        private System.Void SetBuffer(System.Char[] buffer) { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Data.SqlTypes.SqlChars get_Null() { }

    }

    // TypeToken: 0x20000A4
    public struct SqlDateTime, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.Boolean m_fNotNull;        // 0x10
        private System.Int32 m_day;        // 0x14
        private System.Int32 m_time;        // 0x18
        private static readonly System.Double s_SQLTicksPerMillisecond;        // 0x0
        public static readonly System.Int32 SQLTicksPerSecond;        // 0x8
        public static readonly System.Int32 SQLTicksPerMinute;        // 0xC
        public static readonly System.Int32 SQLTicksPerHour;        // 0x10
        private static readonly System.Int32 s_SQLTicksPerDay;        // 0x14
        private static readonly System.Int64 s_ticksPerSecond;        // 0x18
        private static readonly System.DateTime s_SQLBaseDate;        // 0x20
        private static readonly System.Int64 s_SQLBaseDateTicks;        // 0x28
        private static readonly System.Int32 s_minYear;        // 0x30
        private static readonly System.Int32 s_maxYear;        // 0x34
        private static readonly System.Int32 s_minDay;        // 0x38
        private static readonly System.Int32 s_maxDay;        // 0x3C
        private static readonly System.Int32 s_minTime;        // 0x40
        private static readonly System.Int32 s_maxTime;        // 0x44
        private static readonly System.Int32 s_dayBase;        // 0x48
        private static readonly System.Int32[] s_daysToMonth365;        // 0x50
        private static readonly System.Int32[] s_daysToMonth366;        // 0x58
        private static readonly System.DateTime s_minDateTime;        // 0x60
        private static readonly System.DateTime s_maxDateTime;        // 0x68
        private static readonly System.TimeSpan s_minTimeSpan;        // 0x70
        private static readonly System.TimeSpan s_maxTimeSpan;        // 0x78
        private static readonly System.String s_ISO8601_DateTimeFormat;        // 0x80
        private static readonly System.String[] s_dateTimeFormats;        // 0x88
        public static readonly System.Data.SqlTypes.SqlDateTime MinValue;        // 0x90
        public static readonly System.Data.SqlTypes.SqlDateTime MaxValue;        // 0x9C
        public static readonly System.Data.SqlTypes.SqlDateTime Null;        // 0xA8

        // Methods
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.DateTime value) { }
        private System.Void .ctor(System.Int32 dayTicks, System.Int32 timeTicks) { }
        private System.Boolean get_IsNull() { }
        private System.TimeSpan ToTimeSpan(System.Data.SqlTypes.SqlDateTime value) { }
        private System.DateTime ToDateTime(System.Data.SqlTypes.SqlDateTime value) { }
        private System.Data.SqlTypes.SqlDateTime FromTimeSpan(System.TimeSpan value) { }
        private System.Data.SqlTypes.SqlDateTime FromDateTime(System.DateTime value) { }
        private System.DateTime get_Value() { }
        private System.Int32 get_DayTicks() { }
        private System.Int32 get_TimeTicks() { }
        private System.Data.SqlTypes.SqlDateTime op_Implicit(System.DateTime value) { }
        private System.String ToString() { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { }
        private System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { }
        private System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { }
        private System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { }
        private System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlDateTime value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A5
    public struct SqlDecimal, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.Byte _bStatus;        // 0x10
        private System.Byte _bLen;        // 0x11
        private System.Byte _bPrec;        // 0x12
        private System.Byte _bScale;        // 0x13
        private System.UInt32 _data1;        // 0x14
        private System.UInt32 _data2;        // 0x18
        private System.UInt32 _data3;        // 0x1C
        private System.UInt32 _data4;        // 0x20
        private static readonly System.Byte s_NUMERIC_MAX_PRECISION;        // 0x0
        public static readonly System.Byte MaxPrecision;        // 0x1
        public static readonly System.Byte MaxScale;        // 0x2
        private static readonly System.Byte s_bNullMask;        // 0x3
        private static readonly System.Byte s_bIsNull;        // 0x4
        private static readonly System.Byte s_bNotNull;        // 0x5
        private static readonly System.Byte s_bReverseNullMask;        // 0x6
        private static readonly System.Byte s_bSignMask;        // 0x7
        private static readonly System.Byte s_bPositive;        // 0x8
        private static readonly System.Byte s_bNegative;        // 0x9
        private static readonly System.Byte s_bReverseSignMask;        // 0xA
        private static readonly System.UInt32 s_uiZero;        // 0xC
        private static readonly System.Int32 s_cNumeMax;        // 0x10
        private static readonly System.Int64 s_lInt32Base;        // 0x18
        private static readonly System.UInt64 s_ulInt32Base;        // 0x20
        private static readonly System.UInt64 s_ulInt32BaseForMod;        // 0x28
        private static readonly System.UInt64 s_llMax;        // 0x30
        private static readonly System.UInt32 s_ulBase10;        // 0x38
        private static readonly System.Double s_DUINT_BASE;        // 0x40
        private static readonly System.Double s_DUINT_BASE2;        // 0x48
        private static readonly System.Double s_DUINT_BASE3;        // 0x50
        private static readonly System.Double s_DMAX_NUME;        // 0x58
        private static readonly System.UInt32 s_DBL_DIG;        // 0x60
        private static readonly System.Byte s_cNumeDivScaleMin;        // 0x64
        private static readonly System.UInt32[] s_rgulShiftBase;        // 0x68
        private static readonly System.UInt32[] s_decimalHelpersLo;        // 0x70
        private static readonly System.UInt32[] s_decimalHelpersMid;        // 0x78
        private static readonly System.UInt32[] s_decimalHelpersHi;        // 0x80
        private static readonly System.UInt32[] s_decimalHelpersHiHi;        // 0x88
        private static readonly System.Byte[] s_rgCLenFromPrec;        // 0x90
        private static readonly System.UInt32 s_ulT1;        // 0x98
        private static readonly System.UInt32 s_ulT2;        // 0x9C
        private static readonly System.UInt32 s_ulT3;        // 0xA0
        private static readonly System.UInt32 s_ulT4;        // 0xA4
        private static readonly System.UInt32 s_ulT5;        // 0xA8
        private static readonly System.UInt32 s_ulT6;        // 0xAC
        private static readonly System.UInt32 s_ulT7;        // 0xB0
        private static readonly System.UInt32 s_ulT8;        // 0xB4
        private static readonly System.UInt32 s_ulT9;        // 0xB8
        private static readonly System.UInt64 s_dwlT10;        // 0xC0
        private static readonly System.UInt64 s_dwlT11;        // 0xC8
        private static readonly System.UInt64 s_dwlT12;        // 0xD0
        private static readonly System.UInt64 s_dwlT13;        // 0xD8
        private static readonly System.UInt64 s_dwlT14;        // 0xE0
        private static readonly System.UInt64 s_dwlT15;        // 0xE8
        private static readonly System.UInt64 s_dwlT16;        // 0xF0
        private static readonly System.UInt64 s_dwlT17;        // 0xF8
        private static readonly System.UInt64 s_dwlT18;        // 0x100
        private static readonly System.UInt64 s_dwlT19;        // 0x108
        public static readonly System.Data.SqlTypes.SqlDecimal Null;        // 0x110
        public static readonly System.Data.SqlTypes.SqlDecimal MinValue;        // 0x124
        public static readonly System.Data.SqlTypes.SqlDecimal MaxValue;        // 0x138

        // Methods
        private System.Byte CalculatePrecision() { }
        private System.Boolean VerifyPrecision(System.Byte precision) { }
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.Decimal value) { }
        private System.Void .ctor(System.Int32 value) { }
        private System.Void .ctor(System.Int64 value) { }
        private System.Void .ctor(System.UInt32[] rglData, System.Byte bLen, System.Byte bPrec, System.Byte bScale, System.Boolean fPositive) { }
        private System.Boolean get_IsNull() { }
        private System.Decimal get_Value() { }
        private System.Boolean get_IsPositive() { }
        private System.Void SetPositive() { }
        private System.Void SetSignBit(System.Boolean fPositive) { }
        private System.Byte get_Scale() { }
        private System.Int32[] get_Data() { }
        private System.String ToString() { }
        private System.Data.SqlTypes.SqlDecimal Parse(System.String s) { }
        private System.Double ToDouble() { }
        private System.Decimal ToDecimal() { }
        private System.Data.SqlTypes.SqlDecimal op_Implicit(System.Decimal x) { }
        private System.Data.SqlTypes.SqlDecimal op_Implicit(System.Int64 x) { }
        private System.Data.SqlTypes.SqlDecimal op_UnaryNegation(System.Data.SqlTypes.SqlDecimal x) { }
        private System.Data.SqlTypes.SqlDecimal op_Addition(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { }
        private System.Data.SqlTypes.SqlDecimal op_Subtraction(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { }
        private System.Data.SqlTypes.SqlDecimal op_Multiply(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { }
        private System.Data.SqlTypes.SqlDecimal op_Division(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { }
        private System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlByte x) { }
        private System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt16 x) { }
        private System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt32 x) { }
        private System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt64 x) { }
        private System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlMoney x) { }
        private System.Void ZeroToMaxLen(System.UInt32[] rgulData, System.Int32 cUI4sCur) { }
        private System.Boolean FZero() { }
        private System.Boolean FGt10_38() { }
        private System.Boolean FGt10_38(System.UInt32[] rglData) { }
        private System.Byte BGetPrecUI4(System.UInt32 value) { }
        private System.Byte BGetPrecUI8(System.UInt64 dwlVal) { }
        private System.Void AddULong(System.UInt32 ulAdd) { }
        private System.Void MultByULong(System.UInt32 uiMultiplier) { }
        private System.UInt32 DivByULong(System.UInt32 iDivisor) { }
        private System.Void AdjustScale(System.Int32 digits, System.Boolean fRound) { }
        private System.Int32 LAbsCmp(System.Data.SqlTypes.SqlDecimal snumOp) { }
        private System.Void MpMove(System.UInt32[] rgulS, System.Int32 ciulS, System.UInt32[] rgulD, System.Int32& ciulD) { }
        private System.Void MpSet(System.UInt32[] rgulD, System.Int32& ciulD, System.UInt32 iulN) { }
        private System.Void MpNormalize(System.UInt32[] rgulU, System.Int32& ciulU) { }
        private System.Void MpMul1(System.UInt32[] piulD, System.Int32& ciulD, System.UInt32 iulX) { }
        private System.Void MpDiv1(System.UInt32[] rgulU, System.Int32& ciulU, System.UInt32 iulD, System.UInt32& iulR) { }
        private System.UInt64 DWL(System.UInt32 lo, System.UInt32 hi) { }
        private System.UInt32 HI(System.UInt64 x) { }
        private System.UInt32 LO(System.UInt64 x) { }
        private System.Void MpDiv(System.UInt32[] rgulU, System.Int32 ciulU, System.UInt32[] rgulD, System.Int32 ciulD, System.UInt32[] rgulQ, System.Int32& ciulQ, System.UInt32[] rgulR, System.Int32& ciulR) { }
        private System.Data.SqlTypes.EComparison CompareNm(System.Data.SqlTypes.SqlDecimal snumOp) { }
        private System.Void CheckValidPrecScale(System.Byte bPrec, System.Byte bScale) { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { }
        private System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { }
        private System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { }
        private System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { }
        private System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { }
        private System.Data.SqlTypes.SqlDouble ToSqlDouble() { }
        private System.Data.SqlTypes.SqlInt64 ToSqlInt64() { }
        private System.Data.SqlTypes.SqlMoney ToSqlMoney() { }
        private System.Char ChFromDigit(System.UInt32 uiDigit) { }
        private System.Void StoreFromWorkingArray(System.UInt32[] rguiData) { }
        private System.Void SetToZero() { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlDecimal value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A6
    public struct SqlDouble, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.Boolean m_fNotNull;        // 0x10
        private System.Double m_value;        // 0x18
        public static readonly System.Data.SqlTypes.SqlDouble Null;        // 0x0
        public static readonly System.Data.SqlTypes.SqlDouble Zero;        // 0x10
        public static readonly System.Data.SqlTypes.SqlDouble MinValue;        // 0x20
        public static readonly System.Data.SqlTypes.SqlDouble MaxValue;        // 0x30

        // Methods
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.Double value) { }
        private System.Boolean get_IsNull() { }
        private System.Double get_Value() { }
        private System.Data.SqlTypes.SqlDouble op_Implicit(System.Double x) { }
        private System.String ToString() { }
        private System.Data.SqlTypes.SqlDouble op_UnaryNegation(System.Data.SqlTypes.SqlDouble x) { }
        private System.Data.SqlTypes.SqlDouble op_Addition(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { }
        private System.Data.SqlTypes.SqlDouble op_Subtraction(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { }
        private System.Data.SqlTypes.SqlDouble op_Multiply(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { }
        private System.Data.SqlTypes.SqlDouble op_Division(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { }
        private System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlByte x) { }
        private System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt16 x) { }
        private System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt32 x) { }
        private System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt64 x) { }
        private System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlSingle x) { }
        private System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlMoney x) { }
        private System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlDecimal x) { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { }
        private System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { }
        private System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { }
        private System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { }
        private System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { }
        private System.Data.SqlTypes.SqlSingle ToSqlSingle() { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlDouble value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A7
    public struct SqlGuid, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private static readonly System.Int32 s_sizeOfGuid;        // 0x0
        private static readonly System.Int32[] s_rgiGuidOrder;        // 0x8
        private System.Byte[] m_value;        // 0x10
        public static readonly System.Data.SqlTypes.SqlGuid Null;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.Guid g) { }
        private System.Boolean get_IsNull() { }
        private System.Guid get_Value() { }
        private System.Data.SqlTypes.SqlGuid op_Implicit(System.Guid x) { }
        private System.String ToString() { }
        private System.Data.SqlTypes.EComparison Compare(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { }
        private System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { }
        private System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlGuid value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A8
    public struct SqlInt16, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.Boolean m_fNotNull;        // 0x10
        private System.Int16 m_value;        // 0x12
        private static readonly System.Int32 s_MASKI2;        // 0x0
        public static readonly System.Data.SqlTypes.SqlInt16 Null;        // 0x4
        public static readonly System.Data.SqlTypes.SqlInt16 Zero;        // 0x8
        public static readonly System.Data.SqlTypes.SqlInt16 MinValue;        // 0xC
        public static readonly System.Data.SqlTypes.SqlInt16 MaxValue;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.Int16 value) { }
        private System.Boolean get_IsNull() { }
        private System.Int16 get_Value() { }
        private System.Data.SqlTypes.SqlInt16 op_Implicit(System.Int16 x) { }
        private System.String ToString() { }
        private System.Data.SqlTypes.SqlInt16 op_UnaryNegation(System.Data.SqlTypes.SqlInt16 x) { }
        private System.Data.SqlTypes.SqlInt16 op_Addition(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { }
        private System.Data.SqlTypes.SqlInt16 op_Subtraction(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { }
        private System.Data.SqlTypes.SqlInt16 op_Multiply(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { }
        private System.Data.SqlTypes.SqlInt16 op_Division(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { }
        private System.Data.SqlTypes.SqlInt16 op_Implicit(System.Data.SqlTypes.SqlByte x) { }
        private System.Data.SqlTypes.SqlInt16 op_Explicit(System.Data.SqlTypes.SqlInt64 x) { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { }
        private System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { }
        private System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { }
        private System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { }
        private System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { }
        private System.Data.SqlTypes.SqlDouble ToSqlDouble() { }
        private System.Data.SqlTypes.SqlInt64 ToSqlInt64() { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlInt16 value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A9
    public struct SqlInt32, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.Boolean m_fNotNull;        // 0x10
        private System.Int32 m_value;        // 0x14
        private static readonly System.Int64 s_iIntMin;        // 0x0
        private static readonly System.Int64 s_lBitNotIntMax;        // 0x8
        public static readonly System.Data.SqlTypes.SqlInt32 Null;        // 0x10
        public static readonly System.Data.SqlTypes.SqlInt32 Zero;        // 0x18
        public static readonly System.Data.SqlTypes.SqlInt32 MinValue;        // 0x20
        public static readonly System.Data.SqlTypes.SqlInt32 MaxValue;        // 0x28

        // Methods
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.Int32 value) { }
        private System.Boolean get_IsNull() { }
        private System.Int32 get_Value() { }
        private System.Data.SqlTypes.SqlInt32 op_Implicit(System.Int32 x) { }
        private System.String ToString() { }
        private System.Data.SqlTypes.SqlInt32 op_UnaryNegation(System.Data.SqlTypes.SqlInt32 x) { }
        private System.Data.SqlTypes.SqlInt32 op_Addition(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { }
        private System.Data.SqlTypes.SqlInt32 op_Subtraction(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { }
        private System.Data.SqlTypes.SqlInt32 op_Multiply(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { }
        private System.Data.SqlTypes.SqlInt32 op_Division(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { }
        private System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlByte x) { }
        private System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlInt16 x) { }
        private System.Data.SqlTypes.SqlInt32 op_Explicit(System.Data.SqlTypes.SqlInt64 x) { }
        private System.Boolean SameSignInt(System.Int32 x, System.Int32 y) { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { }
        private System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { }
        private System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { }
        private System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { }
        private System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { }
        private System.Data.SqlTypes.SqlDouble ToSqlDouble() { }
        private System.Data.SqlTypes.SqlInt64 ToSqlInt64() { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlInt32 value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AA
    public struct SqlInt64, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.Boolean m_fNotNull;        // 0x10
        private System.Int64 m_value;        // 0x18
        private static readonly System.Int64 s_lLowIntMask;        // 0x0
        private static readonly System.Int64 s_lHighIntMask;        // 0x8
        public static readonly System.Data.SqlTypes.SqlInt64 Null;        // 0x10
        public static readonly System.Data.SqlTypes.SqlInt64 Zero;        // 0x20
        public static readonly System.Data.SqlTypes.SqlInt64 MinValue;        // 0x30
        public static readonly System.Data.SqlTypes.SqlInt64 MaxValue;        // 0x40

        // Methods
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.Int64 value) { }
        private System.Boolean get_IsNull() { }
        private System.Int64 get_Value() { }
        private System.Data.SqlTypes.SqlInt64 op_Implicit(System.Int64 x) { }
        private System.String ToString() { }
        private System.Data.SqlTypes.SqlInt64 op_UnaryNegation(System.Data.SqlTypes.SqlInt64 x) { }
        private System.Data.SqlTypes.SqlInt64 op_Addition(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { }
        private System.Data.SqlTypes.SqlInt64 op_Subtraction(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { }
        private System.Data.SqlTypes.SqlInt64 op_Multiply(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { }
        private System.Data.SqlTypes.SqlInt64 op_Division(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { }
        private System.Data.SqlTypes.SqlInt64 op_Modulus(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { }
        private System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlByte x) { }
        private System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt16 x) { }
        private System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt32 x) { }
        private System.Data.SqlTypes.SqlInt64 op_Explicit(System.Data.SqlTypes.SqlDecimal x) { }
        private System.Boolean SameSignLong(System.Int64 x, System.Int64 y) { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { }
        private System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { }
        private System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { }
        private System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { }
        private System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { }
        private System.Data.SqlTypes.SqlByte ToSqlByte() { }
        private System.Data.SqlTypes.SqlDouble ToSqlDouble() { }
        private System.Data.SqlTypes.SqlInt16 ToSqlInt16() { }
        private System.Data.SqlTypes.SqlInt32 ToSqlInt32() { }
        private System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlInt64 value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AB
    public struct SqlMoney, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.Boolean _fNotNull;        // 0x10
        private System.Int64 _value;        // 0x18
        private static readonly System.Int32 s_iMoneyScale;        // 0x0
        private static readonly System.Int64 s_lTickBase;        // 0x8
        private static readonly System.Double s_dTickBase;        // 0x10
        private static readonly System.Int64 s_minLong;        // 0x18
        private static readonly System.Int64 s_maxLong;        // 0x20
        public static readonly System.Data.SqlTypes.SqlMoney Null;        // 0x28
        public static readonly System.Data.SqlTypes.SqlMoney Zero;        // 0x38
        public static readonly System.Data.SqlTypes.SqlMoney MinValue;        // 0x48
        public static readonly System.Data.SqlTypes.SqlMoney MaxValue;        // 0x58

        // Methods
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.Int64 value, System.Int32 ignored) { }
        private System.Void .ctor(System.Int32 value) { }
        private System.Void .ctor(System.Int64 value) { }
        private System.Void .ctor(System.Decimal value) { }
        private System.Boolean get_IsNull() { }
        private System.Decimal get_Value() { }
        private System.Decimal ToDecimal() { }
        private System.Double ToDouble() { }
        private System.Data.SqlTypes.SqlMoney op_Implicit(System.Decimal x) { }
        private System.Data.SqlTypes.SqlMoney op_Implicit(System.Int64 x) { }
        private System.String ToString() { }
        private System.Data.SqlTypes.SqlMoney op_UnaryNegation(System.Data.SqlTypes.SqlMoney x) { }
        private System.Data.SqlTypes.SqlMoney op_Addition(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { }
        private System.Data.SqlTypes.SqlMoney op_Subtraction(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { }
        private System.Data.SqlTypes.SqlMoney op_Multiply(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { }
        private System.Data.SqlTypes.SqlMoney op_Division(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { }
        private System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlByte x) { }
        private System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt16 x) { }
        private System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt32 x) { }
        private System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt64 x) { }
        private System.Data.SqlTypes.SqlMoney op_Explicit(System.Data.SqlTypes.SqlDecimal x) { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { }
        private System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { }
        private System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { }
        private System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { }
        private System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { }
        private System.Data.SqlTypes.SqlDouble ToSqlDouble() { }
        private System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlMoney value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AC
    public struct SqlSingle, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.Boolean _fNotNull;        // 0x10
        private System.Single _value;        // 0x14
        public static readonly System.Data.SqlTypes.SqlSingle Null;        // 0x0
        public static readonly System.Data.SqlTypes.SqlSingle Zero;        // 0x8
        public static readonly System.Data.SqlTypes.SqlSingle MinValue;        // 0x10
        public static readonly System.Data.SqlTypes.SqlSingle MaxValue;        // 0x18

        // Methods
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.Single value) { }
        private System.Void .ctor(System.Double value) { }
        private System.Boolean get_IsNull() { }
        private System.Single get_Value() { }
        private System.Data.SqlTypes.SqlSingle op_Implicit(System.Single x) { }
        private System.String ToString() { }
        private System.Data.SqlTypes.SqlSingle op_UnaryNegation(System.Data.SqlTypes.SqlSingle x) { }
        private System.Data.SqlTypes.SqlSingle op_Addition(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { }
        private System.Data.SqlTypes.SqlSingle op_Subtraction(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { }
        private System.Data.SqlTypes.SqlSingle op_Multiply(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { }
        private System.Data.SqlTypes.SqlSingle op_Division(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { }
        private System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlByte x) { }
        private System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt16 x) { }
        private System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt32 x) { }
        private System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt64 x) { }
        private System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlMoney x) { }
        private System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlDecimal x) { }
        private System.Data.SqlTypes.SqlSingle op_Explicit(System.Data.SqlTypes.SqlDouble x) { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { }
        private System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { }
        private System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { }
        private System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { }
        private System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { }
        private System.Data.SqlTypes.SqlDouble ToSqlDouble() { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlSingle value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AD
    public struct SqlCompareOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.SqlTypes.SqlCompareOptions None;        // 0x0
        public static System.Data.SqlTypes.SqlCompareOptions IgnoreCase;        // 0x0
        public static System.Data.SqlTypes.SqlCompareOptions IgnoreNonSpace;        // 0x0
        public static System.Data.SqlTypes.SqlCompareOptions IgnoreKanaType;        // 0x0
        public static System.Data.SqlTypes.SqlCompareOptions IgnoreWidth;        // 0x0
        public static System.Data.SqlTypes.SqlCompareOptions BinarySort;        // 0x0
        public static System.Data.SqlTypes.SqlCompareOptions BinarySort2;        // 0x0

    }

    // TypeToken: 0x20000AE
    public struct SqlString, INullable, IComparable, IXmlSerializable
    {
        // Fields
        private System.String m_value;        // 0x10
        private System.Globalization.CompareInfo m_cmpInfo;        // 0x18
        private System.Int32 m_lcid;        // 0x20
        private System.Data.SqlTypes.SqlCompareOptions m_flag;        // 0x24
        private System.Boolean m_fNotNull;        // 0x28
        public static readonly System.Data.SqlTypes.SqlString Null;        // 0x0
        private static readonly System.Text.UnicodeEncoding s_unicodeEncoding;        // 0x20
        public static readonly System.Int32 IgnoreCase;        // 0x28
        public static readonly System.Int32 IgnoreWidth;        // 0x2C
        public static readonly System.Int32 IgnoreNonSpace;        // 0x30
        public static readonly System.Int32 IgnoreKanaType;        // 0x34
        public static readonly System.Int32 BinarySort;        // 0x38
        public static readonly System.Int32 BinarySort2;        // 0x3C
        private static readonly System.Data.SqlTypes.SqlCompareOptions s_iDefaultFlag;        // 0x40
        private static readonly System.Globalization.CompareOptions s_iValidCompareOptionMask;        // 0x44
        private static readonly System.Data.SqlTypes.SqlCompareOptions s_iValidSqlCompareOptionMask;        // 0x48
        private static readonly System.Int32 s_lcidUSEnglish;        // 0x4C
        private static readonly System.Int32 s_lcidBinary;        // 0x50

        // Methods
        private System.Void .ctor(System.Boolean fNull) { }
        private System.Void .ctor(System.String data, System.Int32 lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions) { }
        private System.Void .ctor(System.String data) { }
        private System.Void .ctor(System.Int32 lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, System.String data, System.Globalization.CompareInfo cmpInfo) { }
        private System.Boolean get_IsNull() { }
        private System.String get_Value() { }
        private System.Void SetCompareInfo() { }
        private System.Data.SqlTypes.SqlString op_Implicit(System.String x) { }
        private System.String ToString() { }
        private System.Data.SqlTypes.SqlString op_Addition(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { }
        private System.Int32 StringCompare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { }
        private System.Data.SqlTypes.SqlBoolean Compare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y, System.Data.SqlTypes.EComparison ecExpectedResult) { }
        private System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { }
        private System.Void ValidateSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions) { }
        private System.Globalization.CompareOptions CompareOptionsFromSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions) { }
        private System.Boolean FBinarySort() { }
        private System.Int32 CompareBinary(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { }
        private System.Int32 CompareBinary2(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { }
        private System.Int32 CompareTo(System.Object value) { }
        private System.Int32 CompareTo(System.Data.SqlTypes.SqlString value) { }
        private System.Boolean Equals(System.Object value) { }
        private System.Int32 GetHashCode() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AF
    public struct EComparison
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Data.SqlTypes.EComparison LT;        // 0x0
        public static System.Data.SqlTypes.EComparison LE;        // 0x0
        public static System.Data.SqlTypes.EComparison EQ;        // 0x0
        public static System.Data.SqlTypes.EComparison GE;        // 0x0
        public static System.Data.SqlTypes.EComparison GT;        // 0x0
        public static System.Data.SqlTypes.EComparison NE;        // 0x0

    }

    // TypeToken: 0x20000B0
    public class SqlTypeException : SystemException
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception e) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) { }
        private System.Runtime.Serialization.SerializationInfo SqlTypeExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) { }

    }

    // TypeToken: 0x20000B1
    public class SqlNullValueException : SqlTypeException
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception e) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) { }
        private System.Runtime.Serialization.SerializationInfo SqlNullValueExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) { }

    }

    // TypeToken: 0x20000B2
    public class SqlTruncateException : SqlTypeException
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception e) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) { }
        private System.Runtime.Serialization.SerializationInfo SqlTruncateExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) { }

    }

    // TypeToken: 0x20000B3
    public class SqlStreamChars
    {
        // Methods
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Int32 Read(System.Char[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }

    }

    // TypeToken: 0x20000B4
    public class SqlXml, INullable, IXmlSerializable
    {
        // Fields
        private static readonly System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> s_sqlReaderDelegate;        // 0x0
        private static readonly System.Xml.XmlReaderSettings s_defaultXmlReaderSettings;        // 0x8
        private static readonly System.Xml.XmlReaderSettings s_defaultXmlReaderSettingsCloseInput;        // 0x10
        private static System.Reflection.MethodInfo s_createSqlReaderMethodInfo;        // 0x18
        private System.Reflection.MethodInfo _createSqlReaderMethodInfo;        // 0x10
        private System.Boolean _fNotNull;        // 0x18
        private System.IO.Stream _stream;        // 0x20
        private System.Boolean _firstCreateReader;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Xml.XmlReader CreateReader() { }
        private System.Xml.XmlReader CreateSqlXmlReader(System.IO.Stream stream, System.Boolean closeInput, System.Boolean throwTargetInvocationExceptions) { }
        private System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> CreateSqlReaderDelegate() { }
        private System.Reflection.MethodInfo get_CreateSqlReaderMethodInfo() { }
        private System.Boolean get_IsNull() { }
        private System.Void SetNull() { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B5
    public class SqlXmlStreamWrapper : Stream
    {
        // Fields
        private System.IO.Stream _stream;        // 0x28
        private System.Int64 _lPosition;        // 0x30
        private System.Boolean _isClosed;        // 0x38

        // Methods
        private System.Void .ctor(System.IO.Stream stream) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanSeek() { }
        private System.Boolean get_CanWrite() { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Int32 ReadByte() { }
        private System.Void WriteByte(System.Byte value) { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Void Flush() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void ThrowIfStreamCannotSeek(System.String method) { }
        private System.Void ThrowIfStreamCannotRead(System.String method) { }
        private System.Void ThrowIfStreamCannotWrite(System.String method) { }
        private System.Void ThrowIfStreamClosed(System.String method) { }
        private System.Boolean IsStreamClosed() { }

    }

}

