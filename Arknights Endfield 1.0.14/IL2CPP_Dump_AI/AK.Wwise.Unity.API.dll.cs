// ========================================================
// Dumped by @desirepro
// Assembly: AK.Wwise.Unity.API.dll
// Classes:  182
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Ak3DAudioSinkCapabilities
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(Ak3DAudioSinkCapabilities obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_channelConfig(AkChannelConfig value)
  AkChannelConfig get_channelConfig()
  System.Void set_uMaxSystemAudioObjects(System.UInt32 value)
  System.UInt32 get_uMaxSystemAudioObjects()
  System.Void set_uAvailableSystemAudioObjects(System.UInt32 value)
  System.UInt32 get_uAvailableSystemAudioObjects()
  System.Void set_bPassthrough(System.Boolean value)
  System.Boolean get_bPassthrough()
  System.Void set_bMultiChannelObjects(System.Boolean value)
  System.Boolean get_bMultiChannelObjects()
  System.Void .ctor()
END_CLASS

CLASS: Ak3dData
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(Ak3dData obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void set_xform(AkTransform value)
  AkTransform get_xform()
  System.Void set_spread(System.Single value)
  System.Single get_spread()
  System.Void set_focus(System.Single value)
  System.Single get_focus()
  System.Void set_uEmitterChannelMask(System.UInt32 value)
  System.UInt32 get_uEmitterChannelMask()
END_CLASS

CLASS: Ak3DPositionType
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Ak3DPositionType                AK_3DPositionType_Emitter  // 0x0
  public    static  Ak3DPositionType                AK_3DPositionType_EmitterWithAutomation  // 0x0
  public    static  Ak3DPositionType                AK_3DPositionType_ListenerWithAutomation  // 0x0
METHODS:
END_CLASS

CLASS: Ak3DSpatializationMode
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Ak3DSpatializationMode          AK_SpatializationMode_None  // 0x0
  public    static  Ak3DSpatializationMode          AK_SpatializationMode_PositionOnly  // 0x0
  public    static  Ak3DSpatializationMode          AK_SpatializationMode_PositionAndOrientation  // 0x0
METHODS:
END_CLASS

CLASS: AkAcousticSurface
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkAcousticSurface obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void set_textureID(System.UInt32 value)
  System.UInt32 get_textureID()
  System.Void set_transmissionLoss(System.Single value)
  System.Single get_transmissionLoss()
  System.Void set_strName(System.String value)
  System.String get_strName()
  System.Void Clear()
  System.Void DeleteName()
  System.Int32 GetSizeOf()
  System.Void Clone(AkAcousticSurface other)
END_CLASS

CLASS: AkActionOnEventType
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkActionOnEventType             AkActionOnEventType_Stop  // 0x0
  public    static  AkActionOnEventType             AkActionOnEventType_Pause  // 0x0
  public    static  AkActionOnEventType             AkActionOnEventType_Resume  // 0x0
  public    static  AkActionOnEventType             AkActionOnEventType_Break  // 0x0
  public    static  AkActionOnEventType             AkActionOnEventType_ReleaseEnvelope  // 0x0
METHODS:
END_CLASS

CLASS: AkAttenuationCurveType
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkAttenuationCurveType          AttenuationCurveID_VolumeDry  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_VolumeAuxGameDef  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_VolumeAuxUserDef  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_LowPassFilter  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_HighPassFilter  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_Spread  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_Focus  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_ObstructionVolume  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_ObstructionLPF  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_ObstructionHPF  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_OcclusionVolume  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_OcclusionLPF  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_OcclusionHPF  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_DiffractionVolume  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_DiffractionLPF  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_DiffractionHPF  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_TransmissionVolume  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_TransmissionLPF  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_TransmissionHPF  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_MaxCount  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_Project  // 0x0
  public    static  AkAttenuationCurveType          AttenuationCurveID_None  // 0x0
METHODS:
END_CLASS

CLASS: AkAudioDeviceState
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkAudioDeviceState              AkDeviceState_Unknown  // 0x0
  public    static  AkAudioDeviceState              AkDeviceState_Active  // 0x0
  public    static  AkAudioDeviceState              AkDeviceState_Disabled  // 0x0
  public    static  AkAudioDeviceState              AkDeviceState_NotPresent  // 0x0
  public    static  AkAudioDeviceState              AkDeviceState_Unplugged  // 0x0
  public    static  AkAudioDeviceState              AkDeviceState_All  // 0x0
METHODS:
END_CLASS

CLASS: AkAudioFormat
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkAudioFormat obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_uSampleRate(System.UInt32 value)
  System.UInt32 get_uSampleRate()
  System.Void set_channelConfig(AkChannelConfig value)
  AkChannelConfig get_channelConfig()
  System.Void set_uBitsPerSample(System.UInt32 value)
  System.UInt32 get_uBitsPerSample()
  System.Void set_uBlockAlign(System.UInt32 value)
  System.UInt32 get_uBlockAlign()
  System.Void set_uTypeID(System.UInt32 value)
  System.UInt32 get_uTypeID()
  System.Void set_uInterleaveID(System.UInt32 value)
  System.UInt32 get_uInterleaveID()
  System.UInt32 GetNumChannels()
  System.UInt32 GetBitsPerSample()
  System.UInt32 GetBlockAlign()
  System.UInt32 GetTypeID()
  System.UInt32 GetInterleaveID()
  System.Void SetAll(System.UInt32 in_uSampleRate, AkChannelConfig in_channelConfig, System.UInt32 in_uBitsPerSample, System.UInt32 in_uBlockAlign, System.UInt32 in_uTypeID, System.UInt32 in_uInterleaveID)
  System.Void .ctor()
END_CLASS

CLASS: AkAudioInterruptionCallbackInfo
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkAudioInterruptionCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean get_bEnterInterruption()
  System.Void .ctor()
END_CLASS

CLASS: AkAudioObjectDestination
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkAudioObjectDestination        eDefault  // 0x0
  public    static  AkAudioObjectDestination        eMainMix  // 0x0
  public    static  AkAudioObjectDestination        ePassthrough  // 0x0
  public    static  AkAudioObjectDestination        eSystemAudioObject  // 0x0
METHODS:
END_CLASS

CLASS: AkAudioSettings
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkAudioSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_uNumSamplesPerFrame(System.UInt32 value)
  System.UInt32 get_uNumSamplesPerFrame()
  System.Void set_uNumSamplesPerSecond(System.UInt32 value)
  System.UInt32 get_uNumSamplesPerSecond()
  System.Void .ctor()
END_CLASS

CLASS: AkAudioSourceChangeCallbackInfo
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkAudioSourceChangeCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean get_bOtherAudioPlaying()
  System.Void .ctor()
END_CLASS

CLASS: AkAuxSendValue
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkAuxSendValue obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_listenerID(System.UInt64 value)
  System.UInt64 get_listenerID()
  System.Void set_auxBusID(System.UInt32 value)
  System.UInt32 get_auxBusID()
  System.Void set_fControlValue(System.Single value)
  System.Single get_fControlValue()
  System.Void Set(System.UInt64 listener, System.UInt32 id, System.Single value)
  System.Boolean IsSame(System.UInt64 listener, System.UInt32 id)
  System.Void Set(UnityEngine.GameObject listener, System.UInt32 id, System.Single value)
  System.Boolean IsSame(UnityEngine.GameObject listener, System.UInt32 id)
  System.Int32 GetSizeOf()
END_CLASS

CLASS: AkBankCallbackInfo
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkBankCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.UInt32 get_bankID()
  System.IntPtr get_inMemoryBankPtr()
  AKRESULT get_loadResult()
  System.Void .ctor()
END_CLASS

CLASS: AkBankContent
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkBankContent                   AkBankContent_StructureOnly  // 0x0
  public    static  AkBankContent                   AkBankContent_All  // 0x0
METHODS:
END_CLASS

CLASS: AkBankTypeEnum
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkBankTypeEnum                  AkBankType_User  // 0x0
  public    static  AkBankTypeEnum                  AkBankType_Event  // 0x0
  public    static  AkBankTypeEnum                  AkBankType_Bus  // 0x0
METHODS:
END_CLASS

CLASS: AkBehavioralPositioningData
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkBehavioralPositioningData obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void set_center(System.Single value)
  System.Single get_center()
  System.Void set_panLR(System.Single value)
  System.Single get_panLR()
  System.Void set_panBF(System.Single value)
  System.Single get_panBF()
  System.Void set_panDU(System.Single value)
  System.Single get_panDU()
  System.Void set_panSpatMix(System.Single value)
  System.Single get_panSpatMix()
  System.Void set_spatMode(Ak3DSpatializationMode value)
  Ak3DSpatializationMode get_spatMode()
  System.Void set_panType(AkSpeakerPanningType value)
  AkSpeakerPanningType get_panType()
  System.Void set_enableHeightSpread(System.Boolean value)
  System.Boolean get_enableHeightSpread()
END_CLASS

CLASS: AkBusHierarchyFlags
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkBusHierarchyFlags             AkBusHierarchy_Primary  // 0x0
  public    static  AkBusHierarchyFlags             AkBusHierarchy_Secondary  // 0x0
  public    static  AkBusHierarchyFlags             AkBusHierarchy_IsMaster  // 0x0
METHODS:
END_CLASS

CLASS: AkCallbackInfo
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.IntPtr get_pCookie()
  System.UInt64 get_gameObjID()
  System.Void .ctor()
END_CLASS

CLASS: AkCallbackSerializer
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkCallbackSerializer obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  AKRESULT Init()
  System.Void Term()
  System.IntPtr Lock()
  System.Void Unlock()
  System.Void SetLocalOutput(System.UInt32 in_uErrorLevel, System.String in_ip, System.UInt32 in_port, System.String in_xmlFilePath, System.UInt32 in_msXmlTranslatorTimeout, System.UInt32 in_msWaapiTranslatorTimeout)
  AKRESULT AudioSourceChangeCallbackFunc(System.Boolean in_bOtherAudioPlaying, System.Object in_pCookie)
  System.Void .ctor()
END_CLASS

CLASS: AkCallbackType
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkCallbackType                  AK_EndOfEvent  // 0x0
  public    static  AkCallbackType                  AK_EndOfDynamicSequenceItem  // 0x0
  public    static  AkCallbackType                  AK_Marker  // 0x0
  public    static  AkCallbackType                  AK_Duration  // 0x0
  public    static  AkCallbackType                  AK_SpeakerVolumeMatrix  // 0x0
  public    static  AkCallbackType                  AK_Starvation  // 0x0
  public    static  AkCallbackType                  AK_MusicPlaylistSelect  // 0x0
  public    static  AkCallbackType                  AK_MusicPlayStarted  // 0x0
  public    static  AkCallbackType                  AK_MusicSyncBeat  // 0x0
  public    static  AkCallbackType                  AK_MusicSyncBar  // 0x0
  public    static  AkCallbackType                  AK_MusicSyncEntry  // 0x0
  public    static  AkCallbackType                  AK_MusicSyncExit  // 0x0
  public    static  AkCallbackType                  AK_MusicSyncGrid  // 0x0
  public    static  AkCallbackType                  AK_MusicSyncUserCue  // 0x0
  public    static  AkCallbackType                  AK_MusicSyncPoint  // 0x0
  public    static  AkCallbackType                  AK_MusicSyncAll  // 0x0
  public    static  AkCallbackType                  AK_MIDIEvent  // 0x0
  public    static  AkCallbackType                  AK_CallbackBits  // 0x0
  public    static  AkCallbackType                  AK_EnableGetSourcePlayPosition  // 0x0
  public    static  AkCallbackType                  AK_EnableGetMusicPlayPosition  // 0x0
  public    static  AkCallbackType                  AK_EnableGetSourceStreamBuffering  // 0x0
  public    static  AkCallbackType                  AK_Monitoring  // 0x0
  public    static  AkCallbackType                  AK_Bank  // 0x0
  public    static  AkCallbackType                  AK_AudioInterruption  // 0x0
  public    static  AkCallbackType                  AK_AudioSourceChange  // 0x0
METHODS:
END_CLASS

CLASS: AkChannelConfig
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkChannelConfig obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_uNumChannels(System.UInt32 value)
  System.UInt32 get_uNumChannels()
  System.Void set_eConfigType(System.UInt32 value)
  System.UInt32 get_eConfigType()
  System.Void set_uChannelMask(System.UInt32 value)
  System.UInt32 get_uChannelMask()
  AkChannelConfig Standard(System.UInt32 in_uChannelMask)
  AkChannelConfig Anonymous(System.UInt32 in_uNumChannels)
  AkChannelConfig Ambisonic(System.UInt32 in_uNumChannels)
  AkChannelConfig Object()
  System.Void .ctor()
  System.Void .ctor(System.UInt32 in_uNumChannels, System.UInt32 in_uChannelMask)
  System.Void Clear()
  System.Void SetStandard(System.UInt32 in_uChannelMask)
  System.Void SetStandardOrAnonymous(System.UInt32 in_uNumChannels, System.UInt32 in_uChannelMask)
  System.Void SetAnonymous(System.UInt32 in_uNumChannels)
  System.Void SetAmbisonic(System.UInt32 in_uNumChannels)
  System.Void SetObject()
  System.Void SetSameAsMainMix()
  System.Void SetSameAsPassthrough()
  System.Boolean IsValid()
  System.UInt32 Serialize()
  System.Void Deserialize(System.UInt32 in_uChannelConfig)
  AkChannelConfig RemoveLFE()
  AkChannelConfig RemoveCenter()
END_CLASS

CLASS: AkChannelConfigType
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkChannelConfigType             AK_ChannelConfigType_Anonymous  // 0x0
  public    static  AkChannelConfigType             AK_ChannelConfigType_Standard  // 0x0
  public    static  AkChannelConfigType             AK_ChannelConfigType_Ambisonic  // 0x0
  public    static  AkChannelConfigType             AK_ChannelConfigType_Objects  // 0x0
  public    static  AkChannelConfigType             AK_ChannelConfigType_UseDeviceMain  // 0x0
  public    static  AkChannelConfigType             AK_ChannelConfigType_UseDevicePassthrough  // 0x0
METHODS:
END_CLASS

CLASS: AkChannelEmitter
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkChannelEmitter obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_position(AkWorldTransform value)
  AkWorldTransform get_position()
  System.Void set_uInputChannels(System.UInt32 value)
  System.UInt32 get_uInputChannels()
  System.Void set_padding(System.String value)
  System.String get_padding()
END_CLASS

CLASS: AkChannelOrdering
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkChannelOrdering               ChannelOrdering_Standard  // 0x0
  public    static  AkChannelOrdering               ChannelOrdering_RunTime  // 0x0
METHODS:
END_CLASS

CLASS: AkConnectionType
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkConnectionType                ConnectionType_Direct  // 0x0
  public    static  AkConnectionType                ConnectionType_GameDefSend  // 0x0
  public    static  AkConnectionType                ConnectionType_UserDefSend  // 0x0
  public    static  AkConnectionType                ConnectionType_ReflectionsSend  // 0x0
METHODS:
END_CLASS

CLASS: AkCurveInterpolation
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkCurveInterpolation            AkCurveInterpolation_Log3  // 0x0
  public    static  AkCurveInterpolation            AkCurveInterpolation_Sine  // 0x0
  public    static  AkCurveInterpolation            AkCurveInterpolation_Log1  // 0x0
  public    static  AkCurveInterpolation            AkCurveInterpolation_InvSCurve  // 0x0
  public    static  AkCurveInterpolation            AkCurveInterpolation_Linear  // 0x0
  public    static  AkCurveInterpolation            AkCurveInterpolation_SCurve  // 0x0
  public    static  AkCurveInterpolation            AkCurveInterpolation_Exp1  // 0x0
  public    static  AkCurveInterpolation            AkCurveInterpolation_SineRecip  // 0x0
  public    static  AkCurveInterpolation            AkCurveInterpolation_Exp3  // 0x0
  public    static  AkCurveInterpolation            AkCurveInterpolation_LastFadeCurve  // 0x0
  public    static  AkCurveInterpolation            AkCurveInterpolation_Constant  // 0x0
METHODS:
END_CLASS

CLASS: AkDeviceDescription
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkDeviceDescription obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_idDevice(System.UInt32 value)
  System.UInt32 get_idDevice()
  System.Void set_deviceName(System.String value)
  System.String get_deviceName()
  System.Void set_deviceStateMask(AkAudioDeviceState value)
  AkAudioDeviceState get_deviceStateMask()
  System.Void set_isDefaultDevice(System.Boolean value)
  System.Boolean get_isDefaultDevice()
  System.Void Clear()
  System.Int32 GetSizeOf()
  System.Void Clone(AkDeviceDescription other)
  System.Void .ctor()
END_CLASS

CLASS: AkDeviceSettings
TYPE:  class
TOKEN: 0x200001F
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkDeviceSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_pIOMemory(System.IntPtr value)
  System.IntPtr get_pIOMemory()
  System.Void set_uIOMemorySize(System.UInt32 value)
  System.UInt32 get_uIOMemorySize()
  System.Void set_uIOMemoryAlignment(System.UInt32 value)
  System.UInt32 get_uIOMemoryAlignment()
  System.Void set_ePoolAttributes(System.UInt32 value)
  System.UInt32 get_ePoolAttributes()
  System.Void set_uGranularity(System.UInt32 value)
  System.UInt32 get_uGranularity()
  System.Void set_threadProperties(AkThreadProperties value)
  AkThreadProperties get_threadProperties()
  System.Void set_fTargetAutoStmBufferLength(System.Single value)
  System.Single get_fTargetAutoStmBufferLength()
  System.Void set_uMaxConcurrentIO(System.UInt32 value)
  System.UInt32 get_uMaxConcurrentIO()
  System.Void set_bUseStreamCache(System.Boolean value)
  System.Boolean get_bUseStreamCache()
  System.Void set_uMaxCachePinnedBytes(System.UInt32 value)
  System.UInt32 get_uMaxCachePinnedBytes()
END_CLASS

CLASS: AkDiffractionPathInfo
TYPE:  class
TOKEN: 0x2000020
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
  public    static  System.UInt32                   kMaxNodes  // 0x0
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkDiffractionPathInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_emitterPos(AkVector64 value)
  AkVector64 get_emitterPos()
  System.Void set_virtualPos(AkWorldTransform value)
  AkWorldTransform get_virtualPos()
  System.Void set_nodeCount(System.UInt32 value)
  System.UInt32 get_nodeCount()
  System.Void set_diffraction(System.Single value)
  System.Single get_diffraction()
  System.Void set_transmissionLoss(System.Single value)
  System.Single get_transmissionLoss()
  System.Void set_totLength(System.Single value)
  System.Single get_totLength()
  System.Void set_obstructionValue(System.Single value)
  System.Single get_obstructionValue()
  System.Void set_occlusionValue(System.Single value)
  System.Single get_occlusionValue()
  System.Int32 GetSizeOf()
  UnityEngine.Vector3 GetNodes(System.UInt32 idx)
  System.Single GetAngles(System.UInt32 idx)
  System.UInt64 GetPortals(System.UInt32 idx)
  System.UInt64 GetRooms(System.UInt32 idx)
  System.Void Clone(AkDiffractionPathInfo other)
  System.Void .ctor()
END_CLASS

CLASS: AkDurationCallbackInfo
TYPE:  class
TOKEN: 0x2000021
EXTENDS: AkEventCallbackInfo
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x28
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkDurationCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Dispose(System.Boolean disposing)
  System.Single get_fDuration()
  System.Single get_fEstimatedDuration()
  System.UInt32 get_audioNodeID()
  System.UInt32 get_mediaID()
  System.Boolean get_bStreaming()
  System.Void .ctor()
END_CLASS

CLASS: AkDynamicSequenceItemCallbackInfo
TYPE:  class
TOKEN: 0x2000022
EXTENDS: AkCallbackInfo
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x20
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Dispose(System.Boolean disposing)
  System.UInt32 get_playingID()
  System.UInt32 get_audioNodeID()
  System.IntPtr get_pCustomInfo()
  System.Void .ctor()
END_CLASS

CLASS: AkDynamicSequenceType
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkDynamicSequenceType           DynamicSequenceType_SampleAccurate  // 0x0
  public    static  AkDynamicSequenceType           DynamicSequenceType_NormalTransition  // 0x0
METHODS:
END_CLASS

CLASS: AkEventCallbackInfo
TYPE:  class
TOKEN: 0x2000024
EXTENDS: AkCallbackInfo
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x20
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkEventCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Dispose(System.Boolean disposing)
  System.UInt32 get_playingID()
  System.UInt32 get_eventID()
  System.Void .ctor()
END_CLASS

CLASS: AkExtent
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkExtent obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void .ctor(System.Single in_halfWidth, System.Single in_halfHeight, System.Single in_halfDepth)
  System.Void set_halfWidth(System.Single value)
  System.Single get_halfWidth()
  System.Void set_halfHeight(System.Single value)
  System.Single get_halfHeight()
  System.Void set_halfDepth(System.Single value)
  System.Single get_halfDepth()
END_CLASS

CLASS: AkExternalSourceInfo
TYPE:  class
TOKEN: 0x2000026
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkExternalSourceInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void .ctor(System.IntPtr in_pInMemory, System.UInt32 in_uiMemorySize, System.UInt32 in_iExternalSrcCookie, System.UInt32 in_idCodec)
  System.Void .ctor(System.String in_pszFileName, System.UInt32 in_iExternalSrcCookie, System.UInt32 in_idCodec)
  System.Void .ctor(System.UInt32 in_idFile, System.UInt32 in_iExternalSrcCookie, System.UInt32 in_idCodec)
  System.Void Clear()
  System.Void Clone(AkExternalSourceInfo other)
  System.Int32 GetSizeOf()
  System.Void set_iExternalSrcCookie(System.UInt32 value)
  System.UInt32 get_iExternalSrcCookie()
  System.Void set_idCodec(System.UInt32 value)
  System.UInt32 get_idCodec()
  System.Void set_szFile(System.String value)
  System.String get_szFile()
  System.Void set_pInMemory(System.IntPtr value)
  System.IntPtr get_pInMemory()
  System.Void set_uiMemorySize(System.UInt32 value)
  System.UInt32 get_uiMemorySize()
  System.Void set_idFile(System.UInt32 value)
  System.UInt32 get_idFile()
END_CLASS

CLASS: AkFloorPlane
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkFloorPlane                    AkFloorPlane_XZ  // 0x0
  public    static  AkFloorPlane                    AkFloorPlane_XY  // 0x0
  public    static  AkFloorPlane                    AkFloorPlane_YZ  // 0x0
  public    static  AkFloorPlane                    AkFloorPlane_Default  // 0x0
METHODS:
END_CLASS

CLASS: AkGeometryInstanceParams
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkGeometryInstanceParams obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void set_PositionAndOrientation(AkWorldTransform value)
  AkWorldTransform get_PositionAndOrientation()
  System.Void set_Scale(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_Scale()
  System.Void set_UseForReflectionAndDiffraction(System.Boolean value)
  System.Boolean get_UseForReflectionAndDiffraction()
END_CLASS

CLASS: AkGlobalCallbackLocation
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_Register  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_Begin  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_PreProcessMessageQueueForRender  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_PostMessagesProcessed  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_BeginRender  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_EndRender  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_End  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_Term  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_Monitor  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_MonitorRecap  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_Init  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_Suspend  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_WakeupFromSuspend  // 0x0
  public    static  AkGlobalCallbackLocation        AkGlobalCallbackLocation_Num  // 0x0
METHODS:
END_CLASS

CLASS: AkGroupType
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkGroupType                     AkGroupType_Switch  // 0x0
  public    static  AkGroupType                     AkGroupType_State  // 0x0
METHODS:
END_CLASS

CLASS: AkImageSourceParams
TYPE:  class
TOKEN: 0x200002B
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkImageSourceParams obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void .ctor(AkVector64 in_sourcePosition, System.Single in_fDistanceScalingFactor, System.Single in_fLevel)
  System.Void set_sourcePosition(AkVector64 value)
  AkVector64 get_sourcePosition()
  System.Void set_fDistanceScalingFactor(System.Single value)
  System.Single get_fDistanceScalingFactor()
  System.Void set_fLevel(System.Single value)
  System.Single get_fLevel()
  System.Void set_fDiffraction(System.Single value)
  System.Single get_fDiffraction()
  System.Void set_fOcclusion(System.Single value)
  System.Single get_fOcclusion()
  System.Void set_uDiffractionEmitterSide(System.Byte value)
  System.Byte get_uDiffractionEmitterSide()
  System.Void set_uDiffractionListenerSide(System.Byte value)
  System.Byte get_uDiffractionListenerSide()
END_CLASS

CLASS: AkImageSourceSettings
TYPE:  class
TOKEN: 0x200002C
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkImageSourceSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void .ctor(AkVector64 in_sourcePosition, System.Single in_fDistanceScalingFactor, System.Single in_fLevel)
  System.Void SetOneTexture(System.UInt32 in_texture)
  System.Void set_params_(AkImageSourceParams value)
  AkImageSourceParams get_params_()
END_CLASS

CLASS: AkInitializationSettings
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkInitializationSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void set_streamMgrSettings(AkStreamMgrSettings value)
  AkStreamMgrSettings get_streamMgrSettings()
  System.Void set_deviceSettings(AkDeviceSettings value)
  AkDeviceSettings get_deviceSettings()
  System.Void set_initSettings(AkInitSettings value)
  AkInitSettings get_initSettings()
  System.Void set_platformSettings(AkPlatformInitSettings value)
  AkPlatformInitSettings get_platformSettings()
  System.Void set_musicSettings(AkMusicSettings value)
  AkMusicSettings get_musicSettings()
  System.Void set_unityPlatformSpecificSettings(AkUnityPlatformSpecificSettings value)
  AkUnityPlatformSpecificSettings get_unityPlatformSpecificSettings()
  System.Void set_uMemAllocationSizeLimit(System.UInt32 value)
  System.UInt32 get_uMemAllocationSizeLimit()
  System.Void set_uMemDebugLevel(System.UInt32 value)
  System.UInt32 get_uMemDebugLevel()
  System.Void set_uMemSpanCount(System.UInt32 value)
  System.UInt32 get_uMemSpanCount()
END_CLASS

CLASS: AkInitSettings
TYPE:  class
TOKEN: 0x200002E
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkInitSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_uMaxNumPaths(System.UInt32 value)
  System.UInt32 get_uMaxNumPaths()
  System.Void set_uCommandQueueSize(System.UInt32 value)
  System.UInt32 get_uCommandQueueSize()
  System.Void set_bEnableGameSyncPreparation(System.Boolean value)
  System.Boolean get_bEnableGameSyncPreparation()
  System.Void set_uContinuousPlaybackLookAhead(System.UInt32 value)
  System.UInt32 get_uContinuousPlaybackLookAhead()
  System.Void set_uNumSamplesPerFrame(System.UInt32 value)
  System.UInt32 get_uNumSamplesPerFrame()
  System.Void set_uMonitorQueuePoolSize(System.UInt32 value)
  System.UInt32 get_uMonitorQueuePoolSize()
  System.Void set_uCpuMonitorQueueMaxSize(System.UInt32 value)
  System.UInt32 get_uCpuMonitorQueueMaxSize()
  System.Void set_settingsMainOutput(AkOutputSettings value)
  AkOutputSettings get_settingsMainOutput()
  System.Void set_uMaxHardwareTimeoutMs(System.UInt32 value)
  System.UInt32 get_uMaxHardwareTimeoutMs()
  System.Void set_bUseSoundBankMgrThread(System.Boolean value)
  System.Boolean get_bUseSoundBankMgrThread()
  System.Void set_bUseLEngineThread(System.Boolean value)
  System.Boolean get_bUseLEngineThread()
  System.Void set_szPluginDLLPath(System.String value)
  System.String get_szPluginDLLPath()
  System.Void set_eFloorPlane(AkFloorPlane value)
  AkFloorPlane get_eFloorPlane()
  System.Void set_fGameUnitsToMeters(System.Single value)
  System.Single get_fGameUnitsToMeters()
  System.Void set_uBankReadBufferSize(System.UInt32 value)
  System.UInt32 get_uBankReadBufferSize()
  System.Void set_fDebugOutOfRangeLimit(System.Single value)
  System.Single get_fDebugOutOfRangeLimit()
  System.Void set_bDebugOutOfRangeCheckEnabled(System.Boolean value)
  System.Boolean get_bDebugOutOfRangeCheckEnabled()
END_CLASS

CLASS: AkIterator
TYPE:  class
TOKEN: 0x200002F
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkIterator obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_pItem(AkPlaylistItem value)
  AkPlaylistItem get_pItem()
  AkIterator NextIter()
  AkIterator PrevIter()
  AkPlaylistItem GetItem()
  System.Boolean IsEqualTo(AkIterator in_rOp)
  System.Boolean IsDifferentFrom(AkIterator in_rOp)
  System.Void .ctor()
END_CLASS

CLASS: AkMarkerCallbackInfo
TYPE:  class
TOKEN: 0x2000030
EXTENDS: AkEventCallbackInfo
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x28
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMarkerCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Dispose(System.Boolean disposing)
  System.UInt32 get_uIdentifier()
  System.UInt32 get_uPosition()
  System.String get_strLabel()
  System.Void .ctor()
END_CLASS

CLASS: AkMemCategroyStats
TYPE:  class
TOKEN: 0x2000031
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMemCategroyStats obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_uUsed(System.UInt64 value)
  System.UInt64 get_uUsed()
  System.Void set_uPeakUsed(System.UInt64 value)
  System.UInt64 get_uPeakUsed()
  System.Void set_uAllocs(System.UInt32 value)
  System.UInt32 get_uAllocs()
  System.Void set_uFrees(System.UInt32 value)
  System.UInt32 get_uFrees()
  System.Void .ctor()
END_CLASS

CLASS: AkMemGlobalStats
TYPE:  class
TOKEN: 0x2000032
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMemGlobalStats obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_uUsed(System.UInt64 value)
  System.UInt64 get_uUsed()
  System.Void set_uDeviceUsed(System.UInt64 value)
  System.UInt64 get_uDeviceUsed()
  System.Void set_uReserved(System.UInt64 value)
  System.UInt64 get_uReserved()
  System.Void set_uMax(System.UInt64 value)
  System.UInt64 get_uMax()
  System.Void .ctor()
END_CLASS

CLASS: AkMemID
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  AkMemID                         AkMemID_Object  // 0x0
  public    static  AkMemID                         AkMemID_Event  // 0x0
  public    static  AkMemID                         AkMemID_Structure  // 0x0
  public    static  AkMemID                         AkMemID_Media  // 0x0
  public    static  AkMemID                         AkMemID_GameObject  // 0x0
  public    static  AkMemID                         AkMemID_Processing  // 0x0
  public    static  AkMemID                         AkMemID_ProcessingPlugin  // 0x0
  public    static  AkMemID                         AkMemID_Streaming  // 0x0
  public    static  AkMemID                         AkMemID_StreamingIO  // 0x0
  public    static  AkMemID                         AkMemID_SpatialAudio  // 0x0
  public    static  AkMemID                         AkMemID_SpatialAudioGeometry  // 0x0
  public    static  AkMemID                         AkMemID_SpatialAudioPaths  // 0x0
  public    static  AkMemID                         AkMemID_GameSim  // 0x0
  public    static  AkMemID                         AkMemID_MonitorQueue  // 0x0
  public    static  AkMemID                         AkMemID_Profiler  // 0x0
  public    static  AkMemID                         AkMemID_FilePackage  // 0x0
  public    static  AkMemID                         AkMemID_SoundEngine  // 0x0
  public    static  AkMemID                         AkMemID_Integration  // 0x0
  public    static  AkMemID                         AkMemID_JobMgr  // 0x0
  public    static  AkMemID                         AkMemID_TempAudioRender  // 0x0
  public    static  AkMemID                         AkMemID_NUM  // 0x0
  public    static  AkMemID                         AkMemID_MASK  // 0x0
  public    static  AkMemID                         AkMemType_Media  // 0x0
  public    static  AkMemID                         AkMemType_Device  // 0x0
  public    static  AkMemID                         AkMemType_NoTrack  // 0x0
METHODS:
END_CLASS

CLASS: AkMeteringFlags
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkMeteringFlags                 AK_NoMetering  // 0x0
  public    static  AkMeteringFlags                 AK_EnableBusMeter_Peak  // 0x0
  public    static  AkMeteringFlags                 AK_EnableBusMeter_TruePeak  // 0x0
  public    static  AkMeteringFlags                 AK_EnableBusMeter_RMS  // 0x0
  public    static  AkMeteringFlags                 AK_EnableBusMeter_KPower  // 0x0
  public    static  AkMeteringFlags                 AK_EnableBusMeter_3DMeter  // 0x0
METHODS:
END_CLASS

CLASS: AkMIDICcTypes
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkMIDICcTypes                   BANK_SELECT_COARSE  // 0x0
  public    static  AkMIDICcTypes                   MOD_WHEEL_COARSE  // 0x0
  public    static  AkMIDICcTypes                   BREATH_CTRL_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_3_COARSE  // 0x0
  public    static  AkMIDICcTypes                   FOOT_PEDAL_COARSE  // 0x0
  public    static  AkMIDICcTypes                   PORTAMENTO_COARSE  // 0x0
  public    static  AkMIDICcTypes                   DATA_ENTRY_COARSE  // 0x0
  public    static  AkMIDICcTypes                   VOLUME_COARSE  // 0x0
  public    static  AkMIDICcTypes                   BALANCE_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_9_COARSE  // 0x0
  public    static  AkMIDICcTypes                   PAN_POSITION_COARSE  // 0x0
  public    static  AkMIDICcTypes                   EXPRESSION_COARSE  // 0x0
  public    static  AkMIDICcTypes                   EFFECT_CTRL_1_COARSE  // 0x0
  public    static  AkMIDICcTypes                   EFFECT_CTRL_2_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_14_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_15_COARSE  // 0x0
  public    static  AkMIDICcTypes                   GEN_SLIDER_1  // 0x0
  public    static  AkMIDICcTypes                   GEN_SLIDER_2  // 0x0
  public    static  AkMIDICcTypes                   GEN_SLIDER_3  // 0x0
  public    static  AkMIDICcTypes                   GEN_SLIDER_4  // 0x0
  public    static  AkMIDICcTypes                   CTRL_20_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_21_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_22_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_23_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_24_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_25_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_26_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_27_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_28_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_29_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_30_COARSE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_31_COARSE  // 0x0
  public    static  AkMIDICcTypes                   BANK_SELECT_FINE  // 0x0
  public    static  AkMIDICcTypes                   MOD_WHEEL_FINE  // 0x0
  public    static  AkMIDICcTypes                   BREATH_CTRL_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_3_FINE  // 0x0
  public    static  AkMIDICcTypes                   FOOT_PEDAL_FINE  // 0x0
  public    static  AkMIDICcTypes                   PORTAMENTO_FINE  // 0x0
  public    static  AkMIDICcTypes                   DATA_ENTRY_FINE  // 0x0
  public    static  AkMIDICcTypes                   VOLUME_FINE  // 0x0
  public    static  AkMIDICcTypes                   BALANCE_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_9_FINE  // 0x0
  public    static  AkMIDICcTypes                   PAN_POSITION_FINE  // 0x0
  public    static  AkMIDICcTypes                   EXPRESSION_FINE  // 0x0
  public    static  AkMIDICcTypes                   EFFECT_CTRL_1_FINE  // 0x0
  public    static  AkMIDICcTypes                   EFFECT_CTRL_2_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_14_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_15_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_20_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_21_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_22_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_23_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_24_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_25_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_26_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_27_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_28_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_29_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_30_FINE  // 0x0
  public    static  AkMIDICcTypes                   CTRL_31_FINE  // 0x0
  public    static  AkMIDICcTypes                   HOLD_PEDAL  // 0x0
  public    static  AkMIDICcTypes                   PORTAMENTO_ON_OFF  // 0x0
  public    static  AkMIDICcTypes                   SUSTENUTO_PEDAL  // 0x0
  public    static  AkMIDICcTypes                   SOFT_PEDAL  // 0x0
  public    static  AkMIDICcTypes                   LEGATO_PEDAL  // 0x0
  public    static  AkMIDICcTypes                   HOLD_PEDAL_2  // 0x0
  public    static  AkMIDICcTypes                   SOUND_VARIATION  // 0x0
  public    static  AkMIDICcTypes                   SOUND_TIMBRE  // 0x0
  public    static  AkMIDICcTypes                   SOUND_RELEASE_TIME  // 0x0
  public    static  AkMIDICcTypes                   SOUND_ATTACK_TIME  // 0x0
  public    static  AkMIDICcTypes                   SOUND_BRIGHTNESS  // 0x0
  public    static  AkMIDICcTypes                   SOUND_CTRL_6  // 0x0
  public    static  AkMIDICcTypes                   SOUND_CTRL_7  // 0x0
  public    static  AkMIDICcTypes                   SOUND_CTRL_8  // 0x0
  public    static  AkMIDICcTypes                   SOUND_CTRL_9  // 0x0
  public    static  AkMIDICcTypes                   SOUND_CTRL_10  // 0x0
  public    static  AkMIDICcTypes                   GENERAL_BUTTON_1  // 0x0
  public    static  AkMIDICcTypes                   GENERAL_BUTTON_2  // 0x0
  public    static  AkMIDICcTypes                   GENERAL_BUTTON_3  // 0x0
  public    static  AkMIDICcTypes                   GENERAL_BUTTON_4  // 0x0
  public    static  AkMIDICcTypes                   REVERB_LEVEL  // 0x0
  public    static  AkMIDICcTypes                   TREMOLO_LEVEL  // 0x0
  public    static  AkMIDICcTypes                   CHORUS_LEVEL  // 0x0
  public    static  AkMIDICcTypes                   CELESTE_LEVEL  // 0x0
  public    static  AkMIDICcTypes                   PHASER_LEVEL  // 0x0
  public    static  AkMIDICcTypes                   DATA_BUTTON_P1  // 0x0
  public    static  AkMIDICcTypes                   DATA_BUTTON_M1  // 0x0
  public    static  AkMIDICcTypes                   NON_REGISTER_COARSE  // 0x0
  public    static  AkMIDICcTypes                   NON_REGISTER_FINE  // 0x0
  public    static  AkMIDICcTypes                   ALL_SOUND_OFF  // 0x0
  public    static  AkMIDICcTypes                   ALL_CONTROLLERS_OFF  // 0x0
  public    static  AkMIDICcTypes                   LOCAL_KEYBOARD  // 0x0
  public    static  AkMIDICcTypes                   ALL_NOTES_OFF  // 0x0
  public    static  AkMIDICcTypes                   OMNI_MODE_OFF  // 0x0
  public    static  AkMIDICcTypes                   OMNI_MODE_ON  // 0x0
  public    static  AkMIDICcTypes                   OMNI_MONOPHONIC_ON  // 0x0
  public    static  AkMIDICcTypes                   OMNI_POLYPHONIC_ON  // 0x0
METHODS:
END_CLASS

CLASS: tGen
TYPE:  class
TOKEN: 0x2000037
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMIDIEvent.tGen obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_byParam1(System.Byte value)
  System.Byte get_byParam1()
  System.Void set_byParam2(System.Byte value)
  System.Byte get_byParam2()
  System.Void .ctor()
END_CLASS

CLASS: tNoteOnOff
TYPE:  class
TOKEN: 0x2000038
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMIDIEvent.tNoteOnOff obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_byNote(System.Byte value)
  System.Byte get_byNote()
  System.Void set_byVelocity(System.Byte value)
  System.Byte get_byVelocity()
  System.Void .ctor()
END_CLASS

CLASS: tCc
TYPE:  class
TOKEN: 0x2000039
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMIDIEvent.tCc obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_byCc(System.Byte value)
  System.Byte get_byCc()
  System.Void set_byValue(System.Byte value)
  System.Byte get_byValue()
  System.Void .ctor()
END_CLASS

CLASS: tPitchBend
TYPE:  class
TOKEN: 0x200003A
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMIDIEvent.tPitchBend obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_byValueLsb(System.Byte value)
  System.Byte get_byValueLsb()
  System.Void set_byValueMsb(System.Byte value)
  System.Byte get_byValueMsb()
  System.Void .ctor()
END_CLASS

CLASS: tNoteAftertouch
TYPE:  class
TOKEN: 0x200003B
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMIDIEvent.tNoteAftertouch obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_byNote(System.Byte value)
  System.Byte get_byNote()
  System.Void set_byValue(System.Byte value)
  System.Byte get_byValue()
  System.Void .ctor()
END_CLASS

CLASS: tChanAftertouch
TYPE:  class
TOKEN: 0x200003C
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMIDIEvent.tChanAftertouch obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_byValue(System.Byte value)
  System.Byte get_byValue()
  System.Void .ctor()
END_CLASS

CLASS: tProgramChange
TYPE:  class
TOKEN: 0x200003D
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMIDIEvent.tProgramChange obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_byProgramNum(System.Byte value)
  System.Byte get_byProgramNum()
  System.Void .ctor()
END_CLASS

CLASS: tWwiseCmd
TYPE:  class
TOKEN: 0x200003E
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMIDIEvent.tWwiseCmd obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_uCmd(System.UInt16 value)
  System.UInt16 get_uCmd()
  System.Void set_uArg(System.UInt32 value)
  System.UInt32 get_uArg()
  System.Void .ctor()
END_CLASS

CLASS: AkMIDIEvent
TYPE:  class
TOKEN: 0x2000036
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMIDIEvent obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_byChan(System.Byte value)
  System.Byte get_byChan()
  System.Void set_Gen(AkMIDIEvent.tGen value)
  AkMIDIEvent.tGen get_Gen()
  System.Void set_Cc(AkMIDIEvent.tCc value)
  AkMIDIEvent.tCc get_Cc()
  System.Void set_NoteOnOff(AkMIDIEvent.tNoteOnOff value)
  AkMIDIEvent.tNoteOnOff get_NoteOnOff()
  System.Void set_PitchBend(AkMIDIEvent.tPitchBend value)
  AkMIDIEvent.tPitchBend get_PitchBend()
  System.Void set_NoteAftertouch(AkMIDIEvent.tNoteAftertouch value)
  AkMIDIEvent.tNoteAftertouch get_NoteAftertouch()
  System.Void set_ChanAftertouch(AkMIDIEvent.tChanAftertouch value)
  AkMIDIEvent.tChanAftertouch get_ChanAftertouch()
  System.Void set_ProgramChange(AkMIDIEvent.tProgramChange value)
  AkMIDIEvent.tProgramChange get_ProgramChange()
  System.Void set_WwiseCmd(AkMIDIEvent.tWwiseCmd value)
  AkMIDIEvent.tWwiseCmd get_WwiseCmd()
  System.Void set_byType(AkMIDIEventTypes value)
  AkMIDIEventTypes get_byType()
  System.Void set_byOnOffNote(System.Byte value)
  System.Byte get_byOnOffNote()
  System.Void set_byVelocity(System.Byte value)
  System.Byte get_byVelocity()
  System.Void set_byCc(AkMIDICcTypes value)
  AkMIDICcTypes get_byCc()
  System.Void set_byCcValue(System.Byte value)
  System.Byte get_byCcValue()
  System.Void set_byValueLsb(System.Byte value)
  System.Byte get_byValueLsb()
  System.Void set_byValueMsb(System.Byte value)
  System.Byte get_byValueMsb()
  System.Void set_byAftertouchNote(System.Byte value)
  System.Byte get_byAftertouchNote()
  System.Void set_byNoteAftertouchValue(System.Byte value)
  System.Byte get_byNoteAftertouchValue()
  System.Void set_byChanAftertouchValue(System.Byte value)
  System.Byte get_byChanAftertouchValue()
  System.Void set_byProgramNum(System.Byte value)
  System.Byte get_byProgramNum()
  System.Void set_uCmd(System.UInt16 value)
  System.UInt16 get_uCmd()
  System.Void set_uArg(System.UInt32 value)
  System.UInt32 get_uArg()
  System.Void .ctor()
END_CLASS

CLASS: AkMIDIEventCallbackInfo
TYPE:  class
TOKEN: 0x200003F
EXTENDS: AkEventCallbackInfo
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x28
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMIDIEventCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Dispose(System.Boolean disposing)
  System.Byte get_byChan()
  System.Byte get_byParam1()
  System.Byte get_byParam2()
  AkMIDIEventTypes get_byType()
  System.Byte get_byOnOffNote()
  System.Byte get_byVelocity()
  AkMIDICcTypes get_byCc()
  System.Byte get_byCcValue()
  System.Byte get_byValueLsb()
  System.Byte get_byValueMsb()
  System.Byte get_byAftertouchNote()
  System.Byte get_byNoteAftertouchValue()
  System.Byte get_byChanAftertouchValue()
  System.Byte get_byProgramNum()
  System.Void .ctor()
END_CLASS

CLASS: AkMIDIEventTypes
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkMIDIEventTypes                NOTE_OFF  // 0x0
  public    static  AkMIDIEventTypes                NOTE_ON  // 0x0
  public    static  AkMIDIEventTypes                NOTE_AFTERTOUCH  // 0x0
  public    static  AkMIDIEventTypes                CONTROLLER  // 0x0
  public    static  AkMIDIEventTypes                PROGRAM_CHANGE  // 0x0
  public    static  AkMIDIEventTypes                CHANNEL_AFTERTOUCH  // 0x0
  public    static  AkMIDIEventTypes                PITCH_BEND  // 0x0
  public    static  AkMIDIEventTypes                SYSEX  // 0x0
  public    static  AkMIDIEventTypes                ESCAPE  // 0x0
  public    static  AkMIDIEventTypes                META  // 0x0
METHODS:
END_CLASS

CLASS: AkMIDIPost
TYPE:  class
TOKEN: 0x2000041
EXTENDS: AkMIDIEvent
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x20
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMIDIPost obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Dispose(System.Boolean disposing)
  System.Void set_uOffset(System.UInt64 value)
  System.UInt64 get_uOffset()
  System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts)
  System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets)
  System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie)
  System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_playingID)
  System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts)
  System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets)
  System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie)
  System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_playingID)
  System.Void Clone(AkMIDIPost other)
  System.Int32 GetSizeOf()
  System.Void .ctor()
