// ========================================================
// Dumped by @desirepro
// Assembly: AK.Wwise.Unity.API.dll
// Classes:  182
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class Ak3DAudioSinkCapabilities, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(Ak3DAudioSinkCapabilities obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_channelConfig(AkChannelConfig value) { }
        private AkChannelConfig get_channelConfig() { }
        private System.Void set_uMaxSystemAudioObjects(System.UInt32 value) { }
        private System.UInt32 get_uMaxSystemAudioObjects() { }
        private System.Void set_uAvailableSystemAudioObjects(System.UInt32 value) { }
        private System.UInt32 get_uAvailableSystemAudioObjects() { }
        private System.Void set_bPassthrough(System.Boolean value) { }
        private System.Boolean get_bPassthrough() { }
        private System.Void set_bMultiChannelObjects(System.Boolean value) { }
        private System.Boolean get_bMultiChannelObjects() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000003
    public class Ak3dData, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(Ak3dData obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void set_xform(AkTransform value) { }
        private AkTransform get_xform() { }
        private System.Void set_spread(System.Single value) { }
        private System.Single get_spread() { }
        private System.Void set_focus(System.Single value) { }
        private System.Single get_focus() { }
        private System.Void set_uEmitterChannelMask(System.UInt32 value) { }
        private System.UInt32 get_uEmitterChannelMask() { }

    }

    // TypeToken: 0x2000004
    public struct Ak3DPositionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Ak3DPositionType AK_3DPositionType_Emitter;        // 0x0
        public static Ak3DPositionType AK_3DPositionType_EmitterWithAutomation;        // 0x0
        public static Ak3DPositionType AK_3DPositionType_ListenerWithAutomation;        // 0x0

    }

    // TypeToken: 0x2000005
    public struct Ak3DSpatializationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Ak3DSpatializationMode AK_SpatializationMode_None;        // 0x0
        public static Ak3DSpatializationMode AK_SpatializationMode_PositionOnly;        // 0x0
        public static Ak3DSpatializationMode AK_SpatializationMode_PositionAndOrientation;        // 0x0

    }

    // TypeToken: 0x2000006
    public class AkAcousticSurface, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkAcousticSurface obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void set_textureID(System.UInt32 value) { }
        private System.UInt32 get_textureID() { }
        private System.Void set_transmissionLoss(System.Single value) { }
        private System.Single get_transmissionLoss() { }
        private System.Void set_strName(System.String value) { }
        private System.String get_strName() { }
        private System.Void Clear() { }
        private System.Void DeleteName() { }
        private System.Int32 GetSizeOf() { }
        private System.Void Clone(AkAcousticSurface other) { }

    }

    // TypeToken: 0x2000007
    public struct AkActionOnEventType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkActionOnEventType AkActionOnEventType_Stop;        // 0x0
        public static AkActionOnEventType AkActionOnEventType_Pause;        // 0x0
        public static AkActionOnEventType AkActionOnEventType_Resume;        // 0x0
        public static AkActionOnEventType AkActionOnEventType_Break;        // 0x0
        public static AkActionOnEventType AkActionOnEventType_ReleaseEnvelope;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct AkAttenuationCurveType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkAttenuationCurveType AttenuationCurveID_VolumeDry;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_VolumeAuxGameDef;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_VolumeAuxUserDef;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_LowPassFilter;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_HighPassFilter;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_Spread;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_Focus;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_ObstructionVolume;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_ObstructionLPF;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_ObstructionHPF;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_OcclusionVolume;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_OcclusionLPF;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_OcclusionHPF;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_DiffractionVolume;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_DiffractionLPF;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_DiffractionHPF;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_TransmissionVolume;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_TransmissionLPF;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_TransmissionHPF;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_MaxCount;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_Project;        // 0x0
        public static AkAttenuationCurveType AttenuationCurveID_None;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct AkAudioDeviceState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkAudioDeviceState AkDeviceState_Unknown;        // 0x0
        public static AkAudioDeviceState AkDeviceState_Active;        // 0x0
        public static AkAudioDeviceState AkDeviceState_Disabled;        // 0x0
        public static AkAudioDeviceState AkDeviceState_NotPresent;        // 0x0
        public static AkAudioDeviceState AkDeviceState_Unplugged;        // 0x0
        public static AkAudioDeviceState AkDeviceState_All;        // 0x0

    }

    // TypeToken: 0x200000A
    public class AkAudioFormat, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkAudioFormat obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_uSampleRate(System.UInt32 value) { }
        private System.UInt32 get_uSampleRate() { }
        private System.Void set_channelConfig(AkChannelConfig value) { }
        private AkChannelConfig get_channelConfig() { }
        private System.Void set_uBitsPerSample(System.UInt32 value) { }
        private System.UInt32 get_uBitsPerSample() { }
        private System.Void set_uBlockAlign(System.UInt32 value) { }
        private System.UInt32 get_uBlockAlign() { }
        private System.Void set_uTypeID(System.UInt32 value) { }
        private System.UInt32 get_uTypeID() { }
        private System.Void set_uInterleaveID(System.UInt32 value) { }
        private System.UInt32 get_uInterleaveID() { }
        private System.UInt32 GetNumChannels() { }
        private System.UInt32 GetBitsPerSample() { }
        private System.UInt32 GetBlockAlign() { }
        private System.UInt32 GetTypeID() { }
        private System.UInt32 GetInterleaveID() { }
        private System.Void SetAll(System.UInt32 in_uSampleRate, AkChannelConfig in_channelConfig, System.UInt32 in_uBitsPerSample, System.UInt32 in_uBlockAlign, System.UInt32 in_uTypeID, System.UInt32 in_uInterleaveID) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class AkAudioInterruptionCallbackInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkAudioInterruptionCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean get_bEnterInterruption() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public struct AkAudioObjectDestination
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkAudioObjectDestination eDefault;        // 0x0
        public static AkAudioObjectDestination eMainMix;        // 0x0
        public static AkAudioObjectDestination ePassthrough;        // 0x0
        public static AkAudioObjectDestination eSystemAudioObject;        // 0x0

    }

    // TypeToken: 0x200000D
    public class AkAudioSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkAudioSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_uNumSamplesPerFrame(System.UInt32 value) { }
        private System.UInt32 get_uNumSamplesPerFrame() { }
        private System.Void set_uNumSamplesPerSecond(System.UInt32 value) { }
        private System.UInt32 get_uNumSamplesPerSecond() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public class AkAudioSourceChangeCallbackInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkAudioSourceChangeCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean get_bOtherAudioPlaying() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class AkAuxSendValue, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkAuxSendValue obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_listenerID(System.UInt64 value) { }
        private System.UInt64 get_listenerID() { }
        private System.Void set_auxBusID(System.UInt32 value) { }
        private System.UInt32 get_auxBusID() { }
        private System.Void set_fControlValue(System.Single value) { }
        private System.Single get_fControlValue() { }
        private System.Void Set(System.UInt64 listener, System.UInt32 id, System.Single value) { }
        private System.Boolean IsSame(System.UInt64 listener, System.UInt32 id) { }
        private System.Void Set(UnityEngine.GameObject listener, System.UInt32 id, System.Single value) { }
        private System.Boolean IsSame(UnityEngine.GameObject listener, System.UInt32 id) { }
        private System.Int32 GetSizeOf() { }

    }

    // TypeToken: 0x2000010
    public class AkBankCallbackInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkBankCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.UInt32 get_bankID() { }
        private System.IntPtr get_inMemoryBankPtr() { }
        private AKRESULT get_loadResult() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public struct AkBankContent
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkBankContent AkBankContent_StructureOnly;        // 0x0
        public static AkBankContent AkBankContent_All;        // 0x0

    }

    // TypeToken: 0x2000012
    public struct AkBankTypeEnum
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkBankTypeEnum AkBankType_User;        // 0x0
        public static AkBankTypeEnum AkBankType_Event;        // 0x0
        public static AkBankTypeEnum AkBankType_Bus;        // 0x0

    }

    // TypeToken: 0x2000013
    public class AkBehavioralPositioningData, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkBehavioralPositioningData obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void set_center(System.Single value) { }
        private System.Single get_center() { }
        private System.Void set_panLR(System.Single value) { }
        private System.Single get_panLR() { }
        private System.Void set_panBF(System.Single value) { }
        private System.Single get_panBF() { }
        private System.Void set_panDU(System.Single value) { }
        private System.Single get_panDU() { }
        private System.Void set_panSpatMix(System.Single value) { }
        private System.Single get_panSpatMix() { }
        private System.Void set_spatMode(Ak3DSpatializationMode value) { }
        private Ak3DSpatializationMode get_spatMode() { }
        private System.Void set_panType(AkSpeakerPanningType value) { }
        private AkSpeakerPanningType get_panType() { }
        private System.Void set_enableHeightSpread(System.Boolean value) { }
        private System.Boolean get_enableHeightSpread() { }

    }

    // TypeToken: 0x2000014
    public struct AkBusHierarchyFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkBusHierarchyFlags AkBusHierarchy_Primary;        // 0x0
        public static AkBusHierarchyFlags AkBusHierarchy_Secondary;        // 0x0
        public static AkBusHierarchyFlags AkBusHierarchy_IsMaster;        // 0x0

    }

    // TypeToken: 0x2000015
    public class AkCallbackInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.IntPtr get_pCookie() { }
        private System.UInt64 get_gameObjID() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class AkCallbackSerializer, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkCallbackSerializer obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private AKRESULT Init() { }
        private System.Void Term() { }
        private System.IntPtr Lock() { }
        private System.Void Unlock() { }
        private System.Void SetLocalOutput(System.UInt32 in_uErrorLevel, System.String in_ip, System.UInt32 in_port, System.String in_xmlFilePath, System.UInt32 in_msXmlTranslatorTimeout, System.UInt32 in_msWaapiTranslatorTimeout) { }
        private AKRESULT AudioSourceChangeCallbackFunc(System.Boolean in_bOtherAudioPlaying, System.Object in_pCookie) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public struct AkCallbackType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkCallbackType AK_EndOfEvent;        // 0x0
        public static AkCallbackType AK_EndOfDynamicSequenceItem;        // 0x0
        public static AkCallbackType AK_Marker;        // 0x0
        public static AkCallbackType AK_Duration;        // 0x0
        public static AkCallbackType AK_SpeakerVolumeMatrix;        // 0x0
        public static AkCallbackType AK_Starvation;        // 0x0
        public static AkCallbackType AK_MusicPlaylistSelect;        // 0x0
        public static AkCallbackType AK_MusicPlayStarted;        // 0x0
        public static AkCallbackType AK_MusicSyncBeat;        // 0x0
        public static AkCallbackType AK_MusicSyncBar;        // 0x0
        public static AkCallbackType AK_MusicSyncEntry;        // 0x0
        public static AkCallbackType AK_MusicSyncExit;        // 0x0
        public static AkCallbackType AK_MusicSyncGrid;        // 0x0
        public static AkCallbackType AK_MusicSyncUserCue;        // 0x0
        public static AkCallbackType AK_MusicSyncPoint;        // 0x0
        public static AkCallbackType AK_MusicSyncAll;        // 0x0
        public static AkCallbackType AK_MIDIEvent;        // 0x0
        public static AkCallbackType AK_CallbackBits;        // 0x0
        public static AkCallbackType AK_EnableGetSourcePlayPosition;        // 0x0
        public static AkCallbackType AK_EnableGetMusicPlayPosition;        // 0x0
        public static AkCallbackType AK_EnableGetSourceStreamBuffering;        // 0x0
        public static AkCallbackType AK_Monitoring;        // 0x0
        public static AkCallbackType AK_Bank;        // 0x0
        public static AkCallbackType AK_AudioInterruption;        // 0x0
        public static AkCallbackType AK_AudioSourceChange;        // 0x0

    }

    // TypeToken: 0x2000018
    public class AkChannelConfig, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkChannelConfig obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_uNumChannels(System.UInt32 value) { }
        private System.UInt32 get_uNumChannels() { }
        private System.Void set_eConfigType(System.UInt32 value) { }
        private System.UInt32 get_eConfigType() { }
        private System.Void set_uChannelMask(System.UInt32 value) { }
        private System.UInt32 get_uChannelMask() { }
        private AkChannelConfig Standard(System.UInt32 in_uChannelMask) { }
        private AkChannelConfig Anonymous(System.UInt32 in_uNumChannels) { }
        private AkChannelConfig Ambisonic(System.UInt32 in_uNumChannels) { }
        private AkChannelConfig Object() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.UInt32 in_uNumChannels, System.UInt32 in_uChannelMask) { }
        private System.Void Clear() { }
        private System.Void SetStandard(System.UInt32 in_uChannelMask) { }
        private System.Void SetStandardOrAnonymous(System.UInt32 in_uNumChannels, System.UInt32 in_uChannelMask) { }
        private System.Void SetAnonymous(System.UInt32 in_uNumChannels) { }
        private System.Void SetAmbisonic(System.UInt32 in_uNumChannels) { }
        private System.Void SetObject() { }
        private System.Void SetSameAsMainMix() { }
        private System.Void SetSameAsPassthrough() { }
        private System.Boolean IsValid() { }
        private System.UInt32 Serialize() { }
        private System.Void Deserialize(System.UInt32 in_uChannelConfig) { }
        private AkChannelConfig RemoveLFE() { }
        private AkChannelConfig RemoveCenter() { }

    }

    // TypeToken: 0x2000019
    public struct AkChannelConfigType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkChannelConfigType AK_ChannelConfigType_Anonymous;        // 0x0
        public static AkChannelConfigType AK_ChannelConfigType_Standard;        // 0x0
        public static AkChannelConfigType AK_ChannelConfigType_Ambisonic;        // 0x0
        public static AkChannelConfigType AK_ChannelConfigType_Objects;        // 0x0
        public static AkChannelConfigType AK_ChannelConfigType_UseDeviceMain;        // 0x0
        public static AkChannelConfigType AK_ChannelConfigType_UseDevicePassthrough;        // 0x0

    }

    // TypeToken: 0x200001A
    public class AkChannelEmitter, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkChannelEmitter obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_position(AkWorldTransform value) { }
        private AkWorldTransform get_position() { }
        private System.Void set_uInputChannels(System.UInt32 value) { }
        private System.UInt32 get_uInputChannels() { }
        private System.Void set_padding(System.String value) { }
        private System.String get_padding() { }

    }

    // TypeToken: 0x200001B
    public struct AkChannelOrdering
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkChannelOrdering ChannelOrdering_Standard;        // 0x0
        public static AkChannelOrdering ChannelOrdering_RunTime;        // 0x0

    }

    // TypeToken: 0x200001C
    public struct AkConnectionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkConnectionType ConnectionType_Direct;        // 0x0
        public static AkConnectionType ConnectionType_GameDefSend;        // 0x0
        public static AkConnectionType ConnectionType_UserDefSend;        // 0x0
        public static AkConnectionType ConnectionType_ReflectionsSend;        // 0x0

    }

    // TypeToken: 0x200001D
    public struct AkCurveInterpolation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkCurveInterpolation AkCurveInterpolation_Log3;        // 0x0
        public static AkCurveInterpolation AkCurveInterpolation_Sine;        // 0x0
        public static AkCurveInterpolation AkCurveInterpolation_Log1;        // 0x0
        public static AkCurveInterpolation AkCurveInterpolation_InvSCurve;        // 0x0
        public static AkCurveInterpolation AkCurveInterpolation_Linear;        // 0x0
        public static AkCurveInterpolation AkCurveInterpolation_SCurve;        // 0x0
        public static AkCurveInterpolation AkCurveInterpolation_Exp1;        // 0x0
        public static AkCurveInterpolation AkCurveInterpolation_SineRecip;        // 0x0
        public static AkCurveInterpolation AkCurveInterpolation_Exp3;        // 0x0
        public static AkCurveInterpolation AkCurveInterpolation_LastFadeCurve;        // 0x0
        public static AkCurveInterpolation AkCurveInterpolation_Constant;        // 0x0

    }

    // TypeToken: 0x200001E
    public class AkDeviceDescription, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkDeviceDescription obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_idDevice(System.UInt32 value) { }
        private System.UInt32 get_idDevice() { }
        private System.Void set_deviceName(System.String value) { }
        private System.String get_deviceName() { }
        private System.Void set_deviceStateMask(AkAudioDeviceState value) { }
        private AkAudioDeviceState get_deviceStateMask() { }
        private System.Void set_isDefaultDevice(System.Boolean value) { }
        private System.Boolean get_isDefaultDevice() { }
        private System.Void Clear() { }
        private System.Int32 GetSizeOf() { }
        private System.Void Clone(AkDeviceDescription other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class AkDeviceSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkDeviceSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_pIOMemory(System.IntPtr value) { }
        private System.IntPtr get_pIOMemory() { }
        private System.Void set_uIOMemorySize(System.UInt32 value) { }
        private System.UInt32 get_uIOMemorySize() { }
        private System.Void set_uIOMemoryAlignment(System.UInt32 value) { }
        private System.UInt32 get_uIOMemoryAlignment() { }
        private System.Void set_ePoolAttributes(System.UInt32 value) { }
        private System.UInt32 get_ePoolAttributes() { }
        private System.Void set_uGranularity(System.UInt32 value) { }
        private System.UInt32 get_uGranularity() { }
        private System.Void set_threadProperties(AkThreadProperties value) { }
        private AkThreadProperties get_threadProperties() { }
        private System.Void set_fTargetAutoStmBufferLength(System.Single value) { }
        private System.Single get_fTargetAutoStmBufferLength() { }
        private System.Void set_uMaxConcurrentIO(System.UInt32 value) { }
        private System.UInt32 get_uMaxConcurrentIO() { }
        private System.Void set_bUseStreamCache(System.Boolean value) { }
        private System.Boolean get_bUseStreamCache() { }
        private System.Void set_uMaxCachePinnedBytes(System.UInt32 value) { }
        private System.UInt32 get_uMaxCachePinnedBytes() { }

    }

    // TypeToken: 0x2000020
    public class AkDiffractionPathInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18
        public static System.UInt32 kMaxNodes;        // 0x0

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkDiffractionPathInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_emitterPos(AkVector64 value) { }
        private AkVector64 get_emitterPos() { }
        private System.Void set_virtualPos(AkWorldTransform value) { }
        private AkWorldTransform get_virtualPos() { }
        private System.Void set_nodeCount(System.UInt32 value) { }
        private System.UInt32 get_nodeCount() { }
        private System.Void set_diffraction(System.Single value) { }
        private System.Single get_diffraction() { }
        private System.Void set_transmissionLoss(System.Single value) { }
        private System.Single get_transmissionLoss() { }
        private System.Void set_totLength(System.Single value) { }
        private System.Single get_totLength() { }
        private System.Void set_obstructionValue(System.Single value) { }
        private System.Single get_obstructionValue() { }
        private System.Void set_occlusionValue(System.Single value) { }
        private System.Single get_occlusionValue() { }
        private System.Int32 GetSizeOf() { }
        private UnityEngine.Vector3 GetNodes(System.UInt32 idx) { }
        private System.Single GetAngles(System.UInt32 idx) { }
        private System.UInt64 GetPortals(System.UInt32 idx) { }
        private System.UInt64 GetRooms(System.UInt32 idx) { }
        private System.Void Clone(AkDiffractionPathInfo other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class AkDurationCallbackInfo : AkEventCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x28

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkDurationCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Single get_fDuration() { }
        private System.Single get_fEstimatedDuration() { }
        private System.UInt32 get_audioNodeID() { }
        private System.UInt32 get_mediaID() { }
        private System.Boolean get_bStreaming() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000022
    public class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x20

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.UInt32 get_playingID() { }
        private System.UInt32 get_audioNodeID() { }
        private System.IntPtr get_pCustomInfo() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public struct AkDynamicSequenceType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkDynamicSequenceType DynamicSequenceType_SampleAccurate;        // 0x0
        public static AkDynamicSequenceType DynamicSequenceType_NormalTransition;        // 0x0

    }

    // TypeToken: 0x2000024
    public class AkEventCallbackInfo : AkCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x20

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkEventCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.UInt32 get_playingID() { }
        private System.UInt32 get_eventID() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class AkExtent, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkExtent obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Single in_halfWidth, System.Single in_halfHeight, System.Single in_halfDepth) { }
        private System.Void set_halfWidth(System.Single value) { }
        private System.Single get_halfWidth() { }
        private System.Void set_halfHeight(System.Single value) { }
        private System.Single get_halfHeight() { }
        private System.Void set_halfDepth(System.Single value) { }
        private System.Single get_halfDepth() { }

    }

    // TypeToken: 0x2000026
    public class AkExternalSourceInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkExternalSourceInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.IntPtr in_pInMemory, System.UInt32 in_uiMemorySize, System.UInt32 in_iExternalSrcCookie, System.UInt32 in_idCodec) { }
        private System.Void .ctor(System.String in_pszFileName, System.UInt32 in_iExternalSrcCookie, System.UInt32 in_idCodec) { }
        private System.Void .ctor(System.UInt32 in_idFile, System.UInt32 in_iExternalSrcCookie, System.UInt32 in_idCodec) { }
        private System.Void Clear() { }
        private System.Void Clone(AkExternalSourceInfo other) { }
        private System.Int32 GetSizeOf() { }
        private System.Void set_iExternalSrcCookie(System.UInt32 value) { }
        private System.UInt32 get_iExternalSrcCookie() { }
        private System.Void set_idCodec(System.UInt32 value) { }
        private System.UInt32 get_idCodec() { }
        private System.Void set_szFile(System.String value) { }
        private System.String get_szFile() { }
        private System.Void set_pInMemory(System.IntPtr value) { }
        private System.IntPtr get_pInMemory() { }
        private System.Void set_uiMemorySize(System.UInt32 value) { }
        private System.UInt32 get_uiMemorySize() { }
        private System.Void set_idFile(System.UInt32 value) { }
        private System.UInt32 get_idFile() { }

    }

    // TypeToken: 0x2000027
    public struct AkFloorPlane
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkFloorPlane AkFloorPlane_XZ;        // 0x0
        public static AkFloorPlane AkFloorPlane_XY;        // 0x0
        public static AkFloorPlane AkFloorPlane_YZ;        // 0x0
        public static AkFloorPlane AkFloorPlane_Default;        // 0x0

    }

    // TypeToken: 0x2000028
    public class AkGeometryInstanceParams, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkGeometryInstanceParams obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void set_PositionAndOrientation(AkWorldTransform value) { }
        private AkWorldTransform get_PositionAndOrientation() { }
        private System.Void set_Scale(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_Scale() { }
        private System.Void set_UseForReflectionAndDiffraction(System.Boolean value) { }
        private System.Boolean get_UseForReflectionAndDiffraction() { }

    }

    // TypeToken: 0x2000029
    public struct AkGlobalCallbackLocation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Register;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Begin;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_PreProcessMessageQueueForRender;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_PostMessagesProcessed;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_BeginRender;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_EndRender;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_End;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Term;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Monitor;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_MonitorRecap;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Init;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Suspend;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_WakeupFromSuspend;        // 0x0
        public static AkGlobalCallbackLocation AkGlobalCallbackLocation_Num;        // 0x0

    }

    // TypeToken: 0x200002A
    public struct AkGroupType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkGroupType AkGroupType_Switch;        // 0x0
        public static AkGroupType AkGroupType_State;        // 0x0

    }

    // TypeToken: 0x200002B
    public class AkImageSourceParams, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkImageSourceParams obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void .ctor(AkVector64 in_sourcePosition, System.Single in_fDistanceScalingFactor, System.Single in_fLevel) { }
        private System.Void set_sourcePosition(AkVector64 value) { }
        private AkVector64 get_sourcePosition() { }
        private System.Void set_fDistanceScalingFactor(System.Single value) { }
        private System.Single get_fDistanceScalingFactor() { }
        private System.Void set_fLevel(System.Single value) { }
        private System.Single get_fLevel() { }
        private System.Void set_fDiffraction(System.Single value) { }
        private System.Single get_fDiffraction() { }
        private System.Void set_fOcclusion(System.Single value) { }
        private System.Single get_fOcclusion() { }
        private System.Void set_uDiffractionEmitterSide(System.Byte value) { }
        private System.Byte get_uDiffractionEmitterSide() { }
        private System.Void set_uDiffractionListenerSide(System.Byte value) { }
        private System.Byte get_uDiffractionListenerSide() { }

    }

    // TypeToken: 0x200002C
    public class AkImageSourceSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkImageSourceSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void .ctor(AkVector64 in_sourcePosition, System.Single in_fDistanceScalingFactor, System.Single in_fLevel) { }
        private System.Void SetOneTexture(System.UInt32 in_texture) { }
        private System.Void set_params_(AkImageSourceParams value) { }
        private AkImageSourceParams get_params_() { }

    }

    // TypeToken: 0x200002D
    public class AkInitializationSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkInitializationSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void set_streamMgrSettings(AkStreamMgrSettings value) { }
        private AkStreamMgrSettings get_streamMgrSettings() { }
        private System.Void set_deviceSettings(AkDeviceSettings value) { }
        private AkDeviceSettings get_deviceSettings() { }
        private System.Void set_initSettings(AkInitSettings value) { }
        private AkInitSettings get_initSettings() { }
        private System.Void set_platformSettings(AkPlatformInitSettings value) { }
        private AkPlatformInitSettings get_platformSettings() { }
        private System.Void set_musicSettings(AkMusicSettings value) { }
        private AkMusicSettings get_musicSettings() { }
        private System.Void set_unityPlatformSpecificSettings(AkUnityPlatformSpecificSettings value) { }
        private AkUnityPlatformSpecificSettings get_unityPlatformSpecificSettings() { }
        private System.Void set_uMemAllocationSizeLimit(System.UInt32 value) { }
        private System.UInt32 get_uMemAllocationSizeLimit() { }
        private System.Void set_uMemDebugLevel(System.UInt32 value) { }
        private System.UInt32 get_uMemDebugLevel() { }
        private System.Void set_uMemSpanCount(System.UInt32 value) { }
        private System.UInt32 get_uMemSpanCount() { }

    }

    // TypeToken: 0x200002E
    public class AkInitSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkInitSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_uMaxNumPaths(System.UInt32 value) { }
        private System.UInt32 get_uMaxNumPaths() { }
        private System.Void set_uCommandQueueSize(System.UInt32 value) { }
        private System.UInt32 get_uCommandQueueSize() { }
        private System.Void set_bEnableGameSyncPreparation(System.Boolean value) { }
        private System.Boolean get_bEnableGameSyncPreparation() { }
        private System.Void set_uContinuousPlaybackLookAhead(System.UInt32 value) { }
        private System.UInt32 get_uContinuousPlaybackLookAhead() { }
        private System.Void set_uNumSamplesPerFrame(System.UInt32 value) { }
        private System.UInt32 get_uNumSamplesPerFrame() { }
        private System.Void set_uMonitorQueuePoolSize(System.UInt32 value) { }
        private System.UInt32 get_uMonitorQueuePoolSize() { }
        private System.Void set_uCpuMonitorQueueMaxSize(System.UInt32 value) { }
        private System.UInt32 get_uCpuMonitorQueueMaxSize() { }
        private System.Void set_settingsMainOutput(AkOutputSettings value) { }
        private AkOutputSettings get_settingsMainOutput() { }
        private System.Void set_uMaxHardwareTimeoutMs(System.UInt32 value) { }
        private System.UInt32 get_uMaxHardwareTimeoutMs() { }
        private System.Void set_bUseSoundBankMgrThread(System.Boolean value) { }
        private System.Boolean get_bUseSoundBankMgrThread() { }
        private System.Void set_bUseLEngineThread(System.Boolean value) { }
        private System.Boolean get_bUseLEngineThread() { }
        private System.Void set_szPluginDLLPath(System.String value) { }
        private System.String get_szPluginDLLPath() { }
        private System.Void set_eFloorPlane(AkFloorPlane value) { }
        private AkFloorPlane get_eFloorPlane() { }
        private System.Void set_fGameUnitsToMeters(System.Single value) { }
        private System.Single get_fGameUnitsToMeters() { }
        private System.Void set_uBankReadBufferSize(System.UInt32 value) { }
        private System.UInt32 get_uBankReadBufferSize() { }
        private System.Void set_fDebugOutOfRangeLimit(System.Single value) { }
        private System.Single get_fDebugOutOfRangeLimit() { }
        private System.Void set_bDebugOutOfRangeCheckEnabled(System.Boolean value) { }
        private System.Boolean get_bDebugOutOfRangeCheckEnabled() { }

    }

    // TypeToken: 0x200002F
    public class AkIterator, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkIterator obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_pItem(AkPlaylistItem value) { }
        private AkPlaylistItem get_pItem() { }
        private AkIterator NextIter() { }
        private AkIterator PrevIter() { }
        private AkPlaylistItem GetItem() { }
        private System.Boolean IsEqualTo(AkIterator in_rOp) { }
        private System.Boolean IsDifferentFrom(AkIterator in_rOp) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000030
    public class AkMarkerCallbackInfo : AkEventCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x28

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMarkerCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.UInt32 get_uIdentifier() { }
        private System.UInt32 get_uPosition() { }
        private System.String get_strLabel() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000031
    public class AkMemCategroyStats, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMemCategroyStats obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_uUsed(System.UInt64 value) { }
        private System.UInt64 get_uUsed() { }
        private System.Void set_uPeakUsed(System.UInt64 value) { }
        private System.UInt64 get_uPeakUsed() { }
        private System.Void set_uAllocs(System.UInt32 value) { }
        private System.UInt32 get_uAllocs() { }
        private System.Void set_uFrees(System.UInt32 value) { }
        private System.UInt32 get_uFrees() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000032
    public class AkMemGlobalStats, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMemGlobalStats obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_uUsed(System.UInt64 value) { }
        private System.UInt64 get_uUsed() { }
        private System.Void set_uDeviceUsed(System.UInt64 value) { }
        private System.UInt64 get_uDeviceUsed() { }
        private System.Void set_uReserved(System.UInt64 value) { }
        private System.UInt64 get_uReserved() { }
        private System.Void set_uMax(System.UInt64 value) { }
        private System.UInt64 get_uMax() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000033
    public struct AkMemID
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static AkMemID AkMemID_Object;        // 0x0
        public static AkMemID AkMemID_Event;        // 0x0
        public static AkMemID AkMemID_Structure;        // 0x0
        public static AkMemID AkMemID_Media;        // 0x0
        public static AkMemID AkMemID_GameObject;        // 0x0
        public static AkMemID AkMemID_Processing;        // 0x0
        public static AkMemID AkMemID_ProcessingPlugin;        // 0x0
        public static AkMemID AkMemID_Streaming;        // 0x0
        public static AkMemID AkMemID_StreamingIO;        // 0x0
        public static AkMemID AkMemID_SpatialAudio;        // 0x0
        public static AkMemID AkMemID_SpatialAudioGeometry;        // 0x0
        public static AkMemID AkMemID_SpatialAudioPaths;        // 0x0
        public static AkMemID AkMemID_GameSim;        // 0x0
        public static AkMemID AkMemID_MonitorQueue;        // 0x0
        public static AkMemID AkMemID_Profiler;        // 0x0
        public static AkMemID AkMemID_FilePackage;        // 0x0
        public static AkMemID AkMemID_SoundEngine;        // 0x0
        public static AkMemID AkMemID_Integration;        // 0x0
        public static AkMemID AkMemID_JobMgr;        // 0x0
        public static AkMemID AkMemID_TempAudioRender;        // 0x0
        public static AkMemID AkMemID_NUM;        // 0x0
        public static AkMemID AkMemID_MASK;        // 0x0
        public static AkMemID AkMemType_Media;        // 0x0
        public static AkMemID AkMemType_Device;        // 0x0
        public static AkMemID AkMemType_NoTrack;        // 0x0

    }

    // TypeToken: 0x2000034
    public struct AkMeteringFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkMeteringFlags AK_NoMetering;        // 0x0
        public static AkMeteringFlags AK_EnableBusMeter_Peak;        // 0x0
        public static AkMeteringFlags AK_EnableBusMeter_TruePeak;        // 0x0
        public static AkMeteringFlags AK_EnableBusMeter_RMS;        // 0x0
        public static AkMeteringFlags AK_EnableBusMeter_KPower;        // 0x0
        public static AkMeteringFlags AK_EnableBusMeter_3DMeter;        // 0x0

    }

    // TypeToken: 0x2000035
    public struct AkMIDICcTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkMIDICcTypes BANK_SELECT_COARSE;        // 0x0
        public static AkMIDICcTypes MOD_WHEEL_COARSE;        // 0x0
        public static AkMIDICcTypes BREATH_CTRL_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_3_COARSE;        // 0x0
        public static AkMIDICcTypes FOOT_PEDAL_COARSE;        // 0x0
        public static AkMIDICcTypes PORTAMENTO_COARSE;        // 0x0
        public static AkMIDICcTypes DATA_ENTRY_COARSE;        // 0x0
        public static AkMIDICcTypes VOLUME_COARSE;        // 0x0
        public static AkMIDICcTypes BALANCE_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_9_COARSE;        // 0x0
        public static AkMIDICcTypes PAN_POSITION_COARSE;        // 0x0
        public static AkMIDICcTypes EXPRESSION_COARSE;        // 0x0
        public static AkMIDICcTypes EFFECT_CTRL_1_COARSE;        // 0x0
        public static AkMIDICcTypes EFFECT_CTRL_2_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_14_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_15_COARSE;        // 0x0
        public static AkMIDICcTypes GEN_SLIDER_1;        // 0x0
        public static AkMIDICcTypes GEN_SLIDER_2;        // 0x0
        public static AkMIDICcTypes GEN_SLIDER_3;        // 0x0
        public static AkMIDICcTypes GEN_SLIDER_4;        // 0x0
        public static AkMIDICcTypes CTRL_20_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_21_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_22_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_23_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_24_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_25_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_26_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_27_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_28_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_29_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_30_COARSE;        // 0x0
        public static AkMIDICcTypes CTRL_31_COARSE;        // 0x0
        public static AkMIDICcTypes BANK_SELECT_FINE;        // 0x0
        public static AkMIDICcTypes MOD_WHEEL_FINE;        // 0x0
        public static AkMIDICcTypes BREATH_CTRL_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_3_FINE;        // 0x0
        public static AkMIDICcTypes FOOT_PEDAL_FINE;        // 0x0
        public static AkMIDICcTypes PORTAMENTO_FINE;        // 0x0
        public static AkMIDICcTypes DATA_ENTRY_FINE;        // 0x0
        public static AkMIDICcTypes VOLUME_FINE;        // 0x0
        public static AkMIDICcTypes BALANCE_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_9_FINE;        // 0x0
        public static AkMIDICcTypes PAN_POSITION_FINE;        // 0x0
        public static AkMIDICcTypes EXPRESSION_FINE;        // 0x0
        public static AkMIDICcTypes EFFECT_CTRL_1_FINE;        // 0x0
        public static AkMIDICcTypes EFFECT_CTRL_2_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_14_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_15_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_20_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_21_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_22_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_23_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_24_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_25_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_26_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_27_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_28_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_29_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_30_FINE;        // 0x0
        public static AkMIDICcTypes CTRL_31_FINE;        // 0x0
        public static AkMIDICcTypes HOLD_PEDAL;        // 0x0
        public static AkMIDICcTypes PORTAMENTO_ON_OFF;        // 0x0
        public static AkMIDICcTypes SUSTENUTO_PEDAL;        // 0x0
        public static AkMIDICcTypes SOFT_PEDAL;        // 0x0
        public static AkMIDICcTypes LEGATO_PEDAL;        // 0x0
        public static AkMIDICcTypes HOLD_PEDAL_2;        // 0x0
        public static AkMIDICcTypes SOUND_VARIATION;        // 0x0
        public static AkMIDICcTypes SOUND_TIMBRE;        // 0x0
        public static AkMIDICcTypes SOUND_RELEASE_TIME;        // 0x0
        public static AkMIDICcTypes SOUND_ATTACK_TIME;        // 0x0
        public static AkMIDICcTypes SOUND_BRIGHTNESS;        // 0x0
        public static AkMIDICcTypes SOUND_CTRL_6;        // 0x0
        public static AkMIDICcTypes SOUND_CTRL_7;        // 0x0
        public static AkMIDICcTypes SOUND_CTRL_8;        // 0x0
        public static AkMIDICcTypes SOUND_CTRL_9;        // 0x0
        public static AkMIDICcTypes SOUND_CTRL_10;        // 0x0
        public static AkMIDICcTypes GENERAL_BUTTON_1;        // 0x0
        public static AkMIDICcTypes GENERAL_BUTTON_2;        // 0x0
        public static AkMIDICcTypes GENERAL_BUTTON_3;        // 0x0
        public static AkMIDICcTypes GENERAL_BUTTON_4;        // 0x0
        public static AkMIDICcTypes REVERB_LEVEL;        // 0x0
        public static AkMIDICcTypes TREMOLO_LEVEL;        // 0x0
        public static AkMIDICcTypes CHORUS_LEVEL;        // 0x0
        public static AkMIDICcTypes CELESTE_LEVEL;        // 0x0
        public static AkMIDICcTypes PHASER_LEVEL;        // 0x0
        public static AkMIDICcTypes DATA_BUTTON_P1;        // 0x0
        public static AkMIDICcTypes DATA_BUTTON_M1;        // 0x0
        public static AkMIDICcTypes NON_REGISTER_COARSE;        // 0x0
        public static AkMIDICcTypes NON_REGISTER_FINE;        // 0x0
        public static AkMIDICcTypes ALL_SOUND_OFF;        // 0x0
        public static AkMIDICcTypes ALL_CONTROLLERS_OFF;        // 0x0
        public static AkMIDICcTypes LOCAL_KEYBOARD;        // 0x0
        public static AkMIDICcTypes ALL_NOTES_OFF;        // 0x0
        public static AkMIDICcTypes OMNI_MODE_OFF;        // 0x0
        public static AkMIDICcTypes OMNI_MODE_ON;        // 0x0
        public static AkMIDICcTypes OMNI_MONOPHONIC_ON;        // 0x0
        public static AkMIDICcTypes OMNI_POLYPHONIC_ON;        // 0x0

    }

    // TypeToken: 0x2000037
    public class tGen, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMIDIEvent.tGen obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_byParam1(System.Byte value) { }
        private System.Byte get_byParam1() { }
        private System.Void set_byParam2(System.Byte value) { }
        private System.Byte get_byParam2() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000038
    public class tNoteOnOff, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMIDIEvent.tNoteOnOff obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_byNote(System.Byte value) { }
        private System.Byte get_byNote() { }
        private System.Void set_byVelocity(System.Byte value) { }
        private System.Byte get_byVelocity() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public class tCc, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMIDIEvent.tCc obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_byCc(System.Byte value) { }
        private System.Byte get_byCc() { }
        private System.Void set_byValue(System.Byte value) { }
        private System.Byte get_byValue() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003A
    public class tPitchBend, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMIDIEvent.tPitchBend obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_byValueLsb(System.Byte value) { }
        private System.Byte get_byValueLsb() { }
        private System.Void set_byValueMsb(System.Byte value) { }
        private System.Byte get_byValueMsb() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003B
    public class tNoteAftertouch, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMIDIEvent.tNoteAftertouch obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_byNote(System.Byte value) { }
        private System.Byte get_byNote() { }
        private System.Void set_byValue(System.Byte value) { }
        private System.Byte get_byValue() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003C
    public class tChanAftertouch, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMIDIEvent.tChanAftertouch obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_byValue(System.Byte value) { }
        private System.Byte get_byValue() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003D
    public class tProgramChange, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMIDIEvent.tProgramChange obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_byProgramNum(System.Byte value) { }
        private System.Byte get_byProgramNum() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003E
    public class tWwiseCmd, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMIDIEvent.tWwiseCmd obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_uCmd(System.UInt16 value) { }
        private System.UInt16 get_uCmd() { }
        private System.Void set_uArg(System.UInt32 value) { }
        private System.UInt32 get_uArg() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000036
    public class AkMIDIEvent, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMIDIEvent obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_byChan(System.Byte value) { }
        private System.Byte get_byChan() { }
        private System.Void set_Gen(AkMIDIEvent.tGen value) { }
        private AkMIDIEvent.tGen get_Gen() { }
        private System.Void set_Cc(AkMIDIEvent.tCc value) { }
        private AkMIDIEvent.tCc get_Cc() { }
        private System.Void set_NoteOnOff(AkMIDIEvent.tNoteOnOff value) { }
        private AkMIDIEvent.tNoteOnOff get_NoteOnOff() { }
        private System.Void set_PitchBend(AkMIDIEvent.tPitchBend value) { }
        private AkMIDIEvent.tPitchBend get_PitchBend() { }
        private System.Void set_NoteAftertouch(AkMIDIEvent.tNoteAftertouch value) { }
        private AkMIDIEvent.tNoteAftertouch get_NoteAftertouch() { }
        private System.Void set_ChanAftertouch(AkMIDIEvent.tChanAftertouch value) { }
        private AkMIDIEvent.tChanAftertouch get_ChanAftertouch() { }
        private System.Void set_ProgramChange(AkMIDIEvent.tProgramChange value) { }
        private AkMIDIEvent.tProgramChange get_ProgramChange() { }
        private System.Void set_WwiseCmd(AkMIDIEvent.tWwiseCmd value) { }
        private AkMIDIEvent.tWwiseCmd get_WwiseCmd() { }
        private System.Void set_byType(AkMIDIEventTypes value) { }
        private AkMIDIEventTypes get_byType() { }
        private System.Void set_byOnOffNote(System.Byte value) { }
        private System.Byte get_byOnOffNote() { }
        private System.Void set_byVelocity(System.Byte value) { }
        private System.Byte get_byVelocity() { }
        private System.Void set_byCc(AkMIDICcTypes value) { }
        private AkMIDICcTypes get_byCc() { }
        private System.Void set_byCcValue(System.Byte value) { }
        private System.Byte get_byCcValue() { }
        private System.Void set_byValueLsb(System.Byte value) { }
        private System.Byte get_byValueLsb() { }
        private System.Void set_byValueMsb(System.Byte value) { }
        private System.Byte get_byValueMsb() { }
        private System.Void set_byAftertouchNote(System.Byte value) { }
        private System.Byte get_byAftertouchNote() { }
        private System.Void set_byNoteAftertouchValue(System.Byte value) { }
        private System.Byte get_byNoteAftertouchValue() { }
        private System.Void set_byChanAftertouchValue(System.Byte value) { }
        private System.Byte get_byChanAftertouchValue() { }
        private System.Void set_byProgramNum(System.Byte value) { }
        private System.Byte get_byProgramNum() { }
        private System.Void set_uCmd(System.UInt16 value) { }
        private System.UInt16 get_uCmd() { }
        private System.Void set_uArg(System.UInt32 value) { }
        private System.UInt32 get_uArg() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public class AkMIDIEventCallbackInfo : AkEventCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x28

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMIDIEventCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Byte get_byChan() { }
        private System.Byte get_byParam1() { }
        private System.Byte get_byParam2() { }
        private AkMIDIEventTypes get_byType() { }
        private System.Byte get_byOnOffNote() { }
        private System.Byte get_byVelocity() { }
        private AkMIDICcTypes get_byCc() { }
        private System.Byte get_byCcValue() { }
        private System.Byte get_byValueLsb() { }
        private System.Byte get_byValueMsb() { }
        private System.Byte get_byAftertouchNote() { }
        private System.Byte get_byNoteAftertouchValue() { }
        private System.Byte get_byChanAftertouchValue() { }
        private System.Byte get_byProgramNum() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000040
    public struct AkMIDIEventTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkMIDIEventTypes NOTE_OFF;        // 0x0
        public static AkMIDIEventTypes NOTE_ON;        // 0x0
        public static AkMIDIEventTypes NOTE_AFTERTOUCH;        // 0x0
        public static AkMIDIEventTypes CONTROLLER;        // 0x0
        public static AkMIDIEventTypes PROGRAM_CHANGE;        // 0x0
        public static AkMIDIEventTypes CHANNEL_AFTERTOUCH;        // 0x0
        public static AkMIDIEventTypes PITCH_BEND;        // 0x0
        public static AkMIDIEventTypes SYSEX;        // 0x0
        public static AkMIDIEventTypes ESCAPE;        // 0x0
        public static AkMIDIEventTypes META;        // 0x0

    }

    // TypeToken: 0x2000041
    public class AkMIDIPost : AkMIDIEvent
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x20

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMIDIPost obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_uOffset(System.UInt64 value) { }
        private System.UInt64 get_uOffset() { }
        private System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts) { }
        private System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets) { }
        private System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        private System.UInt32 PostOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_playingID) { }
        private System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts) { }
        private System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets) { }
        private System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        private System.UInt32 PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_playingID) { }
        private System.Void Clone(AkMIDIPost other) { }
        private System.Int32 GetSizeOf() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000042
    public struct AkMonitorErrorCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkMonitorErrorCode ErrorCode_NoError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_FileNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotOpenFile;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotStartStreamNoMemory;        // 0x0
        public static AkMonitorErrorCode ErrorCode_IODevice;        // 0x0
        public static AkMonitorErrorCode ErrorCode_IncompatibleIOSettings;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginUnsupportedChannelConfiguration;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginMediaUnavailable;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginInitialisationFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginProcessingFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginExecutionInvalid;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginAllocationFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_VorbisSeekTableRecommended;        // 0x0
        public static AkMonitorErrorCode ErrorCode_VorbisDecodeError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_ATRAC9DecodeFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_ATRAC9LoopSectionTooSmall;        // 0x0
        public static AkMonitorErrorCode ErrorCode_InvalidAudioFileHeader;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioFileHeaderTooLarge;        // 0x0
        public static AkMonitorErrorCode ErrorCode_LoopTooSmall;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccurateChannel;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccuratePluginMismatch;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccurateRejectedByPlugin;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccurateStarvation;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccurateCodecError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_NothingToPlay;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PlayFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_StingerCouldNotBeScheduled;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TooLongSegmentLookAhead;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotScheduleMusicSwitch;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TooManySimultaneousMusicSegments;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PlaylistStoppedForEditing;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MusicClipsRescheduledAfterTrackEdit;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotPlaySource_Create;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotPlaySource_VirtualOff;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotPlaySource_TimeSkip;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotPlaySource_InconsistentState;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MediaNotLoaded;        // 0x0
        public static AkMonitorErrorCode ErrorCode_VoiceStarving;        // 0x0
        public static AkMonitorErrorCode ErrorCode_StreamingSourceStarving;        // 0x0
        public static AkMonitorErrorCode ErrorCode_XMADecoderSourceStarving;        // 0x0
        public static AkMonitorErrorCode ErrorCode_XMADecodingError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_InvalidXMAData;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginNotRegistered;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CodecNotRegistered;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginVersionMismatch;        // 0x0
        public static AkMonitorErrorCode ErrorCode_EventIDNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_InvalidGroupID;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SelectedNodeNotAvailable;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SelectedMediaNotAvailable;        // 0x0
        public static AkMonitorErrorCode ErrorCode_NoValidSwitch;        // 0x0
        public static AkMonitorErrorCode ErrorCode_BankLoadFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_ErrorWhileLoadingBank;        // 0x0
        public static AkMonitorErrorCode ErrorCode_InsufficientSpaceToLoadBank;        // 0x0
        public static AkMonitorErrorCode ErrorCode_LowerEngineCommandListFull;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SeekNoMarker;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotSeekContinuous;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SeekAfterEof;        // 0x0
        public static AkMonitorErrorCode ErrorCode_UnknownGameObject;        // 0x0
        public static AkMonitorErrorCode ErrorCode_GameObjectNeverRegistered;        // 0x0
        public static AkMonitorErrorCode ErrorCode_DeadGameObject;        // 0x0
        public static AkMonitorErrorCode ErrorCode_GameObjectIsNotEmitter;        // 0x0
        public static AkMonitorErrorCode ErrorCode_ExternalSourceNotResolved;        // 0x0
        public static AkMonitorErrorCode ErrorCode_FileFormatMismatch;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CommandQueueFull;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CommandTooLarge;        // 0x0
        public static AkMonitorErrorCode ErrorCode_XMACreateDecoderLimitReached;        // 0x0
        public static AkMonitorErrorCode ErrorCode_XMAStreamBufferTooSmall;        // 0x0
        public static AkMonitorErrorCode ErrorCode_ModulatorScopeError_Inst;        // 0x0
        public static AkMonitorErrorCode ErrorCode_ModulatorScopeError_Obj;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SeekAfterEndOfPlaylist;        // 0x0
        public static AkMonitorErrorCode ErrorCode_OpusRequireSeekTable;        // 0x0
        public static AkMonitorErrorCode ErrorCode_OpusDecodeError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SourcePluginNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_VirtualVoiceLimit;        // 0x0
        public static AkMonitorErrorCode ErrorCode_NotEnoughMemoryToStart;        // 0x0
        public static AkMonitorErrorCode ErrorCode_UnknownOpusError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioDeviceInitFailure;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioDeviceRemoveFailure;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioDeviceNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioDeviceNotValid;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SpatialAudio_ListenerAutomationNotSupported;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MediaDuplicationLength;        // 0x0
        public static AkMonitorErrorCode ErrorCode_HwVoicesSystemInitFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_HwVoicesDecodeBatchFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_HwVoiceLimitReached;        // 0x0
        public static AkMonitorErrorCode ErrorCode_HwVoiceInitFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_OpusHWCommandFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AddOutputListenerIdWithZeroListeners;        // 0x0
        public static AkMonitorErrorCode ErrorCode_3DObjectLimitExceeded;        // 0x0
        public static AkMonitorErrorCode ErrorCode_OpusHWFatalError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_OpusHWDecodeUnavailable;        // 0x0
        public static AkMonitorErrorCode ErrorCode_OpusHWTimeout;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SystemAudioObjectsUnavailable;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AddOutputNoDistinctListener;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginCannotRunOnObjectConfig;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SpatialAudio_ReflectionBusError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_VorbisHWDecodeUnavailable;        // 0x0
        public static AkMonitorErrorCode ErrorCode_ExternalSourceNoMemorySize;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MonitorQueueFull;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MonitorMsgTooLarge;        // 0x0
        public static AkMonitorErrorCode ErrorCode_NonCompliantDeviceMemory;        // 0x0
        public static AkMonitorErrorCode ErrorCode_JobWorkerFuncCallMismatch;        // 0x0
        public static AkMonitorErrorCode ErrorCode_JobMgrOutOfMemory;        // 0x0
        public static AkMonitorErrorCode ErrorCode_InvalidFileSize;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginMsg;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SinkOpenSL;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioOutOfRange;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioOutOfRangeOnBus;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioOutOfRangeOnBusFx;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioOutOfRangeRay;        // 0x0
        public static AkMonitorErrorCode ErrorCode_UnknownDialogueEvent;        // 0x0
        public static AkMonitorErrorCode ErrorCode_FailedPostingEvent;        // 0x0
        public static AkMonitorErrorCode ErrorCode_OutputDeviceInitializationFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_UnloadBankFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginFileNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginFileIncompatible;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginFileNotEnoughMemoryToStart;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginFileInvalid;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginFileRegisterFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_UnknownArgument;        // 0x0
        public static AkMonitorErrorCode ErrorCode_DynamicSequenceAlreadyClosed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PendingActionDestroyed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CrossFadeTransitionIgnored;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MusicRendererSeekingFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_DynamicSequenceIdNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_BusNotFoundByName;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioDeviceShareSetNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioDeviceShareSetNotFoundByName;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SoundEngineTooManyGameObjects;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SoundEngineTooManyPositions;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SoundEngineCantCallOnChildBus;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SoundEnginePlayingIdNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SoundEngineInvalidTransform;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SoundEngineTooManyEventPosts;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioSubsystemStoppedResponding;        // 0x0
        public static AkMonitorErrorCode ErrorCode_NotEnoughMemInFunction;        // 0x0
        public static AkMonitorErrorCode ErrorCode_FXNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetMixerNotABus;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioNodeNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetMixerFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetBusConfigUnsupported;        // 0x0
        public static AkMonitorErrorCode ErrorCode_BusNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MismatchingMediaSize;        // 0x0
        public static AkMonitorErrorCode ErrorCode_IncompatibleBankVersion;        // 0x0
        public static AkMonitorErrorCode ErrorCode_UnexpectedPrepareGameSyncsCall;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MusicEngineNotInitialized;        // 0x0
        public static AkMonitorErrorCode ErrorCode_LoadingBankMismatch;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MasterBusStructureNotLoaded;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TooManyChildren;        // 0x0
        public static AkMonitorErrorCode ErrorCode_BankContainUneditableEffect;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MemoryAllocationFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_InvalidFloatPriority;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SoundLoadFailedInsufficientMemory;        // 0x0
        public static AkMonitorErrorCode ErrorCode_NXDeviceRegistrationFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MixPluginOnObjectBus;        // 0x0
        public static AkMonitorErrorCode ErrorCode_XboxXMAVoiceResetFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_XboxACPMessage;        // 0x0
        public static AkMonitorErrorCode ErrorCode_XboxFrameDropped;        // 0x0
        public static AkMonitorErrorCode ErrorCode_XboxACPError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_XboxXMAFatalError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MissingMusicNodeParent;        // 0x0
        public static AkMonitorErrorCode ErrorCode_HardwareOpusDecoderError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetGeometryTooManyTriangleConnected;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetGeometryTriangleTooLarge;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetGeometryFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_RemovingGeometrySetFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetGeometryInstanceFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_RemovingGeometryInstanceFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_RevertingToDefaultAudioDevice;        // 0x0
        public static AkMonitorErrorCode ErrorCode_RevertingToDummyAudioDevice;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioThreadSuspended;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioThreadResumed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_ResetPlaylistActionIgnoredGlobalScope;        // 0x0
        public static AkMonitorErrorCode ErrorCode_ResetPlaylistActionIgnoredContinuous;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PlayingTriggerRateNotSupported;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetGeometryTriangleIsSkipped;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetGeometryInstanceInvalidTransform;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetGameObjectRadiusSizeError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetPortalNonDistinctRoom;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetPortalInvalidExtent;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SpatialAudio_PortalNotFound;        // 0x0
        public static AkMonitorErrorCode ErrorCode_InvalidFloatInFunction;        // 0x0
        public static AkMonitorErrorCode ErrorCode_FLTMAXNotSupported;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotInitializeAmbisonicChannelConfiguration;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotInitializePassthrough;        // 0x0
        public static AkMonitorErrorCode ErrorCode_3DAudioUnsupportedSize;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AmbisonicNotAvailable;        // 0x0
        public static AkMonitorErrorCode ErrorCode_NoAudioDevice;        // 0x0
        public static AkMonitorErrorCode ErrorCode_Support;        // 0x0
        public static AkMonitorErrorCode ErrorCode_ReplayMessage;        // 0x0
        public static AkMonitorErrorCode ErrorCode_GameMessage;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TestMessage;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TranslatorStandardTagTest;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TranslatorWwiseTagTest;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TranslatorStringSizeTest;        // 0x0
        public static AkMonitorErrorCode ErrorCode_InvalidParameter;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MaxAudioObjExceeded;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MMSNotEnabled;        // 0x0
        public static AkMonitorErrorCode ErrorCode_NotEnoughSystemObj;        // 0x0
        public static AkMonitorErrorCode ErrorCode_NotEnoughSystemObjWin;        // 0x0
        public static AkMonitorErrorCode ErrorCode_TransitionNotAccurateSourceTooShort;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AlreadyInitialized;        // 0x0
        public static AkMonitorErrorCode ErrorCode_WrongNumberOfArguments;        // 0x0
        public static AkMonitorErrorCode ErrorCode_DataAlignement;        // 0x0
        public static AkMonitorErrorCode ErrorCode_PluginMsgWithShareSet;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SoundEngineNotInit;        // 0x0
        public static AkMonitorErrorCode ErrorCode_NoDefaultSwitch;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CantSetBoundSwitch;        // 0x0
        public static AkMonitorErrorCode ErrorCode_IODeviceInitFailed;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SwitchListEmpty;        // 0x0
        public static AkMonitorErrorCode ErrorCode_NoSwitchSelected;        // 0x0
        public static AkMonitorErrorCode ErrorCode_FilePermissionError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SetEffectOnRendered;        // 0x0
        public static AkMonitorErrorCode ErrorCode_GeometryNotWatertight;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotInitialize3DAudio;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotInitializeInputCallbacks;        // 0x0
        public static AkMonitorErrorCode ErrorCode_CannotConnectAVAudioEngineSource;        // 0x0
        public static AkMonitorErrorCode ErrorCode_ChannelConfigRequestDenied;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MediaUpdatedFromWwise;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MediaErrorFromWwise;        // 0x0
        public static AkMonitorErrorCode ErrorCode_OutputAlreadyExists;        // 0x0
        public static AkMonitorErrorCode ErrorCode_UnknownStateGroup;        // 0x0
        public static AkMonitorErrorCode ErrorCode_MediaErrorWwiseMRUFull;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioOut2ContextCreateError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AudioOut2UserCreateError;        // 0x0
        public static AkMonitorErrorCode ErrorCode_FeedbackOnAudioObjectsBus;        // 0x0
        public static AkMonitorErrorCode ErrorCode_AssetSwapEnabled;        // 0x0
        public static AkMonitorErrorCode ErrorCode_SpatialAudio_SiblingPortal;        // 0x0
        public static AkMonitorErrorCode Num_ErrorCodes;        // 0x0

    }

    // TypeToken: 0x2000043
    public struct AkMonitorErrorLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkMonitorErrorLevel ErrorLevel_Message;        // 0x0
        public static AkMonitorErrorLevel ErrorLevel_Error;        // 0x0
        public static AkMonitorErrorLevel ErrorLevel_All;        // 0x0

    }

    // TypeToken: 0x2000044
    public class AkMonitoringCallbackInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMonitoringCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private AkMonitorErrorCode get_errorCode() { }
        private AkMonitorErrorLevel get_errorLevel() { }
        private System.UInt32 get_playingID() { }
        private System.UInt64 get_gameObjID() { }
        private System.String get_message() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public struct AkMultiPositionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkMultiPositionType MultiPositionType_SingleSource;        // 0x0
        public static AkMultiPositionType MultiPositionType_MultiSources;        // 0x0
        public static AkMultiPositionType MultiPositionType_MultiDirections;        // 0x0

    }

    // TypeToken: 0x2000046
    public class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x28

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.UInt32 get_playlistID() { }
        private System.UInt32 get_uNumPlaylistItems() { }
        private System.UInt32 get_uPlaylistSelection() { }
        private System.UInt32 get_uPlaylistItemDone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public class AkMusicSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMusicSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_fStreamingLookAheadRatio(System.Single value) { }
        private System.Single get_fStreamingLookAheadRatio() { }

    }

    // TypeToken: 0x2000048
    public class AkMusicSyncCallbackInfo : AkCallbackInfo
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x20

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkMusicSyncCallbackInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.UInt32 get_playingID() { }
        private System.Int32 get_segmentInfo_iCurrentPosition() { }
        private System.Int32 get_segmentInfo_iPreEntryDuration() { }
        private System.Int32 get_segmentInfo_iActiveDuration() { }
        private System.Int32 get_segmentInfo_iPostExitDuration() { }
        private System.Int32 get_segmentInfo_iRemainingLookAheadTime() { }
        private System.Single get_segmentInfo_fBeatDuration() { }
        private System.Single get_segmentInfo_fBarDuration() { }
        private System.Single get_segmentInfo_fGridDuration() { }
        private System.Single get_segmentInfo_fGridOffset() { }
        private AkCallbackType get_musicSyncType() { }
        private System.String get_userCueName() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public class AkObjectInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkObjectInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_objID(System.UInt32 value) { }
        private System.UInt32 get_objID() { }
        private System.Void set_parentID(System.UInt32 value) { }
        private System.UInt32 get_parentID() { }
        private System.Void set_iDepth(System.Int32 value) { }
        private System.Int32 get_iDepth() { }
        private System.Void Clear() { }
        private System.Int32 GetSizeOf() { }
        private System.Void Clone(AkObjectInfo other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004A
    public class AkObstructionOcclusionValues, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkObstructionOcclusionValues obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_occlusion(System.Single value) { }
        private System.Single get_occlusion() { }
        private System.Void set_obstruction(System.Single value) { }
        private System.Single get_obstruction() { }
        private System.Void Clear() { }
        private System.Int32 GetSizeOf() { }
        private System.Void Clone(AkObstructionOcclusionValues other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public class AkOutputSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkOutputSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String in_szDeviceShareSet, System.UInt32 in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning) { }
        private System.Void .ctor(System.String in_szDeviceShareSet, System.UInt32 in_idDevice, AkChannelConfig in_channelConfig) { }
        private System.Void .ctor(System.String in_szDeviceShareSet, System.UInt32 in_idDevice) { }
        private System.Void .ctor(System.String in_szDeviceShareSet) { }
        private System.Void set_audioDeviceShareset(System.UInt32 value) { }
        private System.UInt32 get_audioDeviceShareset() { }
        private System.Void set_idDevice(System.UInt32 value) { }
        private System.UInt32 get_idDevice() { }
        private System.Void set_ePanningRule(AkPanningRule value) { }
        private AkPanningRule get_ePanningRule() { }
        private System.Void set_channelConfig(AkChannelConfig value) { }
        private AkChannelConfig get_channelConfig() { }

    }

    // TypeToken: 0x200004C
    public struct AkPanningRule
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkPanningRule AkPanningRule_Speakers;        // 0x0
        public static AkPanningRule AkPanningRule_Headphones;        // 0x0

    }

    // TypeToken: 0x200004D
    public class AkPlaylist : AkPlaylistArray
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x20

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkPlaylist obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay, System.IntPtr in_pCustomInfo, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }
        private AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay, System.IntPtr in_pCustomInfo, System.UInt32 in_cExternals) { }
        private AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay, System.IntPtr in_pCustomInfo) { }
        private AKRESULT Enqueue(System.UInt32 in_audioNodeID, System.Int32 in_msDelay) { }
        private AKRESULT Enqueue(System.UInt32 in_audioNodeID) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004E
    public class AkPlaylistArray, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkPlaylistArray obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private AkIterator Begin() { }
        private AkIterator End() { }
        private AkIterator FindEx(AkPlaylistItem in_Item) { }
        private AkIterator Erase(AkIterator in_rIter) { }
        private System.Void Erase(System.UInt32 in_uIndex) { }
        private AkIterator EraseSwap(AkIterator in_rIter) { }
        private System.Void EraseSwap(System.UInt32 in_uIndex) { }
        private System.Boolean IsGrowingAllowed() { }
        private AKRESULT Reserve(System.UInt32 in_ulReserve) { }
        private AKRESULT ReserveExtra(System.UInt32 in_ulReserve) { }
        private System.UInt32 Reserved() { }
        private System.Void Term() { }
        private System.UInt32 Length() { }
        private AkPlaylistItem Data() { }
        private System.Boolean IsEmpty() { }
        private AkPlaylistItem Exists(AkPlaylistItem in_Item) { }
        private AkPlaylistItem AddLast() { }
        private AkPlaylistItem AddLast(AkPlaylistItem in_rItem) { }
        private AkPlaylistItem Last() { }
        private System.Void RemoveLast() { }
        private AKRESULT Remove(AkPlaylistItem in_rItem) { }
        private AKRESULT RemoveSwap(AkPlaylistItem in_rItem) { }
        private System.Void RemoveAll() { }
        private AkPlaylistItem ItemAtIndex(System.UInt32 uiIndex) { }
        private AkIterator Insert(AkIterator in_rIter) { }
        private AkPlaylistItem Insert(System.UInt32 in_uIndex) { }
        private System.Boolean GrowArray() { }
        private System.Boolean GrowArray(System.UInt32 in_uGrowBy) { }
        private System.Boolean Resize(System.UInt32 in_uiSize) { }
        private System.Void Transfer(AkPlaylistArray in_rSource) { }
        private AKRESULT Copy(AkPlaylistArray in_rSource) { }

    }

    // TypeToken: 0x200004F
    public class AkPlaylistItem, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkPlaylistItem obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void .ctor(AkPlaylistItem in_rCopy) { }
        private AkPlaylistItem Assign(AkPlaylistItem in_rCopy) { }
        private System.Boolean IsEqualTo(AkPlaylistItem in_rCopy) { }
        private AKRESULT SetExternalSources(System.UInt32 in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc) { }
        private System.Void set_audioNodeID(System.UInt32 value) { }
        private System.UInt32 get_audioNodeID() { }
        private System.Void set_msDelay(System.Int32 value) { }
        private System.Int32 get_msDelay() { }
        private System.Void set_pCustomInfo(System.IntPtr value) { }
        private System.IntPtr get_pCustomInfo() { }

    }

    // TypeToken: 0x2000050
    public struct AkPluginType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkPluginType AkPluginTypeNone;        // 0x0
        public static AkPluginType AkPluginTypeCodec;        // 0x0
        public static AkPluginType AkPluginTypeSource;        // 0x0
        public static AkPluginType AkPluginTypeEffect;        // 0x0
        public static AkPluginType AkPluginTypeMixer;        // 0x0
        public static AkPluginType AkPluginTypeSink;        // 0x0
        public static AkPluginType AkPluginTypeGlobalExtension;        // 0x0
        public static AkPluginType AkPluginTypeMetadata;        // 0x0
        public static AkPluginType AkPluginTypeMask;        // 0x0

    }

    // TypeToken: 0x2000051
    public class AkPositioningData, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkPositioningData obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_threeD(Ak3dData value) { }
        private Ak3dData get_threeD() { }
        private System.Void set_behavioral(AkBehavioralPositioningData value) { }
        private AkBehavioralPositioningData get_behavioral() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000052
    public class AkPositioningInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkPositioningInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_fCenterPct(System.Single value) { }
        private System.Single get_fCenterPct() { }
        private System.Void set_pannerType(AkSpeakerPanningType value) { }
        private AkSpeakerPanningType get_pannerType() { }
        private System.Void set_e3dPositioningType(Ak3DPositionType value) { }
        private Ak3DPositionType get_e3dPositioningType() { }
        private System.Void set_bHoldEmitterPosAndOrient(System.Boolean value) { }
        private System.Boolean get_bHoldEmitterPosAndOrient() { }
        private System.Void set_e3DSpatializationMode(Ak3DSpatializationMode value) { }
        private Ak3DSpatializationMode get_e3DSpatializationMode() { }
        private System.Void set_bEnableAttenuation(System.Boolean value) { }
        private System.Boolean get_bEnableAttenuation() { }
        private System.Void set_bUseConeAttenuation(System.Boolean value) { }
        private System.Boolean get_bUseConeAttenuation() { }
        private System.Void set_fInnerAngle(System.Single value) { }
        private System.Single get_fInnerAngle() { }
        private System.Void set_fOuterAngle(System.Single value) { }
        private System.Single get_fOuterAngle() { }
        private System.Void set_fConeMaxAttenuation(System.Single value) { }
        private System.Single get_fConeMaxAttenuation() { }
        private System.Void set_LPFCone(System.Single value) { }
        private System.Single get_LPFCone() { }
        private System.Void set_HPFCone(System.Single value) { }
        private System.Single get_HPFCone() { }
        private System.Void set_fMaxDistance(System.Single value) { }
        private System.Single get_fMaxDistance() { }
        private System.Void set_fVolDryAtMaxDist(System.Single value) { }
        private System.Single get_fVolDryAtMaxDist() { }
        private System.Void set_fVolAuxGameDefAtMaxDist(System.Single value) { }
        private System.Single get_fVolAuxGameDefAtMaxDist() { }
        private System.Void set_fVolAuxUserDefAtMaxDist(System.Single value) { }
        private System.Single get_fVolAuxUserDefAtMaxDist() { }
        private System.Void set_LPFValueAtMaxDist(System.Single value) { }
        private System.Single get_LPFValueAtMaxDist() { }
        private System.Void set_HPFValueAtMaxDist(System.Single value) { }
        private System.Single get_HPFValueAtMaxDist() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000053
    public struct AkPreparationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkPreparationType Preparation_Load;        // 0x0
        public static AkPreparationType Preparation_Unload;        // 0x0
        public static AkPreparationType Preparation_LoadAndDecode;        // 0x0

    }

    // TypeToken: 0x2000054
    public struct AkQueryRTPCValue
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkQueryRTPCValue RTPCValue_Default;        // 0x0
        public static AkQueryRTPCValue RTPCValue_Global;        // 0x0
        public static AkQueryRTPCValue RTPCValue_GameObject;        // 0x0
        public static AkQueryRTPCValue RTPCValue_PlayingID;        // 0x0
        public static AkQueryRTPCValue RTPCValue_Unavailable;        // 0x0

    }

    // TypeToken: 0x2000055
    public class AkRamp, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkRamp obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Single in_fPrev, System.Single in_fNext) { }
        private System.Void set_fPrev(System.Single value) { }
        private System.Single get_fPrev() { }
        private System.Void set_fNext(System.Single value) { }
        private System.Single get_fNext() { }

    }

    // TypeToken: 0x2000056
    public class AkReflectionPathInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkReflectionPathInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_imageSource(AkVector64 value) { }
        private AkVector64 get_imageSource() { }
        private System.Void set_numPathPoints(System.UInt32 value) { }
        private System.UInt32 get_numPathPoints() { }
        private System.Void set_numReflections(System.UInt32 value) { }
        private System.UInt32 get_numReflections() { }
        private System.Void set_level(System.Single value) { }
        private System.Single get_level() { }
        private System.Void set_isOccluded(System.Boolean value) { }
        private System.Boolean get_isOccluded() { }
        private System.Int32 GetSizeOf() { }
        private UnityEngine.Vector3 GetPathPoint(System.UInt32 idx) { }
        private AkAcousticSurface GetAcousticSurface(System.UInt32 idx) { }
        private System.Single GetDiffraction(System.UInt32 idx) { }
        private System.Void Clone(AkReflectionPathInfo other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000057
    public class AkResourceMonitorDataSummary, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkResourceMonitorDataSummary obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_totalCPU(System.Single value) { }
        private System.Single get_totalCPU() { }
        private System.Void set_pluginCPU(System.Single value) { }
        private System.Single get_pluginCPU() { }
        private System.Void set_physicalVoices(System.UInt32 value) { }
        private System.UInt32 get_physicalVoices() { }
        private System.Void set_virtualVoices(System.UInt32 value) { }
        private System.UInt32 get_virtualVoices() { }
        private System.Void set_totalVoices(System.UInt32 value) { }
        private System.UInt32 get_totalVoices() { }
        private System.Void set_nbActiveEvents(System.UInt32 value) { }
        private System.UInt32 get_nbActiveEvents() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000058
    public struct AKRESULT
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AKRESULT AK_NotImplemented;        // 0x0
        public static AKRESULT AK_Success;        // 0x0
        public static AKRESULT AK_Fail;        // 0x0
        public static AKRESULT AK_PartialSuccess;        // 0x0
        public static AKRESULT AK_NotCompatible;        // 0x0
        public static AKRESULT AK_AlreadyConnected;        // 0x0
        public static AKRESULT AK_InvalidFile;        // 0x0
        public static AKRESULT AK_AudioFileHeaderTooLarge;        // 0x0
        public static AKRESULT AK_MaxReached;        // 0x0
        public static AKRESULT AK_InvalidID;        // 0x0
        public static AKRESULT AK_IDNotFound;        // 0x0
        public static AKRESULT AK_InvalidInstanceID;        // 0x0
        public static AKRESULT AK_NoMoreData;        // 0x0
        public static AKRESULT AK_InvalidStateGroup;        // 0x0
        public static AKRESULT AK_ChildAlreadyHasAParent;        // 0x0
        public static AKRESULT AK_InvalidLanguage;        // 0x0
        public static AKRESULT AK_CannotAddItselfAsAChild;        // 0x0
        public static AKRESULT AK_InvalidParameter;        // 0x0
        public static AKRESULT AK_ElementAlreadyInList;        // 0x0
        public static AKRESULT AK_PathNotFound;        // 0x0
        public static AKRESULT AK_PathNoVertices;        // 0x0
        public static AKRESULT AK_PathNotRunning;        // 0x0
        public static AKRESULT AK_PathNotPaused;        // 0x0
        public static AKRESULT AK_PathNodeAlreadyInList;        // 0x0
        public static AKRESULT AK_PathNodeNotInList;        // 0x0
        public static AKRESULT AK_DataNeeded;        // 0x0
        public static AKRESULT AK_NoDataNeeded;        // 0x0
        public static AKRESULT AK_DataReady;        // 0x0
        public static AKRESULT AK_NoDataReady;        // 0x0
        public static AKRESULT AK_InsufficientMemory;        // 0x0
        public static AKRESULT AK_Cancelled;        // 0x0
        public static AKRESULT AK_UnknownBankID;        // 0x0
        public static AKRESULT AK_BankReadError;        // 0x0
        public static AKRESULT AK_InvalidSwitchType;        // 0x0
        public static AKRESULT AK_FormatNotReady;        // 0x0
        public static AKRESULT AK_WrongBankVersion;        // 0x0
        public static AKRESULT AK_FileNotFound;        // 0x0
        public static AKRESULT AK_DeviceNotReady;        // 0x0
        public static AKRESULT AK_BankAlreadyLoaded;        // 0x0
        public static AKRESULT AK_RenderedFX;        // 0x0
        public static AKRESULT AK_ProcessNeeded;        // 0x0
        public static AKRESULT AK_ProcessDone;        // 0x0
        public static AKRESULT AK_MemManagerNotInitialized;        // 0x0
        public static AKRESULT AK_StreamMgrNotInitialized;        // 0x0
        public static AKRESULT AK_SSEInstructionsNotSupported;        // 0x0
        public static AKRESULT AK_Busy;        // 0x0
        public static AKRESULT AK_UnsupportedChannelConfig;        // 0x0
        public static AKRESULT AK_PluginMediaNotAvailable;        // 0x0
        public static AKRESULT AK_MustBeVirtualized;        // 0x0
        public static AKRESULT AK_CommandTooLarge;        // 0x0
        public static AKRESULT AK_RejectedByFilter;        // 0x0
        public static AKRESULT AK_InvalidCustomPlatformName;        // 0x0
        public static AKRESULT AK_DLLCannotLoad;        // 0x0
        public static AKRESULT AK_DLLPathNotFound;        // 0x0
        public static AKRESULT AK_NoJavaVM;        // 0x0
        public static AKRESULT AK_OpenSLError;        // 0x0
        public static AKRESULT AK_PluginNotRegistered;        // 0x0
        public static AKRESULT AK_DataAlignmentError;        // 0x0
        public static AKRESULT AK_DeviceNotCompatible;        // 0x0
        public static AKRESULT AK_DuplicateUniqueID;        // 0x0
        public static AKRESULT AK_InitBankNotLoaded;        // 0x0
        public static AKRESULT AK_DeviceNotFound;        // 0x0
        public static AKRESULT AK_PlayingIDNotFound;        // 0x0
        public static AKRESULT AK_InvalidFloatValue;        // 0x0
        public static AKRESULT AK_FileFormatMismatch;        // 0x0
        public static AKRESULT AK_NoDistinctListener;        // 0x0
        public static AKRESULT AK_ACP_Error;        // 0x0
        public static AKRESULT AK_ResourceInUse;        // 0x0
        public static AKRESULT AK_InvalidBankType;        // 0x0
        public static AKRESULT AK_AlreadyInitialized;        // 0x0
        public static AKRESULT AK_NotInitialized;        // 0x0
        public static AKRESULT AK_FilePermissionError;        // 0x0
        public static AKRESULT AK_UnknownFileError;        // 0x0
        public static AKRESULT AK_TooManyConcurrentOperations;        // 0x0
        public static AKRESULT AK_InvalidFileSize;        // 0x0
        public static AKRESULT AK_Deferred;        // 0x0
        public static AKRESULT AK_FilePathTooLong;        // 0x0
        public static AKRESULT AK_InvalidState;        // 0x0

    }

    // TypeToken: 0x2000059
    public class AkRoomParams, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkRoomParams obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void set_Front(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_Front() { }
        private System.Void set_Up(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_Up() { }
        private System.Void set_ReverbAuxBus(System.UInt32 value) { }
        private System.UInt32 get_ReverbAuxBus() { }
        private System.Void set_ReverbLevel(System.Single value) { }
        private System.Single get_ReverbLevel() { }
        private System.Void set_TransmissionLoss(System.Single value) { }
        private System.Single get_TransmissionLoss() { }
        private System.Void set_RoomGameObj_AuxSendLevelToSelf(System.Single value) { }
        private System.Single get_RoomGameObj_AuxSendLevelToSelf() { }
        private System.Void set_RoomGameObj_KeepRegistered(System.Boolean value) { }
        private System.Boolean get_RoomGameObj_KeepRegistered() { }
        private System.Void set_RoomPriority(System.UInt32 value) { }
        private System.UInt32 get_RoomPriority() { }

    }

    // TypeToken: 0x200005A
    public class AkSegmentInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkSegmentInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_iCurrentPosition(System.Int32 value) { }
        private System.Int32 get_iCurrentPosition() { }
        private System.Void set_iPreEntryDuration(System.Int32 value) { }
        private System.Int32 get_iPreEntryDuration() { }
        private System.Void set_iActiveDuration(System.Int32 value) { }
        private System.Int32 get_iActiveDuration() { }
        private System.Void set_iPostExitDuration(System.Int32 value) { }
        private System.Int32 get_iPostExitDuration() { }
        private System.Void set_iRemainingLookAheadTime(System.Int32 value) { }
        private System.Int32 get_iRemainingLookAheadTime() { }
        private System.Void set_fBeatDuration(System.Single value) { }
        private System.Single get_fBeatDuration() { }
        private System.Void set_fBarDuration(System.Single value) { }
        private System.Single get_fBarDuration() { }
        private System.Void set_fGridDuration(System.Single value) { }
        private System.Single get_fGridDuration() { }
        private System.Void set_fGridOffset(System.Single value) { }
        private System.Single get_fGridOffset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005B
    public class AkSerializedCallbackHeader, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkSerializedCallbackHeader obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.IntPtr get_pPackage() { }
        private System.UInt32 get_eType() { }
        private System.IntPtr GetData() { }
        private AkSerializedCallbackHeader get_pNext() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public struct AkSetPositionFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkSetPositionFlags AkSetPositionFlags_Emitter;        // 0x0
        public static AkSetPositionFlags AkSetPositionFlags_Listener;        // 0x0
        public static AkSetPositionFlags AkSetPositionFlags_Default;        // 0x0

    }

    // TypeToken: 0x200005D
    public struct AkSourceChannelOrdering
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkSourceChannelOrdering SourceChannelOrdering_Standard;        // 0x0
        public static AkSourceChannelOrdering SourceChannelOrdering_Film;        // 0x0
        public static AkSourceChannelOrdering SourceChannelOrdering_FuMa;        // 0x0
        public static AkSourceChannelOrdering SourceChannelOrdering_Last;        // 0x0

    }

    // TypeToken: 0x200005E
    public class AkSourceSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkSourceSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_sourceID(System.UInt32 value) { }
        private System.UInt32 get_sourceID() { }
        private System.Void set_pMediaMemory(System.IntPtr value) { }
        private System.IntPtr get_pMediaMemory() { }
        private System.Void set_uMediaSize(System.UInt32 value) { }
        private System.UInt32 get_uMediaSize() { }
        private System.Void Clear() { }
        private System.Int32 GetSizeOf() { }
        private System.Void Clone(AkSourceSettings other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005F
    public class AkSpatialAudioInitSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkSpatialAudioInitSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void set_uMaxSoundPropagationDepth(System.UInt32 value) { }
        private System.UInt32 get_uMaxSoundPropagationDepth() { }
        private System.Void set_fMovementThreshold(System.Single value) { }
        private System.Single get_fMovementThreshold() { }
        private System.Void set_uNumberOfPrimaryRays(System.UInt32 value) { }
        private System.UInt32 get_uNumberOfPrimaryRays() { }
        private System.Void set_uMaxReflectionOrder(System.UInt32 value) { }
        private System.UInt32 get_uMaxReflectionOrder() { }
        private System.Void set_uMaxDiffractionOrder(System.UInt32 value) { }
        private System.UInt32 get_uMaxDiffractionOrder() { }
        private System.Void set_uMaxEmitterRoomAuxSends(System.UInt32 value) { }
        private System.UInt32 get_uMaxEmitterRoomAuxSends() { }
        private System.Void set_uDiffractionOnReflectionsOrder(System.UInt32 value) { }
        private System.UInt32 get_uDiffractionOnReflectionsOrder() { }
        private System.Void set_fMaxPathLength(System.Single value) { }
        private System.Single get_fMaxPathLength() { }
        private System.Void set_fCPULimitPercentage(System.Single value) { }
        private System.Single get_fCPULimitPercentage() { }
        private System.Void set_uLoadBalancingSpread(System.UInt32 value) { }
        private System.UInt32 get_uLoadBalancingSpread() { }
        private System.Void set_bEnableGeometricDiffractionAndTransmission(System.Boolean value) { }
        private System.Boolean get_bEnableGeometricDiffractionAndTransmission() { }
        private System.Void set_bCalcEmitterVirtualPosition(System.Boolean value) { }
        private System.Boolean get_bCalcEmitterVirtualPosition() { }

    }

    // TypeToken: 0x2000060
    public struct AkSpeakerPanningType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkSpeakerPanningType AK_DirectSpeakerAssignment;        // 0x0
        public static AkSpeakerPanningType AK_BalanceFadeHeight;        // 0x0
        public static AkSpeakerPanningType AK_SteeringPanner;        // 0x0

    }

    // TypeToken: 0x2000061
    public class AkStdMovePolicy, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkStdMovePolicy obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean IsTrivial() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000062
    public class AkStreamMgrSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkStreamMgrSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x2000063
    public class AkTransform, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkTransform obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private UnityEngine.Vector3 Position() { }
        private UnityEngine.Vector3 OrientationFront() { }
        private UnityEngine.Vector3 OrientationTop() { }
        private System.Void Set(UnityEngine.Vector3 in_position, UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop) { }
        private System.Void Set(System.Single in_positionX, System.Single in_positionY, System.Single in_positionZ, System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ) { }
        private System.Void SetPosition(UnityEngine.Vector3 in_position) { }
        private System.Void SetPosition(System.Single in_x, System.Single in_y, System.Single in_z) { }
        private System.Void SetOrientation(UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop) { }
        private System.Void SetOrientation(System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000064
    public class AkTriangle, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkTriangle obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.UInt16 in_pt0, System.UInt16 in_pt1, System.UInt16 in_pt2, System.UInt16 in_surfaceInfo) { }
        private System.Void set_point0(System.UInt16 value) { }
        private System.UInt16 get_point0() { }
        private System.Void set_point1(System.UInt16 value) { }
        private System.UInt16 get_point1() { }
        private System.Void set_point2(System.UInt16 value) { }
        private System.UInt16 get_point2() { }
        private System.Void set_surface(System.UInt16 value) { }
        private System.UInt16 get_surface() { }
        private System.Void Clear() { }
        private System.Int32 GetSizeOf() { }
        private System.Void Clone(AkTriangle other) { }

    }

    // TypeToken: 0x2000065
    public class AkTrivialStdMovePolicy, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkTrivialStdMovePolicy obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean IsTrivial() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000066
    public class AkWorldTransform, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkWorldTransform obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private AkVector64 Position() { }
        private UnityEngine.Vector3 OrientationFront() { }
        private UnityEngine.Vector3 OrientationTop() { }
        private System.Void Set(AkVector64 in_position, UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop) { }
        private System.Void Set(System.Double in_positionX, System.Double in_positionY, System.Double in_positionZ, System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ) { }
        private System.Void SetPosition(AkVector64 in_position) { }
        private System.Void SetPosition(System.Double in_x, System.Double in_y, System.Double in_z) { }
        private System.Void SetOrientation(UnityEngine.Vector3 in_orientationFront, UnityEngine.Vector3 in_orientationTop) { }
        private System.Void SetOrientation(System.Single in_orientFrontX, System.Single in_orientFrontY, System.Single in_orientFrontZ, System.Single in_orientTopX, System.Single in_orientTopY, System.Single in_orientTopZ) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000067
    public class MonitorErrorInfo, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(MonitorErrorInfo obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor(System.String in_name, System.String in_message) { }
        private System.Void .ctor(System.String in_name) { }
        private System.Void .ctor() { }
        private System.Void set_m_name(System.String value) { }
        private System.String get_m_name() { }
        private System.Void set_m_message(System.String value) { }
        private System.String get_m_message() { }

    }

    // TypeToken: 0x2000068
    public class MsgContext, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(MsgContext obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor(System.UInt32 pId, System.UInt64 goId, System.UInt32 nodeId, System.Boolean isBus) { }
        private System.Void .ctor(System.UInt32 pId, System.UInt64 goId, System.UInt32 nodeId) { }
        private System.Void .ctor(System.UInt32 pId, System.UInt64 goId) { }
        private System.Void .ctor(System.UInt32 pId) { }
        private System.Void .ctor() { }
        private System.Void set_in_playingID(System.UInt32 value) { }
        private System.UInt32 get_in_playingID() { }
        private System.Void set_in_gameObjID(System.UInt64 value) { }
        private System.UInt64 get_in_gameObjID() { }
        private System.Void set_in_soundID(System.UInt32 value) { }
        private System.UInt32 get_in_soundID() { }
        private System.Void set_in_bIsBus(System.Boolean value) { }
        private System.Boolean get_in_bIsBus() { }

    }

    // TypeToken: 0x200006A
    public struct AkCommSystem
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkCommunicationSettings.AkCommSystem AkCommSystem_Socket;        // 0x0
        public static AkCommunicationSettings.AkCommSystem AkCommSystem_HTCS;        // 0x0

    }

    // TypeToken: 0x2000069
    public class AkCommunicationSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkCommunicationSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void set_uPoolSize(System.UInt32 value) { }
        private System.UInt32 get_uPoolSize() { }
        private System.Void set_uDiscoveryBroadcastPort(System.UInt16 value) { }
        private System.UInt16 get_uDiscoveryBroadcastPort() { }
        private System.Void set_uCommandPort(System.UInt16 value) { }
        private System.UInt16 get_uCommandPort() { }
        private System.Void set_commSystem(AkCommunicationSettings.AkCommSystem value) { }
        private AkCommunicationSettings.AkCommSystem get_commSystem() { }
        private System.Void set_bInitSystemLib(System.Boolean value) { }
        private System.Boolean get_bInitSystemLib() { }
        private System.Void set_szAppNetworkName(System.String value) { }
        private System.String get_szAppNetworkName() { }

    }

    // TypeToken: 0x200006B
    public class AkPlatformInitSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkPlatformInitSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_threadLEngine(AkThreadProperties value) { }
        private AkThreadProperties get_threadLEngine() { }
        private System.Void set_threadOutputMgr(AkThreadProperties value) { }
        private AkThreadProperties get_threadOutputMgr() { }
        private System.Void set_threadBankManager(AkThreadProperties value) { }
        private AkThreadProperties get_threadBankManager() { }
        private System.Void set_threadMonitor(AkThreadProperties value) { }
        private AkThreadProperties get_threadMonitor() { }
        private System.Void set_uNumRefillsInVoice(System.UInt16 value) { }
        private System.UInt16 get_uNumRefillsInVoice() { }
        private System.Void set_uSampleRate(System.UInt32 value) { }
        private System.UInt32 get_uSampleRate() { }
        private System.Void set_bEnableAvxSupport(System.Boolean value) { }
        private System.Boolean get_bEnableAvxSupport() { }
        private System.Void set_uMaxSystemAudioObjects(System.UInt32 value) { }
        private System.UInt32 get_uMaxSystemAudioObjects() { }
        private System.Void set_bEnableDirectInputSupport(System.Boolean value) { }
        private System.Boolean get_bEnableDirectInputSupport() { }

    }

    // TypeToken: 0x200006C
    public class AkSoundEnginePINVOKE
    {
        // Methods
        private System.Void .cctor() { }
        private System.UInt32 CSharp_JoystickIdToWwiseId(System.UInt32 jarg1) { }
        private System.UInt32 CSharp_AK_INVALID_SHARE_SET_ID_get() { }
        private System.UInt32 CSharp_AK_INVALID_PIPELINE_ID_get() { }
        private System.UInt64 CSharp_AK_INVALID_AUDIO_OBJECT_ID_get() { }
        private System.UInt32 CSharp_AK_SOUNDBANK_VERSION_get() { }
        private System.UInt32 CSharp_AkJobType_Generic_get() { }
        private System.UInt32 CSharp_AkJobType_AudioProcessing_get() { }
        private System.UInt32 CSharp_AkJobType_SpatialAudio_get() { }
        private System.UInt32 CSharp_AK_NUM_JOB_TYPES_get() { }
        private System.Void CSharp_AkAudioSettings_uNumSamplesPerFrame_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkAudioSettings_uNumSamplesPerFrame_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAudioSettings_uNumSamplesPerSecond_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkAudioSettings_uNumSamplesPerSecond_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkAudioSettings() { }
        private System.Void CSharp_delete_AkAudioSettings(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceDescription_idDevice_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkDeviceDescription_idDevice_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceDescription_deviceName_set(System.IntPtr jarg1, System.String jarg2) { }
        private System.IntPtr CSharp_AkDeviceDescription_deviceName_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceDescription_deviceStateMask_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkDeviceDescription_deviceStateMask_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceDescription_isDefaultDevice_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkDeviceDescription_isDefaultDevice_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceDescription_Clear(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkDeviceDescription_GetSizeOf() { }
        private System.Void CSharp_AkDeviceDescription_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_new_AkDeviceDescription() { }
        private System.Void CSharp_delete_AkDeviceDescription(System.IntPtr jarg1) { }
        private AkVector64 CSharp_AkWorldTransform_Position(System.IntPtr jarg1) { }
        private UnityEngine.Vector3 CSharp_AkWorldTransform_OrientationFront(System.IntPtr jarg1) { }
        private UnityEngine.Vector3 CSharp_AkWorldTransform_OrientationTop(System.IntPtr jarg1) { }
        private System.Void CSharp_AkWorldTransform_Set__SWIG_0(System.IntPtr jarg1, AkVector64 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4) { }
        private System.Void CSharp_AkWorldTransform_Set__SWIG_1(System.IntPtr jarg1, System.Double jarg2, System.Double jarg3, System.Double jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7, System.Single jarg8, System.Single jarg9, System.Single jarg10) { }
        private System.Void CSharp_AkWorldTransform_SetPosition__SWIG_0(System.IntPtr jarg1, AkVector64 jarg2) { }
        private System.Void CSharp_AkWorldTransform_SetPosition__SWIG_1(System.IntPtr jarg1, System.Double jarg2, System.Double jarg3, System.Double jarg4) { }
        private System.Void CSharp_AkWorldTransform_SetOrientation__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3) { }
        private System.Void CSharp_AkWorldTransform_SetOrientation__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7) { }
        private System.IntPtr CSharp_new_AkWorldTransform() { }
        private System.Void CSharp_delete_AkWorldTransform(System.IntPtr jarg1) { }
        private UnityEngine.Vector3 CSharp_AkTransform_Position(System.IntPtr jarg1) { }
        private UnityEngine.Vector3 CSharp_AkTransform_OrientationFront(System.IntPtr jarg1) { }
        private UnityEngine.Vector3 CSharp_AkTransform_OrientationTop(System.IntPtr jarg1) { }
        private System.Void CSharp_AkTransform_Set__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4) { }
        private System.Void CSharp_AkTransform_Set__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7, System.Single jarg8, System.Single jarg9, System.Single jarg10) { }
        private System.Void CSharp_AkTransform_SetPosition__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2) { }
        private System.Void CSharp_AkTransform_SetPosition__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4) { }
        private System.Void CSharp_AkTransform_SetOrientation__SWIG_0(System.IntPtr jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3) { }
        private System.Void CSharp_AkTransform_SetOrientation__SWIG_1(System.IntPtr jarg1, System.Single jarg2, System.Single jarg3, System.Single jarg4, System.Single jarg5, System.Single jarg6, System.Single jarg7) { }
        private System.IntPtr CSharp_new_AkTransform() { }
        private System.Void CSharp_delete_AkTransform(System.IntPtr jarg1) { }
        private UnityEngine.Vector3 CSharp_ConvertAkVector64ToAkVector(AkVector64 jarg1) { }
        private System.IntPtr CSharp_ConvertAkWorldTransformToAkTransform(System.IntPtr jarg1) { }
        private AkVector64 CSharp_ConvertAkVectorToAkVector64(UnityEngine.Vector3 jarg1) { }
        private System.IntPtr CSharp_ConvertAkTransformToAkWorldTransform(System.IntPtr jarg1) { }
        private System.Void CSharp_AkObstructionOcclusionValues_occlusion_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkObstructionOcclusionValues_occlusion_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkObstructionOcclusionValues_obstruction_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkObstructionOcclusionValues_obstruction_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkObstructionOcclusionValues_Clear(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkObstructionOcclusionValues_GetSizeOf() { }
        private System.Void CSharp_AkObstructionOcclusionValues_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_new_AkObstructionOcclusionValues() { }
        private System.Void CSharp_delete_AkObstructionOcclusionValues(System.IntPtr jarg1) { }
        private System.Void CSharp_AkChannelEmitter_position_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkChannelEmitter_position_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkChannelEmitter_uInputChannels_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkChannelEmitter_uInputChannels_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkChannelEmitter_padding_set(System.IntPtr jarg1, System.String jarg2) { }
        private System.IntPtr CSharp_AkChannelEmitter_padding_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkChannelEmitter(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAuxSendValue_listenerID_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        private System.UInt64 CSharp_AkAuxSendValue_listenerID_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAuxSendValue_auxBusID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkAuxSendValue_auxBusID_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAuxSendValue_fControlValue_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkAuxSendValue_fControlValue_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAuxSendValue_Set(System.IntPtr jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Single jarg4) { }
        private System.Boolean CSharp_AkAuxSendValue_IsSame(System.IntPtr jarg1, System.UInt64 jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_AkAuxSendValue_GetSizeOf() { }
        private System.Void CSharp_delete_AkAuxSendValue(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkRamp__SWIG_0() { }
        private System.IntPtr CSharp_new_AkRamp__SWIG_1(System.Single jarg1, System.Single jarg2) { }
        private System.Void CSharp_AkRamp_fPrev_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkRamp_fPrev_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkRamp_fNext_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkRamp_fNext_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkRamp(System.IntPtr jarg1) { }
        private System.UInt16 CSharp_AK_INT_get() { }
        private System.UInt16 CSharp_AK_FLOAT_get() { }
        private System.Byte CSharp_AK_INTERLEAVED_get() { }
        private System.Byte CSharp_AK_NONINTERLEAVED_get() { }
        private System.UInt32 CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get() { }
        private System.UInt32 CSharp_AK_LE_NATIVE_SAMPLETYPE_get() { }
        private System.UInt32 CSharp_AK_LE_NATIVE_INTERLEAVE_get() { }
        private System.Void CSharp_AkAudioFormat_uSampleRate_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkAudioFormat_uSampleRate_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAudioFormat_channelConfig_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkAudioFormat_channelConfig_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAudioFormat_uBitsPerSample_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkAudioFormat_uBitsPerSample_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAudioFormat_uBlockAlign_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkAudioFormat_uBlockAlign_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAudioFormat_uTypeID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkAudioFormat_uTypeID_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAudioFormat_uInterleaveID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkAudioFormat_uInterleaveID_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkAudioFormat_GetNumChannels(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkAudioFormat_GetBitsPerSample(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkAudioFormat_GetBlockAlign(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkAudioFormat_GetTypeID(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkAudioFormat_GetInterleaveID(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAudioFormat_SetAll(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.UInt32 jarg4, System.UInt32 jarg5, System.UInt32 jarg6, System.UInt32 jarg7) { }
        private System.IntPtr CSharp_new_AkAudioFormat() { }
        private System.Void CSharp_delete_AkAudioFormat(System.IntPtr jarg1) { }
        private System.Boolean CSharp_IsBankCodecID(System.UInt32 jarg1) { }
        private System.IntPtr CSharp_new_Ak3dData() { }
        private System.Void CSharp_Ak3dData_xform_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_Ak3dData_xform_get(System.IntPtr jarg1) { }
        private System.Void CSharp_Ak3dData_spread_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_Ak3dData_spread_get(System.IntPtr jarg1) { }
        private System.Void CSharp_Ak3dData_focus_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_Ak3dData_focus_get(System.IntPtr jarg1) { }
        private System.Void CSharp_Ak3dData_uEmitterChannelMask_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_Ak3dData_uEmitterChannelMask_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_Ak3dData(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkBehavioralPositioningData() { }
        private System.Void CSharp_AkBehavioralPositioningData_center_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkBehavioralPositioningData_center_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkBehavioralPositioningData_panLR_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkBehavioralPositioningData_panLR_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkBehavioralPositioningData_panBF_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkBehavioralPositioningData_panBF_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkBehavioralPositioningData_panDU_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkBehavioralPositioningData_panDU_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkBehavioralPositioningData_panSpatMix_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkBehavioralPositioningData_panSpatMix_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkBehavioralPositioningData_spatMode_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkBehavioralPositioningData_spatMode_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkBehavioralPositioningData_panType_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkBehavioralPositioningData_panType_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkBehavioralPositioningData_enableHeightSpread_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkBehavioralPositioningData_enableHeightSpread_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkBehavioralPositioningData(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningData_threeD_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkPositioningData_threeD_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningData_behavioral_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkPositioningData_behavioral_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkPositioningData() { }
        private System.Void CSharp_delete_AkPositioningData(System.IntPtr jarg1) { }
        private System.Void CSharp_Ak3DAudioSinkCapabilities_channelConfig_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_Ak3DAudioSinkCapabilities_channelConfig_get(System.IntPtr jarg1) { }
        private System.Void CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_get(System.IntPtr jarg1) { }
        private System.Void CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_get(System.IntPtr jarg1) { }
        private System.Void CSharp_Ak3DAudioSinkCapabilities_bPassthrough_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_Ak3DAudioSinkCapabilities_bPassthrough_get(System.IntPtr jarg1) { }
        private System.Void CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_Ak3DAudioSinkCapabilities() { }
        private System.Void CSharp_delete_Ak3DAudioSinkCapabilities(System.IntPtr jarg1) { }
        private System.Void CSharp_AkIterator_pItem_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkIterator_pItem_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkIterator_NextIter(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkIterator_PrevIter(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkIterator_GetItem(System.IntPtr jarg1) { }
        private System.Boolean CSharp_AkIterator_IsEqualTo(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Boolean CSharp_AkIterator_IsDifferentFrom(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_new_AkIterator() { }
        private System.Void CSharp_delete_AkIterator(System.IntPtr jarg1) { }
        private System.Boolean CSharp_AkStdMovePolicy_IsTrivial() { }
        private System.IntPtr CSharp_new_AkStdMovePolicy() { }
        private System.Void CSharp_delete_AkStdMovePolicy(System.IntPtr jarg1) { }
        private System.Boolean CSharp_AkTrivialStdMovePolicy_IsTrivial() { }
        private System.IntPtr CSharp_new_AkTrivialStdMovePolicy() { }
        private System.Void CSharp_delete_AkTrivialStdMovePolicy(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkPlaylistItem__SWIG_0() { }
        private System.IntPtr CSharp_new_AkPlaylistItem__SWIG_1(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkPlaylistItem(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkPlaylistItem_Assign(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Boolean CSharp_AkPlaylistItem_IsEqualTo(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_AkPlaylistItem_SetExternalSources(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3) { }
        private System.Void CSharp_AkPlaylistItem_audioNodeID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkPlaylistItem_audioNodeID_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlaylistItem_msDelay_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkPlaylistItem_msDelay_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlaylistItem_pCustomInfo_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkPlaylistItem_pCustomInfo_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkPlaylistArray() { }
        private System.Void CSharp_delete_AkPlaylistArray(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkPlaylistArray_Begin(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkPlaylistArray_End(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkPlaylistArray_FindEx(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkPlaylistArray_Erase__SWIG_0(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Void CSharp_AkPlaylistArray_Erase__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.IntPtr CSharp_AkPlaylistArray_EraseSwap__SWIG_0(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Void CSharp_AkPlaylistArray_EraseSwap__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Boolean CSharp_AkPlaylistArray_IsGrowingAllowed(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkPlaylistArray_Reserve(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_AkPlaylistArray_ReserveExtra(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkPlaylistArray_Reserved(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlaylistArray_Term(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkPlaylistArray_Length(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkPlaylistArray_Data(System.IntPtr jarg1) { }
        private System.Boolean CSharp_AkPlaylistArray_IsEmpty(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkPlaylistArray_Exists(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_0(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_1(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkPlaylistArray_Last(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlaylistArray_RemoveLast(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkPlaylistArray_Remove(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_AkPlaylistArray_RemoveSwap(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Void CSharp_AkPlaylistArray_RemoveAll(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkPlaylistArray_ItemAtIndex(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.IntPtr CSharp_AkPlaylistArray_Insert__SWIG_0(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkPlaylistArray_Insert__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Boolean CSharp_AkPlaylistArray_GrowArray__SWIG_0(System.IntPtr jarg1) { }
        private System.Boolean CSharp_AkPlaylistArray_GrowArray__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Boolean CSharp_AkPlaylistArray_Resize(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Void CSharp_AkPlaylistArray_Transfer(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_AkPlaylistArray_Copy(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.IntPtr jarg4, System.UInt32 jarg5, System.IntPtr jarg6) { }
        private System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.IntPtr jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.IntPtr jarg4) { }
        private System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_AkPlaylist_Enqueue__SWIG_4(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.IntPtr CSharp_new_AkPlaylist() { }
        private System.Void CSharp_delete_AkPlaylist(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_DynamicSequenceOpen__SWIG_0(System.UInt64 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5) { }
        private System.UInt32 CSharp_DynamicSequenceOpen__SWIG_1(System.UInt64 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4) { }
        private System.UInt32 CSharp_DynamicSequenceOpen__SWIG_2(System.UInt64 jarg1) { }
        private System.Int32 CSharp_DynamicSequenceClose(System.UInt32 jarg1) { }
        private System.Int32 CSharp_DynamicSequencePlay__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_DynamicSequencePlay__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_DynamicSequencePlay__SWIG_2(System.UInt32 jarg1) { }
        private System.Int32 CSharp_DynamicSequencePause__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_DynamicSequencePause__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_DynamicSequencePause__SWIG_2(System.UInt32 jarg1) { }
        private System.Int32 CSharp_DynamicSequenceResume__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_DynamicSequenceResume__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_DynamicSequenceResume__SWIG_2(System.UInt32 jarg1) { }
        private System.Int32 CSharp_DynamicSequenceStop__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_DynamicSequenceStop__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_DynamicSequenceStop__SWIG_2(System.UInt32 jarg1) { }
        private System.Int32 CSharp_DynamicSequenceBreak(System.UInt32 jarg1) { }
        private System.Int32 CSharp_Seek__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Boolean jarg3) { }
        private System.Int32 CSharp_Seek__SWIG_1(System.UInt32 jarg1, System.Single jarg2, System.Boolean jarg3) { }
        private System.Int32 CSharp_DynamicSequenceGetPauseTimes(System.UInt32 jarg1, System.UInt32& jarg2, System.UInt32& jarg3) { }
        private System.IntPtr CSharp_DynamicSequenceLockPlaylist(System.UInt32 jarg1) { }
        private System.Int32 CSharp_DynamicSequenceUnlockPlaylist(System.UInt32 jarg1) { }
        private System.IntPtr CSharp_new_AkOutputSettings__SWIG_0() { }
        private System.IntPtr CSharp_new_AkOutputSettings__SWIG_1(System.String jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.Int32 jarg4) { }
        private System.IntPtr CSharp_new_AkOutputSettings__SWIG_2(System.String jarg1, System.UInt32 jarg2, System.IntPtr jarg3) { }
        private System.IntPtr CSharp_new_AkOutputSettings__SWIG_3(System.String jarg1, System.UInt32 jarg2) { }
        private System.IntPtr CSharp_new_AkOutputSettings__SWIG_4(System.String jarg1) { }
        private System.Void CSharp_AkOutputSettings_audioDeviceShareset_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkOutputSettings_audioDeviceShareset_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkOutputSettings_idDevice_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkOutputSettings_idDevice_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkOutputSettings_ePanningRule_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkOutputSettings_ePanningRule_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkOutputSettings_channelConfig_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkOutputSettings_channelConfig_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkOutputSettings(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_uMaxNumPaths_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkInitSettings_uMaxNumPaths_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_uCommandQueueSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkInitSettings_uCommandQueueSize_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_bEnableGameSyncPreparation_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkInitSettings_bEnableGameSyncPreparation_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_uNumSamplesPerFrame_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkInitSettings_uNumSamplesPerFrame_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_uMonitorQueuePoolSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkInitSettings_uMonitorQueuePoolSize_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_settingsMainOutput_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkInitSettings_settingsMainOutput_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_bUseSoundBankMgrThread_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkInitSettings_bUseSoundBankMgrThread_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_bUseLEngineThread_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkInitSettings_bUseLEngineThread_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_szPluginDLLPath_set(System.IntPtr jarg1, System.String jarg2) { }
        private System.IntPtr CSharp_AkInitSettings_szPluginDLLPath_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_eFloorPlane_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkInitSettings_eFloorPlane_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_fGameUnitsToMeters_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkInitSettings_fGameUnitsToMeters_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_uBankReadBufferSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkInitSettings_uBankReadBufferSize_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_fDebugOutOfRangeLimit_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkInitSettings_fDebugOutOfRangeLimit_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkInitSettings(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSourceSettings_sourceID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkSourceSettings_sourceID_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSourceSettings_pMediaMemory_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkSourceSettings_pMediaMemory_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSourceSettings_uMediaSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkSourceSettings_uMediaSize_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSourceSettings_Clear(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkSourceSettings_GetSizeOf() { }
        private System.Void CSharp_AkSourceSettings_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_new_AkSourceSettings() { }
        private System.Void CSharp_delete_AkSourceSettings(System.IntPtr jarg1) { }
        private System.Boolean CSharp_IsInitialized() { }
        private System.Int32 CSharp_GetAudioSettings(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_GetSpeakerConfiguration__SWIG_0(System.UInt64 jarg1) { }
        private System.IntPtr CSharp_GetSpeakerConfiguration__SWIG_1() { }
        private System.Int32 CSharp_GetOutputDeviceConfiguration(System.UInt64 jarg1, System.IntPtr jarg2, System.IntPtr jarg3) { }
        private System.Int32 CSharp_GetPanningRule__SWIG_0(System.Int32& jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_GetPanningRule__SWIG_1(System.Int32& jarg1) { }
        private System.Int32 CSharp_SetPanningRule__SWIG_0(System.Int32 jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_SetPanningRule__SWIG_1(System.Int32 jarg1) { }
        private System.Int32 CSharp_GetSpeakerAngles__SWIG_0(System.Single[] jarg1, System.UInt32& jarg2, System.Single& jarg3, System.UInt64 jarg4) { }
        private System.Int32 CSharp_GetSpeakerAngles__SWIG_1(System.Single[] jarg1, System.UInt32& jarg2, System.Single& jarg3) { }
        private System.Int32 CSharp_SetSpeakerAngles__SWIG_0(System.Single[] jarg1, System.UInt32 jarg2, System.Single jarg3, System.UInt64 jarg4) { }
        private System.Int32 CSharp_SetSpeakerAngles__SWIG_1(System.Single[] jarg1, System.UInt32 jarg2, System.Single jarg3) { }
        private System.Int32 CSharp_SetVolumeThreshold(System.Single jarg1) { }
        private System.Int32 CSharp_SetMaxNumVoicesLimit(System.UInt16 jarg1) { }
        private System.Int32 CSharp_SetJobMgrMaxActiveWorkers(System.UInt32 jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_RenderAudio__SWIG_0(System.Boolean jarg1) { }
        private System.Int32 CSharp_RenderAudio__SWIG_1() { }
        private System.Int32 CSharp_RegisterPluginDLL__SWIG_0(System.String jarg1, System.String jarg2) { }
        private System.Int32 CSharp_RegisterPluginDLL__SWIG_1(System.String jarg1) { }
        private System.Boolean CSharp_IsPluginRegistered(System.Int32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        private System.UInt32 CSharp_GetIDFromString__SWIG_0(System.String jarg1) { }
        private System.UInt32 CSharp_PostEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.UInt32 jarg8) { }
        private System.UInt32 CSharp_PostEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7) { }
        private System.UInt32 CSharp_PostEvent__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5) { }
        private System.UInt32 CSharp_PostEvent__SWIG_3(System.UInt32 jarg1, System.UInt64 jarg2) { }
        private System.UInt32 CSharp_PostEvent__SWIG_4(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.UInt32 jarg8) { }
        private System.UInt32 CSharp_PostEvent__SWIG_5(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.UInt32 jarg6, System.IntPtr jarg7) { }
        private System.UInt32 CSharp_PostEvent__SWIG_6(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5) { }
        private System.UInt32 CSharp_PostEvent__SWIG_7(System.String jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_ExecuteActionOnEvent__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.UInt32 jarg6) { }
        private System.Int32 CSharp_ExecuteActionOnEvent__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        private System.Int32 CSharp_ExecuteActionOnEvent__SWIG_2(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_ExecuteActionOnEvent__SWIG_3(System.UInt32 jarg1, System.Int32 jarg2, System.UInt64 jarg3) { }
        private System.Int32 CSharp_ExecuteActionOnEvent__SWIG_4(System.UInt32 jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_ExecuteActionOnEvent__SWIG_5(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.UInt32 jarg6) { }
        private System.Int32 CSharp_ExecuteActionOnEvent__SWIG_6(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        private System.Int32 CSharp_ExecuteActionOnEvent__SWIG_7(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_ExecuteActionOnEvent__SWIG_8(System.String jarg1, System.Int32 jarg2, System.UInt64 jarg3) { }
        private System.Int32 CSharp_ExecuteActionOnEvent__SWIG_9(System.String jarg1, System.Int32 jarg2) { }
        private System.UInt32 CSharp_PostMIDIOnEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8, System.UInt32 jarg9) { }
        private System.UInt32 CSharp_PostMIDIOnEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8) { }
        private System.UInt32 CSharp_PostMIDIOnEvent__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4, System.Boolean jarg5) { }
        private System.UInt32 CSharp_PostMIDIOnEvent__SWIG_3(System.UInt32 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt16 jarg4) { }
        private System.Int32 CSharp_StopMIDIOnEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_StopMIDIOnEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_StopMIDIOnEvent__SWIG_2(System.UInt32 jarg1) { }
        private System.Int32 CSharp_StopMIDIOnEvent__SWIG_3() { }
        private System.Int32 CSharp_PinEventInStreamCache__SWIG_0(System.UInt32 jarg1, System.SByte jarg2, System.SByte jarg3) { }
        private System.Int32 CSharp_PinEventInStreamCache__SWIG_1(System.String jarg1, System.SByte jarg2, System.SByte jarg3) { }
        private System.Int32 CSharp_UnpinEventInStreamCache__SWIG_0(System.UInt32 jarg1) { }
        private System.Int32 CSharp_UnpinEventInStreamCache__SWIG_1(System.String jarg1) { }
        private System.Int32 CSharp_GetBufferStatusForPinnedEvent__SWIG_0(System.UInt32 jarg1, System.Single& jarg2, System.Int32& jarg3) { }
        private System.Int32 CSharp_GetBufferStatusForPinnedEvent__SWIG_1(System.String jarg1, System.Single& jarg2, System.Int32& jarg3) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_3(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_4(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Boolean jarg4) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_5(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_9(System.UInt32 jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_10(System.UInt32 jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_11(System.UInt32 jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_12(System.String jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_13(System.String jarg1, System.UInt64 jarg2, System.Single jarg3, System.Boolean jarg4) { }
        private System.Int32 CSharp_SeekOnEvent__SWIG_14(System.String jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        private System.Void CSharp_CancelEventCallbackCookie(System.IntPtr jarg1) { }
        private System.Void CSharp_CancelEventCallbackGameObject(System.UInt64 jarg1) { }
        private System.Void CSharp_CancelEventCallback(System.UInt32 jarg1) { }
        private System.Int32 CSharp_GetSourcePlayPosition__SWIG_0(System.UInt32 jarg1, System.Int32& jarg2, System.Boolean jarg3) { }
        private System.Int32 CSharp_GetSourcePlayPosition__SWIG_1(System.UInt32 jarg1, System.Int32& jarg2) { }
        private System.Int32 CSharp_GetSourceStreamBuffering(System.UInt32 jarg1, System.Int32& jarg2, System.Int32& jarg3) { }
        private System.Void CSharp_StopAll__SWIG_0(System.UInt64 jarg1) { }
        private System.Void CSharp_StopAll__SWIG_1() { }
        private System.Void CSharp_StopPlayingID__SWIG_0(System.UInt32 jarg1, System.Int32 jarg2, System.Int32 jarg3) { }
        private System.Void CSharp_StopPlayingID__SWIG_1(System.UInt32 jarg1, System.Int32 jarg2) { }
        private System.Void CSharp_StopPlayingID__SWIG_2(System.UInt32 jarg1) { }
        private System.Void CSharp_ExecuteActionOnPlayingID__SWIG_0(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4) { }
        private System.Void CSharp_ExecuteActionOnPlayingID__SWIG_1(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3) { }
        private System.Void CSharp_ExecuteActionOnPlayingID__SWIG_2(System.Int32 jarg1, System.UInt32 jarg2) { }
        private System.Void CSharp_SetRandomSeed(System.UInt32 jarg1) { }
        private System.Void CSharp_MuteBackgroundMusic(System.Boolean jarg1) { }
        private System.Boolean CSharp_GetBackgroundMusicMute() { }
        private System.Int32 CSharp_SendPluginCustomGameData(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.UInt32 jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.UInt32 jarg7) { }
        private System.Int32 CSharp_UnregisterAllGameObj() { }
        private System.Int32 CSharp_SetMultiplePositions__SWIG_0(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        private System.Int32 CSharp_SetMultiplePositions__SWIG_1(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_SetMultiplePositions__SWIG_2(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3) { }
        private System.Int32 CSharp_SetMultiplePositions__SWIG_3(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        private System.Int32 CSharp_SetMultiplePositions__SWIG_4(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_SetMultiplePositions__SWIG_5(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt16 jarg3) { }
        private System.Int32 CSharp_SetScalingFactor(System.UInt64 jarg1, System.Single jarg2) { }
        private System.Int32 CSharp_SetDistanceProbe(System.UInt64 jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_ClearBanks() { }
        private System.Int32 CSharp_SetBankLoadIOSettings(System.Single jarg1, System.SByte jarg2) { }
        private System.Int32 CSharp_LoadBank__SWIG_0(System.String jarg1, System.UInt32& jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_LoadBank__SWIG_1(System.String jarg1, System.UInt32& jarg2) { }
        private System.Int32 CSharp_LoadBank__SWIG_4(System.UInt32 jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_LoadBank__SWIG_5(System.UInt32 jarg1) { }
        private System.Int32 CSharp_LoadBankMemoryView__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3) { }
        private System.Int32 CSharp_LoadBankMemoryView__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3, System.UInt32& jarg4) { }
        private System.Int32 CSharp_LoadBankMemoryCopy__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3) { }
        private System.Int32 CSharp_LoadBankMemoryCopy__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32& jarg3, System.UInt32& jarg4) { }
        private System.Int32 CSharp_LoadBank__SWIG_6(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.UInt32& jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_LoadBank__SWIG_7(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.UInt32& jarg4) { }
        private System.Int32 CSharp_LoadBank__SWIG_10(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.UInt32 jarg4) { }
        private System.Int32 CSharp_LoadBank__SWIG_11(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3) { }
        private System.Int32 CSharp_LoadBankMemoryView__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5) { }
        private System.Int32 CSharp_LoadBankMemoryView__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5, System.UInt32& jarg6) { }
        private System.Int32 CSharp_LoadBankMemoryCopy__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5) { }
        private System.Int32 CSharp_LoadBankMemoryCopy__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32& jarg5, System.UInt32& jarg6) { }
        private System.Int32 CSharp_UnloadBank__SWIG_0(System.String jarg1, System.IntPtr jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_UnloadBank__SWIG_1(System.String jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_UnloadBank__SWIG_4(System.UInt32 jarg1, System.IntPtr jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_UnloadBank__SWIG_5(System.UInt32 jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_UnloadBank__SWIG_6(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_UnloadBank__SWIG_7(System.String jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4) { }
        private System.Int32 CSharp_UnloadBank__SWIG_10(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_UnloadBank__SWIG_11(System.UInt32 jarg1, System.IntPtr jarg2, System.IntPtr jarg3, System.IntPtr jarg4) { }
        private System.Void CSharp_CancelBankCallbackCookie(System.IntPtr jarg1) { }
        private System.Int32 CSharp_PrepareBank__SWIG_0(System.Int32 jarg1, System.String jarg2, System.Int32 jarg3, System.UInt32 jarg4) { }
        private System.Int32 CSharp_PrepareBank__SWIG_1(System.Int32 jarg1, System.String jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_PrepareBank__SWIG_2(System.Int32 jarg1, System.String jarg2) { }
        private System.Int32 CSharp_PrepareBank__SWIG_6(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.UInt32 jarg4) { }
        private System.Int32 CSharp_PrepareBank__SWIG_7(System.Int32 jarg1, System.UInt32 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_PrepareBank__SWIG_8(System.Int32 jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_PrepareBank__SWIG_9(System.Int32 jarg1, System.String jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5, System.UInt32 jarg6) { }
        private System.Int32 CSharp_PrepareBank__SWIG_10(System.Int32 jarg1, System.String jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5) { }
        private System.Int32 CSharp_PrepareBank__SWIG_11(System.Int32 jarg1, System.String jarg2, System.IntPtr jarg3, System.IntPtr jarg4) { }
        private System.Int32 CSharp_PrepareBank__SWIG_15(System.Int32 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5, System.UInt32 jarg6) { }
        private System.Int32 CSharp_PrepareBank__SWIG_16(System.Int32 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4, System.Int32 jarg5) { }
        private System.Int32 CSharp_PrepareBank__SWIG_17(System.Int32 jarg1, System.UInt32 jarg2, System.IntPtr jarg3, System.IntPtr jarg4) { }
        private System.Int32 CSharp_ClearPreparedEvents() { }
        private System.Int32 CSharp_PrepareEvent__SWIG_0(System.Int32 jarg1, System.IntPtr jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_PrepareEvent__SWIG_1(System.Int32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_PrepareEvent__SWIG_2(System.Int32 jarg1, System.IntPtr jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5) { }
        private System.Int32 CSharp_PrepareEvent__SWIG_3(System.Int32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3, System.IntPtr jarg4, System.IntPtr jarg5) { }
        private System.Int32 CSharp_SetMedia(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_UnsetMedia(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_PrepareGameSyncs__SWIG_0(System.Int32 jarg1, System.Int32 jarg2, System.String jarg3, System.IntPtr jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_PrepareGameSyncs__SWIG_1(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt32[] jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_PrepareGameSyncs__SWIG_2(System.Int32 jarg1, System.Int32 jarg2, System.String jarg3, System.IntPtr jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.IntPtr jarg7) { }
        private System.Int32 CSharp_PrepareGameSyncs__SWIG_3(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt32[] jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.IntPtr jarg7) { }
        private System.Int32 CSharp_AddListener(System.UInt64 jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_RemoveListener(System.UInt64 jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_AddDefaultListener(System.UInt64 jarg1) { }
        private System.Int32 CSharp_RemoveDefaultListener(System.UInt64 jarg1) { }
        private System.Int32 CSharp_ResetListenersToDefault(System.UInt64 jarg1) { }
        private System.Int32 CSharp_SetListenerSpatialization__SWIG_0(System.UInt64 jarg1, System.Boolean jarg2, System.IntPtr jarg3, System.Single[] jarg4) { }
        private System.Int32 CSharp_SetListenerSpatialization__SWIG_1(System.UInt64 jarg1, System.Boolean jarg2, System.IntPtr jarg3) { }
        private System.Int32 CSharp_SetRTPCValue__SWIG_0(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6) { }
        private System.Int32 CSharp_SetRTPCValue__SWIG_1(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        private System.Int32 CSharp_SetRTPCValue__SWIG_2(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_SetRTPCValue__SWIG_3(System.UInt32 jarg1, System.Single jarg2, System.UInt64 jarg3) { }
        private System.Int32 CSharp_SetRTPCValue__SWIG_4(System.UInt32 jarg1, System.Single jarg2) { }
        private System.Int32 CSharp_SetRTPCValue__SWIG_5(System.String jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6) { }
        private System.Int32 CSharp_SetRTPCValue__SWIG_6(System.String jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        private System.Int32 CSharp_SetRTPCValue__SWIG_7(System.String jarg1, System.Single jarg2, System.UInt64 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_SetRTPCValue__SWIG_8(System.String jarg1, System.Single jarg2, System.UInt64 jarg3) { }
        private System.Int32 CSharp_SetRTPCValue__SWIG_9(System.String jarg1, System.Single jarg2) { }
        private System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_0(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6) { }
        private System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_1(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        private System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_2(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_3(System.UInt32 jarg1, System.Single jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_4(System.String jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5, System.Boolean jarg6) { }
        private System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_5(System.String jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4, System.Int32 jarg5) { }
        private System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_6(System.String jarg1, System.Single jarg2, System.UInt32 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_SetRTPCValueByPlayingID__SWIG_7(System.String jarg1, System.Single jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_ResetRTPCValue__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5) { }
        private System.Int32 CSharp_ResetRTPCValue__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_ResetRTPCValue__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_ResetRTPCValue__SWIG_3(System.UInt32 jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_ResetRTPCValue__SWIG_4(System.UInt32 jarg1) { }
        private System.Int32 CSharp_ResetRTPCValue__SWIG_5(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5) { }
        private System.Int32 CSharp_ResetRTPCValue__SWIG_6(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_ResetRTPCValue__SWIG_7(System.String jarg1, System.UInt64 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_ResetRTPCValue__SWIG_8(System.String jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_ResetRTPCValue__SWIG_9(System.String jarg1) { }
        private System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5) { }
        private System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_2(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_3(System.UInt32 jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_4(System.String jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4, System.Boolean jarg5) { }
        private System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_5(System.String jarg1, System.UInt32 jarg2, System.Int32 jarg3, System.Int32 jarg4) { }
        private System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_6(System.String jarg1, System.UInt32 jarg2, System.Int32 jarg3) { }
        private System.Int32 CSharp_ResetRTPCValueByPlayingID__SWIG_7(System.String jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_SetSwitch__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt64 jarg3) { }
        private System.Int32 CSharp_SetSwitch__SWIG_1(System.String jarg1, System.String jarg2, System.UInt64 jarg3) { }
        private System.Int32 CSharp_PostTrigger__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_PostTrigger__SWIG_1(System.String jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_SetState__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_SetState__SWIG_1(System.String jarg1, System.String jarg2) { }
        private System.Int32 CSharp_SetGameObjectAuxSendValues(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_SetGameObjectOutputBusVolume(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        private System.Int32 CSharp_SetActorMixerEffect(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_SetBusEffect__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_SetBusEffect__SWIG_1(System.String jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_SetOutputDeviceEffect(System.UInt64 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_SetMixer__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_SetMixer__SWIG_1(System.String jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_SetBusConfig__SWIG_0(System.UInt32 jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_SetBusConfig__SWIG_1(System.String jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_SetObjectObstructionAndOcclusion(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3, System.Single jarg4) { }
        private System.Int32 CSharp_SetMultipleObstructionAndOcclusion(System.UInt64 jarg1, System.UInt64 jarg2, System.IntPtr jarg3, System.UInt32 jarg4) { }
        private System.Int32 CSharp_StartOutputCapture(System.String jarg1) { }
        private System.Int32 CSharp_StopOutputCapture() { }
        private System.Int32 CSharp_AddOutputCaptureMarker(System.String jarg1) { }
        private System.Int32 CSharp_AddOutputCaptureBinaryMarker(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_GetSampleRate() { }
        private System.Int32 CSharp_StartProfilerCapture(System.String jarg1) { }
        private System.Int32 CSharp_StopProfilerCapture() { }
        private System.Int32 CSharp_SetOfflineRenderingFrameTime(System.Single jarg1) { }
        private System.Int32 CSharp_SetOfflineRendering(System.Boolean jarg1) { }
        private System.Int32 CSharp_RemoveOutput(System.UInt64 jarg1) { }
        private System.Int32 CSharp_ReplaceOutput__SWIG_0(System.IntPtr jarg1, System.UInt64 jarg2, System.UInt64& jarg3) { }
        private System.Int32 CSharp_ReplaceOutput__SWIG_1(System.IntPtr jarg1, System.UInt64 jarg2) { }
        private System.UInt64 CSharp_GetOutputID__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2) { }
        private System.UInt64 CSharp_GetOutputID__SWIG_1(System.String jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_SetBusDevice__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_SetBusDevice__SWIG_1(System.String jarg1, System.String jarg2) { }
        private System.Int32 CSharp_GetDeviceList__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32& jarg3, System.IntPtr jarg4) { }
        private System.Int32 CSharp_GetDeviceList__SWIG_1(System.UInt32 jarg1, System.UInt32& jarg2, System.IntPtr jarg3) { }
        private System.Int32 CSharp_SetOutputVolume(System.UInt64 jarg1, System.Single jarg2) { }
        private System.Int32 CSharp_GetDeviceSpatialAudioSupport(System.UInt32 jarg1) { }
        private System.Int32 CSharp_Suspend__SWIG_0(System.Boolean jarg1, System.Boolean jarg2) { }
        private System.Int32 CSharp_Suspend__SWIG_1(System.Boolean jarg1) { }
        private System.Int32 CSharp_Suspend__SWIG_2() { }
        private System.Int32 CSharp_WakeupFromSuspend__SWIG_0(System.UInt32 jarg1) { }
        private System.Int32 CSharp_WakeupFromSuspend__SWIG_1() { }
        private System.UInt32 CSharp_GetBufferTick() { }
        private System.UInt64 CSharp_GetSampleTick() { }
        private System.Void CSharp_AkSegmentInfo_iCurrentPosition_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkSegmentInfo_iCurrentPosition_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSegmentInfo_iPreEntryDuration_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkSegmentInfo_iPreEntryDuration_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSegmentInfo_iActiveDuration_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkSegmentInfo_iActiveDuration_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSegmentInfo_iPostExitDuration_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkSegmentInfo_iPostExitDuration_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSegmentInfo_fBeatDuration_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkSegmentInfo_fBeatDuration_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSegmentInfo_fBarDuration_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkSegmentInfo_fBarDuration_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSegmentInfo_fGridDuration_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkSegmentInfo_fGridDuration_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSegmentInfo_fGridOffset_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkSegmentInfo_fGridOffset_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkSegmentInfo() { }
        private System.Void CSharp_delete_AkSegmentInfo(System.IntPtr jarg1) { }
        private System.Void CSharp_AkResourceMonitorDataSummary_totalCPU_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkResourceMonitorDataSummary_totalCPU_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkResourceMonitorDataSummary_pluginCPU_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkResourceMonitorDataSummary_pluginCPU_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkResourceMonitorDataSummary_physicalVoices_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkResourceMonitorDataSummary_physicalVoices_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkResourceMonitorDataSummary_virtualVoices_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkResourceMonitorDataSummary_virtualVoices_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkResourceMonitorDataSummary_totalVoices_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkResourceMonitorDataSummary_totalVoices_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkResourceMonitorDataSummary_nbActiveEvents_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkResourceMonitorDataSummary_nbActiveEvents_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkResourceMonitorDataSummary() { }
        private System.Void CSharp_delete_AkResourceMonitorDataSummary(System.IntPtr jarg1) { }
        private System.Byte CSharp_AK_INVALID_MIDI_CHANNEL_get() { }
        private System.Byte CSharp_AK_INVALID_MIDI_NOTE_get() { }
        private System.Void CSharp_AkMIDIEvent_byChan_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_byChan_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tGen_byParam1_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tGen_byParam1_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tGen_byParam2_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tGen_byParam2_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMIDIEvent_tGen() { }
        private System.Void CSharp_delete_AkMIDIEvent_tGen(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMIDIEvent_tNoteOnOff() { }
        private System.Void CSharp_delete_AkMIDIEvent_tNoteOnOff(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tCc_byCc_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tCc_byCc_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tCc_byValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tCc_byValue_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMIDIEvent_tCc() { }
        private System.Void CSharp_delete_AkMIDIEvent_tCc(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMIDIEvent_tPitchBend() { }
        private System.Void CSharp_delete_AkMIDIEvent_tPitchBend(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMIDIEvent_tNoteAftertouch() { }
        private System.Void CSharp_delete_AkMIDIEvent_tNoteAftertouch(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMIDIEvent_tChanAftertouch() { }
        private System.Void CSharp_delete_AkMIDIEvent_tChanAftertouch(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMIDIEvent_tProgramChange() { }
        private System.Void CSharp_delete_AkMIDIEvent_tProgramChange(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tWwiseCmd_uCmd_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        private System.UInt16 CSharp_AkMIDIEvent_tWwiseCmd_uCmd_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_tWwiseCmd_uArg_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkMIDIEvent_tWwiseCmd_uArg_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMIDIEvent_tWwiseCmd() { }
        private System.Void CSharp_delete_AkMIDIEvent_tWwiseCmd(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_Gen_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkMIDIEvent_Gen_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_Cc_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkMIDIEvent_Cc_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_NoteOnOff_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkMIDIEvent_NoteOnOff_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_PitchBend_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkMIDIEvent_PitchBend_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_NoteAftertouch_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkMIDIEvent_NoteAftertouch_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_ChanAftertouch_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkMIDIEvent_ChanAftertouch_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_ProgramChange_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkMIDIEvent_ProgramChange_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_WwiseCmd_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkMIDIEvent_WwiseCmd_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_byType_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkMIDIEvent_byType_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_byOnOffNote_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_byOnOffNote_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_byVelocity_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_byVelocity_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_byCc_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkMIDIEvent_byCc_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_byCcValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_byCcValue_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_byValueLsb_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_byValueLsb_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_byValueMsb_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_byValueMsb_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_byAftertouchNote_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_byAftertouchNote_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_byNoteAftertouchValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_byNoteAftertouchValue_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_byChanAftertouchValue_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_byChanAftertouchValue_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_byProgramNum_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkMIDIEvent_byProgramNum_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_uCmd_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        private System.UInt16 CSharp_AkMIDIEvent_uCmd_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIEvent_uArg_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkMIDIEvent_uArg_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMIDIEvent() { }
        private System.Void CSharp_delete_AkMIDIEvent(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMIDIPost_uOffset_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        private System.UInt64 CSharp_AkMIDIPost_uOffset_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_0(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4) { }
        private System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4, System.Boolean jarg5) { }
        private System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_2(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8) { }
        private System.UInt32 CSharp_AkMIDIPost_PostOnEvent__SWIG_3(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt64 jarg3, System.UInt32 jarg4, System.Boolean jarg5, System.UInt32 jarg6, System.IntPtr jarg7, System.IntPtr jarg8, System.UInt32 jarg9) { }
        private System.Void CSharp_AkMIDIPost_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_AkMIDIPost_GetSizeOf() { }
        private System.IntPtr CSharp_new_AkMIDIPost() { }
        private System.Void CSharp_delete_AkMIDIPost(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMemCategroyStats_uUsed_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        private System.UInt64 CSharp_AkMemCategroyStats_uUsed_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMemCategroyStats_uPeakUsed_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        private System.UInt64 CSharp_AkMemCategroyStats_uPeakUsed_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMemCategroyStats_uAllocs_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkMemCategroyStats_uAllocs_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMemCategroyStats_uFrees_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkMemCategroyStats_uFrees_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMemCategroyStats() { }
        private System.Void CSharp_delete_AkMemCategroyStats(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMemGlobalStats_uUsed_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        private System.UInt64 CSharp_AkMemGlobalStats_uUsed_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMemGlobalStats_uDeviceUsed_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        private System.UInt64 CSharp_AkMemGlobalStats_uDeviceUsed_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMemGlobalStats_uReserved_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        private System.UInt64 CSharp_AkMemGlobalStats_uReserved_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMemGlobalStats_uMax_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        private System.UInt64 CSharp_AkMemGlobalStats_uMax_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMemGlobalStats() { }
        private System.Void CSharp_delete_AkMemGlobalStats(System.IntPtr jarg1) { }
        private System.Void CSharp_AkMemGetCategoryStats(System.Int32 jarg1, System.IntPtr jarg2) { }
        private System.Void CSharp_AkMemGetGlobalStats(System.IntPtr jarg1) { }
        private System.Void CSharp_StartProfileThreadUsage() { }
        private System.UInt64 CSharp_StopProfileThreadUsage() { }
        private System.Void CSharp_DumpToFile(System.String jarg1) { }
        private System.UInt64 CSharp_GetGlobalUsed() { }
        private System.UInt64 CSharp_GetGlobalReserved() { }
        private System.Void CSharp_AkMusicSettings_fStreamingLookAheadRatio_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkMusicSettings_fStreamingLookAheadRatio_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkMusicSettings(System.IntPtr jarg1) { }
        private System.Int32 CSharp_GetPlayingSegmentInfo__SWIG_0(System.UInt32 jarg1, System.IntPtr jarg2, System.Boolean jarg3) { }
        private System.Int32 CSharp_GetPlayingSegmentInfo__SWIG_1(System.UInt32 jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkSerializedCallbackHeader_pPackage_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkSerializedCallbackHeader_eType_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkSerializedCallbackHeader_GetData(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkSerializedCallbackHeader_pNext_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkSerializedCallbackHeader() { }
        private System.Void CSharp_delete_AkSerializedCallbackHeader(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkCallbackInfo_pCookie_get(System.IntPtr jarg1) { }
        private System.UInt64 CSharp_AkCallbackInfo_gameObjID_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkCallbackInfo() { }
        private System.Void CSharp_delete_AkCallbackInfo(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkEventCallbackInfo_playingID_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkEventCallbackInfo_eventID_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkEventCallbackInfo() { }
        private System.Void CSharp_delete_AkEventCallbackInfo(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byChan_get(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byParam1_get(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byParam2_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkMIDIEventCallbackInfo_byType_get(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byVelocity_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkMIDIEventCallbackInfo_byCc_get(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byCcValue_get(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(System.IntPtr jarg1) { }
        private System.Byte CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMIDIEventCallbackInfo() { }
        private System.Void CSharp_delete_AkMIDIEventCallbackInfo(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkMarkerCallbackInfo_uIdentifier_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkMarkerCallbackInfo_uPosition_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkMarkerCallbackInfo_strLabel_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMarkerCallbackInfo() { }
        private System.Void CSharp_delete_AkMarkerCallbackInfo(System.IntPtr jarg1) { }
        private System.Single CSharp_AkDurationCallbackInfo_fDuration_get(System.IntPtr jarg1) { }
        private System.Single CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkDurationCallbackInfo_audioNodeID_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkDurationCallbackInfo_mediaID_get(System.IntPtr jarg1) { }
        private System.Boolean CSharp_AkDurationCallbackInfo_bStreaming_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkDurationCallbackInfo() { }
        private System.Void CSharp_delete_AkDurationCallbackInfo(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkDynamicSequenceItemCallbackInfo() { }
        private System.Void CSharp_delete_AkDynamicSequenceItemCallbackInfo(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkMusicSyncCallbackInfo_playingID_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(System.IntPtr jarg1) { }
        private System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(System.IntPtr jarg1) { }
        private System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(System.IntPtr jarg1) { }
        private System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(System.IntPtr jarg1) { }
        private System.Single CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkMusicSyncCallbackInfo_userCueName_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMusicSyncCallbackInfo() { }
        private System.Void CSharp_delete_AkMusicSyncCallbackInfo(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMusicPlaylistCallbackInfo() { }
        private System.Void CSharp_delete_AkMusicPlaylistCallbackInfo(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkBankCallbackInfo_bankID_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkBankCallbackInfo_inMemoryBankPtr_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkBankCallbackInfo_loadResult_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkBankCallbackInfo() { }
        private System.Void CSharp_delete_AkBankCallbackInfo(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkMonitoringCallbackInfo_errorCode_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkMonitoringCallbackInfo_errorLevel_get(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkMonitoringCallbackInfo_playingID_get(System.IntPtr jarg1) { }
        private System.UInt64 CSharp_AkMonitoringCallbackInfo_gameObjID_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkMonitoringCallbackInfo_message_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkMonitoringCallbackInfo() { }
        private System.Void CSharp_delete_AkMonitoringCallbackInfo(System.IntPtr jarg1) { }
        private System.Boolean CSharp_AkAudioInterruptionCallbackInfo_bEnterInterruption_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkAudioInterruptionCallbackInfo() { }
        private System.Void CSharp_delete_AkAudioInterruptionCallbackInfo(System.IntPtr jarg1) { }
        private System.Boolean CSharp_AkAudioSourceChangeCallbackInfo_bOtherAudioPlaying_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkAudioSourceChangeCallbackInfo() { }
        private System.Void CSharp_delete_AkAudioSourceChangeCallbackInfo(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkCallbackSerializer_Init() { }
        private System.Void CSharp_AkCallbackSerializer_Term() { }
        private System.IntPtr CSharp_AkCallbackSerializer_Lock() { }
        private System.Void CSharp_AkCallbackSerializer_Unlock() { }
        private System.Void CSharp_AkCallbackSerializer_SetLocalOutput(System.UInt32 jarg1, System.String jarg2, System.UInt32 jarg3, System.String jarg4, System.UInt32 jarg5, System.UInt32 jarg6) { }
        private System.Int32 CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(System.Boolean jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_new_AkCallbackSerializer() { }
        private System.Void CSharp_delete_AkCallbackSerializer(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_MsgContext__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Boolean jarg4) { }
        private System.IntPtr CSharp_new_MsgContext__SWIG_1(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3) { }
        private System.IntPtr CSharp_new_MsgContext__SWIG_2(System.UInt32 jarg1, System.UInt64 jarg2) { }
        private System.IntPtr CSharp_new_MsgContext__SWIG_3(System.UInt32 jarg1) { }
        private System.IntPtr CSharp_new_MsgContext__SWIG_4() { }
        private System.Void CSharp_MsgContext_in_playingID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_MsgContext_in_playingID_get(System.IntPtr jarg1) { }
        private System.Void CSharp_MsgContext_in_gameObjID_set(System.IntPtr jarg1, System.UInt64 jarg2) { }
        private System.UInt64 CSharp_MsgContext_in_gameObjID_get(System.IntPtr jarg1) { }
        private System.Void CSharp_MsgContext_in_soundID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_MsgContext_in_soundID_get(System.IntPtr jarg1) { }
        private System.Void CSharp_MsgContext_in_bIsBus_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_MsgContext_in_bIsBus_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_MsgContext(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_MonitorErrorInfo__SWIG_0(System.String jarg1, System.String jarg2) { }
        private System.IntPtr CSharp_new_MonitorErrorInfo__SWIG_1(System.String jarg1) { }
        private System.IntPtr CSharp_new_MonitorErrorInfo__SWIG_2() { }
        private System.Void CSharp_MonitorErrorInfo_m_name_set(System.IntPtr jarg1, System.String jarg2) { }
        private System.IntPtr CSharp_MonitorErrorInfo_m_name_get(System.IntPtr jarg1) { }
        private System.Void CSharp_MonitorErrorInfo_m_message_set(System.IntPtr jarg1, System.String jarg2) { }
        private System.IntPtr CSharp_MonitorErrorInfo_m_message_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_MonitorErrorInfo(System.IntPtr jarg1) { }
        private System.Int32 CSharp_PostCode__SWIG_0(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5, System.Boolean jarg6) { }
        private System.Int32 CSharp_PostCode__SWIG_1(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_PostCode__SWIG_2(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4) { }
        private System.Int32 CSharp_PostCode__SWIG_3(System.Int32 jarg1, System.Int32 jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_PostCode__SWIG_4(System.Int32 jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_PostCodeVarArg(System.Int32 jarg1, System.Int32 jarg2, System.IntPtr jarg3) { }
        private System.Int32 CSharp_PostString__SWIG_0(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5, System.Boolean jarg6) { }
        private System.Int32 CSharp_PostString__SWIG_1(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4, System.UInt32 jarg5) { }
        private System.Int32 CSharp_PostString__SWIG_2(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3, System.UInt64 jarg4) { }
        private System.Int32 CSharp_PostString__SWIG_3(System.String jarg1, System.Int32 jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_PostString__SWIG_4(System.String jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_ResetTranslator() { }
        private System.Int32 CSharp_GetTimeStamp() { }
        private System.Void CSharp_MonitorStreamMgrInit(System.IntPtr jarg1) { }
        private System.Void CSharp_MonitorStreamingDeviceInit(System.UInt32 jarg1, System.IntPtr jarg2) { }
        private System.Void CSharp_MonitorStreamingDeviceDestroyed(System.UInt32 jarg1) { }
        private System.Void CSharp_MonitorStreamMgrTerm() { }
        private System.Void CSharp_AkGetDefaultHighPriorityThreadProperties(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_ResolveDialogueEvent__SWIG_0(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3, System.UInt32 jarg4) { }
        private System.UInt32 CSharp_ResolveDialogueEvent__SWIG_1(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32& jarg3) { }
        private System.Int32 CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2, System.Single& jarg3) { }
        private System.Void CSharp_AkPositioningInfo_fCenterPct_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_fCenterPct_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_pannerType_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkPositioningInfo_pannerType_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_e3dPositioningType_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkPositioningInfo_e3dPositioningType_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_e3DSpatializationMode_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkPositioningInfo_e3DSpatializationMode_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_bEnableAttenuation_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkPositioningInfo_bEnableAttenuation_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_bUseConeAttenuation_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkPositioningInfo_bUseConeAttenuation_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_fInnerAngle_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_fInnerAngle_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_fOuterAngle_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_fOuterAngle_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_fConeMaxAttenuation_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_fConeMaxAttenuation_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_LPFCone_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_LPFCone_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_HPFCone_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_HPFCone_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_fMaxDistance_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_fMaxDistance_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkPositioningInfo() { }
        private System.Void CSharp_delete_AkPositioningInfo(System.IntPtr jarg1) { }
        private System.Void CSharp_AkObjectInfo_objID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkObjectInfo_objID_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkObjectInfo_parentID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkObjectInfo_parentID_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkObjectInfo_iDepth_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkObjectInfo_iDepth_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkObjectInfo_Clear(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkObjectInfo_GetSizeOf() { }
        private System.Void CSharp_AkObjectInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_new_AkObjectInfo() { }
        private System.Void CSharp_delete_AkObjectInfo(System.IntPtr jarg1) { }
        private System.Int32 CSharp_GetPosition(System.UInt64 jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_GetListenerPosition(System.UInt64 jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_GetRTPCValue__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Single& jarg4, System.Int32& jarg5) { }
        private System.Int32 CSharp_GetRTPCValue__SWIG_1(System.String jarg1, System.UInt64 jarg2, System.UInt32 jarg3, System.Single& jarg4, System.Int32& jarg5) { }
        private System.Int32 CSharp_GetSwitch__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2, System.UInt32& jarg3) { }
        private System.Int32 CSharp_GetSwitch__SWIG_1(System.String jarg1, System.UInt64 jarg2, System.UInt32& jarg3) { }
        private System.Int32 CSharp_GetState__SWIG_0(System.UInt32 jarg1, System.UInt32& jarg2) { }
        private System.Int32 CSharp_GetState__SWIG_1(System.String jarg1, System.UInt32& jarg2) { }
        private System.Int32 CSharp_GetGameObjectAuxSendValues(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt32& jarg3) { }
        private System.Int32 CSharp_GetGameObjectDryLevelValue(System.UInt64 jarg1, System.UInt64 jarg2, System.Single& jarg3) { }
        private System.Int32 CSharp_GetObjectObstructionAndOcclusion(System.UInt64 jarg1, System.UInt64 jarg2, System.Single& jarg3, System.Single& jarg4) { }
        private System.Int32 CSharp_QueryAudioObjectIDs__SWIG_0(System.UInt32 jarg1, System.UInt32& jarg2, System.IntPtr jarg3) { }
        private System.Int32 CSharp_QueryAudioObjectIDs__SWIG_1(System.String jarg1, System.UInt32& jarg2, System.IntPtr jarg3) { }
        private System.Int32 CSharp_GetPositioningInfo(System.UInt32 jarg1, System.IntPtr jarg2) { }
        private System.Boolean CSharp_GetIsGameObjectActive(System.UInt64 jarg1) { }
        private System.Single CSharp_GetMaxRadius(System.UInt64 jarg1) { }
        private System.UInt32 CSharp_GetEventIDFromPlayingID(System.UInt32 jarg1) { }
        private System.UInt64 CSharp_GetGameObjectFromPlayingID(System.UInt32 jarg1) { }
        private System.Int32 CSharp_GetPlayingIDsFromGameObject(System.UInt64 jarg1, System.UInt32& jarg2, System.UInt32[] jarg3) { }
        private System.Int32 CSharp_GetCustomPropertyValue__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.Int32& jarg3) { }
        private System.Int32 CSharp_GetCustomPropertyValue__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2, System.Single& jarg3) { }
        private System.Void CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(System.UInt32& jarg1) { }
        private System.Void CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(System.UInt32& jarg1) { }
        private System.Void CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(System.UInt32& jarg1) { }
        private System.Byte CSharp_ChannelMaskToNumChannels(System.UInt32 jarg1) { }
        private System.UInt32 CSharp_ChannelMaskFromNumChannels(System.UInt32 jarg1) { }
        private System.Byte CSharp_ChannelBitToIndex(System.UInt32 jarg1, System.UInt32 jarg2) { }
        private System.Boolean CSharp_HasSurroundChannels(System.UInt32 jarg1) { }
        private System.Boolean CSharp_HasStrictlyOnePairOfSurroundChannels(System.UInt32 jarg1) { }
        private System.Boolean CSharp_HasSideAndRearChannels(System.UInt32 jarg1) { }
        private System.Boolean CSharp_HasHeightChannels(System.UInt32 jarg1) { }
        private System.UInt32 CSharp_BackToSideChannels(System.UInt32 jarg1) { }
        private System.UInt32 CSharp_StdChannelIndexToDisplayIndex(System.Int32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        private System.Void CSharp_AkChannelConfig_uNumChannels_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkChannelConfig_uNumChannels_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkChannelConfig_eConfigType_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkChannelConfig_eConfigType_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkChannelConfig_uChannelMask_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkChannelConfig_uChannelMask_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkChannelConfig_Standard(System.UInt32 jarg1) { }
        private System.IntPtr CSharp_AkChannelConfig_Anonymous(System.UInt32 jarg1) { }
        private System.IntPtr CSharp_AkChannelConfig_Ambisonic(System.UInt32 jarg1) { }
        private System.IntPtr CSharp_AkChannelConfig_Object() { }
        private System.IntPtr CSharp_new_AkChannelConfig__SWIG_0() { }
        private System.IntPtr CSharp_new_AkChannelConfig__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2) { }
        private System.Void CSharp_AkChannelConfig_Clear(System.IntPtr jarg1) { }
        private System.Void CSharp_AkChannelConfig_SetStandard(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Void CSharp_AkChannelConfig_SetStandardOrAnonymous(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        private System.Void CSharp_AkChannelConfig_SetAnonymous(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Void CSharp_AkChannelConfig_SetAmbisonic(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Void CSharp_AkChannelConfig_SetObject(System.IntPtr jarg1) { }
        private System.Void CSharp_AkChannelConfig_SetSameAsMainMix(System.IntPtr jarg1) { }
        private System.Void CSharp_AkChannelConfig_SetSameAsPassthrough(System.IntPtr jarg1) { }
        private System.Boolean CSharp_AkChannelConfig_IsValid(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_AkChannelConfig_Serialize(System.IntPtr jarg1) { }
        private System.Void CSharp_AkChannelConfig_Deserialize(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.IntPtr CSharp_AkChannelConfig_RemoveLFE(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkChannelConfig_RemoveCenter(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkChannelConfig(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkImageSourceParams__SWIG_0() { }
        private System.IntPtr CSharp_new_AkImageSourceParams__SWIG_1(AkVector64 jarg1, System.Single jarg2, System.Single jarg3) { }
        private System.Void CSharp_AkImageSourceParams_sourcePosition_set(System.IntPtr jarg1, AkVector64 jarg2) { }
        private AkVector64 CSharp_AkImageSourceParams_sourcePosition_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkImageSourceParams_fDistanceScalingFactor_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkImageSourceParams_fDistanceScalingFactor_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkImageSourceParams_fLevel_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkImageSourceParams_fLevel_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkImageSourceParams_fDiffraction_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkImageSourceParams_fDiffraction_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkImageSourceParams_fOcclusion_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkImageSourceParams_fOcclusion_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkImageSourceParams_uDiffractionListenerSide_set(System.IntPtr jarg1, System.Byte jarg2) { }
        private System.Byte CSharp_AkImageSourceParams_uDiffractionListenerSide_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkImageSourceParams(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_kDefaultDiffractionMaxEdges_get() { }
        private System.UInt32 CSharp_kDefaultDiffractionMaxPaths_get() { }
        private System.Single CSharp_kMaxDiffraction_get() { }
        private System.UInt32 CSharp_kHashListBlockAllocItemCount_get() { }
        private System.UInt32 CSharp_kDiffractionMaxEdges_get() { }
        private System.UInt32 CSharp_kDiffractionMaxPaths_get() { }
        private System.UInt32 CSharp_kPortalToPortalDiffractionMaxPaths_get() { }
        private System.IntPtr CSharp_new_AkSpatialAudioInitSettings() { }
        private System.Void CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSpatialAudioInitSettings_fMaxPathLength_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkSpatialAudioInitSettings_fMaxPathLength_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkSpatialAudioInitSettings(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkImageSourceSettings__SWIG_0() { }
        private System.IntPtr CSharp_new_AkImageSourceSettings__SWIG_1(AkVector64 jarg1, System.Single jarg2, System.Single jarg3) { }
        private System.Void CSharp_AkImageSourceSettings_SetOneTexture(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Void CSharp_AkImageSourceSettings_params__set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkImageSourceSettings_params__get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkImageSourceSettings(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkExtent__SWIG_0() { }
        private System.IntPtr CSharp_new_AkExtent__SWIG_1(System.Single jarg1, System.Single jarg2, System.Single jarg3) { }
        private System.Void CSharp_AkExtent_halfWidth_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkExtent_halfWidth_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkExtent_halfHeight_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkExtent_halfHeight_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkExtent_halfDepth_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkExtent_halfDepth_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkExtent(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkTriangle__SWIG_0() { }
        private System.IntPtr CSharp_new_AkTriangle__SWIG_1(System.UInt16 jarg1, System.UInt16 jarg2, System.UInt16 jarg3, System.UInt16 jarg4) { }
        private System.Void CSharp_AkTriangle_point0_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        private System.UInt16 CSharp_AkTriangle_point0_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkTriangle_point1_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        private System.UInt16 CSharp_AkTriangle_point1_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkTriangle_point2_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        private System.UInt16 CSharp_AkTriangle_point2_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkTriangle_surface_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        private System.UInt16 CSharp_AkTriangle_surface_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkTriangle_Clear(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkTriangle_GetSizeOf() { }
        private System.Void CSharp_AkTriangle_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Void CSharp_delete_AkTriangle(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkAcousticSurface() { }
        private System.Void CSharp_AkAcousticSurface_textureID_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkAcousticSurface_textureID_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAcousticSurface_transmissionLoss_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkAcousticSurface_transmissionLoss_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAcousticSurface_strName_set(System.IntPtr jarg1, System.String jarg2) { }
        private System.IntPtr CSharp_AkAcousticSurface_strName_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAcousticSurface_Clear(System.IntPtr jarg1) { }
        private System.Void CSharp_AkAcousticSurface_DeleteName(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkAcousticSurface_GetSizeOf() { }
        private System.Void CSharp_AkAcousticSurface_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Void CSharp_delete_AkAcousticSurface(System.IntPtr jarg1) { }
        private System.Void CSharp_AkReflectionPathInfo_imageSource_set(System.IntPtr jarg1, AkVector64 jarg2) { }
        private AkVector64 CSharp_AkReflectionPathInfo_imageSource_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkReflectionPathInfo_numPathPoints_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkReflectionPathInfo_numPathPoints_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkReflectionPathInfo_numReflections_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkReflectionPathInfo_numReflections_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkReflectionPathInfo_level_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkReflectionPathInfo_level_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkReflectionPathInfo_isOccluded_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkReflectionPathInfo_isOccluded_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkReflectionPathInfo_GetSizeOf() { }
        private UnityEngine.Vector3 CSharp_AkReflectionPathInfo_GetPathPoint(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.IntPtr CSharp_AkReflectionPathInfo_GetAcousticSurface(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Single CSharp_AkReflectionPathInfo_GetDiffraction(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Void CSharp_AkReflectionPathInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_new_AkReflectionPathInfo() { }
        private System.Void CSharp_delete_AkReflectionPathInfo(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDiffractionPathInfo_emitterPos_set(System.IntPtr jarg1, AkVector64 jarg2) { }
        private AkVector64 CSharp_AkDiffractionPathInfo_emitterPos_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDiffractionPathInfo_virtualPos_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkDiffractionPathInfo_virtualPos_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDiffractionPathInfo_nodeCount_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkDiffractionPathInfo_nodeCount_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDiffractionPathInfo_diffraction_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkDiffractionPathInfo_diffraction_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDiffractionPathInfo_transmissionLoss_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkDiffractionPathInfo_transmissionLoss_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDiffractionPathInfo_totLength_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkDiffractionPathInfo_totLength_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDiffractionPathInfo_obstructionValue_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkDiffractionPathInfo_obstructionValue_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDiffractionPathInfo_occlusionValue_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkDiffractionPathInfo_occlusionValue_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_AkDiffractionPathInfo_GetSizeOf() { }
        private UnityEngine.Vector3 CSharp_AkDiffractionPathInfo_GetNodes(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Single CSharp_AkDiffractionPathInfo_GetAngles(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt64 CSharp_AkDiffractionPathInfo_GetPortals(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt64 CSharp_AkDiffractionPathInfo_GetRooms(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.Void CSharp_AkDiffractionPathInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_new_AkDiffractionPathInfo() { }
        private System.Void CSharp_delete_AkDiffractionPathInfo(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkRoomParams() { }
        private System.Void CSharp_AkRoomParams_Front_set(System.IntPtr jarg1, UnityEngine.Vector3 jarg2) { }
        private UnityEngine.Vector3 CSharp_AkRoomParams_Front_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkRoomParams_Up_set(System.IntPtr jarg1, UnityEngine.Vector3 jarg2) { }
        private UnityEngine.Vector3 CSharp_AkRoomParams_Up_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkRoomParams_ReverbAuxBus_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkRoomParams_ReverbAuxBus_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkRoomParams_ReverbLevel_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkRoomParams_ReverbLevel_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkRoomParams_TransmissionLoss_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkRoomParams_TransmissionLoss_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkRoomParams_RoomPriority_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkRoomParams_RoomPriority_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkRoomParams(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkGeometryInstanceParams() { }
        private System.Void CSharp_AkGeometryInstanceParams_PositionAndOrientation_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkGeometryInstanceParams_PositionAndOrientation_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkGeometryInstanceParams_Scale_set(System.IntPtr jarg1, UnityEngine.Vector3 jarg2) { }
        private UnityEngine.Vector3 CSharp_AkGeometryInstanceParams_Scale_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkGeometryInstanceParams(System.IntPtr jarg1) { }
        private System.Int32 CSharp_SetGameObjectRadius(System.UInt64 jarg1, System.Single jarg2, System.Single jarg3) { }
        private System.Int32 CSharp_SetImageSource__SWIG_0(System.UInt32 jarg1, System.IntPtr jarg2, System.String jarg3, System.UInt32 jarg4, System.UInt64 jarg5) { }
        private System.Int32 CSharp_SetImageSource__SWIG_1(System.UInt32 jarg1, System.IntPtr jarg2, System.String jarg3, System.UInt32 jarg4) { }
        private System.Int32 CSharp_SetImageSource__SWIG_2(System.UInt32 jarg1, System.IntPtr jarg2, System.String jarg3) { }
        private System.Int32 CSharp_RemoveImageSource__SWIG_0(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt64 jarg3) { }
        private System.Int32 CSharp_RemoveImageSource__SWIG_1(System.UInt32 jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_RemoveImageSource__SWIG_2(System.UInt32 jarg1) { }
        private System.Int32 CSharp_ClearImageSources__SWIG_0(System.UInt32 jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_ClearImageSources__SWIG_1(System.UInt32 jarg1) { }
        private System.Int32 CSharp_ClearImageSources__SWIG_2() { }
        private System.Int32 CSharp_RemoveGeometry(System.UInt64 jarg1) { }
        private System.Int32 CSharp_RemoveGeometryInstance(System.UInt64 jarg1) { }
        private System.Int32 CSharp_RemoveRoom(System.UInt64 jarg1) { }
        private System.Int32 CSharp_RemovePortal(System.UInt64 jarg1) { }
        private System.Int32 CSharp_SetReverbZone(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        private System.Int32 CSharp_RemoveReverbZone(System.UInt64 jarg1) { }
        private System.Int32 CSharp_SetGameObjectInRoom(System.UInt64 jarg1, System.UInt64 jarg2) { }
        private System.Int32 CSharp_UnsetGameObjectInRoom(System.UInt64 jarg1) { }
        private System.Int32 CSharp_SetReflectionsOrder(System.UInt32 jarg1, System.Boolean jarg2) { }
        private System.Int32 CSharp_SetDiffractionOrder(System.UInt32 jarg1, System.Boolean jarg2) { }
        private System.Int32 CSharp_SetMaxEmitterRoomAuxSends(System.UInt32 jarg1) { }
        private System.Int32 CSharp_SetNumberOfPrimaryRays(System.UInt32 jarg1) { }
        private System.Int32 CSharp_SetLoadBalancingSpread(System.UInt32 jarg1) { }
        private System.Int32 CSharp_SetEarlyReflectionsAuxSend(System.UInt64 jarg1, System.UInt32 jarg2) { }
        private System.Int32 CSharp_SetEarlyReflectionsVolume(System.UInt64 jarg1, System.Single jarg2) { }
        private System.Int32 CSharp_SetPortalObstructionAndOcclusion(System.UInt64 jarg1, System.Single jarg2, System.Single jarg3) { }
        private System.Int32 CSharp_SetGameObjectToPortalObstruction(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        private System.Int32 CSharp_SetPortalToPortalObstruction(System.UInt64 jarg1, System.UInt64 jarg2, System.Single jarg3) { }
        private System.Int32 CSharp_QueryWetDiffraction(System.UInt64 jarg1, System.Single& jarg2) { }
        private System.Int32 CSharp_ResetStochasticEngine() { }
        private System.Void CSharp_AkPlatformInitSettings_threadLEngine_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkPlatformInitSettings_threadLEngine_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlatformInitSettings_threadOutputMgr_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkPlatformInitSettings_threadOutputMgr_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlatformInitSettings_threadBankManager_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkPlatformInitSettings_threadBankManager_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlatformInitSettings_threadMonitor_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkPlatformInitSettings_threadMonitor_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        private System.UInt16 CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlatformInitSettings_uSampleRate_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkPlatformInitSettings_uSampleRate_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlatformInitSettings_bEnableAvxSupport_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkPlatformInitSettings_bEnableAvxSupport_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkPlatformInitSettings(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_GetDeviceIDFromName(System.String jarg1) { }
        private System.IntPtr CSharp_GetWindowsDeviceName__SWIG_0(System.Int32 jarg1, System.UInt32& jarg2, System.Int32 jarg3) { }
        private System.IntPtr CSharp_GetWindowsDeviceName__SWIG_1(System.Int32 jarg1, System.UInt32& jarg2) { }
        private System.UInt32 CSharp_GetWindowsDeviceCount__SWIG_0(System.Int32 jarg1) { }
        private System.UInt32 CSharp_GetWindowsDeviceCount__SWIG_1() { }
        private System.Void CSharp_delete_AkStreamMgrSettings(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceSettings_pIOMemory_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkDeviceSettings_pIOMemory_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceSettings_uIOMemorySize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkDeviceSettings_uIOMemorySize_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceSettings_uIOMemoryAlignment_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkDeviceSettings_uIOMemoryAlignment_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceSettings_ePoolAttributes_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkDeviceSettings_ePoolAttributes_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceSettings_uGranularity_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkDeviceSettings_uGranularity_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceSettings_threadProperties_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkDeviceSettings_threadProperties_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(System.IntPtr jarg1, System.Single jarg2) { }
        private System.Single CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceSettings_uMaxConcurrentIO_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkDeviceSettings_uMaxConcurrentIO_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceSettings_bUseStreamCache_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkDeviceSettings_bUseStreamCache_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkDeviceSettings(System.IntPtr jarg1) { }
        private System.Void CSharp_AkThreadProperties_nPriority_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkThreadProperties_nPriority_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkThreadProperties_dwAffinityMask_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkThreadProperties_dwAffinityMask_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkThreadProperties_uStackSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkThreadProperties_uStackSize_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkThreadProperties() { }
        private System.Void CSharp_delete_AkThreadProperties(System.IntPtr jarg1) { }
        private System.Void CSharp_SetErrorLogger__SWIG_0(AkLogger.ErrorLoggerInteropDelegate jarg1) { }
        private System.Void CSharp_SetErrorLogger__SWIG_1() { }
        private System.Void CSharp_SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate jarg1, AkAudioInputManager.AudioFormatInteropDelegate jarg2) { }
        private System.Void CSharp_delete_AkUnityPlatformSpecificSettings(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkCommunicationSettings() { }
        private System.Void CSharp_AkCommunicationSettings_uPoolSize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkCommunicationSettings_uPoolSize_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        private System.UInt16 CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkCommunicationSettings_uCommandPort_set(System.IntPtr jarg1, System.UInt16 jarg2) { }
        private System.UInt16 CSharp_AkCommunicationSettings_uCommandPort_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkCommunicationSettings_commSystem_set(System.IntPtr jarg1, System.Int32 jarg2) { }
        private System.Int32 CSharp_AkCommunicationSettings_commSystem_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkCommunicationSettings_bInitSystemLib_set(System.IntPtr jarg1, System.Boolean jarg2) { }
        private System.Boolean CSharp_AkCommunicationSettings_bInitSystemLib_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkCommunicationSettings_szAppNetworkName_set(System.IntPtr jarg1, System.String jarg2) { }
        private System.IntPtr CSharp_AkCommunicationSettings_szAppNetworkName_get(System.IntPtr jarg1) { }
        private System.Void CSharp_delete_AkCommunicationSettings(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkInitializationSettings() { }
        private System.Void CSharp_delete_AkInitializationSettings(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitializationSettings_streamMgrSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkInitializationSettings_streamMgrSettings_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitializationSettings_deviceSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkInitializationSettings_deviceSettings_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitializationSettings_initSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkInitializationSettings_initSettings_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitializationSettings_platformSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkInitializationSettings_platformSettings_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitializationSettings_musicSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkInitializationSettings_musicSettings_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitializationSettings_uMemAllocationSizeLimit_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkInitializationSettings_uMemAllocationSizeLimit_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitializationSettings_uMemDebugLevel_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkInitializationSettings_uMemDebugLevel_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkInitializationSettings_uMemSpanCount_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkInitializationSettings_uMemSpanCount_get(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_0() { }
        private System.Void CSharp_delete_AkExternalSourceInfo(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_1(System.IntPtr jarg1, System.UInt32 jarg2, System.UInt32 jarg3, System.UInt32 jarg4) { }
        private System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_2(System.String jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        private System.IntPtr CSharp_new_AkExternalSourceInfo__SWIG_3(System.UInt32 jarg1, System.UInt32 jarg2, System.UInt32 jarg3) { }
        private System.Void CSharp_AkExternalSourceInfo_Clear(System.IntPtr jarg1) { }
        private System.Void CSharp_AkExternalSourceInfo_Clone(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.Int32 CSharp_AkExternalSourceInfo_GetSizeOf() { }
        private System.Void CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkExternalSourceInfo_idCodec_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkExternalSourceInfo_idCodec_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkExternalSourceInfo_szFile_set(System.IntPtr jarg1, System.String jarg2) { }
        private System.IntPtr CSharp_AkExternalSourceInfo_szFile_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkExternalSourceInfo_pInMemory_set(System.IntPtr jarg1, System.IntPtr jarg2) { }
        private System.IntPtr CSharp_AkExternalSourceInfo_pInMemory_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkExternalSourceInfo_uiMemorySize_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkExternalSourceInfo_uiMemorySize_get(System.IntPtr jarg1) { }
        private System.Void CSharp_AkExternalSourceInfo_idFile_set(System.IntPtr jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_AkExternalSourceInfo_idFile_get(System.IntPtr jarg1) { }
        private System.Int32 CSharp_Init(System.IntPtr jarg1) { }
        private System.Int32 CSharp_InitSpatialAudio(System.IntPtr jarg1) { }
        private System.Int32 CSharp_InitCommunication(System.IntPtr jarg1) { }
        private System.Void CSharp_Term() { }
        private System.Int32 CSharp_RegisterGameObjInternal(System.UInt64 jarg1) { }
        private System.Int32 CSharp_UnregisterGameObjInternal(System.UInt64 jarg1) { }
        private System.Int32 CSharp_RegisterGameObjInternal_WithName(System.UInt64 jarg1, System.String jarg2) { }
        private System.Int32 CSharp_SetBasePath(System.String jarg1) { }
        private System.Int32 CSharp_SetCurrentLanguage(System.String jarg1) { }
        private System.Int32 CSharp_LoadFilePackage(System.String jarg1, System.UInt32& jarg2) { }
        private System.Int32 CSharp_AddBasePath(System.String jarg1) { }
        private System.Int32 CSharp_SetGameName(System.String jarg1) { }
        private System.IntPtr CSharp_GetCurrentLanguage() { }
        private System.Int32 CSharp_UnloadFilePackage(System.UInt32 jarg1) { }
        private System.Int32 CSharp_UnloadAllFilePackages() { }
        private System.Int32 CSharp_SetObjectPosition(System.UInt64 jarg1, UnityEngine.Vector3 jarg2, UnityEngine.Vector3 jarg3, UnityEngine.Vector3 jarg4) { }
        private System.Int32 CSharp_GetSourceMultiplePlayPositions__SWIG_0(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32[] jarg3, System.Int32[] jarg4, System.UInt32& jarg5, System.Boolean jarg6) { }
        private System.Int32 CSharp_GetSourceMultiplePlayPositions__SWIG_1(System.UInt32 jarg1, System.UInt32[] jarg2, System.UInt32[] jarg3, System.Int32[] jarg4, System.UInt32& jarg5) { }
        private System.Int32 CSharp_SetListeners(System.UInt64 jarg1, System.UInt64[] jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_SetDefaultListeners(System.UInt64[] jarg1, System.UInt32 jarg2) { }
        private System.UInt32 CSharp_GetNumOutputDevices(System.UInt32 jarg1) { }
        private System.Int32 CSharp_AddOutput__SWIG_0(System.IntPtr jarg1, System.UInt64& jarg2, System.UInt64[] jarg3, System.UInt32 jarg4) { }
        private System.Int32 CSharp_AddOutput__SWIG_1(System.IntPtr jarg1, System.UInt64& jarg2, System.UInt64[] jarg3) { }
        private System.Int32 CSharp_AddOutput__SWIG_2(System.IntPtr jarg1, System.UInt64& jarg2) { }
        private System.Int32 CSharp_AddOutput__SWIG_3(System.IntPtr jarg1) { }
        private System.Void CSharp_GetDefaultStreamSettings(System.IntPtr jarg1) { }
        private System.Void CSharp_GetDefaultDeviceSettings(System.IntPtr jarg1) { }
        private System.Void CSharp_GetDefaultMusicSettings(System.IntPtr jarg1) { }
        private System.Void CSharp_GetDefaultInitSettings(System.IntPtr jarg1) { }
        private System.Void CSharp_GetDefaultPlatformInitSettings(System.IntPtr jarg1) { }
        private System.UInt32 CSharp_GetMajorMinorVersion() { }
        private System.UInt32 CSharp_GetSubminorBuildVersion() { }
        private System.Void CSharp_StartResourceMonitoring() { }
        private System.Void CSharp_StopResourceMonitoring() { }
        private System.Void CSharp_GetResourceMonitorDataSummary(System.IntPtr jarg1) { }
        private System.Void CSharp_StartDeviceCapture(System.UInt64 jarg1) { }
        private System.Void CSharp_StopDeviceCapture(System.UInt64 jarg1) { }
        private System.Void CSharp_ClearCaptureData() { }
        private System.UInt32 CSharp_UpdateCaptureSampleCount(System.UInt64 jarg1) { }
        private System.UInt32 CSharp_GetCaptureSamples(System.UInt64 jarg1, System.Single[] jarg2, System.UInt32 jarg3) { }
        private System.Int32 CSharp_SetRoomPortal(System.UInt64 jarg1, System.UInt64 jarg2, System.UInt64 jarg3, System.IntPtr jarg4, System.IntPtr jarg5, System.Boolean jarg6, System.String jarg7) { }
        private System.Int32 CSharp_SetRoom(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt64 jarg3, System.String jarg4) { }
        private System.Int32 CSharp_RegisterSpatialAudioListener(System.UInt64 jarg1) { }
        private System.Int32 CSharp_UnregisterSpatialAudioListener(System.UInt64 jarg1) { }
        private System.Int32 CSharp_SetGeometry(System.UInt64 jarg1, System.IntPtr jarg2, System.UInt32 jarg3, UnityEngine.Vector3[] jarg4, System.UInt32 jarg5, System.IntPtr jarg6, System.UInt32 jarg7, System.Boolean jarg8, System.Boolean jarg9) { }
        private System.Int32 CSharp_SetGeometryInstance(System.UInt64 jarg1, System.IntPtr jarg2, UnityEngine.Vector3 jarg3, System.UInt64 jarg4, System.UInt64 jarg5, System.Boolean jarg6) { }
        private System.Int32 CSharp_QueryReflectionPaths(System.UInt64 jarg1, System.UInt32 jarg2, UnityEngine.Vector3& jarg3, UnityEngine.Vector3& jarg4, System.IntPtr jarg5, System.UInt32& jarg6) { }
        private System.Int32 CSharp_QueryDiffractionPaths(System.UInt64 jarg1, System.UInt32 jarg2, UnityEngine.Vector3& jarg3, UnityEngine.Vector3& jarg4, System.IntPtr jarg5, System.UInt32& jarg6) { }
        private System.Void CSharp_PerformStreamMgrIO() { }
        private System.Void CSharp_HgMemShrink() { }
        private System.UInt64 CSharp_HgGetGlobalMemoryUsed() { }
        private System.UInt64 CSharp_HgGetGlobalMemoryReserved() { }
        private System.Void CSharp_InitScePad() { }
        private System.UInt32 CSharp_GetMMDeviceIdFromPadContainerInfo(System.Int32 jarg1) { }
        private System.IntPtr CSharp_AkPlaylist_SWIGUpcast(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkMIDIPost_SWIGUpcast(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkEventCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkMarkerCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkDurationCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        private System.IntPtr CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(System.IntPtr jarg1) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006E
    public class GameObjectHashFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.UInt64 Invoke(UnityEngine.GameObject gameObject) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.GameObject gameObject, System.AsyncCallback callback, System.Object object) { }
        private System.UInt64 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200006D
    public class AkSoundEngine
    {
        // Fields
        public static System.Int32 _WIN32_WINNT;        // 0x0
        public static System.Int32 AK_SIMD_ALIGNMENT;        // 0x0
        public static System.Int32 AK_BUFFER_ALIGNMENT;        // 0x0
        public static System.Int32 AK_XAUDIO2_FLAGS;        // 0x0
        public static System.Int32 AK_MAX_PATH;        // 0x0
        public static System.Int32 AK_BANK_PLATFORM_DATA_ALIGNMENT;        // 0x0
        public static System.String AK_OSCHAR_FMT;        // 0x0
        public static System.UInt32 AK_INVALID_PLUGINID;        // 0x0
        public static System.UInt64 AK_INVALID_GAME_OBJECT;        // 0x0
        public static System.UInt32 AK_INVALID_UNIQUE_ID;        // 0x0
        public static System.UInt32 AK_INVALID_RTPC_ID;        // 0x0
        public static System.UInt32 AK_INVALID_LISTENER_INDEX;        // 0x0
        public static System.UInt32 AK_INVALID_PLAYING_ID;        // 0x0
        public static System.UInt32 AK_DEFAULT_SWITCH_STATE;        // 0x0
        public static System.Int32 AK_INVALID_POOL_ID;        // 0x0
        public static System.Int32 AK_DEFAULT_POOL_ID;        // 0x0
        public static System.UInt32 AK_INVALID_AUX_ID;        // 0x0
        public static System.UInt32 AK_INVALID_FILE_ID;        // 0x0
        public static System.UInt32 AK_INVALID_DEVICE_ID;        // 0x0
        public static System.UInt32 AK_INVALID_BANK_ID;        // 0x0
        public static System.UInt32 AK_FALLBACK_ARGUMENTVALUE_ID;        // 0x0
        public static System.UInt32 AK_INVALID_CHANNELMASK;        // 0x0
        public static System.UInt32 AK_INVALID_OUTPUT_DEVICE_ID;        // 0x0
        public static System.UInt32 AK_MIXER_FX_SLOT;        // 0x0
        public static System.UInt64 AK_DEFAULT_LISTENER_OBJ;        // 0x0
        public static System.UInt32 AK_DEFAULT_PRIORITY;        // 0x0
        public static System.UInt32 AK_MIN_PRIORITY;        // 0x0
        public static System.UInt32 AK_MAX_PRIORITY;        // 0x0
        public static System.UInt32 AK_DEFAULT_BANK_IO_PRIORITY;        // 0x0
        public static System.Double AK_DEFAULT_BANK_THROUGHPUT;        // 0x0
        public static System.UInt32 AKCOMPANYID_AUDIOKINETIC;        // 0x0
        public static System.UInt32 AK_LISTENERS_MASK_ALL;        // 0x0
        public static System.Int32 NULL;        // 0x0
        public static System.Int32 AKCURVEINTERPOLATION_NUM_STORAGE_BIT;        // 0x0
        public static System.Int32 AK_MAX_LANGUAGE_NAME_SIZE;        // 0x0
        public static System.Int32 AKCOMPANYID_PLUGINDEV_MIN;        // 0x0
        public static System.Int32 AKCOMPANYID_PLUGINDEV_MAX;        // 0x0
        public static System.Int32 AKCOMPANYID_AUDIOKINETIC_EXTERNAL;        // 0x0
        public static System.Int32 AKCOMPANYID_MCDSP;        // 0x0
        public static System.Int32 AKCOMPANYID_WAVEARTS;        // 0x0
        public static System.Int32 AKCOMPANYID_PHONETICARTS;        // 0x0
        public static System.Int32 AKCOMPANYID_IZOTOPE;        // 0x0
        public static System.Int32 AKCOMPANYID_CRANKCASEAUDIO;        // 0x0
        public static System.Int32 AKCOMPANYID_IOSONO;        // 0x0
        public static System.Int32 AKCOMPANYID_AUROTECHNOLOGIES;        // 0x0
        public static System.Int32 AKCOMPANYID_DOLBY;        // 0x0
        public static System.Int32 AKCOMPANYID_TWOBIGEARS;        // 0x0
        public static System.Int32 AKCOMPANYID_OCULUS;        // 0x0
        public static System.Int32 AKCOMPANYID_BLUERIPPLESOUND;        // 0x0
        public static System.Int32 AKCOMPANYID_ENZIEN;        // 0x0
        public static System.Int32 AKCOMPANYID_KROTOS;        // 0x0
        public static System.Int32 AKCOMPANYID_NURULIZE;        // 0x0
        public static System.Int32 AKCOMPANYID_SUPERPOWERED;        // 0x0
        public static System.Int32 AKCOMPANYID_GOOGLE;        // 0x0
        public static System.Int32 AKCOMPANYID_VISISONICS;        // 0x0
        public static System.Int32 AKCODECID_BANK;        // 0x0
        public static System.Int32 AKCODECID_PCM;        // 0x0
        public static System.Int32 AKCODECID_ADPCM;        // 0x0
        public static System.Int32 AKCODECID_XMA;        // 0x0
        public static System.Int32 AKCODECID_VORBIS;        // 0x0
        public static System.Int32 AKCODECID_WIIADPCM;        // 0x0
        public static System.Int32 AKCODECID_PCMEX;        // 0x0
        public static System.Int32 AKCODECID_EXTERNAL_SOURCE;        // 0x0
        public static System.Int32 AKCODECID_XWMA;        // 0x0
        public static System.Int32 AKCODECID_FILE_PACKAGE;        // 0x0
        public static System.Int32 AKCODECID_ATRAC9;        // 0x0
        public static System.Int32 AKCODECID_VAG;        // 0x0
        public static System.Int32 AKCODECID_PROFILERCAPTURE;        // 0x0
        public static System.Int32 AKCODECID_ANALYSISFILE;        // 0x0
        public static System.Int32 AKCODECID_MIDI;        // 0x0
        public static System.Int32 AKCODECID_OPUSNX;        // 0x0
        public static System.Int32 AKCODECID_CAF;        // 0x0
        public static System.Int32 AKCODECID_AKOPUS;        // 0x0
        public static System.Int32 AKCODECID_AKOPUS_WEM;        // 0x0
        public static System.Int32 AKCODECID_MEMORYMGR_DUMP;        // 0x0
        public static System.Int32 AKCODECID_SONY360;        // 0x0
        public static System.Int32 AKCODECID_BANK_EVENT;        // 0x0
        public static System.Int32 AKCODECID_BANK_BUS;        // 0x0
        public static System.Int32 AKPLUGINID_METER;        // 0x0
        public static System.Int32 AKPLUGINID_RECORDER;        // 0x0
        public static System.Int32 AKPLUGINID_IMPACTER;        // 0x0
        public static System.Int32 AKPLUGINID_SYSTEM_OUTPUT_META;        // 0x0
        public static System.Int32 AKPLUGINID_AUDIO_OBJECT_ATTENUATION_META;        // 0x0
        public static System.Int32 AKPLUGINID_AUDIO_OBJECT_PRIORITY_META;        // 0x0
        public static System.Int32 AKEXTENSIONID_SPATIALAUDIO;        // 0x0
        public static System.Int32 AKEXTENSIONID_INTERACTIVEMUSIC;        // 0x0
        public static System.Int32 AKEXTENSIONID_MIDIDEVICEMGR;        // 0x0
        public static System.Int32 AK_WAVE_FORMAT_VAG;        // 0x0
        public static System.Int32 AK_WAVE_FORMAT_AT9;        // 0x0
        public static System.Int32 AK_WAVE_FORMAT_VORBIS;        // 0x0
        public static System.Int32 AK_WAVE_FORMAT_OPUSNX;        // 0x0
        public static System.Int32 AK_WAVE_FORMAT_OPUS;        // 0x0
        public static System.Int32 AK_WAVE_FORMAT_OPUS_WEM;        // 0x0
        public static System.Int32 WAVE_FORMAT_XMA2;        // 0x0
        public static System.Int32 AK_PANNER_NUM_STORAGE_BITS;        // 0x0
        public static System.Int32 AK_POSSOURCE_NUM_STORAGE_BITS;        // 0x0
        public static System.Int32 AK_SPAT_NUM_STORAGE_BITS;        // 0x0
        public static System.Int32 AK_MAX_BITS_METERING_FLAGS;        // 0x0
        public static System.Boolean AK_ASYNC_OPEN_DEFAULT;        // 0x0
        public static System.Int32 AK_COMM_DEFAULT_DISCOVERY_PORT;        // 0x0
        public static System.Double AK_DEFAULT_LISTENER_POSITION_X;        // 0x0
        public static System.Double AK_DEFAULT_LISTENER_POSITION_Y;        // 0x0
        public static System.Double AK_DEFAULT_LISTENER_POSITION_Z;        // 0x0
        public static System.Double AK_DEFAULT_LISTENER_FRONT_X;        // 0x0
        public static System.Double AK_DEFAULT_LISTENER_FRONT_Y;        // 0x0
        public static System.Double AK_DEFAULT_LISTENER_FRONT_Z;        // 0x0
        public static System.Double AK_DEFAULT_TOP_X;        // 0x0
        public static System.Double AK_DEFAULT_TOP_Y;        // 0x0
        public static System.Double AK_DEFAULT_TOP_Z;        // 0x0
        public static System.Double AK_SA_EPSILON;        // 0x0
        public static System.Double AK_SA_DIFFRACTION_EPSILON;        // 0x0
        public static System.Double AK_SA_PLANE_THICKNESS;        // 0x0
        public static System.Double AK_SA_MIN_ENVIRONMENT_ABSORPTION;        // 0x0
        public static System.Double AK_SA_MIN_ENVIRONMENT_SURFACE_AREA;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_INVALID;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_NOTE_OFF;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_NOTE_ON;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_CONTROLLER;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_PITCH_BEND;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_SYSEX;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_ESCAPE;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_WWISE_CMD;        // 0x0
        public static System.Int32 AK_MIDI_EVENT_TYPE_META;        // 0x0
        public static System.Int32 AK_MIDI_CC_BANK_SELECT_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_MOD_WHEEL_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_BREATH_CTRL_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_3_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_FOOT_PEDAL_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_PORTAMENTO_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_DATA_ENTRY_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_VOLUME_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_BALANCE_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_9_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_PAN_POSITION_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_EXPRESSION_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_EFFECT_CTRL_1_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_EFFECT_CTRL_2_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_14_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_15_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_GEN_SLIDER_1;        // 0x0
        public static System.Int32 AK_MIDI_CC_GEN_SLIDER_2;        // 0x0
        public static System.Int32 AK_MIDI_CC_GEN_SLIDER_3;        // 0x0
        public static System.Int32 AK_MIDI_CC_GEN_SLIDER_4;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_20_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_21_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_22_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_23_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_24_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_25_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_26_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_27_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_28_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_29_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_30_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_31_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_BANK_SELECT_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_MOD_WHEEL_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_BREATH_CTRL_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_3_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_FOOT_PEDAL_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_PORTAMENTO_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_DATA_ENTRY_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_VOLUME_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_BALANCE_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_9_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_PAN_POSITION_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_EXPRESSION_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_EFFECT_CTRL_1_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_EFFECT_CTRL_2_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_14_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_15_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_20_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_21_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_22_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_23_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_24_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_25_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_26_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_27_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_28_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_29_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_30_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_CTRL_31_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_HOLD_PEDAL;        // 0x0
        public static System.Int32 AK_MIDI_CC_PORTAMENTO_ON_OFF;        // 0x0
        public static System.Int32 AK_MIDI_CC_SUSTENUTO_PEDAL;        // 0x0
        public static System.Int32 AK_MIDI_CC_SOFT_PEDAL;        // 0x0
        public static System.Int32 AK_MIDI_CC_LEGATO_PEDAL;        // 0x0
        public static System.Int32 AK_MIDI_CC_HOLD_PEDAL_2;        // 0x0
        public static System.Int32 AK_MIDI_CC_SOUND_VARIATION;        // 0x0
        public static System.Int32 AK_MIDI_CC_SOUND_TIMBRE;        // 0x0
        public static System.Int32 AK_MIDI_CC_SOUND_RELEASE_TIME;        // 0x0
        public static System.Int32 AK_MIDI_CC_SOUND_ATTACK_TIME;        // 0x0
        public static System.Int32 AK_MIDI_CC_SOUND_BRIGHTNESS;        // 0x0
        public static System.Int32 AK_MIDI_CC_SOUND_CTRL_6;        // 0x0
        public static System.Int32 AK_MIDI_CC_SOUND_CTRL_7;        // 0x0
        public static System.Int32 AK_MIDI_CC_SOUND_CTRL_8;        // 0x0
        public static System.Int32 AK_MIDI_CC_SOUND_CTRL_9;        // 0x0
        public static System.Int32 AK_MIDI_CC_SOUND_CTRL_10;        // 0x0
        public static System.Int32 AK_MIDI_CC_GENERAL_BUTTON_1;        // 0x0
        public static System.Int32 AK_MIDI_CC_GENERAL_BUTTON_2;        // 0x0
        public static System.Int32 AK_MIDI_CC_GENERAL_BUTTON_3;        // 0x0
        public static System.Int32 AK_MIDI_CC_GENERAL_BUTTON_4;        // 0x0
        public static System.Int32 AK_MIDI_CC_REVERB_LEVEL;        // 0x0
        public static System.Int32 AK_MIDI_CC_TREMOLO_LEVEL;        // 0x0
        public static System.Int32 AK_MIDI_CC_CHORUS_LEVEL;        // 0x0
        public static System.Int32 AK_MIDI_CC_CELESTE_LEVEL;        // 0x0
        public static System.Int32 AK_MIDI_CC_PHASER_LEVEL;        // 0x0
        public static System.Int32 AK_MIDI_CC_DATA_BUTTON_P1;        // 0x0
        public static System.Int32 AK_MIDI_CC_DATA_BUTTON_M1;        // 0x0
        public static System.Int32 AK_MIDI_CC_NON_REGISTER_COARSE;        // 0x0
        public static System.Int32 AK_MIDI_CC_NON_REGISTER_FINE;        // 0x0
        public static System.Int32 AK_MIDI_CC_ALL_SOUND_OFF;        // 0x0
        public static System.Int32 AK_MIDI_CC_ALL_CONTROLLERS_OFF;        // 0x0
        public static System.Int32 AK_MIDI_CC_LOCAL_KEYBOARD;        // 0x0
        public static System.Int32 AK_MIDI_CC_ALL_NOTES_OFF;        // 0x0
        public static System.Int32 AK_MIDI_CC_OMNI_MODE_OFF;        // 0x0
        public static System.Int32 AK_MIDI_CC_OMNI_MODE_ON;        // 0x0
        public static System.Int32 AK_MIDI_CC_OMNI_MONOPHONIC_ON;        // 0x0
        public static System.Int32 AK_MIDI_CC_OMNI_POLYPHONIC_ON;        // 0x0
        public static System.Int32 AK_MIDI_WWISE_CMD_PLAY;        // 0x0
        public static System.Int32 AK_MIDI_WWISE_CMD_STOP;        // 0x0
        public static System.Int32 AK_MIDI_WWISE_CMD_PAUSE;        // 0x0
        public static System.Int32 AK_MIDI_WWISE_CMD_RESUME;        // 0x0
        public static System.Int32 AK_MIDI_WWISE_CMD_SEEK_MS;        // 0x0
        public static System.Int32 AK_MIDI_WWISE_CMD_SEEK_SAMPLES;        // 0x0
        public static System.Int32 AK_SPEAKER_FRONT_LEFT;        // 0x0
        public static System.Int32 AK_SPEAKER_FRONT_RIGHT;        // 0x0
        public static System.Int32 AK_SPEAKER_FRONT_CENTER;        // 0x0
        public static System.Int32 AK_SPEAKER_LOW_FREQUENCY;        // 0x0
        public static System.Int32 AK_SPEAKER_BACK_LEFT;        // 0x0
        public static System.Int32 AK_SPEAKER_BACK_RIGHT;        // 0x0
        public static System.Int32 AK_SPEAKER_BACK_CENTER;        // 0x0
        public static System.Int32 AK_SPEAKER_SIDE_LEFT;        // 0x0
        public static System.Int32 AK_SPEAKER_SIDE_RIGHT;        // 0x0
        public static System.Int32 AK_SPEAKER_TOP;        // 0x0
        public static System.Int32 AK_SPEAKER_HEIGHT_FRONT_LEFT;        // 0x0
        public static System.Int32 AK_SPEAKER_HEIGHT_FRONT_CENTER;        // 0x0
        public static System.Int32 AK_SPEAKER_HEIGHT_FRONT_RIGHT;        // 0x0
        public static System.Int32 AK_SPEAKER_HEIGHT_BACK_LEFT;        // 0x0
        public static System.Int32 AK_SPEAKER_HEIGHT_BACK_CENTER;        // 0x0
        public static System.Int32 AK_SPEAKER_HEIGHT_BACK_RIGHT;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_MONO;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_0POINT1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_1POINT1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_STEREO;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_2POINT1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_3STEREO;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_3POINT1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_4;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_4POINT1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_5;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_5POINT1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_6;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_6POINT1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_7;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_7POINT1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_SURROUND;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DPL2;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_2;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_4;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_5;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_ALL;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_4_TOP;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_HEIGHT_5_TOP;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_222;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_8;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_9;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_9POINT1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_10;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_10POINT1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_11;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_11POINT1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_11_740;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_11POINT1_740;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_13_751;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_AURO_13POINT1_751;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_5_0_2;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_5_1_2;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_6_0_2;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_6_1_2;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_6_0_4;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_6_1_4;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_7_0_2;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_7_1_2;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_7_0_4;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DOLBY_7_1_4;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_ALL_SPEAKERS;        // 0x0
        public static System.Int32 AK_IDX_SETUP_FRONT_LEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_FRONT_RIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_CENTER;        // 0x0
        public static System.Int32 AK_IDX_SETUP_NOCENTER_BACK_LEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_NOCENTER_BACK_RIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_NOCENTER_SIDE_LEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_NOCENTER_SIDE_RIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_BACK_LEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_BACK_RIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_SIDE_LEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_LEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_RIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_LEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_RIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_0_LFE;        // 0x0
        public static System.Int32 AK_IDX_SETUP_1_CENTER;        // 0x0
        public static System.Int32 AK_IDX_SETUP_1_LFE;        // 0x0
        public static System.Int32 AK_IDX_SETUP_2_LEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_2_RIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_2_LFE;        // 0x0
        public static System.Int32 AK_IDX_SETUP_3_LEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_3_RIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_3_CENTER;        // 0x0
        public static System.Int32 AK_IDX_SETUP_3_LFE;        // 0x0
        public static System.Int32 AK_IDX_SETUP_4_FRONTLEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_4_FRONTRIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_4_REARLEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_4_REARRIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_4_LFE;        // 0x0
        public static System.Int32 AK_IDX_SETUP_5_FRONTLEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_5_FRONTRIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_5_CENTER;        // 0x0
        public static System.Int32 AK_IDX_SETUP_5_REARLEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_5_REARRIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_5_LFE;        // 0x0
        public static System.Int32 AK_IDX_SETUP_6_FRONTLEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_6_FRONTRIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_6_REARLEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_6_REARRIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_6_SIDELEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_6_SIDERIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_6_LFE;        // 0x0
        public static System.Int32 AK_IDX_SETUP_7_FRONTLEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_7_FRONTRIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_7_CENTER;        // 0x0
        public static System.Int32 AK_IDX_SETUP_7_REARLEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_7_REARRIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_7_SIDELEFT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_7_SIDERIGHT;        // 0x0
        public static System.Int32 AK_IDX_SETUP_7_LFE;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_0_1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_1_0_CENTER;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_1_1_CENTER;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_2_0;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_2_1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_3_0;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_3_1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_FRONT;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_4_0;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_4_1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_5_0;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_5_1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_6_0;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_6_1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_7_0;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_7_1;        // 0x0
        public static System.Int32 AK_SPEAKER_SETUP_DEFAULT_PLANE;        // 0x0
        public static System.Int32 AK_SUPPORTED_STANDARD_CHANNEL_MASK;        // 0x0
        public static System.Int32 AK_STANDARD_MAX_NUM_CHANNELS;        // 0x0
        public static System.Int32 AK_MAX_AMBISONICS_ORDER;        // 0x0
        public static System.Int32 AK_MAX_NUM_TEXTURE;        // 0x0
        public static System.Int32 AK_MAX_REFLECT_ORDER;        // 0x0
        public static System.Int32 AK_MAX_REFLECTION_PATH_LENGTH;        // 0x0
        public static System.Int32 AK_STOCHASTIC_RESERVE_LENGTH;        // 0x0
        public static System.Int32 AK_MAX_SOUND_PROPAGATION_DEPTH;        // 0x0
        public static System.Int32 AK_MAX_SOUND_PROPAGATION_WIDTH;        // 0x0
        public static System.Double AK_SA_DIFFRACTION_DOT_EPSILON;        // 0x0
        public static System.Double AK_DEFAULT_GEOMETRY_POSITION_X;        // 0x0
        public static System.Double AK_DEFAULT_GEOMETRY_POSITION_Y;        // 0x0
        public static System.Double AK_DEFAULT_GEOMETRY_POSITION_Z;        // 0x0
        public static System.Double AK_DEFAULT_GEOMETRY_FRONT_X;        // 0x0
        public static System.Double AK_DEFAULT_GEOMETRY_FRONT_Y;        // 0x0
        public static System.Double AK_DEFAULT_GEOMETRY_FRONT_Z;        // 0x0
        public static System.Double AK_DEFAULT_GEOMETRY_TOP_X;        // 0x0
        public static System.Double AK_DEFAULT_GEOMETRY_TOP_Y;        // 0x0
        public static System.Double AK_DEFAULT_GEOMETRY_TOP_Z;        // 0x0
        private static AkSoundEngine.GameObjectHashFunction gameObjectHash;        // 0x0
        public static System.UInt32 AK_PENDING_EVENT_LOAD_ID;        // 0x0

        // Methods
        private System.UInt32 JoystickIdToWwiseId(System.UInt32 joyStickID) { }
        private System.UInt32 get_AK_INVALID_SHARE_SET_ID() { }
        private System.UInt32 get_AK_INVALID_PIPELINE_ID() { }
        private System.UInt64 get_AK_INVALID_AUDIO_OBJECT_ID() { }
        private System.UInt32 get_AK_SOUNDBANK_VERSION() { }
        private System.UInt32 get_AkJobType_Generic() { }
        private System.UInt32 get_AkJobType_AudioProcessing() { }
        private System.UInt32 get_AkJobType_SpatialAudio() { }
        private System.UInt32 get_AK_NUM_JOB_TYPES() { }
        private UnityEngine.Vector3 ConvertAkVector64ToAkVector(AkVector64 in_) { }
        private AkTransform ConvertAkWorldTransformToAkTransform(AkWorldTransform in_) { }
        private AkVector64 ConvertAkVectorToAkVector64(UnityEngine.Vector3 in_) { }
        private AkWorldTransform ConvertAkTransformToAkWorldTransform(AkTransform in_) { }
        private System.UInt16 get_AK_INT() { }
        private System.UInt16 get_AK_FLOAT() { }
        private System.Byte get_AK_INTERLEAVED() { }
        private System.Byte get_AK_NONINTERLEAVED() { }
        private System.UInt32 get_AK_LE_NATIVE_BITSPERSAMPLE() { }
        private System.UInt32 get_AK_LE_NATIVE_SAMPLETYPE() { }
        private System.UInt32 get_AK_LE_NATIVE_INTERLEAVE() { }
        private System.Boolean IsBankCodecID(System.UInt32 in_codecID) { }
        private System.UInt32 DynamicSequenceOpen(System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType) { }
        private System.UInt32 DynamicSequenceOpen(System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        private System.UInt32 DynamicSequenceOpen(System.UInt64 in_gameObjectID) { }
        private AKRESULT DynamicSequenceClose(System.UInt32 in_playingID) { }
        private AKRESULT DynamicSequencePlay(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT DynamicSequencePlay(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        private AKRESULT DynamicSequencePlay(System.UInt32 in_playingID) { }
        private AKRESULT DynamicSequencePause(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT DynamicSequencePause(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        private AKRESULT DynamicSequencePause(System.UInt32 in_playingID) { }
        private AKRESULT DynamicSequenceResume(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT DynamicSequenceResume(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        private AKRESULT DynamicSequenceResume(System.UInt32 in_playingID) { }
        private AKRESULT DynamicSequenceStop(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT DynamicSequenceStop(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        private AKRESULT DynamicSequenceStop(System.UInt32 in_playingID) { }
        private AKRESULT DynamicSequenceBreak(System.UInt32 in_playingID) { }
        private AKRESULT Seek(System.UInt32 in_playingID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker) { }
        private AKRESULT Seek(System.UInt32 in_playingID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker) { }
        private AKRESULT DynamicSequenceGetPauseTimes(System.UInt32 in_playingID, System.UInt32& out_uTime, System.UInt32& out_uDuration) { }
        private AkPlaylist DynamicSequenceLockPlaylist(System.UInt32 in_playingID) { }
        private AKRESULT DynamicSequenceUnlockPlaylist(System.UInt32 in_playingID) { }
        private System.Boolean IsInitialized() { }
        private AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings) { }
        private AkChannelConfig GetSpeakerConfiguration(System.UInt64 in_idOutput) { }
        private AkChannelConfig GetSpeakerConfiguration() { }
        private AKRESULT GetOutputDeviceConfiguration(System.UInt64 in_idOutput, AkChannelConfig io_channelConfig, Ak3DAudioSinkCapabilities io_capabilities) { }
        private AKRESULT GetPanningRule(System.Int32& out_ePanningRule, System.UInt64 in_idOutput) { }
        private AKRESULT GetPanningRule(System.Int32& out_ePanningRule) { }
        private AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, System.UInt64 in_idOutput) { }
        private AKRESULT SetPanningRule(AkPanningRule in_ePanningRule) { }
        private AKRESULT GetSpeakerAngles(System.Single[] io_pfSpeakerAngles, System.UInt32& io_uNumAngles, System.Single& out_fHeightAngle, System.UInt64 in_idOutput) { }
        private AKRESULT GetSpeakerAngles(System.Single[] io_pfSpeakerAngles, System.UInt32& io_uNumAngles, System.Single& out_fHeightAngle) { }
        private AKRESULT SetSpeakerAngles(System.Single[] in_pfSpeakerAngles, System.UInt32 in_uNumAngles, System.Single in_fHeightAngle, System.UInt64 in_idOutput) { }
        private AKRESULT SetSpeakerAngles(System.Single[] in_pfSpeakerAngles, System.UInt32 in_uNumAngles, System.Single in_fHeightAngle) { }
        private AKRESULT SetVolumeThreshold(System.Single in_fVolumeThresholdDB) { }
        private AKRESULT SetMaxNumVoicesLimit(System.UInt16 in_maxNumberVoices) { }
        private AKRESULT SetJobMgrMaxActiveWorkers(System.UInt32 in_jobType, System.UInt32 in_uNewMaxActiveWorkers) { }
        private AKRESULT RenderAudio(System.Boolean in_bAllowSyncRender) { }
        private AKRESULT RenderAudio() { }
        private AKRESULT RegisterPluginDLL(System.String in_DllName, System.String in_DllPath) { }
        private AKRESULT RegisterPluginDLL(System.String in_DllName) { }
        private System.Boolean IsPluginRegistered(AkPluginType in_eType, System.UInt32 in_ulCompanyID, System.UInt32 in_ulPluginID) { }
        private System.UInt32 GetIDFromString(System.String in_pszString) { }
        private System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID) { }
        private System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }
        private System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        private System.UInt32 PostEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID) { }
        private System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID) { }
        private System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }
        private System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        private System.UInt32 PostEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID) { }
        private AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID) { }
        private AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration) { }
        private AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID) { }
        private AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType) { }
        private AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID) { }
        private AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID, System.Int32 in_uTransitionDuration) { }
        private AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, System.UInt64 in_gameObjectID) { }
        private AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType) { }
        private System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_playingID) { }
        private System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts, System.Boolean in_bAbsoluteOffsets, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        private System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts, System.Boolean in_bAbsoluteOffsets) { }
        private System.UInt32 PostMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts) { }
        private AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.UInt32 in_playingID) { }
        private AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID) { }
        private AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID) { }
        private AKRESULT StopMIDIOnEvent() { }
        private AKRESULT PinEventInStreamCache(System.UInt32 in_eventID, System.SByte in_uActivePriority, System.SByte in_uInactivePriority) { }
        private AKRESULT PinEventInStreamCache(System.String in_pszEventName, System.SByte in_uActivePriority, System.SByte in_uInactivePriority) { }
        private AKRESULT UnpinEventInStreamCache(System.UInt32 in_eventID) { }
        private AKRESULT UnpinEventInStreamCache(System.String in_pszEventName) { }
        private AKRESULT GetBufferStatusForPinnedEvent(System.UInt32 in_eventID, System.Single& out_fPercentBuffered, System.Int32& out_bCachePinnedMemoryFull) { }
        private AKRESULT GetBufferStatusForPinnedEvent(System.String in_pszEventName, System.Single& out_fPercentBuffered, System.Int32& out_bCachePinnedMemoryFull) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Int32 in_iPosition) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Int32 in_iPosition) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, System.UInt64 in_gameObjectID, System.Single in_fPercent) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, System.UInt64 in_gameObjectID, System.Single in_fPercent) { }
        private System.Void CancelEventCallbackCookie(System.Object in_pCookie) { }
        private System.Void CancelEventCallbackGameObject(System.UInt64 in_gameObjectID) { }
        private System.Void CancelEventCallback(System.UInt32 in_playingID) { }
        private AKRESULT GetSourcePlayPosition(System.UInt32 in_PlayingID, System.Int32& out_puPosition, System.Boolean in_bExtrapolate) { }
        private AKRESULT GetSourcePlayPosition(System.UInt32 in_PlayingID, System.Int32& out_puPosition) { }
        private AKRESULT GetSourceStreamBuffering(System.UInt32 in_PlayingID, System.Int32& out_buffering, System.Int32& out_bIsBuffering) { }
        private System.Void StopAll(System.UInt64 in_gameObjectID) { }
        private System.Void StopAll() { }
        private System.Void StopPlayingID(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        private System.Void StopPlayingID(System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        private System.Void StopPlayingID(System.UInt32 in_playingID) { }
        private System.Void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, System.UInt32 in_playingID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        private System.Void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, System.UInt32 in_playingID, System.Int32 in_uTransitionDuration) { }
        private System.Void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, System.UInt32 in_playingID) { }
        private System.Void SetRandomSeed(System.UInt32 in_uSeed) { }
        private System.Void MuteBackgroundMusic(System.Boolean in_bMute) { }
        private System.Boolean GetBackgroundMusicMute() { }
        private AKRESULT SendPluginCustomGameData(System.UInt32 in_busID, System.UInt64 in_busObjectID, AkPluginType in_eType, System.UInt32 in_uCompanyID, System.UInt32 in_uPluginID, System.IntPtr in_pData, System.UInt32 in_uSizeInBytes) { }
        private AKRESULT UnregisterAllGameObj() { }
        private AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags) { }
        private AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType) { }
        private AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions) { }
        private AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags) { }
        private AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType) { }
        private AKRESULT SetMultiplePositions(System.UInt64 in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions) { }
        private AKRESULT SetScalingFactor(System.UInt64 in_GameObjectID, System.Single in_fAttenuationScalingFactor) { }
        private AKRESULT SetDistanceProbe(System.UInt64 in_listenerGameObjectID, System.UInt64 in_distanceProbeGameObjectID) { }
        private AKRESULT ClearBanks() { }
        private AKRESULT SetBankLoadIOSettings(System.Single in_fThroughput, System.SByte in_priority) { }
        private AKRESULT LoadBank(System.String in_pszString, System.UInt32& out_bankID, System.UInt32 in_bankType) { }
        private AKRESULT LoadBank(System.String in_pszString, System.UInt32& out_bankID) { }
        private AKRESULT LoadBank(System.UInt32 in_bankID, System.UInt32 in_bankType) { }
        private AKRESULT LoadBank(System.UInt32 in_bankID) { }
        private AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID) { }
        private AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID, System.UInt32& out_bankType) { }
        private AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID) { }
        private AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, System.UInt32& out_bankID, System.UInt32& out_bankType) { }
        private AKRESULT LoadBank(System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID, System.UInt32 in_bankType) { }
        private AKRESULT LoadBank(System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID) { }
        private AKRESULT LoadBank(System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32 in_bankType) { }
        private AKRESULT LoadBank(System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        private AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID) { }
        private AKRESULT LoadBankMemoryView(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID, System.UInt32& out_bankType) { }
        private AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID) { }
        private AKRESULT LoadBankMemoryCopy(System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32& out_bankID, System.UInt32& out_bankType) { }
        private AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_bankType) { }
        private AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr) { }
        private AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr, System.UInt32 in_bankType) { }
        private AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr) { }
        private AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32 in_bankType) { }
        private AKRESULT UnloadBank(System.String in_pszString, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        private AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, System.UInt32 in_bankType) { }
        private AKRESULT UnloadBank(System.UInt32 in_bankID, System.IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        private System.Void CancelBankCallbackCookie(System.Object in_pCookie) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkBankContent in_uFlags, System.UInt32 in_bankType) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkBankContent in_uFlags) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkBankContent in_uFlags, System.UInt32 in_bankType) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkBankContent in_uFlags) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags, System.UInt32 in_bankType) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.String in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags, System.UInt32 in_bankType) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie, AkBankContent in_uFlags) { }
        private AKRESULT PrepareBank(AkPreparationType in_PreparationType, System.UInt32 in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        private AKRESULT ClearPreparedEvents() { }
        private AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.String[] in_ppszString, System.UInt32 in_uNumEvent) { }
        private AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.UInt32[] in_pEventID, System.UInt32 in_uNumEvent) { }
        private AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.String[] in_ppszString, System.UInt32 in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        private AKRESULT PrepareEvent(AkPreparationType in_PreparationType, System.UInt32[] in_pEventID, System.UInt32 in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        private AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, System.UInt32 in_uNumSourceSettings) { }
        private AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, System.UInt32 in_uNumSourceSettings) { }
        private AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.String in_pszGroupName, System.String[] in_ppszGameSyncName, System.UInt32 in_uNumGameSyncs) { }
        private AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.UInt32 in_GroupID, System.UInt32[] in_paGameSyncID, System.UInt32 in_uNumGameSyncs) { }
        private AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.String in_pszGroupName, System.String[] in_ppszGameSyncName, System.UInt32 in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        private AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, System.UInt32 in_GroupID, System.UInt32[] in_paGameSyncID, System.UInt32 in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, System.Object in_pCookie) { }
        private AKRESULT AddListener(System.UInt64 in_emitterGameObj, System.UInt64 in_listenerGameObj) { }
        private AKRESULT RemoveListener(System.UInt64 in_emitterGameObj, System.UInt64 in_listenerGameObj) { }
        private AKRESULT AddDefaultListener(System.UInt64 in_listenerGameObj) { }
        private AKRESULT RemoveDefaultListener(System.UInt64 in_listenerGameObj) { }
        private AKRESULT ResetListenersToDefault(System.UInt64 in_emitterGameObj) { }
        private AKRESULT SetListenerSpatialization(System.UInt64 in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig, System.Single[] in_pVolumeOffsets) { }
        private AKRESULT SetListenerSpatialization(System.UInt64 in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig) { }
        private AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, System.UInt64 in_gameObjectID) { }
        private AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value) { }
        private AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, System.UInt64 in_gameObjectID) { }
        private AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value) { }
        private AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT SetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.Single in_value, System.UInt32 in_playingID) { }
        private AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT SetRTPCValueByPlayingID(System.String in_pszRtpcName, System.Single in_value, System.UInt32 in_playingID) { }
        private AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID) { }
        private AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID) { }
        private AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT ResetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID) { }
        private AKRESULT ResetRTPCValue(System.String in_pszRtpcName) { }
        private AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT ResetRTPCValueByPlayingID(System.UInt32 in_rtpcID, System.UInt32 in_playingID) { }
        private AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT ResetRTPCValueByPlayingID(System.String in_pszRtpcName, System.UInt32 in_playingID) { }
        private AKRESULT SetSwitch(System.UInt32 in_switchGroup, System.UInt32 in_switchState, System.UInt64 in_gameObjectID) { }
        private AKRESULT SetSwitch(System.String in_pszSwitchGroup, System.String in_pszSwitchState, System.UInt64 in_gameObjectID) { }
        private AKRESULT PostTrigger(System.UInt32 in_triggerID, System.UInt64 in_gameObjectID) { }
        private AKRESULT PostTrigger(System.String in_pszTrigger, System.UInt64 in_gameObjectID) { }
        private AKRESULT SetState(System.UInt32 in_stateGroup, System.UInt32 in_state) { }
        private AKRESULT SetState(System.String in_pszStateGroup, System.String in_pszState) { }
        private AKRESULT SetGameObjectAuxSendValues(System.UInt64 in_gameObjectID, AkAuxSendArray in_aAuxSendValues, System.UInt32 in_uNumSendValues) { }
        private AKRESULT SetGameObjectOutputBusVolume(System.UInt64 in_emitterObjID, System.UInt64 in_listenerObjID, System.Single in_fControlValue) { }
        private AKRESULT SetActorMixerEffect(System.UInt32 in_audioNodeID, System.UInt32 in_uFXIndex, System.UInt32 in_shareSetID) { }
        private AKRESULT SetBusEffect(System.UInt32 in_audioNodeID, System.UInt32 in_uFXIndex, System.UInt32 in_shareSetID) { }
        private AKRESULT SetBusEffect(System.String in_pszBusName, System.UInt32 in_uFXIndex, System.UInt32 in_shareSetID) { }
        private AKRESULT SetOutputDeviceEffect(System.UInt64 in_outputDeviceID, System.UInt32 in_uFXIndex, System.UInt32 in_FXShareSetID) { }
        private AKRESULT SetMixer(System.UInt32 in_audioNodeID, System.UInt32 in_shareSetID) { }
        private AKRESULT SetMixer(System.String in_pszBusName, System.UInt32 in_shareSetID) { }
        private AKRESULT SetBusConfig(System.UInt32 in_audioNodeID, AkChannelConfig in_channelConfig) { }
        private AKRESULT SetBusConfig(System.String in_pszBusName, AkChannelConfig in_channelConfig) { }
        private AKRESULT SetObjectObstructionAndOcclusion(System.UInt64 in_EmitterID, System.UInt64 in_ListenerID, System.Single in_fObstructionLevel, System.Single in_fOcclusionLevel) { }
        private AKRESULT SetMultipleObstructionAndOcclusion(System.UInt64 in_EmitterID, System.UInt64 in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, System.UInt32 in_uNumOcclusionObstruction) { }
        private AKRESULT StartOutputCapture(System.String in_CaptureFileName) { }
        private AKRESULT StopOutputCapture() { }
        private AKRESULT AddOutputCaptureMarker(System.String in_MarkerText) { }
        private AKRESULT AddOutputCaptureBinaryMarker(System.IntPtr in_pMarkerData, System.UInt32 in_uMarkerDataSize) { }
        private System.UInt32 GetSampleRate() { }
        private AKRESULT StartProfilerCapture(System.String in_CaptureFileName) { }
        private AKRESULT StopProfilerCapture() { }
        private AKRESULT SetOfflineRenderingFrameTime(System.Single in_fFrameTimeInSeconds) { }
        private AKRESULT SetOfflineRendering(System.Boolean in_bEnableOfflineRendering) { }
        private AKRESULT RemoveOutput(System.UInt64 in_idOutput) { }
        private AKRESULT ReplaceOutput(AkOutputSettings in_Settings, System.UInt64 in_outputDeviceId, System.UInt64& out_pOutputDeviceId) { }
        private AKRESULT ReplaceOutput(AkOutputSettings in_Settings, System.UInt64 in_outputDeviceId) { }
        private System.UInt64 GetOutputID(System.UInt32 in_idShareset, System.UInt32 in_idDevice) { }
        private System.UInt64 GetOutputID(System.String in_szShareSet, System.UInt32 in_idDevice) { }
        private AKRESULT SetBusDevice(System.UInt32 in_idBus, System.UInt32 in_idNewDevice) { }
        private AKRESULT SetBusDevice(System.String in_BusName, System.String in_DeviceName) { }
        private AKRESULT GetDeviceList(System.UInt32 in_ulCompanyID, System.UInt32 in_ulPluginID, System.UInt32& io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions) { }
        private AKRESULT GetDeviceList(System.UInt32 in_audioDeviceShareSetID, System.UInt32& io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions) { }
        private AKRESULT SetOutputVolume(System.UInt64 in_idOutput, System.Single in_fVolume) { }
        private AKRESULT GetDeviceSpatialAudioSupport(System.UInt32 in_idDevice) { }
        private AKRESULT Suspend(System.Boolean in_bRenderAnyway, System.Boolean in_bFadeOut) { }
        private AKRESULT Suspend(System.Boolean in_bRenderAnyway) { }
        private AKRESULT Suspend() { }
        private AKRESULT WakeupFromSuspend(System.UInt32 in_uDelayMs) { }
        private AKRESULT WakeupFromSuspend() { }
        private System.UInt32 GetBufferTick() { }
        private System.UInt64 GetSampleTick() { }
        private System.Byte get_AK_INVALID_MIDI_CHANNEL() { }
        private System.Byte get_AK_INVALID_MIDI_NOTE() { }
        private System.Void AkMemGetCategoryStats(System.Int32 in_poolId, AkMemCategroyStats out_poolStats) { }
        private System.Void AkMemGetGlobalStats(AkMemGlobalStats out_stats) { }
        private System.Void StartProfileThreadUsage() { }
        private System.UInt64 StopProfileThreadUsage() { }
        private System.Void DumpToFile(System.String pszFilename) { }
        private System.UInt64 GetGlobalUsed() { }
        private System.UInt64 GetGlobalReserved() { }
        private AKRESULT GetPlayingSegmentInfo(System.UInt32 in_PlayingID, AkSegmentInfo out_segmentInfo, System.Boolean in_bExtrapolate) { }
        private AKRESULT GetPlayingSegmentInfo(System.UInt32 in_PlayingID, AkSegmentInfo out_segmentInfo) { }
        private AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus) { }
        private AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID) { }
        private AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID) { }
        private AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID) { }
        private AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel) { }
        private AKRESULT PostCodeVarArg(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, MsgContext msgContext) { }
        private AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus) { }
        private AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.UInt32 in_audioNodeID) { }
        private AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID) { }
        private AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID) { }
        private AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel) { }
        private AKRESULT ResetTranslator() { }
        private System.Int32 GetTimeStamp() { }
        private System.Void MonitorStreamMgrInit(AkStreamMgrSettings in_streamMgrSettings) { }
        private System.Void MonitorStreamingDeviceInit(System.UInt32 in_deviceID, AkDeviceSettings in_deviceSettings) { }
        private System.Void MonitorStreamingDeviceDestroyed(System.UInt32 in_deviceID) { }
        private System.Void MonitorStreamMgrTerm() { }
        private System.Void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties) { }
        private System.UInt32 ResolveDialogueEvent(System.UInt32 in_eventID, System.UInt32[] in_aArgumentValues, System.UInt32 in_uNumArguments, System.UInt32 in_idSequence) { }
        private System.UInt32 ResolveDialogueEvent(System.UInt32 in_eventID, System.UInt32[] in_aArgumentValues, System.UInt32 in_uNumArguments) { }
        private AKRESULT GetDialogueEventCustomPropertyValue(System.UInt32 in_eventID, System.UInt32 in_uPropID, System.Int32& out_iValue) { }
        private AKRESULT GetDialogueEventCustomPropertyValue(System.UInt32 in_eventID, System.UInt32 in_uPropID, System.Single& out_fValue) { }
        private AKRESULT GetPosition(System.UInt64 in_GameObjectID, AkWorldTransform out_rPosition) { }
        private AKRESULT GetListenerPosition(System.UInt64 in_uListenerID, AkWorldTransform out_rPosition) { }
        private AKRESULT GetRTPCValue(System.UInt32 in_rtpcID, System.UInt64 in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType) { }
        private AKRESULT GetRTPCValue(System.String in_pszRtpcName, System.UInt64 in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType) { }
        private AKRESULT GetSwitch(System.UInt32 in_switchGroup, System.UInt64 in_gameObjectID, System.UInt32& out_rSwitchState) { }
        private AKRESULT GetSwitch(System.String in_pstrSwitchGroupName, System.UInt64 in_GameObj, System.UInt32& out_rSwitchState) { }
        private AKRESULT GetState(System.UInt32 in_stateGroup, System.UInt32& out_rState) { }
        private AKRESULT GetState(System.String in_pstrStateGroupName, System.UInt32& out_rState) { }
        private AKRESULT GetGameObjectAuxSendValues(System.UInt64 in_gameObjectID, AkAuxSendArray out_paAuxSendValues, System.UInt32& io_ruNumSendValues) { }
        private AKRESULT GetGameObjectDryLevelValue(System.UInt64 in_EmitterID, System.UInt64 in_ListenerID, System.Single& out_rfControlValue) { }
        private AKRESULT GetObjectObstructionAndOcclusion(System.UInt64 in_EmitterID, System.UInt64 in_ListenerID, System.Single& out_rfObstructionLevel, System.Single& out_rfOcclusionLevel) { }
        private AKRESULT QueryAudioObjectIDs(System.UInt32 in_eventID, System.UInt32& io_ruNumItems, AkObjectInfoArray out_aObjectInfos) { }
        private AKRESULT QueryAudioObjectIDs(System.String in_pszEventName, System.UInt32& io_ruNumItems, AkObjectInfoArray out_aObjectInfos) { }
        private AKRESULT GetPositioningInfo(System.UInt32 in_ObjectID, AkPositioningInfo out_rPositioningInfo) { }
        private System.Boolean GetIsGameObjectActive(System.UInt64 in_GameObjId) { }
        private System.Single GetMaxRadius(System.UInt64 in_GameObjId) { }
        private System.UInt32 GetEventIDFromPlayingID(System.UInt32 in_playingID) { }
        private System.UInt64 GetGameObjectFromPlayingID(System.UInt32 in_playingID) { }
        private AKRESULT GetPlayingIDsFromGameObject(System.UInt64 in_GameObjId, System.UInt32& io_ruNumIDs, System.UInt32[] out_aPlayingIDs) { }
        private AKRESULT GetCustomPropertyValue(System.UInt32 in_ObjectID, System.UInt32 in_uPropID, System.Int32& out_iValue) { }
        private AKRESULT GetCustomPropertyValue(System.UInt32 in_ObjectID, System.UInt32 in_uPropID, System.Single& out_fValue) { }
        private System.Void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(System.UInt32& io_uChannelMask) { }
        private System.Void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(System.UInt32& io_uChannelMask) { }
        private System.Void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(System.UInt32& io_uChannelMask) { }
        private System.Byte ChannelMaskToNumChannels(System.UInt32 in_uChannelMask) { }
        private System.UInt32 ChannelMaskFromNumChannels(System.UInt32 in_uNumChannels) { }
        private System.Byte ChannelBitToIndex(System.UInt32 in_uChannelBit, System.UInt32 in_uChannelMask) { }
        private System.Boolean HasSurroundChannels(System.UInt32 in_uChannelMask) { }
        private System.Boolean HasStrictlyOnePairOfSurroundChannels(System.UInt32 in_uChannelMask) { }
        private System.Boolean HasSideAndRearChannels(System.UInt32 in_uChannelMask) { }
        private System.Boolean HasHeightChannels(System.UInt32 in_uChannelMask) { }
        private System.UInt32 BackToSideChannels(System.UInt32 in_uChannelMask) { }
        private System.UInt32 StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, System.UInt32 in_uChannelMask, System.UInt32 in_uChannelIdx) { }
        private System.UInt32 get_kDefaultDiffractionMaxEdges() { }
        private System.UInt32 get_kDefaultDiffractionMaxPaths() { }
        private System.Single get_kMaxDiffraction() { }
        private System.UInt32 get_kHashListBlockAllocItemCount() { }
        private System.UInt32 get_kDiffractionMaxEdges() { }
        private System.UInt32 get_kDiffractionMaxPaths() { }
        private System.UInt32 get_kPortalToPortalDiffractionMaxPaths() { }
        private AKRESULT SetGameObjectRadius(System.UInt64 in_gameObjectID, System.Single in_outerRadius, System.Single in_innerRadius) { }
        private AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_name, System.UInt32 in_AuxBusID, System.UInt64 in_gameObjectID) { }
        private AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_name, System.UInt32 in_AuxBusID) { }
        private AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_name) { }
        private AKRESULT RemoveImageSource(System.UInt32 in_srcID, System.UInt32 in_AuxBusID, System.UInt64 in_gameObjectID) { }
        private AKRESULT RemoveImageSource(System.UInt32 in_srcID, System.UInt32 in_AuxBusID) { }
        private AKRESULT RemoveImageSource(System.UInt32 in_srcID) { }
        private AKRESULT ClearImageSources(System.UInt32 in_AuxBusID, System.UInt64 in_gameObjectID) { }
        private AKRESULT ClearImageSources(System.UInt32 in_AuxBusID) { }
        private AKRESULT ClearImageSources() { }
        private AKRESULT RemoveGeometry(System.UInt64 in_SetID) { }
        private AKRESULT RemoveGeometryInstance(System.UInt64 in_GeometryInstanceID) { }
        private AKRESULT RemoveRoom(System.UInt64 in_RoomID) { }
        private AKRESULT RemovePortal(System.UInt64 in_PortalID) { }
        private AKRESULT SetReverbZone(System.UInt64 in_ReverbZone, System.UInt64 in_ParentRoom, System.Single in_transitionRegionWidth) { }
        private AKRESULT RemoveReverbZone(System.UInt64 in_ReverbZone) { }
        private AKRESULT SetGameObjectInRoom(System.UInt64 in_gameObjectID, System.UInt64 in_CurrentRoomID) { }
        private AKRESULT UnsetGameObjectInRoom(System.UInt64 in_gameObjectID) { }
        private AKRESULT SetReflectionsOrder(System.UInt32 in_uReflectionsOrder, System.Boolean in_bUpdatePaths) { }
        private AKRESULT SetDiffractionOrder(System.UInt32 in_uDiffractionOrder, System.Boolean in_bUpdatePaths) { }
        private AKRESULT SetMaxEmitterRoomAuxSends(System.UInt32 in_uMaxEmitterRoomAuxSends) { }
        private AKRESULT SetNumberOfPrimaryRays(System.UInt32 in_uNbPrimaryRays) { }
        private AKRESULT SetLoadBalancingSpread(System.UInt32 in_uNbFrames) { }
        private AKRESULT SetEarlyReflectionsAuxSend(System.UInt64 in_gameObjectID, System.UInt32 in_auxBusID) { }
        private AKRESULT SetEarlyReflectionsVolume(System.UInt64 in_gameObjectID, System.Single in_fSendVolume) { }
        private AKRESULT SetPortalObstructionAndOcclusion(System.UInt64 in_PortalID, System.Single in_fObstruction, System.Single in_fOcclusion) { }
        private AKRESULT SetGameObjectToPortalObstruction(System.UInt64 in_gameObjectID, System.UInt64 in_PortalID, System.Single in_fObstruction) { }
        private AKRESULT SetPortalToPortalObstruction(System.UInt64 in_PortalID0, System.UInt64 in_PortalID1, System.Single in_fObstruction) { }
        private AKRESULT QueryWetDiffraction(System.UInt64 in_portal, System.Single& out_wetDiffraction) { }
        private AKRESULT ResetStochasticEngine() { }
        private System.UInt32 GetDeviceIDFromName(System.String in_szToken) { }
        private System.String GetWindowsDeviceName(System.Int32 index, System.UInt32& out_uDeviceID, AkAudioDeviceState uDeviceStateMask) { }
        private System.String GetWindowsDeviceName(System.Int32 index, System.UInt32& out_uDeviceID) { }
        private System.UInt32 GetWindowsDeviceCount(AkAudioDeviceState uDeviceStateMask) { }
        private System.UInt32 GetWindowsDeviceCount() { }
        private System.Void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger) { }
        private System.Void SetErrorLogger() { }
        private System.Void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat) { }
        private AKRESULT Init(AkInitializationSettings settings) { }
        private AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings) { }
        private AKRESULT InitCommunication(AkCommunicationSettings settings) { }
        private System.Void Term() { }
        private AKRESULT RegisterGameObjInternal(System.UInt64 in_GameObj) { }
        private AKRESULT UnregisterGameObjInternal(System.UInt64 in_GameObj) { }
        private AKRESULT RegisterGameObjInternal_WithName(System.UInt64 in_GameObj, System.String in_pszObjName) { }
        private AKRESULT SetBasePath(System.String in_pszBasePath) { }
        private AKRESULT SetCurrentLanguage(System.String in_pszAudioSrcPath) { }
        private AKRESULT LoadFilePackage(System.String in_pszFilePackageName, System.UInt32& out_uPackageID) { }
        private AKRESULT AddBasePath(System.String in_pszBasePath) { }
        private AKRESULT SetGameName(System.String in_GameName) { }
        private System.String GetCurrentLanguage() { }
        private AKRESULT UnloadFilePackage(System.UInt32 in_uPackageID) { }
        private AKRESULT UnloadAllFilePackages() { }
        private AKRESULT SetObjectPosition(System.UInt64 in_GameObjectID, UnityEngine.Vector3 Pos, UnityEngine.Vector3 Front, UnityEngine.Vector3 Top) { }
        private AKRESULT GetSourceMultiplePlayPositions(System.UInt32 in_PlayingID, System.UInt32[] out_audioNodeID, System.UInt32[] out_mediaID, System.Int32[] out_msTime, System.UInt32& io_pcPositions, System.Boolean in_bExtrapolate) { }
        private AKRESULT GetSourceMultiplePlayPositions(System.UInt32 in_PlayingID, System.UInt32[] out_audioNodeID, System.UInt32[] out_mediaID, System.Int32[] out_msTime, System.UInt32& io_pcPositions) { }
        private AKRESULT SetListeners(System.UInt64 in_emitterGameObj, System.UInt64[] in_pListenerGameObjs, System.UInt32 in_uNumListeners) { }
        private AKRESULT SetDefaultListeners(System.UInt64[] in_pListenerObjs, System.UInt32 in_uNumListeners) { }
        private System.UInt32 GetNumOutputDevices(System.UInt32 in_AudioDeviceShareSetID) { }
        private AKRESULT AddOutput(AkOutputSettings in_Settings, System.UInt64& out_pDeviceID, System.UInt64[] in_pListenerIDs, System.UInt32 in_uNumListeners) { }
        private AKRESULT AddOutput(AkOutputSettings in_Settings, System.UInt64& out_pDeviceID, System.UInt64[] in_pListenerIDs) { }
        private AKRESULT AddOutput(AkOutputSettings in_Settings, System.UInt64& out_pDeviceID) { }
        private AKRESULT AddOutput(AkOutputSettings in_Settings) { }
        private System.Void GetDefaultStreamSettings(AkStreamMgrSettings out_settings) { }
        private System.Void GetDefaultDeviceSettings(AkDeviceSettings out_settings) { }
        private System.Void GetDefaultMusicSettings(AkMusicSettings out_settings) { }
        private System.Void GetDefaultInitSettings(AkInitSettings out_settings) { }
        private System.Void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings) { }
        private System.UInt32 GetMajorMinorVersion() { }
        private System.UInt32 GetSubminorBuildVersion() { }
        private System.Void StartResourceMonitoring() { }
        private System.Void StopResourceMonitoring() { }
        private System.Void GetResourceMonitorDataSummary(AkResourceMonitorDataSummary resourceMonitorDataSummary) { }
        private System.Void StartDeviceCapture(System.UInt64 in_idOutputDeviceID) { }
        private System.Void StopDeviceCapture(System.UInt64 in_idOutputDeviceID) { }
        private System.Void ClearCaptureData() { }
        private System.UInt32 UpdateCaptureSampleCount(System.UInt64 in_idOutputDeviceID) { }
        private System.UInt32 GetCaptureSamples(System.UInt64 in_idOutputDeviceID, System.Single[] out_pSamples, System.UInt32 in_uBufferSize) { }
        private AKRESULT SetRoomPortal(System.UInt64 in_PortalID, System.UInt64 FrontRoom, System.UInt64 BackRoom, AkTransform Transform, AkExtent Extent, System.Boolean bEnabled, System.String in_pName) { }
        private AKRESULT SetRoom(System.UInt64 in_RoomID, AkRoomParams in_roomParams, System.UInt64 GeometryInstanceID, System.String in_pName) { }
        private AKRESULT RegisterSpatialAudioListener(System.UInt64 in_gameObjectID) { }
        private AKRESULT UnregisterSpatialAudioListener(System.UInt64 in_gameObjectID) { }
        private AKRESULT SetGeometry(System.UInt64 in_GeomSetID, AkTriangleArray Triangles, System.UInt32 NumTriangles, UnityEngine.Vector3[] Vertices, System.UInt32 NumVertices, AkAcousticSurfaceArray Surfaces, System.UInt32 NumSurfaces, System.Boolean EnableDiffraction, System.Boolean EnableDiffractionOnBoundaryEdges) { }
        private AKRESULT SetGeometryInstance(System.UInt64 in_GeomInstanceID, AkTransform Transform, UnityEngine.Vector3 Scale, System.UInt64 GeometrySetID, System.UInt64 RoomID, System.Boolean UseForReflectionAndDiffraction) { }
        private AKRESULT QueryReflectionPaths(System.UInt64 in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkReflectionPathInfoArray out_aPaths, System.UInt32& io_uArraySize) { }
        private AKRESULT QueryDiffractionPaths(System.UInt64 in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkDiffractionPathInfoArray out_aPaths, System.UInt32& io_uArraySize) { }
        private System.Void PerformStreamMgrIO() { }
        private System.Void HgMemShrink() { }
        private System.UInt64 HgGetGlobalMemoryUsed() { }
        private System.UInt64 HgGetGlobalMemoryReserved() { }
        private System.Void InitScePad() { }
        private System.UInt32 GetMMDeviceIdFromPadContainerInfo(System.Int32 in_padHandle) { }
        private System.String StringFromIntPtrString(System.IntPtr ptr) { }
        private System.String StringFromIntPtrWString(System.IntPtr ptr) { }
        private System.UInt64 InternalGameObjectHash(UnityEngine.GameObject gameObject) { }
        private System.Void set_GameObjectHash(AkSoundEngine.GameObjectHashFunction value) { }
        private System.UInt64 GetAkGameObjectID(UnityEngine.GameObject gameObject) { }
        private AKRESULT RegisterGameObj(UnityEngine.GameObject gameObject) { }
        private AKRESULT RegisterGameObj(UnityEngine.GameObject gameObject, System.String name) { }
        private AKRESULT UnregisterGameObj(UnityEngine.GameObject gameObject) { }
        private System.Void UnregisterAllGameObjects() { }
        private System.String get_WwiseVersion() { }
        private AKRESULT SetObjectPosition(UnityEngine.GameObject gameObject, UnityEngine.Transform transform) { }
        private AKRESULT SetObjectPosition(UnityEngine.GameObject gameObject, System.Single posX, System.Single posY, System.Single posZ, System.Single frontX, System.Single frontY, System.Single frontZ, System.Single topX, System.Single topY, System.Single topZ) { }
        private System.Void PreGameObjectAPICall(UnityEngine.GameObject gameObject, System.UInt64 id) { }
        private System.UInt32 DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType) { }
        private System.UInt32 DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        private System.UInt32 DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID) { }
        private System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID) { }
        private System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }
        private System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        private System.UInt32 PostEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID) { }
        private System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources, System.UInt32 in_PlayingID) { }
        private System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie, System.UInt32 in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }
        private System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, System.Object in_pCookie) { }
        private System.UInt32 PostEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID) { }
        private AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration) { }
        private AKRESULT ExecuteActionOnEvent(System.UInt32 in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, System.UInt32 in_PlayingID) { }
        private AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uTransitionDuration) { }
        private AKRESULT ExecuteActionOnEvent(System.String in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT PostMIDIOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, System.UInt16 in_uNumPosts) { }
        private AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT StopMIDIOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_playingID) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition, System.Boolean in_bSeekToNearestMarker) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_iPosition) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker) { }
        private AKRESULT SeekOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker, System.UInt32 in_PlayingID) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent, System.Boolean in_bSeekToNearestMarker) { }
        private AKRESULT SeekOnEvent(System.String in_pszEventName, UnityEngine.GameObject in_gameObjectID, System.Single in_fPercent) { }
        private System.Void CancelEventCallbackGameObject(UnityEngine.GameObject in_gameObjectID) { }
        private System.Void StopAll(UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT SendPluginCustomGameData(System.UInt32 in_busID, UnityEngine.GameObject in_busObjectID, AkPluginType in_eType, System.UInt32 in_uCompanyID, System.UInt32 in_uPluginID, System.IntPtr in_pData, System.UInt32 in_uSizeInBytes) { }
        private AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType) { }
        private AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkPositionArray in_pPositions, System.UInt16 in_NumPositions) { }
        private AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions, AkMultiPositionType in_eMultiPositionType) { }
        private AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, System.UInt16 in_NumPositions) { }
        private AKRESULT SetScalingFactor(UnityEngine.GameObject in_GameObjectID, System.Single in_fAttenuationScalingFactor) { }
        private AKRESULT AddListener(UnityEngine.GameObject in_emitterGameObj, UnityEngine.GameObject in_listenerGameObj) { }
        private AKRESULT RemoveListener(UnityEngine.GameObject in_emitterGameObj, UnityEngine.GameObject in_listenerGameObj) { }
        private AKRESULT AddDefaultListener(UnityEngine.GameObject in_listenerGameObj) { }
        private AKRESULT RemoveDefaultListener(UnityEngine.GameObject in_listenerGameObj) { }
        private AKRESULT ResetListenersToDefault(UnityEngine.GameObject in_emitterGameObj) { }
        private AKRESULT SetListenerSpatialization(UnityEngine.GameObject in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig, System.Single[] in_pVolumeOffsets) { }
        private AKRESULT SetListenerSpatialization(UnityEngine.GameObject in_uListenerID, System.Boolean in_bSpatialized, AkChannelConfig in_channelConfig) { }
        private AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT SetRTPCValue(System.UInt32 in_rtpcID, System.Single in_value, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT SetRTPCValue(System.String in_pszRtpcName, System.Single in_value, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT ResetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, System.Boolean in_bBypassInternalValueInterpolation) { }
        private AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }
        private AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.Int32 in_uValueChangeDuration) { }
        private AKRESULT ResetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT SetSwitch(System.UInt32 in_switchGroup, System.UInt32 in_switchState, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT SetSwitch(System.String in_pszSwitchGroup, System.String in_pszSwitchState, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT PostTrigger(System.UInt32 in_triggerID, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT PostTrigger(System.String in_pszTrigger, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT SetGameObjectAuxSendValues(UnityEngine.GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, System.UInt32 in_uNumSendValues) { }
        private AKRESULT SetGameObjectOutputBusVolume(UnityEngine.GameObject in_emitterObjID, UnityEngine.GameObject in_listenerObjID, System.Single in_fControlValue) { }
        private AKRESULT SetObjectObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, System.Single in_fObstructionLevel, System.Single in_fOcclusionLevel) { }
        private AKRESULT SetMultipleObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, System.UInt32 in_uNumOcclusionObstruction) { }
        private AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus) { }
        private AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID) { }
        private AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID) { }
        private AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID, System.Boolean in_bIsBus) { }
        private AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID, System.UInt32 in_audioNodeID) { }
        private AKRESULT PostString(System.String in_pszError, AkMonitorErrorLevel in_eErrorLevel, System.UInt32 in_playingID, UnityEngine.GameObject in_gameObjID) { }
        private AKRESULT GetPosition(UnityEngine.GameObject in_GameObjectID, AkTransform out_rPosition) { }
        private AKRESULT GetListenerPosition(UnityEngine.GameObject in_uIndex, AkTransform out_rPosition) { }
        private AKRESULT GetRTPCValue(System.UInt32 in_rtpcID, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType) { }
        private AKRESULT GetRTPCValue(System.String in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, System.UInt32 in_playingID, System.Single& out_rValue, System.Int32& io_rValueType) { }
        private AKRESULT GetSwitch(System.UInt32 in_switchGroup, UnityEngine.GameObject in_gameObjectID, System.UInt32& out_rSwitchState) { }
        private AKRESULT GetSwitch(System.String in_pstrSwitchGroupName, UnityEngine.GameObject in_GameObj, System.UInt32& out_rSwitchState) { }
        private AKRESULT GetGameObjectAuxSendValues(UnityEngine.GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, System.UInt32& io_ruNumSendValues) { }
        private AKRESULT GetGameObjectDryLevelValue(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, System.Single& out_rfControlValue) { }
        private AKRESULT GetObjectObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, System.Single& out_rfObstructionLevel, System.Single& out_rfOcclusionLevel) { }
        private System.Boolean GetIsGameObjectActive(UnityEngine.GameObject in_GameObjId) { }
        private System.Single GetMaxRadius(UnityEngine.GameObject in_GameObjId) { }
        private AKRESULT GetPlayingIDsFromGameObject(UnityEngine.GameObject in_GameObjId, System.UInt32& io_ruNumIDs, System.UInt32[] out_aPlayingIDs) { }
        private AKRESULT SetImageSource(System.UInt32 in_srcID, AkImageSourceSettings in_info, System.String in_imageSourceName, System.UInt32 in_AuxBusID, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT RemoveImageSource(System.UInt32 in_srcID, System.UInt32 in_AuxBusID, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT ClearImageSources(System.UInt32 in_AuxBusID, UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT QueryReflectionPaths(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkReflectionPathInfoArray out_aPaths, System.UInt32& io_uArraySize) { }
        private AKRESULT SetGameObjectInRoom(UnityEngine.GameObject in_gameObjectID, System.UInt64 in_CurrentRoomID) { }
        private AKRESULT SetEarlyReflectionsAuxSend(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_auxBusID) { }
        private AKRESULT SetEarlyReflectionsVolume(UnityEngine.GameObject in_gameObjectID, System.Single in_fSendVolume) { }
        private AKRESULT QueryDiffractionPaths(UnityEngine.GameObject in_gameObjectID, System.UInt32 in_positionIndex, UnityEngine.Vector3& out_listenerPos, UnityEngine.Vector3& out_emitterPos, AkDiffractionPathInfoArray out_aPaths, System.UInt32& io_uArraySize) { }
        private AKRESULT RegisterGameObjInternal(UnityEngine.GameObject in_GameObj) { }
        private AKRESULT UnregisterGameObjInternal(UnityEngine.GameObject in_GameObj) { }
        private AKRESULT RegisterGameObjInternal_WithName(UnityEngine.GameObject in_GameObj, System.String in_pszObjName) { }
        private AKRESULT SetObjectPosition(UnityEngine.GameObject in_GameObjectID, UnityEngine.Vector3 Pos, UnityEngine.Vector3 Front, UnityEngine.Vector3 Top) { }
        private AKRESULT SetListeners(UnityEngine.GameObject in_emitterGameObj, System.UInt64[] in_pListenerGameObjs, System.UInt32 in_uNumListeners) { }
        private AKRESULT RegisterSpatialAudioListener(UnityEngine.GameObject in_gameObjectID) { }
        private AKRESULT UnregisterSpatialAudioListener(UnityEngine.GameObject in_gameObjectID) { }
        private System.String StringFromIntPtrOSString(System.IntPtr ptr) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006F
    public class AkThreadProperties, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkThreadProperties obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void set_nPriority(System.Int32 value) { }
        private System.Int32 get_nPriority() { }
        private System.Void set_dwAffinityMask(System.UInt32 value) { }
        private System.UInt32 get_dwAffinityMask() { }
        private System.Void set_uStackSize(System.UInt32 value) { }
        private System.UInt32 get_uStackSize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000070
    public class AkUnityPlatformSpecificSettings, IDisposable
    {
        // Fields
        private System.IntPtr swigCPtr;        // 0x10
        protected System.Boolean swigCMemOwn;        // 0x18

        // Methods
        private System.Void .ctor(System.IntPtr cPtr, System.Boolean cMemoryOwn) { }
        private System.IntPtr getCPtr(AkUnityPlatformSpecificSettings obj) { }
        private System.Void setCPtr(System.IntPtr cPtr) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x2000073
    public struct AudioAPI
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkAndroidSettings.PlatformAdvancedSettings.AudioAPI None;        // 0x0
        public static AkAndroidSettings.PlatformAdvancedSettings.AudioAPI AAudio;        // 0x0
        public static AkAndroidSettings.PlatformAdvancedSettings.AudioAPI OpenSL_ES;        // 0x0
        public static AkAndroidSettings.PlatformAdvancedSettings.AudioAPI Default;        // 0x0

    }

    // TypeToken: 0x2000072
    public class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        // Fields
        public AkAndroidSettings.PlatformAdvancedSettings.AudioAPI m_AudioAPI;        // 0x50
        public System.Boolean m_RoundFrameSizeToHardwareSize;        // 0x54
        public System.Boolean m_UseLowLatencyMode;        // 0x55

        // Methods
        private System.Void CopyTo(AkPlatformInitSettings settings) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000071
    public class AkAndroidSettings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;        // 0x30
        public AkAndroidSettings.PlatformAdvancedSettings AdvancedSettings;        // 0x38
        public AkCommonCommSettings CommsSettings;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private AkCommonUserSettings GetUserSettings() { }
        private AkCommonAdvancedSettings GetAdvancedSettings() { }
        private AkCommonCommSettings GetCommsSettings() { }

    }

    // TypeToken: 0x2000075
    public class AudioFormatDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.UInt32 playingID, AkAudioFormat format) { }
        private System.IAsyncResult BeginInvoke(System.UInt32 playingID, AkAudioFormat format, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000076
    public class AudioFormatInteropDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.UInt32 playingID, System.IntPtr format) { }
        private System.IAsyncResult BeginInvoke(System.UInt32 playingID, System.IntPtr format, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000077
    public class AudioSamplesDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.UInt32 playingID, System.UInt32 channelIndex, System.Single[] samples) { }
        private System.IAsyncResult BeginInvoke(System.UInt32 playingID, System.UInt32 channelIndex, System.Single[] samples, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000078
    public class AudioSamplesInteropDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.UInt32 playingID, System.Single[] samples, System.UInt32 channelIndex, System.UInt32 frames) { }
        private System.IAsyncResult BeginInvoke(System.UInt32 playingID, System.Single[] samples, System.UInt32 channelIndex, System.UInt32 frames, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000074
    public class AkAudioInputManager
    {
        // Fields
        private static System.Boolean initialized;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.UInt32,AkAudioInputManager.AudioSamplesDelegate> audioSamplesDelegates;        // 0x8
        private static readonly System.Collections.Generic.Dictionary<System.UInt32,AkAudioInputManager.AudioFormatDelegate> audioFormatDelegates;        // 0x10
        private static readonly AkAudioFormat audioFormat;        // 0x18
        private static readonly AkAudioInputManager.AudioSamplesInteropDelegate audioSamplesDelegate;        // 0x20
        private static readonly AkAudioInputManager.AudioFormatInteropDelegate audioFormatDelegate;        // 0x28

        // Methods
        private System.UInt32 PostAudioInputEvent(System.UInt32 akEventID, UnityEngine.GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate) { }
        private System.UInt32 PostAudioInputEvent(System.String akEventName, UnityEngine.GameObject gameObject, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate) { }
        private System.Boolean InternalAudioSamplesDelegate(System.UInt32 playingID, System.Single[] samples, System.UInt32 channelIndex, System.UInt32 frames) { }
        private System.Void InternalAudioFormatDelegate(System.UInt32 playingID, System.IntPtr format) { }
        private System.Void TryInitialize() { }
        private System.Void AddPlayingID(System.UInt32 playingID, AkAudioInputManager.AudioSamplesDelegate sampleDelegate, AkAudioInputManager.AudioFormatDelegate formatDelegate) { }
        private System.Void EventCallback(System.Object cookie, AkCallbackType type, AkCallbackInfo callbackInfo) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000079
    public class AkBasePathGetter
    {
        // Fields
        public static readonly System.String DefaultBasePath;        // 0x0
        private static System.Boolean <IsWwiseProjectAvailable>k__BackingField;        // 0x8
        private System.String <SoundBankBasePath>k__BackingField;        // 0x10
        private System.String <PersistentDataPath>k__BackingField;        // 0x18
        private static System.String <WwiseProjectFullPath>k__BackingField;        // 0x10
        private static AkBasePathGetter Instance;        // 0x18

        // Methods
        private System.String GetPlatformName() { }
        private System.Boolean get_IsWwiseProjectAvailable() { }
        private System.Void set_IsWwiseProjectAvailable(System.Boolean value) { }
        private System.String get_SoundBankBasePath() { }
        private System.Void set_SoundBankBasePath(System.String value) { }
        private System.String get_PersistentDataPath() { }
        private System.Void set_PersistentDataPath(System.String value) { }
        private System.String get_WwiseProjectFullPath() { }
        private System.Void set_WwiseProjectFullPath(System.String value) { }
        private System.String GetPlatformBasePath(System.String platformName) { }
        private AkBasePathGetter Get() { }
        private System.Void Reset() { }
        private System.Void EvaluateGamePaths() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200007B
    public class EventCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info) { }
        private System.IAsyncResult BeginInvoke(System.Object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200007C
    public class MonitoringCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.String in_msg) { }
        private System.IAsyncResult BeginInvoke(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, System.UInt32 in_playingID, System.UInt64 in_gameObjID, System.String in_msg, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200007D
    public class BankCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.UInt32 in_bankID, System.IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, System.Object in_Cookie) { }
        private System.IAsyncResult BeginInvoke(System.UInt32 in_bankID, System.IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, System.Object in_Cookie, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200007E
    public class EventCallbackPackage
    {
        // Fields
        public AkCallbackManager.EventCallback callback;        // 0x10
        public System.Object cookie;        // 0x18
        public System.UInt32 playingID;        // 0x20

        // Methods
        private System.Void Recycle(AkCallbackManager.EventCallbackPackage inPkg) { }
        private AkCallbackManager.EventCallbackPackage Create(AkCallbackManager.EventCallback inCb, System.Object inCookie, System.UInt32& ioFlags) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007F
    public class BankCallbackPackage
    {
        // Fields
        public AkCallbackManager.BankCallback callback;        // 0x10
        public System.Object cookie;        // 0x18

        // Methods
        private AkCallbackManager.BankCallbackPackage Create(AkCallbackManager.BankCallback inCb, System.Object inCookie) { }
        private System.Void Recycle(AkCallbackManager.BankCallbackPackage pkg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000080
    public class SimplePool`1
    {
        // Fields
        private readonly T[] m_pool;        // 0x0
        private readonly System.Int32 m_poolSize;        // 0x0
        private System.Int32 m_poolIndex;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 poolSize) { }
        private T Alloc() { }
        private System.Void Recycle(T obj) { }

    }

    // TypeToken: 0x2000081
    public class BGMCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private AKRESULT Invoke(System.Boolean in_bOtherAudioPlaying, System.Object in_Cookie) { }
        private System.IAsyncResult BeginInvoke(System.Boolean in_bOtherAudioPlaying, System.Object in_Cookie, System.AsyncCallback callback, System.Object object) { }
        private AKRESULT EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000082
    public class BGMCallbackPackage
    {
        // Fields
        public AkCallbackManager.BGMCallback m_Callback;        // 0x10
        public System.Object m_Cookie;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007A
    public class AkCallbackManager
    {
        // Fields
        private static readonly AkEventCallbackInfo AkEventCallbackInfo;        // 0x0
        private static readonly AkDynamicSequenceItemCallbackInfo AkDynamicSequenceItemCallbackInfo;        // 0x8
        private static readonly AkMIDIEventCallbackInfo AkMIDIEventCallbackInfo;        // 0x10
        private static readonly AkMarkerCallbackInfo AkMarkerCallbackInfo;        // 0x18
        private static readonly AkDurationCallbackInfo AkDurationCallbackInfo;        // 0x20
        private static readonly AkMusicSyncCallbackInfo AkMusicSyncCallbackInfo;        // 0x28
        private static readonly AkMusicPlaylistCallbackInfo AkMusicPlaylistCallbackInfo;        // 0x30
        private static readonly AkAudioSourceChangeCallbackInfo AkAudioSourceChangeCallbackInfo;        // 0x38
        private static readonly AkMonitoringCallbackInfo AkMonitoringCallbackInfo;        // 0x40
        private static readonly AkBankCallbackInfo AkBankCallbackInfo;        // 0x48
        private static readonly AkCallbackManager.SimplePool<AkCallbackManager.EventCallbackPackage> s_EventCallbackPackagePool;        // 0x50
        private static readonly AkCallbackManager.SimplePool<AkCallbackManager.BankCallbackPackage> s_BankCallbackPackagePool;        // 0x58
        private static readonly System.Collections.Generic.Dictionary<System.Int32,AkCallbackManager.BankCallbackPackage> s_mapBankCallbacks;        // 0x60
        private static readonly System.Collections.Generic.Dictionary<System.Int32,AkCallbackManager.EventCallbackPackage> s_mapEventCallbacks;        // 0x68
        private static AkCallbackManager.EventCallbackPackage s_lastAddedEventPackage;        // 0x70
        private static AkCallbackManager.MonitoringCallback m_MonitoringCB;        // 0x78
        private static AkCallbackManager.BGMCallbackPackage ms_sourceChangeCallbackPkg;        // 0x80

        // Methods
        private System.Int32 get_bnkCallbackCount() { }
        private System.Int32 get_evtCallbackCount() { }
        private System.Void CancelAllCallbacks() { }
        private System.Void RemoveEventCallback(System.UInt32 in_playingID) { }
        private System.Void RemoveEventCallbackCookie(System.Object in_cookie) { }
        private System.Void RemoveBankCallback(System.Object in_cookie) { }
        private System.Void SetLastAddedPlayingID(System.UInt32 in_playingID) { }
        private System.Void Init() { }
        private System.Void Term() { }
        private System.Void SetMonitoringCallback(AkMonitorErrorLevel in_Level, AkCallbackManager.MonitoringCallback in_CB) { }
        private System.Void SetLocalOutput(AkMonitorErrorLevel in_Level) { }
        private System.Void SetBGMCallback(AkCallbackManager.BGMCallback in_CB, System.Object in_cookie) { }
        private System.Void PostCallbacksNoInvoke() { }
        private System.Int32 PostCallbacks() { }
        private System.Void _ProcessBankCallback(System.IntPtr pPackage, System.IntPtr pData) { }
        private AkCallbackInfo _ProcessEventCallback(AkCallbackType eType, System.IntPtr pData) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000083
    public class AkBasePlatformSettings : ScriptableObject
    {
        // Methods
        private AkInitializationSettings get_AkInitializationSettings() { }
        private AkSpatialAudioInitSettings get_AkSpatialAudioInitSettings() { }
        private System.String get_SoundBankPersistentDataPath() { }
        private System.String get_SoundbankPath() { }
        private AkCommunicationSettings get_AkCommunicationSettings() { }
        private System.UInt32 get_MemoryAllocationSizeLimit() { }
        private System.UInt32 get_MemoryDebugLevel() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000085
    public struct PanningRule
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkCommonOutputSettings.PanningRule Speakers;        // 0x0
        public static AkCommonOutputSettings.PanningRule Headphones;        // 0x0

    }

    // TypeToken: 0x2000087
    public struct ChannelConfigType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType Anonymous;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType Standard;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType Ambisonic;        // 0x0

    }

    // TypeToken: 0x2000088
    public struct ChannelMask
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask NONE;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask FRONT_LEFT;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask FRONT_RIGHT;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask FRONT_CENTER;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask LOW_FREQUENCY;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask BACK_LEFT;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask BACK_RIGHT;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask BACK_CENTER;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SIDE_LEFT;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SIDE_RIGHT;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask TOP;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_FRONT_LEFT;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_FRONT_CENTER;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_FRONT_RIGHT;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_BACK_LEFT;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_BACK_CENTER;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask HEIGHT_BACK_RIGHT;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_MONO;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_0POINT1;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_1POINT1;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_STEREO;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_2POINT1;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_3STEREO;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_3POINT1;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_4;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_4POINT1;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_5;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_5POINT1;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_6;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_6POINT1;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_7;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_7POINT1;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_SURROUND;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DPL2;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_HEIGHT_4;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_HEIGHT_5;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_HEIGHT_ALL;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_222;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_8;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_9;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_9POINT1;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_10;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_10POINT1;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_11;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_11POINT1;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_11_740;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_11POINT1_740;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_13_751;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_AURO_13POINT1_751;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_5_0_2;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_5_1_2;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_6_0_2;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_6_1_2;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_6_0_4;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_6_1_4;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_7_0_2;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_7_1_2;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_7_0_4;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_DOLBY_7_1_4;        // 0x0
        public static AkCommonOutputSettings.ChannelConfiguration.ChannelMask SETUP_ALL_SPEAKERS;        // 0x0

    }

    // TypeToken: 0x2000086
    public class ChannelConfiguration
    {
        // Fields
        public AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType m_ChannelConfigType;        // 0x10
        public AkCommonOutputSettings.ChannelConfiguration.ChannelMask m_ChannelMask;        // 0x14
        public System.UInt32 m_NumberOfChannels;        // 0x18

        // Methods
        private System.Void CopyTo(AkChannelConfig config) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000084
    public class AkCommonOutputSettings
    {
        // Fields
        public System.String m_AudioDeviceShareset;        // 0x10
        public System.UInt32 m_DeviceID;        // 0x18
        public AkCommonOutputSettings.PanningRule m_PanningRule;        // 0x1C
        public AkCommonOutputSettings.ChannelConfiguration m_ChannelConfig;        // 0x20

        // Methods
        private System.Void CopyTo(AkOutputSettings settings) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008A
    public class SpatialAudioSettings
    {
        // Fields
        public System.UInt32 m_MaxSoundPropagationDepth;        // 0x10
        public System.Single m_MovementThreshold;        // 0x14
        public System.UInt32 m_NumberOfPrimaryRays;        // 0x18
        public System.UInt32 m_MaxReflectionOrder;        // 0x1C
        public System.UInt32 m_MaxDiffractionOrder;        // 0x20
        public System.UInt32 m_DiffractionOnReflectionsOrder;        // 0x24
        public System.UInt32 m_MaxEmitterRoomAuxSends;        // 0x28
        public System.Single m_MaxPathLength;        // 0x2C
        public System.Single m_CPULimitPercentage;        // 0x30
        public System.Boolean m_EnableGeometricDiffractionAndTransmission;        // 0x34
        public System.Boolean m_CalcEmitterVirtualPosition;        // 0x35
        public System.UInt32 m_LoadBalancingSpread;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000089
    public class AkCommonUserSettings
    {
        // Fields
        public System.String m_BasePath;        // 0x10
        public System.UInt32 m_MaximumNumberOfPositioningPaths;        // 0x18
        public System.UInt32 m_CommandQueueSize;        // 0x1C
        public System.UInt32 m_SamplesPerFrame;        // 0x20
        public AkCommonOutputSettings m_MainOutputSettings;        // 0x28
        public System.Single m_StreamingLookAheadRatio;        // 0x30
        public System.UInt32 m_SampleRate;        // 0x34
        public System.UInt16 m_NumberOfRefillsInVoice;        // 0x38
        public AkCommonUserSettings.SpatialAudioSettings m_SpatialAudioSettings;        // 0x40

        // Methods
        private System.String GetPluginPath() { }
        private System.Void CopyTo(AkInitSettings settings) { }
        private System.Void CopyTo(AkMusicSettings settings) { }
        private System.Void CopyTo(AkStreamMgrSettings settings) { }
        private System.Void CopyTo(AkDeviceSettings settings) { }
        private System.Void SetSampleRate(AkPlatformInitSettings settings) { }
        private System.Void CopyTo(AkPlatformInitSettings settings) { }
        private System.Void CopyTo(AkSpatialAudioInitSettings settings) { }
        private System.Void CopyTo(AkUnityPlatformSpecificSettings settings) { }
        private System.Void Validate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008C
    public struct MemSpanCount
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkCommonAdvancedSettings.MemSpanCount Small;        // 0x0
        public static AkCommonAdvancedSettings.MemSpanCount Medium;        // 0x0
        public static AkCommonAdvancedSettings.MemSpanCount Huge;        // 0x0

    }

    // TypeToken: 0x200008B
    public class AkCommonAdvancedSettings
    {
        // Fields
        public System.UInt32 m_IOMemorySize;        // 0x10
        public System.Single m_TargetAutoStreamBufferLengthMs;        // 0x14
        public System.Boolean m_UseStreamCache;        // 0x18
        public System.UInt32 m_MaximumPinnedBytesInCache;        // 0x1C
        public System.Boolean m_EnableGameSyncPreparation;        // 0x20
        public System.UInt32 m_ContinuousPlaybackLookAhead;        // 0x24
        public System.UInt32 m_MonitorQueuePoolSize;        // 0x28
        public System.UInt32 m_MaximumHardwareTimeoutMs;        // 0x2C
        public System.Boolean m_DebugOutOfRangeCheckEnabled;        // 0x30
        public System.Single m_DebugOutOfRangeLimit;        // 0x34
        public System.String m_SoundBankPersistentDataPath;        // 0x38
        public System.UInt32 m_MemoryAllocationSizeLimit;        // 0x40
        public System.UInt32 m_MemoryDebugLevel;        // 0x44
        public AkCommonAdvancedSettings.MemSpanCount m_MemorySpanCount;        // 0x48

        // Methods
        private System.Void CopyTo(AkDeviceSettings settings) { }
        private System.Void CopyTo(AkInitSettings settings) { }
        private System.Void CopyTo(AkPlatformInitSettings settings) { }
        private System.Void CopyTo(AkUnityPlatformSpecificSettings settings) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008D
    public class AkCommonCommSettings
    {
        // Fields
        public System.UInt32 m_PoolSize;        // 0x10
        public static System.UInt16 DefaultDiscoveryBroadcastPort;        // 0x0
        public System.UInt16 m_DiscoveryBroadcastPort;        // 0x14
        public System.UInt16 m_CommandPort;        // 0x16
        public System.UInt16 m_NotificationPort;        // 0x18
        public System.Boolean m_InitializeSystemComms;        // 0x1A
        public System.String m_NetworkName;        // 0x20
        public AkCommunicationSettings.AkCommSystem m_commSystem;        // 0x28

        // Methods
        private System.Void CopyTo(AkCommunicationSettings settings) { }
        private System.Void Validate() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200008E
    public class AkCommonPlatformSettings : AkBasePlatformSettings
    {
        // Methods
        private AkCommonUserSettings GetUserSettings() { }
        private AkCommonAdvancedSettings GetAdvancedSettings() { }
        private AkCommonCommSettings GetCommsSettings() { }
        private AkInitializationSettings get_AkInitializationSettings() { }
        private AkSpatialAudioInitSettings get_AkSpatialAudioInitSettings() { }
        private System.String get_SoundBankPersistentDataPath() { }
        private System.String get_SoundbankPath() { }
        private System.UInt32 get_MemoryAllocationSizeLimit() { }
        private System.UInt32 get_MemoryDebugLevel() { }
        private AkCommunicationSettings get_AkCommunicationSettings() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008F
    public class AkEnumFlagAttribute : PropertyAttribute
    {
        // Fields
        public System.Type Type;        // 0x10

        // Methods
        private System.Void .ctor(System.Type type) { }

    }

    // TypeToken: 0x2000091
    public class ErrorLoggerInteropDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String message) { }
        private System.IAsyncResult BeginInvoke(System.String message, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000090
    public class AkLogger
    {
        // Fields
        private static AkLogger ms_Instance;        // 0x0
        private AkLogger.ErrorLoggerInteropDelegate errorLoggerDelegate;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private AkLogger get_Instance() { }
        private System.Void Finalize() { }
        private System.Void Init() { }
        private System.Void WwiseInternalLogError(System.String message) { }
        private System.Void Message(System.String message) { }
        private System.Void Warning(System.String message) { }
        private System.Void Error(System.String message) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000093
    public class InitializationDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000094
    public class TerminationDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000092
    public class AkSoundEngineInitialization
    {
        // Fields
        public static AkSoundEngineInitialization.InitializationDelegate s_initializationDelegate;        // 0x0
        public static AkSoundEngineInitialization.TerminationDelegate s_terminationDelegate;        // 0x8

        // Methods
        private System.Boolean InitializeSoundEngine() { }
        private System.Void _TryInitSpatialAudio(AkBasePlatformSettings& activePlatformSettings) { }
        private System.Void _TryInitCommunication(AkBasePlatformSettings& activePlatformSettings) { }
        private System.Void TerminateSoundEngine() { }
        private System.Void _WaitCallbacks(System.Int32 retry) { }

    }

    // TypeToken: 0x2000096
    public class ShortIDGenerator
    {
        // Fields
        private static System.UInt32 s_prime32;        // 0x0
        private static System.UInt32 s_offsetBasis32;        // 0x0
        private static System.Byte s_hashSize;        // 0x0
        private static System.UInt32 s_mask;        // 0x4

        // Methods
        private System.Void .cctor() { }
        private System.Byte get_HashSize() { }
        private System.Void set_HashSize(System.Byte value) { }
        private System.UInt32 Compute(System.String in_name) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000095
    public class AkUtilities
    {
        // Methods
        private System.Void FixSlashes(System.String& path, System.Char separatorChar, System.Char badChar, System.Boolean addTrailingSlash) { }
        private System.Void FixSlashes(System.String& path) { }
        private System.String GetPathInPackage(System.String relativePath) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000097
    public struct AkVector64
    {
        // Fields
        public System.Double X;        // 0x10
        public System.Double Y;        // 0x18
        public System.Double Z;        // 0x20

        // Methods
        private System.Void Zero() { }
        private AkVector64 op_Implicit(UnityEngine.Vector3 vector) { }

    }

    // TypeToken: 0x2000099
    public class PlatformSettings : AkCommonPlatformSettings
    {
        // Fields
        private System.Collections.Generic.List<System.String> IgnorePropertyNameList;        // 0x18
        private System.Collections.Generic.List<System.String> GlobalPropertyNameList;        // 0x20
        private System.Collections.Generic.HashSet<System.String> _GlobalPropertyHashSet;        // 0x28

        // Methods
        private System.Void IgnorePropertyValue(System.String propertyPath) { }
        private System.Boolean IsPropertyIgnored(System.String propertyPath) { }
        private System.Void .ctor() { }
        private System.Void SetUseGlobalPropertyValue(System.String propertyPath, System.Boolean use) { }
        private System.Void SetGlobalPropertyValues(System.Collections.IEnumerable enumerable) { }
        private System.Boolean IsUsingGlobalPropertyValue(System.String propertyPath) { }
        private System.Collections.Generic.HashSet<System.String> get_GlobalPropertyHashSet() { }
        private System.Void set_GlobalPropertyHashSet(System.Collections.Generic.HashSet<System.String> value) { }

    }

    // TypeToken: 0x200009A
    public class CommonPlatformSettings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;        // 0x30
        public AkCommonAdvancedSettings AdvancedSettings;        // 0x38
        public AkCommonCommSettings CommsSettings;        // 0x40

        // Methods
        private AkCommonUserSettings GetUserSettings() { }
        private AkCommonAdvancedSettings GetAdvancedSettings() { }
        private AkCommonCommSettings GetCommsSettings() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000098
    public class AkWwiseInitializationSettings : AkCommonPlatformSettings
    {
        // Fields
        public System.Collections.Generic.List<System.String> PlatformSettingsNameList;        // 0x18
        public System.Collections.Generic.List<AkWwiseInitializationSettings.PlatformSettings> PlatformSettingsList;        // 0x20
        public System.Collections.Generic.List<System.String> InvalidReferencePlatforms;        // 0x28
        public AkCommonUserSettings UserSettings;        // 0x30
        public AkCommonAdvancedSettings AdvancedSettings;        // 0x38
        public AkCommonCommSettings CommsSettings;        // 0x40
        private static readonly System.String[] AllGlobalValues;        // 0x0
        private static AkWwiseInitializationSettings m_Instance;        // 0x8
        private static AkBasePlatformSettings m_ActivePlatformSettings;        // 0x10

        // Methods
        private System.Boolean get_IsValid() { }
        private System.Int32 get_Count() { }
        private AkCommonUserSettings GetUserSettings() { }
        private AkCommonAdvancedSettings GetAdvancedSettings() { }
        private AkCommonCommSettings GetCommsSettings() { }
        private AkWwiseInitializationSettings get_Instance() { }
        private System.Void set_Instance(AkWwiseInitializationSettings value) { }
        private AkBasePlatformSettings GetPlatformSettings(System.String platformName) { }
        private AkBasePlatformSettings get_ActivePlatformSettings() { }
        private System.Void OnEnable() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009B
    public class AkAcousticSurfaceArray : AkBaseArray`1
    {
        // Methods
        private System.Void .ctor(System.Int32 count) { }
        private System.Int32 get_StructureSize() { }
        private System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        private AkAcousticSurface CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        private System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkAcousticSurface other) { }

    }

    // TypeToken: 0x200009C
    public class AkAuxSendArray, IDisposable
    {
        // Fields
        private static System.Int32 MAX_COUNT;        // 0x0
        private readonly System.Int32 SIZE_OF_AKAUXSENDVALUE;        // 0x10
        private System.IntPtr m_Buffer;        // 0x18
        private System.Int32 m_Count;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private AkAuxSendValue get_Item(System.Int32 index) { }
        private System.Boolean get_isFull() { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }
        private System.Void Reset() { }
        private System.Boolean Add(System.UInt64 in_listenerGameObj, System.UInt32 in_AuxBusID, System.Single in_fValue) { }
        private System.Boolean Add(System.UInt32 in_AuxBusID, System.Single in_fValue) { }
        private System.Boolean Contains(System.UInt64 in_listenerGameObj, System.UInt32 in_AuxBusID) { }
        private System.Boolean Contains(System.UInt32 in_AuxBusID) { }
        private AKRESULT SetValues(System.UInt64 gameObject) { }
        private AKRESULT GetValues(System.UInt64 gameObject) { }
        private System.IntPtr GetBuffer() { }
        private System.Int32 Count() { }
        private System.IntPtr _GetObjectPtr(System.Int32 index) { }

    }

    // TypeToken: 0x200009D
    public class AkBaseArray`1, IDisposable
    {
        // Fields
        private System.Int32 <Capacity>k__BackingField;        // 0x0
        private System.IntPtr m_Buffer;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }
        private System.Int32 get_Capacity() { }
        private System.Void set_Capacity(System.Int32 value) { }
        private System.Int32 Count() { }
        private System.Int32 get_StructureSize() { }
        private System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        private System.Void ReleaseAllocatedMemoryFromReferenceAtIntPtr(System.IntPtr address) { }
        private T CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        private System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, T other) { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.IntPtr GetBuffer() { }
        private System.IntPtr GetObjectPtr(System.Int32 index) { }

    }

    // TypeToken: 0x200009E
    public class AkChannelEmitterArray, IDisposable
    {
        // Fields
        public System.IntPtr m_Buffer;        // 0x10
        private System.IntPtr m_Current;        // 0x18
        private System.UInt32 m_MaxCount;        // 0x20
        private System.UInt32 <Count>k__BackingField;        // 0x24

        // Methods
        private System.Void .ctor(System.UInt32 in_Count) { }
        private System.UInt32 get_Count() { }
        private System.Void set_Count(System.UInt32 value) { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }
        private System.Void Reset() { }
        private System.Void Add(AkVector64 in_Pos, UnityEngine.Vector3 in_Forward, UnityEngine.Vector3 in_Top, System.UInt32 in_ChannelMask) { }

    }

    // TypeToken: 0x200009F
    public class AkDeviceDescriptionArray : AkBaseArray`1
    {
        // Methods
        private System.Void .ctor(System.Int32 count) { }
        private System.Int32 get_StructureSize() { }
        private System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        private AkDeviceDescription CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        private System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkDeviceDescription other) { }

    }

    // TypeToken: 0x20000A0
    public class AkDiffractionPathInfoArray : AkBaseArray`1
    {
        // Methods
        private System.Void .ctor(System.Int32 count) { }
        private System.Int32 get_StructureSize() { }
        private AkDiffractionPathInfo CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        private System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkDiffractionPathInfo other) { }

    }

    // TypeToken: 0x20000A1
    public class AkExternalSourceInfoArray : AkBaseArray`1
    {
        // Methods
        private System.Void .ctor(System.Int32 count) { }
        private System.Int32 get_StructureSize() { }
        private System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        private System.Void ReleaseAllocatedMemoryFromReferenceAtIntPtr(System.IntPtr address) { }
        private AkExternalSourceInfo CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        private System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkExternalSourceInfo other) { }

    }

    // TypeToken: 0x20000A2
    public class AkMIDIPostArray
    {
        // Fields
        private readonly System.Int32 m_Count;        // 0x10
        private readonly System.Int32 SIZE_OF;        // 0x14
        private System.IntPtr m_Buffer;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 size) { }
        private AkMIDIPost get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, AkMIDIPost value) { }
        private System.Void Finalize() { }
        private System.Void PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject gameObject) { }
        private System.Void PostOnEvent(System.UInt32 in_eventID, UnityEngine.GameObject gameObject, System.Int32 count) { }
        private System.IntPtr GetBuffer() { }
        private System.Int32 Count() { }
        private System.IntPtr GetObjectPtr(System.Int32 index) { }

    }

    // TypeToken: 0x20000A3
    public class AkObjectInfoArray : AkBaseArray`1
    {
        // Methods
        private System.Void .ctor(System.Int32 count) { }
        private System.Int32 get_StructureSize() { }
        private System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        private AkObjectInfo CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        private System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkObjectInfo other) { }

    }

    // TypeToken: 0x20000A4
    public class AkObstructionOcclusionValuesArray : AkBaseArray`1
    {
        // Methods
        private System.Void .ctor(System.Int32 count) { }
        private System.Int32 get_StructureSize() { }
        private System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        private AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        private System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkObstructionOcclusionValues other) { }

    }

    // TypeToken: 0x20000A5
    public class AkPositionArray, IDisposable
    {
        // Fields
        public System.IntPtr m_Buffer;        // 0x10
        private System.IntPtr m_Current;        // 0x18
        private System.UInt32 m_MaxCount;        // 0x20
        private System.UInt32 <Count>k__BackingField;        // 0x24

        // Methods
        private System.Void .ctor(System.UInt32 in_Count) { }
        private System.UInt32 get_Count() { }
        private System.Void set_Count(System.UInt32 value) { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }
        private System.Void Reset() { }
        private System.Void Add(AkVector64 in_Pos, UnityEngine.Vector3 in_Forward, UnityEngine.Vector3 in_Top) { }

    }

    // TypeToken: 0x20000A6
    public class AkReflectionPathInfoArray : AkBaseArray`1
    {
        // Methods
        private System.Void .ctor(System.Int32 count) { }
        private System.Int32 get_StructureSize() { }
        private AkReflectionPathInfo CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        private System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkReflectionPathInfo other) { }

    }

    // TypeToken: 0x20000A7
    public class AkSourceSettingsArray : AkBaseArray`1
    {
        // Methods
        private System.Void .ctor(System.Int32 count) { }
        private System.Int32 get_StructureSize() { }
        private System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        private AkSourceSettings CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        private System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkSourceSettings other) { }

    }

    // TypeToken: 0x20000A8
    public class AkTriangleArray : AkBaseArray`1
    {
        // Methods
        private System.Void .ctor(System.Int32 count) { }
        private System.Int32 get_StructureSize() { }
        private System.Void DefaultConstructAtIntPtr(System.IntPtr address) { }
        private AkTriangle CreateNewReferenceFromIntPtr(System.IntPtr address) { }
        private System.Void CloneIntoReferenceFromIntPtr(System.IntPtr address, AkTriangle other) { }

    }

    // TypeToken: 0x20000AA
    public struct AudioTriangleArrayNoGc, IDisposable
    {
        // Fields
        private System.IntPtr m_buffer;        // 0x10
        private System.Int32 m_capacity;        // 0x18
        private System.Int32 m_elementSize;        // 0x1C

        // Methods
        private System.IntPtr get_Buffer() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void Set(System.Int32 idx, System.UInt16 p0, System.UInt16 p1, System.UInt16 p2, System.UInt16 surface) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000AB
    public struct AudioAcousticSurfaceArrayNoGc, IDisposable
    {
        // Fields
        private System.IntPtr m_buffer;        // 0x10
        private System.Int32 m_capacity;        // 0x18
        private System.Int32 m_elementSize;        // 0x1C

        // Methods
        private System.IntPtr get_Buffer() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void Set(System.Int32 idx, System.Single transmissionLoss, System.UInt32 textureId) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000A9
    public class AudioNativeHelper
    {
        // Fields
        private static System.IntPtr s_reusedTransformPtr;        // 0x0

        // Methods
        private System.Void Init() { }
        private System.Void Term() { }
        private AKRESULT SetRoomPortal(System.UInt64 portalID, System.UInt64 frontRoom, System.UInt64 backRoom, UnityEngine.Vector3 position, UnityEngine.Vector3 orientationFront, UnityEngine.Vector3 orientationTop, UnityEngine.Vector3 extent, System.Boolean enabled, System.String portalName) { }
        private AKRESULT SetGeometry(System.UInt64 geoId, AudioNativeHelper.AudioTriangleArrayNoGc triangles, System.UInt32 numTriangles, UnityEngine.Vector3[] vertices, System.UInt32 numVertices, AudioNativeHelper.AudioAcousticSurfaceArrayNoGc surfaces, System.UInt32 numSurfaces, System.Boolean enableDiffraction, System.Boolean enableDiffractionOnBoundaryEdges) { }
        private AKRESULT SetGeometryInstance(System.UInt64 geomInstanceID, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scale, System.UInt64 geometrySetID, System.UInt64 roomID, System.Boolean useForReflectionAndDiffraction) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AE
    public struct Category
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkiOSSettings.PlatformAdvancedSettings.Category Ambient;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.Category SoloAmbient;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.Category PlayAndRecord;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.Category Playback;        // 0x0

    }

    // TypeToken: 0x20000AF
    public struct CategoryOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkiOSSettings.PlatformAdvancedSettings.CategoryOptions MixWithOthers;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.CategoryOptions DuckOthers;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.CategoryOptions AllowBluetooth;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.CategoryOptions DefaultToSpeaker;        // 0x0

    }

    // TypeToken: 0x20000B0
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AkiOSSettings.PlatformAdvancedSettings.Mode Default;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.Mode VoiceChat;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.Mode GameChat;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.Mode VideoRecording;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.Mode Measurement;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.Mode MoviePlayback;        // 0x0
        public static AkiOSSettings.PlatformAdvancedSettings.Mode VideoChat;        // 0x0

    }

    // TypeToken: 0x20000AD
    public class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        // Fields
        public AkiOSSettings.PlatformAdvancedSettings.Category m_AudioSessionCategory;        // 0x50
        public AkiOSSettings.PlatformAdvancedSettings.CategoryOptions m_AudioSessionCategoryOptions;        // 0x54
        public AkiOSSettings.PlatformAdvancedSettings.Mode m_AudioSessionMode;        // 0x58
        public System.UInt32 NumSpatialAudioPointSources;        // 0x5C
        public System.Boolean VerboseSystemOutput;        // 0x60

        // Methods
        private System.Void CopyTo(AkPlatformInitSettings settings) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AC
    public class AkiOSSettings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;        // 0x30
        public AkiOSSettings.PlatformAdvancedSettings AdvancedSettings;        // 0x38
        public AkCommonCommSettings CommsSettings;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private AkCommonUserSettings GetUserSettings() { }
        private AkCommonAdvancedSettings GetAdvancedSettings() { }
        private AkCommonCommSettings GetCommsSettings() { }

    }

    // TypeToken: 0x20000B2
    public class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        // Fields
        public System.UInt32 NumSpatialAudioPointSources;        // 0x50
        public System.Boolean VerboseSystemOutput;        // 0x54

        // Methods
        private System.Void CopyTo(AkPlatformInitSettings settings) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B1
    public class AkMacSettings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;        // 0x30
        public AkMacSettings.PlatformAdvancedSettings AdvancedSettings;        // 0x38
        public AkCommonCommSettings CommsSettings;        // 0x40

        // Methods
        private AkCommonUserSettings GetUserSettings() { }
        private AkCommonAdvancedSettings GetAdvancedSettings() { }
        private AkCommonCommSettings GetCommsSettings() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B4
    public class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        // Fields
        public System.UInt32 NumAudioOut2Ports;        // 0x50
        public System.UInt32 NumAudioOut2ObjectPorts;        // 0x54
        public System.Boolean HwCodecLowLatencyMode;        // 0x58
        public System.Boolean VorbisHwAcceleration;        // 0x59
        public System.Boolean Enable3DAudioSync;        // 0x5A
        public System.UInt32 NumOperationsForHwMixing;        // 0x5C
        public System.Boolean PlotQueueLevel;        // 0x60

        // Methods
        private System.Void CopyTo(AkPlatformInitSettings settings) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3
    public class AkPS5Settings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;        // 0x30
        public AkPS5Settings.PlatformAdvancedSettings AdvancedSettings;        // 0x38
        public AkCommonCommSettings CommsSettings;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private AkCommonUserSettings GetUserSettings() { }
        private AkCommonAdvancedSettings GetAdvancedSettings() { }
        private AkCommonCommSettings GetCommsSettings() { }

    }

    // TypeToken: 0x20000B6
    public class PlatformAdvancedSettings : AkCommonAdvancedSettings
    {
        // Fields
        public System.UInt32 MaxSystemAudioObjects;        // 0x50

        // Methods
        private System.Void CopyTo(AkPlatformInitSettings settings) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B5
    public class AkWindowsSettings : PlatformSettings
    {
        // Fields
        public AkCommonUserSettings UserSettings;        // 0x30
        public AkWindowsSettings.PlatformAdvancedSettings AdvancedSettings;        // 0x38
        public AkCommonCommSettings CommsSettings;        // 0x40

        // Methods
        private AkCommonUserSettings GetUserSettings() { }
        private AkCommonAdvancedSettings GetAdvancedSettings() { }
        private AkCommonCommSettings GetCommsSettings() { }
        private System.Void .ctor() { }

    }

