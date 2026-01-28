// ========================================================
// Dumped by @desirepro
// Assembly: System.Xml.dll
// Classes:  753
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SR
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.String GetString(System.String name, System.Object[] args)
  System.String GetString(System.Globalization.CultureInfo culture, System.String name, System.Object[] args)
  System.String Format(System.String resourceFormat, System.Object p1)
END_CLASS

CLASS: ScanState
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlSqlBinaryReader.ScanStateDoc  // 0x0
  public    static  System.Xml.XmlSqlBinaryReader.ScanStateXmlText  // 0x0
  public    static  System.Xml.XmlSqlBinaryReader.ScanStateAttr  // 0x0
  public    static  System.Xml.XmlSqlBinaryReader.ScanStateAttrVal  // 0x0
  public    static  System.Xml.XmlSqlBinaryReader.ScanStateAttrValPseudoValue  // 0x0
  public    static  System.Xml.XmlSqlBinaryReader.ScanStateInit  // 0x0
  public    static  System.Xml.XmlSqlBinaryReader.ScanStateError  // 0x0
  public    static  System.Xml.XmlSqlBinaryReader.ScanStateEOF  // 0x0
  public    static  System.Xml.XmlSqlBinaryReader.ScanStateClosed  // 0x0
METHODS:
END_CLASS

CLASS: QName
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.String                   prefix  // 0x10
  public            System.String                   localname  // 0x18
  public            System.String                   namespaceUri  // 0x20
METHODS:
  System.Void .ctor(System.String prefix, System.String lname, System.String nsUri)
  System.Void Set(System.String prefix, System.String lname, System.String nsUri)
  System.Void Clear()
  System.Boolean MatchNs(System.String lname, System.String nsUri)
  System.Boolean MatchPrefix(System.String prefix, System.String lname)
  System.Void CheckPrefixNS(System.String prefix, System.String namespaceUri)
  System.Int32 GetHashCode()
  System.Int32 GetNSHashCode(System.Xml.SecureStringHasher hasher)
  System.Boolean Equals(System.Object other)
  System.String ToString()
  System.Boolean op_Equality(System.Xml.XmlSqlBinaryReader.QName a, System.Xml.XmlSqlBinaryReader.QName b)
END_CLASS

CLASS: ElemInfo
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Xml.XmlSqlBinaryReader.QNamename  // 0x10
  public            System.String                   xmlLang  // 0x28
  public            System.Xml.XmlSpace             xmlSpace  // 0x30
  public            System.Boolean                  xmlspacePreserve  // 0x34
  public            System.Xml.XmlSqlBinaryReader.NamespaceDeclnsdecls  // 0x38
METHODS:
  System.Void Set(System.Xml.XmlSqlBinaryReader.QName name, System.Boolean xmlspacePreserve)
  System.Xml.XmlSqlBinaryReader.NamespaceDecl Clear()
END_CLASS

CLASS: AttrInfo
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Xml.XmlSqlBinaryReader.QNamename  // 0x10
  public            System.String                   val  // 0x28
  public            System.Int32                    contentPos  // 0x30
  public            System.Int32                    hashCode  // 0x34
  public            System.Int32                    prevHash  // 0x38
METHODS:
  System.Void Set(System.Xml.XmlSqlBinaryReader.QName n, System.String v)
  System.Void Set(System.Xml.XmlSqlBinaryReader.QName n, System.Int32 pos)
  System.Void GetLocalnameAndNamespaceUri(System.String& localname, System.String& namespaceUri)
  System.Int32 GetLocalnameAndNamespaceUriAndHash(System.Xml.SecureStringHasher hasher, System.String& localname, System.String& namespaceUri)
  System.Boolean MatchNS(System.String localname, System.String namespaceUri)
  System.Boolean MatchHashNS(System.Int32 hash, System.String localname, System.String namespaceUri)
  System.Void AdjustPosition(System.Int32 adj)
END_CLASS

CLASS: NamespaceDecl
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  public            System.String                   prefix  // 0x10
  public            System.String                   uri  // 0x18
  public            System.Xml.XmlSqlBinaryReader.NamespaceDeclscopeLink  // 0x20
  public            System.Xml.XmlSqlBinaryReader.NamespaceDeclprevLink  // 0x28
  public            System.Int32                    scope  // 0x30
  public            System.Boolean                  implied  // 0x34
METHODS:
  System.Void .ctor(System.String prefix, System.String nsuri, System.Xml.XmlSqlBinaryReader.NamespaceDecl nextInScope, System.Xml.XmlSqlBinaryReader.NamespaceDecl prevDecl, System.Int32 scope, System.Boolean implied)
END_CLASS

CLASS: SymbolTables
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.String[]                 symtable  // 0x10
  public            System.Int32                    symCount  // 0x18
  public            System.Xml.XmlSqlBinaryReader.QName[]qnametable  // 0x20
  public            System.Int32                    qnameCount  // 0x28
METHODS:
  System.Void Init()
END_CLASS

CLASS: NestedBinXml
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  public            System.Xml.XmlSqlBinaryReader.SymbolTablessymbolTables  // 0x10
  public            System.Int32                    docState  // 0x30
  public            System.Xml.XmlSqlBinaryReader.NestedBinXmlnext  // 0x38
METHODS:
  System.Void .ctor(System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables, System.Int32 docState, System.Xml.XmlSqlBinaryReader.NestedBinXml next)
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.ReadContentAsBinaryHelper.StateNone  // 0x0
  public    static  System.Xml.ReadContentAsBinaryHelper.StateInReadContent  // 0x0
  public    static  System.Xml.ReadContentAsBinaryHelper.StateInReadElementContent  // 0x0
METHODS:
END_CLASS

CLASS: HashCodeOfStringDelegate
TYPE:  class
TOKEN: 0x200003D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.String s, System.Int32 sLen, System.Int64 additionalEntropy)
END_CLASS

CLASS: XmlEventType
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlEventCache.XmlEventTypeUnknown  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeDocType  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeStartElem  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeStartAttr  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeEndAttr  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeCData  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeComment  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypePI  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeWhitespace  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeString  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeRaw  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeEntRef  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeCharEnt  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeSurrCharEnt  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeBase64  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeBinHex  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeXmlDecl1  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeXmlDecl2  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeStartContent  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeEndElem  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeFullEndElem  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeNmsp  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeEndBase64  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeClose  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeFlush  // 0x0
  public    static  System.Xml.XmlEventCache.XmlEventTypeDispose  // 0x0
METHODS:
END_CLASS

CLASS: XmlEvent
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  private           System.Xml.XmlEventCache.XmlEventTypeeventType  // 0x10
  private           System.String                   s1  // 0x18
  private           System.String                   s2  // 0x20
  private           System.String                   s3  // 0x28
  private           System.Object                   o  // 0x30
METHODS:
  System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType)
  System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1)
  System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2)
  System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2, System.String s3)
  System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2, System.String s3, System.Object o)
  System.Void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.Object o)
  System.Xml.XmlEventCache.XmlEventType get_EventType()
  System.String get_String1()
  System.String get_String2()
  System.String get_String3()
  System.Object get_Object()
END_CLASS

CLASS: ParsingFunction
TYPE:  struct
TOKEN: 0x2000057
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionElementContent  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionNoData  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionOpenUrl  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionSwitchToInteractive  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionSwitchToInteractiveXmlDecl  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionDocumentContent  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionMoveToElementContent  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionPopElementContext  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionPopEmptyElementContext  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionResetAttributesRootLevel  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionError  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionEof  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionReaderClosed  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionEntityReference  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionInIncrementalRead  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionFragmentAttribute  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionReportEndEntity  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionAfterResolveEntityInContent  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionAfterResolveEmptyEntityInContent  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionXmlDeclarationFragment  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionGoToEof  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionPartialTextValue  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionInReadAttributeValue  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionInReadValueChunk  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionInReadContentAsBinary  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingFunctionInReadElementContentAsBinary  // 0x0
METHODS:
END_CLASS

CLASS: ParsingMode
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlTextReaderImpl.ParsingModeFull  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingModeSkipNode  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.ParsingModeSkipContent  // 0x0
METHODS:
END_CLASS

CLASS: EntityType
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlTextReaderImpl.EntityTypeCharacterDec  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.EntityTypeCharacterHex  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.EntityTypeCharacterNamed  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.EntityTypeExpanded  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.EntityTypeSkipped  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.EntityTypeFakeExpanded  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.EntityTypeUnexpanded  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.EntityTypeExpandedInAttribute  // 0x0
METHODS:
END_CLASS

CLASS: EntityExpandType
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlTextReaderImpl.EntityExpandTypeAll  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.EntityExpandTypeOnlyGeneral  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.EntityExpandTypeOnlyCharacter  // 0x0
METHODS:
END_CLASS

CLASS: IncrementalReadState
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateText  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateStartTag  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStatePI  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateCDATA  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateComment  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateAttributes  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateAttributeValue  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateReadData  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateEndElement  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateEnd  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateReadValueChunk_OnCachedValue  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateReadValueChunk_OnPartialValue  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateReadContentAsBinary_OnCachedValue  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateReadContentAsBinary_OnPartialValue  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.IncrementalReadStateReadContentAsBinary_End  // 0x0
METHODS:
END_CLASS

CLASS: LaterInitParam
TYPE:  class
TOKEN: 0x200005C
FIELDS:
  public            System.Boolean                  useAsync  // 0x10
  public            System.IO.Stream                inputStream  // 0x18
  public            System.Byte[]                   inputBytes  // 0x20
  public            System.Int32                    inputByteCount  // 0x28
  public            System.Uri                      inputbaseUri  // 0x30
  public            System.String                   inputUriStr  // 0x38
  public            System.Xml.XmlResolver          inputUriResolver  // 0x40
  public            System.Xml.XmlParserContext     inputContext  // 0x48
  public            System.IO.TextReader            inputTextReader  // 0x50
  public            System.Xml.XmlTextReaderImpl.InitInputTypeinitType  // 0x58
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: InitInputType
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlTextReaderImpl.InitInputTypeUriString  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.InitInputTypeStream  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.InitInputTypeTextReader  // 0x0
  public    static  System.Xml.XmlTextReaderImpl.InitInputTypeInvalid  // 0x0
METHODS:
END_CLASS

CLASS: ParsingState
TYPE:  struct
TOKEN: 0x200005E
FIELDS:
  private           System.Char[]                   chars  // 0x10
  private           System.Int32                    charPos  // 0x18
  private           System.Int32                    charsUsed  // 0x1C
  private           System.Text.Encoding            encoding  // 0x20
  private           System.Boolean                  appendMode  // 0x28
  private           System.IO.Stream                stream  // 0x30
  private           System.Text.Decoder             decoder  // 0x38
  private           System.Byte[]                   bytes  // 0x40
  private           System.Int32                    bytePos  // 0x48
  private           System.Int32                    bytesUsed  // 0x4C
  private           System.IO.TextReader            textReader  // 0x50
  private           System.Int32                    lineNo  // 0x58
  private           System.Int32                    lineStartPos  // 0x5C
  private           System.String                   baseUriStr  // 0x60
  private           System.Uri                      baseUri  // 0x68
  private           System.Boolean                  isEof  // 0x70
  private           System.Boolean                  isStreamEof  // 0x71
  private           System.Xml.IDtdEntityInfo       entity  // 0x78
  private           System.Int32                    entityId  // 0x80
  private           System.Boolean                  eolNormalized  // 0x84
  private           System.Boolean                  entityResolvedManually  // 0x85
METHODS:
  System.Void Clear()
  System.Void Close(System.Boolean closeInput)
  System.Int32 get_LineNo()
  System.Int32 get_LinePos()
END_CLASS

CLASS: XmlContext
TYPE:  class
TOKEN: 0x200005F
FIELDS:
  private           System.Xml.XmlSpace             xmlSpace  // 0x10
  private           System.String                   xmlLang  // 0x18
  private           System.String                   defaultNamespace  // 0x20
  private           System.Xml.XmlTextReaderImpl.XmlContextpreviousContext  // 0x28
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Xml.XmlTextReaderImpl.XmlContext previousContext)
END_CLASS

CLASS: NoNamespaceManager
TYPE:  class
TOKEN: 0x2000060
EXTENDS: XmlNamespaceManager
FIELDS:
METHODS:
  System.Void .ctor()
  System.String get_DefaultNamespace()
  System.Void PushScope()
  System.Boolean PopScope()
  System.Void AddNamespace(System.String prefix, System.String uri)
  System.Void RemoveNamespace(System.String prefix, System.String uri)
  System.Collections.IEnumerator GetEnumerator()
  System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String LookupNamespace(System.String prefix)
  System.String LookupPrefix(System.String uri)
END_CLASS

CLASS: DtdParserProxy
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  private           System.Xml.XmlTextReaderImpl    reader  // 0x10
METHODS:
  System.Void .ctor(System.Xml.XmlTextReaderImpl reader)
  System.Xml.XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable()
  System.Xml.IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver()
  System.Uri System.Xml.IDtdParserAdapter.get_BaseUri()
  System.Boolean System.Xml.IDtdParserAdapter.get_IsEof()
  System.Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer()
  System.Int32 System.Xml.IDtdParserAdapter.get_ParsingBufferLength()
  System.Int32 System.Xml.IDtdParserAdapter.get_CurrentPosition()
  System.Void System.Xml.IDtdParserAdapter.set_CurrentPosition(System.Int32 value)
  System.Int32 System.Xml.IDtdParserAdapter.get_EntityStackLength()
  System.Boolean System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized()
  System.Void System.Xml.IDtdParserAdapter.OnNewLine(System.Int32 pos)
  System.Int32 System.Xml.IDtdParserAdapter.get_LineNo()
  System.Int32 System.Xml.IDtdParserAdapter.get_LineStartPosition()
  System.Int32 System.Xml.IDtdParserAdapter.ReadData()
  System.Int32 System.Xml.IDtdParserAdapter.ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder)
  System.Int32 System.Xml.IDtdParserAdapter.ParseNamedCharRef(System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder)
  System.Void System.Xml.IDtdParserAdapter.ParsePI(System.Text.StringBuilder sb)
  System.Void System.Xml.IDtdParserAdapter.ParseComment(System.Text.StringBuilder sb)
  System.Boolean System.Xml.IDtdParserAdapter.PushEntity(System.Xml.IDtdEntityInfo entity, System.Int32& entityId)
  System.Boolean System.Xml.IDtdParserAdapter.PopEntity(System.Xml.IDtdEntityInfo& oldEntity, System.Int32& newEntityId)
  System.Boolean System.Xml.IDtdParserAdapter.PushExternalSubset(System.String systemId, System.String publicId)
  System.Void System.Xml.IDtdParserAdapter.PushInternalDtd(System.String baseUri, System.String internalDtd)
  System.Void System.Xml.IDtdParserAdapter.Throw(System.Exception e)
  System.Void System.Xml.IDtdParserAdapter.OnSystemId(System.String systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo)
  System.Void System.Xml.IDtdParserAdapter.OnPublicId(System.String publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo)
  System.Boolean System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation()
  System.Xml.IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling()
  System.Boolean System.Xml.IDtdParserAdapterV1.get_Normalization()
  System.Boolean System.Xml.IDtdParserAdapterV1.get_Namespaces()
  System.Boolean System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode()
END_CLASS

CLASS: NodeData
TYPE:  class
TOKEN: 0x2000062
FIELDS:
  private   static  System.Xml.XmlTextReaderImpl.NodeDatas_None  // 0x0
  private           System.Xml.XmlNodeType          type  // 0x10
  private           System.String                   localName  // 0x18
  private           System.String                   prefix  // 0x20
  private           System.String                   ns  // 0x28
  private           System.String                   nameWPrefix  // 0x30
  private           System.String                   value  // 0x38
  private           System.Char[]                   chars  // 0x40
  private           System.Int32                    valueStartPos  // 0x48
  private           System.Int32                    valueLength  // 0x4C
  private           System.Xml.LineInfo             lineInfo  // 0x50
  private           System.Xml.LineInfo             lineInfo2  // 0x58
  private           System.Char                     quoteChar  // 0x60
  private           System.Int32                    depth  // 0x64
  private           System.Boolean                  isEmptyOrDefault  // 0x68
  private           System.Int32                    entityId  // 0x6C
  private           System.Boolean                  xmlContextPushed  // 0x70
  private           System.Xml.XmlTextReaderImpl.NodeDatanextAttrValueChunk  // 0x78
  private           System.Object                   schemaType  // 0x80
  private           System.Object                   typedValue  // 0x88
METHODS:
  System.Xml.XmlTextReaderImpl.NodeData get_None()
  System.Void .ctor()
  System.Int32 get_LineNo()
  System.Int32 get_LinePos()
  System.Boolean get_IsEmptyElement()
  System.Void set_IsEmptyElement(System.Boolean value)
  System.Boolean get_IsDefaultAttribute()
  System.Void set_IsDefaultAttribute(System.Boolean value)
  System.Boolean get_ValueBuffered()
  System.String get_StringValue()
  System.Void TrimSpacesInValue()
  System.Void Clear(System.Xml.XmlNodeType type)
  System.Void ClearName()
  System.Void SetLineInfo(System.Int32 lineNo, System.Int32 linePos)
  System.Void SetLineInfo2(System.Int32 lineNo, System.Int32 linePos)
  System.Void SetValueNode(System.Xml.XmlNodeType type, System.String value)
  System.Void SetValueNode(System.Xml.XmlNodeType type, System.Char[] chars, System.Int32 startPos, System.Int32 len)
  System.Void SetNamedNode(System.Xml.XmlNodeType type, System.String localName)
  System.Void SetNamedNode(System.Xml.XmlNodeType type, System.String localName, System.String prefix, System.String nameWPrefix)
  System.Void SetValue(System.String value)
  System.Void SetValue(System.Char[] chars, System.Int32 startPos, System.Int32 len)
  System.Void OnBufferInvalidated()
  System.Void CopyTo(System.Int32 valueOffset, System.Text.StringBuilder sb)
  System.Int32 CopyTo(System.Int32 valueOffset, System.Char[] buffer, System.Int32 offset, System.Int32 length)
  System.String GetNameWPrefix(System.Xml.XmlNameTable nt)
  System.String CreateNameWPrefix(System.Xml.XmlNameTable nt)
  System.Int32 System.IComparable.CompareTo(System.Object obj)
END_CLASS

CLASS: DtdDefaultAttributeInfoToNodeDataComparer
TYPE:  class
TOKEN: 0x2000063
FIELDS:
  private   static  System.Collections.Generic.IComparer<System.Object>s_instance  // 0x0
METHODS:
  System.Collections.Generic.IComparer<System.Object> get_Instance()
  System.Int32 Compare(System.Object x, System.Object y)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: OnDefaultAttributeUseDelegate
TYPE:  class
TOKEN: 0x2000064
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader)
END_CLASS

CLASS: NamespaceState
TYPE:  struct
TOKEN: 0x2000067
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlTextWriter.NamespaceStateUninitialized  // 0x0
  public    static  System.Xml.XmlTextWriter.NamespaceStateNotDeclaredButInScope  // 0x0
  public    static  System.Xml.XmlTextWriter.NamespaceStateDeclaredButNotWrittenOut  // 0x0
  public    static  System.Xml.XmlTextWriter.NamespaceStateDeclaredAndWrittenOut  // 0x0
METHODS:
END_CLASS

CLASS: TagInfo
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  private           System.String                   name  // 0x10
  private           System.String                   prefix  // 0x18
  private           System.String                   defaultNs  // 0x20
  private           System.Xml.XmlTextWriter.NamespaceStatedefaultNsState  // 0x28
  private           System.Xml.XmlSpace             xmlSpace  // 0x2C
  private           System.String                   xmlLang  // 0x30
  private           System.Int32                    prevNsTop  // 0x38
  private           System.Int32                    prefixCount  // 0x3C
  private           System.Boolean                  mixed  // 0x40
METHODS:
  System.Void Init(System.Int32 nsTop)
END_CLASS

CLASS: Namespace
TYPE:  struct
TOKEN: 0x2000069
FIELDS:
  private           System.String                   prefix  // 0x10
  private           System.String                   ns  // 0x18
  private           System.Boolean                  declared  // 0x20
  private           System.Int32                    prevNsIndex  // 0x24
METHODS:
  System.Void Set(System.String prefix, System.String ns, System.Boolean declared)
END_CLASS

CLASS: SpecialAttr
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlTextWriter.SpecialAttrNone  // 0x0
  public    static  System.Xml.XmlTextWriter.SpecialAttrXmlSpace  // 0x0
  public    static  System.Xml.XmlTextWriter.SpecialAttrXmlLang  // 0x0
  public    static  System.Xml.XmlTextWriter.SpecialAttrXmlNs  // 0x0
METHODS:
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x200006B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlTextWriter.State  Start  // 0x0
  public    static  System.Xml.XmlTextWriter.State  Prolog  // 0x0
  public    static  System.Xml.XmlTextWriter.State  PostDTD  // 0x0
  public    static  System.Xml.XmlTextWriter.State  Element  // 0x0
  public    static  System.Xml.XmlTextWriter.State  Attribute  // 0x0
  public    static  System.Xml.XmlTextWriter.State  Content  // 0x0
  public    static  System.Xml.XmlTextWriter.State  AttrOnly  // 0x0
  public    static  System.Xml.XmlTextWriter.State  Epilog  // 0x0
  public    static  System.Xml.XmlTextWriter.State  Error  // 0x0
  public    static  System.Xml.XmlTextWriter.State  Closed  // 0x0
METHODS:
END_CLASS

CLASS: Token
TYPE:  struct
TOKEN: 0x200006C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlTextWriter.Token  PI  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  Doctype  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  Comment  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  CData  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  StartElement  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  EndElement  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  LongEndElement  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  StartAttribute  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  EndAttribute  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  Content  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  Base64  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  RawData  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  Whitespace  // 0x0
  public    static  System.Xml.XmlTextWriter.Token  Empty  // 0x0
METHODS:
END_CLASS

CLASS: ParsingFunction
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlValidatingReaderImpl.ParsingFunctionRead  // 0x0
  public    static  System.Xml.XmlValidatingReaderImpl.ParsingFunctionInit  // 0x0
  public    static  System.Xml.XmlValidatingReaderImpl.ParsingFunctionParseDtdFromContext  // 0x0
  public    static  System.Xml.XmlValidatingReaderImpl.ParsingFunctionResolveEntityInternally  // 0x0
  public    static  System.Xml.XmlValidatingReaderImpl.ParsingFunctionInReadBinaryContent  // 0x0
  public    static  System.Xml.XmlValidatingReaderImpl.ParsingFunctionReaderClosed  // 0x0
  public    static  System.Xml.XmlValidatingReaderImpl.ParsingFunctionError  // 0x0
  public    static  System.Xml.XmlValidatingReaderImpl.ParsingFunctionNone  // 0x0
METHODS:
END_CLASS

CLASS: ValidationEventHandling
TYPE:  class
TOKEN: 0x2000072
FIELDS:
  private           System.Xml.XmlValidatingReaderImplreader  // 0x10
  private           System.Xml.Schema.ValidationEventHandlereventHandler  // 0x18
METHODS:
  System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader)
  System.Object System.Xml.IValidationEventHandling.get_EventHandler()
  System.Void System.Xml.IValidationEventHandling.SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity)
  System.Void AddHandler(System.Xml.Schema.ValidationEventHandler handler)
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlWellFormedWriter.StateStart  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateTopLevel  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateDocument  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateElement  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateContent  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateB64Content  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateB64Attribute  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateAfterRootEle  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateAttribute  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateSpecialAttr  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateEndDocument  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateRootLevelAttr  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateRootLevelSpecAttr  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateRootLevelB64Attr  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateAfterRootLevelAttr  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateClosed  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateError  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateStartContent  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateStartContentEle  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateStartContentB64  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateStartDoc  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateStartDocEle  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateEndAttrSEle  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateEndAttrEEle  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateEndAttrSCont  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateEndAttrSAttr  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StatePostB64Cont  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StatePostB64Attr  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StatePostB64RootAttr  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateStartFragEle  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateStartFragCont  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateStartFragB64  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.StateStartRootLevelAttr  // 0x0
METHODS:
END_CLASS

CLASS: Token
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlWellFormedWriter.TokenStartDocument  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenEndDocument  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenPI  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenComment  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenDtd  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenStartElement  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenEndElement  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenStartAttribute  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenEndAttribute  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenText  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenCData  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenAtomicValue  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenBase64  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenRawData  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.TokenWhitespace  // 0x0
METHODS:
END_CLASS

CLASS: NamespaceResolverProxy
TYPE:  class
TOKEN: 0x2000076
FIELDS:
  private           System.Xml.XmlWellFormedWriter  wfWriter  // 0x10
METHODS:
  System.Void .ctor(System.Xml.XmlWellFormedWriter wfWriter)
  System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix)
  System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName)
END_CLASS

CLASS: ElementScope
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  private           System.Int32                    prevNSTop  // 0x10
  private           System.String                   prefix  // 0x18
  private           System.String                   localName  // 0x20
  private           System.String                   namespaceUri  // 0x28
  private           System.Xml.XmlSpace             xmlSpace  // 0x30
  private           System.String                   xmlLang  // 0x38
METHODS:
  System.Void Set(System.String prefix, System.String localName, System.String namespaceUri, System.Int32 prevNSTop)
  System.Void WriteEndElement(System.Xml.XmlRawWriter rawWriter)
  System.Void WriteFullEndElement(System.Xml.XmlRawWriter rawWriter)
END_CLASS

CLASS: NamespaceKind
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlWellFormedWriter.NamespaceKindWritten  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.NamespaceKindNeedToWrite  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.NamespaceKindImplied  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.NamespaceKindSpecial  // 0x0
METHODS:
END_CLASS

CLASS: Namespace
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  private           System.String                   prefix  // 0x10
  private           System.String                   namespaceUri  // 0x18
  private           System.Xml.XmlWellFormedWriter.NamespaceKindkind  // 0x20
  private           System.Int32                    prevNsIndex  // 0x24
METHODS:
  System.Void Set(System.String prefix, System.String namespaceUri, System.Xml.XmlWellFormedWriter.NamespaceKind kind)
  System.Void WriteDecl(System.Xml.XmlWriter writer, System.Xml.XmlRawWriter rawWriter)
END_CLASS

CLASS: AttrName
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  private           System.String                   prefix  // 0x10
  private           System.String                   namespaceUri  // 0x18
  private           System.String                   localName  // 0x20
  private           System.Int32                    prev  // 0x28
METHODS:
  System.Void Set(System.String prefix, System.String localName, System.String namespaceUri)
  System.Boolean IsDuplicate(System.String prefix, System.String localName, System.String namespaceUri)
END_CLASS

CLASS: SpecialAttribute
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlWellFormedWriter.SpecialAttributeNo  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.SpecialAttributeDefaultXmlns  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.SpecialAttributePrefixedXmlns  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.SpecialAttributeXmlSpace  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.SpecialAttributeXmlLang  // 0x0
METHODS:
END_CLASS

CLASS: ItemType
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemTypeEntityRef  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemTypeCharEntity  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemTypeSurrogateCharEntity  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemTypeWhitespace  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemTypeString  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemTypeStringChars  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemTypeRaw  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemTypeRawChars  // 0x0
  public    static  System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemTypeValueString  // 0x0
METHODS:
END_CLASS

CLASS: Item
TYPE:  class
TOKEN: 0x200007E
FIELDS:
  private           System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemTypetype  // 0x10
  private           System.Object                   data  // 0x18
METHODS:
  System.Void .ctor()
  System.Void Set(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, System.Object data)
END_CLASS

CLASS: BufferChunk
TYPE:  class
TOKEN: 0x200007F
FIELDS:
  private           System.Char[]                   buffer  // 0x10
  private           System.Int32                    index  // 0x18
  private           System.Int32                    count  // 0x1C
METHODS:
  System.Void .ctor(System.Char[] buffer, System.Int32 index, System.Int32 count)
END_CLASS

CLASS: AttributeValueCache
TYPE:  class
TOKEN: 0x200007C
FIELDS:
  private           System.Text.StringBuilder       stringValue  // 0x10
  private           System.String                   singleStringValue  // 0x18
  private           System.Xml.XmlWellFormedWriter.AttributeValueCache.Item[]items  // 0x20
  private           System.Int32                    firstItem  // 0x28
  private           System.Int32                    lastItem  // 0x2C
METHODS:
  System.String get_StringValue()
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteWhitespace(System.String ws)
  System.Void WriteString(System.String text)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.String data)
  System.Void WriteValue(System.String value)
  System.Void Replay(System.Xml.XmlWriter writer)
  System.Void Trim()
  System.Void Clear()
  System.Void StartComplexValue()
  System.Void AddItem(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, System.Object data)
  System.Void .ctor()
END_CLASS

CLASS: CachingReaderState
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XsdCachingReader.CachingReaderStateNone  // 0x0
  public    static  System.Xml.XsdCachingReader.CachingReaderStateInit  // 0x0
  public    static  System.Xml.XsdCachingReader.CachingReaderStateRecord  // 0x0
  public    static  System.Xml.XsdCachingReader.CachingReaderStateReplay  // 0x0
  public    static  System.Xml.XsdCachingReader.CachingReaderStateReaderClosed  // 0x0
  public    static  System.Xml.XsdCachingReader.CachingReaderStateError  // 0x0
METHODS:
END_CLASS

CLASS: ValidatingReaderState
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateNone  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateInit  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateRead  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateOnDefaultAttribute  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateOnReadAttributeValue  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateOnAttribute  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateClearAttributes  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateParseInlineSchema  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateReadAhead  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateOnReadBinaryContent  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateReaderClosed  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateEOF  // 0x0
  public    static  System.Xml.XsdValidatingReader.ValidatingReaderStateError  // 0x0
METHODS:
END_CLASS

CLASS: SingleObjectEnumerator
TYPE:  class
TOKEN: 0x20000AE
FIELDS:
  private           System.Object                   loneValue  // 0x10
  private           System.Int32                    position  // 0x18
METHODS:
  System.Void .ctor(System.Object value)
  System.Object get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: SmallXmlNodeList
TYPE:  struct
TOKEN: 0x20000AD
FIELDS:
  private           System.Object                   field  // 0x10
METHODS:
  System.Int32 get_Count()
  System.Object get_Item(System.Int32 index)
  System.Void Add(System.Object value)
  System.Void RemoveAt(System.Int32 index)
  System.Void Insert(System.Int32 index, System.Object value)
  System.Collections.IEnumerator GetEnumerator()
END_CLASS

CLASS: VirtualAttribute
TYPE:  struct
TOKEN: 0x20000B4
FIELDS:
  private           System.String                   name  // 0x10
  private           System.String                   value  // 0x18
METHODS:
  System.Void .ctor(System.String name, System.String value)
END_CLASS

CLASS: Entry
TYPE:  class
TOKEN: 0x20000C5
FIELDS:
  private           System.String                   str  // 0x10
  private           System.Int32                    hashCode  // 0x18
  private           System.Xml.NameTable.Entry      next  // 0x20
METHODS:
  System.Void .ctor(System.String str, System.Int32 hashCode, System.Xml.NameTable.Entry next)
END_CLASS

CLASS: Token
TYPE:  struct
TOKEN: 0x20000C8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.DtdParser.Token      CDATA  // 0x0
  public    static  System.Xml.DtdParser.Token      ID  // 0x0
  public    static  System.Xml.DtdParser.Token      IDREF  // 0x0
  public    static  System.Xml.DtdParser.Token      IDREFS  // 0x0
  public    static  System.Xml.DtdParser.Token      ENTITY  // 0x0
  public    static  System.Xml.DtdParser.Token      ENTITIES  // 0x0
  public    static  System.Xml.DtdParser.Token      NMTOKEN  // 0x0
  public    static  System.Xml.DtdParser.Token      NMTOKENS  // 0x0
  public    static  System.Xml.DtdParser.Token      NOTATION  // 0x0
  public    static  System.Xml.DtdParser.Token      None  // 0x0
  public    static  System.Xml.DtdParser.Token      PERef  // 0x0
  public    static  System.Xml.DtdParser.Token      AttlistDecl  // 0x0
  public    static  System.Xml.DtdParser.Token      ElementDecl  // 0x0
  public    static  System.Xml.DtdParser.Token      EntityDecl  // 0x0
  public    static  System.Xml.DtdParser.Token      NotationDecl  // 0x0
  public    static  System.Xml.DtdParser.Token      Comment  // 0x0
  public    static  System.Xml.DtdParser.Token      PI  // 0x0
  public    static  System.Xml.DtdParser.Token      CondSectionStart  // 0x0
  public    static  System.Xml.DtdParser.Token      CondSectionEnd  // 0x0
  public    static  System.Xml.DtdParser.Token      Eof  // 0x0
  public    static  System.Xml.DtdParser.Token      REQUIRED  // 0x0
  public    static  System.Xml.DtdParser.Token      IMPLIED  // 0x0
  public    static  System.Xml.DtdParser.Token      FIXED  // 0x0
  public    static  System.Xml.DtdParser.Token      QName  // 0x0
  public    static  System.Xml.DtdParser.Token      Name  // 0x0
  public    static  System.Xml.DtdParser.Token      Nmtoken  // 0x0
  public    static  System.Xml.DtdParser.Token      Quote  // 0x0
  public    static  System.Xml.DtdParser.Token      LeftParen  // 0x0
  public    static  System.Xml.DtdParser.Token      RightParen  // 0x0
  public    static  System.Xml.DtdParser.Token      GreaterThan  // 0x0
  public    static  System.Xml.DtdParser.Token      Or  // 0x0
  public    static  System.Xml.DtdParser.Token      LeftBracket  // 0x0
  public    static  System.Xml.DtdParser.Token      RightBracket  // 0x0
  public    static  System.Xml.DtdParser.Token      PUBLIC  // 0x0
  public    static  System.Xml.DtdParser.Token      SYSTEM  // 0x0
  public    static  System.Xml.DtdParser.Token      Literal  // 0x0
  public    static  System.Xml.DtdParser.Token      DOCTYPE  // 0x0
  public    static  System.Xml.DtdParser.Token      NData  // 0x0
  public    static  System.Xml.DtdParser.Token      Percent  // 0x0
  public    static  System.Xml.DtdParser.Token      Star  // 0x0
  public    static  System.Xml.DtdParser.Token      QMark  // 0x0
  public    static  System.Xml.DtdParser.Token      Plus  // 0x0
  public    static  System.Xml.DtdParser.Token      PCDATA  // 0x0
  public    static  System.Xml.DtdParser.Token      Comma  // 0x0
  public    static  System.Xml.DtdParser.Token      ANY  // 0x0
  public    static  System.Xml.DtdParser.Token      EMPTY  // 0x0
  public    static  System.Xml.DtdParser.Token      IGNORE  // 0x0
  public    static  System.Xml.DtdParser.Token      INCLUDE  // 0x0
METHODS:
END_CLASS

CLASS: ScanningFunction
TYPE:  struct
TOKEN: 0x20000C9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.DtdParser.ScanningFunctionSubsetContent  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionName  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionQName  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionNmtoken  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionDoctype1  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionDoctype2  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionElement1  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionElement2  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionElement3  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionElement4  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionElement5  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionElement6  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionElement7  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionAttlist1  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionAttlist2  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionAttlist3  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionAttlist4  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionAttlist5  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionAttlist6  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionAttlist7  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionEntity1  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionEntity2  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionEntity3  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionNotation1  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionCondSection1  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionCondSection2  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionCondSection3  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionLiteral  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionSystemId  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionPublicId1  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionPublicId2  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionClosingTag  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionParamEntitySpace  // 0x0
  public    static  System.Xml.DtdParser.ScanningFunctionNone  // 0x0
METHODS:
END_CLASS

CLASS: LiteralType
TYPE:  struct
TOKEN: 0x20000CA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.DtdParser.LiteralTypeAttributeValue  // 0x0
  public    static  System.Xml.DtdParser.LiteralTypeEntityReplText  // 0x0
  public    static  System.Xml.DtdParser.LiteralTypeSystemOrPublicID  // 0x0
METHODS:
END_CLASS

CLASS: UndeclaredNotation
TYPE:  class
TOKEN: 0x20000CB
FIELDS:
  private           System.String                   name  // 0x10
  private           System.Int32                    lineNo  // 0x18
  private           System.Int32                    linePos  // 0x1C
  private           System.Xml.DtdParser.UndeclaredNotationnext  // 0x20
METHODS:
  System.Void .ctor(System.String name, System.Int32 lineNo, System.Int32 linePos)
END_CLASS

CLASS: ParseElementOnlyContent_LocalFrame
TYPE:  class
TOKEN: 0x20000CC
FIELDS:
  public            System.Int32                    startParenEntityId  // 0x10
  public            System.Xml.DtdParser.Token      parsingSchema  // 0x14
METHODS:
  System.Void .ctor(System.Int32 startParentEntityIdParam)
END_CLASS

CLASS: NamespaceDeclaration
TYPE:  struct
TOKEN: 0x20000EA
FIELDS:
  public            System.String                   prefix  // 0x10
  public            System.String                   uri  // 0x18
  public            System.Int32                    scopeId  // 0x20
  public            System.Int32                    previousNsIndex  // 0x24
METHODS:
  System.Void Set(System.String prefix, System.String uri, System.Int32 scopeId, System.Int32 previousNsIndex)
END_CLASS

CLASS: HashCodeOfStringDelegate
TYPE:  class
TOKEN: 0x20000EE
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(System.String s, System.Int32 sLen, System.Int64 additionalEntropy)
END_CLASS

CLASS: Enumerator
TYPE:  class
TOKEN: 0x20000FE
FIELDS:
  private           System.Xml.XPath.XPathNodeIteratororiginal  // 0x10
  private           System.Xml.XPath.XPathNodeIteratorcurrent  // 0x18
  private           System.Boolean                  iterationStarted  // 0x20
METHODS:
  System.Void .ctor(System.Xml.XPath.XPathNodeIterator original)
  System.Object get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: WriteCallbackInfo
TYPE:  class
TOKEN: 0x2000135
FIELDS:
  public            System.Type                     Type  // 0x10
  public            System.String                   TypeName  // 0x18
  public            System.String                   TypeNs  // 0x20
  public            System.Xml.Serialization.XmlSerializationReadCallbackCallback  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CollectionFixup
TYPE:  class
TOKEN: 0x2000136
FIELDS:
  private           System.Xml.Serialization.XmlSerializationCollectionFixupCallbackcallback  // 0x10
  private           System.Object                   collection  // 0x18
  private           System.Object                   collectionItems  // 0x20
  private           System.String                   id  // 0x28
METHODS:
  System.Void .ctor(System.Object collection, System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback, System.String id)
  System.Xml.Serialization.XmlSerializationCollectionFixupCallback get_Callback()
  System.Object get_Collection()
  System.Object get_Id()
  System.Object get_CollectionItems()
  System.Void set_CollectionItems(System.Object value)
END_CLASS

CLASS: Fixup
TYPE:  class
TOKEN: 0x2000137
FIELDS:
  private           System.Object                   source  // 0x10
  private           System.String[]                 ids  // 0x18
  private           System.Xml.Serialization.XmlSerializationFixupCallbackcallback  // 0x20
METHODS:
  System.Void .ctor(System.Object o, System.Xml.Serialization.XmlSerializationFixupCallback callback, System.Int32 count)
  System.Xml.Serialization.XmlSerializationFixupCallback get_Callback()
  System.String[] get_Ids()
  System.Object get_Source()
END_CLASS

CLASS: CollectionItemFixup
TYPE:  class
TOKEN: 0x2000138
FIELDS:
  private           System.Array                    list  // 0x10
  private           System.Int32                    index  // 0x18
  private           System.String                   id  // 0x20
METHODS:
  System.Void .ctor(System.Array list, System.Int32 index, System.String id)
  System.Array get_Collection()
  System.Int32 get_Index()
  System.String get_Id()
END_CLASS

CLASS: FixupCallbackInfo
TYPE:  class
TOKEN: 0x200013A
FIELDS:
  private           System.Xml.Serialization.XmlSerializationReaderInterpreter_sri  // 0x10
  private           System.Xml.Serialization.ClassMap_map  // 0x18
  private           System.Boolean                  _isValueList  // 0x20
METHODS:
  System.Void .ctor(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.ClassMap map, System.Boolean isValueList)
  System.Void FixupMembers(System.Object fixup)
END_CLASS

CLASS: ReaderCallbackInfo
TYPE:  class
TOKEN: 0x200013B
FIELDS:
  private           System.Xml.Serialization.XmlSerializationReaderInterpreter_sri  // 0x10
  private           System.Xml.Serialization.XmlTypeMapping_typeMap  // 0x18
METHODS:
  System.Void .ctor(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.XmlTypeMapping typeMap)
  System.Object ReadObject()
END_CLASS

CLASS: WriteCallbackInfo
TYPE:  class
TOKEN: 0x200013E
FIELDS:
  public            System.Type                     Type  // 0x10
  public            System.String                   TypeName  // 0x18
  public            System.String                   TypeNs  // 0x20
  public            System.Xml.Serialization.XmlSerializationWriteCallbackCallback  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CallbackInfo
TYPE:  class
TOKEN: 0x2000140
FIELDS:
  private           System.Xml.Serialization.XmlSerializationWriterInterpreter_swi  // 0x10
  private           System.Xml.Serialization.XmlTypeMapping_typeMap  // 0x18
METHODS:
  System.Void .ctor(System.Xml.Serialization.XmlSerializationWriterInterpreter swi, System.Xml.Serialization.XmlTypeMapping typeMap)
  System.Void WriteObject(System.Object ob)
  System.Void WriteEnum(System.Object ob)
END_CLASS

CLASS: SerializerData
TYPE:  class
TOKEN: 0x2000142
FIELDS:
  public            System.Reflection.MethodInfo    ReaderMethod  // 0x10
  public            System.Type                     WriterType  // 0x18
  public            System.Reflection.MethodInfo    WriterMethod  // 0x20
  public            System.Xml.Serialization.XmlSerializerImplementationImplementation  // 0x28
METHODS:
  System.Xml.Serialization.XmlSerializationWriter CreateWriter()
END_CLASS

CLASS: EnumMapMember
TYPE:  class
TOKEN: 0x2000157
FIELDS:
  private   readonly System.String                   _xmlName  // 0x10
  private   readonly System.String                   _enumName  // 0x18
  private   readonly System.Int64                    _value  // 0x20
METHODS:
  System.Void .ctor(System.String xmlName, System.String enumName, System.Int64 value)
  System.String get_XmlName()
  System.String get_EnumName()
  System.Int64 get_Value()
END_CLASS

CLASS: ConstraintRole
TYPE:  struct
TOKEN: 0x2000169
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.CompiledIdentityConstraint.ConstraintRoleUnique  // 0x0
  public    static  System.Xml.Schema.CompiledIdentityConstraint.ConstraintRoleKey  // 0x0
  public    static  System.Xml.Schema.CompiledIdentityConstraint.ConstraintRoleKeyref  // 0x0
METHODS:
END_CLASS

CLASS: DecimalStruct
TYPE:  class
TOKEN: 0x200016F
FIELDS:
  private           System.Boolean                  isDecimal  // 0x10
  private           System.Decimal[]                dvalue  // 0x18
METHODS:
  System.Boolean get_IsDecimal()
  System.Void set_IsDecimal(System.Boolean value)
  System.Decimal[] get_Dvalue()
  System.Void .ctor()
  System.Void .ctor(System.Int32 dim)
END_CLASS

CLASS: SequenceConstructPosContext
TYPE:  struct
TOKEN: 0x200017A
FIELDS:
  public            System.Xml.Schema.SequenceNode  this_  // 0x10
  public            System.Xml.Schema.BitSet        firstpos  // 0x18
  public            System.Xml.Schema.BitSet        lastpos  // 0x20
  public            System.Xml.Schema.BitSet        lastposLeft  // 0x28
  public            System.Xml.Schema.BitSet        firstposRight  // 0x30
METHODS:
  System.Void .ctor(System.Xml.Schema.SequenceNode node, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos)
END_CLASS

CLASS: SchemaDatatypeMap
TYPE:  class
TOKEN: 0x200018D
FIELDS:
  private           System.String                   name  // 0x10
  private           System.Xml.Schema.DatatypeImplementationtype  // 0x18
  private           System.Int32                    parentIndex  // 0x20
METHODS:
  System.Void .ctor(System.String name, System.Xml.Schema.DatatypeImplementation type)
  System.Void .ctor(System.String name, System.Xml.Schema.DatatypeImplementation type, System.Int32 parentIndex)
  System.Xml.Schema.DatatypeImplementation op_Explicit(System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap sdm)
  System.String get_Name()
  System.Int32 get_ParentIndex()
  System.Int32 CompareTo(System.Object obj)
END_CLASS

CLASS: NamespaceManager
TYPE:  class
TOKEN: 0x20001CD
EXTENDS: XmlNamespaceManager
FIELDS:
METHODS:
  System.String LookupNamespace(System.String prefix)
  System.Void .ctor()
END_CLASS

CLASS: Map
TYPE:  struct
TOKEN: 0x20001D0
FIELDS:
  private           System.Char                     match  // 0x10
  private           System.String                   replacement  // 0x18
METHODS:
  System.Void .ctor(System.Char m, System.String r)
END_CLASS

CLASS: FacetsCompiler
TYPE:  struct
TOKEN: 0x20001CF
FIELDS:
  private           System.Xml.Schema.DatatypeImplementationdatatype  // 0x10
  private           System.Xml.Schema.RestrictionFacetsderivedRestriction  // 0x18
  private           System.Xml.Schema.RestrictionFlagsbaseFlags  // 0x20
  private           System.Xml.Schema.RestrictionFlagsbaseFixedFlags  // 0x24
  private           System.Xml.Schema.RestrictionFlagsvalidRestrictionFlags  // 0x28
  private           System.Xml.Schema.XmlSchemaDatatypenonNegativeInt  // 0x30
  private           System.Xml.Schema.XmlSchemaDatatypebuiltInType  // 0x38
  private           System.Xml.Schema.XmlTypeCode   builtInEnum  // 0x40
  private           System.Boolean                  firstPattern  // 0x44
  private           System.Text.StringBuilder       regStr  // 0x48
  private           System.Xml.Schema.XmlSchemaPatternFacetpattern_facet  // 0x50
  private   static readonly System.Xml.Schema.FacetsChecker.FacetsCompiler.Map[]c_map  // 0x0
METHODS:
  System.Void .ctor(System.Xml.Schema.DatatypeImplementation baseDatatype, System.Xml.Schema.RestrictionFacets restriction)
  System.Void CompileLengthFacet(System.Xml.Schema.XmlSchemaFacet facet)
  System.Void CompileMinLengthFacet(System.Xml.Schema.XmlSchemaFacet facet)
  System.Void CompileMaxLengthFacet(System.Xml.Schema.XmlSchemaFacet facet)
  System.Void CompilePatternFacet(System.Xml.Schema.XmlSchemaPatternFacet facet)
  System.Void CompileEnumerationFacet(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable)
  System.Void CompileWhitespaceFacet(System.Xml.Schema.XmlSchemaFacet facet)
  System.Void CompileMaxInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet)
  System.Void CompileMaxExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet)
  System.Void CompileMinInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet)
  System.Void CompileMinExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet)
  System.Void CompileTotalDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet)
  System.Void CompileFractionDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet)
  System.Void FinishFacetCompile()
  System.Void CheckValue(System.Object value, System.Xml.Schema.XmlSchemaFacet facet)
  System.Void CompileFacetCombinations()
  System.Void CopyFacetsFromBaseType()
  System.Object ParseFacetValue(System.Xml.Schema.XmlSchemaDatatype datatype, System.Xml.Schema.XmlSchemaFacet facet, System.String code, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable)
  System.String Preprocess(System.String pattern)
  System.Void CheckProhibitedFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, System.String errorCode)
  System.Void CheckDupFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, System.String errorCode)
  System.Void SetFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag)
  System.Void SetFlag(System.Xml.Schema.RestrictionFlags flag)
  System.Void .cctor()
END_CLASS

CLASS: InferenceOption
TYPE:  struct
TOKEN: 0x20001DD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaInference.InferenceOptionRestricted  // 0x0
  public    static  System.Xml.Schema.XmlSchemaInference.InferenceOptionRelaxed  // 0x0
METHODS:
END_CLASS

CLASS: ListType
TYPE:  struct
TOKEN: 0x20001E0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.NamespaceList.ListTypeAny  // 0x0
  public    static  System.Xml.Schema.NamespaceList.ListTypeOther  // 0x0
  public    static  System.Xml.Schema.NamespaceList.ListTypeSet  // 0x0
METHODS:
END_CLASS

CLASS: Reserve
TYPE:  struct
TOKEN: 0x20001E7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.SchemaAttDef.ReserveNone  // 0x0
  public    static  System.Xml.Schema.SchemaAttDef.ReserveXmlSpace  // 0x0
  public    static  System.Xml.Schema.SchemaAttDef.ReserveXmlLang  // 0x0
METHODS:
END_CLASS

CLASS: Compositor
TYPE:  struct
TOKEN: 0x20001EB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.SchemaCollectionPreprocessor.CompositorRoot  // 0x0
  public    static  System.Xml.Schema.SchemaCollectionPreprocessor.CompositorInclude  // 0x0
  public    static  System.Xml.Schema.SchemaCollectionPreprocessor.CompositorImport  // 0x0
METHODS:
END_CLASS

CLASS: Use
TYPE:  struct
TOKEN: 0x20001ED
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.SchemaDeclBase.UseDefault  // 0x0
  public    static  System.Xml.Schema.SchemaDeclBase.UseRequired  // 0x0
  public    static  System.Xml.Schema.SchemaDeclBase.UseImplied  // 0x0
  public    static  System.Xml.Schema.SchemaDeclBase.UseFixed  // 0x0
  public    static  System.Xml.Schema.SchemaDeclBase.UseRequiredFixed  // 0x0
METHODS:
END_CLASS

CLASS: Token
TYPE:  struct
TOKEN: 0x20001F3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.SchemaNames.TokenEmpty  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaName  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaType  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaMaxOccurs  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaMinOccurs  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaInfinite  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaModel  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaOpen  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaClosed  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaContent  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaMixed  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaEmpty  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaElementOnly  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaTextOnly  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaOrder  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaSeq  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaOne  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaMany  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaRequired  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaYes  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaNo  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaString  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaId  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaIdref  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaIdrefs  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaEntity  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaEntities  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaNmtoken  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaNmtokens  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaEnumeration  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaDefault  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXdrRoot  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXdrElementType  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXdrElement  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXdrGroup  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXdrAttributeType  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXdrAttribute  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXdrDatatype  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXdrDescription  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXdrExtends  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaXdrRootAlias  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaDtType  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaDtValues  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaDtMaxLength  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaDtMinLength  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaDtMax  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaDtMin  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaDtMinExclusive  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaDtMaxExclusive  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaTargetNamespace  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaVersion  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaFinalDefault  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaBlockDefault  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaFixed  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaAbstract  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaBlock  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaSubstitutionGroup  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaFinal  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaNillable  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaRef  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaBase  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaDerivedBy  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaNamespace  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaProcessContents  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaRefer  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaPublic  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaSystem  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaSchemaLocation  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaValue  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaSource  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaAttributeFormDefault  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaElementFormDefault  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaUse  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaForm  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdSchema  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdAnnotation  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdInclude  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdImport  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdElement  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdAttribute  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenxsdAttributeGroup  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdAnyAttribute  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdGroup  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdAll  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdChoice  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdSequence  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdAny  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdNotation  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdSimpleType  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdComplexType  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdUnique  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdKey  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdKeyref  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdSelector  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdField  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdMinExclusive  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdMinInclusive  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdMaxExclusive  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdMaxInclusive  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdTotalDigits  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdFractionDigits  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdLength  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdMinLength  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdMaxLength  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdEnumeration  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdPattern  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdDocumentation  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdAppInfo  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdComplexContent  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdComplexContentExtension  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdComplexContentRestriction  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdSimpleContent  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdSimpleContentExtension  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdSimpleContentRestriction  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdSimpleTypeList  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdSimpleTypeRestriction  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdSimpleTypeUnion  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdWhitespace  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXsdRedefine  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaItemType  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaMemberTypes  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenSchemaXPath  // 0x0
  public    static  System.Xml.Schema.SchemaNames.TokenXmlLang  // 0x0
METHODS:
END_CLASS

CLASS: DeclBaseInfo
TYPE:  class
TOKEN: 0x20001FD
FIELDS:
  private           System.Xml.XmlQualifiedName     _Name  // 0x10
  private           System.String                   _Prefix  // 0x18
  private           System.Xml.XmlQualifiedName     _TypeName  // 0x20
  private           System.String                   _TypePrefix  // 0x28
  private           System.Object                   _Default  // 0x30
  private           System.Object                   _Revises  // 0x38
  private           System.UInt32                   _MaxOccurs  // 0x40
  private           System.UInt32                   _MinOccurs  // 0x44
  private           System.Boolean                  _Checking  // 0x48
  private           System.Xml.Schema.SchemaElementDecl_ElementDecl  // 0x50
  private           System.Xml.Schema.SchemaAttDef  _Attdef  // 0x58
  private           System.Xml.Schema.XdrBuilder.DeclBaseInfo_Next  // 0x60
METHODS:
  System.Void .ctor()
  System.Void Reset()
END_CLASS

CLASS: GroupContent
TYPE:  class
TOKEN: 0x20001FE
FIELDS:
  private           System.UInt32                   _MinVal  // 0x10
  private           System.UInt32                   _MaxVal  // 0x14
  private           System.Boolean                  _HasMaxAttr  // 0x18
  private           System.Boolean                  _HasMinAttr  // 0x19
  private           System.Int32                    _Order  // 0x1C
METHODS:
  System.Void Copy(System.Xml.Schema.XdrBuilder.GroupContent from, System.Xml.Schema.XdrBuilder.GroupContent to)
  System.Xml.Schema.XdrBuilder.GroupContent Copy(System.Xml.Schema.XdrBuilder.GroupContent other)
  System.Void .ctor()
END_CLASS

CLASS: ElementContent
TYPE:  class
TOKEN: 0x20001FF
FIELDS:
  private           System.Xml.Schema.SchemaElementDecl_ElementDecl  // 0x10
  private           System.Int32                    _ContentAttr  // 0x18
  private           System.Int32                    _OrderAttr  // 0x1C
  private           System.Boolean                  _MasterGroupRequired  // 0x20
  private           System.Boolean                  _ExistTerminal  // 0x21
  private           System.Boolean                  _AllowDataType  // 0x22
  private           System.Boolean                  _HasDataType  // 0x23
  private           System.Boolean                  _HasType  // 0x24
  private           System.Boolean                  _EnumerationRequired  // 0x25
  private           System.UInt32                   _MinVal  // 0x28
  private           System.UInt32                   _MaxVal  // 0x2C
  private           System.UInt32                   _MaxLength  // 0x30
  private           System.UInt32                   _MinLength  // 0x34
  private           System.Collections.Hashtable    _AttDefList  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: AttributeContent
TYPE:  class
TOKEN: 0x2000200
FIELDS:
  private           System.Xml.Schema.SchemaAttDef  _AttDef  // 0x10
  private           System.Xml.XmlQualifiedName     _Name  // 0x18
  private           System.String                   _Prefix  // 0x20
  private           System.Boolean                  _Required  // 0x28
  private           System.UInt32                   _MinVal  // 0x2C
  private           System.UInt32                   _MaxVal  // 0x30
  private           System.UInt32                   _MaxLength  // 0x34
  private           System.UInt32                   _MinLength  // 0x38
  private           System.Boolean                  _EnumerationRequired  // 0x3C
  private           System.Boolean                  _HasDataType  // 0x3D
  private           System.Boolean                  _Global  // 0x3E
  private           System.Object                   _Default  // 0x40
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: XdrBuildFunction
TYPE:  class
TOKEN: 0x2000201
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
END_CLASS

CLASS: XdrInitFunction
TYPE:  class
TOKEN: 0x2000202
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Xml.Schema.XdrBuilder builder, System.Object obj)
END_CLASS

CLASS: XdrBeginChildFunction
TYPE:  class
TOKEN: 0x2000203
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Xml.Schema.XdrBuilder builder)
END_CLASS

CLASS: XdrEndChildFunction
TYPE:  class
TOKEN: 0x2000204
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Xml.Schema.XdrBuilder builder)
END_CLASS

CLASS: XdrAttributeEntry
TYPE:  class
TOKEN: 0x2000205
FIELDS:
  private           System.Xml.Schema.SchemaNames.Token_Attribute  // 0x10
  private           System.Int32                    _SchemaFlags  // 0x14
  private           System.Xml.Schema.XmlSchemaDatatype_Datatype  // 0x18
  private           System.Xml.Schema.XdrBuilder.XdrBuildFunction_BuildFunc  // 0x20
METHODS:
  System.Void .ctor(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, System.Xml.Schema.XdrBuilder.XdrBuildFunction build)
  System.Void .ctor(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, System.Int32 schemaFlags, System.Xml.Schema.XdrBuilder.XdrBuildFunction build)
END_CLASS

CLASS: XdrEntry
TYPE:  class
TOKEN: 0x2000206
FIELDS:
  private           System.Xml.Schema.SchemaNames.Token_Name  // 0x10
  private           System.Int32[]                  _NextStates  // 0x18
  private           System.Xml.Schema.XdrBuilder.XdrAttributeEntry[]_Attributes  // 0x20
  private           System.Xml.Schema.XdrBuilder.XdrInitFunction_InitFunc  // 0x28
  private           System.Xml.Schema.XdrBuilder.XdrBeginChildFunction_BeginChildFunc  // 0x30
  private           System.Xml.Schema.XdrBuilder.XdrEndChildFunction_EndChildFunc  // 0x38
  private           System.Boolean                  _AllowText  // 0x40
METHODS:
  System.Void .ctor(System.Xml.Schema.SchemaNames.Token n, System.Int32[] states, System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] attributes, System.Xml.Schema.XdrBuilder.XdrInitFunction init, System.Xml.Schema.XdrBuilder.XdrBeginChildFunction begin, System.Xml.Schema.XdrBuilder.XdrEndChildFunction end, System.Boolean fText)
END_CLASS

CLASS: Union
TYPE:  struct
TOKEN: 0x2000209
FIELDS:
  public            System.Boolean                  boolVal  // 0x10
  public            System.Double                   dblVal  // 0x10
  public            System.Int64                    i64Val  // 0x10
  public            System.Int32                    i32Val  // 0x10
  public            System.DateTime                 dtVal  // 0x10
METHODS:
END_CLASS

CLASS: NamespacePrefixForQName
TYPE:  class
TOKEN: 0x200020A
FIELDS:
  public            System.String                   prefix  // 0x10
  public            System.String                   ns  // 0x18
METHODS:
  System.Void .ctor(System.String prefix, System.String ns)
  System.String LookupNamespace(System.String prefix)
  System.String LookupPrefix(System.String namespaceName)
  System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
END_CLASS

CLASS: EnumeratorType
TYPE:  struct
TOKEN: 0x2000248
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaObjectTable.EnumeratorTypeKeys  // 0x0
  public    static  System.Xml.Schema.XmlSchemaObjectTable.EnumeratorTypeValues  // 0x0
  public    static  System.Xml.Schema.XmlSchemaObjectTable.EnumeratorTypeDictionaryEntry  // 0x0
METHODS:
END_CLASS

CLASS: XmlSchemaObjectEntry
TYPE:  struct
TOKEN: 0x2000249
FIELDS:
  private           System.Xml.XmlQualifiedName     qname  // 0x10
  private           System.Xml.Schema.XmlSchemaObjectxso  // 0x18
METHODS:
  System.Void .ctor(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value)
END_CLASS

CLASS: ValuesCollection
TYPE:  class
TOKEN: 0x200024A
FIELDS:
  private           System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry>entries  // 0x10
  private           System.Int32                    size  // 0x18
METHODS:
  System.Void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, System.Int32 size)
  System.Int32 get_Count()
  System.Object get_SyncRoot()
  System.Boolean get_IsSynchronized()
  System.Void CopyTo(System.Array array, System.Int32 arrayIndex)
  System.Collections.IEnumerator GetEnumerator()
END_CLASS

CLASS: XSOEnumerator
TYPE:  class
TOKEN: 0x200024B
FIELDS:
  private           System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry>entries  // 0x10
  private           System.Xml.Schema.XmlSchemaObjectTable.EnumeratorTypeenumType  // 0x18
  protected         System.Int32                    currentIndex  // 0x1C
  protected         System.Int32                    size  // 0x20
  protected         System.Xml.XmlQualifiedName     currentKey  // 0x28
  protected         System.Xml.Schema.XmlSchemaObjectcurrentValue  // 0x30
METHODS:
  System.Void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, System.Int32 size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType)
  System.Object get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: XSODictionaryEnumerator
TYPE:  class
TOKEN: 0x200024C
EXTENDS: XSOEnumerator
FIELDS:
METHODS:
  System.Void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, System.Int32 size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType)
  System.Collections.DictionaryEntry get_Entry()
  System.Object get_Key()
  System.Object get_Value()
END_CLASS

CLASS: Occurs
TYPE:  struct
TOKEN: 0x200024E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaParticle.OccursNone  // 0x0
  public    static  System.Xml.Schema.XmlSchemaParticle.OccursMin  // 0x0
  public    static  System.Xml.Schema.XmlSchemaParticle.OccursMax  // 0x0
METHODS:
END_CLASS

CLASS: EmptyParticle
TYPE:  class
TOKEN: 0x200024F
EXTENDS: XmlSchemaParticle
FIELDS:
METHODS:
  System.Boolean get_IsEmpty()
  System.Void .ctor()
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x2000276
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XsdBuilder.StateRoot  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateSchema  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateAnnotation  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateInclude  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateImport  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateElement  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateAttribute  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateAttributeGroup  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateAttributeGroupRef  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateAnyAttribute  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateGroup  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateGroupRef  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateAll  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateChoice  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateSequence  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateAny  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateNotation  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateSimpleType  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateComplexType  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateComplexContent  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateComplexContentRestriction  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateComplexContentExtension  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateSimpleContent  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateSimpleContentExtension  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateSimpleContentRestriction  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateSimpleTypeUnion  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateSimpleTypeList  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateSimpleTypeRestriction  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateUnique  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateKey  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateKeyRef  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateSelector  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateField  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateMinExclusive  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateMinInclusive  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateMaxExclusive  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateMaxInclusive  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateTotalDigits  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateFractionDigits  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateLength  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateMinLength  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateMaxLength  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateEnumeration  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StatePattern  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateWhiteSpace  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateAppInfo  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateDocumentation  // 0x0
  public    static  System.Xml.Schema.XsdBuilder.StateRedefine  // 0x0
METHODS:
END_CLASS

CLASS: XsdBuildFunction
TYPE:  class
TOKEN: 0x2000277
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Xml.Schema.XsdBuilder builder, System.String value)
END_CLASS

CLASS: XsdInitFunction
TYPE:  class
TOKEN: 0x2000278
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Xml.Schema.XsdBuilder builder, System.String value)
END_CLASS

CLASS: XsdEndChildFunction
TYPE:  class
TOKEN: 0x2000279
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Xml.Schema.XsdBuilder builder)
END_CLASS

CLASS: XsdAttributeEntry
TYPE:  class
TOKEN: 0x200027A
FIELDS:
  public            System.Xml.Schema.SchemaNames.TokenAttribute  // 0x10
  public            System.Xml.Schema.XsdBuilder.XsdBuildFunctionBuildFunc  // 0x18
METHODS:
  System.Void .ctor(System.Xml.Schema.SchemaNames.Token a, System.Xml.Schema.XsdBuilder.XsdBuildFunction build)
END_CLASS

CLASS: XsdEntry
TYPE:  class
TOKEN: 0x200027B
FIELDS:
  public            System.Xml.Schema.SchemaNames.TokenName  // 0x10
  public            System.Xml.Schema.XsdBuilder.StateCurrentState  // 0x14
  public            System.Xml.Schema.XsdBuilder.State[]NextStates  // 0x18
  public            System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]Attributes  // 0x20
  public            System.Xml.Schema.XsdBuilder.XsdInitFunctionInitFunc  // 0x28
  public            System.Xml.Schema.XsdBuilder.XsdEndChildFunctionEndChildFunc  // 0x30
  public            System.Boolean                  ParseContent  // 0x38
METHODS:
  System.Void .ctor(System.Xml.Schema.SchemaNames.Token n, System.Xml.Schema.XsdBuilder.State state, System.Xml.Schema.XsdBuilder.State[] nextStates, System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] attributes, System.Xml.Schema.XsdBuilder.XsdInitFunction init, System.Xml.Schema.XsdBuilder.XsdEndChildFunction end, System.Boolean parseContent)
END_CLASS

CLASS: BuilderNamespaceManager
TYPE:  class
TOKEN: 0x200027C
EXTENDS: XmlNamespaceManager
FIELDS:
  private           System.Xml.XmlNamespaceManager  nsMgr  // 0x50
  private           System.Xml.XmlReader            reader  // 0x58
METHODS:
  System.Void .ctor(System.Xml.XmlNamespaceManager nsMgr, System.Xml.XmlReader reader)
  System.String LookupNamespace(System.String prefix)
END_CLASS

CLASS: DateTimeTypeCode
TYPE:  struct
TOKEN: 0x200027F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XsdDateTime.DateTimeTypeCodeDateTime  // 0x0
  public    static  System.Xml.Schema.XsdDateTime.DateTimeTypeCodeTime  // 0x0
  public    static  System.Xml.Schema.XsdDateTime.DateTimeTypeCodeDate  // 0x0
  public    static  System.Xml.Schema.XsdDateTime.DateTimeTypeCodeGYearMonth  // 0x0
  public    static  System.Xml.Schema.XsdDateTime.DateTimeTypeCodeGYear  // 0x0
  public    static  System.Xml.Schema.XsdDateTime.DateTimeTypeCodeGMonthDay  // 0x0
  public    static  System.Xml.Schema.XsdDateTime.DateTimeTypeCodeGDay  // 0x0
  public    static  System.Xml.Schema.XsdDateTime.DateTimeTypeCodeGMonth  // 0x0
  public    static  System.Xml.Schema.XsdDateTime.DateTimeTypeCodeXdrDateTime  // 0x0
METHODS:
END_CLASS

CLASS: XsdDateTimeKind
TYPE:  struct
TOKEN: 0x2000280
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XsdDateTime.XsdDateTimeKindUnspecified  // 0x0
  public    static  System.Xml.Schema.XsdDateTime.XsdDateTimeKindZulu  // 0x0
  public    static  System.Xml.Schema.XsdDateTime.XsdDateTimeKindLocalWestOfZulu  // 0x0
  public    static  System.Xml.Schema.XsdDateTime.XsdDateTimeKindLocalEastOfZulu  // 0x0
METHODS:
END_CLASS

CLASS: Parser
TYPE:  struct
TOKEN: 0x2000281
FIELDS:
  public            System.Xml.Schema.XsdDateTime.DateTimeTypeCodetypeCode  // 0x10
  public            System.Int32                    year  // 0x14
  public            System.Int32                    month  // 0x18
  public            System.Int32                    day  // 0x1C
  public            System.Int32                    hour  // 0x20
  public            System.Int32                    minute  // 0x24
  public            System.Int32                    second  // 0x28
  public            System.Int32                    fraction  // 0x2C
  public            System.Xml.Schema.XsdDateTime.XsdDateTimeKindkind  // 0x30
  public            System.Int32                    zoneHour  // 0x34
  public            System.Int32                    zoneMinute  // 0x38
  private           System.String                   text  // 0x40
  private           System.Int32                    length  // 0x48
  private   static  System.Int32[]                  Power10  // 0x0
METHODS:
  System.Boolean Parse(System.String text, System.Xml.Schema.XsdDateTimeFlags kinds)
  System.Boolean ParseDate(System.Int32 start)
  System.Boolean ParseTimeAndZoneAndWhitespace(System.Int32 start)
  System.Boolean ParseTimeAndWhitespace(System.Int32 start)
  System.Boolean ParseTime(System.Int32& start)
  System.Boolean ParseZoneAndWhitespace(System.Int32 start)
  System.Boolean Parse4Dig(System.Int32 start, System.Int32& num)
  System.Boolean Parse2Dig(System.Int32 start, System.Int32& num)
  System.Boolean ParseChar(System.Int32 start, System.Char ch)
  System.Boolean Test(System.Xml.Schema.XsdDateTimeFlags left, System.Xml.Schema.XsdDateTimeFlags right)
  System.Void .cctor()
END_CLASS

CLASS: Parts
TYPE:  struct
TOKEN: 0x2000283
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XsdDuration.PartsHasNone  // 0x0
  public    static  System.Xml.Schema.XsdDuration.PartsHasYears  // 0x0
  public    static  System.Xml.Schema.XsdDuration.PartsHasMonths  // 0x0
  public    static  System.Xml.Schema.XsdDuration.PartsHasDays  // 0x0
  public    static  System.Xml.Schema.XsdDuration.PartsHasHours  // 0x0
  public    static  System.Xml.Schema.XsdDuration.PartsHasMinutes  // 0x0
  public    static  System.Xml.Schema.XsdDuration.PartsHasSeconds  // 0x0
METHODS:
END_CLASS

CLASS: DurationType
TYPE:  struct
TOKEN: 0x2000284
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XsdDuration.DurationTypeDuration  // 0x0
  public    static  System.Xml.Schema.XsdDuration.DurationTypeYearMonthDuration  // 0x0
  public    static  System.Xml.Schema.XsdDuration.DurationTypeDayTimeDuration  // 0x0
METHODS:
END_CLASS

CLASS: AstType
TYPE:  struct
TOKEN: 0x2000288
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MS.Internal.Xml.XPath.AstNode.AstTypeAxis  // 0x0
  public    static  MS.Internal.Xml.XPath.AstNode.AstTypeOperator  // 0x0
  public    static  MS.Internal.Xml.XPath.AstNode.AstTypeFilter  // 0x0
  public    static  MS.Internal.Xml.XPath.AstNode.AstTypeConstantOperand  // 0x0
  public    static  MS.Internal.Xml.XPath.AstNode.AstTypeFunction  // 0x0
  public    static  MS.Internal.Xml.XPath.AstNode.AstTypeGroup  // 0x0
  public    static  MS.Internal.Xml.XPath.AstNode.AstTypeRoot  // 0x0
  public    static  MS.Internal.Xml.XPath.AstNode.AstTypeVariable  // 0x0
  public    static  MS.Internal.Xml.XPath.AstNode.AstTypeError  // 0x0
METHODS:
END_CLASS

CLASS: AxisType
TYPE:  struct
TOKEN: 0x200028B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeAncestor  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeAncestorOrSelf  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeAttribute  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeChild  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeDescendant  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeDescendantOrSelf  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeFollowing  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeFollowingSibling  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeNamespace  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeParent  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypePreceding  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypePrecedingSibling  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeSelf  // 0x0
  public    static  MS.Internal.Xml.XPath.Axis.AxisTypeNone  // 0x0
METHODS:
END_CLASS

CLASS: UndefinedXsltContext
TYPE:  class
TOKEN: 0x2000295
EXTENDS: XsltContext
FIELDS:
  private           System.Xml.IXmlNamespaceResolver_nsResolver  // 0x50
METHODS:
  System.Void .ctor(System.Xml.IXmlNamespaceResolver nsResolver)
  System.String get_DefaultNamespace()
  System.String LookupNamespace(System.String prefix)
  System.Xml.Xsl.IXsltContextVariable ResolveVariable(System.String prefix, System.String name)
  System.Xml.Xsl.IXsltContextFunction ResolveFunction(System.String prefix, System.String name, System.Xml.XPath.XPathResultType[] ArgTypes)
  System.Boolean get_Whitespace()
  System.Boolean PreserveWhitespace(System.Xml.XPath.XPathNavigator node)
END_CLASS

CLASS: FunctionType
TYPE:  struct
TOKEN: 0x20002A3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncLast  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncPosition  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncCount  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncID  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncLocalName  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncNameSpaceUri  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncName  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncString  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncBoolean  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncNumber  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncTrue  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncFalse  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncNot  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncConcat  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncStartsWith  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncContains  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncSubstringBefore  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncSubstringAfter  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncSubstring  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncStringLength  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncNormalize  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncTranslate  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncLang  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncSum  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncFloor  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncCeiling  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncRound  // 0x0
  public    static  MS.Internal.Xml.XPath.Function.FunctionTypeFuncUserDefined  // 0x0
METHODS:
END_CLASS

CLASS: cmpXslt
TYPE:  class
TOKEN: 0x20002AA
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
END_CLASS

CLASS: NodeSet
TYPE:  struct
TOKEN: 0x20002AB
FIELDS:
  private           MS.Internal.Xml.XPath.Query     _opnd  // 0x10
  private           System.Xml.XPath.XPathNavigator _current  // 0x18
METHODS:
  System.Void .ctor(System.Object opnd)
  System.Boolean MoveNext()
  System.Void Reset()
  System.String get_Value()
END_CLASS

CLASS: Op
TYPE:  struct
TOKEN: 0x20002B4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MS.Internal.Xml.XPath.Operator.OpINVALID  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpOR  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpAND  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpEQ  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpNE  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpLT  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpLE  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpGT  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpGE  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpPLUS  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpMINUS  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpMUL  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpDIV  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpMOD  // 0x0
  public    static  MS.Internal.Xml.XPath.Operator.OpUNION  // 0x0
METHODS:
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x20002BB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MS.Internal.Xml.XPath.QueryBuilder.FlagsNone  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryBuilder.FlagsSmartDesc  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryBuilder.FlagsPosFilter  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryBuilder.FlagsFilter  // 0x0
METHODS:
END_CLASS

CLASS: Props
TYPE:  struct
TOKEN: 0x20002BC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MS.Internal.Xml.XPath.QueryBuilder.PropsNone  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryBuilder.PropsPosFilter  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryBuilder.PropsHasPosition  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryBuilder.PropsHasLast  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryBuilder.PropsNonFlat  // 0x0
METHODS:
END_CLASS

CLASS: ParamInfo
TYPE:  class
TOKEN: 0x20002CC
FIELDS:
  private           MS.Internal.Xml.XPath.Function.FunctionType_ftype  // 0x10
  private           System.Int32                    _minargs  // 0x14
  private           System.Int32                    _maxargs  // 0x18
  private           System.Xml.XPath.XPathResultType[]_argTypes  // 0x20
METHODS:
  MS.Internal.Xml.XPath.Function.FunctionType get_FType()
  System.Int32 get_Minargs()
  System.Int32 get_Maxargs()
  System.Xml.XPath.XPathResultType[] get_ArgTypes()
  System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType ftype, System.Int32 minargs, System.Int32 maxargs, System.Xml.XPath.XPathResultType[] argTypes)
END_CLASS

CLASS: LexKind
TYPE:  struct
TOKEN: 0x20002CE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindComma  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindSlash  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindAt  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindDot  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindLParens  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindRParens  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindLBracket  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindRBracket  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindStar  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindPlus  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindMinus  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindEq  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindLt  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindGt  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindBang  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindDollar  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindApos  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindQuote  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindUnion  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindNe  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindLe  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindGe  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindAnd  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindOr  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindDotDot  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindSlashSlash  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindName  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindString  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindNumber  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindAxe  // 0x0
  public    static  MS.Internal.Xml.XPath.XPathScanner.LexKindEof  // 0x0
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=6
TYPE:  struct
TOKEN: 0x20002DE
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=12
TYPE:  struct
TOKEN: 0x20002DF
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=16
TYPE:  struct
TOKEN: 0x20002E0
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=20
TYPE:  struct
TOKEN: 0x20002E1
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=24
TYPE:  struct
TOKEN: 0x20002E2
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=28
TYPE:  struct
TOKEN: 0x20002E3
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=32
TYPE:  struct
TOKEN: 0x20002E4
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=36
TYPE:  struct
TOKEN: 0x20002E5
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=38
TYPE:  struct
TOKEN: 0x20002E6
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=40
TYPE:  struct
TOKEN: 0x20002E7
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=44
TYPE:  struct
TOKEN: 0x20002E8
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=56
TYPE:  struct
TOKEN: 0x20002E9
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=64
TYPE:  struct
TOKEN: 0x20002EA
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=68
TYPE:  struct
TOKEN: 0x20002EB
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=112
TYPE:  struct
TOKEN: 0x20002EC
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=144
TYPE:  struct
TOKEN: 0x20002ED
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=416
TYPE:  struct
TOKEN: 0x20002EE
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=664
TYPE:  struct
TOKEN: 0x20002EF
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=960
TYPE:  struct
TOKEN: 0x20002F0
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=1212
TYPE:  struct
TOKEN: 0x20002F1
FIELDS:
METHODS:
END_CLASS

CLASS: MS.Internal.Xml.Cache.XPathDocumentBaseIterator
TYPE:  class
TOKEN: 0x20002D2
EXTENDS: XPathNodeIterator
FIELDS:
  protected         MS.Internal.Xml.Cache.XPathDocumentNavigatorctxt  // 0x18
  protected         System.Int32                    pos  // 0x20
METHODS:
  System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator ctxt)
  System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentBaseIterator iter)
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
END_CLASS

CLASS: MS.Internal.Xml.Cache.XPathDocumentElementChildIterator
TYPE:  class
TOKEN: 0x20002D3
EXTENDS: XPathDocumentBaseIterator
FIELDS:
  private           System.String                   _localName  // 0x28
  private           System.String                   _namespaceUri  // 0x30
METHODS:
  System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator parent, System.String name, System.String namespaceURI)
  System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentElementChildIterator iter)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean MoveNext()
END_CLASS

CLASS: MS.Internal.Xml.Cache.XPathDocumentKindChildIterator
TYPE:  class
TOKEN: 0x20002D4
EXTENDS: XPathDocumentBaseIterator
FIELDS:
  private           System.Xml.XPath.XPathNodeType  _typ  // 0x28
METHODS:
  System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator parent, System.Xml.XPath.XPathNodeType typ)
  System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentKindChildIterator iter)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean MoveNext()
END_CLASS

CLASS: MS.Internal.Xml.Cache.XPathDocumentElementDescendantIterator
TYPE:  class
TOKEN: 0x20002D5
EXTENDS: XPathDocumentBaseIterator
FIELDS:
  private           MS.Internal.Xml.Cache.XPathDocumentNavigator_end  // 0x28
  private           System.String                   _localName  // 0x30
  private           System.String                   _namespaceUri  // 0x38
  private           System.Boolean                  _matchSelf  // 0x40
METHODS:
  System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator root, System.String name, System.String namespaceURI, System.Boolean matchSelf)
  System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentElementDescendantIterator iter)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean MoveNext()
END_CLASS

CLASS: MS.Internal.Xml.Cache.XPathDocumentKindDescendantIterator
TYPE:  class
TOKEN: 0x20002D6
EXTENDS: XPathDocumentBaseIterator
FIELDS:
  private           MS.Internal.Xml.Cache.XPathDocumentNavigator_end  // 0x28
  private           System.Xml.XPath.XPathNodeType  _typ  // 0x30
  private           System.Boolean                  _matchSelf  // 0x34
METHODS:
  System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator root, System.Xml.XPath.XPathNodeType typ, System.Boolean matchSelf)
  System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentKindDescendantIterator iter)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean MoveNext()
END_CLASS

CLASS: MS.Internal.Xml.Cache.XPathDocumentNavigator
TYPE:  class
TOKEN: 0x20002D7
EXTENDS: XPathNavigator
FIELDS:
  private           MS.Internal.Xml.Cache.XPathNode[]_pageCurrent  // 0x10
  private           MS.Internal.Xml.Cache.XPathNode[]_pageParent  // 0x18
  private           System.Int32                    _idxCurrent  // 0x20
  private           System.Int32                    _idxParent  // 0x24
  private           System.String                   _atomizedLocalName  // 0x28
METHODS:
  System.Void .ctor(MS.Internal.Xml.Cache.XPathNode[] pageCurrent, System.Int32 idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageParent, System.Int32 idxParent)
  System.Void .ctor(MS.Internal.Xml.Cache.XPathDocumentNavigator nav)
  System.String get_Value()
  System.Xml.XPath.XPathNavigator Clone()
  System.Xml.XPath.XPathNodeType get_NodeType()
  System.String get_LocalName()
  System.String get_NamespaceURI()
  System.String get_Name()
  System.String get_Prefix()
  System.String get_BaseURI()
  System.Xml.XmlNameTable get_NameTable()
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
  System.Boolean MoveToAttribute(System.String localName, System.String namespaceURI)
  System.Boolean MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope)
  System.Boolean MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope scope)
  System.Boolean MoveToNext()
  System.Boolean MoveToFirstChild()
  System.Boolean MoveToParent()
  System.Boolean MoveTo(System.Xml.XPath.XPathNavigator other)
  System.Boolean MoveToId(System.String id)
  System.Boolean IsSamePosition(System.Xml.XPath.XPathNavigator other)
  System.Void MoveToRoot()
  System.Boolean MoveToChild(System.String localName, System.String namespaceURI)
  System.Boolean MoveToNext(System.String localName, System.String namespaceURI)
  System.Boolean MoveToChild(System.Xml.XPath.XPathNodeType type)
  System.Boolean MoveToNext(System.Xml.XPath.XPathNodeType type)
  System.Boolean MoveToFollowing(System.String localName, System.String namespaceURI, System.Xml.XPath.XPathNavigator end)
  System.Boolean MoveToFollowing(System.Xml.XPath.XPathNodeType type, System.Xml.XPath.XPathNavigator end)
  System.Xml.XPath.XPathNodeIterator SelectChildren(System.Xml.XPath.XPathNodeType type)
  System.Xml.XPath.XPathNodeIterator SelectChildren(System.String name, System.String namespaceURI)
  System.Xml.XPath.XPathNodeIterator SelectDescendants(System.Xml.XPath.XPathNodeType type, System.Boolean matchSelf)
  System.Xml.XPath.XPathNodeIterator SelectDescendants(System.String name, System.String namespaceURI, System.Boolean matchSelf)
  System.Xml.XmlNodeOrder ComparePosition(System.Xml.XPath.XPathNavigator other)
  System.Boolean IsDescendant(System.Xml.XPath.XPathNavigator other)
  System.Int32 GetPrimaryLocation()
  System.Int32 GetSecondaryLocation()
  System.Object get_UnderlyingObject()
  System.Boolean HasLineInfo()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
  System.Int32 GetPositionHashCode()
  System.Boolean IsElementMatch(System.String localName, System.String namespaceURI)
  System.Boolean IsKindMatch(System.Xml.XPath.XPathNodeType typ)
  System.Int32 GetFollowingEnd(MS.Internal.Xml.Cache.XPathDocumentNavigator end, System.Boolean useParentOfVirtual, MS.Internal.Xml.Cache.XPathNode[]& pageEnd)
END_CLASS

CLASS: MS.Internal.Xml.Cache.XPathNode
TYPE:  struct
TOKEN: 0x20002D8
FIELDS:
  private           MS.Internal.Xml.Cache.XPathNodeInfoAtom_info  // 0x10
  private           System.UInt16                   _idxSibling  // 0x18
  private           System.UInt16                   _idxParent  // 0x1A
  private           System.UInt16                   _idxSimilar  // 0x1C
  private           System.UInt16                   _posOffset  // 0x1E
  private           System.UInt32                   _props  // 0x20
  private           System.String                   _value  // 0x28
METHODS:
  System.Xml.XPath.XPathNodeType get_NodeType()
  System.String get_Prefix()
  System.String get_LocalName()
  System.String get_Name()
  System.String get_NamespaceUri()
  System.Xml.XPath.XPathDocument get_Document()
  System.String get_BaseUri()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
  System.Int32 get_CollapsedLinePosition()
  MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo()
  System.Int32 GetRoot(MS.Internal.Xml.Cache.XPathNode[]& pageNode)
  System.Int32 GetParent(MS.Internal.Xml.Cache.XPathNode[]& pageNode)
  System.Int32 GetSibling(MS.Internal.Xml.Cache.XPathNode[]& pageNode)
  System.Int32 GetSimilarElement(MS.Internal.Xml.Cache.XPathNode[]& pageNode)
  System.Boolean NameMatch(System.String localName, System.String namespaceName)
  System.Boolean ElementMatch(System.String localName, System.String namespaceName)
  System.Boolean get_IsXmlNamespaceNode()
  System.Boolean get_HasSibling()
  System.Boolean get_HasCollapsedText()
  System.Boolean get_HasAttribute()
  System.Boolean get_HasContentChild()
  System.Boolean get_HasElementChild()
  System.Boolean get_IsAttrNmsp()
  System.Boolean get_IsText()
  System.Boolean get_HasNamespaceDecls()
  System.String get_Value()
END_CLASS

CLASS: MS.Internal.Xml.Cache.XPathNodeRef
TYPE:  struct
TOKEN: 0x20002D9
FIELDS:
  private           MS.Internal.Xml.Cache.XPathNode[]_page  // 0x10
  private           System.Int32                    _idx  // 0x18
METHODS:
  System.Void .ctor(MS.Internal.Xml.Cache.XPathNode[] page, System.Int32 idx)
  MS.Internal.Xml.Cache.XPathNode[] get_Page()
  System.Int32 get_Index()
  System.Int32 GetHashCode()
END_CLASS

CLASS: MS.Internal.Xml.Cache.XPathNodeHelper
TYPE:  class
TOKEN: 0x20002DA
FIELDS:
METHODS:
  System.Int32 GetLocalNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, System.Int32 idxElem, MS.Internal.Xml.Cache.XPathNode[]& pageNmsp)
  System.Int32 GetInScopeNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, System.Int32 idxElem, MS.Internal.Xml.Cache.XPathNode[]& pageNmsp)
  System.Boolean GetFirstAttribute(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode)
  System.Boolean GetNextAttribute(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode)
  System.Boolean GetContentChild(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode)
  System.Boolean GetContentSibling(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode)
  System.Boolean GetParent(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode)
  System.Int32 GetLocation(MS.Internal.Xml.Cache.XPathNode[] pageNode, System.Int32 idxNode)
  System.Boolean GetElementChild(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode, System.String localName, System.String namespaceName)
  System.Boolean GetElementSibling(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode, System.String localName, System.String namespaceName)
  System.Boolean GetContentChild(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode, System.Xml.XPath.XPathNodeType typ)
  System.Boolean GetContentSibling(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode, System.Xml.XPath.XPathNodeType typ)
  System.Boolean GetAttribute(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode, System.String localName, System.String namespaceName)
  System.Boolean GetElementFollowing(MS.Internal.Xml.Cache.XPathNode[]& pageCurrent, System.Int32& idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageEnd, System.Int32 idxEnd, System.String localName, System.String namespaceName)
  System.Boolean GetContentFollowing(MS.Internal.Xml.Cache.XPathNode[]& pageCurrent, System.Int32& idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageEnd, System.Int32 idxEnd, System.Xml.XPath.XPathNodeType typ)
  System.Boolean GetTextFollowing(MS.Internal.Xml.Cache.XPathNode[]& pageCurrent, System.Int32& idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageEnd, System.Int32 idxEnd)
  System.Boolean GetNonDescendant(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode)
  System.Void GetChild(MS.Internal.Xml.Cache.XPathNode[]& pageNode, System.Int32& idxNode)
END_CLASS

CLASS: MS.Internal.Xml.Cache.XPathNodePageInfo
TYPE:  class
TOKEN: 0x20002DB
FIELDS:
  private           System.Int32                    _pageNum  // 0x10
  private           System.Int32                    _nodeCount  // 0x14
  private           MS.Internal.Xml.Cache.XPathNode[]_pageNext  // 0x18
METHODS:
  System.Int32 get_PageNumber()
  System.Int32 get_NodeCount()
  MS.Internal.Xml.Cache.XPathNode[] get_NextPage()
END_CLASS

CLASS: MS.Internal.Xml.Cache.XPathNodeInfoAtom
TYPE:  class
TOKEN: 0x20002DC
FIELDS:
  private           System.String                   _localName  // 0x10
  private           System.String                   _namespaceUri  // 0x18
  private           System.String                   _prefix  // 0x20
  private           System.String                   _baseUri  // 0x28
  private           MS.Internal.Xml.Cache.XPathNode[]_pageParent  // 0x30
  private           MS.Internal.Xml.Cache.XPathNode[]_pageSibling  // 0x38
  private           MS.Internal.Xml.Cache.XPathNode[]_pageSimilar  // 0x40
  private           System.Xml.XPath.XPathDocument  _doc  // 0x48
  private           System.Int32                    _lineNumBase  // 0x50
  private           System.Int32                    _linePosBase  // 0x54
  private           MS.Internal.Xml.Cache.XPathNodePageInfo_pageInfo  // 0x58
METHODS:
  MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo()
  System.String get_LocalName()
  System.String get_NamespaceUri()
  System.String get_Prefix()
  System.String get_BaseUri()
  MS.Internal.Xml.Cache.XPathNode[] get_SiblingPage()
  MS.Internal.Xml.Cache.XPathNode[] get_SimilarElementPage()
  MS.Internal.Xml.Cache.XPathNode[] get_ParentPage()
  System.Xml.XPath.XPathDocument get_Document()
  System.Int32 get_LineNumberBase()
  System.Int32 get_LinePositionBase()
END_CLASS

CLASS: MS.Internal.Xml.XPath.AbsoluteQuery
TYPE:  class
TOKEN: 0x2000286
EXTENDS: ContextQuery
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(MS.Internal.Xml.XPath.AbsoluteQuery other)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.AstNode
TYPE:  class
TOKEN: 0x2000287
FIELDS:
METHODS:
  MS.Internal.Xml.XPath.AstNode.AstType get_Type()
  System.Xml.XPath.XPathResultType get_ReturnType()
  System.Void .ctor()
END_CLASS

CLASS: MS.Internal.Xml.XPath.AttributeQuery
TYPE:  class
TOKEN: 0x2000289
EXTENDS: BaseAxisQuery
FIELDS:
  private           System.Boolean                  _onAttribute  // 0x58
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type)
  System.Void .ctor(MS.Internal.Xml.XPath.AttributeQuery other)
  System.Void Reset()
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.Axis
TYPE:  class
TOKEN: 0x200028A
EXTENDS: AstNode
FIELDS:
  private           MS.Internal.Xml.XPath.Axis.AxisType_axisType  // 0x10
  private           MS.Internal.Xml.XPath.AstNode   _input  // 0x18
  private           System.String                   _prefix  // 0x20
  private           System.String                   _name  // 0x28
  private           System.Xml.XPath.XPathNodeType  _nodeType  // 0x30
  protected         System.Boolean                  abbrAxis  // 0x34
  private           System.String                   _urn  // 0x38
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input, System.String prefix, System.String name, System.Xml.XPath.XPathNodeType nodetype)
  System.Void .ctor(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input)
  MS.Internal.Xml.XPath.AstNode.AstType get_Type()
  System.Xml.XPath.XPathResultType get_ReturnType()
  MS.Internal.Xml.XPath.AstNode get_Input()
  System.Void set_Input(MS.Internal.Xml.XPath.AstNode value)
  System.String get_Prefix()
  System.String get_Name()
  System.Xml.XPath.XPathNodeType get_NodeType()
  MS.Internal.Xml.XPath.Axis.AxisType get_TypeOfAxis()
  System.Boolean get_AbbrAxis()
  System.String get_Urn()
  System.Void set_Urn(System.String value)
END_CLASS

CLASS: MS.Internal.Xml.XPath.BaseAxisQuery
TYPE:  class
TOKEN: 0x200028C
EXTENDS: Query
FIELDS:
  private           MS.Internal.Xml.XPath.Query     qyInput  // 0x18
  private           System.Boolean                  _nameTest  // 0x20
  private           System.String                   _name  // 0x28
  private           System.String                   _prefix  // 0x30
  private           System.String                   _nsUri  // 0x38
  private           System.Xml.XPath.XPathNodeType  _typeTest  // 0x40
  protected         System.Xml.XPath.XPathNavigator currentNode  // 0x48
  protected         System.Int32                    position  // 0x50
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput)
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest)
  System.Void .ctor(MS.Internal.Xml.XPath.BaseAxisQuery other)
  System.Void Reset()
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.String get_Name()
  System.String get_Namespace()
  System.Boolean get_NameTest()
  System.Xml.XPath.XPathNodeType get_TypeTest()
  System.Int32 get_CurrentPosition()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Boolean matches(System.Xml.XPath.XPathNavigator e)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathResultType get_StaticType()
END_CLASS

CLASS: MS.Internal.Xml.XPath.BooleanExpr
TYPE:  class
TOKEN: 0x200028D
EXTENDS: ValueQuery
FIELDS:
  private           MS.Internal.Xml.XPath.Query     _opnd1  // 0x18
  private           MS.Internal.Xml.XPath.Query     _opnd2  // 0x20
  private           System.Boolean                  _isOr  // 0x28
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.Query opnd1, MS.Internal.Xml.XPath.Query opnd2)
  System.Void .ctor(MS.Internal.Xml.XPath.BooleanExpr other)
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Xml.XPath.XPathResultType get_StaticType()
END_CLASS

CLASS: MS.Internal.Xml.XPath.BooleanFunctions
TYPE:  class
TOKEN: 0x200028E
EXTENDS: ValueQuery
FIELDS:
  private           MS.Internal.Xml.XPath.Query     _arg  // 0x18
  private           MS.Internal.Xml.XPath.Function.FunctionType_funcType  // 0x20
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType funcType, MS.Internal.Xml.XPath.Query arg)
  System.Void .ctor(MS.Internal.Xml.XPath.BooleanFunctions other)
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Boolean toBoolean(System.Double number)
  System.Boolean toBoolean(System.String str)
  System.Boolean toBoolean(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Boolean Not(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Boolean Lang(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.CacheAxisQuery
TYPE:  class
TOKEN: 0x200028F
EXTENDS: BaseAxisQuery
FIELDS:
  protected         System.Collections.Generic.List<System.Xml.XPath.XPathNavigator>outputBuffer  // 0x58
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest)
  System.Void .ctor(MS.Internal.Xml.XPath.CacheAxisQuery other)
  System.Void Reset()
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
  System.Int32 get_Count()
  MS.Internal.Xml.XPath.QueryProps get_Properties()
END_CLASS

CLASS: MS.Internal.Xml.XPath.CacheChildrenQuery
TYPE:  class
TOKEN: 0x2000290
EXTENDS: ChildrenQuery
FIELDS:
  private           System.Xml.XPath.XPathNavigator _nextInput  // 0x60
  private           MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator>_elementStk  // 0x68
  private           MS.Internal.Xml.XPath.ClonableStack<System.Int32>_positionStk  // 0x70
  private           System.Boolean                  _needInput  // 0x78
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType type)
  System.Void .ctor(MS.Internal.Xml.XPath.CacheChildrenQuery other)
  System.Void Reset()
  System.Xml.XPath.XPathNavigator Advance()
  System.Boolean DecideNextNode()
  System.Xml.XPath.XPathNavigator GetNextInput()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.CacheOutputQuery
TYPE:  class
TOKEN: 0x2000291
EXTENDS: Query
FIELDS:
  private           MS.Internal.Xml.XPath.Query     input  // 0x18
  protected         System.Collections.Generic.List<System.Xml.XPath.XPathNavigator>outputBuffer  // 0x20
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query input)
  System.Void .ctor(MS.Internal.Xml.XPath.CacheOutputQuery other)
  System.Void Reset()
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Int32 get_CurrentPosition()
  System.Int32 get_Count()
  MS.Internal.Xml.XPath.QueryProps get_Properties()
END_CLASS

CLASS: MS.Internal.Xml.XPath.ChildrenQuery
TYPE:  class
TOKEN: 0x2000292
EXTENDS: BaseAxisQuery
FIELDS:
  private           System.Xml.XPath.XPathNodeIterator_iterator  // 0x58
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType type)
  System.Void .ctor(MS.Internal.Xml.XPath.ChildrenQuery other)
  System.Void Reset()
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.ClonableStack`1
TYPE:  class
TOKEN: 0x2000293
EXTENDS: List`1
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection)
  System.Void Push(T value)
  T Pop()
  T Peek()
  MS.Internal.Xml.XPath.ClonableStack<T> Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.CompiledXpathExpr
TYPE:  class
TOKEN: 0x2000294
EXTENDS: XPathExpression
FIELDS:
  private           MS.Internal.Xml.XPath.Query     _query  // 0x10
  private           System.String                   _expr  // 0x18
  private           System.Boolean                  _needContext  // 0x20
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query query, System.String expression, System.Boolean needContext)
  MS.Internal.Xml.XPath.Query get_QueryTree()
  System.Void SetContext(System.Xml.IXmlNamespaceResolver nsResolver)
END_CLASS

CLASS: MS.Internal.Xml.XPath.ContextQuery
TYPE:  class
TOKEN: 0x2000296
EXTENDS: Query
FIELDS:
  protected         System.Xml.XPath.XPathNavigator contextNode  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(MS.Internal.Xml.XPath.ContextQuery other)
  System.Void Reset()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Int32 get_CurrentPosition()
  System.Int32 get_Count()
  MS.Internal.Xml.XPath.QueryProps get_Properties()
END_CLASS

CLASS: MS.Internal.Xml.XPath.DescendantBaseQuery
TYPE:  class
TOKEN: 0x2000297
EXTENDS: BaseAxisQuery
FIELDS:
  protected         System.Boolean                  matchSelf  // 0x58
  protected         System.Boolean                  abbrAxis  // 0x59
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type, System.Boolean matchSelf, System.Boolean abbrAxis)
  System.Void .ctor(MS.Internal.Xml.XPath.DescendantBaseQuery other)
END_CLASS

CLASS: MS.Internal.Xml.XPath.DescendantQuery
TYPE:  class
TOKEN: 0x2000298
EXTENDS: DescendantBaseQuery
FIELDS:
  private           System.Xml.XPath.XPathNodeIterator_nodeIterator  // 0x60
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type, System.Boolean matchSelf, System.Boolean abbrAxis)
  System.Void .ctor(MS.Internal.Xml.XPath.DescendantQuery other)
  System.Void Reset()
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.DescendantOverDescendantQuery
TYPE:  class
TOKEN: 0x2000299
EXTENDS: DescendantBaseQuery
FIELDS:
  private           System.Int32                    _level  // 0x60
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, System.Boolean matchSelf, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest, System.Boolean abbrAxis)
  System.Void .ctor(MS.Internal.Xml.XPath.DescendantOverDescendantQuery other)
  System.Void Reset()
  System.Xml.XPath.XPathNavigator Advance()
  System.Boolean MoveToFirstChild()
  System.Boolean MoveUpUntilNext()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.DocumentOrderQuery
TYPE:  class
TOKEN: 0x200029A
EXTENDS: CacheOutputQuery
FIELDS:
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent)
  System.Void .ctor(MS.Internal.Xml.XPath.DocumentOrderQuery other)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.EmptyQuery
TYPE:  class
TOKEN: 0x200029B
EXTENDS: Query
FIELDS:
METHODS:
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Int32 get_CurrentPosition()
  System.Int32 get_Count()
  MS.Internal.Xml.XPath.QueryProps get_Properties()
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Void Reset()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Void .ctor()
END_CLASS

CLASS: MS.Internal.Xml.XPath.ExtensionQuery
TYPE:  class
TOKEN: 0x200029C
EXTENDS: Query
FIELDS:
  protected         System.String                   prefix  // 0x18
  protected         System.String                   name  // 0x20
  protected         System.Xml.Xsl.XsltContext      xsltContext  // 0x28
  private           MS.Internal.Xml.XPath.ResetableIterator_queryIterator  // 0x30
METHODS:
  System.Void .ctor(System.String prefix, System.String name)
  System.Void .ctor(MS.Internal.Xml.XPath.ExtensionQuery other)
  System.Void Reset()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Xml.XPath.XPathNavigator Advance()
  System.Int32 get_CurrentPosition()
  System.Object ProcessResult(System.Object value)
  System.String get_QName()
  System.Int32 get_Count()
  System.Xml.XPath.XPathResultType get_StaticType()
END_CLASS

CLASS: MS.Internal.Xml.XPath.Filter
TYPE:  class
TOKEN: 0x200029D
EXTENDS: AstNode
FIELDS:
  private           MS.Internal.Xml.XPath.AstNode   _input  // 0x10
  private           MS.Internal.Xml.XPath.AstNode   _condition  // 0x18
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.AstNode input, MS.Internal.Xml.XPath.AstNode condition)
  MS.Internal.Xml.XPath.AstNode.AstType get_Type()
  System.Xml.XPath.XPathResultType get_ReturnType()
  MS.Internal.Xml.XPath.AstNode get_Input()
  MS.Internal.Xml.XPath.AstNode get_Condition()
END_CLASS

CLASS: MS.Internal.Xml.XPath.FilterQuery
TYPE:  class
TOKEN: 0x200029E
EXTENDS: BaseAxisQuery
FIELDS:
  private           MS.Internal.Xml.XPath.Query     _cond  // 0x58
  private           System.Boolean                  _noPosition  // 0x60
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, MS.Internal.Xml.XPath.Query cond, System.Boolean noPosition)
  System.Void .ctor(MS.Internal.Xml.XPath.FilterQuery other)
  System.Void Reset()
  MS.Internal.Xml.XPath.Query get_Condition()
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext input)
  System.Xml.XPath.XPathNavigator Advance()
  System.Boolean EvaluatePredicate()
  MS.Internal.Xml.XPath.QueryProps get_Properties()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.FollSiblingQuery
TYPE:  class
TOKEN: 0x200029F
EXTENDS: BaseAxisQuery
FIELDS:
  private           MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator>_elementStk  // 0x58
  private           System.Collections.Generic.List<System.Xml.XPath.XPathNavigator>_parentStk  // 0x60
  private           System.Xml.XPath.XPathNavigator _nextInput  // 0x68
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType type)
  System.Void .ctor(MS.Internal.Xml.XPath.FollSiblingQuery other)
  System.Void Reset()
  System.Boolean Visited(System.Xml.XPath.XPathNavigator nav)
  System.Xml.XPath.XPathNavigator FetchInput()
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.FollowingQuery
TYPE:  class
TOKEN: 0x20002A0
EXTENDS: BaseAxisQuery
FIELDS:
  private           System.Xml.XPath.XPathNavigator _input  // 0x58
  private           System.Xml.XPath.XPathNodeIterator_iterator  // 0x60
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest)
  System.Void .ctor(MS.Internal.Xml.XPath.FollowingQuery other)
  System.Void Reset()
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.ForwardPositionQuery
TYPE:  class
TOKEN: 0x20002A1
EXTENDS: CacheOutputQuery
FIELDS:
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query input)
  System.Void .ctor(MS.Internal.Xml.XPath.ForwardPositionQuery other)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.Function
TYPE:  class
TOKEN: 0x20002A2
EXTENDS: AstNode
FIELDS:
  private           MS.Internal.Xml.XPath.Function.FunctionType_functionType  // 0x10
  private           System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode>_argumentList  // 0x18
  private           System.String                   _name  // 0x20
  private           System.String                   _prefix  // 0x28
  private   static  System.Xml.XPath.XPathResultType[]ReturnTypes  // 0x0
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType ftype, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList)
  System.Void .ctor(System.String prefix, System.String name, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList)
  System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType ftype, MS.Internal.Xml.XPath.AstNode arg)
  MS.Internal.Xml.XPath.AstNode.AstType get_Type()
  System.Xml.XPath.XPathResultType get_ReturnType()
  MS.Internal.Xml.XPath.Function.FunctionType get_TypeOfFunction()
  System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> get_ArgumentList()
  System.String get_Prefix()
  System.String get_Name()
  System.Void .cctor()
END_CLASS

CLASS: MS.Internal.Xml.XPath.FunctionQuery
TYPE:  class
TOKEN: 0x20002A4
EXTENDS: ExtensionQuery
FIELDS:
  private           System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query>_args  // 0x38
  private           System.Xml.Xsl.IXsltContextFunction_function  // 0x40
METHODS:
  System.Void .ctor(System.String prefix, System.String name, System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> args)
  System.Void .ctor(MS.Internal.Xml.XPath.FunctionQuery other)
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.Group
TYPE:  class
TOKEN: 0x20002A5
EXTENDS: AstNode
FIELDS:
  private           MS.Internal.Xml.XPath.AstNode   _groupNode  // 0x10
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.AstNode groupNode)
  MS.Internal.Xml.XPath.AstNode.AstType get_Type()
  System.Xml.XPath.XPathResultType get_ReturnType()
  MS.Internal.Xml.XPath.AstNode get_GroupNode()
END_CLASS

CLASS: MS.Internal.Xml.XPath.GroupQuery
TYPE:  class
TOKEN: 0x20002A6
EXTENDS: BaseAxisQuery
FIELDS:
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qy)
  System.Void .ctor(MS.Internal.Xml.XPath.GroupQuery other)
  System.Xml.XPath.XPathNavigator Advance()
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Xml.XPath.XPathResultType get_StaticType()
  MS.Internal.Xml.XPath.QueryProps get_Properties()
END_CLASS

CLASS: MS.Internal.Xml.XPath.IDQuery
TYPE:  class
TOKEN: 0x20002A7
EXTENDS: CacheOutputQuery
FIELDS:
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query arg)
  System.Void .ctor(MS.Internal.Xml.XPath.IDQuery other)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Void ProcessIds(System.Xml.XPath.XPathNavigator contextNode, System.String val)
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.IteratorFilter
TYPE:  class
TOKEN: 0x20002A8
EXTENDS: XPathNodeIterator
FIELDS:
  private           System.Xml.XPath.XPathNodeIterator_innerIterator  // 0x18
  private           System.String                   _name  // 0x20
  private           System.Int32                    _position  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XPath.XPathNodeIterator innerIterator, System.String name)
  System.Void .ctor(MS.Internal.Xml.XPath.IteratorFilter it)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
  System.Boolean MoveNext()
END_CLASS

CLASS: MS.Internal.Xml.XPath.LogicalExpr
TYPE:  class
TOKEN: 0x20002A9
EXTENDS: ValueQuery
FIELDS:
  private           MS.Internal.Xml.XPath.Operator.Op_op  // 0x18
  private           MS.Internal.Xml.XPath.Query     _opnd1  // 0x20
  private           MS.Internal.Xml.XPath.Query     _opnd2  // 0x28
  private   static readonly MS.Internal.Xml.XPath.LogicalExpr.cmpXslt[][]s_CompXsltE  // 0x0
  private   static readonly MS.Internal.Xml.XPath.LogicalExpr.cmpXslt[][]s_CompXsltO  // 0x8
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.Query opnd1, MS.Internal.Xml.XPath.Query opnd2)
  System.Void .ctor(MS.Internal.Xml.XPath.LogicalExpr other)
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Boolean cmpQueryQueryE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpQueryQueryO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpQueryNumber(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpQueryStringE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpQueryStringO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpRtfQueryE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpRtfQueryO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpQueryBoolE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpQueryBoolO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpBoolBoolE(MS.Internal.Xml.XPath.Operator.Op op, System.Boolean n1, System.Boolean n2)
  System.Boolean cmpBoolBoolE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpBoolBoolO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpBoolNumberE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpBoolNumberO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpBoolStringE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpRtfBoolE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpBoolStringO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpRtfBoolO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpNumberNumber(MS.Internal.Xml.XPath.Operator.Op op, System.Double n1, System.Double n2)
  System.Boolean cmpNumberNumberO(MS.Internal.Xml.XPath.Operator.Op op, System.Double n1, System.Double n2)
  System.Boolean cmpNumberNumber(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpStringNumber(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpRtfNumber(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpStringStringE(MS.Internal.Xml.XPath.Operator.Op op, System.String n1, System.String n2)
  System.Boolean cmpStringStringE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpRtfStringE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpRtfRtfE(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpStringStringO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpRtfStringO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Boolean cmpRtfRtfO(MS.Internal.Xml.XPath.Operator.Op op, System.Object val1, System.Object val2)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.String Rtf(System.Object o)
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Void .cctor()
END_CLASS

CLASS: MS.Internal.Xml.XPath.MergeFilterQuery
TYPE:  class
TOKEN: 0x20002AC
EXTENDS: CacheOutputQuery
FIELDS:
  private           MS.Internal.Xml.XPath.Query     _child  // 0x28
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query input, MS.Internal.Xml.XPath.Query child)
  System.Void .ctor(MS.Internal.Xml.XPath.MergeFilterQuery other)
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext xsltContext)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.NamespaceQuery
TYPE:  class
TOKEN: 0x20002AD
EXTENDS: BaseAxisQuery
FIELDS:
  private           System.Boolean                  _onNamespace  // 0x58
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyParent, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type)
  System.Void .ctor(MS.Internal.Xml.XPath.NamespaceQuery other)
  System.Void Reset()
  System.Xml.XPath.XPathNavigator Advance()
  System.Boolean matches(System.Xml.XPath.XPathNavigator e)
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.NodeFunctions
TYPE:  class
TOKEN: 0x20002AE
EXTENDS: ValueQuery
FIELDS:
  private           MS.Internal.Xml.XPath.Query     _arg  // 0x18
  private           MS.Internal.Xml.XPath.Function.FunctionType_funcType  // 0x20
  private           System.Xml.Xsl.XsltContext      _xsltContext  // 0x28
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType funcType, MS.Internal.Xml.XPath.Query arg)
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.Xml.XPath.XPathNavigator EvaluateArg(System.Xml.XPath.XPathNodeIterator context)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.NumberFunctions
TYPE:  class
TOKEN: 0x20002AF
EXTENDS: ValueQuery
FIELDS:
  private           MS.Internal.Xml.XPath.Query     _arg  // 0x18
  private           MS.Internal.Xml.XPath.Function.FunctionType_ftype  // 0x20
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType ftype, MS.Internal.Xml.XPath.Query arg)
  System.Void .ctor(MS.Internal.Xml.XPath.NumberFunctions other)
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.Double Number(System.Boolean arg)
  System.Double Number(System.String arg)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Double Number(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Double Sum(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Double Floor(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Double Ceiling(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Double Round(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.NumericExpr
TYPE:  class
TOKEN: 0x20002B0
EXTENDS: ValueQuery
FIELDS:
  private           MS.Internal.Xml.XPath.Operator.Op_op  // 0x18
  private           MS.Internal.Xml.XPath.Query     _opnd1  // 0x20
  private           MS.Internal.Xml.XPath.Query     _opnd2  // 0x28
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.Query opnd1, MS.Internal.Xml.XPath.Query opnd2)
  System.Void .ctor(MS.Internal.Xml.XPath.NumericExpr other)
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Double GetValue(MS.Internal.Xml.XPath.Operator.Op op, System.Double n1, System.Double n2)
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.Operand
TYPE:  class
TOKEN: 0x20002B1
EXTENDS: AstNode
FIELDS:
  private           System.Xml.XPath.XPathResultType_type  // 0x10
  private           System.Object                   _val  // 0x18
METHODS:
  System.Void .ctor(System.String val)
  System.Void .ctor(System.Double val)
  MS.Internal.Xml.XPath.AstNode.AstType get_Type()
  System.Xml.XPath.XPathResultType get_ReturnType()
  System.Object get_OperandValue()
END_CLASS

CLASS: MS.Internal.Xml.XPath.OperandQuery
TYPE:  class
TOKEN: 0x20002B2
EXTENDS: ValueQuery
FIELDS:
  private           System.Object                   val  // 0x18
METHODS:
  System.Void .ctor(System.Object val)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.Operator
TYPE:  class
TOKEN: 0x20002B3
EXTENDS: AstNode
FIELDS:
  private   static  MS.Internal.Xml.XPath.Operator.Op[]s_invertOp  // 0x0
  private           MS.Internal.Xml.XPath.Operator.Op_opType  // 0x10
  private           MS.Internal.Xml.XPath.AstNode   _opnd1  // 0x18
  private           MS.Internal.Xml.XPath.AstNode   _opnd2  // 0x20
METHODS:
  MS.Internal.Xml.XPath.Operator.Op InvertOperator(MS.Internal.Xml.XPath.Operator.Op op)
  System.Void .ctor(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.AstNode opnd1, MS.Internal.Xml.XPath.AstNode opnd2)
  MS.Internal.Xml.XPath.AstNode.AstType get_Type()
  System.Xml.XPath.XPathResultType get_ReturnType()
  MS.Internal.Xml.XPath.Operator.Op get_OperatorType()
  MS.Internal.Xml.XPath.AstNode get_Operand1()
  MS.Internal.Xml.XPath.AstNode get_Operand2()
  System.Void .cctor()
END_CLASS

CLASS: MS.Internal.Xml.XPath.ParentQuery
TYPE:  class
TOKEN: 0x20002B5
EXTENDS: CacheAxisQuery
FIELDS:
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type)
  System.Void .ctor(MS.Internal.Xml.XPath.ParentQuery other)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.PreSiblingQuery
TYPE:  class
TOKEN: 0x20002B6
EXTENDS: CacheAxisQuery
FIELDS:
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest)
  System.Void .ctor(MS.Internal.Xml.XPath.PreSiblingQuery other)
  System.Boolean NotVisited(System.Xml.XPath.XPathNavigator nav, System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> parentStk)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathNodeIterator Clone()
  MS.Internal.Xml.XPath.QueryProps get_Properties()
END_CLASS

CLASS: MS.Internal.Xml.XPath.PrecedingQuery
TYPE:  class
TOKEN: 0x20002B7
EXTENDS: BaseAxisQuery
FIELDS:
  private           System.Xml.XPath.XPathNodeIterator_workIterator  // 0x58
  private           MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator>_ancestorStk  // 0x60
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest)
  System.Void .ctor(MS.Internal.Xml.XPath.PrecedingQuery other)
  System.Void Reset()
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathNodeIterator Clone()
  MS.Internal.Xml.XPath.QueryProps get_Properties()
END_CLASS

CLASS: MS.Internal.Xml.XPath.QueryProps
TYPE:  struct
TOKEN: 0x20002B8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  MS.Internal.Xml.XPath.QueryPropsNone  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryPropsPosition  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryPropsCount  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryPropsCached  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryPropsReverse  // 0x0
  public    static  MS.Internal.Xml.XPath.QueryPropsMerge  // 0x0
METHODS:
END_CLASS

CLASS: MS.Internal.Xml.XPath.Query
TYPE:  class
TOKEN: 0x20002B9
EXTENDS: ResetableIterator
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(MS.Internal.Xml.XPath.Query other)
  System.Boolean MoveNext()
  System.Int32 get_Count()
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathResultType get_StaticType()
  MS.Internal.Xml.XPath.QueryProps get_Properties()
  MS.Internal.Xml.XPath.Query Clone(MS.Internal.Xml.XPath.Query input)
  System.Xml.XPath.XPathNodeIterator Clone(System.Xml.XPath.XPathNodeIterator input)
  System.Xml.XPath.XPathNavigator Clone(System.Xml.XPath.XPathNavigator input)
  System.Boolean Insert(System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> buffer, System.Xml.XPath.XPathNavigator nav)
  System.Int32 GetMedian(System.Int32 l, System.Int32 r)
  System.Xml.XmlNodeOrder CompareNodes(System.Xml.XPath.XPathNavigator l, System.Xml.XPath.XPathNavigator r)
  System.Xml.XPath.XPathResultType GetXPathType(System.Object value)
END_CLASS

CLASS: MS.Internal.Xml.XPath.QueryBuilder
TYPE:  class
TOKEN: 0x20002BA
FIELDS:
  private           System.String                   _query  // 0x10
  private           System.Boolean                  _allowVar  // 0x18
  private           System.Boolean                  _allowKey  // 0x19
  private           System.Boolean                  _allowCurrent  // 0x1A
  private           System.Boolean                  _needContext  // 0x1B
  private           MS.Internal.Xml.XPath.BaseAxisQuery_firstInput  // 0x20
  private           System.Int32                    _parseDepth  // 0x28
METHODS:
  System.Void Reset()
  MS.Internal.Xml.XPath.Query ProcessAxis(MS.Internal.Xml.XPath.Axis root, MS.Internal.Xml.XPath.QueryBuilder.Flags flags, MS.Internal.Xml.XPath.QueryBuilder.Props& props)
  System.Boolean CanBeNumber(MS.Internal.Xml.XPath.Query q)
  MS.Internal.Xml.XPath.Query ProcessFilter(MS.Internal.Xml.XPath.Filter root, MS.Internal.Xml.XPath.QueryBuilder.Flags flags, MS.Internal.Xml.XPath.QueryBuilder.Props& props)
  MS.Internal.Xml.XPath.Query ProcessOperator(MS.Internal.Xml.XPath.Operator root, MS.Internal.Xml.XPath.QueryBuilder.Props& props)
  MS.Internal.Xml.XPath.Query ProcessVariable(MS.Internal.Xml.XPath.Variable root)
  MS.Internal.Xml.XPath.Query ProcessFunction(MS.Internal.Xml.XPath.Function root, MS.Internal.Xml.XPath.QueryBuilder.Props& props)
  System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> ProcessArguments(System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> args, MS.Internal.Xml.XPath.QueryBuilder.Props& props)
  MS.Internal.Xml.XPath.Query ProcessNode(MS.Internal.Xml.XPath.AstNode root, MS.Internal.Xml.XPath.QueryBuilder.Flags flags, MS.Internal.Xml.XPath.QueryBuilder.Props& props)
  MS.Internal.Xml.XPath.Query Build(MS.Internal.Xml.XPath.AstNode root, System.String query)
  MS.Internal.Xml.XPath.Query Build(System.String query, System.Boolean allowVar, System.Boolean allowKey)
  MS.Internal.Xml.XPath.Query Build(System.String query, System.Boolean& needContext)
  System.Void .ctor()
END_CLASS

CLASS: MS.Internal.Xml.XPath.ResetableIterator
TYPE:  class
TOKEN: 0x20002BD
EXTENDS: XPathNodeIterator
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(MS.Internal.Xml.XPath.ResetableIterator other)
  System.Void ResetCount()
  System.Void Reset()
  System.Int32 get_CurrentPosition()
END_CLASS

CLASS: MS.Internal.Xml.XPath.ReversePositionQuery
TYPE:  class
TOKEN: 0x20002BE
EXTENDS: ForwardPositionQuery
FIELDS:
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query input)
  System.Void .ctor(MS.Internal.Xml.XPath.ReversePositionQuery other)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Int32 get_CurrentPosition()
  MS.Internal.Xml.XPath.QueryProps get_Properties()
END_CLASS

CLASS: MS.Internal.Xml.XPath.Root
TYPE:  class
TOKEN: 0x20002BF
EXTENDS: AstNode
FIELDS:
METHODS:
  System.Void .ctor()
  MS.Internal.Xml.XPath.AstNode.AstType get_Type()
  System.Xml.XPath.XPathResultType get_ReturnType()
END_CLASS

CLASS: MS.Internal.Xml.XPath.StringFunctions
TYPE:  class
TOKEN: 0x20002C0
EXTENDS: ValueQuery
FIELDS:
  private           MS.Internal.Xml.XPath.Function.FunctionType_funcType  // 0x18
  private           System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query>_argList  // 0x20
  private   static readonly System.Globalization.CompareInfos_compareInfo  // 0x0
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Function.FunctionType funcType, System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> argList)
  System.Void .ctor(MS.Internal.Xml.XPath.StringFunctions other)
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.String toString(System.Double num)
  System.String toString(System.Boolean b)
  System.String toString(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathResultType get_StaticType()
  System.String Concat(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Boolean StartsWith(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Boolean Contains(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.String SubstringBefore(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.String SubstringAfter(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.String Substring(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Double StringLength(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.String Normalize(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.String Translate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Void .cctor()
END_CLASS

CLASS: MS.Internal.Xml.XPath.UnionExpr
TYPE:  class
TOKEN: 0x20002C1
EXTENDS: Query
FIELDS:
  private           MS.Internal.Xml.XPath.Query     qy1  // 0x18
  private           MS.Internal.Xml.XPath.Query     qy2  // 0x20
  private           System.Boolean                  _advance1  // 0x28
  private           System.Boolean                  _advance2  // 0x29
  private           System.Xml.XPath.XPathNavigator _currentNode  // 0x30
  private           System.Xml.XPath.XPathNavigator _nextNode  // 0x38
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query query1, MS.Internal.Xml.XPath.Query query2)
  System.Void .ctor(MS.Internal.Xml.XPath.UnionExpr other)
  System.Void Reset()
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext xsltContext)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathNavigator ProcessSamePosition(System.Xml.XPath.XPathNavigator result)
  System.Xml.XPath.XPathNavigator ProcessBeforePosition(System.Xml.XPath.XPathNavigator res1, System.Xml.XPath.XPathNavigator res2)
  System.Xml.XPath.XPathNavigator ProcessAfterPosition(System.Xml.XPath.XPathNavigator res1, System.Xml.XPath.XPathNavigator res2)
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
END_CLASS

CLASS: MS.Internal.Xml.XPath.ValueQuery
TYPE:  class
TOKEN: 0x20002C2
EXTENDS: Query
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(MS.Internal.Xml.XPath.ValueQuery other)
  System.Void Reset()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
  System.Int32 get_Count()
  System.Xml.XPath.XPathNavigator Advance()
END_CLASS

CLASS: MS.Internal.Xml.XPath.Variable
TYPE:  class
TOKEN: 0x20002C3
EXTENDS: AstNode
FIELDS:
  private           System.String                   _localname  // 0x10
  private           System.String                   _prefix  // 0x18
METHODS:
  System.Void .ctor(System.String name, System.String prefix)
  MS.Internal.Xml.XPath.AstNode.AstType get_Type()
  System.Xml.XPath.XPathResultType get_ReturnType()
  System.String get_Localname()
  System.String get_Prefix()
END_CLASS

CLASS: MS.Internal.Xml.XPath.VariableQuery
TYPE:  class
TOKEN: 0x20002C4
EXTENDS: ExtensionQuery
FIELDS:
  private           System.Xml.Xsl.IXsltContextVariable_variable  // 0x38
METHODS:
  System.Void .ctor(System.String name, System.String prefix)
  System.Void .ctor(MS.Internal.Xml.XPath.VariableQuery other)
  System.Void SetXsltContext(System.Xml.Xsl.XsltContext context)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathResultType get_StaticType()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.XPathAncestorQuery
TYPE:  class
TOKEN: 0x20002C5
EXTENDS: CacheAxisQuery
FIELDS:
  private           System.Boolean                  _matchSelf  // 0x60
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String name, System.String prefix, System.Xml.XPath.XPathNodeType typeTest, System.Boolean matchSelf)
  System.Void .ctor(MS.Internal.Xml.XPath.XPathAncestorQuery other)
  System.Object Evaluate(System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Int32 get_CurrentPosition()
  MS.Internal.Xml.XPath.QueryProps get_Properties()
END_CLASS

CLASS: MS.Internal.Xml.XPath.XPathArrayIterator
TYPE:  class
TOKEN: 0x20002C6
EXTENDS: ResetableIterator
FIELDS:
  protected         System.Collections.IList        list  // 0x18
  protected         System.Int32                    index  // 0x20
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.XPathArrayIterator it)
  System.Void .ctor(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
  System.Int32 get_Count()
  System.Boolean MoveNext()
  System.Void Reset()
  System.Collections.IEnumerator GetEnumerator()
END_CLASS

CLASS: MS.Internal.Xml.XPath.XPathAxisIterator
TYPE:  class
TOKEN: 0x20002C7
EXTENDS: XPathNodeIterator
FIELDS:
  private           System.Xml.XPath.XPathNavigator nav  // 0x18
  private           System.Xml.XPath.XPathNodeType  type  // 0x20
  private           System.String                   name  // 0x28
  private           System.String                   uri  // 0x30
  private           System.Int32                    position  // 0x38
  private           System.Boolean                  matchSelf  // 0x3C
  private           System.Boolean                  first  // 0x3D
METHODS:
  System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.Boolean matchSelf)
  System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.Xml.XPath.XPathNodeType type, System.Boolean matchSelf)
  System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.String name, System.String namespaceURI, System.Boolean matchSelf)
  System.Void .ctor(MS.Internal.Xml.XPath.XPathAxisIterator it)
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
  System.Boolean get_Matches()
END_CLASS

CLASS: MS.Internal.Xml.XPath.XPathChildIterator
TYPE:  class
TOKEN: 0x20002C8
EXTENDS: XPathAxisIterator
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.Xml.XPath.XPathNodeType type)
  System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.String name, System.String namespaceURI)
  System.Void .ctor(MS.Internal.Xml.XPath.XPathChildIterator it)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean MoveNext()
END_CLASS

CLASS: MS.Internal.Xml.XPath.XPathDescendantIterator
TYPE:  class
TOKEN: 0x20002C9
EXTENDS: XPathAxisIterator
FIELDS:
  private           System.Int32                    _level  // 0x40
METHODS:
  System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.Xml.XPath.XPathNodeType type, System.Boolean matchSelf)
  System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.String name, System.String namespaceURI, System.Boolean matchSelf)
  System.Void .ctor(MS.Internal.Xml.XPath.XPathDescendantIterator it)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean MoveNext()
END_CLASS

CLASS: MS.Internal.Xml.XPath.XPathEmptyIterator
TYPE:  class
TOKEN: 0x20002CA
EXTENDS: ResetableIterator
FIELDS:
  public    static  MS.Internal.Xml.XPath.XPathEmptyIteratorInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
  System.Int32 get_Count()
  System.Boolean MoveNext()
  System.Void Reset()
  System.Void .cctor()
END_CLASS

CLASS: MS.Internal.Xml.XPath.XPathParser
TYPE:  class
TOKEN: 0x20002CB
FIELDS:
  private           MS.Internal.Xml.XPath.XPathScanner_scanner  // 0x10
  private           System.Int32                    _parseDepth  // 0x18
  private   static readonly System.Xml.XPath.XPathResultType[]s_temparray1  // 0x0
  private   static readonly System.Xml.XPath.XPathResultType[]s_temparray2  // 0x8
  private   static readonly System.Xml.XPath.XPathResultType[]s_temparray3  // 0x10
  private   static readonly System.Xml.XPath.XPathResultType[]s_temparray4  // 0x18
  private   static readonly System.Xml.XPath.XPathResultType[]s_temparray5  // 0x20
  private   static readonly System.Xml.XPath.XPathResultType[]s_temparray6  // 0x28
  private   static readonly System.Xml.XPath.XPathResultType[]s_temparray7  // 0x30
  private   static readonly System.Xml.XPath.XPathResultType[]s_temparray8  // 0x38
  private   static readonly System.Xml.XPath.XPathResultType[]s_temparray9  // 0x40
  private   static  System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.XPathParser.ParamInfo>s_functionTable  // 0x48
  private   static  System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.Axis.AxisType>s_AxesTable  // 0x50
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.XPathScanner scanner)
  MS.Internal.Xml.XPath.AstNode ParseXPathExpression(System.String xpathExpression)
  MS.Internal.Xml.XPath.AstNode ParseExpression(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseOrExpr(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseAndExpr(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseEqualityExpr(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseRelationalExpr(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseAdditiveExpr(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseMultiplicativeExpr(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseUnaryExpr(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseUnionExpr(MS.Internal.Xml.XPath.AstNode qyInput)
  System.Boolean IsNodeType(MS.Internal.Xml.XPath.XPathScanner scaner)
  MS.Internal.Xml.XPath.AstNode ParsePathExpr(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseFilterExpr(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParsePredicate(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseLocationPath(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseRelativeLocationPath(MS.Internal.Xml.XPath.AstNode qyInput)
  System.Boolean IsStep(MS.Internal.Xml.XPath.XPathScanner.LexKind lexKind)
  MS.Internal.Xml.XPath.AstNode ParseStep(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseNodeTest(MS.Internal.Xml.XPath.AstNode qyInput, MS.Internal.Xml.XPath.Axis.AxisType axisType, System.Xml.XPath.XPathNodeType nodeType)
  System.Boolean IsPrimaryExpr(MS.Internal.Xml.XPath.XPathScanner scanner)
  MS.Internal.Xml.XPath.AstNode ParsePrimaryExpr(MS.Internal.Xml.XPath.AstNode qyInput)
  MS.Internal.Xml.XPath.AstNode ParseMethod(MS.Internal.Xml.XPath.AstNode qyInput)
  System.Void CheckToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t)
  System.Void PassToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t)
  System.Void NextLex()
  System.Boolean TestOp(System.String op)
  System.Void CheckNodeSet(System.Xml.XPath.XPathResultType t)
  System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.XPathParser.ParamInfo> CreateFunctionTable()
  System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable()
  MS.Internal.Xml.XPath.Axis.AxisType GetAxis()
  System.Void .cctor()
END_CLASS

CLASS: MS.Internal.Xml.XPath.XPathScanner
TYPE:  class
TOKEN: 0x20002CD
FIELDS:
  private           System.String                   _xpathExpr  // 0x10
  private           System.Int32                    _xpathExprIndex  // 0x18
  private           MS.Internal.Xml.XPath.XPathScanner.LexKind_kind  // 0x1C
  private           System.Char                     _currentChar  // 0x20
  private           System.String                   _name  // 0x28
  private           System.String                   _prefix  // 0x30
  private           System.String                   _stringValue  // 0x38
  private           System.Double                   _numberValue  // 0x40
  private           System.Boolean                  _canBeFunction  // 0x48
  private           System.Xml.XmlCharType          _xmlCharType  // 0x50
METHODS:
  System.Void .ctor(System.String xpathExpr)
  System.String get_SourceText()
  System.Char get_CurrentChar()
  System.Boolean NextChar()
  MS.Internal.Xml.XPath.XPathScanner.LexKind get_Kind()
  System.String get_Name()
  System.String get_Prefix()
  System.String get_StringValue()
  System.Double get_NumberValue()
  System.Boolean get_CanBeFunction()
  System.Void SkipSpace()
  System.Boolean NextLex()
  System.Double ScanNumber()
  System.Double ScanFraction()
  System.String ScanString()
  System.String ScanName()
END_CLASS

CLASS: MS.Internal.Xml.XPath.XPathSelectionIterator
TYPE:  class
TOKEN: 0x20002CF
EXTENDS: ResetableIterator
FIELDS:
  private           System.Xml.XPath.XPathNavigator _nav  // 0x18
  private           MS.Internal.Xml.XPath.Query     _query  // 0x20
  private           System.Int32                    _position  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XPath.XPathNavigator nav, MS.Internal.Xml.XPath.Query query)
  System.Void .ctor(MS.Internal.Xml.XPath.XPathSelectionIterator it)
  System.Void Reset()
  System.Boolean MoveNext()
  System.Int32 get_Count()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.XPathSelfQuery
TYPE:  class
TOKEN: 0x20002D0
EXTENDS: BaseAxisQuery
FIELDS:
METHODS:
  System.Void .ctor(MS.Internal.Xml.XPath.Query qyInput, System.String Name, System.String Prefix, System.Xml.XPath.XPathNodeType Type)
  System.Void .ctor(MS.Internal.Xml.XPath.XPathSelfQuery other)
  System.Xml.XPath.XPathNavigator Advance()
  System.Xml.XPath.XPathNodeIterator Clone()
END_CLASS

CLASS: MS.Internal.Xml.XPath.XPathSingletonIterator
TYPE:  class
TOKEN: 0x20002D1
EXTENDS: ResetableIterator
FIELDS:
  private           System.Xml.XPath.XPathNavigator _nav  // 0x18
  private           System.Int32                    _position  // 0x20
METHODS:
  System.Void .ctor(System.Xml.XPath.XPathNavigator nav)
  System.Void .ctor(System.Xml.XPath.XPathNavigator nav, System.Boolean moved)
  System.Void .ctor(MS.Internal.Xml.XPath.XPathSingletonIterator it)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
  System.Int32 get_Count()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: Microsoft.CSharp.CodeDomProvider
TYPE:  class
TOKEN: 0x2000003
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Microsoft.CSharp.CSharpCodeProvider
TYPE:  class
TOKEN: 0x2000004
EXTENDS: CodeDomProvider
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.MonoTODOAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.LocalAppContextSwitches
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  public    static readonly System.Boolean                  IgnoreEmptyKeySequences  // 0x0
  public    static readonly System.Boolean                  DontThrowOnInvalidSurrogatePairs  // 0x1
METHODS:
END_CLASS

CLASS: System.Xml.AsyncHelper
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  public    static readonly System.Threading.Tasks.Task     DoneTask  // 0x0
  public    static readonly System.Threading.Tasks.Task<System.Boolean>DoneTaskTrue  // 0x8
  public    static readonly System.Threading.Tasks.Task<System.Boolean>DoneTaskFalse  // 0x10
  public    static readonly System.Threading.Tasks.Task<System.Int32>DoneTaskZero  // 0x18
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Base64Encoder
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private           System.Byte[]                   leftOverBytes  // 0x10
  private           System.Int32                    leftOverBytesCount  // 0x18
  private           System.Char[]                   charsLine  // 0x20
METHODS:
  System.Void .ctor()
  System.Void WriteChars(System.Char[] chars, System.Int32 index, System.Int32 count)
  System.Void Encode(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Void Flush()
END_CLASS

CLASS: System.Xml.XmlRawWriterBase64Encoder
TYPE:  class
TOKEN: 0x2000009
EXTENDS: Base64Encoder
FIELDS:
  private           System.Xml.XmlRawWriter         rawWriter  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XmlRawWriter rawWriter)
  System.Void WriteChars(System.Char[] chars, System.Int32 index, System.Int32 count)
END_CLASS

CLASS: System.Xml.XmlTextWriterBase64Encoder
TYPE:  class
TOKEN: 0x200000A
EXTENDS: Base64Encoder
FIELDS:
  private           System.Xml.XmlTextEncoder       xmlTextEncoder  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XmlTextEncoder xmlTextEncoder)
  System.Void WriteChars(System.Char[] chars, System.Int32 index, System.Int32 count)
END_CLASS

CLASS: System.Xml.BinHexDecoder
TYPE:  class
TOKEN: 0x200000B
EXTENDS: IncrementalReadDecoder
FIELDS:
  private           System.Byte[]                   buffer  // 0x10
  private           System.Int32                    curIndex  // 0x18
  private           System.Int32                    endIndex  // 0x1C
  private           System.Boolean                  hasHalfByteCached  // 0x20
  private           System.Byte                     cachedHalfByte  // 0x21
METHODS:
  System.Boolean get_IsFull()
  System.Int32 Decode(System.Char[] chars, System.Int32 startPos, System.Int32 len)
  System.Byte[] Decode(System.Char[] chars, System.Boolean allowOddChars)
  System.Void Decode(System.Char* pChars, System.Char* pCharsEndPos, System.Byte* pBytes, System.Byte* pBytesEndPos, System.Boolean& hasHalfByteCached, System.Byte& cachedHalfByte, System.Int32& charsDecoded, System.Int32& bytesDecoded)
END_CLASS

CLASS: System.Xml.BinHexEncoder
TYPE:  class
TOKEN: 0x200000C
FIELDS:
METHODS:
  System.Void Encode(System.Byte[] buffer, System.Int32 index, System.Int32 count, System.Xml.XmlWriter writer)
  System.String Encode(System.Byte[] inArray, System.Int32 offsetIn, System.Int32 count)
  System.Int32 Encode(System.Byte[] inArray, System.Int32 offsetIn, System.Int32 count, System.Char[] outArray)
END_CLASS

CLASS: System.Xml.BinXmlToken
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.BinXmlToken          Error  // 0x0
  public    static  System.Xml.BinXmlToken          NotImpl  // 0x0
  public    static  System.Xml.BinXmlToken          EOF  // 0x0
  public    static  System.Xml.BinXmlToken          XmlDecl  // 0x0
  public    static  System.Xml.BinXmlToken          Encoding  // 0x0
  public    static  System.Xml.BinXmlToken          DocType  // 0x0
  public    static  System.Xml.BinXmlToken          System  // 0x0
  public    static  System.Xml.BinXmlToken          Public  // 0x0
  public    static  System.Xml.BinXmlToken          Subset  // 0x0
  public    static  System.Xml.BinXmlToken          Element  // 0x0
  public    static  System.Xml.BinXmlToken          EndElem  // 0x0
  public    static  System.Xml.BinXmlToken          Attr  // 0x0
  public    static  System.Xml.BinXmlToken          EndAttrs  // 0x0
  public    static  System.Xml.BinXmlToken          PI  // 0x0
  public    static  System.Xml.BinXmlToken          Comment  // 0x0
  public    static  System.Xml.BinXmlToken          CData  // 0x0
  public    static  System.Xml.BinXmlToken          EndCData  // 0x0
  public    static  System.Xml.BinXmlToken          Name  // 0x0
  public    static  System.Xml.BinXmlToken          QName  // 0x0
  public    static  System.Xml.BinXmlToken          XmlText  // 0x0
  public    static  System.Xml.BinXmlToken          Nest  // 0x0
  public    static  System.Xml.BinXmlToken          EndNest  // 0x0
  public    static  System.Xml.BinXmlToken          Extn  // 0x0
  public    static  System.Xml.BinXmlToken          NmFlush  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_BIT  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_TINYINT  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_SMALLINT  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_INT  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_BIGINT  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_REAL  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_FLOAT  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_MONEY  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_SMALLMONEY  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_DATETIME  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_SMALLDATETIME  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_DECIMAL  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_NUMERIC  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_UUID  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_VARBINARY  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_BINARY  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_IMAGE  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_CHAR  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_VARCHAR  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_TEXT  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_NVARCHAR  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_NCHAR  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_NTEXT  // 0x0
  public    static  System.Xml.BinXmlToken          SQL_UDT  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_KATMAI_DATE  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_KATMAI_DATETIME  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_KATMAI_TIME  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_KATMAI_DATEOFFSET  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_KATMAI_DATETIMEOFFSET  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_KATMAI_TIMEOFFSET  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_BOOLEAN  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_TIME  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_DATETIME  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_DATE  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_BINHEX  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_BASE64  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_DECIMAL  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_BYTE  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_UNSIGNEDSHORT  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_UNSIGNEDINT  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_UNSIGNEDLONG  // 0x0
  public    static  System.Xml.BinXmlToken          XSD_QNAME  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.BinXmlSqlDecimal
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  private           System.Byte                     m_bLen  // 0x10
  private           System.Byte                     m_bPrec  // 0x11
  private           System.Byte                     m_bScale  // 0x12
  private           System.Byte                     m_bSign  // 0x13
  private           System.UInt32                   m_data1  // 0x14
  private           System.UInt32                   m_data2  // 0x18
  private           System.UInt32                   m_data3  // 0x1C
  private           System.UInt32                   m_data4  // 0x20
  private   static readonly System.Byte                     NUMERIC_MAX_PRECISION  // 0x0
  private   static readonly System.Byte                     MaxPrecision  // 0x1
  private   static readonly System.Byte                     MaxScale  // 0x2
  private   static readonly System.Int32                    x_cNumeMax  // 0x4
  private   static readonly System.Int64                    x_lInt32Base  // 0x8
  private   static readonly System.UInt64                   x_ulInt32Base  // 0x10
  private   static readonly System.UInt64                   x_ulInt32BaseForMod  // 0x18
  private   static readonly System.UInt64                   x_llMax  // 0x20
  private   static readonly System.Double                   DUINT_BASE  // 0x28
  private   static readonly System.Double                   DUINT_BASE2  // 0x30
  private   static readonly System.Double                   DUINT_BASE3  // 0x38
  private   static readonly System.UInt32[]                 x_rgulShiftBase  // 0x40
  private   static readonly System.Byte[]                   rgCLenFromPrec  // 0x48
METHODS:
  System.Boolean get_IsPositive()
  System.Void .ctor(System.Byte[] data, System.Int32 offset, System.Boolean trim)
  System.UInt32 UIntFromByteArray(System.Byte[] data, System.Int32 offset)
  System.Void MpDiv1(System.UInt32[] rgulU, System.Int32& ciulU, System.UInt32 iulD, System.UInt32& iulR)
  System.Void MpNormalize(System.UInt32[] rgulU, System.Int32& ciulU)
  System.Char ChFromDigit(System.UInt32 uiDigit)
  System.Decimal ToDecimal()
  System.Void TrimTrailingZeros()
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.BinXmlSqlMoney
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  private           System.Int64                    data  // 0x10
METHODS:
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Int64 v)
  System.Decimal ToDecimal()
  System.String ToString()
END_CLASS

CLASS: System.Xml.BinXmlDateTime
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private   static  System.Int32[]                  KatmaiTimeScaleMultiplicator  // 0x0
  private   static readonly System.Double                   SQLTicksPerMillisecond  // 0x8
  public    static readonly System.Int32                    SQLTicksPerSecond  // 0x10
  public    static readonly System.Int32                    SQLTicksPerMinute  // 0x14
  public    static readonly System.Int32                    SQLTicksPerHour  // 0x18
  private   static readonly System.Int32                    SQLTicksPerDay  // 0x1C
METHODS:
  System.Void Write2Dig(System.Text.StringBuilder sb, System.Int32 val)
  System.Void Write4DigNeg(System.Text.StringBuilder sb, System.Int32 val)
  System.Void Write3Dec(System.Text.StringBuilder sb, System.Int32 val)
  System.Void WriteDate(System.Text.StringBuilder sb, System.Int32 yr, System.Int32 mnth, System.Int32 day)
  System.Void WriteTime(System.Text.StringBuilder sb, System.Int32 hr, System.Int32 min, System.Int32 sec, System.Int32 ms)
  System.Void WriteTimeFullPrecision(System.Text.StringBuilder sb, System.Int32 hr, System.Int32 min, System.Int32 sec, System.Int32 fraction)
  System.Void WriteTimeZone(System.Text.StringBuilder sb, System.TimeSpan zone)
  System.Void WriteTimeZone(System.Text.StringBuilder sb, System.Boolean negTimeZone, System.Int32 hr, System.Int32 min)
  System.Void BreakDownXsdDateTime(System.Int64 val, System.Int32& yr, System.Int32& mnth, System.Int32& day, System.Int32& hr, System.Int32& min, System.Int32& sec, System.Int32& ms)
  System.Void BreakDownXsdDate(System.Int64 val, System.Int32& yr, System.Int32& mnth, System.Int32& day, System.Boolean& negTimeZone, System.Int32& hr, System.Int32& min)
  System.Void BreakDownXsdTime(System.Int64 val, System.Int32& hr, System.Int32& min, System.Int32& sec, System.Int32& ms)
  System.String XsdDateTimeToString(System.Int64 val)
  System.String XsdDateToString(System.Int64 val)
  System.String XsdTimeToString(System.Int64 val)
  System.String SqlDateTimeToString(System.Int32 dateticks, System.UInt32 timeticks)
  System.DateTime SqlDateTimeToDateTime(System.Int32 dateticks, System.UInt32 timeticks)
  System.String SqlSmallDateTimeToString(System.Int16 dateticks, System.UInt16 timeticks)
  System.DateTime SqlSmallDateTimeToDateTime(System.Int16 dateticks, System.UInt16 timeticks)
  System.DateTime XsdKatmaiDateToDateTime(System.Byte[] data, System.Int32 offset)
  System.DateTime XsdKatmaiDateTimeToDateTime(System.Byte[] data, System.Int32 offset)
  System.DateTime XsdKatmaiTimeToDateTime(System.Byte[] data, System.Int32 offset)
  System.DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(System.Byte[] data, System.Int32 offset)
  System.DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(System.Byte[] data, System.Int32 offset)
  System.DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(System.Byte[] data, System.Int32 offset)
  System.String XsdKatmaiDateToString(System.Byte[] data, System.Int32 offset)
  System.String XsdKatmaiDateTimeToString(System.Byte[] data, System.Int32 offset)
  System.String XsdKatmaiTimeToString(System.Byte[] data, System.Int32 offset)
  System.String XsdKatmaiDateOffsetToString(System.Byte[] data, System.Int32 offset)
  System.String XsdKatmaiDateTimeOffsetToString(System.Byte[] data, System.Int32 offset)
  System.String XsdKatmaiTimeOffsetToString(System.Byte[] data, System.Int32 offset)
  System.Int64 GetKatmaiDateTicks(System.Byte[] data, System.Int32& pos)
  System.Int64 GetKatmaiTimeTicks(System.Byte[] data, System.Int32& pos)
  System.Int64 GetKatmaiTimeZoneTicks(System.Byte[] data, System.Int32 pos)
  System.Int32 GetFractions(System.DateTime dt)
  System.Int32 GetFractions(System.DateTimeOffset dt)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.XmlSqlBinaryReader
TYPE:  class
TOKEN: 0x2000011
EXTENDS: XmlReader
FIELDS:
  private   static readonly System.Type                     TypeOfObject  // 0x0
  private   static readonly System.Type                     TypeOfString  // 0x8
  private   static  System.Type[]                   TokenTypeMap  // 0x10
  private   static  System.Byte[]                   XsdKatmaiTimeScaleToValueLengthMap  // 0x18
  private   static  System.Xml.ReadState[]          ScanState2ReadState  // 0x20
  private           System.IO.Stream                inStrm  // 0x10
  private           System.Byte[]                   data  // 0x18
  private           System.Int32                    pos  // 0x20
  private           System.Int32                    mark  // 0x24
  private           System.Int32                    end  // 0x28
  private           System.Int64                    offset  // 0x30
  private           System.Boolean                  eof  // 0x38
  private           System.Boolean                  sniffed  // 0x39
  private           System.Boolean                  isEmpty  // 0x3A
  private           System.Int32                    docState  // 0x3C
  private           System.Xml.XmlSqlBinaryReader.SymbolTablessymbolTables  // 0x40
  private           System.Xml.XmlNameTable         xnt  // 0x60
  private           System.Boolean                  xntFromSettings  // 0x68
  private           System.String                   xml  // 0x70
  private           System.String                   xmlns  // 0x78
  private           System.String                   nsxmlns  // 0x80
  private           System.String                   baseUri  // 0x88
  private           System.Xml.XmlSqlBinaryReader.ScanStatestate  // 0x90
  private           System.Xml.XmlNodeType          nodetype  // 0x94
  private           System.Xml.BinXmlToken          token  // 0x98
  private           System.Int32                    attrIndex  // 0x9C
  private           System.Xml.XmlSqlBinaryReader.QNameqnameOther  // 0xA0
  private           System.Xml.XmlSqlBinaryReader.QNameqnameElement  // 0xB8
  private           System.Xml.XmlNodeType          parentNodeType  // 0xD0
  private           System.Xml.XmlSqlBinaryReader.ElemInfo[]elementStack  // 0xD8
  private           System.Int32                    elemDepth  // 0xE0
  private           System.Xml.XmlSqlBinaryReader.AttrInfo[]attributes  // 0xE8
  private           System.Int32[]                  attrHashTbl  // 0xF0
  private           System.Int32                    attrCount  // 0xF8
  private           System.Int32                    posAfterAttrs  // 0xFC
  private           System.Boolean                  xmlspacePreserve  // 0x100
  private           System.Int32                    tokLen  // 0x104
  private           System.Int32                    tokDataPos  // 0x108
  private           System.Boolean                  hasTypedValue  // 0x10C
  private           System.Type                     valueType  // 0x110
  private           System.String                   stringValue  // 0x118
  private           System.Collections.Generic.Dictionary<System.String,System.Xml.XmlSqlBinaryReader.NamespaceDecl>namespaces  // 0x120
  private           System.Xml.XmlSqlBinaryReader.NestedBinXmlprevNameInfo  // 0x128
  private           System.Xml.XmlReader            textXmlReader  // 0x130
  private           System.Boolean                  closeInput  // 0x138
  private           System.Boolean                  checkCharacters  // 0x139
  private           System.Boolean                  ignoreWhitespace  // 0x13A
  private           System.Boolean                  ignorePIs  // 0x13B
  private           System.Boolean                  ignoreComments  // 0x13C
  private           System.Xml.DtdProcessing        dtdProcessing  // 0x140
  private           System.Xml.SecureStringHasher   hasher  // 0x148
  private           System.Xml.XmlCharType          xmlCharType  // 0x150
  private           System.Text.Encoding            unicode  // 0x158
  private           System.Byte                     version  // 0x160
METHODS:
  System.Void .ctor(System.IO.Stream stream, System.Byte[] data, System.Int32 len, System.String baseUri, System.Boolean closeInput, System.Xml.XmlReaderSettings settings)
  System.Xml.XmlReaderSettings get_Settings()
  System.Xml.XmlNodeType get_NodeType()
  System.String get_LocalName()
  System.String get_NamespaceURI()
  System.String get_Prefix()
  System.Boolean get_HasValue()
  System.String get_Value()
  System.Int32 get_Depth()
  System.String get_BaseURI()
  System.Boolean get_IsEmptyElement()
  System.Xml.XmlSpace get_XmlSpace()
  System.String get_XmlLang()
  System.Type get_ValueType()
  System.Int32 get_AttributeCount()
  System.String GetAttribute(System.String name, System.String ns)
  System.String GetAttribute(System.String name)
  System.String GetAttribute(System.Int32 i)
  System.Boolean MoveToAttribute(System.String name)
  System.Void MoveToAttribute(System.Int32 i)
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
  System.Boolean MoveToElement()
  System.Boolean get_EOF()
  System.Boolean ReadAttributeValue()
  System.Void Close()
  System.Xml.XmlNameTable get_NameTable()
  System.String LookupNamespace(System.String prefix)
  System.Void ResolveEntity()
  System.Xml.ReadState get_ReadState()
  System.Boolean Read()
  System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName)
  System.Void VerifyVersion(System.Int32 requiredVersion, System.Xml.BinXmlToken token)
  System.Void AddInitNamespace(System.String prefix, System.String uri)
  System.Void AddName()
  System.Void AddQName()
  System.Void NameFlush()
  System.Void SkipExtn()
  System.Int32 ReadQNameRef()
  System.Int32 ReadNameRef()
  System.Boolean FillAllowEOF()
  System.Void Fill_(System.Int32 require)
  System.Void Fill(System.Int32 require)
  System.Byte ReadByte()
  System.UInt16 ReadUShort()
  System.Int32 ParseMB32()
  System.Int32 ParseMB32_(System.Byte b)
  System.Int32 ParseMB32(System.Int32 pos)
  System.Int32 ParseMB64()
  System.Xml.BinXmlToken PeekToken()
  System.Xml.BinXmlToken ReadToken()
  System.Xml.BinXmlToken NextToken2(System.Xml.BinXmlToken token)
  System.Xml.BinXmlToken NextToken1()
  System.Xml.BinXmlToken NextToken()
  System.Xml.BinXmlToken PeekNextToken()
  System.Xml.BinXmlToken RescanNextToken()
  System.String ParseText()
  System.Int32 ScanText(System.Int32& start)
  System.String GetString(System.Int32 pos, System.Int32 cch)
  System.String GetStringAligned(System.Byte[] data, System.Int32 offset, System.Int32 cch)
  System.String GetAttributeText(System.Int32 i)
  System.Int32 LocateAttribute(System.String name, System.String ns)
  System.Int32 LocateAttribute(System.String name)
  System.Void PositionOnAttribute(System.Int32 i)
  System.Void GrowElements()
  System.Void GrowAttributes()
  System.Void ClearAttributes()
  System.Void PushNamespace(System.String prefix, System.String ns, System.Boolean implied)
  System.Void PopNamespaces(System.Xml.XmlSqlBinaryReader.NamespaceDecl firstInScopeChain)
  System.Void GenerateImpliedXmlnsAttrs()
  System.Boolean ReadInit(System.Boolean skipXmlDecl)
  System.Void ScanAttributes()
  System.Void SimpleCheckForDuplicateAttributes()
  System.Void HashCheckForDuplicateAttributes()
  System.String XmlDeclValue()
  System.String CDATAValue()
  System.Void FinishCDATA()
  System.Void FinishEndElement()
  System.Boolean ReadDoc()
  System.Void ImplReadData(System.Xml.BinXmlToken tokenType)
  System.Void ImplReadElement()
  System.Void ImplReadEndElement()
  System.Void ImplReadDoctype()
  System.Void ImplReadPI()
  System.Void ImplReadComment()
  System.Void ImplReadCDATA()
  System.Void ImplReadNest()
  System.Void ImplReadEndNest()
  System.Void ImplReadXmlText()
  System.Void UpdateFromTextReader()
  System.Boolean UpdateFromTextReader(System.Boolean needUpdate)
  System.Void CheckAllowContent()
  System.Void GenerateTokenTypeMap()
  System.Type GetValueType(System.Xml.BinXmlToken token)
  System.Void ReScanOverValue(System.Xml.BinXmlToken token)
  System.Xml.XmlNodeType ScanOverValue(System.Xml.BinXmlToken token, System.Boolean attr, System.Boolean checkChars)
  System.Xml.XmlNodeType ScanOverAnyValue(System.Xml.BinXmlToken token, System.Boolean attr, System.Boolean checkChars)
  System.Xml.XmlNodeType CheckText(System.Boolean attr)
  System.Xml.XmlNodeType CheckTextIsWS()
  System.Void CheckValueTokenBounds()
  System.Int32 GetXsdKatmaiTokenLength(System.Xml.BinXmlToken token)
  System.Int32 XsdKatmaiTimeScaleToValueLength(System.Byte scale)
  System.Int64 ValueAsLong()
  System.UInt64 ValueAsULong()
  System.Decimal ValueAsDecimal()
  System.Double ValueAsDouble()
  System.String ValueAsDateTimeString()
  System.String ValueAsString(System.Xml.BinXmlToken token)
  System.Int16 GetInt16(System.Int32 pos)
  System.UInt16 GetUInt16(System.Int32 pos)
  System.Int32 GetInt32(System.Int32 pos)
  System.UInt32 GetUInt32(System.Int32 pos)
  System.Int64 GetInt64(System.Int32 pos)
  System.UInt64 GetUInt64(System.Int32 pos)
  System.Single GetSingle(System.Int32 offset)
  System.Double GetDouble(System.Int32 offset)
  System.Exception ThrowUnexpectedToken(System.Xml.BinXmlToken token)
  System.Exception ThrowXmlException(System.String res)
  System.Exception ThrowXmlException(System.String res, System.String arg1, System.String arg2)
  System.Exception ThrowNotSupported(System.String res)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.BitStack
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  private           System.UInt32[]                 bitStack  // 0x10
  private           System.Int32                    stackPos  // 0x18
  private           System.UInt32                   curr  // 0x1C
METHODS:
  System.Void .ctor()
  System.Void PushBit(System.Boolean bit)
  System.Boolean PopBit()
  System.Boolean PeekBit()
  System.Void PushCurr()
  System.Void PopCurr()
END_CLASS

CLASS: System.Xml.Bits
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private   static readonly System.UInt32                   MASK_0101010101010101  // 0x0
  private   static readonly System.UInt32                   MASK_0011001100110011  // 0x4
  private   static readonly System.UInt32                   MASK_0000111100001111  // 0x8
  private   static readonly System.UInt32                   MASK_0000000011111111  // 0xC
  private   static readonly System.UInt32                   MASK_1111111111111111  // 0x10
METHODS:
  System.Int32 Count(System.UInt32 num)
  System.Int32 LeastPosition(System.UInt32 num)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.ByteStack
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  private           System.Byte[]                   stack  // 0x10
  private           System.Int32                    growthRate  // 0x18
  private           System.Int32                    top  // 0x1C
  private           System.Int32                    size  // 0x20
METHODS:
  System.Void .ctor(System.Int32 growthRate)
  System.Void Push(System.Byte data)
  System.Byte Pop()
END_CLASS

CLASS: System.Xml.CharEntityEncoderFallback
TYPE:  class
TOKEN: 0x200001C
EXTENDS: EncoderFallback
FIELDS:
  private           System.Xml.CharEntityEncoderFallbackBufferfallbackBuffer  // 0x10
  private           System.Int32[]                  textContentMarks  // 0x18
  private           System.Int32                    endMarkPos  // 0x20
  private           System.Int32                    curMarkPos  // 0x24
  private           System.Int32                    startOffset  // 0x28
METHODS:
  System.Void .ctor()
  System.Text.EncoderFallbackBuffer CreateFallbackBuffer()
  System.Int32 get_MaxCharCount()
  System.Void set_StartOffset(System.Int32 value)
  System.Void Reset(System.Int32[] textContentMarks, System.Int32 endMarkPos)
  System.Boolean CanReplaceAt(System.Int32 index)
END_CLASS

CLASS: System.Xml.CharEntityEncoderFallbackBuffer
TYPE:  class
TOKEN: 0x200001D
EXTENDS: EncoderFallbackBuffer
FIELDS:
  private           System.Xml.CharEntityEncoderFallbackparent  // 0x30
  private           System.String                   charEntity  // 0x38
  private           System.Int32                    charEntityIndex  // 0x40
METHODS:
  System.Void .ctor(System.Xml.CharEntityEncoderFallback parent)
  System.Boolean Fallback(System.Char charUnknown, System.Int32 index)
  System.Boolean Fallback(System.Char charUnknownHigh, System.Char charUnknownLow, System.Int32 index)
  System.Char GetNextChar()
  System.Boolean MovePrevious()
  System.Int32 get_Remaining()
  System.Void Reset()
  System.Int32 SurrogateCharToUtf32(System.Char highSurrogate, System.Char lowSurrogate)
END_CLASS

CLASS: System.Xml.ConformanceLevel
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.ConformanceLevel     Auto  // 0x0
  public    static  System.Xml.ConformanceLevel     Fragment  // 0x0
  public    static  System.Xml.ConformanceLevel     Document  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.DtdProcessing
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.DtdProcessing        Prohibit  // 0x0
  public    static  System.Xml.DtdProcessing        Ignore  // 0x0
  public    static  System.Xml.DtdProcessing        Parse  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.EntityHandling
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.EntityHandling       ExpandEntities  // 0x0
  public    static  System.Xml.EntityHandling       ExpandCharEntities  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.HtmlEncodedRawTextWriter
TYPE:  class
TOKEN: 0x2000021
EXTENDS: XmlEncodedRawTextWriter
FIELDS:
  protected         System.Xml.ByteStack            elementScope  // 0xC0
  protected         System.Xml.ElementProperties    currentElementProperties  // 0xC8
  private           System.Xml.AttributeProperties  currentAttributeProperties  // 0xCC
  private           System.Boolean                  endsWithAmpersand  // 0xD0
  private           System.Byte[]                   uriEscapingBuffer  // 0xD8
  private           System.String                   mediaType  // 0xE0
  private           System.Boolean                  doNotEscapeUriAttributes  // 0xE8
  protected static  System.Xml.TernaryTreeReadOnly  elementPropertySearch  // 0x0
  protected static  System.Xml.TernaryTreeReadOnly  attributePropertySearch  // 0x8
METHODS:
  System.Void .ctor(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings)
  System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings)
  System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone)
  System.Void WriteXmlDeclaration(System.String xmldecl)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void StartElementContent()
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndAttribute()
  System.Void WriteProcessingInstruction(System.String target, System.String text)
  System.Void WriteString(System.String text)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void Init(System.Xml.XmlWriterSettings settings)
  System.Void WriteMetaElement()
  System.Void WriteHtmlElementTextBlock(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void WriteHtmlAttributeTextBlock(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void WriteHtmlAttributeText(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void WriteUriAttributeText(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void OutputRestAmps()
END_CLASS

CLASS: System.Xml.HtmlEncodedRawTextWriterIndent
TYPE:  class
TOKEN: 0x2000022
EXTENDS: HtmlEncodedRawTextWriter
FIELDS:
  private           System.Int32                    indentLevel  // 0xF0
  private           System.Int32                    endBlockPos  // 0xF4
  private           System.String                   indentChars  // 0xF8
  private           System.Boolean                  newLineOnAttributes  // 0x100
METHODS:
  System.Void .ctor(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings)
  System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void StartElementContent()
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void FlushBuffer()
  System.Void Init(System.Xml.XmlWriterSettings settings)
  System.Void WriteIndent()
END_CLASS

CLASS: System.Xml.HtmlTernaryTree
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  private   static  System.Byte[]                   htmlElements  // 0x0
  private   static  System.Byte[]                   htmlAttributes  // 0x8
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.HtmlUtf8RawTextWriter
TYPE:  class
TOKEN: 0x2000024
EXTENDS: XmlUtf8RawTextWriter
FIELDS:
  protected         System.Xml.ByteStack            elementScope  // 0x90
  protected         System.Xml.ElementProperties    currentElementProperties  // 0x98
  private           System.Xml.AttributeProperties  currentAttributeProperties  // 0x9C
  private           System.Boolean                  endsWithAmpersand  // 0xA0
  private           System.Byte[]                   uriEscapingBuffer  // 0xA8
  private           System.String                   mediaType  // 0xB0
  private           System.Boolean                  doNotEscapeUriAttributes  // 0xB8
  protected static  System.Xml.TernaryTreeReadOnly  elementPropertySearch  // 0x0
  protected static  System.Xml.TernaryTreeReadOnly  attributePropertySearch  // 0x8
METHODS:
  System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings)
  System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone)
  System.Void WriteXmlDeclaration(System.String xmldecl)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void StartElementContent()
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndAttribute()
  System.Void WriteProcessingInstruction(System.String target, System.String text)
  System.Void WriteString(System.String text)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void Init(System.Xml.XmlWriterSettings settings)
  System.Void WriteMetaElement()
  System.Void WriteHtmlElementTextBlock(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void WriteHtmlAttributeTextBlock(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void WriteHtmlAttributeText(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void WriteUriAttributeText(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void OutputRestAmps()
END_CLASS

CLASS: System.Xml.HtmlUtf8RawTextWriterIndent
TYPE:  class
TOKEN: 0x2000025
EXTENDS: HtmlUtf8RawTextWriter
FIELDS:
  private           System.Int32                    indentLevel  // 0xC0
  private           System.Int32                    endBlockPos  // 0xC4
  private           System.String                   indentChars  // 0xC8
  private           System.Boolean                  newLineOnAttributes  // 0xD0
METHODS:
  System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void StartElementContent()
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void FlushBuffer()
  System.Void Init(System.Xml.XmlWriterSettings settings)
  System.Void WriteIndent()
END_CLASS

CLASS: System.Xml.IDtdInfo
TYPE:  interface
TOKEN: 0x2000026
FIELDS:
METHODS:
  System.Xml.XmlQualifiedName get_Name()
  System.String get_InternalDtdSubset()
  System.Boolean get_HasDefaultAttributes()
  System.Boolean get_HasNonCDataAttributes()
  System.Xml.IDtdAttributeListInfo LookupAttributeList(System.String prefix, System.String localName)
  System.Xml.IDtdEntityInfo LookupEntity(System.String name)
END_CLASS

CLASS: System.Xml.IDtdAttributeListInfo
TYPE:  interface
TOKEN: 0x2000027
FIELDS:
METHODS:
  System.Boolean get_HasNonCDataAttributes()
  System.Xml.IDtdAttributeInfo LookupAttribute(System.String prefix, System.String localName)
  System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> LookupDefaultAttributes()
END_CLASS

CLASS: System.Xml.IDtdAttributeInfo
TYPE:  interface
TOKEN: 0x2000028
FIELDS:
METHODS:
  System.String get_Prefix()
  System.String get_LocalName()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
  System.Boolean get_IsNonCDataType()
  System.Boolean get_IsDeclaredInExternal()
  System.Boolean get_IsXmlAttribute()
END_CLASS

CLASS: System.Xml.IDtdDefaultAttributeInfo
TYPE:  interface
TOKEN: 0x2000029
FIELDS:
METHODS:
  System.String get_DefaultValueExpanded()
  System.Object get_DefaultValueTyped()
  System.Int32 get_ValueLineNumber()
  System.Int32 get_ValueLinePosition()
END_CLASS

CLASS: System.Xml.IDtdEntityInfo
TYPE:  interface
TOKEN: 0x200002A
FIELDS:
METHODS:
  System.String get_Name()
  System.Boolean get_IsExternal()
  System.Boolean get_IsDeclaredInExternal()
  System.Boolean get_IsUnparsedEntity()
  System.Boolean get_IsParameterEntity()
  System.String get_BaseUriString()
  System.String get_DeclaredUriString()
  System.String get_SystemId()
  System.String get_PublicId()
  System.String get_Text()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
END_CLASS

CLASS: System.Xml.IDtdParser
TYPE:  interface
TOKEN: 0x200002B
FIELDS:
METHODS:
  System.Xml.IDtdInfo ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, System.Boolean saveInternalSubset)
  System.Xml.IDtdInfo ParseFreeFloatingDtd(System.String baseUri, System.String docTypeName, System.String publicId, System.String systemId, System.String internalSubset, System.Xml.IDtdParserAdapter adapter)
END_CLASS

CLASS: System.Xml.IDtdParserAdapter
TYPE:  interface
TOKEN: 0x200002C
FIELDS:
METHODS:
  System.Xml.XmlNameTable get_NameTable()
  System.Xml.IXmlNamespaceResolver get_NamespaceResolver()
  System.Uri get_BaseUri()
  System.Char[] get_ParsingBuffer()
  System.Int32 get_ParsingBufferLength()
  System.Int32 get_CurrentPosition()
  System.Void set_CurrentPosition(System.Int32 value)
  System.Int32 get_LineNo()
  System.Int32 get_LineStartPosition()
  System.Boolean get_IsEof()
  System.Int32 get_EntityStackLength()
  System.Boolean get_IsEntityEolNormalized()
  System.Int32 ReadData()
  System.Void OnNewLine(System.Int32 pos)
  System.Int32 ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder)
  System.Int32 ParseNamedCharRef(System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder)
  System.Void ParsePI(System.Text.StringBuilder sb)
  System.Void ParseComment(System.Text.StringBuilder sb)
  System.Boolean PushEntity(System.Xml.IDtdEntityInfo entity, System.Int32& entityId)
  System.Boolean PopEntity(System.Xml.IDtdEntityInfo& oldEntity, System.Int32& newEntityId)
  System.Boolean PushExternalSubset(System.String systemId, System.String publicId)
  System.Void PushInternalDtd(System.String baseUri, System.String internalDtd)
  System.Void OnSystemId(System.String systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo)
  System.Void OnPublicId(System.String publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo)
  System.Void Throw(System.Exception e)
END_CLASS

CLASS: System.Xml.IDtdParserAdapterWithValidation
TYPE:  interface
TOKEN: 0x200002D
FIELDS:
METHODS:
  System.Boolean get_DtdValidation()
  System.Xml.IValidationEventHandling get_ValidationEventHandling()
END_CLASS

CLASS: System.Xml.IDtdParserAdapterV1
TYPE:  interface
TOKEN: 0x200002E
FIELDS:
METHODS:
  System.Boolean get_V1CompatibilityMode()
  System.Boolean get_Normalization()
  System.Boolean get_Namespaces()
END_CLASS

CLASS: System.Xml.OnRemoveWriter
TYPE:  class
TOKEN: 0x200002F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Xml.XmlRawWriter writer)
END_CLASS

CLASS: System.Xml.IValidationEventHandling
TYPE:  interface
TOKEN: 0x2000030
FIELDS:
METHODS:
  System.Object get_EventHandler()
  System.Void SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity)
END_CLASS

CLASS: System.Xml.IncrementalReadDecoder
TYPE:  class
TOKEN: 0x2000031
FIELDS:
METHODS:
  System.Boolean get_IsFull()
  System.Int32 Decode(System.Char[] chars, System.Int32 startPos, System.Int32 len)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.IncrementalReadDummyDecoder
TYPE:  class
TOKEN: 0x2000032
EXTENDS: IncrementalReadDecoder
FIELDS:
METHODS:
  System.Boolean get_IsFull()
  System.Int32 Decode(System.Char[] chars, System.Int32 startPos, System.Int32 len)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.NamespaceHandling
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.NamespaceHandling    Default  // 0x0
  public    static  System.Xml.NamespaceHandling    OmitDuplicates  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.NewLineHandling
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.NewLineHandling      Replace  // 0x0
  public    static  System.Xml.NewLineHandling      Entitize  // 0x0
  public    static  System.Xml.NewLineHandling      None  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.QueryOutputWriter
TYPE:  class
TOKEN: 0x2000035
EXTENDS: XmlRawWriter
FIELDS:
  private           System.Xml.XmlRawWriter         wrapped  // 0x28
  private           System.Boolean                  inCDataSection  // 0x30
  private           System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Int32>lookupCDataElems  // 0x38
  private           System.Xml.BitStack             bitsCData  // 0x40
  private           System.Xml.XmlQualifiedName     qnameCData  // 0x48
  private           System.Boolean                  outputDocType  // 0x50
  private           System.Boolean                  checkWellFormedDoc  // 0x51
  private           System.Boolean                  hasDocElem  // 0x52
  private           System.Boolean                  inAttr  // 0x53
  private           System.String                   systemId  // 0x58
  private           System.String                   publicId  // 0x60
  private           System.Int32                    depth  // 0x68
METHODS:
  System.Void .ctor(System.Xml.XmlRawWriter writer, System.Xml.XmlWriterSettings settings)
  System.Void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value)
  System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone)
  System.Void WriteXmlDeclaration(System.String xmldecl)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void StartElementContent()
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndAttribute()
  System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns)
  System.Boolean get_SupportsNamespaceDeclarationInChunks()
  System.Void WriteStartNamespaceDeclaration(System.String prefix)
  System.Void WriteEndNamespaceDeclaration()
  System.Void WriteCData(System.String text)
  System.Void WriteComment(System.String text)
  System.Void WriteProcessingInstruction(System.String name, System.String text)
  System.Void WriteWhitespace(System.String ws)
  System.Void WriteString(System.String text)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.String data)
  System.Void Close()
  System.Void Flush()
  System.Boolean StartCDataSection()
  System.Void EndCDataSection()
END_CLASS

CLASS: System.Xml.ReadContentAsBinaryHelper
TYPE:  class
TOKEN: 0x2000036
FIELDS:
  private           System.Xml.XmlReader            reader  // 0x10
  private           System.Xml.ReadContentAsBinaryHelper.Statestate  // 0x18
  private           System.Int32                    valueOffset  // 0x1C
  private           System.Boolean                  isEnd  // 0x20
METHODS:
  System.Void Finish()
  System.Void Reset()
  System.Boolean MoveToNextContentNode(System.Boolean moveIfOnContentNode)
END_CLASS

CLASS: System.Xml.ElementProperties
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  System.Xml.ElementProperties    DEFAULT  // 0x0
  public    static  System.Xml.ElementProperties    URI_PARENT  // 0x0
  public    static  System.Xml.ElementProperties    BOOL_PARENT  // 0x0
  public    static  System.Xml.ElementProperties    NAME_PARENT  // 0x0
  public    static  System.Xml.ElementProperties    EMPTY  // 0x0
  public    static  System.Xml.ElementProperties    NO_ENTITIES  // 0x0
  public    static  System.Xml.ElementProperties    HEAD  // 0x0
  public    static  System.Xml.ElementProperties    BLOCK_WS  // 0x0
  public    static  System.Xml.ElementProperties    HAS_NS  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.AttributeProperties
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  System.Xml.AttributeProperties  DEFAULT  // 0x0
  public    static  System.Xml.AttributeProperties  URI  // 0x0
  public    static  System.Xml.AttributeProperties  BOOLEAN  // 0x0
  public    static  System.Xml.AttributeProperties  NAME  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.TernaryTreeReadOnly
TYPE:  class
TOKEN: 0x200003A
FIELDS:
  private           System.Byte[]                   nodeBuffer  // 0x10
METHODS:
  System.Void .ctor(System.Byte[] nodeBuffer)
  System.Byte FindCaseInsensitiveString(System.String stringToFind)
END_CLASS

CLASS: System.Xml.ReadState
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.ReadState            Initial  // 0x0
  public    static  System.Xml.ReadState            Interactive  // 0x0
  public    static  System.Xml.ReadState            Error  // 0x0
  public    static  System.Xml.ReadState            EndOfFile  // 0x0
  public    static  System.Xml.ReadState            Closed  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.SecureStringHasher
TYPE:  class
TOKEN: 0x200003C
FIELDS:
  private   static  System.Xml.SecureStringHasher.HashCodeOfStringDelegatehashCodeDelegate  // 0x0
  private           System.Int32                    hashCodeRandomizer  // 0x10
METHODS:
  System.Void .ctor()
  System.Boolean Equals(System.String x, System.String y)
  System.Int32 GetHashCode(System.String key)
  System.Int32 GetHashCodeOfString(System.String key, System.Int32 sLen, System.Int64 additionalEntropy)
  System.Xml.SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate()
END_CLASS

CLASS: System.Xml.TextEncodedRawTextWriter
TYPE:  class
TOKEN: 0x200003E
EXTENDS: XmlEncodedRawTextWriter
FIELDS:
METHODS:
  System.Void .ctor(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings)
  System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings)
  System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone)
  System.Void WriteXmlDeclaration(System.String xmldecl)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void StartElementContent()
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndAttribute()
  System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns)
  System.Boolean get_SupportsNamespaceDeclarationInChunks()
  System.Void WriteCData(System.String text)
  System.Void WriteComment(System.String text)
  System.Void WriteProcessingInstruction(System.String name, System.String text)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteWhitespace(System.String ws)
  System.Void WriteString(System.String textBlock)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.String data)
END_CLASS

CLASS: System.Xml.TextUtf8RawTextWriter
TYPE:  class
TOKEN: 0x200003F
EXTENDS: XmlUtf8RawTextWriter
FIELDS:
METHODS:
  System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings)
  System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone)
  System.Void WriteXmlDeclaration(System.String xmldecl)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void StartElementContent()
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndAttribute()
  System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns)
  System.Boolean get_SupportsNamespaceDeclarationInChunks()
  System.Void WriteCData(System.String text)
  System.Void WriteComment(System.String text)
  System.Void WriteProcessingInstruction(System.String name, System.String text)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteWhitespace(System.String ws)
  System.Void WriteString(System.String textBlock)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.String data)
END_CLASS

CLASS: System.Xml.ValidatingReaderNodeData
TYPE:  class
TOKEN: 0x2000040
FIELDS:
  private           System.String                   localName  // 0x10
  private           System.String                   namespaceUri  // 0x18
  private           System.String                   prefix  // 0x20
  private           System.String                   nameWPrefix  // 0x28
  private           System.String                   rawValue  // 0x30
  private           System.String                   originalStringValue  // 0x38
  private           System.Int32                    depth  // 0x40
  private           System.Xml.AttributePSVIInfo    attributePSVIInfo  // 0x48
  private           System.Xml.XmlNodeType          nodeType  // 0x50
  private           System.Int32                    lineNo  // 0x54
  private           System.Int32                    linePos  // 0x58
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Xml.XmlNodeType nodeType)
  System.String get_LocalName()
  System.Void set_LocalName(System.String value)
  System.String get_Namespace()
  System.Void set_Namespace(System.String value)
  System.String get_Prefix()
  System.Void set_Prefix(System.String value)
  System.String GetAtomizedNameWPrefix(System.Xml.XmlNameTable nameTable)
  System.Int32 get_Depth()
  System.Void set_Depth(System.Int32 value)
  System.String get_RawValue()
  System.Void set_RawValue(System.String value)
  System.String get_OriginalStringValue()
  System.Xml.XmlNodeType get_NodeType()
  System.Void set_NodeType(System.Xml.XmlNodeType value)
  System.Xml.AttributePSVIInfo get_AttInfo()
  System.Void set_AttInfo(System.Xml.AttributePSVIInfo value)
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
  System.Void Clear(System.Xml.XmlNodeType nodeType)
  System.Void SetLineInfo(System.Int32 lineNo, System.Int32 linePos)
  System.Void SetLineInfo(System.Xml.IXmlLineInfo lineInfo)
  System.Void SetItemData(System.String localName, System.String prefix, System.String ns, System.Int32 depth)
  System.Void SetItemData(System.String value)
  System.Void SetItemData(System.String value, System.String originalStringValue)
END_CLASS

CLASS: System.Xml.ValidationType
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.ValidationType       None  // 0x0
  public    static  System.Xml.ValidationType       Auto  // 0x0
  public    static  System.Xml.ValidationType       DTD  // 0x0
  public    static  System.Xml.ValidationType       XDR  // 0x0
  public    static  System.Xml.ValidationType       Schema  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.WhitespaceHandling
TYPE:  struct
TOKEN: 0x2000042
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.WhitespaceHandling   All  // 0x0
  public    static  System.Xml.WhitespaceHandling   Significant  // 0x0
  public    static  System.Xml.WhitespaceHandling   None  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlAsyncCheckReader
TYPE:  class
TOKEN: 0x2000043
EXTENDS: XmlReader
FIELDS:
  private   readonly System.Xml.XmlReader            coreReader  // 0x10
  private           System.Threading.Tasks.Task     lastTask  // 0x18
METHODS:
  System.Xml.XmlReader get_CoreReader()
  System.Xml.XmlAsyncCheckReader CreateAsyncCheckWrapper(System.Xml.XmlReader reader)
  System.Void .ctor(System.Xml.XmlReader reader)
  System.Void CheckAsync()
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
  System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo()
  System.Type get_ValueType()
  System.String ReadContentAsString()
  System.Int32 get_AttributeCount()
  System.String GetAttribute(System.String name)
  System.String GetAttribute(System.String name, System.String namespaceURI)
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
  System.Int32 ReadValueChunk(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.String ReadString()
  System.Xml.XmlNodeType MoveToContent()
  System.Void ReadStartElement()
  System.Void ReadStartElement(System.String name)
  System.String ReadElementString()
  System.Void ReadEndElement()
  System.Boolean IsStartElement()
  System.Boolean IsStartElement(System.String localname, System.String ns)
  System.String ReadInnerXml()
  System.Boolean get_HasAttributes()
  System.Void Dispose(System.Boolean disposing)
  System.Xml.XmlNamespaceManager get_NamespaceManager()
  System.Xml.IDtdInfo get_DtdInfo()
END_CLASS

CLASS: System.Xml.XmlAsyncCheckReaderWithNS
TYPE:  class
TOKEN: 0x2000044
EXTENDS: XmlAsyncCheckReader
FIELDS:
  private   readonly System.Xml.IXmlNamespaceResolverreaderAsIXmlNamespaceResolver  // 0x20
METHODS:
  System.Void .ctor(System.Xml.XmlReader reader)
  System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix)
  System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName)
END_CLASS

CLASS: System.Xml.XmlAsyncCheckReaderWithLineInfo
TYPE:  class
TOKEN: 0x2000045
EXTENDS: XmlAsyncCheckReader
FIELDS:
  private   readonly System.Xml.IXmlLineInfo         readerAsIXmlLineInfo  // 0x20
METHODS:
  System.Void .ctor(System.Xml.XmlReader reader)
  System.Boolean HasLineInfo()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
END_CLASS

CLASS: System.Xml.XmlAsyncCheckReaderWithLineInfoNS
TYPE:  class
TOKEN: 0x2000046
EXTENDS: XmlAsyncCheckReaderWithLineInfo
FIELDS:
  private   readonly System.Xml.IXmlNamespaceResolverreaderAsIXmlNamespaceResolver  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XmlReader reader)
  System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix)
  System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName)
END_CLASS

CLASS: System.Xml.XmlAsyncCheckReaderWithLineInfoNSSchema
TYPE:  class
TOKEN: 0x2000047
EXTENDS: XmlAsyncCheckReaderWithLineInfoNS
FIELDS:
  private   readonly System.Xml.Schema.IXmlSchemaInforeaderAsIXmlSchemaInfo  // 0x30
METHODS:
  System.Void .ctor(System.Xml.XmlReader reader)
  System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity()
  System.Boolean System.Xml.Schema.IXmlSchemaInfo.get_IsDefault()
  System.Boolean System.Xml.Schema.IXmlSchemaInfo.get_IsNil()
  System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType()
  System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType()
  System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement()
  System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute()
END_CLASS

CLASS: System.Xml.XmlAsyncCheckWriter
TYPE:  class
TOKEN: 0x2000048
EXTENDS: XmlWriter
FIELDS:
  private   readonly System.Xml.XmlWriter            coreWriter  // 0x18
  private           System.Threading.Tasks.Task     lastTask  // 0x20
METHODS:
  System.Void .ctor(System.Xml.XmlWriter writer)
  System.Void CheckAsync()
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
  System.Void WriteValue(System.Object value)
  System.Void WriteValue(System.String value)
  System.Void WriteValue(System.Boolean value)
  System.Void WriteValue(System.DateTime value)
  System.Void WriteValue(System.Double value)
  System.Void WriteValue(System.Single value)
  System.Void WriteValue(System.Decimal value)
  System.Void WriteValue(System.Int32 value)
  System.Void WriteValue(System.Int64 value)
  System.Void WriteAttributes(System.Xml.XmlReader reader, System.Boolean defattr)
  System.Void WriteNode(System.Xml.XmlReader reader, System.Boolean defattr)
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: System.Xml.XmlAutoDetectWriter
TYPE:  class
TOKEN: 0x2000049
EXTENDS: XmlRawWriter
FIELDS:
  private           System.Xml.XmlRawWriter         wrapped  // 0x28
  private           System.Xml.OnRemoveWriter       onRemove  // 0x30
  private           System.Xml.XmlWriterSettings    writerSettings  // 0x38
  private           System.Xml.XmlEventCache        eventCache  // 0x40
  private           System.IO.TextWriter            textWriter  // 0x48
  private           System.IO.Stream                strm  // 0x50
METHODS:
  System.Void .ctor(System.Xml.XmlWriterSettings writerSettings)
  System.Void .ctor(System.IO.TextWriter textWriter, System.Xml.XmlWriterSettings writerSettings)
  System.Void .ctor(System.IO.Stream strm, System.Xml.XmlWriterSettings writerSettings)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndAttribute()
  System.Void WriteCData(System.String text)
  System.Void WriteComment(System.String text)
  System.Void WriteProcessingInstruction(System.String name, System.String text)
  System.Void WriteWhitespace(System.String ws)
  System.Void WriteString(System.String text)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.String data)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteBinHex(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Void Close()
  System.Void Flush()
  System.Void WriteValue(System.Object value)
  System.Void WriteValue(System.String value)
  System.Void WriteValue(System.Boolean value)
  System.Void WriteValue(System.DateTime value)
  System.Void WriteValue(System.Double value)
  System.Void WriteValue(System.Single value)
  System.Void WriteValue(System.Decimal value)
  System.Void WriteValue(System.Int32 value)
  System.Void WriteValue(System.Int64 value)
  System.Void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value)
  System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone)
  System.Void WriteXmlDeclaration(System.String xmldecl)
  System.Void StartElementContent()
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns)
  System.Boolean get_SupportsNamespaceDeclarationInChunks()
  System.Void WriteStartNamespaceDeclaration(System.String prefix)
  System.Void WriteEndNamespaceDeclaration()
  System.Boolean IsHtmlTag(System.String tagName)
  System.Void EnsureWrappedWriter(System.Xml.XmlOutputMethod outMethod)
  System.Boolean TextBlockCreatesWriter(System.String textBlock)
  System.Void CreateWrappedWriter(System.Xml.XmlOutputMethod outMethod)
END_CLASS

CLASS: System.Xml.XmlEncodedRawTextWriter
TYPE:  class
TOKEN: 0x200004A
EXTENDS: XmlRawWriter
FIELDS:
  private   readonly System.Boolean                  useAsync  // 0x28
  protected         System.Byte[]                   bufBytes  // 0x30
  protected         System.IO.Stream                stream  // 0x38
  protected         System.Text.Encoding            encoding  // 0x40
  protected         System.Xml.XmlCharType          xmlCharType  // 0x48
  protected         System.Int32                    bufPos  // 0x50
  protected         System.Int32                    textPos  // 0x54
  protected         System.Int32                    contentPos  // 0x58
  protected         System.Int32                    cdataPos  // 0x5C
  protected         System.Int32                    attrEndPos  // 0x60
  protected         System.Int32                    bufLen  // 0x64
  protected         System.Boolean                  writeToNull  // 0x68
  protected         System.Boolean                  hadDoubleBracket  // 0x69
  protected         System.Boolean                  inAttributeValue  // 0x6A
  protected         System.Int32                    bufBytesUsed  // 0x6C
  protected         System.Char[]                   bufChars  // 0x70
  protected         System.Text.Encoder             encoder  // 0x78
  protected         System.IO.TextWriter            writer  // 0x80
  protected         System.Boolean                  trackTextContent  // 0x88
  protected         System.Boolean                  inTextContent  // 0x89
  private           System.Int32                    lastMarkPos  // 0x8C
  private           System.Int32[]                  textContentMarks  // 0x90
  private           System.Xml.CharEntityEncoderFallbackcharEntityFallback  // 0x98
  protected         System.Xml.NewLineHandling      newLineHandling  // 0xA0
  protected         System.Boolean                  closeOutput  // 0xA4
  protected         System.Boolean                  omitXmlDeclaration  // 0xA5
  protected         System.String                   newLineChars  // 0xA8
  protected         System.Boolean                  checkCharacters  // 0xB0
  protected         System.Xml.XmlStandalone        standalone  // 0xB4
  protected         System.Xml.XmlOutputMethod      outputMethod  // 0xB8
  protected         System.Boolean                  autoXmlDeclaration  // 0xBC
  protected         System.Boolean                  mergeCDataSections  // 0xBD
METHODS:
  System.Void .ctor(System.Xml.XmlWriterSettings settings)
  System.Void .ctor(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings)
  System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings)
  System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone)
  System.Void WriteXmlDeclaration(System.String xmldecl)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void StartElementContent()
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndAttribute()
  System.Void WriteNamespaceDeclaration(System.String prefix, System.String namespaceName)
  System.Boolean get_SupportsNamespaceDeclarationInChunks()
  System.Void WriteStartNamespaceDeclaration(System.String prefix)
  System.Void WriteEndNamespaceDeclaration()
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
  System.Void Close()
  System.Void Flush()
  System.Void FlushBuffer()
  System.Void EncodeChars(System.Int32 startOffset, System.Int32 endOffset, System.Boolean writeAllToStream)
  System.Void FlushEncoder()
  System.Void WriteAttributeTextBlock(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void WriteElementTextBlock(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void RawText(System.String s)
  System.Void RawText(System.Char* pSrcBegin, System.Char* pSrcEnd)
  System.Void WriteRawWithCharChecking(System.Char* pSrcBegin, System.Char* pSrcEnd)
  System.Void WriteCommentOrPi(System.String text, System.Int32 stopChar)
  System.Void WriteCDataSection(System.String text)
  System.Char* EncodeSurrogate(System.Char* pSrc, System.Char* pSrcEnd, System.Char* pDst)
  System.Char* InvalidXmlChar(System.Int32 ch, System.Char* pDst, System.Boolean entitize)
  System.Void EncodeChar(System.Char*& pSrc, System.Char* pSrcEnd, System.Char*& pDst)
  System.Void ChangeTextContentMark(System.Boolean value)
  System.Void GrowTextContentMarks()
  System.Char* WriteNewLine(System.Char* pDst)
  System.Char* LtEntity(System.Char* pDst)
  System.Char* GtEntity(System.Char* pDst)
  System.Char* AmpEntity(System.Char* pDst)
  System.Char* QuoteEntity(System.Char* pDst)
  System.Char* TabEntity(System.Char* pDst)
  System.Char* LineFeedEntity(System.Char* pDst)
  System.Char* CarriageReturnEntity(System.Char* pDst)
  System.Char* CharEntity(System.Char* pDst, System.Char ch)
  System.Char* RawStartCData(System.Char* pDst)
  System.Char* RawEndCData(System.Char* pDst)
  System.Void ValidateContentChars(System.String chars, System.String propertyName, System.Boolean allowOnlyWhitespace)
END_CLASS

CLASS: System.Xml.XmlEncodedRawTextWriterIndent
TYPE:  class
TOKEN: 0x200004B
EXTENDS: XmlEncodedRawTextWriter
FIELDS:
  protected         System.Int32                    indentLevel  // 0xC0
  protected         System.Boolean                  newLineOnAttributes  // 0xC4
  protected         System.String                   indentChars  // 0xC8
  protected         System.Boolean                  mixedContent  // 0xD0
  private           System.Xml.BitStack             mixedContentStack  // 0xD8
  protected         System.Xml.ConformanceLevel     conformanceLevel  // 0xE0
METHODS:
  System.Void .ctor(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings)
  System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void StartElementContent()
  System.Void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel)
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteCData(System.String text)
  System.Void WriteComment(System.String text)
  System.Void WriteProcessingInstruction(System.String target, System.String text)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteWhitespace(System.String ws)
  System.Void WriteString(System.String text)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.String data)
  System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Void Init(System.Xml.XmlWriterSettings settings)
  System.Void WriteIndent()
END_CLASS

CLASS: System.Xml.XmlEventCache
TYPE:  class
TOKEN: 0x200004C
EXTENDS: XmlRawWriter
FIELDS:
  private           System.Collections.Generic.List<System.Xml.XmlEventCache.XmlEvent[]>pages  // 0x28
  private           System.Xml.XmlEventCache.XmlEvent[]pageCurr  // 0x30
  private           System.Int32                    pageSize  // 0x38
  private           System.Boolean                  hasRootNode  // 0x3C
  private           System.Xml.Xsl.Runtime.StringConcatsingleText  // 0x40
  private           System.String                   baseUri  // 0x78
METHODS:
  System.Void .ctor(System.String baseUri, System.Boolean hasRootNode)
  System.Void EndEvents()
  System.Void EventsToWriter(System.Xml.XmlWriter writer)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndAttribute()
  System.Void WriteCData(System.String text)
  System.Void WriteComment(System.String text)
  System.Void WriteProcessingInstruction(System.String name, System.String text)
  System.Void WriteWhitespace(System.String ws)
  System.Void WriteString(System.String text)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.String data)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteBinHex(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Void Close()
  System.Void Flush()
  System.Void WriteValue(System.Object value)
  System.Void WriteValue(System.String value)
  System.Void Dispose(System.Boolean disposing)
  System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone)
  System.Void WriteXmlDeclaration(System.String xmldecl)
  System.Void StartElementContent()
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns)
  System.Void WriteEndBase64()
  System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType)
  System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1)
  System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2)
  System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2, System.String s3)
  System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.String s1, System.String s2, System.String s3, System.Object o)
  System.Void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, System.Object o)
  System.Int32 NewEvent()
  System.Byte[] ToBytes(System.Byte[] buffer, System.Int32 index, System.Int32 count)
END_CLASS

CLASS: System.Xml.XmlParserContext
TYPE:  class
TOKEN: 0x200004F
FIELDS:
  private           System.Xml.XmlNameTable         _nt  // 0x10
  private           System.Xml.XmlNamespaceManager  _nsMgr  // 0x18
  private           System.String                   _docTypeName  // 0x20
  private           System.String                   _pubId  // 0x28
  private           System.String                   _sysId  // 0x30
  private           System.String                   _internalSubset  // 0x38
  private           System.String                   _xmlLang  // 0x40
  private           System.Xml.XmlSpace             _xmlSpace  // 0x48
  private           System.String                   _baseURI  // 0x50
  private           System.Text.Encoding            _encoding  // 0x58
METHODS:
  System.Void .ctor(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, System.String xmlLang, System.Xml.XmlSpace xmlSpace)
  System.Void .ctor(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, System.String docTypeName, System.String pubId, System.String sysId, System.String internalSubset, System.String baseURI, System.String xmlLang, System.Xml.XmlSpace xmlSpace)
  System.Void .ctor(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, System.String docTypeName, System.String pubId, System.String sysId, System.String internalSubset, System.String baseURI, System.String xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc)
  System.Xml.XmlNameTable get_NameTable()
  System.Xml.XmlNamespaceManager get_NamespaceManager()
  System.String get_DocTypeName()
  System.String get_PublicId()
  System.String get_SystemId()
  System.String get_BaseURI()
  System.String get_InternalSubset()
  System.String get_XmlLang()
  System.Xml.XmlSpace get_XmlSpace()
  System.Text.Encoding get_Encoding()
  System.Boolean get_HasDtdInfo()
END_CLASS

CLASS: System.Xml.XmlRawWriter
TYPE:  class
TOKEN: 0x2000050
EXTENDS: XmlWriter
FIELDS:
  protected         System.Xml.XmlRawWriterBase64Encoderbase64Encoder  // 0x18
  protected         System.Xml.IXmlNamespaceResolverresolver  // 0x20
METHODS:
  System.Void WriteStartDocument()
  System.Void WriteStartDocument(System.Boolean standalone)
  System.Void WriteEndDocument()
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteEndElement()
  System.Void WriteFullEndElement()
  System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.String LookupPrefix(System.String ns)
  System.Xml.WriteState get_WriteState()
  System.Void WriteCData(System.String text)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteWhitespace(System.String ws)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.String data)
  System.Void WriteValue(System.Object value)
  System.Void WriteValue(System.String value)
  System.Void WriteAttributes(System.Xml.XmlReader reader, System.Boolean defattr)
  System.Void WriteNode(System.Xml.XmlReader reader, System.Boolean defattr)
  System.Void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value)
  System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone)
  System.Void WriteXmlDeclaration(System.String xmldecl)
  System.Void StartElementContent()
  System.Void OnRootElement(System.Xml.ConformanceLevel conformanceLevel)
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteNamespaceDeclaration(System.String prefix, System.String ns)
  System.Boolean get_SupportsNamespaceDeclarationInChunks()
  System.Void WriteStartNamespaceDeclaration(System.String prefix)
  System.Void WriteEndNamespaceDeclaration()
  System.Void WriteEndBase64()
  System.Void Close(System.Xml.WriteState currentState)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.XmlReader
TYPE:  class
TOKEN: 0x2000051
FIELDS:
  private   static  System.UInt32                   IsTextualNodeBitmap  // 0x0
  private   static  System.UInt32                   CanReadContentAsBitmap  // 0x4
  private   static  System.UInt32                   HasValueBitmap  // 0x8
METHODS:
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
  System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo()
  System.Type get_ValueType()
  System.String ReadContentAsString()
  System.Int32 get_AttributeCount()
  System.String GetAttribute(System.String name)
  System.String GetAttribute(System.String name, System.String namespaceURI)
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
  System.Int32 ReadValueChunk(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.String ReadString()
  System.Xml.XmlNodeType MoveToContent()
  System.Void ReadStartElement()
  System.Void ReadStartElement(System.String name)
  System.String ReadElementString()
  System.Void ReadEndElement()
  System.Boolean IsStartElement()
  System.Boolean IsStartElement(System.String localname, System.String ns)
  System.String ReadInnerXml()
  System.Void WriteNode(System.Xml.XmlWriter xtw, System.Boolean defattr)
  System.Void WriteAttributeValue(System.Xml.XmlWriter xtw)
  System.Xml.XmlWriter CreateWriterForInnerOuterXml(System.IO.StringWriter sw)
  System.Void SetNamespacesFlag(System.Xml.XmlTextWriter xtw)
  System.Boolean get_HasAttributes()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Xml.XmlNamespaceManager get_NamespaceManager()
  System.Boolean IsTextualNode(System.Xml.XmlNodeType nodeType)
  System.Boolean CanReadContentAs(System.Xml.XmlNodeType nodeType)
  System.Boolean HasValueInternal(System.Xml.XmlNodeType nodeType)
  System.Boolean SkipSubtree()
  System.Exception CreateReadContentAsException(System.String methodName)
  System.Boolean CanReadContentAs()
  System.Exception CreateReadContentAsException(System.String methodName, System.Xml.XmlNodeType nodeType, System.Xml.IXmlLineInfo lineInfo)
  System.String AddLineInfo(System.String message, System.Xml.IXmlLineInfo lineInfo)
  System.String InternalReadContentAsString()
  System.Boolean get_IsDefaultInternal()
  System.Xml.IDtdInfo get_DtdInfo()
  System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.String baseUri)
  System.Xml.XmlReader Create(System.IO.TextReader input)
  System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, System.String baseUri)
  System.Xml.XmlReader CreateSqlReader(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext)
  System.Int32 CalcBufferSize(System.IO.Stream input)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.XmlReaderSettings
TYPE:  class
TOKEN: 0x2000052
FIELDS:
  private           System.Boolean                  useAsync  // 0x10
  private           System.Xml.XmlNameTable         nameTable  // 0x18
  private           System.Xml.XmlResolver          xmlResolver  // 0x20
  private           System.Int32                    lineNumberOffset  // 0x28
  private           System.Int32                    linePositionOffset  // 0x2C
  private           System.Xml.ConformanceLevel     conformanceLevel  // 0x30
  private           System.Boolean                  checkCharacters  // 0x34
  private           System.Int64                    maxCharactersInDocument  // 0x38
  private           System.Int64                    maxCharactersFromEntities  // 0x40
  private           System.Boolean                  ignoreWhitespace  // 0x48
  private           System.Boolean                  ignorePIs  // 0x49
  private           System.Boolean                  ignoreComments  // 0x4A
  private           System.Xml.DtdProcessing        dtdProcessing  // 0x4C
  private           System.Xml.ValidationType       validationType  // 0x50
  private           System.Xml.Schema.XmlSchemaValidationFlagsvalidationFlags  // 0x54
  private           System.Xml.Schema.XmlSchemaSet  schemas  // 0x58
  private           System.Xml.Schema.ValidationEventHandlervalEventHandler  // 0x60
  private           System.Boolean                  closeInput  // 0x68
  private           System.Boolean                  isReadOnly  // 0x69
  private           System.Boolean                  <IsXmlResolverSet>k__BackingField  // 0x6A
  private   static  System.Nullable<System.Boolean> s_enableLegacyXmlSettings  // 0x0
METHODS:
  System.Void .ctor()
  System.Boolean get_Async()
  System.Void set_Async(System.Boolean value)
  System.Xml.XmlNameTable get_NameTable()
  System.Void set_NameTable(System.Xml.XmlNameTable value)
  System.Boolean get_IsXmlResolverSet()
  System.Void set_IsXmlResolverSet(System.Boolean value)
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Xml.XmlResolver GetXmlResolver()
  System.Xml.XmlResolver GetXmlResolver_CheckConfig()
  System.Int32 get_LineNumberOffset()
  System.Void set_LineNumberOffset(System.Int32 value)
  System.Int32 get_LinePositionOffset()
  System.Void set_LinePositionOffset(System.Int32 value)
  System.Xml.ConformanceLevel get_ConformanceLevel()
  System.Void set_ConformanceLevel(System.Xml.ConformanceLevel value)
  System.Boolean get_CheckCharacters()
  System.Void set_CheckCharacters(System.Boolean value)
  System.Int64 get_MaxCharactersInDocument()
  System.Void set_MaxCharactersInDocument(System.Int64 value)
  System.Int64 get_MaxCharactersFromEntities()
  System.Void set_MaxCharactersFromEntities(System.Int64 value)
  System.Boolean get_IgnoreWhitespace()
  System.Void set_IgnoreWhitespace(System.Boolean value)
  System.Boolean get_IgnoreProcessingInstructions()
  System.Void set_IgnoreProcessingInstructions(System.Boolean value)
  System.Boolean get_IgnoreComments()
  System.Void set_IgnoreComments(System.Boolean value)
  System.Xml.DtdProcessing get_DtdProcessing()
  System.Void set_DtdProcessing(System.Xml.DtdProcessing value)
  System.Boolean get_CloseInput()
  System.Void set_CloseInput(System.Boolean value)
  System.Xml.ValidationType get_ValidationType()
  System.Void set_ValidationType(System.Xml.ValidationType value)
  System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags()
  System.Void set_ValidationFlags(System.Xml.Schema.XmlSchemaValidationFlags value)
  System.Xml.Schema.XmlSchemaSet get_Schemas()
  System.Void set_Schemas(System.Xml.Schema.XmlSchemaSet value)
  System.Xml.XmlReaderSettings Clone()
  System.Xml.Schema.ValidationEventHandler GetEventHandler()
  System.Xml.XmlReader CreateReader(System.IO.Stream input, System.Uri baseUri, System.String baseUriString, System.Xml.XmlParserContext inputContext)
  System.Xml.XmlReader CreateReader(System.IO.TextReader input, System.String baseUriString, System.Xml.XmlParserContext inputContext)
  System.Void set_ReadOnly(System.Boolean value)
  System.Void CheckReadOnly(System.String propertyName)
  System.Void Initialize()
  System.Void Initialize(System.Xml.XmlResolver resolver)
  System.Xml.XmlResolver CreateDefaultResolver()
  System.Xml.XmlReader AddValidation(System.Xml.XmlReader reader)
  System.Xml.XmlValidatingReaderImpl CreateDtdValidatingReader(System.Xml.XmlReader baseReader)
  System.Boolean EnableLegacyXmlSettings()
END_CLASS

CLASS: System.Xml.XmlSpace
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlSpace             None  // 0x0
  public    static  System.Xml.XmlSpace             Default  // 0x0
  public    static  System.Xml.XmlSpace             Preserve  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlTextEncoder
TYPE:  class
TOKEN: 0x2000054
FIELDS:
  private           System.IO.TextWriter            textWriter  // 0x10
  private           System.Boolean                  inAttribute  // 0x18
  private           System.Char                     quoteChar  // 0x1A
  private           System.Text.StringBuilder       attrValue  // 0x20
  private           System.Boolean                  cacheAttrValue  // 0x28
  private           System.Xml.XmlCharType          xmlCharType  // 0x30
METHODS:
  System.Void .ctor(System.IO.TextWriter textWriter)
  System.Void set_QuoteChar(System.Char value)
  System.Void StartAttribute(System.Boolean cacheAttrValue)
  System.Void EndAttribute()
  System.String get_AttributeValue()
  System.Void WriteSurrogateChar(System.Char lowChar, System.Char highChar)
  System.Void Write(System.Char[] array, System.Int32 offset, System.Int32 count)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void Write(System.String text)
  System.Void WriteRawWithSurrogateChecking(System.String text)
  System.Void WriteRaw(System.Char[] array, System.Int32 offset, System.Int32 count)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteStringFragment(System.String str, System.Int32 offset, System.Int32 count, System.Char[] helperBuffer)
  System.Void WriteCharEntityImpl(System.Char ch)
  System.Void WriteCharEntityImpl(System.String strVal)
  System.Void WriteEntityRefImpl(System.String name)
END_CLASS

CLASS: System.Xml.XmlTextReader
TYPE:  class
TOKEN: 0x2000055
EXTENDS: XmlReader
FIELDS:
  private           System.Xml.XmlTextReaderImpl    impl  // 0x10
METHODS:
  System.Void .ctor(System.IO.Stream input)
  System.Void .ctor(System.String url, System.IO.Stream input, System.Xml.XmlNameTable nt)
  System.Void .ctor(System.IO.TextReader input)
  System.Void .ctor(System.IO.TextReader input, System.Xml.XmlNameTable nt)
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
  System.Boolean HasLineInfo()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
  System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix)
  System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName)
  System.Boolean get_Namespaces()
  System.Boolean get_Normalization()
  System.Void set_Normalization(System.Boolean value)
  System.Void set_WhitespaceHandling(System.Xml.WhitespaceHandling value)
  System.Void set_EntityHandling(System.Xml.EntityHandling value)
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Xml.XmlTextReaderImpl get_Impl()
  System.Xml.XmlNamespaceManager get_NamespaceManager()
  System.Void set_XmlValidatingReaderCompatibilityMode(System.Boolean value)
  System.Xml.IDtdInfo get_DtdInfo()
END_CLASS

CLASS: System.Xml.XmlTextReaderImpl
TYPE:  class
TOKEN: 0x2000056
EXTENDS: XmlReader
FIELDS:
  private   readonly System.Boolean                  useAsync  // 0x10
  private           System.Xml.XmlTextReaderImpl.LaterInitParamlaterInitParam  // 0x18
  private           System.Xml.XmlCharType          xmlCharType  // 0x20
  private           System.Xml.XmlTextReaderImpl.ParsingStateps  // 0x28
  private           System.Xml.XmlTextReaderImpl.ParsingFunctionparsingFunction  // 0xA0
  private           System.Xml.XmlTextReaderImpl.ParsingFunctionnextParsingFunction  // 0xA4
  private           System.Xml.XmlTextReaderImpl.ParsingFunctionnextNextParsingFunction  // 0xA8
  private           System.Xml.XmlTextReaderImpl.NodeData[]nodes  // 0xB0
  private           System.Xml.XmlTextReaderImpl.NodeDatacurNode  // 0xB8
  private           System.Int32                    index  // 0xC0
  private           System.Int32                    curAttrIndex  // 0xC4
  private           System.Int32                    attrCount  // 0xC8
  private           System.Int32                    attrHashtable  // 0xCC
  private           System.Int32                    attrDuplWalkCount  // 0xD0
  private           System.Boolean                  attrNeedNamespaceLookup  // 0xD4
  private           System.Boolean                  fullAttrCleanup  // 0xD5
  private           System.Xml.XmlTextReaderImpl.NodeData[]attrDuplSortingArray  // 0xD8
  private           System.Xml.XmlNameTable         nameTable  // 0xE0
  private           System.Boolean                  nameTableFromSettings  // 0xE8
  private           System.Xml.XmlResolver          xmlResolver  // 0xF0
  private           System.String                   url  // 0xF8
  private           System.Boolean                  normalize  // 0x100
  private           System.Boolean                  supportNamespaces  // 0x101
  private           System.Xml.WhitespaceHandling   whitespaceHandling  // 0x104
  private           System.Xml.DtdProcessing        dtdProcessing  // 0x108
  private           System.Xml.EntityHandling       entityHandling  // 0x10C
  private           System.Boolean                  ignorePIs  // 0x110
  private           System.Boolean                  ignoreComments  // 0x111
  private           System.Boolean                  checkCharacters  // 0x112
  private           System.Int32                    lineNumberOffset  // 0x114
  private           System.Int32                    linePositionOffset  // 0x118
  private           System.Boolean                  closeInput  // 0x11C
  private           System.Int64                    maxCharactersInDocument  // 0x120
  private           System.Int64                    maxCharactersFromEntities  // 0x128
  private           System.Boolean                  v1Compat  // 0x130
  private           System.Xml.XmlNamespaceManager  namespaceManager  // 0x138
  private           System.String                   lastPrefix  // 0x140
  private           System.Xml.XmlTextReaderImpl.XmlContextxmlContext  // 0x148
  private           System.Xml.XmlTextReaderImpl.ParsingState[]parsingStatesStack  // 0x150
  private           System.Int32                    parsingStatesStackTop  // 0x158
  private           System.String                   reportedBaseUri  // 0x160
  private           System.Text.Encoding            reportedEncoding  // 0x168
  private           System.Xml.IDtdInfo             dtdInfo  // 0x170
  private           System.Xml.XmlNodeType          fragmentType  // 0x178
  private           System.Xml.XmlParserContext     fragmentParserContext  // 0x180
  private           System.Boolean                  fragment  // 0x188
  private           System.Xml.IncrementalReadDecoderincReadDecoder  // 0x190
  private           System.Xml.XmlTextReaderImpl.IncrementalReadStateincReadState  // 0x198
  private           System.Xml.LineInfo             incReadLineInfo  // 0x19C
  private           System.Int32                    incReadDepth  // 0x1A4
  private           System.Int32                    incReadLeftStartPos  // 0x1A8
  private           System.Int32                    incReadLeftEndPos  // 0x1AC
  private           System.Int32                    attributeValueBaseEntityId  // 0x1B0
  private           System.Boolean                  emptyEntityInAttributeResolved  // 0x1B4
  private           System.Xml.IValidationEventHandlingvalidationEventHandling  // 0x1B8
  private           System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegateonDefaultAttributeUse  // 0x1C0
  private           System.Boolean                  validatingReaderCompatFlag  // 0x1C8
  private           System.Boolean                  addDefaultAttributesAndNormalize  // 0x1C9
  private           System.Text.StringBuilder       stringBuilder  // 0x1D0
  private           System.Boolean                  rootElementParsed  // 0x1D8
  private           System.Boolean                  standalone  // 0x1D9
  private           System.Int32                    nextEntityId  // 0x1DC
  private           System.Xml.XmlTextReaderImpl.ParsingModeparsingMode  // 0x1E0
  private           System.Xml.ReadState            readState  // 0x1E4
  private           System.Xml.IDtdEntityInfo       lastEntity  // 0x1E8
  private           System.Boolean                  afterResetState  // 0x1F0
  private           System.Int32                    documentStartBytePos  // 0x1F4
  private           System.Int32                    readValueOffset  // 0x1F8
  private           System.Int64                    charactersInDocument  // 0x200
  private           System.Int64                    charactersFromEntities  // 0x208
  private           System.Collections.Generic.Dictionary<System.Xml.IDtdEntityInfo,System.Xml.IDtdEntityInfo>currentEntities  // 0x210
  private           System.Boolean                  disableUndeclaredEntityCheck  // 0x218
  private           System.Xml.XmlReader            outerReader  // 0x220
  private           System.Boolean                  xmlResolverIsSet  // 0x228
  private           System.String                   Xml  // 0x230
  private           System.String                   XmlNs  // 0x238
  private           System.Threading.Tasks.Task<System.Tuple<System.Int32,System.Int32,System.Int32,System.Boolean>>parseText_dummyTask  // 0x240
METHODS:
  System.Void .ctor(System.Xml.XmlNameTable nt)
  System.Void .ctor(System.Xml.XmlResolver resolver, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext context)
  System.Void .ctor(System.IO.Stream input)
  System.Void .ctor(System.String url, System.IO.Stream input, System.Xml.XmlNameTable nt)
  System.Void .ctor(System.IO.TextReader input)
  System.Void .ctor(System.IO.TextReader input, System.Xml.XmlNameTable nt)
  System.Void .ctor(System.String url, System.IO.TextReader input, System.Xml.XmlNameTable nt)
  System.Void .ctor(System.String xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context)
  System.Void .ctor(System.String xmlFragment, System.Xml.XmlParserContext context)
  System.Void FinishInitUriString()
  System.Void .ctor(System.IO.Stream stream, System.Byte[] bytes, System.Int32 byteCount, System.Xml.XmlReaderSettings settings, System.Uri baseUri, System.String baseUriStr, System.Xml.XmlParserContext context, System.Boolean closeInput)
  System.Void FinishInitStream()
  System.Void .ctor(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, System.String baseUriStr, System.Xml.XmlParserContext context)
  System.Void FinishInitTextReader()
  System.Void .ctor(System.String xmlFragment, System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings)
  System.Xml.XmlReaderSettings get_Settings()
  System.Xml.XmlNodeType get_NodeType()
  System.String get_Name()
  System.String get_LocalName()
  System.String get_NamespaceURI()
  System.String get_Prefix()
  System.String get_Value()
  System.Int32 get_Depth()
  System.String get_BaseURI()
  System.Boolean get_IsEmptyElement()
  System.Boolean get_IsDefault()
  System.Char get_QuoteChar()
  System.Xml.XmlSpace get_XmlSpace()
  System.String get_XmlLang()
  System.Xml.ReadState get_ReadState()
  System.Boolean get_EOF()
  System.Xml.XmlNameTable get_NameTable()
  System.Boolean get_CanResolveEntity()
  System.Int32 get_AttributeCount()
  System.String GetAttribute(System.String name)
  System.String GetAttribute(System.String localName, System.String namespaceURI)
  System.String GetAttribute(System.Int32 i)
  System.Boolean MoveToAttribute(System.String name)
  System.Void MoveToAttribute(System.Int32 i)
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
  System.Boolean MoveToElement()
  System.Void FinishInit()
  System.Boolean Read()
  System.Void Close()
  System.Void Skip()
  System.String LookupNamespace(System.String prefix)
  System.Boolean ReadAttributeValue()
  System.Void ResolveEntity()
  System.Void set_OuterReader(System.Xml.XmlReader value)
  System.Void MoveOffEntityReference()
  System.String ReadString()
  System.Boolean get_CanReadValueChunk()
  System.Int32 ReadValueChunk(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Boolean HasLineInfo()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
  System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix)
  System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName)
  System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String LookupPrefix(System.String namespaceName)
  System.Boolean get_Namespaces()
  System.Void set_Namespaces(System.Boolean value)
  System.Boolean get_Normalization()
  System.Void set_Normalization(System.Boolean value)
  System.Void set_WhitespaceHandling(System.Xml.WhitespaceHandling value)
  System.Void set_EntityHandling(System.Xml.EntityHandling value)
  System.Boolean get_IsResolverSet()
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Xml.XmlNameTable get_DtdParserProxy_NameTable()
  System.Xml.IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver()
  System.Boolean get_DtdParserProxy_DtdValidation()
  System.Boolean get_DtdParserProxy_Normalization()
  System.Boolean get_DtdParserProxy_Namespaces()
  System.Boolean get_DtdParserProxy_V1CompatibilityMode()
  System.Uri get_DtdParserProxy_BaseUri()
  System.Boolean get_DtdParserProxy_IsEof()
  System.Char[] get_DtdParserProxy_ParsingBuffer()
  System.Int32 get_DtdParserProxy_ParsingBufferLength()
  System.Int32 get_DtdParserProxy_CurrentPosition()
  System.Void set_DtdParserProxy_CurrentPosition(System.Int32 value)
  System.Int32 get_DtdParserProxy_EntityStackLength()
  System.Boolean get_DtdParserProxy_IsEntityEolNormalized()
  System.Xml.IValidationEventHandling get_DtdParserProxy_ValidationEventHandling()
  System.Void DtdParserProxy_OnNewLine(System.Int32 pos)
  System.Int32 get_DtdParserProxy_LineNo()
  System.Int32 get_DtdParserProxy_LineStartPosition()
  System.Int32 DtdParserProxy_ReadData()
  System.Int32 DtdParserProxy_ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder)
  System.Int32 DtdParserProxy_ParseNamedCharRef(System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder)
  System.Void DtdParserProxy_ParsePI(System.Text.StringBuilder sb)
  System.Void DtdParserProxy_ParseComment(System.Text.StringBuilder sb)
  System.Boolean get_IsResolverNull()
  System.Xml.XmlResolver GetTempResolver()
  System.Boolean DtdParserProxy_PushEntity(System.Xml.IDtdEntityInfo entity, System.Int32& entityId)
  System.Boolean DtdParserProxy_PopEntity(System.Xml.IDtdEntityInfo& oldEntity, System.Int32& newEntityId)
  System.Boolean DtdParserProxy_PushExternalSubset(System.String systemId, System.String publicId)
  System.Void DtdParserProxy_PushInternalDtd(System.String baseUri, System.String internalDtd)
  System.Void DtdParserProxy_Throw(System.Exception e)
  System.Void DtdParserProxy_OnSystemId(System.String systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo)
  System.Void DtdParserProxy_OnPublicId(System.String publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo)
  System.Void Throw(System.Int32 pos, System.String res, System.String arg)
  System.Void Throw(System.Int32 pos, System.String res, System.String[] args)
  System.Void Throw(System.Int32 pos, System.String res)
  System.Void Throw(System.String res)
  System.Void Throw(System.String res, System.Int32 lineNo, System.Int32 linePos)
  System.Void Throw(System.String res, System.String arg)
  System.Void Throw(System.String res, System.String arg, System.Int32 lineNo, System.Int32 linePos)
  System.Void Throw(System.String res, System.String[] args)
  System.Void Throw(System.String res, System.String arg, System.Exception innerException)
  System.Void Throw(System.String res, System.String[] args, System.Exception innerException)
  System.Void Throw(System.Exception e)
  System.Void ReThrow(System.Exception e, System.Int32 lineNo, System.Int32 linePos)
  System.Void ThrowWithoutLineInfo(System.String res)
  System.Void ThrowWithoutLineInfo(System.String res, System.String arg)
  System.Void ThrowWithoutLineInfo(System.String res, System.String[] args, System.Exception innerException)
  System.Void ThrowInvalidChar(System.Char[] data, System.Int32 length, System.Int32 invCharPos)
  System.Void SetErrorState()
  System.Void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.String code, System.String arg, System.Int32 lineNo, System.Int32 linePos)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException exception)
  System.Boolean get_InAttributeValueIterator()
  System.Void FinishAttributeValueIterator()
  System.Boolean get_DtdValidation()
  System.Void InitStreamInput(System.IO.Stream stream, System.Text.Encoding encoding)
  System.Void InitStreamInput(System.String baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding)
  System.Void InitStreamInput(System.Uri baseUri, System.IO.Stream stream, System.Text.Encoding encoding)
  System.Void InitStreamInput(System.Uri baseUri, System.String baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding)
  System.Void InitStreamInput(System.Uri baseUri, System.String baseUriStr, System.IO.Stream stream, System.Byte[] bytes, System.Int32 byteCount, System.Text.Encoding encoding)
  System.Void InitTextReaderInput(System.String baseUriStr, System.IO.TextReader input)
  System.Void InitTextReaderInput(System.String baseUriStr, System.Uri baseUri, System.IO.TextReader input)
  System.Void InitStringInput(System.String baseUriStr, System.Text.Encoding originalEncoding, System.String str)
  System.Void InitFragmentReader(System.Xml.XmlNodeType fragmentType, System.Xml.XmlParserContext parserContext, System.Boolean allowXmlDeclFragment)
  System.Void ProcessDtdFromParserContext(System.Xml.XmlParserContext context)
  System.Void OpenUrl()
  System.Void OpenUrlDelegate(System.Object xmlResolver)
  System.Text.Encoding DetectEncoding()
  System.Void SetupEncoding(System.Text.Encoding encoding)
  System.Void SwitchEncoding(System.Text.Encoding newEncoding)
  System.Text.Encoding CheckEncoding(System.String newEncodingName)
  System.Void UnDecodeChars()
  System.Void SwitchEncodingToUTF8()
  System.Int32 ReadData()
  System.Int32 GetChars(System.Int32 maxCharsCount)
  System.Void InvalidCharRecovery(System.Int32& bytesCount, System.Int32& charsCount)
  System.Void Close(System.Boolean closeInput)
  System.Void ShiftBuffer(System.Int32 sourcePos, System.Int32 destPos, System.Int32 count)
  System.Boolean ParseXmlDeclaration(System.Boolean isTextDecl)
  System.Boolean ParseDocumentContent()
  System.Boolean ParseElementContent()
  System.Void ThrowUnclosedElements()
  System.Void ParseElement()
  System.Void AddDefaultAttributesAndNormalize()
  System.Void ParseEndElement()
  System.Void ThrowTagMismatch(System.Xml.XmlTextReaderImpl.NodeData startTag)
  System.Void ParseAttributes()
  System.Void ElementNamespaceLookup()
  System.Void AttributeNamespaceLookup()
  System.Void AttributeDuplCheck()
  System.Void OnDefaultNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr)
  System.Void OnNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr)
  System.Void OnXmlReservedAttribute(System.Xml.XmlTextReaderImpl.NodeData attr)
  System.Void ParseAttributeValueSlow(System.Int32 curPos, System.Char quoteChar, System.Xml.XmlTextReaderImpl.NodeData attr)
  System.Void AddAttributeChunkToList(System.Xml.XmlTextReaderImpl.NodeData attr, System.Xml.XmlTextReaderImpl.NodeData chunk, System.Xml.XmlTextReaderImpl.NodeData& lastChunk)
  System.Boolean ParseText()
  System.Boolean ParseText(System.Int32& startPos, System.Int32& endPos, System.Int32& outOrChars)
  System.Void FinishPartialValue()
  System.Void FinishOtherValueIterator()
  System.Void SkipPartialTextValue()
  System.Void FinishReadValueChunk()
  System.Void FinishReadContentAsBinary()
  System.Void FinishReadElementContentAsBinary()
  System.Boolean ParseRootLevelWhitespace()
  System.Void ParseEntityReference()
  System.Xml.XmlTextReaderImpl.EntityType HandleEntityReference(System.Boolean isInAttributeValue, System.Xml.XmlTextReaderImpl.EntityExpandType expandType, System.Int32& charRefEndPos)
  System.Xml.XmlTextReaderImpl.EntityType HandleGeneralEntityReference(System.String name, System.Boolean isInAttributeValue, System.Boolean pushFakeEntityIfNullResolver, System.Int32 entityStartLinePos)
  System.Boolean get_InEntity()
  System.Boolean HandleEntityEnd(System.Boolean checkEntityNesting)
  System.Void SetupEndEntityNodeInContent()
  System.Void SetupEndEntityNodeInAttribute()
  System.Boolean ParsePI()
  System.Boolean ParsePI(System.Text.StringBuilder piInDtdStringBuilder)
  System.Boolean ParsePIValue(System.Int32& outStartPos, System.Int32& outEndPos)
  System.Boolean ParseComment()
  System.Void ParseCData()
  System.Void ParseCDataOrComment(System.Xml.XmlNodeType type)
  System.Boolean ParseCDataOrComment(System.Xml.XmlNodeType type, System.Int32& outStartPos, System.Int32& outEndPos)
  System.Boolean ParseDoctypeDecl()
  System.Void ParseDtd()
  System.Void SkipDtd()
  System.Void SkipPublicOrSystemIdLiteral()
  System.Void SkipUntil(System.Char stopChar, System.Boolean recognizeLiterals)
  System.Int32 EatWhitespaces(System.Text.StringBuilder sb)
  System.Int32 ParseCharRefInline(System.Int32 startPos, System.Int32& charCount, System.Xml.XmlTextReaderImpl.EntityType& entityType)
  System.Int32 ParseNumericCharRef(System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder, System.Xml.XmlTextReaderImpl.EntityType& entityType)
  System.Int32 ParseNumericCharRefInline(System.Int32 startPos, System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder, System.Int32& charCount, System.Xml.XmlTextReaderImpl.EntityType& entityType)
  System.Int32 ParseNamedCharRef(System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder)
  System.Int32 ParseNamedCharRefInline(System.Int32 startPos, System.Boolean expand, System.Text.StringBuilder internalSubsetBuilder)
  System.Int32 ParseName()
  System.Int32 ParseQName(System.Int32& colonPos)
  System.Int32 ParseQName(System.Boolean isQName, System.Int32 startOffset, System.Int32& colonPos)
  System.Boolean ReadDataInName(System.Int32& pos)
  System.String ParseEntityName()
  System.Xml.XmlTextReaderImpl.NodeData AddNode(System.Int32 nodeIndex, System.Int32 nodeDepth)
  System.Xml.XmlTextReaderImpl.NodeData AllocNode(System.Int32 nodeIndex, System.Int32 nodeDepth)
  System.Xml.XmlTextReaderImpl.NodeData AddAttributeNoChecks(System.String name, System.Int32 attrDepth)
  System.Xml.XmlTextReaderImpl.NodeData AddAttribute(System.Int32 endNamePos, System.Int32 colonPos)
  System.Xml.XmlTextReaderImpl.NodeData AddAttribute(System.String localName, System.String prefix, System.String nameWPrefix)
  System.Void PopElementContext()
  System.Void OnNewLine(System.Int32 pos)
  System.Void OnEof()
  System.String LookupNamespace(System.Xml.XmlTextReaderImpl.NodeData node)
  System.Void AddNamespace(System.String prefix, System.String uri, System.Xml.XmlTextReaderImpl.NodeData attr)
  System.Void ResetAttributes()
  System.Void FullAttributeCleanup()
  System.Void PushXmlContext()
  System.Void PopXmlContext()
  System.Xml.XmlNodeType GetWhitespaceType()
  System.Xml.XmlNodeType GetTextNodeType(System.Int32 orChars)
  System.Void PushExternalEntityOrSubset(System.String publicId, System.String systemId, System.Uri baseUri, System.String entityName)
  System.Boolean OpenAndPush(System.Uri uri)
  System.Boolean PushExternalEntity(System.Xml.IDtdEntityInfo entity)
  System.Void PushInternalEntity(System.Xml.IDtdEntityInfo entity)
  System.Void PopEntity()
  System.Void RegisterEntity(System.Xml.IDtdEntityInfo entity)
  System.Void UnregisterEntity()
  System.Void PushParsingState()
  System.Void PopParsingState()
  System.Int32 IncrementalRead()
  System.Void FinishIncrementalRead()
  System.Boolean ParseFragmentAttribute()
  System.Boolean ParseAttributeValueChunk()
  System.Void ParseXmlDeclarationFragment()
  System.Void ThrowUnexpectedToken(System.Int32 pos, System.String expectedToken)
  System.Void ThrowUnexpectedToken(System.String expectedToken1)
  System.Void ThrowUnexpectedToken(System.Int32 pos, System.String expectedToken1, System.String expectedToken2)
  System.Void ThrowUnexpectedToken(System.String expectedToken1, System.String expectedToken2)
  System.String ParseUnexpectedToken(System.Int32 pos)
  System.String ParseUnexpectedToken()
  System.Void ThrowExpectingWhitespace(System.Int32 pos)
  System.Int32 GetIndexOfAttributeWithoutPrefix(System.String name)
  System.Int32 GetIndexOfAttributeWithPrefix(System.String name)
  System.Boolean ZeroEndingStream(System.Int32 pos)
  System.Void ParseDtdFromParserContext()
  System.Boolean MoveToNextContentNode(System.Boolean moveIfOnContentNode)
  System.Void SetupFromParserContext(System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings)
  System.Xml.IDtdInfo get_DtdInfo()
  System.Void SetDtdInfo(System.Xml.IDtdInfo newDtdInfo)
  System.Void set_ValidationEventHandling(System.Xml.IValidationEventHandling value)
  System.Void set_OnDefaultAttributeUse(System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegate value)
  System.Void set_XmlValidatingReaderCompatibilityMode(System.Boolean value)
  System.Xml.XmlNodeType get_FragmentType()
  System.Void ChangeCurrentNodeType(System.Xml.XmlNodeType newNodeType)
  System.Xml.XmlResolver GetResolver()
  System.Void set_InternalSchemaType(System.Object value)
  System.Object get_InternalTypedValue()
  System.Void set_InternalTypedValue(System.Object value)
  System.Boolean get_StandAlone()
  System.Xml.XmlNamespaceManager get_NamespaceManager()
  System.Boolean get_V1Compat()
  System.Boolean AddDefaultAttributeDtd(System.Xml.IDtdDefaultAttributeInfo defAttrInfo, System.Boolean definedInDtd, System.Xml.XmlTextReaderImpl.NodeData[] nameSortedNodeData)
  System.Boolean AddDefaultAttributeNonDtd(System.Xml.Schema.SchemaAttDef attrDef)
  System.Xml.XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(System.String localName, System.String ns, System.String prefix, System.String value, System.Int32 lineNo, System.Int32 linePos, System.Int32 valueLineNo, System.Int32 valueLinePos, System.Boolean isXmlAttribute)
  System.Void set_DisableUndeclaredEntityCheck(System.Boolean value)
  System.Boolean UriEqual(System.Uri uri1, System.String uri1Str, System.String uri2Str, System.Xml.XmlResolver resolver)
  System.Void RegisterConsumedCharacters(System.Int64 characters, System.Boolean inEntityReference)
  System.String StripSpaces(System.String value)
  System.Void StripSpaces(System.Char[] value, System.Int32 index, System.Int32& len)
  System.Void BlockCopyChars(System.Char[] src, System.Int32 srcOffset, System.Char[] dst, System.Int32 dstOffset, System.Int32 count)
  System.Void BlockCopy(System.Byte[] src, System.Int32 srcOffset, System.Byte[] dst, System.Int32 dstOffset, System.Int32 count)
END_CLASS

CLASS: System.Xml.Formatting
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Formatting           None  // 0x0
  public    static  System.Xml.Formatting           Indented  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlTextWriter
TYPE:  class
TOKEN: 0x2000066
EXTENDS: XmlWriter
FIELDS:
  private           System.IO.TextWriter            textWriter  // 0x18
  private           System.Xml.XmlTextEncoder       xmlEncoder  // 0x20
  private           System.Text.Encoding            encoding  // 0x28
  private           System.Xml.Formatting           formatting  // 0x30
  private           System.Boolean                  indented  // 0x34
  private           System.Int32                    indentation  // 0x38
  private           System.Char                     indentChar  // 0x3C
  private           System.Xml.XmlTextWriter.TagInfo[]stack  // 0x40
  private           System.Int32                    top  // 0x48
  private           System.Xml.XmlTextWriter.State[]stateTable  // 0x50
  private           System.Xml.XmlTextWriter.State  currentState  // 0x58
  private           System.Xml.XmlTextWriter.Token  lastToken  // 0x5C
  private           System.Xml.XmlTextWriterBase64Encoderbase64Encoder  // 0x60
  private           System.Char                     quoteChar  // 0x68
  private           System.Char                     curQuoteChar  // 0x6A
  private           System.Boolean                  namespaces  // 0x6C
  private           System.Xml.XmlTextWriter.SpecialAttrspecialAttr  // 0x70
  private           System.String                   prefixForXmlNs  // 0x78
  private           System.Boolean                  flush  // 0x80
  private           System.Xml.XmlTextWriter.Namespace[]nsStack  // 0x88
  private           System.Int32                    nsTop  // 0x90
  private           System.Collections.Generic.Dictionary<System.String,System.Int32>nsHashtable  // 0x98
  private           System.Boolean                  useNsHashtable  // 0xA0
  private           System.Xml.XmlCharType          xmlCharType  // 0xA8
  private   static  System.String[]                 stateName  // 0x0
  private   static  System.String[]                 tokenName  // 0x8
  private   static readonly System.Xml.XmlTextWriter.State[]stateTableDefault  // 0x10
  private   static readonly System.Xml.XmlTextWriter.State[]stateTableDocument  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.IO.Stream w, System.Text.Encoding encoding)
  System.Void .ctor(System.String filename, System.Text.Encoding encoding)
  System.Void .ctor(System.IO.TextWriter w)
  System.IO.Stream get_BaseStream()
  System.Void set_Namespaces(System.Boolean value)
  System.Void set_Formatting(System.Xml.Formatting value)
  System.Void set_QuoteChar(System.Char value)
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
  System.Void StartDocument(System.Int32 standalone)
  System.Void AutoComplete(System.Xml.XmlTextWriter.Token token)
  System.Void AutoCompleteAll()
  System.Void InternalWriteEndElement(System.Boolean longFormat)
  System.Void WriteEndStartTag(System.Boolean empty)
  System.Void WriteEndAttributeQuote()
  System.Void Indent(System.Boolean beforeEndElement)
  System.Void PushNamespace(System.String prefix, System.String ns, System.Boolean declared)
  System.Void AddNamespace(System.String prefix, System.String ns, System.Boolean declared)
  System.Void AddToNamespaceHashtable(System.Int32 namespaceIndex)
  System.Void PopNamespaces(System.Int32 indexFrom, System.Int32 indexTo)
  System.String GeneratePrefix()
  System.Void InternalWriteProcessingInstruction(System.String name, System.String text)
  System.Int32 LookupNamespace(System.String prefix)
  System.Int32 LookupNamespaceInCurrentScope(System.String prefix)
  System.String FindPrefix(System.String ns)
  System.Void ValidateName(System.String name, System.Boolean isNCName)
  System.Void HandleSpecialAttribute()
  System.Void VerifyPrefixXml(System.String prefix, System.String ns)
  System.Void PushStack()
  System.Void FlushEncoders()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.XmlUtf8RawTextWriter
TYPE:  class
TOKEN: 0x200006D
EXTENDS: XmlRawWriter
FIELDS:
  private   readonly System.Boolean                  useAsync  // 0x28
  protected         System.Byte[]                   bufBytes  // 0x30
  protected         System.IO.Stream                stream  // 0x38
  protected         System.Text.Encoding            encoding  // 0x40
  protected         System.Xml.XmlCharType          xmlCharType  // 0x48
  protected         System.Int32                    bufPos  // 0x50
  protected         System.Int32                    textPos  // 0x54
  protected         System.Int32                    contentPos  // 0x58
  protected         System.Int32                    cdataPos  // 0x5C
  protected         System.Int32                    attrEndPos  // 0x60
  protected         System.Int32                    bufLen  // 0x64
  protected         System.Boolean                  writeToNull  // 0x68
  protected         System.Boolean                  hadDoubleBracket  // 0x69
  protected         System.Boolean                  inAttributeValue  // 0x6A
  protected         System.Xml.NewLineHandling      newLineHandling  // 0x6C
  protected         System.Boolean                  closeOutput  // 0x70
  protected         System.Boolean                  omitXmlDeclaration  // 0x71
  protected         System.String                   newLineChars  // 0x78
  protected         System.Boolean                  checkCharacters  // 0x80
  protected         System.Xml.XmlStandalone        standalone  // 0x84
  protected         System.Xml.XmlOutputMethod      outputMethod  // 0x88
  protected         System.Boolean                  autoXmlDeclaration  // 0x8C
  protected         System.Boolean                  mergeCDataSections  // 0x8D
METHODS:
  System.Void .ctor(System.Xml.XmlWriterSettings settings)
  System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings)
  System.Void WriteXmlDeclaration(System.Xml.XmlStandalone standalone)
  System.Void WriteXmlDeclaration(System.String xmldecl)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void StartElementContent()
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndAttribute()
  System.Void WriteNamespaceDeclaration(System.String prefix, System.String namespaceName)
  System.Boolean get_SupportsNamespaceDeclarationInChunks()
  System.Void WriteStartNamespaceDeclaration(System.String prefix)
  System.Void WriteEndNamespaceDeclaration()
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
  System.Void Close()
  System.Void Flush()
  System.Void FlushBuffer()
  System.Void FlushEncoder()
  System.Void WriteAttributeTextBlock(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void WriteElementTextBlock(System.Char* pSrc, System.Char* pSrcEnd)
  System.Void RawText(System.String s)
  System.Void RawText(System.Char* pSrcBegin, System.Char* pSrcEnd)
  System.Void WriteRawWithCharChecking(System.Char* pSrcBegin, System.Char* pSrcEnd)
  System.Void WriteCommentOrPi(System.String text, System.Int32 stopChar)
  System.Void WriteCDataSection(System.String text)
  System.Boolean IsSurrogateByte(System.Byte b)
  System.Byte* EncodeSurrogate(System.Char* pSrc, System.Char* pSrcEnd, System.Byte* pDst)
  System.Byte* InvalidXmlChar(System.Int32 ch, System.Byte* pDst, System.Boolean entitize)
  System.Void EncodeChar(System.Char*& pSrc, System.Char* pSrcEnd, System.Byte*& pDst)
  System.Byte* EncodeMultibyteUTF8(System.Int32 ch, System.Byte* pDst)
  System.Void CharToUTF8(System.Char*& pSrc, System.Char* pSrcEnd, System.Byte*& pDst)
  System.Byte* WriteNewLine(System.Byte* pDst)
  System.Byte* LtEntity(System.Byte* pDst)
  System.Byte* GtEntity(System.Byte* pDst)
  System.Byte* AmpEntity(System.Byte* pDst)
  System.Byte* QuoteEntity(System.Byte* pDst)
  System.Byte* TabEntity(System.Byte* pDst)
  System.Byte* LineFeedEntity(System.Byte* pDst)
  System.Byte* CarriageReturnEntity(System.Byte* pDst)
  System.Byte* CharEntity(System.Byte* pDst, System.Char ch)
  System.Byte* RawStartCData(System.Byte* pDst)
  System.Byte* RawEndCData(System.Byte* pDst)
  System.Void ValidateContentChars(System.String chars, System.String propertyName, System.Boolean allowOnlyWhitespace)
END_CLASS

CLASS: System.Xml.XmlUtf8RawTextWriterIndent
TYPE:  class
TOKEN: 0x200006E
EXTENDS: XmlUtf8RawTextWriter
FIELDS:
  protected         System.Int32                    indentLevel  // 0x90
  protected         System.Boolean                  newLineOnAttributes  // 0x94
  protected         System.String                   indentChars  // 0x98
  protected         System.Boolean                  mixedContent  // 0xA0
  private           System.Xml.BitStack             mixedContentStack  // 0xA8
  protected         System.Xml.ConformanceLevel     conformanceLevel  // 0xB0
METHODS:
  System.Void .ctor(System.IO.Stream stream, System.Xml.XmlWriterSettings settings)
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void StartElementContent()
  System.Void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel)
  System.Void WriteEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteFullEndElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String ns)
  System.Void WriteCData(System.String text)
  System.Void WriteComment(System.String text)
  System.Void WriteProcessingInstruction(System.String target, System.String text)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteWhitespace(System.String ws)
  System.Void WriteString(System.String text)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.String data)
  System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Void Init(System.Xml.XmlWriterSettings settings)
  System.Void WriteIndent()
END_CLASS

CLASS: System.Xml.XmlValidatingReader
TYPE:  class
TOKEN: 0x200006F
EXTENDS: XmlReader
FIELDS:
  private           System.Xml.XmlValidatingReaderImplimpl  // 0x10
METHODS:
  System.Xml.XmlNodeType get_NodeType()
  System.String get_LocalName()
  System.String get_NamespaceURI()
  System.String get_Prefix()
  System.String get_Value()
  System.Int32 get_Depth()
  System.String get_BaseURI()
  System.Boolean get_IsEmptyElement()
  System.Int32 get_AttributeCount()
  System.String GetAttribute(System.String name)
  System.String GetAttribute(System.String localName, System.String namespaceURI)
  System.String GetAttribute(System.Int32 i)
  System.Boolean MoveToAttribute(System.String name)
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
  System.Boolean MoveToElement()
  System.Boolean ReadAttributeValue()
  System.Boolean Read()
  System.Boolean get_EOF()
  System.Xml.ReadState get_ReadState()
  System.Xml.XmlNameTable get_NameTable()
  System.String LookupNamespace(System.String prefix)
  System.Void ResolveEntity()
  System.Boolean get_Namespaces()
END_CLASS

CLASS: System.Xml.XmlValidatingReaderImpl
TYPE:  class
TOKEN: 0x2000070
EXTENDS: XmlReader
FIELDS:
  private           System.Xml.XmlReader            coreReader  // 0x10
  private           System.Xml.XmlTextReaderImpl    coreReaderImpl  // 0x18
  private           System.Xml.IXmlNamespaceResolvercoreReaderNSResolver  // 0x20
  private           System.Xml.ValidationType       validationType  // 0x28
  private           System.Xml.Schema.BaseValidator validator  // 0x30
  private           System.Xml.Schema.XmlSchemaCollectionschemaCollection  // 0x38
  private           System.Boolean                  processIdentityConstraints  // 0x40
  private           System.Xml.XmlValidatingReaderImpl.ParsingFunctionparsingFunction  // 0x44
  private           System.Xml.XmlValidatingReaderImpl.ValidationEventHandlingeventHandling  // 0x48
  private           System.Xml.XmlParserContext     parserContext  // 0x50
  private           System.Xml.ReadContentAsBinaryHelperreadBinaryHelper  // 0x58
  private           System.Xml.XmlReader            outerReader  // 0x60
  private   static  System.Xml.XmlResolver          s_tempResolver  // 0x0
METHODS:
  System.Void .ctor(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler settingsEventHandler, System.Boolean processIdentityConstraints)
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
  System.Xml.ReadState get_ReadState()
  System.Boolean get_EOF()
  System.Xml.XmlNameTable get_NameTable()
  System.Int32 get_AttributeCount()
  System.String GetAttribute(System.String name)
  System.String GetAttribute(System.String localName, System.String namespaceURI)
  System.String GetAttribute(System.Int32 i)
  System.Boolean MoveToAttribute(System.String name)
  System.Void MoveToAttribute(System.Int32 i)
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
  System.Boolean MoveToElement()
  System.Boolean Read()
  System.Void Close()
  System.String LookupNamespace(System.String prefix)
  System.Boolean ReadAttributeValue()
  System.Boolean get_CanResolveEntity()
  System.Void ResolveEntity()
  System.Void MoveOffEntityReference()
  System.String ReadString()
  System.Boolean HasLineInfo()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
  System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix)
  System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName)
  System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String LookupPrefix(System.String namespaceName)
  System.Xml.ValidationType get_ValidationType()
  System.Xml.Schema.XmlSchemaCollection get_Schemas()
  System.Boolean get_Namespaces()
  System.Void ParseDtdFromParserContext()
  System.Void ValidateDtd()
  System.Void ResolveEntityInternally()
  System.Void SetupValidation(System.Xml.ValidationType valType)
  System.Xml.XmlResolver GetResolver()
  System.Void ProcessCoreReaderEvent()
  System.Xml.Schema.BaseValidator get_Validator()
  System.Void set_Validator(System.Xml.Schema.BaseValidator value)
  System.Xml.XmlNamespaceManager get_NamespaceManager()
  System.Boolean get_StandAlone()
  System.Void set_SchemaTypeObject(System.Object value)
  System.Object get_TypedValueObject()
  System.Void set_TypedValueObject(System.Object value)
  System.Boolean AddDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef)
  System.Xml.IDtdInfo get_DtdInfo()
  System.Void ValidateDefaultAttributeOnUse(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader)
END_CLASS

CLASS: System.Xml.XmlWellFormedWriter
TYPE:  class
TOKEN: 0x2000073
EXTENDS: XmlWriter
FIELDS:
  private           System.Xml.XmlWriter            writer  // 0x18
  private           System.Xml.XmlRawWriter         rawWriter  // 0x20
  private           System.Xml.IXmlNamespaceResolverpredefinedNamespaces  // 0x28
  private           System.Xml.XmlWellFormedWriter.Namespace[]nsStack  // 0x30
  private           System.Int32                    nsTop  // 0x38
  private           System.Collections.Generic.Dictionary<System.String,System.Int32>nsHashtable  // 0x40
  private           System.Boolean                  useNsHashtable  // 0x48
  private           System.Xml.XmlWellFormedWriter.ElementScope[]elemScopeStack  // 0x50
  private           System.Int32                    elemTop  // 0x58
  private           System.Xml.XmlWellFormedWriter.AttrName[]attrStack  // 0x60
  private           System.Int32                    attrCount  // 0x68
  private           System.Collections.Generic.Dictionary<System.String,System.Int32>attrHashTable  // 0x70
  private           System.Xml.XmlWellFormedWriter.SpecialAttributespecAttr  // 0x78
  private           System.Xml.XmlWellFormedWriter.AttributeValueCacheattrValueCache  // 0x80
  private           System.String                   curDeclPrefix  // 0x88
  private           System.Xml.XmlWellFormedWriter.State[]stateTable  // 0x90
  private           System.Xml.XmlWellFormedWriter.StatecurrentState  // 0x98
  private           System.Boolean                  checkCharacters  // 0x9C
  private           System.Boolean                  omitDuplNamespaces  // 0x9D
  private           System.Boolean                  writeEndDocumentOnClose  // 0x9E
  private           System.Xml.ConformanceLevel     conformanceLevel  // 0xA0
  private           System.Boolean                  dtdWritten  // 0xA4
  private           System.Boolean                  xmlDeclFollows  // 0xA5
  private           System.Xml.XmlCharType          xmlCharType  // 0xA8
  private           System.Xml.SecureStringHasher   hasher  // 0xB0
  private   static readonly System.String[]                 stateName  // 0x0
  private   static readonly System.String[]                 tokenName  // 0x8
  private   static  System.Xml.WriteState[]         state2WriteState  // 0x10
  private   static readonly System.Xml.XmlWellFormedWriter.State[]StateTableDocument  // 0x18
  private   static readonly System.Xml.XmlWellFormedWriter.State[]StateTableAuto  // 0x20
METHODS:
  System.Void .ctor(System.Xml.XmlWriter writer, System.Xml.XmlWriterSettings settings)
  System.Xml.WriteState get_WriteState()
  System.Void WriteStartDocument()
  System.Void WriteStartDocument(System.Boolean standalone)
  System.Void WriteEndDocument()
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteEndElement()
  System.Void WriteFullEndElement()
  System.Void WriteStartAttribute(System.String prefix, System.String localName, System.String namespaceName)
  System.Void WriteEndAttribute()
  System.Void WriteCData(System.String text)
  System.Void WriteComment(System.String text)
  System.Void WriteProcessingInstruction(System.String name, System.String text)
  System.Void WriteEntityRef(System.String name)
  System.Void WriteCharEntity(System.Char ch)
  System.Void WriteSurrogateCharEntity(System.Char lowChar, System.Char highChar)
  System.Void WriteWhitespace(System.String ws)
  System.Void WriteString(System.String text)
  System.Void WriteChars(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.Char[] buffer, System.Int32 index, System.Int32 count)
  System.Void WriteRaw(System.String data)
  System.Void WriteBase64(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Void Close()
  System.Void Flush()
  System.String LookupPrefix(System.String ns)
  System.Void WriteValue(System.Boolean value)
  System.Void WriteValue(System.DateTime value)
  System.Void WriteValue(System.Double value)
  System.Void WriteValue(System.Single value)
  System.Void WriteValue(System.Decimal value)
  System.Void WriteValue(System.Int32 value)
  System.Void WriteValue(System.Int64 value)
  System.Void WriteValue(System.String value)
  System.Void WriteValue(System.Object value)
  System.Void WriteBinHex(System.Byte[] buffer, System.Int32 index, System.Int32 count)
  System.Xml.XmlRawWriter get_RawWriter()
  System.Boolean get_SaveAttrValue()
  System.Boolean get_InBase64()
  System.Void SetSpecialAttribute(System.Xml.XmlWellFormedWriter.SpecialAttribute special)
  System.Void WriteStartDocumentImpl(System.Xml.XmlStandalone standalone)
  System.Void StartFragment()
  System.Void PushNamespaceImplicit(System.String prefix, System.String ns)
  System.Boolean PushNamespaceExplicit(System.String prefix, System.String ns)
  System.Void AddNamespace(System.String prefix, System.String ns, System.Xml.XmlWellFormedWriter.NamespaceKind kind)
  System.Void AddToNamespaceHashtable(System.Int32 namespaceIndex)
  System.Int32 LookupNamespaceIndex(System.String prefix)
  System.Void PopNamespaces(System.Int32 indexFrom, System.Int32 indexTo)
  System.Xml.XmlException DupAttrException(System.String prefix, System.String localName)
  System.Void AdvanceState(System.Xml.XmlWellFormedWriter.Token token)
  System.Void StartElementContent()
  System.String GetStateName(System.Xml.XmlWellFormedWriter.State state)
  System.String LookupNamespace(System.String prefix)
  System.String LookupLocalNamespace(System.String prefix)
  System.String GeneratePrefix()
  System.Void CheckNCName(System.String ncname)
  System.Exception InvalidCharsException(System.String name, System.Int32 badCharIndex)
  System.Void ThrowInvalidStateTransition(System.Xml.XmlWellFormedWriter.Token token, System.Xml.XmlWellFormedWriter.State currentState)
  System.Boolean get_IsClosedOrErrorState()
  System.Void AddAttribute(System.String prefix, System.String localName, System.String namespaceName)
  System.Void AddToAttrHashTable(System.Int32 attributeIndex)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.WriteState
TYPE:  struct
TOKEN: 0x2000080
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.WriteState           Start  // 0x0
  public    static  System.Xml.WriteState           Prolog  // 0x0
  public    static  System.Xml.WriteState           Element  // 0x0
  public    static  System.Xml.WriteState           Attribute  // 0x0
  public    static  System.Xml.WriteState           Content  // 0x0
  public    static  System.Xml.WriteState           Closed  // 0x0
  public    static  System.Xml.WriteState           Error  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlWriter
TYPE:  class
TOKEN: 0x2000081
FIELDS:
  private           System.Char[]                   writeNodeBuffer  // 0x10
METHODS:
  System.Void WriteStartDocument()
  System.Void WriteStartDocument(System.Boolean standalone)
  System.Void WriteEndDocument()
  System.Void WriteDocType(System.String name, System.String pubid, System.String sysid, System.String subset)
  System.Void WriteStartElement(System.String localName, System.String ns)
  System.Void WriteStartElement(System.String prefix, System.String localName, System.String ns)
  System.Void WriteStartElement(System.String localName)
  System.Void WriteEndElement()
  System.Void WriteFullEndElement()
  System.Void WriteAttributeString(System.String localName, System.String ns, System.String value)
  System.Void WriteAttributeString(System.String localName, System.String value)
  System.Void WriteAttributeString(System.String prefix, System.String localName, System.String ns, System.String value)
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
  System.Void WriteValue(System.Object value)
  System.Void WriteValue(System.String value)
  System.Void WriteValue(System.Boolean value)
  System.Void WriteValue(System.DateTime value)
  System.Void WriteValue(System.Double value)
  System.Void WriteValue(System.Single value)
  System.Void WriteValue(System.Decimal value)
  System.Void WriteValue(System.Int32 value)
  System.Void WriteValue(System.Int64 value)
  System.Void WriteAttributes(System.Xml.XmlReader reader, System.Boolean defattr)
  System.Void WriteNode(System.Xml.XmlReader reader, System.Boolean defattr)
  System.Void WriteElementString(System.String localName, System.String ns, System.String value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Xml.XmlWriter Create(System.IO.Stream output, System.Xml.XmlWriterSettings settings)
  System.Xml.XmlWriter Create(System.IO.TextWriter output)
  System.Xml.XmlWriter Create(System.IO.TextWriter output, System.Xml.XmlWriterSettings settings)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.XmlOutputMethod
TYPE:  struct
TOKEN: 0x2000082
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlOutputMethod      Xml  // 0x0
  public    static  System.Xml.XmlOutputMethod      Html  // 0x0
  public    static  System.Xml.XmlOutputMethod      Text  // 0x0
  public    static  System.Xml.XmlOutputMethod      AutoDetect  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.TriState
TYPE:  struct
TOKEN: 0x2000083
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.TriState             Unknown  // 0x0
  public    static  System.Xml.TriState             False  // 0x0
  public    static  System.Xml.TriState             True  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlStandalone
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlStandalone        Omit  // 0x0
  public    static  System.Xml.XmlStandalone        Yes  // 0x0
  public    static  System.Xml.XmlStandalone        No  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlWriterSettings
TYPE:  class
TOKEN: 0x2000085
FIELDS:
  private           System.Boolean                  useAsync  // 0x10
  private           System.Text.Encoding            encoding  // 0x18
  private           System.Boolean                  omitXmlDecl  // 0x20
  private           System.Xml.NewLineHandling      newLineHandling  // 0x24
  private           System.String                   newLineChars  // 0x28
  private           System.Xml.TriState             indent  // 0x30
  private           System.String                   indentChars  // 0x38
  private           System.Boolean                  newLineOnAttributes  // 0x40
  private           System.Boolean                  closeOutput  // 0x41
  private           System.Xml.NamespaceHandling    namespaceHandling  // 0x44
  private           System.Xml.ConformanceLevel     conformanceLevel  // 0x48
  private           System.Boolean                  checkCharacters  // 0x4C
  private           System.Boolean                  writeEndDocumentOnClose  // 0x4D
  private           System.Xml.XmlOutputMethod      outputMethod  // 0x50
  private           System.Collections.Generic.List<System.Xml.XmlQualifiedName>cdataSections  // 0x58
  private           System.Boolean                  doNotEscapeUriAttributes  // 0x60
  private           System.Boolean                  mergeCDataSections  // 0x61
  private           System.String                   mediaType  // 0x68
  private           System.String                   docTypeSystem  // 0x70
  private           System.String                   docTypePublic  // 0x78
  private           System.Xml.XmlStandalone        standalone  // 0x80
  private           System.Boolean                  autoXmlDecl  // 0x84
  private           System.Boolean                  isReadOnly  // 0x85
METHODS:
  System.Void .ctor()
  System.Boolean get_Async()
  System.Text.Encoding get_Encoding()
  System.Boolean get_OmitXmlDeclaration()
  System.Void set_OmitXmlDeclaration(System.Boolean value)
  System.Xml.NewLineHandling get_NewLineHandling()
  System.String get_NewLineChars()
  System.Boolean get_Indent()
  System.Void set_Indent(System.Boolean value)
  System.String get_IndentChars()
  System.Boolean get_NewLineOnAttributes()
  System.Boolean get_CloseOutput()
  System.Xml.ConformanceLevel get_ConformanceLevel()
  System.Void set_ConformanceLevel(System.Xml.ConformanceLevel value)
  System.Boolean get_CheckCharacters()
  System.Xml.NamespaceHandling get_NamespaceHandling()
  System.Void set_NamespaceHandling(System.Xml.NamespaceHandling value)
  System.Boolean get_WriteEndDocumentOnClose()
  System.Xml.XmlOutputMethod get_OutputMethod()
  System.Void set_OutputMethod(System.Xml.XmlOutputMethod value)
  System.Xml.XmlWriterSettings Clone()
  System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements()
  System.Boolean get_DoNotEscapeUriAttributes()
  System.Boolean get_MergeCDataSections()
  System.String get_MediaType()
  System.String get_DocTypeSystem()
  System.String get_DocTypePublic()
  System.Xml.XmlStandalone get_Standalone()
  System.Boolean get_AutoXmlDeclaration()
  System.Xml.TriState get_IndentInternal()
  System.Boolean get_IsQuerySpecific()
  System.Xml.XmlWriter CreateWriter(System.IO.Stream output)
  System.Xml.XmlWriter CreateWriter(System.IO.TextWriter output)
  System.Void set_ReadOnly(System.Boolean value)
  System.Void CheckReadOnly(System.String propertyName)
  System.Void Initialize()
END_CLASS

CLASS: System.Xml.XsdCachingReader
TYPE:  class
TOKEN: 0x2000086
EXTENDS: XmlReader
FIELDS:
  private           System.Xml.XmlReader            coreReader  // 0x10
  private           System.Xml.XmlNameTable         coreReaderNameTable  // 0x18
  private           System.Xml.ValidatingReaderNodeData[]contentEvents  // 0x20
  private           System.Xml.ValidatingReaderNodeData[]attributeEvents  // 0x28
  private           System.Xml.ValidatingReaderNodeDatacachedNode  // 0x30
  private           System.Xml.XsdCachingReader.CachingReaderStatecacheState  // 0x38
  private           System.Int32                    contentIndex  // 0x3C
  private           System.Int32                    attributeCount  // 0x40
  private           System.Boolean                  returnOriginalStringValues  // 0x44
  private           System.Xml.CachingEventHandler  cacheHandler  // 0x48
  private           System.Int32                    currentAttrIndex  // 0x50
  private           System.Int32                    currentContentIndex  // 0x54
  private           System.Boolean                  readAhead  // 0x58
  private           System.Xml.IXmlLineInfo         lineInfo  // 0x60
  private           System.Xml.ValidatingReaderNodeDatatextNode  // 0x68
METHODS:
  System.Void .ctor(System.Xml.XmlReader reader, System.Xml.IXmlLineInfo lineInfo, System.Xml.CachingEventHandler handlerMethod)
  System.Void Init()
  System.Void Reset(System.Xml.XmlReader reader)
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
  System.String GetAttribute(System.String name, System.String namespaceURI)
  System.String GetAttribute(System.Int32 i)
  System.Boolean MoveToAttribute(System.String name)
  System.Void MoveToAttribute(System.Int32 i)
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
  System.Boolean MoveToElement()
  System.Boolean Read()
  System.Xml.ValidatingReaderNodeData RecordTextNode(System.String textValue, System.String originalStringValue, System.Int32 depth, System.Int32 lineNo, System.Int32 linePos)
  System.Void SwitchTextNodeAndEndElement(System.String textValue, System.String originalStringValue)
  System.Void RecordEndElementNode()
  System.String ReadOriginalContentAsString()
  System.Boolean get_EOF()
  System.Void Close()
  System.Xml.ReadState get_ReadState()
  System.Void Skip()
  System.Xml.XmlNameTable get_NameTable()
  System.String LookupNamespace(System.String prefix)
  System.Void ResolveEntity()
  System.Boolean ReadAttributeValue()
  System.Boolean System.Xml.IXmlLineInfo.HasLineInfo()
  System.Int32 System.Xml.IXmlLineInfo.get_LineNumber()
  System.Int32 System.Xml.IXmlLineInfo.get_LinePosition()
  System.Void SetToReplayMode()
  System.Xml.XmlReader GetCoreReader()
  System.Xml.IXmlLineInfo GetLineInfo()
  System.Void ClearAttributesInfo()
  System.Xml.ValidatingReaderNodeData AddAttribute(System.Int32 attIndex)
  System.Xml.ValidatingReaderNodeData AddContent(System.Xml.XmlNodeType nodeType)
  System.Void RecordAttributes()
  System.Int32 GetAttributeIndexWithoutPrefix(System.String name)
  System.Int32 GetAttributeIndexWithPrefix(System.String name)
  System.Xml.ValidatingReaderNodeData CreateDummyTextNode(System.String attributeValue, System.Int32 depth)
END_CLASS

CLASS: System.Xml.CachingEventHandler
TYPE:  class
TOKEN: 0x2000088
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Xml.XsdCachingReader cachingReader)
END_CLASS

CLASS: System.Xml.AttributePSVIInfo
TYPE:  class
TOKEN: 0x2000089
FIELDS:
  private           System.String                   localName  // 0x10
  private           System.String                   namespaceUri  // 0x18
  private           System.Object                   typedAttributeValue  // 0x20
  private           System.Xml.Schema.XmlSchemaInfo attributeSchemaInfo  // 0x28
METHODS:
  System.Void .ctor()
  System.Void Reset()
END_CLASS

CLASS: System.Xml.XsdValidatingReader
TYPE:  class
TOKEN: 0x200008A
EXTENDS: XmlReader
FIELDS:
  private           System.Xml.XmlReader            coreReader  // 0x10
  private           System.Xml.IXmlNamespaceResolvercoreReaderNSResolver  // 0x18
  private           System.Xml.IXmlNamespaceResolverthisNSResolver  // 0x20
  private           System.Xml.Schema.XmlSchemaValidatorvalidator  // 0x28
  private           System.Xml.XmlResolver          xmlResolver  // 0x30
  private           System.Xml.Schema.ValidationEventHandlervalidationEvent  // 0x38
  private           System.Xml.XsdValidatingReader.ValidatingReaderStatevalidationState  // 0x40
  private           System.Xml.Schema.XmlValueGettervalueGetter  // 0x48
  private           System.Xml.XmlNamespaceManager  nsManager  // 0x50
  private           System.Boolean                  manageNamespaces  // 0x58
  private           System.Boolean                  processInlineSchema  // 0x59
  private           System.Boolean                  replayCache  // 0x5A
  private           System.Xml.ValidatingReaderNodeDatacachedNode  // 0x60
  private           System.Xml.AttributePSVIInfo    attributePSVI  // 0x68
  private           System.Int32                    attributeCount  // 0x70
  private           System.Int32                    coreReaderAttributeCount  // 0x74
  private           System.Int32                    currentAttrIndex  // 0x78
  private           System.Xml.AttributePSVIInfo[]  attributePSVINodes  // 0x80
  private           System.Collections.ArrayList    defaultAttributes  // 0x88
  private           System.Xml.Schema.Parser        inlineSchemaParser  // 0x90
  private           System.Object                   atomicValue  // 0x98
  private           System.Xml.Schema.XmlSchemaInfo xmlSchemaInfo  // 0xA0
  private           System.String                   originalAtomicValueString  // 0xA8
  private           System.Xml.XmlNameTable         coreReaderNameTable  // 0xB0
  private           System.Xml.XsdCachingReader     cachingReader  // 0xB8
  private           System.Xml.ValidatingReaderNodeDatatextNode  // 0xC0
  private           System.String                   NsXmlNs  // 0xC8
  private           System.String                   NsXs  // 0xD0
  private           System.String                   NsXsi  // 0xD8
  private           System.String                   XsiType  // 0xE0
  private           System.String                   XsiNil  // 0xE8
  private           System.String                   XsdSchema  // 0xF0
  private           System.String                   XsiSchemaLocation  // 0xF8
  private           System.String                   XsiNoNamespaceSchemaLocation  // 0x100
  private           System.Xml.XmlCharType          xmlCharType  // 0x108
  private           System.Xml.IXmlLineInfo         lineInfo  // 0x110
  private           System.Xml.ReadContentAsBinaryHelperreadBinaryHelper  // 0x118
  private           System.Xml.XsdValidatingReader.ValidatingReaderStatesavedState  // 0x120
  private   static  System.Type                     TypeOfString  // 0x0
METHODS:
  System.Void .ctor(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings, System.Xml.Schema.XmlSchemaObject partialValidationType)
  System.Void .ctor(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings)
  System.Void Init()
  System.Void SetupValidator(System.Xml.XmlReaderSettings readerSettings, System.Xml.XmlReader reader, System.Xml.Schema.XmlSchemaObject partialValidationType)
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
  System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo()
  System.Type get_ValueType()
  System.String ReadContentAsString()
  System.Int32 get_AttributeCount()
  System.String GetAttribute(System.String name)
  System.String GetAttribute(System.String name, System.String namespaceURI)
  System.String GetAttribute(System.Int32 i)
  System.Boolean MoveToAttribute(System.String name)
  System.Void MoveToAttribute(System.Int32 i)
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
  System.Boolean MoveToElement()
  System.Boolean Read()
  System.Boolean get_EOF()
  System.Void Close()
  System.Xml.ReadState get_ReadState()
  System.Void Skip()
  System.Xml.XmlNameTable get_NameTable()
  System.String LookupNamespace(System.String prefix)
  System.Void ResolveEntity()
  System.Boolean ReadAttributeValue()
  System.Boolean System.Xml.Schema.IXmlSchemaInfo.get_IsDefault()
  System.Boolean System.Xml.Schema.IXmlSchemaInfo.get_IsNil()
  System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity()
  System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType()
  System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType()
  System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement()
  System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute()
  System.Boolean HasLineInfo()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
  System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix)
  System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName)
  System.Object GetStringValue()
  System.Xml.Schema.XmlSchemaType get_ElementXmlType()
  System.Xml.Schema.XmlSchemaType get_AttributeXmlType()
  System.Xml.Schema.XmlSchemaInfo get_AttributeSchemaInfo()
  System.Void ProcessReaderEvent()
  System.Void ProcessElementEvent()
  System.Void ProcessEndElementEvent()
  System.Void ValidateAttributes()
  System.Void ClearAttributesInfo()
  System.Xml.AttributePSVIInfo GetAttributePSVI(System.String name)
  System.Xml.AttributePSVIInfo GetAttributePSVI(System.String localName, System.String ns)
  System.Xml.ValidatingReaderNodeData GetDefaultAttribute(System.String name, System.Boolean updatePosition)
  System.Xml.ValidatingReaderNodeData GetDefaultAttribute(System.String attrLocalName, System.String ns, System.Boolean updatePosition)
  System.Xml.AttributePSVIInfo AddAttributePSVI(System.Int32 attIndex)
  System.Boolean IsXSDRoot(System.String localName, System.String ns)
  System.Void ProcessInlineSchema()
  System.Object InternalReadContentAsObject()
  System.Object InternalReadContentAsObject(System.Boolean unwrapTypedValue)
  System.Object InternalReadContentAsObject(System.Boolean unwrapTypedValue, System.String& originalStringValue)
  System.Object ReadTillEndElement()
  System.Void SwitchReader()
  System.Void ReadAheadForMemberType()
  System.Void GetIsDefault()
  System.Void GetMemberType()
  System.Object ReturnBoxedValue(System.Object typedValue, System.Xml.Schema.XmlSchemaType xmlType, System.Boolean unWrap)
  System.Xml.XsdCachingReader GetCachingReader()
  System.Xml.ValidatingReaderNodeData CreateDummyTextNode(System.String attributeValue, System.Int32 depth)
  System.Void CachingCallBack(System.Xml.XsdCachingReader cachingReader)
  System.String GetOriginalAtomicValueStringOfElement()
END_CLASS

CLASS: System.Xml.DocumentXPathNavigator
TYPE:  class
TOKEN: 0x200008C
EXTENDS: XPathNavigator
FIELDS:
  private           System.Xml.XmlDocument          document  // 0x10
  private           System.Xml.XmlNode              source  // 0x18
  private           System.Int32                    attributeIndex  // 0x20
  private           System.Xml.XmlElement           namespaceParent  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XmlDocument document, System.Xml.XmlNode node)
  System.Void .ctor(System.Xml.DocumentXPathNavigator other)
  System.Xml.XPath.XPathNavigator Clone()
  System.Xml.XmlNameTable get_NameTable()
  System.Xml.XPath.XPathNodeType get_NodeType()
  System.String get_LocalName()
  System.String get_NamespaceURI()
  System.String get_Name()
  System.String get_Prefix()
  System.String get_Value()
  System.String get_ValueDocument()
  System.String get_ValueText()
  System.String get_BaseURI()
  System.String get_XmlLang()
  System.Object get_UnderlyingObject()
  System.Boolean MoveToAttribute(System.String localName, System.String namespaceURI)
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
  System.Boolean MoveToNamespace(System.String name)
  System.Boolean MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope scope)
  System.Boolean MoveToFirstNamespaceLocal(System.Xml.XmlAttributeCollection attributes, System.Int32& index)
  System.Boolean MoveToFirstNamespaceGlobal(System.Xml.XmlAttributeCollection& attributes, System.Int32& index)
  System.Boolean MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope scope)
  System.Boolean MoveToNextNamespaceLocal(System.Xml.XmlAttributeCollection attributes, System.Int32& index)
  System.Boolean MoveToNextNamespaceGlobal(System.Xml.XmlAttributeCollection& attributes, System.Int32& index)
  System.Boolean PathHasDuplicateNamespace(System.Xml.XmlElement top, System.Xml.XmlElement bottom, System.String localName)
  System.String LookupNamespace(System.String prefix)
  System.Boolean MoveToNext()
  System.Boolean MoveToFirstChild()
  System.Boolean MoveToParent()
  System.Void MoveToRoot()
  System.Boolean MoveTo(System.Xml.XPath.XPathNavigator other)
  System.Boolean MoveToId(System.String id)
  System.Boolean MoveToChild(System.String localName, System.String namespaceUri)
  System.Boolean MoveToChild(System.Xml.XPath.XPathNodeType type)
  System.Boolean MoveToFollowing(System.String localName, System.String namespaceUri, System.Xml.XPath.XPathNavigator end)
  System.Boolean MoveToFollowing(System.Xml.XPath.XPathNodeType type, System.Xml.XPath.XPathNavigator end)
  System.Boolean MoveToNext(System.String localName, System.String namespaceUri)
  System.Boolean MoveToNext(System.Xml.XPath.XPathNodeType type)
  System.Boolean IsSamePosition(System.Xml.XPath.XPathNavigator other)
  System.Boolean IsDescendant(System.Xml.XPath.XPathNavigator other)
  System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo()
  System.Xml.XmlNode OwnerNode(System.Xml.XmlNode node)
  System.Int32 GetDepth(System.Xml.XmlNode node)
  System.Xml.XmlNodeOrder Compare(System.Xml.XmlNode node1, System.Xml.XmlNode node2)
  System.Xml.XmlNodeOrder ComparePosition(System.Xml.XPath.XPathNavigator other)
  System.Xml.XmlNode System.Xml.IHasXmlNode.GetNode()
  System.Xml.XPath.XPathNodeIterator SelectDescendants(System.String localName, System.String namespaceURI, System.Boolean matchSelf)
  System.Xml.XPath.XPathNodeIterator SelectDescendants(System.Xml.XPath.XPathNodeType nt, System.Boolean includeSelf)
  System.Void ResetPosition(System.Xml.XmlNode node)
  System.Boolean ResetAttributePosition(System.Xml.XmlAttribute attribute, System.Xml.XmlAttributeCollection attributes, System.Int32& index)
  System.Boolean CheckAttributePosition(System.Xml.XmlAttribute attribute, System.Xml.XmlAttributeCollection& attributes, System.Int32 index)
  System.Void CalibrateText()
  System.Xml.XmlNode ParentNode(System.Xml.XmlNode node)
  System.Xml.XmlNode ParentNodeTail(System.Xml.XmlNode parent)
  System.Xml.XmlNode FirstChild(System.Xml.XmlNode node)
  System.Xml.XmlNode FirstChildTail(System.Xml.XmlNode child)
  System.Xml.XmlNode NextSibling(System.Xml.XmlNode node)
  System.Xml.XmlNode NextSiblingTail(System.Xml.XmlNode node, System.Xml.XmlNode sibling)
  System.Xml.XmlNode PreviousText(System.Xml.XmlNode node)
  System.Xml.XmlNode PreviousTextTail(System.Xml.XmlNode node, System.Xml.XmlNode text)
  System.Boolean IsDescendant(System.Xml.XmlNode top, System.Xml.XmlNode bottom)
  System.Boolean IsValidChild(System.Xml.XmlNode parent, System.Xml.XmlNode child)
  System.Xml.XmlNode TextEnd(System.Xml.XmlNode node)
END_CLASS

CLASS: System.Xml.DocumentXPathNodeIterator_Empty
TYPE:  class
TOKEN: 0x200008D
EXTENDS: XPathNodeIterator
FIELDS:
  private           System.Xml.XPath.XPathNavigator nav  // 0x18
METHODS:
  System.Void .ctor(System.Xml.DocumentXPathNavigator nav)
  System.Void .ctor(System.Xml.DocumentXPathNodeIterator_Empty other)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean MoveNext()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
  System.Int32 get_Count()
END_CLASS

CLASS: System.Xml.DocumentXPathNodeIterator_ElemDescendants
TYPE:  class
TOKEN: 0x200008E
EXTENDS: XPathNodeIterator
FIELDS:
  private           System.Xml.DocumentXPathNavigatornav  // 0x18
  private           System.Int32                    level  // 0x20
  private           System.Int32                    position  // 0x24
METHODS:
  System.Void .ctor(System.Xml.DocumentXPathNavigator nav)
  System.Void .ctor(System.Xml.DocumentXPathNodeIterator_ElemDescendants other)
  System.Boolean Match(System.Xml.XmlNode node)
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
  System.Void SetPosition(System.Int32 pos)
  System.Boolean MoveNext()
END_CLASS

CLASS: System.Xml.DocumentXPathNodeIterator_AllElemChildren
TYPE:  class
TOKEN: 0x200008F
EXTENDS: DocumentXPathNodeIterator_ElemDescendants
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.DocumentXPathNavigator nav)
  System.Void .ctor(System.Xml.DocumentXPathNodeIterator_AllElemChildren other)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean Match(System.Xml.XmlNode node)
END_CLASS

CLASS: System.Xml.DocumentXPathNodeIterator_AllElemChildren_AndSelf
TYPE:  class
TOKEN: 0x2000090
EXTENDS: DocumentXPathNodeIterator_AllElemChildren
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.DocumentXPathNavigator nav)
  System.Void .ctor(System.Xml.DocumentXPathNodeIterator_AllElemChildren_AndSelf other)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean MoveNext()
END_CLASS

CLASS: System.Xml.DocumentXPathNodeIterator_ElemChildren_NoLocalName
TYPE:  class
TOKEN: 0x2000091
EXTENDS: DocumentXPathNodeIterator_ElemDescendants
FIELDS:
  private           System.String                   nsAtom  // 0x28
METHODS:
  System.Void .ctor(System.Xml.DocumentXPathNavigator nav, System.String nsAtom)
  System.Void .ctor(System.Xml.DocumentXPathNodeIterator_ElemChildren_NoLocalName other)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean Match(System.Xml.XmlNode node)
END_CLASS

CLASS: System.Xml.DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName
TYPE:  class
TOKEN: 0x2000092
EXTENDS: DocumentXPathNodeIterator_ElemChildren_NoLocalName
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.DocumentXPathNavigator nav, System.String nsAtom)
  System.Void .ctor(System.Xml.DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName other)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean MoveNext()
END_CLASS

CLASS: System.Xml.DocumentXPathNodeIterator_ElemChildren
TYPE:  class
TOKEN: 0x2000093
EXTENDS: DocumentXPathNodeIterator_ElemDescendants
FIELDS:
  protected         System.String                   localNameAtom  // 0x28
  protected         System.String                   nsAtom  // 0x30
METHODS:
  System.Void .ctor(System.Xml.DocumentXPathNavigator nav, System.String localNameAtom, System.String nsAtom)
  System.Void .ctor(System.Xml.DocumentXPathNodeIterator_ElemChildren other)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean Match(System.Xml.XmlNode node)
END_CLASS

CLASS: System.Xml.DocumentXPathNodeIterator_ElemChildren_AndSelf
TYPE:  class
TOKEN: 0x2000094
EXTENDS: DocumentXPathNodeIterator_ElemChildren
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.DocumentXPathNavigator nav, System.String localNameAtom, System.String nsAtom)
  System.Void .ctor(System.Xml.DocumentXPathNodeIterator_ElemChildren_AndSelf other)
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean MoveNext()
END_CLASS

CLASS: System.Xml.DomNameTable
TYPE:  class
TOKEN: 0x2000095
FIELDS:
  private           System.Xml.XmlName[]            entries  // 0x10
  private           System.Int32                    count  // 0x18
  private           System.Int32                    mask  // 0x1C
  private           System.Xml.XmlDocument          ownerDocument  // 0x20
  private           System.Xml.XmlNameTable         nameTable  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XmlDocument document)
  System.Xml.XmlName GetName(System.String prefix, System.String localName, System.String ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo)
  System.Xml.XmlName AddName(System.String prefix, System.String localName, System.String ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo)
  System.Void Grow()
END_CLASS

CLASS: System.Xml.XPathNodeList
TYPE:  class
TOKEN: 0x2000096
EXTENDS: XmlNodeList
FIELDS:
  private           System.Collections.Generic.List<System.Xml.XmlNode>list  // 0x10
  private           System.Xml.XPath.XPathNodeIteratornodeIterator  // 0x18
  private           System.Boolean                  done  // 0x20
  private   static readonly System.Object[]                 nullparams  // 0x0
METHODS:
  System.Void .ctor(System.Xml.XPath.XPathNodeIterator nodeIterator)
  System.Int32 get_Count()
  System.Xml.XmlNode GetNode(System.Xml.XPath.XPathNavigator n)
  System.Int32 ReadUntil(System.Int32 index)
  System.Xml.XmlNode Item(System.Int32 index)
  System.Collections.IEnumerator GetEnumerator()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.XmlNodeListEnumerator
TYPE:  class
TOKEN: 0x2000097
FIELDS:
  private           System.Xml.XPathNodeList        list  // 0x10
  private           System.Int32                    index  // 0x18
  private           System.Boolean                  valid  // 0x1C
METHODS:
  System.Void .ctor(System.Xml.XPathNodeList list)
  System.Void Reset()
  System.Boolean MoveNext()
  System.Object get_Current()
END_CLASS

CLASS: System.Xml.XmlAttribute
TYPE:  class
TOKEN: 0x2000098
EXTENDS: XmlNode
FIELDS:
  private           System.Xml.XmlName              name  // 0x18
  private           System.Xml.XmlLinkedNode        lastChild  // 0x20
METHODS:
  System.Void .ctor(System.Xml.XmlName name, System.Xml.XmlDocument doc)
  System.Int32 get_LocalNameHash()
  System.Void .ctor(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.XmlDocument doc)
  System.Xml.XmlName get_XmlName()
  System.Void set_XmlName(System.Xml.XmlName value)
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Xml.XmlNode get_ParentNode()
  System.String get_Name()
  System.String get_LocalName()
  System.String get_NamespaceURI()
  System.String get_Prefix()
  System.Void set_Prefix(System.String value)
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlDocument get_OwnerDocument()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo()
  System.Void set_InnerText(System.String value)
  System.Boolean PrepareOwnerElementInElementIdAttrMap()
  System.Void ResetOwnerElementInElementIdAttrMap(System.String oldInnerText)
  System.Boolean get_IsContainer()
  System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc)
  System.Xml.XmlLinkedNode get_LastNode()
  System.Void set_LastNode(System.Xml.XmlLinkedNode value)
  System.Boolean IsValidChildType(System.Xml.XmlNodeType type)
  System.Boolean get_Specified()
  System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild)
  System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild)
  System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild)
  System.Xml.XmlElement get_OwnerElement()
  System.Void set_InnerXml(System.String value)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.String get_BaseURI()
  System.Void SetParent(System.Xml.XmlNode node)
  System.Xml.XmlSpace get_XmlSpace()
  System.String get_XmlLang()
  System.Xml.XPath.XPathNodeType get_XPNodeType()
  System.String get_XPLocalName()
  System.Boolean get_IsNamespace()
END_CLASS

CLASS: System.Xml.XmlAttributeCollection
TYPE:  class
TOKEN: 0x2000099
EXTENDS: XmlNamedNodeMap
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.XmlNode parent)
  System.Xml.XmlAttribute get_ItemOf(System.Int32 i)
  System.Xml.XmlAttribute get_ItemOf(System.String name)
  System.Xml.XmlAttribute get_ItemOf(System.String localName, System.String namespaceURI)
  System.Int32 FindNodeOffsetNS(System.Xml.XmlAttribute node)
  System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node)
  System.Xml.XmlAttribute Append(System.Xml.XmlAttribute node)
  System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute node)
  System.Xml.XmlAttribute RemoveAt(System.Int32 i)
  System.Void RemoveAll()
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Int32 System.Collections.ICollection.get_Count()
  System.Xml.XmlNode AddNode(System.Xml.XmlNode node)
  System.Xml.XmlNode InsertNodeAt(System.Int32 i, System.Xml.XmlNode node)
  System.Xml.XmlNode RemoveNodeAt(System.Int32 i)
  System.Void Detach(System.Xml.XmlAttribute attr)
  System.Void InsertParentIntoElementIdAttrMap(System.Xml.XmlAttribute attr)
  System.Void RemoveParentFromElementIdAttrMap(System.Xml.XmlAttribute attr)
  System.Int32 RemoveDuplicateAttribute(System.Xml.XmlAttribute attr)
  System.Boolean PrepareParentInElementIdAttrMap(System.String attrPrefix, System.String attrLocalName)
  System.Void ResetParentInElementIdAttrMap(System.String oldVal, System.String newVal)
  System.Xml.XmlAttribute InternalAppendAttribute(System.Xml.XmlAttribute node)
END_CLASS

CLASS: System.Xml.XmlCDataSection
TYPE:  class
TOKEN: 0x200009A
EXTENDS: XmlCharacterData
FIELDS:
METHODS:
  System.Void .ctor(System.String data, System.Xml.XmlDocument doc)
  System.String get_Name()
  System.String get_LocalName()
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode get_ParentNode()
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.Xml.XPath.XPathNodeType get_XPNodeType()
  System.Boolean get_IsText()
  System.Xml.XmlNode get_PreviousText()
END_CLASS

CLASS: System.Xml.XmlCharacterData
TYPE:  class
TOKEN: 0x200009B
EXTENDS: XmlLinkedNode
FIELDS:
  private           System.String                   data  // 0x20
METHODS:
  System.Void .ctor(System.String data, System.Xml.XmlDocument doc)
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.String get_InnerText()
  System.Void set_InnerText(System.String value)
  System.String get_Data()
  System.Void set_Data(System.String value)
  System.Boolean CheckOnData(System.String data)
  System.Boolean DecideXPNodeTypeForTextNodes(System.Xml.XmlNode node, System.Xml.XPath.XPathNodeType& xnt)
END_CLASS

CLASS: System.Xml.XmlChildEnumerator
TYPE:  class
TOKEN: 0x200009C
FIELDS:
  private           System.Xml.XmlNode              container  // 0x10
  private           System.Xml.XmlNode              child  // 0x18
  private           System.Boolean                  isFirst  // 0x20
METHODS:
  System.Void .ctor(System.Xml.XmlNode container)
  System.Boolean System.Collections.IEnumerator.MoveNext()
  System.Boolean MoveNext()
  System.Void System.Collections.IEnumerator.Reset()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Xml.XmlNode get_Current()
END_CLASS

CLASS: System.Xml.XmlChildNodes
TYPE:  class
TOKEN: 0x200009D
EXTENDS: XmlNodeList
FIELDS:
  private           System.Xml.XmlNode              container  // 0x10
METHODS:
  System.Void .ctor(System.Xml.XmlNode container)
  System.Xml.XmlNode Item(System.Int32 i)
  System.Int32 get_Count()
  System.Collections.IEnumerator GetEnumerator()
END_CLASS

CLASS: System.Xml.XmlComment
TYPE:  class
TOKEN: 0x200009E
EXTENDS: XmlCharacterData
FIELDS:
METHODS:
  System.Void .ctor(System.String comment, System.Xml.XmlDocument doc)
  System.String get_Name()
  System.String get_LocalName()
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.Xml.XPath.XPathNodeType get_XPNodeType()
END_CLASS

CLASS: System.Xml.XmlDeclaration
TYPE:  class
TOKEN: 0x200009F
EXTENDS: XmlLinkedNode
FIELDS:
  private           System.String                   version  // 0x20
  private           System.String                   encoding  // 0x28
  private           System.String                   standalone  // 0x30
METHODS:
  System.Void .ctor(System.String version, System.String encoding, System.String standalone, System.Xml.XmlDocument doc)
  System.String get_Version()
  System.Void set_Version(System.String value)
  System.String get_Encoding()
  System.Void set_Encoding(System.String value)
  System.String get_Standalone()
  System.Void set_Standalone(System.String value)
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.String get_InnerText()
  System.Void set_InnerText(System.String value)
  System.String get_Name()
  System.String get_LocalName()
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.Boolean IsValidXmlVersion(System.String ver)
END_CLASS

CLASS: System.Xml.XmlDocument
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: XmlNode
FIELDS:
  private           System.Xml.XmlImplementation    implementation  // 0x18
  private           System.Xml.DomNameTable         domNameTable  // 0x20
  private           System.Xml.XmlLinkedNode        lastChild  // 0x28
  private           System.Xml.XmlNamedNodeMap      entities  // 0x30
  private           System.Collections.Hashtable    htElementIdMap  // 0x38
  private           System.Collections.Hashtable    htElementIDAttrDecl  // 0x40
  private           System.Xml.Schema.SchemaInfo    schemaInfo  // 0x48
  private           System.Xml.Schema.XmlSchemaSet  schemas  // 0x50
  private           System.Boolean                  reportValidity  // 0x58
  private           System.Boolean                  actualLoadingStatus  // 0x59
  private           System.Xml.XmlNodeChangedEventHandleronNodeInsertingDelegate  // 0x60
  private           System.Xml.XmlNodeChangedEventHandleronNodeInsertedDelegate  // 0x68
  private           System.Xml.XmlNodeChangedEventHandleronNodeRemovingDelegate  // 0x70
  private           System.Xml.XmlNodeChangedEventHandleronNodeRemovedDelegate  // 0x78
  private           System.Xml.XmlNodeChangedEventHandleronNodeChangingDelegate  // 0x80
  private           System.Xml.XmlNodeChangedEventHandleronNodeChangedDelegate  // 0x88
  private           System.Boolean                  fEntRefNodesPresent  // 0x90
  private           System.Boolean                  fCDataNodesPresent  // 0x91
  private           System.Boolean                  preserveWhitespace  // 0x92
  private           System.Boolean                  isLoading  // 0x93
  private           System.String                   strDocumentName  // 0x98
  private           System.String                   strDocumentFragmentName  // 0xA0
  private           System.String                   strCommentName  // 0xA8
  private           System.String                   strTextName  // 0xB0
  private           System.String                   strCDataSectionName  // 0xB8
  private           System.String                   strEntityName  // 0xC0
  private           System.String                   strID  // 0xC8
  private           System.String                   strXmlns  // 0xD0
  private           System.String                   strXml  // 0xD8
  private           System.String                   strSpace  // 0xE0
  private           System.String                   strLang  // 0xE8
  private           System.String                   strEmpty  // 0xF0
  private           System.String                   strNonSignificantWhitespaceName  // 0xF8
  private           System.String                   strSignificantWhitespaceName  // 0x100
  private           System.String                   strReservedXmlns  // 0x108
  private           System.String                   strReservedXml  // 0x110
  private           System.String                   baseURI  // 0x118
  private           System.Xml.XmlResolver          resolver  // 0x120
  private           System.Boolean                  bSetResolver  // 0x128
  private           System.Object                   objLock  // 0x130
  private           System.Xml.XmlAttribute         namespaceXml  // 0x138
  private   static  System.Xml.EmptyEnumerator      EmptyEnumerator  // 0x0
  private   static  System.Xml.Schema.IXmlSchemaInfoNotKnownSchemaInfo  // 0x8
  private   static  System.Xml.Schema.IXmlSchemaInfoValidSchemaInfo  // 0x10
  private   static  System.Xml.Schema.IXmlSchemaInfoInvalidSchemaInfo  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Xml.XmlNameTable nt)
  System.Void .ctor(System.Xml.XmlImplementation imp)
  System.Xml.Schema.SchemaInfo get_DtdSchemaInfo()
  System.Void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value)
  System.Void CheckName(System.String name)
  System.Xml.XmlName AddXmlName(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo)
  System.Xml.XmlName GetXmlName(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo)
  System.Xml.XmlName AddAttrXmlName(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo)
  System.Boolean AddIdInfo(System.Xml.XmlName eleName, System.Xml.XmlName attrName)
  System.Xml.XmlName GetIDInfoByElement_(System.Xml.XmlName eleName)
  System.Xml.XmlName GetIDInfoByElement(System.Xml.XmlName eleName)
  System.WeakReference GetElement(System.Collections.ArrayList elementList, System.Xml.XmlElement elem)
  System.Void AddElementWithId(System.String id, System.Xml.XmlElement elem)
  System.Void RemoveElementWithId(System.String id, System.Xml.XmlElement elem)
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode get_ParentNode()
  System.Xml.XmlDocumentType get_DocumentType()
  System.Xml.XmlDeclaration get_Declaration()
  System.Xml.XmlImplementation get_Implementation()
  System.String get_Name()
  System.String get_LocalName()
  System.Xml.XmlElement get_DocumentElement()
  System.Boolean get_IsContainer()
  System.Xml.XmlLinkedNode get_LastNode()
  System.Void set_LastNode(System.Xml.XmlLinkedNode value)
  System.Xml.XmlDocument get_OwnerDocument()
  System.Void set_Schemas(System.Xml.Schema.XmlSchemaSet value)
  System.Boolean get_CanReportValidity()
  System.Boolean get_HasSetResolver()
  System.Xml.XmlResolver GetResolver()
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Boolean IsValidChildType(System.Xml.XmlNodeType type)
  System.Boolean HasNodeTypeInPrevSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode)
  System.Boolean HasNodeTypeInNextSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode)
  System.Boolean CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Boolean CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Xml.XmlAttribute CreateAttribute(System.String name)
  System.Void SetDefaultNamespace(System.String prefix, System.String localName, System.String& namespaceURI)
  System.Xml.XmlCDataSection CreateCDataSection(System.String data)
  System.Xml.XmlComment CreateComment(System.String data)
  System.Xml.XmlDocumentType CreateDocumentType(System.String name, System.String publicId, System.String systemId, System.String internalSubset)
  System.Xml.XmlDocumentFragment CreateDocumentFragment()
  System.Xml.XmlElement CreateElement(System.String name)
  System.Void AddDefaultAttributes(System.Xml.XmlElement elem)
  System.Xml.Schema.SchemaElementDecl GetSchemaElementDecl(System.Xml.XmlElement elem)
  System.Xml.XmlAttribute PrepareDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef, System.String attrPrefix, System.String attrLocalname, System.String attrNamespaceURI)
  System.Xml.XmlEntityReference CreateEntityReference(System.String name)
  System.Xml.XmlProcessingInstruction CreateProcessingInstruction(System.String target, System.String data)
  System.Xml.XmlDeclaration CreateXmlDeclaration(System.String version, System.String encoding, System.String standalone)
  System.Xml.XmlText CreateTextNode(System.String text)
  System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(System.String text)
  System.Xml.XPath.XPathNavigator CreateNavigator()
  System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlNode node)
  System.Boolean IsTextNode(System.Xml.XmlNodeType nt)
  System.Xml.XmlNode NormalizeText(System.Xml.XmlNode n)
  System.Xml.XmlWhitespace CreateWhitespace(System.String text)
  System.Xml.XmlAttribute CreateAttribute(System.String qualifiedName, System.String namespaceURI)
  System.Xml.XmlElement CreateElement(System.String qualifiedName, System.String namespaceURI)
  System.Xml.XmlElement GetElementById(System.String elementId)
  System.Xml.XmlNode ImportNodeInternal(System.Xml.XmlNode node, System.Boolean deep)
  System.Void ImportAttributes(System.Xml.XmlNode fromElem, System.Xml.XmlNode toElem)
  System.Void ImportChildren(System.Xml.XmlNode fromNode, System.Xml.XmlNode toNode, System.Boolean deep)
  System.Xml.XmlNameTable get_NameTable()
  System.Xml.XmlAttribute CreateAttribute(System.String prefix, System.String localName, System.String namespaceURI)
  System.Xml.XmlAttribute CreateDefaultAttribute(System.String prefix, System.String localName, System.String namespaceURI)
  System.Xml.XmlElement CreateElement(System.String prefix, System.String localName, System.String namespaceURI)
  System.Boolean get_IsReadOnly()
  System.Xml.XmlNamedNodeMap get_Entities()
  System.Void set_Entities(System.Xml.XmlNamedNodeMap value)
  System.Boolean get_IsLoading()
  System.Void set_IsLoading(System.Boolean value)
  System.Boolean get_ActualLoadingStatus()
  System.Xml.XmlNode ReadNode(System.Xml.XmlReader reader)
  System.Xml.XmlTextReader SetupReader(System.Xml.XmlTextReader tr)
  System.Void Load(System.Xml.XmlReader reader)
  System.Void LoadXml(System.String xml)
  System.Void set_InnerText(System.String value)
  System.Void set_InnerXml(System.String value)
  System.Void Save(System.Xml.XmlWriter w)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter xw)
  System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, System.String oldValue, System.String newValue, System.Xml.XmlNodeChangedAction action)
  System.Xml.XmlNodeChangedEventArgs GetInsertEventArgsForLoad(System.Xml.XmlNode node, System.Xml.XmlNode newParent)
  System.Void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args)
  System.Void AfterEvent(System.Xml.XmlNodeChangedEventArgs args)
  System.Xml.XmlAttribute GetDefaultAttribute(System.Xml.XmlElement elem, System.String attrPrefix, System.String attrLocalname, System.String attrNamespaceURI)
  System.String get_Version()
  System.String get_Encoding()
  System.String get_Standalone()
  System.Xml.XmlEntity GetEntityNode(System.String name)
  System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo()
  System.String get_BaseURI()
  System.Void SetBaseURI(System.String inBaseURI)
  System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc)
  System.Xml.XPath.XPathNodeType get_XPNodeType()
  System.Boolean get_HasEntityReferences()
  System.Xml.XmlAttribute get_NamespaceXml()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.XmlDocumentFragment
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: XmlNode
FIELDS:
  private           System.Xml.XmlLinkedNode        lastChild  // 0x18
METHODS:
  System.Void .ctor(System.Xml.XmlDocument ownerDocument)
  System.String get_Name()
  System.String get_LocalName()
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode get_ParentNode()
  System.Xml.XmlDocument get_OwnerDocument()
  System.Void set_InnerXml(System.String value)
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Boolean get_IsContainer()
  System.Xml.XmlLinkedNode get_LastNode()
  System.Void set_LastNode(System.Xml.XmlLinkedNode value)
  System.Boolean IsValidChildType(System.Xml.XmlNodeType type)
  System.Boolean CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Boolean CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.Xml.XPath.XPathNodeType get_XPNodeType()
END_CLASS

CLASS: System.Xml.XmlDocumentType
TYPE:  class
TOKEN: 0x20000A2
EXTENDS: XmlLinkedNode
FIELDS:
  private           System.String                   name  // 0x20
  private           System.String                   publicId  // 0x28
  private           System.String                   systemId  // 0x30
  private           System.String                   internalSubset  // 0x38
  private           System.Boolean                  namespaces  // 0x40
  private           System.Xml.XmlNamedNodeMap      entities  // 0x48
  private           System.Xml.XmlNamedNodeMap      notations  // 0x50
  private           System.Xml.Schema.SchemaInfo    schemaInfo  // 0x58
METHODS:
  System.Void .ctor(System.String name, System.String publicId, System.String systemId, System.String internalSubset, System.Xml.XmlDocument doc)
  System.String get_Name()
  System.String get_LocalName()
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Boolean get_IsReadOnly()
  System.Xml.XmlNamedNodeMap get_Entities()
  System.Xml.XmlNamedNodeMap get_Notations()
  System.String get_PublicId()
  System.String get_SystemId()
  System.String get_InternalSubset()
  System.Boolean get_ParseWithNamespaces()
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.Xml.Schema.SchemaInfo get_DtdSchemaInfo()
  System.Void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value)
END_CLASS

CLASS: System.Xml.XmlElement
TYPE:  class
TOKEN: 0x20000A3
EXTENDS: XmlLinkedNode
FIELDS:
  private           System.Xml.XmlName              name  // 0x20
  private           System.Xml.XmlAttributeCollectionattributes  // 0x28
  private           System.Xml.XmlLinkedNode        lastChild  // 0x30
METHODS:
  System.Void .ctor(System.Xml.XmlName name, System.Boolean empty, System.Xml.XmlDocument doc)
  System.Void .ctor(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.XmlDocument doc)
  System.Xml.XmlName get_XmlName()
  System.Void set_XmlName(System.Xml.XmlName value)
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.String get_Name()
  System.String get_LocalName()
  System.String get_NamespaceURI()
  System.String get_Prefix()
  System.Void set_Prefix(System.String value)
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode get_ParentNode()
  System.Xml.XmlDocument get_OwnerDocument()
  System.Boolean get_IsContainer()
  System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc)
  System.Boolean get_IsEmpty()
  System.Void set_IsEmpty(System.Boolean value)
  System.Xml.XmlLinkedNode get_LastNode()
  System.Void set_LastNode(System.Xml.XmlLinkedNode value)
  System.Boolean IsValidChildType(System.Xml.XmlNodeType type)
  System.Xml.XmlAttributeCollection get_Attributes()
  System.Boolean get_HasAttributes()
  System.String GetAttribute(System.String name)
  System.Void SetAttribute(System.String name, System.String value)
  System.Xml.XmlAttribute GetAttributeNode(System.String name)
  System.Xml.XmlAttribute SetAttributeNode(System.Xml.XmlAttribute newAttr)
  System.String GetAttribute(System.String localName, System.String namespaceURI)
  System.String SetAttribute(System.String localName, System.String namespaceURI, System.String value)
  System.Xml.XmlAttribute GetAttributeNode(System.String localName, System.String namespaceURI)
  System.Xml.XmlAttribute SetAttributeNode(System.String localName, System.String namespaceURI)
  System.Boolean HasAttribute(System.String name)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteElementTo(System.Xml.XmlWriter writer, System.Xml.XmlElement e)
  System.Void WriteStartElement(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.Void RemoveAllAttributes()
  System.Void RemoveAll()
  System.Void RemoveAllChildren()
  System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo()
  System.Void set_InnerXml(System.String value)
  System.String get_InnerText()
  System.Void set_InnerText(System.String value)
  System.Xml.XmlNode get_NextSibling()
  System.Void SetParent(System.Xml.XmlNode node)
  System.Xml.XPath.XPathNodeType get_XPNodeType()
  System.String get_XPLocalName()
END_CLASS

CLASS: System.Xml.XmlEntity
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: XmlNode
FIELDS:
  private           System.String                   publicId  // 0x18
  private           System.String                   systemId  // 0x20
  private           System.String                   notationName  // 0x28
  private           System.String                   name  // 0x30
  private           System.String                   unparsedReplacementStr  // 0x38
  private           System.String                   baseURI  // 0x40
  private           System.Xml.XmlLinkedNode        lastChild  // 0x48
  private           System.Boolean                  childrenFoliating  // 0x50
METHODS:
  System.Void .ctor(System.String name, System.String strdata, System.String publicId, System.String systemId, System.String notationName, System.Xml.XmlDocument doc)
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Boolean get_IsReadOnly()
  System.String get_Name()
  System.String get_LocalName()
  System.String get_InnerText()
  System.Void set_InnerText(System.String value)
  System.Boolean get_IsContainer()
  System.Xml.XmlLinkedNode get_LastNode()
  System.Void set_LastNode(System.Xml.XmlLinkedNode value)
  System.Boolean IsValidChildType(System.Xml.XmlNodeType type)
  System.Xml.XmlNodeType get_NodeType()
  System.String get_SystemId()
  System.Void set_InnerXml(System.String value)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.String get_BaseURI()
  System.Void SetBaseURI(System.String inBaseURI)
END_CLASS

CLASS: System.Xml.XmlEntityReference
TYPE:  class
TOKEN: 0x20000A5
EXTENDS: XmlLinkedNode
FIELDS:
  private           System.String                   name  // 0x20
  private           System.Xml.XmlLinkedNode        lastChild  // 0x28
METHODS:
  System.Void .ctor(System.String name, System.Xml.XmlDocument doc)
  System.String get_Name()
  System.String get_LocalName()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Boolean get_IsReadOnly()
  System.Boolean get_IsContainer()
  System.Void SetParent(System.Xml.XmlNode node)
  System.Void SetParentForLoad(System.Xml.XmlNode node)
  System.Xml.XmlLinkedNode get_LastNode()
  System.Void set_LastNode(System.Xml.XmlLinkedNode value)
  System.Boolean IsValidChildType(System.Xml.XmlNodeType type)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.String get_BaseURI()
  System.String ConstructBaseURI(System.String baseURI, System.String systemId)
  System.String get_ChildBaseURI()
END_CLASS

CLASS: System.Xml.XmlNodeChangedAction
TYPE:  struct
TOKEN: 0x20000A6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlNodeChangedAction Insert  // 0x0
  public    static  System.Xml.XmlNodeChangedAction Remove  // 0x0
  public    static  System.Xml.XmlNodeChangedAction Change  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlImplementation
TYPE:  class
TOKEN: 0x20000A7
FIELDS:
  private           System.Xml.XmlNameTable         nameTable  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Xml.XmlNameTable nt)
  System.Xml.XmlDocument CreateDocument()
  System.Xml.XmlNameTable get_NameTable()
END_CLASS

CLASS: System.Xml.XmlLinkedNode
TYPE:  class
TOKEN: 0x20000A8
EXTENDS: XmlNode
FIELDS:
  private           System.Xml.XmlLinkedNode        next  // 0x18
METHODS:
  System.Void .ctor(System.Xml.XmlDocument doc)
  System.Xml.XmlNode get_PreviousSibling()
  System.Xml.XmlNode get_NextSibling()
END_CLASS

CLASS: System.Xml.XmlLoader
TYPE:  class
TOKEN: 0x20000A9
FIELDS:
  private           System.Xml.XmlDocument          doc  // 0x10
  private           System.Xml.XmlReader            reader  // 0x18
  private           System.Boolean                  preserveWhitespace  // 0x20
METHODS:
  System.Void .ctor()
  System.Void Load(System.Xml.XmlDocument doc, System.Xml.XmlReader reader, System.Boolean preserveWhitespace)
  System.Void LoadDocSequence(System.Xml.XmlDocument parentDoc)
  System.Xml.XmlNode ReadCurrentNode(System.Xml.XmlDocument doc, System.Xml.XmlReader reader)
  System.Xml.XmlNode LoadNode(System.Boolean skipOverWhitespace)
  System.Xml.XmlAttribute LoadAttributeNode()
  System.Xml.XmlAttribute LoadDefaultAttribute()
  System.Void LoadAttributeValue(System.Xml.XmlNode parent, System.Boolean direct)
  System.Xml.XmlEntityReference LoadEntityReferenceNode(System.Boolean direct)
  System.Xml.XmlDeclaration LoadDeclarationNode()
  System.Xml.XmlDocumentType LoadDocumentTypeNode()
  System.Xml.XmlNode LoadNodeDirect()
  System.Xml.XmlAttribute LoadAttributeNodeDirect()
  System.Void ParseDocumentType(System.Xml.XmlDocumentType dtNode)
  System.Void ParseDocumentType(System.Xml.XmlDocumentType dtNode, System.Boolean bUseResolver, System.Xml.XmlResolver resolver)
  System.Void LoadDocumentType(System.Xml.IDtdInfo dtdInfo, System.Xml.XmlDocumentType dtNode)
  System.Xml.XmlParserContext GetContext(System.Xml.XmlNode node)
  System.Xml.XmlNamespaceManager ParsePartialContent(System.Xml.XmlNode parentNode, System.String innerxmltext, System.Xml.XmlNodeType nt)
  System.Void LoadInnerXmlElement(System.Xml.XmlElement node, System.String innerxmltext)
  System.Void LoadInnerXmlAttribute(System.Xml.XmlAttribute node, System.String innerxmltext)
  System.Void RemoveDuplicateNamespace(System.Xml.XmlElement elem, System.Xml.XmlNamespaceManager mgr, System.Boolean fCheckElemAttrs)
  System.String EntitizeName(System.String name)
  System.Void ExpandEntity(System.Xml.XmlEntity ent)
  System.Void ExpandEntityReference(System.Xml.XmlEntityReference eref)
  System.Xml.XmlReader CreateInnerXmlReader(System.String xmlFragment, System.Xml.XmlNodeType nt, System.Xml.XmlParserContext context, System.Xml.XmlDocument doc)
  System.Void ParseXmlDeclarationValue(System.String strValue, System.String& version, System.String& encoding, System.String& standalone)
  System.Exception UnexpectedNodeType(System.Xml.XmlNodeType nodetype)
END_CLASS

CLASS: System.Xml.XmlName
TYPE:  class
TOKEN: 0x20000AA
FIELDS:
  private           System.String                   prefix  // 0x10
  private           System.String                   localName  // 0x18
  private           System.String                   ns  // 0x20
  private           System.String                   name  // 0x28
  private           System.Int32                    hashCode  // 0x30
  private           System.Xml.XmlDocument          ownerDoc  // 0x38
  private           System.Xml.XmlName              next  // 0x40
METHODS:
  System.Xml.XmlName Create(System.String prefix, System.String localName, System.String ns, System.Int32 hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo)
  System.Void .ctor(System.String prefix, System.String localName, System.String ns, System.Int32 hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next)
  System.String get_LocalName()
  System.String get_NamespaceURI()
  System.String get_Prefix()
  System.Int32 get_HashCode()
  System.Xml.XmlDocument get_OwnerDocument()
  System.String get_Name()
  System.Xml.Schema.XmlSchemaValidity get_Validity()
  System.Boolean get_IsDefault()
  System.Boolean get_IsNil()
  System.Xml.Schema.XmlSchemaSimpleType get_MemberType()
  System.Xml.Schema.XmlSchemaType get_SchemaType()
  System.Xml.Schema.XmlSchemaElement get_SchemaElement()
  System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute()
  System.Boolean Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo)
  System.Int32 GetHashCode(System.String name)
END_CLASS

CLASS: System.Xml.XmlNameEx
TYPE:  class
TOKEN: 0x20000AB
EXTENDS: XmlName
FIELDS:
  private           System.Byte                     flags  // 0x48
  private           System.Xml.Schema.XmlSchemaSimpleTypememberType  // 0x50
  private           System.Xml.Schema.XmlSchemaType schemaType  // 0x58
  private           System.Object                   decl  // 0x60
METHODS:
  System.Void .ctor(System.String prefix, System.String localName, System.String ns, System.Int32 hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo)
  System.Xml.Schema.XmlSchemaValidity get_Validity()
  System.Boolean get_IsDefault()
  System.Boolean get_IsNil()
  System.Xml.Schema.XmlSchemaSimpleType get_MemberType()
  System.Xml.Schema.XmlSchemaType get_SchemaType()
  System.Xml.Schema.XmlSchemaElement get_SchemaElement()
  System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute()
  System.Void SetValidity(System.Xml.Schema.XmlSchemaValidity value)
  System.Void SetIsDefault(System.Boolean value)
  System.Void SetIsNil(System.Boolean value)
  System.Boolean Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo)
END_CLASS

CLASS: System.Xml.XmlNamedNodeMap
TYPE:  class
TOKEN: 0x20000AC
FIELDS:
  private           System.Xml.XmlNode              parent  // 0x10
  private           System.Xml.XmlNamedNodeMap.SmallXmlNodeListnodes  // 0x18
METHODS:
  System.Void .ctor(System.Xml.XmlNode parent)
  System.Xml.XmlNode GetNamedItem(System.String name)
  System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node)
  System.Int32 get_Count()
  System.Collections.IEnumerator GetEnumerator()
  System.Int32 FindNodeOffset(System.String name)
  System.Int32 FindNodeOffset(System.String localName, System.String namespaceURI)
  System.Xml.XmlNode AddNode(System.Xml.XmlNode node)
  System.Xml.XmlNode AddNodeForLoad(System.Xml.XmlNode node, System.Xml.XmlDocument doc)
  System.Xml.XmlNode RemoveNodeAt(System.Int32 i)
  System.Xml.XmlNode ReplaceNodeAt(System.Int32 i, System.Xml.XmlNode node)
  System.Xml.XmlNode InsertNodeAt(System.Int32 i, System.Xml.XmlNode node)
END_CLASS

CLASS: System.Xml.XmlNode
TYPE:  class
TOKEN: 0x20000AF
FIELDS:
  private           System.Xml.XmlNode              parentNode  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Xml.XmlDocument doc)
  System.Xml.XPath.XPathNavigator CreateNavigator()
  System.Xml.XmlNode SelectSingleNode(System.String xpath)
  System.Xml.XmlNodeList SelectNodes(System.String xpath)
  System.String get_Name()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode get_ParentNode()
  System.Xml.XmlNodeList get_ChildNodes()
  System.Xml.XmlNode get_PreviousSibling()
  System.Xml.XmlNode get_NextSibling()
  System.Xml.XmlAttributeCollection get_Attributes()
  System.Xml.XmlDocument get_OwnerDocument()
  System.Xml.XmlNode get_FirstChild()
  System.Xml.XmlNode get_LastChild()
  System.Boolean get_IsContainer()
  System.Xml.XmlLinkedNode get_LastNode()
  System.Void set_LastNode(System.Xml.XmlLinkedNode value)
  System.Boolean AncestorNode(System.Xml.XmlNode node)
  System.Boolean IsConnected()
  System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild)
  System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild)
  System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild)
  System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc)
  System.Boolean IsValidChildType(System.Xml.XmlNodeType type)
  System.Boolean CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Boolean CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Boolean get_HasChildNodes()
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Void CopyChildren(System.Xml.XmlDocument doc, System.Xml.XmlNode container, System.Boolean deep)
  System.String get_NamespaceURI()
  System.String get_Prefix()
  System.Void set_Prefix(System.String value)
  System.String get_LocalName()
  System.Boolean get_IsReadOnly()
  System.Boolean HasReadOnlyParent(System.Xml.XmlNode n)
  System.Object System.ICloneable.Clone()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.IEnumerator GetEnumerator()
  System.Void AppendChildText(System.Text.StringBuilder builder)
  System.String get_InnerText()
  System.Void set_InnerText(System.String value)
  System.Void set_InnerXml(System.String value)
  System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo()
  System.String get_BaseURI()
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.Void RemoveAll()
  System.Xml.XmlDocument get_Document()
  System.String GetPrefixOfNamespace(System.String namespaceURI)
  System.String GetPrefixOfNamespaceStrict(System.String namespaceURI)
  System.Void SetParent(System.Xml.XmlNode node)
  System.Void SetParentForLoad(System.Xml.XmlNode node)
  System.Void SplitName(System.String name, System.String& prefix, System.String& localName)
  System.Xml.XmlNode FindChild(System.Xml.XmlNodeType type)
  System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, System.String oldValue, System.String newValue, System.Xml.XmlNodeChangedAction action)
  System.Void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args)
  System.Void AfterEvent(System.Xml.XmlNodeChangedEventArgs args)
  System.Xml.XmlSpace get_XmlSpace()
  System.String get_XmlLang()
  System.Xml.XPath.XPathNodeType get_XPNodeType()
  System.String get_XPLocalName()
  System.Boolean get_IsText()
  System.Xml.XmlNode get_PreviousText()
  System.Void NestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode)
  System.Void UnnestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode)
END_CLASS

CLASS: System.Xml.XmlNodeChangedEventArgs
TYPE:  class
TOKEN: 0x20000B0
EXTENDS: EventArgs
FIELDS:
  private           System.Xml.XmlNodeChangedAction action  // 0x10
  private           System.Xml.XmlNode              node  // 0x18
  private           System.Xml.XmlNode              oldParent  // 0x20
  private           System.Xml.XmlNode              newParent  // 0x28
  private           System.String                   oldValue  // 0x30
  private           System.String                   newValue  // 0x38
METHODS:
  System.Void .ctor(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, System.String oldValue, System.String newValue, System.Xml.XmlNodeChangedAction action)
  System.Xml.XmlNodeChangedAction get_Action()
END_CLASS

CLASS: System.Xml.XmlNodeChangedEventHandler
TYPE:  class
TOKEN: 0x20000B1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Xml.XmlNodeChangedEventArgs e)
END_CLASS

CLASS: System.Xml.XmlNodeList
TYPE:  class
TOKEN: 0x20000B2
FIELDS:
METHODS:
  System.Xml.XmlNode Item(System.Int32 index)
  System.Int32 get_Count()
  System.Collections.IEnumerator GetEnumerator()
  System.Xml.XmlNode get_ItemOf(System.Int32 i)
  System.Void System.IDisposable.Dispose()
  System.Void PrivateDisposeNodeList()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.XmlNodeReaderNavigator
TYPE:  class
TOKEN: 0x20000B3
FIELDS:
  private           System.Xml.XmlNode              curNode  // 0x10
  private           System.Xml.XmlNode              elemNode  // 0x18
  private           System.Xml.XmlNode              logNode  // 0x20
  private           System.Int32                    attrIndex  // 0x28
  private           System.Int32                    logAttrIndex  // 0x2C
  private           System.Xml.XmlNameTable         nameTable  // 0x30
  private           System.Xml.XmlDocument          doc  // 0x38
  private           System.Int32                    nAttrInd  // 0x40
  private           System.Int32                    nDeclarationAttrCount  // 0x44
  private           System.Int32                    nDocTypeAttrCount  // 0x48
  private           System.Int32                    nLogLevel  // 0x4C
  private           System.Int32                    nLogAttrInd  // 0x50
  private           System.Boolean                  bLogOnAttrVal  // 0x54
  private           System.Boolean                  bCreatedOnAttribute  // 0x55
  private           System.Xml.XmlNodeReaderNavigator.VirtualAttribute[]decNodeAttributes  // 0x58
  private           System.Xml.XmlNodeReaderNavigator.VirtualAttribute[]docTypeNodeAttributes  // 0x60
  private           System.Boolean                  bOnAttrVal  // 0x68
METHODS:
  System.Void .ctor(System.Xml.XmlNode node)
  System.Xml.XmlNodeType get_NodeType()
  System.String get_NamespaceURI()
  System.String get_Name()
  System.String get_LocalName()
  System.Boolean get_CreatedOnAttribute()
  System.Boolean IsLocalNameEmpty(System.Xml.XmlNodeType nt)
  System.String get_Prefix()
  System.Boolean get_HasValue()
  System.String get_Value()
  System.String get_BaseURI()
  System.Xml.XmlSpace get_XmlSpace()
  System.String get_XmlLang()
  System.Boolean get_IsEmptyElement()
  System.Boolean get_IsDefault()
  System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo()
  System.Xml.XmlNameTable get_NameTable()
  System.Int32 get_AttributeCount()
  System.Void CheckIndexCondition(System.Int32 attributeIndex)
  System.Void InitDecAttr()
  System.String GetDeclarationAttr(System.Xml.XmlDeclaration decl, System.String name)
  System.String GetDeclarationAttr(System.Int32 i)
  System.Int32 GetDecAttrInd(System.String name)
  System.Void InitDocTypeAttr()
  System.String GetDocumentTypeAttr(System.Xml.XmlDocumentType docType, System.String name)
  System.String GetDocumentTypeAttr(System.Int32 i)
  System.Int32 GetDocTypeAttrInd(System.String name)
  System.String GetAttributeFromElement(System.Xml.XmlElement elem, System.String name)
  System.String GetAttribute(System.String name)
  System.String GetAttributeFromElement(System.Xml.XmlElement elem, System.String name, System.String ns)
  System.String GetAttribute(System.String name, System.String ns)
  System.String GetAttribute(System.Int32 attributeIndex)
  System.Void LogMove(System.Int32 level)
  System.Void RollBackMove(System.Int32& level)
  System.Boolean get_IsOnDeclOrDocType()
  System.Void ResetToAttribute(System.Int32& level)
  System.Void ResetMove(System.Int32& level, System.Xml.XmlNodeType& nt)
  System.Boolean MoveToAttribute(System.String name)
  System.Boolean MoveToAttributeFromElement(System.Xml.XmlElement elem, System.String name, System.String ns)
  System.Boolean MoveToAttribute(System.String name, System.String namespaceURI)
  System.Void MoveToAttribute(System.Int32 attributeIndex)
  System.Boolean MoveToNextAttribute(System.Int32& level)
  System.Boolean MoveToParent()
  System.Boolean MoveToFirstChild()
  System.Boolean MoveToNextSibling(System.Xml.XmlNode node)
  System.Boolean MoveToNext()
  System.Boolean MoveToElement()
  System.String LookupNamespace(System.String prefix)
  System.String DefaultLookupNamespace(System.String prefix)
  System.String LookupPrefix(System.String namespaceName)
  System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.Boolean ReadAttributeValue(System.Int32& level, System.Boolean& bResolveEntity, System.Xml.XmlNodeType& nt)
  System.Xml.XmlDocument get_Document()
END_CLASS

CLASS: System.Xml.XmlNodeReader
TYPE:  class
TOKEN: 0x20000B5
EXTENDS: XmlReader
FIELDS:
  private           System.Xml.XmlNodeReaderNavigatorreaderNav  // 0x10
  private           System.Xml.XmlNodeType          nodeType  // 0x18
  private           System.Int32                    curDepth  // 0x1C
  private           System.Xml.ReadState            readState  // 0x20
  private           System.Boolean                  fEOF  // 0x24
  private           System.Boolean                  bResolveEntity  // 0x25
  private           System.Boolean                  bStartFromDocument  // 0x26
  private           System.Boolean                  bInReadBinary  // 0x27
  private           System.Xml.ReadContentAsBinaryHelperreadBinaryHelper  // 0x28
METHODS:
  System.Void .ctor(System.Xml.XmlNode node)
  System.Boolean IsInReadingStates()
  System.Xml.XmlNodeType get_NodeType()
  System.String get_Name()
  System.String get_LocalName()
  System.String get_NamespaceURI()
  System.String get_Prefix()
  System.Boolean get_HasValue()
  System.String get_Value()
  System.Int32 get_Depth()
  System.String get_BaseURI()
  System.Boolean get_CanResolveEntity()
  System.Boolean get_IsEmptyElement()
  System.Boolean get_IsDefault()
  System.Xml.XmlSpace get_XmlSpace()
  System.String get_XmlLang()
  System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo()
  System.Int32 get_AttributeCount()
  System.String GetAttribute(System.String name)
  System.String GetAttribute(System.String name, System.String namespaceURI)
  System.String GetAttribute(System.Int32 attributeIndex)
  System.Boolean MoveToAttribute(System.String name)
  System.Void MoveToAttribute(System.Int32 attributeIndex)
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
  System.Boolean MoveToElement()
  System.Boolean Read()
  System.Boolean Read(System.Boolean fSkipChildren)
  System.Boolean ReadNextNode(System.Boolean fSkipChildren)
  System.Void SetEndOfFile()
  System.Boolean ReadAtZeroLevel(System.Boolean fSkipChildren)
  System.Boolean ReadForward(System.Boolean fSkipChildren)
  System.Void ReSetReadingMarks()
  System.Boolean get_EOF()
  System.Void Close()
  System.Xml.ReadState get_ReadState()
  System.Void Skip()
  System.String ReadString()
  System.Boolean get_HasAttributes()
  System.Xml.XmlNameTable get_NameTable()
  System.String LookupNamespace(System.String prefix)
  System.Void ResolveEntity()
  System.Boolean ReadAttributeValue()
  System.Void FinishReadBinary()
  System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String namespaceName)
  System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String prefix)
  System.Xml.IDtdInfo get_DtdInfo()
END_CLASS

CLASS: System.Xml.XmlNotation
TYPE:  class
TOKEN: 0x20000B6
EXTENDS: XmlNode
FIELDS:
  private           System.String                   publicId  // 0x18
  private           System.String                   systemId  // 0x20
  private           System.String                   name  // 0x28
METHODS:
  System.Void .ctor(System.String name, System.String publicId, System.String systemId, System.Xml.XmlDocument doc)
  System.String get_Name()
  System.String get_LocalName()
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Boolean get_IsReadOnly()
  System.Void set_InnerXml(System.String value)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
END_CLASS

CLASS: System.Xml.XmlProcessingInstruction
TYPE:  class
TOKEN: 0x20000B7
EXTENDS: XmlLinkedNode
FIELDS:
  private           System.String                   target  // 0x20
  private           System.String                   data  // 0x28
METHODS:
  System.Void .ctor(System.String target, System.String data, System.Xml.XmlDocument doc)
  System.String get_Name()
  System.String get_LocalName()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Void set_Data(System.String value)
  System.String get_InnerText()
  System.Void set_InnerText(System.String value)
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.String get_XPLocalName()
  System.Xml.XPath.XPathNodeType get_XPNodeType()
END_CLASS

CLASS: System.Xml.XmlSignificantWhitespace
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: XmlCharacterData
FIELDS:
METHODS:
  System.Void .ctor(System.String strData, System.Xml.XmlDocument doc)
  System.String get_Name()
  System.String get_LocalName()
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode get_ParentNode()
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.Xml.XPath.XPathNodeType get_XPNodeType()
  System.Boolean get_IsText()
  System.Xml.XmlNode get_PreviousText()
END_CLASS

CLASS: System.Xml.XmlText
TYPE:  class
TOKEN: 0x20000B9
EXTENDS: XmlCharacterData
FIELDS:
METHODS:
  System.Void .ctor(System.String strData)
  System.Void .ctor(System.String strData, System.Xml.XmlDocument doc)
  System.String get_Name()
  System.String get_LocalName()
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode get_ParentNode()
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.Xml.XPath.XPathNodeType get_XPNodeType()
  System.Boolean get_IsText()
  System.Xml.XmlNode get_PreviousText()
END_CLASS

CLASS: System.Xml.XmlUnspecifiedAttribute
TYPE:  class
TOKEN: 0x20000BA
EXTENDS: XmlAttribute
FIELDS:
  private           System.Boolean                  fSpecified  // 0x28
METHODS:
  System.Void .ctor(System.String prefix, System.String localName, System.String namespaceURI, System.Xml.XmlDocument doc)
  System.Boolean get_Specified()
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Void set_InnerText(System.String value)
  System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild)
  System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild)
  System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void SetSpecified(System.Boolean f)
END_CLASS

CLASS: System.Xml.XmlWhitespace
TYPE:  class
TOKEN: 0x20000BB
EXTENDS: XmlCharacterData
FIELDS:
METHODS:
  System.Void .ctor(System.String strData, System.Xml.XmlDocument doc)
  System.String get_Name()
  System.String get_LocalName()
  System.Xml.XmlNodeType get_NodeType()
  System.Xml.XmlNode get_ParentNode()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Xml.XmlNode CloneNode(System.Boolean deep)
  System.Void WriteTo(System.Xml.XmlWriter w)
  System.Void WriteContentTo(System.Xml.XmlWriter w)
  System.Xml.XPath.XPathNodeType get_XPNodeType()
  System.Boolean get_IsText()
  System.Xml.XmlNode get_PreviousText()
END_CLASS

CLASS: System.Xml.EmptyEnumerator
TYPE:  class
TOKEN: 0x20000BC
FIELDS:
METHODS:
  System.Boolean System.Collections.IEnumerator.MoveNext()
  System.Void System.Collections.IEnumerator.Reset()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.HWStack
TYPE:  class
TOKEN: 0x20000BD
FIELDS:
  private           System.Object[]                 stack  // 0x10
  private           System.Int32                    growthRate  // 0x18
  private           System.Int32                    used  // 0x1C
  private           System.Int32                    size  // 0x20
  private           System.Int32                    limit  // 0x24
METHODS:
  System.Void .ctor(System.Int32 GrowthRate)
  System.Void .ctor(System.Int32 GrowthRate, System.Int32 limit)
  System.Object Push()
  System.Object Pop()
  System.Object Peek()
  System.Void AddToTop(System.Object o)
  System.Object get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Object value)
  System.Int32 get_Length()
  System.Void .ctor(System.Object[] stack, System.Int32 growthRate, System.Int32 used, System.Int32 size)
  System.Object Clone()
END_CLASS

CLASS: System.Xml.IHasXmlNode
TYPE:  interface
TOKEN: 0x20000BE
FIELDS:
METHODS:
  System.Xml.XmlNode GetNode()
END_CLASS

CLASS: System.Xml.IXmlLineInfo
TYPE:  interface
TOKEN: 0x20000BF
FIELDS:
METHODS:
  System.Boolean HasLineInfo()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
END_CLASS

CLASS: System.Xml.PositionInfo
TYPE:  class
TOKEN: 0x20000C0
FIELDS:
METHODS:
  System.Boolean HasLineInfo()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
  System.Xml.PositionInfo GetPositionInfo(System.Object o)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.ReaderPositionInfo
TYPE:  class
TOKEN: 0x20000C1
EXTENDS: PositionInfo
FIELDS:
  private           System.Xml.IXmlLineInfo         lineInfo  // 0x10
METHODS:
  System.Void .ctor(System.Xml.IXmlLineInfo lineInfo)
  System.Boolean HasLineInfo()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
END_CLASS

CLASS: System.Xml.IXmlNamespaceResolver
TYPE:  interface
TOKEN: 0x20000C2
FIELDS:
METHODS:
  System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String LookupNamespace(System.String prefix)
  System.String LookupPrefix(System.String namespaceName)
END_CLASS

CLASS: System.Xml.LineInfo
TYPE:  struct
TOKEN: 0x20000C3
FIELDS:
  private           System.Int32                    lineNo  // 0x10
  private           System.Int32                    linePos  // 0x14
METHODS:
  System.Void .ctor(System.Int32 lineNo, System.Int32 linePos)
  System.Void Set(System.Int32 lineNo, System.Int32 linePos)
END_CLASS

CLASS: System.Xml.NameTable
TYPE:  class
TOKEN: 0x20000C4
EXTENDS: XmlNameTable
FIELDS:
  private           System.Xml.NameTable.Entry[]    entries  // 0x10
  private           System.Int32                    count  // 0x18
  private           System.Int32                    mask  // 0x1C
  private           System.Int32                    hashCodeRandomizer  // 0x20
METHODS:
  System.Void .ctor()
  System.String Add(System.String key)
  System.String Add(System.Char[] key, System.Int32 start, System.Int32 len)
  System.String Get(System.String value)
  System.String AddEntry(System.String str, System.Int32 hashCode)
  System.Void Grow()
  System.Boolean TextEquals(System.String str1, System.Char[] str2, System.Int32 str2Start, System.Int32 str2Length)
END_CLASS

CLASS: System.Xml.Ref
TYPE:  class
TOKEN: 0x20000C6
FIELDS:
METHODS:
  System.Boolean Equal(System.String strA, System.String strB)
END_CLASS

CLASS: System.Xml.DtdParser
TYPE:  class
TOKEN: 0x20000C7
FIELDS:
  private           System.Xml.IDtdParserAdapter    readerAdapter  // 0x10
  private           System.Xml.IDtdParserAdapterWithValidationreaderAdapterWithValidation  // 0x18
  private           System.Xml.XmlNameTable         nameTable  // 0x20
  private           System.Xml.Schema.SchemaInfo    schemaInfo  // 0x28
  private           System.Xml.XmlCharType          xmlCharType  // 0x30
  private           System.String                   systemId  // 0x38
  private           System.String                   publicId  // 0x40
  private           System.Boolean                  normalize  // 0x48
  private           System.Boolean                  validate  // 0x49
  private           System.Boolean                  supportNamespaces  // 0x4A
  private           System.Boolean                  v1Compat  // 0x4B
  private           System.Char[]                   chars  // 0x50
  private           System.Int32                    charsUsed  // 0x58
  private           System.Int32                    curPos  // 0x5C
  private           System.Xml.DtdParser.ScanningFunctionscanningFunction  // 0x60
  private           System.Xml.DtdParser.ScanningFunctionnextScaningFunction  // 0x64
  private           System.Xml.DtdParser.ScanningFunctionsavedScanningFunction  // 0x68
  private           System.Boolean                  whitespaceSeen  // 0x6C
  private           System.Int32                    tokenStartPos  // 0x70
  private           System.Int32                    colonPos  // 0x74
  private           System.Text.StringBuilder       internalSubsetValueSb  // 0x78
  private           System.Int32                    externalEntitiesDepth  // 0x80
  private           System.Int32                    currentEntityId  // 0x84
  private           System.Boolean                  freeFloatingDtd  // 0x88
  private           System.Boolean                  hasFreeFloatingInternalSubset  // 0x89
  private           System.Text.StringBuilder       stringBuilder  // 0x90
  private           System.Int32                    condSectionDepth  // 0x98
  private           System.Xml.LineInfo             literalLineInfo  // 0x9C
  private           System.Char                     literalQuoteChar  // 0xA4
  private           System.String                   documentBaseUri  // 0xA8
  private           System.String                   externalDtdBaseUri  // 0xB0
  private           System.Collections.Generic.Dictionary<System.String,System.Xml.DtdParser.UndeclaredNotation>undeclaredNotations  // 0xB8
  private           System.Int32[]                  condSectionEntityIds  // 0xC0
METHODS:
  System.Void .ctor()
  System.Xml.IDtdParser Create()
  System.Void Initialize(System.Xml.IDtdParserAdapter readerAdapter)
  System.Void InitializeFreeFloatingDtd(System.String baseUri, System.String docTypeName, System.String publicId, System.String systemId, System.String internalSubset, System.Xml.IDtdParserAdapter adapter)
  System.Xml.IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, System.Boolean saveInternalSubset)
  System.Xml.IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(System.String baseUri, System.String docTypeName, System.String publicId, System.String systemId, System.String internalSubset, System.Xml.IDtdParserAdapter adapter)
  System.Boolean get_ParsingInternalSubset()
  System.Boolean get_IgnoreEntityReferences()
  System.Boolean get_SaveInternalSubsetValue()
  System.Boolean get_ParsingTopLevelMarkup()
  System.Boolean get_SupportNamespaces()
  System.Boolean get_Normalize()
  System.Void Parse(System.Boolean saveInternalSubset)
  System.Void ParseInDocumentDtd(System.Boolean saveInternalSubset)
  System.Void ParseFreeFloatingDtd()
  System.Void ParseInternalSubset()
  System.Void ParseExternalSubset()
  System.Void ParseSubset()
  System.Void ParseAttlistDecl()
  System.Void ParseAttlistType(System.Xml.Schema.SchemaAttDef attrDef, System.Xml.Schema.SchemaElementDecl elementDecl, System.Boolean ignoreErrors)
  System.Void ParseAttlistDefault(System.Xml.Schema.SchemaAttDef attrDef, System.Boolean ignoreErrors)
  System.Void ParseElementDecl()
  System.Void ParseElementOnlyContent(System.Xml.Schema.ParticleContentValidator pcv, System.Int32 startParenEntityId)
  System.Void ParseHowMany(System.Xml.Schema.ParticleContentValidator pcv)
  System.Void ParseElementMixedContent(System.Xml.Schema.ParticleContentValidator pcv, System.Int32 startParenEntityId)
  System.Void ParseEntityDecl()
  System.Void ParseNotationDecl()
  System.Void AddUndeclaredNotation(System.String notationName)
  System.Void ParseComment()
  System.Void ParsePI()
  System.Void ParseCondSection()
  System.Void ParseExternalId(System.Xml.DtdParser.Token idTokenType, System.Xml.DtdParser.Token declType, System.String& publicId, System.String& systemId)
  System.Xml.DtdParser.Token GetToken(System.Boolean needWhiteSpace)
  System.Xml.DtdParser.Token ScanSubsetContent()
  System.Xml.DtdParser.Token ScanNameExpected()
  System.Xml.DtdParser.Token ScanQNameExpected()
  System.Xml.DtdParser.Token ScanNmtokenExpected()
  System.Xml.DtdParser.Token ScanDoctype1()
  System.Xml.DtdParser.Token ScanDoctype2()
  System.Xml.DtdParser.Token ScanClosingTag()
  System.Xml.DtdParser.Token ScanElement1()
  System.Xml.DtdParser.Token ScanElement2()
  System.Xml.DtdParser.Token ScanElement3()
  System.Xml.DtdParser.Token ScanElement4()
  System.Xml.DtdParser.Token ScanElement5()
  System.Xml.DtdParser.Token ScanElement6()
  System.Xml.DtdParser.Token ScanElement7()
  System.Xml.DtdParser.Token ScanAttlist1()
  System.Xml.DtdParser.Token ScanAttlist2()
  System.Xml.DtdParser.Token ScanAttlist3()
  System.Xml.DtdParser.Token ScanAttlist4()
  System.Xml.DtdParser.Token ScanAttlist5()
  System.Xml.DtdParser.Token ScanAttlist6()
  System.Xml.DtdParser.Token ScanAttlist7()
  System.Xml.DtdParser.Token ScanLiteral(System.Xml.DtdParser.LiteralType literalType)
  System.Xml.XmlQualifiedName ScanEntityName()
  System.Xml.DtdParser.Token ScanNotation1()
  System.Xml.DtdParser.Token ScanSystemId()
  System.Xml.DtdParser.Token ScanEntity1()
  System.Xml.DtdParser.Token ScanEntity2()
  System.Xml.DtdParser.Token ScanEntity3()
  System.Xml.DtdParser.Token ScanPublicId1()
  System.Xml.DtdParser.Token ScanPublicId2()
  System.Xml.DtdParser.Token ScanCondSection1()
  System.Xml.DtdParser.Token ScanCondSection2()
  System.Xml.DtdParser.Token ScanCondSection3()
  System.Void ScanName()
  System.Void ScanQName()
  System.Void ScanQName(System.Boolean isQName)
  System.Boolean ReadDataInName()
  System.Void ScanNmtoken()
  System.Boolean EatPublicKeyword()
  System.Boolean EatSystemKeyword()
  System.Xml.XmlQualifiedName GetNameQualified(System.Boolean canHavePrefix)
  System.String GetNameString()
  System.String GetNmtokenString()
  System.String GetValue()
  System.String GetValueWithStrippedSpaces()
  System.Int32 ReadData()
  System.Void LoadParsingBuffer()
  System.Void SaveParsingBuffer()
  System.Void SaveParsingBuffer(System.Int32 internalSubsetValueEndPos)
  System.Boolean HandleEntityReference(System.Boolean paramEntity, System.Boolean inLiteral, System.Boolean inAttribute)
  System.Boolean HandleEntityReference(System.Xml.XmlQualifiedName entityName, System.Boolean paramEntity, System.Boolean inLiteral, System.Boolean inAttribute)
  System.Boolean HandleEntityEnd(System.Boolean inLiteral)
  System.Xml.Schema.SchemaEntity VerifyEntityReference(System.Xml.XmlQualifiedName entityName, System.Boolean paramEntity, System.Boolean mustBeDeclared, System.Boolean inAttribute)
  System.Void SendValidationEvent(System.Int32 pos, System.Xml.Schema.XmlSeverityType severity, System.String code, System.String arg)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.String code, System.String arg)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException e)
  System.Boolean IsAttributeValueType(System.Xml.DtdParser.Token token)
  System.Int32 get_LineNo()
  System.Int32 get_LinePos()
  System.String get_BaseUriStr()
  System.Void OnUnexpectedError()
  System.Void Throw(System.Int32 curPos, System.String res)
  System.Void Throw(System.Int32 curPos, System.String res, System.String arg)
  System.Void Throw(System.Int32 curPos, System.String res, System.String[] args)
  System.Void Throw(System.String res, System.String arg, System.Int32 lineNo, System.Int32 linePos)
  System.Void ThrowInvalidChar(System.Int32 pos, System.String data, System.Int32 invCharPos)
  System.Void ThrowInvalidChar(System.Char[] data, System.Int32 length, System.Int32 invCharPos)
  System.Void ThrowUnexpectedToken(System.Int32 pos, System.String expectedToken)
  System.Void ThrowUnexpectedToken(System.Int32 pos, System.String expectedToken1, System.String expectedToken2)
  System.String ParseUnexpectedToken(System.Int32 startPos)
  System.String StripSpaces(System.String value)
END_CLASS

CLASS: System.Xml.XmlTokenizedType
TYPE:  struct
TOKEN: 0x20000CD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlTokenizedType     CDATA  // 0x0
  public    static  System.Xml.XmlTokenizedType     ID  // 0x0
  public    static  System.Xml.XmlTokenizedType     IDREF  // 0x0
  public    static  System.Xml.XmlTokenizedType     IDREFS  // 0x0
  public    static  System.Xml.XmlTokenizedType     ENTITY  // 0x0
  public    static  System.Xml.XmlTokenizedType     ENTITIES  // 0x0
  public    static  System.Xml.XmlTokenizedType     NMTOKEN  // 0x0
  public    static  System.Xml.XmlTokenizedType     NMTOKENS  // 0x0
  public    static  System.Xml.XmlTokenizedType     NOTATION  // 0x0
  public    static  System.Xml.XmlTokenizedType     ENUMERATION  // 0x0
  public    static  System.Xml.XmlTokenizedType     QName  // 0x0
  public    static  System.Xml.XmlTokenizedType     NCName  // 0x0
  public    static  System.Xml.XmlTokenizedType     None  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.ValidateNames
TYPE:  class
TOKEN: 0x20000CE
FIELDS:
  private   static  System.Xml.XmlCharType          xmlCharType  // 0x0
METHODS:
  System.Int32 ParseNmtoken(System.String s, System.Int32 offset)
  System.Int32 ParseNmtokenNoNamespaces(System.String s, System.Int32 offset)
  System.Int32 ParseNameNoNamespaces(System.String s, System.Int32 offset)
  System.Boolean IsNameNoNamespaces(System.String s)
  System.Int32 ParseNCName(System.String s, System.Int32 offset)
  System.Int32 ParseNCName(System.String s)
  System.Int32 ParseQName(System.String s, System.Int32 offset, System.Int32& colonOffset)
  System.Void ParseQNameThrow(System.String s, System.String& prefix, System.String& localName)
  System.Void ThrowInvalidName(System.String s, System.Int32 offsetStartChar, System.Int32 offsetBadChar)
  System.Exception GetInvalidNameException(System.String s, System.Int32 offsetStartChar, System.Int32 offsetBadChar)
  System.Void SplitQName(System.String name, System.String& prefix, System.String& lname)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.XmlCharType
TYPE:  struct
TOKEN: 0x20000CF
FIELDS:
  private   static  System.Object                   s_Lock  // 0x0
  private   static  System.Byte[]                   s_CharProperties  // 0x8
  private           System.Byte[]                   charProperties  // 0x10
METHODS:
  System.Object get_StaticLock()
  System.Void InitInstance()
  System.Void SetProperties(System.Byte[] chProps, System.String ranges, System.Byte value)
  System.Void .ctor(System.Byte[] charProperties)
  System.Xml.XmlCharType get_Instance()
  System.Boolean IsWhiteSpace(System.Char ch)
  System.Boolean IsNCNameSingleChar(System.Char ch)
  System.Boolean IsStartNCNameSingleChar(System.Char ch)
  System.Boolean IsNameSingleChar(System.Char ch)
  System.Boolean IsCharData(System.Char ch)
  System.Boolean IsPubidChar(System.Char ch)
  System.Boolean IsTextChar(System.Char ch)
  System.Boolean IsLetter(System.Char ch)
  System.Boolean IsNCNameCharXml4e(System.Char ch)
  System.Boolean IsStartNCNameCharXml4e(System.Char ch)
  System.Boolean IsNameCharXml4e(System.Char ch)
  System.Boolean IsDigit(System.Char ch)
  System.Boolean IsHighSurrogate(System.Int32 ch)
  System.Boolean IsLowSurrogate(System.Int32 ch)
  System.Boolean IsSurrogate(System.Int32 ch)
  System.Int32 CombineSurrogateChar(System.Int32 lowChar, System.Int32 highChar)
  System.Void SplitSurrogateChar(System.Int32 combinedChar, System.Char& lowChar, System.Char& highChar)
  System.Boolean IsOnlyWhitespace(System.String str)
  System.Int32 IsOnlyWhitespaceWithPos(System.String str)
  System.Int32 IsOnlyCharData(System.String str)
  System.Boolean IsOnlyDigits(System.String str, System.Int32 startPos, System.Int32 len)
  System.Int32 IsPublicId(System.String str)
  System.Boolean InRange(System.Int32 value, System.Int32 start, System.Int32 end)
END_CLASS

CLASS: System.Xml.XmlComplianceUtil
TYPE:  class
TOKEN: 0x20000D0
FIELDS:
METHODS:
  System.String NonCDataNormalize(System.String value)
  System.String CDataNormalize(System.String value)
END_CLASS

CLASS: System.Xml.ExceptionType
TYPE:  struct
TOKEN: 0x20000D1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.ExceptionType        ArgumentException  // 0x0
  public    static  System.Xml.ExceptionType        XmlException  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlDateTimeSerializationMode
TYPE:  struct
TOKEN: 0x20000D2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlDateTimeSerializationModeLocal  // 0x0
  public    static  System.Xml.XmlDateTimeSerializationModeUtc  // 0x0
  public    static  System.Xml.XmlDateTimeSerializationModeUnspecified  // 0x0
  public    static  System.Xml.XmlDateTimeSerializationModeRoundtripKind  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlConvert
TYPE:  class
TOKEN: 0x20000D3
FIELDS:
  private   static  System.Xml.XmlCharType          xmlCharType  // 0x0
  private   static  System.Char[]                   crt  // 0x8
  private   static readonly System.Int32                    c_EncodedCharLength  // 0x10
  private   static  System.Text.RegularExpressions.Regexc_EncodeCharPattern  // 0x18
  private   static  System.Text.RegularExpressions.Regexc_DecodeCharPattern  // 0x20
  private   static  System.String[]                 s_allDateTimeFormats  // 0x28
  private   static readonly System.Char[]                   WhitespaceChars  // 0x30
METHODS:
  System.String EncodeName(System.String name)
  System.String EncodeLocalName(System.String name)
  System.String DecodeName(System.String name)
  System.String EncodeName(System.String name, System.Boolean first, System.Boolean local)
  System.Int32 FromHex(System.Char digit)
  System.Byte[] FromBinHexString(System.String s)
  System.Byte[] FromBinHexString(System.String s, System.Boolean allowOddCount)
  System.String ToBinHexString(System.Byte[] inArray)
  System.String VerifyName(System.String name)
  System.Exception TryVerifyName(System.String name)
  System.String VerifyQName(System.String name, System.Xml.ExceptionType exceptionType)
  System.String VerifyNCName(System.String name)
  System.String VerifyNCName(System.String name, System.Xml.ExceptionType exceptionType)
  System.Exception TryVerifyNCName(System.String name)
  System.String VerifyTOKEN(System.String token)
  System.Exception TryVerifyTOKEN(System.String token)
  System.Exception TryVerifyNMTOKEN(System.String name)
  System.Exception TryVerifyNormalizedString(System.String str)
  System.String ToString(System.Boolean value)
  System.String ToString(System.Char value)
  System.String ToString(System.Decimal value)
  System.String ToString(System.SByte value)
  System.String ToString(System.Int16 value)
  System.String ToString(System.Int32 value)
  System.String ToString(System.Int64 value)
  System.String ToString(System.Byte value)
  System.String ToString(System.UInt16 value)
  System.String ToString(System.UInt32 value)
  System.String ToString(System.UInt64 value)
  System.String ToString(System.Single value)
  System.String ToString(System.Double value)
  System.String ToString(System.TimeSpan value)
  System.String ToString(System.DateTime value, System.String format)
  System.String ToString(System.DateTime value, System.Xml.XmlDateTimeSerializationMode dateTimeOption)
  System.String ToString(System.DateTimeOffset value)
  System.String ToString(System.Guid value)
  System.Boolean ToBoolean(System.String s)
  System.Exception TryToBoolean(System.String s, System.Boolean& result)
  System.Char ToChar(System.String s)
  System.Exception TryToChar(System.String s, System.Char& result)
  System.Decimal ToDecimal(System.String s)
  System.Exception TryToDecimal(System.String s, System.Decimal& result)
  System.Decimal ToInteger(System.String s)
  System.Exception TryToInteger(System.String s, System.Decimal& result)
  System.SByte ToSByte(System.String s)
  System.Exception TryToSByte(System.String s, System.SByte& result)
  System.Int16 ToInt16(System.String s)
  System.Exception TryToInt16(System.String s, System.Int16& result)
  System.Int32 ToInt32(System.String s)
  System.Exception TryToInt32(System.String s, System.Int32& result)
  System.Int64 ToInt64(System.String s)
  System.Exception TryToInt64(System.String s, System.Int64& result)
  System.Byte ToByte(System.String s)
  System.Exception TryToByte(System.String s, System.Byte& result)
  System.UInt16 ToUInt16(System.String s)
  System.Exception TryToUInt16(System.String s, System.UInt16& result)
  System.UInt32 ToUInt32(System.String s)
  System.Exception TryToUInt32(System.String s, System.UInt32& result)
  System.UInt64 ToUInt64(System.String s)
  System.Exception TryToUInt64(System.String s, System.UInt64& result)
  System.Single ToSingle(System.String s)
  System.Exception TryToSingle(System.String s, System.Single& result)
  System.Double ToDouble(System.String s)
  System.Exception TryToDouble(System.String s, System.Double& result)
  System.Double ToXPathDouble(System.Object o)
  System.Double XPathRound(System.Double value)
  System.TimeSpan ToTimeSpan(System.String s)
  System.Exception TryToTimeSpan(System.String s, System.TimeSpan& result)
  System.String[] get_AllDateTimeFormats()
  System.Void CreateAllDateTimeFormats()
  System.DateTime ToDateTime(System.String s)
  System.DateTime ToDateTime(System.String s, System.String[] formats)
  System.DateTime ToDateTime(System.String s, System.Xml.XmlDateTimeSerializationMode dateTimeOption)
  System.DateTimeOffset ToDateTimeOffset(System.String s)
  System.Guid ToGuid(System.String s)
  System.Exception TryToGuid(System.String s, System.Guid& result)
  System.DateTime SwitchToLocalTime(System.DateTime value)
  System.DateTime SwitchToUtcTime(System.DateTime value)
  System.Uri ToUri(System.String s)
  System.Exception TryToUri(System.String s, System.Uri& result)
  System.Boolean StrEqual(System.Char[] chars, System.Int32 strPos1, System.Int32 strLen1, System.String str2)
  System.String TrimString(System.String value)
  System.String TrimStringStart(System.String value)
  System.String TrimStringEnd(System.String value)
  System.String[] SplitString(System.String value)
  System.Boolean IsNegativeZero(System.Double value)
  System.Int64 DoubleToInt64Bits(System.Double value)
  System.Void VerifyCharData(System.String data, System.Xml.ExceptionType invCharExceptionType, System.Xml.ExceptionType invSurrogateExceptionType)
  System.Exception CreateException(System.String res, System.Xml.ExceptionType exceptionType, System.Int32 lineNo, System.Int32 linePos)
  System.Exception CreateException(System.String res, System.String arg, System.Xml.ExceptionType exceptionType, System.Int32 lineNo, System.Int32 linePos)
  System.Exception CreateException(System.String res, System.String[] args, System.Xml.ExceptionType exceptionType)
  System.Exception CreateException(System.String res, System.String[] args, System.Xml.ExceptionType exceptionType, System.Int32 lineNo, System.Int32 linePos)
  System.Exception CreateInvalidSurrogatePairException(System.Char low, System.Char hi)
  System.Exception CreateInvalidSurrogatePairException(System.Char low, System.Char hi, System.Xml.ExceptionType exceptionType)
  System.Exception CreateInvalidSurrogatePairException(System.Char low, System.Char hi, System.Xml.ExceptionType exceptionType, System.Int32 lineNo, System.Int32 linePos)
  System.Exception CreateInvalidHighSurrogateCharException(System.Char hi)
  System.Exception CreateInvalidHighSurrogateCharException(System.Char hi, System.Xml.ExceptionType exceptionType)
  System.Exception CreateInvalidHighSurrogateCharException(System.Char hi, System.Xml.ExceptionType exceptionType, System.Int32 lineNo, System.Int32 linePos)
  System.Exception CreateInvalidCharException(System.String data, System.Int32 invCharPos, System.Xml.ExceptionType exceptionType)
  System.Exception CreateInvalidCharException(System.Char invChar, System.Char nextChar)
  System.Exception CreateInvalidCharException(System.Char invChar, System.Char nextChar, System.Xml.ExceptionType exceptionType)
  System.Exception CreateInvalidNameCharException(System.String name, System.Int32 index, System.Xml.ExceptionType exceptionType)
  System.ArgumentException CreateInvalidNameArgumentException(System.String name, System.String argumentName)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.XmlDownloadManager
TYPE:  class
TOKEN: 0x20000D4
FIELDS:
  private           System.Collections.Hashtable    connections  // 0x10
METHODS:
  System.IO.Stream GetStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy)
  System.IO.Stream GetNonFileStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy)
  System.Void Remove(System.String host)
  System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy)
  System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.OpenedHost
TYPE:  class
TOKEN: 0x20000D7
FIELDS:
  private           System.Int32                    nonCachedConnectionsCount  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.XmlRegisteredNonCachedStream
TYPE:  class
TOKEN: 0x20000D8
EXTENDS: Stream
FIELDS:
  protected         System.IO.Stream                stream  // 0x28
  private           System.Xml.XmlDownloadManager   downloadManager  // 0x30
  private           System.String                   host  // 0x38
METHODS:
  System.Void .ctor(System.IO.Stream stream, System.Xml.XmlDownloadManager downloadManager, System.String host)
  System.Void Finalize()
  System.Void Dispose(System.Boolean disposing)
  System.IAsyncResult BeginRead(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object state)
  System.IAsyncResult BeginWrite(System.Byte[] buffer, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object state)
  System.Int32 EndRead(System.IAsyncResult asyncResult)
  System.Void EndWrite(System.IAsyncResult asyncResult)
  System.Void Flush()
  System.Int32 Read(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Int32 ReadByte()
  System.Int64 Seek(System.Int64 offset, System.IO.SeekOrigin origin)
  System.Void SetLength(System.Int64 value)
  System.Void Write(System.Byte[] buffer, System.Int32 offset, System.Int32 count)
  System.Void WriteByte(System.Byte value)
  System.Boolean get_CanRead()
  System.Boolean get_CanSeek()
  System.Boolean get_CanWrite()
  System.Int64 get_Length()
  System.Int64 get_Position()
  System.Void set_Position(System.Int64 value)
END_CLASS

CLASS: System.Xml.XmlCachedStream
TYPE:  class
TOKEN: 0x20000D9
EXTENDS: MemoryStream
FIELDS:
  private           System.Uri                      uri  // 0x50
METHODS:
  System.Void .ctor(System.Uri uri, System.IO.Stream stream)
END_CLASS

CLASS: System.Xml.UTF16Decoder
TYPE:  class
TOKEN: 0x20000DA
EXTENDS: Decoder
FIELDS:
  private           System.Boolean                  bigEndian  // 0x20
  private           System.Int32                    lastByte  // 0x24
METHODS:
  System.Void .ctor(System.Boolean bigEndian)
  System.Int32 GetCharCount(System.Byte[] bytes, System.Int32 index, System.Int32 count)
  System.Int32 GetCharCount(System.Byte[] bytes, System.Int32 index, System.Int32 count, System.Boolean flush)
  System.Int32 GetChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex)
  System.Void Convert(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex, System.Int32 charCount, System.Boolean flush, System.Int32& bytesUsed, System.Int32& charsUsed, System.Boolean& completed)
END_CLASS

CLASS: System.Xml.SafeAsciiDecoder
TYPE:  class
TOKEN: 0x20000DB
EXTENDS: Decoder
FIELDS:
METHODS:
  System.Void .ctor()
  System.Int32 GetCharCount(System.Byte[] bytes, System.Int32 index, System.Int32 count)
  System.Int32 GetChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex)
  System.Void Convert(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex, System.Int32 charCount, System.Boolean flush, System.Int32& bytesUsed, System.Int32& charsUsed, System.Boolean& completed)
END_CLASS

CLASS: System.Xml.Ucs4Encoding
TYPE:  class
TOKEN: 0x20000DC
EXTENDS: Encoding
FIELDS:
  private           System.Xml.Ucs4Decoder          ucs4Decoder  // 0x38
METHODS:
  System.String get_WebName()
  System.Text.Decoder GetDecoder()
  System.Int32 GetByteCount(System.Char[] chars, System.Int32 index, System.Int32 count)
  System.Byte[] GetBytes(System.String s)
  System.Int32 GetBytes(System.Char[] chars, System.Int32 charIndex, System.Int32 charCount, System.Byte[] bytes, System.Int32 byteIndex)
  System.Int32 GetMaxByteCount(System.Int32 charCount)
  System.Int32 GetCharCount(System.Byte[] bytes, System.Int32 index, System.Int32 count)
  System.Int32 GetChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex)
  System.Int32 GetMaxCharCount(System.Int32 byteCount)
  System.Int32 get_CodePage()
  System.Text.Encoder GetEncoder()
  System.Text.Encoding get_UCS4_Littleendian()
  System.Text.Encoding get_UCS4_Bigendian()
  System.Text.Encoding get_UCS4_2143()
  System.Text.Encoding get_UCS4_3412()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Ucs4Encoding1234
TYPE:  class
TOKEN: 0x20000DD
EXTENDS: Ucs4Encoding
FIELDS:
METHODS:
  System.Void .ctor()
  System.String get_EncodingName()
  System.Byte[] GetPreamble()
END_CLASS

CLASS: System.Xml.Ucs4Encoding4321
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: Ucs4Encoding
FIELDS:
METHODS:
  System.Void .ctor()
  System.String get_EncodingName()
  System.Byte[] GetPreamble()
END_CLASS

CLASS: System.Xml.Ucs4Encoding2143
TYPE:  class
TOKEN: 0x20000DF
EXTENDS: Ucs4Encoding
FIELDS:
METHODS:
  System.Void .ctor()
  System.String get_EncodingName()
  System.Byte[] GetPreamble()
END_CLASS

CLASS: System.Xml.Ucs4Encoding3412
TYPE:  class
TOKEN: 0x20000E0
EXTENDS: Ucs4Encoding
FIELDS:
METHODS:
  System.Void .ctor()
  System.String get_EncodingName()
  System.Byte[] GetPreamble()
END_CLASS

CLASS: System.Xml.Ucs4Decoder
TYPE:  class
TOKEN: 0x20000E1
EXTENDS: Decoder
FIELDS:
  private           System.Byte[]                   lastBytes  // 0x20
  private           System.Int32                    lastBytesCount  // 0x28
METHODS:
  System.Int32 GetCharCount(System.Byte[] bytes, System.Int32 index, System.Int32 count)
  System.Int32 GetFullChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex)
  System.Int32 GetChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex)
  System.Void Convert(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex, System.Int32 charCount, System.Boolean flush, System.Int32& bytesUsed, System.Int32& charsUsed, System.Boolean& completed)
  System.Void Ucs4ToUTF16(System.UInt32 code, System.Char[] chars, System.Int32 charIndex)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Ucs4Decoder4321
TYPE:  class
TOKEN: 0x20000E2
EXTENDS: Ucs4Decoder
FIELDS:
METHODS:
  System.Int32 GetFullChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Ucs4Decoder1234
TYPE:  class
TOKEN: 0x20000E3
EXTENDS: Ucs4Decoder
FIELDS:
METHODS:
  System.Int32 GetFullChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Ucs4Decoder2143
TYPE:  class
TOKEN: 0x20000E4
EXTENDS: Ucs4Decoder
FIELDS:
METHODS:
  System.Int32 GetFullChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Ucs4Decoder3412
TYPE:  class
TOKEN: 0x20000E5
EXTENDS: Ucs4Decoder
FIELDS:
METHODS:
  System.Int32 GetFullChars(System.Byte[] bytes, System.Int32 byteIndex, System.Int32 byteCount, System.Char[] chars, System.Int32 charIndex)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.XmlException
TYPE:  class
TOKEN: 0x20000E6
EXTENDS: SystemException
FIELDS:
  private           System.String                   res  // 0x90
  private           System.String[]                 args  // 0x98
  private           System.Int32                    lineNumber  // 0xA0
  private           System.Int32                    linePosition  // 0xA4
  private           System.String                   sourceUri  // 0xA8
  private           System.String                   message  // 0xB0
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
  System.Void .ctor(System.String message, System.Exception innerException, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void .ctor(System.String message, System.Exception innerException, System.Int32 lineNumber, System.Int32 linePosition, System.String sourceUri)
  System.Void .ctor(System.String res, System.String[] args)
  System.Void .ctor(System.String res, System.String arg)
  System.Void .ctor(System.String res, System.String arg, System.String sourceUri)
  System.Void .ctor(System.String res, System.String arg, System.Xml.IXmlLineInfo lineInfo)
  System.Void .ctor(System.String res, System.String arg, System.Exception innerException, System.Xml.IXmlLineInfo lineInfo)
  System.Void .ctor(System.String res, System.String[] args, System.Xml.IXmlLineInfo lineInfo)
  System.Void .ctor(System.String res, System.String[] args, System.Xml.IXmlLineInfo lineInfo, System.String sourceUri)
  System.Void .ctor(System.String res, System.String arg, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void .ctor(System.String res, System.String arg, System.Int32 lineNumber, System.Int32 linePosition, System.String sourceUri)
  System.Void .ctor(System.String res, System.String[] args, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void .ctor(System.String res, System.String[] args, System.Int32 lineNumber, System.Int32 linePosition, System.String sourceUri)
  System.Void .ctor(System.String res, System.String[] args, System.Exception innerException, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void .ctor(System.String res, System.String[] args, System.Exception innerException, System.Int32 lineNumber, System.Int32 linePosition, System.String sourceUri)
  System.String FormatUserMessage(System.String message, System.Int32 lineNumber, System.Int32 linePosition)
  System.String CreateMessage(System.String res, System.String[] args, System.Int32 lineNumber, System.Int32 linePosition)
  System.String[] BuildCharExceptionArgs(System.String data, System.Int32 invCharIndex)
  System.String[] BuildCharExceptionArgs(System.Char[] data, System.Int32 length, System.Int32 invCharIndex)
  System.String[] BuildCharExceptionArgs(System.Char invChar, System.Char nextChar)
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
  System.String get_Message()
  System.String get_ResString()
END_CLASS

CLASS: System.Xml.XmlNameTable
TYPE:  class
TOKEN: 0x20000E7
FIELDS:
METHODS:
  System.String Get(System.String array)
  System.String Add(System.Char[] array, System.Int32 offset, System.Int32 length)
  System.String Add(System.String array)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.XmlNamespaceScope
TYPE:  struct
TOKEN: 0x20000E8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlNamespaceScope    All  // 0x0
  public    static  System.Xml.XmlNamespaceScope    ExcludeXml  // 0x0
  public    static  System.Xml.XmlNamespaceScope    Local  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlNamespaceManager
TYPE:  class
TOKEN: 0x20000E9
FIELDS:
  private           System.Xml.XmlNamespaceManager.NamespaceDeclaration[]nsdecls  // 0x10
  private           System.Int32                    lastDecl  // 0x18
  private           System.Xml.XmlNameTable         nameTable  // 0x20
  private           System.Int32                    scopeId  // 0x28
  private           System.Collections.Generic.Dictionary<System.String,System.Int32>hashTable  // 0x30
  private           System.Boolean                  useHashtable  // 0x38
  private           System.String                   xml  // 0x40
  private           System.String                   xmlNs  // 0x48
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Xml.XmlNameTable nameTable)
  System.Xml.XmlNameTable get_NameTable()
  System.String get_DefaultNamespace()
  System.Void PushScope()
  System.Boolean PopScope()
  System.Void AddNamespace(System.String prefix, System.String uri)
  System.Void RemoveNamespace(System.String prefix, System.String uri)
  System.Collections.IEnumerator GetEnumerator()
  System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.String LookupNamespace(System.String prefix)
  System.Int32 LookupNamespaceDecl(System.String prefix)
  System.String LookupPrefix(System.String uri)
END_CLASS

CLASS: System.Xml.XmlNodeOrder
TYPE:  struct
TOKEN: 0x20000EB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlNodeOrder         Before  // 0x0
  public    static  System.Xml.XmlNodeOrder         After  // 0x0
  public    static  System.Xml.XmlNodeOrder         Same  // 0x0
  public    static  System.Xml.XmlNodeOrder         Unknown  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlNodeType
TYPE:  struct
TOKEN: 0x20000EC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XmlNodeType          None  // 0x0
  public    static  System.Xml.XmlNodeType          Element  // 0x0
  public    static  System.Xml.XmlNodeType          Attribute  // 0x0
  public    static  System.Xml.XmlNodeType          Text  // 0x0
  public    static  System.Xml.XmlNodeType          CDATA  // 0x0
  public    static  System.Xml.XmlNodeType          EntityReference  // 0x0
  public    static  System.Xml.XmlNodeType          Entity  // 0x0
  public    static  System.Xml.XmlNodeType          ProcessingInstruction  // 0x0
  public    static  System.Xml.XmlNodeType          Comment  // 0x0
  public    static  System.Xml.XmlNodeType          Document  // 0x0
  public    static  System.Xml.XmlNodeType          DocumentType  // 0x0
  public    static  System.Xml.XmlNodeType          DocumentFragment  // 0x0
  public    static  System.Xml.XmlNodeType          Notation  // 0x0
  public    static  System.Xml.XmlNodeType          Whitespace  // 0x0
  public    static  System.Xml.XmlNodeType          SignificantWhitespace  // 0x0
  public    static  System.Xml.XmlNodeType          EndElement  // 0x0
  public    static  System.Xml.XmlNodeType          EndEntity  // 0x0
  public    static  System.Xml.XmlNodeType          XmlDeclaration  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlQualifiedName
TYPE:  class
TOKEN: 0x20000ED
FIELDS:
  private   static  System.Xml.XmlQualifiedName.HashCodeOfStringDelegatehashCodeDelegate  // 0x0
  private           System.String                   name  // 0x10
  private           System.String                   ns  // 0x18
  private           System.Int32                    hash  // 0x20
  public    static readonly System.Xml.XmlQualifiedName     Empty  // 0x8
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String name)
  System.Void .ctor(System.String name, System.String ns)
  System.String get_Namespace()
  System.String get_Name()
  System.Int32 GetHashCode()
  System.Boolean get_IsEmpty()
  System.String ToString()
  System.Boolean Equals(System.Object other)
  System.Boolean op_Equality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b)
  System.Boolean op_Inequality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b)
  System.String ToString(System.String name, System.String ns)
  System.Xml.XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate()
  System.Boolean IsRandomizedHashingDisabled()
  System.Int32 GetHashCodeOfString(System.String s, System.Int32 length, System.Int64 additionalEntropy)
  System.Void Init(System.String name, System.String ns)
  System.Void SetNamespace(System.String ns)
  System.Void Verify()
  System.Void Atomize(System.Xml.XmlNameTable nameTable)
  System.Xml.XmlQualifiedName Parse(System.String s, System.Xml.IXmlNamespaceResolver nsmgr, System.String& prefix)
  System.Xml.XmlQualifiedName Clone()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.XmlResolver
TYPE:  class
TOKEN: 0x20000EF
FIELDS:
METHODS:
  System.Object GetEntity(System.Uri absoluteUri, System.String role, System.Type ofObjectToReturn)
  System.Uri ResolveUri(System.Uri baseUri, System.String relativeUri)
  System.Boolean SupportsType(System.Uri absoluteUri, System.Type type)
  System.Threading.Tasks.Task<System.Object> GetEntityAsync(System.Uri absoluteUri, System.String role, System.Type ofObjectToReturn)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.XmlUrlResolver
TYPE:  class
TOKEN: 0x20000F0
EXTENDS: XmlResolver
FIELDS:
  private   static  System.Object                   s_DownloadManager  // 0x0
  private           System.Net.ICredentials         _credentials  // 0x10
  private           System.Net.IWebProxy            _proxy  // 0x18
  private           System.Net.Cache.RequestCachePolicy_cachePolicy  // 0x20
METHODS:
  System.Xml.XmlDownloadManager get_DownloadManager()
  System.Void .ctor()
  System.Object GetEntity(System.Uri absoluteUri, System.String role, System.Type ofObjectToReturn)
  System.Uri ResolveUri(System.Uri baseUri, System.String relativeUri)
  System.Threading.Tasks.Task<System.Object> GetEntityAsync(System.Uri absoluteUri, System.String role, System.Type ofObjectToReturn)
END_CLASS

CLASS: System.Xml.BinaryCompatibility
TYPE:  class
TOKEN: 0x20000F2
FIELDS:
METHODS:
  System.Boolean get_TargetsAtLeast_Desktop_V4_5_2()
END_CLASS

CLASS: System.Xml.Res
TYPE:  class
TOKEN: 0x20000F3
FIELDS:
METHODS:
  System.String GetString(System.String name)
  System.String GetString(System.String name, System.Object[] args)
END_CLASS

CLASS: System.Xml.Schema.AxisElement
TYPE:  class
TOKEN: 0x200015D
FIELDS:
  private           System.Xml.Schema.DoubleLinkAxiscurNode  // 0x10
  private           System.Int32                    rootDepth  // 0x18
  private           System.Int32                    curDepth  // 0x1C
  private           System.Boolean                  isMatch  // 0x20
METHODS:
  System.Xml.Schema.DoubleLinkAxis get_CurNode()
  System.Void .ctor(System.Xml.Schema.DoubleLinkAxis node, System.Int32 depth)
  System.Void SetDepth(System.Int32 depth)
  System.Void MoveToParent(System.Int32 depth, System.Xml.Schema.ForwardAxis parent)
  System.Boolean MoveToChild(System.String name, System.String URN, System.Int32 depth, System.Xml.Schema.ForwardAxis parent)
END_CLASS

CLASS: System.Xml.Schema.AxisStack
TYPE:  class
TOKEN: 0x200015E
FIELDS:
  private           System.Collections.ArrayList    _stack  // 0x10
  private           System.Xml.Schema.ForwardAxis   _subtree  // 0x18
  private           System.Xml.Schema.ActiveAxis    _parent  // 0x20
METHODS:
  System.Xml.Schema.ForwardAxis get_Subtree()
  System.Int32 get_Length()
  System.Void .ctor(System.Xml.Schema.ForwardAxis faxis, System.Xml.Schema.ActiveAxis parent)
  System.Void Push(System.Int32 depth)
  System.Void Pop()
  System.Boolean Equal(System.String thisname, System.String thisURN, System.String name, System.String URN)
  System.Void MoveToParent(System.String name, System.String URN, System.Int32 depth)
  System.Boolean MoveToChild(System.String name, System.String URN, System.Int32 depth)
  System.Boolean MoveToAttribute(System.String name, System.String URN, System.Int32 depth)
END_CLASS

CLASS: System.Xml.Schema.ActiveAxis
TYPE:  class
TOKEN: 0x200015F
FIELDS:
  private           System.Int32                    _currentDepth  // 0x10
  private           System.Boolean                  _isActive  // 0x14
  private           System.Xml.Schema.Asttree       _axisTree  // 0x18
  private           System.Collections.ArrayList    _axisStack  // 0x20
METHODS:
  System.Int32 get_CurrentDepth()
  System.Void Reactivate()
  System.Void .ctor(System.Xml.Schema.Asttree axisTree)
  System.Boolean MoveToStartElement(System.String localname, System.String URN)
  System.Boolean EndElement(System.String localname, System.String URN)
  System.Boolean MoveToAttribute(System.String localname, System.String URN)
END_CLASS

CLASS: System.Xml.Schema.DoubleLinkAxis
TYPE:  class
TOKEN: 0x2000160
EXTENDS: Axis
FIELDS:
  private           MS.Internal.Xml.XPath.Axis      next  // 0x40
METHODS:
  MS.Internal.Xml.XPath.Axis get_Next()
  System.Void set_Next(MS.Internal.Xml.XPath.Axis value)
  System.Void .ctor(MS.Internal.Xml.XPath.Axis axis, System.Xml.Schema.DoubleLinkAxis inputaxis)
  System.Xml.Schema.DoubleLinkAxis ConvertTree(MS.Internal.Xml.XPath.Axis axis)
END_CLASS

CLASS: System.Xml.Schema.ForwardAxis
TYPE:  class
TOKEN: 0x2000161
FIELDS:
  private           System.Xml.Schema.DoubleLinkAxis_topNode  // 0x10
  private           System.Xml.Schema.DoubleLinkAxis_rootNode  // 0x18
  private           System.Boolean                  _isAttribute  // 0x20
  private           System.Boolean                  _isDss  // 0x21
  private           System.Boolean                  _isSelfAxis  // 0x22
METHODS:
  System.Xml.Schema.DoubleLinkAxis get_RootNode()
  System.Xml.Schema.DoubleLinkAxis get_TopNode()
  System.Boolean get_IsAttribute()
  System.Boolean get_IsDss()
  System.Boolean get_IsSelfAxis()
  System.Void .ctor(System.Xml.Schema.DoubleLinkAxis axis, System.Boolean isdesorself)
END_CLASS

CLASS: System.Xml.Schema.Asttree
TYPE:  class
TOKEN: 0x2000162
FIELDS:
  private           System.Collections.ArrayList    _fAxisArray  // 0x10
  private           System.String                   _xpathexpr  // 0x18
  private           System.Boolean                  _isField  // 0x20
  private           System.Xml.XmlNamespaceManager  _nsmgr  // 0x28
METHODS:
  System.Collections.ArrayList get_SubtreeArray()
  System.Void .ctor(System.String xPath, System.Boolean isField, System.Xml.XmlNamespaceManager nsmgr)
  System.Boolean IsNameTest(MS.Internal.Xml.XPath.Axis ast)
  System.Boolean IsAttribute(MS.Internal.Xml.XPath.Axis ast)
  System.Boolean IsDescendantOrSelf(MS.Internal.Xml.XPath.Axis ast)
  System.Boolean IsSelf(MS.Internal.Xml.XPath.Axis ast)
  System.Void CompileXPath(System.String xPath, System.Boolean isField, System.Xml.XmlNamespaceManager nsmgr)
  System.Void SetURN(MS.Internal.Xml.XPath.Axis axis, System.Xml.XmlNamespaceManager nsmgr)
END_CLASS

CLASS: System.Xml.Schema.AutoValidator
TYPE:  class
TOKEN: 0x2000163
EXTENDS: BaseValidator
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling)
  System.Boolean get_PreserveWhitespace()
  System.Void Validate()
  System.Void CompleteValidation()
  System.Object FindId(System.String name)
  System.Xml.ValidationType DetectValidationType()
END_CLASS

CLASS: System.Xml.Schema.BaseProcessor
TYPE:  class
TOKEN: 0x2000164
FIELDS:
  private           System.Xml.XmlNameTable         nameTable  // 0x10
  private           System.Xml.Schema.SchemaNames   schemaNames  // 0x18
  private           System.Xml.Schema.ValidationEventHandlereventHandler  // 0x20
  private           System.Xml.Schema.XmlSchemaCompilationSettingscompilationSettings  // 0x28
  private           System.Int32                    errorCount  // 0x30
  private           System.String                   NsXml  // 0x38
METHODS:
  System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler)
  System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings)
  System.Xml.XmlNameTable get_NameTable()
  System.Xml.Schema.SchemaNames get_SchemaNames()
  System.Xml.Schema.ValidationEventHandler get_EventHandler()
  System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings()
  System.Boolean get_HasErrors()
  System.Void AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item)
  System.Boolean IsValidAttributeGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table)
  System.Boolean IsValidGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table)
  System.Boolean IsValidTypeRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table)
  System.Void SendValidationEvent(System.String code, System.Xml.Schema.XmlSchemaObject source)
  System.Void SendValidationEvent(System.String code, System.String msg, System.Xml.Schema.XmlSchemaObject source)
  System.Void SendValidationEvent(System.String code, System.String msg1, System.String msg2, System.Xml.Schema.XmlSchemaObject source)
  System.Void SendValidationEvent(System.String code, System.String[] args, System.Exception innerException, System.Xml.Schema.XmlSchemaObject source)
  System.Void SendValidationEvent(System.String code, System.String msg1, System.String msg2, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void SendValidationEvent(System.String code, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e)
  System.Void SendValidationEvent(System.String code, System.String msg, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity)
  System.Void SendValidationEventNoThrow(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity)
END_CLASS

CLASS: System.Xml.Schema.BaseValidator
TYPE:  class
TOKEN: 0x2000165
FIELDS:
  private           System.Xml.Schema.XmlSchemaCollectionschemaCollection  // 0x10
  private           System.Xml.IValidationEventHandlingeventHandling  // 0x18
  private           System.Xml.XmlNameTable         nameTable  // 0x20
  private           System.Xml.Schema.SchemaNames   schemaNames  // 0x28
  private           System.Xml.PositionInfo         positionInfo  // 0x30
  private           System.Xml.XmlResolver          xmlResolver  // 0x38
  private           System.Uri                      baseUri  // 0x40
  protected         System.Xml.Schema.SchemaInfo    schemaInfo  // 0x48
  protected         System.Xml.XmlValidatingReaderImplreader  // 0x50
  protected         System.Xml.XmlQualifiedName     elementName  // 0x58
  protected         System.Xml.Schema.ValidationStatecontext  // 0x60
  protected         System.Text.StringBuilder       textValue  // 0x68
  protected         System.String                   textString  // 0x70
  protected         System.Boolean                  hasSibling  // 0x78
  protected         System.Boolean                  checkDatatype  // 0x79
METHODS:
  System.Void .ctor(System.Xml.Schema.BaseValidator other)
  System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling)
  System.Xml.XmlValidatingReaderImpl get_Reader()
  System.Xml.Schema.XmlSchemaCollection get_SchemaCollection()
  System.Xml.XmlNameTable get_NameTable()
  System.Xml.Schema.SchemaNames get_SchemaNames()
  System.Xml.PositionInfo get_PositionInfo()
  System.Xml.XmlResolver get_XmlResolver()
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Uri get_BaseUri()
  System.Void set_BaseUri(System.Uri value)
  System.Xml.Schema.ValidationEventHandler get_EventHandler()
  System.Xml.Schema.SchemaInfo get_SchemaInfo()
  System.Void set_DtdInfo(System.Xml.IDtdInfo value)
  System.Boolean get_PreserveWhitespace()
  System.Void Validate()
  System.Void CompleteValidation()
  System.Object FindId(System.String name)
  System.Void ValidateText()
  System.Void ValidateWhitespace()
  System.Void SaveTextValue(System.String value)
  System.Void SendValidationEvent(System.String code)
  System.Void SendValidationEvent(System.String code, System.String[] args)
  System.Void SendValidationEvent(System.String code, System.String arg)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e)
  System.Void SendValidationEvent(System.String code, System.String msg, System.Xml.Schema.XmlSeverityType severity)
  System.Void SendValidationEvent(System.String code, System.String[] args, System.Xml.Schema.XmlSeverityType severity)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity)
  System.Void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, System.String name, System.Object sender, System.Xml.Schema.ValidationEventHandler eventhandler, System.String baseUri, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, System.String name, System.Xml.IValidationEventHandling eventHandling, System.String baseUriStr, System.Int32 lineNumber, System.Int32 linePosition)
  System.Xml.Schema.BaseValidator CreateInstance(System.Xml.ValidationType valType, System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling, System.Boolean processIdentityConstraints)
END_CLASS

CLASS: System.Xml.Schema.BitSet
TYPE:  class
TOKEN: 0x2000166
FIELDS:
  private           System.Int32                    count  // 0x10
  private           System.UInt32[]                 bits  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 count)
  System.Int32 get_Count()
  System.Boolean get_Item(System.Int32 index)
  System.Void Clear()
  System.Void Set(System.Int32 index)
  System.Boolean Get(System.Int32 index)
  System.Int32 NextSet(System.Int32 startFrom)
  System.Void And(System.Xml.Schema.BitSet other)
  System.Void Or(System.Xml.Schema.BitSet other)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Xml.Schema.BitSet Clone()
  System.Boolean get_IsEmpty()
  System.Boolean Intersects(System.Xml.Schema.BitSet other)
  System.Int32 Subscript(System.Int32 bitIndex)
  System.Void EnsureLength(System.Int32 nRequiredLength)
END_CLASS

CLASS: System.Xml.Schema.ChameleonKey
TYPE:  class
TOKEN: 0x2000167
FIELDS:
  private           System.String                   targetNS  // 0x10
  private           System.Uri                      chameleonLocation  // 0x18
  private           System.Xml.Schema.XmlSchema     originalSchema  // 0x20
  private           System.Int32                    hashCode  // 0x28
METHODS:
  System.Void .ctor(System.String ns, System.Xml.Schema.XmlSchema originalSchema)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: System.Xml.Schema.CompiledIdentityConstraint
TYPE:  class
TOKEN: 0x2000168
FIELDS:
  private           System.Xml.XmlQualifiedName     name  // 0x10
  private           System.Xml.Schema.CompiledIdentityConstraint.ConstraintRolerole  // 0x18
  private           System.Xml.Schema.Asttree       selector  // 0x20
  private           System.Xml.Schema.Asttree[]     fields  // 0x28
  private           System.Xml.XmlQualifiedName     refer  // 0x30
  public    static readonly System.Xml.Schema.CompiledIdentityConstraintEmpty  // 0x0
METHODS:
  System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole get_Role()
  System.Xml.Schema.Asttree get_Selector()
  System.Xml.Schema.Asttree[] get_Fields()
  System.Void .ctor()
  System.Void .ctor(System.Xml.Schema.XmlSchemaIdentityConstraint constraint, System.Xml.XmlNamespaceManager nsmgr)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.ConstraintStruct
TYPE:  class
TOKEN: 0x200016A
FIELDS:
  private           System.Xml.Schema.CompiledIdentityConstraintconstraint  // 0x10
  private           System.Xml.Schema.SelectorActiveAxisaxisSelector  // 0x18
  private           System.Collections.ArrayList    axisFields  // 0x20
  private           System.Collections.Hashtable    qualifiedTable  // 0x28
  private           System.Collections.Hashtable    keyrefTable  // 0x30
  private           System.Int32                    tableDim  // 0x38
METHODS:
  System.Int32 get_TableDim()
  System.Void .ctor(System.Xml.Schema.CompiledIdentityConstraint constraint)
END_CLASS

CLASS: System.Xml.Schema.LocatedActiveAxis
TYPE:  class
TOKEN: 0x200016B
EXTENDS: ActiveAxis
FIELDS:
  private           System.Int32                    column  // 0x28
  private           System.Boolean                  isMatched  // 0x2C
  private           System.Xml.Schema.KeySequence   Ks  // 0x30
METHODS:
  System.Int32 get_Column()
  System.Void .ctor(System.Xml.Schema.Asttree astfield, System.Xml.Schema.KeySequence ks, System.Int32 column)
  System.Void Reactivate(System.Xml.Schema.KeySequence ks)
END_CLASS

CLASS: System.Xml.Schema.SelectorActiveAxis
TYPE:  class
TOKEN: 0x200016C
EXTENDS: ActiveAxis
FIELDS:
  private           System.Xml.Schema.ConstraintStructcs  // 0x28
  private           System.Collections.ArrayList    KSs  // 0x30
  private           System.Int32                    KSpointer  // 0x38
METHODS:
  System.Int32 get_lastDepth()
  System.Void .ctor(System.Xml.Schema.Asttree axisTree, System.Xml.Schema.ConstraintStruct cs)
  System.Boolean EndElement(System.String localname, System.String URN)
  System.Int32 PushKS(System.Int32 errline, System.Int32 errcol)
  System.Xml.Schema.KeySequence PopKS()
END_CLASS

CLASS: System.Xml.Schema.KSStruct
TYPE:  class
TOKEN: 0x200016D
FIELDS:
  public            System.Int32                    depth  // 0x10
  public            System.Xml.Schema.KeySequence   ks  // 0x18
  public            System.Xml.Schema.LocatedActiveAxis[]fields  // 0x20
METHODS:
  System.Void .ctor(System.Xml.Schema.KeySequence ks, System.Int32 dim)
END_CLASS

CLASS: System.Xml.Schema.TypedObject
TYPE:  class
TOKEN: 0x200016E
FIELDS:
  private           System.Xml.Schema.TypedObject.DecimalStructdstruct  // 0x10
  private           System.Object                   ovalue  // 0x18
  private           System.String                   svalue  // 0x20
  private           System.Xml.Schema.XmlSchemaDatatypexsdtype  // 0x28
  private           System.Int32                    dim  // 0x30
  private           System.Boolean                  isList  // 0x34
METHODS:
  System.Int32 get_Dim()
  System.Boolean get_IsList()
  System.Boolean get_IsDecimal()
  System.Decimal[] get_Dvalue()
  System.Object get_Value()
  System.Xml.Schema.XmlSchemaDatatype get_Type()
  System.Void .ctor(System.Object obj, System.String svalue, System.Xml.Schema.XmlSchemaDatatype xsdtype)
  System.String ToString()
  System.Void SetDecimal()
  System.Boolean ListDValueEquals(System.Xml.Schema.TypedObject other)
  System.Boolean Equals(System.Xml.Schema.TypedObject other)
END_CLASS

CLASS: System.Xml.Schema.KeySequence
TYPE:  class
TOKEN: 0x2000170
FIELDS:
  private           System.Xml.Schema.TypedObject[] ks  // 0x10
  private           System.Int32                    dim  // 0x18
  private           System.Int32                    hashcode  // 0x1C
  private           System.Int32                    posline  // 0x20
  private           System.Int32                    poscol  // 0x24
METHODS:
  System.Void .ctor(System.Int32 dim, System.Int32 line, System.Int32 col)
  System.Int32 get_PosLine()
  System.Int32 get_PosCol()
  System.Object get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Object value)
  System.Boolean IsQualified()
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.String ToString()
END_CLASS

CLASS: System.Xml.Schema.UpaException
TYPE:  class
TOKEN: 0x2000171
EXTENDS: Exception
FIELDS:
  private           System.Object                   particle1  // 0x90
  private           System.Object                   particle2  // 0x98
METHODS:
  System.Void .ctor(System.Object particle1, System.Object particle2)
  System.Object get_Particle1()
  System.Object get_Particle2()
END_CLASS

CLASS: System.Xml.Schema.SymbolsDictionary
TYPE:  class
TOKEN: 0x2000172
FIELDS:
  private           System.Int32                    last  // 0x10
  private           System.Collections.Hashtable    names  // 0x18
  private           System.Collections.Hashtable    wildcards  // 0x20
  private           System.Collections.ArrayList    particles  // 0x28
  private           System.Object                   particleLast  // 0x30
  private           System.Boolean                  isUpaEnforced  // 0x38
METHODS:
  System.Void .ctor()
  System.Int32 get_Count()
  System.Boolean get_IsUpaEnforced()
  System.Void set_IsUpaEnforced(System.Boolean value)
  System.Int32 AddName(System.Xml.XmlQualifiedName name, System.Object particle)
  System.Void AddNamespaceList(System.Xml.Schema.NamespaceList list, System.Object particle, System.Boolean allowLocal)
  System.Void AddWildcard(System.String wildcard, System.Object particle)
  System.Collections.ICollection GetNamespaceListSymbols(System.Xml.Schema.NamespaceList list)
  System.Int32 get_Item(System.Xml.XmlQualifiedName name)
  System.Boolean Exists(System.Xml.XmlQualifiedName name)
  System.Object GetParticle(System.Int32 symbol)
  System.String NameOf(System.Int32 symbol)
END_CLASS

CLASS: System.Xml.Schema.Position
TYPE:  struct
TOKEN: 0x2000173
FIELDS:
  public            System.Int32                    symbol  // 0x10
  public            System.Object                   particle  // 0x18
METHODS:
  System.Void .ctor(System.Int32 symbol, System.Object particle)
END_CLASS

CLASS: System.Xml.Schema.Positions
TYPE:  class
TOKEN: 0x2000174
FIELDS:
  private           System.Collections.ArrayList    positions  // 0x10
METHODS:
  System.Int32 Add(System.Int32 symbol, System.Object particle)
  System.Xml.Schema.Position get_Item(System.Int32 pos)
  System.Int32 get_Count()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.SyntaxTreeNode
TYPE:  class
TOKEN: 0x2000175
FIELDS:
METHODS:
  System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions)
  System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos)
  System.Boolean get_IsNullable()
  System.Boolean get_IsRangeNode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.LeafNode
TYPE:  class
TOKEN: 0x2000176
EXTENDS: SyntaxTreeNode
FIELDS:
  private           System.Int32                    pos  // 0x10
METHODS:
  System.Void .ctor(System.Int32 pos)
  System.Int32 get_Pos()
  System.Void set_Pos(System.Int32 value)
  System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions)
  System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos)
  System.Boolean get_IsNullable()
END_CLASS

CLASS: System.Xml.Schema.NamespaceListNode
TYPE:  class
TOKEN: 0x2000177
EXTENDS: SyntaxTreeNode
FIELDS:
  protected         System.Xml.Schema.NamespaceList namespaceList  // 0x10
  protected         System.Object                   particle  // 0x18
METHODS:
  System.Void .ctor(System.Xml.Schema.NamespaceList namespaceList, System.Object particle)
  System.Collections.ICollection GetResolvedSymbols(System.Xml.Schema.SymbolsDictionary symbols)
  System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions)
  System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos)
  System.Boolean get_IsNullable()
END_CLASS

CLASS: System.Xml.Schema.InteriorNode
TYPE:  class
TOKEN: 0x2000178
EXTENDS: SyntaxTreeNode
FIELDS:
  private           System.Xml.Schema.SyntaxTreeNodeleftChild  // 0x10
  private           System.Xml.Schema.SyntaxTreeNoderightChild  // 0x18
METHODS:
  System.Xml.Schema.SyntaxTreeNode get_LeftChild()
  System.Void set_LeftChild(System.Xml.Schema.SyntaxTreeNode value)
  System.Xml.Schema.SyntaxTreeNode get_RightChild()
  System.Void set_RightChild(System.Xml.Schema.SyntaxTreeNode value)
  System.Void ExpandTreeNoRecursive(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions)
  System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.SequenceNode
TYPE:  class
TOKEN: 0x2000179
EXTENDS: InteriorNode
FIELDS:
METHODS:
  System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos)
  System.Boolean get_IsNullable()
  System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.ChoiceNode
TYPE:  class
TOKEN: 0x200017B
EXTENDS: InteriorNode
FIELDS:
METHODS:
  System.Void ConstructChildPos(System.Xml.Schema.SyntaxTreeNode child, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos)
  System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos)
  System.Boolean get_IsNullable()
  System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.PlusNode
TYPE:  class
TOKEN: 0x200017C
EXTENDS: InteriorNode
FIELDS:
METHODS:
  System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos)
  System.Boolean get_IsNullable()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.QmarkNode
TYPE:  class
TOKEN: 0x200017D
EXTENDS: InteriorNode
FIELDS:
METHODS:
  System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos)
  System.Boolean get_IsNullable()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.StarNode
TYPE:  class
TOKEN: 0x200017E
EXTENDS: InteriorNode
FIELDS:
METHODS:
  System.Void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos)
  System.Boolean get_IsNullable()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.LeafRangeNode
TYPE:  class
TOKEN: 0x200017F
EXTENDS: LeafNode
FIELDS:
  private           System.Decimal                  min  // 0x18
  private           System.Decimal                  max  // 0x28
  private           System.Xml.Schema.BitSet        nextIteration  // 0x38
METHODS:
  System.Void .ctor(System.Decimal min, System.Decimal max)
  System.Void .ctor(System.Int32 pos, System.Decimal min, System.Decimal max)
  System.Decimal get_Max()
  System.Decimal get_Min()
  System.Xml.Schema.BitSet get_NextIteration()
  System.Void set_NextIteration(System.Xml.Schema.BitSet value)
  System.Boolean get_IsRangeNode()
  System.Void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions)
END_CLASS

CLASS: System.Xml.Schema.ContentValidator
TYPE:  class
TOKEN: 0x2000180
FIELDS:
  private           System.Xml.Schema.XmlSchemaContentTypecontentType  // 0x10
  private           System.Boolean                  isOpen  // 0x14
  private           System.Boolean                  isEmptiable  // 0x15
  public    static readonly System.Xml.Schema.ContentValidatorEmpty  // 0x0
  public    static readonly System.Xml.Schema.ContentValidatorTextOnly  // 0x8
  public    static readonly System.Xml.Schema.ContentValidatorMixed  // 0x10
  public    static readonly System.Xml.Schema.ContentValidatorAny  // 0x18
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaContentType contentType)
  System.Void .ctor(System.Xml.Schema.XmlSchemaContentType contentType, System.Boolean isOpen, System.Boolean isEmptiable)
  System.Xml.Schema.XmlSchemaContentType get_ContentType()
  System.Boolean get_PreserveWhitespace()
  System.Boolean get_IsEmptiable()
  System.Boolean get_IsOpen()
  System.Void set_IsOpen(System.Boolean value)
  System.Void InitValidation(System.Xml.Schema.ValidationState context)
  System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode)
  System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context)
  System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly)
  System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles)
  System.Void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles, System.Boolean global)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.ParticleContentValidator
TYPE:  class
TOKEN: 0x2000181
EXTENDS: ContentValidator
FIELDS:
  private           System.Xml.Schema.SymbolsDictionarysymbols  // 0x18
  private           System.Xml.Schema.Positions     positions  // 0x20
  private           System.Collections.Stack        stack  // 0x28
  private           System.Xml.Schema.SyntaxTreeNodecontentNode  // 0x30
  private           System.Boolean                  isPartial  // 0x38
  private           System.Int32                    minMaxNodesCount  // 0x3C
  private           System.Boolean                  enableUpaCheck  // 0x40
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaContentType contentType)
  System.Void .ctor(System.Xml.Schema.XmlSchemaContentType contentType, System.Boolean enableUpaCheck)
  System.Void InitValidation(System.Xml.Schema.ValidationState context)
  System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode)
  System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context)
  System.Void Start()
  System.Void OpenGroup()
  System.Void CloseGroup()
  System.Boolean Exists(System.Xml.XmlQualifiedName name)
  System.Void AddName(System.Xml.XmlQualifiedName name, System.Object particle)
  System.Void AddNamespaceList(System.Xml.Schema.NamespaceList namespaceList, System.Object particle)
  System.Void AddLeafNode(System.Xml.Schema.SyntaxTreeNode node)
  System.Void AddChoice()
  System.Void AddSequence()
  System.Void AddStar()
  System.Void AddPlus()
  System.Void AddQMark()
  System.Void AddLeafRange(System.Decimal min, System.Decimal max)
  System.Void Closure(System.Xml.Schema.InteriorNode node)
  System.Xml.Schema.ContentValidator Finish(System.Boolean useDFA)
  System.Xml.Schema.BitSet[] CalculateTotalFollowposForRangeNodes(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.BitSet& posWithRangeTerminals)
  System.Void CheckCMUPAWithLeafRangeNodes(System.Xml.Schema.BitSet curpos)
  System.Xml.Schema.BitSet GetApplicableMinMaxFollowPos(System.Xml.Schema.BitSet curpos, System.Xml.Schema.BitSet posWithRangeTerminals, System.Xml.Schema.BitSet[] minmaxFollowPos)
  System.Void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos)
  System.Void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet curpos)
  System.Int32[][] BuildTransitionTable(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Int32 endMarkerPos)
END_CLASS

CLASS: System.Xml.Schema.DfaContentValidator
TYPE:  class
TOKEN: 0x2000182
EXTENDS: ContentValidator
FIELDS:
  private           System.Int32[][]                transitionTable  // 0x18
  private           System.Xml.Schema.SymbolsDictionarysymbols  // 0x20
METHODS:
  System.Void .ctor(System.Int32[][] transitionTable, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.XmlSchemaContentType contentType, System.Boolean isOpen, System.Boolean isEmptiable)
  System.Void InitValidation(System.Xml.Schema.ValidationState context)
  System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode)
  System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context)
  System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly)
  System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet)
END_CLASS

CLASS: System.Xml.Schema.NfaContentValidator
TYPE:  class
TOKEN: 0x2000183
EXTENDS: ContentValidator
FIELDS:
  private           System.Xml.Schema.BitSet        firstpos  // 0x18
  private           System.Xml.Schema.BitSet[]      followpos  // 0x20
  private           System.Xml.Schema.SymbolsDictionarysymbols  // 0x28
  private           System.Xml.Schema.Positions     positions  // 0x30
  private           System.Int32                    endMarkerPos  // 0x38
METHODS:
  System.Void .ctor(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, System.Int32 endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, System.Boolean isOpen, System.Boolean isEmptiable)
  System.Void InitValidation(System.Xml.Schema.ValidationState context)
  System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode)
  System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context)
  System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly)
  System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet)
END_CLASS

CLASS: System.Xml.Schema.RangePositionInfo
TYPE:  struct
TOKEN: 0x2000184
FIELDS:
  public            System.Xml.Schema.BitSet        curpos  // 0x10
  public            System.Decimal[]                rangeCounters  // 0x18
METHODS:
END_CLASS

CLASS: System.Xml.Schema.RangeContentValidator
TYPE:  class
TOKEN: 0x2000185
EXTENDS: ContentValidator
FIELDS:
  private           System.Xml.Schema.BitSet        firstpos  // 0x18
  private           System.Xml.Schema.BitSet[]      followpos  // 0x20
  private           System.Xml.Schema.BitSet        positionsWithRangeTerminals  // 0x28
  private           System.Xml.Schema.SymbolsDictionarysymbols  // 0x30
  private           System.Xml.Schema.Positions     positions  // 0x38
  private           System.Int32                    minMaxNodesCount  // 0x40
  private           System.Int32                    endMarkerPos  // 0x44
METHODS:
  System.Void .ctor(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, System.Int32 endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, System.Boolean isEmptiable, System.Xml.Schema.BitSet positionsWithRangeTerminals, System.Int32 minmaxNodesCount)
  System.Void InitValidation(System.Xml.Schema.ValidationState context)
  System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode)
  System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context)
  System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly)
  System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet)
END_CLASS

CLASS: System.Xml.Schema.AllElementsContentValidator
TYPE:  class
TOKEN: 0x2000186
EXTENDS: ContentValidator
FIELDS:
  private           System.Collections.Hashtable    elements  // 0x18
  private           System.Object[]                 particles  // 0x20
  private           System.Xml.Schema.BitSet        isRequired  // 0x28
  private           System.Int32                    countRequired  // 0x30
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaContentType contentType, System.Int32 size, System.Boolean isEmptiable)
  System.Boolean AddElement(System.Xml.XmlQualifiedName name, System.Object particle, System.Boolean isEmptiable)
  System.Boolean get_IsEmptiable()
  System.Void InitValidation(System.Xml.Schema.ValidationState context)
  System.Object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Int32& errorCode)
  System.Boolean CompleteValidation(System.Xml.Schema.ValidationState context)
  System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly)
  System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, System.Boolean isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet)
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaDatatypeVariety
TYPE:  struct
TOKEN: 0x2000187
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaDatatypeVarietyAtomic  // 0x0
  public    static  System.Xml.Schema.XmlSchemaDatatypeVarietyList  // 0x0
  public    static  System.Xml.Schema.XmlSchemaDatatypeVarietyUnion  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XsdSimpleValue
TYPE:  class
TOKEN: 0x2000188
FIELDS:
  private           System.Xml.Schema.XmlSchemaSimpleTypexmlType  // 0x10
  private           System.Object                   typedValue  // 0x18
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaSimpleType st, System.Object value)
  System.Xml.Schema.XmlSchemaSimpleType get_XmlType()
  System.Object get_TypedValue()
END_CLASS

CLASS: System.Xml.Schema.RestrictionFlags
TYPE:  struct
TOKEN: 0x2000189
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.RestrictionFlagsLength  // 0x0
  public    static  System.Xml.Schema.RestrictionFlagsMinLength  // 0x0
  public    static  System.Xml.Schema.RestrictionFlagsMaxLength  // 0x0
  public    static  System.Xml.Schema.RestrictionFlagsPattern  // 0x0
  public    static  System.Xml.Schema.RestrictionFlagsEnumeration  // 0x0
  public    static  System.Xml.Schema.RestrictionFlagsWhiteSpace  // 0x0
  public    static  System.Xml.Schema.RestrictionFlagsMaxInclusive  // 0x0
  public    static  System.Xml.Schema.RestrictionFlagsMaxExclusive  // 0x0
  public    static  System.Xml.Schema.RestrictionFlagsMinInclusive  // 0x0
  public    static  System.Xml.Schema.RestrictionFlagsMinExclusive  // 0x0
  public    static  System.Xml.Schema.RestrictionFlagsTotalDigits  // 0x0
  public    static  System.Xml.Schema.RestrictionFlagsFractionDigits  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaWhiteSpace
TYPE:  struct
TOKEN: 0x200018A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaWhiteSpacePreserve  // 0x0
  public    static  System.Xml.Schema.XmlSchemaWhiteSpaceReplace  // 0x0
  public    static  System.Xml.Schema.XmlSchemaWhiteSpaceCollapse  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.RestrictionFacets
TYPE:  class
TOKEN: 0x200018B
FIELDS:
  private           System.Int32                    Length  // 0x10
  private           System.Int32                    MinLength  // 0x14
  private           System.Int32                    MaxLength  // 0x18
  private           System.Collections.ArrayList    Patterns  // 0x20
  private           System.Collections.ArrayList    Enumeration  // 0x28
  private           System.Xml.Schema.XmlSchemaWhiteSpaceWhiteSpace  // 0x30
  private           System.Object                   MaxInclusive  // 0x38
  private           System.Object                   MaxExclusive  // 0x40
  private           System.Object                   MinInclusive  // 0x48
  private           System.Object                   MinExclusive  // 0x50
  private           System.Int32                    TotalDigits  // 0x58
  private           System.Int32                    FractionDigits  // 0x5C
  private           System.Xml.Schema.RestrictionFlagsFlags  // 0x60
  private           System.Xml.Schema.RestrictionFlagsFixedFlags  // 0x64
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.DatatypeImplementation
TYPE:  class
TOKEN: 0x200018C
EXTENDS: XmlSchemaDatatype
FIELDS:
  private           System.Xml.Schema.XmlSchemaDatatypeVarietyvariety  // 0x10
  private           System.Xml.Schema.RestrictionFacetsrestriction  // 0x18
  private           System.Xml.Schema.DatatypeImplementationbaseType  // 0x20
  private           System.Xml.Schema.XmlValueConvertervalueConverter  // 0x28
  private           System.Xml.Schema.XmlSchemaType parentSchemaType  // 0x30
  private   static  System.Collections.Hashtable    builtinTypes  // 0x0
  private   static  System.Xml.Schema.XmlSchemaSimpleType[]enumToTypeCode  // 0x8
  private   static  System.Xml.Schema.XmlSchemaSimpleTypeanySimpleType  // 0x10
  private   static  System.Xml.Schema.XmlSchemaSimpleTypeanyAtomicType  // 0x18
  private   static  System.Xml.Schema.XmlSchemaSimpleTypeuntypedAtomicType  // 0x20
  private   static  System.Xml.Schema.XmlSchemaSimpleTypeyearMonthDurationType  // 0x28
  private   static  System.Xml.Schema.XmlSchemaSimpleTypedayTimeDurationType  // 0x30
  private   static  System.Xml.Schema.XmlSchemaSimpleTypenormalizedStringTypeV1Compat  // 0x38
  private   static  System.Xml.Schema.XmlSchemaSimpleTypetokenTypeV1Compat  // 0x40
  private   static  System.Xml.XmlQualifiedName     QnAnySimpleType  // 0x48
  private   static  System.Xml.XmlQualifiedName     QnAnyType  // 0x50
  private   static  System.Xml.Schema.FacetsChecker stringFacetsChecker  // 0x58
  private   static  System.Xml.Schema.FacetsChecker miscFacetsChecker  // 0x60
  private   static  System.Xml.Schema.FacetsChecker numeric2FacetsChecker  // 0x68
  private   static  System.Xml.Schema.FacetsChecker binaryFacetsChecker  // 0x70
  private   static  System.Xml.Schema.FacetsChecker dateTimeFacetsChecker  // 0x78
  private   static  System.Xml.Schema.FacetsChecker durationFacetsChecker  // 0x80
  private   static  System.Xml.Schema.FacetsChecker listFacetsChecker  // 0x88
  private   static  System.Xml.Schema.FacetsChecker qnameFacetsChecker  // 0x90
  private   static  System.Xml.Schema.FacetsChecker unionFacetsChecker  // 0x98
  private   static readonly System.Xml.Schema.DatatypeImplementationc_anySimpleType  // 0xA0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_anyURI  // 0xA8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_base64Binary  // 0xB0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_boolean  // 0xB8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_byte  // 0xC0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_char  // 0xC8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_date  // 0xD0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_dateTime  // 0xD8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_dateTimeNoTz  // 0xE0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_dateTimeTz  // 0xE8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_day  // 0xF0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_decimal  // 0xF8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_double  // 0x100
  private   static readonly System.Xml.Schema.DatatypeImplementationc_doubleXdr  // 0x108
  private   static readonly System.Xml.Schema.DatatypeImplementationc_duration  // 0x110
  private   static readonly System.Xml.Schema.DatatypeImplementationc_ENTITY  // 0x118
  private   static readonly System.Xml.Schema.DatatypeImplementationc_ENTITIES  // 0x120
  private   static readonly System.Xml.Schema.DatatypeImplementationc_ENUMERATION  // 0x128
  private   static readonly System.Xml.Schema.DatatypeImplementationc_fixed  // 0x130
  private   static readonly System.Xml.Schema.DatatypeImplementationc_float  // 0x138
  private   static readonly System.Xml.Schema.DatatypeImplementationc_floatXdr  // 0x140
  private   static readonly System.Xml.Schema.DatatypeImplementationc_hexBinary  // 0x148
  private   static readonly System.Xml.Schema.DatatypeImplementationc_ID  // 0x150
  private   static readonly System.Xml.Schema.DatatypeImplementationc_IDREF  // 0x158
  private   static readonly System.Xml.Schema.DatatypeImplementationc_IDREFS  // 0x160
  private   static readonly System.Xml.Schema.DatatypeImplementationc_int  // 0x168
  private   static readonly System.Xml.Schema.DatatypeImplementationc_integer  // 0x170
  private   static readonly System.Xml.Schema.DatatypeImplementationc_language  // 0x178
  private   static readonly System.Xml.Schema.DatatypeImplementationc_long  // 0x180
  private   static readonly System.Xml.Schema.DatatypeImplementationc_month  // 0x188
  private   static readonly System.Xml.Schema.DatatypeImplementationc_monthDay  // 0x190
  private   static readonly System.Xml.Schema.DatatypeImplementationc_Name  // 0x198
  private   static readonly System.Xml.Schema.DatatypeImplementationc_NCName  // 0x1A0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_negativeInteger  // 0x1A8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_NMTOKEN  // 0x1B0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_NMTOKENS  // 0x1B8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_nonNegativeInteger  // 0x1C0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_nonPositiveInteger  // 0x1C8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_normalizedString  // 0x1D0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_NOTATION  // 0x1D8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_positiveInteger  // 0x1E0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_QName  // 0x1E8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_QNameXdr  // 0x1F0
  private   static readonly System.Xml.Schema.DatatypeImplementationc_short  // 0x1F8
  private   static readonly System.Xml.Schema.DatatypeImplementationc_string  // 0x200
  private   static readonly System.Xml.Schema.DatatypeImplementationc_time  // 0x208
  private   static readonly System.Xml.Schema.DatatypeImplementationc_timeNoTz  // 0x210
  private   static readonly System.Xml.Schema.DatatypeImplementationc_timeTz  // 0x218
  private   static readonly System.Xml.Schema.DatatypeImplementationc_token  // 0x220
  private   static readonly System.Xml.Schema.DatatypeImplementationc_unsignedByte  // 0x228
  private   static readonly System.Xml.Schema.DatatypeImplementationc_unsignedInt  // 0x230
  private   static readonly System.Xml.Schema.DatatypeImplementationc_unsignedLong  // 0x238
  private   static readonly System.Xml.Schema.DatatypeImplementationc_unsignedShort  // 0x240
  private   static readonly System.Xml.Schema.DatatypeImplementationc_uuid  // 0x248
  private   static readonly System.Xml.Schema.DatatypeImplementationc_year  // 0x250
  private   static readonly System.Xml.Schema.DatatypeImplementationc_yearMonth  // 0x258
  private   static readonly System.Xml.Schema.DatatypeImplementationc_normalizedStringV1Compat  // 0x260
  private   static readonly System.Xml.Schema.DatatypeImplementationc_tokenV1Compat  // 0x268
  private   static readonly System.Xml.Schema.DatatypeImplementationc_anyAtomicType  // 0x270
  private   static readonly System.Xml.Schema.DatatypeImplementationc_dayTimeDuration  // 0x278
  private   static readonly System.Xml.Schema.DatatypeImplementationc_untypedAtomicType  // 0x280
  private   static readonly System.Xml.Schema.DatatypeImplementationc_yearMonthDuration  // 0x288
  private   static readonly System.Xml.Schema.DatatypeImplementation[]c_tokenizedTypes  // 0x290
  private   static readonly System.Xml.Schema.DatatypeImplementation[]c_tokenizedTypesXsd  // 0x298
  private   static readonly System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap[]c_XdrTypes  // 0x2A0
  private   static readonly System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap[]c_XsdTypes  // 0x2A8
METHODS:
  System.Void .cctor()
  System.Xml.Schema.XmlSchemaSimpleType get_AnySimpleType()
  System.Xml.Schema.XmlSchemaSimpleType get_UntypedAtomicType()
  System.Xml.Schema.DatatypeImplementation FromXmlTokenizedType(System.Xml.XmlTokenizedType token)
  System.Xml.Schema.DatatypeImplementation FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token)
  System.Xml.Schema.DatatypeImplementation FromXdrName(System.String name)
  System.Xml.Schema.DatatypeImplementation FromTypeName(System.String name)
  System.Xml.Schema.XmlSchemaSimpleType StartBuiltinType(System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaDatatype dataType)
  System.Void FinishBuiltinType(System.Xml.Schema.XmlSchemaSimpleType derivedType, System.Xml.Schema.XmlSchemaSimpleType baseType)
  System.Void CreateBuiltinTypes()
  System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromTypeCode(System.Xml.Schema.XmlTypeCode typeCode)
  System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromXsdType(System.Xml.XmlQualifiedName qname)
  System.Xml.Schema.XmlSchemaSimpleType GetNormalizedStringTypeV1Compat()
  System.Xml.Schema.XmlSchemaSimpleType GetTokenTypeV1Compat()
  System.Xml.Schema.XmlSchemaSimpleType[] GetBuiltInTypes()
  System.Xml.Schema.XmlTypeCode GetPrimitiveTypeCode(System.Xml.Schema.XmlTypeCode typeCode)
  System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Int32 minSize, System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.DatatypeImplementation DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType)
  System.Void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller)
  System.Boolean IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean IsEqual(System.Object o1, System.Object o2)
  System.Boolean IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype)
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlValueConverter get_ValueConverter()
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Type get_ValueType()
  System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.Schema.RestrictionFacets get_Restriction()
  System.Boolean get_HasLexicalFacets()
  System.Boolean get_HasValueFacets()
  System.Xml.Schema.DatatypeImplementation get_Base()
  System.Type get_ListValueType()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr)
  System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Boolean createAtomicValue)
  System.Exception TryParseValue(System.Object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Object& typedValue)
  System.String GetTypeName()
  System.Int32 Compare(System.Byte[] value1, System.Byte[] value2)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_List
TYPE:  class
TOKEN: 0x200018E
EXTENDS: Datatype_anySimpleType
FIELDS:
  private           System.Xml.Schema.DatatypeImplementationitemType  // 0x38
  private           System.Int32                    minListSize  // 0x40
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Void .ctor(System.Xml.Schema.DatatypeImplementation type, System.Int32 minListSize)
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Type get_ValueType()
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Type get_ListValueType()
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Xml.Schema.DatatypeImplementation get_ItemType()
  System.Exception TryParseValue(System.Object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Object& typedValue)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
END_CLASS

CLASS: System.Xml.Schema.Datatype_union
TYPE:  class
TOKEN: 0x200018F
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
  private           System.Xml.Schema.XmlSchemaSimpleType[]types  // 0x38
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Void .ctor(System.Xml.Schema.XmlSchemaSimpleType[] types)
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Type get_ValueType()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Type get_ListValueType()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes()
  System.Boolean HasAtomicMembers()
  System.Boolean IsUnionBaseOf(System.Xml.Schema.DatatypeImplementation derivedType)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Exception TryParseValue(System.Object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_anySimpleType
TYPE:  class
TOKEN: 0x2000190
EXTENDS: DatatypeImplementation
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Type get_ValueType()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Type get_ListValueType()
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_anyAtomicType
TYPE:  class
TOKEN: 0x2000191
EXTENDS: Datatype_anySimpleType
FIELDS:
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_untypedAtomicType
TYPE:  class
TOKEN: 0x2000192
EXTENDS: Datatype_anyAtomicType
FIELDS:
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_string
TYPE:  class
TOKEN: 0x2000193
EXTENDS: Datatype_anySimpleType
FIELDS:
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_boolean
TYPE:  class
TOKEN: 0x2000194
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_float
TYPE:  class
TOKEN: 0x2000195
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_double
TYPE:  class
TOKEN: 0x2000196
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_decimal
TYPE:  class
TOKEN: 0x2000197
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x10
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_duration
TYPE:  class
TOKEN: 0x2000198
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_yearMonthDuration
TYPE:  class
TOKEN: 0x2000199
EXTENDS: Datatype_duration
FIELDS:
METHODS:
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_dayTimeDuration
TYPE:  class
TOKEN: 0x200019A
EXTENDS: Datatype_duration
FIELDS:
METHODS:
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_dateTimeBase
TYPE:  class
TOKEN: 0x200019B
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
  private           System.Xml.Schema.XsdDateTimeFlagsdateTimeFlags  // 0x38
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor(System.Xml.Schema.XsdDateTimeFlags dateTimeFlags)
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_dateTimeNoTimeZone
TYPE:  class
TOKEN: 0x200019C
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_dateTimeTimeZone
TYPE:  class
TOKEN: 0x200019D
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_dateTime
TYPE:  class
TOKEN: 0x200019E
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_timeNoTimeZone
TYPE:  class
TOKEN: 0x200019F
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_timeTimeZone
TYPE:  class
TOKEN: 0x20001A0
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_time
TYPE:  class
TOKEN: 0x20001A1
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_date
TYPE:  class
TOKEN: 0x20001A2
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_yearMonth
TYPE:  class
TOKEN: 0x20001A3
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_year
TYPE:  class
TOKEN: 0x20001A4
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_monthDay
TYPE:  class
TOKEN: 0x20001A5
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_day
TYPE:  class
TOKEN: 0x20001A6
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_month
TYPE:  class
TOKEN: 0x20001A7
EXTENDS: Datatype_dateTimeBase
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_hexBinary
TYPE:  class
TOKEN: 0x20001A8
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_base64Binary
TYPE:  class
TOKEN: 0x20001A9
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_anyURI
TYPE:  class
TOKEN: 0x20001AA
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Type get_ValueType()
  System.Boolean get_HasValueFacets()
  System.Type get_ListValueType()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_QName
TYPE:  class
TOKEN: 0x20001AB
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_normalizedString
TYPE:  class
TOKEN: 0x20001AC
EXTENDS: Datatype_string
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Boolean get_HasValueFacets()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_normalizedStringV1Compat
TYPE:  class
TOKEN: 0x20001AD
EXTENDS: Datatype_string
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Boolean get_HasValueFacets()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_token
TYPE:  class
TOKEN: 0x20001AE
EXTENDS: Datatype_normalizedString
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_tokenV1Compat
TYPE:  class
TOKEN: 0x20001AF
EXTENDS: Datatype_normalizedStringV1Compat
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_language
TYPE:  class
TOKEN: 0x20001B0
EXTENDS: Datatype_token
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_NMTOKEN
TYPE:  class
TOKEN: 0x20001B1
EXTENDS: Datatype_token
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_Name
TYPE:  class
TOKEN: 0x20001B2
EXTENDS: Datatype_token
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_NCName
TYPE:  class
TOKEN: 0x20001B3
EXTENDS: Datatype_Name
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_ID
TYPE:  class
TOKEN: 0x20001B4
EXTENDS: Datatype_NCName
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_IDREF
TYPE:  class
TOKEN: 0x20001B5
EXTENDS: Datatype_NCName
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_ENTITY
TYPE:  class
TOKEN: 0x20001B6
EXTENDS: Datatype_NCName
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_NOTATION
TYPE:  class
TOKEN: 0x20001B7
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_integer
TYPE:  class
TOKEN: 0x20001B8
EXTENDS: Datatype_decimal
FIELDS:
METHODS:
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_nonPositiveInteger
TYPE:  class
TOKEN: 0x20001B9
EXTENDS: Datatype_integer
FIELDS:
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x0
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Boolean get_HasValueFacets()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_negativeInteger
TYPE:  class
TOKEN: 0x20001BA
EXTENDS: Datatype_nonPositiveInteger
FIELDS:
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x0
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_long
TYPE:  class
TOKEN: 0x20001BB
EXTENDS: Datatype_integer
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x10
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Boolean get_HasValueFacets()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_int
TYPE:  class
TOKEN: 0x20001BC
EXTENDS: Datatype_long
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x10
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_short
TYPE:  class
TOKEN: 0x20001BD
EXTENDS: Datatype_int
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x10
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_byte
TYPE:  class
TOKEN: 0x20001BE
EXTENDS: Datatype_short
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x10
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_nonNegativeInteger
TYPE:  class
TOKEN: 0x20001BF
EXTENDS: Datatype_integer
FIELDS:
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x0
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Boolean get_HasValueFacets()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_unsignedLong
TYPE:  class
TOKEN: 0x20001C0
EXTENDS: Datatype_nonNegativeInteger
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x10
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_unsignedInt
TYPE:  class
TOKEN: 0x20001C1
EXTENDS: Datatype_unsignedLong
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x10
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_unsignedShort
TYPE:  class
TOKEN: 0x20001C2
EXTENDS: Datatype_unsignedInt
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x10
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_unsignedByte
TYPE:  class
TOKEN: 0x20001C3
EXTENDS: Datatype_unsignedShort
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x10
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_positiveInteger
TYPE:  class
TOKEN: 0x20001C4
EXTENDS: Datatype_nonNegativeInteger
FIELDS:
  private   static readonly System.Xml.Schema.FacetsChecker numeric10FacetsChecker  // 0x0
METHODS:
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_doubleXdr
TYPE:  class
TOKEN: 0x20001C5
EXTENDS: Datatype_double
FIELDS:
METHODS:
  System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_floatXdr
TYPE:  class
TOKEN: 0x20001C6
EXTENDS: Datatype_float
FIELDS:
METHODS:
  System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_QNameXdr
TYPE:  class
TOKEN: 0x20001C7
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr)
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_ENUMERATION
TYPE:  class
TOKEN: 0x20001C8
EXTENDS: Datatype_NMTOKEN
FIELDS:
METHODS:
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_char
TYPE:  class
TOKEN: 0x20001C9
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_fixed
TYPE:  class
TOKEN: 0x20001CA
EXTENDS: Datatype_decimal
FIELDS:
METHODS:
  System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Datatype_uuid
TYPE:  class
TOKEN: 0x20001CB
EXTENDS: Datatype_anySimpleType
FIELDS:
  private   static readonly System.Type                     atomicValueType  // 0x0
  private   static readonly System.Type                     listValueType  // 0x8
METHODS:
  System.Type get_ValueType()
  System.Type get_ListValueType()
  System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.DtdValidator
TYPE:  class
TOKEN: 0x20001CC
EXTENDS: BaseValidator
FIELDS:
  private   static  System.Xml.Schema.DtdValidator.NamespaceManagernamespaceManager  // 0x0
  private           System.Xml.HWStack              validationStack  // 0x80
  private           System.Collections.Hashtable    attPresence  // 0x88
  private           System.Xml.XmlQualifiedName     name  // 0x90
  private           System.Collections.Hashtable    IDs  // 0x98
  private           System.Xml.Schema.IdRefNode     idRefListHead  // 0xA0
  private           System.Boolean                  processIdentityConstraints  // 0xA8
METHODS:
  System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader, System.Xml.IValidationEventHandling eventHandling, System.Boolean processIdentityConstraints)
  System.Void Init()
  System.Void Validate()
  System.Boolean MeetsStandAloneConstraint()
  System.Void ValidatePIComment()
  System.Void ValidateElement()
  System.Void ValidateChildElement()
  System.Void ValidateStartElement()
  System.Void ValidateEndStartElement()
  System.Void ProcessElement()
  System.Void CompleteValidation()
  System.Void ValidateEndElement()
  System.Boolean get_PreserveWhitespace()
  System.Void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, System.String name)
  System.Void CheckValue(System.String value, System.Xml.Schema.SchemaAttDef attdef)
  System.Void AddID(System.String name, System.Object node)
  System.Object FindId(System.String name)
  System.Boolean GenEntity(System.Xml.XmlQualifiedName qname)
  System.Xml.Schema.SchemaEntity GetEntity(System.Xml.XmlQualifiedName qname, System.Boolean fParameterEntity)
  System.Void CheckForwardRefs()
  System.Void Push(System.Xml.XmlQualifiedName elementName)
  System.Boolean Pop()
  System.Void SetDefaultTypedValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.IDtdParserAdapter readerAdapter)
  System.Void CheckDefaultValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.IValidationEventHandling eventHandling, System.String baseUriStr)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.FacetsChecker
TYPE:  class
TOKEN: 0x20001CE
FIELDS:
METHODS:
  System.Exception CheckLexicalFacets(System.String& parseString, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Decimal value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Int64 value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Int32 value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Int16 value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Double value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Single value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.String value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Void CheckWhitespaceFacets(System.String& s, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckPatternFacets(System.Xml.Schema.RestrictionFacets restriction, System.String value)
  System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Xml.Schema.RestrictionFacets ConstructRestriction(System.Xml.Schema.DatatypeImplementation datatype, System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable)
  System.Decimal Power(System.Int32 x, System.Int32 y)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.Numeric10FacetsChecker
TYPE:  class
TOKEN: 0x20001D1
EXTENDS: FacetsChecker
FIELDS:
  private   static readonly System.Char[]                   signs  // 0x0
  private           System.Decimal                  maxValue  // 0x10
  private           System.Decimal                  minValue  // 0x20
METHODS:
  System.Void .ctor(System.Decimal minVal, System.Decimal maxVal)
  System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Decimal value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Int64 value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Int32 value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Int16 value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Decimal value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter)
  System.Exception CheckTotalAndFractionDigits(System.Decimal value, System.Int32 totalDigits, System.Int32 fractionDigits, System.Boolean checkTotal, System.Boolean checkFraction)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.Numeric2FacetsChecker
TYPE:  class
TOKEN: 0x20001D2
EXTENDS: FacetsChecker
FIELDS:
METHODS:
  System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Double value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Single value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Double value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.DurationFacetsChecker
TYPE:  class
TOKEN: 0x20001D3
EXTENDS: FacetsChecker
FIELDS:
METHODS:
  System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.TimeSpan value, System.Collections.ArrayList enumeration)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.DateTimeFacetsChecker
TYPE:  class
TOKEN: 0x20001D4
EXTENDS: FacetsChecker
FIELDS:
METHODS:
  System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.DateTime value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.StringFacetsChecker
TYPE:  class
TOKEN: 0x20001D5
EXTENDS: FacetsChecker
FIELDS:
  private   static  System.Text.RegularExpressions.RegexlanguagePattern  // 0x0
METHODS:
  System.Text.RegularExpressions.Regex get_LanguagePattern()
  System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.String value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.String value, System.Xml.Schema.XmlSchemaDatatype datatype, System.Boolean verifyUri)
  System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.String value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckBuiltInFacets(System.String s, System.Xml.Schema.XmlTypeCode typeCode, System.Boolean verifyUri)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.QNameFacetsChecker
TYPE:  class
TOKEN: 0x20001D6
EXTENDS: FacetsChecker
FIELDS:
METHODS:
  System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Xml.XmlQualifiedName value, System.Collections.ArrayList enumeration)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.MiscFacetsChecker
TYPE:  class
TOKEN: 0x20001D7
EXTENDS: FacetsChecker
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.BinaryFacetsChecker
TYPE:  class
TOKEN: 0x20001D8
EXTENDS: FacetsChecker
FIELDS:
METHODS:
  System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Exception CheckValueFacets(System.Byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Byte[] value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.ListFacetsChecker
TYPE:  class
TOKEN: 0x20001D9
EXTENDS: FacetsChecker
FIELDS:
METHODS:
  System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.UnionFacetsChecker
TYPE:  class
TOKEN: 0x20001DA
EXTENDS: FacetsChecker
FIELDS:
METHODS:
  System.Exception CheckValueFacets(System.Object value, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean MatchEnumeration(System.Object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.IXmlSchemaInfo
TYPE:  interface
TOKEN: 0x20001DB
FIELDS:
METHODS:
  System.Xml.Schema.XmlSchemaValidity get_Validity()
  System.Boolean get_IsDefault()
  System.Boolean get_IsNil()
  System.Xml.Schema.XmlSchemaSimpleType get_MemberType()
  System.Xml.Schema.XmlSchemaType get_SchemaType()
  System.Xml.Schema.XmlSchemaElement get_SchemaElement()
  System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaInference
TYPE:  class
TOKEN: 0x20001DC
FIELDS:
  private   static  System.Xml.XmlQualifiedName     ST_boolean  // 0x0
  private   static  System.Xml.XmlQualifiedName     ST_byte  // 0x8
  private   static  System.Xml.XmlQualifiedName     ST_unsignedByte  // 0x10
  private   static  System.Xml.XmlQualifiedName     ST_short  // 0x18
  private   static  System.Xml.XmlQualifiedName     ST_unsignedShort  // 0x20
  private   static  System.Xml.XmlQualifiedName     ST_int  // 0x28
  private   static  System.Xml.XmlQualifiedName     ST_unsignedInt  // 0x30
  private   static  System.Xml.XmlQualifiedName     ST_long  // 0x38
  private   static  System.Xml.XmlQualifiedName     ST_unsignedLong  // 0x40
  private   static  System.Xml.XmlQualifiedName     ST_integer  // 0x48
  private   static  System.Xml.XmlQualifiedName     ST_decimal  // 0x50
  private   static  System.Xml.XmlQualifiedName     ST_float  // 0x58
  private   static  System.Xml.XmlQualifiedName     ST_double  // 0x60
  private   static  System.Xml.XmlQualifiedName     ST_duration  // 0x68
  private   static  System.Xml.XmlQualifiedName     ST_dateTime  // 0x70
  private   static  System.Xml.XmlQualifiedName     ST_time  // 0x78
  private   static  System.Xml.XmlQualifiedName     ST_date  // 0x80
  private   static  System.Xml.XmlQualifiedName     ST_gYearMonth  // 0x88
  private   static  System.Xml.XmlQualifiedName     ST_string  // 0x90
  private   static  System.Xml.XmlQualifiedName     ST_anySimpleType  // 0x98
  private   static  System.Xml.XmlQualifiedName[]   SimpleTypes  // 0xA0
  private           System.Xml.Schema.XmlSchema     rootSchema  // 0x10
  private           System.Xml.Schema.XmlSchemaSet  schemaSet  // 0x18
  private           System.Xml.XmlReader            xtr  // 0x20
  private           System.Xml.NameTable            nametable  // 0x28
  private           System.String                   TargetNamespace  // 0x30
  private           System.Xml.XmlNamespaceManager  NamespaceManager  // 0x38
  private           System.Collections.ArrayList    schemaList  // 0x40
  private           System.Xml.Schema.XmlSchemaInference.InferenceOptionoccurrence  // 0x48
  private           System.Xml.Schema.XmlSchemaInference.InferenceOptiontypeInference  // 0x4C
METHODS:
  System.Void set_Occurrence(System.Xml.Schema.XmlSchemaInference.InferenceOption value)
  System.Xml.Schema.XmlSchemaInference.InferenceOption get_Occurrence()
  System.Void set_TypeInference(System.Xml.Schema.XmlSchemaInference.InferenceOption value)
  System.Void .ctor()
  System.Xml.Schema.XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument)
  System.Xml.Schema.XmlSchemaSet InferSchema1(System.Xml.XmlReader instanceDocument, System.Xml.Schema.XmlSchemaSet schemas)
  System.Xml.Schema.XmlSchemaAttribute AddAttribute(System.String localName, System.String prefix, System.String childURI, System.String attrValue, System.Boolean bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, System.Xml.Schema.XmlSchemaObjectTable compiledAttributes)
  System.Xml.Schema.XmlSchema CreateXmlSchema(System.String targetNS)
  System.Xml.Schema.XmlSchemaElement AddElement(System.String localName, System.String prefix, System.String childURI, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, System.Int32 positionWithinCollection)
  System.Void InferElement(System.Xml.Schema.XmlSchemaElement xse, System.Boolean bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema)
  System.Xml.Schema.XmlSchemaSimpleContentExtension CheckSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType ct)
  System.Xml.Schema.XmlSchemaType GetEffectiveSchemaType(System.Xml.Schema.XmlSchemaElement elem, System.Boolean bCreatingNewType)
  System.Xml.Schema.XmlSchemaElement FindMatchingElement(System.Boolean bCreatingNewType, System.Xml.XmlReader xtr, System.Xml.Schema.XmlSchemaComplexType ct, System.Int32& lastUsedSeqItem, System.Boolean& bParticleChanged, System.Xml.Schema.XmlSchema parentSchema, System.Boolean setMaxoccurs)
  System.Void ProcessAttributes(System.Xml.Schema.XmlSchemaElement& xse, System.Xml.Schema.XmlSchemaType effectiveSchemaType, System.Boolean bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema)
  System.Void MoveAttributes(System.Xml.Schema.XmlSchemaSimpleContentExtension scExtension, System.Xml.Schema.XmlSchemaComplexType ct)
  System.Void MoveAttributes(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleContentExtension, System.Boolean bCreatingNewType)
  System.Xml.Schema.XmlSchemaAttribute FindAttribute(System.Collections.ICollection attributes, System.String attrName)
  System.Xml.Schema.XmlSchemaElement FindGlobalElement(System.String namespaceURI, System.String localName, System.Xml.Schema.XmlSchema& parentSchema)
  System.Xml.Schema.XmlSchemaElement FindElement(System.Xml.Schema.XmlSchemaObjectCollection elements, System.String elementName)
  System.Xml.Schema.XmlSchemaAttribute FindAttributeRef(System.Collections.ICollection attributes, System.String attributeName, System.String nsURI)
  System.Xml.Schema.XmlSchemaElement FindElementRef(System.Xml.Schema.XmlSchemaObjectCollection elements, System.String elementName, System.String nsURI)
  System.Void MakeExistingAttributesOptional(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance)
  System.Void SwitchUseToOptional(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance)
  System.Xml.XmlQualifiedName RefineSimpleType(System.String s, System.Int32& iTypeFlags)
  System.Int32 InferSimpleType(System.String s, System.Boolean& bNeedsRangeCheck)
  System.Int32 DateTime(System.String s, System.Boolean bDate, System.Boolean bTime)
  System.Xml.Schema.XmlSchemaElement CreateNewElementforChoice(System.Xml.Schema.XmlSchemaElement copyElement)
  System.Int32 GetSchemaType(System.Xml.XmlQualifiedName qname)
  System.Void SetMinMaxOccurs(System.Xml.Schema.XmlSchemaElement el, System.Boolean setMaxOccurs)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaInferenceException
TYPE:  class
TOKEN: 0x20001DE
EXTENDS: XmlSchemaException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String res, System.String arg)
  System.Void .ctor(System.String res, System.Int32 lineNumber, System.Int32 linePosition)
END_CLASS

CLASS: System.Xml.Schema.NamespaceList
TYPE:  class
TOKEN: 0x20001DF
FIELDS:
  private           System.Xml.Schema.NamespaceList.ListTypetype  // 0x10
  private           System.Collections.Hashtable    set  // 0x18
  private           System.String                   targetNamespace  // 0x20
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String namespaces, System.String targetNamespace)
  System.Xml.Schema.NamespaceList Clone()
  System.Xml.Schema.NamespaceList.ListType get_Type()
  System.String get_Excluded()
  System.Collections.ICollection get_Enumerate()
  System.Boolean Allows(System.String ns)
  System.Boolean Allows(System.Xml.XmlQualifiedName qname)
  System.String ToString()
  System.Boolean IsSubset(System.Xml.Schema.NamespaceList sub, System.Xml.Schema.NamespaceList super)
  System.Xml.Schema.NamespaceList Union(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, System.Boolean v1Compat)
  System.Xml.Schema.NamespaceList CompareSetToOther(System.Xml.Schema.NamespaceList other)
  System.Xml.Schema.NamespaceList Intersection(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, System.Boolean v1Compat)
  System.Void RemoveNamespace(System.String tns)
END_CLASS

CLASS: System.Xml.Schema.NamespaceListV1Compat
TYPE:  class
TOKEN: 0x20001E1
EXTENDS: NamespaceList
FIELDS:
METHODS:
  System.Void .ctor(System.String namespaces, System.String targetNamespace)
  System.Boolean Allows(System.String ns)
END_CLASS

CLASS: System.Xml.Schema.Parser
TYPE:  class
TOKEN: 0x20001E2
FIELDS:
  private           System.Xml.Schema.SchemaType    schemaType  // 0x10
  private           System.Xml.XmlNameTable         nameTable  // 0x18
  private           System.Xml.Schema.SchemaNames   schemaNames  // 0x20
  private           System.Xml.Schema.ValidationEventHandlereventHandler  // 0x28
  private           System.Xml.XmlNamespaceManager  namespaceManager  // 0x30
  private           System.Xml.XmlReader            reader  // 0x38
  private           System.Xml.PositionInfo         positionInfo  // 0x40
  private           System.Boolean                  isProcessNamespaces  // 0x48
  private           System.Int32                    schemaXmlDepth  // 0x4C
  private           System.Int32                    markupDepth  // 0x50
  private           System.Xml.Schema.SchemaBuilder builder  // 0x58
  private           System.Xml.Schema.XmlSchema     schema  // 0x60
  private           System.Xml.Schema.SchemaInfo    xdrSchema  // 0x68
  private           System.Xml.XmlResolver          xmlResolver  // 0x70
  private           System.Xml.XmlDocument          dummyDocument  // 0x78
  private           System.Boolean                  processMarkup  // 0x80
  private           System.Xml.XmlNode              parentNode  // 0x88
  private           System.Xml.XmlNamespaceManager  annotationNSManager  // 0x90
  private           System.String                   xmlns  // 0x98
  private           System.Xml.XmlCharType          xmlCharType  // 0xA0
METHODS:
  System.Void .ctor(System.Xml.Schema.SchemaType schemaType, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler)
  System.Xml.Schema.SchemaType Parse(System.Xml.XmlReader reader, System.String targetNamespace)
  System.Void StartParsing(System.Xml.XmlReader reader, System.String targetNamespace)
  System.Boolean CheckSchemaRoot(System.Xml.Schema.SchemaType rootType, System.String& code)
  System.Xml.Schema.SchemaType FinishParsing()
  System.Xml.Schema.XmlSchema get_XmlSchema()
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Xml.Schema.SchemaInfo get_XdrSchema()
  System.Boolean ParseReaderNode()
  System.Void ProcessAppInfoDocMarkup(System.Boolean root)
  System.Xml.XmlElement LoadElementNode(System.Boolean root)
  System.Xml.XmlAttribute CreateXmlNsAttribute(System.String prefix, System.String value)
  System.Xml.XmlAttribute LoadAttributeNode()
  System.Xml.XmlEntityReference LoadEntityReferenceInAttribute()
END_CLASS

CLASS: System.Xml.Schema.Compositor
TYPE:  struct
TOKEN: 0x20001E3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.Compositor    Root  // 0x0
  public    static  System.Xml.Schema.Compositor    Include  // 0x0
  public    static  System.Xml.Schema.Compositor    Import  // 0x0
  public    static  System.Xml.Schema.Compositor    Redefine  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.RedefineEntry
TYPE:  class
TOKEN: 0x20001E4
FIELDS:
  private           System.Xml.Schema.XmlSchemaRedefineredefine  // 0x10
  private           System.Xml.Schema.XmlSchema     schemaToUpdate  // 0x18
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaRedefine external, System.Xml.Schema.XmlSchema schema)
END_CLASS

CLASS: System.Xml.Schema.Preprocessor
TYPE:  class
TOKEN: 0x20001E5
EXTENDS: BaseProcessor
FIELDS:
  private           System.String                   Xmlns  // 0x40
  private           System.String                   NsXsi  // 0x48
  private           System.String                   targetNamespace  // 0x50
  private           System.Xml.Schema.XmlSchema     rootSchema  // 0x58
  private           System.Xml.Schema.XmlSchema     currentSchema  // 0x60
  private           System.Xml.Schema.XmlSchemaForm elementFormDefault  // 0x68
  private           System.Xml.Schema.XmlSchemaForm attributeFormDefault  // 0x6C
  private           System.Xml.Schema.XmlSchemaDerivationMethodblockDefault  // 0x70
  private           System.Xml.Schema.XmlSchemaDerivationMethodfinalDefault  // 0x74
  private           System.Collections.Hashtable    schemaLocations  // 0x78
  private           System.Collections.Hashtable    chameleonSchemas  // 0x80
  private           System.Collections.Hashtable    referenceNamespaces  // 0x88
  private           System.Collections.Hashtable    processedExternals  // 0x90
  private           System.Collections.SortedList   lockList  // 0x98
  private           System.Xml.XmlReaderSettings    readerSettings  // 0xA0
  private           System.Xml.Schema.XmlSchema     rootSchemaForRedefine  // 0xA8
  private           System.Collections.ArrayList    redefinedList  // 0xB0
  private   static  System.Xml.Schema.XmlSchema     builtInSchemaForXmlNS  // 0x0
  private           System.Xml.XmlResolver          xmlResolver  // 0xB8
METHODS:
  System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings)
  System.Boolean Execute(System.Xml.Schema.XmlSchema schema, System.String targetNamespace, System.Boolean loadExternals)
  System.Void Cleanup(System.Xml.Schema.XmlSchema schema)
  System.Void CleanupRedefine(System.Xml.Schema.XmlSchemaExternal include)
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Void set_ReaderSettings(System.Xml.XmlReaderSettings value)
  System.Void set_SchemaLocations(System.Collections.Hashtable value)
  System.Void set_ChameleonSchemas(System.Collections.Hashtable value)
  System.Xml.Schema.XmlSchema get_RootSchema()
  System.Void BuildSchemaList(System.Xml.Schema.XmlSchema schema)
  System.Void LoadExternals(System.Xml.Schema.XmlSchema schema)
  System.Xml.Schema.XmlSchema GetBuildInSchema()
  System.Void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema)
  System.Void ParseUri(System.String uri, System.String code, System.Xml.Schema.XmlSchemaObject sourceSchemaObject)
  System.Void Preprocess(System.Xml.Schema.XmlSchema schema, System.String targetNamespace, System.Collections.ArrayList imports)
  System.Void CopyIncludedComponents(System.Xml.Schema.XmlSchema includedSchema, System.Xml.Schema.XmlSchema schema)
  System.Void PreprocessRedefine(System.Xml.Schema.RedefineEntry redefineEntry)
  System.Void GetIncludedSet(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList includesList)
  System.Xml.Schema.XmlSchema GetParentSchema(System.Xml.Schema.XmlSchemaObject currentSchemaObject)
  System.Void SetSchemaDefaults(System.Xml.Schema.XmlSchema schema)
  System.Int32 CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaGroup redefined)
  System.Void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group)
  System.Void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup)
  System.Void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype)
  System.Void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype)
  System.Void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute)
  System.Void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute)
  System.Void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute)
  System.Void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup)
  System.Void PreprocessElement(System.Xml.Schema.XmlSchemaElement element)
  System.Void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element)
  System.Void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element)
  System.Void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint)
  System.Void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, System.Boolean local)
  System.Void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Boolean local)
  System.Void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group)
  System.Void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation)
  System.Void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle)
  System.Void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent)
  System.Void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso)
  System.Void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso)
  System.Void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, System.String attributeName, System.Xml.XmlQualifiedName value)
  System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, System.String location)
  System.Object GetSchemaEntity(System.Uri ruri)
  System.Xml.Schema.XmlSchema GetChameleonSchema(System.String targetNamespace, System.Xml.Schema.XmlSchema schema)
  System.Void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent)
  System.Void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject)
  System.Void PreprocessAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation)
END_CLASS

CLASS: System.Xml.Schema.SchemaAttDef
TYPE:  class
TOKEN: 0x20001E6
EXTENDS: SchemaDeclBase
FIELDS:
  private           System.String                   defExpanded  // 0x60
  private           System.Int32                    lineNum  // 0x68
  private           System.Int32                    linePos  // 0x6C
  private           System.Int32                    valueLineNum  // 0x70
  private           System.Int32                    valueLinePos  // 0x74
  private           System.Xml.Schema.SchemaAttDef.Reservereserved  // 0x78
  private           System.Boolean                  defaultValueChecked  // 0x7C
  private           System.Xml.Schema.XmlSchemaAttributeschemaAttribute  // 0x80
  public    static readonly System.Xml.Schema.SchemaAttDef  Empty  // 0x0
METHODS:
  System.Void .ctor(System.Xml.XmlQualifiedName name, System.String prefix)
  System.Void .ctor(System.Xml.XmlQualifiedName name)
  System.Void .ctor()
  System.String System.Xml.IDtdAttributeInfo.get_Prefix()
  System.String System.Xml.IDtdAttributeInfo.get_LocalName()
  System.Int32 System.Xml.IDtdAttributeInfo.get_LineNumber()
  System.Int32 System.Xml.IDtdAttributeInfo.get_LinePosition()
  System.Boolean System.Xml.IDtdAttributeInfo.get_IsNonCDataType()
  System.Boolean System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal()
  System.Boolean System.Xml.IDtdAttributeInfo.get_IsXmlAttribute()
  System.String System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded()
  System.Object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped()
  System.Int32 System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber()
  System.Int32 System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition()
  System.Int32 get_LinePosition()
  System.Void set_LinePosition(System.Int32 value)
  System.Int32 get_LineNumber()
  System.Void set_LineNumber(System.Int32 value)
  System.Int32 get_ValueLinePosition()
  System.Void set_ValueLinePosition(System.Int32 value)
  System.Int32 get_ValueLineNumber()
  System.Void set_ValueLineNumber(System.Int32 value)
  System.String get_DefaultValueExpanded()
  System.Void set_DefaultValueExpanded(System.String value)
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Void set_TokenizedType(System.Xml.XmlTokenizedType value)
  System.Xml.Schema.SchemaAttDef.Reserve get_Reserved()
  System.Void set_Reserved(System.Xml.Schema.SchemaAttDef.Reserve value)
  System.Boolean get_DefaultValueChecked()
  System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute()
  System.Void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value)
  System.Void CheckXmlSpace(System.Xml.IValidationEventHandling validationEventHandling)
  System.Xml.Schema.SchemaAttDef Clone()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.SchemaBuilder
TYPE:  class
TOKEN: 0x20001E8
FIELDS:
METHODS:
  System.Boolean ProcessElement(System.String prefix, System.String name, System.String ns)
  System.Void ProcessAttribute(System.String prefix, System.String name, System.String ns, System.String value)
  System.Boolean IsContentParsed()
  System.Void ProcessMarkup(System.Xml.XmlNode[] markup)
  System.Void ProcessCData(System.String value)
  System.Void StartChildren()
  System.Void EndChildren()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.SchemaCollectionCompiler
TYPE:  class
TOKEN: 0x20001E9
EXTENDS: BaseProcessor
FIELDS:
  private           System.Boolean                  compileContentModel  // 0x40
  private           System.Xml.Schema.XmlSchemaObjectTableexamplars  // 0x48
  private           System.Collections.Stack        complexTypeStack  // 0x50
  private           System.Xml.Schema.XmlSchema     schema  // 0x58
METHODS:
  System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler)
  System.Boolean Execute(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.SchemaInfo schemaInfo, System.Boolean compileContentModel)
  System.Void Prepare()
  System.Void Cleanup()
  System.Void Cleanup(System.Xml.Schema.XmlSchema schema)
  System.Void Compile()
  System.Void Output(System.Xml.Schema.SchemaInfo schemaInfo)
  System.Void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute)
  System.Void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup)
  System.Void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType)
  System.Void CleanupElement(System.Xml.Schema.XmlSchemaElement element)
  System.Void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes)
  System.Void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group)
  System.Void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle)
  System.Void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroupV1Compat substitutionGroup)
  System.Void CheckSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup)
  System.Void CompileGroup(System.Xml.Schema.XmlSchemaGroup group)
  System.Void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType)
  System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType)
  System.Void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType)
  System.Void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension)
  System.Void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction)
  System.Void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension)
  System.Void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction)
  System.Void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Boolean substitution)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Boolean root, System.Boolean substitution)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element, System.Boolean substitution)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, System.Boolean root, System.Boolean substitution)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, System.Boolean root, System.Boolean substitution)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, System.Boolean root, System.Boolean substitution)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, System.Boolean root, System.Boolean substitution)
  System.Boolean IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle)
  System.Boolean IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement)
  System.Boolean IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny)
  System.Boolean IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny)
  System.Boolean IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny)
  System.Boolean IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, System.Boolean skipEmptableOnly)
  System.Boolean IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, System.Boolean skipEmptableOnly)
  System.Boolean IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll)
  System.Boolean IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice)
  System.Void CalculateSequenceRange(System.Xml.Schema.XmlSchemaSequence sequence, System.Decimal& minOccurs, System.Decimal& maxOccurs)
  System.Boolean IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle)
  System.Boolean IsValidOccurrenceRangeRestriction(System.Decimal minOccurs, System.Decimal maxOccurs, System.Decimal baseMinOccurs, System.Decimal baseMaxOccurs)
  System.Int32 GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection)
  System.Boolean IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle)
  System.Void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, System.Decimal& minOccurs, System.Decimal& maxOccurs)
  System.Void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle)
  System.Void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup)
  System.Void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy)
  System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b)
  System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b)
  System.Void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa)
  System.Void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi)
  System.Void CompileElement(System.Xml.Schema.XmlSchemaElement xe)
  System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Void BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle)
  System.Void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle)
  System.Void CompileCompexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name)
  System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name)
  System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name)
END_CLASS

CLASS: System.Xml.Schema.SchemaCollectionPreprocessor
TYPE:  class
TOKEN: 0x20001EA
EXTENDS: BaseProcessor
FIELDS:
  private           System.Xml.Schema.XmlSchema     schema  // 0x40
  private           System.String                   targetNamespace  // 0x48
  private           System.Boolean                  buildinIncluded  // 0x50
  private           System.Xml.Schema.XmlSchemaForm elementFormDefault  // 0x54
  private           System.Xml.Schema.XmlSchemaForm attributeFormDefault  // 0x58
  private           System.Xml.Schema.XmlSchemaDerivationMethodblockDefault  // 0x5C
  private           System.Xml.Schema.XmlSchemaDerivationMethodfinalDefault  // 0x60
  private           System.Collections.Hashtable    schemaLocations  // 0x68
  private           System.Collections.Hashtable    referenceNamespaces  // 0x70
  private           System.String                   Xmlns  // 0x78
  private           System.Xml.XmlResolver          xmlResolver  // 0x80
METHODS:
  System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler)
  System.Boolean Execute(System.Xml.Schema.XmlSchema schema, System.String targetNamespace, System.Boolean loadExternals, System.Xml.Schema.XmlSchemaCollection xsc)
  System.Void Cleanup(System.Xml.Schema.XmlSchema schema)
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Void LoadExternals(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.XmlSchemaCollection xsc)
  System.Void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema)
  System.Void Preprocess(System.Xml.Schema.XmlSchema schema, System.String targetNamespace, System.Xml.Schema.SchemaCollectionPreprocessor.Compositor compositor)
  System.Void PreprocessRedefine(System.Xml.Schema.XmlSchemaRedefine redefine)
  System.Int32 CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name)
  System.Void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group)
  System.Void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup)
  System.Void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype)
  System.Void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype)
  System.Void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute)
  System.Void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute)
  System.Void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute)
  System.Void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup)
  System.Void PreprocessElement(System.Xml.Schema.XmlSchemaElement element)
  System.Void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element)
  System.Void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element)
  System.Void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint)
  System.Void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, System.Boolean local)
  System.Void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Boolean local)
  System.Void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group)
  System.Void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation)
  System.Void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle)
  System.Void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent)
  System.Void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso)
  System.Void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso)
  System.Void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, System.String attributeName, System.Xml.XmlQualifiedName value)
  System.Void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent)
  System.Void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject)
  System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, System.String location)
  System.IO.Stream GetSchemaEntity(System.Uri ruri)
END_CLASS

CLASS: System.Xml.Schema.SchemaDeclBase
TYPE:  class
TOKEN: 0x20001EC
FIELDS:
  protected         System.Xml.XmlQualifiedName     name  // 0x10
  protected         System.String                   prefix  // 0x18
  protected         System.Boolean                  isDeclaredInExternal  // 0x20
  protected         System.Xml.Schema.SchemaDeclBase.Usepresence  // 0x24
  protected         System.Xml.Schema.XmlSchemaType schemaType  // 0x28
  protected         System.Xml.Schema.XmlSchemaDatatypedatatype  // 0x30
  protected         System.String                   defaultValueRaw  // 0x38
  protected         System.Object                   defaultValueTyped  // 0x40
  protected         System.Int64                    maxLength  // 0x48
  protected         System.Int64                    minLength  // 0x50
  protected         System.Collections.Generic.List<System.String>values  // 0x58
METHODS:
  System.Void .ctor(System.Xml.XmlQualifiedName name, System.String prefix)
  System.Void .ctor()
  System.Xml.XmlQualifiedName get_Name()
  System.Void set_Name(System.Xml.XmlQualifiedName value)
  System.String get_Prefix()
  System.Void set_Prefix(System.String value)
  System.Boolean get_IsDeclaredInExternal()
  System.Void set_IsDeclaredInExternal(System.Boolean value)
  System.Xml.Schema.SchemaDeclBase.Use get_Presence()
  System.Void set_Presence(System.Xml.Schema.SchemaDeclBase.Use value)
  System.Int64 get_MaxLength()
  System.Void set_MaxLength(System.Int64 value)
  System.Int64 get_MinLength()
  System.Void set_MinLength(System.Int64 value)
  System.Xml.Schema.XmlSchemaType get_SchemaType()
  System.Void set_SchemaType(System.Xml.Schema.XmlSchemaType value)
  System.Xml.Schema.XmlSchemaDatatype get_Datatype()
  System.Void set_Datatype(System.Xml.Schema.XmlSchemaDatatype value)
  System.Void AddValue(System.String value)
  System.Collections.Generic.List<System.String> get_Values()
  System.Void set_Values(System.Collections.Generic.List<System.String> value)
  System.String get_DefaultValueRaw()
  System.Void set_DefaultValueRaw(System.String value)
  System.Object get_DefaultValueTyped()
  System.Void set_DefaultValueTyped(System.Object value)
  System.Boolean CheckEnumeration(System.Object pVal)
  System.Boolean CheckValue(System.Object pVal)
END_CLASS

CLASS: System.Xml.Schema.SchemaElementDecl
TYPE:  class
TOKEN: 0x20001EE
EXTENDS: SchemaDeclBase
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef>attdefs  // 0x60
  private           System.Collections.Generic.List<System.Xml.IDtdDefaultAttributeInfo>defaultAttdefs  // 0x68
  private           System.Boolean                  isIdDeclared  // 0x70
  private           System.Boolean                  hasNonCDataAttribute  // 0x71
  private           System.Boolean                  isAbstract  // 0x72
  private           System.Boolean                  isNillable  // 0x73
  private           System.Boolean                  hasRequiredAttribute  // 0x74
  private           System.Boolean                  isNotationDeclared  // 0x75
  private           System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName>prohibitedAttributes  // 0x78
  private           System.Xml.Schema.ContentValidatorcontentValidator  // 0x80
  private           System.Xml.Schema.XmlSchemaAnyAttributeanyAttribute  // 0x88
  private           System.Xml.Schema.XmlSchemaDerivationMethodblock  // 0x90
  private           System.Xml.Schema.CompiledIdentityConstraint[]constraints  // 0x98
  private           System.Xml.Schema.XmlSchemaElementschemaElement  // 0xA0
  private   static readonly System.Xml.Schema.SchemaElementDeclEmpty  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Xml.Schema.XmlSchemaDatatype dtype)
  System.Void .ctor(System.Xml.XmlQualifiedName name, System.String prefix)
  System.Xml.Schema.SchemaElementDecl CreateAnyTypeElementDecl()
  System.Boolean System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes()
  System.Xml.IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(System.String prefix, System.String localName)
  System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes()
  System.Boolean get_IsIdDeclared()
  System.Void set_IsIdDeclared(System.Boolean value)
  System.Boolean get_HasNonCDataAttribute()
  System.Void set_HasNonCDataAttribute(System.Boolean value)
  System.Xml.Schema.SchemaElementDecl Clone()
  System.Boolean get_IsAbstract()
  System.Void set_IsAbstract(System.Boolean value)
  System.Boolean get_IsNillable()
  System.Void set_IsNillable(System.Boolean value)
  System.Xml.Schema.XmlSchemaDerivationMethod get_Block()
  System.Void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.Boolean get_IsNotationDeclared()
  System.Void set_IsNotationDeclared(System.Boolean value)
  System.Boolean get_HasDefaultAttribute()
  System.Boolean get_HasRequiredAttribute()
  System.Xml.Schema.ContentValidator get_ContentValidator()
  System.Void set_ContentValidator(System.Xml.Schema.ContentValidator value)
  System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute()
  System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value)
  System.Xml.Schema.CompiledIdentityConstraint[] get_Constraints()
  System.Void set_Constraints(System.Xml.Schema.CompiledIdentityConstraint[] value)
  System.Xml.Schema.XmlSchemaElement get_SchemaElement()
  System.Void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value)
  System.Void AddAttDef(System.Xml.Schema.SchemaAttDef attdef)
  System.Xml.Schema.SchemaAttDef GetAttDef(System.Xml.XmlQualifiedName qname)
  System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs()
  System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttDefs()
  System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName> get_ProhibitedAttributes()
  System.Void CheckAttributes(System.Collections.Hashtable presence, System.Boolean standalone)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.SchemaEntity
TYPE:  class
TOKEN: 0x20001EF
FIELDS:
  private           System.Xml.XmlQualifiedName     qname  // 0x10
  private           System.String                   url  // 0x18
  private           System.String                   pubid  // 0x20
  private           System.String                   text  // 0x28
  private           System.Xml.XmlQualifiedName     ndata  // 0x30
  private           System.Int32                    lineNumber  // 0x38
  private           System.Int32                    linePosition  // 0x3C
  private           System.Boolean                  isParameter  // 0x40
  private           System.Boolean                  isExternal  // 0x41
  private           System.Boolean                  parsingInProgress  // 0x42
  private           System.Boolean                  isDeclaredInExternal  // 0x43
  private           System.String                   baseURI  // 0x48
  private           System.String                   declaredURI  // 0x50
METHODS:
  System.Void .ctor(System.Xml.XmlQualifiedName qname, System.Boolean isParameter)
  System.String System.Xml.IDtdEntityInfo.get_Name()
  System.Boolean System.Xml.IDtdEntityInfo.get_IsExternal()
  System.Boolean System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal()
  System.Boolean System.Xml.IDtdEntityInfo.get_IsUnparsedEntity()
  System.Boolean System.Xml.IDtdEntityInfo.get_IsParameterEntity()
  System.String System.Xml.IDtdEntityInfo.get_BaseUriString()
  System.String System.Xml.IDtdEntityInfo.get_DeclaredUriString()
  System.String System.Xml.IDtdEntityInfo.get_SystemId()
  System.String System.Xml.IDtdEntityInfo.get_PublicId()
  System.String System.Xml.IDtdEntityInfo.get_Text()
  System.Int32 System.Xml.IDtdEntityInfo.get_LineNumber()
  System.Int32 System.Xml.IDtdEntityInfo.get_LinePosition()
  System.Boolean IsPredefinedEntity(System.String n)
  System.Xml.XmlQualifiedName get_Name()
  System.String get_Url()
  System.Void set_Url(System.String value)
  System.String get_Pubid()
  System.Void set_Pubid(System.String value)
  System.Boolean get_IsExternal()
  System.Void set_IsExternal(System.Boolean value)
  System.Boolean get_DeclaredInExternal()
  System.Void set_DeclaredInExternal(System.Boolean value)
  System.Xml.XmlQualifiedName get_NData()
  System.Void set_NData(System.Xml.XmlQualifiedName value)
  System.String get_Text()
  System.Void set_Text(System.String value)
  System.Int32 get_Line()
  System.Void set_Line(System.Int32 value)
  System.Int32 get_Pos()
  System.Void set_Pos(System.Int32 value)
  System.String get_BaseURI()
  System.Void set_BaseURI(System.String value)
  System.Boolean get_ParsingInProgress()
  System.Void set_ParsingInProgress(System.Boolean value)
  System.String get_DeclaredURI()
  System.Void set_DeclaredURI(System.String value)
END_CLASS

CLASS: System.Xml.Schema.AttributeMatchState
TYPE:  struct
TOKEN: 0x20001F0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.AttributeMatchStateAttributeFound  // 0x0
  public    static  System.Xml.Schema.AttributeMatchStateAnyIdAttributeFound  // 0x0
  public    static  System.Xml.Schema.AttributeMatchStateUndeclaredElementAndAttribute  // 0x0
  public    static  System.Xml.Schema.AttributeMatchStateUndeclaredAttribute  // 0x0
  public    static  System.Xml.Schema.AttributeMatchStateAnyAttributeLax  // 0x0
  public    static  System.Xml.Schema.AttributeMatchStateAnyAttributeSkip  // 0x0
  public    static  System.Xml.Schema.AttributeMatchStateProhibitedAnyAttribute  // 0x0
  public    static  System.Xml.Schema.AttributeMatchStateProhibitedAttribute  // 0x0
  public    static  System.Xml.Schema.AttributeMatchStateAttributeNameMismatch  // 0x0
  public    static  System.Xml.Schema.AttributeMatchStateValidateAttributeInvalidCall  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.SchemaInfo
TYPE:  class
TOKEN: 0x20001F1
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl>elementDecls  // 0x10
  private           System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl>undeclaredElementDecls  // 0x18
  private           System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity>generalEntities  // 0x20
  private           System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity>parameterEntities  // 0x28
  private           System.Xml.XmlQualifiedName     docTypeName  // 0x30
  private           System.String                   internalDtdSubset  // 0x38
  private           System.Boolean                  hasNonCDataAttributes  // 0x40
  private           System.Boolean                  hasDefaultAttributes  // 0x41
  private           System.Collections.Generic.Dictionary<System.String,System.Boolean>targetNamespaces  // 0x48
  private           System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef>attributeDecls  // 0x50
  private           System.Int32                    errorCount  // 0x58
  private           System.Xml.Schema.SchemaType    schemaType  // 0x5C
  private           System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl>elementDeclsByType  // 0x60
  private           System.Collections.Generic.Dictionary<System.String,System.Xml.Schema.SchemaNotation>notations  // 0x68
METHODS:
  System.Void .ctor()
  System.Xml.XmlQualifiedName get_DocTypeName()
  System.Void set_DocTypeName(System.Xml.XmlQualifiedName value)
  System.Void set_InternalDtdSubset(System.String value)
  System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDecls()
  System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls()
  System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_GeneralEntities()
  System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_ParameterEntities()
  System.Xml.Schema.SchemaType get_SchemaType()
  System.Void set_SchemaType(System.Xml.Schema.SchemaType value)
  System.Collections.Generic.Dictionary<System.String,System.Boolean> get_TargetNamespaces()
  System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType()
  System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttributeDecls()
  System.Collections.Generic.Dictionary<System.String,System.Xml.Schema.SchemaNotation> get_Notations()
  System.Int32 get_ErrorCount()
  System.Void set_ErrorCount(System.Int32 value)
  System.Xml.Schema.SchemaElementDecl GetElementDecl(System.Xml.XmlQualifiedName qname)
  System.Xml.Schema.SchemaElementDecl GetTypeDecl(System.Xml.XmlQualifiedName qname)
  System.Xml.Schema.XmlSchemaElement GetElement(System.Xml.XmlQualifiedName qname)
  System.Boolean HasSchema(System.String ns)
  System.Boolean Contains(System.String ns)
  System.Xml.Schema.SchemaAttDef GetAttributeXdr(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname)
  System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject partialValidationType, System.Xml.Schema.AttributeMatchState& attributeMatchState)
  System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, System.Boolean& skip)
  System.Void Add(System.Xml.Schema.SchemaInfo sinfo, System.Xml.Schema.ValidationEventHandler eventhandler)
  System.Void Finish()
  System.Boolean System.Xml.IDtdInfo.get_HasDefaultAttributes()
  System.Boolean System.Xml.IDtdInfo.get_HasNonCDataAttributes()
  System.Xml.IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(System.String prefix, System.String localName)
  System.Xml.IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(System.String name)
  System.Xml.XmlQualifiedName System.Xml.IDtdInfo.get_Name()
  System.String System.Xml.IDtdInfo.get_InternalDtdSubset()
END_CLASS

CLASS: System.Xml.Schema.SchemaNames
TYPE:  class
TOKEN: 0x20001F2
FIELDS:
  private           System.Xml.XmlNameTable         nameTable  // 0x10
  public            System.String                   NsDataType  // 0x18
  public            System.String                   NsDataTypeAlias  // 0x20
  public            System.String                   NsDataTypeOld  // 0x28
  public            System.String                   NsXml  // 0x30
  public            System.String                   NsXmlNs  // 0x38
  public            System.String                   NsXdr  // 0x40
  public            System.String                   NsXdrAlias  // 0x48
  public            System.String                   NsXs  // 0x50
  public            System.String                   NsXsi  // 0x58
  public            System.String                   XsiType  // 0x60
  public            System.String                   XsiNil  // 0x68
  public            System.String                   XsiSchemaLocation  // 0x70
  public            System.String                   XsiNoNamespaceSchemaLocation  // 0x78
  public            System.String                   XsdSchema  // 0x80
  public            System.String                   XdrSchema  // 0x88
  public            System.Xml.XmlQualifiedName     QnPCData  // 0x90
  public            System.Xml.XmlQualifiedName     QnXml  // 0x98
  public            System.Xml.XmlQualifiedName     QnXmlNs  // 0xA0
  public            System.Xml.XmlQualifiedName     QnDtDt  // 0xA8
  public            System.Xml.XmlQualifiedName     QnXmlLang  // 0xB0
  public            System.Xml.XmlQualifiedName     QnName  // 0xB8
  public            System.Xml.XmlQualifiedName     QnType  // 0xC0
  public            System.Xml.XmlQualifiedName     QnMaxOccurs  // 0xC8
  public            System.Xml.XmlQualifiedName     QnMinOccurs  // 0xD0
  public            System.Xml.XmlQualifiedName     QnInfinite  // 0xD8
  public            System.Xml.XmlQualifiedName     QnModel  // 0xE0
  public            System.Xml.XmlQualifiedName     QnOpen  // 0xE8
  public            System.Xml.XmlQualifiedName     QnClosed  // 0xF0
  public            System.Xml.XmlQualifiedName     QnContent  // 0xF8
  public            System.Xml.XmlQualifiedName     QnMixed  // 0x100
  public            System.Xml.XmlQualifiedName     QnEmpty  // 0x108
  public            System.Xml.XmlQualifiedName     QnEltOnly  // 0x110
  public            System.Xml.XmlQualifiedName     QnTextOnly  // 0x118
  public            System.Xml.XmlQualifiedName     QnOrder  // 0x120
  public            System.Xml.XmlQualifiedName     QnSeq  // 0x128
  public            System.Xml.XmlQualifiedName     QnOne  // 0x130
  public            System.Xml.XmlQualifiedName     QnMany  // 0x138
  public            System.Xml.XmlQualifiedName     QnRequired  // 0x140
  public            System.Xml.XmlQualifiedName     QnYes  // 0x148
  public            System.Xml.XmlQualifiedName     QnNo  // 0x150
  public            System.Xml.XmlQualifiedName     QnString  // 0x158
  public            System.Xml.XmlQualifiedName     QnID  // 0x160
  public            System.Xml.XmlQualifiedName     QnIDRef  // 0x168
  public            System.Xml.XmlQualifiedName     QnIDRefs  // 0x170
  public            System.Xml.XmlQualifiedName     QnEntity  // 0x178
  public            System.Xml.XmlQualifiedName     QnEntities  // 0x180
  public            System.Xml.XmlQualifiedName     QnNmToken  // 0x188
  public            System.Xml.XmlQualifiedName     QnNmTokens  // 0x190
  public            System.Xml.XmlQualifiedName     QnEnumeration  // 0x198
  public            System.Xml.XmlQualifiedName     QnDefault  // 0x1A0
  public            System.Xml.XmlQualifiedName     QnXdrSchema  // 0x1A8
  public            System.Xml.XmlQualifiedName     QnXdrElementType  // 0x1B0
  public            System.Xml.XmlQualifiedName     QnXdrElement  // 0x1B8
  public            System.Xml.XmlQualifiedName     QnXdrGroup  // 0x1C0
  public            System.Xml.XmlQualifiedName     QnXdrAttributeType  // 0x1C8
  public            System.Xml.XmlQualifiedName     QnXdrAttribute  // 0x1D0
  public            System.Xml.XmlQualifiedName     QnXdrDataType  // 0x1D8
  public            System.Xml.XmlQualifiedName     QnXdrDescription  // 0x1E0
  public            System.Xml.XmlQualifiedName     QnXdrExtends  // 0x1E8
  public            System.Xml.XmlQualifiedName     QnXdrAliasSchema  // 0x1F0
  public            System.Xml.XmlQualifiedName     QnDtType  // 0x1F8
  public            System.Xml.XmlQualifiedName     QnDtValues  // 0x200
  public            System.Xml.XmlQualifiedName     QnDtMaxLength  // 0x208
  public            System.Xml.XmlQualifiedName     QnDtMinLength  // 0x210
  public            System.Xml.XmlQualifiedName     QnDtMax  // 0x218
  public            System.Xml.XmlQualifiedName     QnDtMin  // 0x220
  public            System.Xml.XmlQualifiedName     QnDtMinExclusive  // 0x228
  public            System.Xml.XmlQualifiedName     QnDtMaxExclusive  // 0x230
  public            System.Xml.XmlQualifiedName     QnTargetNamespace  // 0x238
  public            System.Xml.XmlQualifiedName     QnVersion  // 0x240
  public            System.Xml.XmlQualifiedName     QnFinalDefault  // 0x248
  public            System.Xml.XmlQualifiedName     QnBlockDefault  // 0x250
  public            System.Xml.XmlQualifiedName     QnFixed  // 0x258
  public            System.Xml.XmlQualifiedName     QnAbstract  // 0x260
  public            System.Xml.XmlQualifiedName     QnBlock  // 0x268
  public            System.Xml.XmlQualifiedName     QnSubstitutionGroup  // 0x270
  public            System.Xml.XmlQualifiedName     QnFinal  // 0x278
  public            System.Xml.XmlQualifiedName     QnNillable  // 0x280
  public            System.Xml.XmlQualifiedName     QnRef  // 0x288
  public            System.Xml.XmlQualifiedName     QnBase  // 0x290
  public            System.Xml.XmlQualifiedName     QnDerivedBy  // 0x298
  public            System.Xml.XmlQualifiedName     QnNamespace  // 0x2A0
  public            System.Xml.XmlQualifiedName     QnProcessContents  // 0x2A8
  public            System.Xml.XmlQualifiedName     QnRefer  // 0x2B0
  public            System.Xml.XmlQualifiedName     QnPublic  // 0x2B8
  public            System.Xml.XmlQualifiedName     QnSystem  // 0x2C0
  public            System.Xml.XmlQualifiedName     QnSchemaLocation  // 0x2C8
  public            System.Xml.XmlQualifiedName     QnValue  // 0x2D0
  public            System.Xml.XmlQualifiedName     QnUse  // 0x2D8
  public            System.Xml.XmlQualifiedName     QnForm  // 0x2E0
  public            System.Xml.XmlQualifiedName     QnElementFormDefault  // 0x2E8
  public            System.Xml.XmlQualifiedName     QnAttributeFormDefault  // 0x2F0
  public            System.Xml.XmlQualifiedName     QnItemType  // 0x2F8
  public            System.Xml.XmlQualifiedName     QnMemberTypes  // 0x300
  public            System.Xml.XmlQualifiedName     QnXPath  // 0x308
  public            System.Xml.XmlQualifiedName     QnXsdSchema  // 0x310
  public            System.Xml.XmlQualifiedName     QnXsdAnnotation  // 0x318
  public            System.Xml.XmlQualifiedName     QnXsdInclude  // 0x320
  public            System.Xml.XmlQualifiedName     QnXsdImport  // 0x328
  public            System.Xml.XmlQualifiedName     QnXsdElement  // 0x330
  public            System.Xml.XmlQualifiedName     QnXsdAttribute  // 0x338
  public            System.Xml.XmlQualifiedName     QnXsdAttributeGroup  // 0x340
  public            System.Xml.XmlQualifiedName     QnXsdAnyAttribute  // 0x348
  public            System.Xml.XmlQualifiedName     QnXsdGroup  // 0x350
  public            System.Xml.XmlQualifiedName     QnXsdAll  // 0x358
  public            System.Xml.XmlQualifiedName     QnXsdChoice  // 0x360
  public            System.Xml.XmlQualifiedName     QnXsdSequence  // 0x368
  public            System.Xml.XmlQualifiedName     QnXsdAny  // 0x370
  public            System.Xml.XmlQualifiedName     QnXsdNotation  // 0x378
  public            System.Xml.XmlQualifiedName     QnXsdSimpleType  // 0x380
  public            System.Xml.XmlQualifiedName     QnXsdComplexType  // 0x388
  public            System.Xml.XmlQualifiedName     QnXsdUnique  // 0x390
  public            System.Xml.XmlQualifiedName     QnXsdKey  // 0x398
  public            System.Xml.XmlQualifiedName     QnXsdKeyRef  // 0x3A0
  public            System.Xml.XmlQualifiedName     QnXsdSelector  // 0x3A8
  public            System.Xml.XmlQualifiedName     QnXsdField  // 0x3B0
  public            System.Xml.XmlQualifiedName     QnXsdMinExclusive  // 0x3B8
  public            System.Xml.XmlQualifiedName     QnXsdMinInclusive  // 0x3C0
  public            System.Xml.XmlQualifiedName     QnXsdMaxInclusive  // 0x3C8
  public            System.Xml.XmlQualifiedName     QnXsdMaxExclusive  // 0x3D0
  public            System.Xml.XmlQualifiedName     QnXsdTotalDigits  // 0x3D8
  public            System.Xml.XmlQualifiedName     QnXsdFractionDigits  // 0x3E0
  public            System.Xml.XmlQualifiedName     QnXsdLength  // 0x3E8
  public            System.Xml.XmlQualifiedName     QnXsdMinLength  // 0x3F0
  public            System.Xml.XmlQualifiedName     QnXsdMaxLength  // 0x3F8
  public            System.Xml.XmlQualifiedName     QnXsdEnumeration  // 0x400
  public            System.Xml.XmlQualifiedName     QnXsdPattern  // 0x408
  public            System.Xml.XmlQualifiedName     QnXsdDocumentation  // 0x410
  public            System.Xml.XmlQualifiedName     QnXsdAppinfo  // 0x418
  public            System.Xml.XmlQualifiedName     QnSource  // 0x420
  public            System.Xml.XmlQualifiedName     QnXsdComplexContent  // 0x428
  public            System.Xml.XmlQualifiedName     QnXsdSimpleContent  // 0x430
  public            System.Xml.XmlQualifiedName     QnXsdRestriction  // 0x438
  public            System.Xml.XmlQualifiedName     QnXsdExtension  // 0x440
  public            System.Xml.XmlQualifiedName     QnXsdUnion  // 0x448
  public            System.Xml.XmlQualifiedName     QnXsdList  // 0x450
  public            System.Xml.XmlQualifiedName     QnXsdWhiteSpace  // 0x458
  public            System.Xml.XmlQualifiedName     QnXsdRedefine  // 0x460
  public            System.Xml.XmlQualifiedName     QnXsdAnyType  // 0x468
  private           System.Xml.XmlQualifiedName[]   TokenToQName  // 0x470
METHODS:
  System.Void .ctor(System.Xml.XmlNameTable nameTable)
  System.Void CreateTokenToQNameTable()
  System.Xml.Schema.SchemaType SchemaTypeFromRoot(System.String localName, System.String ns)
  System.Boolean IsXSDRoot(System.String localName, System.String ns)
  System.Boolean IsXDRRoot(System.String localName, System.String ns)
END_CLASS

CLASS: System.Xml.Schema.SchemaNamespaceManager
TYPE:  class
TOKEN: 0x20001F4
EXTENDS: XmlNamespaceManager
FIELDS:
  private           System.Xml.Schema.XmlSchemaObjectnode  // 0x50
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaObject node)
  System.String LookupNamespace(System.String prefix)
  System.String LookupPrefix(System.String ns)
END_CLASS

CLASS: System.Xml.Schema.SchemaNotation
TYPE:  class
TOKEN: 0x20001F5
FIELDS:
  private           System.Xml.XmlQualifiedName     name  // 0x10
  private           System.String                   systemLiteral  // 0x18
  private           System.String                   pubid  // 0x20
METHODS:
  System.Void .ctor(System.Xml.XmlQualifiedName name)
  System.Xml.XmlQualifiedName get_Name()
  System.String get_SystemLiteral()
  System.Void set_SystemLiteral(System.String value)
  System.String get_Pubid()
  System.Void set_Pubid(System.String value)
END_CLASS

CLASS: System.Xml.Schema.Compiler
TYPE:  class
TOKEN: 0x20001F6
EXTENDS: BaseProcessor
FIELDS:
  private           System.String                   restrictionErrorMsg  // 0x40
  private           System.Xml.Schema.XmlSchemaObjectTableattributes  // 0x48
  private           System.Xml.Schema.XmlSchemaObjectTableattributeGroups  // 0x50
  private           System.Xml.Schema.XmlSchemaObjectTableelements  // 0x58
  private           System.Xml.Schema.XmlSchemaObjectTableschemaTypes  // 0x60
  private           System.Xml.Schema.XmlSchemaObjectTablegroups  // 0x68
  private           System.Xml.Schema.XmlSchemaObjectTablenotations  // 0x70
  private           System.Xml.Schema.XmlSchemaObjectTableexamplars  // 0x78
  private           System.Xml.Schema.XmlSchemaObjectTableidentityConstraints  // 0x80
  private           System.Collections.Stack        complexTypeStack  // 0x88
  private           System.Collections.Hashtable    schemasToCompile  // 0x90
  private           System.Collections.Hashtable    importedSchemas  // 0x98
  private           System.Xml.Schema.XmlSchema     schemaForSchema  // 0xA0
METHODS:
  System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchema schemaForSchema, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings)
  System.Boolean Execute(System.Xml.Schema.XmlSchemaSet schemaSet, System.Xml.Schema.SchemaInfo schemaCompiledInfo)
  System.Void Prepare(System.Xml.Schema.XmlSchema schema, System.Boolean cleanup)
  System.Void UpdateSForSSimpleTypes()
  System.Void Output(System.Xml.Schema.SchemaInfo schemaInfo)
  System.Void ImportAllCompiledSchemas(System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Boolean Compile()
  System.Void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute)
  System.Void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup)
  System.Void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType)
  System.Void CleanupElement(System.Xml.Schema.XmlSchemaElement element)
  System.Void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes)
  System.Void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group)
  System.Void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle)
  System.Void ProcessSubstitutionGroups()
  System.Void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup)
  System.Void RecursivelyCheckRedefinedGroups(System.Xml.Schema.XmlSchemaGroup redefinedGroup, System.Xml.Schema.XmlSchemaGroup baseGroup)
  System.Void RecursivelyCheckRedefinedAttributeGroups(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup)
  System.Void CompileGroup(System.Xml.Schema.XmlSchemaGroup group)
  System.Void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType)
  System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType)
  System.Void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType)
  System.Void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension)
  System.Void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction)
  System.Void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension)
  System.Void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction)
  System.Void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Void CheckParticleDerivation(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle)
  System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Boolean root)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, System.Boolean root)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, System.Boolean root)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, System.Boolean root)
  System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, System.Boolean root)
  System.Xml.Schema.XmlSchemaParticle CannonicalizePointlessRoot(System.Xml.Schema.XmlSchemaParticle particle)
  System.Boolean IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle)
  System.Boolean IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement)
  System.Boolean IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny)
  System.Boolean IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny)
  System.Boolean IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny)
  System.Boolean IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase)
  System.Boolean IsChoiceFromChoiceSubstGroup(System.Xml.Schema.XmlSchemaChoice derivedChoice, System.Xml.Schema.XmlSchemaChoice baseChoice)
  System.Boolean IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, System.Boolean skipEmptableOnly)
  System.Boolean IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll)
  System.Boolean IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice)
  System.Boolean IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle)
  System.Boolean IsValidOccurrenceRangeRestriction(System.Decimal minOccurs, System.Decimal maxOccurs, System.Decimal baseMinOccurs, System.Decimal baseMaxOccurs)
  System.Int32 GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection)
  System.Boolean IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle)
  System.Void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, System.Decimal& minOccurs, System.Decimal& maxOccurs)
  System.Void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle)
  System.Void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup)
  System.Void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy)
  System.Void CheckAtrributeGroupRestriction(System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup derivedAttributeGroup)
  System.Boolean IsProcessContentsRestricted(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaAnyAttribute derivedAttributeWildcard, System.Xml.Schema.XmlSchemaAnyAttribute baseAttributeWildcard)
  System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b)
  System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b)
  System.Void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa)
  System.Void SetDefaultFixed(System.Xml.Schema.XmlSchemaAttribute xa, System.Xml.Schema.SchemaAttDef decl)
  System.Void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi)
  System.Void CompileElement(System.Xml.Schema.XmlSchemaElement xe)
  System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Boolean BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle)
  System.Void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle)
  System.Void CompileParticleElements(System.Xml.Schema.XmlSchemaParticle particle)
  System.Void CompileComplexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType)
  System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name)
  System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name)
  System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name)
  System.Void CopyPosition(System.Xml.Schema.XmlSchemaAnnotated to, System.Xml.Schema.XmlSchemaAnnotated from, System.Boolean copyParent)
  System.Boolean IsFixedEqual(System.Xml.Schema.SchemaDeclBase baseDecl, System.Xml.Schema.SchemaDeclBase derivedDecl)
END_CLASS

CLASS: System.Xml.Schema.SchemaType
TYPE:  struct
TOKEN: 0x20001F7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.SchemaType    None  // 0x0
  public    static  System.Xml.Schema.SchemaType    DTD  // 0x0
  public    static  System.Xml.Schema.SchemaType    XDR  // 0x0
  public    static  System.Xml.Schema.SchemaType    XSD  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.ValidationEventArgs
TYPE:  class
TOKEN: 0x20001F8
EXTENDS: EventArgs
FIELDS:
  private           System.Xml.Schema.XmlSchemaExceptionex  // 0x10
  private           System.Xml.Schema.XmlSeverityTypeseverity  // 0x18
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaException ex)
  System.Void .ctor(System.Xml.Schema.XmlSchemaException ex, System.Xml.Schema.XmlSeverityType severity)
  System.Xml.Schema.XmlSeverityType get_Severity()
  System.Xml.Schema.XmlSchemaException get_Exception()
END_CLASS

CLASS: System.Xml.Schema.ValidationEventHandler
TYPE:  class
TOKEN: 0x20001F9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Xml.Schema.ValidationEventArgs e)
END_CLASS

CLASS: System.Xml.Schema.StateUnion
TYPE:  struct
TOKEN: 0x20001FA
FIELDS:
  public            System.Int32                    State  // 0x10
  public            System.Int32                    AllElementsRequired  // 0x10
  public            System.Int32                    CurPosIndex  // 0x10
  public            System.Int32                    NumberOfRunningPos  // 0x10
METHODS:
END_CLASS

CLASS: System.Xml.Schema.ValidationState
TYPE:  class
TOKEN: 0x20001FB
FIELDS:
  public            System.Boolean                  IsNill  // 0x10
  public            System.Boolean                  IsDefault  // 0x11
  public            System.Boolean                  NeedValidateChildren  // 0x12
  public            System.Boolean                  CheckRequiredAttribute  // 0x13
  public            System.Boolean                  ValidationSkipped  // 0x14
  public            System.Xml.Schema.XmlSchemaContentProcessingProcessContents  // 0x18
  public            System.Xml.Schema.XmlSchemaValidityValidity  // 0x1C
  public            System.Xml.Schema.SchemaElementDeclElementDecl  // 0x20
  public            System.Xml.Schema.SchemaElementDeclElementDeclBeforeXsi  // 0x28
  public            System.String                   LocalName  // 0x30
  public            System.String                   Namespace  // 0x38
  public            System.Xml.Schema.ConstraintStruct[]Constr  // 0x40
  public            System.Xml.Schema.StateUnion    CurrentState  // 0x48
  public            System.Boolean                  HasMatched  // 0x4C
  public            System.Xml.Schema.BitSet[]      CurPos  // 0x50
  public            System.Xml.Schema.BitSet        AllElementsSet  // 0x58
  public            System.Collections.Generic.List<System.Xml.Schema.RangePositionInfo>RunningPositions  // 0x60
  public            System.Boolean                  TooComplex  // 0x68
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XdrBuilder
TYPE:  class
TOKEN: 0x20001FC
EXTENDS: SchemaBuilder
FIELDS:
  private   static readonly System.Int32[]                  S_XDR_Root_Element  // 0x0
  private   static readonly System.Int32[]                  S_XDR_Root_SubElements  // 0x8
  private   static readonly System.Int32[]                  S_XDR_ElementType_SubElements  // 0x10
  private   static readonly System.Int32[]                  S_XDR_AttributeType_SubElements  // 0x18
  private   static readonly System.Int32[]                  S_XDR_Group_SubElements  // 0x20
  private   static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[]S_XDR_Root_Attributes  // 0x28
  private   static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[]S_XDR_ElementType_Attributes  // 0x30
  private   static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[]S_XDR_AttributeType_Attributes  // 0x38
  private   static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[]S_XDR_Element_Attributes  // 0x40
  private   static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[]S_XDR_Attribute_Attributes  // 0x48
  private   static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[]S_XDR_Group_Attributes  // 0x50
  private   static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[]S_XDR_ElementDataType_Attributes  // 0x58
  private   static readonly System.Xml.Schema.XdrBuilder.XdrAttributeEntry[]S_XDR_AttributeDataType_Attributes  // 0x60
  private   static readonly System.Xml.Schema.XdrBuilder.XdrEntry[]S_SchemaEntries  // 0x68
  private           System.Xml.Schema.SchemaInfo    _SchemaInfo  // 0x10
  private           System.String                   _TargetNamespace  // 0x18
  private           System.Xml.XmlReader            _reader  // 0x20
  private           System.Xml.PositionInfo         positionInfo  // 0x28
  private           System.Xml.Schema.ParticleContentValidator_contentValidator  // 0x30
  private           System.Xml.Schema.XdrBuilder.XdrEntry_CurState  // 0x38
  private           System.Xml.Schema.XdrBuilder.XdrEntry_NextState  // 0x40
  private           System.Xml.HWStack              _StateHistory  // 0x48
  private           System.Xml.HWStack              _GroupStack  // 0x50
  private           System.String                   _XdrName  // 0x58
  private           System.String                   _XdrPrefix  // 0x60
  private           System.Xml.Schema.XdrBuilder.ElementContent_ElementDef  // 0x68
  private           System.Xml.Schema.XdrBuilder.GroupContent_GroupDef  // 0x70
  private           System.Xml.Schema.XdrBuilder.AttributeContent_AttributeDef  // 0x78
  private           System.Xml.Schema.XdrBuilder.DeclBaseInfo_UndefinedAttributeTypes  // 0x80
  private           System.Xml.Schema.XdrBuilder.DeclBaseInfo_BaseDecl  // 0x88
  private           System.Xml.XmlNameTable         _NameTable  // 0x90
  private           System.Xml.Schema.SchemaNames   _SchemaNames  // 0x98
  private           System.Xml.XmlNamespaceManager  _CurNsMgr  // 0xA0
  private           System.String                   _Text  // 0xA8
  private           System.Xml.Schema.ValidationEventHandlervalidationEventHandler  // 0xB0
  private           System.Collections.Hashtable    _UndeclaredElements  // 0xB8
  private           System.Xml.XmlResolver          xmlResolver  // 0xC0
METHODS:
  System.Void .ctor(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.SchemaInfo sinfo, System.String targetNamspace, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler)
  System.Boolean ProcessElement(System.String prefix, System.String name, System.String ns)
  System.Void ProcessAttribute(System.String prefix, System.String name, System.String ns, System.String value)
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Boolean LoadSchema(System.String uri)
  System.Boolean IsXdrSchema(System.String uri)
  System.Boolean IsContentParsed()
  System.Void ProcessMarkup(System.Xml.XmlNode[] markup)
  System.Void ProcessCData(System.String value)
  System.Void StartChildren()
  System.Void EndChildren()
  System.Void Push()
  System.Void Pop()
  System.Void PushGroupInfo()
  System.Void PopGroupInfo()
  System.Void XDR_InitRoot(System.Xml.Schema.XdrBuilder builder, System.Object obj)
  System.Void XDR_BuildRoot_Name(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildRoot_ID(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BeginRoot(System.Xml.Schema.XdrBuilder builder)
  System.Void XDR_EndRoot(System.Xml.Schema.XdrBuilder builder)
  System.Void XDR_InitElementType(System.Xml.Schema.XdrBuilder builder, System.Object obj)
  System.Void XDR_BuildElementType_Name(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildElementType_Content(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildElementType_Model(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildElementType_Order(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildElementType_DtType(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildElementType_DtValues(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildElementType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildElementType_DtMinLength(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BeginElementType(System.Xml.Schema.XdrBuilder builder)
  System.Void XDR_EndElementType(System.Xml.Schema.XdrBuilder builder)
  System.Void XDR_InitAttributeType(System.Xml.Schema.XdrBuilder builder, System.Object obj)
  System.Void XDR_BuildAttributeType_Name(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildAttributeType_Required(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildAttributeType_Default(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildAttributeType_DtType(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildAttributeType_DtValues(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildAttributeType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildAttributeType_DtMinLength(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BeginAttributeType(System.Xml.Schema.XdrBuilder builder)
  System.Void XDR_EndAttributeType(System.Xml.Schema.XdrBuilder builder)
  System.Void XDR_InitElement(System.Xml.Schema.XdrBuilder builder, System.Object obj)
  System.Void XDR_BuildElement_Type(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildElement_MinOccurs(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildElement_MaxOccurs(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_EndElement(System.Xml.Schema.XdrBuilder builder)
  System.Void XDR_InitAttribute(System.Xml.Schema.XdrBuilder builder, System.Object obj)
  System.Void XDR_BuildAttribute_Type(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildAttribute_Required(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildAttribute_Default(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BeginAttribute(System.Xml.Schema.XdrBuilder builder)
  System.Void XDR_EndAttribute(System.Xml.Schema.XdrBuilder builder)
  System.Void XDR_InitGroup(System.Xml.Schema.XdrBuilder builder, System.Object obj)
  System.Void XDR_BuildGroup_Order(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildGroup_MinOccurs(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_BuildGroup_MaxOccurs(System.Xml.Schema.XdrBuilder builder, System.Object obj, System.String prefix)
  System.Void XDR_EndGroup(System.Xml.Schema.XdrBuilder builder)
  System.Void XDR_InitElementDtType(System.Xml.Schema.XdrBuilder builder, System.Object obj)
  System.Void XDR_EndElementDtType(System.Xml.Schema.XdrBuilder builder)
  System.Void XDR_InitAttributeDtType(System.Xml.Schema.XdrBuilder builder, System.Object obj)
  System.Void XDR_EndAttributeDtType(System.Xml.Schema.XdrBuilder builder)
  System.Boolean GetNextState(System.Xml.XmlQualifiedName qname)
  System.Boolean IsSkipableElement(System.Xml.XmlQualifiedName qname)
  System.Boolean IsSkipableAttribute(System.Xml.XmlQualifiedName qname)
  System.Int32 GetOrder(System.Xml.XmlQualifiedName qname)
  System.Void AddOrder()
  System.Boolean IsYes(System.Object obj, System.Xml.Schema.XdrBuilder builder)
  System.UInt32 ParseMinOccurs(System.Object obj, System.Xml.Schema.XdrBuilder builder)
  System.UInt32 ParseMaxOccurs(System.Object obj, System.Xml.Schema.XdrBuilder builder)
  System.Void HandleMinMax(System.Xml.Schema.ParticleContentValidator pContent, System.UInt32 cMin, System.UInt32 cMax)
  System.Void ParseDtMaxLength(System.UInt32& cVal, System.Object obj, System.Xml.Schema.XdrBuilder builder)
  System.Void ParseDtMinLength(System.UInt32& cVal, System.Object obj, System.Xml.Schema.XdrBuilder builder)
  System.Void CompareMinMaxLength(System.UInt32 cMin, System.UInt32 cMax, System.Xml.Schema.XdrBuilder builder)
  System.Boolean ParseInteger(System.String str, System.UInt32& n)
  System.Void XDR_CheckAttributeDefault(System.Xml.Schema.XdrBuilder.DeclBaseInfo decl, System.Xml.Schema.SchemaAttDef pAttdef)
  System.Void SetAttributePresence(System.Xml.Schema.SchemaAttDef pAttdef, System.Boolean fRequired)
  System.Int32 GetContent(System.Xml.XmlQualifiedName qname)
  System.Boolean GetModel(System.Xml.XmlQualifiedName qname)
  System.Xml.Schema.XmlSchemaDatatype CheckDatatype(System.String str)
  System.Void CheckDefaultAttValue(System.Xml.Schema.SchemaAttDef attDef)
  System.Boolean IsGlobal(System.Int32 flags)
  System.Void SendValidationEvent(System.String code, System.String[] args, System.Xml.Schema.XmlSeverityType severity)
  System.Void SendValidationEvent(System.String code)
  System.Void SendValidationEvent(System.String code, System.String msg)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XdrValidator
TYPE:  class
TOKEN: 0x2000207
EXTENDS: BaseValidator
FIELDS:
  private           System.Xml.HWStack              validationStack  // 0x80
  private           System.Collections.Hashtable    attPresence  // 0x88
  private           System.Xml.XmlQualifiedName     name  // 0x90
  private           System.Xml.XmlNamespaceManager  nsManager  // 0x98
  private           System.Boolean                  isProcessContents  // 0xA0
  private           System.Collections.Hashtable    IDs  // 0xA8
  private           System.Xml.Schema.IdRefNode     idRefListHead  // 0xB0
  private           System.Xml.Schema.Parser        inlineSchemaParser  // 0xB8
METHODS:
  System.Void .ctor(System.Xml.Schema.BaseValidator validator)
  System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling)
  System.Void Init()
  System.Void Validate()
  System.Void ValidateElement()
  System.Void ValidateChildElement()
  System.Boolean get_IsInlineSchemaStarted()
  System.Void ProcessInlineSchema()
  System.Void ProcessElement()
  System.Void ValidateEndElement()
  System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl()
  System.Void ValidateStartElement()
  System.Void ValidateEndStartElement()
  System.Void LoadSchemaFromLocation(System.String uri)
  System.Void LoadSchema(System.String uri)
  System.Boolean get_HasSchema()
  System.Boolean get_PreserveWhitespace()
  System.Void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, System.String name)
  System.Void CompleteValidation()
  System.Void CheckValue(System.String value, System.Xml.Schema.SchemaAttDef attdef)
  System.Void CheckDefaultValue(System.String value, System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.XmlNamespaceManager nsManager, System.Xml.XmlNameTable NameTable, System.Object sender, System.Xml.Schema.ValidationEventHandler eventhandler, System.String baseUri, System.Int32 lineNo, System.Int32 linePos)
  System.Void AddID(System.String name, System.Object node)
  System.Object FindId(System.String name)
  System.Void Push(System.Xml.XmlQualifiedName elementName)
  System.Void Pop()
  System.Void CheckForwardRefs()
  System.Xml.XmlQualifiedName QualifiedName(System.String name, System.String ns)
END_CLASS

CLASS: System.Xml.Schema.XmlAtomicValue
TYPE:  class
TOKEN: 0x2000208
EXTENDS: XPathItem
FIELDS:
  private           System.Xml.Schema.XmlSchemaType xmlType  // 0x10
  private           System.Object                   objVal  // 0x18
  private           System.TypeCode                 clrType  // 0x20
  private           System.Xml.Schema.XmlAtomicValue.UnionunionVal  // 0x28
  private           System.Xml.Schema.XmlAtomicValue.NamespacePrefixForQNamensPrefix  // 0x30
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Boolean value)
  System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.DateTime value)
  System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Double value)
  System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Int32 value)
  System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Int64 value)
  System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.String value)
  System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.String value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Object value)
  System.Void .ctor(System.Xml.Schema.XmlSchemaType xmlType, System.Object value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object System.ICloneable.Clone()
  System.Xml.Schema.XmlSchemaType get_XmlType()
  System.Type get_ValueType()
  System.Object get_TypedValue()
  System.Boolean get_ValueAsBoolean()
  System.DateTime get_ValueAsDateTime()
  System.Double get_ValueAsDouble()
  System.Int32 get_ValueAsInt()
  System.Int64 get_ValueAsLong()
  System.Object ValueAs(System.Type type, System.Xml.IXmlNamespaceResolver nsResolver)
  System.String get_Value()
  System.String ToString()
  System.String GetPrefixFromQName(System.String value)
END_CLASS

CLASS: System.Xml.Schema.XmlSchema
TYPE:  class
TOKEN: 0x200020B
EXTENDS: XmlSchemaObject
FIELDS:
  private           System.Xml.Schema.XmlSchemaForm attributeFormDefault  // 0x38
  private           System.Xml.Schema.XmlSchemaForm elementFormDefault  // 0x3C
  private           System.Xml.Schema.XmlSchemaDerivationMethodblockDefault  // 0x40
  private           System.Xml.Schema.XmlSchemaDerivationMethodfinalDefault  // 0x44
  private           System.String                   targetNs  // 0x48
  private           System.String                   version  // 0x50
  private           System.Xml.Schema.XmlSchemaObjectCollectionincludes  // 0x58
  private           System.Xml.Schema.XmlSchemaObjectCollectionitems  // 0x60
  private           System.String                   id  // 0x68
  private           System.Xml.XmlAttribute[]       moreAttributes  // 0x70
  private           System.Boolean                  isCompiled  // 0x78
  private           System.Boolean                  isCompiledBySet  // 0x79
  private           System.Boolean                  isPreprocessed  // 0x7A
  private           System.Boolean                  isRedefined  // 0x7B
  private           System.Int32                    errorCount  // 0x7C
  private           System.Xml.Schema.XmlSchemaObjectTableattributes  // 0x80
  private           System.Xml.Schema.XmlSchemaObjectTableattributeGroups  // 0x88
  private           System.Xml.Schema.XmlSchemaObjectTableelements  // 0x90
  private           System.Xml.Schema.XmlSchemaObjectTabletypes  // 0x98
  private           System.Xml.Schema.XmlSchemaObjectTablegroups  // 0xA0
  private           System.Xml.Schema.XmlSchemaObjectTablenotations  // 0xA8
  private           System.Xml.Schema.XmlSchemaObjectTableidentityConstraints  // 0xB0
  private   static  System.Int32                    globalIdCounter  // 0x0
  private           System.Collections.ArrayList    importedSchemas  // 0xB8
  private           System.Collections.ArrayList    importedNamespaces  // 0xC0
  private           System.Int32                    schemaId  // 0xC8
  private           System.Uri                      baseUri  // 0xD0
  private           System.Boolean                  isChameleon  // 0xD8
  private           System.Collections.Hashtable    ids  // 0xE0
  private           System.Xml.XmlDocument          document  // 0xE8
METHODS:
  System.Void .ctor()
  System.Xml.Schema.XmlSchema Read(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler)
  System.Boolean CompileSchema(System.Xml.Schema.XmlSchemaCollection xsc, System.Xml.XmlResolver resolver, System.Xml.Schema.SchemaInfo schemaInfo, System.String ns, System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlNameTable nameTable, System.Boolean CompileContentModel)
  System.Void CompileSchemaInSet(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings)
  System.Xml.Schema.XmlSchemaForm get_AttributeFormDefault()
  System.Void set_AttributeFormDefault(System.Xml.Schema.XmlSchemaForm value)
  System.Xml.Schema.XmlSchemaDerivationMethod get_BlockDefault()
  System.Void set_BlockDefault(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.Xml.Schema.XmlSchemaDerivationMethod get_FinalDefault()
  System.Void set_FinalDefault(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.Xml.Schema.XmlSchemaForm get_ElementFormDefault()
  System.Void set_ElementFormDefault(System.Xml.Schema.XmlSchemaForm value)
  System.String get_TargetNamespace()
  System.Void set_TargetNamespace(System.String value)
  System.String get_Version()
  System.Void set_Version(System.String value)
  System.Xml.Schema.XmlSchemaObjectCollection get_Includes()
  System.Xml.Schema.XmlSchemaObjectCollection get_Items()
  System.Boolean get_IsCompiledBySet()
  System.Void set_IsCompiledBySet(System.Boolean value)
  System.Boolean get_IsPreprocessed()
  System.Void set_IsPreprocessed(System.Boolean value)
  System.Boolean get_IsRedefined()
  System.Void set_IsRedefined(System.Boolean value)
  System.Xml.Schema.XmlSchemaObjectTable get_Attributes()
  System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups()
  System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes()
  System.Xml.Schema.XmlSchemaObjectTable get_Elements()
  System.String get_Id()
  System.Void set_Id(System.String value)
  System.Xml.Schema.XmlSchemaObjectTable get_Groups()
  System.Xml.Schema.XmlSchemaObjectTable get_Notations()
  System.Xml.Schema.XmlSchemaObjectTable get_IdentityConstraints()
  System.Uri get_BaseUri()
  System.Void set_BaseUri(System.Uri value)
  System.Int32 get_SchemaId()
  System.Boolean get_IsChameleon()
  System.Void set_IsChameleon(System.Boolean value)
  System.Collections.Hashtable get_Ids()
  System.Xml.XmlDocument get_Document()
  System.Int32 get_ErrorCount()
  System.Void set_ErrorCount(System.Int32 value)
  System.Xml.Schema.XmlSchema Clone()
  System.Xml.Schema.XmlSchema DeepClone()
  System.String get_IdAttribute()
  System.Void set_IdAttribute(System.String value)
  System.Void SetIsCompiled(System.Boolean isCompiled)
  System.Void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes)
  System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation)
  System.Collections.ArrayList get_ImportedSchemas()
  System.Collections.ArrayList get_ImportedNamespaces()
  System.Void GetExternalSchemasList(System.Collections.IList extList, System.Xml.Schema.XmlSchema schema)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaAll
TYPE:  class
TOKEN: 0x200020C
EXTENDS: XmlSchemaGroupBase
FIELDS:
  private           System.Xml.Schema.XmlSchemaObjectCollectionitems  // 0x78
METHODS:
  System.Xml.Schema.XmlSchemaObjectCollection get_Items()
  System.Boolean get_IsEmpty()
  System.Void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaAnnotated
TYPE:  class
TOKEN: 0x200020D
EXTENDS: XmlSchemaObject
FIELDS:
  private           System.String                   id  // 0x38
  private           System.Xml.Schema.XmlSchemaAnnotationannotation  // 0x40
  private           System.Xml.XmlAttribute[]       moreAttributes  // 0x48
METHODS:
  System.String get_Id()
  System.Void set_Id(System.String value)
  System.Xml.Schema.XmlSchemaAnnotation get_Annotation()
  System.Void set_Annotation(System.Xml.Schema.XmlSchemaAnnotation value)
  System.Xml.XmlAttribute[] get_UnhandledAttributes()
  System.Void set_UnhandledAttributes(System.Xml.XmlAttribute[] value)
  System.String get_IdAttribute()
  System.Void set_IdAttribute(System.String value)
  System.Void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes)
  System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaAnnotation
TYPE:  class
TOKEN: 0x200020E
EXTENDS: XmlSchemaObject
FIELDS:
  private           System.String                   id  // 0x38
  private           System.Xml.Schema.XmlSchemaObjectCollectionitems  // 0x40
  private           System.Xml.XmlAttribute[]       moreAttributes  // 0x48
METHODS:
  System.String get_Id()
  System.Void set_Id(System.String value)
  System.Xml.Schema.XmlSchemaObjectCollection get_Items()
  System.String get_IdAttribute()
  System.Void set_IdAttribute(System.String value)
  System.Void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaAny
TYPE:  class
TOKEN: 0x200020F
EXTENDS: XmlSchemaParticle
FIELDS:
  private           System.String                   ns  // 0x78
  private           System.Xml.Schema.XmlSchemaContentProcessingprocessContents  // 0x80
  private           System.Xml.Schema.NamespaceList namespaceList  // 0x88
METHODS:
  System.String get_Namespace()
  System.Void set_Namespace(System.String value)
  System.Void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value)
  System.Xml.Schema.NamespaceList get_NamespaceList()
  System.String get_ResolvedNamespace()
  System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect()
  System.String get_NameString()
  System.Void BuildNamespaceList(System.String targetNamespace)
  System.Void BuildNamespaceListV1Compat(System.String targetNamespace)
  System.Boolean Allows(System.Xml.XmlQualifiedName qname)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaAnyAttribute
TYPE:  class
TOKEN: 0x2000210
EXTENDS: XmlSchemaAnnotated
FIELDS:
  private           System.String                   ns  // 0x50
  private           System.Xml.Schema.XmlSchemaContentProcessingprocessContents  // 0x58
  private           System.Xml.Schema.NamespaceList namespaceList  // 0x60
METHODS:
  System.Void set_Namespace(System.String value)
  System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContents()
  System.Void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value)
  System.Xml.Schema.NamespaceList get_NamespaceList()
  System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect()
  System.Void BuildNamespaceList(System.String targetNamespace)
  System.Void BuildNamespaceListV1Compat(System.String targetNamespace)
  System.Boolean Allows(System.Xml.XmlQualifiedName qname)
  System.Boolean IsSubset(System.Xml.Schema.XmlSchemaAnyAttribute sub, System.Xml.Schema.XmlSchemaAnyAttribute super)
  System.Xml.Schema.XmlSchemaAnyAttribute Intersection(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, System.Boolean v1Compat)
  System.Xml.Schema.XmlSchemaAnyAttribute Union(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, System.Boolean v1Compat)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaAppInfo
TYPE:  class
TOKEN: 0x2000211
EXTENDS: XmlSchemaObject
FIELDS:
  private           System.String                   source  // 0x38
  private           System.Xml.XmlNode[]            markup  // 0x40
METHODS:
  System.Void set_Source(System.String value)
  System.Xml.XmlNode[] get_Markup()
  System.Void set_Markup(System.Xml.XmlNode[] value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaAttribute
TYPE:  class
TOKEN: 0x2000212
EXTENDS: XmlSchemaAnnotated
FIELDS:
  private           System.String                   defaultValue  // 0x50
  private           System.String                   fixedValue  // 0x58
  private           System.String                   name  // 0x60
  private           System.Xml.Schema.XmlSchemaForm form  // 0x68
  private           System.Xml.Schema.XmlSchemaUse  use  // 0x6C
  private           System.Xml.XmlQualifiedName     refName  // 0x70
  private           System.Xml.XmlQualifiedName     typeName  // 0x78
  private           System.Xml.XmlQualifiedName     qualifiedName  // 0x80
  private           System.Xml.Schema.XmlSchemaSimpleTypetype  // 0x88
  private           System.Xml.Schema.XmlSchemaSimpleTypeattributeType  // 0x90
  private           System.Xml.Schema.SchemaAttDef  attDef  // 0x98
METHODS:
  System.String get_DefaultValue()
  System.Void set_DefaultValue(System.String value)
  System.String get_FixedValue()
  System.Void set_FixedValue(System.String value)
  System.Xml.Schema.XmlSchemaForm get_Form()
  System.Void set_Form(System.Xml.Schema.XmlSchemaForm value)
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Xml.XmlQualifiedName get_RefName()
  System.Void set_RefName(System.Xml.XmlQualifiedName value)
  System.Xml.XmlQualifiedName get_SchemaTypeName()
  System.Void set_SchemaTypeName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.XmlSchemaSimpleType get_SchemaType()
  System.Void set_SchemaType(System.Xml.Schema.XmlSchemaSimpleType value)
  System.Xml.Schema.XmlSchemaUse get_Use()
  System.Void set_Use(System.Xml.Schema.XmlSchemaUse value)
  System.Xml.XmlQualifiedName get_QualifiedName()
  System.Xml.Schema.XmlSchemaSimpleType get_AttributeSchemaType()
  System.Xml.Schema.XmlSchemaDatatype get_Datatype()
  System.Void SetQualifiedName(System.Xml.XmlQualifiedName value)
  System.Void SetAttributeType(System.Xml.Schema.XmlSchemaSimpleType value)
  System.Xml.Schema.SchemaAttDef get_AttDef()
  System.Void set_AttDef(System.Xml.Schema.SchemaAttDef value)
  System.String get_NameAttribute()
  System.Void set_NameAttribute(System.String value)
  System.Xml.Schema.XmlSchemaObject Clone()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaAttributeGroup
TYPE:  class
TOKEN: 0x2000213
EXTENDS: XmlSchemaAnnotated
FIELDS:
  private           System.String                   name  // 0x50
  private           System.Xml.Schema.XmlSchemaObjectCollectionattributes  // 0x58
  private           System.Xml.Schema.XmlSchemaAnyAttributeanyAttribute  // 0x60
  private           System.Xml.XmlQualifiedName     qname  // 0x68
  private           System.Xml.Schema.XmlSchemaAttributeGroupredefined  // 0x70
  private           System.Xml.Schema.XmlSchemaObjectTableattributeUses  // 0x78
  private           System.Xml.Schema.XmlSchemaAnyAttributeattributeWildcard  // 0x80
  private           System.Int32                    selfReferenceCount  // 0x88
METHODS:
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Xml.Schema.XmlSchemaObjectCollection get_Attributes()
  System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute()
  System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value)
  System.Xml.XmlQualifiedName get_QualifiedName()
  System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses()
  System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard()
  System.Void set_AttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value)
  System.Xml.Schema.XmlSchemaAttributeGroup get_RedefinedAttributeGroup()
  System.Xml.Schema.XmlSchemaAttributeGroup get_Redefined()
  System.Void set_Redefined(System.Xml.Schema.XmlSchemaAttributeGroup value)
  System.Int32 get_SelfReferenceCount()
  System.Void set_SelfReferenceCount(System.Int32 value)
  System.String get_NameAttribute()
  System.Void set_NameAttribute(System.String value)
  System.Void SetQualifiedName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.XmlSchemaObject Clone()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaAttributeGroupRef
TYPE:  class
TOKEN: 0x2000214
EXTENDS: XmlSchemaAnnotated
FIELDS:
  private           System.Xml.XmlQualifiedName     refName  // 0x50
METHODS:
  System.Xml.XmlQualifiedName get_RefName()
  System.Void set_RefName(System.Xml.XmlQualifiedName value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaChoice
TYPE:  class
TOKEN: 0x2000215
EXTENDS: XmlSchemaGroupBase
FIELDS:
  private           System.Xml.Schema.XmlSchemaObjectCollectionitems  // 0x78
METHODS:
  System.Xml.Schema.XmlSchemaObjectCollection get_Items()
  System.Boolean get_IsEmpty()
  System.Void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaCollection
TYPE:  class
TOKEN: 0x2000216
FIELDS:
  private           System.Collections.Hashtable    collection  // 0x10
  private           System.Xml.XmlNameTable         nameTable  // 0x18
  private           System.Xml.Schema.SchemaNames   schemaNames  // 0x20
  private           System.Threading.ReaderWriterLockwLock  // 0x28
  private           System.Int32                    timeout  // 0x30
  private           System.Boolean                  isThreadSafe  // 0x34
  private           System.Xml.Schema.ValidationEventHandlervalidationEventHandler  // 0x38
  private           System.Xml.XmlResolver          xmlResolver  // 0x40
METHODS:
  System.Void .ctor(System.Xml.XmlNameTable nametable)
  System.Int32 get_Count()
  System.Xml.XmlNameTable get_NameTable()
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Xml.Schema.XmlSchema get_Item(System.String ns)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Xml.Schema.XmlSchemaCollectionEnumerator GetEnumerator()
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  System.Int32 System.Collections.ICollection.get_Count()
  System.Xml.Schema.SchemaInfo GetSchemaInfo(System.String ns)
  System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt)
  System.Xml.Schema.XmlSchema Add(System.String ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, System.Boolean compile)
  System.Xml.Schema.XmlSchema Add(System.String ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, System.Boolean compile, System.Xml.XmlResolver resolver)
  System.Void Add(System.String ns, System.Xml.Schema.XmlSchemaCollectionNode node)
  System.Xml.Schema.ValidationEventHandler get_EventHandler()
  System.Void set_EventHandler(System.Xml.Schema.ValidationEventHandler value)
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaCollectionNode
TYPE:  class
TOKEN: 0x2000217
FIELDS:
  private           System.String                   namespaceUri  // 0x10
  private           System.Xml.Schema.SchemaInfo    schemaInfo  // 0x18
  private           System.Xml.Schema.XmlSchema     schema  // 0x20
METHODS:
  System.Void set_NamespaceURI(System.String value)
  System.Xml.Schema.SchemaInfo get_SchemaInfo()
  System.Void set_SchemaInfo(System.Xml.Schema.SchemaInfo value)
  System.Xml.Schema.XmlSchema get_Schema()
  System.Void set_Schema(System.Xml.Schema.XmlSchema value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaCollectionEnumerator
TYPE:  class
TOKEN: 0x2000218
FIELDS:
  private           System.Collections.IDictionaryEnumeratorenumerator  // 0x10
METHODS:
  System.Void .ctor(System.Collections.Hashtable collection)
  System.Void System.Collections.IEnumerator.Reset()
  System.Boolean System.Collections.IEnumerator.MoveNext()
  System.Boolean MoveNext()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Xml.Schema.XmlSchema get_Current()
  System.Xml.Schema.XmlSchemaCollectionNode get_CurrentNode()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaCompilationSettings
TYPE:  class
TOKEN: 0x2000219
FIELDS:
  private           System.Boolean                  enableUpaCheck  // 0x10
METHODS:
  System.Void .ctor()
  System.Boolean get_EnableUpaCheck()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaComplexContent
TYPE:  class
TOKEN: 0x200021A
EXTENDS: XmlSchemaContentModel
FIELDS:
  private           System.Xml.Schema.XmlSchemaContentcontent  // 0x50
  private           System.Boolean                  isMixed  // 0x58
  private           System.Boolean                  hasMixedAttribute  // 0x59
METHODS:
  System.Boolean get_IsMixed()
  System.Void set_IsMixed(System.Boolean value)
  System.Xml.Schema.XmlSchemaContent get_Content()
  System.Void set_Content(System.Xml.Schema.XmlSchemaContent value)
  System.Boolean get_HasMixedAttribute()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaComplexContentExtension
TYPE:  class
TOKEN: 0x200021B
EXTENDS: XmlSchemaContent
FIELDS:
  private           System.Xml.Schema.XmlSchemaParticleparticle  // 0x50
  private           System.Xml.Schema.XmlSchemaObjectCollectionattributes  // 0x58
  private           System.Xml.Schema.XmlSchemaAnyAttributeanyAttribute  // 0x60
  private           System.Xml.XmlQualifiedName     baseTypeName  // 0x68
METHODS:
  System.Xml.XmlQualifiedName get_BaseTypeName()
  System.Void set_BaseTypeName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.XmlSchemaParticle get_Particle()
  System.Void set_Particle(System.Xml.Schema.XmlSchemaParticle value)
  System.Xml.Schema.XmlSchemaObjectCollection get_Attributes()
  System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute()
  System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value)
  System.Void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaComplexContentRestriction
TYPE:  class
TOKEN: 0x200021C
EXTENDS: XmlSchemaContent
FIELDS:
  private           System.Xml.Schema.XmlSchemaParticleparticle  // 0x50
  private           System.Xml.Schema.XmlSchemaObjectCollectionattributes  // 0x58
  private           System.Xml.Schema.XmlSchemaAnyAttributeanyAttribute  // 0x60
  private           System.Xml.XmlQualifiedName     baseTypeName  // 0x68
METHODS:
  System.Xml.XmlQualifiedName get_BaseTypeName()
  System.Void set_BaseTypeName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.XmlSchemaParticle get_Particle()
  System.Void set_Particle(System.Xml.Schema.XmlSchemaParticle value)
  System.Xml.Schema.XmlSchemaObjectCollection get_Attributes()
  System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute()
  System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value)
  System.Void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaComplexType
TYPE:  class
TOKEN: 0x200021D
EXTENDS: XmlSchemaType
FIELDS:
  private           System.Xml.Schema.XmlSchemaDerivationMethodblock  // 0x98
  private           System.Xml.Schema.XmlSchemaContentModelcontentModel  // 0xA0
  private           System.Xml.Schema.XmlSchemaParticleparticle  // 0xA8
  private           System.Xml.Schema.XmlSchemaObjectCollectionattributes  // 0xB0
  private           System.Xml.Schema.XmlSchemaAnyAttributeanyAttribute  // 0xB8
  private           System.Xml.Schema.XmlSchemaParticlecontentTypeParticle  // 0xC0
  private           System.Xml.Schema.XmlSchemaDerivationMethodblockResolved  // 0xC8
  private           System.Xml.Schema.XmlSchemaObjectTablelocalElements  // 0xD0
  private           System.Xml.Schema.XmlSchemaObjectTableattributeUses  // 0xD8
  private           System.Xml.Schema.XmlSchemaAnyAttributeattributeWildcard  // 0xE0
  private   static  System.Xml.Schema.XmlSchemaComplexTypeanyTypeLax  // 0x0
  private   static  System.Xml.Schema.XmlSchemaComplexTypeanyTypeSkip  // 0x8
  private   static  System.Xml.Schema.XmlSchemaComplexTypeuntypedAnyType  // 0x10
  private           System.Byte                     pvFlags  // 0xE8
METHODS:
  System.Void .cctor()
  System.Xml.Schema.XmlSchemaComplexType CreateAnyType(System.Xml.Schema.XmlSchemaContentProcessing processContents)
  System.Void .ctor()
  System.Xml.Schema.XmlSchemaComplexType get_AnyType()
  System.Xml.Schema.XmlSchemaComplexType get_UntypedAnyType()
  System.Xml.Schema.ContentValidator get_AnyTypeContentValidator()
  System.Boolean get_IsAbstract()
  System.Void set_IsAbstract(System.Boolean value)
  System.Xml.Schema.XmlSchemaDerivationMethod get_Block()
  System.Void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.Boolean get_IsMixed()
  System.Void set_IsMixed(System.Boolean value)
  System.Xml.Schema.XmlSchemaContentModel get_ContentModel()
  System.Void set_ContentModel(System.Xml.Schema.XmlSchemaContentModel value)
  System.Xml.Schema.XmlSchemaParticle get_Particle()
  System.Void set_Particle(System.Xml.Schema.XmlSchemaParticle value)
  System.Xml.Schema.XmlSchemaObjectCollection get_Attributes()
  System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute()
  System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value)
  System.Xml.Schema.XmlSchemaContentType get_ContentType()
  System.Xml.Schema.XmlSchemaParticle get_ContentTypeParticle()
  System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved()
  System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses()
  System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard()
  System.Xml.Schema.XmlSchemaObjectTable get_LocalElements()
  System.Void SetContentTypeParticle(System.Xml.Schema.XmlSchemaParticle value)
  System.Void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.Void SetAttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value)
  System.Void set_HasWildCard(System.Boolean value)
  System.Void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes)
  System.Boolean ContainsIdAttribute(System.Boolean findAll)
  System.Xml.Schema.XmlSchemaObject Clone()
  System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema)
  System.Void ClearCompiledState()
  System.Xml.Schema.XmlSchemaObjectCollection CloneAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes)
  System.Xml.Schema.XmlSchemaObjectCollection CloneGroupBaseParticles(System.Xml.Schema.XmlSchemaObjectCollection groupBaseParticles, System.Xml.Schema.XmlSchema parentSchema)
  System.Xml.Schema.XmlSchemaParticle CloneParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema)
  System.Xml.Schema.XmlSchemaForm GetResolvedElementForm(System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaElement element)
  System.Boolean HasParticleRef(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema)
  System.Boolean HasAttributeQNameRef(System.Xml.Schema.XmlSchemaObjectCollection attributes)
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaContent
TYPE:  class
TOKEN: 0x200021E
EXTENDS: XmlSchemaAnnotated
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaContentModel
TYPE:  class
TOKEN: 0x200021F
EXTENDS: XmlSchemaAnnotated
FIELDS:
METHODS:
  System.Xml.Schema.XmlSchemaContent get_Content()
  System.Void set_Content(System.Xml.Schema.XmlSchemaContent value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaContentProcessing
TYPE:  struct
TOKEN: 0x2000220
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaContentProcessingNone  // 0x0
  public    static  System.Xml.Schema.XmlSchemaContentProcessingSkip  // 0x0
  public    static  System.Xml.Schema.XmlSchemaContentProcessingLax  // 0x0
  public    static  System.Xml.Schema.XmlSchemaContentProcessingStrict  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaContentType
TYPE:  struct
TOKEN: 0x2000221
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaContentTypeTextOnly  // 0x0
  public    static  System.Xml.Schema.XmlSchemaContentTypeEmpty  // 0x0
  public    static  System.Xml.Schema.XmlSchemaContentTypeElementOnly  // 0x0
  public    static  System.Xml.Schema.XmlSchemaContentTypeMixed  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaDatatype
TYPE:  class
TOKEN: 0x2000222
FIELDS:
METHODS:
  System.Type get_ValueType()
  System.Xml.XmlTokenizedType get_TokenizedType()
  System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr)
  System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Boolean IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Boolean get_HasLexicalFacets()
  System.Boolean get_HasValueFacets()
  System.Xml.Schema.XmlValueConverter get_ValueConverter()
  System.Xml.Schema.RestrictionFacets get_Restriction()
  System.Int32 Compare(System.Object value1, System.Object value2)
  System.Object ParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Boolean createAtomicValue)
  System.Exception TryParseValue(System.String s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, System.Object& typedValue)
  System.Exception TryParseValue(System.Object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Object& typedValue)
  System.Xml.Schema.FacetsChecker get_FacetsChecker()
  System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet()
  System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType)
  System.Void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller)
  System.Boolean IsEqual(System.Object o1, System.Object o2)
  System.Boolean IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype)
  System.String get_TypeCodeString()
  System.String TypeCodeToString(System.Xml.Schema.XmlTypeCode typeCode)
  System.String ConcatenatedToString(System.Object value)
  System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedType(System.Xml.XmlTokenizedType token)
  System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token)
  System.Xml.Schema.XmlSchemaDatatype FromXdrName(System.String name)
  System.Xml.Schema.XmlSchemaDatatype DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType)
  System.String XdrCanonizeUri(System.String uri, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaDerivationMethod
TYPE:  struct
TOKEN: 0x2000223
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaDerivationMethodEmpty  // 0x0
  public    static  System.Xml.Schema.XmlSchemaDerivationMethodSubstitution  // 0x0
  public    static  System.Xml.Schema.XmlSchemaDerivationMethodExtension  // 0x0
  public    static  System.Xml.Schema.XmlSchemaDerivationMethodRestriction  // 0x0
  public    static  System.Xml.Schema.XmlSchemaDerivationMethodList  // 0x0
  public    static  System.Xml.Schema.XmlSchemaDerivationMethodUnion  // 0x0
  public    static  System.Xml.Schema.XmlSchemaDerivationMethodAll  // 0x0
  public    static  System.Xml.Schema.XmlSchemaDerivationMethodNone  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaDocumentation
TYPE:  class
TOKEN: 0x2000224
EXTENDS: XmlSchemaObject
FIELDS:
  private           System.String                   source  // 0x38
  private           System.String                   language  // 0x40
  private           System.Xml.XmlNode[]            markup  // 0x48
  private   static  System.Xml.Schema.XmlSchemaSimpleTypelanguageType  // 0x0
METHODS:
  System.Void set_Source(System.String value)
  System.Void set_Language(System.String value)
  System.Void set_Markup(System.Xml.XmlNode[] value)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaElement
TYPE:  class
TOKEN: 0x2000225
EXTENDS: XmlSchemaParticle
FIELDS:
  private           System.Boolean                  isAbstract  // 0x78
  private           System.Boolean                  hasAbstractAttribute  // 0x79
  private           System.Boolean                  isNillable  // 0x7A
  private           System.Boolean                  hasNillableAttribute  // 0x7B
  private           System.Boolean                  isLocalTypeDerivationChecked  // 0x7C
  private           System.Xml.Schema.XmlSchemaDerivationMethodblock  // 0x80
  private           System.Xml.Schema.XmlSchemaDerivationMethodfinal  // 0x84
  private           System.Xml.Schema.XmlSchemaForm form  // 0x88
  private           System.String                   defaultValue  // 0x90
  private           System.String                   fixedValue  // 0x98
  private           System.String                   name  // 0xA0
  private           System.Xml.XmlQualifiedName     refName  // 0xA8
  private           System.Xml.XmlQualifiedName     substitutionGroup  // 0xB0
  private           System.Xml.XmlQualifiedName     typeName  // 0xB8
  private           System.Xml.Schema.XmlSchemaType type  // 0xC0
  private           System.Xml.XmlQualifiedName     qualifiedName  // 0xC8
  private           System.Xml.Schema.XmlSchemaType elementType  // 0xD0
  private           System.Xml.Schema.XmlSchemaDerivationMethodblockResolved  // 0xD8
  private           System.Xml.Schema.XmlSchemaDerivationMethodfinalResolved  // 0xDC
  private           System.Xml.Schema.XmlSchemaObjectCollectionconstraints  // 0xE0
  private           System.Xml.Schema.SchemaElementDeclelementDecl  // 0xE8
METHODS:
  System.Boolean get_IsAbstract()
  System.Void set_IsAbstract(System.Boolean value)
  System.Xml.Schema.XmlSchemaDerivationMethod get_Block()
  System.Void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.String get_DefaultValue()
  System.Void set_DefaultValue(System.String value)
  System.Xml.Schema.XmlSchemaDerivationMethod get_Final()
  System.Void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.String get_FixedValue()
  System.Void set_FixedValue(System.String value)
  System.Xml.Schema.XmlSchemaForm get_Form()
  System.Void set_Form(System.Xml.Schema.XmlSchemaForm value)
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Boolean get_IsNillable()
  System.Void set_IsNillable(System.Boolean value)
  System.Boolean get_HasNillableAttribute()
  System.Boolean get_HasAbstractAttribute()
  System.Xml.XmlQualifiedName get_RefName()
  System.Void set_RefName(System.Xml.XmlQualifiedName value)
  System.Xml.XmlQualifiedName get_SubstitutionGroup()
  System.Void set_SubstitutionGroup(System.Xml.XmlQualifiedName value)
  System.Xml.XmlQualifiedName get_SchemaTypeName()
  System.Void set_SchemaTypeName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.XmlSchemaType get_SchemaType()
  System.Void set_SchemaType(System.Xml.Schema.XmlSchemaType value)
  System.Xml.Schema.XmlSchemaObjectCollection get_Constraints()
  System.Xml.XmlQualifiedName get_QualifiedName()
  System.Xml.Schema.XmlSchemaType get_ElementSchemaType()
  System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved()
  System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved()
  System.Void SetQualifiedName(System.Xml.XmlQualifiedName value)
  System.Void SetElementType(System.Xml.Schema.XmlSchemaType value)
  System.Void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.Void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.Boolean get_HasConstraints()
  System.Boolean get_IsLocalTypeDerivationChecked()
  System.Void set_IsLocalTypeDerivationChecked(System.Boolean value)
  System.Xml.Schema.SchemaElementDecl get_ElementDecl()
  System.Void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value)
  System.String get_NameAttribute()
  System.Void set_NameAttribute(System.String value)
  System.String get_NameString()
  System.Xml.Schema.XmlSchemaObject Clone()
  System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaException
TYPE:  class
TOKEN: 0x2000226
EXTENDS: SystemException
FIELDS:
  private           System.String                   res  // 0x90
  private           System.String[]                 args  // 0x98
  private           System.String                   sourceUri  // 0xA0
  private           System.Int32                    lineNumber  // 0xA8
  private           System.Int32                    linePosition  // 0xAC
  private           System.Xml.Schema.XmlSchemaObjectsourceSchemaObject  // 0xB0
  private           System.String                   message  // 0xB8
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
  System.Void .ctor(System.String message, System.Exception innerException, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void .ctor(System.String res, System.String[] args)
  System.Void .ctor(System.String res, System.String arg)
  System.Void .ctor(System.String res, System.String arg, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void .ctor(System.String res, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void .ctor(System.String res, System.String[] args, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void .ctor(System.String res, System.Xml.Schema.XmlSchemaObject source)
  System.Void .ctor(System.String res, System.String arg, System.Xml.Schema.XmlSchemaObject source)
  System.Void .ctor(System.String res, System.String[] args, System.Xml.Schema.XmlSchemaObject source)
  System.Void .ctor(System.String res, System.String[] args, System.Exception innerException, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition, System.Xml.Schema.XmlSchemaObject source)
  System.String CreateMessage(System.String res, System.String[] args)
  System.String get_GetRes()
  System.String[] get_Args()
  System.String get_SourceUri()
  System.Int32 get_LineNumber()
  System.Int32 get_LinePosition()
  System.Xml.Schema.XmlSchemaObject get_SourceSchemaObject()
  System.Void SetSource(System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void SetSchemaObject(System.Xml.Schema.XmlSchemaObject source)
  System.Void SetSource(System.Xml.Schema.XmlSchemaObject source)
  System.String get_Message()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaExternal
TYPE:  class
TOKEN: 0x2000227
EXTENDS: XmlSchemaObject
FIELDS:
  private           System.String                   location  // 0x38
  private           System.Uri                      baseUri  // 0x40
  private           System.Xml.Schema.XmlSchema     schema  // 0x48
  private           System.String                   id  // 0x50
  private           System.Xml.XmlAttribute[]       moreAttributes  // 0x58
  private           System.Xml.Schema.Compositor    compositor  // 0x60
METHODS:
  System.String get_SchemaLocation()
  System.Void set_SchemaLocation(System.String value)
  System.Xml.Schema.XmlSchema get_Schema()
  System.Void set_Schema(System.Xml.Schema.XmlSchema value)
  System.String get_Id()
  System.Void set_Id(System.String value)
  System.Uri get_BaseUri()
  System.Void set_BaseUri(System.Uri value)
  System.String get_IdAttribute()
  System.Void set_IdAttribute(System.String value)
  System.Void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes)
  System.Xml.Schema.Compositor get_Compositor()
  System.Void set_Compositor(System.Xml.Schema.Compositor value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.FacetType
TYPE:  struct
TOKEN: 0x2000228
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.FacetType     None  // 0x0
  public    static  System.Xml.Schema.FacetType     Length  // 0x0
  public    static  System.Xml.Schema.FacetType     MinLength  // 0x0
  public    static  System.Xml.Schema.FacetType     MaxLength  // 0x0
  public    static  System.Xml.Schema.FacetType     Pattern  // 0x0
  public    static  System.Xml.Schema.FacetType     Whitespace  // 0x0
  public    static  System.Xml.Schema.FacetType     Enumeration  // 0x0
  public    static  System.Xml.Schema.FacetType     MinExclusive  // 0x0
  public    static  System.Xml.Schema.FacetType     MinInclusive  // 0x0
  public    static  System.Xml.Schema.FacetType     MaxExclusive  // 0x0
  public    static  System.Xml.Schema.FacetType     MaxInclusive  // 0x0
  public    static  System.Xml.Schema.FacetType     TotalDigits  // 0x0
  public    static  System.Xml.Schema.FacetType     FractionDigits  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaFacet
TYPE:  class
TOKEN: 0x2000229
EXTENDS: XmlSchemaAnnotated
FIELDS:
  private           System.String                   value  // 0x50
  private           System.Boolean                  isFixed  // 0x58
  private           System.Xml.Schema.FacetType     facetType  // 0x5C
METHODS:
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Boolean get_IsFixed()
  System.Void set_IsFixed(System.Boolean value)
  System.Xml.Schema.FacetType get_FacetType()
  System.Void set_FacetType(System.Xml.Schema.FacetType value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaNumericFacet
TYPE:  class
TOKEN: 0x200022A
EXTENDS: XmlSchemaFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaLengthFacet
TYPE:  class
TOKEN: 0x200022B
EXTENDS: XmlSchemaNumericFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaMinLengthFacet
TYPE:  class
TOKEN: 0x200022C
EXTENDS: XmlSchemaNumericFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaMaxLengthFacet
TYPE:  class
TOKEN: 0x200022D
EXTENDS: XmlSchemaNumericFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaPatternFacet
TYPE:  class
TOKEN: 0x200022E
EXTENDS: XmlSchemaFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaEnumerationFacet
TYPE:  class
TOKEN: 0x200022F
EXTENDS: XmlSchemaFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaMinExclusiveFacet
TYPE:  class
TOKEN: 0x2000230
EXTENDS: XmlSchemaFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaMinInclusiveFacet
TYPE:  class
TOKEN: 0x2000231
EXTENDS: XmlSchemaFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaMaxExclusiveFacet
TYPE:  class
TOKEN: 0x2000232
EXTENDS: XmlSchemaFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaMaxInclusiveFacet
TYPE:  class
TOKEN: 0x2000233
EXTENDS: XmlSchemaFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaTotalDigitsFacet
TYPE:  class
TOKEN: 0x2000234
EXTENDS: XmlSchemaNumericFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaFractionDigitsFacet
TYPE:  class
TOKEN: 0x2000235
EXTENDS: XmlSchemaNumericFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaWhiteSpaceFacet
TYPE:  class
TOKEN: 0x2000236
EXTENDS: XmlSchemaFacet
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaForm
TYPE:  struct
TOKEN: 0x2000237
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaForm None  // 0x0
  public    static  System.Xml.Schema.XmlSchemaForm Qualified  // 0x0
  public    static  System.Xml.Schema.XmlSchemaForm Unqualified  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaGroup
TYPE:  class
TOKEN: 0x2000238
EXTENDS: XmlSchemaAnnotated
FIELDS:
  private           System.String                   name  // 0x50
  private           System.Xml.Schema.XmlSchemaGroupBaseparticle  // 0x58
  private           System.Xml.Schema.XmlSchemaParticlecanonicalParticle  // 0x60
  private           System.Xml.XmlQualifiedName     qname  // 0x68
  private           System.Xml.Schema.XmlSchemaGroupredefined  // 0x70
  private           System.Int32                    selfReferenceCount  // 0x78
METHODS:
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Xml.Schema.XmlSchemaGroupBase get_Particle()
  System.Void set_Particle(System.Xml.Schema.XmlSchemaGroupBase value)
  System.Xml.XmlQualifiedName get_QualifiedName()
  System.Xml.Schema.XmlSchemaParticle get_CanonicalParticle()
  System.Void set_CanonicalParticle(System.Xml.Schema.XmlSchemaParticle value)
  System.Xml.Schema.XmlSchemaGroup get_Redefined()
  System.Void set_Redefined(System.Xml.Schema.XmlSchemaGroup value)
  System.Int32 get_SelfReferenceCount()
  System.Void set_SelfReferenceCount(System.Int32 value)
  System.String get_NameAttribute()
  System.Void set_NameAttribute(System.String value)
  System.Void SetQualifiedName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.XmlSchemaObject Clone()
  System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaGroupBase
TYPE:  class
TOKEN: 0x2000239
EXTENDS: XmlSchemaParticle
FIELDS:
METHODS:
  System.Xml.Schema.XmlSchemaObjectCollection get_Items()
  System.Void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaGroupRef
TYPE:  class
TOKEN: 0x200023A
EXTENDS: XmlSchemaParticle
FIELDS:
  private           System.Xml.XmlQualifiedName     refName  // 0x78
  private           System.Xml.Schema.XmlSchemaGroupBaseparticle  // 0x80
  private           System.Xml.Schema.XmlSchemaGrouprefined  // 0x88
METHODS:
  System.Xml.XmlQualifiedName get_RefName()
  System.Void set_RefName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.XmlSchemaGroupBase get_Particle()
  System.Void SetParticle(System.Xml.Schema.XmlSchemaGroupBase value)
  System.Xml.Schema.XmlSchemaGroup get_Redefined()
  System.Void set_Redefined(System.Xml.Schema.XmlSchemaGroup value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaIdentityConstraint
TYPE:  class
TOKEN: 0x200023B
EXTENDS: XmlSchemaAnnotated
FIELDS:
  private           System.String                   name  // 0x50
  private           System.Xml.Schema.XmlSchemaXPathselector  // 0x58
  private           System.Xml.Schema.XmlSchemaObjectCollectionfields  // 0x60
  private           System.Xml.XmlQualifiedName     qualifiedName  // 0x68
  private           System.Xml.Schema.CompiledIdentityConstraintcompiledConstraint  // 0x70
METHODS:
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Xml.Schema.XmlSchemaXPath get_Selector()
  System.Void set_Selector(System.Xml.Schema.XmlSchemaXPath value)
  System.Xml.Schema.XmlSchemaObjectCollection get_Fields()
  System.Xml.XmlQualifiedName get_QualifiedName()
  System.Void SetQualifiedName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.CompiledIdentityConstraint get_CompiledConstraint()
  System.Void set_CompiledConstraint(System.Xml.Schema.CompiledIdentityConstraint value)
  System.String get_NameAttribute()
  System.Void set_NameAttribute(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaXPath
TYPE:  class
TOKEN: 0x200023C
EXTENDS: XmlSchemaAnnotated
FIELDS:
  private           System.String                   xpath  // 0x50
METHODS:
  System.String get_XPath()
  System.Void set_XPath(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaUnique
TYPE:  class
TOKEN: 0x200023D
EXTENDS: XmlSchemaIdentityConstraint
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaKey
TYPE:  class
TOKEN: 0x200023E
EXTENDS: XmlSchemaIdentityConstraint
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaKeyref
TYPE:  class
TOKEN: 0x200023F
EXTENDS: XmlSchemaIdentityConstraint
FIELDS:
  private           System.Xml.XmlQualifiedName     refer  // 0x78
METHODS:
  System.Xml.XmlQualifiedName get_Refer()
  System.Void set_Refer(System.Xml.XmlQualifiedName value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaImport
TYPE:  class
TOKEN: 0x2000240
EXTENDS: XmlSchemaExternal
FIELDS:
  private           System.String                   ns  // 0x68
  private           System.Xml.Schema.XmlSchemaAnnotationannotation  // 0x70
METHODS:
  System.Void .ctor()
  System.String get_Namespace()
  System.Void set_Namespace(System.String value)
  System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation)
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaInclude
TYPE:  class
TOKEN: 0x2000241
EXTENDS: XmlSchemaExternal
FIELDS:
  private           System.Xml.Schema.XmlSchemaAnnotationannotation  // 0x68
METHODS:
  System.Void .ctor()
  System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation)
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaInfo
TYPE:  class
TOKEN: 0x2000242
FIELDS:
  private           System.Boolean                  isDefault  // 0x10
  private           System.Boolean                  isNil  // 0x11
  private           System.Xml.Schema.XmlSchemaElementschemaElement  // 0x18
  private           System.Xml.Schema.XmlSchemaAttributeschemaAttribute  // 0x20
  private           System.Xml.Schema.XmlSchemaType schemaType  // 0x28
  private           System.Xml.Schema.XmlSchemaSimpleTypememberType  // 0x30
  private           System.Xml.Schema.XmlSchemaValidityvalidity  // 0x38
  private           System.Xml.Schema.XmlSchemaContentTypecontentType  // 0x3C
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Xml.Schema.XmlSchemaValidity validity)
  System.Xml.Schema.XmlSchemaValidity get_Validity()
  System.Void set_Validity(System.Xml.Schema.XmlSchemaValidity value)
  System.Boolean get_IsDefault()
  System.Void set_IsDefault(System.Boolean value)
  System.Boolean get_IsNil()
  System.Void set_IsNil(System.Boolean value)
  System.Xml.Schema.XmlSchemaSimpleType get_MemberType()
  System.Void set_MemberType(System.Xml.Schema.XmlSchemaSimpleType value)
  System.Xml.Schema.XmlSchemaType get_SchemaType()
  System.Void set_SchemaType(System.Xml.Schema.XmlSchemaType value)
  System.Xml.Schema.XmlSchemaElement get_SchemaElement()
  System.Void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value)
  System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute()
  System.Void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value)
  System.Xml.Schema.XmlSchemaContentType get_ContentType()
  System.Xml.Schema.XmlSchemaType get_XmlType()
  System.Boolean get_HasDefaultValue()
  System.Boolean get_IsUnionType()
  System.Void Clear()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaNotation
TYPE:  class
TOKEN: 0x2000243
EXTENDS: XmlSchemaAnnotated
FIELDS:
  private           System.String                   name  // 0x50
  private           System.String                   publicId  // 0x58
  private           System.String                   systemId  // 0x60
  private           System.Xml.XmlQualifiedName     qname  // 0x68
METHODS:
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.String get_Public()
  System.Void set_Public(System.String value)
  System.String get_System()
  System.Void set_System(System.String value)
  System.Xml.XmlQualifiedName get_QualifiedName()
  System.Void set_QualifiedName(System.Xml.XmlQualifiedName value)
  System.String get_NameAttribute()
  System.Void set_NameAttribute(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaObject
TYPE:  class
TOKEN: 0x2000244
FIELDS:
  private           System.Int32                    lineNum  // 0x10
  private           System.Int32                    linePos  // 0x14
  private           System.String                   sourceUri  // 0x18
  private           System.Xml.Serialization.XmlSerializerNamespacesnamespaces  // 0x20
  private           System.Xml.Schema.XmlSchemaObjectparent  // 0x28
  private           System.Boolean                  isProcessing  // 0x30
METHODS:
  System.Int32 get_LineNumber()
  System.Void set_LineNumber(System.Int32 value)
  System.Int32 get_LinePosition()
  System.Void set_LinePosition(System.Int32 value)
  System.String get_SourceUri()
  System.Void set_SourceUri(System.String value)
  System.Xml.Schema.XmlSchemaObject get_Parent()
  System.Void set_Parent(System.Xml.Schema.XmlSchemaObject value)
  System.Xml.Serialization.XmlSerializerNamespaces get_Namespaces()
  System.Void set_Namespaces(System.Xml.Serialization.XmlSerializerNamespaces value)
  System.Void OnAdd(System.Xml.Schema.XmlSchemaObjectCollection container, System.Object item)
  System.Void OnRemove(System.Xml.Schema.XmlSchemaObjectCollection container, System.Object item)
  System.Void OnClear(System.Xml.Schema.XmlSchemaObjectCollection container)
  System.String get_IdAttribute()
  System.Void set_IdAttribute(System.String value)
  System.Void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes)
  System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation)
  System.String get_NameAttribute()
  System.Void set_NameAttribute(System.String value)
  System.Boolean get_IsProcessing()
  System.Void set_IsProcessing(System.Boolean value)
  System.Xml.Schema.XmlSchemaObject Clone()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaObjectCollection
TYPE:  class
TOKEN: 0x2000245
EXTENDS: CollectionBase
FIELDS:
  private           System.Xml.Schema.XmlSchemaObjectparent  // 0x18
METHODS:
  System.Void .ctor()
  System.Xml.Schema.XmlSchemaObject get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Xml.Schema.XmlSchemaObject value)
  System.Xml.Schema.XmlSchemaObjectEnumerator GetEnumerator()
  System.Int32 Add(System.Xml.Schema.XmlSchemaObject item)
  System.Void Insert(System.Int32 index, System.Xml.Schema.XmlSchemaObject item)
  System.Void Remove(System.Xml.Schema.XmlSchemaObject item)
  System.Void OnInsert(System.Int32 index, System.Object item)
  System.Void OnSet(System.Int32 index, System.Object oldValue, System.Object newValue)
  System.Void OnClear()
  System.Void OnRemove(System.Int32 index, System.Object item)
  System.Xml.Schema.XmlSchemaObjectCollection Clone()
  System.Void Add(System.Xml.Schema.XmlSchemaObjectCollection collToAdd)
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaObjectEnumerator
TYPE:  class
TOKEN: 0x2000246
FIELDS:
  private           System.Collections.IEnumerator  enumerator  // 0x10
METHODS:
  System.Void .ctor(System.Collections.IEnumerator enumerator)
  System.Boolean MoveNext()
  System.Xml.Schema.XmlSchemaObject get_Current()
  System.Void System.Collections.IEnumerator.Reset()
  System.Boolean System.Collections.IEnumerator.MoveNext()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaObjectTable
TYPE:  class
TOKEN: 0x2000247
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaObject>table  // 0x10
  private           System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry>entries  // 0x18
METHODS:
  System.Void .ctor()
  System.Void Add(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value)
  System.Void Insert(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value)
  System.Void Replace(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value)
  System.Void Clear()
  System.Void Remove(System.Xml.XmlQualifiedName name)
  System.Int32 FindIndexByValue(System.Xml.Schema.XmlSchemaObject xso)
  System.Int32 get_Count()
  System.Boolean Contains(System.Xml.XmlQualifiedName name)
  System.Xml.Schema.XmlSchemaObject get_Item(System.Xml.XmlQualifiedName name)
  System.Collections.ICollection get_Values()
  System.Collections.IDictionaryEnumerator GetEnumerator()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaParticle
TYPE:  class
TOKEN: 0x200024D
EXTENDS: XmlSchemaAnnotated
FIELDS:
  private           System.Decimal                  minOccurs  // 0x50
  private           System.Decimal                  maxOccurs  // 0x60
  private           System.Xml.Schema.XmlSchemaParticle.Occursflags  // 0x70
  private   static readonly System.Xml.Schema.XmlSchemaParticleEmpty  // 0x0
METHODS:
  System.String get_MinOccursString()
  System.Void set_MinOccursString(System.String value)
  System.String get_MaxOccursString()
  System.Void set_MaxOccursString(System.String value)
  System.Decimal get_MinOccurs()
  System.Void set_MinOccurs(System.Decimal value)
  System.Decimal get_MaxOccurs()
  System.Void set_MaxOccurs(System.Decimal value)
  System.Boolean get_IsEmpty()
  System.String get_NameString()
  System.Xml.XmlQualifiedName GetQualifiedName()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaRedefine
TYPE:  class
TOKEN: 0x2000250
EXTENDS: XmlSchemaExternal
FIELDS:
  private           System.Xml.Schema.XmlSchemaObjectCollectionitems  // 0x68
  private           System.Xml.Schema.XmlSchemaObjectTableattributeGroups  // 0x70
  private           System.Xml.Schema.XmlSchemaObjectTabletypes  // 0x78
  private           System.Xml.Schema.XmlSchemaObjectTablegroups  // 0x80
METHODS:
  System.Void .ctor()
  System.Xml.Schema.XmlSchemaObjectCollection get_Items()
  System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups()
  System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes()
  System.Xml.Schema.XmlSchemaObjectTable get_Groups()
  System.Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation)
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSequence
TYPE:  class
TOKEN: 0x2000251
EXTENDS: XmlSchemaGroupBase
FIELDS:
  private           System.Xml.Schema.XmlSchemaObjectCollectionitems  // 0x78
METHODS:
  System.Xml.Schema.XmlSchemaObjectCollection get_Items()
  System.Boolean get_IsEmpty()
  System.Void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSet
TYPE:  class
TOKEN: 0x2000252
FIELDS:
  private           System.Xml.XmlNameTable         nameTable  // 0x10
  private           System.Xml.Schema.SchemaNames   schemaNames  // 0x18
  private           System.Collections.SortedList   schemas  // 0x20
  private           System.Xml.Schema.ValidationEventHandlerinternalEventHandler  // 0x28
  private           System.Xml.Schema.ValidationEventHandlereventHandler  // 0x30
  private           System.Boolean                  isCompiled  // 0x38
  private           System.Collections.Hashtable    schemaLocations  // 0x40
  private           System.Collections.Hashtable    chameleonSchemas  // 0x48
  private           System.Collections.Hashtable    targetNamespaces  // 0x50
  private           System.Boolean                  compileAll  // 0x58
  private           System.Xml.Schema.SchemaInfo    cachedCompiledInfo  // 0x60
  private           System.Xml.XmlReaderSettings    readerSettings  // 0x68
  private           System.Xml.Schema.XmlSchema     schemaForSchema  // 0x70
  private           System.Xml.Schema.XmlSchemaCompilationSettingscompilationSettings  // 0x78
  private           System.Xml.Schema.XmlSchemaObjectTableelements  // 0x80
  private           System.Xml.Schema.XmlSchemaObjectTableattributes  // 0x88
  private           System.Xml.Schema.XmlSchemaObjectTableschemaTypes  // 0x90
  private           System.Xml.Schema.XmlSchemaObjectTablesubstitutionGroups  // 0x98
  private           System.Xml.Schema.XmlSchemaObjectTabletypeExtensions  // 0xA0
  private           System.Object                   internalSyncObject  // 0xA8
METHODS:
  System.Object get_InternalSyncObject()
  System.Void .ctor()
  System.Void .ctor(System.Xml.XmlNameTable nameTable)
  System.Void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value)
  System.Void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value)
  System.Boolean get_IsCompiled()
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings()
  System.Void set_CompilationSettings(System.Xml.Schema.XmlSchemaCompilationSettings value)
  System.Int32 get_Count()
  System.Xml.Schema.XmlSchemaObjectTable get_GlobalElements()
  System.Xml.Schema.XmlSchemaObjectTable get_GlobalAttributes()
  System.Xml.Schema.XmlSchemaObjectTable get_GlobalTypes()
  System.Xml.Schema.XmlSchemaObjectTable get_SubstitutionGroups()
  System.Collections.Hashtable get_SchemaLocations()
  System.Xml.Schema.XmlSchemaObjectTable get_TypeExtensions()
  System.Void Add(System.Xml.Schema.XmlSchemaSet schemas)
  System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema)
  System.Boolean RemoveRecursive(System.Xml.Schema.XmlSchema schemaToRemove)
  System.Boolean Contains(System.String targetNamespace)
  System.Void Compile()
  System.Xml.Schema.XmlSchema Reprocess(System.Xml.Schema.XmlSchema schema)
  System.Void CopyTo(System.Xml.Schema.XmlSchema[] schemas, System.Int32 index)
  System.Collections.ICollection Schemas()
  System.Collections.ICollection Schemas(System.String targetNamespace)
  System.Xml.Schema.XmlSchema Add(System.String targetNamespace, System.Xml.Schema.XmlSchema schema)
  System.Void Add(System.String targetNamespace, System.Xml.XmlReader reader, System.Collections.Hashtable validatedNamespaces)
  System.Xml.Schema.XmlSchema FindSchemaByNSAndUrl(System.Uri schemaUri, System.String ns, System.Collections.DictionaryEntry[] locationsTable)
  System.Void AddSchemaToSet(System.Xml.Schema.XmlSchema schema)
  System.Void ProcessNewSubstitutionGroups(System.Xml.Schema.XmlSchemaObjectTable substitutionGroupsTable, System.Boolean resolve)
  System.Void ResolveSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup, System.Xml.Schema.XmlSchemaObjectTable substTable)
  System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema schema, System.Boolean forceCompile)
  System.Void ClearTables()
  System.Boolean PreprocessSchema(System.Xml.Schema.XmlSchema& schema, System.String targetNamespace)
  System.Xml.Schema.XmlSchema ParseSchema(System.String targetNamespace, System.Xml.XmlReader reader)
  System.Void CopyFromCompiledSet(System.Xml.Schema.XmlSchemaSet otherSet)
  System.Xml.Schema.SchemaInfo get_CompiledInfo()
  System.Xml.XmlReaderSettings get_ReaderSettings()
  System.Xml.XmlResolver GetResolver()
  System.Xml.Schema.ValidationEventHandler GetEventHandler()
  System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt)
  System.Boolean IsSchemaLoaded(System.Uri schemaUri, System.String targetNamespace, System.Xml.Schema.XmlSchema& schema)
  System.Boolean GetSchemaByUri(System.Uri schemaUri, System.Xml.Schema.XmlSchema& schema)
  System.String GetTargetNamespace(System.Xml.Schema.XmlSchema schema)
  System.Collections.SortedList get_SortedSchemas()
  System.Void RemoveSchemaFromCaches(System.Xml.Schema.XmlSchema schema)
  System.Void RemoveSchemaFromGlobalTables(System.Xml.Schema.XmlSchema schema)
  System.Boolean AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item)
  System.Void VerifyTables()
  System.Void InternalValidationCallback(System.Object sender, System.Xml.Schema.ValidationEventArgs e)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity)
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSimpleContent
TYPE:  class
TOKEN: 0x2000253
EXTENDS: XmlSchemaContentModel
FIELDS:
  private           System.Xml.Schema.XmlSchemaContentcontent  // 0x50
METHODS:
  System.Xml.Schema.XmlSchemaContent get_Content()
  System.Void set_Content(System.Xml.Schema.XmlSchemaContent value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSimpleContentExtension
TYPE:  class
TOKEN: 0x2000254
EXTENDS: XmlSchemaContent
FIELDS:
  private           System.Xml.Schema.XmlSchemaObjectCollectionattributes  // 0x50
  private           System.Xml.Schema.XmlSchemaAnyAttributeanyAttribute  // 0x58
  private           System.Xml.XmlQualifiedName     baseTypeName  // 0x60
METHODS:
  System.Xml.XmlQualifiedName get_BaseTypeName()
  System.Void set_BaseTypeName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.XmlSchemaObjectCollection get_Attributes()
  System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute()
  System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value)
  System.Void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSimpleContentRestriction
TYPE:  class
TOKEN: 0x2000255
EXTENDS: XmlSchemaContent
FIELDS:
  private           System.Xml.XmlQualifiedName     baseTypeName  // 0x50
  private           System.Xml.Schema.XmlSchemaSimpleTypebaseType  // 0x58
  private           System.Xml.Schema.XmlSchemaObjectCollectionfacets  // 0x60
  private           System.Xml.Schema.XmlSchemaObjectCollectionattributes  // 0x68
  private           System.Xml.Schema.XmlSchemaAnyAttributeanyAttribute  // 0x70
METHODS:
  System.Xml.XmlQualifiedName get_BaseTypeName()
  System.Void set_BaseTypeName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.XmlSchemaSimpleType get_BaseType()
  System.Void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value)
  System.Xml.Schema.XmlSchemaObjectCollection get_Facets()
  System.Xml.Schema.XmlSchemaObjectCollection get_Attributes()
  System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute()
  System.Void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value)
  System.Void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSimpleType
TYPE:  class
TOKEN: 0x2000256
EXTENDS: XmlSchemaType
FIELDS:
  private           System.Xml.Schema.XmlSchemaSimpleTypeContentcontent  // 0x98
METHODS:
  System.Void .ctor()
  System.Xml.Schema.XmlSchemaSimpleTypeContent get_Content()
  System.Void set_Content(System.Xml.Schema.XmlSchemaSimpleTypeContent value)
  System.Xml.Schema.XmlSchemaObject Clone()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSimpleTypeContent
TYPE:  class
TOKEN: 0x2000257
EXTENDS: XmlSchemaAnnotated
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSimpleTypeList
TYPE:  class
TOKEN: 0x2000258
EXTENDS: XmlSchemaSimpleTypeContent
FIELDS:
  private           System.Xml.XmlQualifiedName     itemTypeName  // 0x50
  private           System.Xml.Schema.XmlSchemaSimpleTypeitemType  // 0x58
  private           System.Xml.Schema.XmlSchemaSimpleTypebaseItemType  // 0x60
METHODS:
  System.Xml.XmlQualifiedName get_ItemTypeName()
  System.Void set_ItemTypeName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.XmlSchemaSimpleType get_ItemType()
  System.Void set_ItemType(System.Xml.Schema.XmlSchemaSimpleType value)
  System.Xml.Schema.XmlSchemaSimpleType get_BaseItemType()
  System.Void set_BaseItemType(System.Xml.Schema.XmlSchemaSimpleType value)
  System.Xml.Schema.XmlSchemaObject Clone()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSimpleTypeRestriction
TYPE:  class
TOKEN: 0x2000259
EXTENDS: XmlSchemaSimpleTypeContent
FIELDS:
  private           System.Xml.XmlQualifiedName     baseTypeName  // 0x50
  private           System.Xml.Schema.XmlSchemaSimpleTypebaseType  // 0x58
  private           System.Xml.Schema.XmlSchemaObjectCollectionfacets  // 0x60
METHODS:
  System.Xml.XmlQualifiedName get_BaseTypeName()
  System.Void set_BaseTypeName(System.Xml.XmlQualifiedName value)
  System.Xml.Schema.XmlSchemaSimpleType get_BaseType()
  System.Void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value)
  System.Xml.Schema.XmlSchemaObjectCollection get_Facets()
  System.Xml.Schema.XmlSchemaObject Clone()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSimpleTypeUnion
TYPE:  class
TOKEN: 0x200025A
EXTENDS: XmlSchemaSimpleTypeContent
FIELDS:
  private           System.Xml.Schema.XmlSchemaObjectCollectionbaseTypes  // 0x50
  private           System.Xml.XmlQualifiedName[]   memberTypes  // 0x58
  private           System.Xml.Schema.XmlSchemaSimpleType[]baseMemberTypes  // 0x60
METHODS:
  System.Xml.Schema.XmlSchemaObjectCollection get_BaseTypes()
  System.Xml.XmlQualifiedName[] get_MemberTypes()
  System.Void set_MemberTypes(System.Xml.XmlQualifiedName[] value)
  System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes()
  System.Void SetBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes)
  System.Xml.Schema.XmlSchemaObject Clone()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSubstitutionGroup
TYPE:  class
TOKEN: 0x200025B
EXTENDS: XmlSchemaObject
FIELDS:
  private           System.Collections.ArrayList    membersList  // 0x38
  private           System.Xml.XmlQualifiedName     examplar  // 0x40
METHODS:
  System.Collections.ArrayList get_Members()
  System.Xml.XmlQualifiedName get_Examplar()
  System.Void set_Examplar(System.Xml.XmlQualifiedName value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaSubstitutionGroupV1Compat
TYPE:  class
TOKEN: 0x200025C
EXTENDS: XmlSchemaSubstitutionGroup
FIELDS:
  private           System.Xml.Schema.XmlSchemaChoicechoice  // 0x48
METHODS:
  System.Xml.Schema.XmlSchemaChoice get_Choice()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaType
TYPE:  class
TOKEN: 0x200025D
EXTENDS: XmlSchemaAnnotated
FIELDS:
  private           System.String                   name  // 0x50
  private           System.Xml.Schema.XmlSchemaDerivationMethodfinal  // 0x58
  private           System.Xml.Schema.XmlSchemaDerivationMethodderivedBy  // 0x5C
  private           System.Xml.Schema.XmlSchemaType baseSchemaType  // 0x60
  private           System.Xml.Schema.XmlSchemaDatatypedatatype  // 0x68
  private           System.Xml.Schema.XmlSchemaDerivationMethodfinalResolved  // 0x70
  private           System.Xml.Schema.SchemaElementDeclelementDecl  // 0x78
  private           System.Xml.XmlQualifiedName     qname  // 0x80
  private           System.Xml.Schema.XmlSchemaType redefined  // 0x88
  private           System.Xml.Schema.XmlSchemaContentTypecontentType  // 0x90
METHODS:
  System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName qualifiedName)
  System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.Schema.XmlTypeCode typeCode)
  System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName qualifiedName)
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Xml.Schema.XmlSchemaDerivationMethod get_Final()
  System.Void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.Xml.XmlQualifiedName get_QualifiedName()
  System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved()
  System.Xml.Schema.XmlSchemaType get_BaseXmlSchemaType()
  System.Xml.Schema.XmlSchemaDerivationMethod get_DerivedBy()
  System.Xml.Schema.XmlSchemaDatatype get_Datatype()
  System.Boolean get_IsMixed()
  System.Void set_IsMixed(System.Boolean value)
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.Xml.Schema.XmlValueConverter get_ValueConverter()
  System.Xml.Schema.XmlSchemaContentType get_SchemaContentType()
  System.Void SetQualifiedName(System.Xml.XmlQualifiedName value)
  System.Void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.Void SetBaseSchemaType(System.Xml.Schema.XmlSchemaType value)
  System.Void SetDerivedBy(System.Xml.Schema.XmlSchemaDerivationMethod value)
  System.Void SetDatatype(System.Xml.Schema.XmlSchemaDatatype value)
  System.Xml.Schema.SchemaElementDecl get_ElementDecl()
  System.Void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value)
  System.Xml.Schema.XmlSchemaType get_Redefined()
  System.Void set_Redefined(System.Xml.Schema.XmlSchemaType value)
  System.Void SetContentType(System.Xml.Schema.XmlSchemaContentType value)
  System.Boolean IsDerivedFrom(System.Xml.Schema.XmlSchemaType derivedType, System.Xml.Schema.XmlSchemaType baseType, System.Xml.Schema.XmlSchemaDerivationMethod except)
  System.Boolean IsDerivedFromDatatype(System.Xml.Schema.XmlSchemaDatatype derivedDataType, System.Xml.Schema.XmlSchemaDatatype baseDataType, System.Xml.Schema.XmlSchemaDerivationMethod except)
  System.String get_NameAttribute()
  System.Void set_NameAttribute(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaUse
TYPE:  struct
TOKEN: 0x200025E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaUse  None  // 0x0
  public    static  System.Xml.Schema.XmlSchemaUse  Optional  // 0x0
  public    static  System.Xml.Schema.XmlSchemaUse  Prohibited  // 0x0
  public    static  System.Xml.Schema.XmlSchemaUse  Required  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaValidationException
TYPE:  class
TOKEN: 0x200025F
EXTENDS: XmlSchemaException
FIELDS:
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String res, System.String arg, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void .ctor(System.String res, System.String[] args, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition)
  System.Void .ctor(System.String res, System.String[] args, System.Exception innerException, System.String sourceUri, System.Int32 lineNumber, System.Int32 linePosition)
END_CLASS

CLASS: System.Xml.Schema.XmlValueGetter
TYPE:  class
TOKEN: 0x2000260
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Object Invoke()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaValidationFlags
TYPE:  struct
TOKEN: 0x2000261
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaValidationFlagsNone  // 0x0
  public    static  System.Xml.Schema.XmlSchemaValidationFlagsProcessInlineSchema  // 0x0
  public    static  System.Xml.Schema.XmlSchemaValidationFlagsProcessSchemaLocation  // 0x0
  public    static  System.Xml.Schema.XmlSchemaValidationFlagsReportValidationWarnings  // 0x0
  public    static  System.Xml.Schema.XmlSchemaValidationFlagsProcessIdentityConstraints  // 0x0
  public    static  System.Xml.Schema.XmlSchemaValidationFlagsAllowXmlAttributes  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.ValidatorState
TYPE:  struct
TOKEN: 0x2000262
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.ValidatorStateNone  // 0x0
  public    static  System.Xml.Schema.ValidatorStateStart  // 0x0
  public    static  System.Xml.Schema.ValidatorStateTopLevelAttribute  // 0x0
  public    static  System.Xml.Schema.ValidatorStateTopLevelTextOrWS  // 0x0
  public    static  System.Xml.Schema.ValidatorStateElement  // 0x0
  public    static  System.Xml.Schema.ValidatorStateAttribute  // 0x0
  public    static  System.Xml.Schema.ValidatorStateEndOfAttributes  // 0x0
  public    static  System.Xml.Schema.ValidatorStateText  // 0x0
  public    static  System.Xml.Schema.ValidatorStateWhitespace  // 0x0
  public    static  System.Xml.Schema.ValidatorStateEndElement  // 0x0
  public    static  System.Xml.Schema.ValidatorStateSkipToEndElement  // 0x0
  public    static  System.Xml.Schema.ValidatorStateFinish  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.IdRefNode
TYPE:  class
TOKEN: 0x2000263
FIELDS:
  private           System.String                   Id  // 0x10
  private           System.Int32                    LineNo  // 0x18
  private           System.Int32                    LinePos  // 0x1C
  private           System.Xml.Schema.IdRefNode     Next  // 0x20
METHODS:
  System.Void .ctor(System.Xml.Schema.IdRefNode next, System.String id, System.Int32 lineNo, System.Int32 linePos)
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaValidator
TYPE:  class
TOKEN: 0x2000264
FIELDS:
  private           System.Xml.Schema.XmlSchemaSet  schemaSet  // 0x10
  private           System.Xml.Schema.XmlSchemaValidationFlagsvalidationFlags  // 0x18
  private           System.Int32                    startIDConstraint  // 0x1C
  private           System.Boolean                  isRoot  // 0x20
  private           System.Boolean                  rootHasSchema  // 0x21
  private           System.Boolean                  attrValid  // 0x22
  private           System.Boolean                  checkEntity  // 0x23
  private           System.Xml.Schema.SchemaInfo    compiledSchemaInfo  // 0x28
  private           System.Xml.IDtdInfo             dtdSchemaInfo  // 0x30
  private           System.Collections.Hashtable    validatedNamespaces  // 0x38
  private           System.Xml.HWStack              validationStack  // 0x40
  private           System.Xml.Schema.ValidationStatecontext  // 0x48
  private           System.Xml.Schema.ValidatorStatecurrentState  // 0x50
  private           System.Collections.Hashtable    attPresence  // 0x58
  private           System.Xml.Schema.SchemaAttDef  wildID  // 0x60
  private           System.Collections.Hashtable    IDs  // 0x68
  private           System.Xml.Schema.IdRefNode     idRefListHead  // 0x70
  private           System.Xml.XmlQualifiedName     contextQName  // 0x78
  private           System.String                   NsXs  // 0x80
  private           System.String                   NsXsi  // 0x88
  private           System.String                   NsXmlNs  // 0x90
  private           System.String                   NsXml  // 0x98
  private           System.Xml.Schema.XmlSchemaObjectpartialValidationType  // 0xA0
  private           System.Text.StringBuilder       textValue  // 0xA8
  private           System.Xml.Schema.ValidationEventHandlereventHandler  // 0xB0
  private           System.Object                   validationEventSender  // 0xB8
  private           System.Xml.XmlNameTable         nameTable  // 0xC0
  private           System.Xml.IXmlLineInfo         positionInfo  // 0xC8
  private           System.Xml.IXmlLineInfo         dummyPositionInfo  // 0xD0
  private           System.Xml.XmlResolver          xmlResolver  // 0xD8
  private           System.Uri                      sourceUri  // 0xE0
  private           System.String                   sourceUriString  // 0xE8
  private           System.Xml.IXmlNamespaceResolvernsResolver  // 0xF0
  private           System.Xml.Schema.XmlSchemaContentProcessingprocessContents  // 0xF8
  private           System.String                   xsiTypeString  // 0x100
  private           System.String                   xsiNilString  // 0x108
  private           System.String                   xsiSchemaLocationString  // 0x110
  private           System.String                   xsiNoNamespaceSchemaLocationString  // 0x118
  private   static readonly System.Xml.Schema.XmlSchemaDatatypedtQName  // 0x0
  private   static readonly System.Xml.Schema.XmlSchemaDatatypedtCDATA  // 0x8
  private   static readonly System.Xml.Schema.XmlSchemaDatatypedtStringArray  // 0x10
  private   static  System.Xml.Schema.XmlSchemaParticle[]EmptyParticleArray  // 0x18
  private   static  System.Xml.Schema.XmlSchemaAttribute[]EmptyAttributeArray  // 0x20
  private           System.Xml.XmlCharType          xmlCharType  // 0x120
  private   static  System.Boolean[,]               ValidStates  // 0x28
  private   static  System.String[]                 MethodNames  // 0x30
METHODS:
  System.Void .ctor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Xml.Schema.XmlSchemaValidationFlags validationFlags)
  System.Void Init()
  System.Void Reset()
  System.Void set_XmlResolver(System.Xml.XmlResolver value)
  System.Void set_LineInfoProvider(System.Xml.IXmlLineInfo value)
  System.Void set_SourceUri(System.Uri value)
  System.Void set_ValidationEventSender(System.Object value)
  System.Void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value)
  System.Void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value)
  System.Void AddSchema(System.Xml.Schema.XmlSchema schema)
  System.Void Initialize()
  System.Void Initialize(System.Xml.Schema.XmlSchemaObject partialValidationType)
  System.Void ValidateElement(System.String localName, System.String namespaceUri, System.Xml.Schema.XmlSchemaInfo schemaInfo, System.String xsiType, System.String xsiNil, System.String xsiSchemaLocation, System.String xsiNoNamespaceSchemaLocation)
  System.Object ValidateAttribute(System.String localName, System.String namespaceUri, System.Xml.Schema.XmlValueGetter attributeValue, System.Xml.Schema.XmlSchemaInfo schemaInfo)
  System.Object ValidateAttribute(System.String lName, System.String ns, System.Xml.Schema.XmlValueGetter attributeValueGetter, System.String attributeStringValue, System.Xml.Schema.XmlSchemaInfo schemaInfo)
  System.Void ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo schemaInfo)
  System.Void ValidateText(System.Xml.Schema.XmlValueGetter elementValue)
  System.Void ValidateText(System.String elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter)
  System.Void ValidateWhitespace(System.Xml.Schema.XmlValueGetter elementValue)
  System.Void ValidateWhitespace(System.String elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter)
  System.Object ValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo)
  System.Void SkipToEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo)
  System.Void EndValidation()
  System.Void GetUnspecifiedDefaultAttributes(System.Collections.ArrayList defaultAttributes, System.Boolean createNodeData)
  System.Xml.Schema.XmlSchemaSet get_SchemaSet()
  System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags()
  System.Xml.Schema.XmlSchemaContentType get_CurrentContentType()
  System.Void SetDtdSchemaInfo(System.Xml.IDtdInfo dtdSchemaInfo)
  System.Boolean get_StrictlyAssessed()
  System.Boolean get_HasSchema()
  System.String GetConcatenatedValue()
  System.Object InternalValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo, System.Object typedValue)
  System.Void ProcessSchemaLocations(System.String xsiSchemaLocation, System.String xsiNoNamespaceSchemaLocation)
  System.Object ValidateElementContext(System.Xml.XmlQualifiedName elementName, System.Boolean& invalidElementInContext)
  System.Xml.Schema.XmlSchemaElement GetSubstitutionGroupHead(System.Xml.XmlQualifiedName member)
  System.Object ValidateAtomicValue(System.String stringValue, System.Xml.Schema.XmlSchemaSimpleType& memberType)
  System.Object ValidateAtomicValue(System.Object parsedValue, System.Xml.Schema.XmlSchemaSimpleType& memberType)
  System.String GetTypeName(System.Xml.Schema.SchemaDeclBase decl)
  System.Void SaveTextValue(System.Object value)
  System.Void Push(System.Xml.XmlQualifiedName elementName)
  System.Void Pop()
  System.Xml.Schema.SchemaElementDecl FastGetElementDecl(System.Xml.XmlQualifiedName elementName, System.Object particle)
  System.Xml.Schema.SchemaElementDecl CheckXsiTypeAndNil(System.Xml.Schema.SchemaElementDecl elementDecl, System.String xsiType, System.String xsiNil, System.Boolean& declFound)
  System.Void ThrowDeclNotFoundWarningOrError(System.Boolean declFound)
  System.Void CheckElementProperties()
  System.Void ValidateStartElementIdentityConstraints()
  System.Xml.Schema.SchemaAttDef CheckIsXmlAttribute(System.Xml.XmlQualifiedName attQName)
  System.Void AddXmlNamespaceSchema()
  System.Object CheckMixedValueConstraint(System.String elementValue)
  System.Void LoadSchema(System.String uri, System.String url)
  System.Void RecompileSchemaSet()
  System.Void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, System.String name, System.Boolean attrValue)
  System.Object CheckAttributeValue(System.Object value, System.Xml.Schema.SchemaAttDef attdef)
  System.Object CheckElementValue(System.String stringValue)
  System.Void CheckTokenizedTypes(System.Xml.Schema.XmlSchemaDatatype dtype, System.Object typedValue, System.Boolean attrValue)
  System.Object FindId(System.String name)
  System.Void CheckForwardRefs()
  System.Boolean get_HasIdentityConstraints()
  System.Boolean get_ProcessIdentityConstraints()
  System.Boolean get_ReportValidationWarnings()
  System.Boolean get_ProcessSchemaHints()
  System.Void CheckStateTransition(System.Xml.Schema.ValidatorState toState, System.String methodName)
  System.Void ClearPSVI()
  System.Void CheckRequiredAttributes(System.Xml.Schema.SchemaElementDecl currentElementDecl)
  System.Xml.Schema.XmlSchemaElement GetSchemaElement()
  System.String GetDefaultAttributePrefix(System.String attributeNS)
  System.Void AddIdentityConstraints()
  System.Void ElementIdentityConstraints()
  System.Void AttributeIdentityConstraints(System.String name, System.String ns, System.Object obj, System.String sobj, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Void EndElementIdentityConstraints(System.Object typedValue, System.String stringValue, System.Xml.Schema.XmlSchemaDatatype datatype)
  System.Void ElementValidationError(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, System.Object sender, System.String sourceUri, System.Int32 lineNo, System.Int32 linePos, System.Xml.Schema.XmlSchemaSet schemaSet)
  System.Void CompleteValidationError(System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, System.Object sender, System.String sourceUri, System.Int32 lineNo, System.Int32 linePos, System.Xml.Schema.XmlSchemaSet schemaSet)
  System.String PrintExpectedElements(System.Collections.ArrayList expected, System.Boolean getParticles)
  System.String PrintNames(System.Collections.ArrayList expected)
  System.Void PrintNamesWithNS(System.Collections.ArrayList expected, System.Text.StringBuilder builder)
  System.Void EnumerateAny(System.Text.StringBuilder builder, System.String namespaces)
  System.String QNameString(System.String localName, System.String ns)
  System.String BuildElementName(System.Xml.XmlQualifiedName qname)
  System.String BuildElementName(System.String localName, System.String ns)
  System.Void ProcessEntity(System.String name)
  System.Void SendValidationEvent(System.String code)
  System.Void SendValidationEvent(System.String code, System.String[] args)
  System.Void SendValidationEvent(System.String code, System.String arg)
  System.Void SendValidationEvent(System.String code, System.String arg1, System.String arg2)
  System.Void SendValidationEvent(System.String code, System.String[] args, System.Exception innerException, System.Xml.Schema.XmlSeverityType severity)
  System.Void SendValidationEvent(System.String code, System.String[] args, System.Exception innerException)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e)
  System.Void SendValidationEvent(System.String code, System.String msg, System.Xml.Schema.XmlSeverityType severity)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity)
  System.Void SendValidationEvent(System.Xml.Schema.ValidationEventHandler eventHandler, System.Object sender, System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XmlSchemaValidity
TYPE:  struct
TOKEN: 0x2000265
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSchemaValidityNotKnown  // 0x0
  public    static  System.Xml.Schema.XmlSchemaValidityValid  // 0x0
  public    static  System.Xml.Schema.XmlSchemaValidityInvalid  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XmlSeverityType
TYPE:  struct
TOKEN: 0x2000266
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlSeverityTypeError  // 0x0
  public    static  System.Xml.Schema.XmlSeverityTypeWarning  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XmlTypeCode
TYPE:  struct
TOKEN: 0x2000267
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XmlTypeCode   None  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Item  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Node  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Document  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Element  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Attribute  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Namespace  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   ProcessingInstruction  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Comment  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Text  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   AnyAtomicType  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   UntypedAtomic  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   String  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Boolean  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Decimal  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Float  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Double  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Duration  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   DateTime  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Time  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Date  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   GYearMonth  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   GYear  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   GMonthDay  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   GDay  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   GMonth  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   HexBinary  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Base64Binary  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   AnyUri  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   QName  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Notation  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   NormalizedString  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Token  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Language  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   NmToken  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Name  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   NCName  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Id  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Idref  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Entity  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Integer  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   NonPositiveInteger  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   NegativeInteger  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Long  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Int  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Short  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   Byte  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   NonNegativeInteger  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   UnsignedLong  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   UnsignedInt  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   UnsignedShort  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   UnsignedByte  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   PositiveInteger  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   YearMonthDuration  // 0x0
  public    static  System.Xml.Schema.XmlTypeCode   DayTimeDuration  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XmlValueConverter
TYPE:  class
TOKEN: 0x2000268
FIELDS:
METHODS:
  System.Boolean ToBoolean(System.Int64 value)
  System.Boolean ToBoolean(System.Int32 value)
  System.Boolean ToBoolean(System.Double value)
  System.Boolean ToBoolean(System.DateTime value)
  System.Boolean ToBoolean(System.String value)
  System.Boolean ToBoolean(System.Object value)
  System.Int32 ToInt32(System.Boolean value)
  System.Int32 ToInt32(System.Int64 value)
  System.Int32 ToInt32(System.Double value)
  System.Int32 ToInt32(System.DateTime value)
  System.Int32 ToInt32(System.String value)
  System.Int32 ToInt32(System.Object value)
  System.Int64 ToInt64(System.Boolean value)
  System.Int64 ToInt64(System.Int32 value)
  System.Int64 ToInt64(System.Double value)
  System.Int64 ToInt64(System.DateTime value)
  System.Int64 ToInt64(System.String value)
  System.Int64 ToInt64(System.Object value)
  System.Decimal ToDecimal(System.String value)
  System.Decimal ToDecimal(System.Object value)
  System.Double ToDouble(System.Boolean value)
  System.Double ToDouble(System.Int32 value)
  System.Double ToDouble(System.Int64 value)
  System.Double ToDouble(System.DateTime value)
  System.Double ToDouble(System.String value)
  System.Double ToDouble(System.Object value)
  System.Single ToSingle(System.Double value)
  System.Single ToSingle(System.String value)
  System.Single ToSingle(System.Object value)
  System.DateTime ToDateTime(System.Boolean value)
  System.DateTime ToDateTime(System.Int32 value)
  System.DateTime ToDateTime(System.Int64 value)
  System.DateTime ToDateTime(System.Double value)
  System.DateTime ToDateTime(System.DateTimeOffset value)
  System.DateTime ToDateTime(System.String value)
  System.DateTime ToDateTime(System.Object value)
  System.DateTimeOffset ToDateTimeOffset(System.DateTime value)
  System.DateTimeOffset ToDateTimeOffset(System.String value)
  System.DateTimeOffset ToDateTimeOffset(System.Object value)
  System.String ToString(System.Boolean value)
  System.String ToString(System.Int32 value)
  System.String ToString(System.Int64 value)
  System.String ToString(System.Decimal value)
  System.String ToString(System.Single value)
  System.String ToString(System.Double value)
  System.String ToString(System.DateTime value)
  System.String ToString(System.DateTimeOffset value)
  System.String ToString(System.Object value)
  System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Boolean value, System.Type destinationType)
  System.Object ChangeType(System.Int32 value, System.Type destinationType)
  System.Object ChangeType(System.Int64 value, System.Type destinationType)
  System.Object ChangeType(System.Decimal value, System.Type destinationType)
  System.Object ChangeType(System.Double value, System.Type destinationType)
  System.Object ChangeType(System.DateTime value, System.Type destinationType)
  System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Object value, System.Type destinationType)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Schema.XmlBaseConverter
TYPE:  class
TOKEN: 0x2000269
EXTENDS: XmlValueConverter
FIELDS:
  private           System.Xml.Schema.XmlSchemaType schemaType  // 0x10
  private           System.Xml.Schema.XmlTypeCode   typeCode  // 0x18
  private           System.Type                     clrTypeDefault  // 0x20
  protected static readonly System.Type                     ICollectionType  // 0x0
  protected static readonly System.Type                     IEnumerableType  // 0x8
  protected static readonly System.Type                     IListType  // 0x10
  protected static readonly System.Type                     ObjectArrayType  // 0x18
  protected static readonly System.Type                     StringArrayType  // 0x20
  protected static readonly System.Type                     XmlAtomicValueArrayType  // 0x28
  protected static readonly System.Type                     DecimalType  // 0x30
  protected static readonly System.Type                     Int32Type  // 0x38
  protected static readonly System.Type                     Int64Type  // 0x40
  protected static readonly System.Type                     StringType  // 0x48
  protected static readonly System.Type                     XmlAtomicValueType  // 0x50
  protected static readonly System.Type                     ObjectType  // 0x58
  protected static readonly System.Type                     ByteType  // 0x60
  protected static readonly System.Type                     Int16Type  // 0x68
  protected static readonly System.Type                     SByteType  // 0x70
  protected static readonly System.Type                     UInt16Type  // 0x78
  protected static readonly System.Type                     UInt32Type  // 0x80
  protected static readonly System.Type                     UInt64Type  // 0x88
  protected static readonly System.Type                     XPathItemType  // 0x90
  protected static readonly System.Type                     DoubleType  // 0x98
  protected static readonly System.Type                     SingleType  // 0xA0
  protected static readonly System.Type                     DateTimeType  // 0xA8
  protected static readonly System.Type                     DateTimeOffsetType  // 0xB0
  protected static readonly System.Type                     BooleanType  // 0xB8
  protected static readonly System.Type                     ByteArrayType  // 0xC0
  protected static readonly System.Type                     XmlQualifiedNameType  // 0xC8
  protected static readonly System.Type                     UriType  // 0xD0
  protected static readonly System.Type                     TimeSpanType  // 0xD8
  protected static readonly System.Type                     XPathNavigatorType  // 0xE0
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType)
  System.Void .ctor(System.Xml.Schema.XmlTypeCode typeCode)
  System.Void .ctor(System.Xml.Schema.XmlBaseConverter converterAtomic)
  System.Void .ctor(System.Xml.Schema.XmlBaseConverter converterAtomic, System.Type clrTypeDefault)
  System.Boolean ToBoolean(System.DateTime value)
  System.Boolean ToBoolean(System.Double value)
  System.Boolean ToBoolean(System.Int32 value)
  System.Boolean ToBoolean(System.Int64 value)
  System.Boolean ToBoolean(System.String value)
  System.Boolean ToBoolean(System.Object value)
  System.DateTime ToDateTime(System.Boolean value)
  System.DateTime ToDateTime(System.DateTimeOffset value)
  System.DateTime ToDateTime(System.Double value)
  System.DateTime ToDateTime(System.Int32 value)
  System.DateTime ToDateTime(System.Int64 value)
  System.DateTime ToDateTime(System.String value)
  System.DateTime ToDateTime(System.Object value)
  System.DateTimeOffset ToDateTimeOffset(System.DateTime value)
  System.DateTimeOffset ToDateTimeOffset(System.String value)
  System.DateTimeOffset ToDateTimeOffset(System.Object value)
  System.Decimal ToDecimal(System.String value)
  System.Decimal ToDecimal(System.Object value)
  System.Double ToDouble(System.Boolean value)
  System.Double ToDouble(System.DateTime value)
  System.Double ToDouble(System.Int32 value)
  System.Double ToDouble(System.Int64 value)
  System.Double ToDouble(System.String value)
  System.Double ToDouble(System.Object value)
  System.Int32 ToInt32(System.Boolean value)
  System.Int32 ToInt32(System.DateTime value)
  System.Int32 ToInt32(System.Double value)
  System.Int32 ToInt32(System.Int64 value)
  System.Int32 ToInt32(System.String value)
  System.Int32 ToInt32(System.Object value)
  System.Int64 ToInt64(System.Boolean value)
  System.Int64 ToInt64(System.DateTime value)
  System.Int64 ToInt64(System.Double value)
  System.Int64 ToInt64(System.Int32 value)
  System.Int64 ToInt64(System.String value)
  System.Int64 ToInt64(System.Object value)
  System.Single ToSingle(System.Double value)
  System.Single ToSingle(System.String value)
  System.Single ToSingle(System.Object value)
  System.String ToString(System.Boolean value)
  System.String ToString(System.DateTime value)
  System.String ToString(System.DateTimeOffset value)
  System.String ToString(System.Decimal value)
  System.String ToString(System.Double value)
  System.String ToString(System.Int32 value)
  System.String ToString(System.Int64 value)
  System.String ToString(System.Single value)
  System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.String ToString(System.Object value)
  System.Object ChangeType(System.Boolean value, System.Type destinationType)
  System.Object ChangeType(System.DateTime value, System.Type destinationType)
  System.Object ChangeType(System.Decimal value, System.Type destinationType)
  System.Object ChangeType(System.Double value, System.Type destinationType)
  System.Object ChangeType(System.Int32 value, System.Type destinationType)
  System.Object ChangeType(System.Int64 value, System.Type destinationType)
  System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Object value, System.Type destinationType)
  System.Xml.Schema.XmlSchemaType get_SchemaType()
  System.Xml.Schema.XmlTypeCode get_TypeCode()
  System.String get_XmlTypeName()
  System.Type get_DefaultClrType()
  System.Boolean IsDerivedFrom(System.Type derivedType, System.Type baseType)
  System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType)
  System.String QNameToString(System.Xml.XmlQualifiedName name)
  System.Object ChangeListType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Byte[] StringToBase64Binary(System.String value)
  System.DateTime StringToDate(System.String value)
  System.DateTime StringToDateTime(System.String value)
  System.TimeSpan StringToDayTimeDuration(System.String value)
  System.TimeSpan StringToDuration(System.String value)
  System.DateTime StringToGDay(System.String value)
  System.DateTime StringToGMonth(System.String value)
  System.DateTime StringToGMonthDay(System.String value)
  System.DateTime StringToGYear(System.String value)
  System.DateTime StringToGYearMonth(System.String value)
  System.DateTimeOffset StringToDateOffset(System.String value)
  System.DateTimeOffset StringToDateTimeOffset(System.String value)
  System.DateTimeOffset StringToGDayOffset(System.String value)
  System.DateTimeOffset StringToGMonthOffset(System.String value)
  System.DateTimeOffset StringToGMonthDayOffset(System.String value)
  System.DateTimeOffset StringToGYearOffset(System.String value)
  System.DateTimeOffset StringToGYearMonthOffset(System.String value)
  System.Byte[] StringToHexBinary(System.String value)
  System.Xml.XmlQualifiedName StringToQName(System.String value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.DateTime StringToTime(System.String value)
  System.DateTimeOffset StringToTimeOffset(System.String value)
  System.TimeSpan StringToYearMonthDuration(System.String value)
  System.String AnyUriToString(System.Uri value)
  System.String Base64BinaryToString(System.Byte[] value)
  System.String DateToString(System.DateTime value)
  System.String DateTimeToString(System.DateTime value)
  System.String DayTimeDurationToString(System.TimeSpan value)
  System.String DurationToString(System.TimeSpan value)
  System.String GDayToString(System.DateTime value)
  System.String GMonthToString(System.DateTime value)
  System.String GMonthDayToString(System.DateTime value)
  System.String GYearToString(System.DateTime value)
  System.String GYearMonthToString(System.DateTime value)
  System.String DateOffsetToString(System.DateTimeOffset value)
  System.String DateTimeOffsetToString(System.DateTimeOffset value)
  System.String GDayOffsetToString(System.DateTimeOffset value)
  System.String GMonthOffsetToString(System.DateTimeOffset value)
  System.String GMonthDayOffsetToString(System.DateTimeOffset value)
  System.String GYearOffsetToString(System.DateTimeOffset value)
  System.String GYearMonthOffsetToString(System.DateTimeOffset value)
  System.String QNameToString(System.Xml.XmlQualifiedName qname, System.Xml.IXmlNamespaceResolver nsResolver)
  System.String TimeToString(System.DateTime value)
  System.String TimeOffsetToString(System.DateTimeOffset value)
  System.String YearMonthDurationToString(System.TimeSpan value)
  System.DateTime DateTimeOffsetToDateTime(System.DateTimeOffset value)
  System.Int32 DecimalToInt32(System.Decimal value)
  System.Int64 DecimalToInt64(System.Decimal value)
  System.UInt64 DecimalToUInt64(System.Decimal value)
  System.Byte Int32ToByte(System.Int32 value)
  System.Int16 Int32ToInt16(System.Int32 value)
  System.SByte Int32ToSByte(System.Int32 value)
  System.UInt16 Int32ToUInt16(System.Int32 value)
  System.Int32 Int64ToInt32(System.Int64 value)
  System.UInt32 Int64ToUInt32(System.Int64 value)
  System.DateTime UntypedAtomicToDateTime(System.String value)
  System.DateTimeOffset UntypedAtomicToDateTimeOffset(System.String value)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XmlNumeric10Converter
TYPE:  class
TOKEN: 0x200026A
EXTENDS: XmlBaseConverter
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType)
  System.Decimal ToDecimal(System.String value)
  System.Decimal ToDecimal(System.Object value)
  System.Int32 ToInt32(System.Int64 value)
  System.Int32 ToInt32(System.String value)
  System.Int32 ToInt32(System.Object value)
  System.Int64 ToInt64(System.Int32 value)
  System.Int64 ToInt64(System.String value)
  System.Int64 ToInt64(System.Object value)
  System.String ToString(System.Decimal value)
  System.String ToString(System.Int32 value)
  System.String ToString(System.Int64 value)
  System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Decimal value, System.Type destinationType)
  System.Object ChangeType(System.Int32 value, System.Type destinationType)
  System.Object ChangeType(System.Int64 value, System.Type destinationType)
  System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeTypeWildcardDestination(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeTypeWildcardSource(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
END_CLASS

CLASS: System.Xml.Schema.XmlNumeric2Converter
TYPE:  class
TOKEN: 0x200026B
EXTENDS: XmlBaseConverter
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType)
  System.Double ToDouble(System.String value)
  System.Double ToDouble(System.Object value)
  System.Single ToSingle(System.Double value)
  System.Single ToSingle(System.String value)
  System.Single ToSingle(System.Object value)
  System.String ToString(System.Double value)
  System.String ToString(System.Single value)
  System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Double value, System.Type destinationType)
  System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
END_CLASS

CLASS: System.Xml.Schema.XmlDateTimeConverter
TYPE:  class
TOKEN: 0x200026C
EXTENDS: XmlBaseConverter
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType)
  System.DateTime ToDateTime(System.DateTimeOffset value)
  System.DateTime ToDateTime(System.String value)
  System.DateTime ToDateTime(System.Object value)
  System.DateTimeOffset ToDateTimeOffset(System.DateTime value)
  System.DateTimeOffset ToDateTimeOffset(System.String value)
  System.DateTimeOffset ToDateTimeOffset(System.Object value)
  System.String ToString(System.DateTime value)
  System.String ToString(System.DateTimeOffset value)
  System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.DateTime value, System.Type destinationType)
  System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
END_CLASS

CLASS: System.Xml.Schema.XmlBooleanConverter
TYPE:  class
TOKEN: 0x200026D
EXTENDS: XmlBaseConverter
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType)
  System.Boolean ToBoolean(System.String value)
  System.Boolean ToBoolean(System.Object value)
  System.String ToString(System.Boolean value)
  System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Boolean value, System.Type destinationType)
  System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
END_CLASS

CLASS: System.Xml.Schema.XmlMiscConverter
TYPE:  class
TOKEN: 0x200026E
EXTENDS: XmlBaseConverter
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType)
  System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeTypeWildcardDestination(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeTypeWildcardSource(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
END_CLASS

CLASS: System.Xml.Schema.XmlStringConverter
TYPE:  class
TOKEN: 0x200026F
EXTENDS: XmlBaseConverter
FIELDS:
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType)
  System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
END_CLASS

CLASS: System.Xml.Schema.XmlUntypedConverter
TYPE:  class
TOKEN: 0x2000270
EXTENDS: XmlListConverter
FIELDS:
  private           System.Boolean                  allowListToList  // 0x30
  public    static readonly System.Xml.Schema.XmlValueConverterUntyped  // 0x0
  public    static readonly System.Xml.Schema.XmlValueConverterUntypedList  // 0x8
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Xml.Schema.XmlUntypedConverter atomicConverter, System.Boolean allowListToList)
  System.Boolean ToBoolean(System.String value)
  System.Boolean ToBoolean(System.Object value)
  System.DateTime ToDateTime(System.String value)
  System.DateTime ToDateTime(System.Object value)
  System.DateTimeOffset ToDateTimeOffset(System.String value)
  System.DateTimeOffset ToDateTimeOffset(System.Object value)
  System.Decimal ToDecimal(System.String value)
  System.Decimal ToDecimal(System.Object value)
  System.Double ToDouble(System.String value)
  System.Double ToDouble(System.Object value)
  System.Int32 ToInt32(System.String value)
  System.Int32 ToInt32(System.Object value)
  System.Int64 ToInt64(System.String value)
  System.Int64 ToInt64(System.Object value)
  System.Single ToSingle(System.String value)
  System.Single ToSingle(System.Object value)
  System.String ToString(System.Boolean value)
  System.String ToString(System.DateTime value)
  System.String ToString(System.DateTimeOffset value)
  System.String ToString(System.Decimal value)
  System.String ToString(System.Double value)
  System.String ToString(System.Int32 value)
  System.String ToString(System.Int64 value)
  System.String ToString(System.Single value)
  System.String ToString(System.Object value, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Boolean value, System.Type destinationType)
  System.Object ChangeType(System.DateTime value, System.Type destinationType)
  System.Object ChangeType(System.Decimal value, System.Type destinationType)
  System.Object ChangeType(System.Double value, System.Type destinationType)
  System.Object ChangeType(System.Int32 value, System.Type destinationType)
  System.Object ChangeType(System.Int64 value, System.Type destinationType)
  System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeTypeWildcardDestination(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeTypeWildcardSource(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeListType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Boolean SupportsType(System.Type clrType)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XmlAnyConverter
TYPE:  class
TOKEN: 0x2000271
EXTENDS: XmlBaseConverter
FIELDS:
  public    static readonly System.Xml.Schema.XmlValueConverterItem  // 0x0
  public    static readonly System.Xml.Schema.XmlValueConverterAnyAtomic  // 0x8
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlTypeCode typeCode)
  System.Boolean ToBoolean(System.Object value)
  System.DateTime ToDateTime(System.Object value)
  System.DateTimeOffset ToDateTimeOffset(System.Object value)
  System.Decimal ToDecimal(System.Object value)
  System.Double ToDouble(System.Object value)
  System.Int32 ToInt32(System.Object value)
  System.Int64 ToInt64(System.Object value)
  System.Single ToSingle(System.Object value)
  System.Object ChangeType(System.Boolean value, System.Type destinationType)
  System.Object ChangeType(System.DateTime value, System.Type destinationType)
  System.Object ChangeType(System.Decimal value, System.Type destinationType)
  System.Object ChangeType(System.Double value, System.Type destinationType)
  System.Object ChangeType(System.Int32 value, System.Type destinationType)
  System.Object ChangeType(System.Int64 value, System.Type destinationType)
  System.Object ChangeType(System.String value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeTypeWildcardDestination(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeTypeWildcardSource(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Xml.XPath.XPathNavigator ToNavigator(System.Xml.XPath.XPathNavigator nav)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XmlAnyListConverter
TYPE:  class
TOKEN: 0x2000272
EXTENDS: XmlListConverter
FIELDS:
  public    static readonly System.Xml.Schema.XmlValueConverterItemList  // 0x0
  public    static readonly System.Xml.Schema.XmlValueConverterAnyAtomicList  // 0x8
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlBaseConverter atomicConverter)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XmlListConverter
TYPE:  class
TOKEN: 0x2000273
EXTENDS: XmlBaseConverter
FIELDS:
  protected         System.Xml.Schema.XmlValueConverteratomicConverter  // 0x28
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlBaseConverter atomicConverter)
  System.Void .ctor(System.Xml.Schema.XmlBaseConverter atomicConverter, System.Type clrTypeDefault)
  System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlValueConverter atomicConverter)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object ChangeListType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Boolean IsListType(System.Type type)
  T[] ToArray(System.Object list, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Collections.IList ToList(System.Object list, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Collections.Generic.List<System.String> StringAsList(System.String value)
  System.String ListAsString(System.Collections.IEnumerable list, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType)
END_CLASS

CLASS: System.Xml.Schema.XmlUnionConverter
TYPE:  class
TOKEN: 0x2000274
EXTENDS: XmlBaseConverter
FIELDS:
  private           System.Xml.Schema.XmlValueConverter[]converters  // 0x28
  private           System.Boolean                  hasAtomicMember  // 0x30
  private           System.Boolean                  hasListMember  // 0x31
METHODS:
  System.Void .ctor(System.Xml.Schema.XmlSchemaType schemaType)
  System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType)
  System.Object ChangeType(System.Object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver)
END_CLASS

CLASS: System.Xml.Schema.XsdBuilder
TYPE:  class
TOKEN: 0x2000275
EXTENDS: SchemaBuilder
FIELDS:
  private   static readonly System.Xml.Schema.XsdBuilder.State[]SchemaElement  // 0x0
  private   static readonly System.Xml.Schema.XsdBuilder.State[]SchemaSubelements  // 0x8
  private   static readonly System.Xml.Schema.XsdBuilder.State[]AttributeSubelements  // 0x10
  private   static readonly System.Xml.Schema.XsdBuilder.State[]ElementSubelements  // 0x18
  private   static readonly System.Xml.Schema.XsdBuilder.State[]ComplexTypeSubelements  // 0x20
  private   static readonly System.Xml.Schema.XsdBuilder.State[]SimpleContentSubelements  // 0x28
  private   static readonly System.Xml.Schema.XsdBuilder.State[]SimpleContentExtensionSubelements  // 0x30
  private   static readonly System.Xml.Schema.XsdBuilder.State[]SimpleContentRestrictionSubelements  // 0x38
  private   static readonly System.Xml.Schema.XsdBuilder.State[]ComplexContentSubelements  // 0x40
  private   static readonly System.Xml.Schema.XsdBuilder.State[]ComplexContentExtensionSubelements  // 0x48
  private   static readonly System.Xml.Schema.XsdBuilder.State[]ComplexContentRestrictionSubelements  // 0x50
  private   static readonly System.Xml.Schema.XsdBuilder.State[]SimpleTypeSubelements  // 0x58
  private   static readonly System.Xml.Schema.XsdBuilder.State[]SimpleTypeRestrictionSubelements  // 0x60
  private   static readonly System.Xml.Schema.XsdBuilder.State[]SimpleTypeListSubelements  // 0x68
  private   static readonly System.Xml.Schema.XsdBuilder.State[]SimpleTypeUnionSubelements  // 0x70
  private   static readonly System.Xml.Schema.XsdBuilder.State[]RedefineSubelements  // 0x78
  private   static readonly System.Xml.Schema.XsdBuilder.State[]AttributeGroupSubelements  // 0x80
  private   static readonly System.Xml.Schema.XsdBuilder.State[]GroupSubelements  // 0x88
  private   static readonly System.Xml.Schema.XsdBuilder.State[]AllSubelements  // 0x90
  private   static readonly System.Xml.Schema.XsdBuilder.State[]ChoiceSequenceSubelements  // 0x98
  private   static readonly System.Xml.Schema.XsdBuilder.State[]IdentityConstraintSubelements  // 0xA0
  private   static readonly System.Xml.Schema.XsdBuilder.State[]AnnotationSubelements  // 0xA8
  private   static readonly System.Xml.Schema.XsdBuilder.State[]AnnotatedSubelements  // 0xB0
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]SchemaAttributes  // 0xB8
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]AttributeAttributes  // 0xC0
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]ElementAttributes  // 0xC8
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]ComplexTypeAttributes  // 0xD0
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]SimpleContentAttributes  // 0xD8
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]SimpleContentExtensionAttributes  // 0xE0
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]SimpleContentRestrictionAttributes  // 0xE8
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]ComplexContentAttributes  // 0xF0
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]ComplexContentExtensionAttributes  // 0xF8
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]ComplexContentRestrictionAttributes  // 0x100
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]SimpleTypeAttributes  // 0x108
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]SimpleTypeRestrictionAttributes  // 0x110
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]SimpleTypeUnionAttributes  // 0x118
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]SimpleTypeListAttributes  // 0x120
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]AttributeGroupAttributes  // 0x128
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]AttributeGroupRefAttributes  // 0x130
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]GroupAttributes  // 0x138
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]GroupRefAttributes  // 0x140
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]ParticleAttributes  // 0x148
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]AnyAttributes  // 0x150
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]IdentityConstraintAttributes  // 0x158
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]SelectorAttributes  // 0x160
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]FieldAttributes  // 0x168
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]NotationAttributes  // 0x170
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]IncludeAttributes  // 0x178
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]ImportAttributes  // 0x180
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]FacetAttributes  // 0x188
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]AnyAttributeAttributes  // 0x190
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]DocumentationAttributes  // 0x198
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]AppinfoAttributes  // 0x1A0
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]RedefineAttributes  // 0x1A8
  private   static readonly System.Xml.Schema.XsdBuilder.XsdAttributeEntry[]AnnotationAttributes  // 0x1B0
  private   static readonly System.Xml.Schema.XsdBuilder.XsdEntry[]SchemaEntries  // 0x1B8
  private   static readonly System.Int32[]                  DerivationMethodValues  // 0x1C0
  private   static readonly System.String[]                 DerivationMethodStrings  // 0x1C8
  private   static readonly System.String[]                 FormStringValues  // 0x1D0
  private   static readonly System.String[]                 UseStringValues  // 0x1D8
  private   static readonly System.String[]                 ProcessContentsStringValues  // 0x1E0
  private           System.Xml.XmlReader            reader  // 0x10
  private           System.Xml.PositionInfo         positionInfo  // 0x18
  private           System.Xml.Schema.XsdBuilder.XsdEntrycurrentEntry  // 0x20
  private           System.Xml.Schema.XsdBuilder.XsdEntrynextEntry  // 0x28
  private           System.Boolean                  hasChild  // 0x30
  private           System.Xml.HWStack              stateHistory  // 0x38
  private           System.Collections.Stack        containerStack  // 0x40
  private           System.Xml.XmlNameTable         nameTable  // 0x48
  private           System.Xml.Schema.SchemaNames   schemaNames  // 0x50
  private           System.Xml.XmlNamespaceManager  namespaceManager  // 0x58
  private           System.Boolean                  canIncludeImport  // 0x60
  private           System.Xml.Schema.XmlSchema     schema  // 0x68
  private           System.Xml.Schema.XmlSchemaObjectxso  // 0x70
  private           System.Xml.Schema.XmlSchemaElementelement  // 0x78
  private           System.Xml.Schema.XmlSchemaAny  anyElement  // 0x80
  private           System.Xml.Schema.XmlSchemaAttributeattribute  // 0x88
  private           System.Xml.Schema.XmlSchemaAnyAttributeanyAttribute  // 0x90
  private           System.Xml.Schema.XmlSchemaComplexTypecomplexType  // 0x98
  private           System.Xml.Schema.XmlSchemaSimpleTypesimpleType  // 0xA0
  private           System.Xml.Schema.XmlSchemaComplexContentcomplexContent  // 0xA8
  private           System.Xml.Schema.XmlSchemaComplexContentExtensioncomplexContentExtension  // 0xB0
  private           System.Xml.Schema.XmlSchemaComplexContentRestrictioncomplexContentRestriction  // 0xB8
  private           System.Xml.Schema.XmlSchemaSimpleContentsimpleContent  // 0xC0
  private           System.Xml.Schema.XmlSchemaSimpleContentExtensionsimpleContentExtension  // 0xC8
  private           System.Xml.Schema.XmlSchemaSimpleContentRestrictionsimpleContentRestriction  // 0xD0
  private           System.Xml.Schema.XmlSchemaSimpleTypeUnionsimpleTypeUnion  // 0xD8
  private           System.Xml.Schema.XmlSchemaSimpleTypeListsimpleTypeList  // 0xE0
  private           System.Xml.Schema.XmlSchemaSimpleTypeRestrictionsimpleTypeRestriction  // 0xE8
  private           System.Xml.Schema.XmlSchemaGroupgroup  // 0xF0
  private           System.Xml.Schema.XmlSchemaGroupRefgroupRef  // 0xF8
  private           System.Xml.Schema.XmlSchemaAll  all  // 0x100
  private           System.Xml.Schema.XmlSchemaChoicechoice  // 0x108
  private           System.Xml.Schema.XmlSchemaSequencesequence  // 0x110
  private           System.Xml.Schema.XmlSchemaParticleparticle  // 0x118
  private           System.Xml.Schema.XmlSchemaAttributeGroupattributeGroup  // 0x120
  private           System.Xml.Schema.XmlSchemaAttributeGroupRefattributeGroupRef  // 0x128
  private           System.Xml.Schema.XmlSchemaNotationnotation  // 0x130
  private           System.Xml.Schema.XmlSchemaIdentityConstraintidentityConstraint  // 0x138
  private           System.Xml.Schema.XmlSchemaXPathxpath  // 0x140
  private           System.Xml.Schema.XmlSchemaIncludeinclude  // 0x148
  private           System.Xml.Schema.XmlSchemaImportimport  // 0x150
  private           System.Xml.Schema.XmlSchemaAnnotationannotation  // 0x158
  private           System.Xml.Schema.XmlSchemaAppInfoappInfo  // 0x160
  private           System.Xml.Schema.XmlSchemaDocumentationdocumentation  // 0x168
  private           System.Xml.Schema.XmlSchemaFacetfacet  // 0x170
  private           System.Xml.XmlNode[]            markup  // 0x178
  private           System.Xml.Schema.XmlSchemaRedefineredefine  // 0x180
  private           System.Xml.Schema.ValidationEventHandlervalidationEventHandler  // 0x188
  private           System.Collections.ArrayList    unhandledAttributes  // 0x190
  private           System.Collections.Hashtable    namespaces  // 0x198
METHODS:
  System.Void .ctor(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.XmlSchema schema, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler)
  System.Boolean ProcessElement(System.String prefix, System.String name, System.String ns)
  System.Void ProcessAttribute(System.String prefix, System.String name, System.String ns, System.String value)
  System.Boolean IsContentParsed()
  System.Void ProcessMarkup(System.Xml.XmlNode[] markup)
  System.Void ProcessCData(System.String value)
  System.Void StartChildren()
  System.Void EndChildren()
  System.Void Push()
  System.Void Pop()
  System.Xml.Schema.SchemaNames.Token get_CurrentElement()
  System.Xml.Schema.SchemaNames.Token get_ParentElement()
  System.Xml.Schema.XmlSchemaObject get_ParentContainer()
  System.Xml.Schema.XmlSchemaObject GetContainer(System.Xml.Schema.XsdBuilder.State state)
  System.Void SetContainer(System.Xml.Schema.XsdBuilder.State state, System.Object container)
  System.Void BuildAnnotated_Id(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSchema_AttributeFormDefault(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSchema_ElementFormDefault(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSchema_TargetNamespace(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSchema_Version(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSchema_FinalDefault(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSchema_BlockDefault(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitSchema(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitInclude(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildInclude_SchemaLocation(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitImport(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildImport_Namespace(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildImport_SchemaLocation(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitRedefine(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildRedefine_SchemaLocation(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void EndRedefine(System.Xml.Schema.XsdBuilder builder)
  System.Void InitAttribute(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAttribute_Default(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAttribute_Fixed(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAttribute_Form(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAttribute_Use(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAttribute_Ref(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAttribute_Name(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAttribute_Type(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitElement(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_Abstract(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_Block(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_Default(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_Form(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_SubstitutionGroup(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_Final(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_Fixed(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_MaxOccurs(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_MinOccurs(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_Name(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_Nillable(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_Ref(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildElement_Type(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitSimpleType(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSimpleType_Name(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSimpleType_Final(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitSimpleTypeUnion(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSimpleTypeUnion_MemberTypes(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitSimpleTypeList(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSimpleTypeList_ItemType(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitSimpleTypeRestriction(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSimpleTypeRestriction_Base(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitComplexType(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildComplexType_Abstract(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildComplexType_Block(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildComplexType_Final(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildComplexType_Mixed(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildComplexType_Name(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitComplexContent(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildComplexContent_Mixed(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitComplexContentExtension(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildComplexContentExtension_Base(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitComplexContentRestriction(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildComplexContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitSimpleContent(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitSimpleContentExtension(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSimpleContentExtension_Base(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitSimpleContentRestriction(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSimpleContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitAttributeGroup(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAttributeGroup_Name(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitAttributeGroupRef(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAttributeGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitAnyAttribute(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAnyAttribute_Namespace(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAnyAttribute_ProcessContents(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitGroup(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildGroup_Name(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitGroupRef(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildParticle_MaxOccurs(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildParticle_MinOccurs(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitAll(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitChoice(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitSequence(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitAny(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAny_Namespace(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAny_ProcessContents(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitNotation(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildNotation_Name(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildNotation_Public(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildNotation_System(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitFacet(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildFacet_Fixed(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildFacet_Value(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitIdentityConstraint(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildIdentityConstraint_Name(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildIdentityConstraint_Refer(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitSelector(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildSelector_XPath(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitField(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildField_XPath(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitAnnotation(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void InitAppinfo(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildAppinfo_Source(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void EndAppinfo(System.Xml.Schema.XsdBuilder builder)
  System.Void InitDocumentation(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildDocumentation_Source(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void BuildDocumentation_XmlLang(System.Xml.Schema.XsdBuilder builder, System.String value)
  System.Void EndDocumentation(System.Xml.Schema.XsdBuilder builder)
  System.Void AddAttribute(System.Xml.Schema.XmlSchemaObject value)
  System.Void AddParticle(System.Xml.Schema.XmlSchemaParticle particle)
  System.Boolean GetNextState(System.Xml.XmlQualifiedName qname)
  System.Boolean IsSkipableElement(System.Xml.XmlQualifiedName qname)
  System.Void SetMinOccurs(System.Xml.Schema.XmlSchemaParticle particle, System.String value)
  System.Void SetMaxOccurs(System.Xml.Schema.XmlSchemaParticle particle, System.String value)
  System.Boolean ParseBoolean(System.String value, System.String attributeName)
  System.Int32 ParseEnum(System.String value, System.String attributeName, System.String[] values)
  System.Xml.XmlQualifiedName ParseQName(System.String value, System.String attributeName)
  System.Int32 ParseBlockFinalEnum(System.String value, System.String attributeName)
  System.String ParseUriReference(System.String s)
  System.Void SendValidationEvent(System.String code, System.String arg0, System.String arg1, System.String arg2)
  System.Void SendValidationEvent(System.String code, System.String msg)
  System.Void SendValidationEvent(System.String code, System.String[] args, System.Xml.Schema.XmlSeverityType severity)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity)
  System.Void SendValidationEvent(System.Xml.Schema.XmlSchemaException e)
  System.Void RecordPosition()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XsdDateTimeFlags
TYPE:  struct
TOKEN: 0x200027D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Schema.XsdDateTimeFlagsDateTime  // 0x0
  public    static  System.Xml.Schema.XsdDateTimeFlagsTime  // 0x0
  public    static  System.Xml.Schema.XsdDateTimeFlagsDate  // 0x0
  public    static  System.Xml.Schema.XsdDateTimeFlagsGYearMonth  // 0x0
  public    static  System.Xml.Schema.XsdDateTimeFlagsGYear  // 0x0
  public    static  System.Xml.Schema.XsdDateTimeFlagsGMonthDay  // 0x0
  public    static  System.Xml.Schema.XsdDateTimeFlagsGDay  // 0x0
  public    static  System.Xml.Schema.XsdDateTimeFlagsGMonth  // 0x0
  public    static  System.Xml.Schema.XsdDateTimeFlagsXdrDateTimeNoTz  // 0x0
  public    static  System.Xml.Schema.XsdDateTimeFlagsXdrDateTime  // 0x0
  public    static  System.Xml.Schema.XsdDateTimeFlagsXdrTimeNoTz  // 0x0
  public    static  System.Xml.Schema.XsdDateTimeFlagsAllXsd  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Schema.XsdDateTime
TYPE:  struct
TOKEN: 0x200027E
FIELDS:
  private           System.DateTime                 dt  // 0x10
  private           System.UInt32                   extra  // 0x18
  private   static readonly System.Int32                    Lzyyyy  // 0x0
  private   static readonly System.Int32                    Lzyyyy_  // 0x4
  private   static readonly System.Int32                    Lzyyyy_MM  // 0x8
  private   static readonly System.Int32                    Lzyyyy_MM_  // 0xC
  private   static readonly System.Int32                    Lzyyyy_MM_dd  // 0x10
  private   static readonly System.Int32                    Lzyyyy_MM_ddT  // 0x14
  private   static readonly System.Int32                    LzHH  // 0x18
  private   static readonly System.Int32                    LzHH_  // 0x1C
  private   static readonly System.Int32                    LzHH_mm  // 0x20
  private   static readonly System.Int32                    LzHH_mm_  // 0x24
  private   static readonly System.Int32                    LzHH_mm_ss  // 0x28
  private   static readonly System.Int32                    Lz_  // 0x2C
  private   static readonly System.Int32                    Lz_zz  // 0x30
  private   static readonly System.Int32                    Lz_zz_  // 0x34
  private   static readonly System.Int32                    Lz_zz_zz  // 0x38
  private   static readonly System.Int32                    Lz__  // 0x3C
  private   static readonly System.Int32                    Lz__mm  // 0x40
  private   static readonly System.Int32                    Lz__mm_  // 0x44
  private   static readonly System.Int32                    Lz__mm__  // 0x48
  private   static readonly System.Int32                    Lz__mm_dd  // 0x4C
  private   static readonly System.Int32                    Lz___  // 0x50
  private   static readonly System.Int32                    Lz___dd  // 0x54
  private   static readonly System.Xml.Schema.XmlTypeCode[] typeCodes  // 0x58
METHODS:
  System.Void .ctor(System.String text, System.Xml.Schema.XsdDateTimeFlags kinds)
  System.Void .ctor(System.Xml.Schema.XsdDateTime.Parser parser)
  System.Void InitiateXsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser)
  System.Boolean TryParse(System.String text, System.Xml.Schema.XsdDateTimeFlags kinds, System.Xml.Schema.XsdDateTime& result)
  System.Void .ctor(System.DateTime dateTime, System.Xml.Schema.XsdDateTimeFlags kinds)
  System.Void .ctor(System.DateTimeOffset dateTimeOffset)
  System.Void .ctor(System.DateTimeOffset dateTimeOffset, System.Xml.Schema.XsdDateTimeFlags kinds)
  System.Xml.Schema.XsdDateTime.DateTimeTypeCode get_InternalTypeCode()
  System.Xml.Schema.XsdDateTime.XsdDateTimeKind get_InternalKind()
  System.Int32 get_Year()
  System.Int32 get_Month()
  System.Int32 get_Day()
  System.Int32 get_Hour()
  System.Int32 get_Minute()
  System.Int32 get_Second()
  System.Int32 get_Fraction()
  System.Int32 get_ZoneHour()
  System.Int32 get_ZoneMinute()
  System.DateTime op_Implicit(System.Xml.Schema.XsdDateTime xdt)
  System.DateTimeOffset op_Implicit(System.Xml.Schema.XsdDateTime xdt)
  System.String ToString()
  System.Void PrintDate(System.Text.StringBuilder sb)
  System.Void PrintTime(System.Text.StringBuilder sb)
  System.Void PrintZone(System.Text.StringBuilder sb)
  System.Void IntToCharArray(System.Char[] text, System.Int32 start, System.Int32 value, System.Int32 digits)
  System.Void ShortToCharArray(System.Char[] text, System.Int32 start, System.Int32 value)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Schema.XsdDuration
TYPE:  struct
TOKEN: 0x2000282
FIELDS:
  private           System.Int32                    years  // 0x10
  private           System.Int32                    months  // 0x14
  private           System.Int32                    days  // 0x18
  private           System.Int32                    hours  // 0x1C
  private           System.Int32                    minutes  // 0x20
  private           System.Int32                    seconds  // 0x24
  private           System.UInt32                   nanoseconds  // 0x28
METHODS:
  System.Void .ctor(System.Boolean isNegative, System.Int32 years, System.Int32 months, System.Int32 days, System.Int32 hours, System.Int32 minutes, System.Int32 seconds, System.Int32 nanoseconds)
  System.Void .ctor(System.TimeSpan timeSpan)
  System.Void .ctor(System.TimeSpan timeSpan, System.Xml.Schema.XsdDuration.DurationType durationType)
  System.Void .ctor(System.String s)
  System.Void .ctor(System.String s, System.Xml.Schema.XsdDuration.DurationType durationType)
  System.Boolean get_IsNegative()
  System.Int32 get_Years()
  System.Int32 get_Months()
  System.Int32 get_Days()
  System.Int32 get_Hours()
  System.Int32 get_Minutes()
  System.Int32 get_Seconds()
  System.Int32 get_Nanoseconds()
  System.TimeSpan ToTimeSpan()
  System.TimeSpan ToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType)
  System.Exception TryToTimeSpan(System.TimeSpan& result)
  System.Exception TryToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType, System.TimeSpan& result)
  System.String ToString()
  System.String ToString(System.Xml.Schema.XsdDuration.DurationType durationType)
  System.Exception TryParse(System.String s, System.Xml.Schema.XsdDuration& result)
  System.Exception TryParse(System.String s, System.Xml.Schema.XsdDuration.DurationType durationType, System.Xml.Schema.XsdDuration& result)
  System.String TryParseDigits(System.String s, System.Int32& offset, System.Boolean eatDigits, System.Int32& result, System.Int32& numDigits)
END_CLASS

CLASS: System.Xml.Schema.XsdValidator
TYPE:  class
TOKEN: 0x2000285
EXTENDS: BaseValidator
FIELDS:
  private           System.Int32                    startIDConstraint  // 0x80
  private           System.Xml.HWStack              validationStack  // 0x88
  private           System.Collections.Hashtable    attPresence  // 0x90
  private           System.Xml.XmlNamespaceManager  nsManager  // 0x98
  private           System.Boolean                  bManageNamespaces  // 0xA0
  private           System.Collections.Hashtable    IDs  // 0xA8
  private           System.Xml.Schema.IdRefNode     idRefListHead  // 0xB0
  private           System.Xml.Schema.Parser        inlineSchemaParser  // 0xB8
  private           System.Xml.Schema.XmlSchemaContentProcessingprocessContents  // 0xC0
  private   static readonly System.Xml.Schema.XmlSchemaDatatypedtCDATA  // 0x0
  private   static readonly System.Xml.Schema.XmlSchemaDatatypedtQName  // 0x8
  private   static readonly System.Xml.Schema.XmlSchemaDatatypedtStringArray  // 0x10
  private           System.String                   NsXmlNs  // 0xC8
  private           System.String                   NsXs  // 0xD0
  private           System.String                   NsXsi  // 0xD8
  private           System.String                   XsiType  // 0xE0
  private           System.String                   XsiNil  // 0xE8
  private           System.String                   XsiSchemaLocation  // 0xF0
  private           System.String                   XsiNoNamespaceSchemaLocation  // 0xF8
  private           System.String                   XsdSchema  // 0x100
METHODS:
  System.Void .ctor(System.Xml.Schema.BaseValidator validator)
  System.Void .ctor(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling)
  System.Void Init()
  System.Void Validate()
  System.Void CompleteValidation()
  System.Boolean get_IsInlineSchemaStarted()
  System.Void ProcessInlineSchema()
  System.Void ValidateElement()
  System.Object ValidateChildElement()
  System.Void ProcessElement(System.Object particle)
  System.Void ProcessXsiAttributes(System.Xml.XmlQualifiedName& xsiType, System.String& xsiNil)
  System.Void ValidateEndElement()
  System.Xml.Schema.SchemaElementDecl FastGetElementDecl(System.Object particle)
  System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl(System.Xml.Schema.SchemaElementDecl elementDecl, System.Xml.XmlQualifiedName xsiType, System.String xsiNil)
  System.Void ValidateStartElement()
  System.Void ValidateEndStartElement()
  System.Void LoadSchemaFromLocation(System.String uri, System.String url)
  System.Void LoadSchema(System.String uri, System.String url)
  System.Boolean get_HasSchema()
  System.Boolean get_PreserveWhitespace()
  System.Void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, System.String name)
  System.Void CheckValue(System.String value, System.Xml.Schema.SchemaAttDef attdef)
  System.Void AddID(System.String name, System.Object node)
  System.Object FindId(System.String name)
  System.Boolean IsXSDRoot(System.String localName, System.String ns)
  System.Void Push(System.Xml.XmlQualifiedName elementName)
  System.Void Pop()
  System.Void CheckForwardRefs()
  System.Void ValidateStartElementIdentityConstraints()
  System.Boolean get_HasIdentityConstraints()
  System.Void AddIdentityConstraints()
  System.Void ElementIdentityConstraints()
  System.Void AttributeIdentityConstraints(System.String name, System.String ns, System.Object obj, System.String sobj, System.Xml.Schema.SchemaAttDef attdef)
  System.Object UnWrapUnion(System.Object typedValue)
  System.Void EndElementIdentityConstraints()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Serialization.CodeIdentifier
TYPE:  class
TOKEN: 0x2000100
FIELDS:
  private   static  Microsoft.CSharp.CodeDomProvidercsharp  // 0x0
METHODS:
  System.String MakePascal(System.String identifier)
  System.String MakeValid(System.String identifier)
  System.Boolean IsValidStart(System.Char c)
  System.Boolean IsValid(System.Char c)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializerNamespaces
TYPE:  class
TOKEN: 0x2000101
FIELDS:
  private           System.Collections.Hashtable    namespaces  // 0x10
METHODS:
  System.Void .ctor()
  System.Void Add(System.String prefix, System.String ns)
  System.Void AddInternal(System.String prefix, System.String ns)
  System.Xml.XmlQualifiedName[] ToArray()
  System.Int32 get_Count()
  System.Collections.ArrayList get_NamespaceList()
  System.Collections.Hashtable get_Namespaces()
  System.Void set_Namespaces(System.Collections.Hashtable value)
END_CLASS

CLASS: System.Xml.Serialization.XmlAttributeEventHandler
TYPE:  class
TOKEN: 0x2000102
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Xml.Serialization.XmlAttributeEventArgs e)
END_CLASS

CLASS: System.Xml.Serialization.XmlAttributeEventArgs
TYPE:  class
TOKEN: 0x2000103
EXTENDS: EventArgs
FIELDS:
  private           System.Object                   o  // 0x10
  private           System.Xml.XmlAttribute         attr  // 0x18
  private           System.String                   qnames  // 0x20
  private           System.Int32                    lineNumber  // 0x28
  private           System.Int32                    linePosition  // 0x2C
METHODS:
  System.Void .ctor(System.Xml.XmlAttribute attr, System.Int32 lineNumber, System.Int32 linePosition, System.Object o, System.String qnames)
END_CLASS

CLASS: System.Xml.Serialization.XmlElementEventHandler
TYPE:  class
TOKEN: 0x2000104
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Xml.Serialization.XmlElementEventArgs e)
END_CLASS

CLASS: System.Xml.Serialization.XmlElementEventArgs
TYPE:  class
TOKEN: 0x2000105
EXTENDS: EventArgs
FIELDS:
  private           System.Object                   o  // 0x10
  private           System.Xml.XmlElement           elem  // 0x18
  private           System.String                   qnames  // 0x20
  private           System.Int32                    lineNumber  // 0x28
  private           System.Int32                    linePosition  // 0x2C
METHODS:
  System.Void .ctor(System.Xml.XmlElement elem, System.Int32 lineNumber, System.Int32 linePosition, System.Object o, System.String qnames)
END_CLASS

CLASS: System.Xml.Serialization.XmlNodeEventHandler
TYPE:  class
TOKEN: 0x2000106
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Xml.Serialization.XmlNodeEventArgs e)
END_CLASS

CLASS: System.Xml.Serialization.XmlNodeEventArgs
TYPE:  class
TOKEN: 0x2000107
EXTENDS: EventArgs
FIELDS:
  private           System.Object                   o  // 0x10
  private           System.Xml.XmlNode              xmlNode  // 0x18
  private           System.Int32                    lineNumber  // 0x20
  private           System.Int32                    linePosition  // 0x24
METHODS:
  System.Void .ctor(System.Xml.XmlNode xmlNode, System.Int32 lineNumber, System.Int32 linePosition, System.Object o)
END_CLASS

CLASS: System.Xml.Serialization.UnreferencedObjectEventHandler
TYPE:  class
TOKEN: 0x2000108
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object sender, System.Xml.Serialization.UnreferencedObjectEventArgs e)
END_CLASS

CLASS: System.Xml.Serialization.UnreferencedObjectEventArgs
TYPE:  class
TOKEN: 0x2000109
EXTENDS: EventArgs
FIELDS:
  private           System.Object                   o  // 0x10
  private           System.String                   id  // 0x18
METHODS:
  System.Void .ctor(System.Object o, System.String id)
END_CLASS

CLASS: System.Xml.Serialization.IXmlSerializable
TYPE:  interface
TOKEN: 0x200010A
FIELDS:
METHODS:
  System.Xml.Schema.XmlSchema GetSchema()
  System.Void ReadXml(System.Xml.XmlReader reader)
  System.Void WriteXml(System.Xml.XmlWriter writer)
END_CLASS

CLASS: System.Xml.Serialization.IXmlTextParser
TYPE:  interface
TOKEN: 0x200010B
FIELDS:
METHODS:
  System.Boolean get_Normalized()
  System.Void set_Normalized(System.Boolean value)
END_CLASS

CLASS: System.Xml.Serialization.KeyHelper
TYPE:  class
TOKEN: 0x200010C
FIELDS:
METHODS:
  System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.String val)
  System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.String val, System.String def)
  System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.Boolean val)
  System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.Boolean val, System.Boolean def)
  System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.Int32 val, System.Int32 def)
  System.Void AddField(System.Text.StringBuilder sb, System.Int32 n, System.Type val)
END_CLASS

CLASS: System.Xml.Serialization.ReflectionHelper
TYPE:  class
TOKEN: 0x200010D
FIELDS:
  private           System.Collections.Hashtable    _clrTypes  // 0x10
  private           System.Collections.Hashtable    _schemaTypes  // 0x18
  private   static readonly System.Reflection.ParameterModifier[]empty_modifiers  // 0x0
METHODS:
  System.Void RegisterSchemaType(System.Xml.Serialization.XmlTypeMapping map, System.String xmlType, System.String ns)
  System.Xml.Serialization.XmlTypeMapping GetRegisteredSchemaType(System.String xmlType, System.String ns)
  System.Void RegisterClrType(System.Xml.Serialization.XmlTypeMapping map, System.Type type, System.String ns)
  System.Xml.Serialization.XmlTypeMapping GetRegisteredClrType(System.Type type, System.String ns)
  System.Void CheckSerializableType(System.Type type, System.Boolean allowPrivateConstructors)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Serialization.SchemaTypes
TYPE:  struct
TOKEN: 0x200010E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Serialization.SchemaTypesNotSet  // 0x0
  public    static  System.Xml.Serialization.SchemaTypesPrimitive  // 0x0
  public    static  System.Xml.Serialization.SchemaTypesEnum  // 0x0
  public    static  System.Xml.Serialization.SchemaTypesArray  // 0x0
  public    static  System.Xml.Serialization.SchemaTypesClass  // 0x0
  public    static  System.Xml.Serialization.SchemaTypesXmlSerializable  // 0x0
  public    static  System.Xml.Serialization.SchemaTypesXmlNode  // 0x0
  public    static  System.Xml.Serialization.SchemaTypesVoid  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Serialization.SerializationSource
TYPE:  class
TOKEN: 0x200010F
FIELDS:
  private           System.Type[]                   includedTypes  // 0x10
  private           System.String                   namspace  // 0x18
  private           System.Boolean                  canBeGenerated  // 0x20
METHODS:
  System.Void .ctor(System.String namspace, System.Type[] includedTypes)
  System.Boolean BaseEquals(System.Xml.Serialization.SerializationSource other)
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeSerializationSource
TYPE:  class
TOKEN: 0x2000110
EXTENDS: SerializationSource
FIELDS:
  private           System.String                   attributeOverridesHash  // 0x28
  private           System.Type                     type  // 0x30
  private           System.String                   rootHash  // 0x38
METHODS:
  System.Void .ctor(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, System.String namspace, System.Type[] includedTypes)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeConvertorAttribute
TYPE:  class
TOKEN: 0x2000111
EXTENDS: Attribute
FIELDS:
  private           System.String                   <Method>k__BackingField  // 0x10
METHODS:
  System.String get_Method()
  System.Void set_Method(System.String value)
  System.Void .ctor(System.String method)
END_CLASS

CLASS: System.Xml.Serialization.TypeData
TYPE:  class
TOKEN: 0x2000112
FIELDS:
  private           System.Type                     type  // 0x10
  private           System.String                   elementName  // 0x18
  private           System.Xml.Serialization.SchemaTypessType  // 0x20
  private           System.Type                     listItemType  // 0x28
  private           System.String                   typeName  // 0x30
  private           System.String                   fullTypeName  // 0x38
  private           System.Xml.Serialization.TypeDatalistItemTypeData  // 0x40
  private           System.Xml.Serialization.TypeDatamappedType  // 0x48
  private           System.Xml.Schema.XmlSchemaPatternFacetfacet  // 0x50
  private           System.Reflection.MethodInfo    typeConvertor  // 0x58
  private           System.Boolean                  hasPublicConstructor  // 0x60
  private           System.Boolean                  nullableOverride  // 0x61
  private   static  System.String[]                 keywords  // 0x0
METHODS:
  System.Void .ctor(System.Type type, System.String elementName, System.Boolean isPrimitive)
  System.Void .ctor(System.Type type, System.String elementName, System.Boolean isPrimitive, System.Xml.Serialization.TypeData mappedType, System.Xml.Schema.XmlSchemaPatternFacet facet)
  System.Void LookupTypeConvertor()
  System.Void ConvertForAssignment(System.Object& value)
  System.String get_TypeName()
  System.String get_XmlType()
  System.Type get_Type()
  System.String get_FullTypeName()
  System.Xml.Serialization.SchemaTypes get_SchemaType()
  System.Boolean get_IsListType()
  System.Boolean get_IsComplexType()
  System.Boolean get_IsValueType()
  System.Boolean get_IsNullable()
  System.Void set_IsNullable(System.Boolean value)
  System.Xml.Serialization.TypeData get_ListItemTypeData()
  System.Type get_ListItemType()
  System.Boolean get_IsXsdType()
  System.Boolean get_HasPublicConstructor()
  System.Reflection.PropertyInfo GetIndexerProperty(System.Type collectionType)
  System.InvalidOperationException CreateMissingAddMethodException(System.Type type, System.String inheritFrom, System.Type argumentType)
  System.Type GetGenericListItemType(System.Type type)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Serialization.TypeMember
TYPE:  class
TOKEN: 0x2000113
FIELDS:
  private           System.Type                     type  // 0x10
  private           System.String                   member  // 0x18
METHODS:
  System.Void .ctor(System.Type type, System.String member)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(System.Xml.Serialization.TypeMember tm1, System.Xml.Serialization.TypeMember tm2)
  System.String ToString()
END_CLASS

CLASS: System.Xml.Serialization.TypeTranslator
TYPE:  class
TOKEN: 0x2000114
FIELDS:
  private   static  System.Collections.Hashtable    nameCache  // 0x0
  private   static  System.Collections.Hashtable    primitiveTypes  // 0x8
  private   static  System.Collections.Hashtable    primitiveArrayTypes  // 0x10
  private   static  System.Collections.Hashtable    nullableTypes  // 0x18
METHODS:
  System.Void .cctor()
  System.Xml.Serialization.TypeData GetTypeData(System.Type type)
  System.Xml.Serialization.TypeData GetTypeData(System.Type runtimeType, System.String xmlDataType, System.Boolean underlyingEnumType)
  System.Xml.Serialization.TypeData GetPrimitiveTypeData(System.String typeName)
  System.Xml.Serialization.TypeData GetPrimitiveTypeData(System.String typeName, System.Boolean nullable)
  System.Xml.Serialization.TypeData FindPrimitiveTypeData(System.String typeName)
  System.String GetArrayName(System.String elemName)
  System.Void ParseArrayType(System.String arrayType, System.String& type, System.String& ns, System.String& dimensions)
END_CLASS

CLASS: System.Xml.Serialization.XmlAnyAttributeAttribute
TYPE:  class
TOKEN: 0x2000115
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlAnyElementAttribute
TYPE:  class
TOKEN: 0x2000116
EXTENDS: Attribute
FIELDS:
  private           System.String                   elementName  // 0x10
  private           System.String                   ns  // 0x18
  private           System.Int32                    order  // 0x20
METHODS:
  System.Void .ctor()
  System.String get_Name()
  System.String get_Namespace()
  System.Int32 get_Order()
  System.Void AddKeyHash(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Serialization.XmlAnyElementAttributes
TYPE:  class
TOKEN: 0x2000117
EXTENDS: CollectionBase
FIELDS:
METHODS:
  System.Xml.Serialization.XmlAnyElementAttribute get_Item(System.Int32 index)
  System.Int32 Add(System.Xml.Serialization.XmlAnyElementAttribute attribute)
  System.Void AddKeyHash(System.Text.StringBuilder sb)
  System.Int32 get_Order()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlArrayAttribute
TYPE:  class
TOKEN: 0x2000118
EXTENDS: Attribute
FIELDS:
  private           System.String                   elementName  // 0x10
  private           System.Xml.Schema.XmlSchemaForm form  // 0x18
  private           System.Boolean                  isNullable  // 0x1C
  private           System.String                   ns  // 0x20
  private           System.Int32                    order  // 0x28
METHODS:
  System.String get_ElementName()
  System.Xml.Schema.XmlSchemaForm get_Form()
  System.Boolean get_IsNullable()
  System.String get_Namespace()
  System.Int32 get_Order()
  System.Void AddKeyHash(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Serialization.XmlArrayItemAttribute
TYPE:  class
TOKEN: 0x2000119
EXTENDS: Attribute
FIELDS:
  private           System.String                   dataType  // 0x10
  private           System.String                   elementName  // 0x18
  private           System.Xml.Schema.XmlSchemaForm form  // 0x20
  private           System.String                   ns  // 0x28
  private           System.Boolean                  isNullable  // 0x30
  private           System.Boolean                  isNullableSpecified  // 0x31
  private           System.Int32                    nestingLevel  // 0x34
  private           System.Type                     type  // 0x38
METHODS:
  System.String get_DataType()
  System.String get_ElementName()
  System.Xml.Schema.XmlSchemaForm get_Form()
  System.String get_Namespace()
  System.Boolean get_IsNullable()
  System.Boolean get_IsNullableSpecified()
  System.Type get_Type()
  System.Int32 get_NestingLevel()
  System.Void AddKeyHash(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Serialization.XmlArrayItemAttributes
TYPE:  class
TOKEN: 0x200011A
EXTENDS: CollectionBase
FIELDS:
METHODS:
  System.Xml.Serialization.XmlArrayItemAttribute get_Item(System.Int32 index)
  System.Int32 Add(System.Xml.Serialization.XmlArrayItemAttribute attribute)
  System.Void AddKeyHash(System.Text.StringBuilder sb)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlAttributeAttribute
TYPE:  class
TOKEN: 0x200011B
EXTENDS: Attribute
FIELDS:
  private           System.String                   attributeName  // 0x10
  private           System.String                   dataType  // 0x18
  private           System.Type                     type  // 0x20
  private           System.Xml.Schema.XmlSchemaForm form  // 0x28
  private           System.String                   ns  // 0x30
METHODS:
  System.Void .ctor(System.String attributeName)
  System.String get_AttributeName()
  System.String get_DataType()
  System.Void set_DataType(System.String value)
  System.Xml.Schema.XmlSchemaForm get_Form()
  System.String get_Namespace()
  System.Void AddKeyHash(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Serialization.XmlAttributeOverrides
TYPE:  class
TOKEN: 0x200011C
FIELDS:
  private           System.Collections.Hashtable    overrides  // 0x10
METHODS:
  System.Void .ctor()
  System.Xml.Serialization.XmlAttributes get_Item(System.Type type)
  System.Xml.Serialization.XmlAttributes get_Item(System.Type type, System.String member)
  System.Xml.Serialization.TypeMember GetKey(System.Type type, System.String member)
  System.Void AddKeyHash(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Serialization.XmlAttributes
TYPE:  class
TOKEN: 0x200011D
FIELDS:
  private           System.Xml.Serialization.XmlAnyAttributeAttributexmlAnyAttribute  // 0x10
  private           System.Xml.Serialization.XmlAnyElementAttributesxmlAnyElements  // 0x18
  private           System.Xml.Serialization.XmlArrayAttributexmlArray  // 0x20
  private           System.Xml.Serialization.XmlArrayItemAttributesxmlArrayItems  // 0x28
  private           System.Xml.Serialization.XmlAttributeAttributexmlAttribute  // 0x30
  private           System.Xml.Serialization.XmlChoiceIdentifierAttributexmlChoiceIdentifier  // 0x38
  private           System.Object                   xmlDefaultValue  // 0x40
  private           System.Xml.Serialization.XmlElementAttributesxmlElements  // 0x48
  private           System.Xml.Serialization.XmlEnumAttributexmlEnum  // 0x50
  private           System.Boolean                  xmlIgnore  // 0x58
  private           System.Boolean                  xmlns  // 0x59
  private           System.Xml.Serialization.XmlRootAttributexmlRoot  // 0x60
  private           System.Xml.Serialization.XmlTextAttributexmlText  // 0x68
  private           System.Xml.Serialization.XmlTypeAttributexmlType  // 0x70
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Reflection.ICustomAttributeProvider provider)
  System.Xml.Serialization.XmlAnyAttributeAttribute get_XmlAnyAttribute()
  System.Xml.Serialization.XmlAnyElementAttributes get_XmlAnyElements()
  System.Xml.Serialization.XmlArrayAttribute get_XmlArray()
  System.Xml.Serialization.XmlArrayItemAttributes get_XmlArrayItems()
  System.Xml.Serialization.XmlAttributeAttribute get_XmlAttribute()
  System.Xml.Serialization.XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier()
  System.Object get_XmlDefaultValue()
  System.Xml.Serialization.XmlElementAttributes get_XmlElements()
  System.Boolean get_XmlIgnore()
  System.Boolean get_Xmlns()
  System.Xml.Serialization.XmlRootAttribute get_XmlRoot()
  System.Xml.Serialization.XmlTextAttribute get_XmlText()
  System.Xml.Serialization.XmlTypeAttribute get_XmlType()
  System.Void AddKeyHash(System.Text.StringBuilder sb)
  System.Nullable<System.Int32> get_Order()
  System.Int32 get_SortableOrder()
END_CLASS

CLASS: System.Xml.Serialization.XmlChoiceIdentifierAttribute
TYPE:  class
TOKEN: 0x200011E
EXTENDS: Attribute
FIELDS:
  private           System.String                   memberName  // 0x10
METHODS:
  System.String get_MemberName()
  System.Void AddKeyHash(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Serialization.XmlCustomFormatter
TYPE:  class
TOKEN: 0x200011F
FIELDS:
  private   static  System.String[]                 allTimeFormats  // 0x0
METHODS:
  System.String FromEnum(System.Int64 value, System.String[] values, System.Int64[] ids, System.String typeName)
  System.String FromXmlName(System.String name)
  System.String FromXmlNCName(System.String ncName)
  System.String ToXmlString(System.Xml.Serialization.TypeData type, System.Object value)
  System.Object FromXmlString(System.Xml.Serialization.TypeData type, System.String value)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlElementAttribute
TYPE:  class
TOKEN: 0x2000120
EXTENDS: Attribute
FIELDS:
  private           System.String                   dataType  // 0x10
  private           System.String                   elementName  // 0x18
  private           System.Xml.Schema.XmlSchemaForm form  // 0x20
  private           System.String                   ns  // 0x28
  private           System.Boolean                  isNullable  // 0x30
  private           System.Type                     type  // 0x38
  private           System.Int32                    order  // 0x40
METHODS:
  System.Void .ctor(System.String elementName)
  System.Void .ctor(System.String elementName, System.Type type)
  System.String get_DataType()
  System.String get_ElementName()
  System.Xml.Schema.XmlSchemaForm get_Form()
  System.String get_Namespace()
  System.Boolean get_IsNullable()
  System.Int32 get_Order()
  System.Type get_Type()
  System.Void AddKeyHash(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Serialization.XmlElementAttributes
TYPE:  class
TOKEN: 0x2000121
EXTENDS: CollectionBase
FIELDS:
METHODS:
  System.Xml.Serialization.XmlElementAttribute get_Item(System.Int32 index)
  System.Int32 Add(System.Xml.Serialization.XmlElementAttribute attribute)
  System.Void AddKeyHash(System.Text.StringBuilder sb)
  System.Int32 get_Order()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlEnumAttribute
TYPE:  class
TOKEN: 0x2000122
EXTENDS: Attribute
FIELDS:
  private           System.String                   name  // 0x10
METHODS:
  System.Void .ctor(System.String name)
  System.String get_Name()
  System.Void AddKeyHash(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Serialization.XmlIgnoreAttribute
TYPE:  class
TOKEN: 0x2000123
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlIncludeAttribute
TYPE:  class
TOKEN: 0x2000124
EXTENDS: Attribute
FIELDS:
  private           System.Type                     type  // 0x10
METHODS:
  System.Type get_Type()
END_CLASS

CLASS: System.Xml.Serialization.XmlMapping
TYPE:  class
TOKEN: 0x2000125
FIELDS:
  private           System.Xml.Serialization.ObjectMapmap  // 0x10
  private           System.Collections.ArrayList    relatedMaps  // 0x18
  private           System.Xml.Serialization.SerializationFormatformat  // 0x20
  private           System.Xml.Serialization.SerializationSourcesource  // 0x28
  private           System.String                   _elementName  // 0x30
  private           System.String                   _namespace  // 0x38
  private           System.String                   key  // 0x40
METHODS:
  System.Void .ctor(System.String elementName, System.String ns)
  System.String get_ElementName()
  System.String get_Namespace()
  System.Void SetKey(System.String key)
  System.Xml.Serialization.ObjectMap get_ObjectMap()
  System.Void set_ObjectMap(System.Xml.Serialization.ObjectMap value)
  System.Collections.ArrayList get_RelatedMaps()
  System.Void set_RelatedMaps(System.Collections.ArrayList value)
  System.Xml.Serialization.SerializationFormat get_Format()
  System.Void set_Format(System.Xml.Serialization.SerializationFormat value)
  System.Xml.Serialization.SerializationSource get_Source()
END_CLASS

CLASS: System.Xml.Serialization.ObjectMap
TYPE:  class
TOKEN: 0x2000126
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.SerializationFormat
TYPE:  struct
TOKEN: 0x2000127
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.Serialization.SerializationFormatEncoded  // 0x0
  public    static  System.Xml.Serialization.SerializationFormatLiteral  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.Serialization.XmlMemberMapping
TYPE:  class
TOKEN: 0x2000128
FIELDS:
METHODS:
END_CLASS

CLASS: System.Xml.Serialization.XmlMembersMapping
TYPE:  class
TOKEN: 0x2000129
EXTENDS: XmlMapping
FIELDS:
  private           System.Boolean                  _hasWrapperElement  // 0x48
  private           System.Xml.Serialization.XmlMemberMapping[]_mapping  // 0x50
METHODS:
  System.Int32 get_Count()
  System.Boolean get_HasWrapperElement()
END_CLASS

CLASS: System.Xml.Serialization.XmlNamespaceDeclarationsAttribute
TYPE:  class
TOKEN: 0x200012A
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlReflectionImporter
TYPE:  class
TOKEN: 0x200012B
FIELDS:
  private           System.String                   initialDefaultNamespace  // 0x10
  private           System.Xml.Serialization.XmlAttributeOverridesattributeOverrides  // 0x18
  private           System.Collections.ArrayList    includedTypes  // 0x20
  private           System.Xml.Serialization.ReflectionHelperhelper  // 0x28
  private           System.Int32                    arrayChoiceCount  // 0x30
  private           System.Collections.ArrayList    relatedMaps  // 0x38
  private           System.Boolean                  allowPrivateTypes  // 0x40
  private   static readonly System.String                   errSimple  // 0x0
  private   static readonly System.String                   errSimple2  // 0x8
METHODS:
  System.Void .ctor(System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, System.String defaultNamespace)
  System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type)
  System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, System.String defaultNamespace)
  System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace)
  System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace)
  System.Xml.Serialization.XmlTypeMapping CreateTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultXmlType, System.String defaultNamespace)
  System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace, System.Boolean isBaseType)
  System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace, System.Boolean isBaseType)
  System.Void RegisterDerivedMap(System.Xml.Serialization.XmlTypeMapping map, System.Xml.Serialization.XmlTypeMapping derivedMap)
  System.String GetTypeNamespace(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace)
  System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace, System.Xml.Serialization.XmlAttributes atts, System.Int32 nestingLevel)
  System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace, System.Xml.Serialization.XmlAttributes atts, System.Int32 nestingLevel)
  System.Xml.Serialization.XmlTypeMapping ImportXmlNodeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace)
  System.Xml.Serialization.XmlTypeMapping ImportPrimitiveMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace)
  System.Xml.Serialization.XmlTypeMapping ImportEnumMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace)
  System.Xml.Serialization.XmlTypeMapping ImportXmlSerializableMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace)
  System.Void ImportIncludedTypes(System.Type type, System.String defaultNamespace)
  System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(System.Type type)
  System.Xml.Serialization.XmlTypeMapMember CreateMapMember(System.Type declaringType, System.Xml.Serialization.XmlReflectionMember rmember, System.String defaultNamespace)
  System.Xml.Serialization.XmlTypeMapElementInfoList ImportElementInfo(System.Type cls, System.String defaultName, System.String defaultNamespace, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts)
  System.Xml.Serialization.XmlTypeMapElementInfoList ImportAnyElementInfo(System.String defaultNamespace, System.Xml.Serialization.XmlReflectionMember rmember, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts)
  System.Void ImportTextElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList list, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts, System.String defaultNamespace)
  System.Boolean CanBeNull(System.Xml.Serialization.TypeData type)
  System.Void IncludeType(System.Type type)
  System.Object GetDefaultValue(System.Xml.Serialization.TypeData typeData, System.Object defaultValue)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlReflectionMember
TYPE:  class
TOKEN: 0x200012D
FIELDS:
  private           System.Boolean                  isReturnValue  // 0x10
  private           System.String                   memberName  // 0x18
  private           System.Type                     memberType  // 0x20
  private           System.Xml.Serialization.XmlAttributesxmlAttributes  // 0x28
  private           System.Type                     declaringType  // 0x30
METHODS:
  System.Void .ctor(System.String name, System.Type type, System.Xml.Serialization.XmlAttributes attributes)
  System.Boolean get_IsReturnValue()
  System.String get_MemberName()
  System.Type get_MemberType()
  System.Xml.Serialization.XmlAttributes get_XmlAttributes()
  System.Type get_DeclaringType()
  System.Void set_DeclaringType(System.Type value)
END_CLASS

CLASS: System.Xml.Serialization.XmlRootAttribute
TYPE:  class
TOKEN: 0x200012E
EXTENDS: Attribute
FIELDS:
  private           System.String                   dataType  // 0x10
  private           System.String                   elementName  // 0x18
  private           System.Boolean                  isNullable  // 0x20
  private           System.String                   ns  // 0x28
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String elementName)
  System.String get_DataType()
  System.Void set_DataType(System.String value)
  System.String get_ElementName()
  System.Void set_ElementName(System.String value)
  System.Boolean get_IsNullable()
  System.Void set_IsNullable(System.Boolean value)
  System.String get_Namespace()
  System.Void set_Namespace(System.String value)
  System.Void AddKeyHash(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Serialization.XmlSchemaProviderAttribute
TYPE:  class
TOKEN: 0x200012F
EXTENDS: Attribute
FIELDS:
  private           System.String                   _methodName  // 0x10
  private           System.Boolean                  _isAny  // 0x18
METHODS:
  System.Void .ctor(System.String methodName)
  System.String get_MethodName()
  System.Boolean get_IsAny()
  System.Void set_IsAny(System.Boolean value)
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializationCollectionFixupCallback
TYPE:  class
TOKEN: 0x2000130
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object collection, System.Object collectionItems)
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializationFixupCallback
TYPE:  class
TOKEN: 0x2000131
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object fixup)
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializationGeneratedCode
TYPE:  class
TOKEN: 0x2000132
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializationReadCallback
TYPE:  class
TOKEN: 0x2000133
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Object Invoke()
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializationReader
TYPE:  class
TOKEN: 0x2000134
EXTENDS: XmlSerializationGeneratedCode
FIELDS:
  private           System.Xml.XmlDocument          document  // 0x10
  private           System.Xml.XmlReader            reader  // 0x18
  private           System.Collections.ArrayList    fixups  // 0x20
  private           System.Collections.Hashtable    collFixups  // 0x28
  private           System.Collections.ArrayList    collItemFixups  // 0x30
  private           System.Collections.Hashtable    typesCallbacks  // 0x38
  private           System.Collections.ArrayList    noIDTargets  // 0x40
  private           System.Collections.Hashtable    targets  // 0x48
  private           System.Collections.Hashtable    delayedListFixups  // 0x50
  private           System.Xml.Serialization.XmlSerializereventSource  // 0x58
  private           System.Int32                    delayedFixupId  // 0x60
  private           System.Collections.Hashtable    referencedObjects  // 0x68
  private           System.Int32                    readCount  // 0x70
  private           System.Int32                    whileIterationCount  // 0x74
  private           System.String                   w3SchemaNS  // 0x78
  private           System.String                   w3InstanceNS  // 0x80
  private           System.String                   w3InstanceNS2000  // 0x88
  private           System.String                   w3InstanceNS1999  // 0x90
  private           System.String                   soapNS  // 0x98
  private           System.String                   wsdlNS  // 0xA0
  private           System.String                   nullX  // 0xA8
  private           System.String                   nil  // 0xB0
  private           System.String                   typeX  // 0xB8
  private           System.String                   arrayType  // 0xC0
  private           System.Xml.XmlQualifiedName     arrayQName  // 0xC8
METHODS:
  System.Void Initialize(System.Xml.XmlReader reader, System.Xml.Serialization.XmlSerializer eventSource)
  System.Collections.ArrayList EnsureArrayList(System.Collections.ArrayList list)
  System.Collections.Hashtable EnsureHashtable(System.Collections.Hashtable hash)
  System.Void .ctor()
  System.Xml.XmlDocument get_Document()
  System.Xml.XmlReader get_Reader()
  System.Void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionFixup fixup)
  System.Void AddFixup(System.Xml.Serialization.XmlSerializationReader.Fixup fixup)
  System.Void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionItemFixup fixup)
  System.Void AddReadCallback(System.String name, System.String ns, System.Type type, System.Xml.Serialization.XmlSerializationReadCallback read)
  System.Void AddTarget(System.String id, System.Object o)
  System.String CurrentTag()
  System.Exception CreateReadOnlyCollectionException(System.String name)
  System.Exception CreateUnknownConstantException(System.String value, System.Type enumType)
  System.Exception CreateUnknownNodeException()
  System.Exception CreateUnknownTypeException(System.Xml.XmlQualifiedName type)
  System.Array EnsureArrayIndex(System.Array a, System.Int32 index, System.Type elementType)
  System.Boolean GetNullAttr()
  System.Object GetTarget(System.String id)
  System.Boolean TargetReady(System.String id)
  System.Xml.XmlQualifiedName GetXsiType()
  System.Void InitCallbacks()
  System.Void InitIDs()
  System.Boolean IsXmlnsAttribute(System.String name)
  System.Void ParseWsdlArrayType(System.Xml.XmlAttribute attr)
  System.Xml.XmlQualifiedName ReadElementQualifiedName()
  System.Void ReadEndElement()
  System.Boolean ReadNull()
  System.Xml.XmlQualifiedName ReadNullableQualifiedName()
  System.String ReadNullableString()
  System.Object ReadReferencedElement()
  System.Xml.Serialization.XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(System.Xml.XmlQualifiedName qname)
  System.Object ReadReferencedElement(System.String name, System.String ns)
  System.Boolean ReadList(System.Object& resultList)
  System.Void ReadReferencedElements()
  System.Object ReadReferencingElement(System.String& fixupReference)
  System.Object ReadReferencingElement(System.String name, System.String ns, System.String& fixupReference)
  System.Object ReadReferencingElement(System.String name, System.String ns, System.Boolean elementCanBeType, System.String& fixupReference)
  System.Xml.Serialization.IXmlSerializable ReadSerializable(System.Xml.Serialization.IXmlSerializable serializable)
  System.Object ReadTypedPrimitive(System.Xml.XmlQualifiedName type)
  System.Object ReadTypedPrimitive(System.Xml.XmlQualifiedName qname, System.Boolean reportUnknown)
  System.Xml.XmlNode ReadXmlNode(System.Boolean wrapped)
  System.Xml.XmlDocument ReadXmlDocument(System.Boolean wrapped)
  System.Array ShrinkArray(System.Array a, System.Int32 length, System.Type elementType, System.Boolean isNullable)
  System.Xml.XmlQualifiedName ToXmlQualifiedName(System.String value)
  System.Void UnknownAttribute(System.Object o, System.Xml.XmlAttribute attr, System.String qnames)
  System.Void UnknownElement(System.Object o, System.Xml.XmlElement elem, System.String qnames)
  System.Void UnknownNode(System.Object o)
  System.Void UnknownNode(System.Object o, System.String qnames)
  System.Void OnUnknownNode(System.Xml.XmlNode node, System.Object o, System.String qnames)
  System.Void UnreferencedObject(System.String id, System.Object o)
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializationReaderInterpreter
TYPE:  class
TOKEN: 0x2000139
EXTENDS: XmlSerializationReader
FIELDS:
  private           System.Xml.Serialization.XmlMapping_typeMap  // 0xD0
  private           System.Xml.Serialization.SerializationFormat_format  // 0xD8
  private   static readonly System.Xml.XmlQualifiedName     AnyType  // 0x0
  private   static readonly System.Object[]                 empty_array  // 0x8
METHODS:
  System.Void .ctor(System.Xml.Serialization.XmlMapping typeMap)
  System.Void InitCallbacks()
  System.Void InitIDs()
  System.Object ReadRoot()
  System.Object ReadEncodedObject(System.Xml.Serialization.XmlTypeMapping typeMap)
  System.Object ReadMessage(System.Xml.Serialization.XmlMembersMapping typeMap)
  System.Object ReadRoot(System.Xml.Serialization.XmlTypeMapping rootMap)
  System.Object ReadObject(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable, System.Boolean checkType)
  System.Object ReadClassInstance(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable, System.Boolean checkType)
  System.Void ReadClassInstanceMembers(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob)
  System.Void ReadAttributeMembers(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList)
  System.Void ReadMembers(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList, System.Boolean readBySoapOrder)
  System.Void SetListMembersDefaults(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList)
  System.Void FixupMembers(System.Xml.Serialization.ClassMap map, System.Object obfixup, System.Boolean isValueList)
  System.Void ProcessUnknownAttribute(System.Object target)
  System.Void ProcessUnknownElement(System.Object target)
  System.Boolean IsReadOnly(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData memType, System.Object ob, System.Boolean isValueList)
  System.Void SetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, System.Object ob, System.Object value, System.Boolean isValueList)
  System.Void SetMemberValueFromAttr(System.Xml.Serialization.XmlTypeMapMember member, System.Object ob, System.Object value, System.Boolean isValueList)
  System.Object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, System.Object ob, System.Boolean isValueList)
  System.Object ReadObjectElement(System.Xml.Serialization.XmlTypeMapElementInfo elem)
  System.Object ReadPrimitiveValue(System.Xml.Serialization.XmlTypeMapElementInfo elem)
  System.Object GetValueFromXmlString(System.String value, System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlTypeMapping typeMap)
  System.Object ReadListElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable, System.Object list, System.Boolean canCreateInstance)
  System.Object ReadListString(System.Xml.Serialization.XmlTypeMapping typeMap, System.String values)
  System.Void AddListValue(System.Xml.Serialization.TypeData listType, System.Object& list, System.Int32 index, System.Object value, System.Boolean canCreateInstance)
  System.Object CreateInstance(System.Type type, System.Boolean nonPublic)
  System.Object CreateInstance(System.Type type)
  System.Object CreateList(System.Type listType)
  System.Object InitializeList(System.Xml.Serialization.TypeData listType)
  System.Void FillList(System.Object list, System.Object items)
  System.Void CopyEnumerableList(System.Object source, System.Object dest)
  System.Object ReadXmlNodeElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable)
  System.Object ReadXmlNode(System.Xml.Serialization.TypeData type, System.Boolean wrapped)
  System.Object ReadPrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable)
  System.Object ReadEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable)
  System.Object GetEnumValue(System.Xml.Serialization.XmlTypeMapping typeMap, System.String val)
  System.Object ReadXmlSerializableElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Boolean isNullable)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializationWriteCallback
TYPE:  class
TOKEN: 0x200013C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object o)
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializationWriter
TYPE:  class
TOKEN: 0x200013D
EXTENDS: XmlSerializationGeneratedCode
FIELDS:
  private           System.Runtime.Serialization.ObjectIDGeneratoridGenerator  // 0x10
  private           System.Int32                    qnameCount  // 0x18
  private           System.Boolean                  topLevelElement  // 0x1C
  private           System.Collections.ArrayList    namespaces  // 0x20
  private           System.Xml.XmlWriter            writer  // 0x28
  private           System.Collections.Queue        referencedElements  // 0x30
  private           System.Collections.Hashtable    callbacks  // 0x38
  private           System.Collections.Hashtable    serializedObjects  // 0x40
METHODS:
  System.Void .ctor()
  System.Void Initialize(System.Xml.XmlWriter writer, System.Xml.Serialization.XmlSerializerNamespaces nss)
  System.Xml.XmlWriter get_Writer()
  System.Void AddWriteCallback(System.Type type, System.String typeName, System.String typeNs, System.Xml.Serialization.XmlSerializationWriteCallback callback)
  System.Exception CreateUnknownAnyElementException(System.String name, System.String ns)
  System.Exception CreateUnknownTypeException(System.Object o)
  System.Exception CreateUnknownTypeException(System.Type type)
  System.String FromXmlQualifiedName(System.Xml.XmlQualifiedName xmlQualifiedName)
  System.String GetId(System.Object o, System.Boolean addToReferencesList)
  System.Boolean AlreadyQueued(System.Object ob)
  System.String GetNamespacePrefix(System.String ns)
  System.String GetQualifiedName(System.String name, System.String ns)
  System.Void InitCallbacks()
  System.Void TopLevelElement()
  System.Void WriteAttribute(System.String localName, System.String ns, System.String value)
  System.Void WriteAttribute(System.String prefix, System.String localName, System.String ns, System.String value)
  System.Void WriteXmlNode(System.Xml.XmlNode node)
  System.Void WriteElementEncoded(System.Xml.XmlNode node, System.String name, System.String ns, System.Boolean isNullable, System.Boolean any)
  System.Void WriteElementLiteral(System.Xml.XmlNode node, System.String name, System.String ns, System.Boolean isNullable, System.Boolean any)
  System.Void WriteElementQualifiedName(System.String localName, System.String ns, System.Xml.XmlQualifiedName value)
  System.Void WriteElementQualifiedName(System.String localName, System.String ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType)
  System.Void WriteElementString(System.String localName, System.String ns, System.String value)
  System.Void WriteElementString(System.String localName, System.String ns, System.String value, System.Xml.XmlQualifiedName xsiType)
  System.Void WriteEndElement()
  System.Void WriteEndElement(System.Object o)
  System.Void WriteNamespaceDeclarations(System.Xml.Serialization.XmlSerializerNamespaces xmlns)
  System.Void WriteNullableQualifiedNameEncoded(System.String name, System.String ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType)
  System.Void WriteNullableQualifiedNameLiteral(System.String name, System.String ns, System.Xml.XmlQualifiedName value)
  System.Void WriteNullableStringEncoded(System.String name, System.String ns, System.String value, System.Xml.XmlQualifiedName xsiType)
  System.Void WriteNullableStringLiteral(System.String name, System.String ns, System.String value)
  System.Void WriteNullTagEncoded(System.String name, System.String ns)
  System.Void WriteNullTagLiteral(System.String name, System.String ns)
  System.Void WritePotentiallyReferencingElement(System.String n, System.String ns, System.Object o, System.Type ambientType, System.Boolean suppressReference, System.Boolean isNullable)
  System.Void WriteReferencedElements()
  System.Boolean IsPrimitiveArray(System.Xml.Serialization.TypeData td)
  System.Void WriteArray(System.Object o, System.Xml.Serialization.TypeData td)
  System.Void WriteReferencingElement(System.String n, System.String ns, System.Object o, System.Boolean isNullable)
  System.Void CheckReferenceQueue()
  System.Void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, System.String name, System.String ns, System.Boolean isNullable)
  System.Void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, System.String name, System.String ns, System.Boolean isNullable, System.Boolean wrapped)
  System.Void WriteStartDocument()
  System.Void WriteStartElement(System.String name, System.String ns)
  System.Void WriteStartElement(System.String name, System.String ns, System.Boolean writePrefixed)
  System.Void WriteStartElement(System.String name, System.String ns, System.Object o)
  System.Void WriteStartElement(System.String name, System.String ns, System.Object o, System.Boolean writePrefixed)
  System.Void WriteStartElement(System.String name, System.String ns, System.Object o, System.Boolean writePrefixed, System.Collections.ICollection namespaces)
  System.Void WriteTypedPrimitive(System.String name, System.String ns, System.Object o, System.Boolean xsiType)
  System.Void WriteValue(System.String value)
  System.Void WriteXmlAttribute(System.Xml.XmlNode node, System.Object container)
  System.Void WriteXsiType(System.String name, System.String ns)
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializationWriterInterpreter
TYPE:  class
TOKEN: 0x200013F
EXTENDS: XmlSerializationWriter
FIELDS:
  private           System.Xml.Serialization.XmlMapping_typeMap  // 0x48
  private           System.Xml.Serialization.SerializationFormat_format  // 0x50
METHODS:
  System.Void .ctor(System.Xml.Serialization.XmlMapping typeMap)
  System.Void InitCallbacks()
  System.Void WriteRoot(System.Object ob)
  System.Void WriteObject(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob, System.String element, System.String namesp, System.Boolean isNullable, System.Boolean needType, System.Boolean writeWrappingElem)
  System.Void WriteMessage(System.Xml.Serialization.XmlMembersMapping membersMap, System.Object[] parameters)
  System.Void WriteObjectElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob, System.String element, System.String namesp)
  System.Void WriteObjectElementAttributes(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob)
  System.Void WriteObjectElementElements(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob)
  System.Void WriteMembers(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList)
  System.Void WriteAttributeMembers(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList)
  System.Void WriteElementMembers(System.Xml.Serialization.ClassMap map, System.Object ob, System.Boolean isValueList)
  System.Object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, System.Object ob, System.Boolean isValueList)
  System.Boolean MemberHasValue(System.Xml.Serialization.XmlTypeMapMember member, System.Object ob, System.Boolean isValueList)
  System.Void WriteMemberElement(System.Xml.Serialization.XmlTypeMapElementInfo elem, System.Object memberValue)
  System.Object ImplicitConvert(System.Object obj, System.Type type)
  System.Void WritePrimitiveValueLiteral(System.Object memberValue, System.String name, System.String ns, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, System.Boolean wrapped, System.Boolean isNullable)
  System.Void WritePrimitiveValueEncoded(System.Object memberValue, System.String name, System.String ns, System.Xml.XmlQualifiedName xsiType, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, System.Boolean wrapped, System.Boolean isNullable)
  System.Void WriteListElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob, System.String element, System.String namesp)
  System.Void WriteListContent(System.Object container, System.Xml.Serialization.TypeData listType, System.Xml.Serialization.ListMap map, System.Object ob, System.Text.StringBuilder targetString)
  System.Int32 GetListCount(System.Xml.Serialization.TypeData listType, System.Object ob)
  System.Void WriteAnyElementContent(System.Xml.Serialization.XmlTypeMapMemberAnyElement member, System.Object memberValue)
  System.Void WritePrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob, System.String element, System.String namesp)
  System.Void WriteEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob, System.String element, System.String namesp)
  System.String GetStringValue(System.Xml.Serialization.XmlTypeMapping typeMap, System.Xml.Serialization.TypeData type, System.Object value)
  System.String GetEnumXmlValue(System.Xml.Serialization.XmlTypeMapping typeMap, System.Object ob)
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializer
TYPE:  class
TOKEN: 0x2000141
FIELDS:
  private   static  System.Int32                    generationThreshold  // 0x0
  private   static  System.Boolean                  backgroundGeneration  // 0x4
  private   static  System.Boolean                  deleteTempFiles  // 0x5
  private   static  System.Boolean                  generatorFallback  // 0x6
  private           System.Boolean                  customSerializer  // 0x10
  private           System.Xml.Serialization.XmlMappingtypeMapping  // 0x18
  private           System.Xml.Serialization.XmlSerializer.SerializerDataserializerData  // 0x20
  private   static  System.Collections.Hashtable    serializerTypes  // 0x8
  private           System.Xml.Serialization.UnreferencedObjectEventHandleronUnreferencedObject  // 0x28
  private           System.Xml.Serialization.XmlAttributeEventHandleronUnknownAttribute  // 0x30
  private           System.Xml.Serialization.XmlElementEventHandleronUnknownElement  // 0x38
  private           System.Xml.Serialization.XmlNodeEventHandleronUnknownNode  // 0x40
METHODS:
  System.Void .cctor()
  System.Void .ctor(System.Type type)
  System.Void .ctor(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace)
  System.Xml.Serialization.XmlMapping get_Mapping()
  System.Void OnUnknownAttribute(System.Xml.Serialization.XmlAttributeEventArgs e)
  System.Void OnUnknownElement(System.Xml.Serialization.XmlElementEventArgs e)
  System.Void OnUnknownNode(System.Xml.Serialization.XmlNodeEventArgs e)
  System.Void OnUnreferencedObject(System.Xml.Serialization.UnreferencedObjectEventArgs e)
  System.Xml.Serialization.XmlSerializationReader CreateReader()
  System.Xml.Serialization.XmlSerializationWriter CreateWriter()
  System.Object Deserialize(System.IO.TextReader textReader)
  System.Object Deserialize(System.Xml.XmlReader xmlReader)
  System.Object Deserialize(System.Xml.Serialization.XmlSerializationReader reader)
  System.Void Serialize(System.Object o, System.Xml.Serialization.XmlSerializationWriter writer)
  System.Void Serialize(System.IO.TextWriter textWriter, System.Object o)
  System.Void Serialize(System.Xml.XmlWriter xmlWriter, System.Object o)
  System.Void Serialize(System.Xml.XmlWriter xmlWriter, System.Object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces)
  System.Xml.Serialization.XmlSerializationWriter CreateWriter(System.Xml.Serialization.XmlMapping typeMapping)
  System.Xml.Serialization.XmlSerializationReader CreateReader(System.Xml.Serialization.XmlMapping typeMapping)
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializerFactory
TYPE:  class
TOKEN: 0x2000143
FIELDS:
  private   static  System.Collections.Hashtable    serializersBySource  // 0x0
METHODS:
  System.Void .ctor()
  System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type)
  System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute root)
  System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, System.String defaultNamespace)
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializerImplementation
TYPE:  class
TOKEN: 0x2000144
FIELDS:
METHODS:
  System.Xml.Serialization.XmlSerializationWriter get_Writer()
END_CLASS

CLASS: System.Xml.Serialization.XmlTextAttribute
TYPE:  class
TOKEN: 0x2000145
EXTENDS: Attribute
FIELDS:
  private           System.String                   dataType  // 0x10
  private           System.Type                     type  // 0x18
METHODS:
  System.Void .ctor()
  System.String get_DataType()
  System.Type get_Type()
  System.Void AddKeyHash(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeAttribute
TYPE:  class
TOKEN: 0x2000146
EXTENDS: Attribute
FIELDS:
  private           System.Boolean                  includeInSchema  // 0x10
  private           System.String                   ns  // 0x18
  private           System.String                   typeName  // 0x20
METHODS:
  System.Boolean get_IncludeInSchema()
  System.String get_Namespace()
  System.String get_TypeName()
  System.Void AddKeyHash(System.Text.StringBuilder sb)
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapElementInfo
TYPE:  class
TOKEN: 0x2000147
FIELDS:
  private           System.String                   _elementName  // 0x10
  private           System.String                   _namespace  // 0x18
  private           System.Xml.Schema.XmlSchemaForm _form  // 0x20
  private           System.Xml.Serialization.XmlTypeMapMember_member  // 0x28
  private           System.Object                   _choiceValue  // 0x30
  private           System.Boolean                  _isNullable  // 0x38
  private           System.Int32                    _nestingLevel  // 0x3C
  private           System.Xml.Serialization.XmlTypeMapping_mappedType  // 0x40
  private           System.Xml.Serialization.TypeData_type  // 0x48
  private           System.Boolean                  _wrappedElement  // 0x50
  private           System.Int32                    _explicitOrder  // 0x54
METHODS:
  System.Void .ctor(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData type)
  System.Xml.Serialization.TypeData get_TypeData()
  System.Object get_ChoiceValue()
  System.Void set_ChoiceValue(System.Object value)
  System.String get_ElementName()
  System.Void set_ElementName(System.String value)
  System.String get_Namespace()
  System.Void set_Namespace(System.String value)
  System.String get_DataTypeNamespace()
  System.String get_DataTypeName()
  System.Xml.Schema.XmlSchemaForm get_Form()
  System.Void set_Form(System.Xml.Schema.XmlSchemaForm value)
  System.Xml.Serialization.XmlTypeMapping get_MappedType()
  System.Void set_MappedType(System.Xml.Serialization.XmlTypeMapping value)
  System.Boolean get_IsNullable()
  System.Void set_IsNullable(System.Boolean value)
  System.Xml.Serialization.XmlTypeMapMember get_Member()
  System.Void set_NestingLevel(System.Int32 value)
  System.Boolean get_MultiReferenceType()
  System.Boolean get_WrappedElement()
  System.Void set_WrappedElement(System.Boolean value)
  System.Boolean get_IsTextElement()
  System.Void set_IsTextElement(System.Boolean value)
  System.Boolean get_IsUnnamedAnyElement()
  System.Void set_IsUnnamedAnyElement(System.Boolean value)
  System.Int32 get_ExplicitOrder()
  System.Void set_ExplicitOrder(System.Int32 value)
  System.Boolean Equals(System.Object other)
  System.Int32 GetHashCode()
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapElementInfoList
TYPE:  class
TOKEN: 0x2000148
EXTENDS: ArrayList
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapMember
TYPE:  class
TOKEN: 0x2000149
FIELDS:
  private           System.String                   _name  // 0x10
  private           System.Int32                    _index  // 0x18
  private           System.Int32                    _globalIndex  // 0x1C
  private           System.Int32                    _specifiedGlobalIndex  // 0x20
  private           System.Xml.Serialization.TypeData_typeData  // 0x28
  private           System.Reflection.MemberInfo    _member  // 0x30
  private           System.Reflection.MemberInfo    _specifiedMember  // 0x38
  private           System.Reflection.MethodInfo    _shouldSerialize  // 0x40
  private           System.Object                   _defaultValue  // 0x48
  private           System.Int32                    _flags  // 0x50
METHODS:
  System.Void .ctor()
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Object get_DefaultValue()
  System.Void set_DefaultValue(System.Object value)
  System.Boolean IsReadOnly(System.Type type)
  System.Object GetValue(System.Object ob, System.String name)
  System.Object GetValue(System.Object ob)
  System.Void SetValue(System.Object ob, System.Object value)
  System.Void SetValue(System.Object ob, System.String name, System.Object value)
  System.Void InitMember(System.Type type)
  System.Xml.Serialization.TypeData get_TypeData()
  System.Void set_TypeData(System.Xml.Serialization.TypeData value)
  System.Int32 get_Index()
  System.Void set_Index(System.Int32 value)
  System.Int32 get_GlobalIndex()
  System.Void set_GlobalIndex(System.Int32 value)
  System.Boolean get_IsOptionalValueType()
  System.Void set_IsOptionalValueType(System.Boolean value)
  System.Boolean get_IsReturnValue()
  System.Void set_IsReturnValue(System.Boolean value)
  System.Void CheckOptionalValueType(System.Type type)
  System.Boolean GetValueSpecified(System.Object ob)
  System.Void SetValueSpecified(System.Object ob, System.Boolean value)
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapMemberAttribute
TYPE:  class
TOKEN: 0x200014A
EXTENDS: XmlTypeMapMember
FIELDS:
  private           System.String                   _attributeName  // 0x58
  private           System.String                   _namespace  // 0x60
  private           System.Xml.Schema.XmlSchemaForm _form  // 0x68
  private           System.Xml.Serialization.XmlTypeMapping_mappedType  // 0x70
METHODS:
  System.Void .ctor()
  System.String get_AttributeName()
  System.Void set_AttributeName(System.String value)
  System.String get_Namespace()
  System.Void set_Namespace(System.String value)
  System.Void set_Form(System.Xml.Schema.XmlSchemaForm value)
  System.Xml.Serialization.XmlTypeMapping get_MappedType()
  System.Void set_MappedType(System.Xml.Serialization.XmlTypeMapping value)
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapMemberElement
TYPE:  class
TOKEN: 0x200014B
EXTENDS: XmlTypeMapMember
FIELDS:
  private           System.Xml.Serialization.XmlTypeMapElementInfoList_elementInfo  // 0x58
  private           System.String                   _choiceMember  // 0x60
  private           System.Boolean                  _isTextCollector  // 0x68
  private           System.Xml.Serialization.TypeData_choiceTypeData  // 0x70
METHODS:
  System.Void .ctor()
  System.Xml.Serialization.XmlTypeMapElementInfoList get_ElementInfo()
  System.Void set_ElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value)
  System.String get_ChoiceMember()
  System.Void set_ChoiceMember(System.String value)
  System.Xml.Serialization.TypeData get_ChoiceTypeData()
  System.Void set_ChoiceTypeData(System.Xml.Serialization.TypeData value)
  System.Xml.Serialization.XmlTypeMapElementInfo FindElement(System.Object ob, System.Object memberValue)
  System.Void SetChoice(System.Object ob, System.Object choice)
  System.Boolean get_IsXmlTextCollector()
  System.Void set_IsXmlTextCollector(System.Boolean value)
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapMemberList
TYPE:  class
TOKEN: 0x200014C
EXTENDS: XmlTypeMapMemberElement
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapMemberExpandable
TYPE:  class
TOKEN: 0x200014D
EXTENDS: XmlTypeMapMemberElement
FIELDS:
  private           System.Int32                    _flatArrayIndex  // 0x78
METHODS:
  System.Int32 get_FlatArrayIndex()
  System.Void set_FlatArrayIndex(System.Int32 value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapMemberFlatList
TYPE:  class
TOKEN: 0x200014E
EXTENDS: XmlTypeMapMemberExpandable
FIELDS:
  private           System.Xml.Serialization.ListMap_listMap  // 0x80
METHODS:
  System.Xml.Serialization.ListMap get_ListMap()
  System.Void set_ListMap(System.Xml.Serialization.ListMap value)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapMemberAnyElement
TYPE:  class
TOKEN: 0x200014F
EXTENDS: XmlTypeMapMemberExpandable
FIELDS:
METHODS:
  System.Boolean IsElementDefined(System.String name, System.String ns)
  System.Boolean get_IsDefaultAny()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapMemberAnyAttribute
TYPE:  class
TOKEN: 0x2000150
EXTENDS: XmlTypeMapMember
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapMemberNamespaces
TYPE:  class
TOKEN: 0x2000151
EXTENDS: XmlTypeMapMember
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.XmlTypeMapping
TYPE:  class
TOKEN: 0x2000152
EXTENDS: XmlMapping
FIELDS:
  private           System.String                   xmlType  // 0x48
  private           System.String                   xmlTypeNamespace  // 0x50
  private           System.Xml.Serialization.TypeDatatype  // 0x58
  private           System.Xml.Serialization.XmlTypeMappingbaseMap  // 0x60
  private           System.Boolean                  multiReferenceType  // 0x68
  private           System.Boolean                  includeInSchema  // 0x69
  private           System.Boolean                  isNullable  // 0x6A
  private           System.Boolean                  isAny  // 0x6B
  private           System.Collections.ArrayList    _derivedTypes  // 0x70
METHODS:
  System.Void .ctor(System.String elementName, System.String ns, System.Xml.Serialization.TypeData typeData, System.String xmlType, System.String xmlTypeNamespace)
  System.String get_TypeFullName()
  System.Xml.Serialization.TypeData get_TypeData()
  System.String get_XmlType()
  System.Void set_XmlType(System.String value)
  System.String get_XmlTypeNamespace()
  System.Void set_XmlTypeNamespace(System.String value)
  System.Boolean get_HasXmlTypeNamespace()
  System.Collections.ArrayList get_DerivedTypes()
  System.Boolean get_MultiReferenceType()
  System.Xml.Serialization.XmlTypeMapping get_BaseMap()
  System.Void set_BaseMap(System.Xml.Serialization.XmlTypeMapping value)
  System.Void set_IncludeInSchema(System.Boolean value)
  System.Boolean get_IsNullable()
  System.Void set_IsNullable(System.Boolean value)
  System.Boolean get_IsAny()
  System.Void set_IsAny(System.Boolean value)
  System.Xml.Serialization.XmlTypeMapping GetRealTypeMap(System.Type objectType)
  System.Xml.Serialization.XmlTypeMapping GetRealElementMap(System.String name, System.String ens)
  System.Void UpdateRoot(System.Xml.XmlQualifiedName qname)
END_CLASS

CLASS: System.Xml.Serialization.XmlSerializableMapping
TYPE:  class
TOKEN: 0x2000153
EXTENDS: XmlTypeMapping
FIELDS:
  private           System.Xml.Schema.XmlSchema     _schema  // 0x78
  private           System.Xml.Schema.XmlSchemaComplexType_schemaType  // 0x80
  private           System.Xml.XmlQualifiedName     _schemaTypeName  // 0x88
METHODS:
  System.Void .ctor(System.Xml.Serialization.XmlRootAttribute root, System.String elementName, System.String ns, System.Xml.Serialization.TypeData typeData, System.String xmlType, System.String xmlTypeNamespace)
END_CLASS

CLASS: System.Xml.Serialization.ClassMap
TYPE:  class
TOKEN: 0x2000154
EXTENDS: ObjectMap
FIELDS:
  private           System.Collections.Hashtable    _elements  // 0x10
  private           System.Collections.ArrayList    _elementMembers  // 0x18
  private           System.Collections.Hashtable    _attributeMembers  // 0x20
  private           System.Xml.Serialization.XmlTypeMapMemberAttribute[]_attributeMembersArray  // 0x28
  private           System.Collections.ArrayList    _flatLists  // 0x30
  private           System.Collections.ArrayList    _allMembers  // 0x38
  private           System.Collections.ArrayList    _membersWithDefault  // 0x40
  private           System.Collections.ArrayList    _listMembers  // 0x48
  private           System.Xml.Serialization.XmlTypeMapMemberAnyElement_defaultAnyElement  // 0x50
  private           System.Xml.Serialization.XmlTypeMapMemberAnyAttribute_defaultAnyAttribute  // 0x58
  private           System.Xml.Serialization.XmlTypeMapMemberNamespaces_namespaceDeclarations  // 0x60
  private           System.Xml.Serialization.XmlTypeMapMember_xmlTextCollector  // 0x68
  private           System.Xml.Serialization.XmlTypeMapMember_returnMember  // 0x70
  private           System.Boolean                  _ignoreMemberNamespace  // 0x78
  private           System.Boolean                  _canBeSimpleType  // 0x79
  private           System.Nullable<System.Boolean> _isOrderDependentMap  // 0x7A
METHODS:
  System.Void AddMember(System.Xml.Serialization.XmlTypeMapMember member)
  System.Void RegisterFlatList(System.Xml.Serialization.XmlTypeMapMemberExpandable member)
  System.Xml.Serialization.XmlTypeMapMemberAttribute GetAttribute(System.String name, System.String ns)
  System.Xml.Serialization.XmlTypeMapElementInfo GetElement(System.String name, System.String ns, System.Int32 minimalOrder)
  System.Xml.Serialization.XmlTypeMapElementInfo GetElement(System.String name, System.String ns)
  System.String BuildKey(System.String name, System.String ns, System.Int32 explicitOrder)
  System.Boolean get_IsOrderDependentMap()
  System.Xml.Serialization.XmlTypeMapMemberAnyElement get_DefaultAnyElementMember()
  System.Xml.Serialization.XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember()
  System.Xml.Serialization.XmlTypeMapMemberNamespaces get_NamespaceDeclarations()
  System.Collections.ICollection get_AttributeMembers()
  System.Collections.ICollection get_ElementMembers()
  System.Collections.ArrayList get_AllMembers()
  System.Collections.ArrayList get_FlatLists()
  System.Collections.ArrayList get_ListMembers()
  System.Xml.Serialization.XmlTypeMapMember get_XmlTextCollector()
  System.Xml.Serialization.XmlTypeMapMember get_ReturnMember()
  System.Xml.XmlQualifiedName get_SimpleContentBaseType()
  System.Void SetCanBeSimpleType(System.Boolean can)
  System.Boolean get_HasSimpleContent()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.ListMap
TYPE:  class
TOKEN: 0x2000155
EXTENDS: ObjectMap
FIELDS:
  private           System.Xml.Serialization.XmlTypeMapElementInfoList_itemInfo  // 0x10
  private           System.String                   _choiceMember  // 0x18
METHODS:
  System.Void set_ChoiceMember(System.String value)
  System.Xml.Serialization.XmlTypeMapElementInfoList get_ItemInfo()
  System.Void set_ItemInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value)
  System.Xml.Serialization.XmlTypeMapElementInfo FindElement(System.Object ob, System.Int32 index, System.Object memberValue)
  System.Xml.Serialization.XmlTypeMapElementInfo FindElement(System.String elementName, System.String ns)
  System.Xml.Serialization.XmlTypeMapElementInfo FindTextElement()
  System.Void GetArrayType(System.Int32 itemCount, System.String& localName, System.String& ns)
  System.Boolean Equals(System.Object other)
  System.Int32 GetHashCode()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.Serialization.EnumMap
TYPE:  class
TOKEN: 0x2000156
EXTENDS: ObjectMap
FIELDS:
  private   readonly System.Xml.Serialization.EnumMap.EnumMapMember[]_members  // 0x10
  private   readonly System.Boolean                  _isFlags  // 0x18
  private   readonly System.String[]                 _enumNames  // 0x20
  private   readonly System.String[]                 _xmlNames  // 0x28
  private   readonly System.Int64[]                  _values  // 0x30
METHODS:
  System.Void .ctor(System.Xml.Serialization.EnumMap.EnumMapMember[] members, System.Boolean isFlags)
  System.Boolean get_IsFlags()
  System.String[] get_EnumNames()
  System.String[] get_XmlNames()
  System.Int64[] get_Values()
  System.String GetXmlName(System.String typeName, System.Object enumValue)
  System.String GetEnumName(System.String typeName, System.String xmlName)
END_CLASS

CLASS: System.Xml.XPath.IXPathNavigable
TYPE:  interface
TOKEN: 0x20000F4
FIELDS:
METHODS:
  System.Xml.XPath.XPathNavigator CreateNavigator()
END_CLASS

CLASS: System.Xml.XPath.XPathDocument
TYPE:  class
TOKEN: 0x20000F5
FIELDS:
  private           MS.Internal.Xml.Cache.XPathNode[]pageText  // 0x10
  private           MS.Internal.Xml.Cache.XPathNode[]pageRoot  // 0x18
  private           MS.Internal.Xml.Cache.XPathNode[]pageXmlNmsp  // 0x20
  private           System.Int32                    idxText  // 0x28
  private           System.Int32                    idxRoot  // 0x2C
  private           System.Int32                    idxXmlNmsp  // 0x30
  private           System.Xml.XmlNameTable         nameTable  // 0x38
  private           System.Boolean                  hasLineInfo  // 0x40
  private           System.Collections.Generic.Dictionary<MS.Internal.Xml.Cache.XPathNodeRef,MS.Internal.Xml.Cache.XPathNodeRef>mapNmsp  // 0x48
  private           System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.Cache.XPathNodeRef>idValueMap  // 0x50
METHODS:
  System.Xml.XmlNameTable get_NameTable()
  System.Boolean get_HasLineInfo()
  System.Int32 GetCollapsedTextNode(MS.Internal.Xml.Cache.XPathNode[]& pageText)
  System.Int32 GetRootNode(MS.Internal.Xml.Cache.XPathNode[]& pageRoot)
  System.Int32 GetXmlNamespaceNode(MS.Internal.Xml.Cache.XPathNode[]& pageXmlNmsp)
  System.Int32 LookupNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, System.Int32 idxElem, MS.Internal.Xml.Cache.XPathNode[]& pageNmsp)
  System.Int32 LookupIdElement(System.String id, MS.Internal.Xml.Cache.XPathNode[]& pageElem)
END_CLASS

CLASS: System.Xml.XPath.XPathException
TYPE:  class
TOKEN: 0x20000F6
EXTENDS: SystemException
FIELDS:
  private           System.String                   res  // 0x90
  private           System.String[]                 args  // 0x98
  private           System.String                   message  // 0xA0
METHODS:
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Void .ctor(System.String message, System.Exception innerException)
  System.Xml.XPath.XPathException Create(System.String res)
  System.Xml.XPath.XPathException Create(System.String res, System.String arg)
  System.Xml.XPath.XPathException Create(System.String res, System.String arg, System.String arg2)
  System.Xml.XPath.XPathException Create(System.String res, System.String arg, System.Exception innerException)
  System.Void .ctor(System.String res, System.String[] args)
  System.Void .ctor(System.String res, System.String[] args, System.Exception inner)
  System.String CreateMessage(System.String res, System.String[] args)
  System.String get_Message()
END_CLASS

CLASS: System.Xml.XPath.XPathResultType
TYPE:  struct
TOKEN: 0x20000F7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XPath.XPathResultTypeNumber  // 0x0
  public    static  System.Xml.XPath.XPathResultTypeString  // 0x0
  public    static  System.Xml.XPath.XPathResultTypeBoolean  // 0x0
  public    static  System.Xml.XPath.XPathResultTypeNodeSet  // 0x0
  public    static  System.Xml.XPath.XPathResultTypeNavigator  // 0x0
  public    static  System.Xml.XPath.XPathResultTypeAny  // 0x0
  public    static  System.Xml.XPath.XPathResultTypeError  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XPath.XPathExpression
TYPE:  class
TOKEN: 0x20000F8
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void SetContext(System.Xml.IXmlNamespaceResolver nsResolver)
  System.Xml.XPath.XPathExpression Compile(System.String xpath)
  System.Xml.XPath.XPathExpression Compile(System.String xpath, System.Xml.IXmlNamespaceResolver nsResolver)
END_CLASS

CLASS: System.Xml.XPath.XPathItem
TYPE:  class
TOKEN: 0x20000F9
FIELDS:
METHODS:
  System.Xml.Schema.XmlSchemaType get_XmlType()
  System.String get_Value()
  System.Object get_TypedValue()
  System.Type get_ValueType()
  System.Boolean get_ValueAsBoolean()
  System.DateTime get_ValueAsDateTime()
  System.Double get_ValueAsDouble()
  System.Int32 get_ValueAsInt()
  System.Int64 get_ValueAsLong()
  System.Object ValueAs(System.Type returnType)
  System.Object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.XPath.XPathNamespaceScope
TYPE:  struct
TOKEN: 0x20000FA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XPath.XPathNamespaceScopeAll  // 0x0
  public    static  System.Xml.XPath.XPathNamespaceScopeExcludeXml  // 0x0
  public    static  System.Xml.XPath.XPathNamespaceScopeLocal  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XPath.XPathNavigator
TYPE:  class
TOKEN: 0x20000FB
EXTENDS: XPathItem
FIELDS:
  private   static readonly System.Xml.XPath.XPathNavigatorKeyComparercomparer  // 0x0
  private   static readonly System.Char[]                   NodeTypeLetter  // 0x8
  private   static readonly System.Char[]                   UniqueIdTbl  // 0x10
  private   static readonly System.Int32[]                  ContentKindMasks  // 0x18
METHODS:
  System.String ToString()
  System.Xml.Schema.XmlSchemaType get_XmlType()
  System.Object get_TypedValue()
  System.Type get_ValueType()
  System.Boolean get_ValueAsBoolean()
  System.DateTime get_ValueAsDateTime()
  System.Double get_ValueAsDouble()
  System.Int32 get_ValueAsInt()
  System.Int64 get_ValueAsLong()
  System.Object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver)
  System.Object System.ICloneable.Clone()
  System.Xml.XPath.XPathNavigator CreateNavigator()
  System.Xml.XmlNameTable get_NameTable()
  System.String LookupNamespace(System.String prefix)
  System.String LookupPrefix(System.String namespaceURI)
  System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope)
  System.Xml.XPath.XPathNavigator Clone()
  System.Xml.XPath.XPathNodeType get_NodeType()
  System.String get_LocalName()
  System.String get_Name()
  System.String get_NamespaceURI()
  System.String get_Prefix()
  System.String get_BaseURI()
  System.String get_XmlLang()
  System.Object get_UnderlyingObject()
  System.Boolean MoveToAttribute(System.String localName, System.String namespaceURI)
  System.Boolean MoveToFirstAttribute()
  System.Boolean MoveToNextAttribute()
  System.Boolean MoveToNamespace(System.String name)
  System.Boolean MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope)
  System.Boolean MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope)
  System.Boolean MoveToFirstNamespace()
  System.Boolean MoveToNextNamespace()
  System.Boolean MoveToNext()
  System.Boolean MoveToFirstChild()
  System.Boolean MoveToParent()
  System.Void MoveToRoot()
  System.Boolean MoveTo(System.Xml.XPath.XPathNavigator other)
  System.Boolean MoveToId(System.String id)
  System.Boolean MoveToChild(System.String localName, System.String namespaceURI)
  System.Boolean MoveToChild(System.Xml.XPath.XPathNodeType type)
  System.Boolean MoveToFollowing(System.String localName, System.String namespaceURI, System.Xml.XPath.XPathNavigator end)
  System.Boolean MoveToFollowing(System.Xml.XPath.XPathNodeType type, System.Xml.XPath.XPathNavigator end)
  System.Boolean MoveToNext(System.String localName, System.String namespaceURI)
  System.Boolean MoveToNext(System.Xml.XPath.XPathNodeType type)
  System.Boolean IsSamePosition(System.Xml.XPath.XPathNavigator other)
  System.Boolean IsDescendant(System.Xml.XPath.XPathNavigator nav)
  System.Xml.XmlNodeOrder ComparePosition(System.Xml.XPath.XPathNavigator nav)
  System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo()
  System.Xml.XPath.XPathNodeIterator Select(System.String xpath)
  System.Xml.XPath.XPathNodeIterator Select(System.Xml.XPath.XPathExpression expr)
  System.Object Evaluate(System.Xml.XPath.XPathExpression expr)
  System.Object Evaluate(System.Xml.XPath.XPathExpression expr, System.Xml.XPath.XPathNodeIterator context)
  System.Xml.XPath.XPathNodeIterator SelectChildren(System.Xml.XPath.XPathNodeType type)
  System.Xml.XPath.XPathNodeIterator SelectChildren(System.String name, System.String namespaceURI)
  System.Xml.XPath.XPathNodeIterator SelectDescendants(System.Xml.XPath.XPathNodeType type, System.Boolean matchSelf)
  System.Xml.XPath.XPathNodeIterator SelectDescendants(System.String name, System.String namespaceURI, System.Boolean matchSelf)
  System.Boolean MoveToNonDescendant()
  System.Int32 GetDepth(System.Xml.XPath.XPathNavigator nav)
  System.Xml.XmlNodeOrder CompareSiblings(System.Xml.XPath.XPathNavigator n1, System.Xml.XPath.XPathNavigator n2)
  System.Int32 GetContentKindMask(System.Xml.XPath.XPathNodeType type)
  System.Int32 GetKindMask(System.Xml.XPath.XPathNodeType type)
  System.Boolean IsText(System.Xml.XPath.XPathNodeType type)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Xml.XPath.XPathNavigatorKeyComparer
TYPE:  class
TOKEN: 0x20000FC
FIELDS:
METHODS:
  System.Boolean System.Collections.IEqualityComparer.Equals(System.Object obj1, System.Object obj2)
  System.Int32 System.Collections.IEqualityComparer.GetHashCode(System.Object obj)
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.XPath.XPathNodeIterator
TYPE:  class
TOKEN: 0x20000FD
FIELDS:
  private           System.Int32                    count  // 0x10
METHODS:
  System.Object System.ICloneable.Clone()
  System.Xml.XPath.XPathNodeIterator Clone()
  System.Boolean MoveNext()
  System.Xml.XPath.XPathNavigator get_Current()
  System.Int32 get_CurrentPosition()
  System.Int32 get_Count()
  System.Collections.IEnumerator GetEnumerator()
  System.Void .ctor()
END_CLASS

CLASS: System.Xml.XPath.XPathNodeType
TYPE:  struct
TOKEN: 0x20000FF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Xml.XPath.XPathNodeType  Root  // 0x0
  public    static  System.Xml.XPath.XPathNodeType  Element  // 0x0
  public    static  System.Xml.XPath.XPathNodeType  Attribute  // 0x0
  public    static  System.Xml.XPath.XPathNodeType  Namespace  // 0x0
  public    static  System.Xml.XPath.XPathNodeType  Text  // 0x0
  public    static  System.Xml.XPath.XPathNodeType  SignificantWhitespace  // 0x0
  public    static  System.Xml.XPath.XPathNodeType  Whitespace  // 0x0
  public    static  System.Xml.XPath.XPathNodeType  ProcessingInstruction  // 0x0
  public    static  System.Xml.XPath.XPathNodeType  Comment  // 0x0
  public    static  System.Xml.XPath.XPathNodeType  All  // 0x0
METHODS:
END_CLASS

CLASS: System.Xml.XmlConfiguration.XmlReaderSection
TYPE:  class
TOKEN: 0x2000158
FIELDS:
METHODS:
  System.Boolean get_ProhibitDefaultUrlResolver()
  System.Xml.XmlResolver CreateDefaultResolver()
  System.Boolean get_CollapseWhiteSpaceIntoEmptyString()
END_CLASS

CLASS: System.Xml.Xsl.IXsltContextFunction
TYPE:  interface
TOKEN: 0x2000159
FIELDS:
METHODS:
  System.Xml.XPath.XPathResultType get_ReturnType()
  System.Object Invoke(System.Xml.Xsl.XsltContext xsltContext, System.Object[] args, System.Xml.XPath.XPathNavigator docContext)
END_CLASS

CLASS: System.Xml.Xsl.IXsltContextVariable
TYPE:  interface
TOKEN: 0x200015A
FIELDS:
METHODS:
  System.Xml.XPath.XPathResultType get_VariableType()
  System.Object Evaluate(System.Xml.Xsl.XsltContext xsltContext)
END_CLASS

CLASS: System.Xml.Xsl.XsltContext
TYPE:  class
TOKEN: 0x200015B
EXTENDS: XmlNamespaceManager
FIELDS:
METHODS:
  System.Void .ctor(System.Boolean dummy)
  System.Xml.Xsl.IXsltContextVariable ResolveVariable(System.String prefix, System.String name)
  System.Xml.Xsl.IXsltContextFunction ResolveFunction(System.String prefix, System.String name, System.Xml.XPath.XPathResultType[] ArgTypes)
  System.Boolean get_Whitespace()
  System.Boolean PreserveWhitespace(System.Xml.XPath.XPathNavigator node)
END_CLASS

CLASS: System.Xml.Xsl.Runtime.StringConcat
TYPE:  struct
TOKEN: 0x200015C
FIELDS:
  private           System.String                   s1  // 0x10
  private           System.String                   s2  // 0x18
  private           System.String                   s3  // 0x20
  private           System.String                   s4  // 0x28
  private           System.String                   delimiter  // 0x30
  private           System.Collections.Generic.List<System.String>strList  // 0x38
  private           System.Int32                    idxStr  // 0x40
METHODS:
  System.Void Clear()
  System.Int32 get_Count()
  System.String GetResult()
  System.Void ConcatNoDelimiter(System.String s)
END_CLASS

