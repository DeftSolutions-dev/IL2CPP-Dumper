// ========================================================
// Dumped by @desirepro
// Assembly: Sirenix.Serialization.Config.dll
// Classes:  8
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Sirenix.Serialization.CustomLogger
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private           System.Action<System.String>    logWarningDelegate  // 0x10
  private           System.Action<System.String>    logErrorDelegate  // 0x18
  private           System.Action<System.Exception> logExceptionDelegate  // 0x20
METHODS:
  System.Void .ctor(System.Action<System.String> logWarningDelegate, System.Action<System.String> logErrorDelegate, System.Action<System.Exception> logExceptionDelegate)
  System.Void LogWarning(System.String warning)
  System.Void LogError(System.String error)
  System.Void LogException(System.Exception exception)
END_CLASS

CLASS: Sirenix.Serialization.DataFormat
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Sirenix.Serialization.DataFormatBinary  // 0x0
  public    static  Sirenix.Serialization.DataFormatJSON  // 0x0
  public    static  Sirenix.Serialization.DataFormatNodes  // 0x0
METHODS:
END_CLASS

CLASS: Sirenix.Serialization.DefaultLoggers
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private   static readonly System.Object                   LOCK  // 0x0
  private   static  Sirenix.Serialization.ILogger   unityLogger  // 0x8
METHODS:
  Sirenix.Serialization.ILogger get_DefaultLogger()
  Sirenix.Serialization.ILogger get_UnityLogger()
  System.Void .cctor()
END_CLASS

CLASS: Sirenix.Serialization.ErrorHandlingPolicy
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Sirenix.Serialization.ErrorHandlingPolicyResilient  // 0x0
  public    static  Sirenix.Serialization.ErrorHandlingPolicyThrowOnErrors  // 0x0
  public    static  Sirenix.Serialization.ErrorHandlingPolicyThrowOnWarningsAndErrors  // 0x0
METHODS:
END_CLASS

CLASS: Sirenix.Serialization.GlobalSerializationConfig
TYPE:  class
TOKEN: 0x2000006
EXTENDS: GlobalConfig`1
FIELDS:
  public    static  System.String                   ODIN_SERIALIZATION_CAUTIONARY_WARNING_TEXT  // 0x0
  public    static  System.String                   ODIN_PREFAB_CAUTIONARY_WARNING_TEXT  // 0x0
  public    static  System.String                   ODIN_SERIALIZATION_CAUTIONARY_WARNING_BUTTON_TEXT  // 0x0
  public    static  System.String                   ODIN_PREFAB_CAUTIONARY_WARNING_BUTTON_TEXT  // 0x0
  private   static readonly Sirenix.Serialization.DataFormat[]BuildFormats  // 0x0
  public            System.Boolean                  HideSerializationCautionaryMessage  // 0x18
  public            System.Boolean                  HidePrefabCautionaryMessage  // 0x19
  public            System.Boolean                  HideOdinSerializeAttributeWarningMessages  // 0x1A
  public            System.Boolean                  HideNonSerializedShowInInspectorWarningMessages  // 0x1B
  private           Sirenix.Serialization.DataFormatbuildSerializationFormat  // 0x1C
  private           Sirenix.Serialization.DataFormateditorSerializationFormat  // 0x20
  private           Sirenix.Serialization.LoggingPolicyloggingPolicy  // 0x24
  private           Sirenix.Serialization.ErrorHandlingPolicyerrorHandlingPolicy  // 0x28
METHODS:
  Sirenix.Serialization.ILogger get_Logger()
  Sirenix.Serialization.DataFormat get_EditorSerializationFormat()
  System.Void set_EditorSerializationFormat(Sirenix.Serialization.DataFormat value)
  Sirenix.Serialization.DataFormat get_BuildSerializationFormat()
  System.Void set_BuildSerializationFormat(Sirenix.Serialization.DataFormat value)
  Sirenix.Serialization.LoggingPolicy get_LoggingPolicy()
  System.Void set_LoggingPolicy(Sirenix.Serialization.LoggingPolicy value)
  Sirenix.Serialization.ErrorHandlingPolicy get_ErrorHandlingPolicy()
  System.Void set_ErrorHandlingPolicy(Sirenix.Serialization.ErrorHandlingPolicy value)
  System.Void OnInspectorGUI()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Sirenix.Serialization.ILogger
TYPE:  interface
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Void LogWarning(System.String warning)
  System.Void LogError(System.String error)
  System.Void LogException(System.Exception exception)
END_CLASS

CLASS: Sirenix.Serialization.LoggingPolicy
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Sirenix.Serialization.LoggingPolicyLogErrors  // 0x0
  public    static  Sirenix.Serialization.LoggingPolicyLogWarningsAndErrors  // 0x0
  public    static  Sirenix.Serialization.LoggingPolicySilent  // 0x0
METHODS:
END_CLASS

