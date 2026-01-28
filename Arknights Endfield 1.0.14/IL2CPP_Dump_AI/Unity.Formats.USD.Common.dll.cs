// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Formats.USD.Common.dll
// Classes:  10
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UsageAnalyticsData
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Boolean                  InitSucceeded  // 0x10
  public            System.Double                   TimeTakenMs  // 0x18
METHODS:
END_CLASS

CLASS: ImportAnalyticsData
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.String                   FileExtension  // 0x10
  public            System.Double                   TimeTakenMs  // 0x18
  public            System.Boolean                  Succeeded  // 0x20
  public            System.Boolean                  IncludesMeshes  // 0x21
  public            System.Boolean                  IncludesPointInstancer  // 0x22
  public            System.Boolean                  IncludesMaterials  // 0x23
  public            System.Boolean                  IncludesSkel  // 0x24
METHODS:
END_CLASS

CLASS: ImportResult
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Boolean                  Success  // 0x10
  public            Unity.Formats.USD.ImportType    ImportType  // 0x14
  public            System.Boolean                  ContainsMeshes  // 0x18
  public            System.Boolean                  ContainsPointInstancer  // 0x19
  public            System.Boolean                  ContainsSkel  // 0x1A
  public            System.Boolean                  ContainsMaterials  // 0x1B
METHODS:
  Unity.Formats.USD.UsdEditorAnalytics.ImportResult get_Default()
END_CLASS

CLASS: ReimportAnalyticsData
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.String                   FileExtension  // 0x10
  public            System.Double                   TimeTakenMs  // 0x18
  public            System.Boolean                  Succeeded  // 0x20
  public            System.Boolean                  ForceRebuild  // 0x21
  public            System.Boolean                  IncludesMeshes  // 0x22
  public            System.Boolean                  IncludesPointInstancer  // 0x23
  public            System.Boolean                  IncludesMaterials  // 0x24
  public            System.Boolean                  IncludesSkel  // 0x25
METHODS:
END_CLASS

CLASS: ExportAnalyticsData
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.String                   FileExtension  // 0x10
  public            System.Double                   TimeTakenMs  // 0x18
  public            System.Boolean                  Succeeded  // 0x20
  public            System.Boolean                  OnlyOverrides  // 0x21
METHODS:
END_CLASS

CLASS: RecorderExportAnalyticsData
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.String                   FileExtension  // 0x10
  public            System.Double                   TimeTakenMs  // 0x18
  public            System.Boolean                  Succeeded  // 0x20
  public            System.Boolean                  OnlyOverrides  // 0x21
  public            System.Int32                    FrameCount  // 0x24
METHODS:
END_CLASS

CLASS: Unity.Formats.USD.InitUsd
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static  System.Boolean                  m_usdInitialized  // 0x0
  private   static  System.Boolean                  m_usdInitializeFailed  // 0x1
  private   static  USD.NET.Unity.DiagnosticHandler m_handler  // 0x8
METHODS:
  System.Boolean Initialize()
  System.Void SetupUsdPath(System.String sourceFilePath)
END_CLASS

CLASS: Unity.Formats.USD.ImportType
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Formats.USD.ImportType    Initial  // 0x0
  public    static  Unity.Formats.USD.ImportType    ForceRebuild  // 0x0
  public    static  Unity.Formats.USD.ImportType    Refresh  // 0x0
  public    static  Unity.Formats.USD.ImportType    Streaming  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Formats.USD.UsdEditorAnalytics
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private   static  System.Int32                    k_MaxEventsPerHour  // 0x0
  private   static  System.Int32                    k_MaxNumberOfElements  // 0x0
  private   static  System.String                   k_VendorKey  // 0x0
  private   static  System.String                   k_UsageEventName  // 0x0
  private   static  System.String                   k_ImportEventName  // 0x0
  private   static  System.String                   k_ReimportEventName  // 0x0
  private   static  System.String                   k_ExportEventName  // 0x0
  private   static  System.String                   k_RecorderExportEventName  // 0x0
  public    static  System.Collections.Generic.Dictionary<System.String,System.Boolean>sUsdEditorAnalyticsEvents  // 0x0
METHODS:
  System.Boolean RegisterAnalytics(System.String eventName)
  System.Void SendUsageEvent(System.Boolean success, System.Double timeTakenMs)
  System.Void SendImportEvent(System.String fileExtension, System.Double timeTakenMs, Unity.Formats.USD.UsdEditorAnalytics.ImportResult importResult)
  System.Void SendReimportEvent(System.String fileExtension, System.Double timeTakenMs, Unity.Formats.USD.UsdEditorAnalytics.ImportResult importResult)
  System.Void SendExportEvent(System.String fileExtension, System.Double timeTakenMs, System.Boolean exportSucceeded, System.Boolean onlyOverrides)
  System.Void SendRecorderExportEvent(System.String fileExtension, System.Double timeTakenMs, System.Boolean exportSucceeded, System.Boolean onlyOverrides, System.Int32 frameCount)
  System.Void .cctor()
END_CLASS

