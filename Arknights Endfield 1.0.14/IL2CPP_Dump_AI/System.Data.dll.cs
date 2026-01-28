// ========================================================
// Dumped by @desirepro
// Assembly: System.Data.dll
// Classes:  230
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SR
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.String GetString(System.String name)
  System.String Format(System.String resourceFormat, System.Object p1)
  System.String Format(System.String resourceFormat, System.Object p1, System.Object p2)
  System.String Format(System.String resourceFormat, System.Object p1, System.Object p2, System.Object p3)
END_CLASS

CLASS: ColumnError
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  private           System.Data.DataColumn          _column  // 0x10
  private           System.String                   _error  // 0x18
METHODS:
END_CLASS

CLASS: DataTableRelationCollection
TYPE:  class
TOKEN: 0x2000027
EXTENDS: DataRelationCollection
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x38
  private   readonly System.Collections.ArrayList    _relations  // 0x40
  private   readonly System.Boolean                  _fParentCollection  // 0x48
  private           System.ComponentModel.CollectionChangeEventHandlerRelationPropertyChanged  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.Boolean fParentCollection)
  System.Collections.ArrayList get_List()
  System.Void EnsureDataSet()
  System.Data.DataSet GetDataSet()
  System.Data.DataRelation get_Item(System.Int32 index)
  System.Data.DataRelation get_Item(System.String name)
  System.Void add_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value)
  System.Void remove_RelationPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value)
  System.Void AddCache(System.Data.DataRelation relation)
  System.Void AddCore(System.Data.DataRelation relation)
  System.Void RemoveCache(System.Data.DataRelation relation)
  System.Void RemoveCore(System.Data.DataRelation relation)
END_CLASS

CLASS: DataSetRelationCollection
TYPE:  class
TOKEN: 0x2000028
EXTENDS: DataRelationCollection
FIELDS:
  private   readonly System.Data.DataSet             _dataSet  // 0x38
  private   readonly System.Collections.ArrayList    _relations  // 0x40
  private           System.Data.DataRelation[]      _delayLoadingRelations  // 0x48
METHODS:
  System.Void .ctor(System.Data.DataSet dataSet)
  System.Collections.ArrayList get_List()
  System.Void Clear()
  System.Data.DataSet GetDataSet()
  System.Data.DataRelation get_Item(System.Int32 index)
  System.Data.DataRelation get_Item(System.String name)
  System.Void AddCore(System.Data.DataRelation relation)
  System.Void RemoveCore(System.Data.DataRelation relation)
END_CLASS

CLASS: DataRowTree
TYPE:  class
TOKEN: 0x2000030
EXTENDS: RBTree`1
FIELDS:
METHODS:
  System.Void .ctor()
  System.Int32 CompareNode(System.Data.DataRow record1, System.Data.DataRow record2)
  System.Int32 CompareSateliteTreeNode(System.Data.DataRow record1, System.Data.DataRow record2)
END_CLASS

CLASS: RowDiffIdUsageSection
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  private           System.Data.DataTable           _targetTable  // 0x10
METHODS:
  System.Void Prepare(System.Data.DataTable table)
END_CLASS

CLASS: DSRowDiffIdUsageSection
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  private           System.Data.DataSet             _targetDS  // 0x10
METHODS:
  System.Void Prepare(System.Data.DataSet ds)
END_CLASS

CLASS: DataRowReferenceComparer
TYPE:  class
TOKEN: 0x2000043
FIELDS:
  private   static readonly System.Data.DataView.DataRowReferenceComparers_default  // 0x0
METHODS:
  System.Void .ctor()
  System.Boolean Equals(System.Data.DataRow x, System.Data.DataRow y)
  System.Int32 GetHashCode(System.Data.DataRow obj)
  System.Void .cctor()
END_CLASS

CLASS: DataTypePrecedence
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlDateTime  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceDateTimeOffset  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceDateTime  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceTimeSpan  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlDouble  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceDouble  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlSingle  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSingle  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlDecimal  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceDecimal  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlMoney  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceUInt64  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlInt64  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceInt64  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceUInt32  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlInt32  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceInt32  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceUInt16  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlInt16  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceInt16  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceByte  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlByte  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSByte  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceError  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlBoolean  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceBoolean  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlGuid  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlString  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceString  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlXml  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlChars  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceChar  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlBytes  // 0x0
  public    static  System.Data.BinaryNode.DataTypePrecedenceSqlBinary  // 0x0
METHODS:
END_CLASS

CLASS: ReservedWords
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  private   readonly System.String                   _word  // 0x10
  private   readonly System.Data.Tokens              _token  // 0x18
  private   readonly System.Int32                    _op  // 0x1C
METHODS:
  System.Void .ctor(System.String word, System.Data.Tokens token, System.Int32 op)
END_CLASS

CLASS: NodeColor
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  System.Data.RBTree.NodeColor<K> red  // 0x0
  public    static  System.Data.RBTree.NodeColor<K> black  // 0x0
METHODS:
END_CLASS

CLASS: Node
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  private           System.Int32                    _selfId  // 0x0
  private           System.Int32                    _leftId  // 0x0
  private           System.Int32                    _rightId  // 0x0
  private           System.Int32                    _parentId  // 0x0
  private           System.Int32                    _nextId  // 0x0
  private           System.Int32                    _subTreeSize  // 0x0
  private           K                               _keyOfNode  // 0x0
  private           System.Data.RBTree.NodeColor<K> _nodeColor  // 0x0
METHODS:
END_CLASS

CLASS: NodePath
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  private   readonly System.Int32                    _nodeID  // 0x0
  private   readonly System.Int32                    _mainTreeNodeID  // 0x0
METHODS:
  System.Void .ctor(System.Int32 nodeID, System.Int32 mainTreeNodeID)
END_CLASS

CLASS: TreePage
TYPE:  class
TOKEN: 0x2000074
FIELDS:
  private   readonly System.Data.RBTree.Node<K>[]    _slots  // 0x0
  private   readonly System.Int32[]                  _slotMap  // 0x0
  private           System.Int32                    _inUseCount  // 0x0
  private           System.Int32                    _pageId  // 0x0
  private           System.Int32                    _nextFreeSlotLine  // 0x0
METHODS:
  System.Void .ctor(System.Int32 size)
  System.Int32 AllocSlot(System.Data.RBTree<K> tree)
  System.Int32 get_InUseCount()
  System.Void set_InUseCount(System.Int32 value)
  System.Int32 get_PageId()
  System.Void set_PageId(System.Int32 value)
END_CLASS

CLASS: RBTreeEnumerator
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  private   readonly System.Data.RBTree<K>           _tree  // 0x0
  private   readonly System.Int32                    _version  // 0x0
  private           System.Int32                    _index  // 0x0
  private           System.Int32                    _mainTreeNodeId  // 0x0
  private           K                               _current  // 0x0
METHODS:
  System.Void .ctor(System.Data.RBTree<K> tree)
  System.Void .ctor(System.Data.RBTree<K> tree, System.Int32 position)
  System.Void Dispose()
  System.Boolean MoveNext()
  K get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: ColumnInfo
TYPE:  class
TOKEN: 0x200007C
FIELDS:
  public            System.Boolean                  flag  // 0x10
  public            System.Boolean                  equalsOperator  // 0x11
  public            System.Data.BinaryNode          expr  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IndexTree
TYPE:  class
TOKEN: 0x200007F
EXTENDS: RBTree`1
FIELDS:
  private   readonly System.Data.Index               _index  // 0x40
METHODS:
  System.Void .ctor(System.Data.Index index)
  System.Int32 CompareNode(System.Int32 record1, System.Int32 record2)
  System.Int32 CompareSateliteTreeNode(System.Int32 record1, System.Int32 record2)
END_CLASS

CLASS: Action`4
TYPE:  class
TOKEN: 0x2000083
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
END_CLASS

CLASS: Func`2
TYPE:  class
TOKEN: 0x2000084
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 arg1)
END_CLASS

CLASS: NameType
TYPE:  class
TOKEN: 0x2000088
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Type                     type  // 0x18
METHODS:
  System.Void .ctor(System.String n, System.Type t)
  System.Int32 CompareTo(System.Object obj)
END_CLASS

CLASS: NameType
TYPE:  class
TOKEN: 0x200008D
FIELDS:
  public    readonly System.String                   name  // 0x10
  public    readonly System.Type                     type  // 0x18
METHODS:
  System.Void .ctor(System.String n, System.Type t)
  System.Int32 CompareTo(System.Object obj)
END_CLASS

CLASS: XmlNodeIdentety
TYPE:  class
TOKEN: 0x2000092
FIELDS:
  public            System.String                   LocalName  // 0x10
  public            System.String                   NamespaceURI  // 0x18
METHODS:
  System.Void .ctor(System.String localName, System.String namespaceURI)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: XmlNodeIdHashtable
TYPE:  class
TOKEN: 0x2000093
EXTENDS: Hashtable
FIELDS:
  private           System.Data.XmlToDatasetMap.XmlNodeIdentety_id  // 0x50
METHODS:
  System.Void .ctor(System.Int32 capacity)
  System.Object get_Item(System.Xml.XmlNode node)
  System.Object get_Item(System.Xml.XmlReader dataReader)
  System.Object get_Item(System.Data.DataTable table)
  System.Object get_Item(System.String name)
END_CLASS

CLASS: TableSchemaInfo
TYPE:  class
TOKEN: 0x2000094
FIELDS:
  public            System.Data.DataTable           TableSchema  // 0x10
  public            System.Data.XmlToDatasetMap.XmlNodeIdHashtableColumnsSchemaMap  // 0x18
METHODS:
  System.Void .ctor(System.Data.DataTable tableSchema)
END_CLASS

CLASS: Families
TYPE:  struct
TOKEN: 0x20000C5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Common.ObjectStorage.FamiliesDATETIME  // 0x0
  public    static  System.Data.Common.ObjectStorage.FamiliesNUMBER  // 0x0
  public    static  System.Data.Common.ObjectStorage.FamiliesSTRING  // 0x0
  public    static  System.Data.Common.ObjectStorage.FamiliesBOOLEAN  // 0x0
  public    static  System.Data.Common.ObjectStorage.FamiliesARRAY  // 0x0
METHODS:
END_CLASS

CLASS: TempAssemblyComparer
TYPE:  class
TOKEN: 0x20000C6
FIELDS:
  private   static readonly System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute>>s_default  // 0x0
METHODS:
  System.Void .ctor()
  System.Boolean Equals(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> y)
  System.Int32 GetHashCode(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> obj)
  System.Void .cctor()
END_CLASS

CLASS: __StaticArrayInitTypeSize=36
TYPE:  struct
TOKEN: 0x20000E1
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=38
TYPE:  struct
TOKEN: 0x20000E2
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=52
TYPE:  struct
TOKEN: 0x20000E3
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=64
TYPE:  struct
TOKEN: 0x20000E4
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=152
TYPE:  struct
TOKEN: 0x20000E5
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=176
TYPE:  struct
TOKEN: 0x20000E6
FIELDS:
METHODS:
END_CLASS

CLASS: System.Data.AcceptRejectRule
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.AcceptRejectRule    None  // 0x0
  public    static  System.Data.AcceptRejectRule    Cascade  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.AggregateType
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.AggregateType       None  // 0x0
  public    static  System.Data.AggregateType       Sum  // 0x0
  public    static  System.Data.AggregateType       Mean  // 0x0
  public    static  System.Data.AggregateType       Min  // 0x0
  public    static  System.Data.AggregateType       Max  // 0x0
  public    static  System.Data.AggregateType       First  // 0x0
  public    static  System.Data.AggregateType       Count  // 0x0
  public    static  System.Data.AggregateType       Var  // 0x0
  public    static  System.Data.AggregateType       StDev  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.InternalDataCollectionBase
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private   static readonly System.ComponentModel.CollectionChangeEventArgss_refreshEventArgs  // 0x0
METHODS:
  System.Int32 get_Count()
  System.Void CopyTo(System.Array ar, System.Int32 index)
  System.Collections.IEnumerator GetEnumerator()
  System.Boolean get_IsSynchronized()
  System.Int32 NamesEqual(System.String s1, System.String s2, System.Boolean fCaseSensitive, System.Globalization.CultureInfo locale)
  System.Object get_SyncRoot()
  System.Collections.ArrayList get_List()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Data.ColumnTypeConverter
TYPE:  class
TOKEN: 0x2000006
EXTENDS: TypeConverter
FIELDS:
  private   static readonly System.Type[]                   s_types  // 0x0
  private           System.ComponentModel.TypeConverter.StandardValuesCollection_values  // 0x10
METHODS:
  System.Void .ctor()
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
  System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.DataCommonEventSource
TYPE:  class
TOKEN: 0x2000007
EXTENDS: EventSource
FIELDS:
  private   static readonly System.Data.DataCommonEventSourceLog  // 0x0
  private   static  System.Int64                    s_nextScopeId  // 0x8
METHODS:
  System.Void Trace(System.String message)
  System.Void Trace(System.String format, T0 arg0)
  System.Void Trace(System.String format, T0 arg0, T1 arg1)
  System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2)
  System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
  System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.Void Trace(System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  System.Int64 EnterScope(System.String message)
  System.Int64 EnterScope(System.String format, T1 arg1)
  System.Int64 EnterScope(System.String format, T1 arg1, T2 arg2)
  System.Int64 EnterScope(System.String format, T1 arg1, T2 arg2, T3 arg3)
  System.Int64 EnterScope(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.Void ExitScope(System.Int64 scopeId)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Data.Constraint
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private           System.String                   _schemaName  // 0x10
  private           System.Boolean                  _inCollection  // 0x18
  private           System.Data.DataSet             _dataSet  // 0x20
  private           System.String                   _name  // 0x28
  private           System.Data.PropertyCollection  _extendedProperties  // 0x30
METHODS:
  System.String get_ConstraintName()
  System.Void set_ConstraintName(System.String value)
  System.String get_SchemaName()
  System.Void set_SchemaName(System.String value)
  System.Boolean get_InCollection()
  System.Void set_InCollection(System.Boolean value)
  System.Data.DataTable get_Table()
  System.Data.PropertyCollection get_ExtendedProperties()
  System.Boolean ContainsColumn(System.Data.DataColumn column)
  System.Boolean CanEnableConstraint()
  System.Data.Constraint Clone(System.Data.DataSet destination)
  System.Data.Constraint Clone(System.Data.DataSet destination, System.Boolean ignoreNSforTableLookup)
  System.Void CheckConstraint()
  System.Void CheckCanAddToCollection(System.Data.ConstraintCollection constraint)
  System.Boolean CanBeRemovedFromCollection(System.Data.ConstraintCollection constraint, System.Boolean fThrowException)
  System.Void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action)
  System.Void CheckState()
  System.Void CheckStateForProperty()
  System.Data.DataSet get__DataSet()
  System.Boolean IsConstraintViolated()
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: System.Data.ConstraintCollection
TYPE:  class
TOKEN: 0x2000009
EXTENDS: InternalDataCollectionBase
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Collections.ArrayList    _list  // 0x18
  private           System.Int32                    _defaultNameIndex  // 0x20
  private           System.ComponentModel.CollectionChangeEventHandler_onCollectionChanged  // 0x28
  private           System.Data.Constraint[]        _delayLoadingConstraints  // 0x30
  private           System.Boolean                  _fLoadForeignKeyConstraintsOnly  // 0x38
METHODS:
  System.Void .ctor(System.Data.DataTable table)
  System.Collections.ArrayList get_List()
  System.Data.Constraint get_Item(System.Int32 index)
  System.Data.DataTable get_Table()
  System.Data.Constraint get_Item(System.String name)
  System.Void Add(System.Data.Constraint constraint)
  System.Void Add(System.Data.Constraint constraint, System.Boolean addUniqueWhenAddingForeign)
  System.Data.Constraint Add(System.String name, System.Data.DataColumn[] columns, System.Boolean primaryKey)
  System.Void AddUniqueConstraint(System.Data.UniqueConstraint constraint)
  System.Void AddForeignKeyConstraint(System.Data.ForeignKeyConstraint constraint)
  System.Boolean AutoGenerated(System.Data.Constraint constraint)
  System.Void ArrayAdd(System.Data.Constraint constraint)
  System.Void ArrayRemove(System.Data.Constraint constraint)
  System.String AssignName()
  System.Void BaseAdd(System.Data.Constraint constraint)
  System.Void BaseGroupSwitch(System.Data.Constraint[] oldArray, System.Int32 oldLength, System.Data.Constraint[] newArray, System.Int32 newLength)
  System.Void BaseRemove(System.Data.Constraint constraint)
  System.Boolean CanRemove(System.Data.Constraint constraint, System.Boolean fThrowException)
  System.Void Clear()
  System.Boolean Contains(System.String name)
  System.Boolean Contains(System.String name, System.Boolean caseSensitive)
  System.Data.Constraint FindConstraint(System.Data.Constraint constraint)
  System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn[] columns)
  System.Data.UniqueConstraint FindKeyConstraint(System.Data.DataColumn column)
  System.Data.ForeignKeyConstraint FindForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns)
  System.Boolean CompareArrays(System.Data.DataColumn[] a1, System.Data.DataColumn[] a2)
  System.Int32 InternalIndexOf(System.String constraintName)
  System.String MakeName(System.Int32 index)
  System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent)
  System.Void RegisterName(System.String name)
  System.Void Remove(System.Data.Constraint constraint)
  System.Void UnregisterName(System.String name)
END_CLASS

CLASS: System.Data.ConstraintConverter
TYPE:  class
TOKEN: 0x200000A
EXTENDS: ExpandableObjectConverter
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
END_CLASS

CLASS: System.Data.ConstraintEnumerator
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private           System.Collections.IEnumerator  _tables  // 0x10
  private           System.Collections.IEnumerator  _constraints  // 0x18
  private           System.Data.Constraint          _currentObject  // 0x20
METHODS:
  System.Void .ctor(System.Data.DataSet dataSet)
  System.Boolean GetNext()
  System.Data.Constraint GetConstraint()
  System.Boolean IsValidCandidate(System.Data.Constraint constraint)
  System.Data.Constraint get_CurrentObject()
END_CLASS

CLASS: System.Data.ForeignKeyConstraintEnumerator
TYPE:  class
TOKEN: 0x200000C
EXTENDS: ConstraintEnumerator
FIELDS:
METHODS:
  System.Void .ctor(System.Data.DataSet dataSet)
  System.Boolean IsValidCandidate(System.Data.Constraint constraint)
  System.Data.ForeignKeyConstraint GetForeignKeyConstraint()
END_CLASS

CLASS: System.Data.ChildForeignKeyConstraintEnumerator
TYPE:  class
TOKEN: 0x200000D
EXTENDS: ForeignKeyConstraintEnumerator
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x28
METHODS:
  System.Void .ctor(System.Data.DataSet dataSet, System.Data.DataTable inTable)
  System.Boolean IsValidCandidate(System.Data.Constraint constraint)
END_CLASS

CLASS: System.Data.ParentForeignKeyConstraintEnumerator
TYPE:  class
TOKEN: 0x200000E
EXTENDS: ForeignKeyConstraintEnumerator
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x28
METHODS:
  System.Void .ctor(System.Data.DataSet dataSet, System.Data.DataTable inTable)
  System.Boolean IsValidCandidate(System.Data.Constraint constraint)
END_CLASS

CLASS: System.Data.DataColumn
TYPE:  class
TOKEN: 0x200000F
EXTENDS: MarshalByValueComponent
FIELDS:
  private           System.Boolean                  _allowNull  // 0x20
  private           System.String                   _caption  // 0x28
  private           System.String                   _columnName  // 0x30
  private           System.Type                     _dataType  // 0x38
  private           System.Data.Common.StorageType  _storageType  // 0x40
  private           System.Object                   _defaultValue  // 0x48
  private           System.Data.DataSetDateTime     _dateTimeMode  // 0x50
  private           System.Data.DataExpression      _expression  // 0x58
  private           System.Int32                    _maxLength  // 0x60
  private           System.Int32                    _ordinal  // 0x64
  private           System.Boolean                  _readOnly  // 0x68
  private           System.Data.Index               _sortIndex  // 0x70
  private           System.Data.DataTable           _table  // 0x78
  private           System.Boolean                  _unique  // 0x80
  private           System.Data.MappingType         _columnMapping  // 0x84
  private           System.Int32                    _hashCode  // 0x88
  private           System.Int32                    _errors  // 0x8C
  private           System.Boolean                  _isSqlType  // 0x90
  private           System.Boolean                  _implementsINullable  // 0x91
  private           System.Boolean                  _implementsIChangeTracking  // 0x92
  private           System.Boolean                  _implementsIRevertibleChangeTracking  // 0x93
  private           System.Boolean                  _implementsIXMLSerializable  // 0x94
  private           System.Boolean                  _defaultValueIsNull  // 0x95
  private           System.Collections.Generic.List<System.Data.DataColumn>_dependentColumns  // 0x98
  private           System.Data.PropertyCollection  _extendedProperties  // 0xA0
  private           System.Data.Common.DataStorage  _storage  // 0xA8
  private           System.Data.AutoIncrementValue  _autoInc  // 0xB0
  private           System.String                   _columnUri  // 0xB8
  private           System.String                   _columnPrefix  // 0xC0
  private           System.String                   _encodedColumnName  // 0xC8
  private           System.Data.SimpleType          _simpleType  // 0xD0
  private   static  System.Int32                    s_objectTypeCount  // 0x0
  private   readonly System.Int32                    _objectID  // 0xD8
  private           System.String                   <XmlDataType>k__BackingField  // 0xE0
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanging  // 0xE8
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String columnName, System.Type dataType)
  System.Void .ctor(System.String columnName, System.Type dataType, System.String expr, System.Data.MappingType type)
  System.Void UpdateColumnType(System.Type type, System.Data.Common.StorageType typeCode)
  System.Boolean get_AllowDBNull()
  System.Void set_AllowDBNull(System.Boolean value)
  System.Boolean get_AutoIncrement()
  System.Void set_AutoIncrement(System.Boolean value)
  System.Object get_AutoIncrementCurrent()
  System.Void set_AutoIncrementCurrent(System.Object value)
  System.Data.AutoIncrementValue get_AutoInc()
  System.Int64 get_AutoIncrementSeed()
  System.Void set_AutoIncrementSeed(System.Int64 value)
  System.Int64 get_AutoIncrementStep()
  System.Void set_AutoIncrementStep(System.Int64 value)
  System.String get_Caption()
  System.Void set_Caption(System.String value)
  System.String get_ColumnName()
  System.Void set_ColumnName(System.String value)
  System.String get_EncodedColumnName()
  System.IFormatProvider get_FormatProvider()
  System.Globalization.CultureInfo get_Locale()
  System.Int32 get_ObjectID()
  System.String get_Prefix()
  System.Void set_Prefix(System.String value)
  System.String GetColumnValueAsString(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Boolean get_Computed()
  System.Data.DataExpression get_DataExpression()
  System.Type get_DataType()
  System.Void set_DataType(System.Type value)
  System.Data.DataSetDateTime get_DateTimeMode()
  System.Void set_DateTimeMode(System.Data.DataSetDateTime value)
  System.Object get_DefaultValue()
  System.Void set_DefaultValue(System.Object value)
  System.Boolean get_DefaultValueIsNull()
  System.String get_Expression()
  System.Void set_Expression(System.String value)
  System.Data.PropertyCollection get_ExtendedProperties()
  System.Boolean get_HasData()
  System.Boolean get_ImplementsINullable()
  System.Boolean get_ImplementsIChangeTracking()
  System.Boolean get_ImplementsIRevertibleChangeTracking()
  System.Boolean get_IsValueType()
  System.Boolean get_IsSqlType()
  System.Void SetMaxLengthSimpleType()
  System.Int32 get_MaxLength()
  System.Void set_MaxLength(System.Int32 value)
  System.String get_Namespace()
  System.Void set_Namespace(System.String value)
  System.Int32 get_Ordinal()
  System.Void SetOrdinalInternal(System.Int32 ordinal)
  System.Boolean get_ReadOnly()
  System.Void set_ReadOnly(System.Boolean value)
  System.Data.Index get_SortIndex()
  System.Data.DataTable get_Table()
  System.Void SetTable(System.Data.DataTable table)
  System.Data.DataRow GetDataRow(System.Int32 index)
  System.Object get_Item(System.Int32 record)
  System.Void set_Item(System.Int32 record, System.Object value)
  System.Void InitializeRecord(System.Int32 record)
  System.Void SetValue(System.Int32 record, System.Object value)
  System.Void FreeRecord(System.Int32 record)
  System.Boolean get_Unique()
  System.Void set_Unique(System.Boolean value)
  System.Void InternalUnique(System.Boolean value)
  System.String get_XmlDataType()
  System.Void set_XmlDataType(System.String value)
  System.Data.SimpleType get_SimpleType()
  System.Void set_SimpleType(System.Data.SimpleType value)
  System.Data.MappingType get_ColumnMapping()
  System.Void set_ColumnMapping(System.Data.MappingType value)
  System.Void CheckColumnConstraint(System.Data.DataRow row, System.Data.DataRowAction action)
  System.Boolean CheckMaxLength()
  System.Void CheckMaxLength(System.Data.DataRow dr)
  System.Void CheckNotAllowNull()
  System.Void CheckNullable(System.Data.DataRow row)
  System.Void CheckUnique()
  System.Int32 Compare(System.Int32 record1, System.Int32 record2)
  System.Boolean CompareValueTo(System.Int32 record1, System.Object value, System.Boolean checkType)
  System.Int32 CompareValueTo(System.Int32 record1, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 srcRecordNo, System.Int32 dstRecordNo)
  System.Data.DataColumn Clone()
  System.Object GetAggregateValue(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 GetStringLength(System.Int32 record)
  System.Void Init(System.Int32 record)
  System.Boolean IsAutoIncrementType(System.Type dataType)
  System.Boolean get_IsCustomType()
  System.Boolean IsValueCustomTypeInstance(System.Object value)
  System.Boolean get_ImplementsIXMLSerializable()
  System.Boolean IsInRelation()
  System.Boolean IsMaxLengthViolated()
  System.Boolean IsNotAllowDBNullViolated()
  System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent)
  System.Void RaisePropertyChanging(System.String name)
  System.Void InsureStorage()
  System.Void SetCapacity(System.Int32 capacity)
  System.Void OnSetDataSet()
  System.String ToString()
  System.Object ConvertXmlToObject(System.String s)
  System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  System.String ConvertObjectToXml(System.Object value)
  System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  System.Object GetEmptyColumnStore(System.Int32 recordCount)
  System.Void CopyValueIntoStore(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  System.Void AddDependentColumn(System.Data.DataColumn expressionColumn)
  System.Void RemoveDependentColumn(System.Data.DataColumn expressionColumn)
  System.Void HandleDependentColumnList(System.Data.DataExpression oldExpression, System.Data.DataExpression newExpression)
END_CLASS

CLASS: System.Data.AutoIncrementValue
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private           System.Boolean                  <Auto>k__BackingField  // 0x10
METHODS:
  System.Boolean get_Auto()
  System.Void set_Auto(System.Boolean value)
  System.Object get_Current()
  System.Void set_Current(System.Object value)
  System.Int64 get_Seed()
  System.Void set_Seed(System.Int64 value)
  System.Int64 get_Step()
  System.Void set_Step(System.Int64 value)
  System.Type get_DataType()
  System.Void SetCurrent(System.Object value, System.IFormatProvider formatProvider)
  System.Void SetCurrentAndIncrement(System.Object value)
  System.Void MoveAfter()
  System.Data.AutoIncrementValue Clone()
  System.Void .ctor()
END_CLASS

CLASS: System.Data.AutoIncrementInt64
TYPE:  class
TOKEN: 0x2000011
EXTENDS: AutoIncrementValue
FIELDS:
  private           System.Int64                    _current  // 0x18
  private           System.Int64                    _seed  // 0x20
  private           System.Int64                    _step  // 0x28
METHODS:
  System.Object get_Current()
  System.Void set_Current(System.Object value)
  System.Type get_DataType()
  System.Int64 get_Seed()
  System.Void set_Seed(System.Int64 value)
  System.Int64 get_Step()
  System.Void set_Step(System.Int64 value)
  System.Void MoveAfter()
  System.Void SetCurrent(System.Object value, System.IFormatProvider formatProvider)
  System.Void SetCurrentAndIncrement(System.Object value)
  System.Boolean BoundaryCheck(System.Numerics.BigInteger value)
  System.Void .ctor()
END_CLASS

CLASS: System.Data.AutoIncrementBigInteger
TYPE:  class
TOKEN: 0x2000012
EXTENDS: AutoIncrementValue
FIELDS:
  private           System.Numerics.BigInteger      _current  // 0x18
  private           System.Int64                    _seed  // 0x28
  private           System.Numerics.BigInteger      _step  // 0x30
METHODS:
  System.Object get_Current()
  System.Void set_Current(System.Object value)
  System.Type get_DataType()
  System.Int64 get_Seed()
  System.Void set_Seed(System.Int64 value)
  System.Int64 get_Step()
  System.Void set_Step(System.Int64 value)
  System.Void MoveAfter()
  System.Void SetCurrent(System.Object value, System.IFormatProvider formatProvider)
  System.Void SetCurrentAndIncrement(System.Object value)
  System.Boolean BoundaryCheck(System.Numerics.BigInteger value)
  System.Void .ctor()
END_CLASS

CLASS: System.Data.DataColumnChangeEventArgs
TYPE:  class
TOKEN: 0x2000013
EXTENDS: EventArgs
FIELDS:
  private           System.Data.DataColumn          _column  // 0x10
  private   readonly System.Data.DataRow             <Row>k__BackingField  // 0x18
  private           System.Object                   <ProposedValue>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Data.DataRow row)
  System.Void .ctor(System.Data.DataRow row, System.Data.DataColumn column, System.Object value)
  System.Object get_ProposedValue()
  System.Void set_ProposedValue(System.Object value)
  System.Void InitializeColumnChangeEvent(System.Data.DataColumn column, System.Object value)
END_CLASS

CLASS: System.Data.DataColumnChangeEventHandler
TYPE:  class
TOKEN: 0x2000014
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Data.DataColumnChangeEventArgs e)
END_CLASS

CLASS: System.Data.DataColumnCollection
TYPE:  class
TOKEN: 0x2000015
EXTENDS: InternalDataCollectionBase
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Collections.ArrayList    _list  // 0x18
  private           System.Int32                    _defaultNameIndex  // 0x20
  private           System.Data.DataColumn[]        _delayedAddRangeColumns  // 0x28
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Data.DataColumn>_columnFromName  // 0x30
  private           System.Boolean                  _fInClear  // 0x38
  private           System.Data.DataColumn[]        _columnsImplementingIChangeTracking  // 0x40
  private           System.Int32                    _nColumnsImplementingIChangeTracking  // 0x48
  private           System.Int32                    _nColumnsImplementingIRevertibleChangeTracking  // 0x4C
  private           System.ComponentModel.CollectionChangeEventHandlerCollectionChanged  // 0x50
  private           System.ComponentModel.CollectionChangeEventHandlerCollectionChanging  // 0x58
  private           System.ComponentModel.CollectionChangeEventHandlerColumnPropertyChanged  // 0x60
