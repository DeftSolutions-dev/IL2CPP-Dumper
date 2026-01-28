// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.HGNetLogger.Proto.dll
// Classes:  31
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Beyond.Network.HGNetLogger
{

    // TypeToken: 0x2000002
    public class MessageReflection
    {
        // Fields
        private static Google.Protobuf.Reflection.FileDescriptor descriptor;        // 0x0

        // Methods
        private Google.Protobuf.Reflection.FileDescriptor get_Descriptor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000003
    public struct MessageType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Network.HGNetLogger.MessageType AuthRequest;        // 0x0
        public static Beyond.Network.HGNetLogger.MessageType AuthResponse;        // 0x0
        public static Beyond.Network.HGNetLogger.MessageType LogMessage;        // 0x0
        public static Beyond.Network.HGNetLogger.MessageType LogMessageResponse;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct UploadPriority
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Network.HGNetLogger.UploadPriority Low;        // 0x0
        public static Beyond.Network.HGNetLogger.UploadPriority Normal;        // 0x0
        public static Beyond.Network.HGNetLogger.UploadPriority High;        // 0x0
        public static Beyond.Network.HGNetLogger.UploadPriority Critical;        // 0x0
        public static Beyond.Network.HGNetLogger.UploadPriority Emergency;        // 0x0

    }

    // TypeToken: 0x2000005
    public struct Version
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Network.HGNetLogger.Version V0;        // 0x0
        public static Beyond.Network.HGNetLogger.Version V1;        // 0x0
        public static Beyond.Network.HGNetLogger.Version V2;        // 0x0

    }

    // TypeToken: 0x2000006
    public struct EncryptType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Network.HGNetLogger.EncryptType None;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct LogLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Network.HGNetLogger.LogLevel Debug;        // 0x0
        public static Beyond.Network.HGNetLogger.LogLevel Info;        // 0x0
        public static Beyond.Network.HGNetLogger.LogLevel Warn;        // 0x0
        public static Beyond.Network.HGNetLogger.LogLevel Error;        // 0x0
        public static Beyond.Network.HGNetLogger.LogLevel Fatal;        // 0x0
        public static Beyond.Network.HGNetLogger.LogLevel Important;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct NativeLogLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Network.HGNetLogger.NativeLogLevel None;        // 0x0
        public static Beyond.Network.HGNetLogger.NativeLogLevel Debug;        // 0x0
        public static Beyond.Network.HGNetLogger.NativeLogLevel Info;        // 0x0
        public static Beyond.Network.HGNetLogger.NativeLogLevel Warn;        // 0x0
        public static Beyond.Network.HGNetLogger.NativeLogLevel Error;        // 0x0
        public static Beyond.Network.HGNetLogger.NativeLogLevel Fatal;        // 0x0
        public static Beyond.Network.HGNetLogger.NativeLogLevel Important;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct ResponseStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Network.HGNetLogger.ResponseStatus Ok;        // 0x0
        public static Beyond.Network.HGNetLogger.ResponseStatus PackageCheckFailed;        // 0x0
        public static Beyond.Network.HGNetLogger.ResponseStatus TooManyTemplate;        // 0x0
        public static Beyond.Network.HGNetLogger.ResponseStatus TemplateParamCountNotMatch;        // 0x0
        public static Beyond.Network.HGNetLogger.ResponseStatus AuthFailed;        // 0x0
        public static Beyond.Network.HGNetLogger.ResponseStatus TemplateNotFound;        // 0x0
        public static Beyond.Network.HGNetLogger.ResponseStatus InvalidAppId;        // 0x0
        public static Beyond.Network.HGNetLogger.ResponseStatus InvalidToken;        // 0x0
        public static Beyond.Network.HGNetLogger.ResponseStatus InvalidProtocolVersion;        // 0x0
        public static Beyond.Network.HGNetLogger.ResponseStatus UnsupportedMessageType;        // 0x0
        public static Beyond.Network.HGNetLogger.ResponseStatus UnexpectedSeqId;        // 0x0
        public static Beyond.Network.HGNetLogger.ResponseStatus ChecksumFailed;        // 0x0

    }

    // TypeToken: 0x200000A
    public class Header, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.Header> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 VersionFieldNumber;        // 0x0
        private Beyond.Network.HGNetLogger.Version version_;        // 0x18
        public static System.Int32 MessageTypeFieldNumber;        // 0x0
        private Beyond.Network.HGNetLogger.MessageType messageType_;        // 0x1C
        public static System.Int32 SeqIdFieldNumber;        // 0x0
        private System.UInt32 seqId_;        // 0x20

        // Methods
        private Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.Header> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Network.HGNetLogger.Header other) { }
        private Beyond.Network.HGNetLogger.Header Clone() { }
        private Beyond.Network.HGNetLogger.Version get_Version() { }
        private System.Void set_Version(Beyond.Network.HGNetLogger.Version value) { }
        private Beyond.Network.HGNetLogger.MessageType get_MessageType() { }
        private System.Void set_MessageType(Beyond.Network.HGNetLogger.MessageType value) { }
        private System.UInt32 get_SeqId() { }
        private System.Void set_SeqId(System.UInt32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Beyond.Network.HGNetLogger.Header other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Beyond.Network.HGNetLogger.Header other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000C
    public class AuthRequest, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.AuthRequest> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 TokenFieldNumber;        // 0x0
        private System.String token_;        // 0x18
        public static System.Int32 UidFieldNumber;        // 0x0
        private System.String uid_;        // 0x20
        public static System.Int32 DidFieldNumber;        // 0x0
        private System.String did_;        // 0x28
        public static System.Int32 AppIdFieldNumber;        // 0x0
        private System.String appId_;        // 0x30
        public static System.Int32 OsFieldNumber;        // 0x0
        private System.String os_;        // 0x38
        public static System.Int32 OsVersionFieldNumber;        // 0x0
        private System.String osVersion_;        // 0x40
        public static System.Int32 AppVersionFieldNumber;        // 0x0
        private System.String appVersion_;        // 0x48
        public static System.Int32 LogSdkVersionFieldNumber;        // 0x0
        private System.String logSdkVersion_;        // 0x50
        public static System.Int32 DeviceModelFieldNumber;        // 0x0
        private System.String deviceModel_;        // 0x58
        public static System.Int32 NetworkTypeFieldNumber;        // 0x0
        private System.String networkType_;        // 0x60
        public static System.Int32 DeviceNameFieldNumber;        // 0x0
        private System.String deviceName_;        // 0x68
        public static System.Int32 ServerNameFieldNumber;        // 0x0
        private System.String serverName_;        // 0x70
        public static System.Int32 ServerChannelFieldNumber;        // 0x0
        private System.String serverChannel_;        // 0x78
        public static System.Int32 GameLaunchTimeFieldNumber;        // 0x0
        private System.Int64 gameLaunchTime_;        // 0x80
        public static System.Int32 AccountAliasFieldNumber;        // 0x0
        private System.String accountAlias_;        // 0x88
        public static System.Int32 DevVersionFieldNumber;        // 0x0
        private System.String devVersion_;        // 0x90
        public static System.Int32 UploadPriorityFieldNumber;        // 0x0
        private Beyond.Network.HGNetLogger.UploadPriority uploadPriority_;        // 0x98
        public static System.Int32 CharacterIdFieldNumber;        // 0x0
        private System.String characterId_;        // 0xA0
        public static System.Int32 RoleIdFieldNumber;        // 0x0
        private System.Int64 roleId_;        // 0xA8
        public static System.Int32 ExtraFieldNumber;        // 0x0
        private static readonly Google.Protobuf.Collections.MapField.Codec<System.String,System.String> _map_extra_codec;        // 0x8
        private readonly Google.Protobuf.Collections.MapField<System.String,System.String> extra_;        // 0xB0

        // Methods
        private Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.AuthRequest> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Network.HGNetLogger.AuthRequest other) { }
        private Beyond.Network.HGNetLogger.AuthRequest Clone() { }
        private System.String get_Token() { }
        private System.Void set_Token(System.String value) { }
        private System.String get_Uid() { }
        private System.Void set_Uid(System.String value) { }
        private System.String get_Did() { }
        private System.Void set_Did(System.String value) { }
        private System.String get_AppId() { }
        private System.Void set_AppId(System.String value) { }
        private System.String get_Os() { }
        private System.Void set_Os(System.String value) { }
        private System.String get_OsVersion() { }
        private System.Void set_OsVersion(System.String value) { }
        private System.String get_AppVersion() { }
        private System.Void set_AppVersion(System.String value) { }
        private System.String get_LogSdkVersion() { }
        private System.Void set_LogSdkVersion(System.String value) { }
        private System.String get_DeviceModel() { }
        private System.Void set_DeviceModel(System.String value) { }
        private System.String get_NetworkType() { }
        private System.Void set_NetworkType(System.String value) { }
        private System.String get_DeviceName() { }
        private System.Void set_DeviceName(System.String value) { }
        private System.String get_ServerName() { }
        private System.Void set_ServerName(System.String value) { }
        private System.String get_ServerChannel() { }
        private System.Void set_ServerChannel(System.String value) { }
        private System.Int64 get_GameLaunchTime() { }
        private System.Void set_GameLaunchTime(System.Int64 value) { }
        private System.String get_AccountAlias() { }
        private System.Void set_AccountAlias(System.String value) { }
        private System.String get_DevVersion() { }
        private System.Void set_DevVersion(System.String value) { }
        private Beyond.Network.HGNetLogger.UploadPriority get_UploadPriority() { }
        private System.Void set_UploadPriority(Beyond.Network.HGNetLogger.UploadPriority value) { }
        private System.String get_CharacterId() { }
        private System.Void set_CharacterId(System.String value) { }
        private System.Int64 get_RoleId() { }
        private System.Void set_RoleId(System.Int64 value) { }
        private Google.Protobuf.Collections.MapField<System.String,System.String> get_Extra() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Beyond.Network.HGNetLogger.AuthRequest other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Beyond.Network.HGNetLogger.AuthRequest other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000E
    public class LogControl, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogControl> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 GlobalEnabledFieldNumber;        // 0x0
        private System.Boolean globalEnabled_;        // 0x18
        public static System.Int32 DefaultLogLevelMaskFieldNumber;        // 0x0
        private System.Int32 defaultLogLevelMask_;        // 0x1C
        public static System.Int32 ModuleControlFieldNumber;        // 0x0
        private static readonly Google.Protobuf.Collections.MapField.Codec<System.Int32,System.Int32> _map_moduleControl_codec;        // 0x8
        private readonly Google.Protobuf.Collections.MapField<System.Int32,System.Int32> moduleControl_;        // 0x20
        public static System.Int32 PolicyIdFieldNumber;        // 0x0
        private System.String policyId_;        // 0x28

        // Methods
        private Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogControl> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Network.HGNetLogger.LogControl other) { }
        private Beyond.Network.HGNetLogger.LogControl Clone() { }
        private System.Boolean get_GlobalEnabled() { }
        private System.Void set_GlobalEnabled(System.Boolean value) { }
        private System.Int32 get_DefaultLogLevelMask() { }
        private System.Void set_DefaultLogLevelMask(System.Int32 value) { }
        private Google.Protobuf.Collections.MapField<System.Int32,System.Int32> get_ModuleControl() { }
        private System.String get_PolicyId() { }
        private System.Void set_PolicyId(System.String value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Beyond.Network.HGNetLogger.LogControl other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Beyond.Network.HGNetLogger.LogControl other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000010
    public class AuthResponse, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.AuthResponse> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 StatusFieldNumber;        // 0x0
        private Beyond.Network.HGNetLogger.ResponseStatus status_;        // 0x18
        public static System.Int32 MessageFieldNumber;        // 0x0
        private System.String message_;        // 0x20
        public static System.Int32 EncryptTypeFieldNumber;        // 0x0
        private Beyond.Network.HGNetLogger.EncryptType encryptType_;        // 0x28
        public static System.Int32 KeyFieldNumber;        // 0x0
        private System.String key_;        // 0x30
        public static System.Int32 CloudLogControlFieldNumber;        // 0x0
        private Beyond.Network.HGNetLogger.LogControl cloudLogControl_;        // 0x38
        public static System.Int32 LocalLogControlFieldNumber;        // 0x0
        private Beyond.Network.HGNetLogger.LogControl localLogControl_;        // 0x40

        // Methods
        private Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.AuthResponse> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Network.HGNetLogger.AuthResponse other) { }
        private Beyond.Network.HGNetLogger.AuthResponse Clone() { }
        private Beyond.Network.HGNetLogger.ResponseStatus get_Status() { }
        private System.Void set_Status(Beyond.Network.HGNetLogger.ResponseStatus value) { }
        private System.String get_Message() { }
        private System.Void set_Message(System.String value) { }
        private Beyond.Network.HGNetLogger.EncryptType get_EncryptType() { }
        private System.Void set_EncryptType(Beyond.Network.HGNetLogger.EncryptType value) { }
        private System.String get_Key() { }
        private System.Void set_Key(System.String value) { }
        private Beyond.Network.HGNetLogger.LogControl get_CloudLogControl() { }
        private System.Void set_CloudLogControl(Beyond.Network.HGNetLogger.LogControl value) { }
        private Beyond.Network.HGNetLogger.LogControl get_LocalLogControl() { }
        private System.Void set_LocalLogControl(Beyond.Network.HGNetLogger.LogControl value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Beyond.Network.HGNetLogger.AuthResponse other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Beyond.Network.HGNetLogger.AuthResponse other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000012
    public class LogIntParam, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogIntParam> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValFieldNumber;        // 0x0
        private System.Int64 val_;        // 0x18
        public static System.Int32 IndexFieldNumber;        // 0x0
        private System.Int32 index_;        // 0x20

        // Methods
        private Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogIntParam> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Network.HGNetLogger.LogIntParam other) { }
        private Beyond.Network.HGNetLogger.LogIntParam Clone() { }
        private System.Int64 get_Val() { }
        private System.Void set_Val(System.Int64 value) { }
        private System.Int32 get_Index() { }
        private System.Void set_Index(System.Int32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Beyond.Network.HGNetLogger.LogIntParam other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Beyond.Network.HGNetLogger.LogIntParam other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000014
    public class LogFloatParam, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogFloatParam> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValFieldNumber;        // 0x0
        private System.Single val_;        // 0x18
        public static System.Int32 IndexFieldNumber;        // 0x0
        private System.Int32 index_;        // 0x1C

        // Methods
        private Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogFloatParam> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Network.HGNetLogger.LogFloatParam other) { }
        private Beyond.Network.HGNetLogger.LogFloatParam Clone() { }
        private System.Single get_Val() { }
        private System.Void set_Val(System.Single value) { }
        private System.Int32 get_Index() { }
        private System.Void set_Index(System.Int32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Beyond.Network.HGNetLogger.LogFloatParam other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Beyond.Network.HGNetLogger.LogFloatParam other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000016
    public class LogDoubleParam, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogDoubleParam> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValFieldNumber;        // 0x0
        private System.Double val_;        // 0x18
        public static System.Int32 IndexFieldNumber;        // 0x0
        private System.Int32 index_;        // 0x20

        // Methods
        private Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogDoubleParam> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Network.HGNetLogger.LogDoubleParam other) { }
        private Beyond.Network.HGNetLogger.LogDoubleParam Clone() { }
        private System.Double get_Val() { }
        private System.Void set_Val(System.Double value) { }
        private System.Int32 get_Index() { }
        private System.Void set_Index(System.Int32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Beyond.Network.HGNetLogger.LogDoubleParam other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Beyond.Network.HGNetLogger.LogDoubleParam other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000018
    public class LogBoolParam, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogBoolParam> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValFieldNumber;        // 0x0
        private System.String val_;        // 0x18
        public static System.Int32 IndexFieldNumber;        // 0x0
        private System.Int32 index_;        // 0x20

        // Methods
        private Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogBoolParam> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Network.HGNetLogger.LogBoolParam other) { }
        private Beyond.Network.HGNetLogger.LogBoolParam Clone() { }
        private System.String get_Val() { }
        private System.Void set_Val(System.String value) { }
        private System.Int32 get_Index() { }
        private System.Void set_Index(System.Int32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Beyond.Network.HGNetLogger.LogBoolParam other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Beyond.Network.HGNetLogger.LogBoolParam other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001A
    public class LogStringParam, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogStringParam> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 ValFieldNumber;        // 0x0
        private System.String val_;        // 0x18
        public static System.Int32 IndexFieldNumber;        // 0x0
        private System.Int32 index_;        // 0x20

        // Methods
        private Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogStringParam> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Network.HGNetLogger.LogStringParam other) { }
        private Beyond.Network.HGNetLogger.LogStringParam Clone() { }
        private System.String get_Val() { }
        private System.Void set_Val(System.String value) { }
        private System.Int32 get_Index() { }
        private System.Void set_Index(System.Int32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Beyond.Network.HGNetLogger.LogStringParam other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Beyond.Network.HGNetLogger.LogStringParam other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001C
    public class LogMessage, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogMessage> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 LogTemplateFieldNumber;        // 0x0
        private System.String logTemplate_;        // 0x18
        public static System.Int32 TemplateHashFieldNumber;        // 0x0
        private System.UInt32 templateHash_;        // 0x20
        public static System.Int32 LogLevelFieldNumber;        // 0x0
        private Beyond.Network.HGNetLogger.LogLevel logLevel_;        // 0x24
        public static System.Int32 ChannelFieldNumber;        // 0x0
        private System.Int32 channel_;        // 0x28
        public static System.Int32 TimeFieldNumber;        // 0x0
        private System.Int64 time_;        // 0x30
        public static System.Int32 FrameCountFieldNumber;        // 0x0
        private System.UInt32 frameCount_;        // 0x38
        public static System.Int32 PlayerPosXFieldNumber;        // 0x0
        private System.Single playerPosX_;        // 0x3C
        public static System.Int32 PlayerPosYFieldNumber;        // 0x0
        private System.Single playerPosY_;        // 0x40
        public static System.Int32 PlayerPosZFieldNumber;        // 0x0
        private System.Single playerPosZ_;        // 0x44
        public static System.Int32 PlayerPingFieldNumber;        // 0x0
        private System.Int32 playerPing_;        // 0x48
        public static System.Int32 ParamsIntListFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Beyond.Network.HGNetLogger.LogIntParam> _repeated_paramsIntList_codec;        // 0x8
        private readonly Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogIntParam> paramsIntList_;        // 0x50
        public static System.Int32 ParamsFloatListFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Beyond.Network.HGNetLogger.LogFloatParam> _repeated_paramsFloatList_codec;        // 0x10
        private readonly Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogFloatParam> paramsFloatList_;        // 0x58
        public static System.Int32 ParamsDoubleListFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Beyond.Network.HGNetLogger.LogDoubleParam> _repeated_paramsDoubleList_codec;        // 0x18
        private readonly Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogDoubleParam> paramsDoubleList_;        // 0x60
        public static System.Int32 ParamsBoolListFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Beyond.Network.HGNetLogger.LogBoolParam> _repeated_paramsBoolList_codec;        // 0x20
        private readonly Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogBoolParam> paramsBoolList_;        // 0x68
        public static System.Int32 ParamsStringListFieldNumber;        // 0x0
        private static readonly Google.Protobuf.FieldCodec<Beyond.Network.HGNetLogger.LogStringParam> _repeated_paramsStringList_codec;        // 0x28
        private readonly Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogStringParam> paramsStringList_;        // 0x70
        public static System.Int32 NativeLogLevelFieldNumber;        // 0x0
        private Beyond.Network.HGNetLogger.NativeLogLevel nativeLogLevel_;        // 0x78
        public static System.Int32 ReturnLoginCountFieldNumber;        // 0x0
        private System.Int32 returnLoginCount_;        // 0x7C
        public static System.Int32 AppPauseCountFieldNumber;        // 0x0
        private System.Int32 appPauseCount_;        // 0x80

        // Methods
        private Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogMessage> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Network.HGNetLogger.LogMessage other) { }
        private Beyond.Network.HGNetLogger.LogMessage Clone() { }
        private System.String get_LogTemplate() { }
        private System.Void set_LogTemplate(System.String value) { }
        private System.UInt32 get_TemplateHash() { }
        private System.Void set_TemplateHash(System.UInt32 value) { }
        private Beyond.Network.HGNetLogger.LogLevel get_LogLevel() { }
        private System.Void set_LogLevel(Beyond.Network.HGNetLogger.LogLevel value) { }
        private System.Int32 get_Channel() { }
        private System.Void set_Channel(System.Int32 value) { }
        private System.Int64 get_Time() { }
        private System.Void set_Time(System.Int64 value) { }
        private System.UInt32 get_FrameCount() { }
        private System.Void set_FrameCount(System.UInt32 value) { }
        private System.Single get_PlayerPosX() { }
        private System.Void set_PlayerPosX(System.Single value) { }
        private System.Single get_PlayerPosY() { }
        private System.Void set_PlayerPosY(System.Single value) { }
        private System.Single get_PlayerPosZ() { }
        private System.Void set_PlayerPosZ(System.Single value) { }
        private System.Int32 get_PlayerPing() { }
        private System.Void set_PlayerPing(System.Int32 value) { }
        private Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogIntParam> get_ParamsIntList() { }
        private Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogFloatParam> get_ParamsFloatList() { }
        private Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogDoubleParam> get_ParamsDoubleList() { }
        private Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogBoolParam> get_ParamsBoolList() { }
        private Google.Protobuf.Collections.RepeatedField<Beyond.Network.HGNetLogger.LogStringParam> get_ParamsStringList() { }
        private Beyond.Network.HGNetLogger.NativeLogLevel get_NativeLogLevel() { }
        private System.Void set_NativeLogLevel(Beyond.Network.HGNetLogger.NativeLogLevel value) { }
        private System.Int32 get_ReturnLoginCount() { }
        private System.Void set_ReturnLoginCount(System.Int32 value) { }
        private System.Int32 get_AppPauseCount() { }
        private System.Void set_AppPauseCount(System.Int32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Beyond.Network.HGNetLogger.LogMessage other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Beyond.Network.HGNetLogger.LogMessage other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001E
    public class LogMessageResponse, IMessage`1, IMessage, IEquatable`1, IDeepCloneable`1, IBufferMessage
    {
        // Fields
        private static readonly Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogMessageResponse> _parser;        // 0x0
        private Google.Protobuf.UnknownFieldSet _unknownFields;        // 0x10
        public static System.Int32 StatusFieldNumber;        // 0x0
        private Beyond.Network.HGNetLogger.ResponseStatus status_;        // 0x18
        public static System.Int32 MessageFieldNumber;        // 0x0
        private System.String message_;        // 0x20
        public static System.Int32 TemplateHashFieldNumber;        // 0x0
        private System.UInt32 templateHash_;        // 0x28

        // Methods
        private Google.Protobuf.MessageParser<Beyond.Network.HGNetLogger.LogMessageResponse> get_Parser() { }
        private Google.Protobuf.Reflection.MessageDescriptor get_Descriptor() { }
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(Beyond.Network.HGNetLogger.LogMessageResponse other) { }
        private Beyond.Network.HGNetLogger.LogMessageResponse Clone() { }
        private Beyond.Network.HGNetLogger.ResponseStatus get_Status() { }
        private System.Void set_Status(Beyond.Network.HGNetLogger.ResponseStatus value) { }
        private System.String get_Message() { }
        private System.Void set_Message(System.String value) { }
        private System.UInt32 get_TemplateHash() { }
        private System.Void set_TemplateHash(System.UInt32 value) { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(Beyond.Network.HGNetLogger.LogMessageResponse other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Void WriteTo(Google.Protobuf.CodedOutputStream output) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(Google.Protobuf.WriteContext& output) { }
        private System.Int32 CalculateSize() { }
        private System.Void MergeFrom(Beyond.Network.HGNetLogger.LogMessageResponse other) { }
        private System.Void MergeFrom(Google.Protobuf.CodedInputStream input) { }
        private System.Void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(Google.Protobuf.ParseContext& input) { }
        private System.Void .cctor() { }

    }

}

