// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Formats.USD.Common.dll
// Classes:  10
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000005
    public struct UsageAnalyticsData
    {
        // Fields
        public System.Boolean InitSucceeded;        // 0x10
        public System.Double TimeTakenMs;        // 0x18

    }

    // TypeToken: 0x2000006
    public struct ImportAnalyticsData
    {
        // Fields
        public System.String FileExtension;        // 0x10
        public System.Double TimeTakenMs;        // 0x18
        public System.Boolean Succeeded;        // 0x20
        public System.Boolean IncludesMeshes;        // 0x21
        public System.Boolean IncludesPointInstancer;        // 0x22
        public System.Boolean IncludesMaterials;        // 0x23
        public System.Boolean IncludesSkel;        // 0x24

    }

    // TypeToken: 0x2000007
    public struct ImportResult
    {
        // Fields
        public System.Boolean Success;        // 0x10
        public Unity.Formats.USD.ImportType ImportType;        // 0x14
        public System.Boolean ContainsMeshes;        // 0x18
        public System.Boolean ContainsPointInstancer;        // 0x19
        public System.Boolean ContainsSkel;        // 0x1A
        public System.Boolean ContainsMaterials;        // 0x1B

        // Methods
        private Unity.Formats.USD.UsdEditorAnalytics.ImportResult get_Default() { }

    }

    // TypeToken: 0x2000008
    public struct ReimportAnalyticsData
    {
        // Fields
        public System.String FileExtension;        // 0x10
        public System.Double TimeTakenMs;        // 0x18
        public System.Boolean Succeeded;        // 0x20
        public System.Boolean ForceRebuild;        // 0x21
        public System.Boolean IncludesMeshes;        // 0x22
        public System.Boolean IncludesPointInstancer;        // 0x23
        public System.Boolean IncludesMaterials;        // 0x24
        public System.Boolean IncludesSkel;        // 0x25

    }

    // TypeToken: 0x2000009
    public struct ExportAnalyticsData
    {
        // Fields
        public System.String FileExtension;        // 0x10
        public System.Double TimeTakenMs;        // 0x18
        public System.Boolean Succeeded;        // 0x20
        public System.Boolean OnlyOverrides;        // 0x21

    }

    // TypeToken: 0x200000A
    public struct RecorderExportAnalyticsData
    {
        // Fields
        public System.String FileExtension;        // 0x10
        public System.Double TimeTakenMs;        // 0x18
        public System.Boolean Succeeded;        // 0x20
        public System.Boolean OnlyOverrides;        // 0x21
        public System.Int32 FrameCount;        // 0x24

    }

namespace Unity.Formats.USD
{

    // TypeToken: 0x2000002
    public class InitUsd
    {
        // Fields
        private static System.Boolean m_usdInitialized;        // 0x0
        private static System.Boolean m_usdInitializeFailed;        // 0x1
        private static USD.NET.Unity.DiagnosticHandler m_handler;        // 0x8

        // Methods
        private System.Boolean Initialize() { }
        private System.Void SetupUsdPath(System.String sourceFilePath) { }

    }

    // TypeToken: 0x2000003
    public struct ImportType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Formats.USD.ImportType Initial;        // 0x0
        public static Unity.Formats.USD.ImportType ForceRebuild;        // 0x0
        public static Unity.Formats.USD.ImportType Refresh;        // 0x0
        public static Unity.Formats.USD.ImportType Streaming;        // 0x0

    }

    // TypeToken: 0x2000004
    public class UsdEditorAnalytics
    {
        // Fields
        private static System.Int32 k_MaxEventsPerHour;        // 0x0
        private static System.Int32 k_MaxNumberOfElements;        // 0x0
        private static System.String k_VendorKey;        // 0x0
        private static System.String k_UsageEventName;        // 0x0
        private static System.String k_ImportEventName;        // 0x0
        private static System.String k_ReimportEventName;        // 0x0
        private static System.String k_ExportEventName;        // 0x0
        private static System.String k_RecorderExportEventName;        // 0x0
        public static System.Collections.Generic.Dictionary<System.String,System.Boolean> sUsdEditorAnalyticsEvents;        // 0x0

        // Methods
        private System.Boolean RegisterAnalytics(System.String eventName) { }
        private System.Void SendUsageEvent(System.Boolean success, System.Double timeTakenMs) { }
        private System.Void SendImportEvent(System.String fileExtension, System.Double timeTakenMs, Unity.Formats.USD.UsdEditorAnalytics.ImportResult importResult) { }
        private System.Void SendReimportEvent(System.String fileExtension, System.Double timeTakenMs, Unity.Formats.USD.UsdEditorAnalytics.ImportResult importResult) { }
        private System.Void SendExportEvent(System.String fileExtension, System.Double timeTakenMs, System.Boolean exportSucceeded, System.Boolean onlyOverrides) { }
        private System.Void SendRecorderExportEvent(System.String fileExtension, System.Double timeTakenMs, System.Boolean exportSucceeded, System.Boolean onlyOverrides, System.Int32 frameCount) { }
        private System.Void .cctor() { }

    }

}

