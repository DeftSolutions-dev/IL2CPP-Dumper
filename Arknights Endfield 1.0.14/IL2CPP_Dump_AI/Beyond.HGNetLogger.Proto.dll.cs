// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.HGNetLogger.Proto.dll
// Classes:  31
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Beyond.Network.HGNetLogger.MessageReflection
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static  Google.Protobuf.Reflection.FileDescriptordescriptor  // 0x0
METHODS:
  Google.Protobuf.Reflection.FileDescriptor get_Descriptor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.MessageType
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.HGNetLogger.MessageTypeAuthRequest  // 0x0
  public    static  Beyond.Network.HGNetLogger.MessageTypeAuthResponse  // 0x0
  public    static  Beyond.Network.HGNetLogger.MessageTypeLogMessage  // 0x0
  public    static  Beyond.Network.HGNetLogger.MessageTypeLogMessageResponse  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.HGNetLogger.UploadPriority
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.HGNetLogger.UploadPriorityLow  // 0x0
  public    static  Beyond.Network.HGNetLogger.UploadPriorityNormal  // 0x0
  public    static  Beyond.Network.HGNetLogger.UploadPriorityHigh  // 0x0
  public    static  Beyond.Network.HGNetLogger.UploadPriorityCritical  // 0x0
  public    static  Beyond.Network.HGNetLogger.UploadPriorityEmergency  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.HGNetLogger.Version
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.HGNetLogger.VersionV0  // 0x0
  public    static  Beyond.Network.HGNetLogger.VersionV1  // 0x0
  public    static  Beyond.Network.HGNetLogger.VersionV2  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.HGNetLogger.EncryptType
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.HGNetLogger.EncryptTypeNone  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.HGNetLogger.LogLevel
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.HGNetLogger.LogLevelDebug  // 0x0
  public    static  Beyond.Network.HGNetLogger.LogLevelInfo  // 0x0
  public    static  Beyond.Network.HGNetLogger.LogLevelWarn  // 0x0
  public    static  Beyond.Network.HGNetLogger.LogLevelError  // 0x0
  public    static  Beyond.Network.HGNetLogger.LogLevelFatal  // 0x0
  public    static  Beyond.Network.HGNetLogger.LogLevelImportant  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.HGNetLogger.NativeLogLevel
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.HGNetLogger.NativeLogLevelNone  // 0x0
  public    static  Beyond.Network.HGNetLogger.NativeLogLevelDebug  // 0x0
  public    static  Beyond.Network.HGNetLogger.NativeLogLevelInfo  // 0x0
  public    static  Beyond.Network.HGNetLogger.NativeLogLevelWarn  // 0x0
  public    static  Beyond.Network.HGNetLogger.NativeLogLevelError  // 0x0
  public    static  Beyond.Network.HGNetLogger.NativeLogLevelFatal  // 0x0
  public    static  Beyond.Network.HGNetLogger.NativeLogLevelImportant  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.HGNetLogger.ResponseStatus
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.HGNetLogger.ResponseStatusOk  // 0x0
  public    static  Beyond.Network.HGNetLogger.ResponseStatusPackageCheckFailed  // 0x0
  public    static  Beyond.Network.HGNetLogger.ResponseStatusTooManyTemplate  // 0x0
  public    static  Beyond.Network.HGNetLogger.ResponseStatusTemplateParamCountNotMatch  // 0x0
  public    static  Beyond.Network.HGNetLogger.ResponseStatusAuthFailed  // 0x0
  public    static  Beyond.Network.HGNetLogger.ResponseStatusTemplateNotFound  // 0x0
  public    static  Beyond.Network.HGNetLogger.ResponseStatusInvalidAppId  // 0x0
  public    static  Beyond.Network.HGNetLogger.ResponseStatusInvalidToken  // 0x0
  public    static  Beyond.Network.HGNetLogger.ResponseStatusInvalidProtocolVersion  // 0x0
  public    static  Beyond.Network.HGNetLogger.ResponseStatusUnsupportedMessageType  // 0x0
  public    static  Beyond.Network.HGNetLogger.ResponseStatusUnexpectedSeqId  // 0x0
  public    static  Beyond.Network.HGNetLogger.ResponseStatusChecksumFailed  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.HGNetLogger.Header
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.Header>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    VersionFieldNumber  // 0x0
  private           Beyond.Network.HGNetLogger.Versionversion_  // 0x18
  public    static  System.Int32                    MessageTypeFieldNumber  // 0x0
  private           Beyond.Network.HGNetLogger.MessageTypemessageType_  // 0x1C
  public    static  System.Int32                    SeqIdFieldNumber  // 0x0
  private           System.UInt32                   seqId_  // 0x20
