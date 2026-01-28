// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.SpeedTest.dll
// Classes:  33
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: __StaticArrayInitTypeSize=16
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=32
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
METHODS:
END_CLASS

CLASS: Hypergryph.SpeedTest.EventLogWrapper
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static readonly Hypergryph.SpeedTest.EventLogWrapper_instance  // 0x0
  private           System.String                   _appId  // 0x10
  private           System.String                   _gameVersion  // 0x18
METHODS:
  System.Void .ctor()
  Hypergryph.SpeedTest.EventLogWrapper get_Instance()
  System.Void init()
  System.Void EventTrack(System.String name, System.Collections.Generic.Dictionary<System.String,System.Object> data)
  System.Threading.Tasks.Task ExecuteEventTrackSafely(System.String name, System.Collections.Generic.Dictionary<System.String,System.Object> data)
  System.Void .cctor()
END_CLASS

CLASS: Hypergryph.SpeedTest.HGSpeedTestSDKVersion
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  public    static readonly System.String                   VERSION  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Hypergryph.SpeedTest.SpeedTestServerInfo
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  public            System.String                   host  // 0x10
  public            System.String                   name  // 0x18
METHODS:
  System.Void .ctor(System.String host, System.String name)
END_CLASS

CLASS: Hypergryph.SpeedTest.TaskResult
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    taskCode  // 0x10
  public            System.String                   message  // 0x18
METHODS:
  System.Void .ctor(System.Int32 code, System.String message)
END_CLASS

CLASS: Hypergryph.SpeedTest.SpeedTestResult
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  public            System.String                   host  // 0x10
  public            System.String                   name  // 0x18
  public            System.Int32                    latency  // 0x20
  public            System.Int32                    resultCode  // 0x24
METHODS:
  System.Void .ctor(System.Int32 resultCode, System.Int32 latency, Hypergryph.SpeedTest.SpeedTestServerInfo server)
END_CLASS

CLASS: Hypergryph.SpeedTest.SpeedTestProtocol
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Hypergryph.SpeedTest.SpeedTestProtocolTCP  // 0x0
  public    static  Hypergryph.SpeedTest.SpeedTestProtocolUDP  // 0x0
METHODS:
END_CLASS

CLASS: Hypergryph.SpeedTest.HGSpeedTestSDK
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  private   static readonly Hypergryph.SpeedTest.HGSpeedTestSDK_instance  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Net.Sockets.TcpClient>_connections  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Net.Sockets.NetworkStream>_streams  // 0x18
  private   readonly System.Object                   _lockObject  // 0x20
  private           System.Threading.CancellationTokenSourcects  // 0x28
  private           System.Int64                    _packetIndex  // 0x30
  private           System.Boolean                  _isInSpeedTest  // 0x38
METHODS:
  System.Void .ctor()
  Hypergryph.SpeedTest.HGSpeedTestSDK GetInstance()
  System.Threading.Tasks.Task OnApplicationPause(System.Boolean pauseStatus)
  System.Threading.Tasks.Task<Hypergryph.SpeedTest.TaskResult> StartSpeedTest(System.Collections.Generic.List<Hypergryph.SpeedTest.SpeedTestServerInfo> serverList, System.Action<Hypergryph.SpeedTest.SpeedTestResult> callback, System.Int32 round, Hypergryph.SpeedTest.SpeedTestProtocol protocol)
  System.Void OnSpeedTestStart()
  Hypergryph.SpeedTest.TaskResult OnSpeedTaskResult(System.Int32 code, System.String message)
  System.Void NotifyRoundResult(System.Action<Hypergryph.SpeedTest.SpeedTestResult> callback, System.Int32 code, System.Int32 latency, Hypergryph.SpeedTest.SpeedTestServerInfo server)
  System.Void CleanupConnections()
  System.Void TestServerLatency(Hypergryph.SpeedTest.SpeedTestServerInfo server, System.Action<Hypergryph.SpeedTest.SpeedTestResult> callback, System.Int32 round, Hypergryph.SpeedTest.SpeedTestProtocol protocol, System.Threading.CancellationToken cancellationToken)
  System.Int32 EstablishConnection(Hypergryph.SpeedTest.SpeedTestServerInfo server)
  Hypergryph.SpeedTest.SpeedTestResult TestTcpLatency(Hypergryph.SpeedTest.SpeedTestServerInfo server, System.Collections.Generic.List<System.Int64> serverLatencyList, System.Threading.CancellationToken cancellationToken)
  System.Int64 SendTcpPackage(System.Net.Sockets.NetworkStream stream)
  System.Byte[] CreateTcpPacket()
  System.Int64 GetP50(System.Collections.Generic.List<System.Int64> latencies)
  System.Void .cctor()
END_CLASS

CLASS: Hypergryph.SpeedTest.NativeConfigLoader
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private   static  Hypergryph.SpeedTest.NativeConfigLoaderinstance  // 0x0
  private           System.String                   region  // 0x10
  private           System.String                   appDataPath  // 0x18
  private           System.String                   _gameVersion  // 0x20
METHODS:
  System.Void .ctor()
  System.Threading.Tasks.Task init()
  Hypergryph.SpeedTest.NativeConfigLoader GetInstance()
  System.String GetGameVersion()
  System.String GetRegion()
  System.String GetRegionFromConfig()
  System.String ReadWinConfig()
  System.Void .cctor()
  System.String <init>b__7_0()
END_CLASS

CLASS: Hypergryph.SpeedTest.SpeedTestLogger
TYPE:  class
TOKEN: 0x2000017
FIELDS:
METHODS:
  System.Void Debug(System.String message)
  System.Void Error(System.String message)
  System.Void PrintLogToView(System.String logInfo)
END_CLASS

CLASS: Hypergryph.SpeedTest.UnityMainThread
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  private   static  System.Threading.SynchronizationContextMainContext  // 0x0
  public    static  System.Boolean                  isDebug  // 0x8
METHODS:
  System.Void Init()
  System.Void RunOnMainThread(System.Action action)
  System.Threading.Tasks.Task<T> RunOnMainThread(System.Func<T> func)
  System.Threading.Tasks.Task<System.Boolean> isAppFocused()
END_CLASS

CLASS: Hypergryph.SpeedTest.WinConfigParser
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  private   static readonly System.Byte[]                   iv  // 0x0
  private   static readonly System.Byte[]                   aes_key  // 0x8
  private   static readonly System.String                   public_key_str  // 0x10
METHODS:
  System.String ParseEncryptionFile(System.String encryptionfile, System.String verifyfile)
  System.String DecryptConfig(System.Byte[] encryptedData, System.Byte[] key, System.Byte[] iv)
  System.Boolean VerifySignature(System.String data, System.String sign)
  System.Void ImportRsaPublicKeyManually(System.Security.Cryptography.RSACryptoServiceProvider rsa, System.Byte[] publicKeyBytes)
  System.Byte[] ExtractPublicKeyFromPem(System.String pemString)
  System.Void .cctor()
END_CLASS

