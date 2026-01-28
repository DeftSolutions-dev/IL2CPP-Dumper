// ========================================================
// Dumped by @desirepro
// Assembly: Network.Beyond.dll
// Classes:  97
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: HandlerEntry
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  public            Beyond.Network.NetResponseHandlerhandler  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ResultHandler
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  private           System.Boolean                  m_ignoreSeq  // 0x10
  private           Beyond.ListDict<Proto.SCMessageID,System.Object>m_responseTokens  // 0x18
  private           Beyond.ListDict<Proto.SCMessageID,Beyond.Network.NetResponseHandler>m_responseHandlers  // 0x20
  private           System.Boolean                  <isDisposed>k__BackingField  // 0x28
  private           System.UInt64                   <cachedSeqNum>k__BackingField  // 0x30
  private           System.Int32                    <sessionID>k__BackingField  // 0x38
METHODS:
  System.Boolean get_isDisposed()
  System.Void set_isDisposed(System.Boolean value)
  System.UInt64 get_cachedSeqNum()
  System.Void set_cachedSeqNum(System.UInt64 value)
  System.Int32 get_sessionID()
  System.Void set_sessionID(System.Int32 value)
  System.Void SetIgnoreSeq(System.Boolean ignoreSeq)
  Beyond.Network.NetBus.ResultHandler OnResponse(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler)
  System.Void Dispose()
  System.Void _HandleMessage(Beyond.Network.NetResponse& msg)
  System.Void .ctor()
END_CLASS

CLASS: Sender
TYPE:  class
TOKEN: 0x2000015
FIELDS:
METHODS:
  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg)
  System.Void OnNetShutDown()
  Beyond.Network.NetBus.ResultHandler DoSend(Google.Protobuf.IMessage message)
  System.Void DoListen(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler)
  System.Void DoUnListen(Proto.SCMessageID msgId, Beyond.Network.NetResponseHandler handler)
  System.Void .ctor()
END_CLASS

CLASS: NetworkFrequency
TYPE:  class
TOKEN: 0x2000029
FIELDS:
  public            System.Type                     type  // 0x10
  public            System.Single                   second  // 0x18
  public            System.Int32                    maxCount  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MaskInfo
TYPE:  class
TOKEN: 0x200002B
FIELDS:
  public            System.Int32                    key  // 0x10
  public            System.String                   name  // 0x18
  public            System.Single                   startTime  // 0x20
  public            System.Single                   delayTime  // 0x24
  public            System.Single                   timeoutTime  // 0x28
METHODS:
  System.Single get_endTime()
  System.Single get_showDecoTime()
  System.Void .ctor()
END_CLASS

CLASS: Config
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  public            System.String                   key  // 0x10
  public            Beyond.SerializeFieldDictionaryPaired<Proto.CSMessageID,Proto.SCMessageID>messages  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: EUrlType
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.NetworkUrls.EUrlTypeServerList  // 0x0
  public    static  Beyond.Network.NetworkUrls.EUrlTypeGameLicense  // 0x0
  public    static  Beyond.Network.NetworkUrls.EUrlTypeAgeTips  // 0x0
  public    static  Beyond.Network.NetworkUrls.EUrlTypeGateBulletin  // 0x0
  public    static  Beyond.Network.NetworkUrls.EUrlTypeGameBulletin  // 0x0
  public    static  Beyond.Network.NetworkUrls.EUrlTypeLauncher  // 0x0
  public    static  Beyond.Network.NetworkUrls.EUrlTypeGov  // 0x0
METHODS:
END_CLASS

CLASS: ErrorType
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.HttpSender.ErrorTypeNONE  // 0x0
  public    static  Beyond.Network.HttpSender.ErrorTypeTIMEOUT  // 0x0
  public    static  Beyond.Network.HttpSender.ErrorTypeDNS_FAILED  // 0x0
  public    static  Beyond.Network.HttpSender.ErrorTypeCANCELED  // 0x0
  public    static  Beyond.Network.HttpSender.ErrorTypeINTERNAL  // 0x0
METHODS:
END_CLASS

CLASS: Cancellation
TYPE:  class
TOKEN: 0x2000033
FIELDS:
  private           System.Boolean                  m_isCancelled  // 0x10
  private           System.Action                   OnCancelInvoked  // 0x18
METHODS:
  System.Void add_OnCancelInvoked(System.Action value)
  System.Void remove_OnCancelInvoked(System.Action value)
  System.Void Cancel()
  System.Boolean IsCanceled()
  System.Void .ctor()
END_CLASS

CLASS: FGetOptions
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public    static readonly Beyond.Network.HttpSender.FGetOptionsDEFAULT  // 0x0
  public            System.Collections.Generic.Dictionary<System.String,System.String>headers  // 0x10
  public            System.String                   contentType  // 0x18
  public            System.Boolean                  headOnly  // 0x20
  public            Beyond.Network.HttpSender.Cancellationcancellation  // 0x28
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: FPostOptions
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public    static readonly Beyond.Network.HttpSender.FPostOptionsDEFAULT  // 0x0
  public            System.Collections.Generic.Dictionary<System.String,System.String>headers  // 0x10
  public            System.String                   textBody  // 0x18
  public            System.String                   contentType  // 0x20
  public            Beyond.Network.HttpSender.Cancellationcancellation  // 0x28
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: FSendFunc
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.String                   url  // 0x10
  public            System.Int32                    opt  // 0x18
  public            Beyond.Network.HttpSender.FGetOptionsoptionsGET  // 0x20
  public            Beyond.Network.HttpSender.FPostOptionsoptionsPOST  // 0x40
  public            System.Boolean                  editorOnly  // 0x60
METHODS:
  UnityEngine.Networking.UnityWebRequest Invoke()
  Beyond.Network.HttpSender.Cancellation GetCancellation()
  System.String GetOptMethod()
END_CLASS

CLASS: Result
TYPE:  class
TOKEN: 0x2000037
FIELDS:
  public            System.Int32                    respCode  // 0x10
  public            Beyond.Network.HttpSender.ErrorTypeerrorType  // 0x14
  public            System.Boolean                  isError  // 0x18
  public            System.Exception                exception  // 0x20
  public            System.String                   respText  // 0x28
  public            System.Byte[]                   respData  // 0x30
  public            System.String                   respError  // 0x38
  public            System.Boolean                  isServiceDone  // 0x40
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TypedResult
TYPE:  class
TOKEN: 0x2000038
EXTENDS: Result
FIELDS:
  private           System.Type                     <respType>k__BackingField  // 0x48
  public            System.Object                   respObject  // 0x50
  public            System.Boolean                  isDeserializeFailed  // 0x58
METHODS:
  System.Type get_respType()
  System.Void set_respType(System.Type value)
  System.Void .ctor(System.Type respType)
END_CLASS

CLASS: Result`1
TYPE:  class
TOKEN: 0x2000039
EXTENDS: TypedResult
FIELDS:
METHODS:
  System.Void .ctor()
  TResp GetRespObject()
END_CLASS

CLASS: LoginErrorInfo
TYPE:  class
TOKEN: 0x2000057
FIELDS:
  private           System.Int32                    <code>k__BackingField  // 0x10
  private           System.String                   <details>k__BackingField  // 0x18
METHODS:
  System.Int32 get_code()
  System.Void set_code(System.Int32 value)
  System.String get_details()
  System.Void set_details(System.String value)
  System.Void SetErrorInvaild()
  System.Void SetErrorConnectError()
  System.Void SetErrorConnectTimeOut()
  System.Void Clear()
  System.Void Set(System.Int32 code, System.String details)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.DoubleQueue`1
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private           System.Collections.Generic.Queue<T>m_readQueue  // 0x0
  private           System.Collections.Generic.Queue<T>m_writeQueue  // 0x0
METHODS:
  System.Void LockingSwap()
  System.Void TryLockingSwap()
  System.Void Enqueue(T item)
  System.Boolean TryDequeue(T& item)
  System.Void EnqueueRange(System.Collections.Generic.List<T> list)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.HGTcpClient
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private           System.Net.Sockets.Socket       m_ClientSocket  // 0x10
  private           System.Boolean                  m_Active  // 0x18
  private           System.Net.Sockets.NetworkStreamm_DataStream  // 0x20
  private           System.Net.Sockets.AddressFamilym_Family  // 0x28
  private           System.Boolean                  m_CleanedUp  // 0x2C
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String hostname, System.Int32 port)
  System.Void .ctor(System.Net.Sockets.Socket acceptedSocket)
  System.Net.Sockets.Socket get_Client()
  System.Void set_Client(System.Net.Sockets.Socket value)
  System.Boolean get_Active()
  System.Void set_Active(System.Boolean value)
  System.Int32 get_Available()
  System.Boolean get_Connected()
  System.Boolean get_ExclusiveAddressUse()
  System.Void set_ExclusiveAddressUse(System.Boolean value)
  System.Void Connect(System.String hostname, System.Int32 port)
  System.Void Connect(System.Net.IPAddress address, System.Int32 port)
  System.Void Connect(System.Net.IPEndPoint remoteEP)
  System.Void Connect(System.Net.IPAddress[] ipAddresses, System.Int32 port)
  System.IAsyncResult BeginConnect(System.String host, System.Int32 port, System.AsyncCallback requestCallback, System.Object state)
  System.IAsyncResult BeginConnect(System.Net.IPAddress address, System.Int32 port, System.AsyncCallback requestCallback, System.Object state)
  System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, System.Int32 port, System.AsyncCallback requestCallback, System.Object state)
  System.Void EndConnect(System.IAsyncResult asyncResult)
  System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress address, System.Int32 port)
  System.Threading.Tasks.Task ConnectAsync(System.String host, System.Int32 port)
  System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress[] addresses, System.Int32 port)
  System.Net.Sockets.NetworkStream GetStream()
  System.Void Close()
  System.Void Dispose(System.Boolean disposing)
  System.Void Dispose()
  System.Void Finalize()
  System.Int32 get_ReceiveBufferSize()
  System.Void set_ReceiveBufferSize(System.Int32 value)
  System.Int32 get_SendBufferSize()
  System.Void set_SendBufferSize(System.Int32 value)
  System.Int32 get_ReceiveTimeout()
  System.Void set_ReceiveTimeout(System.Int32 value)
  System.Int32 get_SendTimeout()
  System.Void set_SendTimeout(System.Int32 value)
  System.Net.Sockets.LingerOption get_LingerState()
  System.Void set_LingerState(System.Net.Sockets.LingerOption value)
  System.Boolean get_NoDelay()
  System.Void set_NoDelay(System.Boolean value)
  System.Void _Initialize()
  System.Int32 _NumericOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName)
