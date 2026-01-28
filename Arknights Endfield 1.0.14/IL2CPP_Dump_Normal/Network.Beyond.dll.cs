// ========================================================
// Dumped by @desirepro
// Assembly: Network.Beyond.dll
// Classes:  97
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000013
    public class HandlerEntry
    {
        // Fields
        public Beyond.Network.NetResponseHandler handler;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class ResultHandler, IDisposable
    {
        // Fields
        private System.Boolean m_ignoreSeq;        // 0x10
        private Beyond.ListDict<Proto.SCMessageID,System.Object> m_responseTokens;        // 0x18
        private Beyond.ListDict<Proto.SCMessageID,Beyond.Network.NetResponseHandler> m_responseHandlers;        // 0x20
        private System.Boolean <isDisposed>k__BackingField;        // 0x28
        private System.UInt64 <cachedSeqNum>k__BackingField;        // 0x30
        private System.Int32 <sessionID>k__BackingField;        // 0x38

        // Methods
        private System.Boolean get_isDisposed() { }
        private System.Void set_isDisposed(System.Boolean value) { }
        private System.UInt64 get_cachedSeqNum() { }
        private System.Void set_cachedSeqNum(System.UInt64 value) { }
        private System.Int32 get_sessionID() { }
        private System.Void set_sessionID(System.Int32 value) { }
        private System.Void SetIgnoreSeq(System.Boolean ignoreSeq) { }
        private Beyond.Network.NetBus.ResultHandler OnResponse(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler) { }
        private System.Void Dispose() { }
        private System.Void _HandleMessage(Beyond.Network.NetResponse& msg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000015
    public class Sender
    {
        // Methods
        private Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg) { }
        private System.Void OnNetShutDown() { }
        private Beyond.Network.NetBus.ResultHandler DoSend(Google.Protobuf.IMessage message) { }
        private System.Void DoListen(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler) { }
        private System.Void DoUnListen(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000029
    public class NetworkFrequency
    {
        // Fields
        public System.Type type;        // 0x10
        public System.Single second;        // 0x18
        public System.Int32 maxCount;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class MaskInfo
    {
        // Fields
        public System.Int32 key;        // 0x10
        public System.String name;        // 0x18
        public System.Single startTime;        // 0x20
        public System.Single delayTime;        // 0x24
        public System.Single timeoutTime;        // 0x28

        // Methods
        private System.Single get_endTime() { }
        private System.Single get_showDecoTime() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public class Config
    {
        // Fields
        public System.String key;        // 0x10
        public Beyond.SerializeFieldDictionaryPaired<Proto.CSMessageID,Proto.SCMessageID> messages;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002F
    public struct EUrlType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Network.NetworkUrls.EUrlType ServerList;        // 0x0
        public static Beyond.Network.NetworkUrls.EUrlType GameLicense;        // 0x0
        public static Beyond.Network.NetworkUrls.EUrlType AgeTips;        // 0x0
        public static Beyond.Network.NetworkUrls.EUrlType GateBulletin;        // 0x0
        public static Beyond.Network.NetworkUrls.EUrlType GameBulletin;        // 0x0
        public static Beyond.Network.NetworkUrls.EUrlType Launcher;        // 0x0
        public static Beyond.Network.NetworkUrls.EUrlType Gov;        // 0x0

    }

    // TypeToken: 0x2000032
    public struct ErrorType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Network.HttpSender.ErrorType NONE;        // 0x0
        public static Beyond.Network.HttpSender.ErrorType TIMEOUT;        // 0x0
        public static Beyond.Network.HttpSender.ErrorType DNS_FAILED;        // 0x0
        public static Beyond.Network.HttpSender.ErrorType CANCELED;        // 0x0
        public static Beyond.Network.HttpSender.ErrorType INTERNAL;        // 0x0

    }

    // TypeToken: 0x2000033
    public class Cancellation
    {
        // Fields
        private System.Boolean m_isCancelled;        // 0x10
        private System.Action OnCancelInvoked;        // 0x18

        // Methods
        private System.Void add_OnCancelInvoked(System.Action value) { }
        private System.Void remove_OnCancelInvoked(System.Action value) { }
        private System.Void Cancel() { }
        private System.Boolean IsCanceled() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public struct FGetOptions
    {
        // Fields
        public static readonly Beyond.Network.HttpSender.FGetOptions DEFAULT;        // 0x0
        public System.Collections.Generic.Dictionary<System.String,System.String> headers;        // 0x10
        public System.String contentType;        // 0x18
        public System.Boolean headOnly;        // 0x20
        public Beyond.Network.HttpSender.Cancellation cancellation;        // 0x28

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000035
    public struct FPostOptions
    {
        // Fields
        public static readonly Beyond.Network.HttpSender.FPostOptions DEFAULT;        // 0x0
        public System.Collections.Generic.Dictionary<System.String,System.String> headers;        // 0x10
        public System.String textBody;        // 0x18
        public System.String contentType;        // 0x20
        public Beyond.Network.HttpSender.Cancellation cancellation;        // 0x28

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000036
    public struct FSendFunc
    {
        // Fields
        public System.String url;        // 0x10
        public System.Int32 opt;        // 0x18
        public Beyond.Network.HttpSender.FGetOptions optionsGET;        // 0x20
        public Beyond.Network.HttpSender.FPostOptions optionsPOST;        // 0x40
        public System.Boolean editorOnly;        // 0x60

        // Methods
        private UnityEngine.Networking.UnityWebRequest Invoke() { }
        private Beyond.Network.HttpSender.Cancellation GetCancellation() { }
        private System.String GetOptMethod() { }

    }

    // TypeToken: 0x2000037
    public class Result
    {
        // Fields
        public System.Int32 respCode;        // 0x10
        public Beyond.Network.HttpSender.ErrorType errorType;        // 0x14
        public System.Boolean isError;        // 0x18
        public System.Exception exception;        // 0x20
        public System.String respText;        // 0x28
        public System.Byte[] respData;        // 0x30
        public System.String respError;        // 0x38
        public System.Boolean isServiceDone;        // 0x40

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000038
    public class TypedResult : Result
    {
        // Fields
        private System.Type <respType>k__BackingField;        // 0x48
        public System.Object respObject;        // 0x50
        public System.Boolean isDeserializeFailed;        // 0x58

        // Methods
        private System.Type get_respType() { }
        private System.Void set_respType(System.Type value) { }
        private System.Void .ctor(System.Type respType) { }

    }

    // TypeToken: 0x2000039
    public class Result`1 : TypedResult
    {
        // Methods
        private System.Void .ctor() { }
        private TResp GetRespObject() { }

    }

    // TypeToken: 0x2000057
    public class LoginErrorInfo
    {
        // Fields
        private System.Int32 <code>k__BackingField;        // 0x10
        private System.String <details>k__BackingField;        // 0x18

        // Methods
        private System.Int32 get_code() { }
        private System.Void set_code(System.Int32 value) { }
        private System.String get_details() { }
        private System.Void set_details(System.String value) { }
        private System.Void SetErrorInvaild() { }
        private System.Void SetErrorConnectError() { }
        private System.Void SetErrorConnectTimeOut() { }
        private System.Void Clear() { }
        private System.Void Set(System.Int32 code, System.String details) { }
        private System.Void .ctor() { }

    }

namespace Beyond.Network
{

    // TypeToken: 0x2000007
    public class DoubleQueue`1
    {
        // Fields
        private System.Collections.Generic.Queue<T> m_readQueue;        // 0x0
        private System.Collections.Generic.Queue<T> m_writeQueue;        // 0x0

        // Methods
        private System.Void LockingSwap() { }
        private System.Void TryLockingSwap() { }
        private System.Void Enqueue(T item) { }
        private System.Boolean TryDequeue(T& item) { }
        private System.Void EnqueueRange(System.Collections.Generic.List<T> list) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class HGTcpClient, IDisposable
    {
        // Fields
        private System.Net.Sockets.Socket m_ClientSocket;        // 0x10
        private System.Boolean m_Active;        // 0x18
        private System.Net.Sockets.NetworkStream m_DataStream;        // 0x20
        private System.Net.Sockets.AddressFamily m_Family;        // 0x28
        private System.Boolean m_CleanedUp;        // 0x2C

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String hostname, System.Int32 port) { }
        private System.Void .ctor(System.Net.Sockets.Socket acceptedSocket) { }
        private System.Net.Sockets.Socket get_Client() { }
        private System.Void set_Client(System.Net.Sockets.Socket value) { }
        private System.Boolean get_Active() { }
        private System.Void set_Active(System.Boolean value) { }
        private System.Int32 get_Available() { }
        private System.Boolean get_Connected() { }
        private System.Boolean get_ExclusiveAddressUse() { }
        private System.Void set_ExclusiveAddressUse(System.Boolean value) { }
        private System.Void Connect(System.String hostname, System.Int32 port) { }
        private System.Void Connect(System.Net.IPAddress address, System.Int32 port) { }
        private System.Void Connect(System.Net.IPEndPoint remoteEP) { }
        private System.Void Connect(System.Net.IPAddress[] ipAddresses, System.Int32 port) { }
        private System.IAsyncResult BeginConnect(System.String host, System.Int32 port, System.AsyncCallback requestCallback, System.Object state) { }
        private System.IAsyncResult BeginConnect(System.Net.IPAddress address, System.Int32 port, System.AsyncCallback requestCallback, System.Object state) { }
        private System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, System.Int32 port, System.AsyncCallback requestCallback, System.Object state) { }
        private System.Void EndConnect(System.IAsyncResult asyncResult) { }
        private System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress address, System.Int32 port) { }
        private System.Threading.Tasks.Task ConnectAsync(System.String host, System.Int32 port) { }
        private System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress[] addresses, System.Int32 port) { }
        private System.Net.Sockets.NetworkStream GetStream() { }
        private System.Void Close() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }
        private System.Int32 get_ReceiveBufferSize() { }
        private System.Void set_ReceiveBufferSize(System.Int32 value) { }
        private System.Int32 get_SendBufferSize() { }
        private System.Void set_SendBufferSize(System.Int32 value) { }
        private System.Int32 get_ReceiveTimeout() { }
        private System.Void set_ReceiveTimeout(System.Int32 value) { }
        private System.Int32 get_SendTimeout() { }
        private System.Void set_SendTimeout(System.Int32 value) { }
        private System.Net.Sockets.LingerOption get_LingerState() { }
        private System.Void set_LingerState(System.Net.Sockets.LingerOption value) { }
        private System.Boolean get_NoDelay() { }
        private System.Void set_NoDelay(System.Boolean value) { }
        private System.Void _Initialize() { }
        private System.Int32 _NumericOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName) { }

    }

    // TypeToken: 0x2000009
    public interface INetIO : IDisposable
    {
        // Methods
        private System.Void Connect(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize) { }
        private System.Threading.Tasks.Task ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize) { }
        private System.Void Close() { }
        private System.Void TestCloseNetIO(System.Boolean bIsTestReconnectFailed) { }
        private System.Void TestDropNetIO(System.Boolean bIsTestDropSC, System.Boolean bIsTestDropCS) { }
        private System.Boolean IsConnected() { }
        private System.Int32 ReadData(System.Byte[] buffer, System.Int32 offset, System.Int32 len) { }
        private System.Void WriteData(System.Byte[] data, System.Int32 offset, System.Int32 len) { }
        private System.Boolean IsAuthed() { }
        private System.Void MarkAuthed() { }
        private System.Void EnableCryptStream(System.Byte[] key, System.Byte[] iv) { }
        private System.Int32 ReadCryptoData(System.Byte[] buffer, System.Int32 offset, System.Int32 len) { }
        private System.Void WriteCryptoData(System.Byte[] data, System.Int32 offset, System.Int32 len) { }
        private System.Byte[] GetSendHeadBuffer() { }
        private System.Byte[] GetSendBuffer() { }
        private System.Byte[] GetReceiveBuffer() { }
        private System.Int32 GetReceiveBufferOffset() { }
        private System.Void ClearReceiveBufferOffset() { }
        private System.Void SkipReceiveBufferOffset(System.Int32 len) { }
        private System.Net.EndPoint GetEndPoint() { }
        private System.Int32 Available() { }

    }

    // TypeToken: 0x200000A
    public class NetMsgHandlerAttribute : Attribute
    {
        // Fields
        public readonly System.Type msgType;        // 0x10

        // Methods
        private System.Void .ctor(System.Type t) { }
        private System.Void .ctor() { }
        private System.Type GetMsgType(System.Reflection.MethodInfo annotatedMethod) { }

    }

    // TypeToken: 0x200000B
    public class NetResponseHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Beyond.Network.NetResponse& msg) { }
        private System.IAsyncResult BeginInvoke(Beyond.Network.NetResponse& msg, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(Beyond.Network.NetResponse& msg, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000C
    public class NetMessageHandle`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T message) { }
        private System.IAsyncResult BeginInvoke(T message, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000D
    public interface INetBusResponseListener
    {
        // Methods
        private System.Void UpdateMsgTime(Beyond.Network.NetResponse resp) { }

    }

    // TypeToken: 0x200000E
    public struct NetRequest
    {
        // Fields
        public System.UInt64 csSeqID;        // 0x10
        public System.Int32 mergeNum;        // 0x18
        public Google.Protobuf.IMessage msg;        // 0x20

    }

    // TypeToken: 0x200000F
    public struct NetResponse
    {
        // Fields
        public static Beyond.Network.NetResponse EMPTY;        // 0x0
        public Google.Protobuf.IMessage headMsg;        // 0x10
        public Google.Protobuf.IMessage msgBody;        // 0x18
        public System.Boolean isPacked;        // 0x20
        public System.Int64 recvTimestamp;        // 0x28

        // Methods
        private Beyond.Network.HGNetLogger.Header get_logHead() { }
        private System.Void set_logHead(Beyond.Network.HGNetLogger.Header value) { }
        private Proto.CSHead get_csHead() { }
        private System.Void set_csHead(Proto.CSHead value) { }
        private System.Int32 get_msgId() { }
        private System.UInt64 get_csSeqId() { }
        private System.UInt64 get_scSeqId() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000010
    public class MessageHandleWrapper
    {
        // Methods
        private System.Void HandleMessage(Google.Protobuf.IMessage msg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class MessageHandleWrapper`1 : MessageHandleWrapper
    {
        // Fields
        private readonly Beyond.Network.NetMessageHandle<T> m_handle;        // 0x0

        // Methods
        private System.Void .ctor(Beyond.Network.NetMessageHandle<T> handle) { }
        private System.Void HandleMessage(Google.Protobuf.IMessage msg) { }

    }

    // TypeToken: 0x2000012
    public class NetBus : ExplicitSingleton`1
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.Network.NetResponseHandler> m_msgHandlers;        // 0x10
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<Beyond.Network.NetBus.HandlerEntry>> m_msgWithSeqNumHandlers;        // 0x18
        private readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.Network.MessageHandleWrapper> m_msgHdlWrappers;        // 0x20
        private Beyond.Network.HGNetSession m_netSession;        // 0x28
        private static System.Collections.Generic.List<Beyond.Network.NetResponseHandler> s_handlersToCall;        // 0x0
        private readonly Beyond.Network.UIBusSender <uiSender>k__BackingField;        // 0x30
        private readonly Beyond.Network.DisposableBusSender <defaultSender>k__BackingField;        // 0x38
        private readonly Beyond.Network.Special2BusSender <s2Sender>k__BackingField;        // 0x40
        private readonly Beyond.Network.InteractiveBusSender <interactiveSender>k__BackingField;        // 0x48
        private readonly Beyond.Network.FrequencyControlBusSender <frequencyControlSender>k__BackingField;        // 0x50

        // Methods
        private Beyond.Network.UIBusSender get_uiSender() { }
        private Beyond.Network.DisposableBusSender get_defaultSender() { }
        private Beyond.Network.Special2BusSender get_s2Sender() { }
        private Beyond.Network.InteractiveBusSender get_interactiveSender() { }
        private Beyond.Network.FrequencyControlBusSender get_frequencyControlSender() { }
        private System.Int32 get_currentSessionID() { }
        private System.Void .ctor() { }
        private System.Boolean IsBusBusy() { }
        private System.Void Setup(Beyond.Network.HGNetSession session) { }
        private System.Void Send(Google.Protobuf.IMessage msg) { }
        private System.Void RegisterMessageHandler(System.Int32 msgId, Beyond.Network.MessageHandleWrapper handler) { }
        private System.Void UnRegisterMessageHandler(System.Int32 msgId) { }
        private System.Void HandleMessageTime(Beyond.Network.NetResponse response) { }
        private System.Void HandleMessage(Beyond.Network.NetResponse response) { }
        private System.Boolean _ValidateSession() { }
        private System.Void OnNetClientShutDown() { }
        private Beyond.Network.NetBus.ResultHandler _SendWithResult(Google.Protobuf.IMessage msg) { }
        private System.Void _Listen(System.Int32 msgId, Beyond.Network.NetResponseHandler handler) { }
        private System.Void _UnListen(System.Int32 msgId, Beyond.Network.NetResponseHandler handler) { }
        private System.Object _ListenWithSeqNum(System.Int32 msgId, Beyond.Network.NetResponseHandler callback) { }
        private System.Void _UnListenWithSeqNum(System.Int32 msgId, System.Object token) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000016
    public class Special2BusSender : DisposableBusSender, INetBusResponseListener
    {
        // Fields
        public System.Collections.Generic.Dictionary<System.UInt64,System.Double> sendedMsgWithTime;        // 0x20
        public System.Double minSendTime;        // 0x28
        private System.Single m_maxWaitTime;        // 0x30

        // Methods
        private System.Boolean get_isBusBusy() { }
        private Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg) { }
        private System.Void UpdateStartBlockTime() { }
        private System.Void OnNetShutDown() { }
        private System.Void Dispose() { }
        private System.Void _ClearSendTime() { }
        private System.Void UpdateMsgTime(Beyond.Network.NetResponse resp) { }
        private System.Void .ctor() { }
        private Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0) { }
        private System.Void <>iFixBaseProxy_OnNetShutDown() { }
        private System.Void <>iFixBaseProxy_Dispose() { }

    }

    // TypeToken: 0x2000017
    public class InteractiveBusSender : Special2BusSender
    {
        // Fields
        private System.Single m_maxWaitTime;        // 0x38

        // Methods
        private System.Boolean get_isBusBusy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000018
    public class DisposableBusSender : Sender, IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.HashSet<Beyond.Network.NetBus.ResultHandler> m_resultHandlers;        // 0x10
        private System.Boolean <isDisposed>k__BackingField;        // 0x18

        // Methods
        private System.Boolean get_isDisposed() { }
        private System.Void set_isDisposed(System.Boolean value) { }
        private Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg) { }
        private System.Void OnNetShutDown() { }
        private System.Void Dispose() { }
        private System.Void _Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class NetworkMaskConfigHolder
    {
        // Fields
        public System.Collections.Generic.Dictionary<Proto.CSMessageID,Proto.SCMessageID> msgs;        // 0x10

        // Methods
        private System.Void Init() { }
        private System.Void Dispose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public class UIBusSender : DisposableBusSender
    {
        // Fields
        private Beyond.Network.NetworkMaskConfigHolder <config>k__BackingField;        // 0x20
        private System.Collections.Generic.HashSet<System.Int32> m_maskKeys;        // 0x28

        // Methods
        private Beyond.Network.NetworkMaskConfigHolder get_config() { }
        private System.Void set_config(Beyond.Network.NetworkMaskConfigHolder value) { }
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg) { }
        private System.Void OnNetShutDown() { }
        private System.Void <>iFixBaseProxy_Dispose() { }
        private Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0) { }
        private System.Void <>iFixBaseProxy_OnNetShutDown() { }

    }

    // TypeToken: 0x200001C
    public class FrequencyControlBusSender : DisposableBusSender
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<Proto.CSMessageID,System.Collections.Generic.Queue<System.Double>> m_lastSendTime;        // 0x20
        private System.Collections.Generic.List<Google.Protobuf.IMessage> m_waitingSendMsgs;        // 0x28
        private System.Collections.Generic.List<System.Action<System.Int32>> m_onError;        // 0x30
        private System.Int32 m_loopId;        // 0x38

        // Methods
        private System.Void .ctor() { }
        private System.Void _TrySendWaitingMsg() { }
        private Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg) { }
        private Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg, System.Boolean needAddToWaitingList, System.Action<System.Int32> onError, System.Action onWait) { }
        private System.Void Dispose() { }
        private Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0) { }
        private System.Void <>iFixBaseProxy_Dispose() { }

    }

    // TypeToken: 0x200001E
    public class ServerDesc
    {
        // Fields
        public System.String name;        // 0x10
        public System.String addr;        // 0x18
        public System.Int32 port;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class ServerList
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Network.ServerDesc> servers;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class ServerConfig
    {
        // Fields
        public System.String serverName;        // 0x10
        public System.String uid;        // 0x18
        public System.Boolean checkDev;        // 0x20

        // Methods
        private System.Boolean IsSame(Beyond.Network.ServerConfig other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class HostData
    {
        // Fields
        public System.String host;        // 0x10
        public System.Int32 port;        // 0x18
        public System.Double delay;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000022
    public class NetConfig
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Network.HostData> hosts;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.Generic.List<Beyond.Network.HostData> hosts) { }

    }

    // TypeToken: 0x2000023
    public class NetConsts
    {
        // Fields
        public static readonly System.String NETMASK_CONFIG_PATH;        // 0x0
        public static readonly System.String NETMASK_PREFAB_PATH;        // 0x8

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000024
    public interface INetworkSystem : ILuaCallCSharp
    {
        // Methods
        private System.Void OnReConnect() { }
        private System.Void SendMsg(Google.Protobuf.IMessage msg, System.Action<System.Int32> onError) { }

    }

    // TypeToken: 0x2000025
    public class NetUtil
    {
        // Fields
        private static System.Boolean s_isRegistedAllMessages;        // 0x0
        public static readonly System.Int32 MAX_RECEIVE_PACK_BODY_SIZE;        // 0x4
        public static readonly System.Int32 MAX_MERGE_PACK_BODY_SIZE;        // 0x8
        public static readonly System.Int32 MAX_SEND_PACK_BODY_SIZE;        // 0xC
        private static System.Collections.Generic.Dictionary<System.Int32,System.Type> s_sc_id2MessageType;        // 0x10
        private static System.Collections.Generic.Dictionary<System.Type,System.Int32> s_sc_messageType2Id;        // 0x18
        private static System.Collections.Generic.Dictionary<System.Type,System.Int32> s_cs_messageType2Id;        // 0x20
        private static System.Byte[] s_decompressedBuffer;        // 0x28

        // Methods
        private System.Void RegisterSCMessage(System.Int32 msgId, System.Type msgType) { }
        private System.Void RegisterCSMessage(System.Int32 msgId, System.Type msgType) { }
        private System.Int32 GetSCMsgIdByType(System.Type msgType) { }
        private System.Type GetSCMsgTypeById(System.Int32 msgId) { }
        private System.Int32 GetCSMsgIdByType(System.Type msgType) { }
        private System.Void _GenMessageName2ValuePair(System.Collections.Generic.Dictionary<System.String,System.Int32> dic) { }
        private System.Void FastRegisterMessage() { }
        private System.Boolean GetNetMessageFromDataBytes(System.Span<System.Byte> headBytes, System.Byte[] bodyBuffer, System.Int32 offset, System.Int32 bodyLen, System.Byte[] packedbuffer, Beyond.Network.NetResponse& response) { }
        private System.Int32 SerializeHeadMessage(Google.Protobuf.IMessage msg, System.UInt64 upSeqid, System.Int32 bodyLen, System.Int32 crc32, System.Byte[] buffer, System.Int32 offset) { }
        private System.Int32 SerializeBodyMessage(Google.Protobuf.IMessage msg, System.Byte[] buffer, System.Int32& crc32, System.Int32 offset) { }
        private System.Void AutoRegisterMessageHandlers(System.Object target) { }
        private System.Void AutoUnRegisterMessageHandlers(System.Object target) { }
        private System.Void _ForeachMessageHandlers(System.Object target, System.Action<System.Type,System.Reflection.MethodInfo> doFunc) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000028
    public class NetworkFrequencyConfig
    {
        // Fields
        public static Beyond.SerializeFieldDictionary<System.Int32,Beyond.Network.NetworkFrequencyConfig.NetworkFrequency> msgs;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002A
    public class NetworkMask : Singleton`1
    {
        // Fields
        private Beyond.TickFunction m_preTickFunction;        // 0x10
        private System.Int32 m_nextKey;        // 0x18
        public UnityEngine.GameObject maskObj;        // 0x20
        public UnityEngine.GameObject decoObj;        // 0x28
        private Beyond.Resource.FAssetProxyHandle m_handle;        // 0x30
        private System.Action<System.Boolean> m_onNetMaskChanged;        // 0x48
        private System.Boolean <showingMask>k__BackingField;        // 0x50
        private System.Boolean <showingDeco>k__BackingField;        // 0x51
        private System.Boolean m_isNetReconnecting;        // 0x52
        private static System.String DECO_NAME;        // 0x0
        private System.Collections.Generic.List<Beyond.Network.NetworkMask.MaskInfo> m_masks;        // 0x58

        // Methods
        private System.Boolean get_showingMask() { }
        private System.Void set_showingMask(System.Boolean value) { }
        private System.Boolean get_showingDeco() { }
        private System.Void set_showingDeco(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void OnInit() { }
        private System.Void OnUnInit() { }
        private System.Void Release() { }
        private System.Void _OnSwitchLanguage() { }
        private System.Void _CreateTickFunction() { }
        private System.Void _ClearTickFunction() { }
        private System.Void PreTick(System.Single deltaTime) { }
        private System.Int32 _GetKey() { }
        private System.Int32 AddMask(Proto.CSMessageID msgId, System.Single timeoutTime) { }
        private System.Int32 AddMask(System.String name, System.Single timeoutTime, System.Single delayTime) { }
        private System.Void RemoveMask(System.Int32 key) { }
        private System.Void SetIsNetReconnecting(System.Boolean isReconnecting) { }
        private System.Void _UpdateMaskState() { }
        private System.Void ListenOnNetMaskChanged(System.Action<System.Boolean> action) { }
        private System.Void UnListenOnNetMaskChanged(System.Action<System.Boolean> action) { }

    }

    // TypeToken: 0x200002C
    public class NetworkMaskConfig : ScriptableObject
    {
        // Fields
        public Beyond.SerializeFieldDictionary<Proto.CSMessageID,Proto.SCMessageID> msgs;        // 0x18
        public System.Collections.Generic.List<Beyond.Network.NetworkMaskConfig.Config> configs;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class NetworkUrls
    {
        // Fields
        public static System.String URL_GET_SPLIT;        // 0x0

        // Methods
        private System.String RemoteConfigUrl() { }
        private System.String ResourceRootUrlDev(System.String version) { }
        private System.String ServerListUrl() { }
        private System.String AgeTipsUrl() { }
        private System.String GovUrl() { }
        private System.String LauncherUrl() { }
        private System.String _SelectUrl(System.String urlInConfig, Beyond.Network.NetworkUrls.EUrlType urlType) { }
        private System.String _GetUrlFromLocal(Beyond.Network.NetworkUrls.EUrlType type) { }

    }

    // TypeToken: 0x2000030
    public class TcpIO, INetIO, IDisposable
    {
        // Fields
        private Beyond.Network.HGTcpClient m_tcpClient;        // 0x10
        protected System.Byte[] m_recvBuffer;        // 0x18
        protected System.Byte[] m_sendHeadBuffer;        // 0x20
        protected System.Byte[] m_sendBuffer;        // 0x28
        protected System.Int32 m_recvBufferOffset;        // 0x30
        private Beyond.XXEnc.XXE1 m_encryptor;        // 0x38
        private Beyond.XXEnc.XXE1 m_decryptor;        // 0x40
        protected System.Boolean m_isAuthed;        // 0x48
        private System.Boolean m_bIsTestDropSC;        // 0x49
        private System.Boolean m_bIsTestDropCS;        // 0x4A
        private System.Boolean m_bIsTestReconnectFailed;        // 0x4B
        public static System.Int32 SEND_HEAD_BUFFER_LENGTH;        // 0x0

        // Methods
        private System.Void Connect(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize) { }
        private System.Threading.Tasks.Task ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize) { }
        private System.Boolean IsAuthed() { }
        private System.Void MarkAuthed() { }
        private System.Void EnableCryptStream(System.Byte[] key, System.Byte[] iv) { }
        private System.Net.EndPoint GetEndPoint() { }
        private System.Void Close() { }
        private System.Void TestCloseNetIO(System.Boolean bIsTestReconnectFailed) { }
        private System.Void TestDropNetIO(System.Boolean bIsTestDropSC, System.Boolean bIsTestDropCS) { }
        private System.Boolean IsConnected() { }
        private System.Void WriteData(System.Byte[] data, System.Int32 offset, System.Int32 len) { }
        private System.Void WriteCryptoData(System.Byte[] data, System.Int32 offset, System.Int32 len) { }
        private System.Byte[] GetSendHeadBuffer() { }
        private System.Byte[] GetSendBuffer() { }
        private System.Byte[] GetReceiveBuffer() { }
        private System.Void ClearReceiveBufferOffset() { }
        private System.Int32 GetReceiveBufferOffset() { }
        private System.Void SkipReceiveBufferOffset(System.Int32 len) { }
        private System.Int32 ReadData(System.Byte[] buffer, System.Int32 offset, System.Int32 len) { }
        private System.Int32 ReadCryptoData(System.Byte[] buffer, System.Int32 offset, System.Int32 len) { }
        private System.Int32 Available() { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000031
    public class HttpSender
    {
        // Fields
        public static System.String CONTENT_TYPE_JSON;        // 0x0
        public static System.String CONTENT_ENCODING_GZIP;        // 0x0
        public static System.Int32 ERROR_CODE_TIMEOUT;        // 0x0
        public static System.Int32 ERROR_CODE_DNS_FAILED;        // 0x0
        public static System.Int32 ERROR_CODE_DESERIALIZE;        // 0x0
        public static System.Single TIMEOUT_DEFAULT;        // 0x0
        private static System.Int32 OPT_GET;        // 0x0
        private static System.Int32 OPT_POST;        // 0x0

        // Methods
        private System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, Beyond.Misc.ObjectRef resultRef) { }
        private System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, Beyond.Misc.ObjectRef resultRef) { }
        private System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, System.Type respType, Beyond.Misc.ObjectRef resultRef) { }
        private System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, Beyond.Misc.ObjectRef resultRef) { }
        private System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, Beyond.Misc.ObjectRef resultRef) { }
        private System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, System.Type respType, Beyond.Misc.ObjectRef resultRef) { }
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options) { }
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendGet(System.String url) { }
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options) { }
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> WaitForSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options) { }
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> WaitForSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options) { }
        private System.Int32 GetGeneralErrorCode(Beyond.Network.HttpSender.Result result, System.Boolean& hasError) { }
        private System.Collections.IEnumerator _YieldSendHttpRequest(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc) { }
        private System.Collections.IEnumerator _YieldSendHttpRequest(Beyond.Misc.ObjectRef resultRef, Beyond.Network.HttpSender.FSendFunc sendFunc, System.Type respType) { }
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> _WaitForSendHttpRequest(Beyond.Network.HttpSender.FSendFunc sendFunc) { }
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> _WaitForSendHttpRequest(Beyond.Network.HttpSender.FSendFunc sendFunc) { }
        private System.Void _StartWebRequestTask(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc) { }
        private System.Void _WaitForServiceDone(Beyond.Network.HttpSender.Result result) { }
        private UnityEngine.Networking.UnityWebRequest _CreateWebRequestGET(System.String url, Beyond.Network.HttpSender.FGetOptions options) { }
        private UnityEngine.Networking.UnityWebRequest _CreateWebRequestPOST(System.String url, Beyond.Network.HttpSender.FPostOptions options) { }
        private System.Void _SetHttpResult(Beyond.Network.HttpSender.Result result, UnityEngine.Networking.UnityWebRequest request) { }
        private System.Void _DeserializeTypedResult(Beyond.Network.HttpSender.TypedResult result) { }
        private System.Void _DebugOnlyProfileResult(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc) { }
        private System.Void _MarkResultAsException(Beyond.Network.HttpSender.Result result, System.Exception ex) { }

    }

    // TypeToken: 0x2000044
    public class CircularBuffer`1, IEnumerable`1, IEnumerable, IReadOnlyList`1, IReadOnlyCollection`1
    {
        // Fields
        private readonly T[] m_buffer;        // 0x0
        private System.Int32 m_end;        // 0x0
        private System.Int32 m_count;        // 0x0
        private System.Int32 m_start;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void .ctor(System.Int32 capacity, T[] items) { }
        private System.Int32 get_Capacity() { }
        private System.Boolean get_IsFull() { }
        private System.Boolean get_IsEmpty() { }
        private System.Int32 get_Count() { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.Void Clear() { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private T Front() { }
        private System.Boolean TryFront(T& result) { }
        private T Back() { }
        private System.Boolean TryBack(T& result) { }
        private System.Void PushBack(T item) { }
        private System.Void PushFront(T item) { }
        private System.Void PopBack() { }
        private System.Void PopFront() { }
        private System.Boolean TryPopFront(T& result) { }
        private System.Boolean TryPopBack(T& result) { }
        private T[] ToArray() { }
        private System.Void _ThrowIfEmpty(System.String message) { }
        private System.Void _Increment(System.Int32& index) { }
        private System.Void _Decrement(System.Int32& index) { }
        private System.Int32 _InternalIndex(System.Int32 index) { }
        private System.ArraySegment<T> _ArrayOne() { }
        private System.ArraySegment<T> _ArrayTwo() { }

    }

    // TypeToken: 0x2000046
    public class HGNetBaseSession
    {
        // Fields
        private Beyond.Network.INetIO m_tcpIO;        // 0x10
        public static System.Int32 s_recvBuffLen;        // 0x0
        public static System.Int32 s_tcpSendTimeout;        // 0x4
        public static System.Int32 s_sessionThreadSleepTimeMS;        // 0x8
        public static System.Int32 s_sessionThreadPauseSleepTimeMS;        // 0xC
        public System.Int32 m_maxReconnectTimeout;        // 0x18
        public System.Int32 m_maxReconnectTimes;        // 0x1C
        public System.Int32 sendNumLimit;        // 0x20
        protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetResponse> m_recvQueue;        // 0x28
        protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest> m_sendQueue;        // 0x30
        private static System.Int32 MAX_RECYCLE_QUEUE_COUNT;        // 0x0
        protected Beyond.Network.CircularBuffer<Beyond.Network.NetRequest> m_circularBuffer;        // 0x38
        private System.Int64 m_csSeqId;        // 0x40
        protected System.Int64 m_scSeqId;        // 0x48
        protected System.Threading.Tasks.Task m_threadTask;        // 0x50
        protected System.Int32 m_threadTaskSignalID;        // 0x58
        protected Beyond.ELogChannel m_logChannel;        // 0x5C
        protected System.Boolean m_isSyncFullDataEnd;        // 0x5D
        protected Google.Protobuf.IMessage m_lastLoginMsg;        // 0x60
        private System.String m_lastConnectServerIp;        // 0x68
        private System.Int32 m_lastConnectServerPort;        // 0x70
        protected System.Int32 m_tryReconnectTimes;        // 0x74
        protected System.Boolean m_isAutoReconnect;        // 0x78
        protected System.Int64 m_startReconnectTimestampMS;        // 0x80
        protected System.Int32 m_closeNetMsgID;        // 0x88
        public static System.Int32 INVALID_SESSION_ID;        // 0x10
        protected static System.Int32 s_sessionIDGenerator;        // 0x14
        private System.Int32 <sessionID>k__BackingField;        // 0x8C
        protected Beyond.Network.HGNetSessionConnectYield m_lastAsyncConnectHandle;        // 0x90
        protected Beyond.Network.EHGNetSessionState m_state;        // 0x98
        private Beyond.Network.EHGNetSessionReconnectState m_reconnectState;        // 0x99
        protected System.Double m_startReconnectTimeMS;        // 0xA0
        protected System.Int32 m_closeErrorCode;        // 0xA8
        public static System.Boolean s_applicationIsPaused;        // 0x18
        private System.Int64 m_clientLastReceiveMsgMilliTs;        // 0xB0
        private System.Int64 m_clientLastSendMsgMilliTs;        // 0xB8

        // Methods
        private System.Int32 get_sessionID() { }
        private System.Void set_sessionID(System.Int32 value) { }
        private Beyond.Network.EHGNetSessionReconnectState get_reconnectState() { }
        private System.Void set_reconnectState(Beyond.Network.EHGNetSessionReconnectState value) { }
        private System.Boolean get_isRunning() { }
        private System.Boolean get_isConnecting() { }
        private System.Boolean get_isRunningAndConnected() { }
        private System.Boolean get_isReconnecting() { }
        private System.Int32 get_closeErrorCode() { }
        private System.Boolean get_isAutoReconnect() { }
        private System.Int32 get_maxRecycleQueueCount() { }
        private System.Void Start() { }
        private System.Boolean Connect(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect) { }
        private System.Boolean ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect, Beyond.Network.HGNetSessionConnectYield& yieldHandle) { }
        private System.Void OnConnectAsyncEnd(System.Threading.Tasks.Task completedTask, Beyond.Network.INetIO tcpIO) { }
        private System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO) { }
        private System.Void _DNSCheck(System.String serverIp) { }
        private System.Void Close(Beyond.Network.ENetCloseReason netCloseReason) { }
        private System.Void InternalClose(Beyond.Network.INetIO tcpIO, Beyond.Network.ENetCloseReason netCloseReason) { }
        private System.Void InternalClose(Beyond.Network.INetIO tcpIO, System.Int32 netCloseReason) { }
        private System.Void EnqueueSendMsg(Beyond.Network.NetRequest msg) { }
        private System.Int32 GetSendQueueMsgCount() { }
        private System.Int64 IncrementCSSeqID() { }
        private System.Void SetCSSeqID(System.Int64 id) { }
        private System.Int64 GetCSSeqID() { }
        private Beyond.Network.INetIO GetIO() { }
        private System.Void StartTCPMsgLoopThreadTask() { }
        private System.Void CloseTCPMsgThreadTask() { }
        private System.Threading.Tasks.Task _SessionThread(Beyond.Network.INetIO tcp, System.Int32 threadID) { }
        private System.Boolean _SendAndCheckMessage(Beyond.Network.INetIO tcp, System.Int32 threadID) { }
        private System.Boolean _ReadAndCheckMessageInSessionThread(Beyond.Network.INetIO tcp, System.Int32 threadID) { }
        private System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp) { }
        private System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& m) { }
        private System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m) { }
        private System.Void SessionCheckSignalAndSleep(System.Int32 threadID) { }
        private System.Void OpenAutoReconnect() { }
        private System.Void RemoveAutoReconnect() { }
        private System.Threading.Tasks.Task _ReconnectCheckerTick(Beyond.Network.INetIO tcpIO) { }
        private System.Threading.Tasks.Task<System.Boolean> TryConnectWithTimeout(Beyond.Network.INetIO tcpIO, System.String ip, System.Int32 port, System.Int32 sendTimeout, System.Int32 receiveBufferLen, System.Int32 timeoutMilliseconds) { }
        private System.Threading.Tasks.Task<System.Boolean> TryCloseTcpIOWithTimeout(Beyond.Network.INetIO tcpIO, System.Int32 timeoutMilliseconds) { }
        private System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO) { }
        private System.Boolean NeedKeepConnect() { }
        private System.Void DoReconnectLogin(Beyond.Network.INetIO netIO) { }
        private System.Void InitClientRSAKey() { }
        private System.Void ClearRSAKey() { }
        private System.Void ClearRecvQueue() { }
        private System.Void ClearSendQueue() { }
        private System.Void NetStatusChecker_Receive(Beyond.Network.INetIO netIO, System.Int64 scSeqId, System.Int32 receiveCount) { }
        private System.Void NetStatusChecker_Sender(Beyond.Network.INetIO netIO, System.Int64 csSeqId, System.Int32 sendCount) { }
        private System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs) { }
        private System.Void ClearPingWDG() { }
        private System.Boolean IsPingOut() { }
        private System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004F
    public class HGNetSession : HGNetBaseSession
    {
        // Fields
        private System.String m_uid;        // 0xC0
        private System.String m_token;        // 0xC8
        private System.Int32 m_channel;        // 0xD0
        public static System.Int32 LOGIN_TIMEOUT;        // 0x0
        public static System.Int32 MAX_CLIENT_RESEND_NUM;        // 0x4
        public static System.Single PER_FRAME_RECEIVED_MESSAGES_TIME_30FPS;        // 0x8
        public static System.Single PER_FRAME_RECEIVED_MESSAGES_TIME;        // 0xC
        public static System.Single MESSAGE_MAX_DELAY_TIME;        // 0x10
        protected System.Int32 m_messageDelayCount;        // 0xD4
        protected System.Int64 m_logCDTimestamp;        // 0xD8
        private static System.Boolean s_HGNetSessionBurst;        // 0x14
        private readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest> m_frameSendQueue;        // 0xE0
        private System.Collections.Generic.Queue<Beyond.Network.NetRequest> m_mergeQueueCache;        // 0xE8
        private System.Object m_frameSendQueueLocker;        // 0xF0
        private System.Byte[] m_frameSendPacketBuffer;        // 0xF8
        private System.Byte[] m_frameSendPacketHeadBuffer;        // 0x100
        private System.Byte[] m_frameSendPacketTempBuffer;        // 0x108
        private System.Byte[] m_frameSendCryptoBuffer;        // 0x110
        private System.Byte[] m_frameReceivePacketBuffer;        // 0x118
        public static System.Int64 s_maxframeSendPacketBuffer;        // 0x18
        protected readonly System.Collections.Generic.Queue<Beyond.Network.NetResponse> m_callbackQueue;        // 0x120
        private Beyond.Network.HGNetSessionLoginYield m_currLoginHandle;        // 0x128
        private static System.Int32 SEND_PING_DELTA_TICK_TIME_MS;        // 0x0
        private static System.Int32 s_pingWdgOutTimes;        // 0x20
        private static System.Int32 s_pingSyncFullEndBeforeTimes;        // 0x24
        private System.Int64 m_needSendPingTimer;        // 0x130
        private System.Int32 m_pingWDG;        // 0x138
        private System.Int64 m_clientTsDelayms;        // 0x140
        private System.Int32 m_pingValue;        // 0x148
        private static readonly System.String CLIENT_NET_PEM_PUBLIC_KEY_HEAD_FORMAT;        // 0x28
        private static readonly System.String CLIENT_NET_RSA_PUBLIC_KEY;        // 0x30
        private static readonly System.String CLIENT_NET_RSA_PRIVATE_KEY;        // 0x38
        private static System.Byte[] s_clientPublicKeyBytes;        // 0x40
        private System.Security.Cryptography.RSA m_rsaClientPrivateProvider;        // 0x150
        private static readonly System.Byte[] EMPTY_BYTES;        // 0x48
        private static System.Int32 s_CacheLogLength;        // 0x50
        private System.Text.StringBuilder m_sbCache;        // 0x158

        // Methods
        private System.Void SetAutoReconnectToken(System.String uid, System.String token, System.Int32 channel) { }
        private System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs) { }
        private System.Void DoReconnectLogin(Beyond.Network.INetIO netIO) { }
        private System.Void Start() { }
        private System.Void OnApplicationPause(System.Boolean pause) { }
        private System.UInt64 SendMessage(Google.Protobuf.IMessage msg) { }
        private System.Void PackMessageToSendQueue() { }
        private System.Void UpdateInGameThread() { }
        private System.Void TailLateUpdateInGameThread() { }
        private System.Single _GetMessageTimeLimit() { }
        private System.Void _ProcessReceivedMessagesInGameThread(System.Boolean flushAll) { }
        private Beyond.Network.HGNetSessionLoginYield LoginAsync(System.String uid, System.String token, System.Int32 channel) { }
        private System.Void _CSLoginHelper_UpdateAppInfo(Proto.MSG_A1 msg) { }
        private System.String _GetOnlineResVersion() { }
        private Proto.ENV_TYPE _GetSDKEnv() { }
        private Proto.CLIENT_PLATFORM_TYPE _GetPlatformID() { }
        private System.Int32 _GetPayPlatform() { }
        private System.Void _SessionLoginThreadTask(System.Object handle) { }
        private System.Void StartMsgLoop() { }
        private System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO) { }
        private System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO) { }
        private System.Boolean NeedKeepConnect() { }
        private System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& req) { }
        private System.Void _WriteMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& request, System.Boolean useSRSA) { }
        private System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp) { }
        private System.Boolean _ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp, System.Boolean useSRSA) { }
        private System.Void ClearRecvQueue() { }
        private System.Void ClearSendQueue() { }
        private System.Void SetBurstMode(System.Boolean val) { }
        private System.Void Finalize() { }
        private System.Int32 GetPing() { }
        private System.Void ClearPingWDG() { }
        private System.Void _ApproximateLoginServerTime(System.Int64 serverTimeMS, System.Int32 serverZone) { }
        private System.Boolean _HandleSpecialMessagePing(Beyond.Network.NetResponse m) { }
        private System.Boolean IsPingOut() { }
        private System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId) { }
        private System.Byte[] GetClientPublicKey() { }
        private System.Void InitClientRSAKey() { }
        private System.Byte[] _RSADecrypt(System.Byte[] data) { }
        private System.Void ClearRSAKey() { }
        private System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& msg) { }
        private System.Boolean _HandleSpecialMessageReconnectIncr(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m) { }
        private System.Boolean _HandleSpecialMessageReconnectFull(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m) { }
        private System.Boolean _HandleSpecialMessageErrorCode(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m) { }
        private System.Boolean _HandleSpecialMessageReconnectLogin(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m) { }
        private System.Void _HandleLoginEncryp(Beyond.Network.INetIO netIO, Proto.MSG_B1 msg) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <>iFixBaseProxy_Start() { }

    }

    // TypeToken: 0x2000050
    public struct EHGNetSessionState
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.Network.EHGNetSessionState Closed;        // 0x0
        public static Beyond.Network.EHGNetSessionState Opened;        // 0x0
        public static Beyond.Network.EHGNetSessionState Connecting;        // 0x0
        public static Beyond.Network.EHGNetSessionState SessionRunning;        // 0x0

    }

    // TypeToken: 0x2000051
    public struct EHGNetSessionReconnectState
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.Network.EHGNetSessionReconnectState None;        // 0x0
        public static Beyond.Network.EHGNetSessionReconnectState ReconnectingTcp;        // 0x0
        public static Beyond.Network.EHGNetSessionReconnectState SendLogin;        // 0x0
        public static Beyond.Network.EHGNetSessionReconnectState ResendPack;        // 0x0

    }

    // TypeToken: 0x2000052
    public struct ENetCloseReason
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Network.ENetCloseReason Invalid;        // 0x0
        public static Beyond.Network.ENetCloseReason None;        // 0x0
        public static Beyond.Network.ENetCloseReason ForServerErrorMax;        // 0x0
        public static Beyond.Network.ENetCloseReason ConnectFailed;        // 0x0
        public static Beyond.Network.ENetCloseReason ServerReconnectFailed;        // 0x0
        public static Beyond.Network.ENetCloseReason TooMuchClientReconnectPack;        // 0x0
        public static Beyond.Network.ENetCloseReason ServerReconnectFullPack;        // 0x0
        public static Beyond.Network.ENetCloseReason ClientShutDown;        // 0x0
        public static Beyond.Network.ENetCloseReason ClientLaunch;        // 0x0
        public static Beyond.Network.ENetCloseReason ClientReconnectTooMuchTimes;        // 0x0

    }

    // TypeToken: 0x2000053
    public class HGNetSessionUtils
    {
        // Methods
        private System.Boolean CheckErrorNeedsDisconnect(Proto.CODE errorCode) { }

    }

    // TypeToken: 0x2000054
    public class HGNetSessionConstant
    {
        // Fields
        public static System.Int32 CODE_SUC;        // 0x0
        public static System.Int32 CODE_CONN_FAILED;        // 0x0
        public static System.Int32 CODE_CONN_WAIT;        // 0x0

    }

    // TypeToken: 0x2000055
    public struct ENetConnectErrorCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Network.ENetConnectErrorCode Invalid;        // 0x0
        public static Beyond.Network.ENetConnectErrorCode None;        // 0x0
        public static Beyond.Network.ENetConnectErrorCode ForServerErrorMax;        // 0x0
        public static Beyond.Network.ENetConnectErrorCode ConnectError;        // 0x0
        public static Beyond.Network.ENetConnectErrorCode TimeOut;        // 0x0

    }

    // TypeToken: 0x2000056
    public class HGNetSessionLoginYield : CustomYieldInstruction
    {
        // Fields
        private Beyond.Network.HGNetSessionLoginYield.LoginErrorInfo m_loginErrorInfo;        // 0x10
        private System.Boolean m_bIsFinish;        // 0x18
        private Proto.MSG_A1 m_request;        // 0x20
        private Proto.MSG_B1 m_resp;        // 0x28
        private System.Object m_locker;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(Proto.MSG_A1 req) { }
        private Proto.MSG_A1 GetRequest() { }
        private Proto.MSG_B1 GetResponse() { }
        private System.Int32 GetErrorCode() { }
        private System.String GetErrorDetails() { }
        private System.Void SetSucceed(Proto.MSG_B1 sc) { }
        private System.Void SetNtfError(System.Int32 ntfErrorCode, System.String ntfErrorDetails) { }
        private System.Void SetConnectErrorError() { }
        private System.Void SetTimeOutError() { }
        private System.Boolean get_isSucceed() { }
        private System.Boolean get_keepWaiting() { }

    }

    // TypeToken: 0x2000058
    public class HGNetSessionConnectYield : CustomYieldInstruction
    {
        // Fields
        private System.Threading.Tasks.Task m_connectTask;        // 0x10
        private Beyond.Network.ENetConnectErrorCode connectErrorCode;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Threading.Tasks.Task connectTask) { }
        private System.Int32 GetCode() { }
        private System.Void SetFinish(Beyond.Network.ENetConnectErrorCode code) { }
        private System.Boolean get_isSucceed() { }
        private System.Boolean get_keepWaiting() { }

    }

}

