// ========================================================
// Dumped by @desirepro
// Assembly: Audio.Beyond.dll
// Classes:  82
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Context
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  public    static  System.UInt64                   s_listenerObjId  // 0x0
  public    static  System.UInt64                   s_2dEmitterObjectId  // 0x8
  public    static  System.UInt32                   s_playingIdInternal  // 0x10
  public    static  System.Collections.Generic.Dictionary<System.UInt32,System.UInt32>s_playingIdLut  // 0x18
  public    static  Beyond.PoolCore.ObjectPool<Beyond.Audio.AudioAdapter.PayloadPostEvent>s_payloadPool  // 0x20
  public    static readonly AkExternalSourceInfoArray       S_EXTERNAL_SOURCE_INFO_ARRAY  // 0x28
  public    static  AkRoomParams                    s_reusableAkRoomParams  // 0x30
METHODS:
  System.Void PostSoundEngineInit()
  System.Void Reset()
  System.Void .cctor()
END_CLASS

CLASS: PayloadPostEvent
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  public            System.UInt64                   audioObjectId  // 0x10
  public            System.UInt32                   callbackType  // 0x18
  public            System.UInt32                   internalPlayingId  // 0x1C
  public            Beyond.Audio.AudioEventCallback callback  // 0x20
  public            System.Object                   cookie  // 0x28
METHODS:
  System.Void OnRecycle(Beyond.Audio.AudioAdapter.PayloadPostEvent obj)
  System.Void .ctor()
END_CLASS

CLASS: Device
TYPE:  class
TOKEN: 0x200000B
FIELDS:
METHODS:
  System.Boolean GetSpeakerConfiguration(Beyond.Audio.AudioChannelMask& channelMask, System.UInt32& numChannels, Beyond.Audio.AudioChannelConfigType& configType)
  System.Boolean AddOutputDevice(System.String deviceName, System.UInt32 deviceId, System.UInt32 numChannels, System.UInt32 speakerSetup, System.UInt64& outDeviceId)
  System.Boolean AddOutput(System.String shareSetName, System.UInt32 deviceId, System.UInt64& outId)
  System.UInt64 GetOutputDeviceId(System.String shareSetName, System.UInt32 deviceId)
  System.Boolean RemoveOutputDevice(System.UInt64 output)
  System.Boolean Switch3DOutput(System.Boolean use3DDevice)
  System.Void SetOutputDeviceEffect(System.UInt64 outputDeviceId, System.UInt32 effectIdx, System.UInt32 shareSetId)
  System.UInt32 GetMmDeviceIdFromScePadHandle(System.Int32 scePadHandle)
END_CLASS

CLASS: WarnType
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Audio.AudioEventWarnAttribute.WarnTypeNONE  // 0x0
  public    static  Beyond.Audio.AudioEventWarnAttribute.WarnTypeONE_SHOT  // 0x0
  public    static  Beyond.Audio.AudioEventWarnAttribute.WarnTypeLOOP  // 0x0
METHODS:
END_CLASS

CLASS: CallbackCookie
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  public            System.String                   bankName  // 0x10
  public            System.Action                   callback  // 0x18
  public            Beyond.Audio.BankHandle         handle  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: EBoolFlags
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  Beyond.Audio.AudioRoomData.EBoolFlagsNone  // 0x0
  public    static  Beyond.Audio.AudioRoomData.EBoolFlagsKeepRegistered  // 0x0
  public    static  Beyond.Audio.AudioRoomData.EBoolFlagsUseForReflectionAndDiffraction  // 0x0
  public    static  Beyond.Audio.AudioRoomData.EBoolFlagsAsReverbZone  // 0x0
METHODS:
END_CLASS

CLASS: FExecuteAction
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int32                    queuedFrame  // 0x10
  public            System.UInt32                   playingId  // 0x14
  public            AkActionOnEventType             actionType  // 0x18
  public            System.Int32                    durationMs  // 0x1C
METHODS:
END_CLASS

CLASS: FRTPCAction
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    queuedFrame  // 0x10
  public            System.UInt32                   playingId  // 0x14
  public            System.UInt32                   rtpcId  // 0x18
  public            System.Single                   targetValue  // 0x1C
  public            System.Int32                    durationMs  // 0x20
METHODS:
END_CLASS

CLASS: FSeekAction
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Int32                    queuedFrame  // 0x10
  public            System.Single                   queuedTime  // 0x14
  public            System.UInt32                   playingId  // 0x18
  public            System.UInt32                   eventId  // 0x1C
  public            System.UInt64                   audioObjectId  // 0x20
  public            System.Int32                    timeMs  // 0x28
  public            System.Boolean                  toNearestMarker  // 0x2C
METHODS:
END_CLASS

CLASS: EventCacheInfo
TYPE:  class
TOKEN: 0x2000038
FIELDS:
  public            System.UInt32                   id  // 0x10
  public            System.UInt32                   refCount  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cache
TYPE:  class
TOKEN: 0x2000039
FIELDS:
  private   readonly System.Collections.Generic.LinkedList<Beyond.Audio.AudioAssetCache.EventCacheInfo>m_lruCachedEventsList  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>>m_lruCachedEvents  // 0x18
METHODS:
  System.Collections.Generic.LinkedList<Beyond.Audio.AudioAssetCache.EventCacheInfo> get_lruCachedEventsList()
  System.Int32 get_count()
  System.Void Clear()
  System.UInt32 RemoveFirst(System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& outNode)
  System.Boolean Remove(System.UInt32 inId, System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& outNode)
  System.Void AddLast(System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& node)
  System.Void .ctor()
END_CLASS

CLASS: FOnBankLoadedDoPrepareEventPayload
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.UInt32                   id  // 0x10
  public            AkCallbackManager.BankCallback  callback  // 0x18
  public            System.Object                   cookie  // 0x20
METHODS:
END_CLASS

CLASS: FPendingLoadRequest
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            System.UInt32                   id  // 0x10
  public            Beyond.Audio.AudioAssetHelper.FOnBankLoadedDoPrepareEventPayloadpayload  // 0x18
METHODS:
END_CLASS

CLASS: FGlobalMemoryStats
TYPE:  struct
TOKEN: 0x2000042
FIELDS:
  public            System.UInt64                   used  // 0x10
  public            System.UInt64                   reserved  // 0x18
METHODS:
END_CLASS

CLASS: FExtraMemoryStats
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            System.UInt64                   active  // 0x10
  public            System.UInt64                   mapped  // 0x18
  public            System.UInt64                   retained  // 0x20
  public            System.UInt64                   allocated  // 0x28
METHODS:
END_CLASS

CLASS: UIAudioType
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Audio.AudioUIUtil.UIAudioTypeNone  // 0x0
  public    static  Beyond.Audio.AudioUIUtil.UIAudioTypeFullScreen  // 0x0
  public    static  Beyond.Audio.AudioUIUtil.UIAudioTypeTips  // 0x0
METHODS:
END_CLASS

CLASS: VfsLoadedInfo
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public            System.Collections.Generic.List<System.UInt32>loadedPcks  // 0x10
  public            System.Int32                    loadedVersion  // 0x18
  public            System.Boolean                  isLoaded  // 0x1C
METHODS:
  Beyond.Audio.AudioVFSLoader.VfsLoadedInfo Create()
END_CLASS

CLASS: AudioWwiseProfilingData
TYPE:  class
TOKEN: 0x200004A
FIELDS:
  public    static readonly Unity.Profiling.ProfilerCounterValue<System.Single>CPU  // 0x0
  public    static readonly Unity.Profiling.ProfilerCounterValue<System.Single>PLUGIN_CPU  // 0x1
  public    static readonly Unity.Profiling.ProfilerCounterValue<System.Int32>ACTIVE_EVENTS  // 0x2
  public    static readonly Unity.Profiling.ProfilerCounterValue<System.Int32>TOTAL_VOICES  // 0x3
  public    static readonly Unity.Profiling.ProfilerCounterValue<System.Int32>PHYS_VOICES  // 0x4
  public    static readonly Unity.Profiling.ProfilerCounterValue<System.Int32>VIR_VOPICES  // 0x5
  public    static readonly Unity.Profiling.ProfilerCounterValue<System.UInt64>TOTAL_MEM  // 0x6
  public    static readonly Unity.Profiling.ProfilerCounterValue<System.UInt64>RESERVED_MEM  // 0x7
  public    static readonly Unity.Profiling.ProfilerCounterValue<System.Single>CACHE_HIT_RATE  // 0x8
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: __StaticArrayInitTypeSize=12
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioAdapter
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private   static readonly AkCallbackManager.BankCallback  ON_EVENT_PREPARED_DO_POST_EVENT  // 0x0
  private   static readonly AkCallbackManager.EventCallback ON_EVENT_CALLBACK  // 0x8
  private   static readonly AkCallbackManager.EventCallback ON_EXTERNAL_SOURCE_EVENT_CALLBACK  // 0x10
