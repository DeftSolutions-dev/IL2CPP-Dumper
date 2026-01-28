// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.Dlogger.Runtime.dll
// Classes:  23
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Options
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  public            System.Collections.Generic.Dictionary<Beyond.EnableLogType,System.Boolean>remoteSet  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: LogCallback
TYPE:  class
TOKEN: 0x2000009
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(Beyond.Log.FLogMessage& msg)
END_CLASS

CLASS: DebugContext
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  public            Beyond.ELogLevel                logLevelMask  // 0x10
  public            System.String                   info  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: DebugContextScope
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: Beyond.ELogChannel
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.ELogChannel              None  // 0x0
  public    static  Beyond.ELogChannel              Res  // 0x0
  public    static  Beyond.ELogChannel              Cfg  // 0x0
  public    static  Beyond.ELogChannel              Battle  // 0x0
  public    static  Beyond.ELogChannel              GamePlay  // 0x0
  public    static  Beyond.ELogChannel              UI  // 0x0
  public    static  Beyond.ELogChannel              Effect  // 0x0
  public    static  Beyond.ELogChannel              Audio  // 0x0
  public    static  Beyond.ELogChannel              Network  // 0x0
  public    static  Beyond.ELogChannel              Dialog  // 0x0
  public    static  Beyond.ELogChannel              Cutscene  // 0x0
  public    static  Beyond.ELogChannel              HGRP  // 0x0
  public    static  Beyond.ELogChannel              Build  // 0x0
  public    static  Beyond.ELogChannel              Camera  // 0x0
  public    static  Beyond.ELogChannel              Animation  // 0x0
  public    static  Beyond.ELogChannel              Scene  // 0x0
  public    static  Beyond.ELogChannel              Action  // 0x0
  public    static  Beyond.ELogChannel              Tool  // 0x0
  public    static  Beyond.ELogChannel              Inventory  // 0x0
  public    static  Beyond.ELogChannel              Lua  // 0x0
  public    static  Beyond.ELogChannel              Debug  // 0x0
  public    static  Beyond.ELogChannel              LevelScript  // 0x0
  public    static  Beyond.ELogChannel              Movement  // 0x0
  public    static  Beyond.ELogChannel              Interactive  // 0x0
  public    static  Beyond.ELogChannel              Common  // 0x0
  public    static  Beyond.ELogChannel              Editor  // 0x0
  public    static  Beyond.ELogChannel              Streaming  // 0x0
  public    static  Beyond.ELogChannel              Factory  // 0x0
  public    static  Beyond.ELogChannel              Utils  // 0x0
  public    static  Beyond.ELogChannel              NPC  // 0x0
  public    static  Beyond.ELogChannel              VIDEO  // 0x0
  public    static  Beyond.ELogChannel              I18N  // 0x0
  public    static  Beyond.ELogChannel              Guide  // 0x0
  public    static  Beyond.ELogChannel              HGEventLog  // 0x0
  public    static  Beyond.ELogChannel              RedDot  // 0x0
  public    static  Beyond.ELogChannel              NetworkCore  // 0x0
  public    static  Beyond.ELogChannel              ExportScene  // 0x0
  public    static  Beyond.ELogChannel              ExportSceneValidation  // 0x0
  public    static  Beyond.ELogChannel              HGNetLog  // 0x0
  public    static  Beyond.ELogChannel              IFix  // 0x0
  public    static  Beyond.ELogChannel              SDK  // 0x0
  public    static  Beyond.ELogChannel              VFS  // 0x0
  public    static  Beyond.ELogChannel              Preload  // 0x0
  public    static  Beyond.ELogChannel              Voice  // 0x0
  public    static  Beyond.ELogChannel              CmdExport  // 0x0
  public    static  Beyond.ELogChannel              BossBattler  // 0x0
  public    static  Beyond.ELogChannel              ActionDetail  // 0x0
  public    static  Beyond.ELogChannel              ActionExecutor  // 0x0
  public    static  Beyond.ELogChannel              GameEventManager  // 0x0
  public    static  Beyond.ELogChannel              ClientData  // 0x0
  public    static  Beyond.ELogChannel              P4  // 0x0
  public    static  Beyond.ELogChannel              NavMesh  // 0x0
  public    static  Beyond.ELogChannel              FMV  // 0x0
  public    static  Beyond.ELogChannel              Scope  // 0x0
  public    static  Beyond.ELogChannel              MiniGame  // 0x0
  public    static  Beyond.ELogChannel              Spawner  // 0x0
  public    static  Beyond.ELogChannel              AI  // 0x0
  public    static  Beyond.ELogChannel              Validation  // 0x0
  public    static  Beyond.ELogChannel              Luna  // 0x0
  public    static  Beyond.ELogChannel              LevelScriptTask  // 0x0
  public    static  Beyond.ELogChannel              Dungeon  // 0x0
  public    static  Beyond.ELogChannel              WorldLifeSpan  // 0x0
  public    static  Beyond.ELogChannel              SNS  // 0x0
  public    static  Beyond.ELogChannel              HttpGm  // 0x0
  public    static  Beyond.ELogChannel              LevelEditor  // 0x0
  public    static  Beyond.ELogChannel              TowerDefense  // 0x0
  public    static  Beyond.ELogChannel              Spaceship  // 0x0
  public    static  Beyond.ELogChannel              Physics  // 0x0
  public    static  Beyond.ELogChannel              Weapon  // 0x0
  public    static  Beyond.ELogChannel              DataManager  // 0x0
  public    static  Beyond.ELogChannel              TempFile  // 0x0
  public    static  Beyond.ELogChannel              Quality  // 0x0
  public    static  Beyond.ELogChannel              Map  // 0x0
  public    static  Beyond.ELogChannel              Bark  // 0x0
  public    static  Beyond.ELogChannel              Entity  // 0x0
  public    static  Beyond.ELogChannel              Squad  // 0x0
  public    static  Beyond.ELogChannel              LevelSeq  // 0x0
  public    static  Beyond.ELogChannel              Mission  // 0x0
  public    static  Beyond.ELogChannel              Tracking  // 0x0
  public    static  Beyond.ELogChannel              Friend  // 0x0
  public    static  Beyond.ELogChannel              Lsm  // 0x0
  public    static  Beyond.ELogChannel              ConditionRuntime  // 0x0
  public    static  Beyond.ELogChannel              DynamicScene  // 0x0
  public    static  Beyond.ELogChannel              ModelView  // 0x0
  public    static  Beyond.ELogChannel              WaterDrone  // 0x0
  public    static  Beyond.ELogChannel              HelloWorld  // 0x0
  public    static  Beyond.ELogChannel              MapRegion  // 0x0
  public    static  Beyond.ELogChannel              GameSetting  // 0x0
  public    static  Beyond.ELogChannel              LevelLoader  // 0x0
  public    static  Beyond.ELogChannel              PS5  // 0x0
  public    static  Beyond.ELogChannel              Activity  // 0x0
  public    static  Beyond.ELogChannel              Login  // 0x0
  public    static  Beyond.ELogChannel              SkeletalMorph  // 0x0
  public    static  Beyond.ELogChannel              Gm  // 0x0
  public    static  Beyond.ELogChannel              Max  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.ELogLevel
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.ELogLevel                None  // 0x0
  public    static  Beyond.ELogLevel                Info  // 0x0
  public    static  Beyond.ELogLevel                Warning  // 0x0
  public    static  Beyond.ELogLevel                Error  // 0x0
  public    static  Beyond.ELogLevel                Critical  // 0x0
  public    static  Beyond.ELogLevel                Important  // 0x0
  public    static  Beyond.ELogLevel                Exception  // 0x0
  public    static  Beyond.ELogLevel                All  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.EColorTag
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.EColorTag                None  // 0x0
  public    static  Beyond.EColorTag                Red  // 0x0
  public    static  Beyond.EColorTag                Yellow  // 0x0
  public    static  Beyond.EColorTag                Green  // 0x0
  public    static  Beyond.EColorTag                Blue  // 0x0
  public    static  Beyond.EColorTag                White  // 0x0
  public    static  Beyond.EColorTag                Black  // 0x0
  public    static  Beyond.EColorTag                Grey  // 0x0
  public    static  Beyond.EColorTag                Cyan  // 0x0
  public    static  Beyond.EColorTag                Magenta  // 0x0
  public    static  Beyond.EColorTag                Critical  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.LogDefine
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Int32,System.String>s_logNameCacheDict  // 0x0
METHODS:
  System.String ConvertColorTagToName(Beyond.EColorTag colorTag)
  System.String ConvertLogChannelToName(Beyond.ELogChannel logChannel)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.EnableLogType
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.EnableLogType            DevOnly  // 0x0
  public    static  Beyond.EnableLogType            Release  // 0x0
  public    static  Beyond.EnableLogType            Login  // 0x0
  public    static  Beyond.EnableLogType            EntitySpawn  // 0x0
  public    static  Beyond.EnableLogType            NpcSpawn  // 0x0
  public    static  Beyond.EnableLogType            Proxy  // 0x0
  public    static  Beyond.EnableLogType            NpcAction  // 0x0
  public    static  Beyond.EnableLogType            GuideState  // 0x0
  public    static  Beyond.EnableLogType            MainCharacter  // 0x0
  public    static  Beyond.EnableLogType            Perform  // 0x0
  public    static  Beyond.EnableLogType            LevelLoader  // 0x0
  public    static  Beyond.EnableLogType            Dialog  // 0x0
  public    static  Beyond.EnableLogType            MainHudActionQueue  // 0x0
  public    static  Beyond.EnableLogType            AirWall  // 0x0
  public    static  Beyond.EnableLogType            Gm  // 0x0
  public    static  Beyond.EnableLogType            I18N  // 0x0
  public    static  Beyond.EnableLogType            Count  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.DLogger
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private   static  System.Boolean[]                s_remoteSet  // 0x0
  private   static  Beyond.Log.ILogger              s_consoleLogger  // 0x8
  private   static  Beyond.Log.SceneViewMessageLoggers_sceneViewLogger  // 0x10
  private   static  Beyond.Log.UnionLogger          s_defaultLogger  // 0x18
  private   static  Beyond.ELogLevel                ms_enabledLogLevel  // 0x20
  private   static  Beyond.ELogLevel[]              ms_enabledLogChannel  // 0x28
  private   static  Beyond.DLogger.LogCallback      ms_logCriticalAndExceptionCallbackHandler  // 0x30
  private   static  Beyond.DLogger.LogCallback      ms_onBeforeLogError  // 0x38
  private   static  Beyond.DLogger.LogCallback      ms_onBeforeLogCriticalAndException  // 0x40
  public    static  System.Func<System.String>      s_getLuaStackTraceHandler  // 0x48
  private   static  System.Collections.Generic.Stack<Beyond.DLogger.DebugContext>s_debugContextPool  // 0x50
  private   static  System.Collections.Generic.List<Beyond.DLogger.DebugContext>s_debugContextList  // 0x58
  private   static  System.Int32                    <FrameCountThreadSafe>k__BackingField  // 0x60
  private   static  System.Int32                    <LogPing>k__BackingField  // 0x64
  private   static  UnityEngine.Vector3             <LogPlayerPos>k__BackingField  // 0x68
  public    static  System.Int32                    ExceptionCount  // 0x74
  public    static  System.Int32                    CriticalCount  // 0x78
  public    static  System.Int32                    ErrorCount  // 0x7C
  public    static  System.Int32                    ImportantCount  // 0x80
  public    static  System.Int32                    WarningCount  // 0x84
  public    static  System.Int32                    InfoCount  // 0x88
  public    static  System.Int32                    PauseCount  // 0x8C
  public    static  System.Int32                    ReturnLoginCount  // 0x90
