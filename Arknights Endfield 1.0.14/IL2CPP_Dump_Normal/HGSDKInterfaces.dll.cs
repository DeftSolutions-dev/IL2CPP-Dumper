// ========================================================
// Dumped by @desirepro
// Assembly: HGSDKInterfaces.dll
// Classes:  34
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public struct CSLogSeverity
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CSLogSeverity LogSilent;        // 0x0
        public static CSLogSeverity LogError;        // 0x0
        public static CSLogSeverity LogWarning;        // 0x0
        public static CSLogSeverity LogInfo;        // 0x0
        public static CSLogSeverity LogDebug;        // 0x0
        public static CSLogSeverity LogVerbose;        // 0x0

    }

    // TypeToken: 0x2000003
    public struct CSReportType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CSReportType InterfaceReport;        // 0x0
        public static CSReportType LogCallback;        // 0x0
        public static CSReportType LogCallbackThreaded;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct JankReportInfoOption
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static JankReportInfoOption JankOnlyBasicInfo;        // 0x0
        public static JankReportInfoOption JankSystemLog;        // 0x0
        public static JankReportInfoOption JankCustomLog;        // 0x0
        public static JankReportInfoOption JankCustomKv;        // 0x0
        public static JankReportInfoOption JankCallbackInfo;        // 0x0
        public static JankReportInfoOption JankAutoDumpStack;        // 0x0
        public static JankReportInfoOption JankAndroidAllJavaStack;        // 0x0

    }

    // TypeToken: 0x2000006
    public class HGCrashSightCallback : CrashSightCallback
    {
        // Methods
        private System.String OnCrashBaseRetEvent(System.Int32 methodId, System.Int32 crashType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class HGCrashSightLogCallback : CrashSightLogCallback
    {
        // Methods
        private System.String OnSetLogPathEvent(System.Int32 methodId, System.Int32 crashType) { }
        private System.Void OnLogUploadResultEvent(System.Int32 methodId, System.Int32 crashType, System.Int32 result) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class LogCallbackDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String condition, System.String stackTrace, UnityEngine.LogType type) { }
        private System.IAsyncResult BeginInvoke(System.String condition, System.String stackTrace, UnityEngine.LogType type, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000009
    public class LogFilterDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.String condition, System.String stackTrace, UnityEngine.LogType type) { }
        private System.IAsyncResult BeginInvoke(System.String condition, System.String stackTrace, UnityEngine.LogType type, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000005
    public class CrashSightAgent
    {
        // Fields
        private static CrashSightAgent.HGCrashSightCallback _crashSightCallback;        // 0x0
        private static CrashSightAgent.HGCrashSightLogCallback _crashSightLogCallback;        // 0x8
        private static System.String crashUploadUrl;        // 0x10
        public static System.Collections.Generic.List<System.Int32> callbackThreads;        // 0x18
        public static System.Object callbackThreadsLock;        // 0x20
        private static CrashSightAgent.LogCallbackDelegate _LogCallbackEventHandler;        // 0x28
        private static CrashSightAgent.LogFilterDelegate s_logFilter;        // 0x30
        private static System.Boolean _isInitialized;        // 0x38
        private static UnityEngine.LogType _autoReportLogLevel;        // 0x3C
        private static System.Boolean _debugMode;        // 0x40
        private static System.Boolean _autoQuitApplicationAfterReport;        // 0x41
        private static System.Func<System.Collections.Generic.Dictionary<System.String,System.String>> _LogCallbackExtrasHandler;        // 0x48
        private static System.Boolean _uncaughtAutoReportOnce;        // 0x50
        public static readonly System.String s_UnityBuildVersion;        // 0x58
        public static readonly System.String s_CommandLine;        // 0x60
        public static readonly System.String s_UserName;        // 0x68
        public static readonly System.String s_UserDomainName;        // 0x70
        public static readonly System.String s_DeviceModel;        // 0x78
        public static readonly System.String s_DeviceName;        // 0x80
        public static readonly System.String s_DeviceUniqueIdentifier;        // 0x88
        public static readonly System.String s_DeviceType;        // 0x90
        public static readonly System.String s_GraphicsDeviceName;        // 0x98
        public static readonly System.String s_GraphicsDeviceType;        // 0xA0
        public static readonly System.String s_GraphicsDeviceVersion;        // 0xA8
        public static readonly System.String s_GraphicsDeviceVendor;        // 0xB0
        public static readonly System.Int32 s_GraphicsMemorySize;        // 0xB8
        public static readonly System.String s_NvidiaDriverVersion;        // 0xC0
        public static readonly System.String[] s_BootParams;        // 0xC8
        public static readonly System.String s_SOCModel;        // 0xD0

        // Methods
        private System.Void add__LogCallbackEventHandler(CrashSightAgent.LogCallbackDelegate value) { }
        private System.Void remove__LogCallbackEventHandler(CrashSightAgent.LogCallbackDelegate value) { }
        private System.Void SetLogFilter(CrashSightAgent.LogFilterDelegate filter) { }
        private System.Void InitWithAppId(System.String appId, System.Boolean forceOnUiThread) { }
        private System.Void ReportException(System.Exception e, System.String message) { }
        private System.Void ReportException(System.String name, System.String message, System.String stackTrace) { }
        private System.Void ReportException(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String errorAttachmentPath) { }
        private System.Void SetUserId(System.String userId) { }
        private System.Void AddSceneData(System.String key, System.String value) { }
        private System.Void SetUserValue(System.String key, System.Int32 value) { }
        private System.Void SetUserValue(System.String key, System.String value) { }
        private System.Void SetUserValue(System.String key, System.String[] value) { }
        private System.Void SetAppVersion(System.String appVersion) { }
        private System.Void ConfigCrashServerUrl(System.String crashServerUrl) { }
        private System.Void SetLogPath(System.String logPath) { }
        private System.Void ConfigDebugMode(System.Boolean enable) { }
        private System.Void SetDeviceId(System.String deviceId) { }
        private System.Void ConfigCrashReporter(System.Int32 logLevel) { }
        private System.Void ConfigCrashReporter(CSLogSeverity logLevel) { }
        private System.Void PrintLog(CSLogSeverity level, System.String format, System.Object[] args) { }
        private System.Void TestNativeCrash() { }
        private System.Void SetEnvironmentName(System.String serverEnv) { }
        private System.Void EnableAnrMonitor(System.Int32 timeoutMs) { }
        private System.Void DisableAnrMonitor() { }
        private System.Void RegisterCrashCallback(CrashSightCallback callback) { }
        private System.Void UnregisterCrashCallback() { }
        private System.Void RegisterCrashLogCallback(CrashSightLogCallback callback) { }
        private System.Void EnableExceptionHandler() { }
        private System.Void RegisterLogCallback(CrashSightAgent.LogCallbackDelegate handler) { }
        private System.Void UnregisterLogCallback(CrashSightAgent.LogCallbackDelegate handler) { }
        private System.Void SetLogCallbackExtrasHandler(System.Func<System.Collections.Generic.Dictionary<System.String,System.String>> handler) { }
        private System.Void ConfigAutoQuitApplication(System.Boolean autoQuit) { }
        private System.Boolean get_AutoQuitApplicationAfterReport() { }
        private System.Void DebugLog(System.String tag, System.String format) { }
        private System.Boolean get_IsInitialized() { }
        private System.Void _RegisterExceptionHandler() { }
        private System.Void _UnregisterExceptionHandler() { }
        private System.Void SetCrashSightStackTraceEnable(System.Boolean enable) { }
        private System.Void ConfigCallbackType(System.Int32 callbackType) { }
        private System.Void SetDeviceModel(System.String deviceModel) { }
        private System.Void ReportLogInfo(System.String msgType, System.String msg) { }
        private System.Void SetScene(System.String sceneId, System.Boolean upload) { }
        private System.Void SetScene(System.Int32 sceneId, System.Boolean upload) { }
        private System.Int64 GetCrashThreadId() { }
        private System.Void SetCustomizedDeviceID(System.String deviceId) { }
        private System.String GetSDKDefinedDeviceID() { }
        private System.Void SetCustomizedMatchID(System.String matchId) { }
        private System.String GetSDKSessionID() { }
        private System.Void TestOomCrash() { }
        private System.Void TestJavaCrash() { }
        private System.Void TestANR() { }
        private System.String GetCrashUuid() { }
        private System.Void SetLogcatBufferSize(System.Int32 size) { }
        private System.Void TestOcCrash() { }
        private System.Void StartDumpRoutine(System.Int32 dumpMode, System.Int32 startTimeMode, System.Int64 startTime, System.Int64 dumpInterval, System.Int32 dumpTimes, System.Boolean saveLocal, System.String savePath) { }
        private System.Void StartMonitorFdCount(System.Int32 interval, System.Int32 limit, System.Int32 dumpType) { }
        private System.Int32 getExceptionType(System.String name) { }
        private System.Void TestUseAfterFree() { }
        private System.Void ReRegistAllMonitors() { }
        private System.Void CloseAllMonitors() { }
        private System.Void setEnableGetPackageInfo(System.Boolean enable) { }
        private System.Void setCatchMultiSignal(System.Boolean enable) { }
        private System.Void enableDetailedPageTracing(System.Boolean enable) { }
        private System.Boolean IsLastSessionCrash() { }
        private System.String GetLastSessionUserId() { }
        private System.Boolean CheckFdCount(System.Int32 limit, System.Int32 dumpType, System.Boolean upload) { }
        private System.Void SetOomLogPath(System.String logPath) { }
        private System.Void ReportJank(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.String paramsJson, System.Int32 reportInfoOption, System.String jankAttachmentPath) { }
        private System.Void ReportStuck(System.Int32 threadId, System.Int32 maxChecks, System.Int64 checkInterval, System.String name, System.String message, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String attachPath) { }
        private System.Void SetVehEnable(System.Boolean enable) { }
        private System.Void ReportCrash() { }
        private System.Void ReportDump(System.String dump_path, System.Boolean is_async) { }
        private System.Void SetExtraHandler(System.Boolean extra_handle_enable) { }
        private System.Void UploadGivenPathDump(System.String dump_dir, System.Boolean is_extra_check) { }
        private System.Void SetDumpType(System.Int32 dump_type) { }
        private System.Void AddValidExpCode(System.UInt64 exp_code) { }
        private System.Void UploadCrashWithGuid(System.String guid) { }
        private System.Void SetCrashUploadEnable(System.Boolean enable) { }
        private System.Void SetWorkSpace(System.String workspace) { }
        private System.Void SetCustomAttachDir(System.String path) { }
        private System.Void SetErrorUploadInterval(System.Int32 interval) { }
        private System.Void SetErrorUploadEnable(System.Boolean enable) { }
        private System.Void SetRecordFileDir(System.String record_dir) { }
        private System.Void InitContext(System.String userId, System.String version, System.String key) { }
        private System.Void Init(System.String app_id, System.String app_key, System.String app_version) { }
        private System.Void ConfigDefault(System.String channel, System.String version, System.String user, System.Int64 delay) { }
        private System.Void _OnLogCallbackHandlerMain(System.String condition, System.String stackTrace, UnityEngine.LogType type) { }
        private System.Void _OnLogCallbackHandlerThreaded(System.String condition, System.String stackTrace, UnityEngine.LogType type) { }
        private System.Void _OnLogCallbackHandler(System.String condition, System.String stackTrace, UnityEngine.LogType type, CSReportType rType) { }
        private System.Void _OnUncaughtExceptionHandler(System.Object sender, System.UnhandledExceptionEventArgs args) { }
        private System.Void _HandleException(System.Exception e, System.String message, System.Boolean uncaught) { }
        private System.Boolean ShouldSkipFrame(System.String frame) { }
        private System.Void _reportException(System.Boolean uncaught, System.String name, System.String reason, System.String stackTrace) { }
        private System.Void AddTrackCustomData() { }
        private System.Void AddLocalLogFile() { }
        private System.Int32 valueOf(UnityEngine.LogType logLevel) { }
        private System.Boolean isEnableAutoReport(UnityEngine.LogType logLevel) { }
        private System.Void _HandleException(UnityEngine.LogType logLevel, System.String name, System.String message, System.String stackTrace, System.Boolean uncaught, CSReportType rType) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000A
    public class CrashSightAnrMonitor
    {
        // Fields
        private static CrashSightMonoBehaviour monoBehaviour;        // 0x0
        private static System.Int32 anrTimeoutMs;        // 0x8
        private static System.Int32 detectionTimeoutMs;        // 0xC
        private static System.Boolean <Paused>k__BackingField;        // 0x10
        private static System.Int32 ticksSinceUiUpdate;        // 0x14
        private static System.Boolean reported;        // 0x18
        private static System.Boolean running;        // 0x19
        private static System.Threading.Thread thread;        // 0x20

        // Methods
        private System.Boolean get_Paused() { }
        private System.Void set_Paused(System.Boolean value) { }
        private System.Void Start(System.Int32 timeoutMs) { }
        private System.Void Stop() { }
        private System.Collections.IEnumerator UpdateUiStatus() { }
        private System.Void Run() { }
        private System.Void Report() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public class UnityAnrException : Exception
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String message) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }

    }

    // TypeToken: 0x200000E
    public class CrashSightCallback
    {
        // Methods
        private System.String OnCrashBaseRetEvent(System.Int32 methodId, System.Int32 crashType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class CrashSightLogCallback
    {
        // Methods
        private System.String OnSetLogPathEvent(System.Int32 methodId, System.Int32 crashType) { }
        private System.Void OnLogUploadResultEvent(System.Int32 methodId, System.Int32 crashType, System.Int32 result) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public class CrashSightMonoBehaviour : MonoBehaviour
    {
        // Fields
        private static CrashSightMonoBehaviour _instance;        // 0x0
        private System.Action ApplicationResuming;        // 0x18
        private System.Action ApplicationPausing;        // 0x20
        private System.Action ApplicationQuitting;        // 0x28
        private System.Boolean _isRunning;        // 0x30

        // Methods
        private CrashSightMonoBehaviour get_Instance() { }
        private System.Void add_ApplicationResuming(System.Action value) { }
        private System.Void remove_ApplicationResuming(System.Action value) { }
        private System.Void add_ApplicationPausing(System.Action value) { }
        private System.Void remove_ApplicationPausing(System.Action value) { }
        private System.Void add_ApplicationQuitting(System.Action value) { }
        private System.Void remove_ApplicationQuitting(System.Action value) { }
        private System.Void UpdatePauseStatus(System.Boolean paused) { }
        private System.Void OnApplicationPause(System.Boolean pauseStatus) { }
        private System.Void OnApplicationFocus(System.Boolean hasFocus) { }
        private System.Void OnApplicationQuit() { }
        private System.Void Awake() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class CrashSightStackTrace
    {
        // Fields
        public static System.Boolean enable;        // 0x0
        private static System.String stackTrace;        // 0x8

        // Methods
        private System.Void setEnable(System.Boolean enable) { }
        private System.String ExtractStackTrace() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public struct Level
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static GCloud.UQM.UQMLog.Level None;        // 0x0
        public static GCloud.UQM.UQMLog.Level Log;        // 0x0
        public static GCloud.UQM.UQMLog.Level Warning;        // 0x0
        public static GCloud.UQM.UQMLog.Level Error;        // 0x0

    }

    // TypeToken: 0x200001E
    public class UQMRetJsonEventHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.String Invoke(System.Int32 methodId, System.Int32 callType, System.Int32 logUploadResult) { }
        private System.IAsyncResult BeginInvoke(System.Int32 methodId, System.Int32 callType, System.Int32 logUploadResult, System.AsyncCallback callback, System.Object object) { }
        private System.String EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000021
    public struct TOKEN
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN NONE;        // 0x0
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN CURLY_OPEN;        // 0x0
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN CURLY_CLOSE;        // 0x0
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN SQUARED_OPEN;        // 0x0
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN SQUARED_CLOSE;        // 0x0
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN COLON;        // 0x0
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN COMMA;        // 0x0
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN STRING;        // 0x0
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN NUMBER;        // 0x0
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN TRUE;        // 0x0
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN FALSE;        // 0x0
        public static GCloud.UQM.MiniJSON.Json.Parser.TOKEN NULL;        // 0x0

    }

    // TypeToken: 0x2000020
    public class Parser, IDisposable
    {
        // Fields
        private static System.String WORD_BREAK;        // 0x0
        private System.IO.StringReader json;        // 0x10

        // Methods
        private System.Boolean IsWordBreak(System.Char c) { }
        private System.Void .ctor(System.String jsonString) { }
        private System.Object Parse(System.String jsonString) { }
        private System.Void Dispose() { }
        private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }
        private System.Collections.Generic.List<System.Object> ParseArray() { }
        private System.Object ParseValue() { }
        private System.Object ParseByToken(GCloud.UQM.MiniJSON.Json.Parser.TOKEN token) { }
        private System.String ParseString() { }
        private System.Object ParseNumber() { }
        private System.Void EatWhitespace() { }
        private System.Char get_PeekChar() { }
        private System.Char get_NextChar() { }
        private System.String get_NextWord() { }
        private GCloud.UQM.MiniJSON.Json.Parser.TOKEN get_NextToken() { }

    }

    // TypeToken: 0x2000022
    public class Serializer
    {
        // Fields
        private System.Text.StringBuilder builder;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.String Serialize(System.Object obj) { }
        private System.Void SerializeValue(System.Object value) { }
        private System.Void SerializeObject(System.Collections.IDictionary obj) { }
        private System.Void SerializeArray(System.Collections.IList anArray) { }
        private System.Void SerializeString(System.String str) { }
        private System.Void SerializeOther(System.Object value) { }

    }

namespace GCloud.UQM
{

    // TypeToken: 0x2000012
    public class OnUQMRetEventHandler`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T ret) { }
        private System.IAsyncResult BeginInvoke(T ret, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000013
    public class OnUQMStringRetEventHandler`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.String Invoke(T ret, T crashType) { }
        private System.IAsyncResult BeginInvoke(T ret, T crashType, System.AsyncCallback callback, System.Object object) { }
        private System.String EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000014
    public class OnUQMStringRetSetLogPathEventHandler`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.String Invoke(T ret, T crashType) { }
        private System.IAsyncResult BeginInvoke(T ret, T crashType, System.AsyncCallback callback, System.Object object) { }
        private System.String EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000015
    public class OnUQMRetLogUploadEventHandler`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T ret, T crashType, T result) { }
        private System.IAsyncResult BeginInvoke(T ret, T crashType, T result, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000016
    public class UQM
    {
        // Fields
        public static System.String LibName;        // 0x0
        private static System.Boolean initialized;        // 0x0
        public static System.Boolean isDebug;        // 0x1

        // Methods
        private System.Void Init() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000017
    public struct UQMCrashLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static GCloud.UQM.UQMCrashLevel CSLogLevelSilent;        // 0x0
        public static GCloud.UQM.UQMCrashLevel CSLogLevelError;        // 0x0
        public static GCloud.UQM.UQMCrashLevel CSLogLevelWarn;        // 0x0
        public static GCloud.UQM.UQMCrashLevel CSLogLevelInfo;        // 0x0
        public static GCloud.UQM.UQMCrashLevel CSLogLevelDebug;        // 0x0
        public static GCloud.UQM.UQMCrashLevel CSLogLevelVerbose;        // 0x0

    }

    // TypeToken: 0x2000018
    public class UQMCrash
    {
        // Fields
        private static GCloud.UQM.OnUQMStringRetEventHandler<System.Int32> CrashBaseRetEvent;        // 0x0
        private static GCloud.UQM.OnUQMStringRetSetLogPathEventHandler<System.Int32> CrashSetLogPathRetEvent;        // 0x8
        private static GCloud.UQM.OnUQMRetLogUploadEventHandler<System.Int32> CrashLogUploadRetEvent;        // 0x10
        private static UnityEngine.AndroidJavaClass _gameAgentClass;        // 0x18
        private static System.Boolean _isLoadedSo;        // 0x20
        private static System.Int32 _gameType;        // 0x24
        private static readonly System.String GAME_AGENT_CLASS;        // 0x28

        // Methods
        private System.Void CS_InitContext(System.String id, System.String version, System.String key) { }
        private System.Void CS_ReportExceptionW(System.Int32 type, System.String name, System.String message, System.String stack_trace, System.String extras, System.Boolean is_async, System.String attachmentPath) { }
        private System.Void CS_SetUserValue(System.String key, System.String value) { }
        private System.Void CS_SetVehEnable(System.Boolean enable) { }
        private System.Void CS_SetExtraHandler(System.Boolean extra_handle_enable) { }
        private System.Void CS_SetCustomLogDirW(System.String log_path) { }
        private System.Void CS_SetUserId(System.String user_id) { }
        private System.Void CS_MonitorEnable(System.Boolean enable) { }
        private System.Void CS_PrintLog(System.Int32 level, System.String tag, System.String format, System.String arg) { }
        private System.Void CS_UploadGivenPathDump(System.String dump_dir, System.Boolean is_extra_check) { }
        private System.Void CS_ReportCrash() { }
        private System.Void CS_ReportDump(System.String dump_dir, System.Boolean is_async) { }
        private System.Void CS_SetEnvironmentName(System.String name) { }
        private System.Void CS_InitWithAppId(System.String app_id) { }
        private System.Void CS_SetAppVersion(System.String app_version) { }
        private System.Void CS_ConfigCrashServerUrl(System.String crash_server_url) { }
        private System.Void CS_ConfigDebugMode(System.Boolean enable) { }
        private System.Void CS_SetDeviceId(System.String device_id) { }
        private System.Void CS_ConfigCrashReporter(System.Int32 log_level) { }
        private System.Void CS_TestNativeCrash() { }
        private System.Void CS_SetDumpType(System.Int32 dump_type) { }
        private System.Void CS_AddValidExpCode(System.UInt64 exp_code) { }
        private System.Void CS_UploadCrashWithGuid(System.String guid) { }
        private System.Void CS_SetCrashUploadEnable(System.Boolean enable) { }
        private System.Void CS_SetWorkSpaceW(System.String workspace) { }
        private System.Void CS_SetEngineInfo(System.String version, System.String buildConfig, System.String language, System.String locale) { }
        private System.Void CS_SetCustomAttachDirW(System.String log_path) { }
        private System.Void CS_UseSavedUserId(System.Boolean enable) { }
        private System.Void CS_ReportStuck(System.Int32 threadId, System.Int32 maxChecks, System.Int32 checkInterval, System.String name, System.String message, System.String extraInfo, System.Int32 dumpNativeType, System.String attachPath) { }
        private System.Void add_CrashBaseRetEvent(GCloud.UQM.OnUQMStringRetEventHandler<System.Int32> value) { }
        private System.Void remove_CrashBaseRetEvent(GCloud.UQM.OnUQMStringRetEventHandler<System.Int32> value) { }
        private System.Void add_CrashSetLogPathRetEvent(GCloud.UQM.OnUQMStringRetSetLogPathEventHandler<System.Int32> value) { }
        private System.Void remove_CrashSetLogPathRetEvent(GCloud.UQM.OnUQMStringRetSetLogPathEventHandler<System.Int32> value) { }
        private System.Void add_CrashLogUploadRetEvent(GCloud.UQM.OnUQMRetLogUploadEventHandler<System.Int32> value) { }
        private System.Void remove_CrashLogUploadRetEvent(GCloud.UQM.OnUQMRetLogUploadEventHandler<System.Int32> value) { }
        private UnityEngine.AndroidJavaClass get_CrashSightPlatform() { }
        private System.Void LoadCrashSightCoreSo() { }
        private System.Void ConfigCallbackType(System.Int32 callbackType) { }
        private System.Void ConfigGameType(System.Int32 gameType) { }
        private System.Void ConfigAutoReportLogLevel(System.Int32 level) { }
        private System.Void ConfigCrashServerUrl(System.String serverUrl) { }
        private System.Void ConfigDebugMode(System.Boolean enable) { }
        private System.Void ConfigDefault(System.String channel, System.String version, System.String user, System.Int64 delay) { }
        private System.Void InitWithAppId(System.String appId, System.Boolean forceOnUiThread) { }
        private System.Void InitContext(System.String userId, System.String version, System.String key) { }
        private System.Void LogRecord(System.Int32 level, System.String message) { }
        private System.Void AddSceneData(System.String k, System.String v) { }
        private System.Void ReportException(System.Int32 type, System.String name, System.String message, System.String stackTrace, System.String extras, System.Boolean quitProgram) { }
        private System.Void ReportException(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String errorAttachmentPath) { }
        private System.Void SetUserId(System.String userId) { }
        private System.Void SetScene(System.String sceneId, System.Boolean upload) { }
        private System.Void ReRegistAllMonitors() { }
        private System.Void CloseAllMonitors() { }
        private System.Void ReportLogInfo(System.String msgType, System.String msg) { }
        private System.Void SetAppVersion(System.String appVersion) { }
        private System.Void SetDeviceId(System.String deviceId) { }
        private System.Void SetCustomizedDeviceID(System.String deviceId) { }
        private System.String GetSDKDefinedDeviceID() { }
        private System.Void SetCustomizedMatchID(System.String matchId) { }
        private System.String GetSDKSessionID() { }
        private System.String GetCrashUuid() { }
        private System.Void SetDeviceModel(System.String deviceModel) { }
        private System.Void SetLogPath(System.String logPath) { }
        private System.Void SetCrashCallback() { }
        private System.Void UnsetCrashCallback() { }
        private System.Void SetCrashLogCallback() { }
        private System.String OnCrashCallbackMessage(System.Int32 methodId, System.Int32 crashType) { }
        private System.String OnCrashCallbackData(System.Int32 methodId, System.Int32 crashType) { }
        private System.String OnCrashSetLogPathMessage(System.Int32 methodId, System.Int32 crashType) { }
        private System.String OnCrashLogUploadMessage(System.Int32 methodId, System.Int32 crashType, System.Int32 result) { }
        private System.String OnCrashCallbackNoRet(System.Int32 methodId, System.Int32 crashType) { }
        private System.Void ConfigCallBack() { }
        private System.Void UnregisterCallBack() { }
        private System.Void ConfigLogCallBack() { }
        private System.Void TestOomCrash() { }
        private System.Void TestJavaCrash() { }
        private System.Void TestOcCrash() { }
        private System.Void TestNativeCrash() { }
        private System.Void TestANR() { }
        private System.Int64 GetCrashThreadId() { }
        private System.Void SetLogcatBufferSize(System.Int32 size) { }
        private System.Void SetCallbackMsg(System.String data) { }
        private System.Void StartDumpRoutine(System.Int32 dumpMode, System.Int32 startTimeMode, System.Int64 startTime, System.Int64 dumpInterval, System.Int32 dumpTimes, System.Boolean saveLocal, System.String savePath) { }
        private System.Void StartMonitorFdCount(System.Int32 interval, System.Int32 limit, System.Int32 dumpType) { }
        private System.Int32 getExceptionType(System.String name) { }
        private System.Void TestUseAfterFree() { }
        private System.Void SetServerEnv(System.String serverEnv) { }
        private System.Void SetVehEnable(System.Boolean enable) { }
        private System.Void ReportCrash() { }
        private System.Void ReportDump(System.String dump_path, System.Boolean is_async) { }
        private System.Void SetExtraHandler(System.Boolean extra_handle_enable) { }
        private System.Void UploadGivenPathDump(System.String dump_dir, System.Boolean is_extra_check) { }
        private System.Void SetErrorUploadInterval(System.Int32 interval) { }
        private System.Void SetErrorUploadEnable(System.Boolean enable) { }
        private System.Void SetRecordFileDir(System.String record_dir) { }
        private System.Void Init(System.String app_id, System.String app_key, System.String app_version) { }
        private System.Void setEnableGetPackageInfo(System.Boolean enable) { }
        private System.Void SetDumpType(System.Int32 dump_type) { }
        private System.Void AddValidExpCode(System.UInt64 exp_code) { }
        private System.Void UploadCrashWithGuid(System.String guid) { }
        private System.Void SetCrashUploadEnable(System.Boolean enable) { }
        private System.Void SetWorkSpace(System.String workspace) { }
        private System.Void SetEngineInfo(System.String version, System.String buildConfig, System.String language, System.String locale) { }
        private System.Void setCatchMultiSignal(System.Boolean enable) { }
        private System.Void enableDetailedPageTracing(System.Boolean enable) { }
        private System.Void useSavedUserId(System.Boolean enable) { }
        private System.Void SetCustomAttachDir(System.String path) { }
        private System.Boolean IsLastSessionCrash() { }
        private System.String GetLastSessionUserId() { }
        private System.Boolean CheckFdCount(System.Int32 limit, System.Int32 dumpType, System.Boolean upload) { }
        private System.Void SetOomLogPath(System.String logPath) { }
        private System.Void ReportJank(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.String paramsJson, System.Int32 reportInfoOption, System.String jankAttachmentPath) { }
        private System.Void ProcessEngineAnr(System.Int32 type) { }
        private System.Void SetEngineMainThread() { }
        private System.Void ReportStuck(System.Int32 threadId, System.Int32 maxChecks, System.Int64 checkInterval, System.String name, System.String message, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String attachPath) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000019
    public struct UQMMethodNameID
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static GCloud.UQM.UQMMethodNameID UQM_CRASH_CALLBACK_EXTRA_DATA;        // 0x0
        public static GCloud.UQM.UQMMethodNameID UQM_CRASH_CALLBACK_EXTRA_MESSAGE;        // 0x0
        public static GCloud.UQM.UQMMethodNameID UQM_CRASH_CALLBACK_SET_LOG_PATH;        // 0x0
        public static GCloud.UQM.UQMMethodNameID UQM_CRASH_CALLBACK_LOG_UPLOAD_RESULT;        // 0x0

    }

    // TypeToken: 0x200001A
    public class UQMLog
    {
        // Fields
        private static GCloud.UQM.UQMLog.Level level;        // 0x0
        private static System.String header;        // 0x0

        // Methods
        private System.Void SetLevel(GCloud.UQM.UQMLog.Level l) { }
        private System.Void Log(System.String message) { }
        private System.Void LogWarning(System.String message) { }
        private System.Void LogError(System.String message) { }
        private System.Void FullLog(System.String message) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001C
    public class RetArgsWrapper
    {
        // Fields
        private readonly System.Int32 methodId;        // 0x10
        private readonly System.Int32 crashType;        // 0x14
        private readonly System.Int32 logUploadResult;        // 0x18

        // Methods
        private System.Int32 get_MethodId() { }
        private System.Int32 get_CrashType() { }
        private System.Int32 get_LogUploadResult() { }
        private System.Void .ctor(System.Int32 _methodId, System.Int32 _crashType, System.Int32 _logUploadResult) { }

    }

    // TypeToken: 0x200001D
    public class UQMMessageCenter : MonoBehaviour
    {
        // Fields
        private static System.Boolean initialzed;        // 0x0
        private static GCloud.UQM.UQMMessageCenter instance;        // 0x8

        // Methods
        private System.String OnUQMRet(System.Int32 methodId, System.Int32 crashType, System.Int32 logUploadResult) { }
        private System.Void cs_setUnityCallback(GCloud.UQM.UQMMessageCenter.UQMRetJsonEventHandler eventHandler) { }
        private GCloud.UQM.UQMMessageCenter get_Instance() { }
        private System.Void Init() { }
        private System.Void Uninit() { }
        private System.String SynchronousDelegate(System.Object arg) { }
        private System.Void .ctor() { }

    }

}

namespace GCloud.UQM.MiniJSON
{

    // TypeToken: 0x200001F
    public class Json
    {
        // Methods
        private System.Object Deserialize(System.String json) { }
        private System.String Serialize(System.Object obj) { }

    }

}