METHODS:
  Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.Header> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Beyond.Network.HGNetLogger.Header other)
  Beyond.Network.HGNetLogger.Header Clone()
  Beyond.Network.HGNetLogger.Version get_Version()
  System.Void set_Version(Beyond.Network.HGNetLogger.Version value)
  Beyond.Network.HGNetLogger.MessageType get_MessageType()
  System.Void set_MessageType(Beyond.Network.HGNetLogger.MessageType value)
  System.UInt32 get_SeqId()
  System.Void set_SeqId(System.UInt32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Beyond.Network.HGNetLogger.Header other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Beyond.Network.HGNetLogger.Header other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.AuthRequest
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.AuthRequest>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    TokenFieldNumber  // 0x0
  private           System.String                   token_  // 0x18
  public    static  System.Int32                    UidFieldNumber  // 0x0
  private           System.String                   uid_  // 0x20
  public    static  System.Int32                    DidFieldNumber  // 0x0
  private           System.String                   did_  // 0x28
  public    static  System.Int32                    AppIdFieldNumber  // 0x0
  private           System.String                   appId_  // 0x30
  public    static  System.Int32                    OsFieldNumber  // 0x0
  private           System.String                   os_  // 0x38
  public    static  System.Int32                    OsVersionFieldNumber  // 0x0
  private           System.String                   osVersion_  // 0x40
  public    static  System.Int32                    AppVersionFieldNumber  // 0x0
  private           System.String                   appVersion_  // 0x48
  public    static  System.Int32                    LogSdkVersionFieldNumber  // 0x0
  private           System.String                   logSdkVersion_  // 0x50
  public    static  System.Int32                    DeviceModelFieldNumber  // 0x0
  private           System.String                   deviceModel_  // 0x58
  public    static  System.Int32                    NetworkTypeFieldNumber  // 0x0
  private           System.String                   networkType_  // 0x60
  public    static  System.Int32                    DeviceNameFieldNumber  // 0x0
  private           System.String                   deviceName_  // 0x68
  public    static  System.Int32                    ServerNameFieldNumber  // 0x0
  private           System.String                   serverName_  // 0x70
  public    static  System.Int32                    ServerChannelFieldNumber  // 0x0
  private           System.String                   serverChannel_  // 0x78
  public    static  System.Int32                    GameLaunchTimeFieldNumber  // 0x0
  private           System.Int64                    gameLaunchTime_  // 0x80
  public    static  System.Int32                    AccountAliasFieldNumber  // 0x0
  private           System.String                   accountAlias_  // 0x88
  public    static  System.Int32                    DevVersionFieldNumber  // 0x0
  private           System.String                   devVersion_  // 0x90
  public    static  System.Int32                    UploadPriorityFieldNumber  // 0x0
  private           Beyond.Network.HGNetLogger.UploadPriorityuploadPriority_  // 0x98
  public    static  System.Int32                    CharacterIdFieldNumber  // 0x0
  private           System.String                   characterId_  // 0xA0
  public    static  System.Int32                    RoleIdFieldNumber  // 0x0
  private           System.Int64                    roleId_  // 0xA8
  public    static  System.Int32                    ExtraFieldNumber  // 0x0
  private   static readonly Google.Protobuf.Collections.MapField.Codec<System.String,System.String>_map_extra_codec  // 0x8
  private   readonly Google.Protobuf.Collections.MapField<System.String,System.String>extra_  // 0xB0
METHODS:
  Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.AuthRequest> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Beyond.Network.HGNetLogger.AuthRequest other)
  Beyond.Network.HGNetLogger.AuthRequest Clone()
  System.String get_Token()
  System.Void set_Token(System.String value)
  System.String get_Uid()
  System.Void set_Uid(System.String value)
  System.String get_Did()
  System.Void set_Did(System.String value)
  System.String get_AppId()
  System.Void set_AppId(System.String value)
  System.String get_Os()
  System.Void set_Os(System.String value)
  System.String get_OsVersion()
  System.Void set_OsVersion(System.String value)
  System.String get_AppVersion()
  System.Void set_AppVersion(System.String value)
  System.String get_LogSdkVersion()
  System.Void set_LogSdkVersion(System.String value)
  System.String get_DeviceModel()
  System.Void set_DeviceModel(System.String value)
  System.String get_NetworkType()
  System.Void set_NetworkType(System.String value)
  System.String get_DeviceName()
  System.Void set_DeviceName(System.String value)
  System.String get_ServerName()
  System.Void set_ServerName(System.String value)
  System.String get_ServerChannel()
  System.Void set_ServerChannel(System.String value)
  System.Int64 get_GameLaunchTime()
  System.Void set_GameLaunchTime(System.Int64 value)
  System.String get_AccountAlias()
  System.Void set_AccountAlias(System.String value)
  System.String get_DevVersion()
  System.Void set_DevVersion(System.String value)
  Beyond.Network.HGNetLogger.UploadPriority get_UploadPriority()
  System.Void set_UploadPriority(Beyond.Network.HGNetLogger.UploadPriority value)
  System.String get_CharacterId()
  System.Void set_CharacterId(System.String value)
  System.Int64 get_RoleId()
  System.Void set_RoleId(System.Int64 value)
  Google.Protobuf.Collections.MapField<System.String,System.String> get_Extra()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Beyond.Network.HGNetLogger.AuthRequest other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Beyond.Network.HGNetLogger.AuthRequest other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.LogControl
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogControl>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    GlobalEnabledFieldNumber  // 0x0
  private           System.Boolean                  globalEnabled_  // 0x18
  public    static  System.Int32                    DefaultLogLevelMaskFieldNumber  // 0x0
  private           System.Int32                    defaultLogLevelMask_  // 0x1C
  public    static  System.Int32                    ModuleControlFieldNumber  // 0x0
  private   static readonly Google.Protobuf.Collections.MapField.Codec<System.Int32,System.Int32>_map_moduleControl_codec  // 0x8
  private   readonly Google.Protobuf.Collections.MapField<System.Int32,System.Int32>moduleControl_  // 0x20
  public    static  System.Int32                    PolicyIdFieldNumber  // 0x0
  private           System.String                   policyId_  // 0x28