METHODS:
  System.Void .ctor(System.Data.DataTable table)
  System.Collections.ArrayList get_List()
  System.Data.DataColumn[] get_ColumnsImplementingIChangeTracking()
  System.Int32 get_ColumnsImplementingIChangeTrackingCount()
  System.Int32 get_ColumnsImplementingIRevertibleChangeTrackingCount()
  System.Data.DataColumn get_Item(System.Int32 index)
  System.Data.DataColumn get_Item(System.String name)
  System.Data.DataColumn get_Item(System.String name, System.String ns)
  System.Void Add(System.Data.DataColumn column)
  System.Void AddAt(System.Int32 index, System.Data.DataColumn column)
  System.Void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value)
  System.Void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value)
  System.Void add_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value)
  System.Void remove_ColumnPropertyChanged(System.ComponentModel.CollectionChangeEventHandler value)
  System.Void ArrayAdd(System.Data.DataColumn column)
  System.Void ArrayAdd(System.Int32 index, System.Data.DataColumn column)
  System.Void ArrayRemove(System.Data.DataColumn column)
  System.String AssignName()
  System.Void BaseAdd(System.Data.DataColumn column)
  System.Void BaseGroupSwitch(System.Data.DataColumn[] oldArray, System.Int32 oldLength, System.Data.DataColumn[] newArray, System.Int32 newLength)
  System.Void BaseRemove(System.Data.DataColumn column)
  System.Boolean CanRemove(System.Data.DataColumn column, System.Boolean fThrowException)
  System.Void CheckIChangeTracking(System.Data.DataColumn column)
  System.Void Clear()
  System.Boolean Contains(System.String name)
  System.Boolean Contains(System.String name, System.Boolean caseSensitive)
  System.Int32 IndexOf(System.String columnName)
  System.Int32 IndexOfCaseInsensitive(System.String name)
  System.String MakeName(System.Int32 index)
  System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent)
  System.Void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent)
  System.Void OnColumnPropertyChanged(System.ComponentModel.CollectionChangeEventArgs ccevent)
  System.Void RegisterColumnName(System.String name, System.Data.DataColumn column)
  System.Boolean CanRegisterName(System.String name)
  System.Void Remove(System.Data.DataColumn column)
  System.Void UnregisterName(System.String name)
  System.Void AddColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn)
  System.Void RemoveColumnsImplementingIChangeTrackingList(System.Data.DataColumn dataColumn)
END_CLASS

CLASS: System.Data.DataColumnPropertyDescriptor
TYPE:  class
TOKEN: 0x2000016
EXTENDS: PropertyDescriptor
FIELDS:
  private   readonly System.Data.DataColumn          <Column>k__BackingField  // 0x88
METHODS:
  System.Void .ctor(System.Data.DataColumn dataColumn)
  System.ComponentModel.AttributeCollection get_Attributes()
  System.Data.DataColumn get_Column()
  System.Type get_ComponentType()
  System.Boolean get_IsReadOnly()
  System.Type get_PropertyType()
  System.Boolean Equals(System.Object other)
  System.Int32 GetHashCode()
  System.Boolean CanResetValue(System.Object component)
  System.Object GetValue(System.Object component)
  System.Void ResetValue(System.Object component)
  System.Void SetValue(System.Object component, System.Object value)
  System.Boolean ShouldSerializeValue(System.Object component)
END_CLASS

CLASS: System.Data.DataError
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private           System.String                   _rowError  // 0x10
  private           System.Int32                    _count  // 0x18
  private           System.Data.DataError.ColumnError[]_errorList  // 0x20
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String rowError)
  System.String get_Text()
  System.Void set_Text(System.String value)
  System.Boolean get_HasErrors()
  System.Void SetColumnError(System.Data.DataColumn column, System.String error)
  System.String GetColumnError(System.Data.DataColumn column)
  System.Void Clear(System.Data.DataColumn column)
  System.Void Clear()
  System.Data.DataColumn[] GetColumnsInError()
  System.Void SetText(System.String errorText)
  System.Int32 IndexOf(System.Data.DataColumn column)
END_CLASS

CLASS: System.Data.DataException
TYPE:  class
TOKEN: 0x2000019
EXTENDS: SystemException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
  System.Void .ctor(System.String s, System.Exception innerException)
END_CLASS

CLASS: System.Data.ConstraintException
TYPE:  class
TOKEN: 0x200001A
EXTENDS: DataException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.DeletedRowInaccessibleException
TYPE:  class
TOKEN: 0x200001B
EXTENDS: DataException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.DuplicateNameException
TYPE:  class
TOKEN: 0x200001C
EXTENDS: DataException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.InRowChangingEventException
TYPE:  class
TOKEN: 0x200001D
EXTENDS: DataException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.InvalidConstraintException
TYPE:  class
TOKEN: 0x200001E
EXTENDS: DataException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.NoNullAllowedException
TYPE:  class
TOKEN: 0x200001F
EXTENDS: DataException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.ReadOnlyException
TYPE:  class
TOKEN: 0x2000020
EXTENDS: DataException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.RowNotInTableException
TYPE:  class
TOKEN: 0x2000021
EXTENDS: DataException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.VersionNotFoundException
TYPE:  class
TOKEN: 0x2000022
EXTENDS: DataException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.ExceptionBuilder
TYPE:  class
TOKEN: 0x2000023
FIELDS:
METHODS:
  System.Void TraceException(System.String trace, System.Exception e)
  System.Exception TraceExceptionAsReturnValue(System.Exception e)
  System.Exception TraceExceptionForCapture(System.Exception e)
  System.Exception TraceExceptionWithoutRethrow(System.Exception e)
  System.Exception _Argument(System.String error)
  System.Exception _Argument(System.String error, System.Exception innerException)
  System.Exception _ArgumentNull(System.String paramName, System.String msg)
  System.Exception _ArgumentOutOfRange(System.String paramName, System.String msg)
  System.Exception _IndexOutOfRange(System.String error)
  System.Exception _InvalidOperation(System.String error)
  System.Exception _InvalidEnumArgumentException(System.String error)
  System.Exception _InvalidEnumArgumentException(T value)
  System.Void ThrowDataException(System.String error, System.Exception innerException)
  System.Exception _Data(System.String error)
  System.Exception _Constraint(System.String error)
  System.Exception _InvalidConstraint(System.String error)
  System.Exception _DeletedRowInaccessible(System.String error)
  System.Exception _DuplicateName(System.String error)
  System.Exception _InRowChangingEvent(System.String error)
  System.Exception _NoNullAllowed(System.String error)
  System.Exception _ReadOnly(System.String error)
  System.Exception _RowNotInTable(System.String error)
  System.Exception _VersionNotFound(System.String error)
  System.Exception ArgumentNull(System.String paramName)
  System.Exception ArgumentOutOfRange(System.String paramName)
  System.Exception BadObjectPropertyAccess(System.String error)
  System.Exception CaseInsensitiveNameConflict(System.String name)
  System.Exception NamespaceNameConflict(System.String name)
  System.Exception InvalidOffsetLength()
  System.Exception ColumnNotInTheTable(System.String column, System.String table)
  System.Exception ColumnNotInAnyTable()
  System.Exception ColumnOutOfRange(System.Int32 index)
  System.Exception ColumnOutOfRange(System.String column)
  System.Exception CannotAddColumn1(System.String column)
  System.Exception CannotAddColumn2(System.String column)
  System.Exception CannotAddColumn3()
  System.Exception CannotAddColumn4(System.String column)
  System.Exception CannotAddDuplicate(System.String column)
  System.Exception CannotAddDuplicate2(System.String table)
  System.Exception CannotAddDuplicate3(System.String table)
  System.Exception CannotRemoveColumn()
  System.Exception CannotRemovePrimaryKey()
  System.Exception CannotRemoveChildKey(System.String relation)
  System.Exception CannotRemoveConstraint(System.String constraint, System.String table)
  System.Exception CannotRemoveExpression(System.String column, System.String expression)
  System.Exception AddPrimaryKeyConstraint()
  System.Exception NoConstraintName()
  System.Exception ConstraintViolation(System.String constraint)
  System.String KeysToString(System.Object[] keys)
  System.String UniqueConstraintViolationText(System.Data.DataColumn[] columns, System.Object[] values)
  System.Exception ConstraintViolation(System.Data.DataColumn[] columns, System.Object[] values)
  System.Exception ConstraintOutOfRange(System.Int32 index)
  System.Exception DuplicateConstraint(System.String constraint)
  System.Exception DuplicateConstraintName(System.String constraint)
  System.Exception NeededForForeignKeyConstraint(System.Data.UniqueConstraint key, System.Data.ForeignKeyConstraint fk)
  System.Exception UniqueConstraintViolation()
  System.Exception ConstraintForeignTable()
  System.Exception ConstraintParentValues()
  System.Exception ConstraintAddFailed(System.Data.DataTable table)
  System.Exception ConstraintRemoveFailed()
  System.Exception FailedCascadeDelete(System.String constraint)
  System.Exception FailedCascadeUpdate(System.String constraint)
  System.Exception FailedClearParentTable(System.String table, System.String constraint, System.String childTable)
  System.Exception ForeignKeyViolation(System.String constraint, System.Object[] keys)
  System.Exception RemoveParentRow(System.Data.ForeignKeyConstraint constraint)
  System.String MaxLengthViolationText(System.String columnName)
  System.String NotAllowDBNullViolationText(System.String columnName)
  System.Exception CantAddConstraintToMultipleNestedTable(System.String tableName)
  System.Exception AutoIncrementAndExpression()
  System.Exception AutoIncrementAndDefaultValue()
  System.Exception AutoIncrementSeed()
  System.Exception CantChangeDataType()
  System.Exception NullDataType()
  System.Exception ColumnNameRequired()
  System.Exception DefaultValueAndAutoIncrement()
  System.Exception DefaultValueDataType(System.String column, System.Type defaultType, System.Type columnType, System.Exception inner)
  System.Exception DefaultValueColumnDataType(System.String column, System.Type defaultType, System.Type columnType, System.Exception inner)
  System.Exception ExpressionAndUnique()
  System.Exception ExpressionAndReadOnly()
  System.Exception ExpressionAndConstraint(System.Data.DataColumn column, System.Data.Constraint constraint)
  System.Exception ExpressionInConstraint(System.Data.DataColumn column)
  System.Exception ExpressionCircular()
  System.Exception NonUniqueValues(System.String column)
  System.Exception NullKeyValues(System.String column)
  System.Exception NullValues(System.String column)
  System.Exception ReadOnlyAndExpression()
  System.Exception ReadOnly(System.String column)
  System.Exception UniqueAndExpression()
  System.Exception SetFailed(System.Object value, System.Data.DataColumn column, System.Type type, System.Exception innerException)
  System.Exception CannotSetToNull(System.Data.DataColumn column)
  System.Exception LongerThanMaxLength(System.Data.DataColumn column)
  System.Exception CannotSetMaxLength(System.Data.DataColumn column, System.Int32 value)
  System.Exception CannotSetMaxLength2(System.Data.DataColumn column)
  System.Exception CannotSetSimpleContentType(System.String columnName, System.Type type)
  System.Exception CannotSetSimpleContent(System.String columnName, System.Type type)
  System.Exception CannotChangeNamespace(System.String columnName)
  System.Exception HasToBeStringType(System.Data.DataColumn column)
  System.Exception AutoIncrementCannotSetIfHasData(System.String typeName)
  System.Exception INullableUDTwithoutStaticNull(System.String typeName)
  System.Exception IComparableNotImplemented(System.String typeName)
  System.Exception UDTImplementsIChangeTrackingButnotIRevertible(System.String typeName)
  System.Exception InvalidDataColumnMapping(System.Type type)
  System.Exception CannotSetDateTimeModeForNonDateTimeColumns()
  System.Exception InvalidDateTimeMode(System.Data.DataSetDateTime mode)
  System.Exception CantChangeDateTimeMode(System.Data.DataSetDateTime oldValue, System.Data.DataSetDateTime newValue)
  System.Exception ColumnTypeNotSupported()
  System.Exception SetFailed(System.String name)
  System.Exception CanNotUse()
  System.Exception SetIListObject()
  System.Exception AddNewNotAllowNull()
  System.Exception NotOpen()
  System.Exception CreateChildView()
  System.Exception CanNotDelete()
  System.Exception GetElementIndex(System.Int32 index)
  System.Exception AddExternalObject()
  System.Exception CanNotClear()
  System.Exception InsertExternalObject()
  System.Exception RemoveExternalObject()
  System.Exception KeyTableMismatch()
  System.Exception KeyNoColumns()
  System.Exception KeyTooManyColumns(System.Int32 cols)
  System.Exception KeyDuplicateColumns(System.String columnName)
  System.Exception RelationDataSetMismatch()
  System.Exception ColumnsTypeMismatch()
  System.Exception KeyLengthMismatch()
  System.Exception KeyLengthZero()
  System.Exception ForeignRelation()
  System.Exception KeyColumnsIdentical()
  System.Exception RelationForeignTable(System.String t1, System.String t2)
  System.Exception GetParentRowTableMismatch(System.String t1, System.String t2)
  System.Exception SetParentRowTableMismatch(System.String t1, System.String t2)
  System.Exception RelationForeignRow()
  System.Exception RelationNestedReadOnly()
  System.Exception TableCantBeNestedInTwoTables(System.String tableName)
  System.Exception LoopInNestedRelations(System.String tableName)
  System.Exception RelationDoesNotExist()
  System.Exception ParentOrChildColumnsDoNotHaveDataSet()
  System.Exception InValidNestedRelation(System.String childTableName)
  System.Exception InvalidParentNamespaceinNestedRelation(System.String childTableName)
  System.Exception RowNotInTheDataSet()
  System.Exception RowNotInTheTable()
  System.Exception EditInRowChanging()
  System.Exception EndEditInRowChanging()
  System.Exception BeginEditInRowChanging()
  System.Exception CancelEditInRowChanging()
  System.Exception DeleteInRowDeleting()
  System.Exception ValueArrayLength()
  System.Exception NoCurrentData()
  System.Exception NoOriginalData()
  System.Exception NoProposedData()
  System.Exception RowRemovedFromTheTable()
  System.Exception DeletedRowInaccessible()
  System.Exception RowAlreadyDeleted()
  System.Exception RowEmpty()
  System.Exception InvalidRowVersion()
  System.Exception RowOutOfRange(System.Int32 index)
  System.Exception RowInsertTwice(System.Int32 index, System.String tableName)
  System.Exception RowInsertMissing(System.String tableName)
  System.Exception RowAlreadyRemoved()
  System.Exception MultipleParents()
  System.Exception InvalidRowState(System.Data.DataRowState state)
  System.Exception InvalidRowBitPattern()
  System.Exception SetDataSetNameToEmpty()
  System.Exception SetDataSetNameConflicting(System.String name)
  System.Exception DataSetUnsupportedSchema(System.String ns)
  System.Exception MergeMissingDefinition(System.String obj)
  System.Exception TablesInDifferentSets()
  System.Exception RelationAlreadyExists()
  System.Exception RowAlreadyInOtherCollection()
  System.Exception RowAlreadyInTheCollection()
  System.Exception RecordStateRange()
  System.Exception IndexKeyLength(System.Int32 length, System.Int32 keyLength)
  System.Exception RemovePrimaryKey(System.Data.DataTable table)
  System.Exception RelationAlreadyInOtherDataSet()
  System.Exception RelationAlreadyInTheDataSet()
  System.Exception RelationNotInTheDataSet(System.String relation)
  System.Exception RelationOutOfRange(System.Object index)
  System.Exception DuplicateRelation(System.String relation)
  System.Exception RelationTableNull()
  System.Exception RelationDataSetNull()
  System.Exception RelationTableWasRemoved()
  System.Exception ParentTableMismatch()
  System.Exception ChildTableMismatch()
  System.Exception EnforceConstraint()
  System.Exception CaseLocaleMismatch()
  System.Exception CannotChangeCaseLocale()
  System.Exception CannotChangeCaseLocale(System.Exception innerException)
  System.Exception InvalidRemotingFormat(System.Data.SerializationFormat mode)
  System.Exception TableForeignPrimaryKey()
  System.Exception TableCannotAddToSimpleContent()
  System.Exception NoTableName()
  System.Exception MultipleTextOnlyColumns()
  System.Exception InvalidSortString(System.String sort)
  System.Exception DuplicateTableName(System.String table)
  System.Exception DuplicateTableName2(System.String table, System.String ns)
  System.Exception SelfnestedDatasetConflictingName(System.String table)
  System.Exception DatasetConflictingName(System.String table)
  System.Exception TableAlreadyInOtherDataSet()
  System.Exception TableAlreadyInTheDataSet()
  System.Exception TableOutOfRange(System.Int32 index)
  System.Exception TableNotInTheDataSet(System.String table)
  System.Exception TableInRelation()
  System.Exception TableInConstraint(System.Data.DataTable table, System.Data.Constraint constraint)
  System.Exception CanNotSerializeDataTableHierarchy()
  System.Exception CanNotRemoteDataTable()
  System.Exception CanNotSetRemotingFormat()
  System.Exception CanNotSerializeDataTableWithEmptyName()
  System.Exception TableNotFound(System.String tableName)
  System.Exception AggregateException(System.Data.AggregateType aggregateType, System.Type type)
  System.Exception InvalidStorageType(System.TypeCode typecode)
  System.Exception RangeArgument(System.Int32 min, System.Int32 max)
  System.Exception NullRange()
  System.Exception NegativeMinimumCapacity()
  System.Exception ProblematicChars(System.Char charValue)
  System.Exception StorageSetFailed()
  System.Exception SimpleTypeNotSupported()
  System.Exception MissingAttribute(System.String attribute)
  System.Exception MissingAttribute(System.String element, System.String attribute)
  System.Exception InvalidAttributeValue(System.String name, System.String value)
  System.Exception AttributeValues(System.String name, System.String value1, System.String value2)
  System.Exception ElementTypeNotFound(System.String name)
  System.Exception RelationParentNameMissing(System.String rel)
  System.Exception RelationChildNameMissing(System.String rel)
  System.Exception RelationTableKeyMissing(System.String rel)
  System.Exception RelationChildKeyMissing(System.String rel)
  System.Exception UndefinedDatatype(System.String name)
  System.Exception DatatypeNotDefined()
  System.Exception MismatchKeyLength()
  System.Exception InvalidField(System.String name)
  System.Exception InvalidSelector(System.String name)
  System.Exception CircularComplexType(System.String name)
  System.Exception CannotInstantiateAbstract(System.String name)
  System.Exception InvalidKey(System.String name)
  System.Exception DiffgramMissingTable(System.String name)
  System.Exception DiffgramMissingSQL()
  System.Exception DuplicateConstraintRead(System.String str)
  System.Exception ColumnTypeConflict(System.String name)
  System.Exception CannotConvert(System.String name, System.String type)
  System.Exception MissingRefer(System.String name)
  System.Exception InvalidPrefix(System.String name)
  System.Exception CanNotDeserializeObjectType()
  System.Exception IsDataSetAttributeMissingInSchema()
  System.Exception TooManyIsDataSetAtributeInSchema()
  System.Exception NestedCircular(System.String name)
  System.Exception MultipleParentRows(System.String tableQName)
  System.Exception PolymorphismNotSupported(System.String typeName)
  System.Exception DataTableInferenceNotSupported()
  System.Void ThrowMultipleTargetConverter(System.Exception innerException)
  System.Exception DuplicateDeclaration(System.String name)
  System.Exception FoundEntity()
  System.Exception MergeFailed(System.String name)
  System.Exception ConvertFailed(System.Type type1, System.Type type2)
  System.Exception InvalidDuplicateNamedSimpleTypeDelaration(System.String stName, System.String errorStr)
  System.Exception InternalRBTreeError(System.Data.RBTreeError internalError)
  System.Exception EnumeratorModified()
END_CLASS

CLASS: System.Data.DataKey
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  private   readonly System.Data.DataColumn[]        _columns  // 0x10
METHODS:
  System.Void .ctor(System.Data.DataColumn[] columns, System.Boolean copyColumns)
  System.Data.DataColumn[] get_ColumnsReference()
  System.Boolean get_HasValue()
  System.Data.DataTable get_Table()
  System.Void CheckState()
  System.Boolean ColumnsEqual(System.Data.DataKey key)
  System.Boolean ColumnsEqual(System.Data.DataColumn[] column1, System.Data.DataColumn[] column2)
  System.Boolean ContainsColumn(System.Data.DataColumn column)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object value)
  System.Boolean Equals(System.Data.DataKey value)
  System.String[] GetColumnNames()
  System.Data.IndexField[] GetIndexDesc()
  System.Object[] GetKeyValues(System.Int32 record)
  System.Data.Index GetSortIndex()
  System.Data.Index GetSortIndex(System.Data.DataViewRowState recordStates)
  System.Boolean RecordsEqual(System.Int32 record1, System.Int32 record2)
  System.Data.DataColumn[] ToArray()
END_CLASS

CLASS: System.Data.DataRelation
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  private           System.Data.DataSet             _dataSet  // 0x10
  private           System.Data.PropertyCollection  _extendedProperties  // 0x18
  private           System.String                   _relationName  // 0x20
  private           System.Data.DataKey             _childKey  // 0x28
  private           System.Data.DataKey             _parentKey  // 0x30
  private           System.Data.UniqueConstraint    _parentKeyConstraint  // 0x38
  private           System.Data.ForeignKeyConstraint_childKeyConstraint  // 0x40
  private           System.String[]                 _parentColumnNames  // 0x48
  private           System.String[]                 _childColumnNames  // 0x50
  private           System.String                   _parentTableName  // 0x58
  private           System.String                   _childTableName  // 0x60
  private           System.String                   _parentTableNamespace  // 0x68
  private           System.String                   _childTableNamespace  // 0x70
  private           System.Boolean                  _nested  // 0x78
  private           System.Boolean                  _createConstraints  // 0x79
  private           System.Boolean                  _checkMultipleNested  // 0x7A
  private   static  System.Int32                    s_objectTypeCount  // 0x0
  private   readonly System.Int32                    _objectID  // 0x7C
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanging  // 0x80
METHODS:
  System.Void .ctor(System.String relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, System.Boolean createConstraints)
  System.Void .ctor(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns)
  System.Void .ctor(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, System.Boolean createConstraints)
  System.Void .ctor(System.String relationName, System.String parentTableName, System.String childTableName, System.String[] parentColumnNames, System.String[] childColumnNames, System.Boolean nested)
  System.Void .ctor(System.String relationName, System.String parentTableName, System.String parentTableNamespace, System.String childTableName, System.String childTableNamespace, System.String[] parentColumnNames, System.String[] childColumnNames, System.Boolean nested)
  System.Data.DataColumn[] get_ChildColumns()
  System.Data.DataColumn[] get_ChildColumnsReference()
  System.Data.DataKey get_ChildKey()
  System.Data.DataTable get_ChildTable()
  System.Data.DataSet get_DataSet()
  System.String[] get_ParentColumnNames()
  System.String[] get_ChildColumnNames()
  System.Boolean IsKeyNull(System.Object[] values)
  System.Data.DataRow[] GetChildRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow parentRow, System.Data.DataRowVersion version)
  System.Data.DataRow[] GetParentRows(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version)
  System.Data.DataRow GetParentRow(System.Data.DataKey parentKey, System.Data.DataKey childKey, System.Data.DataRow childRow, System.Data.DataRowVersion version)
  System.Void SetDataSet(System.Data.DataSet dataSet)
  System.Data.DataColumn[] get_ParentColumns()
  System.Data.DataColumn[] get_ParentColumnsReference()
  System.Data.DataKey get_ParentKey()
  System.Data.DataTable get_ParentTable()
  System.String get_RelationName()
  System.Void CheckNamespaceValidityForNestedRelations(System.String ns)
  System.Void CheckNestedRelations()
  System.Boolean get_Nested()
  System.Void set_Nested(System.Boolean value)
  System.Data.UniqueConstraint get_ParentKeyConstraint()
  System.Void SetParentKeyConstraint(System.Data.UniqueConstraint value)
  System.Data.ForeignKeyConstraint get_ChildKeyConstraint()
  System.Data.PropertyCollection get_ExtendedProperties()
  System.Boolean get_CheckMultipleNested()
  System.Void set_CheckMultipleNested(System.Boolean value)
  System.Void SetChildKeyConstraint(System.Data.ForeignKeyConstraint value)
  System.Void CheckState()
  System.Void CheckStateForProperty()
  System.Void Create(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, System.Boolean createConstraints)
  System.Data.DataRelation Clone(System.Data.DataSet destination)
  System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent)
  System.Void RaisePropertyChanging(System.String name)
  System.String ToString()
  System.Void ValidateMultipleNestedRelations()
  System.Boolean IsAutoGenerated(System.Data.DataColumn col)
  System.Int32 get_ObjectID()
END_CLASS

CLASS: System.Data.DataRelationCollection
TYPE:  class
TOKEN: 0x2000026
EXTENDS: InternalDataCollectionBase
FIELDS:
  private           System.Data.DataRelation        _inTransition  // 0x10
  private           System.Int32                    _defaultNameIndex  // 0x18
  private           System.ComponentModel.CollectionChangeEventHandler_onCollectionChangedDelegate  // 0x20
  private           System.ComponentModel.CollectionChangeEventHandler_onCollectionChangingDelegate  // 0x28
  private   static  System.Int32                    s_objectTypeCount  // 0x0
  private   readonly System.Int32                    _objectID  // 0x30
METHODS:
  System.Int32 get_ObjectID()
  System.Data.DataRelation get_Item(System.Int32 index)
  System.Data.DataRelation get_Item(System.String name)
  System.Void Add(System.Data.DataRelation relation)
  System.Void AddCore(System.Data.DataRelation relation)
  System.Void add_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value)
  System.Void remove_CollectionChanged(System.ComponentModel.CollectionChangeEventHandler value)
  System.String AssignName()
  System.Void Clear()
  System.Boolean Contains(System.String name)
  System.Int32 InternalIndexOf(System.String name)
  System.Data.DataSet GetDataSet()
  System.String MakeName(System.Int32 index)
  System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent)
  System.Void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent)
  System.Void RegisterName(System.String name)
  System.Void Remove(System.Data.DataRelation relation)
  System.Void RemoveAt(System.Int32 index)
  System.Void RemoveCore(System.Data.DataRelation relation)
  System.Void UnregisterName(System.String name)
  System.Void .ctor()
END_CLASS

CLASS: System.Data.DataRelationPropertyDescriptor
TYPE:  class
TOKEN: 0x2000029
EXTENDS: PropertyDescriptor
FIELDS:
  private   readonly System.Data.DataRelation        <Relation>k__BackingField  // 0x88
METHODS:
  System.Void .ctor(System.Data.DataRelation dataRelation)
  System.Data.DataRelation get_Relation()
  System.Type get_ComponentType()
  System.Boolean get_IsReadOnly()
  System.Type get_PropertyType()
  System.Boolean Equals(System.Object other)
  System.Int32 GetHashCode()
  System.Boolean CanResetValue(System.Object component)
  System.Object GetValue(System.Object component)
  System.Void ResetValue(System.Object component)
  System.Void SetValue(System.Object component, System.Object value)
  System.Boolean ShouldSerializeValue(System.Object component)
END_CLASS

CLASS: System.Data.DataRow
TYPE:  class
TOKEN: 0x200002A
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Data.DataColumnCollection_columns  // 0x18
  private           System.Int32                    _oldRecord  // 0x20
  private           System.Int32                    _newRecord  // 0x24
  private           System.Int32                    _tempRecord  // 0x28
  private           System.Int64                    _rowID  // 0x30
  private           System.Data.DataRowAction       _action  // 0x38
  private           System.Boolean                  _inChangingEvent  // 0x3C
  private           System.Boolean                  _inDeletingEvent  // 0x3D
  private           System.Boolean                  _inCascade  // 0x3E
  private           System.Data.DataColumn          _lastChangedColumn  // 0x40
  private           System.Int32                    _countColumnChange  // 0x48
  private           System.Data.DataError           _error  // 0x50
  private           System.Int32                    _rbTreeNodeId  // 0x58
  private   static  System.Int32                    s_objectTypeCount  // 0x0
  private   readonly System.Int32                    _objectID  // 0x5C
METHODS:
  System.Void .ctor(System.Data.DataRowBuilder builder)
  System.Data.DataColumn get_LastChangedColumn()
  System.Void set_LastChangedColumn(System.Data.DataColumn value)
  System.Boolean get_HasPropertyChanged()
  System.Int32 get_RBTreeNodeId()
  System.Void set_RBTreeNodeId(System.Int32 value)
  System.String get_RowError()
  System.Void set_RowError(System.String value)
  System.Void RowErrorChanged()
  System.Int64 get_rowID()
  System.Void set_rowID(System.Int64 value)
  System.Data.DataRowState get_RowState()
  System.Data.DataTable get_Table()
  System.Void CheckForLoops(System.Data.DataRelation rel)
  System.Int32 GetNestedParentCount()
  System.Void set_Item(System.String columnName, System.Object value)
  System.Object get_Item(System.Data.DataColumn column)
  System.Void set_Item(System.Data.DataColumn column, System.Object value)
  System.Object get_Item(System.Data.DataColumn column, System.Data.DataRowVersion version)
  System.Void set_ItemArray(System.Object[] value)
  System.Void AcceptChanges()
  System.Void BeginEdit()
  System.Boolean BeginEditInternal()
  System.Void CancelEdit()
  System.Void CheckColumn(System.Data.DataColumn column)
  System.Void CheckInTable()
  System.Void Delete()
  System.Void EndEdit()
  System.Void SetColumnError(System.Int32 columnIndex, System.String error)
  System.Void SetColumnError(System.Data.DataColumn column, System.String error)
  System.String GetColumnError(System.Data.DataColumn column)
  System.Void ClearErrors()
  System.Void ClearError(System.Data.DataColumn column)
  System.Boolean get_HasErrors()
  System.Data.DataColumn[] GetColumnsInError()
  System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation)
  System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation, System.Data.DataRowVersion version)
  System.Data.DataColumn GetDataColumn(System.String columnName)
  System.Data.DataRow GetParentRow(System.Data.DataRelation relation)
  System.Data.DataRow GetParentRow(System.Data.DataRelation relation, System.Data.DataRowVersion version)
  System.Data.DataRow GetNestedParentRow(System.Data.DataRowVersion version)
  System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation)
  System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation, System.Data.DataRowVersion version)
  System.Object[] GetColumnValues(System.Data.DataColumn[] columns)
  System.Object[] GetColumnValues(System.Data.DataColumn[] columns, System.Data.DataRowVersion version)
  System.Object[] GetKeyValues(System.Data.DataKey key)
  System.Object[] GetKeyValues(System.Data.DataKey key, System.Data.DataRowVersion version)
  System.Int32 GetCurrentRecordNo()
  System.Int32 GetDefaultRecord()
  System.Int32 GetOriginalRecordNo()
  System.Int32 GetProposedRecordNo()
  System.Int32 GetRecordFromVersion(System.Data.DataRowVersion version)
  System.Data.DataRowVersion GetDefaultRowVersion(System.Data.DataViewRowState viewState)
  System.Data.DataViewRowState GetRecordState(System.Int32 record)
  System.Boolean HasKeyChanged(System.Data.DataKey key)
  System.Boolean HasKeyChanged(System.Data.DataKey key, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2)
  System.Boolean HasVersion(System.Data.DataRowVersion version)
  System.Boolean HaveValuesChanged(System.Data.DataColumn[] columns)
  System.Boolean HaveValuesChanged(System.Data.DataColumn[] columns, System.Data.DataRowVersion version1, System.Data.DataRowVersion version2)
  System.Void RejectChanges()
  System.Void ResetLastChangedColumn()
  System.Void SetKeyValues(System.Data.DataKey key, System.Object[] keyValues)
  System.Void SetNestedParentRow(System.Data.DataRow parentRow, System.Boolean setNonNested)
  System.Void SetParentRowToDBNull()
  System.Void SetParentRowToDBNull(System.Data.DataRelation relation)
  System.Int32 CopyValuesIntoStore(System.Collections.ArrayList storeList, System.Collections.ArrayList nullbitList, System.Int32 storeIndex)