END_CLASS

CLASS: AkMonitorErrorCode
TYPE:  struct
TOKEN: 0x2000042
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkMonitorErrorCode              ErrorCode_NoError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_FileNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotOpenFile  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotStartStreamNoMemory  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_IODevice  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_IncompatibleIOSettings  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginUnsupportedChannelConfiguration  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginMediaUnavailable  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginInitialisationFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginProcessingFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginExecutionInvalid  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginAllocationFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_VorbisSeekTableRecommended  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_VorbisDecodeError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_ATRAC9DecodeFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_ATRAC9LoopSectionTooSmall  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_InvalidAudioFileHeader  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioFileHeaderTooLarge  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_LoopTooSmall  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TransitionNotAccurateChannel  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TransitionNotAccuratePluginMismatch  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TransitionNotAccurateRejectedByPlugin  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TransitionNotAccurateStarvation  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TransitionNotAccurateCodecError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_NothingToPlay  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PlayFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_StingerCouldNotBeScheduled  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TooLongSegmentLookAhead  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotScheduleMusicSwitch  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TooManySimultaneousMusicSegments  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PlaylistStoppedForEditing  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MusicClipsRescheduledAfterTrackEdit  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotPlaySource_Create  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotPlaySource_VirtualOff  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotPlaySource_TimeSkip  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotPlaySource_InconsistentState  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MediaNotLoaded  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_VoiceStarving  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_StreamingSourceStarving  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_XMADecoderSourceStarving  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_XMADecodingError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_InvalidXMAData  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginNotRegistered  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CodecNotRegistered  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginVersionMismatch  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_EventIDNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_InvalidGroupID  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SelectedNodeNotAvailable  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SelectedMediaNotAvailable  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_NoValidSwitch  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_BankLoadFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_ErrorWhileLoadingBank  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_InsufficientSpaceToLoadBank  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_LowerEngineCommandListFull  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SeekNoMarker  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotSeekContinuous  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SeekAfterEof  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_UnknownGameObject  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_GameObjectNeverRegistered  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_DeadGameObject  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_GameObjectIsNotEmitter  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_ExternalSourceNotResolved  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_FileFormatMismatch  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CommandQueueFull  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CommandTooLarge  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_XMACreateDecoderLimitReached  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_XMAStreamBufferTooSmall  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_ModulatorScopeError_Inst  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_ModulatorScopeError_Obj  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SeekAfterEndOfPlaylist  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_OpusRequireSeekTable  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_OpusDecodeError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SourcePluginNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_VirtualVoiceLimit  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_NotEnoughMemoryToStart  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_UnknownOpusError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioDeviceInitFailure  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioDeviceRemoveFailure  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioDeviceNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioDeviceNotValid  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SpatialAudio_ListenerAutomationNotSupported  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MediaDuplicationLength  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_HwVoicesSystemInitFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_HwVoicesDecodeBatchFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_HwVoiceLimitReached  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_HwVoiceInitFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_OpusHWCommandFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AddOutputListenerIdWithZeroListeners  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_3DObjectLimitExceeded  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_OpusHWFatalError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_OpusHWDecodeUnavailable  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_OpusHWTimeout  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SystemAudioObjectsUnavailable  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AddOutputNoDistinctListener  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginCannotRunOnObjectConfig  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SpatialAudio_ReflectionBusError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_VorbisHWDecodeUnavailable  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_ExternalSourceNoMemorySize  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MonitorQueueFull  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MonitorMsgTooLarge  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_NonCompliantDeviceMemory  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_JobWorkerFuncCallMismatch  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_JobMgrOutOfMemory  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_InvalidFileSize  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginMsg  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SinkOpenSL  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioOutOfRange  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioOutOfRangeOnBus  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioOutOfRangeOnBusFx  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioOutOfRangeRay  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_UnknownDialogueEvent  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_FailedPostingEvent  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_OutputDeviceInitializationFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_UnloadBankFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginFileNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginFileIncompatible  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginFileNotEnoughMemoryToStart  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginFileInvalid  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginFileRegisterFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_UnknownArgument  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_DynamicSequenceAlreadyClosed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PendingActionDestroyed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CrossFadeTransitionIgnored  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MusicRendererSeekingFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_DynamicSequenceIdNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_BusNotFoundByName  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioDeviceShareSetNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioDeviceShareSetNotFoundByName  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SoundEngineTooManyGameObjects  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SoundEngineTooManyPositions  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SoundEngineCantCallOnChildBus  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SoundEnginePlayingIdNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SoundEngineInvalidTransform  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SoundEngineTooManyEventPosts  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioSubsystemStoppedResponding  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_NotEnoughMemInFunction  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_FXNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetMixerNotABus  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioNodeNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetMixerFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetBusConfigUnsupported  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_BusNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MismatchingMediaSize  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_IncompatibleBankVersion  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_UnexpectedPrepareGameSyncsCall  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MusicEngineNotInitialized  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_LoadingBankMismatch  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MasterBusStructureNotLoaded  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TooManyChildren  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_BankContainUneditableEffect  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MemoryAllocationFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_InvalidFloatPriority  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SoundLoadFailedInsufficientMemory  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_NXDeviceRegistrationFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MixPluginOnObjectBus  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_XboxXMAVoiceResetFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_XboxACPMessage  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_XboxFrameDropped  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_XboxACPError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_XboxXMAFatalError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MissingMusicNodeParent  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_HardwareOpusDecoderError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetGeometryTooManyTriangleConnected  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetGeometryTriangleTooLarge  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetGeometryFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_RemovingGeometrySetFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetGeometryInstanceFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_RemovingGeometryInstanceFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_RevertingToDefaultAudioDevice  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_RevertingToDummyAudioDevice  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioThreadSuspended  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioThreadResumed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_ResetPlaylistActionIgnoredGlobalScope  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_ResetPlaylistActionIgnoredContinuous  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PlayingTriggerRateNotSupported  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetGeometryTriangleIsSkipped  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetGeometryInstanceInvalidTransform  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetGameObjectRadiusSizeError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetPortalNonDistinctRoom  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetPortalInvalidExtent  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SpatialAudio_PortalNotFound  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_InvalidFloatInFunction  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_FLTMAXNotSupported  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotInitializeAmbisonicChannelConfiguration  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotInitializePassthrough  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_3DAudioUnsupportedSize  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AmbisonicNotAvailable  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_NoAudioDevice  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_Support  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_ReplayMessage  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_GameMessage  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TestMessage  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TranslatorStandardTagTest  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TranslatorWwiseTagTest  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TranslatorStringSizeTest  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_InvalidParameter  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MaxAudioObjExceeded  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MMSNotEnabled  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_NotEnoughSystemObj  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_NotEnoughSystemObjWin  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_TransitionNotAccurateSourceTooShort  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AlreadyInitialized  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_WrongNumberOfArguments  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_DataAlignement  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_PluginMsgWithShareSet  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SoundEngineNotInit  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_NoDefaultSwitch  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CantSetBoundSwitch  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_IODeviceInitFailed  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SwitchListEmpty  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_NoSwitchSelected  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_FilePermissionError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SetEffectOnRendered  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_GeometryNotWatertight  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotInitialize3DAudio  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotInitializeInputCallbacks  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_CannotConnectAVAudioEngineSource  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_ChannelConfigRequestDenied  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MediaUpdatedFromWwise  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MediaErrorFromWwise  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_OutputAlreadyExists  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_UnknownStateGroup  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_MediaErrorWwiseMRUFull  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioOut2ContextCreateError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AudioOut2UserCreateError  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_FeedbackOnAudioObjectsBus  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_AssetSwapEnabled  // 0x0
  public    static  AkMonitorErrorCode              ErrorCode_SpatialAudio_SiblingPortal  // 0x0
  public    static  AkMonitorErrorCode              Num_ErrorCodes  // 0x0
METHODS:
END_CLASS

CLASS: AkMonitorErrorLevel
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkMonitorErrorLevel             ErrorLevel_Message  // 0x0
  public    static  AkMonitorErrorLevel             ErrorLevel_Error  // 0x0
  public    static  AkMonitorErrorLevel             ErrorLevel_All  // 0x0
METHODS:
END_CLASS

CLASS: AkMonitoringCallbackInfo
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMonitoringCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  AkMonitorErrorCode get_errorCode()
  AkMonitorErrorLevel get_errorLevel()
  System.UInt32 get_playingID()
  System.UInt64 get_gameObjID()
  System.String get_message()
  System.Void .ctor()
END_CLASS

CLASS: AkMultiPositionType
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkMultiPositionType             MultiPositionType_SingleSource  // 0x0
  public    static  AkMultiPositionType             MultiPositionType_MultiSources  // 0x0
  public    static  AkMultiPositionType             MultiPositionType_MultiDirections  // 0x0
METHODS:
END_CLASS

CLASS: AkMusicPlaylistCallbackInfo
TYPE:  class
TOKEN: 0x2000046
EXTENDS: AkEventCallbackInfo
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x28
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Dispose(System.Boolean disposing)
  System.UInt32 get_playlistID()
  System.UInt32 get_uNumPlaylistItems()
  System.UInt32 get_uPlaylistSelection()
  System.UInt32 get_uPlaylistItemDone()
  System.Void .ctor()
END_CLASS

CLASS: AkMusicSettings
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMusicSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_fStreamingLookAheadRatio(System.Single value)
  System.Single get_fStreamingLookAheadRatio()
END_CLASS

CLASS: AkMusicSyncCallbackInfo
TYPE:  class
TOKEN: 0x2000048
EXTENDS: AkCallbackInfo
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x20
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkMusicSyncCallbackInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Dispose(System.Boolean disposing)
  System.UInt32 get_playingID()
  System.Int32 get_segmentInfo_iCurrentPosition()
  System.Int32 get_segmentInfo_iPreEntryDuration()
  System.Int32 get_segmentInfo_iActiveDuration()
  System.Int32 get_segmentInfo_iPostExitDuration()
  System.Int32 get_segmentInfo_iRemainingLookAheadTime()
  System.Single get_segmentInfo_fBeatDuration()
  System.Single get_segmentInfo_fBarDuration()
  System.Single get_segmentInfo_fGridDuration()
  System.Single get_segmentInfo_fGridOffset()
  AkCallbackType get_musicSyncType()
  System.String get_userCueName()
  System.Void .ctor()
END_CLASS

CLASS: AkObjectInfo
TYPE:  class
TOKEN: 0x2000049
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkObjectInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_objID(System.UInt32 value)
  System.UInt32 get_objID()
  System.Void set_parentID(System.UInt32 value)
  System.UInt32 get_parentID()
  System.Void set_iDepth(System.Int32 value)
  System.Int32 get_iDepth()
  System.Void Clear()
  System.Int32 GetSizeOf()
  System.Void Clone(AkObjectInfo other)
  System.Void .ctor()
END_CLASS

CLASS: AkObstructionOcclusionValues
TYPE:  class
TOKEN: 0x200004A
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkObstructionOcclusionValues obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_occlusion(System.Single value)
  System.Single get_occlusion()
  System.Void set_obstruction(System.Single value)
  System.Single get_obstruction()
  System.Void Clear()
  System.Int32 GetSizeOf()
  System.Void Clone(AkObstructionOcclusionValues other)
  System.Void .ctor()
END_CLASS

CLASS: AkOutputSettings
TYPE:  class
TOKEN: 0x200004B
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkOutputSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void .ctor(System.String in_szDeviceShareSet, System.UInt32 in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning)
  System.Void .ctor(System.String in_szDeviceShareSet, System.UInt32 in_idDevice, AkChannelConfig in_channelConfig)
  System.Void .ctor(System.String in_szDeviceShareSet, System.UInt32 in_idDevice)
  System.Void .ctor(System.String in_szDeviceShareSet)
  System.Void set_audioDeviceShareset(System.UInt32 value)
  System.UInt32 get_audioDeviceShareset()
  System.Void set_idDevice(System.UInt32 value)
  System.UInt32 get_idDevice()
  System.Void set_ePanningRule(AkPanningRule value)
  AkPanningRule get_ePanningRule()
  System.Void set_channelConfig(AkChannelConfig value)
  AkChannelConfig get_channelConfig()
END_CLASS

CLASS: AkPanningRule
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkPanningRule                   AkPanningRule_Speakers  // 0x0
  public    static  AkPanningRule                   AkPanningRule_Headphones  // 0x0
METHODS:
END_CLASS

CLASS: AkPlaylist
TYPE:  class
TOKEN: 0x200004D
EXTENDS: AkPlaylistArray
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x20
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkPlaylist obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Dispose(System.Boolean disposing)
  AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay, System.IntPtr in_pCustomInfo, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
  AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay, System.IntPtr in_pCustomInfo, System.UInt32 in_cExternals)
  AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay, System.IntPtr in_pCustomInfo)
  AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay)
  AKRESULT Enqueue(System.UInt32 in_audioNodeID)
  System.Void .ctor()
END_CLASS

CLASS: AkPlaylistArray
TYPE:  class
TOKEN: 0x200004E
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkPlaylistArray obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  AkIterator Begin()
  AkIterator End()
  AkIterator FindEx(AkPlaylistItem in_Item)
  AkIterator Erase(AkIterator in_rIter)
  System.Void Erase(System.UInt32 in_uIndex)
  AkIterator EraseSwap(AkIterator in_rIter)
  System.Void EraseSwap(System.UInt32 in_uIndex)
  System.Boolean IsGrowingAllowed()
  AKRESULT Reserve(System.UInt32 in_ulReserve)
  AKRESULT ReserveExtra(System.UInt32 in_ulReserve)
  System.UInt32 Reserved()
  System.Void Term()
  System.UInt32 Length()
  AkPlaylistItem Data()
  System.Boolean IsEmpty()
  AkPlaylistItem Exists(AkPlaylistItem in_Item)
  AkPlaylistItem AddLast()
  AkPlaylistItem AddLast(AkPlaylistItem in_rItem)
  AkPlaylistItem Last()
  System.Void RemoveLast()
  AKRESULT Remove(AkPlaylistItem in_rItem)
  AKRESULT RemoveSwap(AkPlaylistItem in_rItem)
  System.Void RemoveAll()
  AkPlaylistItem ItemAtIndex(System.UInt32 uiIndex)
  AkIterator Insert(AkIterator in_rIter)
  AkPlaylistItem Insert(System.UInt32 in_uIndex)
  System.Boolean GrowArray()
  System.Boolean GrowArray(System.UInt32 in_uGrowBy)
  System.Boolean Resize(System.UInt32 in_uiSize)
  System.Void Transfer(AkPlaylistArray in_rSource)
  AKRESULT Copy(AkPlaylistArray in_rSource)
END_CLASS

CLASS: AkPlaylistItem
TYPE:  class
TOKEN: 0x200004F
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkPlaylistItem obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void .ctor(AkPlaylistItem in_rCopy)
  AkPlaylistItem Assign(AkPlaylistItem in_rCopy)
  System.Boolean IsEqualTo(AkPlaylistItem in_rCopy)
  AKRESULT SetExternalSources(System.UInt32 in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc)
  System.Void set_audioNodeID(System.UInt32 value)
  System.UInt32 get_audioNodeID()
  System.Void set_msDelay(System.Int32 value)
  System.Int32 get_msDelay()
  System.Void set_pCustomInfo(System.IntPtr value)
  System.IntPtr get_pCustomInfo()
END_CLASS

CLASS: AkPluginType
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkPluginType                    AkPluginTypeNone  // 0x0
  public    static  AkPluginType                    AkPluginTypeCodec  // 0x0
  public    static  AkPluginType                    AkPluginTypeSource  // 0x0
  public    static  AkPluginType                    AkPluginTypeEffect  // 0x0
  public    static  AkPluginType                    AkPluginTypeMixer  // 0x0
  public    static  AkPluginType                    AkPluginTypeSink  // 0x0
  public    static  AkPluginType                    AkPluginTypeGlobalExtension  // 0x0
  public    static  AkPluginType                    AkPluginTypeMetadata  // 0x0
  public    static  AkPluginType                    AkPluginTypeMask  // 0x0
METHODS:
END_CLASS

CLASS: AkPositioningData
TYPE:  class
TOKEN: 0x2000051
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkPositioningData obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_threeD(Ak3dData value)
  Ak3dData get_threeD()
  System.Void set_behavioral(AkBehavioralPositioningData value)
  AkBehavioralPositioningData get_behavioral()
  System.Void .ctor()
END_CLASS

CLASS: AkPositioningInfo
TYPE:  class
TOKEN: 0x2000052
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkPositioningInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_fCenterPct(System.Single value)
  System.Single get_fCenterPct()
  System.Void set_pannerType(AkSpeakerPanningType value)
  AkSpeakerPanningType get_pannerType()
  System.Void set_e3dPositioningType(Ak3DPositionType value)
  Ak3DPositionType get_e3dPositioningType()
  System.Void set_bHoldEmitterPosAndOrient(System.Boolean value)
  System.Boolean get_bHoldEmitterPosAndOrient()
  System.Void set_e3DSpatializationMode(Ak3DSpatializationMode value)
  Ak3DSpatializationMode get_e3DSpatializationMode()
  System.Void set_bEnableAttenuation(System.Boolean value)
  System.Boolean get_bEnableAttenuation()
  System.Void set_bUseConeAttenuation(System.Boolean value)
  System.Boolean get_bUseConeAttenuation()
  System.Void set_fInnerAngle(System.Single value)
  System.Single get_fInnerAngle()
  System.Void set_fOuterAngle(System.Single value)
  System.Single get_fOuterAngle()
  System.Void set_fConeMaxAttenuation(System.Single value)
  System.Single get_fConeMaxAttenuation()
  System.Void set_LPFCone(System.Single value)
  System.Single get_LPFCone()
  System.Void set_HPFCone(System.Single value)
  System.Single get_HPFCone()
  System.Void set_fMaxDistance(System.Single value)
  System.Single get_fMaxDistance()
  System.Void set_fVolDryAtMaxDist(System.Single value)
  System.Single get_fVolDryAtMaxDist()
  System.Void set_fVolAuxGameDefAtMaxDist(System.Single value)
  System.Single get_fVolAuxGameDefAtMaxDist()
  System.Void set_fVolAuxUserDefAtMaxDist(System.Single value)
  System.Single get_fVolAuxUserDefAtMaxDist()
  System.Void set_LPFValueAtMaxDist(System.Single value)
  System.Single get_LPFValueAtMaxDist()
  System.Void set_HPFValueAtMaxDist(System.Single value)
  System.Single get_HPFValueAtMaxDist()
  System.Void .ctor()
END_CLASS

CLASS: AkPreparationType
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkPreparationType               Preparation_Load  // 0x0
  public    static  AkPreparationType               Preparation_Unload  // 0x0
  public    static  AkPreparationType               Preparation_LoadAndDecode  // 0x0
METHODS:
END_CLASS

CLASS: AkQueryRTPCValue
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkQueryRTPCValue                RTPCValue_Default  // 0x0
  public    static  AkQueryRTPCValue                RTPCValue_Global  // 0x0
  public    static  AkQueryRTPCValue                RTPCValue_GameObject  // 0x0
  public    static  AkQueryRTPCValue                RTPCValue_PlayingID  // 0x0
  public    static  AkQueryRTPCValue                RTPCValue_Unavailable  // 0x0
METHODS:
END_CLASS

CLASS: AkRamp
TYPE:  class
TOKEN: 0x2000055
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkRamp obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void .ctor(System.Single in_fPrev, System.Single in_fNext)
  System.Void set_fPrev(System.Single value)
  System.Single get_fPrev()
  System.Void set_fNext(System.Single value)
  System.Single get_fNext()
END_CLASS

CLASS: AkReflectionPathInfo
TYPE:  class
TOKEN: 0x2000056
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkReflectionPathInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_imageSource(AkVector64 value)
  AkVector64 get_imageSource()
  System.Void set_numPathPoints(System.UInt32 value)
  System.UInt32 get_numPathPoints()
  System.Void set_numReflections(System.UInt32 value)
  System.UInt32 get_numReflections()
  System.Void set_level(System.Single value)
  System.Single get_level()
  System.Void set_isOccluded(System.Boolean value)
  System.Boolean get_isOccluded()
  System.Int32 GetSizeOf()
  UnityEngine.Vector3 GetPathPoint(System.UInt32 idx)
  AkAcousticSurface GetAcousticSurface(System.UInt32 idx)
  System.Single GetDiffraction(System.UInt32 idx)
  System.Void Clone(AkReflectionPathInfo other)
  System.Void .ctor()
END_CLASS

CLASS: AkResourceMonitorDataSummary
TYPE:  class
TOKEN: 0x2000057
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkResourceMonitorDataSummary obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_totalCPU(System.Single value)
  System.Single get_totalCPU()
  System.Void set_pluginCPU(System.Single value)
  System.Single get_pluginCPU()
  System.Void set_physicalVoices(System.UInt32 value)
  System.UInt32 get_physicalVoices()
  System.Void set_virtualVoices(System.UInt32 value)
  System.UInt32 get_virtualVoices()
  System.Void set_totalVoices(System.UInt32 value)
  System.UInt32 get_totalVoices()
  System.Void set_nbActiveEvents(System.UInt32 value)
  System.UInt32 get_nbActiveEvents()
  System.Void .ctor()
END_CLASS

