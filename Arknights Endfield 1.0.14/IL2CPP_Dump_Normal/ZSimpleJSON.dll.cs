// ========================================================
// Dumped by @desirepro
// Assembly: ZSimpleJSON.dll
// Classes:  23
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000004
    public struct Type
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ZSimpleJSON.JSONNode.Enumerator.Type None;        // 0x0
        public static ZSimpleJSON.JSONNode.Enumerator.Type Array;        // 0x0
        public static ZSimpleJSON.JSONNode.Enumerator.Type Object;        // 0x0

    }

    // TypeToken: 0x2000003
    public struct Enumerator
    {
        // Fields
        private ZSimpleJSON.JSONNode.Enumerator.Type type;        // 0x10
        private System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> m_Object;        // 0x18
        private System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> m_Array;        // 0x40

        // Methods
        private System.Boolean get_IsValid() { }
        private System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum) { }
        private System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum) { }
        private System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> get_Current() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x2000005
    public struct ValueEnumerator
    {
        // Fields
        private ZSimpleJSON.JSONNode.Enumerator m_Enumerator;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum) { }
        private System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum) { }
        private System.Void .ctor(ZSimpleJSON.JSONNode.Enumerator aEnumerator) { }
        private ZSimpleJSON.JSONNode get_Current() { }
        private System.Boolean MoveNext() { }
        private ZSimpleJSON.JSONNode.ValueEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x2000006
    public struct KeyEnumerator
    {
        // Fields
        private ZSimpleJSON.JSONNode.Enumerator m_Enumerator;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.Generic.List.Enumerator<ZSimpleJSON.JSONNode> aArrayEnum) { }
        private System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,ZSimpleJSON.JSONNode> aDictEnum) { }
        private System.Void .ctor(ZSimpleJSON.JSONNode.Enumerator aEnumerator) { }
        private System.String get_Current() { }
        private System.Boolean MoveNext() { }
        private ZSimpleJSON.JSONNode.KeyEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x2000007
    public class LinqEnumerator, IEnumerator`1, IEnumerator, IDisposable, IEnumerable`1, IEnumerable
    {
        // Fields
        private ZSimpleJSON.JSONNode m_Node;        // 0x10
        private ZSimpleJSON.JSONNode.Enumerator m_Enumerator;        // 0x18

        // Methods
        private System.Void .ctor(ZSimpleJSON.JSONNode aNode) { }
        private System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Dispose() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode>> GetEnumerator() { }
        private System.Void Reset() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

namespace ZSimpleJSON
{

    // TypeToken: 0x2000002
    public class JSONNode
    {
        // Fields
        public static System.Byte Color32DefaultAlpha;        // 0x0
        public static System.Single ColorDefaultAlpha;        // 0x4
        public static ZSimpleJSON.JSONContainerType VectorContainerType;        // 0x8
        public static ZSimpleJSON.JSONContainerType QuaternionContainerType;        // 0xC
        public static ZSimpleJSON.JSONContainerType RectContainerType;        // 0x10
        public static ZSimpleJSON.JSONContainerType ColorContainerType;        // 0x14
        public static System.Boolean forceASCII;        // 0x18
        public static System.Boolean longAsString;        // 0x19
        public static System.Boolean allowLineComments;        // 0x1A
        private static System.Text.StringBuilder m_EscapeBuilder;        // 0xFFFFFFFF

        // Methods
        private System.Decimal get_AsDecimal() { }
        private System.Void set_AsDecimal(System.Decimal value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Decimal aDecimal) { }
        private System.Decimal op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.Char get_AsChar() { }
        private System.Void set_AsChar(System.Char value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Char aChar) { }
        private System.Char op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.UInt32 get_AsUInt() { }
        private System.Void set_AsUInt(System.UInt32 value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.UInt32 aUInt) { }
        private System.UInt32 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.Byte get_AsByte() { }
        private System.Void set_AsByte(System.Byte value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Byte aByte) { }
        private System.Byte op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.SByte get_AsSByte() { }
        private System.Void set_AsSByte(System.SByte value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.SByte aSByte) { }
        private System.SByte op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.Int16 get_AsShort() { }
        private System.Void set_AsShort(System.Int16 value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Int16 aShort) { }
        private System.Int16 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.UInt16 get_AsUShort() { }
        private System.Void set_AsUShort(System.UInt16 value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.UInt16 aUShort) { }
        private System.UInt16 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.DateTime get_AsDateTime() { }
        private System.Void set_AsDateTime(System.DateTime value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.DateTime aDateTime) { }
        private System.DateTime op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.TimeSpan get_AsTimeSpan() { }
        private System.Void set_AsTimeSpan(System.TimeSpan value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.TimeSpan aTimeSpan) { }
        private System.TimeSpan op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.Guid get_AsGuid() { }
        private System.Void set_AsGuid(System.Guid value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Guid aGuid) { }
        private System.Guid op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.Byte[] get_AsByteArray() { }
        private System.Void set_AsByteArray(System.Byte[] value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Byte[] aByteArray) { }
        private System.Byte[] op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.Collections.Generic.List<System.Byte> get_AsByteList() { }
        private System.Void set_AsByteList(System.Collections.Generic.List<System.Byte> value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.List<System.Byte> aByteList) { }
        private System.Collections.Generic.List<System.Byte> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.UInt64[] get_AsUlongArray() { }
        private System.Void set_AsUlongArray(System.UInt64[] value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.UInt64[] aStringArray) { }
        private System.UInt64[] op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.String[] get_AsStringArray() { }
        private System.Void set_AsStringArray(System.String[] value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.String[] aStringArray) { }
        private System.String[] op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private System.Collections.Generic.List<System.String> get_AsStringList() { }
        private System.Void set_AsStringList(System.Collections.Generic.List<System.String> value) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.List<System.String> aStringList) { }
        private System.Collections.Generic.List<System.String> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int32> aValue) { }
        private System.Nullable<System.Int32> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Single> aValue) { }
        private System.Nullable<System.Single> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Double> aValue) { }
        private System.Nullable<System.Double> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Boolean> aValue) { }
        private System.Nullable<System.Boolean> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int64> aValue) { }
        private System.Nullable<System.Int64> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Nullable<System.Int16> aValue) { }
        private System.Nullable<System.Int16> op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private ZSimpleJSON.JSONNode GetContainer(ZSimpleJSON.JSONContainerType aType) { }
        private ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector2 aVec) { }
        private ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector3 aVec) { }
        private ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Vector4 aVec) { }
        private ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Color aCol) { }
        private ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Color32 aCol) { }
        private ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Quaternion aRot) { }
        private ZSimpleJSON.JSONNode op_Implicit(UnityEngine.Rect aRect) { }
        private ZSimpleJSON.JSONNode op_Implicit(UnityEngine.RectOffset aRect) { }
        private UnityEngine.Vector2 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private UnityEngine.Vector3 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private UnityEngine.Vector4 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private UnityEngine.Color op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private UnityEngine.Color32 op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private UnityEngine.Quaternion op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private UnityEngine.Rect op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private UnityEngine.RectOffset op_Implicit(ZSimpleJSON.JSONNode aNode) { }
        private UnityEngine.Vector2 ReadVector2(UnityEngine.Vector2 aDefault) { }
        private UnityEngine.Vector2 ReadVector2(System.String aXName, System.String aYName) { }
        private UnityEngine.Vector2 ReadVector2() { }
        private ZSimpleJSON.JSONNode WriteVector2(UnityEngine.Vector2 aVec, System.String aXName, System.String aYName) { }
        private UnityEngine.Vector3 ReadVector3(UnityEngine.Vector3 aDefault) { }
        private UnityEngine.Vector3 ReadVector3(System.String aXName, System.String aYName, System.String aZName) { }
        private UnityEngine.Vector3 ReadVector3() { }
        private ZSimpleJSON.JSONNode WriteVector3(UnityEngine.Vector3 aVec, System.String aXName, System.String aYName, System.String aZName) { }
        private UnityEngine.Vector4 ReadVector4(UnityEngine.Vector4 aDefault) { }
        private UnityEngine.Vector4 ReadVector4() { }
        private ZSimpleJSON.JSONNode WriteVector4(UnityEngine.Vector4 aVec) { }
        private UnityEngine.Color ReadColor(UnityEngine.Color aDefault) { }
        private UnityEngine.Color ReadColor() { }
        private ZSimpleJSON.JSONNode WriteColor(UnityEngine.Color aCol) { }
        private UnityEngine.Color32 ReadColor32(UnityEngine.Color32 aDefault) { }
        private UnityEngine.Color32 ReadColor32() { }
        private ZSimpleJSON.JSONNode WriteColor32(UnityEngine.Color32 aCol) { }
        private UnityEngine.Quaternion ReadQuaternion(UnityEngine.Quaternion aDefault) { }
        private UnityEngine.Quaternion ReadQuaternion() { }
        private ZSimpleJSON.JSONNode WriteQuaternion(UnityEngine.Quaternion aRot) { }
        private UnityEngine.Rect ReadRect(UnityEngine.Rect aDefault) { }
        private UnityEngine.Rect ReadRect() { }
        private ZSimpleJSON.JSONNode WriteRect(UnityEngine.Rect aRect) { }
        private UnityEngine.RectOffset ReadRectOffset(UnityEngine.RectOffset aDefault) { }
        private UnityEngine.RectOffset ReadRectOffset() { }
        private ZSimpleJSON.JSONNode WriteRectOffset(UnityEngine.RectOffset aRect) { }
        private UnityEngine.Matrix4x4 ReadMatrix() { }
        private ZSimpleJSON.JSONNode WriteMatrix(UnityEngine.Matrix4x4 aMatrix) { }
        private ZSimpleJSON.JSONNodeType get_Tag() { }
        private ZSimpleJSON.JSONNode get_Item(System.Int32 aIndex) { }
        private System.Void set_Item(System.Int32 aIndex, ZSimpleJSON.JSONNode value) { }
        private ZSimpleJSON.JSONNode get_Item(System.String aKey) { }
        private System.Void set_Item(System.String aKey, ZSimpleJSON.JSONNode value) { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsNumber() { }
        private System.Boolean get_IsString() { }
        private System.Boolean get_IsBoolean() { }
        private System.Boolean get_IsNull() { }
        private System.Boolean get_IsArray() { }
        private System.Boolean get_IsObject() { }
        private System.Boolean get_Inline() { }
        private System.Void set_Inline(System.Boolean value) { }
        private System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem) { }
        private System.Void Add(ZSimpleJSON.JSONNode aItem) { }
        private ZSimpleJSON.JSONNode Remove(System.String aKey) { }
        private ZSimpleJSON.JSONNode Remove(System.Int32 aIndex) { }
        private ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode) { }
        private System.Void Clear() { }
        private ZSimpleJSON.JSONNode Clone() { }
        private System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> get_Children() { }
        private System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> get_DeepChildren() { }
        private System.Boolean HasKey(System.String aKey) { }
        private ZSimpleJSON.JSONNode GetValueOrDefault(System.String aKey, ZSimpleJSON.JSONNode aDefault) { }
        private System.String ToString() { }
        private System.String ToString(System.Int32 aIndent) { }
        private System.Void ToStringBuild(System.Text.StringBuilder& sb) { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        private ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode>> get_Linq() { }
        private ZSimpleJSON.JSONNode.KeyEnumerator get_Keys() { }
        private ZSimpleJSON.JSONNode.ValueEnumerator get_Values() { }
        private System.Double get_AsDouble() { }
        private System.Void set_AsDouble(System.Double value) { }
        private System.Int32 get_AsInt() { }
        private System.Void set_AsInt(System.Int32 value) { }
        private System.Single get_AsFloat() { }
        private System.Void set_AsFloat(System.Single value) { }
        private System.Boolean get_AsBool() { }
        private System.Void set_AsBool(System.Boolean value) { }
        private System.Int64 get_AsLong() { }
        private System.Void set_AsLong(System.Int64 value) { }
        private System.UInt64 get_AsULong() { }
        private System.Void set_AsULong(System.UInt64 value) { }
        private ZSimpleJSON.JSONArray get_AsArray() { }
        private ZSimpleJSON.JSONObject get_AsObject() { }
        private ZSimpleJSON.JSONNode op_Implicit(System.String s) { }
        private System.String op_Implicit(ZSimpleJSON.JSONNode d) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Double n) { }
        private System.Double op_Implicit(ZSimpleJSON.JSONNode d) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Single n) { }
        private System.Single op_Implicit(ZSimpleJSON.JSONNode d) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Int32 n) { }
        private System.Int32 op_Implicit(ZSimpleJSON.JSONNode d) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Int64 n) { }
        private System.Int64 op_Implicit(ZSimpleJSON.JSONNode d) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.UInt64 n) { }
        private System.UInt64 op_Implicit(ZSimpleJSON.JSONNode d) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Boolean b) { }
        private System.Boolean op_Implicit(ZSimpleJSON.JSONNode d) { }
        private ZSimpleJSON.JSONNode op_Implicit(System.Collections.Generic.KeyValuePair<System.String,ZSimpleJSON.JSONNode> aKeyValue) { }
        private System.Boolean op_Equality(ZSimpleJSON.JSONNode a, System.Object b) { }
        private System.Boolean op_Inequality(ZSimpleJSON.JSONNode a, System.Object b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Text.StringBuilder get_EscapeBuilder() { }
        private System.String Escape(System.String aText) { }
        private ZSimpleJSON.JSONNode ParseElement(System.String token, System.Boolean quoted) { }
        private ZSimpleJSON.JSONNode Parse(System.String aJSON) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000A
    public struct JSONContainerType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ZSimpleJSON.JSONContainerType Array;        // 0x0
        public static ZSimpleJSON.JSONContainerType Object;        // 0x0

    }

    // TypeToken: 0x200000B
    public struct JSONNodeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ZSimpleJSON.JSONNodeType Array;        // 0x0
        public static ZSimpleJSON.JSONNodeType Object;        // 0x0
        public static ZSimpleJSON.JSONNodeType String;        // 0x0
        public static ZSimpleJSON.JSONNodeType Number;        // 0x0
        public static ZSimpleJSON.JSONNodeType NullValue;        // 0x0
        public static ZSimpleJSON.JSONNodeType Boolean;        // 0x0
        public static ZSimpleJSON.JSONNodeType None;        // 0x0
        public static ZSimpleJSON.JSONNodeType Custom;        // 0x0

    }

    // TypeToken: 0x200000C
    public struct JSONTextMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ZSimpleJSON.JSONTextMode Compact;        // 0x0
        public static ZSimpleJSON.JSONTextMode Indent;        // 0x0

    }

    // TypeToken: 0x200000D
    public class JSONArray : JSONNode
    {
        // Fields
        private System.Collections.Generic.List<ZSimpleJSON.JSONNode> m_List;        // 0x10
        private System.Boolean inline;        // 0x18

        // Methods
        private System.Boolean get_Inline() { }
        private System.Void set_Inline(System.Boolean value) { }
        private ZSimpleJSON.JSONNodeType get_Tag() { }
        private System.Boolean get_IsArray() { }
        private ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        private ZSimpleJSON.JSONNode get_Item(System.Int32 aIndex) { }
        private System.Void set_Item(System.Int32 aIndex, ZSimpleJSON.JSONNode value) { }
        private ZSimpleJSON.JSONNode get_Item(System.String aKey) { }
        private System.Void set_Item(System.String aKey, ZSimpleJSON.JSONNode value) { }
        private System.Int32 get_Count() { }
        private System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem) { }
        private ZSimpleJSON.JSONNode Remove(System.Int32 aIndex) { }
        private ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode) { }
        private System.Void Clear() { }
        private ZSimpleJSON.JSONNode Clone() { }
        private System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> get_Children() { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class JSONObject : JSONNode
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,ZSimpleJSON.JSONNode> m_Dict;        // 0x10
        private System.Boolean inline;        // 0x18

        // Methods
        private System.Boolean get_Inline() { }
        private System.Void set_Inline(System.Boolean value) { }
        private ZSimpleJSON.JSONNodeType get_Tag() { }
        private System.Boolean get_IsObject() { }
        private ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        private ZSimpleJSON.JSONNode get_Item(System.String aKey) { }
        private System.Void set_Item(System.String aKey, ZSimpleJSON.JSONNode value) { }
        private ZSimpleJSON.JSONNode get_Item(System.Int32 aIndex) { }
        private System.Void set_Item(System.Int32 aIndex, ZSimpleJSON.JSONNode value) { }
        private System.Int32 get_Count() { }
        private System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem) { }
        private ZSimpleJSON.JSONNode Remove(System.String aKey) { }
        private ZSimpleJSON.JSONNode Remove(System.Int32 aIndex) { }
        private ZSimpleJSON.JSONNode Remove(ZSimpleJSON.JSONNode aNode) { }
        private System.Void Clear() { }
        private ZSimpleJSON.JSONNode Clone() { }
        private System.Boolean HasKey(System.String aKey) { }
        private ZSimpleJSON.JSONNode GetValueOrDefault(System.String aKey, ZSimpleJSON.JSONNode aDefault) { }
        private System.Collections.Generic.IEnumerable<ZSimpleJSON.JSONNode> get_Children() { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class JSONString : JSONNode
    {
        // Fields
        private System.String m_Data;        // 0x10

        // Methods
        private ZSimpleJSON.JSONNodeType get_Tag() { }
        private System.Boolean get_IsString() { }
        private ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Void .ctor(System.String aData) { }
        private ZSimpleJSON.JSONNode Clone() { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x2000013
    public class JSONNumber : JSONNode
    {
        // Fields
        private System.Double m_Data;        // 0x10

        // Methods
        private ZSimpleJSON.JSONNodeType get_Tag() { }
        private System.Boolean get_IsNumber() { }
        private ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Double get_AsDouble() { }
        private System.Void set_AsDouble(System.Double value) { }
        private System.Int64 get_AsLong() { }
        private System.Void set_AsLong(System.Int64 value) { }
        private System.UInt64 get_AsULong() { }
        private System.Void set_AsULong(System.UInt64 value) { }
        private System.Void .ctor(System.Double aData) { }
        private System.Void .ctor(System.String aData) { }
        private ZSimpleJSON.JSONNode Clone() { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        private System.Boolean IsNumeric(System.Object value) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x2000014
    public class JSONBool : JSONNode
    {
        // Fields
        private System.Boolean m_Data;        // 0x10

        // Methods
        private ZSimpleJSON.JSONNodeType get_Tag() { }
        private System.Boolean get_IsBoolean() { }
        private ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Boolean get_AsBool() { }
        private System.Void set_AsBool(System.Boolean value) { }
        private System.Void .ctor(System.Boolean aData) { }
        private System.Void .ctor(System.String aData) { }
        private ZSimpleJSON.JSONNode Clone() { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x2000015
    public class JSONNull : JSONNode
    {
        // Fields
        private static ZSimpleJSON.JSONNull m_StaticInstance;        // 0x0
        public static System.Boolean reuseSameInstance;        // 0x8

        // Methods
        private ZSimpleJSON.JSONNull CreateOrGet() { }
        private System.Void .ctor() { }
        private ZSimpleJSON.JSONNodeType get_Tag() { }
        private System.Boolean get_IsNull() { }
        private ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Boolean get_AsBool() { }
        private System.Void set_AsBool(System.Boolean value) { }
        private ZSimpleJSON.JSONNode Clone() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000016
    public class JSONLazyCreator : JSONNode
    {
        // Fields
        private ZSimpleJSON.JSONNode m_Node;        // 0x10
        private System.String m_Key;        // 0x18

        // Methods
        private ZSimpleJSON.JSONNodeType get_Tag() { }
        private ZSimpleJSON.JSONNode.Enumerator GetEnumerator() { }
        private System.Void .ctor(ZSimpleJSON.JSONNode aNode) { }
        private System.Void .ctor(ZSimpleJSON.JSONNode aNode, System.String aKey) { }
        private T Set(T aVal) { }
        private ZSimpleJSON.JSONNode get_Item(System.Int32 aIndex) { }
        private System.Void set_Item(System.Int32 aIndex, ZSimpleJSON.JSONNode value) { }
        private ZSimpleJSON.JSONNode get_Item(System.String aKey) { }
        private System.Void set_Item(System.String aKey, ZSimpleJSON.JSONNode value) { }
        private System.Void Add(ZSimpleJSON.JSONNode aItem) { }
        private System.Void Add(System.String aKey, ZSimpleJSON.JSONNode aItem) { }
        private System.Boolean op_Equality(ZSimpleJSON.JSONLazyCreator a, System.Object b) { }
        private System.Boolean op_Inequality(ZSimpleJSON.JSONLazyCreator a, System.Object b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Int32 get_AsInt() { }
        private System.Void set_AsInt(System.Int32 value) { }
        private System.Single get_AsFloat() { }
        private System.Void set_AsFloat(System.Single value) { }
        private System.Double get_AsDouble() { }
        private System.Void set_AsDouble(System.Double value) { }
        private System.Int64 get_AsLong() { }
        private System.Void set_AsLong(System.Int64 value) { }
        private System.UInt64 get_AsULong() { }
        private System.Void set_AsULong(System.UInt64 value) { }
        private System.Boolean get_AsBool() { }
        private System.Void set_AsBool(System.Boolean value) { }
        private ZSimpleJSON.JSONArray get_AsArray() { }
        private ZSimpleJSON.JSONObject get_AsObject() { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, ZSimpleJSON.JSONTextMode aMode) { }

    }

    // TypeToken: 0x2000017
    public class JSON
    {
        // Methods
        private ZSimpleJSON.JSONNode Parse(System.String aJSON) { }

    }

}