END_CLASS

CLASS: System.Data.DataRowBuilder
TYPE:  class
TOKEN: 0x200002B
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private           System.Int32                    _record  // 0x18
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.Int32 record)
END_CLASS

CLASS: System.Data.DataRowAction
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.DataRowAction       Nothing  // 0x0
  public    static  System.Data.DataRowAction       Delete  // 0x0
  public    static  System.Data.DataRowAction       Change  // 0x0
  public    static  System.Data.DataRowAction       Rollback  // 0x0
  public    static  System.Data.DataRowAction       Commit  // 0x0
  public    static  System.Data.DataRowAction       Add  // 0x0
  public    static  System.Data.DataRowAction       ChangeOriginal  // 0x0
  public    static  System.Data.DataRowAction       ChangeCurrentAndOriginal  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.DataRowChangeEventArgs
TYPE:  class
TOKEN: 0x200002D
EXTENDS: EventArgs
FIELDS:
  private   readonly System.Data.DataRow             <Row>k__BackingField  // 0x10
  private   readonly System.Data.DataRowAction       <Action>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Data.DataRow row, System.Data.DataRowAction action)
END_CLASS

CLASS: System.Data.DataRowChangeEventHandler
TYPE:  class
TOKEN: 0x200002E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Data.DataRowChangeEventArgs e)
END_CLASS

CLASS: System.Data.DataRowCollection
TYPE:  class
TOKEN: 0x200002F
EXTENDS: InternalDataCollectionBase
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Data.DataRowCollection.DataRowTree_list  // 0x18
  private           System.Int32                    _nullInList  // 0x20
METHODS:
  System.Void .ctor(System.Data.DataTable table)
  System.Int32 get_Count()
  System.Data.DataRow get_Item(System.Int32 index)
  System.Void Add(System.Data.DataRow row)
  System.Void DiffInsertAt(System.Data.DataRow row, System.Int32 pos)
  System.Int32 IndexOf(System.Data.DataRow row)
  System.Data.DataRow AddWithColumnEvents(System.Object[] values)
  System.Void ArrayAdd(System.Data.DataRow row)
  System.Void ArrayInsert(System.Data.DataRow row, System.Int32 pos)
  System.Void ArrayClear()
  System.Void ArrayRemove(System.Data.DataRow row)
  System.Void CopyTo(System.Array ar, System.Int32 index)
  System.Void CopyTo(System.Data.DataRow[] array, System.Int32 index)
  System.Collections.IEnumerator GetEnumerator()
END_CLASS

CLASS: System.Data.DataRowCreatedEventHandler
TYPE:  class
TOKEN: 0x2000031
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Data.DataRow r)
END_CLASS

CLASS: System.Data.DataSetClearEventhandler
TYPE:  class
TOKEN: 0x2000032
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Data.DataTable table)
END_CLASS

CLASS: System.Data.DataRowState
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.DataRowState        Detached  // 0x0
  public    static  System.Data.DataRowState        Unchanged  // 0x0
  public    static  System.Data.DataRowState        Added  // 0x0
  public    static  System.Data.DataRowState        Deleted  // 0x0
  public    static  System.Data.DataRowState        Modified  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.DataRowVersion
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.DataRowVersion      Original  // 0x0
  public    static  System.Data.DataRowVersion      Current  // 0x0
  public    static  System.Data.DataRowVersion      Proposed  // 0x0
  public    static  System.Data.DataRowVersion      Default  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.DataRowView
TYPE:  class
TOKEN: 0x2000035
FIELDS:
  private   readonly System.Data.DataView            _dataView  // 0x10
  private   readonly System.Data.DataRow             _row  // 0x18
  private           System.Boolean                  _delayBeginEdit  // 0x20
  private   static readonly System.ComponentModel.PropertyDescriptorCollections_zeroPropertyDescriptorCollection  // 0x0
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanged  // 0x28
METHODS:
  System.Void .ctor(System.Data.DataView dataView, System.Data.DataRow row)
  System.Boolean Equals(System.Object other)
  System.Int32 GetHashCode()
  System.Data.DataView get_DataView()
  System.Data.DataRowVersion get_RowVersionDefault()
  System.Int32 GetRecord()
  System.Boolean HasRecord()
  System.Object GetColumnValue(System.Data.DataColumn column)
  System.Void SetColumnValue(System.Data.DataColumn column, System.Object value)
  System.Data.DataView CreateChildView(System.Data.DataRelation relation, System.Boolean followParent)
  System.Data.DataView CreateChildView(System.Data.DataRelation relation)
  System.Data.DataRow get_Row()
  System.Void EndEdit()
  System.Boolean get_IsNew()
  System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void RaisePropertyChangedEvent(System.String propName)
  System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
  System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
  System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes)
  System.Object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SerializationFormat
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SerializationFormat Xml  // 0x0
  public    static  System.Data.SerializationFormat Binary  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.DataSet
TYPE:  class
TOKEN: 0x2000037
EXTENDS: MarshalByValueComponent
FIELDS:
  private           System.Data.DataViewManager     _defaultViewManager  // 0x20
  private   readonly System.Data.DataTableCollection _tableCollection  // 0x28
  private   readonly System.Data.DataRelationCollection_relationCollection  // 0x30
  private           System.Data.PropertyCollection  _extendedProperties  // 0x38
  private           System.String                   _dataSetName  // 0x40
  private           System.String                   _datasetPrefix  // 0x48
  private           System.String                   _namespaceURI  // 0x50
  private           System.Boolean                  _enforceConstraints  // 0x58
  private           System.Boolean                  _caseSensitive  // 0x59
  private           System.Globalization.CultureInfo_culture  // 0x60
  private           System.Boolean                  _cultureUserSet  // 0x68
  private           System.Boolean                  _fInReadXml  // 0x69
  private           System.Boolean                  _fInLoadDiffgram  // 0x6A
  private           System.Boolean                  _fTopLevelTable  // 0x6B
  private           System.Boolean                  _fInitInProgress  // 0x6C
  private           System.Boolean                  _fEnableCascading  // 0x6D
  private           System.Boolean                  _fIsSchemaLoading  // 0x6E
  private           System.String                   _mainTableName  // 0x70
  private           System.Data.SerializationFormat _remotingFormat  // 0x78
  private           System.Object                   _defaultViewManagerLock  // 0x80
  private   static  System.Int32                    s_objectTypeCount  // 0x0
  private   readonly System.Int32                    _objectID  // 0x88
  private   static  System.Xml.Schema.XmlSchemaComplexTypes_schemaTypeForWSDL  // 0x8
  private           System.Boolean                  _useDataSetSchemaOnly  // 0x8C
  private           System.Boolean                  _udtIsWrapped  // 0x8D
  private           System.ComponentModel.PropertyChangedEventHandlerPropertyChanging  // 0x90
  private           System.Data.MergeFailedEventHandlerMergeFailed  // 0x98
  private           System.Data.DataRowCreatedEventHandlerDataRowCreated  // 0xA0
  private           System.Data.DataSetClearEventhandlerClearFunctionCalled  // 0xA8
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String dataSetName)
  System.Data.SerializationFormat get_RemotingFormat()
  System.Void set_RemotingFormat(System.Data.SerializationFormat value)
  System.Data.SchemaSerializationMode get_SchemaSerializationMode()
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean ConstructSchema)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void InitializeDerivedDataSet()
  System.Void SerializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat)
  System.Void DeserializeDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode)
  System.Void DeserializeDataSetSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat, System.Data.SchemaSerializationMode schemaSerializationMode)
  System.Void DeserializeDataSetData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Data.SerializationFormat remotingFormat)
  System.Void SerializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void DeserializeDataSetProperties(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void SerializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void DeserializeRelations(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void FailedEnableConstraints()
  System.Boolean get_CaseSensitive()
  System.Void set_CaseSensitive(System.Boolean value)
  System.Boolean get_EnforceConstraints()
  System.Void set_EnforceConstraints(System.Boolean value)
  System.Void RestoreEnforceConstraints(System.Boolean value)
  System.Void EnableConstraints()
  System.String get_DataSetName()
  System.Void set_DataSetName(System.String value)
  System.String get_Namespace()
  System.Void set_Namespace(System.String value)
  System.String get_Prefix()
  System.Void set_Prefix(System.String value)
  System.Data.PropertyCollection get_ExtendedProperties()
  System.Globalization.CultureInfo get_Locale()
  System.Void set_Locale(System.Globalization.CultureInfo value)
  System.Void SetLocaleValue(System.Globalization.CultureInfo value, System.Boolean userSet)
  System.Boolean ShouldSerializeLocale()
  System.ComponentModel.ISite get_Site()
  System.Data.DataRelationCollection get_Relations()
  System.Data.DataTableCollection get_Tables()
  System.Void Clear()
  System.Data.DataSet Clone()
  System.Int32 EstimatedXmlStringSize()
  System.String GetRemotingDiffGram(System.Data.DataTable table)
  System.String GetXmlSchemaForRemoting(System.Data.DataTable table)
  System.Void ReadXmlSchema(System.Xml.XmlReader reader)
  System.Void ReadXmlSchema(System.Xml.XmlReader reader, System.Boolean denyResolving)
  System.Boolean MoveToElement(System.Xml.XmlReader reader, System.Int32 depth)
  System.Void MoveToElement(System.Xml.XmlReader reader)
  System.Void ReadEndElement(System.Xml.XmlReader reader)
  System.Void ReadXSDSchema(System.Xml.XmlReader reader, System.Boolean denyResolving)
  System.Void ReadXDRSchema(System.Xml.XmlReader reader)
  System.Void WriteXmlSchema(System.Xml.XmlWriter writer, System.Data.SchemaFormat schemaFormat, System.Converter<System.Type,System.String> multipleTargetConverter)
  System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader)
  System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Boolean denyResolving)
  System.Void InferSchema(System.Xml.XmlDocument xdoc, System.String[] excludedNamespaces, System.Data.XmlReadMode mode)
  System.Boolean IsEmpty()
  System.Void ReadXmlDiffgram(System.Xml.XmlReader reader)
  System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode)
  System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, System.Boolean denyResolving)
  System.Void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode)
  System.Void Merge(System.Data.DataSet dataSet)
  System.Void Merge(System.Data.DataSet dataSet, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction)
  System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent)
  System.Void OnMergeFailed(System.Data.MergeFailedEventArgs mfevent)
  System.Void RaiseMergeFailed(System.Data.DataTable table, System.String conflict, System.Data.MissingSchemaAction missingSchemaAction)
  System.Void OnDataRowCreated(System.Data.DataRow row)
  System.Void OnClearFunctionCalled(System.Data.DataTable table)
  System.Void OnRemoveTable(System.Data.DataTable table)
  System.Void OnRemovedTable(System.Data.DataTable table)
  System.Void OnRemoveRelation(System.Data.DataRelation relation)
  System.Void OnRemoveRelationHack(System.Data.DataRelation relation)
  System.Void RaisePropertyChanging(System.String name)
  System.Data.DataTable[] TopLevelTables()
  System.Data.DataTable[] TopLevelTables(System.Boolean forSchema)
  System.Void Reset()
  System.Boolean ValidateCaseConstraint()
  System.Boolean ValidateLocaleConstraint()
  System.Void ReadXmlSerializable(System.Xml.XmlReader reader)
  System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.String get_MainTableName()
  System.Void set_MainTableName(System.String value)
  System.Int32 get_ObjectID()
END_CLASS

CLASS: System.Data.DataSetDateTime
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.DataSetDateTime     Local  // 0x0
  public    static  System.Data.DataSetDateTime     Unspecified  // 0x0
  public    static  System.Data.DataSetDateTime     UnspecifiedLocal  // 0x0
  public    static  System.Data.DataSetDateTime     Utc  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.DataTable
TYPE:  class
TOKEN: 0x2000039
EXTENDS: MarshalByValueComponent
FIELDS:
  private           System.Data.DataSet             _dataSet  // 0x20
  private           System.Data.DataView            _defaultView  // 0x28
  private           System.Int64                    _nextRowID  // 0x30
  private   readonly System.Data.DataRowCollection   _rowCollection  // 0x38
  private   readonly System.Data.DataColumnCollection_columnCollection  // 0x40
  private   readonly System.Data.ConstraintCollection_constraintCollection  // 0x48
  private           System.Int32                    _elementColumnCount  // 0x50
  private           System.Data.DataRelationCollection_parentRelationsCollection  // 0x58
  private           System.Data.DataRelationCollection_childRelationsCollection  // 0x60
  private   readonly System.Data.RecordManager       _recordManager  // 0x68
  private   readonly System.Collections.Generic.List<System.Data.Index>_indexes  // 0x70
  private           System.Collections.Generic.List<System.Data.Index>_shadowIndexes  // 0x78
  private           System.Int32                    _shadowCount  // 0x80
  private           System.Data.PropertyCollection  _extendedProperties  // 0x88
  private           System.String                   _tableName  // 0x90
  private           System.String                   _tableNamespace  // 0x98
  private           System.String                   _tablePrefix  // 0xA0
  private           System.Data.DataExpression      _displayExpression  // 0xA8
  private           System.Boolean                  _fNestedInDataset  // 0xB0
  private           System.Globalization.CultureInfo_culture  // 0xB8
  private           System.Boolean                  _cultureUserSet  // 0xC0
  private           System.Globalization.CompareInfo_compareInfo  // 0xC8
  private           System.Globalization.CompareOptions_compareFlags  // 0xD0
  private           System.IFormatProvider          _formatProvider  // 0xD8
  private           System.StringComparer           _hashCodeProvider  // 0xE0
  private           System.Boolean                  _caseSensitive  // 0xE8
  private           System.Boolean                  _caseSensitiveUserSet  // 0xE9
  private           System.String                   _encodedTableName  // 0xF0
  private           System.Data.DataColumn          _xmlText  // 0xF8
  private           System.Data.DataColumn          _colUnique  // 0x100
  private           System.Decimal                  _minOccurs  // 0x108
  private           System.Decimal                  _maxOccurs  // 0x118
  private           System.Boolean                  _repeatableElement  // 0x128
  private           System.Object                   _typeName  // 0x130
  private           System.Data.UniqueConstraint    _primaryKey  // 0x138
  private           System.Data.IndexField[]        _primaryIndex  // 0x140
  private           System.Data.DataColumn[]        _delayedSetPrimaryKey  // 0x148
  private           System.Data.Index               _loadIndex  // 0x150
  private           System.Data.Index               _loadIndexwithOriginalAdded  // 0x158
  private           System.Data.Index               _loadIndexwithCurrentDeleted  // 0x160
  private           System.Int32                    _suspendIndexEvents  // 0x168
  private           System.Boolean                  _inDataLoad  // 0x16C
  private           System.Boolean                  _schemaLoading  // 0x16D
  private           System.Boolean                  _enforceConstraints  // 0x16E
  private           System.Boolean                  _suspendEnforceConstraints  // 0x16F
  protected internal        System.Boolean                  fInitInProgress  // 0x170
  private           System.Boolean                  _inLoad  // 0x171
  private           System.Boolean                  _fInLoadDiffgram  // 0x172
  private           System.Byte                     _isTypedDataTable  // 0x173
  private           System.Data.DataRow[]           _emptyDataRowArray  // 0x178
  private           System.ComponentModel.PropertyDescriptorCollection_propertyDescriptorCollectionCache  // 0x180
  private           System.Data.DataRelation[]      _nestedParentRelations  // 0x188
  private           System.Collections.Generic.List<System.Data.DataColumn>_dependentColumns  // 0x190
  private           System.Boolean                  _mergingData  // 0x198
  private           System.Data.DataRowChangeEventHandler_onRowChangedDelegate  // 0x1A0
  private           System.Data.DataRowChangeEventHandler_onRowChangingDelegate  // 0x1A8
  private           System.Data.DataRowChangeEventHandler_onRowDeletingDelegate  // 0x1B0
  private           System.Data.DataRowChangeEventHandler_onRowDeletedDelegate  // 0x1B8
  private           System.Data.DataColumnChangeEventHandler_onColumnChangedDelegate  // 0x1C0
  private           System.Data.DataColumnChangeEventHandler_onColumnChangingDelegate  // 0x1C8
  private           System.Data.DataTableClearEventHandler_onTableClearingDelegate  // 0x1D0
  private           System.Data.DataTableClearEventHandler_onTableClearedDelegate  // 0x1D8
  private           System.Data.DataTableNewRowEventHandler_onTableNewRowDelegate  // 0x1E0
  private           System.ComponentModel.PropertyChangedEventHandler_onPropertyChangingDelegate  // 0x1E8
  private   readonly System.Data.DataRowBuilder      _rowBuilder  // 0x1F0
  private   readonly System.Collections.Generic.List<System.Data.DataView>_delayedViews  // 0x1F8
  private   readonly System.Collections.Generic.List<System.Data.DataViewListener>_dataViewListeners  // 0x200
  private           System.Collections.Hashtable    _rowDiffId  // 0x208
  private   readonly System.Threading.ReaderWriterLockSlim_indexesLock  // 0x210
  private           System.Int32                    _ukColumnPositionForInference  // 0x218
  private           System.Data.SerializationFormat _remotingFormat  // 0x21C
  private   static  System.Int32                    s_objectTypeCount  // 0x0
  private   readonly System.Int32                    _objectID  // 0x220
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String tableName)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void SerializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable, System.Data.SerializationFormat remotingFormat)
  System.Void DeserializeDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable, System.Data.SerializationFormat remotingFormat)
  System.Void SerializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable)
  System.Void DeserializeTableSchema(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Boolean isSingleTable)
  System.Void SerializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex, System.Boolean allConstraints)
  System.Void DeserializeConstraints(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex, System.Boolean allConstraints)
  System.Void SerializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex)
  System.Void DeserializeExpressionColumns(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex)
  System.Void SerializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex)
  System.Void DeserializeTableData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Int32 serIndex)
  System.Data.DataRowState ConvertToRowState(System.Collections.BitArray bitStates, System.Int32 bitIndex)
  System.Void GetRowAndColumnErrors(System.Int32 rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors)
  System.Void ConvertToRowError(System.Int32 rowIndex, System.Collections.Hashtable rowErrors, System.Collections.Hashtable colErrors)
  System.Boolean get_CaseSensitive()
  System.Void set_CaseSensitive(System.Boolean value)
  System.Boolean get_AreIndexEventsSuspended()
  System.Void RestoreIndexEvents(System.Boolean forceReset)
  System.Void SuspendIndexEvents()
  System.Boolean get_IsTypedDataTable()
  System.Boolean SetCaseSensitiveValue(System.Boolean isCaseSensitive, System.Boolean userSet, System.Boolean resetIndexes)
  System.Boolean ShouldSerializeCaseSensitive()
  System.Boolean get_SelfNested()
  System.Collections.Generic.List<System.Data.Index> get_LiveIndexes()
  System.Data.SerializationFormat get_RemotingFormat()
  System.Void set_RemotingFormat(System.Data.SerializationFormat value)
  System.Int32 get_UKColumnPositionForInference()
  System.Void set_UKColumnPositionForInference(System.Int32 value)
  System.Data.DataRelationCollection get_ChildRelations()
  System.Data.DataColumnCollection get_Columns()
  System.Globalization.CompareInfo get_CompareInfo()
  System.Data.ConstraintCollection get_Constraints()
  System.Void ResetConstraints()
  System.Data.DataSet get_DataSet()
  System.Void SetDataSet(System.Data.DataSet dataSet)
  System.String get_DisplayExpressionInternal()
  System.Boolean get_EnforceConstraints()
  System.Void set_EnforceConstraints(System.Boolean value)
  System.Boolean get_SuspendEnforceConstraints()
  System.Void set_SuspendEnforceConstraints(System.Boolean value)
  System.Void EnableConstraints()
  System.Data.PropertyCollection get_ExtendedProperties()
  System.IFormatProvider get_FormatProvider()
  System.Globalization.CultureInfo get_Locale()
  System.Void set_Locale(System.Globalization.CultureInfo value)
  System.Boolean SetLocaleValue(System.Globalization.CultureInfo culture, System.Boolean userSet, System.Boolean resetIndexes)
  System.Boolean ShouldSerializeLocale()
  System.Int32 get_MinimumCapacity()
  System.Void set_MinimumCapacity(System.Int32 value)
  System.Int32 get_RecordCapacity()
  System.Int32 get_ElementColumnCount()
  System.Void set_ElementColumnCount(System.Int32 value)
  System.Data.DataRelationCollection get_ParentRelations()
  System.Boolean get_MergingData()
  System.Void set_MergingData(System.Boolean value)
  System.Data.DataRelation[] get_NestedParentRelations()
  System.Boolean get_SchemaLoading()
  System.Void CacheNestedParent()
  System.Data.DataRelation[] FindNestedParentRelations()
  System.Int32 get_NestedParentsCount()
  System.Data.DataColumn[] get_PrimaryKey()
  System.Void set_PrimaryKey(System.Data.DataColumn[] value)
  System.Data.DataRowCollection get_Rows()
  System.String get_TableName()
  System.Void set_TableName(System.String value)
  System.String get_EncodedTableName()
  System.String GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables)
  System.String get_Namespace()
  System.Void set_Namespace(System.String value)
  System.Boolean IsNamespaceInherited()
  System.Void CheckCascadingNamespaceConflict(System.String realNamespace)
  System.Void CheckNamespaceValidityForNestedRelations(System.String realNamespace)
  System.Void CheckNamespaceValidityForNestedParentRelations(System.String ns, System.Data.DataTable parentTable)
  System.Void DoRaiseNamespaceChange()
  System.String get_Prefix()
  System.Void set_Prefix(System.String value)
  System.Data.DataColumn get_XmlText()
  System.Void set_XmlText(System.Data.DataColumn value)
  System.Decimal get_MaxOccurs()
  System.Void set_MaxOccurs(System.Decimal value)
  System.Decimal get_MinOccurs()
  System.Void set_MinOccurs(System.Decimal value)
  System.Void SetKeyValues(System.Data.DataKey key, System.Object[] keyValues, System.Int32 record)
  System.Data.DataRow FindByIndex(System.Data.Index ndx, System.Object[] key)
  System.Data.DataRow FindMergeTarget(System.Data.DataRow row, System.Data.DataKey key, System.Data.Index ndx)
  System.Void SetMergeRecords(System.Data.DataRow row, System.Int32 newRecord, System.Int32 oldRecord, System.Data.DataRowAction action)
  System.Data.DataRow MergeRow(System.Data.DataRow row, System.Data.DataRow targetRow, System.Boolean preserveChanges, System.Data.Index idxSearch)
  System.Data.DataTable CreateInstance()
  System.Data.DataTable Clone()
  System.Data.DataTable Clone(System.Data.DataSet cloneDS)
  System.Data.DataTable IncrementalCloneTo(System.Data.DataTable sourceTable, System.Data.DataTable targetTable)
  System.Data.DataTable CloneHierarchy(System.Data.DataTable sourceTable, System.Data.DataSet ds, System.Collections.Hashtable visitedMap)
  System.Data.DataTable CloneTo(System.Data.DataTable clone, System.Data.DataSet cloneDS, System.Boolean skipExpressionColumns)
  System.ComponentModel.ISite get_Site()
  System.Void AddRow(System.Data.DataRow row, System.Int32 proposedID)
  System.Void InsertRow(System.Data.DataRow row, System.Int32 proposedID, System.Int32 pos)
  System.Void InsertRow(System.Data.DataRow row, System.Int64 proposedID, System.Int32 pos, System.Boolean fireEvent)
  System.Void CheckNotModifying(System.Data.DataRow row)
  System.Void Clear()
  System.Void Clear(System.Boolean clearAll)
  System.Void CascadeAll(System.Data.DataRow row, System.Data.DataRowAction action)
  System.Void CommitRow(System.Data.DataRow row)
  System.Int32 Compare(System.String s1, System.String s2)
  System.Int32 Compare(System.String s1, System.String s2, System.Globalization.CompareInfo comparer)
  System.Int32 IndexOf(System.String s1, System.String s2)
  System.Boolean IsSuffix(System.String s1, System.String s2)
  System.Object Compute(System.String expression, System.String filter)
  System.Void DeleteRow(System.Data.DataRow row)
  System.String FormatSortString(System.Data.IndexField[] indexDesc)
  System.Void FreeRecord(System.Int32& record)
  System.Data.Index GetIndex(System.String sort, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  System.Data.Index GetIndex(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  System.Collections.Generic.List<System.Data.DataViewListener> GetListeners()
  System.Int32 GetSpecialHashCode(System.String name)
  System.Void InsertRow(System.Data.DataRow row, System.Int64 proposedID)
  System.Int32 NewRecord()
  System.Int32 NewUninitializedRecord()
  System.Int32 NewRecord(System.Int32 sourceRecord)
  System.Data.DataRow NewEmptyRow()
  System.Data.DataRow NewUninitializedRow()
  System.Data.DataRow NewRow()
  System.Data.DataRow CreateEmptyRow()
  System.Void NewRowCreated(System.Data.DataRow row)
  System.Data.DataRow NewRow(System.Int32 record)
  System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder)
  System.Type GetRowType()
  System.Data.DataRow[] NewRowArray(System.Int32 size)
  System.Boolean get_NeedColumnChangeEvents()
  System.Void OnColumnChanging(System.Data.DataColumnChangeEventArgs e)
  System.Void OnColumnChanged(System.Data.DataColumnChangeEventArgs e)
  System.Void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent)
  System.Void OnRemoveColumnInternal(System.Data.DataColumn column)
  System.Void OnRemoveColumn(System.Data.DataColumn column)
  System.Data.DataRowChangeEventArgs OnRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction)
  System.Data.DataRowChangeEventArgs OnRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction)
  System.Void OnRowChanged(System.Data.DataRowChangeEventArgs e)
  System.Void OnRowChanging(System.Data.DataRowChangeEventArgs e)
  System.Void OnRowDeleting(System.Data.DataRowChangeEventArgs e)
  System.Void OnRowDeleted(System.Data.DataRowChangeEventArgs e)
  System.Void OnTableCleared(System.Data.DataTableClearEventArgs e)
  System.Void OnTableClearing(System.Data.DataTableClearEventArgs e)
  System.Void OnTableNewRow(System.Data.DataTableNewRowEventArgs e)
  System.Data.IndexField[] ParseSortString(System.String sortString)
  System.Void RaisePropertyChanging(System.String name)
  System.Void RecordChanged(System.Int32 record)
  System.Void RecordChanged(System.Int32[] oldIndex, System.Int32[] newIndex)
  System.Void RecordStateChanged(System.Int32 record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState)
  System.Void RecordStateChanged(System.Int32 record1, System.Data.DataViewRowState oldState1, System.Data.DataViewRowState newState1, System.Int32 record2, System.Data.DataViewRowState oldState2, System.Data.DataViewRowState newState2)
  System.Int32[] RemoveRecordFromIndexes(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Int32[] InsertRecordToIndexes(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Void SilentlySetValue(System.Data.DataRow dr, System.Data.DataColumn dc, System.Data.DataRowVersion version, System.Object newValue)
  System.Void RemoveRow(System.Data.DataRow row, System.Boolean check)
  System.Void Reset()
  System.Void ResetIndexes()
  System.Void ResetInternalIndexes(System.Data.DataColumn column)
  System.Void RollbackRow(System.Data.DataRow row)
  System.Data.DataRowChangeEventArgs RaiseRowChanged(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction)
  System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction)
  System.Data.DataRowChangeEventArgs RaiseRowChanging(System.Data.DataRowChangeEventArgs args, System.Data.DataRow eRow, System.Data.DataRowAction eAction, System.Boolean fireEvent)
  System.Data.DataRow[] Select(System.String filterExpression, System.String sort, System.Data.DataViewRowState recordStates)
  System.Void SetNewRecord(System.Data.DataRow row, System.Int32 proposedRecord, System.Data.DataRowAction action, System.Boolean isInMerge, System.Boolean fireEvent, System.Boolean suppressEnsurePropertyChanged)
  System.Void SetNewRecordWorker(System.Data.DataRow row, System.Int32 proposedRecord, System.Data.DataRowAction action, System.Boolean isInMerge, System.Boolean suppressEnsurePropertyChanged, System.Int32 position, System.Boolean fireEvent, System.Exception& deferredException)
  System.Void SetOldRecord(System.Data.DataRow row, System.Int32 proposedRecord)
  System.Void RestoreShadowIndexes()
  System.Void SetShadowIndexes()
  System.Void ShadowIndexCopy()
  System.String ToString()
  System.Boolean UpdatingCurrent(System.Data.DataRow row, System.Data.DataRowAction action)
  System.Data.DataColumn AddUniqueKey(System.Int32 position)
  System.Data.DataColumn AddUniqueKey()
  System.Data.DataColumn AddForeignKey(System.Data.DataColumn parentKey)
  System.Void UpdatePropertyDescriptorCollectionCache()
  System.ComponentModel.PropertyDescriptorCollection GetPropertyDescriptorCollection(System.Attribute[] attributes)
  System.Xml.XmlQualifiedName get_TypeName()
  System.Void set_TypeName(System.Xml.XmlQualifiedName value)
  System.Void Merge(System.Data.DataTable table)
  System.Void Merge(System.Data.DataTable table, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction)
  System.Void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode, System.Boolean writeHierarchy)
  System.Boolean CheckForClosureOnExpressions(System.Data.DataTable dt, System.Boolean writeHierarchy)
  System.Boolean CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList)
  System.Void WriteXmlSchema(System.Xml.XmlWriter writer, System.Boolean writeHierarchy)
  System.Void RestoreConstraint(System.Boolean originalEnforceConstraint)
  System.Boolean IsEmptyXml(System.Xml.XmlReader reader)
  System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode, System.Boolean denyResolving)
  System.Void ReadEndElement(System.Xml.XmlReader reader)
  System.Void ReadXDRSchema(System.Xml.XmlReader reader)
  System.Boolean MoveToElement(System.Xml.XmlReader reader, System.Int32 depth)
  System.Void ReadXmlDiffgram(System.Xml.XmlReader reader)
  System.Void ReadXSDSchema(System.Xml.XmlReader reader, System.Boolean denyResolving)
  System.Void ReadXmlSchema(System.Xml.XmlReader reader, System.Boolean denyResolving)
  System.Void CreateTableList(System.Data.DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList)
  System.Void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList)
  System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Xml.Schema.XmlSchema GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Void ReadXmlSerializable(System.Xml.XmlReader reader)
  System.Collections.Hashtable get_RowDiffId()
  System.Int32 get_ObjectID()
  System.Void AddDependentColumn(System.Data.DataColumn expressionColumn)
  System.Void RemoveDependentColumn(System.Data.DataColumn expressionColumn)
  System.Void EvaluateExpressions()
  System.Void EvaluateExpressions(System.Data.DataRow row, System.Data.DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows)
  System.Void EvaluateExpressions(System.Data.DataColumn column)
  System.Void EvaluateDependentExpressions(System.Data.DataColumn column)
  System.Void EvaluateDependentExpressions(System.Collections.Generic.List<System.Data.DataColumn> columns, System.Data.DataRow row, System.Data.DataRowVersion version, System.Collections.Generic.List<System.Data.DataRow> cachedRows)