CLASS: AKRESULT
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AKRESULT                        AK_NotImplemented  // 0x0
  public    static  AKRESULT                        AK_Success  // 0x0
  public    static  AKRESULT                        AK_Fail  // 0x0
  public    static  AKRESULT                        AK_PartialSuccess  // 0x0
  public    static  AKRESULT                        AK_NotCompatible  // 0x0
  public    static  AKRESULT                        AK_AlreadyConnected  // 0x0
  public    static  AKRESULT                        AK_InvalidFile  // 0x0
  public    static  AKRESULT                        AK_AudioFileHeaderTooLarge  // 0x0
  public    static  AKRESULT                        AK_MaxReached  // 0x0
  public    static  AKRESULT                        AK_InvalidID  // 0x0
  public    static  AKRESULT                        AK_IDNotFound  // 0x0
  public    static  AKRESULT                        AK_InvalidInstanceID  // 0x0
  public    static  AKRESULT                        AK_NoMoreData  // 0x0
  public    static  AKRESULT                        AK_InvalidStateGroup  // 0x0
  public    static  AKRESULT                        AK_ChildAlreadyHasAParent  // 0x0
  public    static  AKRESULT                        AK_InvalidLanguage  // 0x0
  public    static  AKRESULT                        AK_CannotAddItselfAsAChild  // 0x0
  public    static  AKRESULT                        AK_InvalidParameter  // 0x0
  public    static  AKRESULT                        AK_ElementAlreadyInList  // 0x0
  public    static  AKRESULT                        AK_PathNotFound  // 0x0
  public    static  AKRESULT                        AK_PathNoVertices  // 0x0
  public    static  AKRESULT                        AK_PathNotRunning  // 0x0
  public    static  AKRESULT                        AK_PathNotPaused  // 0x0
  public    static  AKRESULT                        AK_PathNodeAlreadyInList  // 0x0
  public    static  AKRESULT                        AK_PathNodeNotInList  // 0x0
  public    static  AKRESULT                        AK_DataNeeded  // 0x0
  public    static  AKRESULT                        AK_NoDataNeeded  // 0x0
  public    static  AKRESULT                        AK_DataReady  // 0x0
  public    static  AKRESULT                        AK_NoDataReady  // 0x0
  public    static  AKRESULT                        AK_InsufficientMemory  // 0x0
  public    static  AKRESULT                        AK_Cancelled  // 0x0
  public    static  AKRESULT                        AK_UnknownBankID  // 0x0
  public    static  AKRESULT                        AK_BankReadError  // 0x0
  public    static  AKRESULT                        AK_InvalidSwitchType  // 0x0
  public    static  AKRESULT                        AK_FormatNotReady  // 0x0
  public    static  AKRESULT                        AK_WrongBankVersion  // 0x0
  public    static  AKRESULT                        AK_FileNotFound  // 0x0
  public    static  AKRESULT                        AK_DeviceNotReady  // 0x0
  public    static  AKRESULT                        AK_BankAlreadyLoaded  // 0x0
  public    static  AKRESULT                        AK_RenderedFX  // 0x0
  public    static  AKRESULT                        AK_ProcessNeeded  // 0x0
  public    static  AKRESULT                        AK_ProcessDone  // 0x0
  public    static  AKRESULT                        AK_MemManagerNotInitialized  // 0x0
  public    static  AKRESULT                        AK_StreamMgrNotInitialized  // 0x0
  public    static  AKRESULT                        AK_SSEInstructionsNotSupported  // 0x0
  public    static  AKRESULT                        AK_Busy  // 0x0
  public    static  AKRESULT                        AK_UnsupportedChannelConfig  // 0x0
  public    static  AKRESULT                        AK_PluginMediaNotAvailable  // 0x0
  public    static  AKRESULT                        AK_MustBeVirtualized  // 0x0
  public    static  AKRESULT                        AK_CommandTooLarge  // 0x0
  public    static  AKRESULT                        AK_RejectedByFilter  // 0x0
  public    static  AKRESULT                        AK_InvalidCustomPlatformName  // 0x0
  public    static  AKRESULT                        AK_DLLCannotLoad  // 0x0
  public    static  AKRESULT                        AK_DLLPathNotFound  // 0x0
  public    static  AKRESULT                        AK_NoJavaVM  // 0x0
  public    static  AKRESULT                        AK_OpenSLError  // 0x0
  public    static  AKRESULT                        AK_PluginNotRegistered  // 0x0
  public    static  AKRESULT                        AK_DataAlignmentError  // 0x0
  public    static  AKRESULT                        AK_DeviceNotCompatible  // 0x0
  public    static  AKRESULT                        AK_DuplicateUniqueID  // 0x0
  public    static  AKRESULT                        AK_InitBankNotLoaded  // 0x0
  public    static  AKRESULT                        AK_DeviceNotFound  // 0x0
  public    static  AKRESULT                        AK_PlayingIDNotFound  // 0x0
  public    static  AKRESULT                        AK_InvalidFloatValue  // 0x0
  public    static  AKRESULT                        AK_FileFormatMismatch  // 0x0
  public    static  AKRESULT                        AK_NoDistinctListener  // 0x0
  public    static  AKRESULT                        AK_ACP_Error  // 0x0
  public    static  AKRESULT                        AK_ResourceInUse  // 0x0
  public    static  AKRESULT                        AK_InvalidBankType  // 0x0
  public    static  AKRESULT                        AK_AlreadyInitialized  // 0x0
  public    static  AKRESULT                        AK_NotInitialized  // 0x0
  public    static  AKRESULT                        AK_FilePermissionError  // 0x0
  public    static  AKRESULT                        AK_UnknownFileError  // 0x0
  public    static  AKRESULT                        AK_TooManyConcurrentOperations  // 0x0
  public    static  AKRESULT                        AK_InvalidFileSize  // 0x0
  public    static  AKRESULT                        AK_Deferred  // 0x0
  public    static  AKRESULT                        AK_FilePathTooLong  // 0x0
  public    static  AKRESULT                        AK_InvalidState  // 0x0
METHODS:
END_CLASS

