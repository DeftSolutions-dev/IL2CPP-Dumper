// ========================================================
// Dumped by @desirepro
// Assembly: RuntimeQuality.dll
// Classes:  88
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: MatchType
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeWhiteList  // 0x0
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeSystemVersion  // 0x0
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeGPU  // 0x0
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeCPU  // 0x0
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeDefaultScore  // 0x0
  public    static  Beyond.Scripts.Quality.DeviceInfo.MatchTypeMemoryCorrection  // 0x0
METHODS:
END_CLASS

CLASS: AntiAliasing
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasingNone  // 0x0
  public    static  Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasingCSAA  // 0x0
  public    static  Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasingFXAA  // 0x0
  public    static  Beyond.Scripts.Quality.Components.AntiAliasingQuality.AntiAliasingMSAA  // 0x0
METHODS:
END_CLASS

CLASS: MatchSource
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSourceUpClosest  // 0x0
  public    static  Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSourceDownClosest  // 0x0
  public    static  Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSourceMatched  // 0x0
  public    static  Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSourceOverride  // 0x0
METHODS:
END_CLASS

CLASS: DLSSFrameGenQualityEnum
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnumAuto  // 0x0
  public    static  Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnumX1  // 0x0
  public    static  Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnumX2  // 0x0
  public    static  Beyond.Scripts.Quality.Components.DLSSFrameGenQuality.DLSSFrameGenQualityEnumX3  // 0x0
METHODS:
END_CLASS

CLASS: FrameGenMode
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.FrameGenQuality.FrameGenModeNone  // 0x0
  public    static  Beyond.Scripts.Quality.Components.FrameGenQuality.FrameGenModeDLSS  // 0x0
METHODS:
END_CLASS

CLASS: FrameRateQualityEnum
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnumFPS120  // 0x0
  public    static  Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnumFPS60  // 0x0
  public    static  Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnumFPS30  // 0x0
METHODS:
END_CLASS

CLASS: ReasonEnum
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumDefault  // 0x0
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumInit  // 0x0
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumQuality  // 0x0
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumDialog  // 0x0
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumCutScene  // 0x0
  public    static  Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnumGMCommand  // 0x0
METHODS:
END_CLASS

CLASS: FrameRateQualityMobileEnum
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnumFPS60  // 0x0
  public    static  Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnumFPS45  // 0x0
  public    static  Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnumFPS30  // 0x0
METHODS:
END_CLASS

CLASS: HGAnisoLevel
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevelX1  // 0x0
  public    static  Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevelX2  // 0x0
  public    static  Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevelX4  // 0x0
  public    static  Beyond.Scripts.Quality.Components.HGAnisoLevelQuality.HGAnisoLevelX8  // 0x0
METHODS:
END_CLASS

CLASS: TextureQualityEnum
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnumHigh  // 0x0
  public    static  Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnumMedium  // 0x0
  public    static  Beyond.Scripts.Quality.Components.HGTextureQuality.TextureQualityEnumLow  // 0x0
METHODS:
END_CLASS

CLASS: RenderingScaleMode
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleModeExHigh  // 0x0
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleModeHigh  // 0x0
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleModeMedium  // 0x0
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleModeLow  // 0x0
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile.RenderingScaleModeExLow  // 0x0
METHODS:
END_CLASS

CLASS: RenderingScaleMode
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleModePercent100  // 0x0
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleModePercent90  // 0x0
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleModePercent80  // 0x0
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleModePercent70  // 0x0
  public    static  Beyond.Scripts.Quality.Components.RenderingScaleQualityPC.RenderingScaleModePercent60  // 0x0
METHODS:
END_CLASS

CLASS: ShaderLodEnum
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumPC600  // 0x0
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumMobile500  // 0x0
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumMobile400  // 0x0
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumMobile300  // 0x0
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumMobile200  // 0x0
  public    static  Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumMobile100  // 0x0
METHODS:
END_CLASS

CLASS: UpscalerMode
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.UpscalerQuality.UpscalerModeDLSS  // 0x0
  public    static  Beyond.Scripts.Quality.Components.UpscalerQuality.UpscalerModeTAAU  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.BeyondPerformance.LogicQualityLevel
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.BeyondPerformance.LogicQualityLevelEconomy  // 0x0
  public    static  Beyond.Gameplay.BeyondPerformance.LogicQualityLevelBalanced  // 0x0
  public    static  Beyond.Gameplay.BeyondPerformance.LogicQualityLevelPerformance  // 0x0
  public    static  Beyond.Gameplay.BeyondPerformance.LogicQualityLevelMax  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.BeyondPerformance.ThermalState
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.BeyondPerformance.ThermalStateGameNormal  // 0x0
  public    static  Beyond.Gameplay.BeyondPerformance.ThermalStateGameFair  // 0x0
  public    static  Beyond.Gameplay.BeyondPerformance.ThermalStateGameSerious  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.BeyondPerformance.LogicQualityConst
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  public    static  System.Single                   s_reduceQualityLevelFPSThresholdRatio  // 0x0
  public    static  System.Single                   s_recoverQualityLevelFPSThresholdRatio  // 0x4
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Beyond.PoolCore.ListPoolInitializer_RuntimeQuality
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private   static  System.Boolean                  s_initialized  // 0x0
METHODS:
  System.Void InitializeAtRuntime()
  System.Void Initialize()
END_CLASS