END_CLASS

CLASS: Beyond.Network.INetIO
TYPE:  interface
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Void Connect(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize)
  System.Threading.Tasks.Task ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize)
  System.Void Close()
  System.Void TestCloseNetIO(System.Boolean bIsTestReconnectFailed)
  System.Void TestDropNetIO(System.Boolean bIsTestDropSC, System.Boolean bIsTestDropCS)
  System.Boolean IsConnected()
  System.Int32 ReadData(System.Byte[] buffer, System.Int32 offset, System.Int32 len)
  System.Void WriteData(System.Byte[] data, System.Int32 offset, System.Int32 len)
  System.Boolean IsAuthed()
  System.Void MarkAuthed()
  System.Void EnableCryptStream(System.Byte[] key, System.Byte[] iv)
  System.Int32 ReadCryptoData(System.Byte[] buffer, System.Int32 offset, System.Int32 len)
  System.Void WriteCryptoData(System.Byte[] data, System.Int32 offset, System.Int32 len)
  System.Byte[] GetSendHeadBuffer()
  System.Byte[] GetSendBuffer()
  System.Byte[] GetReceiveBuffer()
  System.Int32 GetReceiveBufferOffset()
  System.Void ClearReceiveBufferOffset()
  System.Void SkipReceiveBufferOffset(System.Int32 len)
  System.Net.EndPoint GetEndPoint()
  System.Int32 Available()
END_CLASS

CLASS: Beyond.Network.NetMsgHandlerAttribute
TYPE:  class
TOKEN: 0x200000A
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type                     msgType  // 0x10
METHODS:
  System.Void .ctor(System.Type t)
  System.Void .ctor()
  System.Type GetMsgType(System.Reflection.MethodInfo annotatedMethod)
END_CLASS

