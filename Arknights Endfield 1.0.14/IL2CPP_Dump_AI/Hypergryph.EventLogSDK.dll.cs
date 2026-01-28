// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.EventLogSDK.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Hypergryph.SDK.IEventLogSDK
TYPE:  interface
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.Boolean setEnvironment(System.String env)
  System.Boolean enableRealTimeSend(System.Boolean enable)
  System.Boolean init(System.String appId, System.String regionTag)
  System.Boolean setGlobalProperties(System.String appId, System.String globalProperties)
  System.Boolean unsetGlobalProperties(System.String appId, System.String propertyKeys)
  System.Void clearGlobalProperties(System.String appId)
  System.Boolean eventTrack(System.String appId, System.String name, System.String properties)
  System.Boolean appStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  System.Void pauseBeat(System.String appId)
  System.Void resumeBeat(System.String appId)
  System.Boolean userLoginEvent(System.String appId, System.String userId, System.String properties)
  System.Void unsetUser(System.String appId)
  System.Boolean characterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties)
  System.Void unsetCharacter(System.String appId)
  System.String getPresetProperties(System.String appId)
  System.Void flush(System.String appId)
  System.String getStaticPresetProperties(System.String appId)
  System.String getDeviceIdProperties(System.String appId)
  System.Boolean setGlobalPropertiesV2(System.String globalProperties)
  System.Boolean unsetGlobalPropertiesV2(System.String propertyKeys)
  System.Void clearGlobalPropertiesV2()
  System.Boolean eventTrackV2(System.String name, System.String properties)
  System.Boolean appStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  System.Void pauseBeatV2()
  System.Void resumeBeatV2()
  System.Boolean userLoginEventV2(System.String userId, System.String properties)
  System.Void unsetUserV2()
  System.Boolean characterLoginEventV2(System.String characterId, System.String serverId, System.String properties)
  System.Void unsetCharacterV2()
  System.String getPresetPropertiesV2()
  System.Void flushV2()
  System.String getStaticPresetPropertiesV2()
  System.String getDeviceIdPropertiesV2()
  System.Boolean eventTrackV3(System.String appId, System.String name, System.String properties)
END_CLASS

CLASS: Hypergryph.SDK.HGEventLogSDKBridge
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private   static  Hypergryph.SDK.IEventLogSDK     s_el  // 0x0
METHODS:
  Hypergryph.SDK.IEventLogSDK get_eventLogSdk()
END_CLASS