CLASS: Beyond.Scripts.Quality.DeviceInfo
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  public            UnityEngine.RuntimePlatform     m_platform  // 0x10
  private           System.Int32                    <DevicesScore>k__BackingField  // 0x14
  public    readonly System.String                   m_deviceModel  // 0x18
  public    readonly System.String                   m_deviceName  // 0x20
  public    readonly System.String                   m_graphicsDeviceName  // 0x28
  public    readonly System.String                   m_graphicsDeviceVersion  // 0x30
  public    readonly System.String                   m_cpuDeviceName  // 0x38
  public    readonly System.Int32                    m_systemMemorySize  // 0x40
  public    readonly System.Int32                    m_GPUMemorySize  // 0x44
  public    readonly System.Int32                    m_processorCount  // 0x48
  public    readonly UnityEngine.Rendering.GraphicsDeviceTypem_graphicsDeviceType  // 0x4C
  public            Beyond.Scripts.Quality.DeviceMatchRulesm_matchRules  // 0x50
  public            Beyond.Scripts.Quality.DeviceMatchResultm_matchResult  // 0x58
  public            System.Boolean                  bEditorSimulator  // 0x78
  public    readonly System.String                   m_SystemInfo  // 0x80
  private   static  System.String                   ADRENO_KEY  // 0x0
  private   static  System.String                   ADRENO_PATTERN  // 0x0
  private   static  System.String                   ADRENO_STANDARD_FORMAT  // 0x0
  private   static  System.String                   MALI_KEY  // 0x0
  private   static  System.String                   MALI_PATTERN  // 0x0
  private   static  System.String                   MALI_STANDARD_FORMAT  // 0x0
  private   static  System.String                   POWER_VR_KEY  // 0x0
  private   static  System.String                   POWER_VR_PATTERN  // 0x0
  private   static  System.String                   POWER_VR_STANDARD_FORMAT  // 0x0
  private   static  System.String                   NVIDIA_KEY  // 0x0
  private   static  System.String                   NVIDIA_PATTERN  // 0x0
  private   static  System.String                   NVIDIA_STANDARD_FORMAT  // 0x0
  private   static  System.String                   TITAN_PATTERN  // 0x0
  private   static  System.String                   NVIDIA_FALLBACK  // 0x0
  private   static  System.String                   AMD_KEY  // 0x0
  private   static  System.String                   AMD_PATTERN  // 0x0
  private   static  System.String                   AMD_STANDARD_FORMAT  // 0x0
  private   static  System.String                   AMD_FALLBACK  // 0x0
  private   static  System.String                   INTEL_KEY  // 0x0
  private   static  System.String                   INTEL_PATTERN  // 0x0
  private   static  System.String                   INTEL_STANDARD_FORMAT  // 0x0
  private   static  System.String                   INTEL_PATTERN_2  // 0x0
  private   static  System.String                   INTEL_FALLBACK  // 0x0
METHODS:
  System.Int32 get_DevicesScore()
  System.Void set_DevicesScore(System.Int32 value)
  System.Void .ctor(System.String remoteJson)
  System.Void .ctor(UnityEngine.RuntimePlatform platform, System.String deviceName, System.String deviceModel, System.String graphicsDeviceName, System.String graphicsDeviceVersion, System.String systemMemorySize, System.String processorName, System.String processorCount, System.String processorFrequency)
  System.Void SupplementFromRemote(System.String json)
  System.String ToString()
  System.Boolean IsNoMatchDevice()
  System.Boolean IsZeroDevices()
  System.String get_cpuName()
  System.Boolean IsHUAWEIDevice()
  System.Boolean IsQualcommDevice()
  Beyond.Scripts.Quality.DeviceMatchRules LoadingSettingRules()
  System.Int32 GetDeviceScore(System.String remoteJson)
  System.Int32 EditorSimulateGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  System.Int32 IOSGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  System.Int32 AndroidGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  System.Int32 StandaloneGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  System.Int32 StandaloneOSXGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  System.Int32 StandalonePS5GetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  System.Int32 DefaultGetMatchedRule(Beyond.Scripts.Quality.DeviceInfo deviceInfo)
  System.Boolean RuleSuffixMatch(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String name, Beyond.Scripts.Quality.RankingRule& matchedRule)
  System.Boolean RuleFullNameMatch(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String name, Beyond.Scripts.Quality.RankingRule& matchedRule)
  System.Boolean MatchDeviceModeRule(System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule> list, System.String deviceModel, Beyond.Scripts.Quality.RankingRule& rule)
  System.Boolean MatchGPURule(Beyond.Scripts.Quality.DeviceMatchRules rules, System.String gpu, Beyond.Scripts.Quality.RankingRule& rule, System.String& standardName)
  System.Boolean StandaloneMatchGPURule(Beyond.Scripts.Quality.DeviceMatchRules rules, System.String gpu, Beyond.Scripts.Quality.RankingRule& rule, System.String& standardName)
  System.String GetNvidiaStandardGPUName(System.String gpu)
  System.String GetAmdStandardGPUName(System.String gpu)
  System.String GetIntelStandardGPUName(System.String gpu)
  System.String GetAdrenoStandardGPUName(System.String gpu)
  System.String GetMaliStandardGPUName(System.String gpu)
  System.String GetPowerVRStandardGPUName(System.String gpu)
  System.Void _ReportMatchRuleFailed(Beyond.Scripts.Quality.DeviceInfo deviceModel)
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.RankingRule
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.String                   regexPattern  // 0x10
  public            System.Int32                    targetScore  // 0x18
METHODS:
  System.Boolean Equals(Beyond.Scripts.Quality.RankingRule other)
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.MemoryRule
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            UnityEngine.Vector2             range  // 0x10
  public            System.Int32                    targetScore  // 0x18
METHODS:
  System.String ToString()
  System.Boolean Equals(Beyond.Scripts.Quality.MemoryRule other)
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.ListUtils
TYPE:  class
TOKEN: 0x200000F
FIELDS:
METHODS:
  System.Void AddOrReplace(System.Collections.Generic.List<TItem> source, System.Collections.Generic.List<TItem> remote)
END_CLASS

CLASS: Beyond.Scripts.Quality.DeviceMatchRules
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  public            System.Int32                    DefaultIOSRankingRule  // 0x10
  public            System.Int32                    DefaultAndroidScore  // 0x14
  public            System.Int32                    DefaultStandAloneScore  // 0x18
  public            System.Int32                    DefaultPowerVRScore  // 0x1C
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>appleWhiteList  // 0x20
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>appleGPUList  // 0x28
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>androidWhiteList  // 0x30
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>adrenoRulesList  // 0x38
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>maliRulesList  // 0x40
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>powerVRRulesList  // 0x48
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>androidGPUWhiteList  // 0x50
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>androidCPUWhiteList  // 0x58
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule>iOSMemoryRules  // 0x60
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule>androidMemoryRules  // 0x68
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>nvidiaRulesList  // 0x70
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>amdRulesList  // 0x78
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>intelRulesList  // 0x80
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.MemoryRule>standaloneMemoryRules  // 0x88
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.RankingRule>macSocRulesList  // 0x90
METHODS:
  System.Void Combine(Beyond.Scripts.Quality.DeviceMatchRules other)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.DeviceMatchResult
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  private           Beyond.Scripts.Quality.RankingRulem_rule  // 0x10
  private           Beyond.Scripts.Quality.DeviceInfo.MatchTypem_matchType  // 0x20
  private           System.String                   gpuStandardName  // 0x28