CLASS: Beyond.Network.NetResponseHandler
TYPE:  class
TOKEN: 0x200000B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Beyond.Network.NetResponse& msg)
  System.IAsyncResult BeginInvoke(Beyond.Network.NetResponse& msg, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(Beyond.Network.NetResponse& msg, System.IAsyncResult result)
END_CLASS

CLASS: Beyond.Network.NetMessageHandle`1
TYPE:  class
TOKEN: 0x200000C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T message)
  System.IAsyncResult BeginInvoke(T message, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Beyond.Network.INetBusResponseListener
TYPE:  interface
TOKEN: 0x200000D
FIELDS:
METHODS:
  System.Void UpdateMsgTime(Beyond.Network.NetResponse resp)
END_CLASS

CLASS: Beyond.Network.NetRequest
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.UInt64                   csSeqID  // 0x10
  public            System.Int32                    mergeNum  // 0x18
  public            Google.Protobuf.IMessage        msg  // 0x20
METHODS:
END_CLASS

CLASS: Beyond.Network.NetResponse
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public    static  Beyond.Network.NetResponse      EMPTY  // 0x0
  public            Google.Protobuf.IMessage        headMsg  // 0x10
  public            Google.Protobuf.IMessage        msgBody  // 0x18
  public            System.Boolean                  isPacked  // 0x20
  public            System.Int64                    recvTimestamp  // 0x28
METHODS:
  Beyond.Network.HGNetLogger.Header get_logHead()
  System.Void set_logHead(Beyond.Network.HGNetLogger.Header value)
  Proto.CSHead get_csHead()
  System.Void set_csHead(Proto.CSHead value)
  System.Int32 get_msgId()
  System.UInt64 get_csSeqId()
  System.UInt64 get_scSeqId()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.MessageHandleWrapper
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
  System.Void HandleMessage(Google.Protobuf.IMessage msg)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.MessageHandleWrapper`1
TYPE:  class
TOKEN: 0x2000011
EXTENDS: MessageHandleWrapper
FIELDS:
  private   readonly Beyond.Network.NetMessageHandle<T>m_handle  // 0x0
METHODS:
  System.Void .ctor(Beyond.Network.NetMessageHandle<T> handle)
  System.Void HandleMessage(Google.Protobuf.IMessage msg)
END_CLASS

CLASS: Beyond.Network.NetBus
TYPE:  class
TOKEN: 0x2000012
EXTENDS: ExplicitSingleton`1
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.Network.NetResponseHandler>m_msgHandlers  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<Beyond.Network.NetBus.HandlerEntry>>m_msgWithSeqNumHandlers  // 0x18
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.Network.MessageHandleWrapper>m_msgHdlWrappers  // 0x20
  private           Beyond.Network.HGNetSession     m_netSession  // 0x28
  private   static  System.Collections.Generic.List<Beyond.Network.NetResponseHandler>s_handlersToCall  // 0x0
  private   readonly Beyond.Network.UIBusSender      <uiSender>k__BackingField  // 0x30
  private   readonly Beyond.Network.DisposableBusSender<defaultSender>k__BackingField  // 0x38
  private   readonly Beyond.Network.Special2BusSender<s2Sender>k__BackingField  // 0x40
  private   readonly Beyond.Network.InteractiveBusSender<interactiveSender>k__BackingField  // 0x48
  private   readonly Beyond.Network.FrequencyControlBusSender<frequencyControlSender>k__BackingField  // 0x50
METHODS:
  Beyond.Network.UIBusSender get_uiSender()
  Beyond.Network.DisposableBusSender get_defaultSender()
  Beyond.Network.Special2BusSender get_s2Sender()
  Beyond.Network.InteractiveBusSender get_interactiveSender()
  Beyond.Network.FrequencyControlBusSender get_frequencyControlSender()
  System.Int32 get_currentSessionID()
  System.Void .ctor()
  System.Boolean IsBusBusy()
  System.Void Setup(Beyond.Network.HGNetSession session)
  System.Void Send(Google.Protobuf.IMessage msg)
  System.Void RegisterMessageHandler(System.Int32 msgId, Beyond.Network.MessageHandleWrapper handler)
  System.Void UnRegisterMessageHandler(System.Int32 msgId)
  System.Void HandleMessageTime(Beyond.Network.NetResponse response)
  System.Void HandleMessage(Beyond.Network.NetResponse response)
  System.Boolean _ValidateSession()
  System.Void OnNetClientShutDown()
  Beyond.Network.NetBus.ResultHandler _SendWithResult(Google.Protobuf.IMessage msg)
  System.Void _Listen(System.Int32 msgId, Beyond.Network.NetResponseHandler handler)
  System.Void _UnListen(System.Int32 msgId, Beyond.Network.NetResponseHandler handler)
  System.Object _ListenWithSeqNum(System.Int32 msgId, Beyond.Network.NetResponseHandler callback)
  System.Void _UnListenWithSeqNum(System.Int32 msgId, System.Object token)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.Special2BusSender
TYPE:  class
TOKEN: 0x2000016
EXTENDS: DisposableBusSender
FIELDS:
  public            System.Collections.Generic.Dictionary<System.UInt64,System.Double>sendedMsgWithTime  // 0x20
  public            System.Double                   minSendTime  // 0x28
  private           System.Single                   m_maxWaitTime  // 0x30
METHODS:
  System.Boolean get_isBusBusy()
  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg)
  System.Void UpdateStartBlockTime()
  System.Void OnNetShutDown()
  System.Void Dispose()
  System.Void _ClearSendTime()
  System.Void UpdateMsgTime(Beyond.Network.NetResponse resp)
  System.Void .ctor()
  Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0)
  System.Void <>iFixBaseProxy_OnNetShutDown()
  System.Void <>iFixBaseProxy_Dispose()
END_CLASS

CLASS: Beyond.Network.InteractiveBusSender
TYPE:  class
TOKEN: 0x2000017
EXTENDS: Special2BusSender
FIELDS:
  private           System.Single                   m_maxWaitTime  // 0x38
METHODS:
  System.Boolean get_isBusBusy()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.DisposableBusSender
TYPE:  class
TOKEN: 0x2000018
EXTENDS: Sender
FIELDS:
  private   readonly System.Collections.Generic.HashSet<Beyond.Network.NetBus.ResultHandler>m_resultHandlers  // 0x10
  private           System.Boolean                  <isDisposed>k__BackingField  // 0x18
METHODS:
  System.Boolean get_isDisposed()
  System.Void set_isDisposed(System.Boolean value)
  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg)
  System.Void OnNetShutDown()
  System.Void Dispose()
  System.Void _Clear()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.NetworkMaskConfigHolder
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  public            System.Collections.Generic.Dictionary<Proto.CSMessageID,Proto.SCMessageID>msgs  // 0x10
METHODS:
  System.Void Init()
  System.Void Dispose()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.UIBusSender
TYPE:  class
TOKEN: 0x200001A
EXTENDS: DisposableBusSender
FIELDS:
  private           Beyond.Network.NetworkMaskConfigHolder<config>k__BackingField  // 0x20
  private           System.Collections.Generic.HashSet<System.Int32>m_maskKeys  // 0x28
METHODS:
  Beyond.Network.NetworkMaskConfigHolder get_config()
  System.Void set_config(Beyond.Network.NetworkMaskConfigHolder value)
  System.Void .ctor()
  System.Void Dispose()
  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg)
  System.Void OnNetShutDown()
  System.Void <>iFixBaseProxy_Dispose()
  Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0)
  System.Void <>iFixBaseProxy_OnNetShutDown()
END_CLASS

CLASS: Beyond.Network.FrequencyControlBusSender
TYPE:  class
TOKEN: 0x200001C
EXTENDS: DisposableBusSender
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<Proto.CSMessageID,System.Collections.Generic.Queue<System.Double>>m_lastSendTime  // 0x20
  private           System.Collections.Generic.List<Google.Protobuf.IMessage>m_waitingSendMsgs  // 0x28
  private           System.Collections.Generic.List<System.Action<System.Int32>>m_onError  // 0x30
  private           System.Int32                    m_loopId  // 0x38
METHODS:
  System.Void .ctor()
  System.Void _TrySendWaitingMsg()
  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg)
  Beyond.Network.NetBus.ResultHandler Send(Google.Protobuf.IMessage msg, System.Boolean needAddToWaitingList, System.Action<System.Int32> onError, System.Action onWait)
  System.Void Dispose()
  Beyond.Network.NetBus.ResultHandler <>iFixBaseProxy_Send(Google.Protobuf.IMessage P0)
  System.Void <>iFixBaseProxy_Dispose()
END_CLASS

CLASS: Beyond.Network.ServerDesc
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   addr  // 0x18
  public            System.Int32                    port  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.ServerList
TYPE:  class
TOKEN: 0x200001F
FIELDS:
  public            System.Collections.Generic.List<Beyond.Network.ServerDesc>servers  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.ServerConfig
TYPE:  class
TOKEN: 0x2000020
FIELDS:
  public            System.String                   serverName  // 0x10
  public            System.String                   uid  // 0x18
  public            System.Boolean                  checkDev  // 0x20
METHODS:
  System.Boolean IsSame(Beyond.Network.ServerConfig other)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.HostData
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  public            System.String                   host  // 0x10
  public            System.Int32                    port  // 0x18
  public            System.Double                   delay  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.NetConfig
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  public            System.Collections.Generic.List<Beyond.Network.HostData>hosts  // 0x10
METHODS:
  System.Void .ctor(System.Collections.Generic.List<Beyond.Network.HostData> hosts)
END_CLASS

CLASS: Beyond.Network.NetConsts
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  public    static readonly System.String                   NETMASK_CONFIG_PATH  // 0x0
  public    static readonly System.String                   NETMASK_PREFAB_PATH  // 0x8
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.INetworkSystem
TYPE:  interface
TOKEN: 0x2000024
FIELDS:
METHODS:
  System.Void OnReConnect()
  System.Void SendMsg(Google.Protobuf.IMessage msg, System.Action<System.Int32> onError)
END_CLASS

CLASS: Beyond.Network.NetUtil
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  private   static  System.Boolean                  s_isRegistedAllMessages  // 0x0
  public    static readonly System.Int32                    MAX_RECEIVE_PACK_BODY_SIZE  // 0x4
  public    static readonly System.Int32                    MAX_MERGE_PACK_BODY_SIZE  // 0x8
  public    static readonly System.Int32                    MAX_SEND_PACK_BODY_SIZE  // 0xC
  private   static  System.Collections.Generic.Dictionary<System.Int32,System.Type>s_sc_id2MessageType  // 0x10
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Int32>s_sc_messageType2Id  // 0x18
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Int32>s_cs_messageType2Id  // 0x20
  private   static  System.Byte[]                   s_decompressedBuffer  // 0x28
METHODS:
  System.Void RegisterSCMessage(System.Int32 msgId, System.Type msgType)
  System.Void RegisterCSMessage(System.Int32 msgId, System.Type msgType)
  System.Int32 GetSCMsgIdByType(System.Type msgType)
  System.Type GetSCMsgTypeById(System.Int32 msgId)
  System.Int32 GetCSMsgIdByType(System.Type msgType)
  System.Void _GenMessageName2ValuePair(System.Collections.Generic.Dictionary<System.String,System.Int32> dic)
  System.Void FastRegisterMessage()
  System.Boolean GetNetMessageFromDataBytes(System.Span<System.Byte> headBytes, System.Byte[] bodyBuffer, System.Int32 offset, System.Int32 bodyLen, System.Byte[] packedbuffer, Beyond.Network.NetResponse& response)
  System.Int32 SerializeHeadMessage(Google.Protobuf.IMessage msg, System.UInt64 upSeqid, System.Int32 bodyLen, System.Int32 crc32, System.Byte[] buffer, System.Int32 offset)
  System.Int32 SerializeBodyMessage(Google.Protobuf.IMessage msg, System.Byte[] buffer, System.Int32& crc32, System.Int32 offset)
  System.Void AutoRegisterMessageHandlers(System.Object target)
  System.Void AutoUnRegisterMessageHandlers(System.Object target)
  System.Void _ForeachMessageHandlers(System.Object target, System.Action<System.Type,System.Reflection.MethodInfo> doFunc)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.NetworkFrequencyConfig
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  public    static  Beyond.SerializeFieldDictionary<System.Int32,Beyond.Network.NetworkFrequencyConfig.NetworkFrequency>msgs  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.NetworkMask
TYPE:  class
TOKEN: 0x200002A
EXTENDS: Singleton`1
FIELDS:
  private           Beyond.TickFunction             m_preTickFunction  // 0x10
  private           System.Int32                    m_nextKey  // 0x18
  public            UnityEngine.GameObject          maskObj  // 0x20
  public            UnityEngine.GameObject          decoObj  // 0x28
  private           Beyond.Resource.FAssetProxyHandlem_handle  // 0x30
  private           System.Action<System.Boolean>   m_onNetMaskChanged  // 0x48
  private           System.Boolean                  <showingMask>k__BackingField  // 0x50
  private           System.Boolean                  <showingDeco>k__BackingField  // 0x51
  private           System.Boolean                  m_isNetReconnecting  // 0x52
  private   static  System.String                   DECO_NAME  // 0x0
  private           System.Collections.Generic.List<Beyond.Network.NetworkMask.MaskInfo>m_masks  // 0x58
METHODS:
  System.Boolean get_showingMask()
  System.Void set_showingMask(System.Boolean value)
  System.Boolean get_showingDeco()
  System.Void set_showingDeco(System.Boolean value)
  System.Void .ctor()
  System.Void OnInit()
  System.Void OnUnInit()
  System.Void Release()
  System.Void _OnSwitchLanguage()
  System.Void _CreateTickFunction()
  System.Void _ClearTickFunction()
  System.Void PreTick(System.Single deltaTime)
  System.Int32 _GetKey()
  System.Int32 AddMask(Proto.CSMessageID msgId, System.Single timeoutTime)
  System.Int32 AddMask(System.String name, System.Single timeoutTime, System.Single delayTime)
  System.Void RemoveMask(System.Int32 key)
  System.Void SetIsNetReconnecting(System.Boolean isReconnecting)
  System.Void _UpdateMaskState()
  System.Void ListenOnNetMaskChanged(System.Action<System.Boolean> action)
  System.Void UnListenOnNetMaskChanged(System.Action<System.Boolean> action)
END_CLASS

CLASS: Beyond.Network.NetworkMaskConfig
TYPE:  class
TOKEN: 0x200002C
EXTENDS: ScriptableObject
FIELDS:
  public            Beyond.SerializeFieldDictionary<Proto.CSMessageID,Proto.SCMessageID>msgs  // 0x18
  public            System.Collections.Generic.List<Beyond.Network.NetworkMaskConfig.Config>configs  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.NetworkUrls
TYPE:  class
TOKEN: 0x200002E
FIELDS:
  public    static  System.String                   URL_GET_SPLIT  // 0x0
METHODS:
  System.String RemoteConfigUrl()
  System.String ResourceRootUrlDev(System.String version)
  System.String ServerListUrl()
  System.String AgeTipsUrl()
  System.String GovUrl()
  System.String LauncherUrl()
  System.String _SelectUrl(System.String urlInConfig, Beyond.Network.NetworkUrls.EUrlType urlType)
  System.String _GetUrlFromLocal(Beyond.Network.NetworkUrls.EUrlType type)
END_CLASS

CLASS: Beyond.Network.TcpIO
TYPE:  class
TOKEN: 0x2000030
FIELDS:
  private           Beyond.Network.HGTcpClient      m_tcpClient  // 0x10
  protected         System.Byte[]                   m_recvBuffer  // 0x18
  protected         System.Byte[]                   m_sendHeadBuffer  // 0x20
  protected         System.Byte[]                   m_sendBuffer  // 0x28
  protected         System.Int32                    m_recvBufferOffset  // 0x30
  private           Beyond.XXEnc.XXE1               m_encryptor  // 0x38
  private           Beyond.XXEnc.XXE1               m_decryptor  // 0x40
  protected         System.Boolean                  m_isAuthed  // 0x48
  private           System.Boolean                  m_bIsTestDropSC  // 0x49
  private           System.Boolean                  m_bIsTestDropCS  // 0x4A
  private           System.Boolean                  m_bIsTestReconnectFailed  // 0x4B
  public    static  System.Int32                    SEND_HEAD_BUFFER_LENGTH  // 0x0
METHODS:
  System.Void Connect(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize)
  System.Threading.Tasks.Task ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Int32 sendTimeout, System.Int32 receiveBufferSize, System.Int32 sendBufferSize)
  System.Boolean IsAuthed()
  System.Void MarkAuthed()
  System.Void EnableCryptStream(System.Byte[] key, System.Byte[] iv)
  System.Net.EndPoint GetEndPoint()
  System.Void Close()
  System.Void TestCloseNetIO(System.Boolean bIsTestReconnectFailed)
  System.Void TestDropNetIO(System.Boolean bIsTestDropSC, System.Boolean bIsTestDropCS)
  System.Boolean IsConnected()
  System.Void WriteData(System.Byte[] data, System.Int32 offset, System.Int32 len)
  System.Void WriteCryptoData(System.Byte[] data, System.Int32 offset, System.Int32 len)
  System.Byte[] GetSendHeadBuffer()
  System.Byte[] GetSendBuffer()
  System.Byte[] GetReceiveBuffer()
  System.Void ClearReceiveBufferOffset()
  System.Int32 GetReceiveBufferOffset()
  System.Void SkipReceiveBufferOffset(System.Int32 len)
  System.Int32 ReadData(System.Byte[] buffer, System.Int32 offset, System.Int32 len)
  System.Int32 ReadCryptoData(System.Byte[] buffer, System.Int32 offset, System.Int32 len)
  System.Int32 Available()
  System.Void Dispose()
  System.Void Finalize()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Network.HttpSender
TYPE:  class
TOKEN: 0x2000031
FIELDS:
  public    static  System.String                   CONTENT_TYPE_JSON  // 0x0
  public    static  System.String                   CONTENT_ENCODING_GZIP  // 0x0
  public    static  System.Int32                    ERROR_CODE_TIMEOUT  // 0x0
  public    static  System.Int32                    ERROR_CODE_DNS_FAILED  // 0x0
  public    static  System.Int32                    ERROR_CODE_DESERIALIZE  // 0x0
  public    static  System.Single                   TIMEOUT_DEFAULT  // 0x0
  private   static  System.Int32                    OPT_GET  // 0x0
  private   static  System.Int32                    OPT_POST  // 0x0
