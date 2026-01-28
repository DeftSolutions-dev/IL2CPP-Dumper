// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.Dlogger.Runtime.dll
// Classes:  23
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000008
    public class Options
    {
        // Fields
        public System.Collections.Generic.Dictionary<Beyond.EnableLogType,System.Boolean> remoteSet;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class LogCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(Beyond.Log.FLogMessage& msg) { }

    }

    // TypeToken: 0x200000A
    public class DebugContext
    {
        // Fields
        public Beyond.ELogLevel logLevelMask;        // 0x10
        public System.String info;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public struct DebugContextScope, IDisposable
    {
        // Methods
        private System.Void Dispose() { }

    }

namespace Beyond
{

    // TypeToken: 0x2000002
    public struct ELogChannel
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.ELogChannel None;        // 0x0
        public static Beyond.ELogChannel Res;        // 0x0
        public static Beyond.ELogChannel Cfg;        // 0x0
        public static Beyond.ELogChannel Battle;        // 0x0
        public static Beyond.ELogChannel GamePlay;        // 0x0
        public static Beyond.ELogChannel UI;        // 0x0
        public static Beyond.ELogChannel Effect;        // 0x0
        public static Beyond.ELogChannel Audio;        // 0x0
        public static Beyond.ELogChannel Network;        // 0x0
        public static Beyond.ELogChannel Dialog;        // 0x0
        public static Beyond.ELogChannel Cutscene;        // 0x0
        public static Beyond.ELogChannel HGRP;        // 0x0
        public static Beyond.ELogChannel Build;        // 0x0
        public static Beyond.ELogChannel Camera;        // 0x0
        public static Beyond.ELogChannel Animation;        // 0x0
        public static Beyond.ELogChannel Scene;        // 0x0
        public static Beyond.ELogChannel Action;        // 0x0
        public static Beyond.ELogChannel Tool;        // 0x0
        public static Beyond.ELogChannel Inventory;        // 0x0
        public static Beyond.ELogChannel Lua;        // 0x0
        public static Beyond.ELogChannel Debug;        // 0x0
        public static Beyond.ELogChannel LevelScript;        // 0x0
        public static Beyond.ELogChannel Movement;        // 0x0
        public static Beyond.ELogChannel Interactive;        // 0x0
        public static Beyond.ELogChannel Common;        // 0x0
        public static Beyond.ELogChannel Editor;        // 0x0
        public static Beyond.ELogChannel Streaming;        // 0x0
        public static Beyond.ELogChannel Factory;        // 0x0
        public static Beyond.ELogChannel Utils;        // 0x0
        public static Beyond.ELogChannel NPC;        // 0x0
        public static Beyond.ELogChannel VIDEO;        // 0x0
        public static Beyond.ELogChannel I18N;        // 0x0
        public static Beyond.ELogChannel Guide;        // 0x0
        public static Beyond.ELogChannel HGEventLog;        // 0x0
        public static Beyond.ELogChannel RedDot;        // 0x0
        public static Beyond.ELogChannel NetworkCore;        // 0x0
        public static Beyond.ELogChannel ExportScene;        // 0x0
        public static Beyond.ELogChannel ExportSceneValidation;        // 0x0
        public static Beyond.ELogChannel HGNetLog;        // 0x0
        public static Beyond.ELogChannel IFix;        // 0x0
        public static Beyond.ELogChannel SDK;        // 0x0
        public static Beyond.ELogChannel VFS;        // 0x0
        public static Beyond.ELogChannel Preload;        // 0x0
        public static Beyond.ELogChannel Voice;        // 0x0
        public static Beyond.ELogChannel CmdExport;        // 0x0
        public static Beyond.ELogChannel BossBattler;        // 0x0
        public static Beyond.ELogChannel ActionDetail;        // 0x0
        public static Beyond.ELogChannel ActionExecutor;        // 0x0
        public static Beyond.ELogChannel GameEventManager;        // 0x0
        public static Beyond.ELogChannel ClientData;        // 0x0
        public static Beyond.ELogChannel P4;        // 0x0
        public static Beyond.ELogChannel NavMesh;        // 0x0
        public static Beyond.ELogChannel FMV;        // 0x0
        public static Beyond.ELogChannel Scope;        // 0x0
        public static Beyond.ELogChannel MiniGame;        // 0x0
        public static Beyond.ELogChannel Spawner;        // 0x0
        public static Beyond.ELogChannel AI;        // 0x0
        public static Beyond.ELogChannel Validation;        // 0x0
        public static Beyond.ELogChannel Luna;        // 0x0
        public static Beyond.ELogChannel LevelScriptTask;        // 0x0
        public static Beyond.ELogChannel Dungeon;        // 0x0
        public static Beyond.ELogChannel WorldLifeSpan;        // 0x0
        public static Beyond.ELogChannel SNS;        // 0x0
        public static Beyond.ELogChannel HttpGm;        // 0x0
        public static Beyond.ELogChannel LevelEditor;        // 0x0
        public static Beyond.ELogChannel TowerDefense;        // 0x0
        public static Beyond.ELogChannel Spaceship;        // 0x0
        public static Beyond.ELogChannel Physics;        // 0x0
        public static Beyond.ELogChannel Weapon;        // 0x0
        public static Beyond.ELogChannel DataManager;        // 0x0
        public static Beyond.ELogChannel TempFile;        // 0x0
        public static Beyond.ELogChannel Quality;        // 0x0
        public static Beyond.ELogChannel Map;        // 0x0
        public static Beyond.ELogChannel Bark;        // 0x0
        public static Beyond.ELogChannel Entity;        // 0x0
        public static Beyond.ELogChannel Squad;        // 0x0
        public static Beyond.ELogChannel LevelSeq;        // 0x0
        public static Beyond.ELogChannel Mission;        // 0x0
        public static Beyond.ELogChannel Tracking;        // 0x0
        public static Beyond.ELogChannel Friend;        // 0x0
        public static Beyond.ELogChannel Lsm;        // 0x0
        public static Beyond.ELogChannel ConditionRuntime;        // 0x0
        public static Beyond.ELogChannel DynamicScene;        // 0x0
        public static Beyond.ELogChannel ModelView;        // 0x0
        public static Beyond.ELogChannel WaterDrone;        // 0x0
        public static Beyond.ELogChannel HelloWorld;        // 0x0
        public static Beyond.ELogChannel MapRegion;        // 0x0
        public static Beyond.ELogChannel GameSetting;        // 0x0
        public static Beyond.ELogChannel LevelLoader;        // 0x0
        public static Beyond.ELogChannel PS5;        // 0x0
        public static Beyond.ELogChannel Activity;        // 0x0
        public static Beyond.ELogChannel Login;        // 0x0
        public static Beyond.ELogChannel SkeletalMorph;        // 0x0
        public static Beyond.ELogChannel Gm;        // 0x0
        public static Beyond.ELogChannel Max;        // 0x0

    }

    // TypeToken: 0x2000003
    public struct ELogLevel
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.ELogLevel None;        // 0x0
        public static Beyond.ELogLevel Info;        // 0x0
        public static Beyond.ELogLevel Warning;        // 0x0
        public static Beyond.ELogLevel Error;        // 0x0
        public static Beyond.ELogLevel Critical;        // 0x0
        public static Beyond.ELogLevel Important;        // 0x0
        public static Beyond.ELogLevel Exception;        // 0x0
        public static Beyond.ELogLevel All;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct EColorTag
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.EColorTag None;        // 0x0
        public static Beyond.EColorTag Red;        // 0x0
        public static Beyond.EColorTag Yellow;        // 0x0
        public static Beyond.EColorTag Green;        // 0x0
        public static Beyond.EColorTag Blue;        // 0x0
        public static Beyond.EColorTag White;        // 0x0
        public static Beyond.EColorTag Black;        // 0x0
        public static Beyond.EColorTag Grey;        // 0x0
        public static Beyond.EColorTag Cyan;        // 0x0
        public static Beyond.EColorTag Magenta;        // 0x0
        public static Beyond.EColorTag Critical;        // 0x0

    }

    // TypeToken: 0x2000005
    public class LogDefine
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Int32,System.String> s_logNameCacheDict;        // 0x0

        // Methods
        private System.String ConvertColorTagToName(Beyond.EColorTag colorTag) { }
        private System.String ConvertLogChannelToName(Beyond.ELogChannel logChannel) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000006
    public struct EnableLogType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.EnableLogType DevOnly;        // 0x0
        public static Beyond.EnableLogType Release;        // 0x0
        public static Beyond.EnableLogType Login;        // 0x0
        public static Beyond.EnableLogType EntitySpawn;        // 0x0
        public static Beyond.EnableLogType NpcSpawn;        // 0x0
        public static Beyond.EnableLogType Proxy;        // 0x0
        public static Beyond.EnableLogType NpcAction;        // 0x0
        public static Beyond.EnableLogType GuideState;        // 0x0
        public static Beyond.EnableLogType MainCharacter;        // 0x0
        public static Beyond.EnableLogType Perform;        // 0x0
        public static Beyond.EnableLogType LevelLoader;        // 0x0
        public static Beyond.EnableLogType Dialog;        // 0x0
        public static Beyond.EnableLogType MainHudActionQueue;        // 0x0
        public static Beyond.EnableLogType AirWall;        // 0x0
        public static Beyond.EnableLogType Gm;        // 0x0
        public static Beyond.EnableLogType I18N;        // 0x0
        public static Beyond.EnableLogType Count;        // 0x0

    }

    // TypeToken: 0x2000007
    public class DLogger
    {
        // Fields
        private static System.Boolean[] s_remoteSet;        // 0x0
        private static Beyond.Log.ILogger s_consoleLogger;        // 0x8
        private static Beyond.Log.SceneViewMessageLogger s_sceneViewLogger;        // 0x10
        private static Beyond.Log.UnionLogger s_defaultLogger;        // 0x18
        private static Beyond.ELogLevel ms_enabledLogLevel;        // 0x20
        private static Beyond.ELogLevel[] ms_enabledLogChannel;        // 0x28
        private static Beyond.DLogger.LogCallback ms_logCriticalAndExceptionCallbackHandler;        // 0x30
        private static Beyond.DLogger.LogCallback ms_onBeforeLogError;        // 0x38
        private static Beyond.DLogger.LogCallback ms_onBeforeLogCriticalAndException;        // 0x40
        public static System.Func<System.String> s_getLuaStackTraceHandler;        // 0x48
        private static System.Collections.Generic.Stack<Beyond.DLogger.DebugContext> s_debugContextPool;        // 0x50
        private static System.Collections.Generic.List<Beyond.DLogger.DebugContext> s_debugContextList;        // 0x58
        private static System.Int32 <FrameCountThreadSafe>k__BackingField;        // 0x60
        private static System.Int32 <LogPing>k__BackingField;        // 0x64
        private static UnityEngine.Vector3 <LogPlayerPos>k__BackingField;        // 0x68
        public static System.Int32 ExceptionCount;        // 0x74
        public static System.Int32 CriticalCount;        // 0x78
        public static System.Int32 ErrorCount;        // 0x7C
        public static System.Int32 ImportantCount;        // 0x80
        public static System.Int32 WarningCount;        // 0x84
        public static System.Int32 InfoCount;        // 0x88
        public static System.Int32 PauseCount;        // 0x8C
        public static System.Int32 ReturnLoginCount;        // 0x90

        // Methods
        private System.Void SetImportantLogConfig(Beyond.DLogger.Options options) { }
        private Beyond.ELogLevel[] get_s_enabledLogChannel() { }
        private System.Void add_s_logCriticalAndExceptionMessageReceived(Beyond.DLogger.LogCallback value) { }
        private System.Void remove_s_logCriticalAndExceptionMessageReceived(Beyond.DLogger.LogCallback value) { }
        private System.Void _RunOnStart() { }
        private System.Void UpdateLogCount(Beyond.Log.FLogMessage& msg) { }
        private System.Void add_s_onBeforeLogError(Beyond.DLogger.LogCallback value) { }
        private System.Void remove_s_onBeforeLogError(Beyond.DLogger.LogCallback value) { }
        private System.Void add_s_onBeforeLogCriticalAndException(Beyond.DLogger.LogCallback value) { }
        private System.Void remove_s_onBeforeLogCriticalAndException(Beyond.DLogger.LogCallback value) { }
        private System.Void SetServerLogger(Beyond.Log.ILogger logger) { }
        private System.Void SetLogLevel(Beyond.ELogLevel level) { }
        private System.Boolean CheckLogLevel(Beyond.ELogLevel level) { }
        private System.Void SetLogChannelEnabled(Beyond.ELogChannel channel, Beyond.ELogLevel level, System.Boolean val) { }
        private System.Boolean CheckLogChannelEnabled(Beyond.ELogChannel channel, Beyond.ELogLevel level) { }
        private System.Void Log(System.String message) { }
        private System.Void Log(System.String message, T param1) { }
        private System.Void Log(System.String message, T1 param1, T2 param2) { }
        private System.Void Log(System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void Log(System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void Log(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void Log(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void Log(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void Log(Beyond.ELogChannel channel, System.String message) { }
        private System.Void Log(Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void Log(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void Log(UnityEngine.Object context, System.String message) { }
        private System.Void Log(UnityEngine.Object context, System.String message, T param1) { }
        private System.Void Log(UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void Log(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void Log(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void Log(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void Log(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogEditorAlwaysPrint(System.String message) { }
        private System.Void LogEditorAlwaysPrint(System.String message, T param1) { }
        private System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2) { }
        private System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogEditorAlwaysPrint(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message) { }
        private System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T param1) { }
        private System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogEditorAlwaysPrint(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogWarning(System.String message) { }
        private System.Void LogWarning(UnityEngine.Object context, System.String message) { }
        private System.Void LogWarning(System.String message, T param1) { }
        private System.Void LogWarning(System.String message, T1 param1, T2 param2) { }
        private System.Void LogWarning(System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogWarning(System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogWarning(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogWarning(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogWarning(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogError(System.String message) { }
        private System.Void LogErrorWithLuaStack(Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogErrorWithLuaStack(Beyond.ELogChannel channel, System.String message, T1 param1) { }
        private System.Void LogErrorWithLuaStack(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogErrorWithLuaStack(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogErrorWithLuaStack(System.String message) { }
        private System.Void LogError(System.String message, T param1) { }
        private System.Void LogError(System.String message, T1 param1, T2 param2) { }
        private System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogError(Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogError(Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogError(UnityEngine.Object context, System.String message) { }
        private System.Void LogError(UnityEngine.Object context, System.String message, T param1) { }
        private System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogError(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message) { }
        private System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T param1) { }
        private System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogError(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogError(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void IFixLogError(System.String message) { }
        private System.Void IFixLogError(System.String message, System.String param1) { }
        private System.Void IFixLogError(System.String message, System.String param1, System.String param2) { }
        private System.Void IFixLogError(System.String message, System.String param1, System.String param2, System.String param3) { }
        private System.Void IFixLogError(System.String message, System.String param1, System.String param2, System.String param3, System.String param4) { }
        private System.Void IFixLogError(System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5) { }
        private System.Void IFixLogError(System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5, System.String param6) { }
        private System.Void IFixLogError(System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5, System.String param6, System.String param7) { }
        private System.Void IFixLogError(Beyond.ELogChannel channel, System.String message) { }
        private System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1) { }
        private System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2) { }
        private System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2, System.String param3) { }
        private System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2, System.String param3, System.String param4) { }
        private System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5) { }
        private System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5, System.String param6) { }
        private System.Void IFixLogError(Beyond.ELogChannel channel, System.String message, System.String param1, System.String param2, System.String param3, System.String param4, System.String param5, System.String param6, System.String param7) { }
        private System.Void LogErrorWithFilter(System.String message, System.String filter) { }
        private System.Void LogErrorWithFilter(System.String message, System.String filter, T param1) { }
        private System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2) { }
        private System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogErrorWithFilter(System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T param1) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T param1) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter) { }
        private System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T param1) { }
        private System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2) { }
        private System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogErrorWithFilter(UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T param1) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T param1) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogCritical(System.String message) { }
        private System.Void LogCritical(System.String message, T param1) { }
        private System.Void LogCritical(System.String message, T1 param1, T2 param2) { }
        private System.Void LogCritical(System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogCritical(System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogCritical(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogCritical(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogCritical(System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogCritical(UnityEngine.Object context, System.String message) { }
        private System.Void LogCritical(UnityEngine.Object context, System.String message, T param1) { }
        private System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogCritical(UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T param1) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogCritical(Beyond.ELogChannel channel, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogException(System.Exception e) { }
        private System.Void LogException(UnityEngine.Object context, System.Exception e) { }
        private System.Void LogException(Beyond.ELogChannel channel, System.Exception e) { }
        private System.Void LogException(Beyond.ELogChannel channel, Beyond.EColorTag color, System.Exception e) { }
        private System.Void LogException(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.Exception e) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T param1) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T param1) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T param1) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { }
        private System.Void LogImportant(Beyond.EnableLogType enableLogType, Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void _Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter) { }
        private System.Void _Log(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void _LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter) { }
        private System.Void _LogEditorAlwaysPrint(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void _LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter) { }
        private System.Void _LogWarning(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void _LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter) { }
        private System.Void _LogErrorWithFilter(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void _LogImportant(Beyond.ELogChannel channel, Beyond.EnableLogType enableLogType, Beyond.EColorTag color, UnityEngine.Object context, System.String message) { }
        private System.Void _LogImportant(Beyond.ELogChannel channel, Beyond.EnableLogType enableLogType, Beyond.EColorTag color, UnityEngine.Object context, System.String message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void _LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter) { }
        private System.Void _LogCritical(Beyond.ELogChannel channel, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void _ApplyLog(Beyond.ELogChannel channel, Beyond.ELogLevel level, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter) { }
        private System.Void _LogWithFilter(Beyond.ELogChannel channel, Beyond.ELogLevel level, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter) { }
        private System.Void _ApplyLog(Beyond.ELogChannel channel, Beyond.ELogLevel level, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void _LogWithFilter(Beyond.ELogChannel channel, Beyond.ELogLevel level, Beyond.EColorTag color, UnityEngine.Object context, System.String message, System.String filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { }
        private System.Void LogToConsole(Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogToConsole(Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void LogToConsole(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogErrorToConsole(Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogErrorToConsole(Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void LogErrorToConsole(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogErrorToConsole(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogErrorToConsole(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogExceptionToConsole(Beyond.ELogChannel channel, System.Exception e) { }
        private System.Void SetLogToSceneViewEnabled(System.Boolean enabled) { }
        private System.Void LogToSceneViewImpl(Beyond.ELogLevel logLevel, Beyond.ELogChannel channel, System.String message, System.Single lifeTime) { }
        private System.Void ClearSceneViewLogs(System.String message) { }
        private System.Void ClearSceneViewLogsRegex(System.String message) { }
        private System.Void LogToSceneView(Beyond.ELogChannel channel, System.Single lifeTime, System.String message) { }
        private System.Void LogToSceneView(Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogToSceneView(Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void LogToSceneView(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T param1) { }
        private System.Void LogToSceneView(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogToSceneView(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T1 param1, T2 param2) { }
        private System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.Single lifeTime, System.String message) { }
        private System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T param1) { }
        private System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogToSceneViewWarning(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T1 param1, T2 param2) { }
        private System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.Single lifeTime, System.String message) { }
        private System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T param1) { }
        private System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogToSceneViewError(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T1 param1, T2 param2) { }
        private System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.Single lifeTime, System.String message) { }
        private System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.String message) { }
        private System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.String message, T param1) { }
        private System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T param1) { }
        private System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.String message, T1 param1, T2 param2) { }
        private System.Void LogToSceneViewCritical(Beyond.ELogChannel channel, System.Single lifeTime, System.String message, T1 param1, T2 param2) { }
        private System.Void Log(Beyond.ELogLevel logLevel, Beyond.ELogChannel channel, System.String message, UnityEngine.Object context) { }
        private System.Void Log(Beyond.ELogLevel logLevel, Beyond.ELogChannel channel, Beyond.EColorTag color, System.String message, UnityEngine.Object context) { }
        private System.Void _DefaultLog(Beyond.Log.FLogMessage& msg) { }
        private System.Void _ConsoleLog(Beyond.Log.FLogMessage& msg) { }
        private System.Void _SceneViewLog(Beyond.Log.FLogMessage& msg, System.Single time) { }
        private Beyond.DLogger.DebugContext _AllocateDebugContext() { }
        private Beyond.DLogger.DebugContextScope SetDebugContextInfo_MustUseUsing(System.String info, Beyond.ELogLevel logLevelMask) { }
        private System.String GetDebugContextInfo(Beyond.ELogLevel logLevelMask) { }
        private System.Int32 get_FrameCountThreadSafe() { }
        private System.Void set_FrameCountThreadSafe(System.Int32 value) { }
        private System.Int32 get_LogPing() { }
        private System.Void set_LogPing(System.Int32 value) { }
        private UnityEngine.Vector3 get_LogPlayerPos() { }
        private System.Void set_LogPlayerPos(UnityEngine.Vector3 value) { }
        private System.Void PushPing(System.Int32 ping) { }
        private System.Void PushPlayerPos(UnityEngine.Vector3 pos) { }
        private System.Void Init() { }
        private System.Void _AddCustomGameLoop(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop) { }
        private System.Void AddPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem method, UnityEngine.LowLevel.PlayerLoopSystem& playerLoop, System.String categoryName, System.String systemName, System.Boolean last, System.Boolean before) { }
        private System.Boolean CheckRegist(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop) { }
        private System.Void _OnApplicationQuit() { }
        private System.Void .cctor() { }

    }

}

namespace Beyond.Log
{

    // TypeToken: 0x200000F
    public struct BitArray256
    {
        // Fields
        private System.UInt64 data1;        // 0x10
        private System.UInt64 data2;        // 0x18
        private System.UInt64 data3;        // 0x20
        private System.UInt64 data4;        // 0x28

        // Methods
        private System.UInt32 get_capacity() { }
        private System.Boolean get_allFalse() { }
        private System.Boolean get_allTrue() { }
        private System.String get_humanizedData() { }
        private System.Boolean get_Item(System.Byte index) { }
        private System.Void set_Item(System.Byte index, System.Boolean value) { }
        private System.Void .ctor(System.UInt64 initValue1, System.UInt64 initValue2, System.UInt64 initValue3, System.UInt64 initValue4) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<System.UInt32> bitIndexTrue) { }
        private Beyond.Log.BitArray256 op_OnesComplement(Beyond.Log.BitArray256 a) { }
        private Beyond.Log.BitArray256 op_BitwiseOr(Beyond.Log.BitArray256 a, Beyond.Log.BitArray256 b) { }
        private Beyond.Log.BitArray256 op_BitwiseAnd(Beyond.Log.BitArray256 a, Beyond.Log.BitArray256 b) { }
        private System.Boolean op_Equality(Beyond.Log.BitArray256 a, Beyond.Log.BitArray256 b) { }
        private System.Boolean op_Inequality(Beyond.Log.BitArray256 a, Beyond.Log.BitArray256 b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean GetBool(System.Byte index) { }
        private System.Void SetBool(System.UInt32 index, System.Boolean value) { }
        private System.Void SetAllTrue() { }
        private System.Void SetAllFalse() { }
        private Beyond.Log.BitArray256 AllTrue() { }
        private Beyond.Log.BitArray256 AllFalse() { }
        private System.Boolean <>iFixBaseProxy_Equals(System.Object P0) { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x2000010
    public class ConsoleLogger, ILogger
    {
        // Fields
        public static readonly System.String LOG_TAG;        // 0x0

        // Methods
        private System.Boolean _CheckIsMainThread() { }
        private System.String _GetCurrentThreadName() { }
        private System.Int32 _GetCurrentThreadID() { }
        private System.Void Log(Beyond.Log.FLogMessage& msg) { }
        private System.Void LogToUnity(Beyond.ELogLevel level, System.String msg, System.Exception exception, UnityEngine.Object context) { }
        private System.String _BuildLogForRuntime(System.Int64 msgTime, System.Int32 frameCount, System.String message, Beyond.ELogChannel channel, Beyond.EColorTag color, Beyond.ELogLevel logLevel) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000011
    public struct FLogMessage
    {
        // Fields
        public System.String message;        // 0x10
        public System.Int64 msgTime;        // 0x18
        public System.Exception exception;        // 0x20
        public Beyond.ELogLevel logLevel;        // 0x28
        public Beyond.EColorTag colorTag;        // 0x29
        public Beyond.ELogChannel channel;        // 0x2A
        public UnityEngine.Object context;        // 0x30
        public System.Int32 ping;        // 0x38
        public System.Int32 frameCount;        // 0x3C
        public UnityEngine.Vector3 playerPos;        // 0x40

        // Methods
        private Beyond.Log.FLogMessage CreateFromUnityLogCallback(Beyond.ELogChannel channel, System.String message, System.String stacktrace, UnityEngine.LogType type) { }

    }

    // TypeToken: 0x2000012
    public interface ILogger
    {
        // Methods
        private System.Void Log(Beyond.Log.FLogMessage& msg) { }

    }

    // TypeToken: 0x2000013
    public class LocalLogger
    {
        // Fields
        private static System.Int32 mainThreadId;        // 0x0
        private static System.Boolean s_initLog;        // 0x4
        private static System.IO.StreamWriter s_StreamWriter;        // 0x8
        private static System.Collections.Concurrent.ConcurrentStack<Beyond.UnSafeString> s_stack;        // 0x10
        private static Beyond.UnSafeString s_mainCache;        // 0x18
        private static System.String s_LogFilePath;        // 0x20
        private static System.String[] s_logTypeString;        // 0x28

        // Methods
        private System.String get_persistentDataPath() { }
        private System.Void .cctor() { }
        private System.Void SubsystemRegistration() { }
        private System.Void LogInit(System.Boolean forceDebug) { }
        private System.Void InitLocalLogger(System.String path) { }
        private System.Void OnWantsToShutdown() { }
        private System.String FlushFile() { }
        private System.String getLogFileLocalPath() { }
        private System.Void _UnityLogCallback(System.String condition, System.String stackTrace, UnityEngine.LogType type) { }
        private System.Void _UnityLogCallbackThread(System.String condition, System.String stackTrace, UnityEngine.LogType type) { }
        private System.Void _GetTime(Beyond.UnSafeString unSafeString) { }
        private System.Void _GetLogType(Beyond.UnSafeString unSafeString, UnityEngine.LogType type) { }
        private Beyond.UnSafeString Alloc() { }
        private System.Void Release(Beyond.UnSafeString value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class SceneViewMessageLogger, ILogger
    {
        // Fields
        public System.Boolean enabled;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void Log(Beyond.Log.FLogMessage& msg) { }
        private System.Void Log(Beyond.Log.FLogMessage& msg, System.Single lifeTime) { }
        private System.Void ClearLogs(System.String msg) { }
        private System.Void ClearLogsRegex(System.String regexMsg) { }

    }

    // TypeToken: 0x2000015
    public class UnionLogger, ILogger
    {
        // Fields
        private Beyond.Log.ILogger s_consoleLogger;        // 0x10
        private Beyond.Log.ILogger s_netServerLogger;        // 0x18
        private static System.Int32 MAX_MSG_LEN;        // 0x0

        // Methods
        private System.Void SetServerLogger(Beyond.Log.ILogger log) { }
        private System.Void Log(Beyond.Log.FLogMessage& msg) { }
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000016
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.String __Gen_Wrap_0(Beyond.EColorTag P0) { }
        private System.String __Gen_Wrap_1(Beyond.ELogChannel P0) { }
        private System.Void __Gen_Wrap_2(System.Object P0) { }
        private System.Void __Gen_Wrap_3() { }
        private System.Void __Gen_Wrap_4(Beyond.Log.FLogMessage& P0) { }
        private System.Void __Gen_Wrap_5(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_6(Beyond.ELogLevel P0) { }
        private System.Boolean __Gen_Wrap_7(Beyond.ELogLevel P0) { }
        private System.Void __Gen_Wrap_8(Beyond.ELogChannel P0, Beyond.ELogLevel P1, System.Boolean P2) { }
        private System.Boolean __Gen_Wrap_9(Beyond.ELogChannel P0, Beyond.ELogLevel P1) { }
        private System.Void __Gen_Wrap_10(Beyond.ELogChannel P0, Beyond.ELogLevel P1, Beyond.EColorTag P2, System.Object P3, System.Object P4, System.Object P5) { }
        private System.Void __Gen_Wrap_11(Beyond.ELogChannel P0, Beyond.EColorTag P1, System.Object P2, System.Object P3, System.Object P4) { }
        private System.Void __Gen_Wrap_12(Beyond.ELogChannel P0, System.Object P1) { }
        private System.Void __Gen_Wrap_13(Beyond.ELogChannel P0, Beyond.EColorTag P1, System.Object P2) { }
        private System.Void __Gen_Wrap_14(Beyond.ELogChannel P0, Beyond.EColorTag P1, System.Object P2, System.Object P3) { }
        private System.Void __Gen_Wrap_15(Beyond.ELogChannel P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_16(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_17(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        private System.Void __Gen_Wrap_18(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4) { }
        private System.Void __Gen_Wrap_19(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5) { }
        private System.Void __Gen_Wrap_20(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6) { }
        private System.Void __Gen_Wrap_21(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6, System.Object P7) { }
        private System.Void __Gen_Wrap_22(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3) { }
        private System.Void __Gen_Wrap_23(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4) { }
        private System.Void __Gen_Wrap_24(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5) { }
        private System.Void __Gen_Wrap_25(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6) { }
        private System.Void __Gen_Wrap_26(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6, System.Object P7) { }
        private System.Void __Gen_Wrap_27(Beyond.ELogChannel P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Object P5, System.Object P6, System.Object P7, System.Object P8) { }
        private System.Void __Gen_Wrap_28(Beyond.ELogChannel P0, Beyond.EnableLogType P1, Beyond.EColorTag P2, System.Object P3, System.Object P4) { }
        private System.Void __Gen_Wrap_29(Beyond.EnableLogType P0, System.Object P1) { }
        private System.Void __Gen_Wrap_30(Beyond.EnableLogType P0, Beyond.ELogChannel P1, System.Object P2) { }
        private System.Void __Gen_Wrap_31(Beyond.EnableLogType P0, Beyond.ELogChannel P1, Beyond.EColorTag P2, System.Object P3) { }
        private System.Void __Gen_Wrap_32(Beyond.EnableLogType P0, Beyond.ELogChannel P1, Beyond.EColorTag P2, System.Object P3, System.Object P4) { }
        private System.Void __Gen_Wrap_33(System.Boolean P0) { }
        private System.Void __Gen_Wrap_34(Beyond.ELogLevel P0, Beyond.ELogChannel P1, System.Object P2, System.Single P3) { }
        private System.Void __Gen_Wrap_35(Beyond.ELogChannel P0, System.Single P1, System.Object P2) { }
        private System.Void __Gen_Wrap_36(Beyond.ELogLevel P0, Beyond.ELogChannel P1, System.Object P2, System.Object P3) { }
        private System.Void __Gen_Wrap_37(Beyond.ELogLevel P0, Beyond.ELogChannel P1, Beyond.EColorTag P2, System.Object P3, System.Object P4) { }
        private Beyond.DLogger.DebugContext __Gen_Wrap_38() { }
        private Beyond.DLogger.DebugContextScope __Gen_Wrap_39(System.Object P0, Beyond.ELogLevel P1) { }
        private System.String __Gen_Wrap_40(Beyond.ELogLevel P0) { }
        private System.Boolean __Gen_Wrap_42(UnityEngine.LowLevel.PlayerLoopSystem& P0) { }
        private System.Void __Gen_Wrap_43(UnityEngine.LowLevel.PlayerLoopSystem P0, UnityEngine.LowLevel.PlayerLoopSystem& P1, System.Object P2, System.Object P3, System.Boolean P4, System.Boolean P5) { }
        private System.Void __Gen_Wrap_44(UnityEngine.LowLevel.PlayerLoopSystem& P0) { }
        private System.Void __Gen_Wrap_45(Beyond.DLogger.DebugContextScope& P0) { }
        private System.Boolean __Gen_Wrap_46(Beyond.Log.BitArray256& P0) { }
        private System.String __Gen_Wrap_47(Beyond.Log.BitArray256& P0) { }
        private Beyond.Log.BitArray256 __Gen_Wrap_48(Beyond.Log.BitArray256 P0) { }
        private Beyond.Log.BitArray256 __Gen_Wrap_49(Beyond.Log.BitArray256 P0, Beyond.Log.BitArray256 P1) { }
        private System.Boolean __Gen_Wrap_50(Beyond.Log.BitArray256 P0, Beyond.Log.BitArray256 P1) { }
        private System.Boolean __Gen_Wrap_51(Beyond.Log.BitArray256& P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_52(Beyond.Log.BitArray256& P0) { }
        private System.Boolean __Gen_Wrap_53(Beyond.Log.BitArray256& P0, System.Byte P1) { }
        private System.Void __Gen_Wrap_54(Beyond.Log.BitArray256& P0, System.UInt32 P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_55(Beyond.Log.BitArray256& P0) { }
        private Beyond.Log.BitArray256 __Gen_Wrap_56() { }
        private System.Boolean __Gen_Wrap_57() { }
        private System.String __Gen_Wrap_58() { }
        private System.Int32 __Gen_Wrap_59() { }
        private System.String __Gen_Wrap_60(System.Int64 P0, System.Int32 P1, System.Object P2, Beyond.ELogChannel P3, Beyond.EColorTag P4, Beyond.ELogLevel P5) { }
        private System.Void __Gen_Wrap_61(Beyond.ELogLevel P0, System.Object P1, System.Object P2, System.Object P3) { }
        private System.Void __Gen_Wrap_62(System.Object P0, Beyond.Log.FLogMessage& P1) { }
        private Beyond.Log.FLogMessage __Gen_Wrap_63(Beyond.ELogChannel P0, System.Object P1, System.Object P2, UnityEngine.LogType P3) { }
        private Beyond.UnSafeString __Gen_Wrap_64() { }
        private System.Void __Gen_Wrap_65(System.Object P0, System.Object P1, UnityEngine.LogType P2) { }
        private System.Void __Gen_Wrap_66(System.Object P0, Beyond.Log.FLogMessage& P1, System.Single P2) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000017
    public class WrappersManagerImpl
    {
        // Methods
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }

    }

}