CLASS: AkRoomParams
TYPE:  class
TOKEN: 0x2000059
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkRoomParams obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void set_Front(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_Front()
  System.Void set_Up(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_Up()
  System.Void set_ReverbAuxBus(System.UInt32 value)
  System.UInt32 get_ReverbAuxBus()
  System.Void set_ReverbLevel(System.Single value)
  System.Single get_ReverbLevel()
  System.Void set_TransmissionLoss(System.Single value)
  System.Single get_TransmissionLoss()
  System.Void set_RoomGameObj_AuxSendLevelToSelf(System.Single value)
  System.Single get_RoomGameObj_AuxSendLevelToSelf()
  System.Void set_RoomGameObj_KeepRegistered(System.Boolean value)
  System.Boolean get_RoomGameObj_KeepRegistered()
  System.Void set_RoomPriority(System.UInt32 value)
  System.UInt32 get_RoomPriority()
END_CLASS

CLASS: AkSegmentInfo
TYPE:  class
TOKEN: 0x200005A
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkSegmentInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_iCurrentPosition(System.Int32 value)
  System.Int32 get_iCurrentPosition()
  System.Void set_iPreEntryDuration(System.Int32 value)
  System.Int32 get_iPreEntryDuration()
  System.Void set_iActiveDuration(System.Int32 value)
  System.Int32 get_iActiveDuration()
  System.Void set_iPostExitDuration(System.Int32 value)
  System.Int32 get_iPostExitDuration()
  System.Void set_iRemainingLookAheadTime(System.Int32 value)
  System.Int32 get_iRemainingLookAheadTime()
  System.Void set_fBeatDuration(System.Single value)
  System.Single get_fBeatDuration()
  System.Void set_fBarDuration(System.Single value)
  System.Single get_fBarDuration()
  System.Void set_fGridDuration(System.Single value)
  System.Single get_fGridDuration()
  System.Void set_fGridOffset(System.Single value)
  System.Single get_fGridOffset()
  System.Void .ctor()
END_CLASS

CLASS: AkSerializedCallbackHeader
TYPE:  class
TOKEN: 0x200005B
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkSerializedCallbackHeader obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.IntPtr get_pPackage()
  System.UInt32 get_eType()
  System.IntPtr GetData()
  AkSerializedCallbackHeader get_pNext()
  System.Void .ctor()
END_CLASS

CLASS: AkSetPositionFlags
TYPE:  struct
TOKEN: 0x200005C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkSetPositionFlags              AkSetPositionFlags_Emitter  // 0x0
  public    static  AkSetPositionFlags              AkSetPositionFlags_Listener  // 0x0
  public    static  AkSetPositionFlags              AkSetPositionFlags_Default  // 0x0
METHODS:
END_CLASS

CLASS: AkSourceChannelOrdering
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkSourceChannelOrdering         SourceChannelOrdering_Standard  // 0x0
  public    static  AkSourceChannelOrdering         SourceChannelOrdering_Film  // 0x0
  public    static  AkSourceChannelOrdering         SourceChannelOrdering_FuMa  // 0x0
  public    static  AkSourceChannelOrdering         SourceChannelOrdering_Last  // 0x0
METHODS:
END_CLASS

CLASS: AkSourceSettings
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkSourceSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_sourceID(System.UInt32 value)
  System.UInt32 get_sourceID()
  System.Void set_pMediaMemory(System.IntPtr value)
  System.IntPtr get_pMediaMemory()
  System.Void set_uMediaSize(System.UInt32 value)
  System.UInt32 get_uMediaSize()
  System.Void Clear()
  System.Int32 GetSizeOf()
  System.Void Clone(AkSourceSettings other)
  System.Void .ctor()
END_CLASS

CLASS: AkSpatialAudioInitSettings
TYPE:  class
TOKEN: 0x200005F
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkSpatialAudioInitSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void set_uMaxSoundPropagationDepth(System.UInt32 value)
  System.UInt32 get_uMaxSoundPropagationDepth()
  System.Void set_fMovementThreshold(System.Single value)
  System.Single get_fMovementThreshold()
  System.Void set_uNumberOfPrimaryRays(System.UInt32 value)
  System.UInt32 get_uNumberOfPrimaryRays()
  System.Void set_uMaxReflectionOrder(System.UInt32 value)
  System.UInt32 get_uMaxReflectionOrder()
  System.Void set_uMaxDiffractionOrder(System.UInt32 value)
  System.UInt32 get_uMaxDiffractionOrder()
  System.Void set_uMaxEmitterRoomAuxSends(System.UInt32 value)
  System.UInt32 get_uMaxEmitterRoomAuxSends()
  System.Void set_uDiffractionOnReflectionsOrder(System.UInt32 value)
  System.UInt32 get_uDiffractionOnReflectionsOrder()
  System.Void set_fMaxPathLength(System.Single value)
  System.Single get_fMaxPathLength()
  System.Void set_fCPULimitPercentage(System.Single value)
  System.Single get_fCPULimitPercentage()
  System.Void set_uLoadBalancingSpread(System.UInt32 value)
  System.UInt32 get_uLoadBalancingSpread()
  System.Void set_bEnableGeometricDiffractionAndTransmission(System.Boolean value)
  System.Boolean get_bEnableGeometricDiffractionAndTransmission()
  System.Void set_bCalcEmitterVirtualPosition(System.Boolean value)
  System.Boolean get_bCalcEmitterVirtualPosition()
END_CLASS

CLASS: AkSpeakerPanningType
TYPE:  struct
TOKEN: 0x2000060
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkSpeakerPanningType            AK_DirectSpeakerAssignment  // 0x0
  public    static  AkSpeakerPanningType            AK_BalanceFadeHeight  // 0x0
  public    static  AkSpeakerPanningType            AK_SteeringPanner  // 0x0
METHODS:
END_CLASS

CLASS: AkStdMovePolicy
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkStdMovePolicy obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean IsTrivial()
  System.Void .ctor()
END_CLASS

CLASS: AkStreamMgrSettings
TYPE:  class
TOKEN: 0x2000062
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkStreamMgrSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: AkTransform
TYPE:  class
TOKEN: 0x2000063
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkTransform obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  UnityEngine.Vector3 Position()
  UnityEngine.Vector3 OrientationFront()
  UnityEngine.Vector3 OrientationTop()
  System.Void Set(UnityEngine.Vector3 in_position, UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop)
  System.Void Set(System.Single in_positionX, System.Single in_positionY, System.Single in_positionZ, System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ)
  System.Void SetPosition(UnityEngine.Vector3 in_position)
  System.Void SetPosition(System.Single in_x, System.Single in_y, System.Single in_z)
  System.Void SetOrientation(UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop)
  System.Void SetOrientation(System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ)
  System.Void .ctor()
END_CLASS

CLASS: AkTriangle
TYPE:  class
TOKEN: 0x2000064
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkTriangle obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void .ctor(System.UInt16 in_pt0, System.UInt16 in_pt1, System.UInt16 in_pt2, System.UInt16 in_surfaceInfo)
  System.Void set_point0(System.UInt16 value)
  System.UInt16 get_point0()
  System.Void set_point1(System.UInt16 value)
  System.UInt16 get_point1()
  System.Void set_point2(System.UInt16 value)
  System.UInt16 get_point2()
  System.Void set_surface(System.UInt16 value)
  System.UInt16 get_surface()
  System.Void Clear()
  System.Int32 GetSizeOf()
  System.Void Clone(AkTriangle other)
END_CLASS

CLASS: AkTrivialStdMovePolicy
TYPE:  class
TOKEN: 0x2000065
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkTrivialStdMovePolicy obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean IsTrivial()
  System.Void .ctor()
END_CLASS

CLASS: AkWorldTransform
TYPE:  class
TOKEN: 0x2000066
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkWorldTransform obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  AkVector64 Position()
  UnityEngine.Vector3 OrientationFront()
  UnityEngine.Vector3 OrientationTop()
  System.Void Set(AkVector64 in_position, UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop)
  System.Void Set(System.Double in_positionX, System.Double in_positionY, System.Double in_positionZ, System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ)
  System.Void SetPosition(AkVector64 in_position)
  System.Void SetPosition(System.Double in_x, System.Double in_y, System.Double in_z)
  System.Void SetOrientation(UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop)
  System.Void SetOrientation(System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ)
  System.Void .ctor()
END_CLASS

CLASS: MonitorErrorInfo
TYPE:  class
TOKEN: 0x2000067
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(MonitorErrorInfo obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor(System.String in_name, System.String in_message)
  System.Void .ctor(System.String in_name)
  System.Void .ctor()
  System.Void set_m_name(System.String value)
  System.String get_m_name()
  System.Void set_m_message(System.String value)
  System.String get_m_message()
END_CLASS

CLASS: MsgContext
TYPE:  class
TOKEN: 0x2000068
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(MsgContext obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor(System.UInt32 pId, System.UInt64 goId, System.UInt32 nodeId, System.Boolean isBus)
  System.Void .ctor(System.UInt32 pId, System.UInt64 goId, System.UInt32 nodeId)
  System.Void .ctor(System.UInt32 pId, System.UInt64 goId)
  System.Void .ctor(System.UInt32 pId)
  System.Void .ctor()
  System.Void set_in_playingID(System.UInt32 value)
  System.UInt32 get_in_playingID()
  System.Void set_in_gameObjID(System.UInt64 value)
  System.UInt64 get_in_gameObjID()
  System.Void set_in_soundID(System.UInt32 value)
  System.UInt32 get_in_soundID()
  System.Void set_in_bIsBus(System.Boolean value)
  System.Boolean get_in_bIsBus()
END_CLASS

CLASS: AkCommSystem
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkCommunicationSettings.AkCommSystemAkCommSystem_Socket  // 0x0
  public    static  AkCommunicationSettings.AkCommSystemAkCommSystem_HTCS  // 0x0
METHODS:
END_CLASS

CLASS: AkCommunicationSettings
TYPE:  class
TOKEN: 0x2000069
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkCommunicationSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void set_uPoolSize(System.UInt32 value)
  System.UInt32 get_uPoolSize()
  System.Void set_uDiscoveryBroadcastPort(System.UInt16 value)
  System.UInt16 get_uDiscoveryBroadcastPort()
  System.Void set_uCommandPort(System.UInt16 value)
  System.UInt16 get_uCommandPort()
  System.Void set_commSystem(AkCommunicationSettings.AkCommSystem value)
  AkCommunicationSettings.AkCommSystem get_commSystem()
  System.Void set_bInitSystemLib(System.Boolean value)
  System.Boolean get_bInitSystemLib()
  System.Void set_szAppNetworkName(System.String value)
  System.String get_szAppNetworkName()
END_CLASS

CLASS: AkPlatformInitSettings
TYPE:  class
TOKEN: 0x200006B
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkPlatformInitSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_threadLEngine(AkThreadProperties value)
  AkThreadProperties get_threadLEngine()
  System.Void set_threadOutputMgr(AkThreadProperties value)
  AkThreadProperties get_threadOutputMgr()
  System.Void set_threadBankManager(AkThreadProperties value)
  AkThreadProperties get_threadBankManager()
  System.Void set_threadMonitor(AkThreadProperties value)
  AkThreadProperties get_threadMonitor()
  System.Void set_uNumRefillsInVoice(System.UInt16 value)
  System.UInt16 get_uNumRefillsInVoice()
  System.Void set_uSampleRate(System.UInt32 value)
  System.UInt32 get_uSampleRate()
  System.Void set_bEnableAvxSupport(System.Boolean value)
  System.Boolean get_bEnableAvxSupport()
  System.Void set_uMaxSystemAudioObjects(System.UInt32 value)
  System.UInt32 get_uMaxSystemAudioObjects()
  System.Void set_bEnableDirectInputSupport(System.Boolean value)
  System.Boolean get_bEnableDirectInputSupport()
END_CLASS

CLASS: AkSoundEnginePINVOKE
TYPE:  class
TOKEN: 0x200006C
FIELDS:
METHODS:
  System.Void .cctor()
  System.UInt32 CSharp_JoystickIdToWwiseId(System.UInt32 jarg1)
  System.UInt32 CSharp_AK_INVALID_SHARE_SET_ID_get()
  System.UInt32 CSharp_AK_INVALID_PIPELINE_ID_get()
  System.UInt64 CSharp_AK_INVALID_AUDIO_OBJECT_ID_get()
  System.UInt32 CSharp_AK_SOUNDBANK_VERSION_get()
  System.UInt32 CSharp_AkJobType_Generic_get()
  System.UInt32 CSharp_AkJobType_AudioProcessing_get()
  System.UInt32 CSharp_AkJobType_SpatialAudio_get()
  System.UInt32 CSharp_AK_NUM_JOB_TYPES_get()
  System.Void CSharp_AkAudioSettings_uNumSamplesPerFrame_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkAudioSettings_uNumSamplesPerFrame_get(System.IntPtr jarg1)
  System.Void CSharp_AkAudioSettings_uNumSamplesPerSecond_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkAudioSettings_uNumSamplesPerSecond_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkAudioSettings()
  System.Void CSharp_delete_AkAudioSettings(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceDescription_idDevice_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkDeviceDescription_idDevice_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceDescription_deviceName_set(System.IntPtr jarg1, System.String jarg2)
  System.IntPtr CSharp_AkDeviceDescription_deviceName_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceDescription_deviceStateMask_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkDeviceDescription_deviceStateMask_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceDescription_isDefaultDevice_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkDeviceDescription_isDefaultDevice_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceDescription_Clear(System.IntPtr jarg1)
  System.Int32 CSharp_AkDeviceDescription_GetSizeOf()
  System.Void CSharp_AkDeviceDescription_Clone(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_new_AkDeviceDescription()
  System.Void CSharp_delete_AkDeviceDescription(System.IntPtr jarg1)
  AkVector64 CSharp_AkWorldTransform_Position(System.IntPtr jarg1)
  UnityEngine.Vector3 CSharp_AkWorldTransform_OrientationFront(System.IntPtr jarg1)
  UnityEngine.Vector3 CSharp_AkWorldTransform_OrientationTop(System.IntPtr jarg1)
  System.Void CSharp_AkWorldTransform_Set__SWIG_0(System.IntPtr jarg1, AkVector64 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4)
  System.Void CSharp_AkWorldTransform_Set__SWIG_1(System.IntPtr jarg1, System.Double jarg2, System.Double jarg3, System.Double jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7, System.Single jarg8, System.Single jarg9, System.Single jarg10)
  System.Void CSharp_AkWorldTransform_SetPosition__SWIG_0(System.IntPtr jarg1, AkVector64 jarg2)
  System.Void CSharp_AkWorldTransform_SetPosition__SWIG_1(System.IntPtr jarg1, System.Double jarg2, System.Double jarg3, System.Double jarg4)
  System.Void CSharp_AkWorldTransform_SetOrientation__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3)
  System.Void CSharp_AkWorldTransform_SetOrientation__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7)
  System.IntPtr CSharp_new_AkWorldTransform()
  System.Void CSharp_delete_AkWorldTransform(System.IntPtr jarg1)
  UnityEngine.Vector3 CSharp_AkTransform_Position(System.IntPtr jarg1)
  UnityEngine.Vector3 CSharp_AkTransform_OrientationFront(System.IntPtr jarg1)
  UnityEngine.Vector3 CSharp_AkTransform_OrientationTop(System.IntPtr jarg1)
  System.Void CSharp_AkTransform_Set__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4)
  System.Void CSharp_AkTransform_Set__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7, System.Single jarg8, System.Single jarg9, System.Single jarg10)
  System.Void CSharp_AkTransform_SetPosition__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2)
  System.Void CSharp_AkTransform_SetPosition__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4)
  System.Void CSharp_AkTransform_SetOrientation__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3)
  System.Void CSharp_AkTransform_SetOrientation__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7)
  System.IntPtr CSharp_new_AkTransform()
  System.Void CSharp_delete_AkTransform(System.IntPtr jarg1)
  UnityEngine.Vector3 CSharp_ConvertAkVector64ToAkVector(AkVector64 jarg1)
  System.IntPtr CSharp_ConvertAkWorldTransformToAkTransform(System.IntPtr jarg1)
  AkVector64 CSharp_ConvertAkVectorToAkVector64(UnityEngine.Vector3 jarg1)
  System.IntPtr CSharp_ConvertAkTransformToAkWorldTransform(System.IntPtr jarg1)
  System.Void CSharp_AkObstructionOcclusionValues_occlusion_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkObstructionOcclusionValues_occlusion_get(System.IntPtr jarg1)
  System.Void CSharp_AkObstructionOcclusionValues_obstruction_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkObstructionOcclusionValues_obstruction_get(System.IntPtr jarg1)
  System.Void CSharp_AkObstructionOcclusionValues_Clear(System.IntPtr jarg1)
  System.Int32 CSharp_AkObstructionOcclusionValues_GetSizeOf()
  System.Void CSharp_AkObstructionOcclusionValues_Clone(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_new_AkObstructionOcclusionValues()
  System.Void CSharp_delete_AkObstructionOcclusionValues(System.IntPtr jarg1)
  System.Void CSharp_AkChannelEmitter_position_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkChannelEmitter_position_get(System.IntPtr jarg1)
  System.Void CSharp_AkChannelEmitter_uInputChannels_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkChannelEmitter_uInputChannels_get(System.IntPtr jarg1)
  System.Void CSharp_AkChannelEmitter_padding_set(System.IntPtr jarg1, System.String jarg2)
  System.IntPtr CSharp_AkChannelEmitter_padding_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkChannelEmitter(System.IntPtr jarg1)
  System.Void CSharp_AkAuxSendValue_listenerID_set(System.IntPtr jarg1, System.UInt64 jarg2)
  System.UInt64 CSharp_AkAuxSendValue_listenerID_get(System.IntPtr jarg1)
  System.Void CSharp_AkAuxSendValue_auxBusID_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkAuxSendValue_auxBusID_get(System.IntPtr jarg1)
  System.Void CSharp_AkAuxSendValue_fControlValue_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkAuxSendValue_fControlValue_get(System.IntPtr jarg1)
  System.Void CSharp_AkAuxSendValue_Set(System.IntPtr jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Single jarg4)
  System.Boolean CSharp_AkAuxSendValue_IsSame(System.IntPtr jarg1, System.UInt64 jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_AkAuxSendValue_GetSizeOf()
  System.Void CSharp_delete_AkAuxSendValue(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkRamp__SWIG_0()
  System.IntPtr CSharp_new_AkRamp__SWIG_1(System.Single jarg1, System.Single jarg2)
  System.Void CSharp_AkRamp_fPrev_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkRamp_fPrev_get(System.IntPtr jarg1)
  System.Void CSharp_AkRamp_fNext_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkRamp_fNext_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkRamp(System.IntPtr jarg1)
  System.UInt16 CSharp_AK_INT_get()
  System.UInt16 CSharp_AK_FLOAT_get()
  System.Byte CSharp_AK_INTERLEAVED_get()
  System.Byte CSharp_AK_NONINTERLEAVED_get()
  System.UInt32 CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get()
  System.UInt32 CSharp_AK_LE_NATIVE_SAMPLETYPE_get()
  System.UInt32 CSharp_AK_LE_NATIVE_INTERLEAVE_get()
  System.Void CSharp_AkAudioFormat_uSampleRate_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkAudioFormat_uSampleRate_get(System.IntPtr jarg1)
  System.Void CSharp_AkAudioFormat_channelConfig_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkAudioFormat_channelConfig_get(System.IntPtr jarg1)
  System.Void CSharp_AkAudioFormat_uBitsPerSample_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkAudioFormat_uBitsPerSample_get(System.IntPtr jarg1)
  System.Void CSharp_AkAudioFormat_uBlockAlign_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkAudioFormat_uBlockAlign_get(System.IntPtr jarg1)
  System.Void CSharp_AkAudioFormat_uTypeID_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkAudioFormat_uTypeID_get(System.IntPtr jarg1)
  System.Void CSharp_AkAudioFormat_uInterleaveID_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkAudioFormat_uInterleaveID_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkAudioFormat_GetNumChannels(System.IntPtr jarg1)
  System.UInt32 CSharp_AkAudioFormat_GetBitsPerSample(System.IntPtr jarg1)
  System.UInt32 CSharp_AkAudioFormat_GetBlockAlign(System.IntPtr jarg1)
  System.UInt32 CSharp_AkAudioFormat_GetTypeID(System.IntPtr jarg1)
  System.UInt32 CSharp_AkAudioFormat_GetInterleaveID(System.IntPtr jarg1)
  System.Void CSharp_AkAudioFormat_SetAll(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.UInt32 jarg4, System.UInt32 jarg5, System.UInt32 jarg6, System.UInt32 jarg7)
  System.IntPtr CSharp_new_AkAudioFormat()
  System.Void CSharp_delete_AkAudioFormat(System.IntPtr jarg1)
  System.Boolean CSharp_IsBankCodecID(System.UInt32 jarg1)
  System.IntPtr CSharp_new_Ak3dData()
  System.Void CSharp_Ak3dData_xform_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_Ak3dData_xform_get(System.IntPtr jarg1)
  System.Void CSharp_Ak3dData_spread_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_Ak3dData_spread_get(System.IntPtr jarg1)
  System.Void CSharp_Ak3dData_focus_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_Ak3dData_focus_get(System.IntPtr jarg1)
  System.Void CSharp_Ak3dData_uEmitterChannelMask_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_Ak3dData_uEmitterChannelMask_get(System.IntPtr jarg1)
  System.Void CSharp_delete_Ak3dData(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkBehavioralPositioningData()
  System.Void CSharp_AkBehavioralPositioningData_center_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkBehavioralPositioningData_center_get(System.IntPtr jarg1)
  System.Void CSharp_AkBehavioralPositioningData_panLR_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkBehavioralPositioningData_panLR_get(System.IntPtr jarg1)
  System.Void CSharp_AkBehavioralPositioningData_panBF_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkBehavioralPositioningData_panBF_get(System.IntPtr jarg1)
  System.Void CSharp_AkBehavioralPositioningData_panDU_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkBehavioralPositioningData_panDU_get(System.IntPtr jarg1)
  System.Void CSharp_AkBehavioralPositioningData_panSpatMix_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkBehavioralPositioningData_panSpatMix_get(System.IntPtr jarg1)
  System.Void CSharp_AkBehavioralPositioningData_spatMode_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkBehavioralPositioningData_spatMode_get(System.IntPtr jarg1)
  System.Void CSharp_AkBehavioralPositioningData_panType_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkBehavioralPositioningData_panType_get(System.IntPtr jarg1)
  System.Void CSharp_AkBehavioralPositioningData_enableHeightSpread_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkBehavioralPositioningData_enableHeightSpread_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkBehavioralPositioningData(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningData_threeD_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkPositioningData_threeD_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningData_behavioral_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkPositioningData_behavioral_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkPositioningData()
  System.Void CSharp_delete_AkPositioningData(System.IntPtr jarg1)
  System.Void CSharp_Ak3DAudioSinkCapabilities_channelConfig_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_Ak3DAudioSinkCapabilities_channelConfig_get(System.IntPtr jarg1)
  System.Void CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_get(System.IntPtr jarg1)
  System.Void CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_get(System.IntPtr jarg1)
  System.Void CSharp_Ak3DAudioSinkCapabilities_bPassthrough_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_Ak3DAudioSinkCapabilities_bPassthrough_get(System.IntPtr jarg1)
  System.Void CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_Ak3DAudioSinkCapabilities()
  System.Void CSharp_delete_Ak3DAudioSinkCapabilities(System.IntPtr jarg1)
  System.Void CSharp_AkIterator_pItem_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkIterator_pItem_get(System.IntPtr jarg1)
  System.IntPtr CSharp_AkIterator_NextIter(System.IntPtr jarg1)
  System.IntPtr CSharp_AkIterator_PrevIter(System.IntPtr jarg1)
  System.IntPtr CSharp_AkIterator_GetItem(System.IntPtr jarg1)
  System.Boolean CSharp_AkIterator_IsEqualTo(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Boolean CSharp_AkIterator_IsDifferentFrom(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_new_AkIterator()
  System.Void CSharp_delete_AkIterator(System.IntPtr jarg1)
  System.Boolean CSharp_AkStdMovePolicy_IsTrivial()
  System.IntPtr CSharp_new_AkStdMovePolicy()
  System.Void CSharp_delete_AkStdMovePolicy(System.IntPtr jarg1)
  System.Boolean CSharp_AkTrivialStdMovePolicy_IsTrivial()
  System.IntPtr CSharp_new_AkTrivialStdMovePolicy()
  System.Void CSharp_delete_AkTrivialStdMovePolicy(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkPlaylistItem__SWIG_0()
  System.IntPtr CSharp_new_AkPlaylistItem__SWIG_1(System.IntPtr jarg1)
  System.Void CSharp_delete_AkPlaylistItem(System.IntPtr jarg1)
  System.IntPtr CSharp_AkPlaylistItem_Assign(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Boolean CSharp_AkPlaylistItem_IsEqualTo(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_AkPlaylistItem_SetExternalSources(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3)
  System.Void CSharp_AkPlaylistItem_audioNodeID_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkPlaylistItem_audioNodeID_get(System.IntPtr jarg1)
  System.Void CSharp_AkPlaylistItem_msDelay_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkPlaylistItem_msDelay_get(System.IntPtr jarg1)
  System.Void CSharp_AkPlaylistItem_pCustomInfo_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkPlaylistItem_pCustomInfo_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkPlaylistArray()
  System.Void CSharp_delete_AkPlaylistArray(System.IntPtr jarg1)
  System.IntPtr CSharp_AkPlaylistArray_Begin(System.IntPtr jarg1)
  System.IntPtr CSharp_AkPlaylistArray_End(System.IntPtr jarg1)
  System.IntPtr CSharp_AkPlaylistArray_FindEx(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkPlaylistArray_Erase__SWIG_0(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Void CSharp_AkPlaylistArray_Erase__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2)
  System.IntPtr CSharp_AkPlaylistArray_EraseSwap__SWIG_0(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Void CSharp_AkPlaylistArray_EraseSwap__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Boolean CSharp_AkPlaylistArray_IsGrowingAllowed(System.IntPtr jarg1)
  System.Int32 CSharp_AkPlaylistArray_Reserve(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_AkPlaylistArray_ReserveExtra(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkPlaylistArray_Reserved(System.IntPtr jarg1)
  System.Void CSharp_AkPlaylistArray_Term(System.IntPtr jarg1)
  System.UInt32 CSharp_AkPlaylistArray_Length(System.IntPtr jarg1)
  System.IntPtr CSharp_AkPlaylistArray_Data(System.IntPtr jarg1)
  System.Boolean CSharp_AkPlaylistArray_IsEmpty(System.IntPtr jarg1)
  System.IntPtr CSharp_AkPlaylistArray_Exists(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_0(System.IntPtr jarg1)
  System.IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_1(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkPlaylistArray_Last(System.IntPtr jarg1)
  System.Void CSharp_AkPlaylistArray_RemoveLast(System.IntPtr jarg1)
  System.Int32 CSharp_AkPlaylistArray_Remove(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_AkPlaylistArray_RemoveSwap(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Void CSharp_AkPlaylistArray_RemoveAll(System.IntPtr jarg1)
  System.IntPtr CSharp_AkPlaylistArray_ItemAtIndex(System.IntPtr jarg1, System.UInt32 jarg2)
  System.IntPtr CSharp_AkPlaylistArray_Insert__SWIG_0(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkPlaylistArray_Insert__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Boolean CSharp_AkPlaylistArray_GrowArray__SWIG_0(System.IntPtr jarg1)
  System.Boolean CSharp_AkPlaylistArray_GrowArray__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Boolean CSharp_AkPlaylistArray_Resize(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Void CSharp_AkPlaylistArray_Transfer(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_AkPlaylistArray_Copy(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.IntPtr jarg4, System.UInt32 jarg5, System.IntPtr jarg6)
  System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.IntPtr jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.IntPtr jarg4)
  System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_4(System.IntPtr jarg1, System.UInt32 jarg2)
  System.IntPtr CSharp_new_AkPlaylist()
  System.Void CSharp_delete_AkPlaylist(System.IntPtr jarg1)
  System.UInt32 CSharp_DynamicSequenceOpen__SWIG_0(System.UInt64 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5)
  System.UInt32 CSharp_DynamicSequenceOpen__SWIG_1(System.UInt64 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4)
  System.UInt32 CSharp_DynamicSequenceOpen__SWIG_2(System.UInt64 jarg1)
  System.Int32 CSharp_DynamicSequenceClose(System.UInt32 jarg1)
  System.Int32 CSharp_DynamicSequencePlay__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_DynamicSequencePlay__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2)
  System.Int32 CSharp_DynamicSequencePlay__SWIG_2(System.UInt32 jarg1)
  System.Int32 CSharp_DynamicSequencePause__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_DynamicSequencePause__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2)
  System.Int32 CSharp_DynamicSequencePause__SWIG_2(System.UInt32 jarg1)
  System.Int32 CSharp_DynamicSequenceResume__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_DynamicSequenceResume__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2)
  System.Int32 CSharp_DynamicSequenceResume__SWIG_2(System.UInt32 jarg1)
  System.Int32 CSharp_DynamicSequenceStop__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_DynamicSequenceStop__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2)
  System.Int32 CSharp_DynamicSequenceStop__SWIG_2(System.UInt32 jarg1)
  System.Int32 CSharp_DynamicSequenceBreak(System.UInt32 jarg1)
  System.Int32 CSharp_Seek__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Boolean jarg3)
  System.Int32 CSharp_Seek__SWIG_1(System.UInt32 jarg1, System.Single jarg2, System.Boolean jarg3)
  System.Int32 CSharp_DynamicSequenceGetPauseTimes(System.UInt32 jarg1, System.UInt32& jarg2, System.UInt32& jarg3)
  System.IntPtr CSharp_DynamicSequenceLockPlaylist(System.UInt32 jarg1)
  System.Int32 CSharp_DynamicSequenceUnlockPlaylist(System.UInt32 jarg1)
  System.IntPtr CSharp_new_AkOutputSettings__SWIG_0()
  System.IntPtr CSharp_new_AkOutputSettings__SWIG_1(System.String jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.Int32 jarg4)
  System.IntPtr CSharp_new_AkOutputSettings__SWIG_2(System.String jarg1, System.UInt32 jarg2, System.IntPtr jarg3)
  System.IntPtr CSharp_new_AkOutputSettings__SWIG_3(System.String jarg1, System.UInt32 jarg2)
  System.IntPtr CSharp_new_AkOutputSettings__SWIG_4(System.String jarg1)
  System.Void CSharp_AkOutputSettings_audioDeviceShareset_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkOutputSettings_audioDeviceShareset_get(System.IntPtr jarg1)
  System.Void CSharp_AkOutputSettings_idDevice_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkOutputSettings_idDevice_get(System.IntPtr jarg1)
  System.Void CSharp_AkOutputSettings_ePanningRule_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkOutputSettings_ePanningRule_get(System.IntPtr jarg1)
  System.Void CSharp_AkOutputSettings_channelConfig_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkOutputSettings_channelConfig_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkOutputSettings(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_uMaxNumPaths_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkInitSettings_uMaxNumPaths_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_uCommandQueueSize_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkInitSettings_uCommandQueueSize_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_bEnableGameSyncPreparation_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkInitSettings_bEnableGameSyncPreparation_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_uNumSamplesPerFrame_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkInitSettings_uNumSamplesPerFrame_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_uMonitorQueuePoolSize_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkInitSettings_uMonitorQueuePoolSize_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_settingsMainOutput_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkInitSettings_settingsMainOutput_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_bUseSoundBankMgrThread_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkInitSettings_bUseSoundBankMgrThread_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_bUseLEngineThread_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkInitSettings_bUseLEngineThread_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_szPluginDLLPath_set(System.IntPtr jarg1, System.String jarg2)
  System.IntPtr CSharp_AkInitSettings_szPluginDLLPath_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_eFloorPlane_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkInitSettings_eFloorPlane_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_fGameUnitsToMeters_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkInitSettings_fGameUnitsToMeters_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_uBankReadBufferSize_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkInitSettings_uBankReadBufferSize_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_fDebugOutOfRangeLimit_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkInitSettings_fDebugOutOfRangeLimit_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkInitSettings(System.IntPtr jarg1)
  System.Void CSharp_AkSourceSettings_sourceID_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkSourceSettings_sourceID_get(System.IntPtr jarg1)
  System.Void CSharp_AkSourceSettings_pMediaMemory_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkSourceSettings_pMediaMemory_get(System.IntPtr jarg1)
  System.Void CSharp_AkSourceSettings_uMediaSize_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkSourceSettings_uMediaSize_get(System.IntPtr jarg1)
  System.Void CSharp_AkSourceSettings_Clear(System.IntPtr jarg1)
  System.Int32 CSharp_AkSourceSettings_GetSizeOf()
  System.Void CSharp_AkSourceSettings_Clone(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_new_AkSourceSettings()
  System.Void CSharp_delete_AkSourceSettings(System.IntPtr jarg1)
  System.Boolean CSharp_IsInitialized()
  System.Int32 CSharp_GetAudioSettings(System.IntPtr jarg1)
  System.IntPtr CSharp_GetSpeakerConfiguration__SWIG_0(System.UInt64 jarg1)
  System.IntPtr CSharp_GetSpeakerConfiguration__SWIG_1()
  System.Int32 CSharp_GetOutputDeviceConfiguration(System.UInt64 jarg1, System.IntPtr jarg2, System.IntPtr jarg3)
  System.Int32 CSharp_GetPanningRule__SWIG_0(System.Int32& jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_GetPanningRule__SWIG_1(System.Int32& jarg1)
  System.Int32 CSharp_SetPanningRule__SWIG_0(System.Int32 jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_SetPanningRule__SWIG_1(System.Int32 jarg1)
  System.Int32 CSharp_GetSpeakerAngles__SWIG_0(System.Single[] jarg1, System.UInt32& jarg2, System.Single& jarg3, System.UInt64 jarg4)
  System.Int32 CSharp_GetSpeakerAngles__SWIG_1(System.Single[] jarg1, System.UInt32& jarg2, System.Single& jarg3)
  System.Int32 CSharp_SetSpeakerAngles__SWIG_0(System.Single[] jarg1, System.UInt32 jarg2, System.Single jarg3, System.UInt64 jarg4)
  System.Int32 CSharp_SetSpeakerAngles__SWIG_1(System.Single[] jarg1, System.UInt32 jarg2, System.Single jarg3)
  System.Int32 CSharp_SetVolumeThreshold(System.Single jarg1)
  System.Int32 CSharp_SetMaxNumVoicesLimit(System.UInt16 jarg1)
  System.Int32 CSharp_SetJobMgrMaxActiveWorkers(System.UInt32 jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_RenderAudio__SWIG_0(System.Boolean jarg1)
  System.Int32 CSharp_RenderAudio__SWIG_1()
  System.Int32 CSharp_RegisterPluginDLL__SWIG_0(System.String jarg1, System.String jarg2)
  System.Int32 CSharp_RegisterPluginDLL__SWIG_1(System.String jarg1)
  System.Boolean CSharp_IsPluginRegistered(System.Int32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3)
  System.UInt32 CSharp_GetIDFromString__SWIG_0(System.String jarg1)
  System.UInt32 CSharp_PostEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.UInt32 jarg8)
  System.UInt32 CSharp_PostEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7)
  System.UInt32 CSharp_PostEvent__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5)
  System.UInt32 CSharp_PostEvent__SWIG_3(System.UInt32 jarg1, System.UInt64 jarg2)
  System.UInt32 CSharp_PostEvent__SWIG_4(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.UInt32 jarg8)
  System.UInt32 CSharp_PostEvent__SWIG_5(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7)
  System.UInt32 CSharp_PostEvent__SWIG_6(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5)
  System.UInt32 CSharp_PostEvent__SWIG_7(System.String jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_ExecuteActionOnEvent__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.UInt32 jarg6)
  System.Int32 CSharp_ExecuteActionOnEvent__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5)
  System.Int32 CSharp_ExecuteActionOnEvent__SWIG_2(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_ExecuteActionOnEvent__SWIG_3(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3)
  System.Int32 CSharp_ExecuteActionOnEvent__SWIG_4(System.UInt32 jarg1, System.Int32 jarg2)
  System.Int32 CSharp_ExecuteActionOnEvent__SWIG_5(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.UInt32 jarg6)
  System.Int32 CSharp_ExecuteActionOnEvent__SWIG_6(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5)
  System.Int32 CSharp_ExecuteActionOnEvent__SWIG_7(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_ExecuteActionOnEvent__SWIG_8(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3)
  System.Int32 CSharp_ExecuteActionOnEvent__SWIG_9(System.String jarg1, System.Int32 jarg2)
  System.UInt32 CSharp_PostMIDIOnEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8, System.UInt32 jarg9)
  System.UInt32 CSharp_PostMIDIOnEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8)
  System.UInt32 CSharp_PostMIDIOnEvent__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4, System.Boolean jarg5)
  System.UInt32 CSharp_PostMIDIOnEvent__SWIG_3(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4)
  System.Int32 CSharp_StopMIDIOnEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_StopMIDIOnEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_StopMIDIOnEvent__SWIG_2(System.UInt32 jarg1)
  System.Int32 CSharp_StopMIDIOnEvent__SWIG_3()
  System.Int32 CSharp_PinEventInStreamCache__SWIG_0(System.UInt32 jarg1, System.SByte jarg2, System.SByte jarg3)
  System.Int32 CSharp_PinEventInStreamCache__SWIG_1(System.String jarg1, System.SByte jarg2, System.SByte jarg3)
  System.Int32 CSharp_UnpinEventInStreamCache__SWIG_0(System.UInt32 jarg1)
  System.Int32 CSharp_UnpinEventInStreamCache__SWIG_1(System.String jarg1)
  System.Int32 CSharp_GetBufferStatusForPinnedEvent__SWIG_0(System.UInt32 jarg1, System.Single& jarg2, System.Int32& jarg3)
  System.Int32 CSharp_GetBufferStatusForPinnedEvent__SWIG_1(System.String jarg1, System.Single& jarg2, System.Int32& jarg3)
  System.Int32 CSharp_SeekOnEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_SeekOnEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4)
  System.Int32 CSharp_SeekOnEvent__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_SeekOnEvent__SWIG_3(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_SeekOnEvent__SWIG_4(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4)
  System.Int32 CSharp_SeekOnEvent__SWIG_5(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_SeekOnEvent__SWIG_9(System.UInt32 jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_SeekOnEvent__SWIG_10(System.UInt32 jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4)
  System.Int32 CSharp_SeekOnEvent__SWIG_11(System.UInt32 jarg1, System.UInt64 jarg2, System.Single jarg3)
  System.Int32 CSharp_SeekOnEvent__SWIG_12(System.String jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_SeekOnEvent__SWIG_13(System.String jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4)
  System.Int32 CSharp_SeekOnEvent__SWIG_14(System.String jarg1, System.UInt64 jarg2, System.Single jarg3)
  System.Void CSharp_CancelEventCallbackCookie(System.IntPtr jarg1)
  System.Void CSharp_CancelEventCallbackGameObject(System.UInt64 jarg1)
  System.Void CSharp_CancelEventCallback(System.UInt32 jarg1)
  System.Int32 CSharp_GetSourcePlayPosition__SWIG_0(System.UInt32 jarg1, System.Int32& jarg2, System.Boolean jarg3)
  System.Int32 CSharp_GetSourcePlayPosition__SWIG_1(System.UInt32 jarg1, System.Int32& jarg2)
  System.Int32 CSharp_GetSourceStreamBuffering(System.UInt32 jarg1, System.Int32& jarg2, System.Int32& jarg3)
  System.Void CSharp_StopAll__SWIG_0(System.UInt64 jarg1)
  System.Void CSharp_StopAll__SWIG_1()
  System.Void CSharp_StopPlayingID__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3)
  System.Void CSharp_StopPlayingID__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2)
  System.Void CSharp_StopPlayingID__SWIG_2(System.UInt32 jarg1)
  System.Void CSharp_ExecuteActionOnPlayingID__SWIG_0(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4)
  System.Void CSharp_ExecuteActionOnPlayingID__SWIG_1(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3)
  System.Void CSharp_ExecuteActionOnPlayingID__SWIG_2(System.Int32 jarg1, System.UInt32 jarg2)
  System.Void CSharp_SetRandomSeed(System.UInt32 jarg1)
  System.Void CSharp_MuteBackgroundMusic(System.Boolean jarg1)
  System.Boolean CSharp_GetBackgroundMusicMute()
  System.Int32 CSharp_SendPluginCustomGameData(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.UInt32 jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.UInt32 jarg7)
  System.Int32 CSharp_UnregisterAllGameObj()
  System.Int32 CSharp_SetMultiplePositions__SWIG_0(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4, System.Int32 jarg5)
  System.Int32 CSharp_SetMultiplePositions__SWIG_1(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_SetMultiplePositions__SWIG_2(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3)
  System.Int32 CSharp_SetMultiplePositions__SWIG_3(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4, System.Int32 jarg5)
  System.Int32 CSharp_SetMultiplePositions__SWIG_4(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_SetMultiplePositions__SWIG_5(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3)
  System.Int32 CSharp_SetScalingFactor(System.UInt64 jarg1, System.Single jarg2)
  System.Int32 CSharp_SetDistanceProbe(System.UInt64 jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_ClearBanks()
  System.Int32 CSharp_SetBankLoadIOSettings(System.Single jarg1, System.SByte jarg2)
  System.Int32 CSharp_LoadBank__SWIG_0(System.String jarg1, System.UInt32& jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_LoadBank__SWIG_1(System.String jarg1, System.UInt32& jarg2)
  System.Int32 CSharp_LoadBank__SWIG_4(System.UInt32 jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_LoadBank__SWIG_5(System.UInt32 jarg1)
  System.Int32 CSharp_LoadBankMemoryView__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3)
  System.Int32 CSharp_LoadBankMemoryView__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3, System.UInt32& jarg4)
  System.Int32 CSharp_LoadBankMemoryCopy__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3)
  System.Int32 CSharp_LoadBankMemoryCopy__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3, System.UInt32& jarg4)
  System.Int32 CSharp_LoadBank__SWIG_6(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.UInt32& jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_LoadBank__SWIG_7(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.UInt32& jarg4)
  System.Int32 CSharp_LoadBank__SWIG_10(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.UInt32 jarg4)
  System.Int32 CSharp_LoadBank__SWIG_11(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3)
  System.Int32 CSharp_LoadBankMemoryView__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5)
  System.Int32 CSharp_LoadBankMemoryView__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5, System.UInt32& jarg6)
  System.Int32 CSharp_LoadBankMemoryCopy__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5)
  System.Int32 CSharp_LoadBankMemoryCopy__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5, System.UInt32& jarg6)
  System.Int32 CSharp_UnloadBank__SWIG_0(System.String jarg1, System.IntPtr jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_UnloadBank__SWIG_1(System.String jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_UnloadBank__SWIG_4(System.UInt32 jarg1, System.IntPtr jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_UnloadBank__SWIG_5(System.UInt32 jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_UnloadBank__SWIG_6(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_UnloadBank__SWIG_7(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4)
  System.Int32 CSharp_UnloadBank__SWIG_10(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_UnloadBank__SWIG_11(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4)
  System.Void CSharp_CancelBankCallbackCookie(System.IntPtr jarg1)
  System.Int32 CSharp_PrepareBank__SWIG_0(System.Int32 jarg1, System.String jarg2, System.Int32 jarg3, System.UInt32 jarg4)
  System.Int32 CSharp_PrepareBank__SWIG_1(System.Int32 jarg1, System.String jarg2, System.Int32 jarg3)
  System.Int32 CSharp_PrepareBank__SWIG_2(System.Int32 jarg1, System.String jarg2)
  System.Int32 CSharp_PrepareBank__SWIG_6(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.UInt32 jarg4)
  System.Int32 CSharp_PrepareBank__SWIG_7(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_PrepareBank__SWIG_8(System.Int32 jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_PrepareBank__SWIG_9(System.Int32 jarg1, System.String jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5, System.UInt32 jarg6)
  System.Int32 CSharp_PrepareBank__SWIG_10(System.Int32 jarg1, System.String jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5)
  System.Int32 CSharp_PrepareBank__SWIG_11(System.Int32 jarg1, System.String jarg2, System.IntPtr jarg3, System.IntPtr jarg4)
  System.Int32 CSharp_PrepareBank__SWIG_15(System.Int32 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5, System.UInt32 jarg6)
  System.Int32 CSharp_PrepareBank__SWIG_16(System.Int32 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5)
  System.Int32 CSharp_PrepareBank__SWIG_17(System.Int32 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4)
  System.Int32 CSharp_ClearPreparedEvents()
  System.Int32 CSharp_PrepareEvent__SWIG_0(System.Int32 jarg1, System.IntPtr jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_PrepareEvent__SWIG_1(System.Int32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_PrepareEvent__SWIG_2(System.Int32 jarg1, System.IntPtr jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5)
  System.Int32 CSharp_PrepareEvent__SWIG_3(System.Int32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5)
  System.Int32 CSharp_SetMedia(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_UnsetMedia(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_PrepareGameSyncs__SWIG_0(System.Int32 jarg1, System.Int32 jarg2, System.String jarg3, System.IntPtr jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_PrepareGameSyncs__SWIG_1(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt32[] jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_PrepareGameSyncs__SWIG_2(System.Int32 jarg1, System.Int32 jarg2, System.String jarg3, System.IntPtr jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.IntPtr jarg7)
  System.Int32 CSharp_PrepareGameSyncs__SWIG_3(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt32[] jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.IntPtr jarg7)
  System.Int32 CSharp_AddListener(System.UInt64 jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_RemoveListener(System.UInt64 jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_AddDefaultListener(System.UInt64 jarg1)
  System.Int32 CSharp_RemoveDefaultListener(System.UInt64 jarg1)
  System.Int32 CSharp_ResetListenersToDefault(System.UInt64 jarg1)
  System.Int32 CSharp_SetListenerSpatialization__SWIG_0(System.UInt64 jarg1, System.Boolean jarg2, System.IntPtr jarg3, System.Single[] jarg4)
  System.Int32 CSharp_SetListenerSpatialization__SWIG_1(System.UInt64 jarg1, System.Boolean jarg2, System.IntPtr jarg3)
  System.Int32 CSharp_SetRTPCValue__SWIG_0(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6)
  System.Int32 CSharp_SetRTPCValue__SWIG_1(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5)
  System.Int32 CSharp_SetRTPCValue__SWIG_2(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_SetRTPCValue__SWIG_3(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3)
  System.Int32 CSharp_SetRTPCValue__SWIG_4(System.UInt32 jarg1, System.Single jarg2)
  System.Int32 CSharp_SetRTPCValue__SWIG_5(System.String jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6)
  System.Int32 CSharp_SetRTPCValue__SWIG_6(System.String jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5)
  System.Int32 CSharp_SetRTPCValue__SWIG_7(System.String jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_SetRTPCValue__SWIG_8(System.String jarg1, System.Single jarg2, System.UInt64 jarg3)
  System.Int32 CSharp_SetRTPCValue__SWIG_9(System.String jarg1, System.Single jarg2)
  System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_0(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6)
  System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_1(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5)
  System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_2(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_3(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_4(System.String jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6)
  System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_5(System.String jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5)
  System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_6(System.String jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_7(System.String jarg1, System.Single jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_ResetRTPCValue__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5)
  System.Int32 CSharp_ResetRTPCValue__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_ResetRTPCValue__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_ResetRTPCValue__SWIG_3(System.UInt32 jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_ResetRTPCValue__SWIG_4(System.UInt32 jarg1)
  System.Int32 CSharp_ResetRTPCValue__SWIG_5(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5)
  System.Int32 CSharp_ResetRTPCValue__SWIG_6(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_ResetRTPCValue__SWIG_7(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_ResetRTPCValue__SWIG_8(System.String jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_ResetRTPCValue__SWIG_9(System.String jarg1)
  System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5)
  System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_2(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_3(System.UInt32 jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_4(System.String jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5)
  System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_5(System.String jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4)
  System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_6(System.String jarg1, System.UInt32 jarg2, System.Int32 jarg3)
  System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_7(System.String jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_SetSwitch__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt64 jarg3)
  System.Int32 CSharp_SetSwitch__SWIG_1(System.String jarg1, System.String jarg2, System.UInt64 jarg3)
  System.Int32 CSharp_PostTrigger__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_PostTrigger__SWIG_1(System.String jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_SetState__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_SetState__SWIG_1(System.String jarg1, System.String jarg2)
  System.Int32 CSharp_SetGameObjectAuxSendValues(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_SetGameObjectOutputBusVolume(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3)
  System.Int32 CSharp_SetActorMixerEffect(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_SetBusEffect__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_SetBusEffect__SWIG_1(System.String jarg1, System.UInt32 jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_SetOutputDeviceEffect(System.UInt64 jarg1, System.UInt32 jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_SetMixer__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_SetMixer__SWIG_1(System.String jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_SetBusConfig__SWIG_0(System.UInt32 jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_SetBusConfig__SWIG_1(System.String jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_SetObjectObstructionAndOcclusion(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3, System.Single jarg4)
  System.Int32 CSharp_SetMultipleObstructionAndOcclusion(System.UInt64 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt32 jarg4)
  System.Int32 CSharp_StartOutputCapture(System.String jarg1)
  System.Int32 CSharp_StopOutputCapture()
  System.Int32 CSharp_AddOutputCaptureMarker(System.String jarg1)
  System.Int32 CSharp_AddOutputCaptureBinaryMarker(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_GetSampleRate()
  System.Int32 CSharp_StartProfilerCapture(System.String jarg1)
  System.Int32 CSharp_StopProfilerCapture()
  System.Int32 CSharp_SetOfflineRenderingFrameTime(System.Single jarg1)
  System.Int32 CSharp_SetOfflineRendering(System.Boolean jarg1)
  System.Int32 CSharp_RemoveOutput(System.UInt64 jarg1)
  System.Int32 CSharp_ReplaceOutput__SWIG_0(System.IntPtr jarg1, System.UInt64 jarg2, System.UInt64& jarg3)
  System.Int32 CSharp_ReplaceOutput__SWIG_1(System.IntPtr jarg1, System.UInt64 jarg2)
  System.UInt64 CSharp_GetOutputID__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2)
  System.UInt64 CSharp_GetOutputID__SWIG_1(System.String jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_SetBusDevice__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_SetBusDevice__SWIG_1(System.String jarg1, System.String jarg2)
  System.Int32 CSharp_GetDeviceList__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32& jarg3, System.IntPtr jarg4)
  System.Int32 CSharp_GetDeviceList__SWIG_1(System.UInt32 jarg1, System.UInt32& jarg2, System.IntPtr jarg3)
  System.Int32 CSharp_SetOutputVolume(System.UInt64 jarg1, System.Single jarg2)
  System.Int32 CSharp_GetDeviceSpatialAudioSupport(System.UInt32 jarg1)
  System.Int32 CSharp_Suspend__SWIG_0(System.Boolean jarg1, System.Boolean jarg2)
  System.Int32 CSharp_Suspend__SWIG_1(System.Boolean jarg1)
  System.Int32 CSharp_Suspend__SWIG_2()
  System.Int32 CSharp_WakeupFromSuspend__SWIG_0(System.UInt32 jarg1)
  System.Int32 CSharp_WakeupFromSuspend__SWIG_1()
  System.UInt32 CSharp_GetBufferTick()
  System.UInt64 CSharp_GetSampleTick()
  System.Void CSharp_AkSegmentInfo_iCurrentPosition_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkSegmentInfo_iCurrentPosition_get(System.IntPtr jarg1)
  System.Void CSharp_AkSegmentInfo_iPreEntryDuration_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkSegmentInfo_iPreEntryDuration_get(System.IntPtr jarg1)
  System.Void CSharp_AkSegmentInfo_iActiveDuration_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkSegmentInfo_iActiveDuration_get(System.IntPtr jarg1)
  System.Void CSharp_AkSegmentInfo_iPostExitDuration_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkSegmentInfo_iPostExitDuration_get(System.IntPtr jarg1)
  System.Void CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(System.IntPtr jarg1)
  System.Void CSharp_AkSegmentInfo_fBeatDuration_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkSegmentInfo_fBeatDuration_get(System.IntPtr jarg1)
  System.Void CSharp_AkSegmentInfo_fBarDuration_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkSegmentInfo_fBarDuration_get(System.IntPtr jarg1)
  System.Void CSharp_AkSegmentInfo_fGridDuration_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkSegmentInfo_fGridDuration_get(System.IntPtr jarg1)
  System.Void CSharp_AkSegmentInfo_fGridOffset_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkSegmentInfo_fGridOffset_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkSegmentInfo()
  System.Void CSharp_delete_AkSegmentInfo(System.IntPtr jarg1)
  System.Void CSharp_AkResourceMonitorDataSummary_totalCPU_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkResourceMonitorDataSummary_totalCPU_get(System.IntPtr jarg1)
  System.Void CSharp_AkResourceMonitorDataSummary_pluginCPU_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkResourceMonitorDataSummary_pluginCPU_get(System.IntPtr jarg1)
  System.Void CSharp_AkResourceMonitorDataSummary_physicalVoices_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkResourceMonitorDataSummary_physicalVoices_get(System.IntPtr jarg1)
  System.Void CSharp_AkResourceMonitorDataSummary_virtualVoices_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkResourceMonitorDataSummary_virtualVoices_get(System.IntPtr jarg1)
  System.Void CSharp_AkResourceMonitorDataSummary_totalVoices_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkResourceMonitorDataSummary_totalVoices_get(System.IntPtr jarg1)
  System.Void CSharp_AkResourceMonitorDataSummary_nbActiveEvents_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkResourceMonitorDataSummary_nbActiveEvents_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkResourceMonitorDataSummary()
  System.Void CSharp_delete_AkResourceMonitorDataSummary(System.IntPtr jarg1)
  System.Byte CSharp_AK_INVALID_MIDI_CHANNEL_get()
  System.Byte CSharp_AK_INVALID_MIDI_NOTE_get()
  System.Void CSharp_AkMIDIEvent_byChan_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_byChan_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tGen_byParam1_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tGen_byParam1_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tGen_byParam2_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tGen_byParam2_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMIDIEvent_tGen()
  System.Void CSharp_delete_AkMIDIEvent_tGen(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMIDIEvent_tNoteOnOff()
  System.Void CSharp_delete_AkMIDIEvent_tNoteOnOff(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tCc_byCc_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tCc_byCc_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tCc_byValue_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tCc_byValue_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMIDIEvent_tCc()
  System.Void CSharp_delete_AkMIDIEvent_tCc(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMIDIEvent_tPitchBend()
  System.Void CSharp_delete_AkMIDIEvent_tPitchBend(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMIDIEvent_tNoteAftertouch()
  System.Void CSharp_delete_AkMIDIEvent_tNoteAftertouch(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMIDIEvent_tChanAftertouch()
  System.Void CSharp_delete_AkMIDIEvent_tChanAftertouch(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMIDIEvent_tProgramChange()
  System.Void CSharp_delete_AkMIDIEvent_tProgramChange(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tWwiseCmd_uCmd_set(System.IntPtr jarg1, System.UInt16 jarg2)
  System.UInt16 CSharp_AkMIDIEvent_tWwiseCmd_uCmd_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_tWwiseCmd_uArg_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkMIDIEvent_tWwiseCmd_uArg_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMIDIEvent_tWwiseCmd()
  System.Void CSharp_delete_AkMIDIEvent_tWwiseCmd(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_Gen_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkMIDIEvent_Gen_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_Cc_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkMIDIEvent_Cc_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_NoteOnOff_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkMIDIEvent_NoteOnOff_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_PitchBend_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkMIDIEvent_PitchBend_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_NoteAftertouch_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkMIDIEvent_NoteAftertouch_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_ChanAftertouch_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkMIDIEvent_ChanAftertouch_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_ProgramChange_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkMIDIEvent_ProgramChange_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_WwiseCmd_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkMIDIEvent_WwiseCmd_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_byType_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkMIDIEvent_byType_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_byOnOffNote_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_byOnOffNote_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_byVelocity_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_byVelocity_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_byCc_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkMIDIEvent_byCc_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_byCcValue_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_byCcValue_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_byValueLsb_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_byValueLsb_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_byValueMsb_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_byValueMsb_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_byAftertouchNote_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_byAftertouchNote_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_byNoteAftertouchValue_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_byNoteAftertouchValue_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_byChanAftertouchValue_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_byChanAftertouchValue_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_byProgramNum_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkMIDIEvent_byProgramNum_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_uCmd_set(System.IntPtr jarg1, System.UInt16 jarg2)
  System.UInt16 CSharp_AkMIDIEvent_uCmd_get(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIEvent_uArg_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkMIDIEvent_uArg_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMIDIEvent()
  System.Void CSharp_delete_AkMIDIEvent(System.IntPtr jarg1)
  System.Void CSharp_AkMIDIPost_uOffset_set(System.IntPtr jarg1, System.UInt64 jarg2)
  System.UInt64 CSharp_AkMIDIPost_uOffset_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4)
  System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4, System.Boolean jarg5)
  System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8)
  System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8, System.UInt32 jarg9)
  System.Void CSharp_AkMIDIPost_Clone(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_AkMIDIPost_GetSizeOf()
  System.IntPtr CSharp_new_AkMIDIPost()
  System.Void CSharp_delete_AkMIDIPost(System.IntPtr jarg1)
  System.Void CSharp_AkMemCategroyStats_uUsed_set(System.IntPtr jarg1, System.UInt64 jarg2)
  System.UInt64 CSharp_AkMemCategroyStats_uUsed_get(System.IntPtr jarg1)
  System.Void CSharp_AkMemCategroyStats_uPeakUsed_set(System.IntPtr jarg1, System.UInt64 jarg2)
  System.UInt64 CSharp_AkMemCategroyStats_uPeakUsed_get(System.IntPtr jarg1)
  System.Void CSharp_AkMemCategroyStats_uAllocs_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkMemCategroyStats_uAllocs_get(System.IntPtr jarg1)
  System.Void CSharp_AkMemCategroyStats_uFrees_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkMemCategroyStats_uFrees_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMemCategroyStats()
  System.Void CSharp_delete_AkMemCategroyStats(System.IntPtr jarg1)
  System.Void CSharp_AkMemGlobalStats_uUsed_set(System.IntPtr jarg1, System.UInt64 jarg2)
  System.UInt64 CSharp_AkMemGlobalStats_uUsed_get(System.IntPtr jarg1)
  System.Void CSharp_AkMemGlobalStats_uDeviceUsed_set(System.IntPtr jarg1, System.UInt64 jarg2)
  System.UInt64 CSharp_AkMemGlobalStats_uDeviceUsed_get(System.IntPtr jarg1)
  System.Void CSharp_AkMemGlobalStats_uReserved_set(System.IntPtr jarg1, System.UInt64 jarg2)
  System.UInt64 CSharp_AkMemGlobalStats_uReserved_get(System.IntPtr jarg1)
  System.Void CSharp_AkMemGlobalStats_uMax_set(System.IntPtr jarg1, System.UInt64 jarg2)
  System.UInt64 CSharp_AkMemGlobalStats_uMax_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMemGlobalStats()
  System.Void CSharp_delete_AkMemGlobalStats(System.IntPtr jarg1)
  System.Void CSharp_AkMemGetCategoryStats(System.Int32 jarg1, System.IntPtr jarg2)
  System.Void CSharp_AkMemGetGlobalStats(System.IntPtr jarg1)
  System.Void CSharp_StartProfileThreadUsage()
  System.UInt64 CSharp_StopProfileThreadUsage()
  System.Void CSharp_DumpToFile(System.String jarg1)
  System.UInt64 CSharp_GetGlobalUsed()
  System.UInt64 CSharp_GetGlobalReserved()
  System.Void CSharp_AkMusicSettings_fStreamingLookAheadRatio_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkMusicSettings_fStreamingLookAheadRatio_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkMusicSettings(System.IntPtr jarg1)
  System.Int32 CSharp_GetPlayingSegmentInfo__SWIG_0(System.UInt32 jarg1, System.IntPtr jarg2, System.Boolean jarg3)
  System.Int32 CSharp_GetPlayingSegmentInfo__SWIG_1(System.UInt32 jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkSerializedCallbackHeader_pPackage_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkSerializedCallbackHeader_eType_get(System.IntPtr jarg1)
  System.IntPtr CSharp_AkSerializedCallbackHeader_GetData(System.IntPtr jarg1)
  System.IntPtr CSharp_AkSerializedCallbackHeader_pNext_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkSerializedCallbackHeader()
  System.Void CSharp_delete_AkSerializedCallbackHeader(System.IntPtr jarg1)
  System.IntPtr CSharp_AkCallbackInfo_pCookie_get(System.IntPtr jarg1)
  System.UInt64 CSharp_AkCallbackInfo_gameObjID_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkCallbackInfo()
  System.Void CSharp_delete_AkCallbackInfo(System.IntPtr jarg1)
  System.UInt32 CSharp_AkEventCallbackInfo_playingID_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkEventCallbackInfo_eventID_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkEventCallbackInfo()
  System.Void CSharp_delete_AkEventCallbackInfo(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byChan_get(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byParam1_get(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byParam2_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkMIDIEventCallbackInfo_byType_get(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byVelocity_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkMIDIEventCallbackInfo_byCc_get(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byCcValue_get(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(System.IntPtr jarg1)
  System.Byte CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMIDIEventCallbackInfo()
  System.Void CSharp_delete_AkMIDIEventCallbackInfo(System.IntPtr jarg1)
  System.UInt32 CSharp_AkMarkerCallbackInfo_uIdentifier_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkMarkerCallbackInfo_uPosition_get(System.IntPtr jarg1)
  System.IntPtr CSharp_AkMarkerCallbackInfo_strLabel_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMarkerCallbackInfo()
  System.Void CSharp_delete_AkMarkerCallbackInfo(System.IntPtr jarg1)
  System.Single CSharp_AkDurationCallbackInfo_fDuration_get(System.IntPtr jarg1)
  System.Single CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkDurationCallbackInfo_audioNodeID_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkDurationCallbackInfo_mediaID_get(System.IntPtr jarg1)
  System.Boolean CSharp_AkDurationCallbackInfo_bStreaming_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkDurationCallbackInfo()
  System.Void CSharp_delete_AkDurationCallbackInfo(System.IntPtr jarg1)
  System.UInt32 CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(System.IntPtr jarg1)
  System.IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkDynamicSequenceItemCallbackInfo()
  System.Void CSharp_delete_AkDynamicSequenceItemCallbackInfo(System.IntPtr jarg1)
  System.UInt32 CSharp_AkMusicSyncCallbackInfo_playingID_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(System.IntPtr jarg1)
  System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(System.IntPtr jarg1)
  System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(System.IntPtr jarg1)
  System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(System.IntPtr jarg1)
  System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(System.IntPtr jarg1)
  System.IntPtr CSharp_AkMusicSyncCallbackInfo_userCueName_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMusicSyncCallbackInfo()
  System.Void CSharp_delete_AkMusicSyncCallbackInfo(System.IntPtr jarg1)
  System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMusicPlaylistCallbackInfo()
  System.Void CSharp_delete_AkMusicPlaylistCallbackInfo(System.IntPtr jarg1)
  System.UInt32 CSharp_AkBankCallbackInfo_bankID_get(System.IntPtr jarg1)
  System.IntPtr CSharp_AkBankCallbackInfo_inMemoryBankPtr_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkBankCallbackInfo_loadResult_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkBankCallbackInfo()
  System.Void CSharp_delete_AkBankCallbackInfo(System.IntPtr jarg1)
  System.Int32 CSharp_AkMonitoringCallbackInfo_errorCode_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkMonitoringCallbackInfo_errorLevel_get(System.IntPtr jarg1)
  System.UInt32 CSharp_AkMonitoringCallbackInfo_playingID_get(System.IntPtr jarg1)
  System.UInt64 CSharp_AkMonitoringCallbackInfo_gameObjID_get(System.IntPtr jarg1)
  System.IntPtr CSharp_AkMonitoringCallbackInfo_message_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkMonitoringCallbackInfo()
  System.Void CSharp_delete_AkMonitoringCallbackInfo(System.IntPtr jarg1)
  System.Boolean CSharp_AkAudioInterruptionCallbackInfo_bEnterInterruption_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkAudioInterruptionCallbackInfo()
  System.Void CSharp_delete_AkAudioInterruptionCallbackInfo(System.IntPtr jarg1)
  System.Boolean CSharp_AkAudioSourceChangeCallbackInfo_bOtherAudioPlaying_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkAudioSourceChangeCallbackInfo()
  System.Void CSharp_delete_AkAudioSourceChangeCallbackInfo(System.IntPtr jarg1)
  System.Int32 CSharp_AkCallbackSerializer_Init()
  System.Void CSharp_AkCallbackSerializer_Term()
  System.IntPtr CSharp_AkCallbackSerializer_Lock()
  System.Void CSharp_AkCallbackSerializer_Unlock()
  System.Void CSharp_AkCallbackSerializer_SetLocalOutput(System.UInt32 jarg1, System.String jarg2, System.UInt32 jarg3, System.String jarg4, System.UInt32 jarg5, System.UInt32 jarg6)
  System.Int32 CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(System.Boolean jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_new_AkCallbackSerializer()
  System.Void CSharp_delete_AkCallbackSerializer(System.IntPtr jarg1)
  System.IntPtr CSharp_new_MsgContext__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Boolean jarg4)
  System.IntPtr CSharp_new_MsgContext__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3)
  System.IntPtr CSharp_new_MsgContext__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2)
  System.IntPtr CSharp_new_MsgContext__SWIG_3(System.UInt32 jarg1)
  System.IntPtr CSharp_new_MsgContext__SWIG_4()
  System.Void CSharp_MsgContext_in_playingID_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_MsgContext_in_playingID_get(System.IntPtr jarg1)
  System.Void CSharp_MsgContext_in_gameObjID_set(System.IntPtr jarg1, System.UInt64 jarg2)
  System.UInt64 CSharp_MsgContext_in_gameObjID_get(System.IntPtr jarg1)
  System.Void CSharp_MsgContext_in_soundID_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_MsgContext_in_soundID_get(System.IntPtr jarg1)
  System.Void CSharp_MsgContext_in_bIsBus_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_MsgContext_in_bIsBus_get(System.IntPtr jarg1)
  System.Void CSharp_delete_MsgContext(System.IntPtr jarg1)
  System.IntPtr CSharp_new_MonitorErrorInfo__SWIG_0(System.String jarg1, System.String jarg2)
  System.IntPtr CSharp_new_MonitorErrorInfo__SWIG_1(System.String jarg1)
  System.IntPtr CSharp_new_MonitorErrorInfo__SWIG_2()
  System.Void CSharp_MonitorErrorInfo_m_name_set(System.IntPtr jarg1, System.String jarg2)
  System.IntPtr CSharp_MonitorErrorInfo_m_name_get(System.IntPtr jarg1)
  System.Void CSharp_MonitorErrorInfo_m_message_set(System.IntPtr jarg1, System.String jarg2)
  System.IntPtr CSharp_MonitorErrorInfo_m_message_get(System.IntPtr jarg1)
  System.Void CSharp_delete_MonitorErrorInfo(System.IntPtr jarg1)
  System.Int32 CSharp_PostCode__SWIG_0(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5, System.Boolean jarg6)
  System.Int32 CSharp_PostCode__SWIG_1(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_PostCode__SWIG_2(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4)
  System.Int32 CSharp_PostCode__SWIG_3(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_PostCode__SWIG_4(System.Int32 jarg1, System.Int32 jarg2)
  System.Int32 CSharp_PostCodeVarArg(System.Int32 jarg1, System.Int32 jarg2, System.IntPtr jarg3)
  System.Int32 CSharp_PostString__SWIG_0(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5, System.Boolean jarg6)
  System.Int32 CSharp_PostString__SWIG_1(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5)
  System.Int32 CSharp_PostString__SWIG_2(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4)
  System.Int32 CSharp_PostString__SWIG_3(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_PostString__SWIG_4(System.String jarg1, System.Int32 jarg2)
  System.Int32 CSharp_ResetTranslator()
  System.Int32 CSharp_GetTimeStamp()
  System.Void CSharp_MonitorStreamMgrInit(System.IntPtr jarg1)
  System.Void CSharp_MonitorStreamingDeviceInit(System.UInt32 jarg1, System.IntPtr jarg2)
  System.Void CSharp_MonitorStreamingDeviceDestroyed(System.UInt32 jarg1)
  System.Void CSharp_MonitorStreamMgrTerm()
  System.Void CSharp_AkGetDefaultHighPriorityThreadProperties(System.IntPtr jarg1)
  System.UInt32 CSharp_ResolveDialogueEvent__SWIG_0(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3, System.UInt32 jarg4)
  System.UInt32 CSharp_ResolveDialogueEvent__SWIG_1(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32& jarg3)
  System.Int32 CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2, System.Single& jarg3)
  System.Void CSharp_AkPositioningInfo_fCenterPct_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_fCenterPct_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_pannerType_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkPositioningInfo_pannerType_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_e3dPositioningType_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkPositioningInfo_e3dPositioningType_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_e3DSpatializationMode_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkPositioningInfo_e3DSpatializationMode_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_bEnableAttenuation_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkPositioningInfo_bEnableAttenuation_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_bUseConeAttenuation_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkPositioningInfo_bUseConeAttenuation_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_fInnerAngle_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_fInnerAngle_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_fOuterAngle_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_fOuterAngle_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_fConeMaxAttenuation_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_fConeMaxAttenuation_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_LPFCone_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_LPFCone_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_HPFCone_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_HPFCone_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_fMaxDistance_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_fMaxDistance_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(System.IntPtr jarg1)
  System.Void CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkPositioningInfo()
  System.Void CSharp_delete_AkPositioningInfo(System.IntPtr jarg1)
  System.Void CSharp_AkObjectInfo_objID_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkObjectInfo_objID_get(System.IntPtr jarg1)
  System.Void CSharp_AkObjectInfo_parentID_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkObjectInfo_parentID_get(System.IntPtr jarg1)
  System.Void CSharp_AkObjectInfo_iDepth_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkObjectInfo_iDepth_get(System.IntPtr jarg1)
  System.Void CSharp_AkObjectInfo_Clear(System.IntPtr jarg1)
  System.Int32 CSharp_AkObjectInfo_GetSizeOf()
  System.Void CSharp_AkObjectInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_new_AkObjectInfo()
  System.Void CSharp_delete_AkObjectInfo(System.IntPtr jarg1)
  System.Int32 CSharp_GetPosition(System.UInt64 jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_GetListenerPosition(System.UInt64 jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_GetRTPCValue__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Single& jarg4, System.Int32& jarg5)
  System.Int32 CSharp_GetRTPCValue__SWIG_1(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Single& jarg4, System.Int32& jarg5)
  System.Int32 CSharp_GetSwitch__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32& jarg3)
  System.Int32 CSharp_GetSwitch__SWIG_1(System.String jarg1, System.UInt64 jarg2, System.UInt32& jarg3)
  System.Int32 CSharp_GetState__SWIG_0(System.UInt32 jarg1, System.UInt32& jarg2)
  System.Int32 CSharp_GetState__SWIG_1(System.String jarg1, System.UInt32& jarg2)
  System.Int32 CSharp_GetGameObjectAuxSendValues(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt32& jarg3)
  System.Int32 CSharp_GetGameObjectDryLevelValue(System.UInt64 jarg1, System.UInt64 jarg2, System.Single& jarg3)
  System.Int32 CSharp_GetObjectObstructionAndOcclusion(System.UInt64 jarg1, System.UInt64 jarg2, System.Single& jarg3, System.Single& jarg4)
  System.Int32 CSharp_QueryAudioObjectIDs__SWIG_0(System.UInt32 jarg1, System.UInt32& jarg2, System.IntPtr jarg3)
  System.Int32 CSharp_QueryAudioObjectIDs__SWIG_1(System.String jarg1, System.UInt32& jarg2, System.IntPtr jarg3)
  System.Int32 CSharp_GetPositioningInfo(System.UInt32 jarg1, System.IntPtr jarg2)
  System.Boolean CSharp_GetIsGameObjectActive(System.UInt64 jarg1)
  System.Single CSharp_GetMaxRadius(System.UInt64 jarg1)
  System.UInt32 CSharp_GetEventIDFromPlayingID(System.UInt32 jarg1)
  System.UInt64 CSharp_GetGameObjectFromPlayingID(System.UInt32 jarg1)
  System.Int32 CSharp_GetPlayingIDsFromGameObject(System.UInt64 jarg1, System.UInt32& jarg2, System.UInt32[] jarg3)
  System.Int32 CSharp_GetCustomPropertyValue__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32& jarg3)
  System.Int32 CSharp_GetCustomPropertyValue__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2, System.Single& jarg3)
  System.Void CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(System.UInt32& jarg1)
  System.Void CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(System.UInt32& jarg1)
  System.Void CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(System.UInt32& jarg1)
  System.Byte CSharp_ChannelMaskToNumChannels(System.UInt32 jarg1)
  System.UInt32 CSharp_ChannelMaskFromNumChannels(System.UInt32 jarg1)
  System.Byte CSharp_ChannelBitToIndex(System.UInt32 jarg1, System.UInt32 jarg2)
  System.Boolean CSharp_HasSurroundChannels(System.UInt32 jarg1)
  System.Boolean CSharp_HasStrictlyOnePairOfSurroundChannels(System.UInt32 jarg1)
  System.Boolean CSharp_HasSideAndRearChannels(System.UInt32 jarg1)
  System.Boolean CSharp_HasHeightChannels(System.UInt32 jarg1)
  System.UInt32 CSharp_BackToSideChannels(System.UInt32 jarg1)
  System.UInt32 CSharp_StdChannelIndexToDisplayIndex(System.Int32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3)
  System.Void CSharp_AkChannelConfig_uNumChannels_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkChannelConfig_uNumChannels_get(System.IntPtr jarg1)
  System.Void CSharp_AkChannelConfig_eConfigType_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkChannelConfig_eConfigType_get(System.IntPtr jarg1)
  System.Void CSharp_AkChannelConfig_uChannelMask_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkChannelConfig_uChannelMask_get(System.IntPtr jarg1)
  System.IntPtr CSharp_AkChannelConfig_Standard(System.UInt32 jarg1)
  System.IntPtr CSharp_AkChannelConfig_Anonymous(System.UInt32 jarg1)
  System.IntPtr CSharp_AkChannelConfig_Ambisonic(System.UInt32 jarg1)
  System.IntPtr CSharp_AkChannelConfig_Object()
  System.IntPtr CSharp_new_AkChannelConfig__SWIG_0()
  System.IntPtr CSharp_new_AkChannelConfig__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2)
  System.Void CSharp_AkChannelConfig_Clear(System.IntPtr jarg1)
  System.Void CSharp_AkChannelConfig_SetStandard(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Void CSharp_AkChannelConfig_SetStandardOrAnonymous(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32 jarg3)
  System.Void CSharp_AkChannelConfig_SetAnonymous(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Void CSharp_AkChannelConfig_SetAmbisonic(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Void CSharp_AkChannelConfig_SetObject(System.IntPtr jarg1)
  System.Void CSharp_AkChannelConfig_SetSameAsMainMix(System.IntPtr jarg1)
  System.Void CSharp_AkChannelConfig_SetSameAsPassthrough(System.IntPtr jarg1)
  System.Boolean CSharp_AkChannelConfig_IsValid(System.IntPtr jarg1)
  System.UInt32 CSharp_AkChannelConfig_Serialize(System.IntPtr jarg1)
  System.Void CSharp_AkChannelConfig_Deserialize(System.IntPtr jarg1, System.UInt32 jarg2)
  System.IntPtr CSharp_AkChannelConfig_RemoveLFE(System.IntPtr jarg1)
  System.IntPtr CSharp_AkChannelConfig_RemoveCenter(System.IntPtr jarg1)
  System.Void CSharp_delete_AkChannelConfig(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkImageSourceParams__SWIG_0()
  System.IntPtr CSharp_new_AkImageSourceParams__SWIG_1(AkVector64 jarg1, System.Single jarg2, System.Single jarg3)
  System.Void CSharp_AkImageSourceParams_sourcePosition_set(System.IntPtr jarg1, AkVector64 jarg2)
  AkVector64 CSharp_AkImageSourceParams_sourcePosition_get(System.IntPtr jarg1)
  System.Void CSharp_AkImageSourceParams_fDistanceScalingFactor_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkImageSourceParams_fDistanceScalingFactor_get(System.IntPtr jarg1)
  System.Void CSharp_AkImageSourceParams_fLevel_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkImageSourceParams_fLevel_get(System.IntPtr jarg1)
  System.Void CSharp_AkImageSourceParams_fDiffraction_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkImageSourceParams_fDiffraction_get(System.IntPtr jarg1)
  System.Void CSharp_AkImageSourceParams_fOcclusion_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkImageSourceParams_fOcclusion_get(System.IntPtr jarg1)
  System.Void CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(System.IntPtr jarg1)
  System.Void CSharp_AkImageSourceParams_uDiffractionListenerSide_set(System.IntPtr jarg1, System.Byte jarg2)
  System.Byte CSharp_AkImageSourceParams_uDiffractionListenerSide_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkImageSourceParams(System.IntPtr jarg1)
  System.UInt32 CSharp_kDefaultDiffractionMaxEdges_get()
  System.UInt32 CSharp_kDefaultDiffractionMaxPaths_get()
  System.Single CSharp_kMaxDiffraction_get()
  System.UInt32 CSharp_kHashListBlockAllocItemCount_get()
  System.UInt32 CSharp_kDiffractionMaxEdges_get()
  System.UInt32 CSharp_kDiffractionMaxPaths_get()
  System.UInt32 CSharp_kPortalToPortalDiffractionMaxPaths_get()
  System.IntPtr CSharp_new_AkSpatialAudioInitSettings()
  System.Void CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(System.IntPtr jarg1)
  System.Void CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(System.IntPtr jarg1)
  System.Void CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_get(System.IntPtr jarg1)
  System.Void CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_get(System.IntPtr jarg1)
  System.Void CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_get(System.IntPtr jarg1)
  System.Void CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_get(System.IntPtr jarg1)
  System.Void CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_get(System.IntPtr jarg1)
  System.Void CSharp_AkSpatialAudioInitSettings_fMaxPathLength_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkSpatialAudioInitSettings_fMaxPathLength_get(System.IntPtr jarg1)
  System.Void CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_get(System.IntPtr jarg1)
  System.Void CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_get(System.IntPtr jarg1)
  System.Void CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_get(System.IntPtr jarg1)
  System.Void CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkSpatialAudioInitSettings(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkImageSourceSettings__SWIG_0()
  System.IntPtr CSharp_new_AkImageSourceSettings__SWIG_1(AkVector64 jarg1, System.Single jarg2, System.Single jarg3)
  System.Void CSharp_AkImageSourceSettings_SetOneTexture(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Void CSharp_AkImageSourceSettings_params__set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkImageSourceSettings_params__get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkImageSourceSettings(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkExtent__SWIG_0()
  System.IntPtr CSharp_new_AkExtent__SWIG_1(System.Single jarg1, System.Single jarg2, System.Single jarg3)
  System.Void CSharp_AkExtent_halfWidth_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkExtent_halfWidth_get(System.IntPtr jarg1)
  System.Void CSharp_AkExtent_halfHeight_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkExtent_halfHeight_get(System.IntPtr jarg1)
  System.Void CSharp_AkExtent_halfDepth_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkExtent_halfDepth_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkExtent(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkTriangle__SWIG_0()
  System.IntPtr CSharp_new_AkTriangle__SWIG_1(System.UInt16 jarg1, System.UInt16 jarg2, System.UInt16 jarg3, System.UInt16 jarg4)
  System.Void CSharp_AkTriangle_point0_set(System.IntPtr jarg1, System.UInt16 jarg2)
  System.UInt16 CSharp_AkTriangle_point0_get(System.IntPtr jarg1)
  System.Void CSharp_AkTriangle_point1_set(System.IntPtr jarg1, System.UInt16 jarg2)
  System.UInt16 CSharp_AkTriangle_point1_get(System.IntPtr jarg1)
  System.Void CSharp_AkTriangle_point2_set(System.IntPtr jarg1, System.UInt16 jarg2)
  System.UInt16 CSharp_AkTriangle_point2_get(System.IntPtr jarg1)
  System.Void CSharp_AkTriangle_surface_set(System.IntPtr jarg1, System.UInt16 jarg2)
  System.UInt16 CSharp_AkTriangle_surface_get(System.IntPtr jarg1)
  System.Void CSharp_AkTriangle_Clear(System.IntPtr jarg1)
  System.Int32 CSharp_AkTriangle_GetSizeOf()
  System.Void CSharp_AkTriangle_Clone(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Void CSharp_delete_AkTriangle(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkAcousticSurface()
  System.Void CSharp_AkAcousticSurface_textureID_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkAcousticSurface_textureID_get(System.IntPtr jarg1)
  System.Void CSharp_AkAcousticSurface_transmissionLoss_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkAcousticSurface_transmissionLoss_get(System.IntPtr jarg1)
  System.Void CSharp_AkAcousticSurface_strName_set(System.IntPtr jarg1, System.String jarg2)
  System.IntPtr CSharp_AkAcousticSurface_strName_get(System.IntPtr jarg1)
  System.Void CSharp_AkAcousticSurface_Clear(System.IntPtr jarg1)
  System.Void CSharp_AkAcousticSurface_DeleteName(System.IntPtr jarg1)
  System.Int32 CSharp_AkAcousticSurface_GetSizeOf()
  System.Void CSharp_AkAcousticSurface_Clone(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Void CSharp_delete_AkAcousticSurface(System.IntPtr jarg1)
  System.Void CSharp_AkReflectionPathInfo_imageSource_set(System.IntPtr jarg1, AkVector64 jarg2)
  AkVector64 CSharp_AkReflectionPathInfo_imageSource_get(System.IntPtr jarg1)
  System.Void CSharp_AkReflectionPathInfo_numPathPoints_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkReflectionPathInfo_numPathPoints_get(System.IntPtr jarg1)
  System.Void CSharp_AkReflectionPathInfo_numReflections_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkReflectionPathInfo_numReflections_get(System.IntPtr jarg1)
  System.Void CSharp_AkReflectionPathInfo_level_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkReflectionPathInfo_level_get(System.IntPtr jarg1)
  System.Void CSharp_AkReflectionPathInfo_isOccluded_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkReflectionPathInfo_isOccluded_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkReflectionPathInfo_GetSizeOf()
  UnityEngine.Vector3 CSharp_AkReflectionPathInfo_GetPathPoint(System.IntPtr jarg1, System.UInt32 jarg2)
  System.IntPtr CSharp_AkReflectionPathInfo_GetAcousticSurface(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Single CSharp_AkReflectionPathInfo_GetDiffraction(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Void CSharp_AkReflectionPathInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_new_AkReflectionPathInfo()
  System.Void CSharp_delete_AkReflectionPathInfo(System.IntPtr jarg1)
  System.Void CSharp_AkDiffractionPathInfo_emitterPos_set(System.IntPtr jarg1, AkVector64 jarg2)
  AkVector64 CSharp_AkDiffractionPathInfo_emitterPos_get(System.IntPtr jarg1)
  System.Void CSharp_AkDiffractionPathInfo_virtualPos_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkDiffractionPathInfo_virtualPos_get(System.IntPtr jarg1)
  System.Void CSharp_AkDiffractionPathInfo_nodeCount_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkDiffractionPathInfo_nodeCount_get(System.IntPtr jarg1)
  System.Void CSharp_AkDiffractionPathInfo_diffraction_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkDiffractionPathInfo_diffraction_get(System.IntPtr jarg1)
  System.Void CSharp_AkDiffractionPathInfo_transmissionLoss_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkDiffractionPathInfo_transmissionLoss_get(System.IntPtr jarg1)
  System.Void CSharp_AkDiffractionPathInfo_totLength_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkDiffractionPathInfo_totLength_get(System.IntPtr jarg1)
  System.Void CSharp_AkDiffractionPathInfo_obstructionValue_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkDiffractionPathInfo_obstructionValue_get(System.IntPtr jarg1)
  System.Void CSharp_AkDiffractionPathInfo_occlusionValue_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkDiffractionPathInfo_occlusionValue_get(System.IntPtr jarg1)
  System.Int32 CSharp_AkDiffractionPathInfo_GetSizeOf()
  UnityEngine.Vector3 CSharp_AkDiffractionPathInfo_GetNodes(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Single CSharp_AkDiffractionPathInfo_GetAngles(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt64 CSharp_AkDiffractionPathInfo_GetPortals(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt64 CSharp_AkDiffractionPathInfo_GetRooms(System.IntPtr jarg1, System.UInt32 jarg2)
  System.Void CSharp_AkDiffractionPathInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_new_AkDiffractionPathInfo()
  System.Void CSharp_delete_AkDiffractionPathInfo(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkRoomParams()
  System.Void CSharp_AkRoomParams_Front_set(System.IntPtr jarg1, UnityEngine.Vector3 jarg2)
  UnityEngine.Vector3 CSharp_AkRoomParams_Front_get(System.IntPtr jarg1)
  System.Void CSharp_AkRoomParams_Up_set(System.IntPtr jarg1, UnityEngine.Vector3 jarg2)
  UnityEngine.Vector3 CSharp_AkRoomParams_Up_get(System.IntPtr jarg1)
  System.Void CSharp_AkRoomParams_ReverbAuxBus_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkRoomParams_ReverbAuxBus_get(System.IntPtr jarg1)
  System.Void CSharp_AkRoomParams_ReverbLevel_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkRoomParams_ReverbLevel_get(System.IntPtr jarg1)
  System.Void CSharp_AkRoomParams_TransmissionLoss_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkRoomParams_TransmissionLoss_get(System.IntPtr jarg1)
  System.Void CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(System.IntPtr jarg1)
  System.Void CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(System.IntPtr jarg1)
  System.Void CSharp_AkRoomParams_RoomPriority_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkRoomParams_RoomPriority_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkRoomParams(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkGeometryInstanceParams()
  System.Void CSharp_AkGeometryInstanceParams_PositionAndOrientation_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkGeometryInstanceParams_PositionAndOrientation_get(System.IntPtr jarg1)
  System.Void CSharp_AkGeometryInstanceParams_Scale_set(System.IntPtr jarg1, UnityEngine.Vector3 jarg2)
  UnityEngine.Vector3 CSharp_AkGeometryInstanceParams_Scale_get(System.IntPtr jarg1)
  System.Void CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkGeometryInstanceParams(System.IntPtr jarg1)
  System.Int32 CSharp_SetGameObjectRadius(System.UInt64 jarg1, System.Single jarg2, System.Single jarg3)
  System.Int32 CSharp_SetImageSource__SWIG_0(System.UInt32 jarg1, System.IntPtr jarg2, System.String jarg3, System.UInt32 jarg4, System.UInt64 jarg5)
  System.Int32 CSharp_SetImageSource__SWIG_1(System.UInt32 jarg1, System.IntPtr jarg2, System.String jarg3, System.UInt32 jarg4)
  System.Int32 CSharp_SetImageSource__SWIG_2(System.UInt32 jarg1, System.IntPtr jarg2, System.String jarg3)
  System.Int32 CSharp_RemoveImageSource__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt64 jarg3)
  System.Int32 CSharp_RemoveImageSource__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_RemoveImageSource__SWIG_2(System.UInt32 jarg1)
  System.Int32 CSharp_ClearImageSources__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_ClearImageSources__SWIG_1(System.UInt32 jarg1)
  System.Int32 CSharp_ClearImageSources__SWIG_2()
  System.Int32 CSharp_RemoveGeometry(System.UInt64 jarg1)
  System.Int32 CSharp_RemoveGeometryInstance(System.UInt64 jarg1)
  System.Int32 CSharp_RemoveRoom(System.UInt64 jarg1)
  System.Int32 CSharp_RemovePortal(System.UInt64 jarg1)
  System.Int32 CSharp_SetReverbZone(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3)
  System.Int32 CSharp_RemoveReverbZone(System.UInt64 jarg1)
  System.Int32 CSharp_SetGameObjectInRoom(System.UInt64 jarg1, System.UInt64 jarg2)
  System.Int32 CSharp_UnsetGameObjectInRoom(System.UInt64 jarg1)
  System.Int32 CSharp_SetReflectionsOrder(System.UInt32 jarg1, System.Boolean jarg2)
  System.Int32 CSharp_SetDiffractionOrder(System.UInt32 jarg1, System.Boolean jarg2)
  System.Int32 CSharp_SetMaxEmitterRoomAuxSends(System.UInt32 jarg1)
  System.Int32 CSharp_SetNumberOfPrimaryRays(System.UInt32 jarg1)
  System.Int32 CSharp_SetLoadBalancingSpread(System.UInt32 jarg1)
  System.Int32 CSharp_SetEarlyReflectionsAuxSend(System.UInt64 jarg1, System.UInt32 jarg2)
  System.Int32 CSharp_SetEarlyReflectionsVolume(System.UInt64 jarg1, System.Single jarg2)
  System.Int32 CSharp_SetPortalObstructionAndOcclusion(System.UInt64 jarg1, System.Single jarg2, System.Single jarg3)
  System.Int32 CSharp_SetGameObjectToPortalObstruction(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3)
  System.Int32 CSharp_SetPortalToPortalObstruction(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3)
  System.Int32 CSharp_QueryWetDiffraction(System.UInt64 jarg1, System.Single& jarg2)
  System.Int32 CSharp_ResetStochasticEngine()
  System.Void CSharp_AkPlatformInitSettings_threadLEngine_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkPlatformInitSettings_threadLEngine_get(System.IntPtr jarg1)
  System.Void CSharp_AkPlatformInitSettings_threadOutputMgr_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkPlatformInitSettings_threadOutputMgr_get(System.IntPtr jarg1)
  System.Void CSharp_AkPlatformInitSettings_threadBankManager_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkPlatformInitSettings_threadBankManager_get(System.IntPtr jarg1)
  System.Void CSharp_AkPlatformInitSettings_threadMonitor_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkPlatformInitSettings_threadMonitor_get(System.IntPtr jarg1)
  System.Void CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(System.IntPtr jarg1, System.UInt16 jarg2)
  System.UInt16 CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(System.IntPtr jarg1)
  System.Void CSharp_AkPlatformInitSettings_uSampleRate_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkPlatformInitSettings_uSampleRate_get(System.IntPtr jarg1)
  System.Void CSharp_AkPlatformInitSettings_bEnableAvxSupport_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkPlatformInitSettings_bEnableAvxSupport_get(System.IntPtr jarg1)
  System.Void CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_get(System.IntPtr jarg1)
  System.Void CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkPlatformInitSettings(System.IntPtr jarg1)
  System.UInt32 CSharp_GetDeviceIDFromName(System.String jarg1)
  System.IntPtr CSharp_GetWindowsDeviceName__SWIG_0(System.Int32 jarg1, System.UInt32& jarg2, System.Int32 jarg3)
  System.IntPtr CSharp_GetWindowsDeviceName__SWIG_1(System.Int32 jarg1, System.UInt32& jarg2)
  System.UInt32 CSharp_GetWindowsDeviceCount__SWIG_0(System.Int32 jarg1)
  System.UInt32 CSharp_GetWindowsDeviceCount__SWIG_1()
  System.Void CSharp_delete_AkStreamMgrSettings(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceSettings_pIOMemory_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkDeviceSettings_pIOMemory_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceSettings_uIOMemorySize_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkDeviceSettings_uIOMemorySize_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceSettings_uIOMemoryAlignment_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkDeviceSettings_uIOMemoryAlignment_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceSettings_ePoolAttributes_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkDeviceSettings_ePoolAttributes_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceSettings_uGranularity_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkDeviceSettings_uGranularity_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceSettings_threadProperties_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkDeviceSettings_threadProperties_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(System.IntPtr jarg1, System.Single jarg2)
  System.Single CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceSettings_uMaxConcurrentIO_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkDeviceSettings_uMaxConcurrentIO_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceSettings_bUseStreamCache_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkDeviceSettings_bUseStreamCache_get(System.IntPtr jarg1)
  System.Void CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkDeviceSettings(System.IntPtr jarg1)
  System.Void CSharp_AkThreadProperties_nPriority_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkThreadProperties_nPriority_get(System.IntPtr jarg1)
  System.Void CSharp_AkThreadProperties_dwAffinityMask_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkThreadProperties_dwAffinityMask_get(System.IntPtr jarg1)
  System.Void CSharp_AkThreadProperties_uStackSize_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkThreadProperties_uStackSize_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkThreadProperties()
  System.Void CSharp_delete_AkThreadProperties(System.IntPtr jarg1)
  System.Void CSharp_SetErrorLogger__SWIG_0(AkLogger.ErrorLoggerInteropDelegate jarg1)
  System.Void CSharp_SetErrorLogger__SWIG_1()
  System.Void CSharp_SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate jarg1, AkAudioInputManager.AudioFormatInteropDelegate jarg2)
  System.Void CSharp_delete_AkUnityPlatformSpecificSettings(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkCommunicationSettings()
  System.Void CSharp_AkCommunicationSettings_uPoolSize_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkCommunicationSettings_uPoolSize_get(System.IntPtr jarg1)
  System.Void CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(System.IntPtr jarg1, System.UInt16 jarg2)
  System.UInt16 CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(System.IntPtr jarg1)
  System.Void CSharp_AkCommunicationSettings_uCommandPort_set(System.IntPtr jarg1, System.UInt16 jarg2)
  System.UInt16 CSharp_AkCommunicationSettings_uCommandPort_get(System.IntPtr jarg1)
  System.Void CSharp_AkCommunicationSettings_commSystem_set(System.IntPtr jarg1, System.Int32 jarg2)
  System.Int32 CSharp_AkCommunicationSettings_commSystem_get(System.IntPtr jarg1)
  System.Void CSharp_AkCommunicationSettings_bInitSystemLib_set(System.IntPtr jarg1, System.Boolean jarg2)
  System.Boolean CSharp_AkCommunicationSettings_bInitSystemLib_get(System.IntPtr jarg1)
  System.Void CSharp_AkCommunicationSettings_szAppNetworkName_set(System.IntPtr jarg1, System.String jarg2)
  System.IntPtr CSharp_AkCommunicationSettings_szAppNetworkName_get(System.IntPtr jarg1)
  System.Void CSharp_delete_AkCommunicationSettings(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkInitializationSettings()
  System.Void CSharp_delete_AkInitializationSettings(System.IntPtr jarg1)
  System.Void CSharp_AkInitializationSettings_streamMgrSettings_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkInitializationSettings_streamMgrSettings_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitializationSettings_deviceSettings_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkInitializationSettings_deviceSettings_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitializationSettings_initSettings_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkInitializationSettings_initSettings_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitializationSettings_platformSettings_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkInitializationSettings_platformSettings_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitializationSettings_musicSettings_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkInitializationSettings_musicSettings_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitializationSettings_uMemAllocationSizeLimit_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkInitializationSettings_uMemAllocationSizeLimit_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitializationSettings_uMemDebugLevel_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkInitializationSettings_uMemDebugLevel_get(System.IntPtr jarg1)
  System.Void CSharp_AkInitializationSettings_uMemSpanCount_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkInitializationSettings_uMemSpanCount_get(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_0()
  System.Void CSharp_delete_AkExternalSourceInfo(System.IntPtr jarg1)
  System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32 jarg3, System.UInt32 jarg4)
  System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_2(System.String jarg1, System.UInt32 jarg2, System.UInt32 jarg3)
  System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_3(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3)
  System.Void CSharp_AkExternalSourceInfo_Clear(System.IntPtr jarg1)
  System.Void CSharp_AkExternalSourceInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2)
  System.Int32 CSharp_AkExternalSourceInfo_GetSizeOf()
  System.Void CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(System.IntPtr jarg1)
  System.Void CSharp_AkExternalSourceInfo_idCodec_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkExternalSourceInfo_idCodec_get(System.IntPtr jarg1)
  System.Void CSharp_AkExternalSourceInfo_szFile_set(System.IntPtr jarg1, System.String jarg2)
  System.IntPtr CSharp_AkExternalSourceInfo_szFile_get(System.IntPtr jarg1)
  System.Void CSharp_AkExternalSourceInfo_pInMemory_set(System.IntPtr jarg1, System.IntPtr jarg2)
  System.IntPtr CSharp_AkExternalSourceInfo_pInMemory_get(System.IntPtr jarg1)
  System.Void CSharp_AkExternalSourceInfo_uiMemorySize_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkExternalSourceInfo_uiMemorySize_get(System.IntPtr jarg1)
  System.Void CSharp_AkExternalSourceInfo_idFile_set(System.IntPtr jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_AkExternalSourceInfo_idFile_get(System.IntPtr jarg1)
  System.Int32 CSharp_Init(System.IntPtr jarg1)
  System.Int32 CSharp_InitSpatialAudio(System.IntPtr jarg1)
  System.Int32 CSharp_InitCommunication(System.IntPtr jarg1)
  System.Void CSharp_Term()
  System.Int32 CSharp_RegisterGameObjInternal(System.UInt64 jarg1)
  System.Int32 CSharp_UnregisterGameObjInternal(System.UInt64 jarg1)
  System.Int32 CSharp_RegisterGameObjInternal_WithName(System.UInt64 jarg1, System.String jarg2)
  System.Int32 CSharp_SetBasePath(System.String jarg1)
  System.Int32 CSharp_SetCurrentLanguage(System.String jarg1)
  System.Int32 CSharp_LoadFilePackage(System.String jarg1, System.UInt32& jarg2)
  System.Int32 CSharp_AddBasePath(System.String jarg1)
  System.Int32 CSharp_SetGameName(System.String jarg1)
  System.IntPtr CSharp_GetCurrentLanguage()
  System.Int32 CSharp_UnloadFilePackage(System.UInt32 jarg1)
  System.Int32 CSharp_UnloadAllFilePackages()
  System.Int32 CSharp_SetObjectPosition(System.UInt64 jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4)
  System.Int32 CSharp_GetSourceMultiplePlayPositions__SWIG_0(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32[] jarg3, System.Int32[] jarg4, System.UInt32& jarg5, System.Boolean jarg6)
  System.Int32 CSharp_GetSourceMultiplePlayPositions__SWIG_1(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32[] jarg3, System.Int32[] jarg4, System.UInt32& jarg5)
  System.Int32 CSharp_SetListeners(System.UInt64 jarg1, System.UInt64[] jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_SetDefaultListeners(System.UInt64[] jarg1, System.UInt32 jarg2)
  System.UInt32 CSharp_GetNumOutputDevices(System.UInt32 jarg1)
  System.Int32 CSharp_AddOutput__SWIG_0(System.IntPtr jarg1, System.UInt64& jarg2, System.UInt64[] jarg3, System.UInt32 jarg4)
  System.Int32 CSharp_AddOutput__SWIG_1(System.IntPtr jarg1, System.UInt64& jarg2, System.UInt64[] jarg3)
  System.Int32 CSharp_AddOutput__SWIG_2(System.IntPtr jarg1, System.UInt64& jarg2)
  System.Int32 CSharp_AddOutput__SWIG_3(System.IntPtr jarg1)
  System.Void CSharp_GetDefaultStreamSettings(System.IntPtr jarg1)
  System.Void CSharp_GetDefaultDeviceSettings(System.IntPtr jarg1)
  System.Void CSharp_GetDefaultMusicSettings(System.IntPtr jarg1)
  System.Void CSharp_GetDefaultInitSettings(System.IntPtr jarg1)
  System.Void CSharp_GetDefaultPlatformInitSettings(System.IntPtr jarg1)
  System.UInt32 CSharp_GetMajorMinorVersion()
  System.UInt32 CSharp_GetSubminorBuildVersion()
  System.Void CSharp_StartResourceMonitoring()
  System.Void CSharp_StopResourceMonitoring()
  System.Void CSharp_GetResourceMonitorDataSummary(System.IntPtr jarg1)
  System.Void CSharp_StartDeviceCapture(System.UInt64 jarg1)
  System.Void CSharp_StopDeviceCapture(System.UInt64 jarg1)
  System.Void CSharp_ClearCaptureData()
  System.UInt32 CSharp_UpdateCaptureSampleCount(System.UInt64 jarg1)
  System.UInt32 CSharp_GetCaptureSamples(System.UInt64 jarg1, System.Single[] jarg2, System.UInt32 jarg3)
  System.Int32 CSharp_SetRoomPortal(System.UInt64 jarg1, System.UInt64 jarg2, System.UInt64 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.Boolean jarg6, System.String jarg7)
  System.Int32 CSharp_SetRoom(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt64 jarg3, System.String jarg4)
  System.Int32 CSharp_RegisterSpatialAudioListener(System.UInt64 jarg1)
  System.Int32 CSharp_UnregisterSpatialAudioListener(System.UInt64 jarg1)
  System.Int32 CSharp_SetGeometry(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt32 jarg3, UnityEngine.Vector3[] jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.UInt32 jarg7, System.Boolean jarg8, System.Boolean jarg9)
  System.Int32 CSharp_SetGeometryInstance(System.UInt64 jarg1, System.IntPtr jarg2, UnityEngine.Vector3 jarg3, System.UInt64 jarg4, System.UInt64 jarg5, System.Boolean jarg6)
  System.Int32 CSharp_QueryReflectionPaths(System.UInt64 jarg1, System.UInt32 jarg2, UnityEngine.Vector3& jarg3, UnityEngine.Vector3& jarg4, System.IntPtr jarg5, System.UInt32& jarg6)
  System.Int32 CSharp_QueryDiffractionPaths(System.UInt64 jarg1, System.UInt32 jarg2, UnityEngine.Vector3& jarg3, UnityEngine.Vector3& jarg4, System.IntPtr jarg5, System.UInt32& jarg6)
  System.Void CSharp_PerformStreamMgrIO()
  System.Void CSharp_HgMemShrink()
  System.UInt64 CSharp_HgGetGlobalMemoryUsed()
  System.UInt64 CSharp_HgGetGlobalMemoryReserved()
  System.Void CSharp_InitScePad()
  System.UInt32 CSharp_GetMMDeviceIdFromPadContainerInfo(System.Int32 jarg1)
  System.IntPtr CSharp_AkPlaylist_SWIGUpcast(System.IntPtr jarg1)
  System.IntPtr CSharp_AkMIDIPost_SWIGUpcast(System.IntPtr jarg1)
  System.IntPtr CSharp_AkEventCallbackInfo_SWIGUpcast(System.IntPtr jarg1)
  System.IntPtr CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(System.IntPtr jarg1)
  System.IntPtr CSharp_AkMarkerCallbackInfo_SWIGUpcast(System.IntPtr jarg1)
  System.IntPtr CSharp_AkDurationCallbackInfo_SWIGUpcast(System.IntPtr jarg1)
  System.IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(System.IntPtr jarg1)
  System.IntPtr CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(System.IntPtr jarg1)
  System.IntPtr CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(System.IntPtr jarg1)
  System.Void .ctor()
END_CLASS

CLASS: GameObjectHashFunction
TYPE:  class
TOKEN: 0x200006E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.UInt64 Invoke(UnityEngine.GameObject gameObject)
  System.IAsyncResult BeginInvoke(UnityEngine.GameObject gameObject, System.AsyncCallback callback, System.Object object)
  System.UInt64 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: AkSoundEngine
TYPE:  class
TOKEN: 0x200006D
FIELDS:
  public    static  System.Int32                    _WIN32_WINNT  // 0x0
  public    static  System.Int32                    AK_SIMD_ALIGNMENT  // 0x0
  public    static  System.Int32                    AK_BUFFER_ALIGNMENT  // 0x0
  public    static  System.Int32                    AK_XAUDIO2_FLAGS  // 0x0
  public    static  System.Int32                    AK_MAX_PATH  // 0x0
  public    static  System.Int32                    AK_BANK_PLATFORM_DATA_ALIGNMENT  // 0x0
  public    static  System.String                   AK_OSCHAR_FMT  // 0x0
  public    static  System.UInt32                   AK_INVALID_PLUGINID  // 0x0
  public    static  System.UInt64                   AK_INVALID_GAME_OBJECT  // 0x0
  public    static  System.UInt32                   AK_INVALID_UNIQUE_ID  // 0x0
  public    static  System.UInt32                   AK_INVALID_RTPC_ID  // 0x0
  public    static  System.UInt32                   AK_INVALID_LISTENER_INDEX  // 0x0
  public    static  System.UInt32                   AK_INVALID_PLAYING_ID  // 0x0
  public    static  System.UInt32                   AK_DEFAULT_SWITCH_STATE  // 0x0
  public    static  System.Int32                    AK_INVALID_POOL_ID  // 0x0
  public    static  System.Int32                    AK_DEFAULT_POOL_ID  // 0x0
  public    static  System.UInt32                   AK_INVALID_AUX_ID  // 0x0
  public    static  System.UInt32                   AK_INVALID_FILE_ID  // 0x0
  public    static  System.UInt32                   AK_INVALID_DEVICE_ID  // 0x0
  public    static  System.UInt32                   AK_INVALID_BANK_ID  // 0x0
  public    static  System.UInt32                   AK_FALLBACK_ARGUMENTVALUE_ID  // 0x0
  public    static  System.UInt32                   AK_INVALID_CHANNELMASK  // 0x0
  public    static  System.UInt32                   AK_INVALID_OUTPUT_DEVICE_ID  // 0x0
  public    static  System.UInt32                   AK_MIXER_FX_SLOT  // 0x0
  public    static  System.UInt64                   AK_DEFAULT_LISTENER_OBJ  // 0x0
  public    static  System.UInt32                   AK_DEFAULT_PRIORITY  // 0x0
  public    static  System.UInt32                   AK_MIN_PRIORITY  // 0x0
  public    static  System.UInt32                   AK_MAX_PRIORITY  // 0x0
  public    static  System.UInt32                   AK_DEFAULT_BANK_IO_PRIORITY  // 0x0
  public    static  System.Double                   AK_DEFAULT_BANK_THROUGHPUT  // 0x0
  public    static  System.UInt32                   AKCOMPANYID_AUDIOKINETIC  // 0x0
  public    static  System.UInt32                   AK_LISTENERS_MASK_ALL  // 0x0
  public    static  System.Int32                    NULL  // 0x0
  public    static  System.Int32                    AKCURVEINTERPOLATION_NUM_STORAGE_BIT  // 0x0
  public    static  System.Int32                    AK_MAX_LANGUAGE_NAME_SIZE  // 0x0
  public    static  System.Int32                    AKCOMPANYID_PLUGINDEV_MIN  // 0x0
  public    static  System.Int32                    AKCOMPANYID_PLUGINDEV_MAX  // 0x0
  public    static  System.Int32                    AKCOMPANYID_AUDIOKINETIC_EXTERNAL  // 0x0
  public    static  System.Int32                    AKCOMPANYID_MCDSP  // 0x0
  public    static  System.Int32                    AKCOMPANYID_WAVEARTS  // 0x0
  public    static  System.Int32                    AKCOMPANYID_PHONETICARTS  // 0x0
  public    static  System.Int32                    AKCOMPANYID_IZOTOPE  // 0x0
  public    static  System.Int32                    AKCOMPANYID_CRANKCASEAUDIO  // 0x0
  public    static  System.Int32                    AKCOMPANYID_IOSONO  // 0x0
  public    static  System.Int32                    AKCOMPANYID_AUROTECHNOLOGIES  // 0x0
  public    static  System.Int32                    AKCOMPANYID_DOLBY  // 0x0
  public    static  System.Int32                    AKCOMPANYID_TWOBIGEARS  // 0x0
  public    static  System.Int32                    AKCOMPANYID_OCULUS  // 0x0
  public    static  System.Int32                    AKCOMPANYID_BLUERIPPLESOUND  // 0x0
  public    static  System.Int32                    AKCOMPANYID_ENZIEN  // 0x0
  public    static  System.Int32                    AKCOMPANYID_KROTOS  // 0x0
  public    static  System.Int32                    AKCOMPANYID_NURULIZE  // 0x0
  public    static  System.Int32                    AKCOMPANYID_SUPERPOWERED  // 0x0
  public    static  System.Int32                    AKCOMPANYID_GOOGLE  // 0x0
  public    static  System.Int32                    AKCOMPANYID_VISISONICS  // 0x0
  public    static  System.Int32                    AKCODECID_BANK  // 0x0
  public    static  System.Int32                    AKCODECID_PCM  // 0x0
  public    static  System.Int32                    AKCODECID_ADPCM  // 0x0
  public    static  System.Int32                    AKCODECID_XMA  // 0x0
  public    static  System.Int32                    AKCODECID_VORBIS  // 0x0
  public    static  System.Int32                    AKCODECID_WIIADPCM  // 0x0
  public    static  System.Int32                    AKCODECID_PCMEX  // 0x0
  public    static  System.Int32                    AKCODECID_EXTERNAL_SOURCE  // 0x0
  public    static  System.Int32                    AKCODECID_XWMA  // 0x0
  public    static  System.Int32                    AKCODECID_FILE_PACKAGE  // 0x0
  public    static  System.Int32                    AKCODECID_ATRAC9  // 0x0
  public    static  System.Int32                    AKCODECID_VAG  // 0x0
  public    static  System.Int32                    AKCODECID_PROFILERCAPTURE  // 0x0
  public    static  System.Int32                    AKCODECID_ANALYSISFILE  // 0x0
  public    static  System.Int32                    AKCODECID_MIDI  // 0x0
  public    static  System.Int32                    AKCODECID_OPUSNX  // 0x0
  public    static  System.Int32                    AKCODECID_CAF  // 0x0
  public    static  System.Int32                    AKCODECID_AKOPUS  // 0x0
  public    static  System.Int32                    AKCODECID_AKOPUS_WEM  // 0x0
  public    static  System.Int32                    AKCODECID_MEMORYMGR_DUMP  // 0x0
  public    static  System.Int32                    AKCODECID_SONY360  // 0x0
  public    static  System.Int32                    AKCODECID_BANK_EVENT  // 0x0
  public    static  System.Int32                    AKCODECID_BANK_BUS  // 0x0
  public    static  System.Int32                    AKPLUGINID_METER  // 0x0
  public    static  System.Int32                    AKPLUGINID_RECORDER  // 0x0
  public    static  System.Int32                    AKPLUGINID_IMPACTER  // 0x0
  public    static  System.Int32                    AKPLUGINID_SYSTEM_OUTPUT_META  // 0x0
  public    static  System.Int32                    AKPLUGINID_AUDIO_OBJECT_ATTENUATION_META  // 0x0
  public    static  System.Int32                    AKPLUGINID_AUDIO_OBJECT_PRIORITY_META  // 0x0
  public    static  System.Int32                    AKEXTENSIONID_SPATIALAUDIO  // 0x0
  public    static  System.Int32                    AKEXTENSIONID_INTERACTIVEMUSIC  // 0x0
  public    static  System.Int32                    AKEXTENSIONID_MIDIDEVICEMGR  // 0x0
  public    static  System.Int32                    AK_WAVE_FORMAT_VAG  // 0x0
  public    static  System.Int32                    AK_WAVE_FORMAT_AT9  // 0x0
  public    static  System.Int32                    AK_WAVE_FORMAT_VORBIS  // 0x0
  public    static  System.Int32                    AK_WAVE_FORMAT_OPUSNX  // 0x0
  public    static  System.Int32                    AK_WAVE_FORMAT_OPUS  // 0x0
  public    static  System.Int32                    AK_WAVE_FORMAT_OPUS_WEM  // 0x0
  public    static  System.Int32                    WAVE_FORMAT_XMA2  // 0x0
  public    static  System.Int32                    AK_PANNER_NUM_STORAGE_BITS  // 0x0
  public    static  System.Int32                    AK_POSSOURCE_NUM_STORAGE_BITS  // 0x0
  public    static  System.Int32                    AK_SPAT_NUM_STORAGE_BITS  // 0x0
  public    static  System.Int32                    AK_MAX_BITS_METERING_FLAGS  // 0x0
  public    static  System.Boolean                  AK_ASYNC_OPEN_DEFAULT  // 0x0
  public    static  System.Int32                    AK_COMM_DEFAULT_DISCOVERY_PORT  // 0x0
  public    static  System.Double                   AK_DEFAULT_LISTENER_POSITION_X  // 0x0
  public    static  System.Double                   AK_DEFAULT_LISTENER_POSITION_Y  // 0x0
  public    static  System.Double                   AK_DEFAULT_LISTENER_POSITION_Z  // 0x0
  public    static  System.Double                   AK_DEFAULT_LISTENER_FRONT_X  // 0x0
  public    static  System.Double                   AK_DEFAULT_LISTENER_FRONT_Y  // 0x0
  public    static  System.Double                   AK_DEFAULT_LISTENER_FRONT_Z  // 0x0
  public    static  System.Double                   AK_DEFAULT_TOP_X  // 0x0
  public    static  System.Double                   AK_DEFAULT_TOP_Y  // 0x0
  public    static  System.Double                   AK_DEFAULT_TOP_Z  // 0x0
  public    static  System.Double                   AK_SA_EPSILON  // 0x0
  public    static  System.Double                   AK_SA_DIFFRACTION_EPSILON  // 0x0
  public    static  System.Double                   AK_SA_PLANE_THICKNESS  // 0x0
  public    static  System.Double                   AK_SA_MIN_ENVIRONMENT_ABSORPTION  // 0x0
  public    static  System.Double                   AK_SA_MIN_ENVIRONMENT_SURFACE_AREA  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_INVALID  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_NOTE_OFF  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_NOTE_ON  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_CONTROLLER  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_PITCH_BEND  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_SYSEX  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_ESCAPE  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_WWISE_CMD  // 0x0
  public    static  System.Int32                    AK_MIDI_EVENT_TYPE_META  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_BANK_SELECT_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_MOD_WHEEL_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_BREATH_CTRL_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_3_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_FOOT_PEDAL_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_PORTAMENTO_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_DATA_ENTRY_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_VOLUME_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_BALANCE_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_9_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_PAN_POSITION_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_EXPRESSION_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_EFFECT_CTRL_1_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_EFFECT_CTRL_2_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_14_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_15_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_GEN_SLIDER_1  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_GEN_SLIDER_2  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_GEN_SLIDER_3  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_GEN_SLIDER_4  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_20_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_21_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_22_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_23_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_24_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_25_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_26_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_27_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_28_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_29_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_30_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_31_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_BANK_SELECT_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_MOD_WHEEL_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_BREATH_CTRL_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_3_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_FOOT_PEDAL_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_PORTAMENTO_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_DATA_ENTRY_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_VOLUME_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_BALANCE_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_9_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_PAN_POSITION_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_EXPRESSION_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_EFFECT_CTRL_1_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_EFFECT_CTRL_2_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_14_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_15_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_20_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_21_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_22_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_23_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_24_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_25_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_26_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_27_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_28_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_29_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_30_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CTRL_31_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_HOLD_PEDAL  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_PORTAMENTO_ON_OFF  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SUSTENUTO_PEDAL  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SOFT_PEDAL  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_LEGATO_PEDAL  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_HOLD_PEDAL_2  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SOUND_VARIATION  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SOUND_TIMBRE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SOUND_RELEASE_TIME  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SOUND_ATTACK_TIME  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SOUND_BRIGHTNESS  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SOUND_CTRL_6  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SOUND_CTRL_7  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SOUND_CTRL_8  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SOUND_CTRL_9  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_SOUND_CTRL_10  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_GENERAL_BUTTON_1  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_GENERAL_BUTTON_2  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_GENERAL_BUTTON_3  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_GENERAL_BUTTON_4  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_REVERB_LEVEL  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_TREMOLO_LEVEL  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CHORUS_LEVEL  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_CELESTE_LEVEL  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_PHASER_LEVEL  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_DATA_BUTTON_P1  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_DATA_BUTTON_M1  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_NON_REGISTER_COARSE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_NON_REGISTER_FINE  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_ALL_SOUND_OFF  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_ALL_CONTROLLERS_OFF  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_LOCAL_KEYBOARD  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_ALL_NOTES_OFF  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_OMNI_MODE_OFF  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_OMNI_MODE_ON  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_OMNI_MONOPHONIC_ON  // 0x0
  public    static  System.Int32                    AK_MIDI_CC_OMNI_POLYPHONIC_ON  // 0x0
  public    static  System.Int32                    AK_MIDI_WWISE_CMD_PLAY  // 0x0
  public    static  System.Int32                    AK_MIDI_WWISE_CMD_STOP  // 0x0
  public    static  System.Int32                    AK_MIDI_WWISE_CMD_PAUSE  // 0x0
  public    static  System.Int32                    AK_MIDI_WWISE_CMD_RESUME  // 0x0
  public    static  System.Int32                    AK_MIDI_WWISE_CMD_SEEK_MS  // 0x0
  public    static  System.Int32                    AK_MIDI_WWISE_CMD_SEEK_SAMPLES  // 0x0
  public    static  System.Int32                    AK_SPEAKER_FRONT_LEFT  // 0x0
  public    static  System.Int32                    AK_SPEAKER_FRONT_RIGHT  // 0x0
  public    static  System.Int32                    AK_SPEAKER_FRONT_CENTER  // 0x0
  public    static  System.Int32                    AK_SPEAKER_LOW_FREQUENCY  // 0x0
  public    static  System.Int32                    AK_SPEAKER_BACK_LEFT  // 0x0
  public    static  System.Int32                    AK_SPEAKER_BACK_RIGHT  // 0x0
  public    static  System.Int32                    AK_SPEAKER_BACK_CENTER  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SIDE_LEFT  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SIDE_RIGHT  // 0x0
  public    static  System.Int32                    AK_SPEAKER_TOP  // 0x0
  public    static  System.Int32                    AK_SPEAKER_HEIGHT_FRONT_LEFT  // 0x0
  public    static  System.Int32                    AK_SPEAKER_HEIGHT_FRONT_CENTER  // 0x0
  public    static  System.Int32                    AK_SPEAKER_HEIGHT_FRONT_RIGHT  // 0x0
  public    static  System.Int32                    AK_SPEAKER_HEIGHT_BACK_LEFT  // 0x0
  public    static  System.Int32                    AK_SPEAKER_HEIGHT_BACK_CENTER  // 0x0
  public    static  System.Int32                    AK_SPEAKER_HEIGHT_BACK_RIGHT  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_MONO  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_0POINT1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_1POINT1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_STEREO  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_2POINT1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_3STEREO  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_3POINT1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_4  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_4POINT1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_5  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_5POINT1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_6  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_6POINT1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_7  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_7POINT1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_SURROUND  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DPL2  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_HEIGHT_2  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_HEIGHT_4  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_HEIGHT_5  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_HEIGHT_ALL  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_HEIGHT_4_TOP  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_HEIGHT_5_TOP  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_222  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_8  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_9  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_9POINT1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_10  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_10POINT1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_11  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_11POINT1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_11_740  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_11POINT1_740  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_13_751  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_AURO_13POINT1_751  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DOLBY_5_0_2  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DOLBY_5_1_2  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DOLBY_6_0_2  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DOLBY_6_1_2  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DOLBY_6_0_4  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DOLBY_6_1_4  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DOLBY_7_0_2  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DOLBY_7_1_2  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DOLBY_7_0_4  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DOLBY_7_1_4  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_ALL_SPEAKERS  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_FRONT_LEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_FRONT_RIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_CENTER  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_NOCENTER_BACK_LEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_NOCENTER_BACK_RIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_NOCENTER_SIDE_LEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_NOCENTER_SIDE_RIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_WITHCENTER_BACK_LEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_WITHCENTER_BACK_RIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_WITHCENTER_SIDE_LEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_LEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_RIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_LEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_RIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_0_LFE  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_1_CENTER  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_1_LFE  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_2_LEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_2_RIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_2_LFE  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_3_LEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_3_RIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_3_CENTER  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_3_LFE  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_4_FRONTLEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_4_FRONTRIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_4_REARLEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_4_REARRIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_4_LFE  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_5_FRONTLEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_5_FRONTRIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_5_CENTER  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_5_REARLEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_5_REARRIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_5_LFE  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_6_FRONTLEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_6_FRONTRIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_6_REARLEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_6_REARRIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_6_SIDELEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_6_SIDERIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_6_LFE  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_7_FRONTLEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_7_FRONTRIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_7_CENTER  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_7_REARLEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_7_REARRIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_7_SIDELEFT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_7_SIDERIGHT  // 0x0
  public    static  System.Int32                    AK_IDX_SETUP_7_LFE  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_0_1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_1_0_CENTER  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_1_1_CENTER  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_2_0  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_2_1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_3_0  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_3_1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_FRONT  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_4_0  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_4_1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_5_0  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_5_1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_6_0  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_6_1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_7_0  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_7_1  // 0x0
  public    static  System.Int32                    AK_SPEAKER_SETUP_DEFAULT_PLANE  // 0x0
  public    static  System.Int32                    AK_SUPPORTED_STANDARD_CHANNEL_MASK  // 0x0
  public    static  System.Int32                    AK_STANDARD_MAX_NUM_CHANNELS  // 0x0
  public    static  System.Int32                    AK_MAX_AMBISONICS_ORDER  // 0x0
  public    static  System.Int32                    AK_MAX_NUM_TEXTURE  // 0x0
  public    static  System.Int32                    AK_MAX_REFLECT_ORDER  // 0x0
  public    static  System.Int32                    AK_MAX_REFLECTION_PATH_LENGTH  // 0x0
  public    static  System.Int32                    AK_STOCHASTIC_RESERVE_LENGTH  // 0x0
  public    static  System.Int32                    AK_MAX_SOUND_PROPAGATION_DEPTH  // 0x0
  public    static  System.Int32                    AK_MAX_SOUND_PROPAGATION_WIDTH  // 0x0
  public    static  System.Double                   AK_SA_DIFFRACTION_DOT_EPSILON  // 0x0
  public    static  System.Double                   AK_DEFAULT_GEOMETRY_POSITION_X  // 0x0
  public    static  System.Double                   AK_DEFAULT_GEOMETRY_POSITION_Y  // 0x0
  public    static  System.Double                   AK_DEFAULT_GEOMETRY_POSITION_Z  // 0x0
  public    static  System.Double                   AK_DEFAULT_GEOMETRY_FRONT_X  // 0x0
  public    static  System.Double                   AK_DEFAULT_GEOMETRY_FRONT_Y  // 0x0
  public    static  System.Double                   AK_DEFAULT_GEOMETRY_FRONT_Z  // 0x0
  public    static  System.Double                   AK_DEFAULT_GEOMETRY_TOP_X  // 0x0
  public    static  System.Double                   AK_DEFAULT_GEOMETRY_TOP_Y  // 0x0
  public    static  System.Double                   AK_DEFAULT_GEOMETRY_TOP_Z  // 0x0
  private   static  AkSoundEngine.GameObjectHashFunctiongameObjectHash  // 0x0
  public    static  System.UInt32                   AK_PENDING_EVENT_LOAD_ID  // 0x0
METHODS:
  System.UInt32 JoystickIdToWwiseId(System.UInt32 joyStickID)
  System.UInt32 get_AK_INVALID_SHARE_SET_ID()
  System.UInt32 get_AK_INVALID_PIPELINE_ID()
  System.UInt64 get_AK_INVALID_AUDIO_OBJECT_ID()
  System.UInt32 get_AK_SOUNDBANK_VERSION()
  System.UInt32 get_AkJobType_Generic()
  System.UInt32 get_AkJobType_AudioProcessing()
  System.UInt32 get_AkJobType_SpatialAudio()
  System.UInt32 get_AK_NUM_JOB_TYPES()
  UnityEngine.Vector3 ConvertAkVector64ToAkVector(AkVector64 in_)
  AkTransform ConvertAkWorldTransformToAkTransform(AkWorldTransform in_)
  AkVector64 ConvertAkVectorToAkVector64(UnityEngine.Vector3 in_)
  AkWorldTransform ConvertAkTransformToAkWorldTransform(AkTransform in_)
  System.UInt16 get_AK_INT()
  System.UInt16 get_AK_FLOAT()
  System.Byte get_AK_INTERLEAVED()
  System.Byte get_AK_NONINTERLEAVED()
  System.UInt32 get_AK_LE_NATIVE_BITSPERSAMPLE()
  System.UInt32 get_AK_LE_NATIVE_SAMPLETYPE()
  System.UInt32 get_AK_LE_NATIVE_INTERLEAVE()
  System.Boolean IsBankCodecID(System.UInt32 in_codecID)
  System.UInt32 DynamicSequenceOpen(System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType)
  System.UInt32 DynamicSequenceOpen(System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie)
  System.UInt32 DynamicSequenceOpen(System.UInt64 in_gameObjectID)
  AKRESULT DynamicSequenceClose(System.UInt32 in_playingID)
  AKRESULT DynamicSequencePlay(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT DynamicSequencePlay(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration)
  AKRESULT DynamicSequencePlay(System.UInt32 in_playingID)
  AKRESULT DynamicSequencePause(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT DynamicSequencePause(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration)
  AKRESULT DynamicSequencePause(System.UInt32 in_playingID)
  AKRESULT DynamicSequenceResume(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT DynamicSequenceResume(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration)
  AKRESULT DynamicSequenceResume(System.UInt32 in_playingID)
  AKRESULT DynamicSequenceStop(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT DynamicSequenceStop(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration)
  AKRESULT DynamicSequenceStop(System.UInt32 in_playingID)
  AKRESULT DynamicSequenceBreak(System.UInt32 in_playingID)
  AKRESULT Seek(System.UInt32 in_playingID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker)
  AKRESULT Seek(System.UInt32 in_playingID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker)
  AKRESULT DynamicSequenceGetPauseTimes(System.UInt32 in_playingID, System.UInt32& out_uTime, System.UInt32& out_uDuration)
  AkPlaylist DynamicSequenceLockPlaylist(System.UInt32 in_playingID)
  AKRESULT DynamicSequenceUnlockPlaylist(System.UInt32 in_playingID)
  System.Boolean IsInitialized()
  AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings)
  AkChannelConfig GetSpeakerConfiguration(System.UInt64 in_idOutput)
  AkChannelConfig GetSpeakerConfiguration()
  AKRESULT GetOutputDeviceConfiguration(System.UInt64 in_idOutput, AkChannelConfig io_channelConfig, Ak3DAudioSinkCapabilities io_capabilities)
  AKRESULT GetPanningRule(System.Int32& out_ePanningRule, System.UInt64 in_idOutput)
  AKRESULT GetPanningRule(System.Int32& out_ePanningRule)
  AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, System.UInt64 in_idOutput)
  AKRESULT SetPanningRule(AkPanningRule in_ePanningRule)
  AKRESULT GetSpeakerAngles(System.Single[] io_pfSpeakerAngles, System.UInt32& io_uNumAngles, System.Single& out_fHeightAngle, System.UInt64 in_idOutput)
  AKRESULT GetSpeakerAngles(System.Single[] io_pfSpeakerAngles, System.UInt32& io_uNumAngles, System.Single& out_fHeightAngle)
  AKRESULT SetSpeakerAngles(System.Single[] in_pfSpeakerAngles, System.UInt32 in_uNumAngles, System.Single in_fHeightAngle, System.UInt64 in_idOutput)
  AKRESULT SetSpeakerAngles(System.Single[] in_pfSpeakerAngles, System.UInt32 in_uNumAngles, System.Single in_fHeightAngle)
  AKRESULT SetVolumeThreshold(System.Single in_fVolumeThresholdDB)
  AKRESULT SetMaxNumVoicesLimit(System.UInt16 in_maxNumberVoices)
  AKRESULT SetJobMgrMaxActiveWorkers(System.UInt32 in_jobType, System.UInt32 in_uNewMaxActiveWorkers)
  AKRESULT RenderAudio(System.Boolean in_bAllowSyncRender)
  AKRESULT RenderAudio()
  AKRESULT RegisterPluginDLL(System.String in_DllName, System.String in_DllPath)
  AKRESULT RegisterPluginDLL(System.String in_DllName)
  System.Boolean IsPluginRegistered(AkPluginType in_eType, System.UInt32 in_ulCompanyID, System.UInt32 in_ulPluginID)
  System.UInt32 GetIDFromString(System.String in_pszString)
  System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID)
  System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
  System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie)
  System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID)
  System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID)
  System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
  System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie)
  System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID)
  AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID)
  AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration)
  AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID)
  AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType)
  AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID)
  AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration)
  AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID)
  AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType)
  System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_playingID)
  System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie)
  System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts, System.Boolean in_bAbsoluteOffsets)
  System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts)
  AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_playingID)
  AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID)
  AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID)
  AKRESULT StopMIDIOnEvent()
  AKRESULT PinEventInStreamCache(System.UInt32 in_eventID, System.SByte in_uActivePriority, System.SByte in_uInactivePriority)
  AKRESULT PinEventInStreamCache(System.String in_pszEventName, System.SByte in_uActivePriority, System.SByte in_uInactivePriority)
  AKRESULT UnpinEventInStreamCache(System.UInt32 in_eventID)
  AKRESULT UnpinEventInStreamCache(System.String in_pszEventName)
  AKRESULT GetBufferStatusForPinnedEvent(System.UInt32 in_eventID, System.Single& out_fPercentBuffered, System.Int32& out_bCachePinnedMemoryFull)
  AKRESULT GetBufferStatusForPinnedEvent(System.String in_pszEventName, System.Single& out_fPercentBuffered, System.Int32& out_bCachePinnedMemoryFull)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Int32 in_iPosition)
  AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID)
  AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker)
  AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Int32 in_iPosition)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Single in_fPercent)
  AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID)
  AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker)
  AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Single in_fPercent)
  System.Void CancelEventCallbackCookie(System.Object in_pCookie)
  System.Void CancelEventCallbackGameObject(System.UInt64 in_gameObjectID)
  System.Void CancelEventCallback(System.UInt32 in_playingID)
  AKRESULT GetSourcePlayPosition(System.UInt32 in_PlayingID, System.Int32& out_puPosition, System.Boolean in_bExtrapolate)
  AKRESULT GetSourcePlayPosition(System.UInt32 in_PlayingID, System.Int32& out_puPosition)
  AKRESULT GetSourceStreamBuffering(System.UInt32 in_PlayingID, System.Int32& out_buffering, System.Int32& out_bIsBuffering)
  System.Void StopAll(System.UInt64 in_gameObjectID)
  System.Void StopAll()
  System.Void StopPlayingID(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
  System.Void StopPlayingID(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration)
  System.Void StopPlayingID(System.UInt32 in_playingID)
  System.Void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
  System.Void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, System.UInt32 in_playingID, System.Int32 in_uTransitionDuration)
  System.Void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, System.UInt32 in_playingID)
  System.Void SetRandomSeed(System.UInt32 in_uSeed)
  System.Void MuteBackgroundMusic(System.Boolean in_bMute)
  System.Boolean GetBackgroundMusicMute()
  AKRESULT SendPluginCustomGameData(System.UInt32 in_busID, System.UInt64 in_busObjectID, AkPluginType in_eType, System.UInt32 in_uCompanyID, System.UInt32 in_uPluginID, System.IntPtr in_pData, System.UInt32 in_uSizeInBytes)
  AKRESULT UnregisterAllGameObj()
  AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags)
  AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType)
  AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions)
  AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags)
  AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType)
  AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions)
  AKRESULT SetScalingFactor(System.UInt64 in_GameObjectID, System.Single in_fAttenuationScalingFactor)
  AKRESULT SetDistanceProbe(System.UInt64 in_listenerGameObjectID, System.UInt64 in_distanceProbeGameObjectID)
  AKRESULT ClearBanks()
  AKRESULT SetBankLoadIOSettings(System.Single in_fThroughput, System.SByte in_priority)
  AKRESULT LoadBank(System.String in_pszString, System.UInt32& out_bankID, System.UInt32 in_bankType)
  AKRESULT LoadBank(System.String in_pszString, System.UInt32& out_bankID)
  AKRESULT LoadBank(System.UInt32 in_bankID, System.UInt32 in_bankType)
  AKRESULT LoadBank(System.UInt32 in_bankID)
  AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID)
  AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID, System.UInt32& out_bankType)
  AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID)
  AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID, System.UInt32& out_bankType)
  AKRESULT LoadBank(System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID, System.UInt32 in_bankType)
  AKRESULT LoadBank(System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID)
  AKRESULT LoadBank(System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32 in_bankType)
  AKRESULT LoadBank(System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie)
  AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID)
  AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID, System.UInt32& out_bankType)
  AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID)
  AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID, System.UInt32& out_bankType)
  AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_bankType)
  AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr)
  AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_bankType)
  AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr)
  AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32 in_bankType)
  AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie)
  AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32 in_bankType)
  AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie)
  System.Void CancelBankCallbackCookie(System.Object in_pCookie)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkBankContent in_uFlags, System.UInt32 in_bankType)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkBankContent in_uFlags)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkBankContent in_uFlags, System.UInt32 in_bankType)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkBankContent in_uFlags)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags, System.UInt32 in_bankType)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags, System.UInt32 in_bankType)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags)
  AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie)
  AKRESULT ClearPreparedEvents()
  AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.String[] in_ppszString, System.UInt32 in_uNumEvent)
  AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.UInt32[] in_pEventID, System.UInt32 in_uNumEvent)
  AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.String[] in_ppszString, System.UInt32 in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie)
  AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.UInt32[] in_pEventID, System.UInt32 in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie)
  AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, System.UInt32 in_uNumSourceSettings)
  AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, System.UInt32 in_uNumSourceSettings)
  AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.String in_pszGroupName, System.String[] in_ppszGameSyncName, System.UInt32 in_uNumGameSyncs)
  AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.UInt32 in_GroupID, System.UInt32[] in_paGameSyncID, System.UInt32 in_uNumGameSyncs)
  AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.String in_pszGroupName, System.String[] in_ppszGameSyncName, System.UInt32 in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie)
  AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.UInt32 in_GroupID, System.UInt32[] in_paGameSyncID, System.UInt32 in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie)
  AKRESULT AddListener(System.UInt64 in_emitterGameObj, System.UInt64 in_listenerGameObj)
  AKRESULT RemoveListener(System.UInt64 in_emitterGameObj, System.UInt64 in_listenerGameObj)
  AKRESULT AddDefaultListener(System.UInt64 in_listenerGameObj)
  AKRESULT RemoveDefaultListener(System.UInt64 in_listenerGameObj)
  AKRESULT ResetListenersToDefault(System.UInt64 in_emitterGameObj)
  AKRESULT SetListenerSpatialization(System.UInt64 in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig, System.Single[] in_pVolumeOffsets)
  AKRESULT SetListenerSpatialization(System.UInt64 in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig)
  AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration)
  AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID)
  AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value)
  AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration)
  AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID)
  AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value)
  AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration)
  AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID)
  AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration)
  AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID)
  AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration)
  AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID)
  AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID)
  AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration)
  AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID)
  AKRESULT ResetRTPCValue(System.String in_pszRtpcName)
  AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration)
  AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID)
  AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration)
  AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID)
  AKRESULT SetSwitch(System.UInt32 in_switchGroup, System.UInt32 in_switchState, System.UInt64 in_gameObjectID)
  AKRESULT SetSwitch(System.String in_pszSwitchGroup, System.String in_pszSwitchState, System.UInt64 in_gameObjectID)
  AKRESULT PostTrigger(System.UInt32 in_triggerID, System.UInt64 in_gameObjectID)
  AKRESULT PostTrigger(System.String in_pszTrigger, System.UInt64 in_gameObjectID)
  AKRESULT SetState(System.UInt32 in_stateGroup, System.UInt32 in_state)
  AKRESULT SetState(System.String in_pszStateGroup, System.String in_pszState)
  AKRESULT SetGameObjectAuxSendValues(System.UInt64 in_gameObjectID, AkAuxSendArray in_aAuxSendValues, System.UInt32 in_uNumSendValues)
  AKRESULT SetGameObjectOutputBusVolume(System.UInt64 in_emitterObjID, System.UInt64 in_listenerObjID, System.Single in_fControlValue)
  AKRESULT SetActorMixerEffect(System.UInt32 in_audioNodeID, System.UInt32 in_uFXIndex, System.UInt32 in_shareSetID)
  AKRESULT SetBusEffect(System.UInt32 in_audioNodeID, System.UInt32 in_uFXIndex, System.UInt32 in_shareSetID)
  AKRESULT SetBusEffect(System.String in_pszBusName, System.UInt32 in_uFXIndex, System.UInt32 in_shareSetID)
  AKRESULT SetOutputDeviceEffect(System.UInt64 in_outputDeviceID, System.UInt32 in_uFXIndex, System.UInt32 in_FXShareSetID)
  AKRESULT SetMixer(System.UInt32 in_audioNodeID, System.UInt32 in_shareSetID)
  AKRESULT SetMixer(System.String in_pszBusName, System.UInt32 in_shareSetID)
  AKRESULT SetBusConfig(System.UInt32 in_audioNodeID, AkChannelConfig in_channelConfig)
  AKRESULT SetBusConfig(System.String in_pszBusName, AkChannelConfig in_channelConfig)
  AKRESULT SetObjectObstructionAndOcclusion(System.UInt64 in_EmitterID, System.UInt64 in_ListenerID, System.Single in_fObstructionLevel, System.Single in_fOcclusionLevel)
  AKRESULT SetMultipleObstructionAndOcclusion(System.UInt64 in_EmitterID, System.UInt64 in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, System.UInt32 in_uNumOcclusionObstruction)
  AKRESULT StartOutputCapture(System.String in_CaptureFileName)
  AKRESULT StopOutputCapture()
  AKRESULT AddOutputCaptureMarker(System.String in_MarkerText)
  AKRESULT AddOutputCaptureBinaryMarker(System.IntPtr in_pMarkerData, System.UInt32 in_uMarkerDataSize)
  System.UInt32 GetSampleRate()
  AKRESULT StartProfilerCapture(System.String in_CaptureFileName)
  AKRESULT StopProfilerCapture()
  AKRESULT SetOfflineRenderingFrameTime(System.Single in_fFrameTimeInSeconds)
  AKRESULT SetOfflineRendering(System.Boolean in_bEnableOfflineRendering)
  AKRESULT RemoveOutput(System.UInt64 in_idOutput)
  AKRESULT ReplaceOutput(AkOutputSettings in_Settings, System.UInt64 in_outputDeviceId, System.UInt64& out_pOutputDeviceId)
  AKRESULT ReplaceOutput(AkOutputSettings in_Settings, System.UInt64 in_outputDeviceId)
  System.UInt64 GetOutputID(System.UInt32 in_idShareset, System.UInt32 in_idDevice)
  System.UInt64 GetOutputID(System.String in_szShareSet, System.UInt32 in_idDevice)
  AKRESULT SetBusDevice(System.UInt32 in_idBus, System.UInt32 in_idNewDevice)
  AKRESULT SetBusDevice(System.String in_BusName, System.String in_DeviceName)
  AKRESULT GetDeviceList(System.UInt32 in_ulCompanyID, System.UInt32 in_ulPluginID, System.UInt32& io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions)
  AKRESULT GetDeviceList(System.UInt32 in_audioDeviceShareSetID, System.UInt32& io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions)
  AKRESULT SetOutputVolume(System.UInt64 in_idOutput, System.Single in_fVolume)
  AKRESULT GetDeviceSpatialAudioSupport(System.UInt32 in_idDevice)
  AKRESULT Suspend(System.Boolean in_bRenderAnyway, System.Boolean in_bFadeOut)
  AKRESULT Suspend(System.Boolean in_bRenderAnyway)
  AKRESULT Suspend()
  AKRESULT WakeupFromSuspend(System.UInt32 in_uDelayMs)
  AKRESULT WakeupFromSuspend()
  System.UInt32 GetBufferTick()
  System.UInt64 GetSampleTick()
  System.Byte get_AK_INVALID_MIDI_CHANNEL()
  System.Byte get_AK_INVALID_MIDI_NOTE()
  System.Void AkMemGetCategoryStats(System.Int32 in_poolId, AkMemCategroyStats out_poolStats)
  System.Void AkMemGetGlobalStats(AkMemGlobalStats out_stats)
  System.Void StartProfileThreadUsage()
  System.UInt64 StopProfileThreadUsage()
  System.Void DumpToFile(System.String pszFilename)
  System.UInt64 GetGlobalUsed()
  System.UInt64 GetGlobalReserved()
  AKRESULT GetPlayingSegmentInfo(System.UInt32 in_PlayingID, AkSegmentInfo out_segmentInfo, System.Boolean in_bExtrapolate)
  AKRESULT GetPlayingSegmentInfo(System.UInt32 in_PlayingID, AkSegmentInfo out_segmentInfo)
  AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus)
  AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID)
  AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID)
  AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID)
  AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel)
  AKRESULT PostCodeVarArg(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, MsgContext msgContext)
  AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus)
  AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID)
  AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID)
  AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID)
  AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel)
  AKRESULT ResetTranslator()
  System.Int32 GetTimeStamp()
  System.Void MonitorStreamMgrInit(AkStreamMgrSettings in_streamMgrSettings)
  System.Void MonitorStreamingDeviceInit(System.UInt32 in_deviceID, AkDeviceSettings in_deviceSettings)
  System.Void MonitorStreamingDeviceDestroyed(System.UInt32 in_deviceID)
  System.Void MonitorStreamMgrTerm()
  System.Void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties)
  System.UInt32 ResolveDialogueEvent(System.UInt32 in_eventID, System.UInt32[] in_aArgumentValues, System.UInt32 in_uNumArguments, System.UInt32 in_idSequence)
  System.UInt32 ResolveDialogueEvent(System.UInt32 in_eventID, System.UInt32[] in_aArgumentValues, System.UInt32 in_uNumArguments)
  AKRESULT GetDialogueEventCustomPropertyValue(System.UInt32 in_eventID, System.UInt32 in_uPropID, System.Int32& out_iValue)
  AKRESULT GetDialogueEventCustomPropertyValue(System.UInt32 in_eventID, System.UInt32 in_uPropID, System.Single& out_fValue)
  AKRESULT GetPosition(System.UInt64 in_GameObjectID, AkWorldTransform out_rPosition)
  AKRESULT GetListenerPosition(System.UInt64 in_uListenerID, AkWorldTransform out_rPosition)
  AKRESULT GetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType)
  AKRESULT GetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType)
  AKRESULT GetSwitch(System.UInt32 in_switchGroup, System.UInt64 in_gameObjectID, System.UInt32& out_rSwitchState)
  AKRESULT GetSwitch(System.String in_pstrSwitchGroupName, System.UInt64 in_GameObj, System.UInt32& out_rSwitchState)
  AKRESULT GetState(System.UInt32 in_stateGroup, System.UInt32& out_rState)
  AKRESULT GetState(System.String in_pstrStateGroupName, System.UInt32& out_rState)
  AKRESULT GetGameObjectAuxSendValues(System.UInt64 in_gameObjectID, AkAuxSendArray out_paAuxSendValues, System.UInt32& io_ruNumSendValues)
  AKRESULT GetGameObjectDryLevelValue(System.UInt64 in_EmitterID, System.UInt64 in_ListenerID, System.Single& out_rfControlValue)
  AKRESULT GetObjectObstructionAndOcclusion(System.UInt64 in_EmitterID, System.UInt64 in_ListenerID, System.Single& out_rfObstructionLevel, System.Single& out_rfOcclusionLevel)
  AKRESULT QueryAudioObjectIDs(System.UInt32 in_eventID, System.UInt32& io_ruNumItems, AkObjectInfoArray out_aObjectInfos)
  AKRESULT QueryAudioObjectIDs(System.String in_pszEventName, System.UInt32& io_ruNumItems, AkObjectInfoArray out_aObjectInfos)
  AKRESULT GetPositioningInfo(System.UInt32 in_ObjectID, AkPositioningInfo out_rPositioningInfo)
  System.Boolean GetIsGameObjectActive(System.UInt64 in_GameObjId)
  System.Single GetMaxRadius(System.UInt64 in_GameObjId)
  System.UInt32 GetEventIDFromPlayingID(System.UInt32 in_playingID)
  System.UInt64 GetGameObjectFromPlayingID(System.UInt32 in_playingID)
  AKRESULT GetPlayingIDsFromGameObject(System.UInt64 in_GameObjId, System.UInt32& io_ruNumIDs, System.UInt32[] out_aPlayingIDs)
  AKRESULT GetCustomPropertyValue(System.UInt32 in_ObjectID, System.UInt32 in_uPropID, System.Int32& out_iValue)
  AKRESULT GetCustomPropertyValue(System.UInt32 in_ObjectID, System.UInt32 in_uPropID, System.Single& out_fValue)
  System.Void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(System.UInt32& io_uChannelMask)
  System.Void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(System.UInt32& io_uChannelMask)
  System.Void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(System.UInt32& io_uChannelMask)
  System.Byte ChannelMaskToNumChannels(System.UInt32 in_uChannelMask)
  System.UInt32 ChannelMaskFromNumChannels(System.UInt32 in_uNumChannels)
  System.Byte ChannelBitToIndex(System.UInt32 in_uChannelBit, System.UInt32 in_uChannelMask)
  System.Boolean HasSurroundChannels(System.UInt32 in_uChannelMask)
  System.Boolean HasStrictlyOnePairOfSurroundChannels(System.UInt32 in_uChannelMask)
  System.Boolean HasSideAndRearChannels(System.UInt32 in_uChannelMask)
  System.Boolean HasHeightChannels(System.UInt32 in_uChannelMask)
  System.UInt32 BackToSideChannels(System.UInt32 in_uChannelMask)
  System.UInt32 StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, System.UInt32 in_uChannelMask, System.UInt32 in_uChannelIdx)
  System.UInt32 get_kDefaultDiffractionMaxEdges()
  System.UInt32 get_kDefaultDiffractionMaxPaths()
  System.Single get_kMaxDiffraction()
  System.UInt32 get_kHashListBlockAllocItemCount()
  System.UInt32 get_kDiffractionMaxEdges()
  System.UInt32 get_kDiffractionMaxPaths()
  System.UInt32 get_kPortalToPortalDiffractionMaxPaths()
  AKRESULT SetGameObjectRadius(System.UInt64 in_gameObjectID, System.Single in_outerRadius, System.Single in_innerRadius)
  AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_name, System.UInt32 in_AuxBusID, System.UInt64 in_gameObjectID)
  AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_name, System.UInt32 in_AuxBusID)
  AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_name)
  AKRESULT RemoveImageSource(System.UInt32 in_srcID, System.UInt32 in_AuxBusID, System.UInt64 in_gameObjectID)
  AKRESULT RemoveImageSource(System.UInt32 in_srcID, System.UInt32 in_AuxBusID)
  AKRESULT RemoveImageSource(System.UInt32 in_srcID)
  AKRESULT ClearImageSources(System.UInt32 in_AuxBusID, System.UInt64 in_gameObjectID)
  AKRESULT ClearImageSources(System.UInt32 in_AuxBusID)
  AKRESULT ClearImageSources()
  AKRESULT RemoveGeometry(System.UInt64 in_SetID)
  AKRESULT RemoveGeometryInstance(System.UInt64 in_GeometryInstanceID)
  AKRESULT RemoveRoom(System.UInt64 in_RoomID)
  AKRESULT RemovePortal(System.UInt64 in_PortalID)
  AKRESULT SetReverbZone(System.UInt64 in_ReverbZone, System.UInt64 in_ParentRoom, System.Single in_transitionRegionWidth)
  AKRESULT RemoveReverbZone(System.UInt64 in_ReverbZone)
  AKRESULT SetGameObjectInRoom(System.UInt64 in_gameObjectID, System.UInt64 in_CurrentRoomID)
  AKRESULT UnsetGameObjectInRoom(System.UInt64 in_gameObjectID)
  AKRESULT SetReflectionsOrder(System.UInt32 in_uReflectionsOrder, System.Boolean in_bUpdatePaths)
  AKRESULT SetDiffractionOrder(System.UInt32 in_uDiffractionOrder, System.Boolean in_bUpdatePaths)
  AKRESULT SetMaxEmitterRoomAuxSends(System.UInt32 in_uMaxEmitterRoomAuxSends)
  AKRESULT SetNumberOfPrimaryRays(System.UInt32 in_uNbPrimaryRays)
  AKRESULT SetLoadBalancingSpread(System.UInt32 in_uNbFrames)
  AKRESULT SetEarlyReflectionsAuxSend(System.UInt64 in_gameObjectID, System.UInt32 in_auxBusID)
  AKRESULT SetEarlyReflectionsVolume(System.UInt64 in_gameObjectID, System.Single in_fSendVolume)
  AKRESULT SetPortalObstructionAndOcclusion(System.UInt64 in_PortalID, System.Single in_fObstruction, System.Single in_fOcclusion)
  AKRESULT SetGameObjectToPortalObstruction(System.UInt64 in_gameObjectID, System.UInt64 in_PortalID, System.Single in_fObstruction)
  AKRESULT SetPortalToPortalObstruction(System.UInt64 in_PortalID0, System.UInt64 in_PortalID1, System.Single in_fObstruction)
  AKRESULT QueryWetDiffraction(System.UInt64 in_portal, System.Single& out_wetDiffraction)
  AKRESULT ResetStochasticEngine()
  System.UInt32 GetDeviceIDFromName(System.String in_szToken)
  System.String GetWindowsDeviceName(System.Int32 index, System.UInt32& out_uDeviceID, AkAudioDeviceState uDeviceStateMask)
  System.String GetWindowsDeviceName(System.Int32 index, System.UInt32& out_uDeviceID)
  System.UInt32 GetWindowsDeviceCount(AkAudioDeviceState uDeviceStateMask)
  System.UInt32 GetWindowsDeviceCount()
  System.Void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger)
  System.Void SetErrorLogger()
  System.Void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat)
  AKRESULT Init(AkInitializationSettings settings)
  AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings)
  AKRESULT InitCommunication(AkCommunicationSettings settings)
  System.Void Term()
  AKRESULT RegisterGameObjInternal(System.UInt64 in_GameObj)
  AKRESULT UnregisterGameObjInternal(System.UInt64 in_GameObj)
  AKRESULT RegisterGameObjInternal_WithName(System.UInt64 in_GameObj, System.String in_pszObjName)
  AKRESULT SetBasePath(System.String in_pszBasePath)
  AKRESULT SetCurrentLanguage(System.String in_pszAudioSrcPath)
  AKRESULT LoadFilePackage(System.String in_pszFilePackageName, System.UInt32& out_uPackageID)
  AKRESULT AddBasePath(System.String in_pszBasePath)
  AKRESULT SetGameName(System.String in_GameName)
  System.String GetCurrentLanguage()
  AKRESULT UnloadFilePackage(System.UInt32 in_uPackageID)
  AKRESULT UnloadAllFilePackages()
  AKRESULT SetObjectPosition(System.UInt64 in_GameObjectID, UnityEngine.Vector3 Pos, UnityEngine.Vector3 Front, UnityEngine.Vector3 Top)
  AKRESULT GetSourceMultiplePlayPositions(System.UInt32 in_PlayingID, System.UInt32[] out_audioNodeID, System.UInt32[] out_mediaID, System.Int32[] out_msTime, System.UInt32& io_pcPositions, System.Boolean in_bExtrapolate)
  AKRESULT GetSourceMultiplePlayPositions(System.UInt32 in_PlayingID, System.UInt32[] out_audioNodeID, System.UInt32[] out_mediaID, System.Int32[] out_msTime, System.UInt32& io_pcPositions)
  AKRESULT SetListeners(System.UInt64 in_emitterGameObj, System.UInt64[] in_pListenerGameObjs, System.UInt32 in_uNumListeners)
  AKRESULT SetDefaultListeners(System.UInt64[] in_pListenerObjs, System.UInt32 in_uNumListeners)
  System.UInt32 GetNumOutputDevices(System.UInt32 in_AudioDeviceShareSetID)
  AKRESULT AddOutput(AkOutputSettings in_Settings, System.UInt64& out_pDeviceID, System.UInt64[] in_pListenerIDs, System.UInt32 in_uNumListeners)
  AKRESULT AddOutput(AkOutputSettings in_Settings, System.UInt64& out_pDeviceID, System.UInt64[] in_pListenerIDs)
  AKRESULT AddOutput(AkOutputSettings in_Settings, System.UInt64& out_pDeviceID)
  AKRESULT AddOutput(AkOutputSettings in_Settings)
  System.Void GetDefaultStreamSettings(AkStreamMgrSettings out_settings)
  System.Void GetDefaultDeviceSettings(AkDeviceSettings out_settings)
  System.Void GetDefaultMusicSettings(AkMusicSettings out_settings)
  System.Void GetDefaultInitSettings(AkInitSettings out_settings)
  System.Void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings)
  System.UInt32 GetMajorMinorVersion()
  System.UInt32 GetSubminorBuildVersion()
  System.Void StartResourceMonitoring()
  System.Void StopResourceMonitoring()
  System.Void GetResourceMonitorDataSummary(AkResourceMonitorDataSummary resourceMonitorDataSummary)
  System.Void StartDeviceCapture(System.UInt64 in_idOutputDeviceID)
  System.Void StopDeviceCapture(System.UInt64 in_idOutputDeviceID)
  System.Void ClearCaptureData()
  System.UInt32 UpdateCaptureSampleCount(System.UInt64 in_idOutputDeviceID)
  System.UInt32 GetCaptureSamples(System.UInt64 in_idOutputDeviceID, System.Single[] out_pSamples, System.UInt32 in_uBufferSize)
  AKRESULT SetRoomPortal(System.UInt64 in_PortalID, System.UInt64 FrontRoom, System.UInt64 BackRoom, AkTransform Transform, AkExtent Extent, System.Boolean bEnabled, System.String in_pName)
  AKRESULT SetRoom(System.UInt64 in_RoomID, AkRoomParams in_roomParams, System.UInt64 GeometryInstanceID, System.String in_pName)
  AKRESULT RegisterSpatialAudioListener(System.UInt64 in_gameObjectID)
  AKRESULT UnregisterSpatialAudioListener(System.UInt64 in_gameObjectID)
  AKRESULT SetGeometry(System.UInt64 in_GeomSetID, AkTriangleArray Triangles, System.UInt32 NumTriangles, UnityEngine.Vector3[] Vertices, System.UInt32 NumVertices, AkAcousticSurfaceArray Surfaces, System.UInt32 NumSurfaces, System.Boolean EnableDiffraction, System.Boolean EnableDiffractionOnBoundaryEdges)
  AKRESULT SetGeometryInstance(System.UInt64 in_GeomInstanceID, AkTransform Transform, UnityEngine.Vector3 Scale, System.UInt64 GeometrySetID, System.UInt64 RoomID, System.Boolean UseForReflectionAndDiffraction)
  AKRESULT QueryReflectionPaths(System.UInt64 in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkReflectionPathInfoArray out_aPaths, System.UInt32& io_uArraySize)
  AKRESULT QueryDiffractionPaths(System.UInt64 in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkDiffractionPathInfoArray out_aPaths, System.UInt32& io_uArraySize)
  System.Void PerformStreamMgrIO()
  System.Void HgMemShrink()
  System.UInt64 HgGetGlobalMemoryUsed()
  System.UInt64 HgGetGlobalMemoryReserved()
  System.Void InitScePad()
  System.UInt32 GetMMDeviceIdFromPadContainerInfo(System.Int32 in_padHandle)
  System.String StringFromIntPtrString(System.IntPtr ptr)
  System.String StringFromIntPtrWString(System.IntPtr ptr)
  System.UInt64 InternalGameObjectHash(UnityEngine.GameObject gameObject)
  System.Void set_GameObjectHash(AkSoundEngine.GameObjectHashFunction value)
  System.UInt64 GetAkGameObjectID(UnityEngine.GameObject gameObject)
  AKRESULT RegisterGameObj(UnityEngine.GameObject gameObject)
  AKRESULT RegisterGameObj(UnityEngine.GameObject gameObject, System.String name)
  AKRESULT UnregisterGameObj(UnityEngine.GameObject gameObject)
  System.Void UnregisterAllGameObjects()
  System.String get_WwiseVersion()
  AKRESULT SetObjectPosition(UnityEngine.GameObject gameObject, UnityEngine.Transform transform)
  AKRESULT SetObjectPosition(UnityEngine.GameObject gameObject, System.Single posX, System.Single posY, System.Single posZ, System.Single frontX, System.Single frontY, System.Single frontZ, System.Single topX, System.Single topY, System.Single topZ)
  System.Void PreGameObjectAPICall(UnityEngine.GameObject gameObject, System.UInt64 id)
  System.UInt32 DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType)
  System.UInt32 DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie)
  System.UInt32 DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID)
  System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID)
  System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
  System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie)
  System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID)
  System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID)
  System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
  System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie)
  System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID)
  AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID)
  AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration)
  AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID)
  AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID)
  AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration)
  AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID)
  AKRESULT PostMIDIOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts)
  AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID)
  AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_playingID)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition)
  AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID)
  AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker)
  AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker)
  AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent)
  AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID)
  AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker)
  AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent)
  System.Void CancelEventCallbackGameObject(UnityEngine.GameObject in_gameObjectID)
  System.Void StopAll(UnityEngine.GameObject in_gameObjectID)
  AKRESULT SendPluginCustomGameData(System.UInt32 in_busID, UnityEngine.GameObject in_busObjectID, AkPluginType in_eType, System.UInt32 in_uCompanyID, System.UInt32 in_uPluginID, System.IntPtr in_pData, System.UInt32 in_uSizeInBytes)
  AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType)
  AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions)
  AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType)
  AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions)
  AKRESULT SetScalingFactor(UnityEngine.GameObject in_GameObjectID, System.Single in_fAttenuationScalingFactor)
  AKRESULT AddListener(UnityEngine.GameObject in_emitterGameObj, UnityEngine.GameObject in_listenerGameObj)
  AKRESULT RemoveListener(UnityEngine.GameObject in_emitterGameObj, UnityEngine.GameObject in_listenerGameObj)
  AKRESULT AddDefaultListener(UnityEngine.GameObject in_listenerGameObj)
  AKRESULT RemoveDefaultListener(UnityEngine.GameObject in_listenerGameObj)
  AKRESULT ResetListenersToDefault(UnityEngine.GameObject in_emitterGameObj)
  AKRESULT SetListenerSpatialization(UnityEngine.GameObject in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig, System.Single[] in_pVolumeOffsets)
  AKRESULT SetListenerSpatialization(UnityEngine.GameObject in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig)
  AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration)
  AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID)
  AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration)
  AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID)
  AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration)
  AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID)
  AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation)
  AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
  AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration)
  AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID)
  AKRESULT SetSwitch(System.UInt32 in_switchGroup, System.UInt32 in_switchState, UnityEngine.GameObject in_gameObjectID)
  AKRESULT SetSwitch(System.String in_pszSwitchGroup, System.String in_pszSwitchState, UnityEngine.GameObject in_gameObjectID)
  AKRESULT PostTrigger(System.UInt32 in_triggerID, UnityEngine.GameObject in_gameObjectID)
  AKRESULT PostTrigger(System.String in_pszTrigger, UnityEngine.GameObject in_gameObjectID)
  AKRESULT SetGameObjectAuxSendValues(UnityEngine.GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, System.UInt32 in_uNumSendValues)
  AKRESULT SetGameObjectOutputBusVolume(UnityEngine.GameObject in_emitterObjID, UnityEngine.GameObject in_listenerObjID, System.Single in_fControlValue)
  AKRESULT SetObjectObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, System.Single in_fObstructionLevel, System.Single in_fOcclusionLevel)
  AKRESULT SetMultipleObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, System.UInt32 in_uNumOcclusionObstruction)
  AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus)
  AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID)
  AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID)
  AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus)
  AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID)
  AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID)
  AKRESULT GetPosition(UnityEngine.GameObject in_GameObjectID, AkTransform out_rPosition)
  AKRESULT GetListenerPosition(UnityEngine.GameObject in_uIndex, AkTransform out_rPosition)
  AKRESULT GetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType)
  AKRESULT GetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType)
  AKRESULT GetSwitch(System.UInt32 in_switchGroup, UnityEngine.GameObject in_gameObjectID, System.UInt32& out_rSwitchState)
  AKRESULT GetSwitch(System.String in_pstrSwitchGroupName, UnityEngine.GameObject in_GameObj, System.UInt32& out_rSwitchState)
  AKRESULT GetGameObjectAuxSendValues(UnityEngine.GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, System.UInt32& io_ruNumSendValues)
  AKRESULT GetGameObjectDryLevelValue(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, System.Single& out_rfControlValue)
  AKRESULT GetObjectObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, System.Single& out_rfObstructionLevel, System.Single& out_rfOcclusionLevel)
  System.Boolean GetIsGameObjectActive(UnityEngine.GameObject in_GameObjId)
  System.Single GetMaxRadius(UnityEngine.GameObject in_GameObjId)
  AKRESULT GetPlayingIDsFromGameObject(UnityEngine.GameObject in_GameObjId, System.UInt32& io_ruNumIDs, System.UInt32[] out_aPlayingIDs)
  AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_imageSourceName, System.UInt32 in_AuxBusID, UnityEngine.GameObject in_gameObjectID)
  AKRESULT RemoveImageSource(System.UInt32 in_srcID, System.UInt32 in_AuxBusID, UnityEngine.GameObject in_gameObjectID)
  AKRESULT ClearImageSources(System.UInt32 in_AuxBusID, UnityEngine.GameObject in_gameObjectID)
  AKRESULT QueryReflectionPaths(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkReflectionPathInfoArray out_aPaths, System.UInt32& io_uArraySize)
  AKRESULT SetGameObjectInRoom(UnityEngine.GameObject in_gameObjectID, System.UInt64 in_CurrentRoomID)
  AKRESULT SetEarlyReflectionsAuxSend(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_auxBusID)
  AKRESULT SetEarlyReflectionsVolume(UnityEngine.GameObject in_gameObjectID, System.Single in_fSendVolume)
  AKRESULT QueryDiffractionPaths(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkDiffractionPathInfoArray out_aPaths, System.UInt32& io_uArraySize)
  AKRESULT RegisterGameObjInternal(UnityEngine.GameObject in_GameObj)
  AKRESULT UnregisterGameObjInternal(UnityEngine.GameObject in_GameObj)
  AKRESULT RegisterGameObjInternal_WithName(UnityEngine.GameObject in_GameObj, System.String in_pszObjName)
  AKRESULT SetObjectPosition(UnityEngine.GameObject in_GameObjectID, UnityEngine.Vector3 Pos, UnityEngine.Vector3 Front, UnityEngine.Vector3 Top)
  AKRESULT SetListeners(UnityEngine.GameObject in_emitterGameObj, System.UInt64[] in_pListenerGameObjs, System.UInt32 in_uNumListeners)
  AKRESULT RegisterSpatialAudioListener(UnityEngine.GameObject in_gameObjectID)
  AKRESULT UnregisterSpatialAudioListener(UnityEngine.GameObject in_gameObjectID)
  System.String StringFromIntPtrOSString(System.IntPtr ptr)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: AkThreadProperties