METHODS:
  System.Void SetImportantLogConfig(Beyond.DLogger.Options options)
  Beyond.ELogLevel[] get_s_enabledLogChannel()
  System.Void add_s_logCriticalAndExceptionMessageReceived(Beyond.DLogger.LogCallback value)
  System.Void remove_s_logCriticalAndExceptionMessageReceived(Beyond.DLogger.LogCallback value)
  System.Void _RunOnStart()
  System.Void UpdateLogCount(Beyond.Log.FLogMessage& msg)
  System.Void add_s_onBeforeLogError(Beyond.DLogger.LogCallback value)
  System.Void remove_s_onBeforeLogError(Beyond.DLogger.LogCallback value)
  System.Void add_s_onBeforeLogCriticalAndException(Beyond.DLogger.LogCallback value)
  System.Void remove_s_onBeforeLogCriticalAndException(Beyond.DLogger.LogCallback value)
  System.Void SetServerLogger(Beyond.Log.ILogger logger)
  System.Void SetLogLevel(Beyond.ELogLevel level)
  System.Boolean CheckLogLevel(Beyond.ELogLevel level)
  System.Void SetLogChannelEnabled(Beyond.ELogChannel channel, Beyond.ELogLevel level, System.Boolean val)
  System.Boolean CheckLogChannelEnabled(Beyond.ELogChannel channel, Beyond.ELogLevel level)
  System.Void Log(System.String message)
  System.Void Log(System.String message, T param1)
  System.Void Log(System.String message, T1 param1, T2 param2)
  System.Void Log(System.String message, T1 param1, T2 param2, T3 param3)
  System.Void Log(System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void Log(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void Log(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void Log(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void Log(Beyond.ELogChannel channel, System.String message)
  System.Void Log(Beyond.ELogChannel channel, System.String message, T param1)
  System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void Log(UnityEngine.Object context, System.String message)
  System.Void Log(UnityEngine.Object context, System.String message, T param1)
  System.Void Log(UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void Log(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void Log(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void Log(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void Log(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogEditorAlwaysPrint(System.String message)
  System.Void LogEditorAlwaysPrint(System.String message, T param1)
  System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2)
  System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T param1)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message)
  System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T param1)
  System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogWarning(System.String message)
  System.Void LogWarning(UnityEngine.Object context, System.String message)
  System.Void LogWarning(System.String message, T param1)
  System.Void LogWarning(System.String message, T1 param1, T2 param2)
  System.Void LogWarning(System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogWarning(System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogWarning(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogWarning(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogWarning(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogWarning(Beyond.ELogChannel channel, System.String message)
  System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T param1)
  System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogError(System.String message)
  System.Void LogErrorWithLuaStack(Beyond.ELogChannel channel, System.String message)
  System.Void LogErrorWithLuaStack(Beyond.ELogChannel channel, System.String message, T1 param1)
  System.Void LogErrorWithLuaStack(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogErrorWithLuaStack(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogErrorWithLuaStack(System.String message)
  System.Void LogError(System.String message, T param1)
  System.Void LogError(System.String message, T1 param1, T2 param2)
  System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogError(Beyond.ELogChannel channel, System.String message)
  System.Void LogError(Beyond.ELogChannel channel, System.String message, T param1)
  System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogError(UnityEngine.Object context, System.String message)
  System.Void LogError(UnityEngine.Object context, System.String message, T param1)
  System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message)
  System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T param1)
  System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void IFixLogError(System.String message)
  System.Void IFixLogError(System.String message, System.String param1)
  System.Void IFixLogError(System.String message, System.String param1, System.String param2)
  System.Void IFixLogError(System.String message, System.String param1, System.String param2, System.String param3)
  System.Void IFixLogError(System.String message, System.String param1, System.String param2, System.String param3, System.String param4)
  System.Void IFixLogError(System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5)
  System.Void IFixLogError(System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5, System.String param6)
  System.Void IFixLogError(System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5, System.String param6, System.String param7)
  System.Void IFixLogError(Beyond.ELogChannel channel, System.String message)
  System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1)
  System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2)
  System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2, System.String param3)
  System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2, System.String param3, System.String param4)
  System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5)
  System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5, System.String param6)
  System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5, System.String param6, System.String param7)
  System.Void LogErrorWithFilter(System.String message, System.String filter)
  System.Void LogErrorWithFilter(System.String message, System.String filter, T param1)
  System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2)
  System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2, T3 param3)
  System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T param1)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2, T3 param3)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T param1)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2, T3 param3)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter)
  System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T param1)
  System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2)
  System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3)
  System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T param1)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T param1)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogCritical(System.String message)
  System.Void LogCritical(System.String message, T param1)
  System.Void LogCritical(System.String message, T1 param1, T2 param2)
  System.Void LogCritical(System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogCritical(System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogCritical(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogCritical(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogCritical(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogCritical(UnityEngine.Object context, System.String message)
  System.Void LogCritical(UnityEngine.Object context, System.String message, T param1)
  System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message)
  System.Void LogCritical(Beyond.ELogChannel channel, System.String message)
  System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T param1)
  System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T param1)
  System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogException(System.Exception e)
  System.Void LogException(UnityEngine.Object context, System.Exception e)
  System.Void LogException(Beyond.ELogChannel channel, System.Exception e)
  System.Void LogException(Beyond.ELogChannel channel, Beyond.EColorTag color, System.Exception e)
  System.Void LogException(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.Exception e)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T param1)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T param1)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6)
  System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void _Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter)
  System.Void _Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void _LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter)
  System.Void _LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void _LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter)
  System.Void _LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void _LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter)
  System.Void _LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void _LogImportant(Beyond.ELogChannel channel, Beyond.EnableLogType enableLogType, Beyond.EColorTag color, UnityEngine.Object context, System.String message)
  System.Void _LogImportant(Beyond.ELogChannel channel, Beyond.EnableLogType enableLogType, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void _LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter)
  System.Void _LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void _ApplyLog(Beyond.ELogChannel channel, Beyond.ELogLevel level, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter)
  System.Void _LogWithFilter(Beyond.ELogChannel channel, Beyond.ELogLevel level, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter)
  System.Void _ApplyLog(Beyond.ELogChannel channel, Beyond.ELogLevel level, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void _LogWithFilter(Beyond.ELogChannel channel, Beyond.ELogLevel level, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7)
  System.Void LogToConsole(Beyond.ELogChannel channel, System.String message)
  System.Void LogToConsole(Beyond.ELogChannel channel, System.String message, T param1)
  System.Void LogToConsole(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogErrorToConsole(Beyond.ELogChannel channel, System.String message)
  System.Void LogErrorToConsole(Beyond.ELogChannel channel, System.String message, T param1)
  System.Void LogErrorToConsole(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogErrorToConsole(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3)
  System.Void LogErrorToConsole(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogExceptionToConsole(Beyond.ELogChannel channel, System.Exception e)
  System.Void SetLogToSceneViewEnabled(System.Boolean enabled)
  System.Void LogToSceneViewImpl(Beyond.ELogLevel logLevel, Beyond.ELogChannel channel, System.String message, System.Single lifeTime)
  System.Void ClearSceneViewLogs(System.String message)
  System.Void ClearSceneViewLogsRegex(System.String message)
  System.Void LogToSceneView(Beyond.ELogChannel channel, System.Single lifeTime, System.String message)
  System.Void LogToSceneView(Beyond.ELogChannel channel, System.String message)
  System.Void LogToSceneView(Beyond.ELogChannel channel, System.String message, T param1)
  System.Void LogToSceneView(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T param1)
  System.Void LogToSceneView(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogToSceneView(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T1 param1, T2 param2)
  System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.Single lifeTime, System.String message)
  System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.String message)
  System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.String message, T param1)
  System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T param1)
  System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T1 param1, T2 param2)
  System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.Single lifeTime, System.String message)
  System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.String message)
  System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.String message, T param1)
  System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T param1)
  System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T1 param1, T2 param2)
  System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.Single lifeTime, System.String message)
  System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.String message)
  System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.String message, T param1)
  System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T param1)
  System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2)
  System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T1 param1, T2 param2)
  System.Void Log(Beyond.ELogLevel logLevel, Beyond.ELogChannel channel, System.String message, UnityEngine.Object context)
  System.Void Log(Beyond.ELogLevel logLevel, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, UnityEngine.Object context)
  System.Void _DefaultLog(Beyond.Log.FLogMessage& msg)
  System.Void _ConsoleLog(Beyond.Log.FLogMessage& msg)
  System.Void _SceneViewLog(Beyond.Log.FLogMessage& msg, System.Single time)
  Beyond.DLogger.DebugContext _AllocateDebugContext()
  Beyond.DLogger.DebugContextScope SetDebugContextInfo_MustUseUsing(System.String info, Beyond.ELogLevel logLevelMask)
  System.String GetDebugContextInfo(Beyond.ELogLevel logLevelMask)
  System.Int32 get_FrameCountThreadSafe()
  System.Void set_FrameCountThreadSafe(System.Int32 value)
  System.Int32 get_LogPing()
  System.Void set_LogPing(System.Int32 value)
  UnityEngine.Vector3 get_LogPlayerPos()
  System.Void set_LogPlayerPos(UnityEngine.Vector3 value)
  System.Void PushPing(System.Int32 ping)
  System.Void PushPlayerPos(UnityEngine.Vector3 pos)
  System.Void Init()
  System.Void _AddCustomGameLoop(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop)
  System.Void AddPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem method, UnityEngine.LowLevel.PlayerLoopSystem& playerLoop, System.String categoryName, System.String systemName, System.Boolean last, System.Boolean before)
  System.Boolean CheckRegist(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop)
  System.Void _OnApplicationQuit()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Log.BitArray256
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  private           System.UInt64                   data1  // 0x10
  private           System.UInt64                   data2  // 0x18
  private           System.UInt64                   data3  // 0x20
  private           System.UInt64                   data4  // 0x28