METHODS:
  System.Void .ctor(Beyond.Scripts.Quality.RankingRule r, Beyond.Scripts.Quality.DeviceInfo.MatchType type, System.String gpuStandardName)
  System.String ToString()
  System.Boolean IsNoMatch()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.DeviceQualityMapItem
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Int32                    deviceScore  // 0x18
  public            System.Int32                    defaultLevel  // 0x1C
  public            System.Int32                    veryLowLevel  // 0x20
  public            System.Int32                    lowLevel  // 0x24
  public            System.Int32                    middleLevel  // 0x28
  public            System.Int32                    highLevel  // 0x2C
  public            System.Int32                    veryHighLevel  // 0x30
METHODS:
  System.String ToString()
  UnityEngine.Color getColor(System.Int32 level)
  UnityEngine.Color getVeryLowColor()
  UnityEngine.Color getLowColor()
  UnityEngine.Color getMiddleColor()
  UnityEngine.Color getHighColor()
  UnityEngine.Color getVeryHighColor()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.DeviceQualityMap
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  public            UnityEngine.RuntimePlatform     m_platform  // 0x10
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.DeviceQualityMapItem>items  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.QualityConst
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  public    static  System.String                   SIMULATE_DEVICE_LIST  // 0x0
  public    static  System.String                   SETTING_RULES  // 0x0
  public    static  System.String                   QUALITY_MAP  // 0x0
  public    static  System.String                   QUALITY_TIER_COMPONENTS  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Scripts.Quality.QualityManager
TYPE:  class
TOKEN: 0x2000015
EXTENDS: Singleton`1
FIELDS:
  private           Beyond.Scripts.Quality.DeviceInfom_deviceInfo  // 0x10
  private           Beyond.Scripts.Quality.DeviceQualityMapm_qualityMap  // 0x18
  private           Beyond.Scripts.Quality.DeviceQualityMapItemm_matchedConfig  // 0x20
  private           System.Collections.Generic.Dictionary<Beyond.GameSetting.GameSettingVideoQuality,System.Int32>m_qualityScoreMap  // 0x48
  private           System.Collections.Generic.List<Beyond.Scripts.Quality.Components.QualityTierLevel>m_qualityTiers  // 0x50
  private           System.Collections.Generic.HashSet<System.Type>m_qualityTierTypes  // 0x58
  private           System.Collections.Generic.Dictionary<System.Type,Beyond.Scripts.Quality.Components.QualityTierComponentMatch>m_currentQualityTierComponent  // 0x60
  private           System.Collections.Generic.Dictionary<System.Type,Beyond.Scripts.Quality.Components.QualityTierComponentMatch>m_overrideQualityTierComponent  // 0x68
  private           System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Type,System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>>>m_qualityTierComponentChangeCallBack  // 0x70
  private           System.Collections.Generic.Queue<System.ValueTuple<System.Type,System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>>>m_queue  // 0x78
  private           System.Int32                    m_defaultTier  // 0x80
  private           System.Int32                    m_currentTier  // 0x84
  private           System.Boolean                  m_overrideFinish  // 0x88
  private           System.Func<System.Type,System.Boolean>resetSaveQualityTier  // 0x90
  private   static  System.Collections.Generic.HashSet<System.Int32>s_matchCount  // 0x0
METHODS:
  Beyond.Scripts.Quality.DeviceQualityMapItem get_Config()
  System.Int32 get_currentTier()
  System.Int32 get_defaultTier()
  Beyond.Scripts.Quality.DeviceInfo get_device()
  System.Void .ctor()
  System.Void Init(System.String remoteJson)
  System.Void InitOnlyDevice(System.String remoteJson)
  System.Void InitShaderLod()
  System.Void FinishInit()
  System.Boolean get_isInitializing()
  System.Void Dispose()
  System.Void LoadQualityTier(System.String overridePlatform)
  System.Void setQualityTier(System.Int32 qualityTier)
  System.Void ApplyQualityScore()
  System.Void ApplyShaderTier()
  System.Type _GetQualityComponentByName(System.String typeName)
  System.Void SetQualityTierByVideoQuality(Beyond.GameSetting.GameSettingVideoQuality VideoQuality)
  Beyond.GameSetting.GameSettingVideoQuality GetDefaultVideoQuality()
  System.Boolean NoMatchDeviceOrZeroScore()
  System.Boolean IsQualcommDevice()
  System.Boolean IsHUAWEIDevice()
  System.Boolean IsIpadDevice()
  System.Boolean IsVideoQualityEnable(Beyond.GameSetting.GameSettingVideoQuality VideoQuality)
  System.Void InitResetQualityTierComponentFunction(System.Func<System.Type,System.Boolean> func)
  System.Boolean ResetQualityTierComponentValue(System.Type type)
  Beyond.Scripts.Quality.Components.QualityTierComponentMatch _SetQualityTierComponentLevel(System.Type type, System.Int32 level)
  System.Void ForceSetQualityTierComponentLevel(System.String type, System.Int32 level)
  System.Void RevertSetQualityTierComponentLevel(System.String type)
  System.Boolean NeedRestart()
  System.Void ApplyCallBack()
  Beyond.Scripts.Quality.Components.QualityTierComponentMatch _GetOverrideQualityTierComponentLevel(System.Type type)
  Beyond.Scripts.Quality.Components.QualityTierType GetQualityTierComponentTierType(System.String type)
  System.Int32 GetQualityTierComponentTierVersion(System.String type)
  System.Boolean _IsToggleQualityTierComponent(System.String type)
  System.Void _ToggleQualityTierComponentLevel(System.String type, System.Int32 index)
  System.Boolean IsEnumQualityTierComponent(System.String type)
  System.Int32 GetEnumQualityTierComponentCount(System.String type)
  System.Void SetEnumQualityTierComponentCount(System.String type, System.Int32 index)
  System.Boolean IsSliderQualityTierComponent(System.String type)
  System.Void SetSliderQualityTierComponentCount(System.String type, System.Single value)
  UnityEngine.Vector3 GetSliderQualityTierComponent(System.String type)
  System.Boolean InvokeQualityTierComponent(System.String type, System.String functionName, System.Object[] parameters)
  System.Void RegisterQualityTierComponentChange(System.Type tierType, System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent> cb)
  System.Void InvokeChangeCallBack(System.Type type, Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  System.ValueTuple<System.Single,System.Single> GetQualityTierComponentTierCount(System.String type)
  System.Single GetQualityComponentDefaultTier(System.String type)
  System.Single GetQualityComponentTier(System.String type)
  System.Void SetQualityComponentTier(System.String type, System.Single index)
  System.String ToString()
  System.String DebugQualityTierComponentInfo()
  System.Void _ReportQuality()
  System.Void _DynamicInitQualitySetting()
  System.Void _DynamicReleaseQualitySetting()
  System.Void DynamicQualityChange(Beyond.EventData<Beyond.Gameplay.BeyondPerformance.LogicQualityLevel,Beyond.Gameplay.BeyondPerformance.LogicQualityLevel>& data)
  System.Void DynamicThermalChange(Beyond.EventData<Beyond.Gameplay.BeyondPerformance.ThermalState,Beyond.Gameplay.BeyondPerformance.ThermalState>& data)
  System.Void .cctor()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Scripts.Quality.QualityUtility
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private   static  Newtonsoft.Json.JsonSerializerSettingss_settings  // 0x0
METHODS:
  T LoadFromCompressedJson()
  T LoadingQualityJson(System.String path)
  T LoadingQualityJsonFromString(System.String value)
  System.Byte[] Decompress(System.Byte[] data)
  Newtonsoft.Json.JsonSerializerSettings get_JsonSerializerSettings()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.AntiAliasingQuality
TYPE:  class
TOKEN: 0x2000018
EXTENDS: EnumQualityComponent`1
FIELDS:
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.IEnumQualityComponent
TYPE:  interface
TOKEN: 0x200001A
FIELDS:
METHODS:
  System.Int32 GetEnumIndex(System.Enum enumValue)
  System.Int32 GetEnumIndex()
  System.Int32 GetDefaultEnumIndex()
  System.Int32 GetEnumCount()
  System.Void SetEnumIndex(System.Int32 value)
  System.String GetEnumName(System.Int32 index)
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.EnumQualityComponent`1
TYPE:  class
TOKEN: 0x200001B
EXTENDS: QualityTierComponent
FIELDS:
  private           T                               enumValue  // 0x0
  private           System.Nullable<System.Int32>   m_currentValue  // 0x0
  private           System.String[]                 m_strings  // 0x0
METHODS:
  System.Int32 GetEnumIndex(System.Enum enumValue)
  System.Int32 GetEnumIndex()
  System.Int32 GetDefaultEnumIndex()
  System.Int32 GetEnumCount()
  System.Void SetEnumIndex(System.Int32 value)
  System.String GetEnumName(System.Int32 index)
  System.Void SetEnum(T value)
  T GetValue()
  T GetDefaultValue()
  System.Void SetEnumWithOutApply(T value)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.QualityTierType
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Quality.Components.QualityTierTypeQuality  // 0x0
  public    static  Beyond.Scripts.Quality.Components.QualityTierTypeToggleQuality  // 0x0
  public    static  Beyond.Scripts.Quality.Components.QualityTierTypeEnumQuality  // 0x0
  public    static  Beyond.Scripts.Quality.Components.QualityTierTypeSliderQuality  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.IQualityComponentExtension`1