CLASS: Hypergryph.SDK.HGEventLogSDKAppInstance
TYPE:  class
TOKEN: 0x2000004
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Boolean SetEnvironment(System.String env)
  System.Boolean SetGlobalProperties(System.String globalProperties)
  System.Boolean UnsetGlobalProperties(System.String propertyKeys)
  System.Void ClearGlobalProperties()
  System.Boolean EventTrack(System.String name, System.String properties)
  System.Boolean AppStartEvent(System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  System.Boolean UserLoginEvent(System.String userId, System.String properties)
  System.Void UnsetUser()
  System.Boolean CharacterLoginEvent(System.String characterId, System.String serverId, System.String properties)
  System.Void UnsetCharacter()
  System.String GetPresetProperties()
  System.Void PauseBeat()
  System.Void ResumeBeat()
  System.Void Flush()
  System.Boolean EnableRealTimeSend(System.Boolean enable)
  System.String GetStaticPresetProperties()
  System.String GetDeviceIdProperties()
  System.Void OnApplicationPause(System.Boolean pause)
  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.HGEventLogSDKInstance
TYPE:  class
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Boolean init(System.String appId, System.String region)
  System.Boolean EventTrackWithAppId(System.String appId, System.String name, System.String properties)
END_CLASS

CLASS: Hypergryph.SDK.HGEventLogSDKMgr
TYPE:  class
TOKEN: 0x2000006
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.String                   appIdForInstance  // 0x0
METHODS:
  System.Boolean SetEnvironment(System.String env)
  System.Boolean Init(System.String appId, System.String regionTag)
  System.Boolean SetGlobalProperties(System.String globalProperties)
  System.Boolean UnsetGlobalProperties(System.String propertyKeys)
  System.Void ClearGlobalProperties()
  System.Boolean EventTrack(System.String name, System.String properties)
  System.Boolean AppStartEvent(System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  System.Boolean UserLoginEvent(System.String userId, System.String properties)
  System.Void UnsetUser()
  System.Boolean CharacterLoginEvent(System.String characterId, System.String serverId, System.String properties)
  System.Void UnsetCharacter()
  System.String GetPresetProperties()
  System.Void PauseBeat()
  System.Void ResumeBeat()
  System.Void Flush()
  System.Boolean EnableRealTimeSend(System.Boolean enable)
  System.String GetStaticPresetProperties()
  System.String GetDeviceIdProperties()
  System.Void OnApplicationPause(System.Boolean pause)
  System.Void .ctor()
END_CLASS

CLASS: Hypergryph.SDK.HGEventLogSDKPluginWindows
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Boolean EventLogSetEnvironment(System.String env)
  System.Boolean EventLogInitInstance(System.String appId, System.String regionTag)
  System.Boolean EventLogSetGlobalProperties(System.String appId, System.String globalProperties)
  System.Boolean EventLogUnsetGlobalProperties(System.String appId, System.String propertyKeys)
  System.Boolean EventLogClearGlobalProperties(System.String appId)
  System.Boolean EventLogEvent(System.String appId, System.String name, System.String properties)
  System.Boolean EventLogAppStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  System.Boolean EventLogBeatPause(System.String appId)
  System.Boolean EventLogBeatResume(System.String appId)
  System.Boolean EventLogUserLoginEvent(System.String appId, System.String userId, System.String properties)
  System.Boolean EventLogUnsetUser(System.String appId)
  System.Boolean EventLogCharacterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties)
  System.Boolean EventLogUnsetCharacter(System.String appId)
  System.IntPtr EventLogGetPresetProperties(System.String appId)
  System.IntPtr EventLogGetStaticPresetProperties(System.String appId)
  System.IntPtr EventLogGetDeviceIdProperties(System.String appId)
  System.Boolean EventLogEnableRealTimeSend(System.Boolean enable)
  System.Void EventLogFlush(System.String appId)
  System.Boolean EventLogFree(System.IntPtr buf)
  System.Boolean EventLogUnsetGlobalPropertiesV2(System.String property_keys)
  System.Boolean EventLogSetGlobalPropertiesV2(System.String global_properties)
  System.Void EventLogClearGlobalPropertiesV2()
  System.Boolean EventLogEventV2(System.String name, System.String json_str)
  System.Boolean EventLogAppStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String json_str)
  System.Void EventLogBeatPauseV2()
  System.Void EventLogBeatResumeV2()
  System.Boolean EventLogUserLoginEventV2(System.String user_id, System.String json_str)
  System.Void EventLogUnsetUserV2()
  System.Boolean EventLogCharacterLoginEventV2(System.String character_id, System.String server_id, System.String json_str)
  System.Void EventLogUnsetCharacterV2()
  System.IntPtr EventLogGetPresetPropertiesV2()
  System.IntPtr EventLogGetStaticPresetPropertiesV2()
  System.IntPtr EventLogGetDeviceIdPropertiesV2()
  System.Void EventLogFlushV2()
  System.Void .ctor()
  System.Boolean setEnvironment(System.String env)
  System.Boolean init(System.String appId, System.String regionTag)
  System.Boolean setGlobalProperties(System.String appId, System.String globalProperties)
  System.Boolean unsetGlobalProperties(System.String appId, System.String propertyKeys)
  System.Void clearGlobalProperties(System.String appId)
  System.Boolean eventTrack(System.String appId, System.String name, System.String properties)
  System.Boolean appStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  System.Void pauseBeat(System.String appId)
  System.Void resumeBeat(System.String appId)
  System.Boolean userLoginEvent(System.String appId, System.String userId, System.String properties)
  System.Void unsetUser(System.String appId)
  System.Boolean characterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties)
  System.Void unsetCharacter(System.String appId)
  System.String getPresetProperties(System.String appId)
  System.String getStaticPresetProperties(System.String appId)
  System.String getDeviceIdProperties(System.String appId)
  System.Void flush(System.String appId)
  System.Boolean enableRealTimeSend(System.Boolean enable)
  System.Boolean setGlobalPropertiesV2(System.String globalProperties)
  System.Boolean unsetGlobalPropertiesV2(System.String propertyKeys)
  System.Void clearGlobalPropertiesV2()
  System.Boolean eventTrackV2(System.String name, System.String properties)
  System.Boolean appStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String properties)
  System.Void pauseBeatV2()
  System.Void resumeBeatV2()
  System.Boolean userLoginEventV2(System.String userId, System.String properties)
  System.Void unsetUserV2()
  System.Boolean characterLoginEventV2(System.String characterId, System.String serverId, System.String properties)
  System.Void unsetCharacterV2()
  System.String getPresetPropertiesV2()
  System.Void flushV2()
  System.String getStaticPresetPropertiesV2()
  System.String getDeviceIdPropertiesV2()
  System.Boolean eventTrackV3(System.String appId, System.String name, System.String properties)
END_CLASS

