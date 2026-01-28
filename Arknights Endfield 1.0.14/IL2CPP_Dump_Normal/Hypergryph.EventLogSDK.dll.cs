// ========================================================
// Dumped by @desirepro
// Assembly: Hypergryph.EventLogSDK.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Hypergryph.SDK
{

    // TypeToken: 0x2000002
    public interface IEventLogSDK
    {
        // Methods
        private System.Boolean setEnvironment(System.String env) { }
        private System.Boolean enableRealTimeSend(System.Boolean enable) { }
        private System.Boolean init(System.String appId, System.String regionTag) { }
        private System.Boolean setGlobalProperties(System.String appId, System.String globalProperties) { }
        private System.Boolean unsetGlobalProperties(System.String appId, System.String propertyKeys) { }
        private System.Void clearGlobalProperties(System.String appId) { }
        private System.Boolean eventTrack(System.String appId, System.String name, System.String properties) { }
        private System.Boolean appStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        private System.Void pauseBeat(System.String appId) { }
        private System.Void resumeBeat(System.String appId) { }
        private System.Boolean userLoginEvent(System.String appId, System.String userId, System.String properties) { }
        private System.Void unsetUser(System.String appId) { }
        private System.Boolean characterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties) { }
        private System.Void unsetCharacter(System.String appId) { }
        private System.String getPresetProperties(System.String appId) { }
        private System.Void flush(System.String appId) { }
        private System.String getStaticPresetProperties(System.String appId) { }
        private System.String getDeviceIdProperties(System.String appId) { }
        private System.Boolean setGlobalPropertiesV2(System.String globalProperties) { }
        private System.Boolean unsetGlobalPropertiesV2(System.String propertyKeys) { }
        private System.Void clearGlobalPropertiesV2() { }
        private System.Boolean eventTrackV2(System.String name, System.String properties) { }
        private System.Boolean appStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        private System.Void pauseBeatV2() { }
        private System.Void resumeBeatV2() { }
        private System.Boolean userLoginEventV2(System.String userId, System.String properties) { }
        private System.Void unsetUserV2() { }
        private System.Boolean characterLoginEventV2(System.String characterId, System.String serverId, System.String properties) { }
        private System.Void unsetCharacterV2() { }
        private System.String getPresetPropertiesV2() { }
        private System.Void flushV2() { }
        private System.String getStaticPresetPropertiesV2() { }
        private System.String getDeviceIdPropertiesV2() { }
        private System.Boolean eventTrackV3(System.String appId, System.String name, System.String properties) { }

    }

    // TypeToken: 0x2000003
    public class HGEventLogSDKBridge
    {
        // Fields
        private static Hypergryph.SDK.IEventLogSDK s_el;        // 0x0

        // Methods
        private Hypergryph.SDK.IEventLogSDK get_eventLogSdk() { }

    }

    // TypeToken: 0x2000004
    public class HGEventLogSDKAppInstance : MonoBehaviour
    {
        // Methods
        private System.Boolean SetEnvironment(System.String env) { }
        private System.Boolean SetGlobalProperties(System.String globalProperties) { }
        private System.Boolean UnsetGlobalProperties(System.String propertyKeys) { }
        private System.Void ClearGlobalProperties() { }
        private System.Boolean EventTrack(System.String name, System.String properties) { }
        private System.Boolean AppStartEvent(System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        private System.Boolean UserLoginEvent(System.String userId, System.String properties) { }
        private System.Void UnsetUser() { }
        private System.Boolean CharacterLoginEvent(System.String characterId, System.String serverId, System.String properties) { }
        private System.Void UnsetCharacter() { }
        private System.String GetPresetProperties() { }
        private System.Void PauseBeat() { }
        private System.Void ResumeBeat() { }
        private System.Void Flush() { }
        private System.Boolean EnableRealTimeSend(System.Boolean enable) { }
        private System.String GetStaticPresetProperties() { }
        private System.String GetDeviceIdProperties() { }
        private System.Void OnApplicationPause(System.Boolean pause) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class HGEventLogSDKInstance
    {
        // Methods
        private System.Boolean init(System.String appId, System.String region) { }
        private System.Boolean EventTrackWithAppId(System.String appId, System.String name, System.String properties) { }

    }

    // TypeToken: 0x2000006
    public class HGEventLogSDKMgr : MonoBehaviour
    {
        // Fields
        private static System.String appIdForInstance;        // 0x0

        // Methods
        private System.Boolean SetEnvironment(System.String env) { }
        private System.Boolean Init(System.String appId, System.String regionTag) { }
        private System.Boolean SetGlobalProperties(System.String globalProperties) { }
        private System.Boolean UnsetGlobalProperties(System.String propertyKeys) { }
        private System.Void ClearGlobalProperties() { }
        private System.Boolean EventTrack(System.String name, System.String properties) { }
        private System.Boolean AppStartEvent(System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        private System.Boolean UserLoginEvent(System.String userId, System.String properties) { }
        private System.Void UnsetUser() { }
        private System.Boolean CharacterLoginEvent(System.String characterId, System.String serverId, System.String properties) { }
        private System.Void UnsetCharacter() { }
        private System.String GetPresetProperties() { }
        private System.Void PauseBeat() { }
        private System.Void ResumeBeat() { }
        private System.Void Flush() { }
        private System.Boolean EnableRealTimeSend(System.Boolean enable) { }
        private System.String GetStaticPresetProperties() { }
        private System.String GetDeviceIdProperties() { }
        private System.Void OnApplicationPause(System.Boolean pause) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class HGEventLogSDKPluginWindows, IEventLogSDK
    {
        // Methods
        private System.Boolean EventLogSetEnvironment(System.String env) { }
        private System.Boolean EventLogInitInstance(System.String appId, System.String regionTag) { }
        private System.Boolean EventLogSetGlobalProperties(System.String appId, System.String globalProperties) { }
        private System.Boolean EventLogUnsetGlobalProperties(System.String appId, System.String propertyKeys) { }
        private System.Boolean EventLogClearGlobalProperties(System.String appId) { }
        private System.Boolean EventLogEvent(System.String appId, System.String name, System.String properties) { }
        private System.Boolean EventLogAppStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        private System.Boolean EventLogBeatPause(System.String appId) { }
        private System.Boolean EventLogBeatResume(System.String appId) { }
        private System.Boolean EventLogUserLoginEvent(System.String appId, System.String userId, System.String properties) { }
        private System.Boolean EventLogUnsetUser(System.String appId) { }
        private System.Boolean EventLogCharacterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties) { }
        private System.Boolean EventLogUnsetCharacter(System.String appId) { }
        private System.IntPtr EventLogGetPresetProperties(System.String appId) { }
        private System.IntPtr EventLogGetStaticPresetProperties(System.String appId) { }
        private System.IntPtr EventLogGetDeviceIdProperties(System.String appId) { }
        private System.Boolean EventLogEnableRealTimeSend(System.Boolean enable) { }
        private System.Void EventLogFlush(System.String appId) { }
        private System.Boolean EventLogFree(System.IntPtr buf) { }
        private System.Boolean EventLogUnsetGlobalPropertiesV2(System.String property_keys) { }
        private System.Boolean EventLogSetGlobalPropertiesV2(System.String global_properties) { }
        private System.Void EventLogClearGlobalPropertiesV2() { }
        private System.Boolean EventLogEventV2(System.String name, System.String json_str) { }
        private System.Boolean EventLogAppStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String json_str) { }
        private System.Void EventLogBeatPauseV2() { }
        private System.Void EventLogBeatResumeV2() { }
        private System.Boolean EventLogUserLoginEventV2(System.String user_id, System.String json_str) { }
        private System.Void EventLogUnsetUserV2() { }
        private System.Boolean EventLogCharacterLoginEventV2(System.String character_id, System.String server_id, System.String json_str) { }
        private System.Void EventLogUnsetCharacterV2() { }
        private System.IntPtr EventLogGetPresetPropertiesV2() { }
        private System.IntPtr EventLogGetStaticPresetPropertiesV2() { }
        private System.IntPtr EventLogGetDeviceIdPropertiesV2() { }
        private System.Void EventLogFlushV2() { }
        private System.Void .ctor() { }
        private System.Boolean setEnvironment(System.String env) { }
        private System.Boolean init(System.String appId, System.String regionTag) { }
        private System.Boolean setGlobalProperties(System.String appId, System.String globalProperties) { }
        private System.Boolean unsetGlobalProperties(System.String appId, System.String propertyKeys) { }
        private System.Void clearGlobalProperties(System.String appId) { }
        private System.Boolean eventTrack(System.String appId, System.String name, System.String properties) { }
        private System.Boolean appStartEvent(System.String appId, System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        private System.Void pauseBeat(System.String appId) { }
        private System.Void resumeBeat(System.String appId) { }
        private System.Boolean userLoginEvent(System.String appId, System.String userId, System.String properties) { }
        private System.Void unsetUser(System.String appId) { }
        private System.Boolean characterLoginEvent(System.String appId, System.String characterId, System.String serverId, System.String properties) { }
        private System.Void unsetCharacter(System.String appId) { }
        private System.String getPresetProperties(System.String appId) { }
        private System.String getStaticPresetProperties(System.String appId) { }
        private System.String getDeviceIdProperties(System.String appId) { }
        private System.Void flush(System.String appId) { }
        private System.Boolean enableRealTimeSend(System.Boolean enable) { }
        private System.Boolean setGlobalPropertiesV2(System.String globalProperties) { }
        private System.Boolean unsetGlobalPropertiesV2(System.String propertyKeys) { }
        private System.Void clearGlobalPropertiesV2() { }
        private System.Boolean eventTrackV2(System.String name, System.String properties) { }
        private System.Boolean appStartEventV2(System.String channel1, System.String channel2, System.Boolean beat, System.String properties) { }
        private System.Void pauseBeatV2() { }
        private System.Void resumeBeatV2() { }
        private System.Boolean userLoginEventV2(System.String userId, System.String properties) { }
        private System.Void unsetUserV2() { }
        private System.Boolean characterLoginEventV2(System.String characterId, System.String serverId, System.String properties) { }
        private System.Void unsetCharacterV2() { }
        private System.String getPresetPropertiesV2() { }
        private System.Void flushV2() { }
        private System.String getStaticPresetPropertiesV2() { }
        private System.String getDeviceIdPropertiesV2() { }
        private System.Boolean eventTrackV3(System.String appId, System.String name, System.String properties) { }

    }

}