TYPE:  interface
TOKEN: 0x200001D
FIELDS:
METHODS:
  T GetValue()
  T GetDefaultValue()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.QualityTierComponent
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  private           System.Boolean                  isNeedStartDirty  // 0x10
METHODS:
  System.Void Apply()
  System.Void InitApply()
  System.Void LowMemory()
  System.Void DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last)
  System.Void DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last)
  System.Int32 Version()
  System.Int32 ApplyOrder()
  System.Void SafeApply()
  System.Void SafeLowMemory(System.Boolean init)
  System.Void CallDynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last)
  System.Void CallDynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.QualityTierComponentMatch
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            Beyond.Scripts.Quality.Components.QualityTierComponentcomponent  // 0x10
  public            Beyond.Scripts.Quality.Components.QualityTierComponentMatch.MatchSourcematchSource  // 0x18
  public            System.Int32                    matchQualityTier  // 0x1C
METHODS:
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.QualityTierLevel
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    qualityTier  // 0x10
  public            System.Collections.Generic.List<Beyond.Scripts.Quality.Components.QualityTierComponent>qualityTierComponents  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.SliderQualityComponent
TYPE:  class
TOKEN: 0x2000022
EXTENDS: QualityTierComponent
FIELDS:
  private           System.Single                   sliderValue  // 0x18
  private           System.Single                   MaxSliderValue  // 0x1C
  private           System.Single                   MinSliderValue  // 0x20
  private           System.Nullable<System.Single>  m_currentSliderValue  // 0x24
METHODS:
  System.Single GetValue()
  System.Single GetDefaultValue()
  UnityEngine.Vector2 GetRange()
  System.Void SetValue(System.Single value)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.ToggleQualityComponent
TYPE:  class
TOKEN: 0x2000023
EXTENDS: QualityTierComponent
FIELDS:
  private           System.Boolean                  toggleVal  // 0x18
  private           System.Nullable<System.Boolean> m_currentValue  // 0x19
METHODS:
  System.Void Apply()
  System.Void Toggle(System.Boolean value)
  System.Void ChangeToggle(System.Int32 index)
  System.Boolean GetValue()
  System.Boolean GetDefaultValue()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.CharacterRenderFeatureQuality
TYPE:  class
TOKEN: 0x2000024
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Int32                    characterSelfShadowOffLodQuality  // 0x18
  public            System.Int32                    characterShadowTierLevel  // 0x1C
  public            System.Int32                    characterOutlineTierLevel  // 0x20
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.ChromaticAberrationQuality
TYPE:  class
TOKEN: 0x2000025
EXTENDS: ToggleQualityComponent
FIELDS:
  private   static  System.Int32                    ENABLE_TIER  // 0x0
  private   static  System.Int32                    DISABLE_TIER  // 0x0
