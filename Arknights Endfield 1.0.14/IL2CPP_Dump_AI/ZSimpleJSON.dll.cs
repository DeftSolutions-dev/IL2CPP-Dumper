// ========================================================
// Dumped by @desirepro
// Assembly: ZSimpleJSON.dll
// Classes:  23
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Type
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ZSimpleJSON.JSONNode.Enumerator.TypeNone  // 0x0
  public    static  ZSimpleJSON.JSONNode.Enumerator.TypeArray  // 0x0
  public    static  ZSimpleJSON.JSONNode.Enumerator.TypeObject  // 0x0
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  private           ZSimpleJSON.JSONNode.Enumerator.Typetype  // 0x10
  private           System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode>m_Object  // 0x18
  private           System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode>m_Array  // 0x40
METHODS:
  System.Boolean get_IsValid()
  System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum)
  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum)
  System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> get_Current()
  System.Boolean MoveNext()
END_CLASS

CLASS: ValueEnumerator
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  private           ZSimpleJSON.JSONNode.Enumerator m_Enumerator  // 0x10
METHODS:
  System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum)
  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum)
  System.Void .ctor(ZSimpleJSON.JSONNode.Enumerator aEnumerator)
  ZSimpleJSON.JSONNode get_Current()
  System.Boolean MoveNext()
  ZSimpleJSON.JSONNode.ValueEnumerator GetEnumerator()
END_CLASS

CLASS: KeyEnumerator
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  private           ZSimpleJSON.JSONNode.Enumerator m_Enumerator  // 0x10
METHODS:
  System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum)
  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum)
  System.Void .ctor(ZSimpleJSON.JSONNode.Enumerator aEnumerator)
  System.String get_Current()
  System.Boolean MoveNext()
  ZSimpleJSON.JSONNode.KeyEnumerator GetEnumerator()
END_CLASS

CLASS: LinqEnumerator
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private           ZSimpleJSON.JSONNode            m_Node  // 0x10
  private           ZSimpleJSON.JSONNode.Enumerator m_Enumerator  // 0x18
METHODS:
  System.Void .ctor(ZSimpleJSON.JSONNode aNode)
  System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean MoveNext()
  System.Void Dispose()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode>> GetEnumerator()
  System.Void Reset()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: ZSimpleJSON.JSONNode
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  public    static  System.Byte                     Color32DefaultAlpha  // 0x0
  public    static  System.Single                   ColorDefaultAlpha  // 0x4
  public    static  ZSimpleJSON.JSONContainerType   VectorContainerType  // 0x8
  public    static  ZSimpleJSON.JSONContainerType   QuaternionContainerType  // 0xC
  public    static  ZSimpleJSON.JSONContainerType   RectContainerType  // 0x10
  public    static  ZSimpleJSON.JSONContainerType   ColorContainerType  // 0x14
  public    static  System.Boolean                  forceASCII  // 0x18
  public    static  System.Boolean                  longAsString  // 0x19
  public    static  System.Boolean                  allowLineComments  // 0x1A
  private   static  System.Text.StringBuilder       m_EscapeBuilder  // 0xFFFFFFFF
