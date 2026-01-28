// ========================================================
// Dumped by @desirepro
// Assembly: RuntimeQuality.dll
// Classes:  88
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000C
    public struct MatchType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType WhiteList;        // 0x0
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType SystemVersion;        // 0x0
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType GPU;        // 0x0
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType CPU;        // 0x0
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType DefaultScore;        // 0x0
        public static Beyond.Scripts.Quality.DeviceInfo.MatchType MemoryCorrection;        // 0x0

    }

    // TypeToken: 0x2000019
    public struct AntiAliasing
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasing None;        // 0x0
        public static Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasing CSAA;        // 0x0
        public static Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasing FXAA;        // 0x0
        public static Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasing MSAA;        // 0x0

    }

    // TypeToken: 0x2000020
    public struct MatchSource
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSource UpClosest;        // 0x0
        public static Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSource DownClosest;        // 0x0
        public static Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSource Matched;        // 0x0
        public static Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSource Override;        // 0x0

    }

    // TypeToken: 0x2000027
    public struct DLSSFrameGenQualityEnum
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnum Auto;        // 0x0
        public static Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnum X1;        // 0x0
        public static Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnum X2;        // 0x0
        public static Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnum X3;        // 0x0

    }

    // TypeToken: 0x200002B
    public struct FrameGenMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.FrameGenQuality.FrameGenMode None;        // 0x0
        public static Beyond.Scripts.Quality.Components.FrameGenQuality.FrameGenMode DLSS;        // 0x0

    }

    // TypeToken: 0x200002D
    public struct FrameRateQualityEnum
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum FPS120;        // 0x0
        public static Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum FPS60;        // 0x0
        public static Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum FPS30;        // 0x0

    }

    // TypeToken: 0x200002F
    public struct ReasonEnum
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum Default;        // 0x0
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum Init;        // 0x0
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum Quality;        // 0x0
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum Dialog;        // 0x0
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum CutScene;        // 0x0
        public static Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum GMCommand;        // 0x0

    }

    // TypeToken: 0x2000031
    public struct FrameRateQualityMobileEnum
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum FPS60;        // 0x0
        public static Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum FPS45;        // 0x0
        public static Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum FPS30;        // 0x0

    }

    // TypeToken: 0x2000035
    public struct HGAnisoLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevel X1;        // 0x0
        public static Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevel X2;        // 0x0
        public static Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevel X4;        // 0x0
        public static Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevel X8;        // 0x0

    }

    // TypeToken: 0x200003E
    public struct TextureQualityEnum
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnum High;        // 0x0
        public static Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnum Medium;        // 0x0
        public static Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnum Low;        // 0x0

    }

    // TypeToken: 0x2000047
    public struct RenderingScaleMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleMode ExHigh;        // 0x0
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleMode High;        // 0x0
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleMode Medium;        // 0x0
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleMode Low;        // 0x0
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleMode ExLow;        // 0x0

    }

    // TypeToken: 0x2000049
    public struct RenderingScaleMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleMode Percent100;        // 0x0
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleMode Percent90;        // 0x0
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleMode Percent80;        // 0x0
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleMode Percent70;        // 0x0
        public static Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleMode Percent60;        // 0x0

    }

    // TypeToken: 0x200004D
    public struct ShaderLodEnum
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum PC600;        // 0x0
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum Mobile500;        // 0x0
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum Mobile400;        // 0x0
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum Mobile300;        // 0x0
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum Mobile200;        // 0x0
        public static Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum Mobile100;        // 0x0

    }

    // TypeToken: 0x2000052
    public struct UpscalerMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.UpscalerQuality.UpscalerMode DLSS;        // 0x0
        public static Beyond.Scripts.Quality.Components.UpscalerQuality.UpscalerMode TAAU;        // 0x0

    }

namespace Beyond.Gameplay.BeyondPerformance
{

    // TypeToken: 0x2000008
    public struct LogicQualityLevel
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.Gameplay.BeyondPerformance.LogicQualityLevel Economy;        // 0x0
        public static Beyond.Gameplay.BeyondPerformance.LogicQualityLevel Balanced;        // 0x0
        public static Beyond.Gameplay.BeyondPerformance.LogicQualityLevel Performance;        // 0x0
        public static Beyond.Gameplay.BeyondPerformance.LogicQualityLevel Max;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct ThermalState
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.Gameplay.BeyondPerformance.ThermalState GameNormal;        // 0x0
        public static Beyond.Gameplay.BeyondPerformance.ThermalState GameFair;        // 0x0
        public static Beyond.Gameplay.BeyondPerformance.ThermalState GameSerious;        // 0x0

    }

    // TypeToken: 0x200000A
    public class LogicQualityConst
    {
        // Fields
        public static System.Single s_reduceQualityLevelFPSThresholdRatio;        // 0x0
        public static System.Single s_recoverQualityLevelFPSThresholdRatio;        // 0x4

        // Methods
        private System.Void .cctor() { }

    }

}

namespace Beyond.PoolCore
{

    // TypeToken: 0x2000003
    public class ListPoolInitializer_RuntimeQuality
    {
        // Fields
        private static System.Boolean s_initialized;        // 0x0

        // Methods
        private System.Void InitializeAtRuntime() { }
        private System.Void Initialize() { }

    }

}

namespace Beyond.Scripts.Quality
{