METHODS:
  System.Void Toggle(System.Boolean value)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Toggle(System.Boolean P0)
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.DLSSFrameGenQuality
TYPE:  class
TOKEN: 0x2000026
EXTENDS: EnumQualityComponent`1
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x30
METHODS:
  System.Void Apply()
  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  System.Boolean ShouldShowAuto()
  System.Boolean ShouldShowX1()
  System.Boolean ShouldShowX2()
  System.Boolean ShouldShowX3()
  System.Boolean ShouldShow()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.DLSSUpscalerQuality
TYPE:  class
TOKEN: 0x2000028
EXTENDS: EnumQualityComponent`1
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x30
METHODS:
  System.Void Apply()
  System.Boolean ShouldShow()
  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.EnvironmentRenderingFeatureQuality
TYPE:  class
TOKEN: 0x2000029
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Int32                    environmentRenderingFeatureQualityTier  // 0x18
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.FrameGenQuality
TYPE:  class
TOKEN: 0x200002A
EXTENDS: EnumQualityComponent`1
FIELDS:
METHODS:
  System.Void Apply()
  System.Boolean ShouldShow()
  System.Boolean ShouldShowDLSS()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.FrameRateQuality
TYPE:  class
TOKEN: 0x200002C
EXTENDS: EnumQualityComponent`1
FIELDS:
METHODS:
  System.Int32 get_frameRate()
  System.Int32 GetFrameRateFromEnum(Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum enumValue)
  System.Int32 Version()
  System.Boolean ShouldShow()
  System.Void Apply()
  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  System.Boolean _FPS30Enabled()
  System.Boolean _FPS60Enabled()
  System.Boolean _FPSBNoLimitEnabled()
  System.Boolean _IsGDLSSGDisable()
  System.Void .ctor()
  System.Int32 <>iFixBaseProxy_Version()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HgFrameRateControl
TYPE:  class
TOKEN: 0x200002E
FIELDS:
  public    static  System.Int32                    s_cinematicFrameRate  // 0x0
  public    static  System.Collections.Generic.Stack<System.ValueTuple<System.Int32,System.Int32,Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum>>s_rateStack  // 0x8
  public    static  System.Action<System.Int32,System.Int32>s_OnFrameRateChanged  // 0x10
METHODS:
  System.Int32 GetDefaultFrameRate()
  System.Void Init()
  System.Void SetFrameRateOverrider(System.Int32 frameRate, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum reason)
  System.Int32 GetFrameRate()
  System.Boolean IsHighFrameRate()
  System.Int32 RecommendedDefaultFrameRate()
  System.Int32 GetUserSettingFrameRate()
  System.Void __ForceSetFrameRate(System.Int32 frameRate, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum reason)
  System.Void ResetFrameRate()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.FrameRateQualityMobile
TYPE:  class
TOKEN: 0x2000030
EXTENDS: EnumQualityComponent`1
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x30
METHODS:
  System.Int32 get_frameRate()
  System.Int32 GetFrameRateFromEnum(Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum enumValue)
  System.Int32 Version()
  System.Void Apply()
  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  System.Void .ctor()
  System.Int32 <>iFixBaseProxy_Version()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.GrassSparsityQuality
TYPE:  class
TOKEN: 0x2000032
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Int32                    grassSparsityQualityTier  // 0x18
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGAmbientOcclusionQuality
TYPE:  class
TOKEN: 0x2000033
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Int32                    aoQualityTier  // 0x18
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGAnisoLevelQuality
TYPE:  class
TOKEN: 0x2000034
EXTENDS: EnumQualityComponent`1
FIELDS:
METHODS:
  System.Void InitApply()
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_InitApply()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGContactShadowQuality
TYPE:  class
TOKEN: 0x2000036
EXTENDS: ToggleQualityComponent
FIELDS:
  private   static  System.Int32                    ENABLE_TIER  // 0x0
  private   static  System.Int32                    DISABLE_TIER  // 0x0
METHODS:
  System.Void Toggle(System.Boolean value)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Toggle(System.Boolean P0)
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGIrradianceVolumeQuality
TYPE:  class
TOKEN: 0x2000037
EXTENDS: QualityTierComponent
FIELDS:
METHODS:
  System.Void LowMemory()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LowMemory()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGLODStreamingComponent
TYPE:  class
TOKEN: 0x2000038
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Boolean                  enableLODStreaming  // 0x18
METHODS:
  System.Void Apply()
  System.Void LowMemory()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
  System.Void <>iFixBaseProxy_LowMemory()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGReflectionProbeBinningQuality
TYPE:  class
TOKEN: 0x2000039
EXTENDS: QualityTierComponent
FIELDS:
METHODS:
  System.Void LowMemory()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LowMemory()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGRPTierQuality
TYPE:  class
TOKEN: 0x200003A
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Int32                    HGRP_QualityTier  // 0x18
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGScreenSpaceReflectionQuality
TYPE:  class
TOKEN: 0x200003B
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Int32                    ssrQualityTier  // 0x18
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGShadowQuality
TYPE:  class
TOKEN: 0x200003C
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Int32                    shadowQualityTier  // 0x18
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGTextureQuality
TYPE:  class
TOKEN: 0x200003D
EXTENDS: EnumQualityComponent`1
FIELDS:
METHODS:
  System.Int32 get_textureQualityTier()
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.HGVolumetricFogQuality
TYPE:  class
TOKEN: 0x200003F
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Int32                    volumetricFogQualityTier  // 0x18
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.LODGroupQuality
TYPE:  class
TOKEN: 0x2000040
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Single                   lodBias  // 0x18
  public            System.Int32                    lodOffset  // 0x1C
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.PhysicsClothQuality
TYPE:  class
TOKEN: 0x2000041
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Boolean                  UsePhysicCloth  // 0x18
  public            System.Boolean                  UseCrossFrameJob  // 0x19
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.PrefabInstantiateQuality
TYPE:  class
TOKEN: 0x2000042
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Single                   normalMaxUpdateTimeInMsThreshold  // 0x18
  public            System.Single                   busyMaxUpdateTimeInMsThreshold  // 0x1C
  public            System.Single                   burstMaxUpdateTimeInMsThreshold  // 0x20
  public            System.Single                   normalUnloadMaxUpdateTimeInMsThreshold  // 0x24
  public            System.Single                   burstUnloadMaxUpdateTimeInMsThreshold  // 0x28
  public            System.Single                   normalCallbackMaxUpdateTimeInMsThreshold  // 0x2C
  public            System.Single                   burstCallbackMaxUpdateTimeInMsThreshold  // 0x30
  public            System.Int32                    normalMaxDestroyCount  // 0x34
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.PreloadLoadSettingQuality
TYPE:  class
TOKEN: 0x2000043
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Single                   normalMaxUpdateTimeInMsThreshold  // 0x18
  public            System.Single                   busyMaxUpdateTimeInMsThreshold  // 0x1C
  public            System.Single                   burstMaxUpdateTimeInMsThreshold  // 0x20
  public            System.Single                   normalUnloadMaxUpdateTimeInMsThreshold  // 0x24
  public            System.Single                   burstUnloadMaxUpdateTimeInMsThreshold  // 0x28
  public            System.Single                   normalCallbackMaxUpdateTimeInMsThreshold  // 0x2C
  public            System.Single                   burstCallbackMaxUpdateTimeInMsThreshold  // 0x30
  public            System.Single                   preloadManagerUnloadKeepTime  // 0x34
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.RayTracingQuality
TYPE:  class
TOKEN: 0x2000044
EXTENDS: ToggleQualityComponent
FIELDS:
METHODS:
  System.Boolean get_supportsRayTracing()
  System.Void InitApply()
  System.Void Apply()
  System.Boolean ShouldShow()
  System.Int32 ApplyOrder()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_InitApply()
  System.Void <>iFixBaseProxy_Apply()
  System.Int32 <>iFixBaseProxy_ApplyOrder()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.ReflexQuality
TYPE:  class
TOKEN: 0x2000045
EXTENDS: EnumQualityComponent`1
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x30
METHODS:
  System.Void Apply()
  System.Boolean ShouldShow()
  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.RenderingScaleQualityMobile
TYPE:  class
TOKEN: 0x2000046
EXTENDS: EnumQualityComponent`1
FIELDS:
METHODS:
  System.Single get_renderingScaleFactor()
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.RenderingScaleQualityPC
TYPE:  class
TOKEN: 0x2000048
EXTENDS: EnumQualityComponent`1
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x30
METHODS:
  System.Single get_renderingScale()
  System.Void Apply()
  System.Boolean ShouldShow()
  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.ResLoadSettingQuality
TYPE:  class
TOKEN: 0x200004A
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Boolean                  debugCloseBundleUnload  // 0x18
  public            System.Boolean                  debugCloseBundleUnloadUntilBurstMode  // 0x19
  public            System.Boolean                  enableForceSyncUnload  // 0x1A
  public            System.Boolean                  enableUnloadLocker  // 0x1B
  public            System.Int32                    enableUnloadLockerBundleNum  // 0x1C
  public            System.Int32                    maxUnloadOpNum_Normal  // 0x20
  public            System.Int32                    maxUnloadOpNum_BusyMode  // 0x24
  public            System.Int32                    bundleFrameDelayToUnload_NormalMode  // 0x28
  public            System.Int32                    bundleFrameDelayToUnload_BusyMode  // 0x2C
  public            System.Int32                    bundleFrameDelayToUnload_BurstMode  // 0x30
  public            System.Int32                    bundleFrameDelayToUnload_SwitchScene  // 0x34
  public            System.Int32                    bundleFrameDelayToUnload_Fast  // 0x38
  public            System.Int32                    enterBusyOperationNum  // 0x3C
  public            System.Int32                    exitBusyOperationNum  // 0x40
  public            System.Single                   unloadBudgetFloatingCoefficient  // 0x44
  public            System.Single                   unloadMaxFloatingBudget  // 0x48
METHODS:
  System.Void Apply()
  System.Void LowMemory()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
  System.Void <>iFixBaseProxy_LowMemory()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.SceneDetailQuality
TYPE:  class
TOKEN: 0x200004B
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Int32                    sceneDetailQualityTier  // 0x18
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.ShaderLodQuality
TYPE:  class
TOKEN: 0x200004C
EXTENDS: QualityTierComponent
FIELDS:
  public            Beyond.Scripts.Quality.Components.ShaderLodQuality.ShaderLodEnumShaderLod  // 0x18
METHODS:
  System.Void InitApply()
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_InitApply()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.SharpnessQuality
TYPE:  class
TOKEN: 0x200004E
EXTENDS: SliderQualityComponent
FIELDS:
METHODS:
  System.Void Apply()
  System.Boolean ShouldShow()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.SliderTestComponent
TYPE:  class
TOKEN: 0x200004F
EXTENDS: SliderQualityComponent
FIELDS:
METHODS:
  System.Void Apply()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.TickExclusiveQuality
TYPE:  class
TOKEN: 0x2000050
EXTENDS: QualityTierComponent
FIELDS:
  public            Beyond.TickExclusiveMode        quality  // 0x18
  private           Beyond.Gameplay.BeyondPerformance.LogicQualityLevelm_currentQuality  // 0x1C
  private           Beyond.Gameplay.BeyondPerformance.ThermalStatem_currentThermalState  // 0x1D