END_CLASS

CLASS: System.Data.DataTableClearEventArgs
TYPE:  class
TOKEN: 0x200003C
EXTENDS: EventArgs
FIELDS:
  private   readonly System.Data.DataTable           <Table>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Data.DataTable dataTable)
END_CLASS

CLASS: System.Data.DataTableClearEventHandler
TYPE:  class
TOKEN: 0x200003D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Data.DataTableClearEventArgs e)
END_CLASS

CLASS: System.Data.DataTableCollection
TYPE:  class
TOKEN: 0x200003E
EXTENDS: InternalDataCollectionBase
FIELDS:
  private   readonly System.Data.DataSet             _dataSet  // 0x10
  private   readonly System.Collections.ArrayList    _list  // 0x18
  private           System.Int32                    _defaultNameIndex  // 0x20
  private           System.Data.DataTable[]         _delayedAddRangeTables  // 0x28
  private           System.ComponentModel.CollectionChangeEventHandler_onCollectionChangedDelegate  // 0x30
  private           System.ComponentModel.CollectionChangeEventHandler_onCollectionChangingDelegate  // 0x38
  private   static  System.Int32                    s_objectTypeCount  // 0x0
  private   readonly System.Int32                    _objectID  // 0x40
METHODS:
  System.Void .ctor(System.Data.DataSet dataSet)
  System.Collections.ArrayList get_List()
  System.Int32 get_ObjectID()
  System.Data.DataTable get_Item(System.Int32 index)
  System.Data.DataTable get_Item(System.String name)
  System.Data.DataTable get_Item(System.String name, System.String tableNamespace)
  System.Data.DataTable GetTable(System.String name, System.String ns)
  System.Data.DataTable GetTableSmart(System.String name, System.String ns)
  System.Void Add(System.Data.DataTable table)
  System.Void ArrayAdd(System.Data.DataTable table)
  System.String AssignName()
  System.Void BaseAdd(System.Data.DataTable table)
  System.Void BaseGroupSwitch(System.Data.DataTable[] oldArray, System.Int32 oldLength, System.Data.DataTable[] newArray, System.Int32 newLength)
  System.Void BaseRemove(System.Data.DataTable table)
  System.Boolean CanRemove(System.Data.DataTable table, System.Boolean fThrowException)
  System.Void Clear()
  System.Boolean Contains(System.String name)
  System.Boolean Contains(System.String name, System.String tableNamespace, System.Boolean checkProperty, System.Boolean caseSensitive)
  System.Boolean Contains(System.String name, System.Boolean caseSensitive)
  System.Int32 IndexOf(System.Data.DataTable table)
  System.Int32 IndexOf(System.String tableName)
  System.Int32 IndexOf(System.String tableName, System.String tableNamespace, System.Boolean chekforNull)
  System.Void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList)
  System.Int32 InternalIndexOf(System.String tableName)
  System.Int32 InternalIndexOf(System.String tableName, System.String tableNamespace)
  System.String MakeName(System.Int32 index)
  System.Void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent)
  System.Void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent)
  System.Void RegisterName(System.String name, System.String tbNamespace)
  System.Void Remove(System.Data.DataTable table)
  System.Void UnregisterName(System.String name)
END_CLASS

CLASS: System.Data.DataTableNewRowEventArgs
TYPE:  class
TOKEN: 0x200003F
EXTENDS: EventArgs
FIELDS:
  private   readonly System.Data.DataRow             <Row>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Data.DataRow dataRow)
END_CLASS

CLASS: System.Data.DataTableNewRowEventHandler
TYPE:  class
TOKEN: 0x2000040
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Data.DataTableNewRowEventArgs e)
END_CLASS

CLASS: System.Data.DataTableTypeConverter
TYPE:  class
TOKEN: 0x2000041
EXTENDS: ReferenceConverter
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
END_CLASS

CLASS: System.Data.DataView
TYPE:  class
TOKEN: 0x2000042
EXTENDS: MarshalByValueComponent
FIELDS:
  private           System.Data.DataViewManager     _dataViewManager  // 0x20
  private           System.Data.DataTable           _table  // 0x28
  private           System.Boolean                  _locked  // 0x30
  private           System.Data.Index               _index  // 0x38
  private           System.Collections.Generic.Dictionary<System.String,System.Data.Index>_findIndexes  // 0x40
  private           System.String                   _sort  // 0x48
  private           System.Comparison<System.Data.DataRow>_comparison  // 0x50
  private           System.Data.IFilter             _rowFilter  // 0x58
  private           System.Data.DataViewRowState    _recordStates  // 0x60
  private           System.Boolean                  _shouldOpen  // 0x64
  private           System.Boolean                  _open  // 0x65
  private           System.Boolean                  _allowNew  // 0x66
  private           System.Boolean                  _allowEdit  // 0x67
  private           System.Boolean                  _allowDelete  // 0x68
  private           System.Boolean                  _applyDefaultSort  // 0x69
  private           System.Data.DataRow             _addNewRow  // 0x70
  private           System.ComponentModel.ListChangedEventArgs_addNewMoved  // 0x78
  private           System.ComponentModel.ListChangedEventHandler_onListChanged  // 0x80
  private   static  System.ComponentModel.ListChangedEventArgss_resetEventArgs  // 0x0
  private           System.Data.DataViewRowState    _delayedRecordStates  // 0x88
  private           System.Boolean                  _fEndInitInProgress  // 0x8C
  private           System.Collections.Generic.Dictionary<System.Data.DataRow,System.Data.DataRowView>_rowViewCache  // 0x90
  private   readonly System.Collections.Generic.Dictionary<System.Data.DataRow,System.Data.DataRowView>_rowViewBuffer  // 0x98
  private           System.Data.DataViewListener    _dvListener  // 0xA0
  private   static  System.Int32                    s_objectTypeCount  // 0x8
  private   readonly System.Int32                    _objectID  // 0xA8
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.Boolean locked)
  System.Boolean get_AllowDelete()
  System.Boolean get_AllowNew()
  System.Int32 get_Count()
  System.Int32 get_CountFromIndex()
  System.Data.DataViewManager get_DataViewManager()
  System.Boolean get_IsOpen()
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Data.DataViewRowState get_RowStateFilter()
  System.String get_Sort()
  System.Comparison<System.Data.DataRow> get_SortComparison()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Data.DataTable get_Table()
  System.Object System.Collections.IList.get_Item(System.Int32 recordIndex)
  System.Void System.Collections.IList.set_Item(System.Int32 recordIndex, System.Object value)
  System.Data.DataRowView get_Item(System.Int32 recordIndex)
  System.Data.DataRowView AddNew()
  System.Void CheckOpen()
  System.Void Close()
  System.Void CopyTo(System.Array array, System.Int32 index)
  System.Void CopyTo(System.Data.DataRowView[] array, System.Int32 index)
  System.Void Delete(System.Int32 index)
  System.Void Delete(System.Data.DataRow row)
  System.Void Dispose(System.Boolean disposing)
  System.Void FinishAddNew(System.Boolean success)
  System.Collections.IEnumerator GetEnumerator()
  System.Boolean System.Collections.IList.get_IsReadOnly()
  System.Boolean System.Collections.IList.get_IsFixedSize()
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Void System.Collections.IList.Clear()
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Int32 IndexOf(System.Data.DataRowView rowview)
  System.Int32 IndexOfDataRowView(System.Data.DataRowView rowview)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Void System.Collections.IList.RemoveAt(System.Int32 index)
  System.Data.IFilter GetFilter()
  System.Int32 GetRecord(System.Int32 recordIndex)
  System.Data.DataRow GetRow(System.Int32 index)
  System.Data.DataRowView GetRowView(System.Int32 record)
  System.Data.DataRowView GetRowView(System.Data.DataRow dr)
  System.Void IndexListChanged(System.Object sender, System.ComponentModel.ListChangedEventArgs e)
  System.Void IndexListChangedInternal(System.ComponentModel.ListChangedEventArgs e)
  System.Void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, System.Boolean trackAddRemove)
  System.Void OnListChanged(System.ComponentModel.ListChangedEventArgs e)
  System.Void Reset()
  System.Void ResetRowViewCache()
  System.Void SetDataViewManager(System.Data.DataViewManager dataViewManager)
  System.Void SetIndex(System.String newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter)
  System.Void SetIndex2(System.String newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter, System.Boolean fireEvent)
  System.Void UpdateIndex()
  System.Void UpdateIndex(System.Boolean force)
  System.Void UpdateIndex(System.Boolean force, System.Boolean fireEvent)
  System.Void ChildRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  System.Void ParentRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  System.Void ColumnCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  System.Void ColumnCollectionChangedInternal(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  System.Int32 get_ObjectID()
  System.Void .cctor()
END_CLASS

CLASS: System.Data.DataViewListener
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  private   readonly System.WeakReference            _dvWeak  // 0x10
  private           System.Data.DataTable           _table  // 0x18
  private           System.Data.Index               _index  // 0x20
  private   readonly System.Int32                    _objectID  // 0x28
METHODS:
  System.Void .ctor(System.Data.DataView dv)
  System.Void ChildRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  System.Void ParentRelationCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  System.Void ColumnCollectionChanged(System.Object sender, System.ComponentModel.CollectionChangeEventArgs e)
  System.Void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Data.DataRow row, System.Boolean trackAddRemove)
  System.Void IndexListChanged(System.ComponentModel.ListChangedEventArgs e)
  System.Void RegisterMetaDataEvents(System.Data.DataTable table)
  System.Void UnregisterMetaDataEvents()
  System.Void UnregisterMetaDataEvents(System.Boolean updateListeners)
  System.Void RegisterListChangedEvent(System.Data.Index index)
  System.Void UnregisterListChangedEvent()
  System.Void CleanUp(System.Boolean updateListeners)
  System.Void RegisterListener(System.Data.DataTable table)
END_CLASS

CLASS: System.Data.DataViewManager
TYPE:  class
TOKEN: 0x2000045
EXTENDS: MarshalByValueComponent
FIELDS:
  private           System.Data.DataViewSettingCollection_dataViewSettingsCollection  // 0x20
  private           System.Int32                    _nViews  // 0x28
  private   static  System.NotSupportedException    s_notSupported  // 0x0
METHODS:
  System.Data.DataViewSettingCollection get_DataViewSettings()
  System.Void .cctor()
END_CLASS

CLASS: System.Data.DataViewRowState
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.DataViewRowState    None  // 0x0
  public    static  System.Data.DataViewRowState    Unchanged  // 0x0
  public    static  System.Data.DataViewRowState    Added  // 0x0
  public    static  System.Data.DataViewRowState    Deleted  // 0x0
  public    static  System.Data.DataViewRowState    ModifiedCurrent  // 0x0
  public    static  System.Data.DataViewRowState    ModifiedOriginal  // 0x0
  public    static  System.Data.DataViewRowState    OriginalRows  // 0x0
  public    static  System.Data.DataViewRowState    CurrentRows  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.DataViewSetting
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  private           System.Data.DataViewManager     _dataViewManager  // 0x10
  private           System.Data.DataTable           _table  // 0x18
  private           System.String                   _sort  // 0x20
  private           System.String                   _rowFilter  // 0x28
  private           System.Data.DataViewRowState    _rowStateFilter  // 0x30
  private           System.Boolean                  _applyDefaultSort  // 0x34
METHODS:
  System.Void .ctor()
  System.Boolean get_ApplyDefaultSort()
  System.Void SetDataViewManager(System.Data.DataViewManager dataViewManager)
  System.Void SetDataTable(System.Data.DataTable table)
  System.String get_RowFilter()
  System.Data.DataViewRowState get_RowStateFilter()
  System.String get_Sort()
END_CLASS

CLASS: System.Data.DataViewSettingCollection
TYPE:  class
TOKEN: 0x2000048
FIELDS:
  private   readonly System.Data.DataViewManager     _dataViewManager  // 0x10
  private   readonly System.Collections.Hashtable    _list  // 0x18
METHODS:
  System.Data.DataViewSetting get_Item(System.Data.DataTable table)
  System.Void set_Item(System.Data.DataTable table, System.Data.DataViewSetting value)
  System.Void Remove(System.Data.DataTable table)
END_CLASS

CLASS: System.Data.DefaultValueTypeConverter
TYPE:  class
TOKEN: 0x2000049
EXTENDS: StringConverter
FIELDS:
METHODS:
  System.Void .ctor()
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
  System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
END_CLASS

CLASS: System.Data.Aggregate
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Aggregate           None  // 0x0
  public    static  System.Data.Aggregate           Sum  // 0x0
  public    static  System.Data.Aggregate           Avg  // 0x0
  public    static  System.Data.Aggregate           Min  // 0x0
  public    static  System.Data.Aggregate           Max  // 0x0
  public    static  System.Data.Aggregate           Count  // 0x0
  public    static  System.Data.Aggregate           StDev  // 0x0
  public    static  System.Data.Aggregate           Var  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.AggregateNode
TYPE:  class
TOKEN: 0x200004B
EXTENDS: ExpressionNode
FIELDS:
  private   readonly System.Data.AggregateType       _type  // 0x18
  private   readonly System.Data.Aggregate           _aggregate  // 0x1C
  private   readonly System.Boolean                  _local  // 0x20
  private   readonly System.String                   _relationName  // 0x28
  private   readonly System.String                   _columnName  // 0x30
  private           System.Data.DataTable           _childTable  // 0x38
  private           System.Data.DataColumn          _column  // 0x40
  private           System.Data.DataRelation        _relation  // 0x48
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.Data.FunctionId aggregateType, System.String columnName)
  System.Void .ctor(System.Data.DataTable table, System.Data.FunctionId aggregateType, System.String columnName, System.Boolean local, System.String relationName)
  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  System.Void Bind(System.Data.DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list)
  System.Object Eval()
  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Object Eval(System.Int32[] records)
  System.Boolean IsConstant()
  System.Boolean IsTableConstant()
  System.Boolean HasLocalAggregate()
  System.Boolean HasRemoteAggregate()
  System.Boolean DependsOn(System.Data.DataColumn column)
  System.Data.ExpressionNode Optimize()
END_CLASS

CLASS: System.Data.BinaryNode
TYPE:  class
TOKEN: 0x200004C
EXTENDS: ExpressionNode
FIELDS:
  private           System.Int32                    _op  // 0x18
  private           System.Data.ExpressionNode      _left  // 0x20
  private           System.Data.ExpressionNode      _right  // 0x28
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.Int32 op, System.Data.ExpressionNode left, System.Data.ExpressionNode right)
  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  System.Object Eval()
  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Object Eval(System.Int32[] recordNos)
  System.Boolean IsConstant()
  System.Boolean IsTableConstant()
  System.Boolean HasLocalAggregate()
  System.Boolean HasRemoteAggregate()
  System.Boolean DependsOn(System.Data.DataColumn column)
  System.Data.ExpressionNode Optimize()
  System.Void SetTypeMismatchError(System.Int32 op, System.Type left, System.Type right)
  System.Object Eval(System.Data.ExpressionNode expr, System.Data.DataRow row, System.Data.DataRowVersion version, System.Int32[] recordNos)
  System.Int32 BinaryCompare(System.Object vLeft, System.Object vRight, System.Data.Common.StorageType resultType, System.Int32 op)
  System.Int32 BinaryCompare(System.Object vLeft, System.Object vRight, System.Data.Common.StorageType resultType, System.Int32 op, System.Globalization.CompareInfo comparer)
  System.Object EvalBinaryOp(System.Int32 op, System.Data.ExpressionNode left, System.Data.ExpressionNode right, System.Data.DataRow row, System.Data.DataRowVersion version, System.Int32[] recordNos)
  System.Data.BinaryNode.DataTypePrecedence GetPrecedence(System.Data.Common.StorageType storageType)
  System.Data.Common.StorageType GetPrecedenceType(System.Data.BinaryNode.DataTypePrecedence code)
  System.Boolean IsMixed(System.Data.Common.StorageType left, System.Data.Common.StorageType right)
  System.Boolean IsMixedSql(System.Data.Common.StorageType left, System.Data.Common.StorageType right)
  System.Data.Common.StorageType ResultType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, System.Boolean lc, System.Boolean rc, System.Int32 op)
  System.Data.Common.StorageType ResultSqlType(System.Data.Common.StorageType left, System.Data.Common.StorageType right, System.Boolean lc, System.Boolean rc, System.Int32 op)
  System.Int32 SqlResultType(System.Int32 typeCode)
END_CLASS

CLASS: System.Data.LikeNode
TYPE:  class
TOKEN: 0x200004E
EXTENDS: BinaryNode
FIELDS:
  private           System.Int32                    _kind  // 0x30
  private           System.String                   _pattern  // 0x38
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.Int32 op, System.Data.ExpressionNode left, System.Data.ExpressionNode right)
  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.String AnalyzePattern(System.String pat)
END_CLASS

CLASS: System.Data.ConstNode
TYPE:  class
TOKEN: 0x200004F
EXTENDS: ExpressionNode
FIELDS:
  private   readonly System.Object                   _val  // 0x18
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.Data.ValueType type, System.Object constant)
  System.Void .ctor(System.Data.DataTable table, System.Data.ValueType type, System.Object constant, System.Boolean fParseQuotes)
  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  System.Object Eval()
  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Object Eval(System.Int32[] recordNos)
  System.Boolean IsConstant()
  System.Boolean IsTableConstant()
  System.Boolean HasLocalAggregate()
  System.Boolean HasRemoteAggregate()
  System.Data.ExpressionNode Optimize()
  System.Object SmallestDecimal(System.Object constant)
  System.Object SmallestNumeric(System.Object constant)
END_CLASS

CLASS: System.Data.DataExpression
TYPE:  class
TOKEN: 0x2000050
FIELDS:
  private           System.String                   _originalExpression  // 0x10
  private           System.Boolean                  _parsed  // 0x18
  private           System.Boolean                  _bound  // 0x19
  private           System.Data.ExpressionNode      _expr  // 0x20
  private           System.Data.DataTable           _table  // 0x28
  private   readonly System.Data.Common.StorageType  _storageType  // 0x30
  private   readonly System.Type                     _dataType  // 0x38
  private           System.Data.DataColumn[]        _dependency  // 0x40
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.String expression)
  System.Void .ctor(System.Data.DataTable table, System.String expression, System.Type type)
  System.String get_Expression()
  System.Data.ExpressionNode get_ExpressionNode()
  System.Boolean get_HasValue()
  System.Void Bind(System.Data.DataTable table)
  System.Boolean DependsOn(System.Data.DataColumn column)
  System.Object Evaluate()
  System.Object Evaluate(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Object Evaluate(System.Data.DataRow[] rows)
  System.Object Evaluate(System.Data.DataRow[] rows, System.Data.DataRowVersion version)
  System.Boolean Invoke(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Data.DataColumn[] GetDependency()
  System.Boolean IsTableAggregate()
  System.Boolean IsUnknown(System.Object value)
  System.Boolean HasLocalAggregate()
  System.Boolean HasRemoteAggregate()
  System.Boolean ToBoolean(System.Object value)
END_CLASS

CLASS: System.Data.ExpressionNode
TYPE:  class
TOKEN: 0x2000051
FIELDS:
  private           System.Data.DataTable           _table  // 0x10
METHODS:
  System.Void .ctor(System.Data.DataTable table)
  System.IFormatProvider get_FormatProvider()
  System.Boolean get_IsSqlColumn()
  System.Data.DataTable get_table()
  System.Void BindTable(System.Data.DataTable table)
  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  System.Object Eval()
  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Object Eval(System.Int32[] recordNos)
  System.Boolean IsConstant()
  System.Boolean IsTableConstant()
  System.Boolean HasLocalAggregate()
  System.Boolean HasRemoteAggregate()
  System.Data.ExpressionNode Optimize()
  System.Boolean DependsOn(System.Data.DataColumn column)
  System.Boolean IsInteger(System.Data.Common.StorageType type)
  System.Boolean IsIntegerSql(System.Data.Common.StorageType type)
  System.Boolean IsSigned(System.Data.Common.StorageType type)
  System.Boolean IsSignedSql(System.Data.Common.StorageType type)
  System.Boolean IsUnsigned(System.Data.Common.StorageType type)
  System.Boolean IsUnsignedSql(System.Data.Common.StorageType type)
  System.Boolean IsNumeric(System.Data.Common.StorageType type)
  System.Boolean IsNumericSql(System.Data.Common.StorageType type)
  System.Boolean IsFloat(System.Data.Common.StorageType type)
  System.Boolean IsFloatSql(System.Data.Common.StorageType type)
END_CLASS

CLASS: System.Data.ValueType
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.ValueType           Unknown  // 0x0
  public    static  System.Data.ValueType           Null  // 0x0
  public    static  System.Data.ValueType           Bool  // 0x0
  public    static  System.Data.ValueType           Numeric  // 0x0
  public    static  System.Data.ValueType           Str  // 0x0
  public    static  System.Data.ValueType           Float  // 0x0
  public    static  System.Data.ValueType           Decimal  // 0x0
  public    static  System.Data.ValueType           Object  // 0x0
  public    static  System.Data.ValueType           Date  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.Nodes
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Nodes               Noop  // 0x0
  public    static  System.Data.Nodes               Unop  // 0x0
  public    static  System.Data.Nodes               UnopSpec  // 0x0
  public    static  System.Data.Nodes               Binop  // 0x0
  public    static  System.Data.Nodes               BinopSpec  // 0x0
  public    static  System.Data.Nodes               Zop  // 0x0
  public    static  System.Data.Nodes               Call  // 0x0
  public    static  System.Data.Nodes               Const  // 0x0
  public    static  System.Data.Nodes               Name  // 0x0
  public    static  System.Data.Nodes               Paren  // 0x0
  public    static  System.Data.Nodes               Conv  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.ExpressionParser
TYPE:  class
TOKEN: 0x2000054
FIELDS:
  private   static readonly System.Data.ExpressionParser.ReservedWords[]s_reservedwords  // 0x0
  private           System.Char                     _escape  // 0x10
  private           System.Char                     _decimalSeparator  // 0x12
  private           System.Char                     _listSeparator  // 0x14
  private           System.Char                     _exponentL  // 0x16
  private           System.Char                     _exponentU  // 0x18
  private           System.Char[]                   _text  // 0x20
  private           System.Int32                    _pos  // 0x28
  private           System.Int32                    _start  // 0x2C
  private           System.Data.Tokens              _token  // 0x30
  private           System.Int32                    _op  // 0x34
  private           System.Data.OperatorInfo[]      _ops  // 0x38
  private           System.Int32                    _topOperator  // 0x40
  private           System.Int32                    _topNode  // 0x44
  private   readonly System.Data.DataTable           _table  // 0x48
  private           System.Data.ExpressionNode[]    _nodeStack  // 0x50
  private           System.Int32                    _prevOperand  // 0x58
  private           System.Data.ExpressionNode      _expression  // 0x60
METHODS:
  System.Void .ctor(System.Data.DataTable table)
  System.Void LoadExpression(System.String data)
  System.Void StartScan()
  System.Data.ExpressionNode Parse()
  System.Data.ExpressionNode ParseAggregateArgument(System.Data.FunctionId aggregate)
  System.Data.ExpressionNode NodePop()
  System.Data.ExpressionNode NodePeek()
  System.Void NodePush(System.Data.ExpressionNode node)
  System.Void BuildExpression(System.Int32 pri)
  System.Void CheckToken(System.Data.Tokens token)
  System.Data.Tokens Scan()
  System.Void ScanNumeric()
  System.Void ScanName()
  System.Void ScanName(System.Char chEnd, System.Char esc, System.String charsToEscape)
  System.Void ScanDate()
  System.Void ScanBinaryConstant()
  System.Void ScanReserved()
  System.Void ScanString(System.Char escape)
  System.Void ScanToken(System.Data.Tokens token)
  System.Void ScanWhite()
  System.Boolean IsWhiteSpace(System.Char ch)
  System.Boolean IsAlphaNumeric(System.Char ch)
  System.Boolean IsDigit(System.Char ch)
  System.Boolean IsAlpha(System.Char ch)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.Tokens
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Tokens              None  // 0x0
  public    static  System.Data.Tokens              Name  // 0x0
  public    static  System.Data.Tokens              Numeric  // 0x0
  public    static  System.Data.Tokens              Decimal  // 0x0
  public    static  System.Data.Tokens              Float  // 0x0
  public    static  System.Data.Tokens              BinaryConst  // 0x0
  public    static  System.Data.Tokens              StringConst  // 0x0
  public    static  System.Data.Tokens              Date  // 0x0
  public    static  System.Data.Tokens              ListSeparator  // 0x0
  public    static  System.Data.Tokens              LeftParen  // 0x0
  public    static  System.Data.Tokens              RightParen  // 0x0
  public    static  System.Data.Tokens              ZeroOp  // 0x0
  public    static  System.Data.Tokens              UnaryOp  // 0x0
  public    static  System.Data.Tokens              BinaryOp  // 0x0
  public    static  System.Data.Tokens              Child  // 0x0
  public    static  System.Data.Tokens              Parent  // 0x0
  public    static  System.Data.Tokens              Dot  // 0x0
  public    static  System.Data.Tokens              Unknown  // 0x0
  public    static  System.Data.Tokens              EOS  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.OperatorInfo
TYPE:  class
TOKEN: 0x2000057
FIELDS:
  private           System.Data.Nodes               _type  // 0x10
  private           System.Int32                    _op  // 0x14
  private           System.Int32                    _priority  // 0x18
METHODS:
  System.Void .ctor(System.Data.Nodes type, System.Int32 op, System.Int32 pri)
END_CLASS

CLASS: System.Data.InvalidExpressionException
TYPE:  class
TOKEN: 0x2000058
EXTENDS: DataException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.EvaluateException
TYPE:  class
TOKEN: 0x2000059
EXTENDS: InvalidExpressionException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.SyntaxErrorException
TYPE:  class
TOKEN: 0x200005A
EXTENDS: InvalidExpressionException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String s)
END_CLASS

CLASS: System.Data.ExprException
TYPE:  class
TOKEN: 0x200005B
FIELDS:
METHODS:
  System.OverflowException _Overflow(System.String error)
  System.Data.InvalidExpressionException _Expr(System.String error)
  System.Data.SyntaxErrorException _Syntax(System.String error)
  System.Data.EvaluateException _Eval(System.String error)
  System.Data.EvaluateException _Eval(System.String error, System.Exception innerException)
  System.Exception InvokeArgument()
  System.Exception NYI(System.String moreinfo)
  System.Exception MissingOperand(System.Data.OperatorInfo before)
  System.Exception MissingOperator(System.String token)
  System.Exception TypeMismatch(System.String expr)
  System.Exception FunctionArgumentOutOfRange(System.String arg, System.String func)
  System.Exception ExpressionTooComplex()
  System.Exception UnboundName(System.String name)
  System.Exception InvalidString(System.String str)
  System.Exception UndefinedFunction(System.String name)
  System.Exception SyntaxError()
  System.Exception FunctionArgumentCount(System.String name)
  System.Exception MissingRightParen()
  System.Exception UnknownToken(System.String token, System.Int32 position)
  System.Exception UnknownToken(System.Data.Tokens tokExpected, System.Data.Tokens tokCurr, System.Int32 position)
  System.Exception DatatypeConvertion(System.Type type1, System.Type type2)
  System.Exception DatavalueConvertion(System.Object value, System.Type type, System.Exception innerException)
  System.Exception InvalidName(System.String name)
  System.Exception InvalidDate(System.String date)
  System.Exception NonConstantArgument()
  System.Exception InvalidPattern(System.String pat)
  System.Exception InWithoutParentheses()
  System.Exception InWithoutList()
  System.Exception InvalidIsSyntax()
  System.Exception Overflow(System.Type type)
  System.Exception ArgumentType(System.String function, System.Int32 arg, System.Type type)
  System.Exception ArgumentTypeInteger(System.String function, System.Int32 arg)
  System.Exception TypeMismatchInBinop(System.Int32 op, System.Type type1, System.Type type2)
  System.Exception AmbiguousBinop(System.Int32 op, System.Type type1, System.Type type2)
  System.Exception UnsupportedOperator(System.Int32 op)
  System.Exception InvalidNameBracketing(System.String name)
  System.Exception MissingOperandBefore(System.String op)
  System.Exception TooManyRightParentheses()
  System.Exception UnresolvedRelation(System.String name, System.String expr)
  System.Data.EvaluateException BindFailure(System.String relationName)
  System.Exception AggregateArgument()
  System.Exception AggregateUnbound(System.String expr)
  System.Exception EvalNoContext()
  System.Exception ExpressionUnbound(System.String expr)
  System.Exception ComputeNotAggregate(System.String expr)
  System.Exception FilterConvertion(System.String expr)
  System.Exception LookupArgument()
  System.Exception InvalidType(System.String typeName)
  System.Exception InvalidHoursArgument()
  System.Exception InvalidMinutesArgument()
  System.Exception InvalidTimeZoneRange()
  System.Exception MismatchKindandTimeSpan()
  System.Exception UnsupportedDataType(System.Type type)
END_CLASS

CLASS: System.Data.FunctionNode
TYPE:  class
TOKEN: 0x200005C
EXTENDS: ExpressionNode
FIELDS:
  private   readonly System.String                   _name  // 0x18
  private   readonly System.Int32                    _info  // 0x20
  private           System.Int32                    _argumentCount  // 0x24
  private           System.Data.ExpressionNode[]    _arguments  // 0x28
  private   static readonly System.Data.Function[]          s_funcs  // 0x0
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.String name)
  System.Void AddArgument(System.Data.ExpressionNode argument)
  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  System.Object Eval()
  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Object Eval(System.Int32[] recordNos)
  System.Boolean IsConstant()
  System.Boolean IsTableConstant()
  System.Boolean HasLocalAggregate()
  System.Boolean HasRemoteAggregate()
  System.Boolean DependsOn(System.Data.DataColumn column)
  System.Data.ExpressionNode Optimize()
  System.Type GetDataType(System.Data.ExpressionNode node)
  System.Object EvalFunction(System.Data.FunctionId id, System.Object[] argumentValues, System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Data.FunctionId get_Aggregate()
  System.Boolean get_IsAggregate()
  System.Void Check()
  System.Void .cctor()
END_CLASS

CLASS: System.Data.FunctionId
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.FunctionId          none  // 0x0
  public    static  System.Data.FunctionId          Ascii  // 0x0
  public    static  System.Data.FunctionId          Char  // 0x0
  public    static  System.Data.FunctionId          Charindex  // 0x0
  public    static  System.Data.FunctionId          Difference  // 0x0
  public    static  System.Data.FunctionId          Len  // 0x0
  public    static  System.Data.FunctionId          Lower  // 0x0
  public    static  System.Data.FunctionId          LTrim  // 0x0
  public    static  System.Data.FunctionId          Patindex  // 0x0
  public    static  System.Data.FunctionId          Replicate  // 0x0
  public    static  System.Data.FunctionId          Reverse  // 0x0
  public    static  System.Data.FunctionId          Right  // 0x0
  public    static  System.Data.FunctionId          RTrim  // 0x0
  public    static  System.Data.FunctionId          Soundex  // 0x0
  public    static  System.Data.FunctionId          Space  // 0x0
  public    static  System.Data.FunctionId          Str  // 0x0
  public    static  System.Data.FunctionId          Stuff  // 0x0
  public    static  System.Data.FunctionId          Substring  // 0x0
  public    static  System.Data.FunctionId          Upper  // 0x0
  public    static  System.Data.FunctionId          IsNull  // 0x0
  public    static  System.Data.FunctionId          Iif  // 0x0
  public    static  System.Data.FunctionId          Convert  // 0x0
  public    static  System.Data.FunctionId          cInt  // 0x0
  public    static  System.Data.FunctionId          cBool  // 0x0
  public    static  System.Data.FunctionId          cDate  // 0x0
  public    static  System.Data.FunctionId          cDbl  // 0x0
  public    static  System.Data.FunctionId          cStr  // 0x0
  public    static  System.Data.FunctionId          Abs  // 0x0
  public    static  System.Data.FunctionId          Acos  // 0x0
  public    static  System.Data.FunctionId          In  // 0x0
  public    static  System.Data.FunctionId          Trim  // 0x0
  public    static  System.Data.FunctionId          Sum  // 0x0
  public    static  System.Data.FunctionId          Avg  // 0x0
  public    static  System.Data.FunctionId          Min  // 0x0
  public    static  System.Data.FunctionId          Max  // 0x0
  public    static  System.Data.FunctionId          Count  // 0x0
  public    static  System.Data.FunctionId          StDev  // 0x0
  public    static  System.Data.FunctionId          Var  // 0x0
  public    static  System.Data.FunctionId          DateTimeOffset  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.Function
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  private   readonly System.String                   _name  // 0x10
  private   readonly System.Data.FunctionId          _id  // 0x18
  private   readonly System.Type                     _result  // 0x20
  private   readonly System.Boolean                  _isValidateArguments  // 0x28
  private   readonly System.Boolean                  _isVariantArgumentList  // 0x29
  private   readonly System.Int32                    _argumentCount  // 0x2C
  private   readonly System.Type[]                   _parameters  // 0x30
  private   static  System.String[]                 s_functionName  // 0x0
METHODS:
  System.Void .ctor(System.String name, System.Data.FunctionId id, System.Type result, System.Boolean IsValidateArguments, System.Boolean IsVariantArgumentList, System.Int32 argumentCount, System.Type a1, System.Type a2, System.Type a3)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.IFilter
TYPE:  interface
TOKEN: 0x200005F
FIELDS:
METHODS:
  System.Boolean Invoke(System.Data.DataRow row, System.Data.DataRowVersion version)
END_CLASS

CLASS: System.Data.LookupNode
TYPE:  class
TOKEN: 0x2000060
EXTENDS: ExpressionNode
FIELDS:
  private   readonly System.String                   _relationName  // 0x18
  private   readonly System.String                   _columnName  // 0x20
  private           System.Data.DataColumn          _column  // 0x28
  private           System.Data.DataRelation        _relation  // 0x30
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.String columnName, System.String relationName)
  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  System.Object Eval()
  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Object Eval(System.Int32[] recordNos)
  System.Boolean IsConstant()
  System.Boolean IsTableConstant()
  System.Boolean HasLocalAggregate()
  System.Boolean HasRemoteAggregate()
  System.Boolean DependsOn(System.Data.DataColumn column)
  System.Data.ExpressionNode Optimize()
