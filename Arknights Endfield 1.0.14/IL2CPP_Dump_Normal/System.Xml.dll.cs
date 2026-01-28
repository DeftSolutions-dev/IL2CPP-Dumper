// ========================================================
// Dumped by @desirepro
// Assembly: System.Xml.dll
// Classes:  753
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class SR
    {
        // Methods
        private System.String GetString(System.String name, System.Object[] args) { }
        private System.String GetString(System.Globalization.CultureInfo culture, System.String name, System.Object[] args) { }
        private System.String Format(System.String resourceFormat, System.Object p1) { }

    }

    // TypeToken: 0x2000012
    public struct ScanState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlSqlBinaryReader.ScanState Doc;        // 0x0
        public static System.Xml.XmlSqlBinaryReader.ScanState XmlText;        // 0x0
        public static System.Xml.XmlSqlBinaryReader.ScanState Attr;        // 0x0
        public static System.Xml.XmlSqlBinaryReader.ScanState AttrVal;        // 0x0
        public static System.Xml.XmlSqlBinaryReader.ScanState AttrValPseudoValue;        // 0x0
        public static System.Xml.XmlSqlBinaryReader.ScanState Init;        // 0x0
        public static System.Xml.XmlSqlBinaryReader.ScanState Error;        // 0x0
        public static System.Xml.XmlSqlBinaryReader.ScanState EOF;        // 0x0
        public static System.Xml.XmlSqlBinaryReader.ScanState Closed;        // 0x0

    }

    // TypeToken: 0x2000013
    public struct QName
    {
        // Fields
        public System.String prefix;        // 0x10
        public System.String localname;        // 0x18
        public System.String namespaceUri;        // 0x20

        // Methods
        private System.Void .ctor(System.String prefix, System.String lname, System.String nsUri) { }
        private System.Void Set(System.String prefix, System.String lname, System.String nsUri) { }
        private System.Void Clear() { }
        private System.Boolean MatchNs(System.String lname, System.String nsUri) { }
        private System.Boolean MatchPrefix(System.String prefix, System.String lname) { }
        private System.Void CheckPrefixNS(System.String prefix, System.String namespaceUri) { }
        private System.Int32 GetHashCode() { }
        private System.Int32 GetNSHashCode(System.Xml.SecureStringHasher hasher) { }
        private System.Boolean Equals(System.Object other) { }
        private System.String ToString() { }
        private System.Boolean op_Equality(System.Xml.XmlSqlBinaryReader.QName a, System.Xml.XmlSqlBinaryReader.QName b) { }

    }

    // TypeToken: 0x2000014
    public struct ElemInfo
    {
        // Fields
        public System.Xml.XmlSqlBinaryReader.QName name;        // 0x10
        public System.String xmlLang;        // 0x28
        public System.Xml.XmlSpace xmlSpace;        // 0x30
        public System.Boolean xmlspacePreserve;        // 0x34
        public System.Xml.XmlSqlBinaryReader.NamespaceDecl nsdecls;        // 0x38

        // Methods
        private System.Void Set(System.Xml.XmlSqlBinaryReader.QName name, System.Boolean xmlspacePreserve) { }
        private System.Xml.XmlSqlBinaryReader.NamespaceDecl Clear() { }

    }

    // TypeToken: 0x2000015
    public struct AttrInfo
    {
        // Fields
        public System.Xml.XmlSqlBinaryReader.QName name;        // 0x10
        public System.String val;        // 0x28
        public System.Int32 contentPos;        // 0x30
        public System.Int32 hashCode;        // 0x34
        public System.Int32 prevHash;        // 0x38

        // Methods
        private System.Void Set(System.Xml.XmlSqlBinaryReader.QName n, System.String v) { }
        private System.Void Set(System.Xml.XmlSqlBinaryReader.QName n, System.Int32 pos) { }
        private System.Void GetLocalnameAndNamespaceUri(System.String& localname, System.String& namespaceUri) { }
        private System.Int32 GetLocalnameAndNamespaceUriAndHash(System.Xml.SecureStringHasher hasher, System.String& localname, System.String& namespaceUri) { }
        private System.Boolean MatchNS(System.String localname, System.String namespaceUri) { }
        private System.Boolean MatchHashNS(System.Int32 hash, System.String localname, System.String namespaceUri) { }
        private System.Void AdjustPosition(System.Int32 adj) { }

    }

    // TypeToken: 0x2000016
    public class NamespaceDecl
    {
        // Fields
        public System.String prefix;        // 0x10
        public System.String uri;        // 0x18
        public System.Xml.XmlSqlBinaryReader.NamespaceDecl scopeLink;        // 0x20
        public System.Xml.XmlSqlBinaryReader.NamespaceDecl prevLink;        // 0x28
        public System.Int32 scope;        // 0x30
        public System.Boolean implied;        // 0x34

        // Methods
        private System.Void .ctor(System.String prefix, System.String nsuri, System.Xml.XmlSqlBinaryReader.NamespaceDecl nextInScope, System.Xml.XmlSqlBinaryReader.NamespaceDecl prevDecl, System.Int32 scope, System.Boolean implied) { }

    }

    // TypeToken: 0x2000017
    public struct SymbolTables
    {
        // Fields
        public System.String[] symtable;        // 0x10
        public System.Int32 symCount;        // 0x18
        public System.Xml.XmlSqlBinaryReader.QName[] qnametable;        // 0x20
        public System.Int32 qnameCount;        // 0x28

        // Methods
        private System.Void Init() { }

    }

    // TypeToken: 0x2000018
    public class NestedBinXml
    {
        // Fields
        public System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables;        // 0x10
        public System.Int32 docState;        // 0x30
        public System.Xml.XmlSqlBinaryReader.NestedBinXml next;        // 0x38

        // Methods
        private System.Void .ctor(System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables, System.Int32 docState, System.Xml.XmlSqlBinaryReader.NestedBinXml next) { }

    }

    // TypeToken: 0x2000037
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.ReadContentAsBinaryHelper.State None;        // 0x0
        public static System.Xml.ReadContentAsBinaryHelper.State InReadContent;        // 0x0
        public static System.Xml.ReadContentAsBinaryHelper.State InReadElementContent;        // 0x0

    }

    // TypeToken: 0x200003D
    public class HashCodeOfStringDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.String s, System.Int32 sLen, System.Int64 additionalEntropy) { }

    }

    // TypeToken: 0x200004D
    public struct XmlEventType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlEventCache.XmlEventType Unknown;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType DocType;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType StartElem;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType StartAttr;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType EndAttr;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType CData;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType Comment;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType PI;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType Whitespace;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType String;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType Raw;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType EntRef;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType CharEnt;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType SurrCharEnt;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType Base64;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType BinHex;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType XmlDecl1;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType XmlDecl2;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType StartContent;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType EndElem;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType FullEndElem;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType Nmsp;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType EndBase64;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType Close;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType Flush;        // 0x0
        public static System.Xml.XmlEventCache.XmlEventType Dispose;        // 0x0

    }

    // TypeToken: 0x200004E
    public struct XmlEvent
    {
        // Fields
        private System.Xml.XmlEventCache.XmlEventType eventType;        // 0x10
        private System.String s1;        // 0x18
        private System.String s2;        // 0x20
        private System.String s3;        // 0x28
        private System.Object o;        // 0x30

        // Methods
        private System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType) { }
        private System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1) { }
        private System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2) { }
        private System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2, System.String s3) { }
        private System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2, System.String s3, System.Object o) { }
        private System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.Object o) { }
        private System.Xml.XmlEventCache.XmlEventType get_EventType() { }
        private System.String get_String1() { }
        private System.String get_String2() { }
        private System.String get_String3() { }
        private System.Object get_Object() { }

    }

    // TypeToken: 0x2000057
    public struct ParsingFunction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlTextReaderImpl.ParsingFunction ElementContent;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction NoData;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction OpenUrl;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction SwitchToInteractive;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction SwitchToInteractiveXmlDecl;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction DocumentContent;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction MoveToElementContent;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction PopElementContext;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction PopEmptyElementContext;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction ResetAttributesRootLevel;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction Error;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction Eof;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction ReaderClosed;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction EntityReference;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction InIncrementalRead;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction FragmentAttribute;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction ReportEndEntity;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction AfterResolveEntityInContent;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction AfterResolveEmptyEntityInContent;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction XmlDeclarationFragment;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction GoToEof;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction PartialTextValue;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction InReadAttributeValue;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction InReadValueChunk;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction InReadContentAsBinary;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingFunction InReadElementContentAsBinary;        // 0x0

    }

    // TypeToken: 0x2000058
    public struct ParsingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlTextReaderImpl.ParsingMode Full;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingMode SkipNode;        // 0x0
        public static System.Xml.XmlTextReaderImpl.ParsingMode SkipContent;        // 0x0

    }

    // TypeToken: 0x2000059
    public struct EntityType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlTextReaderImpl.EntityType CharacterDec;        // 0x0
        public static System.Xml.XmlTextReaderImpl.EntityType CharacterHex;        // 0x0
        public static System.Xml.XmlTextReaderImpl.EntityType CharacterNamed;        // 0x0
        public static System.Xml.XmlTextReaderImpl.EntityType Expanded;        // 0x0
        public static System.Xml.XmlTextReaderImpl.EntityType Skipped;        // 0x0
        public static System.Xml.XmlTextReaderImpl.EntityType FakeExpanded;        // 0x0
        public static System.Xml.XmlTextReaderImpl.EntityType Unexpanded;        // 0x0
        public static System.Xml.XmlTextReaderImpl.EntityType ExpandedInAttribute;        // 0x0

    }

    // TypeToken: 0x200005A
    public struct EntityExpandType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlTextReaderImpl.EntityExpandType All;        // 0x0
        public static System.Xml.XmlTextReaderImpl.EntityExpandType OnlyGeneral;        // 0x0
        public static System.Xml.XmlTextReaderImpl.EntityExpandType OnlyCharacter;        // 0x0

    }

    // TypeToken: 0x200005B
    public struct IncrementalReadState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState Text;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState StartTag;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState PI;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState CDATA;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState Comment;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState Attributes;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState AttributeValue;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState ReadData;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState EndElement;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState End;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnCachedValue;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnPartialValue;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnCachedValue;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnPartialValue;        // 0x0
        public static System.Xml.XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_End;        // 0x0

    }

    // TypeToken: 0x200005C
    public class LaterInitParam
    {
        // Fields
        public System.Boolean useAsync;        // 0x10
        public System.IO.Stream inputStream;        // 0x18
        public System.Byte[] inputBytes;        // 0x20
        public System.Int32 inputByteCount;        // 0x28
        public System.Uri inputbaseUri;        // 0x30
        public System.String inputUriStr;        // 0x38
        public System.Xml.XmlResolver inputUriResolver;        // 0x40
        public System.Xml.XmlParserContext inputContext;        // 0x48
        public System.IO.TextReader inputTextReader;        // 0x50
        public System.Xml.XmlTextReaderImpl.InitInputType initType;        // 0x58

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005D
    public struct InitInputType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlTextReaderImpl.InitInputType UriString;        // 0x0
        public static System.Xml.XmlTextReaderImpl.InitInputType Stream;        // 0x0
        public static System.Xml.XmlTextReaderImpl.InitInputType TextReader;        // 0x0
        public static System.Xml.XmlTextReaderImpl.InitInputType Invalid;        // 0x0

    }

    // TypeToken: 0x200005E
    public struct ParsingState
    {
        // Fields
        private System.Char[] chars;        // 0x10
        private System.Int32 charPos;        // 0x18
        private System.Int32 charsUsed;        // 0x1C
        private System.Text.Encoding encoding;        // 0x20
        private System.Boolean appendMode;        // 0x28
        private System.IO.Stream stream;        // 0x30
        private System.Text.Decoder decoder;        // 0x38
        private System.Byte[] bytes;        // 0x40
        private System.Int32 bytePos;        // 0x48
        private System.Int32 bytesUsed;        // 0x4C
        private System.IO.TextReader textReader;        // 0x50
        private System.Int32 lineNo;        // 0x58
        private System.Int32 lineStartPos;        // 0x5C
        private System.String baseUriStr;        // 0x60
        private System.Uri baseUri;        // 0x68
        private System.Boolean isEof;        // 0x70
        private System.Boolean isStreamEof;        // 0x71
        private System.Xml.IDtdEntityInfo entity;        // 0x78
        private System.Int32 entityId;        // 0x80
        private System.Boolean eolNormalized;        // 0x84
        private System.Boolean entityResolvedManually;        // 0x85

        // Methods
        private System.Void Clear() { }
        private System.Void Close(System.Boolean closeInput) { }
        private System.Int32 get_LineNo() { }
        private System.Int32 get_LinePos() { }

    }

    // TypeToken: 0x200005F
    public class XmlContext
    {
        // Fields
        private System.Xml.XmlSpace xmlSpace;        // 0x10
        private System.String xmlLang;        // 0x18
        private System.String defaultNamespace;        // 0x20
        private System.Xml.XmlTextReaderImpl.XmlContext previousContext;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.XmlTextReaderImpl.XmlContext previousContext) { }

    }

    // TypeToken: 0x2000060
    public class NoNamespaceManager : XmlNamespaceManager
    {
        // Methods
        private System.Void .ctor() { }
        private System.String get_DefaultNamespace() { }
        private System.Void PushScope() { }
        private System.Boolean PopScope() { }
        private System.Void AddNamespace(System.String prefix, System.String uri) { }
        private System.Void RemoveNamespace(System.String prefix, System.String uri) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.String LookupPrefix(System.String uri) { }

    }

    // TypeToken: 0x2000061
    public class DtdParserProxy, IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter
    {
        // Fields
        private System.Xml.XmlTextReaderImpl reader;        // 0x10

        // Methods
        private System.Void .ctor(System.Xml.XmlTextReaderImpl reader) { }
        private System.Xml.XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }
        private System.Xml.IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }
        private System.Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }
        private System.Boolean System.Xml.IDtdParserAdapter.get_IsEof() { }
        private System.Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }
        private System.Int32 System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }
        private System.Int32 System.Xml.IDtdParserAdapter.get_CurrentPosition() { }
        private System.Void System.Xml.IDtdParserAdapter.set_CurrentPosition(System.Int32 value) { }
        private System.Int32 System.Xml.IDtdParserAdapter.get_EntityStackLength() { }
        private System.Boolean System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }
        private System.Void System.Xml.IDtdParserAdapter.OnNewLine(System.Int32 pos) { }
        private System.Int32 System.Xml.IDtdParserAdapter.get_LineNo() { }
        private System.Int32 System.Xml.IDtdParserAdapter.get_LineStartPosition() { }
        private System.Int32 System.Xml.IDtdParserAdapter.ReadData() { }
        private System.Int32 System.Xml.IDtdParserAdapter.ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder) { }
        private System.Int32 System.Xml.IDtdParserAdapter.ParseNamedCharRef(System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder) { }
        private System.Void System.Xml.IDtdParserAdapter.ParsePI(System.Text.StringBuilder sb) { }
        private System.Void System.Xml.IDtdParserAdapter.ParseComment(System.Text.StringBuilder sb) { }
        private System.Boolean System.Xml.IDtdParserAdapter.PushEntity(System.Xml.IDtdEntityInfo entity, System.Int32& entityId) { }
        private System.Boolean System.Xml.IDtdParserAdapter.PopEntity(System.Xml.IDtdEntityInfo& oldEntity, System.Int32& newEntityId) { }
        private System.Boolean System.Xml.IDtdParserAdapter.PushExternalSubset(System.String systemId, System.String publicId) { }
        private System.Void System.Xml.IDtdParserAdapter.PushInternalDtd(System.String baseUri, System.String internalDtd) { }
        private System.Void System.Xml.IDtdParserAdapter.Throw(System.Exception e) { }
        private System.Void System.Xml.IDtdParserAdapter.OnSystemId(System.String systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo) { }
        private System.Void System.Xml.IDtdParserAdapter.OnPublicId(System.String publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo) { }
        private System.Boolean System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }
        private System.Xml.IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }
        private System.Boolean System.Xml.IDtdParserAdapterV1.get_Normalization() { }
        private System.Boolean System.Xml.IDtdParserAdapterV1.get_Namespaces() { }
        private System.Boolean System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }

    }

    // TypeToken: 0x2000062
    public class NodeData, IComparable
    {
        // Fields
        private static System.Xml.XmlTextReaderImpl.NodeData s_None;        // 0x0
        private System.Xml.XmlNodeType type;        // 0x10
        private System.String localName;        // 0x18
        private System.String prefix;        // 0x20
        private System.String ns;        // 0x28
        private System.String nameWPrefix;        // 0x30
        private System.String value;        // 0x38
        private System.Char[] chars;        // 0x40
        private System.Int32 valueStartPos;        // 0x48
        private System.Int32 valueLength;        // 0x4C
        private System.Xml.LineInfo lineInfo;        // 0x50
        private System.Xml.LineInfo lineInfo2;        // 0x58
        private System.Char quoteChar;        // 0x60
        private System.Int32 depth;        // 0x64
        private System.Boolean isEmptyOrDefault;        // 0x68
        private System.Int32 entityId;        // 0x6C
        private System.Boolean xmlContextPushed;        // 0x70
        private System.Xml.XmlTextReaderImpl.NodeData nextAttrValueChunk;        // 0x78
        private System.Object schemaType;        // 0x80
        private System.Object typedValue;        // 0x88

        // Methods
        private System.Xml.XmlTextReaderImpl.NodeData get_None() { }
        private System.Void .ctor() { }
        private System.Int32 get_LineNo() { }
        private System.Int32 get_LinePos() { }
        private System.Boolean get_IsEmptyElement() { }
        private System.Void set_IsEmptyElement(System.Boolean value) { }
        private System.Boolean get_IsDefaultAttribute() { }
        private System.Void set_IsDefaultAttribute(System.Boolean value) { }
        private System.Boolean get_ValueBuffered() { }
        private System.String get_StringValue() { }
        private System.Void TrimSpacesInValue() { }
        private System.Void Clear(System.Xml.XmlNodeType type) { }
        private System.Void ClearName() { }
        private System.Void SetLineInfo(System.Int32 lineNo, System.Int32 linePos) { }
        private System.Void SetLineInfo2(System.Int32 lineNo, System.Int32 linePos) { }
        private System.Void SetValueNode(System.Xml.XmlNodeType type, System.String value) { }
        private System.Void SetValueNode(System.Xml.XmlNodeType type, System.Char[] chars, System.Int32 startPos, System.Int32 len) { }
        private System.Void SetNamedNode(System.Xml.XmlNodeType type, System.String localName) { }
        private System.Void SetNamedNode(System.Xml.XmlNodeType type, System.String localName, System.String prefix, System.String nameWPrefix) { }
        private System.Void SetValue(System.String value) { }
        private System.Void SetValue(System.Char[] chars, System.Int32 startPos, System.Int32 len) { }
        private System.Void OnBufferInvalidated() { }
        private System.Void CopyTo(System.Int32 valueOffset, System.Text.StringBuilder sb) { }
        private System.Int32 CopyTo(System.Int32 valueOffset, System.Char[] buffer, System.Int32 offset, System.Int32 length) { }
        private System.String GetNameWPrefix(System.Xml.XmlNameTable nt) { }
        private System.String CreateNameWPrefix(System.Xml.XmlNameTable nt) { }
        private System.Int32 System.IComparable.CompareTo(System.Object obj) { }

    }

    // TypeToken: 0x2000063
    public class DtdDefaultAttributeInfoToNodeDataComparer, IComparer`1
    {
        // Fields
        private static System.Collections.Generic.IComparer<System.Object> s_instance;        // 0x0

        // Methods
        private System.Collections.Generic.IComparer<System.Object> get_Instance() { }
        private System.Int32 Compare(System.Object x, System.Object y) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000064
    public class OnDefaultAttributeUseDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader) { }

    }

    // TypeToken: 0x2000067
    public struct NamespaceState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlTextWriter.NamespaceState Uninitialized;        // 0x0
        public static System.Xml.XmlTextWriter.NamespaceState NotDeclaredButInScope;        // 0x0
        public static System.Xml.XmlTextWriter.NamespaceState DeclaredButNotWrittenOut;        // 0x0
        public static System.Xml.XmlTextWriter.NamespaceState DeclaredAndWrittenOut;        // 0x0

    }

    // TypeToken: 0x2000068
    public struct TagInfo
    {
        // Fields
        private System.String name;        // 0x10
        private System.String prefix;        // 0x18
        private System.String defaultNs;        // 0x20
        private System.Xml.XmlTextWriter.NamespaceState defaultNsState;        // 0x28
        private System.Xml.XmlSpace xmlSpace;        // 0x2C
        private System.String xmlLang;        // 0x30
        private System.Int32 prevNsTop;        // 0x38
        private System.Int32 prefixCount;        // 0x3C
        private System.Boolean mixed;        // 0x40

        // Methods
        private System.Void Init(System.Int32 nsTop) { }

    }

    // TypeToken: 0x2000069
    public struct Namespace
    {
        // Fields
        private System.String prefix;        // 0x10
        private System.String ns;        // 0x18
        private System.Boolean declared;        // 0x20
        private System.Int32 prevNsIndex;        // 0x24

        // Methods
        private System.Void Set(System.String prefix, System.String ns, System.Boolean declared) { }

    }

    // TypeToken: 0x200006A
    public struct SpecialAttr
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlTextWriter.SpecialAttr None;        // 0x0
        public static System.Xml.XmlTextWriter.SpecialAttr XmlSpace;        // 0x0
        public static System.Xml.XmlTextWriter.SpecialAttr XmlLang;        // 0x0
        public static System.Xml.XmlTextWriter.SpecialAttr XmlNs;        // 0x0

    }

    // TypeToken: 0x200006B
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlTextWriter.State Start;        // 0x0
        public static System.Xml.XmlTextWriter.State Prolog;        // 0x0
        public static System.Xml.XmlTextWriter.State PostDTD;        // 0x0
        public static System.Xml.XmlTextWriter.State Element;        // 0x0
        public static System.Xml.XmlTextWriter.State Attribute;        // 0x0
        public static System.Xml.XmlTextWriter.State Content;        // 0x0
        public static System.Xml.XmlTextWriter.State AttrOnly;        // 0x0
        public static System.Xml.XmlTextWriter.State Epilog;        // 0x0
        public static System.Xml.XmlTextWriter.State Error;        // 0x0
        public static System.Xml.XmlTextWriter.State Closed;        // 0x0

    }

    // TypeToken: 0x200006C
    public struct Token
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlTextWriter.Token PI;        // 0x0
        public static System.Xml.XmlTextWriter.Token Doctype;        // 0x0
        public static System.Xml.XmlTextWriter.Token Comment;        // 0x0
        public static System.Xml.XmlTextWriter.Token CData;        // 0x0
        public static System.Xml.XmlTextWriter.Token StartElement;        // 0x0
        public static System.Xml.XmlTextWriter.Token EndElement;        // 0x0
        public static System.Xml.XmlTextWriter.Token LongEndElement;        // 0x0
        public static System.Xml.XmlTextWriter.Token StartAttribute;        // 0x0
        public static System.Xml.XmlTextWriter.Token EndAttribute;        // 0x0
        public static System.Xml.XmlTextWriter.Token Content;        // 0x0
        public static System.Xml.XmlTextWriter.Token Base64;        // 0x0
        public static System.Xml.XmlTextWriter.Token RawData;        // 0x0
        public static System.Xml.XmlTextWriter.Token Whitespace;        // 0x0
        public static System.Xml.XmlTextWriter.Token Empty;        // 0x0

    }

    // TypeToken: 0x2000071
    public struct ParsingFunction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlValidatingReaderImpl.ParsingFunction Read;        // 0x0
        public static System.Xml.XmlValidatingReaderImpl.ParsingFunction Init;        // 0x0
        public static System.Xml.XmlValidatingReaderImpl.ParsingFunction ParseDtdFromContext;        // 0x0
        public static System.Xml.XmlValidatingReaderImpl.ParsingFunction ResolveEntityInternally;        // 0x0
        public static System.Xml.XmlValidatingReaderImpl.ParsingFunction InReadBinaryContent;        // 0x0
        public static System.Xml.XmlValidatingReaderImpl.ParsingFunction ReaderClosed;        // 0x0
        public static System.Xml.XmlValidatingReaderImpl.ParsingFunction Error;        // 0x0
        public static System.Xml.XmlValidatingReaderImpl.ParsingFunction None;        // 0x0

    }

    // TypeToken: 0x2000072
    public class ValidationEventHandling, IValidationEventHandling
    {
        // Fields
        private System.Xml.XmlValidatingReaderImpl reader;        // 0x10
        private System.Xml.Schema.ValidationEventHandler eventHandler;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader) { }
        private System.Object System.Xml.IValidationEventHandling.get_EventHandler() { }
        private System.Void System.Xml.IValidationEventHandling.SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void AddHandler(System.Xml.Schema.ValidationEventHandler handler) { }

    }

    // TypeToken: 0x2000074
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlWellFormedWriter.State Start;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State TopLevel;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State Document;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State Element;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State Content;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State B64Content;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State B64Attribute;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State AfterRootEle;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State Attribute;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State SpecialAttr;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State EndDocument;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State RootLevelAttr;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State RootLevelSpecAttr;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State RootLevelB64Attr;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State AfterRootLevelAttr;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State Closed;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State Error;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State StartContent;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State StartContentEle;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State StartContentB64;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State StartDoc;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State StartDocEle;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State EndAttrSEle;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State EndAttrEEle;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State EndAttrSCont;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State EndAttrSAttr;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State PostB64Cont;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State PostB64Attr;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State PostB64RootAttr;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State StartFragEle;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State StartFragCont;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State StartFragB64;        // 0x0
        public static System.Xml.XmlWellFormedWriter.State StartRootLevelAttr;        // 0x0

    }

    // TypeToken: 0x2000075
    public struct Token
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlWellFormedWriter.Token StartDocument;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token EndDocument;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token PI;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token Comment;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token Dtd;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token StartElement;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token EndElement;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token StartAttribute;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token EndAttribute;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token Text;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token CData;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token AtomicValue;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token Base64;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token RawData;        // 0x0
        public static System.Xml.XmlWellFormedWriter.Token Whitespace;        // 0x0

    }

    // TypeToken: 0x2000076
    public class NamespaceResolverProxy, IXmlNamespaceResolver
    {
        // Fields
        private System.Xml.XmlWellFormedWriter wfWriter;        // 0x10

        // Methods
        private System.Void .ctor(System.Xml.XmlWellFormedWriter wfWriter) { }
        private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName) { }

    }

    // TypeToken: 0x2000077
    public struct ElementScope
    {
        // Fields
        private System.Int32 prevNSTop;        // 0x10
        private System.String prefix;        // 0x18
        private System.String localName;        // 0x20
        private System.String namespaceUri;        // 0x28
        private System.Xml.XmlSpace xmlSpace;        // 0x30
        private System.String xmlLang;        // 0x38

        // Methods
        private System.Void Set(System.String prefix, System.String localName, System.String namespaceUri, System.Int32 prevNSTop) { }
        private System.Void WriteEndElement(System.Xml.XmlRawWriter rawWriter) { }
        private System.Void WriteFullEndElement(System.Xml.XmlRawWriter rawWriter) { }

    }

    // TypeToken: 0x2000078
    public struct NamespaceKind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlWellFormedWriter.NamespaceKind Written;        // 0x0
        public static System.Xml.XmlWellFormedWriter.NamespaceKind NeedToWrite;        // 0x0
        public static System.Xml.XmlWellFormedWriter.NamespaceKind Implied;        // 0x0
        public static System.Xml.XmlWellFormedWriter.NamespaceKind Special;        // 0x0

    }

    // TypeToken: 0x2000079
    public struct Namespace
    {
        // Fields
        private System.String prefix;        // 0x10
        private System.String namespaceUri;        // 0x18
        private System.Xml.XmlWellFormedWriter.NamespaceKind kind;        // 0x20
        private System.Int32 prevNsIndex;        // 0x24

        // Methods
        private System.Void Set(System.String prefix, System.String namespaceUri, System.Xml.XmlWellFormedWriter.NamespaceKind kind) { }
        private System.Void WriteDecl(System.Xml.XmlWriter writer, System.Xml.XmlRawWriter rawWriter) { }

    }

    // TypeToken: 0x200007A
    public struct AttrName
    {
        // Fields
        private System.String prefix;        // 0x10
        private System.String namespaceUri;        // 0x18
        private System.String localName;        // 0x20
        private System.Int32 prev;        // 0x28

        // Methods
        private System.Void Set(System.String prefix, System.String localName, System.String namespaceUri) { }
        private System.Boolean IsDuplicate(System.String prefix, System.String localName, System.String namespaceUri) { }

    }

    // TypeToken: 0x200007B
    public struct SpecialAttribute
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlWellFormedWriter.SpecialAttribute No;        // 0x0
        public static System.Xml.XmlWellFormedWriter.SpecialAttribute DefaultXmlns;        // 0x0
        public static System.Xml.XmlWellFormedWriter.SpecialAttribute PrefixedXmlns;        // 0x0
        public static System.Xml.XmlWellFormedWriter.SpecialAttribute XmlSpace;        // 0x0
        public static System.Xml.XmlWellFormedWriter.SpecialAttribute XmlLang;        // 0x0

    }

    // TypeToken: 0x200007D
    public struct ItemType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType EntityRef;        // 0x0
        public static System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType CharEntity;        // 0x0
        public static System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType SurrogateCharEntity;        // 0x0
        public static System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType Whitespace;        // 0x0
        public static System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType String;        // 0x0
        public static System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType StringChars;        // 0x0
        public static System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType Raw;        // 0x0
        public static System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType RawChars;        // 0x0
        public static System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType ValueString;        // 0x0

    }

    // TypeToken: 0x200007E
    public class Item
    {
        // Fields
        private System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type;        // 0x10
        private System.Object data;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void Set(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, System.Object data) { }

    }

    // TypeToken: 0x200007F
    public class BufferChunk
    {
        // Fields
        private System.Char[] buffer;        // 0x10
        private System.Int32 index;        // 0x18
        private System.Int32 count;        // 0x1C

        // Methods
        private System.Void .ctor(System.Char[] buffer, System.Int32 index, System.Int32 count) { }

    }

    // TypeToken: 0x200007C
    public class AttributeValueCache
    {
        // Fields
        private System.Text.StringBuilder stringValue;        // 0x10
        private System.String singleStringValue;        // 0x18
        private System.Xml.XmlWellFormedWriter.AttributeValueCache.Item[] items;        // 0x20
        private System.Int32 firstItem;        // 0x28
        private System.Int32 lastItem;        // 0x2C

        // Methods
        private System.String get_StringValue() { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteWhitespace(System.String ws) { }
        private System.Void WriteString(System.String text) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.String data) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void Replay(System.Xml.XmlWriter writer) { }
        private System.Void Trim() { }
        private System.Void Clear() { }
        private System.Void StartComplexValue() { }
        private System.Void AddItem(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, System.Object data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000087
    public struct CachingReaderState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XsdCachingReader.CachingReaderState None;        // 0x0
        public static System.Xml.XsdCachingReader.CachingReaderState Init;        // 0x0
        public static System.Xml.XsdCachingReader.CachingReaderState Record;        // 0x0
        public static System.Xml.XsdCachingReader.CachingReaderState Replay;        // 0x0
        public static System.Xml.XsdCachingReader.CachingReaderState ReaderClosed;        // 0x0
        public static System.Xml.XsdCachingReader.CachingReaderState Error;        // 0x0

    }

    // TypeToken: 0x200008B
    public struct ValidatingReaderState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XsdValidatingReader.ValidatingReaderState None;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState Init;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState Read;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState OnDefaultAttribute;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState OnReadAttributeValue;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState OnAttribute;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState ClearAttributes;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState ParseInlineSchema;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState ReadAhead;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState OnReadBinaryContent;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState ReaderClosed;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState EOF;        // 0x0
        public static System.Xml.XsdValidatingReader.ValidatingReaderState Error;        // 0x0

    }

    // TypeToken: 0x20000AE
    public class SingleObjectEnumerator, IEnumerator
    {
        // Fields
        private System.Object loneValue;        // 0x10
        private System.Int32 position;        // 0x18

        // Methods
        private System.Void .ctor(System.Object value) { }
        private System.Object get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x20000AD
    public struct SmallXmlNodeList
    {
        // Fields
        private System.Object field;        // 0x10

        // Methods
        private System.Int32 get_Count() { }
        private System.Object get_Item(System.Int32 index) { }
        private System.Void Add(System.Object value) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void Insert(System.Int32 index, System.Object value) { }
        private System.Collections.IEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x20000B4
    public struct VirtualAttribute
    {
        // Fields
        private System.String name;        // 0x10
        private System.String value;        // 0x18

        // Methods
        private System.Void .ctor(System.String name, System.String value) { }

    }

    // TypeToken: 0x20000C5
    public class Entry
    {
        // Fields
        private System.String str;        // 0x10
        private System.Int32 hashCode;        // 0x18
        private System.Xml.NameTable.Entry next;        // 0x20

        // Methods
        private System.Void .ctor(System.String str, System.Int32 hashCode, System.Xml.NameTable.Entry next) { }

    }

    // TypeToken: 0x20000C8
    public struct Token
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.DtdParser.Token CDATA;        // 0x0
        public static System.Xml.DtdParser.Token ID;        // 0x0
        public static System.Xml.DtdParser.Token IDREF;        // 0x0
        public static System.Xml.DtdParser.Token IDREFS;        // 0x0
        public static System.Xml.DtdParser.Token ENTITY;        // 0x0
        public static System.Xml.DtdParser.Token ENTITIES;        // 0x0
        public static System.Xml.DtdParser.Token NMTOKEN;        // 0x0
        public static System.Xml.DtdParser.Token NMTOKENS;        // 0x0
        public static System.Xml.DtdParser.Token NOTATION;        // 0x0
        public static System.Xml.DtdParser.Token None;        // 0x0
        public static System.Xml.DtdParser.Token PERef;        // 0x0
        public static System.Xml.DtdParser.Token AttlistDecl;        // 0x0
        public static System.Xml.DtdParser.Token ElementDecl;        // 0x0
        public static System.Xml.DtdParser.Token EntityDecl;        // 0x0
        public static System.Xml.DtdParser.Token NotationDecl;        // 0x0
        public static System.Xml.DtdParser.Token Comment;        // 0x0
        public static System.Xml.DtdParser.Token PI;        // 0x0
        public static System.Xml.DtdParser.Token CondSectionStart;        // 0x0
        public static System.Xml.DtdParser.Token CondSectionEnd;        // 0x0
        public static System.Xml.DtdParser.Token Eof;        // 0x0
        public static System.Xml.DtdParser.Token REQUIRED;        // 0x0
        public static System.Xml.DtdParser.Token IMPLIED;        // 0x0
        public static System.Xml.DtdParser.Token FIXED;        // 0x0
        public static System.Xml.DtdParser.Token QName;        // 0x0
        public static System.Xml.DtdParser.Token Name;        // 0x0
        public static System.Xml.DtdParser.Token Nmtoken;        // 0x0
        public static System.Xml.DtdParser.Token Quote;        // 0x0
        public static System.Xml.DtdParser.Token LeftParen;        // 0x0
        public static System.Xml.DtdParser.Token RightParen;        // 0x0
        public static System.Xml.DtdParser.Token GreaterThan;        // 0x0
        public static System.Xml.DtdParser.Token Or;        // 0x0
        public static System.Xml.DtdParser.Token LeftBracket;        // 0x0
        public static System.Xml.DtdParser.Token RightBracket;        // 0x0
        public static System.Xml.DtdParser.Token PUBLIC;        // 0x0
        public static System.Xml.DtdParser.Token SYSTEM;        // 0x0
        public static System.Xml.DtdParser.Token Literal;        // 0x0
        public static System.Xml.DtdParser.Token DOCTYPE;        // 0x0
        public static System.Xml.DtdParser.Token NData;        // 0x0
        public static System.Xml.DtdParser.Token Percent;        // 0x0
        public static System.Xml.DtdParser.Token Star;        // 0x0
        public static System.Xml.DtdParser.Token QMark;        // 0x0
        public static System.Xml.DtdParser.Token Plus;        // 0x0
        public static System.Xml.DtdParser.Token PCDATA;        // 0x0
        public static System.Xml.DtdParser.Token Comma;        // 0x0
        public static System.Xml.DtdParser.Token ANY;        // 0x0
        public static System.Xml.DtdParser.Token EMPTY;        // 0x0
        public static System.Xml.DtdParser.Token IGNORE;        // 0x0
        public static System.Xml.DtdParser.Token INCLUDE;        // 0x0

    }

    // TypeToken: 0x20000C9
    public struct ScanningFunction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.DtdParser.ScanningFunction SubsetContent;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Name;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction QName;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Nmtoken;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Doctype1;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Doctype2;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Element1;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Element2;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Element3;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Element4;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Element5;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Element6;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Element7;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Attlist1;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Attlist2;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Attlist3;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Attlist4;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Attlist5;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Attlist6;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Attlist7;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Entity1;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Entity2;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Entity3;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Notation1;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction CondSection1;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction CondSection2;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction CondSection3;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction Literal;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction SystemId;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction PublicId1;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction PublicId2;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction ClosingTag;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction ParamEntitySpace;        // 0x0
        public static System.Xml.DtdParser.ScanningFunction None;        // 0x0

    }

    // TypeToken: 0x20000CA
    public struct LiteralType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.DtdParser.LiteralType AttributeValue;        // 0x0
        public static System.Xml.DtdParser.LiteralType EntityReplText;        // 0x0
        public static System.Xml.DtdParser.LiteralType SystemOrPublicID;        // 0x0

    }

    // TypeToken: 0x20000CB
    public class UndeclaredNotation
    {
        // Fields
        private System.String name;        // 0x10
        private System.Int32 lineNo;        // 0x18
        private System.Int32 linePos;        // 0x1C
        private System.Xml.DtdParser.UndeclaredNotation next;        // 0x20

        // Methods
        private System.Void .ctor(System.String name, System.Int32 lineNo, System.Int32 linePos) { }

    }

    // TypeToken: 0x20000CC
    public class ParseElementOnlyContent_LocalFrame
    {
        // Fields
        public System.Int32 startParenEntityId;        // 0x10
        public System.Xml.DtdParser.Token parsingSchema;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 startParentEntityIdParam) { }

    }

    // TypeToken: 0x20000EA
    public struct NamespaceDeclaration
    {
        // Fields
        public System.String prefix;        // 0x10
        public System.String uri;        // 0x18
        public System.Int32 scopeId;        // 0x20
        public System.Int32 previousNsIndex;        // 0x24

        // Methods
        private System.Void Set(System.String prefix, System.String uri, System.Int32 scopeId, System.Int32 previousNsIndex) { }

    }

    // TypeToken: 0x20000EE
    public class HashCodeOfStringDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(System.String s, System.Int32 sLen, System.Int64 additionalEntropy) { }

    }

    // TypeToken: 0x20000FE
    public class Enumerator, IEnumerator
    {
        // Fields
        private System.Xml.XPath.XPathNodeIterator original;        // 0x10
        private System.Xml.XPath.XPathNodeIterator current;        // 0x18
        private System.Boolean iterationStarted;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.XPath.XPathNodeIterator original) { }
        private System.Object get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000135
    public class WriteCallbackInfo
    {
        // Fields
        public System.Type Type;        // 0x10
        public System.String TypeName;        // 0x18
        public System.String TypeNs;        // 0x20
        public System.Xml.Serialization.XmlSerializationReadCallback Callback;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000136
    public class CollectionFixup
    {
        // Fields
        private System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback;        // 0x10
        private System.Object collection;        // 0x18
        private System.Object collectionItems;        // 0x20
        private System.String id;        // 0x28

        // Methods
        private System.Void .ctor(System.Object collection, System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback, System.String id) { }
        private System.Xml.Serialization.XmlSerializationCollectionFixupCallback get_Callback() { }
        private System.Object get_Collection() { }
        private System.Object get_Id() { }
        private System.Object get_CollectionItems() { }
        private System.Void set_CollectionItems(System.Object value) { }

    }

    // TypeToken: 0x2000137
    public class Fixup
    {
        // Fields
        private System.Object source;        // 0x10
        private System.String[] ids;        // 0x18
        private System.Xml.Serialization.XmlSerializationFixupCallback callback;        // 0x20

        // Methods
        private System.Void .ctor(System.Object o, System.Xml.Serialization.XmlSerializationFixupCallback callback, System.Int32 count) { }
        private System.Xml.Serialization.XmlSerializationFixupCallback get_Callback() { }
        private System.String[] get_Ids() { }
        private System.Object get_Source() { }

    }

    // TypeToken: 0x2000138
    public class CollectionItemFixup
    {
        // Fields
        private System.Array list;        // 0x10
        private System.Int32 index;        // 0x18
        private System.String id;        // 0x20

        // Methods
        private System.Void .ctor(System.Array list, System.Int32 index, System.String id) { }
        private System.Array get_Collection() { }
        private System.Int32 get_Index() { }
        private System.String get_Id() { }

    }

    // TypeToken: 0x200013A
    public class FixupCallbackInfo
    {
        // Fields
        private System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;        // 0x10
        private System.Xml.Serialization.ClassMap _map;        // 0x18
        private System.Boolean _isValueList;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.ClassMap map, System.Boolean isValueList) { }
        private System.Void FixupMembers(System.Object fixup) { }

    }

    // TypeToken: 0x200013B
    public class ReaderCallbackInfo
    {
        // Fields
        private System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;        // 0x10
        private System.Xml.Serialization.XmlTypeMapping _typeMap;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.XmlTypeMapping typeMap) { }
        private System.Object ReadObject() { }

    }

    // TypeToken: 0x200013E
    public class WriteCallbackInfo
    {
        // Fields
        public System.Type Type;        // 0x10
        public System.String TypeName;        // 0x18
        public System.String TypeNs;        // 0x20
        public System.Xml.Serialization.XmlSerializationWriteCallback Callback;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000140
    public class CallbackInfo
    {
        // Fields
        private System.Xml.Serialization.XmlSerializationWriterInterpreter _swi;        // 0x10
        private System.Xml.Serialization.XmlTypeMapping _typeMap;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.Serialization.XmlSerializationWriterInterpreter swi, System.Xml.Serialization.XmlTypeMapping typeMap) { }
        private System.Void WriteObject(System.Object ob) { }
        private System.Void WriteEnum(System.Object ob) { }

    }

    // TypeToken: 0x2000142
    public class SerializerData
    {
        // Fields
        public System.Reflection.MethodInfo ReaderMethod;        // 0x10
        public System.Type WriterType;        // 0x18
        public System.Reflection.MethodInfo WriterMethod;        // 0x20
        public System.Xml.Serialization.XmlSerializerImplementation Implementation;        // 0x28

        // Methods
        private System.Xml.Serialization.XmlSerializationWriter CreateWriter() { }

    }

    // TypeToken: 0x2000157
    public class EnumMapMember
    {
        // Fields
        private readonly System.String _xmlName;        // 0x10
        private readonly System.String _enumName;        // 0x18
        private readonly System.Int64 _value;        // 0x20

        // Methods
        private System.Void .ctor(System.String xmlName, System.String enumName, System.Int64 value) { }
        private System.String get_XmlName() { }
        private System.String get_EnumName() { }
        private System.Int64 get_Value() { }

    }

    // TypeToken: 0x2000169
    public struct ConstraintRole
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole Unique;        // 0x0
        public static System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole Key;        // 0x0
        public static System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole Keyref;        // 0x0

    }

    // TypeToken: 0x200016F
    public class DecimalStruct
    {
        // Fields
        private System.Boolean isDecimal;        // 0x10
        private System.Decimal[] dvalue;        // 0x18

        // Methods
        private System.Boolean get_IsDecimal() { }
        private System.Void set_IsDecimal(System.Boolean value) { }
        private System.Decimal[] get_Dvalue() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 dim) { }

    }

    // TypeToken: 0x200017A
    public struct SequenceConstructPosContext
    {
        // Fields
        public System.Xml.Schema.SequenceNode this_;        // 0x10
        public System.Xml.Schema.BitSet firstpos;        // 0x18
        public System.Xml.Schema.BitSet lastpos;        // 0x20
        public System.Xml.Schema.BitSet lastposLeft;        // 0x28
        public System.Xml.Schema.BitSet firstposRight;        // 0x30

        // Methods
        private System.Void .ctor(System.Xml.Schema.SequenceNode node, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos) { }

    }

    // TypeToken: 0x200018D
    public class SchemaDatatypeMap, IComparable
    {
        // Fields
        private System.String name;        // 0x10
        private System.Xml.Schema.DatatypeImplementation type;        // 0x18
        private System.Int32 parentIndex;        // 0x20

        // Methods
        private System.Void .ctor(System.String name, System.Xml.Schema.DatatypeImplementation type) { }
        private System.Void .ctor(System.String name, System.Xml.Schema.DatatypeImplementation type, System.Int32 parentIndex) { }
        private System.Xml.Schema.DatatypeImplementation op_Explicit(System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap sdm) { }
        private System.String get_Name() { }
        private System.Int32 get_ParentIndex() { }
        private System.Int32 CompareTo(System.Object obj) { }

    }

    // TypeToken: 0x20001CD
    public class NamespaceManager : XmlNamespaceManager
    {
        // Methods
        private System.String LookupNamespace(System.String prefix) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D0
    public struct Map
    {
        // Fields
        private System.Char match;        // 0x10
        private System.String replacement;        // 0x18

        // Methods
        private System.Void .ctor(System.Char m, System.String r) { }

    }

    // TypeToken: 0x20001CF
    public struct FacetsCompiler
    {
        // Fields
        private System.Xml.Schema.DatatypeImplementation datatype;        // 0x10
        private System.Xml.Schema.RestrictionFacets derivedRestriction;        // 0x18
        private System.Xml.Schema.RestrictionFlags baseFlags;        // 0x20
        private System.Xml.Schema.RestrictionFlags baseFixedFlags;        // 0x24
        private System.Xml.Schema.RestrictionFlags validRestrictionFlags;        // 0x28
        private System.Xml.Schema.XmlSchemaDatatype nonNegativeInt;        // 0x30
        private System.Xml.Schema.XmlSchemaDatatype builtInType;        // 0x38
        private System.Xml.Schema.XmlTypeCode builtInEnum;        // 0x40
        private System.Boolean firstPattern;        // 0x44
        private System.Text.StringBuilder regStr;        // 0x48
        private System.Xml.Schema.XmlSchemaPatternFacet pattern_facet;        // 0x50
        private static readonly System.Xml.Schema.FacetsChecker.FacetsCompiler.Map[] c_map;        // 0x0

        // Methods
        private System.Void .ctor(System.Xml.Schema.DatatypeImplementation baseDatatype, System.Xml.Schema.RestrictionFacets restriction) { }
        private System.Void CompileLengthFacet(System.Xml.Schema.XmlSchemaFacet facet) { }
        private System.Void CompileMinLengthFacet(System.Xml.Schema.XmlSchemaFacet facet) { }
        private System.Void CompileMaxLengthFacet(System.Xml.Schema.XmlSchemaFacet facet) { }
        private System.Void CompilePatternFacet(System.Xml.Schema.XmlSchemaPatternFacet facet) { }
        private System.Void CompileEnumerationFacet(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable) { }
        private System.Void CompileWhitespaceFacet(System.Xml.Schema.XmlSchemaFacet facet) { }
        private System.Void CompileMaxInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet) { }
        private System.Void CompileMaxExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet) { }
        private System.Void CompileMinInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet) { }
        private System.Void CompileMinExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet) { }
        private System.Void CompileTotalDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet) { }
        private System.Void CompileFractionDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet) { }
        private System.Void FinishFacetCompile() { }
        private System.Void CheckValue(System.Object value, System.Xml.Schema.XmlSchemaFacet facet) { }
        private System.Void CompileFacetCombinations() { }
        private System.Void CopyFacetsFromBaseType() { }
        private System.Object ParseFacetValue(System.Xml.Schema.XmlSchemaDatatype datatype, System.Xml.Schema.XmlSchemaFacet facet, System.String code, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable) { }
        private System.String Preprocess(System.String pattern) { }
        private System.Void CheckProhibitedFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, System.String errorCode) { }
        private System.Void CheckDupFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, System.String errorCode) { }
        private System.Void SetFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag) { }
        private System.Void SetFlag(System.Xml.Schema.RestrictionFlags flag) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001DD
    public struct InferenceOption
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaInference.InferenceOption Restricted;        // 0x0
        public static System.Xml.Schema.XmlSchemaInference.InferenceOption Relaxed;        // 0x0

    }

    // TypeToken: 0x20001E0
    public struct ListType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.NamespaceList.ListType Any;        // 0x0
        public static System.Xml.Schema.NamespaceList.ListType Other;        // 0x0
        public static System.Xml.Schema.NamespaceList.ListType Set;        // 0x0

    }

    // TypeToken: 0x20001E7
    public struct Reserve
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.SchemaAttDef.Reserve None;        // 0x0
        public static System.Xml.Schema.SchemaAttDef.Reserve XmlSpace;        // 0x0
        public static System.Xml.Schema.SchemaAttDef.Reserve XmlLang;        // 0x0

    }

    // TypeToken: 0x20001EB
    public struct Compositor
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.SchemaCollectionPreprocessor.Compositor Root;        // 0x0
        public static System.Xml.Schema.SchemaCollectionPreprocessor.Compositor Include;        // 0x0
        public static System.Xml.Schema.SchemaCollectionPreprocessor.Compositor Import;        // 0x0

    }

    // TypeToken: 0x20001ED
    public struct Use
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.SchemaDeclBase.Use Default;        // 0x0
        public static System.Xml.Schema.SchemaDeclBase.Use Required;        // 0x0
        public static System.Xml.Schema.SchemaDeclBase.Use Implied;        // 0x0
        public static System.Xml.Schema.SchemaDeclBase.Use Fixed;        // 0x0
        public static System.Xml.Schema.SchemaDeclBase.Use RequiredFixed;        // 0x0

    }

    // TypeToken: 0x20001F3
    public struct Token
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.SchemaNames.Token Empty;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaName;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaType;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaMaxOccurs;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaMinOccurs;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaInfinite;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaModel;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaOpen;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaClosed;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaContent;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaMixed;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaEmpty;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaElementOnly;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaTextOnly;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaOrder;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaSeq;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaOne;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaMany;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaRequired;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaYes;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaNo;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaString;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaId;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaIdref;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaIdrefs;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaEntity;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaEntities;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaNmtoken;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaNmtokens;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaEnumeration;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaDefault;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XdrRoot;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XdrElementType;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XdrElement;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XdrGroup;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XdrAttributeType;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XdrAttribute;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XdrDatatype;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XdrDescription;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XdrExtends;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaXdrRootAlias;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaDtType;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaDtValues;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaDtMaxLength;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaDtMinLength;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaDtMax;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaDtMin;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaDtMinExclusive;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaDtMaxExclusive;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaTargetNamespace;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaVersion;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaFinalDefault;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaBlockDefault;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaFixed;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaAbstract;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaBlock;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaSubstitutionGroup;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaFinal;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaNillable;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaRef;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaBase;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaDerivedBy;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaNamespace;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaProcessContents;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaRefer;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaPublic;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaSystem;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaSchemaLocation;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaValue;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaSource;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaAttributeFormDefault;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaElementFormDefault;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaUse;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaForm;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdSchema;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdAnnotation;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdInclude;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdImport;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdElement;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdAttribute;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token xsdAttributeGroup;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdAnyAttribute;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdGroup;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdAll;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdChoice;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdSequence;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdAny;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdNotation;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdSimpleType;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdComplexType;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdUnique;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdKey;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdKeyref;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdSelector;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdField;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdMinExclusive;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdMinInclusive;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdMaxExclusive;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdMaxInclusive;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdTotalDigits;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdFractionDigits;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdLength;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdMinLength;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdMaxLength;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdEnumeration;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdPattern;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdDocumentation;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdAppInfo;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdComplexContent;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdComplexContentExtension;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdComplexContentRestriction;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdSimpleContent;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdSimpleContentExtension;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdSimpleContentRestriction;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdSimpleTypeList;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdSimpleTypeRestriction;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdSimpleTypeUnion;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdWhitespace;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XsdRedefine;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaItemType;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaMemberTypes;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token SchemaXPath;        // 0x0
        public static System.Xml.Schema.SchemaNames.Token XmlLang;        // 0x0

    }

    // TypeToken: 0x20001FD
    public class DeclBaseInfo
    {
        // Fields
        private System.Xml.XmlQualifiedName _Name;        // 0x10
        private System.String _Prefix;        // 0x18
        private System.Xml.XmlQualifiedName _TypeName;        // 0x20
        private System.String _TypePrefix;        // 0x28
        private System.Object _Default;        // 0x30
        private System.Object _Revises;        // 0x38
        private System.UInt32 _MaxOccurs;        // 0x40
        private System.UInt32 _MinOccurs;        // 0x44
        private System.Boolean _Checking;        // 0x48
        private System.Xml.Schema.SchemaElementDecl _ElementDecl;        // 0x50
        private System.Xml.Schema.SchemaAttDef _Attdef;        // 0x58
        private System.Xml.Schema.XdrBuilder.DeclBaseInfo _Next;        // 0x60

        // Methods
        private System.Void .ctor() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x20001FE
    public class GroupContent
    {
        // Fields
        private System.UInt32 _MinVal;        // 0x10
        private System.UInt32 _MaxVal;        // 0x14
        private System.Boolean _HasMaxAttr;        // 0x18
        private System.Boolean _HasMinAttr;        // 0x19
        private System.Int32 _Order;        // 0x1C

        // Methods
        private System.Void Copy(System.Xml.Schema.XdrBuilder.GroupContent from, System.Xml.Schema.XdrBuilder.GroupContent to) { }
        private System.Xml.Schema.XdrBuilder.GroupContent Copy(System.Xml.Schema.XdrBuilder.GroupContent other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001FF
    public class ElementContent
    {
        // Fields
        private System.Xml.Schema.SchemaElementDecl _ElementDecl;        // 0x10
        private System.Int32 _ContentAttr;        // 0x18
        private System.Int32 _OrderAttr;        // 0x1C
        private System.Boolean _MasterGroupRequired;        // 0x20
        private System.Boolean _ExistTerminal;        // 0x21
        private System.Boolean _AllowDataType;        // 0x22
        private System.Boolean _HasDataType;        // 0x23
        private System.Boolean _HasType;        // 0x24
        private System.Boolean _EnumerationRequired;        // 0x25
        private System.UInt32 _MinVal;        // 0x28
        private System.UInt32 _MaxVal;        // 0x2C
        private System.UInt32 _MaxLength;        // 0x30
        private System.UInt32 _MinLength;        // 0x34
        private System.Collections.Hashtable _AttDefList;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000200
    public class AttributeContent
    {
        // Fields
        private System.Xml.Schema.SchemaAttDef _AttDef;        // 0x10
        private System.Xml.XmlQualifiedName _Name;        // 0x18
        private System.String _Prefix;        // 0x20
        private System.Boolean _Required;        // 0x28
        private System.UInt32 _MinVal;        // 0x2C
        private System.UInt32 _MaxVal;        // 0x30
        private System.UInt32 _MaxLength;        // 0x34
        private System.UInt32 _MinLength;        // 0x38
        private System.Boolean _EnumerationRequired;        // 0x3C
        private System.Boolean _HasDataType;        // 0x3D
        private System.Boolean _Global;        // 0x3E
        private System.Object _Default;        // 0x40

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000201
    public class XdrBuildFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }

    }

    // TypeToken: 0x2000202
    public class XdrInitFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Xml.Schema.XdrBuilder builder, System.Object obj) { }

    }

    // TypeToken: 0x2000203
    public class XdrBeginChildFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Xml.Schema.XdrBuilder builder) { }

    }

    // TypeToken: 0x2000204
    public class XdrEndChildFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Xml.Schema.XdrBuilder builder) { }

    }

    // TypeToken: 0x2000205
    public class XdrAttributeEntry
    {
        // Fields
        private System.Xml.Schema.SchemaNames.Token _Attribute;        // 0x10
        private System.Int32 _SchemaFlags;        // 0x14
        private System.Xml.Schema.XmlSchemaDatatype _Datatype;        // 0x18
        private System.Xml.Schema.XdrBuilder.XdrBuildFunction _BuildFunc;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, System.Xml.Schema.XdrBuilder.XdrBuildFunction build) { }
        private System.Void .ctor(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, System.Int32 schemaFlags, System.Xml.Schema.XdrBuilder.XdrBuildFunction build) { }

    }

    // TypeToken: 0x2000206
    public class XdrEntry
    {
        // Fields
        private System.Xml.Schema.SchemaNames.Token _Name;        // 0x10
        private System.Int32[] _NextStates;        // 0x18
        private System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] _Attributes;        // 0x20
        private System.Xml.Schema.XdrBuilder.XdrInitFunction _InitFunc;        // 0x28
        private System.Xml.Schema.XdrBuilder.XdrBeginChildFunction _BeginChildFunc;        // 0x30
        private System.Xml.Schema.XdrBuilder.XdrEndChildFunction _EndChildFunc;        // 0x38
        private System.Boolean _AllowText;        // 0x40

        // Methods
        private System.Void .ctor(System.Xml.Schema.SchemaNames.Token n, System.Int32[] states, System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] attributes, System.Xml.Schema.XdrBuilder.XdrInitFunction init, System.Xml.Schema.XdrBuilder.XdrBeginChildFunction begin, System.Xml.Schema.XdrBuilder.XdrEndChildFunction end, System.Boolean fText) { }

    }

    // TypeToken: 0x2000209
    public struct Union
    {
        // Fields
        public System.Boolean boolVal;        // 0x10
        public System.Double dblVal;        // 0x10
        public System.Int64 i64Val;        // 0x10
        public System.Int32 i32Val;        // 0x10
        public System.DateTime dtVal;        // 0x10

    }

    // TypeToken: 0x200020A
    public class NamespacePrefixForQName, IXmlNamespaceResolver
    {
        // Fields
        public System.String prefix;        // 0x10
        public System.String ns;        // 0x18

        // Methods
        private System.Void .ctor(System.String prefix, System.String ns) { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.String LookupPrefix(System.String namespaceName) { }
        private System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }

    }

    // TypeToken: 0x2000248
    public struct EnumeratorType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType Keys;        // 0x0
        public static System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType Values;        // 0x0
        public static System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType DictionaryEntry;        // 0x0

    }

    // TypeToken: 0x2000249
    public struct XmlSchemaObjectEntry
    {
        // Fields
        private System.Xml.XmlQualifiedName qname;        // 0x10
        private System.Xml.Schema.XmlSchemaObject xso;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value) { }

    }

    // TypeToken: 0x200024A
    public class ValuesCollection, ICollection, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;        // 0x10
        private System.Int32 size;        // 0x18

        // Methods
        private System.Void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, System.Int32 size) { }
        private System.Int32 get_Count() { }
        private System.Object get_SyncRoot() { }
        private System.Boolean get_IsSynchronized() { }
        private System.Void CopyTo(System.Array array, System.Int32 arrayIndex) { }
        private System.Collections.IEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x200024B
    public class XSOEnumerator, IEnumerator
    {
        // Fields
        private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;        // 0x10
        private System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType;        // 0x18
        protected System.Int32 currentIndex;        // 0x1C
        protected System.Int32 size;        // 0x20
        protected System.Xml.XmlQualifiedName currentKey;        // 0x28
        protected System.Xml.Schema.XmlSchemaObject currentValue;        // 0x30

        // Methods
        private System.Void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, System.Int32 size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType) { }
        private System.Object get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x200024C
    public class XSODictionaryEnumerator : XSOEnumerator, IDictionaryEnumerator, IEnumerator
    {
        // Methods
        private System.Void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, System.Int32 size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType) { }
        private System.Collections.DictionaryEntry get_Entry() { }
        private System.Object get_Key() { }
        private System.Object get_Value() { }

    }

    // TypeToken: 0x200024E
    public struct Occurs
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaParticle.Occurs None;        // 0x0
        public static System.Xml.Schema.XmlSchemaParticle.Occurs Min;        // 0x0
        public static System.Xml.Schema.XmlSchemaParticle.Occurs Max;        // 0x0

    }

    // TypeToken: 0x200024F
    public class EmptyParticle : XmlSchemaParticle
    {
        // Methods
        private System.Boolean get_IsEmpty() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000276
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XsdBuilder.State Root;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Schema;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Annotation;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Include;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Import;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Element;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Attribute;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State AttributeGroup;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State AttributeGroupRef;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State AnyAttribute;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Group;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State GroupRef;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State All;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Choice;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Sequence;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Any;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Notation;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State SimpleType;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State ComplexType;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State ComplexContent;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State ComplexContentRestriction;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State ComplexContentExtension;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State SimpleContent;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State SimpleContentExtension;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State SimpleContentRestriction;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State SimpleTypeUnion;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State SimpleTypeList;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State SimpleTypeRestriction;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Unique;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Key;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State KeyRef;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Selector;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Field;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State MinExclusive;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State MinInclusive;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State MaxExclusive;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State MaxInclusive;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State TotalDigits;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State FractionDigits;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Length;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State MinLength;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State MaxLength;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Enumeration;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Pattern;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State WhiteSpace;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State AppInfo;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Documentation;        // 0x0
        public static System.Xml.Schema.XsdBuilder.State Redefine;        // 0x0

    }

    // TypeToken: 0x2000277
    public class XsdBuildFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Xml.Schema.XsdBuilder builder, System.String value) { }

    }

    // TypeToken: 0x2000278
    public class XsdInitFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Xml.Schema.XsdBuilder builder, System.String value) { }

    }

    // TypeToken: 0x2000279
    public class XsdEndChildFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Xml.Schema.XsdBuilder builder) { }

    }

    // TypeToken: 0x200027A
    public class XsdAttributeEntry
    {
        // Fields
        public System.Xml.Schema.SchemaNames.Token Attribute;        // 0x10
        public System.Xml.Schema.XsdBuilder.XsdBuildFunction BuildFunc;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.Schema.SchemaNames.Token a, System.Xml.Schema.XsdBuilder.XsdBuildFunction build) { }

    }

    // TypeToken: 0x200027B
    public class XsdEntry
    {
        // Fields
        public System.Xml.Schema.SchemaNames.Token Name;        // 0x10
        public System.Xml.Schema.XsdBuilder.State CurrentState;        // 0x14
        public System.Xml.Schema.XsdBuilder.State[] NextStates;        // 0x18
        public System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] Attributes;        // 0x20
        public System.Xml.Schema.XsdBuilder.XsdInitFunction InitFunc;        // 0x28
        public System.Xml.Schema.XsdBuilder.XsdEndChildFunction EndChildFunc;        // 0x30
        public System.Boolean ParseContent;        // 0x38

        // Methods
        private System.Void .ctor(System.Xml.Schema.SchemaNames.Token n, System.Xml.Schema.XsdBuilder.State state, System.Xml.Schema.XsdBuilder.State[] nextStates, System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] attributes, System.Xml.Schema.XsdBuilder.XsdInitFunction init, System.Xml.Schema.XsdBuilder.XsdEndChildFunction end, System.Boolean parseContent) { }

    }

    // TypeToken: 0x200027C
    public class BuilderNamespaceManager : XmlNamespaceManager
    {
        // Fields
        private System.Xml.XmlNamespaceManager nsMgr;        // 0x50
        private System.Xml.XmlReader reader;        // 0x58

        // Methods
        private System.Void .ctor(System.Xml.XmlNamespaceManager nsMgr, System.Xml.XmlReader reader) { }
        private System.String LookupNamespace(System.String prefix) { }

    }

    // TypeToken: 0x200027F
    public struct DateTimeTypeCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XsdDateTime.DateTimeTypeCode DateTime;        // 0x0
        public static System.Xml.Schema.XsdDateTime.DateTimeTypeCode Time;        // 0x0
        public static System.Xml.Schema.XsdDateTime.DateTimeTypeCode Date;        // 0x0
        public static System.Xml.Schema.XsdDateTime.DateTimeTypeCode GYearMonth;        // 0x0
        public static System.Xml.Schema.XsdDateTime.DateTimeTypeCode GYear;        // 0x0
        public static System.Xml.Schema.XsdDateTime.DateTimeTypeCode GMonthDay;        // 0x0
        public static System.Xml.Schema.XsdDateTime.DateTimeTypeCode GDay;        // 0x0
        public static System.Xml.Schema.XsdDateTime.DateTimeTypeCode GMonth;        // 0x0
        public static System.Xml.Schema.XsdDateTime.DateTimeTypeCode XdrDateTime;        // 0x0

    }

    // TypeToken: 0x2000280
    public struct XsdDateTimeKind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XsdDateTime.XsdDateTimeKind Unspecified;        // 0x0
        public static System.Xml.Schema.XsdDateTime.XsdDateTimeKind Zulu;        // 0x0
        public static System.Xml.Schema.XsdDateTime.XsdDateTimeKind LocalWestOfZulu;        // 0x0
        public static System.Xml.Schema.XsdDateTime.XsdDateTimeKind LocalEastOfZulu;        // 0x0

    }

    // TypeToken: 0x2000281
    public struct Parser
    {
        // Fields
        public System.Xml.Schema.XsdDateTime.DateTimeTypeCode typeCode;        // 0x10
        public System.Int32 year;        // 0x14
        public System.Int32 month;        // 0x18
        public System.Int32 day;        // 0x1C
        public System.Int32 hour;        // 0x20
        public System.Int32 minute;        // 0x24
        public System.Int32 second;        // 0x28
        public System.Int32 fraction;        // 0x2C
        public System.Xml.Schema.XsdDateTime.XsdDateTimeKind kind;        // 0x30
        public System.Int32 zoneHour;        // 0x34
        public System.Int32 zoneMinute;        // 0x38
        private System.String text;        // 0x40
        private System.Int32 length;        // 0x48
        private static System.Int32[] Power10;        // 0x0

        // Methods
        private System.Boolean Parse(System.String text, System.Xml.Schema.XsdDateTimeFlags kinds) { }
        private System.Boolean ParseDate(System.Int32 start) { }
        private System.Boolean ParseTimeAndZoneAndWhitespace(System.Int32 start) { }
        private System.Boolean ParseTimeAndWhitespace(System.Int32 start) { }
        private System.Boolean ParseTime(System.Int32& start) { }
        private System.Boolean ParseZoneAndWhitespace(System.Int32 start) { }
        private System.Boolean Parse4Dig(System.Int32 start, System.Int32& num) { }
        private System.Boolean Parse2Dig(System.Int32 start, System.Int32& num) { }
        private System.Boolean ParseChar(System.Int32 start, System.Char ch) { }
        private System.Boolean Test(System.Xml.Schema.XsdDateTimeFlags left, System.Xml.Schema.XsdDateTimeFlags right) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000283
    public struct Parts
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XsdDuration.Parts HasNone;        // 0x0
        public static System.Xml.Schema.XsdDuration.Parts HasYears;        // 0x0
        public static System.Xml.Schema.XsdDuration.Parts HasMonths;        // 0x0
        public static System.Xml.Schema.XsdDuration.Parts HasDays;        // 0x0
        public static System.Xml.Schema.XsdDuration.Parts HasHours;        // 0x0
        public static System.Xml.Schema.XsdDuration.Parts HasMinutes;        // 0x0
        public static System.Xml.Schema.XsdDuration.Parts HasSeconds;        // 0x0

    }

    // TypeToken: 0x2000284
    public struct DurationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XsdDuration.DurationType Duration;        // 0x0
        public static System.Xml.Schema.XsdDuration.DurationType YearMonthDuration;        // 0x0
        public static System.Xml.Schema.XsdDuration.DurationType DayTimeDuration;        // 0x0

    }

    // TypeToken: 0x2000288
    public struct AstType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MS.Internal.Xml.XPath.AstNode.AstType Axis;        // 0x0
        public static MS.Internal.Xml.XPath.AstNode.AstType Operator;        // 0x0
        public static MS.Internal.Xml.XPath.AstNode.AstType Filter;        // 0x0
        public static MS.Internal.Xml.XPath.AstNode.AstType ConstantOperand;        // 0x0
        public static MS.Internal.Xml.XPath.AstNode.AstType Function;        // 0x0
        public static MS.Internal.Xml.XPath.AstNode.AstType Group;        // 0x0
        public static MS.Internal.Xml.XPath.AstNode.AstType Root;        // 0x0
        public static MS.Internal.Xml.XPath.AstNode.AstType Variable;        // 0x0
        public static MS.Internal.Xml.XPath.AstNode.AstType Error;        // 0x0

    }

    // TypeToken: 0x200028B
    public struct AxisType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MS.Internal.Xml.XPath.Axis.AxisType Ancestor;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType AncestorOrSelf;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType Attribute;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType Child;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType Descendant;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType DescendantOrSelf;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType Following;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType FollowingSibling;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType Namespace;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType Parent;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType Preceding;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType PrecedingSibling;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType Self;        // 0x0
        public static MS.Internal.Xml.XPath.Axis.AxisType None;        // 0x0

    }

    // TypeToken: 0x2000295
    public class UndefinedXsltContext : XsltContext
    {
        // Fields
        private System.Xml.IXmlNamespaceResolver _nsResolver;        // 0x50

        // Methods
        private System.Void .ctor(System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.String get_DefaultNamespace() { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.Xml.Xsl.IXsltContextVariable ResolveVariable(System.String prefix, System.String name) { }
        private System.Xml.Xsl.IXsltContextFunction ResolveFunction(System.String prefix, System.String name, System.Xml.XPath.XPathResultType[] ArgTypes) { }
        private System.Boolean get_Whitespace() { }
        private System.Boolean PreserveWhitespace(System.Xml.XPath.XPathNavigator node) { }

    }

    // TypeToken: 0x20002A3
    public struct FunctionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncLast;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncPosition;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncCount;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncID;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncLocalName;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncNameSpaceUri;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncName;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncString;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncBoolean;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncNumber;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncTrue;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncFalse;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncNot;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncConcat;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncStartsWith;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncContains;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncSubstringBefore;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncSubstringAfter;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncSubstring;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncStringLength;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncNormalize;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncTranslate;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncLang;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncSum;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncFloor;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncCeiling;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncRound;        // 0x0
        public static MS.Internal.Xml.XPath.Function.FunctionType FuncUserDefined;        // 0x0

    }

    // TypeToken: 0x20002AA
    public class cmpXslt : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }

    }

    // TypeToken: 0x20002AB
    public struct NodeSet
    {
        // Fields
        private MS.Internal.Xml.XPath.Query _opnd;        // 0x10
        private System.Xml.XPath.XPathNavigator _current;        // 0x18

        // Methods
        private System.Void .ctor(System.Object opnd) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.String get_Value() { }

    }

    // TypeToken: 0x20002B4
    public struct Op
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MS.Internal.Xml.XPath.Operator.Op INVALID;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op OR;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op AND;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op EQ;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op NE;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op LT;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op LE;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op GT;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op GE;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op PLUS;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op MINUS;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op MUL;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op DIV;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op MOD;        // 0x0
        public static MS.Internal.Xml.XPath.Operator.Op UNION;        // 0x0

    }

    // TypeToken: 0x20002BB
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MS.Internal.Xml.XPath.QueryBuilder.Flags None;        // 0x0
        public static MS.Internal.Xml.XPath.QueryBuilder.Flags SmartDesc;        // 0x0
        public static MS.Internal.Xml.XPath.QueryBuilder.Flags PosFilter;        // 0x0
        public static MS.Internal.Xml.XPath.QueryBuilder.Flags Filter;        // 0x0

    }

    // TypeToken: 0x20002BC
    public struct Props
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MS.Internal.Xml.XPath.QueryBuilder.Props None;        // 0x0
        public static MS.Internal.Xml.XPath.QueryBuilder.Props PosFilter;        // 0x0
        public static MS.Internal.Xml.XPath.QueryBuilder.Props HasPosition;        // 0x0
        public static MS.Internal.Xml.XPath.QueryBuilder.Props HasLast;        // 0x0
        public static MS.Internal.Xml.XPath.QueryBuilder.Props NonFlat;        // 0x0

    }

    // TypeToken: 0x20002CC
    public class ParamInfo
    {
        // Fields
        private MS.Internal.Xml.XPath.Function.FunctionType _ftype;        // 0x10
        private System.Int32 _minargs;        // 0x14
        private System.Int32 _maxargs;        // 0x18
        private System.Xml.XPath.XPathResultType[] _argTypes;        // 0x20

        // Methods
        private MS.Internal.Xml.XPath.Function.FunctionType get_FType() { }
        private System.Int32 get_Minargs() { }
        private System.Int32 get_Maxargs() { }
        private System.Xml.XPath.XPathResultType[] get_ArgTypes() { }
        private System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType ftype, System.Int32 minargs, System.Int32 maxargs, System.Xml.XPath.XPathResultType[] argTypes) { }

    }

    // TypeToken: 0x20002CE
    public struct LexKind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Comma;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Slash;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind At;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Dot;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind LParens;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind RParens;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind LBracket;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind RBracket;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Star;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Plus;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Minus;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Eq;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Lt;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Gt;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Bang;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Dollar;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Apos;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Quote;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Union;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Ne;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Le;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Ge;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind And;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Or;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind DotDot;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind SlashSlash;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Name;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind String;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Number;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Axe;        // 0x0
        public static MS.Internal.Xml.XPath.XPathScanner.LexKind Eof;        // 0x0

    }

    // TypeToken: 0x20002DE
    public struct __StaticArrayInitTypeSize=6
    {
    }

    // TypeToken: 0x20002DF
    public struct __StaticArrayInitTypeSize=12
    {
    }

    // TypeToken: 0x20002E0
    public struct __StaticArrayInitTypeSize=16
    {
    }

    // TypeToken: 0x20002E1
    public struct __StaticArrayInitTypeSize=20
    {
    }

    // TypeToken: 0x20002E2
    public struct __StaticArrayInitTypeSize=24
    {
    }

    // TypeToken: 0x20002E3
    public struct __StaticArrayInitTypeSize=28
    {
    }

    // TypeToken: 0x20002E4
    public struct __StaticArrayInitTypeSize=32
    {
    }

    // TypeToken: 0x20002E5
    public struct __StaticArrayInitTypeSize=36
    {
    }

    // TypeToken: 0x20002E6
    public struct __StaticArrayInitTypeSize=38
    {
    }

    // TypeToken: 0x20002E7
    public struct __StaticArrayInitTypeSize=40
    {
    }

    // TypeToken: 0x20002E8
    public struct __StaticArrayInitTypeSize=44
    {
    }

    // TypeToken: 0x20002E9
    public struct __StaticArrayInitTypeSize=56
    {
    }

    // TypeToken: 0x20002EA
    public struct __StaticArrayInitTypeSize=64
    {
    }

    // TypeToken: 0x20002EB
    public struct __StaticArrayInitTypeSize=68
    {
    }

    // TypeToken: 0x20002EC
    public struct __StaticArrayInitTypeSize=112
    {
    }

    // TypeToken: 0x20002ED
    public struct __StaticArrayInitTypeSize=144
    {
    }

    // TypeToken: 0x20002EE
    public struct __StaticArrayInitTypeSize=416
    {
    }

    // TypeToken: 0x20002EF
    public struct __StaticArrayInitTypeSize=664
    {
    }

    // TypeToken: 0x20002F0
    public struct __StaticArrayInitTypeSize=960
    {
    }

    // TypeToken: 0x20002F1
    public struct __StaticArrayInitTypeSize=1212
    {
    }

namespace MS.Internal.Xml.Cache
{

    // TypeToken: 0x20002D2
    public class XPathDocumentBaseIterator : XPathNodeIterator
    {
        // Fields
        protected MS.Internal.Xml.Cache.XPathDocumentNavigator ctxt;        // 0x18
        protected System.Int32 pos;        // 0x20

        // Methods
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator ctxt) { }
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentBaseIterator iter) { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }

    }

    // TypeToken: 0x20002D3
    public class XPathDocumentElementChildIterator : XPathDocumentBaseIterator
    {
        // Fields
        private System.String _localName;        // 0x28
        private System.String _namespaceUri;        // 0x30

        // Methods
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator parent, System.String name, System.String namespaceURI) { }
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentElementChildIterator iter) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x20002D4
    public class XPathDocumentKindChildIterator : XPathDocumentBaseIterator
    {
        // Fields
        private System.Xml.XPath.XPathNodeType _typ;        // 0x28

        // Methods
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator parent, System.Xml.XPath.XPathNodeType typ) { }
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentKindChildIterator iter) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x20002D5
    public class XPathDocumentElementDescendantIterator : XPathDocumentBaseIterator
    {
        // Fields
        private MS.Internal.Xml.Cache.XPathDocumentNavigator _end;        // 0x28
        private System.String _localName;        // 0x30
        private System.String _namespaceUri;        // 0x38
        private System.Boolean _matchSelf;        // 0x40

        // Methods
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator root, System.String name, System.String namespaceURI, System.Boolean matchSelf) { }
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentElementDescendantIterator iter) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x20002D6
    public class XPathDocumentKindDescendantIterator : XPathDocumentBaseIterator
    {
        // Fields
        private MS.Internal.Xml.Cache.XPathDocumentNavigator _end;        // 0x28
        private System.Xml.XPath.XPathNodeType _typ;        // 0x30
        private System.Boolean _matchSelf;        // 0x34

        // Methods
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator root, System.Xml.XPath.XPathNodeType typ, System.Boolean matchSelf) { }
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentKindDescendantIterator iter) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x20002D7
    public class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo
    {
        // Fields
        private MS.Internal.Xml.Cache.XPathNode[] _pageCurrent;        // 0x10
        private MS.Internal.Xml.Cache.XPathNode[] _pageParent;        // 0x18
        private System.Int32 _idxCurrent;        // 0x20
        private System.Int32 _idxParent;        // 0x24
        private System.String _atomizedLocalName;        // 0x28

        // Methods
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathNode[] pageCurrent, System.Int32 idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageParent, System.Int32 idxParent) { }
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator nav) { }
        private System.String get_Value() { }
        private System.Xml.XPath.XPathNavigator Clone() { }
        private System.Xml.XPath.XPathNodeType get_NodeType() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Name() { }
        private System.String get_Prefix() { }
        private System.String get_BaseURI() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }
        private System.Boolean MoveToAttribute(System.String localName, System.String namespaceURI) { }
        private System.Boolean MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope) { }
        private System.Boolean MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope scope) { }
        private System.Boolean MoveToNext() { }
        private System.Boolean MoveToFirstChild() { }
        private System.Boolean MoveToParent() { }
        private System.Boolean MoveTo(System.Xml.XPath.XPathNavigator other) { }
        private System.Boolean MoveToId(System.String id) { }
        private System.Boolean IsSamePosition(System.Xml.XPath.XPathNavigator other) { }
        private System.Void MoveToRoot() { }
        private System.Boolean MoveToChild(System.String localName, System.String namespaceURI) { }
        private System.Boolean MoveToNext(System.String localName, System.String namespaceURI) { }
        private System.Boolean MoveToChild(System.Xml.XPath.XPathNodeType type) { }
        private System.Boolean MoveToNext(System.Xml.XPath.XPathNodeType type) { }
        private System.Boolean MoveToFollowing(System.String localName, System.String namespaceURI, System.Xml.XPath.XPathNavigator end) { }
        private System.Boolean MoveToFollowing(System.Xml.XPath.XPathNodeType type, System.Xml.XPath.XPathNavigator end) { }
        private System.Xml.XPath.XPathNodeIterator SelectChildren(System.Xml.XPath.XPathNodeType type) { }
        private System.Xml.XPath.XPathNodeIterator SelectChildren(System.String name, System.String namespaceURI) { }
        private System.Xml.XPath.XPathNodeIterator SelectDescendants(System.Xml.XPath.XPathNodeType type, System.Boolean matchSelf) { }
        private System.Xml.XPath.XPathNodeIterator SelectDescendants(System.String name, System.String namespaceURI, System.Boolean matchSelf) { }
        private System.Xml.XmlNodeOrder ComparePosition(System.Xml.XPath.XPathNavigator other) { }
        private System.Boolean IsDescendant(System.Xml.XPath.XPathNavigator other) { }
        private System.Int32 GetPrimaryLocation() { }
        private System.Int32 GetSecondaryLocation() { }
        private System.Object get_UnderlyingObject() { }
        private System.Boolean HasLineInfo() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }
        private System.Int32 GetPositionHashCode() { }
        private System.Boolean IsElementMatch(System.String localName, System.String namespaceURI) { }
        private System.Boolean IsKindMatch(System.Xml.XPath.XPathNodeType typ) { }
        private System.Int32 GetFollowingEnd(MS.Internal.Xml.Cache.XPathDocumentNavigator end, System.Boolean useParentOfVirtual, MS.Internal.Xml.Cache.XPathNode[]& pageEnd) { }

    }

    // TypeToken: 0x20002D8
    public struct XPathNode
    {
        // Fields
        private MS.Internal.Xml.Cache.XPathNodeInfoAtom _info;        // 0x10
        private System.UInt16 _idxSibling;        // 0x18
        private System.UInt16 _idxParent;        // 0x1A
        private System.UInt16 _idxSimilar;        // 0x1C
        private System.UInt16 _posOffset;        // 0x1E
        private System.UInt32 _props;        // 0x20
        private System.String _value;        // 0x28

        // Methods
        private System.Xml.XPath.XPathNodeType get_NodeType() { }
        private System.String get_Prefix() { }
        private System.String get_LocalName() { }
        private System.String get_Name() { }
        private System.String get_NamespaceUri() { }
        private System.Xml.XPath.XPathDocument get_Document() { }
        private System.String get_BaseUri() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }
        private System.Int32 get_CollapsedLinePosition() { }
        private MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo() { }
        private System.Int32 GetRoot(MS.Internal.Xml.Cache.XPathNode[]& pageNode) { }
        private System.Int32 GetParent(MS.Internal.Xml.Cache.XPathNode[]& pageNode) { }
        private System.Int32 GetSibling(MS.Internal.Xml.Cache.XPathNode[]& pageNode) { }
        private System.Int32 GetSimilarElement(MS.Internal.Xml.Cache.XPathNode[]& pageNode) { }
        private System.Boolean NameMatch(System.String localName, System.String namespaceName) { }
        private System.Boolean ElementMatch(System.String localName, System.String namespaceName) { }
        private System.Boolean get_IsXmlNamespaceNode() { }
        private System.Boolean get_HasSibling() { }
        private System.Boolean get_HasCollapsedText() { }
        private System.Boolean get_HasAttribute() { }
        private System.Boolean get_HasContentChild() { }
        private System.Boolean get_HasElementChild() { }
        private System.Boolean get_IsAttrNmsp() { }
        private System.Boolean get_IsText() { }
        private System.Boolean get_HasNamespaceDecls() { }
        private System.String get_Value() { }

    }

    // TypeToken: 0x20002D9
    public struct XPathNodeRef
    {
        // Fields
        private MS.Internal.Xml.Cache.XPathNode[] _page;        // 0x10
        private System.Int32 _idx;        // 0x18

        // Methods
        private System.Void .ctor(MS.Internal.Xml.Cache.XPathNode[] page, System.Int32 idx) { }
        private MS.Internal.Xml.Cache.XPathNode[] get_Page() { }
        private System.Int32 get_Index() { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x20002DA
    public class XPathNodeHelper
    {
        // Methods
        private System.Int32 GetLocalNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, System.Int32 idxElem, MS.Internal.Xml.Cache.XPathNode[]& pageNmsp) { }
        private System.Int32 GetInScopeNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, System.Int32 idxElem, MS.Internal.Xml.Cache.XPathNode[]& pageNmsp) { }
        private System.Boolean GetFirstAttribute(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode) { }
        private System.Boolean GetNextAttribute(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode) { }
        private System.Boolean GetContentChild(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode) { }
        private System.Boolean GetContentSibling(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode) { }
        private System.Boolean GetParent(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode) { }
        private System.Int32 GetLocation(MS.Internal.Xml.Cache.XPathNode[] pageNode, System.Int32 idxNode) { }
        private System.Boolean GetElementChild(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode, System.String localName, System.String namespaceName) { }
        private System.Boolean GetElementSibling(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode, System.String localName, System.String namespaceName) { }
        private System.Boolean GetContentChild(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode, System.Xml.XPath.XPathNodeType typ) { }
        private System.Boolean GetContentSibling(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode, System.Xml.XPath.XPathNodeType typ) { }
        private System.Boolean GetAttribute(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode, System.String localName, System.String namespaceName) { }
        private System.Boolean GetElementFollowing(MS.Internal.Xml.Cache.XPathNode[]& pageCurrent, System.Int32& idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageEnd, System.Int32 idxEnd, System.String localName, System.String namespaceName) { }
        private System.Boolean GetContentFollowing(MS.Internal.Xml.Cache.XPathNode[]& pageCurrent, System.Int32& idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageEnd, System.Int32 idxEnd, System.Xml.XPath.XPathNodeType typ) { }
        private System.Boolean GetTextFollowing(MS.Internal.Xml.Cache.XPathNode[]& pageCurrent, System.Int32& idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageEnd, System.Int32 idxEnd) { }
        private System.Boolean GetNonDescendant(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode) { }
        private System.Void GetChild(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode) { }

    }

    // TypeToken: 0x20002DB
    public class XPathNodePageInfo
    {
        // Fields
        private System.Int32 _pageNum;        // 0x10
        private System.Int32 _nodeCount;        // 0x14
        private MS.Internal.Xml.Cache.XPathNode[] _pageNext;        // 0x18

        // Methods
        private System.Int32 get_PageNumber() { }
        private System.Int32 get_NodeCount() { }
        private MS.Internal.Xml.Cache.XPathNode[] get_NextPage() { }

    }

    // TypeToken: 0x20002DC
    public class XPathNodeInfoAtom
    {
        // Fields
        private System.String _localName;        // 0x10
        private System.String _namespaceUri;        // 0x18
        private System.String _prefix;        // 0x20
        private System.String _baseUri;        // 0x28
        private MS.Internal.Xml.Cache.XPathNode[] _pageParent;        // 0x30
        private MS.Internal.Xml.Cache.XPathNode[] _pageSibling;        // 0x38
        private MS.Internal.Xml.Cache.XPathNode[] _pageSimilar;        // 0x40
        private System.Xml.XPath.XPathDocument _doc;        // 0x48
        private System.Int32 _lineNumBase;        // 0x50
        private System.Int32 _linePosBase;        // 0x54
        private MS.Internal.Xml.Cache.XPathNodePageInfo _pageInfo;        // 0x58

        // Methods
        private MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceUri() { }
        private System.String get_Prefix() { }
        private System.String get_BaseUri() { }
        private MS.Internal.Xml.Cache.XPathNode[] get_SiblingPage() { }
        private MS.Internal.Xml.Cache.XPathNode[] get_SimilarElementPage() { }
        private MS.Internal.Xml.Cache.XPathNode[] get_ParentPage() { }
        private System.Xml.XPath.XPathDocument get_Document() { }
        private System.Int32 get_LineNumberBase() { }
        private System.Int32 get_LinePositionBase() { }

    }

}

namespace MS.Internal.Xml.XPath
{

    // TypeToken: 0x2000286
    public class AbsoluteQuery : ContextQuery
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(MS.Internal.Xml.XPath.AbsoluteQuery other) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x2000287
    public class AstNode
    {
        // Methods
        private MS.Internal.Xml.XPath.AstNode.AstType get_Type() { }
        private System.Xml.XPath.XPathResultType get_ReturnType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000289
    public class AttributeQuery : BaseAxisQuery
    {
        // Fields
        private System.Boolean _onAttribute;        // 0x58

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.AttributeQuery other) { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x200028A
    public class Axis : AstNode
    {
        // Fields
        private MS.Internal.Xml.XPath.Axis.AxisType _axisType;        // 0x10
        private MS.Internal.Xml.XPath.AstNode _input;        // 0x18
        private System.String _prefix;        // 0x20
        private System.String _name;        // 0x28
        private System.Xml.XPath.XPathNodeType _nodeType;        // 0x30
        protected System.Boolean abbrAxis;        // 0x34
        private System.String _urn;        // 0x38

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input, System.String prefix, System.String name, System.Xml.XPath.XPathNodeType nodetype) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input) { }
        private MS.Internal.Xml.XPath.AstNode.AstType get_Type() { }
        private System.Xml.XPath.XPathResultType get_ReturnType() { }
        private MS.Internal.Xml.XPath.AstNode get_Input() { }
        private System.Void set_Input(MS.Internal.Xml.XPath.AstNode value) { }
        private System.String get_Prefix() { }
        private System.String get_Name() { }
        private System.Xml.XPath.XPathNodeType get_NodeType() { }
        private MS.Internal.Xml.XPath.Axis.AxisType get_TypeOfAxis() { }
        private System.Boolean get_AbbrAxis() { }
        private System.String get_Urn() { }
        private System.Void set_Urn(System.String value) { }

    }

    // TypeToken: 0x200028C
    public class BaseAxisQuery : Query
    {
        // Fields
        private MS.Internal.Xml.XPath.Query qyInput;        // 0x18
        private System.Boolean _nameTest;        // 0x20
        private System.String _name;        // 0x28
        private System.String _prefix;        // 0x30
        private System.String _nsUri;        // 0x38
        private System.Xml.XPath.XPathNodeType _typeTest;        // 0x40
        protected System.Xml.XPath.XPathNavigator currentNode;        // 0x48
        protected System.Int32 position;        // 0x50

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.BaseAxisQuery other) { }
        private System.Void Reset() { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.String get_Name() { }
        private System.String get_Namespace() { }
        private System.Boolean get_NameTest() { }
        private System.Xml.XPath.XPathNodeType get_TypeTest() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Boolean matches(System.Xml.XPath.XPathNavigator e) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }

    }

    // TypeToken: 0x200028D
    public class BooleanExpr : ValueQuery
    {
        // Fields
        private MS.Internal.Xml.XPath.Query _opnd1;        // 0x18
        private MS.Internal.Xml.XPath.Query _opnd2;        // 0x20
        private System.Boolean _isOr;        // 0x28

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.Query opnd1, MS.Internal.Xml.XPath.Query opnd2) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.BooleanExpr other) { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }

    }

    // TypeToken: 0x200028E
    public class BooleanFunctions : ValueQuery
    {
        // Fields
        private MS.Internal.Xml.XPath.Query _arg;        // 0x18
        private MS.Internal.Xml.XPath.Function.FunctionType _funcType;        // 0x20

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType funcType, MS.Internal.Xml.XPath.Query arg) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.BooleanFunctions other) { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Boolean toBoolean(System.Double number) { }
        private System.Boolean toBoolean(System.String str) { }
        private System.Boolean toBoolean(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Boolean Not(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Boolean Lang(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x200028F
    public class CacheAxisQuery : BaseAxisQuery
    {
        // Fields
        protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer;        // 0x58

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.CacheAxisQuery other) { }
        private System.Void Reset() { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Int32 get_Count() { }
        private MS.Internal.Xml.XPath.QueryProps get_Properties() { }

    }

    // TypeToken: 0x2000290
    public class CacheChildrenQuery : ChildrenQuery
    {
        // Fields
        private System.Xml.XPath.XPathNavigator _nextInput;        // 0x60
        private MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator> _elementStk;        // 0x68
        private MS.Internal.Xml.XPath.ClonableStack<System.Int32> _positionStk;        // 0x70
        private System.Boolean _needInput;        // 0x78

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType type) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.CacheChildrenQuery other) { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Boolean DecideNextNode() { }
        private System.Xml.XPath.XPathNavigator GetNextInput() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x2000291
    public class CacheOutputQuery : Query
    {
        // Fields
        private MS.Internal.Xml.XPath.Query input;        // 0x18
        protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer;        // 0x20

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query input) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.CacheOutputQuery other) { }
        private System.Void Reset() { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Int32 get_Count() { }
        private MS.Internal.Xml.XPath.QueryProps get_Properties() { }

    }

    // TypeToken: 0x2000292
    public class ChildrenQuery : BaseAxisQuery
    {
        // Fields
        private System.Xml.XPath.XPathNodeIterator _iterator;        // 0x58

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType type) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.ChildrenQuery other) { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x2000293
    public class ClonableStack`1 : List`1
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection) { }
        private System.Void Push(T value) { }
        private T Pop() { }
        private T Peek() { }
        private MS.Internal.Xml.XPath.ClonableStack<T> Clone() { }

    }

    // TypeToken: 0x2000294
    public class CompiledXpathExpr : XPathExpression
    {
        // Fields
        private MS.Internal.Xml.XPath.Query _query;        // 0x10
        private System.String _expr;        // 0x18
        private System.Boolean _needContext;        // 0x20

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query query, System.String expression, System.Boolean needContext) { }
        private MS.Internal.Xml.XPath.Query get_QueryTree() { }
        private System.Void SetContext(System.Xml.IXmlNamespaceResolver nsResolver) { }

    }

    // TypeToken: 0x2000296
    public class ContextQuery : Query
    {
        // Fields
        protected System.Xml.XPath.XPathNavigator contextNode;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(MS.Internal.Xml.XPath.ContextQuery other) { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Int32 get_Count() { }
        private MS.Internal.Xml.XPath.QueryProps get_Properties() { }

    }

    // TypeToken: 0x2000297
    public class DescendantBaseQuery : BaseAxisQuery
    {
        // Fields
        protected System.Boolean matchSelf;        // 0x58
        protected System.Boolean abbrAxis;        // 0x59

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type, System.Boolean matchSelf, System.Boolean abbrAxis) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.DescendantBaseQuery other) { }

    }

    // TypeToken: 0x2000298
    public class DescendantQuery : DescendantBaseQuery
    {
        // Fields
        private System.Xml.XPath.XPathNodeIterator _nodeIterator;        // 0x60

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type, System.Boolean matchSelf, System.Boolean abbrAxis) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.DescendantQuery other) { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x2000299
    public class DescendantOverDescendantQuery : DescendantBaseQuery
    {
        // Fields
        private System.Int32 _level;        // 0x60

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, System.Boolean matchSelf, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest, System.Boolean abbrAxis) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.DescendantOverDescendantQuery other) { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Boolean MoveToFirstChild() { }
        private System.Boolean MoveUpUntilNext() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x200029A
    public class DocumentOrderQuery : CacheOutputQuery
    {
        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.DocumentOrderQuery other) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x200029B
    public class EmptyQuery : Query
    {
        // Methods
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Int32 get_CurrentPosition() { }
        private System.Int32 get_Count() { }
        private MS.Internal.Xml.XPath.QueryProps get_Properties() { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200029C
    public class ExtensionQuery : Query
    {
        // Fields
        protected System.String prefix;        // 0x18
        protected System.String name;        // 0x20
        protected System.Xml.Xsl.XsltContext xsltContext;        // 0x28
        private MS.Internal.Xml.XPath.ResetableIterator _queryIterator;        // 0x30

        // Methods
        private System.Void .ctor(System.String prefix, System.String name) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.ExtensionQuery other) { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Object ProcessResult(System.Object value) { }
        private System.String get_QName() { }
        private System.Int32 get_Count() { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }

    }

    // TypeToken: 0x200029D
    public class Filter : AstNode
    {
        // Fields
        private MS.Internal.Xml.XPath.AstNode _input;        // 0x10
        private MS.Internal.Xml.XPath.AstNode _condition;        // 0x18

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.AstNode input, MS.Internal.Xml.XPath.AstNode condition) { }
        private MS.Internal.Xml.XPath.AstNode.AstType get_Type() { }
        private System.Xml.XPath.XPathResultType get_ReturnType() { }
        private MS.Internal.Xml.XPath.AstNode get_Input() { }
        private MS.Internal.Xml.XPath.AstNode get_Condition() { }

    }

    // TypeToken: 0x200029E
    public class FilterQuery : BaseAxisQuery
    {
        // Fields
        private MS.Internal.Xml.XPath.Query _cond;        // 0x58
        private System.Boolean _noPosition;        // 0x60

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, MS.Internal.Xml.XPath.Query cond, System.Boolean noPosition) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.FilterQuery other) { }
        private System.Void Reset() { }
        private MS.Internal.Xml.XPath.Query get_Condition() { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext input) { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Boolean EvaluatePredicate() { }
        private MS.Internal.Xml.XPath.QueryProps get_Properties() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x200029F
    public class FollSiblingQuery : BaseAxisQuery
    {
        // Fields
        private MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator> _elementStk;        // 0x58
        private System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> _parentStk;        // 0x60
        private System.Xml.XPath.XPathNavigator _nextInput;        // 0x68

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType type) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.FollSiblingQuery other) { }
        private System.Void Reset() { }
        private System.Boolean Visited(System.Xml.XPath.XPathNavigator nav) { }
        private System.Xml.XPath.XPathNavigator FetchInput() { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002A0
    public class FollowingQuery : BaseAxisQuery
    {
        // Fields
        private System.Xml.XPath.XPathNavigator _input;        // 0x58
        private System.Xml.XPath.XPathNodeIterator _iterator;        // 0x60

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.FollowingQuery other) { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002A1
    public class ForwardPositionQuery : CacheOutputQuery
    {
        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query input) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.ForwardPositionQuery other) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002A2
    public class Function : AstNode
    {
        // Fields
        private MS.Internal.Xml.XPath.Function.FunctionType _functionType;        // 0x10
        private System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> _argumentList;        // 0x18
        private System.String _name;        // 0x20
        private System.String _prefix;        // 0x28
        private static System.Xml.XPath.XPathResultType[] ReturnTypes;        // 0x0

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType ftype, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }
        private System.Void .ctor(System.String prefix, System.String name, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType ftype, MS.Internal.Xml.XPath.AstNode arg) { }
        private MS.Internal.Xml.XPath.AstNode.AstType get_Type() { }
        private System.Xml.XPath.XPathResultType get_ReturnType() { }
        private MS.Internal.Xml.XPath.Function.FunctionType get_TypeOfFunction() { }
        private System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> get_ArgumentList() { }
        private System.String get_Prefix() { }
        private System.String get_Name() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002A4
    public class FunctionQuery : ExtensionQuery
    {
        // Fields
        private System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> _args;        // 0x38
        private System.Xml.Xsl.IXsltContextFunction _function;        // 0x40

        // Methods
        private System.Void .ctor(System.String prefix, System.String name, System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> args) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.FunctionQuery other) { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002A5
    public class Group : AstNode
    {
        // Fields
        private MS.Internal.Xml.XPath.AstNode _groupNode;        // 0x10

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.AstNode groupNode) { }
        private MS.Internal.Xml.XPath.AstNode.AstType get_Type() { }
        private System.Xml.XPath.XPathResultType get_ReturnType() { }
        private MS.Internal.Xml.XPath.AstNode get_GroupNode() { }

    }

    // TypeToken: 0x20002A6
    public class GroupQuery : BaseAxisQuery
    {
        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qy) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.GroupQuery other) { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private MS.Internal.Xml.XPath.QueryProps get_Properties() { }

    }

    // TypeToken: 0x20002A7
    public class IDQuery : CacheOutputQuery
    {
        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query arg) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.IDQuery other) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Void ProcessIds(System.Xml.XPath.XPathNavigator contextNode, System.String val) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002A8
    public class IteratorFilter : XPathNodeIterator
    {
        // Fields
        private System.Xml.XPath.XPathNodeIterator _innerIterator;        // 0x18
        private System.String _name;        // 0x20
        private System.Int32 _position;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XPath.XPathNodeIterator innerIterator, System.String name) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.IteratorFilter it) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x20002A9
    public class LogicalExpr : ValueQuery
    {
        // Fields
        private MS.Internal.Xml.XPath.Operator.Op _op;        // 0x18
        private MS.Internal.Xml.XPath.Query _opnd1;        // 0x20
        private MS.Internal.Xml.XPath.Query _opnd2;        // 0x28
        private static readonly MS.Internal.Xml.XPath.LogicalExpr.cmpXslt[][] s_CompXsltE;        // 0x0
        private static readonly MS.Internal.Xml.XPath.LogicalExpr.cmpXslt[][] s_CompXsltO;        // 0x8

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.Query opnd1, MS.Internal.Xml.XPath.Query opnd2) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.LogicalExpr other) { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Boolean cmpQueryQueryE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpQueryQueryO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpQueryNumber(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpQueryStringE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpQueryStringO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpRtfQueryE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpRtfQueryO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpQueryBoolE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpQueryBoolO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpBoolBoolE(MS.Internal.Xml.XPath.Operator.Op op, System.Boolean n1, System.Boolean n2) { }
        private System.Boolean cmpBoolBoolE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpBoolBoolO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpBoolNumberE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpBoolNumberO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpBoolStringE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpRtfBoolE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpBoolStringO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpRtfBoolO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpNumberNumber(MS.Internal.Xml.XPath.Operator.Op op, System.Double n1, System.Double n2) { }
        private System.Boolean cmpNumberNumberO(MS.Internal.Xml.XPath.Operator.Op op, System.Double n1, System.Double n2) { }
        private System.Boolean cmpNumberNumber(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpStringNumber(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpRtfNumber(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpStringStringE(MS.Internal.Xml.XPath.Operator.Op op, System.String n1, System.String n2) { }
        private System.Boolean cmpStringStringE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpRtfStringE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpRtfRtfE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpStringStringO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpRtfStringO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Boolean cmpRtfRtfO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.String Rtf(System.Object o) { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002AC
    public class MergeFilterQuery : CacheOutputQuery
    {
        // Fields
        private MS.Internal.Xml.XPath.Query _child;        // 0x28

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query input, MS.Internal.Xml.XPath.Query child) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.MergeFilterQuery other) { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext xsltContext) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002AD
    public class NamespaceQuery : BaseAxisQuery
    {
        // Fields
        private System.Boolean _onNamespace;        // 0x58

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.NamespaceQuery other) { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Boolean matches(System.Xml.XPath.XPathNavigator e) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002AE
    public class NodeFunctions : ValueQuery
    {
        // Fields
        private MS.Internal.Xml.XPath.Query _arg;        // 0x18
        private MS.Internal.Xml.XPath.Function.FunctionType _funcType;        // 0x20
        private System.Xml.Xsl.XsltContext _xsltContext;        // 0x28

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType funcType, MS.Internal.Xml.XPath.Query arg) { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.Xml.XPath.XPathNavigator EvaluateArg(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002AF
    public class NumberFunctions : ValueQuery
    {
        // Fields
        private MS.Internal.Xml.XPath.Query _arg;        // 0x18
        private MS.Internal.Xml.XPath.Function.FunctionType _ftype;        // 0x20

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType ftype, MS.Internal.Xml.XPath.Query arg) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.NumberFunctions other) { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.Double Number(System.Boolean arg) { }
        private System.Double Number(System.String arg) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Double Number(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Double Sum(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Double Floor(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Double Ceiling(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Double Round(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002B0
    public class NumericExpr : ValueQuery
    {
        // Fields
        private MS.Internal.Xml.XPath.Operator.Op _op;        // 0x18
        private MS.Internal.Xml.XPath.Query _opnd1;        // 0x20
        private MS.Internal.Xml.XPath.Query _opnd2;        // 0x28

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.Query opnd1, MS.Internal.Xml.XPath.Query opnd2) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.NumericExpr other) { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Double GetValue(MS.Internal.Xml.XPath.Operator.Op op, System.Double n1, System.Double n2) { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002B1
    public class Operand : AstNode
    {
        // Fields
        private System.Xml.XPath.XPathResultType _type;        // 0x10
        private System.Object _val;        // 0x18

        // Methods
        private System.Void .ctor(System.String val) { }
        private System.Void .ctor(System.Double val) { }
        private MS.Internal.Xml.XPath.AstNode.AstType get_Type() { }
        private System.Xml.XPath.XPathResultType get_ReturnType() { }
        private System.Object get_OperandValue() { }

    }

    // TypeToken: 0x20002B2
    public class OperandQuery : ValueQuery
    {
        // Fields
        private System.Object val;        // 0x18

        // Methods
        private System.Void .ctor(System.Object val) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002B3
    public class Operator : AstNode
    {
        // Fields
        private static MS.Internal.Xml.XPath.Operator.Op[] s_invertOp;        // 0x0
        private MS.Internal.Xml.XPath.Operator.Op _opType;        // 0x10
        private MS.Internal.Xml.XPath.AstNode _opnd1;        // 0x18
        private MS.Internal.Xml.XPath.AstNode _opnd2;        // 0x20

        // Methods
        private MS.Internal.Xml.XPath.Operator.Op InvertOperator(MS.Internal.Xml.XPath.Operator.Op op) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.AstNode opnd1, MS.Internal.Xml.XPath.AstNode opnd2) { }
        private MS.Internal.Xml.XPath.AstNode.AstType get_Type() { }
        private System.Xml.XPath.XPathResultType get_ReturnType() { }
        private MS.Internal.Xml.XPath.Operator.Op get_OperatorType() { }
        private MS.Internal.Xml.XPath.AstNode get_Operand1() { }
        private MS.Internal.Xml.XPath.AstNode get_Operand2() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002B5
    public class ParentQuery : CacheAxisQuery
    {
        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.ParentQuery other) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002B6
    public class PreSiblingQuery : CacheAxisQuery
    {
        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.PreSiblingQuery other) { }
        private System.Boolean NotVisited(System.Xml.XPath.XPathNavigator nav, System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> parentStk) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private MS.Internal.Xml.XPath.QueryProps get_Properties() { }

    }

    // TypeToken: 0x20002B7
    public class PrecedingQuery : BaseAxisQuery
    {
        // Fields
        private System.Xml.XPath.XPathNodeIterator _workIterator;        // 0x58
        private MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator> _ancestorStk;        // 0x60

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.PrecedingQuery other) { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private MS.Internal.Xml.XPath.QueryProps get_Properties() { }

    }

    // TypeToken: 0x20002B8
    public struct QueryProps
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static MS.Internal.Xml.XPath.QueryProps None;        // 0x0
        public static MS.Internal.Xml.XPath.QueryProps Position;        // 0x0
        public static MS.Internal.Xml.XPath.QueryProps Count;        // 0x0
        public static MS.Internal.Xml.XPath.QueryProps Cached;        // 0x0
        public static MS.Internal.Xml.XPath.QueryProps Reverse;        // 0x0
        public static MS.Internal.Xml.XPath.QueryProps Merge;        // 0x0

    }

    // TypeToken: 0x20002B9
    public class Query : ResetableIterator
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(MS.Internal.Xml.XPath.Query other) { }
        private System.Boolean MoveNext() { }
        private System.Int32 get_Count() { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private MS.Internal.Xml.XPath.QueryProps get_Properties() { }
        private MS.Internal.Xml.XPath.Query Clone(MS.Internal.Xml.XPath.Query input) { }
        private System.Xml.XPath.XPathNodeIterator Clone(System.Xml.XPath.XPathNodeIterator input) { }
        private System.Xml.XPath.XPathNavigator Clone(System.Xml.XPath.XPathNavigator input) { }
        private System.Boolean Insert(System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> buffer, System.Xml.XPath.XPathNavigator nav) { }
        private System.Int32 GetMedian(System.Int32 l, System.Int32 r) { }
        private System.Xml.XmlNodeOrder CompareNodes(System.Xml.XPath.XPathNavigator l, System.Xml.XPath.XPathNavigator r) { }
        private System.Xml.XPath.XPathResultType GetXPathType(System.Object value) { }

    }

    // TypeToken: 0x20002BA
    public class QueryBuilder
    {
        // Fields
        private System.String _query;        // 0x10
        private System.Boolean _allowVar;        // 0x18
        private System.Boolean _allowKey;        // 0x19
        private System.Boolean _allowCurrent;        // 0x1A
        private System.Boolean _needContext;        // 0x1B
        private MS.Internal.Xml.XPath.BaseAxisQuery _firstInput;        // 0x20
        private System.Int32 _parseDepth;        // 0x28

        // Methods
        private System.Void Reset() { }
        private MS.Internal.Xml.XPath.Query ProcessAxis(MS.Internal.Xml.XPath.Axis root, MS.Internal.Xml.XPath.QueryBuilder.Flags flags, MS.Internal.Xml.XPath.QueryBuilder.Props& props) { }
        private System.Boolean CanBeNumber(MS.Internal.Xml.XPath.Query q) { }
        private MS.Internal.Xml.XPath.Query ProcessFilter(MS.Internal.Xml.XPath.Filter root, MS.Internal.Xml.XPath.QueryBuilder.Flags flags, MS.Internal.Xml.XPath.QueryBuilder.Props& props) { }
        private MS.Internal.Xml.XPath.Query ProcessOperator(MS.Internal.Xml.XPath.Operator root, MS.Internal.Xml.XPath.QueryBuilder.Props& props) { }
        private MS.Internal.Xml.XPath.Query ProcessVariable(MS.Internal.Xml.XPath.Variable root) { }
        private MS.Internal.Xml.XPath.Query ProcessFunction(MS.Internal.Xml.XPath.Function root, MS.Internal.Xml.XPath.QueryBuilder.Props& props) { }
        private System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> ProcessArguments(System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> args, MS.Internal.Xml.XPath.QueryBuilder.Props& props) { }
        private MS.Internal.Xml.XPath.Query ProcessNode(MS.Internal.Xml.XPath.AstNode root, MS.Internal.Xml.XPath.QueryBuilder.Flags flags, MS.Internal.Xml.XPath.QueryBuilder.Props& props) { }
        private MS.Internal.Xml.XPath.Query Build(MS.Internal.Xml.XPath.AstNode root, System.String query) { }
        private MS.Internal.Xml.XPath.Query Build(System.String query, System.Boolean allowVar, System.Boolean allowKey) { }
        private MS.Internal.Xml.XPath.Query Build(System.String query, System.Boolean& needContext) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002BD
    public class ResetableIterator : XPathNodeIterator
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(MS.Internal.Xml.XPath.ResetableIterator other) { }
        private System.Void ResetCount() { }
        private System.Void Reset() { }
        private System.Int32 get_CurrentPosition() { }

    }

    // TypeToken: 0x20002BE
    public class ReversePositionQuery : ForwardPositionQuery
    {
        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query input) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.ReversePositionQuery other) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Int32 get_CurrentPosition() { }
        private MS.Internal.Xml.XPath.QueryProps get_Properties() { }

    }

    // TypeToken: 0x20002BF
    public class Root : AstNode
    {
        // Methods
        private System.Void .ctor() { }
        private MS.Internal.Xml.XPath.AstNode.AstType get_Type() { }
        private System.Xml.XPath.XPathResultType get_ReturnType() { }

    }

    // TypeToken: 0x20002C0
    public class StringFunctions : ValueQuery
    {
        // Fields
        private MS.Internal.Xml.XPath.Function.FunctionType _funcType;        // 0x18
        private System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> _argList;        // 0x20
        private static readonly System.Globalization.CompareInfo s_compareInfo;        // 0x0

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType funcType, System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> argList) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.StringFunctions other) { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.String toString(System.Double num) { }
        private System.String toString(System.Boolean b) { }
        private System.String toString(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.String Concat(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Boolean StartsWith(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Boolean Contains(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.String SubstringBefore(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.String SubstringAfter(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.String Substring(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Double StringLength(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.String Normalize(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.String Translate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002C1
    public class UnionExpr : Query
    {
        // Fields
        private MS.Internal.Xml.XPath.Query qy1;        // 0x18
        private MS.Internal.Xml.XPath.Query qy2;        // 0x20
        private System.Boolean _advance1;        // 0x28
        private System.Boolean _advance2;        // 0x29
        private System.Xml.XPath.XPathNavigator _currentNode;        // 0x30
        private System.Xml.XPath.XPathNavigator _nextNode;        // 0x38

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query query1, MS.Internal.Xml.XPath.Query query2) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.UnionExpr other) { }
        private System.Void Reset() { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext xsltContext) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathNavigator ProcessSamePosition(System.Xml.XPath.XPathNavigator result) { }
        private System.Xml.XPath.XPathNavigator ProcessBeforePosition(System.Xml.XPath.XPathNavigator res1, System.Xml.XPath.XPathNavigator res2) { }
        private System.Xml.XPath.XPathNavigator ProcessAfterPosition(System.Xml.XPath.XPathNavigator res1, System.Xml.XPath.XPathNavigator res2) { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }

    }

    // TypeToken: 0x20002C2
    public class ValueQuery : Query
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(MS.Internal.Xml.XPath.ValueQuery other) { }
        private System.Void Reset() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Int32 get_Count() { }
        private System.Xml.XPath.XPathNavigator Advance() { }

    }

    // TypeToken: 0x20002C3
    public class Variable : AstNode
    {
        // Fields
        private System.String _localname;        // 0x10
        private System.String _prefix;        // 0x18

        // Methods
        private System.Void .ctor(System.String name, System.String prefix) { }
        private MS.Internal.Xml.XPath.AstNode.AstType get_Type() { }
        private System.Xml.XPath.XPathResultType get_ReturnType() { }
        private System.String get_Localname() { }
        private System.String get_Prefix() { }

    }

    // TypeToken: 0x20002C4
    public class VariableQuery : ExtensionQuery
    {
        // Fields
        private System.Xml.Xsl.IXsltContextVariable _variable;        // 0x38

        // Methods
        private System.Void .ctor(System.String name, System.String prefix) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.VariableQuery other) { }
        private System.Void SetXsltContext(System.Xml.Xsl.XsltContext context) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathResultType get_StaticType() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002C5
    public class XPathAncestorQuery : CacheAxisQuery
    {
        // Fields
        private System.Boolean _matchSelf;        // 0x60

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest, System.Boolean matchSelf) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.XPathAncestorQuery other) { }
        private System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Int32 get_CurrentPosition() { }
        private MS.Internal.Xml.XPath.QueryProps get_Properties() { }

    }

    // TypeToken: 0x20002C6
    public class XPathArrayIterator : ResetableIterator
    {
        // Fields
        protected System.Collections.IList list;        // 0x18
        protected System.Int32 index;        // 0x20

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.XPathArrayIterator it) { }
        private System.Void .ctor(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Int32 get_Count() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Collections.IEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x20002C7
    public class XPathAxisIterator : XPathNodeIterator
    {
        // Fields
        private System.Xml.XPath.XPathNavigator nav;        // 0x18
        private System.Xml.XPath.XPathNodeType type;        // 0x20
        private System.String name;        // 0x28
        private System.String uri;        // 0x30
        private System.Int32 position;        // 0x38
        private System.Boolean matchSelf;        // 0x3C
        private System.Boolean first;        // 0x3D

        // Methods
        private System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.Boolean matchSelf) { }
        private System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.Xml.XPath.XPathNodeType type, System.Boolean matchSelf) { }
        private System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.String name, System.String namespaceURI, System.Boolean matchSelf) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.XPathAxisIterator it) { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Boolean get_Matches() { }

    }

    // TypeToken: 0x20002C8
    public class XPathChildIterator : XPathAxisIterator
    {
        // Methods
        private System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.Xml.XPath.XPathNodeType type) { }
        private System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.String name, System.String namespaceURI) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.XPathChildIterator it) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x20002C9
    public class XPathDescendantIterator : XPathAxisIterator
    {
        // Fields
        private System.Int32 _level;        // 0x40

        // Methods
        private System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.Xml.XPath.XPathNodeType type, System.Boolean matchSelf) { }
        private System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.String name, System.String namespaceURI, System.Boolean matchSelf) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.XPathDescendantIterator it) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x20002CA
    public class XPathEmptyIterator : ResetableIterator
    {
        // Fields
        public static MS.Internal.Xml.XPath.XPathEmptyIterator Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Int32 get_Count() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002CB
    public class XPathParser
    {
        // Fields
        private MS.Internal.Xml.XPath.XPathScanner _scanner;        // 0x10
        private System.Int32 _parseDepth;        // 0x18
        private static readonly System.Xml.XPath.XPathResultType[] s_temparray1;        // 0x0
        private static readonly System.Xml.XPath.XPathResultType[] s_temparray2;        // 0x8
        private static readonly System.Xml.XPath.XPathResultType[] s_temparray3;        // 0x10
        private static readonly System.Xml.XPath.XPathResultType[] s_temparray4;        // 0x18
        private static readonly System.Xml.XPath.XPathResultType[] s_temparray5;        // 0x20
        private static readonly System.Xml.XPath.XPathResultType[] s_temparray6;        // 0x28
        private static readonly System.Xml.XPath.XPathResultType[] s_temparray7;        // 0x30
        private static readonly System.Xml.XPath.XPathResultType[] s_temparray8;        // 0x38
        private static readonly System.Xml.XPath.XPathResultType[] s_temparray9;        // 0x40
        private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.XPathParser.ParamInfo> s_functionTable;        // 0x48
        private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.Axis.AxisType> s_AxesTable;        // 0x50

        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.XPathScanner scanner) { }
        private MS.Internal.Xml.XPath.AstNode ParseXPathExpression(System.String xpathExpression) { }
        private MS.Internal.Xml.XPath.AstNode ParseExpression(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseOrExpr(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseAndExpr(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseEqualityExpr(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseRelationalExpr(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseAdditiveExpr(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseMultiplicativeExpr(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseUnaryExpr(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseUnionExpr(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private System.Boolean IsNodeType(MS.Internal.Xml.XPath.XPathScanner scaner) { }
        private MS.Internal.Xml.XPath.AstNode ParsePathExpr(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseFilterExpr(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParsePredicate(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseLocationPath(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseRelativeLocationPath(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private System.Boolean IsStep(MS.Internal.Xml.XPath.XPathScanner.LexKind lexKind) { }
        private MS.Internal.Xml.XPath.AstNode ParseStep(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseNodeTest(MS.Internal.Xml.XPath.AstNode qyInput, MS.Internal.Xml.XPath.Axis.AxisType axisType, System.Xml.XPath.XPathNodeType nodeType) { }
        private System.Boolean IsPrimaryExpr(MS.Internal.Xml.XPath.XPathScanner scanner) { }
        private MS.Internal.Xml.XPath.AstNode ParsePrimaryExpr(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private MS.Internal.Xml.XPath.AstNode ParseMethod(MS.Internal.Xml.XPath.AstNode qyInput) { }
        private System.Void CheckToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t) { }
        private System.Void PassToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t) { }
        private System.Void NextLex() { }
        private System.Boolean TestOp(System.String op) { }
        private System.Void CheckNodeSet(System.Xml.XPath.XPathResultType t) { }
        private System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.XPathParser.ParamInfo> CreateFunctionTable() { }
        private System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable() { }
        private MS.Internal.Xml.XPath.Axis.AxisType GetAxis() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002CD
    public class XPathScanner
    {
        // Fields
        private System.String _xpathExpr;        // 0x10
        private System.Int32 _xpathExprIndex;        // 0x18
        private MS.Internal.Xml.XPath.XPathScanner.LexKind _kind;        // 0x1C
        private System.Char _currentChar;        // 0x20
        private System.String _name;        // 0x28
        private System.String _prefix;        // 0x30
        private System.String _stringValue;        // 0x38
        private System.Double _numberValue;        // 0x40
        private System.Boolean _canBeFunction;        // 0x48
        private System.Xml.XmlCharType _xmlCharType;        // 0x50

        // Methods
        private System.Void .ctor(System.String xpathExpr) { }
        private System.String get_SourceText() { }
        private System.Char get_CurrentChar() { }
        private System.Boolean NextChar() { }
        private MS.Internal.Xml.XPath.XPathScanner.LexKind get_Kind() { }
        private System.String get_Name() { }
        private System.String get_Prefix() { }
        private System.String get_StringValue() { }
        private System.Double get_NumberValue() { }
        private System.Boolean get_CanBeFunction() { }
        private System.Void SkipSpace() { }
        private System.Boolean NextLex() { }
        private System.Double ScanNumber() { }
        private System.Double ScanFraction() { }
        private System.String ScanString() { }
        private System.String ScanName() { }

    }

    // TypeToken: 0x20002CF
    public class XPathSelectionIterator : ResetableIterator
    {
        // Fields
        private System.Xml.XPath.XPathNavigator _nav;        // 0x18
        private MS.Internal.Xml.XPath.Query _query;        // 0x20
        private System.Int32 _position;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XPath.XPathNavigator nav, MS.Internal.Xml.XPath.Query query) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.XPathSelectionIterator it) { }
        private System.Void Reset() { }
        private System.Boolean MoveNext() { }
        private System.Int32 get_Count() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002D0
    public class XPathSelfQuery : BaseAxisQuery
    {
        // Methods
        private System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.XPathSelfQuery other) { }
        private System.Xml.XPath.XPathNavigator Advance() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }

    }

    // TypeToken: 0x20002D1
    public class XPathSingletonIterator : ResetableIterator
    {
        // Fields
        private System.Xml.XPath.XPathNavigator _nav;        // 0x18
        private System.Int32 _position;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.XPath.XPathNavigator nav) { }
        private System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.Boolean moved) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.XPathSingletonIterator it) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Int32 get_Count() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

}

namespace Microsoft.CSharp
{

    // TypeToken: 0x2000003
    public class CodeDomProvider
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class CSharpCodeProvider : CodeDomProvider
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System
{

    // TypeToken: 0x2000005
    public class MonoTODOAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class LocalAppContextSwitches
    {
        // Fields
        public static readonly System.Boolean IgnoreEmptyKeySequences;        // 0x0
        public static readonly System.Boolean DontThrowOnInvalidSurrogatePairs;        // 0x1

    }

}

namespace System.Xml
{

    // TypeToken: 0x2000007
    public class AsyncHelper
    {
        // Fields
        public static readonly System.Threading.Tasks.Task DoneTask;        // 0x0
        public static readonly System.Threading.Tasks.Task<System.Boolean> DoneTaskTrue;        // 0x8
        public static readonly System.Threading.Tasks.Task<System.Boolean> DoneTaskFalse;        // 0x10
        public static readonly System.Threading.Tasks.Task<System.Int32> DoneTaskZero;        // 0x18

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000008
    public class Base64Encoder
    {
        // Fields
        private System.Byte[] leftOverBytes;        // 0x10
        private System.Int32 leftOverBytesCount;        // 0x18
        private System.Char[] charsLine;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void WriteChars(System.Char[] chars, System.Int32 index, System.Int32 count) { }
        private System.Void Encode(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void Flush() { }

    }

    // TypeToken: 0x2000009
    public class XmlRawWriterBase64Encoder : Base64Encoder
    {
        // Fields
        private System.Xml.XmlRawWriter rawWriter;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XmlRawWriter rawWriter) { }
        private System.Void WriteChars(System.Char[] chars, System.Int32 index, System.Int32 count) { }

    }

    // TypeToken: 0x200000A
    public class XmlTextWriterBase64Encoder : Base64Encoder
    {
        // Fields
        private System.Xml.XmlTextEncoder xmlTextEncoder;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XmlTextEncoder xmlTextEncoder) { }
        private System.Void WriteChars(System.Char[] chars, System.Int32 index, System.Int32 count) { }

    }

    // TypeToken: 0x200000B
    public class BinHexDecoder : IncrementalReadDecoder
    {
        // Fields
        private System.Byte[] buffer;        // 0x10
        private System.Int32 curIndex;        // 0x18
        private System.Int32 endIndex;        // 0x1C
        private System.Boolean hasHalfByteCached;        // 0x20
        private System.Byte cachedHalfByte;        // 0x21

        // Methods
        private System.Boolean get_IsFull() { }
        private System.Int32 Decode(System.Char[] chars, System.Int32 startPos, System.Int32 len) { }
        private System.Byte[] Decode(System.Char[] chars, System.Boolean allowOddChars) { }
        private System.Void Decode(System.Char* pChars, System.Char* pCharsEndPos, System.Byte* pBytes, System.Byte* pBytesEndPos, System.Boolean& hasHalfByteCached, System.Byte& cachedHalfByte, System.Int32& charsDecoded, System.Int32& bytesDecoded) { }

    }

    // TypeToken: 0x200000C
    public class BinHexEncoder
    {
        // Methods
        private System.Void Encode(System.Byte[] buffer, System.Int32 index, System.Int32 count, System.Xml.XmlWriter writer) { }
        private System.String Encode(System.Byte[] inArray, System.Int32 offsetIn, System.Int32 count) { }
        private System.Int32 Encode(System.Byte[] inArray, System.Int32 offsetIn, System.Int32 count, System.Char[] outArray) { }

    }

    // TypeToken: 0x200000D
    public struct BinXmlToken
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.BinXmlToken Error;        // 0x0
        public static System.Xml.BinXmlToken NotImpl;        // 0x0
        public static System.Xml.BinXmlToken EOF;        // 0x0
        public static System.Xml.BinXmlToken XmlDecl;        // 0x0
        public static System.Xml.BinXmlToken Encoding;        // 0x0
        public static System.Xml.BinXmlToken DocType;        // 0x0
        public static System.Xml.BinXmlToken System;        // 0x0
        public static System.Xml.BinXmlToken Public;        // 0x0
        public static System.Xml.BinXmlToken Subset;        // 0x0
        public static System.Xml.BinXmlToken Element;        // 0x0
        public static System.Xml.BinXmlToken EndElem;        // 0x0
        public static System.Xml.BinXmlToken Attr;        // 0x0
        public static System.Xml.BinXmlToken EndAttrs;        // 0x0
        public static System.Xml.BinXmlToken PI;        // 0x0
        public static System.Xml.BinXmlToken Comment;        // 0x0
        public static System.Xml.BinXmlToken CData;        // 0x0
        public static System.Xml.BinXmlToken EndCData;        // 0x0
        public static System.Xml.BinXmlToken Name;        // 0x0
        public static System.Xml.BinXmlToken QName;        // 0x0
        public static System.Xml.BinXmlToken XmlText;        // 0x0
        public static System.Xml.BinXmlToken Nest;        // 0x0
        public static System.Xml.BinXmlToken EndNest;        // 0x0
        public static System.Xml.BinXmlToken Extn;        // 0x0
        public static System.Xml.BinXmlToken NmFlush;        // 0x0
        public static System.Xml.BinXmlToken SQL_BIT;        // 0x0
        public static System.Xml.BinXmlToken SQL_TINYINT;        // 0x0
        public static System.Xml.BinXmlToken SQL_SMALLINT;        // 0x0
        public static System.Xml.BinXmlToken SQL_INT;        // 0x0
        public static System.Xml.BinXmlToken SQL_BIGINT;        // 0x0
        public static System.Xml.BinXmlToken SQL_REAL;        // 0x0
        public static System.Xml.BinXmlToken SQL_FLOAT;        // 0x0
        public static System.Xml.BinXmlToken SQL_MONEY;        // 0x0
        public static System.Xml.BinXmlToken SQL_SMALLMONEY;        // 0x0
        public static System.Xml.BinXmlToken SQL_DATETIME;        // 0x0
        public static System.Xml.BinXmlToken SQL_SMALLDATETIME;        // 0x0
        public static System.Xml.BinXmlToken SQL_DECIMAL;        // 0x0
        public static System.Xml.BinXmlToken SQL_NUMERIC;        // 0x0
        public static System.Xml.BinXmlToken SQL_UUID;        // 0x0
        public static System.Xml.BinXmlToken SQL_VARBINARY;        // 0x0
        public static System.Xml.BinXmlToken SQL_BINARY;        // 0x0
        public static System.Xml.BinXmlToken SQL_IMAGE;        // 0x0
        public static System.Xml.BinXmlToken SQL_CHAR;        // 0x0
        public static System.Xml.BinXmlToken SQL_VARCHAR;        // 0x0
        public static System.Xml.BinXmlToken SQL_TEXT;        // 0x0
        public static System.Xml.BinXmlToken SQL_NVARCHAR;        // 0x0
        public static System.Xml.BinXmlToken SQL_NCHAR;        // 0x0
        public static System.Xml.BinXmlToken SQL_NTEXT;        // 0x0
        public static System.Xml.BinXmlToken SQL_UDT;        // 0x0
        public static System.Xml.BinXmlToken XSD_KATMAI_DATE;        // 0x0
        public static System.Xml.BinXmlToken XSD_KATMAI_DATETIME;        // 0x0
        public static System.Xml.BinXmlToken XSD_KATMAI_TIME;        // 0x0
        public static System.Xml.BinXmlToken XSD_KATMAI_DATEOFFSET;        // 0x0
        public static System.Xml.BinXmlToken XSD_KATMAI_DATETIMEOFFSET;        // 0x0
        public static System.Xml.BinXmlToken XSD_KATMAI_TIMEOFFSET;        // 0x0
        public static System.Xml.BinXmlToken XSD_BOOLEAN;        // 0x0
        public static System.Xml.BinXmlToken XSD_TIME;        // 0x0
        public static System.Xml.BinXmlToken XSD_DATETIME;        // 0x0
        public static System.Xml.BinXmlToken XSD_DATE;        // 0x0
        public static System.Xml.BinXmlToken XSD_BINHEX;        // 0x0
        public static System.Xml.BinXmlToken XSD_BASE64;        // 0x0
        public static System.Xml.BinXmlToken XSD_DECIMAL;        // 0x0
        public static System.Xml.BinXmlToken XSD_BYTE;        // 0x0
        public static System.Xml.BinXmlToken XSD_UNSIGNEDSHORT;        // 0x0
        public static System.Xml.BinXmlToken XSD_UNSIGNEDINT;        // 0x0
        public static System.Xml.BinXmlToken XSD_UNSIGNEDLONG;        // 0x0
        public static System.Xml.BinXmlToken XSD_QNAME;        // 0x0

    }

    // TypeToken: 0x200000E
    public struct BinXmlSqlDecimal
    {
        // Fields
        private System.Byte m_bLen;        // 0x10
        private System.Byte m_bPrec;        // 0x11
        private System.Byte m_bScale;        // 0x12
        private System.Byte m_bSign;        // 0x13
        private System.UInt32 m_data1;        // 0x14
        private System.UInt32 m_data2;        // 0x18
        private System.UInt32 m_data3;        // 0x1C
        private System.UInt32 m_data4;        // 0x20
        private static readonly System.Byte NUMERIC_MAX_PRECISION;        // 0x0
        private static readonly System.Byte MaxPrecision;        // 0x1
        private static readonly System.Byte MaxScale;        // 0x2
        private static readonly System.Int32 x_cNumeMax;        // 0x4
        private static readonly System.Int64 x_lInt32Base;        // 0x8
        private static readonly System.UInt64 x_ulInt32Base;        // 0x10
        private static readonly System.UInt64 x_ulInt32BaseForMod;        // 0x18
        private static readonly System.UInt64 x_llMax;        // 0x20
        private static readonly System.Double DUINT_BASE;        // 0x28
        private static readonly System.Double DUINT_BASE2;        // 0x30
        private static readonly System.Double DUINT_BASE3;        // 0x38
        private static readonly System.UInt32[] x_rgulShiftBase;        // 0x40
        private static readonly System.Byte[] rgCLenFromPrec;        // 0x48

        // Methods
        private System.Boolean get_IsPositive() { }
        private System.Void .ctor(System.Byte[] data, System.Int32 offset, System.Boolean trim) { }
        private System.UInt32 UIntFromByteArray(System.Byte[] data, System.Int32 offset) { }
        private System.Void MpDiv1(System.UInt32[] rgulU, System.Int32& ciulU, System.UInt32 iulD, System.UInt32& iulR) { }
        private System.Void MpNormalize(System.UInt32[] rgulU, System.Int32& ciulU) { }
        private System.Char ChFromDigit(System.UInt32 uiDigit) { }
        private System.Decimal ToDecimal() { }
        private System.Void TrimTrailingZeros() { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000F
    public struct BinXmlSqlMoney
    {
        // Fields
        private System.Int64 data;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 v) { }
        private System.Void .ctor(System.Int64 v) { }
        private System.Decimal ToDecimal() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000010
    public class BinXmlDateTime
    {
        // Fields
        private static System.Int32[] KatmaiTimeScaleMultiplicator;        // 0x0
        private static readonly System.Double SQLTicksPerMillisecond;        // 0x8
        public static readonly System.Int32 SQLTicksPerSecond;        // 0x10
        public static readonly System.Int32 SQLTicksPerMinute;        // 0x14
        public static readonly System.Int32 SQLTicksPerHour;        // 0x18
        private static readonly System.Int32 SQLTicksPerDay;        // 0x1C

        // Methods
        private System.Void Write2Dig(System.Text.StringBuilder sb, System.Int32 val) { }
        private System.Void Write4DigNeg(System.Text.StringBuilder sb, System.Int32 val) { }
        private System.Void Write3Dec(System.Text.StringBuilder sb, System.Int32 val) { }
        private System.Void WriteDate(System.Text.StringBuilder sb, System.Int32 yr, System.Int32 mnth, System.Int32 day) { }
        private System.Void WriteTime(System.Text.StringBuilder sb, System.Int32 hr, System.Int32 min, System.Int32 sec, System.Int32 ms) { }
        private System.Void WriteTimeFullPrecision(System.Text.StringBuilder sb, System.Int32 hr, System.Int32 min, System.Int32 sec, System.Int32 fraction) { }
        private System.Void WriteTimeZone(System.Text.StringBuilder sb, System.TimeSpan zone) { }
        private System.Void WriteTimeZone(System.Text.StringBuilder sb, System.Boolean negTimeZone, System.Int32 hr, System.Int32 min) { }
        private System.Void BreakDownXsdDateTime(System.Int64 val, System.Int32& yr, System.Int32& mnth, System.Int32& day, System.Int32& hr, System.Int32& min, System.Int32& sec, System.Int32& ms) { }
        private System.Void BreakDownXsdDate(System.Int64 val, System.Int32& yr, System.Int32& mnth, System.Int32& day, System.Boolean& negTimeZone, System.Int32& hr, System.Int32& min) { }
        private System.Void BreakDownXsdTime(System.Int64 val, System.Int32& hr, System.Int32& min, System.Int32& sec, System.Int32& ms) { }
        private System.String XsdDateTimeToString(System.Int64 val) { }
        private System.String XsdDateToString(System.Int64 val) { }
        private System.String XsdTimeToString(System.Int64 val) { }
        private System.String SqlDateTimeToString(System.Int32 dateticks, System.UInt32 timeticks) { }
        private System.DateTime SqlDateTimeToDateTime(System.Int32 dateticks, System.UInt32 timeticks) { }
        private System.String SqlSmallDateTimeToString(System.Int16 dateticks, System.UInt16 timeticks) { }
        private System.DateTime SqlSmallDateTimeToDateTime(System.Int16 dateticks, System.UInt16 timeticks) { }
        private System.DateTime XsdKatmaiDateToDateTime(System.Byte[] data, System.Int32 offset) { }
        private System.DateTime XsdKatmaiDateTimeToDateTime(System.Byte[] data, System.Int32 offset) { }
        private System.DateTime XsdKatmaiTimeToDateTime(System.Byte[] data, System.Int32 offset) { }
        private System.DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(System.Byte[] data, System.Int32 offset) { }
        private System.DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(System.Byte[] data, System.Int32 offset) { }
        private System.DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(System.Byte[] data, System.Int32 offset) { }
        private System.String XsdKatmaiDateToString(System.Byte[] data, System.Int32 offset) { }
        private System.String XsdKatmaiDateTimeToString(System.Byte[] data, System.Int32 offset) { }
        private System.String XsdKatmaiTimeToString(System.Byte[] data, System.Int32 offset) { }
        private System.String XsdKatmaiDateOffsetToString(System.Byte[] data, System.Int32 offset) { }
        private System.String XsdKatmaiDateTimeOffsetToString(System.Byte[] data, System.Int32 offset) { }
        private System.String XsdKatmaiTimeOffsetToString(System.Byte[] data, System.Int32 offset) { }
        private System.Int64 GetKatmaiDateTicks(System.Byte[] data, System.Int32& pos) { }
        private System.Int64 GetKatmaiTimeTicks(System.Byte[] data, System.Int32& pos) { }
        private System.Int64 GetKatmaiTimeZoneTicks(System.Byte[] data, System.Int32 pos) { }
        private System.Int32 GetFractions(System.DateTime dt) { }
        private System.Int32 GetFractions(System.DateTimeOffset dt) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000011
    public class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver
    {
        // Fields
        private static readonly System.Type TypeOfObject;        // 0x0
        private static readonly System.Type TypeOfString;        // 0x8
        private static System.Type[] TokenTypeMap;        // 0x10
        private static System.Byte[] XsdKatmaiTimeScaleToValueLengthMap;        // 0x18
        private static System.Xml.ReadState[] ScanState2ReadState;        // 0x20
        private System.IO.Stream inStrm;        // 0x10
        private System.Byte[] data;        // 0x18
        private System.Int32 pos;        // 0x20
        private System.Int32 mark;        // 0x24
        private System.Int32 end;        // 0x28
        private System.Int64 offset;        // 0x30
        private System.Boolean eof;        // 0x38
        private System.Boolean sniffed;        // 0x39
        private System.Boolean isEmpty;        // 0x3A
        private System.Int32 docState;        // 0x3C
        private System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables;        // 0x40
        private System.Xml.XmlNameTable xnt;        // 0x60
        private System.Boolean xntFromSettings;        // 0x68
        private System.String xml;        // 0x70
        private System.String xmlns;        // 0x78
        private System.String nsxmlns;        // 0x80
        private System.String baseUri;        // 0x88
        private System.Xml.XmlSqlBinaryReader.ScanState state;        // 0x90
        private System.Xml.XmlNodeType nodetype;        // 0x94
        private System.Xml.BinXmlToken token;        // 0x98
        private System.Int32 attrIndex;        // 0x9C
        private System.Xml.XmlSqlBinaryReader.QName qnameOther;        // 0xA0
        private System.Xml.XmlSqlBinaryReader.QName qnameElement;        // 0xB8
        private System.Xml.XmlNodeType parentNodeType;        // 0xD0
        private System.Xml.XmlSqlBinaryReader.ElemInfo[] elementStack;        // 0xD8
        private System.Int32 elemDepth;        // 0xE0
        private System.Xml.XmlSqlBinaryReader.AttrInfo[] attributes;        // 0xE8
        private System.Int32[] attrHashTbl;        // 0xF0
        private System.Int32 attrCount;        // 0xF8
        private System.Int32 posAfterAttrs;        // 0xFC
        private System.Boolean xmlspacePreserve;        // 0x100
        private System.Int32 tokLen;        // 0x104
        private System.Int32 tokDataPos;        // 0x108
        private System.Boolean hasTypedValue;        // 0x10C
        private System.Type valueType;        // 0x110
        private System.String stringValue;        // 0x118
        private System.Collections.Generic.Dictionary<System.String,System.Xml.XmlSqlBinaryReader.NamespaceDecl> namespaces;        // 0x120
        private System.Xml.XmlSqlBinaryReader.NestedBinXml prevNameInfo;        // 0x128
        private System.Xml.XmlReader textXmlReader;        // 0x130
        private System.Boolean closeInput;        // 0x138
        private System.Boolean checkCharacters;        // 0x139
        private System.Boolean ignoreWhitespace;        // 0x13A
        private System.Boolean ignorePIs;        // 0x13B
        private System.Boolean ignoreComments;        // 0x13C
        private System.Xml.DtdProcessing dtdProcessing;        // 0x140
        private System.Xml.SecureStringHasher hasher;        // 0x148
        private System.Xml.XmlCharType xmlCharType;        // 0x150
        private System.Text.Encoding unicode;        // 0x158
        private System.Byte version;        // 0x160

        // Methods
        private System.Void .ctor(System.IO.Stream stream, System.Byte[] data, System.Int32 len, System.String baseUri, System.Boolean closeInput, System.Xml.XmlReaderSettings settings) { }
        private System.Xml.XmlReaderSettings get_Settings() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Prefix() { }
        private System.Boolean get_HasValue() { }
        private System.String get_Value() { }
        private System.Int32 get_Depth() { }
        private System.String get_BaseURI() { }
        private System.Boolean get_IsEmptyElement() { }
        private System.Xml.XmlSpace get_XmlSpace() { }
        private System.String get_XmlLang() { }
        private System.Type get_ValueType() { }
        private System.Int32 get_AttributeCount() { }
        private System.String GetAttribute(System.String name, System.String ns) { }
        private System.String GetAttribute(System.String name) { }
        private System.String GetAttribute(System.Int32 i) { }
        private System.Boolean MoveToAttribute(System.String name) { }
        private System.Void MoveToAttribute(System.Int32 i) { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }
        private System.Boolean MoveToElement() { }
        private System.Boolean get_EOF() { }
        private System.Boolean ReadAttributeValue() { }
        private System.Void Close() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.Void ResolveEntity() { }
        private System.Xml.ReadState get_ReadState() { }
        private System.Boolean Read() { }
        private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName) { }
        private System.Void VerifyVersion(System.Int32 requiredVersion, System.Xml.BinXmlToken token) { }
        private System.Void AddInitNamespace(System.String prefix, System.String uri) { }
        private System.Void AddName() { }
        private System.Void AddQName() { }
        private System.Void NameFlush() { }
        private System.Void SkipExtn() { }
        private System.Int32 ReadQNameRef() { }
        private System.Int32 ReadNameRef() { }
        private System.Boolean FillAllowEOF() { }
        private System.Void Fill_(System.Int32 require) { }
        private System.Void Fill(System.Int32 require) { }
        private System.Byte ReadByte() { }
        private System.UInt16 ReadUShort() { }
        private System.Int32 ParseMB32() { }
        private System.Int32 ParseMB32_(System.Byte b) { }
        private System.Int32 ParseMB32(System.Int32 pos) { }
        private System.Int32 ParseMB64() { }
        private System.Xml.BinXmlToken PeekToken() { }
        private System.Xml.BinXmlToken ReadToken() { }
        private System.Xml.BinXmlToken NextToken2(System.Xml.BinXmlToken token) { }
        private System.Xml.BinXmlToken NextToken1() { }
        private System.Xml.BinXmlToken NextToken() { }
        private System.Xml.BinXmlToken PeekNextToken() { }
        private System.Xml.BinXmlToken RescanNextToken() { }
        private System.String ParseText() { }
        private System.Int32 ScanText(System.Int32& start) { }
        private System.String GetString(System.Int32 pos, System.Int32 cch) { }
        private System.String GetStringAligned(System.Byte[] data, System.Int32 offset, System.Int32 cch) { }
        private System.String GetAttributeText(System.Int32 i) { }
        private System.Int32 LocateAttribute(System.String name, System.String ns) { }
        private System.Int32 LocateAttribute(System.String name) { }
        private System.Void PositionOnAttribute(System.Int32 i) { }
        private System.Void GrowElements() { }
        private System.Void GrowAttributes() { }
        private System.Void ClearAttributes() { }
        private System.Void PushNamespace(System.String prefix, System.String ns, System.Boolean implied) { }
        private System.Void PopNamespaces(System.Xml.XmlSqlBinaryReader.NamespaceDecl firstInScopeChain) { }
        private System.Void GenerateImpliedXmlnsAttrs() { }
        private System.Boolean ReadInit(System.Boolean skipXmlDecl) { }
        private System.Void ScanAttributes() { }
        private System.Void SimpleCheckForDuplicateAttributes() { }
        private System.Void HashCheckForDuplicateAttributes() { }
        private System.String XmlDeclValue() { }
        private System.String CDATAValue() { }
        private System.Void FinishCDATA() { }
        private System.Void FinishEndElement() { }
        private System.Boolean ReadDoc() { }
        private System.Void ImplReadData(System.Xml.BinXmlToken tokenType) { }
        private System.Void ImplReadElement() { }
        private System.Void ImplReadEndElement() { }
        private System.Void ImplReadDoctype() { }
        private System.Void ImplReadPI() { }
        private System.Void ImplReadComment() { }
        private System.Void ImplReadCDATA() { }
        private System.Void ImplReadNest() { }
        private System.Void ImplReadEndNest() { }
        private System.Void ImplReadXmlText() { }
        private System.Void UpdateFromTextReader() { }
        private System.Boolean UpdateFromTextReader(System.Boolean needUpdate) { }
        private System.Void CheckAllowContent() { }
        private System.Void GenerateTokenTypeMap() { }
        private System.Type GetValueType(System.Xml.BinXmlToken token) { }
        private System.Void ReScanOverValue(System.Xml.BinXmlToken token) { }
        private System.Xml.XmlNodeType ScanOverValue(System.Xml.BinXmlToken token, System.Boolean attr, System.Boolean checkChars) { }
        private System.Xml.XmlNodeType ScanOverAnyValue(System.Xml.BinXmlToken token, System.Boolean attr, System.Boolean checkChars) { }
        private System.Xml.XmlNodeType CheckText(System.Boolean attr) { }
        private System.Xml.XmlNodeType CheckTextIsWS() { }
        private System.Void CheckValueTokenBounds() { }
        private System.Int32 GetXsdKatmaiTokenLength(System.Xml.BinXmlToken token) { }
        private System.Int32 XsdKatmaiTimeScaleToValueLength(System.Byte scale) { }
        private System.Int64 ValueAsLong() { }
        private System.UInt64 ValueAsULong() { }
        private System.Decimal ValueAsDecimal() { }
        private System.Double ValueAsDouble() { }
        private System.String ValueAsDateTimeString() { }
        private System.String ValueAsString(System.Xml.BinXmlToken token) { }
        private System.Int16 GetInt16(System.Int32 pos) { }
        private System.UInt16 GetUInt16(System.Int32 pos) { }
        private System.Int32 GetInt32(System.Int32 pos) { }
        private System.UInt32 GetUInt32(System.Int32 pos) { }
        private System.Int64 GetInt64(System.Int32 pos) { }
        private System.UInt64 GetUInt64(System.Int32 pos) { }
        private System.Single GetSingle(System.Int32 offset) { }
        private System.Double GetDouble(System.Int32 offset) { }
        private System.Exception ThrowUnexpectedToken(System.Xml.BinXmlToken token) { }
        private System.Exception ThrowXmlException(System.String res) { }
        private System.Exception ThrowXmlException(System.String res, System.String arg1, System.String arg2) { }
        private System.Exception ThrowNotSupported(System.String res) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000019
    public class BitStack
    {
        // Fields
        private System.UInt32[] bitStack;        // 0x10
        private System.Int32 stackPos;        // 0x18
        private System.UInt32 curr;        // 0x1C

        // Methods
        private System.Void .ctor() { }
        private System.Void PushBit(System.Boolean bit) { }
        private System.Boolean PopBit() { }
        private System.Boolean PeekBit() { }
        private System.Void PushCurr() { }
        private System.Void PopCurr() { }

    }

    // TypeToken: 0x200001A
    public class Bits
    {
        // Fields
        private static readonly System.UInt32 MASK_0101010101010101;        // 0x0
        private static readonly System.UInt32 MASK_0011001100110011;        // 0x4
        private static readonly System.UInt32 MASK_0000111100001111;        // 0x8
        private static readonly System.UInt32 MASK_0000000011111111;        // 0xC
        private static readonly System.UInt32 MASK_1111111111111111;        // 0x10

        // Methods
        private System.Int32 Count(System.UInt32 num) { }
        private System.Int32 LeastPosition(System.UInt32 num) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001B
    public class ByteStack
    {
        // Fields
        private System.Byte[] stack;        // 0x10
        private System.Int32 growthRate;        // 0x18
        private System.Int32 top;        // 0x1C
        private System.Int32 size;        // 0x20

        // Methods
        private System.Void .ctor(System.Int32 growthRate) { }
        private System.Void Push(System.Byte data) { }
        private System.Byte Pop() { }

    }

    // TypeToken: 0x200001C
    public class CharEntityEncoderFallback : EncoderFallback
    {
        // Fields
        private System.Xml.CharEntityEncoderFallbackBuffer fallbackBuffer;        // 0x10
        private System.Int32[] textContentMarks;        // 0x18
        private System.Int32 endMarkPos;        // 0x20
        private System.Int32 curMarkPos;        // 0x24
        private System.Int32 startOffset;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Text.EncoderFallbackBuffer CreateFallbackBuffer() { }
        private System.Int32 get_MaxCharCount() { }
        private System.Void set_StartOffset(System.Int32 value) { }
        private System.Void Reset(System.Int32[] textContentMarks, System.Int32 endMarkPos) { }
        private System.Boolean CanReplaceAt(System.Int32 index) { }

    }

    // TypeToken: 0x200001D
    public class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
    {
        // Fields
        private System.Xml.CharEntityEncoderFallback parent;        // 0x30
        private System.String charEntity;        // 0x38
        private System.Int32 charEntityIndex;        // 0x40

        // Methods
        private System.Void .ctor(System.Xml.CharEntityEncoderFallback parent) { }
        private System.Boolean Fallback(System.Char charUnknown, System.Int32 index) { }
        private System.Boolean Fallback(System.Char charUnknownHigh, System.Char charUnknownLow, System.Int32 index) { }
        private System.Char GetNextChar() { }
        private System.Boolean MovePrevious() { }
        private System.Int32 get_Remaining() { }
        private System.Void Reset() { }
        private System.Int32 SurrogateCharToUtf32(System.Char highSurrogate, System.Char lowSurrogate) { }

    }

    // TypeToken: 0x200001E
    public struct ConformanceLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.ConformanceLevel Auto;        // 0x0
        public static System.Xml.ConformanceLevel Fragment;        // 0x0
        public static System.Xml.ConformanceLevel Document;        // 0x0

    }

    // TypeToken: 0x200001F
    public struct DtdProcessing
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.DtdProcessing Prohibit;        // 0x0
        public static System.Xml.DtdProcessing Ignore;        // 0x0
        public static System.Xml.DtdProcessing Parse;        // 0x0

    }

    // TypeToken: 0x2000020
    public struct EntityHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.EntityHandling ExpandEntities;        // 0x0
        public static System.Xml.EntityHandling ExpandCharEntities;        // 0x0

    }

    // TypeToken: 0x2000021
    public class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter
    {
        // Fields
        protected System.Xml.ByteStack elementScope;        // 0xC0
        protected System.Xml.ElementProperties currentElementProperties;        // 0xC8
        private System.Xml.AttributeProperties currentAttributeProperties;        // 0xCC
        private System.Boolean endsWithAmpersand;        // 0xD0
        private System.Byte[] uriEscapingBuffer;        // 0xD8
        private System.String mediaType;        // 0xE0
        private System.Boolean doNotEscapeUriAttributes;        // 0xE8
        protected static System.Xml.TernaryTreeReadOnly elementPropertySearch;        // 0x0
        protected static System.Xml.TernaryTreeReadOnly attributePropertySearch;        // 0x8

        // Methods
        private System.Void .ctor(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings) { }
        private System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone) { }
        private System.Void WriteXmlDeclaration(System.String xmldecl) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void StartElementContent() { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndAttribute() { }
        private System.Void WriteProcessingInstruction(System.String target, System.String text) { }
        private System.Void WriteString(System.String text) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void Init(System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteMetaElement() { }
        private System.Void WriteHtmlElementTextBlock(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void WriteHtmlAttributeTextBlock(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void WriteHtmlAttributeText(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void WriteUriAttributeText(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void OutputRestAmps() { }

    }

    // TypeToken: 0x2000022
    public class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter
    {
        // Fields
        private System.Int32 indentLevel;        // 0xF0
        private System.Int32 endBlockPos;        // 0xF4
        private System.String indentChars;        // 0xF8
        private System.Boolean newLineOnAttributes;        // 0x100

        // Methods
        private System.Void .ctor(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings) { }
        private System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void StartElementContent() { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void FlushBuffer() { }
        private System.Void Init(System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteIndent() { }

    }

    // TypeToken: 0x2000023
    public class HtmlTernaryTree
    {
        // Fields
        private static System.Byte[] htmlElements;        // 0x0
        private static System.Byte[] htmlAttributes;        // 0x8

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000024
    public class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter
    {
        // Fields
        protected System.Xml.ByteStack elementScope;        // 0x90
        protected System.Xml.ElementProperties currentElementProperties;        // 0x98
        private System.Xml.AttributeProperties currentAttributeProperties;        // 0x9C
        private System.Boolean endsWithAmpersand;        // 0xA0
        private System.Byte[] uriEscapingBuffer;        // 0xA8
        private System.String mediaType;        // 0xB0
        private System.Boolean doNotEscapeUriAttributes;        // 0xB8
        protected static System.Xml.TernaryTreeReadOnly elementPropertySearch;        // 0x0
        protected static System.Xml.TernaryTreeReadOnly attributePropertySearch;        // 0x8

        // Methods
        private System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone) { }
        private System.Void WriteXmlDeclaration(System.String xmldecl) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void StartElementContent() { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndAttribute() { }
        private System.Void WriteProcessingInstruction(System.String target, System.String text) { }
        private System.Void WriteString(System.String text) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void Init(System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteMetaElement() { }
        private System.Void WriteHtmlElementTextBlock(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void WriteHtmlAttributeTextBlock(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void WriteHtmlAttributeText(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void WriteUriAttributeText(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void OutputRestAmps() { }

    }

    // TypeToken: 0x2000025
    public class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
    {
        // Fields
        private System.Int32 indentLevel;        // 0xC0
        private System.Int32 endBlockPos;        // 0xC4
        private System.String indentChars;        // 0xC8
        private System.Boolean newLineOnAttributes;        // 0xD0

        // Methods
        private System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void StartElementContent() { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void FlushBuffer() { }
        private System.Void Init(System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteIndent() { }

    }

    // TypeToken: 0x2000026
    public interface IDtdInfo
    {
        // Methods
        private System.Xml.XmlQualifiedName get_Name() { }
        private System.String get_InternalDtdSubset() { }
        private System.Boolean get_HasDefaultAttributes() { }
        private System.Boolean get_HasNonCDataAttributes() { }
        private System.Xml.IDtdAttributeListInfo LookupAttributeList(System.String prefix, System.String localName) { }
        private System.Xml.IDtdEntityInfo LookupEntity(System.String name) { }

    }

    // TypeToken: 0x2000027
    public interface IDtdAttributeListInfo
    {
        // Methods
        private System.Boolean get_HasNonCDataAttributes() { }
        private System.Xml.IDtdAttributeInfo LookupAttribute(System.String prefix, System.String localName) { }
        private System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> LookupDefaultAttributes() { }

    }

    // TypeToken: 0x2000028
    public interface IDtdAttributeInfo
    {
        // Methods
        private System.String get_Prefix() { }
        private System.String get_LocalName() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }
        private System.Boolean get_IsNonCDataType() { }
        private System.Boolean get_IsDeclaredInExternal() { }
        private System.Boolean get_IsXmlAttribute() { }

    }

    // TypeToken: 0x2000029
    public interface IDtdDefaultAttributeInfo : IDtdAttributeInfo
    {
        // Methods
        private System.String get_DefaultValueExpanded() { }
        private System.Object get_DefaultValueTyped() { }
        private System.Int32 get_ValueLineNumber() { }
        private System.Int32 get_ValueLinePosition() { }

    }

    // TypeToken: 0x200002A
    public interface IDtdEntityInfo
    {
        // Methods
        private System.String get_Name() { }
        private System.Boolean get_IsExternal() { }
        private System.Boolean get_IsDeclaredInExternal() { }
        private System.Boolean get_IsUnparsedEntity() { }
        private System.Boolean get_IsParameterEntity() { }
        private System.String get_BaseUriString() { }
        private System.String get_DeclaredUriString() { }
        private System.String get_SystemId() { }
        private System.String get_PublicId() { }
        private System.String get_Text() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }

    }

    // TypeToken: 0x200002B
    public interface IDtdParser
    {
        // Methods
        private System.Xml.IDtdInfo ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, System.Boolean saveInternalSubset) { }
        private System.Xml.IDtdInfo ParseFreeFloatingDtd(System.String baseUri, System.String docTypeName, System.String publicId, System.String systemId, System.String internalSubset, System.Xml.IDtdParserAdapter adapter) { }

    }

    // TypeToken: 0x200002C
    public interface IDtdParserAdapter
    {
        // Methods
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Xml.IXmlNamespaceResolver get_NamespaceResolver() { }
        private System.Uri get_BaseUri() { }
        private System.Char[] get_ParsingBuffer() { }
        private System.Int32 get_ParsingBufferLength() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Void set_CurrentPosition(System.Int32 value) { }
        private System.Int32 get_LineNo() { }
        private System.Int32 get_LineStartPosition() { }
        private System.Boolean get_IsEof() { }
        private System.Int32 get_EntityStackLength() { }
        private System.Boolean get_IsEntityEolNormalized() { }
        private System.Int32 ReadData() { }
        private System.Void OnNewLine(System.Int32 pos) { }
        private System.Int32 ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder) { }
        private System.Int32 ParseNamedCharRef(System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder) { }
        private System.Void ParsePI(System.Text.StringBuilder sb) { }
        private System.Void ParseComment(System.Text.StringBuilder sb) { }
        private System.Boolean PushEntity(System.Xml.IDtdEntityInfo entity, System.Int32& entityId) { }
        private System.Boolean PopEntity(System.Xml.IDtdEntityInfo& oldEntity, System.Int32& newEntityId) { }
        private System.Boolean PushExternalSubset(System.String systemId, System.String publicId) { }
        private System.Void PushInternalDtd(System.String baseUri, System.String internalDtd) { }
        private System.Void OnSystemId(System.String systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo) { }
        private System.Void OnPublicId(System.String publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo) { }
        private System.Void Throw(System.Exception e) { }

    }

    // TypeToken: 0x200002D
    public interface IDtdParserAdapterWithValidation : IDtdParserAdapter
    {
        // Methods
        private System.Boolean get_DtdValidation() { }
        private System.Xml.IValidationEventHandling get_ValidationEventHandling() { }

    }

    // TypeToken: 0x200002E
    public interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter
    {
        // Methods
        private System.Boolean get_V1CompatibilityMode() { }
        private System.Boolean get_Normalization() { }
        private System.Boolean get_Namespaces() { }

    }

    // TypeToken: 0x200002F
    public class OnRemoveWriter : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Xml.XmlRawWriter writer) { }

    }

    // TypeToken: 0x2000030
    public interface IValidationEventHandling
    {
        // Methods
        private System.Object get_EventHandler() { }
        private System.Void SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity) { }

    }

    // TypeToken: 0x2000031
    public class IncrementalReadDecoder
    {
        // Methods
        private System.Boolean get_IsFull() { }
        private System.Int32 Decode(System.Char[] chars, System.Int32 startPos, System.Int32 len) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000032
    public class IncrementalReadDummyDecoder : IncrementalReadDecoder
    {
        // Methods
        private System.Boolean get_IsFull() { }
        private System.Int32 Decode(System.Char[] chars, System.Int32 startPos, System.Int32 len) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000033
    public struct NamespaceHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.NamespaceHandling Default;        // 0x0
        public static System.Xml.NamespaceHandling OmitDuplicates;        // 0x0

    }

    // TypeToken: 0x2000034
    public struct NewLineHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.NewLineHandling Replace;        // 0x0
        public static System.Xml.NewLineHandling Entitize;        // 0x0
        public static System.Xml.NewLineHandling None;        // 0x0

    }

    // TypeToken: 0x2000035
    public class QueryOutputWriter : XmlRawWriter
    {
        // Fields
        private System.Xml.XmlRawWriter wrapped;        // 0x28
        private System.Boolean inCDataSection;        // 0x30
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Int32> lookupCDataElems;        // 0x38
        private System.Xml.BitStack bitsCData;        // 0x40
        private System.Xml.XmlQualifiedName qnameCData;        // 0x48
        private System.Boolean outputDocType;        // 0x50
        private System.Boolean checkWellFormedDoc;        // 0x51
        private System.Boolean hasDocElem;        // 0x52
        private System.Boolean inAttr;        // 0x53
        private System.String systemId;        // 0x58
        private System.String publicId;        // 0x60
        private System.Int32 depth;        // 0x68

        // Methods
        private System.Void .ctor(System.Xml.XmlRawWriter writer, System.Xml.XmlWriterSettings settings) { }
        private System.Void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value) { }
        private System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone) { }
        private System.Void WriteXmlDeclaration(System.String xmldecl) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void StartElementContent() { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndAttribute() { }
        private System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns) { }
        private System.Boolean get_SupportsNamespaceDeclarationInChunks() { }
        private System.Void WriteStartNamespaceDeclaration(System.String prefix) { }
        private System.Void WriteEndNamespaceDeclaration() { }
        private System.Void WriteCData(System.String text) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void WriteProcessingInstruction(System.String name, System.String text) { }
        private System.Void WriteWhitespace(System.String ws) { }
        private System.Void WriteString(System.String text) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.String data) { }
        private System.Void Close() { }
        private System.Void Flush() { }
        private System.Boolean StartCDataSection() { }
        private System.Void EndCDataSection() { }

    }

    // TypeToken: 0x2000036
    public class ReadContentAsBinaryHelper
    {
        // Fields
        private System.Xml.XmlReader reader;        // 0x10
        private System.Xml.ReadContentAsBinaryHelper.State state;        // 0x18
        private System.Int32 valueOffset;        // 0x1C
        private System.Boolean isEnd;        // 0x20

        // Methods
        private System.Void Finish() { }
        private System.Void Reset() { }
        private System.Boolean MoveToNextContentNode(System.Boolean moveIfOnContentNode) { }

    }

    // TypeToken: 0x2000038
    public struct ElementProperties
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static System.Xml.ElementProperties DEFAULT;        // 0x0
        public static System.Xml.ElementProperties URI_PARENT;        // 0x0
        public static System.Xml.ElementProperties BOOL_PARENT;        // 0x0
        public static System.Xml.ElementProperties NAME_PARENT;        // 0x0
        public static System.Xml.ElementProperties EMPTY;        // 0x0
        public static System.Xml.ElementProperties NO_ENTITIES;        // 0x0
        public static System.Xml.ElementProperties HEAD;        // 0x0
        public static System.Xml.ElementProperties BLOCK_WS;        // 0x0
        public static System.Xml.ElementProperties HAS_NS;        // 0x0

    }

    // TypeToken: 0x2000039
    public struct AttributeProperties
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static System.Xml.AttributeProperties DEFAULT;        // 0x0
        public static System.Xml.AttributeProperties URI;        // 0x0
        public static System.Xml.AttributeProperties BOOLEAN;        // 0x0
        public static System.Xml.AttributeProperties NAME;        // 0x0

    }

    // TypeToken: 0x200003A
    public class TernaryTreeReadOnly
    {
        // Fields
        private System.Byte[] nodeBuffer;        // 0x10

        // Methods
        private System.Void .ctor(System.Byte[] nodeBuffer) { }
        private System.Byte FindCaseInsensitiveString(System.String stringToFind) { }

    }

    // TypeToken: 0x200003B
    public struct ReadState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.ReadState Initial;        // 0x0
        public static System.Xml.ReadState Interactive;        // 0x0
        public static System.Xml.ReadState Error;        // 0x0
        public static System.Xml.ReadState EndOfFile;        // 0x0
        public static System.Xml.ReadState Closed;        // 0x0

    }

    // TypeToken: 0x200003C
    public class SecureStringHasher, IEqualityComparer`1
    {
        // Fields
        private static System.Xml.SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate;        // 0x0
        private System.Int32 hashCodeRandomizer;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Boolean Equals(System.String x, System.String y) { }
        private System.Int32 GetHashCode(System.String key) { }
        private System.Int32 GetHashCodeOfString(System.String key, System.Int32 sLen, System.Int64 additionalEntropy) { }
        private System.Xml.SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate() { }

    }

    // TypeToken: 0x200003E
    public class TextEncodedRawTextWriter : XmlEncodedRawTextWriter
    {
        // Methods
        private System.Void .ctor(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings) { }
        private System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone) { }
        private System.Void WriteXmlDeclaration(System.String xmldecl) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void StartElementContent() { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndAttribute() { }
        private System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns) { }
        private System.Boolean get_SupportsNamespaceDeclarationInChunks() { }
        private System.Void WriteCData(System.String text) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void WriteProcessingInstruction(System.String name, System.String text) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteWhitespace(System.String ws) { }
        private System.Void WriteString(System.String textBlock) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.String data) { }

    }

    // TypeToken: 0x200003F
    public class TextUtf8RawTextWriter : XmlUtf8RawTextWriter
    {
        // Methods
        private System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone) { }
        private System.Void WriteXmlDeclaration(System.String xmldecl) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void StartElementContent() { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndAttribute() { }
        private System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns) { }
        private System.Boolean get_SupportsNamespaceDeclarationInChunks() { }
        private System.Void WriteCData(System.String text) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void WriteProcessingInstruction(System.String name, System.String text) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteWhitespace(System.String ws) { }
        private System.Void WriteString(System.String textBlock) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.String data) { }

    }

    // TypeToken: 0x2000040
    public class ValidatingReaderNodeData
    {
        // Fields
        private System.String localName;        // 0x10
        private System.String namespaceUri;        // 0x18
        private System.String prefix;        // 0x20
        private System.String nameWPrefix;        // 0x28
        private System.String rawValue;        // 0x30
        private System.String originalStringValue;        // 0x38
        private System.Int32 depth;        // 0x40
        private System.Xml.AttributePSVIInfo attributePSVIInfo;        // 0x48
        private System.Xml.XmlNodeType nodeType;        // 0x50
        private System.Int32 lineNo;        // 0x54
        private System.Int32 linePos;        // 0x58

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.XmlNodeType nodeType) { }
        private System.String get_LocalName() { }
        private System.Void set_LocalName(System.String value) { }
        private System.String get_Namespace() { }
        private System.Void set_Namespace(System.String value) { }
        private System.String get_Prefix() { }
        private System.Void set_Prefix(System.String value) { }
        private System.String GetAtomizedNameWPrefix(System.Xml.XmlNameTable nameTable) { }
        private System.Int32 get_Depth() { }
        private System.Void set_Depth(System.Int32 value) { }
        private System.String get_RawValue() { }
        private System.Void set_RawValue(System.String value) { }
        private System.String get_OriginalStringValue() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Void set_NodeType(System.Xml.XmlNodeType value) { }
        private System.Xml.AttributePSVIInfo get_AttInfo() { }
        private System.Void set_AttInfo(System.Xml.AttributePSVIInfo value) { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }
        private System.Void Clear(System.Xml.XmlNodeType nodeType) { }
        private System.Void SetLineInfo(System.Int32 lineNo, System.Int32 linePos) { }
        private System.Void SetLineInfo(System.Xml.IXmlLineInfo lineInfo) { }
        private System.Void SetItemData(System.String localName, System.String prefix, System.String ns, System.Int32 depth) { }
        private System.Void SetItemData(System.String value) { }
        private System.Void SetItemData(System.String value, System.String originalStringValue) { }

    }

    // TypeToken: 0x2000041
    public struct ValidationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.ValidationType None;        // 0x0
        public static System.Xml.ValidationType Auto;        // 0x0
        public static System.Xml.ValidationType DTD;        // 0x0
        public static System.Xml.ValidationType XDR;        // 0x0
        public static System.Xml.ValidationType Schema;        // 0x0

    }

    // TypeToken: 0x2000042
    public struct WhitespaceHandling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.WhitespaceHandling All;        // 0x0
        public static System.Xml.WhitespaceHandling Significant;        // 0x0
        public static System.Xml.WhitespaceHandling None;        // 0x0

    }

    // TypeToken: 0x2000043
    public class XmlAsyncCheckReader : XmlReader
    {
        // Fields
        private readonly System.Xml.XmlReader coreReader;        // 0x10
        private System.Threading.Tasks.Task lastTask;        // 0x18

        // Methods
        private System.Xml.XmlReader get_CoreReader() { }
        private System.Xml.XmlAsyncCheckReader CreateAsyncCheckWrapper(System.Xml.XmlReader reader) { }
        private System.Void .ctor(System.Xml.XmlReader reader) { }
        private System.Void CheckAsync() { }
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
        private System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo() { }
        private System.Type get_ValueType() { }
        private System.String ReadContentAsString() { }
        private System.Int32 get_AttributeCount() { }
        private System.String GetAttribute(System.String name) { }
        private System.String GetAttribute(System.String name, System.String namespaceURI) { }
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
        private System.Int32 ReadValueChunk(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.String ReadString() { }
        private System.Xml.XmlNodeType MoveToContent() { }
        private System.Void ReadStartElement() { }
        private System.Void ReadStartElement(System.String name) { }
        private System.String ReadElementString() { }
        private System.Void ReadEndElement() { }
        private System.Boolean IsStartElement() { }
        private System.Boolean IsStartElement(System.String localname, System.String ns) { }
        private System.String ReadInnerXml() { }
        private System.Boolean get_HasAttributes() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Xml.XmlNamespaceManager get_NamespaceManager() { }
        private System.Xml.IDtdInfo get_DtdInfo() { }

    }

    // TypeToken: 0x2000044
    public class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver
    {
        // Fields
        private readonly System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.XmlReader reader) { }
        private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName) { }

    }

    // TypeToken: 0x2000045
    public class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo
    {
        // Fields
        private readonly System.Xml.IXmlLineInfo readerAsIXmlLineInfo;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.XmlReader reader) { }
        private System.Boolean HasLineInfo() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }

    }

    // TypeToken: 0x2000046
    public class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver
    {
        // Fields
        private readonly System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XmlReader reader) { }
        private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName) { }

    }

    // TypeToken: 0x2000047
    public class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS, IXmlSchemaInfo
    {
        // Fields
        private readonly System.Xml.Schema.IXmlSchemaInfo readerAsIXmlSchemaInfo;        // 0x30

        // Methods
        private System.Void .ctor(System.Xml.XmlReader reader) { }
        private System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }
        private System.Boolean System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }
        private System.Boolean System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }
        private System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }
        private System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }
        private System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }
        private System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

    }

    // TypeToken: 0x2000048
    public class XmlAsyncCheckWriter : XmlWriter
    {
        // Fields
        private readonly System.Xml.XmlWriter coreWriter;        // 0x18
        private System.Threading.Tasks.Task lastTask;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.XmlWriter writer) { }
        private System.Void CheckAsync() { }
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
        private System.Void WriteValue(System.Object value) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void WriteValue(System.Boolean value) { }
        private System.Void WriteValue(System.DateTime value) { }
        private System.Void WriteValue(System.Double value) { }
        private System.Void WriteValue(System.Single value) { }
        private System.Void WriteValue(System.Decimal value) { }
        private System.Void WriteValue(System.Int32 value) { }
        private System.Void WriteValue(System.Int64 value) { }
        private System.Void WriteAttributes(System.Xml.XmlReader reader, System.Boolean defattr) { }
        private System.Void WriteNode(System.Xml.XmlReader reader, System.Boolean defattr) { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x2000049
    public class XmlAutoDetectWriter : XmlRawWriter
    {
        // Fields
        private System.Xml.XmlRawWriter wrapped;        // 0x28
        private System.Xml.OnRemoveWriter onRemove;        // 0x30
        private System.Xml.XmlWriterSettings writerSettings;        // 0x38
        private System.Xml.XmlEventCache eventCache;        // 0x40
        private System.IO.TextWriter textWriter;        // 0x48
        private System.IO.Stream strm;        // 0x50

        // Methods
        private System.Void .ctor(System.Xml.XmlWriterSettings writerSettings) { }
        private System.Void .ctor(System.IO.TextWriter textWriter, System.Xml.XmlWriterSettings writerSettings) { }
        private System.Void .ctor(System.IO.Stream strm, System.Xml.XmlWriterSettings writerSettings) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndAttribute() { }
        private System.Void WriteCData(System.String text) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void WriteProcessingInstruction(System.String name, System.String text) { }
        private System.Void WriteWhitespace(System.String ws) { }
        private System.Void WriteString(System.String text) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.String data) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteBinHex(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void Close() { }
        private System.Void Flush() { }
        private System.Void WriteValue(System.Object value) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void WriteValue(System.Boolean value) { }
        private System.Void WriteValue(System.DateTime value) { }
        private System.Void WriteValue(System.Double value) { }
        private System.Void WriteValue(System.Single value) { }
        private System.Void WriteValue(System.Decimal value) { }
        private System.Void WriteValue(System.Int32 value) { }
        private System.Void WriteValue(System.Int64 value) { }
        private System.Void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value) { }
        private System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone) { }
        private System.Void WriteXmlDeclaration(System.String xmldecl) { }
        private System.Void StartElementContent() { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns) { }
        private System.Boolean get_SupportsNamespaceDeclarationInChunks() { }
        private System.Void WriteStartNamespaceDeclaration(System.String prefix) { }
        private System.Void WriteEndNamespaceDeclaration() { }
        private System.Boolean IsHtmlTag(System.String tagName) { }
        private System.Void EnsureWrappedWriter(System.Xml.XmlOutputMethod outMethod) { }
        private System.Boolean TextBlockCreatesWriter(System.String textBlock) { }
        private System.Void CreateWrappedWriter(System.Xml.XmlOutputMethod outMethod) { }

    }

    // TypeToken: 0x200004A
    public class XmlEncodedRawTextWriter : XmlRawWriter
    {
        // Fields
        private readonly System.Boolean useAsync;        // 0x28
        protected System.Byte[] bufBytes;        // 0x30
        protected System.IO.Stream stream;        // 0x38
        protected System.Text.Encoding encoding;        // 0x40
        protected System.Xml.XmlCharType xmlCharType;        // 0x48
        protected System.Int32 bufPos;        // 0x50
        protected System.Int32 textPos;        // 0x54
        protected System.Int32 contentPos;        // 0x58
        protected System.Int32 cdataPos;        // 0x5C
        protected System.Int32 attrEndPos;        // 0x60
        protected System.Int32 bufLen;        // 0x64
        protected System.Boolean writeToNull;        // 0x68
        protected System.Boolean hadDoubleBracket;        // 0x69
        protected System.Boolean inAttributeValue;        // 0x6A
        protected System.Int32 bufBytesUsed;        // 0x6C
        protected System.Char[] bufChars;        // 0x70
        protected System.Text.Encoder encoder;        // 0x78
        protected System.IO.TextWriter writer;        // 0x80
        protected System.Boolean trackTextContent;        // 0x88
        protected System.Boolean inTextContent;        // 0x89
        private System.Int32 lastMarkPos;        // 0x8C
        private System.Int32[] textContentMarks;        // 0x90
        private System.Xml.CharEntityEncoderFallback charEntityFallback;        // 0x98
        protected System.Xml.NewLineHandling newLineHandling;        // 0xA0
        protected System.Boolean closeOutput;        // 0xA4
        protected System.Boolean omitXmlDeclaration;        // 0xA5
        protected System.String newLineChars;        // 0xA8
        protected System.Boolean checkCharacters;        // 0xB0
        protected System.Xml.XmlStandalone standalone;        // 0xB4
        protected System.Xml.XmlOutputMethod outputMethod;        // 0xB8
        protected System.Boolean autoXmlDeclaration;        // 0xBC
        protected System.Boolean mergeCDataSections;        // 0xBD

        // Methods
        private System.Void .ctor(System.Xml.XmlWriterSettings settings) { }
        private System.Void .ctor(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings) { }
        private System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone) { }
        private System.Void WriteXmlDeclaration(System.String xmldecl) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void StartElementContent() { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndAttribute() { }
        private System.Void WriteNamespaceDeclaration(System.String prefix, System.String namespaceName) { }
        private System.Boolean get_SupportsNamespaceDeclarationInChunks() { }
        private System.Void WriteStartNamespaceDeclaration(System.String prefix) { }
        private System.Void WriteEndNamespaceDeclaration() { }
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
        private System.Void Close() { }
        private System.Void Flush() { }
        private System.Void FlushBuffer() { }
        private System.Void EncodeChars(System.Int32 startOffset, System.Int32 endOffset, System.Boolean writeAllToStream) { }
        private System.Void FlushEncoder() { }
        private System.Void WriteAttributeTextBlock(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void WriteElementTextBlock(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void RawText(System.String s) { }
        private System.Void RawText(System.Char* pSrcBegin, System.Char* pSrcEnd) { }
        private System.Void WriteRawWithCharChecking(System.Char* pSrcBegin, System.Char* pSrcEnd) { }
        private System.Void WriteCommentOrPi(System.String text, System.Int32 stopChar) { }
        private System.Void WriteCDataSection(System.String text) { }
        private System.Char* EncodeSurrogate(System.Char* pSrc, System.Char* pSrcEnd, System.Char* pDst) { }
        private System.Char* InvalidXmlChar(System.Int32 ch, System.Char* pDst, System.Boolean entitize) { }
        private System.Void EncodeChar(System.Char*& pSrc, System.Char* pSrcEnd, System.Char*& pDst) { }
        private System.Void ChangeTextContentMark(System.Boolean value) { }
        private System.Void GrowTextContentMarks() { }
        private System.Char* WriteNewLine(System.Char* pDst) { }
        private System.Char* LtEntity(System.Char* pDst) { }
        private System.Char* GtEntity(System.Char* pDst) { }
        private System.Char* AmpEntity(System.Char* pDst) { }
        private System.Char* QuoteEntity(System.Char* pDst) { }
        private System.Char* TabEntity(System.Char* pDst) { }
        private System.Char* LineFeedEntity(System.Char* pDst) { }
        private System.Char* CarriageReturnEntity(System.Char* pDst) { }
        private System.Char* CharEntity(System.Char* pDst, System.Char ch) { }
        private System.Char* RawStartCData(System.Char* pDst) { }
        private System.Char* RawEndCData(System.Char* pDst) { }
        private System.Void ValidateContentChars(System.String chars, System.String propertyName, System.Boolean allowOnlyWhitespace) { }

    }

    // TypeToken: 0x200004B
    public class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
    {
        // Fields
        protected System.Int32 indentLevel;        // 0xC0
        protected System.Boolean newLineOnAttributes;        // 0xC4
        protected System.String indentChars;        // 0xC8
        protected System.Boolean mixedContent;        // 0xD0
        private System.Xml.BitStack mixedContentStack;        // 0xD8
        protected System.Xml.ConformanceLevel conformanceLevel;        // 0xE0

        // Methods
        private System.Void .ctor(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings) { }
        private System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void StartElementContent() { }
        private System.Void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel) { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteCData(System.String text) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void WriteProcessingInstruction(System.String target, System.String text) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteWhitespace(System.String ws) { }
        private System.Void WriteString(System.String text) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.String data) { }
        private System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void Init(System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteIndent() { }

    }

    // TypeToken: 0x200004C
    public class XmlEventCache : XmlRawWriter
    {
        // Fields
        private System.Collections.Generic.List<System.Xml.XmlEventCache.XmlEvent[]> pages;        // 0x28
        private System.Xml.XmlEventCache.XmlEvent[] pageCurr;        // 0x30
        private System.Int32 pageSize;        // 0x38
        private System.Boolean hasRootNode;        // 0x3C
        private System.Xml.Xsl.Runtime.StringConcat singleText;        // 0x40
        private System.String baseUri;        // 0x78

        // Methods
        private System.Void .ctor(System.String baseUri, System.Boolean hasRootNode) { }
        private System.Void EndEvents() { }
        private System.Void EventsToWriter(System.Xml.XmlWriter writer) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndAttribute() { }
        private System.Void WriteCData(System.String text) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void WriteProcessingInstruction(System.String name, System.String text) { }
        private System.Void WriteWhitespace(System.String ws) { }
        private System.Void WriteString(System.String text) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.String data) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteBinHex(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void Close() { }
        private System.Void Flush() { }
        private System.Void WriteValue(System.Object value) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone) { }
        private System.Void WriteXmlDeclaration(System.String xmldecl) { }
        private System.Void StartElementContent() { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns) { }
        private System.Void WriteEndBase64() { }
        private System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType) { }
        private System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1) { }
        private System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2) { }
        private System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2, System.String s3) { }
        private System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2, System.String s3, System.Object o) { }
        private System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.Object o) { }
        private System.Int32 NewEvent() { }
        private System.Byte[] ToBytes(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }

    }

    // TypeToken: 0x200004F
    public class XmlParserContext
    {
        // Fields
        private System.Xml.XmlNameTable _nt;        // 0x10
        private System.Xml.XmlNamespaceManager _nsMgr;        // 0x18
        private System.String _docTypeName;        // 0x20
        private System.String _pubId;        // 0x28
        private System.String _sysId;        // 0x30
        private System.String _internalSubset;        // 0x38
        private System.String _xmlLang;        // 0x40
        private System.Xml.XmlSpace _xmlSpace;        // 0x48
        private System.String _baseURI;        // 0x50
        private System.Text.Encoding _encoding;        // 0x58

        // Methods
        private System.Void .ctor(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, System.String xmlLang, System.Xml.XmlSpace xmlSpace) { }
        private System.Void .ctor(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, System.String docTypeName, System.String pubId, System.String sysId, System.String internalSubset, System.String baseURI, System.String xmlLang, System.Xml.XmlSpace xmlSpace) { }
        private System.Void .ctor(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, System.String docTypeName, System.String pubId, System.String sysId, System.String internalSubset, System.String baseURI, System.String xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc) { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Xml.XmlNamespaceManager get_NamespaceManager() { }
        private System.String get_DocTypeName() { }
        private System.String get_PublicId() { }
        private System.String get_SystemId() { }
        private System.String get_BaseURI() { }
        private System.String get_InternalSubset() { }
        private System.String get_XmlLang() { }
        private System.Xml.XmlSpace get_XmlSpace() { }
        private System.Text.Encoding get_Encoding() { }
        private System.Boolean get_HasDtdInfo() { }

    }

    // TypeToken: 0x2000050
    public class XmlRawWriter : XmlWriter
    {
        // Fields
        protected System.Xml.XmlRawWriterBase64Encoder base64Encoder;        // 0x18
        protected System.Xml.IXmlNamespaceResolver resolver;        // 0x20

        // Methods
        private System.Void WriteStartDocument() { }
        private System.Void WriteStartDocument(System.Boolean standalone) { }
        private System.Void WriteEndDocument() { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteEndElement() { }
        private System.Void WriteFullEndElement() { }
        private System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.String LookupPrefix(System.String ns) { }
        private System.Xml.WriteState get_WriteState() { }
        private System.Void WriteCData(System.String text) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteWhitespace(System.String ws) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.String data) { }
        private System.Void WriteValue(System.Object value) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void WriteAttributes(System.Xml.XmlReader reader, System.Boolean defattr) { }
        private System.Void WriteNode(System.Xml.XmlReader reader, System.Boolean defattr) { }
        private System.Void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value) { }
        private System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone) { }
        private System.Void WriteXmlDeclaration(System.String xmldecl) { }
        private System.Void StartElementContent() { }
        private System.Void OnRootElement(System.Xml.ConformanceLevel conformanceLevel) { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns) { }
        private System.Boolean get_SupportsNamespaceDeclarationInChunks() { }
        private System.Void WriteStartNamespaceDeclaration(System.String prefix) { }
        private System.Void WriteEndNamespaceDeclaration() { }
        private System.Void WriteEndBase64() { }
        private System.Void Close(System.Xml.WriteState currentState) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000051
    public class XmlReader, IDisposable
    {
        // Fields
        private static System.UInt32 IsTextualNodeBitmap;        // 0x0
        private static System.UInt32 CanReadContentAsBitmap;        // 0x4
        private static System.UInt32 HasValueBitmap;        // 0x8

        // Methods
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
        private System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo() { }
        private System.Type get_ValueType() { }
        private System.String ReadContentAsString() { }
        private System.Int32 get_AttributeCount() { }
        private System.String GetAttribute(System.String name) { }
        private System.String GetAttribute(System.String name, System.String namespaceURI) { }
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
        private System.Int32 ReadValueChunk(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.String ReadString() { }
        private System.Xml.XmlNodeType MoveToContent() { }
        private System.Void ReadStartElement() { }
        private System.Void ReadStartElement(System.String name) { }
        private System.String ReadElementString() { }
        private System.Void ReadEndElement() { }
        private System.Boolean IsStartElement() { }
        private System.Boolean IsStartElement(System.String localname, System.String ns) { }
        private System.String ReadInnerXml() { }
        private System.Void WriteNode(System.Xml.XmlWriter xtw, System.Boolean defattr) { }
        private System.Void WriteAttributeValue(System.Xml.XmlWriter xtw) { }
        private System.Xml.XmlWriter CreateWriterForInnerOuterXml(System.IO.StringWriter sw) { }
        private System.Void SetNamespacesFlag(System.Xml.XmlTextWriter xtw) { }
        private System.Boolean get_HasAttributes() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Xml.XmlNamespaceManager get_NamespaceManager() { }
        private System.Boolean IsTextualNode(System.Xml.XmlNodeType nodeType) { }
        private System.Boolean CanReadContentAs(System.Xml.XmlNodeType nodeType) { }
        private System.Boolean HasValueInternal(System.Xml.XmlNodeType nodeType) { }
        private System.Boolean SkipSubtree() { }
        private System.Exception CreateReadContentAsException(System.String methodName) { }
        private System.Boolean CanReadContentAs() { }
        private System.Exception CreateReadContentAsException(System.String methodName, System.Xml.XmlNodeType nodeType, System.Xml.IXmlLineInfo lineInfo) { }
        private System.String AddLineInfo(System.String message, System.Xml.IXmlLineInfo lineInfo) { }
        private System.String InternalReadContentAsString() { }
        private System.Boolean get_IsDefaultInternal() { }
        private System.Xml.IDtdInfo get_DtdInfo() { }
        private System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.String baseUri) { }
        private System.Xml.XmlReader Create(System.IO.TextReader input) { }
        private System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, System.String baseUri) { }
        private System.Xml.XmlReader CreateSqlReader(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext) { }
        private System.Int32 CalcBufferSize(System.IO.Stream input) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000052
    public class XmlReaderSettings
    {
        // Fields
        private System.Boolean useAsync;        // 0x10
        private System.Xml.XmlNameTable nameTable;        // 0x18
        private System.Xml.XmlResolver xmlResolver;        // 0x20
        private System.Int32 lineNumberOffset;        // 0x28
        private System.Int32 linePositionOffset;        // 0x2C
        private System.Xml.ConformanceLevel conformanceLevel;        // 0x30
        private System.Boolean checkCharacters;        // 0x34
        private System.Int64 maxCharactersInDocument;        // 0x38
        private System.Int64 maxCharactersFromEntities;        // 0x40
        private System.Boolean ignoreWhitespace;        // 0x48
        private System.Boolean ignorePIs;        // 0x49
        private System.Boolean ignoreComments;        // 0x4A
        private System.Xml.DtdProcessing dtdProcessing;        // 0x4C
        private System.Xml.ValidationType validationType;        // 0x50
        private System.Xml.Schema.XmlSchemaValidationFlags validationFlags;        // 0x54
        private System.Xml.Schema.XmlSchemaSet schemas;        // 0x58
        private System.Xml.Schema.ValidationEventHandler valEventHandler;        // 0x60
        private System.Boolean closeInput;        // 0x68
        private System.Boolean isReadOnly;        // 0x69
        private System.Boolean <IsXmlResolverSet>k__BackingField;        // 0x6A
        private static System.Nullable<System.Boolean> s_enableLegacyXmlSettings;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_Async() { }
        private System.Void set_Async(System.Boolean value) { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Void set_NameTable(System.Xml.XmlNameTable value) { }
        private System.Boolean get_IsXmlResolverSet() { }
        private System.Void set_IsXmlResolverSet(System.Boolean value) { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Xml.XmlResolver GetXmlResolver() { }
        private System.Xml.XmlResolver GetXmlResolver_CheckConfig() { }
        private System.Int32 get_LineNumberOffset() { }
        private System.Void set_LineNumberOffset(System.Int32 value) { }
        private System.Int32 get_LinePositionOffset() { }
        private System.Void set_LinePositionOffset(System.Int32 value) { }
        private System.Xml.ConformanceLevel get_ConformanceLevel() { }
        private System.Void set_ConformanceLevel(System.Xml.ConformanceLevel value) { }
        private System.Boolean get_CheckCharacters() { }
        private System.Void set_CheckCharacters(System.Boolean value) { }
        private System.Int64 get_MaxCharactersInDocument() { }
        private System.Void set_MaxCharactersInDocument(System.Int64 value) { }
        private System.Int64 get_MaxCharactersFromEntities() { }
        private System.Void set_MaxCharactersFromEntities(System.Int64 value) { }
        private System.Boolean get_IgnoreWhitespace() { }
        private System.Void set_IgnoreWhitespace(System.Boolean value) { }
        private System.Boolean get_IgnoreProcessingInstructions() { }
        private System.Void set_IgnoreProcessingInstructions(System.Boolean value) { }
        private System.Boolean get_IgnoreComments() { }
        private System.Void set_IgnoreComments(System.Boolean value) { }
        private System.Xml.DtdProcessing get_DtdProcessing() { }
        private System.Void set_DtdProcessing(System.Xml.DtdProcessing value) { }
        private System.Boolean get_CloseInput() { }
        private System.Void set_CloseInput(System.Boolean value) { }
        private System.Xml.ValidationType get_ValidationType() { }
        private System.Void set_ValidationType(System.Xml.ValidationType value) { }
        private System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags() { }
        private System.Void set_ValidationFlags(System.Xml.Schema.XmlSchemaValidationFlags value) { }
        private System.Xml.Schema.XmlSchemaSet get_Schemas() { }
        private System.Void set_Schemas(System.Xml.Schema.XmlSchemaSet value) { }
        private System.Xml.XmlReaderSettings Clone() { }
        private System.Xml.Schema.ValidationEventHandler GetEventHandler() { }
        private System.Xml.XmlReader CreateReader(System.IO.Stream input, System.Uri baseUri, System.String baseUriString, System.Xml.XmlParserContext inputContext) { }
        private System.Xml.XmlReader CreateReader(System.IO.TextReader input, System.String baseUriString, System.Xml.XmlParserContext inputContext) { }
        private System.Void set_ReadOnly(System.Boolean value) { }
        private System.Void CheckReadOnly(System.String propertyName) { }
        private System.Void Initialize() { }
        private System.Void Initialize(System.Xml.XmlResolver resolver) { }
        private System.Xml.XmlResolver CreateDefaultResolver() { }
        private System.Xml.XmlReader AddValidation(System.Xml.XmlReader reader) { }
        private System.Xml.XmlValidatingReaderImpl CreateDtdValidatingReader(System.Xml.XmlReader baseReader) { }
        private System.Boolean EnableLegacyXmlSettings() { }

    }

    // TypeToken: 0x2000053
    public struct XmlSpace
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlSpace None;        // 0x0
        public static System.Xml.XmlSpace Default;        // 0x0
        public static System.Xml.XmlSpace Preserve;        // 0x0

    }

    // TypeToken: 0x2000054
    public class XmlTextEncoder
    {
        // Fields
        private System.IO.TextWriter textWriter;        // 0x10
        private System.Boolean inAttribute;        // 0x18
        private System.Char quoteChar;        // 0x1A
        private System.Text.StringBuilder attrValue;        // 0x20
        private System.Boolean cacheAttrValue;        // 0x28
        private System.Xml.XmlCharType xmlCharType;        // 0x30

        // Methods
        private System.Void .ctor(System.IO.TextWriter textWriter) { }
        private System.Void set_QuoteChar(System.Char value) { }
        private System.Void StartAttribute(System.Boolean cacheAttrValue) { }
        private System.Void EndAttribute() { }
        private System.String get_AttributeValue() { }
        private System.Void WriteSurrogateChar(System.Char lowChar, System.Char highChar) { }
        private System.Void Write(System.Char[] array, System.Int32 offset, System.Int32 count) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void Write(System.String text) { }
        private System.Void WriteRawWithSurrogateChecking(System.String text) { }
        private System.Void WriteRaw(System.Char[] array, System.Int32 offset, System.Int32 count) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteStringFragment(System.String str, System.Int32 offset, System.Int32 count, System.Char[] helperBuffer) { }
        private System.Void WriteCharEntityImpl(System.Char ch) { }
        private System.Void WriteCharEntityImpl(System.String strVal) { }
        private System.Void WriteEntityRefImpl(System.String name) { }

    }

    // TypeToken: 0x2000055
    public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
    {
        // Fields
        private System.Xml.XmlTextReaderImpl impl;        // 0x10

        // Methods
        private System.Void .ctor(System.IO.Stream input) { }
        private System.Void .ctor(System.String url, System.IO.Stream input, System.Xml.XmlNameTable nt) { }
        private System.Void .ctor(System.IO.TextReader input) { }
        private System.Void .ctor(System.IO.TextReader input, System.Xml.XmlNameTable nt) { }
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
        private System.Boolean HasLineInfo() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }
        private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName) { }
        private System.Boolean get_Namespaces() { }
        private System.Boolean get_Normalization() { }
        private System.Void set_Normalization(System.Boolean value) { }
        private System.Void set_WhitespaceHandling(System.Xml.WhitespaceHandling value) { }
        private System.Void set_EntityHandling(System.Xml.EntityHandling value) { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Xml.XmlTextReaderImpl get_Impl() { }
        private System.Xml.XmlNamespaceManager get_NamespaceManager() { }
        private System.Void set_XmlValidatingReaderCompatibilityMode(System.Boolean value) { }
        private System.Xml.IDtdInfo get_DtdInfo() { }

    }

    // TypeToken: 0x2000056
    public class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
    {
        // Fields
        private readonly System.Boolean useAsync;        // 0x10
        private System.Xml.XmlTextReaderImpl.LaterInitParam laterInitParam;        // 0x18
        private System.Xml.XmlCharType xmlCharType;        // 0x20
        private System.Xml.XmlTextReaderImpl.ParsingState ps;        // 0x28
        private System.Xml.XmlTextReaderImpl.ParsingFunction parsingFunction;        // 0xA0
        private System.Xml.XmlTextReaderImpl.ParsingFunction nextParsingFunction;        // 0xA4
        private System.Xml.XmlTextReaderImpl.ParsingFunction nextNextParsingFunction;        // 0xA8
        private System.Xml.XmlTextReaderImpl.NodeData[] nodes;        // 0xB0
        private System.Xml.XmlTextReaderImpl.NodeData curNode;        // 0xB8
        private System.Int32 index;        // 0xC0
        private System.Int32 curAttrIndex;        // 0xC4
        private System.Int32 attrCount;        // 0xC8
        private System.Int32 attrHashtable;        // 0xCC
        private System.Int32 attrDuplWalkCount;        // 0xD0
        private System.Boolean attrNeedNamespaceLookup;        // 0xD4
        private System.Boolean fullAttrCleanup;        // 0xD5
        private System.Xml.XmlTextReaderImpl.NodeData[] attrDuplSortingArray;        // 0xD8
        private System.Xml.XmlNameTable nameTable;        // 0xE0
        private System.Boolean nameTableFromSettings;        // 0xE8
        private System.Xml.XmlResolver xmlResolver;        // 0xF0
        private System.String url;        // 0xF8
        private System.Boolean normalize;        // 0x100
        private System.Boolean supportNamespaces;        // 0x101
        private System.Xml.WhitespaceHandling whitespaceHandling;        // 0x104
        private System.Xml.DtdProcessing dtdProcessing;        // 0x108
        private System.Xml.EntityHandling entityHandling;        // 0x10C
        private System.Boolean ignorePIs;        // 0x110
        private System.Boolean ignoreComments;        // 0x111
        private System.Boolean checkCharacters;        // 0x112
        private System.Int32 lineNumberOffset;        // 0x114
        private System.Int32 linePositionOffset;        // 0x118
        private System.Boolean closeInput;        // 0x11C
        private System.Int64 maxCharactersInDocument;        // 0x120
        private System.Int64 maxCharactersFromEntities;        // 0x128
        private System.Boolean v1Compat;        // 0x130
        private System.Xml.XmlNamespaceManager namespaceManager;        // 0x138
        private System.String lastPrefix;        // 0x140
        private System.Xml.XmlTextReaderImpl.XmlContext xmlContext;        // 0x148
        private System.Xml.XmlTextReaderImpl.ParsingState[] parsingStatesStack;        // 0x150
        private System.Int32 parsingStatesStackTop;        // 0x158
        private System.String reportedBaseUri;        // 0x160
        private System.Text.Encoding reportedEncoding;        // 0x168
        private System.Xml.IDtdInfo dtdInfo;        // 0x170
        private System.Xml.XmlNodeType fragmentType;        // 0x178
        private System.Xml.XmlParserContext fragmentParserContext;        // 0x180
        private System.Boolean fragment;        // 0x188
        private System.Xml.IncrementalReadDecoder incReadDecoder;        // 0x190
        private System.Xml.XmlTextReaderImpl.IncrementalReadState incReadState;        // 0x198
        private System.Xml.LineInfo incReadLineInfo;        // 0x19C
        private System.Int32 incReadDepth;        // 0x1A4
        private System.Int32 incReadLeftStartPos;        // 0x1A8
        private System.Int32 incReadLeftEndPos;        // 0x1AC
        private System.Int32 attributeValueBaseEntityId;        // 0x1B0
        private System.Boolean emptyEntityInAttributeResolved;        // 0x1B4
        private System.Xml.IValidationEventHandling validationEventHandling;        // 0x1B8
        private System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse;        // 0x1C0
        private System.Boolean validatingReaderCompatFlag;        // 0x1C8
        private System.Boolean addDefaultAttributesAndNormalize;        // 0x1C9
        private System.Text.StringBuilder stringBuilder;        // 0x1D0
        private System.Boolean rootElementParsed;        // 0x1D8
        private System.Boolean standalone;        // 0x1D9
        private System.Int32 nextEntityId;        // 0x1DC
        private System.Xml.XmlTextReaderImpl.ParsingMode parsingMode;        // 0x1E0
        private System.Xml.ReadState readState;        // 0x1E4
        private System.Xml.IDtdEntityInfo lastEntity;        // 0x1E8
        private System.Boolean afterResetState;        // 0x1F0
        private System.Int32 documentStartBytePos;        // 0x1F4
        private System.Int32 readValueOffset;        // 0x1F8
        private System.Int64 charactersInDocument;        // 0x200
        private System.Int64 charactersFromEntities;        // 0x208
        private System.Collections.Generic.Dictionary<System.Xml.IDtdEntityInfo,System.Xml.IDtdEntityInfo> currentEntities;        // 0x210
        private System.Boolean disableUndeclaredEntityCheck;        // 0x218
        private System.Xml.XmlReader outerReader;        // 0x220
        private System.Boolean xmlResolverIsSet;        // 0x228
        private System.String Xml;        // 0x230
        private System.String XmlNs;        // 0x238
        private System.Threading.Tasks.Task<System.Tuple<System.Int32,System.Int32,System.Int32,System.Boolean>> parseText_dummyTask;        // 0x240

        // Methods
        private System.Void .ctor(System.Xml.XmlNameTable nt) { }
        private System.Void .ctor(System.Xml.XmlResolver resolver, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext context) { }
        private System.Void .ctor(System.IO.Stream input) { }
        private System.Void .ctor(System.String url, System.IO.Stream input, System.Xml.XmlNameTable nt) { }
        private System.Void .ctor(System.IO.TextReader input) { }
        private System.Void .ctor(System.IO.TextReader input, System.Xml.XmlNameTable nt) { }
        private System.Void .ctor(System.String url, System.IO.TextReader input, System.Xml.XmlNameTable nt) { }
        private System.Void .ctor(System.String xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context) { }
        private System.Void .ctor(System.String xmlFragment, System.Xml.XmlParserContext context) { }
        private System.Void FinishInitUriString() { }
        private System.Void .ctor(System.IO.Stream stream, System.Byte[] bytes, System.Int32 byteCount, System.Xml.XmlReaderSettings settings, System.Uri baseUri, System.String baseUriStr, System.Xml.XmlParserContext context, System.Boolean closeInput) { }
        private System.Void FinishInitStream() { }
        private System.Void .ctor(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, System.String baseUriStr, System.Xml.XmlParserContext context) { }
        private System.Void FinishInitTextReader() { }
        private System.Void .ctor(System.String xmlFragment, System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings) { }
        private System.Xml.XmlReaderSettings get_Settings() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Prefix() { }
        private System.String get_Value() { }
        private System.Int32 get_Depth() { }
        private System.String get_BaseURI() { }
        private System.Boolean get_IsEmptyElement() { }
        private System.Boolean get_IsDefault() { }
        private System.Char get_QuoteChar() { }
        private System.Xml.XmlSpace get_XmlSpace() { }
        private System.String get_XmlLang() { }
        private System.Xml.ReadState get_ReadState() { }
        private System.Boolean get_EOF() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Boolean get_CanResolveEntity() { }
        private System.Int32 get_AttributeCount() { }
        private System.String GetAttribute(System.String name) { }
        private System.String GetAttribute(System.String localName, System.String namespaceURI) { }
        private System.String GetAttribute(System.Int32 i) { }
        private System.Boolean MoveToAttribute(System.String name) { }
        private System.Void MoveToAttribute(System.Int32 i) { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }
        private System.Boolean MoveToElement() { }
        private System.Void FinishInit() { }
        private System.Boolean Read() { }
        private System.Void Close() { }
        private System.Void Skip() { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.Boolean ReadAttributeValue() { }
        private System.Void ResolveEntity() { }
        private System.Void set_OuterReader(System.Xml.XmlReader value) { }
        private System.Void MoveOffEntityReference() { }
        private System.String ReadString() { }
        private System.Boolean get_CanReadValueChunk() { }
        private System.Int32 ReadValueChunk(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Boolean HasLineInfo() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }
        private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName) { }
        private System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String LookupPrefix(System.String namespaceName) { }
        private System.Boolean get_Namespaces() { }
        private System.Void set_Namespaces(System.Boolean value) { }
        private System.Boolean get_Normalization() { }
        private System.Void set_Normalization(System.Boolean value) { }
        private System.Void set_WhitespaceHandling(System.Xml.WhitespaceHandling value) { }
        private System.Void set_EntityHandling(System.Xml.EntityHandling value) { }
        private System.Boolean get_IsResolverSet() { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Xml.XmlNameTable get_DtdParserProxy_NameTable() { }
        private System.Xml.IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }
        private System.Boolean get_DtdParserProxy_DtdValidation() { }
        private System.Boolean get_DtdParserProxy_Normalization() { }
        private System.Boolean get_DtdParserProxy_Namespaces() { }
        private System.Boolean get_DtdParserProxy_V1CompatibilityMode() { }
        private System.Uri get_DtdParserProxy_BaseUri() { }
        private System.Boolean get_DtdParserProxy_IsEof() { }
        private System.Char[] get_DtdParserProxy_ParsingBuffer() { }
        private System.Int32 get_DtdParserProxy_ParsingBufferLength() { }
        private System.Int32 get_DtdParserProxy_CurrentPosition() { }
        private System.Void set_DtdParserProxy_CurrentPosition(System.Int32 value) { }
        private System.Int32 get_DtdParserProxy_EntityStackLength() { }
        private System.Boolean get_DtdParserProxy_IsEntityEolNormalized() { }
        private System.Xml.IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }
        private System.Void DtdParserProxy_OnNewLine(System.Int32 pos) { }
        private System.Int32 get_DtdParserProxy_LineNo() { }
        private System.Int32 get_DtdParserProxy_LineStartPosition() { }
        private System.Int32 DtdParserProxy_ReadData() { }
        private System.Int32 DtdParserProxy_ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder) { }
        private System.Int32 DtdParserProxy_ParseNamedCharRef(System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder) { }
        private System.Void DtdParserProxy_ParsePI(System.Text.StringBuilder sb) { }
        private System.Void DtdParserProxy_ParseComment(System.Text.StringBuilder sb) { }
        private System.Boolean get_IsResolverNull() { }
        private System.Xml.XmlResolver GetTempResolver() { }
        private System.Boolean DtdParserProxy_PushEntity(System.Xml.IDtdEntityInfo entity, System.Int32& entityId) { }
        private System.Boolean DtdParserProxy_PopEntity(System.Xml.IDtdEntityInfo& oldEntity, System.Int32& newEntityId) { }
        private System.Boolean DtdParserProxy_PushExternalSubset(System.String systemId, System.String publicId) { }
        private System.Void DtdParserProxy_PushInternalDtd(System.String baseUri, System.String internalDtd) { }
        private System.Void DtdParserProxy_Throw(System.Exception e) { }
        private System.Void DtdParserProxy_OnSystemId(System.String systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo) { }
        private System.Void DtdParserProxy_OnPublicId(System.String publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo) { }
        private System.Void Throw(System.Int32 pos, System.String res, System.String arg) { }
        private System.Void Throw(System.Int32 pos, System.String res, System.String[] args) { }
        private System.Void Throw(System.Int32 pos, System.String res) { }
        private System.Void Throw(System.String res) { }
        private System.Void Throw(System.String res, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Void Throw(System.String res, System.String arg) { }
        private System.Void Throw(System.String res, System.String arg, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Void Throw(System.String res, System.String[] args) { }
        private System.Void Throw(System.String res, System.String arg, System.Exception innerException) { }
        private System.Void Throw(System.String res, System.String[] args, System.Exception innerException) { }
        private System.Void Throw(System.Exception e) { }
        private System.Void ReThrow(System.Exception e, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Void ThrowWithoutLineInfo(System.String res) { }
        private System.Void ThrowWithoutLineInfo(System.String res, System.String arg) { }
        private System.Void ThrowWithoutLineInfo(System.String res, System.String[] args, System.Exception innerException) { }
        private System.Void ThrowInvalidChar(System.Char[] data, System.Int32 length, System.Int32 invCharPos) { }
        private System.Void SetErrorState() { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.String code, System.String arg, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException exception) { }
        private System.Boolean get_InAttributeValueIterator() { }
        private System.Void FinishAttributeValueIterator() { }
        private System.Boolean get_DtdValidation() { }
        private System.Void InitStreamInput(System.IO.Stream stream, System.Text.Encoding encoding) { }
        private System.Void InitStreamInput(System.String baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding) { }
        private System.Void InitStreamInput(System.Uri baseUri, System.IO.Stream stream, System.Text.Encoding encoding) { }
        private System.Void InitStreamInput(System.Uri baseUri, System.String baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding) { }
        private System.Void InitStreamInput(System.Uri baseUri, System.String baseUriStr, System.IO.Stream stream, System.Byte[] bytes, System.Int32 byteCount, System.Text.Encoding encoding) { }
        private System.Void InitTextReaderInput(System.String baseUriStr, System.IO.TextReader input) { }
        private System.Void InitTextReaderInput(System.String baseUriStr, System.Uri baseUri, System.IO.TextReader input) { }
        private System.Void InitStringInput(System.String baseUriStr, System.Text.Encoding originalEncoding, System.String str) { }
        private System.Void InitFragmentReader(System.Xml.XmlNodeType fragmentType, System.Xml.XmlParserContext parserContext, System.Boolean allowXmlDeclFragment) { }
        private System.Void ProcessDtdFromParserContext(System.Xml.XmlParserContext context) { }
        private System.Void OpenUrl() { }
        private System.Void OpenUrlDelegate(System.Object xmlResolver) { }
        private System.Text.Encoding DetectEncoding() { }
        private System.Void SetupEncoding(System.Text.Encoding encoding) { }
        private System.Void SwitchEncoding(System.Text.Encoding newEncoding) { }
        private System.Text.Encoding CheckEncoding(System.String newEncodingName) { }
        private System.Void UnDecodeChars() { }
        private System.Void SwitchEncodingToUTF8() { }
        private System.Int32 ReadData() { }
        private System.Int32 GetChars(System.Int32 maxCharsCount) { }
        private System.Void InvalidCharRecovery(System.Int32& bytesCount, System.Int32& charsCount) { }
        private System.Void Close(System.Boolean closeInput) { }
        private System.Void ShiftBuffer(System.Int32 sourcePos, System.Int32 destPos, System.Int32 count) { }
        private System.Boolean ParseXmlDeclaration(System.Boolean isTextDecl) { }
        private System.Boolean ParseDocumentContent() { }
        private System.Boolean ParseElementContent() { }
        private System.Void ThrowUnclosedElements() { }
        private System.Void ParseElement() { }
        private System.Void AddDefaultAttributesAndNormalize() { }
        private System.Void ParseEndElement() { }
        private System.Void ThrowTagMismatch(System.Xml.XmlTextReaderImpl.NodeData startTag) { }
        private System.Void ParseAttributes() { }
        private System.Void ElementNamespaceLookup() { }
        private System.Void AttributeNamespaceLookup() { }
        private System.Void AttributeDuplCheck() { }
        private System.Void OnDefaultNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr) { }
        private System.Void OnNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr) { }
        private System.Void OnXmlReservedAttribute(System.Xml.XmlTextReaderImpl.NodeData attr) { }
        private System.Void ParseAttributeValueSlow(System.Int32 curPos, System.Char quoteChar, System.Xml.XmlTextReaderImpl.NodeData attr) { }
        private System.Void AddAttributeChunkToList(System.Xml.XmlTextReaderImpl.NodeData attr, System.Xml.XmlTextReaderImpl.NodeData chunk, System.Xml.XmlTextReaderImpl.NodeData& lastChunk) { }
        private System.Boolean ParseText() { }
        private System.Boolean ParseText(System.Int32& startPos, System.Int32& endPos, System.Int32& outOrChars) { }
        private System.Void FinishPartialValue() { }
        private System.Void FinishOtherValueIterator() { }
        private System.Void SkipPartialTextValue() { }
        private System.Void FinishReadValueChunk() { }
        private System.Void FinishReadContentAsBinary() { }
        private System.Void FinishReadElementContentAsBinary() { }
        private System.Boolean ParseRootLevelWhitespace() { }
        private System.Void ParseEntityReference() { }
        private System.Xml.XmlTextReaderImpl.EntityType HandleEntityReference(System.Boolean isInAttributeValue, System.Xml.XmlTextReaderImpl.EntityExpandType expandType, System.Int32& charRefEndPos) { }
        private System.Xml.XmlTextReaderImpl.EntityType HandleGeneralEntityReference(System.String name, System.Boolean isInAttributeValue, System.Boolean pushFakeEntityIfNullResolver, System.Int32 entityStartLinePos) { }
        private System.Boolean get_InEntity() { }
        private System.Boolean HandleEntityEnd(System.Boolean checkEntityNesting) { }
        private System.Void SetupEndEntityNodeInContent() { }
        private System.Void SetupEndEntityNodeInAttribute() { }
        private System.Boolean ParsePI() { }
        private System.Boolean ParsePI(System.Text.StringBuilder piInDtdStringBuilder) { }
        private System.Boolean ParsePIValue(System.Int32& outStartPos, System.Int32& outEndPos) { }
        private System.Boolean ParseComment() { }
        private System.Void ParseCData() { }
        private System.Void ParseCDataOrComment(System.Xml.XmlNodeType type) { }
        private System.Boolean ParseCDataOrComment(System.Xml.XmlNodeType type, System.Int32& outStartPos, System.Int32& outEndPos) { }
        private System.Boolean ParseDoctypeDecl() { }
        private System.Void ParseDtd() { }
        private System.Void SkipDtd() { }
        private System.Void SkipPublicOrSystemIdLiteral() { }
        private System.Void SkipUntil(System.Char stopChar, System.Boolean recognizeLiterals) { }
        private System.Int32 EatWhitespaces(System.Text.StringBuilder sb) { }
        private System.Int32 ParseCharRefInline(System.Int32 startPos, System.Int32& charCount, System.Xml.XmlTextReaderImpl.EntityType& entityType) { }
        private System.Int32 ParseNumericCharRef(System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder, System.Xml.XmlTextReaderImpl.EntityType& entityType) { }
        private System.Int32 ParseNumericCharRefInline(System.Int32 startPos, System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder, System.Int32& charCount, System.Xml.XmlTextReaderImpl.EntityType& entityType) { }
        private System.Int32 ParseNamedCharRef(System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder) { }
        private System.Int32 ParseNamedCharRefInline(System.Int32 startPos, System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder) { }
        private System.Int32 ParseName() { }
        private System.Int32 ParseQName(System.Int32& colonPos) { }
        private System.Int32 ParseQName(System.Boolean isQName, System.Int32 startOffset, System.Int32& colonPos) { }
        private System.Boolean ReadDataInName(System.Int32& pos) { }
        private System.String ParseEntityName() { }
        private System.Xml.XmlTextReaderImpl.NodeData AddNode(System.Int32 nodeIndex, System.Int32 nodeDepth) { }
        private System.Xml.XmlTextReaderImpl.NodeData AllocNode(System.Int32 nodeIndex, System.Int32 nodeDepth) { }
        private System.Xml.XmlTextReaderImpl.NodeData AddAttributeNoChecks(System.String name, System.Int32 attrDepth) { }
        private System.Xml.XmlTextReaderImpl.NodeData AddAttribute(System.Int32 endNamePos, System.Int32 colonPos) { }
        private System.Xml.XmlTextReaderImpl.NodeData AddAttribute(System.String localName, System.String prefix, System.String nameWPrefix) { }
        private System.Void PopElementContext() { }
        private System.Void OnNewLine(System.Int32 pos) { }
        private System.Void OnEof() { }
        private System.String LookupNamespace(System.Xml.XmlTextReaderImpl.NodeData node) { }
        private System.Void AddNamespace(System.String prefix, System.String uri, System.Xml.XmlTextReaderImpl.NodeData attr) { }
        private System.Void ResetAttributes() { }
        private System.Void FullAttributeCleanup() { }
        private System.Void PushXmlContext() { }
        private System.Void PopXmlContext() { }
        private System.Xml.XmlNodeType GetWhitespaceType() { }
        private System.Xml.XmlNodeType GetTextNodeType(System.Int32 orChars) { }
        private System.Void PushExternalEntityOrSubset(System.String publicId, System.String systemId, System.Uri baseUri, System.String entityName) { }
        private System.Boolean OpenAndPush(System.Uri uri) { }
        private System.Boolean PushExternalEntity(System.Xml.IDtdEntityInfo entity) { }
        private System.Void PushInternalEntity(System.Xml.IDtdEntityInfo entity) { }
        private System.Void PopEntity() { }
        private System.Void RegisterEntity(System.Xml.IDtdEntityInfo entity) { }
        private System.Void UnregisterEntity() { }
        private System.Void PushParsingState() { }
        private System.Void PopParsingState() { }
        private System.Int32 IncrementalRead() { }
        private System.Void FinishIncrementalRead() { }
        private System.Boolean ParseFragmentAttribute() { }
        private System.Boolean ParseAttributeValueChunk() { }
        private System.Void ParseXmlDeclarationFragment() { }
        private System.Void ThrowUnexpectedToken(System.Int32 pos, System.String expectedToken) { }
        private System.Void ThrowUnexpectedToken(System.String expectedToken1) { }
        private System.Void ThrowUnexpectedToken(System.Int32 pos, System.String expectedToken1, System.String expectedToken2) { }
        private System.Void ThrowUnexpectedToken(System.String expectedToken1, System.String expectedToken2) { }
        private System.String ParseUnexpectedToken(System.Int32 pos) { }
        private System.String ParseUnexpectedToken() { }
        private System.Void ThrowExpectingWhitespace(System.Int32 pos) { }
        private System.Int32 GetIndexOfAttributeWithoutPrefix(System.String name) { }
        private System.Int32 GetIndexOfAttributeWithPrefix(System.String name) { }
        private System.Boolean ZeroEndingStream(System.Int32 pos) { }
        private System.Void ParseDtdFromParserContext() { }
        private System.Boolean MoveToNextContentNode(System.Boolean moveIfOnContentNode) { }
        private System.Void SetupFromParserContext(System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings) { }
        private System.Xml.IDtdInfo get_DtdInfo() { }
        private System.Void SetDtdInfo(System.Xml.IDtdInfo newDtdInfo) { }
        private System.Void set_ValidationEventHandling(System.Xml.IValidationEventHandling value) { }
        private System.Void set_OnDefaultAttributeUse(System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }
        private System.Void set_XmlValidatingReaderCompatibilityMode(System.Boolean value) { }
        private System.Xml.XmlNodeType get_FragmentType() { }
        private System.Void ChangeCurrentNodeType(System.Xml.XmlNodeType newNodeType) { }
        private System.Xml.XmlResolver GetResolver() { }
        private System.Void set_InternalSchemaType(System.Object value) { }
        private System.Object get_InternalTypedValue() { }
        private System.Void set_InternalTypedValue(System.Object value) { }
        private System.Boolean get_StandAlone() { }
        private System.Xml.XmlNamespaceManager get_NamespaceManager() { }
        private System.Boolean get_V1Compat() { }
        private System.Boolean AddDefaultAttributeDtd(System.Xml.IDtdDefaultAttributeInfo defAttrInfo, System.Boolean definedInDtd, System.Xml.XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }
        private System.Boolean AddDefaultAttributeNonDtd(System.Xml.Schema.SchemaAttDef attrDef) { }
        private System.Xml.XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(System.String localName, System.String ns, System.String prefix, System.String value, System.Int32 lineNo, System.Int32 linePos, System.Int32 valueLineNo, System.Int32 valueLinePos, System.Boolean isXmlAttribute) { }
        private System.Void set_DisableUndeclaredEntityCheck(System.Boolean value) { }
        private System.Boolean UriEqual(System.Uri uri1, System.String uri1Str, System.String uri2Str, System.Xml.XmlResolver resolver) { }
        private System.Void RegisterConsumedCharacters(System.Int64 characters, System.Boolean inEntityReference) { }
        private System.String StripSpaces(System.String value) { }
        private System.Void StripSpaces(System.Char[] value, System.Int32 index, System.Int32& len) { }
        private System.Void BlockCopyChars(System.Char[] src, System.Int32 srcOffset, System.Char[] dst, System.Int32 dstOffset, System.Int32 count) { }
        private System.Void BlockCopy(System.Byte[] src, System.Int32 srcOffset, System.Byte[] dst, System.Int32 dstOffset, System.Int32 count) { }

    }

    // TypeToken: 0x2000065
    public struct Formatting
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Formatting None;        // 0x0
        public static System.Xml.Formatting Indented;        // 0x0

    }

    // TypeToken: 0x2000066
    public class XmlTextWriter : XmlWriter
    {
        // Fields
        private System.IO.TextWriter textWriter;        // 0x18
        private System.Xml.XmlTextEncoder xmlEncoder;        // 0x20
        private System.Text.Encoding encoding;        // 0x28
        private System.Xml.Formatting formatting;        // 0x30
        private System.Boolean indented;        // 0x34
        private System.Int32 indentation;        // 0x38
        private System.Char indentChar;        // 0x3C
        private System.Xml.XmlTextWriter.TagInfo[] stack;        // 0x40
        private System.Int32 top;        // 0x48
        private System.Xml.XmlTextWriter.State[] stateTable;        // 0x50
        private System.Xml.XmlTextWriter.State currentState;        // 0x58
        private System.Xml.XmlTextWriter.Token lastToken;        // 0x5C
        private System.Xml.XmlTextWriterBase64Encoder base64Encoder;        // 0x60
        private System.Char quoteChar;        // 0x68
        private System.Char curQuoteChar;        // 0x6A
        private System.Boolean namespaces;        // 0x6C
        private System.Xml.XmlTextWriter.SpecialAttr specialAttr;        // 0x70
        private System.String prefixForXmlNs;        // 0x78
        private System.Boolean flush;        // 0x80
        private System.Xml.XmlTextWriter.Namespace[] nsStack;        // 0x88
        private System.Int32 nsTop;        // 0x90
        private System.Collections.Generic.Dictionary<System.String,System.Int32> nsHashtable;        // 0x98
        private System.Boolean useNsHashtable;        // 0xA0
        private System.Xml.XmlCharType xmlCharType;        // 0xA8
        private static System.String[] stateName;        // 0x0
        private static System.String[] tokenName;        // 0x8
        private static readonly System.Xml.XmlTextWriter.State[] stateTableDefault;        // 0x10
        private static readonly System.Xml.XmlTextWriter.State[] stateTableDocument;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.IO.Stream w, System.Text.Encoding encoding) { }
        private System.Void .ctor(System.String filename, System.Text.Encoding encoding) { }
        private System.Void .ctor(System.IO.TextWriter w) { }
        private System.IO.Stream get_BaseStream() { }
        private System.Void set_Namespaces(System.Boolean value) { }
        private System.Void set_Formatting(System.Xml.Formatting value) { }
        private System.Void set_QuoteChar(System.Char value) { }
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
        private System.Void StartDocument(System.Int32 standalone) { }
        private System.Void AutoComplete(System.Xml.XmlTextWriter.Token token) { }
        private System.Void AutoCompleteAll() { }
        private System.Void InternalWriteEndElement(System.Boolean longFormat) { }
        private System.Void WriteEndStartTag(System.Boolean empty) { }
        private System.Void WriteEndAttributeQuote() { }
        private System.Void Indent(System.Boolean beforeEndElement) { }
        private System.Void PushNamespace(System.String prefix, System.String ns, System.Boolean declared) { }
        private System.Void AddNamespace(System.String prefix, System.String ns, System.Boolean declared) { }
        private System.Void AddToNamespaceHashtable(System.Int32 namespaceIndex) { }
        private System.Void PopNamespaces(System.Int32 indexFrom, System.Int32 indexTo) { }
        private System.String GeneratePrefix() { }
        private System.Void InternalWriteProcessingInstruction(System.String name, System.String text) { }
        private System.Int32 LookupNamespace(System.String prefix) { }
        private System.Int32 LookupNamespaceInCurrentScope(System.String prefix) { }
        private System.String FindPrefix(System.String ns) { }
        private System.Void ValidateName(System.String name, System.Boolean isNCName) { }
        private System.Void HandleSpecialAttribute() { }
        private System.Void VerifyPrefixXml(System.String prefix, System.String ns) { }
        private System.Void PushStack() { }
        private System.Void FlushEncoders() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006D
    public class XmlUtf8RawTextWriter : XmlRawWriter
    {
        // Fields
        private readonly System.Boolean useAsync;        // 0x28
        protected System.Byte[] bufBytes;        // 0x30
        protected System.IO.Stream stream;        // 0x38
        protected System.Text.Encoding encoding;        // 0x40
        protected System.Xml.XmlCharType xmlCharType;        // 0x48
        protected System.Int32 bufPos;        // 0x50
        protected System.Int32 textPos;        // 0x54
        protected System.Int32 contentPos;        // 0x58
        protected System.Int32 cdataPos;        // 0x5C
        protected System.Int32 attrEndPos;        // 0x60
        protected System.Int32 bufLen;        // 0x64
        protected System.Boolean writeToNull;        // 0x68
        protected System.Boolean hadDoubleBracket;        // 0x69
        protected System.Boolean inAttributeValue;        // 0x6A
        protected System.Xml.NewLineHandling newLineHandling;        // 0x6C
        protected System.Boolean closeOutput;        // 0x70
        protected System.Boolean omitXmlDeclaration;        // 0x71
        protected System.String newLineChars;        // 0x78
        protected System.Boolean checkCharacters;        // 0x80
        protected System.Xml.XmlStandalone standalone;        // 0x84
        protected System.Xml.XmlOutputMethod outputMethod;        // 0x88
        protected System.Boolean autoXmlDeclaration;        // 0x8C
        protected System.Boolean mergeCDataSections;        // 0x8D

        // Methods
        private System.Void .ctor(System.Xml.XmlWriterSettings settings) { }
        private System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone) { }
        private System.Void WriteXmlDeclaration(System.String xmldecl) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void StartElementContent() { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndAttribute() { }
        private System.Void WriteNamespaceDeclaration(System.String prefix, System.String namespaceName) { }
        private System.Boolean get_SupportsNamespaceDeclarationInChunks() { }
        private System.Void WriteStartNamespaceDeclaration(System.String prefix) { }
        private System.Void WriteEndNamespaceDeclaration() { }
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
        private System.Void Close() { }
        private System.Void Flush() { }
        private System.Void FlushBuffer() { }
        private System.Void FlushEncoder() { }
        private System.Void WriteAttributeTextBlock(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void WriteElementTextBlock(System.Char* pSrc, System.Char* pSrcEnd) { }
        private System.Void RawText(System.String s) { }
        private System.Void RawText(System.Char* pSrcBegin, System.Char* pSrcEnd) { }
        private System.Void WriteRawWithCharChecking(System.Char* pSrcBegin, System.Char* pSrcEnd) { }
        private System.Void WriteCommentOrPi(System.String text, System.Int32 stopChar) { }
        private System.Void WriteCDataSection(System.String text) { }
        private System.Boolean IsSurrogateByte(System.Byte b) { }
        private System.Byte* EncodeSurrogate(System.Char* pSrc, System.Char* pSrcEnd, System.Byte* pDst) { }
        private System.Byte* InvalidXmlChar(System.Int32 ch, System.Byte* pDst, System.Boolean entitize) { }
        private System.Void EncodeChar(System.Char*& pSrc, System.Char* pSrcEnd, System.Byte*& pDst) { }
        private System.Byte* EncodeMultibyteUTF8(System.Int32 ch, System.Byte* pDst) { }
        private System.Void CharToUTF8(System.Char*& pSrc, System.Char* pSrcEnd, System.Byte*& pDst) { }
        private System.Byte* WriteNewLine(System.Byte* pDst) { }
        private System.Byte* LtEntity(System.Byte* pDst) { }
        private System.Byte* GtEntity(System.Byte* pDst) { }
        private System.Byte* AmpEntity(System.Byte* pDst) { }
        private System.Byte* QuoteEntity(System.Byte* pDst) { }
        private System.Byte* TabEntity(System.Byte* pDst) { }
        private System.Byte* LineFeedEntity(System.Byte* pDst) { }
        private System.Byte* CarriageReturnEntity(System.Byte* pDst) { }
        private System.Byte* CharEntity(System.Byte* pDst, System.Char ch) { }
        private System.Byte* RawStartCData(System.Byte* pDst) { }
        private System.Byte* RawEndCData(System.Byte* pDst) { }
        private System.Void ValidateContentChars(System.String chars, System.String propertyName, System.Boolean allowOnlyWhitespace) { }

    }

    // TypeToken: 0x200006E
    public class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
    {
        // Fields
        protected System.Int32 indentLevel;        // 0x90
        protected System.Boolean newLineOnAttributes;        // 0x94
        protected System.String indentChars;        // 0x98
        protected System.Boolean mixedContent;        // 0xA0
        private System.Xml.BitStack mixedContentStack;        // 0xA8
        protected System.Xml.ConformanceLevel conformanceLevel;        // 0xB0

        // Methods
        private System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void StartElementContent() { }
        private System.Void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel) { }
        private System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteCData(System.String text) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void WriteProcessingInstruction(System.String target, System.String text) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteWhitespace(System.String ws) { }
        private System.Void WriteString(System.String text) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.String data) { }
        private System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void Init(System.Xml.XmlWriterSettings settings) { }
        private System.Void WriteIndent() { }

    }

    // TypeToken: 0x200006F
    public class XmlValidatingReader : XmlReader
    {
        // Fields
        private System.Xml.XmlValidatingReaderImpl impl;        // 0x10

        // Methods
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Prefix() { }
        private System.String get_Value() { }
        private System.Int32 get_Depth() { }
        private System.String get_BaseURI() { }
        private System.Boolean get_IsEmptyElement() { }
        private System.Int32 get_AttributeCount() { }
        private System.String GetAttribute(System.String name) { }
        private System.String GetAttribute(System.String localName, System.String namespaceURI) { }
        private System.String GetAttribute(System.Int32 i) { }
        private System.Boolean MoveToAttribute(System.String name) { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }
        private System.Boolean MoveToElement() { }
        private System.Boolean ReadAttributeValue() { }
        private System.Boolean Read() { }
        private System.Boolean get_EOF() { }
        private System.Xml.ReadState get_ReadState() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.Void ResolveEntity() { }
        private System.Boolean get_Namespaces() { }

    }

    // TypeToken: 0x2000070
    public class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
    {
        // Fields
        private System.Xml.XmlReader coreReader;        // 0x10
        private System.Xml.XmlTextReaderImpl coreReaderImpl;        // 0x18
        private System.Xml.IXmlNamespaceResolver coreReaderNSResolver;        // 0x20
        private System.Xml.ValidationType validationType;        // 0x28
        private System.Xml.Schema.BaseValidator validator;        // 0x30
        private System.Xml.Schema.XmlSchemaCollection schemaCollection;        // 0x38
        private System.Boolean processIdentityConstraints;        // 0x40
        private System.Xml.XmlValidatingReaderImpl.ParsingFunction parsingFunction;        // 0x44
        private System.Xml.XmlValidatingReaderImpl.ValidationEventHandling eventHandling;        // 0x48
        private System.Xml.XmlParserContext parserContext;        // 0x50
        private System.Xml.ReadContentAsBinaryHelper readBinaryHelper;        // 0x58
        private System.Xml.XmlReader outerReader;        // 0x60
        private static System.Xml.XmlResolver s_tempResolver;        // 0x0

        // Methods
        private System.Void .ctor(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler settingsEventHandler, System.Boolean processIdentityConstraints) { }
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
        private System.Xml.ReadState get_ReadState() { }
        private System.Boolean get_EOF() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Int32 get_AttributeCount() { }
        private System.String GetAttribute(System.String name) { }
        private System.String GetAttribute(System.String localName, System.String namespaceURI) { }
        private System.String GetAttribute(System.Int32 i) { }
        private System.Boolean MoveToAttribute(System.String name) { }
        private System.Void MoveToAttribute(System.Int32 i) { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }
        private System.Boolean MoveToElement() { }
        private System.Boolean Read() { }
        private System.Void Close() { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.Boolean ReadAttributeValue() { }
        private System.Boolean get_CanResolveEntity() { }
        private System.Void ResolveEntity() { }
        private System.Void MoveOffEntityReference() { }
        private System.String ReadString() { }
        private System.Boolean HasLineInfo() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }
        private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName) { }
        private System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String LookupPrefix(System.String namespaceName) { }
        private System.Xml.ValidationType get_ValidationType() { }
        private System.Xml.Schema.XmlSchemaCollection get_Schemas() { }
        private System.Boolean get_Namespaces() { }
        private System.Void ParseDtdFromParserContext() { }
        private System.Void ValidateDtd() { }
        private System.Void ResolveEntityInternally() { }
        private System.Void SetupValidation(System.Xml.ValidationType valType) { }
        private System.Xml.XmlResolver GetResolver() { }
        private System.Void ProcessCoreReaderEvent() { }
        private System.Xml.Schema.BaseValidator get_Validator() { }
        private System.Void set_Validator(System.Xml.Schema.BaseValidator value) { }
        private System.Xml.XmlNamespaceManager get_NamespaceManager() { }
        private System.Boolean get_StandAlone() { }
        private System.Void set_SchemaTypeObject(System.Object value) { }
        private System.Object get_TypedValueObject() { }
        private System.Void set_TypedValueObject(System.Object value) { }
        private System.Boolean AddDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef) { }
        private System.Xml.IDtdInfo get_DtdInfo() { }
        private System.Void ValidateDefaultAttributeOnUse(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader) { }

    }

    // TypeToken: 0x2000073
    public class XmlWellFormedWriter : XmlWriter
    {
        // Fields
        private System.Xml.XmlWriter writer;        // 0x18
        private System.Xml.XmlRawWriter rawWriter;        // 0x20
        private System.Xml.IXmlNamespaceResolver predefinedNamespaces;        // 0x28
        private System.Xml.XmlWellFormedWriter.Namespace[] nsStack;        // 0x30
        private System.Int32 nsTop;        // 0x38
        private System.Collections.Generic.Dictionary<System.String,System.Int32> nsHashtable;        // 0x40
        private System.Boolean useNsHashtable;        // 0x48
        private System.Xml.XmlWellFormedWriter.ElementScope[] elemScopeStack;        // 0x50
        private System.Int32 elemTop;        // 0x58
        private System.Xml.XmlWellFormedWriter.AttrName[] attrStack;        // 0x60
        private System.Int32 attrCount;        // 0x68
        private System.Collections.Generic.Dictionary<System.String,System.Int32> attrHashTable;        // 0x70
        private System.Xml.XmlWellFormedWriter.SpecialAttribute specAttr;        // 0x78
        private System.Xml.XmlWellFormedWriter.AttributeValueCache attrValueCache;        // 0x80
        private System.String curDeclPrefix;        // 0x88
        private System.Xml.XmlWellFormedWriter.State[] stateTable;        // 0x90
        private System.Xml.XmlWellFormedWriter.State currentState;        // 0x98
        private System.Boolean checkCharacters;        // 0x9C
        private System.Boolean omitDuplNamespaces;        // 0x9D
        private System.Boolean writeEndDocumentOnClose;        // 0x9E
        private System.Xml.ConformanceLevel conformanceLevel;        // 0xA0
        private System.Boolean dtdWritten;        // 0xA4
        private System.Boolean xmlDeclFollows;        // 0xA5
        private System.Xml.XmlCharType xmlCharType;        // 0xA8
        private System.Xml.SecureStringHasher hasher;        // 0xB0
        private static readonly System.String[] stateName;        // 0x0
        private static readonly System.String[] tokenName;        // 0x8
        private static System.Xml.WriteState[] state2WriteState;        // 0x10
        private static readonly System.Xml.XmlWellFormedWriter.State[] StateTableDocument;        // 0x18
        private static readonly System.Xml.XmlWellFormedWriter.State[] StateTableAuto;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.XmlWriter writer, System.Xml.XmlWriterSettings settings) { }
        private System.Xml.WriteState get_WriteState() { }
        private System.Void WriteStartDocument() { }
        private System.Void WriteStartDocument(System.Boolean standalone) { }
        private System.Void WriteEndDocument() { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteEndElement() { }
        private System.Void WriteFullEndElement() { }
        private System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String namespaceName) { }
        private System.Void WriteEndAttribute() { }
        private System.Void WriteCData(System.String text) { }
        private System.Void WriteComment(System.String text) { }
        private System.Void WriteProcessingInstruction(System.String name, System.String text) { }
        private System.Void WriteEntityRef(System.String name) { }
        private System.Void WriteCharEntity(System.Char ch) { }
        private System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar) { }
        private System.Void WriteWhitespace(System.String ws) { }
        private System.Void WriteString(System.String text) { }
        private System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void WriteRaw(System.String data) { }
        private System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Void Close() { }
        private System.Void Flush() { }
        private System.String LookupPrefix(System.String ns) { }
        private System.Void WriteValue(System.Boolean value) { }
        private System.Void WriteValue(System.DateTime value) { }
        private System.Void WriteValue(System.Double value) { }
        private System.Void WriteValue(System.Single value) { }
        private System.Void WriteValue(System.Decimal value) { }
        private System.Void WriteValue(System.Int32 value) { }
        private System.Void WriteValue(System.Int64 value) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void WriteValue(System.Object value) { }
        private System.Void WriteBinHex(System.Byte[] buffer, System.Int32 index, System.Int32 count) { }
        private System.Xml.XmlRawWriter get_RawWriter() { }
        private System.Boolean get_SaveAttrValue() { }
        private System.Boolean get_InBase64() { }
        private System.Void SetSpecialAttribute(System.Xml.XmlWellFormedWriter.SpecialAttribute special) { }
        private System.Void WriteStartDocumentImpl(System.Xml.XmlStandalone standalone) { }
        private System.Void StartFragment() { }
        private System.Void PushNamespaceImplicit(System.String prefix, System.String ns) { }
        private System.Boolean PushNamespaceExplicit(System.String prefix, System.String ns) { }
        private System.Void AddNamespace(System.String prefix, System.String ns, System.Xml.XmlWellFormedWriter.NamespaceKind kind) { }
        private System.Void AddToNamespaceHashtable(System.Int32 namespaceIndex) { }
        private System.Int32 LookupNamespaceIndex(System.String prefix) { }
        private System.Void PopNamespaces(System.Int32 indexFrom, System.Int32 indexTo) { }
        private System.Xml.XmlException DupAttrException(System.String prefix, System.String localName) { }
        private System.Void AdvanceState(System.Xml.XmlWellFormedWriter.Token token) { }
        private System.Void StartElementContent() { }
        private System.String GetStateName(System.Xml.XmlWellFormedWriter.State state) { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.String LookupLocalNamespace(System.String prefix) { }
        private System.String GeneratePrefix() { }
        private System.Void CheckNCName(System.String ncname) { }
        private System.Exception InvalidCharsException(System.String name, System.Int32 badCharIndex) { }
        private System.Void ThrowInvalidStateTransition(System.Xml.XmlWellFormedWriter.Token token, System.Xml.XmlWellFormedWriter.State currentState) { }
        private System.Boolean get_IsClosedOrErrorState() { }
        private System.Void AddAttribute(System.String prefix, System.String localName, System.String namespaceName) { }
        private System.Void AddToAttrHashTable(System.Int32 attributeIndex) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000080
    public struct WriteState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.WriteState Start;        // 0x0
        public static System.Xml.WriteState Prolog;        // 0x0
        public static System.Xml.WriteState Element;        // 0x0
        public static System.Xml.WriteState Attribute;        // 0x0
        public static System.Xml.WriteState Content;        // 0x0
        public static System.Xml.WriteState Closed;        // 0x0
        public static System.Xml.WriteState Error;        // 0x0

    }

    // TypeToken: 0x2000081
    public class XmlWriter, IDisposable
    {
        // Fields
        private System.Char[] writeNodeBuffer;        // 0x10

        // Methods
        private System.Void WriteStartDocument() { }
        private System.Void WriteStartDocument(System.Boolean standalone) { }
        private System.Void WriteEndDocument() { }
        private System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset) { }
        private System.Void WriteStartElement(System.String localName, System.String ns) { }
        private System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns) { }
        private System.Void WriteStartElement(System.String localName) { }
        private System.Void WriteEndElement() { }
        private System.Void WriteFullEndElement() { }
        private System.Void WriteAttributeString(System.String localName, System.String ns, System.String value) { }
        private System.Void WriteAttributeString(System.String localName, System.String value) { }
        private System.Void WriteAttributeString(System.String prefix, System.String localName, System.String ns, System.String value) { }
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
        private System.Void WriteValue(System.Object value) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void WriteValue(System.Boolean value) { }
        private System.Void WriteValue(System.DateTime value) { }
        private System.Void WriteValue(System.Double value) { }
        private System.Void WriteValue(System.Single value) { }
        private System.Void WriteValue(System.Decimal value) { }
        private System.Void WriteValue(System.Int32 value) { }
        private System.Void WriteValue(System.Int64 value) { }
        private System.Void WriteAttributes(System.Xml.XmlReader reader, System.Boolean defattr) { }
        private System.Void WriteNode(System.Xml.XmlReader reader, System.Boolean defattr) { }
        private System.Void WriteElementString(System.String localName, System.String ns, System.String value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Xml.XmlWriter Create(System.IO.Stream output, System.Xml.XmlWriterSettings settings) { }
        private System.Xml.XmlWriter Create(System.IO.TextWriter output) { }
        private System.Xml.XmlWriter Create(System.IO.TextWriter output, System.Xml.XmlWriterSettings settings) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000082
    public struct XmlOutputMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlOutputMethod Xml;        // 0x0
        public static System.Xml.XmlOutputMethod Html;        // 0x0
        public static System.Xml.XmlOutputMethod Text;        // 0x0
        public static System.Xml.XmlOutputMethod AutoDetect;        // 0x0

    }

    // TypeToken: 0x2000083
    public struct TriState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.TriState Unknown;        // 0x0
        public static System.Xml.TriState False;        // 0x0
        public static System.Xml.TriState True;        // 0x0

    }

    // TypeToken: 0x2000084
    public struct XmlStandalone
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlStandalone Omit;        // 0x0
        public static System.Xml.XmlStandalone Yes;        // 0x0
        public static System.Xml.XmlStandalone No;        // 0x0

    }

    // TypeToken: 0x2000085
    public class XmlWriterSettings
    {
        // Fields
        private System.Boolean useAsync;        // 0x10
        private System.Text.Encoding encoding;        // 0x18
        private System.Boolean omitXmlDecl;        // 0x20
        private System.Xml.NewLineHandling newLineHandling;        // 0x24
        private System.String newLineChars;        // 0x28
        private System.Xml.TriState indent;        // 0x30
        private System.String indentChars;        // 0x38
        private System.Boolean newLineOnAttributes;        // 0x40
        private System.Boolean closeOutput;        // 0x41
        private System.Xml.NamespaceHandling namespaceHandling;        // 0x44
        private System.Xml.ConformanceLevel conformanceLevel;        // 0x48
        private System.Boolean checkCharacters;        // 0x4C
        private System.Boolean writeEndDocumentOnClose;        // 0x4D
        private System.Xml.XmlOutputMethod outputMethod;        // 0x50
        private System.Collections.Generic.List<System.Xml.XmlQualifiedName> cdataSections;        // 0x58
        private System.Boolean doNotEscapeUriAttributes;        // 0x60
        private System.Boolean mergeCDataSections;        // 0x61
        private System.String mediaType;        // 0x68
        private System.String docTypeSystem;        // 0x70
        private System.String docTypePublic;        // 0x78
        private System.Xml.XmlStandalone standalone;        // 0x80
        private System.Boolean autoXmlDecl;        // 0x84
        private System.Boolean isReadOnly;        // 0x85

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_Async() { }
        private System.Text.Encoding get_Encoding() { }
        private System.Boolean get_OmitXmlDeclaration() { }
        private System.Void set_OmitXmlDeclaration(System.Boolean value) { }
        private System.Xml.NewLineHandling get_NewLineHandling() { }
        private System.String get_NewLineChars() { }
        private System.Boolean get_Indent() { }
        private System.Void set_Indent(System.Boolean value) { }
        private System.String get_IndentChars() { }
        private System.Boolean get_NewLineOnAttributes() { }
        private System.Boolean get_CloseOutput() { }
        private System.Xml.ConformanceLevel get_ConformanceLevel() { }
        private System.Void set_ConformanceLevel(System.Xml.ConformanceLevel value) { }
        private System.Boolean get_CheckCharacters() { }
        private System.Xml.NamespaceHandling get_NamespaceHandling() { }
        private System.Void set_NamespaceHandling(System.Xml.NamespaceHandling value) { }
        private System.Boolean get_WriteEndDocumentOnClose() { }
        private System.Xml.XmlOutputMethod get_OutputMethod() { }
        private System.Void set_OutputMethod(System.Xml.XmlOutputMethod value) { }
        private System.Xml.XmlWriterSettings Clone() { }
        private System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements() { }
        private System.Boolean get_DoNotEscapeUriAttributes() { }
        private System.Boolean get_MergeCDataSections() { }
        private System.String get_MediaType() { }
        private System.String get_DocTypeSystem() { }
        private System.String get_DocTypePublic() { }
        private System.Xml.XmlStandalone get_Standalone() { }
        private System.Boolean get_AutoXmlDeclaration() { }
        private System.Xml.TriState get_IndentInternal() { }
        private System.Boolean get_IsQuerySpecific() { }
        private System.Xml.XmlWriter CreateWriter(System.IO.Stream output) { }
        private System.Xml.XmlWriter CreateWriter(System.IO.TextWriter output) { }
        private System.Void set_ReadOnly(System.Boolean value) { }
        private System.Void CheckReadOnly(System.String propertyName) { }
        private System.Void Initialize() { }

    }

    // TypeToken: 0x2000086
    public class XsdCachingReader : XmlReader, IXmlLineInfo
    {
        // Fields
        private System.Xml.XmlReader coreReader;        // 0x10
        private System.Xml.XmlNameTable coreReaderNameTable;        // 0x18
        private System.Xml.ValidatingReaderNodeData[] contentEvents;        // 0x20
        private System.Xml.ValidatingReaderNodeData[] attributeEvents;        // 0x28
        private System.Xml.ValidatingReaderNodeData cachedNode;        // 0x30
        private System.Xml.XsdCachingReader.CachingReaderState cacheState;        // 0x38
        private System.Int32 contentIndex;        // 0x3C
        private System.Int32 attributeCount;        // 0x40
        private System.Boolean returnOriginalStringValues;        // 0x44
        private System.Xml.CachingEventHandler cacheHandler;        // 0x48
        private System.Int32 currentAttrIndex;        // 0x50
        private System.Int32 currentContentIndex;        // 0x54
        private System.Boolean readAhead;        // 0x58
        private System.Xml.IXmlLineInfo lineInfo;        // 0x60
        private System.Xml.ValidatingReaderNodeData textNode;        // 0x68

        // Methods
        private System.Void .ctor(System.Xml.XmlReader reader, System.Xml.IXmlLineInfo lineInfo, System.Xml.CachingEventHandler handlerMethod) { }
        private System.Void Init() { }
        private System.Void Reset(System.Xml.XmlReader reader) { }
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
        private System.String GetAttribute(System.String name, System.String namespaceURI) { }
        private System.String GetAttribute(System.Int32 i) { }
        private System.Boolean MoveToAttribute(System.String name) { }
        private System.Void MoveToAttribute(System.Int32 i) { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }
        private System.Boolean MoveToElement() { }
        private System.Boolean Read() { }
        private System.Xml.ValidatingReaderNodeData RecordTextNode(System.String textValue, System.String originalStringValue, System.Int32 depth, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Void SwitchTextNodeAndEndElement(System.String textValue, System.String originalStringValue) { }
        private System.Void RecordEndElementNode() { }
        private System.String ReadOriginalContentAsString() { }
        private System.Boolean get_EOF() { }
        private System.Void Close() { }
        private System.Xml.ReadState get_ReadState() { }
        private System.Void Skip() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.Void ResolveEntity() { }
        private System.Boolean ReadAttributeValue() { }
        private System.Boolean System.Xml.IXmlLineInfo.HasLineInfo() { }
        private System.Int32 System.Xml.IXmlLineInfo.get_LineNumber() { }
        private System.Int32 System.Xml.IXmlLineInfo.get_LinePosition() { }
        private System.Void SetToReplayMode() { }
        private System.Xml.XmlReader GetCoreReader() { }
        private System.Xml.IXmlLineInfo GetLineInfo() { }
        private System.Void ClearAttributesInfo() { }
        private System.Xml.ValidatingReaderNodeData AddAttribute(System.Int32 attIndex) { }
        private System.Xml.ValidatingReaderNodeData AddContent(System.Xml.XmlNodeType nodeType) { }
        private System.Void RecordAttributes() { }
        private System.Int32 GetAttributeIndexWithoutPrefix(System.String name) { }
        private System.Int32 GetAttributeIndexWithPrefix(System.String name) { }
        private System.Xml.ValidatingReaderNodeData CreateDummyTextNode(System.String attributeValue, System.Int32 depth) { }

    }

    // TypeToken: 0x2000088
    public class CachingEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Xml.XsdCachingReader cachingReader) { }

    }

    // TypeToken: 0x2000089
    public class AttributePSVIInfo
    {
        // Fields
        private System.String localName;        // 0x10
        private System.String namespaceUri;        // 0x18
        private System.Object typedAttributeValue;        // 0x20
        private System.Xml.Schema.XmlSchemaInfo attributeSchemaInfo;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x200008A
    public class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver
    {
        // Fields
        private System.Xml.XmlReader coreReader;        // 0x10
        private System.Xml.IXmlNamespaceResolver coreReaderNSResolver;        // 0x18
        private System.Xml.IXmlNamespaceResolver thisNSResolver;        // 0x20
        private System.Xml.Schema.XmlSchemaValidator validator;        // 0x28
        private System.Xml.XmlResolver xmlResolver;        // 0x30
        private System.Xml.Schema.ValidationEventHandler validationEvent;        // 0x38
        private System.Xml.XsdValidatingReader.ValidatingReaderState validationState;        // 0x40
        private System.Xml.Schema.XmlValueGetter valueGetter;        // 0x48
        private System.Xml.XmlNamespaceManager nsManager;        // 0x50
        private System.Boolean manageNamespaces;        // 0x58
        private System.Boolean processInlineSchema;        // 0x59
        private System.Boolean replayCache;        // 0x5A
        private System.Xml.ValidatingReaderNodeData cachedNode;        // 0x60
        private System.Xml.AttributePSVIInfo attributePSVI;        // 0x68
        private System.Int32 attributeCount;        // 0x70
        private System.Int32 coreReaderAttributeCount;        // 0x74
        private System.Int32 currentAttrIndex;        // 0x78
        private System.Xml.AttributePSVIInfo[] attributePSVINodes;        // 0x80
        private System.Collections.ArrayList defaultAttributes;        // 0x88
        private System.Xml.Schema.Parser inlineSchemaParser;        // 0x90
        private System.Object atomicValue;        // 0x98
        private System.Xml.Schema.XmlSchemaInfo xmlSchemaInfo;        // 0xA0
        private System.String originalAtomicValueString;        // 0xA8
        private System.Xml.XmlNameTable coreReaderNameTable;        // 0xB0
        private System.Xml.XsdCachingReader cachingReader;        // 0xB8
        private System.Xml.ValidatingReaderNodeData textNode;        // 0xC0
        private System.String NsXmlNs;        // 0xC8
        private System.String NsXs;        // 0xD0
        private System.String NsXsi;        // 0xD8
        private System.String XsiType;        // 0xE0
        private System.String XsiNil;        // 0xE8
        private System.String XsdSchema;        // 0xF0
        private System.String XsiSchemaLocation;        // 0xF8
        private System.String XsiNoNamespaceSchemaLocation;        // 0x100
        private System.Xml.XmlCharType xmlCharType;        // 0x108
        private System.Xml.IXmlLineInfo lineInfo;        // 0x110
        private System.Xml.ReadContentAsBinaryHelper readBinaryHelper;        // 0x118
        private System.Xml.XsdValidatingReader.ValidatingReaderState savedState;        // 0x120
        private static System.Type TypeOfString;        // 0x0

        // Methods
        private System.Void .ctor(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings, System.Xml.Schema.XmlSchemaObject partialValidationType) { }
        private System.Void .ctor(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings) { }
        private System.Void Init() { }
        private System.Void SetupValidator(System.Xml.XmlReaderSettings readerSettings, System.Xml.XmlReader reader, System.Xml.Schema.XmlSchemaObject partialValidationType) { }
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
        private System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo() { }
        private System.Type get_ValueType() { }
        private System.String ReadContentAsString() { }
        private System.Int32 get_AttributeCount() { }
        private System.String GetAttribute(System.String name) { }
        private System.String GetAttribute(System.String name, System.String namespaceURI) { }
        private System.String GetAttribute(System.Int32 i) { }
        private System.Boolean MoveToAttribute(System.String name) { }
        private System.Void MoveToAttribute(System.Int32 i) { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }
        private System.Boolean MoveToElement() { }
        private System.Boolean Read() { }
        private System.Boolean get_EOF() { }
        private System.Void Close() { }
        private System.Xml.ReadState get_ReadState() { }
        private System.Void Skip() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.Void ResolveEntity() { }
        private System.Boolean ReadAttributeValue() { }
        private System.Boolean System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }
        private System.Boolean System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }
        private System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }
        private System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }
        private System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }
        private System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }
        private System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }
        private System.Boolean HasLineInfo() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }
        private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName) { }
        private System.Object GetStringValue() { }
        private System.Xml.Schema.XmlSchemaType get_ElementXmlType() { }
        private System.Xml.Schema.XmlSchemaType get_AttributeXmlType() { }
        private System.Xml.Schema.XmlSchemaInfo get_AttributeSchemaInfo() { }
        private System.Void ProcessReaderEvent() { }
        private System.Void ProcessElementEvent() { }
        private System.Void ProcessEndElementEvent() { }
        private System.Void ValidateAttributes() { }
        private System.Void ClearAttributesInfo() { }
        private System.Xml.AttributePSVIInfo GetAttributePSVI(System.String name) { }
        private System.Xml.AttributePSVIInfo GetAttributePSVI(System.String localName, System.String ns) { }
        private System.Xml.ValidatingReaderNodeData GetDefaultAttribute(System.String name, System.Boolean updatePosition) { }
        private System.Xml.ValidatingReaderNodeData GetDefaultAttribute(System.String attrLocalName, System.String ns, System.Boolean updatePosition) { }
        private System.Xml.AttributePSVIInfo AddAttributePSVI(System.Int32 attIndex) { }
        private System.Boolean IsXSDRoot(System.String localName, System.String ns) { }
        private System.Void ProcessInlineSchema() { }
        private System.Object InternalReadContentAsObject() { }
        private System.Object InternalReadContentAsObject(System.Boolean unwrapTypedValue) { }
        private System.Object InternalReadContentAsObject(System.Boolean unwrapTypedValue, System.String& originalStringValue) { }
        private System.Object ReadTillEndElement() { }
        private System.Void SwitchReader() { }
        private System.Void ReadAheadForMemberType() { }
        private System.Void GetIsDefault() { }
        private System.Void GetMemberType() { }
        private System.Object ReturnBoxedValue(System.Object typedValue, System.Xml.Schema.XmlSchemaType xmlType, System.Boolean unWrap) { }
        private System.Xml.XsdCachingReader GetCachingReader() { }
        private System.Xml.ValidatingReaderNodeData CreateDummyTextNode(System.String attributeValue, System.Int32 depth) { }
        private System.Void CachingCallBack(System.Xml.XsdCachingReader cachingReader) { }
        private System.String GetOriginalAtomicValueStringOfElement() { }

    }

    // TypeToken: 0x200008C
    public class DocumentXPathNavigator : XPathNavigator, IHasXmlNode
    {
        // Fields
        private System.Xml.XmlDocument document;        // 0x10
        private System.Xml.XmlNode source;        // 0x18
        private System.Int32 attributeIndex;        // 0x20
        private System.Xml.XmlElement namespaceParent;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XmlDocument document, System.Xml.XmlNode node) { }
        private System.Void .ctor(System.Xml.DocumentXPathNavigator other) { }
        private System.Xml.XPath.XPathNavigator Clone() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Xml.XPath.XPathNodeType get_NodeType() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Name() { }
        private System.String get_Prefix() { }
        private System.String get_Value() { }
        private System.String get_ValueDocument() { }
        private System.String get_ValueText() { }
        private System.String get_BaseURI() { }
        private System.String get_XmlLang() { }
        private System.Object get_UnderlyingObject() { }
        private System.Boolean MoveToAttribute(System.String localName, System.String namespaceURI) { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }
        private System.Boolean MoveToNamespace(System.String name) { }
        private System.Boolean MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope scope) { }
        private System.Boolean MoveToFirstNamespaceLocal(System.Xml.XmlAttributeCollection attributes, System.Int32& index) { }
        private System.Boolean MoveToFirstNamespaceGlobal(System.Xml.XmlAttributeCollection& attributes, System.Int32& index) { }
        private System.Boolean MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope scope) { }
        private System.Boolean MoveToNextNamespaceLocal(System.Xml.XmlAttributeCollection attributes, System.Int32& index) { }
        private System.Boolean MoveToNextNamespaceGlobal(System.Xml.XmlAttributeCollection& attributes, System.Int32& index) { }
        private System.Boolean PathHasDuplicateNamespace(System.Xml.XmlElement top, System.Xml.XmlElement bottom, System.String localName) { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.Boolean MoveToNext() { }
        private System.Boolean MoveToFirstChild() { }
        private System.Boolean MoveToParent() { }
        private System.Void MoveToRoot() { }
        private System.Boolean MoveTo(System.Xml.XPath.XPathNavigator other) { }
        private System.Boolean MoveToId(System.String id) { }
        private System.Boolean MoveToChild(System.String localName, System.String namespaceUri) { }
        private System.Boolean MoveToChild(System.Xml.XPath.XPathNodeType type) { }
        private System.Boolean MoveToFollowing(System.String localName, System.String namespaceUri, System.Xml.XPath.XPathNavigator end) { }
        private System.Boolean MoveToFollowing(System.Xml.XPath.XPathNodeType type, System.Xml.XPath.XPathNavigator end) { }
        private System.Boolean MoveToNext(System.String localName, System.String namespaceUri) { }
        private System.Boolean MoveToNext(System.Xml.XPath.XPathNodeType type) { }
        private System.Boolean IsSamePosition(System.Xml.XPath.XPathNavigator other) { }
        private System.Boolean IsDescendant(System.Xml.XPath.XPathNavigator other) { }
        private System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo() { }
        private System.Xml.XmlNode OwnerNode(System.Xml.XmlNode node) { }
        private System.Int32 GetDepth(System.Xml.XmlNode node) { }
        private System.Xml.XmlNodeOrder Compare(System.Xml.XmlNode node1, System.Xml.XmlNode node2) { }
        private System.Xml.XmlNodeOrder ComparePosition(System.Xml.XPath.XPathNavigator other) { }
        private System.Xml.XmlNode System.Xml.IHasXmlNode.GetNode() { }
        private System.Xml.XPath.XPathNodeIterator SelectDescendants(System.String localName, System.String namespaceURI, System.Boolean matchSelf) { }
        private System.Xml.XPath.XPathNodeIterator SelectDescendants(System.Xml.XPath.XPathNodeType nt, System.Boolean includeSelf) { }
        private System.Void ResetPosition(System.Xml.XmlNode node) { }
        private System.Boolean ResetAttributePosition(System.Xml.XmlAttribute attribute, System.Xml.XmlAttributeCollection attributes, System.Int32& index) { }
        private System.Boolean CheckAttributePosition(System.Xml.XmlAttribute attribute, System.Xml.XmlAttributeCollection& attributes, System.Int32 index) { }
        private System.Void CalibrateText() { }
        private System.Xml.XmlNode ParentNode(System.Xml.XmlNode node) { }
        private System.Xml.XmlNode ParentNodeTail(System.Xml.XmlNode parent) { }
        private System.Xml.XmlNode FirstChild(System.Xml.XmlNode node) { }
        private System.Xml.XmlNode FirstChildTail(System.Xml.XmlNode child) { }
        private System.Xml.XmlNode NextSibling(System.Xml.XmlNode node) { }
        private System.Xml.XmlNode NextSiblingTail(System.Xml.XmlNode node, System.Xml.XmlNode sibling) { }
        private System.Xml.XmlNode PreviousText(System.Xml.XmlNode node) { }
        private System.Xml.XmlNode PreviousTextTail(System.Xml.XmlNode node, System.Xml.XmlNode text) { }
        private System.Boolean IsDescendant(System.Xml.XmlNode top, System.Xml.XmlNode bottom) { }
        private System.Boolean IsValidChild(System.Xml.XmlNode parent, System.Xml.XmlNode child) { }
        private System.Xml.XmlNode TextEnd(System.Xml.XmlNode node) { }

    }

    // TypeToken: 0x200008D
    public class DocumentXPathNodeIterator_Empty : XPathNodeIterator
    {
        // Fields
        private System.Xml.XPath.XPathNavigator nav;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.DocumentXPathNavigator nav) { }
        private System.Void .ctor(System.Xml.DocumentXPathNodeIterator_Empty other) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean MoveNext() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Int32 get_Count() { }

    }

    // TypeToken: 0x200008E
    public class DocumentXPathNodeIterator_ElemDescendants : XPathNodeIterator
    {
        // Fields
        private System.Xml.DocumentXPathNavigator nav;        // 0x18
        private System.Int32 level;        // 0x20
        private System.Int32 position;        // 0x24

        // Methods
        private System.Void .ctor(System.Xml.DocumentXPathNavigator nav) { }
        private System.Void .ctor(System.Xml.DocumentXPathNodeIterator_ElemDescendants other) { }
        private System.Boolean Match(System.Xml.XmlNode node) { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Void SetPosition(System.Int32 pos) { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x200008F
    public class DocumentXPathNodeIterator_AllElemChildren : DocumentXPathNodeIterator_ElemDescendants
    {
        // Methods
        private System.Void .ctor(System.Xml.DocumentXPathNavigator nav) { }
        private System.Void .ctor(System.Xml.DocumentXPathNodeIterator_AllElemChildren other) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean Match(System.Xml.XmlNode node) { }

    }

    // TypeToken: 0x2000090
    public class DocumentXPathNodeIterator_AllElemChildren_AndSelf : DocumentXPathNodeIterator_AllElemChildren
    {
        // Methods
        private System.Void .ctor(System.Xml.DocumentXPathNavigator nav) { }
        private System.Void .ctor(System.Xml.DocumentXPathNodeIterator_AllElemChildren_AndSelf other) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x2000091
    public class DocumentXPathNodeIterator_ElemChildren_NoLocalName : DocumentXPathNodeIterator_ElemDescendants
    {
        // Fields
        private System.String nsAtom;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.DocumentXPathNavigator nav, System.String nsAtom) { }
        private System.Void .ctor(System.Xml.DocumentXPathNodeIterator_ElemChildren_NoLocalName other) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean Match(System.Xml.XmlNode node) { }

    }

    // TypeToken: 0x2000092
    public class DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName : DocumentXPathNodeIterator_ElemChildren_NoLocalName
    {
        // Methods
        private System.Void .ctor(System.Xml.DocumentXPathNavigator nav, System.String nsAtom) { }
        private System.Void .ctor(System.Xml.DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName other) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x2000093
    public class DocumentXPathNodeIterator_ElemChildren : DocumentXPathNodeIterator_ElemDescendants
    {
        // Fields
        protected System.String localNameAtom;        // 0x28
        protected System.String nsAtom;        // 0x30

        // Methods
        private System.Void .ctor(System.Xml.DocumentXPathNavigator nav, System.String localNameAtom, System.String nsAtom) { }
        private System.Void .ctor(System.Xml.DocumentXPathNodeIterator_ElemChildren other) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean Match(System.Xml.XmlNode node) { }

    }

    // TypeToken: 0x2000094
    public class DocumentXPathNodeIterator_ElemChildren_AndSelf : DocumentXPathNodeIterator_ElemChildren
    {
        // Methods
        private System.Void .ctor(System.Xml.DocumentXPathNavigator nav, System.String localNameAtom, System.String nsAtom) { }
        private System.Void .ctor(System.Xml.DocumentXPathNodeIterator_ElemChildren_AndSelf other) { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x2000095
    public class DomNameTable
    {
        // Fields
        private System.Xml.XmlName[] entries;        // 0x10
        private System.Int32 count;        // 0x18
        private System.Int32 mask;        // 0x1C
        private System.Xml.XmlDocument ownerDocument;        // 0x20
        private System.Xml.XmlNameTable nameTable;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XmlDocument document) { }
        private System.Xml.XmlName GetName(System.String prefix, System.String localName, System.String ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo) { }
        private System.Xml.XmlName AddName(System.String prefix, System.String localName, System.String ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo) { }
        private System.Void Grow() { }

    }

    // TypeToken: 0x2000096
    public class XPathNodeList : XmlNodeList
    {
        // Fields
        private System.Collections.Generic.List<System.Xml.XmlNode> list;        // 0x10
        private System.Xml.XPath.XPathNodeIterator nodeIterator;        // 0x18
        private System.Boolean done;        // 0x20
        private static readonly System.Object[] nullparams;        // 0x0

        // Methods
        private System.Void .ctor(System.Xml.XPath.XPathNodeIterator nodeIterator) { }
        private System.Int32 get_Count() { }
        private System.Xml.XmlNode GetNode(System.Xml.XPath.XPathNavigator n) { }
        private System.Int32 ReadUntil(System.Int32 index) { }
        private System.Xml.XmlNode Item(System.Int32 index) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000097
    public class XmlNodeListEnumerator, IEnumerator
    {
        // Fields
        private System.Xml.XPathNodeList list;        // 0x10
        private System.Int32 index;        // 0x18
        private System.Boolean valid;        // 0x1C

        // Methods
        private System.Void .ctor(System.Xml.XPathNodeList list) { }
        private System.Void Reset() { }
        private System.Boolean MoveNext() { }
        private System.Object get_Current() { }

    }

    // TypeToken: 0x2000098
    public class XmlAttribute : XmlNode
    {
        // Fields
        private System.Xml.XmlName name;        // 0x18
        private System.Xml.XmlLinkedNode lastChild;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.XmlName name, System.Xml.XmlDocument doc) { }
        private System.Int32 get_LocalNameHash() { }
        private System.Void .ctor(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.XmlDocument doc) { }
        private System.Xml.XmlName get_XmlName() { }
        private System.Void set_XmlName(System.Xml.XmlName value) { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Xml.XmlNode get_ParentNode() { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Prefix() { }
        private System.Void set_Prefix(System.String value) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlDocument get_OwnerDocument() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo() { }
        private System.Void set_InnerText(System.String value) { }
        private System.Boolean PrepareOwnerElementInElementIdAttrMap() { }
        private System.Void ResetOwnerElementInElementIdAttrMap(System.String oldInnerText) { }
        private System.Boolean get_IsContainer() { }
        private System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc) { }
        private System.Xml.XmlLinkedNode get_LastNode() { }
        private System.Void set_LastNode(System.Xml.XmlLinkedNode value) { }
        private System.Boolean IsValidChildType(System.Xml.XmlNodeType type) { }
        private System.Boolean get_Specified() { }
        private System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild) { }
        private System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild) { }
        private System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild) { }
        private System.Xml.XmlElement get_OwnerElement() { }
        private System.Void set_InnerXml(System.String value) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.String get_BaseURI() { }
        private System.Void SetParent(System.Xml.XmlNode node) { }
        private System.Xml.XmlSpace get_XmlSpace() { }
        private System.String get_XmlLang() { }
        private System.Xml.XPath.XPathNodeType get_XPNodeType() { }
        private System.String get_XPLocalName() { }
        private System.Boolean get_IsNamespace() { }

    }

    // TypeToken: 0x2000099
    public class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable
    {
        // Methods
        private System.Void .ctor(System.Xml.XmlNode parent) { }
        private System.Xml.XmlAttribute get_ItemOf(System.Int32 i) { }
        private System.Xml.XmlAttribute get_ItemOf(System.String name) { }
        private System.Xml.XmlAttribute get_ItemOf(System.String localName, System.String namespaceURI) { }
        private System.Int32 FindNodeOffsetNS(System.Xml.XmlAttribute node) { }
        private System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node) { }
        private System.Xml.XmlAttribute Append(System.Xml.XmlAttribute node) { }
        private System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute node) { }
        private System.Xml.XmlAttribute RemoveAt(System.Int32 i) { }
        private System.Void RemoveAll() { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Int32 System.Collections.ICollection.get_Count() { }
        private System.Xml.XmlNode AddNode(System.Xml.XmlNode node) { }
        private System.Xml.XmlNode InsertNodeAt(System.Int32 i, System.Xml.XmlNode node) { }
        private System.Xml.XmlNode RemoveNodeAt(System.Int32 i) { }
        private System.Void Detach(System.Xml.XmlAttribute attr) { }
        private System.Void InsertParentIntoElementIdAttrMap(System.Xml.XmlAttribute attr) { }
        private System.Void RemoveParentFromElementIdAttrMap(System.Xml.XmlAttribute attr) { }
        private System.Int32 RemoveDuplicateAttribute(System.Xml.XmlAttribute attr) { }
        private System.Boolean PrepareParentInElementIdAttrMap(System.String attrPrefix, System.String attrLocalName) { }
        private System.Void ResetParentInElementIdAttrMap(System.String oldVal, System.String newVal) { }
        private System.Xml.XmlAttribute InternalAppendAttribute(System.Xml.XmlAttribute node) { }

    }

    // TypeToken: 0x200009A
    public class XmlCDataSection : XmlCharacterData
    {
        // Methods
        private System.Void .ctor(System.String data, System.Xml.XmlDocument doc) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode get_ParentNode() { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.Xml.XPath.XPathNodeType get_XPNodeType() { }
        private System.Boolean get_IsText() { }
        private System.Xml.XmlNode get_PreviousText() { }

    }

    // TypeToken: 0x200009B
    public class XmlCharacterData : XmlLinkedNode
    {
        // Fields
        private System.String data;        // 0x20

        // Methods
        private System.Void .ctor(System.String data, System.Xml.XmlDocument doc) { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.String get_InnerText() { }
        private System.Void set_InnerText(System.String value) { }
        private System.String get_Data() { }
        private System.Void set_Data(System.String value) { }
        private System.Boolean CheckOnData(System.String data) { }
        private System.Boolean DecideXPNodeTypeForTextNodes(System.Xml.XmlNode node, System.Xml.XPath.XPathNodeType& xnt) { }

    }

    // TypeToken: 0x200009C
    public class XmlChildEnumerator, IEnumerator
    {
        // Fields
        private System.Xml.XmlNode container;        // 0x10
        private System.Xml.XmlNode child;        // 0x18
        private System.Boolean isFirst;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.XmlNode container) { }
        private System.Boolean System.Collections.IEnumerator.MoveNext() { }
        private System.Boolean MoveNext() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Xml.XmlNode get_Current() { }

    }

    // TypeToken: 0x200009D
    public class XmlChildNodes : XmlNodeList
    {
        // Fields
        private System.Xml.XmlNode container;        // 0x10

        // Methods
        private System.Void .ctor(System.Xml.XmlNode container) { }
        private System.Xml.XmlNode Item(System.Int32 i) { }
        private System.Int32 get_Count() { }
        private System.Collections.IEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x200009E
    public class XmlComment : XmlCharacterData
    {
        // Methods
        private System.Void .ctor(System.String comment, System.Xml.XmlDocument doc) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.Xml.XPath.XPathNodeType get_XPNodeType() { }

    }

    // TypeToken: 0x200009F
    public class XmlDeclaration : XmlLinkedNode
    {
        // Fields
        private System.String version;        // 0x20
        private System.String encoding;        // 0x28
        private System.String standalone;        // 0x30

        // Methods
        private System.Void .ctor(System.String version, System.String encoding, System.String standalone, System.Xml.XmlDocument doc) { }
        private System.String get_Version() { }
        private System.Void set_Version(System.String value) { }
        private System.String get_Encoding() { }
        private System.Void set_Encoding(System.String value) { }
        private System.String get_Standalone() { }
        private System.Void set_Standalone(System.String value) { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.String get_InnerText() { }
        private System.Void set_InnerText(System.String value) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.Boolean IsValidXmlVersion(System.String ver) { }

    }

    // TypeToken: 0x20000A0
    public class XmlDocument : XmlNode
    {
        // Fields
        private System.Xml.XmlImplementation implementation;        // 0x18
        private System.Xml.DomNameTable domNameTable;        // 0x20
        private System.Xml.XmlLinkedNode lastChild;        // 0x28
        private System.Xml.XmlNamedNodeMap entities;        // 0x30
        private System.Collections.Hashtable htElementIdMap;        // 0x38
        private System.Collections.Hashtable htElementIDAttrDecl;        // 0x40
        private System.Xml.Schema.SchemaInfo schemaInfo;        // 0x48
        private System.Xml.Schema.XmlSchemaSet schemas;        // 0x50
        private System.Boolean reportValidity;        // 0x58
        private System.Boolean actualLoadingStatus;        // 0x59
        private System.Xml.XmlNodeChangedEventHandler onNodeInsertingDelegate;        // 0x60
        private System.Xml.XmlNodeChangedEventHandler onNodeInsertedDelegate;        // 0x68
        private System.Xml.XmlNodeChangedEventHandler onNodeRemovingDelegate;        // 0x70
        private System.Xml.XmlNodeChangedEventHandler onNodeRemovedDelegate;        // 0x78
        private System.Xml.XmlNodeChangedEventHandler onNodeChangingDelegate;        // 0x80
        private System.Xml.XmlNodeChangedEventHandler onNodeChangedDelegate;        // 0x88
        private System.Boolean fEntRefNodesPresent;        // 0x90
        private System.Boolean fCDataNodesPresent;        // 0x91
        private System.Boolean preserveWhitespace;        // 0x92
        private System.Boolean isLoading;        // 0x93
        private System.String strDocumentName;        // 0x98
        private System.String strDocumentFragmentName;        // 0xA0
        private System.String strCommentName;        // 0xA8
        private System.String strTextName;        // 0xB0
        private System.String strCDataSectionName;        // 0xB8
        private System.String strEntityName;        // 0xC0
        private System.String strID;        // 0xC8
        private System.String strXmlns;        // 0xD0
        private System.String strXml;        // 0xD8
        private System.String strSpace;        // 0xE0
        private System.String strLang;        // 0xE8
        private System.String strEmpty;        // 0xF0
        private System.String strNonSignificantWhitespaceName;        // 0xF8
        private System.String strSignificantWhitespaceName;        // 0x100
        private System.String strReservedXmlns;        // 0x108
        private System.String strReservedXml;        // 0x110
        private System.String baseURI;        // 0x118
        private System.Xml.XmlResolver resolver;        // 0x120
        private System.Boolean bSetResolver;        // 0x128
        private System.Object objLock;        // 0x130
        private System.Xml.XmlAttribute namespaceXml;        // 0x138
        private static System.Xml.EmptyEnumerator EmptyEnumerator;        // 0x0
        private static System.Xml.Schema.IXmlSchemaInfo NotKnownSchemaInfo;        // 0x8
        private static System.Xml.Schema.IXmlSchemaInfo ValidSchemaInfo;        // 0x10
        private static System.Xml.Schema.IXmlSchemaInfo InvalidSchemaInfo;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.XmlNameTable nt) { }
        private System.Void .ctor(System.Xml.XmlImplementation imp) { }
        private System.Xml.Schema.SchemaInfo get_DtdSchemaInfo() { }
        private System.Void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value) { }
        private System.Void CheckName(System.String name) { }
        private System.Xml.XmlName AddXmlName(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo) { }
        private System.Xml.XmlName GetXmlName(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo) { }
        private System.Xml.XmlName AddAttrXmlName(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo) { }
        private System.Boolean AddIdInfo(System.Xml.XmlName eleName, System.Xml.XmlName attrName) { }
        private System.Xml.XmlName GetIDInfoByElement_(System.Xml.XmlName eleName) { }
        private System.Xml.XmlName GetIDInfoByElement(System.Xml.XmlName eleName) { }
        private System.WeakReference GetElement(System.Collections.ArrayList elementList, System.Xml.XmlElement elem) { }
        private System.Void AddElementWithId(System.String id, System.Xml.XmlElement elem) { }
        private System.Void RemoveElementWithId(System.String id, System.Xml.XmlElement elem) { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode get_ParentNode() { }
        private System.Xml.XmlDocumentType get_DocumentType() { }
        private System.Xml.XmlDeclaration get_Declaration() { }
        private System.Xml.XmlImplementation get_Implementation() { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.Xml.XmlElement get_DocumentElement() { }
        private System.Boolean get_IsContainer() { }
        private System.Xml.XmlLinkedNode get_LastNode() { }
        private System.Void set_LastNode(System.Xml.XmlLinkedNode value) { }
        private System.Xml.XmlDocument get_OwnerDocument() { }
        private System.Void set_Schemas(System.Xml.Schema.XmlSchemaSet value) { }
        private System.Boolean get_CanReportValidity() { }
        private System.Boolean get_HasSetResolver() { }
        private System.Xml.XmlResolver GetResolver() { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Boolean IsValidChildType(System.Xml.XmlNodeType type) { }
        private System.Boolean HasNodeTypeInPrevSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode) { }
        private System.Boolean HasNodeTypeInNextSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode) { }
        private System.Boolean CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Boolean CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Xml.XmlAttribute CreateAttribute(System.String name) { }
        private System.Void SetDefaultNamespace(System.String prefix, System.String localName, System.String& namespaceURI) { }
        private System.Xml.XmlCDataSection CreateCDataSection(System.String data) { }
        private System.Xml.XmlComment CreateComment(System.String data) { }
        private System.Xml.XmlDocumentType CreateDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset) { }
        private System.Xml.XmlDocumentFragment CreateDocumentFragment() { }
        private System.Xml.XmlElement CreateElement(System.String name) { }
        private System.Void AddDefaultAttributes(System.Xml.XmlElement elem) { }
        private System.Xml.Schema.SchemaElementDecl GetSchemaElementDecl(System.Xml.XmlElement elem) { }
        private System.Xml.XmlAttribute PrepareDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef, System.String attrPrefix, System.String attrLocalname, System.String attrNamespaceURI) { }
        private System.Xml.XmlEntityReference CreateEntityReference(System.String name) { }
        private System.Xml.XmlProcessingInstruction CreateProcessingInstruction(System.String target, System.String data) { }
        private System.Xml.XmlDeclaration CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone) { }
        private System.Xml.XmlText CreateTextNode(System.String text) { }
        private System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(System.String text) { }
        private System.Xml.XPath.XPathNavigator CreateNavigator() { }
        private System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlNode node) { }
        private System.Boolean IsTextNode(System.Xml.XmlNodeType nt) { }
        private System.Xml.XmlNode NormalizeText(System.Xml.XmlNode n) { }
        private System.Xml.XmlWhitespace CreateWhitespace(System.String text) { }
        private System.Xml.XmlAttribute CreateAttribute(System.String qualifiedName, System.String namespaceURI) { }
        private System.Xml.XmlElement CreateElement(System.String qualifiedName, System.String namespaceURI) { }
        private System.Xml.XmlElement GetElementById(System.String elementId) { }
        private System.Xml.XmlNode ImportNodeInternal(System.Xml.XmlNode node, System.Boolean deep) { }
        private System.Void ImportAttributes(System.Xml.XmlNode fromElem, System.Xml.XmlNode toElem) { }
        private System.Void ImportChildren(System.Xml.XmlNode fromNode, System.Xml.XmlNode toNode, System.Boolean deep) { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Xml.XmlAttribute CreateAttribute(System.String prefix, System.String localName, System.String namespaceURI) { }
        private System.Xml.XmlAttribute CreateDefaultAttribute(System.String prefix, System.String localName, System.String namespaceURI) { }
        private System.Xml.XmlElement CreateElement(System.String prefix, System.String localName, System.String namespaceURI) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Xml.XmlNamedNodeMap get_Entities() { }
        private System.Void set_Entities(System.Xml.XmlNamedNodeMap value) { }
        private System.Boolean get_IsLoading() { }
        private System.Void set_IsLoading(System.Boolean value) { }
        private System.Boolean get_ActualLoadingStatus() { }
        private System.Xml.XmlNode ReadNode(System.Xml.XmlReader reader) { }
        private System.Xml.XmlTextReader SetupReader(System.Xml.XmlTextReader tr) { }
        private System.Void Load(System.Xml.XmlReader reader) { }
        private System.Void LoadXml(System.String xml) { }
        private System.Void set_InnerText(System.String value) { }
        private System.Void set_InnerXml(System.String value) { }
        private System.Void Save(System.Xml.XmlWriter w) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter xw) { }
        private System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, System.String oldValue, System.String newValue, System.Xml.XmlNodeChangedAction action) { }
        private System.Xml.XmlNodeChangedEventArgs GetInsertEventArgsForLoad(System.Xml.XmlNode node, System.Xml.XmlNode newParent) { }
        private System.Void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args) { }
        private System.Void AfterEvent(System.Xml.XmlNodeChangedEventArgs args) { }
        private System.Xml.XmlAttribute GetDefaultAttribute(System.Xml.XmlElement elem, System.String attrPrefix, System.String attrLocalname, System.String attrNamespaceURI) { }
        private System.String get_Version() { }
        private System.String get_Encoding() { }
        private System.String get_Standalone() { }
        private System.Xml.XmlEntity GetEntityNode(System.String name) { }
        private System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo() { }
        private System.String get_BaseURI() { }
        private System.Void SetBaseURI(System.String inBaseURI) { }
        private System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc) { }
        private System.Xml.XPath.XPathNodeType get_XPNodeType() { }
        private System.Boolean get_HasEntityReferences() { }
        private System.Xml.XmlAttribute get_NamespaceXml() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A1
    public class XmlDocumentFragment : XmlNode
    {
        // Fields
        private System.Xml.XmlLinkedNode lastChild;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.XmlDocument ownerDocument) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode get_ParentNode() { }
        private System.Xml.XmlDocument get_OwnerDocument() { }
        private System.Void set_InnerXml(System.String value) { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Boolean get_IsContainer() { }
        private System.Xml.XmlLinkedNode get_LastNode() { }
        private System.Void set_LastNode(System.Xml.XmlLinkedNode value) { }
        private System.Boolean IsValidChildType(System.Xml.XmlNodeType type) { }
        private System.Boolean CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Boolean CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.Xml.XPath.XPathNodeType get_XPNodeType() { }

    }

    // TypeToken: 0x20000A2
    public class XmlDocumentType : XmlLinkedNode
    {
        // Fields
        private System.String name;        // 0x20
        private System.String publicId;        // 0x28
        private System.String systemId;        // 0x30
        private System.String internalSubset;        // 0x38
        private System.Boolean namespaces;        // 0x40
        private System.Xml.XmlNamedNodeMap entities;        // 0x48
        private System.Xml.XmlNamedNodeMap notations;        // 0x50
        private System.Xml.Schema.SchemaInfo schemaInfo;        // 0x58

        // Methods
        private System.Void .ctor(System.String name, System.String publicId, System.String systemId, System.String internalSubset, System.Xml.XmlDocument doc) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Xml.XmlNamedNodeMap get_Entities() { }
        private System.Xml.XmlNamedNodeMap get_Notations() { }
        private System.String get_PublicId() { }
        private System.String get_SystemId() { }
        private System.String get_InternalSubset() { }
        private System.Boolean get_ParseWithNamespaces() { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.Xml.Schema.SchemaInfo get_DtdSchemaInfo() { }
        private System.Void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value) { }

    }

    // TypeToken: 0x20000A3
    public class XmlElement : XmlLinkedNode
    {
        // Fields
        private System.Xml.XmlName name;        // 0x20
        private System.Xml.XmlAttributeCollection attributes;        // 0x28
        private System.Xml.XmlLinkedNode lastChild;        // 0x30

        // Methods
        private System.Void .ctor(System.Xml.XmlName name, System.Boolean empty, System.Xml.XmlDocument doc) { }
        private System.Void .ctor(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.XmlDocument doc) { }
        private System.Xml.XmlName get_XmlName() { }
        private System.Void set_XmlName(System.Xml.XmlName value) { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Prefix() { }
        private System.Void set_Prefix(System.String value) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode get_ParentNode() { }
        private System.Xml.XmlDocument get_OwnerDocument() { }
        private System.Boolean get_IsContainer() { }
        private System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc) { }
        private System.Boolean get_IsEmpty() { }
        private System.Void set_IsEmpty(System.Boolean value) { }
        private System.Xml.XmlLinkedNode get_LastNode() { }
        private System.Void set_LastNode(System.Xml.XmlLinkedNode value) { }
        private System.Boolean IsValidChildType(System.Xml.XmlNodeType type) { }
        private System.Xml.XmlAttributeCollection get_Attributes() { }
        private System.Boolean get_HasAttributes() { }
        private System.String GetAttribute(System.String name) { }
        private System.Void SetAttribute(System.String name, System.String value) { }
        private System.Xml.XmlAttribute GetAttributeNode(System.String name) { }
        private System.Xml.XmlAttribute SetAttributeNode(System.Xml.XmlAttribute newAttr) { }
        private System.String GetAttribute(System.String localName, System.String namespaceURI) { }
        private System.String SetAttribute(System.String localName, System.String namespaceURI, System.String value) { }
        private System.Xml.XmlAttribute GetAttributeNode(System.String localName, System.String namespaceURI) { }
        private System.Xml.XmlAttribute SetAttributeNode(System.String localName, System.String namespaceURI) { }
        private System.Boolean HasAttribute(System.String name) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteElementTo(System.Xml.XmlWriter writer, System.Xml.XmlElement e) { }
        private System.Void WriteStartElement(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.Void RemoveAllAttributes() { }
        private System.Void RemoveAll() { }
        private System.Void RemoveAllChildren() { }
        private System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo() { }
        private System.Void set_InnerXml(System.String value) { }
        private System.String get_InnerText() { }
        private System.Void set_InnerText(System.String value) { }
        private System.Xml.XmlNode get_NextSibling() { }
        private System.Void SetParent(System.Xml.XmlNode node) { }
        private System.Xml.XPath.XPathNodeType get_XPNodeType() { }
        private System.String get_XPLocalName() { }

    }

    // TypeToken: 0x20000A4
    public class XmlEntity : XmlNode
    {
        // Fields
        private System.String publicId;        // 0x18
        private System.String systemId;        // 0x20
        private System.String notationName;        // 0x28
        private System.String name;        // 0x30
        private System.String unparsedReplacementStr;        // 0x38
        private System.String baseURI;        // 0x40
        private System.Xml.XmlLinkedNode lastChild;        // 0x48
        private System.Boolean childrenFoliating;        // 0x50

        // Methods
        private System.Void .ctor(System.String name, System.String strdata, System.String publicId, System.String systemId, System.String notationName, System.Xml.XmlDocument doc) { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Boolean get_IsReadOnly() { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.String get_InnerText() { }
        private System.Void set_InnerText(System.String value) { }
        private System.Boolean get_IsContainer() { }
        private System.Xml.XmlLinkedNode get_LastNode() { }
        private System.Void set_LastNode(System.Xml.XmlLinkedNode value) { }
        private System.Boolean IsValidChildType(System.Xml.XmlNodeType type) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_SystemId() { }
        private System.Void set_InnerXml(System.String value) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.String get_BaseURI() { }
        private System.Void SetBaseURI(System.String inBaseURI) { }

    }

    // TypeToken: 0x20000A5
    public class XmlEntityReference : XmlLinkedNode
    {
        // Fields
        private System.String name;        // 0x20
        private System.Xml.XmlLinkedNode lastChild;        // 0x28

        // Methods
        private System.Void .ctor(System.String name, System.Xml.XmlDocument doc) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean get_IsContainer() { }
        private System.Void SetParent(System.Xml.XmlNode node) { }
        private System.Void SetParentForLoad(System.Xml.XmlNode node) { }
        private System.Xml.XmlLinkedNode get_LastNode() { }
        private System.Void set_LastNode(System.Xml.XmlLinkedNode value) { }
        private System.Boolean IsValidChildType(System.Xml.XmlNodeType type) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.String get_BaseURI() { }
        private System.String ConstructBaseURI(System.String baseURI, System.String systemId) { }
        private System.String get_ChildBaseURI() { }

    }

    // TypeToken: 0x20000A6
    public struct XmlNodeChangedAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlNodeChangedAction Insert;        // 0x0
        public static System.Xml.XmlNodeChangedAction Remove;        // 0x0
        public static System.Xml.XmlNodeChangedAction Change;        // 0x0

    }

    // TypeToken: 0x20000A7
    public class XmlImplementation
    {
        // Fields
        private System.Xml.XmlNameTable nameTable;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.XmlNameTable nt) { }
        private System.Xml.XmlDocument CreateDocument() { }
        private System.Xml.XmlNameTable get_NameTable() { }

    }

    // TypeToken: 0x20000A8
    public class XmlLinkedNode : XmlNode
    {
        // Fields
        private System.Xml.XmlLinkedNode next;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.XmlDocument doc) { }
        private System.Xml.XmlNode get_PreviousSibling() { }
        private System.Xml.XmlNode get_NextSibling() { }

    }

    // TypeToken: 0x20000A9
    public class XmlLoader
    {
        // Fields
        private System.Xml.XmlDocument doc;        // 0x10
        private System.Xml.XmlReader reader;        // 0x18
        private System.Boolean preserveWhitespace;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void Load(System.Xml.XmlDocument doc, System.Xml.XmlReader reader, System.Boolean preserveWhitespace) { }
        private System.Void LoadDocSequence(System.Xml.XmlDocument parentDoc) { }
        private System.Xml.XmlNode ReadCurrentNode(System.Xml.XmlDocument doc, System.Xml.XmlReader reader) { }
        private System.Xml.XmlNode LoadNode(System.Boolean skipOverWhitespace) { }
        private System.Xml.XmlAttribute LoadAttributeNode() { }
        private System.Xml.XmlAttribute LoadDefaultAttribute() { }
        private System.Void LoadAttributeValue(System.Xml.XmlNode parent, System.Boolean direct) { }
        private System.Xml.XmlEntityReference LoadEntityReferenceNode(System.Boolean direct) { }
        private System.Xml.XmlDeclaration LoadDeclarationNode() { }
        private System.Xml.XmlDocumentType LoadDocumentTypeNode() { }
        private System.Xml.XmlNode LoadNodeDirect() { }
        private System.Xml.XmlAttribute LoadAttributeNodeDirect() { }
        private System.Void ParseDocumentType(System.Xml.XmlDocumentType dtNode) { }
        private System.Void ParseDocumentType(System.Xml.XmlDocumentType dtNode, System.Boolean bUseResolver, System.Xml.XmlResolver resolver) { }
        private System.Void LoadDocumentType(System.Xml.IDtdInfo dtdInfo, System.Xml.XmlDocumentType dtNode) { }
        private System.Xml.XmlParserContext GetContext(System.Xml.XmlNode node) { }
        private System.Xml.XmlNamespaceManager ParsePartialContent(System.Xml.XmlNode parentNode, System.String innerxmltext, System.Xml.XmlNodeType nt) { }
        private System.Void LoadInnerXmlElement(System.Xml.XmlElement node, System.String innerxmltext) { }
        private System.Void LoadInnerXmlAttribute(System.Xml.XmlAttribute node, System.String innerxmltext) { }
        private System.Void RemoveDuplicateNamespace(System.Xml.XmlElement elem, System.Xml.XmlNamespaceManager mgr, System.Boolean fCheckElemAttrs) { }
        private System.String EntitizeName(System.String name) { }
        private System.Void ExpandEntity(System.Xml.XmlEntity ent) { }
        private System.Void ExpandEntityReference(System.Xml.XmlEntityReference eref) { }
        private System.Xml.XmlReader CreateInnerXmlReader(System.String xmlFragment, System.Xml.XmlNodeType nt, System.Xml.XmlParserContext context, System.Xml.XmlDocument doc) { }
        private System.Void ParseXmlDeclarationValue(System.String strValue, System.String& version, System.String& encoding, System.String& standalone) { }
        private System.Exception UnexpectedNodeType(System.Xml.XmlNodeType nodetype) { }

    }

    // TypeToken: 0x20000AA
    public class XmlName, IXmlSchemaInfo
    {
        // Fields
        private System.String prefix;        // 0x10
        private System.String localName;        // 0x18
        private System.String ns;        // 0x20
        private System.String name;        // 0x28
        private System.Int32 hashCode;        // 0x30
        private System.Xml.XmlDocument ownerDoc;        // 0x38
        private System.Xml.XmlName next;        // 0x40

        // Methods
        private System.Xml.XmlName Create(System.String prefix, System.String localName, System.String ns, System.Int32 hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo) { }
        private System.Void .ctor(System.String prefix, System.String localName, System.String ns, System.Int32 hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next) { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Prefix() { }
        private System.Int32 get_HashCode() { }
        private System.Xml.XmlDocument get_OwnerDocument() { }
        private System.String get_Name() { }
        private System.Xml.Schema.XmlSchemaValidity get_Validity() { }
        private System.Boolean get_IsDefault() { }
        private System.Boolean get_IsNil() { }
        private System.Xml.Schema.XmlSchemaSimpleType get_MemberType() { }
        private System.Xml.Schema.XmlSchemaType get_SchemaType() { }
        private System.Xml.Schema.XmlSchemaElement get_SchemaElement() { }
        private System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute() { }
        private System.Boolean Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo) { }
        private System.Int32 GetHashCode(System.String name) { }

    }

    // TypeToken: 0x20000AB
    public class XmlNameEx : XmlName
    {
        // Fields
        private System.Byte flags;        // 0x48
        private System.Xml.Schema.XmlSchemaSimpleType memberType;        // 0x50
        private System.Xml.Schema.XmlSchemaType schemaType;        // 0x58
        private System.Object decl;        // 0x60

        // Methods
        private System.Void .ctor(System.String prefix, System.String localName, System.String ns, System.Int32 hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo) { }
        private System.Xml.Schema.XmlSchemaValidity get_Validity() { }
        private System.Boolean get_IsDefault() { }
        private System.Boolean get_IsNil() { }
        private System.Xml.Schema.XmlSchemaSimpleType get_MemberType() { }
        private System.Xml.Schema.XmlSchemaType get_SchemaType() { }
        private System.Xml.Schema.XmlSchemaElement get_SchemaElement() { }
        private System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute() { }
        private System.Void SetValidity(System.Xml.Schema.XmlSchemaValidity value) { }
        private System.Void SetIsDefault(System.Boolean value) { }
        private System.Void SetIsNil(System.Boolean value) { }
        private System.Boolean Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo) { }

    }

    // TypeToken: 0x20000AC
    public class XmlNamedNodeMap, IEnumerable
    {
        // Fields
        private System.Xml.XmlNode parent;        // 0x10
        private System.Xml.XmlNamedNodeMap.SmallXmlNodeList nodes;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.XmlNode parent) { }
        private System.Xml.XmlNode GetNamedItem(System.String name) { }
        private System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node) { }
        private System.Int32 get_Count() { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Int32 FindNodeOffset(System.String name) { }
        private System.Int32 FindNodeOffset(System.String localName, System.String namespaceURI) { }
        private System.Xml.XmlNode AddNode(System.Xml.XmlNode node) { }
        private System.Xml.XmlNode AddNodeForLoad(System.Xml.XmlNode node, System.Xml.XmlDocument doc) { }
        private System.Xml.XmlNode RemoveNodeAt(System.Int32 i) { }
        private System.Xml.XmlNode ReplaceNodeAt(System.Int32 i, System.Xml.XmlNode node) { }
        private System.Xml.XmlNode InsertNodeAt(System.Int32 i, System.Xml.XmlNode node) { }

    }

    // TypeToken: 0x20000AF
    public class XmlNode, ICloneable, IEnumerable, IXPathNavigable
    {
        // Fields
        private System.Xml.XmlNode parentNode;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.XmlDocument doc) { }
        private System.Xml.XPath.XPathNavigator CreateNavigator() { }
        private System.Xml.XmlNode SelectSingleNode(System.String xpath) { }
        private System.Xml.XmlNodeList SelectNodes(System.String xpath) { }
        private System.String get_Name() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode get_ParentNode() { }
        private System.Xml.XmlNodeList get_ChildNodes() { }
        private System.Xml.XmlNode get_PreviousSibling() { }
        private System.Xml.XmlNode get_NextSibling() { }
        private System.Xml.XmlAttributeCollection get_Attributes() { }
        private System.Xml.XmlDocument get_OwnerDocument() { }
        private System.Xml.XmlNode get_FirstChild() { }
        private System.Xml.XmlNode get_LastChild() { }
        private System.Boolean get_IsContainer() { }
        private System.Xml.XmlLinkedNode get_LastNode() { }
        private System.Void set_LastNode(System.Xml.XmlLinkedNode value) { }
        private System.Boolean AncestorNode(System.Xml.XmlNode node) { }
        private System.Boolean IsConnected() { }
        private System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild) { }
        private System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild) { }
        private System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild) { }
        private System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc) { }
        private System.Boolean IsValidChildType(System.Xml.XmlNodeType type) { }
        private System.Boolean CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Boolean CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Boolean get_HasChildNodes() { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Void CopyChildren(System.Xml.XmlDocument doc, System.Xml.XmlNode container, System.Boolean deep) { }
        private System.String get_NamespaceURI() { }
        private System.String get_Prefix() { }
        private System.Void set_Prefix(System.String value) { }
        private System.String get_LocalName() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean HasReadOnlyParent(System.Xml.XmlNode n) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Void AppendChildText(System.Text.StringBuilder builder) { }
        private System.String get_InnerText() { }
        private System.Void set_InnerText(System.String value) { }
        private System.Void set_InnerXml(System.String value) { }
        private System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo() { }
        private System.String get_BaseURI() { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.Void RemoveAll() { }
        private System.Xml.XmlDocument get_Document() { }
        private System.String GetPrefixOfNamespace(System.String namespaceURI) { }
        private System.String GetPrefixOfNamespaceStrict(System.String namespaceURI) { }
        private System.Void SetParent(System.Xml.XmlNode node) { }
        private System.Void SetParentForLoad(System.Xml.XmlNode node) { }
        private System.Void SplitName(System.String name, System.String& prefix, System.String& localName) { }
        private System.Xml.XmlNode FindChild(System.Xml.XmlNodeType type) { }
        private System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, System.String oldValue, System.String newValue, System.Xml.XmlNodeChangedAction action) { }
        private System.Void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args) { }
        private System.Void AfterEvent(System.Xml.XmlNodeChangedEventArgs args) { }
        private System.Xml.XmlSpace get_XmlSpace() { }
        private System.String get_XmlLang() { }
        private System.Xml.XPath.XPathNodeType get_XPNodeType() { }
        private System.String get_XPLocalName() { }
        private System.Boolean get_IsText() { }
        private System.Xml.XmlNode get_PreviousText() { }
        private System.Void NestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode) { }
        private System.Void UnnestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode) { }

    }

    // TypeToken: 0x20000B0
    public class XmlNodeChangedEventArgs : EventArgs
    {
        // Fields
        private System.Xml.XmlNodeChangedAction action;        // 0x10
        private System.Xml.XmlNode node;        // 0x18
        private System.Xml.XmlNode oldParent;        // 0x20
        private System.Xml.XmlNode newParent;        // 0x28
        private System.String oldValue;        // 0x30
        private System.String newValue;        // 0x38

        // Methods
        private System.Void .ctor(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, System.String oldValue, System.String newValue, System.Xml.XmlNodeChangedAction action) { }
        private System.Xml.XmlNodeChangedAction get_Action() { }

    }

    // TypeToken: 0x20000B1
    public class XmlNodeChangedEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Xml.XmlNodeChangedEventArgs e) { }

    }

    // TypeToken: 0x20000B2
    public class XmlNodeList, IEnumerable, IDisposable
    {
        // Methods
        private System.Xml.XmlNode Item(System.Int32 index) { }
        private System.Int32 get_Count() { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Xml.XmlNode get_ItemOf(System.Int32 i) { }
        private System.Void System.IDisposable.Dispose() { }
        private System.Void PrivateDisposeNodeList() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3
    public class XmlNodeReaderNavigator
    {
        // Fields
        private System.Xml.XmlNode curNode;        // 0x10
        private System.Xml.XmlNode elemNode;        // 0x18
        private System.Xml.XmlNode logNode;        // 0x20
        private System.Int32 attrIndex;        // 0x28
        private System.Int32 logAttrIndex;        // 0x2C
        private System.Xml.XmlNameTable nameTable;        // 0x30
        private System.Xml.XmlDocument doc;        // 0x38
        private System.Int32 nAttrInd;        // 0x40
        private System.Int32 nDeclarationAttrCount;        // 0x44
        private System.Int32 nDocTypeAttrCount;        // 0x48
        private System.Int32 nLogLevel;        // 0x4C
        private System.Int32 nLogAttrInd;        // 0x50
        private System.Boolean bLogOnAttrVal;        // 0x54
        private System.Boolean bCreatedOnAttribute;        // 0x55
        private System.Xml.XmlNodeReaderNavigator.VirtualAttribute[] decNodeAttributes;        // 0x58
        private System.Xml.XmlNodeReaderNavigator.VirtualAttribute[] docTypeNodeAttributes;        // 0x60
        private System.Boolean bOnAttrVal;        // 0x68

        // Methods
        private System.Void .ctor(System.Xml.XmlNode node) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.Boolean get_CreatedOnAttribute() { }
        private System.Boolean IsLocalNameEmpty(System.Xml.XmlNodeType nt) { }
        private System.String get_Prefix() { }
        private System.Boolean get_HasValue() { }
        private System.String get_Value() { }
        private System.String get_BaseURI() { }
        private System.Xml.XmlSpace get_XmlSpace() { }
        private System.String get_XmlLang() { }
        private System.Boolean get_IsEmptyElement() { }
        private System.Boolean get_IsDefault() { }
        private System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Int32 get_AttributeCount() { }
        private System.Void CheckIndexCondition(System.Int32 attributeIndex) { }
        private System.Void InitDecAttr() { }
        private System.String GetDeclarationAttr(System.Xml.XmlDeclaration decl, System.String name) { }
        private System.String GetDeclarationAttr(System.Int32 i) { }
        private System.Int32 GetDecAttrInd(System.String name) { }
        private System.Void InitDocTypeAttr() { }
        private System.String GetDocumentTypeAttr(System.Xml.XmlDocumentType docType, System.String name) { }
        private System.String GetDocumentTypeAttr(System.Int32 i) { }
        private System.Int32 GetDocTypeAttrInd(System.String name) { }
        private System.String GetAttributeFromElement(System.Xml.XmlElement elem, System.String name) { }
        private System.String GetAttribute(System.String name) { }
        private System.String GetAttributeFromElement(System.Xml.XmlElement elem, System.String name, System.String ns) { }
        private System.String GetAttribute(System.String name, System.String ns) { }
        private System.String GetAttribute(System.Int32 attributeIndex) { }
        private System.Void LogMove(System.Int32 level) { }
        private System.Void RollBackMove(System.Int32& level) { }
        private System.Boolean get_IsOnDeclOrDocType() { }
        private System.Void ResetToAttribute(System.Int32& level) { }
        private System.Void ResetMove(System.Int32& level, System.Xml.XmlNodeType& nt) { }
        private System.Boolean MoveToAttribute(System.String name) { }
        private System.Boolean MoveToAttributeFromElement(System.Xml.XmlElement elem, System.String name, System.String ns) { }
        private System.Boolean MoveToAttribute(System.String name, System.String namespaceURI) { }
        private System.Void MoveToAttribute(System.Int32 attributeIndex) { }
        private System.Boolean MoveToNextAttribute(System.Int32& level) { }
        private System.Boolean MoveToParent() { }
        private System.Boolean MoveToFirstChild() { }
        private System.Boolean MoveToNextSibling(System.Xml.XmlNode node) { }
        private System.Boolean MoveToNext() { }
        private System.Boolean MoveToElement() { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.String DefaultLookupNamespace(System.String prefix) { }
        private System.String LookupPrefix(System.String namespaceName) { }
        private System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.Boolean ReadAttributeValue(System.Int32& level, System.Boolean& bResolveEntity, System.Xml.XmlNodeType& nt) { }
        private System.Xml.XmlDocument get_Document() { }

    }

    // TypeToken: 0x20000B5
    public class XmlNodeReader : XmlReader, IXmlNamespaceResolver
    {
        // Fields
        private System.Xml.XmlNodeReaderNavigator readerNav;        // 0x10
        private System.Xml.XmlNodeType nodeType;        // 0x18
        private System.Int32 curDepth;        // 0x1C
        private System.Xml.ReadState readState;        // 0x20
        private System.Boolean fEOF;        // 0x24
        private System.Boolean bResolveEntity;        // 0x25
        private System.Boolean bStartFromDocument;        // 0x26
        private System.Boolean bInReadBinary;        // 0x27
        private System.Xml.ReadContentAsBinaryHelper readBinaryHelper;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.XmlNode node) { }
        private System.Boolean IsInReadingStates() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Prefix() { }
        private System.Boolean get_HasValue() { }
        private System.String get_Value() { }
        private System.Int32 get_Depth() { }
        private System.String get_BaseURI() { }
        private System.Boolean get_CanResolveEntity() { }
        private System.Boolean get_IsEmptyElement() { }
        private System.Boolean get_IsDefault() { }
        private System.Xml.XmlSpace get_XmlSpace() { }
        private System.String get_XmlLang() { }
        private System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo() { }
        private System.Int32 get_AttributeCount() { }
        private System.String GetAttribute(System.String name) { }
        private System.String GetAttribute(System.String name, System.String namespaceURI) { }
        private System.String GetAttribute(System.Int32 attributeIndex) { }
        private System.Boolean MoveToAttribute(System.String name) { }
        private System.Void MoveToAttribute(System.Int32 attributeIndex) { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }
        private System.Boolean MoveToElement() { }
        private System.Boolean Read() { }
        private System.Boolean Read(System.Boolean fSkipChildren) { }
        private System.Boolean ReadNextNode(System.Boolean fSkipChildren) { }
        private System.Void SetEndOfFile() { }
        private System.Boolean ReadAtZeroLevel(System.Boolean fSkipChildren) { }
        private System.Boolean ReadForward(System.Boolean fSkipChildren) { }
        private System.Void ReSetReadingMarks() { }
        private System.Boolean get_EOF() { }
        private System.Void Close() { }
        private System.Xml.ReadState get_ReadState() { }
        private System.Void Skip() { }
        private System.String ReadString() { }
        private System.Boolean get_HasAttributes() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.Void ResolveEntity() { }
        private System.Boolean ReadAttributeValue() { }
        private System.Void FinishReadBinary() { }
        private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName) { }
        private System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix) { }
        private System.Xml.IDtdInfo get_DtdInfo() { }

    }

    // TypeToken: 0x20000B6
    public class XmlNotation : XmlNode
    {
        // Fields
        private System.String publicId;        // 0x18
        private System.String systemId;        // 0x20
        private System.String name;        // 0x28

        // Methods
        private System.Void .ctor(System.String name, System.String publicId, System.String systemId, System.Xml.XmlDocument doc) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Boolean get_IsReadOnly() { }
        private System.Void set_InnerXml(System.String value) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }

    }

    // TypeToken: 0x20000B7
    public class XmlProcessingInstruction : XmlLinkedNode
    {
        // Fields
        private System.String target;        // 0x20
        private System.String data;        // 0x28

        // Methods
        private System.Void .ctor(System.String target, System.String data, System.Xml.XmlDocument doc) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Void set_Data(System.String value) { }
        private System.String get_InnerText() { }
        private System.Void set_InnerText(System.String value) { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.String get_XPLocalName() { }
        private System.Xml.XPath.XPathNodeType get_XPNodeType() { }

    }

    // TypeToken: 0x20000B8
    public class XmlSignificantWhitespace : XmlCharacterData
    {
        // Methods
        private System.Void .ctor(System.String strData, System.Xml.XmlDocument doc) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode get_ParentNode() { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.Xml.XPath.XPathNodeType get_XPNodeType() { }
        private System.Boolean get_IsText() { }
        private System.Xml.XmlNode get_PreviousText() { }

    }

    // TypeToken: 0x20000B9
    public class XmlText : XmlCharacterData
    {
        // Methods
        private System.Void .ctor(System.String strData) { }
        private System.Void .ctor(System.String strData, System.Xml.XmlDocument doc) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode get_ParentNode() { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.Xml.XPath.XPathNodeType get_XPNodeType() { }
        private System.Boolean get_IsText() { }
        private System.Xml.XmlNode get_PreviousText() { }

    }

    // TypeToken: 0x20000BA
    public class XmlUnspecifiedAttribute : XmlAttribute
    {
        // Fields
        private System.Boolean fSpecified;        // 0x28

        // Methods
        private System.Void .ctor(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.XmlDocument doc) { }
        private System.Boolean get_Specified() { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Void set_InnerText(System.String value) { }
        private System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { }
        private System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild) { }
        private System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void SetSpecified(System.Boolean f) { }

    }

    // TypeToken: 0x20000BB
    public class XmlWhitespace : XmlCharacterData
    {
        // Methods
        private System.Void .ctor(System.String strData, System.Xml.XmlDocument doc) { }
        private System.String get_Name() { }
        private System.String get_LocalName() { }
        private System.Xml.XmlNodeType get_NodeType() { }
        private System.Xml.XmlNode get_ParentNode() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Xml.XmlNode CloneNode(System.Boolean deep) { }
        private System.Void WriteTo(System.Xml.XmlWriter w) { }
        private System.Void WriteContentTo(System.Xml.XmlWriter w) { }
        private System.Xml.XPath.XPathNodeType get_XPNodeType() { }
        private System.Boolean get_IsText() { }
        private System.Xml.XmlNode get_PreviousText() { }

    }

    // TypeToken: 0x20000BC
    public class EmptyEnumerator, IEnumerator
    {
        // Methods
        private System.Boolean System.Collections.IEnumerator.MoveNext() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BD
    public class HWStack, ICloneable
    {
        // Fields
        private System.Object[] stack;        // 0x10
        private System.Int32 growthRate;        // 0x18
        private System.Int32 used;        // 0x1C
        private System.Int32 size;        // 0x20
        private System.Int32 limit;        // 0x24

        // Methods
        private System.Void .ctor(System.Int32 GrowthRate) { }
        private System.Void .ctor(System.Int32 GrowthRate, System.Int32 limit) { }
        private System.Object Push() { }
        private System.Object Pop() { }
        private System.Object Peek() { }
        private System.Void AddToTop(System.Object o) { }
        private System.Object get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Object value) { }
        private System.Int32 get_Length() { }
        private System.Void .ctor(System.Object[] stack, System.Int32 growthRate, System.Int32 used, System.Int32 size) { }
        private System.Object Clone() { }

    }

    // TypeToken: 0x20000BE
    public interface IHasXmlNode
    {
        // Methods
        private System.Xml.XmlNode GetNode() { }

    }

    // TypeToken: 0x20000BF
    public interface IXmlLineInfo
    {
        // Methods
        private System.Boolean HasLineInfo() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }

    }

    // TypeToken: 0x20000C0
    public class PositionInfo, IXmlLineInfo
    {
        // Methods
        private System.Boolean HasLineInfo() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }
        private System.Xml.PositionInfo GetPositionInfo(System.Object o) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1
    public class ReaderPositionInfo : PositionInfo
    {
        // Fields
        private System.Xml.IXmlLineInfo lineInfo;        // 0x10

        // Methods
        private System.Void .ctor(System.Xml.IXmlLineInfo lineInfo) { }
        private System.Boolean HasLineInfo() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }

    }

    // TypeToken: 0x20000C2
    public interface IXmlNamespaceResolver
    {
        // Methods
        private System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.String LookupPrefix(System.String namespaceName) { }

    }

    // TypeToken: 0x20000C3
    public struct LineInfo
    {
        // Fields
        private System.Int32 lineNo;        // 0x10
        private System.Int32 linePos;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 lineNo, System.Int32 linePos) { }
        private System.Void Set(System.Int32 lineNo, System.Int32 linePos) { }

    }

    // TypeToken: 0x20000C4
    public class NameTable : XmlNameTable
    {
        // Fields
        private System.Xml.NameTable.Entry[] entries;        // 0x10
        private System.Int32 count;        // 0x18
        private System.Int32 mask;        // 0x1C
        private System.Int32 hashCodeRandomizer;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.String Add(System.String key) { }
        private System.String Add(System.Char[] key, System.Int32 start, System.Int32 len) { }
        private System.String Get(System.String value) { }
        private System.String AddEntry(System.String str, System.Int32 hashCode) { }
        private System.Void Grow() { }
        private System.Boolean TextEquals(System.String str1, System.Char[] str2, System.Int32 str2Start, System.Int32 str2Length) { }

    }

    // TypeToken: 0x20000C6
    public class Ref
    {
        // Methods
        private System.Boolean Equal(System.String strA, System.String strB) { }

    }

    // TypeToken: 0x20000C7
    public class DtdParser, IDtdParser
    {
        // Fields
        private System.Xml.IDtdParserAdapter readerAdapter;        // 0x10
        private System.Xml.IDtdParserAdapterWithValidation readerAdapterWithValidation;        // 0x18
        private System.Xml.XmlNameTable nameTable;        // 0x20
        private System.Xml.Schema.SchemaInfo schemaInfo;        // 0x28
        private System.Xml.XmlCharType xmlCharType;        // 0x30
        private System.String systemId;        // 0x38
        private System.String publicId;        // 0x40
        private System.Boolean normalize;        // 0x48
        private System.Boolean validate;        // 0x49
        private System.Boolean supportNamespaces;        // 0x4A
        private System.Boolean v1Compat;        // 0x4B
        private System.Char[] chars;        // 0x50
        private System.Int32 charsUsed;        // 0x58
        private System.Int32 curPos;        // 0x5C
        private System.Xml.DtdParser.ScanningFunction scanningFunction;        // 0x60
        private System.Xml.DtdParser.ScanningFunction nextScaningFunction;        // 0x64
        private System.Xml.DtdParser.ScanningFunction savedScanningFunction;        // 0x68
        private System.Boolean whitespaceSeen;        // 0x6C
        private System.Int32 tokenStartPos;        // 0x70
        private System.Int32 colonPos;        // 0x74
        private System.Text.StringBuilder internalSubsetValueSb;        // 0x78
        private System.Int32 externalEntitiesDepth;        // 0x80
        private System.Int32 currentEntityId;        // 0x84
        private System.Boolean freeFloatingDtd;        // 0x88
        private System.Boolean hasFreeFloatingInternalSubset;        // 0x89
        private System.Text.StringBuilder stringBuilder;        // 0x90
        private System.Int32 condSectionDepth;        // 0x98
        private System.Xml.LineInfo literalLineInfo;        // 0x9C
        private System.Char literalQuoteChar;        // 0xA4
        private System.String documentBaseUri;        // 0xA8
        private System.String externalDtdBaseUri;        // 0xB0
        private System.Collections.Generic.Dictionary<System.String,System.Xml.DtdParser.UndeclaredNotation> undeclaredNotations;        // 0xB8
        private System.Int32[] condSectionEntityIds;        // 0xC0

        // Methods
        private System.Void .ctor() { }
        private System.Xml.IDtdParser Create() { }
        private System.Void Initialize(System.Xml.IDtdParserAdapter readerAdapter) { }
        private System.Void InitializeFreeFloatingDtd(System.String baseUri, System.String docTypeName, System.String publicId, System.String systemId, System.String internalSubset, System.Xml.IDtdParserAdapter adapter) { }
        private System.Xml.IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, System.Boolean saveInternalSubset) { }
        private System.Xml.IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(System.String baseUri, System.String docTypeName, System.String publicId, System.String systemId, System.String internalSubset, System.Xml.IDtdParserAdapter adapter) { }
        private System.Boolean get_ParsingInternalSubset() { }
        private System.Boolean get_IgnoreEntityReferences() { }
        private System.Boolean get_SaveInternalSubsetValue() { }
        private System.Boolean get_ParsingTopLevelMarkup() { }
        private System.Boolean get_SupportNamespaces() { }
        private System.Boolean get_Normalize() { }
        private System.Void Parse(System.Boolean saveInternalSubset) { }
        private System.Void ParseInDocumentDtd(System.Boolean saveInternalSubset) { }
        private System.Void ParseFreeFloatingDtd() { }
        private System.Void ParseInternalSubset() { }
        private System.Void ParseExternalSubset() { }
        private System.Void ParseSubset() { }
        private System.Void ParseAttlistDecl() { }
        private System.Void ParseAttlistType(System.Xml.Schema.SchemaAttDef attrDef, System.Xml.Schema.SchemaElementDecl elementDecl, System.Boolean ignoreErrors) { }
        private System.Void ParseAttlistDefault(System.Xml.Schema.SchemaAttDef attrDef, System.Boolean ignoreErrors) { }
        private System.Void ParseElementDecl() { }
        private System.Void ParseElementOnlyContent(System.Xml.Schema.ParticleContentValidator pcv, System.Int32 startParenEntityId) { }
        private System.Void ParseHowMany(System.Xml.Schema.ParticleContentValidator pcv) { }
        private System.Void ParseElementMixedContent(System.Xml.Schema.ParticleContentValidator pcv, System.Int32 startParenEntityId) { }
        private System.Void ParseEntityDecl() { }
        private System.Void ParseNotationDecl() { }
        private System.Void AddUndeclaredNotation(System.String notationName) { }
        private System.Void ParseComment() { }
        private System.Void ParsePI() { }
        private System.Void ParseCondSection() { }
        private System.Void ParseExternalId(System.Xml.DtdParser.Token idTokenType, System.Xml.DtdParser.Token declType, System.String& publicId, System.String& systemId) { }
        private System.Xml.DtdParser.Token GetToken(System.Boolean needWhiteSpace) { }
        private System.Xml.DtdParser.Token ScanSubsetContent() { }
        private System.Xml.DtdParser.Token ScanNameExpected() { }
        private System.Xml.DtdParser.Token ScanQNameExpected() { }
        private System.Xml.DtdParser.Token ScanNmtokenExpected() { }
        private System.Xml.DtdParser.Token ScanDoctype1() { }
        private System.Xml.DtdParser.Token ScanDoctype2() { }
        private System.Xml.DtdParser.Token ScanClosingTag() { }
        private System.Xml.DtdParser.Token ScanElement1() { }
        private System.Xml.DtdParser.Token ScanElement2() { }
        private System.Xml.DtdParser.Token ScanElement3() { }
        private System.Xml.DtdParser.Token ScanElement4() { }
        private System.Xml.DtdParser.Token ScanElement5() { }
        private System.Xml.DtdParser.Token ScanElement6() { }
        private System.Xml.DtdParser.Token ScanElement7() { }
        private System.Xml.DtdParser.Token ScanAttlist1() { }
        private System.Xml.DtdParser.Token ScanAttlist2() { }
        private System.Xml.DtdParser.Token ScanAttlist3() { }
        private System.Xml.DtdParser.Token ScanAttlist4() { }
        private System.Xml.DtdParser.Token ScanAttlist5() { }
        private System.Xml.DtdParser.Token ScanAttlist6() { }
        private System.Xml.DtdParser.Token ScanAttlist7() { }
        private System.Xml.DtdParser.Token ScanLiteral(System.Xml.DtdParser.LiteralType literalType) { }
        private System.Xml.XmlQualifiedName ScanEntityName() { }
        private System.Xml.DtdParser.Token ScanNotation1() { }
        private System.Xml.DtdParser.Token ScanSystemId() { }
        private System.Xml.DtdParser.Token ScanEntity1() { }
        private System.Xml.DtdParser.Token ScanEntity2() { }
        private System.Xml.DtdParser.Token ScanEntity3() { }
        private System.Xml.DtdParser.Token ScanPublicId1() { }
        private System.Xml.DtdParser.Token ScanPublicId2() { }
        private System.Xml.DtdParser.Token ScanCondSection1() { }
        private System.Xml.DtdParser.Token ScanCondSection2() { }
        private System.Xml.DtdParser.Token ScanCondSection3() { }
        private System.Void ScanName() { }
        private System.Void ScanQName() { }
        private System.Void ScanQName(System.Boolean isQName) { }
        private System.Boolean ReadDataInName() { }
        private System.Void ScanNmtoken() { }
        private System.Boolean EatPublicKeyword() { }
        private System.Boolean EatSystemKeyword() { }
        private System.Xml.XmlQualifiedName GetNameQualified(System.Boolean canHavePrefix) { }
        private System.String GetNameString() { }
        private System.String GetNmtokenString() { }
        private System.String GetValue() { }
        private System.String GetValueWithStrippedSpaces() { }
        private System.Int32 ReadData() { }
        private System.Void LoadParsingBuffer() { }
        private System.Void SaveParsingBuffer() { }
        private System.Void SaveParsingBuffer(System.Int32 internalSubsetValueEndPos) { }
        private System.Boolean HandleEntityReference(System.Boolean paramEntity, System.Boolean inLiteral, System.Boolean inAttribute) { }
        private System.Boolean HandleEntityReference(System.Xml.XmlQualifiedName entityName, System.Boolean paramEntity, System.Boolean inLiteral, System.Boolean inAttribute) { }
        private System.Boolean HandleEntityEnd(System.Boolean inLiteral) { }
        private System.Xml.Schema.SchemaEntity VerifyEntityReference(System.Xml.XmlQualifiedName entityName, System.Boolean paramEntity, System.Boolean mustBeDeclared, System.Boolean inAttribute) { }
        private System.Void SendValidationEvent(System.Int32 pos, System.Xml.Schema.XmlSeverityType severity, System.String code, System.String arg) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.String code, System.String arg) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException e) { }
        private System.Boolean IsAttributeValueType(System.Xml.DtdParser.Token token) { }
        private System.Int32 get_LineNo() { }
        private System.Int32 get_LinePos() { }
        private System.String get_BaseUriStr() { }
        private System.Void OnUnexpectedError() { }
        private System.Void Throw(System.Int32 curPos, System.String res) { }
        private System.Void Throw(System.Int32 curPos, System.String res, System.String arg) { }
        private System.Void Throw(System.Int32 curPos, System.String res, System.String[] args) { }
        private System.Void Throw(System.String res, System.String arg, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Void ThrowInvalidChar(System.Int32 pos, System.String data, System.Int32 invCharPos) { }
        private System.Void ThrowInvalidChar(System.Char[] data, System.Int32 length, System.Int32 invCharPos) { }
        private System.Void ThrowUnexpectedToken(System.Int32 pos, System.String expectedToken) { }
        private System.Void ThrowUnexpectedToken(System.Int32 pos, System.String expectedToken1, System.String expectedToken2) { }
        private System.String ParseUnexpectedToken(System.Int32 startPos) { }
        private System.String StripSpaces(System.String value) { }

    }

    // TypeToken: 0x20000CD
    public struct XmlTokenizedType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlTokenizedType CDATA;        // 0x0
        public static System.Xml.XmlTokenizedType ID;        // 0x0
        public static System.Xml.XmlTokenizedType IDREF;        // 0x0
        public static System.Xml.XmlTokenizedType IDREFS;        // 0x0
        public static System.Xml.XmlTokenizedType ENTITY;        // 0x0
        public static System.Xml.XmlTokenizedType ENTITIES;        // 0x0
        public static System.Xml.XmlTokenizedType NMTOKEN;        // 0x0
        public static System.Xml.XmlTokenizedType NMTOKENS;        // 0x0
        public static System.Xml.XmlTokenizedType NOTATION;        // 0x0
        public static System.Xml.XmlTokenizedType ENUMERATION;        // 0x0
        public static System.Xml.XmlTokenizedType QName;        // 0x0
        public static System.Xml.XmlTokenizedType NCName;        // 0x0
        public static System.Xml.XmlTokenizedType None;        // 0x0

    }

    // TypeToken: 0x20000CE
    public class ValidateNames
    {
        // Fields
        private static System.Xml.XmlCharType xmlCharType;        // 0x0

        // Methods
        private System.Int32 ParseNmtoken(System.String s, System.Int32 offset) { }
        private System.Int32 ParseNmtokenNoNamespaces(System.String s, System.Int32 offset) { }
        private System.Int32 ParseNameNoNamespaces(System.String s, System.Int32 offset) { }
        private System.Boolean IsNameNoNamespaces(System.String s) { }
        private System.Int32 ParseNCName(System.String s, System.Int32 offset) { }
        private System.Int32 ParseNCName(System.String s) { }
        private System.Int32 ParseQName(System.String s, System.Int32 offset, System.Int32& colonOffset) { }
        private System.Void ParseQNameThrow(System.String s, System.String& prefix, System.String& localName) { }
        private System.Void ThrowInvalidName(System.String s, System.Int32 offsetStartChar, System.Int32 offsetBadChar) { }
        private System.Exception GetInvalidNameException(System.String s, System.Int32 offsetStartChar, System.Int32 offsetBadChar) { }
        private System.Void SplitQName(System.String name, System.String& prefix, System.String& lname) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000CF
    public struct XmlCharType
    {
        // Fields
        private static System.Object s_Lock;        // 0x0
        private static System.Byte[] s_CharProperties;        // 0x8
        private System.Byte[] charProperties;        // 0x10

        // Methods
        private System.Object get_StaticLock() { }
        private System.Void InitInstance() { }
        private System.Void SetProperties(System.Byte[] chProps, System.String ranges, System.Byte value) { }
        private System.Void .ctor(System.Byte[] charProperties) { }
        private System.Xml.XmlCharType get_Instance() { }
        private System.Boolean IsWhiteSpace(System.Char ch) { }
        private System.Boolean IsNCNameSingleChar(System.Char ch) { }
        private System.Boolean IsStartNCNameSingleChar(System.Char ch) { }
        private System.Boolean IsNameSingleChar(System.Char ch) { }
        private System.Boolean IsCharData(System.Char ch) { }
        private System.Boolean IsPubidChar(System.Char ch) { }
        private System.Boolean IsTextChar(System.Char ch) { }
        private System.Boolean IsLetter(System.Char ch) { }
        private System.Boolean IsNCNameCharXml4e(System.Char ch) { }
        private System.Boolean IsStartNCNameCharXml4e(System.Char ch) { }
        private System.Boolean IsNameCharXml4e(System.Char ch) { }
        private System.Boolean IsDigit(System.Char ch) { }
        private System.Boolean IsHighSurrogate(System.Int32 ch) { }
        private System.Boolean IsLowSurrogate(System.Int32 ch) { }
        private System.Boolean IsSurrogate(System.Int32 ch) { }
        private System.Int32 CombineSurrogateChar(System.Int32 lowChar, System.Int32 highChar) { }
        private System.Void SplitSurrogateChar(System.Int32 combinedChar, System.Char& lowChar, System.Char& highChar) { }
        private System.Boolean IsOnlyWhitespace(System.String str) { }
        private System.Int32 IsOnlyWhitespaceWithPos(System.String str) { }
        private System.Int32 IsOnlyCharData(System.String str) { }
        private System.Boolean IsOnlyDigits(System.String str, System.Int32 startPos, System.Int32 len) { }
        private System.Int32 IsPublicId(System.String str) { }
        private System.Boolean InRange(System.Int32 value, System.Int32 start, System.Int32 end) { }

    }

    // TypeToken: 0x20000D0
    public class XmlComplianceUtil
    {
        // Methods
        private System.String NonCDataNormalize(System.String value) { }
        private System.String CDataNormalize(System.String value) { }

    }

    // TypeToken: 0x20000D1
    public struct ExceptionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.ExceptionType ArgumentException;        // 0x0
        public static System.Xml.ExceptionType XmlException;        // 0x0

    }

    // TypeToken: 0x20000D2
    public struct XmlDateTimeSerializationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlDateTimeSerializationMode Local;        // 0x0
        public static System.Xml.XmlDateTimeSerializationMode Utc;        // 0x0
        public static System.Xml.XmlDateTimeSerializationMode Unspecified;        // 0x0
        public static System.Xml.XmlDateTimeSerializationMode RoundtripKind;        // 0x0

    }

    // TypeToken: 0x20000D3
    public class XmlConvert
    {
        // Fields
        private static System.Xml.XmlCharType xmlCharType;        // 0x0
        private static System.Char[] crt;        // 0x8
        private static readonly System.Int32 c_EncodedCharLength;        // 0x10
        private static System.Text.RegularExpressions.Regex c_EncodeCharPattern;        // 0x18
        private static System.Text.RegularExpressions.Regex c_DecodeCharPattern;        // 0x20
        private static System.String[] s_allDateTimeFormats;        // 0x28
        private static readonly System.Char[] WhitespaceChars;        // 0x30

        // Methods
        private System.String EncodeName(System.String name) { }
        private System.String EncodeLocalName(System.String name) { }
        private System.String DecodeName(System.String name) { }
        private System.String EncodeName(System.String name, System.Boolean first, System.Boolean local) { }
        private System.Int32 FromHex(System.Char digit) { }
        private System.Byte[] FromBinHexString(System.String s) { }
        private System.Byte[] FromBinHexString(System.String s, System.Boolean allowOddCount) { }
        private System.String ToBinHexString(System.Byte[] inArray) { }
        private System.String VerifyName(System.String name) { }
        private System.Exception TryVerifyName(System.String name) { }
        private System.String VerifyQName(System.String name, System.Xml.ExceptionType exceptionType) { }
        private System.String VerifyNCName(System.String name) { }
        private System.String VerifyNCName(System.String name, System.Xml.ExceptionType exceptionType) { }
        private System.Exception TryVerifyNCName(System.String name) { }
        private System.String VerifyTOKEN(System.String token) { }
        private System.Exception TryVerifyTOKEN(System.String token) { }
        private System.Exception TryVerifyNMTOKEN(System.String name) { }
        private System.Exception TryVerifyNormalizedString(System.String str) { }
        private System.String ToString(System.Boolean value) { }
        private System.String ToString(System.Char value) { }
        private System.String ToString(System.Decimal value) { }
        private System.String ToString(System.SByte value) { }
        private System.String ToString(System.Int16 value) { }
        private System.String ToString(System.Int32 value) { }
        private System.String ToString(System.Int64 value) { }
        private System.String ToString(System.Byte value) { }
        private System.String ToString(System.UInt16 value) { }
        private System.String ToString(System.UInt32 value) { }
        private System.String ToString(System.UInt64 value) { }
        private System.String ToString(System.Single value) { }
        private System.String ToString(System.Double value) { }
        private System.String ToString(System.TimeSpan value) { }
        private System.String ToString(System.DateTime value, System.String format) { }
        private System.String ToString(System.DateTime value, System.Xml.XmlDateTimeSerializationMode dateTimeOption) { }
        private System.String ToString(System.DateTimeOffset value) { }
        private System.String ToString(System.Guid value) { }
        private System.Boolean ToBoolean(System.String s) { }
        private System.Exception TryToBoolean(System.String s, System.Boolean& result) { }
        private System.Char ToChar(System.String s) { }
        private System.Exception TryToChar(System.String s, System.Char& result) { }
        private System.Decimal ToDecimal(System.String s) { }
        private System.Exception TryToDecimal(System.String s, System.Decimal& result) { }
        private System.Decimal ToInteger(System.String s) { }
        private System.Exception TryToInteger(System.String s, System.Decimal& result) { }
        private System.SByte ToSByte(System.String s) { }
        private System.Exception TryToSByte(System.String s, System.SByte& result) { }
        private System.Int16 ToInt16(System.String s) { }
        private System.Exception TryToInt16(System.String s, System.Int16& result) { }
        private System.Int32 ToInt32(System.String s) { }
        private System.Exception TryToInt32(System.String s, System.Int32& result) { }
        private System.Int64 ToInt64(System.String s) { }
        private System.Exception TryToInt64(System.String s, System.Int64& result) { }
        private System.Byte ToByte(System.String s) { }
        private System.Exception TryToByte(System.String s, System.Byte& result) { }
        private System.UInt16 ToUInt16(System.String s) { }
        private System.Exception TryToUInt16(System.String s, System.UInt16& result) { }
        private System.UInt32 ToUInt32(System.String s) { }
        private System.Exception TryToUInt32(System.String s, System.UInt32& result) { }
        private System.UInt64 ToUInt64(System.String s) { }
        private System.Exception TryToUInt64(System.String s, System.UInt64& result) { }
        private System.Single ToSingle(System.String s) { }
        private System.Exception TryToSingle(System.String s, System.Single& result) { }
        private System.Double ToDouble(System.String s) { }
        private System.Exception TryToDouble(System.String s, System.Double& result) { }
        private System.Double ToXPathDouble(System.Object o) { }
        private System.Double XPathRound(System.Double value) { }
        private System.TimeSpan ToTimeSpan(System.String s) { }
        private System.Exception TryToTimeSpan(System.String s, System.TimeSpan& result) { }
        private System.String[] get_AllDateTimeFormats() { }
        private System.Void CreateAllDateTimeFormats() { }
        private System.DateTime ToDateTime(System.String s) { }
        private System.DateTime ToDateTime(System.String s, System.String[] formats) { }
        private System.DateTime ToDateTime(System.String s, System.Xml.XmlDateTimeSerializationMode dateTimeOption) { }
        private System.DateTimeOffset ToDateTimeOffset(System.String s) { }
        private System.Guid ToGuid(System.String s) { }
        private System.Exception TryToGuid(System.String s, System.Guid& result) { }
        private System.DateTime SwitchToLocalTime(System.DateTime value) { }
        private System.DateTime SwitchToUtcTime(System.DateTime value) { }
        private System.Uri ToUri(System.String s) { }
        private System.Exception TryToUri(System.String s, System.Uri& result) { }
        private System.Boolean StrEqual(System.Char[] chars, System.Int32 strPos1, System.Int32 strLen1, System.String str2) { }
        private System.String TrimString(System.String value) { }
        private System.String TrimStringStart(System.String value) { }
        private System.String TrimStringEnd(System.String value) { }
        private System.String[] SplitString(System.String value) { }
        private System.Boolean IsNegativeZero(System.Double value) { }
        private System.Int64 DoubleToInt64Bits(System.Double value) { }
        private System.Void VerifyCharData(System.String data, System.Xml.ExceptionType invCharExceptionType, System.Xml.ExceptionType invSurrogateExceptionType) { }
        private System.Exception CreateException(System.String res, System.Xml.ExceptionType exceptionType, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Exception CreateException(System.String res, System.String arg, System.Xml.ExceptionType exceptionType, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Exception CreateException(System.String res, System.String[] args, System.Xml.ExceptionType exceptionType) { }
        private System.Exception CreateException(System.String res, System.String[] args, System.Xml.ExceptionType exceptionType, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Exception CreateInvalidSurrogatePairException(System.Char low, System.Char hi) { }
        private System.Exception CreateInvalidSurrogatePairException(System.Char low, System.Char hi, System.Xml.ExceptionType exceptionType) { }
        private System.Exception CreateInvalidSurrogatePairException(System.Char low, System.Char hi, System.Xml.ExceptionType exceptionType, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Exception CreateInvalidHighSurrogateCharException(System.Char hi) { }
        private System.Exception CreateInvalidHighSurrogateCharException(System.Char hi, System.Xml.ExceptionType exceptionType) { }
        private System.Exception CreateInvalidHighSurrogateCharException(System.Char hi, System.Xml.ExceptionType exceptionType, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Exception CreateInvalidCharException(System.String data, System.Int32 invCharPos, System.Xml.ExceptionType exceptionType) { }
        private System.Exception CreateInvalidCharException(System.Char invChar, System.Char nextChar) { }
        private System.Exception CreateInvalidCharException(System.Char invChar, System.Char nextChar, System.Xml.ExceptionType exceptionType) { }
        private System.Exception CreateInvalidNameCharException(System.String name, System.Int32 index, System.Xml.ExceptionType exceptionType) { }
        private System.ArgumentException CreateInvalidNameArgumentException(System.String name, System.String argumentName) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D4
    public class XmlDownloadManager
    {
        // Fields
        private System.Collections.Hashtable connections;        // 0x10

        // Methods
        private System.IO.Stream GetStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy) { }
        private System.IO.Stream GetNonFileStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy) { }
        private System.Void Remove(System.String host) { }
        private System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy) { }
        private System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7
    public class OpenedHost
    {
        // Fields
        private System.Int32 nonCachedConnectionsCount;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D8
    public class XmlRegisteredNonCachedStream : Stream
    {
        // Fields
        protected System.IO.Stream stream;        // 0x28
        private System.Xml.XmlDownloadManager downloadManager;        // 0x30
        private System.String host;        // 0x38

        // Methods
        private System.Void .ctor(System.IO.Stream stream, System.Xml.XmlDownloadManager downloadManager, System.String host) { }
        private System.Void Finalize() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object state) { }
        private System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object state) { }
        private System.Int32 EndRead(System.IAsyncResult asyncResult) { }
        private System.Void EndWrite(System.IAsyncResult asyncResult) { }
        private System.Void Flush() { }
        private System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Int32 ReadByte() { }
        private System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin) { }
        private System.Void SetLength(System.Int64 value) { }
        private System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count) { }
        private System.Void WriteByte(System.Byte value) { }
        private System.Boolean get_CanRead() { }
        private System.Boolean get_CanSeek() { }
        private System.Boolean get_CanWrite() { }
        private System.Int64 get_Length() { }
        private System.Int64 get_Position() { }
        private System.Void set_Position(System.Int64 value) { }

    }

    // TypeToken: 0x20000D9
    public class XmlCachedStream : MemoryStream
    {
        // Fields
        private System.Uri uri;        // 0x50

        // Methods
        private System.Void .ctor(System.Uri uri, System.IO.Stream stream) { }

    }

    // TypeToken: 0x20000DA
    public class UTF16Decoder : Decoder
    {
        // Fields
        private System.Boolean bigEndian;        // 0x20
        private System.Int32 lastByte;        // 0x24

        // Methods
        private System.Void .ctor(System.Boolean bigEndian) { }
        private System.Int32 GetCharCount(System.Byte[] bytes, System.Int32 index, System.Int32 count) { }
        private System.Int32 GetCharCount(System.Byte[] bytes, System.Int32 index, System.Int32 count, System.Boolean flush) { }
        private System.Int32 GetChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex) { }
        private System.Void Convert(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex, System.Int32 charCount, System.Boolean flush, System.Int32& bytesUsed, System.Int32& charsUsed, System.Boolean& completed) { }

    }

    // TypeToken: 0x20000DB
    public class SafeAsciiDecoder : Decoder
    {
        // Methods
        private System.Void .ctor() { }
        private System.Int32 GetCharCount(System.Byte[] bytes, System.Int32 index, System.Int32 count) { }
        private System.Int32 GetChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex) { }
        private System.Void Convert(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex, System.Int32 charCount, System.Boolean flush, System.Int32& bytesUsed, System.Int32& charsUsed, System.Boolean& completed) { }

    }

    // TypeToken: 0x20000DC
    public class Ucs4Encoding : Encoding
    {
        // Fields
        private System.Xml.Ucs4Decoder ucs4Decoder;        // 0x38

        // Methods
        private System.String get_WebName() { }
        private System.Text.Decoder GetDecoder() { }
        private System.Int32 GetByteCount(System.Char[] chars, System.Int32 index, System.Int32 count) { }
        private System.Byte[] GetBytes(System.String s) { }
        private System.Int32 GetBytes(System.Char[] chars, System.Int32 charIndex, System.Int32 charCount, System.Byte[] bytes, System.Int32 byteIndex) { }
        private System.Int32 GetMaxByteCount(System.Int32 charCount) { }
        private System.Int32 GetCharCount(System.Byte[] bytes, System.Int32 index, System.Int32 count) { }
        private System.Int32 GetChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex) { }
        private System.Int32 GetMaxCharCount(System.Int32 byteCount) { }
        private System.Int32 get_CodePage() { }
        private System.Text.Encoder GetEncoder() { }
        private System.Text.Encoding get_UCS4_Littleendian() { }
        private System.Text.Encoding get_UCS4_Bigendian() { }
        private System.Text.Encoding get_UCS4_2143() { }
        private System.Text.Encoding get_UCS4_3412() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DD
    public class Ucs4Encoding1234 : Ucs4Encoding
    {
        // Methods
        private System.Void .ctor() { }
        private System.String get_EncodingName() { }
        private System.Byte[] GetPreamble() { }

    }

    // TypeToken: 0x20000DE
    public class Ucs4Encoding4321 : Ucs4Encoding
    {
        // Methods
        private System.Void .ctor() { }
        private System.String get_EncodingName() { }
        private System.Byte[] GetPreamble() { }

    }

    // TypeToken: 0x20000DF
    public class Ucs4Encoding2143 : Ucs4Encoding
    {
        // Methods
        private System.Void .ctor() { }
        private System.String get_EncodingName() { }
        private System.Byte[] GetPreamble() { }

    }

    // TypeToken: 0x20000E0
    public class Ucs4Encoding3412 : Ucs4Encoding
    {
        // Methods
        private System.Void .ctor() { }
        private System.String get_EncodingName() { }
        private System.Byte[] GetPreamble() { }

    }

    // TypeToken: 0x20000E1
    public class Ucs4Decoder : Decoder
    {
        // Fields
        private System.Byte[] lastBytes;        // 0x20
        private System.Int32 lastBytesCount;        // 0x28

        // Methods
        private System.Int32 GetCharCount(System.Byte[] bytes, System.Int32 index, System.Int32 count) { }
        private System.Int32 GetFullChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex) { }
        private System.Int32 GetChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex) { }
        private System.Void Convert(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex, System.Int32 charCount, System.Boolean flush, System.Int32& bytesUsed, System.Int32& charsUsed, System.Boolean& completed) { }
        private System.Void Ucs4ToUTF16(System.UInt32 code, System.Char[] chars, System.Int32 charIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E2
    public class Ucs4Decoder4321 : Ucs4Decoder
    {
        // Methods
        private System.Int32 GetFullChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E3
    public class Ucs4Decoder1234 : Ucs4Decoder
    {
        // Methods
        private System.Int32 GetFullChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E4
    public class Ucs4Decoder2143 : Ucs4Decoder
    {
        // Methods
        private System.Int32 GetFullChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E5
    public class Ucs4Decoder3412 : Ucs4Decoder
    {
        // Methods
        private System.Int32 GetFullChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E6
    public class XmlException : SystemException
    {
        // Fields
        private System.String res;        // 0x90
        private System.String[] args;        // 0x98
        private System.Int32 lineNumber;        // 0xA0
        private System.Int32 linePosition;        // 0xA4
        private System.String sourceUri;        // 0xA8
        private System.String message;        // 0xB0

        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private System.Void .ctor(System.String message, System.Exception innerException, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void .ctor(System.String message, System.Exception innerException, System.Int32 lineNumber, System.Int32 linePosition, System.String sourceUri) { }
        private System.Void .ctor(System.String res, System.String[] args) { }
        private System.Void .ctor(System.String res, System.String arg) { }
        private System.Void .ctor(System.String res, System.String arg, System.String sourceUri) { }
        private System.Void .ctor(System.String res, System.String arg, System.Xml.IXmlLineInfo lineInfo) { }
        private System.Void .ctor(System.String res, System.String arg, System.Exception innerException, System.Xml.IXmlLineInfo lineInfo) { }
        private System.Void .ctor(System.String res, System.String[] args, System.Xml.IXmlLineInfo lineInfo) { }
        private System.Void .ctor(System.String res, System.String[] args, System.Xml.IXmlLineInfo lineInfo, System.String sourceUri) { }
        private System.Void .ctor(System.String res, System.String arg, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void .ctor(System.String res, System.String arg, System.Int32 lineNumber, System.Int32 linePosition, System.String sourceUri) { }
        private System.Void .ctor(System.String res, System.String[] args, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void .ctor(System.String res, System.String[] args, System.Int32 lineNumber, System.Int32 linePosition, System.String sourceUri) { }
        private System.Void .ctor(System.String res, System.String[] args, System.Exception innerException, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void .ctor(System.String res, System.String[] args, System.Exception innerException, System.Int32 lineNumber, System.Int32 linePosition, System.String sourceUri) { }
        private System.String FormatUserMessage(System.String message, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.String CreateMessage(System.String res, System.String[] args, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.String[] BuildCharExceptionArgs(System.String data, System.Int32 invCharIndex) { }
        private System.String[] BuildCharExceptionArgs(System.Char[] data, System.Int32 length, System.Int32 invCharIndex) { }
        private System.String[] BuildCharExceptionArgs(System.Char invChar, System.Char nextChar) { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }
        private System.String get_Message() { }
        private System.String get_ResString() { }

    }

    // TypeToken: 0x20000E7
    public class XmlNameTable
    {
        // Methods
        private System.String Get(System.String array) { }
        private System.String Add(System.Char[] array, System.Int32 offset, System.Int32 length) { }
        private System.String Add(System.String array) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E8
    public struct XmlNamespaceScope
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlNamespaceScope All;        // 0x0
        public static System.Xml.XmlNamespaceScope ExcludeXml;        // 0x0
        public static System.Xml.XmlNamespaceScope Local;        // 0x0

    }

    // TypeToken: 0x20000E9
    public class XmlNamespaceManager, IXmlNamespaceResolver, IEnumerable
    {
        // Fields
        private System.Xml.XmlNamespaceManager.NamespaceDeclaration[] nsdecls;        // 0x10
        private System.Int32 lastDecl;        // 0x18
        private System.Xml.XmlNameTable nameTable;        // 0x20
        private System.Int32 scopeId;        // 0x28
        private System.Collections.Generic.Dictionary<System.String,System.Int32> hashTable;        // 0x30
        private System.Boolean useHashtable;        // 0x38
        private System.String xml;        // 0x40
        private System.String xmlNs;        // 0x48

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.XmlNameTable nameTable) { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.String get_DefaultNamespace() { }
        private System.Void PushScope() { }
        private System.Boolean PopScope() { }
        private System.Void AddNamespace(System.String prefix, System.String uri) { }
        private System.Void RemoveNamespace(System.String prefix, System.String uri) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.Int32 LookupNamespaceDecl(System.String prefix) { }
        private System.String LookupPrefix(System.String uri) { }

    }

    // TypeToken: 0x20000EB
    public struct XmlNodeOrder
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlNodeOrder Before;        // 0x0
        public static System.Xml.XmlNodeOrder After;        // 0x0
        public static System.Xml.XmlNodeOrder Same;        // 0x0
        public static System.Xml.XmlNodeOrder Unknown;        // 0x0

    }

    // TypeToken: 0x20000EC
    public struct XmlNodeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XmlNodeType None;        // 0x0
        public static System.Xml.XmlNodeType Element;        // 0x0
        public static System.Xml.XmlNodeType Attribute;        // 0x0
        public static System.Xml.XmlNodeType Text;        // 0x0
        public static System.Xml.XmlNodeType CDATA;        // 0x0
        public static System.Xml.XmlNodeType EntityReference;        // 0x0
        public static System.Xml.XmlNodeType Entity;        // 0x0
        public static System.Xml.XmlNodeType ProcessingInstruction;        // 0x0
        public static System.Xml.XmlNodeType Comment;        // 0x0
        public static System.Xml.XmlNodeType Document;        // 0x0
        public static System.Xml.XmlNodeType DocumentType;        // 0x0
        public static System.Xml.XmlNodeType DocumentFragment;        // 0x0
        public static System.Xml.XmlNodeType Notation;        // 0x0
        public static System.Xml.XmlNodeType Whitespace;        // 0x0
        public static System.Xml.XmlNodeType SignificantWhitespace;        // 0x0
        public static System.Xml.XmlNodeType EndElement;        // 0x0
        public static System.Xml.XmlNodeType EndEntity;        // 0x0
        public static System.Xml.XmlNodeType XmlDeclaration;        // 0x0

    }

    // TypeToken: 0x20000ED
    public class XmlQualifiedName
    {
        // Fields
        private static System.Xml.XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate;        // 0x0
        private System.String name;        // 0x10
        private System.String ns;        // 0x18
        private System.Int32 hash;        // 0x20
        public static readonly System.Xml.XmlQualifiedName Empty;        // 0x8

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(System.String name, System.String ns) { }
        private System.String get_Namespace() { }
        private System.String get_Name() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean get_IsEmpty() { }
        private System.String ToString() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean op_Equality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b) { }
        private System.Boolean op_Inequality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b) { }
        private System.String ToString(System.String name, System.String ns) { }
        private System.Xml.XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }
        private System.Boolean IsRandomizedHashingDisabled() { }
        private System.Int32 GetHashCodeOfString(System.String s, System.Int32 length, System.Int64 additionalEntropy) { }
        private System.Void Init(System.String name, System.String ns) { }
        private System.Void SetNamespace(System.String ns) { }
        private System.Void Verify() { }
        private System.Void Atomize(System.Xml.XmlNameTable nameTable) { }
        private System.Xml.XmlQualifiedName Parse(System.String s, System.Xml.IXmlNamespaceResolver nsmgr, System.String& prefix) { }
        private System.Xml.XmlQualifiedName Clone() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000EF
    public class XmlResolver
    {
        // Methods
        private System.Object GetEntity(System.Uri absoluteUri, System.String role, System.Type ofObjectToReturn) { }
        private System.Uri ResolveUri(System.Uri baseUri, System.String relativeUri) { }
        private System.Boolean SupportsType(System.Uri absoluteUri, System.Type type) { }
        private System.Threading.Tasks.Task<System.Object> GetEntityAsync(System.Uri absoluteUri, System.String role, System.Type ofObjectToReturn) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F0
    public class XmlUrlResolver : XmlResolver
    {
        // Fields
        private static System.Object s_DownloadManager;        // 0x0
        private System.Net.ICredentials _credentials;        // 0x10
        private System.Net.IWebProxy _proxy;        // 0x18
        private System.Net.Cache.RequestCachePolicy _cachePolicy;        // 0x20

        // Methods
        private System.Xml.XmlDownloadManager get_DownloadManager() { }
        private System.Void .ctor() { }
        private System.Object GetEntity(System.Uri absoluteUri, System.String role, System.Type ofObjectToReturn) { }
        private System.Uri ResolveUri(System.Uri baseUri, System.String relativeUri) { }
        private System.Threading.Tasks.Task<System.Object> GetEntityAsync(System.Uri absoluteUri, System.String role, System.Type ofObjectToReturn) { }

    }

    // TypeToken: 0x20000F2
    public class BinaryCompatibility
    {
        // Methods
        private System.Boolean get_TargetsAtLeast_Desktop_V4_5_2() { }

    }

    // TypeToken: 0x20000F3
    public class Res
    {
        // Methods
        private System.String GetString(System.String name) { }
        private System.String GetString(System.String name, System.Object[] args) { }

    }

}

namespace System.Xml.Schema
{

    // TypeToken: 0x200015D
    public class AxisElement
    {
        // Fields
        private System.Xml.Schema.DoubleLinkAxis curNode;        // 0x10
        private System.Int32 rootDepth;        // 0x18
        private System.Int32 curDepth;        // 0x1C
        private System.Boolean isMatch;        // 0x20

        // Methods
        private System.Xml.Schema.DoubleLinkAxis get_CurNode() { }
        private System.Void .ctor(System.Xml.Schema.DoubleLinkAxis node, System.Int32 depth) { }
        private System.Void SetDepth(System.Int32 depth) { }
        private System.Void MoveToParent(System.Int32 depth, System.Xml.Schema.ForwardAxis parent) { }
        private System.Boolean MoveToChild(System.String name, System.String URN, System.Int32 depth, System.Xml.Schema.ForwardAxis parent) { }

    }

    // TypeToken: 0x200015E
    public class AxisStack
    {
        // Fields
        private System.Collections.ArrayList _stack;        // 0x10
        private System.Xml.Schema.ForwardAxis _subtree;        // 0x18
        private System.Xml.Schema.ActiveAxis _parent;        // 0x20

        // Methods
        private System.Xml.Schema.ForwardAxis get_Subtree() { }
        private System.Int32 get_Length() { }
        private System.Void .ctor(System.Xml.Schema.ForwardAxis faxis, System.Xml.Schema.ActiveAxis parent) { }
        private System.Void Push(System.Int32 depth) { }
        private System.Void Pop() { }
        private System.Boolean Equal(System.String thisname, System.String thisURN, System.String name, System.String URN) { }
        private System.Void MoveToParent(System.String name, System.String URN, System.Int32 depth) { }
        private System.Boolean MoveToChild(System.String name, System.String URN, System.Int32 depth) { }
        private System.Boolean MoveToAttribute(System.String name, System.String URN, System.Int32 depth) { }

    }

    // TypeToken: 0x200015F
    public class ActiveAxis
    {
        // Fields
        private System.Int32 _currentDepth;        // 0x10
        private System.Boolean _isActive;        // 0x14
        private System.Xml.Schema.Asttree _axisTree;        // 0x18
        private System.Collections.ArrayList _axisStack;        // 0x20

        // Methods
        private System.Int32 get_CurrentDepth() { }
        private System.Void Reactivate() { }
        private System.Void .ctor(System.Xml.Schema.Asttree axisTree) { }
        private System.Boolean MoveToStartElement(System.String localname, System.String URN) { }
        private System.Boolean EndElement(System.String localname, System.String URN) { }
        private System.Boolean MoveToAttribute(System.String localname, System.String URN) { }

    }

    // TypeToken: 0x2000160
    public class DoubleLinkAxis : Axis
    {
        // Fields
        private MS.Internal.Xml.XPath.Axis next;        // 0x40

        // Methods
        private MS.Internal.Xml.XPath.Axis get_Next() { }
        private System.Void set_Next(MS.Internal.Xml.XPath.Axis value) { }
        private System.Void .ctor(MS.Internal.Xml.XPath.Axis axis, System.Xml.Schema.DoubleLinkAxis inputaxis) { }
        private System.Xml.Schema.DoubleLinkAxis ConvertTree(MS.Internal.Xml.XPath.Axis axis) { }

    }

    // TypeToken: 0x2000161
    public class ForwardAxis
    {
        // Fields
        private System.Xml.Schema.DoubleLinkAxis _topNode;        // 0x10
        private System.Xml.Schema.DoubleLinkAxis _rootNode;        // 0x18
        private System.Boolean _isAttribute;        // 0x20
        private System.Boolean _isDss;        // 0x21
        private System.Boolean _isSelfAxis;        // 0x22

        // Methods
        private System.Xml.Schema.DoubleLinkAxis get_RootNode() { }
        private System.Xml.Schema.DoubleLinkAxis get_TopNode() { }
        private System.Boolean get_IsAttribute() { }
        private System.Boolean get_IsDss() { }
        private System.Boolean get_IsSelfAxis() { }
        private System.Void .ctor(System.Xml.Schema.DoubleLinkAxis axis, System.Boolean isdesorself) { }

    }

    // TypeToken: 0x2000162
    public class Asttree
    {
        // Fields
        private System.Collections.ArrayList _fAxisArray;        // 0x10
        private System.String _xpathexpr;        // 0x18
        private System.Boolean _isField;        // 0x20
        private System.Xml.XmlNamespaceManager _nsmgr;        // 0x28

        // Methods
        private System.Collections.ArrayList get_SubtreeArray() { }
        private System.Void .ctor(System.String xPath, System.Boolean isField, System.Xml.XmlNamespaceManager nsmgr) { }
        private System.Boolean IsNameTest(MS.Internal.Xml.XPath.Axis ast) { }
        private System.Boolean IsAttribute(MS.Internal.Xml.XPath.Axis ast) { }
        private System.Boolean IsDescendantOrSelf(MS.Internal.Xml.XPath.Axis ast) { }
        private System.Boolean IsSelf(MS.Internal.Xml.XPath.Axis ast) { }
        private System.Void CompileXPath(System.String xPath, System.Boolean isField, System.Xml.XmlNamespaceManager nsmgr) { }
        private System.Void SetURN(MS.Internal.Xml.XPath.Axis axis, System.Xml.XmlNamespaceManager nsmgr) { }

    }

    // TypeToken: 0x2000163
    public class AutoValidator : BaseValidator
    {
        // Methods
        private System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling) { }
        private System.Boolean get_PreserveWhitespace() { }
        private System.Void Validate() { }
        private System.Void CompleteValidation() { }
        private System.Object FindId(System.String name) { }
        private System.Xml.ValidationType DetectValidationType() { }

    }

    // TypeToken: 0x2000164
    public class BaseProcessor
    {
        // Fields
        private System.Xml.XmlNameTable nameTable;        // 0x10
        private System.Xml.Schema.SchemaNames schemaNames;        // 0x18
        private System.Xml.Schema.ValidationEventHandler eventHandler;        // 0x20
        private System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings;        // 0x28
        private System.Int32 errorCount;        // 0x30
        private System.String NsXml;        // 0x38

        // Methods
        private System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler) { }
        private System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings) { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Xml.Schema.SchemaNames get_SchemaNames() { }
        private System.Xml.Schema.ValidationEventHandler get_EventHandler() { }
        private System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings() { }
        private System.Boolean get_HasErrors() { }
        private System.Void AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item) { }
        private System.Boolean IsValidAttributeGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table) { }
        private System.Boolean IsValidGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table) { }
        private System.Boolean IsValidTypeRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table) { }
        private System.Void SendValidationEvent(System.String code, System.Xml.Schema.XmlSchemaObject source) { }
        private System.Void SendValidationEvent(System.String code, System.String msg, System.Xml.Schema.XmlSchemaObject source) { }
        private System.Void SendValidationEvent(System.String code, System.String msg1, System.String msg2, System.Xml.Schema.XmlSchemaObject source) { }
        private System.Void SendValidationEvent(System.String code, System.String[] args, System.Exception innerException, System.Xml.Schema.XmlSchemaObject source) { }
        private System.Void SendValidationEvent(System.String code, System.String msg1, System.String msg2, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void SendValidationEvent(System.String code, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e) { }
        private System.Void SendValidationEvent(System.String code, System.String msg, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void SendValidationEventNoThrow(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity) { }

    }

    // TypeToken: 0x2000165
    public class BaseValidator
    {
        // Fields
        private System.Xml.Schema.XmlSchemaCollection schemaCollection;        // 0x10
        private System.Xml.IValidationEventHandling eventHandling;        // 0x18
        private System.Xml.XmlNameTable nameTable;        // 0x20
        private System.Xml.Schema.SchemaNames schemaNames;        // 0x28
        private System.Xml.PositionInfo positionInfo;        // 0x30
        private System.Xml.XmlResolver xmlResolver;        // 0x38
        private System.Uri baseUri;        // 0x40
        protected System.Xml.Schema.SchemaInfo schemaInfo;        // 0x48
        protected System.Xml.XmlValidatingReaderImpl reader;        // 0x50
        protected System.Xml.XmlQualifiedName elementName;        // 0x58
        protected System.Xml.Schema.ValidationState context;        // 0x60
        protected System.Text.StringBuilder textValue;        // 0x68
        protected System.String textString;        // 0x70
        protected System.Boolean hasSibling;        // 0x78
        protected System.Boolean checkDatatype;        // 0x79

        // Methods
        private System.Void .ctor(System.Xml.Schema.BaseValidator other) { }
        private System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling) { }
        private System.Xml.XmlValidatingReaderImpl get_Reader() { }
        private System.Xml.Schema.XmlSchemaCollection get_SchemaCollection() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Xml.Schema.SchemaNames get_SchemaNames() { }
        private System.Xml.PositionInfo get_PositionInfo() { }
        private System.Xml.XmlResolver get_XmlResolver() { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Uri get_BaseUri() { }
        private System.Void set_BaseUri(System.Uri value) { }
        private System.Xml.Schema.ValidationEventHandler get_EventHandler() { }
        private System.Xml.Schema.SchemaInfo get_SchemaInfo() { }
        private System.Void set_DtdInfo(System.Xml.IDtdInfo value) { }
        private System.Boolean get_PreserveWhitespace() { }
        private System.Void Validate() { }
        private System.Void CompleteValidation() { }
        private System.Object FindId(System.String name) { }
        private System.Void ValidateText() { }
        private System.Void ValidateWhitespace() { }
        private System.Void SaveTextValue(System.String value) { }
        private System.Void SendValidationEvent(System.String code) { }
        private System.Void SendValidationEvent(System.String code, System.String[] args) { }
        private System.Void SendValidationEvent(System.String code, System.String arg) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e) { }
        private System.Void SendValidationEvent(System.String code, System.String msg, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void SendValidationEvent(System.String code, System.String[] args, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, System.String name, System.Object sender, System.Xml.Schema.ValidationEventHandler eventhandler, System.String baseUri, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, System.String name, System.Xml.IValidationEventHandling eventHandling, System.String baseUriStr, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Xml.Schema.BaseValidator CreateInstance(System.Xml.ValidationType valType, System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling, System.Boolean processIdentityConstraints) { }

    }

    // TypeToken: 0x2000166
    public class BitSet
    {
        // Fields
        private System.Int32 count;        // 0x10
        private System.UInt32[] bits;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 count) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_Item(System.Int32 index) { }
        private System.Void Clear() { }
        private System.Void Set(System.Int32 index) { }
        private System.Boolean Get(System.Int32 index) { }
        private System.Int32 NextSet(System.Int32 startFrom) { }
        private System.Void And(System.Xml.Schema.BitSet other) { }
        private System.Void Or(System.Xml.Schema.BitSet other) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Xml.Schema.BitSet Clone() { }
        private System.Boolean get_IsEmpty() { }
        private System.Boolean Intersects(System.Xml.Schema.BitSet other) { }
        private System.Int32 Subscript(System.Int32 bitIndex) { }
        private System.Void EnsureLength(System.Int32 nRequiredLength) { }

    }

    // TypeToken: 0x2000167
    public class ChameleonKey
    {
        // Fields
        private System.String targetNS;        // 0x10
        private System.Uri chameleonLocation;        // 0x18
        private System.Xml.Schema.XmlSchema originalSchema;        // 0x20
        private System.Int32 hashCode;        // 0x28

        // Methods
        private System.Void .ctor(System.String ns, System.Xml.Schema.XmlSchema originalSchema) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }

    }

    // TypeToken: 0x2000168
    public class CompiledIdentityConstraint
    {
        // Fields
        private System.Xml.XmlQualifiedName name;        // 0x10
        private System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole role;        // 0x18
        private System.Xml.Schema.Asttree selector;        // 0x20
        private System.Xml.Schema.Asttree[] fields;        // 0x28
        private System.Xml.XmlQualifiedName refer;        // 0x30
        public static readonly System.Xml.Schema.CompiledIdentityConstraint Empty;        // 0x0

        // Methods
        private System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole get_Role() { }
        private System.Xml.Schema.Asttree get_Selector() { }
        private System.Xml.Schema.Asttree[] get_Fields() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaIdentityConstraint constraint, System.Xml.XmlNamespaceManager nsmgr) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200016A
    public class ConstraintStruct
    {
        // Fields
        private System.Xml.Schema.CompiledIdentityConstraint constraint;        // 0x10
        private System.Xml.Schema.SelectorActiveAxis axisSelector;        // 0x18
        private System.Collections.ArrayList axisFields;        // 0x20
        private System.Collections.Hashtable qualifiedTable;        // 0x28
        private System.Collections.Hashtable keyrefTable;        // 0x30
        private System.Int32 tableDim;        // 0x38

        // Methods
        private System.Int32 get_TableDim() { }
        private System.Void .ctor(System.Xml.Schema.CompiledIdentityConstraint constraint) { }

    }

    // TypeToken: 0x200016B
    public class LocatedActiveAxis : ActiveAxis
    {
        // Fields
        private System.Int32 column;        // 0x28
        private System.Boolean isMatched;        // 0x2C
        private System.Xml.Schema.KeySequence Ks;        // 0x30

        // Methods
        private System.Int32 get_Column() { }
        private System.Void .ctor(System.Xml.Schema.Asttree astfield, System.Xml.Schema.KeySequence ks, System.Int32 column) { }
        private System.Void Reactivate(System.Xml.Schema.KeySequence ks) { }

    }

    // TypeToken: 0x200016C
    public class SelectorActiveAxis : ActiveAxis
    {
        // Fields
        private System.Xml.Schema.ConstraintStruct cs;        // 0x28
        private System.Collections.ArrayList KSs;        // 0x30
        private System.Int32 KSpointer;        // 0x38

        // Methods
        private System.Int32 get_lastDepth() { }
        private System.Void .ctor(System.Xml.Schema.Asttree axisTree, System.Xml.Schema.ConstraintStruct cs) { }
        private System.Boolean EndElement(System.String localname, System.String URN) { }
        private System.Int32 PushKS(System.Int32 errline, System.Int32 errcol) { }
        private System.Xml.Schema.KeySequence PopKS() { }

    }

    // TypeToken: 0x200016D
    public class KSStruct
    {
        // Fields
        public System.Int32 depth;        // 0x10
        public System.Xml.Schema.KeySequence ks;        // 0x18
        public System.Xml.Schema.LocatedActiveAxis[] fields;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.Schema.KeySequence ks, System.Int32 dim) { }

    }

    // TypeToken: 0x200016E
    public class TypedObject
    {
        // Fields
        private System.Xml.Schema.TypedObject.DecimalStruct dstruct;        // 0x10
        private System.Object ovalue;        // 0x18
        private System.String svalue;        // 0x20
        private System.Xml.Schema.XmlSchemaDatatype xsdtype;        // 0x28
        private System.Int32 dim;        // 0x30
        private System.Boolean isList;        // 0x34

        // Methods
        private System.Int32 get_Dim() { }
        private System.Boolean get_IsList() { }
        private System.Boolean get_IsDecimal() { }
        private System.Decimal[] get_Dvalue() { }
        private System.Object get_Value() { }
        private System.Xml.Schema.XmlSchemaDatatype get_Type() { }
        private System.Void .ctor(System.Object obj, System.String svalue, System.Xml.Schema.XmlSchemaDatatype xsdtype) { }
        private System.String ToString() { }
        private System.Void SetDecimal() { }
        private System.Boolean ListDValueEquals(System.Xml.Schema.TypedObject other) { }
        private System.Boolean Equals(System.Xml.Schema.TypedObject other) { }

    }

    // TypeToken: 0x2000170
    public class KeySequence
    {
        // Fields
        private System.Xml.Schema.TypedObject[] ks;        // 0x10
        private System.Int32 dim;        // 0x18
        private System.Int32 hashcode;        // 0x1C
        private System.Int32 posline;        // 0x20
        private System.Int32 poscol;        // 0x24

        // Methods
        private System.Void .ctor(System.Int32 dim, System.Int32 line, System.Int32 col) { }
        private System.Int32 get_PosLine() { }
        private System.Int32 get_PosCol() { }
        private System.Object get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Object value) { }
        private System.Boolean IsQualified() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000171
    public class UpaException : Exception
    {
        // Fields
        private System.Object particle1;        // 0x90
        private System.Object particle2;        // 0x98

        // Methods
        private System.Void .ctor(System.Object particle1, System.Object particle2) { }
        private System.Object get_Particle1() { }
        private System.Object get_Particle2() { }

    }

    // TypeToken: 0x2000172
    public class SymbolsDictionary
    {
        // Fields
        private System.Int32 last;        // 0x10
        private System.Collections.Hashtable names;        // 0x18
        private System.Collections.Hashtable wildcards;        // 0x20
        private System.Collections.ArrayList particles;        // 0x28
        private System.Object particleLast;        // 0x30
        private System.Boolean isUpaEnforced;        // 0x38

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsUpaEnforced() { }
        private System.Void set_IsUpaEnforced(System.Boolean value) { }
        private System.Int32 AddName(System.Xml.XmlQualifiedName name, System.Object particle) { }
        private System.Void AddNamespaceList(System.Xml.Schema.NamespaceList list, System.Object particle, System.Boolean allowLocal) { }
        private System.Void AddWildcard(System.String wildcard, System.Object particle) { }
        private System.Collections.ICollection GetNamespaceListSymbols(System.Xml.Schema.NamespaceList list) { }
        private System.Int32 get_Item(System.Xml.XmlQualifiedName name) { }
        private System.Boolean Exists(System.Xml.XmlQualifiedName name) { }
        private System.Object GetParticle(System.Int32 symbol) { }
        private System.String NameOf(System.Int32 symbol) { }

    }

    // TypeToken: 0x2000173
    public struct Position
    {
        // Fields
        public System.Int32 symbol;        // 0x10
        public System.Object particle;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 symbol, System.Object particle) { }

    }

    // TypeToken: 0x2000174
    public class Positions
    {
        // Fields
        private System.Collections.ArrayList positions;        // 0x10

        // Methods
        private System.Int32 Add(System.Int32 symbol, System.Object particle) { }
        private System.Xml.Schema.Position get_Item(System.Int32 pos) { }
        private System.Int32 get_Count() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000175
    public class SyntaxTreeNode
    {
        // Methods
        private System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions) { }
        private System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos) { }
        private System.Boolean get_IsNullable() { }
        private System.Boolean get_IsRangeNode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000176
    public class LeafNode : SyntaxTreeNode
    {
        // Fields
        private System.Int32 pos;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 pos) { }
        private System.Int32 get_Pos() { }
        private System.Void set_Pos(System.Int32 value) { }
        private System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions) { }
        private System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos) { }
        private System.Boolean get_IsNullable() { }

    }

    // TypeToken: 0x2000177
    public class NamespaceListNode : SyntaxTreeNode
    {
        // Fields
        protected System.Xml.Schema.NamespaceList namespaceList;        // 0x10
        protected System.Object particle;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.Schema.NamespaceList namespaceList, System.Object particle) { }
        private System.Collections.ICollection GetResolvedSymbols(System.Xml.Schema.SymbolsDictionary symbols) { }
        private System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions) { }
        private System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos) { }
        private System.Boolean get_IsNullable() { }

    }

    // TypeToken: 0x2000178
    public class InteriorNode : SyntaxTreeNode
    {
        // Fields
        private System.Xml.Schema.SyntaxTreeNode leftChild;        // 0x10
        private System.Xml.Schema.SyntaxTreeNode rightChild;        // 0x18

        // Methods
        private System.Xml.Schema.SyntaxTreeNode get_LeftChild() { }
        private System.Void set_LeftChild(System.Xml.Schema.SyntaxTreeNode value) { }
        private System.Xml.Schema.SyntaxTreeNode get_RightChild() { }
        private System.Void set_RightChild(System.Xml.Schema.SyntaxTreeNode value) { }
        private System.Void ExpandTreeNoRecursive(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions) { }
        private System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000179
    public class SequenceNode : InteriorNode
    {
        // Methods
        private System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos) { }
        private System.Boolean get_IsNullable() { }
        private System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017B
    public class ChoiceNode : InteriorNode
    {
        // Methods
        private System.Void ConstructChildPos(System.Xml.Schema.SyntaxTreeNode child, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos) { }
        private System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos) { }
        private System.Boolean get_IsNullable() { }
        private System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017C
    public class PlusNode : InteriorNode
    {
        // Methods
        private System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos) { }
        private System.Boolean get_IsNullable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017D
    public class QmarkNode : InteriorNode
    {
        // Methods
        private System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos) { }
        private System.Boolean get_IsNullable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017E
    public class StarNode : InteriorNode
    {
        // Methods
        private System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos) { }
        private System.Boolean get_IsNullable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017F
    public class LeafRangeNode : LeafNode
    {
        // Fields
        private System.Decimal min;        // 0x18
        private System.Decimal max;        // 0x28
        private System.Xml.Schema.BitSet nextIteration;        // 0x38

        // Methods
        private System.Void .ctor(System.Decimal min, System.Decimal max) { }
        private System.Void .ctor(System.Int32 pos, System.Decimal min, System.Decimal max) { }
        private System.Decimal get_Max() { }
        private System.Decimal get_Min() { }
        private System.Xml.Schema.BitSet get_NextIteration() { }
        private System.Void set_NextIteration(System.Xml.Schema.BitSet value) { }
        private System.Boolean get_IsRangeNode() { }
        private System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions) { }

    }

    // TypeToken: 0x2000180
    public class ContentValidator
    {
        // Fields
        private System.Xml.Schema.XmlSchemaContentType contentType;        // 0x10
        private System.Boolean isOpen;        // 0x14
        private System.Boolean isEmptiable;        // 0x15
        public static readonly System.Xml.Schema.ContentValidator Empty;        // 0x0
        public static readonly System.Xml.Schema.ContentValidator TextOnly;        // 0x8
        public static readonly System.Xml.Schema.ContentValidator Mixed;        // 0x10
        public static readonly System.Xml.Schema.ContentValidator Any;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaContentType contentType) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaContentType contentType, System.Boolean isOpen, System.Boolean isEmptiable) { }
        private System.Xml.Schema.XmlSchemaContentType get_ContentType() { }
        private System.Boolean get_PreserveWhitespace() { }
        private System.Boolean get_IsEmptiable() { }
        private System.Boolean get_IsOpen() { }
        private System.Void set_IsOpen(System.Boolean value) { }
        private System.Void InitValidation(System.Xml.Schema.ValidationState context) { }
        private System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode) { }
        private System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context) { }
        private System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly) { }
        private System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles) { }
        private System.Void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles, System.Boolean global) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000181
    public class ParticleContentValidator : ContentValidator
    {
        // Fields
        private System.Xml.Schema.SymbolsDictionary symbols;        // 0x18
        private System.Xml.Schema.Positions positions;        // 0x20
        private System.Collections.Stack stack;        // 0x28
        private System.Xml.Schema.SyntaxTreeNode contentNode;        // 0x30
        private System.Boolean isPartial;        // 0x38
        private System.Int32 minMaxNodesCount;        // 0x3C
        private System.Boolean enableUpaCheck;        // 0x40

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaContentType contentType) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaContentType contentType, System.Boolean enableUpaCheck) { }
        private System.Void InitValidation(System.Xml.Schema.ValidationState context) { }
        private System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode) { }
        private System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context) { }
        private System.Void Start() { }
        private System.Void OpenGroup() { }
        private System.Void CloseGroup() { }
        private System.Boolean Exists(System.Xml.XmlQualifiedName name) { }
        private System.Void AddName(System.Xml.XmlQualifiedName name, System.Object particle) { }
        private System.Void AddNamespaceList(System.Xml.Schema.NamespaceList namespaceList, System.Object particle) { }
        private System.Void AddLeafNode(System.Xml.Schema.SyntaxTreeNode node) { }
        private System.Void AddChoice() { }
        private System.Void AddSequence() { }
        private System.Void AddStar() { }
        private System.Void AddPlus() { }
        private System.Void AddQMark() { }
        private System.Void AddLeafRange(System.Decimal min, System.Decimal max) { }
        private System.Void Closure(System.Xml.Schema.InteriorNode node) { }
        private System.Xml.Schema.ContentValidator Finish(System.Boolean useDFA) { }
        private System.Xml.Schema.BitSet[] CalculateTotalFollowposForRangeNodes(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.BitSet& posWithRangeTerminals) { }
        private System.Void CheckCMUPAWithLeafRangeNodes(System.Xml.Schema.BitSet curpos) { }
        private System.Xml.Schema.BitSet GetApplicableMinMaxFollowPos(System.Xml.Schema.BitSet curpos, System.Xml.Schema.BitSet posWithRangeTerminals, System.Xml.Schema.BitSet[] minmaxFollowPos) { }
        private System.Void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos) { }
        private System.Void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet curpos) { }
        private System.Int32[][] BuildTransitionTable(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Int32 endMarkerPos) { }

    }

    // TypeToken: 0x2000182
    public class DfaContentValidator : ContentValidator
    {
        // Fields
        private System.Int32[][] transitionTable;        // 0x18
        private System.Xml.Schema.SymbolsDictionary symbols;        // 0x20

        // Methods
        private System.Void .ctor(System.Int32[][] transitionTable, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.XmlSchemaContentType contentType, System.Boolean isOpen, System.Boolean isEmptiable) { }
        private System.Void InitValidation(System.Xml.Schema.ValidationState context) { }
        private System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode) { }
        private System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context) { }
        private System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly) { }
        private System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet) { }

    }

    // TypeToken: 0x2000183
    public class NfaContentValidator : ContentValidator
    {
        // Fields
        private System.Xml.Schema.BitSet firstpos;        // 0x18
        private System.Xml.Schema.BitSet[] followpos;        // 0x20
        private System.Xml.Schema.SymbolsDictionary symbols;        // 0x28
        private System.Xml.Schema.Positions positions;        // 0x30
        private System.Int32 endMarkerPos;        // 0x38

        // Methods
        private System.Void .ctor(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, System.Int32 endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, System.Boolean isOpen, System.Boolean isEmptiable) { }
        private System.Void InitValidation(System.Xml.Schema.ValidationState context) { }
        private System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode) { }
        private System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context) { }
        private System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly) { }
        private System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet) { }

    }

    // TypeToken: 0x2000184
    public struct RangePositionInfo
    {
        // Fields
        public System.Xml.Schema.BitSet curpos;        // 0x10
        public System.Decimal[] rangeCounters;        // 0x18

    }

    // TypeToken: 0x2000185
    public class RangeContentValidator : ContentValidator
    {
        // Fields
        private System.Xml.Schema.BitSet firstpos;        // 0x18
        private System.Xml.Schema.BitSet[] followpos;        // 0x20
        private System.Xml.Schema.BitSet positionsWithRangeTerminals;        // 0x28
        private System.Xml.Schema.SymbolsDictionary symbols;        // 0x30
        private System.Xml.Schema.Positions positions;        // 0x38
        private System.Int32 minMaxNodesCount;        // 0x40
        private System.Int32 endMarkerPos;        // 0x44

        // Methods
        private System.Void .ctor(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, System.Int32 endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, System.Boolean isEmptiable, System.Xml.Schema.BitSet positionsWithRangeTerminals, System.Int32 minmaxNodesCount) { }
        private System.Void InitValidation(System.Xml.Schema.ValidationState context) { }
        private System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode) { }
        private System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context) { }
        private System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly) { }
        private System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet) { }

    }

    // TypeToken: 0x2000186
    public class AllElementsContentValidator : ContentValidator
    {
        // Fields
        private System.Collections.Hashtable elements;        // 0x18
        private System.Object[] particles;        // 0x20
        private System.Xml.Schema.BitSet isRequired;        // 0x28
        private System.Int32 countRequired;        // 0x30

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaContentType contentType, System.Int32 size, System.Boolean isEmptiable) { }
        private System.Boolean AddElement(System.Xml.XmlQualifiedName name, System.Object particle, System.Boolean isEmptiable) { }
        private System.Boolean get_IsEmptiable() { }
        private System.Void InitValidation(System.Xml.Schema.ValidationState context) { }
        private System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode) { }
        private System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context) { }
        private System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly) { }
        private System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet) { }

    }

    // TypeToken: 0x2000187
    public struct XmlSchemaDatatypeVariety
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaDatatypeVariety Atomic;        // 0x0
        public static System.Xml.Schema.XmlSchemaDatatypeVariety List;        // 0x0
        public static System.Xml.Schema.XmlSchemaDatatypeVariety Union;        // 0x0

    }

    // TypeToken: 0x2000188
    public class XsdSimpleValue
    {
        // Fields
        private System.Xml.Schema.XmlSchemaSimpleType xmlType;        // 0x10
        private System.Object typedValue;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaSimpleType st, System.Object value) { }
        private System.Xml.Schema.XmlSchemaSimpleType get_XmlType() { }
        private System.Object get_TypedValue() { }

    }

    // TypeToken: 0x2000189
    public struct RestrictionFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.RestrictionFlags Length;        // 0x0
        public static System.Xml.Schema.RestrictionFlags MinLength;        // 0x0
        public static System.Xml.Schema.RestrictionFlags MaxLength;        // 0x0
        public static System.Xml.Schema.RestrictionFlags Pattern;        // 0x0
        public static System.Xml.Schema.RestrictionFlags Enumeration;        // 0x0
        public static System.Xml.Schema.RestrictionFlags WhiteSpace;        // 0x0
        public static System.Xml.Schema.RestrictionFlags MaxInclusive;        // 0x0
        public static System.Xml.Schema.RestrictionFlags MaxExclusive;        // 0x0
        public static System.Xml.Schema.RestrictionFlags MinInclusive;        // 0x0
        public static System.Xml.Schema.RestrictionFlags MinExclusive;        // 0x0
        public static System.Xml.Schema.RestrictionFlags TotalDigits;        // 0x0
        public static System.Xml.Schema.RestrictionFlags FractionDigits;        // 0x0

    }

    // TypeToken: 0x200018A
    public struct XmlSchemaWhiteSpace
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaWhiteSpace Preserve;        // 0x0
        public static System.Xml.Schema.XmlSchemaWhiteSpace Replace;        // 0x0
        public static System.Xml.Schema.XmlSchemaWhiteSpace Collapse;        // 0x0

    }

    // TypeToken: 0x200018B
    public class RestrictionFacets
    {
        // Fields
        private System.Int32 Length;        // 0x10
        private System.Int32 MinLength;        // 0x14
        private System.Int32 MaxLength;        // 0x18
        private System.Collections.ArrayList Patterns;        // 0x20
        private System.Collections.ArrayList Enumeration;        // 0x28
        private System.Xml.Schema.XmlSchemaWhiteSpace WhiteSpace;        // 0x30
        private System.Object MaxInclusive;        // 0x38
        private System.Object MaxExclusive;        // 0x40
        private System.Object MinInclusive;        // 0x48
        private System.Object MinExclusive;        // 0x50
        private System.Int32 TotalDigits;        // 0x58
        private System.Int32 FractionDigits;        // 0x5C
        private System.Xml.Schema.RestrictionFlags Flags;        // 0x60
        private System.Xml.Schema.RestrictionFlags FixedFlags;        // 0x64

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018C
    public class DatatypeImplementation : XmlSchemaDatatype
    {
        // Fields
        private System.Xml.Schema.XmlSchemaDatatypeVariety variety;        // 0x10
        private System.Xml.Schema.RestrictionFacets restriction;        // 0x18
        private System.Xml.Schema.DatatypeImplementation baseType;        // 0x20
        private System.Xml.Schema.XmlValueConverter valueConverter;        // 0x28
        private System.Xml.Schema.XmlSchemaType parentSchemaType;        // 0x30
        private static System.Collections.Hashtable builtinTypes;        // 0x0
        private static System.Xml.Schema.XmlSchemaSimpleType[] enumToTypeCode;        // 0x8
        private static System.Xml.Schema.XmlSchemaSimpleType anySimpleType;        // 0x10
        private static System.Xml.Schema.XmlSchemaSimpleType anyAtomicType;        // 0x18
        private static System.Xml.Schema.XmlSchemaSimpleType untypedAtomicType;        // 0x20
        private static System.Xml.Schema.XmlSchemaSimpleType yearMonthDurationType;        // 0x28
        private static System.Xml.Schema.XmlSchemaSimpleType dayTimeDurationType;        // 0x30
        private static System.Xml.Schema.XmlSchemaSimpleType normalizedStringTypeV1Compat;        // 0x38
        private static System.Xml.Schema.XmlSchemaSimpleType tokenTypeV1Compat;        // 0x40
        private static System.Xml.XmlQualifiedName QnAnySimpleType;        // 0x48
        private static System.Xml.XmlQualifiedName QnAnyType;        // 0x50
        private static System.Xml.Schema.FacetsChecker stringFacetsChecker;        // 0x58
        private static System.Xml.Schema.FacetsChecker miscFacetsChecker;        // 0x60
        private static System.Xml.Schema.FacetsChecker numeric2FacetsChecker;        // 0x68
        private static System.Xml.Schema.FacetsChecker binaryFacetsChecker;        // 0x70
        private static System.Xml.Schema.FacetsChecker dateTimeFacetsChecker;        // 0x78
        private static System.Xml.Schema.FacetsChecker durationFacetsChecker;        // 0x80
        private static System.Xml.Schema.FacetsChecker listFacetsChecker;        // 0x88
        private static System.Xml.Schema.FacetsChecker qnameFacetsChecker;        // 0x90
        private static System.Xml.Schema.FacetsChecker unionFacetsChecker;        // 0x98
        private static readonly System.Xml.Schema.DatatypeImplementation c_anySimpleType;        // 0xA0
        private static readonly System.Xml.Schema.DatatypeImplementation c_anyURI;        // 0xA8
        private static readonly System.Xml.Schema.DatatypeImplementation c_base64Binary;        // 0xB0
        private static readonly System.Xml.Schema.DatatypeImplementation c_boolean;        // 0xB8
        private static readonly System.Xml.Schema.DatatypeImplementation c_byte;        // 0xC0
        private static readonly System.Xml.Schema.DatatypeImplementation c_char;        // 0xC8
        private static readonly System.Xml.Schema.DatatypeImplementation c_date;        // 0xD0
        private static readonly System.Xml.Schema.DatatypeImplementation c_dateTime;        // 0xD8
        private static readonly System.Xml.Schema.DatatypeImplementation c_dateTimeNoTz;        // 0xE0
        private static readonly System.Xml.Schema.DatatypeImplementation c_dateTimeTz;        // 0xE8
        private static readonly System.Xml.Schema.DatatypeImplementation c_day;        // 0xF0
        private static readonly System.Xml.Schema.DatatypeImplementation c_decimal;        // 0xF8
        private static readonly System.Xml.Schema.DatatypeImplementation c_double;        // 0x100
        private static readonly System.Xml.Schema.DatatypeImplementation c_doubleXdr;        // 0x108
        private static readonly System.Xml.Schema.DatatypeImplementation c_duration;        // 0x110
        private static readonly System.Xml.Schema.DatatypeImplementation c_ENTITY;        // 0x118
        private static readonly System.Xml.Schema.DatatypeImplementation c_ENTITIES;        // 0x120
        private static readonly System.Xml.Schema.DatatypeImplementation c_ENUMERATION;        // 0x128
        private static readonly System.Xml.Schema.DatatypeImplementation c_fixed;        // 0x130
        private static readonly System.Xml.Schema.DatatypeImplementation c_float;        // 0x138
        private static readonly System.Xml.Schema.DatatypeImplementation c_floatXdr;        // 0x140
        private static readonly System.Xml.Schema.DatatypeImplementation c_hexBinary;        // 0x148
        private static readonly System.Xml.Schema.DatatypeImplementation c_ID;        // 0x150
        private static readonly System.Xml.Schema.DatatypeImplementation c_IDREF;        // 0x158
        private static readonly System.Xml.Schema.DatatypeImplementation c_IDREFS;        // 0x160
        private static readonly System.Xml.Schema.DatatypeImplementation c_int;        // 0x168
        private static readonly System.Xml.Schema.DatatypeImplementation c_integer;        // 0x170
        private static readonly System.Xml.Schema.DatatypeImplementation c_language;        // 0x178
        private static readonly System.Xml.Schema.DatatypeImplementation c_long;        // 0x180
        private static readonly System.Xml.Schema.DatatypeImplementation c_month;        // 0x188
        private static readonly System.Xml.Schema.DatatypeImplementation c_monthDay;        // 0x190
        private static readonly System.Xml.Schema.DatatypeImplementation c_Name;        // 0x198
        private static readonly System.Xml.Schema.DatatypeImplementation c_NCName;        // 0x1A0
        private static readonly System.Xml.Schema.DatatypeImplementation c_negativeInteger;        // 0x1A8
        private static readonly System.Xml.Schema.DatatypeImplementation c_NMTOKEN;        // 0x1B0
        private static readonly System.Xml.Schema.DatatypeImplementation c_NMTOKENS;        // 0x1B8
        private static readonly System.Xml.Schema.DatatypeImplementation c_nonNegativeInteger;        // 0x1C0
        private static readonly System.Xml.Schema.DatatypeImplementation c_nonPositiveInteger;        // 0x1C8
        private static readonly System.Xml.Schema.DatatypeImplementation c_normalizedString;        // 0x1D0
        private static readonly System.Xml.Schema.DatatypeImplementation c_NOTATION;        // 0x1D8
        private static readonly System.Xml.Schema.DatatypeImplementation c_positiveInteger;        // 0x1E0
        private static readonly System.Xml.Schema.DatatypeImplementation c_QName;        // 0x1E8
        private static readonly System.Xml.Schema.DatatypeImplementation c_QNameXdr;        // 0x1F0
        private static readonly System.Xml.Schema.DatatypeImplementation c_short;        // 0x1F8
        private static readonly System.Xml.Schema.DatatypeImplementation c_string;        // 0x200
        private static readonly System.Xml.Schema.DatatypeImplementation c_time;        // 0x208
        private static readonly System.Xml.Schema.DatatypeImplementation c_timeNoTz;        // 0x210
        private static readonly System.Xml.Schema.DatatypeImplementation c_timeTz;        // 0x218
        private static readonly System.Xml.Schema.DatatypeImplementation c_token;        // 0x220
        private static readonly System.Xml.Schema.DatatypeImplementation c_unsignedByte;        // 0x228
        private static readonly System.Xml.Schema.DatatypeImplementation c_unsignedInt;        // 0x230
        private static readonly System.Xml.Schema.DatatypeImplementation c_unsignedLong;        // 0x238
        private static readonly System.Xml.Schema.DatatypeImplementation c_unsignedShort;        // 0x240
        private static readonly System.Xml.Schema.DatatypeImplementation c_uuid;        // 0x248
        private static readonly System.Xml.Schema.DatatypeImplementation c_year;        // 0x250
        private static readonly System.Xml.Schema.DatatypeImplementation c_yearMonth;        // 0x258
        private static readonly System.Xml.Schema.DatatypeImplementation c_normalizedStringV1Compat;        // 0x260
        private static readonly System.Xml.Schema.DatatypeImplementation c_tokenV1Compat;        // 0x268
        private static readonly System.Xml.Schema.DatatypeImplementation c_anyAtomicType;        // 0x270
        private static readonly System.Xml.Schema.DatatypeImplementation c_dayTimeDuration;        // 0x278
        private static readonly System.Xml.Schema.DatatypeImplementation c_untypedAtomicType;        // 0x280
        private static readonly System.Xml.Schema.DatatypeImplementation c_yearMonthDuration;        // 0x288
        private static readonly System.Xml.Schema.DatatypeImplementation[] c_tokenizedTypes;        // 0x290
        private static readonly System.Xml.Schema.DatatypeImplementation[] c_tokenizedTypesXsd;        // 0x298
        private static readonly System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes;        // 0x2A0
        private static readonly System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes;        // 0x2A8

        // Methods
        private System.Void .cctor() { }
        private System.Xml.Schema.XmlSchemaSimpleType get_AnySimpleType() { }
        private System.Xml.Schema.XmlSchemaSimpleType get_UntypedAtomicType() { }
        private System.Xml.Schema.DatatypeImplementation FromXmlTokenizedType(System.Xml.XmlTokenizedType token) { }
        private System.Xml.Schema.DatatypeImplementation FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token) { }
        private System.Xml.Schema.DatatypeImplementation FromXdrName(System.String name) { }
        private System.Xml.Schema.DatatypeImplementation FromTypeName(System.String name) { }
        private System.Xml.Schema.XmlSchemaSimpleType StartBuiltinType(System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaDatatype dataType) { }
        private System.Void FinishBuiltinType(System.Xml.Schema.XmlSchemaSimpleType derivedType, System.Xml.Schema.XmlSchemaSimpleType baseType) { }
        private System.Void CreateBuiltinTypes() { }
        private System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromTypeCode(System.Xml.Schema.XmlTypeCode typeCode) { }
        private System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromXsdType(System.Xml.XmlQualifiedName qname) { }
        private System.Xml.Schema.XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }
        private System.Xml.Schema.XmlSchemaSimpleType GetTokenTypeV1Compat() { }
        private System.Xml.Schema.XmlSchemaSimpleType[] GetBuiltInTypes() { }
        private System.Xml.Schema.XmlTypeCode GetPrimitiveTypeCode(System.Xml.Schema.XmlTypeCode typeCode) { }
        private System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Int32 minSize, System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.DatatypeImplementation DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller) { }
        private System.Boolean IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean IsEqual(System.Object o1, System.Object o2) { }
        private System.Boolean IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype) { }
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlValueConverter get_ValueConverter() { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Type get_ValueType() { }
        private System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.Schema.RestrictionFacets get_Restriction() { }
        private System.Boolean get_HasLexicalFacets() { }
        private System.Boolean get_HasValueFacets() { }
        private System.Xml.Schema.DatatypeImplementation get_Base() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr) { }
        private System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Boolean createAtomicValue) { }
        private System.Exception TryParseValue(System.Object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Object& typedValue) { }
        private System.String GetTypeName() { }
        private System.Int32 Compare(System.Byte[] value1, System.Byte[] value2) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018E
    public class Datatype_List : Datatype_anySimpleType
    {
        // Fields
        private System.Xml.Schema.DatatypeImplementation itemType;        // 0x38
        private System.Int32 minListSize;        // 0x40

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Void .ctor(System.Xml.Schema.DatatypeImplementation type, System.Int32 minListSize) { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Type get_ValueType() { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Xml.Schema.DatatypeImplementation get_ItemType() { }
        private System.Exception TryParseValue(System.Object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Object& typedValue) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }

    }

    // TypeToken: 0x200018F
    public class Datatype_union : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8
        private System.Xml.Schema.XmlSchemaSimpleType[] types;        // 0x38

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaSimpleType[] types) { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Type get_ValueType() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes() { }
        private System.Boolean HasAtomicMembers() { }
        private System.Boolean IsUnionBaseOf(System.Xml.Schema.DatatypeImplementation derivedType) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Exception TryParseValue(System.Object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000190
    public class Datatype_anySimpleType : DatatypeImplementation
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Type get_ValueType() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Type get_ListValueType() { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000191
    public class Datatype_anyAtomicType : Datatype_anySimpleType
    {
        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000192
    public class Datatype_untypedAtomicType : Datatype_anyAtomicType
    {
        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000193
    public class Datatype_string : Datatype_anySimpleType
    {
        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000194
    public class Datatype_boolean : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000195
    public class Datatype_float : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000196
    public class Datatype_double : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000197
    public class Datatype_decimal : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x10

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000198
    public class Datatype_duration : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000199
    public class Datatype_yearMonthDuration : Datatype_duration
    {
        // Methods
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019A
    public class Datatype_dayTimeDuration : Datatype_duration
    {
        // Methods
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019B
    public class Datatype_dateTimeBase : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8
        private System.Xml.Schema.XsdDateTimeFlags dateTimeFlags;        // 0x38

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor(System.Xml.Schema.XsdDateTimeFlags dateTimeFlags) { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200019C
    public class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019D
    public class Datatype_dateTimeTimeZone : Datatype_dateTimeBase
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019E
    public class Datatype_dateTime : Datatype_dateTimeBase
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019F
    public class Datatype_timeNoTimeZone : Datatype_dateTimeBase
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A0
    public class Datatype_timeTimeZone : Datatype_dateTimeBase
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A1
    public class Datatype_time : Datatype_dateTimeBase
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A2
    public class Datatype_date : Datatype_dateTimeBase
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A3
    public class Datatype_yearMonth : Datatype_dateTimeBase
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A4
    public class Datatype_year : Datatype_dateTimeBase
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A5
    public class Datatype_monthDay : Datatype_dateTimeBase
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A6
    public class Datatype_day : Datatype_dateTimeBase
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A7
    public class Datatype_month : Datatype_dateTimeBase
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A8
    public class Datatype_hexBinary : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001A9
    public class Datatype_base64Binary : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001AA
    public class Datatype_anyURI : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Type get_ValueType() { }
        private System.Boolean get_HasValueFacets() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001AB
    public class Datatype_QName : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001AC
    public class Datatype_normalizedString : Datatype_string
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Boolean get_HasValueFacets() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001AD
    public class Datatype_normalizedStringV1Compat : Datatype_string
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Boolean get_HasValueFacets() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001AE
    public class Datatype_token : Datatype_normalizedString
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001AF
    public class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B0
    public class Datatype_language : Datatype_token
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B1
    public class Datatype_NMTOKEN : Datatype_token
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B2
    public class Datatype_Name : Datatype_token
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B3
    public class Datatype_NCName : Datatype_Name
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B4
    public class Datatype_ID : Datatype_NCName
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B5
    public class Datatype_IDREF : Datatype_NCName
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B6
    public class Datatype_ENTITY : Datatype_NCName
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B7
    public class Datatype_NOTATION : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001B8
    public class Datatype_integer : Datatype_decimal
    {
        // Methods
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B9
    public class Datatype_nonPositiveInteger : Datatype_integer
    {
        // Fields
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x0

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Boolean get_HasValueFacets() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001BA
    public class Datatype_negativeInteger : Datatype_nonPositiveInteger
    {
        // Fields
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x0

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001BB
    public class Datatype_long : Datatype_integer
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x10

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Boolean get_HasValueFacets() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001BC
    public class Datatype_int : Datatype_long
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x10

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001BD
    public class Datatype_short : Datatype_int
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x10

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001BE
    public class Datatype_byte : Datatype_short
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x10

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001BF
    public class Datatype_nonNegativeInteger : Datatype_integer
    {
        // Fields
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x0

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Boolean get_HasValueFacets() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001C0
    public class Datatype_unsignedLong : Datatype_nonNegativeInteger
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x10

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001C1
    public class Datatype_unsignedInt : Datatype_unsignedLong
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x10

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001C2
    public class Datatype_unsignedShort : Datatype_unsignedInt
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x10

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001C3
    public class Datatype_unsignedByte : Datatype_unsignedShort
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x10

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001C4
    public class Datatype_positiveInteger : Datatype_nonNegativeInteger
    {
        // Fields
        private static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker;        // 0x0

        // Methods
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001C5
    public class Datatype_doubleXdr : Datatype_double
    {
        // Methods
        private System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C6
    public class Datatype_floatXdr : Datatype_float
    {
        // Methods
        private System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C7
    public class Datatype_QNameXdr : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr) { }
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001C8
    public class Datatype_ENUMERATION : Datatype_NMTOKEN
    {
        // Methods
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C9
    public class Datatype_char : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001CA
    public class Datatype_fixed : Datatype_decimal
    {
        // Methods
        private System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001CB
    public class Datatype_uuid : Datatype_anySimpleType
    {
        // Fields
        private static readonly System.Type atomicValueType;        // 0x0
        private static readonly System.Type listValueType;        // 0x8

        // Methods
        private System.Type get_ValueType() { }
        private System.Type get_ListValueType() { }
        private System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001CC
    public class DtdValidator : BaseValidator
    {
        // Fields
        private static System.Xml.Schema.DtdValidator.NamespaceManager namespaceManager;        // 0x0
        private System.Xml.HWStack validationStack;        // 0x80
        private System.Collections.Hashtable attPresence;        // 0x88
        private System.Xml.XmlQualifiedName name;        // 0x90
        private System.Collections.Hashtable IDs;        // 0x98
        private System.Xml.Schema.IdRefNode idRefListHead;        // 0xA0
        private System.Boolean processIdentityConstraints;        // 0xA8

        // Methods
        private System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader, System.Xml.IValidationEventHandling eventHandling, System.Boolean processIdentityConstraints) { }
        private System.Void Init() { }
        private System.Void Validate() { }
        private System.Boolean MeetsStandAloneConstraint() { }
        private System.Void ValidatePIComment() { }
        private System.Void ValidateElement() { }
        private System.Void ValidateChildElement() { }
        private System.Void ValidateStartElement() { }
        private System.Void ValidateEndStartElement() { }
        private System.Void ProcessElement() { }
        private System.Void CompleteValidation() { }
        private System.Void ValidateEndElement() { }
        private System.Boolean get_PreserveWhitespace() { }
        private System.Void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, System.String name) { }
        private System.Void CheckValue(System.String value, System.Xml.Schema.SchemaAttDef attdef) { }
        private System.Void AddID(System.String name, System.Object node) { }
        private System.Object FindId(System.String name) { }
        private System.Boolean GenEntity(System.Xml.XmlQualifiedName qname) { }
        private System.Xml.Schema.SchemaEntity GetEntity(System.Xml.XmlQualifiedName qname, System.Boolean fParameterEntity) { }
        private System.Void CheckForwardRefs() { }
        private System.Void Push(System.Xml.XmlQualifiedName elementName) { }
        private System.Boolean Pop() { }
        private System.Void SetDefaultTypedValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.IDtdParserAdapter readerAdapter) { }
        private System.Void CheckDefaultValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.IValidationEventHandling eventHandling, System.String baseUriStr) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001CE
    public class FacetsChecker
    {
        // Methods
        private System.Exception CheckLexicalFacets(System.String& parseString, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Decimal value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Int64 value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Int32 value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Int16 value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Double value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Single value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.String value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Void CheckWhitespaceFacets(System.String& s, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckPatternFacets(System.Xml.Schema.RestrictionFacets restriction, System.String value) { }
        private System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Xml.Schema.RestrictionFacets ConstructRestriction(System.Xml.Schema.DatatypeImplementation datatype, System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable) { }
        private System.Decimal Power(System.Int32 x, System.Int32 y) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D1
    public class Numeric10FacetsChecker : FacetsChecker
    {
        // Fields
        private static readonly System.Char[] signs;        // 0x0
        private System.Decimal maxValue;        // 0x10
        private System.Decimal minValue;        // 0x20

        // Methods
        private System.Void .ctor(System.Decimal minVal, System.Decimal maxVal) { }
        private System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Decimal value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Int64 value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Int32 value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Int16 value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Decimal value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter) { }
        private System.Exception CheckTotalAndFractionDigits(System.Decimal value, System.Int32 totalDigits, System.Int32 fractionDigits, System.Boolean checkTotal, System.Boolean checkFraction) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001D2
    public class Numeric2FacetsChecker : FacetsChecker
    {
        // Methods
        private System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Double value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Single value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Double value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D3
    public class DurationFacetsChecker : FacetsChecker
    {
        // Methods
        private System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.TimeSpan value, System.Collections.ArrayList enumeration) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D4
    public class DateTimeFacetsChecker : FacetsChecker
    {
        // Methods
        private System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.DateTime value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D5
    public class StringFacetsChecker : FacetsChecker
    {
        // Fields
        private static System.Text.RegularExpressions.Regex languagePattern;        // 0x0

        // Methods
        private System.Text.RegularExpressions.Regex get_LanguagePattern() { }
        private System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.String value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.String value, System.Xml.Schema.XmlSchemaDatatype datatype, System.Boolean verifyUri) { }
        private System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.String value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckBuiltInFacets(System.String s, System.Xml.Schema.XmlTypeCode typeCode, System.Boolean verifyUri) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D6
    public class QNameFacetsChecker : FacetsChecker
    {
        // Methods
        private System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Xml.XmlQualifiedName value, System.Collections.ArrayList enumeration) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D7
    public class MiscFacetsChecker : FacetsChecker
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D8
    public class BinaryFacetsChecker : FacetsChecker
    {
        // Methods
        private System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Exception CheckValueFacets(System.Byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Byte[] value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D9
    public class ListFacetsChecker : FacetsChecker
    {
        // Methods
        private System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DA
    public class UnionFacetsChecker : FacetsChecker
    {
        // Methods
        private System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DB
    public interface IXmlSchemaInfo
    {
        // Methods
        private System.Xml.Schema.XmlSchemaValidity get_Validity() { }
        private System.Boolean get_IsDefault() { }
        private System.Boolean get_IsNil() { }
        private System.Xml.Schema.XmlSchemaSimpleType get_MemberType() { }
        private System.Xml.Schema.XmlSchemaType get_SchemaType() { }
        private System.Xml.Schema.XmlSchemaElement get_SchemaElement() { }
        private System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute() { }

    }

    // TypeToken: 0x20001DC
    public class XmlSchemaInference
    {
        // Fields
        private static System.Xml.XmlQualifiedName ST_boolean;        // 0x0
        private static System.Xml.XmlQualifiedName ST_byte;        // 0x8
        private static System.Xml.XmlQualifiedName ST_unsignedByte;        // 0x10
        private static System.Xml.XmlQualifiedName ST_short;        // 0x18
        private static System.Xml.XmlQualifiedName ST_unsignedShort;        // 0x20
        private static System.Xml.XmlQualifiedName ST_int;        // 0x28
        private static System.Xml.XmlQualifiedName ST_unsignedInt;        // 0x30
        private static System.Xml.XmlQualifiedName ST_long;        // 0x38
        private static System.Xml.XmlQualifiedName ST_unsignedLong;        // 0x40
        private static System.Xml.XmlQualifiedName ST_integer;        // 0x48
        private static System.Xml.XmlQualifiedName ST_decimal;        // 0x50
        private static System.Xml.XmlQualifiedName ST_float;        // 0x58
        private static System.Xml.XmlQualifiedName ST_double;        // 0x60
        private static System.Xml.XmlQualifiedName ST_duration;        // 0x68
        private static System.Xml.XmlQualifiedName ST_dateTime;        // 0x70
        private static System.Xml.XmlQualifiedName ST_time;        // 0x78
        private static System.Xml.XmlQualifiedName ST_date;        // 0x80
        private static System.Xml.XmlQualifiedName ST_gYearMonth;        // 0x88
        private static System.Xml.XmlQualifiedName ST_string;        // 0x90
        private static System.Xml.XmlQualifiedName ST_anySimpleType;        // 0x98
        private static System.Xml.XmlQualifiedName[] SimpleTypes;        // 0xA0
        private System.Xml.Schema.XmlSchema rootSchema;        // 0x10
        private System.Xml.Schema.XmlSchemaSet schemaSet;        // 0x18
        private System.Xml.XmlReader xtr;        // 0x20
        private System.Xml.NameTable nametable;        // 0x28
        private System.String TargetNamespace;        // 0x30
        private System.Xml.XmlNamespaceManager NamespaceManager;        // 0x38
        private System.Collections.ArrayList schemaList;        // 0x40
        private System.Xml.Schema.XmlSchemaInference.InferenceOption occurrence;        // 0x48
        private System.Xml.Schema.XmlSchemaInference.InferenceOption typeInference;        // 0x4C

        // Methods
        private System.Void set_Occurrence(System.Xml.Schema.XmlSchemaInference.InferenceOption value) { }
        private System.Xml.Schema.XmlSchemaInference.InferenceOption get_Occurrence() { }
        private System.Void set_TypeInference(System.Xml.Schema.XmlSchemaInference.InferenceOption value) { }
        private System.Void .ctor() { }
        private System.Xml.Schema.XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument) { }
        private System.Xml.Schema.XmlSchemaSet InferSchema1(System.Xml.XmlReader instanceDocument, System.Xml.Schema.XmlSchemaSet schemas) { }
        private System.Xml.Schema.XmlSchemaAttribute AddAttribute(System.String localName, System.String prefix, System.String childURI, System.String attrValue, System.Boolean bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, System.Xml.Schema.XmlSchemaObjectTable compiledAttributes) { }
        private System.Xml.Schema.XmlSchema CreateXmlSchema(System.String targetNS) { }
        private System.Xml.Schema.XmlSchemaElement AddElement(System.String localName, System.String prefix, System.String childURI, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, System.Int32 positionWithinCollection) { }
        private System.Void InferElement(System.Xml.Schema.XmlSchemaElement xse, System.Boolean bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema) { }
        private System.Xml.Schema.XmlSchemaSimpleContentExtension CheckSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType ct) { }
        private System.Xml.Schema.XmlSchemaType GetEffectiveSchemaType(System.Xml.Schema.XmlSchemaElement elem, System.Boolean bCreatingNewType) { }
        private System.Xml.Schema.XmlSchemaElement FindMatchingElement(System.Boolean bCreatingNewType, System.Xml.XmlReader xtr, System.Xml.Schema.XmlSchemaComplexType ct, System.Int32& lastUsedSeqItem, System.Boolean& bParticleChanged, System.Xml.Schema.XmlSchema parentSchema, System.Boolean setMaxoccurs) { }
        private System.Void ProcessAttributes(System.Xml.Schema.XmlSchemaElement& xse, System.Xml.Schema.XmlSchemaType effectiveSchemaType, System.Boolean bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema) { }
        private System.Void MoveAttributes(System.Xml.Schema.XmlSchemaSimpleContentExtension scExtension, System.Xml.Schema.XmlSchemaComplexType ct) { }
        private System.Void MoveAttributes(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleContentExtension, System.Boolean bCreatingNewType) { }
        private System.Xml.Schema.XmlSchemaAttribute FindAttribute(System.Collections.ICollection attributes, System.String attrName) { }
        private System.Xml.Schema.XmlSchemaElement FindGlobalElement(System.String namespaceURI, System.String localName, System.Xml.Schema.XmlSchema& parentSchema) { }
        private System.Xml.Schema.XmlSchemaElement FindElement(System.Xml.Schema.XmlSchemaObjectCollection elements, System.String elementName) { }
        private System.Xml.Schema.XmlSchemaAttribute FindAttributeRef(System.Collections.ICollection attributes, System.String attributeName, System.String nsURI) { }
        private System.Xml.Schema.XmlSchemaElement FindElementRef(System.Xml.Schema.XmlSchemaObjectCollection elements, System.String elementName, System.String nsURI) { }
        private System.Void MakeExistingAttributesOptional(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance) { }
        private System.Void SwitchUseToOptional(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance) { }
        private System.Xml.XmlQualifiedName RefineSimpleType(System.String s, System.Int32& iTypeFlags) { }
        private System.Int32 InferSimpleType(System.String s, System.Boolean& bNeedsRangeCheck) { }
        private System.Int32 DateTime(System.String s, System.Boolean bDate, System.Boolean bTime) { }
        private System.Xml.Schema.XmlSchemaElement CreateNewElementforChoice(System.Xml.Schema.XmlSchemaElement copyElement) { }
        private System.Int32 GetSchemaType(System.Xml.XmlQualifiedName qname) { }
        private System.Void SetMinMaxOccurs(System.Xml.Schema.XmlSchemaElement el, System.Boolean setMaxOccurs) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001DE
    public class XmlSchemaInferenceException : XmlSchemaException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String res, System.String arg) { }
        private System.Void .ctor(System.String res, System.Int32 lineNumber, System.Int32 linePosition) { }

    }

    // TypeToken: 0x20001DF
    public class NamespaceList
    {
        // Fields
        private System.Xml.Schema.NamespaceList.ListType type;        // 0x10
        private System.Collections.Hashtable set;        // 0x18
        private System.String targetNamespace;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String namespaces, System.String targetNamespace) { }
        private System.Xml.Schema.NamespaceList Clone() { }
        private System.Xml.Schema.NamespaceList.ListType get_Type() { }
        private System.String get_Excluded() { }
        private System.Collections.ICollection get_Enumerate() { }
        private System.Boolean Allows(System.String ns) { }
        private System.Boolean Allows(System.Xml.XmlQualifiedName qname) { }
        private System.String ToString() { }
        private System.Boolean IsSubset(System.Xml.Schema.NamespaceList sub, System.Xml.Schema.NamespaceList super) { }
        private System.Xml.Schema.NamespaceList Union(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, System.Boolean v1Compat) { }
        private System.Xml.Schema.NamespaceList CompareSetToOther(System.Xml.Schema.NamespaceList other) { }
        private System.Xml.Schema.NamespaceList Intersection(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, System.Boolean v1Compat) { }
        private System.Void RemoveNamespace(System.String tns) { }

    }

    // TypeToken: 0x20001E1
    public class NamespaceListV1Compat : NamespaceList
    {
        // Methods
        private System.Void .ctor(System.String namespaces, System.String targetNamespace) { }
        private System.Boolean Allows(System.String ns) { }

    }

    // TypeToken: 0x20001E2
    public class Parser
    {
        // Fields
        private System.Xml.Schema.SchemaType schemaType;        // 0x10
        private System.Xml.XmlNameTable nameTable;        // 0x18
        private System.Xml.Schema.SchemaNames schemaNames;        // 0x20
        private System.Xml.Schema.ValidationEventHandler eventHandler;        // 0x28
        private System.Xml.XmlNamespaceManager namespaceManager;        // 0x30
        private System.Xml.XmlReader reader;        // 0x38
        private System.Xml.PositionInfo positionInfo;        // 0x40
        private System.Boolean isProcessNamespaces;        // 0x48
        private System.Int32 schemaXmlDepth;        // 0x4C
        private System.Int32 markupDepth;        // 0x50
        private System.Xml.Schema.SchemaBuilder builder;        // 0x58
        private System.Xml.Schema.XmlSchema schema;        // 0x60
        private System.Xml.Schema.SchemaInfo xdrSchema;        // 0x68
        private System.Xml.XmlResolver xmlResolver;        // 0x70
        private System.Xml.XmlDocument dummyDocument;        // 0x78
        private System.Boolean processMarkup;        // 0x80
        private System.Xml.XmlNode parentNode;        // 0x88
        private System.Xml.XmlNamespaceManager annotationNSManager;        // 0x90
        private System.String xmlns;        // 0x98
        private System.Xml.XmlCharType xmlCharType;        // 0xA0

        // Methods
        private System.Void .ctor(System.Xml.Schema.SchemaType schemaType, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler) { }
        private System.Xml.Schema.SchemaType Parse(System.Xml.XmlReader reader, System.String targetNamespace) { }
        private System.Void StartParsing(System.Xml.XmlReader reader, System.String targetNamespace) { }
        private System.Boolean CheckSchemaRoot(System.Xml.Schema.SchemaType rootType, System.String& code) { }
        private System.Xml.Schema.SchemaType FinishParsing() { }
        private System.Xml.Schema.XmlSchema get_XmlSchema() { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Xml.Schema.SchemaInfo get_XdrSchema() { }
        private System.Boolean ParseReaderNode() { }
        private System.Void ProcessAppInfoDocMarkup(System.Boolean root) { }
        private System.Xml.XmlElement LoadElementNode(System.Boolean root) { }
        private System.Xml.XmlAttribute CreateXmlNsAttribute(System.String prefix, System.String value) { }
        private System.Xml.XmlAttribute LoadAttributeNode() { }
        private System.Xml.XmlEntityReference LoadEntityReferenceInAttribute() { }

    }

    // TypeToken: 0x20001E3
    public struct Compositor
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.Compositor Root;        // 0x0
        public static System.Xml.Schema.Compositor Include;        // 0x0
        public static System.Xml.Schema.Compositor Import;        // 0x0
        public static System.Xml.Schema.Compositor Redefine;        // 0x0

    }

    // TypeToken: 0x20001E4
    public class RedefineEntry
    {
        // Fields
        private System.Xml.Schema.XmlSchemaRedefine redefine;        // 0x10
        private System.Xml.Schema.XmlSchema schemaToUpdate;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaRedefine external, System.Xml.Schema.XmlSchema schema) { }

    }

    // TypeToken: 0x20001E5
    public class Preprocessor : BaseProcessor
    {
        // Fields
        private System.String Xmlns;        // 0x40
        private System.String NsXsi;        // 0x48
        private System.String targetNamespace;        // 0x50
        private System.Xml.Schema.XmlSchema rootSchema;        // 0x58
        private System.Xml.Schema.XmlSchema currentSchema;        // 0x60
        private System.Xml.Schema.XmlSchemaForm elementFormDefault;        // 0x68
        private System.Xml.Schema.XmlSchemaForm attributeFormDefault;        // 0x6C
        private System.Xml.Schema.XmlSchemaDerivationMethod blockDefault;        // 0x70
        private System.Xml.Schema.XmlSchemaDerivationMethod finalDefault;        // 0x74
        private System.Collections.Hashtable schemaLocations;        // 0x78
        private System.Collections.Hashtable chameleonSchemas;        // 0x80
        private System.Collections.Hashtable referenceNamespaces;        // 0x88
        private System.Collections.Hashtable processedExternals;        // 0x90
        private System.Collections.SortedList lockList;        // 0x98
        private System.Xml.XmlReaderSettings readerSettings;        // 0xA0
        private System.Xml.Schema.XmlSchema rootSchemaForRedefine;        // 0xA8
        private System.Collections.ArrayList redefinedList;        // 0xB0
        private static System.Xml.Schema.XmlSchema builtInSchemaForXmlNS;        // 0x0
        private System.Xml.XmlResolver xmlResolver;        // 0xB8

        // Methods
        private System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings) { }
        private System.Boolean Execute(System.Xml.Schema.XmlSchema schema, System.String targetNamespace, System.Boolean loadExternals) { }
        private System.Void Cleanup(System.Xml.Schema.XmlSchema schema) { }
        private System.Void CleanupRedefine(System.Xml.Schema.XmlSchemaExternal include) { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Void set_ReaderSettings(System.Xml.XmlReaderSettings value) { }
        private System.Void set_SchemaLocations(System.Collections.Hashtable value) { }
        private System.Void set_ChameleonSchemas(System.Collections.Hashtable value) { }
        private System.Xml.Schema.XmlSchema get_RootSchema() { }
        private System.Void BuildSchemaList(System.Xml.Schema.XmlSchema schema) { }
        private System.Void LoadExternals(System.Xml.Schema.XmlSchema schema) { }
        private System.Xml.Schema.XmlSchema GetBuildInSchema() { }
        private System.Void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema) { }
        private System.Void ParseUri(System.String uri, System.String code, System.Xml.Schema.XmlSchemaObject sourceSchemaObject) { }
        private System.Void Preprocess(System.Xml.Schema.XmlSchema schema, System.String targetNamespace, System.Collections.ArrayList imports) { }
        private System.Void CopyIncludedComponents(System.Xml.Schema.XmlSchema includedSchema, System.Xml.Schema.XmlSchema schema) { }
        private System.Void PreprocessRedefine(System.Xml.Schema.RedefineEntry redefineEntry) { }
        private System.Void GetIncludedSet(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList includesList) { }
        private System.Xml.Schema.XmlSchema GetParentSchema(System.Xml.Schema.XmlSchemaObject currentSchemaObject) { }
        private System.Void SetSchemaDefaults(System.Xml.Schema.XmlSchema schema) { }
        private System.Int32 CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaGroup redefined) { }
        private System.Void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group) { }
        private System.Void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup) { }
        private System.Void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype) { }
        private System.Void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype) { }
        private System.Void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute) { }
        private System.Void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute) { }
        private System.Void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute) { }
        private System.Void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup) { }
        private System.Void PreprocessElement(System.Xml.Schema.XmlSchemaElement element) { }
        private System.Void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element) { }
        private System.Void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element) { }
        private System.Void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint) { }
        private System.Void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, System.Boolean local) { }
        private System.Void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Boolean local) { }
        private System.Void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group) { }
        private System.Void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation) { }
        private System.Void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent) { }
        private System.Void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso) { }
        private System.Void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso) { }
        private System.Void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, System.String attributeName, System.Xml.XmlQualifiedName value) { }
        private System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, System.String location) { }
        private System.Object GetSchemaEntity(System.Uri ruri) { }
        private System.Xml.Schema.XmlSchema GetChameleonSchema(System.String targetNamespace, System.Xml.Schema.XmlSchema schema) { }
        private System.Void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent) { }
        private System.Void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject) { }
        private System.Void PreprocessAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation) { }

    }

    // TypeToken: 0x20001E6
    public class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo
    {
        // Fields
        private System.String defExpanded;        // 0x60
        private System.Int32 lineNum;        // 0x68
        private System.Int32 linePos;        // 0x6C
        private System.Int32 valueLineNum;        // 0x70
        private System.Int32 valueLinePos;        // 0x74
        private System.Xml.Schema.SchemaAttDef.Reserve reserved;        // 0x78
        private System.Boolean defaultValueChecked;        // 0x7C
        private System.Xml.Schema.XmlSchemaAttribute schemaAttribute;        // 0x80
        public static readonly System.Xml.Schema.SchemaAttDef Empty;        // 0x0

        // Methods
        private System.Void .ctor(System.Xml.XmlQualifiedName name, System.String prefix) { }
        private System.Void .ctor(System.Xml.XmlQualifiedName name) { }
        private System.Void .ctor() { }
        private System.String System.Xml.IDtdAttributeInfo.get_Prefix() { }
        private System.String System.Xml.IDtdAttributeInfo.get_LocalName() { }
        private System.Int32 System.Xml.IDtdAttributeInfo.get_LineNumber() { }
        private System.Int32 System.Xml.IDtdAttributeInfo.get_LinePosition() { }
        private System.Boolean System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }
        private System.Boolean System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }
        private System.Boolean System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }
        private System.String System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }
        private System.Object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }
        private System.Int32 System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }
        private System.Int32 System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }
        private System.Int32 get_LinePosition() { }
        private System.Void set_LinePosition(System.Int32 value) { }
        private System.Int32 get_LineNumber() { }
        private System.Void set_LineNumber(System.Int32 value) { }
        private System.Int32 get_ValueLinePosition() { }
        private System.Void set_ValueLinePosition(System.Int32 value) { }
        private System.Int32 get_ValueLineNumber() { }
        private System.Void set_ValueLineNumber(System.Int32 value) { }
        private System.String get_DefaultValueExpanded() { }
        private System.Void set_DefaultValueExpanded(System.String value) { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Void set_TokenizedType(System.Xml.XmlTokenizedType value) { }
        private System.Xml.Schema.SchemaAttDef.Reserve get_Reserved() { }
        private System.Void set_Reserved(System.Xml.Schema.SchemaAttDef.Reserve value) { }
        private System.Boolean get_DefaultValueChecked() { }
        private System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute() { }
        private System.Void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value) { }
        private System.Void CheckXmlSpace(System.Xml.IValidationEventHandling validationEventHandling) { }
        private System.Xml.Schema.SchemaAttDef Clone() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001E8
    public class SchemaBuilder
    {
        // Methods
        private System.Boolean ProcessElement(System.String prefix, System.String name, System.String ns) { }
        private System.Void ProcessAttribute(System.String prefix, System.String name, System.String ns, System.String value) { }
        private System.Boolean IsContentParsed() { }
        private System.Void ProcessMarkup(System.Xml.XmlNode[] markup) { }
        private System.Void ProcessCData(System.String value) { }
        private System.Void StartChildren() { }
        private System.Void EndChildren() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E9
    public class SchemaCollectionCompiler : BaseProcessor
    {
        // Fields
        private System.Boolean compileContentModel;        // 0x40
        private System.Xml.Schema.XmlSchemaObjectTable examplars;        // 0x48
        private System.Collections.Stack complexTypeStack;        // 0x50
        private System.Xml.Schema.XmlSchema schema;        // 0x58

        // Methods
        private System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler) { }
        private System.Boolean Execute(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.SchemaInfo schemaInfo, System.Boolean compileContentModel) { }
        private System.Void Prepare() { }
        private System.Void Cleanup() { }
        private System.Void Cleanup(System.Xml.Schema.XmlSchema schema) { }
        private System.Void Compile() { }
        private System.Void Output(System.Xml.Schema.SchemaInfo schemaInfo) { }
        private System.Void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute) { }
        private System.Void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup) { }
        private System.Void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType) { }
        private System.Void CleanupElement(System.Xml.Schema.XmlSchemaElement element) { }
        private System.Void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes) { }
        private System.Void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group) { }
        private System.Void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }
        private System.Void CheckSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup) { }
        private System.Void CompileGroup(System.Xml.Schema.XmlSchemaGroup group) { }
        private System.Void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType) { }
        private System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType) { }
        private System.Void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType) { }
        private System.Void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension) { }
        private System.Void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction) { }
        private System.Void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension) { }
        private System.Void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction) { }
        private System.Void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Boolean substitution) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Boolean root, System.Boolean substitution) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element, System.Boolean substitution) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, System.Boolean root, System.Boolean substitution) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, System.Boolean root, System.Boolean substitution) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, System.Boolean root, System.Boolean substitution) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, System.Boolean root, System.Boolean substitution) { }
        private System.Boolean IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle) { }
        private System.Boolean IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement) { }
        private System.Boolean IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny) { }
        private System.Boolean IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny) { }
        private System.Boolean IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny) { }
        private System.Boolean IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, System.Boolean skipEmptableOnly) { }
        private System.Boolean IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, System.Boolean skipEmptableOnly) { }
        private System.Boolean IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll) { }
        private System.Boolean IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice) { }
        private System.Void CalculateSequenceRange(System.Xml.Schema.XmlSchemaSequence sequence, System.Decimal& minOccurs, System.Decimal& maxOccurs) { }
        private System.Boolean IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle) { }
        private System.Boolean IsValidOccurrenceRangeRestriction(System.Decimal minOccurs, System.Decimal maxOccurs, System.Decimal baseMinOccurs, System.Decimal baseMaxOccurs) { }
        private System.Int32 GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection) { }
        private System.Boolean IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, System.Decimal& minOccurs, System.Decimal& maxOccurs) { }
        private System.Void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup) { }
        private System.Void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy) { }
        private System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b) { }
        private System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b) { }
        private System.Void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa) { }
        private System.Void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi) { }
        private System.Void CompileElement(System.Xml.Schema.XmlSchemaElement xe) { }
        private System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Void BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void CompileCompexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name) { }
        private System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name) { }
        private System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name) { }

    }

    // TypeToken: 0x20001EA
    public class SchemaCollectionPreprocessor : BaseProcessor
    {
        // Fields
        private System.Xml.Schema.XmlSchema schema;        // 0x40
        private System.String targetNamespace;        // 0x48
        private System.Boolean buildinIncluded;        // 0x50
        private System.Xml.Schema.XmlSchemaForm elementFormDefault;        // 0x54
        private System.Xml.Schema.XmlSchemaForm attributeFormDefault;        // 0x58
        private System.Xml.Schema.XmlSchemaDerivationMethod blockDefault;        // 0x5C
        private System.Xml.Schema.XmlSchemaDerivationMethod finalDefault;        // 0x60
        private System.Collections.Hashtable schemaLocations;        // 0x68
        private System.Collections.Hashtable referenceNamespaces;        // 0x70
        private System.String Xmlns;        // 0x78
        private System.Xml.XmlResolver xmlResolver;        // 0x80

        // Methods
        private System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler) { }
        private System.Boolean Execute(System.Xml.Schema.XmlSchema schema, System.String targetNamespace, System.Boolean loadExternals, System.Xml.Schema.XmlSchemaCollection xsc) { }
        private System.Void Cleanup(System.Xml.Schema.XmlSchema schema) { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Void LoadExternals(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.XmlSchemaCollection xsc) { }
        private System.Void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema) { }
        private System.Void Preprocess(System.Xml.Schema.XmlSchema schema, System.String targetNamespace, System.Xml.Schema.SchemaCollectionPreprocessor.Compositor compositor) { }
        private System.Void PreprocessRedefine(System.Xml.Schema.XmlSchemaRedefine redefine) { }
        private System.Int32 CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name) { }
        private System.Void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group) { }
        private System.Void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup) { }
        private System.Void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype) { }
        private System.Void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype) { }
        private System.Void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute) { }
        private System.Void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute) { }
        private System.Void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute) { }
        private System.Void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup) { }
        private System.Void PreprocessElement(System.Xml.Schema.XmlSchemaElement element) { }
        private System.Void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element) { }
        private System.Void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element) { }
        private System.Void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint) { }
        private System.Void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, System.Boolean local) { }
        private System.Void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Boolean local) { }
        private System.Void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group) { }
        private System.Void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation) { }
        private System.Void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent) { }
        private System.Void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso) { }
        private System.Void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso) { }
        private System.Void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, System.String attributeName, System.Xml.XmlQualifiedName value) { }
        private System.Void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent) { }
        private System.Void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject) { }
        private System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, System.String location) { }
        private System.IO.Stream GetSchemaEntity(System.Uri ruri) { }

    }

    // TypeToken: 0x20001EC
    public class SchemaDeclBase
    {
        // Fields
        protected System.Xml.XmlQualifiedName name;        // 0x10
        protected System.String prefix;        // 0x18
        protected System.Boolean isDeclaredInExternal;        // 0x20
        protected System.Xml.Schema.SchemaDeclBase.Use presence;        // 0x24
        protected System.Xml.Schema.XmlSchemaType schemaType;        // 0x28
        protected System.Xml.Schema.XmlSchemaDatatype datatype;        // 0x30
        protected System.String defaultValueRaw;        // 0x38
        protected System.Object defaultValueTyped;        // 0x40
        protected System.Int64 maxLength;        // 0x48
        protected System.Int64 minLength;        // 0x50
        protected System.Collections.Generic.List<System.String> values;        // 0x58

        // Methods
        private System.Void .ctor(System.Xml.XmlQualifiedName name, System.String prefix) { }
        private System.Void .ctor() { }
        private System.Xml.XmlQualifiedName get_Name() { }
        private System.Void set_Name(System.Xml.XmlQualifiedName value) { }
        private System.String get_Prefix() { }
        private System.Void set_Prefix(System.String value) { }
        private System.Boolean get_IsDeclaredInExternal() { }
        private System.Void set_IsDeclaredInExternal(System.Boolean value) { }
        private System.Xml.Schema.SchemaDeclBase.Use get_Presence() { }
        private System.Void set_Presence(System.Xml.Schema.SchemaDeclBase.Use value) { }
        private System.Int64 get_MaxLength() { }
        private System.Void set_MaxLength(System.Int64 value) { }
        private System.Int64 get_MinLength() { }
        private System.Void set_MinLength(System.Int64 value) { }
        private System.Xml.Schema.XmlSchemaType get_SchemaType() { }
        private System.Void set_SchemaType(System.Xml.Schema.XmlSchemaType value) { }
        private System.Xml.Schema.XmlSchemaDatatype get_Datatype() { }
        private System.Void set_Datatype(System.Xml.Schema.XmlSchemaDatatype value) { }
        private System.Void AddValue(System.String value) { }
        private System.Collections.Generic.List<System.String> get_Values() { }
        private System.Void set_Values(System.Collections.Generic.List<System.String> value) { }
        private System.String get_DefaultValueRaw() { }
        private System.Void set_DefaultValueRaw(System.String value) { }
        private System.Object get_DefaultValueTyped() { }
        private System.Void set_DefaultValueTyped(System.Object value) { }
        private System.Boolean CheckEnumeration(System.Object pVal) { }
        private System.Boolean CheckValue(System.Object pVal) { }

    }

    // TypeToken: 0x20001EE
    public class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> attdefs;        // 0x60
        private System.Collections.Generic.List<System.Xml.IDtdDefaultAttributeInfo> defaultAttdefs;        // 0x68
        private System.Boolean isIdDeclared;        // 0x70
        private System.Boolean hasNonCDataAttribute;        // 0x71
        private System.Boolean isAbstract;        // 0x72
        private System.Boolean isNillable;        // 0x73
        private System.Boolean hasRequiredAttribute;        // 0x74
        private System.Boolean isNotationDeclared;        // 0x75
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName> prohibitedAttributes;        // 0x78
        private System.Xml.Schema.ContentValidator contentValidator;        // 0x80
        private System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;        // 0x88
        private System.Xml.Schema.XmlSchemaDerivationMethod block;        // 0x90
        private System.Xml.Schema.CompiledIdentityConstraint[] constraints;        // 0x98
        private System.Xml.Schema.XmlSchemaElement schemaElement;        // 0xA0
        private static readonly System.Xml.Schema.SchemaElementDecl Empty;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaDatatype dtype) { }
        private System.Void .ctor(System.Xml.XmlQualifiedName name, System.String prefix) { }
        private System.Xml.Schema.SchemaElementDecl CreateAnyTypeElementDecl() { }
        private System.Boolean System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }
        private System.Xml.IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(System.String prefix, System.String localName) { }
        private System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }
        private System.Boolean get_IsIdDeclared() { }
        private System.Void set_IsIdDeclared(System.Boolean value) { }
        private System.Boolean get_HasNonCDataAttribute() { }
        private System.Void set_HasNonCDataAttribute(System.Boolean value) { }
        private System.Xml.Schema.SchemaElementDecl Clone() { }
        private System.Boolean get_IsAbstract() { }
        private System.Void set_IsAbstract(System.Boolean value) { }
        private System.Boolean get_IsNillable() { }
        private System.Void set_IsNillable(System.Boolean value) { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_Block() { }
        private System.Void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.Boolean get_IsNotationDeclared() { }
        private System.Void set_IsNotationDeclared(System.Boolean value) { }
        private System.Boolean get_HasDefaultAttribute() { }
        private System.Boolean get_HasRequiredAttribute() { }
        private System.Xml.Schema.ContentValidator get_ContentValidator() { }
        private System.Void set_ContentValidator(System.Xml.Schema.ContentValidator value) { }
        private System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute() { }
        private System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value) { }
        private System.Xml.Schema.CompiledIdentityConstraint[] get_Constraints() { }
        private System.Void set_Constraints(System.Xml.Schema.CompiledIdentityConstraint[] value) { }
        private System.Xml.Schema.XmlSchemaElement get_SchemaElement() { }
        private System.Void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value) { }
        private System.Void AddAttDef(System.Xml.Schema.SchemaAttDef attdef) { }
        private System.Xml.Schema.SchemaAttDef GetAttDef(System.Xml.XmlQualifiedName qname) { }
        private System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttDefs() { }
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName> get_ProhibitedAttributes() { }
        private System.Void CheckAttributes(System.Collections.Hashtable presence, System.Boolean standalone) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001EF
    public class SchemaEntity, IDtdEntityInfo
    {
        // Fields
        private System.Xml.XmlQualifiedName qname;        // 0x10
        private System.String url;        // 0x18
        private System.String pubid;        // 0x20
        private System.String text;        // 0x28
        private System.Xml.XmlQualifiedName ndata;        // 0x30
        private System.Int32 lineNumber;        // 0x38
        private System.Int32 linePosition;        // 0x3C
        private System.Boolean isParameter;        // 0x40
        private System.Boolean isExternal;        // 0x41
        private System.Boolean parsingInProgress;        // 0x42
        private System.Boolean isDeclaredInExternal;        // 0x43
        private System.String baseURI;        // 0x48
        private System.String declaredURI;        // 0x50

        // Methods
        private System.Void .ctor(System.Xml.XmlQualifiedName qname, System.Boolean isParameter) { }
        private System.String System.Xml.IDtdEntityInfo.get_Name() { }
        private System.Boolean System.Xml.IDtdEntityInfo.get_IsExternal() { }
        private System.Boolean System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }
        private System.Boolean System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }
        private System.Boolean System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }
        private System.String System.Xml.IDtdEntityInfo.get_BaseUriString() { }
        private System.String System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }
        private System.String System.Xml.IDtdEntityInfo.get_SystemId() { }
        private System.String System.Xml.IDtdEntityInfo.get_PublicId() { }
        private System.String System.Xml.IDtdEntityInfo.get_Text() { }
        private System.Int32 System.Xml.IDtdEntityInfo.get_LineNumber() { }
        private System.Int32 System.Xml.IDtdEntityInfo.get_LinePosition() { }
        private System.Boolean IsPredefinedEntity(System.String n) { }
        private System.Xml.XmlQualifiedName get_Name() { }
        private System.String get_Url() { }
        private System.Void set_Url(System.String value) { }
        private System.String get_Pubid() { }
        private System.Void set_Pubid(System.String value) { }
        private System.Boolean get_IsExternal() { }
        private System.Void set_IsExternal(System.Boolean value) { }
        private System.Boolean get_DeclaredInExternal() { }
        private System.Void set_DeclaredInExternal(System.Boolean value) { }
        private System.Xml.XmlQualifiedName get_NData() { }
        private System.Void set_NData(System.Xml.XmlQualifiedName value) { }
        private System.String get_Text() { }
        private System.Void set_Text(System.String value) { }
        private System.Int32 get_Line() { }
        private System.Void set_Line(System.Int32 value) { }
        private System.Int32 get_Pos() { }
        private System.Void set_Pos(System.Int32 value) { }
        private System.String get_BaseURI() { }
        private System.Void set_BaseURI(System.String value) { }
        private System.Boolean get_ParsingInProgress() { }
        private System.Void set_ParsingInProgress(System.Boolean value) { }
        private System.String get_DeclaredURI() { }
        private System.Void set_DeclaredURI(System.String value) { }

    }

    // TypeToken: 0x20001F0
    public struct AttributeMatchState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.AttributeMatchState AttributeFound;        // 0x0
        public static System.Xml.Schema.AttributeMatchState AnyIdAttributeFound;        // 0x0
        public static System.Xml.Schema.AttributeMatchState UndeclaredElementAndAttribute;        // 0x0
        public static System.Xml.Schema.AttributeMatchState UndeclaredAttribute;        // 0x0
        public static System.Xml.Schema.AttributeMatchState AnyAttributeLax;        // 0x0
        public static System.Xml.Schema.AttributeMatchState AnyAttributeSkip;        // 0x0
        public static System.Xml.Schema.AttributeMatchState ProhibitedAnyAttribute;        // 0x0
        public static System.Xml.Schema.AttributeMatchState ProhibitedAttribute;        // 0x0
        public static System.Xml.Schema.AttributeMatchState AttributeNameMismatch;        // 0x0
        public static System.Xml.Schema.AttributeMatchState ValidateAttributeInvalidCall;        // 0x0

    }

    // TypeToken: 0x20001F1
    public class SchemaInfo, IDtdInfo
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> elementDecls;        // 0x10
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> undeclaredElementDecls;        // 0x18
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> generalEntities;        // 0x20
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> parameterEntities;        // 0x28
        private System.Xml.XmlQualifiedName docTypeName;        // 0x30
        private System.String internalDtdSubset;        // 0x38
        private System.Boolean hasNonCDataAttributes;        // 0x40
        private System.Boolean hasDefaultAttributes;        // 0x41
        private System.Collections.Generic.Dictionary<System.String,System.Boolean> targetNamespaces;        // 0x48
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> attributeDecls;        // 0x50
        private System.Int32 errorCount;        // 0x58
        private System.Xml.Schema.SchemaType schemaType;        // 0x5C
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> elementDeclsByType;        // 0x60
        private System.Collections.Generic.Dictionary<System.String,System.Xml.Schema.SchemaNotation> notations;        // 0x68

        // Methods
        private System.Void .ctor() { }
        private System.Xml.XmlQualifiedName get_DocTypeName() { }
        private System.Void set_DocTypeName(System.Xml.XmlQualifiedName value) { }
        private System.Void set_InternalDtdSubset(System.String value) { }
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDecls() { }
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls() { }
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_GeneralEntities() { }
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_ParameterEntities() { }
        private System.Xml.Schema.SchemaType get_SchemaType() { }
        private System.Void set_SchemaType(System.Xml.Schema.SchemaType value) { }
        private System.Collections.Generic.Dictionary<System.String,System.Boolean> get_TargetNamespaces() { }
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType() { }
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttributeDecls() { }
        private System.Collections.Generic.Dictionary<System.String,System.Xml.Schema.SchemaNotation> get_Notations() { }
        private System.Int32 get_ErrorCount() { }
        private System.Void set_ErrorCount(System.Int32 value) { }
        private System.Xml.Schema.SchemaElementDecl GetElementDecl(System.Xml.XmlQualifiedName qname) { }
        private System.Xml.Schema.SchemaElementDecl GetTypeDecl(System.Xml.XmlQualifiedName qname) { }
        private System.Xml.Schema.XmlSchemaElement GetElement(System.Xml.XmlQualifiedName qname) { }
        private System.Boolean HasSchema(System.String ns) { }
        private System.Boolean Contains(System.String ns) { }
        private System.Xml.Schema.SchemaAttDef GetAttributeXdr(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname) { }
        private System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject partialValidationType, System.Xml.Schema.AttributeMatchState& attributeMatchState) { }
        private System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, System.Boolean& skip) { }
        private System.Void Add(System.Xml.Schema.SchemaInfo sinfo, System.Xml.Schema.ValidationEventHandler eventhandler) { }
        private System.Void Finish() { }
        private System.Boolean System.Xml.IDtdInfo.get_HasDefaultAttributes() { }
        private System.Boolean System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }
        private System.Xml.IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(System.String prefix, System.String localName) { }
        private System.Xml.IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(System.String name) { }
        private System.Xml.XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }
        private System.String System.Xml.IDtdInfo.get_InternalDtdSubset() { }

    }

    // TypeToken: 0x20001F2
    public class SchemaNames
    {
        // Fields
        private System.Xml.XmlNameTable nameTable;        // 0x10
        public System.String NsDataType;        // 0x18
        public System.String NsDataTypeAlias;        // 0x20
        public System.String NsDataTypeOld;        // 0x28
        public System.String NsXml;        // 0x30
        public System.String NsXmlNs;        // 0x38
        public System.String NsXdr;        // 0x40
        public System.String NsXdrAlias;        // 0x48
        public System.String NsXs;        // 0x50
        public System.String NsXsi;        // 0x58
        public System.String XsiType;        // 0x60
        public System.String XsiNil;        // 0x68
        public System.String XsiSchemaLocation;        // 0x70
        public System.String XsiNoNamespaceSchemaLocation;        // 0x78
        public System.String XsdSchema;        // 0x80
        public System.String XdrSchema;        // 0x88
        public System.Xml.XmlQualifiedName QnPCData;        // 0x90
        public System.Xml.XmlQualifiedName QnXml;        // 0x98
        public System.Xml.XmlQualifiedName QnXmlNs;        // 0xA0
        public System.Xml.XmlQualifiedName QnDtDt;        // 0xA8
        public System.Xml.XmlQualifiedName QnXmlLang;        // 0xB0
        public System.Xml.XmlQualifiedName QnName;        // 0xB8
        public System.Xml.XmlQualifiedName QnType;        // 0xC0
        public System.Xml.XmlQualifiedName QnMaxOccurs;        // 0xC8
        public System.Xml.XmlQualifiedName QnMinOccurs;        // 0xD0
        public System.Xml.XmlQualifiedName QnInfinite;        // 0xD8
        public System.Xml.XmlQualifiedName QnModel;        // 0xE0
        public System.Xml.XmlQualifiedName QnOpen;        // 0xE8
        public System.Xml.XmlQualifiedName QnClosed;        // 0xF0
        public System.Xml.XmlQualifiedName QnContent;        // 0xF8
        public System.Xml.XmlQualifiedName QnMixed;        // 0x100
        public System.Xml.XmlQualifiedName QnEmpty;        // 0x108
        public System.Xml.XmlQualifiedName QnEltOnly;        // 0x110
        public System.Xml.XmlQualifiedName QnTextOnly;        // 0x118
        public System.Xml.XmlQualifiedName QnOrder;        // 0x120
        public System.Xml.XmlQualifiedName QnSeq;        // 0x128
        public System.Xml.XmlQualifiedName QnOne;        // 0x130
        public System.Xml.XmlQualifiedName QnMany;        // 0x138
        public System.Xml.XmlQualifiedName QnRequired;        // 0x140
        public System.Xml.XmlQualifiedName QnYes;        // 0x148
        public System.Xml.XmlQualifiedName QnNo;        // 0x150
        public System.Xml.XmlQualifiedName QnString;        // 0x158
        public System.Xml.XmlQualifiedName QnID;        // 0x160
        public System.Xml.XmlQualifiedName QnIDRef;        // 0x168
        public System.Xml.XmlQualifiedName QnIDRefs;        // 0x170
        public System.Xml.XmlQualifiedName QnEntity;        // 0x178
        public System.Xml.XmlQualifiedName QnEntities;        // 0x180
        public System.Xml.XmlQualifiedName QnNmToken;        // 0x188
        public System.Xml.XmlQualifiedName QnNmTokens;        // 0x190
        public System.Xml.XmlQualifiedName QnEnumeration;        // 0x198
        public System.Xml.XmlQualifiedName QnDefault;        // 0x1A0
        public System.Xml.XmlQualifiedName QnXdrSchema;        // 0x1A8
        public System.Xml.XmlQualifiedName QnXdrElementType;        // 0x1B0
        public System.Xml.XmlQualifiedName QnXdrElement;        // 0x1B8
        public System.Xml.XmlQualifiedName QnXdrGroup;        // 0x1C0
        public System.Xml.XmlQualifiedName QnXdrAttributeType;        // 0x1C8
        public System.Xml.XmlQualifiedName QnXdrAttribute;        // 0x1D0
        public System.Xml.XmlQualifiedName QnXdrDataType;        // 0x1D8
        public System.Xml.XmlQualifiedName QnXdrDescription;        // 0x1E0
        public System.Xml.XmlQualifiedName QnXdrExtends;        // 0x1E8
        public System.Xml.XmlQualifiedName QnXdrAliasSchema;        // 0x1F0
        public System.Xml.XmlQualifiedName QnDtType;        // 0x1F8
        public System.Xml.XmlQualifiedName QnDtValues;        // 0x200
        public System.Xml.XmlQualifiedName QnDtMaxLength;        // 0x208
        public System.Xml.XmlQualifiedName QnDtMinLength;        // 0x210
        public System.Xml.XmlQualifiedName QnDtMax;        // 0x218
        public System.Xml.XmlQualifiedName QnDtMin;        // 0x220
        public System.Xml.XmlQualifiedName QnDtMinExclusive;        // 0x228
        public System.Xml.XmlQualifiedName QnDtMaxExclusive;        // 0x230
        public System.Xml.XmlQualifiedName QnTargetNamespace;        // 0x238
        public System.Xml.XmlQualifiedName QnVersion;        // 0x240
        public System.Xml.XmlQualifiedName QnFinalDefault;        // 0x248
        public System.Xml.XmlQualifiedName QnBlockDefault;        // 0x250
        public System.Xml.XmlQualifiedName QnFixed;        // 0x258
        public System.Xml.XmlQualifiedName QnAbstract;        // 0x260
        public System.Xml.XmlQualifiedName QnBlock;        // 0x268
        public System.Xml.XmlQualifiedName QnSubstitutionGroup;        // 0x270
        public System.Xml.XmlQualifiedName QnFinal;        // 0x278
        public System.Xml.XmlQualifiedName QnNillable;        // 0x280
        public System.Xml.XmlQualifiedName QnRef;        // 0x288
        public System.Xml.XmlQualifiedName QnBase;        // 0x290
        public System.Xml.XmlQualifiedName QnDerivedBy;        // 0x298
        public System.Xml.XmlQualifiedName QnNamespace;        // 0x2A0
        public System.Xml.XmlQualifiedName QnProcessContents;        // 0x2A8
        public System.Xml.XmlQualifiedName QnRefer;        // 0x2B0
        public System.Xml.XmlQualifiedName QnPublic;        // 0x2B8
        public System.Xml.XmlQualifiedName QnSystem;        // 0x2C0
        public System.Xml.XmlQualifiedName QnSchemaLocation;        // 0x2C8
        public System.Xml.XmlQualifiedName QnValue;        // 0x2D0
        public System.Xml.XmlQualifiedName QnUse;        // 0x2D8
        public System.Xml.XmlQualifiedName QnForm;        // 0x2E0
        public System.Xml.XmlQualifiedName QnElementFormDefault;        // 0x2E8
        public System.Xml.XmlQualifiedName QnAttributeFormDefault;        // 0x2F0
        public System.Xml.XmlQualifiedName QnItemType;        // 0x2F8
        public System.Xml.XmlQualifiedName QnMemberTypes;        // 0x300
        public System.Xml.XmlQualifiedName QnXPath;        // 0x308
        public System.Xml.XmlQualifiedName QnXsdSchema;        // 0x310
        public System.Xml.XmlQualifiedName QnXsdAnnotation;        // 0x318
        public System.Xml.XmlQualifiedName QnXsdInclude;        // 0x320
        public System.Xml.XmlQualifiedName QnXsdImport;        // 0x328
        public System.Xml.XmlQualifiedName QnXsdElement;        // 0x330
        public System.Xml.XmlQualifiedName QnXsdAttribute;        // 0x338
        public System.Xml.XmlQualifiedName QnXsdAttributeGroup;        // 0x340
        public System.Xml.XmlQualifiedName QnXsdAnyAttribute;        // 0x348
        public System.Xml.XmlQualifiedName QnXsdGroup;        // 0x350
        public System.Xml.XmlQualifiedName QnXsdAll;        // 0x358
        public System.Xml.XmlQualifiedName QnXsdChoice;        // 0x360
        public System.Xml.XmlQualifiedName QnXsdSequence;        // 0x368
        public System.Xml.XmlQualifiedName QnXsdAny;        // 0x370
        public System.Xml.XmlQualifiedName QnXsdNotation;        // 0x378
        public System.Xml.XmlQualifiedName QnXsdSimpleType;        // 0x380
        public System.Xml.XmlQualifiedName QnXsdComplexType;        // 0x388
        public System.Xml.XmlQualifiedName QnXsdUnique;        // 0x390
        public System.Xml.XmlQualifiedName QnXsdKey;        // 0x398
        public System.Xml.XmlQualifiedName QnXsdKeyRef;        // 0x3A0
        public System.Xml.XmlQualifiedName QnXsdSelector;        // 0x3A8
        public System.Xml.XmlQualifiedName QnXsdField;        // 0x3B0
        public System.Xml.XmlQualifiedName QnXsdMinExclusive;        // 0x3B8
        public System.Xml.XmlQualifiedName QnXsdMinInclusive;        // 0x3C0
        public System.Xml.XmlQualifiedName QnXsdMaxInclusive;        // 0x3C8
        public System.Xml.XmlQualifiedName QnXsdMaxExclusive;        // 0x3D0
        public System.Xml.XmlQualifiedName QnXsdTotalDigits;        // 0x3D8
        public System.Xml.XmlQualifiedName QnXsdFractionDigits;        // 0x3E0
        public System.Xml.XmlQualifiedName QnXsdLength;        // 0x3E8
        public System.Xml.XmlQualifiedName QnXsdMinLength;        // 0x3F0
        public System.Xml.XmlQualifiedName QnXsdMaxLength;        // 0x3F8
        public System.Xml.XmlQualifiedName QnXsdEnumeration;        // 0x400
        public System.Xml.XmlQualifiedName QnXsdPattern;        // 0x408
        public System.Xml.XmlQualifiedName QnXsdDocumentation;        // 0x410
        public System.Xml.XmlQualifiedName QnXsdAppinfo;        // 0x418
        public System.Xml.XmlQualifiedName QnSource;        // 0x420
        public System.Xml.XmlQualifiedName QnXsdComplexContent;        // 0x428
        public System.Xml.XmlQualifiedName QnXsdSimpleContent;        // 0x430
        public System.Xml.XmlQualifiedName QnXsdRestriction;        // 0x438
        public System.Xml.XmlQualifiedName QnXsdExtension;        // 0x440
        public System.Xml.XmlQualifiedName QnXsdUnion;        // 0x448
        public System.Xml.XmlQualifiedName QnXsdList;        // 0x450
        public System.Xml.XmlQualifiedName QnXsdWhiteSpace;        // 0x458
        public System.Xml.XmlQualifiedName QnXsdRedefine;        // 0x460
        public System.Xml.XmlQualifiedName QnXsdAnyType;        // 0x468
        private System.Xml.XmlQualifiedName[] TokenToQName;        // 0x470

        // Methods
        private System.Void .ctor(System.Xml.XmlNameTable nameTable) { }
        private System.Void CreateTokenToQNameTable() { }
        private System.Xml.Schema.SchemaType SchemaTypeFromRoot(System.String localName, System.String ns) { }
        private System.Boolean IsXSDRoot(System.String localName, System.String ns) { }
        private System.Boolean IsXDRRoot(System.String localName, System.String ns) { }

    }

    // TypeToken: 0x20001F4
    public class SchemaNamespaceManager : XmlNamespaceManager
    {
        // Fields
        private System.Xml.Schema.XmlSchemaObject node;        // 0x50

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaObject node) { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.String LookupPrefix(System.String ns) { }

    }

    // TypeToken: 0x20001F5
    public class SchemaNotation
    {
        // Fields
        private System.Xml.XmlQualifiedName name;        // 0x10
        private System.String systemLiteral;        // 0x18
        private System.String pubid;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.XmlQualifiedName name) { }
        private System.Xml.XmlQualifiedName get_Name() { }
        private System.String get_SystemLiteral() { }
        private System.Void set_SystemLiteral(System.String value) { }
        private System.String get_Pubid() { }
        private System.Void set_Pubid(System.String value) { }

    }

    // TypeToken: 0x20001F6
    public class Compiler : BaseProcessor
    {
        // Fields
        private System.String restrictionErrorMsg;        // 0x40
        private System.Xml.Schema.XmlSchemaObjectTable attributes;        // 0x48
        private System.Xml.Schema.XmlSchemaObjectTable attributeGroups;        // 0x50
        private System.Xml.Schema.XmlSchemaObjectTable elements;        // 0x58
        private System.Xml.Schema.XmlSchemaObjectTable schemaTypes;        // 0x60
        private System.Xml.Schema.XmlSchemaObjectTable groups;        // 0x68
        private System.Xml.Schema.XmlSchemaObjectTable notations;        // 0x70
        private System.Xml.Schema.XmlSchemaObjectTable examplars;        // 0x78
        private System.Xml.Schema.XmlSchemaObjectTable identityConstraints;        // 0x80
        private System.Collections.Stack complexTypeStack;        // 0x88
        private System.Collections.Hashtable schemasToCompile;        // 0x90
        private System.Collections.Hashtable importedSchemas;        // 0x98
        private System.Xml.Schema.XmlSchema schemaForSchema;        // 0xA0

        // Methods
        private System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchema schemaForSchema, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings) { }
        private System.Boolean Execute(System.Xml.Schema.XmlSchemaSet schemaSet, System.Xml.Schema.SchemaInfo schemaCompiledInfo) { }
        private System.Void Prepare(System.Xml.Schema.XmlSchema schema, System.Boolean cleanup) { }
        private System.Void UpdateSForSSimpleTypes() { }
        private System.Void Output(System.Xml.Schema.SchemaInfo schemaInfo) { }
        private System.Void ImportAllCompiledSchemas(System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Boolean Compile() { }
        private System.Void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute) { }
        private System.Void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup) { }
        private System.Void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType) { }
        private System.Void CleanupElement(System.Xml.Schema.XmlSchemaElement element) { }
        private System.Void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes) { }
        private System.Void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group) { }
        private System.Void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void ProcessSubstitutionGroups() { }
        private System.Void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup) { }
        private System.Void RecursivelyCheckRedefinedGroups(System.Xml.Schema.XmlSchemaGroup redefinedGroup, System.Xml.Schema.XmlSchemaGroup baseGroup) { }
        private System.Void RecursivelyCheckRedefinedAttributeGroups(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup) { }
        private System.Void CompileGroup(System.Xml.Schema.XmlSchemaGroup group) { }
        private System.Void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType) { }
        private System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType) { }
        private System.Void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType) { }
        private System.Void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension) { }
        private System.Void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction) { }
        private System.Void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension) { }
        private System.Void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction) { }
        private System.Void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Void CheckParticleDerivation(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle) { }
        private System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Boolean root) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, System.Boolean root) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, System.Boolean root) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, System.Boolean root) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, System.Boolean root) { }
        private System.Xml.Schema.XmlSchemaParticle CannonicalizePointlessRoot(System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Boolean IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle) { }
        private System.Boolean IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement) { }
        private System.Boolean IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny) { }
        private System.Boolean IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny) { }
        private System.Boolean IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny) { }
        private System.Boolean IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase) { }
        private System.Boolean IsChoiceFromChoiceSubstGroup(System.Xml.Schema.XmlSchemaChoice derivedChoice, System.Xml.Schema.XmlSchemaChoice baseChoice) { }
        private System.Boolean IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, System.Boolean skipEmptableOnly) { }
        private System.Boolean IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll) { }
        private System.Boolean IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice) { }
        private System.Boolean IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle) { }
        private System.Boolean IsValidOccurrenceRangeRestriction(System.Decimal minOccurs, System.Decimal maxOccurs, System.Decimal baseMinOccurs, System.Decimal baseMaxOccurs) { }
        private System.Int32 GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection) { }
        private System.Boolean IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, System.Decimal& minOccurs, System.Decimal& maxOccurs) { }
        private System.Void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup) { }
        private System.Void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy) { }
        private System.Void CheckAtrributeGroupRestriction(System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup derivedAttributeGroup) { }
        private System.Boolean IsProcessContentsRestricted(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaAnyAttribute derivedAttributeWildcard, System.Xml.Schema.XmlSchemaAnyAttribute baseAttributeWildcard) { }
        private System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b) { }
        private System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b) { }
        private System.Void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa) { }
        private System.Void SetDefaultFixed(System.Xml.Schema.XmlSchemaAttribute xa, System.Xml.Schema.SchemaAttDef decl) { }
        private System.Void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi) { }
        private System.Void CompileElement(System.Xml.Schema.XmlSchemaElement xe) { }
        private System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Boolean BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void CompileParticleElements(System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Void CompileComplexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType) { }
        private System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name) { }
        private System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name) { }
        private System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name) { }
        private System.Void CopyPosition(System.Xml.Schema.XmlSchemaAnnotated to, System.Xml.Schema.XmlSchemaAnnotated from, System.Boolean copyParent) { }
        private System.Boolean IsFixedEqual(System.Xml.Schema.SchemaDeclBase baseDecl, System.Xml.Schema.SchemaDeclBase derivedDecl) { }

    }

    // TypeToken: 0x20001F7
    public struct SchemaType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.SchemaType None;        // 0x0
        public static System.Xml.Schema.SchemaType DTD;        // 0x0
        public static System.Xml.Schema.SchemaType XDR;        // 0x0
        public static System.Xml.Schema.SchemaType XSD;        // 0x0

    }

    // TypeToken: 0x20001F8
    public class ValidationEventArgs : EventArgs
    {
        // Fields
        private System.Xml.Schema.XmlSchemaException ex;        // 0x10
        private System.Xml.Schema.XmlSeverityType severity;        // 0x18

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaException ex) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaException ex, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Xml.Schema.XmlSeverityType get_Severity() { }
        private System.Xml.Schema.XmlSchemaException get_Exception() { }

    }

    // TypeToken: 0x20001F9
    public class ValidationEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Xml.Schema.ValidationEventArgs e) { }

    }

    // TypeToken: 0x20001FA
    public struct StateUnion
    {
        // Fields
        public System.Int32 State;        // 0x10
        public System.Int32 AllElementsRequired;        // 0x10
        public System.Int32 CurPosIndex;        // 0x10
        public System.Int32 NumberOfRunningPos;        // 0x10

    }

    // TypeToken: 0x20001FB
    public class ValidationState
    {
        // Fields
        public System.Boolean IsNill;        // 0x10
        public System.Boolean IsDefault;        // 0x11
        public System.Boolean NeedValidateChildren;        // 0x12
        public System.Boolean CheckRequiredAttribute;        // 0x13
        public System.Boolean ValidationSkipped;        // 0x14
        public System.Xml.Schema.XmlSchemaContentProcessing ProcessContents;        // 0x18
        public System.Xml.Schema.XmlSchemaValidity Validity;        // 0x1C
        public System.Xml.Schema.SchemaElementDecl ElementDecl;        // 0x20
        public System.Xml.Schema.SchemaElementDecl ElementDeclBeforeXsi;        // 0x28
        public System.String LocalName;        // 0x30
        public System.String Namespace;        // 0x38
        public System.Xml.Schema.ConstraintStruct[] Constr;        // 0x40
        public System.Xml.Schema.StateUnion CurrentState;        // 0x48
        public System.Boolean HasMatched;        // 0x4C
        public System.Xml.Schema.BitSet[] CurPos;        // 0x50
        public System.Xml.Schema.BitSet AllElementsSet;        // 0x58
        public System.Collections.Generic.List<System.Xml.Schema.RangePositionInfo> RunningPositions;        // 0x60
        public System.Boolean TooComplex;        // 0x68

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001FC
    public class XdrBuilder : SchemaBuilder
    {
        // Fields
        private static readonly System.Int32[] S_XDR_Root_Element;        // 0x0
        private static readonly System.Int32[] S_XDR_Root_SubElements;        // 0x8
        private static readonly System.Int32[] S_XDR_ElementType_SubElements;        // 0x10
        private static readonly System.Int32[] S_XDR_AttributeType_SubElements;        // 0x18
        private static readonly System.Int32[] S_XDR_Group_SubElements;        // 0x20
        private static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes;        // 0x28
        private static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes;        // 0x30
        private static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes;        // 0x38
        private static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes;        // 0x40
        private static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes;        // 0x48
        private static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes;        // 0x50
        private static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes;        // 0x58
        private static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes;        // 0x60
        private static readonly System.Xml.Schema.XdrBuilder.XdrEntry[] S_SchemaEntries;        // 0x68
        private System.Xml.Schema.SchemaInfo _SchemaInfo;        // 0x10
        private System.String _TargetNamespace;        // 0x18
        private System.Xml.XmlReader _reader;        // 0x20
        private System.Xml.PositionInfo positionInfo;        // 0x28
        private System.Xml.Schema.ParticleContentValidator _contentValidator;        // 0x30
        private System.Xml.Schema.XdrBuilder.XdrEntry _CurState;        // 0x38
        private System.Xml.Schema.XdrBuilder.XdrEntry _NextState;        // 0x40
        private System.Xml.HWStack _StateHistory;        // 0x48
        private System.Xml.HWStack _GroupStack;        // 0x50
        private System.String _XdrName;        // 0x58
        private System.String _XdrPrefix;        // 0x60
        private System.Xml.Schema.XdrBuilder.ElementContent _ElementDef;        // 0x68
        private System.Xml.Schema.XdrBuilder.GroupContent _GroupDef;        // 0x70
        private System.Xml.Schema.XdrBuilder.AttributeContent _AttributeDef;        // 0x78
        private System.Xml.Schema.XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes;        // 0x80
        private System.Xml.Schema.XdrBuilder.DeclBaseInfo _BaseDecl;        // 0x88
        private System.Xml.XmlNameTable _NameTable;        // 0x90
        private System.Xml.Schema.SchemaNames _SchemaNames;        // 0x98
        private System.Xml.XmlNamespaceManager _CurNsMgr;        // 0xA0
        private System.String _Text;        // 0xA8
        private System.Xml.Schema.ValidationEventHandler validationEventHandler;        // 0xB0
        private System.Collections.Hashtable _UndeclaredElements;        // 0xB8
        private System.Xml.XmlResolver xmlResolver;        // 0xC0

        // Methods
        private System.Void .ctor(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.SchemaInfo sinfo, System.String targetNamspace, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler) { }
        private System.Boolean ProcessElement(System.String prefix, System.String name, System.String ns) { }
        private System.Void ProcessAttribute(System.String prefix, System.String name, System.String ns, System.String value) { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Boolean LoadSchema(System.String uri) { }
        private System.Boolean IsXdrSchema(System.String uri) { }
        private System.Boolean IsContentParsed() { }
        private System.Void ProcessMarkup(System.Xml.XmlNode[] markup) { }
        private System.Void ProcessCData(System.String value) { }
        private System.Void StartChildren() { }
        private System.Void EndChildren() { }
        private System.Void Push() { }
        private System.Void Pop() { }
        private System.Void PushGroupInfo() { }
        private System.Void PopGroupInfo() { }
        private System.Void XDR_InitRoot(System.Xml.Schema.XdrBuilder builder, System.Object obj) { }
        private System.Void XDR_BuildRoot_Name(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildRoot_ID(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BeginRoot(System.Xml.Schema.XdrBuilder builder) { }
        private System.Void XDR_EndRoot(System.Xml.Schema.XdrBuilder builder) { }
        private System.Void XDR_InitElementType(System.Xml.Schema.XdrBuilder builder, System.Object obj) { }
        private System.Void XDR_BuildElementType_Name(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildElementType_Content(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildElementType_Model(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildElementType_Order(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildElementType_DtType(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildElementType_DtValues(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildElementType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildElementType_DtMinLength(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BeginElementType(System.Xml.Schema.XdrBuilder builder) { }
        private System.Void XDR_EndElementType(System.Xml.Schema.XdrBuilder builder) { }
        private System.Void XDR_InitAttributeType(System.Xml.Schema.XdrBuilder builder, System.Object obj) { }
        private System.Void XDR_BuildAttributeType_Name(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildAttributeType_Required(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildAttributeType_Default(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildAttributeType_DtType(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildAttributeType_DtValues(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildAttributeType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildAttributeType_DtMinLength(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BeginAttributeType(System.Xml.Schema.XdrBuilder builder) { }
        private System.Void XDR_EndAttributeType(System.Xml.Schema.XdrBuilder builder) { }
        private System.Void XDR_InitElement(System.Xml.Schema.XdrBuilder builder, System.Object obj) { }
        private System.Void XDR_BuildElement_Type(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildElement_MinOccurs(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildElement_MaxOccurs(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_EndElement(System.Xml.Schema.XdrBuilder builder) { }
        private System.Void XDR_InitAttribute(System.Xml.Schema.XdrBuilder builder, System.Object obj) { }
        private System.Void XDR_BuildAttribute_Type(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildAttribute_Required(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildAttribute_Default(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BeginAttribute(System.Xml.Schema.XdrBuilder builder) { }
        private System.Void XDR_EndAttribute(System.Xml.Schema.XdrBuilder builder) { }
        private System.Void XDR_InitGroup(System.Xml.Schema.XdrBuilder builder, System.Object obj) { }
        private System.Void XDR_BuildGroup_Order(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildGroup_MinOccurs(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_BuildGroup_MaxOccurs(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix) { }
        private System.Void XDR_EndGroup(System.Xml.Schema.XdrBuilder builder) { }
        private System.Void XDR_InitElementDtType(System.Xml.Schema.XdrBuilder builder, System.Object obj) { }
        private System.Void XDR_EndElementDtType(System.Xml.Schema.XdrBuilder builder) { }
        private System.Void XDR_InitAttributeDtType(System.Xml.Schema.XdrBuilder builder, System.Object obj) { }
        private System.Void XDR_EndAttributeDtType(System.Xml.Schema.XdrBuilder builder) { }
        private System.Boolean GetNextState(System.Xml.XmlQualifiedName qname) { }
        private System.Boolean IsSkipableElement(System.Xml.XmlQualifiedName qname) { }
        private System.Boolean IsSkipableAttribute(System.Xml.XmlQualifiedName qname) { }
        private System.Int32 GetOrder(System.Xml.XmlQualifiedName qname) { }
        private System.Void AddOrder() { }
        private System.Boolean IsYes(System.Object obj, System.Xml.Schema.XdrBuilder builder) { }
        private System.UInt32 ParseMinOccurs(System.Object obj, System.Xml.Schema.XdrBuilder builder) { }
        private System.UInt32 ParseMaxOccurs(System.Object obj, System.Xml.Schema.XdrBuilder builder) { }
        private System.Void HandleMinMax(System.Xml.Schema.ParticleContentValidator pContent, System.UInt32 cMin, System.UInt32 cMax) { }
        private System.Void ParseDtMaxLength(System.UInt32& cVal, System.Object obj, System.Xml.Schema.XdrBuilder builder) { }
        private System.Void ParseDtMinLength(System.UInt32& cVal, System.Object obj, System.Xml.Schema.XdrBuilder builder) { }
        private System.Void CompareMinMaxLength(System.UInt32 cMin, System.UInt32 cMax, System.Xml.Schema.XdrBuilder builder) { }
        private System.Boolean ParseInteger(System.String str, System.UInt32& n) { }
        private System.Void XDR_CheckAttributeDefault(System.Xml.Schema.XdrBuilder.DeclBaseInfo decl, System.Xml.Schema.SchemaAttDef pAttdef) { }
        private System.Void SetAttributePresence(System.Xml.Schema.SchemaAttDef pAttdef, System.Boolean fRequired) { }
        private System.Int32 GetContent(System.Xml.XmlQualifiedName qname) { }
        private System.Boolean GetModel(System.Xml.XmlQualifiedName qname) { }
        private System.Xml.Schema.XmlSchemaDatatype CheckDatatype(System.String str) { }
        private System.Void CheckDefaultAttValue(System.Xml.Schema.SchemaAttDef attDef) { }
        private System.Boolean IsGlobal(System.Int32 flags) { }
        private System.Void SendValidationEvent(System.String code, System.String[] args, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void SendValidationEvent(System.String code) { }
        private System.Void SendValidationEvent(System.String code, System.String msg) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000207
    public class XdrValidator : BaseValidator
    {
        // Fields
        private System.Xml.HWStack validationStack;        // 0x80
        private System.Collections.Hashtable attPresence;        // 0x88
        private System.Xml.XmlQualifiedName name;        // 0x90
        private System.Xml.XmlNamespaceManager nsManager;        // 0x98
        private System.Boolean isProcessContents;        // 0xA0
        private System.Collections.Hashtable IDs;        // 0xA8
        private System.Xml.Schema.IdRefNode idRefListHead;        // 0xB0
        private System.Xml.Schema.Parser inlineSchemaParser;        // 0xB8

        // Methods
        private System.Void .ctor(System.Xml.Schema.BaseValidator validator) { }
        private System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling) { }
        private System.Void Init() { }
        private System.Void Validate() { }
        private System.Void ValidateElement() { }
        private System.Void ValidateChildElement() { }
        private System.Boolean get_IsInlineSchemaStarted() { }
        private System.Void ProcessInlineSchema() { }
        private System.Void ProcessElement() { }
        private System.Void ValidateEndElement() { }
        private System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl() { }
        private System.Void ValidateStartElement() { }
        private System.Void ValidateEndStartElement() { }
        private System.Void LoadSchemaFromLocation(System.String uri) { }
        private System.Void LoadSchema(System.String uri) { }
        private System.Boolean get_HasSchema() { }
        private System.Boolean get_PreserveWhitespace() { }
        private System.Void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, System.String name) { }
        private System.Void CompleteValidation() { }
        private System.Void CheckValue(System.String value, System.Xml.Schema.SchemaAttDef attdef) { }
        private System.Void CheckDefaultValue(System.String value, System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.XmlNamespaceManager nsManager, System.Xml.XmlNameTable NameTable, System.Object sender, System.Xml.Schema.ValidationEventHandler eventhandler, System.String baseUri, System.Int32 lineNo, System.Int32 linePos) { }
        private System.Void AddID(System.String name, System.Object node) { }
        private System.Object FindId(System.String name) { }
        private System.Void Push(System.Xml.XmlQualifiedName elementName) { }
        private System.Void Pop() { }
        private System.Void CheckForwardRefs() { }
        private System.Xml.XmlQualifiedName QualifiedName(System.String name, System.String ns) { }

    }

    // TypeToken: 0x2000208
    public class XmlAtomicValue : XPathItem, ICloneable
    {
        // Fields
        private System.Xml.Schema.XmlSchemaType xmlType;        // 0x10
        private System.Object objVal;        // 0x18
        private System.TypeCode clrType;        // 0x20
        private System.Xml.Schema.XmlAtomicValue.Union unionVal;        // 0x28
        private System.Xml.Schema.XmlAtomicValue.NamespacePrefixForQName nsPrefix;        // 0x30

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Boolean value) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.DateTime value) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Double value) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Int32 value) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Int64 value) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.String value) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.String value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Object value) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Object value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Xml.Schema.XmlSchemaType get_XmlType() { }
        private System.Type get_ValueType() { }
        private System.Object get_TypedValue() { }
        private System.Boolean get_ValueAsBoolean() { }
        private System.DateTime get_ValueAsDateTime() { }
        private System.Double get_ValueAsDouble() { }
        private System.Int32 get_ValueAsInt() { }
        private System.Int64 get_ValueAsLong() { }
        private System.Object ValueAs(System.Type type, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.String get_Value() { }
        private System.String ToString() { }
        private System.String GetPrefixFromQName(System.String value) { }

    }

    // TypeToken: 0x200020B
    public class XmlSchema : XmlSchemaObject
    {
        // Fields
        private System.Xml.Schema.XmlSchemaForm attributeFormDefault;        // 0x38
        private System.Xml.Schema.XmlSchemaForm elementFormDefault;        // 0x3C
        private System.Xml.Schema.XmlSchemaDerivationMethod blockDefault;        // 0x40
        private System.Xml.Schema.XmlSchemaDerivationMethod finalDefault;        // 0x44
        private System.String targetNs;        // 0x48
        private System.String version;        // 0x50
        private System.Xml.Schema.XmlSchemaObjectCollection includes;        // 0x58
        private System.Xml.Schema.XmlSchemaObjectCollection items;        // 0x60
        private System.String id;        // 0x68
        private System.Xml.XmlAttribute[] moreAttributes;        // 0x70
        private System.Boolean isCompiled;        // 0x78
        private System.Boolean isCompiledBySet;        // 0x79
        private System.Boolean isPreprocessed;        // 0x7A
        private System.Boolean isRedefined;        // 0x7B
        private System.Int32 errorCount;        // 0x7C
        private System.Xml.Schema.XmlSchemaObjectTable attributes;        // 0x80
        private System.Xml.Schema.XmlSchemaObjectTable attributeGroups;        // 0x88
        private System.Xml.Schema.XmlSchemaObjectTable elements;        // 0x90
        private System.Xml.Schema.XmlSchemaObjectTable types;        // 0x98
        private System.Xml.Schema.XmlSchemaObjectTable groups;        // 0xA0
        private System.Xml.Schema.XmlSchemaObjectTable notations;        // 0xA8
        private System.Xml.Schema.XmlSchemaObjectTable identityConstraints;        // 0xB0
        private static System.Int32 globalIdCounter;        // 0x0
        private System.Collections.ArrayList importedSchemas;        // 0xB8
        private System.Collections.ArrayList importedNamespaces;        // 0xC0
        private System.Int32 schemaId;        // 0xC8
        private System.Uri baseUri;        // 0xD0
        private System.Boolean isChameleon;        // 0xD8
        private System.Collections.Hashtable ids;        // 0xE0
        private System.Xml.XmlDocument document;        // 0xE8

        // Methods
        private System.Void .ctor() { }
        private System.Xml.Schema.XmlSchema Read(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler) { }
        private System.Boolean CompileSchema(System.Xml.Schema.XmlSchemaCollection xsc, System.Xml.XmlResolver resolver, System.Xml.Schema.SchemaInfo schemaInfo, System.String ns, System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlNameTable nameTable, System.Boolean CompileContentModel) { }
        private System.Void CompileSchemaInSet(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings) { }
        private System.Xml.Schema.XmlSchemaForm get_AttributeFormDefault() { }
        private System.Void set_AttributeFormDefault(System.Xml.Schema.XmlSchemaForm value) { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_BlockDefault() { }
        private System.Void set_BlockDefault(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_FinalDefault() { }
        private System.Void set_FinalDefault(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.Xml.Schema.XmlSchemaForm get_ElementFormDefault() { }
        private System.Void set_ElementFormDefault(System.Xml.Schema.XmlSchemaForm value) { }
        private System.String get_TargetNamespace() { }
        private System.Void set_TargetNamespace(System.String value) { }
        private System.String get_Version() { }
        private System.Void set_Version(System.String value) { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Includes() { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Items() { }
        private System.Boolean get_IsCompiledBySet() { }
        private System.Void set_IsCompiledBySet(System.Boolean value) { }
        private System.Boolean get_IsPreprocessed() { }
        private System.Void set_IsPreprocessed(System.Boolean value) { }
        private System.Boolean get_IsRedefined() { }
        private System.Void set_IsRedefined(System.Boolean value) { }
        private System.Xml.Schema.XmlSchemaObjectTable get_Attributes() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_Elements() { }
        private System.String get_Id() { }
        private System.Void set_Id(System.String value) { }
        private System.Xml.Schema.XmlSchemaObjectTable get_Groups() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_Notations() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_IdentityConstraints() { }
        private System.Uri get_BaseUri() { }
        private System.Void set_BaseUri(System.Uri value) { }
        private System.Int32 get_SchemaId() { }
        private System.Boolean get_IsChameleon() { }
        private System.Void set_IsChameleon(System.Boolean value) { }
        private System.Collections.Hashtable get_Ids() { }
        private System.Xml.XmlDocument get_Document() { }
        private System.Int32 get_ErrorCount() { }
        private System.Void set_ErrorCount(System.Int32 value) { }
        private System.Xml.Schema.XmlSchema Clone() { }
        private System.Xml.Schema.XmlSchema DeepClone() { }
        private System.String get_IdAttribute() { }
        private System.Void set_IdAttribute(System.String value) { }
        private System.Void SetIsCompiled(System.Boolean isCompiled) { }
        private System.Void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes) { }
        private System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation) { }
        private System.Collections.ArrayList get_ImportedSchemas() { }
        private System.Collections.ArrayList get_ImportedNamespaces() { }
        private System.Void GetExternalSchemasList(System.Collections.IList extList, System.Xml.Schema.XmlSchema schema) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200020C
    public class XmlSchemaAll : XmlSchemaGroupBase
    {
        // Fields
        private System.Xml.Schema.XmlSchemaObjectCollection items;        // 0x78

        // Methods
        private System.Xml.Schema.XmlSchemaObjectCollection get_Items() { }
        private System.Boolean get_IsEmpty() { }
        private System.Void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020D
    public class XmlSchemaAnnotated : XmlSchemaObject
    {
        // Fields
        private System.String id;        // 0x38
        private System.Xml.Schema.XmlSchemaAnnotation annotation;        // 0x40
        private System.Xml.XmlAttribute[] moreAttributes;        // 0x48

        // Methods
        private System.String get_Id() { }
        private System.Void set_Id(System.String value) { }
        private System.Xml.Schema.XmlSchemaAnnotation get_Annotation() { }
        private System.Void set_Annotation(System.Xml.Schema.XmlSchemaAnnotation value) { }
        private System.Xml.XmlAttribute[] get_UnhandledAttributes() { }
        private System.Void set_UnhandledAttributes(System.Xml.XmlAttribute[] value) { }
        private System.String get_IdAttribute() { }
        private System.Void set_IdAttribute(System.String value) { }
        private System.Void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes) { }
        private System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020E
    public class XmlSchemaAnnotation : XmlSchemaObject
    {
        // Fields
        private System.String id;        // 0x38
        private System.Xml.Schema.XmlSchemaObjectCollection items;        // 0x40
        private System.Xml.XmlAttribute[] moreAttributes;        // 0x48

        // Methods
        private System.String get_Id() { }
        private System.Void set_Id(System.String value) { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Items() { }
        private System.String get_IdAttribute() { }
        private System.Void set_IdAttribute(System.String value) { }
        private System.Void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020F
    public class XmlSchemaAny : XmlSchemaParticle
    {
        // Fields
        private System.String ns;        // 0x78
        private System.Xml.Schema.XmlSchemaContentProcessing processContents;        // 0x80
        private System.Xml.Schema.NamespaceList namespaceList;        // 0x88

        // Methods
        private System.String get_Namespace() { }
        private System.Void set_Namespace(System.String value) { }
        private System.Void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value) { }
        private System.Xml.Schema.NamespaceList get_NamespaceList() { }
        private System.String get_ResolvedNamespace() { }
        private System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect() { }
        private System.String get_NameString() { }
        private System.Void BuildNamespaceList(System.String targetNamespace) { }
        private System.Void BuildNamespaceListV1Compat(System.String targetNamespace) { }
        private System.Boolean Allows(System.Xml.XmlQualifiedName qname) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000210
    public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
    {
        // Fields
        private System.String ns;        // 0x50
        private System.Xml.Schema.XmlSchemaContentProcessing processContents;        // 0x58
        private System.Xml.Schema.NamespaceList namespaceList;        // 0x60

        // Methods
        private System.Void set_Namespace(System.String value) { }
        private System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContents() { }
        private System.Void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value) { }
        private System.Xml.Schema.NamespaceList get_NamespaceList() { }
        private System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect() { }
        private System.Void BuildNamespaceList(System.String targetNamespace) { }
        private System.Void BuildNamespaceListV1Compat(System.String targetNamespace) { }
        private System.Boolean Allows(System.Xml.XmlQualifiedName qname) { }
        private System.Boolean IsSubset(System.Xml.Schema.XmlSchemaAnyAttribute sub, System.Xml.Schema.XmlSchemaAnyAttribute super) { }
        private System.Xml.Schema.XmlSchemaAnyAttribute Intersection(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, System.Boolean v1Compat) { }
        private System.Xml.Schema.XmlSchemaAnyAttribute Union(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, System.Boolean v1Compat) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000211
    public class XmlSchemaAppInfo : XmlSchemaObject
    {
        // Fields
        private System.String source;        // 0x38
        private System.Xml.XmlNode[] markup;        // 0x40

        // Methods
        private System.Void set_Source(System.String value) { }
        private System.Xml.XmlNode[] get_Markup() { }
        private System.Void set_Markup(System.Xml.XmlNode[] value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000212
    public class XmlSchemaAttribute : XmlSchemaAnnotated
    {
        // Fields
        private System.String defaultValue;        // 0x50
        private System.String fixedValue;        // 0x58
        private System.String name;        // 0x60
        private System.Xml.Schema.XmlSchemaForm form;        // 0x68
        private System.Xml.Schema.XmlSchemaUse use;        // 0x6C
        private System.Xml.XmlQualifiedName refName;        // 0x70
        private System.Xml.XmlQualifiedName typeName;        // 0x78
        private System.Xml.XmlQualifiedName qualifiedName;        // 0x80
        private System.Xml.Schema.XmlSchemaSimpleType type;        // 0x88
        private System.Xml.Schema.XmlSchemaSimpleType attributeType;        // 0x90
        private System.Xml.Schema.SchemaAttDef attDef;        // 0x98

        // Methods
        private System.String get_DefaultValue() { }
        private System.Void set_DefaultValue(System.String value) { }
        private System.String get_FixedValue() { }
        private System.Void set_FixedValue(System.String value) { }
        private System.Xml.Schema.XmlSchemaForm get_Form() { }
        private System.Void set_Form(System.Xml.Schema.XmlSchemaForm value) { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Xml.XmlQualifiedName get_RefName() { }
        private System.Void set_RefName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.XmlQualifiedName get_SchemaTypeName() { }
        private System.Void set_SchemaTypeName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.XmlSchemaSimpleType get_SchemaType() { }
        private System.Void set_SchemaType(System.Xml.Schema.XmlSchemaSimpleType value) { }
        private System.Xml.Schema.XmlSchemaUse get_Use() { }
        private System.Void set_Use(System.Xml.Schema.XmlSchemaUse value) { }
        private System.Xml.XmlQualifiedName get_QualifiedName() { }
        private System.Xml.Schema.XmlSchemaSimpleType get_AttributeSchemaType() { }
        private System.Xml.Schema.XmlSchemaDatatype get_Datatype() { }
        private System.Void SetQualifiedName(System.Xml.XmlQualifiedName value) { }
        private System.Void SetAttributeType(System.Xml.Schema.XmlSchemaSimpleType value) { }
        private System.Xml.Schema.SchemaAttDef get_AttDef() { }
        private System.Void set_AttDef(System.Xml.Schema.SchemaAttDef value) { }
        private System.String get_NameAttribute() { }
        private System.Void set_NameAttribute(System.String value) { }
        private System.Xml.Schema.XmlSchemaObject Clone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000213
    public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
    {
        // Fields
        private System.String name;        // 0x50
        private System.Xml.Schema.XmlSchemaObjectCollection attributes;        // 0x58
        private System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;        // 0x60
        private System.Xml.XmlQualifiedName qname;        // 0x68
        private System.Xml.Schema.XmlSchemaAttributeGroup redefined;        // 0x70
        private System.Xml.Schema.XmlSchemaObjectTable attributeUses;        // 0x78
        private System.Xml.Schema.XmlSchemaAnyAttribute attributeWildcard;        // 0x80
        private System.Int32 selfReferenceCount;        // 0x88

        // Methods
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Attributes() { }
        private System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute() { }
        private System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value) { }
        private System.Xml.XmlQualifiedName get_QualifiedName() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses() { }
        private System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard() { }
        private System.Void set_AttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value) { }
        private System.Xml.Schema.XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }
        private System.Xml.Schema.XmlSchemaAttributeGroup get_Redefined() { }
        private System.Void set_Redefined(System.Xml.Schema.XmlSchemaAttributeGroup value) { }
        private System.Int32 get_SelfReferenceCount() { }
        private System.Void set_SelfReferenceCount(System.Int32 value) { }
        private System.String get_NameAttribute() { }
        private System.Void set_NameAttribute(System.String value) { }
        private System.Void SetQualifiedName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.XmlSchemaObject Clone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000214
    public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
    {
        // Fields
        private System.Xml.XmlQualifiedName refName;        // 0x50

        // Methods
        private System.Xml.XmlQualifiedName get_RefName() { }
        private System.Void set_RefName(System.Xml.XmlQualifiedName value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000215
    public class XmlSchemaChoice : XmlSchemaGroupBase
    {
        // Fields
        private System.Xml.Schema.XmlSchemaObjectCollection items;        // 0x78

        // Methods
        private System.Xml.Schema.XmlSchemaObjectCollection get_Items() { }
        private System.Boolean get_IsEmpty() { }
        private System.Void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000216
    public class XmlSchemaCollection, ICollection, IEnumerable
    {
        // Fields
        private System.Collections.Hashtable collection;        // 0x10
        private System.Xml.XmlNameTable nameTable;        // 0x18
        private System.Xml.Schema.SchemaNames schemaNames;        // 0x20
        private System.Threading.ReaderWriterLock wLock;        // 0x28
        private System.Int32 timeout;        // 0x30
        private System.Boolean isThreadSafe;        // 0x34
        private System.Xml.Schema.ValidationEventHandler validationEventHandler;        // 0x38
        private System.Xml.XmlResolver xmlResolver;        // 0x40

        // Methods
        private System.Void .ctor(System.Xml.XmlNameTable nametable) { }
        private System.Int32 get_Count() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Xml.Schema.XmlSchema get_Item(System.String ns) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Xml.Schema.XmlSchemaCollectionEnumerator GetEnumerator() { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private System.Int32 System.Collections.ICollection.get_Count() { }
        private System.Xml.Schema.SchemaInfo GetSchemaInfo(System.String ns) { }
        private System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt) { }
        private System.Xml.Schema.XmlSchema Add(System.String ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, System.Boolean compile) { }
        private System.Xml.Schema.XmlSchema Add(System.String ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, System.Boolean compile, System.Xml.XmlResolver resolver) { }
        private System.Void Add(System.String ns, System.Xml.Schema.XmlSchemaCollectionNode node) { }
        private System.Xml.Schema.ValidationEventHandler get_EventHandler() { }
        private System.Void set_EventHandler(System.Xml.Schema.ValidationEventHandler value) { }

    }

    // TypeToken: 0x2000217
    public class XmlSchemaCollectionNode
    {
        // Fields
        private System.String namespaceUri;        // 0x10
        private System.Xml.Schema.SchemaInfo schemaInfo;        // 0x18
        private System.Xml.Schema.XmlSchema schema;        // 0x20

        // Methods
        private System.Void set_NamespaceURI(System.String value) { }
        private System.Xml.Schema.SchemaInfo get_SchemaInfo() { }
        private System.Void set_SchemaInfo(System.Xml.Schema.SchemaInfo value) { }
        private System.Xml.Schema.XmlSchema get_Schema() { }
        private System.Void set_Schema(System.Xml.Schema.XmlSchema value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000218
    public class XmlSchemaCollectionEnumerator, IEnumerator
    {
        // Fields
        private System.Collections.IDictionaryEnumerator enumerator;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.Hashtable collection) { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Boolean System.Collections.IEnumerator.MoveNext() { }
        private System.Boolean MoveNext() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Xml.Schema.XmlSchema get_Current() { }
        private System.Xml.Schema.XmlSchemaCollectionNode get_CurrentNode() { }

    }

    // TypeToken: 0x2000219
    public class XmlSchemaCompilationSettings
    {
        // Fields
        private System.Boolean enableUpaCheck;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_EnableUpaCheck() { }

    }

    // TypeToken: 0x200021A
    public class XmlSchemaComplexContent : XmlSchemaContentModel
    {
        // Fields
        private System.Xml.Schema.XmlSchemaContent content;        // 0x50
        private System.Boolean isMixed;        // 0x58
        private System.Boolean hasMixedAttribute;        // 0x59

        // Methods
        private System.Boolean get_IsMixed() { }
        private System.Void set_IsMixed(System.Boolean value) { }
        private System.Xml.Schema.XmlSchemaContent get_Content() { }
        private System.Void set_Content(System.Xml.Schema.XmlSchemaContent value) { }
        private System.Boolean get_HasMixedAttribute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021B
    public class XmlSchemaComplexContentExtension : XmlSchemaContent
    {
        // Fields
        private System.Xml.Schema.XmlSchemaParticle particle;        // 0x50
        private System.Xml.Schema.XmlSchemaObjectCollection attributes;        // 0x58
        private System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;        // 0x60
        private System.Xml.XmlQualifiedName baseTypeName;        // 0x68

        // Methods
        private System.Xml.XmlQualifiedName get_BaseTypeName() { }
        private System.Void set_BaseTypeName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.XmlSchemaParticle get_Particle() { }
        private System.Void set_Particle(System.Xml.Schema.XmlSchemaParticle value) { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Attributes() { }
        private System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute() { }
        private System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value) { }
        private System.Void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021C
    public class XmlSchemaComplexContentRestriction : XmlSchemaContent
    {
        // Fields
        private System.Xml.Schema.XmlSchemaParticle particle;        // 0x50
        private System.Xml.Schema.XmlSchemaObjectCollection attributes;        // 0x58
        private System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;        // 0x60
        private System.Xml.XmlQualifiedName baseTypeName;        // 0x68

        // Methods
        private System.Xml.XmlQualifiedName get_BaseTypeName() { }
        private System.Void set_BaseTypeName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.XmlSchemaParticle get_Particle() { }
        private System.Void set_Particle(System.Xml.Schema.XmlSchemaParticle value) { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Attributes() { }
        private System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute() { }
        private System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value) { }
        private System.Void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021D
    public class XmlSchemaComplexType : XmlSchemaType
    {
        // Fields
        private System.Xml.Schema.XmlSchemaDerivationMethod block;        // 0x98
        private System.Xml.Schema.XmlSchemaContentModel contentModel;        // 0xA0
        private System.Xml.Schema.XmlSchemaParticle particle;        // 0xA8
        private System.Xml.Schema.XmlSchemaObjectCollection attributes;        // 0xB0
        private System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;        // 0xB8
        private System.Xml.Schema.XmlSchemaParticle contentTypeParticle;        // 0xC0
        private System.Xml.Schema.XmlSchemaDerivationMethod blockResolved;        // 0xC8
        private System.Xml.Schema.XmlSchemaObjectTable localElements;        // 0xD0
        private System.Xml.Schema.XmlSchemaObjectTable attributeUses;        // 0xD8
        private System.Xml.Schema.XmlSchemaAnyAttribute attributeWildcard;        // 0xE0
        private static System.Xml.Schema.XmlSchemaComplexType anyTypeLax;        // 0x0
        private static System.Xml.Schema.XmlSchemaComplexType anyTypeSkip;        // 0x8
        private static System.Xml.Schema.XmlSchemaComplexType untypedAnyType;        // 0x10
        private System.Byte pvFlags;        // 0xE8

        // Methods
        private System.Void .cctor() { }
        private System.Xml.Schema.XmlSchemaComplexType CreateAnyType(System.Xml.Schema.XmlSchemaContentProcessing processContents) { }
        private System.Void .ctor() { }
        private System.Xml.Schema.XmlSchemaComplexType get_AnyType() { }
        private System.Xml.Schema.XmlSchemaComplexType get_UntypedAnyType() { }
        private System.Xml.Schema.ContentValidator get_AnyTypeContentValidator() { }
        private System.Boolean get_IsAbstract() { }
        private System.Void set_IsAbstract(System.Boolean value) { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_Block() { }
        private System.Void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.Boolean get_IsMixed() { }
        private System.Void set_IsMixed(System.Boolean value) { }
        private System.Xml.Schema.XmlSchemaContentModel get_ContentModel() { }
        private System.Void set_ContentModel(System.Xml.Schema.XmlSchemaContentModel value) { }
        private System.Xml.Schema.XmlSchemaParticle get_Particle() { }
        private System.Void set_Particle(System.Xml.Schema.XmlSchemaParticle value) { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Attributes() { }
        private System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute() { }
        private System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value) { }
        private System.Xml.Schema.XmlSchemaContentType get_ContentType() { }
        private System.Xml.Schema.XmlSchemaParticle get_ContentTypeParticle() { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses() { }
        private System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_LocalElements() { }
        private System.Void SetContentTypeParticle(System.Xml.Schema.XmlSchemaParticle value) { }
        private System.Void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.Void SetAttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value) { }
        private System.Void set_HasWildCard(System.Boolean value) { }
        private System.Void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes) { }
        private System.Boolean ContainsIdAttribute(System.Boolean findAll) { }
        private System.Xml.Schema.XmlSchemaObject Clone() { }
        private System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema) { }
        private System.Void ClearCompiledState() { }
        private System.Xml.Schema.XmlSchemaObjectCollection CloneAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes) { }
        private System.Xml.Schema.XmlSchemaObjectCollection CloneGroupBaseParticles(System.Xml.Schema.XmlSchemaObjectCollection groupBaseParticles, System.Xml.Schema.XmlSchema parentSchema) { }
        private System.Xml.Schema.XmlSchemaParticle CloneParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema) { }
        private System.Xml.Schema.XmlSchemaForm GetResolvedElementForm(System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaElement element) { }
        private System.Boolean HasParticleRef(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema) { }
        private System.Boolean HasAttributeQNameRef(System.Xml.Schema.XmlSchemaObjectCollection attributes) { }

    }

    // TypeToken: 0x200021E
    public class XmlSchemaContent : XmlSchemaAnnotated
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021F
    public class XmlSchemaContentModel : XmlSchemaAnnotated
    {
        // Methods
        private System.Xml.Schema.XmlSchemaContent get_Content() { }
        private System.Void set_Content(System.Xml.Schema.XmlSchemaContent value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000220
    public struct XmlSchemaContentProcessing
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaContentProcessing None;        // 0x0
        public static System.Xml.Schema.XmlSchemaContentProcessing Skip;        // 0x0
        public static System.Xml.Schema.XmlSchemaContentProcessing Lax;        // 0x0
        public static System.Xml.Schema.XmlSchemaContentProcessing Strict;        // 0x0

    }

    // TypeToken: 0x2000221
    public struct XmlSchemaContentType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaContentType TextOnly;        // 0x0
        public static System.Xml.Schema.XmlSchemaContentType Empty;        // 0x0
        public static System.Xml.Schema.XmlSchemaContentType ElementOnly;        // 0x0
        public static System.Xml.Schema.XmlSchemaContentType Mixed;        // 0x0

    }

    // TypeToken: 0x2000222
    public class XmlSchemaDatatype
    {
        // Methods
        private System.Type get_ValueType() { }
        private System.Xml.XmlTokenizedType get_TokenizedType() { }
        private System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr) { }
        private System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Boolean IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Boolean get_HasLexicalFacets() { }
        private System.Boolean get_HasValueFacets() { }
        private System.Xml.Schema.XmlValueConverter get_ValueConverter() { }
        private System.Xml.Schema.RestrictionFacets get_Restriction() { }
        private System.Int32 Compare(System.Object value1, System.Object value2) { }
        private System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Boolean createAtomicValue) { }
        private System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue) { }
        private System.Exception TryParseValue(System.Object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Object& typedValue) { }
        private System.Xml.Schema.FacetsChecker get_FacetsChecker() { }
        private System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }
        private System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller) { }
        private System.Boolean IsEqual(System.Object o1, System.Object o2) { }
        private System.Boolean IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype) { }
        private System.String get_TypeCodeString() { }
        private System.String TypeCodeToString(System.Xml.Schema.XmlTypeCode typeCode) { }
        private System.String ConcatenatedToString(System.Object value) { }
        private System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedType(System.Xml.XmlTokenizedType token) { }
        private System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token) { }
        private System.Xml.Schema.XmlSchemaDatatype FromXdrName(System.String name) { }
        private System.Xml.Schema.XmlSchemaDatatype DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.String XdrCanonizeUri(System.String uri, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000223
    public struct XmlSchemaDerivationMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaDerivationMethod Empty;        // 0x0
        public static System.Xml.Schema.XmlSchemaDerivationMethod Substitution;        // 0x0
        public static System.Xml.Schema.XmlSchemaDerivationMethod Extension;        // 0x0
        public static System.Xml.Schema.XmlSchemaDerivationMethod Restriction;        // 0x0
        public static System.Xml.Schema.XmlSchemaDerivationMethod List;        // 0x0
        public static System.Xml.Schema.XmlSchemaDerivationMethod Union;        // 0x0
        public static System.Xml.Schema.XmlSchemaDerivationMethod All;        // 0x0
        public static System.Xml.Schema.XmlSchemaDerivationMethod None;        // 0x0

    }

    // TypeToken: 0x2000224
    public class XmlSchemaDocumentation : XmlSchemaObject
    {
        // Fields
        private System.String source;        // 0x38
        private System.String language;        // 0x40
        private System.Xml.XmlNode[] markup;        // 0x48
        private static System.Xml.Schema.XmlSchemaSimpleType languageType;        // 0x0

        // Methods
        private System.Void set_Source(System.String value) { }
        private System.Void set_Language(System.String value) { }
        private System.Void set_Markup(System.Xml.XmlNode[] value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000225
    public class XmlSchemaElement : XmlSchemaParticle
    {
        // Fields
        private System.Boolean isAbstract;        // 0x78
        private System.Boolean hasAbstractAttribute;        // 0x79
        private System.Boolean isNillable;        // 0x7A
        private System.Boolean hasNillableAttribute;        // 0x7B
        private System.Boolean isLocalTypeDerivationChecked;        // 0x7C
        private System.Xml.Schema.XmlSchemaDerivationMethod block;        // 0x80
        private System.Xml.Schema.XmlSchemaDerivationMethod final;        // 0x84
        private System.Xml.Schema.XmlSchemaForm form;        // 0x88
        private System.String defaultValue;        // 0x90
        private System.String fixedValue;        // 0x98
        private System.String name;        // 0xA0
        private System.Xml.XmlQualifiedName refName;        // 0xA8
        private System.Xml.XmlQualifiedName substitutionGroup;        // 0xB0
        private System.Xml.XmlQualifiedName typeName;        // 0xB8
        private System.Xml.Schema.XmlSchemaType type;        // 0xC0
        private System.Xml.XmlQualifiedName qualifiedName;        // 0xC8
        private System.Xml.Schema.XmlSchemaType elementType;        // 0xD0
        private System.Xml.Schema.XmlSchemaDerivationMethod blockResolved;        // 0xD8
        private System.Xml.Schema.XmlSchemaDerivationMethod finalResolved;        // 0xDC
        private System.Xml.Schema.XmlSchemaObjectCollection constraints;        // 0xE0
        private System.Xml.Schema.SchemaElementDecl elementDecl;        // 0xE8

        // Methods
        private System.Boolean get_IsAbstract() { }
        private System.Void set_IsAbstract(System.Boolean value) { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_Block() { }
        private System.Void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.String get_DefaultValue() { }
        private System.Void set_DefaultValue(System.String value) { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_Final() { }
        private System.Void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.String get_FixedValue() { }
        private System.Void set_FixedValue(System.String value) { }
        private System.Xml.Schema.XmlSchemaForm get_Form() { }
        private System.Void set_Form(System.Xml.Schema.XmlSchemaForm value) { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Boolean get_IsNillable() { }
        private System.Void set_IsNillable(System.Boolean value) { }
        private System.Boolean get_HasNillableAttribute() { }
        private System.Boolean get_HasAbstractAttribute() { }
        private System.Xml.XmlQualifiedName get_RefName() { }
        private System.Void set_RefName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.XmlQualifiedName get_SubstitutionGroup() { }
        private System.Void set_SubstitutionGroup(System.Xml.XmlQualifiedName value) { }
        private System.Xml.XmlQualifiedName get_SchemaTypeName() { }
        private System.Void set_SchemaTypeName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.XmlSchemaType get_SchemaType() { }
        private System.Void set_SchemaType(System.Xml.Schema.XmlSchemaType value) { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Constraints() { }
        private System.Xml.XmlQualifiedName get_QualifiedName() { }
        private System.Xml.Schema.XmlSchemaType get_ElementSchemaType() { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved() { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved() { }
        private System.Void SetQualifiedName(System.Xml.XmlQualifiedName value) { }
        private System.Void SetElementType(System.Xml.Schema.XmlSchemaType value) { }
        private System.Void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.Void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.Boolean get_HasConstraints() { }
        private System.Boolean get_IsLocalTypeDerivationChecked() { }
        private System.Void set_IsLocalTypeDerivationChecked(System.Boolean value) { }
        private System.Xml.Schema.SchemaElementDecl get_ElementDecl() { }
        private System.Void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value) { }
        private System.String get_NameAttribute() { }
        private System.Void set_NameAttribute(System.String value) { }
        private System.String get_NameString() { }
        private System.Xml.Schema.XmlSchemaObject Clone() { }
        private System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000226
    public class XmlSchemaException : SystemException
    {
        // Fields
        private System.String res;        // 0x90
        private System.String[] args;        // 0x98
        private System.String sourceUri;        // 0xA0
        private System.Int32 lineNumber;        // 0xA8
        private System.Int32 linePosition;        // 0xAC
        private System.Xml.Schema.XmlSchemaObject sourceSchemaObject;        // 0xB0
        private System.String message;        // 0xB8

        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private System.Void .ctor(System.String message, System.Exception innerException, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void .ctor(System.String res, System.String[] args) { }
        private System.Void .ctor(System.String res, System.String arg) { }
        private System.Void .ctor(System.String res, System.String arg, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void .ctor(System.String res, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void .ctor(System.String res, System.String[] args, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void .ctor(System.String res, System.Xml.Schema.XmlSchemaObject source) { }
        private System.Void .ctor(System.String res, System.String arg, System.Xml.Schema.XmlSchemaObject source) { }
        private System.Void .ctor(System.String res, System.String[] args, System.Xml.Schema.XmlSchemaObject source) { }
        private System.Void .ctor(System.String res, System.String[] args, System.Exception innerException, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition, System.Xml.Schema.XmlSchemaObject source) { }
        private System.String CreateMessage(System.String res, System.String[] args) { }
        private System.String get_GetRes() { }
        private System.String[] get_Args() { }
        private System.String get_SourceUri() { }
        private System.Int32 get_LineNumber() { }
        private System.Int32 get_LinePosition() { }
        private System.Xml.Schema.XmlSchemaObject get_SourceSchemaObject() { }
        private System.Void SetSource(System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void SetSchemaObject(System.Xml.Schema.XmlSchemaObject source) { }
        private System.Void SetSource(System.Xml.Schema.XmlSchemaObject source) { }
        private System.String get_Message() { }

    }

    // TypeToken: 0x2000227
    public class XmlSchemaExternal : XmlSchemaObject
    {
        // Fields
        private System.String location;        // 0x38
        private System.Uri baseUri;        // 0x40
        private System.Xml.Schema.XmlSchema schema;        // 0x48
        private System.String id;        // 0x50
        private System.Xml.XmlAttribute[] moreAttributes;        // 0x58
        private System.Xml.Schema.Compositor compositor;        // 0x60

        // Methods
        private System.String get_SchemaLocation() { }
        private System.Void set_SchemaLocation(System.String value) { }
        private System.Xml.Schema.XmlSchema get_Schema() { }
        private System.Void set_Schema(System.Xml.Schema.XmlSchema value) { }
        private System.String get_Id() { }
        private System.Void set_Id(System.String value) { }
        private System.Uri get_BaseUri() { }
        private System.Void set_BaseUri(System.Uri value) { }
        private System.String get_IdAttribute() { }
        private System.Void set_IdAttribute(System.String value) { }
        private System.Void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes) { }
        private System.Xml.Schema.Compositor get_Compositor() { }
        private System.Void set_Compositor(System.Xml.Schema.Compositor value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000228
    public struct FacetType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.FacetType None;        // 0x0
        public static System.Xml.Schema.FacetType Length;        // 0x0
        public static System.Xml.Schema.FacetType MinLength;        // 0x0
        public static System.Xml.Schema.FacetType MaxLength;        // 0x0
        public static System.Xml.Schema.FacetType Pattern;        // 0x0
        public static System.Xml.Schema.FacetType Whitespace;        // 0x0
        public static System.Xml.Schema.FacetType Enumeration;        // 0x0
        public static System.Xml.Schema.FacetType MinExclusive;        // 0x0
        public static System.Xml.Schema.FacetType MinInclusive;        // 0x0
        public static System.Xml.Schema.FacetType MaxExclusive;        // 0x0
        public static System.Xml.Schema.FacetType MaxInclusive;        // 0x0
        public static System.Xml.Schema.FacetType TotalDigits;        // 0x0
        public static System.Xml.Schema.FacetType FractionDigits;        // 0x0

    }

    // TypeToken: 0x2000229
    public class XmlSchemaFacet : XmlSchemaAnnotated
    {
        // Fields
        private System.String value;        // 0x50
        private System.Boolean isFixed;        // 0x58
        private System.Xml.Schema.FacetType facetType;        // 0x5C

        // Methods
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Boolean get_IsFixed() { }
        private System.Void set_IsFixed(System.Boolean value) { }
        private System.Xml.Schema.FacetType get_FacetType() { }
        private System.Void set_FacetType(System.Xml.Schema.FacetType value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022A
    public class XmlSchemaNumericFacet : XmlSchemaFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022B
    public class XmlSchemaLengthFacet : XmlSchemaNumericFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022C
    public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022D
    public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022E
    public class XmlSchemaPatternFacet : XmlSchemaFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022F
    public class XmlSchemaEnumerationFacet : XmlSchemaFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000230
    public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000231
    public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000232
    public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000233
    public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000234
    public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000235
    public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000236
    public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000237
    public struct XmlSchemaForm
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaForm None;        // 0x0
        public static System.Xml.Schema.XmlSchemaForm Qualified;        // 0x0
        public static System.Xml.Schema.XmlSchemaForm Unqualified;        // 0x0

    }

    // TypeToken: 0x2000238
    public class XmlSchemaGroup : XmlSchemaAnnotated
    {
        // Fields
        private System.String name;        // 0x50
        private System.Xml.Schema.XmlSchemaGroupBase particle;        // 0x58
        private System.Xml.Schema.XmlSchemaParticle canonicalParticle;        // 0x60
        private System.Xml.XmlQualifiedName qname;        // 0x68
        private System.Xml.Schema.XmlSchemaGroup redefined;        // 0x70
        private System.Int32 selfReferenceCount;        // 0x78

        // Methods
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Xml.Schema.XmlSchemaGroupBase get_Particle() { }
        private System.Void set_Particle(System.Xml.Schema.XmlSchemaGroupBase value) { }
        private System.Xml.XmlQualifiedName get_QualifiedName() { }
        private System.Xml.Schema.XmlSchemaParticle get_CanonicalParticle() { }
        private System.Void set_CanonicalParticle(System.Xml.Schema.XmlSchemaParticle value) { }
        private System.Xml.Schema.XmlSchemaGroup get_Redefined() { }
        private System.Void set_Redefined(System.Xml.Schema.XmlSchemaGroup value) { }
        private System.Int32 get_SelfReferenceCount() { }
        private System.Void set_SelfReferenceCount(System.Int32 value) { }
        private System.String get_NameAttribute() { }
        private System.Void set_NameAttribute(System.String value) { }
        private System.Void SetQualifiedName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.XmlSchemaObject Clone() { }
        private System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000239
    public class XmlSchemaGroupBase : XmlSchemaParticle
    {
        // Methods
        private System.Xml.Schema.XmlSchemaObjectCollection get_Items() { }
        private System.Void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023A
    public class XmlSchemaGroupRef : XmlSchemaParticle
    {
        // Fields
        private System.Xml.XmlQualifiedName refName;        // 0x78
        private System.Xml.Schema.XmlSchemaGroupBase particle;        // 0x80
        private System.Xml.Schema.XmlSchemaGroup refined;        // 0x88

        // Methods
        private System.Xml.XmlQualifiedName get_RefName() { }
        private System.Void set_RefName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.XmlSchemaGroupBase get_Particle() { }
        private System.Void SetParticle(System.Xml.Schema.XmlSchemaGroupBase value) { }
        private System.Xml.Schema.XmlSchemaGroup get_Redefined() { }
        private System.Void set_Redefined(System.Xml.Schema.XmlSchemaGroup value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023B
    public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
    {
        // Fields
        private System.String name;        // 0x50
        private System.Xml.Schema.XmlSchemaXPath selector;        // 0x58
        private System.Xml.Schema.XmlSchemaObjectCollection fields;        // 0x60
        private System.Xml.XmlQualifiedName qualifiedName;        // 0x68
        private System.Xml.Schema.CompiledIdentityConstraint compiledConstraint;        // 0x70

        // Methods
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Xml.Schema.XmlSchemaXPath get_Selector() { }
        private System.Void set_Selector(System.Xml.Schema.XmlSchemaXPath value) { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Fields() { }
        private System.Xml.XmlQualifiedName get_QualifiedName() { }
        private System.Void SetQualifiedName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.CompiledIdentityConstraint get_CompiledConstraint() { }
        private System.Void set_CompiledConstraint(System.Xml.Schema.CompiledIdentityConstraint value) { }
        private System.String get_NameAttribute() { }
        private System.Void set_NameAttribute(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023C
    public class XmlSchemaXPath : XmlSchemaAnnotated
    {
        // Fields
        private System.String xpath;        // 0x50

        // Methods
        private System.String get_XPath() { }
        private System.Void set_XPath(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023D
    public class XmlSchemaUnique : XmlSchemaIdentityConstraint
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023E
    public class XmlSchemaKey : XmlSchemaIdentityConstraint
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023F
    public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
    {
        // Fields
        private System.Xml.XmlQualifiedName refer;        // 0x78

        // Methods
        private System.Xml.XmlQualifiedName get_Refer() { }
        private System.Void set_Refer(System.Xml.XmlQualifiedName value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000240
    public class XmlSchemaImport : XmlSchemaExternal
    {
        // Fields
        private System.String ns;        // 0x68
        private System.Xml.Schema.XmlSchemaAnnotation annotation;        // 0x70

        // Methods
        private System.Void .ctor() { }
        private System.String get_Namespace() { }
        private System.Void set_Namespace(System.String value) { }
        private System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation) { }

    }

    // TypeToken: 0x2000241
    public class XmlSchemaInclude : XmlSchemaExternal
    {
        // Fields
        private System.Xml.Schema.XmlSchemaAnnotation annotation;        // 0x68

        // Methods
        private System.Void .ctor() { }
        private System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation) { }

    }

    // TypeToken: 0x2000242
    public class XmlSchemaInfo, IXmlSchemaInfo
    {
        // Fields
        private System.Boolean isDefault;        // 0x10
        private System.Boolean isNil;        // 0x11
        private System.Xml.Schema.XmlSchemaElement schemaElement;        // 0x18
        private System.Xml.Schema.XmlSchemaAttribute schemaAttribute;        // 0x20
        private System.Xml.Schema.XmlSchemaType schemaType;        // 0x28
        private System.Xml.Schema.XmlSchemaSimpleType memberType;        // 0x30
        private System.Xml.Schema.XmlSchemaValidity validity;        // 0x38
        private System.Xml.Schema.XmlSchemaContentType contentType;        // 0x3C

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaValidity validity) { }
        private System.Xml.Schema.XmlSchemaValidity get_Validity() { }
        private System.Void set_Validity(System.Xml.Schema.XmlSchemaValidity value) { }
        private System.Boolean get_IsDefault() { }
        private System.Void set_IsDefault(System.Boolean value) { }
        private System.Boolean get_IsNil() { }
        private System.Void set_IsNil(System.Boolean value) { }
        private System.Xml.Schema.XmlSchemaSimpleType get_MemberType() { }
        private System.Void set_MemberType(System.Xml.Schema.XmlSchemaSimpleType value) { }
        private System.Xml.Schema.XmlSchemaType get_SchemaType() { }
        private System.Void set_SchemaType(System.Xml.Schema.XmlSchemaType value) { }
        private System.Xml.Schema.XmlSchemaElement get_SchemaElement() { }
        private System.Void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value) { }
        private System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute() { }
        private System.Void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value) { }
        private System.Xml.Schema.XmlSchemaContentType get_ContentType() { }
        private System.Xml.Schema.XmlSchemaType get_XmlType() { }
        private System.Boolean get_HasDefaultValue() { }
        private System.Boolean get_IsUnionType() { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x2000243
    public class XmlSchemaNotation : XmlSchemaAnnotated
    {
        // Fields
        private System.String name;        // 0x50
        private System.String publicId;        // 0x58
        private System.String systemId;        // 0x60
        private System.Xml.XmlQualifiedName qname;        // 0x68

        // Methods
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.String get_Public() { }
        private System.Void set_Public(System.String value) { }
        private System.String get_System() { }
        private System.Void set_System(System.String value) { }
        private System.Xml.XmlQualifiedName get_QualifiedName() { }
        private System.Void set_QualifiedName(System.Xml.XmlQualifiedName value) { }
        private System.String get_NameAttribute() { }
        private System.Void set_NameAttribute(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000244
    public class XmlSchemaObject
    {
        // Fields
        private System.Int32 lineNum;        // 0x10
        private System.Int32 linePos;        // 0x14
        private System.String sourceUri;        // 0x18
        private System.Xml.Serialization.XmlSerializerNamespaces namespaces;        // 0x20
        private System.Xml.Schema.XmlSchemaObject parent;        // 0x28
        private System.Boolean isProcessing;        // 0x30

        // Methods
        private System.Int32 get_LineNumber() { }
        private System.Void set_LineNumber(System.Int32 value) { }
        private System.Int32 get_LinePosition() { }
        private System.Void set_LinePosition(System.Int32 value) { }
        private System.String get_SourceUri() { }
        private System.Void set_SourceUri(System.String value) { }
        private System.Xml.Schema.XmlSchemaObject get_Parent() { }
        private System.Void set_Parent(System.Xml.Schema.XmlSchemaObject value) { }
        private System.Xml.Serialization.XmlSerializerNamespaces get_Namespaces() { }
        private System.Void set_Namespaces(System.Xml.Serialization.XmlSerializerNamespaces value) { }
        private System.Void OnAdd(System.Xml.Schema.XmlSchemaObjectCollection container, System.Object item) { }
        private System.Void OnRemove(System.Xml.Schema.XmlSchemaObjectCollection container, System.Object item) { }
        private System.Void OnClear(System.Xml.Schema.XmlSchemaObjectCollection container) { }
        private System.String get_IdAttribute() { }
        private System.Void set_IdAttribute(System.String value) { }
        private System.Void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes) { }
        private System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation) { }
        private System.String get_NameAttribute() { }
        private System.Void set_NameAttribute(System.String value) { }
        private System.Boolean get_IsProcessing() { }
        private System.Void set_IsProcessing(System.Boolean value) { }
        private System.Xml.Schema.XmlSchemaObject Clone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000245
    public class XmlSchemaObjectCollection : CollectionBase
    {
        // Fields
        private System.Xml.Schema.XmlSchemaObject parent;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Xml.Schema.XmlSchemaObject get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Xml.Schema.XmlSchemaObject value) { }
        private System.Xml.Schema.XmlSchemaObjectEnumerator GetEnumerator() { }
        private System.Int32 Add(System.Xml.Schema.XmlSchemaObject item) { }
        private System.Void Insert(System.Int32 index, System.Xml.Schema.XmlSchemaObject item) { }
        private System.Void Remove(System.Xml.Schema.XmlSchemaObject item) { }
        private System.Void OnInsert(System.Int32 index, System.Object item) { }
        private System.Void OnSet(System.Int32 index, System.Object oldValue, System.Object newValue) { }
        private System.Void OnClear() { }
        private System.Void OnRemove(System.Int32 index, System.Object item) { }
        private System.Xml.Schema.XmlSchemaObjectCollection Clone() { }
        private System.Void Add(System.Xml.Schema.XmlSchemaObjectCollection collToAdd) { }

    }

    // TypeToken: 0x2000246
    public class XmlSchemaObjectEnumerator, IEnumerator
    {
        // Fields
        private System.Collections.IEnumerator enumerator;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.IEnumerator enumerator) { }
        private System.Boolean MoveNext() { }
        private System.Xml.Schema.XmlSchemaObject get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Boolean System.Collections.IEnumerator.MoveNext() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x2000247
    public class XmlSchemaObjectTable
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaObject> table;        // 0x10
        private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void Add(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value) { }
        private System.Void Insert(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value) { }
        private System.Void Replace(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value) { }
        private System.Void Clear() { }
        private System.Void Remove(System.Xml.XmlQualifiedName name) { }
        private System.Int32 FindIndexByValue(System.Xml.Schema.XmlSchemaObject xso) { }
        private System.Int32 get_Count() { }
        private System.Boolean Contains(System.Xml.XmlQualifiedName name) { }
        private System.Xml.Schema.XmlSchemaObject get_Item(System.Xml.XmlQualifiedName name) { }
        private System.Collections.ICollection get_Values() { }
        private System.Collections.IDictionaryEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x200024D
    public class XmlSchemaParticle : XmlSchemaAnnotated
    {
        // Fields
        private System.Decimal minOccurs;        // 0x50
        private System.Decimal maxOccurs;        // 0x60
        private System.Xml.Schema.XmlSchemaParticle.Occurs flags;        // 0x70
        private static readonly System.Xml.Schema.XmlSchemaParticle Empty;        // 0x0

        // Methods
        private System.String get_MinOccursString() { }
        private System.Void set_MinOccursString(System.String value) { }
        private System.String get_MaxOccursString() { }
        private System.Void set_MaxOccursString(System.String value) { }
        private System.Decimal get_MinOccurs() { }
        private System.Void set_MinOccurs(System.Decimal value) { }
        private System.Decimal get_MaxOccurs() { }
        private System.Void set_MaxOccurs(System.Decimal value) { }
        private System.Boolean get_IsEmpty() { }
        private System.String get_NameString() { }
        private System.Xml.XmlQualifiedName GetQualifiedName() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000250
    public class XmlSchemaRedefine : XmlSchemaExternal
    {
        // Fields
        private System.Xml.Schema.XmlSchemaObjectCollection items;        // 0x68
        private System.Xml.Schema.XmlSchemaObjectTable attributeGroups;        // 0x70
        private System.Xml.Schema.XmlSchemaObjectTable types;        // 0x78
        private System.Xml.Schema.XmlSchemaObjectTable groups;        // 0x80

        // Methods
        private System.Void .ctor() { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Items() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_Groups() { }
        private System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation) { }

    }

    // TypeToken: 0x2000251
    public class XmlSchemaSequence : XmlSchemaGroupBase
    {
        // Fields
        private System.Xml.Schema.XmlSchemaObjectCollection items;        // 0x78

        // Methods
        private System.Xml.Schema.XmlSchemaObjectCollection get_Items() { }
        private System.Boolean get_IsEmpty() { }
        private System.Void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000252
    public class XmlSchemaSet
    {
        // Fields
        private System.Xml.XmlNameTable nameTable;        // 0x10
        private System.Xml.Schema.SchemaNames schemaNames;        // 0x18
        private System.Collections.SortedList schemas;        // 0x20
        private System.Xml.Schema.ValidationEventHandler internalEventHandler;        // 0x28
        private System.Xml.Schema.ValidationEventHandler eventHandler;        // 0x30
        private System.Boolean isCompiled;        // 0x38
        private System.Collections.Hashtable schemaLocations;        // 0x40
        private System.Collections.Hashtable chameleonSchemas;        // 0x48
        private System.Collections.Hashtable targetNamespaces;        // 0x50
        private System.Boolean compileAll;        // 0x58
        private System.Xml.Schema.SchemaInfo cachedCompiledInfo;        // 0x60
        private System.Xml.XmlReaderSettings readerSettings;        // 0x68
        private System.Xml.Schema.XmlSchema schemaForSchema;        // 0x70
        private System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings;        // 0x78
        private System.Xml.Schema.XmlSchemaObjectTable elements;        // 0x80
        private System.Xml.Schema.XmlSchemaObjectTable attributes;        // 0x88
        private System.Xml.Schema.XmlSchemaObjectTable schemaTypes;        // 0x90
        private System.Xml.Schema.XmlSchemaObjectTable substitutionGroups;        // 0x98
        private System.Xml.Schema.XmlSchemaObjectTable typeExtensions;        // 0xA0
        private System.Object internalSyncObject;        // 0xA8

        // Methods
        private System.Object get_InternalSyncObject() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.XmlNameTable nameTable) { }
        private System.Void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value) { }
        private System.Void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value) { }
        private System.Boolean get_IsCompiled() { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings() { }
        private System.Void set_CompilationSettings(System.Xml.Schema.XmlSchemaCompilationSettings value) { }
        private System.Int32 get_Count() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_GlobalElements() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_GlobalAttributes() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_GlobalTypes() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_SubstitutionGroups() { }
        private System.Collections.Hashtable get_SchemaLocations() { }
        private System.Xml.Schema.XmlSchemaObjectTable get_TypeExtensions() { }
        private System.Void Add(System.Xml.Schema.XmlSchemaSet schemas) { }
        private System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema) { }
        private System.Boolean RemoveRecursive(System.Xml.Schema.XmlSchema schemaToRemove) { }
        private System.Boolean Contains(System.String targetNamespace) { }
        private System.Void Compile() { }
        private System.Xml.Schema.XmlSchema Reprocess(System.Xml.Schema.XmlSchema schema) { }
        private System.Void CopyTo(System.Xml.Schema.XmlSchema[] schemas, System.Int32 index) { }
        private System.Collections.ICollection Schemas() { }
        private System.Collections.ICollection Schemas(System.String targetNamespace) { }
        private System.Xml.Schema.XmlSchema Add(System.String targetNamespace, System.Xml.Schema.XmlSchema schema) { }
        private System.Void Add(System.String targetNamespace, System.Xml.XmlReader reader, System.Collections.Hashtable validatedNamespaces) { }
        private System.Xml.Schema.XmlSchema FindSchemaByNSAndUrl(System.Uri schemaUri, System.String ns, System.Collections.DictionaryEntry[] locationsTable) { }
        private System.Void AddSchemaToSet(System.Xml.Schema.XmlSchema schema) { }
        private System.Void ProcessNewSubstitutionGroups(System.Xml.Schema.XmlSchemaObjectTable substitutionGroupsTable, System.Boolean resolve) { }
        private System.Void ResolveSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup, System.Xml.Schema.XmlSchemaObjectTable substTable) { }
        private System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema schema, System.Boolean forceCompile) { }
        private System.Void ClearTables() { }
        private System.Boolean PreprocessSchema(System.Xml.Schema.XmlSchema& schema, System.String targetNamespace) { }
        private System.Xml.Schema.XmlSchema ParseSchema(System.String targetNamespace, System.Xml.XmlReader reader) { }
        private System.Void CopyFromCompiledSet(System.Xml.Schema.XmlSchemaSet otherSet) { }
        private System.Xml.Schema.SchemaInfo get_CompiledInfo() { }
        private System.Xml.XmlReaderSettings get_ReaderSettings() { }
        private System.Xml.XmlResolver GetResolver() { }
        private System.Xml.Schema.ValidationEventHandler GetEventHandler() { }
        private System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt) { }
        private System.Boolean IsSchemaLoaded(System.Uri schemaUri, System.String targetNamespace, System.Xml.Schema.XmlSchema& schema) { }
        private System.Boolean GetSchemaByUri(System.Uri schemaUri, System.Xml.Schema.XmlSchema& schema) { }
        private System.String GetTargetNamespace(System.Xml.Schema.XmlSchema schema) { }
        private System.Collections.SortedList get_SortedSchemas() { }
        private System.Void RemoveSchemaFromCaches(System.Xml.Schema.XmlSchema schema) { }
        private System.Void RemoveSchemaFromGlobalTables(System.Xml.Schema.XmlSchema schema) { }
        private System.Boolean AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item) { }
        private System.Void VerifyTables() { }
        private System.Void InternalValidationCallback(System.Object sender, System.Xml.Schema.ValidationEventArgs e) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity) { }

    }

    // TypeToken: 0x2000253
    public class XmlSchemaSimpleContent : XmlSchemaContentModel
    {
        // Fields
        private System.Xml.Schema.XmlSchemaContent content;        // 0x50

        // Methods
        private System.Xml.Schema.XmlSchemaContent get_Content() { }
        private System.Void set_Content(System.Xml.Schema.XmlSchemaContent value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000254
    public class XmlSchemaSimpleContentExtension : XmlSchemaContent
    {
        // Fields
        private System.Xml.Schema.XmlSchemaObjectCollection attributes;        // 0x50
        private System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;        // 0x58
        private System.Xml.XmlQualifiedName baseTypeName;        // 0x60

        // Methods
        private System.Xml.XmlQualifiedName get_BaseTypeName() { }
        private System.Void set_BaseTypeName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Attributes() { }
        private System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute() { }
        private System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value) { }
        private System.Void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000255
    public class XmlSchemaSimpleContentRestriction : XmlSchemaContent
    {
        // Fields
        private System.Xml.XmlQualifiedName baseTypeName;        // 0x50
        private System.Xml.Schema.XmlSchemaSimpleType baseType;        // 0x58
        private System.Xml.Schema.XmlSchemaObjectCollection facets;        // 0x60
        private System.Xml.Schema.XmlSchemaObjectCollection attributes;        // 0x68
        private System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;        // 0x70

        // Methods
        private System.Xml.XmlQualifiedName get_BaseTypeName() { }
        private System.Void set_BaseTypeName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.XmlSchemaSimpleType get_BaseType() { }
        private System.Void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value) { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Facets() { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Attributes() { }
        private System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute() { }
        private System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value) { }
        private System.Void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000256
    public class XmlSchemaSimpleType : XmlSchemaType
    {
        // Fields
        private System.Xml.Schema.XmlSchemaSimpleTypeContent content;        // 0x98

        // Methods
        private System.Void .ctor() { }
        private System.Xml.Schema.XmlSchemaSimpleTypeContent get_Content() { }
        private System.Void set_Content(System.Xml.Schema.XmlSchemaSimpleTypeContent value) { }
        private System.Xml.Schema.XmlSchemaObject Clone() { }

    }

    // TypeToken: 0x2000257
    public class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000258
    public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
    {
        // Fields
        private System.Xml.XmlQualifiedName itemTypeName;        // 0x50
        private System.Xml.Schema.XmlSchemaSimpleType itemType;        // 0x58
        private System.Xml.Schema.XmlSchemaSimpleType baseItemType;        // 0x60

        // Methods
        private System.Xml.XmlQualifiedName get_ItemTypeName() { }
        private System.Void set_ItemTypeName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.XmlSchemaSimpleType get_ItemType() { }
        private System.Void set_ItemType(System.Xml.Schema.XmlSchemaSimpleType value) { }
        private System.Xml.Schema.XmlSchemaSimpleType get_BaseItemType() { }
        private System.Void set_BaseItemType(System.Xml.Schema.XmlSchemaSimpleType value) { }
        private System.Xml.Schema.XmlSchemaObject Clone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000259
    public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
    {
        // Fields
        private System.Xml.XmlQualifiedName baseTypeName;        // 0x50
        private System.Xml.Schema.XmlSchemaSimpleType baseType;        // 0x58
        private System.Xml.Schema.XmlSchemaObjectCollection facets;        // 0x60

        // Methods
        private System.Xml.XmlQualifiedName get_BaseTypeName() { }
        private System.Void set_BaseTypeName(System.Xml.XmlQualifiedName value) { }
        private System.Xml.Schema.XmlSchemaSimpleType get_BaseType() { }
        private System.Void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value) { }
        private System.Xml.Schema.XmlSchemaObjectCollection get_Facets() { }
        private System.Xml.Schema.XmlSchemaObject Clone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200025A
    public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
    {
        // Fields
        private System.Xml.Schema.XmlSchemaObjectCollection baseTypes;        // 0x50
        private System.Xml.XmlQualifiedName[] memberTypes;        // 0x58
        private System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes;        // 0x60

        // Methods
        private System.Xml.Schema.XmlSchemaObjectCollection get_BaseTypes() { }
        private System.Xml.XmlQualifiedName[] get_MemberTypes() { }
        private System.Void set_MemberTypes(System.Xml.XmlQualifiedName[] value) { }
        private System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes() { }
        private System.Void SetBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes) { }
        private System.Xml.Schema.XmlSchemaObject Clone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200025B
    public class XmlSchemaSubstitutionGroup : XmlSchemaObject
    {
        // Fields
        private System.Collections.ArrayList membersList;        // 0x38
        private System.Xml.XmlQualifiedName examplar;        // 0x40

        // Methods
        private System.Collections.ArrayList get_Members() { }
        private System.Xml.XmlQualifiedName get_Examplar() { }
        private System.Void set_Examplar(System.Xml.XmlQualifiedName value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200025C
    public class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup
    {
        // Fields
        private System.Xml.Schema.XmlSchemaChoice choice;        // 0x48

        // Methods
        private System.Xml.Schema.XmlSchemaChoice get_Choice() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200025D
    public class XmlSchemaType : XmlSchemaAnnotated
    {
        // Fields
        private System.String name;        // 0x50
        private System.Xml.Schema.XmlSchemaDerivationMethod final;        // 0x58
        private System.Xml.Schema.XmlSchemaDerivationMethod derivedBy;        // 0x5C
        private System.Xml.Schema.XmlSchemaType baseSchemaType;        // 0x60
        private System.Xml.Schema.XmlSchemaDatatype datatype;        // 0x68
        private System.Xml.Schema.XmlSchemaDerivationMethod finalResolved;        // 0x70
        private System.Xml.Schema.SchemaElementDecl elementDecl;        // 0x78
        private System.Xml.XmlQualifiedName qname;        // 0x80
        private System.Xml.Schema.XmlSchemaType redefined;        // 0x88
        private System.Xml.Schema.XmlSchemaContentType contentType;        // 0x90

        // Methods
        private System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName qualifiedName) { }
        private System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.Schema.XmlTypeCode typeCode) { }
        private System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName qualifiedName) { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_Final() { }
        private System.Void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.Xml.XmlQualifiedName get_QualifiedName() { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved() { }
        private System.Xml.Schema.XmlSchemaType get_BaseXmlSchemaType() { }
        private System.Xml.Schema.XmlSchemaDerivationMethod get_DerivedBy() { }
        private System.Xml.Schema.XmlSchemaDatatype get_Datatype() { }
        private System.Boolean get_IsMixed() { }
        private System.Void set_IsMixed(System.Boolean value) { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.Xml.Schema.XmlValueConverter get_ValueConverter() { }
        private System.Xml.Schema.XmlSchemaContentType get_SchemaContentType() { }
        private System.Void SetQualifiedName(System.Xml.XmlQualifiedName value) { }
        private System.Void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.Void SetBaseSchemaType(System.Xml.Schema.XmlSchemaType value) { }
        private System.Void SetDerivedBy(System.Xml.Schema.XmlSchemaDerivationMethod value) { }
        private System.Void SetDatatype(System.Xml.Schema.XmlSchemaDatatype value) { }
        private System.Xml.Schema.SchemaElementDecl get_ElementDecl() { }
        private System.Void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value) { }
        private System.Xml.Schema.XmlSchemaType get_Redefined() { }
        private System.Void set_Redefined(System.Xml.Schema.XmlSchemaType value) { }
        private System.Void SetContentType(System.Xml.Schema.XmlSchemaContentType value) { }
        private System.Boolean IsDerivedFrom(System.Xml.Schema.XmlSchemaType derivedType, System.Xml.Schema.XmlSchemaType baseType, System.Xml.Schema.XmlSchemaDerivationMethod except) { }
        private System.Boolean IsDerivedFromDatatype(System.Xml.Schema.XmlSchemaDatatype derivedDataType, System.Xml.Schema.XmlSchemaDatatype baseDataType, System.Xml.Schema.XmlSchemaDerivationMethod except) { }
        private System.String get_NameAttribute() { }
        private System.Void set_NameAttribute(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200025E
    public struct XmlSchemaUse
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaUse None;        // 0x0
        public static System.Xml.Schema.XmlSchemaUse Optional;        // 0x0
        public static System.Xml.Schema.XmlSchemaUse Prohibited;        // 0x0
        public static System.Xml.Schema.XmlSchemaUse Required;        // 0x0

    }

    // TypeToken: 0x200025F
    public class XmlSchemaValidationException : XmlSchemaException
    {
        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String res, System.String arg, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void .ctor(System.String res, System.String[] args, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition) { }
        private System.Void .ctor(System.String res, System.String[] args, System.Exception innerException, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition) { }

    }

    // TypeToken: 0x2000260
    public class XmlValueGetter : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Object Invoke() { }

    }

    // TypeToken: 0x2000261
    public struct XmlSchemaValidationFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaValidationFlags None;        // 0x0
        public static System.Xml.Schema.XmlSchemaValidationFlags ProcessInlineSchema;        // 0x0
        public static System.Xml.Schema.XmlSchemaValidationFlags ProcessSchemaLocation;        // 0x0
        public static System.Xml.Schema.XmlSchemaValidationFlags ReportValidationWarnings;        // 0x0
        public static System.Xml.Schema.XmlSchemaValidationFlags ProcessIdentityConstraints;        // 0x0
        public static System.Xml.Schema.XmlSchemaValidationFlags AllowXmlAttributes;        // 0x0

    }

    // TypeToken: 0x2000262
    public struct ValidatorState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.ValidatorState None;        // 0x0
        public static System.Xml.Schema.ValidatorState Start;        // 0x0
        public static System.Xml.Schema.ValidatorState TopLevelAttribute;        // 0x0
        public static System.Xml.Schema.ValidatorState TopLevelTextOrWS;        // 0x0
        public static System.Xml.Schema.ValidatorState Element;        // 0x0
        public static System.Xml.Schema.ValidatorState Attribute;        // 0x0
        public static System.Xml.Schema.ValidatorState EndOfAttributes;        // 0x0
        public static System.Xml.Schema.ValidatorState Text;        // 0x0
        public static System.Xml.Schema.ValidatorState Whitespace;        // 0x0
        public static System.Xml.Schema.ValidatorState EndElement;        // 0x0
        public static System.Xml.Schema.ValidatorState SkipToEndElement;        // 0x0
        public static System.Xml.Schema.ValidatorState Finish;        // 0x0

    }

    // TypeToken: 0x2000263
    public class IdRefNode
    {
        // Fields
        private System.String Id;        // 0x10
        private System.Int32 LineNo;        // 0x18
        private System.Int32 LinePos;        // 0x1C
        private System.Xml.Schema.IdRefNode Next;        // 0x20

        // Methods
        private System.Void .ctor(System.Xml.Schema.IdRefNode next, System.String id, System.Int32 lineNo, System.Int32 linePos) { }

    }

    // TypeToken: 0x2000264
    public class XmlSchemaValidator
    {
        // Fields
        private System.Xml.Schema.XmlSchemaSet schemaSet;        // 0x10
        private System.Xml.Schema.XmlSchemaValidationFlags validationFlags;        // 0x18
        private System.Int32 startIDConstraint;        // 0x1C
        private System.Boolean isRoot;        // 0x20
        private System.Boolean rootHasSchema;        // 0x21
        private System.Boolean attrValid;        // 0x22
        private System.Boolean checkEntity;        // 0x23
        private System.Xml.Schema.SchemaInfo compiledSchemaInfo;        // 0x28
        private System.Xml.IDtdInfo dtdSchemaInfo;        // 0x30
        private System.Collections.Hashtable validatedNamespaces;        // 0x38
        private System.Xml.HWStack validationStack;        // 0x40
        private System.Xml.Schema.ValidationState context;        // 0x48
        private System.Xml.Schema.ValidatorState currentState;        // 0x50
        private System.Collections.Hashtable attPresence;        // 0x58
        private System.Xml.Schema.SchemaAttDef wildID;        // 0x60
        private System.Collections.Hashtable IDs;        // 0x68
        private System.Xml.Schema.IdRefNode idRefListHead;        // 0x70
        private System.Xml.XmlQualifiedName contextQName;        // 0x78
        private System.String NsXs;        // 0x80
        private System.String NsXsi;        // 0x88
        private System.String NsXmlNs;        // 0x90
        private System.String NsXml;        // 0x98
        private System.Xml.Schema.XmlSchemaObject partialValidationType;        // 0xA0
        private System.Text.StringBuilder textValue;        // 0xA8
        private System.Xml.Schema.ValidationEventHandler eventHandler;        // 0xB0
        private System.Object validationEventSender;        // 0xB8
        private System.Xml.XmlNameTable nameTable;        // 0xC0
        private System.Xml.IXmlLineInfo positionInfo;        // 0xC8
        private System.Xml.IXmlLineInfo dummyPositionInfo;        // 0xD0
        private System.Xml.XmlResolver xmlResolver;        // 0xD8
        private System.Uri sourceUri;        // 0xE0
        private System.String sourceUriString;        // 0xE8
        private System.Xml.IXmlNamespaceResolver nsResolver;        // 0xF0
        private System.Xml.Schema.XmlSchemaContentProcessing processContents;        // 0xF8
        private System.String xsiTypeString;        // 0x100
        private System.String xsiNilString;        // 0x108
        private System.String xsiSchemaLocationString;        // 0x110
        private System.String xsiNoNamespaceSchemaLocationString;        // 0x118
        private static readonly System.Xml.Schema.XmlSchemaDatatype dtQName;        // 0x0
        private static readonly System.Xml.Schema.XmlSchemaDatatype dtCDATA;        // 0x8
        private static readonly System.Xml.Schema.XmlSchemaDatatype dtStringArray;        // 0x10
        private static System.Xml.Schema.XmlSchemaParticle[] EmptyParticleArray;        // 0x18
        private static System.Xml.Schema.XmlSchemaAttribute[] EmptyAttributeArray;        // 0x20
        private System.Xml.XmlCharType xmlCharType;        // 0x120
        private static System.Boolean[,] ValidStates;        // 0x28
        private static System.String[] MethodNames;        // 0x30

        // Methods
        private System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Xml.Schema.XmlSchemaValidationFlags validationFlags) { }
        private System.Void Init() { }
        private System.Void Reset() { }
        private System.Void set_XmlResolver(System.Xml.XmlResolver value) { }
        private System.Void set_LineInfoProvider(System.Xml.IXmlLineInfo value) { }
        private System.Void set_SourceUri(System.Uri value) { }
        private System.Void set_ValidationEventSender(System.Object value) { }
        private System.Void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value) { }
        private System.Void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value) { }
        private System.Void AddSchema(System.Xml.Schema.XmlSchema schema) { }
        private System.Void Initialize() { }
        private System.Void Initialize(System.Xml.Schema.XmlSchemaObject partialValidationType) { }
        private System.Void ValidateElement(System.String localName, System.String namespaceUri, System.Xml.Schema.XmlSchemaInfo schemaInfo, System.String xsiType, System.String xsiNil, System.String xsiSchemaLocation, System.String xsiNoNamespaceSchemaLocation) { }
        private System.Object ValidateAttribute(System.String localName, System.String namespaceUri, System.Xml.Schema.XmlValueGetter attributeValue, System.Xml.Schema.XmlSchemaInfo schemaInfo) { }
        private System.Object ValidateAttribute(System.String lName, System.String ns, System.Xml.Schema.XmlValueGetter attributeValueGetter, System.String attributeStringValue, System.Xml.Schema.XmlSchemaInfo schemaInfo) { }
        private System.Void ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo schemaInfo) { }
        private System.Void ValidateText(System.Xml.Schema.XmlValueGetter elementValue) { }
        private System.Void ValidateText(System.String elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter) { }
        private System.Void ValidateWhitespace(System.Xml.Schema.XmlValueGetter elementValue) { }
        private System.Void ValidateWhitespace(System.String elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter) { }
        private System.Object ValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo) { }
        private System.Void SkipToEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo) { }
        private System.Void EndValidation() { }
        private System.Void GetUnspecifiedDefaultAttributes(System.Collections.ArrayList defaultAttributes, System.Boolean createNodeData) { }
        private System.Xml.Schema.XmlSchemaSet get_SchemaSet() { }
        private System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags() { }
        private System.Xml.Schema.XmlSchemaContentType get_CurrentContentType() { }
        private System.Void SetDtdSchemaInfo(System.Xml.IDtdInfo dtdSchemaInfo) { }
        private System.Boolean get_StrictlyAssessed() { }
        private System.Boolean get_HasSchema() { }
        private System.String GetConcatenatedValue() { }
        private System.Object InternalValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo, System.Object typedValue) { }
        private System.Void ProcessSchemaLocations(System.String xsiSchemaLocation, System.String xsiNoNamespaceSchemaLocation) { }
        private System.Object ValidateElementContext(System.Xml.XmlQualifiedName elementName, System.Boolean& invalidElementInContext) { }
        private System.Xml.Schema.XmlSchemaElement GetSubstitutionGroupHead(System.Xml.XmlQualifiedName member) { }
        private System.Object ValidateAtomicValue(System.String stringValue, System.Xml.Schema.XmlSchemaSimpleType& memberType) { }
        private System.Object ValidateAtomicValue(System.Object parsedValue, System.Xml.Schema.XmlSchemaSimpleType& memberType) { }
        private System.String GetTypeName(System.Xml.Schema.SchemaDeclBase decl) { }
        private System.Void SaveTextValue(System.Object value) { }
        private System.Void Push(System.Xml.XmlQualifiedName elementName) { }
        private System.Void Pop() { }
        private System.Xml.Schema.SchemaElementDecl FastGetElementDecl(System.Xml.XmlQualifiedName elementName, System.Object particle) { }
        private System.Xml.Schema.SchemaElementDecl CheckXsiTypeAndNil(System.Xml.Schema.SchemaElementDecl elementDecl, System.String xsiType, System.String xsiNil, System.Boolean& declFound) { }
        private System.Void ThrowDeclNotFoundWarningOrError(System.Boolean declFound) { }
        private System.Void CheckElementProperties() { }
        private System.Void ValidateStartElementIdentityConstraints() { }
        private System.Xml.Schema.SchemaAttDef CheckIsXmlAttribute(System.Xml.XmlQualifiedName attQName) { }
        private System.Void AddXmlNamespaceSchema() { }
        private System.Object CheckMixedValueConstraint(System.String elementValue) { }
        private System.Void LoadSchema(System.String uri, System.String url) { }
        private System.Void RecompileSchemaSet() { }
        private System.Void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, System.String name, System.Boolean attrValue) { }
        private System.Object CheckAttributeValue(System.Object value, System.Xml.Schema.SchemaAttDef attdef) { }
        private System.Object CheckElementValue(System.String stringValue) { }
        private System.Void CheckTokenizedTypes(System.Xml.Schema.XmlSchemaDatatype dtype, System.Object typedValue, System.Boolean attrValue) { }
        private System.Object FindId(System.String name) { }
        private System.Void CheckForwardRefs() { }
        private System.Boolean get_HasIdentityConstraints() { }
        private System.Boolean get_ProcessIdentityConstraints() { }
        private System.Boolean get_ReportValidationWarnings() { }
        private System.Boolean get_ProcessSchemaHints() { }
        private System.Void CheckStateTransition(System.Xml.Schema.ValidatorState toState, System.String methodName) { }
        private System.Void ClearPSVI() { }
        private System.Void CheckRequiredAttributes(System.Xml.Schema.SchemaElementDecl currentElementDecl) { }
        private System.Xml.Schema.XmlSchemaElement GetSchemaElement() { }
        private System.String GetDefaultAttributePrefix(System.String attributeNS) { }
        private System.Void AddIdentityConstraints() { }
        private System.Void ElementIdentityConstraints() { }
        private System.Void AttributeIdentityConstraints(System.String name, System.String ns, System.Object obj, System.String sobj, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Void EndElementIdentityConstraints(System.Object typedValue, System.String stringValue, System.Xml.Schema.XmlSchemaDatatype datatype) { }
        private System.Void ElementValidationError(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, System.Object sender, System.String sourceUri, System.Int32 lineNo, System.Int32 linePos, System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.Void CompleteValidationError(System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, System.Object sender, System.String sourceUri, System.Int32 lineNo, System.Int32 linePos, System.Xml.Schema.XmlSchemaSet schemaSet) { }
        private System.String PrintExpectedElements(System.Collections.ArrayList expected, System.Boolean getParticles) { }
        private System.String PrintNames(System.Collections.ArrayList expected) { }
        private System.Void PrintNamesWithNS(System.Collections.ArrayList expected, System.Text.StringBuilder builder) { }
        private System.Void EnumerateAny(System.Text.StringBuilder builder, System.String namespaces) { }
        private System.String QNameString(System.String localName, System.String ns) { }
        private System.String BuildElementName(System.Xml.XmlQualifiedName qname) { }
        private System.String BuildElementName(System.String localName, System.String ns) { }
        private System.Void ProcessEntity(System.String name) { }
        private System.Void SendValidationEvent(System.String code) { }
        private System.Void SendValidationEvent(System.String code, System.String[] args) { }
        private System.Void SendValidationEvent(System.String code, System.String arg) { }
        private System.Void SendValidationEvent(System.String code, System.String arg1, System.String arg2) { }
        private System.Void SendValidationEvent(System.String code, System.String[] args, System.Exception innerException, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void SendValidationEvent(System.String code, System.String[] args, System.Exception innerException) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e) { }
        private System.Void SendValidationEvent(System.String code, System.String msg, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void SendValidationEvent(System.Xml.Schema.ValidationEventHandler eventHandler, System.Object sender, System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000265
    public struct XmlSchemaValidity
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSchemaValidity NotKnown;        // 0x0
        public static System.Xml.Schema.XmlSchemaValidity Valid;        // 0x0
        public static System.Xml.Schema.XmlSchemaValidity Invalid;        // 0x0

    }

    // TypeToken: 0x2000266
    public struct XmlSeverityType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlSeverityType Error;        // 0x0
        public static System.Xml.Schema.XmlSeverityType Warning;        // 0x0

    }

    // TypeToken: 0x2000267
    public struct XmlTypeCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XmlTypeCode None;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Item;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Node;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Document;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Element;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Attribute;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Namespace;        // 0x0
        public static System.Xml.Schema.XmlTypeCode ProcessingInstruction;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Comment;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Text;        // 0x0
        public static System.Xml.Schema.XmlTypeCode AnyAtomicType;        // 0x0
        public static System.Xml.Schema.XmlTypeCode UntypedAtomic;        // 0x0
        public static System.Xml.Schema.XmlTypeCode String;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Boolean;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Decimal;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Float;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Double;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Duration;        // 0x0
        public static System.Xml.Schema.XmlTypeCode DateTime;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Time;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Date;        // 0x0
        public static System.Xml.Schema.XmlTypeCode GYearMonth;        // 0x0
        public static System.Xml.Schema.XmlTypeCode GYear;        // 0x0
        public static System.Xml.Schema.XmlTypeCode GMonthDay;        // 0x0
        public static System.Xml.Schema.XmlTypeCode GDay;        // 0x0
        public static System.Xml.Schema.XmlTypeCode GMonth;        // 0x0
        public static System.Xml.Schema.XmlTypeCode HexBinary;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Base64Binary;        // 0x0
        public static System.Xml.Schema.XmlTypeCode AnyUri;        // 0x0
        public static System.Xml.Schema.XmlTypeCode QName;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Notation;        // 0x0
        public static System.Xml.Schema.XmlTypeCode NormalizedString;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Token;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Language;        // 0x0
        public static System.Xml.Schema.XmlTypeCode NmToken;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Name;        // 0x0
        public static System.Xml.Schema.XmlTypeCode NCName;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Id;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Idref;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Entity;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Integer;        // 0x0
        public static System.Xml.Schema.XmlTypeCode NonPositiveInteger;        // 0x0
        public static System.Xml.Schema.XmlTypeCode NegativeInteger;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Long;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Int;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Short;        // 0x0
        public static System.Xml.Schema.XmlTypeCode Byte;        // 0x0
        public static System.Xml.Schema.XmlTypeCode NonNegativeInteger;        // 0x0
        public static System.Xml.Schema.XmlTypeCode UnsignedLong;        // 0x0
        public static System.Xml.Schema.XmlTypeCode UnsignedInt;        // 0x0
        public static System.Xml.Schema.XmlTypeCode UnsignedShort;        // 0x0
        public static System.Xml.Schema.XmlTypeCode UnsignedByte;        // 0x0
        public static System.Xml.Schema.XmlTypeCode PositiveInteger;        // 0x0
        public static System.Xml.Schema.XmlTypeCode YearMonthDuration;        // 0x0
        public static System.Xml.Schema.XmlTypeCode DayTimeDuration;        // 0x0

    }

    // TypeToken: 0x2000268
    public class XmlValueConverter
    {
        // Methods
        private System.Boolean ToBoolean(System.Int64 value) { }
        private System.Boolean ToBoolean(System.Int32 value) { }
        private System.Boolean ToBoolean(System.Double value) { }
        private System.Boolean ToBoolean(System.DateTime value) { }
        private System.Boolean ToBoolean(System.String value) { }
        private System.Boolean ToBoolean(System.Object value) { }
        private System.Int32 ToInt32(System.Boolean value) { }
        private System.Int32 ToInt32(System.Int64 value) { }
        private System.Int32 ToInt32(System.Double value) { }
        private System.Int32 ToInt32(System.DateTime value) { }
        private System.Int32 ToInt32(System.String value) { }
        private System.Int32 ToInt32(System.Object value) { }
        private System.Int64 ToInt64(System.Boolean value) { }
        private System.Int64 ToInt64(System.Int32 value) { }
        private System.Int64 ToInt64(System.Double value) { }
        private System.Int64 ToInt64(System.DateTime value) { }
        private System.Int64 ToInt64(System.String value) { }
        private System.Int64 ToInt64(System.Object value) { }
        private System.Decimal ToDecimal(System.String value) { }
        private System.Decimal ToDecimal(System.Object value) { }
        private System.Double ToDouble(System.Boolean value) { }
        private System.Double ToDouble(System.Int32 value) { }
        private System.Double ToDouble(System.Int64 value) { }
        private System.Double ToDouble(System.DateTime value) { }
        private System.Double ToDouble(System.String value) { }
        private System.Double ToDouble(System.Object value) { }
        private System.Single ToSingle(System.Double value) { }
        private System.Single ToSingle(System.String value) { }
        private System.Single ToSingle(System.Object value) { }
        private System.DateTime ToDateTime(System.Boolean value) { }
        private System.DateTime ToDateTime(System.Int32 value) { }
        private System.DateTime ToDateTime(System.Int64 value) { }
        private System.DateTime ToDateTime(System.Double value) { }
        private System.DateTime ToDateTime(System.DateTimeOffset value) { }
        private System.DateTime ToDateTime(System.String value) { }
        private System.DateTime ToDateTime(System.Object value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.DateTime value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.String value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.Object value) { }
        private System.String ToString(System.Boolean value) { }
        private System.String ToString(System.Int32 value) { }
        private System.String ToString(System.Int64 value) { }
        private System.String ToString(System.Decimal value) { }
        private System.String ToString(System.Single value) { }
        private System.String ToString(System.Double value) { }
        private System.String ToString(System.DateTime value) { }
        private System.String ToString(System.DateTimeOffset value) { }
        private System.String ToString(System.Object value) { }
        private System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Boolean value, System.Type destinationType) { }
        private System.Object ChangeType(System.Int32 value, System.Type destinationType) { }
        private System.Object ChangeType(System.Int64 value, System.Type destinationType) { }
        private System.Object ChangeType(System.Decimal value, System.Type destinationType) { }
        private System.Object ChangeType(System.Double value, System.Type destinationType) { }
        private System.Object ChangeType(System.DateTime value, System.Type destinationType) { }
        private System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000269
    public class XmlBaseConverter : XmlValueConverter
    {
        // Fields
        private System.Xml.Schema.XmlSchemaType schemaType;        // 0x10
        private System.Xml.Schema.XmlTypeCode typeCode;        // 0x18
        private System.Type clrTypeDefault;        // 0x20
        protected static readonly System.Type ICollectionType;        // 0x0
        protected static readonly System.Type IEnumerableType;        // 0x8
        protected static readonly System.Type IListType;        // 0x10
        protected static readonly System.Type ObjectArrayType;        // 0x18
        protected static readonly System.Type StringArrayType;        // 0x20
        protected static readonly System.Type XmlAtomicValueArrayType;        // 0x28
        protected static readonly System.Type DecimalType;        // 0x30
        protected static readonly System.Type Int32Type;        // 0x38
        protected static readonly System.Type Int64Type;        // 0x40
        protected static readonly System.Type StringType;        // 0x48
        protected static readonly System.Type XmlAtomicValueType;        // 0x50
        protected static readonly System.Type ObjectType;        // 0x58
        protected static readonly System.Type ByteType;        // 0x60
        protected static readonly System.Type Int16Type;        // 0x68
        protected static readonly System.Type SByteType;        // 0x70
        protected static readonly System.Type UInt16Type;        // 0x78
        protected static readonly System.Type UInt32Type;        // 0x80
        protected static readonly System.Type UInt64Type;        // 0x88
        protected static readonly System.Type XPathItemType;        // 0x90
        protected static readonly System.Type DoubleType;        // 0x98
        protected static readonly System.Type SingleType;        // 0xA0
        protected static readonly System.Type DateTimeType;        // 0xA8
        protected static readonly System.Type DateTimeOffsetType;        // 0xB0
        protected static readonly System.Type BooleanType;        // 0xB8
        protected static readonly System.Type ByteArrayType;        // 0xC0
        protected static readonly System.Type XmlQualifiedNameType;        // 0xC8
        protected static readonly System.Type UriType;        // 0xD0
        protected static readonly System.Type TimeSpanType;        // 0xD8
        protected static readonly System.Type XPathNavigatorType;        // 0xE0

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Void .ctor(System.Xml.Schema.XmlTypeCode typeCode) { }
        private System.Void .ctor(System.Xml.Schema.XmlBaseConverter converterAtomic) { }
        private System.Void .ctor(System.Xml.Schema.XmlBaseConverter converterAtomic, System.Type clrTypeDefault) { }
        private System.Boolean ToBoolean(System.DateTime value) { }
        private System.Boolean ToBoolean(System.Double value) { }
        private System.Boolean ToBoolean(System.Int32 value) { }
        private System.Boolean ToBoolean(System.Int64 value) { }
        private System.Boolean ToBoolean(System.String value) { }
        private System.Boolean ToBoolean(System.Object value) { }
        private System.DateTime ToDateTime(System.Boolean value) { }
        private System.DateTime ToDateTime(System.DateTimeOffset value) { }
        private System.DateTime ToDateTime(System.Double value) { }
        private System.DateTime ToDateTime(System.Int32 value) { }
        private System.DateTime ToDateTime(System.Int64 value) { }
        private System.DateTime ToDateTime(System.String value) { }
        private System.DateTime ToDateTime(System.Object value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.DateTime value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.String value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.Object value) { }
        private System.Decimal ToDecimal(System.String value) { }
        private System.Decimal ToDecimal(System.Object value) { }
        private System.Double ToDouble(System.Boolean value) { }
        private System.Double ToDouble(System.DateTime value) { }
        private System.Double ToDouble(System.Int32 value) { }
        private System.Double ToDouble(System.Int64 value) { }
        private System.Double ToDouble(System.String value) { }
        private System.Double ToDouble(System.Object value) { }
        private System.Int32 ToInt32(System.Boolean value) { }
        private System.Int32 ToInt32(System.DateTime value) { }
        private System.Int32 ToInt32(System.Double value) { }
        private System.Int32 ToInt32(System.Int64 value) { }
        private System.Int32 ToInt32(System.String value) { }
        private System.Int32 ToInt32(System.Object value) { }
        private System.Int64 ToInt64(System.Boolean value) { }
        private System.Int64 ToInt64(System.DateTime value) { }
        private System.Int64 ToInt64(System.Double value) { }
        private System.Int64 ToInt64(System.Int32 value) { }
        private System.Int64 ToInt64(System.String value) { }
        private System.Int64 ToInt64(System.Object value) { }
        private System.Single ToSingle(System.Double value) { }
        private System.Single ToSingle(System.String value) { }
        private System.Single ToSingle(System.Object value) { }
        private System.String ToString(System.Boolean value) { }
        private System.String ToString(System.DateTime value) { }
        private System.String ToString(System.DateTimeOffset value) { }
        private System.String ToString(System.Decimal value) { }
        private System.String ToString(System.Double value) { }
        private System.String ToString(System.Int32 value) { }
        private System.String ToString(System.Int64 value) { }
        private System.String ToString(System.Single value) { }
        private System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.String ToString(System.Object value) { }
        private System.Object ChangeType(System.Boolean value, System.Type destinationType) { }
        private System.Object ChangeType(System.DateTime value, System.Type destinationType) { }
        private System.Object ChangeType(System.Decimal value, System.Type destinationType) { }
        private System.Object ChangeType(System.Double value, System.Type destinationType) { }
        private System.Object ChangeType(System.Int32 value, System.Type destinationType) { }
        private System.Object ChangeType(System.Int64 value, System.Type destinationType) { }
        private System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType) { }
        private System.Xml.Schema.XmlSchemaType get_SchemaType() { }
        private System.Xml.Schema.XmlTypeCode get_TypeCode() { }
        private System.String get_XmlTypeName() { }
        private System.Type get_DefaultClrType() { }
        private System.Boolean IsDerivedFrom(System.Type derivedType, System.Type baseType) { }
        private System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType) { }
        private System.String QNameToString(System.Xml.XmlQualifiedName name) { }
        private System.Object ChangeListType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Byte[] StringToBase64Binary(System.String value) { }
        private System.DateTime StringToDate(System.String value) { }
        private System.DateTime StringToDateTime(System.String value) { }
        private System.TimeSpan StringToDayTimeDuration(System.String value) { }
        private System.TimeSpan StringToDuration(System.String value) { }
        private System.DateTime StringToGDay(System.String value) { }
        private System.DateTime StringToGMonth(System.String value) { }
        private System.DateTime StringToGMonthDay(System.String value) { }
        private System.DateTime StringToGYear(System.String value) { }
        private System.DateTime StringToGYearMonth(System.String value) { }
        private System.DateTimeOffset StringToDateOffset(System.String value) { }
        private System.DateTimeOffset StringToDateTimeOffset(System.String value) { }
        private System.DateTimeOffset StringToGDayOffset(System.String value) { }
        private System.DateTimeOffset StringToGMonthOffset(System.String value) { }
        private System.DateTimeOffset StringToGMonthDayOffset(System.String value) { }
        private System.DateTimeOffset StringToGYearOffset(System.String value) { }
        private System.DateTimeOffset StringToGYearMonthOffset(System.String value) { }
        private System.Byte[] StringToHexBinary(System.String value) { }
        private System.Xml.XmlQualifiedName StringToQName(System.String value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.DateTime StringToTime(System.String value) { }
        private System.DateTimeOffset StringToTimeOffset(System.String value) { }
        private System.TimeSpan StringToYearMonthDuration(System.String value) { }
        private System.String AnyUriToString(System.Uri value) { }
        private System.String Base64BinaryToString(System.Byte[] value) { }
        private System.String DateToString(System.DateTime value) { }
        private System.String DateTimeToString(System.DateTime value) { }
        private System.String DayTimeDurationToString(System.TimeSpan value) { }
        private System.String DurationToString(System.TimeSpan value) { }
        private System.String GDayToString(System.DateTime value) { }
        private System.String GMonthToString(System.DateTime value) { }
        private System.String GMonthDayToString(System.DateTime value) { }
        private System.String GYearToString(System.DateTime value) { }
        private System.String GYearMonthToString(System.DateTime value) { }
        private System.String DateOffsetToString(System.DateTimeOffset value) { }
        private System.String DateTimeOffsetToString(System.DateTimeOffset value) { }
        private System.String GDayOffsetToString(System.DateTimeOffset value) { }
        private System.String GMonthOffsetToString(System.DateTimeOffset value) { }
        private System.String GMonthDayOffsetToString(System.DateTimeOffset value) { }
        private System.String GYearOffsetToString(System.DateTimeOffset value) { }
        private System.String GYearMonthOffsetToString(System.DateTimeOffset value) { }
        private System.String QNameToString(System.Xml.XmlQualifiedName qname, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.String TimeToString(System.DateTime value) { }
        private System.String TimeOffsetToString(System.DateTimeOffset value) { }
        private System.String YearMonthDurationToString(System.TimeSpan value) { }
        private System.DateTime DateTimeOffsetToDateTime(System.DateTimeOffset value) { }
        private System.Int32 DecimalToInt32(System.Decimal value) { }
        private System.Int64 DecimalToInt64(System.Decimal value) { }
        private System.UInt64 DecimalToUInt64(System.Decimal value) { }
        private System.Byte Int32ToByte(System.Int32 value) { }
        private System.Int16 Int32ToInt16(System.Int32 value) { }
        private System.SByte Int32ToSByte(System.Int32 value) { }
        private System.UInt16 Int32ToUInt16(System.Int32 value) { }
        private System.Int32 Int64ToInt32(System.Int64 value) { }
        private System.UInt32 Int64ToUInt32(System.Int64 value) { }
        private System.DateTime UntypedAtomicToDateTime(System.String value) { }
        private System.DateTimeOffset UntypedAtomicToDateTimeOffset(System.String value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200026A
    public class XmlNumeric10Converter : XmlBaseConverter
    {
        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Decimal ToDecimal(System.String value) { }
        private System.Decimal ToDecimal(System.Object value) { }
        private System.Int32 ToInt32(System.Int64 value) { }
        private System.Int32 ToInt32(System.String value) { }
        private System.Int32 ToInt32(System.Object value) { }
        private System.Int64 ToInt64(System.Int32 value) { }
        private System.Int64 ToInt64(System.String value) { }
        private System.Int64 ToInt64(System.Object value) { }
        private System.String ToString(System.Decimal value) { }
        private System.String ToString(System.Int32 value) { }
        private System.String ToString(System.Int64 value) { }
        private System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Decimal value, System.Type destinationType) { }
        private System.Object ChangeType(System.Int32 value, System.Type destinationType) { }
        private System.Object ChangeType(System.Int64 value, System.Type destinationType) { }
        private System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeTypeWildcardDestination(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeTypeWildcardSource(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }

    }

    // TypeToken: 0x200026B
    public class XmlNumeric2Converter : XmlBaseConverter
    {
        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Double ToDouble(System.String value) { }
        private System.Double ToDouble(System.Object value) { }
        private System.Single ToSingle(System.Double value) { }
        private System.Single ToSingle(System.String value) { }
        private System.Single ToSingle(System.Object value) { }
        private System.String ToString(System.Double value) { }
        private System.String ToString(System.Single value) { }
        private System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Double value, System.Type destinationType) { }
        private System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }

    }

    // TypeToken: 0x200026C
    public class XmlDateTimeConverter : XmlBaseConverter
    {
        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.DateTime ToDateTime(System.DateTimeOffset value) { }
        private System.DateTime ToDateTime(System.String value) { }
        private System.DateTime ToDateTime(System.Object value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.DateTime value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.String value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.Object value) { }
        private System.String ToString(System.DateTime value) { }
        private System.String ToString(System.DateTimeOffset value) { }
        private System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.DateTime value, System.Type destinationType) { }
        private System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }

    }

    // TypeToken: 0x200026D
    public class XmlBooleanConverter : XmlBaseConverter
    {
        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Boolean ToBoolean(System.String value) { }
        private System.Boolean ToBoolean(System.Object value) { }
        private System.String ToString(System.Boolean value) { }
        private System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Boolean value, System.Type destinationType) { }
        private System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }

    }

    // TypeToken: 0x200026E
    public class XmlMiscConverter : XmlBaseConverter
    {
        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeTypeWildcardDestination(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeTypeWildcardSource(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }

    }

    // TypeToken: 0x200026F
    public class XmlStringConverter : XmlBaseConverter
    {
        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }

    }

    // TypeToken: 0x2000270
    public class XmlUntypedConverter : XmlListConverter
    {
        // Fields
        private System.Boolean allowListToList;        // 0x30
        public static readonly System.Xml.Schema.XmlValueConverter Untyped;        // 0x0
        public static readonly System.Xml.Schema.XmlValueConverter UntypedList;        // 0x8

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Xml.Schema.XmlUntypedConverter atomicConverter, System.Boolean allowListToList) { }
        private System.Boolean ToBoolean(System.String value) { }
        private System.Boolean ToBoolean(System.Object value) { }
        private System.DateTime ToDateTime(System.String value) { }
        private System.DateTime ToDateTime(System.Object value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.String value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.Object value) { }
        private System.Decimal ToDecimal(System.String value) { }
        private System.Decimal ToDecimal(System.Object value) { }
        private System.Double ToDouble(System.String value) { }
        private System.Double ToDouble(System.Object value) { }
        private System.Int32 ToInt32(System.String value) { }
        private System.Int32 ToInt32(System.Object value) { }
        private System.Int64 ToInt64(System.String value) { }
        private System.Int64 ToInt64(System.Object value) { }
        private System.Single ToSingle(System.String value) { }
        private System.Single ToSingle(System.Object value) { }
        private System.String ToString(System.Boolean value) { }
        private System.String ToString(System.DateTime value) { }
        private System.String ToString(System.DateTimeOffset value) { }
        private System.String ToString(System.Decimal value) { }
        private System.String ToString(System.Double value) { }
        private System.String ToString(System.Int32 value) { }
        private System.String ToString(System.Int64 value) { }
        private System.String ToString(System.Single value) { }
        private System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Boolean value, System.Type destinationType) { }
        private System.Object ChangeType(System.DateTime value, System.Type destinationType) { }
        private System.Object ChangeType(System.Decimal value, System.Type destinationType) { }
        private System.Object ChangeType(System.Double value, System.Type destinationType) { }
        private System.Object ChangeType(System.Int32 value, System.Type destinationType) { }
        private System.Object ChangeType(System.Int64 value, System.Type destinationType) { }
        private System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeTypeWildcardDestination(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeTypeWildcardSource(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeListType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Boolean SupportsType(System.Type clrType) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000271
    public class XmlAnyConverter : XmlBaseConverter
    {
        // Fields
        public static readonly System.Xml.Schema.XmlValueConverter Item;        // 0x0
        public static readonly System.Xml.Schema.XmlValueConverter AnyAtomic;        // 0x8

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlTypeCode typeCode) { }
        private System.Boolean ToBoolean(System.Object value) { }
        private System.DateTime ToDateTime(System.Object value) { }
        private System.DateTimeOffset ToDateTimeOffset(System.Object value) { }
        private System.Decimal ToDecimal(System.Object value) { }
        private System.Double ToDouble(System.Object value) { }
        private System.Int32 ToInt32(System.Object value) { }
        private System.Int64 ToInt64(System.Object value) { }
        private System.Single ToSingle(System.Object value) { }
        private System.Object ChangeType(System.Boolean value, System.Type destinationType) { }
        private System.Object ChangeType(System.DateTime value, System.Type destinationType) { }
        private System.Object ChangeType(System.Decimal value, System.Type destinationType) { }
        private System.Object ChangeType(System.Double value, System.Type destinationType) { }
        private System.Object ChangeType(System.Int32 value, System.Type destinationType) { }
        private System.Object ChangeType(System.Int64 value, System.Type destinationType) { }
        private System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeTypeWildcardDestination(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeTypeWildcardSource(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Xml.XPath.XPathNavigator ToNavigator(System.Xml.XPath.XPathNavigator nav) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000272
    public class XmlAnyListConverter : XmlListConverter
    {
        // Fields
        public static readonly System.Xml.Schema.XmlValueConverter ItemList;        // 0x0
        public static readonly System.Xml.Schema.XmlValueConverter AnyAtomicList;        // 0x8

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlBaseConverter atomicConverter) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000273
    public class XmlListConverter : XmlBaseConverter
    {
        // Fields
        protected System.Xml.Schema.XmlValueConverter atomicConverter;        // 0x28

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlBaseConverter atomicConverter) { }
        private System.Void .ctor(System.Xml.Schema.XmlBaseConverter atomicConverter, System.Type clrTypeDefault) { }
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlValueConverter atomicConverter) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object ChangeListType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Boolean IsListType(System.Type type) { }
        private T[] ToArray(System.Object list, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Collections.IList ToList(System.Object list, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Collections.Generic.List<System.String> StringAsList(System.String value) { }
        private System.String ListAsString(System.Collections.IEnumerable list, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType) { }

    }

    // TypeToken: 0x2000274
    public class XmlUnionConverter : XmlBaseConverter
    {
        // Fields
        private System.Xml.Schema.XmlValueConverter[] converters;        // 0x28
        private System.Boolean hasAtomicMember;        // 0x30
        private System.Boolean hasListMember;        // 0x31

        // Methods
        private System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType) { }
        private System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver) { }

    }

    // TypeToken: 0x2000275
    public class XsdBuilder : SchemaBuilder
    {
        // Fields
        private static readonly System.Xml.Schema.XsdBuilder.State[] SchemaElement;        // 0x0
        private static readonly System.Xml.Schema.XsdBuilder.State[] SchemaSubelements;        // 0x8
        private static readonly System.Xml.Schema.XsdBuilder.State[] AttributeSubelements;        // 0x10
        private static readonly System.Xml.Schema.XsdBuilder.State[] ElementSubelements;        // 0x18
        private static readonly System.Xml.Schema.XsdBuilder.State[] ComplexTypeSubelements;        // 0x20
        private static readonly System.Xml.Schema.XsdBuilder.State[] SimpleContentSubelements;        // 0x28
        private static readonly System.Xml.Schema.XsdBuilder.State[] SimpleContentExtensionSubelements;        // 0x30
        private static readonly System.Xml.Schema.XsdBuilder.State[] SimpleContentRestrictionSubelements;        // 0x38
        private static readonly System.Xml.Schema.XsdBuilder.State[] ComplexContentSubelements;        // 0x40
        private static readonly System.Xml.Schema.XsdBuilder.State[] ComplexContentExtensionSubelements;        // 0x48
        private static readonly System.Xml.Schema.XsdBuilder.State[] ComplexContentRestrictionSubelements;        // 0x50
        private static readonly System.Xml.Schema.XsdBuilder.State[] SimpleTypeSubelements;        // 0x58
        private static readonly System.Xml.Schema.XsdBuilder.State[] SimpleTypeRestrictionSubelements;        // 0x60
        private static readonly System.Xml.Schema.XsdBuilder.State[] SimpleTypeListSubelements;        // 0x68
        private static readonly System.Xml.Schema.XsdBuilder.State[] SimpleTypeUnionSubelements;        // 0x70
        private static readonly System.Xml.Schema.XsdBuilder.State[] RedefineSubelements;        // 0x78
        private static readonly System.Xml.Schema.XsdBuilder.State[] AttributeGroupSubelements;        // 0x80
        private static readonly System.Xml.Schema.XsdBuilder.State[] GroupSubelements;        // 0x88
        private static readonly System.Xml.Schema.XsdBuilder.State[] AllSubelements;        // 0x90
        private static readonly System.Xml.Schema.XsdBuilder.State[] ChoiceSequenceSubelements;        // 0x98
        private static readonly System.Xml.Schema.XsdBuilder.State[] IdentityConstraintSubelements;        // 0xA0
        private static readonly System.Xml.Schema.XsdBuilder.State[] AnnotationSubelements;        // 0xA8
        private static readonly System.Xml.Schema.XsdBuilder.State[] AnnotatedSubelements;        // 0xB0
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SchemaAttributes;        // 0xB8
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AttributeAttributes;        // 0xC0
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ElementAttributes;        // 0xC8
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes;        // 0xD0
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes;        // 0xD8
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes;        // 0xE0
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes;        // 0xE8
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes;        // 0xF0
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes;        // 0xF8
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes;        // 0x100
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes;        // 0x108
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes;        // 0x110
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes;        // 0x118
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes;        // 0x120
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes;        // 0x128
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes;        // 0x130
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] GroupAttributes;        // 0x138
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] GroupRefAttributes;        // 0x140
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ParticleAttributes;        // 0x148
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AnyAttributes;        // 0x150
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes;        // 0x158
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SelectorAttributes;        // 0x160
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] FieldAttributes;        // 0x168
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] NotationAttributes;        // 0x170
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] IncludeAttributes;        // 0x178
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ImportAttributes;        // 0x180
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] FacetAttributes;        // 0x188
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes;        // 0x190
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] DocumentationAttributes;        // 0x198
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AppinfoAttributes;        // 0x1A0
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] RedefineAttributes;        // 0x1A8
        private static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AnnotationAttributes;        // 0x1B0
        private static readonly System.Xml.Schema.XsdBuilder.XsdEntry[] SchemaEntries;        // 0x1B8
        private static readonly System.Int32[] DerivationMethodValues;        // 0x1C0
        private static readonly System.String[] DerivationMethodStrings;        // 0x1C8
        private static readonly System.String[] FormStringValues;        // 0x1D0
        private static readonly System.String[] UseStringValues;        // 0x1D8
        private static readonly System.String[] ProcessContentsStringValues;        // 0x1E0
        private System.Xml.XmlReader reader;        // 0x10
        private System.Xml.PositionInfo positionInfo;        // 0x18
        private System.Xml.Schema.XsdBuilder.XsdEntry currentEntry;        // 0x20
        private System.Xml.Schema.XsdBuilder.XsdEntry nextEntry;        // 0x28
        private System.Boolean hasChild;        // 0x30
        private System.Xml.HWStack stateHistory;        // 0x38
        private System.Collections.Stack containerStack;        // 0x40
        private System.Xml.XmlNameTable nameTable;        // 0x48
        private System.Xml.Schema.SchemaNames schemaNames;        // 0x50
        private System.Xml.XmlNamespaceManager namespaceManager;        // 0x58
        private System.Boolean canIncludeImport;        // 0x60
        private System.Xml.Schema.XmlSchema schema;        // 0x68
        private System.Xml.Schema.XmlSchemaObject xso;        // 0x70
        private System.Xml.Schema.XmlSchemaElement element;        // 0x78
        private System.Xml.Schema.XmlSchemaAny anyElement;        // 0x80
        private System.Xml.Schema.XmlSchemaAttribute attribute;        // 0x88
        private System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;        // 0x90
        private System.Xml.Schema.XmlSchemaComplexType complexType;        // 0x98
        private System.Xml.Schema.XmlSchemaSimpleType simpleType;        // 0xA0
        private System.Xml.Schema.XmlSchemaComplexContent complexContent;        // 0xA8
        private System.Xml.Schema.XmlSchemaComplexContentExtension complexContentExtension;        // 0xB0
        private System.Xml.Schema.XmlSchemaComplexContentRestriction complexContentRestriction;        // 0xB8
        private System.Xml.Schema.XmlSchemaSimpleContent simpleContent;        // 0xC0
        private System.Xml.Schema.XmlSchemaSimpleContentExtension simpleContentExtension;        // 0xC8
        private System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleContentRestriction;        // 0xD0
        private System.Xml.Schema.XmlSchemaSimpleTypeUnion simpleTypeUnion;        // 0xD8
        private System.Xml.Schema.XmlSchemaSimpleTypeList simpleTypeList;        // 0xE0
        private System.Xml.Schema.XmlSchemaSimpleTypeRestriction simpleTypeRestriction;        // 0xE8
        private System.Xml.Schema.XmlSchemaGroup group;        // 0xF0
        private System.Xml.Schema.XmlSchemaGroupRef groupRef;        // 0xF8
        private System.Xml.Schema.XmlSchemaAll all;        // 0x100
        private System.Xml.Schema.XmlSchemaChoice choice;        // 0x108
        private System.Xml.Schema.XmlSchemaSequence sequence;        // 0x110
        private System.Xml.Schema.XmlSchemaParticle particle;        // 0x118
        private System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup;        // 0x120
        private System.Xml.Schema.XmlSchemaAttributeGroupRef attributeGroupRef;        // 0x128
        private System.Xml.Schema.XmlSchemaNotation notation;        // 0x130
        private System.Xml.Schema.XmlSchemaIdentityConstraint identityConstraint;        // 0x138
        private System.Xml.Schema.XmlSchemaXPath xpath;        // 0x140
        private System.Xml.Schema.XmlSchemaInclude include;        // 0x148
        private System.Xml.Schema.XmlSchemaImport import;        // 0x150
        private System.Xml.Schema.XmlSchemaAnnotation annotation;        // 0x158
        private System.Xml.Schema.XmlSchemaAppInfo appInfo;        // 0x160
        private System.Xml.Schema.XmlSchemaDocumentation documentation;        // 0x168
        private System.Xml.Schema.XmlSchemaFacet facet;        // 0x170
        private System.Xml.XmlNode[] markup;        // 0x178
        private System.Xml.Schema.XmlSchemaRedefine redefine;        // 0x180
        private System.Xml.Schema.ValidationEventHandler validationEventHandler;        // 0x188
        private System.Collections.ArrayList unhandledAttributes;        // 0x190
        private System.Collections.Hashtable namespaces;        // 0x198

        // Methods
        private System.Void .ctor(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.XmlSchema schema, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler) { }
        private System.Boolean ProcessElement(System.String prefix, System.String name, System.String ns) { }
        private System.Void ProcessAttribute(System.String prefix, System.String name, System.String ns, System.String value) { }
        private System.Boolean IsContentParsed() { }
        private System.Void ProcessMarkup(System.Xml.XmlNode[] markup) { }
        private System.Void ProcessCData(System.String value) { }
        private System.Void StartChildren() { }
        private System.Void EndChildren() { }
        private System.Void Push() { }
        private System.Void Pop() { }
        private System.Xml.Schema.SchemaNames.Token get_CurrentElement() { }
        private System.Xml.Schema.SchemaNames.Token get_ParentElement() { }
        private System.Xml.Schema.XmlSchemaObject get_ParentContainer() { }
        private System.Xml.Schema.XmlSchemaObject GetContainer(System.Xml.Schema.XsdBuilder.State state) { }
        private System.Void SetContainer(System.Xml.Schema.XsdBuilder.State state, System.Object container) { }
        private System.Void BuildAnnotated_Id(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSchema_AttributeFormDefault(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSchema_ElementFormDefault(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSchema_TargetNamespace(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSchema_Version(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSchema_FinalDefault(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSchema_BlockDefault(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitSchema(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitInclude(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildInclude_SchemaLocation(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitImport(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildImport_Namespace(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildImport_SchemaLocation(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitRedefine(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildRedefine_SchemaLocation(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void EndRedefine(System.Xml.Schema.XsdBuilder builder) { }
        private System.Void InitAttribute(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAttribute_Default(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAttribute_Fixed(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAttribute_Form(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAttribute_Use(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAttribute_Ref(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAttribute_Name(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAttribute_Type(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitElement(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_Abstract(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_Block(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_Default(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_Form(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_SubstitutionGroup(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_Final(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_Fixed(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_MaxOccurs(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_MinOccurs(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_Name(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_Nillable(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_Ref(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildElement_Type(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitSimpleType(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSimpleType_Name(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSimpleType_Final(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitSimpleTypeUnion(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSimpleTypeUnion_MemberTypes(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitSimpleTypeList(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSimpleTypeList_ItemType(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitSimpleTypeRestriction(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSimpleTypeRestriction_Base(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitComplexType(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildComplexType_Abstract(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildComplexType_Block(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildComplexType_Final(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildComplexType_Mixed(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildComplexType_Name(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitComplexContent(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildComplexContent_Mixed(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitComplexContentExtension(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildComplexContentExtension_Base(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitComplexContentRestriction(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildComplexContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitSimpleContent(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitSimpleContentExtension(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSimpleContentExtension_Base(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitSimpleContentRestriction(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSimpleContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitAttributeGroup(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAttributeGroup_Name(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitAttributeGroupRef(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAttributeGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitAnyAttribute(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAnyAttribute_Namespace(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAnyAttribute_ProcessContents(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitGroup(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildGroup_Name(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitGroupRef(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildParticle_MaxOccurs(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildParticle_MinOccurs(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitAll(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitChoice(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitSequence(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitAny(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAny_Namespace(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAny_ProcessContents(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitNotation(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildNotation_Name(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildNotation_Public(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildNotation_System(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitFacet(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildFacet_Fixed(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildFacet_Value(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitIdentityConstraint(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildIdentityConstraint_Name(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildIdentityConstraint_Refer(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitSelector(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildSelector_XPath(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitField(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildField_XPath(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitAnnotation(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void InitAppinfo(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildAppinfo_Source(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void EndAppinfo(System.Xml.Schema.XsdBuilder builder) { }
        private System.Void InitDocumentation(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildDocumentation_Source(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void BuildDocumentation_XmlLang(System.Xml.Schema.XsdBuilder builder, System.String value) { }
        private System.Void EndDocumentation(System.Xml.Schema.XsdBuilder builder) { }
        private System.Void AddAttribute(System.Xml.Schema.XmlSchemaObject value) { }
        private System.Void AddParticle(System.Xml.Schema.XmlSchemaParticle particle) { }
        private System.Boolean GetNextState(System.Xml.XmlQualifiedName qname) { }
        private System.Boolean IsSkipableElement(System.Xml.XmlQualifiedName qname) { }
        private System.Void SetMinOccurs(System.Xml.Schema.XmlSchemaParticle particle, System.String value) { }
        private System.Void SetMaxOccurs(System.Xml.Schema.XmlSchemaParticle particle, System.String value) { }
        private System.Boolean ParseBoolean(System.String value, System.String attributeName) { }
        private System.Int32 ParseEnum(System.String value, System.String attributeName, System.String[] values) { }
        private System.Xml.XmlQualifiedName ParseQName(System.String value, System.String attributeName) { }
        private System.Int32 ParseBlockFinalEnum(System.String value, System.String attributeName) { }
        private System.String ParseUriReference(System.String s) { }
        private System.Void SendValidationEvent(System.String code, System.String arg0, System.String arg1, System.String arg2) { }
        private System.Void SendValidationEvent(System.String code, System.String msg) { }
        private System.Void SendValidationEvent(System.String code, System.String[] args, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity) { }
        private System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e) { }
        private System.Void RecordPosition() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200027D
    public struct XsdDateTimeFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Schema.XsdDateTimeFlags DateTime;        // 0x0
        public static System.Xml.Schema.XsdDateTimeFlags Time;        // 0x0
        public static System.Xml.Schema.XsdDateTimeFlags Date;        // 0x0
        public static System.Xml.Schema.XsdDateTimeFlags GYearMonth;        // 0x0
        public static System.Xml.Schema.XsdDateTimeFlags GYear;        // 0x0
        public static System.Xml.Schema.XsdDateTimeFlags GMonthDay;        // 0x0
        public static System.Xml.Schema.XsdDateTimeFlags GDay;        // 0x0
        public static System.Xml.Schema.XsdDateTimeFlags GMonth;        // 0x0
        public static System.Xml.Schema.XsdDateTimeFlags XdrDateTimeNoTz;        // 0x0
        public static System.Xml.Schema.XsdDateTimeFlags XdrDateTime;        // 0x0
        public static System.Xml.Schema.XsdDateTimeFlags XdrTimeNoTz;        // 0x0
        public static System.Xml.Schema.XsdDateTimeFlags AllXsd;        // 0x0

    }

    // TypeToken: 0x200027E
    public struct XsdDateTime
    {
        // Fields
        private System.DateTime dt;        // 0x10
        private System.UInt32 extra;        // 0x18
        private static readonly System.Int32 Lzyyyy;        // 0x0
        private static readonly System.Int32 Lzyyyy_;        // 0x4
        private static readonly System.Int32 Lzyyyy_MM;        // 0x8
        private static readonly System.Int32 Lzyyyy_MM_;        // 0xC
        private static readonly System.Int32 Lzyyyy_MM_dd;        // 0x10
        private static readonly System.Int32 Lzyyyy_MM_ddT;        // 0x14
        private static readonly System.Int32 LzHH;        // 0x18
        private static readonly System.Int32 LzHH_;        // 0x1C
        private static readonly System.Int32 LzHH_mm;        // 0x20
        private static readonly System.Int32 LzHH_mm_;        // 0x24
        private static readonly System.Int32 LzHH_mm_ss;        // 0x28
        private static readonly System.Int32 Lz_;        // 0x2C
        private static readonly System.Int32 Lz_zz;        // 0x30
        private static readonly System.Int32 Lz_zz_;        // 0x34
        private static readonly System.Int32 Lz_zz_zz;        // 0x38
        private static readonly System.Int32 Lz__;        // 0x3C
        private static readonly System.Int32 Lz__mm;        // 0x40
        private static readonly System.Int32 Lz__mm_;        // 0x44
        private static readonly System.Int32 Lz__mm__;        // 0x48
        private static readonly System.Int32 Lz__mm_dd;        // 0x4C
        private static readonly System.Int32 Lz___;        // 0x50
        private static readonly System.Int32 Lz___dd;        // 0x54
        private static readonly System.Xml.Schema.XmlTypeCode[] typeCodes;        // 0x58

        // Methods
        private System.Void .ctor(System.String text, System.Xml.Schema.XsdDateTimeFlags kinds) { }
        private System.Void .ctor(System.Xml.Schema.XsdDateTime.Parser parser) { }
        private System.Void InitiateXsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser) { }
        private System.Boolean TryParse(System.String text, System.Xml.Schema.XsdDateTimeFlags kinds, System.Xml.Schema.XsdDateTime& result) { }
        private System.Void .ctor(System.DateTime dateTime, System.Xml.Schema.XsdDateTimeFlags kinds) { }
        private System.Void .ctor(System.DateTimeOffset dateTimeOffset) { }
        private System.Void .ctor(System.DateTimeOffset dateTimeOffset, System.Xml.Schema.XsdDateTimeFlags kinds) { }
        private System.Xml.Schema.XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }
        private System.Xml.Schema.XsdDateTime.XsdDateTimeKind get_InternalKind() { }
        private System.Int32 get_Year() { }
        private System.Int32 get_Month() { }
        private System.Int32 get_Day() { }
        private System.Int32 get_Hour() { }
        private System.Int32 get_Minute() { }
        private System.Int32 get_Second() { }
        private System.Int32 get_Fraction() { }
        private System.Int32 get_ZoneHour() { }
        private System.Int32 get_ZoneMinute() { }
        private System.DateTime op_Implicit(System.Xml.Schema.XsdDateTime xdt) { }
        private System.DateTimeOffset op_Implicit(System.Xml.Schema.XsdDateTime xdt) { }
        private System.String ToString() { }
        private System.Void PrintDate(System.Text.StringBuilder sb) { }
        private System.Void PrintTime(System.Text.StringBuilder sb) { }
        private System.Void PrintZone(System.Text.StringBuilder sb) { }
        private System.Void IntToCharArray(System.Char[] text, System.Int32 start, System.Int32 value, System.Int32 digits) { }
        private System.Void ShortToCharArray(System.Char[] text, System.Int32 start, System.Int32 value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000282
    public struct XsdDuration
    {
        // Fields
        private System.Int32 years;        // 0x10
        private System.Int32 months;        // 0x14
        private System.Int32 days;        // 0x18
        private System.Int32 hours;        // 0x1C
        private System.Int32 minutes;        // 0x20
        private System.Int32 seconds;        // 0x24
        private System.UInt32 nanoseconds;        // 0x28

        // Methods
        private System.Void .ctor(System.Boolean isNegative, System.Int32 years, System.Int32 months, System.Int32 days, System.Int32 hours, System.Int32 minutes, System.Int32 seconds, System.Int32 nanoseconds) { }
        private System.Void .ctor(System.TimeSpan timeSpan) { }
        private System.Void .ctor(System.TimeSpan timeSpan, System.Xml.Schema.XsdDuration.DurationType durationType) { }
        private System.Void .ctor(System.String s) { }
        private System.Void .ctor(System.String s, System.Xml.Schema.XsdDuration.DurationType durationType) { }
        private System.Boolean get_IsNegative() { }
        private System.Int32 get_Years() { }
        private System.Int32 get_Months() { }
        private System.Int32 get_Days() { }
        private System.Int32 get_Hours() { }
        private System.Int32 get_Minutes() { }
        private System.Int32 get_Seconds() { }
        private System.Int32 get_Nanoseconds() { }
        private System.TimeSpan ToTimeSpan() { }
        private System.TimeSpan ToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType) { }
        private System.Exception TryToTimeSpan(System.TimeSpan& result) { }
        private System.Exception TryToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType, System.TimeSpan& result) { }
        private System.String ToString() { }
        private System.String ToString(System.Xml.Schema.XsdDuration.DurationType durationType) { }
        private System.Exception TryParse(System.String s, System.Xml.Schema.XsdDuration& result) { }
        private System.Exception TryParse(System.String s, System.Xml.Schema.XsdDuration.DurationType durationType, System.Xml.Schema.XsdDuration& result) { }
        private System.String TryParseDigits(System.String s, System.Int32& offset, System.Boolean eatDigits, System.Int32& result, System.Int32& numDigits) { }

    }

    // TypeToken: 0x2000285
    public class XsdValidator : BaseValidator
    {
        // Fields
        private System.Int32 startIDConstraint;        // 0x80
        private System.Xml.HWStack validationStack;        // 0x88
        private System.Collections.Hashtable attPresence;        // 0x90
        private System.Xml.XmlNamespaceManager nsManager;        // 0x98
        private System.Boolean bManageNamespaces;        // 0xA0
        private System.Collections.Hashtable IDs;        // 0xA8
        private System.Xml.Schema.IdRefNode idRefListHead;        // 0xB0
        private System.Xml.Schema.Parser inlineSchemaParser;        // 0xB8
        private System.Xml.Schema.XmlSchemaContentProcessing processContents;        // 0xC0
        private static readonly System.Xml.Schema.XmlSchemaDatatype dtCDATA;        // 0x0
        private static readonly System.Xml.Schema.XmlSchemaDatatype dtQName;        // 0x8
        private static readonly System.Xml.Schema.XmlSchemaDatatype dtStringArray;        // 0x10
        private System.String NsXmlNs;        // 0xC8
        private System.String NsXs;        // 0xD0
        private System.String NsXsi;        // 0xD8
        private System.String XsiType;        // 0xE0
        private System.String XsiNil;        // 0xE8
        private System.String XsiSchemaLocation;        // 0xF0
        private System.String XsiNoNamespaceSchemaLocation;        // 0xF8
        private System.String XsdSchema;        // 0x100

        // Methods
        private System.Void .ctor(System.Xml.Schema.BaseValidator validator) { }
        private System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling) { }
        private System.Void Init() { }
        private System.Void Validate() { }
        private System.Void CompleteValidation() { }
        private System.Boolean get_IsInlineSchemaStarted() { }
        private System.Void ProcessInlineSchema() { }
        private System.Void ValidateElement() { }
        private System.Object ValidateChildElement() { }
        private System.Void ProcessElement(System.Object particle) { }
        private System.Void ProcessXsiAttributes(System.Xml.XmlQualifiedName& xsiType, System.String& xsiNil) { }
        private System.Void ValidateEndElement() { }
        private System.Xml.Schema.SchemaElementDecl FastGetElementDecl(System.Object particle) { }
        private System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl(System.Xml.Schema.SchemaElementDecl elementDecl, System.Xml.XmlQualifiedName xsiType, System.String xsiNil) { }
        private System.Void ValidateStartElement() { }
        private System.Void ValidateEndStartElement() { }
        private System.Void LoadSchemaFromLocation(System.String uri, System.String url) { }
        private System.Void LoadSchema(System.String uri, System.String url) { }
        private System.Boolean get_HasSchema() { }
        private System.Boolean get_PreserveWhitespace() { }
        private System.Void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, System.String name) { }
        private System.Void CheckValue(System.String value, System.Xml.Schema.SchemaAttDef attdef) { }
        private System.Void AddID(System.String name, System.Object node) { }
        private System.Object FindId(System.String name) { }
        private System.Boolean IsXSDRoot(System.String localName, System.String ns) { }
        private System.Void Push(System.Xml.XmlQualifiedName elementName) { }
        private System.Void Pop() { }
        private System.Void CheckForwardRefs() { }
        private System.Void ValidateStartElementIdentityConstraints() { }
        private System.Boolean get_HasIdentityConstraints() { }
        private System.Void AddIdentityConstraints() { }
        private System.Void ElementIdentityConstraints() { }
        private System.Void AttributeIdentityConstraints(System.String name, System.String ns, System.Object obj, System.String sobj, System.Xml.Schema.SchemaAttDef attdef) { }
        private System.Object UnWrapUnion(System.Object typedValue) { }
        private System.Void EndElementIdentityConstraints() { }
        private System.Void .cctor() { }

    }

}

namespace System.Xml.Serialization
{

    // TypeToken: 0x2000100
    public class CodeIdentifier
    {
        // Fields
        private static Microsoft.CSharp.CodeDomProvider csharp;        // 0x0

        // Methods
        private System.String MakePascal(System.String identifier) { }
        private System.String MakeValid(System.String identifier) { }
        private System.Boolean IsValidStart(System.Char c) { }
        private System.Boolean IsValid(System.Char c) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000101
    public class XmlSerializerNamespaces
    {
        // Fields
        private System.Collections.Hashtable namespaces;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void Add(System.String prefix, System.String ns) { }
        private System.Void AddInternal(System.String prefix, System.String ns) { }
        private System.Xml.XmlQualifiedName[] ToArray() { }
        private System.Int32 get_Count() { }
        private System.Collections.ArrayList get_NamespaceList() { }
        private System.Collections.Hashtable get_Namespaces() { }
        private System.Void set_Namespaces(System.Collections.Hashtable value) { }

    }

    // TypeToken: 0x2000102
    public class XmlAttributeEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Xml.Serialization.XmlAttributeEventArgs e) { }

    }

    // TypeToken: 0x2000103
    public class XmlAttributeEventArgs : EventArgs
    {
        // Fields
        private System.Object o;        // 0x10
        private System.Xml.XmlAttribute attr;        // 0x18
        private System.String qnames;        // 0x20
        private System.Int32 lineNumber;        // 0x28
        private System.Int32 linePosition;        // 0x2C

        // Methods
        private System.Void .ctor(System.Xml.XmlAttribute attr, System.Int32 lineNumber, System.Int32 linePosition, System.Object o, System.String qnames) { }

    }

    // TypeToken: 0x2000104
    public class XmlElementEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Xml.Serialization.XmlElementEventArgs e) { }

    }

    // TypeToken: 0x2000105
    public class XmlElementEventArgs : EventArgs
    {
        // Fields
        private System.Object o;        // 0x10
        private System.Xml.XmlElement elem;        // 0x18
        private System.String qnames;        // 0x20
        private System.Int32 lineNumber;        // 0x28
        private System.Int32 linePosition;        // 0x2C

        // Methods
        private System.Void .ctor(System.Xml.XmlElement elem, System.Int32 lineNumber, System.Int32 linePosition, System.Object o, System.String qnames) { }

    }

    // TypeToken: 0x2000106
    public class XmlNodeEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Xml.Serialization.XmlNodeEventArgs e) { }

    }

    // TypeToken: 0x2000107
    public class XmlNodeEventArgs : EventArgs
    {
        // Fields
        private System.Object o;        // 0x10
        private System.Xml.XmlNode xmlNode;        // 0x18
        private System.Int32 lineNumber;        // 0x20
        private System.Int32 linePosition;        // 0x24

        // Methods
        private System.Void .ctor(System.Xml.XmlNode xmlNode, System.Int32 lineNumber, System.Int32 linePosition, System.Object o) { }

    }

    // TypeToken: 0x2000108
    public class UnreferencedObjectEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object sender, System.Xml.Serialization.UnreferencedObjectEventArgs e) { }

    }

    // TypeToken: 0x2000109
    public class UnreferencedObjectEventArgs : EventArgs
    {
        // Fields
        private System.Object o;        // 0x10
        private System.String id;        // 0x18

        // Methods
        private System.Void .ctor(System.Object o, System.String id) { }

    }

    // TypeToken: 0x200010A
    public interface IXmlSerializable
    {
        // Methods
        private System.Xml.Schema.XmlSchema GetSchema() { }
        private System.Void ReadXml(System.Xml.XmlReader reader) { }
        private System.Void WriteXml(System.Xml.XmlWriter writer) { }

    }

    // TypeToken: 0x200010B
    public interface IXmlTextParser
    {
        // Methods
        private System.Boolean get_Normalized() { }
        private System.Void set_Normalized(System.Boolean value) { }

    }

    // TypeToken: 0x200010C
    public class KeyHelper
    {
        // Methods
        private System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.String val) { }
        private System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.String val, System.String def) { }
        private System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.Boolean val) { }
        private System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.Boolean val, System.Boolean def) { }
        private System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.Int32 val, System.Int32 def) { }
        private System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.Type val) { }

    }

    // TypeToken: 0x200010D
    public class ReflectionHelper
    {
        // Fields
        private System.Collections.Hashtable _clrTypes;        // 0x10
        private System.Collections.Hashtable _schemaTypes;        // 0x18
        private static readonly System.Reflection.ParameterModifier[] empty_modifiers;        // 0x0

        // Methods
        private System.Void RegisterSchemaType(System.Xml.Serialization.XmlTypeMapping map, System.String xmlType, System.String ns) { }
        private System.Xml.Serialization.XmlTypeMapping GetRegisteredSchemaType(System.String xmlType, System.String ns) { }
        private System.Void RegisterClrType(System.Xml.Serialization.XmlTypeMapping map, System.Type type, System.String ns) { }
        private System.Xml.Serialization.XmlTypeMapping GetRegisteredClrType(System.Type type, System.String ns) { }
        private System.Void CheckSerializableType(System.Type type, System.Boolean allowPrivateConstructors) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200010E
    public struct SchemaTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Serialization.SchemaTypes NotSet;        // 0x0
        public static System.Xml.Serialization.SchemaTypes Primitive;        // 0x0
        public static System.Xml.Serialization.SchemaTypes Enum;        // 0x0
        public static System.Xml.Serialization.SchemaTypes Array;        // 0x0
        public static System.Xml.Serialization.SchemaTypes Class;        // 0x0
        public static System.Xml.Serialization.SchemaTypes XmlSerializable;        // 0x0
        public static System.Xml.Serialization.SchemaTypes XmlNode;        // 0x0
        public static System.Xml.Serialization.SchemaTypes Void;        // 0x0

    }

    // TypeToken: 0x200010F
    public class SerializationSource
    {
        // Fields
        private System.Type[] includedTypes;        // 0x10
        private System.String namspace;        // 0x18
        private System.Boolean canBeGenerated;        // 0x20

        // Methods
        private System.Void .ctor(System.String namspace, System.Type[] includedTypes) { }
        private System.Boolean BaseEquals(System.Xml.Serialization.SerializationSource other) { }

    }

    // TypeToken: 0x2000110
    public class XmlTypeSerializationSource : SerializationSource
    {
        // Fields
        private System.String attributeOverridesHash;        // 0x28
        private System.Type type;        // 0x30
        private System.String rootHash;        // 0x38

        // Methods
        private System.Void .ctor(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, System.String namspace, System.Type[] includedTypes) { }
        private System.Boolean Equals(System.Object o) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000111
    public class XmlTypeConvertorAttribute : Attribute
    {
        // Fields
        private System.String <Method>k__BackingField;        // 0x10

        // Methods
        private System.String get_Method() { }
        private System.Void set_Method(System.String value) { }
        private System.Void .ctor(System.String method) { }

    }

    // TypeToken: 0x2000112
    public class TypeData
    {
        // Fields
        private System.Type type;        // 0x10
        private System.String elementName;        // 0x18
        private System.Xml.Serialization.SchemaTypes sType;        // 0x20
        private System.Type listItemType;        // 0x28
        private System.String typeName;        // 0x30
        private System.String fullTypeName;        // 0x38
        private System.Xml.Serialization.TypeData listItemTypeData;        // 0x40
        private System.Xml.Serialization.TypeData mappedType;        // 0x48
        private System.Xml.Schema.XmlSchemaPatternFacet facet;        // 0x50
        private System.Reflection.MethodInfo typeConvertor;        // 0x58
        private System.Boolean hasPublicConstructor;        // 0x60
        private System.Boolean nullableOverride;        // 0x61
        private static System.String[] keywords;        // 0x0

        // Methods
        private System.Void .ctor(System.Type type, System.String elementName, System.Boolean isPrimitive) { }
        private System.Void .ctor(System.Type type, System.String elementName, System.Boolean isPrimitive, System.Xml.Serialization.TypeData mappedType, System.Xml.Schema.XmlSchemaPatternFacet facet) { }
        private System.Void LookupTypeConvertor() { }
        private System.Void ConvertForAssignment(System.Object& value) { }
        private System.String get_TypeName() { }
        private System.String get_XmlType() { }
        private System.Type get_Type() { }
        private System.String get_FullTypeName() { }
        private System.Xml.Serialization.SchemaTypes get_SchemaType() { }
        private System.Boolean get_IsListType() { }
        private System.Boolean get_IsComplexType() { }
        private System.Boolean get_IsValueType() { }
        private System.Boolean get_IsNullable() { }
        private System.Void set_IsNullable(System.Boolean value) { }
        private System.Xml.Serialization.TypeData get_ListItemTypeData() { }
        private System.Type get_ListItemType() { }
        private System.Boolean get_IsXsdType() { }
        private System.Boolean get_HasPublicConstructor() { }
        private System.Reflection.PropertyInfo GetIndexerProperty(System.Type collectionType) { }
        private System.InvalidOperationException CreateMissingAddMethodException(System.Type type, System.String inheritFrom, System.Type argumentType) { }
        private System.Type GetGenericListItemType(System.Type type) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000113
    public class TypeMember
    {
        // Fields
        private System.Type type;        // 0x10
        private System.String member;        // 0x18

        // Methods
        private System.Void .ctor(System.Type type, System.String member) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(System.Xml.Serialization.TypeMember tm1, System.Xml.Serialization.TypeMember tm2) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000114
    public class TypeTranslator
    {
        // Fields
        private static System.Collections.Hashtable nameCache;        // 0x0
        private static System.Collections.Hashtable primitiveTypes;        // 0x8
        private static System.Collections.Hashtable primitiveArrayTypes;        // 0x10
        private static System.Collections.Hashtable nullableTypes;        // 0x18

        // Methods
        private System.Void .cctor() { }
        private System.Xml.Serialization.TypeData GetTypeData(System.Type type) { }
        private System.Xml.Serialization.TypeData GetTypeData(System.Type runtimeType, System.String xmlDataType, System.Boolean underlyingEnumType) { }
        private System.Xml.Serialization.TypeData GetPrimitiveTypeData(System.String typeName) { }
        private System.Xml.Serialization.TypeData GetPrimitiveTypeData(System.String typeName, System.Boolean nullable) { }
        private System.Xml.Serialization.TypeData FindPrimitiveTypeData(System.String typeName) { }
        private System.String GetArrayName(System.String elemName) { }
        private System.Void ParseArrayType(System.String arrayType, System.String& type, System.String& ns, System.String& dimensions) { }

    }

    // TypeToken: 0x2000115
    public class XmlAnyAttributeAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000116
    public class XmlAnyElementAttribute : Attribute
    {
        // Fields
        private System.String elementName;        // 0x10
        private System.String ns;        // 0x18
        private System.Int32 order;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.String get_Name() { }
        private System.String get_Namespace() { }
        private System.Int32 get_Order() { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x2000117
    public class XmlAnyElementAttributes : CollectionBase
    {
        // Methods
        private System.Xml.Serialization.XmlAnyElementAttribute get_Item(System.Int32 index) { }
        private System.Int32 Add(System.Xml.Serialization.XmlAnyElementAttribute attribute) { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }
        private System.Int32 get_Order() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000118
    public class XmlArrayAttribute : Attribute
    {
        // Fields
        private System.String elementName;        // 0x10
        private System.Xml.Schema.XmlSchemaForm form;        // 0x18
        private System.Boolean isNullable;        // 0x1C
        private System.String ns;        // 0x20
        private System.Int32 order;        // 0x28

        // Methods
        private System.String get_ElementName() { }
        private System.Xml.Schema.XmlSchemaForm get_Form() { }
        private System.Boolean get_IsNullable() { }
        private System.String get_Namespace() { }
        private System.Int32 get_Order() { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x2000119
    public class XmlArrayItemAttribute : Attribute
    {
        // Fields
        private System.String dataType;        // 0x10
        private System.String elementName;        // 0x18
        private System.Xml.Schema.XmlSchemaForm form;        // 0x20
        private System.String ns;        // 0x28
        private System.Boolean isNullable;        // 0x30
        private System.Boolean isNullableSpecified;        // 0x31
        private System.Int32 nestingLevel;        // 0x34
        private System.Type type;        // 0x38

        // Methods
        private System.String get_DataType() { }
        private System.String get_ElementName() { }
        private System.Xml.Schema.XmlSchemaForm get_Form() { }
        private System.String get_Namespace() { }
        private System.Boolean get_IsNullable() { }
        private System.Boolean get_IsNullableSpecified() { }
        private System.Type get_Type() { }
        private System.Int32 get_NestingLevel() { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x200011A
    public class XmlArrayItemAttributes : CollectionBase
    {
        // Methods
        private System.Xml.Serialization.XmlArrayItemAttribute get_Item(System.Int32 index) { }
        private System.Int32 Add(System.Xml.Serialization.XmlArrayItemAttribute attribute) { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011B
    public class XmlAttributeAttribute : Attribute
    {
        // Fields
        private System.String attributeName;        // 0x10
        private System.String dataType;        // 0x18
        private System.Type type;        // 0x20
        private System.Xml.Schema.XmlSchemaForm form;        // 0x28
        private System.String ns;        // 0x30

        // Methods
        private System.Void .ctor(System.String attributeName) { }
        private System.String get_AttributeName() { }
        private System.String get_DataType() { }
        private System.Void set_DataType(System.String value) { }
        private System.Xml.Schema.XmlSchemaForm get_Form() { }
        private System.String get_Namespace() { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x200011C
    public class XmlAttributeOverrides
    {
        // Fields
        private System.Collections.Hashtable overrides;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Xml.Serialization.XmlAttributes get_Item(System.Type type) { }
        private System.Xml.Serialization.XmlAttributes get_Item(System.Type type, System.String member) { }
        private System.Xml.Serialization.TypeMember GetKey(System.Type type, System.String member) { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x200011D
    public class XmlAttributes
    {
        // Fields
        private System.Xml.Serialization.XmlAnyAttributeAttribute xmlAnyAttribute;        // 0x10
        private System.Xml.Serialization.XmlAnyElementAttributes xmlAnyElements;        // 0x18
        private System.Xml.Serialization.XmlArrayAttribute xmlArray;        // 0x20
        private System.Xml.Serialization.XmlArrayItemAttributes xmlArrayItems;        // 0x28
        private System.Xml.Serialization.XmlAttributeAttribute xmlAttribute;        // 0x30
        private System.Xml.Serialization.XmlChoiceIdentifierAttribute xmlChoiceIdentifier;        // 0x38
        private System.Object xmlDefaultValue;        // 0x40
        private System.Xml.Serialization.XmlElementAttributes xmlElements;        // 0x48
        private System.Xml.Serialization.XmlEnumAttribute xmlEnum;        // 0x50
        private System.Boolean xmlIgnore;        // 0x58
        private System.Boolean xmlns;        // 0x59
        private System.Xml.Serialization.XmlRootAttribute xmlRoot;        // 0x60
        private System.Xml.Serialization.XmlTextAttribute xmlText;        // 0x68
        private System.Xml.Serialization.XmlTypeAttribute xmlType;        // 0x70

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Reflection.ICustomAttributeProvider provider) { }
        private System.Xml.Serialization.XmlAnyAttributeAttribute get_XmlAnyAttribute() { }
        private System.Xml.Serialization.XmlAnyElementAttributes get_XmlAnyElements() { }
        private System.Xml.Serialization.XmlArrayAttribute get_XmlArray() { }
        private System.Xml.Serialization.XmlArrayItemAttributes get_XmlArrayItems() { }
        private System.Xml.Serialization.XmlAttributeAttribute get_XmlAttribute() { }
        private System.Xml.Serialization.XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }
        private System.Object get_XmlDefaultValue() { }
        private System.Xml.Serialization.XmlElementAttributes get_XmlElements() { }
        private System.Boolean get_XmlIgnore() { }
        private System.Boolean get_Xmlns() { }
        private System.Xml.Serialization.XmlRootAttribute get_XmlRoot() { }
        private System.Xml.Serialization.XmlTextAttribute get_XmlText() { }
        private System.Xml.Serialization.XmlTypeAttribute get_XmlType() { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }
        private System.Nullable<System.Int32> get_Order() { }
        private System.Int32 get_SortableOrder() { }

    }

    // TypeToken: 0x200011E
    public class XmlChoiceIdentifierAttribute : Attribute
    {
        // Fields
        private System.String memberName;        // 0x10

        // Methods
        private System.String get_MemberName() { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x200011F
    public class XmlCustomFormatter
    {
        // Fields
        private static System.String[] allTimeFormats;        // 0x0

        // Methods
        private System.String FromEnum(System.Int64 value, System.String[] values, System.Int64[] ids, System.String typeName) { }
        private System.String FromXmlName(System.String name) { }
        private System.String FromXmlNCName(System.String ncName) { }
        private System.String ToXmlString(System.Xml.Serialization.TypeData type, System.Object value) { }
        private System.Object FromXmlString(System.Xml.Serialization.TypeData type, System.String value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000120
    public class XmlElementAttribute : Attribute
    {
        // Fields
        private System.String dataType;        // 0x10
        private System.String elementName;        // 0x18
        private System.Xml.Schema.XmlSchemaForm form;        // 0x20
        private System.String ns;        // 0x28
        private System.Boolean isNullable;        // 0x30
        private System.Type type;        // 0x38
        private System.Int32 order;        // 0x40

        // Methods
        private System.Void .ctor(System.String elementName) { }
        private System.Void .ctor(System.String elementName, System.Type type) { }
        private System.String get_DataType() { }
        private System.String get_ElementName() { }
        private System.Xml.Schema.XmlSchemaForm get_Form() { }
        private System.String get_Namespace() { }
        private System.Boolean get_IsNullable() { }
        private System.Int32 get_Order() { }
        private System.Type get_Type() { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x2000121
    public class XmlElementAttributes : CollectionBase
    {
        // Methods
        private System.Xml.Serialization.XmlElementAttribute get_Item(System.Int32 index) { }
        private System.Int32 Add(System.Xml.Serialization.XmlElementAttribute attribute) { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }
        private System.Int32 get_Order() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000122
    public class XmlEnumAttribute : Attribute
    {
        // Fields
        private System.String name;        // 0x10

        // Methods
        private System.Void .ctor(System.String name) { }
        private System.String get_Name() { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x2000123
    public class XmlIgnoreAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000124
    public class XmlIncludeAttribute : Attribute
    {
        // Fields
        private System.Type type;        // 0x10

        // Methods
        private System.Type get_Type() { }

    }

    // TypeToken: 0x2000125
    public class XmlMapping
    {
        // Fields
        private System.Xml.Serialization.ObjectMap map;        // 0x10
        private System.Collections.ArrayList relatedMaps;        // 0x18
        private System.Xml.Serialization.SerializationFormat format;        // 0x20
        private System.Xml.Serialization.SerializationSource source;        // 0x28
        private System.String _elementName;        // 0x30
        private System.String _namespace;        // 0x38
        private System.String key;        // 0x40

        // Methods
        private System.Void .ctor(System.String elementName, System.String ns) { }
        private System.String get_ElementName() { }
        private System.String get_Namespace() { }
        private System.Void SetKey(System.String key) { }
        private System.Xml.Serialization.ObjectMap get_ObjectMap() { }
        private System.Void set_ObjectMap(System.Xml.Serialization.ObjectMap value) { }
        private System.Collections.ArrayList get_RelatedMaps() { }
        private System.Void set_RelatedMaps(System.Collections.ArrayList value) { }
        private System.Xml.Serialization.SerializationFormat get_Format() { }
        private System.Void set_Format(System.Xml.Serialization.SerializationFormat value) { }
        private System.Xml.Serialization.SerializationSource get_Source() { }

    }

    // TypeToken: 0x2000126
    public class ObjectMap
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000127
    public struct SerializationFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.Serialization.SerializationFormat Encoded;        // 0x0
        public static System.Xml.Serialization.SerializationFormat Literal;        // 0x0

    }

    // TypeToken: 0x2000128
    public class XmlMemberMapping
    {
    }

    // TypeToken: 0x2000129
    public class XmlMembersMapping : XmlMapping
    {
        // Fields
        private System.Boolean _hasWrapperElement;        // 0x48
        private System.Xml.Serialization.XmlMemberMapping[] _mapping;        // 0x50

        // Methods
        private System.Int32 get_Count() { }
        private System.Boolean get_HasWrapperElement() { }

    }

    // TypeToken: 0x200012A
    public class XmlNamespaceDeclarationsAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012B
    public class XmlReflectionImporter
    {
        // Fields
        private System.String initialDefaultNamespace;        // 0x10
        private System.Xml.Serialization.XmlAttributeOverrides attributeOverrides;        // 0x18
        private System.Collections.ArrayList includedTypes;        // 0x20
        private System.Xml.Serialization.ReflectionHelper helper;        // 0x28
        private System.Int32 arrayChoiceCount;        // 0x30
        private System.Collections.ArrayList relatedMaps;        // 0x38
        private System.Boolean allowPrivateTypes;        // 0x40
        private static readonly System.String errSimple;        // 0x0
        private static readonly System.String errSimple2;        // 0x8

        // Methods
        private System.Void .ctor(System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, System.String defaultNamespace) { }
        private System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type) { }
        private System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, System.String defaultNamespace) { }
        private System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace) { }
        private System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace) { }
        private System.Xml.Serialization.XmlTypeMapping CreateTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultXmlType, System.String defaultNamespace) { }
        private System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace, System.Boolean isBaseType) { }
        private System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace, System.Boolean isBaseType) { }
        private System.Void RegisterDerivedMap(System.Xml.Serialization.XmlTypeMapping map, System.Xml.Serialization.XmlTypeMapping derivedMap) { }
        private System.String GetTypeNamespace(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace) { }
        private System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace, System.Xml.Serialization.XmlAttributes atts, System.Int32 nestingLevel) { }
        private System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace, System.Xml.Serialization.XmlAttributes atts, System.Int32 nestingLevel) { }
        private System.Xml.Serialization.XmlTypeMapping ImportXmlNodeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace) { }
        private System.Xml.Serialization.XmlTypeMapping ImportPrimitiveMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace) { }
        private System.Xml.Serialization.XmlTypeMapping ImportEnumMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace) { }
        private System.Xml.Serialization.XmlTypeMapping ImportXmlSerializableMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace) { }
        private System.Void ImportIncludedTypes(System.Type type, System.String defaultNamespace) { }
        private System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(System.Type type) { }
        private System.Xml.Serialization.XmlTypeMapMember CreateMapMember(System.Type declaringType, System.Xml.Serialization.XmlReflectionMember rmember, System.String defaultNamespace) { }
        private System.Xml.Serialization.XmlTypeMapElementInfoList ImportElementInfo(System.Type cls, System.String defaultName, System.String defaultNamespace, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts) { }
        private System.Xml.Serialization.XmlTypeMapElementInfoList ImportAnyElementInfo(System.String defaultNamespace, System.Xml.Serialization.XmlReflectionMember rmember, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts) { }
        private System.Void ImportTextElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList list, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts, System.String defaultNamespace) { }
        private System.Boolean CanBeNull(System.Xml.Serialization.TypeData type) { }
        private System.Void IncludeType(System.Type type) { }
        private System.Object GetDefaultValue(System.Xml.Serialization.TypeData typeData, System.Object defaultValue) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200012D
    public class XmlReflectionMember
    {
        // Fields
        private System.Boolean isReturnValue;        // 0x10
        private System.String memberName;        // 0x18
        private System.Type memberType;        // 0x20
        private System.Xml.Serialization.XmlAttributes xmlAttributes;        // 0x28
        private System.Type declaringType;        // 0x30

        // Methods
        private System.Void .ctor(System.String name, System.Type type, System.Xml.Serialization.XmlAttributes attributes) { }
        private System.Boolean get_IsReturnValue() { }
        private System.String get_MemberName() { }
        private System.Type get_MemberType() { }
        private System.Xml.Serialization.XmlAttributes get_XmlAttributes() { }
        private System.Type get_DeclaringType() { }
        private System.Void set_DeclaringType(System.Type value) { }

    }

    // TypeToken: 0x200012E
    public class XmlRootAttribute : Attribute
    {
        // Fields
        private System.String dataType;        // 0x10
        private System.String elementName;        // 0x18
        private System.Boolean isNullable;        // 0x20
        private System.String ns;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String elementName) { }
        private System.String get_DataType() { }
        private System.Void set_DataType(System.String value) { }
        private System.String get_ElementName() { }
        private System.Void set_ElementName(System.String value) { }
        private System.Boolean get_IsNullable() { }
        private System.Void set_IsNullable(System.Boolean value) { }
        private System.String get_Namespace() { }
        private System.Void set_Namespace(System.String value) { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x200012F
    public class XmlSchemaProviderAttribute : Attribute
    {
        // Fields
        private System.String _methodName;        // 0x10
        private System.Boolean _isAny;        // 0x18

        // Methods
        private System.Void .ctor(System.String methodName) { }
        private System.String get_MethodName() { }
        private System.Boolean get_IsAny() { }
        private System.Void set_IsAny(System.Boolean value) { }

    }

    // TypeToken: 0x2000130
    public class XmlSerializationCollectionFixupCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object collection, System.Object collectionItems) { }

    }

    // TypeToken: 0x2000131
    public class XmlSerializationFixupCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object fixup) { }

    }

    // TypeToken: 0x2000132
    public class XmlSerializationGeneratedCode
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000133
    public class XmlSerializationReadCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Object Invoke() { }

    }

    // TypeToken: 0x2000134
    public class XmlSerializationReader : XmlSerializationGeneratedCode
    {
        // Fields
        private System.Xml.XmlDocument document;        // 0x10
        private System.Xml.XmlReader reader;        // 0x18
        private System.Collections.ArrayList fixups;        // 0x20
        private System.Collections.Hashtable collFixups;        // 0x28
        private System.Collections.ArrayList collItemFixups;        // 0x30
        private System.Collections.Hashtable typesCallbacks;        // 0x38
        private System.Collections.ArrayList noIDTargets;        // 0x40
        private System.Collections.Hashtable targets;        // 0x48
        private System.Collections.Hashtable delayedListFixups;        // 0x50
        private System.Xml.Serialization.XmlSerializer eventSource;        // 0x58
        private System.Int32 delayedFixupId;        // 0x60
        private System.Collections.Hashtable referencedObjects;        // 0x68
        private System.Int32 readCount;        // 0x70
        private System.Int32 whileIterationCount;        // 0x74
        private System.String w3SchemaNS;        // 0x78
        private System.String w3InstanceNS;        // 0x80
        private System.String w3InstanceNS2000;        // 0x88
        private System.String w3InstanceNS1999;        // 0x90
        private System.String soapNS;        // 0x98
        private System.String wsdlNS;        // 0xA0
        private System.String nullX;        // 0xA8
        private System.String nil;        // 0xB0
        private System.String typeX;        // 0xB8
        private System.String arrayType;        // 0xC0
        private System.Xml.XmlQualifiedName arrayQName;        // 0xC8

        // Methods
        private System.Void Initialize(System.Xml.XmlReader reader, System.Xml.Serialization.XmlSerializer eventSource) { }
        private System.Collections.ArrayList EnsureArrayList(System.Collections.ArrayList list) { }
        private System.Collections.Hashtable EnsureHashtable(System.Collections.Hashtable hash) { }
        private System.Void .ctor() { }
        private System.Xml.XmlDocument get_Document() { }
        private System.Xml.XmlReader get_Reader() { }
        private System.Void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionFixup fixup) { }
        private System.Void AddFixup(System.Xml.Serialization.XmlSerializationReader.Fixup fixup) { }
        private System.Void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionItemFixup fixup) { }
        private System.Void AddReadCallback(System.String name, System.String ns, System.Type type, System.Xml.Serialization.XmlSerializationReadCallback read) { }
        private System.Void AddTarget(System.String id, System.Object o) { }
        private System.String CurrentTag() { }
        private System.Exception CreateReadOnlyCollectionException(System.String name) { }
        private System.Exception CreateUnknownConstantException(System.String value, System.Type enumType) { }
        private System.Exception CreateUnknownNodeException() { }
        private System.Exception CreateUnknownTypeException(System.Xml.XmlQualifiedName type) { }
        private System.Array EnsureArrayIndex(System.Array a, System.Int32 index, System.Type elementType) { }
        private System.Boolean GetNullAttr() { }
        private System.Object GetTarget(System.String id) { }
        private System.Boolean TargetReady(System.String id) { }
        private System.Xml.XmlQualifiedName GetXsiType() { }
        private System.Void InitCallbacks() { }
        private System.Void InitIDs() { }
        private System.Boolean IsXmlnsAttribute(System.String name) { }
        private System.Void ParseWsdlArrayType(System.Xml.XmlAttribute attr) { }
        private System.Xml.XmlQualifiedName ReadElementQualifiedName() { }
        private System.Void ReadEndElement() { }
        private System.Boolean ReadNull() { }
        private System.Xml.XmlQualifiedName ReadNullableQualifiedName() { }
        private System.String ReadNullableString() { }
        private System.Object ReadReferencedElement() { }
        private System.Xml.Serialization.XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(System.Xml.XmlQualifiedName qname) { }
        private System.Object ReadReferencedElement(System.String name, System.String ns) { }
        private System.Boolean ReadList(System.Object& resultList) { }
        private System.Void ReadReferencedElements() { }
        private System.Object ReadReferencingElement(System.String& fixupReference) { }
        private System.Object ReadReferencingElement(System.String name, System.String ns, System.String& fixupReference) { }
        private System.Object ReadReferencingElement(System.String name, System.String ns, System.Boolean elementCanBeType, System.String& fixupReference) { }
        private System.Xml.Serialization.IXmlSerializable ReadSerializable(System.Xml.Serialization.IXmlSerializable serializable) { }
        private System.Object ReadTypedPrimitive(System.Xml.XmlQualifiedName type) { }
        private System.Object ReadTypedPrimitive(System.Xml.XmlQualifiedName qname, System.Boolean reportUnknown) { }
        private System.Xml.XmlNode ReadXmlNode(System.Boolean wrapped) { }
        private System.Xml.XmlDocument ReadXmlDocument(System.Boolean wrapped) { }
        private System.Array ShrinkArray(System.Array a, System.Int32 length, System.Type elementType, System.Boolean isNullable) { }
        private System.Xml.XmlQualifiedName ToXmlQualifiedName(System.String value) { }
        private System.Void UnknownAttribute(System.Object o, System.Xml.XmlAttribute attr, System.String qnames) { }
        private System.Void UnknownElement(System.Object o, System.Xml.XmlElement elem, System.String qnames) { }
        private System.Void UnknownNode(System.Object o) { }
        private System.Void UnknownNode(System.Object o, System.String qnames) { }
        private System.Void OnUnknownNode(System.Xml.XmlNode node, System.Object o, System.String qnames) { }
        private System.Void UnreferencedObject(System.String id, System.Object o) { }

    }

    // TypeToken: 0x2000139
    public class XmlSerializationReaderInterpreter : XmlSerializationReader
    {
        // Fields
        private System.Xml.Serialization.XmlMapping _typeMap;        // 0xD0
        private System.Xml.Serialization.SerializationFormat _format;        // 0xD8
        private static readonly System.Xml.XmlQualifiedName AnyType;        // 0x0
        private static readonly System.Object[] empty_array;        // 0x8

        // Methods
        private System.Void .ctor(System.Xml.Serialization.XmlMapping typeMap) { }
        private System.Void InitCallbacks() { }
        private System.Void InitIDs() { }
        private System.Object ReadRoot() { }
        private System.Object ReadEncodedObject(System.Xml.Serialization.XmlTypeMapping typeMap) { }
        private System.Object ReadMessage(System.Xml.Serialization.XmlMembersMapping typeMap) { }
        private System.Object ReadRoot(System.Xml.Serialization.XmlTypeMapping rootMap) { }
        private System.Object ReadObject(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable, System.Boolean checkType) { }
        private System.Object ReadClassInstance(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable, System.Boolean checkType) { }
        private System.Void ReadClassInstanceMembers(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob) { }
        private System.Void ReadAttributeMembers(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList) { }
        private System.Void ReadMembers(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList, System.Boolean readBySoapOrder) { }
        private System.Void SetListMembersDefaults(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList) { }
        private System.Void FixupMembers(System.Xml.Serialization.ClassMap map, System.Object obfixup, System.Boolean isValueList) { }
        private System.Void ProcessUnknownAttribute(System.Object target) { }
        private System.Void ProcessUnknownElement(System.Object target) { }
        private System.Boolean IsReadOnly(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData memType, System.Object ob, System.Boolean isValueList) { }
        private System.Void SetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, System.Object ob, System.Object value, System.Boolean isValueList) { }
        private System.Void SetMemberValueFromAttr(System.Xml.Serialization.XmlTypeMapMember member, System.Object ob, System.Object value, System.Boolean isValueList) { }
        private System.Object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, System.Object ob, System.Boolean isValueList) { }
        private System.Object ReadObjectElement(System.Xml.Serialization.XmlTypeMapElementInfo elem) { }
        private System.Object ReadPrimitiveValue(System.Xml.Serialization.XmlTypeMapElementInfo elem) { }
        private System.Object GetValueFromXmlString(System.String value, System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlTypeMapping typeMap) { }
        private System.Object ReadListElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable, System.Object list, System.Boolean canCreateInstance) { }
        private System.Object ReadListString(System.Xml.Serialization.XmlTypeMapping typeMap, System.String values) { }
        private System.Void AddListValue(System.Xml.Serialization.TypeData listType, System.Object& list, System.Int32 index, System.Object value, System.Boolean canCreateInstance) { }
        private System.Object CreateInstance(System.Type type, System.Boolean nonPublic) { }
        private System.Object CreateInstance(System.Type type) { }
        private System.Object CreateList(System.Type listType) { }
        private System.Object InitializeList(System.Xml.Serialization.TypeData listType) { }
        private System.Void FillList(System.Object list, System.Object items) { }
        private System.Void CopyEnumerableList(System.Object source, System.Object dest) { }
        private System.Object ReadXmlNodeElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable) { }
        private System.Object ReadXmlNode(System.Xml.Serialization.TypeData type, System.Boolean wrapped) { }
        private System.Object ReadPrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable) { }
        private System.Object ReadEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable) { }
        private System.Object GetEnumValue(System.Xml.Serialization.XmlTypeMapping typeMap, System.String val) { }
        private System.Object ReadXmlSerializableElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200013C
    public class XmlSerializationWriteCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object o) { }

    }

    // TypeToken: 0x200013D
    public class XmlSerializationWriter : XmlSerializationGeneratedCode
    {
        // Fields
        private System.Runtime.Serialization.ObjectIDGenerator idGenerator;        // 0x10
        private System.Int32 qnameCount;        // 0x18
        private System.Boolean topLevelElement;        // 0x1C
        private System.Collections.ArrayList namespaces;        // 0x20
        private System.Xml.XmlWriter writer;        // 0x28
        private System.Collections.Queue referencedElements;        // 0x30
        private System.Collections.Hashtable callbacks;        // 0x38
        private System.Collections.Hashtable serializedObjects;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private System.Void Initialize(System.Xml.XmlWriter writer, System.Xml.Serialization.XmlSerializerNamespaces nss) { }
        private System.Xml.XmlWriter get_Writer() { }
        private System.Void AddWriteCallback(System.Type type, System.String typeName, System.String typeNs, System.Xml.Serialization.XmlSerializationWriteCallback callback) { }
        private System.Exception CreateUnknownAnyElementException(System.String name, System.String ns) { }
        private System.Exception CreateUnknownTypeException(System.Object o) { }
        private System.Exception CreateUnknownTypeException(System.Type type) { }
        private System.String FromXmlQualifiedName(System.Xml.XmlQualifiedName xmlQualifiedName) { }
        private System.String GetId(System.Object o, System.Boolean addToReferencesList) { }
        private System.Boolean AlreadyQueued(System.Object ob) { }
        private System.String GetNamespacePrefix(System.String ns) { }
        private System.String GetQualifiedName(System.String name, System.String ns) { }
        private System.Void InitCallbacks() { }
        private System.Void TopLevelElement() { }
        private System.Void WriteAttribute(System.String localName, System.String ns, System.String value) { }
        private System.Void WriteAttribute(System.String prefix, System.String localName, System.String ns, System.String value) { }
        private System.Void WriteXmlNode(System.Xml.XmlNode node) { }
        private System.Void WriteElementEncoded(System.Xml.XmlNode node, System.String name, System.String ns, System.Boolean isNullable, System.Boolean any) { }
        private System.Void WriteElementLiteral(System.Xml.XmlNode node, System.String name, System.String ns, System.Boolean isNullable, System.Boolean any) { }
        private System.Void WriteElementQualifiedName(System.String localName, System.String ns, System.Xml.XmlQualifiedName value) { }
        private System.Void WriteElementQualifiedName(System.String localName, System.String ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType) { }
        private System.Void WriteElementString(System.String localName, System.String ns, System.String value) { }
        private System.Void WriteElementString(System.String localName, System.String ns, System.String value, System.Xml.XmlQualifiedName xsiType) { }
        private System.Void WriteEndElement() { }
        private System.Void WriteEndElement(System.Object o) { }
        private System.Void WriteNamespaceDeclarations(System.Xml.Serialization.XmlSerializerNamespaces xmlns) { }
        private System.Void WriteNullableQualifiedNameEncoded(System.String name, System.String ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType) { }
        private System.Void WriteNullableQualifiedNameLiteral(System.String name, System.String ns, System.Xml.XmlQualifiedName value) { }
        private System.Void WriteNullableStringEncoded(System.String name, System.String ns, System.String value, System.Xml.XmlQualifiedName xsiType) { }
        private System.Void WriteNullableStringLiteral(System.String name, System.String ns, System.String value) { }
        private System.Void WriteNullTagEncoded(System.String name, System.String ns) { }
        private System.Void WriteNullTagLiteral(System.String name, System.String ns) { }
        private System.Void WritePotentiallyReferencingElement(System.String n, System.String ns, System.Object o, System.Type ambientType, System.Boolean suppressReference, System.Boolean isNullable) { }
        private System.Void WriteReferencedElements() { }
        private System.Boolean IsPrimitiveArray(System.Xml.Serialization.TypeData td) { }
        private System.Void WriteArray(System.Object o, System.Xml.Serialization.TypeData td) { }
        private System.Void WriteReferencingElement(System.String n, System.String ns, System.Object o, System.Boolean isNullable) { }
        private System.Void CheckReferenceQueue() { }
        private System.Void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, System.String name, System.String ns, System.Boolean isNullable) { }
        private System.Void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, System.String name, System.String ns, System.Boolean isNullable, System.Boolean wrapped) { }
        private System.Void WriteStartDocument() { }
        private System.Void WriteStartElement(System.String name, System.String ns) { }
        private System.Void WriteStartElement(System.String name, System.String ns, System.Boolean writePrefixed) { }
        private System.Void WriteStartElement(System.String name, System.String ns, System.Object o) { }
        private System.Void WriteStartElement(System.String name, System.String ns, System.Object o, System.Boolean writePrefixed) { }
        private System.Void WriteStartElement(System.String name, System.String ns, System.Object o, System.Boolean writePrefixed, System.Collections.ICollection namespaces) { }
        private System.Void WriteTypedPrimitive(System.String name, System.String ns, System.Object o, System.Boolean xsiType) { }
        private System.Void WriteValue(System.String value) { }
        private System.Void WriteXmlAttribute(System.Xml.XmlNode node, System.Object container) { }
        private System.Void WriteXsiType(System.String name, System.String ns) { }

    }

    // TypeToken: 0x200013F
    public class XmlSerializationWriterInterpreter : XmlSerializationWriter
    {
        // Fields
        private System.Xml.Serialization.XmlMapping _typeMap;        // 0x48
        private System.Xml.Serialization.SerializationFormat _format;        // 0x50

        // Methods
        private System.Void .ctor(System.Xml.Serialization.XmlMapping typeMap) { }
        private System.Void InitCallbacks() { }
        private System.Void WriteRoot(System.Object ob) { }
        private System.Void WriteObject(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob, System.String element, System.String namesp, System.Boolean isNullable, System.Boolean needType, System.Boolean writeWrappingElem) { }
        private System.Void WriteMessage(System.Xml.Serialization.XmlMembersMapping membersMap, System.Object[] parameters) { }
        private System.Void WriteObjectElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob, System.String element, System.String namesp) { }
        private System.Void WriteObjectElementAttributes(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob) { }
        private System.Void WriteObjectElementElements(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob) { }
        private System.Void WriteMembers(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList) { }
        private System.Void WriteAttributeMembers(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList) { }
        private System.Void WriteElementMembers(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList) { }
        private System.Object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, System.Object ob, System.Boolean isValueList) { }
        private System.Boolean MemberHasValue(System.Xml.Serialization.XmlTypeMapMember member, System.Object ob, System.Boolean isValueList) { }
        private System.Void WriteMemberElement(System.Xml.Serialization.XmlTypeMapElementInfo elem, System.Object memberValue) { }
        private System.Object ImplicitConvert(System.Object obj, System.Type type) { }
        private System.Void WritePrimitiveValueLiteral(System.Object memberValue, System.String name, System.String ns, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, System.Boolean wrapped, System.Boolean isNullable) { }
        private System.Void WritePrimitiveValueEncoded(System.Object memberValue, System.String name, System.String ns, System.Xml.XmlQualifiedName xsiType, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, System.Boolean wrapped, System.Boolean isNullable) { }
        private System.Void WriteListElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob, System.String element, System.String namesp) { }
        private System.Void WriteListContent(System.Object container, System.Xml.Serialization.TypeData listType, System.Xml.Serialization.ListMap map, System.Object ob, System.Text.StringBuilder targetString) { }
        private System.Int32 GetListCount(System.Xml.Serialization.TypeData listType, System.Object ob) { }
        private System.Void WriteAnyElementContent(System.Xml.Serialization.XmlTypeMapMemberAnyElement member, System.Object memberValue) { }
        private System.Void WritePrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob, System.String element, System.String namesp) { }
        private System.Void WriteEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob, System.String element, System.String namesp) { }
        private System.String GetStringValue(System.Xml.Serialization.XmlTypeMapping typeMap, System.Xml.Serialization.TypeData type, System.Object value) { }
        private System.String GetEnumXmlValue(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob) { }

    }

    // TypeToken: 0x2000141
    public class XmlSerializer
    {
        // Fields
        private static System.Int32 generationThreshold;        // 0x0
        private static System.Boolean backgroundGeneration;        // 0x4
        private static System.Boolean deleteTempFiles;        // 0x5
        private static System.Boolean generatorFallback;        // 0x6
        private System.Boolean customSerializer;        // 0x10
        private System.Xml.Serialization.XmlMapping typeMapping;        // 0x18
        private System.Xml.Serialization.XmlSerializer.SerializerData serializerData;        // 0x20
        private static System.Collections.Hashtable serializerTypes;        // 0x8
        private System.Xml.Serialization.UnreferencedObjectEventHandler onUnreferencedObject;        // 0x28
        private System.Xml.Serialization.XmlAttributeEventHandler onUnknownAttribute;        // 0x30
        private System.Xml.Serialization.XmlElementEventHandler onUnknownElement;        // 0x38
        private System.Xml.Serialization.XmlNodeEventHandler onUnknownNode;        // 0x40

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor(System.Type type) { }
        private System.Void .ctor(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace) { }
        private System.Xml.Serialization.XmlMapping get_Mapping() { }
        private System.Void OnUnknownAttribute(System.Xml.Serialization.XmlAttributeEventArgs e) { }
        private System.Void OnUnknownElement(System.Xml.Serialization.XmlElementEventArgs e) { }
        private System.Void OnUnknownNode(System.Xml.Serialization.XmlNodeEventArgs e) { }
        private System.Void OnUnreferencedObject(System.Xml.Serialization.UnreferencedObjectEventArgs e) { }
        private System.Xml.Serialization.XmlSerializationReader CreateReader() { }
        private System.Xml.Serialization.XmlSerializationWriter CreateWriter() { }
        private System.Object Deserialize(System.IO.TextReader textReader) { }
        private System.Object Deserialize(System.Xml.XmlReader xmlReader) { }
        private System.Object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) { }
        private System.Void Serialize(System.Object o, System.Xml.Serialization.XmlSerializationWriter writer) { }
        private System.Void Serialize(System.IO.TextWriter textWriter, System.Object o) { }
        private System.Void Serialize(System.Xml.XmlWriter xmlWriter, System.Object o) { }
        private System.Void Serialize(System.Xml.XmlWriter xmlWriter, System.Object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces) { }
        private System.Xml.Serialization.XmlSerializationWriter CreateWriter(System.Xml.Serialization.XmlMapping typeMapping) { }
        private System.Xml.Serialization.XmlSerializationReader CreateReader(System.Xml.Serialization.XmlMapping typeMapping) { }

    }

    // TypeToken: 0x2000143
    public class XmlSerializerFactory
    {
        // Fields
        private static System.Collections.Hashtable serializersBySource;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type) { }
        private System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute root) { }
        private System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000144
    public class XmlSerializerImplementation
    {
        // Methods
        private System.Xml.Serialization.XmlSerializationWriter get_Writer() { }

    }

    // TypeToken: 0x2000145
    public class XmlTextAttribute : Attribute
    {
        // Fields
        private System.String dataType;        // 0x10
        private System.Type type;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.String get_DataType() { }
        private System.Type get_Type() { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x2000146
    public class XmlTypeAttribute : Attribute
    {
        // Fields
        private System.Boolean includeInSchema;        // 0x10
        private System.String ns;        // 0x18
        private System.String typeName;        // 0x20

        // Methods
        private System.Boolean get_IncludeInSchema() { }
        private System.String get_Namespace() { }
        private System.String get_TypeName() { }
        private System.Void AddKeyHash(System.Text.StringBuilder sb) { }

    }

    // TypeToken: 0x2000147
    public class XmlTypeMapElementInfo
    {
        // Fields
        private System.String _elementName;        // 0x10
        private System.String _namespace;        // 0x18
        private System.Xml.Schema.XmlSchemaForm _form;        // 0x20
        private System.Xml.Serialization.XmlTypeMapMember _member;        // 0x28
        private System.Object _choiceValue;        // 0x30
        private System.Boolean _isNullable;        // 0x38
        private System.Int32 _nestingLevel;        // 0x3C
        private System.Xml.Serialization.XmlTypeMapping _mappedType;        // 0x40
        private System.Xml.Serialization.TypeData _type;        // 0x48
        private System.Boolean _wrappedElement;        // 0x50
        private System.Int32 _explicitOrder;        // 0x54

        // Methods
        private System.Void .ctor(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData type) { }
        private System.Xml.Serialization.TypeData get_TypeData() { }
        private System.Object get_ChoiceValue() { }
        private System.Void set_ChoiceValue(System.Object value) { }
        private System.String get_ElementName() { }
        private System.Void set_ElementName(System.String value) { }
        private System.String get_Namespace() { }
        private System.Void set_Namespace(System.String value) { }
        private System.String get_DataTypeNamespace() { }
        private System.String get_DataTypeName() { }
        private System.Xml.Schema.XmlSchemaForm get_Form() { }
        private System.Void set_Form(System.Xml.Schema.XmlSchemaForm value) { }
        private System.Xml.Serialization.XmlTypeMapping get_MappedType() { }
        private System.Void set_MappedType(System.Xml.Serialization.XmlTypeMapping value) { }
        private System.Boolean get_IsNullable() { }
        private System.Void set_IsNullable(System.Boolean value) { }
        private System.Xml.Serialization.XmlTypeMapMember get_Member() { }
        private System.Void set_NestingLevel(System.Int32 value) { }
        private System.Boolean get_MultiReferenceType() { }
        private System.Boolean get_WrappedElement() { }
        private System.Void set_WrappedElement(System.Boolean value) { }
        private System.Boolean get_IsTextElement() { }
        private System.Void set_IsTextElement(System.Boolean value) { }
        private System.Boolean get_IsUnnamedAnyElement() { }
        private System.Void set_IsUnnamedAnyElement(System.Boolean value) { }
        private System.Int32 get_ExplicitOrder() { }
        private System.Void set_ExplicitOrder(System.Int32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000148
    public class XmlTypeMapElementInfoList : ArrayList
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000149
    public class XmlTypeMapMember
    {
        // Fields
        private System.String _name;        // 0x10
        private System.Int32 _index;        // 0x18
        private System.Int32 _globalIndex;        // 0x1C
        private System.Int32 _specifiedGlobalIndex;        // 0x20
        private System.Xml.Serialization.TypeData _typeData;        // 0x28
        private System.Reflection.MemberInfo _member;        // 0x30
        private System.Reflection.MemberInfo _specifiedMember;        // 0x38
        private System.Reflection.MethodInfo _shouldSerialize;        // 0x40
        private System.Object _defaultValue;        // 0x48
        private System.Int32 _flags;        // 0x50

        // Methods
        private System.Void .ctor() { }
        private System.String get_Name() { }
        private System.Void set_Name(System.String value) { }
        private System.Object get_DefaultValue() { }
        private System.Void set_DefaultValue(System.Object value) { }
        private System.Boolean IsReadOnly(System.Type type) { }
        private System.Object GetValue(System.Object ob, System.String name) { }
        private System.Object GetValue(System.Object ob) { }
        private System.Void SetValue(System.Object ob, System.Object value) { }
        private System.Void SetValue(System.Object ob, System.String name, System.Object value) { }
        private System.Void InitMember(System.Type type) { }
        private System.Xml.Serialization.TypeData get_TypeData() { }
        private System.Void set_TypeData(System.Xml.Serialization.TypeData value) { }
        private System.Int32 get_Index() { }
        private System.Void set_Index(System.Int32 value) { }
        private System.Int32 get_GlobalIndex() { }
        private System.Void set_GlobalIndex(System.Int32 value) { }
        private System.Boolean get_IsOptionalValueType() { }
        private System.Void set_IsOptionalValueType(System.Boolean value) { }
        private System.Boolean get_IsReturnValue() { }
        private System.Void set_IsReturnValue(System.Boolean value) { }
        private System.Void CheckOptionalValueType(System.Type type) { }
        private System.Boolean GetValueSpecified(System.Object ob) { }
        private System.Void SetValueSpecified(System.Object ob, System.Boolean value) { }

    }

    // TypeToken: 0x200014A
    public class XmlTypeMapMemberAttribute : XmlTypeMapMember
    {
        // Fields
        private System.String _attributeName;        // 0x58
        private System.String _namespace;        // 0x60
        private System.Xml.Schema.XmlSchemaForm _form;        // 0x68
        private System.Xml.Serialization.XmlTypeMapping _mappedType;        // 0x70

        // Methods
        private System.Void .ctor() { }
        private System.String get_AttributeName() { }
        private System.Void set_AttributeName(System.String value) { }
        private System.String get_Namespace() { }
        private System.Void set_Namespace(System.String value) { }
        private System.Void set_Form(System.Xml.Schema.XmlSchemaForm value) { }
        private System.Xml.Serialization.XmlTypeMapping get_MappedType() { }
        private System.Void set_MappedType(System.Xml.Serialization.XmlTypeMapping value) { }

    }

    // TypeToken: 0x200014B
    public class XmlTypeMapMemberElement : XmlTypeMapMember
    {
        // Fields
        private System.Xml.Serialization.XmlTypeMapElementInfoList _elementInfo;        // 0x58
        private System.String _choiceMember;        // 0x60
        private System.Boolean _isTextCollector;        // 0x68
        private System.Xml.Serialization.TypeData _choiceTypeData;        // 0x70

        // Methods
        private System.Void .ctor() { }
        private System.Xml.Serialization.XmlTypeMapElementInfoList get_ElementInfo() { }
        private System.Void set_ElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value) { }
        private System.String get_ChoiceMember() { }
        private System.Void set_ChoiceMember(System.String value) { }
        private System.Xml.Serialization.TypeData get_ChoiceTypeData() { }
        private System.Void set_ChoiceTypeData(System.Xml.Serialization.TypeData value) { }
        private System.Xml.Serialization.XmlTypeMapElementInfo FindElement(System.Object ob, System.Object memberValue) { }
        private System.Void SetChoice(System.Object ob, System.Object choice) { }
        private System.Boolean get_IsXmlTextCollector() { }
        private System.Void set_IsXmlTextCollector(System.Boolean value) { }

    }

    // TypeToken: 0x200014C
    public class XmlTypeMapMemberList : XmlTypeMapMemberElement
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014D
    public class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement
    {
        // Fields
        private System.Int32 _flatArrayIndex;        // 0x78

        // Methods
        private System.Int32 get_FlatArrayIndex() { }
        private System.Void set_FlatArrayIndex(System.Int32 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014E
    public class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable
    {
        // Fields
        private System.Xml.Serialization.ListMap _listMap;        // 0x80

        // Methods
        private System.Xml.Serialization.ListMap get_ListMap() { }
        private System.Void set_ListMap(System.Xml.Serialization.ListMap value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014F
    public class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable
    {
        // Methods
        private System.Boolean IsElementDefined(System.String name, System.String ns) { }
        private System.Boolean get_IsDefaultAny() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000150
    public class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000151
    public class XmlTypeMapMemberNamespaces : XmlTypeMapMember
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000152
    public class XmlTypeMapping : XmlMapping
    {
        // Fields
        private System.String xmlType;        // 0x48
        private System.String xmlTypeNamespace;        // 0x50
        private System.Xml.Serialization.TypeData type;        // 0x58
        private System.Xml.Serialization.XmlTypeMapping baseMap;        // 0x60
        private System.Boolean multiReferenceType;        // 0x68
        private System.Boolean includeInSchema;        // 0x69
        private System.Boolean isNullable;        // 0x6A
        private System.Boolean isAny;        // 0x6B
        private System.Collections.ArrayList _derivedTypes;        // 0x70

        // Methods
        private System.Void .ctor(System.String elementName, System.String ns, System.Xml.Serialization.TypeData typeData, System.String xmlType, System.String xmlTypeNamespace) { }
        private System.String get_TypeFullName() { }
        private System.Xml.Serialization.TypeData get_TypeData() { }
        private System.String get_XmlType() { }
        private System.Void set_XmlType(System.String value) { }
        private System.String get_XmlTypeNamespace() { }
        private System.Void set_XmlTypeNamespace(System.String value) { }
        private System.Boolean get_HasXmlTypeNamespace() { }
        private System.Collections.ArrayList get_DerivedTypes() { }
        private System.Boolean get_MultiReferenceType() { }
        private System.Xml.Serialization.XmlTypeMapping get_BaseMap() { }
        private System.Void set_BaseMap(System.Xml.Serialization.XmlTypeMapping value) { }
        private System.Void set_IncludeInSchema(System.Boolean value) { }
        private System.Boolean get_IsNullable() { }
        private System.Void set_IsNullable(System.Boolean value) { }
        private System.Boolean get_IsAny() { }
        private System.Void set_IsAny(System.Boolean value) { }
        private System.Xml.Serialization.XmlTypeMapping GetRealTypeMap(System.Type objectType) { }
        private System.Xml.Serialization.XmlTypeMapping GetRealElementMap(System.String name, System.String ens) { }
        private System.Void UpdateRoot(System.Xml.XmlQualifiedName qname) { }

    }

    // TypeToken: 0x2000153
    public class XmlSerializableMapping : XmlTypeMapping
    {
        // Fields
        private System.Xml.Schema.XmlSchema _schema;        // 0x78
        private System.Xml.Schema.XmlSchemaComplexType _schemaType;        // 0x80
        private System.Xml.XmlQualifiedName _schemaTypeName;        // 0x88

        // Methods
        private System.Void .ctor(System.Xml.Serialization.XmlRootAttribute root, System.String elementName, System.String ns, System.Xml.Serialization.TypeData typeData, System.String xmlType, System.String xmlTypeNamespace) { }

    }

    // TypeToken: 0x2000154
    public class ClassMap : ObjectMap
    {
        // Fields
        private System.Collections.Hashtable _elements;        // 0x10
        private System.Collections.ArrayList _elementMembers;        // 0x18
        private System.Collections.Hashtable _attributeMembers;        // 0x20
        private System.Xml.Serialization.XmlTypeMapMemberAttribute[] _attributeMembersArray;        // 0x28
        private System.Collections.ArrayList _flatLists;        // 0x30
        private System.Collections.ArrayList _allMembers;        // 0x38
        private System.Collections.ArrayList _membersWithDefault;        // 0x40
        private System.Collections.ArrayList _listMembers;        // 0x48
        private System.Xml.Serialization.XmlTypeMapMemberAnyElement _defaultAnyElement;        // 0x50
        private System.Xml.Serialization.XmlTypeMapMemberAnyAttribute _defaultAnyAttribute;        // 0x58
        private System.Xml.Serialization.XmlTypeMapMemberNamespaces _namespaceDeclarations;        // 0x60
        private System.Xml.Serialization.XmlTypeMapMember _xmlTextCollector;        // 0x68
        private System.Xml.Serialization.XmlTypeMapMember _returnMember;        // 0x70
        private System.Boolean _ignoreMemberNamespace;        // 0x78
        private System.Boolean _canBeSimpleType;        // 0x79
        private System.Nullable<System.Boolean> _isOrderDependentMap;        // 0x7A

        // Methods
        private System.Void AddMember(System.Xml.Serialization.XmlTypeMapMember member) { }
        private System.Void RegisterFlatList(System.Xml.Serialization.XmlTypeMapMemberExpandable member) { }
        private System.Xml.Serialization.XmlTypeMapMemberAttribute GetAttribute(System.String name, System.String ns) { }
        private System.Xml.Serialization.XmlTypeMapElementInfo GetElement(System.String name, System.String ns, System.Int32 minimalOrder) { }
        private System.Xml.Serialization.XmlTypeMapElementInfo GetElement(System.String name, System.String ns) { }
        private System.String BuildKey(System.String name, System.String ns, System.Int32 explicitOrder) { }
        private System.Boolean get_IsOrderDependentMap() { }
        private System.Xml.Serialization.XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }
        private System.Xml.Serialization.XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }
        private System.Xml.Serialization.XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }
        private System.Collections.ICollection get_AttributeMembers() { }
        private System.Collections.ICollection get_ElementMembers() { }
        private System.Collections.ArrayList get_AllMembers() { }
        private System.Collections.ArrayList get_FlatLists() { }
        private System.Collections.ArrayList get_ListMembers() { }
        private System.Xml.Serialization.XmlTypeMapMember get_XmlTextCollector() { }
        private System.Xml.Serialization.XmlTypeMapMember get_ReturnMember() { }
        private System.Xml.XmlQualifiedName get_SimpleContentBaseType() { }
        private System.Void SetCanBeSimpleType(System.Boolean can) { }
        private System.Boolean get_HasSimpleContent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000155
    public class ListMap : ObjectMap
    {
        // Fields
        private System.Xml.Serialization.XmlTypeMapElementInfoList _itemInfo;        // 0x10
        private System.String _choiceMember;        // 0x18

        // Methods
        private System.Void set_ChoiceMember(System.String value) { }
        private System.Xml.Serialization.XmlTypeMapElementInfoList get_ItemInfo() { }
        private System.Void set_ItemInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value) { }
        private System.Xml.Serialization.XmlTypeMapElementInfo FindElement(System.Object ob, System.Int32 index, System.Object memberValue) { }
        private System.Xml.Serialization.XmlTypeMapElementInfo FindElement(System.String elementName, System.String ns) { }
        private System.Xml.Serialization.XmlTypeMapElementInfo FindTextElement() { }
        private System.Void GetArrayType(System.Int32 itemCount, System.String& localName, System.String& ns) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Int32 GetHashCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000156
    public class EnumMap : ObjectMap
    {
        // Fields
        private readonly System.Xml.Serialization.EnumMap.EnumMapMember[] _members;        // 0x10
        private readonly System.Boolean _isFlags;        // 0x18
        private readonly System.String[] _enumNames;        // 0x20
        private readonly System.String[] _xmlNames;        // 0x28
        private readonly System.Int64[] _values;        // 0x30

        // Methods
        private System.Void .ctor(System.Xml.Serialization.EnumMap.EnumMapMember[] members, System.Boolean isFlags) { }
        private System.Boolean get_IsFlags() { }
        private System.String[] get_EnumNames() { }
        private System.String[] get_XmlNames() { }
        private System.Int64[] get_Values() { }
        private System.String GetXmlName(System.String typeName, System.Object enumValue) { }
        private System.String GetEnumName(System.String typeName, System.String xmlName) { }

    }

}

namespace System.Xml.XPath
{

    // TypeToken: 0x20000F4
    public interface IXPathNavigable
    {
        // Methods
        private System.Xml.XPath.XPathNavigator CreateNavigator() { }

    }

    // TypeToken: 0x20000F5
    public class XPathDocument
    {
        // Fields
        private MS.Internal.Xml.Cache.XPathNode[] pageText;        // 0x10
        private MS.Internal.Xml.Cache.XPathNode[] pageRoot;        // 0x18
        private MS.Internal.Xml.Cache.XPathNode[] pageXmlNmsp;        // 0x20
        private System.Int32 idxText;        // 0x28
        private System.Int32 idxRoot;        // 0x2C
        private System.Int32 idxXmlNmsp;        // 0x30
        private System.Xml.XmlNameTable nameTable;        // 0x38
        private System.Boolean hasLineInfo;        // 0x40
        private System.Collections.Generic.Dictionary<MS.Internal.Xml.Cache.XPathNodeRef,MS.Internal.Xml.Cache.XPathNodeRef> mapNmsp;        // 0x48
        private System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.Cache.XPathNodeRef> idValueMap;        // 0x50

        // Methods
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.Boolean get_HasLineInfo() { }
        private System.Int32 GetCollapsedTextNode(MS.Internal.Xml.Cache.XPathNode[]& pageText) { }
        private System.Int32 GetRootNode(MS.Internal.Xml.Cache.XPathNode[]& pageRoot) { }
        private System.Int32 GetXmlNamespaceNode(MS.Internal.Xml.Cache.XPathNode[]& pageXmlNmsp) { }
        private System.Int32 LookupNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, System.Int32 idxElem, MS.Internal.Xml.Cache.XPathNode[]& pageNmsp) { }
        private System.Int32 LookupIdElement(System.String id, MS.Internal.Xml.Cache.XPathNode[]& pageElem) { }

    }

    // TypeToken: 0x20000F6
    public class XPathException : SystemException
    {
        // Fields
        private System.String res;        // 0x90
        private System.String[] args;        // 0x98
        private System.String message;        // 0xA0

        // Methods
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private System.Xml.XPath.XPathException Create(System.String res) { }
        private System.Xml.XPath.XPathException Create(System.String res, System.String arg) { }
        private System.Xml.XPath.XPathException Create(System.String res, System.String arg, System.String arg2) { }
        private System.Xml.XPath.XPathException Create(System.String res, System.String arg, System.Exception innerException) { }
        private System.Void .ctor(System.String res, System.String[] args) { }
        private System.Void .ctor(System.String res, System.String[] args, System.Exception inner) { }
        private System.String CreateMessage(System.String res, System.String[] args) { }
        private System.String get_Message() { }

    }

    // TypeToken: 0x20000F7
    public struct XPathResultType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XPath.XPathResultType Number;        // 0x0
        public static System.Xml.XPath.XPathResultType String;        // 0x0
        public static System.Xml.XPath.XPathResultType Boolean;        // 0x0
        public static System.Xml.XPath.XPathResultType NodeSet;        // 0x0
        public static System.Xml.XPath.XPathResultType Navigator;        // 0x0
        public static System.Xml.XPath.XPathResultType Any;        // 0x0
        public static System.Xml.XPath.XPathResultType Error;        // 0x0

    }

    // TypeToken: 0x20000F8
    public class XPathExpression
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void SetContext(System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Xml.XPath.XPathExpression Compile(System.String xpath) { }
        private System.Xml.XPath.XPathExpression Compile(System.String xpath, System.Xml.IXmlNamespaceResolver nsResolver) { }

    }

    // TypeToken: 0x20000F9
    public class XPathItem
    {
        // Methods
        private System.Xml.Schema.XmlSchemaType get_XmlType() { }
        private System.String get_Value() { }
        private System.Object get_TypedValue() { }
        private System.Type get_ValueType() { }
        private System.Boolean get_ValueAsBoolean() { }
        private System.DateTime get_ValueAsDateTime() { }
        private System.Double get_ValueAsDouble() { }
        private System.Int32 get_ValueAsInt() { }
        private System.Int64 get_ValueAsLong() { }
        private System.Object ValueAs(System.Type returnType) { }
        private System.Object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FA
    public struct XPathNamespaceScope
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XPath.XPathNamespaceScope All;        // 0x0
        public static System.Xml.XPath.XPathNamespaceScope ExcludeXml;        // 0x0
        public static System.Xml.XPath.XPathNamespaceScope Local;        // 0x0

    }

    // TypeToken: 0x20000FB
    public class XPathNavigator : XPathItem, ICloneable, IXPathNavigable, IXmlNamespaceResolver
    {
        // Fields
        private static readonly System.Xml.XPath.XPathNavigatorKeyComparer comparer;        // 0x0
        private static readonly System.Char[] NodeTypeLetter;        // 0x8
        private static readonly System.Char[] UniqueIdTbl;        // 0x10
        private static readonly System.Int32[] ContentKindMasks;        // 0x18

        // Methods
        private System.String ToString() { }
        private System.Xml.Schema.XmlSchemaType get_XmlType() { }
        private System.Object get_TypedValue() { }
        private System.Type get_ValueType() { }
        private System.Boolean get_ValueAsBoolean() { }
        private System.DateTime get_ValueAsDateTime() { }
        private System.Double get_ValueAsDouble() { }
        private System.Int32 get_ValueAsInt() { }
        private System.Int64 get_ValueAsLong() { }
        private System.Object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver) { }
        private System.Object System.ICloneable.Clone() { }
        private System.Xml.XPath.XPathNavigator CreateNavigator() { }
        private System.Xml.XmlNameTable get_NameTable() { }
        private System.String LookupNamespace(System.String prefix) { }
        private System.String LookupPrefix(System.String namespaceURI) { }
        private System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { }
        private System.Xml.XPath.XPathNavigator Clone() { }
        private System.Xml.XPath.XPathNodeType get_NodeType() { }
        private System.String get_LocalName() { }
        private System.String get_Name() { }
        private System.String get_NamespaceURI() { }
        private System.String get_Prefix() { }
        private System.String get_BaseURI() { }
        private System.String get_XmlLang() { }
        private System.Object get_UnderlyingObject() { }
        private System.Boolean MoveToAttribute(System.String localName, System.String namespaceURI) { }
        private System.Boolean MoveToFirstAttribute() { }
        private System.Boolean MoveToNextAttribute() { }
        private System.Boolean MoveToNamespace(System.String name) { }
        private System.Boolean MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope) { }
        private System.Boolean MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope) { }
        private System.Boolean MoveToFirstNamespace() { }
        private System.Boolean MoveToNextNamespace() { }
        private System.Boolean MoveToNext() { }
        private System.Boolean MoveToFirstChild() { }
        private System.Boolean MoveToParent() { }
        private System.Void MoveToRoot() { }
        private System.Boolean MoveTo(System.Xml.XPath.XPathNavigator other) { }
        private System.Boolean MoveToId(System.String id) { }
        private System.Boolean MoveToChild(System.String localName, System.String namespaceURI) { }
        private System.Boolean MoveToChild(System.Xml.XPath.XPathNodeType type) { }
        private System.Boolean MoveToFollowing(System.String localName, System.String namespaceURI, System.Xml.XPath.XPathNavigator end) { }
        private System.Boolean MoveToFollowing(System.Xml.XPath.XPathNodeType type, System.Xml.XPath.XPathNavigator end) { }
        private System.Boolean MoveToNext(System.String localName, System.String namespaceURI) { }
        private System.Boolean MoveToNext(System.Xml.XPath.XPathNodeType type) { }
        private System.Boolean IsSamePosition(System.Xml.XPath.XPathNavigator other) { }
        private System.Boolean IsDescendant(System.Xml.XPath.XPathNavigator nav) { }
        private System.Xml.XmlNodeOrder ComparePosition(System.Xml.XPath.XPathNavigator nav) { }
        private System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo() { }
        private System.Xml.XPath.XPathNodeIterator Select(System.String xpath) { }
        private System.Xml.XPath.XPathNodeIterator Select(System.Xml.XPath.XPathExpression expr) { }
        private System.Object Evaluate(System.Xml.XPath.XPathExpression expr) { }
        private System.Object Evaluate(System.Xml.XPath.XPathExpression expr, System.Xml.XPath.XPathNodeIterator context) { }
        private System.Xml.XPath.XPathNodeIterator SelectChildren(System.Xml.XPath.XPathNodeType type) { }
        private System.Xml.XPath.XPathNodeIterator SelectChildren(System.String name, System.String namespaceURI) { }
        private System.Xml.XPath.XPathNodeIterator SelectDescendants(System.Xml.XPath.XPathNodeType type, System.Boolean matchSelf) { }
        private System.Xml.XPath.XPathNodeIterator SelectDescendants(System.String name, System.String namespaceURI, System.Boolean matchSelf) { }
        private System.Boolean MoveToNonDescendant() { }
        private System.Int32 GetDepth(System.Xml.XPath.XPathNavigator nav) { }
        private System.Xml.XmlNodeOrder CompareSiblings(System.Xml.XPath.XPathNavigator n1, System.Xml.XPath.XPathNavigator n2) { }
        private System.Int32 GetContentKindMask(System.Xml.XPath.XPathNodeType type) { }
        private System.Int32 GetKindMask(System.Xml.XPath.XPathNodeType type) { }
        private System.Boolean IsText(System.Xml.XPath.XPathNodeType type) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000FC
    public class XPathNavigatorKeyComparer, IEqualityComparer
    {
        // Methods
        private System.Boolean System.Collections.IEqualityComparer.Equals(System.Object obj1, System.Object obj2) { }
        private System.Int32 System.Collections.IEqualityComparer.GetHashCode(System.Object obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FD
    public class XPathNodeIterator, ICloneable, IEnumerable
    {
        // Fields
        private System.Int32 count;        // 0x10

        // Methods
        private System.Object System.ICloneable.Clone() { }
        private System.Xml.XPath.XPathNodeIterator Clone() { }
        private System.Boolean MoveNext() { }
        private System.Xml.XPath.XPathNavigator get_Current() { }
        private System.Int32 get_CurrentPosition() { }
        private System.Int32 get_Count() { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FF
    public struct XPathNodeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Xml.XPath.XPathNodeType Root;        // 0x0
        public static System.Xml.XPath.XPathNodeType Element;        // 0x0
        public static System.Xml.XPath.XPathNodeType Attribute;        // 0x0
        public static System.Xml.XPath.XPathNodeType Namespace;        // 0x0
        public static System.Xml.XPath.XPathNodeType Text;        // 0x0
        public static System.Xml.XPath.XPathNodeType SignificantWhitespace;        // 0x0
        public static System.Xml.XPath.XPathNodeType Whitespace;        // 0x0
        public static System.Xml.XPath.XPathNodeType ProcessingInstruction;        // 0x0
        public static System.Xml.XPath.XPathNodeType Comment;        // 0x0
        public static System.Xml.XPath.XPathNodeType All;        // 0x0

    }

}

namespace System.Xml.XmlConfiguration
{

    // TypeToken: 0x2000158
    public class XmlReaderSection
    {
        // Methods
        private System.Boolean get_ProhibitDefaultUrlResolver() { }
        private System.Xml.XmlResolver CreateDefaultResolver() { }
        private System.Boolean get_CollapseWhiteSpaceIntoEmptyString() { }

    }

}

namespace System.Xml.Xsl
{

    // TypeToken: 0x2000159
    public interface IXsltContextFunction
    {
        // Methods
        private System.Xml.XPath.XPathResultType get_ReturnType() { }
        private System.Object Invoke(System.Xml.Xsl.XsltContext xsltContext, System.Object[] args, System.Xml.XPath.XPathNavigator docContext) { }

    }

    // TypeToken: 0x200015A
    public interface IXsltContextVariable
    {
        // Methods
        private System.Xml.XPath.XPathResultType get_VariableType() { }
        private System.Object Evaluate(System.Xml.Xsl.XsltContext xsltContext) { }

    }

    // TypeToken: 0x200015B
    public class XsltContext : XmlNamespaceManager
    {
        // Methods
        private System.Void .ctor(System.Boolean dummy) { }
        private System.Xml.Xsl.IXsltContextVariable ResolveVariable(System.String prefix, System.String name) { }
        private System.Xml.Xsl.IXsltContextFunction ResolveFunction(System.String prefix, System.String name, System.Xml.XPath.XPathResultType[] ArgTypes) { }
        private System.Boolean get_Whitespace() { }
        private System.Boolean PreserveWhitespace(System.Xml.XPath.XPathNavigator node) { }

    }

}

namespace System.Xml.Xsl.Runtime
{

    // TypeToken: 0x200015C
    public struct StringConcat
    {
        // Fields
        private System.String s1;        // 0x10
        private System.String s2;        // 0x18
        private System.String s3;        // 0x20
        private System.String s4;        // 0x28
        private System.String delimiter;        // 0x30
        private System.Collections.Generic.List<System.String> strList;        // 0x38
        private System.Int32 idxStr;        // 0x40

        // Methods
        private System.Void Clear() { }
        private System.Int32 get_Count() { }
        private System.String GetResult() { }
        private System.Void ConcatNoDelimiter(System.String s) { }

    }

}

