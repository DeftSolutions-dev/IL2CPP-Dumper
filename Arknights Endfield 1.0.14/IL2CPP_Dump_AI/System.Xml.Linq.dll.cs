// ========================================================
// Dumped by @desirepro
// Assembly: System.Xml.Linq.dll
// Classes:  38
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SR
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.String Format(System.String resourceFormat, System.Object p1)
  System.String Format(System.String resourceFormat, System.Object p1, System.Object p2)
END_CLASS

CLASS: ContentReader
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   readonly System.Xml.Linq.NamespaceCache  _eCache  // 0x10
  private   readonly System.Xml.Linq.NamespaceCache  _aCache  // 0x20
  private   readonly System.Xml.IXmlLineInfo         _lineInfo  // 0x30
  private           System.Xml.Linq.XContainer      _currentContainer  // 0x38
  private           System.String                   _baseUri  // 0x40
METHODS:
  System.Void .ctor(System.Xml.Linq.XContainer rootContainer)
  System.Void .ctor(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o)
  System.Boolean ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r)
  System.Boolean ReadContentFrom(System.Xml.Linq.XContainer rootContainer, System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o)
END_CLASS

CLASS: ExtractKeyDelegate
TYPE:  class
TOKEN: 0x2000012
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.String Invoke(TValue value)
END_CLASS

CLASS: Entry
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            TValue                          Value  // 0x0
  public            System.Int32                    HashCode  // 0x0
  public            System.Int32                    Next  // 0x0
METHODS:
END_CLASS

CLASS: XHashtableState
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  private           System.Int32[]                  _buckets  // 0x0
  private           System.Xml.Linq.XHashtable.XHashtableState.Entry<TValue>[]_entries  // 0x0
  private           System.Int32                    _numEntries  // 0x0
  private           System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue>_extractKey  // 0x0
METHODS:
  System.Void .ctor(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, System.Int32 capacity)
  System.Xml.Linq.XHashtable.XHashtableState<TValue> Resize()
  System.Boolean TryGetValue(System.String key, System.Int32 index, System.Int32 count, TValue& value)
  System.Boolean TryAdd(TValue value, TValue& newValue)
  System.Boolean FindEntry(System.Int32 hashCode, System.String key, System.Int32 index, System.Int32 count, System.Int32& entryIndex)
  System.Int32 ComputeHashCode(System.String key, System.Int32 index, System.Int32 count)
END_CLASS

CLASS: NamespaceDeclaration
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  public            System.String                   prefix  // 0x10
  public            System.Xml.Linq.XNamespace      ns  // 0x18
  public            System.Int32                    scope  // 0x20
  public            System.Xml.Linq.NamespaceResolver.NamespaceDeclarationprev  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Text.StringBuilderCache
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  private   static  System.Text.StringBuilder       t_cachedInstance  // 0xFFFFFFFF
METHODS:
  System.Text.StringBuilder Acquire(System.Int32 capacity)
  System.Void Release(System.Text.StringBuilder sb)
  System.String GetStringAndRelease(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Linq.BaseUriAnnotation
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private           System.String                   baseUri  // 0x10
METHODS:
  System.Void .ctor(System.String baseUri)
END_CLASS

CLASS: System.Xml.Linq.LineInfoAnnotation
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           System.Int32                    lineNumber  // 0x10
  private           System.Int32                    linePosition  // 0x14
METHODS:
  System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition)
END_CLASS

CLASS: System.Xml.Linq.LineInfoEndElementAnnotation
TYPE:  class
TOKEN: 0x2000005
EXTENDS: LineInfoAnnotation
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 lineNumber, System.Int32 linePosition)
END_CLASS

CLASS: System.Xml.Linq.XAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: XObject
FIELDS:
  private           System.Xml.Linq.XAttribute      next  // 0x20
  private           System.Xml.Linq.XName           name  // 0x28
  private           System.String                   value  // 0x30
METHODS:
  System.Void .ctor(System.Xml.Linq.XName name, System.Object value)
  System.Void .ctor(System.Xml.Linq.XAttribute other)
  System.Boolean get_IsNamespaceDeclaration()
  System.Xml.Linq.XName get_Name()
  System.Xml.XmlNodeType get_NodeType()
  System.String get_Value()
  System.String ToString()
  System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns)
  System.Void ValidateAttribute(System.Xml.Linq.XName name, System.String value)