END_CLASS

CLASS: System.Data.NameNode
TYPE:  class
TOKEN: 0x2000061
EXTENDS: ExpressionNode
FIELDS:
  private           System.String                   _name  // 0x18
  private           System.Boolean                  _found  // 0x20
  private           System.Data.DataColumn          _column  // 0x28
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.Char[] text, System.Int32 start, System.Int32 pos)
  System.Void .ctor(System.Data.DataTable table, System.String name)
  System.Boolean get_IsSqlColumn()
  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  System.Object Eval()
  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Object Eval(System.Int32[] records)
  System.Boolean IsConstant()
  System.Boolean IsTableConstant()
  System.Boolean HasLocalAggregate()
  System.Boolean HasRemoteAggregate()
  System.Boolean DependsOn(System.Data.DataColumn column)
  System.Data.ExpressionNode Optimize()
  System.String ParseName(System.Char[] text, System.Int32 start, System.Int32 pos)
END_CLASS

CLASS: System.Data.Operators
TYPE:  class
TOKEN: 0x2000062
FIELDS:
  private   static readonly System.Int32[]                  s_priority  // 0x0
  private   static readonly System.String[]                 s_looks  // 0x8
METHODS:
  System.Boolean IsArithmetical(System.Int32 op)
  System.Boolean IsLogical(System.Int32 op)
  System.Boolean IsRelational(System.Int32 op)
  System.Int32 Priority(System.Int32 op)
  System.String ToString(System.Int32 op)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.UnaryNode
TYPE:  class
TOKEN: 0x2000063
EXTENDS: ExpressionNode
FIELDS:
  private   readonly System.Int32                    _op  // 0x18
  private           System.Data.ExpressionNode      _right  // 0x20
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.Int32 op, System.Data.ExpressionNode right)
  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  System.Object Eval()
  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Object Eval(System.Int32[] recordNos)
  System.Object EvalUnaryOp(System.Int32 op, System.Object vl)
  System.Boolean IsConstant()
  System.Boolean IsTableConstant()
  System.Boolean HasLocalAggregate()
  System.Boolean HasRemoteAggregate()
  System.Boolean DependsOn(System.Data.DataColumn column)
  System.Data.ExpressionNode Optimize()
END_CLASS

CLASS: System.Data.ZeroOpNode
TYPE:  class
TOKEN: 0x2000064
EXTENDS: ExpressionNode
FIELDS:
  private   readonly System.Int32                    _op  // 0x18
METHODS:
  System.Void .ctor(System.Int32 op)
  System.Void Bind(System.Data.DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list)
  System.Object Eval()
  System.Object Eval(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Object Eval(System.Int32[] recordNos)
  System.Boolean IsConstant()
  System.Boolean IsTableConstant()
  System.Boolean HasLocalAggregate()
  System.Boolean HasRemoteAggregate()
  System.Data.ExpressionNode Optimize()
END_CLASS

CLASS: System.Data.ForeignKeyConstraint
TYPE:  class
TOKEN: 0x2000065
EXTENDS: Constraint
FIELDS:
  private           System.Data.Rule                _deleteRule  // 0x38
  private           System.Data.Rule                _updateRule  // 0x3C
  private           System.Data.AcceptRejectRule    _acceptRejectRule  // 0x40
  private           System.Data.DataKey             _childKey  // 0x48
  private           System.Data.DataKey             _parentKey  // 0x50
  private           System.String                   _constraintName  // 0x58
  private           System.String[]                 _parentColumnNames  // 0x60
  private           System.String[]                 _childColumnNames  // 0x68
  private           System.String                   _parentTableName  // 0x70
METHODS:
  System.Void .ctor(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns)
  System.Void .ctor(System.String constraintName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns)
  System.Void .ctor(System.String constraintName, System.String parentTableName, System.String[] parentColumnNames, System.String[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule)
  System.Data.DataKey get_ChildKey()
  System.Data.DataColumn[] get_Columns()
  System.Data.DataTable get_Table()
  System.String[] get_ParentColumnNames()
  System.String[] get_ChildColumnNames()
  System.Void CheckCanAddToCollection(System.Data.ConstraintCollection constraints)
  System.Boolean CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, System.Boolean fThrowException)
  System.Boolean IsKeyNull(System.Object[] values)
  System.Boolean IsConstraintViolated()
  System.Boolean CanEnableConstraint()
  System.Void CascadeCommit(System.Data.DataRow row)
  System.Void CascadeDelete(System.Data.DataRow row)
  System.Void CascadeRollback(System.Data.DataRow row)
  System.Void CascadeUpdate(System.Data.DataRow row)
  System.Void CheckCanClearParentTable(System.Data.DataTable table)
  System.Void CheckCanRemoveParentRow(System.Data.DataRow row)
  System.Void CheckCascade(System.Data.DataRow row, System.Data.DataRowAction action)
  System.Void CheckConstraint(System.Data.DataRow childRow, System.Data.DataRowAction action)
  System.Void NonVirtualCheckState()
  System.Void CheckState()
  System.Data.AcceptRejectRule get_AcceptRejectRule()
  System.Void set_AcceptRejectRule(System.Data.AcceptRejectRule value)
  System.Boolean ContainsColumn(System.Data.DataColumn column)
  System.Data.Constraint Clone(System.Data.DataSet destination)
  System.Data.Constraint Clone(System.Data.DataSet destination, System.Boolean ignorNSforTableLookup)
  System.Data.ForeignKeyConstraint Clone(System.Data.DataTable destination)
  System.Void Create(System.String relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns)
  System.Data.Rule get_DeleteRule()
  System.Void set_DeleteRule(System.Data.Rule value)
  System.Boolean Equals(System.Object key)
  System.Int32 GetHashCode()
  System.Data.DataColumn[] get_RelatedColumns()
  System.Data.DataColumn[] get_RelatedColumnsReference()
  System.Data.DataKey get_ParentKey()
  System.Data.DataRelation FindParentRelation()
  System.Data.DataTable get_RelatedTable()
  System.Data.Rule get_UpdateRule()
  System.Void set_UpdateRule(System.Data.Rule value)
END_CLASS

CLASS: System.Data.MappingType
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.MappingType         Element  // 0x0
  public    static  System.Data.MappingType         Attribute  // 0x0
  public    static  System.Data.MappingType         SimpleContent  // 0x0
  public    static  System.Data.MappingType         Hidden  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.MergeFailedEventArgs
TYPE:  class
TOKEN: 0x2000067
EXTENDS: EventArgs
FIELDS:
  private   readonly System.Data.DataTable           <Table>k__BackingField  // 0x10
  private   readonly System.String                   <Conflict>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.String conflict)
  System.String get_Conflict()
END_CLASS

CLASS: System.Data.MergeFailedEventHandler
TYPE:  class
TOKEN: 0x2000068
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Data.MergeFailedEventArgs e)
END_CLASS

CLASS: System.Data.Merger
TYPE:  class
TOKEN: 0x2000069
FIELDS:
  private           System.Data.DataSet             _dataSet  // 0x10
  private           System.Data.DataTable           _dataTable  // 0x18
  private           System.Boolean                  _preserveChanges  // 0x20
  private           System.Data.MissingSchemaAction _missingSchemaAction  // 0x24
  private           System.Boolean                  _isStandAlonetable  // 0x28
  private           System.Boolean                  _IgnoreNSforTableLookup  // 0x29
METHODS:
  System.Void .ctor(System.Data.DataSet dataSet, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction)
  System.Void .ctor(System.Data.DataTable dataTable, System.Boolean preserveChanges, System.Data.MissingSchemaAction missingSchemaAction)
  System.Void MergeDataSet(System.Data.DataSet source)
  System.Void MergeTable(System.Data.DataTable src)
  System.Void MergeTable(System.Data.DataTable src, System.Data.DataTable dst)
  System.Data.DataTable MergeSchema(System.Data.DataTable table)
  System.Void MergeTableData(System.Data.DataTable src)
  System.Void MergeConstraints(System.Data.DataSet source)
  System.Void MergeConstraints(System.Data.DataTable table)
  System.Void MergeRelation(System.Data.DataRelation relation)
  System.Void MergeExtendedProperties(System.Data.PropertyCollection src, System.Data.PropertyCollection dst)
  System.Data.DataKey GetSrcKey(System.Data.DataTable src, System.Data.DataTable dst)
END_CLASS

CLASS: System.Data.MissingSchemaAction
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.MissingSchemaAction Add  // 0x0
  public    static  System.Data.MissingSchemaAction Ignore  // 0x0
  public    static  System.Data.MissingSchemaAction Error  // 0x0
  public    static  System.Data.MissingSchemaAction AddWithKey  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.PrimaryKeyTypeConverter
TYPE:  class
TOKEN: 0x200006B
EXTENDS: ReferenceConverter
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
END_CLASS

CLASS: System.Data.PropertyCollection
TYPE:  class
TOKEN: 0x200006C
EXTENDS: Hashtable
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Object Clone()
END_CLASS

CLASS: System.Data.Range
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  private           System.Int32                    _min  // 0x10
  private           System.Int32                    _max  // 0x14
  private           System.Boolean                  _isNotNull  // 0x18
METHODS:
  System.Void .ctor(System.Int32 min, System.Int32 max)
  System.Int32 get_Count()
  System.Boolean get_IsNull()
  System.Int32 get_Min()
  System.Void CheckNull()
END_CLASS

CLASS: System.Data.RBTreeError
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.RBTreeError         InvalidPageSize  // 0x0
  public    static  System.Data.RBTreeError         PagePositionInSlotInUse  // 0x0
  public    static  System.Data.RBTreeError         NoFreeSlots  // 0x0
  public    static  System.Data.RBTreeError         InvalidStateinInsert  // 0x0
  public    static  System.Data.RBTreeError         InvalidNextSizeInDelete  // 0x0
  public    static  System.Data.RBTreeError         InvalidStateinDelete  // 0x0
  public    static  System.Data.RBTreeError         InvalidNodeSizeinDelete  // 0x0
  public    static  System.Data.RBTreeError         InvalidStateinEndDelete  // 0x0
  public    static  System.Data.RBTreeError         CannotRotateInvalidsuccessorNodeinDelete  // 0x0
  public    static  System.Data.RBTreeError         IndexOutOFRangeinGetNodeByIndex  // 0x0
  public    static  System.Data.RBTreeError         RBDeleteFixup  // 0x0
  public    static  System.Data.RBTreeError         UnsupportedAccessMethod1  // 0x0
  public    static  System.Data.RBTreeError         UnsupportedAccessMethod2  // 0x0
  public    static  System.Data.RBTreeError         UnsupportedAccessMethodInNonNillRootSubtree  // 0x0
  public    static  System.Data.RBTreeError         AttachedNodeWithZerorbTreeNodeId  // 0x0
  public    static  System.Data.RBTreeError         CompareNodeInDataRowTree  // 0x0
  public    static  System.Data.RBTreeError         CompareSateliteTreeNodeInDataRowTree  // 0x0
  public    static  System.Data.RBTreeError         NestedSatelliteTreeEnumerator  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.TreeAccessMethod
TYPE:  struct
TOKEN: 0x200006F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.TreeAccessMethod    KEY_SEARCH_AND_INDEX  // 0x0
  public    static  System.Data.TreeAccessMethod    INDEX_ONLY  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.RBTree`1
TYPE:  class
TOKEN: 0x2000070
FIELDS:
  private           System.Data.RBTree.TreePage<K>[]_pageTable  // 0x0
  private           System.Int32[]                  _pageTableMap  // 0x0
  private           System.Int32                    _inUsePageCount  // 0x0
  private           System.Int32                    _nextFreePageLine  // 0x0
  public            System.Int32                    root  // 0x0
  private           System.Int32                    _version  // 0x0
  private           System.Int32                    _inUseNodeCount  // 0x0
  private           System.Int32                    _inUseSatelliteTreeCount  // 0x0
  private   readonly System.Data.TreeAccessMethod    _accessMethod  // 0x0
METHODS:
  System.Int32 CompareNode(K record1, K record2)
  System.Int32 CompareSateliteTreeNode(K record1, K record2)
  System.Void .ctor(System.Data.TreeAccessMethod accessMethod)
  System.Void InitTree()
  System.Void FreePage(System.Data.RBTree.TreePage<K> page)
  System.Data.RBTree.TreePage<K> AllocPage(System.Int32 size)
  System.Void MarkPageFull(System.Data.RBTree.TreePage<K> page)
  System.Void MarkPageFree(System.Data.RBTree.TreePage<K> page)
  System.Int32 GetIntValueFromBitMap(System.UInt32 bitMap)
  System.Void FreeNode(System.Int32 nodeId)
  System.Int32 GetIndexOfPageWithFreeSlot(System.Boolean allocatedPage)
  System.Int32 get_Count()
  System.Boolean get_HasDuplicates()
  System.Int32 GetNewNode(K key)
  System.Int32 Successor(System.Int32 x_id)
  System.Boolean Successor(System.Int32& nodeId, System.Int32& mainTreeNodeId)
  System.Int32 Minimum(System.Int32 x_id)
  System.Int32 LeftRotate(System.Int32 root_id, System.Int32 x_id, System.Int32 mainTreeNode)
  System.Int32 RightRotate(System.Int32 root_id, System.Int32 x_id, System.Int32 mainTreeNode)
  System.Int32 RBInsert(System.Int32 root_id, System.Int32 x_id, System.Int32 mainTreeNodeID, System.Int32 position, System.Boolean append)
  System.Void UpdateNodeKey(K currentKey, K newKey)
  K DeleteByIndex(System.Int32 i)
  System.Int32 RBDelete(System.Int32 z_id)
  System.Int32 RBDeleteX(System.Int32 root_id, System.Int32 z_id, System.Int32 mainTreeNodeID)
  System.Int32 RBDeleteFixup(System.Int32 root_id, System.Int32 x_id, System.Int32 px_id, System.Int32 mainTreeNodeID)
  System.Int32 SearchSubTree(System.Int32 root_id, K key)
  K get_Item(System.Int32 index)
  System.Data.RBTree.NodePath<K> GetNodeByKey(K key)
  System.Int32 GetIndexByKey(K key)
  System.Int32 GetIndexByNode(System.Int32 node)
  System.Int32 GetIndexByNodePath(System.Data.RBTree.NodePath<K> path)
  System.Int32 ComputeIndexByNode(System.Int32 nodeId)
  System.Int32 ComputeIndexWithSatelliteByNode(System.Int32 nodeId)
  System.Data.RBTree.NodePath<K> GetNodeByIndex(System.Int32 userIndex)
  System.Int32 ComputeNodeByIndex(System.Int32 index, System.Int32& satelliteRootId)
  System.Int32 ComputeNodeByIndex(System.Int32 x_id, System.Int32 index)
  System.Int32 Insert(K item)
  System.Int32 Add(K item)
  System.Collections.IEnumerator GetEnumerator()
  System.Int32 IndexOf(System.Int32 nodeId, K item)
  System.Int32 Insert(System.Int32 position, K item)
  System.Int32 InsertAt(System.Int32 position, K item, System.Boolean append)
  System.Void RemoveAt(System.Int32 position)
  System.Void Clear()
  System.Void CopyTo(System.Array array, System.Int32 index)
  System.Void CopyTo(K[] array, System.Int32 index)
  System.Void SetRight(System.Int32 nodeId, System.Int32 rightNodeId)
  System.Void SetLeft(System.Int32 nodeId, System.Int32 leftNodeId)
  System.Void SetParent(System.Int32 nodeId, System.Int32 parentNodeId)
  System.Void SetColor(System.Int32 nodeId, System.Data.RBTree.NodeColor<K> color)
  System.Void SetKey(System.Int32 nodeId, K key)
  System.Void SetNext(System.Int32 nodeId, System.Int32 nextNodeId)
  System.Void SetSubTreeSize(System.Int32 nodeId, System.Int32 size)
  System.Void IncreaseSize(System.Int32 nodeId)
  System.Void RecomputeSize(System.Int32 nodeId)
  System.Void DecreaseSize(System.Int32 nodeId)
  System.Int32 Right(System.Int32 nodeId)
  System.Int32 Left(System.Int32 nodeId)
  System.Int32 Parent(System.Int32 nodeId)
  System.Data.RBTree.NodeColor<K> color(System.Int32 nodeId)
  System.Int32 Next(System.Int32 nodeId)
  System.Int32 SubTreeSize(System.Int32 nodeId)
  K Key(System.Int32 nodeId)
END_CLASS

CLASS: System.Data.RecordManager
TYPE:  class
TOKEN: 0x2000076
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private           System.Int32                    _lastFreeRecord  // 0x18
  private           System.Int32                    _minimumCapacity  // 0x1C
  private           System.Int32                    _recordCapacity  // 0x20
  private   readonly System.Collections.Generic.List<System.Int32>_freeRecordList  // 0x28
  private           System.Data.DataRow[]           _rows  // 0x30
METHODS:
  System.Void .ctor(System.Data.DataTable table)
  System.Void GrowRecordCapacity()
  System.Int32 get_LastFreeRecord()
  System.Int32 get_MinimumCapacity()
  System.Void set_MinimumCapacity(System.Int32 value)
  System.Int32 get_RecordCapacity()
  System.Void set_RecordCapacity(System.Int32 value)
  System.Int32 NewCapacity(System.Int32 capacity)
  System.Int32 NormalizedMinimumCapacity(System.Int32 capacity)
  System.Int32 NewRecordBase()
  System.Void FreeRecord(System.Int32& record)
  System.Void Clear(System.Boolean clearAll)
  System.Data.DataRow get_Item(System.Int32 record)
  System.Void set_Item(System.Int32 record, System.Data.DataRow value)
  System.Int32 ImportRecord(System.Data.DataTable src, System.Int32 record)
  System.Int32 CopyRecord(System.Data.DataTable src, System.Int32 record, System.Int32 copy)
  System.Void SetRowCache(System.Data.DataRow[] newRows)
END_CLASS

CLASS: System.Data.RelatedView
TYPE:  class
TOKEN: 0x2000077
EXTENDS: DataView
FIELDS:
  private   readonly System.Nullable<System.Data.DataKey>_parentKey  // 0xB0
  private   readonly System.Data.DataKey             _childKey  // 0xC0
  private   readonly System.Data.DataRowView         _parentRowView  // 0xC8
  private   readonly System.Object[]                 _filterValues  // 0xD0
METHODS:
  System.Void .ctor(System.Data.DataColumn[] columns, System.Object[] values)
  System.Void .ctor(System.Data.DataRowView parentRowView, System.Data.DataKey parentKey, System.Data.DataColumn[] childKeyColumns)
  System.Object[] GetParentValues()
  System.Boolean Invoke(System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Data.IFilter GetFilter()
  System.Data.DataRowView AddNew()
  System.Void SetIndex(System.String newSort, System.Data.DataViewRowState newRowStates, System.Data.IFilter newRowFilter)
END_CLASS

CLASS: System.Data.RelationshipConverter
TYPE:  class
TOKEN: 0x2000078
EXTENDS: ExpandableObjectConverter
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
  System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
END_CLASS

CLASS: System.Data.Rule
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Rule                None  // 0x0
  public    static  System.Data.Rule                Cascade  // 0x0
  public    static  System.Data.Rule                SetNull  // 0x0
  public    static  System.Data.Rule                SetDefault  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.SchemaSerializationMode
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SchemaSerializationModeIncludeSchema  // 0x0
  public    static  System.Data.SchemaSerializationModeExcludeSchema  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.Select
TYPE:  class
TOKEN: 0x200007B
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Data.IndexField[]        _indexFields  // 0x18
  private           System.Data.DataViewRowState    _recordStates  // 0x20
  private           System.Data.DataExpression      _rowFilter  // 0x28
  private           System.Data.ExpressionNode      _expression  // 0x30
  private           System.Data.Index               _index  // 0x38
  private           System.Int32[]                  _records  // 0x40
  private           System.Int32                    _recordCount  // 0x48
  private           System.Data.ExpressionNode      _linearExpression  // 0x50
  private           System.Boolean                  _candidatesForBinarySearch  // 0x58
  private           System.Data.Select.ColumnInfo[] _candidateColumns  // 0x60
  private           System.Int32                    _nCandidates  // 0x68
  private           System.Int32                    _matchedCandidates  // 0x6C
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.String filterExpression, System.String sort, System.Data.DataViewRowState recordStates)
  System.Boolean IsSupportedOperator(System.Int32 op)
  System.Void AnalyzeExpression(System.Data.BinaryNode expr)
  System.Boolean CompareSortIndexDesc(System.Data.IndexField[] fields)
  System.Boolean FindSortIndex()
  System.Int32 CompareClosestCandidateIndexDesc(System.Data.IndexField[] fields)
  System.Boolean FindClosestCandidateIndex()
  System.Void InitCandidateColumns()
  System.Void CreateIndex()
  System.Boolean IsOperatorIn(System.Data.ExpressionNode enode)
  System.Void BuildLinearExpression()
  System.Data.DataRow[] SelectRows()
  System.Data.DataRow[] GetRows()
  System.Boolean AcceptRecord(System.Int32 record)
  System.Int32 Eval(System.Data.BinaryNode expr, System.Data.DataRow row, System.Data.DataRowVersion version)
  System.Int32 Evaluate(System.Int32 record)
  System.Int32 FindFirstMatchingRecord()
  System.Int32 FindLastMatchingRecord(System.Int32 lo)
  System.Data.Range GetBinaryFilteredRecords()
  System.Int32[] GetLinearFilteredRecords(System.Data.Range range)
  System.Data.DataRow[] GetLinearFilteredRows(System.Data.Range range)
  System.Int32 CompareRecords(System.Int32 record1, System.Int32 record2)
  System.Void Sort(System.Int32 left, System.Int32 right)
END_CLASS

CLASS: System.Data.IndexField
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  public    readonly System.Data.DataColumn          Column  // 0x10
  public    readonly System.Boolean                  IsDescending  // 0x18
METHODS:
  System.Void .ctor(System.Data.DataColumn column, System.Boolean isDescending)
  System.Boolean op_Equality(System.Data.IndexField if1, System.Data.IndexField if2)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: System.Data.Index
TYPE:  class
TOKEN: 0x200007E
FIELDS:
  private   readonly System.Data.DataTable           _table  // 0x10
  private   readonly System.Data.IndexField[]        _indexFields  // 0x18
  private   readonly System.Comparison<System.Data.DataRow>_comparison  // 0x20
  private   readonly System.Data.DataViewRowState    _recordStates  // 0x28
  private           System.WeakReference            _rowFilter  // 0x30
  private           System.Data.Index.IndexTree     _records  // 0x38
  private           System.Int32                    _recordCount  // 0x40
  private           System.Int32                    _refCount  // 0x44
  private           System.Data.Listeners<System.Data.DataViewListener>_listeners  // 0x48
  private           System.Boolean                  _suspendEvents  // 0x50
  private   readonly System.Boolean                  _isSharable  // 0x51
  private   readonly System.Boolean                  _hasRemoteAggregate  // 0x52
  private   static  System.Int32                    s_objectTypeCount  // 0x0
  private   readonly System.Int32                    _objectID  // 0x54
METHODS:
  System.Void .ctor(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  System.Void .ctor(System.Data.DataTable table, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  System.Data.IndexField[] GetAllFields(System.Data.DataColumnCollection columns)
  System.Void .ctor(System.Data.DataTable table, System.Data.IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  System.Boolean Equal(System.Data.IndexField[] indexDesc, System.Data.DataViewRowState recordStates, System.Data.IFilter rowFilter)
  System.Boolean get_HasRemoteAggregate()
  System.Int32 get_ObjectID()
  System.Data.DataViewRowState get_RecordStates()
  System.Data.IFilter get_RowFilter()
  System.Int32 GetRecord(System.Int32 recordIndex)
  System.Boolean get_HasDuplicates()
  System.Int32 get_RecordCount()
  System.Boolean get_IsSharable()
  System.Boolean AcceptRecord(System.Int32 record)
  System.Boolean AcceptRecord(System.Int32 record, System.Data.IFilter filter)
  System.Void ListChangedAdd(System.Data.DataViewListener listener)
  System.Void ListChangedRemove(System.Data.DataViewListener listener)
  System.Int32 get_RefCount()
  System.Void AddRef()
  System.Int32 RemoveRef()
  System.Void ApplyChangeAction(System.Int32 record, System.Int32 action, System.Int32 changeRecord)
  System.Boolean CheckUnique()
  System.Int32 CompareRecords(System.Int32 record1, System.Int32 record2)
  System.Int32 CompareDataRows(System.Int32 record1, System.Int32 record2)
  System.Int32 CompareDuplicateRecords(System.Int32 record1, System.Int32 record2)
  System.Int32 CompareRecordToKey(System.Int32 record1, System.Object[] vals)
  System.Void DeleteRecordFromIndex(System.Int32 recordIndex)
  System.Void DeleteRecord(System.Int32 recordIndex)
  System.Void DeleteRecord(System.Int32 recordIndex, System.Boolean fireEvent)
  System.Data.RBTree.RBTreeEnumerator<System.Int32> GetEnumerator(System.Int32 startIndex)
  System.Int32 GetIndex(System.Int32 record)
  System.Int32 GetIndex(System.Int32 record, System.Int32 changeRecord)
  System.Object[] GetUniqueKeyValues()
  System.Int32 FindNodeByKey(System.Object originalKey)
  System.Int32 FindNodeByKeys(System.Object[] originalKey)
  System.Int32 FindNodeByKeyRecord(System.Int32 record)
  System.Data.Range GetRangeFromNode(System.Int32 nodeId)
  System.Data.Range FindRecords(System.Object key)
  System.Data.Range FindRecords(System.Object[] key)
  System.Void FireResetEvent()
  System.Int32 GetChangeAction(System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState)
  System.Int32 GetReplaceAction(System.Data.DataViewRowState oldState)
  System.Data.DataRow GetRow(System.Int32 i)
  System.Data.DataRow[] GetRows(System.Object[] values)
  System.Data.DataRow[] GetRows(System.Data.Range range)
  System.Void InitRecords(System.Data.IFilter filter)
  System.Int32 InsertRecordToIndex(System.Int32 record)
  System.Int32 InsertRecord(System.Int32 record, System.Boolean fireEvent)
  System.Boolean IsKeyInIndex(System.Object key)
  System.Boolean IsKeyInIndex(System.Object[] key)
  System.Boolean IsKeyRecordInIndex(System.Int32 record)
  System.Boolean get_DoListChanged()
  System.Void OnListChanged(System.ComponentModel.ListChangedType changedType, System.Int32 newIndex, System.Int32 oldIndex)
  System.Void OnListChanged(System.ComponentModel.ListChangedType changedType, System.Int32 index)
  System.Void OnListChanged(System.ComponentModel.ListChangedEventArgs e)
  System.Void MaintainDataView(System.ComponentModel.ListChangedType changedType, System.Int32 record, System.Boolean trackAddRemove)
  System.Void Reset()
  System.Void RecordChanged(System.Int32 record)
  System.Void RecordChanged(System.Int32 oldIndex, System.Int32 newIndex)
  System.Void RecordStateChanged(System.Int32 record, System.Data.DataViewRowState oldState, System.Data.DataViewRowState newState)
  System.Void RecordStateChanged(System.Int32 oldRecord, System.Data.DataViewRowState oldOldState, System.Data.DataViewRowState oldNewState, System.Int32 newRecord, System.Data.DataViewRowState newOldState, System.Data.DataViewRowState newNewState)
  System.Data.DataTable get_Table()
  System.Void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, System.Int32 curNodeId)
  System.Int32 IndexOfReference(System.Collections.Generic.List<T> list, T item)
END_CLASS

CLASS: System.Data.Listeners`1
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  private   readonly System.Collections.Generic.List<TElem>_listeners  // 0x0
  private   readonly System.Data.Listeners.Func<TElem,TElem,System.Boolean>_filter  // 0x0
  private   readonly System.Int32                    _objectID  // 0x0
  private           System.Int32                    _listenerReaderCount  // 0x0