METHODS:
  System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, Beyond.Misc.ObjectRef resultRef)
  System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, Beyond.Misc.ObjectRef resultRef)
  System.Collections.IEnumerator YieldSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options, System.Type respType, Beyond.Misc.ObjectRef resultRef)
  System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, Beyond.Misc.ObjectRef resultRef)
  System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, Beyond.Misc.ObjectRef resultRef)
  System.Collections.IEnumerator YieldSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options, System.Type respType, Beyond.Misc.ObjectRef resultRef)
  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options)
  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendGet(System.String url)
  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> WaitForSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options)
  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> WaitForSendPost(System.String url, Beyond.Network.HttpSender.FPostOptions options)
  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> WaitForSendGet(System.String url, Beyond.Network.HttpSender.FGetOptions options)
  System.Int32 GetGeneralErrorCode(Beyond.Network.HttpSender.Result result, System.Boolean& hasError)
  System.Collections.IEnumerator _YieldSendHttpRequest(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc)
  System.Collections.IEnumerator _YieldSendHttpRequest(Beyond.Misc.ObjectRef resultRef, Beyond.Network.HttpSender.FSendFunc sendFunc, System.Type respType)
  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> _WaitForSendHttpRequest(Beyond.Network.HttpSender.FSendFunc sendFunc)
  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result<TResp>> _WaitForSendHttpRequest(Beyond.Network.HttpSender.FSendFunc sendFunc)
  System.Void _StartWebRequestTask(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc)
  System.Void _WaitForServiceDone(Beyond.Network.HttpSender.Result result)
  UnityEngine.Networking.UnityWebRequest _CreateWebRequestGET(System.String url, Beyond.Network.HttpSender.FGetOptions options)
  UnityEngine.Networking.UnityWebRequest _CreateWebRequestPOST(System.String url, Beyond.Network.HttpSender.FPostOptions options)
  System.Void _SetHttpResult(Beyond.Network.HttpSender.Result result, UnityEngine.Networking.UnityWebRequest request)
  System.Void _DeserializeTypedResult(Beyond.Network.HttpSender.TypedResult result)
  System.Void _DebugOnlyProfileResult(Beyond.Network.HttpSender.Result result, Beyond.Network.HttpSender.FSendFunc sendFunc)
  System.Void _MarkResultAsException(Beyond.Network.HttpSender.Result result, System.Exception ex)
END_CLASS