END_CLASS

CLASS: System.Xml.Linq.XCData
TYPE:  class
TOKEN: 0x2000007
EXTENDS: XText
FIELDS:
METHODS:
  System.Void .ctor(System.String value)
  System.Void .ctor(System.Xml.Linq.XCData other)
  System.Xml.XmlNodeType get_NodeType()
  System.Void WriteTo(System.Xml.XmlWriter writer)
  System.Xml.Linq.XNode CloneNode()
END_CLASS

CLASS: System.Xml.Linq.XComment
TYPE:  class
TOKEN: 0x2000008
EXTENDS: XNode
FIELDS:
  private           System.String                   value  // 0x28
METHODS:
  System.Void .ctor(System.String value)
  System.Void .ctor(System.Xml.Linq.XComment other)
  System.Xml.XmlNodeType get_NodeType()
  System.String get_Value()
  System.Void WriteTo(System.Xml.XmlWriter writer)
  System.Xml.Linq.XNode CloneNode()
END_CLASS

CLASS: System.Xml.Linq.XContainer
TYPE:  class
TOKEN: 0x2000009
EXTENDS: XNode
FIELDS:
  private           System.Object                   content  // 0x28
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Xml.Linq.XContainer other)
  System.Xml.Linq.XNode get_LastNode()
  System.Void Add(System.Object content)
  System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes()
  System.Void AddAttribute(System.Xml.Linq.XAttribute a)
  System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a)
  System.Void AddContentSkipNotify(System.Object content)
  System.Void AddNode(System.Xml.Linq.XNode n)
  System.Void AddNodeSkipNotify(System.Xml.Linq.XNode n)
  System.Void AddString(System.String s)
  System.Void AddStringSkipNotify(System.String s)
  System.Void AppendNode(System.Xml.Linq.XNode n)
  System.Void AppendNodeSkipNotify(System.Xml.Linq.XNode n)
  System.Void AppendText(System.Text.StringBuilder sb)
  System.Void ConvertTextToNode()
  System.String GetStringValue(System.Object value)
  System.Void ReadContentFrom(System.Xml.XmlReader r)
  System.Void ReadContentFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o)
  System.Void RemoveNode(System.Xml.Linq.XNode n)
  System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous)
  System.Void ValidateString(System.String s)
  System.Void WriteContentTo(System.Xml.XmlWriter writer)
END_CLASS

CLASS: System.Xml.Linq.XDeclaration
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private           System.String                   _version  // 0x10
  private           System.String                   _encoding  // 0x18
  private           System.String                   _standalone  // 0x20
METHODS:
  System.Void .ctor(System.String version, System.String encoding, System.String standalone)
  System.Void .ctor(System.Xml.Linq.XDeclaration other)
  System.String get_Encoding()
  System.String get_Standalone()
  System.String get_Version()
  System.String ToString()
END_CLASS

CLASS: System.Xml.Linq.XDocument
TYPE:  class
TOKEN: 0x200000D
EXTENDS: XContainer
FIELDS:
  private           System.Xml.Linq.XDeclaration    _declaration  // 0x30
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Xml.Linq.XDocument other)
  System.Xml.Linq.XDeclaration get_Declaration()
  System.Void set_Declaration(System.Xml.Linq.XDeclaration value)
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.Linq.XElement get_Root()
  System.Void WriteTo(System.Xml.XmlWriter writer)
  System.Void AddAttribute(System.Xml.Linq.XAttribute a)
  System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a)
  System.Xml.Linq.XNode CloneNode()
  T GetFirstNode()
  System.Boolean IsWhitespace(System.String s)
  System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous)
  System.Void ValidateDocument(System.Xml.Linq.XNode previous, System.Xml.XmlNodeType allowBefore, System.Xml.XmlNodeType allowAfter)
  System.Void ValidateString(System.String s)
END_CLASS

CLASS: System.Xml.Linq.XDocumentType
TYPE:  class
TOKEN: 0x200000E
EXTENDS: XNode
FIELDS:
  private           System.String                   _name  // 0x28
  private           System.String                   _publicId  // 0x30
  private           System.String                   _systemId  // 0x38
  private           System.String                   _internalSubset  // 0x40