namespace Beyond.Network.HGNetLogger
{

    // TypeToken: 0x2000059
    public class HGNetLogBaseSession
    {
        // Fields
        private readonly Beyond.Network.INetIO m_tcpIO;        // 0x10
        public static System.Int32 s_recvBuffLen;        // 0x0
        public static System.Int32 s_tcpSendTimeout;        // 0x4
        public static System.Int32 s_sessionThreadSleepTimeMS;        // 0x8
        public static System.Int32 s_sessionThreadPauseSleepTimeMS;        // 0xC
        public static System.Int32 s_maxReconnectTimeout;        // 0x10
        public static System.Int32 s_maxReconnectTimes;        // 0x14
        protected System.Int32 m_sendNumLimit;        // 0x18
        protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetResponse> m_recvQueue;        // 0x20
        private readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest> m_sendQueue;        // 0x28
        private static System.Int32 MAX_RECYCLE_QUEUE_COUNT;        // 0x0
        protected Beyond.Network.CircularBuffer<Beyond.Network.NetRequest> m_circularBuffer;        // 0x30
        private System.Int64 m_csSeqId;        // 0x38
        protected System.Int64 m_scSeqId;        // 0x40
        protected System.Threading.Tasks.Task m_threadTask;        // 0x48
        protected System.Int32 m_threadTaskSignal;        // 0x50
        protected Beyond.ELogChannel m_logChannel;        // 0x54
        private System.String m_lastConnectServerIp;        // 0x58
        private System.Int32 m_lastConnectServerPort;        // 0x60
        protected System.Int32 m_tryReconnectTimes;        // 0x64
        protected System.Int64 m_startReconnectTimestampMS;        // 0x68
        protected System.Boolean m_isAutoReconnect;        // 0x70
        protected Beyond.Network.HGNetSessionConnectYield m_lastAsyncConnectHandle;        // 0x78
        protected Beyond.Network.EHGNetSessionState m_state;        // 0x80
        protected Beyond.Network.EHGNetSessionReconnectState m_reconnectState;        // 0x81
        protected System.Int32 m_closeErrorCode;        // 0x84
        public static System.Boolean s_applicationIsPaused;        // 0x18
        private System.Int64 m_clientLastReceiveMsgMilliTs;        // 0x88
        private System.Int64 m_clientLastSendMsgMilliTs;        // 0x90