TYPE:  class
TOKEN: 0x200006F
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkThreadProperties obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void set_nPriority(System.Int32 value)
  System.Int32 get_nPriority()
  System.Void set_dwAffinityMask(System.UInt32 value)
  System.UInt32 get_dwAffinityMask()
  System.Void set_uStackSize(System.UInt32 value)
  System.UInt32 get_uStackSize()
  System.Void .ctor()
END_CLASS

CLASS: AkUnityPlatformSpecificSettings
TYPE:  class
TOKEN: 0x2000070
FIELDS:
  private           System.IntPtr                   swigCPtr  // 0x10
  protected         System.Boolean                  swigCMemOwn  // 0x18
METHODS:
  System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn)
  System.IntPtr getCPtr(AkUnityPlatformSpecificSettings obj)
  System.Void setCPtr(System.IntPtr cPtr)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: AudioAPI
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkAndroidSettings.PlatformAdvancedSettings.AudioAPINone  // 0x0
  public    static  AkAndroidSettings.PlatformAdvancedSettings.AudioAPIAAudio  // 0x0
  public    static  AkAndroidSettings.PlatformAdvancedSettings.AudioAPIOpenSL_ES  // 0x0
  public    static  AkAndroidSettings.PlatformAdvancedSettings.AudioAPIDefault  // 0x0
