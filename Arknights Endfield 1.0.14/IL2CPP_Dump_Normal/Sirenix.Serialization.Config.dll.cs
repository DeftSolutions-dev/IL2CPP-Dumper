// ========================================================
// Dumped by @desirepro
// Assembly: Sirenix.Serialization.Config.dll
// Classes:  8
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Sirenix.Serialization
{

    // TypeToken: 0x2000002
    public class CustomLogger, ILogger
    {
        // Fields
        private System.Action<System.String> logWarningDelegate;        // 0x10
        private System.Action<System.String> logErrorDelegate;        // 0x18
        private System.Action<System.Exception> logExceptionDelegate;        // 0x20

        // Methods
        private System.Void .ctor(System.Action<System.String> logWarningDelegate, System.Action<System.String> logErrorDelegate, System.Action<System.Exception> logExceptionDelegate) { }
        private System.Void LogWarning(System.String warning) { }
        private System.Void LogError(System.String error) { }
        private System.Void LogException(System.Exception exception) { }

    }

    // TypeToken: 0x2000003
    public struct DataFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Sirenix.Serialization.DataFormat Binary;        // 0x0
        public static Sirenix.Serialization.DataFormat JSON;        // 0x0
        public static Sirenix.Serialization.DataFormat Nodes;        // 0x0

    }

    // TypeToken: 0x2000004
    public class DefaultLoggers
    {
        // Fields
        private static readonly System.Object LOCK;        // 0x0
        private static Sirenix.Serialization.ILogger unityLogger;        // 0x8

        // Methods
        private Sirenix.Serialization.ILogger get_DefaultLogger() { }
        private Sirenix.Serialization.ILogger get_UnityLogger() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000005
    public struct ErrorHandlingPolicy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Sirenix.Serialization.ErrorHandlingPolicy Resilient;        // 0x0
        public static Sirenix.Serialization.ErrorHandlingPolicy ThrowOnErrors;        // 0x0
        public static Sirenix.Serialization.ErrorHandlingPolicy ThrowOnWarningsAndErrors;        // 0x0

    }

    // TypeToken: 0x2000006
    public class GlobalSerializationConfig : GlobalConfig`1
    {
        // Fields
        public static System.String ODIN_SERIALIZATION_CAUTIONARY_WARNING_TEXT;        // 0x0
        public static System.String ODIN_PREFAB_CAUTIONARY_WARNING_TEXT;        // 0x0
        public static System.String ODIN_SERIALIZATION_CAUTIONARY_WARNING_BUTTON_TEXT;        // 0x0
        public static System.String ODIN_PREFAB_CAUTIONARY_WARNING_BUTTON_TEXT;        // 0x0
        private static readonly Sirenix.Serialization.DataFormat[] BuildFormats;        // 0x0
        public System.Boolean HideSerializationCautionaryMessage;        // 0x18
        public System.Boolean HidePrefabCautionaryMessage;        // 0x19
        public System.Boolean HideOdinSerializeAttributeWarningMessages;        // 0x1A
        public System.Boolean HideNonSerializedShowInInspectorWarningMessages;        // 0x1B
        private Sirenix.Serialization.DataFormat buildSerializationFormat;        // 0x1C
        private Sirenix.Serialization.DataFormat editorSerializationFormat;        // 0x20
        private Sirenix.Serialization.LoggingPolicy loggingPolicy;        // 0x24
        private Sirenix.Serialization.ErrorHandlingPolicy errorHandlingPolicy;        // 0x28

        // Methods
        private Sirenix.Serialization.ILogger get_Logger() { }
        private Sirenix.Serialization.DataFormat get_EditorSerializationFormat() { }
        private System.Void set_EditorSerializationFormat(Sirenix.Serialization.DataFormat value) { }
        private Sirenix.Serialization.DataFormat get_BuildSerializationFormat() { }
        private System.Void set_BuildSerializationFormat(Sirenix.Serialization.DataFormat value) { }
        private Sirenix.Serialization.LoggingPolicy get_LoggingPolicy() { }
        private System.Void set_LoggingPolicy(Sirenix.Serialization.LoggingPolicy value) { }
        private Sirenix.Serialization.ErrorHandlingPolicy get_ErrorHandlingPolicy() { }
        private System.Void set_ErrorHandlingPolicy(Sirenix.Serialization.ErrorHandlingPolicy value) { }
        private System.Void OnInspectorGUI() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000007
    public interface ILogger
    {
        // Methods
        private System.Void LogWarning(System.String warning) { }
        private System.Void LogError(System.String error) { }
        private System.Void LogException(System.Exception exception) { }

    }

    // TypeToken: 0x2000008
    public struct LoggingPolicy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Sirenix.Serialization.LoggingPolicy LogErrors;        // 0x0
        public static Sirenix.Serialization.LoggingPolicy LogWarningsAndErrors;        // 0x0
        public static Sirenix.Serialization.LoggingPolicy Silent;        // 0x0

    }

}