METHODS:
  System.Void .ctor(System.String name, System.String publicId, System.String systemId, System.String internalSubset)
  System.Void .ctor(System.Xml.Linq.XDocumentType other)
  System.String get_InternalSubset()
  System.String get_Name()
  System.Xml.XmlNodeType get_NodeType()
  System.String get_PublicId()
  System.String get_SystemId()
  System.Void WriteTo(System.Xml.XmlWriter writer)
  System.Xml.Linq.XNode CloneNode()
END_CLASS

CLASS: System.Xml.Linq.XElement
TYPE:  class
TOKEN: 0x200000F
EXTENDS: XContainer
FIELDS:
  private           System.Xml.Linq.XName           name  // 0x30
  private           System.Xml.Linq.XAttribute      lastAttr  // 0x38
METHODS:
  System.Void .ctor(System.Xml.Linq.XName name)
  System.Void .ctor(System.Xml.Linq.XElement other)
  System.Void .ctor(System.Xml.Linq.XStreamingElement other)
  System.Boolean get_HasAttributes()
  System.Boolean get_IsEmpty()
  System.Xml.Linq.XName get_Name()
  System.Xml.XmlNodeType get_NodeType()
  System.String get_Value()
  System.Xml.Linq.XAttribute Attribute(System.Xml.Linq.XName name)
  System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes()
  System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns)
  System.Void WriteTo(System.Xml.XmlWriter writer)
  System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
  System.Void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
  System.Void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
  System.Void AddAttribute(System.Xml.Linq.XAttribute a)
  System.Void AddAttributeSkipNotify(System.Xml.Linq.XAttribute a)
  System.Void AppendAttribute(System.Xml.Linq.XAttribute a)
  System.Void AppendAttributeSkipNotify(System.Xml.Linq.XAttribute a)
  System.Xml.Linq.XNode CloneNode()
  System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(System.Xml.Linq.XName name)
  System.String GetNamespaceOfPrefixInScope(System.String prefix, System.Xml.Linq.XElement outOfScope)
  System.Void ReadElementFrom(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o)
  System.Void ReadElementFromImpl(System.Xml.XmlReader r, System.Xml.Linq.LoadOptions o)
  System.Void SetEndElementLineInfo(System.Int32 lineNumber, System.Int32 linePosition)
  System.Void ValidateNode(System.Xml.Linq.XNode node, System.Xml.Linq.XNode previous)
END_CLASS

