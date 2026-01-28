// ========================================================
// Dumped by @desirepro
// Assembly: UnityWebSocket.Runtime.dll
// Classes:  16
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SendBuffer
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  public            System.Byte[]                   data  // 0x10
  public            System.Net.WebSockets.WebSocketMessageTypetype  // 0x18
METHODS:
  System.Void .ctor(System.Byte[] data, System.Net.WebSockets.WebSocketMessageType type)
END_CLASS

CLASS: UnityWebSocket.CloseEventArgs
TYPE:  class
TOKEN: 0x2000002
EXTENDS: EventArgs
FIELDS:
  private           System.UInt16                   <Code>k__BackingField  // 0x10
  private           System.String                   <Reason>k__BackingField  // 0x18
  private           System.Boolean                  <WasClean>k__BackingField  // 0x20
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.UInt16 code)
  System.Void .ctor(UnityWebSocket.CloseStatusCode code)
  System.Void .ctor(UnityWebSocket.CloseStatusCode code, System.String reason)
  System.Void .ctor(System.UInt16 code, System.String reason)
  System.UInt16 get_Code()
  System.Void set_Code(System.UInt16 value)
  System.String get_Reason()
  System.Void set_Reason(System.String value)
  System.Boolean get_WasClean()
  System.Void set_WasClean(System.Boolean value)
  UnityWebSocket.CloseStatusCode get_StatusCode()
END_CLASS

CLASS: UnityWebSocket.CloseStatusCode
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  UnityWebSocket.CloseStatusCode  Unknown  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  Normal  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  Away  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  ProtocolError  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  UnsupportedData  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  Undefined  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  NoStatus  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  Abnormal  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  InvalidData  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  PolicyViolation  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  TooBig  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  MandatoryExtension  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  ServerError  // 0x0
  public    static  UnityWebSocket.CloseStatusCode  TlsHandshakeFailure  // 0x0
METHODS:
END_CLASS

CLASS: UnityWebSocket.ErrorEventArgs
TYPE:  class
TOKEN: 0x2000004
EXTENDS: EventArgs
FIELDS:
  private           System.Exception                <Exception>k__BackingField  // 0x10
  private           System.String                   <Message>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception exception)
  System.Exception get_Exception()
  System.Void set_Exception(System.Exception value)
  System.String get_Message()
  System.Void set_Message(System.String value)
END_CLASS

CLASS: UnityWebSocket.IWebSocket
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Void ConnectAsync()
  System.Void CloseAsync()
  System.Void SendAsync(System.Byte[] data)
  System.Void SendAsync(System.String text)
  System.String get_Address()
  System.String[] get_SubProtocols()
  UnityWebSocket.WebSocketState get_ReadyState()
  System.String get_BinaryType()
  System.Void set_BinaryType(System.String value)
  System.Void add_OnOpen(System.EventHandler<UnityWebSocket.OpenEventArgs> value)
  System.Void remove_OnOpen(System.EventHandler<UnityWebSocket.OpenEventArgs> value)
  System.Void add_OnClose(System.EventHandler<UnityWebSocket.CloseEventArgs> value)
  System.Void remove_OnClose(System.EventHandler<UnityWebSocket.CloseEventArgs> value)
  System.Void add_OnError(System.EventHandler<UnityWebSocket.ErrorEventArgs> value)
  System.Void remove_OnError(System.EventHandler<UnityWebSocket.ErrorEventArgs> value)
  System.Void add_OnMessage(System.EventHandler<UnityWebSocket.MessageEventArgs> value)
  System.Void remove_OnMessage(System.EventHandler<UnityWebSocket.MessageEventArgs> value)
END_CLASS

CLASS: UnityWebSocket.MessageEventArgs
TYPE:  class
TOKEN: 0x2000006
EXTENDS: EventArgs
FIELDS:
  private           System.Byte[]                   _rawData  // 0x10
  private           System.String                   _data  // 0x18
  private           UnityWebSocket.Opcode           <Opcode>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(UnityWebSocket.Opcode opcode, System.Byte[] rawData)
  System.Void .ctor(UnityWebSocket.Opcode opcode, System.String data)
  UnityWebSocket.Opcode get_Opcode()
  System.Void set_Opcode(UnityWebSocket.Opcode value)
  System.String get_Data()
  System.Byte[] get_RawData()
  System.Boolean get_IsBinary()
  System.Boolean get_IsText()
  System.Void SetData()
  System.Void SetRawData()
END_CLASS

CLASS: UnityWebSocket.Opcode
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityWebSocket.Opcode           Text  // 0x0
  public    static  UnityWebSocket.Opcode           Binary  // 0x0
  public    static  UnityWebSocket.Opcode           Close  // 0x0
METHODS:
END_CLASS