METHODS:
  System.UInt64 get_listenerObjId()
  System.UInt32 PostEvent(System.String eventName)
  System.UInt32 PostEvent(System.UInt32 eventId)
  System.UInt32 PostEvent(System.String eventName, System.UInt64 audioObjectId)
  System.UInt32 PostEvent(System.UInt32 eventId, System.UInt64 audioObjectId)
  System.UInt32 PostEvent(System.String eventName, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie)
  System.UInt32 PostEvent(System.UInt32 eventId, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie)
  System.UInt32 PostEvent(System.String eventName, System.UInt64 audioObjectId, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie)
  System.UInt32 PostEvent(System.UInt32 eventId, System.UInt64 audioObjectId, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie)
  System.UInt32 PostEventExternal(System.String eventName, System.UInt64 audioObjectId, System.String externalSourceKey, System.UInt32 externalCookie, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie, Beyond.Audio.AudioCodec codec)
  System.UInt32 PostEventExternal(System.UInt32 eventId, System.UInt64 audioObjectId, System.String externalSourceKey, System.UInt32 externalCookie, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie, Beyond.Audio.AudioCodec codec)
  System.Void StopByPlayingId(System.UInt32 playingId, System.Int32 fadeTimeMs)
  System.Void PauseByPlayingId(System.UInt32 playingId, System.Int32 fadeTimeMs)
  System.Void ResumeByPlayingId(System.UInt32 playingId, System.Int32 fadeTimeMs)
  System.Void PinEvent(System.UInt32 eventId)
  System.Void UnpinEvent(System.UInt32 eventId)
  System.Void UnpinEvent(System.String eventName)
  System.Void LoadAndPinEventsSync(System.Collections.Generic.IList<System.UInt32> events)
  System.Void LoadAndPinEventsSync(System.Collections.Generic.ICollection<System.String> events)
  System.Void LoadAndPinEventsAsync(System.Collections.Generic.IList<System.UInt32> events, System.Action<System.Object> onDone, System.Object payload)
  System.Void LoadAndPinEventsAsync(System.Collections.Generic.IList<Beyond.Audio.AudioId> events, System.Action<System.Object> onDone, System.Object payload)
  System.Void LoadAndPinEventsAsync(System.Collections.Generic.ICollection<System.String> events, System.Action<System.Object> onDone, System.Object payload)
  System.Collections.IEnumerator LoadAndPinEventsCoroutine(System.Collections.Generic.IList<System.UInt32> events)
  System.Collections.IEnumerator LoadAndPinEventsCoroutine(System.Collections.Generic.ICollection<System.String> events)
  System.Void SetState(System.String stateGroup, System.String stateName)
  System.Void SetState(System.UInt32 stateGroup, System.UInt32 stateName)
  System.Boolean TryGetState(System.UInt32 stateGroupId, System.UInt32& stateId)
  System.Void SetSwitch(System.UInt32 switchGroup, System.UInt32 switchValue, System.UInt64 audioObjectId)
  System.Void SetSwitch(System.String switchGroup, System.String switchValue, System.UInt64 audioObjectId)
  System.Void SetRtpc(System.String rtpcName, System.Single rtpcValue, System.UInt64 audioObjectId)
  System.Void SetRtpc(System.UInt32 rtpcId, System.Single rtpcValue, System.UInt64 audioObjectId)
  System.Void SetRtpc(System.UInt32 rtpcId, System.Single rtpcValue, System.UInt64 audioObjectId, System.Int32 fadeTimeMs)
  System.Void SetRtpcValueByPlayingID(System.UInt32 rtpcId, System.Single rtpcValue, System.UInt32 playingId, System.Int32 fadeTimeMs)
  System.Void ResetRtpc(System.UInt32 rtpcId, System.UInt64 audioObjectId, System.Int32 fadeTimeMs)
  System.Void ResetRtpc(System.String rtpcName, System.UInt64 audioObjectId, System.Int32 fadeTimeMs)
  System.Boolean GetRtpcValue(System.String rtpcName, System.UInt64 audioObjectId, System.UInt32 playingId, System.Single& value, System.Int32& valueType)
  System.Boolean GetRtpcValue(System.UInt32 rtpcId, System.UInt64 audioObjectId, System.UInt32 playingId, System.Single& value, System.Int32& valueType)
  System.Void SeekOnEvent(System.String eventName, System.UInt64 audioObjectId, System.Int32 timeMs, System.Boolean toNearestMarker, System.UInt32 playingId)
  System.Void SeekOnEvent(System.UInt32 eventId, System.UInt64 audioObjectId, System.Int32 timeMs, System.Boolean toNearestMarker, System.UInt32 playingId)
  System.Void SeekOnEvent(System.String eventName, System.Int32 timeMs, System.Boolean toNearestMarker, System.UInt32 playingId)
  System.Void SeekOnEvent(System.UInt32 eventId, System.Int32 timeMs, System.Boolean toNearestMarker, System.UInt32 playingId)
  System.Boolean TryGetPlayingPosition(System.UInt32 playingId, System.Int32& posTimeMs, System.Boolean extrapolate)
  System.Boolean IsPlaying(System.UInt32 playingId)
  System.UInt32 SetScalingFactor(System.UInt64 audioObjectId, System.Single factor)
  System.Boolean RegisterGameObject(System.UInt64 audioObjectId)
  System.Boolean RegisterGameObject(System.UInt64 audioObjectId, System.String name)
  System.Boolean UnregisterGameObject(System.UInt64 audioObjectId)
  System.Void SetPosition(System.UInt64 audioObjectId, UnityEngine.Vector3 pos, UnityEngine.Vector3 forward, UnityEngine.Vector3 up)
  System.Void StopAll()
  System.Void StopAllOnObject(System.UInt64 audioObjectId)
  System.Void ReleaseAllCachedEventsSync()
  System.Void SetLargePositions(System.UInt64 audioObjectId, Beyond.Audio.AudioPositionArrayProxy positions, Beyond.Audio.AudioLargeType type)
  System.Void SetDefaultListener(System.UInt64 audioObjectId)
  System.Void SetListener(System.UInt64 audioObjectId, System.UInt64 listenerId)
  System.Boolean TryGetRealPlayingId(System.UInt32 playingId, System.UInt32& realPlayingId)
  System.Void SetDefaultEmitter(System.UInt64 audioObjectId)
  System.Void SetAudioLanguage(System.String language)
  System.Void SetDistanceProbe(System.UInt64 probeObjectId)
  System.UInt32 ComputeIdFromString(System.String name)
  System.Void SetAudioEngineInitSetting(Beyond.Audio.AudioEngineInitSetting settings)
  System.Void UnsetAudioEngineInitSetting()
  System.Boolean InitWwise()
  System.Void TermWwise()
  System.Void LoadInitResources()
  System.Void ReloadInitResources()
  System.Void RenderAudio()
  System.Void Suspend(System.Boolean renderAnyway)
  System.Void WakeupFromSuspend()
  System.Void InitScePad()
  System.Void SetAudioMemoryBudget(System.UInt64 inMemoryBytes, System.UInt16 inGcCount)
  System.Void LogToWwise(System.String msg, System.Boolean isError, System.UInt32 playingId, System.UInt64 goId)
  System.Void MemoryShrink()
  System.Boolean _InitInternal()
  System.Void _ReleaseInternal()
  System.Void _OnBeforeTerminate()
  System.Void _ResetStaticFields()
  System.Void _OnEventPreparedDoPostEvent(System.UInt32 inId, System.IntPtr _, AKRESULT __, System.Object inCookie)
  System.Void _OnEventCallback(System.Object inCookie, AkCallbackType inType, AkCallbackInfo inInfo)
  System.Void _OnExternalSourceEventCallback(System.Object inCookie, AkCallbackType inType, AkCallbackInfo inInfo)
  System.UInt32 _PostEvent(System.UInt32 eventId, System.UInt64 audioObjectId, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback originCallback, System.Object originCookie)
  System.UInt32 _PostEventWithExternalSource(System.UInt32 eventId, System.UInt64 audioObjectId, System.String externalSourceKey, System.UInt32 externalCookie, Beyond.Audio.AudioCallbackType callbackType, Beyond.Audio.AudioEventCallback callback, System.Object cookie, Beyond.Audio.AudioCodec codec)
  System.Void _ExecuteActionOnPlayingId(AkActionOnEventType type, System.UInt32 playingId, System.Int32 durationMs)
  System.UInt32 _GetInternalPlayingId()
  System.Void _LoadAndPinEventsAsync(System.Collections.Generic.IList<System.UInt32>& events, System.Action<System.Object>& onDone, System.Object& payload)
  System.Void _DoLoadAndPinEventsSync(System.Collections.Generic.IList<System.UInt32> events)
  System.Collections.IEnumerator _DoLoadAndPinEventsAsync(System.Collections.Generic.IList<System.UInt32> events, System.Action<System.Object> onDone, System.Object payload)
  System.Void _InitAndroidActivityEnvironment()
  System.Void SetUprSamplingEnabled(System.Boolean isEnabled)
  System.Void _ProfilerUpdate()
  System.Void _SampleAllData()
  System.Void _SampleMemoryOnly()
  System.Void StartProfileCapture(System.String fileName)
  System.Void StopProfileCapture()
  AkResourceMonitorDataSummary GetResourceSummaryData()
  Beyond.Audio.AudioMemoryMonitor.FGlobalMemoryStats GetGlobalMemoryStats()
  Beyond.Audio.AudioMemoryMonitor.FExtraMemoryStats GetExtraMemoryStats()
  System.Void SetEnableSpatialAudio(System.Boolean enable)
  System.Void SetObjectObstructionAndOcclusion(System.UInt64 audioObjectId, System.Single obstructionLevel, System.Single occlusionLevel)
  System.Boolean SetGeometry(System.UInt64 geoId, UnityEngine.Vector3[] vertices, System.UInt16[] triangles, Beyond.Audio.AudioAcousticSurfaceData[] surfaceData, System.UInt16[] surfaceIdx, System.Boolean enableDiffraction, System.Boolean enableEdgeDiffraction)
  System.Boolean SetGeometryInstance(System.UInt64 instanceId, UnityEngine.Vector3 pos, UnityEngine.Vector3 scale, UnityEngine.Quaternion rot, System.UInt64 geoId, System.Boolean useReflectionAndDiffraction)
  System.Boolean SetRoom(System.UInt64 roomId, Beyond.Audio.AudioRoomData roomData, System.UInt64 geoInstanceId, System.String roomName)
  System.Boolean SetPortal(System.UInt64 portalId, System.UInt64 roomIdA, System.UInt64 roomIdB, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 extent, System.Boolean enabled, System.String portalName)
  System.Boolean SetPortalObstructionAndOcclusion(System.UInt64 portalId, System.Single obstruction, System.Single occlusion)
  System.Boolean SetReverbZone(System.UInt64 reverbZoneId, System.UInt64 parentRoom, System.Single transitionWidth)
  System.Boolean RemoveRoom(System.UInt64 roomId)
  System.Boolean RemovePortal(System.UInt64 portalId)
  System.Boolean RemoveGeometry(System.UInt64 geoId)
  System.Boolean RemoveGeometryInstance(System.UInt64 instanceId)
  System.Boolean RemoveReverbZone(System.UInt64 reverbZoneId)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Audio.AudioEventCallback
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object in_cookie, Beyond.Audio.AudioCallbackType in_type, Beyond.Audio.AudioCallbackInfo in_info)
  System.IAsyncResult BeginInvoke(System.Object in_cookie, Beyond.Audio.AudioCallbackType in_type, Beyond.Audio.AudioCallbackInfo in_info, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Beyond.Audio.AudioStringAttribute
TYPE:  class
TOKEN: 0x2000011
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Audio.AudioVectorAttribute
TYPE:  class
TOKEN: 0x2000012
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Audio.AudioEventWarnAttribute
TYPE:  class
TOKEN: 0x2000013
EXTENDS: PropertyAttribute
FIELDS:
  public            Beyond.Audio.AudioEventWarnAttribute.WarnTypewarnType  // 0x10
METHODS:
  System.Void .ctor(Beyond.Audio.AudioEventWarnAttribute.WarnType type)
END_CLASS

CLASS: Beyond.Audio.BankHandle
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private   readonly System.String                   <name>k__BackingField  // 0x10
  private           AKRESULT                        <result>k__BackingField  // 0x18
  private           System.Boolean                  <isDone>k__BackingField  // 0x1C
  private           System.Int32                    m_refCount  // 0x20
METHODS:
  System.String get_name()
  AKRESULT get_result()
  System.Void set_result(AKRESULT value)
  System.Boolean get_isDone()
  System.Void set_isDone(System.Boolean value)
  System.Int32 get_refCount()
  System.Void .ctor(System.String bankName)
  System.Void Dispose()
  System.Void IncRef()
  System.Void DecRef()
END_CLASS

CLASS: Beyond.Audio.AsyncLoadBankTask
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private   readonly System.Collections.Generic.List<Beyond.Audio.BankHandle>m_handles  // 0x10
METHODS:
  Beyond.Audio.AsyncLoadBankTask LoadBanksAsync(System.Collections.Generic.IList<System.String> bankNames)
  System.Void .ctor(System.Collections.Generic.IList<System.String> bankNames)
  System.Boolean MoveNext()
  System.Void Reset()
  System.Object get_Current()
  System.Void Dispose()
END_CLASS

CLASS: Beyond.Audio.AudioBankManager
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,Beyond.Audio.BankHandle>s_loadedBankHandles  // 0x0
METHODS:
  System.Void LoadMainPCK()
  Beyond.Audio.BankHandle LoadBankAsync(System.String bankName, System.Action callback)
  System.Void _LoadBankCallback(System.UInt32 inBankId, System.IntPtr _, AKRESULT inLoadResult, System.Object inCookie)
  System.Boolean UnloadBank(System.String bankName)
  System.Void UnloadAllBanks()
  System.Boolean IsBankLoaded(System.String bankName)
  System.Void Reset()
  System.Void LoadDebugFilePackage(System.String path)
  System.Void AddDebugBankPath(System.String path)
  System.Void _PreResetBasePath(System.Collections.Generic.List<System.UInt32>& unPinnedEventIds)
  System.Void _PostResetBasePath(System.Collections.Generic.List<System.UInt32> unPinnedEventIds)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Audio.AudioConstants
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  public    static  System.UInt64                   AUDIO_INVALID_GAME_OBJECT  // 0x0
  public    static  System.UInt32                   AUDIO_INVALID_UNIQUE_ID  // 0x0
  public    static  System.UInt32                   AUDIO_INVALID_INTERNAL_PLAYING_ID  // 0x0
  public    static  System.UInt64                   AUDIO_GLOBAL_GAME_OBJECT  // 0x0
  public    static  System.UInt64                   AUDIO_ROOM_OUTDOOR_ID  // 0x0
  public    static  System.UInt64                   AUDIO_ROOM_OUTDOORS_ID  // 0x0
  public    static  System.String                   AU_UI_BATTLE_BREAK_POISE  // 0x0
  public    static  System.String                   AU_GLOBAL_GAIN_ON  // 0x0
  public    static  System.String                   AU_GLOBAL_GAIN_OFF  // 0x0
  public    static  System.UInt32                   AU_HASH_EXTERNAL_SOURCE_COOKIE  // 0x0
  public    static  System.UInt32                   AU_BANK_INIT  // 0x0
  public    static  System.String                   AU_DEVICE_CONTROLLER_SPEAKER  // 0x0
  public    static  System.Int32                    AUDIO_SPEAKER_SETUP_4_0  // 0x0
  public    static  System.String                   AU_DEVICE_WWISE_MOTION  // 0x0
  public    static  System.String                   AU_DEVICE_SYSTEM  // 0x0
  public    static  System.String                   AU_DEVICE_SYSTEM_3D  // 0x0
  public    static  System.UInt32                   AUDIO_UI_FULLSCREEN_OPEN  // 0x0
  public    static  System.UInt32                   AUDIO_UI_FULLSCREEN_CLOSE  // 0x0
  public    static  System.UInt32                   AUDIO_UI_FULLSCREEN_PAUSE  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Audio.AudioId
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    _id  // 0x10
METHODS:
  System.Void .ctor(System.UInt32 id)
  System.String GetName()
  System.UInt32 op_Implicit(Beyond.Audio.AudioId id)
  System.Int32 op_Implicit(Beyond.Audio.AudioId id)
  Beyond.Audio.AudioId op_Implicit(System.UInt32 id)
  Beyond.Audio.AudioId op_Implicit(System.Int32 id)
  Beyond.Audio.AudioId op_Implicit(System.String id)
END_CLASS

CLASS: Beyond.Audio.AudioIdExtensions
TYPE:  class
TOKEN: 0x200001B
FIELDS:
METHODS:
  System.UInt32[] ToUIntArray(System.Collections.Generic.ICollection<Beyond.Audio.AudioId> ids)
END_CLASS

CLASS: Beyond.Audio.AudioState
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  private           System.Int32                    _stateGroup  // 0x10
  private           System.Int32                    _stateValue  // 0x14
METHODS:
  System.UInt32 get_stateGroup()
  System.UInt32 get_stateValue()
  System.Void .ctor(System.UInt32 stateGroup, System.UInt32 stateValue)
  System.Boolean Equals(Beyond.Audio.AudioState other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean <>iFixBaseProxy_Equals(System.Object P0)
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: Beyond.Audio.AudioIdList
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            Beyond.Audio.AudioId[]          _ids  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioStateList
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            Beyond.Audio.AudioState[]       _states  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioEngineInitSetting
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            AkWwiseInitializationSettings   akInitSettings  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioLargeSource
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Quaternion          rotation  // 0x1C
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioCallbackInfo
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.UInt64                   objectId  // 0x10
  public            System.IntPtr                   pCookie  // 0x18
  private           AkCallbackInfo                  rawInfo  // 0x20
METHODS:
  Beyond.Audio.AudioDurationCallbackInfo CastToDurationCallbackInfo()
END_CLASS

CLASS: Beyond.Audio.AudioDurationCallbackInfo
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  public            System.Single                   duration  // 0x10
  public            System.Single                   estimatedDuration  // 0x14
  public            System.UInt32                   audioNodeId  // 0x18
  public            System.UInt32                   mediaId  // 0x1C
  public            System.Boolean                  isStreaming  // 0x20
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioPositionArrayProxy
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  private           AkPositionArray                 m_array  // 0x10
METHODS:
  System.UInt32 get_count()
  System.Void .ctor(System.UInt32 count)
  AkPositionArray GetRawArray()
  System.Void Add(UnityEngine.Vector3 position, UnityEngine.Vector3 forward, UnityEngine.Vector3 up)
  System.Void Reset()
  System.Void Finalize()
END_CLASS

CLASS: Beyond.Audio.AudioAcousticSurfaceData
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  public            System.UInt32                   textureId  // 0x10
  public            System.Single                   transmissionLoss  // 0x14
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioRoomData
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.UInt32                   roomToneId  // 0x10
  public            System.UInt32                   priority  // 0x14
  public            System.UInt32                   auxBusId  // 0x18
  public            System.UInt32                   parentRoomId  // 0x1C
  public            System.Single                   auxLevel  // 0x20
  public            System.Single                   auxLevelToSelf  // 0x24
  public            System.Single                   transmissionLoss  // 0x28
  public            System.Single                   transitionWidth  // 0x2C
  public            System.Single                   t60DecayTIme  // 0x30
  public            System.Single                   preDelayTime  // 0x34
  public            System.Single                   reverbLevel  // 0x38
  public            System.Single                   erLevel  // 0x3C
  public            Beyond.Audio.AudioRoomData.EBoolFlagsflags  // 0x40
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioCallbackType
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Audio.AudioCallbackType  None  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_EndOfEvent  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_EndOfDynamicSequenceItem  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_Marker  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_Duration  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_SpeakerVolumeMatrix  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_Starvation  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_MusicPlaylistSelect  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_MusicPlayStarted  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_MusicSyncBeat  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_MusicSyncBar  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_MusicSyncEntry  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_MusicSyncExit  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_MusicSyncGrid  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_MusicSyncUserCue  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_MusicSyncPoint  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_MusicSyncAll  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_MIDIEvent  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_CallbackBits  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_EnableGetSourcePlayPosition  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_EnableGetMusicPlayPosition  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_EnableGetSourceStreamBuffering  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_Monitoring  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_Bank  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_AudioInterruption  // 0x0
  public    static  Beyond.Audio.AudioCallbackType  AU_AudioSourceChange  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioLargeType
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Audio.AudioLargeType     Sum  // 0x0
  public    static  Beyond.Audio.AudioLargeType     Nearest  // 0x0
  public    static  Beyond.Audio.AudioLargeType     Single  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioPlayableActions
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Audio.AudioPlayableActionsNone  // 0x0
  public    static  Beyond.Audio.AudioPlayableActionsPlayback  // 0x0
  public    static  Beyond.Audio.AudioPlayableActionsStop  // 0x0
  public    static  Beyond.Audio.AudioPlayableActionsSeek  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioEventType
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Audio.AudioEventType     Sfx  // 0x0
  public    static  Beyond.Audio.AudioEventType     Music  // 0x0
  public    static  Beyond.Audio.AudioEventType     State  // 0x0
  public    static  Beyond.Audio.AudioEventType     GameSync  // 0x0
  public    static  Beyond.Audio.AudioEventType     Voice  // 0x0
  public    static  Beyond.Audio.AudioEventType     Controller  // 0x0
  public    static  Beyond.Audio.AudioEventType     Vibration  // 0x0
  public    static  Beyond.Audio.AudioEventType     Global  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioMixDownMode
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Audio.AudioMixDownMode   Direct  // 0x0
  public    static  Beyond.Audio.AudioMixDownMode   ForceToMono  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioMasteringSuiteMode
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Audio.AudioMasteringSuiteModeHeadphone  // 0x0
  public    static  Beyond.Audio.AudioMasteringSuiteModeTV  // 0x0
  public    static  Beyond.Audio.AudioMasteringSuiteModeHomeCinema  // 0x0
  public    static  Beyond.Audio.AudioMasteringSuiteModeSoundBar  // 0x0
  public    static  Beyond.Audio.AudioMasteringSuiteModeSpeaker  // 0x0
  public    static  Beyond.Audio.AudioMasteringSuiteModeDevMode  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioChannelConfigType
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  Beyond.Audio.AudioChannelConfigTypeAnonymous  // 0x0
  public    static  Beyond.Audio.AudioChannelConfigTypeStandard  // 0x0
  public    static  Beyond.Audio.AudioChannelConfigTypeAmbisonic  // 0x0
  public    static  Beyond.Audio.AudioChannelConfigTypeObjects  // 0x0
  public    static  Beyond.Audio.AudioChannelConfigTypeUseDeviceMain  // 0x0
  public    static  Beyond.Audio.AudioChannelConfigTypeUseDevicePassthrough  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioCodec
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  Beyond.Audio.AudioCodec         PCM  // 0x0
  public    static  Beyond.Audio.AudioCodec         ADPCM  // 0x0
  public    static  Beyond.Audio.AudioCodec         VORBIS  // 0x0
  public    static  Beyond.Audio.AudioCodec         ATRAC9  // 0x0
  public    static  Beyond.Audio.AudioCodec         OPUS_WEM  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioChannelMask
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  Beyond.Audio.AudioChannelMask   NONE  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   FRONT_LEFT  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   FRONT_RIGHT  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   FRONT_CENTER  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   LOW_FREQUENCY  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   BACK_LEFT  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   BACK_RIGHT  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   BACK_CENTER  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SIDE_LEFT  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SIDE_RIGHT  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   TOP  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   HEIGHT_FRONT_LEFT  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   HEIGHT_FRONT_CENTER  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   HEIGHT_FRONT_RIGHT  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   HEIGHT_BACK_LEFT  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   HEIGHT_BACK_CENTER  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   HEIGHT_BACK_RIGHT  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_MONO  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_0POINT1  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_1POINT1  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_STEREO  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_2POINT1  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_3STEREO  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_3POINT1  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_4  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_4POINT1  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_5  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_5POINT1  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_6  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_6POINT1  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_7  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_7POINT1  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_SURROUND  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_DPL2  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_HEIGHT_4  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_HEIGHT_5  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_HEIGHT_ALL  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_222  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_8  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_9  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_9POINT1  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_10  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_10POINT1  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_11  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_11POINT1  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_11_740  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_11POINT1_740  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_13_751  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_AURO_13POINT1_751  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_DOLBY_5_0_2  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_DOLBY_5_1_2  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_DOLBY_6_0_2  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_DOLBY_6_1_2  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_DOLBY_6_0_4  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_DOLBY_6_1_4  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_DOLBY_7_0_2  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_DOLBY_7_1_2  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_DOLBY_7_0_4  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_DOLBY_7_1_4  // 0x0
  public    static  Beyond.Audio.AudioChannelMask   SETUP_ALL_SPEAKERS  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioLogChannel
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Audio.AudioLogChannel    NONE  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    API  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    IO  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    OBJECT  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    MUSIC  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    SPATIAL  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    SCENE  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    VOICE  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    GAMEPLAY  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    GP_STATE  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    GP_CUE  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    GP_FACTORY  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    GP_UI  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    GP_ANIM  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    MOTION  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    WWISE  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    EDITOR  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    MISC  // 0x0
  public    static  Beyond.Audio.AudioLogChannel    ALL  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Audio.AudioLogger
TYPE:  class
TOKEN: 0x2000031
FIELDS:
  public    static  Beyond.Audio.AudioLogChannel    s_enabledChannels  // 0x0
METHODS:
  System.Boolean IsChannelEnabled(Beyond.Audio.AudioLogChannel channel)
  System.Void EnableChannel(Beyond.Audio.AudioLogChannel channel)
  System.Void DisableChannel(Beyond.Audio.AudioLogChannel channel)
  System.Void SetChannels(Beyond.Audio.AudioLogChannel channel)
  System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg)
  System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1)
  System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2)
  System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3)
  System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void Log(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5)
  System.Void LogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg)
  System.Void LogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1)
  System.Void LogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2)
  System.Void LogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3)
  System.Void LogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogError(Beyond.Audio.AudioLogChannel channel, System.String msg)
  System.Void LogError(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1)
  System.Void LogError(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2)
  System.Void LogError(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3)
  System.Void LogError(Beyond.Audio.AudioLogChannel channel, System.String msg, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void _DoLog(Beyond.Audio.AudioLogChannel channel, System.String msg)
  System.Void _DoLogWarning(Beyond.Audio.AudioLogChannel channel, System.String msg)
  System.Void _DoLogError(Beyond.Audio.AudioLogChannel channel, System.String msg)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Audio.AudioAcousticUtil
TYPE:  class
TOKEN: 0x2000032
FIELDS:
  private   static  System.Single                   SOUND_SPEED  // 0x0
METHODS:
  System.Single RT60DecayTime(System.Single volume, System.Single surfaceArea, System.Single absorptionFactor)
  System.Single PreDelayTime(UnityEngine.Vector3 size)
  System.Single CriticalDistance(System.Single volume, System.Single rt60, System.Single gamma)
  System.Single ReverbIntensity(UnityEngine.Vector3 size)
  System.Single ErIntensity(UnityEngine.Vector3 size)
END_CLASS

CLASS: Beyond.Audio.AudioActionQueueHelper
TYPE:  class
TOKEN: 0x2000033
FIELDS:
  private   static  System.Collections.Generic.Queue<Beyond.Audio.AudioActionQueueHelper.FExecuteAction>s_executeActionQueue  // 0x0
  private   static  System.Collections.Generic.Queue<Beyond.Audio.AudioActionQueueHelper.FRTPCAction>s_rtpcActionQueue  // 0x8
  private   static  System.Collections.Generic.Queue<Beyond.Audio.AudioActionQueueHelper.FSeekAction>s_seekActionQueue  // 0x10
  private   static  System.Int32                    QUEUE_LIFETIME_FRAME  // 0x0
METHODS:
  System.Void QueueExecuteAction(System.UInt32 playingId, AkActionOnEventType actionType, System.Int32 durationMs)
  System.Void QueueRtpcAction(System.UInt32 playingId, System.UInt32 rtpcId, System.Single targetValue, System.Int32 durationMs)
  System.Void QueueSeekAction(System.UInt32 playingId, System.UInt32 eventId, System.UInt64 audioObjectId, System.Int32 timeMs, System.Boolean toNearestMarker)
  System.Void ConsumeQueue()
  System.Void ClearQueue()
  System.Void _ConsumeExecute(System.Int32 currFrame)
  System.Void _ConsumeRtpc(System.Int32 currFrame)
  System.Void _ConsumeSeek(System.Int32 currFrame)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Audio.AudioAssetCache
TYPE:  class
TOKEN: 0x2000037
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>>s_lruUsingEvents  // 0x0
  private   static  Beyond.Audio.AudioAssetCache.Caches_cachedEvents  // 0x8
  private   static  System.Collections.Generic.HashSet<System.UInt32>s_pinnedEvents  // 0x10
  private   static  System.Int32                    INIT_PREPARE_CAP  // 0x0
  private   static  Beyond.PoolCore.ObjectPool<System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>>s_nodePool  // 0x18
METHODS:
  System.Void Reset()
  System.Void PinEvent(System.UInt32 inId)
  System.Void UnpinEvent(System.UInt32 inId)
  System.Void GetAllUsingAssetsAndRelease(System.Collections.Generic.List<System.UInt32>& allIds)
  System.UInt32 GetLeastActiveAssetAndUncache()
  System.Int32 GetCachedAssetCount()
  System.Boolean ActivateAsset(System.UInt32 inId)
  System.Void DeactivateAsset(System.UInt32 inId)
  System.Void ForceReleaseCachedAsset(System.UInt32 inId)
  System.Void _NotifyDebugger()
  System.Void _NotifyDebuggerCacheHit(System.Boolean isHit)
  System.Void _ResetDebugger()
  System.Void _PinnedEventLeakDetect()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Audio.AudioAssetHelper
TYPE:  class
TOKEN: 0x200003B
FIELDS:
  private   static  System.UInt64                   s_memoryBudget  // 0x0
  private   static  System.Single                   FACTOR_B_TO_MB  // 0x0
  private   static  System.UInt16                   s_gcCount  // 0x8
  private   static  System.Int32                    s_gcPendingCount  // 0xC
  private   static  System.Collections.Generic.Queue<Beyond.Audio.AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload>s_waitingCallbacks  // 0x10
  private   static  System.Collections.Generic.Queue<Beyond.Audio.AudioAssetHelper.FPendingLoadRequest>s_pendingLoadRequests  // 0x18
  private   static  System.Collections.Generic.HashSet<System.UInt32>s_solidLoadedEvents  // 0x20
  private   static readonly System.UInt32[]                 S_REUSABLE_UINT_ARRAY  // 0x28
  private   static readonly AkCallbackManager.BankCallback  ON_UNPREPARED_DO_UNLOAD_BANK  // 0x30
  private   static readonly AkCallbackManager.BankCallback  ON_DONE_UNLOAD_BANK  // 0x38
  private   static readonly AkCallbackManager.BankCallback  ON_BANK_LOADED_DO_PREPARE_EVENT  // 0x40
  private   static readonly AkCallbackManager.BankCallback  ON_DONE_PREPARE_EVENT  // 0x48
METHODS:
  System.Boolean get_isGcProcessing()
  System.Void SetMemoryBudget(System.UInt64 inBudgetBytes, System.UInt16 inGcCount)
  System.Boolean HasPreparingEvents()
  System.Void UnPrepareAllEventsSync()
  System.Void LoadEventAsync(System.UInt32 inId, AkCallbackManager.BankCallback callback, System.Object cookie)
  System.Void _TryConsumePendingLoadRequests()
  System.Void _ConsumePendingLoadRequests()
  System.Void _DoLoadEventAsync(System.UInt32 inId, Beyond.Audio.AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload payload)
  System.Void PinEvent(System.UInt32 inId)
  System.Void UnpinEvent(System.UInt32 inId)
  System.Void ResetStaticFields()
  System.Void ReleaseAllCachedEventsSync()
  System.Void _TryGC()
  System.Void _DoGc(System.Int32 gcCount)
  System.Void UnloadEvent(System.UInt32 inId)
  System.Void _OnUnpreparedDoUnloadBank(System.UInt32 inId, System.IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, System.Object inCookie)
  System.Void _OnDoneUnloadBank(System.UInt32 inId, System.IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, System.Object inCookie)
  System.Void _OnBankLoadedDoPrepareEvent(System.UInt32 inId, System.IntPtr _, AKRESULT inLoadResult, System.Object __)
  System.Void _OnDonePrepareEvent(System.UInt32 inId, System.IntPtr _, AKRESULT __, System.Object ___)
  System.Void _TryDequeueAndInvokeCallback()
  System.Void _RemoveLoadingDebug(System.UInt32 inId)
  System.Void _AddLoadingDebug(System.UInt32 inId)
  System.Void _ClearLoadingDebug()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Audio.AudioCallbackMessageParser
TYPE:  class
TOKEN: 0x200003E
FIELDS:
METHODS:
  System.Void Set()
  System.Void _OnMonitoringCallback(AkMonitorErrorCode inErrorCode, AkMonitorErrorLevel inErrorLevel, System.UInt32 inPlayingID, System.UInt64 inGameObjID, System.String inMsg)
END_CLASS

CLASS: Beyond.Audio.AudioDebugInfoContainer
TYPE:  class
TOKEN: 0x200003F
FIELDS:
METHODS:
  System.Void SetAudioObjectName(System.UInt64 audioObjId, System.String name)
  System.Void RemoveAudioObjectName(System.UInt64 audioObjId)
  System.String GetAudioObjectName(System.UInt64 audioObjId)
  System.String ForceGetEventName(System.UInt32 eventId)
  System.String ForceGetRtpcName(System.UInt32 rtpcId)
  System.String GetRtpcName(System.UInt32 rtpcId)
  System.String GetEventName(System.UInt32 eventId)
END_CLASS

CLASS: Beyond.Audio.AudioHashGenerator
TYPE:  class
TOKEN: 0x2000040
FIELDS:
  private   static  System.UInt32                   PRIME32  // 0x0
  private   static  System.UInt32                   OFFSET_BASIS32  // 0x0
METHODS:
  System.UInt32 Compute(System.String inStr)
  System.UInt32 Compute(System.String inStr1, System.String inStr2)
  System.UInt32 Compute(System.String[] strings)
  System.UInt32 _GetUintFromCharToLower(System.Char c)
END_CLASS

CLASS: Beyond.Audio.AudioMemoryMonitor
TYPE:  class
TOKEN: 0x2000041
FIELDS:
  private   static  AkMemCategroyStats              s_categoryStats  // 0x0
  private   static  System.Boolean                  s_monitorInited  // 0x8
METHODS:
  System.Void Init()
  System.Void Release()
  System.Boolean IsValid()
  System.UInt64 GetUsedMemoryUnsafe()
  System.UInt64 GetUsedMemory()
  Beyond.Audio.AudioMemoryMonitor.FGlobalMemoryStats GetGlobalMemoryStats()
  Beyond.Audio.AudioMemoryMonitor.FExtraMemoryStats GetExtraMemoryStats()
  System.UInt64 GetUsedMemoryByCategory(AkMemID memCategory)
END_CLASS

CLASS: Beyond.Audio.AudioUIUtil
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  private   static  System.UInt16                   s_fullScreenCounter  // 0x0
METHODS:
  System.Void Init()
  System.Void Release()
  System.UInt32 PostUIEvent(System.String eventName, UnityEngine.GameObject uiGameObject)
  System.UInt32 PostUIEvent(System.String eventName, System.String objPath)
  System.Void OnUIPanelClose(Beyond.Audio.AudioUIUtil.UIAudioType uiAudioType)
  System.Void OnUIPanelOpen(Beyond.Audio.AudioUIUtil.UIAudioType uiAudioType)
END_CLASS

CLASS: Beyond.Audio.AudioVFSLoader
TYPE:  class
TOKEN: 0x2000046
FIELDS:
  private   static  System.String                   PCK_SUFFIX  // 0x0
  private   static  Beyond.Audio.AudioVFSLoader.VfsLoadedInfos_loadedInitPckInfo  // 0x0
  private   static  Beyond.Audio.AudioVFSLoader.VfsLoadedInfos_loadedMainPckInfo  // 0x10
  private   static  Beyond.Audio.AudioVFSLoader.VfsLoadedInfos_loadedAuditPckInfo  // 0x20
  private   static  Beyond.Audio.AudioVFSLoader.VfsLoadedInfos_loadedLangPckInfo  // 0x30
  private   static  Beyond.VFS.EVFSBlockType        s_pendingLanguageBlock  // 0x40
METHODS:
  System.Void UnloadAll()
  System.Boolean TryLoadInitPck()
  System.Boolean TryLoadMainPck()
  System.Boolean TryLoadLanguagePck(System.String language)
  System.Boolean _DoLoadLanguagePck(Beyond.VFS.EVFSBlockType blockType)
  System.Void InitBasePaths()
  System.Boolean _TryLoadPcksFromVfsInfo(Beyond.VFS.VFBlockMainInfo vfsInfo, Beyond.Audio.AudioVFSLoader.VfsLoadedInfo& info)
  System.Boolean _DoLoadPcksFromVfs(Beyond.VFS.VFBlockMainInfo vfs, System.Collections.Generic.List<System.UInt32>& loaded)
  System.Boolean _DoLoadSinglePckFromVfs(Beyond.VFS.FVFBlockFileInfo fileInfo, System.UInt32& loadedId)
  System.Void _UnloadPcks(Beyond.Audio.AudioVFSLoader.VfsLoadedInfo& info)
  Beyond.VFS.EVFSBlockType _GetVfsBlockTypeFromLanguage(System.String language)
END_CLASS

CLASS: Beyond.Audio.AudioPerformanceMonitor.AudioProfiling
TYPE:  class
TOKEN: 0x2000049
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Audio.AudioPerformanceMonitor.WwiseResourceMonitor
TYPE:  class
TOKEN: 0x200004B
EXTENDS: Singleton`1
FIELDS:
  private   static  System.Single                   TIME_OF_SOUND_FRAME  // 0x0
  private   static  System.Single                   MB_RATE  // 0x0
  private           System.Boolean                  m_isActiveAkResourceMonitoring  // 0x10
  private           Beyond.Audio.AudioPerformanceMonitor.WwiseResourceMonitorItemm_wwiseResourceMonitorData  // 0x14
METHODS:
  System.Boolean get_isActiveAkResourceMonitoring()
  System.Void .ctor()
  System.Boolean IsSupportMemoryMonitor()
  System.Void StartSoundEngineResourceMonitor()
  System.Void StopSoundEngineResourceMonitor()
  Beyond.Audio.AudioPerformanceMonitor.WwiseResourceMonitorItem SampleRawWwiseResource()
END_CLASS

CLASS: Beyond.Audio.AudioPerformanceMonitor.WwiseResourceMonitorItem
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  public            System.Single                   pluginCpu  // 0x10
  public            System.Single                   cpu  // 0x14
  public            System.Single                   pluginCpuInMs  // 0x18
  public            System.Single                   cpuInMs  // 0x1C
  public            System.Single                   reservedMemory  // 0x20
  public            System.Single                   usedMemory  // 0x24
  public            System.Single                   allocatedMemory  // 0x28
  public            System.Single                   mappedMemory  // 0x2C
  public            System.Single                   activeMemory  // 0x30
  public            System.Single                   retainedMemory  // 0x34
  public            System.Int32                    eventNum  // 0x38
  public            System.Int32                    totalVoiceNum  // 0x3C
  public            System.Int32                    physicalVoiceNum  // 0x40
  public            System.Int32                    virtualVoiceNum  // 0x44
  public            System.Int32                    eventCallbackCount  // 0x48
  public            System.Int32                    bankCallbackCount  // 0x4C
METHODS:
END_CLASS

CLASS: Beyond.Audio.Editor.AudioEditorAssetsLoader
TYPE:  class
TOKEN: 0x2000048
FIELDS:
METHODS:
  System.Void Init()
  System.Void Release()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
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

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
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
TOKEN: 0x200004F
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.UInt32 __Gen_Wrap_0(System.UInt32 P0, System.UInt64 P1, System.Object P2, System.UInt32 P3, Beyond.Audio.AudioCallbackType P4, System.Object P5, System.Object P6, Beyond.Audio.AudioCodec P7)
  System.UInt32 __Gen_Wrap_1(System.Object P0, System.UInt64 P1, System.Object P2, System.UInt32 P3, Beyond.Audio.AudioCallbackType P4, System.Object P5, System.Object P6, Beyond.Audio.AudioCodec P7)
  System.Void __Gen_Wrap_2(System.UInt32 P0, System.IntPtr P1, AKRESULT P2, System.Object P3)
  System.Void __Gen_Wrap_3(System.Object P0)
  System.Collections.IEnumerator __Gen_Wrap_4(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_5(System.Collections.Generic.IList<System.UInt32>& P0, System.Action<System.Object>& P1, System.Object& P2)
  System.Void __Gen_Wrap_6(System.Object P0, System.Object P1, System.Object P2)
  System.UInt32 __Gen_Wrap_7(Beyond.Audio.AudioId P0)
  System.Collections.IEnumerator __Gen_Wrap_8(System.Object P0)
  System.Void __Gen_Wrap_9(System.UInt32 P0, System.UInt32 P1, System.UInt64 P2)
  System.Void __Gen_Wrap_10(System.Object P0, System.Object P1, System.UInt64 P2)
  System.UInt32 __Gen_Wrap_11(System.Object P0)
  System.Void __Gen_Wrap_12(System.UInt32 P0, System.Single P1, System.UInt64 P2)
  System.Void __Gen_Wrap_13(System.Object P0, System.Single P1, System.UInt64 P2)
  System.Void __Gen_Wrap_14(System.UInt32 P0, System.Single P1, System.UInt64 P2, System.Int32 P3)
  System.Void __Gen_Wrap_15(System.UInt32 P0, System.UInt32 P1, System.Single P2, System.Int32 P3)
  System.Void __Gen_Wrap_16(System.UInt32 P0, System.Single P1, System.UInt32 P2, System.Int32 P3)
  System.Void __Gen_Wrap_17(System.UInt32 P0, System.UInt64 P1, System.Int32 P2)
  System.Void __Gen_Wrap_18(System.Object P0, System.UInt64 P1, System.Int32 P2)
  System.Void __Gen_Wrap_19(System.UInt32 P0, System.UInt32 P1, System.UInt64 P2, System.Int32 P3, System.Boolean P4)
  System.Void __Gen_Wrap_20(System.UInt32 P0, System.UInt64 P1, System.Int32 P2, System.Boolean P3, System.UInt32 P4)
  System.Void __Gen_Wrap_21(System.Object P0, System.UInt64 P1, System.Int32 P2, System.Boolean P3, System.UInt32 P4)
  System.Void __Gen_Wrap_22(System.Object P0, System.Int32 P1, System.Boolean P2, System.UInt32 P3)
  System.Void __Gen_Wrap_23(System.UInt32 P0, System.Int32 P1, System.Boolean P2, System.UInt32 P3)
  System.Boolean __Gen_Wrap_24(System.UInt32 P0, System.Int32& P1, System.Boolean P2)
  System.Boolean __Gen_Wrap_25(System.UInt32 P0)
  System.Int32 __Gen_Wrap_26()
  System.UInt32 __Gen_Wrap_27(System.Object P0, System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& P1)
  System.UInt32 __Gen_Wrap_28()
  System.Boolean __Gen_Wrap_29(System.Object P0, System.UInt32 P1, System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& P2)
  System.Void __Gen_Wrap_30()
  System.Void __Gen_Wrap_31(System.UInt32 P0, Beyond.Audio.AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload P1)
  System.Void __Gen_Wrap_32(System.Int32 P0)
  AkPositionArray __Gen_Wrap_33(System.Object P0)
  System.Void __Gen_Wrap_34(System.UInt64 P0, System.Object P1, Beyond.Audio.AudioLargeType P2)
  System.Void __Gen_Wrap_35(System.UInt64 P0)
  System.Void __Gen_Wrap_36(System.UInt64 P0, System.UInt64 P1)
  System.Boolean __Gen_Wrap_37(System.UInt32 P0, System.UInt32& P1)
  Beyond.VFS.EVFSBlockType __Gen_Wrap_38(System.Object P0)
  System.Void __Gen_Wrap_39(Beyond.Audio.AudioVFSLoader.VfsLoadedInfo& P0)
  System.Boolean __Gen_Wrap_40(Beyond.VFS.FVFBlockFileInfo P0, System.UInt32& P1)
  System.Boolean __Gen_Wrap_41(System.Object P0, System.Collections.Generic.List<System.UInt32>& P1)
  System.Boolean __Gen_Wrap_42(System.Object P0, Beyond.Audio.AudioVFSLoader.VfsLoadedInfo& P1)
  System.Boolean __Gen_Wrap_43(Beyond.VFS.EVFSBlockType P0)
  System.Boolean __Gen_Wrap_44(System.Object P0)
  System.Void __Gen_Wrap_45(Beyond.Audio.AudioEngineInitSetting P0)
  Beyond.Audio.AudioAdapter.PayloadPostEvent __Gen_Wrap_46()
  System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo> __Gen_Wrap_47()
  Beyond.Audio.AudioVFSLoader.VfsLoadedInfo __Gen_Wrap_48()
  System.Boolean __Gen_Wrap_49()
  System.Void __Gen_Wrap_50(System.Collections.Generic.List<System.UInt32>& P0)
  System.Void __Gen_Wrap_51(System.Object P0, AkCallbackType P1, System.Object P2)
  System.UInt32 __Gen_Wrap_52(System.UInt32 P0, System.UInt64 P1, Beyond.Audio.AudioCallbackType P2, System.Object P3, System.Object P4)
  System.Void __Gen_Wrap_53(System.UInt32 P0, AkActionOnEventType P1, System.Int32 P2)
  System.Void __Gen_Wrap_54(AkActionOnEventType P0, System.UInt32 P1, System.Int32 P2)
  AkResourceMonitorDataSummary __Gen_Wrap_55()
  Beyond.Audio.AudioMemoryMonitor.FGlobalMemoryStats __Gen_Wrap_56()
  Beyond.Audio.AudioMemoryMonitor.FExtraMemoryStats __Gen_Wrap_57()
  System.Void __Gen_Wrap_58(System.Boolean P0)
  System.Void __Gen_Wrap_59(System.UInt64 P0, System.Single P1, System.Single P2)
  System.Boolean __Gen_Wrap_60(System.UInt64 P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, System.Boolean P5, System.Boolean P6)
  System.Boolean __Gen_Wrap_61(System.UInt64 P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2, UnityEngine.Quaternion P3, System.UInt64 P4, System.Boolean P5)
  System.Boolean __Gen_Wrap_62(System.UInt64 P0, Beyond.Audio.AudioRoomData P1, System.UInt64 P2, System.Object P3)
  System.Boolean __Gen_Wrap_63(System.UInt64 P0, System.UInt64 P1, System.UInt64 P2, UnityEngine.Vector3 P3, UnityEngine.Quaternion P4, UnityEngine.Vector3 P5, System.Boolean P6, System.Object P7)
  System.Boolean __Gen_Wrap_64(Beyond.Audio.AudioChannelMask& P0, System.UInt32& P1, Beyond.Audio.AudioChannelConfigType& P2)
  System.Boolean __Gen_Wrap_65(System.Object P0, System.UInt32 P1, System.UInt32 P2, System.UInt32 P3, System.UInt64& P4)
  System.Boolean __Gen_Wrap_66(System.Object P0, System.UInt32 P1, System.UInt64& P2)
  System.UInt64 __Gen_Wrap_67(System.Object P0, System.UInt32 P1)
  System.Boolean __Gen_Wrap_68(System.UInt64 P0)
  System.Boolean __Gen_Wrap_69(System.Boolean P0)
  System.Void __Gen_Wrap_70(System.UInt64 P0, System.UInt32 P1, System.UInt32 P2)
  System.UInt32 __Gen_Wrap_71(System.Int32 P0)
  Beyond.Audio.AsyncLoadBankTask __Gen_Wrap_72(System.Object P0)
  Beyond.Audio.BankHandle __Gen_Wrap_73(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_74(System.Collections.Generic.List<System.UInt32>& P0)
  System.String __Gen_Wrap_75(Beyond.Audio.AudioId& P0)
  System.Int32 __Gen_Wrap_76(Beyond.Audio.AudioId P0)
  Beyond.Audio.AudioId __Gen_Wrap_77(System.UInt32 P0)
  Beyond.Audio.AudioId __Gen_Wrap_78(System.Int32 P0)
  Beyond.Audio.AudioId __Gen_Wrap_79(System.Object P0)
  System.UInt32[] __Gen_Wrap_80(System.Object P0)
  System.Boolean __Gen_Wrap_81(Beyond.Audio.AudioState& P0, Beyond.Audio.AudioState P1)
  System.Boolean __Gen_Wrap_82(Beyond.Audio.AudioState& P0, System.Object P1)
  System.Int32 __Gen_Wrap_83(Beyond.Audio.AudioState& P0)
  Beyond.Audio.AudioDurationCallbackInfo __Gen_Wrap_84(Beyond.Audio.AudioCallbackInfo& P0)
  System.Void __Gen_Wrap_85(System.Object P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2, UnityEngine.Vector3 P3)
  System.Boolean __Gen_Wrap_86(Beyond.Audio.AudioLogChannel P0)
  System.Void __Gen_Wrap_87(Beyond.Audio.AudioLogChannel P0)
  System.Void __Gen_Wrap_88(Beyond.Audio.AudioLogChannel P0, System.Object P1)
  System.Single __Gen_Wrap_89(System.Single P0, System.Single P1, System.Single P2)
  System.Single __Gen_Wrap_90(UnityEngine.Vector3 P0)
  System.Void __Gen_Wrap_91(System.UInt32 P0)
  System.Void __Gen_Wrap_92(System.Object P0, System.Collections.Generic.LinkedListNode<Beyond.Audio.AudioAssetCache.EventCacheInfo>& P1)
  System.Collections.Generic.LinkedList<Beyond.Audio.AudioAssetCache.EventCacheInfo> __Gen_Wrap_93(System.Object P0)
  System.Void __Gen_Wrap_94(System.UInt64 P0, System.UInt16 P1)
  System.Void __Gen_Wrap_95(System.UInt64 P0, System.Object P1)
  System.String __Gen_Wrap_96(System.UInt32 P0)
  System.UInt32 __Gen_Wrap_97(System.Object P0, System.Object P1)
  System.UInt64 __Gen_Wrap_98(AkMemID P0)
  System.Void __Gen_Wrap_99(Beyond.Audio.AudioUIUtil.UIAudioType P0)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000050
EXTENDS: AnonymousStorey
FIELDS:
  private           System.Int32                    methodId_0  // 0x40
  private           System.Int32                    methodId_1  // 0x44
  private           System.Int32                    methodId_2  // 0x48
  private           System.Int32                    methodId_3  // 0x4C
  private           System.Int32                    methodId_4  // 0x50
METHODS:
  System.Void System.IDisposable.Dispose()
  System.Boolean MoveNext()
  System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000051
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
TOKEN: 0x2000052
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_PostEventWithExternalSource0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-PostEventExternal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-PostEventExternal1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_DoLoadAndPinEventsSync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-LoadAndPinEventsSync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-LoadAndPinEventsSync1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_DoLoadAndPinEventsAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_LoadAndPinEventsAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioId-op_Implicit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-LoadAndPinEventsCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-LoadAndPinEventsCoroutine1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetSwitch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetSwitch1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioHashGenerator-Compute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetRtpc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetRtpc1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetRtpc2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioActionQueueHelper-QueueRtpcAction0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetRtpcValueByPlayingID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-ResetRtpc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-ResetRtpc1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioActionQueueHelper-QueueSeekAction0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SeekOnEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SeekOnEvent1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SeekOnEvent2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SeekOnEvent3  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-TryGetPlayingPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-IsPlaying0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-GetCachedAssetCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-Cache-RemoveFirst0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-GetLeastActiveAssetAndUncache0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-Cache-Remove0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-ActivateAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_TryDequeueAndInvokeCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_DoLoadEventAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_ConsumePendingLoadRequests0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_TryConsumePendingLoadRequests0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_DoGc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-ReleaseAllCachedEventsSync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-ReleaseAllCachedEventsSync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioPositionArrayProxy-GetRawArray0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetLargePositions0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetDefaultListener0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetListener0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-TryGetRealPlayingId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetDefaultEmitter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-_GetVfsBlockTypeFromLanguage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-_UnloadPcks0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-_DoLoadSinglePckFromVfs0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-_DoLoadPcksFromVfs0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-_TryLoadPcksFromVfsInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-_DoLoadLanguagePck0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-TryLoadLanguagePck0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetAudioLanguage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetDistanceProbe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetAudioEngineInitSetting0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-UnsetAudioEngineInitSetting0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-PayloadPostEvent-OnRecycle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-Context-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-Cache-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-ResetStaticFields0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_ResetStaticFields0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_InitAndroidActivityEnvironment0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioCallbackMessageParser-Set0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioMemoryMonitor-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-Context-PostSoundEngineInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-VfsLoadedInfo-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-InitBasePaths0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_InitInternal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-TryLoadInitPck0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-LoadInitResources0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-InitWwise0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioActionQueueHelper-ClearQueue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-HasPreparingEvents0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_OnBeforeTerminate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-GetAllUsingAssetsAndRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-UnPrepareAllEventsSync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioMemoryMonitor-Release0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_ReleaseInternal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-TermWwise0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-UnloadAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-ReloadInitResources0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-MemoryShrink0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_OnEventPreparedDoPostEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_OnEventCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_OnExternalSourceEventCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_PostEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioActionQueueHelper-QueueExecuteAction0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_ExecuteActionOnPlayingId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_SampleAllData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-_SampleMemoryOnly0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-StartProfileCapture0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-StopProfileCapture0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-GetResourceSummaryData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-GetGlobalMemoryStats0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-GetExtraMemoryStats0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetEnableSpatialAudio0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetObjectObstructionAndOcclusion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetGeometry0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetGeometryInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetRoom0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-SetPortal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-Device-GetSpeakerConfiguration0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-Device-AddOutputDevice0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-Device-AddOutput0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-Device-GetOutputDeviceId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-Device-RemoveOutputDevice0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-Device-Switch3DOutput0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-Device-SetOutputDeviceEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAdapter-Device-GetMmDeviceIdFromScePadHandle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-BankHandle-DecRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioBankManager-UnloadBank0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-BankHandle-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-BankHandle-IncRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AsyncLoadBankTask-LoadBanksAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AsyncLoadBankTask-MoveNext0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AsyncLoadBankTask-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AsyncLoadBankTask-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioVFSLoader-TryLoadMainPck0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioBankManager-LoadMainPCK0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioBankManager-_LoadBankCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioBankManager-LoadBankAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioBankManager-UnloadAllBanks0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioBankManager-IsBankLoaded0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioBankManager-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioBankManager-_PreResetBasePath0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioBankManager-_PostResetBasePath0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioBankManager-LoadDebugFilePackage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioBankManager-AddDebugBankPath0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioId-GetName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioId-op_Implicit1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioId-op_Implicit2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioId-op_Implicit3  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioId-op_Implicit4  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioIdExtensions-ToUIntArray0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioState-Equals0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioState-Equals1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioState-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioCallbackInfo-CastToDurationCallbackInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioPositionArrayProxy-Add0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioPositionArrayProxy-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioLogger-IsChannelEnabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioLogger-EnableChannel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioLogger-DisableChannel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioLogger-SetChannels0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioLogger-_DoLog0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioLogger-Log0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioLogger-_DoLogWarning0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioLogger-LogWarning0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioLogger-_DoLogError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioLogger-LogError0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAcousticUtil-RT60DecayTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAcousticUtil-PreDelayTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAcousticUtil-CriticalDistance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAcousticUtil-ReverbIntensity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAcousticUtil-ErIntensity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioActionQueueHelper-_ConsumeExecute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioActionQueueHelper-_ConsumeRtpc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioActionQueueHelper-_ConsumeSeek0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioActionQueueHelper-ConsumeQueue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-PinEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-UnpinEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-Cache-AddLast0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-DeactivateAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-ForceReleaseCachedAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-_NotifyDebugger0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-_NotifyDebuggerCacheHit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-_ResetDebugger0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-_PinnedEventLeakDetect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetCache-Cache-get_lruCachedEventsList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-SetMemoryBudget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_OnUnpreparedDoUnloadBank0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_OnDoneUnloadBank0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_OnDonePrepareEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_OnBankLoadedDoPrepareEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_RemoveLoadingDebug0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_AddLoadingDebug0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioAssetHelper-_ClearLoadingDebug0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioDebugInfoContainer-SetAudioObjectName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioDebugInfoContainer-RemoveAudioObjectName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioDebugInfoContainer-ForceGetEventName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioDebugInfoContainer-ForceGetRtpcName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioHashGenerator-Compute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioHashGenerator-Compute2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioMemoryMonitor-GetGlobalMemoryStats0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioMemoryMonitor-GetExtraMemoryStats0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioMemoryMonitor-GetUsedMemoryByCategory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioUIUtil-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioUIUtil-Release0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioUIUtil-PostUIEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioUIUtil-PostUIEvent1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioUIUtil-OnUIPanelClose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Audio-AudioUIUtil-OnUIPanelOpen0  // 0x0
METHODS:
END_CLASS