METHODS:
  System.Decimal get_AsDecimal()
  System.Void set_AsDecimal(System.Decimal value)
  ZSimpleJSON.JSONNode op_Implicit(System.Decimal aDecimal)
  System.Decimal op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.Char get_AsChar()
  System.Void set_AsChar(System.Char value)
  ZSimpleJSON.JSONNode op_Implicit(System.Char aChar)
  System.Char op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.UInt32 get_AsUInt()
  System.Void set_AsUInt(System.UInt32 value)
  ZSimpleJSON.JSONNode op_Implicit(System.UInt32 aUInt)
  System.UInt32 op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.Byte get_AsByte()
  System.Void set_AsByte(System.Byte value)
  ZSimpleJSON.JSONNode op_Implicit(System.Byte aByte)
  System.Byte op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.SByte get_AsSByte()
  System.Void set_AsSByte(System.SByte value)
  ZSimpleJSON.JSONNode op_Implicit(System.SByte aSByte)
  System.SByte op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.Int16 get_AsShort()
  System.Void set_AsShort(System.Int16 value)
  ZSimpleJSON.JSONNode op_Implicit(System.Int16 aShort)
  System.Int16 op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.UInt16 get_AsUShort()
  System.Void set_AsUShort(System.UInt16 value)
  ZSimpleJSON.JSONNode op_Implicit(System.UInt16 aUShort)
  System.UInt16 op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.DateTime get_AsDateTime()
  System.Void set_AsDateTime(System.DateTime value)
  ZSimpleJSON.JSONNode op_Implicit(System.DateTime aDateTime)
  System.DateTime op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.TimeSpan get_AsTimeSpan()
  System.Void set_AsTimeSpan(System.TimeSpan value)
  ZSimpleJSON.JSONNode op_Implicit(System.TimeSpan aTimeSpan)
  System.TimeSpan op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.Guid get_AsGuid()
  System.Void set_AsGuid(System.Guid value)
  ZSimpleJSON.JSONNode op_Implicit(System.Guid aGuid)
  System.Guid op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.Byte[] get_AsByteArray()
  System.Void set_AsByteArray(System.Byte[] value)
  ZSimpleJSON.JSONNode op_Implicit(System.Byte[] aByteArray)
  System.Byte[] op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.Collections.Generic.List<System.Byte> get_AsByteList()
  System.Void set_AsByteList(System.Collections.Generic.List<System.Byte> value)
  ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.List<System.Byte> aByteList)
  System.Collections.Generic.List<System.Byte> op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.UInt64[] get_AsUlongArray()
  System.Void set_AsUlongArray(System.UInt64[] value)
  ZSimpleJSON.JSONNode op_Implicit(System.UInt64[] aStringArray)
  System.UInt64[] op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.String[] get_AsStringArray()
  System.Void set_AsStringArray(System.String[] value)
  ZSimpleJSON.JSONNode op_Implicit(System.String[] aStringArray)
  System.String[] op_Implicit(ZSimpleJSON.JSONNode aNode)
  System.Collections.Generic.List<System.String> get_AsStringList()
  System.Void set_AsStringList(System.Collections.Generic.List<System.String> value)
  ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.List<System.String> aStringList)
  System.Collections.Generic.List<System.String> op_Implicit(ZSimpleJSON.JSONNode aNode)
  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int32> aValue)
  System.Nullable<System.Int32> op_Implicit(ZSimpleJSON.JSONNode aNode)
  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Single> aValue)
  System.Nullable<System.Single> op_Implicit(ZSimpleJSON.JSONNode aNode)
  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Double> aValue)
  System.Nullable<System.Double> op_Implicit(ZSimpleJSON.JSONNode aNode)
  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Boolean> aValue)
  System.Nullable<System.Boolean> op_Implicit(ZSimpleJSON.JSONNode aNode)
  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int64> aValue)
  System.Nullable<System.Int64> op_Implicit(ZSimpleJSON.JSONNode aNode)
  ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int16> aValue)
  System.Nullable<System.Int16> op_Implicit(ZSimpleJSON.JSONNode aNode)
  ZSimpleJSON.JSONNode GetContainer(ZSimpleJSON.JSONContainerType aType)
  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector2 aVec)
  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector3 aVec)
  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector4 aVec)
  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Color aCol)
  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Color32 aCol)
  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Quaternion aRot)
  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Rect aRect)
  ZSimpleJSON.JSONNode op_Implicit(UnityEngine.RectOffset aRect)
  UnityEngine.Vector2 op_Implicit(ZSimpleJSON.JSONNode aNode)
  UnityEngine.Vector3 op_Implicit(ZSimpleJSON.JSONNode aNode)
  UnityEngine.Vector4 op_Implicit(ZSimpleJSON.JSONNode aNode)
  UnityEngine.Color op_Implicit(ZSimpleJSON.JSONNode aNode)
  UnityEngine.Color32 op_Implicit(ZSimpleJSON.JSONNode aNode)
  UnityEngine.Quaternion op_Implicit(ZSimpleJSON.JSONNode aNode)
  UnityEngine.Rect op_Implicit(ZSimpleJSON.JSONNode aNode)
  UnityEngine.RectOffset op_Implicit(ZSimpleJSON.JSONNode aNode)
  UnityEngine.Vector2 ReadVector2(UnityEngine.Vector2 aDefault)
  UnityEngine.Vector2 ReadVector2(System.String aXName, System.String aYName)
  UnityEngine.Vector2 ReadVector2()
  ZSimpleJSON.JSONNode WriteVector2(UnityEngine.Vector2 aVec, System.String aXName, System.String aYName)
  UnityEngine.Vector3 ReadVector3(UnityEngine.Vector3 aDefault)
  UnityEngine.Vector3 ReadVector3(System.String aXName, System.String aYName, System.String aZName)
  UnityEngine.Vector3 ReadVector3()
  ZSimpleJSON.JSONNode WriteVector3(UnityEngine.Vector3 aVec, System.String aXName, System.String aYName, System.String aZName)
  UnityEngine.Vector4 ReadVector4(UnityEngine.Vector4 aDefault)
  UnityEngine.Vector4 ReadVector4()
  ZSimpleJSON.JSONNode WriteVector4(UnityEngine.Vector4 aVec)
  UnityEngine.Color ReadColor(UnityEngine.Color aDefault)
  UnityEngine.Color ReadColor()
  ZSimpleJSON.JSONNode WriteColor(UnityEngine.Color aCol)
  UnityEngine.Color32 ReadColor32(UnityEngine.Color32 aDefault)
  UnityEngine.Color32 ReadColor32()
  ZSimpleJSON.JSONNode WriteColor32(UnityEngine.Color32 aCol)
  UnityEngine.Quaternion ReadQuaternion(UnityEngine.Quaternion aDefault)
  UnityEngine.Quaternion ReadQuaternion()
  ZSimpleJSON.JSONNode WriteQuaternion(UnityEngine.Quaternion aRot)
  UnityEngine.Rect ReadRect(UnityEngine.Rect aDefault)
  UnityEngine.Rect ReadRect()
  ZSimpleJSON.JSONNode WriteRect(UnityEngine.Rect aRect)
  UnityEngine.RectOffset ReadRectOffset(UnityEngine.RectOffset aDefault)
  UnityEngine.RectOffset ReadRectOffset()
  ZSimpleJSON.JSONNode WriteRectOffset(UnityEngine.RectOffset aRect)
  UnityEngine.Matrix4x4 ReadMatrix()
  ZSimpleJSON.JSONNode WriteMatrix(UnityEngine.Matrix4x4 aMatrix)
  ZSimpleJSON.JSONNodeType get_Tag()
  ZSimpleJSON.JSONNode get_Item(System.Int32 aIndex)
  System.Void set_Item(System.Int32 aIndex, ZSimpleJSON.JSONNode value)
  ZSimpleJSON.JSONNode get_Item(System.String aKey)
  System.Void set_Item(System.String aKey, ZSimpleJSON.JSONNode value)
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Int32 get_Count()
  System.Boolean get_IsNumber()
  System.Boolean get_IsString()
  System.Boolean get_IsBoolean()
  System.Boolean get_IsNull()
  System.Boolean get_IsArray()
  System.Boolean get_IsObject()
  System.Boolean get_Inline()
  System.Void set_Inline(System.Boolean value)
  System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem)
  System.Void Add(ZSimpleJSON.JSONNode aItem)
  ZSimpleJSON.JSONNode Remove(System.String aKey)
  ZSimpleJSON.JSONNode Remove(System.Int32 aIndex)
  ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode)
  System.Void Clear()
  ZSimpleJSON.JSONNode Clone()
  System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> get_Children()
  System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> get_DeepChildren()
  System.Boolean HasKey(System.String aKey)
  ZSimpleJSON.JSONNode GetValueOrDefault(System.String aKey, ZSimpleJSON.JSONNode aDefault)
  System.String ToString()
  System.String ToString(System.Int32 aIndent)
  System.Void ToStringBuild(System.Text.StringBuilder& sb)
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode>> get_Linq()
  ZSimpleJSON.JSONNode.KeyEnumerator get_Keys()
  ZSimpleJSON.JSONNode.ValueEnumerator get_Values()
  System.Double get_AsDouble()
  System.Void set_AsDouble(System.Double value)
  System.Int32 get_AsInt()
  System.Void set_AsInt(System.Int32 value)
  System.Single get_AsFloat()
  System.Void set_AsFloat(System.Single value)
  System.Boolean get_AsBool()
  System.Void set_AsBool(System.Boolean value)
  System.Int64 get_AsLong()
  System.Void set_AsLong(System.Int64 value)
  System.UInt64 get_AsULong()
  System.Void set_AsULong(System.UInt64 value)
  ZSimpleJSON.JSONArray get_AsArray()
  ZSimpleJSON.JSONObject get_AsObject()
  ZSimpleJSON.JSONNode op_Implicit(System.String s)
  System.String op_Implicit(ZSimpleJSON.JSONNode d)
  ZSimpleJSON.JSONNode op_Implicit(System.Double n)
  System.Double op_Implicit(ZSimpleJSON.JSONNode d)
  ZSimpleJSON.JSONNode op_Implicit(System.Single n)
  System.Single op_Implicit(ZSimpleJSON.JSONNode d)
  ZSimpleJSON.JSONNode op_Implicit(System.Int32 n)
  System.Int32 op_Implicit(ZSimpleJSON.JSONNode d)
  ZSimpleJSON.JSONNode op_Implicit(System.Int64 n)
  System.Int64 op_Implicit(ZSimpleJSON.JSONNode d)
  ZSimpleJSON.JSONNode op_Implicit(System.UInt64 n)
  System.UInt64 op_Implicit(ZSimpleJSON.JSONNode d)
  ZSimpleJSON.JSONNode op_Implicit(System.Boolean b)
  System.Boolean op_Implicit(ZSimpleJSON.JSONNode d)
  ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> aKeyValue)
  System.Boolean op_Equality(ZSimpleJSON.JSONNode a, System.Object b)
  System.Boolean op_Inequality(ZSimpleJSON.JSONNode a, System.Object b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Text.StringBuilder get_EscapeBuilder()
  System.String Escape(System.String aText)
  ZSimpleJSON.JSONNode ParseElement(System.String token, System.Boolean quoted)
  ZSimpleJSON.JSONNode Parse(System.String aJSON)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: ZSimpleJSON.JSONContainerType
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ZSimpleJSON.JSONContainerType   Array  // 0x0
  public    static  ZSimpleJSON.JSONContainerType   Object  // 0x0
METHODS:
END_CLASS

CLASS: ZSimpleJSON.JSONNodeType
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ZSimpleJSON.JSONNodeType        Array  // 0x0
  public    static  ZSimpleJSON.JSONNodeType        Object  // 0x0
  public    static  ZSimpleJSON.JSONNodeType        String  // 0x0
  public    static  ZSimpleJSON.JSONNodeType        Number  // 0x0
  public    static  ZSimpleJSON.JSONNodeType        NullValue  // 0x0
  public    static  ZSimpleJSON.JSONNodeType        Boolean  // 0x0
  public    static  ZSimpleJSON.JSONNodeType        None  // 0x0
  public    static  ZSimpleJSON.JSONNodeType        Custom  // 0x0
METHODS:
END_CLASS

CLASS: ZSimpleJSON.JSONTextMode
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ZSimpleJSON.JSONTextMode        Compact  // 0x0
  public    static  ZSimpleJSON.JSONTextMode        Indent  // 0x0
METHODS:
END_CLASS

CLASS: ZSimpleJSON.JSONArray
TYPE:  class
TOKEN: 0x200000D
EXTENDS: JSONNode
FIELDS:
  private           System.Collections.Generic.List<ZSimpleJSON.JSONNode>m_List  // 0x10
  private           System.Boolean                  inline  // 0x18
METHODS:
  System.Boolean get_Inline()
  System.Void set_Inline(System.Boolean value)
  ZSimpleJSON.JSONNodeType get_Tag()
  System.Boolean get_IsArray()
  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  ZSimpleJSON.JSONNode get_Item(System.Int32 aIndex)
  System.Void set_Item(System.Int32 aIndex, ZSimpleJSON.JSONNode value)
  ZSimpleJSON.JSONNode get_Item(System.String aKey)
  System.Void set_Item(System.String aKey, ZSimpleJSON.JSONNode value)
  System.Int32 get_Count()
  System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem)
  ZSimpleJSON.JSONNode Remove(System.Int32 aIndex)
  ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode)
  System.Void Clear()
  ZSimpleJSON.JSONNode Clone()
  System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> get_Children()
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  System.Void .ctor()
END_CLASS

