// ========================================================
// Dumped by @desirepro
// Assembly: Audio.Beyond.dll
// Classes:  82
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000008
    public class Context
    {
        // Fields
        public static System.UInt64 s_listenerObjId;        // 0x0
        public static System.UInt64 s_2dEmitterObjectId;        // 0x8
        public static System.UInt32 s_playingIdInternal;        // 0x10
        public static System.Collections.Generic.Dictionary<System.UInt32,System.UInt32> s_playingIdLut;        // 0x18
        public static Beyond.PoolCore.ObjectPool<Beyond.Audio.AudioAdapter.PayloadPostEvent> s_payloadPool;        // 0x20
        public static readonly AkExternalSourceInfoArray S_EXTERNAL_SOURCE_INFO_ARRAY;        // 0x28
        public static AkRoomParams s_reusableAkRoomParams;        // 0x30

        // Methods
        private System.Void PostSoundEngineInit() { }
        private System.Void Reset() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000A
    public class PayloadPostEvent
    {
        // Fields
        public System.UInt64 audioObjectId;        // 0x10
        public System.UInt32 callbackType;        // 0x18
        public System.UInt32 internalPlayingId;        // 0x1C
        public Beyond.Audio.AudioEventCallback callback;        // 0x20
        public System.Object cookie;        // 0x28

        // Methods
        private System.Void OnRecycle(Beyond.Audio.AudioAdapter.PayloadPostEvent obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class Device
    {
        // Methods
        private System.Boolean GetSpeakerConfiguration(Beyond.Audio.AudioChannelMask& channelMask, System.UInt32& numChannels, Beyond.Audio.AudioChannelConfigType& configType) { }
        private System.Boolean AddOutputDevice(System.String deviceName, System.UInt32 deviceId, System.UInt32 numChannels, System.UInt32 speakerSetup, System.UInt64& outDeviceId) { }
        private System.Boolean AddOutput(System.String shareSetName, System.UInt32 deviceId, System.UInt64& outId) { }
        private System.UInt64 GetOutputDeviceId(System.String shareSetName, System.UInt32 deviceId) { }
        private System.Boolean RemoveOutputDevice(System.UInt64 output) { }
        private System.Boolean Switch3DOutput(System.Boolean use3DDevice) { }
        private System.Void SetOutputDeviceEffect(System.UInt64 outputDeviceId, System.UInt32 effectIdx, System.UInt32 shareSetId) { }
        private System.UInt32 GetMmDeviceIdFromScePadHandle(System.Int32 scePadHandle) { }

    }

    // TypeToken: 0x2000014
    public struct WarnType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.Audio.AudioEventWarnAttribute.WarnType NONE;        // 0x0
        public static Beyond.Audio.AudioEventWarnAttribute.WarnType ONE_SHOT;        // 0x0
        public static Beyond.Audio.AudioEventWarnAttribute.WarnType LOOP;        // 0x0

    }

    // TypeToken: 0x2000018
    public class CallbackCookie
    {
        // Fields
        public System.String bankName;        // 0x10
        public System.Action callback;        // 0x18
        public Beyond.Audio.BankHandle handle;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public struct EBoolFlags
    {
        // Fields
        public System.UInt16 value__;        // 0x10
        public static Beyond.Audio.AudioRoomData.EBoolFlags None;        // 0x0
        public static Beyond.Audio.AudioRoomData.EBoolFlags KeepRegistered;        // 0x0
        public static Beyond.Audio.AudioRoomData.EBoolFlags UseForReflectionAndDiffraction;        // 0x0
        public static Beyond.Audio.AudioRoomData.EBoolFlags AsReverbZone;        // 0x0

    }

    // TypeToken: 0x2000034
    public struct FExecuteAction
    {
        // Fields
        public System.Int32 queuedFrame;        // 0x10
        public System.UInt32 playingId;        // 0x14
        public AkActionOnEventType actionType;        // 0x18
        public System.Int32 durationMs;        // 0x1C

    }

    // TypeToken: 0x2000035
    public struct FRTPCAction
    {
        // Fields
        public System.Int32 queuedFrame;        // 0x10
        public System.UInt32 playingId;        // 0x14
        public System.UInt32 rtpcId;        // 0x18
        public System.Single targetValue;        // 0x1C
        public System.Int32 durationMs;        // 0x20

    }

    // TypeToken: 0x2000036
    public struct FSeekAction
    {
        // Fields
        public System.Int32 queuedFrame;        // 0x10
        public System.Single queuedTime;        // 0x14
        public System.UInt32 playingId;        // 0x18
        public System.UInt32 eventId;        // 0x1C
        public System.UInt64 audioObjectId;        // 0x20
        public System.Int32 timeMs;        // 0x28
        public System.Boolean toNearestMarker;        // 0x2C

    }

    // TypeToken: 0x2000038
    public class EventCacheInfo
    {
        // Fields
        public System.UInt32 id;        // 0x10
        public System.UInt32 refCount;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public class Cache
    {
        // Fields
        private readonly System.Collections.Generic.LinkedList<Beyond.Audio.AudioAssetCache.EventCacheInfo> m_lruCachedEventsList;        // 0x10
        private readonly System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>> m_lruCachedEvents;        // 0x18

        // Methods
        private System.Collections.Generic.LinkedList<Beyond.Audio.AudioAssetCache.EventCacheInfo> get_lruCachedEventsList() { }
        private System.Int32 get_count() { }
        private System.Void Clear() { }
        private System.UInt32 RemoveFirst(System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& outNode) { }
        private System.Boolean Remove(System.UInt32 inId, System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& outNode) { }
        private System.Void AddLast(System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003C
    public struct FOnBankLoadedDoPrepareEventPayload
    {
        // Fields
        public System.UInt32 id;        // 0x10
        public AkCallbackManager.BankCallback callback;        // 0x18
        public System.Object cookie;        // 0x20

    }

    // TypeToken: 0x200003D
    public struct FPendingLoadRequest
    {
        // Fields
        public System.UInt32 id;        // 0x10
        public Beyond.Audio.AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload payload;        // 0x18

    }

    // TypeToken: 0x2000042
    public struct FGlobalMemoryStats
    {
        // Fields
        public System.UInt64 used;        // 0x10
        public System.UInt64 reserved;        // 0x18

    }

    // TypeToken: 0x2000043
    public struct FExtraMemoryStats
    {
        // Fields
        public System.UInt64 active;        // 0x10
        public System.UInt64 mapped;        // 0x18
        public System.UInt64 retained;        // 0x20
        public System.UInt64 allocated;        // 0x28

    }

    // TypeToken: 0x2000045
    public struct UIAudioType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Audio.AudioUIUtil.UIAudioType None;        // 0x0
        public static Beyond.Audio.AudioUIUtil.UIAudioType FullScreen;        // 0x0
        public static Beyond.Audio.AudioUIUtil.UIAudioType Tips;        // 0x0

    }

    // TypeToken: 0x2000047
    public struct VfsLoadedInfo
    {
        // Fields
        public System.Collections.Generic.List<System.UInt32> loadedPcks;        // 0x10
        public System.Int32 loadedVersion;        // 0x18
        public System.Boolean isLoaded;        // 0x1C

        // Methods
        private Beyond.Audio.AudioVFSLoader.VfsLoadedInfo Create() { }

    }

    // TypeToken: 0x200004A
    public class AudioWwiseProfilingData
    {
        // Fields
        public static readonly Unity.Profiling.ProfilerCounterValue<System.Single> CPU;        // 0x0
        public static readonly Unity.Profiling.ProfilerCounterValue<System.Single> PLUGIN_CPU;        // 0x1
        public static readonly Unity.Profiling.ProfilerCounterValue<System.Int32> ACTIVE_EVENTS;        // 0x2
        public static readonly Unity.Profiling.ProfilerCounterValue<System.Int32> TOTAL_VOICES;        // 0x3
        public static readonly Unity.Profiling.ProfilerCounterValue<System.Int32> PHYS_VOICES;        // 0x4
        public static readonly Unity.Profiling.ProfilerCounterValue<System.Int32> VIR_VOPICES;        // 0x5
        public static readonly Unity.Profiling.ProfilerCounterValue<System.UInt64> TOTAL_MEM;        // 0x6
        public static readonly Unity.Profiling.ProfilerCounterValue<System.UInt64> RESERVED_MEM;        // 0x7
        public static readonly Unity.Profiling.ProfilerCounterValue<System.Single> CACHE_HIT_RATE;        // 0x8

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004E
    public struct __StaticArrayInitTypeSize=12
    {
    }

namespace Beyond.Audio
{

    // TypeToken: 0x2000007
    public class AudioAdapter
    {
        // Fields
        private static readonly AkCallbackManager.BankCallback ON_EVENT_PREPARED_DO_POST_EVENT;        // 0x0
        private static readonly AkCallbackManager.EventCallback ON_EVENT_CALLBACK;        // 0x8
        private static readonly AkCallbackManager.EventCallback ON_EXTERNAL_SOURCE_EVENT_CALLBACK;        // 0x10

        // Methods
        private System.UInt64 get_listenerObjId() { }
        private System.UInt32 PostEvent(System.String eventName) { }
        private System.UInt32 PostEvent(System.UInt32 eventId) { }
        private System.UInt32 PostEvent(System.String eventName, System.UInt64 audioObjectId) { }
        private System.UInt32 PostEvent(System.UInt32 eventId, System.UInt64 audioObjectId) { }
        private System.UInt32 PostEvent(System.String eventName, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie) { }
        private System.UInt32 PostEvent(System.UInt32 eventId, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie) { }
        private System.UInt32 PostEvent(System.String eventName, System.UInt64 audioObjectId, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie) { }
        private System.UInt32 PostEvent(System.UInt32 eventId, System.UInt64 audioObjectId, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie) { }
        private System.UInt32 PostEventExternal(System.String eventName, System.UInt64 audioObjectId, System.String externalSourceKey, System.UInt32 externalCookie, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie, Beyond.Audio.AudioCodec codec) { }
        private System.UInt32 PostEventExternal(System.UInt32 eventId, System.UInt64 audioObjectId, System.String externalSourceKey, System.UInt32 externalCookie, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie, Beyond.Audio.AudioCodec codec) { }
        private System.Void StopByPlayingId(System.UInt32 playingId, System.Int32 fadeTimeMs) { }
        private System.Void PauseByPlayingId(System.UInt32 playingId, System.Int32 fadeTimeMs) { }
        private System.Void ResumeByPlayingId(System.UInt32 playingId, System.Int32 fadeTimeMs) { }
        private System.Void PinEvent(System.UInt32 eventId) { }
        private System.Void UnpinEvent(System.UInt32 eventId) { }
        private System.Void UnpinEvent(System.String eventName) { }
        private System.Void LoadAndPinEventsSync(System.Collections.Generic.IList<System.UInt32> events) { }
        private System.Void LoadAndPinEventsSync(System.Collections.Generic.ICollection<System.String> events) { }
        private System.Void LoadAndPinEventsAsync(System.Collections.Generic.IList<System.UInt32> events, System.Action<System.Object> onDone, System.Object payload) { }
        private System.Void LoadAndPinEventsAsync(System.Collections.Generic.IList<Beyond.Audio.AudioId> events, System.Action<System.Object> onDone, System.Object payload) { }
        private System.Void LoadAndPinEventsAsync(System.Collections.Generic.ICollection<System.String> events, System.Action<System.Object> onDone, System.Object payload) { }
        private System.Collections.IEnumerator LoadAndPinEventsCoroutine(System.Collections.Generic.IList<System.UInt32> events) { }
        private System.Collections.IEnumerator LoadAndPinEventsCoroutine(System.Collections.Generic.ICollection<System.String> events) { }
        private System.Void SetState(System.String stateGroup, System.String stateName) { }
        private System.Void SetState(System.UInt32 stateGroup, System.UInt32 stateName) { }
        private System.Boolean TryGetState(System.UInt32 stateGroupId, System.UInt32& stateId) { }
        private System.Void SetSwitch(System.UInt32 switchGroup, System.UInt32 switchValue, System.UInt64 audioObjectId) { }
        private System.Void SetSwitch(System.String switchGroup, System.String switchValue, System.UInt64 audioObjectId) { }
        private System.Void SetRtpc(System.String rtpcName, System.Single rtpcValue, System.UInt64 audioObjectId) { }
        private System.Void SetRtpc(System.UInt32 rtpcId, System.Single rtpcValue, System.UInt64 audioObjectId) { }
        private System.Void SetRtpc(System.UInt32 rtpcId, System.Single rtpcValue, System.UInt64 audioObjectId, System.Int32 fadeTimeMs) { }
        private System.Void SetRtpcValueByPlayingID(System.UInt32 rtpcId, System.Single rtpcValue, System.UInt32 playingId, System.Int32 fadeTimeMs) { }
        private System.Void ResetRtpc(System.UInt32 rtpcId, System.UInt64 audioObjectId, System.Int32 fadeTimeMs) { }
        private System.Void ResetRtpc(System.String rtpcName, System.UInt64 audioObjectId, System.Int32 fadeTimeMs) { }
        private System.Boolean GetRtpcValue(System.String rtpcName, System.UInt64 audioObjectId, System.UInt32 playingId, System.Single& value, System.Int32& valueType) { }
        private System.Boolean GetRtpcValue(System.UInt32 rtpcId, System.UInt64 audioObjectId, System.UInt32 playingId, System.Single& value, System.Int32& valueType) { }
        private System.Void SeekOnEvent(System.String eventName, System.UInt64 audioObjectId, System.Int32 timeMs, System.Boolean toNearestMarker, System.UInt32 playingId) { }
        private System.Void SeekOnEvent(System.UInt32 eventId, System.UInt64 audioObjectId, System.Int32 timeMs, System.Boolean toNearestMarker, System.UInt32 playingId) { }
        private System.Void SeekOnEvent(System.String eventName, System.Int32 timeMs, System.Boolean toNearestMarker, System.UInt32 playingId) { }
        private System.Void SeekOnEvent(System.UInt32 eventId, System.Int32 timeMs, System.Boolean toNearestMarker, System.UInt32 playingId) { }
        private System.Boolean TryGetPlayingPosition(System.UInt32 playingId, System.Int32& posTimeMs, System.Boolean extrapolate) { }
        private System.Boolean IsPlaying(System.UInt32 playingId) { }
        private System.UInt32 SetScalingFactor(System.UInt64 audioObjectId, System.Single factor) { }
        private System.Boolean RegisterGameObject(System.UInt64 audioObjectId) { }
        private System.Boolean RegisterGameObject(System.UInt64 audioObjectId, System.String name) { }
        private System.Boolean UnregisterGameObject(System.UInt64 audioObjectId) { }
        private System.Void SetPosition(System.UInt64 audioObjectId, UnityEngine.Vector3 pos, UnityEngine.Vector3 forward, UnityEngine.Vector3 up) { }
        private System.Void StopAll() { }
        private System.Void StopAllOnObject(System.UInt64 audioObjectId) { }
        private System.Void ReleaseAllCachedEventsSync() { }
        private System.Void SetLargePositions(System.UInt64 audioObjectId, Beyond.Audio.AudioPositionArrayProxy positions, Beyond.Audio.AudioLargeType type) { }
        private System.Void SetDefaultListener(System.UInt64 audioObjectId) { }
        private System.Void SetListener(System.UInt64 audioObjectId, System.UInt64 listenerId) { }
        private System.Boolean TryGetRealPlayingId(System.UInt32 playingId, System.UInt32& realPlayingId) { }
        private System.Void SetDefaultEmitter(System.UInt64 audioObjectId) { }
        private System.Void SetAudioLanguage(System.String language) { }
        private System.Void SetDistanceProbe(System.UInt64 probeObjectId) { }
        private System.UInt32 ComputeIdFromString(System.String name) { }
        private System.Void SetAudioEngineInitSetting(Beyond.Audio.AudioEngineInitSetting settings) { }
        private System.Void UnsetAudioEngineInitSetting() { }
        private System.Boolean InitWwise() { }
        private System.Void TermWwise() { }
        private System.Void LoadInitResources() { }
        private System.Void ReloadInitResources() { }
        private System.Void RenderAudio() { }
        private System.Void Suspend(System.Boolean renderAnyway) { }
        private System.Void WakeupFromSuspend() { }
        private System.Void InitScePad() { }
        private System.Void SetAudioMemoryBudget(System.UInt64 inMemoryBytes, System.UInt16 inGcCount) { }
        private System.Void LogToWwise(System.String msg, System.Boolean isError, System.UInt32 playingId, System.UInt64 goId) { }
        private System.Void MemoryShrink() { }
        private System.Boolean _InitInternal() { }
        private System.Void _ReleaseInternal() { }
        private System.Void _OnBeforeTerminate() { }
        private System.Void _ResetStaticFields() { }
        private System.Void _OnEventPreparedDoPostEvent(System.UInt32 inId, System.IntPtr _, AKRESULT __, System.Object inCookie) { }
        private System.Void _OnEventCallback(System.Object inCookie, AkCallbackType inType, AkCallbackInfo inInfo) { }
        private System.Void _OnExternalSourceEventCallback(System.Object inCookie, AkCallbackType inType, AkCallbackInfo inInfo) { }
        private System.UInt32 _PostEvent(System.UInt32 eventId, System.UInt64 audioObjectId, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback originCallback, System.Object originCookie) { }
        private System.UInt32 _PostEventWithExternalSource(System.UInt32 eventId, System.UInt64 audioObjectId, System.String externalSourceKey, System.UInt32 externalCookie, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie, Beyond.Audio.AudioCodec codec) { }
        private System.Void _ExecuteActionOnPlayingId(AkActionOnEventType type, System.UInt32 playingId, System.Int32 durationMs) { }
        private System.UInt32 _GetInternalPlayingId() { }
        private System.Void _LoadAndPinEventsAsync(System.Collections.Generic.IList<System.UInt32>& events, System.Action<System.Object>& onDone, System.Object& payload) { }
        private System.Void _DoLoadAndPinEventsSync(System.Collections.Generic.IList<System.UInt32> events) { }
        private System.Collections.IEnumerator _DoLoadAndPinEventsAsync(System.Collections.Generic.IList<System.UInt32> events, System.Action<System.Object> onDone, System.Object payload) { }
        private System.Void _InitAndroidActivityEnvironment() { }
        private System.Void SetUprSamplingEnabled(System.Boolean isEnabled) { }
        private System.Void _ProfilerUpdate() { }
        private System.Void _SampleAllData() { }
        private System.Void _SampleMemoryOnly() { }
        private System.Void StartProfileCapture(System.String fileName) { }
        private System.Void StopProfileCapture() { }
        private AkResourceMonitorDataSummary GetResourceSummaryData() { }
        private Beyond.Audio.AudioMemoryMonitor.FGlobalMemoryStats GetGlobalMemoryStats() { }
        private Beyond.Audio.AudioMemoryMonitor.FExtraMemoryStats GetExtraMemoryStats() { }
        private System.Void SetEnableSpatialAudio(System.Boolean enable) { }
        private System.Void SetObjectObstructionAndOcclusion(System.UInt64 audioObjectId, System.Single obstructionLevel, System.Single occlusionLevel) { }
        private System.Boolean SetGeometry(System.UInt64 geoId, UnityEngine.Vector3[] vertices, System.UInt16[] triangles, Beyond.Audio.AudioAcousticSurfaceData[] surfaceData, System.UInt16[] surfaceIdx, System.Boolean enableDiffraction, System.Boolean enableEdgeDiffraction) { }
        private System.Boolean SetGeometryInstance(System.UInt64 instanceId, UnityEngine.Vector3 pos, UnityEngine.Vector3 scale, UnityEngine.Quaternion rot, System.UInt64 geoId, System.Boolean useReflectionAndDiffraction) { }
        private System.Boolean SetRoom(System.UInt64 roomId, Beyond.Audio.AudioRoomData roomData, System.UInt64 geoInstanceId, System.String roomName) { }
        private System.Boolean SetPortal(System.UInt64 portalId, System.UInt64 roomIdA, System.UInt64 roomIdB, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 extent, System.Boolean enabled, System.String portalName) { }
        private System.Boolean SetPortalObstructionAndOcclusion(System.UInt64 portalId, System.Single obstruction, System.Single occlusion) { }
        private System.Boolean SetReverbZone(System.UInt64 reverbZoneId, System.UInt64 parentRoom, System.Single transitionWidth) { }
        private System.Boolean RemoveRoom(System.UInt64 roomId) { }
        private System.Boolean RemovePortal(System.UInt64 portalId) { }
        private System.Boolean RemoveGeometry(System.UInt64 geoId) { }
        private System.Boolean RemoveGeometryInstance(System.UInt64 instanceId) { }
        private System.Boolean RemoveReverbZone(System.UInt64 reverbZoneId) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000010
    public class AudioEventCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object in_cookie, Beyond.Audio.AudioCallbackType in_type, Beyond.Audio.AudioCallbackInfo in_info) { }
        private System.IAsyncResult BeginInvoke(System.Object in_cookie, Beyond.Audio.AudioCallbackType in_type, Beyond.Audio.AudioCallbackInfo in_info, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000011
    public class AudioStringAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class AudioVectorAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class AudioEventWarnAttribute : PropertyAttribute
    {
        // Fields
        public Beyond.Audio.AudioEventWarnAttribute.WarnType warnType;        // 0x10

        // Methods
        private System.Void .ctor(Beyond.Audio.AudioEventWarnAttribute.WarnType type) { }

    }

    // TypeToken: 0x2000015
    public class BankHandle, IDisposable
    {
        // Fields
        private readonly System.String <name>k__BackingField;        // 0x10
        private AKRESULT <result>k__BackingField;        // 0x18
        private System.Boolean <isDone>k__BackingField;        // 0x1C
        private System.Int32 m_refCount;        // 0x20

        // Methods
        private System.String get_name() { }
        private AKRESULT get_result() { }
        private System.Void set_result(AKRESULT value) { }
        private System.Boolean get_isDone() { }
        private System.Void set_isDone(System.Boolean value) { }
        private System.Int32 get_refCount() { }
        private System.Void .ctor(System.String bankName) { }
        private System.Void Dispose() { }
        private System.Void IncRef() { }
        private System.Void DecRef() { }

    }

    // TypeToken: 0x2000016
    public class AsyncLoadBankTask, IEnumerator, IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.List<Beyond.Audio.BankHandle> m_handles;        // 0x10

        // Methods
        private Beyond.Audio.AsyncLoadBankTask LoadBanksAsync(System.Collections.Generic.IList<System.String> bankNames) { }
        private System.Void .ctor(System.Collections.Generic.IList<System.String> bankNames) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Object get_Current() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000017
    public class AudioBankManager
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.String,Beyond.Audio.BankHandle> s_loadedBankHandles;        // 0x0

        // Methods
        private System.Void LoadMainPCK() { }
        private Beyond.Audio.BankHandle LoadBankAsync(System.String bankName, System.Action callback) { }
        private System.Void _LoadBankCallback(System.UInt32 inBankId, System.IntPtr _, AKRESULT inLoadResult, System.Object inCookie) { }
        private System.Boolean UnloadBank(System.String bankName) { }
        private System.Void UnloadAllBanks() { }
        private System.Boolean IsBankLoaded(System.String bankName) { }
        private System.Void Reset() { }
        private System.Void LoadDebugFilePackage(System.String path) { }
        private System.Void AddDebugBankPath(System.String path) { }
        private System.Void _PreResetBasePath(System.Collections.Generic.List<System.UInt32>& unPinnedEventIds) { }
        private System.Void _PostResetBasePath(System.Collections.Generic.List<System.UInt32> unPinnedEventIds) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000019
    public class AudioConstants
    {
        // Fields
        public static System.UInt64 AUDIO_INVALID_GAME_OBJECT;        // 0x0
        public static System.UInt32 AUDIO_INVALID_UNIQUE_ID;        // 0x0
        public static System.UInt32 AUDIO_INVALID_INTERNAL_PLAYING_ID;        // 0x0
        public static System.UInt64 AUDIO_GLOBAL_GAME_OBJECT;        // 0x0
        public static System.UInt64 AUDIO_ROOM_OUTDOOR_ID;        // 0x0
        public static System.UInt64 AUDIO_ROOM_OUTDOORS_ID;        // 0x0
        public static System.String AU_UI_BATTLE_BREAK_POISE;        // 0x0
        public static System.String AU_GLOBAL_GAIN_ON;        // 0x0
        public static System.String AU_GLOBAL_GAIN_OFF;        // 0x0
        public static System.UInt32 AU_HASH_EXTERNAL_SOURCE_COOKIE;        // 0x0
        public static System.UInt32 AU_BANK_INIT;        // 0x0
        public static System.String AU_DEVICE_CONTROLLER_SPEAKER;        // 0x0
        public static System.Int32 AUDIO_SPEAKER_SETUP_4_0;        // 0x0
        public static System.String AU_DEVICE_WWISE_MOTION;        // 0x0
        public static System.String AU_DEVICE_SYSTEM;        // 0x0
        public static System.String AU_DEVICE_SYSTEM_3D;        // 0x0
        public static System.UInt32 AUDIO_UI_FULLSCREEN_OPEN;        // 0x0
        public static System.UInt32 AUDIO_UI_FULLSCREEN_CLOSE;        // 0x0
        public static System.UInt32 AUDIO_UI_FULLSCREEN_PAUSE;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public struct AudioId
    {
        // Fields
        public System.Int32 _id;        // 0x10

        // Methods
        private System.Void .ctor(System.UInt32 id) { }
        private System.String GetName() { }
        private System.UInt32 op_Implicit(Beyond.Audio.AudioId id) { }
        private System.Int32 op_Implicit(Beyond.Audio.AudioId id) { }
        private Beyond.Audio.AudioId op_Implicit(System.UInt32 id) { }
        private Beyond.Audio.AudioId op_Implicit(System.Int32 id) { }
        private Beyond.Audio.AudioId op_Implicit(System.String id) { }

    }

    // TypeToken: 0x200001B
    public class AudioIdExtensions
    {
        // Methods
        private System.UInt32[] ToUIntArray(System.Collections.Generic.ICollection<Beyond.Audio.AudioId> ids) { }

    }

    // TypeToken: 0x200001C
    public struct AudioState, IEquatable`1
    {
        // Fields
        private System.Int32 _stateGroup;        // 0x10
        private System.Int32 _stateValue;        // 0x14

        // Methods
        private System.UInt32 get_stateGroup() { }
        private System.UInt32 get_stateValue() { }
        private System.Void .ctor(System.UInt32 stateGroup, System.UInt32 stateValue) { }
        private System.Boolean Equals(Beyond.Audio.AudioState other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean <>iFixBaseProxy_Equals(System.Object P0) { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x200001D
    public struct AudioIdList
    {
        // Fields
        public Beyond.Audio.AudioId[] _ids;        // 0x10

    }

    // TypeToken: 0x200001E
    public struct AudioStateList
    {
        // Fields
        public Beyond.Audio.AudioState[] _states;        // 0x10

    }

    // TypeToken: 0x200001F
    public struct AudioEngineInitSetting
    {
        // Fields
        public AkWwiseInitializationSettings akInitSettings;        // 0x10

    }

    // TypeToken: 0x2000020
    public struct AudioLargeSource
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Quaternion rotation;        // 0x1C

    }

    // TypeToken: 0x2000021
    public struct AudioCallbackInfo
    {
        // Fields
        public System.UInt64 objectId;        // 0x10
        public System.IntPtr pCookie;        // 0x18
        private AkCallbackInfo rawInfo;        // 0x20

        // Methods
        private Beyond.Audio.AudioDurationCallbackInfo CastToDurationCallbackInfo() { }

    }

    // TypeToken: 0x2000022
    public struct AudioDurationCallbackInfo
    {
        // Fields
        public System.Single duration;        // 0x10
        public System.Single estimatedDuration;        // 0x14
        public System.UInt32 audioNodeId;        // 0x18
        public System.UInt32 mediaId;        // 0x1C
        public System.Boolean isStreaming;        // 0x20

    }

    // TypeToken: 0x2000023
    public class AudioPositionArrayProxy
    {
        // Fields
        private AkPositionArray m_array;        // 0x10

        // Methods
        private System.UInt32 get_count() { }
        private System.Void .ctor(System.UInt32 count) { }
        private AkPositionArray GetRawArray() { }
        private System.Void Add(UnityEngine.Vector3 position, UnityEngine.Vector3 forward, UnityEngine.Vector3 up) { }
        private System.Void Reset() { }
        private System.Void Finalize() { }

    }

    // TypeToken: 0x2000024
    public struct AudioAcousticSurfaceData
    {
        // Fields
        public System.UInt32 textureId;        // 0x10
        public System.Single transmissionLoss;        // 0x14

    }

    // TypeToken: 0x2000025
    public struct AudioRoomData
    {
        // Fields
        public System.UInt32 roomToneId;        // 0x10
        public System.UInt32 priority;        // 0x14
        public System.UInt32 auxBusId;        // 0x18
        public System.UInt32 parentRoomId;        // 0x1C
        public System.Single auxLevel;        // 0x20
        public System.Single auxLevelToSelf;        // 0x24
        public System.Single transmissionLoss;        // 0x28
        public System.Single transitionWidth;        // 0x2C
        public System.Single t60DecayTIme;        // 0x30
        public System.Single preDelayTime;        // 0x34
        public System.Single reverbLevel;        // 0x38
        public System.Single erLevel;        // 0x3C
        public Beyond.Audio.AudioRoomData.EBoolFlags flags;        // 0x40

    }

    // TypeToken: 0x2000027
    public struct AudioCallbackType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Audio.AudioCallbackType None;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_EndOfEvent;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_EndOfDynamicSequenceItem;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_Marker;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_Duration;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_SpeakerVolumeMatrix;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_Starvation;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_MusicPlaylistSelect;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_MusicPlayStarted;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_MusicSyncBeat;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_MusicSyncBar;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_MusicSyncEntry;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_MusicSyncExit;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_MusicSyncGrid;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_MusicSyncUserCue;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_MusicSyncPoint;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_MusicSyncAll;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_MIDIEvent;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_CallbackBits;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_EnableGetSourcePlayPosition;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_EnableGetMusicPlayPosition;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_EnableGetSourceStreamBuffering;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_Monitoring;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_Bank;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_AudioInterruption;        // 0x0
        public static Beyond.Audio.AudioCallbackType AU_AudioSourceChange;        // 0x0

    }

    // TypeToken: 0x2000028
    public struct AudioLargeType
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Beyond.Audio.AudioLargeType Sum;        // 0x0
        public static Beyond.Audio.AudioLargeType Nearest;        // 0x0
        public static Beyond.Audio.AudioLargeType Single;        // 0x0

    }

    // TypeToken: 0x2000029
    public struct AudioPlayableActions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Audio.AudioPlayableActions None;        // 0x0
        public static Beyond.Audio.AudioPlayableActions Playback;        // 0x0
        public static Beyond.Audio.AudioPlayableActions Stop;        // 0x0
        public static Beyond.Audio.AudioPlayableActions Seek;        // 0x0

    }

    // TypeToken: 0x200002A
    public struct AudioEventType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Audio.AudioEventType Sfx;        // 0x0
        public static Beyond.Audio.AudioEventType Music;        // 0x0
        public static Beyond.Audio.AudioEventType State;        // 0x0
        public static Beyond.Audio.AudioEventType GameSync;        // 0x0
        public static Beyond.Audio.AudioEventType Voice;        // 0x0
        public static Beyond.Audio.AudioEventType Controller;        // 0x0
        public static Beyond.Audio.AudioEventType Vibration;        // 0x0
        public static Beyond.Audio.AudioEventType Global;        // 0x0

    }

    // TypeToken: 0x200002B
    public struct AudioMixDownMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Audio.AudioMixDownMode Direct;        // 0x0
        public static Beyond.Audio.AudioMixDownMode ForceToMono;        // 0x0

    }

    // TypeToken: 0x200002C
    public struct AudioMasteringSuiteMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Audio.AudioMasteringSuiteMode Headphone;        // 0x0
        public static Beyond.Audio.AudioMasteringSuiteMode TV;        // 0x0
        public static Beyond.Audio.AudioMasteringSuiteMode HomeCinema;        // 0x0
        public static Beyond.Audio.AudioMasteringSuiteMode SoundBar;        // 0x0
        public static Beyond.Audio.AudioMasteringSuiteMode Speaker;        // 0x0
        public static Beyond.Audio.AudioMasteringSuiteMode DevMode;        // 0x0

    }

    // TypeToken: 0x200002D
    public struct AudioChannelConfigType
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static Beyond.Audio.AudioChannelConfigType Anonymous;        // 0x0
        public static Beyond.Audio.AudioChannelConfigType Standard;        // 0x0
        public static Beyond.Audio.AudioChannelConfigType Ambisonic;        // 0x0
        public static Beyond.Audio.AudioChannelConfigType Objects;        // 0x0
        public static Beyond.Audio.AudioChannelConfigType UseDeviceMain;        // 0x0
        public static Beyond.Audio.AudioChannelConfigType UseDevicePassthrough;        // 0x0

    }

    // TypeToken: 0x200002E
    public struct AudioCodec
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static Beyond.Audio.AudioCodec PCM;        // 0x0
        public static Beyond.Audio.AudioCodec ADPCM;        // 0x0
        public static Beyond.Audio.AudioCodec VORBIS;        // 0x0
        public static Beyond.Audio.AudioCodec ATRAC9;        // 0x0
        public static Beyond.Audio.AudioCodec OPUS_WEM;        // 0x0

    }

    // TypeToken: 0x200002F
    public struct AudioChannelMask
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static Beyond.Audio.AudioChannelMask NONE;        // 0x0
        public static Beyond.Audio.AudioChannelMask FRONT_LEFT;        // 0x0
        public static Beyond.Audio.AudioChannelMask FRONT_RIGHT;        // 0x0
        public static Beyond.Audio.AudioChannelMask FRONT_CENTER;        // 0x0
        public static Beyond.Audio.AudioChannelMask LOW_FREQUENCY;        // 0x0
        public static Beyond.Audio.AudioChannelMask BACK_LEFT;        // 0x0
        public static Beyond.Audio.AudioChannelMask BACK_RIGHT;        // 0x0
        public static Beyond.Audio.AudioChannelMask BACK_CENTER;        // 0x0
        public static Beyond.Audio.AudioChannelMask SIDE_LEFT;        // 0x0
        public static Beyond.Audio.AudioChannelMask SIDE_RIGHT;        // 0x0
        public static Beyond.Audio.AudioChannelMask TOP;        // 0x0
        public static Beyond.Audio.AudioChannelMask HEIGHT_FRONT_LEFT;        // 0x0
        public static Beyond.Audio.AudioChannelMask HEIGHT_FRONT_CENTER;        // 0x0
        public static Beyond.Audio.AudioChannelMask HEIGHT_FRONT_RIGHT;        // 0x0
        public static Beyond.Audio.AudioChannelMask HEIGHT_BACK_LEFT;        // 0x0
        public static Beyond.Audio.AudioChannelMask HEIGHT_BACK_CENTER;        // 0x0
        public static Beyond.Audio.AudioChannelMask HEIGHT_BACK_RIGHT;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_MONO;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_0POINT1;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_1POINT1;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_STEREO;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_2POINT1;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_3STEREO;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_3POINT1;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_4;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_4POINT1;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_5;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_5POINT1;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_6;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_6POINT1;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_7;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_7POINT1;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_SURROUND;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_DPL2;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_HEIGHT_4;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_HEIGHT_5;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_HEIGHT_ALL;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_222;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_8;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_9;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_9POINT1;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_10;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_10POINT1;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_11;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_11POINT1;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_11_740;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_11POINT1_740;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_13_751;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_AURO_13POINT1_751;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_DOLBY_5_0_2;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_DOLBY_5_1_2;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_DOLBY_6_0_2;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_DOLBY_6_1_2;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_DOLBY_6_0_4;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_DOLBY_6_1_4;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_DOLBY_7_0_2;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_DOLBY_7_1_2;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_DOLBY_7_0_4;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_DOLBY_7_1_4;        // 0x0
        public static Beyond.Audio.AudioChannelMask SETUP_ALL_SPEAKERS;        // 0x0

    }

    // TypeToken: 0x2000030
    public struct AudioLogChannel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Audio.AudioLogChannel NONE;        // 0x0
        public static Beyond.Audio.AudioLogChannel API;        // 0x0
        public static Beyond.Audio.AudioLogChannel IO;        // 0x0
        public static Beyond.Audio.AudioLogChannel OBJECT;        // 0x0
        public static Beyond.Audio.AudioLogChannel MUSIC;        // 0x0
        public static Beyond.Audio.AudioLogChannel SPATIAL;        // 0x0
        public static Beyond.Audio.AudioLogChannel SCENE;        // 0x0
        public static Beyond.Audio.AudioLogChannel VOICE;        // 0x0
        public static Beyond.Audio.AudioLogChannel GAMEPLAY;        // 0x0
        public static Beyond.Audio.AudioLogChannel GP_STATE;        // 0x0
        public static Beyond.Audio.AudioLogChannel GP_CUE;        // 0x0
        public static Beyond.Audio.AudioLogChannel GP_FACTORY;        // 0x0
        public static Beyond.Audio.AudioLogChannel GP_UI;        // 0x0
        public static Beyond.Audio.AudioLogChannel GP_ANIM;        // 0x0
        public static Beyond.Audio.AudioLogChannel MOTION;        // 0x0
        public static Beyond.Audio.AudioLogChannel WWISE;        // 0x0
        public static Beyond.Audio.AudioLogChannel EDITOR;        // 0x0
        public static Beyond.Audio.AudioLogChannel MISC;        // 0x0
        public static Beyond.Audio.AudioLogChannel ALL;        // 0x0

    }

    // TypeToken: 0x2000031
    public class AudioLogger
    {
        // Fields
        public static Beyond.Audio.AudioLogChannel s_enabledChannels;        // 0x0

        // Methods
        private System.Boolean IsChannelEnabled(Beyond.Audio.AudioLogChannel channel) { }
        private System.Void EnableChannel(Beyond.Audio.AudioLogChannel channel) { }
        private System.Void DisableChannel(Beyond.Audio.AudioLogChannel channel) { }
        private System.Void SetChannels(Beyond.Audio.AudioLogChannel channel) { }
        private System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg) { }
        private System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1) { }
        private System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2) { }
        private System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3) { }
        private System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { }
        private System.Void LogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg) { }
        private System.Void LogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1) { }
        private System.Void LogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2) { }
        private System.Void LogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogError(Beyond.Audio.AudioLogChannel channel, System.String msg) { }
        private System.Void LogError(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1) { }
        private System.Void LogError(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2) { }
        private System.Void LogError(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3) { }
        private System.Void LogError(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void _DoLog(Beyond.Audio.AudioLogChannel channel, System.String msg) { }
        private System.Void _DoLogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg) { }
        private System.Void _DoLogError(Beyond.Audio.AudioLogChannel channel, System.String msg) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000032
    public class AudioAcousticUtil
    {
        // Fields
        private static System.Single SOUND_SPEED;        // 0x0

        // Methods
        private System.Single RT60DecayTime(System.Single volume, System.Single surfaceArea, System.Single absorptionFactor) { }
        private System.Single PreDelayTime(UnityEngine.Vector3 size) { }
        private System.Single CriticalDistance(System.Single volume, System.Single rt60, System.Single gamma) { }
        private System.Single ReverbIntensity(UnityEngine.Vector3 size) { }
        private System.Single ErIntensity(UnityEngine.Vector3 size) { }

    }

    // TypeToken: 0x2000033
    public class AudioActionQueueHelper
    {
        // Fields
        private static System.Collections.Generic.Queue<Beyond.Audio.AudioActionQueueHelper.FExecuteAction> s_executeActionQueue;        // 0x0
        private static System.Collections.Generic.Queue<Beyond.Audio.AudioActionQueueHelper.FRTPCAction> s_rtpcActionQueue;        // 0x8
        private static System.Collections.Generic.Queue<Beyond.Audio.AudioActionQueueHelper.FSeekAction> s_seekActionQueue;        // 0x10
        private static System.Int32 QUEUE_LIFETIME_FRAME;        // 0x0

        // Methods
        private System.Void QueueExecuteAction(System.UInt32 playingId, AkActionOnEventType actionType, System.Int32 durationMs) { }
        private System.Void QueueRtpcAction(System.UInt32 playingId, System.UInt32 rtpcId, System.Single targetValue, System.Int32 durationMs) { }
        private System.Void QueueSeekAction(System.UInt32 playingId, System.UInt32 eventId, System.UInt64 audioObjectId, System.Int32 timeMs, System.Boolean toNearestMarker) { }
        private System.Void ConsumeQueue() { }
        private System.Void ClearQueue() { }
        private System.Void _ConsumeExecute(System.Int32 currFrame) { }
        private System.Void _ConsumeRtpc(System.Int32 currFrame) { }
        private System.Void _ConsumeSeek(System.Int32 currFrame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000037
    public class AudioAssetCache
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>> s_lruUsingEvents;        // 0x0
        private static Beyond.Audio.AudioAssetCache.Cache s_cachedEvents;        // 0x8
        private static System.Collections.Generic.HashSet<System.UInt32> s_pinnedEvents;        // 0x10
        private static System.Int32 INIT_PREPARE_CAP;        // 0x0
        private static Beyond.PoolCore.ObjectPool<System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>> s_nodePool;        // 0x18

        // Methods
        private System.Void Reset() { }
        private System.Void PinEvent(System.UInt32 inId) { }
        private System.Void UnpinEvent(System.UInt32 inId) { }
        private System.Void GetAllUsingAssetsAndRelease(System.Collections.Generic.List<System.UInt32>& allIds) { }
        private System.UInt32 GetLeastActiveAssetAndUncache() { }
        private System.Int32 GetCachedAssetCount() { }
        private System.Boolean ActivateAsset(System.UInt32 inId) { }
        private System.Void DeactivateAsset(System.UInt32 inId) { }
        private System.Void ForceReleaseCachedAsset(System.UInt32 inId) { }
        private System.Void _NotifyDebugger() { }
        private System.Void _NotifyDebuggerCacheHit(System.Boolean isHit) { }
        private System.Void _ResetDebugger() { }
        private System.Void _PinnedEventLeakDetect() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003B
    public class AudioAssetHelper
    {
        // Fields
        private static System.UInt64 s_memoryBudget;        // 0x0
        private static System.Single FACTOR_B_TO_MB;        // 0x0
        private static System.UInt16 s_gcCount;        // 0x8
        private static System.Int32 s_gcPendingCount;        // 0xC
        private static System.Collections.Generic.Queue<Beyond.Audio.AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload> s_waitingCallbacks;        // 0x10
        private static System.Collections.Generic.Queue<Beyond.Audio.AudioAssetHelper.FPendingLoadRequest> s_pendingLoadRequests;        // 0x18
        private static System.Collections.Generic.HashSet<System.UInt32> s_solidLoadedEvents;        // 0x20
        private static readonly System.UInt32[] S_REUSABLE_UINT_ARRAY;        // 0x28
        private static readonly AkCallbackManager.BankCallback ON_UNPREPARED_DO_UNLOAD_BANK;        // 0x30
        private static readonly AkCallbackManager.BankCallback ON_DONE_UNLOAD_BANK;        // 0x38
        private static readonly AkCallbackManager.BankCallback ON_BANK_LOADED_DO_PREPARE_EVENT;        // 0x40
        private static readonly AkCallbackManager.BankCallback ON_DONE_PREPARE_EVENT;        // 0x48

        // Methods
        private System.Boolean get_isGcProcessing() { }
        private System.Void SetMemoryBudget(System.UInt64 inBudgetBytes, System.UInt16 inGcCount) { }
        private System.Boolean HasPreparingEvents() { }
        private System.Void UnPrepareAllEventsSync() { }
        private System.Void LoadEventAsync(System.UInt32 inId, AkCallbackManager.BankCallback callback, System.Object cookie) { }
        private System.Void _TryConsumePendingLoadRequests() { }
        private System.Void _ConsumePendingLoadRequests() { }
        private System.Void _DoLoadEventAsync(System.UInt32 inId, Beyond.Audio.AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload payload) { }
        private System.Void PinEvent(System.UInt32 inId) { }
        private System.Void UnpinEvent(System.UInt32 inId) { }
        private System.Void ResetStaticFields() { }
        private System.Void ReleaseAllCachedEventsSync() { }
        private System.Void _TryGC() { }
        private System.Void _DoGc(System.Int32 gcCount) { }
        private System.Void UnloadEvent(System.UInt32 inId) { }
        private System.Void _OnUnpreparedDoUnloadBank(System.UInt32 inId, System.IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, System.Object inCookie) { }
        private System.Void _OnDoneUnloadBank(System.UInt32 inId, System.IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, System.Object inCookie) { }
        private System.Void _OnBankLoadedDoPrepareEvent(System.UInt32 inId, System.IntPtr _, AKRESULT inLoadResult, System.Object __) { }
        private System.Void _OnDonePrepareEvent(System.UInt32 inId, System.IntPtr _, AKRESULT __, System.Object ___) { }
        private System.Void _TryDequeueAndInvokeCallback() { }
        private System.Void _RemoveLoadingDebug(System.UInt32 inId) { }
        private System.Void _AddLoadingDebug(System.UInt32 inId) { }
        private System.Void _ClearLoadingDebug() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003E
    public class AudioCallbackMessageParser
    {
        // Methods
        private System.Void Set() { }
        private System.Void _OnMonitoringCallback(AkMonitorErrorCode inErrorCode, AkMonitorErrorLevel inErrorLevel, System.UInt32 inPlayingID, System.UInt64 inGameObjID, System.String inMsg) { }

    }

    // TypeToken: 0x200003F
    public class AudioDebugInfoContainer
    {
        // Methods
        private System.Void SetAudioObjectName(System.UInt64 audioObjId, System.String name) { }
        private System.Void RemoveAudioObjectName(System.UInt64 audioObjId) { }
        private System.String GetAudioObjectName(System.UInt64 audioObjId) { }
        private System.String ForceGetEventName(System.UInt32 eventId) { }
        private System.String ForceGetRtpcName(System.UInt32 rtpcId) { }
        private System.String GetRtpcName(System.UInt32 rtpcId) { }
        private System.String GetEventName(System.UInt32 eventId) { }

    }

    // TypeToken: 0x2000040
    public class AudioHashGenerator
    {
        // Fields
        private static System.UInt32 PRIME32;        // 0x0
        private static System.UInt32 OFFSET_BASIS32;        // 0x0

        // Methods
        private System.UInt32 Compute(System.String inStr) { }
        private System.UInt32 Compute(System.String inStr1, System.String inStr2) { }
        private System.UInt32 Compute(System.String[] strings) { }
        private System.UInt32 _GetUintFromCharToLower(System.Char c) { }

    }

    // TypeToken: 0x2000041
    public class AudioMemoryMonitor
    {
        // Fields
        private static AkMemCategroyStats s_categoryStats;        // 0x0
        private static System.Boolean s_monitorInited;        // 0x8

        // Methods
        private System.Void Init() { }
        private System.Void Release() { }
        private System.Boolean IsValid() { }
        private System.UInt64 GetUsedMemoryUnsafe() { }
        private System.UInt64 GetUsedMemory() { }
        private Beyond.Audio.AudioMemoryMonitor.FGlobalMemoryStats GetGlobalMemoryStats() { }
        private Beyond.Audio.AudioMemoryMonitor.FExtraMemoryStats GetExtraMemoryStats() { }
        private System.UInt64 GetUsedMemoryByCategory(AkMemID memCategory) { }

    }

    // TypeToken: 0x2000044
    public class AudioUIUtil
    {
        // Fields
        private static System.UInt16 s_fullScreenCounter;        // 0x0

        // Methods
        private System.Void Init() { }
        private System.Void Release() { }
        private System.UInt32 PostUIEvent(System.String eventName, UnityEngine.GameObject uiGameObject) { }
        private System.UInt32 PostUIEvent(System.String eventName, System.String objPath) { }
        private System.Void OnUIPanelClose(Beyond.Audio.AudioUIUtil.UIAudioType uiAudioType) { }
        private System.Void OnUIPanelOpen(Beyond.Audio.AudioUIUtil.UIAudioType uiAudioType) { }

    }

    // TypeToken: 0x2000046
    public class AudioVFSLoader
    {
        // Fields
        private static System.String PCK_SUFFIX;        // 0x0
        private static Beyond.Audio.AudioVFSLoader.VfsLoadedInfo s_loadedInitPckInfo;        // 0x0
        private static Beyond.Audio.AudioVFSLoader.VfsLoadedInfo s_loadedMainPckInfo;        // 0x10
        private static Beyond.Audio.AudioVFSLoader.VfsLoadedInfo s_loadedAuditPckInfo;        // 0x20
        private static Beyond.Audio.AudioVFSLoader.VfsLoadedInfo s_loadedLangPckInfo;        // 0x30
        private static Beyond.VFS.EVFSBlockType s_pendingLanguageBlock;        // 0x40

        // Methods
        private System.Void UnloadAll() { }
        private System.Boolean TryLoadInitPck() { }
        private System.Boolean TryLoadMainPck() { }
        private System.Boolean TryLoadLanguagePck(System.String language) { }
        private System.Boolean _DoLoadLanguagePck(Beyond.VFS.EVFSBlockType blockType) { }
        private System.Void InitBasePaths() { }
        private System.Boolean _TryLoadPcksFromVfsInfo(Beyond.VFS.VFBlockMainInfo vfsInfo, Beyond.Audio.AudioVFSLoader.VfsLoadedInfo& info) { }
        private System.Boolean _DoLoadPcksFromVfs(Beyond.VFS.VFBlockMainInfo vfs, System.Collections.Generic.List<System.UInt32>& loaded) { }
        private System.Boolean _DoLoadSinglePckFromVfs(Beyond.VFS.FVFBlockFileInfo fileInfo, System.UInt32& loadedId) { }
        private System.Void _UnloadPcks(Beyond.Audio.AudioVFSLoader.VfsLoadedInfo& info) { }
        private Beyond.VFS.EVFSBlockType _GetVfsBlockTypeFromLanguage(System.String language) { }

    }

}

namespace Beyond.Audio.AudioPerformanceMonitor
{

    // TypeToken: 0x2000049
    public class AudioProfiling
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public class WwiseResourceMonitor : Singleton`1
    {
        // Fields
        private static System.Single TIME_OF_SOUND_FRAME;        // 0x0
        private static System.Single MB_RATE;        // 0x0
        private System.Boolean m_isActiveAkResourceMonitoring;        // 0x10
        private Beyond.Audio.AudioPerformanceMonitor.WwiseResourceMonitorItem m_wwiseResourceMonitorData;        // 0x14

        // Methods
        private System.Boolean get_isActiveAkResourceMonitoring() { }
        private System.Void .ctor() { }
        private System.Boolean IsSupportMemoryMonitor() { }
        private System.Void StartSoundEngineResourceMonitor() { }
        private System.Void StopSoundEngineResourceMonitor() { }
        private Beyond.Audio.AudioPerformanceMonitor.WwiseResourceMonitorItem SampleRawWwiseResource() { }

    }

    // TypeToken: 0x200004C
    public struct WwiseResourceMonitorItem
    {
        // Fields
        public System.Single pluginCpu;        // 0x10
        public System.Single cpu;        // 0x14
        public System.Single pluginCpuInMs;        // 0x18
        public System.Single cpuInMs;        // 0x1C
        public System.Single reservedMemory;        // 0x20
        public System.Single usedMemory;        // 0x24
        public System.Single allocatedMemory;        // 0x28
        public System.Single mappedMemory;        // 0x2C
        public System.Single activeMemory;        // 0x30
        public System.Single retainedMemory;        // 0x34
        public System.Int32 eventNum;        // 0x38
        public System.Int32 totalVoiceNum;        // 0x3C
        public System.Int32 physicalVoiceNum;        // 0x40
        public System.Int32 virtualVoiceNum;        // 0x44
        public System.Int32 eventCallbackCount;        // 0x48
        public System.Int32 bankCallbackCount;        // 0x4C

    }

}

namespace Beyond.Audio.Editor
{

    // TypeToken: 0x2000048
    public class AudioEditorAssetsLoader
    {
        // Methods
        private System.Void Init() { }
        private System.Void Release() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000003
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class AnimatorBlackboardAttribute : Attribute
    {
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
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

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

    // TypeToken: 0x200004F
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.UInt32 __Gen_Wrap_0(System.UInt32 P0, System.UInt64 P1, System.Object P2, System.UInt32 P3, Beyond.Audio.AudioCallbackType P4, System.Object P5, System.Object P6, Beyond.Audio.AudioCodec P7) { }
        private System.UInt32 __Gen_Wrap_1(System.Object P0, System.UInt64 P1, System.Object P2, System.UInt32 P3, Beyond.Audio.AudioCallbackType P4, System.Object P5, System.Object P6, Beyond.Audio.AudioCodec P7) { }
        private System.Void __Gen_Wrap_2(System.UInt32 P0, System.IntPtr P1, AKRESULT P2, System.Object P3) { }
        private System.Void __Gen_Wrap_3(System.Object P0) { }
        private System.Collections.IEnumerator __Gen_Wrap_4(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_5(System.Collections.Generic.IList<System.UInt32>& P0, System.Action<System.Object>& P1, System.Object& P2) { }
        private System.Void __Gen_Wrap_6(System.Object P0, System.Object P1, System.Object P2) { }
        private System.UInt32 __Gen_Wrap_7(Beyond.Audio.AudioId P0) { }
        private System.Collections.IEnumerator __Gen_Wrap_8(System.Object P0) { }
        private System.Void __Gen_Wrap_9(System.UInt32 P0, System.UInt32 P1, System.UInt64 P2) { }
        private System.Void __Gen_Wrap_10(System.Object P0, System.Object P1, System.UInt64 P2) { }
        private System.UInt32 __Gen_Wrap_11(System.Object P0) { }
        private System.Void __Gen_Wrap_12(System.UInt32 P0, System.Single P1, System.UInt64 P2) { }
        private System.Void __Gen_Wrap_13(System.Object P0, System.Single P1, System.UInt64 P2) { }
        private System.Void __Gen_Wrap_14(System.UInt32 P0, System.Single P1, System.UInt64 P2, System.Int32 P3) { }
        private System.Void __Gen_Wrap_15(System.UInt32 P0, System.UInt32 P1, System.Single P2, System.Int32 P3) { }
        private System.Void __Gen_Wrap_16(System.UInt32 P0, System.Single P1, System.UInt32 P2, System.Int32 P3) { }
        private System.Void __Gen_Wrap_17(System.UInt32 P0, System.UInt64 P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_18(System.Object P0, System.UInt64 P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_19(System.UInt32 P0, System.UInt32 P1, System.UInt64 P2, System.Int32 P3, System.Boolean P4) { }
        private System.Void __Gen_Wrap_20(System.UInt32 P0, System.UInt64 P1, System.Int32 P2, System.Boolean P3, System.UInt32 P4) { }
        private System.Void __Gen_Wrap_21(System.Object P0, System.UInt64 P1, System.Int32 P2, System.Boolean P3, System.UInt32 P4) { }
        private System.Void __Gen_Wrap_22(System.Object P0, System.Int32 P1, System.Boolean P2, System.UInt32 P3) { }
        private System.Void __Gen_Wrap_23(System.UInt32 P0, System.Int32 P1, System.Boolean P2, System.UInt32 P3) { }
        private System.Boolean __Gen_Wrap_24(System.UInt32 P0, System.Int32& P1, System.Boolean P2) { }
        private System.Boolean __Gen_Wrap_25(System.UInt32 P0) { }
        private System.Int32 __Gen_Wrap_26() { }
        private System.UInt32 __Gen_Wrap_27(System.Object P0, System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& P1) { }
        private System.UInt32 __Gen_Wrap_28() { }
        private System.Boolean __Gen_Wrap_29(System.Object P0, System.UInt32 P1, System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& P2) { }
        private System.Void __Gen_Wrap_30() { }
        private System.Void __Gen_Wrap_31(System.UInt32 P0, Beyond.Audio.AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload P1) { }
        private System.Void __Gen_Wrap_32(System.Int32 P0) { }
        private AkPositionArray __Gen_Wrap_33(System.Object P0) { }
        private System.Void __Gen_Wrap_34(System.UInt64 P0, System.Object P1, Beyond.Audio.AudioLargeType P2) { }
        private System.Void __Gen_Wrap_35(System.UInt64 P0) { }
        private System.Void __Gen_Wrap_36(System.UInt64 P0, System.UInt64 P1) { }
        private System.Boolean __Gen_Wrap_37(System.UInt32 P0, System.UInt32& P1) { }
        private Beyond.VFS.EVFSBlockType __Gen_Wrap_38(System.Object P0) { }
        private System.Void __Gen_Wrap_39(Beyond.Audio.AudioVFSLoader.VfsLoadedInfo& P0) { }
        private System.Boolean __Gen_Wrap_40(Beyond.VFS.FVFBlockFileInfo P0, System.UInt32& P1) { }
        private System.Boolean __Gen_Wrap_41(System.Object P0, System.Collections.Generic.List<System.UInt32>& P1) { }
        private System.Boolean __Gen_Wrap_42(System.Object P0, Beyond.Audio.AudioVFSLoader.VfsLoadedInfo& P1) { }
        private System.Boolean __Gen_Wrap_43(Beyond.VFS.EVFSBlockType P0) { }
        private System.Boolean __Gen_Wrap_44(System.Object P0) { }
        private System.Void __Gen_Wrap_45(Beyond.Audio.AudioEngineInitSetting P0) { }
        private Beyond.Audio.AudioAdapter.PayloadPostEvent __Gen_Wrap_46() { }
        private System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo> __Gen_Wrap_47() { }
        private Beyond.Audio.AudioVFSLoader.VfsLoadedInfo __Gen_Wrap_48() { }
        private System.Boolean __Gen_Wrap_49() { }
        private System.Void __Gen_Wrap_50(System.Collections.Generic.List<System.UInt32>& P0) { }
        private System.Void __Gen_Wrap_51(System.Object P0, AkCallbackType P1, System.Object P2) { }
        private System.UInt32 __Gen_Wrap_52(System.UInt32 P0, System.UInt64 P1, Beyond.Audio.AudioCallbackType P2, System.Object P3, System.Object P4) { }
        private System.Void __Gen_Wrap_53(System.UInt32 P0, AkActionOnEventType P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_54(AkActionOnEventType P0, System.UInt32 P1, System.Int32 P2) { }
        private AkResourceMonitorDataSummary __Gen_Wrap_55() { }
        private Beyond.Audio.AudioMemoryMonitor.FGlobalMemoryStats __Gen_Wrap_56() { }
        private Beyond.Audio.AudioMemoryMonitor.FExtraMemoryStats __Gen_Wrap_57() { }
        private System.Void __Gen_Wrap_58(System.Boolean P0) { }
        private System.Void __Gen_Wrap_59(System.UInt64 P0, System.Single P1, System.Single P2) { }
        private System.Boolean __Gen_Wrap_60(System.UInt64 P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Boolean P5, System.Boolean P6) { }
        private System.Boolean __Gen_Wrap_61(System.UInt64 P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2, UnityEngine.Quaternion P3, System.UInt64 P4, System.Boolean P5) { }
        private System.Boolean __Gen_Wrap_62(System.UInt64 P0, Beyond.Audio.AudioRoomData P1, System.UInt64 P2, System.Object P3) { }
        private System.Boolean __Gen_Wrap_63(System.UInt64 P0, System.UInt64 P1, System.UInt64 P2, UnityEngine.Vector3 P3, UnityEngine.Quaternion P4, UnityEngine.Vector3 P5, System.Boolean P6, System.Object P7) { }
        private System.Boolean __Gen_Wrap_64(Beyond.Audio.AudioChannelMask& P0, System.UInt32& P1, Beyond.Audio.AudioChannelConfigType& P2) { }
        private System.Boolean __Gen_Wrap_65(System.Object P0, System.UInt32 P1, System.UInt32 P2, System.UInt32 P3, System.UInt64& P4) { }
        private System.Boolean __Gen_Wrap_66(System.Object P0, System.UInt32 P1, System.UInt64& P2) { }
        private System.UInt64 __Gen_Wrap_67(System.Object P0, System.UInt32 P1) { }
        private System.Boolean __Gen_Wrap_68(System.UInt64 P0) { }
        private System.Boolean __Gen_Wrap_69(System.Boolean P0) { }
        private System.Void __Gen_Wrap_70(System.UInt64 P0, System.UInt32 P1, System.UInt32 P2) { }
        private System.UInt32 __Gen_Wrap_71(System.Int32 P0) { }
        private Beyond.Audio.AsyncLoadBankTask __Gen_Wrap_72(System.Object P0) { }
        private Beyond.Audio.BankHandle __Gen_Wrap_73(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_74(System.Collections.Generic.List<System.UInt32>& P0) { }
        private System.String __Gen_Wrap_75(Beyond.Audio.AudioId& P0) { }
        private System.Int32 __Gen_Wrap_76(Beyond.Audio.AudioId P0) { }
        private Beyond.Audio.AudioId __Gen_Wrap_77(System.UInt32 P0) { }
        private Beyond.Audio.AudioId __Gen_Wrap_78(System.Int32 P0) { }
        private Beyond.Audio.AudioId __Gen_Wrap_79(System.Object P0) { }
        private System.UInt32[] __Gen_Wrap_80(System.Object P0) { }
        private System.Boolean __Gen_Wrap_81(Beyond.Audio.AudioState& P0, Beyond.Audio.AudioState P1) { }
        private System.Boolean __Gen_Wrap_82(Beyond.Audio.AudioState& P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_83(Beyond.Audio.AudioState& P0) { }
        private Beyond.Audio.AudioDurationCallbackInfo __Gen_Wrap_84(Beyond.Audio.AudioCallbackInfo& P0) { }
        private System.Void __Gen_Wrap_85(System.Object P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2, UnityEngine.Vector3 P3) { }
        private System.Boolean __Gen_Wrap_86(Beyond.Audio.AudioLogChannel P0) { }
        private System.Void __Gen_Wrap_87(Beyond.Audio.AudioLogChannel P0) { }
        private System.Void __Gen_Wrap_88(Beyond.Audio.AudioLogChannel P0, System.Object P1) { }
        private System.Single __Gen_Wrap_89(System.Single P0, System.Single P1, System.Single P2) { }
        private System.Single __Gen_Wrap_90(UnityEngine.Vector3 P0) { }
        private System.Void __Gen_Wrap_91(System.UInt32 P0) { }
        private System.Void __Gen_Wrap_92(System.Object P0, System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& P1) { }
        private System.Collections.Generic.LinkedList<Beyond.Audio.AudioAssetCache.EventCacheInfo> __Gen_Wrap_93(System.Object P0) { }
        private System.Void __Gen_Wrap_94(System.UInt64 P0, System.UInt16 P1) { }
        private System.Void __Gen_Wrap_95(System.UInt64 P0, System.Object P1) { }
        private System.String __Gen_Wrap_96(System.UInt32 P0) { }
        private System.UInt32 __Gen_Wrap_97(System.Object P0, System.Object P1) { }
        private System.UInt64 __Gen_Wrap_98(AkMemID P0) { }
        private System.Void __Gen_Wrap_99(Beyond.Audio.AudioUIUtil.UIAudioType P0) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000050
    public class ILFixInterfaceBridge : AnonymousStorey, IDisposable, IEnumerator, IEnumerator`1
    {
        // Fields
        private System.Int32 methodId_0;        // 0x40
        private System.Int32 methodId_1;        // 0x44
        private System.Int32 methodId_2;        // 0x48
        private System.Int32 methodId_3;        // 0x4C
        private System.Int32 methodId_4;        // 0x50

        // Methods
        private System.Void System.IDisposable.Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000051
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

    // TypeToken: 0x2000052
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_PostEventWithExternalSource0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-PostEventExternal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-PostEventExternal1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_DoLoadAndPinEventsSync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-LoadAndPinEventsSync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-LoadAndPinEventsSync1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_DoLoadAndPinEventsAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_LoadAndPinEventsAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioId-op_Implicit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync2;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-LoadAndPinEventsCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-LoadAndPinEventsCoroutine1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetSwitch0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetSwitch1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioHashGenerator-Compute0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetRtpc0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetRtpc1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetRtpc2;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioActionQueueHelper-QueueRtpcAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetRtpcValueByPlayingID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-ResetRtpc0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-ResetRtpc1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioActionQueueHelper-QueueSeekAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SeekOnEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SeekOnEvent1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SeekOnEvent2;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SeekOnEvent3;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-TryGetPlayingPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-IsPlaying0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-GetCachedAssetCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-Cache-RemoveFirst0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-GetLeastActiveAssetAndUncache0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-Cache-Remove0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-ActivateAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_TryDequeueAndInvokeCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_DoLoadEventAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_ConsumePendingLoadRequests0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_TryConsumePendingLoadRequests0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_DoGc0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-ReleaseAllCachedEventsSync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-ReleaseAllCachedEventsSync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioPositionArrayProxy-GetRawArray0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetLargePositions0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetDefaultListener0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetListener0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-TryGetRealPlayingId0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetDefaultEmitter0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-_GetVfsBlockTypeFromLanguage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-_UnloadPcks0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-_DoLoadSinglePckFromVfs0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-_DoLoadPcksFromVfs0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-_TryLoadPcksFromVfsInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-_DoLoadLanguagePck0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-TryLoadLanguagePck0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetAudioLanguage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetDistanceProbe0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetAudioEngineInitSetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-UnsetAudioEngineInitSetting0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-PayloadPostEvent-OnRecycle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-Context-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-Cache-Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-ResetStaticFields0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_ResetStaticFields0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_InitAndroidActivityEnvironment0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioCallbackMessageParser-Set0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioMemoryMonitor-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-Context-PostSoundEngineInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-VfsLoadedInfo-Create0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-InitBasePaths0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_InitInternal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-TryLoadInitPck0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-LoadInitResources0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-InitWwise0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioActionQueueHelper-ClearQueue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-HasPreparingEvents0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_OnBeforeTerminate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-GetAllUsingAssetsAndRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-UnPrepareAllEventsSync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioMemoryMonitor-Release0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_ReleaseInternal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-TermWwise0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-UnloadAll0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-ReloadInitResources0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-MemoryShrink0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_OnEventPreparedDoPostEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_OnEventCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_OnExternalSourceEventCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_PostEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioActionQueueHelper-QueueExecuteAction0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_ExecuteActionOnPlayingId0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_SampleAllData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-_SampleMemoryOnly0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-StartProfileCapture0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-StopProfileCapture0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-GetResourceSummaryData0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-GetGlobalMemoryStats0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-GetExtraMemoryStats0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetEnableSpatialAudio0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetObjectObstructionAndOcclusion0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetGeometry0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetGeometryInstance0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetRoom0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-SetPortal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-Device-GetSpeakerConfiguration0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-Device-AddOutputDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-Device-AddOutput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-Device-GetOutputDeviceId0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-Device-RemoveOutputDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-Device-Switch3DOutput0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-Device-SetOutputDeviceEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAdapter-Device-GetMmDeviceIdFromScePadHandle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-BankHandle-DecRef0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioBankManager-UnloadBank0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-BankHandle-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-BankHandle-IncRef0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AsyncLoadBankTask-LoadBanksAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AsyncLoadBankTask-MoveNext0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AsyncLoadBankTask-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AsyncLoadBankTask-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioVFSLoader-TryLoadMainPck0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioBankManager-LoadMainPCK0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioBankManager-_LoadBankCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioBankManager-LoadBankAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioBankManager-UnloadAllBanks0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioBankManager-IsBankLoaded0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioBankManager-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioBankManager-_PreResetBasePath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioBankManager-_PostResetBasePath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioBankManager-LoadDebugFilePackage0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioBankManager-AddDebugBankPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioId-GetName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioId-op_Implicit1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioId-op_Implicit2;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioId-op_Implicit3;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioId-op_Implicit4;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioIdExtensions-ToUIntArray0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioState-Equals0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioState-Equals1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioState-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioCallbackInfo-CastToDurationCallbackInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioPositionArrayProxy-Add0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioPositionArrayProxy-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioLogger-IsChannelEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioLogger-EnableChannel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioLogger-DisableChannel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioLogger-SetChannels0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioLogger-_DoLog0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioLogger-Log0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioLogger-_DoLogWarning0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioLogger-LogWarning0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioLogger-_DoLogError0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioLogger-LogError0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAcousticUtil-RT60DecayTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAcousticUtil-PreDelayTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAcousticUtil-CriticalDistance0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAcousticUtil-ReverbIntensity0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAcousticUtil-ErIntensity0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioActionQueueHelper-_ConsumeExecute0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioActionQueueHelper-_ConsumeRtpc0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioActionQueueHelper-_ConsumeSeek0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioActionQueueHelper-ConsumeQueue0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-PinEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-UnpinEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-Cache-AddLast0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-DeactivateAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-ForceReleaseCachedAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-_NotifyDebugger0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-_NotifyDebuggerCacheHit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-_ResetDebugger0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-_PinnedEventLeakDetect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetCache-Cache-get_lruCachedEventsList0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-SetMemoryBudget0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_OnUnpreparedDoUnloadBank0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_OnDoneUnloadBank0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_OnDonePrepareEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_OnBankLoadedDoPrepareEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_RemoveLoadingDebug0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_AddLoadingDebug0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioAssetHelper-_ClearLoadingDebug0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioDebugInfoContainer-SetAudioObjectName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioDebugInfoContainer-RemoveAudioObjectName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioDebugInfoContainer-ForceGetEventName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioDebugInfoContainer-ForceGetRtpcName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioHashGenerator-Compute1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioHashGenerator-Compute2;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioMemoryMonitor-GetGlobalMemoryStats0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioMemoryMonitor-GetExtraMemoryStats0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioMemoryMonitor-GetUsedMemoryByCategory0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioUIUtil-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioUIUtil-Release0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioUIUtil-PostUIEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioUIUtil-PostUIEvent1;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioUIUtil-OnUIPanelClose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Audio-AudioUIUtil-OnUIPanelOpen0;        // 0x0

    }

}