METHODS:
  System.Void .ctor(System.Int32 ObjectID, System.Data.Listeners.Func<TElem,TElem,System.Boolean> notifyFilter)
  System.Boolean get_HasListeners()
  System.Void Add(TElem listener)
  System.Int32 IndexOfReference(TElem listener)
  System.Void Remove(TElem listener)
  System.Void Notify(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem,TElem,T1,T2,T3> action)
  System.Void RemoveNullListeners(System.Int32 nullIndex)
END_CLASS

CLASS: System.Data.SimpleType
TYPE:  class
TOKEN: 0x2000085
FIELDS:
  private           System.String                   _baseType  // 0x10
  private           System.Data.SimpleType          _baseSimpleType  // 0x18
  private           System.Xml.XmlQualifiedName     _xmlBaseType  // 0x20
  private           System.String                   _name  // 0x28
  private           System.Int32                    _length  // 0x30
  private           System.Int32                    _minLength  // 0x34
  private           System.Int32                    _maxLength  // 0x38
  private           System.String                   _pattern  // 0x40
  private           System.String                   _ns  // 0x48
  private           System.String                   _maxExclusive  // 0x50
  private           System.String                   _maxInclusive  // 0x58
  private           System.String                   _minExclusive  // 0x60
  private           System.String                   _minInclusive  // 0x68
  private           System.String                   _enumeration  // 0x70
METHODS:
  System.Void .ctor(System.String baseType)
  System.Void .ctor(System.Xml.Schema.XmlSchemaSimpleType node)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void LoadTypeValues(System.Xml.Schema.XmlSchemaSimpleType node)
  System.Boolean IsPlainString()
  System.String get_BaseType()
  System.Xml.XmlQualifiedName get_XmlBaseType()
  System.String get_Name()
  System.String get_Namespace()
  System.Int32 get_Length()
  System.Int32 get_MaxLength()
  System.Void set_MaxLength(System.Int32 value)
  System.Data.SimpleType get_BaseSimpleType()
  System.String get_SimpleTypeQualifiedName()
  System.String QualifiedName(System.String name)
  System.Xml.XmlNode ToNode(System.Xml.XmlDocument dc, System.Collections.Hashtable prefixes, System.Boolean inRemoting)
  System.Data.SimpleType CreateEnumeratedType(System.String values)
  System.Data.SimpleType CreateByteArrayType(System.String encoding)
  System.Data.SimpleType CreateLimitedStringType(System.Int32 length)
  System.Data.SimpleType CreateSimpleType(System.Data.Common.StorageType typeCode, System.Type type)
  System.String HasConflictingDefinition(System.Data.SimpleType otherSimpleType)
  System.Boolean CanHaveMaxLength()
  System.Void ConvertToAnnonymousSimpleType()
END_CLASS

CLASS: System.Data.UniqueConstraint
TYPE:  class
TOKEN: 0x2000086
EXTENDS: Constraint
FIELDS:
  private           System.Data.DataKey             _key  // 0x38
  private           System.Data.Index               _constraintIndex  // 0x40
  private           System.Boolean                  _bPrimaryKey  // 0x48
  private           System.String                   _constraintName  // 0x50
  private           System.String[]                 _columnNames  // 0x58
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Void .ctor(System.String name, System.Data.DataColumn[] columns)
  System.Void .ctor(System.Data.DataColumn[] columns)
  System.Void .ctor(System.String name, System.String[] columnNames, System.Boolean isPrimaryKey)
  System.Void .ctor(System.String name, System.Data.DataColumn[] columns, System.Boolean isPrimaryKey)
  System.String[] get_ColumnNames()
  System.Data.Index get_ConstraintIndex()
  System.Void ConstraintIndexClear()
  System.Void ConstraintIndexInitialize()
  System.Void CheckState()
  System.Void NonVirtualCheckState()
  System.Void CheckCanAddToCollection(System.Data.ConstraintCollection constraints)
  System.Boolean CanBeRemovedFromCollection(System.Data.ConstraintCollection constraints, System.Boolean fThrowException)
  System.Boolean CanEnableConstraint()
  System.Boolean IsConstraintViolated()
  System.Void CheckConstraint(System.Data.DataRow row, System.Data.DataRowAction action)
  System.Boolean ContainsColumn(System.Data.DataColumn column)
  System.Data.Constraint Clone(System.Data.DataSet destination)
  System.Data.Constraint Clone(System.Data.DataSet destination, System.Boolean ignorNSforTableLookup)
  System.Data.UniqueConstraint Clone(System.Data.DataTable table)
  System.Data.DataColumn[] get_Columns()
  System.Data.DataColumn[] get_ColumnsReference()
  System.Boolean get_IsPrimaryKey()
  System.Void Create(System.String constraintName, System.Data.DataColumn[] columns)
  System.Boolean Equals(System.Object key2)
  System.Int32 GetHashCode()
  System.Void set_InCollection(System.Boolean value)
  System.Data.DataKey get_Key()
  System.Data.DataTable get_Table()
END_CLASS

CLASS: System.Data.XDRSchema
TYPE:  class
TOKEN: 0x2000087
EXTENDS: XMLSchema
FIELDS:
  private           System.String                   _schemaName  // 0x10
  private           System.String                   _schemaUri  // 0x18
  private           System.Xml.XmlElement           _schemaRoot  // 0x20
  private           System.Data.DataSet             _ds  // 0x28
  private   static readonly System.Char[]                   s_colonArray  // 0x0
  private   static  System.Data.XDRSchema.NameType[]s_mapNameTypeXdr  // 0x8
  private   static  System.Data.XDRSchema.NameType  s_enumerationNameType  // 0x10
METHODS:
  System.Void .ctor(System.Data.DataSet ds, System.Boolean fInline)
  System.Void LoadSchema(System.Xml.XmlElement schemaRoot, System.Data.DataSet ds)
  System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node)
  System.Boolean IsTextOnlyContent(System.Xml.XmlElement node)
  System.Boolean IsXDRField(System.Xml.XmlElement node, System.Xml.XmlElement typeNode)
  System.Data.DataTable HandleTable(System.Xml.XmlElement node)
  System.Data.XDRSchema.NameType FindNameType(System.String name)
  System.Type ParseDataType(System.String dt, System.String dtValues)
  System.String GetInstanceName(System.Xml.XmlElement node)
  System.Void HandleColumn(System.Xml.XmlElement node, System.Data.DataTable table)
  System.Void GetMinMax(System.Xml.XmlElement elNode, System.Int32& minOccurs, System.Int32& maxOccurs)
  System.Void GetMinMax(System.Xml.XmlElement elNode, System.Boolean isAttribute, System.Int32& minOccurs, System.Int32& maxOccurs)
  System.Void HandleTypeNode(System.Xml.XmlElement typeNode, System.Data.DataTable table, System.Collections.ArrayList tableChildren)
  System.Data.DataTable InstantiateTable(System.Data.DataSet dataSet, System.Xml.XmlElement node, System.Xml.XmlElement typeNode)
  System.Data.DataTable InstantiateSimpleTable(System.Data.DataSet dataSet, System.Xml.XmlElement node)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.XMLDiffLoader
TYPE:  class
TOKEN: 0x2000089
FIELDS:
  private           System.Collections.ArrayList    _tables  // 0x10
  private           System.Data.DataSet             _dataSet  // 0x18
  private           System.Data.DataTable           _dataTable  // 0x20
METHODS:
  System.Void LoadDiffGram(System.Data.DataSet ds, System.Xml.XmlReader dataTextReader)
  System.Void CreateTablesHierarchy(System.Data.DataTable dt)
  System.Void LoadDiffGram(System.Data.DataTable dt, System.Xml.XmlReader dataTextReader)
  System.Void ProcessDiffs(System.Data.DataSet ds, System.Xml.XmlReader ssync)
  System.Void ProcessDiffs(System.Collections.ArrayList tableList, System.Xml.XmlReader ssync)
  System.Void ProcessErrors(System.Data.DataSet ds, System.Xml.XmlReader ssync)
  System.Void ProcessErrors(System.Collections.ArrayList dt, System.Xml.XmlReader ssync)
  System.Data.DataTable GetTable(System.String tableName, System.String ns)
  System.Int32 ReadOldRowData(System.Data.DataSet ds, System.Data.DataTable& table, System.Int32& pos, System.Xml.XmlReader row)
  System.Void SkipWhitespaces(System.Xml.XmlReader reader)
  System.Void .ctor()
END_CLASS

CLASS: System.Data.XMLSchema
TYPE:  class
TOKEN: 0x200008A
FIELDS:
METHODS:
  System.ComponentModel.TypeConverter GetConverter(System.Type type)
  System.Void SetProperties(System.Object instance, System.Xml.XmlAttributeCollection attrs)
  System.Boolean FEqualIdentity(System.Xml.XmlNode node, System.String name, System.String ns)
  System.Boolean GetBooleanAttribute(System.Xml.XmlElement element, System.String attrName, System.String attrNS, System.Boolean defVal)
  System.String GenUniqueColumnName(System.String proposedName, System.Data.DataTable table)
  System.Void .ctor()
END_CLASS

CLASS: System.Data.ConstraintTable
TYPE:  class
TOKEN: 0x200008B
FIELDS:
  public            System.Data.DataTable           table  // 0x10
  public            System.Xml.Schema.XmlSchemaIdentityConstraintconstraint  // 0x18
METHODS:
  System.Void .ctor(System.Data.DataTable t, System.Xml.Schema.XmlSchemaIdentityConstraint c)
END_CLASS

CLASS: System.Data.XSDSchema
TYPE:  class
TOKEN: 0x200008C
EXTENDS: XMLSchema
FIELDS:
  private           System.Xml.Schema.XmlSchemaSet  _schemaSet  // 0x10
  private           System.Xml.Schema.XmlSchemaElement_dsElement  // 0x18
  private           System.Data.DataSet             _ds  // 0x20
  private           System.String                   _schemaName  // 0x28
  private           System.Collections.ArrayList    _columnExpressions  // 0x30
  private           System.Collections.Hashtable    _constraintNodes  // 0x38
  private           System.Collections.ArrayList    _refTables  // 0x40
  private           System.Collections.ArrayList    _complexTypes  // 0x48
  private           System.Xml.Schema.XmlSchemaObjectCollection_annotations  // 0x50
  private           System.Xml.Schema.XmlSchemaObjectCollection_elements  // 0x58
  private           System.Collections.Hashtable    _attributes  // 0x60
  private           System.Collections.Hashtable    _elementsTable  // 0x68
  private           System.Collections.Hashtable    _attributeGroups  // 0x70
  private           System.Collections.Hashtable    _schemaTypes  // 0x78
  private           System.Collections.Hashtable    _expressions  // 0x80
  private           System.Collections.Generic.Dictionary<System.Data.DataTable,System.Collections.Generic.List<System.Data.DataTable>>_tableDictionary  // 0x88
  private           System.Collections.Hashtable    _udSimpleTypes  // 0x90
  private           System.Collections.Hashtable    _existingSimpleTypeMap  // 0x98
  private           System.Boolean                  _fromInference  // 0xA0
  private   static readonly System.Data.XSDSchema.NameType[]s_mapNameTypeXsd  // 0x0
METHODS:
  System.Boolean get_FromInference()
  System.Void set_FromInference(System.Boolean value)
  System.Void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema)
  System.Void CollectElementsAnnotations(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList schemaList)
  System.String QualifiedName(System.String name)
  System.Void SetProperties(System.Object instance, System.Xml.XmlAttribute[] attrs)
  System.Void SetExtProperties(System.Object instance, System.Xml.XmlAttribute[] attrs)
  System.Void HandleColumnExpression(System.Object instance, System.Xml.XmlAttribute[] attrs)
  System.String GetMsdataAttribute(System.Xml.Schema.XmlSchemaAnnotated node, System.String ln)
  System.Void SetExtProperties(System.Object instance, System.Xml.XmlAttributeCollection attrs)
  System.Void HandleRefTableProperties(System.Collections.ArrayList RefTables, System.Xml.Schema.XmlSchemaElement element)
  System.Void HandleRelation(System.Xml.XmlElement node, System.Boolean fNested)
  System.Boolean HasAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes)
  System.Boolean IsDatasetParticle(System.Xml.Schema.XmlSchemaParticle pt)
  System.Int32 DatasetElementCount(System.Xml.Schema.XmlSchemaObjectCollection elements)
  System.Xml.Schema.XmlSchemaElement FindDatasetElement(System.Xml.Schema.XmlSchemaObjectCollection elements)
  System.Void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataTable dt)
  System.Void LoadSchema(System.Xml.Schema.XmlSchemaSet schemaSet, System.Data.DataSet ds)
  System.Void HandleRelations(System.Xml.Schema.XmlSchemaAnnotation ann, System.Boolean fNested)
  System.Xml.Schema.XmlSchemaObjectCollection GetParticleItems(System.Xml.Schema.XmlSchemaParticle pt)
  System.Void HandleParticle(System.Xml.Schema.XmlSchemaParticle pt, System.Data.DataTable table, System.Collections.ArrayList tableChildren, System.Boolean isBase)
  System.Void HandleAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Data.DataTable table, System.Boolean isBase)
  System.Void HandleAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Data.DataTable table, System.Boolean isBase)
  System.Void HandleComplexType(System.Xml.Schema.XmlSchemaComplexType ct, System.Data.DataTable table, System.Collections.ArrayList tableChildren, System.Boolean isNillable)
  System.Xml.Schema.XmlSchemaParticle GetParticle(System.Xml.Schema.XmlSchemaComplexType ct)
  System.Data.DataColumn FindField(System.Data.DataTable table, System.String field)
  System.Data.DataColumn[] BuildKey(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode, System.Data.DataTable table)
  System.Boolean GetBooleanAttribute(System.Xml.Schema.XmlSchemaAnnotated element, System.String attrName, System.Boolean defVal)
  System.String GetStringAttribute(System.Xml.Schema.XmlSchemaAnnotated element, System.String attrName, System.String defVal)
  System.Data.AcceptRejectRule TranslateAcceptRejectRule(System.String strRule)
  System.Data.Rule TranslateRule(System.String strRule)
  System.Void HandleKeyref(System.Xml.Schema.XmlSchemaKeyref keyref)
  System.Void HandleConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint keyNode)
  System.Data.DataTable InstantiateSimpleTable(System.Xml.Schema.XmlSchemaElement node)
  System.String GetInstanceName(System.Xml.Schema.XmlSchemaAnnotated node)
  System.Data.DataTable InstantiateTable(System.Xml.Schema.XmlSchemaElement node, System.Xml.Schema.XmlSchemaComplexType typeNode, System.Boolean isRef)
  System.Type XsdtoClr(System.String xsdTypeName)
  System.Data.XSDSchema.NameType FindNameType(System.String name)
  System.Type ParseDataType(System.String dt)
  System.Boolean IsXsdType(System.String name)
  System.Xml.Schema.XmlSchemaAnnotated FindTypeNode(System.Xml.Schema.XmlSchemaAnnotated node)
  System.Void HandleSimpleTypeSimpleContentColumn(System.Xml.Schema.XmlSchemaSimpleType typeNode, System.String strType, System.Data.DataTable table, System.Boolean isBase, System.Xml.XmlAttribute[] attrs, System.Boolean isNillable)
  System.Void HandleSimpleContentColumn(System.String strType, System.Data.DataTable table, System.Boolean isBase, System.Xml.XmlAttribute[] attrs, System.Boolean isNillable)
  System.Void HandleAttributeColumn(System.Xml.Schema.XmlSchemaAttribute attrib, System.Data.DataTable table, System.Boolean isBase)
  System.Void HandleElementColumn(System.Xml.Schema.XmlSchemaElement elem, System.Data.DataTable table, System.Boolean isBase)
  System.Void HandleDataSet(System.Xml.Schema.XmlSchemaElement node, System.Boolean isNewDataSet)
  System.Void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Data.DataTable dt)
  System.String GetPrefix(System.String ns)
  System.String GetNamespaceFromPrefix(System.String prefix)
  System.String GetTableNamespace(System.Xml.Schema.XmlSchemaIdentityConstraint key)
  System.String GetTableName(System.Xml.Schema.XmlSchemaIdentityConstraint key)
  System.Boolean IsTable(System.Xml.Schema.XmlSchemaElement node)
  System.Data.DataTable HandleTable(System.Xml.Schema.XmlSchemaElement node)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Data.XmlIgnoreNamespaceReader
TYPE:  class
TOKEN: 0x200008E
EXTENDS: XmlNodeReader
FIELDS:
  private           System.Collections.Generic.List<System.String>_namespacesToIgnore  // 0x30
METHODS:
  System.Void .ctor(System.Xml.XmlDocument xdoc, System.String[] namespacesToIgnore)
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
END_CLASS

CLASS: System.Data.XmlDataLoader
TYPE:  class
TOKEN: 0x200008F
FIELDS:
  private           System.Data.DataSet             _dataSet  // 0x10
  private           System.Data.XmlToDatasetMap     _nodeToSchemaMap  // 0x18
  private           System.Collections.Hashtable    _nodeToRowMap  // 0x20
  private           System.Collections.Stack        _childRowsStack  // 0x28
  private           System.Collections.Hashtable    _htableExcludedNS  // 0x30
  private           System.Boolean                  _fIsXdr  // 0x38
  private           System.Boolean                  _isDiffgram  // 0x39
  private           System.Xml.XmlElement           _topMostNode  // 0x40
  private           System.Boolean                  _ignoreSchema  // 0x48
  private           System.Data.DataTable           _dataTable  // 0x50
  private           System.Boolean                  _isTableLevel  // 0x58
  private           System.Boolean                  _fromInference  // 0x59
  private           System.Xml.XmlReader            _dataReader  // 0x60
  private           System.Object                   _XSD_XMLNS_NS  // 0x68
  private           System.Object                   _XDR_SCHEMA  // 0x70
  private           System.Object                   _XDRNS  // 0x78
  private           System.Object                   _SQL_SYNC  // 0x80
  private           System.Object                   _UPDGNS  // 0x88
  private           System.Object                   _XSD_SCHEMA  // 0x90
  private           System.Object                   _XSDNS  // 0x98
  private           System.Object                   _DFFNS  // 0xA0
  private           System.Object                   _MSDNS  // 0xA8
  private           System.Object                   _DIFFID  // 0xB0
  private           System.Object                   _HASCHANGES  // 0xB8
  private           System.Object                   _ROWORDER  // 0xC0
METHODS:
  System.Void .ctor(System.Data.DataSet dataset, System.Boolean IsXdr, System.Boolean ignoreSchema)
  System.Void .ctor(System.Data.DataSet dataset, System.Boolean IsXdr, System.Xml.XmlElement topNode, System.Boolean ignoreSchema)
  System.Void .ctor(System.Data.DataTable datatable, System.Boolean IsXdr, System.Boolean ignoreSchema)
  System.Void .ctor(System.Data.DataTable datatable, System.Boolean IsXdr, System.Xml.XmlElement topNode, System.Boolean ignoreSchema)
  System.Boolean get_FromInference()
  System.Void set_FromInference(System.Boolean value)
  System.Void AttachRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement)
  System.Int32 CountNonNSAttributes(System.Xml.XmlNode node)
  System.String GetValueForTextOnlyColums(System.Xml.XmlNode n)
  System.String GetInitialTextFromNodes(System.Xml.XmlNode& n)
  System.Data.DataColumn GetTextOnlyColumn(System.Data.DataRow row)
  System.Data.DataRow GetRowFromElement(System.Xml.XmlElement e)
  System.Boolean FColumnElement(System.Xml.XmlElement e)
  System.Boolean FExcludedNamespace(System.String ns)
  System.Boolean FIgnoreNamespace(System.Xml.XmlNode node)
  System.Boolean FIgnoreNamespace(System.Xml.XmlReader node)
  System.Boolean IsTextLikeNode(System.Xml.XmlNodeType n)
  System.Boolean IsTextOnly(System.Data.DataColumn c)
  System.Void LoadData(System.Xml.XmlDocument xdoc)
  System.Void LoadRowData(System.Data.DataRow row, System.Xml.XmlElement rowElement)
  System.Void LoadRows(System.Data.DataRow parentRow, System.Xml.XmlNode parentElement)
  System.Void SetRowValueFromXmlText(System.Data.DataRow row, System.Data.DataColumn col, System.String xmlText)
  System.Void InitNameTable()
  System.Void LoadData(System.Xml.XmlReader reader)
  System.Void LoadTopMostTable(System.Data.DataTable table)
  System.Void LoadTable(System.Data.DataTable table, System.Boolean isNested)
  System.Void LoadColumn(System.Data.DataColumn column, System.Object[] foundColumns)
  System.Boolean ProcessXsdSchema()
END_CLASS

CLASS: System.Data.XmlReadMode
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.XmlReadMode         Auto  // 0x0
  public    static  System.Data.XmlReadMode         ReadSchema  // 0x0
  public    static  System.Data.XmlReadMode         IgnoreSchema  // 0x0
  public    static  System.Data.XmlReadMode         InferSchema  // 0x0
  public    static  System.Data.XmlReadMode         DiffGram  // 0x0
  public    static  System.Data.XmlReadMode         Fragment  // 0x0
  public    static  System.Data.XmlReadMode         InferTypedSchema  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.XmlToDatasetMap
TYPE:  class
TOKEN: 0x2000091
FIELDS:
  private           System.Data.XmlToDatasetMap.XmlNodeIdHashtable_tableSchemaMap  // 0x10
  private           System.Data.XmlToDatasetMap.TableSchemaInfo_lastTableSchemaInfo  // 0x18
METHODS:
  System.Void .ctor(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable)
  System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet)
  System.Void .ctor(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable)
  System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable)
  System.Boolean IsMappedColumn(System.Data.DataColumn c)
  System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Data.DataTable table, System.Xml.XmlNameTable nameTable)
  System.Data.XmlToDatasetMap.TableSchemaInfo AddTableSchema(System.Xml.XmlNameTable nameTable, System.Data.DataTable table)
  System.Boolean AddColumnSchema(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns)
  System.Boolean AddColumnSchema(System.Xml.XmlNameTable nameTable, System.Data.DataColumn col, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns)
  System.Void BuildIdentityMap(System.Data.DataSet dataSet, System.Xml.XmlNameTable nameTable)
  System.Void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataSet dataSet)
  System.Void BuildIdentityMap(System.Data.DataTable dataTable, System.Xml.XmlNameTable nameTable)
  System.Void BuildIdentityMap(System.Xml.XmlNameTable nameTable, System.Data.DataTable dataTable)
  System.Collections.ArrayList GetSelfAndDescendants(System.Data.DataTable dt)
  System.Object GetColumnSchema(System.Xml.XmlNode node, System.Boolean fIgnoreNamespace)
  System.Object GetColumnSchema(System.Data.DataTable table, System.Xml.XmlReader dataReader, System.Boolean fIgnoreNamespace)
  System.Object GetSchemaForNode(System.Xml.XmlNode node, System.Boolean fIgnoreNamespace)
  System.Data.DataTable GetTableForNode(System.Xml.XmlReader node, System.Boolean fIgnoreNamespace)
  System.Void HandleSpecialColumn(System.Data.DataColumn col, System.Xml.XmlNameTable nameTable, System.Data.XmlToDatasetMap.XmlNodeIdHashtable columns)
END_CLASS

CLASS: System.Data.XmlWriteMode
TYPE:  struct
TOKEN: 0x2000095
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.XmlWriteMode        WriteSchema  // 0x0
  public    static  System.Data.XmlWriteMode        IgnoreSchema  // 0x0
  public    static  System.Data.XmlWriteMode        DiffGram  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.SchemaFormat
TYPE:  struct
TOKEN: 0x2000096
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SchemaFormat        Public  // 0x0
  public    static  System.Data.SchemaFormat        Remoting  // 0x0
  public    static  System.Data.SchemaFormat        WebService  // 0x0
  public    static  System.Data.SchemaFormat        RemotingSkipSchema  // 0x0
  public    static  System.Data.SchemaFormat        WebServiceSkipSchema  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.XmlTreeGen
TYPE:  class
TOKEN: 0x2000097
FIELDS:
  private           System.Collections.ArrayList    _constraintNames  // 0x10
  private           System.Collections.Hashtable    _namespaces  // 0x18
  private           System.Collections.Hashtable    _autogenerated  // 0x20
  private           System.Collections.Hashtable    _prefixes  // 0x28
  private           System.Data.DataSet             _ds  // 0x30
  private           System.Collections.ArrayList    _tables  // 0x38
  private           System.Collections.ArrayList    _relations  // 0x40
  private           System.Xml.XmlDocument          _dc  // 0x48
  private           System.Xml.XmlElement           _sRoot  // 0x50
  private           System.Int32                    _prefixCount  // 0x58
  private           System.Data.SchemaFormat        _schFormat  // 0x5C
  private           System.String                   _filePath  // 0x60
  private           System.String                   _fileName  // 0x68
  private           System.String                   _fileExt  // 0x70
  private           System.Xml.XmlElement           _dsElement  // 0x78
  private           System.Xml.XmlElement           _constraintSeparator  // 0x80
  private           System.Converter<System.Type,System.String>_targetConverter  // 0x88
METHODS:
  System.Void .ctor(System.Data.SchemaFormat format)
  System.Void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node)
  System.Void AddExtendedProperties(System.Data.PropertyCollection props, System.Xml.XmlElement node, System.Type type)
  System.Void AddXdoProperties(System.Object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd)
  System.Void AddXdoProperty(System.ComponentModel.PropertyDescriptor pd, System.Object instance, System.Xml.XmlElement root, System.Xml.XmlDocument xd)
  System.String XmlDataTypeName(System.Type type)
  System.Void GenerateConstraintNames(System.Data.DataTable table, System.Boolean fromTable)
  System.Void GenerateConstraintNames(System.Collections.ArrayList tables)
  System.Void GenerateConstraintNames(System.Data.DataSet ds)
  System.Boolean _PropsNotEmpty(System.Data.PropertyCollection props)
  System.Boolean HaveExtendedProperties(System.Data.DataSet ds)
  System.Void WriteSchemaRoot(System.Xml.XmlDocument xd, System.Xml.XmlElement rootSchema, System.String targetNamespace)
  System.Void ValidateColumnMapping(System.Type columnType)
  System.Void SetupAutoGenerated(System.Data.DataSet ds)
  System.Void SetupAutoGenerated(System.Collections.ArrayList dt)
  System.Void SetupAutoGenerated(System.Data.DataTable dt)
  System.Void CreateTablesHierarchy(System.Data.DataTable dt)
  System.Void CreateRelations(System.Data.DataTable dt)
  System.Data.DataTable[] CreateToplevelTables()
  System.Void SchemaTree(System.Xml.XmlDocument xd, System.Xml.XmlWriter xmlWriter, System.Data.DataSet ds, System.Data.DataTable dt, System.Boolean writeHierarchy)
  System.Xml.XmlElement SchemaTree(System.Xml.XmlDocument xd, System.Data.DataTable dt)
  System.Xml.XmlElement FillDataSetElement(System.Xml.XmlDocument xd, System.Data.DataSet ds, System.Data.DataTable dt)
  System.Void SetPath(System.Xml.XmlWriter xw)
  System.Void Save(System.Data.DataSet ds, System.Xml.XmlWriter xw)
  System.Void Save(System.Data.DataTable dt, System.Xml.XmlWriter xw)
  System.Void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw)
  System.Void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, System.Boolean writeHierarchy)
  System.Void Save(System.Data.DataSet ds, System.Data.DataTable dt, System.Xml.XmlWriter xw, System.Boolean writeHierarchy, System.Converter<System.Type,System.String> multipleTargetConverter)
  System.Xml.XmlElement HandleRelation(System.Data.DataRelation rel, System.Xml.XmlDocument dc)
  System.Xml.XmlElement FindSimpleType(System.Xml.XmlElement schema, System.String name)
  System.Xml.XmlElement GetSchema(System.String NamespaceURI)
  System.Void HandleColumnType(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement root, System.Xml.XmlElement schema)
  System.Void AddColumnProperties(System.Data.DataColumn col, System.Xml.XmlElement root)
  System.String FindTargetNamespace(System.Data.DataTable table)
  System.Xml.XmlElement HandleColumn(System.Data.DataColumn col, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, System.Boolean fWriteOrdinal)
  System.String TranslateAcceptRejectRule(System.Data.AcceptRejectRule rule)
  System.String TranslateRule(System.Data.Rule rule)
  System.Void AppendChildWithoutRef(System.Xml.XmlElement node, System.String Namespace, System.Xml.XmlElement el, System.String refString)
  System.Xml.XmlElement FindTypeNode(System.Xml.XmlElement node, System.String strType)
  System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema)
  System.Boolean HasMixedColumns(System.Data.DataTable table)
  System.Boolean AutoGenerated(System.Data.DataColumn col)
  System.Boolean AutoGenerated(System.Data.DataRelation rel)
  System.Boolean AutoGenerated(System.Data.UniqueConstraint unique)
  System.Boolean AutoGenerated(System.Data.ForeignKeyConstraint fk)
  System.Boolean AutoGenerated(System.Data.ForeignKeyConstraint fk, System.Boolean checkRelation)
  System.Boolean IsAutoGenerated(System.Object o)
  System.Xml.XmlElement HandleTable(System.Data.DataTable table, System.Xml.XmlDocument dc, System.Xml.XmlElement schema, System.Boolean genNested)
  System.Void SetMSDataAttribute(System.Xml.XmlElement root, System.Type type)
