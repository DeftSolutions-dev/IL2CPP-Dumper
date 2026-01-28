// ========================================================
// Dumped by @desirepro
// Assembly: UnityWebSocket.Runtime.dll
// Classes:  16
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000C
    public class SendBuffer
    {
        // Fields
        public System.Byte[] data;        // 0x10
        public System.Net.WebSockets.WebSocketMessageType type;        // 0x18

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Net.WebSockets.WebSocketMessageType type) { }

    }

namespace UnityWebSocket
{

    // TypeToken: 0x2000002
    public class CloseEventArgs : EventArgs
    {
        // Fields
        private System.UInt16 <Code>k__BackingField;        // 0x10
        private System.String <Reason>k__BackingField;        // 0x18
        private System.Boolean <WasClean>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.UInt16 code) { }
        private System.Void .ctor(UnityWebSocket.CloseStatusCode code) { }
        private System.Void .ctor(UnityWebSocket.CloseStatusCode code, System.String reason) { }
        private System.Void .ctor(System.UInt16 code, System.String reason) { }
        private System.UInt16 get_Code() { }
        private System.Void set_Code(System.UInt16 value) { }
        private System.String get_Reason() { }
        private System.Void set_Reason(System.String value) { }
        private System.Boolean get_WasClean() { }
        private System.Void set_WasClean(System.Boolean value) { }
        private UnityWebSocket.CloseStatusCode get_StatusCode() { }

    }

    // TypeToken: 0x2000003
    public struct CloseStatusCode
    {
        // Fields
        public System.UInt16 value__;        // 0x10
        public static UnityWebSocket.CloseStatusCode Unknown;        // 0x0
        public static UnityWebSocket.CloseStatusCode Normal;        // 0x0
        public static UnityWebSocket.CloseStatusCode Away;        // 0x0
        public static UnityWebSocket.CloseStatusCode ProtocolError;        // 0x0
        public static UnityWebSocket.CloseStatusCode UnsupportedData;        // 0x0
        public static UnityWebSocket.CloseStatusCode Undefined;        // 0x0
        public static UnityWebSocket.CloseStatusCode NoStatus;        // 0x0
        public static UnityWebSocket.CloseStatusCode Abnormal;        // 0x0
        public static UnityWebSocket.CloseStatusCode InvalidData;        // 0x0
        public static UnityWebSocket.CloseStatusCode PolicyViolation;        // 0x0
        public static UnityWebSocket.CloseStatusCode TooBig;        // 0x0
        public static UnityWebSocket.CloseStatusCode MandatoryExtension;        // 0x0
        public static UnityWebSocket.CloseStatusCode ServerError;        // 0x0
        public static UnityWebSocket.CloseStatusCode TlsHandshakeFailure;        // 0x0

    }

    // TypeToken: 0x2000004
    public class ErrorEventArgs : EventArgs
    {
        // Fields
        private System.Exception <Exception>k__BackingField;        // 0x10
        private System.String <Message>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception exception) { }
        private System.Exception get_Exception() { }
        private System.Void set_Exception(System.Exception value) { }
        private System.String get_Message() { }
        private System.Void set_Message(System.String value) { }

    }

    // TypeToken: 0x2000005
    public interface IWebSocket
    {
        // Methods
        private System.Void ConnectAsync() { }
        private System.Void CloseAsync() { }
        private System.Void SendAsync(System.Byte[] data) { }
        private System.Void SendAsync(System.String text) { }
        private System.String get_Address() { }
        private System.String[] get_SubProtocols() { }
        private UnityWebSocket.WebSocketState get_ReadyState() { }
        private System.String get_BinaryType() { }
        private System.Void set_BinaryType(System.String value) { }
        private System.Void add_OnOpen(System.EventHandler<UnityWebSocket.OpenEventArgs> value) { }
        private System.Void remove_OnOpen(System.EventHandler<UnityWebSocket.OpenEventArgs> value) { }
        private System.Void add_OnClose(System.EventHandler<UnityWebSocket.CloseEventArgs> value) { }
        private System.Void remove_OnClose(System.EventHandler<UnityWebSocket.CloseEventArgs> value) { }
        private System.Void add_OnError(System.EventHandler<UnityWebSocket.ErrorEventArgs> value) { }
        private System.Void remove_OnError(System.EventHandler<UnityWebSocket.ErrorEventArgs> value) { }
        private System.Void add_OnMessage(System.EventHandler<UnityWebSocket.MessageEventArgs> value) { }
        private System.Void remove_OnMessage(System.EventHandler<UnityWebSocket.MessageEventArgs> value) { }

    }

    // TypeToken: 0x2000006
    public class MessageEventArgs : EventArgs
    {
        // Fields
        private System.Byte[] _rawData;        // 0x10
        private System.String _data;        // 0x18
        private UnityWebSocket.Opcode <Opcode>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(UnityWebSocket.Opcode opcode, System.Byte[] rawData) { }
        private System.Void .ctor(UnityWebSocket.Opcode opcode, System.String data) { }
        private UnityWebSocket.Opcode get_Opcode() { }
        private System.Void set_Opcode(UnityWebSocket.Opcode value) { }
        private System.String get_Data() { }
        private System.Byte[] get_RawData() { }
        private System.Boolean get_IsBinary() { }
        private System.Boolean get_IsText() { }
        private System.Void SetData() { }
        private System.Void SetRawData() { }

    }

    // TypeToken: 0x2000007
    public struct Opcode
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityWebSocket.Opcode Text;        // 0x0
        public static UnityWebSocket.Opcode Binary;        // 0x0
        public static UnityWebSocket.Opcode Close;        // 0x0

    }

    // TypeToken: 0x2000008
    public class OpenEventArgs : EventArgs
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class Settings
    {
        // Fields
        public static System.String GITHUB;        // 0x0
        public static System.String QQ_GROUP;        // 0x0
        public static System.String QQ_GROUP_LINK;        // 0x0
        public static System.String EMAIL;        // 0x0
        public static System.String AUHTOR;        // 0x0
        public static System.String VERSION;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct WebSocketState
    {
        // Fields
        public System.UInt16 value__;        // 0x10
        public static UnityWebSocket.WebSocketState Connecting;        // 0x0
        public static UnityWebSocket.WebSocketState Open;        // 0x0
        public static UnityWebSocket.WebSocketState Closing;        // 0x0
        public static UnityWebSocket.WebSocketState Closed;        // 0x0

    }

    // TypeToken: 0x200000B
    public class WebSocket, IWebSocket
    {
        // Fields
        private System.String <Address>k__BackingField;        // 0x10
        private System.String[] <SubProtocols>k__BackingField;        // 0x18
        private System.String <BinaryType>k__BackingField;        // 0x20
        private System.EventHandler<UnityWebSocket.OpenEventArgs> OnOpen;        // 0x28
        private System.EventHandler<UnityWebSocket.CloseEventArgs> OnClose;        // 0x30
        private System.EventHandler<UnityWebSocket.ErrorEventArgs> OnError;        // 0x38
        private System.EventHandler<UnityWebSocket.MessageEventArgs> OnMessage;        // 0x40
        private System.Net.WebSockets.ClientWebSocket socket;        // 0x48
        private System.Object sendQueueLock;        // 0x50
        private System.Collections.Generic.Queue<UnityWebSocket.WebSocket.SendBuffer> sendQueue;        // 0x58
        private System.Boolean isSendTaskRunning;        // 0x60
        private readonly System.Collections.Generic.Queue<System.EventArgs> eventQueue;        // 0x68
        private readonly System.Object eventQueueLock;        // 0x70

        // Methods
        private System.String get_Address() { }
        private System.Void set_Address(System.String value) { }
        private System.String[] get_SubProtocols() { }
        private System.Void set_SubProtocols(System.String[] value) { }
        private UnityWebSocket.WebSocketState get_ReadyState() { }
        private System.String get_BinaryType() { }
        private System.Void set_BinaryType(System.String value) { }
        private System.Void add_OnOpen(System.EventHandler<UnityWebSocket.OpenEventArgs> value) { }
        private System.Void remove_OnOpen(System.EventHandler<UnityWebSocket.OpenEventArgs> value) { }
        private System.Void add_OnClose(System.EventHandler<UnityWebSocket.CloseEventArgs> value) { }
        private System.Void remove_OnClose(System.EventHandler<UnityWebSocket.CloseEventArgs> value) { }
        private System.Void add_OnError(System.EventHandler<UnityWebSocket.ErrorEventArgs> value) { }
        private System.Void remove_OnError(System.EventHandler<UnityWebSocket.ErrorEventArgs> value) { }
        private System.Void add_OnMessage(System.EventHandler<UnityWebSocket.MessageEventArgs> value) { }
        private System.Void remove_OnMessage(System.EventHandler<UnityWebSocket.MessageEventArgs> value) { }
        private System.Boolean get_isOpening() { }
        private System.Void .ctor(System.String address) { }
        private System.Void .ctor(System.String address, System.String subProtocol) { }
        private System.Void .ctor(System.String address, System.String[] subProtocols) { }
        private System.Void ConnectAsync() { }
        private System.Void CloseAsync() { }
        private System.Void SendAsync(System.Byte[] data) { }
        private System.Void SendAsync(System.String text) { }
        private System.Threading.Tasks.Task ConnectTask() { }
        private System.Void SendBufferAsync(UnityWebSocket.WebSocket.SendBuffer buffer) { }
        private System.Threading.Tasks.Task SendTask() { }
        private System.Threading.Tasks.Task ReceiveTask() { }
        private System.Void SocketDispose() { }
        private System.Void HandleOpen() { }
        private System.Void HandleMessage(UnityWebSocket.Opcode opcode, System.Byte[] rawData) { }
        private System.Void HandleClose(System.UInt16 code, System.String reason) { }
        private System.Void HandleError(System.Exception exception) { }
        private System.Void HandleEventSync(System.EventArgs eventArgs) { }
        private System.Void Update() { }
        private System.Void Log(System.String msg) { }

    }

    // TypeToken: 0x2000010
    public class WebSocketManager : MonoBehaviour
    {
        // Fields
        private static System.String rootName;        // 0x0
        private static UnityWebSocket.WebSocketManager _instance;        // 0x0
        private readonly System.Collections.Generic.List<UnityWebSocket.WebSocket> sockets;        // 0x18

        // Methods
        private UnityWebSocket.WebSocketManager get_Instance() { }
        private System.Void Awake() { }
        private System.Void CreateInstance() { }
        private System.Void Add(UnityWebSocket.WebSocket socket) { }
        private System.Void Remove(UnityWebSocket.WebSocket socket) { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

}