CLASS: ZSimpleJSON.JSONObject
TYPE:  class
TOKEN: 0x200000F
EXTENDS: JSONNode
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,ZSimpleJSON.JSONNode>m_Dict  // 0x10
  private           System.Boolean                  inline  // 0x18
METHODS:
  System.Boolean get_Inline()
  System.Void set_Inline(System.Boolean value)
  ZSimpleJSON.JSONNodeType get_Tag()
  System.Boolean get_IsObject()
  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  ZSimpleJSON.JSONNode get_Item(System.String aKey)
  System.Void set_Item(System.String aKey, ZSimpleJSON.JSONNode value)
  ZSimpleJSON.JSONNode get_Item(System.Int32 aIndex)
  System.Void set_Item(System.Int32 aIndex, ZSimpleJSON.JSONNode value)
  System.Int32 get_Count()
  System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem)
  ZSimpleJSON.JSONNode Remove(System.String aKey)
  ZSimpleJSON.JSONNode Remove(System.Int32 aIndex)
  ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode)
  System.Void Clear()
  ZSimpleJSON.JSONNode Clone()
  System.Boolean HasKey(System.String aKey)
  ZSimpleJSON.JSONNode GetValueOrDefault(System.String aKey, ZSimpleJSON.JSONNode aDefault)
  System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> get_Children()
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  System.Void .ctor()
END_CLASS