METHODS:
END_CLASS

CLASS: PlatformAdvancedSettings
TYPE:  class
TOKEN: 0x2000072
EXTENDS: AkCommonAdvancedSettings
FIELDS:
  public            AkAndroidSettings.PlatformAdvancedSettings.AudioAPIm_AudioAPI  // 0x50
  public            System.Boolean                  m_RoundFrameSizeToHardwareSize  // 0x54
  public            System.Boolean                  m_UseLowLatencyMode  // 0x55
METHODS:
  System.Void CopyTo(AkPlatformInitSettings settings)
  System.Void .ctor()
END_CLASS

CLASS: AkAndroidSettings
TYPE:  class
TOKEN: 0x2000071
EXTENDS: PlatformSettings
FIELDS:
  public            AkCommonUserSettings            UserSettings  // 0x30
  public            AkAndroidSettings.PlatformAdvancedSettingsAdvancedSettings  // 0x38
  public            AkCommonCommSettings            CommsSettings  // 0x40
METHODS:
  System.Void .ctor()
  AkCommonUserSettings GetUserSettings()
  AkCommonAdvancedSettings GetAdvancedSettings()
  AkCommonCommSettings GetCommsSettings()
END_CLASS

CLASS: AudioFormatDelegate
TYPE:  class
TOKEN: 0x2000075
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.UInt32 playingID, AkAudioFormat format)
  System.IAsyncResult BeginInvoke(System.UInt32 playingID, AkAudioFormat format, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: AudioFormatInteropDelegate
TYPE:  class
TOKEN: 0x2000076
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.UInt32 playingID, System.IntPtr format)
  System.IAsyncResult BeginInvoke(System.UInt32 playingID, System.IntPtr format, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: AudioSamplesDelegate
TYPE:  class
TOKEN: 0x2000077
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.UInt32 playingID, System.UInt32 channelIndex, System.Single[] samples)
  System.IAsyncResult BeginInvoke(System.UInt32 playingID, System.UInt32 channelIndex, System.Single[] samples, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: AudioSamplesInteropDelegate
TYPE:  class
TOKEN: 0x2000078
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.UInt32 playingID, System.Single[] samples, System.UInt32 channelIndex, System.UInt32 frames)
  System.IAsyncResult BeginInvoke(System.UInt32 playingID, System.Single[] samples, System.UInt32 channelIndex, System.UInt32 frames, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: AkAudioInputManager
TYPE:  class
TOKEN: 0x2000074
FIELDS:
  private   static  System.Boolean                  initialized  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.UInt32,AkAudioInputManager.AudioSamplesDelegate>audioSamplesDelegates  // 0x8
  private   static readonly System.Collections.Generic.Dictionary<System.UInt32,AkAudioInputManager.AudioFormatDelegate>audioFormatDelegates  // 0x10
  private   static readonly AkAudioFormat                   audioFormat  // 0x18
  private   static readonly AkAudioInputManager.AudioSamplesInteropDelegateaudioSamplesDelegate  // 0x20
  private   static readonly AkAudioInputManager.AudioFormatInteropDelegateaudioFormatDelegate  // 0x28
METHODS:
  System.UInt32 PostAudioInputEvent(System.UInt32 akEventID, UnityEngine.GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate)
  System.UInt32 PostAudioInputEvent(System.String akEventName, UnityEngine.GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate)
  System.Boolean InternalAudioSamplesDelegate(System.UInt32 playingID, System.Single[] samples, System.UInt32 channelIndex, System.UInt32 frames)
  System.Void InternalAudioFormatDelegate(System.UInt32 playingID, System.IntPtr format)
  System.Void TryInitialize()
  System.Void AddPlayingID(System.UInt32 playingID, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate)
  System.Void EventCallback(System.Object cookie, AkCallbackType type, AkCallbackInfo callbackInfo)
  System.Void .cctor()
END_CLASS

CLASS: AkBasePathGetter
TYPE:  class
TOKEN: 0x2000079
FIELDS:
  public    static readonly System.String                   DefaultBasePath  // 0x0
  private   static  System.Boolean                  <IsWwiseProjectAvailable>k__BackingField  // 0x8
  private           System.String                   <SoundBankBasePath>k__BackingField  // 0x10
  private           System.String                   <PersistentDataPath>k__BackingField  // 0x18
  private   static  System.String                   <WwiseProjectFullPath>k__BackingField  // 0x10
  private   static  AkBasePathGetter                Instance  // 0x18
METHODS:
  System.String GetPlatformName()
  System.Boolean get_IsWwiseProjectAvailable()
  System.Void set_IsWwiseProjectAvailable(System.Boolean value)
  System.String get_SoundBankBasePath()
  System.Void set_SoundBankBasePath(System.String value)
  System.String get_PersistentDataPath()
  System.Void set_PersistentDataPath(System.String value)
  System.String get_WwiseProjectFullPath()
  System.Void set_WwiseProjectFullPath(System.String value)
  System.String GetPlatformBasePath(System.String platformName)
  AkBasePathGetter Get()
  System.Void Reset()
  System.Void EvaluateGamePaths()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: EventCallback
TYPE:  class
TOKEN: 0x200007B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
  System.IAsyncResult BeginInvoke(System.Object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: MonitoringCallback
TYPE:  class
TOKEN: 0x200007C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.String in_msg)
  System.IAsyncResult BeginInvoke(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.String in_msg, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: BankCallback
TYPE:  class
TOKEN: 0x200007D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.UInt32 in_bankID, System.IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, System.Object in_Cookie)
  System.IAsyncResult BeginInvoke(System.UInt32 in_bankID, System.IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, System.Object in_Cookie, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: EventCallbackPackage
TYPE:  class
TOKEN: 0x200007E
FIELDS:
  public            AkCallbackManager.EventCallback callback  // 0x10
  public            System.Object                   cookie  // 0x18
  public            System.UInt32                   playingID  // 0x20
METHODS:
  System.Void Recycle(AkCallbackManager.EventCallbackPackage inPkg)
  AkCallbackManager.EventCallbackPackage Create(AkCallbackManager.EventCallback inCb, System.Object inCookie, System.UInt32& ioFlags)
  System.Void .ctor()
END_CLASS

CLASS: BankCallbackPackage
TYPE:  class
TOKEN: 0x200007F
FIELDS:
  public            AkCallbackManager.BankCallback  callback  // 0x10
  public            System.Object                   cookie  // 0x18
METHODS:
  AkCallbackManager.BankCallbackPackage Create(AkCallbackManager.BankCallback inCb, System.Object inCookie)
  System.Void Recycle(AkCallbackManager.BankCallbackPackage pkg)
  System.Void .ctor()
END_CLASS

CLASS: SimplePool`1
TYPE:  class
TOKEN: 0x2000080
FIELDS:
  private   readonly T[]                             m_pool  // 0x0
  private   readonly System.Int32                    m_poolSize  // 0x0
  private           System.Int32                    m_poolIndex  // 0x0
METHODS:
  System.Void .ctor(System.Int32 poolSize)
  T Alloc()
  System.Void Recycle(T obj)
END_CLASS

CLASS: BGMCallback
TYPE:  class
TOKEN: 0x2000081
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  AKRESULT Invoke(System.Boolean in_bOtherAudioPlaying, System.Object in_Cookie)
  System.IAsyncResult BeginInvoke(System.Boolean in_bOtherAudioPlaying, System.Object in_Cookie, System.AsyncCallback callback, System.Object object)
  AKRESULT EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: BGMCallbackPackage
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  public            AkCallbackManager.BGMCallback   m_Callback  // 0x10
  public            System.Object                   m_Cookie  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: AkCallbackManager
TYPE:  class
TOKEN: 0x200007A
FIELDS:
  private   static readonly AkEventCallbackInfo             AkEventCallbackInfo  // 0x0
  private   static readonly AkDynamicSequenceItemCallbackInfoAkDynamicSequenceItemCallbackInfo  // 0x8
  private   static readonly AkMIDIEventCallbackInfo         AkMIDIEventCallbackInfo  // 0x10
  private   static readonly AkMarkerCallbackInfo            AkMarkerCallbackInfo  // 0x18
  private   static readonly AkDurationCallbackInfo          AkDurationCallbackInfo  // 0x20
  private   static readonly AkMusicSyncCallbackInfo         AkMusicSyncCallbackInfo  // 0x28
  private   static readonly AkMusicPlaylistCallbackInfo     AkMusicPlaylistCallbackInfo  // 0x30
  private   static readonly AkAudioSourceChangeCallbackInfo AkAudioSourceChangeCallbackInfo  // 0x38
  private   static readonly AkMonitoringCallbackInfo        AkMonitoringCallbackInfo  // 0x40
  private   static readonly AkBankCallbackInfo              AkBankCallbackInfo  // 0x48
  private   static readonly AkCallbackManager.SimplePool<AkCallbackManager.EventCallbackPackage>s_EventCallbackPackagePool  // 0x50
  private   static readonly AkCallbackManager.SimplePool<AkCallbackManager.BankCallbackPackage>s_BankCallbackPackagePool  // 0x58
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,AkCallbackManager.BankCallbackPackage>s_mapBankCallbacks  // 0x60
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,AkCallbackManager.EventCallbackPackage>s_mapEventCallbacks  // 0x68
  private   static  AkCallbackManager.EventCallbackPackages_lastAddedEventPackage  // 0x70
  private   static  AkCallbackManager.MonitoringCallbackm_MonitoringCB  // 0x78
  private   static  AkCallbackManager.BGMCallbackPackagems_sourceChangeCallbackPkg  // 0x80
METHODS:
  System.Int32 get_bnkCallbackCount()
  System.Int32 get_evtCallbackCount()
  System.Void CancelAllCallbacks()
  System.Void RemoveEventCallback(System.UInt32 in_playingID)
  System.Void RemoveEventCallbackCookie(System.Object in_cookie)
  System.Void RemoveBankCallback(System.Object in_cookie)
  System.Void SetLastAddedPlayingID(System.UInt32 in_playingID)
  System.Void Init()
  System.Void Term()
  System.Void SetMonitoringCallback(AkMonitorErrorLevel in_Level, AkCallbackManager.MonitoringCallback in_CB)
  System.Void SetLocalOutput(AkMonitorErrorLevel in_Level)
  System.Void SetBGMCallback(AkCallbackManager.BGMCallback in_CB, System.Object in_cookie)
  System.Void PostCallbacksNoInvoke()
  System.Int32 PostCallbacks()
  System.Void _ProcessBankCallback(System.IntPtr pPackage, System.IntPtr pData)
  AkCallbackInfo _ProcessEventCallback(AkCallbackType eType, System.IntPtr pData)
  System.Void .cctor()
END_CLASS

CLASS: AkBasePlatformSettings
TYPE:  class
TOKEN: 0x2000083
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  AkInitializationSettings get_AkInitializationSettings()
  AkSpatialAudioInitSettings get_AkSpatialAudioInitSettings()
  System.String get_SoundBankPersistentDataPath()
  System.String get_SoundbankPath()
  AkCommunicationSettings get_AkCommunicationSettings()
  System.UInt32 get_MemoryAllocationSizeLimit()
  System.UInt32 get_MemoryDebugLevel()
  System.Void .ctor()
END_CLASS

CLASS: PanningRule
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkCommonOutputSettings.PanningRuleSpeakers  // 0x0
  public    static  AkCommonOutputSettings.PanningRuleHeadphones  // 0x0
METHODS:
END_CLASS

CLASS: ChannelConfigType
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelConfigTypeAnonymous  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelConfigTypeStandard  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelConfigTypeAmbisonic  // 0x0
METHODS:
END_CLASS

CLASS: ChannelMask
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskNONE  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskFRONT_LEFT  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskFRONT_RIGHT  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskFRONT_CENTER  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskLOW_FREQUENCY  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskBACK_LEFT  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskBACK_RIGHT  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskBACK_CENTER  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSIDE_LEFT  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSIDE_RIGHT  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskTOP  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskHEIGHT_FRONT_LEFT  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskHEIGHT_FRONT_CENTER  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskHEIGHT_FRONT_RIGHT  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskHEIGHT_BACK_LEFT  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskHEIGHT_BACK_CENTER  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskHEIGHT_BACK_RIGHT  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_MONO  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_0POINT1  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_1POINT1  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_STEREO  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_2POINT1  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_3STEREO  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_3POINT1  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_4  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_4POINT1  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_5  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_5POINT1  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_6  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_6POINT1  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_7  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_7POINT1  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_SURROUND  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_DPL2  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_HEIGHT_4  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_HEIGHT_5  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_HEIGHT_ALL  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_222  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_8  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_9  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_9POINT1  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_10  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_10POINT1  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_11  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_11POINT1  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_11_740  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_11POINT1_740  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_13_751  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_AURO_13POINT1_751  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_DOLBY_5_0_2  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_DOLBY_5_1_2  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_DOLBY_6_0_2  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_DOLBY_6_1_2  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_DOLBY_6_0_4  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_DOLBY_6_1_4  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_DOLBY_7_0_2  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_DOLBY_7_1_2  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_DOLBY_7_0_4  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_DOLBY_7_1_4  // 0x0
  public    static  AkCommonOutputSettings.ChannelConfiguration.ChannelMaskSETUP_ALL_SPEAKERS  // 0x0
METHODS:
END_CLASS

CLASS: ChannelConfiguration
TYPE:  class
TOKEN: 0x2000086
FIELDS:
  public            AkCommonOutputSettings.ChannelConfiguration.ChannelConfigTypem_ChannelConfigType  // 0x10
  public            AkCommonOutputSettings.ChannelConfiguration.ChannelMaskm_ChannelMask  // 0x14
  public            System.UInt32                   m_NumberOfChannels  // 0x18
METHODS:
  System.Void CopyTo(AkChannelConfig config)
  System.Void .ctor()
END_CLASS

CLASS: AkCommonOutputSettings
TYPE:  class
TOKEN: 0x2000084
FIELDS:
  public            System.String                   m_AudioDeviceShareset  // 0x10
  public            System.UInt32                   m_DeviceID  // 0x18
  public            AkCommonOutputSettings.PanningRulem_PanningRule  // 0x1C
  public            AkCommonOutputSettings.ChannelConfigurationm_ChannelConfig  // 0x20
METHODS:
  System.Void CopyTo(AkOutputSettings settings)
  System.Void .ctor()
END_CLASS

CLASS: SpatialAudioSettings
TYPE:  class
TOKEN: 0x200008A
FIELDS:
  public            System.UInt32                   m_MaxSoundPropagationDepth  // 0x10
  public            System.Single                   m_MovementThreshold  // 0x14
  public            System.UInt32                   m_NumberOfPrimaryRays  // 0x18
  public            System.UInt32                   m_MaxReflectionOrder  // 0x1C
  public            System.UInt32                   m_MaxDiffractionOrder  // 0x20
  public            System.UInt32                   m_DiffractionOnReflectionsOrder  // 0x24
  public            System.UInt32                   m_MaxEmitterRoomAuxSends  // 0x28
  public            System.Single                   m_MaxPathLength  // 0x2C
  public            System.Single                   m_CPULimitPercentage  // 0x30
  public            System.Boolean                  m_EnableGeometricDiffractionAndTransmission  // 0x34
  public            System.Boolean                  m_CalcEmitterVirtualPosition  // 0x35
  public            System.UInt32                   m_LoadBalancingSpread  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: AkCommonUserSettings
TYPE:  class
TOKEN: 0x2000089
FIELDS:
  public            System.String                   m_BasePath  // 0x10
  public            System.UInt32                   m_MaximumNumberOfPositioningPaths  // 0x18
  public            System.UInt32                   m_CommandQueueSize  // 0x1C
  public            System.UInt32                   m_SamplesPerFrame  // 0x20
  public            AkCommonOutputSettings          m_MainOutputSettings  // 0x28
  public            System.Single                   m_StreamingLookAheadRatio  // 0x30
  public            System.UInt32                   m_SampleRate  // 0x34
  public            System.UInt16                   m_NumberOfRefillsInVoice  // 0x38
  public            AkCommonUserSettings.SpatialAudioSettingsm_SpatialAudioSettings  // 0x40
METHODS:
  System.String GetPluginPath()
  System.Void CopyTo(AkInitSettings settings)
  System.Void CopyTo(AkMusicSettings settings)
  System.Void CopyTo(AkStreamMgrSettings settings)
  System.Void CopyTo(AkDeviceSettings settings)
  System.Void SetSampleRate(AkPlatformInitSettings settings)
  System.Void CopyTo(AkPlatformInitSettings settings)
  System.Void CopyTo(AkSpatialAudioInitSettings settings)
  System.Void CopyTo(AkUnityPlatformSpecificSettings settings)
  System.Void Validate()
  System.Void .ctor()
END_CLASS

CLASS: MemSpanCount
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkCommonAdvancedSettings.MemSpanCountSmall  // 0x0
  public    static  AkCommonAdvancedSettings.MemSpanCountMedium  // 0x0
  public    static  AkCommonAdvancedSettings.MemSpanCountHuge  // 0x0
METHODS:
END_CLASS

CLASS: AkCommonAdvancedSettings
TYPE:  class
TOKEN: 0x200008B
FIELDS:
  public            System.UInt32                   m_IOMemorySize  // 0x10
  public            System.Single                   m_TargetAutoStreamBufferLengthMs  // 0x14
  public            System.Boolean                  m_UseStreamCache  // 0x18
  public            System.UInt32                   m_MaximumPinnedBytesInCache  // 0x1C
  public            System.Boolean                  m_EnableGameSyncPreparation  // 0x20
  public            System.UInt32                   m_ContinuousPlaybackLookAhead  // 0x24
  public            System.UInt32                   m_MonitorQueuePoolSize  // 0x28
  public            System.UInt32                   m_MaximumHardwareTimeoutMs  // 0x2C
  public            System.Boolean                  m_DebugOutOfRangeCheckEnabled  // 0x30
  public            System.Single                   m_DebugOutOfRangeLimit  // 0x34
  public            System.String                   m_SoundBankPersistentDataPath  // 0x38
  public            System.UInt32                   m_MemoryAllocationSizeLimit  // 0x40
  public            System.UInt32                   m_MemoryDebugLevel  // 0x44
  public            AkCommonAdvancedSettings.MemSpanCountm_MemorySpanCount  // 0x48
METHODS:
  System.Void CopyTo(AkDeviceSettings settings)
  System.Void CopyTo(AkInitSettings settings)
  System.Void CopyTo(AkPlatformInitSettings settings)
  System.Void CopyTo(AkUnityPlatformSpecificSettings settings)
  System.Void .ctor()
END_CLASS

CLASS: AkCommonCommSettings
TYPE:  class
TOKEN: 0x200008D
FIELDS:
  public            System.UInt32                   m_PoolSize  // 0x10
  public    static  System.UInt16                   DefaultDiscoveryBroadcastPort  // 0x0
  public            System.UInt16                   m_DiscoveryBroadcastPort  // 0x14
  public            System.UInt16                   m_CommandPort  // 0x16
  public            System.UInt16                   m_NotificationPort  // 0x18
  public            System.Boolean                  m_InitializeSystemComms  // 0x1A
  public            System.String                   m_NetworkName  // 0x20
  public            AkCommunicationSettings.AkCommSystemm_commSystem  // 0x28
METHODS:
  System.Void CopyTo(AkCommunicationSettings settings)
  System.Void Validate()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: AkCommonPlatformSettings
TYPE:  class
TOKEN: 0x200008E
EXTENDS: AkBasePlatformSettings
FIELDS:
METHODS:
  AkCommonUserSettings GetUserSettings()
  AkCommonAdvancedSettings GetAdvancedSettings()
  AkCommonCommSettings GetCommsSettings()
  AkInitializationSettings get_AkInitializationSettings()
  AkSpatialAudioInitSettings get_AkSpatialAudioInitSettings()
  System.String get_SoundBankPersistentDataPath()
  System.String get_SoundbankPath()
  System.UInt32 get_MemoryAllocationSizeLimit()
  System.UInt32 get_MemoryDebugLevel()
  AkCommunicationSettings get_AkCommunicationSettings()
  System.Void .ctor()
END_CLASS

CLASS: AkEnumFlagAttribute
TYPE:  class
TOKEN: 0x200008F
EXTENDS: PropertyAttribute
FIELDS:
  public            System.Type                     Type  // 0x10
METHODS:
  System.Void .ctor(System.Type type)
END_CLASS

CLASS: ErrorLoggerInteropDelegate
TYPE:  class
TOKEN: 0x2000091
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String message)
  System.IAsyncResult BeginInvoke(System.String message, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: AkLogger
TYPE:  class
TOKEN: 0x2000090
FIELDS:
  private   static  AkLogger                        ms_Instance  // 0x0
  private           AkLogger.ErrorLoggerInteropDelegateerrorLoggerDelegate  // 0x10
METHODS:
  System.Void .ctor()
  AkLogger get_Instance()
  System.Void Finalize()
  System.Void Init()
  System.Void WwiseInternalLogError(System.String message)
  System.Void Message(System.String message)
  System.Void Warning(System.String message)
  System.Void Error(System.String message)
  System.Void .cctor()
END_CLASS

CLASS: InitializationDelegate
TYPE:  class
TOKEN: 0x2000093
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TerminationDelegate
TYPE:  class
TOKEN: 0x2000094
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: AkSoundEngineInitialization
TYPE:  class
TOKEN: 0x2000092
FIELDS:
  public    static  AkSoundEngineInitialization.InitializationDelegates_initializationDelegate  // 0x0
  public    static  AkSoundEngineInitialization.TerminationDelegates_terminationDelegate  // 0x8
METHODS:
  System.Boolean InitializeSoundEngine()
  System.Void _TryInitSpatialAudio(AkBasePlatformSettings& activePlatformSettings)
  System.Void _TryInitCommunication(AkBasePlatformSettings& activePlatformSettings)
  System.Void TerminateSoundEngine()
  System.Void _WaitCallbacks(System.Int32 retry)
END_CLASS

CLASS: ShortIDGenerator
TYPE:  class
TOKEN: 0x2000096
FIELDS:
  private   static  System.UInt32                   s_prime32  // 0x0
  private   static  System.UInt32                   s_offsetBasis32  // 0x0
  private   static  System.Byte                     s_hashSize  // 0x0
  private   static  System.UInt32                   s_mask  // 0x4
METHODS:
  System.Void .cctor()
  System.Byte get_HashSize()
  System.Void set_HashSize(System.Byte value)
  System.UInt32 Compute(System.String in_name)
  System.Void .ctor()
END_CLASS

CLASS: AkUtilities
TYPE:  class
TOKEN: 0x2000095
FIELDS:
METHODS:
  System.Void FixSlashes(System.String& path, System.Char separatorChar, System.Char badChar, System.Boolean addTrailingSlash)
  System.Void FixSlashes(System.String& path)
  System.String GetPathInPackage(System.String relativePath)
  System.Void .ctor()
END_CLASS

CLASS: AkVector64
TYPE:  struct
TOKEN: 0x2000097
FIELDS:
  public            System.Double                   X  // 0x10
  public            System.Double                   Y  // 0x18
  public            System.Double                   Z  // 0x20
METHODS:
  System.Void Zero()
  AkVector64 op_Implicit(UnityEngine.Vector3 vector)
END_CLASS

CLASS: PlatformSettings
TYPE:  class
TOKEN: 0x2000099
EXTENDS: AkCommonPlatformSettings
FIELDS:
  private           System.Collections.Generic.List<System.String>IgnorePropertyNameList  // 0x18
  private           System.Collections.Generic.List<System.String>GlobalPropertyNameList  // 0x20
  private           System.Collections.Generic.HashSet<System.String>_GlobalPropertyHashSet  // 0x28
METHODS:
  System.Void IgnorePropertyValue(System.String propertyPath)
  System.Boolean IsPropertyIgnored(System.String propertyPath)
  System.Void .ctor()
  System.Void SetUseGlobalPropertyValue(System.String propertyPath, System.Boolean use)
  System.Void SetGlobalPropertyValues(System.Collections.IEnumerable enumerable)
  System.Boolean IsUsingGlobalPropertyValue(System.String propertyPath)
  System.Collections.Generic.HashSet<System.String> get_GlobalPropertyHashSet()
  System.Void set_GlobalPropertyHashSet(System.Collections.Generic.HashSet<System.String> value)
END_CLASS

CLASS: CommonPlatformSettings
TYPE:  class
TOKEN: 0x200009A
EXTENDS: PlatformSettings
FIELDS:
  public            AkCommonUserSettings            UserSettings  // 0x30
  public            AkCommonAdvancedSettings        AdvancedSettings  // 0x38
  public            AkCommonCommSettings            CommsSettings  // 0x40
METHODS:
  AkCommonUserSettings GetUserSettings()
  AkCommonAdvancedSettings GetAdvancedSettings()
  AkCommonCommSettings GetCommsSettings()
  System.Void .ctor()
END_CLASS

CLASS: AkWwiseInitializationSettings
TYPE:  class
TOKEN: 0x2000098
EXTENDS: AkCommonPlatformSettings
FIELDS:
  public            System.Collections.Generic.List<System.String>PlatformSettingsNameList  // 0x18
  public            System.Collections.Generic.List<AkWwiseInitializationSettings.PlatformSettings>PlatformSettingsList  // 0x20
  public            System.Collections.Generic.List<System.String>InvalidReferencePlatforms  // 0x28
  public            AkCommonUserSettings            UserSettings  // 0x30
  public            AkCommonAdvancedSettings        AdvancedSettings  // 0x38
  public            AkCommonCommSettings            CommsSettings  // 0x40
  private   static readonly System.String[]                 AllGlobalValues  // 0x0
  private   static  AkWwiseInitializationSettings   m_Instance  // 0x8
  private   static  AkBasePlatformSettings          m_ActivePlatformSettings  // 0x10
METHODS:
  System.Boolean get_IsValid()
  System.Int32 get_Count()
  AkCommonUserSettings GetUserSettings()
  AkCommonAdvancedSettings GetAdvancedSettings()
  AkCommonCommSettings GetCommsSettings()
  AkWwiseInitializationSettings get_Instance()
  System.Void set_Instance(AkWwiseInitializationSettings value)
  AkBasePlatformSettings GetPlatformSettings(System.String platformName)
  AkBasePlatformSettings get_ActivePlatformSettings()
  System.Void OnEnable()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: AkAcousticSurfaceArray
TYPE:  class
TOKEN: 0x200009B
EXTENDS: AkBaseArray`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 count)
  System.Int32 get_StructureSize()
  System.Void DefaultConstructAtIntPtr(System.IntPtr address)
  AkAcousticSurface CreateNewReferenceFromIntPtr(System.IntPtr address)
  System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkAcousticSurface other)