CLASS: Beyond.Network.CircularBuffer`1
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  private   readonly T[]                             m_buffer  // 0x0
  private           System.Int32                    m_end  // 0x0
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_start  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity)
  System.Void .ctor(System.Int32 capacity, T[] items)
  System.Int32 get_Capacity()
  System.Boolean get_IsFull()
  System.Boolean get_IsEmpty()
  System.Int32 get_Count()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.Void Clear()
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T Front()
  System.Boolean TryFront(T& result)
  T Back()
  System.Boolean TryBack(T& result)
  System.Void PushBack(T item)
  System.Void PushFront(T item)
  System.Void PopBack()
  System.Void PopFront()
  System.Boolean TryPopFront(T& result)
  System.Boolean TryPopBack(T& result)
  T[] ToArray()
  System.Void _ThrowIfEmpty(System.String message)
  System.Void _Increment(System.Int32& index)
  System.Void _Decrement(System.Int32& index)
  System.Int32 _InternalIndex(System.Int32 index)
  System.ArraySegment<T> _ArrayOne()
  System.ArraySegment<T> _ArrayTwo()
END_CLASS

CLASS: Beyond.Network.HGNetBaseSession
TYPE:  class
TOKEN: 0x2000046
FIELDS:
  private           Beyond.Network.INetIO           m_tcpIO  // 0x10
  public    static  System.Int32                    s_recvBuffLen  // 0x0
  public    static  System.Int32                    s_tcpSendTimeout  // 0x4
  public    static  System.Int32                    s_sessionThreadSleepTimeMS  // 0x8
  public    static  System.Int32                    s_sessionThreadPauseSleepTimeMS  // 0xC
  public            System.Int32                    m_maxReconnectTimeout  // 0x18
  public            System.Int32                    m_maxReconnectTimes  // 0x1C
  public            System.Int32                    sendNumLimit  // 0x20
  protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetResponse>m_recvQueue  // 0x28
  protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest>m_sendQueue  // 0x30
  private   static  System.Int32                    MAX_RECYCLE_QUEUE_COUNT  // 0x0
  protected         Beyond.Network.CircularBuffer<Beyond.Network.NetRequest>m_circularBuffer  // 0x38
  private           System.Int64                    m_csSeqId  // 0x40
  protected         System.Int64                    m_scSeqId  // 0x48
  protected         System.Threading.Tasks.Task     m_threadTask  // 0x50
  protected         System.Int32                    m_threadTaskSignalID  // 0x58
  protected         Beyond.ELogChannel              m_logChannel  // 0x5C
  protected         System.Boolean                  m_isSyncFullDataEnd  // 0x5D
  protected         Google.Protobuf.IMessage        m_lastLoginMsg  // 0x60
  private           System.String                   m_lastConnectServerIp  // 0x68
  private           System.Int32                    m_lastConnectServerPort  // 0x70
  protected         System.Int32                    m_tryReconnectTimes  // 0x74
  protected         System.Boolean                  m_isAutoReconnect  // 0x78
  protected         System.Int64                    m_startReconnectTimestampMS  // 0x80
  protected         System.Int32                    m_closeNetMsgID  // 0x88
  public    static  System.Int32                    INVALID_SESSION_ID  // 0x10
  protected static  System.Int32                    s_sessionIDGenerator  // 0x14
  private           System.Int32                    <sessionID>k__BackingField  // 0x8C
  protected         Beyond.Network.HGNetSessionConnectYieldm_lastAsyncConnectHandle  // 0x90
  protected         Beyond.Network.EHGNetSessionStatem_state  // 0x98
  private           Beyond.Network.EHGNetSessionReconnectStatem_reconnectState  // 0x99
  protected         System.Double                   m_startReconnectTimeMS  // 0xA0
  protected         System.Int32                    m_closeErrorCode  // 0xA8
  public    static  System.Boolean                  s_applicationIsPaused  // 0x18
  private           System.Int64                    m_clientLastReceiveMsgMilliTs  // 0xB0
  private           System.Int64                    m_clientLastSendMsgMilliTs  // 0xB8
METHODS:
  System.Int32 get_sessionID()
  System.Void set_sessionID(System.Int32 value)
  Beyond.Network.EHGNetSessionReconnectState get_reconnectState()
  System.Void set_reconnectState(Beyond.Network.EHGNetSessionReconnectState value)
  System.Boolean get_isRunning()
  System.Boolean get_isConnecting()
  System.Boolean get_isRunningAndConnected()
  System.Boolean get_isReconnecting()
  System.Int32 get_closeErrorCode()
  System.Boolean get_isAutoReconnect()
  System.Int32 get_maxRecycleQueueCount()
  System.Void Start()
  System.Boolean Connect(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect)
  System.Boolean ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect, Beyond.Network.HGNetSessionConnectYield& yieldHandle)
  System.Void OnConnectAsyncEnd(System.Threading.Tasks.Task completedTask, Beyond.Network.INetIO tcpIO)
  System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO)
  System.Void _DNSCheck(System.String serverIp)
  System.Void Close(Beyond.Network.ENetCloseReason netCloseReason)
  System.Void InternalClose(Beyond.Network.INetIO tcpIO, Beyond.Network.ENetCloseReason netCloseReason)
  System.Void InternalClose(Beyond.Network.INetIO tcpIO, System.Int32 netCloseReason)
  System.Void EnqueueSendMsg(Beyond.Network.NetRequest msg)
  System.Int32 GetSendQueueMsgCount()
  System.Int64 IncrementCSSeqID()
  System.Void SetCSSeqID(System.Int64 id)
  System.Int64 GetCSSeqID()
  Beyond.Network.INetIO GetIO()
  System.Void StartTCPMsgLoopThreadTask()
  System.Void CloseTCPMsgThreadTask()
  System.Threading.Tasks.Task _SessionThread(Beyond.Network.INetIO tcp, System.Int32 threadID)
  System.Boolean _SendAndCheckMessage(Beyond.Network.INetIO tcp, System.Int32 threadID)
  System.Boolean _ReadAndCheckMessageInSessionThread(Beyond.Network.INetIO tcp, System.Int32 threadID)
  System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp)
  System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& m)
  System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m)
  System.Void SessionCheckSignalAndSleep(System.Int32 threadID)
  System.Void OpenAutoReconnect()
  System.Void RemoveAutoReconnect()
  System.Threading.Tasks.Task _ReconnectCheckerTick(Beyond.Network.INetIO tcpIO)
  System.Threading.Tasks.Task<System.Boolean> TryConnectWithTimeout(Beyond.Network.INetIO tcpIO, System.String ip, System.Int32 port, System.Int32 sendTimeout, System.Int32 receiveBufferLen, System.Int32 timeoutMilliseconds)
  System.Threading.Tasks.Task<System.Boolean> TryCloseTcpIOWithTimeout(Beyond.Network.INetIO tcpIO, System.Int32 timeoutMilliseconds)
  System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO)
  System.Boolean NeedKeepConnect()
  System.Void DoReconnectLogin(Beyond.Network.INetIO netIO)
  System.Void InitClientRSAKey()
  System.Void ClearRSAKey()
  System.Void ClearRecvQueue()
  System.Void ClearSendQueue()
  System.Void NetStatusChecker_Receive(Beyond.Network.INetIO netIO, System.Int64 scSeqId, System.Int32 receiveCount)
  System.Void NetStatusChecker_Sender(Beyond.Network.INetIO netIO, System.Int64 csSeqId, System.Int32 sendCount)
  System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs)
  System.Void ClearPingWDG()
  System.Boolean IsPingOut()
  System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetSession
TYPE:  class
TOKEN: 0x200004F
EXTENDS: HGNetBaseSession
FIELDS:
  private           System.String                   m_uid  // 0xC0
  private           System.String                   m_token  // 0xC8
  private           System.Int32                    m_channel  // 0xD0
  public    static  System.Int32                    LOGIN_TIMEOUT  // 0x0
  public    static  System.Int32                    MAX_CLIENT_RESEND_NUM  // 0x4
  public    static  System.Single                   PER_FRAME_RECEIVED_MESSAGES_TIME_30FPS  // 0x8
  public    static  System.Single                   PER_FRAME_RECEIVED_MESSAGES_TIME  // 0xC
  public    static  System.Single                   MESSAGE_MAX_DELAY_TIME  // 0x10
  protected         System.Int32                    m_messageDelayCount  // 0xD4
  protected         System.Int64                    m_logCDTimestamp  // 0xD8
  private   static  System.Boolean                  s_HGNetSessionBurst  // 0x14
  private   readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest>m_frameSendQueue  // 0xE0
  private           System.Collections.Generic.Queue<Beyond.Network.NetRequest>m_mergeQueueCache  // 0xE8
  private           System.Object                   m_frameSendQueueLocker  // 0xF0
  private           System.Byte[]                   m_frameSendPacketBuffer  // 0xF8
  private           System.Byte[]                   m_frameSendPacketHeadBuffer  // 0x100
  private           System.Byte[]                   m_frameSendPacketTempBuffer  // 0x108
  private           System.Byte[]                   m_frameSendCryptoBuffer  // 0x110
  private           System.Byte[]                   m_frameReceivePacketBuffer  // 0x118
  public    static  System.Int64                    s_maxframeSendPacketBuffer  // 0x18
  protected readonly System.Collections.Generic.Queue<Beyond.Network.NetResponse>m_callbackQueue  // 0x120
  private           Beyond.Network.HGNetSessionLoginYieldm_currLoginHandle  // 0x128
  private   static  System.Int32                    SEND_PING_DELTA_TICK_TIME_MS  // 0x0
  private   static  System.Int32                    s_pingWdgOutTimes  // 0x20
  private   static  System.Int32                    s_pingSyncFullEndBeforeTimes  // 0x24
  private           System.Int64                    m_needSendPingTimer  // 0x130
  private           System.Int32                    m_pingWDG  // 0x138
  private           System.Int64                    m_clientTsDelayms  // 0x140
  private           System.Int32                    m_pingValue  // 0x148
  private   static readonly System.String                   CLIENT_NET_PEM_PUBLIC_KEY_HEAD_FORMAT  // 0x28
  private   static readonly System.String                   CLIENT_NET_RSA_PUBLIC_KEY  // 0x30
  private   static readonly System.String                   CLIENT_NET_RSA_PRIVATE_KEY  // 0x38
  private   static  System.Byte[]                   s_clientPublicKeyBytes  // 0x40
  private           System.Security.Cryptography.RSAm_rsaClientPrivateProvider  // 0x150
  private   static readonly System.Byte[]                   EMPTY_BYTES  // 0x48
  private   static  System.Int32                    s_CacheLogLength  // 0x50
  private           System.Text.StringBuilder       m_sbCache  // 0x158
METHODS:
  System.Void SetAutoReconnectToken(System.String uid, System.String token, System.Int32 channel)
  System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs)
  System.Void DoReconnectLogin(Beyond.Network.INetIO netIO)
  System.Void Start()
  System.Void OnApplicationPause(System.Boolean pause)
  System.UInt64 SendMessage(Google.Protobuf.IMessage msg)
  System.Void PackMessageToSendQueue()
  System.Void UpdateInGameThread()
  System.Void TailLateUpdateInGameThread()
  System.Single _GetMessageTimeLimit()
  System.Void _ProcessReceivedMessagesInGameThread(System.Boolean flushAll)
  Beyond.Network.HGNetSessionLoginYield LoginAsync(System.String uid, System.String token, System.Int32 channel)
  System.Void _CSLoginHelper_UpdateAppInfo(Proto.MSG_A1 msg)
  System.String _GetOnlineResVersion()
  Proto.ENV_TYPE _GetSDKEnv()
  Proto.CLIENT_PLATFORM_TYPE _GetPlatformID()
  System.Int32 _GetPayPlatform()
  System.Void _SessionLoginThreadTask(System.Object handle)
  System.Void StartMsgLoop()
  System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO)
  System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO)
  System.Boolean NeedKeepConnect()
  System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& req)
  System.Void _WriteMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& request, System.Boolean useSRSA)
  System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp)
  System.Boolean _ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp, System.Boolean useSRSA)
  System.Void ClearRecvQueue()
  System.Void ClearSendQueue()
  System.Void SetBurstMode(System.Boolean val)
  System.Void Finalize()
  System.Int32 GetPing()
  System.Void ClearPingWDG()
  System.Void _ApproximateLoginServerTime(System.Int64 serverTimeMS, System.Int32 serverZone)
  System.Boolean _HandleSpecialMessagePing(Beyond.Network.NetResponse m)
  System.Boolean IsPingOut()
  System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId)
  System.Byte[] GetClientPublicKey()
  System.Void InitClientRSAKey()
  System.Byte[] _RSADecrypt(System.Byte[] data)
  System.Void ClearRSAKey()
  System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& msg)
  System.Boolean _HandleSpecialMessageReconnectIncr(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m)
  System.Boolean _HandleSpecialMessageReconnectFull(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m)
  System.Boolean _HandleSpecialMessageErrorCode(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m)
  System.Boolean _HandleSpecialMessageReconnectLogin(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse m)
  System.Void _HandleLoginEncryp(Beyond.Network.INetIO netIO, Proto.MSG_B1 msg)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_Start()
END_CLASS

CLASS: Beyond.Network.EHGNetSessionState
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Network.EHGNetSessionStateClosed  // 0x0
  public    static  Beyond.Network.EHGNetSessionStateOpened  // 0x0
  public    static  Beyond.Network.EHGNetSessionStateConnecting  // 0x0
  public    static  Beyond.Network.EHGNetSessionStateSessionRunning  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.EHGNetSessionReconnectState
TYPE:  struct
TOKEN: 0x2000051
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Network.EHGNetSessionReconnectStateNone  // 0x0
  public    static  Beyond.Network.EHGNetSessionReconnectStateReconnectingTcp  // 0x0
  public    static  Beyond.Network.EHGNetSessionReconnectStateSendLogin  // 0x0
  public    static  Beyond.Network.EHGNetSessionReconnectStateResendPack  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.ENetCloseReason
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.ENetCloseReason  Invalid  // 0x0
  public    static  Beyond.Network.ENetCloseReason  None  // 0x0
  public    static  Beyond.Network.ENetCloseReason  ForServerErrorMax  // 0x0
  public    static  Beyond.Network.ENetCloseReason  ConnectFailed  // 0x0
  public    static  Beyond.Network.ENetCloseReason  ServerReconnectFailed  // 0x0
  public    static  Beyond.Network.ENetCloseReason  TooMuchClientReconnectPack  // 0x0
  public    static  Beyond.Network.ENetCloseReason  ServerReconnectFullPack  // 0x0
  public    static  Beyond.Network.ENetCloseReason  ClientShutDown  // 0x0
  public    static  Beyond.Network.ENetCloseReason  ClientLaunch  // 0x0
  public    static  Beyond.Network.ENetCloseReason  ClientReconnectTooMuchTimes  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.HGNetSessionUtils
TYPE:  class
TOKEN: 0x2000053
FIELDS:
METHODS:
  System.Boolean CheckErrorNeedsDisconnect(Proto.CODE errorCode)
END_CLASS

CLASS: Beyond.Network.HGNetSessionConstant
TYPE:  class
TOKEN: 0x2000054
FIELDS:
  public    static  System.Int32                    CODE_SUC  // 0x0
  public    static  System.Int32                    CODE_CONN_FAILED  // 0x0
  public    static  System.Int32                    CODE_CONN_WAIT  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.ENetConnectErrorCode
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Network.ENetConnectErrorCodeInvalid  // 0x0
  public    static  Beyond.Network.ENetConnectErrorCodeNone  // 0x0
  public    static  Beyond.Network.ENetConnectErrorCodeForServerErrorMax  // 0x0
  public    static  Beyond.Network.ENetConnectErrorCodeConnectError  // 0x0
  public    static  Beyond.Network.ENetConnectErrorCodeTimeOut  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Network.HGNetSessionLoginYield
TYPE:  class
TOKEN: 0x2000056
EXTENDS: CustomYieldInstruction
FIELDS:
  private           Beyond.Network.HGNetSessionLoginYield.LoginErrorInfom_loginErrorInfo  // 0x10
  private           System.Boolean                  m_bIsFinish  // 0x18
  private           Proto.MSG_A1                    m_request  // 0x20
  private           Proto.MSG_B1                    m_resp  // 0x28
  private           System.Object                   m_locker  // 0x30
METHODS:
  System.Void .ctor()
  System.Void .ctor(Proto.MSG_A1 req)
  Proto.MSG_A1 GetRequest()
  Proto.MSG_B1 GetResponse()
  System.Int32 GetErrorCode()
  System.String GetErrorDetails()
  System.Void SetSucceed(Proto.MSG_B1 sc)
  System.Void SetNtfError(System.Int32 ntfErrorCode, System.String ntfErrorDetails)
  System.Void SetConnectErrorError()
  System.Void SetTimeOutError()
  System.Boolean get_isSucceed()
  System.Boolean get_keepWaiting()
END_CLASS

CLASS: Beyond.Network.HGNetSessionConnectYield
TYPE:  class
TOKEN: 0x2000058
EXTENDS: CustomYieldInstruction
FIELDS:
  private           System.Threading.Tasks.Task     m_connectTask  // 0x10
  private           Beyond.Network.ENetConnectErrorCodeconnectErrorCode  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Threading.Tasks.Task connectTask)
  System.Int32 GetCode()
  System.Void SetFinish(Beyond.Network.ENetConnectErrorCode code)
  System.Boolean get_isSucceed()
  System.Boolean get_keepWaiting()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.HGNetLogBaseSession
TYPE:  class
TOKEN: 0x2000059
FIELDS:
  private   readonly Beyond.Network.INetIO           m_tcpIO  // 0x10
  public    static  System.Int32                    s_recvBuffLen  // 0x0
  public    static  System.Int32                    s_tcpSendTimeout  // 0x4
  public    static  System.Int32                    s_sessionThreadSleepTimeMS  // 0x8
  public    static  System.Int32                    s_sessionThreadPauseSleepTimeMS  // 0xC
  public    static  System.Int32                    s_maxReconnectTimeout  // 0x10
  public    static  System.Int32                    s_maxReconnectTimes  // 0x14
  protected         System.Int32                    m_sendNumLimit  // 0x18
  protected readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetResponse>m_recvQueue  // 0x20
  private   readonly System.Collections.Concurrent.ConcurrentQueue<Beyond.Network.NetRequest>m_sendQueue  // 0x28
  private   static  System.Int32                    MAX_RECYCLE_QUEUE_COUNT  // 0x0
  protected         Beyond.Network.CircularBuffer<Beyond.Network.NetRequest>m_circularBuffer  // 0x30
  private           System.Int64                    m_csSeqId  // 0x38
  protected         System.Int64                    m_scSeqId  // 0x40
  protected         System.Threading.Tasks.Task     m_threadTask  // 0x48
  protected         System.Int32                    m_threadTaskSignal  // 0x50
  protected         Beyond.ELogChannel              m_logChannel  // 0x54
  private           System.String                   m_lastConnectServerIp  // 0x58
  private           System.Int32                    m_lastConnectServerPort  // 0x60
  protected         System.Int32                    m_tryReconnectTimes  // 0x64
  protected         System.Int64                    m_startReconnectTimestampMS  // 0x68
  protected         System.Boolean                  m_isAutoReconnect  // 0x70
  protected         Beyond.Network.HGNetSessionConnectYieldm_lastAsyncConnectHandle  // 0x78
  protected         Beyond.Network.EHGNetSessionStatem_state  // 0x80
  protected         Beyond.Network.EHGNetSessionReconnectStatem_reconnectState  // 0x81
  protected         System.Int32                    m_closeErrorCode  // 0x84
  public    static  System.Boolean                  s_applicationIsPaused  // 0x18
  private           System.Int64                    m_clientLastReceiveMsgMilliTs  // 0x88
  private           System.Int64                    m_clientLastSendMsgMilliTs  // 0x90
METHODS:
  System.Boolean get_isRunning()
  System.Boolean get_isConnecting()
  System.Boolean get_isRunningAndConnected()
  System.Int32 get_closeErrorCode()
  System.Boolean get_isAutoReconnect()
  System.Void Start()
  System.Boolean Connect(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect)
  System.Boolean ConnectAsync(System.String serverIp, System.Int32 serverPort, System.Boolean forceReconnect, Beyond.Network.HGNetSessionConnectYield& yieldHandle)
  System.Void OnConnectAsyncEnd(System.Threading.Tasks.Task continuationAction)
  System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO)
  System.Void _DNSCheck(System.String serverIp)
  System.Void Close(Beyond.Network.ENetCloseReason netCloseReason)
  System.Void Close(System.Int32 netCloseReason)
  System.Void EnqueueSendMsg(Beyond.Network.NetRequest msg)
  System.Int32 GetSendQueueMsgCount()
  System.Int64 IncrementCSSeqID()
  System.Void SetCSSeqID(System.Int64 id)
  System.Int64 GetCSSeqID()
  Beyond.Network.INetIO GetIO()
  System.Void StartTCPMsgLoopThreadTask()
  System.Void CloseTCPMsgThreadTask()
  System.Void _SessionThread()
  System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp)
  System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& m)
  System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m)
  System.Void SessionCheckSignalAndSleep()
  System.Void OpenAutoReconnect()
  System.Void RemoveAutoReconnect()
  System.Void _ReconnectCheckerTick()
  System.Void OnReconnectTimesOver()
  System.Boolean NeedKeepConnect()
  System.Void DoReconnectLogin(Beyond.Network.INetIO netIO)
  System.Void InitClientRSAKey()
  System.Void ClearRSAKey()
  System.Void NetStatusChecker_Receive(Beyond.Network.INetIO netIO, System.Int64 scSeqId, System.Int32 receiveCount)
  System.Void NetStatusChecker_Sender(Beyond.Network.INetIO netIO, System.Int64 csSeqId, System.Int32 sendCount)
  System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs)
  System.Void ClearPingWDG()
  System.Boolean IsPingOut()
  System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.HGNetLogger
TYPE:  class
TOKEN: 0x200005A
FIELDS:
  private           Beyond.Log.BitArray256          m_enabledLogChannel  // 0x10
  private           System.Collections.Concurrent.ConcurrentQueue<Beyond.Log.FLogMessage>m_logMessagesQueue  // 0x30
  public    static  System.Int32                    s_maxLogQueueSize  // 0x0
  public    static  System.Int32                    s_maxRepeatedMsgMs  // 0x4
  public    static  System.Int32                    s_maxRepeatedMsgCount  // 0x8
METHODS:
  System.Void Log(Beyond.Log.FLogMessage& msg)
  Beyond.Network.HGNetLogger.LogLevel ConvertFromDLogger(Beyond.ELogLevel level)
  Beyond.Network.HGNetLogger.NativeLogLevel ConvertFromDLoggerV2(Beyond.ELogLevel level)
  System.Boolean CheckLog(Beyond.Log.FLogMessage& msg)
  System.Void Clear()
  System.Void SetLogChannel(System.UInt64 channel1, System.UInt64 channel2, System.UInt64 channel3, System.UInt64 channel4)
  System.Int32 ConvertFromDLogger(Beyond.ELogChannel channel)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.HGNetLoggerClient
TYPE:  class
TOKEN: 0x200005B
FIELDS:
  private   static  Beyond.Network.HGNetLogger.HGNetLoggerClients_instance  // 0x0
  private   static  System.Int64                    <s_roleID>k__BackingField  // 0x8
  public            Beyond.Network.HGNetLogger.HGNetLoggerSessionm_logsession  // 0x10
  private           Beyond.Network.HGNetLogger.HGNetLoggerm_netLogger  // 0x18
  public    static readonly System.Int32                    MAX_LOG_SEND_QUEUE_SIZE  // 0x10
  private   static  System.Int32                    MAX_LOCAL_LOG_QUEUE_SIZE  // 0x0
  private   readonly System.Collections.Generic.Queue<Beyond.Log.FLogMessage>m_localLogQueue  // 0x20
  private   readonly System.Object                   m_queueLock  // 0x28
  public    static  Beyond.Network.HGNetLogger.Versions_usedVersion  // 0x14
METHODS:
  System.Void .ctor()
  Beyond.Network.HGNetLogger.HGNetLoggerClient get_instance()
  System.Int64 get_s_roleID()
  System.Void set_s_roleID(System.Int64 value)
  System.Void Init(System.String uid, System.String token, System.String env, System.String roleId)
  System.Void AddLog(System.String message, System.String stacktrace, UnityEngine.LogType type)
  System.Void _FlushLocalLogQueue()
  System.Void OnApplicationPause(System.Boolean pauseStatus)
  System.Void ShutDown()
  System.Void _CloseAndClear(Beyond.Network.ENetCloseReason reason)
  System.Void WriteNetLog(Beyond.Network.HGNetLogger.LogMessage& log)
  System.Void SetRoleID(System.UInt64 roleID)
  System.Void SetNetLogMaskFromServer(Google.Protobuf.Collections.RepeatedField<System.UInt64> masks)
  System.Void .cctor()
  System.Void <Init>b__15_0()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.HGNetLoggerCloudSettings
TYPE:  class
TOKEN: 0x200005C
FIELDS:
  public    static readonly Beyond.Network.HGNetLogger.HGNetLoggerCloudSettingsinstance  // 0x0
  private           Beyond.Network.HGNetLogger.LogControlm_cloudLogControl  // 0x10
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_cloudChannelLevelMaskTables  // 0x18
  private           Beyond.Network.HGNetLogger.LogControlm_localLogControl  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_localChannelLevelMaskTables  // 0x28
  private   static  System.Collections.Generic.List<Beyond.Network.HGNetLogger.NativeLogLevel>s_allLevels  // 0x8
METHODS:
  System.Void SetCloudLogControl(Beyond.Network.HGNetLogger.AuthResponse control, Beyond.Network.HGNetBaseSession session)
  System.Boolean IsNetLogLevelEnabled(Beyond.ELogLevel elevel, Beyond.ELogChannel channel)
  System.Boolean IsNetLogLevelEnabled(Beyond.Network.HGNetLogger.NativeLogLevel level, System.Int32 channel)
  System.Boolean IsLocalLogLevelEnabled(Beyond.ELogLevel elevel, Beyond.ELogChannel channel)
  Beyond.Network.HGNetLogger.NativeLogLevel ConvertFromDLogger(Beyond.ELogLevel level)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Network.HGNetLogger.HGNetLoggerSession
TYPE:  class
TOKEN: 0x200005D
EXTENDS: HGNetBaseSession
FIELDS:
  private           System.Byte[]                   m_keyBytes  // 0xC0
  private           System.Collections.Generic.Dictionary<System.String,System.Int32>m_templeCRCDict  // 0xC8
  private           System.Action                   m_onReconnectSuccess  // 0xD0
  private           System.String                   m_uid  // 0xD8
  private           System.String                   m_roleId  // 0xE0
  private           System.String                   m_token  // 0xE8
  private           System.String                   m_env  // 0xF0
  private   static  System.Collections.Generic.Dictionary<System.Type,Beyond.Network.HGNetLogger.MessageType>s_m_messageType2Id  // 0x0
  private   static  System.Collections.Generic.Dictionary<Beyond.Network.HGNetLogger.MessageType,System.Type>s_m_messageId2Type  // 0x8
METHODS:
  System.String get_uid()
  System.String get_roleId()
  System.Collections.Generic.Dictionary<System.Type,Beyond.Network.HGNetLogger.MessageType> get_s_messageType2Id()
  System.Collections.Generic.Dictionary<Beyond.Network.HGNetLogger.MessageType,System.Type> get_s_messageId2Type()
  System.Boolean TryGetMsgTypeByID(System.Type msgType, Beyond.Network.HGNetLogger.MessageType& type)
  System.Void Start()
  System.Void SetReconnectSuccessCallback(System.Action onReconnectSuccess)
  System.Void OnApplicationPause(System.Boolean pause)
  System.Void OnConnectedSucceed(Beyond.Network.INetIO tcpIO)
  System.Boolean ReadMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp)
  System.Void CheckAndDealRespMessages(Beyond.Network.INetIO netIO, Beyond.Network.NetResponse& resp)
  System.Void CheckAndWriteReqMsg(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest& m)
  System.Void _WriteMessageInSessionThread(Beyond.Network.INetIO netIO, Beyond.Network.NetRequest request)
  System.UInt64 SendMessage(Google.Protobuf.IMessage msg)
  System.Void SetAutoReconnectToken(System.String uid, System.String token, System.String env, System.String roleId)
  System.Boolean NeedKeepConnect()
  System.Void DoReconnectLogin(Beyond.Network.INetIO netIO)
  System.Int32 _GetConnectTimeoutTime()
  System.Void SessionConnectTimeoutCheckerTick(Beyond.Network.INetIO netIO, System.Int64 clientLastReceiveMsgMilliTs, System.Int64 clientLastSendMsgMilliTs)
  System.Void ClearPingWDG()
  System.Void SendLogin(Beyond.Network.INetIO netIO)
  System.Boolean IsPingOut()
  System.Void PingSenderTick(Beyond.Network.INetIO netIO, System.Int64 upSeqId)
  System.Void InitClientRSAKey()
  System.Void ClearRSAKey()
  System.Void ClearRecvQueue()
  System.Void ClearSendQueue()
  System.Void OnReconnectTimesOver(Beyond.Network.INetIO tcpIO)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Start()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Void __Gen_Wrap_0(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_1(System.Object P0, System.Object P1, System.Int32 P2)
  System.IAsyncResult __Gen_Wrap_2(System.Object P0, System.Object P1, System.Int32 P2, System.Object P3, System.Object P4)
  System.Threading.Tasks.Task __Gen_Wrap_3(System.Object P0, System.Object P1, System.Int32 P2)
  System.Net.Sockets.NetworkStream __Gen_Wrap_4(System.Object P0)
  System.Void __Gen_Wrap_5(System.Object P0)
  System.Void __Gen_Wrap_6(System.Object P0, System.Boolean P1)
  System.Net.Sockets.LingerOption __Gen_Wrap_7(System.Object P0)
  System.Int32 __Gen_Wrap_8(System.Object P0, System.Net.Sockets.SocketOptionLevel P1, System.Net.Sockets.SocketOptionName P2)
  System.Int32 __Gen_Wrap_9(System.Object P0)
  System.Boolean __Gen_Wrap_10(System.Object P0)
  System.Int64 __Gen_Wrap_11(System.Object P0)
  System.UInt64 __Gen_Wrap_12(System.Object P0, System.Object P1)
  System.Type __Gen_Wrap_13(System.Int32 P0)
  System.Void __Gen_Wrap_14(System.Object P0, System.Int32 P1, System.Object P2)
  System.Void __Gen_Wrap_15(System.Object P0, System.Int32 P1)
  Beyond.Network.NetBus.ResultHandler __Gen_Wrap_16(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_17(System.Object P0, Beyond.Network.NetResponse& P1)
  Beyond.Network.NetBus.ResultHandler __Gen_Wrap_18(System.Object P0, Proto.SCMessageID P1, System.Object P2)
  System.Void __Gen_Wrap_19(System.Object P0, Proto.SCMessageID P1, System.Object P2)
  System.Int32 __Gen_Wrap_20(System.Object P0, System.Object P1, System.Single P2, System.Single P3)
  System.Int32 __Gen_Wrap_21(System.Object P0, Proto.CSMessageID P1, System.Single P2)
  System.Void __Gen_Wrap_22(Beyond.Network.NetResponse& P0)
  Beyond.Network.NetBus.ResultHandler __Gen_Wrap_23(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3, System.Object P4)
  System.Boolean __Gen_Wrap_24(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_25(System.Int32 P0, System.Object P1)
  System.Void __Gen_Wrap_26()
  System.Boolean __Gen_Wrap_27(System.Span<System.Byte> P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Object P4, Beyond.Network.NetResponse& P5)
  System.Int32 __Gen_Wrap_28(System.Object P0, System.UInt64 P1, System.Int32 P2, System.Int32 P3, System.Object P4, System.Int32 P5)
  System.Void __Gen_Wrap_29(System.Type P0, System.Reflection.MethodInfo P1)
  System.Void __Gen_Wrap_30(System.Object P0, System.Single P1)
  System.String __Gen_Wrap_31()
  System.String __Gen_Wrap_32(System.Object P0)
  System.String __Gen_Wrap_33(Beyond.Network.NetworkUrls.EUrlType P0)
  System.String __Gen_Wrap_34(System.Object P0, Beyond.Network.NetworkUrls.EUrlType P1)
  System.Void __Gen_Wrap_35(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Int32 P5)
  System.Threading.Tasks.Task __Gen_Wrap_36(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Int32 P5)
  System.Void __Gen_Wrap_37(System.Object P0, System.Object P1, System.Object P2)
  System.Net.EndPoint __Gen_Wrap_38(System.Object P0)
  System.Void __Gen_Wrap_39(System.Object P0, System.Boolean P1, System.Boolean P2)
  System.Void __Gen_Wrap_40(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3)
  System.Byte[] __Gen_Wrap_41(System.Object P0)
  System.Int32 __Gen_Wrap_42(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3)
  Beyond.Network.HttpSender.Cancellation __Gen_Wrap_43(Beyond.Network.HttpSender.FSendFunc& P0)
  UnityEngine.Networking.UnityWebRequest __Gen_Wrap_44(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1)
  UnityEngine.Networking.UnityWebRequest __Gen_Wrap_45(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1)
  UnityEngine.Networking.UnityWebRequest __Gen_Wrap_46(Beyond.Network.HttpSender.FSendFunc& P0)
  System.Collections.IEnumerator __Gen_Wrap_47(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1)
  System.Collections.IEnumerator __Gen_Wrap_48(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1, System.Object P2)
  System.Collections.IEnumerator __Gen_Wrap_49(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1, System.Object P2, System.Object P3)
  System.Collections.IEnumerator __Gen_Wrap_50(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1, System.Object P2)
  System.Collections.IEnumerator __Gen_Wrap_51(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1, System.Object P2, System.Object P3)
  System.Collections.IEnumerator __Gen_Wrap_52(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1, System.Object P2)
  System.Void __Gen_Wrap_53(System.Object P0, Beyond.Network.HttpSender.FSendFunc P1)
  Beyond.Network.HttpSender.Result __Gen_Wrap_54()
  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_55(Beyond.Network.HttpSender.FSendFunc P0)
  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_56(System.Object P0, Beyond.Network.HttpSender.FPostOptions P1)
  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_57(System.Object P0, Beyond.Network.HttpSender.FGetOptions P1)
  Beyond.WaitForAsyncTask<Beyond.Network.HttpSender.Result> __Gen_Wrap_58(System.Object P0)
  System.Int32 __Gen_Wrap_59(System.Object P0, System.Boolean& P1)
  System.String __Gen_Wrap_60(Beyond.Network.HttpSender.FSendFunc& P0)
  System.Void __Gen_Wrap_61(System.Object P0, Beyond.Network.EHGNetSessionReconnectState P1)
  System.Void __Gen_Wrap_62(System.Object P0, System.Object P1, Beyond.Network.ENetCloseReason P2)
  System.Boolean __Gen_Wrap_63(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3)
  System.Void __Gen_Wrap_64(System.Object P0, Beyond.Network.ENetConnectErrorCode P1)
  System.Void __Gen_Wrap_65(System.Object P0, Beyond.Network.ENetCloseReason P1)
  System.Void __Gen_Wrap_66(System.Threading.Tasks.Task<System.Threading.Tasks.Task> P0)
  System.Boolean __Gen_Wrap_67(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3, Beyond.Network.HGNetSessionConnectYield& P4)
  System.Void __Gen_Wrap_68(System.Object P0, Beyond.Network.NetRequest P1)
  System.Void __Gen_Wrap_69(System.Object P0, System.Int64 P1)
  Beyond.Network.INetIO __Gen_Wrap_70(System.Object P0)
  System.Threading.Tasks.Task<System.Boolean> __Gen_Wrap_71(System.Object P0, System.Object P1, System.Int32 P2)
  System.Threading.Tasks.Task<System.Boolean> __Gen_Wrap_72(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3, System.Int32 P4, System.Int32 P5, System.Int32 P6)
  System.Threading.Tasks.Task __Gen_Wrap_73(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_74(System.Object P0, System.Object P1, System.Int64 P2, System.Int32 P3)
  System.Boolean __Gen_Wrap_75(System.Object P0, System.Object P1, System.Int32 P2)
  System.Threading.Tasks.Task __Gen_Wrap_76()
  System.Void __Gen_Wrap_77(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3)
  System.Void __Gen_Wrap_78(System.Object P0, System.Object P1, System.Int64 P2, System.Int64 P3)
  System.Byte[] __Gen_Wrap_79()
  Proto.CLIENT_PLATFORM_TYPE __Gen_Wrap_80()
  Proto.ENV_TYPE __Gen_Wrap_81()
  System.Int32 __Gen_Wrap_82()
  System.Void __Gen_Wrap_83(System.Object P0, System.Object P1, Beyond.Network.NetRequest& P2, System.Boolean P3)
  System.Boolean __Gen_Wrap_84(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2, System.Boolean P3)
  System.Void __Gen_Wrap_85(System.Object P0, System.Int64 P1, System.Int32 P2)
  System.Byte[] __Gen_Wrap_86(System.Object P0, System.Object P1)
  Proto.MSG_A1 __Gen_Wrap_87(System.Object P0)
  Beyond.Network.HGNetSessionLoginYield __Gen_Wrap_88(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3)
  System.Void __Gen_Wrap_89(System.Object P0, System.Object P1, Beyond.Network.NetRequest& P2)
  System.Boolean __Gen_Wrap_90(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2)
  System.Boolean __Gen_Wrap_91(System.Object P0, Beyond.Network.NetResponse P1)
  System.Void __Gen_Wrap_92(System.Object P0, System.Object P1, System.Int64 P2)
  System.Boolean __Gen_Wrap_93(Proto.CODE P0)
  System.Boolean __Gen_Wrap_94(System.Object P0, System.Object P1, Beyond.Network.NetResponse P2)
  System.Void __Gen_Wrap_95(System.Object P0, System.Object P1, Beyond.Network.NetResponse& P2)
  Proto.MSG_B1 __Gen_Wrap_96(System.Object P0)
  System.Boolean __Gen_Wrap_97(System.Object P0, Beyond.Log.FLogMessage& P1)
  Beyond.Network.HGNetLogger.LogLevel __Gen_Wrap_98(Beyond.ELogLevel P0)
  Beyond.Network.HGNetLogger.NativeLogLevel __Gen_Wrap_99(Beyond.ELogLevel P0)
  System.Int32 __Gen_Wrap_100(Beyond.ELogChannel P0)
  System.Boolean __Gen_Wrap_101(Beyond.Network.HGNetLogger.NativeLogLevel P0, System.Int32 P1)
  System.Boolean __Gen_Wrap_102(Beyond.ELogLevel P0, Beyond.ELogChannel P1)
  System.Void __Gen_Wrap_103(System.Object P0, System.Object P1, System.Object P2, UnityEngine.LogType P3)
  Beyond.Network.HGNetLogger.HGNetLoggerClient __Gen_Wrap_104()
  System.Void __Gen_Wrap_105(System.Object P0, Beyond.Network.HGNetLogger.LogMessage& P1)
  System.Void __Gen_Wrap_106(System.Object P0, Beyond.Log.FLogMessage& P1)
  System.Void __Gen_Wrap_107(System.Object P0, System.UInt64 P1, System.UInt64 P2, System.UInt64 P3, System.UInt64 P4)
  System.Void __Gen_Wrap_108(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4)
  System.Void __Gen_Wrap_109(System.Boolean P0)
  System.Void __Gen_Wrap_110(System.UInt64 P0)
  System.Collections.Generic.Dictionary<System.Type,Beyond.Network.HGNetLogger.MessageType> __Gen_Wrap_111()
  System.Collections.Generic.Dictionary<Beyond.Network.HGNetLogger.MessageType,System.Type> __Gen_Wrap_112()
  System.Boolean __Gen_Wrap_113(System.Object P0, Beyond.Network.HGNetLogger.MessageType& P1)
  System.Void __Gen_Wrap_114(System.Object P0, System.Object P1, Beyond.Network.NetRequest P2)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x200005F
EXTENDS: AnonymousStorey
FIELDS:
  private           System.Int32                    methodId_0  // 0x40
  private           System.Int32                    methodId_1  // 0x44
  private           System.Int32                    methodId_2  // 0x48
  private           System.Int32                    methodId_3  // 0x4C
  private           System.Int32                    methodId_4  // 0x50
  private           System.Int32                    methodId_5  // 0x54
  private           System.Int32                    methodId_6  // 0x58
METHODS:
  System.Void System.IDisposable.Dispose()
  System.Boolean MoveNext()
  System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void MoveNext()
  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine P0)
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAwaitUnsafeOnCompleteMethod()
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000060
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  System.Object CreateWrapper(System.Int32 id)
  System.Object InitWrapperArray(System.Int32 len)
  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  struct
TOKEN: 0x2000061
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Connect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Connect1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Connect2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Connect3  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-BeginConnect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-BeginConnect1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-BeginConnect2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-EndConnect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-ConnectAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-ConnectAsync1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-ConnectAsync2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-GetStream0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Close0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-Dispose1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-get_LingerState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-_Initialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGTcpClient-_NumericOption0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-get_currentSessionID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-Setup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-_ValidateSession0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-IncrementCSSeqID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-SendMessage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-Send0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-GetSCMsgTypeById0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-RegisterMessageHandler0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-UnRegisterMessageHandler0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-OnNetClientShutDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-_SendWithResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-_Listen0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-_UnListen0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-_UnListenWithSeqNum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-ResultHandler-SetIgnoreSeq0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-ResultHandler-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-ResultHandler-_HandleMessage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-ResultHandler-OnResponse0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-Sender-DoSend0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-Sender-DoListen0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetBus-Sender-DoUnListen0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-Special2BusSender-Send0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-DisposableBusSender-_Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-DisposableBusSender-OnNetShutDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-Special2BusSender-_ClearSendTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-Special2BusSender-OnNetShutDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-DisposableBusSender-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-Special2BusSender-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-DisposableBusSender-Send0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMaskConfigHolder-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMaskConfigHolder-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-_UpdateMaskState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-RemoveMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-UIBusSender-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-GetCSMsgIdByType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-_GetKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-AddMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-AddMask1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-UIBusSender-Send0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-UIBusSender-OnNetShutDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-FrequencyControlBusSender-Send0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-FrequencyControlBusSender-_TrySendWaitingMsg0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-FrequencyControlBusSender-Send1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-FrequencyControlBusSender-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-ServerConfig-IsSame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-RegisterSCMessage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-RegisterCSMessage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-GetSCMsgIdByType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-FastRegisterMessage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-GetNetMessageFromDataBytes0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-SerializeHeadMessage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-AutoRegisterMessageHandlers0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-_ForeachMessageHandlers0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetUtil-AutoUnRegisterMessageHandlers0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-PreTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-_CreateTickFunction0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-_OnSwitchLanguage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-_ClearTickFunction0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-OnUnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-Release0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-ListenOnNetMaskChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkMask-UnListenOnNetMaskChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-RemoteConfigUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-ResourceRootUrlDev0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-_GetUrlFromLocal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-ServerListUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-_SelectUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-AgeTipsUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-GovUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-NetworkUrls-LauncherUrl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-IsConnected0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-Close0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-Connect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-ConnectAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-IsAuthed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-MarkAuthed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-EnableCryptStream0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-GetEndPoint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-TestCloseNetIO0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-TestDropNetIO0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-WriteData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-WriteCryptoData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-GetSendHeadBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-GetSendBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-GetReceiveBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-ClearReceiveBufferOffset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-GetReceiveBufferOffset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-SkipReceiveBufferOffset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-ReadData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-ReadCryptoData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-Available0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-TcpIO-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-FSendFunc-GetCancellation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_CreateWebRequestGET0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_CreateWebRequestPOST0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-FSendFunc-Invoke0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-Cancellation-IsCanceled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_SetHttpResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_MarkResultAsException0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_YieldSendHttpRequest0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_DeserializeTypedResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_YieldSendHttpRequest1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-YieldSendGet0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-YieldSendGet1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-YieldSendPost0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-YieldSendPost1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_WaitForServiceDone0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_StartWebRequestTask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_WaitForSendHttpRequest0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-WaitForSendPost0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-WaitForSendGet0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-WaitForSendGet1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-GetGeneralErrorCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-_DebugOnlyProfileResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-Cancellation-Cancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HttpSender-FSendFunc-GetOptMethod0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-set_reconnectState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-_DNSCheck0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-RemoveAutoReconnect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-CloseTCPMsgThreadTask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-InternalClose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-InternalClose1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-Connect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionConnectYield-SetFinish0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-Close0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-OnConnectAsyncEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-ConnectAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-EnqueueSendMsg0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-GetSendQueueMsgCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-SetCSSeqID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-GetCSSeqID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-GetIO0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-TryCloseTcpIOWithTimeout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-TryConnectWithTimeout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-_ReconnectCheckerTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-SessionCheckSignalAndSleep0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-NetStatusChecker_Receive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-_ReadAndCheckMessageInSessionThread0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-NetStatusChecker_Sender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-_SendAndCheckMessage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-_SessionThread0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-StartTCPMsgLoopThreadTask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetBaseSession-OpenAutoReconnect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-SetAutoReconnectToken0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-SessionConnectTimeoutCheckerTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-GetClientPublicKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_GetOnlineResVersion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_GetPlatformID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_GetSDKEnv0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_GetPayPlatform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_CSLoginHelper_UpdateAppInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_WriteMessageInSessionThread0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_ReadMessageInSessionThread0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_ApproximateLoginServerTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_RSADecrypt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleLoginEncryp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-DoReconnectLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-OnApplicationPause0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-GetRequest0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-SetSucceed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Set0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-SetNtfError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-SetConnectErrorError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectTimeOut0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-SetTimeOutError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_SessionLoginThreadTask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-LoginAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-StartMsgLoop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-OnConnectedSucceed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-OnReconnectTimesOver0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-NeedKeepConnect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-CheckAndWriteReqMsg0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-ReadMessageInSessionThread0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-ClearRecvQueue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-ClearSendQueue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-GetPing0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-ClearPingWDG0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleSpecialMessagePing0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-IsPingOut0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-PingSenderTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-InitClientRSAKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-ClearRSAKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionUtils-CheckErrorNeedsDisconnect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleSpecialMessageErrorCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectIncr0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectFull0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-CheckAndDealRespMessages0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-GetResponse0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-GetErrorCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-GetErrorDetails0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorInvaild0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionConnectYield-GetCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetSessionConnectYield-get_keepWaiting0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DNSCheck0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-RemoveAutoReconnect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-CloseTCPMsgThreadTask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-Connect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-OnConnectAsyncEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-ConnectAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-EnqueueSendMsg0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetSendQueueMsgCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-IncrementCSSeqID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-SetCSSeqID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetCSSeqID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetIO0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-_ReconnectCheckerTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-SessionCheckSignalAndSleep0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Receive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Sender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-_SessionThread0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-StartTCPMsgLoopThreadTask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogBaseSession-OpenAutoReconnect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-CheckLog0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLoggerV20  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-ConvertFromDLogger0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-_FlushLocalLogQueue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-AddLog0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-_CloseAndClear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-ShutDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-get_instance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-SendMessage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-WriteNetLog0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-Log0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLogger-SetLogChannel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-SetAutoReconnectToken0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-SetReconnectSuccessCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-OnApplicationPause0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-OnApplicationPause0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-SetRoleID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerClient-SetNetLogMaskFromServer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-SetCloudLogControl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsLocalLogLevelEnabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageType2Id0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageId2Type0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-TryGetMsgTypeByID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-_WriteMessageInSessionThread0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-SendLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-OnConnectedSucceed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-ReadMessageInSessionThread0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndDealRespMessages0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndWriteReqMsg0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-NeedKeepConnect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-DoReconnectLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-_GetConnectTimeoutTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-SessionConnectTimeoutCheckerTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearPingWDG0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-IsPingOut0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-PingSenderTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-InitClientRSAKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRSAKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRecvQueue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearSendQueue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Network-HGNetLogger-HGNetLoggerSession-OnReconnectTimesOver0  // 0x0
METHODS:
END_CLASS

