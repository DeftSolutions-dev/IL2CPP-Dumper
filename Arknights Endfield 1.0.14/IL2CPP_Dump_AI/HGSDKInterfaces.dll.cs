// ========================================================
// Dumped by @desirepro
// Assembly: HGSDKInterfaces.dll
// Classes:  34
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: CSLogSeverity
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CSLogSeverity                   LogSilent  // 0x0
  public    static  CSLogSeverity                   LogError  // 0x0
  public    static  CSLogSeverity                   LogWarning  // 0x0
  public    static  CSLogSeverity                   LogInfo  // 0x0
  public    static  CSLogSeverity                   LogDebug  // 0x0
  public    static  CSLogSeverity                   LogVerbose  // 0x0
METHODS:
END_CLASS

CLASS: CSReportType
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CSReportType                    InterfaceReport  // 0x0
  public    static  CSReportType                    LogCallback  // 0x0
  public    static  CSReportType                    LogCallbackThreaded  // 0x0
METHODS:
END_CLASS

CLASS: JankReportInfoOption
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  JankReportInfoOption            JankOnlyBasicInfo  // 0x0
  public    static  JankReportInfoOption            JankSystemLog  // 0x0
  public    static  JankReportInfoOption            JankCustomLog  // 0x0
  public    static  JankReportInfoOption            JankCustomKv  // 0x0
  public    static  JankReportInfoOption            JankCallbackInfo  // 0x0
  public    static  JankReportInfoOption            JankAutoDumpStack  // 0x0
  public    static  JankReportInfoOption            JankAndroidAllJavaStack  // 0x0
METHODS:
END_CLASS

CLASS: HGCrashSightCallback
TYPE:  class
TOKEN: 0x2000006
EXTENDS: CrashSightCallback
FIELDS:
METHODS:
  System.String OnCrashBaseRetEvent(System.Int32 methodId, System.Int32 crashType)
  System.Void .ctor()
END_CLASS

CLASS: HGCrashSightLogCallback
TYPE:  class
TOKEN: 0x2000007
EXTENDS: CrashSightLogCallback
FIELDS:
METHODS:
  System.String OnSetLogPathEvent(System.Int32 methodId, System.Int32 crashType)
  System.Void OnLogUploadResultEvent(System.Int32 methodId, System.Int32 crashType, System.Int32 result)
  System.Void .ctor()
END_CLASS