    // TypeToken: 0x200000B
    public class DeviceInfo
    {
        // Fields
        public UnityEngine.RuntimePlatform m_platform;        // 0x10
        private System.Int32 <DevicesScore>k__BackingField;        // 0x14
        public readonly System.String m_deviceModel;        // 0x18
        public readonly System.String m_deviceName;        // 0x20
        public readonly System.String m_graphicsDeviceName;        // 0x28
        public readonly System.String m_graphicsDeviceVersion;        // 0x30
        public readonly System.String m_cpuDeviceName;        // 0x38
        public readonly System.Int32 m_systemMemorySize;        // 0x40
        public readonly System.Int32 m_GPUMemorySize;        // 0x44
        public readonly System.Int32 m_processorCount;        // 0x48
        public readonly UnityEngine.Rendering.GraphicsDeviceType m_graphicsDeviceType;        // 0x4C
        public Beyond.Scripts.Quality.DeviceMatchRules m_matchRules;        // 0x50
        public Beyond.Scripts.Quality.DeviceMatchResult m_matchResult;        // 0x58
        public System.Boolean bEditorSimulator;        // 0x78
        public readonly System.String m_SystemInfo;        // 0x80
        private static System.String ADRENO_KEY;        // 0x0
        private static System.String ADRENO_PATTERN;        // 0x0
        private static System.String ADRENO_STANDARD_FORMAT;        // 0x0
        private static System.String MALI_KEY;        // 0x0
        private static System.String MALI_PATTERN;        // 0x0
        private static System.String MALI_STANDARD_FORMAT;        // 0x0
        private static System.String POWER_VR_KEY;        // 0x0
        private static System.String POWER_VR_PATTERN;        // 0x0
        private static System.String POWER_VR_STANDARD_FORMAT;        // 0x0
        private static System.String NVIDIA_KEY;        // 0x0
        private static System.String NVIDIA_PATTERN;        // 0x0
        private static System.String NVIDIA_STANDARD_FORMAT;        // 0x0
        private static System.String TITAN_PATTERN;        // 0x0
        private static System.String NVIDIA_FALLBACK;        // 0x0
        private static System.String AMD_KEY;        // 0x0
        private static System.String AMD_PATTERN;        // 0x0
        private static System.String AMD_STANDARD_FORMAT;        // 0x0
        private static System.String AMD_FALLBACK;        // 0x0
        private static System.String INTEL_KEY;        // 0x0
        private static System.String INTEL_PATTERN;        // 0x0
        private static System.String INTEL_STANDARD_FORMAT;        // 0x0
        private static System.String INTEL_PATTERN_2;        // 0x0
        private static System.String INTEL_FALLBACK;        // 0x0