METHODS:
  Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogControl> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Beyond.Network.HGNetLogger.LogControl other)
  Beyond.Network.HGNetLogger.LogControl Clone()
  System.Boolean get_GlobalEnabled()
  System.Void set_GlobalEnabled(System.Boolean value)
  System.Int32 get_DefaultLogLevelMask()
  System.Void set_DefaultLogLevelMask(System.Int32 value)
  Google.Protobuf.Collections.MapField<System.Int32,System.Int32> get_ModuleControl()
  System.String get_PolicyId()
  System.Void set_PolicyId(System.String value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Beyond.Network.HGNetLogger.LogControl other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Beyond.Network.HGNetLogger.LogControl other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.AuthResponse
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.AuthResponse>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    StatusFieldNumber  // 0x0
  private           Beyond.Network.HGNetLogger.ResponseStatusstatus_  // 0x18
  public    static  System.Int32                    MessageFieldNumber  // 0x0
  private           System.String                   message_  // 0x20
  public    static  System.Int32                    EncryptTypeFieldNumber  // 0x0
  private           Beyond.Network.HGNetLogger.EncryptTypeencryptType_  // 0x28
  public    static  System.Int32                    KeyFieldNumber  // 0x0
  private           System.String                   key_  // 0x30
  public    static  System.Int32                    CloudLogControlFieldNumber  // 0x0
  private           Beyond.Network.HGNetLogger.LogControlcloudLogControl_  // 0x38
  public    static  System.Int32                    LocalLogControlFieldNumber  // 0x0
  private           Beyond.Network.HGNetLogger.LogControllocalLogControl_  // 0x40
METHODS:
  Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.AuthResponse> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Beyond.Network.HGNetLogger.AuthResponse other)
  Beyond.Network.HGNetLogger.AuthResponse Clone()
  Beyond.Network.HGNetLogger.ResponseStatus get_Status()
  System.Void set_Status(Beyond.Network.HGNetLogger.ResponseStatus value)
  System.String get_Message()
  System.Void set_Message(System.String value)
  Beyond.Network.HGNetLogger.EncryptType get_EncryptType()
  System.Void set_EncryptType(Beyond.Network.HGNetLogger.EncryptType value)
  System.String get_Key()
  System.Void set_Key(System.String value)
  Beyond.Network.HGNetLogger.LogControl get_CloudLogControl()
  System.Void set_CloudLogControl(Beyond.Network.HGNetLogger.LogControl value)
  Beyond.Network.HGNetLogger.LogControl get_LocalLogControl()
  System.Void set_LocalLogControl(Beyond.Network.HGNetLogger.LogControl value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Beyond.Network.HGNetLogger.AuthResponse other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Beyond.Network.HGNetLogger.AuthResponse other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.LogIntParam
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogIntParam>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValFieldNumber  // 0x0
  private           System.Int64                    val_  // 0x18
  public    static  System.Int32                    IndexFieldNumber  // 0x0
  private           System.Int32                    index_  // 0x20
METHODS:
  Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogIntParam> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Beyond.Network.HGNetLogger.LogIntParam other)
  Beyond.Network.HGNetLogger.LogIntParam Clone()
  System.Int64 get_Val()
  System.Void set_Val(System.Int64 value)
  System.Int32 get_Index()
  System.Void set_Index(System.Int32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Beyond.Network.HGNetLogger.LogIntParam other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Beyond.Network.HGNetLogger.LogIntParam other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.LogFloatParam
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogFloatParam>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValFieldNumber  // 0x0
  private           System.Single                   val_  // 0x18
  public    static  System.Int32                    IndexFieldNumber  // 0x0
  private           System.Int32                    index_  // 0x1C
METHODS:
  Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogFloatParam> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Beyond.Network.HGNetLogger.LogFloatParam other)
  Beyond.Network.HGNetLogger.LogFloatParam Clone()
  System.Single get_Val()
  System.Void set_Val(System.Single value)
  System.Int32 get_Index()
  System.Void set_Index(System.Int32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Beyond.Network.HGNetLogger.LogFloatParam other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Beyond.Network.HGNetLogger.LogFloatParam other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.LogDoubleParam
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogDoubleParam>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValFieldNumber  // 0x0
  private           System.Double                   val_  // 0x18
  public    static  System.Int32                    IndexFieldNumber  // 0x0
  private           System.Int32                    index_  // 0x20
METHODS:
  Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogDoubleParam> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Beyond.Network.HGNetLogger.LogDoubleParam other)
  Beyond.Network.HGNetLogger.LogDoubleParam Clone()
  System.Double get_Val()
  System.Void set_Val(System.Double value)
  System.Int32 get_Index()
  System.Void set_Index(System.Int32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Beyond.Network.HGNetLogger.LogDoubleParam other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Beyond.Network.HGNetLogger.LogDoubleParam other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.LogBoolParam
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogBoolParam>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValFieldNumber  // 0x0
  private           System.String                   val_  // 0x18
  public    static  System.Int32                    IndexFieldNumber  // 0x0
  private           System.Int32                    index_  // 0x20
METHODS:
  Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogBoolParam> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Beyond.Network.HGNetLogger.LogBoolParam other)
  Beyond.Network.HGNetLogger.LogBoolParam Clone()
  System.String get_Val()
  System.Void set_Val(System.String value)
  System.Int32 get_Index()
  System.Void set_Index(System.Int32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Beyond.Network.HGNetLogger.LogBoolParam other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Beyond.Network.HGNetLogger.LogBoolParam other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.LogStringParam
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogStringParam>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    ValFieldNumber  // 0x0
  private           System.String                   val_  // 0x18
  public    static  System.Int32                    IndexFieldNumber  // 0x0
  private           System.Int32                    index_  // 0x20
METHODS:
  Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogStringParam> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Beyond.Network.HGNetLogger.LogStringParam other)
  Beyond.Network.HGNetLogger.LogStringParam Clone()
  System.String get_Val()
  System.Void set_Val(System.String value)
  System.Int32 get_Index()
  System.Void set_Index(System.Int32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Beyond.Network.HGNetLogger.LogStringParam other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Beyond.Network.HGNetLogger.LogStringParam other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.LogMessage
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogMessage>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    LogTemplateFieldNumber  // 0x0
  private           System.String                   logTemplate_  // 0x18
  public    static  System.Int32                    TemplateHashFieldNumber  // 0x0
  private           System.UInt32                   templateHash_  // 0x20
  public    static  System.Int32                    LogLevelFieldNumber  // 0x0
  private           Beyond.Network.HGNetLogger.LogLevellogLevel_  // 0x24
  public    static  System.Int32                    ChannelFieldNumber  // 0x0
  private           System.Int32                    channel_  // 0x28
  public    static  System.Int32                    TimeFieldNumber  // 0x0
  private           System.Int64                    time_  // 0x30
  public    static  System.Int32                    FrameCountFieldNumber  // 0x0
  private           System.UInt32                   frameCount_  // 0x38
  public    static  System.Int32                    PlayerPosXFieldNumber  // 0x0
  private           System.Single                   playerPosX_  // 0x3C
  public    static  System.Int32                    PlayerPosYFieldNumber  // 0x0
  private           System.Single                   playerPosY_  // 0x40
  public    static  System.Int32                    PlayerPosZFieldNumber  // 0x0
  private           System.Single                   playerPosZ_  // 0x44
  public    static  System.Int32                    PlayerPingFieldNumber  // 0x0
  private           System.Int32                    playerPing_  // 0x48
  public    static  System.Int32                    ParamsIntListFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Beyond.Network.HGNetLogger.LogIntParam>_repeated_paramsIntList_codec  // 0x8
  private   readonly Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogIntParam>paramsIntList_  // 0x50
  public    static  System.Int32                    ParamsFloatListFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Beyond.Network.HGNetLogger.LogFloatParam>_repeated_paramsFloatList_codec  // 0x10
  private   readonly Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogFloatParam>paramsFloatList_  // 0x58
  public    static  System.Int32                    ParamsDoubleListFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Beyond.Network.HGNetLogger.LogDoubleParam>_repeated_paramsDoubleList_codec  // 0x18
  private   readonly Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogDoubleParam>paramsDoubleList_  // 0x60
  public    static  System.Int32                    ParamsBoolListFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Beyond.Network.HGNetLogger.LogBoolParam>_repeated_paramsBoolList_codec  // 0x20
  private   readonly Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogBoolParam>paramsBoolList_  // 0x68
  public    static  System.Int32                    ParamsStringListFieldNumber  // 0x0
  private   static readonly Google.Protobuf.FieldCodec<Beyond.Network.HGNetLogger.LogStringParam>_repeated_paramsStringList_codec  // 0x28
  private   readonly Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogStringParam>paramsStringList_  // 0x70
  public    static  System.Int32                    NativeLogLevelFieldNumber  // 0x0
  private           Beyond.Network.HGNetLogger.NativeLogLevelnativeLogLevel_  // 0x78
  public    static  System.Int32                    ReturnLoginCountFieldNumber  // 0x0
  private           System.Int32                    returnLoginCount_  // 0x7C
  public    static  System.Int32                    AppPauseCountFieldNumber  // 0x0
  private           System.Int32                    appPauseCount_  // 0x80
METHODS:
  Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogMessage> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Beyond.Network.HGNetLogger.LogMessage other)
  Beyond.Network.HGNetLogger.LogMessage Clone()
  System.String get_LogTemplate()
  System.Void set_LogTemplate(System.String value)
  System.UInt32 get_TemplateHash()
  System.Void set_TemplateHash(System.UInt32 value)
  Beyond.Network.HGNetLogger.LogLevel get_LogLevel()
  System.Void set_LogLevel(Beyond.Network.HGNetLogger.LogLevel value)
  System.Int32 get_Channel()
  System.Void set_Channel(System.Int32 value)
  System.Int64 get_Time()
  System.Void set_Time(System.Int64 value)
  System.UInt32 get_FrameCount()
  System.Void set_FrameCount(System.UInt32 value)
  System.Single get_PlayerPosX()
  System.Void set_PlayerPosX(System.Single value)
  System.Single get_PlayerPosY()
  System.Void set_PlayerPosY(System.Single value)
  System.Single get_PlayerPosZ()
  System.Void set_PlayerPosZ(System.Single value)
  System.Int32 get_PlayerPing()
  System.Void set_PlayerPing(System.Int32 value)
  Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogIntParam> get_ParamsIntList()
  Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogFloatParam> get_ParamsFloatList()
  Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogDoubleParam> get_ParamsDoubleList()
  Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogBoolParam> get_ParamsBoolList()
  Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogStringParam> get_ParamsStringList()
  Beyond.Network.HGNetLogger.NativeLogLevel get_NativeLogLevel()
  System.Void set_NativeLogLevel(Beyond.Network.HGNetLogger.NativeLogLevel value)
  System.Int32 get_ReturnLoginCount()
  System.Void set_ReturnLoginCount(System.Int32 value)
  System.Int32 get_AppPauseCount()
  System.Void set_AppPauseCount(System.Int32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Beyond.Network.HGNetLogger.LogMessage other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Beyond.Network.HGNetLogger.LogMessage other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.LogMessageResponse
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  private   static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogMessageResponse>_parser  // 0x0
  private           Google.Protobuf.UnknownFieldSet _unknownFields  // 0x10
  public    static  System.Int32                    StatusFieldNumber  // 0x0
  private           Beyond.Network.HGNetLogger.ResponseStatusstatus_  // 0x18
  public    static  System.Int32                    MessageFieldNumber  // 0x0
  private           System.String                   message_  // 0x20
  public    static  System.Int32                    TemplateHashFieldNumber  // 0x0
  private           System.UInt32                   templateHash_  // 0x28
METHODS:
  Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogMessageResponse> get_Parser()
  Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
  Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
  System.Void .ctor()
  System.Void .ctor(Beyond.Network.HGNetLogger.LogMessageResponse other)
  Beyond.Network.HGNetLogger.LogMessageResponse Clone()
  Beyond.Network.HGNetLogger.ResponseStatus get_Status()
  System.Void set_Status(Beyond.Network.HGNetLogger.ResponseStatus value)
  System.String get_Message()
  System.Void set_Message(System.String value)
  System.UInt32 get_TemplateHash()
  System.Void set_TemplateHash(System.UInt32 value)
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(Beyond.Network.HGNetLogger.LogMessageResponse other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void WriteTo(Google.Protobuf.CodedOutputStream output)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output)
  System.Int32 CalculateSize()
  System.Void MergeFrom(Beyond.Network.HGNetLogger.LogMessageResponse other)
  System.Void MergeFrom(Google.Protobuf.CodedInputStream input)
  System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input)
  System.Void .cctor()
END_CLASS