CLASS: LogCallbackDelegate
TYPE:  class
TOKEN: 0x2000008
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  System.IAsyncResult BeginInvoke(System.String condition, System.String stackTrace, UnityEngine.LogType type, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: LogFilterDelegate
TYPE:  class
TOKEN: 0x2000009
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  System.IAsyncResult BeginInvoke(System.String condition, System.String stackTrace, UnityEngine.LogType type, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: CrashSightAgent
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private   static  CrashSightAgent.HGCrashSightCallback_crashSightCallback  // 0x0
  private   static  CrashSightAgent.HGCrashSightLogCallback_crashSightLogCallback  // 0x8
  private   static  System.String                   crashUploadUrl  // 0x10
  public    static  System.Collections.Generic.List<System.Int32>callbackThreads  // 0x18
  public    static  System.Object                   callbackThreadsLock  // 0x20
  private   static  CrashSightAgent.LogCallbackDelegate_LogCallbackEventHandler  // 0x28
  private   static  CrashSightAgent.LogFilterDelegates_logFilter  // 0x30
  private   static  System.Boolean                  _isInitialized  // 0x38
  private   static  UnityEngine.LogType             _autoReportLogLevel  // 0x3C
  private   static  System.Boolean                  _debugMode  // 0x40
  private   static  System.Boolean                  _autoQuitApplicationAfterReport  // 0x41
  private   static  System.Func<System.Collections.Generic.Dictionary<System.String,System.String>>_LogCallbackExtrasHandler  // 0x48
  private   static  System.Boolean                  _uncaughtAutoReportOnce  // 0x50
  public    static readonly System.String                   s_UnityBuildVersion  // 0x58
  public    static readonly System.String                   s_CommandLine  // 0x60
  public    static readonly System.String                   s_UserName  // 0x68
  public    static readonly System.String                   s_UserDomainName  // 0x70
  public    static readonly System.String                   s_DeviceModel  // 0x78
  public    static readonly System.String                   s_DeviceName  // 0x80
  public    static readonly System.String                   s_DeviceUniqueIdentifier  // 0x88
  public    static readonly System.String                   s_DeviceType  // 0x90
  public    static readonly System.String                   s_GraphicsDeviceName  // 0x98
  public    static readonly System.String                   s_GraphicsDeviceType  // 0xA0
  public    static readonly System.String                   s_GraphicsDeviceVersion  // 0xA8
  public    static readonly System.String                   s_GraphicsDeviceVendor  // 0xB0
  public    static readonly System.Int32                    s_GraphicsMemorySize  // 0xB8
  public    static readonly System.String                   s_NvidiaDriverVersion  // 0xC0
  public    static readonly System.String[]                 s_BootParams  // 0xC8
  public    static readonly System.String                   s_SOCModel  // 0xD0
METHODS:
  System.Void add__LogCallbackEventHandler(CrashSightAgent.LogCallbackDelegate value)
  System.Void remove__LogCallbackEventHandler(CrashSightAgent.LogCallbackDelegate value)
  System.Void SetLogFilter(CrashSightAgent.LogFilterDelegate filter)
  System.Void InitWithAppId(System.String appId, System.Boolean forceOnUiThread)
  System.Void ReportException(System.Exception e, System.String message)
  System.Void ReportException(System.String name, System.String message, System.String stackTrace)
  System.Void ReportException(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String errorAttachmentPath)
  System.Void SetUserId(System.String userId)
  System.Void AddSceneData(System.String key, System.String value)
  System.Void SetUserValue(System.String key, System.Int32 value)
  System.Void SetUserValue(System.String key, System.String value)
  System.Void SetUserValue(System.String key, System.String[] value)
  System.Void SetAppVersion(System.String appVersion)
  System.Void ConfigCrashServerUrl(System.String crashServerUrl)
  System.Void SetLogPath(System.String logPath)
  System.Void ConfigDebugMode(System.Boolean enable)
  System.Void SetDeviceId(System.String deviceId)
  System.Void ConfigCrashReporter(System.Int32 logLevel)
  System.Void ConfigCrashReporter(CSLogSeverity logLevel)
  System.Void PrintLog(CSLogSeverity level, System.String format, System.Object[] args)
  System.Void TestNativeCrash()
  System.Void SetEnvironmentName(System.String serverEnv)
  System.Void EnableAnrMonitor(System.Int32 timeoutMs)
  System.Void DisableAnrMonitor()
  System.Void RegisterCrashCallback(CrashSightCallback callback)
  System.Void UnregisterCrashCallback()
  System.Void RegisterCrashLogCallback(CrashSightLogCallback callback)
  System.Void EnableExceptionHandler()
  System.Void RegisterLogCallback(CrashSightAgent.LogCallbackDelegate handler)
  System.Void UnregisterLogCallback(CrashSightAgent.LogCallbackDelegate handler)
  System.Void SetLogCallbackExtrasHandler(System.Func<System.Collections.Generic.Dictionary<System.String,System.String>> handler)
  System.Void ConfigAutoQuitApplication(System.Boolean autoQuit)
  System.Boolean get_AutoQuitApplicationAfterReport()
  System.Void DebugLog(System.String tag, System.String format)
  System.Boolean get_IsInitialized()
  System.Void _RegisterExceptionHandler()
  System.Void _UnregisterExceptionHandler()
  System.Void SetCrashSightStackTraceEnable(System.Boolean enable)
  System.Void ConfigCallbackType(System.Int32 callbackType)
  System.Void SetDeviceModel(System.String deviceModel)
  System.Void ReportLogInfo(System.String msgType, System.String msg)
  System.Void SetScene(System.String sceneId, System.Boolean upload)
  System.Void SetScene(System.Int32 sceneId, System.Boolean upload)
  System.Int64 GetCrashThreadId()
  System.Void SetCustomizedDeviceID(System.String deviceId)
  System.String GetSDKDefinedDeviceID()
  System.Void SetCustomizedMatchID(System.String matchId)
  System.String GetSDKSessionID()
  System.Void TestOomCrash()
  System.Void TestJavaCrash()
  System.Void TestANR()
  System.String GetCrashUuid()
  System.Void SetLogcatBufferSize(System.Int32 size)
  System.Void TestOcCrash()
  System.Void StartDumpRoutine(System.Int32 dumpMode, System.Int32 startTimeMode, System.Int64 startTime, System.Int64 dumpInterval, System.Int32 dumpTimes, System.Boolean saveLocal, System.String savePath)
  System.Void StartMonitorFdCount(System.Int32 interval, System.Int32 limit, System.Int32 dumpType)
  System.Int32 getExceptionType(System.String name)
  System.Void TestUseAfterFree()
  System.Void ReRegistAllMonitors()
  System.Void CloseAllMonitors()
  System.Void setEnableGetPackageInfo(System.Boolean enable)
  System.Void setCatchMultiSignal(System.Boolean enable)
  System.Void enableDetailedPageTracing(System.Boolean enable)
  System.Boolean IsLastSessionCrash()
  System.String GetLastSessionUserId()
  System.Boolean CheckFdCount(System.Int32 limit, System.Int32 dumpType, System.Boolean upload)
  System.Void SetOomLogPath(System.String logPath)
  System.Void ReportJank(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.String paramsJson, System.Int32 reportInfoOption, System.String jankAttachmentPath)
  System.Void ReportStuck(System.Int32 threadId, System.Int32 maxChecks, System.Int64 checkInterval, System.String name, System.String message, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String attachPath)
  System.Void SetVehEnable(System.Boolean enable)
  System.Void ReportCrash()
  System.Void ReportDump(System.String dump_path, System.Boolean is_async)
  System.Void SetExtraHandler(System.Boolean extra_handle_enable)
  System.Void UploadGivenPathDump(System.String dump_dir, System.Boolean is_extra_check)
  System.Void SetDumpType(System.Int32 dump_type)
  System.Void AddValidExpCode(System.UInt64 exp_code)
  System.Void UploadCrashWithGuid(System.String guid)
  System.Void SetCrashUploadEnable(System.Boolean enable)
  System.Void SetWorkSpace(System.String workspace)
  System.Void SetCustomAttachDir(System.String path)
  System.Void SetErrorUploadInterval(System.Int32 interval)
  System.Void SetErrorUploadEnable(System.Boolean enable)
  System.Void SetRecordFileDir(System.String record_dir)
  System.Void InitContext(System.String userId, System.String version, System.String key)
  System.Void Init(System.String app_id, System.String app_key, System.String app_version)
  System.Void ConfigDefault(System.String channel, System.String version, System.String user, System.Int64 delay)
  System.Void _OnLogCallbackHandlerMain(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  System.Void _OnLogCallbackHandlerThreaded(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  System.Void _OnLogCallbackHandler(System.String condition, System.String stackTrace, UnityEngine.LogType type, CSReportType rType)
  System.Void _OnUncaughtExceptionHandler(System.Object sender, System.UnhandledExceptionEventArgs args)
  System.Void _HandleException(System.Exception e, System.String message, System.Boolean uncaught)
  System.Boolean ShouldSkipFrame(System.String frame)
  System.Void _reportException(System.Boolean uncaught, System.String name, System.String reason, System.String stackTrace)
  System.Void AddTrackCustomData()
  System.Void AddLocalLogFile()
  System.Int32 valueOf(UnityEngine.LogType logLevel)
  System.Boolean isEnableAutoReport(UnityEngine.LogType logLevel)
  System.Void _HandleException(UnityEngine.LogType logLevel, System.String name, System.String message, System.String stackTrace, System.Boolean uncaught, CSReportType rType)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: CrashSightAnrMonitor
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   static  CrashSightMonoBehaviour         monoBehaviour  // 0x0
  private   static  System.Int32                    anrTimeoutMs  // 0x8
  private   static  System.Int32                    detectionTimeoutMs  // 0xC
  private   static  System.Boolean                  <Paused>k__BackingField  // 0x10
  private   static  System.Int32                    ticksSinceUiUpdate  // 0x14
  private   static  System.Boolean                  reported  // 0x18
  private   static  System.Boolean                  running  // 0x19
  private   static  System.Threading.Thread         thread  // 0x20
METHODS:
  System.Boolean get_Paused()
  System.Void set_Paused(System.Boolean value)
  System.Void Start(System.Int32 timeoutMs)
  System.Void Stop()
  System.Collections.IEnumerator UpdateUiStatus()
  System.Void Run()
  System.Void Report()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityAnrException
TYPE:  class
TOKEN: 0x200000D
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception innerException)
END_CLASS

CLASS: CrashSightCallback
TYPE:  class
TOKEN: 0x200000E
FIELDS:
METHODS:
  System.String OnCrashBaseRetEvent(System.Int32 methodId, System.Int32 crashType)
  System.Void .ctor()
END_CLASS

CLASS: CrashSightLogCallback
TYPE:  class
TOKEN: 0x200000F
FIELDS:
METHODS:
  System.String OnSetLogPathEvent(System.Int32 methodId, System.Int32 crashType)
  System.Void OnLogUploadResultEvent(System.Int32 methodId, System.Int32 crashType, System.Int32 result)
  System.Void .ctor()
END_CLASS

CLASS: CrashSightMonoBehaviour
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MonoBehaviour
FIELDS:
  private   static  CrashSightMonoBehaviour         _instance  // 0x0
  private           System.Action                   ApplicationResuming  // 0x18
  private           System.Action                   ApplicationPausing  // 0x20
  private           System.Action                   ApplicationQuitting  // 0x28
  private           System.Boolean                  _isRunning  // 0x30
METHODS:
  CrashSightMonoBehaviour get_Instance()
  System.Void add_ApplicationResuming(System.Action value)
  System.Void remove_ApplicationResuming(System.Action value)
  System.Void add_ApplicationPausing(System.Action value)
  System.Void remove_ApplicationPausing(System.Action value)
  System.Void add_ApplicationQuitting(System.Action value)
  System.Void remove_ApplicationQuitting(System.Action value)
  System.Void UpdatePauseStatus(System.Boolean paused)
  System.Void OnApplicationPause(System.Boolean pauseStatus)
  System.Void OnApplicationFocus(System.Boolean hasFocus)
  System.Void OnApplicationQuit()
  System.Void Awake()
  System.Void .ctor()
END_CLASS

CLASS: CrashSightStackTrace
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  public    static  System.Boolean                  enable  // 0x0
  private   static  System.String                   stackTrace  // 0x8
METHODS:
  System.Void setEnable(System.Boolean enable)
  System.String ExtractStackTrace()
  System.Void .ctor()
END_CLASS

CLASS: Level
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  GCloud.UQM.UQMLog.Level         None  // 0x0
  public    static  GCloud.UQM.UQMLog.Level         Log  // 0x0
  public    static  GCloud.UQM.UQMLog.Level         Warning  // 0x0
  public    static  GCloud.UQM.UQMLog.Level         Error  // 0x0
METHODS:
END_CLASS

CLASS: UQMRetJsonEventHandler
TYPE:  class
TOKEN: 0x200001E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.String Invoke(System.Int32 methodId, System.Int32 callType, System.Int32 logUploadResult)
  System.IAsyncResult BeginInvoke(System.Int32 methodId, System.Int32 callType, System.Int32 logUploadResult, System.AsyncCallback callback, System.Object object)
  System.String EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TOKEN
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENNONE  // 0x0
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENCURLY_OPEN  // 0x0
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENCURLY_CLOSE  // 0x0
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENSQUARED_OPEN  // 0x0
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENSQUARED_CLOSE  // 0x0
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENCOLON  // 0x0
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENCOMMA  // 0x0
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENSTRING  // 0x0
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENNUMBER  // 0x0
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENTRUE  // 0x0
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENFALSE  // 0x0
  public    static  GCloud.UQM.MiniJSON.Json.Parser.TOKENNULL  // 0x0
METHODS:
END_CLASS

CLASS: Parser
TYPE:  class
TOKEN: 0x2000020
FIELDS:
  private   static  System.String                   WORD_BREAK  // 0x0
  private           System.IO.StringReader          json  // 0x10
METHODS:
  System.Boolean IsWordBreak(System.Char c)
  System.Void .ctor(System.String jsonString)
  System.Object Parse(System.String jsonString)
  System.Void Dispose()
  System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject()
  System.Collections.Generic.List<System.Object> ParseArray()
  System.Object ParseValue()
  System.Object ParseByToken(GCloud.UQM.MiniJSON.Json.Parser.TOKEN token)
  System.String ParseString()
  System.Object ParseNumber()
  System.Void EatWhitespace()
  System.Char get_PeekChar()
  System.Char get_NextChar()
  System.String get_NextWord()
  GCloud.UQM.MiniJSON.Json.Parser.TOKEN get_NextToken()
END_CLASS

CLASS: Serializer
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  private           System.Text.StringBuilder       builder  // 0x10
METHODS:
  System.Void .ctor()
  System.String Serialize(System.Object obj)
  System.Void SerializeValue(System.Object value)
  System.Void SerializeObject(System.Collections.IDictionary obj)
  System.Void SerializeArray(System.Collections.IList anArray)
  System.Void SerializeString(System.String str)
  System.Void SerializeOther(System.Object value)
END_CLASS

CLASS: GCloud.UQM.OnUQMRetEventHandler`1
TYPE:  class
TOKEN: 0x2000012
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T ret)
  System.IAsyncResult BeginInvoke(T ret, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GCloud.UQM.OnUQMStringRetEventHandler`1
TYPE:  class
TOKEN: 0x2000013
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.String Invoke(T ret, T crashType)
  System.IAsyncResult BeginInvoke(T ret, T crashType, System.AsyncCallback callback, System.Object object)
  System.String EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GCloud.UQM.OnUQMStringRetSetLogPathEventHandler`1
TYPE:  class
TOKEN: 0x2000014
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.String Invoke(T ret, T crashType)
  System.IAsyncResult BeginInvoke(T ret, T crashType, System.AsyncCallback callback, System.Object object)
  System.String EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GCloud.UQM.OnUQMRetLogUploadEventHandler`1
TYPE:  class
TOKEN: 0x2000015
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T ret, T crashType, T result)
  System.IAsyncResult BeginInvoke(T ret, T crashType, T result, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GCloud.UQM.UQM
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  public    static  System.String                   LibName  // 0x0
  private   static  System.Boolean                  initialized  // 0x0
  public    static  System.Boolean                  isDebug  // 0x1
METHODS:
  System.Void Init()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: GCloud.UQM.UQMCrashLevel
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelSilent  // 0x0
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelError  // 0x0
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelWarn  // 0x0
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelInfo  // 0x0
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelDebug  // 0x0
  public    static  GCloud.UQM.UQMCrashLevel        CSLogLevelVerbose  // 0x0
METHODS:
END_CLASS

CLASS: GCloud.UQM.UQMCrash
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  private   static  GCloud.UQM.OnUQMStringRetEventHandler<System.Int32>CrashBaseRetEvent  // 0x0
  private   static  GCloud.UQM.OnUQMStringRetSetLogPathEventHandler<System.Int32>CrashSetLogPathRetEvent  // 0x8
  private   static  GCloud.UQM.OnUQMRetLogUploadEventHandler<System.Int32>CrashLogUploadRetEvent  // 0x10
  private   static  UnityEngine.AndroidJavaClass    _gameAgentClass  // 0x18
  private   static  System.Boolean                  _isLoadedSo  // 0x20
  private   static  System.Int32                    _gameType  // 0x24
  private   static readonly System.String                   GAME_AGENT_CLASS  // 0x28
METHODS:
  System.Void CS_InitContext(System.String id, System.String version, System.String key)
  System.Void CS_ReportExceptionW(System.Int32 type, System.String name, System.String message, System.String stack_trace, System.String extras, System.Boolean is_async, System.String attachmentPath)
  System.Void CS_SetUserValue(System.String key, System.String value)
  System.Void CS_SetVehEnable(System.Boolean enable)
  System.Void CS_SetExtraHandler(System.Boolean extra_handle_enable)
  System.Void CS_SetCustomLogDirW(System.String log_path)
  System.Void CS_SetUserId(System.String user_id)
  System.Void CS_MonitorEnable(System.Boolean enable)
  System.Void CS_PrintLog(System.Int32 level, System.String tag, System.String format, System.String arg)
  System.Void CS_UploadGivenPathDump(System.String dump_dir, System.Boolean is_extra_check)
  System.Void CS_ReportCrash()
  System.Void CS_ReportDump(System.String dump_dir, System.Boolean is_async)
  System.Void CS_SetEnvironmentName(System.String name)
  System.Void CS_InitWithAppId(System.String app_id)
  System.Void CS_SetAppVersion(System.String app_version)
  System.Void CS_ConfigCrashServerUrl(System.String crash_server_url)
  System.Void CS_ConfigDebugMode(System.Boolean enable)
  System.Void CS_SetDeviceId(System.String device_id)
  System.Void CS_ConfigCrashReporter(System.Int32 log_level)
  System.Void CS_TestNativeCrash()
  System.Void CS_SetDumpType(System.Int32 dump_type)
  System.Void CS_AddValidExpCode(System.UInt64 exp_code)
  System.Void CS_UploadCrashWithGuid(System.String guid)
  System.Void CS_SetCrashUploadEnable(System.Boolean enable)
  System.Void CS_SetWorkSpaceW(System.String workspace)
  System.Void CS_SetEngineInfo(System.String version, System.String buildConfig, System.String language, System.String locale)
  System.Void CS_SetCustomAttachDirW(System.String log_path)
  System.Void CS_UseSavedUserId(System.Boolean enable)
  System.Void CS_ReportStuck(System.Int32 threadId, System.Int32 maxChecks, System.Int32 checkInterval, System.String name, System.String message, System.String extraInfo, System.Int32 dumpNativeType, System.String attachPath)
  System.Void add_CrashBaseRetEvent(GCloud.UQM.OnUQMStringRetEventHandler<System.Int32> value)
  System.Void remove_CrashBaseRetEvent(GCloud.UQM.OnUQMStringRetEventHandler<System.Int32> value)
  System.Void add_CrashSetLogPathRetEvent(GCloud.UQM.OnUQMStringRetSetLogPathEventHandler<System.Int32> value)
  System.Void remove_CrashSetLogPathRetEvent(GCloud.UQM.OnUQMStringRetSetLogPathEventHandler<System.Int32> value)
  System.Void add_CrashLogUploadRetEvent(GCloud.UQM.OnUQMRetLogUploadEventHandler<System.Int32> value)
  System.Void remove_CrashLogUploadRetEvent(GCloud.UQM.OnUQMRetLogUploadEventHandler<System.Int32> value)
  UnityEngine.AndroidJavaClass get_CrashSightPlatform()
  System.Void LoadCrashSightCoreSo()
  System.Void ConfigCallbackType(System.Int32 callbackType)
  System.Void ConfigGameType(System.Int32 gameType)
  System.Void ConfigAutoReportLogLevel(System.Int32 level)
  System.Void ConfigCrashServerUrl(System.String serverUrl)
  System.Void ConfigDebugMode(System.Boolean enable)
  System.Void ConfigDefault(System.String channel, System.String version, System.String user, System.Int64 delay)
  System.Void InitWithAppId(System.String appId, System.Boolean forceOnUiThread)
  System.Void InitContext(System.String userId, System.String version, System.String key)
  System.Void LogRecord(System.Int32 level, System.String message)
  System.Void AddSceneData(System.String k, System.String v)
  System.Void ReportException(System.Int32 type, System.String name, System.String message, System.String stackTrace, System.String extras, System.Boolean quitProgram)
  System.Void ReportException(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String errorAttachmentPath)
  System.Void SetUserId(System.String userId)
  System.Void SetScene(System.String sceneId, System.Boolean upload)
  System.Void ReRegistAllMonitors()
  System.Void CloseAllMonitors()
  System.Void ReportLogInfo(System.String msgType, System.String msg)
  System.Void SetAppVersion(System.String appVersion)
  System.Void SetDeviceId(System.String deviceId)
  System.Void SetCustomizedDeviceID(System.String deviceId)
  System.String GetSDKDefinedDeviceID()
  System.Void SetCustomizedMatchID(System.String matchId)
  System.String GetSDKSessionID()
  System.String GetCrashUuid()
  System.Void SetDeviceModel(System.String deviceModel)
  System.Void SetLogPath(System.String logPath)
  System.Void SetCrashCallback()
  System.Void UnsetCrashCallback()
  System.Void SetCrashLogCallback()
  System.String OnCrashCallbackMessage(System.Int32 methodId, System.Int32 crashType)
  System.String OnCrashCallbackData(System.Int32 methodId, System.Int32 crashType)
  System.String OnCrashSetLogPathMessage(System.Int32 methodId, System.Int32 crashType)
  System.String OnCrashLogUploadMessage(System.Int32 methodId, System.Int32 crashType, System.Int32 result)
  System.String OnCrashCallbackNoRet(System.Int32 methodId, System.Int32 crashType)
  System.Void ConfigCallBack()
  System.Void UnregisterCallBack()
  System.Void ConfigLogCallBack()
  System.Void TestOomCrash()
  System.Void TestJavaCrash()
  System.Void TestOcCrash()
  System.Void TestNativeCrash()
  System.Void TestANR()
  System.Int64 GetCrashThreadId()
  System.Void SetLogcatBufferSize(System.Int32 size)
  System.Void SetCallbackMsg(System.String data)
  System.Void StartDumpRoutine(System.Int32 dumpMode, System.Int32 startTimeMode, System.Int64 startTime, System.Int64 dumpInterval, System.Int32 dumpTimes, System.Boolean saveLocal, System.String savePath)
  System.Void StartMonitorFdCount(System.Int32 interval, System.Int32 limit, System.Int32 dumpType)
  System.Int32 getExceptionType(System.String name)
  System.Void TestUseAfterFree()
  System.Void SetServerEnv(System.String serverEnv)
  System.Void SetVehEnable(System.Boolean enable)
  System.Void ReportCrash()
  System.Void ReportDump(System.String dump_path, System.Boolean is_async)
  System.Void SetExtraHandler(System.Boolean extra_handle_enable)
  System.Void UploadGivenPathDump(System.String dump_dir, System.Boolean is_extra_check)
  System.Void SetErrorUploadInterval(System.Int32 interval)
  System.Void SetErrorUploadEnable(System.Boolean enable)
  System.Void SetRecordFileDir(System.String record_dir)
  System.Void Init(System.String app_id, System.String app_key, System.String app_version)
  System.Void setEnableGetPackageInfo(System.Boolean enable)
  System.Void SetDumpType(System.Int32 dump_type)
  System.Void AddValidExpCode(System.UInt64 exp_code)
  System.Void UploadCrashWithGuid(System.String guid)
  System.Void SetCrashUploadEnable(System.Boolean enable)
  System.Void SetWorkSpace(System.String workspace)
  System.Void SetEngineInfo(System.String version, System.String buildConfig, System.String language, System.String locale)
  System.Void setCatchMultiSignal(System.Boolean enable)
  System.Void enableDetailedPageTracing(System.Boolean enable)
  System.Void useSavedUserId(System.Boolean enable)
  System.Void SetCustomAttachDir(System.String path)
  System.Boolean IsLastSessionCrash()
  System.String GetLastSessionUserId()
  System.Boolean CheckFdCount(System.Int32 limit, System.Int32 dumpType, System.Boolean upload)
  System.Void SetOomLogPath(System.String logPath)
  System.Void ReportJank(System.Int32 type, System.String exceptionName, System.String exceptionMsg, System.String exceptionStack, System.String paramsJson, System.Int32 reportInfoOption, System.String jankAttachmentPath)
  System.Void ProcessEngineAnr(System.Int32 type)
  System.Void SetEngineMainThread()
  System.Void ReportStuck(System.Int32 threadId, System.Int32 maxChecks, System.Int64 checkInterval, System.String name, System.String message, System.Collections.Generic.Dictionary<System.String,System.String> extInfo, System.Int32 dumpNativeType, System.String attachPath)
  System.Void .cctor()
END_CLASS

CLASS: GCloud.UQM.UQMMethodNameID
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  GCloud.UQM.UQMMethodNameID      UQM_CRASH_CALLBACK_EXTRA_DATA  // 0x0
  public    static  GCloud.UQM.UQMMethodNameID      UQM_CRASH_CALLBACK_EXTRA_MESSAGE  // 0x0
  public    static  GCloud.UQM.UQMMethodNameID      UQM_CRASH_CALLBACK_SET_LOG_PATH  // 0x0
  public    static  GCloud.UQM.UQMMethodNameID      UQM_CRASH_CALLBACK_LOG_UPLOAD_RESULT  // 0x0
METHODS:
END_CLASS

CLASS: GCloud.UQM.UQMLog
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private   static  GCloud.UQM.UQMLog.Level         level  // 0x0
  private   static  System.String                   header  // 0x0
METHODS:
  System.Void SetLevel(GCloud.UQM.UQMLog.Level l)
  System.Void Log(System.String message)
  System.Void LogWarning(System.String message)
  System.Void LogError(System.String message)
  System.Void FullLog(System.String message)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: GCloud.UQM.RetArgsWrapper
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  private   readonly System.Int32                    methodId  // 0x10
  private   readonly System.Int32                    crashType  // 0x14
  private   readonly System.Int32                    logUploadResult  // 0x18
METHODS:
  System.Int32 get_MethodId()
  System.Int32 get_CrashType()
  System.Int32 get_LogUploadResult()
  System.Void .ctor(System.Int32 _methodId, System.Int32 _crashType, System.Int32 _logUploadResult)
END_CLASS

CLASS: GCloud.UQM.UQMMessageCenter
TYPE:  class
TOKEN: 0x200001D
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.Boolean                  initialzed  // 0x0
  private   static  GCloud.UQM.UQMMessageCenter     instance  // 0x8
METHODS:
  System.String OnUQMRet(System.Int32 methodId, System.Int32 crashType, System.Int32 logUploadResult)
  System.Void cs_setUnityCallback(GCloud.UQM.UQMMessageCenter.UQMRetJsonEventHandler eventHandler)
  GCloud.UQM.UQMMessageCenter get_Instance()
  System.Void Init()
  System.Void Uninit()
  System.String SynchronousDelegate(System.Object arg)
  System.Void .ctor()
END_CLASS

CLASS: GCloud.UQM.MiniJSON.Json
TYPE:  class
TOKEN: 0x200001F
FIELDS:
METHODS:
  System.Object Deserialize(System.String json)
  System.String Serialize(System.Object obj)
END_CLASS

