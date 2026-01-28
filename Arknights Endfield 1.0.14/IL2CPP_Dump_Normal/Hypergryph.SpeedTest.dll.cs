// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.SpeedTest.dll
// Classes:  33
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000020
    public struct __StaticArrayInitTypeSize=16
    {
    }

    // TypeToken: 0x2000021
    public struct __StaticArrayInitTypeSize=32
    {
    }

namespace Hypergryph.SpeedTest
{

    // TypeToken: 0x2000002
    public class EventLogWrapper
    {
        // Fields
        private static readonly Hypergryph.SpeedTest.EventLogWrapper _instance;        // 0x0
        private System.String _appId;        // 0x10
        private System.String _gameVersion;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private Hypergryph.SpeedTest.EventLogWrapper get_Instance() { }
        private System.Void init() { }
        private System.Void EventTrack(System.String name, System.Collections.Generic.Dictionary<System.String,System.Object> data) { }
        private System.Threading.Tasks.Task ExecuteEventTrackSafely(System.String name, System.Collections.Generic.Dictionary<System.String,System.Object> data) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000009
    public class HGSpeedTestSDKVersion
    {
        // Fields
        public static readonly System.String VERSION;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000A
    public class SpeedTestServerInfo
    {
        // Fields
        public System.String host;        // 0x10
        public System.String name;        // 0x18

        // Methods
        private System.Void .ctor(System.String host, System.String name) { }

    }

    // TypeToken: 0x200000B
    public class TaskResult
    {
        // Fields
        public System.Int32 taskCode;        // 0x10
        public System.String message;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 code, System.String message) { }

    }

    // TypeToken: 0x200000C
    public class SpeedTestResult
    {
        // Fields
        public System.String host;        // 0x10
        public System.String name;        // 0x18
        public System.Int32 latency;        // 0x20
        public System.Int32 resultCode;        // 0x24

        // Methods
        private System.Void .ctor(System.Int32 resultCode, System.Int32 latency, Hypergryph.SpeedTest.SpeedTestServerInfo server) { }

    }

    // TypeToken: 0x200000D
    public struct SpeedTestProtocol
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Hypergryph.SpeedTest.SpeedTestProtocol TCP;        // 0x0
        public static Hypergryph.SpeedTest.SpeedTestProtocol UDP;        // 0x0

    }

    // TypeToken: 0x200000E
    public class HGSpeedTestSDK
    {
        // Fields
        private static readonly Hypergryph.SpeedTest.HGSpeedTestSDK _instance;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.String,System.Net.Sockets.TcpClient> _connections;        // 0x10
        private readonly System.Collections.Generic.Dictionary<System.String,System.Net.Sockets.NetworkStream> _streams;        // 0x18
        private readonly System.Object _lockObject;        // 0x20
        private System.Threading.CancellationTokenSource cts;        // 0x28
        private System.Int64 _packetIndex;        // 0x30
        private System.Boolean _isInSpeedTest;        // 0x38

        // Methods
        private System.Void .ctor() { }
        private Hypergryph.SpeedTest.HGSpeedTestSDK GetInstance() { }
        private System.Threading.Tasks.Task OnApplicationPause(System.Boolean pauseStatus) { }
        private System.Threading.Tasks.Task<Hypergryph.SpeedTest.TaskResult> StartSpeedTest(System.Collections.Generic.List<Hypergryph.SpeedTest.SpeedTestServerInfo> serverList, System.Action<Hypergryph.SpeedTest.SpeedTestResult> callback, System.Int32 round, Hypergryph.SpeedTest.SpeedTestProtocol protocol) { }
        private System.Void OnSpeedTestStart() { }
        private Hypergryph.SpeedTest.TaskResult OnSpeedTaskResult(System.Int32 code, System.String message) { }
        private System.Void NotifyRoundResult(System.Action<Hypergryph.SpeedTest.SpeedTestResult> callback, System.Int32 code, System.Int32 latency, Hypergryph.SpeedTest.SpeedTestServerInfo server) { }
        private System.Void CleanupConnections() { }
        private System.Void TestServerLatency(Hypergryph.SpeedTest.SpeedTestServerInfo server, System.Action<Hypergryph.SpeedTest.SpeedTestResult> callback, System.Int32 round, Hypergryph.SpeedTest.SpeedTestProtocol protocol, System.Threading.CancellationToken cancellationToken) { }
        private System.Int32 EstablishConnection(Hypergryph.SpeedTest.SpeedTestServerInfo server) { }
        private Hypergryph.SpeedTest.SpeedTestResult TestTcpLatency(Hypergryph.SpeedTest.SpeedTestServerInfo server, System.Collections.Generic.List<System.Int64> serverLatencyList, System.Threading.CancellationToken cancellationToken) { }
        private System.Int64 SendTcpPackage(System.Net.Sockets.NetworkStream stream) { }
        private System.Byte[] CreateTcpPacket() { }
        private System.Int64 GetP50(System.Collections.Generic.List<System.Int64> latencies) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000015
    public class NativeConfigLoader
    {
        // Fields
        private static Hypergryph.SpeedTest.NativeConfigLoader instance;        // 0x0
        private System.String region;        // 0x10
        private System.String appDataPath;        // 0x18
        private System.String _gameVersion;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Threading.Tasks.Task init() { }
        private Hypergryph.SpeedTest.NativeConfigLoader GetInstance() { }
        private System.String GetGameVersion() { }
        private System.String GetRegion() { }
        private System.String GetRegionFromConfig() { }
        private System.String ReadWinConfig() { }
        private System.Void .cctor() { }
        private System.String <init>b__7_0() { }

    }

    // TypeToken: 0x2000017
    public class SpeedTestLogger
    {
        // Methods
        private System.Void Debug(System.String message) { }
        private System.Void Error(System.String message) { }
        private System.Void PrintLogToView(System.String logInfo) { }

    }

    // TypeToken: 0x2000019
    public class UnityMainThread
    {
        // Fields
        private static System.Threading.SynchronizationContext MainContext;        // 0x0
        public static System.Boolean isDebug;        // 0x8

        // Methods
        private System.Void Init() { }
        private System.Void RunOnMainThread(System.Action action) { }
        private System.Threading.Tasks.Task<T> RunOnMainThread(System.Func<T> func) { }
        private System.Threading.Tasks.Task<System.Boolean> isAppFocused() { }

    }

    // TypeToken: 0x200001E
    public class WinConfigParser
    {
        // Fields
        private static readonly System.Byte[] iv;        // 0x0
        private static readonly System.Byte[] aes_key;        // 0x8
        private static readonly System.String public_key_str;        // 0x10

        // Methods
        private System.String ParseEncryptionFile(System.String encryptionfile, System.String verifyfile) { }
        private System.String DecryptConfig(System.Byte[] encryptedData, System.Byte[] key, System.Byte[] iv) { }
        private System.Boolean VerifySignature(System.String data, System.String sign) { }
        private System.Void ImportRsaPublicKeyManually(System.Security.Cryptography.RSACryptoServiceProvider rsa, System.Byte[] publicKeyBytes) { }
        private System.Byte[] ExtractPublicKeyFromPem(System.String pemString) { }
        private System.Void .cctor() { }

    }

}