CLASS: System.Xml.Linq.XHashtable`1
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private           System.Xml.Linq.XHashtable.XHashtableState<TValue>_state  // 0x0
METHODS:
  System.Void .ctor(System.Xml.Linq.XHashtable.ExtractKeyDelegate<TValue> extractKey, System.Int32 capacity)
  System.Boolean TryGetValue(System.String key, System.Int32 index, System.Int32 count, TValue& value)
  TValue Add(TValue value)
END_CLASS

CLASS: System.Xml.Linq.NamespaceCache
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  private           System.Xml.Linq.XNamespace      _ns  // 0x10
  private           System.String                   _namespaceName  // 0x18
METHODS:
  System.Xml.Linq.XNamespace Get(System.String namespaceName)
END_CLASS

CLASS: System.Xml.Linq.ElementWriter
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  private           System.Xml.XmlWriter            _writer  // 0x10
  private           System.Xml.Linq.NamespaceResolver_resolver  // 0x18
METHODS:
  System.Void .ctor(System.Xml.XmlWriter writer)
  System.Void WriteElement(System.Xml.Linq.XElement e)
  System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, System.Boolean allowDefaultNamespace)
  System.Void PushAncestors(System.Xml.Linq.XElement e)
  System.Void PushElement(System.Xml.Linq.XElement e)
  System.Void WriteEndElement()
  System.Void WriteFullEndElement()
  System.Void WriteStartElement(System.Xml.Linq.XElement e)
END_CLASS

CLASS: System.Xml.Linq.NamespaceResolver
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  private           System.Int32                    _scope  // 0x10
  private           System.Xml.Linq.NamespaceResolver.NamespaceDeclaration_declaration  // 0x18
  private           System.Xml.Linq.NamespaceResolver.NamespaceDeclaration_rover  // 0x20
METHODS:
  System.Void PushScope()
  System.Void PopScope()
  System.Void Add(System.String prefix, System.Xml.Linq.XNamespace ns)
  System.Void AddFirst(System.String prefix, System.Xml.Linq.XNamespace ns)
  System.String GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns, System.Boolean allowDefaultNamespace)
END_CLASS

CLASS: System.Xml.Linq.XObjectChange
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Linq.XObjectChange   Add  // 0x0
  public    static  System.Xml.Linq.XObjectChange   Remove  // 0x0
  public    static  System.Xml.Linq.XObjectChange   Name  // 0x0
  public    static  System.Xml.Linq.XObjectChange   Value  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Linq.LoadOptions
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Linq.LoadOptions     None  // 0x0
  public    static  System.Xml.Linq.LoadOptions     PreserveWhitespace  // 0x0
  public    static  System.Xml.Linq.LoadOptions     SetBaseUri  // 0x0
  public    static  System.Xml.Linq.LoadOptions     SetLineInfo  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Linq.SaveOptions
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Linq.SaveOptions     None  // 0x0
  public    static  System.Xml.Linq.SaveOptions     DisableFormatting  // 0x0
  public    static  System.Xml.Linq.SaveOptions     OmitDuplicateNamespaces  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Linq.XName
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  private           System.Xml.Linq.XNamespace      _ns  // 0x10
  private           System.String                   _localName  // 0x18
  private           System.Int32                    _hashCode  // 0x20
METHODS:
  System.Void .ctor(System.Xml.Linq.XNamespace ns, System.String localName)
  System.String get_LocalName()
  System.Xml.Linq.XNamespace get_Namespace()
  System.String get_NamespaceName()
  System.String ToString()
  System.Xml.Linq.XName Get(System.String expandedName)
  System.Xml.Linq.XName Get(System.String localName, System.String namespaceName)
  System.Xml.Linq.XName op_Implicit(System.String expandedName)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(System.Xml.Linq.XName left, System.Xml.Linq.XName right)
  System.Boolean System.IEquatable<System.Xml.Linq.XName>.Equals(System.Xml.Linq.XName other)
  System.Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Linq.XNamespace
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  private   static  System.Xml.Linq.XHashtable<System.WeakReference>s_namespaces  // 0x0
  private   static  System.WeakReference            s_refNone  // 0x8
  private   static  System.WeakReference            s_refXml  // 0x10
  private   static  System.WeakReference            s_refXmlns  // 0x18
  private           System.String                   _namespaceName  // 0x10
  private           System.Int32                    _hashCode  // 0x18
  private           System.Xml.Linq.XHashtable<System.Xml.Linq.XName>_names  // 0x20
METHODS:
  System.Void .ctor(System.String namespaceName)
  System.String get_NamespaceName()
  System.Xml.Linq.XName GetName(System.String localName)
  System.String ToString()
  System.Xml.Linq.XNamespace get_None()
  System.Xml.Linq.XNamespace get_Xml()
  System.Xml.Linq.XNamespace get_Xmlns()
  System.Xml.Linq.XNamespace Get(System.String namespaceName)
  System.Xml.Linq.XNamespace op_Implicit(System.String namespaceName)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right)
  System.Boolean op_Inequality(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right)
  System.Xml.Linq.XName GetName(System.String localName, System.Int32 index, System.Int32 count)
  System.Xml.Linq.XNamespace Get(System.String namespaceName, System.Int32 index, System.Int32 count)
  System.String ExtractLocalName(System.Xml.Linq.XName n)
  System.String ExtractNamespace(System.WeakReference r)
  System.Xml.Linq.XNamespace EnsureNamespace(System.WeakReference& refNmsp, System.String namespaceName)
END_CLASS

CLASS: System.Xml.Linq.XNode
TYPE:  class
TOKEN: 0x200001E
EXTENDS: XObject
FIELDS:
  private           System.Xml.Linq.XNode           next  // 0x20
METHODS:
  System.Void .ctor()
  System.Void Remove()
  System.String ToString()
  System.Void WriteTo(System.Xml.XmlWriter writer)
  System.Void AppendText(System.Text.StringBuilder sb)
  System.Xml.Linq.XNode CloneNode()
  System.String GetXmlString(System.Xml.Linq.SaveOptions o)
END_CLASS

CLASS: System.Xml.Linq.XObject
TYPE:  class
TOKEN: 0x200001F
FIELDS:
  private           System.Xml.Linq.XContainer      parent  // 0x10
  private           System.Object                   annotations  // 0x18
METHODS:
  System.Void .ctor()
  System.String get_BaseUri()
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.Linq.XElement get_Parent()
  System.Void AddAnnotation(System.Object annotation)
  System.Object AnnotationForSealedType(System.Type type)
  T Annotation()
  System.Boolean System.Xml.IXmlLineInfo.HasLineInfo()
  System.Int32 System.Xml.IXmlLineInfo.get_LineNumber()
  System.Int32 System.Xml.IXmlLineInfo.get_LinePosition()
  System.Boolean get_HasBaseUri()
  System.Boolean NotifyChanged(System.Object sender, System.Xml.Linq.XObjectChangeEventArgs e)
  System.Boolean NotifyChanging(System.Object sender, System.Xml.Linq.XObjectChangeEventArgs e)
  System.Void SetBaseUri(System.String baseUri)
  System.Void SetLineInfo(System.Int32 lineNumber, System.Int32 linePosition)
  System.Boolean SkipNotify()
  System.Xml.Linq.SaveOptions GetSaveOptionsFromAnnotations()
END_CLASS

CLASS: System.Xml.Linq.XObjectChangeAnnotation
TYPE:  class
TOKEN: 0x2000020
FIELDS:
  private           System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs>changing  // 0x10
  private           System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs>changed  // 0x18
METHODS:
END_CLASS

CLASS: System.Xml.Linq.XObjectChangeEventArgs
TYPE:  class
TOKEN: 0x2000021
EXTENDS: EventArgs
FIELDS:
  private           System.Xml.Linq.XObjectChange   _objectChange  // 0x10
  public    static readonly System.Xml.Linq.XObjectChangeEventArgsAdd  // 0x0
  public    static readonly System.Xml.Linq.XObjectChangeEventArgsRemove  // 0x8
  public    static readonly System.Xml.Linq.XObjectChangeEventArgsName  // 0x10
  public    static readonly System.Xml.Linq.XObjectChangeEventArgsValue  // 0x18
METHODS:
  System.Void .ctor(System.Xml.Linq.XObjectChange objectChange)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Linq.XProcessingInstruction
TYPE:  class
TOKEN: 0x2000022
EXTENDS: XNode
FIELDS:
  private           System.String                   target  // 0x28
  private           System.String                   data  // 0x30
METHODS:
  System.Void .ctor(System.String target, System.String data)
  System.Void .ctor(System.Xml.Linq.XProcessingInstruction other)
  System.String get_Data()
  System.Xml.XmlNodeType get_NodeType()
  System.String get_Target()
  System.Void WriteTo(System.Xml.XmlWriter writer)
  System.Xml.Linq.XNode CloneNode()
  System.Void ValidateName(System.String name)
END_CLASS

CLASS: System.Xml.Linq.XStreamingElement
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  private           System.Xml.Linq.XName           name  // 0x10
  private           System.Object                   content  // 0x18
METHODS:
END_CLASS

CLASS: System.Xml.Linq.XText
TYPE:  class
TOKEN: 0x2000024
EXTENDS: XNode
FIELDS:
  private           System.String                   text  // 0x28
METHODS:
  System.Void .ctor(System.String value)
  System.Void .ctor(System.Xml.Linq.XText other)
  System.Xml.XmlNodeType get_NodeType()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Void WriteTo(System.Xml.XmlWriter writer)
  System.Void AppendText(System.Text.StringBuilder sb)
  System.Xml.Linq.XNode CloneNode()
END_CLASS

CLASS: Unity.ThrowStub
TYPE:  class
TOKEN: 0x2000026
EXTENDS: ObjectDisposedException
FIELDS:
METHODS:
  System.Void ThrowNotSupportedException()
END_CLASS