        // Methods
        private System.Boolean get_isRunning() { }
        private System.Boolean get_isConnecting() { }
        private System.Boolean get_isRunningAndConnected() { }
        private System.Int32 get_closeErrorCode() { }
        private System.Boolean get_isAutoReconnect() { }
        private System.Void Start() { }
        private System.Boolean Connect(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect) { }
        private System.Boolean ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect, Beyond.Network.HGNetSessionConnectYield& yieldHandle) { }
        private System.Void OnConnectAsyncEnd(System.Threading.Tasks.Task continuationAction) { }
        private System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO) { }
        private System.Void _DNSCheck(System.String serverIp) { }
        private System.Void Close(Beyond.Network.ENetCloseReason netCloseReason) { }
        private System.Void Close(System.Int32 netCloseReason) { }
        private System.Void EnqueueSendMsg(Beyond.Network.NetRequest msg) { }
        private System.Int32 GetSendQueueMsgCount() { }
        private System.Int64 IncrementCSSeqID() { }
        private System.Void SetCSSeqID(System.Int64 id) { }
        private System.Int64 GetCSSeqID() { }
        private Beyond.Network.INetIO GetIO() { }
        private System.Void StartTCPMsgLoopThreadTask() { }
        private System.Void CloseTCPMsgThreadTask() { }
        private System.Void _SessionThread() { }
        private System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp) { }
        private System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& m) { }
        private System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m) { }
        private System.Void SessionCheckSignalAndSleep() { }
        private System.Void OpenAutoReconnect() { }
        private System.Void RemoveAutoReconnect() { }
        private System.Void _ReconnectCheckerTick() { }
        private System.Void OnReconnectTimesOver() { }
        private System.Boolean NeedKeepConnect() { }
        private System.Void DoReconnectLogin(Beyond.Network.INetIO netIO) { }
        private System.Void InitClientRSAKey() { }
        private System.Void ClearRSAKey() { }
        private System.Void NetStatusChecker_Receive(Beyond.Network.INetIO netIO, System.Int64 scSeqId, System.Int32 receiveCount) { }
        private System.Void NetStatusChecker_Sender(Beyond.Network.INetIO netIO, System.Int64 csSeqId, System.Int32 sendCount) { }
        private System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs) { }
        private System.Void ClearPingWDG() { }
        private System.Boolean IsPingOut() { }
        private System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005A
    public class HGNetLogger, ILogger
    {
        // Fields
        private Beyond.Log.BitArray256 m_enabledLogChannel;        // 0x10
        private System.Collections.Concurrent.ConcurrentQueue<Beyond.Log.FLogMessage> m_logMessagesQueue;        // 0x30
        public static System.Int32 s_maxLogQueueSize;        // 0x0
        public static System.Int32 s_maxRepeatedMsgMs;        // 0x4
        public static System.Int32 s_maxRepeatedMsgCount;        // 0x8

        // Methods
        private System.Void Log(Beyond.Log.FLogMessage& msg) { }
        private Beyond.Network.HGNetLogger.LogLevel ConvertFromDLogger(Beyond.ELogLevel level) { }
        private Beyond.Network.HGNetLogger.NativeLogLevel ConvertFromDLoggerV2(Beyond.ELogLevel level) { }
        private System.Boolean CheckLog(Beyond.Log.FLogMessage& msg) { }
        private System.Void Clear() { }
        private System.Void SetLogChannel(System.UInt64 channel1, System.UInt64 channel2, System.UInt64 channel3, System.UInt64 channel4) { }
        private System.Int32 ConvertFromDLogger(Beyond.ELogChannel channel) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005B
    public class HGNetLoggerClient
    {
        // Fields
        private static Beyond.Network.HGNetLogger.HGNetLoggerClient s_instance;        // 0x0
        private static System.Int64 <s_roleID>k__BackingField;        // 0x8
        public Beyond.Network.HGNetLogger.HGNetLoggerSession m_logsession;        // 0x10
        private Beyond.Network.HGNetLogger.HGNetLogger m_netLogger;        // 0x18
        public static readonly System.Int32 MAX_LOG_SEND_QUEUE_SIZE;        // 0x10
        private static System.Int32 MAX_LOCAL_LOG_QUEUE_SIZE;        // 0x0
        private readonly System.Collections.Generic.Queue<Beyond.Log.FLogMessage> m_localLogQueue;        // 0x20
        private readonly System.Object m_queueLock;        // 0x28
        public static Beyond.Network.HGNetLogger.Version s_usedVersion;        // 0x14

        // Methods
        private System.Void .ctor() { }
        private Beyond.Network.HGNetLogger.HGNetLoggerClient get_instance() { }
        private System.Int64 get_s_roleID() { }
        private System.Void set_s_roleID(System.Int64 value) { }
        private System.Void Init(System.String uid, System.String token, System.String env, System.String roleId) { }
        private System.Void AddLog(System.String message, System.String stacktrace, UnityEngine.LogType type) { }
        private System.Void _FlushLocalLogQueue() { }
        private System.Void OnApplicationPause(System.Boolean pauseStatus) { }
        private System.Void ShutDown() { }
        private System.Void _CloseAndClear(Beyond.Network.ENetCloseReason reason) { }
        private System.Void WriteNetLog(Beyond.Network.HGNetLogger.LogMessage& log) { }
        private System.Void SetRoleID(System.UInt64 roleID) { }
        private System.Void SetNetLogMaskFromServer(Google.Protobuf.Collections.RepeatedField<System.UInt64> masks) { }
        private System.Void .cctor() { }
        private System.Void <Init>b__15_0() { }

    }

    // TypeToken: 0x200005C
    public class HGNetLoggerCloudSettings
    {
        // Fields
        public static readonly Beyond.Network.HGNetLogger.HGNetLoggerCloudSettings instance;        // 0x0
        private Beyond.Network.HGNetLogger.LogControl m_cloudLogControl;        // 0x10
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_cloudChannelLevelMaskTables;        // 0x18
        private Beyond.Network.HGNetLogger.LogControl m_localLogControl;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_localChannelLevelMaskTables;        // 0x28
        private static System.Collections.Generic.List<Beyond.Network.HGNetLogger.NativeLogLevel> s_allLevels;        // 0x8

        // Methods
        private System.Void SetCloudLogControl(Beyond.Network.HGNetLogger.AuthResponse control, Beyond.Network.HGNetBaseSession session) { }
        private System.Boolean IsNetLogLevelEnabled(Beyond.ELogLevel elevel, Beyond.ELogChannel channel) { }
        private System.Boolean IsNetLogLevelEnabled(Beyond.Network.HGNetLogger.NativeLogLevel level, System.Int32 channel) { }
        private System.Boolean IsLocalLogLevelEnabled(Beyond.ELogLevel elevel, Beyond.ELogChannel channel) { }
        private Beyond.Network.HGNetLogger.NativeLogLevel ConvertFromDLogger(Beyond.ELogLevel level) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005D
    public class HGNetLoggerSession : HGNetBaseSession
    {
        // Fields
        private System.Byte[] m_keyBytes;        // 0xC0
        private System.Collections.Generic.Dictionary<System.String,System.Int32> m_templeCRCDict;        // 0xC8
        private System.Action m_onReconnectSuccess;        // 0xD0
        private System.String m_uid;        // 0xD8
        private System.String m_roleId;        // 0xE0
        private System.String m_token;        // 0xE8
        private System.String m_env;        // 0xF0
        private static System.Collections.Generic.Dictionary<System.Type,Beyond.Network.HGNetLogger.MessageType> s_m_messageType2Id;        // 0x0
        private static System.Collections.Generic.Dictionary<Beyond.Network.HGNetLogger.MessageType,System.Type> s_m_messageId2Type;        // 0x8

        // Methods
        private System.String get_uid() { }
        private System.String get_roleId() { }
        private System.Collections.Generic.Dictionary<System.Type,Beyond.Network.HGNetLogger.MessageType> get_s_messageType2Id() { }
        private System.Collections.Generic.Dictionary<Beyond.Network.HGNetLogger.MessageType,System.Type> get_s_messageId2Type() { }
        private System.Boolean TryGetMsgTypeByID(System.Type msgType, Beyond.Network.HGNetLogger.MessageType& type) { }
        private System.Void Start() { }
        private System.Void SetReconnectSuccessCallback(System.Action onReconnectSuccess) { }
        private System.Void OnApplicationPause(System.Boolean pause) { }
        private System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO) { }
        private System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp) { }
        private System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp) { }
        private System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m) { }
        private System.Void _WriteMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest request) { }
        private System.UInt64 SendMessage(Google.Protobuf.IMessage msg) { }
        private System.Void SetAutoReconnectToken(System.String uid, System.String token, System.String env, System.String roleId) { }
        private System.Boolean NeedKeepConnect() { }
        private System.Void DoReconnectLogin(Beyond.Network.INetIO netIO) { }
        private System.Int32 _GetConnectTimeoutTime() { }
        private System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs) { }
        private System.Void ClearPingWDG() { }
        private System.Void SendLogin(Beyond.Network.INetIO netIO) { }
        private System.Boolean IsPingOut() { }
        private System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId) { }
        private System.Void InitClientRSAKey() { }
        private System.Void ClearRSAKey() { }
        private System.Void ClearRecvQueue() { }
        private System.Void ClearSendQueue() { }
        private System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Start() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000003
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000002
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x200005E
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Void __Gen_Wrap_0(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_1(System.Object P0, System.Object P1, System.Int32 P2) { }
        private System.IAsyncResult __Gen_Wrap_2(System.Object P0, System.Object P1, System.Int32 P2, System.Object P3, System.Object P4) { }
        private System.Threading.Tasks.Task __Gen_Wrap_3(System.Object P0, System.Object P1, System.Int32 P2) { }
        private System.Net.Sockets.NetworkStream __Gen_Wrap_4(System.Object P0) { }
        private System.Void __Gen_Wrap_5(System.Object P0) { }
        private System.Void __Gen_Wrap_6(System.Object P0, System.Boolean P1) { }
        private System.Net.Sockets.LingerOption __Gen_Wrap_7(System.Object P0) { }
        private System.Int32 __Gen_Wrap_8(System.Object P0, System.Net.Sockets.SocketOptionLevel P1, System.Net.Sockets.SocketOptionName P2) { }
        private System.Int32 __Gen_Wrap_9(System.Object P0) { }
        private System.Boolean __Gen_Wrap_10(System.Object P0) { }
        private System.Int64 __Gen_Wrap_11(System.Object P0) { }
        private System.UInt64 __Gen_Wrap_12(System.Object P0, System.Object P1) { }
        private System.Type __Gen_Wrap_13(System.Int32 P0) { }
        private System.Void __Gen_Wrap_14(System.Object P0, System.Int32 P1, System.Object P2) { }
        private System.Void __Gen_Wrap_15(System.Object P0, System.Int32 P1) { }
        private Beyond.Network.NetBus.ResultHandler __Gen_Wrap_16(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_17(System.Object P0, Beyond.Network.NetResponse& P1) { }
        private Beyond.Network.NetBus.ResultHandler __Gen_Wrap_18(System.Object P0, Proto.SCMessageID P1, System.Object P2) { }
        private System.Void __Gen_Wrap_19(System.Object P0, Proto.SCMessageID P1, System.Object P2) { }
        private System.Int32 __Gen_Wrap_20(System.Object P0, System.Object P1, System.Single P2, System.Single P3) { }
        private System.Int32 __Gen_Wrap_21(System.Object P0, Proto.CSMessageID P1, System.Single P2) { }
        private System.Void __Gen_Wrap_22(Beyond.Network.NetResponse& P0) { }
        private Beyond.Network.NetBus.ResultHandler __Gen_Wrap_23(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3, System.Object P4) { }
        private System.Boolean __Gen_Wrap_24(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_25(System.Int32 P0, System.Object P1) { }
        private System.Void __Gen_Wrap_26() { }
        private System.Boolean __Gen_Wrap_27(System.Span<System.Byte> P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Object P4, Beyond.Network.NetResponse& P5) { }
        private System.Int32 __Gen_Wrap_28(System.Object P0, System.UInt64 P1, System.Int32 P2, System.Int32 P3, System.Object P4, System.Int32 P5) { }
        private System.Void __Gen_Wrap_29(System.Type P0, System.Reflection.MethodInfo P1) { }
        private System.Void __Gen_Wrap_30(System.Object P0, System.Single P1) { }
        private System.String __Gen_Wrap_31() { }
        private System.String __Gen_Wrap_32(System.Object P0) { }
        private System.String __Gen_Wrap_33(Beyond.Network.NetworkUrls.EUrlType P0) { }
        private System.String __Gen_Wrap_34(System.Object P0, Beyond.Network.NetworkUrls.EUrlType P1) { }
        private System.Void __Gen_Wrap_35(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Int32 P5) { }
        private System.Threading.Tasks.Task __Gen_Wrap_36(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Int32 P5) { }
        private System.Void __Gen_Wrap_37(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Net.EndPoint __Gen_Wrap_38(System.Object P0) { }
        private System.Void __Gen_Wrap_39(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_40(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3) { }
        private System.Byte[] __Gen_Wrap_41(System.Object P0) { }
        private System.Int32 __Gen_Wrap_42(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3) { }
        private Beyond.Network.HttpSender.Cancellation __Gen_Wrap_43(Beyond.Network.HttpSender.FSendFunc& P0) { }
        private UnityEngine.Networking.UnityWebRequest __Gen_Wrap_44(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1) { }
        private UnityEngine.Networking.UnityWebRequest __Gen_Wrap_45(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1) { }
        private UnityEngine.Networking.UnityWebRequest __Gen_Wrap_46(Beyond.Network.HttpSender.FSendFunc& P0) { }
        private System.Collections.IEnumerator __Gen_Wrap_47(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1) { }
        private System.Collections.IEnumerator __Gen_Wrap_48(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1, System.Object P2) { }
        private System.Collections.IEnumerator __Gen_Wrap_49(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1, System.Object P2, System.Object P3) { }
        private System.Collections.IEnumerator __Gen_Wrap_50(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1, System.Object P2) { }
        private System.Collections.IEnumerator __Gen_Wrap_51(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1, System.Object P2, System.Object P3) { }
        private System.Collections.IEnumerator __Gen_Wrap_52(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1, System.Object P2) { }
        private System.Void __Gen_Wrap_53(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1) { }
        private Beyond.Network.HttpSender.Result __Gen_Wrap_54() { }
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_55(Beyond.Network.HttpSender.FSendFunc P0) { }
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_56(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1) { }
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_57(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1) { }
        private Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_58(System.Object P0) { }
        private System.Int32 __Gen_Wrap_59(System.Object P0, System.Boolean& P1) { }
        private System.String __Gen_Wrap_60(Beyond.Network.HttpSender.FSendFunc& P0) { }
        private System.Void __Gen_Wrap_61(System.Object P0, Beyond.Network.EHGNetSessionReconnectState P1) { }
        private System.Void __Gen_Wrap_62(System.Object P0, System.Object P1, Beyond.Network.ENetCloseReason P2) { }
        private System.Boolean __Gen_Wrap_63(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_64(System.Object P0, Beyond.Network.ENetConnectErrorCode P1) { }
        private System.Void __Gen_Wrap_65(System.Object P0, Beyond.Network.ENetCloseReason P1) { }
        private System.Void __Gen_Wrap_66(System.Threading.Tasks.Task<System.Threading.Tasks.Task> P0) { }
        private System.Boolean __Gen_Wrap_67(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3, Beyond.Network.HGNetSessionConnectYield& P4) { }
        private System.Void __Gen_Wrap_68(System.Object P0, Beyond.Network.NetRequest P1) { }
        private System.Void __Gen_Wrap_69(System.Object P0, System.Int64 P1) { }
        private Beyond.Network.INetIO __Gen_Wrap_70(System.Object P0) { }
        private System.Threading.Tasks.Task<System.Boolean> __Gen_Wrap_71(System.Object P0, System.Object P1, System.Int32 P2) { }
        private System.Threading.Tasks.Task<System.Boolean> __Gen_Wrap_72(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3, System.Int32 P4, System.Int32 P5, System.Int32 P6) { }
        private System.Threading.Tasks.Task __Gen_Wrap_73(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_74(System.Object P0, System.Object P1, System.Int64 P2, System.Int32 P3) { }
        private System.Boolean __Gen_Wrap_75(System.Object P0, System.Object P1, System.Int32 P2) { }
        private System.Threading.Tasks.Task __Gen_Wrap_76() { }
        private System.Void __Gen_Wrap_77(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3) { }
        private System.Void __Gen_Wrap_78(System.Object P0, System.Object P1, System.Int64 P2, System.Int64 P3) { }
        private System.Byte[] __Gen_Wrap_79() { }
        private Proto.CLIENT_PLATFORM_TYPE __Gen_Wrap_80() { }
        private Proto.ENV_TYPE __Gen_Wrap_81() { }
        private System.Int32 __Gen_Wrap_82() { }
        private System.Void __Gen_Wrap_83(System.Object P0, System.Object P1, Beyond.Network.NetRequest& P2, System.Boolean P3) { }
        private System.Boolean __Gen_Wrap_84(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_85(System.Object P0, System.Int64 P1, System.Int32 P2) { }
        private System.Byte[] __Gen_Wrap_86(System.Object P0, System.Object P1) { }
        private Proto.MSG_A1 __Gen_Wrap_87(System.Object P0) { }
        private Beyond.Network.HGNetSessionLoginYield __Gen_Wrap_88(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3) { }
        private System.Void __Gen_Wrap_89(System.Object P0, System.Object P1, Beyond.Network.NetRequest& P2) { }
        private System.Boolean __Gen_Wrap_90(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2) { }
        private System.Boolean __Gen_Wrap_91(System.Object P0, Beyond.Network.NetResponse P1) { }
        private System.Void __Gen_Wrap_92(System.Object P0, System.Object P1, System.Int64 P2) { }
        private System.Boolean __Gen_Wrap_93(Proto.CODE P0) { }
        private System.Boolean __Gen_Wrap_94(System.Object P0, System.Object P1, Beyond.Network.NetResponse P2) { }
        private System.Void __Gen_Wrap_95(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2) { }
        private Proto.MSG_B1 __Gen_Wrap_96(System.Object P0) { }
        private System.Boolean __Gen_Wrap_97(System.Object P0, Beyond.Log.FLogMessage& P1) { }
        private Beyond.Network.HGNetLogger.LogLevel __Gen_Wrap_98(Beyond.ELogLevel P0) { }
        private Beyond.Network.HGNetLogger.NativeLogLevel __Gen_Wrap_99(Beyond.ELogLevel P0) { }
        private System.Int32 __Gen_Wrap_100(Beyond.ELogChannel P0) { }
        private System.Boolean __Gen_Wrap_101(Beyond.Network.HGNetLogger.NativeLogLevel P0, System.Int32 P1) { }
        private System.Boolean __Gen_Wrap_102(Beyond.ELogLevel P0, Beyond.ELogChannel P1) { }
        private System.Void __Gen_Wrap_103(System.Object P0, System.Object P1, System.Object P2, UnityEngine.LogType P3) { }
        private Beyond.Network.HGNetLogger.HGNetLoggerClient __Gen_Wrap_104() { }
        private System.Void __Gen_Wrap_105(System.Object P0, Beyond.Network.HGNetLogger.LogMessage& P1) { }
        private System.Void __Gen_Wrap_106(System.Object P0, Beyond.Log.FLogMessage& P1) { }
        private System.Void __Gen_Wrap_107(System.Object P0, System.UInt64 P1, System.UInt64 P2, System.UInt64 P3, System.UInt64 P4) { }
        private System.Void __Gen_Wrap_108(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4) { }
        private System.Void __Gen_Wrap_109(System.Boolean P0) { }
        private System.Void __Gen_Wrap_110(System.UInt64 P0) { }
        private System.Collections.Generic.Dictionary<System.Type,Beyond.Network.HGNetLogger.MessageType> __Gen_Wrap_111() { }
        private System.Collections.Generic.Dictionary<Beyond.Network.HGNetLogger.MessageType,System.Type> __Gen_Wrap_112() { }
        private System.Boolean __Gen_Wrap_113(System.Object P0, Beyond.Network.HGNetLogger.MessageType& P1) { }
        private System.Void __Gen_Wrap_114(System.Object P0, System.Object P1, Beyond.Network.NetRequest P2) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005F
    public class ILFixInterfaceBridge : AnonymousStorey, IDisposable, IEnumerator, IEnumerator`1, IAsyncStateMachine
    {
        // Fields
        private System.Int32 methodId_0;        // 0x40
        private System.Int32 methodId_1;        // 0x44
        private System.Int32 methodId_2;        // 0x48
        private System.Int32 methodId_3;        // 0x4C
        private System.Int32 methodId_4;        // 0x50
        private System.Int32 methodId_5;        // 0x54
        private System.Int32 methodId_6;        // 0x58

        // Methods
        private System.Void System.IDisposable.Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void MoveNext() { }
        private System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine P0) { }
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAwaitUnsafeOnCompleteMethod() { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000060
    public class WrappersManagerImpl, WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }
        private System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        private System.Object CreateWrapper(System.Int32 id) { }
        private System.Object InitWrapperArray(System.Int32 len) { }
        private IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000061
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Connect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Connect1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Connect2;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Connect3;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-BeginConnect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-BeginConnect1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-BeginConnect2;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-EndConnect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-ConnectAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-ConnectAsync1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-ConnectAsync2;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-GetStream0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Close0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-Dispose1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-get_LingerState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-_Initialize0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGTcpClient-_NumericOption0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-get_currentSessionID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-Setup0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-_ValidateSession0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-IncrementCSSeqID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-SendMessage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-Send0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetUtil-GetSCMsgTypeById0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-RegisterMessageHandler0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-UnRegisterMessageHandler0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-OnNetClientShutDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-_SendWithResult0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-_Listen0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-_UnListen0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-_UnListenWithSeqNum0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-ResultHandler-SetIgnoreSeq0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-ResultHandler-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-ResultHandler-_HandleMessage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-ResultHandler-OnResponse0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-Sender-DoSend0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-Sender-DoListen0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetBus-Sender-DoUnListen0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-Special2BusSender-Send0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-DisposableBusSender-_Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-DisposableBusSender-OnNetShutDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-Special2BusSender-_ClearSendTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-Special2BusSender-OnNetShutDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-DisposableBusSender-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-Special2BusSender-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-DisposableBusSender-Send0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMaskConfigHolder-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMaskConfigHolder-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-_UpdateMaskState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-RemoveMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-UIBusSender-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetUtil-GetCSMsgIdByType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-_GetKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-AddMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-AddMask1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-UIBusSender-Send0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-UIBusSender-OnNetShutDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-FrequencyControlBusSender-Send0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-FrequencyControlBusSender-_TrySendWaitingMsg0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-FrequencyControlBusSender-Send1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-FrequencyControlBusSender-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-ServerConfig-IsSame0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetUtil-RegisterSCMessage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetUtil-RegisterCSMessage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetUtil-GetSCMsgIdByType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetUtil-FastRegisterMessage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetUtil-GetNetMessageFromDataBytes0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetUtil-SerializeHeadMessage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetUtil-AutoRegisterMessageHandlers0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetUtil-_ForeachMessageHandlers0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetUtil-AutoUnRegisterMessageHandlers0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-PreTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-_CreateTickFunction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-_OnSwitchLanguage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-_ClearTickFunction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-OnUnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-Release0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-ListenOnNetMaskChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkMask-UnListenOnNetMaskChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-RemoteConfigUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-ResourceRootUrlDev0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-_GetUrlFromLocal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-ServerListUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-_SelectUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-AgeTipsUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-GovUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-NetworkUrls-LauncherUrl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-IsConnected0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-Close0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-Connect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-ConnectAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-IsAuthed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-MarkAuthed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-EnableCryptStream0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-GetEndPoint0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-TestCloseNetIO0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-TestDropNetIO0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-WriteData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-WriteCryptoData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-GetSendHeadBuffer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-GetSendBuffer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-GetReceiveBuffer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-ClearReceiveBufferOffset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-GetReceiveBufferOffset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-SkipReceiveBufferOffset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-ReadData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-ReadCryptoData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-Available0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-TcpIO-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-FSendFunc-GetCancellation0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_CreateWebRequestGET0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_CreateWebRequestPOST0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-FSendFunc-Invoke0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-Cancellation-IsCanceled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_SetHttpResult0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_MarkResultAsException0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_YieldSendHttpRequest0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_DeserializeTypedResult0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_YieldSendHttpRequest1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-YieldSendGet0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-YieldSendGet1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-YieldSendPost0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-YieldSendPost1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_WaitForServiceDone0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_StartWebRequestTask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_WaitForSendHttpRequest0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-WaitForSendPost0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-WaitForSendGet0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-WaitForSendGet1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-GetGeneralErrorCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-_DebugOnlyProfileResult0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-Cancellation-Cancel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HttpSender-FSendFunc-GetOptMethod0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-set_reconnectState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-_DNSCheck0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-RemoveAutoReconnect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-CloseTCPMsgThreadTask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-InternalClose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-InternalClose1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-Connect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionConnectYield-SetFinish0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-Close0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-OnConnectAsyncEnd0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-ConnectAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-EnqueueSendMsg0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-GetSendQueueMsgCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-SetCSSeqID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-GetCSSeqID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-GetIO0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-TryCloseTcpIOWithTimeout0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-TryConnectWithTimeout0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-_ReconnectCheckerTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-SessionCheckSignalAndSleep0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-NetStatusChecker_Receive0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-_ReadAndCheckMessageInSessionThread0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-NetStatusChecker_Sender0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-_SendAndCheckMessage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-_SessionThread0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-StartTCPMsgLoopThreadTask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetBaseSession-OpenAutoReconnect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-SetAutoReconnectToken0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-SessionConnectTimeoutCheckerTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-GetClientPublicKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_GetOnlineResVersion0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_GetPlatformID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_GetSDKEnv0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_GetPayPlatform0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_CSLoginHelper_UpdateAppInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_WriteMessageInSessionThread0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_ReadMessageInSessionThread0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_ApproximateLoginServerTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_RSADecrypt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleLoginEncryp0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-DoReconnectLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-OnApplicationPause0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-GetRequest0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-SetSucceed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Set0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-SetNtfError0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectError0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-SetConnectErrorError0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectTimeOut0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-SetTimeOutError0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_SessionLoginThreadTask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-LoginAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-StartMsgLoop0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-OnConnectedSucceed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-OnReconnectTimesOver0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-NeedKeepConnect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-CheckAndWriteReqMsg0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-ReadMessageInSessionThread0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-ClearRecvQueue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-ClearSendQueue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-GetPing0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-ClearPingWDG0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleSpecialMessagePing0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-IsPingOut0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-PingSenderTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-InitClientRSAKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-ClearRSAKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionUtils-CheckErrorNeedsDisconnect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleSpecialMessageErrorCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectIncr0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectFull0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-CheckAndDealRespMessages0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-GetResponse0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-GetErrorCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-GetErrorDetails0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorInvaild0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionConnectYield-GetCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetSessionConnectYield-get_keepWaiting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DNSCheck0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-RemoveAutoReconnect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-CloseTCPMsgThreadTask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-Connect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-OnConnectAsyncEnd0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-ConnectAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-EnqueueSendMsg0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetSendQueueMsgCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-IncrementCSSeqID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-SetCSSeqID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetCSSeqID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetIO0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-_ReconnectCheckerTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-SessionCheckSignalAndSleep0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Receive0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Sender0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-_SessionThread0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-StartTCPMsgLoopThreadTask0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogBaseSession-OpenAutoReconnect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-CheckLog0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLoggerV20;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-ConvertFromDLogger0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled1;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-_FlushLocalLogQueue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-AddLog0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-_CloseAndClear0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-ShutDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-get_instance0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-SendMessage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-WriteNetLog0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-Log0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLogger-SetLogChannel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-SetAutoReconnectToken0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-SetReconnectSuccessCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-OnApplicationPause0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-OnApplicationPause0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-SetRoleID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerClient-SetNetLogMaskFromServer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-SetCloudLogControl0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsLocalLogLevelEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageType2Id0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageId2Type0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-TryGetMsgTypeByID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-_WriteMessageInSessionThread0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-SendLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-OnConnectedSucceed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-ReadMessageInSessionThread0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndDealRespMessages0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndWriteReqMsg0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-NeedKeepConnect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-DoReconnectLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-_GetConnectTimeoutTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-SessionConnectTimeoutCheckerTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearPingWDG0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-IsPingOut0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-PingSenderTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-InitClientRSAKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRSAKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRecvQueue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearSendQueue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Network-HGNetLogger-HGNetLoggerSession-OnReconnectTimesOver0;        // 0x0

    }

}

