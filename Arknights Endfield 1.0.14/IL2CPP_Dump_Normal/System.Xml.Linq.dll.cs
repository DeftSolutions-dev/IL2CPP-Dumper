// ========================================================
// Dumped by @desirepro
// Assembly: System.Xml.Linq.dll
// Classes:  38
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class SR
    {
        // Methods
        private System.String Format(System.String resourceFormat, System.Object p1) { }
        private System.String Format(System.String resourceFormat, System.Object p1, System.Object p2) { }

    }

    // TypeToken: 0x200000A
    public class ContentReader
    {
        // Fields
        private readonly System.Xml.Linq.NamespaceCache _eCache;        // 0x10
        private readonly System.Xml.Linq.NamespaceCache _aCache;        // 0x20
        private readonly System.Xml.IXmlLineInfo _lineInfo;        // 0x30
        private System.Xml.Linq.XContainer _currentContainer;        // 0x38
        private System.String _baseUri;        // 0x40

        // Methods
        private System.Void .ctor(System.Xml.Linq.XContainer rootContainer) { }
        private System.Void .ctor(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o) { }
        private System.Boolean ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r) { }
        private System.Boolean ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o) { }

    }

    // TypeToken: 0x2000012
    public class ExtractKeyDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.String Invoke(TValue value) { }

    }

    // TypeToken: 0x2000014
    public struct Entry
    {
        // Fields
        public TValue Value;        // 0x0
        public System.Int32 HashCode;        // 0x0
        public System.Int32 Next;        // 0x0

    }

    // TypeToken: 0x2000013
    public class XHashtableState
    {
        // Fields
        private System.Int32[] _buckets;        // 0x0
        private System.Xml.Linq.XHashtable.XHashtableState.Entry<TValue>[] _entries;        // 0x0
        private System.Int32 _numEntries;        // 0x0
        private System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> _extractKey;        // 0x0

        // Methods
        private System.Void .ctor(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, System.Int32 capacity) { }
        private System.Xml.Linq.XHashtable.XHashtableState<TValue> Resize() { }
        private System.Boolean TryGetValue(System.String key, System.Int32 index, System.Int32 count, TValue& value) { }
        private System.Boolean TryAdd(TValue value, TValue& newValue) { }
        private System.Boolean FindEntry(System.Int32 hashCode, System.String key, System.Int32 index, System.Int32 count, System.Int32& entryIndex) { }
        private System.Int32 ComputeHashCode(System.String key, System.Int32 index, System.Int32 count) { }

    }

    // TypeToken: 0x2000018
    public class NamespaceDeclaration
    {
        // Fields
        public System.String prefix;        // 0x10
        public System.Xml.Linq.XNamespace ns;        // 0x18
        public System.Int32 scope;        // 0x20
        public System.Xml.Linq.NamespaceResolver.NamespaceDeclaration prev;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

namespace System.Text
{

    // TypeToken: 0x2000025
    public class StringBuilderCache
    {
        // Fields
        private static System.Text.StringBuilder t_cachedInstance;        // 0xFFFFFFFF

        // Methods
        private System.Text.StringBuilder Acquire(System.Int32 capacity) { }
        private System.Void Release(System.Text.StringBuilder sb) { }
        private System.String GetStringAndRelease(System.Text.StringBuilder sb) { }

    }

}

namespace System.Xml.Linq
{

    // TypeToken: 0x2000003
    public class BaseUriAnnotation
    {
        // Fields
        private System.String baseUri;        // 0x10

        // Methods
        private System.Void .ctor(System.String baseUri) { }

    }

    // TypeToken: 0x2000004
    public class LineInfoAnnotation
    {
        // Fields
        private System.Int32 lineNumber;        // 0x10
        private System.Int32 linePosition;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition) { }

    }

    // TypeToken: 0x2000005
    public class LineInfoEndElementAnnotation : LineInfoAnnotation
    {
        // Methods
        private System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition) { }

    }

    // TypeToken: 0x2000006
    public class XAttribute : XObject
    {
        // Fields
        private System.Xml.Linq.XAttribute next;        // 0x20
        private System.Xml.Linq.XName name;        // 0x28
        private System.String value;        // 0x30

        // Methods
        private System.Void .ctor(System.Xml.Linq.XName name, System.Object value) { }
        private System.Void .ctor(System.Xml.Linq.XAttribute other) { }
        private System.Boolean get_IsNamespaceDeclaration() { }
        private System.Xml.Linq.XName get_Name() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_Value() { }
        private System.String ToString() { }
        private System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns) { }
        private System.Void ValidateAttribute(System.Xml.Linq.XName name, System.String value) { }

    }

    // TypeToken: 0x2000007
    public class XCData : XText
    {
        // Methods
        private System.Void .ctor(System.String value) { }
        private System.Void .ctor(System.Xml.Linq.XCData other) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Void WriteTo(System.Xml.XmlWriter writer) { }
        private System.Xml.Linq.XNode CloneNode() { }

    }

    // TypeToken: 0x2000008
    public class XComment : XNode
    {
        // Fields
        private System.String value;        // 0x28

        // Methods
        private System.Void .ctor(System.String value) { }
        private System.Void .ctor(System.Xml.Linq.XComment other) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_Value() { }
        private System.Void WriteTo(System.Xml.XmlWriter writer) { }
        private System.Xml.Linq.XNode CloneNode() { }

    }

    // TypeToken: 0x2000009
    public class XContainer : XNode
    {
        // Fields
        private System.Object content;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.Linq.XContainer other) { }
        private System.Xml.Linq.XNode get_LastNode() { }
        private System.Void Add(System.Object content) { }
        private System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes() { }
        private System.Void AddAttribute(System.Xml.Linq.XAttribute a) { }
        private System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a) { }
        private System.Void AddContentSkipNotify(System.Object content) { }
        private System.Void AddNode(System.Xml.Linq.XNode n) { }
        private System.Void AddNodeSkipNotify(System.Xml.Linq.XNode n) { }
        private System.Void AddString(System.String s) { }
        private System.Void AddStringSkipNotify(System.String s) { }
        private System.Void AppendNode(System.Xml.Linq.XNode n) { }
        private System.Void AppendNodeSkipNotify(System.Xml.Linq.XNode n) { }
        private System.Void AppendText(System.Text.StringBuilder sb) { }
        private System.Void ConvertTextToNode() { }
        private System.String GetStringValue(System.Object value) { }
        private System.Void ReadContentFrom(System.Xml.XmlReader r) { }
        private System.Void ReadContentFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o) { }
        private System.Void RemoveNode(System.Xml.Linq.XNode n) { }
        private System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous) { }
        private System.Void ValidateString(System.String s) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter writer) { }

    }

    // TypeToken: 0x200000C
    public class XDeclaration
    {
        // Fields
        private System.String _version;        // 0x10
        private System.String _encoding;        // 0x18
        private System.String _standalone;        // 0x20

        // Methods
        private System.Void .ctor(System.String version, System.String encoding, System.String standalone) { }
        private System.Void .ctor(System.Xml.Linq.XDeclaration other) { }
        private System.String get_Encoding() { }
        private System.String get_Standalone() { }
        private System.String get_Version() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200000D
    public class XDocument : XContainer
    {
        // Fields
        private System.Xml.Linq.XDeclaration _declaration;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.Linq.XDocument other) { }
        private System.Xml.Linq.XDeclaration get_Declaration() { }
        private System.Void set_Declaration(System.Xml.Linq.XDeclaration value) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.Linq.XElement get_Root() { }
        private System.Void WriteTo(System.Xml.XmlWriter writer) { }
        private System.Void AddAttribute(System.Xml.Linq.XAttribute a) { }
        private System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a) { }
        private System.Xml.Linq.XNode CloneNode() { }
        private T GetFirstNode() { }
        private System.Boolean IsWhitespace(System.String s) { }
        private System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous) { }
        private System.Void ValidateDocument(System.Xml.Linq.XNode previous, System.Xml.XmlNodeType allowBefore, System.Xml.XmlNodeType allowAfter) { }
        private System.Void ValidateString(System.String s) { }

    }

    // TypeToken: 0x200000E
    public class XDocumentType : XNode
    {
        // Fields
        private System.String _name;        // 0x28
        private System.String _publicId;        // 0x30
        private System.String _systemId;        // 0x38
        private System.String _internalSubset;        // 0x40

        // Methods
        private System.Void .ctor(System.String name, System.String publicId, System.String systemId, System.String internalSubset) { }
        private System.Void .ctor(System.Xml.Linq.XDocumentType other) { }
        private System.String get_InternalSubset() { }
        private System.String get_Name() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_PublicId() { }
        private System.String get_SystemId() { }
        private System.Void WriteTo(System.Xml.XmlWriter writer) { }
        private System.Xml.Linq.XNode CloneNode() { }

    }

    // TypeToken: 0x200000F
    public class XElement : XContainer, IXmlSerializable
    {
        // Fields
        private System.Xml.Linq.XName name;        // 0x30
        private System.Xml.Linq.XAttribute lastAttr;        // 0x38

        // Methods
        private System.Void .ctor(System.Xml.Linq.XName name) { }
        private System.Void .ctor(System.Xml.Linq.XElement other) { }
        private System.Void .ctor(System.Xml.Linq.XStreamingElement other) { }
        private System.Boolean get_HasAttributes() { }
        private System.Boolean get_IsEmpty() { }
        private System.Xml.Linq.XName get_Name() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_Value() { }
        private System.Xml.Linq.XAttribute Attribute(System.Xml.Linq.XName name) { }
        private System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes() { }
        private System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns) { }
        private System.Void WriteTo(System.Xml.XmlWriter writer) { }
        private System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }
        private System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        private System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        private System.Void AddAttribute(System.Xml.Linq.XAttribute a) { }
        private System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a) { }
        private System.Void AppendAttribute(System.Xml.Linq.XAttribute a) { }
        private System.Void AppendAttributeSkipNotify(System.Xml.Linq.XAttribute a) { }
        private System.Xml.Linq.XNode CloneNode() { }
        private System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(System.Xml.Linq.XName name) { }
        private System.String GetNamespaceOfPrefixInScope(System.String prefix, System.Xml.Linq.XElement outOfScope) { }
        private System.Void ReadElementFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o) { }
        private System.Void ReadElementFromImpl(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o) { }
        private System.Void SetEndElementLineInfo(System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous) { }

    }

    // TypeToken: 0x2000011
    public class XHashtable`1
    {
        // Fields
        private System.Xml.Linq.XHashtable.XHashtableState<TValue> _state;        // 0x0

        // Methods
        private System.Void .ctor(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, System.Int32 capacity) { }
        private System.Boolean TryGetValue(System.String key, System.Int32 index, System.Int32 count, TValue& value) { }
        private TValue Add(TValue value) { }

    }

    // TypeToken: 0x2000015
    public struct NamespaceCache
    {
        // Fields
        private System.Xml.Linq.XNamespace _ns;        // 0x10
        private System.String _namespaceName;        // 0x18

        // Methods
        private System.Xml.Linq.XNamespace Get(System.String namespaceName) { }

    }

    // TypeToken: 0x2000016
    public struct ElementWriter
    {
        // Fields
        private System.Xml.XmlWriter _writer;        // 0x10
        private System.Xml.Linq.NamespaceResolver _resolver;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.XmlWriter writer) { }
        private System.Void WriteElement(System.Xml.Linq.XElement e) { }
        private System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, System.Boolean allowDefaultNamespace) { }
        private System.Void PushAncestors(System.Xml.Linq.XElement e) { }
        private System.Void PushElement(System.Xml.Linq.XElement e) { }
        private System.Void WriteEndElement() { }
        private System.Void WriteFullEndElement() { }
        private System.Void WriteStartElement(System.Xml.Linq.XElement e) { }

    }

    // TypeToken: 0x2000017
    public struct NamespaceResolver
    {
        // Fields
        private System.Int32 _scope;        // 0x10
        private System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _declaration;        // 0x18
        private System.Xml.Linq.NamespaceResolver.NamespaceDeclaration _rover;        // 0x20

        // Methods
        private System.Void PushScope() { }
        private System.Void PopScope() { }
        private System.Void Add(System.String prefix, System.Xml.Linq.XNamespace ns) { }
        private System.Void AddFirst(System.String prefix, System.Xml.Linq.XNamespace ns) { }
        private System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, System.Boolean allowDefaultNamespace) { }

    }

    // TypeToken: 0x2000019
    public struct XObjectChange
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Linq.XObjectChange Add;        // 0x0
        public static System.Xml.Linq.XObjectChange Remove;        // 0x0
        public static System.Xml.Linq.XObjectChange Name;        // 0x0
        public static System.Xml.Linq.XObjectChange Value;        // 0x0

    }

    // TypeToken: 0x200001A
    public struct LoadOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Linq.LoadOptions None;        // 0x0
        public static System.Xml.Linq.LoadOptions PreserveWhitespace;        // 0x0
        public static System.Xml.Linq.LoadOptions SetBaseUri;        // 0x0
        public static System.Xml.Linq.LoadOptions SetLineInfo;        // 0x0

    }

    // TypeToken: 0x200001B
    public struct SaveOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Linq.SaveOptions None;        // 0x0
        public static System.Xml.Linq.SaveOptions DisableFormatting;        // 0x0
        public static System.Xml.Linq.SaveOptions OmitDuplicateNamespaces;        // 0x0

    }

    // TypeToken: 0x200001C
    public class XName, IEquatable`1, ISerializable
    {
        // Fields
        private System.Xml.Linq.XNamespace _ns;        // 0x10
        private System.String _localName;        // 0x18
        private System.Int32 _hashCode;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.Linq.XNamespace ns, System.String localName) { }
        private System.String get_LocalName() { }
        private System.Xml.Linq.XNamespace get_Namespace() { }
        private System.String get_NamespaceName() { }
        private System.String ToString() { }
        private System.Xml.Linq.XName Get(System.String expandedName) { }
        private System.Xml.Linq.XName Get(System.String localName, System.String namespaceName) { }
        private System.Xml.Linq.XName op_Implicit(System.String expandedName) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(System.Xml.Linq.XName left, System.Xml.Linq.XName right) { }
        private System.Boolean System.IEquatable<System.Xml.Linq.XName>.Equals(System.Xml.Linq.XName other) { }
        private System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001D
    public class XNamespace
    {
        // Fields
        private static System.Xml.Linq.XHashtable<System.WeakReference> s_namespaces;        // 0x0
        private static System.WeakReference s_refNone;        // 0x8
        private static System.WeakReference s_refXml;        // 0x10
        private static System.WeakReference s_refXmlns;        // 0x18
        private System.String _namespaceName;        // 0x10
        private System.Int32 _hashCode;        // 0x18
        private System.Xml.Linq.XHashtable<System.Xml.Linq.XName> _names;        // 0x20

        // Methods
        private System.Void .ctor(System.String namespaceName) { }
        private System.String get_NamespaceName() { }
        private System.Xml.Linq.XName GetName(System.String localName) { }
        private System.String ToString() { }
        private System.Xml.Linq.XNamespace get_None() { }
        private System.Xml.Linq.XNamespace get_Xml() { }
        private System.Xml.Linq.XNamespace get_Xmlns() { }
        private System.Xml.Linq.XNamespace Get(System.String namespaceName) { }
        private System.Xml.Linq.XNamespace op_Implicit(System.String namespaceName) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right) { }
        private System.Boolean op_Inequality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right) { }
        private System.Xml.Linq.XName GetName(System.String localName, System.Int32 index, System.Int32 count) { }
        private System.Xml.Linq.XNamespace Get(System.String namespaceName, System.Int32 index, System.Int32 count) { }
        private System.String ExtractLocalName(System.Xml.Linq.XName n) { }
        private System.String ExtractNamespace(System.WeakReference r) { }
        private System.Xml.Linq.XNamespace EnsureNamespace(System.WeakReference& refNmsp, System.String namespaceName) { }

    }

    // TypeToken: 0x200001E
    public class XNode : XObject
    {
        // Fields
        private System.Xml.Linq.XNode next;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void Remove() { }
        private System.String ToString() { }
        private System.Void WriteTo(System.Xml.XmlWriter writer) { }
        private System.Void AppendText(System.Text.StringBuilder sb) { }
        private System.Xml.Linq.XNode CloneNode() { }
        private System.String GetXmlString(System.Xml.Linq.SaveOptions o) { }

    }

    // TypeToken: 0x200001F
    public class XObject, IXmlLineInfo
    {
        // Fields
        private System.Xml.Linq.XContainer parent;        // 0x10
        private System.Object annotations;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.String get_BaseUri() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.Linq.XElement get_Parent() { }
        private System.Void AddAnnotation(System.Object annotation) { }
        private System.Object AnnotationForSealedType(System.Type type) { }
        private T Annotation() { }
        private System.Boolean System.Xml.IXmlLineInfo.HasLineInfo() { }
        private System.Int32 System.Xml.IXmlLineInfo.get_LineNumber() { }
        private System.Int32 System.Xml.IXmlLineInfo.get_LinePosition() { }
        private System.Boolean get_HasBaseUri() { }
        private System.Boolean NotifyChanged(System.Object sender, System.Xml.Linq.XObjectChangeEventArgs e) { }
        private System.Boolean NotifyChanging(System.Object sender, System.Xml.Linq.XObjectChangeEventArgs e) { }
        private System.Void SetBaseUri(System.String baseUri) { }
        private System.Void SetLineInfo(System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Boolean SkipNotify() { }
        private System.Xml.Linq.SaveOptions GetSaveOptionsFromAnnotations() { }

    }

    // TypeToken: 0x2000020
    public class XObjectChangeAnnotation
    {
        // Fields
        private System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> changing;        // 0x10
        private System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> changed;        // 0x18

    }

    // TypeToken: 0x2000021
    public class XObjectChangeEventArgs : EventArgs
    {
        // Fields
        private System.Xml.Linq.XObjectChange _objectChange;        // 0x10
        public static readonly System.Xml.Linq.XObjectChangeEventArgs Add;        // 0x0
        public static readonly System.Xml.Linq.XObjectChangeEventArgs Remove;        // 0x8
        public static readonly System.Xml.Linq.XObjectChangeEventArgs Name;        // 0x10
        public static readonly System.Xml.Linq.XObjectChangeEventArgs Value;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.Linq.XObjectChange objectChange) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000022
    public class XProcessingInstruction : XNode
    {
        // Fields
        private System.String target;        // 0x28
        private System.String data;        // 0x30

        // Methods
        private System.Void .ctor(System.String target, System.String data) { }
        private System.Void .ctor(System.Xml.Linq.XProcessingInstruction other) { }
        private System.String get_Data() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_Target() { }
        private System.Void WriteTo(System.Xml.XmlWriter writer) { }
        private System.Xml.Linq.XNode CloneNode() { }
        private System.Void ValidateName(System.String name) { }

    }

    // TypeToken: 0x2000023
    public class XStreamingElement
    {
        // Fields
        private System.Xml.Linq.XName name;        // 0x10
        private System.Object content;        // 0x18

    }

    // TypeToken: 0x2000024
    public class XText : XNode
    {
        // Fields
        private System.String text;        // 0x28

        // Methods
        private System.Void .ctor(System.String value) { }
        private System.Void .ctor(System.Xml.Linq.XText other) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Void WriteTo(System.Xml.XmlWriter writer) { }
        private System.Void AppendText(System.Text.StringBuilder sb) { }
        private System.Xml.Linq.XNode CloneNode() { }

    }

}

namespace Unity
{

    // TypeToken: 0x2000026
    public class ThrowStub : ObjectDisposedException
    {
        // Methods
        private System.Void ThrowNotSupportedException() { }

    }

}