        // Methods
        private System.Int32 get_DevicesScore() { }
        private System.Void set_DevicesScore(System.Int32 value) { }
        private System.Void .ctor(System.String remoteJson) { }
        private System.Void .ctor(UnityEngine.RuntimePlatform platform, System.String deviceName, System.String deviceModel, System.String graphicsDeviceName, System.String graphicsDeviceVersion, System.String systemMemorySize, System.String processorName, System.String processorCount, System.String processorFrequency) { }
        private System.Void SupplementFromRemote(System.String json) { }
        private System.String ToString() { }
        private System.Boolean IsNoMatchDevice() { }
        private System.Boolean IsZeroDevices() { }
        private System.String get_cpuName() { }
        private System.Boolean IsHUAWEIDevice() { }
        private System.Boolean IsQualcommDevice() { }
        private Beyond.Scripts.Quality.DeviceMatchRules LoadingSettingRules() { }
        private System.Int32 GetDeviceScore(System.String remoteJson) { }
        private System.Int32 EditorSimulateGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        private System.Int32 IOSGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        private System.Int32 AndroidGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        private System.Int32 StandaloneGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        private System.Int32 StandaloneOSXGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        private System.Int32 StandalonePS5GetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        private System.Int32 DefaultGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo) { }
        private System.Boolean RuleSuffixMatch(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String name, Beyond.Scripts.Quality.RankingRule& matchedRule) { }
        private System.Boolean RuleFullNameMatch(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String name, Beyond.Scripts.Quality.RankingRule& matchedRule) { }
        private System.Boolean MatchDeviceModeRule(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String deviceModel, Beyond.Scripts.Quality.RankingRule& rule) { }
        private System.Boolean MatchGPURule(Beyond.Scripts.Quality.DeviceMatchRules rules, System.String gpu, Beyond.Scripts.Quality.RankingRule& rule, System.String& standardName) { }
        private System.Boolean StandaloneMatchGPURule(Beyond.Scripts.Quality.DeviceMatchRules rules, System.String gpu, Beyond.Scripts.Quality.RankingRule& rule, System.String& standardName) { }
        private System.String GetNvidiaStandardGPUName(System.String gpu) { }
        private System.String GetAmdStandardGPUName(System.String gpu) { }
        private System.String GetIntelStandardGPUName(System.String gpu) { }
        private System.String GetAdrenoStandardGPUName(System.String gpu) { }
        private System.String GetMaliStandardGPUName(System.String gpu) { }
        private System.String GetPowerVRStandardGPUName(System.String gpu) { }
        private System.Void _ReportMatchRuleFailed(Beyond.Scripts.Quality.DeviceInfo deviceModel) { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200000D
    public struct RankingRule, IEquatable`1
    {
        // Fields
        public System.String regexPattern;        // 0x10
        public System.Int32 targetScore;        // 0x18

        // Methods
        private System.Boolean Equals(Beyond.Scripts.Quality.RankingRule other) { }
        private System.String ToString() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200000E
    public struct MemoryRule, IEquatable`1
    {
        // Fields
        public UnityEngine.Vector2 range;        // 0x10
        public System.Int32 targetScore;        // 0x18

        // Methods
        private System.String ToString() { }
        private System.Boolean Equals(Beyond.Scripts.Quality.MemoryRule other) { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x200000F
    public class ListUtils
    {
        // Methods
        private System.Void AddOrReplace(System.Collections.Generic.List<TItem> source, System.Collections.Generic.List<TItem> remote) { }

    }

    // TypeToken: 0x2000010
    public class DeviceMatchRules
    {
        // Fields
        public System.Int32 DefaultIOSRankingRule;        // 0x10
        public System.Int32 DefaultAndroidScore;        // 0x14
        public System.Int32 DefaultStandAloneScore;        // 0x18
        public System.Int32 DefaultPowerVRScore;        // 0x1C
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> appleWhiteList;        // 0x20
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> appleGPUList;        // 0x28
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> androidWhiteList;        // 0x30
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> adrenoRulesList;        // 0x38
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> maliRulesList;        // 0x40
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> powerVRRulesList;        // 0x48
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> androidGPUWhiteList;        // 0x50
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> androidCPUWhiteList;        // 0x58
        public System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule> iOSMemoryRules;        // 0x60
        public System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule> androidMemoryRules;        // 0x68
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> nvidiaRulesList;        // 0x70
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> amdRulesList;        // 0x78
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> intelRulesList;        // 0x80
        public System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule> standaloneMemoryRules;        // 0x88
        public System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> macSocRulesList;        // 0x90

        // Methods
        private System.Void Combine(Beyond.Scripts.Quality.DeviceMatchRules other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public struct DeviceMatchResult
    {
        // Fields
        private Beyond.Scripts.Quality.RankingRule m_rule;        // 0x10
        private Beyond.Scripts.Quality.DeviceInfo.MatchType m_matchType;        // 0x20
        private System.String gpuStandardName;        // 0x28

        // Methods
        private System.Void .ctor(Beyond.Scripts.Quality.RankingRule r, Beyond.Scripts.Quality.DeviceInfo.MatchType type, System.String gpuStandardName) { }
        private System.String ToString() { }
        private System.Boolean IsNoMatch() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000012
    public struct DeviceQualityMapItem
    {
        // Fields
        public System.String name;        // 0x10
        public System.Int32 deviceScore;        // 0x18
        public System.Int32 defaultLevel;        // 0x1C
        public System.Int32 veryLowLevel;        // 0x20
        public System.Int32 lowLevel;        // 0x24
        public System.Int32 middleLevel;        // 0x28
        public System.Int32 highLevel;        // 0x2C
        public System.Int32 veryHighLevel;        // 0x30

        // Methods
        private System.String ToString() { }
        private UnityEngine.Color getColor(System.Int32 level) { }
        private UnityEngine.Color getVeryLowColor() { }
        private UnityEngine.Color getLowColor() { }
        private UnityEngine.Color getMiddleColor() { }
        private UnityEngine.Color getHighColor() { }
        private UnityEngine.Color getVeryHighColor() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000013
    public class DeviceQualityMap
    {
        // Fields
        public UnityEngine.RuntimePlatform m_platform;        // 0x10
        public System.Collections.Generic.List<Beyond.Scripts.Quality.DeviceQualityMapItem> items;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class QualityConst
    {
        // Fields
        public static System.String SIMULATE_DEVICE_LIST;        // 0x0
        public static System.String SETTING_RULES;        // 0x0
        public static System.String QUALITY_MAP;        // 0x0
        public static System.String QUALITY_TIER_COMPONENTS;        // 0x0

    }

    // TypeToken: 0x2000015
    public class QualityManager : Singleton`1, IDisposable
    {
        // Fields
        private Beyond.Scripts.Quality.DeviceInfo m_deviceInfo;        // 0x10
        private Beyond.Scripts.Quality.DeviceQualityMap m_qualityMap;        // 0x18
        private Beyond.Scripts.Quality.DeviceQualityMapItem m_matchedConfig;        // 0x20
        private System.Collections.Generic.Dictionary<Beyond.GameSetting.GameSettingVideoQuality,System.Int32> m_qualityScoreMap;        // 0x48
        private System.Collections.Generic.List<Beyond.Scripts.Quality.Components.QualityTierLevel> m_qualityTiers;        // 0x50
        private System.Collections.Generic.HashSet<System.Type> m_qualityTierTypes;        // 0x58
        private System.Collections.Generic.Dictionary<System.Type,Beyond.Scripts.Quality.Components.QualityTierComponentMatch> m_currentQualityTierComponent;        // 0x60
        private System.Collections.Generic.Dictionary<System.Type,Beyond.Scripts.Quality.Components.QualityTierComponentMatch> m_overrideQualityTierComponent;        // 0x68
        private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Type,System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>>> m_qualityTierComponentChangeCallBack;        // 0x70
        private System.Collections.Generic.Queue<System.ValueTuple<System.Type,System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>>> m_queue;        // 0x78
        private System.Int32 m_defaultTier;        // 0x80
        private System.Int32 m_currentTier;        // 0x84
        private System.Boolean m_overrideFinish;        // 0x88
        private System.Func<System.Type,System.Boolean> resetSaveQualityTier;        // 0x90
        private static System.Collections.Generic.HashSet<System.Int32> s_matchCount;        // 0x0

        // Methods
        private Beyond.Scripts.Quality.DeviceQualityMapItem get_Config() { }
        private System.Int32 get_currentTier() { }
        private System.Int32 get_defaultTier() { }
        private Beyond.Scripts.Quality.DeviceInfo get_device() { }
        private System.Void .ctor() { }
        private System.Void Init(System.String remoteJson) { }
        private System.Void InitOnlyDevice(System.String remoteJson) { }
        private System.Void InitShaderLod() { }
        private System.Void FinishInit() { }
        private System.Boolean get_isInitializing() { }
        private System.Void Dispose() { }
        private System.Void LoadQualityTier(System.String overridePlatform) { }
        private System.Void setQualityTier(System.Int32 qualityTier) { }
        private System.Void ApplyQualityScore() { }
        private System.Void ApplyShaderTier() { }
        private System.Type _GetQualityComponentByName(System.String typeName) { }
        private System.Void SetQualityTierByVideoQuality(Beyond.GameSetting.GameSettingVideoQuality VideoQuality) { }
        private Beyond.GameSetting.GameSettingVideoQuality GetDefaultVideoQuality() { }
        private System.Boolean NoMatchDeviceOrZeroScore() { }
        private System.Boolean IsQualcommDevice() { }
        private System.Boolean IsHUAWEIDevice() { }
        private System.Boolean IsIpadDevice() { }
        private System.Boolean IsVideoQualityEnable(Beyond.GameSetting.GameSettingVideoQuality VideoQuality) { }
        private System.Void InitResetQualityTierComponentFunction(System.Func<System.Type,System.Boolean> func) { }
        private System.Boolean ResetQualityTierComponentValue(System.Type type) { }
        private Beyond.Scripts.Quality.Components.QualityTierComponentMatch _SetQualityTierComponentLevel(System.Type type, System.Int32 level) { }
        private System.Void ForceSetQualityTierComponentLevel(System.String type, System.Int32 level) { }
        private System.Void RevertSetQualityTierComponentLevel(System.String type) { }
        private System.Boolean NeedRestart() { }
        private System.Void ApplyCallBack() { }
        private Beyond.Scripts.Quality.Components.QualityTierComponentMatch _GetOverrideQualityTierComponentLevel(System.Type type) { }
        private Beyond.Scripts.Quality.Components.QualityTierType GetQualityTierComponentTierType(System.String type) { }
        private System.Int32 GetQualityTierComponentTierVersion(System.String type) { }
        private System.Boolean _IsToggleQualityTierComponent(System.String type) { }
        private System.Void _ToggleQualityTierComponentLevel(System.String type, System.Int32 index) { }
        private System.Boolean IsEnumQualityTierComponent(System.String type) { }
        private System.Int32 GetEnumQualityTierComponentCount(System.String type) { }
        private System.Void SetEnumQualityTierComponentCount(System.String type, System.Int32 index) { }
        private System.Boolean IsSliderQualityTierComponent(System.String type) { }
        private System.Void SetSliderQualityTierComponentCount(System.String type, System.Single value) { }
        private UnityEngine.Vector3 GetSliderQualityTierComponent(System.String type) { }
        private System.Boolean InvokeQualityTierComponent(System.String type, System.String functionName, System.Object[] parameters) { }
        private System.Void RegisterQualityTierComponentChange(System.Type tierType, System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> cb) { }
        private System.Void InvokeChangeCallBack(System.Type type, Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        private System.ValueTuple<System.Single,System.Single> GetQualityTierComponentTierCount(System.String type) { }
        private System.Single GetQualityComponentDefaultTier(System.String type) { }
        private System.Single GetQualityComponentTier(System.String type) { }
        private System.Void SetQualityComponentTier(System.String type, System.Single index) { }
        private System.String ToString() { }
        private System.String DebugQualityTierComponentInfo() { }
        private System.Void _ReportQuality() { }
        private System.Void _DynamicInitQualitySetting() { }
        private System.Void _DynamicReleaseQualitySetting() { }
        private System.Void DynamicQualityChange(Beyond.EventData<Beyond.Gameplay.BeyondPerformance.LogicQualityLevel,Beyond.Gameplay.BeyondPerformance.LogicQualityLevel>& data) { }
        private System.Void DynamicThermalChange(Beyond.EventData<Beyond.Gameplay.BeyondPerformance.ThermalState,Beyond.Gameplay.BeyondPerformance.ThermalState>& data) { }
        private System.Void .cctor() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000017
    public class QualityUtility
    {
        // Fields
        private static Newtonsoft.Json.JsonSerializerSettings s_settings;        // 0x0

        // Methods
        private T LoadFromCompressedJson() { }
        private T LoadingQualityJson(System.String path) { }
        private T LoadingQualityJsonFromString(System.String value) { }
        private System.Byte[] Decompress(System.Byte[] data) { }
        private Newtonsoft.Json.JsonSerializerSettings get_JsonSerializerSettings() { }

    }

}

namespace Beyond.Scripts.Quality.Components
{

    // TypeToken: 0x2000018
    public class AntiAliasingQuality : EnumQualityComponent`1
    {
        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200001A
    public interface IEnumQualityComponent
    {
        // Methods
        private System.Int32 GetEnumIndex(System.Enum enumValue) { }
        private System.Int32 GetEnumIndex() { }
        private System.Int32 GetDefaultEnumIndex() { }
        private System.Int32 GetEnumCount() { }
        private System.Void SetEnumIndex(System.Int32 value) { }
        private System.String GetEnumName(System.Int32 index) { }

    }

    // TypeToken: 0x200001B
    public class EnumQualityComponent`1 : QualityTierComponent, IEnumQualityComponent, IQualityComponentExtension`1
    {
        // Fields
        private T enumValue;        // 0x0
        private System.Nullable<System.Int32> m_currentValue;        // 0x0
        private System.String[] m_strings;        // 0x0

        // Methods
        private System.Int32 GetEnumIndex(System.Enum enumValue) { }
        private System.Int32 GetEnumIndex() { }
        private System.Int32 GetDefaultEnumIndex() { }
        private System.Int32 GetEnumCount() { }
        private System.Void SetEnumIndex(System.Int32 value) { }
        private System.String GetEnumName(System.Int32 index) { }
        private System.Void SetEnum(T value) { }
        private T GetValue() { }
        private T GetDefaultValue() { }
        private System.Void SetEnumWithOutApply(T value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001C
    public struct QualityTierType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Quality.Components.QualityTierType Quality;        // 0x0
        public static Beyond.Scripts.Quality.Components.QualityTierType ToggleQuality;        // 0x0
        public static Beyond.Scripts.Quality.Components.QualityTierType EnumQuality;        // 0x0
        public static Beyond.Scripts.Quality.Components.QualityTierType SliderQuality;        // 0x0

    }

    // TypeToken: 0x200001D
    public interface IQualityComponentExtension`1
    {
        // Methods
        private T GetValue() { }
        private T GetDefaultValue() { }

    }

    // TypeToken: 0x200001E
    public class QualityTierComponent
    {
        // Fields
        private System.Boolean isNeedStartDirty;        // 0x10

        // Methods
        private System.Void Apply() { }
        private System.Void InitApply() { }
        private System.Void LowMemory() { }
        private System.Void DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last) { }
        private System.Void DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last) { }
        private System.Int32 Version() { }
        private System.Int32 ApplyOrder() { }
        private System.Void SafeApply() { }
        private System.Void SafeLowMemory(System.Boolean init) { }
        private System.Void CallDynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last) { }
        private System.Void CallDynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public struct QualityTierComponentMatch
    {
        // Fields
        public Beyond.Scripts.Quality.Components.QualityTierComponent component;        // 0x10
        public Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSource matchSource;        // 0x18
        public System.Int32 matchQualityTier;        // 0x1C

    }

    // TypeToken: 0x2000021
    public class QualityTierLevel
    {
        // Fields
        public System.Int32 qualityTier;        // 0x10
        public System.Collections.Generic.List<Beyond.Scripts.Quality.Components.QualityTierComponent> qualityTierComponents;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000022
    public class SliderQualityComponent : QualityTierComponent
    {
        // Fields
        private System.Single sliderValue;        // 0x18
        private System.Single MaxSliderValue;        // 0x1C
        private System.Single MinSliderValue;        // 0x20
        private System.Nullable<System.Single> m_currentSliderValue;        // 0x24

        // Methods
        private System.Single GetValue() { }
        private System.Single GetDefaultValue() { }
        private UnityEngine.Vector2 GetRange() { }
        private System.Void SetValue(System.Single value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public class ToggleQualityComponent : QualityTierComponent, IQualityComponentExtension`1
    {
        // Fields
        private System.Boolean toggleVal;        // 0x18
        private System.Nullable<System.Boolean> m_currentValue;        // 0x19

        // Methods
        private System.Void Apply() { }
        private System.Void Toggle(System.Boolean value) { }
        private System.Void ChangeToggle(System.Int32 index) { }
        private System.Boolean GetValue() { }
        private System.Boolean GetDefaultValue() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000024
    public class CharacterRenderFeatureQuality : QualityTierComponent
    {
        // Fields
        public System.Int32 characterSelfShadowOffLodQuality;        // 0x18
        public System.Int32 characterShadowTierLevel;        // 0x1C
        public System.Int32 characterOutlineTierLevel;        // 0x20

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000025
    public class ChromaticAberrationQuality : ToggleQualityComponent
    {
        // Fields
        private static System.Int32 ENABLE_TIER;        // 0x0
        private static System.Int32 DISABLE_TIER;        // 0x0

        // Methods
        private System.Void Toggle(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Toggle(System.Boolean P0) { }

    }

    // TypeToken: 0x2000026
    public class DLSSFrameGenQuality : EnumQualityComponent`1
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;        // 0x30

        // Methods
        private System.Void Apply() { }
        private System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        private System.Boolean ShouldShowAuto() { }
        private System.Boolean ShouldShowX1() { }
        private System.Boolean ShouldShowX2() { }
        private System.Boolean ShouldShowX3() { }
        private System.Boolean ShouldShow() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000028
    public class DLSSUpscalerQuality : EnumQualityComponent`1
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;        // 0x30

        // Methods
        private System.Void Apply() { }
        private System.Boolean ShouldShow() { }
        private System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000029
    public class EnvironmentRenderingFeatureQuality : QualityTierComponent
    {
        // Fields
        public System.Int32 environmentRenderingFeatureQualityTier;        // 0x18

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200002A
    public class FrameGenQuality : EnumQualityComponent`1
    {
        // Methods
        private System.Void Apply() { }
        private System.Boolean ShouldShow() { }
        private System.Boolean ShouldShowDLSS() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200002C
    public class FrameRateQuality : EnumQualityComponent`1
    {
        // Methods
        private System.Int32 get_frameRate() { }
        private System.Int32 GetFrameRateFromEnum(Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum enumValue) { }
        private System.Int32 Version() { }
        private System.Boolean ShouldShow() { }
        private System.Void Apply() { }
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        private System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        private System.Boolean _FPS30Enabled() { }
        private System.Boolean _FPS60Enabled() { }
        private System.Boolean _FPSBNoLimitEnabled() { }
        private System.Boolean _IsGDLSSGDisable() { }
        private System.Void .ctor() { }
        private System.Int32 <>iFixBaseProxy_Version() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200002E
    public class HgFrameRateControl
    {
        // Fields
        public static System.Int32 s_cinematicFrameRate;        // 0x0
        public static System.Collections.Generic.Stack<System.ValueTuple<System.Int32,System.Int32,Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum>> s_rateStack;        // 0x8
        public static System.Action<System.Int32,System.Int32> s_OnFrameRateChanged;        // 0x10

        // Methods
        private System.Int32 GetDefaultFrameRate() { }
        private System.Void Init() { }
        private System.Void SetFrameRateOverrider(System.Int32 frameRate, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum reason) { }
        private System.Int32 GetFrameRate() { }
        private System.Boolean IsHighFrameRate() { }
        private System.Int32 RecommendedDefaultFrameRate() { }
        private System.Int32 GetUserSettingFrameRate() { }
        private System.Void __ForceSetFrameRate(System.Int32 frameRate, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum reason) { }
        private System.Void ResetFrameRate() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000030
    public class FrameRateQualityMobile : EnumQualityComponent`1
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;        // 0x30

        // Methods
        private System.Int32 get_frameRate() { }
        private System.Int32 GetFrameRateFromEnum(Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum enumValue) { }
        private System.Int32 Version() { }
        private System.Void Apply() { }
        private System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        private System.Void .ctor() { }
        private System.Int32 <>iFixBaseProxy_Version() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000032
    public class GrassSparsityQuality : QualityTierComponent
    {
        // Fields
        public System.Int32 grassSparsityQualityTier;        // 0x18

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000033
    public class HGAmbientOcclusionQuality : QualityTierComponent
    {
        // Fields
        public System.Int32 aoQualityTier;        // 0x18

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000034
    public class HGAnisoLevelQuality : EnumQualityComponent`1
    {
        // Methods
        private System.Void InitApply() { }
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_InitApply() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000036
    public class HGContactShadowQuality : ToggleQualityComponent
    {
        // Fields
        private static System.Int32 ENABLE_TIER;        // 0x0
        private static System.Int32 DISABLE_TIER;        // 0x0

        // Methods
        private System.Void Toggle(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Toggle(System.Boolean P0) { }

    }

    // TypeToken: 0x2000037
    public class HGIrradianceVolumeQuality : QualityTierComponent
    {
        // Methods
        private System.Void LowMemory() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_LowMemory() { }

    }

    // TypeToken: 0x2000038
    public class HGLODStreamingComponent : QualityTierComponent
    {
        // Fields
        public System.Boolean enableLODStreaming;        // 0x18

        // Methods
        private System.Void Apply() { }
        private System.Void LowMemory() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }
        private System.Void <>iFixBaseProxy_LowMemory() { }

    }

    // TypeToken: 0x2000039
    public class HGReflectionProbeBinningQuality : QualityTierComponent
    {
        // Methods
        private System.Void LowMemory() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_LowMemory() { }

    }

    // TypeToken: 0x200003A
    public class HGRPTierQuality : QualityTierComponent
    {
        // Fields
        public System.Int32 HGRP_QualityTier;        // 0x18

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200003B
    public class HGScreenSpaceReflectionQuality : QualityTierComponent
    {
        // Fields
        public System.Int32 ssrQualityTier;        // 0x18

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200003C
    public class HGShadowQuality : QualityTierComponent
    {
        // Fields
        public System.Int32 shadowQualityTier;        // 0x18

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200003D
    public class HGTextureQuality : EnumQualityComponent`1
    {
        // Methods
        private System.Int32 get_textureQualityTier() { }
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200003F
    public class HGVolumetricFogQuality : QualityTierComponent
    {
        // Fields
        public System.Int32 volumetricFogQualityTier;        // 0x18

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000040
    public class LODGroupQuality : QualityTierComponent
    {
        // Fields
        public System.Single lodBias;        // 0x18
        public System.Int32 lodOffset;        // 0x1C

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000041
    public class PhysicsClothQuality : QualityTierComponent
    {
        // Fields
        public System.Boolean UsePhysicCloth;        // 0x18
        public System.Boolean UseCrossFrameJob;        // 0x19

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000042
    public class PrefabInstantiateQuality : QualityTierComponent
    {
        // Fields
        public System.Single normalMaxUpdateTimeInMsThreshold;        // 0x18
        public System.Single busyMaxUpdateTimeInMsThreshold;        // 0x1C
        public System.Single burstMaxUpdateTimeInMsThreshold;        // 0x20
        public System.Single normalUnloadMaxUpdateTimeInMsThreshold;        // 0x24
        public System.Single burstUnloadMaxUpdateTimeInMsThreshold;        // 0x28
        public System.Single normalCallbackMaxUpdateTimeInMsThreshold;        // 0x2C
        public System.Single burstCallbackMaxUpdateTimeInMsThreshold;        // 0x30
        public System.Int32 normalMaxDestroyCount;        // 0x34

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000043
    public class PreloadLoadSettingQuality : QualityTierComponent
    {
        // Fields
        public System.Single normalMaxUpdateTimeInMsThreshold;        // 0x18
        public System.Single busyMaxUpdateTimeInMsThreshold;        // 0x1C
        public System.Single burstMaxUpdateTimeInMsThreshold;        // 0x20
        public System.Single normalUnloadMaxUpdateTimeInMsThreshold;        // 0x24
        public System.Single burstUnloadMaxUpdateTimeInMsThreshold;        // 0x28
        public System.Single normalCallbackMaxUpdateTimeInMsThreshold;        // 0x2C
        public System.Single burstCallbackMaxUpdateTimeInMsThreshold;        // 0x30
        public System.Single preloadManagerUnloadKeepTime;        // 0x34

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000044
    public class RayTracingQuality : ToggleQualityComponent
    {
        // Methods
        private System.Boolean get_supportsRayTracing() { }
        private System.Void InitApply() { }
        private System.Void Apply() { }
        private System.Boolean ShouldShow() { }
        private System.Int32 ApplyOrder() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_InitApply() { }
        private System.Void <>iFixBaseProxy_Apply() { }
        private System.Int32 <>iFixBaseProxy_ApplyOrder() { }

    }

    // TypeToken: 0x2000045
    public class ReflexQuality : EnumQualityComponent`1
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;        // 0x30

        // Methods
        private System.Void Apply() { }
        private System.Boolean ShouldShow() { }
        private System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000046
    public class RenderingScaleQualityMobile : EnumQualityComponent`1
    {
        // Methods
        private System.Single get_renderingScaleFactor() { }
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000048
    public class RenderingScaleQualityPC : EnumQualityComponent`1
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;        // 0x30

        // Methods
        private System.Single get_renderingScale() { }
        private System.Void Apply() { }
        private System.Boolean ShouldShow() { }
        private System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200004A
    public class ResLoadSettingQuality : QualityTierComponent
    {
        // Fields
        public System.Boolean debugCloseBundleUnload;        // 0x18
        public System.Boolean debugCloseBundleUnloadUntilBurstMode;        // 0x19
        public System.Boolean enableForceSyncUnload;        // 0x1A
        public System.Boolean enableUnloadLocker;        // 0x1B
        public System.Int32 enableUnloadLockerBundleNum;        // 0x1C
        public System.Int32 maxUnloadOpNum_Normal;        // 0x20
        public System.Int32 maxUnloadOpNum_BusyMode;        // 0x24
        public System.Int32 bundleFrameDelayToUnload_NormalMode;        // 0x28
        public System.Int32 bundleFrameDelayToUnload_BusyMode;        // 0x2C
        public System.Int32 bundleFrameDelayToUnload_BurstMode;        // 0x30
        public System.Int32 bundleFrameDelayToUnload_SwitchScene;        // 0x34
        public System.Int32 bundleFrameDelayToUnload_Fast;        // 0x38
        public System.Int32 enterBusyOperationNum;        // 0x3C
        public System.Int32 exitBusyOperationNum;        // 0x40
        public System.Single unloadBudgetFloatingCoefficient;        // 0x44
        public System.Single unloadMaxFloatingBudget;        // 0x48

        // Methods
        private System.Void Apply() { }
        private System.Void LowMemory() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }
        private System.Void <>iFixBaseProxy_LowMemory() { }

    }

    // TypeToken: 0x200004B
    public class SceneDetailQuality : QualityTierComponent
    {
        // Fields
        public System.Int32 sceneDetailQualityTier;        // 0x18

        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200004C
    public class ShaderLodQuality : QualityTierComponent
    {
        // Fields
        public Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnum ShaderLod;        // 0x18

        // Methods
        private System.Void InitApply() { }
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_InitApply() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200004E
    public class SharpnessQuality : SliderQualityComponent
    {
        // Methods
        private System.Void Apply() { }
        private System.Boolean ShouldShow() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x200004F
    public class SliderTestComponent : SliderQualityComponent
    {
        // Methods
        private System.Void Apply() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000050
    public class TickExclusiveQuality : QualityTierComponent
    {
        // Fields
        public Beyond.TickExclusiveMode quality;        // 0x18
        private Beyond.Gameplay.BeyondPerformance.LogicQualityLevel m_currentQuality;        // 0x1C
        private Beyond.Gameplay.BeyondPerformance.ThermalState m_currentThermalState;        // 0x1D

        // Methods
        private System.Void Apply() { }
        private System.Void DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last) { }
        private System.Void DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last) { }
        private System.Void _OnQualityOrThermalChanged() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }
        private System.Void <>iFixBaseProxy_DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P0, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P1) { }
        private System.Void <>iFixBaseProxy_DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState P0, Beyond.Gameplay.BeyondPerformance.ThermalState P1) { }

    }

    // TypeToken: 0x2000051
    public class UpscalerQuality : EnumQualityComponent`1
    {
        // Methods
        private System.Void Apply() { }
        private System.Boolean ShouldShow() { }
        private System.Boolean ShouldShowDLSS() { }
        private System.Int32 Version() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }
        private System.Int32 <>iFixBaseProxy_Version() { }

    }

    // TypeToken: 0x2000053
    public class VSyncQuality : QualityTierComponent
    {
        // Fields
        public System.Boolean bVSync;        // 0x18

        // Methods
        private System.Void Apply() { }
        private System.Void Remove() { }
        private System.Void Init() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Apply() { }

    }

    // TypeToken: 0x2000054
    public class VSyncQualityV2 : ToggleQualityComponent
    {
        // Fields
        private System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> callback;        // 0x20

        // Methods
        private System.Void Toggle(System.Boolean value) { }
        private System.Void Init() { }
        private System.Int32 Version() { }
        private System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        private System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent) { }
        private System.Boolean ShouldShow() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Toggle(System.Boolean P0) { }
        private System.Int32 <>iFixBaseProxy_Version() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000004
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000002
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000055
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Void __Gen_Wrap_0() { }
        private System.Void __Gen_Wrap_1(System.Object P0, System.Object P1) { }
        private System.String __Gen_Wrap_2(Beyond.Scripts.Quality.RankingRule& P0) { }
        private System.String __Gen_Wrap_3(Beyond.Scripts.Quality.DeviceMatchResult& P0) { }
        private System.String __Gen_Wrap_4(System.Object P0) { }
        private System.Boolean __Gen_Wrap_5(Beyond.Scripts.Quality.DeviceMatchResult& P0) { }
        private System.Boolean __Gen_Wrap_6(System.Object P0) { }
        private Beyond.Scripts.Quality.DeviceMatchRules __Gen_Wrap_7(System.Object P0) { }
        private System.String __Gen_Wrap_8(System.Object P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_9(System.Object P0, System.Object P1, System.Object P2, Beyond.Scripts.Quality.RankingRule& P3) { }
        private System.Boolean __Gen_Wrap_10(System.Object P0, System.Object P1, System.Object P2, Beyond.Scripts.Quality.RankingRule& P3, System.String& P4) { }
        private System.Void __Gen_Wrap_11(System.Object P0) { }
        private System.Int32 __Gen_Wrap_12(System.Object P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_13(System.Object P0, System.Object P1, Beyond.Scripts.Quality.RankingRule& P2) { }
        private System.Boolean __Gen_Wrap_14(Beyond.Scripts.Quality.RankingRule& P0, Beyond.Scripts.Quality.RankingRule P1) { }
        private System.String __Gen_Wrap_15(Beyond.Scripts.Quality.MemoryRule& P0) { }
        private System.Boolean __Gen_Wrap_16(Beyond.Scripts.Quality.MemoryRule& P0, Beyond.Scripts.Quality.MemoryRule P1) { }
        private System.String __Gen_Wrap_17(Beyond.Scripts.Quality.DeviceQualityMapItem& P0) { }
        private UnityEngine.Color __Gen_Wrap_18(Beyond.Scripts.Quality.DeviceQualityMapItem& P0, System.Int32 P1) { }
        private UnityEngine.Color __Gen_Wrap_19(Beyond.Scripts.Quality.DeviceQualityMapItem& P0) { }
        private System.Int32 __Gen_Wrap_20(System.Object P0) { }
        private System.Int32 __Gen_Wrap_21(Beyond.Scripts.Quality.Components.QualityTierLevel P0) { }
        private System.Int32 __Gen_Wrap_22(Beyond.Scripts.Quality.DeviceQualityMapItem P0) { }
        private Beyond.Scripts.Quality.Components.QualityTierComponentMatch __Gen_Wrap_23(System.Object P0, System.Object P1, System.Int32 P2) { }
        private System.Int32 __Gen_Wrap_24(Beyond.Scripts.Quality.Components.QualityTierComponentMatch P0) { }
        private System.Void __Gen_Wrap_25(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_26(System.Object P0, System.Boolean P1) { }
        private Beyond.Scripts.Quality.Components.QualityTierComponentMatch __Gen_Wrap_27(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_28(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_29(System.Object P0, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P1, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P2) { }
        private System.Void __Gen_Wrap_30(System.Object P0, Beyond.EventData<Beyond.Gameplay.BeyondPerformance.LogicQualityLevel,Beyond.Gameplay.BeyondPerformance.LogicQualityLevel>& P1) { }
        private System.Void __Gen_Wrap_31(System.Object P0, Beyond.Gameplay.BeyondPerformance.ThermalState P1, Beyond.Gameplay.BeyondPerformance.ThermalState P2) { }
        private System.Void __Gen_Wrap_32(System.Object P0, Beyond.EventData<Beyond.Gameplay.BeyondPerformance.ThermalState,Beyond.Gameplay.BeyondPerformance.ThermalState>& P1) { }
        private System.Type __Gen_Wrap_33(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_34(System.Object P0, System.Object P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_35(System.Object P0, Beyond.GameSetting.GameSettingVideoQuality P1) { }
        private Beyond.GameSetting.GameSettingVideoQuality __Gen_Wrap_36(System.Object P0) { }
        private System.Boolean __Gen_Wrap_37() { }
        private System.Boolean __Gen_Wrap_38(System.Object P0, System.Object P1) { }
        private Beyond.Scripts.Quality.Components.QualityTierType __Gen_Wrap_39(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_40(System.Object P0, System.Single P1) { }
        private System.Void __Gen_Wrap_41(System.Object P0, System.Object P1, System.Single P2) { }
        private UnityEngine.Vector2 __Gen_Wrap_42(System.Object P0) { }
        private System.Single __Gen_Wrap_43(System.Object P0) { }
        private UnityEngine.Vector3 __Gen_Wrap_44(System.Object P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_45(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        private System.ValueTuple<System.Single,System.Single> __Gen_Wrap_46(System.Object P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_47(System.Int32 P0, System.Int32 P1) { }
        private System.Single __Gen_Wrap_48(System.Object P0, System.Object P1) { }
        private System.Byte[] __Gen_Wrap_49(System.Object P0) { }
        private Newtonsoft.Json.JsonSerializerSettings __Gen_Wrap_50() { }
        private System.Void __Gen_Wrap_51(System.Object P0, System.Runtime.Serialization.StreamingContext P1) { }
        private System.Int32 __Gen_Wrap_52(Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum P0) { }
        private System.Void __Gen_Wrap_53(System.Int32 P0, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum P1) { }
        private System.Int32 __Gen_Wrap_54() { }
        private System.Int32 __Gen_Wrap_55(Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum P0) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000056
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000057
    public class WrappersManagerImpl, WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }
        private System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        private System.Object CreateWrapper(System.Int32 id) { }
        private System.Object InitWrapperArray(System.Int32 len) { }
        private IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000058
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-Initialize0;        // 0x0
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-InitializeAtRuntime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceMatchRules-Combine0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-SupplementFromRemote0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-RankingRule-ToString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceMatchResult-ToString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-ToString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceMatchResult-IsNoMatch0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-IsNoMatchDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-IsZeroDevices0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-IsHUAWEIDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-IsQualcommDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-LoadingSettingRules0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetNvidiaStandardGPUName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-RuleSuffixMatch0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetAmdStandardGPUName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetIntelStandardGPUName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-StandaloneMatchGPURule0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-_ReportMatchRuleFailed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-StandaloneGetMatchedRule0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetDeviceScore0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-RuleFullNameMatch0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-MatchDeviceModeRule0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetAdrenoStandardGPUName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetMaliStandardGPUName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-MatchGPURule0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-AndroidGetMatchedRule0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-IOSGetMatchedRule0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-DefaultGetMatchedRule0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-EditorSimulateGetMatchedRule0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-StandaloneOSXGetMatchedRule0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-StandalonePS5GetMatchedRule0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceInfo-GetPowerVRStandardGPUName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-RankingRule-Equals0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-MemoryRule-ToString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-MemoryRule-Equals0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-ToString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryLowColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getLowColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getMiddleColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getHighColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryHighColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-ApplyOrder0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-LoadQualityTier0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_SetQualityTierComponentLevel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-InitApply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-LowMemory0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-InvokeChangeCallBack0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-SafeApply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-SafeLowMemory0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_GetOverrideQualityTierComponentLevel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ApplyCallBack0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-setQualityTier0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ApplyQualityScore0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicQualityChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicQualityChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-DynamicQualityChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicThermalChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicThermalChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-DynamicThermalChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_DynamicInitQualitySetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-InitOnlyDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_GetQualityComponentByName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ForceSetQualityTierComponentLevel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-FinishInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ApplyShaderTier0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-InitShaderLod0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_DynamicReleaseQualitySetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-SetQualityTierByVideoQuality0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetDefaultVideoQuality0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-NoMatchDeviceOrZeroScore0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-IsQualcommDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-IsHUAWEIDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-IsIpadDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-InitResetQualityTierComponentFunction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ResetQualityTierComponentValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-RevertSetQualityTierComponentLevel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-NeedRestart0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-QualityTierComponent-Version0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierVersion0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_IsToggleQualityTierComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ToggleQualityComponent-ChangeToggle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_ToggleQualityTierComponentLevel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-IsEnumQualityTierComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetEnumQualityTierComponentCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-SetEnumQualityTierComponentCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-IsSliderQualityTierComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SliderQualityComponent-SetValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-SetSliderQualityTierComponentCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SliderQualityComponent-GetRange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SliderQualityComponent-GetValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetSliderQualityTierComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-InvokeQualityTierComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetDefaultValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SliderQualityComponent-GetDefaultValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetQualityComponentDefaultTier0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-GetQualityComponentTier0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-_ReportQuality0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-SetQualityComponentTier0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-ToString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityManager-DebugQualityTierComponentInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityUtility-Decompress0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-QualityUtility-get_JsonSerializerSettings0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-AntiAliasingQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ToggleQualityComponent-Toggle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ToggleQualityComponent-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-CharacterRenderFeatureQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ChromaticAberrationQuality-Toggle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-DlSSChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-OnDeserialized0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowAuto0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX10;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX20;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX30;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-ShouldShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-DlSSChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-OnDeserialized0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-EnvironmentRenderingFeatureQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameGenQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShowDLSS0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-GetFrameRateFromEnum0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-Version0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-ShouldShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-__ForceSetFrameRate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-DlSSChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-OnDeserialized0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS30Enabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS60Enabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-_FPSBNoLimitEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQuality-_IsGDLSSGDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-GetDefaultFrameRate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-SetFrameRateOverrider0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-GetFrameRate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-RecommendedDefaultFrameRate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-GetUserSettingFrameRate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HgFrameRateControl-ResetFrameRate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQualityMobile-GetFrameRateFromEnum0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Version0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-FrameRateQualityMobile-OnDeserialized0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-GrassSparsityQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGAmbientOcclusionQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-InitApply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGContactShadowQuality-Toggle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGIrradianceVolumeQuality-LowMemory0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGLODStreamingComponent-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGLODStreamingComponent-LowMemory0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGReflectionProbeBinningQuality-LowMemory0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGRPTierQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGScreenSpaceReflectionQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGShadowQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGTextureQuality-get_textureQualityTier0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGTextureQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-HGVolumetricFogQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-LODGroupQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-PhysicsClothQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-PrefabInstantiateQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-PreloadLoadSettingQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RayTracingQuality-InitApply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RayTracingQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RayTracingQuality-ShouldShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RayTracingQuality-ApplyOrder0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ReflexQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ReflexQuality-ShouldShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ReflexQuality-DlSSChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ReflexQuality-OnDeserialized0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-get_renderingScaleFactor0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-get_renderingScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-ShouldShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-DlSSChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-OnDeserialized0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ResLoadSettingQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ResLoadSettingQuality-LowMemory0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SceneDetailQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ShaderLodQuality-InitApply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-ShaderLodQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SharpnessQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SharpnessQuality-ShouldShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-SliderTestComponent-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-TickExclusiveQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-TickExclusiveQuality-_OnQualityOrThermalChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicQualityChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicThermalChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-UpscalerQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowDLSS0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-UpscalerQuality-Version0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQuality-Apply0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQuality-Remove0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQuality-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-Toggle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-Version0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-DlSSChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-OnDeserialized0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Quality-Components-VSyncQualityV2-ShouldShow0;        // 0x0

    }

}