END_CLASS

CLASS: AkAuxSendArray
TYPE:  class
TOKEN: 0x200009C
FIELDS:
  private   static  System.Int32                    MAX_COUNT  // 0x0
  private   readonly System.Int32                    SIZE_OF_AKAUXSENDVALUE  // 0x10
  private           System.IntPtr                   m_Buffer  // 0x18
  private           System.Int32                    m_Count  // 0x20
METHODS:
  System.Void .ctor()
  AkAuxSendValue get_Item(System.Int32 index)
  System.Boolean get_isFull()
  System.Void Dispose()
  System.Void Finalize()
  System.Void Reset()
  System.Boolean Add(System.UInt64 in_listenerGameObj, System.UInt32 in_AuxBusID, System.Single in_fValue)
  System.Boolean Add(System.UInt32 in_AuxBusID, System.Single in_fValue)
  System.Boolean Contains(System.UInt64 in_listenerGameObj, System.UInt32 in_AuxBusID)
  System.Boolean Contains(System.UInt32 in_AuxBusID)
  AKRESULT SetValues(System.UInt64 gameObject)
  AKRESULT GetValues(System.UInt64 gameObject)
  System.IntPtr GetBuffer()
  System.Int32 Count()
  System.IntPtr _GetObjectPtr(System.Int32 index)