CLASS: ZSimpleJSON.JSONString
TYPE:  class
TOKEN: 0x2000012
EXTENDS: JSONNode
FIELDS:
  private           System.String                   m_Data  // 0x10
METHODS:
  ZSimpleJSON.JSONNodeType get_Tag()
  System.Boolean get_IsString()
  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Void .ctor(System.String aData)
  ZSimpleJSON.JSONNode Clone()
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void Clear()
END_CLASS

CLASS: ZSimpleJSON.JSONNumber
TYPE:  class
TOKEN: 0x2000013
EXTENDS: JSONNode
FIELDS:
  private           System.Double                   m_Data  // 0x10
METHODS:
  ZSimpleJSON.JSONNodeType get_Tag()
  System.Boolean get_IsNumber()
  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Double get_AsDouble()
  System.Void set_AsDouble(System.Double value)
  System.Int64 get_AsLong()
  System.Void set_AsLong(System.Int64 value)
  System.UInt64 get_AsULong()
  System.Void set_AsULong(System.UInt64 value)
  System.Void .ctor(System.Double aData)
  System.Void .ctor(System.String aData)
  ZSimpleJSON.JSONNode Clone()
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  System.Boolean IsNumeric(System.Object value)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void Clear()
END_CLASS

CLASS: ZSimpleJSON.JSONBool
TYPE:  class
TOKEN: 0x2000014
EXTENDS: JSONNode
FIELDS:
  private           System.Boolean                  m_Data  // 0x10