CLASS: UnityWebSocket.OpenEventArgs
TYPE:  class
TOKEN: 0x2000008
EXTENDS: EventArgs
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityWebSocket.Settings
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  public    static  System.String                   GITHUB  // 0x0
  public    static  System.String                   QQ_GROUP  // 0x0
  public    static  System.String                   QQ_GROUP_LINK  // 0x0
  public    static  System.String                   EMAIL  // 0x0
  public    static  System.String                   AUHTOR  // 0x0
  public    static  System.String                   VERSION  // 0x0
METHODS:
END_CLASS

CLASS: UnityWebSocket.WebSocketState
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  UnityWebSocket.WebSocketState   Connecting  // 0x0
  public    static  UnityWebSocket.WebSocketState   Open  // 0x0
  public    static  UnityWebSocket.WebSocketState   Closing  // 0x0
  public    static  UnityWebSocket.WebSocketState   Closed  // 0x0
METHODS:
END_CLASS

CLASS: UnityWebSocket.WebSocket
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private           System.String                   <Address>k__BackingField  // 0x10
  private           System.String[]                 <SubProtocols>k__BackingField  // 0x18
  private           System.String                   <BinaryType>k__BackingField  // 0x20
  private           System.EventHandler<UnityWebSocket.OpenEventArgs>OnOpen  // 0x28
  private           System.EventHandler<UnityWebSocket.CloseEventArgs>OnClose  // 0x30
  private           System.EventHandler<UnityWebSocket.ErrorEventArgs>OnError  // 0x38
  private           System.EventHandler<UnityWebSocket.MessageEventArgs>OnMessage  // 0x40
  private           System.Net.WebSockets.ClientWebSocketsocket  // 0x48
  private           System.Object                   sendQueueLock  // 0x50
  private           System.Collections.Generic.Queue<UnityWebSocket.WebSocket.SendBuffer>sendQueue  // 0x58
  private           System.Boolean                  isSendTaskRunning  // 0x60
  private   readonly System.Collections.Generic.Queue<System.EventArgs>eventQueue  // 0x68
  private   readonly System.Object                   eventQueueLock  // 0x70
METHODS:
  System.String get_Address()
  System.Void set_Address(System.String value)
  System.String[] get_SubProtocols()
  System.Void set_SubProtocols(System.String[] value)
  UnityWebSocket.WebSocketState get_ReadyState()
  System.String get_BinaryType()
  System.Void set_BinaryType(System.String value)
  System.Void add_OnOpen(System.EventHandler<UnityWebSocket.OpenEventArgs> value)
  System.Void remove_OnOpen(System.EventHandler<UnityWebSocket.OpenEventArgs> value)
  System.Void add_OnClose(System.EventHandler<UnityWebSocket.CloseEventArgs> value)
  System.Void remove_OnClose(System.EventHandler<UnityWebSocket.CloseEventArgs> value)
  System.Void add_OnError(System.EventHandler<UnityWebSocket.ErrorEventArgs> value)
  System.Void remove_OnError(System.EventHandler<UnityWebSocket.ErrorEventArgs> value)
  System.Void add_OnMessage(System.EventHandler<UnityWebSocket.MessageEventArgs> value)
  System.Void remove_OnMessage(System.EventHandler<UnityWebSocket.MessageEventArgs> value)
  System.Boolean get_isOpening()
  System.Void .ctor(System.String address)
  System.Void .ctor(System.String address, System.String subProtocol)
  System.Void .ctor(System.String address, System.String[] subProtocols)
  System.Void ConnectAsync()
  System.Void CloseAsync()
  System.Void SendAsync(System.Byte[] data)
  System.Void SendAsync(System.String text)
  System.Threading.Tasks.Task ConnectTask()
  System.Void SendBufferAsync(UnityWebSocket.WebSocket.SendBuffer buffer)
  System.Threading.Tasks.Task SendTask()
  System.Threading.Tasks.Task ReceiveTask()
  System.Void SocketDispose()
  System.Void HandleOpen()
  System.Void HandleMessage(UnityWebSocket.Opcode opcode, System.Byte[] rawData)
  System.Void HandleClose(System.UInt16 code, System.String reason)
  System.Void HandleError(System.Exception exception)
  System.Void HandleEventSync(System.EventArgs eventArgs)
  System.Void Update()
  System.Void Log(System.String msg)
END_CLASS

CLASS: UnityWebSocket.WebSocketManager
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.String                   rootName  // 0x0
  private   static  UnityWebSocket.WebSocketManager _instance  // 0x0
  private   readonly System.Collections.Generic.List<UnityWebSocket.WebSocket>sockets  // 0x18
METHODS:
  UnityWebSocket.WebSocketManager get_Instance()
  System.Void Awake()
  System.Void CreateInstance()
  System.Void Add(UnityWebSocket.WebSocket socket)
  System.Void Remove(UnityWebSocket.WebSocket socket)
  System.Void Update()
  System.Void .ctor()
END_CLASS