END_CLASS

CLASS: System.Data.NewDiffgramGen
TYPE:  class
TOKEN: 0x2000098
FIELDS:
  private           System.Xml.XmlDocument          _doc  // 0x10
  private           System.Data.DataSet             _ds  // 0x18
  private           System.Data.DataTable           _dt  // 0x20
  private           System.Xml.XmlWriter            _xmlw  // 0x28
  private           System.Boolean                  _fBefore  // 0x30
  private           System.Boolean                  _fErrors  // 0x31
  private           System.Collections.Hashtable    _rowsOrder  // 0x38
  private           System.Collections.ArrayList    _tables  // 0x40
  private           System.Boolean                  _writeHierarchy  // 0x48
METHODS:
  System.Void .ctor(System.Data.DataSet ds)
  System.Void .ctor(System.Data.DataTable dt, System.Boolean writeHierarchy)
  System.Void CreateTableHierarchy(System.Data.DataTable dt)
  System.Void DoAssignments(System.Collections.ArrayList tables)
  System.Boolean EmptyData()
  System.Void Save(System.Xml.XmlWriter xmlw)
  System.Void Save(System.Xml.XmlWriter xmlw, System.Data.DataTable table)
  System.Void GenerateTable(System.Data.DataTable table)
  System.Void GenerateTableErrors(System.Data.DataTable table)
  System.Void GenerateRow(System.Data.DataRow row)
  System.Void GenerateColumn(System.Data.DataRow row, System.Data.DataColumn col, System.Data.DataRowVersion version)
  System.String QualifiedName(System.String prefix, System.String name)
END_CLASS

CLASS: System.Data.XmlDataTreeWriter
TYPE:  class
TOKEN: 0x2000099
FIELDS:
  private           System.Xml.XmlWriter            _xmlw  // 0x10
  private           System.Data.DataSet             _ds  // 0x18
  private           System.Data.DataTable           _dt  // 0x20
  private           System.Collections.ArrayList    _dTables  // 0x28
  private           System.Data.DataTable[]         _topLevelTables  // 0x30
  private           System.Boolean                  _fFromTable  // 0x38
  private           System.Boolean                  _isDiffgram  // 0x39
  private           System.Collections.Hashtable    _rowsOrder  // 0x40
  private           System.Boolean                  _writeHierarchy  // 0x48
METHODS:
  System.Void .ctor(System.Data.DataSet ds)
  System.Void .ctor(System.Data.DataTable dt, System.Boolean writeHierarchy)
  System.Data.DataTable[] CreateToplevelTables()
  System.Void CreateTablesHierarchy(System.Data.DataTable dt)
  System.Boolean RowHasErrors(System.Data.DataRow row)
  System.Void SaveDiffgramData(System.Xml.XmlWriter xw, System.Collections.Hashtable rowsOrder)
  System.Void Save(System.Xml.XmlWriter xw, System.Boolean writeSchema)
  System.Collections.ArrayList GetNestedChildRelations(System.Data.DataRow row)
  System.Void XmlDataRowWriter(System.Data.DataRow row, System.String encodedTableName)
  System.Boolean PreserveSpace(System.Object value)
END_CLASS

CLASS: System.Data.DataTextWriter
TYPE:  class
TOKEN: 0x200009A
EXTENDS: XmlWriter
FIELDS:
  private           System.Xml.XmlWriter            _xmltextWriter  // 0x18
METHODS:
  System.Xml.XmlWriter CreateWriter(System.Xml.XmlWriter xw)
  System.Void .ctor(System.Xml.XmlWriter w)
  System.IO.Stream get_BaseStream()
  System.Void WriteStartDocument()
  System.Void WriteStartDocument(System.Boolean standalone)
  System.Void WriteEndDocument()
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndElement()
  System.Void WriteFullEndElement()
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndAttribute()
  System.Void WriteCData(System.String text)
  System.Void WriteComment(System.String text)
  System.Void WriteProcessingInstruction(System.String name, System.String text)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteWhitespace(System.String ws)
  System.Void WriteString(System.String text)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.String data)
  System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteBinHex(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Xml.WriteState get_WriteState()
  System.Void Close()
  System.Void Flush()
  System.String LookupPrefix(System.String ns)
END_CLASS

CLASS: System.Data.DataTextReader
TYPE:  class
TOKEN: 0x200009B
EXTENDS: XmlReader
FIELDS:
  private           System.Xml.XmlReader            _xmlreader  // 0x10
METHODS:
  System.Xml.XmlReader CreateReader(System.Xml.XmlReader xr)
  System.Void .ctor(System.Xml.XmlReader input)
  System.Xml.XmlReaderSettings get_Settings()
  System.Xml.XmlNodeType get_NodeType()
  System.String get_Name()
  System.String get_LocalName()
  System.String get_NamespaceURI()
  System.String get_Prefix()
  System.Boolean get_HasValue()
  System.String get_Value()
  System.Int32 get_Depth()
  System.String get_BaseURI()
  System.Boolean get_IsEmptyElement()
  System.Boolean get_IsDefault()
  System.Char get_QuoteChar()
  System.Xml.XmlSpace get_XmlSpace()
  System.String get_XmlLang()
  System.Int32 get_AttributeCount()
  System.String GetAttribute(System.String name)
  System.String GetAttribute(System.String localName, System.String namespaceURI)
  System.String GetAttribute(System.Int32 i)
  System.Boolean MoveToAttribute(System.String name)
  System.Void MoveToAttribute(System.Int32 i)
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
  System.Boolean MoveToElement()
  System.Boolean ReadAttributeValue()
  System.Boolean Read()
  System.Boolean get_EOF()
  System.Void Close()
  System.Xml.ReadState get_ReadState()
  System.Void Skip()
  System.Xml.XmlNameTable get_NameTable()
  System.String LookupNamespace(System.String prefix)
  System.Boolean get_CanResolveEntity()
  System.Void ResolveEntity()
  System.Boolean get_CanReadValueChunk()
  System.String ReadString()
END_CLASS

CLASS: System.Data.Common.ADP
TYPE:  class
TOKEN: 0x20000B6
FIELDS:
  private   static readonly System.Type                     s_stackOverflowType  // 0x0
  private   static readonly System.Type                     s_outOfMemoryType  // 0x8
  private   static readonly System.Type                     s_threadAbortType  // 0x10
  private   static readonly System.Type                     s_nullReferenceType  // 0x18
  private   static readonly System.Type                     s_accessViolationType  // 0x20
  private   static readonly System.Type                     s_securityType  // 0x28
  private   static readonly System.String                   StrEmpty  // 0x30
  private   static readonly System.String[]                 AzureSqlServerEndpoints  // 0x38
  private   static readonly System.IntPtr                   PtrZero  // 0x40
  private   static readonly System.Int32                    PtrSize  // 0x48
METHODS:
  System.Void TraceException(System.String trace, System.Exception e)
  System.Void TraceExceptionAsReturnValue(System.Exception e)
  System.Void TraceExceptionWithoutRethrow(System.Exception e)
  System.ArgumentException Argument(System.String error)
  System.ArgumentOutOfRangeException ArgumentOutOfRange(System.String parameterName)
  System.ArgumentOutOfRangeException ArgumentOutOfRange(System.String message, System.String parameterName)
  System.InvalidOperationException InvalidOperation(System.String error)
  System.NotSupportedException NotSupported(System.String error)
  System.Boolean IsCatchableExceptionType(System.Exception e)
  System.Boolean IsCatchableOrSecurityExceptionType(System.Exception e)
  System.ArgumentOutOfRangeException InvalidEnumerationValue(System.Type type, System.Int32 value)
  System.Exception InvalidSeekOrigin(System.String parameterName)
  System.ArgumentOutOfRangeException InvalidAcceptRejectRule(System.Data.AcceptRejectRule value)
  System.ArgumentOutOfRangeException InvalidMissingSchemaAction(System.Data.MissingSchemaAction value)
  System.ArgumentOutOfRangeException InvalidRule(System.Data.Rule value)
  System.Exception WrongType(System.Type got, System.Type expected)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.BigIntegerStorage
TYPE:  class
TOKEN: 0x20000B7
EXTENDS: DataStorage
FIELDS:
  private           System.Numerics.BigInteger[]    _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Numerics.BigInteger ConvertToBigInteger(System.Object value, System.IFormatProvider formatProvider)
  System.Object ConvertFromBigInteger(System.Numerics.BigInteger value, System.Type type, System.IFormatProvider formatProvider)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.BooleanStorage
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: DataStorage
FIELDS:
  private           System.Boolean[]                _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.ByteStorage
TYPE:  class
TOKEN: 0x20000B9
EXTENDS: DataStorage
FIELDS:
  private           System.Byte[]                   _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.CharStorage
TYPE:  class
TOKEN: 0x20000BA
EXTENDS: DataStorage
FIELDS:
  private           System.Char[]                   _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.StorageType
TYPE:  struct
TOKEN: 0x20000BB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.Common.StorageType  Empty  // 0x0
  public    static  System.Data.Common.StorageType  Object  // 0x0
  public    static  System.Data.Common.StorageType  DBNull  // 0x0
  public    static  System.Data.Common.StorageType  Boolean  // 0x0
  public    static  System.Data.Common.StorageType  Char  // 0x0
  public    static  System.Data.Common.StorageType  SByte  // 0x0
  public    static  System.Data.Common.StorageType  Byte  // 0x0
  public    static  System.Data.Common.StorageType  Int16  // 0x0
  public    static  System.Data.Common.StorageType  UInt16  // 0x0
  public    static  System.Data.Common.StorageType  Int32  // 0x0
  public    static  System.Data.Common.StorageType  UInt32  // 0x0
  public    static  System.Data.Common.StorageType  Int64  // 0x0
  public    static  System.Data.Common.StorageType  UInt64  // 0x0
  public    static  System.Data.Common.StorageType  Single  // 0x0
  public    static  System.Data.Common.StorageType  Double  // 0x0
  public    static  System.Data.Common.StorageType  Decimal  // 0x0
  public    static  System.Data.Common.StorageType  DateTime  // 0x0
  public    static  System.Data.Common.StorageType  TimeSpan  // 0x0
  public    static  System.Data.Common.StorageType  String  // 0x0
  public    static  System.Data.Common.StorageType  Guid  // 0x0
  public    static  System.Data.Common.StorageType  ByteArray  // 0x0
  public    static  System.Data.Common.StorageType  CharArray  // 0x0
  public    static  System.Data.Common.StorageType  Type  // 0x0
  public    static  System.Data.Common.StorageType  DateTimeOffset  // 0x0
  public    static  System.Data.Common.StorageType  BigInteger  // 0x0
  public    static  System.Data.Common.StorageType  Uri  // 0x0
  public    static  System.Data.Common.StorageType  SqlBinary  // 0x0
  public    static  System.Data.Common.StorageType  SqlBoolean  // 0x0
  public    static  System.Data.Common.StorageType  SqlByte  // 0x0
  public    static  System.Data.Common.StorageType  SqlBytes  // 0x0
  public    static  System.Data.Common.StorageType  SqlChars  // 0x0
  public    static  System.Data.Common.StorageType  SqlDateTime  // 0x0
  public    static  System.Data.Common.StorageType  SqlDecimal  // 0x0
  public    static  System.Data.Common.StorageType  SqlDouble  // 0x0
  public    static  System.Data.Common.StorageType  SqlGuid  // 0x0
  public    static  System.Data.Common.StorageType  SqlInt16  // 0x0
  public    static  System.Data.Common.StorageType  SqlInt32  // 0x0
  public    static  System.Data.Common.StorageType  SqlInt64  // 0x0
  public    static  System.Data.Common.StorageType  SqlMoney  // 0x0
  public    static  System.Data.Common.StorageType  SqlSingle  // 0x0
  public    static  System.Data.Common.StorageType  SqlString  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.Common.DataStorage
TYPE:  class
TOKEN: 0x20000BC
FIELDS:
  private   static readonly System.Type[]                   s_storageClassType  // 0x0
  private   readonly System.Data.DataColumn          _column  // 0x10
  private   readonly System.Data.DataTable           _table  // 0x18
  private   readonly System.Type                     _dataType  // 0x20
  private   readonly System.Data.Common.StorageType  _storageTypeCode  // 0x28
  private           System.Collections.BitArray     _dbNullBits  // 0x30
  private   readonly System.Object                   _defaultValue  // 0x38
  private   readonly System.Object                   _nullValue  // 0x40
  private   readonly System.Boolean                  _isCloneable  // 0x48
  private   readonly System.Boolean                  _isCustomDefinedType  // 0x49
  private   readonly System.Boolean                  _isStringType  // 0x4A
  private   readonly System.Boolean                  _isValueType  // 0x4B
  private   static readonly System.Func<System.Type,System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean>>s_inspectTypeForInterfaces  // 0x8
  private   static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean>>s_typeImplementsInterface  // 0x10
METHODS:
  System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object defaultValue, System.Data.Common.StorageType storageType)
  System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object defaultValue, System.Object nullValue, System.Data.Common.StorageType storageType)
  System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object defaultValue, System.Object nullValue, System.Boolean isICloneable, System.Data.Common.StorageType storageType)
  System.Data.DataSetDateTime get_DateTimeMode()
  System.IFormatProvider get_FormatProvider()
  System.Object Aggregate(System.Int32[] recordNos, System.Data.AggregateType kind)
  System.Object AggregateCount(System.Int32[] recordNos)
  System.Int32 CompareBits(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo1, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void CopyBits(System.Int32 srcRecordNo, System.Int32 dstRecordNo)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 recordNo)
  System.Object GetBits(System.Int32 recordNo)
  System.Int32 GetStringLength(System.Int32 record)
  System.Boolean HasValue(System.Int32 recordNo)
  System.Boolean IsNull(System.Int32 recordNo)
  System.Void Set(System.Int32 recordNo, System.Object value)
  System.Void SetNullBit(System.Int32 recordNo, System.Boolean flag)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  System.String ConvertObjectToXml(System.Object value)
  System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  System.Data.Common.DataStorage CreateStorage(System.Data.DataColumn column, System.Type dataType, System.Data.Common.StorageType typeCode)
  System.Data.Common.StorageType GetStorageType(System.Type dataType)
  System.Type GetTypeStorage(System.Data.Common.StorageType storageType)
  System.Boolean IsTypeCustomType(System.Type type)
  System.Boolean IsTypeCustomType(System.Data.Common.StorageType typeCode)
  System.Boolean IsSqlType(System.Data.Common.StorageType storageType)
  System.Boolean IsSqlType(System.Type dataType)
  System.Boolean DetermineIfValueType(System.Data.Common.StorageType typeCode, System.Type dataType)
  System.Void ImplementsInterfaces(System.Data.Common.StorageType typeCode, System.Type dataType, System.Boolean& sqlType, System.Boolean& nullable, System.Boolean& xmlSerializable, System.Boolean& changeTracking, System.Boolean& revertibleChangeTracking)
  System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean> InspectTypeForInterfaces(System.Type dataType)
  System.Boolean ImplementsINullableValue(System.Data.Common.StorageType typeCode, System.Type dataType)
  System.Boolean IsObjectNull(System.Object value)
  System.Boolean IsObjectSqlNull(System.Object value)
  System.Object GetEmptyStorageInternal(System.Int32 recordCount)
  System.Void CopyValueInternal(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorageInternal(System.Object store, System.Collections.BitArray nullbits)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  System.Void SetNullStorage(System.Collections.BitArray nullbits)
  System.Type GetType(System.String value)
  System.String GetQualifiedName(System.Type type)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.DateTimeOffsetStorage
TYPE:  class
TOKEN: 0x20000BD
EXTENDS: DataStorage
FIELDS:
  private   static readonly System.DateTimeOffset           s_defaultValue  // 0x0
  private           System.DateTimeOffset[]         _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.DateTimeStorage
TYPE:  class
TOKEN: 0x20000BE
EXTENDS: DataStorage
FIELDS:
  private   static readonly System.DateTime                 s_defaultValue  // 0x0
  private           System.DateTime[]               _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.DecimalStorage
TYPE:  class
TOKEN: 0x20000BF
EXTENDS: DataStorage
FIELDS:
  private   static readonly System.Decimal                  s_defaultValue  // 0x0
  private           System.Decimal[]                _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.DoubleStorage
TYPE:  class
TOKEN: 0x20000C0
EXTENDS: DataStorage
FIELDS:
  private           System.Double[]                 _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.Int16Storage
TYPE:  class
TOKEN: 0x20000C1
EXTENDS: DataStorage
FIELDS:
  private           System.Int16[]                  _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.Int32Storage
TYPE:  class
TOKEN: 0x20000C2
EXTENDS: DataStorage
FIELDS:
  private           System.Int32[]                  _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.Int64Storage
TYPE:  class
TOKEN: 0x20000C3
EXTENDS: DataStorage
FIELDS:
  private           System.Int64[]                  _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.ObjectStorage
TYPE:  class
TOKEN: 0x20000C4
EXTENDS: DataStorage
FIELDS:
  private   static readonly System.Object                   s_defaultValue  // 0x0
  private           System.Object[]                 _values  // 0x50
  private   readonly System.Boolean                  _implementsIXmlSerializable  // 0x58
  private   static readonly System.Object                   s_tempAssemblyCacheLock  // 0x8
  private   static  System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute>,System.Xml.Serialization.XmlSerializer>s_tempAssemblyCache  // 0x10
  private   static readonly System.Xml.Serialization.XmlSerializerFactorys_serializerFactory  // 0x18
METHODS:
  System.Void .ctor(System.Data.DataColumn column, System.Type type)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo1, System.Object value)
  System.Int32 CompareTo(System.Object valueNo1, System.Object valueNo2)
  System.Int32 CompareWithFamilies(System.Object valueNo1, System.Object valueNo2)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 recordNo)
  System.Data.Common.ObjectStorage.Families GetFamily(System.Type dataType)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 recordNo, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  System.String ConvertObjectToXml(System.Object value)
  System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  System.Void VerifyIDynamicMetaObjectProvider(System.Type type)
  System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type)
  System.Xml.Serialization.XmlSerializer GetXmlSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute attribute)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.SByteStorage
TYPE:  class
TOKEN: 0x20000C7
EXTENDS: DataStorage
FIELDS:
  private           System.SByte[]                  _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlConvert
TYPE:  class
TOKEN: 0x20000C8
FIELDS:
METHODS:
  System.Data.SqlTypes.SqlByte ConvertToSqlByte(System.Object value)
  System.Data.SqlTypes.SqlInt16 ConvertToSqlInt16(System.Object value)
  System.Data.SqlTypes.SqlInt32 ConvertToSqlInt32(System.Object value)
  System.Data.SqlTypes.SqlInt64 ConvertToSqlInt64(System.Object value)
  System.Data.SqlTypes.SqlDouble ConvertToSqlDouble(System.Object value)
  System.Data.SqlTypes.SqlDecimal ConvertToSqlDecimal(System.Object value)
  System.Data.SqlTypes.SqlSingle ConvertToSqlSingle(System.Object value)
  System.Data.SqlTypes.SqlMoney ConvertToSqlMoney(System.Object value)
  System.Data.SqlTypes.SqlDateTime ConvertToSqlDateTime(System.Object value)
  System.Data.SqlTypes.SqlBoolean ConvertToSqlBoolean(System.Object value)
  System.Data.SqlTypes.SqlGuid ConvertToSqlGuid(System.Object value)
  System.Data.SqlTypes.SqlBinary ConvertToSqlBinary(System.Object value)
  System.Data.SqlTypes.SqlString ConvertToSqlString(System.Object value)
  System.Data.SqlTypes.SqlChars ConvertToSqlChars(System.Object value)
  System.Data.SqlTypes.SqlBytes ConvertToSqlBytes(System.Object value)
  System.DateTimeOffset ConvertStringToDateTimeOffset(System.String value, System.IFormatProvider formatProvider)
  System.Object ChangeTypeForDefaultValue(System.Object value, System.Type type, System.IFormatProvider formatProvider)
  System.Object ChangeType2(System.Object value, System.Data.Common.StorageType stype, System.Type type, System.IFormatProvider formatProvider)
  System.Object ChangeTypeForXML(System.Object value, System.Type type)
END_CLASS

CLASS: System.Data.Common.SqlBinaryStorage
TYPE:  class
TOKEN: 0x20000C9
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlBinary[]_values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlByteStorage
TYPE:  class
TOKEN: 0x20000CA
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlByte[]  _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlBytesStorage
TYPE:  class
TOKEN: 0x20000CB
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlBytes[] _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlCharsStorage
TYPE:  class
TOKEN: 0x20000CC
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlChars[] _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlDateTimeStorage
TYPE:  class
TOKEN: 0x20000CD
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlDateTime[]_values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlDecimalStorage
TYPE:  class
TOKEN: 0x20000CE
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlDecimal[]_values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlDoubleStorage
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlDouble[]_values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlGuidStorage
TYPE:  class
TOKEN: 0x20000D0
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlGuid[]  _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlInt16Storage
TYPE:  class
TOKEN: 0x20000D1
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlInt16[] _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlInt32Storage
TYPE:  class
TOKEN: 0x20000D2
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlInt32[] _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlInt64Storage
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlInt64[] _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlMoneyStorage
TYPE:  class
TOKEN: 0x20000D4
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlMoney[] _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlSingleStorage
TYPE:  class
TOKEN: 0x20000D5
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlSingle[]_values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlStringStorage
TYPE:  class
TOKEN: 0x20000D6
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlString[]_values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] recordNos, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 Compare(System.Data.SqlTypes.SqlString valueNo1, System.Data.SqlTypes.SqlString valueNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Int32 GetStringLength(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlBooleanStorage
TYPE:  class
TOKEN: 0x20000D7
EXTENDS: DataStorage
FIELDS:
  private           System.Data.SqlTypes.SqlBoolean[]_values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SingleStorage
TYPE:  class
TOKEN: 0x20000D8
EXTENDS: DataStorage
FIELDS:
  private           System.Single[]                 _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.SqlUdtStorage
TYPE:  class
TOKEN: 0x20000D9
EXTENDS: DataStorage
FIELDS:
  private           System.Object[]                 _values  // 0x50
  private   readonly System.Boolean                  _implementsIXmlSerializable  // 0x58
  private   readonly System.Boolean                  _implementsIComparable  // 0x59
  private   static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Object>s_typeToNull  // 0x0
METHODS:
  System.Void .ctor(System.Data.DataColumn column, System.Type type)
  System.Void .ctor(System.Data.DataColumn column, System.Type type, System.Object nullValue)
  System.Object GetStaticNullForUdtType(System.Type type)
  System.Boolean IsNull(System.Int32 record)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo1, System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 recordNo)
  System.Void Set(System.Int32 recordNo, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.Object ConvertXmlToObject(System.Xml.XmlReader xmlReader, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  System.String ConvertObjectToXml(System.Object value)
  System.Void ConvertObjectToXml(System.Object value, System.Xml.XmlWriter xmlWriter, System.Xml.Serialization.XmlRootAttribute xmlAttrib)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.StringStorage
TYPE:  class
TOKEN: 0x20000DB
EXTENDS: DataStorage
FIELDS:
  private           System.String[]                 _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] recordNos, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 recordNo)
  System.Int32 GetStringLength(System.Int32 record)
  System.Boolean IsNull(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.TimeSpanStorage
TYPE:  class
TOKEN: 0x20000DC
EXTENDS: DataStorage
FIELDS:
  private   static readonly System.TimeSpan                 s_defaultValue  // 0x0
  private           System.TimeSpan[]               _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.TimeSpan ConvertToTimeSpan(System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.Common.UInt16Storage
TYPE:  class
TOKEN: 0x20000DD
EXTENDS: DataStorage
FIELDS:
  private   static readonly System.UInt16                   s_defaultValue  // 0x0
  private           System.UInt16[]                 _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.UInt32Storage
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: DataStorage
FIELDS:
  private   static readonly System.UInt32                   s_defaultValue  // 0x0
  private           System.UInt32[]                 _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.Common.UInt64Storage
TYPE:  class
TOKEN: 0x20000DF
EXTENDS: DataStorage
FIELDS:
  private   static readonly System.UInt64                   s_defaultValue  // 0x0
  private           System.UInt64[]                 _values  // 0x50
METHODS:
  System.Void .ctor(System.Data.DataColumn column)
  System.Object Aggregate(System.Int32[] records, System.Data.AggregateType kind)
  System.Int32 Compare(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Int32 CompareValueTo(System.Int32 recordNo, System.Object value)
  System.Object ConvertValue(System.Object value)
  System.Void Copy(System.Int32 recordNo1, System.Int32 recordNo2)
  System.Object Get(System.Int32 record)
  System.Void Set(System.Int32 record, System.Object value)
  System.Void SetCapacity(System.Int32 capacity)
  System.Object ConvertXmlToObject(System.String s)
  System.String ConvertObjectToXml(System.Object value)
  System.Object GetEmptyStorage(System.Int32 recordCount)
  System.Void CopyValue(System.Int32 record, System.Object store, System.Collections.BitArray nullbits, System.Int32 storeIndex)
  System.Void SetStorage(System.Object store, System.Collections.BitArray nullbits)
END_CLASS

CLASS: System.Data.SqlTypes.SQLResource
TYPE:  class
TOKEN: 0x200009C
FIELDS:
METHODS:
  System.String get_NullString()
  System.String get_ArithOverflowMessage()
  System.String get_DivideByZeroMessage()
  System.String get_NullValueMessage()
  System.String get_TruncationMessage()
  System.String get_DateTimeOverflowMessage()
  System.String get_ConcatDiffCollationMessage()
  System.String get_CompareDiffCollationMessage()
  System.String get_ConversionOverflowMessage()
  System.String get_TimeZoneSpecifiedMessage()
  System.String get_InvalidPrecScaleMessage()
  System.String get_FormatMessage()
  System.String InvalidOpStreamClosed(System.String method)
  System.String InvalidOpStreamNonWritable(System.String method)
  System.String InvalidOpStreamNonReadable(System.String method)
  System.String InvalidOpStreamNonSeekable(System.String method)
END_CLASS

CLASS: System.Data.SqlTypes.INullable
TYPE:  interface
TOKEN: 0x200009D
FIELDS:
METHODS:
  System.Boolean get_IsNull()
END_CLASS

CLASS: System.Data.SqlTypes.SqlBinary
TYPE:  struct
TOKEN: 0x200009E
FIELDS:
  private           System.Byte[]                   _value  // 0x10
  public    static readonly System.Data.SqlTypes.SqlBinary  Null  // 0x0
METHODS:
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.Byte[] value)
  System.Boolean get_IsNull()
  System.Byte[] get_Value()
  System.Data.SqlTypes.SqlBinary op_Implicit(System.Byte[] x)
  System.String ToString()
  System.Data.SqlTypes.EComparison PerformCompareByte(System.Byte[] x, System.Byte[] y)
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y)
  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y)
  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y)
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlBinary value)
  System.Boolean Equals(System.Object value)
  System.Int32 HashByteArray(System.Byte[] rgbValue, System.Int32 length)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlBoolean
TYPE:  struct
TOKEN: 0x200009F
FIELDS:
  private           System.Byte                     m_value  // 0x10
  public    static readonly System.Data.SqlTypes.SqlBoolean True  // 0x0
  public    static readonly System.Data.SqlTypes.SqlBoolean False  // 0x1
  public    static readonly System.Data.SqlTypes.SqlBoolean Null  // 0x2
  public    static readonly System.Data.SqlTypes.SqlBoolean Zero  // 0x3
  public    static readonly System.Data.SqlTypes.SqlBoolean One  // 0x4
METHODS:
  System.Void .ctor(System.Boolean value)
  System.Void .ctor(System.Int32 value)
  System.Void .ctor(System.Int32 value, System.Boolean fNull)
  System.Boolean get_IsNull()
  System.Boolean get_Value()
  System.Boolean get_IsTrue()
  System.Boolean get_IsFalse()
  System.Data.SqlTypes.SqlBoolean op_Implicit(System.Boolean x)
  System.Boolean op_True(System.Data.SqlTypes.SqlBoolean x)
  System.Data.SqlTypes.SqlBoolean op_BitwiseAnd(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y)
  System.Data.SqlTypes.SqlBoolean op_BitwiseOr(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y)
  System.Byte get_ByteValue()
  System.String ToString()
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y)
  System.Data.SqlTypes.SqlBoolean And(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y)
  System.Data.SqlTypes.SqlBoolean Or(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y)
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlBoolean value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlByte
TYPE:  struct
TOKEN: 0x20000A0
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Byte                     m_value  // 0x11
  private   static readonly System.Int32                    s_iBitNotByteMax  // 0x0
  public    static readonly System.Data.SqlTypes.SqlByte    Null  // 0x4
  public    static readonly System.Data.SqlTypes.SqlByte    Zero  // 0x6
  public    static readonly System.Data.SqlTypes.SqlByte    MinValue  // 0x8
  public    static readonly System.Data.SqlTypes.SqlByte    MaxValue  // 0xA