METHODS:
  System.UInt32 get_capacity()
  System.Boolean get_allFalse()
  System.Boolean get_allTrue()
  System.String get_humanizedData()
  System.Boolean get_Item(System.Byte index)
  System.Void set_Item(System.Byte index, System.Boolean value)
  System.Void .ctor(System.UInt64 initValue1, System.UInt64 initValue2, System.UInt64 initValue3, System.UInt64 initValue4)
  System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue)
  Beyond.Log.BitArray256 op_OnesComplement(Beyond.Log.BitArray256 a)
  Beyond.Log.BitArray256 op_BitwiseOr(Beyond.Log.BitArray256 a, Beyond.Log.BitArray256 b)
  Beyond.Log.BitArray256 op_BitwiseAnd(Beyond.Log.BitArray256 a, Beyond.Log.BitArray256 b)
  System.Boolean op_Equality(Beyond.Log.BitArray256 a, Beyond.Log.BitArray256 b)
  System.Boolean op_Inequality(Beyond.Log.BitArray256 a, Beyond.Log.BitArray256 b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean GetBool(System.Byte index)
  System.Void SetBool(System.UInt32 index, System.Boolean value)
  System.Void SetAllTrue()
  System.Void SetAllFalse()
  Beyond.Log.BitArray256 AllTrue()
  Beyond.Log.BitArray256 AllFalse()
  System.Boolean <>iFixBaseProxy_Equals(System.Object P0)
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: Beyond.Log.ConsoleLogger
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  public    static readonly System.String                   LOG_TAG  // 0x0
METHODS:
  System.Boolean _CheckIsMainThread()
  System.String _GetCurrentThreadName()
  System.Int32 _GetCurrentThreadID()
  System.Void Log(Beyond.Log.FLogMessage& msg)
  System.Void LogToUnity(Beyond.ELogLevel level, System.String msg, System.Exception exception, UnityEngine.Object context)
  System.String _BuildLogForRuntime(System.Int64 msgTime, System.Int32 frameCount, System.String message, Beyond.ELogChannel channel, Beyond.EColorTag color, Beyond.ELogLevel logLevel)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Log.FLogMessage
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.String                   message  // 0x10
  public            System.Int64                    msgTime  // 0x18
  public            System.Exception                exception  // 0x20
  public            Beyond.ELogLevel                logLevel  // 0x28
  public            Beyond.EColorTag                colorTag  // 0x29
  public            Beyond.ELogChannel              channel  // 0x2A
  public            UnityEngine.Object              context  // 0x30
  public            System.Int32                    ping  // 0x38
  public            System.Int32                    frameCount  // 0x3C
  public            UnityEngine.Vector3             playerPos  // 0x40
METHODS:
  Beyond.Log.FLogMessage CreateFromUnityLogCallback(Beyond.ELogChannel channel, System.String message, System.String stacktrace, UnityEngine.LogType type)
END_CLASS

CLASS: Beyond.Log.ILogger
TYPE:  interface
TOKEN: 0x2000012
FIELDS:
METHODS:
  System.Void Log(Beyond.Log.FLogMessage& msg)
END_CLASS

CLASS: Beyond.Log.LocalLogger
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  private   static  System.Int32                    mainThreadId  // 0x0
  private   static  System.Boolean                  s_initLog  // 0x4
  private   static  System.IO.StreamWriter          s_StreamWriter  // 0x8
  private   static  System.Collections.Concurrent.ConcurrentStack<Beyond.UnSafeString>s_stack  // 0x10
  private   static  Beyond.UnSafeString             s_mainCache  // 0x18
  private   static  System.String                   s_LogFilePath  // 0x20
  private   static  System.String[]                 s_logTypeString  // 0x28
METHODS:
  System.String get_persistentDataPath()
  System.Void .cctor()
  System.Void SubsystemRegistration()
  System.Void LogInit(System.Boolean forceDebug)
  System.Void InitLocalLogger(System.String path)
  System.Void OnWantsToShutdown()
  System.String FlushFile()
  System.String getLogFileLocalPath()
  System.Void _UnityLogCallback(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  System.Void _UnityLogCallbackThread(System.String condition, System.String stackTrace, UnityEngine.LogType type)
  System.Void _GetTime(Beyond.UnSafeString unSafeString)
  System.Void _GetLogType(Beyond.UnSafeString unSafeString, UnityEngine.LogType type)
  Beyond.UnSafeString Alloc()
  System.Void Release(Beyond.UnSafeString value)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Log.SceneViewMessageLogger
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  public            System.Boolean                  enabled  // 0x10
METHODS:
  System.Void .ctor()
  System.Void Log(Beyond.Log.FLogMessage& msg)
  System.Void Log(Beyond.Log.FLogMessage& msg, System.Single lifeTime)
  System.Void ClearLogs(System.String msg)
  System.Void ClearLogsRegex(System.String regexMsg)
END_CLASS

CLASS: Beyond.Log.UnionLogger
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private           Beyond.Log.ILogger              s_consoleLogger  // 0x10
  private           Beyond.Log.ILogger              s_netServerLogger  // 0x18
  private   static  System.Int32                    MAX_MSG_LEN  // 0x0
METHODS:
  System.Void SetServerLogger(Beyond.Log.ILogger log)
  System.Void Log(Beyond.Log.FLogMessage& msg)
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.String __Gen_Wrap_0(Beyond.EColorTag P0)
  System.String __Gen_Wrap_1(Beyond.ELogChannel P0)
  System.Void __Gen_Wrap_2(System.Object P0)
  System.Void __Gen_Wrap_3()
  System.Void __Gen_Wrap_4(Beyond.Log.FLogMessage& P0)
  System.Void __Gen_Wrap_5(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_6(Beyond.ELogLevel P0)
  System.Boolean __Gen_Wrap_7(Beyond.ELogLevel P0)
  System.Void __Gen_Wrap_8(Beyond.ELogChannel P0, Beyond.ELogLevel P1, System.Boolean P2)
  System.Boolean __Gen_Wrap_9(Beyond.ELogChannel P0, Beyond.ELogLevel P1)
  System.Void __Gen_Wrap_10(Beyond.ELogChannel P0, Beyond.ELogLevel P1, Beyond.EColorTag P2, System.Object P3, System.Object P4, System.Object P5)
  System.Void __Gen_Wrap_11(Beyond.ELogChannel P0, Beyond.EColorTag P1, System.Object P2, System.Object P3, System.Object P4)
  System.Void __Gen_Wrap_12(Beyond.ELogChannel P0, System.Object P1)
  System.Void __Gen_Wrap_13(Beyond.ELogChannel P0, Beyond.EColorTag P1, System.Object P2)
  System.Void __Gen_Wrap_14(Beyond.ELogChannel P0, Beyond.EColorTag P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_15(Beyond.ELogChannel P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_16(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_17(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_18(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4)
  System.Void __Gen_Wrap_19(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5)
  System.Void __Gen_Wrap_20(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6)
  System.Void __Gen_Wrap_21(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6, System.Object P7)
  System.Void __Gen_Wrap_22(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_23(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4)
  System.Void __Gen_Wrap_24(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5)
  System.Void __Gen_Wrap_25(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6)
  System.Void __Gen_Wrap_26(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6, System.Object P7)
  System.Void __Gen_Wrap_27(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6, System.Object P7, System.Object P8)
  System.Void __Gen_Wrap_28(Beyond.ELogChannel P0, Beyond.EnableLogType P1, Beyond.EColorTag P2, System.Object P3, System.Object P4)
  System.Void __Gen_Wrap_29(Beyond.EnableLogType P0, System.Object P1)
  System.Void __Gen_Wrap_30(Beyond.EnableLogType P0, Beyond.ELogChannel P1, System.Object P2)
  System.Void __Gen_Wrap_31(Beyond.EnableLogType P0, Beyond.ELogChannel P1, Beyond.EColorTag P2, System.Object P3)
  System.Void __Gen_Wrap_32(Beyond.EnableLogType P0, Beyond.ELogChannel P1, Beyond.EColorTag P2, System.Object P3, System.Object P4)
  System.Void __Gen_Wrap_33(System.Boolean P0)
  System.Void __Gen_Wrap_34(Beyond.ELogLevel P0, Beyond.ELogChannel P1, System.Object P2, System.Single P3)
  System.Void __Gen_Wrap_35(Beyond.ELogChannel P0, System.Single P1, System.Object P2)
  System.Void __Gen_Wrap_36(Beyond.ELogLevel P0, Beyond.ELogChannel P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_37(Beyond.ELogLevel P0, Beyond.ELogChannel P1, Beyond.EColorTag P2, System.Object P3, System.Object P4)
  Beyond.DLogger.DebugContext __Gen_Wrap_38()
  Beyond.DLogger.DebugContextScope __Gen_Wrap_39(System.Object P0, Beyond.ELogLevel P1)
  System.String __Gen_Wrap_40(Beyond.ELogLevel P0)
  System.Boolean __Gen_Wrap_42(UnityEngine.LowLevel.PlayerLoopSystem& P0)
  System.Void __Gen_Wrap_43(UnityEngine.LowLevel.PlayerLoopSystem P0, UnityEngine.LowLevel.PlayerLoopSystem& P1, System.Object P2, System.Object P3, System.Boolean P4, System.Boolean P5)
  System.Void __Gen_Wrap_44(UnityEngine.LowLevel.PlayerLoopSystem& P0)
  System.Void __Gen_Wrap_45(Beyond.DLogger.DebugContextScope& P0)
  System.Boolean __Gen_Wrap_46(Beyond.Log.BitArray256& P0)
  System.String __Gen_Wrap_47(Beyond.Log.BitArray256& P0)
  Beyond.Log.BitArray256 __Gen_Wrap_48(Beyond.Log.BitArray256 P0)
  Beyond.Log.BitArray256 __Gen_Wrap_49(Beyond.Log.BitArray256 P0, Beyond.Log.BitArray256 P1)
  System.Boolean __Gen_Wrap_50(Beyond.Log.BitArray256 P0, Beyond.Log.BitArray256 P1)
  System.Boolean __Gen_Wrap_51(Beyond.Log.BitArray256& P0, System.Object P1)
  System.Int32 __Gen_Wrap_52(Beyond.Log.BitArray256& P0)
  System.Boolean __Gen_Wrap_53(Beyond.Log.BitArray256& P0, System.Byte P1)
  System.Void __Gen_Wrap_54(Beyond.Log.BitArray256& P0, System.UInt32 P1, System.Boolean P2)
  System.Void __Gen_Wrap_55(Beyond.Log.BitArray256& P0)
  Beyond.Log.BitArray256 __Gen_Wrap_56()
  System.Boolean __Gen_Wrap_57()
  System.String __Gen_Wrap_58()
  System.Int32 __Gen_Wrap_59()
  System.String __Gen_Wrap_60(System.Int64 P0, System.Int32 P1, System.Object P2, Beyond.ELogChannel P3, Beyond.EColorTag P4, Beyond.ELogLevel P5)
  System.Void __Gen_Wrap_61(Beyond.ELogLevel P0, System.Object P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_62(System.Object P0, Beyond.Log.FLogMessage& P1)
  Beyond.Log.FLogMessage __Gen_Wrap_63(Beyond.ELogChannel P0, System.Object P1, System.Object P2, UnityEngine.LogType P3)
  Beyond.UnSafeString __Gen_Wrap_64()
  System.Void __Gen_Wrap_65(System.Object P0, System.Object P1, UnityEngine.LogType P2)
  System.Void __Gen_Wrap_66(System.Object P0, Beyond.Log.FLogMessage& P1, System.Single P2)
  System.Void .cctor()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000017
FIELDS:
METHODS:
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
END_CLASS