METHODS:
  System.Void Apply()
  System.Void DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel current, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel last)
  System.Void DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState current, Beyond.Gameplay.BeyondPerformance.ThermalState last)
  System.Void _OnQualityOrThermalChanged()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
  System.Void <>iFixBaseProxy_DynamicQualityChange(Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P0, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P1)
  System.Void <>iFixBaseProxy_DynamicThermalChange(Beyond.Gameplay.BeyondPerformance.ThermalState P0, Beyond.Gameplay.BeyondPerformance.ThermalState P1)
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.UpscalerQuality
TYPE:  class
TOKEN: 0x2000051
EXTENDS: EnumQualityComponent`1
FIELDS:
METHODS:
  System.Void Apply()
  System.Boolean ShouldShow()
  System.Boolean ShouldShowDLSS()
  System.Int32 Version()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
  System.Int32 <>iFixBaseProxy_Version()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.VSyncQuality
TYPE:  class
TOKEN: 0x2000053
EXTENDS: QualityTierComponent
FIELDS:
  public            System.Boolean                  bVSync  // 0x18
METHODS:
  System.Void Apply()
  System.Void Remove()
  System.Void Init()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Apply()
END_CLASS

CLASS: Beyond.Scripts.Quality.Components.VSyncQualityV2
TYPE:  class
TOKEN: 0x2000054
EXTENDS: ToggleQualityComponent
FIELDS:
  private           System.Action<Beyond.Scripts.Quality.Components.QualityTierComponent>callback  // 0x20
METHODS:
  System.Void Toggle(System.Boolean value)
  System.Void Init()
  System.Int32 Version()
  System.Void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
  System.Void DlSSChange(Beyond.Scripts.Quality.Components.QualityTierComponent qualityTierComponent)
  System.Boolean ShouldShow()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Toggle(System.Boolean P0)
  System.Int32 <>iFixBaseProxy_Version()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000055
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Void __Gen_Wrap_0()
  System.Void __Gen_Wrap_1(System.Object P0, System.Object P1)
  System.String __Gen_Wrap_2(Beyond.Scripts.Quality.RankingRule& P0)
  System.String __Gen_Wrap_3(Beyond.Scripts.Quality.DeviceMatchResult& P0)
  System.String __Gen_Wrap_4(System.Object P0)
  System.Boolean __Gen_Wrap_5(Beyond.Scripts.Quality.DeviceMatchResult& P0)
  System.Boolean __Gen_Wrap_6(System.Object P0)
  Beyond.Scripts.Quality.DeviceMatchRules __Gen_Wrap_7(System.Object P0)
  System.String __Gen_Wrap_8(System.Object P0, System.Object P1)
  System.Boolean __Gen_Wrap_9(System.Object P0, System.Object P1, System.Object P2, Beyond.Scripts.Quality.RankingRule& P3)
  System.Boolean __Gen_Wrap_10(System.Object P0, System.Object P1, System.Object P2, Beyond.Scripts.Quality.RankingRule& P3, System.String& P4)
  System.Void __Gen_Wrap_11(System.Object P0)
  System.Int32 __Gen_Wrap_12(System.Object P0, System.Object P1)
  System.Boolean __Gen_Wrap_13(System.Object P0, System.Object P1, Beyond.Scripts.Quality.RankingRule& P2)
  System.Boolean __Gen_Wrap_14(Beyond.Scripts.Quality.RankingRule& P0, Beyond.Scripts.Quality.RankingRule P1)
  System.String __Gen_Wrap_15(Beyond.Scripts.Quality.MemoryRule& P0)
  System.Boolean __Gen_Wrap_16(Beyond.Scripts.Quality.MemoryRule& P0, Beyond.Scripts.Quality.MemoryRule P1)
  System.String __Gen_Wrap_17(Beyond.Scripts.Quality.DeviceQualityMapItem& P0)
  UnityEngine.Color __Gen_Wrap_18(Beyond.Scripts.Quality.DeviceQualityMapItem& P0, System.Int32 P1)
  UnityEngine.Color __Gen_Wrap_19(Beyond.Scripts.Quality.DeviceQualityMapItem& P0)
  System.Int32 __Gen_Wrap_20(System.Object P0)
  System.Int32 __Gen_Wrap_21(Beyond.Scripts.Quality.Components.QualityTierLevel P0)
  System.Int32 __Gen_Wrap_22(Beyond.Scripts.Quality.DeviceQualityMapItem P0)
  Beyond.Scripts.Quality.Components.QualityTierComponentMatch __Gen_Wrap_23(System.Object P0, System.Object P1, System.Int32 P2)
  System.Int32 __Gen_Wrap_24(Beyond.Scripts.Quality.Components.QualityTierComponentMatch P0)
  System.Void __Gen_Wrap_25(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_26(System.Object P0, System.Boolean P1)
  Beyond.Scripts.Quality.Components.QualityTierComponentMatch __Gen_Wrap_27(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_28(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_29(System.Object P0, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P1, Beyond.Gameplay.BeyondPerformance.LogicQualityLevel P2)
  System.Void __Gen_Wrap_30(System.Object P0, Beyond.EventData<Beyond.Gameplay.BeyondPerformance.LogicQualityLevel,Beyond.Gameplay.BeyondPerformance.LogicQualityLevel>& P1)
  System.Void __Gen_Wrap_31(System.Object P0, Beyond.Gameplay.BeyondPerformance.ThermalState P1, Beyond.Gameplay.BeyondPerformance.ThermalState P2)
  System.Void __Gen_Wrap_32(System.Object P0, Beyond.EventData<Beyond.Gameplay.BeyondPerformance.ThermalState,Beyond.Gameplay.BeyondPerformance.ThermalState>& P1)
  System.Type __Gen_Wrap_33(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_34(System.Object P0, System.Object P1, System.Int32 P2)
  System.Void __Gen_Wrap_35(System.Object P0, Beyond.GameSetting.GameSettingVideoQuality P1)
  Beyond.GameSetting.GameSettingVideoQuality __Gen_Wrap_36(System.Object P0)
  System.Boolean __Gen_Wrap_37()
  System.Boolean __Gen_Wrap_38(System.Object P0, System.Object P1)
  Beyond.Scripts.Quality.Components.QualityTierType __Gen_Wrap_39(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_40(System.Object P0, System.Single P1)
  System.Void __Gen_Wrap_41(System.Object P0, System.Object P1, System.Single P2)
  UnityEngine.Vector2 __Gen_Wrap_42(System.Object P0)
  System.Single __Gen_Wrap_43(System.Object P0)
  UnityEngine.Vector3 __Gen_Wrap_44(System.Object P0, System.Object P1)
  System.Boolean __Gen_Wrap_45(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  System.ValueTuple<System.Single,System.Single> __Gen_Wrap_46(System.Object P0, System.Object P1)
  System.Int32 __Gen_Wrap_47(System.Int32 P0, System.Int32 P1)
  System.Single __Gen_Wrap_48(System.Object P0, System.Object P1)
  System.Byte[] __Gen_Wrap_49(System.Object P0)
  Newtonsoft.Json.JsonSerializerSettings __Gen_Wrap_50()
  System.Void __Gen_Wrap_51(System.Object P0, System.Runtime.Serialization.StreamingContext P1)
  System.Int32 __Gen_Wrap_52(Beyond.Scripts.Quality.Components.FrameRateQuality.FrameRateQualityEnum P0)
  System.Void __Gen_Wrap_53(System.Int32 P0, Beyond.Scripts.Quality.Components.HgFrameRateControl.ReasonEnum P1)
  System.Int32 __Gen_Wrap_54()
  System.Int32 __Gen_Wrap_55(Beyond.Scripts.Quality.Components.FrameRateQualityMobile.FrameRateQualityMobileEnum P0)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000056
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000057
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  System.Object CreateWrapper(System.Int32 id)
  System.Object InitWrapperArray(System.Int32 len)
  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-InitializeAtRuntime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceMatchRules-Combine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-SupplementFromRemote0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-RankingRule-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceMatchResult-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceMatchResult-IsNoMatch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-IsNoMatchDevice0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-IsZeroDevices0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-IsHUAWEIDevice0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-IsQualcommDevice0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-LoadingSettingRules0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetNvidiaStandardGPUName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-RuleSuffixMatch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetAmdStandardGPUName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetIntelStandardGPUName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-StandaloneMatchGPURule0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-_ReportMatchRuleFailed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-StandaloneGetMatchedRule0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetDeviceScore0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-RuleFullNameMatch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-MatchDeviceModeRule0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetAdrenoStandardGPUName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetMaliStandardGPUName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-MatchGPURule0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-AndroidGetMatchedRule0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-IOSGetMatchedRule0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-DefaultGetMatchedRule0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-EditorSimulateGetMatchedRule0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-StandaloneOSXGetMatchedRule0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-StandalonePS5GetMatchedRule0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceInfo-GetPowerVRStandardGPUName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-RankingRule-Equals0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-MemoryRule-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-MemoryRule-Equals0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryLowColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getLowColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getMiddleColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getHighColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryHighColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-ApplyOrder0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-LoadQualityTier0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_SetQualityTierComponentLevel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-InitApply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-LowMemory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-InvokeChangeCallBack0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-SafeApply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-SafeLowMemory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_GetOverrideQualityTierComponentLevel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ApplyCallBack0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-setQualityTier0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ApplyQualityScore0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicQualityChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicQualityChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-DynamicQualityChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicThermalChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicThermalChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-DynamicThermalChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_DynamicInitQualitySetting0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-InitOnlyDevice0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_GetQualityComponentByName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ForceSetQualityTierComponentLevel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-FinishInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ApplyShaderTier0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-InitShaderLod0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_DynamicReleaseQualitySetting0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-SetQualityTierByVideoQuality0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetDefaultVideoQuality0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-NoMatchDeviceOrZeroScore0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-IsQualcommDevice0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-IsHUAWEIDevice0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-IsIpadDevice0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-InitResetQualityTierComponentFunction0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ResetQualityTierComponentValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-RevertSetQualityTierComponentLevel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-NeedRestart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-QualityTierComponent-Version0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierVersion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_IsToggleQualityTierComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ToggleQualityComponent-ChangeToggle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_ToggleQualityTierComponentLevel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-IsEnumQualityTierComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetEnumQualityTierComponentCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-SetEnumQualityTierComponentCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-IsSliderQualityTierComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SliderQualityComponent-SetValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-SetSliderQualityTierComponentCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SliderQualityComponent-GetRange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SliderQualityComponent-GetValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetSliderQualityTierComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-InvokeQualityTierComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetDefaultValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SliderQualityComponent-GetDefaultValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetQualityComponentDefaultTier0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-GetQualityComponentTier0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-_ReportQuality0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-SetQualityComponentTier0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityManager-DebugQualityTierComponentInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityUtility-Decompress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-QualityUtility-get_JsonSerializerSettings0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-AntiAliasingQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ToggleQualityComponent-Toggle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ToggleQualityComponent-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-CharacterRenderFeatureQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ChromaticAberrationQuality-Toggle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-DlSSChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-OnDeserialized0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowAuto0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX10  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX20  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX30  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-ShouldShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-DlSSChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-OnDeserialized0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-EnvironmentRenderingFeatureQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameGenQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShowDLSS0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-GetFrameRateFromEnum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-Version0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-ShouldShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-__ForceSetFrameRate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-DlSSChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-OnDeserialized0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS30Enabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS60Enabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-_FPSBNoLimitEnabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQuality-_IsGDLSSGDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-GetDefaultFrameRate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-SetFrameRateOverrider0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-GetFrameRate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-RecommendedDefaultFrameRate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-GetUserSettingFrameRate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HgFrameRateControl-ResetFrameRate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQualityMobile-GetFrameRateFromEnum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Version0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-FrameRateQualityMobile-OnDeserialized0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-GrassSparsityQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGAmbientOcclusionQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-InitApply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGContactShadowQuality-Toggle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGIrradianceVolumeQuality-LowMemory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGLODStreamingComponent-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGLODStreamingComponent-LowMemory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGReflectionProbeBinningQuality-LowMemory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGRPTierQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGScreenSpaceReflectionQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGShadowQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGTextureQuality-get_textureQualityTier0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGTextureQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-HGVolumetricFogQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-LODGroupQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-PhysicsClothQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-PrefabInstantiateQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-PreloadLoadSettingQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RayTracingQuality-InitApply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RayTracingQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RayTracingQuality-ShouldShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RayTracingQuality-ApplyOrder0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ReflexQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ReflexQuality-ShouldShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ReflexQuality-DlSSChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ReflexQuality-OnDeserialized0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-get_renderingScaleFactor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-get_renderingScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-ShouldShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-DlSSChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-OnDeserialized0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ResLoadSettingQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ResLoadSettingQuality-LowMemory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SceneDetailQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ShaderLodQuality-InitApply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-ShaderLodQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SharpnessQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SharpnessQuality-ShouldShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-SliderTestComponent-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-TickExclusiveQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-TickExclusiveQuality-_OnQualityOrThermalChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicQualityChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicThermalChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-UpscalerQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowDLSS0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-UpscalerQuality-Version0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQuality-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQuality-Remove0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQuality-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-Toggle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-Version0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-DlSSChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-OnDeserialized0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Quality-Components-VSyncQualityV2-ShouldShow0  // 0x0
METHODS:
END_CLASS