METHODS:
  ZSimpleJSON.JSONNodeType get_Tag()
  System.Boolean get_IsBoolean()
  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Boolean get_AsBool()
  System.Void set_AsBool(System.Boolean value)
  System.Void .ctor(System.Boolean aData)
  System.Void .ctor(System.String aData)
  ZSimpleJSON.JSONNode Clone()
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void Clear()
END_CLASS

CLASS: ZSimpleJSON.JSONNull
TYPE:  class
TOKEN: 0x2000015
EXTENDS: JSONNode
FIELDS:
  private   static  ZSimpleJSON.JSONNull            m_StaticInstance  // 0x0
  public    static  System.Boolean                  reuseSameInstance  // 0x8
METHODS:
  ZSimpleJSON.JSONNull CreateOrGet()
  System.Void .ctor()
  ZSimpleJSON.JSONNodeType get_Tag()
  System.Boolean get_IsNull()
  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Boolean get_AsBool()
  System.Void set_AsBool(System.Boolean value)
  ZSimpleJSON.JSONNode Clone()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
  System.Void .cctor()
END_CLASS

CLASS: ZSimpleJSON.JSONLazyCreator
TYPE:  class
TOKEN: 0x2000016
EXTENDS: JSONNode
FIELDS:
  private           ZSimpleJSON.JSONNode            m_Node  // 0x10
  private           System.String                   m_Key  // 0x18
METHODS:
  ZSimpleJSON.JSONNodeType get_Tag()
  ZSimpleJSON.JSONNode.Enumerator GetEnumerator()
  System.Void .ctor(ZSimpleJSON.JSONNode aNode)
  System.Void .ctor(ZSimpleJSON.JSONNode aNode, System.String aKey)
  T Set(T aVal)
  ZSimpleJSON.JSONNode get_Item(System.Int32 aIndex)
  System.Void set_Item(System.Int32 aIndex, ZSimpleJSON.JSONNode value)
  ZSimpleJSON.JSONNode get_Item(System.String aKey)
  System.Void set_Item(System.String aKey, ZSimpleJSON.JSONNode value)
  System.Void Add(ZSimpleJSON.JSONNode aItem)
  System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem)
  System.Boolean op_Equality(ZSimpleJSON.JSONLazyCreator a, System.Object b)
  System.Boolean op_Inequality(ZSimpleJSON.JSONLazyCreator a, System.Object b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Int32 get_AsInt()
  System.Void set_AsInt(System.Int32 value)
  System.Single get_AsFloat()
  System.Void set_AsFloat(System.Single value)
  System.Double get_AsDouble()
  System.Void set_AsDouble(System.Double value)
  System.Int64 get_AsLong()
  System.Void set_AsLong(System.Int64 value)
  System.UInt64 get_AsULong()
  System.Void set_AsULong(System.UInt64 value)
  System.Boolean get_AsBool()
  System.Void set_AsBool(System.Boolean value)
  ZSimpleJSON.JSONArray get_AsArray()
  ZSimpleJSON.JSONObject get_AsObject()
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode)
END_CLASS

CLASS: ZSimpleJSON.JSON
TYPE:  class
TOKEN: 0x2000017
FIELDS:
METHODS:
  ZSimpleJSON.JSONNode Parse(System.String aJSON)
END_CLASS