END_CLASS

CLASS: AkBaseArray`1
TYPE:  class
TOKEN: 0x200009D
FIELDS:
  private           System.Int32                    <Capacity>k__BackingField  // 0x0
  private           System.IntPtr                   m_Buffer  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity)
  System.Void Dispose()
  System.Void Finalize()
  System.Int32 get_Capacity()
  System.Void set_Capacity(System.Int32 value)
  System.Int32 Count()
  System.Int32 get_StructureSize()
  System.Void DefaultConstructAtIntPtr(System.IntPtr address)
  System.Void ReleaseAllocatedMemoryFromReferenceAtIntPtr(System.IntPtr address)
  T CreateNewReferenceFromIntPtr(System.IntPtr address)
  System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, T other)
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.IntPtr GetBuffer()
  System.IntPtr GetObjectPtr(System.Int32 index)
END_CLASS

CLASS: AkChannelEmitterArray
TYPE:  class
TOKEN: 0x200009E
FIELDS:
  public            System.IntPtr                   m_Buffer  // 0x10
  private           System.IntPtr                   m_Current  // 0x18
  private           System.UInt32                   m_MaxCount  // 0x20
  private           System.UInt32                   <Count>k__BackingField  // 0x24
METHODS:
  System.Void .ctor(System.UInt32 in_Count)
  System.UInt32 get_Count()
  System.Void set_Count(System.UInt32 value)
  System.Void Dispose()
  System.Void Finalize()
  System.Void Reset()
  System.Void Add(AkVector64 in_Pos, UnityEngine.Vector3 in_Forward, UnityEngine.Vector3 in_Top, System.UInt32 in_ChannelMask)
END_CLASS

CLASS: AkDeviceDescriptionArray
TYPE:  class
TOKEN: 0x200009F
EXTENDS: AkBaseArray`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 count)
  System.Int32 get_StructureSize()
  System.Void DefaultConstructAtIntPtr(System.IntPtr address)
  AkDeviceDescription CreateNewReferenceFromIntPtr(System.IntPtr address)
  System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkDeviceDescription other)
END_CLASS

CLASS: AkDiffractionPathInfoArray
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: AkBaseArray`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 count)
  System.Int32 get_StructureSize()
  AkDiffractionPathInfo CreateNewReferenceFromIntPtr(System.IntPtr address)
  System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkDiffractionPathInfo other)
END_CLASS

CLASS: AkExternalSourceInfoArray
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: AkBaseArray`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 count)
  System.Int32 get_StructureSize()
  System.Void DefaultConstructAtIntPtr(System.IntPtr address)
  System.Void ReleaseAllocatedMemoryFromReferenceAtIntPtr(System.IntPtr address)
  AkExternalSourceInfo CreateNewReferenceFromIntPtr(System.IntPtr address)
  System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkExternalSourceInfo other)
END_CLASS

CLASS: AkMIDIPostArray
TYPE:  class
TOKEN: 0x20000A2
FIELDS:
  private   readonly System.Int32                    m_Count  // 0x10
  private   readonly System.Int32                    SIZE_OF  // 0x14
  private           System.IntPtr                   m_Buffer  // 0x18
METHODS:
  System.Void .ctor(System.Int32 size)
  AkMIDIPost get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, AkMIDIPost value)
  System.Void Finalize()
  System.Void PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject gameObject)
  System.Void PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject gameObject, System.Int32 count)
  System.IntPtr GetBuffer()
  System.Int32 Count()
  System.IntPtr GetObjectPtr(System.Int32 index)
END_CLASS

CLASS: AkObjectInfoArray
TYPE:  class
TOKEN: 0x20000A3
EXTENDS: AkBaseArray`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 count)
  System.Int32 get_StructureSize()
  System.Void DefaultConstructAtIntPtr(System.IntPtr address)
  AkObjectInfo CreateNewReferenceFromIntPtr(System.IntPtr address)
  System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkObjectInfo other)
END_CLASS

CLASS: AkObstructionOcclusionValuesArray
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: AkBaseArray`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 count)
  System.Int32 get_StructureSize()
  System.Void DefaultConstructAtIntPtr(System.IntPtr address)
  AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(System.IntPtr address)
  System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkObstructionOcclusionValues other)
END_CLASS

CLASS: AkPositionArray
TYPE:  class
TOKEN: 0x20000A5
FIELDS:
  public            System.IntPtr                   m_Buffer  // 0x10
  private           System.IntPtr                   m_Current  // 0x18
  private           System.UInt32                   m_MaxCount  // 0x20
  private           System.UInt32                   <Count>k__BackingField  // 0x24
METHODS:
  System.Void .ctor(System.UInt32 in_Count)
  System.UInt32 get_Count()
  System.Void set_Count(System.UInt32 value)
  System.Void Dispose()
  System.Void Finalize()
  System.Void Reset()
  System.Void Add(AkVector64 in_Pos, UnityEngine.Vector3 in_Forward, UnityEngine.Vector3 in_Top)
END_CLASS

CLASS: AkReflectionPathInfoArray
TYPE:  class
TOKEN: 0x20000A6
EXTENDS: AkBaseArray`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 count)
  System.Int32 get_StructureSize()
  AkReflectionPathInfo CreateNewReferenceFromIntPtr(System.IntPtr address)
  System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkReflectionPathInfo other)
END_CLASS

CLASS: AkSourceSettingsArray
TYPE:  class
TOKEN: 0x20000A7
EXTENDS: AkBaseArray`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 count)
  System.Int32 get_StructureSize()
  System.Void DefaultConstructAtIntPtr(System.IntPtr address)
  AkSourceSettings CreateNewReferenceFromIntPtr(System.IntPtr address)
  System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkSourceSettings other)
END_CLASS

CLASS: AkTriangleArray
TYPE:  class
TOKEN: 0x20000A8
EXTENDS: AkBaseArray`1
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 count)
  System.Int32 get_StructureSize()
  System.Void DefaultConstructAtIntPtr(System.IntPtr address)
  AkTriangle CreateNewReferenceFromIntPtr(System.IntPtr address)
  System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkTriangle other)
END_CLASS

CLASS: AudioTriangleArrayNoGc
TYPE:  struct
TOKEN: 0x20000AA
FIELDS:
  private           System.IntPtr                   m_buffer  // 0x10
  private           System.Int32                    m_capacity  // 0x18
  private           System.Int32                    m_elementSize  // 0x1C
METHODS:
  System.IntPtr get_Buffer()
  System.Void .ctor(System.Int32 capacity)
  System.Void Set(System.Int32 idx, System.UInt16 p0, System.UInt16 p1, System.UInt16 p2, System.UInt16 surface)
  System.Void Dispose()
END_CLASS

CLASS: AudioAcousticSurfaceArrayNoGc
TYPE:  struct
TOKEN: 0x20000AB
FIELDS:
  private           System.IntPtr                   m_buffer  // 0x10
  private           System.Int32                    m_capacity  // 0x18
  private           System.Int32                    m_elementSize  // 0x1C
METHODS:
  System.IntPtr get_Buffer()
  System.Void .ctor(System.Int32 capacity)
  System.Void Set(System.Int32 idx, System.Single transmissionLoss, System.UInt32 textureId)
  System.Void Dispose()
END_CLASS

CLASS: AudioNativeHelper
TYPE:  class
TOKEN: 0x20000A9
FIELDS:
  private   static  System.IntPtr                   s_reusedTransformPtr  // 0x0
METHODS:
  System.Void Init()
  System.Void Term()
  AKRESULT SetRoomPortal(System.UInt64 portalID, System.UInt64 frontRoom, System.UInt64 backRoom, UnityEngine.Vector3 position, UnityEngine.Vector3 orientationFront, UnityEngine.Vector3 orientationTop, UnityEngine.Vector3 extent, System.Boolean enabled, System.String portalName)
  AKRESULT SetGeometry(System.UInt64 geoId, AudioNativeHelper.AudioTriangleArrayNoGc triangles, System.UInt32 numTriangles, UnityEngine.Vector3[] vertices, System.UInt32 numVertices, AudioNativeHelper.AudioAcousticSurfaceArrayNoGc surfaces, System.UInt32 numSurfaces, System.Boolean enableDiffraction, System.Boolean enableDiffractionOnBoundaryEdges)
  AKRESULT SetGeometryInstance(System.UInt64 geomInstanceID, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scale, System.UInt64 geometrySetID, System.UInt64 roomID, System.Boolean useForReflectionAndDiffraction)
  System.Void .cctor()
END_CLASS

CLASS: Category
TYPE:  struct
TOKEN: 0x20000AE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkiOSSettings.PlatformAdvancedSettings.CategoryAmbient  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.CategorySoloAmbient  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.CategoryPlayAndRecord  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.CategoryPlayback  // 0x0
METHODS:
END_CLASS

CLASS: CategoryOptions
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkiOSSettings.PlatformAdvancedSettings.CategoryOptionsMixWithOthers  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.CategoryOptionsDuckOthers  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.CategoryOptionsAllowBluetooth  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.CategoryOptionsDefaultToSpeaker  // 0x0
METHODS:
END_CLASS

CLASS: Mode
TYPE:  struct
TOKEN: 0x20000B0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AkiOSSettings.PlatformAdvancedSettings.ModeDefault  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.ModeVoiceChat  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.ModeGameChat  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.ModeVideoRecording  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.ModeMeasurement  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.ModeMoviePlayback  // 0x0
  public    static  AkiOSSettings.PlatformAdvancedSettings.ModeVideoChat  // 0x0
METHODS:
END_CLASS

CLASS: PlatformAdvancedSettings
TYPE:  class
TOKEN: 0x20000AD
EXTENDS: AkCommonAdvancedSettings
FIELDS:
  public            AkiOSSettings.PlatformAdvancedSettings.Categorym_AudioSessionCategory  // 0x50
  public            AkiOSSettings.PlatformAdvancedSettings.CategoryOptionsm_AudioSessionCategoryOptions  // 0x54
  public            AkiOSSettings.PlatformAdvancedSettings.Modem_AudioSessionMode  // 0x58
  public            System.UInt32                   NumSpatialAudioPointSources  // 0x5C
  public            System.Boolean                  VerboseSystemOutput  // 0x60
METHODS:
  System.Void CopyTo(AkPlatformInitSettings settings)
  System.Void .ctor()
END_CLASS

CLASS: AkiOSSettings
TYPE:  class
TOKEN: 0x20000AC
EXTENDS: PlatformSettings
FIELDS:
  public            AkCommonUserSettings            UserSettings  // 0x30
  public            AkiOSSettings.PlatformAdvancedSettingsAdvancedSettings  // 0x38
  public            AkCommonCommSettings            CommsSettings  // 0x40
METHODS:
  System.Void .ctor()
  AkCommonUserSettings GetUserSettings()
  AkCommonAdvancedSettings GetAdvancedSettings()
  AkCommonCommSettings GetCommsSettings()
END_CLASS

CLASS: PlatformAdvancedSettings
TYPE:  class
TOKEN: 0x20000B2
EXTENDS: AkCommonAdvancedSettings
FIELDS:
  public            System.UInt32                   NumSpatialAudioPointSources  // 0x50
  public            System.Boolean                  VerboseSystemOutput  // 0x54
METHODS:
  System.Void CopyTo(AkPlatformInitSettings settings)
  System.Void .ctor()
END_CLASS

CLASS: AkMacSettings
TYPE:  class
TOKEN: 0x20000B1
EXTENDS: PlatformSettings
FIELDS:
  public            AkCommonUserSettings            UserSettings  // 0x30
  public            AkMacSettings.PlatformAdvancedSettingsAdvancedSettings  // 0x38
  public            AkCommonCommSettings            CommsSettings  // 0x40
METHODS:
  AkCommonUserSettings GetUserSettings()
  AkCommonAdvancedSettings GetAdvancedSettings()
  AkCommonCommSettings GetCommsSettings()
  System.Void .ctor()
END_CLASS

CLASS: PlatformAdvancedSettings
TYPE:  class
TOKEN: 0x20000B4
EXTENDS: AkCommonAdvancedSettings
FIELDS:
  public            System.UInt32                   NumAudioOut2Ports  // 0x50
  public            System.UInt32                   NumAudioOut2ObjectPorts  // 0x54
  public            System.Boolean                  HwCodecLowLatencyMode  // 0x58
  public            System.Boolean                  VorbisHwAcceleration  // 0x59
  public            System.Boolean                  Enable3DAudioSync  // 0x5A
  public            System.UInt32                   NumOperationsForHwMixing  // 0x5C
  public            System.Boolean                  PlotQueueLevel  // 0x60
METHODS:
  System.Void CopyTo(AkPlatformInitSettings settings)
  System.Void .ctor()
END_CLASS

CLASS: AkPS5Settings
TYPE:  class
TOKEN: 0x20000B3
EXTENDS: PlatformSettings
FIELDS:
  public            AkCommonUserSettings            UserSettings  // 0x30
  public            AkPS5Settings.PlatformAdvancedSettingsAdvancedSettings  // 0x38
  public            AkCommonCommSettings            CommsSettings  // 0x40
METHODS:
  System.Void .ctor()
  AkCommonUserSettings GetUserSettings()
  AkCommonAdvancedSettings GetAdvancedSettings()
  AkCommonCommSettings GetCommsSettings()
END_CLASS

CLASS: PlatformAdvancedSettings
TYPE:  class
TOKEN: 0x20000B6
EXTENDS: AkCommonAdvancedSettings
FIELDS:
  public            System.UInt32                   MaxSystemAudioObjects  // 0x50
METHODS:
  System.Void CopyTo(AkPlatformInitSettings settings)
  System.Void .ctor()
END_CLASS

CLASS: AkWindowsSettings
TYPE:  class
TOKEN: 0x20000B5
EXTENDS: PlatformSettings
FIELDS:
  public            AkCommonUserSettings            UserSettings  // 0x30
  public            AkWindowsSettings.PlatformAdvancedSettingsAdvancedSettings  // 0x38
  public            AkCommonCommSettings            CommsSettings  // 0x40
METHODS:
  AkCommonUserSettings GetUserSettings()
  AkCommonAdvancedSettings GetAdvancedSettings()
  AkCommonCommSettings GetCommsSettings()
  System.Void .ctor()
END_CLASS