METHODS:
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.Byte value)
  System.Boolean get_IsNull()
  System.Byte get_Value()
  System.Data.SqlTypes.SqlByte op_Implicit(System.Byte x)
  System.String ToString()
  System.Data.SqlTypes.SqlByte op_Addition(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  System.Data.SqlTypes.SqlByte op_Subtraction(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  System.Data.SqlTypes.SqlByte op_Multiply(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  System.Data.SqlTypes.SqlByte op_Division(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  System.Data.SqlTypes.SqlByte op_Explicit(System.Data.SqlTypes.SqlInt64 x)
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y)
  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  System.Data.SqlTypes.SqlInt64 ToSqlInt64()
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlByte value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlBytesCharsState
TYPE:  struct
TOKEN: 0x20000A1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SqlTypes.SqlBytesCharsStateNull  // 0x0
  public    static  System.Data.SqlTypes.SqlBytesCharsStateBuffer  // 0x0
  public    static  System.Data.SqlTypes.SqlBytesCharsStateStream  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.SqlTypes.SqlBytes
TYPE:  class
TOKEN: 0x20000A2
FIELDS:
  private           System.Byte[]                   _rgbBuf  // 0x10
  private           System.Int64                    _lCurLen  // 0x18
  private           System.IO.Stream                _stream  // 0x20
  private           System.Data.SqlTypes.SqlBytesCharsState_state  // 0x28
  private           System.Byte[]                   _rgbWorkBuf  // 0x30
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Byte[] buffer)
  System.Void .ctor(System.Data.SqlTypes.SqlBinary value)
  System.Boolean get_IsNull()
  System.Byte[] get_Buffer()
  System.Int64 get_Length()
  System.Byte[] get_Value()
  System.Void SetNull()
  System.Void CopyStreamToBuffer()
  System.Boolean FStream()
  System.Void SetBuffer(System.Byte[] buffer)
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Data.SqlTypes.SqlBytes get_Null()
END_CLASS

CLASS: System.Data.SqlTypes.SqlChars
TYPE:  class
TOKEN: 0x20000A3
FIELDS:
  private           System.Char[]                   _rgchBuf  // 0x10
  private           System.Int64                    _lCurLen  // 0x18
  private           System.Data.SqlTypes.SqlStreamChars_stream  // 0x20
  private           System.Data.SqlTypes.SqlBytesCharsState_state  // 0x28
  private           System.Char[]                   _rgchWorkBuf  // 0x30
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Char[] buffer)
  System.Void .ctor(System.Data.SqlTypes.SqlString value)
  System.Boolean get_IsNull()
  System.Char[] get_Buffer()
  System.Int64 get_Length()
  System.Char[] get_Value()
  System.Void SetNull()
  System.Boolean FStream()
  System.Void CopyStreamToBuffer()
  System.Void SetBuffer(System.Char[] buffer)
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Data.SqlTypes.SqlChars get_Null()
END_CLASS

CLASS: System.Data.SqlTypes.SqlDateTime
TYPE:  struct
TOKEN: 0x20000A4
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Int32                    m_day  // 0x14
  private           System.Int32                    m_time  // 0x18
  private   static readonly System.Double                   s_SQLTicksPerMillisecond  // 0x0
  public    static readonly System.Int32                    SQLTicksPerSecond  // 0x8
  public    static readonly System.Int32                    SQLTicksPerMinute  // 0xC
  public    static readonly System.Int32                    SQLTicksPerHour  // 0x10
  private   static readonly System.Int32                    s_SQLTicksPerDay  // 0x14
  private   static readonly System.Int64                    s_ticksPerSecond  // 0x18
  private   static readonly System.DateTime                 s_SQLBaseDate  // 0x20
  private   static readonly System.Int64                    s_SQLBaseDateTicks  // 0x28
  private   static readonly System.Int32                    s_minYear  // 0x30
  private   static readonly System.Int32                    s_maxYear  // 0x34
  private   static readonly System.Int32                    s_minDay  // 0x38
  private   static readonly System.Int32                    s_maxDay  // 0x3C
  private   static readonly System.Int32                    s_minTime  // 0x40
  private   static readonly System.Int32                    s_maxTime  // 0x44
  private   static readonly System.Int32                    s_dayBase  // 0x48
  private   static readonly System.Int32[]                  s_daysToMonth365  // 0x50
  private   static readonly System.Int32[]                  s_daysToMonth366  // 0x58
  private   static readonly System.DateTime                 s_minDateTime  // 0x60
  private   static readonly System.DateTime                 s_maxDateTime  // 0x68
  private   static readonly System.TimeSpan                 s_minTimeSpan  // 0x70
  private   static readonly System.TimeSpan                 s_maxTimeSpan  // 0x78
  private   static readonly System.String                   s_ISO8601_DateTimeFormat  // 0x80
  private   static readonly System.String[]                 s_dateTimeFormats  // 0x88
  public    static readonly System.Data.SqlTypes.SqlDateTimeMinValue  // 0x90
  public    static readonly System.Data.SqlTypes.SqlDateTimeMaxValue  // 0x9C
  public    static readonly System.Data.SqlTypes.SqlDateTimeNull  // 0xA8
METHODS:
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.DateTime value)
  System.Void .ctor(System.Int32 dayTicks, System.Int32 timeTicks)
  System.Boolean get_IsNull()
  System.TimeSpan ToTimeSpan(System.Data.SqlTypes.SqlDateTime value)
  System.DateTime ToDateTime(System.Data.SqlTypes.SqlDateTime value)
  System.Data.SqlTypes.SqlDateTime FromTimeSpan(System.TimeSpan value)
  System.Data.SqlTypes.SqlDateTime FromDateTime(System.DateTime value)
  System.DateTime get_Value()
  System.Int32 get_DayTicks()
  System.Int32 get_TimeTicks()
  System.Data.SqlTypes.SqlDateTime op_Implicit(System.DateTime value)
  System.String ToString()
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y)
  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y)
  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y)
  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y)
  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y)
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlDateTime value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlDecimal
TYPE:  struct
TOKEN: 0x20000A5
FIELDS:
  private           System.Byte                     _bStatus  // 0x10
  private           System.Byte                     _bLen  // 0x11
  private           System.Byte                     _bPrec  // 0x12
  private           System.Byte                     _bScale  // 0x13
  private           System.UInt32                   _data1  // 0x14
  private           System.UInt32                   _data2  // 0x18
  private           System.UInt32                   _data3  // 0x1C
  private           System.UInt32                   _data4  // 0x20
  private   static readonly System.Byte                     s_NUMERIC_MAX_PRECISION  // 0x0
  public    static readonly System.Byte                     MaxPrecision  // 0x1
  public    static readonly System.Byte                     MaxScale  // 0x2
  private   static readonly System.Byte                     s_bNullMask  // 0x3
  private   static readonly System.Byte                     s_bIsNull  // 0x4
  private   static readonly System.Byte                     s_bNotNull  // 0x5
  private   static readonly System.Byte                     s_bReverseNullMask  // 0x6
  private   static readonly System.Byte                     s_bSignMask  // 0x7
  private   static readonly System.Byte                     s_bPositive  // 0x8
  private   static readonly System.Byte                     s_bNegative  // 0x9
  private   static readonly System.Byte                     s_bReverseSignMask  // 0xA
  private   static readonly System.UInt32                   s_uiZero  // 0xC
  private   static readonly System.Int32                    s_cNumeMax  // 0x10
  private   static readonly System.Int64                    s_lInt32Base  // 0x18
  private   static readonly System.UInt64                   s_ulInt32Base  // 0x20
  private   static readonly System.UInt64                   s_ulInt32BaseForMod  // 0x28
  private   static readonly System.UInt64                   s_llMax  // 0x30
  private   static readonly System.UInt32                   s_ulBase10  // 0x38
  private   static readonly System.Double                   s_DUINT_BASE  // 0x40
  private   static readonly System.Double                   s_DUINT_BASE2  // 0x48
  private   static readonly System.Double                   s_DUINT_BASE3  // 0x50
  private   static readonly System.Double                   s_DMAX_NUME  // 0x58
  private   static readonly System.UInt32                   s_DBL_DIG  // 0x60
  private   static readonly System.Byte                     s_cNumeDivScaleMin  // 0x64
  private   static readonly System.UInt32[]                 s_rgulShiftBase  // 0x68
  private   static readonly System.UInt32[]                 s_decimalHelpersLo  // 0x70
  private   static readonly System.UInt32[]                 s_decimalHelpersMid  // 0x78
  private   static readonly System.UInt32[]                 s_decimalHelpersHi  // 0x80
  private   static readonly System.UInt32[]                 s_decimalHelpersHiHi  // 0x88
  private   static readonly System.Byte[]                   s_rgCLenFromPrec  // 0x90
  private   static readonly System.UInt32                   s_ulT1  // 0x98
  private   static readonly System.UInt32                   s_ulT2  // 0x9C
  private   static readonly System.UInt32                   s_ulT3  // 0xA0
  private   static readonly System.UInt32                   s_ulT4  // 0xA4
  private   static readonly System.UInt32                   s_ulT5  // 0xA8
  private   static readonly System.UInt32                   s_ulT6  // 0xAC
  private   static readonly System.UInt32                   s_ulT7  // 0xB0
  private   static readonly System.UInt32                   s_ulT8  // 0xB4
  private   static readonly System.UInt32                   s_ulT9  // 0xB8
  private   static readonly System.UInt64                   s_dwlT10  // 0xC0
  private   static readonly System.UInt64                   s_dwlT11  // 0xC8
  private   static readonly System.UInt64                   s_dwlT12  // 0xD0
  private   static readonly System.UInt64                   s_dwlT13  // 0xD8
  private   static readonly System.UInt64                   s_dwlT14  // 0xE0
  private   static readonly System.UInt64                   s_dwlT15  // 0xE8
  private   static readonly System.UInt64                   s_dwlT16  // 0xF0
  private   static readonly System.UInt64                   s_dwlT17  // 0xF8
  private   static readonly System.UInt64                   s_dwlT18  // 0x100
  private   static readonly System.UInt64                   s_dwlT19  // 0x108
  public    static readonly System.Data.SqlTypes.SqlDecimal Null  // 0x110
  public    static readonly System.Data.SqlTypes.SqlDecimal MinValue  // 0x124
  public    static readonly System.Data.SqlTypes.SqlDecimal MaxValue  // 0x138
METHODS:
  System.Byte CalculatePrecision()
  System.Boolean VerifyPrecision(System.Byte precision)
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.Decimal value)
  System.Void .ctor(System.Int32 value)
  System.Void .ctor(System.Int64 value)
  System.Void .ctor(System.UInt32[] rglData, System.Byte bLen, System.Byte bPrec, System.Byte bScale, System.Boolean fPositive)
  System.Boolean get_IsNull()
  System.Decimal get_Value()
  System.Boolean get_IsPositive()
  System.Void SetPositive()
  System.Void SetSignBit(System.Boolean fPositive)
  System.Byte get_Scale()
  System.Int32[] get_Data()
  System.String ToString()
  System.Data.SqlTypes.SqlDecimal Parse(System.String s)
  System.Double ToDouble()
  System.Decimal ToDecimal()
  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Decimal x)
  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Int64 x)
  System.Data.SqlTypes.SqlDecimal op_UnaryNegation(System.Data.SqlTypes.SqlDecimal x)
  System.Data.SqlTypes.SqlDecimal op_Addition(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  System.Data.SqlTypes.SqlDecimal op_Subtraction(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  System.Data.SqlTypes.SqlDecimal op_Multiply(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  System.Data.SqlTypes.SqlDecimal op_Division(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlByte x)
  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt32 x)
  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlInt64 x)
  System.Data.SqlTypes.SqlDecimal op_Implicit(System.Data.SqlTypes.SqlMoney x)
  System.Void ZeroToMaxLen(System.UInt32[] rgulData, System.Int32 cUI4sCur)
  System.Boolean FZero()
  System.Boolean FGt10_38()
  System.Boolean FGt10_38(System.UInt32[] rglData)
  System.Byte BGetPrecUI4(System.UInt32 value)
  System.Byte BGetPrecUI8(System.UInt64 dwlVal)
  System.Void AddULong(System.UInt32 ulAdd)
  System.Void MultByULong(System.UInt32 uiMultiplier)
  System.UInt32 DivByULong(System.UInt32 iDivisor)
  System.Void AdjustScale(System.Int32 digits, System.Boolean fRound)
  System.Int32 LAbsCmp(System.Data.SqlTypes.SqlDecimal snumOp)
  System.Void MpMove(System.UInt32[] rgulS, System.Int32 ciulS, System.UInt32[] rgulD, System.Int32& ciulD)
  System.Void MpSet(System.UInt32[] rgulD, System.Int32& ciulD, System.UInt32 iulN)
  System.Void MpNormalize(System.UInt32[] rgulU, System.Int32& ciulU)
  System.Void MpMul1(System.UInt32[] piulD, System.Int32& ciulD, System.UInt32 iulX)
  System.Void MpDiv1(System.UInt32[] rgulU, System.Int32& ciulU, System.UInt32 iulD, System.UInt32& iulR)
  System.UInt64 DWL(System.UInt32 lo, System.UInt32 hi)
  System.UInt32 HI(System.UInt64 x)
  System.UInt32 LO(System.UInt64 x)
  System.Void MpDiv(System.UInt32[] rgulU, System.Int32 ciulU, System.UInt32[] rgulD, System.Int32 ciulD, System.UInt32[] rgulQ, System.Int32& ciulQ, System.UInt32[] rgulR, System.Int32& ciulR)
  System.Data.SqlTypes.EComparison CompareNm(System.Data.SqlTypes.SqlDecimal snumOp)
  System.Void CheckValidPrecScale(System.Byte bPrec, System.Byte bScale)
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y)
  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  System.Data.SqlTypes.SqlInt64 ToSqlInt64()
  System.Data.SqlTypes.SqlMoney ToSqlMoney()
  System.Char ChFromDigit(System.UInt32 uiDigit)
  System.Void StoreFromWorkingArray(System.UInt32[] rguiData)
  System.Void SetToZero()
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlDecimal value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlDouble
TYPE:  struct
TOKEN: 0x20000A6
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Double                   m_value  // 0x18
  public    static readonly System.Data.SqlTypes.SqlDouble  Null  // 0x0
  public    static readonly System.Data.SqlTypes.SqlDouble  Zero  // 0x10
  public    static readonly System.Data.SqlTypes.SqlDouble  MinValue  // 0x20
  public    static readonly System.Data.SqlTypes.SqlDouble  MaxValue  // 0x30
METHODS:
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.Double value)
  System.Boolean get_IsNull()
  System.Double get_Value()
  System.Data.SqlTypes.SqlDouble op_Implicit(System.Double x)
  System.String ToString()
  System.Data.SqlTypes.SqlDouble op_UnaryNegation(System.Data.SqlTypes.SqlDouble x)
  System.Data.SqlTypes.SqlDouble op_Addition(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  System.Data.SqlTypes.SqlDouble op_Subtraction(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  System.Data.SqlTypes.SqlDouble op_Multiply(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  System.Data.SqlTypes.SqlDouble op_Division(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlByte x)
  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt32 x)
  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlInt64 x)
  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlSingle x)
  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlMoney x)
  System.Data.SqlTypes.SqlDouble op_Implicit(System.Data.SqlTypes.SqlDecimal x)
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y)
  System.Data.SqlTypes.SqlSingle ToSqlSingle()
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlDouble value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlGuid
TYPE:  struct
TOKEN: 0x20000A7
FIELDS:
  private   static readonly System.Int32                    s_sizeOfGuid  // 0x0
  private   static readonly System.Int32[]                  s_rgiGuidOrder  // 0x8
  private           System.Byte[]                   m_value  // 0x10
  public    static readonly System.Data.SqlTypes.SqlGuid    Null  // 0x10
METHODS:
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.Guid g)
  System.Boolean get_IsNull()
  System.Guid get_Value()
  System.Data.SqlTypes.SqlGuid op_Implicit(System.Guid x)
  System.String ToString()
  System.Data.SqlTypes.EComparison Compare(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y)
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y)
  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y)
  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y)
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlGuid value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlInt16
TYPE:  struct
TOKEN: 0x20000A8
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Int16                    m_value  // 0x12
  private   static readonly System.Int32                    s_MASKI2  // 0x0
  public    static readonly System.Data.SqlTypes.SqlInt16   Null  // 0x4
  public    static readonly System.Data.SqlTypes.SqlInt16   Zero  // 0x8
  public    static readonly System.Data.SqlTypes.SqlInt16   MinValue  // 0xC
  public    static readonly System.Data.SqlTypes.SqlInt16   MaxValue  // 0x10
METHODS:
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.Int16 value)
  System.Boolean get_IsNull()
  System.Int16 get_Value()
  System.Data.SqlTypes.SqlInt16 op_Implicit(System.Int16 x)
  System.String ToString()
  System.Data.SqlTypes.SqlInt16 op_UnaryNegation(System.Data.SqlTypes.SqlInt16 x)
  System.Data.SqlTypes.SqlInt16 op_Addition(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  System.Data.SqlTypes.SqlInt16 op_Subtraction(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  System.Data.SqlTypes.SqlInt16 op_Multiply(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  System.Data.SqlTypes.SqlInt16 op_Division(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  System.Data.SqlTypes.SqlInt16 op_Implicit(System.Data.SqlTypes.SqlByte x)
  System.Data.SqlTypes.SqlInt16 op_Explicit(System.Data.SqlTypes.SqlInt64 x)
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y)
  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  System.Data.SqlTypes.SqlInt64 ToSqlInt64()
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlInt16 value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlInt32
TYPE:  struct
TOKEN: 0x20000A9
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Int32                    m_value  // 0x14
  private   static readonly System.Int64                    s_iIntMin  // 0x0
  private   static readonly System.Int64                    s_lBitNotIntMax  // 0x8
  public    static readonly System.Data.SqlTypes.SqlInt32   Null  // 0x10
  public    static readonly System.Data.SqlTypes.SqlInt32   Zero  // 0x18
  public    static readonly System.Data.SqlTypes.SqlInt32   MinValue  // 0x20
  public    static readonly System.Data.SqlTypes.SqlInt32   MaxValue  // 0x28
METHODS:
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.Int32 value)
  System.Boolean get_IsNull()
  System.Int32 get_Value()
  System.Data.SqlTypes.SqlInt32 op_Implicit(System.Int32 x)
  System.String ToString()
  System.Data.SqlTypes.SqlInt32 op_UnaryNegation(System.Data.SqlTypes.SqlInt32 x)
  System.Data.SqlTypes.SqlInt32 op_Addition(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  System.Data.SqlTypes.SqlInt32 op_Subtraction(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  System.Data.SqlTypes.SqlInt32 op_Multiply(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  System.Data.SqlTypes.SqlInt32 op_Division(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlByte x)
  System.Data.SqlTypes.SqlInt32 op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  System.Data.SqlTypes.SqlInt32 op_Explicit(System.Data.SqlTypes.SqlInt64 x)
  System.Boolean SameSignInt(System.Int32 x, System.Int32 y)
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y)
  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  System.Data.SqlTypes.SqlInt64 ToSqlInt64()
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlInt32 value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlInt64
TYPE:  struct
TOKEN: 0x20000AA
FIELDS:
  private           System.Boolean                  m_fNotNull  // 0x10
  private           System.Int64                    m_value  // 0x18
  private   static readonly System.Int64                    s_lLowIntMask  // 0x0
  private   static readonly System.Int64                    s_lHighIntMask  // 0x8
  public    static readonly System.Data.SqlTypes.SqlInt64   Null  // 0x10
  public    static readonly System.Data.SqlTypes.SqlInt64   Zero  // 0x20
  public    static readonly System.Data.SqlTypes.SqlInt64   MinValue  // 0x30
  public    static readonly System.Data.SqlTypes.SqlInt64   MaxValue  // 0x40
METHODS:
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.Int64 value)
  System.Boolean get_IsNull()
  System.Int64 get_Value()
  System.Data.SqlTypes.SqlInt64 op_Implicit(System.Int64 x)
  System.String ToString()
  System.Data.SqlTypes.SqlInt64 op_UnaryNegation(System.Data.SqlTypes.SqlInt64 x)
  System.Data.SqlTypes.SqlInt64 op_Addition(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  System.Data.SqlTypes.SqlInt64 op_Subtraction(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  System.Data.SqlTypes.SqlInt64 op_Multiply(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  System.Data.SqlTypes.SqlInt64 op_Division(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  System.Data.SqlTypes.SqlInt64 op_Modulus(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlByte x)
  System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  System.Data.SqlTypes.SqlInt64 op_Implicit(System.Data.SqlTypes.SqlInt32 x)
  System.Data.SqlTypes.SqlInt64 op_Explicit(System.Data.SqlTypes.SqlDecimal x)
  System.Boolean SameSignLong(System.Int64 x, System.Int64 y)
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y)
  System.Data.SqlTypes.SqlByte ToSqlByte()
  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  System.Data.SqlTypes.SqlInt16 ToSqlInt16()
  System.Data.SqlTypes.SqlInt32 ToSqlInt32()
  System.Data.SqlTypes.SqlDecimal ToSqlDecimal()
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlInt64 value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlMoney
TYPE:  struct
TOKEN: 0x20000AB
FIELDS:
  private           System.Boolean                  _fNotNull  // 0x10
  private           System.Int64                    _value  // 0x18
  private   static readonly System.Int32                    s_iMoneyScale  // 0x0
  private   static readonly System.Int64                    s_lTickBase  // 0x8
  private   static readonly System.Double                   s_dTickBase  // 0x10
  private   static readonly System.Int64                    s_minLong  // 0x18
  private   static readonly System.Int64                    s_maxLong  // 0x20
  public    static readonly System.Data.SqlTypes.SqlMoney   Null  // 0x28
  public    static readonly System.Data.SqlTypes.SqlMoney   Zero  // 0x38
  public    static readonly System.Data.SqlTypes.SqlMoney   MinValue  // 0x48
  public    static readonly System.Data.SqlTypes.SqlMoney   MaxValue  // 0x58
METHODS:
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.Int64 value, System.Int32 ignored)
  System.Void .ctor(System.Int32 value)
  System.Void .ctor(System.Int64 value)
  System.Void .ctor(System.Decimal value)
  System.Boolean get_IsNull()
  System.Decimal get_Value()
  System.Decimal ToDecimal()
  System.Double ToDouble()
  System.Data.SqlTypes.SqlMoney op_Implicit(System.Decimal x)
  System.Data.SqlTypes.SqlMoney op_Implicit(System.Int64 x)
  System.String ToString()
  System.Data.SqlTypes.SqlMoney op_UnaryNegation(System.Data.SqlTypes.SqlMoney x)
  System.Data.SqlTypes.SqlMoney op_Addition(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  System.Data.SqlTypes.SqlMoney op_Subtraction(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  System.Data.SqlTypes.SqlMoney op_Multiply(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  System.Data.SqlTypes.SqlMoney op_Division(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlByte x)
  System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt32 x)
  System.Data.SqlTypes.SqlMoney op_Implicit(System.Data.SqlTypes.SqlInt64 x)
  System.Data.SqlTypes.SqlMoney op_Explicit(System.Data.SqlTypes.SqlDecimal x)
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y)
  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  System.Data.SqlTypes.SqlDecimal ToSqlDecimal()
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlMoney value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlSingle
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  private           System.Boolean                  _fNotNull  // 0x10
  private           System.Single                   _value  // 0x14
  public    static readonly System.Data.SqlTypes.SqlSingle  Null  // 0x0
  public    static readonly System.Data.SqlTypes.SqlSingle  Zero  // 0x8
  public    static readonly System.Data.SqlTypes.SqlSingle  MinValue  // 0x10
  public    static readonly System.Data.SqlTypes.SqlSingle  MaxValue  // 0x18
METHODS:
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.Single value)
  System.Void .ctor(System.Double value)
  System.Boolean get_IsNull()
  System.Single get_Value()
  System.Data.SqlTypes.SqlSingle op_Implicit(System.Single x)
  System.String ToString()
  System.Data.SqlTypes.SqlSingle op_UnaryNegation(System.Data.SqlTypes.SqlSingle x)
  System.Data.SqlTypes.SqlSingle op_Addition(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  System.Data.SqlTypes.SqlSingle op_Subtraction(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  System.Data.SqlTypes.SqlSingle op_Multiply(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  System.Data.SqlTypes.SqlSingle op_Division(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlByte x)
  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt16 x)
  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt32 x)
  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlInt64 x)
  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlMoney x)
  System.Data.SqlTypes.SqlSingle op_Implicit(System.Data.SqlTypes.SqlDecimal x)
  System.Data.SqlTypes.SqlSingle op_Explicit(System.Data.SqlTypes.SqlDouble x)
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  System.Data.SqlTypes.SqlBoolean op_LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  System.Data.SqlTypes.SqlBoolean op_GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y)
  System.Data.SqlTypes.SqlDouble ToSqlDouble()
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlSingle value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlCompareOptions
TYPE:  struct
TOKEN: 0x20000AD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SqlTypes.SqlCompareOptionsNone  // 0x0
  public    static  System.Data.SqlTypes.SqlCompareOptionsIgnoreCase  // 0x0
  public    static  System.Data.SqlTypes.SqlCompareOptionsIgnoreNonSpace  // 0x0
  public    static  System.Data.SqlTypes.SqlCompareOptionsIgnoreKanaType  // 0x0
  public    static  System.Data.SqlTypes.SqlCompareOptionsIgnoreWidth  // 0x0
  public    static  System.Data.SqlTypes.SqlCompareOptionsBinarySort  // 0x0
  public    static  System.Data.SqlTypes.SqlCompareOptionsBinarySort2  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.SqlTypes.SqlString
TYPE:  struct
TOKEN: 0x20000AE
FIELDS:
  private           System.String                   m_value  // 0x10
  private           System.Globalization.CompareInfom_cmpInfo  // 0x18
  private           System.Int32                    m_lcid  // 0x20
  private           System.Data.SqlTypes.SqlCompareOptionsm_flag  // 0x24
  private           System.Boolean                  m_fNotNull  // 0x28
  public    static readonly System.Data.SqlTypes.SqlString  Null  // 0x0
  private   static readonly System.Text.UnicodeEncoding     s_unicodeEncoding  // 0x20
  public    static readonly System.Int32                    IgnoreCase  // 0x28
  public    static readonly System.Int32                    IgnoreWidth  // 0x2C
  public    static readonly System.Int32                    IgnoreNonSpace  // 0x30
  public    static readonly System.Int32                    IgnoreKanaType  // 0x34
  public    static readonly System.Int32                    BinarySort  // 0x38
  public    static readonly System.Int32                    BinarySort2  // 0x3C
  private   static readonly System.Data.SqlTypes.SqlCompareOptionss_iDefaultFlag  // 0x40
  private   static readonly System.Globalization.CompareOptionss_iValidCompareOptionMask  // 0x44
  private   static readonly System.Data.SqlTypes.SqlCompareOptionss_iValidSqlCompareOptionMask  // 0x48
  private   static readonly System.Int32                    s_lcidUSEnglish  // 0x4C
  private   static readonly System.Int32                    s_lcidBinary  // 0x50
METHODS:
  System.Void .ctor(System.Boolean fNull)
  System.Void .ctor(System.String data, System.Int32 lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions)
  System.Void .ctor(System.String data)
  System.Void .ctor(System.Int32 lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, System.String data, System.Globalization.CompareInfo cmpInfo)
  System.Boolean get_IsNull()
  System.String get_Value()
  System.Void SetCompareInfo()
  System.Data.SqlTypes.SqlString op_Implicit(System.String x)
  System.String ToString()
  System.Data.SqlTypes.SqlString op_Addition(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y)
  System.Int32 StringCompare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y)
  System.Data.SqlTypes.SqlBoolean Compare(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y, System.Data.SqlTypes.EComparison ecExpectedResult)
  System.Data.SqlTypes.SqlBoolean op_Equality(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y)
  System.Void ValidateSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions)
  System.Globalization.CompareOptions CompareOptionsFromSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions)
  System.Boolean FBinarySort()
  System.Int32 CompareBinary(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y)
  System.Int32 CompareBinary2(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y)
  System.Int32 CompareTo(System.Object value)
  System.Int32 CompareTo(System.Data.SqlTypes.SqlString value)
  System.Boolean Equals(System.Object value)
  System.Int32 GetHashCode()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.EComparison
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Data.SqlTypes.EComparisonLT  // 0x0
  public    static  System.Data.SqlTypes.EComparisonLE  // 0x0
  public    static  System.Data.SqlTypes.EComparisonEQ  // 0x0
  public    static  System.Data.SqlTypes.EComparisonGE  // 0x0
  public    static  System.Data.SqlTypes.EComparisonGT  // 0x0
  public    static  System.Data.SqlTypes.EComparisonNE  // 0x0
METHODS:
END_CLASS

CLASS: System.Data.SqlTypes.SqlTypeException
TYPE:  class
TOKEN: 0x20000B0
EXTENDS: SystemException
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception e)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
  System.Runtime.Serialization.SerializationInfo SqlTypeExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
END_CLASS

CLASS: System.Data.SqlTypes.SqlNullValueException
TYPE:  class
TOKEN: 0x20000B1
EXTENDS: SqlTypeException
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception e)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
  System.Runtime.Serialization.SerializationInfo SqlNullValueExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
END_CLASS

CLASS: System.Data.SqlTypes.SqlTruncateException
TYPE:  class
TOKEN: 0x20000B2
EXTENDS: SqlTypeException
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception e)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
  System.Runtime.Serialization.SerializationInfo SqlTruncateExceptionSerialization(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc)
END_CLASS

CLASS: System.Data.SqlTypes.SqlStreamChars
TYPE:  class
TOKEN: 0x20000B3
FIELDS:
METHODS:
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Int32 Read(System.Char[] buffer, System.Int32 offset, System.Int32 count)
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
END_CLASS

CLASS: System.Data.SqlTypes.SqlXml
TYPE:  class
TOKEN: 0x20000B4
FIELDS:
  private   static readonly System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader>s_sqlReaderDelegate  // 0x0
  private   static readonly System.Xml.XmlReaderSettings    s_defaultXmlReaderSettings  // 0x8
  private   static readonly System.Xml.XmlReaderSettings    s_defaultXmlReaderSettingsCloseInput  // 0x10
  private   static  System.Reflection.MethodInfo    s_createSqlReaderMethodInfo  // 0x18
  private           System.Reflection.MethodInfo    _createSqlReaderMethodInfo  // 0x10
  private           System.Boolean                  _fNotNull  // 0x18
  private           System.IO.Stream                _stream  // 0x20
  private           System.Boolean                  _firstCreateReader  // 0x28
METHODS:
  System.Void .ctor()
  System.Xml.XmlReader CreateReader()
  System.Xml.XmlReader CreateSqlXmlReader(System.IO.Stream stream, System.Boolean closeInput, System.Boolean throwTargetInvocationExceptions)
  System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> CreateSqlReaderDelegate()
  System.Reflection.MethodInfo get_CreateSqlReaderMethodInfo()
  System.Boolean get_IsNull()
  System.Void SetNull()
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void .cctor()
END_CLASS

CLASS: System.Data.SqlTypes.SqlXmlStreamWrapper
TYPE:  class
TOKEN: 0x20000B5
EXTENDS: Stream
FIELDS:
  private           System.IO.Stream                _stream  // 0x28
  private           System.Int64                    _lPosition  // 0x30
  private           System.Boolean                  _isClosed  // 0x38
METHODS:
  System.Void .ctor(System.IO.Stream stream)
  System.Boolean get_CanRead()
  System.Boolean get_CanSeek()
  System.Boolean get_CanWrite()
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Int32 ReadByte()
  System.Void WriteByte(System.Byte value)
  System.Void SetLength(System.Int64 value)
  System.Void Flush()
  System.Void Dispose(System.Boolean disposing)
  System.Void ThrowIfStreamCannotSeek(System.String method)
  System.Void ThrowIfStreamCannotRead(System.String method)
  System.Void ThrowIfStreamCannotWrite(System.String method)
  System.Void ThrowIfStreamClosed(System.String method)
  System.Boolean IsStreamClosed()
END_CLASS

