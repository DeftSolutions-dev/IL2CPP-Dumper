// ========================================================
// Dumped by @desirepro
// Assembly: CriMw.CriWare.Runtime.dll
// Classes:  326
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000008
    public struct AudioPortType
    {
        // Fields
        public System.UInt16 value__;        // 0x10
        public static CriWare.CriWarePS5.AudioPortType Main;        // 0x0
        public static CriWare.CriWarePS5.AudioPortType Bgm;        // 0x0
        public static CriWare.CriWarePS5.AudioPortType Voice;        // 0x0
        public static CriWare.CriWarePS5.AudioPortType PadSpeaker;        // 0x0
        public static CriWare.CriWarePS5.AudioPortType Personal;        // 0x0
        public static CriWare.CriWarePS5.AudioPortType Aux;        // 0x0
        public static CriWare.CriWarePS5.AudioPortType Vibration;        // 0x0
        public static CriWare.CriWarePS5.AudioPortType ObjectMain;        // 0x0
        public static CriWare.CriWarePS5.AudioPortType ObjectVoice;        // 0x0
        public static CriWare.CriWarePS5.AudioPortType ObjecPersonal;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct AttributeId
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriWarePS5.AttributeId Pcm;        // 0x0
        public static CriWare.CriWarePS5.AttributeId Gain;        // 0x0
        public static CriWare.CriWarePS5.AttributeId Priority;        // 0x0
        public static CriWare.CriWarePS5.AttributeId Position;        // 0x0
        public static CriWare.CriWarePS5.AttributeId Spread;        // 0x0
        public static CriWare.CriWarePS5.AttributeId Passthrough;        // 0x0
        public static CriWare.CriWarePS5.AttributeId ResetState;        // 0x0
        public static CriWare.CriWarePS5.AttributeId ApplicationSpecific;        // 0x0
        public static CriWare.CriWarePS5.AttributeId Ambisonics;        // 0x0
        public static CriWare.CriWarePS5.AttributeId Restricted;        // 0x0
        public static CriWare.CriWarePS5.AttributeId MixToMainGain;        // 0x0
        public static CriWare.CriWarePS5.AttributeId DebugName;        // 0x0
        public static CriWare.CriWarePS5.AttributeId MAX;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct PortFlag
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static CriWare.CriWarePS5.PortFlag Restricted;        // 0x0
        public static CriWare.CriWarePS5.PortFlag Passthrough;        // 0x0

    }

    // TypeToken: 0x200000B
    public class SafeNativeMethods
    {
        // Methods
        private System.Void criFsUnity_Setup_PS5(System.Boolean enable_apr_direct_mode) { }

    }

    // TypeToken: 0x200000D
    public class CallbackFromNativeDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.UInt64 Invoke(System.IntPtr ptr1) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr ptr1, System.AsyncCallback callback, System.Object object) { }
        private System.UInt64 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000015
    public struct OutputDeviceType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomOutputDeviceObserver.OutputDeviceType BuiltinSpeaker;        // 0x0
        public static CriWare.CriAtomOutputDeviceObserver.OutputDeviceType WiredDevice;        // 0x0
        public static CriWare.CriAtomOutputDeviceObserver.OutputDeviceType WirelessDevice;        // 0x0

    }

    // TypeToken: 0x2000016
    public class DeviceConnectionChangeCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Boolean isConnected, CriWare.CriAtomOutputDeviceObserver.OutputDeviceType deviceType) { }
        private System.IAsyncResult BeginInvoke(System.Boolean isConnected, CriWare.CriAtomOutputDeviceObserver.OutputDeviceType deviceType, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000017
    public class UnsafeNativeMethods
    {
    }

    // TypeToken: 0x200001D
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomSourceBase.Status Stop;        // 0x0
        public static CriWare.CriAtomSourceBase.Status Prep;        // 0x0
        public static CriWare.CriAtomSourceBase.Status Playing;        // 0x0
        public static CriWare.CriAtomSourceBase.Status PlayEnd;        // 0x0
        public static CriWare.CriAtomSourceBase.Status Error;        // 0x0

    }

    // TypeToken: 0x200001F
    public class SetControlIdMethod : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.UInt16 id) { }
        private System.IAsyncResult BeginInvoke(System.UInt16 id, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000022
    public struct CharacterEncoding
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.CharacterEncoding Utf8;        // 0x0
        public static CriWare.CriAtomEx.CharacterEncoding Sjis;        // 0x0

    }

    // TypeToken: 0x2000023
    public struct SoundRendererType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.SoundRendererType Default;        // 0x0
        public static CriWare.CriAtomEx.SoundRendererType Native;        // 0x0
        public static CriWare.CriAtomEx.SoundRendererType Asr;        // 0x0
        public static CriWare.CriAtomEx.SoundRendererType Hw1;        // 0x0
        public static CriWare.CriAtomEx.SoundRendererType Hw2;        // 0x0
        public static CriWare.CriAtomEx.SoundRendererType Haptic;        // 0x0

    }

    // TypeToken: 0x2000024
    public struct VoiceAllocationMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.VoiceAllocationMethod Once;        // 0x0
        public static CriWare.CriAtomEx.VoiceAllocationMethod Retry;        // 0x0

    }

    // TypeToken: 0x2000025
    public struct BiquadFilterType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.BiquadFilterType Off;        // 0x0
        public static CriWare.CriAtomEx.BiquadFilterType LowPass;        // 0x0
        public static CriWare.CriAtomEx.BiquadFilterType HighPass;        // 0x0
        public static CriWare.CriAtomEx.BiquadFilterType Notch;        // 0x0
        public static CriWare.CriAtomEx.BiquadFilterType LowShelf;        // 0x0
        public static CriWare.CriAtomEx.BiquadFilterType HighShelf;        // 0x0
        public static CriWare.CriAtomEx.BiquadFilterType Peaking;        // 0x0

    }

    // TypeToken: 0x2000026
    public struct ResumeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.ResumeMode AllPlayback;        // 0x0
        public static CriWare.CriAtomEx.ResumeMode PausedPlayback;        // 0x0
        public static CriWare.CriAtomEx.ResumeMode PreparedPlayback;        // 0x0

    }

    // TypeToken: 0x2000027
    public struct PanType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.PanType Unknown;        // 0x0
        public static CriWare.CriAtomEx.PanType Pan3d;        // 0x0
        public static CriWare.CriAtomEx.PanType Pos3d;        // 0x0
        public static CriWare.CriAtomEx.PanType Auto;        // 0x0

    }

    // TypeToken: 0x2000028
    public struct VoiceControlMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.VoiceControlMethod PreferLast;        // 0x0
        public static CriWare.CriAtomEx.VoiceControlMethod PreferFirst;        // 0x0

    }

    // TypeToken: 0x2000029
    public struct Parameter
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.Parameter Volume;        // 0x0
        public static CriWare.CriAtomEx.Parameter Pitch;        // 0x0
        public static CriWare.CriAtomEx.Parameter Pan3dAngle;        // 0x0
        public static CriWare.CriAtomEx.Parameter Pan3dDistance;        // 0x0
        public static CriWare.CriAtomEx.Parameter Pan3dVolume;        // 0x0
        public static CriWare.CriAtomEx.Parameter BusSendLevel0;        // 0x0
        public static CriWare.CriAtomEx.Parameter BusSendLevel1;        // 0x0
        public static CriWare.CriAtomEx.Parameter BusSendLevel2;        // 0x0
        public static CriWare.CriAtomEx.Parameter BusSendLevel3;        // 0x0
        public static CriWare.CriAtomEx.Parameter BusSendLevel4;        // 0x0
        public static CriWare.CriAtomEx.Parameter BusSendLevel5;        // 0x0
        public static CriWare.CriAtomEx.Parameter BusSendLevel6;        // 0x0
        public static CriWare.CriAtomEx.Parameter BusSendLevel7;        // 0x0
        public static CriWare.CriAtomEx.Parameter BandPassFilterCofLow;        // 0x0
        public static CriWare.CriAtomEx.Parameter BandPassFilterCofHigh;        // 0x0
        public static CriWare.CriAtomEx.Parameter BiquadFilterType;        // 0x0
        public static CriWare.CriAtomEx.Parameter BiquadFilterFreq;        // 0x0
        public static CriWare.CriAtomEx.Parameter BiquadFIlterQ;        // 0x0
        public static CriWare.CriAtomEx.Parameter BiquadFilterGain;        // 0x0
        public static CriWare.CriAtomEx.Parameter EnvelopeAttackTime;        // 0x0
        public static CriWare.CriAtomEx.Parameter EnvelopeHoldTime;        // 0x0
        public static CriWare.CriAtomEx.Parameter EnvelopeDecayTime;        // 0x0
        public static CriWare.CriAtomEx.Parameter EnvelopeReleaseTime;        // 0x0
        public static CriWare.CriAtomEx.Parameter EnvelopeSustainLevel;        // 0x0
        public static CriWare.CriAtomEx.Parameter StartTime;        // 0x0
        public static CriWare.CriAtomEx.Parameter Priority;        // 0x0

    }

    // TypeToken: 0x200002A
    public struct Speaker
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.Speaker FrontLeft;        // 0x0
        public static CriWare.CriAtomEx.Speaker FrontRight;        // 0x0
        public static CriWare.CriAtomEx.Speaker FrontCenter;        // 0x0
        public static CriWare.CriAtomEx.Speaker LowFrequency;        // 0x0
        public static CriWare.CriAtomEx.Speaker SurroundLeft;        // 0x0
        public static CriWare.CriAtomEx.Speaker SurroundRight;        // 0x0
        public static CriWare.CriAtomEx.Speaker SurroundBackLeft;        // 0x0
        public static CriWare.CriAtomEx.Speaker SurroundBackRight;        // 0x0

    }

    // TypeToken: 0x200002B
    public struct Format
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static CriWare.CriAtomEx.Format ADX;        // 0x0
        public static CriWare.CriAtomEx.Format HCA;        // 0x0
        public static CriWare.CriAtomEx.Format HCA_MX;        // 0x0
        public static CriWare.CriAtomEx.Format WAVE;        // 0x0
        public static CriWare.CriAtomEx.Format RAW_PCM;        // 0x0
        public static CriWare.CriAtomEx.Format AUDIO_BUFFER;        // 0x0

    }

    // TypeToken: 0x200002C
    public struct SpeakerSystem
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static CriWare.CriAtomEx.SpeakerSystem Surround_5_1;        // 0x0
        public static CriWare.CriAtomEx.SpeakerSystem Surround_7_1;        // 0x0

    }

    // TypeToken: 0x200002D
    public struct SpeakerAngles6ch
    {
        // Fields
        public System.Single frontLeft;        // 0x10
        public System.Single frontRight;        // 0x14
        public System.Single frontCenter;        // 0x18
        public System.Single lowFrequency;        // 0x1C
        public System.Single surroundLeft;        // 0x20
        public System.Single surroundRight;        // 0x24

        // Methods
        private CriWare.CriAtomEx.SpeakerAngles6ch Default() { }

    }

    // TypeToken: 0x200002E
    public struct SpeakerAngles8ch
    {
        // Fields
        public System.Single frontLeft;        // 0x10
        public System.Single frontRight;        // 0x14
        public System.Single frontCenter;        // 0x18
        public System.Single lowFrequency;        // 0x1C
        public System.Single surroundLeft;        // 0x20
        public System.Single surroundRight;        // 0x24
        public System.Single surroundBackLeft;        // 0x28
        public System.Single surroundBackRight;        // 0x2C

        // Methods
        private CriWare.CriAtomEx.SpeakerAngles8ch Default() { }

    }

    // TypeToken: 0x200002F
    public struct FormatInfo
    {
        // Fields
        public CriWare.CriAtomEx.Format format;        // 0x10
        public System.Int32 samplingRate;        // 0x14
        public System.Int64 numSamples;        // 0x18
        public System.Int64 loopOffset;        // 0x20
        public System.Int64 loopLength;        // 0x28
        public System.Int32 numChannels;        // 0x30
        public System.UInt32 reserved;        // 0x34

    }

    // TypeToken: 0x2000030
    public struct AisacControlInfo
    {
        // Fields
        public readonly System.String name;        // 0x10
        public System.UInt32 id;        // 0x18

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x2000031
    public struct Randomize3dCalcType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.Randomize3dCalcType None;        // 0x0
        public static CriWare.CriAtomEx.Randomize3dCalcType Rectangle;        // 0x0
        public static CriWare.CriAtomEx.Randomize3dCalcType Cuboid;        // 0x0
        public static CriWare.CriAtomEx.Randomize3dCalcType Circle;        // 0x0
        public static CriWare.CriAtomEx.Randomize3dCalcType Cylinder;        // 0x0
        public static CriWare.CriAtomEx.Randomize3dCalcType Sphere;        // 0x0
        public static CriWare.CriAtomEx.Randomize3dCalcType List;        // 0x0

    }

    // TypeToken: 0x2000032
    public struct Randomize3dParamType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.Randomize3dParamType None;        // 0x0
        public static CriWare.CriAtomEx.Randomize3dParamType Width;        // 0x0
        public static CriWare.CriAtomEx.Randomize3dParamType Depth;        // 0x0
        public static CriWare.CriAtomEx.Randomize3dParamType Height;        // 0x0
        public static CriWare.CriAtomEx.Randomize3dParamType Radius;        // 0x0

    }

    // TypeToken: 0x2000033
    public struct Randomize3dConfig
    {
        // Fields
        public static System.Int32 NumOfCalcParams;        // 0x0
        private System.Boolean followsOriginalSource;        // 0x10
        private CriWare.CriAtomEx.Randomize3dCalcType calculationType;        // 0x14
        private System.Single[] calculationParameters;        // 0x18

        // Methods
        private System.Boolean get_FollowsOriginalSource() { }
        private CriWare.CriAtomEx.Randomize3dCalcType get_CalculationType() { }
        private System.Single get_CalculationParameter1() { }
        private System.Single get_CalculationParameter2() { }
        private System.Single get_CalculationParameter3() { }
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }
        private System.Void .ctor(System.Boolean followsOriginalSource, CriWare.CriAtomEx.Randomize3dCalcType calculationType, System.Single param1, System.Single param2, System.Single param3) { }
        private System.Void .ctor(System.Int32 dummy) { }
        private System.Void ClearCalcParams(System.Single initVal) { }
        private System.Boolean GetParamByType(CriWare.CriAtomEx.Randomize3dParamType paramType, System.Single& paramVal) { }
        private System.Boolean SetParamByType(CriWare.CriAtomEx.Randomize3dParamType paramType, System.Single paramVal) { }

    }

    // TypeToken: 0x2000034
    public struct CuePos3dInfo
    {
        // Fields
        public System.Single coneInsideAngle;        // 0x10
        public System.Single coneOutsideAngle;        // 0x14
        public System.Single minAttenuationDistance;        // 0x18
        public System.Single maxAttenuationDistance;        // 0x1C
        public System.Single sourceRadius;        // 0x20
        public System.Single interiorDistance;        // 0x24
        public System.Single dopplerFactor;        // 0x28
        public CriWare.CriAtomEx.Randomize3dConfig randomPos;        // 0x30
        public System.UInt32 distanceAisacControl;        // 0x40
        public System.UInt32 listenerBaseAngleAisacControl;        // 0x44
        public System.UInt32 sourceBaseAngleAisacControl;        // 0x48
        public System.UInt32 listenerBaseElevationAisacControl;        // 0x4C
        public System.UInt32 sourceBaseElevationAisacControl;        // 0x50

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x2000035
    public struct GameVariableInfo
    {
        // Fields
        public readonly System.String name;        // 0x10
        public System.UInt32 id;        // 0x18
        public System.Single gameValue;        // 0x1C

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }
        private System.Void .ctor(System.String name, System.UInt32 id, System.Single gameValue) { }

    }

    // TypeToken: 0x2000036
    public struct CueType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomEx.CueType Polyphonic;        // 0x0
        public static CriWare.CriAtomEx.CueType Sequential;        // 0x0
        public static CriWare.CriAtomEx.CueType Shuffle;        // 0x0
        public static CriWare.CriAtomEx.CueType Random;        // 0x0
        public static CriWare.CriAtomEx.CueType RandomNoRepeat;        // 0x0
        public static CriWare.CriAtomEx.CueType SwitchGameVariable;        // 0x0
        public static CriWare.CriAtomEx.CueType ComboSequential;        // 0x0
        public static CriWare.CriAtomEx.CueType SwitchSelector;        // 0x0
        public static CriWare.CriAtomEx.CueType TrackTransitionBySelector;        // 0x0

    }

    // TypeToken: 0x2000037
    public struct CueInfo
    {
        // Fields
        public System.Int32 id;        // 0x10
        public CriWare.CriAtomEx.CueType type;        // 0x14
        public readonly System.String name;        // 0x18
        public readonly System.String userData;        // 0x20
        public System.Int64 length;        // 0x28
        public System.UInt16[] categories;        // 0x30
        public System.Int16 numLimits;        // 0x38
        public System.UInt16 numBlocks;        // 0x3A
        public System.UInt16 numTracks;        // 0x3C
        public System.UInt16 numRelatedWaveForms;        // 0x3E
        public System.Byte priority;        // 0x40
        public System.Byte headerVisibility;        // 0x41
        public System.Byte ignore_player_parameter;        // 0x42
        public System.Byte probability;        // 0x43
        public CriWare.CriAtomEx.PanType panType;        // 0x44
        public CriWare.CriAtomEx.CuePos3dInfo pos3dInfo;        // 0x48
        public CriWare.CriAtomEx.GameVariableInfo gameVariableInfo;        // 0x90

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x2000038
    public struct WaveformInfo
    {
        // Fields
        public System.Int32 waveId;        // 0x10
        public System.UInt32 format;        // 0x14
        public System.Int32 samplingRate;        // 0x18
        public System.Int32 numChannels;        // 0x1C
        public System.Int64 numSamples;        // 0x20
        public System.Boolean streamingFlag;        // 0x28
        public System.UInt32[] reserved;        // 0x30

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x2000039
    public struct AisacInfo
    {
        // Fields
        public readonly System.String name;        // 0x10
        public System.Boolean defaultControlFlag;        // 0x18
        public System.Single defaultControlValue;        // 0x1C
        public System.UInt32 controlId;        // 0x20
        public readonly System.String controlName;        // 0x28

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x200003A
    public struct PerformanceInfo
    {
        // Fields
        public System.UInt32 serverProcessCount;        // 0x10
        public System.UInt32 lastServerTime;        // 0x14
        public System.UInt32 maxServerTime;        // 0x18
        public System.UInt32 averageServerTime;        // 0x1C
        public System.UInt32 lastServerInterval;        // 0x20
        public System.UInt32 maxServerInterval;        // 0x24
        public System.UInt32 averageServerInterval;        // 0x28

    }

    // TypeToken: 0x200003B
    public struct ResourceUsage
    {
        // Fields
        public System.UInt32 useCount;        // 0x10
        public System.UInt32 limit;        // 0x14

    }

    // TypeToken: 0x200003C
    public struct NativeVector
    {
        // Fields
        public System.Single x;        // 0x10
        public System.Single y;        // 0x14
        public System.Single z;        // 0x18

        // Methods
        private System.Void .ctor(System.Single x, System.Single y, System.Single z) { }
        private System.Void .ctor(UnityEngine.Vector3 vector) { }

    }

    // TypeToken: 0x200003D
    public struct CueLinkInfo
    {
        // Fields
        public System.IntPtr nativePlayerHn;        // 0x10
        public System.UInt32 basePlaybackId;        // 0x18
        public System.UInt32 targetPlaybackId;        // 0x1C
        public System.Int32 cueLinkType;        // 0x20

    }

    // TypeToken: 0x200003E
    public class CueLinkCbFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(CriWare.CriAtomEx.CueLinkInfo& info) { }
        private System.IAsyncResult BeginInvoke(CriWare.CriAtomEx.CueLinkInfo& info, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(CriWare.CriAtomEx.CueLinkInfo& info, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000040
    public struct ReactType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExCategory.ReactType Ducker;        // 0x0
        public static CriWare.CriAtomExCategory.ReactType AisacModulationTrigger;        // 0x0

    }

    // TypeToken: 0x2000041
    public struct ReactDuckerTargetType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExCategory.ReactDuckerTargetType Volume;        // 0x0
        public static CriWare.CriAtomExCategory.ReactDuckerTargetType AisacControlValue;        // 0x0

    }

    // TypeToken: 0x2000042
    public struct ReactDuckerCurveType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExCategory.ReactDuckerCurveType Linear;        // 0x0
        public static CriWare.CriAtomExCategory.ReactDuckerCurveType Square;        // 0x0
        public static CriWare.CriAtomExCategory.ReactDuckerCurveType SquareReverse;        // 0x0
        public static CriWare.CriAtomExCategory.ReactDuckerCurveType SCurve;        // 0x0
        public static CriWare.CriAtomExCategory.ReactDuckerCurveType FlatAtHalf;        // 0x0

    }

    // TypeToken: 0x2000043
    public struct ReactFadeParameter
    {
        // Fields
        public CriWare.CriAtomExCategory.ReactDuckerCurveType curveType;        // 0x10
        public System.Single curveStrength;        // 0x14
        public System.UInt16 fadeTimeMs;        // 0x18

    }

    // TypeToken: 0x2000044
    public struct ReactHoldType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExCategory.ReactHoldType WhilePlaying;        // 0x0
        public static CriWare.CriAtomExCategory.ReactHoldType FixedTime;        // 0x0

    }

    // TypeToken: 0x2000046
    public struct Volume
    {
        // Fields
        public System.Single level;        // 0x10

    }

    // TypeToken: 0x2000047
    public struct AisacControl
    {
        // Fields
        public System.UInt32 id;        // 0x10
        public System.Single value;        // 0x14

    }

    // TypeToken: 0x2000048
    public struct Target
    {
        // Fields
        public CriWare.CriAtomExCategory.ReactDuckerParameter.Volume volume;        // 0x10
        public CriWare.CriAtomExCategory.ReactDuckerParameter.AisacControl aisacControl;        // 0x10

    }

    // TypeToken: 0x2000045
    public struct ReactDuckerParameter
    {
        // Fields
        public CriWare.CriAtomExCategory.ReactDuckerParameter.Target target;        // 0x10
        public CriWare.CriAtomExCategory.ReactDuckerTargetType targetType;        // 0x18
        public CriWare.CriAtomExCategory.ReactFadeParameter entry;        // 0x1C
        public CriWare.CriAtomExCategory.ReactFadeParameter exit;        // 0x28
        public CriWare.CriAtomExCategory.ReactHoldType holdType;        // 0x34
        public System.UInt16 holdTimeMs;        // 0x38

    }

    // TypeToken: 0x2000049
    public struct ReactAisacModulationParameter
    {
        // Fields
        private System.Int32 _enableDecrementAisacModulationKey;        // 0x10
        public System.UInt32 decrementAisacModulationKey;        // 0x14
        private System.Int32 _enableIncrementAisacModulationKey;        // 0x18
        public System.UInt32 incrementAisacModulationKey;        // 0x1C

        // Methods
        private System.Boolean get_enableDecrementAisacModulationKey() { }
        private System.Boolean get_enableIncrementAisacModulationKey() { }

    }

    // TypeToken: 0x200004B
    public struct Parameter
    {
        // Fields
        public CriWare.CriAtomExCategory.ReactDuckerParameter ducker;        // 0x10
        public CriWare.CriAtomExCategory.ReactAisacModulationParameter aisacModulation;        // 0x10

    }

    // TypeToken: 0x200004A
    public struct ReactParameter
    {
        // Fields
        public CriWare.CriAtomExCategory.ReactParameter.Parameter parameter;        // 0x10
        public CriWare.CriAtomExCategory.ReactType type;        // 0x3C
        public System.Boolean enablePausingCue;        // 0x40

    }

    // TypeToken: 0x200004C
    public struct ReactStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExCategory.ReactStatus Stop;        // 0x0
        public static CriWare.CriAtomExCategory.ReactStatus FadeOut;        // 0x0
        public static CriWare.CriAtomExCategory.ReactStatus Hold;        // 0x0
        public static CriWare.CriAtomExCategory.ReactStatus FadeIn;        // 0x0
        public static CriWare.CriAtomExCategory.ReactStatus Error;        // 0x0

    }

    // TypeToken: 0x200004E
    public struct CriAtomExSequenceEventInfo
    {
        // Fields
        public System.UInt64 position;        // 0x10
        public System.IntPtr playerHn;        // 0x18
        public readonly System.String tag;        // 0x20
        public System.UInt32 playbackId;        // 0x28
        private System.Int32 type;        // 0x2C
        public System.UInt32 id;        // 0x30
        private System.UInt32 reserved;        // 0x34

    }

    // TypeToken: 0x200004F
    public class EventCbFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String eventParamsString) { }
        private System.IAsyncResult BeginInvoke(System.String eventParamsString, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000050
    public class EventCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(CriWare.CriAtomExSequencer.CriAtomExSequenceEventInfo& criAtomExSequenceInfo) { }
        private System.IAsyncResult BeginInvoke(CriWare.CriAtomExSequencer.CriAtomExSequenceEventInfo& criAtomExSequenceInfo, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(CriWare.CriAtomExSequencer.CriAtomExSequenceEventInfo& criAtomExSequenceInfo, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000052
    public struct Info
    {
        // Fields
        public System.IntPtr playerHn;        // 0x10
        public System.UInt32 playbackId;        // 0x18
        public System.UInt32 barCount;        // 0x1C
        public System.UInt32 beatCount;        // 0x20
        public System.Single beatProgress;        // 0x24
        public System.Single bpm;        // 0x28
        public System.Int32 offset;        // 0x2C
        public System.UInt32 numBeats;        // 0x30

    }

    // TypeToken: 0x2000053
    public class CbFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(CriWare.CriAtomExBeatSync.Info& info) { }
        private System.IAsyncResult BeginInvoke(CriWare.CriAtomExBeatSync.Info& info, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(CriWare.CriAtomExBeatSync.Info& info, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000055
    public struct BusAnalyzerConfig
    {
        // Fields
        public System.Int32 interval;        // 0x10
        public System.Int32 peakHoldTime;        // 0x14

    }

    // TypeToken: 0x2000056
    public struct BusAnalyzerInfo
    {
        // Fields
        public System.Int32 numChannels;        // 0x10
        public System.Single[] rmsLevels;        // 0x18
        public System.Single[] peakLevels;        // 0x20
        public System.Single[] peakHoldLevels;        // 0x28

        // Methods
        private System.Void .ctor(System.Byte[] data) { }

    }

    // TypeToken: 0x2000058
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExLatencyEstimator.Status Stop;        // 0x0
        public static CriWare.CriAtomExLatencyEstimator.Status Processing;        // 0x0
        public static CriWare.CriAtomExLatencyEstimator.Status Done;        // 0x0
        public static CriWare.CriAtomExLatencyEstimator.Status Error;        // 0x0

    }

    // TypeToken: 0x2000059
    public struct EstimatorInfo
    {
        // Fields
        public CriWare.CriAtomExLatencyEstimator.Status status;        // 0x10
        public System.UInt32 estimated_latency;        // 0x14

    }

    // TypeToken: 0x200005B
    public struct Config
    {
        // Fields
        public System.Int32 reserved;        // 0x10

    }

    // TypeToken: 0x200005D
    public struct Config
    {
        // Fields
        public System.Boolean enableVoicePriorityDecay;        // 0x10
        public System.UInt32 randomPositionListMaxLength;        // 0x14

        // Methods
        private System.Void .ctor(System.Boolean enableVoicePriorityDecay, System.UInt32 randomPositionListMaxLength) { }

    }

    // TypeToken: 0x200005F
    public struct Config
    {
        // Fields
        public System.Int32 reserved;        // 0x10

    }

    // TypeToken: 0x2000060
    public class UnsafeNativeMethods
    {
        // Methods
        private System.IntPtr criAtomEx3dTransceiver_Create(CriWare.CriAtomEx3dTransceiver.Config& config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomEx3dTransceiver_Destroy(System.IntPtr ex_3d_transceiver) { }
        private System.Void criAtomEx3dTransceiver_Update(System.IntPtr ex_3d_transceiver) { }
        private System.Void criAtomEx3dTransceiver_SetInputPosition(System.IntPtr ex_3d_transceiver, CriWare.CriAtomEx.NativeVector& position) { }
        private System.Void criAtomEx3dTransceiver_SetOutputPosition(System.IntPtr ex_3d_transceiver, CriWare.CriAtomEx.NativeVector& position) { }
        private System.Void criAtomEx3dTransceiver_SetInputOrientation(System.IntPtr ex_3d_transceiver, CriWare.CriAtomEx.NativeVector& front, CriWare.CriAtomEx.NativeVector& top) { }
        private System.Void criAtomEx3dTransceiver_SetOutputOrientation(System.IntPtr ex_3d_transceiver, CriWare.CriAtomEx.NativeVector& front, CriWare.CriAtomEx.NativeVector& top) { }
        private System.Void criAtomEx3dTransceiver_SetOutputConeParameter(System.IntPtr ex_3d_transceiver, System.Single inside_angle, System.Single outside_angle, System.Single outside_volume) { }
        private System.Void criAtomEx3dTransceiver_SetOutputMinMaxAttenuationDistance(System.IntPtr ex_3d_transceiver, System.Single min_attenuation_distance, System.Single max_attenuation_distance) { }
        private System.Void criAtomEx3dTransceiver_SetOutputInteriorPanField(System.IntPtr ex_3d_transceiver, System.Single transceiver_radius, System.Single interior_distance) { }
        private System.Void criAtomEx3dTransceiver_SetInputCrossFadeField(System.IntPtr ex_3d_transceiver, System.Single direct_audio_radius, System.Single crossfade_distance) { }
        private System.Void criAtomEx3dTransceiver_SetOutputVolume(System.IntPtr ex_3d_transceiver, System.Single volume) { }
        private System.Void criAtomEx3dTransceiver_AttachAisac(System.IntPtr ex_3d_transceiver, System.String global_aisac_name) { }
        private System.Void criAtomEx3dTransceiver_DetachAisac(System.IntPtr ex_3d_transceiver, System.String global_aisac_name) { }
        private System.Void criAtomEx3dTransceiver_SetMaxAngleAisacDelta(System.IntPtr ex_3d_transceiver, System.Single max_delta) { }
        private System.Void criAtomEx3dTransceiver_SetDistanceAisacControlId(System.IntPtr ex_3d_transceiver, System.UInt16 aisac_control_id) { }
        private System.Void criAtomEx3dTransceiver_SetListenerBasedAzimuthAngleAisacControlId(System.IntPtr ex_3d_transceiver, System.UInt16 aisac_control_id) { }
        private System.Void criAtomEx3dTransceiver_SetListenerBasedElevationAngleAisacControlId(System.IntPtr ex_3d_transceiver, System.UInt16 aisac_control_id) { }
        private System.Void criAtomEx3dTransceiver_SetTransceiverOutputBasedAzimuthAngleAisacControlId(System.IntPtr ex_3d_transceiver, System.UInt16 aisac_control_id) { }
        private System.Void criAtomEx3dTransceiver_SetTransceiverOutputBasedElevationAngleAisacControlId(System.IntPtr ex_3d_transceiver, System.UInt16 aisac_control_id) { }
        private System.Void criAtomEx3dTransceiver_Set3dRegionHn(System.IntPtr ex_3d_transceiver, System.IntPtr ex_3d_region) { }

    }

    // TypeToken: 0x2000062
    public struct Config
    {
        // Fields
        public System.Int32 reserved;        // 0x10

    }

    // TypeToken: 0x2000063
    public class UnsafeNativeMethods
    {
        // Methods
        private System.IntPtr criAtomEx3dRegion_Create(CriWare.CriAtomEx3dRegion.Config& config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomEx3dRegion_Destroy(System.IntPtr ex_3d_region) { }

    }

    // TypeToken: 0x2000066
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExAcbLoader.Status Stop;        // 0x0
        public static CriWare.CriAtomExAcbLoader.Status Loading;        // 0x0
        public static CriWare.CriAtomExAcbLoader.Status Complete;        // 0x0
        public static CriWare.CriAtomExAcbLoader.Status Error;        // 0x0

    }

    // TypeToken: 0x2000067
    public struct LoaderConfig
    {
        // Fields
        public System.Boolean shouldLoadAwbOnMemory;        // 0x10

    }

    // TypeToken: 0x2000069
    public struct AcfDspSettingInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.UInt16[] busIndexes;        // 0x18
        public System.UInt16[] extendBusIndexes;        // 0x20
        public System.UInt16 snapshotStartIndex;        // 0x28
        public System.Byte numBuses;        // 0x2A
        public System.Byte numExtendBuses;        // 0x2B
        public System.UInt16 numSnapshots;        // 0x2C
        public System.UInt16 snapshotWorkSize;        // 0x2E
        public System.UInt16 numMixerAisacs;        // 0x30
        public System.UInt16 mixerAisacStartIndex;        // 0x32

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x200006A
    public struct AcfDspSettingSnapshotInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.Byte numBuses;        // 0x18
        public System.Byte numExtendBuses;        // 0x19
        public System.Byte[] reserved;        // 0x20
        public System.UInt16[] busIndexes;        // 0x28
        public System.UInt16[] extendBusIndexes;        // 0x30

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x200006B
    public struct AcfDspBusInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.Single volume;        // 0x18
        public System.Single pan3dVolume;        // 0x1C
        public System.Single pan3dAngle;        // 0x20
        public System.Single pan3dDistance;        // 0x24
        public System.Single pan3dSpread;        // 0x28
        public System.UInt16[] fxIndexes;        // 0x30
        public System.UInt16[] busLinkIndexes;        // 0x38
        public System.UInt16 busNo;        // 0x40
        public System.Byte numFxes;        // 0x42
        public System.Byte numBusLinks;        // 0x43

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x200006C
    public struct AcfDspBusLinkType
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static CriWare.CriAtomExAcf.AcfDspBusLinkType preVolume;        // 0x0
        public static CriWare.CriAtomExAcf.AcfDspBusLinkType postVolume;        // 0x0
        public static CriWare.CriAtomExAcf.AcfDspBusLinkType postPan;        // 0x0

    }

    // TypeToken: 0x200006D
    public struct AcfDspBusLinkInfo
    {
        // Fields
        public CriWare.CriAtomExAcf.AcfDspBusLinkType type;        // 0x10
        public System.Single sendLevel;        // 0x14
        public System.UInt16 busNo;        // 0x18
        public System.UInt16 busId;        // 0x1A

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x200006E
    public struct CategoryInfo
    {
        // Fields
        public System.UInt32 groupNo;        // 0x10
        public System.UInt32 id;        // 0x14
        public System.String name;        // 0x18
        public System.UInt32 numCueLimits;        // 0x20
        public System.Single volume;        // 0x24

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x200006F
    public struct AcfAisacType
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static CriWare.CriAtomExAcf.AcfAisacType normal;        // 0x0
        public static CriWare.CriAtomExAcf.AcfAisacType autoModulation;        // 0x0

    }

    // TypeToken: 0x2000070
    public struct GlobalAisacInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.UInt16 index;        // 0x18
        public System.UInt16 numGraphs;        // 0x1A
        public CriWare.CriAtomExAcf.AcfAisacType type;        // 0x1C
        public System.Single randomRange;        // 0x20
        public System.UInt16 controlId;        // 0x24
        public System.UInt16 dummy;        // 0x26

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x2000071
    public struct AisacGraphType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExAcf.AisacGraphType none;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType volume;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType pitch;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType bandpassHigh;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType bandpassLow;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType biquadFreq;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType biquadQ;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType busSend0;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType busSend1;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType busSend2;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType busSend3;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType busSend4;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType busSend5;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType busSend6;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType busSend7;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType pan3dAngel;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType pan3dVolume;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType pan3dInteriorDistance;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType pan3dCenter;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType pan3dLfe;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac0;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac1;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac2;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac3;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac4;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac5;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac6;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac7;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac8;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac9;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac10;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac11;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac12;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac13;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac14;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType aisac15;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType priority;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType preDelayTime;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType biquadGain;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType pan3dMixdownCenter;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType pan3dMixdownLfe;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType egAttack;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType egRelease;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType playbackRatio;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType drySendL;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType drySendR;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType drySendCenter;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType drySendLfe;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType drySendSl;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType drySendSr;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType drySendEx1;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType drySendEx2;        // 0x0
        public static CriWare.CriAtomExAcf.AisacGraphType panSpread;        // 0x0

    }

    // TypeToken: 0x2000072
    public struct AisacGraphInfo
    {
        // Fields
        public CriWare.CriAtomExAcf.AisacGraphType type;        // 0x10

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x2000073
    public struct CharacterEncoding
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static CriWare.CriAtomExAcf.CharacterEncoding utf8;        // 0x0
        public static CriWare.CriAtomExAcf.CharacterEncoding sjis;        // 0x0

    }

    // TypeToken: 0x2000074
    public struct AcfInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.UInt32 size;        // 0x18
        public System.UInt32 version;        // 0x1C
        public CriWare.CriAtomExAcf.CharacterEncoding characterEncoding;        // 0x20
        public System.Int32 numDspSettings;        // 0x24
        public System.Int32 numCategories;        // 0x28
        public System.Int32 numCategoriesPerPlayback;        // 0x2C
        public System.Int32 numReacts;        // 0x30
        public System.Int32 numAisacControls;        // 0x34
        public System.Int32 numGlobalAisacs;        // 0x38
        public System.Int32 numGameVariables;        // 0x3C
        public System.Int32 maxBusesOfDspBusSettings;        // 0x40
        public System.Int32 numBuses;        // 0x44
        public System.Int32 numVoiceLimitGroups;        // 0x48
        public System.Int32 numOutputPorts;        // 0x4C

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x2000075
    public struct SelectorInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.UInt16 index;        // 0x18
        public System.UInt16 numLabels;        // 0x1A
        public System.UInt16 globalLabelIndex;        // 0x1C

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x2000076
    public struct SelectorLabelInfo
    {
        // Fields
        public System.String selectorName;        // 0x10
        public System.String labelName;        // 0x18

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x2000078
    public struct SpeakerMapping
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExAsrRack.SpeakerMapping Auto;        // 0x0
        public static CriWare.CriAtomExAsrRack.SpeakerMapping Monaural;        // 0x0
        public static CriWare.CriAtomExAsrRack.SpeakerMapping Stereo;        // 0x0
        public static CriWare.CriAtomExAsrRack.SpeakerMapping Ch5_1;        // 0x0
        public static CriWare.CriAtomExAsrRack.SpeakerMapping Ch7_1;        // 0x0
        public static CriWare.CriAtomExAsrRack.SpeakerMapping Ch5_1_2;        // 0x0
        public static CriWare.CriAtomExAsrRack.SpeakerMapping Ch7_1_4;        // 0x0

    }

    // TypeToken: 0x2000079
    public struct Config
    {
        // Fields
        public System.Single serverFrequency;        // 0x10
        public System.Int32 numBuses;        // 0x14
        public System.Int32 outputChannels;        // 0x18
        public CriWare.CriAtomExAsrRack.SpeakerMapping speakerMapping;        // 0x1C
        public System.Int32 outputSamplingRate;        // 0x20
        public CriWare.CriAtomEx.SoundRendererType soundRendererType;        // 0x24
        public System.Int32 outputRackId;        // 0x28
        public System.IntPtr context;        // 0x30

    }

    // TypeToken: 0x200007A
    public struct PlatformConfig
    {
        // Fields
        public System.Byte reserved;        // 0x10

    }

    // TypeToken: 0x200007B
    public struct PerformanceInfo
    {
        // Fields
        public System.UInt32 processCount;        // 0x10
        public System.UInt32 lastProcessTime;        // 0x14
        public System.UInt32 maxProcessTime;        // 0x18
        public System.UInt32 averageProcessTime;        // 0x1C
        public System.UInt32 lastProcessInterval;        // 0x20
        public System.UInt32 maxProcessInterval;        // 0x24
        public System.UInt32 averageProcessInterval;        // 0x28
        public System.UInt32 lastProcessSamples;        // 0x2C
        public System.UInt32 maxProcessSamples;        // 0x30
        public System.UInt32 averageProcessSamples;        // 0x34

    }

    // TypeToken: 0x200007D
    public struct Config
    {
        // Fields
        public System.Int32 maxChannels;        // 0x10
        public System.Int32 maxSamplingRate;        // 0x14
        public CriWare.CriAtomEx.SoundRendererType soundRendererType;        // 0x18

        // Methods
        private CriWare.CriAtomExAuxIn.Config get_Default() { }

    }

    // TypeToken: 0x200007F
    public struct DeviceInfo
    {
        // Fields
        public System.String deviceId;        // 0x10
        public System.String deviceName;        // 0x18
        public System.UInt32 deviceFlags;        // 0x20
        public System.Int32 maxChannels;        // 0x24
        public System.Int32 maxSamplingRate;        // 0x28

    }

    // TypeToken: 0x2000080
    public struct Config
    {
        // Fields
        public System.String deviceId;        // 0x10
        public System.UInt32 flags;        // 0x18
        public System.Int32 numChannels;        // 0x1C
        public System.Int32 samplingRate;        // 0x20
        public System.UInt32 frameSize;        // 0x24
        public System.UInt32 bufferingTime;        // 0x28
        public System.IntPtr context;        // 0x30

        // Methods
        private CriWare.CriAtomExMic.Config get_Default() { }

    }

    // TypeToken: 0x2000081
    public class Effect
    {
        // Fields
        private System.IntPtr <handle>k__BackingField;        // 0x10
        private System.IntPtr <afxInstance>k__BackingField;        // 0x18

        // Methods
        private System.IntPtr get_handle() { }
        private System.Void set_handle(System.IntPtr value) { }
        private System.IntPtr get_afxInstance() { }
        private System.Void set_afxInstance(System.IntPtr value) { }
        private System.Void .ctor(System.IntPtr handle, System.IntPtr afxInstance) { }

    }

    // TypeToken: 0x2000083
    public class PcmCaptureCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Single[] dataL, System.Single[] dataR, System.Int32 numChannels, System.Int32 numData) { }
        private System.IAsyncResult BeginInvoke(System.Single[] dataL, System.Single[] dataR, System.Int32 numChannels, System.Int32 numData, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000084
    public struct Config
    {
        // Fields
        public System.Boolean enableLevelmeter;        // 0x10
        public System.Boolean enableSpectrumAnalyzer;        // 0x11
        public System.Boolean enablePcmCapture;        // 0x12
        public System.Boolean enablePcmCaptureCallback;        // 0x13
        public System.Int32 numSpectrumAnalyzerBands;        // 0x14
        public System.Int32 numCapturedPcmSamples;        // 0x18

    }

    // TypeToken: 0x2000085
    public class InternalPcmCaptureCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.IntPtr dataL, System.IntPtr dataR, System.Int32 numChannels, System.Int32 numData) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr dataL, System.IntPtr dataR, System.Int32 numChannels, System.Int32 numData, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000087
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExPlayback.Status Prep;        // 0x0
        public static CriWare.CriAtomExPlayback.Status Playing;        // 0x0
        public static CriWare.CriAtomExPlayback.Status Removed;        // 0x0

    }

    // TypeToken: 0x2000088
    public struct TrackInfo
    {
        // Fields
        public System.UInt32 id;        // 0x10
        public CriWare.CriAtomEx.CueType sequenceType;        // 0x14
        public System.IntPtr playerHn;        // 0x18
        public System.UInt16 trackNo;        // 0x20
        public System.UInt16 reserved;        // 0x22

    }

    // TypeToken: 0x200008A
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExPlayer.Status Stop;        // 0x0
        public static CriWare.CriAtomExPlayer.Status Prep;        // 0x0
        public static CriWare.CriAtomExPlayer.Status Playing;        // 0x0
        public static CriWare.CriAtomExPlayer.Status PlayEnd;        // 0x0
        public static CriWare.CriAtomExPlayer.Status Error;        // 0x0

    }

    // TypeToken: 0x200008B
    public struct Config
    {
        // Fields
        public CriWare.CriAtomEx.VoiceAllocationMethod voiceAllocationMethod;        // 0x10
        public System.Int32 maxPathStrings;        // 0x14
        public System.Int32 maxPath;        // 0x18
        public System.Int32 maxAisacs;        // 0x1C
        public System.Boolean updatesTime;        // 0x20
        public System.Boolean enableAudioSyncedTimer;        // 0x21

    }

    // TypeToken: 0x200008C
    public struct TimeStretchParameterId
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExPlayer.TimeStretchParameterId Ratio;        // 0x0
        public static CriWare.CriAtomExPlayer.TimeStretchParameterId FrameTime;        // 0x0
        public static CriWare.CriAtomExPlayer.TimeStretchParameterId Quality;        // 0x0

    }

    // TypeToken: 0x200008D
    public struct PitchShifterParameterId
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExPlayer.PitchShifterParameterId Pitch;        // 0x0
        public static CriWare.CriAtomExPlayer.PitchShifterParameterId Formant;        // 0x0
        public static CriWare.CriAtomExPlayer.PitchShifterParameterId Mode;        // 0x0

    }

    // TypeToken: 0x200008F
    public struct Type
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExPlayerOutputAnalyzer.Type LevelMeter;        // 0x0
        public static CriWare.CriAtomExPlayerOutputAnalyzer.Type SpectrumAnalyzer;        // 0x0
        public static CriWare.CriAtomExPlayerOutputAnalyzer.Type PcmCapture;        // 0x0

    }

    // TypeToken: 0x2000090
    public struct Config
    {
        // Fields
        public System.Int32 num_spectrum_analyzer_bands;        // 0x10
        public System.Int32 num_stored_output_data;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 num_spectrum_analyzer_bands, System.Int32 num_stored_output_data) { }

    }

    // TypeToken: 0x2000092
    public struct Config
    {
        // Fields
        public System.Boolean enableVoiceLimitScope;        // 0x10
        public System.Boolean enableCategoryCueLimitScope;        // 0x11

    }

    // TypeToken: 0x2000094
    public struct ParameterType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExTween.ParameterType Basic;        // 0x0
        public static CriWare.CriAtomExTween.ParameterType Aisac;        // 0x0

    }

    // TypeToken: 0x2000096
    public struct Target
    {
        // Fields
        public CriWare.CriAtomEx.Parameter parameterId;        // 0x10
        public System.UInt32 aisacIds;        // 0x10

    }

    // TypeToken: 0x2000095
    public struct Config
    {
        // Fields
        public CriWare.CriAtomExTween.Config.Target target;        // 0x10
        public CriWare.CriAtomExTween.ParameterType parameterType;        // 0x14

    }

    // TypeToken: 0x2000098
    public struct VoicePoolId
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExVoicePool.VoicePoolId StandardMemory;        // 0x0
        public static CriWare.CriAtomExVoicePool.VoicePoolId StandardStreaming;        // 0x0
        public static CriWare.CriAtomExVoicePool.VoicePoolId HcaMxMemory;        // 0x0
        public static CriWare.CriAtomExVoicePool.VoicePoolId HcaMxStreaming;        // 0x0

    }

    // TypeToken: 0x2000099
    public struct PitchShifterMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExVoicePool.PitchShifterMode Music;        // 0x0
        public static CriWare.CriAtomExVoicePool.PitchShifterMode Vocal;        // 0x0
        public static CriWare.CriAtomExVoicePool.PitchShifterMode SoundEffect;        // 0x0
        public static CriWare.CriAtomExVoicePool.PitchShifterMode Speech;        // 0x0

    }

    // TypeToken: 0x200009A
    public struct UsedVoicesInfo
    {
        // Fields
        public System.Int32 numUsedVoices;        // 0x10
        public System.Int32 numPoolVoices;        // 0x14

    }

    // TypeToken: 0x200009B
    public struct PlayerConfig
    {
        // Fields
        public System.Int32 maxChannels;        // 0x10
        public System.Int32 maxSamplingRate;        // 0x14
        public System.Boolean streamingFlag;        // 0x18
        public System.Int32 soundRendererType;        // 0x1C
        public System.Int32 decodeLatency;        // 0x20
        private System.IntPtr context;        // 0x28

    }

    // TypeToken: 0x200009C
    public struct VoicePoolConfig
    {
        // Fields
        public System.UInt32 identifier;        // 0x10
        public System.Int32 numVoices;        // 0x14
        public CriWare.CriAtomExVoicePool.PlayerConfig playerConfig;        // 0x18

    }

    // TypeToken: 0x200009D
    public struct PitchShifterConfig
    {
        // Fields
        public System.Int32 mode;        // 0x10
        public System.Int32 windowSize;        // 0x14
        public System.Int32 overlapTimes;        // 0x18

    }

    // TypeToken: 0x200009E
    public struct ExPitchShifterConfig
    {
        // Fields
        public System.Int32 numDsp;        // 0x10
        public System.Int32 maxChannels;        // 0x14
        public System.Int32 maxSamplingRate;        // 0x18
        public CriWare.CriAtomExVoicePool.PitchShifterConfig config;        // 0x1C

    }

    // TypeToken: 0x200009F
    public struct TimeStretchConfig
    {
        // Fields
        public System.Int32 reserved;        // 0x10

    }

    // TypeToken: 0x20000A0
    public struct ExTimeStretchConfig
    {
        // Fields
        public System.Int32 numDsp;        // 0x10
        public System.Int32 maxChannels;        // 0x14
        public System.Int32 maxSamplingRate;        // 0x18
        public CriWare.CriAtomExVoicePool.TimeStretchConfig config;        // 0x1C

    }

    // TypeToken: 0x20000A4
    public struct RawPcmFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExRawPcmVoicePool.RawPcmFormat Sint16;        // 0x0
        public static CriWare.CriAtomExRawPcmVoicePool.RawPcmFormat Float32;        // 0x0

    }

    // TypeToken: 0x20000A5
    public struct RawPcmPlayerConfig
    {
        // Fields
        public CriWare.CriAtomExRawPcmVoicePool.RawPcmFormat format;        // 0x10
        public System.Int32 maxChannels;        // 0x14
        public System.Int32 maxSamplingRate;        // 0x18
        public System.Int32 soundRendererType;        // 0x1C
        public System.Int32 decodeLatency;        // 0x20
        private System.IntPtr context;        // 0x28

    }

    // TypeToken: 0x20000A6
    public struct RawPcmVoicePoolConfig
    {
        // Fields
        public System.UInt32 identifier;        // 0x10
        public System.Int32 numVoices;        // 0x14
        public CriWare.CriAtomExRawPcmVoicePool.RawPcmPlayerConfig playerConfig;        // 0x18

    }

    // TypeToken: 0x20000A8
    public class InternalDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.UInt32 Invoke(System.IntPtr cbobj, System.IntPtr data, System.UInt32 numSamples) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr cbobj, System.IntPtr data, System.UInt32 numSamples, System.AsyncCallback callback, System.Object object) { }
        private System.UInt32 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000A9
    public class Delegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.UInt32 Invoke(System.Single[][] buffer, System.UInt32 numSamples) { }
        private System.IAsyncResult BeginInvoke(System.Single[][] buffer, System.UInt32 numSamples, System.AsyncCallback callback, System.Object object) { }
        private System.UInt32 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000AC
    public class InternalDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.UInt32 Invoke(System.IntPtr cbobj, System.IntPtr data, System.UInt32 numSamples) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr cbobj, System.IntPtr data, System.UInt32 numSamples, System.AsyncCallback callback, System.Object object) { }
        private System.UInt32 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000AD
    public class Delegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.UInt32 Invoke(System.Single[][] buffer, System.UInt32 numSamples) { }
        private System.IAsyncResult BeginInvoke(System.Single[][] buffer, System.UInt32 numSamples, System.AsyncCallback callback, System.Object object) { }
        private System.UInt32 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000B0
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriFsLoader.Status Stop;        // 0x0
        public static CriWare.CriFsLoader.Status Loading;        // 0x0
        public static CriWare.CriFsLoader.Status Complete;        // 0x0
        public static CriWare.CriFsLoader.Status Error;        // 0x0

    }

    // TypeToken: 0x20000B2
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriFsInstaller.Status Stop;        // 0x0
        public static CriWare.CriFsInstaller.Status Busy;        // 0x0
        public static CriWare.CriFsInstaller.Status Complete;        // 0x0
        public static CriWare.CriFsInstaller.Status Error;        // 0x0

    }

    // TypeToken: 0x20000B3
    public struct CopyPolicy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriFsInstaller.CopyPolicy Always;        // 0x0

    }

    // TypeToken: 0x20000B5
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriFsBinder.Status None;        // 0x0
        public static CriWare.CriFsBinder.Status Analyze;        // 0x0
        public static CriWare.CriFsBinder.Status Complete;        // 0x0
        public static CriWare.CriFsBinder.Status Unbind;        // 0x0
        public static CriWare.CriFsBinder.Status Removed;        // 0x0
        public static CriWare.CriFsBinder.Status Invalid;        // 0x0
        public static CriWare.CriFsBinder.Status Error;        // 0x0

    }

    // TypeToken: 0x20000B6
    public struct ContentsFileInfo
    {
        // Fields
        public readonly System.String directory;        // 0x10
        public readonly System.String fileName;        // 0x18
        public System.UInt32 readSize;        // 0x20
        public System.UInt32 extractSize;        // 0x24
        public System.UInt64 offset;        // 0x28
        public System.Int32 fileId;        // 0x30
        private System.String userStr;        // 0x38

        // Methods
        private System.Void .ctor(System.Byte[] data, System.Int32 startIndex) { }

    }

    // TypeToken: 0x20000B8
    public class DoneDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(CriWare.CriFsRequest request) { }
        private System.IAsyncResult BeginInvoke(CriWare.CriFsRequest request, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000BB
    public struct Phase
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriFsLoadFileRequest.Phase Stop;        // 0x0
        public static CriWare.CriFsLoadFileRequest.Phase Bind;        // 0x0
        public static CriWare.CriFsLoadFileRequest.Phase Load;        // 0x0
        public static CriWare.CriFsLoadFileRequest.Phase Done;        // 0x0
        public static CriWare.CriFsLoadFileRequest.Phase Error;        // 0x0

    }

    // TypeToken: 0x20000C1
    public struct BindType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriFsBindRequest.BindType Cpk;        // 0x0
        public static CriWare.CriFsBindRequest.BindType Directory;        // 0x0
        public static CriWare.CriFsBindRequest.BindType File;        // 0x0

    }

    // TypeToken: 0x20000C6
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriFsWebInstaller.Status Stop;        // 0x0
        public static CriWare.CriFsWebInstaller.Status Busy;        // 0x0
        public static CriWare.CriFsWebInstaller.Status Complete;        // 0x0
        public static CriWare.CriFsWebInstaller.Status Error;        // 0x0

    }

    // TypeToken: 0x20000C7
    public struct Error
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriFsWebInstaller.Error None;        // 0x0
        public static CriWare.CriFsWebInstaller.Error Timeout;        // 0x0
        public static CriWare.CriFsWebInstaller.Error Memory;        // 0x0
        public static CriWare.CriFsWebInstaller.Error LocalFs;        // 0x0
        public static CriWare.CriFsWebInstaller.Error DNS;        // 0x0
        public static CriWare.CriFsWebInstaller.Error Connection;        // 0x0
        public static CriWare.CriFsWebInstaller.Error SSL;        // 0x0
        public static CriWare.CriFsWebInstaller.Error HTTP;        // 0x0
        public static CriWare.CriFsWebInstaller.Error Internal;        // 0x0

    }

    // TypeToken: 0x20000C8
    public struct StatusInfo
    {
        // Fields
        public CriWare.CriFsWebInstaller.Status status;        // 0x10
        public CriWare.CriFsWebInstaller.Error error;        // 0x14
        public System.Int32 httpStatusCode;        // 0x18
        public System.Int64 contentsSize;        // 0x20
        public System.Int64 receivedSize;        // 0x28

    }

    // TypeToken: 0x20000C9
    public struct ModuleConfig
    {
        // Fields
        public System.UInt32 numInstallers;        // 0x10
        public System.String proxyHost;        // 0x18
        public System.UInt16 proxyPort;        // 0x20
        public System.String userAgent;        // 0x28
        public System.UInt32 inactiveTimeoutSec;        // 0x30
        public System.Boolean allowInsecureSSL;        // 0x34
        public System.Boolean crcEnabled;        // 0x35
        public CriWare.CriFsWebInstaller.ModulePlatformConfig platformConfig;        // 0x36

    }

    // TypeToken: 0x20000CA
    public struct ModulePlatformConfig
    {
        // Fields
        public System.Byte reserved;        // 0x10

        // Methods
        private CriWare.CriFsWebInstaller.ModulePlatformConfig get_defaultConfig() { }

    }

    // TypeToken: 0x20000D1
    public struct MaxFrameDrop
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop Disabled;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop One;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop Two;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop Three;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop Four;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop Five;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop Six;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop Seven;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop Eight;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop Nine;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop Ten;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.MaxFrameDrop Infinite;        // 0x0

    }

    // TypeToken: 0x20000D2
    public struct RenderMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriManaMovieMaterialBase.RenderMode Always;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.RenderMode OnVisibility;        // 0x0
        public static CriWare.CriManaMovieMaterialBase.RenderMode Never;        // 0x0

    }

    // TypeToken: 0x20000D3
    public class OnApplicationPauseCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(CriWare.CriManaMovieMaterialBase manaMovieMaterial, System.Boolean appPause) { }
        private System.IAsyncResult BeginInvoke(CriWare.CriManaMovieMaterialBase manaMovieMaterial, System.Boolean appPause, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000D8
    public struct CpuUsage
    {
        // Fields
        public System.Single last;        // 0x10
        public System.Single average;        // 0x14
        public System.Single peak;        // 0x18

    }

    // TypeToken: 0x20000DA
    public class CallbackFromNativeDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.UInt64 Invoke(System.IntPtr ptr1) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr ptr1, System.AsyncCallback callback, System.Object object) { }
        private System.UInt64 EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000DC
    public class Callback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String message) { }
        private System.IAsyncResult BeginInvoke(System.String message, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000DE
    public class Callback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String message) { }
        private System.IAsyncResult BeginInvoke(System.String message, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000DF
    public class ErrorCallbackFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.IntPtr errmsgPtr, System.UInt32 p1, System.UInt32 p2, System.IntPtr parray) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr errmsgPtr, System.UInt32 p1, System.UInt32 p2, System.IntPtr parray, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000E0
    public class NativeMethod
    {
        // Methods
        private System.Void criErr_SetCallback(CriWare.CriErrorNotifier.ErrorCallbackFunc callback) { }
        private System.IntPtr criErr_ConvertIdToMessage(System.IntPtr errmsgPtr, System.UInt32 p1, System.UInt32 p2) { }

    }

    // TypeToken: 0x20000E3
    public class StandardVoicePoolConfig
    {
        // Fields
        public System.Int32 memoryVoices;        // 0x10
        public System.Int32 streamingVoices;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E4
    public class HcaMxVoicePoolConfig
    {
        // Fields
        public System.Int32 memoryVoices;        // 0x10
        public System.Int32 streamingVoices;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E5
    public struct InGamePreviewSwitchMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomConfig.InGamePreviewSwitchMode Disable;        // 0x0
        public static CriWare.CriAtomConfig.InGamePreviewSwitchMode Enable;        // 0x0
        public static CriWare.CriAtomConfig.InGamePreviewSwitchMode FollowBuildSetting;        // 0x0
        public static CriWare.CriAtomConfig.InGamePreviewSwitchMode Default;        // 0x0

    }

    // TypeToken: 0x20000E6
    public class InGamePreviewConfig
    {
        // Fields
        public System.Int32 maxPreviewObjects;        // 0x10
        public System.Int32 communicationBufferSize;        // 0x14
        public System.Int32 playbackPositionUpdateInterval;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E7
    public class EditorPcmOutputConfig
    {
        // Fields
        public System.Boolean enable;        // 0x10
        public System.Int32 bufferLength;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E8
    public struct LinuxOutput
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomConfig.LinuxOutput Default;        // 0x0
        public static CriWare.CriAtomConfig.LinuxOutput PulseAudio;        // 0x0
        public static CriWare.CriAtomConfig.LinuxOutput ALSA;        // 0x0

    }

    // TypeToken: 0x20000E9
    public class AndroidLowLatencyStandardVoicePoolConfig
    {
        // Fields
        public System.Int32 memoryVoices;        // 0x10
        public System.Int32 streamingVoices;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EA
    public class VitaManaVoicePoolConfig
    {
        // Fields
        public System.Int32 numberOfManaDecoders;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EB
    public class VitaAtrac9VoicePoolConfig
    {
        // Fields
        public System.Int32 memoryVoices;        // 0x10
        public System.Int32 streamingVoices;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EC
    public class Ps4Atrac9VoicePoolConfig
    {
        // Fields
        public System.Int32 memoryVoices;        // 0x10
        public System.Int32 streamingVoices;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000ED
    public class Ps5PortConfig
    {
        // Fields
        public System.Int32 maxChannelPorts;        // 0x10
        public System.Int32 maxObjectPorts;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EE
    public class SwitchOpusVoicePoolConfig
    {
        // Fields
        public System.Int32 memoryVoices;        // 0x10
        public System.Int32 streamingVoices;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F0
    public class VoicePoolConfig
    {
        // Fields
        public System.Int32 memoryVoices;        // 0x10
        public System.Int32 streamingVoices;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EF
    public class Ps4Audio3dConfig
    {
        // Fields
        public System.Boolean useAudio3D;        // 0x10
        public CriWare.CriAtomConfig.Ps4Audio3dConfig.VoicePoolConfig voicePoolConfig;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F1
    public class WebGLWebAudioVoicePoolConfig
    {
        // Fields
        public System.Int32 voices;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F3
    public class PCH264PlaybackConfig
    {
        // Fields
        public System.Boolean useH264Playback;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F4
    public class VitaH264PlaybackConfig
    {
        // Fields
        public System.Boolean useH264Playback;        // 0x10
        public System.Int32 maxWidth;        // 0x14
        public System.Int32 maxHeight;        // 0x18
        public System.Boolean getMemoryFromTexture;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F5
    public class WebGLConfig
    {
        // Fields
        public System.String webworkerPath;        // 0x10
        public System.Int32 heapSize;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F9
    public struct ResourcesInfo
    {
        // Fields
        public CriWare.CriAtomEx.ResourceUsage virtualVoiceUsage;        // 0x10
        public CriWare.CriAtomEx.ResourceUsage sequenceUsage;        // 0x18
        public CriWare.CriAtomEx.ResourceUsage sequenceTrackUsage;        // 0x20
        public CriWare.CriAtomEx.ResourceUsage sequenceTrackItemUsage;        // 0x28

    }

    // TypeToken: 0x20000FB
    public struct CategoryInfo
    {
        // Fields
        public System.UInt32 groupNo;        // 0x10
        public System.UInt32 id;        // 0x14
        public System.String name;        // 0x18
        public System.UInt32 numCueLimits;        // 0x20
        public System.Single volume;        // 0x24

    }

    // TypeToken: 0x20000FC
    public struct DspBusInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.Single volume;        // 0x18
        public System.Single pan3dVolume;        // 0x1C
        public System.Single pan3dAngle;        // 0x20
        public System.Single pan3dDistance;        // 0x24
        public System.Single pan3dSpread;        // 0x28
        public System.UInt16[] fxIndexes;        // 0x30
        public System.UInt16[] busLinkIndexes;        // 0x38
        public System.UInt16 busNo;        // 0x40
        public System.Byte numFxes;        // 0x42
        public System.Byte numBusLinks;        // 0x43

    }

    // TypeToken: 0x20000FD
    public struct AisacControlInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.UInt32 id;        // 0x18

    }

    // TypeToken: 0x20000FE
    public struct AisacType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriAtomExAcfDebug.AisacType Normal;        // 0x0
        public static CriWare.CriAtomExAcfDebug.AisacType AutoModulation;        // 0x0

    }

    // TypeToken: 0x20000FF
    public struct GlobalAisacInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.UInt16 index;        // 0x18
        public System.UInt16 numGraphs;        // 0x1A
        public CriWare.CriAtomExAcfDebug.AisacType type;        // 0x1C
        public System.Single randomRange;        // 0x20
        public System.UInt16 controlId;        // 0x24

    }

    // TypeToken: 0x2000100
    public struct SelectorInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.UInt16 index;        // 0x18
        public System.UInt16 numLabels;        // 0x1A
        public System.UInt16 globalLabelIndex;        // 0x1C

    }

    // TypeToken: 0x2000101
    public struct SelectorLabelInfo
    {
        // Fields
        public System.String selectorName;        // 0x10
        public System.String labelName;        // 0x18

    }

    // TypeToken: 0x2000102
    public struct CategoryInfoForMarshaling
    {
        // Fields
        public System.UInt32 groupNo;        // 0x10
        public System.UInt32 id;        // 0x14
        public System.IntPtr namePtr;        // 0x18
        public System.UInt32 numCueLimits;        // 0x20
        public System.Single volume;        // 0x24

        // Methods
        private System.Void Convert(CriWare.CriAtomExAcfDebug.CategoryInfo& x) { }

    }

    // TypeToken: 0x2000103
    public struct DspBusInfoForMarshaling
    {
        // Fields
        public System.IntPtr namePtr;        // 0x10
        public System.Single volume;        // 0x18
        public System.Single pan3dVolume;        // 0x1C
        public System.Single pan3dAngle;        // 0x20
        public System.Single pan3dDistance;        // 0x24
        public System.Single pan3dSpread;        // 0x28
        public System.UInt16[] fxIndexes;        // 0x30
        public System.UInt16[] busLinkIndexes;        // 0x38
        public System.UInt16 busNo;        // 0x40
        public System.Byte numFxes;        // 0x42
        public System.Byte numBusLinks;        // 0x43

        // Methods
        private System.Void Convert(CriWare.CriAtomExAcfDebug.DspBusInfo& x) { }

    }

    // TypeToken: 0x2000104
    public struct AisacControlInfoForMarshaling
    {
        // Fields
        public System.IntPtr namePtr;        // 0x10
        public System.UInt32 id;        // 0x18

        // Methods
        private System.Void Convert(CriWare.CriAtomExAcfDebug.AisacControlInfo& x) { }

    }

    // TypeToken: 0x2000105
    public struct GlobalAisacInfoForMarshaling
    {
        // Fields
        public System.IntPtr namePtr;        // 0x10
        public System.UInt16 index;        // 0x18
        public System.UInt16 numGraphs;        // 0x1A
        public System.UInt32 type;        // 0x1C
        public System.Single randomRange;        // 0x20
        public System.UInt16 controlId;        // 0x24
        public System.UInt16 dummy;        // 0x26

        // Methods
        private System.Void Convert(CriWare.CriAtomExAcfDebug.GlobalAisacInfo& x) { }

    }

    // TypeToken: 0x2000106
    public struct SelectorInfoForMarshaling
    {
        // Fields
        public System.IntPtr namePtr;        // 0x10
        public System.UInt16 index;        // 0x18
        public System.UInt16 numLabels;        // 0x1A
        public System.UInt16 globalLabelIndex;        // 0x1C

        // Methods
        private System.Void Convert(CriWare.CriAtomExAcfDebug.SelectorInfo& x) { }

    }

    // TypeToken: 0x2000107
    public struct SelectorLabelInfoForMarshaling
    {
        // Fields
        public System.IntPtr selectorNamePtr;        // 0x10
        public System.IntPtr labelNamePtr;        // 0x18

        // Methods
        private System.Void Convert(CriWare.CriAtomExAcfDebug.SelectorLabelInfo& x) { }

    }

    // TypeToken: 0x2000109
    public struct AcbInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.UInt32 size;        // 0x18
        public System.UInt32 version;        // 0x1C
        public CriWare.CriAtomEx.CharacterEncoding characterEncoding;        // 0x20
        public System.Single volume;        // 0x24
        public System.Int32 numCues;        // 0x28

    }

    // TypeToken: 0x200010A
    public struct AcbInfoForMarshaling
    {
        // Fields
        public System.IntPtr namePtr;        // 0x10
        public System.UInt32 size;        // 0x18
        public System.UInt32 version;        // 0x1C
        public CriWare.CriAtomEx.CharacterEncoding characterEncoding;        // 0x20
        public System.Single volume;        // 0x24
        public System.Int32 numCues;        // 0x28

        // Methods
        private System.Void Convert(CriWare.CriAtomExAcbDebug.AcbInfo& x) { }

    }

    // TypeToken: 0x200010E
    public struct ModuleType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriDisposableObjectManager.ModuleType Atom;        // 0x0
        public static CriWare.CriDisposableObjectManager.ModuleType AtomMic;        // 0x0
        public static CriWare.CriDisposableObjectManager.ModuleType Fs;        // 0x0
        public static CriWare.CriDisposableObjectManager.ModuleType FsWeb;        // 0x0
        public static CriWare.CriDisposableObjectManager.ModuleType Mana;        // 0x0
        public static CriWare.CriDisposableObjectManager.ModuleType Lips;        // 0x0
        public static CriWare.CriDisposableObjectManager.ModuleType Vip;        // 0x0
        public static CriWare.CriDisposableObjectManager.ModuleType Rtc;        // 0x0

    }

    // TypeToken: 0x200010F
    public struct ObjectRef
    {
        // Fields
        public System.Guid guid;        // 0x10
        public CriWare.CriDisposableObjectManager.ModuleType type;        // 0x20
        public CriWare.CriDisposable disposable;        // 0x28

        // Methods
        private System.Void .ctor(System.Guid _guid, CriWare.CriDisposable _disposable, CriWare.CriDisposableObjectManager.ModuleType _type) { }

    }

    // TypeToken: 0x2000116
    public struct MovieInfoStruct
    {
        // Fields
        public System.UInt32 width;        // 0x10
        public System.UInt32 height;        // 0x14
        public System.UInt32 dispWidth;        // 0x18
        public System.UInt32 dispHeight;        // 0x1C
        public System.UInt32 framerateN;        // 0x20
        public System.UInt32 framerateD;        // 0x24
        public System.UInt32 totalFrames;        // 0x28
        public CriWare.CriMana.CodecType _codecType;        // 0x2C
        public CriWare.CriMana.CodecType _alphaCodecType;        // 0x30

    }

    // TypeToken: 0x2000118
    public struct MovieMixerState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerState Preloading;        // 0x0
        public static CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerState Ready;        // 0x0
        public static CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerState Playing;        // 0x0
        public static CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerState Stopping;        // 0x0
        public static CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerState Stopped;        // 0x0

    }

    // TypeToken: 0x2000119
    public struct ClipState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriTimeline.Mana.CriManaMixerBehaviour.ClipState Idle;        // 0x0
        public static CriWare.CriTimeline.Mana.CriManaMixerBehaviour.ClipState Prepare;        // 0x0
        public static CriWare.CriTimeline.Mana.CriManaMixerBehaviour.ClipState Play;        // 0x0
        public static CriWare.CriTimeline.Mana.CriManaMixerBehaviour.ClipState Seek;        // 0x0

    }

    // TypeToken: 0x2000123
    public struct PlayerSource
    {
        // Fields
        public readonly CriWare.CriAtomExPlayer player;        // 0x10
        public readonly CriWare.CriAtomEx3dSource source3d;        // 0x18

        // Methods
        private System.Void .ctor(CriWare.CriAtomEx3dListener listener) { }

    }

    // TypeToken: 0x200012D
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriMana.Player.Status Stop;        // 0x0
        public static CriWare.CriMana.Player.Status Dechead;        // 0x0
        public static CriWare.CriMana.Player.Status WaitPrep;        // 0x0
        public static CriWare.CriMana.Player.Status Prep;        // 0x0
        public static CriWare.CriMana.Player.Status Ready;        // 0x0
        public static CriWare.CriMana.Player.Status Playing;        // 0x0
        public static CriWare.CriMana.Player.Status PlayEnd;        // 0x0
        public static CriWare.CriMana.Player.Status Error;        // 0x0
        public static CriWare.CriMana.Player.Status StopProcessing;        // 0x0
        public static CriWare.CriMana.Player.Status ReadyForRendering;        // 0x0

    }

    // TypeToken: 0x200012E
    public struct SetMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriMana.Player.SetMode New;        // 0x0
        public static CriWare.CriMana.Player.SetMode Append;        // 0x0
        public static CriWare.CriMana.Player.SetMode AppendRepeatedly;        // 0x0

    }

    // TypeToken: 0x200012F
    public struct MovieEventSyncMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriMana.Player.MovieEventSyncMode FrameTime;        // 0x0
        public static CriWare.CriMana.Player.MovieEventSyncMode PlayBackTime;        // 0x0

    }

    // TypeToken: 0x2000130
    public struct AudioTrack
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriMana.Player.AudioTrack Off;        // 0x0
        public static CriWare.CriMana.Player.AudioTrack Auto;        // 0x0

    }

    // TypeToken: 0x2000131
    public struct TimerType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriMana.Player.TimerType None;        // 0x0
        public static CriWare.CriMana.Player.TimerType System;        // 0x0
        public static CriWare.CriMana.Player.TimerType Audio;        // 0x0
        public static CriWare.CriMana.Player.TimerType User;        // 0x0
        public static CriWare.CriMana.Player.TimerType Manual;        // 0x0

    }

    // TypeToken: 0x2000132
    public class CuePointCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(CriWare.CriMana.EventPoint& eventPoint) { }
        private System.IAsyncResult BeginInvoke(CriWare.CriMana.EventPoint& eventPoint, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(CriWare.CriMana.EventPoint& eventPoint, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000133
    public class StatusChangeCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(CriWare.CriMana.Player.Status status) { }
        private System.IAsyncResult BeginInvoke(CriWare.CriMana.Player.Status status, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000134
    public class SubtitleChangeCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.IntPtr subtitleBuffer) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr subtitleBuffer, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000135
    public class ShaderDispatchCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.Shader Invoke(CriWare.CriMana.MovieInfo movieInfo, System.Boolean additiveMode) { }
        private System.IAsyncResult BeginInvoke(CriWare.CriMana.MovieInfo movieInfo, System.Boolean additiveMode, System.AsyncCallback callback, System.Object object) { }
        private UnityEngine.Shader EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000136
    public class CuePointCallbackFromNativeDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.IntPtr ptr1, System.IntPtr ptr2, CriWare.CriMana.EventPoint& eventPoint) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr ptr1, System.IntPtr ptr2, CriWare.CriMana.EventPoint& eventPoint, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(CriWare.CriMana.EventPoint& eventPoint, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000137
    public struct CriManaUnityPlayer_RenderEventAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriMana.Player.CriManaUnityPlayer_RenderEventAction UPDATE;        // 0x0
        public static CriWare.CriMana.Player.CriManaUnityPlayer_RenderEventAction INITIALIZE;        // 0x0
        public static CriWare.CriMana.Player.CriManaUnityPlayer_RenderEventAction RENDER;        // 0x0
        public static CriWare.CriMana.Player.CriManaUnityPlayer_RenderEventAction DESTROY;        // 0x0

    }

    // TypeToken: 0x2000138
    public struct OperationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriMana.Player.OperationType Normal;        // 0x0
        public static CriWare.CriMana.Player.OperationType SetFile;        // 0x0
        public static CriWare.CriMana.Player.OperationType SeekToTime;        // 0x0
        public static CriWare.CriMana.Player.OperationType Pause;        // 0x0

    }

    // TypeToken: 0x2000139
    public struct Operation
    {
        // Fields
        public CriWare.CriMana.Player.OperationType opType;        // 0x10
        public CriWare.CriMana.Player.Status targetStatus;        // 0x14
        public System.Boolean isStopForSeek;        // 0x18
        public CriWare.CriFsBinder binder;        // 0x20
        public System.String moviePath;        // 0x28
        public CriWare.CriMana.Player.SetMode setMode;        // 0x30
        public System.Single timeToSeek;        // 0x34
        public System.Boolean sw;        // 0x38

        // Methods
        private CriWare.CriMana.Player.Operation Start() { }
        private CriWare.CriMana.Player.Operation Pause(System.Boolean sw) { }
        private CriWare.CriMana.Player.Operation Stop() { }
        private CriWare.CriMana.Player.Operation StopForSeek() { }
        private CriWare.CriMana.Player.Operation Prepare() { }
        private CriWare.CriMana.Player.Operation PrepareForRendering() { }
        private CriWare.CriMana.Player.Operation SetFile(CriWare.CriFsBinder binder, System.String moviePath, CriWare.CriMana.Player.SetMode setMode) { }
        private CriWare.CriMana.Player.Operation SeekToTime(System.Single time) { }

    }

    // TypeToken: 0x200013C
    public class RendererResourceFactoryH264Yuv : RendererResourceFactory
    {
        // Methods
        private CriWare.CriMana.Detail.RendererResource CreateRendererResource(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader) { }
        private System.Void OnDisposeManaged() { }
        private System.Void OnDisposeUnmanaged() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013D
    public class RendererResourceFactorySofdecPrimeYuv : RendererResourceFactory
    {
        // Methods
        private CriWare.CriMana.Detail.RendererResource CreateRendererResource(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader) { }
        private System.Void OnDisposeManaged() { }
        private System.Void OnDisposeUnmanaged() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013E
    public class RendererResourceFactorySofdecPrimeYuvRawData : RendererResourceFactory
    {
        // Methods
        private CriWare.CriMana.Detail.RendererResource CreateRendererResource(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader) { }
        private System.Void OnDisposeManaged() { }
        private System.Void OnDisposeUnmanaged() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000146
    public struct __StaticArrayInitTypeSize=12
    {
    }

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000003
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

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
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace CriWare
{

    // TypeToken: 0x2000007
    public class CriWarePS5
    {
        // Fields
        public static System.Int32 SystemUserID;        // 0x0

        // Methods
        private System.Void SetupFileSystem(System.Boolean enableAprDirectMode) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class CriAtomPlugin
    {
        // Fields
        private static System.Int32 initializationCount;        // 0x0
        private static System.Collections.Generic.List<System.IntPtr> effectInterfaceList;        // 0x8
        private static System.Boolean isConfigured;        // 0x10
        private static System.Single timeSinceStartup;        // 0x14
        private static CriWare.Common.CpuUsage cpuUsage;        // 0x18
        private static System.Int32 CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT;        // 0x24
        private static System.UInt16 CRIATOMPARAMETER2_ID_INVALID;        // 0x28
        private static System.UInt64 temporalStorage;        // 0x30

        // Methods
        private System.Void Log(System.String log) { }
        private System.Boolean get_isInitialized() { }
        private System.Void ExecuteQueuedCueLinkCallbacks() { }
        private System.Void ExecuteQueuedEventCallbacks() { }
        private System.Void ExecuteQueuedBeatSyncCallbacks() { }
        private System.Boolean GetAudioEffectInterfaceList(System.Collections.Generic.List<System.IntPtr>& effect_interface_list) { }
        private System.IntPtr GetSpatializerCoreInterfaceFromAtomOculusAudioBridge() { }
        private System.Void SetConfigParameters(System.Int32 max_virtual_voices, System.Int32 max_voice_limit_groups, System.Int32 max_categories, System.Int32 max_aisacs, System.Int32 max_bus_sends, System.Int32 max_sequence_events_per_frame, System.Int32 max_beatsync_callbacks_per_frame, System.Int32 max_cuelink_callbacks_per_frame, System.Int32 num_standard_memory_voices, System.Int32 num_standard_streaming_voices, System.Int32 num_hca_mx_memory_voices, System.Int32 num_hca_mx_streaming_voices, System.Int32 output_sampling_rate, System.Int32 num_asr_output_channels, System.Boolean uses_in_game_preview, System.Single server_frequency, System.Int32 max_parameter_blocks, System.Int32 categories_per_playback, System.Int32 max_faders, System.Int32 num_buses, System.Boolean vr_mode) { }
        private System.Void SetConfigMonitorParametes(System.Int32 max_preview_objects, System.Int32 communication_buffer_size, System.Int32 playback_position_update_interval) { }
        private System.Void SetConfigAdditionalParameters_EDITOR(System.Boolean enable_user_pcm_output, System.Int32 user_pcm_buffer_length) { }
        private System.Void SetConfigAdditionalParameters_PC(System.Int64 buffering_time_pc) { }
        private System.Void SetConfigAdditionalParameters_LINUX(CriWare.CriAtomConfig.LinuxOutput output, System.Int32 pulse_latency_usec) { }
        private System.Void SetConfigAdditionalParameters_IOS(System.Boolean enable_sonicsync, System.UInt32 buffering_time_ios, System.Boolean override_ipod_music_ios) { }
        private System.Void SetConfigAdditionalParameters_ANDROID(System.Boolean enable_sonicsync, System.Int32 num_low_delay_memory_voices, System.Int32 num_low_delay_streaming_voices, System.Int32 sound_buffering_time, System.Int32 sound_start_buffering_time, System.Boolean use_fast_mixer, System.Boolean use_aaudio, System.Int32 stream_type) { }
        private System.Void SetConfigAdditionalParameters_VITA(System.Int32 num_atrac9_memory_voices, System.Int32 num_atrac9_streaming_voices, System.Int32 num_mana_decoders) { }
        private System.Void SetConfigAdditionalParameters_PS4(System.Int32 num_atrac9_memory_voices, System.Int32 num_atrac9_streaming_voices, System.Boolean use_audio3d, System.Int32 num_audio3d_memory_voices, System.Int32 num_audio3d_streaming_voices) { }
        private System.Void SetConfigAdditionalParameters_PS5(System.Int32 max_channel_ports, System.Int32 max_object_ports) { }
        private System.Void SetConfigAdditionalParameters_SWITCH(System.Boolean enable_sonicsync, System.Int32 num_opus_memory_voices, System.Int32 num_opus_streaming_voices, System.Boolean init_socket) { }
        private System.Void SetConfigAdditionalParameters_WEBGL(System.Int32 num_webaudio_voices) { }
        private System.Void SetMaxSamplingRateForStandardVoicePool(System.Int32 sampling_rate_for_memory, System.Int32 sampling_rate_for_streaming) { }
        private System.Int32 GetRequiredMaxVirtualVoices(CriWare.CriAtomConfig atomConfig) { }
        private System.Void InitializeLibrary() { }
        private System.Boolean IsLibraryInitialized() { }
        private System.Void FinalizeLibrary() { }
        private System.Void Pause(System.Boolean pause) { }
        private CriWare.Common.CpuUsage GetCpuUsage() { }
        private System.Int32 GetOutputSamplingRate() { }
        private System.Int32 GetOutputChannels() { }
        private System.Boolean IsInitializedForPcmOutput() { }
        private System.UInt16 GetLoopCountParameterId() { }
        private System.Void DecryptAcb(System.IntPtr acb_hn, System.UInt64 key, System.UInt64 nonce) { }
        private System.UInt64 CallbackFromNative(System.IntPtr ptr1) { }
        private System.Void CRIWARE009CE561(System.Int32 max_virtual_voices, System.Int32 max_voice_limit_groups, System.Int32 max_categories, System.Int32 max_aisacs, System.Int32 max_bus_sends, System.Int32 max_sequence_events_per_frame, System.Int32 max_beatsync_callbacks_per_frame, System.Int32 max_cuelink_callbacks_per_frame, System.Int32 num_standard_memory_voices, System.Int32 num_standard_streaming_voices, System.Int32 num_hca_mx_memory_voices, System.Int32 num_hca_mx_streaming_voices, System.Int32 output_sampling_rate, System.Int32 num_asr_output_channels, System.Boolean uses_in_game_preview, System.Single server_frequency, System.Int32 max_parameter_blocks, System.Int32 categories_per_playback, System.Int32 max_faders, System.Int32 num_buses, System.Boolean use_ambisonics, System.IntPtr spatializer_core_interface) { }
        private System.Void CRIWARE8384362B(System.UInt32 max_preivew_objects, System.UInt32 communication_buffer_size, System.Int32 playback_position_update_interval) { }
        private System.Void CRIWARE237CA5E3(System.Boolean enable_user_pcm_out_mode) { }
        private System.Void CRIWARE780E6ED2(System.Int64 buffering_time_pc) { }
        private System.Void CRIWAREE996B258(System.Int32 output, System.Int32 pulse_latency_usec) { }
        private System.Void CRIWARE2F034134(System.Boolean enable_sonicsync, System.UInt32 buffering_time_ios, System.Boolean override_ipod_music_ios) { }
        private System.Void CRIWARE70981A20(System.Boolean enable_sonicsync, System.Int32 num_low_delay_memory_voices, System.Int32 num_low_delay_streaming_voices, System.Int32 sound_buffering_time, System.Int32 sound_start_buffering_time, System.Boolean apply_hw_property, System.Int32 stream_type) { }
        private System.Void CRIWARE2626EF5B() { }
        private System.Boolean CRIWAREC176B113() { }
        private System.Void CRIWARE63E1F278() { }
        private System.Void CRIWAREB64E0C3B(System.Boolean pause) { }
        private System.UInt32 CRIWAREA703719E() { }
        private System.Void CRIWAREBF97E87F(System.Int32 code) { }
        private System.Void CRIWARE15B0037A(System.IntPtr cbfunc, System.String separator_string) { }
        private System.Void CRIWARE28E5ABA4(System.IntPtr cbfunc) { }
        private System.Void CRIWARECCA1268B() { }
        private System.Void CRIWARE88175F19(System.IntPtr cbfunc) { }
        private System.Void CRIWARE7581CF8C() { }
        private System.Void CRIWARE15F30D07(System.IntPtr cbfunc) { }
        private System.Void CRIWARED1FD92AA() { }
        private System.Void CRIWARE2CFF30B7(System.Int32 sampling_rate_for_memory, System.Int32 sampling_rate_for_streaming) { }
        private System.Void CRIWARE797E0462() { }
        private System.Void CRIWAREC54D0552() { }
        private System.Void CRIWARE5BC8942D(System.IntPtr acb_hn, CriWare.CriAtomPlugin.CallbackFromNativeDelegate func, System.IntPtr obj) { }
        private System.UInt16 CRIWARE5B1C5B3B(System.Int32 id) { }
        private System.Boolean CRIWAREE097EA6E() { }
        private System.Int32 CRIWAREE320F01B() { }
        private System.Int32 CRIWARE98A6BE5C() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000E
    public class CriAtomCueSheet
    {
        // Fields
        public System.String name;        // 0x10
        public System.String acbFile;        // 0x18
        public System.String awbFile;        // 0x20
        public CriWare.CriAtomExAcb acb;        // 0x28
        public CriWare.CriAtomExAcbLoader.Status loaderStatus;        // 0x30

        // Methods
        private System.Boolean get_IsLoading() { }
        private System.Boolean get_IsError() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class CriAtom : CriMonoBehaviour
    {
        // Fields
        public System.String acfFile;        // 0x28
        private System.Boolean acfIsLoading;        // 0x30
        public CriWare.CriAtomCueSheet[] cueSheets;        // 0x38
        public System.String dspBusSetting;        // 0x40
        public System.Boolean dontDestroyOnLoad;        // 0x48
        private static CriWare.CriAtomExSequencer.EventCallback eventUserCallback;        // 0x0
        private static CriWare.CriAtomExSequencer.EventCbFunc eventUserCbFunc;        // 0x8
        private static CriWare.CriAtomExBeatSync.CbFunc beatsyncUserCbFunc;        // 0x10
        private static CriWare.CriAtomExBeatSync.CbFunc obsoleteBeatSyncFunc;        // 0x18
        private static CriWare.CriAtomEx.CueLinkCbFunc cueLinkUserCbFunc;        // 0x20
        private static CriWare.CriAtom <instance>k__BackingField;        // 0x28
        private System.Runtime.InteropServices.GCHandle acfRegisterGCHandle;        // 0x50
        public System.Boolean dontRemoveExistsCueSheet;        // 0x58

        // Methods
        private System.Void add_OnEventSequencerCallback(CriWare.CriAtomExSequencer.EventCallback value) { }
        private System.Void remove_OnEventSequencerCallback(CriWare.CriAtomExSequencer.EventCallback value) { }
        private System.Void add_beatsyncUserCbFunc(CriWare.CriAtomExBeatSync.CbFunc value) { }
        private System.Void remove_beatsyncUserCbFunc(CriWare.CriAtomExBeatSync.CbFunc value) { }
        private System.Void add_OnBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value) { }
        private System.Void remove_OnBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value) { }
        private System.Void add_cueLinkUserCbFunc(CriWare.CriAtomEx.CueLinkCbFunc value) { }
        private System.Void remove_cueLinkUserCbFunc(CriWare.CriAtomEx.CueLinkCbFunc value) { }
        private System.Void add_OnCueLinkCallback(CriWare.CriAtomEx.CueLinkCbFunc value) { }
        private System.Void remove_OnCueLinkCallback(CriWare.CriAtomEx.CueLinkCbFunc value) { }
        private CriWare.CriAtom get_instance() { }
        private System.Void set_instance(CriWare.CriAtom value) { }
        private System.Void AttachDspBusSetting(System.String settingName) { }
        private System.Void DetachDspBusSetting() { }
        private CriWare.CriAtomCueSheet GetCueSheet(System.String name) { }
        private CriWare.CriAtomCueSheet AddCueSheet(System.String name, System.String acbFile, System.String awbFile, CriWare.CriFsBinder binder) { }
        private CriWare.CriAtomCueSheet AddCueSheetAsync(System.String name, System.String acbFile, System.String awbFile, CriWare.CriFsBinder binder, System.Boolean loadAwbOnMemory) { }
        private CriWare.CriAtomCueSheet AddCueSheet(System.String name, System.Byte[] acbData, System.String awbFile, CriWare.CriFsBinder awbBinder) { }
        private CriWare.CriAtomCueSheet AddCueSheetAsync(System.String name, System.Byte[] acbData, System.String awbFile, CriWare.CriFsBinder awbBinder, System.Boolean loadAwbOnMemory) { }
        private System.Void RemoveCueSheet(System.String name) { }
        private System.Boolean get_CueSheetsAreLoading() { }
        private CriWare.CriAtomExAcb GetAcb(System.String cueSheetName) { }
        private System.Void SetCategoryVolume(System.String name, System.Single volume) { }
        private System.Void SetCategoryVolume(System.Int32 id, System.Single volume) { }
        private System.Single GetCategoryVolume(System.String name) { }
        private System.Single GetCategoryVolume(System.Int32 id) { }
        private System.Void SetBusAnalyzer(System.String busName, System.Boolean sw) { }
        private System.Void SetBusAnalyzer(System.Boolean sw) { }
        private CriWare.CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(System.String busName) { }
        private CriWare.CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(System.Int32 busId) { }
        private System.Void Setup() { }
        private System.Void Shutdown() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDestroy() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private CriWare.CriAtomCueSheet GetCueSheetInternal(System.String name) { }
        private CriWare.CriAtomCueSheet AddCueSheetInternal(System.String name, System.String acbFile, System.String awbFile, CriWare.CriFsBinder binder) { }
        private System.Void RemoveCueSheetInternal(System.String name) { }
        private System.Void MargeCueSheet(CriWare.CriAtomCueSheet[] newCueSheets, System.Boolean newDontRemoveExistsCueSheet) { }
        private CriWare.CriAtomExAcb LoadAcbFile(CriWare.CriFsBinder binder, System.String acbFile, System.String awbFile) { }
        private CriWare.CriAtomExAcb LoadAcbData(System.Byte[] acbData, CriWare.CriFsBinder binder, System.String awbFile) { }
        private System.Void LoadAcbFileAsync(CriWare.CriAtomCueSheet cueSheet, CriWare.CriFsBinder binder, System.String acbFile, System.String awbFile, System.Boolean loadAwbOnMemory) { }
        private System.Collections.IEnumerator LoadAcbFileCoroutine(CriWare.CriAtomCueSheet cueSheet, CriWare.CriFsBinder binder, System.String acbPath, System.String awbPath, System.Boolean loadAwbOnMemory) { }
        private System.Void LoadAcbDataAsync(CriWare.CriAtomCueSheet cueSheet, System.Byte[] acbData, CriWare.CriFsBinder awbBinder, System.String awbFile, System.Boolean loadAwbOnMemory) { }
        private System.Collections.IEnumerator LoadAcbDataCoroutine(CriWare.CriAtomCueSheet cueSheet, System.Byte[] acbData, CriWare.CriFsBinder awbBinder, System.String awbPath, System.Boolean loadAwbOnMemory) { }
        private System.Void SequenceEventCallbackFromNative(System.String eventString) { }
        private System.Void SequenceCallbackFromNative(CriWare.CriAtomExSequencer.CriAtomExSequenceEventInfo& criAtomExSequenceInfo) { }
        private System.Void BeatSyncCallbackFromNative(CriWare.CriAtomExBeatSync.Info& info) { }
        private System.Void CueLinkCallbackFromNative(CriWare.CriAtomEx.CueLinkInfo& info) { }
        private System.Void SetEventCallback(CriWare.CriAtomExSequencer.EventCbFunc func, System.String separator) { }
        private System.Void RegisterEventCallbackChain(CriWare.CriAtomExSequencer.EventCallback func) { }
        private System.Void UnregisterEventCallbackChain(CriWare.CriAtomExSequencer.EventCallback func) { }
        private System.Void SetBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc func) { }
        private System.Void RegisterBeatSyncCallbackChain(CriWare.CriAtomExBeatSync.CbFunc func) { }
        private System.Void UnregisterBeatSyncCallbackChain(CriWare.CriAtomExBeatSync.CbFunc func) { }
        private System.Void RegisterCueLinkCallbackChain(CriWare.CriAtomEx.CueLinkCbFunc func) { }
        private System.Void UnregisterCueLinkCallbackChain(CriWare.CriAtomEx.CueLinkCbFunc func) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class CriAtomListener : CriMonoBehaviour
    {
        // Fields
        private CriWare.CriAtomEx3dListener <nativeListener>k__BackingField;        // 0x28
        private CriWare.CriAtomRegion regionOnStart;        // 0x30
        public System.Boolean activateListenerOnEnable;        // 0x38
        private static System.Collections.Generic.List<CriWare.CriAtomListener> listenersList;        // 0x0
        private static CriWare.CriAtomEx3dListener dummyNativeListener;        // 0x8
        private UnityEngine.Vector3 lastPosition;        // 0x3C
        private CriWare.CriAtomRegion currentRegion;        // 0x48
        private System.Boolean _isActive;        // 0x50

        // Methods
        private System.Void CreateDummyNativeListener() { }
        private System.Void DestroyDummyNativeListener() { }
        private CriWare.CriAtomEx3dListener get_nativeListener() { }
        private System.Void set_nativeListener(CriWare.CriAtomEx3dListener value) { }
        private System.Boolean get_isActive() { }
        private System.Void set_isActive(System.Boolean value) { }
        private CriWare.CriAtomRegion get_region3d() { }
        private System.Void set_region3d(CriWare.CriAtomRegion value) { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private System.Void UpdatePosition() { }
        private System.Void ActivateListener(System.Boolean exclusive) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000014
    public class CriAtomOutputDeviceObserver : CriMonoBehaviour
    {
        // Fields
        private System.Boolean dontDestroyOnLoad;        // 0x28
        private System.Boolean lastIsConnected;        // 0x29
        private System.Boolean isConnected;        // 0x2A
        private CriWare.CriAtomOutputDeviceObserver.OutputDeviceType lastDeviceType;        // 0x2C
        private CriWare.CriAtomOutputDeviceObserver.OutputDeviceType deviceType;        // 0x30
        private static CriWare.CriAtomOutputDeviceObserver instance;        // 0x0
        private static CriWare.CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback _onDeviceConnectionChanged;        // 0x8

        // Methods
        private System.Void add_OnDeviceConnectionChanged(CriWare.CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback value) { }
        private System.Void remove_OnDeviceConnectionChanged(CriWare.CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback value) { }
        private System.Boolean get_IsDeviceConnected() { }
        private CriWare.CriAtomOutputDeviceObserver.OutputDeviceType get_DeviceType() { }
        private System.Void add__onDeviceConnectionChanged(CriWare.CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback value) { }
        private System.Void remove__onDeviceConnectionChanged(CriWare.CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback value) { }
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000018
    public class CriAtomRegion : CriMonoBehaviour
    {
        // Fields
        private CriWare.CriAtomEx3dRegion <region3dHn>k__BackingField;        // 0x28
        private System.Collections.Generic.List<CriWare.CriAtomSourceBase> referringSources;        // 0x30
        private System.Collections.Generic.List<CriWare.CriAtomListener> referringListeners;        // 0x38
        private System.Collections.Generic.List<CriWare.CriAtomTransceiver> referringTransceivers;        // 0x40

        // Methods
        private CriWare.CriAtomEx3dRegion get_region3dHn() { }
        private System.Void set_region3dHn(CriWare.CriAtomEx3dRegion value) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDestroy() { }
        private System.Void InternalInitialize() { }
        private System.Void InternalFinalize() { }
        private System.Void InitializeParameters() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class CriAtomServer : CriMonoBehaviour
    {
        // Fields
        private static CriWare.CriAtomServer _instance;        // 0x0
        public System.Action<System.Boolean> onApplicationPausePreProcess;        // 0x28
        public System.Action<System.Boolean> onApplicationPausePostProcess;        // 0x30
        public static System.Boolean KeepPlayingSoundOnPause;        // 0x8
        public static System.Boolean EnableAutoConsumePcmOutput;        // 0x9

        // Methods
        private CriWare.CriAtomServer get_instance() { }
        private System.Void CreateInstance() { }
        private System.Void DestroyInstance() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private System.Void ConsumePcmOutput() { }
        private System.Void OnApplicationPause(System.Boolean appPause) { }
        private System.Void ProcessApplicationPause(System.Boolean appPause) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001A
    public class CriAtomSource : CriAtomSourceBase
    {
        // Fields
        private System.String _cueName;        // 0xA0
        private System.String _cueSheet;        // 0xA8

        // Methods
        private System.String get_cueName() { }
        private System.Void set_cueName(System.String value) { }
        private System.String get_cueSheet() { }
        private System.Void set_cueSheet(System.String value) { }
        private CriWare.CriAtomExPlayback Play() { }
        private CriWare.CriAtomExAcb GetAcb() { }
        private System.Void PlayOnStart() { }
        private System.Collections.IEnumerator PlayAsync(System.String cueName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001C
    public class CriAtomSourceBase : CriMonoBehaviour
    {
        // Fields
        private CriWare.CriAtomExPlayer <player>k__BackingField;        // 0x28
        private CriWare.CriAtomEx3dSource <source>k__BackingField;        // 0x30
        protected System.Boolean initialized;        // 0x38
        protected UnityEngine.Vector3 lastPosition;        // 0x3C
        protected System.Boolean hasValidPosition;        // 0x48
        private CriWare.CriAtomRegion currentRegion;        // 0x50
        private CriWare.CriAtomListener currentListener;        // 0x58
        private System.Boolean _playOnStart;        // 0x60
        private CriWare.CriAtomRegion _regionOnStart;        // 0x68
        private CriWare.CriAtomListener _listenerOnStart;        // 0x70
        private System.Boolean _use3dPositioning;        // 0x78
        private System.Boolean _freezeOrientation;        // 0x79
        private System.Boolean _loop;        // 0x7A
        private System.Single _volume;        // 0x7C
        private System.Single _pitch;        // 0x80
        private System.Boolean _androidUseLowLatencyVoicePool;        // 0x84
        private System.Boolean need_to_player_update_all;        // 0x85
        private System.Boolean _use3dRandomization;        // 0x86
        private System.UInt32 _randomPositionListMaxLength;        // 0x88
        private CriWare.CriAtomEx.Randomize3dConfig randomize3dConfig;        // 0x90

        // Methods
        private System.Void set_player(CriWare.CriAtomExPlayer value) { }
        private CriWare.CriAtomExPlayer get_player() { }
        private System.Void set_source(CriWare.CriAtomEx3dSource value) { }
        private CriWare.CriAtomEx3dSource get_source() { }
        private System.Boolean get_playOnStart() { }
        private System.Void set_playOnStart(System.Boolean value) { }
        private System.Void set_use3dPositioning(System.Boolean value) { }
        private System.Boolean get_use3dPositioning() { }
        private System.Boolean get_freezeOrientation() { }
        private System.Void set_freezeOrientation(System.Boolean value) { }
        private System.Void set_use3dRandomization(System.Boolean value) { }
        private System.Boolean get_use3dRandomization() { }
        private System.Void set_randomPositionListMaxLength(System.UInt32 value) { }
        private System.UInt32 get_randomPositionListMaxLength() { }
        private CriWare.CriAtomRegion get_region3d() { }
        private System.Void set_region3d(CriWare.CriAtomRegion value) { }
        private CriWare.CriAtomListener get_listener() { }
        private System.Void set_listener(CriWare.CriAtomListener value) { }
        private CriWare.CriAtomRegion get_regionOnStart() { }
        private System.Void set_regionOnStart(CriWare.CriAtomRegion value) { }
        private CriWare.CriAtomListener get_listenerOnStart() { }
        private System.Void set_listenerOnStart(CriWare.CriAtomListener value) { }
        private System.Void set_loop(System.Boolean value) { }
        private System.Boolean get_loop() { }
        private System.Void set_volume(System.Single value) { }
        private System.Single get_volume() { }
        private System.Void set_pitch(System.Single value) { }
        private System.Single get_pitch() { }
        private System.Void set_pan3dAngle(System.Single value) { }
        private System.Single get_pan3dAngle() { }
        private System.Void set_pan3dDistance(System.Single value) { }
        private System.Single get_pan3dDistance() { }
        private System.Void set_startTime(System.Int32 value) { }
        private System.Int32 get_startTime() { }
        private System.Int64 get_time() { }
        private CriWare.CriAtomSourceBase.Status get_status() { }
        private System.Void set_attenuationDistanceSetting(System.Boolean value) { }
        private System.Boolean get_attenuationDistanceSetting() { }
        private System.Boolean get_androidUseLowLatencyVoicePool() { }
        private System.Void set_androidUseLowLatencyVoicePool(System.Boolean value) { }
        private System.Void SetNeedToPlayerUpdateAll() { }
        private System.Void InternalInitialize() { }
        private System.Void InternalFinalize() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDestroy() { }
        private System.Boolean SetInitialSourcePosition() { }
        private System.Void SetInitialParameters() { }
        private System.Void UpdatePosition() { }
        private System.Void Start() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private CriWare.CriAtomExPlayback Play() { }
        private CriWare.CriAtomExAcb GetAcb() { }
        private System.Void PlayOnStart() { }
        private CriWare.CriAtomExPlayback Play(System.String cueName) { }
        private CriWare.CriAtomExPlayback Play(System.Int32 cueId) { }
        private CriWare.CriAtomExPlayback InternalPlayCue() { }
        private System.Void Stop() { }
        private System.Void Pause(System.Boolean sw) { }
        private System.Boolean IsPaused() { }
        private System.Void SetBusSendLevel(System.String busName, System.Single level) { }
        private System.Void SetBusSendLevel(System.Int32 busId, System.Single level) { }
        private System.Void SetBusSendLevelOffset(System.String busName, System.Single levelOffset) { }
        private System.Void SetBusSendLevelOffset(System.Int32 busId, System.Single levelOffset) { }
        private System.Void SetAisacControl(System.String controlName, System.Single value) { }
        private System.Void SetAisac(System.String controlName, System.Single value) { }
        private System.Void SetAisacControl(System.UInt32 controlId, System.Single value) { }
        private System.Void SetAisac(System.UInt32 controlId, System.Single value) { }
        private System.Void AttachToAnalyzer(CriWare.CriAtomExOutputAnalyzer analyzer) { }
        private System.Void DetachFromAnalyzer(CriWare.CriAtomExOutputAnalyzer analyzer) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class CriAtomTransceiver : CriMonoBehaviour
    {
        // Fields
        private CriWare.CriAtomEx3dTransceiver <transceiverHn>k__BackingField;        // 0x28
        private UnityEngine.Vector3 <inputPos>k__BackingField;        // 0x30
        private UnityEngine.Vector3 <inputFront>k__BackingField;        // 0x3C
        private UnityEngine.Vector3 <inputUp>k__BackingField;        // 0x48
        private CriWare.CriAtomRegion regionOnStart;        // 0x58
        private System.Boolean useDedicatedInput;        // 0x60
        private UnityEngine.GameObject dedicatedInput;        // 0x68
        private System.Single outputVolume;        // 0x70
        private System.Single directAudioRadius;        // 0x74
        private System.Single crossFadeDistance;        // 0x78
        private System.Single coneInsideAngle;        // 0x7C
        private System.Single coneOutsideAngle;        // 0x80
        private System.Single coneOutsideVolume;        // 0x84
        private System.Single transceiverRadius;        // 0x88
        private System.Single interiorDistance;        // 0x8C
        public System.Single minAttenuation;        // 0x90
        public System.Single maxAttenuation;        // 0x94
        private System.String globalAisacName;        // 0x98
        private System.Single maxAngleAisacDelta;        // 0xA0
        private System.String distanceAisacControlId;        // 0xA8
        private System.String listenerAzimuthAisacControlId;        // 0xB0
        private System.String listenerElevationAisacControlId;        // 0xB8
        private System.String outputAzimuthAisacControlId;        // 0xC0
        private System.String outputElevationAisacControlId;        // 0xC8
        public System.Boolean inspectorAisacSettingFoldout;        // 0xD0
        private System.Boolean isInitialized;        // 0xD1
        private System.Boolean dedicatedInputNotSetWarned;        // 0xD2
        private CriWare.CriAtomRegion currentRegion;        // 0xD8

        // Methods
        private CriWare.CriAtomEx3dTransceiver get_transceiverHn() { }
        private System.Void set_transceiverHn(CriWare.CriAtomEx3dTransceiver value) { }
        private UnityEngine.Vector3 get_inputPos() { }
        private System.Void set_inputPos(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_inputFront() { }
        private System.Void set_inputFront(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_inputUp() { }
        private System.Void set_inputUp(UnityEngine.Vector3 value) { }
        private CriWare.CriAtomRegion get_region3d() { }
        private System.Void set_region3d(CriWare.CriAtomRegion value) { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDestroy() { }
        private System.Void InternalInitialize() { }
        private System.Void InternalFinalize() { }
        private System.Void InitializeParameters() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private System.Void ApplyCurrentPosition() { }
        private System.Void ApplyParameters() { }
        private System.Void TrySetAisacControlId(System.String strId, CriWare.CriAtomTransceiver.SetControlIdMethod callback) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class CriStructMemory`1, IDisposable
    {
        // Fields
        private System.Byte[] <bytes>k__BackingField;        // 0x0
        private System.Runtime.InteropServices.GCHandle gch;        // 0x0

        // Methods
        private System.Byte[] get_bytes() { }
        private System.Void set_bytes(System.Byte[] value) { }
        private System.IntPtr get_ptr() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 num) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000021
    public class CriAtomEx
    {
        // Fields
        public static System.UInt32 InvalidAisacControlId;        // 0x0
        public static readonly System.Collections.Generic.Dictionary<CriWare.CriAtomEx.Randomize3dCalcType,CriWare.CriAtomEx.Randomize3dParamType[]> randomize3dParamTable;        // 0x0

        // Methods
        private System.Void SetSpeakerAngle(CriWare.CriAtomEx.SpeakerAngles6ch speakerAngle) { }
        private System.Void SetSpeakerAngle(CriWare.CriAtomEx.SpeakerAngles8ch speakerAngle) { }
        private System.Void SetVirtualSpeakerAngle(CriWare.CriAtomEx.SpeakerAngles6ch speakerAngle) { }
        private System.Void SetVirtualSpeakerAngle(CriWare.CriAtomEx.SpeakerAngles8ch speakerAngle) { }
        private System.Void ControlVirtualSpeakerSetting(System.Boolean sw) { }
        private System.Void add_OnCueLinkCallback(CriWare.CriAtomEx.CueLinkCbFunc value) { }
        private System.Void remove_OnCueLinkCallback(CriWare.CriAtomEx.CueLinkCbFunc value) { }
        private System.Void RegisterAcf(CriWare.CriFsBinder binder, System.String acfPath) { }
        private System.Void RegisterAcf(System.IntPtr acfData, System.Int32 dataSize) { }
        private System.Void RegisterAcf(System.Byte[] acfData) { }
        private System.Void UnregisterAcf() { }
        private System.String GetAppliedDspBusSnapshotName() { }
        private System.Void AttachDspBusSetting(System.String settingName) { }
        private System.Void DetachDspBusSetting() { }
        private System.Void ApplyDspBusSnapshot(System.String snapshot_name, System.Int32 time_ms) { }
        private System.Int32 GetNumGameVariables() { }
        private System.Boolean GetGameVariableInfo(System.UInt16 index, CriWare.CriAtomEx.GameVariableInfo& info) { }
        private System.Single GetGameVariable(System.UInt32 game_variable_id) { }
        private System.Single GetGameVariable(System.String game_variable_name) { }
        private System.Void SetGameVariable(System.UInt32 game_variable_id, System.Single game_variable_value) { }
        private System.Void SetGameVariable(System.String game_variable_name, System.Single game_variable_value) { }
        private System.Void SetRandomSeed(System.UInt32 seed) { }
        private System.Void ResetPerformanceMonitor() { }
        private System.Void GetPerformanceInfo(CriWare.CriAtomEx.PerformanceInfo& info) { }
        private System.Void SetGlobalLabelToSelectorByIndex(System.UInt16 selector_index, System.UInt16 label_index) { }
        private System.Void SetGlobalLabelToSelectorByName(System.String selector_name, System.String label_name) { }
        private System.Void Lock() { }
        private System.Void Unlock() { }
        private System.Void SetOutputAudioDevice_PC(System.String deviceId) { }
        private System.Boolean LoadAudioDeviceList_PC() { }
        private System.Int32 GetNumAudioDevices_PC() { }
        private System.String GetAudioDeviceName_PC(System.Int32 index) { }
        private System.Void SetOutputAudioDevice_PC(System.Int32 index) { }
        private System.Void SetOutputVolume_VITA(System.Single volume) { }
        private System.Boolean IsBgmPortAcquired_VITA() { }
        private System.Boolean IsSoundStopped_IOS() { }
        private System.Void EnableAudioSessionRestoration_IOS(System.Boolean flag) { }
        private System.Void EnableBusSendOffsetWhenLevelNotExist(System.Boolean enable) { }
        private System.Boolean criAtomEx_RegisterAcfFile(System.IntPtr binder, System.String path, System.IntPtr work, System.Int32 workSize) { }
        private System.Void criAtomEx_RegisterAcfData(System.IntPtr acfData, System.Int32 acfDataSize, System.IntPtr work, System.Int32 workSize) { }
        private System.Void criAtomEx_RegisterAcfData(System.Byte[] acfData, System.Int32 acfDataSize, System.IntPtr work, System.Int32 workSize) { }
        private System.Void criAtomEx_UnregisterAcf() { }
        private System.Void criAtomEx_AttachDspBusSetting(System.String settingName, System.IntPtr work, System.Int32 workSize) { }
        private System.Void criAtomEx_DetachDspBusSetting() { }
        private System.Void criAtomEx_ApplyDspBusSnapshot(System.String snapshot_name, System.Int32 time_ms) { }
        private System.IntPtr criAtomEx_GetAppliedDspBusSnapshotName() { }
        private System.Int32 criAtomEx_GetNumGameVariables() { }
        private System.Boolean criAtomEx_GetGameVariableInfo(System.UInt16 index, System.IntPtr game_variable_info) { }
        private System.Single criAtomEx_GetGameVariableById(System.UInt32 game_variable_id) { }
        private System.Single criAtomEx_GetGameVariableByName(System.String game_variable_name) { }
        private System.Void criAtomEx_SetGameVariableById(System.UInt32 game_variable_id, System.Single game_variable_value) { }
        private System.Void criAtomEx_SetGameVariableByName(System.String game_variable_name, System.Single game_variable_value) { }
        private System.Void criAtomEx_SetRandomSeed(System.UInt32 seed) { }
        private System.Void criAtomEx_Lock() { }
        private System.Void criAtomEx_Unlock() { }
        private System.Void criAtom_ResetPerformanceMonitor() { }
        private System.Void criAtom_GetPerformanceInfo(CriWare.CriAtomEx.PerformanceInfo& info) { }
        private System.Void criAtomExAcf_SetGlobalLabelToSelectorByIndex(System.UInt16 selector_index, System.UInt16 label_index) { }
        private System.Void criAtomExAcf_SetGlobalLabelToSelectorByName(System.String selector_name, System.String label_name) { }
        private System.Void criAtomEx_SetSpeakerAngleArray(CriWare.CriAtomEx.SpeakerSystem speaker_system, CriWare.CriAtomEx.SpeakerAngles6ch& angle_array) { }
        private System.Void criAtomEx_SetSpeakerAngleArray(CriWare.CriAtomEx.SpeakerSystem speaker_system, CriWare.CriAtomEx.SpeakerAngles8ch& angle_array) { }
        private System.Void criAtomEx_SetVirtualSpeakerAngleArray(CriWare.CriAtomEx.SpeakerSystem speaker_system, CriWare.CriAtomEx.SpeakerAngles6ch& angle_array) { }
        private System.Void criAtomEx_SetVirtualSpeakerAngleArray(CriWare.CriAtomEx.SpeakerSystem speaker_system, CriWare.CriAtomEx.SpeakerAngles8ch& angle_array) { }
        private System.Void criAtomEx_ControlVirtualSpeakerSetting(System.Boolean sw) { }
        private System.Void criAtomEx_EnableBusSendOffsetWhenLevelNotExist(System.Boolean enable) { }
        private System.Void criAtom_SetDeviceId_WASAPI(CriWare.CriAtomEx.SoundRendererType soundRendererType, System.String deviceId) { }
        private System.Void criAtom_SetDeviceId_WASAPI(CriWare.CriAtomEx.SoundRendererType type, System.IntPtr deviceId) { }
        private System.Boolean criAtomUnity_LoadAudioDeviceList_PC() { }
        private System.Int32 criAtomUnity_GetNumAudioDevices_PC() { }
        private System.IntPtr criAtomUnity_GetAudioDeviceName_PC(System.Int32 index) { }
        private System.IntPtr criAtomUnity_GetAudioDeviceId_PC(System.Int32 index) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003F
    public class CriAtomExCategory
    {
        // Methods
        private System.Void SetVolume(System.String name, System.Single volume) { }
        private System.Void SetVolume(System.Int32 id, System.Single volume) { }
        private System.Single GetVolume(System.String name) { }
        private System.Single GetVolume(System.Int32 id) { }
        private System.Void Mute(System.String name, System.Boolean mute) { }
        private System.Void Mute(System.Int32 id, System.Boolean mute) { }
        private System.Boolean IsMuted(System.String name) { }
        private System.Boolean IsMuted(System.Int32 id) { }
        private System.Void Solo(System.String name, System.Boolean solo, System.Single muteVolume) { }
        private System.Void Solo(System.Int32 id, System.Boolean solo, System.Single muteVolume) { }
        private System.Boolean IsSoloed(System.String name) { }
        private System.Boolean IsSoloed(System.Int32 id) { }
        private System.Void Pause(System.String name, System.Boolean pause) { }
        private System.Void Pause(System.Int32 id, System.Boolean pause) { }
        private System.Boolean IsPaused(System.String name) { }
        private System.Boolean IsPaused(System.Int32 id) { }
        private System.Void SetAisacControl(System.String name, System.String controlName, System.Single value) { }
        private System.Void SetAisac(System.String name, System.String controlName, System.Single value) { }
        private System.Void SetAisacControl(System.Int32 id, System.Int32 controlId, System.Single value) { }
        private System.Void SetAisac(System.Int32 id, System.Int32 controlId, System.Single value) { }
        private System.Void SetReactParameter(System.String name, CriWare.CriAtomExCategory.ReactParameter parameter) { }
        private System.Boolean GetReactParameter(System.String name, CriWare.CriAtomExCategory.ReactParameter& parameter) { }
        private System.Boolean GetAttachedAisacInfoById(System.UInt32 id, System.Int32 aisacAttachedIndex, CriWare.CriAtomEx.AisacInfo& aisacInfo) { }
        private System.Boolean GetAttachedAisacInfoByName(System.String name, System.Int32 aisacAttachedIndex, CriWare.CriAtomEx.AisacInfo& aisacInfo) { }
        private System.Boolean GetCurrentAisacControlValue(System.String categoryName, System.String aisacControlName, System.Single& controlValue) { }
        private CriWare.CriAtomExCategory.ReactStatus GetReactStatus(System.String reactName) { }
        private System.Void criAtomExCategory_SetVolumeByName(System.String name, System.Single volume) { }
        private System.Single criAtomExCategory_GetVolumeByName(System.String name) { }
        private System.Void criAtomExCategory_SetVolumeById(System.Int32 id, System.Single volume) { }
        private System.Single criAtomExCategory_GetVolumeById(System.Int32 id) { }
        private System.Void criAtomExCategory_MuteById(System.Int32 id, System.Boolean mute) { }
        private System.Boolean criAtomExCategory_IsMutedById(System.Int32 id) { }
        private System.Void criAtomExCategory_MuteByName(System.String name, System.Boolean mute) { }
        private System.Boolean criAtomExCategory_IsMutedByName(System.String name) { }
        private System.Void criAtomExCategory_SoloById(System.Int32 id, System.Boolean solo, System.Single volume) { }
        private System.Boolean criAtomExCategory_IsSoloedById(System.Int32 id) { }
        private System.Void criAtomExCategory_SoloByName(System.String name, System.Boolean solo, System.Single volume) { }
        private System.Boolean criAtomExCategory_IsSoloedByName(System.String name) { }
        private System.Void criAtomExCategory_PauseById(System.Int32 id, System.Boolean pause) { }
        private System.Boolean criAtomExCategory_IsPausedById(System.Int32 id) { }
        private System.Void criAtomExCategory_PauseByName(System.String name, System.Boolean pause) { }
        private System.Boolean criAtomExCategory_IsPausedByName(System.String name) { }
        private System.Void criAtomExCategory_SetAisacControlById(System.Int32 id, System.UInt16 controlId, System.Single value) { }
        private System.Void criAtomExCategory_SetAisacControlByName(System.String name, System.String controlName, System.Single value) { }
        private System.Void criAtomExCategory_SetReactParameter(System.String react_name, CriWare.CriAtomExCategory.ReactParameter& parameter) { }
        private System.Boolean criAtomExCategory_GetReactParameter(System.String react_name, CriWare.CriAtomExCategory.ReactParameter& parameter) { }
        private System.Boolean criAtomExCategory_GetAttachedAisacInfoById(System.UInt32 id, System.Int32 aisacAttachedIndex, System.IntPtr aisacInfo) { }
        private System.Boolean criAtomExCategory_GetAttachedAisacInfoByName(System.String name, System.Int32 aisacAttachedIndex, System.IntPtr aisacInfo) { }
        private System.Boolean criAtomExCategory_GetCurrentAisacControlValueByName(System.String category_name, System.String aisac_control_name, System.Single& control_value) { }
        private CriWare.CriAtomExCategory.ReactStatus criAtomExCategory_GetReactStatus(System.String react_name) { }

    }

    // TypeToken: 0x200004D
    public class CriAtomExSequencer
    {
        // Methods
        private System.Void add_OnCallback(CriWare.CriAtomExSequencer.EventCallback value) { }
        private System.Void remove_OnCallback(CriWare.CriAtomExSequencer.EventCallback value) { }
        private System.Void SetEventCallback(CriWare.CriAtomExSequencer.EventCbFunc func, System.String separator) { }

    }

    // TypeToken: 0x2000051
    public class CriAtomExBeatSync
    {
        // Methods
        private System.Void add_OnCallback(CriWare.CriAtomExBeatSync.CbFunc value) { }
        private System.Void remove_OnCallback(CriWare.CriAtomExBeatSync.CbFunc value) { }
        private System.Void SetCallback(CriWare.CriAtomExBeatSync.CbFunc func) { }

    }

    // TypeToken: 0x2000054
    public class CriAtomExAsr
    {
        // Methods
        private System.Void AttachBusAnalyzer(System.String busName, System.Int32 interval, System.Int32 peakHoldTime) { }
        private System.Void AttachBusAnalyzer(System.Int32 interval, System.Int32 peakHoldTime) { }
        private System.Void DetachBusAnalyzer(System.String busName) { }
        private System.Void DetachBusAnalyzer() { }
        private System.Void GetBusAnalyzerInfo(System.String busName, CriWare.CriAtomExAsr.BusAnalyzerInfo& info) { }
        private System.Void GetBusAnalyzerInfo(System.Int32 busId, CriWare.CriAtomExAsr.BusAnalyzerInfo& info) { }
        private System.Void SetBusVolume(System.String busName, System.Single volume) { }
        private System.Void SetBusVolume(System.Int32 busId, System.Single volume) { }
        private System.Void SetBusSendLevel(System.String busName, System.String sendTo, System.Single level) { }
        private System.Void SetBusSendLevel(System.Int32 busId, System.Int32 sendTo, System.Single level) { }
        private System.Void SetBusMatrix(System.String busName, System.Int32 inputChannels, System.Int32 outputChannels, System.Single[] matrix) { }
        private System.Void SetBusMatrix(System.Int32 busId, System.Int32 inputChannels, System.Int32 outputChannels, System.Single[] matrix) { }
        private System.Void SetEffectBypass(System.String busName, System.String effectName, System.Boolean bypass) { }
        private System.Void SetEffectParameter(System.String busName, System.String effectName, System.UInt32 parameterIndex, System.Single parameterValue) { }
        private System.Single GetEffectParameter(System.String busName, System.String effectName, System.UInt32 parameterIndex) { }
        private System.Boolean RegisterEffectInterface(System.IntPtr afx_interface) { }
        private System.Void UnregisterEffectInterface(System.IntPtr afx_interface) { }
        private System.Void GetBusVolume(System.String busName, System.Single& volume) { }
        private System.Int32 GetPcmOutput(System.Int32 outputChannels, System.Int32 outputSamples, System.Single[][] buffer) { }
        private System.Int32 GetNumBufferedPcmOutputSamples() { }
        private System.Void SetPcmBufferSize(System.Int32 numSamples) { }
        private System.Void criAtomExAsr_AttachBusAnalyzerByName(System.String busName, CriWare.CriAtomExAsr.BusAnalyzerConfig& config) { }
        private System.Void criAtomExAsr_AttachBusAnalyzer(System.Int32 busNo, CriWare.CriAtomExAsr.BusAnalyzerConfig& config) { }
        private System.Void criAtomExAsr_DetachBusAnalyzerByName(System.String busName) { }
        private System.Void criAtomExAsr_DetachBusAnalyzer(System.Int32 busNo) { }
        private System.Void criAtomExAsr_GetBusAnalyzerInfoByName(System.String busName, System.IntPtr info) { }
        private System.Void criAtomExAsr_GetBusAnalyzerInfo(System.Int32 busNo, System.IntPtr info) { }
        private System.Void criAtomExAsr_SetBusVolumeByName(System.String busName, System.Single volume) { }
        private System.Void criAtomExAsr_SetBusVolume(System.Int32 busNo, System.Single volume) { }
        private System.Void criAtomExAsr_SetBusSendLevelByName(System.String busName, System.String sendtoName, System.Single level) { }
        private System.Void criAtomExAsr_SetBusSendLevel(System.Int32 busNo, System.Int32 sendtoNo, System.Single level) { }
        private System.Void criAtomExAsr_SetBusMatrixByName(System.String busName, System.Int32 inputChannels, System.Int32 outputChannels, System.Single[] matrix) { }
        private System.Void criAtomExAsr_SetBusMatrix(System.Int32 busNo, System.Int32 inputChannels, System.Int32 outputChannels, System.Single[] matrix) { }
        private System.Void criAtomExAsr_SetEffectBypass(System.String busName, System.String effectName, System.Boolean bypass) { }
        private System.Void criAtomExAsr_UpdateEffectParameters(System.String busName, System.String effectName) { }
        private System.Void criAtomExAsr_SetEffectParameter(System.String busName, System.String effectName, System.UInt32 parameterIndex, System.Single parameterValue) { }
        private System.Single criAtomExAsr_GetEffectParameter(System.String busName, System.String effectName, System.UInt32 parameterIndex) { }
        private System.Boolean criAtomExAsr_RegisterEffectInterface(System.IntPtr afx_interface) { }
        private System.Void criAtomExAsr_UnregisterEffectInterface(System.IntPtr afx_interface) { }
        private System.Void criAtomExAsr_GetBusVolumeByName(System.String busName, System.Single& volume) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000057
    public class CriAtomExLatencyEstimator
    {
        // Methods
        private System.Void InitializeModule() { }
        private System.Void FinalizeModule() { }
        private CriWare.CriAtomExLatencyEstimator.EstimatorInfo GetCurrentInfo() { }

    }

    // TypeToken: 0x200005A
    public class CriAtomEx3dListener : CriDisposable
    {
        // Fields
        private System.IntPtr handle;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.IntPtr get_nativeHandle() { }
        private System.Void Update() { }
        private System.Void ResetParameters() { }
        private System.Void SetPosition(System.Single x, System.Single y, System.Single z) { }
        private System.Void SetVelocity(System.Single x, System.Single y, System.Single z) { }
        private System.Void SetOrientation(System.Single fx, System.Single fy, System.Single fz, System.Single ux, System.Single uy, System.Single uz) { }
        private System.Void SetDistanceFactor(System.Single distanceFactor) { }
        private System.Void SetDopplerMultiplier(System.Single dopplerMultiplier) { }
        private System.Void SetFocusPoint(System.Single x, System.Single y, System.Single z) { }
        private System.Void SetDistanceFocusLevel(System.Single distanceFocusLevel) { }
        private System.Void SetDirectionFocusLevel(System.Single directionFocusLevel) { }
        private System.Void Set3dRegion(CriWare.CriAtomEx3dRegion region3d) { }
        private System.Boolean IsDestroyable() { }
        private System.Void Finalize() { }
        private System.IntPtr criAtomEx3dListener_Create(CriWare.CriAtomEx3dListener.Config& config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomEx3dListener_Destroy(System.IntPtr ex_3d_listener) { }
        private System.Void criAtomEx3dListener_Update(System.IntPtr ex_3d_listener) { }
        private System.Void criAtomEx3dListener_ResetParameters(System.IntPtr ex_3d_listener) { }
        private System.Void criAtomEx3dListener_SetPosition(System.IntPtr ex_3d_listener, CriWare.CriAtomEx.NativeVector& position) { }
        private System.Void criAtomEx3dListener_SetVelocity(System.IntPtr ex_3d_listener, CriWare.CriAtomEx.NativeVector& velocity) { }
        private System.Void criAtomEx3dListener_SetOrientation(System.IntPtr ex_3d_listener, CriWare.CriAtomEx.NativeVector& front, CriWare.CriAtomEx.NativeVector& top) { }
        private System.Void criAtomEx3dListener_SetDistanceFactor(System.IntPtr ex_3d_listener, System.Single distance_factor) { }
        private System.Void criAtomEx3dListener_SetDopplerMultiplier(System.IntPtr ex_3d_listener, System.Single doppler_multiplier) { }
        private System.Void criAtomEx3dListener_SetFocusPoint(System.IntPtr ex_3d_listener, CriWare.CriAtomEx.NativeVector& focus_point) { }
        private System.Void criAtomEx3dListener_SetDistanceFocusLevel(System.IntPtr ex_3d_listener, System.Single distance_focus_level) { }
        private System.Void criAtomEx3dListener_SetDirectionFocusLevel(System.IntPtr ex_3d_listener, System.Single direction_focus_level) { }
        private System.Boolean criAtomEx3dListener_IsDestroyable(System.IntPtr ex_3d_listener) { }
        private System.Void criAtomEx3dListener_Set3dRegionHn(System.IntPtr ex_3d_listener, System.IntPtr ex_3d_region) { }

    }

    // TypeToken: 0x200005C
    public class CriAtomEx3dSource : CriDisposable
    {
        // Fields
        private System.UInt32 currentRandomPositionListMaxLength;        // 0x20
        private System.IntPtr handle;        // 0x28

        // Methods
        private System.Void .ctor(System.Boolean enableVoicePriorityDecay, System.UInt32 randomPositionListMaxLength) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.IntPtr get_nativeHandle() { }
        private System.Void Update() { }
        private System.Void ResetParameters() { }
        private System.Void SetPosition(System.Single x, System.Single y, System.Single z) { }
        private System.Void SetVelocity(System.Single x, System.Single y, System.Single z) { }
        private System.Void SetOrientation(UnityEngine.Vector3 front, UnityEngine.Vector3 top) { }
        private System.Void SetConeOrientation(System.Single x, System.Single y, System.Single z) { }
        private System.Void SetConeParameter(System.Single insideAngle, System.Single outsideAngle, System.Single outsideVolume) { }
        private System.Void SetMinMaxDistance(System.Single minDistance, System.Single maxDistance) { }
        private System.Void SetInteriorPanField(System.Single sourceRadius, System.Single interiorDistance) { }
        private System.Void SetDopplerFactor(System.Single dopplerFactor) { }
        private System.Void SetVolume(System.Single volume) { }
        private System.Void SetMaxAngleAisacDelta(System.Single maxDelta) { }
        private System.Void SetAttenuationDistanceSetting(System.Boolean flag) { }
        private System.Boolean GetAttenuationDistanceSetting() { }
        private System.Void SetRandomPositionConfig(System.Nullable<CriWare.CriAtomEx.Randomize3dConfig> config) { }
        private System.Void SetRandomPositionList(UnityEngine.Vector3[] positionList) { }
        private System.Void Set3dRegion(CriWare.CriAtomEx3dRegion region3d) { }
        private System.Void SetListenerBasedElevationAngleAisacControlId(System.UInt16 aisacControlId) { }
        private System.Void SetSourceBasedElevationAngleAisacControlId(System.UInt16 aisacControlId) { }
        private System.Void SetDistanceAisacControlId(System.UInt16 aisacControlId) { }
        private System.Boolean IsDestroyable() { }
        private CriWare.CriAtomEx.NativeVector GetPosition() { }
        private System.Void Finalize() { }
        private System.IntPtr criAtomEx3dSource_Create(CriWare.CriAtomEx3dSource.Config& config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomEx3dSource_Destroy(System.IntPtr ex_3d_source) { }
        private System.Void criAtomEx3dSource_Update(System.IntPtr ex_3d_source) { }
        private System.Void criAtomEx3dSource_ResetParameters(System.IntPtr ex_3d_source) { }
        private System.Void criAtomEx3dSource_SetPosition(System.IntPtr ex_3d_source, CriWare.CriAtomEx.NativeVector& position) { }
        private System.Void criAtomEx3dSource_SetVelocity(System.IntPtr ex_3d_source, CriWare.CriAtomEx.NativeVector& velocity) { }
        private System.Void criAtomEx3dSource_SetOrientation(System.IntPtr ex_3d_source, CriWare.CriAtomEx.NativeVector& front, CriWare.CriAtomEx.NativeVector& top) { }
        private System.Void criAtomEx3dSource_SetConeOrientation(System.IntPtr ex_3d_source, CriWare.CriAtomEx.NativeVector& cone_orient) { }
        private System.Void criAtomEx3dSource_SetConeParameter(System.IntPtr ex_3d_source, System.Single inside_angle, System.Single outside_angle, System.Single outside_volume) { }
        private System.Void criAtomEx3dSource_SetMinMaxAttenuationDistance(System.IntPtr ex_3d_source, System.Single min_distance, System.Single max_distance) { }
        private System.Void criAtomEx3dSource_SetInteriorPanField(System.IntPtr ex_3d_source, System.Single source_radius, System.Single interior_distance) { }
        private System.Void criAtomEx3dSource_SetDopplerFactor(System.IntPtr ex_3d_source, System.Single doppler_factor) { }
        private System.Void criAtomEx3dSource_SetVolume(System.IntPtr ex_3d_source, System.Single volume) { }
        private System.Void criAtomEx3dSource_SetMaxAngleAisacDelta(System.IntPtr ex_3d_source, System.Single max_delta) { }
        private System.Void criAtomEx3dSource_SetAttenuationDistanceSetting(System.IntPtr ex_3d_source, System.Boolean flag) { }
        private System.Boolean criAtomEx3dSource_GetAttenuationDistanceSetting(System.IntPtr ex_3d_source) { }
        private System.Void criAtomEx3dSource_SetRandomPositionConfig(System.IntPtr ex_3d_source, CriWare.CriAtomEx.Randomize3dConfig& config) { }
        private System.Void criAtomEx3dSource_SetRandomPositionConfig(System.IntPtr ex_3d_source, System.IntPtr config) { }
        private System.Void criAtomEx3dSource_SetRandomPositionList(System.IntPtr ex_3d_source, CriWare.CriAtomEx.NativeVector[] position_list, System.UInt32 length) { }
        private System.Void criAtomEx3dSource_SetDistanceAisacControlId(System.IntPtr ex_3d_source, System.UInt16 aisac_control_id) { }
        private System.Boolean criAtomEx3dSource_IsDestroyable(System.IntPtr ex_3d_source) { }
        private CriWare.CriAtomEx.NativeVector criAtomEx3dSource_GetPosition(System.IntPtr ex_3d_source) { }
        private System.Void criAtomEx3dSource_Set3dRegionHn(System.IntPtr ex_3d_source, System.IntPtr ex_3d_region) { }
        private System.Void criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId(System.IntPtr ex_3d_source, System.UInt16 aisac_control_id) { }
        private System.Void criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId(System.IntPtr ex_3d_source, System.UInt16 aisac_control_id) { }

    }

    // TypeToken: 0x200005E
    public class CriAtomEx3dTransceiver : CriDisposable
    {
        // Fields
        private System.IntPtr handle;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.IntPtr get_nativeHandle() { }
        private System.Void Update() { }
        private System.Void SetInputPosition(UnityEngine.Vector3 position) { }
        private System.Void SetOutputPosition(UnityEngine.Vector3 position) { }
        private System.Void SetInputOrientation(UnityEngine.Vector3 front, UnityEngine.Vector3 top) { }
        private System.Void SetOutputOrientation(UnityEngine.Vector3 front, UnityEngine.Vector3 top) { }
        private System.Void SetOutputConeParameter(System.Single insideAngle, System.Single outsideAngle, System.Single outsideVolume) { }
        private System.Void SetOutputMinMaxDistance(System.Single minDistance, System.Single maxDistance) { }
        private System.Void SetOutputInteriorPanField(System.Single radius, System.Single interiorDistance) { }
        private System.Void SetInputCrossFadeField(System.Single directAudioRadius, System.Single crossfadeDistance) { }
        private System.Void SetOutputVolume(System.Single volume) { }
        private System.Void AttachAisac(System.String globalAisacName) { }
        private System.Void DetachAisac(System.String globalAisacName) { }
        private System.Void SetMaxAngleAisacDelta(System.Single maxDelta) { }
        private System.Void SetDistanceAisacControlId(System.UInt16 aisacControlId) { }
        private System.Void SetListenerBasedAzimuthAngleAisacControlId(System.UInt16 aisacControlId) { }
        private System.Void SetListenerBasedElevationAngleAisacControlId(System.UInt16 aisacControlId) { }
        private System.Void SetTransceiverOutputBasedAzimuthAngleAisacControlId(System.UInt16 aisacControlId) { }
        private System.Void SetTransceiverOutputBasedElevationAngleAisacControlId(System.UInt16 aisacControlId) { }
        private System.Void Set3dRegion(CriWare.CriAtomEx3dRegion region3d) { }
        private System.Void Finalize() { }

    }

    // TypeToken: 0x2000061
    public class CriAtomEx3dRegion : CriDisposable
    {
        // Fields
        private System.IntPtr handle;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Finalize() { }
        private System.IntPtr get_nativeHandle() { }

    }

    // TypeToken: 0x2000064
    public class CriAtomExAcb : CriDisposable
    {
        // Fields
        private System.IntPtr handle;        // 0x20
        private System.Runtime.InteropServices.GCHandle dataHandle;        // 0x28

        // Methods
        private System.IntPtr get_nativeHandle() { }
        private System.Boolean get_isAvailable() { }
        private CriWare.CriAtomExAcb LoadAcbFile(CriWare.CriFsBinder binder, System.String acbPath, System.String awbPath) { }
        private CriWare.CriAtomExAcb LoadAcbData(System.Byte[] acbData, CriWare.CriFsBinder awbBinder, System.String awbPath) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean Exists(System.String cueName) { }
        private System.Boolean Exists(System.Int32 cueId) { }
        private System.Boolean GetCueInfo(System.String cueName, CriWare.CriAtomEx.CueInfo& info) { }
        private System.Boolean GetCueInfo(System.Int32 cueId, CriWare.CriAtomEx.CueInfo& info) { }
        private System.Boolean GetCueInfoByIndex(System.Int32 index, CriWare.CriAtomEx.CueInfo& info) { }
        private CriWare.CriAtomEx.CueInfo[] GetCueInfoList() { }
        private System.Boolean GetWaveFormInfo(System.String cueName, CriWare.CriAtomEx.WaveformInfo& info) { }
        private System.Boolean GetWaveFormInfo(System.Int32 cueId, CriWare.CriAtomEx.WaveformInfo& info) { }
        private System.Int32 GetNumCuePlaying(System.String name) { }
        private System.Int32 GetNumCuePlaying(System.Int32 id) { }
        private System.Int32 GetBlockIndex(System.String cueName, System.String blockName) { }
        private System.Int32 GetBlockIndex(System.Int32 cueId, System.String blockName) { }
        private System.Int32 GetNumUsableAisacControls(System.String cueName) { }
        private System.Int32 GetNumUsableAisacControls(System.Int32 cueId) { }
        private System.Boolean GetUsableAisacControl(System.String cueName, System.Int32 index, CriWare.CriAtomEx.AisacControlInfo& info) { }
        private System.Boolean GetUsableAisacControl(System.Int32 cueId, System.Int32 index, CriWare.CriAtomEx.AisacControlInfo& info) { }
        private CriWare.CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(System.String cueName) { }
        private CriWare.CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(System.Int32 cueId) { }
        private System.Void ResetCueTypeState(System.String cueName) { }
        private System.Void ResetCueTypeState(System.Int32 cueId) { }
        private System.Void AttachAwbFile(CriWare.CriFsBinder awb_binder, System.String awb_path, System.String awb_name) { }
        private System.Void DetachAwbFile(System.String awb_name) { }
        private System.Boolean IsReadyToRelease() { }
        private System.Single GetLoadProgress() { }
        private System.Void Decrypt(System.UInt64 key, System.UInt64 nonce) { }
        private System.Void .ctor(System.IntPtr handle, System.Nullable<System.Runtime.InteropServices.GCHandle> dataHandle) { }
        private System.Void Finalize() { }
        private System.IntPtr criAtomExAcb_LoadAcbFile(System.IntPtr acb_binder, System.String acb_path, System.IntPtr awb_binder, System.String awb_path, System.IntPtr work, System.Int32 work_size) { }
        private System.IntPtr criAtomExAcb_LoadAcbData(System.IntPtr acb_data, System.Int32 acb_data_size, System.IntPtr awb_binder, System.String awb_path, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomExAcb_Release(System.IntPtr acb_hn) { }
        private System.Int32 criAtomExAcb_GetNumCues(System.IntPtr acb_hn) { }
        private System.Boolean criAtomExAcb_ExistsId(System.IntPtr acb_hn, System.Int32 id) { }
        private System.Boolean criAtomExAcb_ExistsName(System.IntPtr acb_hn, System.String name) { }
        private System.Int32 criAtomExAcb_GetNumUsableAisacControlsById(System.IntPtr acb_hn, System.Int32 id) { }
        private System.Int32 criAtomExAcb_GetNumUsableAisacControlsByName(System.IntPtr acb_hn, System.String name) { }
        private System.Boolean criAtomExAcb_GetUsableAisacControlById(System.IntPtr acb_hn, System.Int32 id, System.UInt16 index, System.IntPtr info) { }
        private System.Boolean criAtomExAcb_GetUsableAisacControlByName(System.IntPtr acb_hn, System.String name, System.UInt16 index, System.IntPtr info) { }
        private System.Boolean criAtomExAcb_GetWaveformInfoById(System.IntPtr acb_hn, System.Int32 id, System.IntPtr waveform_info) { }
        private System.Boolean criAtomExAcb_GetWaveformInfoByName(System.IntPtr acb_hn, System.String name, System.IntPtr waveform_info) { }
        private System.Boolean criAtomExAcb_GetCueInfoByName(System.IntPtr acb_hn, System.String name, System.IntPtr info) { }
        private System.Boolean criAtomExAcb_GetCueInfoById(System.IntPtr acb_hn, System.Int32 id, System.IntPtr info) { }
        private System.Boolean criAtomExAcb_GetCueInfoByIndex(System.IntPtr acb_hn, System.Int32 index, System.IntPtr info) { }
        private System.Int32 criAtomExAcb_GetNumCuePlayingCountByName(System.IntPtr acb_hn, System.String name) { }
        private System.Int32 criAtomExAcb_GetNumCuePlayingCountById(System.IntPtr acb_hn, System.Int32 id) { }
        private System.Int32 criAtomExAcb_GetBlockIndexById(System.IntPtr acb_hn, System.Int32 id, System.String block_name) { }
        private System.Int32 criAtomExAcb_GetBlockIndexByName(System.IntPtr acb_hn, System.String name, System.String block_name) { }
        private System.Void criAtomExAcb_ResetCueTypeStateByName(System.IntPtr acb_hn, System.String name) { }
        private System.Void criAtomExAcb_ResetCueTypeStateById(System.IntPtr acb_hn, System.Int32 id) { }
        private System.Void criAtomExAcb_AttachAwbFile(System.IntPtr acb_hn, System.IntPtr awb_binder, System.String awb_path, System.String awb_name, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomExAcb_DetachAwbFile(System.IntPtr acb_hn, System.String awb_name) { }
        private System.Boolean criAtomExAcb_IsReadyToRelease(System.IntPtr acb_hn) { }

    }

    // TypeToken: 0x2000065
    public class CriAtomExAcbLoader : CriDisposable
    {
        // Fields
        private System.IntPtr handle;        // 0x20
        private System.Nullable<System.Runtime.InteropServices.GCHandle> gch;        // 0x28

        // Methods
        private CriWare.CriAtomExAcbLoader LoadAcbFileAsync(CriWare.CriFsBinder binder, System.String acbPath, System.String awbPath, System.Boolean loadAwbOnMemory) { }
        private CriWare.CriAtomExAcbLoader LoadAcbDataAsync(System.Byte[] acbData, CriWare.CriFsBinder awbBinder, System.String awbPath, System.Boolean loadAwbOnMemory) { }
        private CriWare.CriAtomExAcbLoader.Status GetStatus() { }
        private CriWare.CriAtomExAcb MoveAcb() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor(System.IntPtr handle, System.Nullable<System.Runtime.InteropServices.GCHandle> dataHandle) { }
        private System.Void Finalize() { }
        private System.IntPtr criAtomExAcbLoader_Create(CriWare.CriAtomExAcbLoader.LoaderConfig& config) { }
        private System.Void criAtomExAcbLoader_Destroy(System.IntPtr acb_loader) { }
        private System.Boolean criAtomExAcbLoader_LoadAcbFileAsync(System.IntPtr acb_loader, System.IntPtr acb_binder, System.String acb_path, System.IntPtr awb_binder, System.String awb_path) { }
        private System.Boolean criAtomExAcbLoader_LoadAcbDataAsync(System.IntPtr acb_loader, System.IntPtr acb_data, System.Int32 acb_size, System.IntPtr awb_binder, System.String awb_path) { }
        private CriWare.CriAtomExAcbLoader.Status criAtomExAcbLoader_GetStatus(System.IntPtr acb_loader) { }
        private System.Boolean criAtomExAcbLoader_WaitForCompletion(System.IntPtr acb_loader) { }
        private System.IntPtr criAtomExAcbLoader_MoveAcbHandle(System.IntPtr acb_loader) { }

    }

    // TypeToken: 0x2000068
    public class CriAtomExAcf
    {
        // Methods
        private System.Int32 GetNumAisacControls() { }
        private System.Boolean GetAisacControlInfo(System.UInt16 index, CriWare.CriAtomEx.AisacControlInfo& info) { }
        private System.Int32 GetNumDspSettings() { }
        private System.Int32 GetNumDspSettings(System.IntPtr acfData, System.Int32 size) { }
        private System.String GetDspSettingNameByIndex(System.UInt16 index) { }
        private System.String GetDspSettingNameByIndex(System.IntPtr acfData, System.Int32 size, System.UInt16 index) { }
        private System.Boolean GetDspSettingInformation(System.String name, CriWare.CriAtomExAcf.AcfDspSettingInfo& info) { }
        private System.Boolean GetDspSettingSnapshotInformation(System.UInt16 index, CriWare.CriAtomExAcf.AcfDspSettingSnapshotInfo& info) { }
        private System.Boolean GetDspBusInformation(System.UInt16 index, CriWare.CriAtomExAcf.AcfDspBusInfo& info) { }
        private System.Boolean GetDspBusLinkInformation(System.UInt16 index, CriWare.CriAtomExAcf.AcfDspBusLinkInfo& info) { }
        private System.Int32 GetNumCategories() { }
        private System.Int32 GetNumCategoriesPerPlayback() { }
        private System.Boolean GetCategoryInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcf.CategoryInfo& info) { }
        private System.Boolean GetCategoryInfoByName(System.String name, CriWare.CriAtomExAcf.CategoryInfo& info) { }
        private System.Boolean GetCategoryInfoById(System.UInt32 id, CriWare.CriAtomExAcf.CategoryInfo& info) { }
        private System.Int32 GetNumGlobalAisacs() { }
        private System.Boolean GetGlobalAisacInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcf.GlobalAisacInfo& info) { }
        private System.Boolean GetGlobalAisacInfoByName(System.String name, CriWare.CriAtomExAcf.GlobalAisacInfo& info) { }
        private System.Boolean GetGlobalAisacGraphInfo(CriWare.CriAtomExAcf.GlobalAisacInfo aisacInfo, System.UInt16 graphIndex, CriWare.CriAtomExAcf.AisacGraphInfo& graphInfo) { }
        private System.Boolean GetGlobalAisacValue(CriWare.CriAtomExAcf.GlobalAisacInfo aisacInfo, System.Single control, CriWare.CriAtomExAcf.AisacGraphType type, System.Single& value) { }
        private System.Boolean GetAcfInfo(CriWare.CriAtomExAcf.AcfInfo& acfInfo) { }
        private System.Int32 GetNumSelectors() { }
        private System.Boolean GetSelectorInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcf.SelectorInfo& info) { }
        private System.Boolean GetSelectorInfoByName(System.String name, CriWare.CriAtomExAcf.SelectorInfo& info) { }
        private System.Boolean GetSelectorLabelInfo(CriWare.CriAtomExAcf.SelectorInfo selectorInfo, System.UInt16 labelIndex, CriWare.CriAtomExAcf.SelectorLabelInfo& info) { }
        private System.Int32 GetNumBuses() { }
        private System.Int32 GetMaxBusesOfDspBusSettings() { }
        private System.String FindBusName(System.String busName) { }
        private System.Int32 criAtomExAcf_GetNumAisacControls() { }
        private System.Boolean criAtomExAcf_GetAisacControlInfo(System.UInt16 index, System.IntPtr info) { }
        private System.UInt32 criAtomExAcf_GetAisacControlIdByName(System.String name) { }
        private System.String criAtomExAcf_GetAisacControlNameById(System.UInt32 id) { }
        private System.Int32 criAtomExAcf_GetNumDspSettings() { }
        private System.Int32 criAtomExAcf_GetNumDspSettingsFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size) { }
        private System.IntPtr criAtomExAcf_GetDspSettingNameByIndex(System.UInt16 index) { }
        private System.IntPtr criAtomExAcf_GetDspSettingNameByIndexFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size, System.UInt16 index) { }
        private System.Boolean criAtomExAcf_GetDspSettingInformation(System.String name, System.IntPtr info) { }
        private System.Boolean criAtomExAcf_GetDspSettingSnapshotInformation(System.UInt16 index, System.IntPtr info) { }
        private System.Boolean criAtomExAcf_GetDspBusInformation(System.UInt16 index, System.IntPtr info) { }
        private System.Int32 criAtomExAcf_GetDspFxType(System.UInt16 index) { }
        private System.String criAtomExAcf_GetDspFxName(System.UInt16 index) { }
        private System.Boolean criAtomExAcf_GetDspFxParameters(System.UInt16 index, System.IntPtr parameters, System.Int32 size) { }
        private System.Boolean criAtomExAcf_GetDspBusLinkInformation(System.UInt16 index, System.IntPtr info) { }
        private System.Int32 criAtomExAcf_GetNumCategoriesFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size) { }
        private System.Int32 criAtomExAcf_GetNumCategories() { }
        private System.Int32 criAtomExAcf_GetNumCategoriesPerPlaybackFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size) { }
        private System.Int32 criAtomExAcf_GetNumCategoriesPerPlayback() { }
        private System.Boolean criAtomExAcf_GetCategoryInfo(System.UInt16 index, System.IntPtr info) { }
        private System.Boolean criAtomExAcf_GetCategoryInfoByName(System.String name, System.IntPtr info) { }
        private System.Boolean criAtomExAcf_GetCategoryInfoById(System.UInt32 id, System.IntPtr info) { }
        private System.Int32 criAtomExAcf_GetNumGlobalAisacs() { }
        private System.Boolean criAtomExAcf_GetGlobalAisacInfo(System.UInt16 index, System.IntPtr info) { }
        private System.Boolean criAtomExAcf_GetGlobalAisacInfoByName(System.String name, System.IntPtr info) { }
        private System.Boolean criAtomExAcf_GetGlobalAisacGraphInfo(System.IntPtr aisac_info, System.UInt16 graph_index, System.IntPtr graph_info) { }
        private System.Boolean criAtomExAcf_GetGlobalAisacValue(System.IntPtr aisac_info, System.Single control, CriWare.CriAtomExAcf.AisacGraphType type, System.Single& value) { }
        private System.Boolean criAtomExAcf_GetAcfInfo(System.IntPtr acf_info) { }
        private System.Boolean criAtomExAcf_GetAcfInfoFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size, System.IntPtr acf_info) { }
        private System.Int32 criAtomExAcf_GetNumSelectors() { }
        private System.Boolean criAtomExAcf_GetSelectorInfoByIndex(System.UInt16 index, System.IntPtr info) { }
        private System.Boolean criAtomExAcf_GetSelectorInfoByName(System.String name, System.IntPtr info) { }
        private System.Boolean criAtomExAcf_GetSelectorLabelInfo(System.IntPtr selector_info, System.UInt16 label_index, System.IntPtr info) { }
        private System.Int32 criAtomExAcf_GetNumBusesFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size) { }
        private System.Int32 criAtomExAcf_GetNumBuses() { }
        private System.Int32 criAtomExAcf_GetMaxBusesOfDspBusSettingsFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size) { }
        private System.Int32 criAtomExAcf_GetMaxBusesOfDspBusSettings() { }
        private System.String criAtomExAcf_FindBusName(System.String bus_name) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000077
    public class CriAtomExAsrRack : CriDisposable
    {
        // Fields
        public static System.Int32 defaultRackId;        // 0x0
        private System.Int32 _rackId;        // 0x20
        private System.Boolean hasExistingRackId;        // 0x24

        // Methods
        private System.Void .ctor(CriWare.CriAtomExAsrRack.Config config, CriWare.CriAtomExAsrRack.PlatformConfig platformConfig) { }
        private System.Void .ctor(System.Int32 existingRackId) { }
        private System.Void AttachDspBusSetting(System.String settingName) { }
        private System.Void DetachDspBusSetting() { }
        private System.Void ApplyDspBusSnapshot(System.String snapshotName, System.Int32 timeMs) { }
        private System.String GetAppliedDspBusSnapshotName(System.Int32 rackId) { }
        private System.String GetAppliedDspBusSnapshotName() { }
        private CriWare.CriAtomExAsrRack.PerformanceInfo GetPerformanceInfo() { }
        private CriWare.CriAtomExAsrRack.PerformanceInfo GetPerformanceInfoByRackId(System.Int32 rackId) { }
        private System.Void ResetPerformanceMonitor() { }
        private System.Void ResetPerformanceMonitorByRackId(System.Int32 rackId) { }
        private System.Void SetAisacControl(System.Int32 rackId, System.String controlName, System.Single value) { }
        private System.Void SetAisacControl(System.Int32 rackId, System.Int32 controlId, System.Single value) { }
        private System.Void Dispose() { }
        private System.Int32 get_rackId() { }
        private CriWare.CriAtomExAsrRack.Config get_defaultConfig() { }
        private System.Void Finalize() { }
        private System.Int32 CRIWARE6158351D(CriWare.CriAtomExAsrRack.Config& config, CriWare.CriAtomExAsrRack.PlatformConfig& platformConfig) { }
        private System.Void criAtomExAsrRack_Destroy(System.Int32 rackId) { }
        private System.Void criAtomExAsrRack_AttachDspBusSetting(System.Int32 rackId, System.String setting, System.IntPtr work, System.Int32 workSize) { }
        private System.Void criAtomExAsrRack_DetachDspBusSetting(System.Int32 rackId) { }
        private System.IntPtr criAtomExAsrRack_GetAppliedDspBusSnapshotName(System.Int32 rackId) { }
        private System.Void criAtomExAsrRack_ApplyDspBusSnapshot(System.Int32 rackId, System.String snapshotName, System.Int32 timeMs) { }
        private System.Void criAtomExAsrRack_GetPerformanceInfo(System.Int32 rackId, CriWare.CriAtomExAsrRack.PerformanceInfo& perfInfo) { }
        private System.Void criAtomExAsrRack_ResetPerformanceMonitor(System.Int32 rackId) { }
        private System.Void criAtomExAsrRack_SetAisacControlById(System.Int32 rackId, System.UInt16 controlId, System.Single value) { }
        private System.Void criAtomExAsrRack_SetAisacControlByName(System.Int32 rackId, System.String controlName, System.Single value) { }

    }

    // TypeToken: 0x200007C
    public class CriAtomExAuxIn : CriDisposable
    {
        // Fields
        private static System.String errorInvalidHandle;        // 0x0
        private System.IntPtr handle;        // 0x20
        private CriWare.CriAudioReadStream inputReadStream;        // 0x28

        // Methods
        private System.Void .ctor(System.Nullable<CriWare.CriAtomExAuxIn.Config> config) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Start() { }
        private System.Void Stop() { }
        private System.Void SetFormat(System.Int32 numChannels, System.Int32 samplingRate) { }
        private System.Void GetFormat(System.Int32& numChannels, System.Int32& samplingRate) { }
        private System.Void SetVolume(System.Single volume) { }
        private System.Void SetFrequencyRatio(System.Single frequencyRatio) { }
        private System.Void SetBusSendLevel(System.String busName, System.Single level) { }
        private System.Void SetInputReadStream(CriWare.CriAudioReadStream stream) { }
        private System.IntPtr criAtomAuxIn_Create(CriWare.CriAtomExAuxIn.Config& config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomAuxIn_Destroy(System.IntPtr aux_in) { }
        private System.Void criAtomAuxIn_Start(System.IntPtr aux_in) { }
        private System.Void criAtomAuxIn_Stop(System.IntPtr aux_in) { }
        private System.Void criAtomAuxIn_SetVolume(System.IntPtr aux_in, System.Single volume) { }
        private System.Void criAtomAuxIn_SetFrequencyRatio(System.IntPtr aux_in, System.Single ratio) { }
        private System.Void criAtomAuxIn_SetBusSendLevelByName(System.IntPtr aux_in, System.String bus_name, System.Single level) { }
        private System.Void criAtomAuxIn_SetFormat(System.IntPtr aux_in, System.Int32 num_channels, System.Int32 sampling_rate) { }
        private System.Void criAtomAuxIn_GetFormat(System.IntPtr aux_in, System.Int32& num_channels, System.Int32& sampling_rate) { }
        private System.Void criAtomAuxIn_SetInputReadStream(System.IntPtr aux_in, System.IntPtr stream_cbfunc, System.IntPtr stream_ptr) { }

    }

    // TypeToken: 0x200007E
    public class CriAtomExMic : CriDisposable
    {
        // Fields
        private static System.String errorInvalidHandle;        // 0x0
        private static System.String errorInvalidBufferLength;        // 0x0
        private static System.String errorInvalidNumBuffers;        // 0x0
        private static System.String errorAlreadyInitialized;        // 0x0
        private static System.String errorNotInitialized;        // 0x0
        private static System.Boolean <isInitialized>k__BackingField;        // 0x0
        private System.IntPtr handle;        // 0x20
        private System.IntPtr[] bufferPointers;        // 0x28
        private System.Runtime.InteropServices.GCHandle[] gcHandles;        // 0x30
        private CriWare.CriAudioWriteStream outputWriteStream;        // 0x38
        private static System.Int32 _initializationCount;        // 0x4

        // Methods
        private System.Boolean get_isInitialized() { }
        private System.Void set_isInitialized(System.Boolean value) { }
        private System.Void InitializeModule() { }
        private System.Void FinalizeModule() { }
        private System.Void SetupOutputCategoryForMic_IOS(System.Boolean enable) { }
        private CriWare.CriAtomExMic.DeviceInfo[] GetDevices() { }
        private System.Int32 GetNumDevices() { }
        private System.Nullable<CriWare.CriAtomExMic.DeviceInfo> GetDefaultDevice() { }
        private System.Boolean IsFormatSupported(CriWare.CriAtomExMic.Config config) { }
        private CriWare.CriAtomExMic Create(System.Nullable<CriWare.CriAtomExMic.Config> config) { }
        private System.Void .ctor(System.IntPtr handle) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Start() { }
        private System.Void Stop() { }
        private System.Int32 GetNumChannels() { }
        private System.Int32 GetSamplingRate() { }
        private System.UInt32 GetNumBufferedSamples() { }
        private System.UInt32 GetNumBufferredSamples() { }
        private System.Boolean IsAvailable() { }
        private System.UInt32 ReadData(System.Single[] bufferMono) { }
        private System.UInt32 ReadData(System.Single[] bufferMono, System.UInt32 numToRead) { }
        private System.UInt32 ReadData(System.Single[] bufferL, System.Single[] bufferR) { }
        private System.UInt32 ReadData(System.Single[] bufferL, System.Single[] bufferR, System.UInt32 numToRead) { }
        private System.UInt32 ReadData(System.Single[][] buffers) { }
        private System.UInt32 ReadData(System.Single[][] buffers, System.UInt32 numToRead) { }
        private System.Void SetOutputWriteStream(CriWare.CriAudioWriteStream stream) { }
        private CriWare.CriAudioReadStream GetOutputReadStream() { }
        private CriWare.CriAtomExMic.Effect AttachEffect(System.IntPtr afxInterface, System.Single[] configParameters) { }
        private System.Void DetachEffect(CriWare.CriAtomExMic.Effect effect) { }
        private System.Void SetEffectParameter(CriWare.CriAtomExMic.Effect effect, System.Int32 parameterIndex, System.Single parameterValue) { }
        private System.Single GetEffectParameter(CriWare.CriAtomExMic.Effect effect, System.Int32 parameterIndex) { }
        private System.Void SetEffectBypass(CriWare.CriAtomExMic.Effect effect, System.Boolean bypass) { }
        private System.Void UpdateEffectParameters(CriWare.CriAtomExMic.Effect effect) { }
        private System.UInt32 InternalReadDataFromBufferPointers(System.UInt32 numToRead) { }
        private System.Void InternalClearBuffers() { }
        private System.Void criAtomMicUnity_Initialize() { }
        private System.Void criAtomMicUnity_Finalize() { }
        private System.Int32 criAtomMic_GetNumDevices() { }
        private System.Boolean criAtomMic_GetDevice(System.Int32 index, CriWare.CriAtomExMic.DeviceInfo& info) { }
        private System.Boolean criAtomMic_GetDefaultDevice(CriWare.CriAtomExMic.DeviceInfo& info) { }
        private System.Boolean criAtomMic_IsFormatSupported(CriWare.CriAtomExMic.Config& config) { }
        private System.IntPtr criAtomMic_Create(CriWare.CriAtomExMic.Config& config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomMic_Destroy(System.IntPtr mic) { }
        private System.Void criAtomMic_Start(System.IntPtr mic) { }
        private System.Void criAtomMic_Stop(System.IntPtr mic) { }
        private System.Int32 criAtomMic_GetNumChannels(System.IntPtr mic) { }
        private System.Int32 criAtomMic_GetSamplingRate(System.IntPtr mic) { }
        private System.UInt32 criAtomMic_GetNumBufferedSamples(System.IntPtr mic) { }
        private System.Boolean criAtomMic_IsAvailable(System.IntPtr mic) { }
        private System.UInt32 criAtomMic_ReadData(System.IntPtr mic, System.IntPtr[] data, System.UInt32 num_samples) { }
        private System.Void criAtomMic_SetOutputWriteStream(System.IntPtr mic, System.IntPtr stream_cbfunc, System.IntPtr stream_ptr) { }
        private System.IntPtr criAtomMic_GetOutputReadStream() { }
        private System.Int32 criAtomMic_CalculateWorkSizeForEffect(System.IntPtr mic, System.IntPtr afx_interface, System.Single[] config_parameters, System.UInt32 num_config_parameters) { }
        private System.IntPtr criAtomMic_AttachEffect(System.IntPtr mic, System.IntPtr afx_interface, System.Single[] config_parameters, System.UInt32 num_config_parameters, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomMic_DetachEffect(System.IntPtr mic, System.IntPtr effect) { }
        private System.IntPtr criAtomMic_GetEffectInstance(System.IntPtr mic, System.IntPtr effect) { }
        private System.Void criAtomMic_SetEffectBypass(System.IntPtr mic, System.IntPtr effect, System.Boolean bypass) { }
        private System.Void criAtomMic_SetEffectParameter(System.IntPtr mic, System.IntPtr effect, System.UInt32 parameter_index, System.Single parameter_value) { }
        private System.Single criAtomMic_GetEffectParameter(System.IntPtr mic, System.IntPtr effect, System.UInt32 parameter_index) { }
        private System.Void criAtomMic_UpdateEffectParameters(System.IntPtr mic, System.IntPtr effect) { }

    }

    // TypeToken: 0x2000082
    public class CriAtomExOutputAnalyzer : CriDisposable
    {
        // Fields
        public static System.Int32 MaximumSpectrumBands;        // 0x0
        protected System.IntPtr handle;        // 0x20
        protected CriWare.CriAtomExPlayer player;        // 0x28
        protected System.String busName;        // 0x30
        protected System.Int32 numBands;        // 0x38
        protected System.Int32 numCapturedPcmSamples;        // 0x3C
        protected CriWare.CriAtomExOutputAnalyzer.PcmCaptureCallback userPcmCaptureCallback;        // 0x40
        protected System.Single[] dataL;        // 0x48
        protected System.Single[] dataR;        // 0x50
        protected static System.Int32 pcmCapturerNumMaxData;        // 0x0
        protected static System.IntPtr InternalCallbackFunctionPointer;        // 0x0
        protected static CriWare.CriAtomExOutputAnalyzer.InternalPcmCaptureCallback DelegateObject;        // 0x8
        protected static System.Single[] DataL;        // 0x10
        protected static System.Single[] DataR;        // 0x18
        protected static CriWare.CriAtomExOutputAnalyzer.PcmCaptureCallback UserPcmCaptureCallback;        // 0x20

        // Methods
        private System.IntPtr get_nativeHandle() { }
        private System.Void .ctor(CriWare.CriAtomExOutputAnalyzer.Config config) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean AttachExPlayer(CriWare.CriAtomExPlayer player) { }
        private System.Void DetachExPlayer() { }
        private System.Boolean AttachDspBus(System.String busName) { }
        private System.Void DetachDspBus() { }
        private System.Single GetRms(System.Int32 channel) { }
        private System.Void GetSpectrumLevels(System.Single[]& levels) { }
        private System.Void GetPcmData(System.Single[]& data, System.Int32 ch) { }
        private System.Void SetPcmCaptureCallback(CriWare.CriAtomExOutputAnalyzer.PcmCaptureCallback callback) { }
        private System.Void ExecutePcmCaptureCallback() { }
        private System.Void ExecutePcmCaptureCallback(CriWare.CriAtomExOutputAnalyzer.PcmCaptureCallback callback) { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void InitializeWithConfig(CriWare.CriAtomExOutputAnalyzer.Config config) { }
        private System.Void Callback(System.IntPtr ptrL, System.IntPtr ptrR, System.Int32 numChannels, System.Int32 numData) { }
        private System.IntPtr criAtomExOutputAnalyzer_Create(CriWare.CriAtomExOutputAnalyzer.Config& config) { }
        private System.Void criAtomExOutputAnalyzer_Destroy(System.IntPtr analyzer) { }
        private System.Void criAtomExOutputAnalyzer_AttachExPlayer(System.IntPtr analyzer, System.IntPtr player) { }
        private System.Void criAtomExOutputAnalyzer_DetachExPlayer(System.IntPtr analyzer, System.IntPtr player) { }
        private System.Void criAtomExOutputAnalyzer_AttachDspBusByName(System.IntPtr analyzer, System.String busName) { }
        private System.Void criAtomExOutputAnalyzer_DetachDspBusByName(System.IntPtr analyzer, System.String busName) { }
        private System.Single criAtomExOutputAnalyzer_GetRms(System.IntPtr analyzer, System.Int32 channel) { }
        private System.IntPtr criAtomExOutputAnalyzer_GetSpectrumLevels(System.IntPtr analyzer) { }
        private System.IntPtr criAtomExOutputAnalyzer_GetPcmData(System.IntPtr analyzer, System.Int32 ch) { }
        private System.Void criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks(System.IntPtr analyzer, System.IntPtr callback) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000086
    public struct CriAtomExPlayback
    {
        // Fields
        private System.UInt32 <id>k__BackingField;        // 0x10
        public static System.UInt32 invalidId;        // 0x0

        // Methods
        private System.Void .ctor(System.UInt32 id) { }
        private System.Void Stop(System.Boolean ignoresReleaseTime) { }
        private System.Void Pause() { }
        private System.Void Resume(CriWare.CriAtomEx.ResumeMode mode) { }
        private System.Boolean IsPaused() { }
        private System.Boolean GetFormatInfo(CriWare.CriAtomEx.FormatInfo& info) { }
        private CriWare.CriAtomExPlayback.Status GetStatus() { }
        private System.Int64 GetTime() { }
        private System.Int64 GetTimeSyncedWithAudio() { }
        private System.Boolean GetNumPlayedSamples(System.Int64& numSamples, System.Int32& samplingRate) { }
        private System.Int64 GetSequencePosition() { }
        private System.Int32 GetCurrentBlockIndex() { }
        private System.Boolean GetTrackInfo(CriWare.CriAtomExPlayback.TrackInfo& info) { }
        private System.Boolean GetBeatSyncInfo(CriWare.CriAtomExBeatSync.Info& info) { }
        private System.Void SetNextBlockIndex(System.Int32 index) { }
        private System.Boolean SetBeatSyncOffset(System.Int16 timeMs) { }
        private System.UInt32 get_id() { }
        private System.Void set_id(System.UInt32 value) { }
        private CriWare.CriAtomExPlayback.Status get_status() { }
        private System.Int64 get_time() { }
        private System.Int64 get_timeSyncedWithAudio() { }
        private System.Void Stop() { }
        private System.Void StopWithoutReleaseTime() { }
        private System.Void Pause(System.Boolean sw) { }
        private System.Void criAtomExPlayback_Stop(System.UInt32 id) { }
        private System.Void criAtomExPlayback_StopWithoutReleaseTime(System.UInt32 id) { }
        private System.Void criAtomExPlayback_Pause(System.UInt32 id, System.Boolean sw) { }
        private System.Void criAtomExPlayback_Resume(System.UInt32 id, CriWare.CriAtomEx.ResumeMode mode) { }
        private System.Boolean criAtomExPlayback_IsPaused(System.UInt32 id) { }
        private CriWare.CriAtomExPlayback.Status criAtomExPlayback_GetStatus(System.UInt32 id) { }
        private System.Boolean criAtomExPlayback_GetFormatInfo(System.UInt32 id, CriWare.CriAtomEx.FormatInfo& info) { }
        private System.Int64 criAtomExPlayback_GetTime(System.UInt32 id) { }
        private System.Int64 criAtomExPlayback_GetTimeSyncedWithAudio(System.UInt32 id) { }
        private System.Boolean criAtomExPlayback_GetNumPlayedSamples(System.UInt32 id, System.Int64& num_samples, System.Int32& sampling_rate) { }
        private System.Int64 criAtomExPlayback_GetSequencePosition(System.UInt32 id) { }
        private System.Void criAtomExPlayback_SetNextBlockIndex(System.UInt32 id, System.Int32 index) { }
        private System.Int32 criAtomExPlayback_GetCurrentBlockIndex(System.UInt32 id) { }
        private System.Boolean criAtomExPlayback_GetPlaybackTrackInfo(System.UInt32 id, CriWare.CriAtomExPlayback.TrackInfo& info) { }
        private System.Boolean criAtomExPlayback_GetBeatSyncInfo(System.UInt32 id, CriWare.CriAtomExBeatSync.Info& info) { }
        private System.Boolean criAtomExPlayback_SetBeatSyncOffset(System.UInt32 id, System.Int16 timeMs) { }

    }

    // TypeToken: 0x2000089
    public class CriAtomExPlayer : CriDisposable
    {
        // Fields
        private CriWare.CriAtomExBeatSync.CbFunc _onBeatSyncCallback;        // 0x20
        private CriWare.CriAtomExSequencer.EventCallback _onSequenceCallback;        // 0x28
        private System.Boolean hasExistingNativeHandle;        // 0x30
        private System.IntPtr entryPoolHandle;        // 0x38
        private System.Int32 _entryPoolCapacity;        // 0x40
        private System.Int32 max_path;        // 0x44
        private System.IntPtr handle;        // 0x48

        // Methods
        private System.IntPtr get_nativeHandle() { }
        private System.Boolean get_isAvailable() { }
        private System.Void add__onBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value) { }
        private System.Void remove__onBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value) { }
        private System.Void add_OnBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value) { }
        private System.Void remove_OnBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value) { }
        private System.Void add__onSequenceCallback(CriWare.CriAtomExSequencer.EventCallback value) { }
        private System.Void remove__onSequenceCallback(CriWare.CriAtomExSequencer.EventCallback value) { }
        private System.Void add_OnSequenceCallback(CriWare.CriAtomExSequencer.EventCallback value) { }
        private System.Void remove_OnSequenceCallback(CriWare.CriAtomExSequencer.EventCallback value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 maxPath, System.Int32 maxPathStrings) { }
        private System.Void .ctor(System.Boolean enableAudioSyncedTimer) { }
        private System.Void .ctor(System.Int32 maxPath, System.Int32 maxPathStrings, System.Boolean enableAudioSyncedTimer) { }
        private System.Void .ctor(System.IntPtr existingNativeHandle) { }
        private System.Void .ctor(System.Int32 maxPath, System.Int32 maxPathStrings, System.Boolean enableAudioSyncedTimer, System.IntPtr existingNativeHandle) { }
        private System.Void Dispose() { }
        private System.Void SetCue(CriWare.CriAtomExAcb acb, System.String name) { }
        private System.Void SetCue(CriWare.CriAtomExAcb acb, System.Int32 id) { }
        private System.Void SetCueIndex(CriWare.CriAtomExAcb acb, System.Int32 index) { }
        private System.Void SetContentId(CriWare.CriFsBinder binder, System.Int32 contentId) { }
        private System.Void SetFile(CriWare.CriFsBinder binder, System.String path) { }
        private System.Void SetData(System.Byte[] buffer, System.Int32 size) { }
        private System.Void SetData(System.IntPtr buffer, System.Int32 size) { }
        private System.Void SetFormat(CriWare.CriAtomEx.Format format) { }
        private System.Void SetNumChannels(System.Int32 numChannels) { }
        private System.Void SetSamplingRate(System.Int32 samplingRate) { }
        private System.Void PrepareEntryPool(System.Int32 capacity, System.Boolean stopOnEmpty) { }
        private System.Int32 GetNumEntries() { }
        private System.Int32 GetNumConsumedEntries() { }
        private System.Int32 get_entryPoolCapacity() { }
        private System.Boolean EntryFile(CriWare.CriFsBinder binder, System.String path, System.Boolean repeat) { }
        private System.Boolean EntryContentId(CriWare.CriFsBinder binder, System.Int32 contentId, System.Boolean repeat) { }
        private System.Boolean EntryData(System.Byte[] buffer, System.Int32 size, System.Boolean repeat) { }
        private System.Boolean EntryData(System.IntPtr buffer, System.Int32 size, System.Boolean repeat) { }
        private System.Boolean EntryCue(CriWare.CriAtomExAcb acb, System.String name, System.Boolean repeat) { }
        private CriWare.CriAtomExPlayback Start() { }
        private CriWare.CriAtomExPlayback Prepare() { }
        private System.Void Stop(System.Boolean ignoresReleaseTime) { }
        private System.Void Pause() { }
        private System.Void Resume(CriWare.CriAtomEx.ResumeMode mode) { }
        private System.Boolean IsPaused() { }
        private System.Void SetVolume(System.Single volume) { }
        private System.Void SetPitch(System.Single pitch) { }
        private System.Void SetPlaybackRatio(System.Single ratio) { }
        private System.Void SetPan3dAngle(System.Single angle) { }
        private System.Void SetPan3dInteriorDistance(System.Single distance) { }
        private System.Void SetPan3dVolume(System.Single volume) { }
        private System.Void SetPanType(CriWare.CriAtomEx.PanType panType) { }
        private System.Void SetSendLevel(System.Int32 channel, CriWare.CriAtomEx.Speaker id, System.Single level) { }
        private System.Void SetBiquadFilterParameters(CriWare.CriAtomEx.BiquadFilterType type, System.Single frequency, System.Single gain, System.Single q) { }
        private System.Void SetBandpassFilterParameters(System.Single cofLow, System.Single cofHigh) { }
        private System.Void SetBusSendLevel(System.String busName, System.Single level) { }
        private System.Boolean GetBusSendLevel(System.String busName, System.Single& level) { }
        private System.Void SetBusSendLevel(System.Int32 busId, System.Single level) { }
        private System.Void SetBusSendLevelOffset(System.String busName, System.Single levelOffset) { }
        private System.Boolean GetBusSendLevelOffset(System.String busName, System.Single& level) { }
        private System.Void SetBusSendLevelOffset(System.Int32 busId, System.Single levelOffset) { }
        private System.Void AttachAisac(System.String globalAisacName) { }
        private System.Void DetachAisac(System.String globalAisacName) { }
        private System.Void SetAisacControl(System.String controlName, System.Single value) { }
        private System.Void SetAisac(System.String controlName, System.Single value) { }
        private System.Void SetAisacControl(System.UInt32 controlId, System.Single value) { }
        private System.Void SetAisac(System.UInt32 controlId, System.Single value) { }
        private System.Boolean GetAttachedAisacInfo(System.Int32 aisacAttachedIndex, CriWare.CriAtomEx.AisacInfo& aisacInfo) { }
        private System.Void Set3dSource(CriWare.CriAtomEx3dSource source) { }
        private System.Void Set3dListener(CriWare.CriAtomEx3dListener listener) { }
        private System.Void SetStartTime(System.Int64 startTimeMs) { }
        private System.Void SetFirstBlockIndex(System.Int32 index) { }
        private System.Void SetSelectorLabel(System.String selector, System.String label) { }
        private System.Void UnsetSelectorLabel(System.String selector) { }
        private System.Void ClearSelectorLabels() { }
        private System.Void SetCategory(System.Int32 categoryId) { }
        private System.Void SetCategory(System.String categoryName) { }
        private System.Void UnsetCategory() { }
        private System.Void SetCuePriority(System.Int32 priority) { }
        private System.Void SetVoicePriority(System.Int32 priority) { }
        private System.Void SetVoiceControlMethod(CriWare.CriAtomEx.VoiceControlMethod method) { }
        private System.Void SetPreDelayTime(System.Single time) { }
        private System.Void SetEnvelopeAttackTime(System.Single time) { }
        private System.Void SetEnvelopeHoldTime(System.Single time) { }
        private System.Void SetEnvelopeDecayTime(System.Single time) { }
        private System.Void SetEnvelopeReleaseTime(System.Single time) { }
        private System.Void SetEnvelopeSustainLevel(System.Single level) { }
        private System.Void AttachFader() { }
        private System.Void DetachFader() { }
        private System.Void SetFadeOutTime(System.Int32 ms) { }
        private System.Void SetFadeInTime(System.Int32 ms) { }
        private System.Void SetFadeInStartOffset(System.Int32 ms) { }
        private System.Void SetFadeOutEndDelay(System.Int32 ms) { }
        private System.Boolean IsFading() { }
        private System.Void ResetFaderParameters() { }
        private System.Void SetGroupNumber(System.Int32 group_no) { }
        private System.Void Update(CriWare.CriAtomExPlayback playback) { }
        private System.Void UpdateAll() { }
        private System.Void ResetParameters() { }
        private System.Int64 GetTime() { }
        private CriWare.CriAtomExPlayer.Status GetStatus() { }
        private System.Single GetParameterFloat32(CriWare.CriAtomEx.Parameter id) { }
        private System.UInt32 GetParameterUint32(CriWare.CriAtomEx.Parameter id) { }
        private System.Int32 GetParameterSint32(CriWare.CriAtomEx.Parameter id) { }
        private System.Void SetSoundRendererType(CriWare.CriAtomEx.SoundRendererType type) { }
        private System.Void SetRandomSeed(System.UInt32 seed) { }
        private System.Void Loop(System.Boolean sw) { }
        private System.Void SetAsrRackId(System.Int32 asr_rack_id) { }
        private System.Void SetVoicePoolIdentifier(System.UInt32 identifier) { }
        private System.Void SetDspTimeStretchRatio(System.Single ratio) { }
        private System.Void SetDspPitchShifterPitch(System.Single pitch) { }
        private System.Void SetDspParameter(System.Int32 id, System.Single value) { }
        private System.Void SetSequencePrepareTime(System.UInt32 ms) { }
        private System.Void AttachTween(CriWare.CriAtomExTween tween) { }
        private System.Void DetachTween(CriWare.CriAtomExTween tween) { }
        private System.Void DetachTweenAll() { }
        private System.Void Stop() { }
        private System.Void StopWithoutReleaseTime() { }
        private System.Void Pause(System.Boolean sw) { }
        private System.Void Finalize() { }
        private System.Void OnBeatSyncCallbackChainInternal(CriWare.CriAtomExBeatSync.Info& info) { }
        private System.Void OnSequenceCallbackChainInternal(CriWare.CriAtomExSequencer.CriAtomExSequenceEventInfo& info) { }
        private System.IntPtr criAtomExPlayer_Create(CriWare.CriAtomExPlayer.Config& config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomExPlayer_Destroy(System.IntPtr player) { }
        private System.Void criAtomExPlayer_SetCueId(System.IntPtr player, System.IntPtr acb_hn, System.Int32 id) { }
        private System.Void criAtomExPlayer_SetCueName(System.IntPtr player, System.IntPtr acb_hn, System.String cue_name) { }
        private System.Void criAtomExPlayer_SetCueIndex(System.IntPtr player, System.IntPtr acb_hn, System.Int32 index) { }
        private System.Void criAtomExPlayer_SetFile(System.IntPtr player, System.IntPtr binder, System.String path) { }
        private System.Void criAtomExPlayer_SetData(System.IntPtr player, System.Byte[] buffer, System.Int32 size) { }
        private System.Void criAtomExPlayer_SetData(System.IntPtr player, System.IntPtr buffer, System.Int32 size) { }
        private System.Void criAtomExPlayer_SetContentId(System.IntPtr player, System.IntPtr binder, System.Int32 id) { }
        private System.Void criAtomExPlayer_SetVoicePoolIdentifier(System.IntPtr player, System.UInt32 identifier) { }
        private System.UInt32 criAtomExPlayer_Start(System.IntPtr player) { }
        private System.UInt32 criAtomExPlayer_Prepare(System.IntPtr player) { }
        private System.Void criAtomExPlayer_Stop(System.IntPtr player) { }
        private System.Void criAtomExPlayer_StopWithoutReleaseTime(System.IntPtr player) { }
        private System.Void criAtomExPlayer_Pause(System.IntPtr player, System.Boolean sw) { }
        private System.Void criAtomExPlayer_Resume(System.IntPtr player, CriWare.CriAtomEx.ResumeMode mode) { }
        private System.Boolean criAtomExPlayer_IsPaused(System.IntPtr player) { }
        private CriWare.CriAtomExPlayer.Status criAtomExPlayer_GetStatus(System.IntPtr player) { }
        private System.Int64 criAtomExPlayer_GetTime(System.IntPtr player) { }
        private System.Void criAtomExPlayer_SetFormat(System.IntPtr player, CriWare.CriAtomEx.Format format) { }
        private System.Void criAtomExPlayer_SetNumChannels(System.IntPtr player, System.Int32 num_channels) { }
        private System.Void criAtomExPlayer_SetSamplingRate(System.IntPtr player, System.Int32 sampling_rate) { }
        private System.IntPtr CRIWAREF1DB6C3C(System.IntPtr player, System.Int32 capacity, System.Int32 max_path, System.Boolean stopOnEmpty) { }
        private System.Void CRIWARE348B99F2(System.IntPtr pool) { }
        private System.Int32 CRIWAREB0CA8CB3(System.IntPtr pool) { }
        private System.Int32 CRIWAREF2104D05(System.IntPtr pool) { }
        private System.Void CRIWAREBAFBC575(System.IntPtr pool) { }
        private System.Boolean CRIWARE5277731E(System.IntPtr pool, System.IntPtr binder, System.String path, System.Boolean repeat, System.Int32 max_path) { }
        private System.Boolean CRIWARE78E74FE0(System.IntPtr pool, System.IntPtr binder, System.Int32 id, System.Boolean repeat) { }
        private System.Boolean CRIWARE10CB0D07(System.IntPtr pool, System.Byte[] buffer, System.Int32 size, System.Boolean repeat) { }
        private System.Boolean CRIWARE10CB0D07(System.IntPtr pool, System.IntPtr buffer, System.Int32 size, System.Boolean repeat) { }
        private System.Boolean CRIWARE59CCEB17(System.IntPtr pool, System.IntPtr acbhn, System.String name, System.Boolean repeat) { }
        private System.Void CRIWARE94DBB2A3(System.IntPtr pool) { }
        private System.Void criAtomExPlayer_SetStartTime(System.IntPtr player, System.Int64 start_time_ms) { }
        private System.Void criAtomExPlayer_SetSequencePrepareTime(System.IntPtr player, System.UInt32 seq_prep_time_ms) { }
        private System.Void criAtomExPlayer_LimitLoopCount(System.IntPtr player, System.Int32 count) { }
        private System.Void criAtomExPlayer_Update(System.IntPtr player, System.UInt32 id) { }
        private System.Void criAtomExPlayer_UpdateAll(System.IntPtr player) { }
        private System.Void criAtomExPlayer_ResetParameters(System.IntPtr player) { }
        private System.Single criAtomExPlayer_GetParameterFloat32(System.IntPtr player, CriWare.CriAtomEx.Parameter id) { }
        private System.UInt32 criAtomExPlayer_GetParameterUint32(System.IntPtr player, CriWare.CriAtomEx.Parameter id) { }
        private System.Int32 criAtomExPlayer_GetParameterSint32(System.IntPtr player, CriWare.CriAtomEx.Parameter id) { }
        private System.IntPtr criAtomExPlayer_GetPlayerParameter(System.IntPtr player) { }
        private System.Void criAtomExPlayerParameter_RemoveParameter(System.IntPtr player_parameter, System.UInt16 id) { }
        private System.Void criAtomExPlayer_SetVolume(System.IntPtr player, System.Single volume) { }
        private System.Void criAtomExPlayer_SetPitch(System.IntPtr player, System.Single pitch) { }
        private System.Void criAtomExPlayer_SetPlaybackRatio(System.IntPtr player, System.Single playback_ratio) { }
        private System.Void criAtomExPlayer_SetPan3dAngle(System.IntPtr player, System.Single pan3d_angle) { }
        private System.Void criAtomExPlayer_SetPan3dInteriorDistance(System.IntPtr player, System.Single pan3d_interior_distance) { }
        private System.Void criAtomExPlayer_SetPan3dVolume(System.IntPtr player, System.Single pan3d_volume) { }
        private System.Void criAtomExPlayer_SetPanType(System.IntPtr player, CriWare.CriAtomEx.PanType panType) { }
        private System.Void criAtomExPlayer_SetSendLevel(System.IntPtr player, System.Int32 channel, CriWare.CriAtomEx.Speaker id, System.Single level) { }
        private System.Void criAtomExPlayer_SetBusSendLevel(System.IntPtr player, System.Int32 bus_id, System.Single level) { }
        private System.Void criAtomExPlayer_SetBusSendLevelByName(System.IntPtr player, System.String bus_name, System.Single level) { }
        private System.Boolean criAtomExPlayer_GetBusSendLevelByName(System.IntPtr player, System.String bus_name, System.Single& level) { }
        private System.Void criAtomExPlayer_SetBusSendLevelOffset(System.IntPtr player, System.Int32 bus_id, System.Single level_offset) { }
        private System.Void criAtomExPlayer_SetBusSendLevelOffsetByName(System.IntPtr player, System.String bus_name, System.Single level_offset) { }
        private System.Boolean criAtomExPlayer_GetBusSendLevelOffsetByName(System.IntPtr player, System.String bus_name, System.Single& level_offset) { }
        private System.Void criAtomExPlayer_SetBandpassFilterParameters(System.IntPtr player, System.Single cof_low, System.Single cof_high) { }
        private System.Void criAtomExPlayer_SetBiquadFilterParameters(System.IntPtr player, CriWare.CriAtomEx.BiquadFilterType type, System.Single frequency, System.Single gain, System.Single q) { }
        private System.Void criAtomExPlayer_SetVoicePriority(System.IntPtr player, System.Int32 priority) { }
        private System.Void criAtomExPlayer_SetVoiceControlMethod(System.IntPtr player, CriWare.CriAtomEx.VoiceControlMethod method) { }
        private System.Void criAtomExPlayer_SetAisacControlById(System.IntPtr player, System.UInt16 control_id, System.Single control_value) { }
        private System.Void criAtomExPlayer_SetAisacControlByName(System.IntPtr player, System.String control_name, System.Single control_value) { }
        private System.Void criAtomExPlayer_Set3dSourceHn(System.IntPtr player, System.IntPtr source) { }
        private System.Void criAtomExPlayer_Set3dListenerHn(System.IntPtr player, System.IntPtr listener) { }
        private System.Void criAtomExPlayer_SetCategoryById(System.IntPtr player, System.UInt32 category_id) { }
        private System.Void criAtomExPlayer_SetCategoryByName(System.IntPtr player, System.String category_name) { }
        private System.Void criAtomExPlayer_UnsetCategory(System.IntPtr player) { }
        private System.Void criAtomExPlayer_SetCuePriority(System.IntPtr player, System.Int32 cue_priority) { }
        private System.Void criAtomExPlayer_SetPreDelayTime(System.IntPtr player, System.Single predelay_time_ms) { }
        private System.Void criAtomExPlayer_SetEnvelopeAttackTime(System.IntPtr player, System.Single attack_time_ms) { }
        private System.Void criAtomExPlayer_SetEnvelopeHoldTime(System.IntPtr player, System.Single hold_time_ms) { }
        private System.Void criAtomExPlayer_SetEnvelopeDecayTime(System.IntPtr player, System.Single decay_time_ms) { }
        private System.Void criAtomExPlayer_SetEnvelopeReleaseTime(System.IntPtr player, System.Single release_time_ms) { }
        private System.Void criAtomExPlayer_SetEnvelopeSustainLevel(System.IntPtr player, System.Single susutain_level) { }
        private System.Void criAtomExPlayer_AttachFader(System.IntPtr player, System.IntPtr config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomExPlayer_AttachAisac(System.IntPtr player, System.String globalAisacName) { }
        private System.Void criAtomExPlayer_DetachAisac(System.IntPtr player, System.String globalAisacName) { }
        private System.Void criAtomExPlayer_DetachFader(System.IntPtr player) { }
        private System.Void criAtomExPlayer_SetFadeOutTime(System.IntPtr player, System.Int32 ms) { }
        private System.Void criAtomExPlayer_SetFadeInTime(System.IntPtr player, System.Int32 ms) { }
        private System.Void criAtomExPlayer_SetFadeInStartOffset(System.IntPtr player, System.Int32 ms) { }
        private System.Void criAtomExPlayer_SetFadeOutEndDelay(System.IntPtr player, System.Int32 ms) { }
        private System.Boolean criAtomExPlayer_IsFading(System.IntPtr player) { }
        private System.Void criAtomExPlayer_ResetFaderParameters(System.IntPtr player) { }
        private System.Void criAtomExPlayer_SetGroupNumber(System.IntPtr player, System.Int32 group_no) { }
        private System.Boolean criAtomExPlayer_GetAttachedAisacInfo(System.IntPtr player, System.Int32 aisac_attached_index, System.IntPtr aisac_info) { }
        private System.Void criAtomExPlayer_SetFirstBlockIndex(System.IntPtr player, System.Int32 index) { }
        private System.Void criAtomExPlayer_SetSelectorLabel(System.IntPtr player, System.String selector, System.String label) { }
        private System.Void criAtomExPlayer_UnsetSelectorLabel(System.IntPtr player, System.String selector) { }
        private System.Void criAtomExPlayer_ClearSelectorLabels(System.IntPtr player) { }
        private System.Void criAtomExPlayer_SetSoundRendererType(System.IntPtr player, CriWare.CriAtomEx.SoundRendererType type) { }
        private System.Void criAtomExPlayer_SetRandomSeed(System.IntPtr player, System.UInt32 seed) { }
        private System.Void CRIWAREF466419F(System.IntPtr player, System.Boolean sw) { }
        private System.Void criAtomExPlayer_SetAsrRackId(System.IntPtr player, System.Int32 asr_rack_id) { }
        private System.Void criAtomExPlayer_SetDspParameter(System.IntPtr player, System.Int32 id, System.Single value) { }
        private System.Void criAtomExPlayer_AttachTween(System.IntPtr player, System.IntPtr tween) { }
        private System.Void criAtomExPlayer_DetachTween(System.IntPtr player, System.IntPtr tween) { }
        private System.Void criAtomExPlayer_DetachTweenAll(System.IntPtr player) { }

    }

    // TypeToken: 0x200008E
    public class CriAtomExPlayerOutputAnalyzer : CriAtomExOutputAnalyzer
    {
        // Methods
        private System.Void .ctor(CriWare.CriAtomExPlayerOutputAnalyzer.Type[] types, CriWare.CriAtomExPlayerOutputAnalyzer.Config[] configs) { }

    }

    // TypeToken: 0x2000091
    public class CriAtomExSoundObject : CriDisposable
    {
        // Fields
        private System.IntPtr handle;        // 0x20

        // Methods
        private System.IntPtr get_nativeHandle() { }
        private System.Void .ctor(System.Boolean enableVoiceLimitScope, System.Boolean enableCategoryCueLimitScope) { }
        private System.Void Dispose() { }
        private System.Void AddPlayer(CriWare.CriAtomExPlayer player) { }
        private System.Void DeletePlayer(CriWare.CriAtomExPlayer player) { }
        private System.Void DeleteAllPlayers() { }
        private System.Void Finalize() { }
        private System.IntPtr criAtomExSoundObject_Create(CriWare.CriAtomExSoundObject.Config& config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomExSoundObject_Destroy(System.IntPtr soundObject) { }
        private System.Void criAtomExSoundObject_AddPlayer(System.IntPtr soundObject, System.IntPtr player) { }
        private System.Void criAtomExSoundObject_DeletePlayer(System.IntPtr soundObject, System.IntPtr player) { }
        private System.Void criAtomExSoundObject_DeleteAllPlayers(System.IntPtr soundObject) { }

    }

    // TypeToken: 0x2000093
    public class CriAtomExTween : CriDisposable
    {
        // Fields
        private System.IntPtr handle;        // 0x20

        // Methods
        private System.IntPtr get_nativeHandle() { }
        private System.Void .ctor() { }
        private System.Void .ctor(CriWare.CriAtomEx.Parameter parameterId) { }
        private System.Void .ctor(System.UInt32 aisacId) { }
        private System.Void .ctor(CriWare.CriAtomExTween.ParameterType parameterType, System.UInt32 targetId) { }
        private System.Void Dispose() { }
        private System.Single get_Value() { }
        private System.Boolean get_IsActive() { }
        private System.Void MoveTo(System.UInt16 durationMs, System.Single value) { }
        private System.Void MoveFrom(System.UInt16 durationMs, System.Single value) { }
        private System.Void Stop() { }
        private System.Void Reset() { }
        private System.Void Finalize() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.IntPtr criAtomExTween_Create(CriWare.CriAtomExTween.Config& config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomExTween_Destroy(System.IntPtr tween) { }
        private System.Single criAtomExTween_GetValue(System.IntPtr tween) { }
        private System.Void criAtomExTween_MoveTo(System.IntPtr tween, System.UInt16 time_ms, System.Single value) { }
        private System.Void criAtomExTween_MoveFrom(System.IntPtr tween, System.UInt16 time_ms, System.Single value) { }
        private System.Void criAtomExTween_Stop(System.IntPtr tween) { }
        private System.Void criAtomExTween_Reset(System.IntPtr tween) { }
        private System.Boolean criAtomExTween_IsActive(System.IntPtr tween) { }

    }

    // TypeToken: 0x2000097
    public class CriAtomExVoicePool : CriDisposable
    {
        // Fields
        public static System.Int32 StandardMemoryAsrVoicePoolId;        // 0x0
        public static System.Int32 StandardStreamingAsrVoicePoolId;        // 0x0
        public static System.Int32 StandardMemoryNsrVoicePoolId;        // 0x0
        public static System.Int32 StandardStreamingNsrVoicePoolId;        // 0x0
        protected System.IntPtr _handle;        // 0x20
        protected System.UInt32 _identifier;        // 0x28
        protected System.Int32 _numVoices;        // 0x2C
        protected System.Int32 _maxChannels;        // 0x30
        protected System.Int32 _maxSamplingRate;        // 0x34

        // Methods
        private CriWare.CriAtomExVoicePool.UsedVoicesInfo GetNumUsedVoices(CriWare.CriAtomExVoicePool.VoicePoolId voicePoolId) { }
        private System.IntPtr get_nativeHandle() { }
        private System.UInt32 get_identifier() { }
        private System.Int32 get_numVoices() { }
        private System.Int32 get_maxChannels() { }
        private System.Int32 get_maxSamplingRate() { }
        private System.Void Dispose() { }
        private CriWare.CriAtomExVoicePool.UsedVoicesInfo GetNumUsedVoices() { }
        private System.Void AttachDspTimeStretch() { }
        private System.Void AttachDspPitchShifter(CriWare.CriAtomExVoicePool.PitchShifterMode mode, System.Int32 windosSize, System.Int32 overlapTimes) { }
        private System.Void DetachDsp() { }
        private System.Void Finalize() { }
        private System.Void CRIWARED389B244(System.Int32 voice_pool_id, System.Int32& num_used_voices, System.Int32& num_pool_voices) { }
        private System.Void criAtomExVoicePool_GetNumUsedVoices(System.IntPtr pool, System.Int32& num_used_voices, System.Int32& num_pool_voices) { }
        private System.Void criAtomExVoicePool_Free(System.IntPtr pool) { }
        private System.Void criAtomExVoicePool_AttachDspTimeStretch(System.IntPtr pool, CriWare.CriAtomExVoicePool.ExTimeStretchConfig& config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomExVoicePool_AttachDspPitchShifter(System.IntPtr pool, CriWare.CriAtomExVoicePool.ExPitchShifterConfig& config, System.IntPtr work, System.Int32 work_size) { }
        private System.Void criAtomExVoicePool_DetachDsp(System.IntPtr pool) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A1
    public class CriAtomExStandardVoicePool : CriAtomExVoicePool
    {
        // Methods
        private System.Void .ctor(System.Int32 numVoices, System.Int32 maxChannels, System.Int32 maxSamplingRate, System.Boolean streamingFlag, System.UInt32 identifier) { }
        private System.IntPtr criAtomExVoicePool_AllocateStandardVoicePool(CriWare.CriAtomExVoicePool.VoicePoolConfig& config, System.IntPtr work, System.Int32 work_size) { }

    }

    // TypeToken: 0x20000A2
    public class CriAtomExWaveVoicePool : CriAtomExVoicePool
    {
        // Methods
        private System.Void .ctor(System.Int32 numVoices, System.Int32 maxChannels, System.Int32 maxSamplingRate, System.Boolean streamingFlag, System.UInt32 identifier) { }
        private System.IntPtr criAtomExVoicePool_AllocateWaveVoicePool(CriWare.CriAtomExVoicePool.VoicePoolConfig& config, System.IntPtr work, System.Int32 work_size) { }

    }

    // TypeToken: 0x20000A3
    public class CriAtomExRawPcmVoicePool : CriAtomExVoicePool
    {
        // Methods
        private System.Void .ctor(System.Int32 numVoices, System.Int32 maxChannels, System.Int32 maxSamplingRate, CriWare.CriAtomExRawPcmVoicePool.RawPcmFormat format, System.UInt32 identifier) { }
        private System.IntPtr criAtomExVoicePool_AllocateRawPcmVoicePool(CriWare.CriAtomExRawPcmVoicePool.RawPcmVoicePoolConfig& config, System.IntPtr work, System.Int32 work_size) { }

    }

    // TypeToken: 0x20000A7
    public class CriAudioReadStream
    {
        // Fields
        private CriWare.CriAudioReadStream.InternalDelegate internalDelegate;        // 0x10
        private System.IntPtr <callbackFunction>k__BackingField;        // 0x18
        private System.IntPtr <callbackPointer>k__BackingField;        // 0x20

        // Methods
        private System.IntPtr get_callbackFunction() { }
        private System.Void set_callbackFunction(System.IntPtr value) { }
        private System.IntPtr get_callbackPointer() { }
        private System.Void set_callbackPointer(System.IntPtr value) { }
        private System.Void .ctor(System.IntPtr callbackFunction, System.IntPtr callbackPointer) { }
        private System.Void .ctor(CriWare.CriAudioReadStream.Delegate callback, System.Int32 numChannels, System.Int32 bufferSize) { }

    }

    // TypeToken: 0x20000AB
    public class CriAudioWriteStream
    {
        // Fields
        private CriWare.CriAudioWriteStream.InternalDelegate internalDelegate;        // 0x10
        private System.IntPtr <callbackFunction>k__BackingField;        // 0x18
        private System.IntPtr <callbackPointer>k__BackingField;        // 0x20

        // Methods
        private System.IntPtr get_callbackFunction() { }
        private System.Void set_callbackFunction(System.IntPtr value) { }
        private System.IntPtr get_callbackPointer() { }
        private System.Void set_callbackPointer(System.IntPtr value) { }
        private System.Void .ctor(System.IntPtr callbackFunction, System.IntPtr callbackPointer) { }
        private System.Void .ctor(CriWare.CriAudioWriteStream.Delegate callback, System.Int32 numChannels, System.Int32 bufferSize) { }

    }

    // TypeToken: 0x20000AF
    public class CriFsLoader : CriDisposable
    {
        // Fields
        private System.IntPtr handle;        // 0x20
        private System.Runtime.InteropServices.GCHandle dstGch;        // 0x28
        private System.Runtime.InteropServices.GCHandle srcGch;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Load(CriWare.CriFsBinder binder, System.String path, System.Int64 fileOffset, System.Int64 loadSize, System.Byte[] buffer) { }
        private System.Void LoadById(CriWare.CriFsBinder binder, System.Int32 id, System.Int64 fileOffset, System.Int64 loadSize, System.Byte[] buffer) { }
        private System.Void LoadWithoutDecompression(CriWare.CriFsBinder binder, System.String path, System.Int64 fileOffset, System.Int64 loadSize, System.Byte[] buffer) { }
        private System.Void LoadWithoutDecompressionById(CriWare.CriFsBinder binder, System.Int32 id, System.Int64 fileOffset, System.Int64 loadSize, System.Byte[] buffer) { }
        private System.Void DecompressData(System.Int64 srcSize, System.Byte[] srcBuffer, System.Int64 dstSize, System.Byte[] dstBuffer) { }
        private System.Void Stop() { }
        private CriWare.CriFsLoader.Status GetStatus() { }
        private System.Void SetReadUnitSize(System.Int32 unit_size) { }
        private System.Void Finalize() { }
        private System.Int32 criFsLoader_Create(System.IntPtr& loader) { }
        private System.Int32 criFsLoader_Destroy(System.IntPtr loader) { }
        private System.Int32 criFsLoader_Load(System.IntPtr loader, System.IntPtr binder, System.String path, System.Int64 offset, System.Int64 load_size, System.IntPtr buffer, System.Int64 buffer_size) { }
        private System.Int32 criFsLoader_LoadById(System.IntPtr loader, System.IntPtr binder, System.Int32 id, System.Int64 offset, System.Int64 load_size, System.IntPtr buffer, System.Int64 buffer_size) { }
        private System.Int32 criFsLoader_Stop(System.IntPtr loader) { }
        private System.Int32 criFsLoader_GetStatus(System.IntPtr loader, CriWare.CriFsLoader.Status& status) { }
        private System.Int32 criFsLoader_SetReadUnitSize(System.IntPtr loader, System.Int64 unit_size) { }
        private System.Int32 criFsLoader_LoadWithoutDecompression(System.IntPtr loader, System.IntPtr binder, System.String path, System.Int64 offset, System.Int64 load_size, System.IntPtr buffer, System.Int64 buffer_size) { }
        private System.Int32 criFsLoader_LoadWithoutDecompressionById(System.IntPtr loader, System.IntPtr binder, System.Int32 id, System.Int64 offset, System.Int64 load_size, System.IntPtr buffer, System.Int64 buffer_size) { }
        private System.Int32 criFsLoader_DecompressData(System.IntPtr loader, System.IntPtr src, System.Int64 src_size, System.IntPtr dst, System.Int64 dst_size) { }

    }

    // TypeToken: 0x20000B1
    public class CriFsInstaller : CriDisposable
    {
        // Fields
        private System.Byte[] installBuffer;        // 0x20
        private System.Runtime.InteropServices.GCHandle installBufferGch;        // 0x28
        private System.IntPtr handle;        // 0x30

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Copy(CriWare.CriFsBinder binder, System.String srcPath, System.String dstPath, System.Int32 installBufferSize) { }
        private System.Void Stop() { }
        private CriWare.CriFsInstaller.Status GetStatus() { }
        private System.Single GetProgress() { }
        private System.Void ExecuteMain() { }
        private System.Void Finalize() { }
        private System.Int32 criFsInstaller_ExecuteMain() { }
        private System.Int32 criFsInstaller_Create(System.IntPtr& installer, CriWare.CriFsInstaller.CopyPolicy option) { }
        private System.Int32 criFsInstaller_Destroy(System.IntPtr installer) { }
        private System.Int32 criFsInstaller_Copy(System.IntPtr installer, System.IntPtr binder, System.String src_path, System.String dst_path, System.IntPtr buffer, System.Int64 buffer_size) { }
        private System.Int32 criFsInstaller_Stop(System.IntPtr installer) { }
        private System.Int32 criFsInstaller_GetStatus(System.IntPtr installer, CriWare.CriFsInstaller.Status& status) { }
        private System.Int32 criFsInstaller_GetProgress(System.IntPtr installer, System.Single& progress) { }

    }

    // TypeToken: 0x20000B4
    public class CriFsBinder : CriDisposable
    {
        // Fields
        private System.IntPtr handle;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.UInt32 BindCpk(CriWare.CriFsBinder srcBinder, System.String path) { }
        private System.UInt32 BindDirectory(CriWare.CriFsBinder srcBinder, System.String path) { }
        private System.UInt32 BindFile(CriWare.CriFsBinder srcBinder, System.String path) { }
        private System.UInt32 BindFileSection(CriWare.CriFsBinder srcBinder, System.String path, System.UInt64 offset, System.Int32 size, System.String sectionName) { }
        private System.Void Unbind(System.UInt32 bindId) { }
        private CriWare.CriFsBinder.Status GetStatus(System.UInt32 bindId) { }
        private System.Int64 GetFileSize(System.String path) { }
        private System.Int64 GetFileSize(System.Int32 id) { }
        private System.Boolean GetContentsFileInfo(System.String path, CriWare.CriFsBinder.ContentsFileInfo& info) { }
        private System.Boolean GetContentsFileInfo(System.Int32 id, CriWare.CriFsBinder.ContentsFileInfo& info) { }
        private System.Boolean GetContentsFileInfoByIndex(System.UInt32 bindId, System.Int32 index, System.Int32 numFiles, CriWare.CriFsBinder.ContentsFileInfo[]& info) { }
        private System.Int32 GetNumContentsFiles(System.UInt32 bindId) { }
        private System.Void SetPriority(System.UInt32 bindId, System.Int32 priority) { }
        private System.IntPtr get_nativeHandle() { }
        private System.Void Finalize() { }
        private System.UInt32 criFsBinder_Create(System.IntPtr& binder) { }
        private System.UInt32 criFsBinder_Destroy(System.IntPtr binder) { }
        private System.UInt32 criFsBinder_BindCpk(System.IntPtr binder, System.IntPtr srcBinder, System.String path, System.IntPtr work, System.Int32 worksize, System.UInt32& bindId) { }
        private System.UInt32 criFsBinder_BindDirectory(System.IntPtr binder, System.IntPtr srcBinder, System.String path, System.IntPtr work, System.Int32 worksize, System.UInt32& bindId) { }
        private System.UInt32 criFsBinder_BindFile(System.IntPtr binder, System.IntPtr srcBinder, System.String path, System.IntPtr work, System.Int32 worksize, System.UInt32& bindId) { }
        private System.UInt32 criFsBinder_BindFileSection(System.IntPtr binder, System.IntPtr srcBinder, System.String path, System.UInt64 offset, System.Int32 size, System.String sectionName, System.IntPtr work, System.Int32 worksize, System.UInt32& bindId) { }
        private System.Int32 criFsBinder_Unbind(System.UInt32 bindId) { }
        private System.Int32 criFsBinder_GetStatus(System.UInt32 bindId, CriWare.CriFsBinder.Status& status) { }
        private System.Int32 criFsBinder_GetFileSize(System.IntPtr binder, System.String path, System.Int64& size) { }
        private System.Int32 criFsBinder_GetFileSizeById(System.IntPtr binder, System.Int32 id, System.Int64& size) { }
        private System.Int32 criFsBinder_SetPriority(System.UInt32 bindId, System.Int32 priority) { }
        private System.Int32 criFsBinder_GetContentsFileInfo(System.IntPtr binder, System.String path, System.IntPtr info) { }
        private System.Int32 criFsBinder_GetContentsFileInfoById(System.IntPtr binder, System.Int32 id, System.IntPtr info) { }
        private System.Int32 criFsBinder_GetContentsFileInfoByIndex(System.UInt32 id, System.Int32 index, System.IntPtr info, System.Int32 num) { }
        private System.Int32 CRIWAREF02BA103(System.UInt32 id) { }

    }

    // TypeToken: 0x20000B7
    public class CriFsRequest : CriDisposable
    {
        // Fields
        private CriWare.CriFsRequest.DoneDelegate <doneDelegate>k__BackingField;        // 0x20
        private System.Boolean <isDone>k__BackingField;        // 0x28
        private System.String <error>k__BackingField;        // 0x30
        private System.Boolean <isDisposed>k__BackingField;        // 0x38

        // Methods
        private CriWare.CriFsRequest.DoneDelegate get_doneDelegate() { }
        private System.Void set_doneDelegate(CriWare.CriFsRequest.DoneDelegate value) { }
        private System.Boolean get_isDone() { }
        private System.Void set_isDone(System.Boolean value) { }
        private System.String get_error() { }
        private System.Void set_error(System.String value) { }
        private System.Boolean get_isDisposed() { }
        private System.Void set_isDisposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Stop() { }
        private UnityEngine.YieldInstruction WaitForDone(UnityEngine.MonoBehaviour mb) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Update() { }
        private System.Void Done() { }
        private System.Collections.IEnumerator CheckDone() { }
        private System.Void Finalize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BA
    public class CriFsLoadFileRequest : CriFsRequest
    {
        // Fields
        private System.String <path>k__BackingField;        // 0x40
        private System.Byte[] <bytes>k__BackingField;        // 0x48
        private CriWare.CriFsLoadFileRequest.Phase phase;        // 0x50
        private CriWare.CriFsBinder refBinder;        // 0x58
        private CriWare.CriFsBinder newBinder;        // 0x60
        private System.UInt32 bindId;        // 0x68
        private CriWare.CriFsLoader loader;        // 0x70
        private System.Int32 readUnitSize;        // 0x78
        private System.Int64 fileSize;        // 0x80

        // Methods
        private System.String get_path() { }
        private System.Void set_path(System.String value) { }
        private System.Byte[] get_bytes() { }
        private System.Void set_bytes(System.Byte[] value) { }
        private System.Void .ctor(CriWare.CriFsBinder srcBinder, System.String path, CriWare.CriFsRequest.DoneDelegate doneDelegate, System.Int32 readUnitSize) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Stop() { }
        private System.Void Update() { }
        private System.Void UpdateBinder() { }
        private System.Void UpdateLoader() { }
        private System.Void OnError() { }

    }

    // TypeToken: 0x20000BC
    public class CriFsLoadAssetBundleRequest : CriFsRequest
    {
        // Fields
        private System.String <path>k__BackingField;        // 0x40
        private UnityEngine.AssetBundle <assetBundle>k__BackingField;        // 0x48
        private CriWare.CriFsLoadFileRequest loadFileReq;        // 0x50
        private UnityEngine.AssetBundleCreateRequest assetBundleReq;        // 0x58

        // Methods
        private System.String get_path() { }
        private System.Void set_path(System.String value) { }
        private UnityEngine.AssetBundle get_assetBundle() { }
        private System.Void set_assetBundle(UnityEngine.AssetBundle value) { }
        private System.Void .ctor(CriWare.CriFsBinder binder, System.String path, System.Int32 readUnitSize) { }
        private System.Void Update() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x20000BD
    public class CriFsInstallRequest : CriFsRequest
    {
        // Fields
        private System.String <sourcePath>k__BackingField;        // 0x40
        private System.String <destinationPath>k__BackingField;        // 0x48
        private System.Single <progress>k__BackingField;        // 0x50

        // Methods
        private System.String get_sourcePath() { }
        private System.Void set_sourcePath(System.String value) { }
        private System.String get_destinationPath() { }
        private System.Void set_destinationPath(System.String value) { }
        private System.Single get_progress() { }
        private System.Void set_progress(System.Single value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BE
    public class CriFsInstallRequestLegacy : CriFsInstallRequest
    {
        // Fields
        private CriWare.CriFsInstaller installer;        // 0x58

        // Methods
        private System.Void Stop() { }
        private System.Void .ctor(CriWare.CriFsBinder srcBinder, System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDelegate, System.Int32 installBufferSize) { }
        private System.Void Update() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x20000BF
    public class CriFsWebInstallRequest : CriFsInstallRequest
    {
        // Fields
        private CriWare.CriFsWebInstaller installer;        // 0x58
        private System.UInt32 crc32;        // 0x60
        private System.Boolean crc32_set;        // 0x64

        // Methods
        private System.Void Stop() { }
        private System.Boolean GetCRC32(System.UInt32& ret_val) { }
        private System.Void .ctor(System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDelegate) { }
        private System.Void Update() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x20000C0
    public class CriFsBindRequest : CriFsRequest
    {
        // Fields
        private System.String <path>k__BackingField;        // 0x40
        private System.UInt32 <bindId>k__BackingField;        // 0x48

        // Methods
        private System.String get_path() { }
        private System.Void set_path(System.String value) { }
        private System.UInt32 get_bindId() { }
        private System.Void set_bindId(System.UInt32 value) { }
        private System.Void .ctor(CriWare.CriFsBindRequest.BindType type, CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String path) { }
        private System.Void Stop() { }
        private System.Void Update() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x20000C2
    public class CriFsUtility
    {
        // Fields
        public static System.Int32 DefaultReadUnitSize;        // 0x0

        // Methods
        private CriWare.CriFsLoadFileRequest LoadFile(System.String path, System.Int32 readUnitSize) { }
        private CriWare.CriFsLoadFileRequest LoadFile(System.String path, CriWare.CriFsRequest.DoneDelegate doneDelegate, System.Int32 readUnitSize) { }
        private CriWare.CriFsLoadFileRequest LoadFile(CriWare.CriFsBinder binder, System.String path, System.Int32 readUnitSize) { }
        private CriWare.CriFsLoadAssetBundleRequest LoadAssetBundle(System.String path, System.Int32 readUnitSize) { }
        private CriWare.CriFsLoadAssetBundleRequest LoadAssetBundle(CriWare.CriFsBinder binder, System.String path, System.Int32 readUnitSize) { }
        private CriWare.CriFsInstallRequest Install(System.String srcPath, System.String dstPath) { }
        private CriWare.CriFsInstallRequest Install(System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDeleagate) { }
        private CriWare.CriFsInstallRequest Install(CriWare.CriFsBinder srcBinder, System.String srcPath, System.String dstPath) { }
        private CriWare.CriFsInstallRequest Install(CriWare.CriFsBinder srcBinder, System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDeleagate) { }
        private CriWare.CriFsInstallRequest WebInstall(System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDeleagate) { }
        private CriWare.CriFsBindRequest BindCpk(CriWare.CriFsBinder targetBinder, System.String srcPath) { }
        private CriWare.CriFsBindRequest BindCpk(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String srcPath) { }
        private CriWare.CriFsBindRequest BindDirectory(CriWare.CriFsBinder targetBinder, System.String srcPath) { }
        private CriWare.CriFsBindRequest BindDirectory(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String srcPath) { }
        private CriWare.CriFsBindRequest BindFile(CriWare.CriFsBinder targetBinder, System.String srcPath) { }
        private CriWare.CriFsBindRequest BindFile(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String srcPath) { }
        private System.Void SetUserAgentString(System.String userAgentString) { }
        private System.Void SetProxyServer(System.String proxyPath, System.UInt16 proxyPort) { }
        private System.Void SetPathSeparator(System.String filter) { }
        private System.Boolean CRIWARECD0DC04A(System.String userAgentString) { }
        private System.Boolean CRIWARE48E31D64(System.String proxyPath, System.UInt16 proxyPort) { }
        private System.Boolean CRIWARE0C80F382(System.String filter) { }

    }

    // TypeToken: 0x20000C3
    public class CriFsPlugin
    {
        // Fields
        private static System.Int32 initializationCount;        // 0x0
        private static System.Boolean isConfigured;        // 0x4
        public static System.Int32 defaultInstallBufferSize;        // 0x8
        public static System.Int32 installBufferSize;        // 0xC

        // Methods
        private System.Boolean get_isInitialized() { }
        private System.Void SetConfigParameters(System.Int32 num_loaders, System.Int32 num_binders, System.Int32 num_installers, System.Int32 argInstallBufferSize, System.Int32 max_path, System.Boolean minimize_file_descriptor_usage, System.Boolean enable_crc_check) { }
        private System.Void SetReadDeviceEnabled(System.Int32 deviceId, System.Boolean enabled) { }
        private System.Void SetConfigAdditionalParameters_ANDROID(System.Int32 device_read_bps) { }
        private System.Void SetMemoryFileSystemThreadPriorityExperimentalAndroid(System.Int32 prio) { }
        private System.Void SetDataDecompressionThreadPriorityExperimentalAndroid(System.Int32 prio) { }
        private System.Void InitializeLibrary() { }
        private System.Boolean IsLibraryInitialized() { }
        private System.Void FinalizeLibrary() { }
        private System.Void CRIWARE8451156E(System.Int32 num_loaders, System.Int32 num_binders, System.Int32 num_installers, System.Int32 max_path, System.Boolean minimize_file_descriptor_usage, System.Boolean enable_crc_check) { }
        private System.Void CRIWARE601ABE43() { }
        private System.Boolean CRIWARE1012AF20() { }
        private System.Void CRIWARE74A6103A() { }
        private System.UInt32 CRIWARE785081A5() { }
        private System.UInt32 criFsLoader_GetRetryCount() { }
        private System.Int32 criFs_GetNumBinds(System.Int32& cur, System.Int32& max, System.Int32& limit) { }
        private System.Int32 criFs_GetNumUsedLoaders(System.Int32& cur, System.Int32& max, System.Int32& limit) { }
        private System.Int32 criFs_GetNumUsedInstallers(System.Int32& cur, System.Int32& max, System.Int32& limit) { }
        private System.Int32 criFs_SetReadDeviceEnabled(System.Int32 device_id, System.Boolean enabled) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C4
    public class CriFsServer : CriMonoBehaviour
    {
        // Fields
        private static CriWare.CriFsServer _instance;        // 0x0
        private System.Collections.Generic.List<CriWare.CriFsRequest> requestList;        // 0x28
        private System.Int32 <installBufferSize>k__BackingField;        // 0x30

        // Methods
        private CriWare.CriFsServer get_instance() { }
        private System.Int32 get_installBufferSize() { }
        private System.Void set_installBufferSize(System.Int32 value) { }
        private System.Void CreateInstance() { }
        private System.Void DestroyInstance() { }
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private System.Void AddRequest(CriWare.CriFsRequest request) { }
        private CriWare.CriFsLoadFileRequest LoadFile(CriWare.CriFsBinder binder, System.String path, CriWare.CriFsRequest.DoneDelegate doneDelegate, System.Int32 readUnitSize) { }
        private CriWare.CriFsLoadAssetBundleRequest LoadAssetBundle(CriWare.CriFsBinder binder, System.String path, System.Int32 readUnitSize) { }
        private CriWare.CriFsInstallRequest Install(CriWare.CriFsBinder srcBinder, System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDelegate) { }
        private CriWare.CriFsInstallRequest WebInstall(System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDelegate) { }
        private CriWare.CriFsBindRequest BindCpk(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String path) { }
        private CriWare.CriFsBindRequest BindDirectory(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String path) { }
        private CriWare.CriFsBindRequest BindFile(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String path) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C5
    public class CriFsWebInstaller : CriDisposable
    {
        // Fields
        private static System.Boolean <isInitialized>k__BackingField;        // 0x0
        private static System.Boolean <isCrcEnabled>k__BackingField;        // 0x1
        public static System.Int32 InvalidHttpStatusCode;        // 0x0
        public static System.Int64 InvalidContentsSize;        // 0x0
        private System.IntPtr handle;        // 0x20

        // Methods
        private System.Boolean get_isInitialized() { }
        private System.Void set_isInitialized(System.Boolean value) { }
        private System.Boolean get_isCrcEnabled() { }
        private System.Void set_isCrcEnabled(System.Boolean value) { }
        private CriWare.CriFsWebInstaller.ModuleConfig get_defaultModuleConfig() { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Copy(System.String url, System.String dstPath) { }
        private System.Void Stop() { }
        private CriWare.CriFsWebInstaller.StatusInfo GetStatusInfo() { }
        private System.Boolean GetCRC32(System.UInt32& ret_val) { }
        private System.Void InitializeModule(CriWare.CriFsWebInstaller.ModuleConfig config) { }
        private System.Type GetCriFsWebInstallerCurlExpansionClass() { }
        private System.Void FinalizeModule() { }
        private System.Void ExecuteMain() { }
        private System.Boolean SetRequestHeader(System.String field, System.String value) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Int32 criFsWebInstaller_Initialize(CriWare.CriFsWebInstaller.ModuleConfig& config) { }
        private System.Int32 criFsWebInstaller_Finalize() { }
        private System.Int32 criFsWebInstaller_ExecuteMain() { }
        private System.Int32 criFsWebInstaller_Create(System.IntPtr& installer) { }
        private System.Int32 criFsWebInstaller_Destroy(System.IntPtr installer) { }
        private System.Int32 criFsWebInstaller_Copy(System.IntPtr installer, System.String url, System.String dstPath) { }
        private System.Int32 criFsWebInstaller_Stop(System.IntPtr installer) { }
        private System.Int32 criFsWebInstaller_GetStatusInfo(System.IntPtr installer, CriWare.CriFsWebInstaller.StatusInfo& status) { }
        private System.Int32 criFsWebInstaller_GetCRC32(System.IntPtr installer, System.UInt32& crc32) { }
        private System.Int32 criFsWebInstaller_SetRequestHeader(System.String field, System.String value) { }

    }

    // TypeToken: 0x20000CB
    public class CriManaPlugin
    {
        // Fields
        private static System.Int32 initializationCount;        // 0x0
        private static System.Boolean isConfigured;        // 0x4
        private static System.Boolean enabledMultithreadedRendering;        // 0x5
        public static System.Int32 renderingEventOffset;        // 0x8

        // Methods
        private System.Boolean get_isInitialized() { }
        private System.Boolean get_isMultithreadedRenderingEnabled() { }
        private System.Void SetConfigParameters(System.Boolean graphicsMultiThreaded, System.Int32 num_decoders, System.Int32 max_num_of_entries) { }
        private System.Void SetupVp9() { }
        private System.Void SetConfigAdditonalParameters_VITA(System.Boolean use_h264_playback, System.Int32 width, System.Int32 height) { }
        private System.Void SetConfigAdditonalParameters_PC(System.Boolean use_h264_playback) { }
        private System.Void SetConfigAdditonalParameters_ANDROID(System.Boolean enable_buffer_output_for_h264, System.Boolean enable_buffer_output_for_vp9) { }
        private System.Void SetConfigAdditonalParameters_WEBGL(System.String webworkerPath, System.UInt32 heapSize) { }
        private System.Void InitializeLibrary() { }
        private System.Boolean IsLibraryInitialized() { }
        private System.Void FinalizeLibrary() { }
        private System.Boolean IsCodecSupported(CriWare.CriMana.CodecType codecType) { }
        private System.Type GetVp9ExpansionClass() { }
        private System.Boolean IsVp9CodecSupported() { }
        private System.Boolean IsH264CodecSupported() { }
        private System.Void SetDecodeThreadPriorityAndroidExperimental(System.Int32 prio) { }
        private System.Boolean ShouldSampleRed(UnityEngine.Rendering.GraphicsDeviceType type, System.IntPtr tex_ptr) { }
        private System.Void Lock() { }
        private System.Void Unlock() { }
        private System.UInt32 GetPrimeBufferAlignmentSize() { }
        private System.Void CRIWARECFA78B41(System.Int32 graphics_api, System.Boolean graphics_multi_threaded, System.Int32 num_decoders, System.Int32 num_of_max_entries) { }
        private System.Void CRIWARE7BFC56AA() { }
        private System.Boolean CRIWARE611B78A5() { }
        private System.Void CRIWARED672C36F() { }
        private System.Void CRIWARE9F182D39(System.Boolean flag) { }
        private System.Void CRIWARE06C87176() { }
        private System.Void CRIWARE46E1A37B() { }
        private System.UInt32 criManaUnity_GetPrimeBufferAlignmentSize() { }
        private System.Void criMana_UseStreamerManager(System.Boolean flag) { }
        private System.Boolean criMana_IsStreamerManagerUsed() { }
        private System.UInt32 CRIWARE257CA763() { }
        private System.Void CRIWARE62B7B053(System.Boolean enable) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000CC
    public class CriManaAmbisonicSource : CriMonoBehaviour
    {
        // Fields
        private CriWare.CriAtomEx3dSource atomEx3DsourceForAmbisonics;        // 0x28
        private UnityEngine.Vector3 ambisonicSourceOrientationFront;        // 0x30
        private UnityEngine.Vector3 ambisonicSourceOrientationTop;        // 0x3C
        private UnityEngine.Vector3 lastEulerOfAmbisonicSource;        // 0x48

        // Methods
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private System.Void OnEnable() { }
        private System.Void ForceUpdateAmbisonicSourceOrientation() { }
        private System.Void UpdateAmbisonicSourceOrientation() { }
        private System.Void RoatateAmbisonicSourceOrientationByTransformOfChild(UnityEngine.Vector3& input_euler) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CD
    public class CriManaMovieController : CriManaMovieMaterial
    {
        // Fields
        public UnityEngine.Renderer target;        // 0x98
        public System.Boolean useOriginalMaterial;        // 0xA0
        private UnityEngine.Material originalMaterial;        // 0xA8

        // Methods
        private System.Void CriInternalUpdate() { }
        private System.Boolean RenderTargetManualSetup() { }
        private System.Void RenderTargetManualFinalize() { }
        private System.Void OnMaterialAvailableChanged() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CE
    public class CriManaMovieControllerForUI : CriManaMovieMaterial
    {
        // Fields
        public UnityEngine.UI.Graphic target;        // 0x98
        public System.Boolean useOriginalMaterial;        // 0xA0
        private UnityEngine.Material originalMaterial;        // 0xA8

        // Methods
        private System.Void Awake() { }
        private System.Void CriInternalUpdate() { }
        private System.Boolean RenderTargetManualSetup() { }
        private System.Void RenderTargetManualFinalize() { }
        private System.Void OnMaterialAvailableChanged() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF
    public class CriManaMovieMaterial : CriManaMovieMaterialBase
    {
        // Fields
        private System.String _moviePath;        // 0x80
        private System.Boolean _loop;        // 0x88
        private System.Boolean _additiveMode;        // 0x89
        private System.Boolean _useMaterialBlendMode;        // 0x8A
        private System.Boolean _advancedAudio;        // 0x8B
        private System.Boolean _ambisonics;        // 0x8C
        private System.Boolean _applyTargetAlpha;        // 0x8D
        private System.Boolean _uiRenderMode;        // 0x8E
        private UnityEngine.GameObject ambisonicSource;        // 0x90

        // Methods
        private System.String get_moviePath() { }
        private System.Void set_moviePath(System.String value) { }
        private System.Boolean get_loop() { }
        private System.Void set_loop(System.Boolean value) { }
        private System.Boolean get_advancedAudio() { }
        private System.Void set_advancedAudio(System.Boolean value) { }
        private System.Boolean get_ambisonics() { }
        private System.Void set_ambisonics(System.Boolean value) { }
        private System.Boolean get_additiveMode() { }
        private System.Void set_additiveMode(System.Boolean value) { }
        private System.Boolean get_useMaterialBlendMode() { }
        private System.Void set_useMaterialBlendMode(System.Boolean value) { }
        private System.Boolean get_applyTargetAlpha() { }
        private System.Void set_applyTargetAlpha(System.Boolean value) { }
        private System.Boolean get_uiRenderMode() { }
        private System.Void set_uiRenderMode(System.Boolean value) { }
        private System.UInt32 get_FilePathLength() { }
        private System.Boolean get_initializeWithAdvancedAudio() { }
        private System.Boolean get_initializeWithAmbisonics() { }
        private System.Void SetDataToPlayer() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D0
    public class CriManaMovieMaterialBase : CriMonoBehaviour
    {
        // Fields
        public System.Boolean playOnStart;        // 0x28
        public System.Boolean restartOnEnable;        // 0x29
        private System.Boolean <isMaterialAvailable>k__BackingField;        // 0x2A
        private CriWare.CriMana.Player <player>k__BackingField;        // 0x30
        public CriWare.CriManaMovieMaterialBase.RenderMode renderMode;        // 0x38
        public CriWare.CriManaMovieMaterialBase.OnApplicationPauseCallback onApplicationPauseCallback;        // 0x40
        private CriWare.CriMana.Player.TimerType _timerType;        // 0x48
        private UnityEngine.Material _material;        // 0x50
        private CriWare.CriManaMovieMaterialBase.MaxFrameDrop _maxFrameDrop;        // 0x58
        private System.Boolean materialOwn;        // 0x5C
        protected System.Boolean isMonoBehaviourStartCalled;        // 0x5D
        private System.Boolean wasDisabled;        // 0x5E
        private System.Boolean wasPausedOnDisable;        // 0x5F
        private System.Boolean previousOnApplicationPauseStatus;        // 0x60
        private UnityEngine.WaitForEndOfFrame frameEnd;        // 0x68
        private System.Boolean unpauseOnApplicationUnpause;        // 0x70
        private System.Boolean <HaveRendererOwner>k__BackingField;        // 0x71
        private CriWare.CriManaMoviePlayerHolder playerHolder;        // 0x78

        // Methods
        private CriWare.CriManaMovieMaterialBase.MaxFrameDrop get_maxFrameDrop() { }
        private System.Void set_maxFrameDrop(CriWare.CriManaMovieMaterialBase.MaxFrameDrop value) { }
        private System.Boolean get_initializeWithAdvancedAudio() { }
        private System.Boolean get_initializeWithAmbisonics() { }
        private System.Boolean get_isMaterialAvailable() { }
        private System.Void set_isMaterialAvailable(System.Boolean value) { }
        private CriWare.CriMana.Player get_player() { }
        private System.Void set_player(CriWare.CriMana.Player value) { }
        private UnityEngine.Material get_material() { }
        private System.Void set_material(UnityEngine.Material value) { }
        private CriWare.CriMana.Player.TimerType get_timerType() { }
        private System.Void set_timerType(CriWare.CriMana.Player.TimerType value) { }
        private System.UInt32 get_FilePathLength() { }
        private System.Void SetDataToPlayer() { }
        private System.Boolean get_HaveRendererOwner() { }
        private System.Void set_HaveRendererOwner(System.Boolean value) { }
        private System.Void Play() { }
        private System.Void Stop() { }
        private System.Void Pause(System.Boolean sw) { }
        private System.Void OnMaterialAvailableChanged() { }
        private System.Void OnMaterialUpdated() { }
        private System.Void PlayerManualInitialize() { }
        private System.Void PlayerManualFinalize() { }
        private System.Void AsyncDispose(CriWare.CriMana.Player player) { }
        private System.Void PlayerManualSetup() { }
        private System.Boolean RenderTargetManualSetup() { }
        private System.Void RenderTargetManualFinalize() { }
        private System.Void PlayerManualUpdate() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Collections.IEnumerator RestartPlayerRoutine() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void Start() { }
        private System.Void CriInternalUpdate() { }
        private System.Void RenderMovie() { }
        private System.Void CriInternalLateUpdate() { }
        private System.Void OnWillRenderObject() { }
        private System.Void OnApplicationPause(System.Boolean appPause) { }
        private System.Void ProcessApplicationPause(System.Boolean appPause) { }
        private System.Void CreateMaterial() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D6
    public class CriManaMoviePlayerHolder : CriMonoBehaviour
    {
        // Fields
        private CriWare.CriMana.Player _player;        // 0x28

        // Methods
        private System.Void set_player(CriWare.CriMana.Player value) { }
        private System.Void Awake() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private System.Void Start() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7
    public class Common
    {
        // Fields
        private static System.String scriptVersionString;        // 0x0
        public static System.Boolean supportsCriFsInstaller;        // 0x0
        public static System.Boolean supportsCriFsWebInstaller;        // 0x0
        public static System.String pluginName;        // 0x0
        public static System.Runtime.InteropServices.CallingConvention pluginCallingConvention;        // 0x0
        private static UnityEngine.GameObject _managerObject;        // 0x0

        // Methods
        private System.String get_streamingAssetsPath() { }
        private System.String get_installTargetPath() { }
        private System.String get_installCachePath() { }
        private System.Boolean IsStreamingAssetsPath(System.String path) { }
        private UnityEngine.GameObject get_managerObject() { }
        private System.String GetScriptVersionString() { }
        private System.Int32 GetBinaryVersionNumber() { }
        private System.Int32 GetRequiredBinaryVersionNumber() { }
        private System.Boolean CheckBinaryVersionCompatibility() { }
        private System.UInt32 GetFsMemoryUsage() { }
        private System.UInt32 GetAtomMemoryUsage() { }
        private System.UInt32 GetManaMemoryUsage() { }
        private CriWare.Common.CpuUsage GetAtomCpuUsage() { }
        private System.Int32 CRIWAREC8077C29() { }
        private System.Void criWareUnity_SetRenderingEventOffsetForMana(System.Int32 offset) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D9
    public class CriWareDecrypter
    {
        // Fields
        private static System.UInt64 temporalStorage;        // 0x0

        // Methods
        private System.Boolean Initialize(CriWare.CriWareDecrypterConfig config) { }
        private System.Boolean Initialize(System.String key, System.String authenticationFile, System.Boolean enableAtomDecryption, System.Boolean enableManaDecryption) { }
        private System.UInt64 CallbackFromNative(System.IntPtr ptr1) { }
        private System.Int32 CRIWARE05CA8EB2(System.Boolean enable_atom_decryption, System.Boolean enable_mana_decryption, CriWare.CriWareDecrypter.CallbackFromNativeDelegate func, System.IntPtr obj) { }

    }

    // TypeToken: 0x20000DB
    public class CriWareErrorHandler : CriMonoBehaviour
    {
        // Fields
        public System.Boolean enableDebugPrintOnTerminal;        // 0x28
        public System.Boolean enableForceCrashOnError;        // 0x29
        public System.Boolean dontDestroyOnLoad;        // 0x2A
        private static System.String <errorMessage>k__BackingField;        // 0x0
        public static readonly System.String logPrefix;        // 0x8
        private static CriWare.CriWareErrorHandler.Callback OnCallback;        // 0x10
        public static CriWare.CriWareErrorHandler.Callback callback;        // 0x18
        public System.UInt32 messageBufferCounts;        // 0x2C
        private System.Collections.Concurrent.ConcurrentQueue<System.String> unThreadSafeMessages;        // 0x30
        private static System.Int32 initializationCount;        // 0x20

        // Methods
        private System.String get_errorMessage() { }
        private System.Void set_errorMessage(System.String value) { }
        private System.Void add_OnCallback(CriWare.CriWareErrorHandler.Callback value) { }
        private System.Void remove_OnCallback(CriWare.CriWareErrorHandler.Callback value) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private System.Void OnDestroy() { }
        private System.Void DequeueErrorMessages() { }
        private System.Void HandleMessage(System.String errmsg) { }
        private System.Void OutputDefaultLog(System.String errmsg) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000DD
    public class CriErrorNotifier
    {
        // Fields
        private static CriWare.CriErrorNotifier.Callback _onCallbackThreadUnsafe;        // 0x0
        private static System.Object objectLock;        // 0x8

        // Methods
        private System.Void add__onCallbackThreadUnsafe(CriWare.CriErrorNotifier.Callback value) { }
        private System.Void remove__onCallbackThreadUnsafe(CriWare.CriErrorNotifier.Callback value) { }
        private System.Void add_OnCallbackThreadUnsafe(CriWare.CriErrorNotifier.Callback value) { }
        private System.Void remove_OnCallbackThreadUnsafe(CriWare.CriErrorNotifier.Callback value) { }
        private System.Boolean IsRegistered(CriWare.CriErrorNotifier.Callback target) { }
        private System.Void CallEvent(System.String message) { }
        private System.Void ErrorCallbackFromNative(System.IntPtr errmsgPtr, System.UInt32 p1, System.UInt32 p2, System.IntPtr parray) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E1
    public class CriFsConfig
    {
        // Fields
        public static System.Int32 defaultAndroidDeviceReadBitrate;        // 0x0
        public System.Int32 numberOfLoaders;        // 0x10
        public System.Int32 numberOfBinders;        // 0x14
        public System.Int32 numberOfInstallers;        // 0x18
        public System.Int32 installBufferSize;        // 0x1C
        public System.Int32 maxPath;        // 0x20
        public System.String userAgentString;        // 0x28
        public System.Boolean minimizeFileDescriptorUsage;        // 0x30
        public System.Boolean enableCrcCheck;        // 0x31
        public System.Int32 androidDeviceReadBitrate;        // 0x34

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E2
    public class CriAtomConfig
    {
        // Fields
        public System.String acfFileName;        // 0x10
        public System.Int32 maxVirtualVoices;        // 0x18
        public System.Int32 maxVoiceLimitGroups;        // 0x1C
        public System.Int32 maxCategories;        // 0x20
        public System.Int32 maxAisacs;        // 0x24
        public System.Int32 maxBusSends;        // 0x28
        public System.Int32 maxSequenceEventsPerFrame;        // 0x2C
        public System.Int32 maxBeatSyncCallbacksPerFrame;        // 0x30
        public System.Int32 maxCueLinkCallbacksPerFrame;        // 0x34
        public CriWare.CriAtomConfig.StandardVoicePoolConfig standardVoicePoolConfig;        // 0x38
        public CriWare.CriAtomConfig.HcaMxVoicePoolConfig hcaMxVoicePoolConfig;        // 0x40
        public System.Int32 outputSamplingRate;        // 0x48
        public System.Boolean usesInGamePreview;        // 0x4C
        public CriWare.CriAtomConfig.InGamePreviewSwitchMode inGamePreviewMode;        // 0x50
        public System.Boolean switchInitializeSocket;        // 0x54
        public CriWare.CriAtomConfig.InGamePreviewConfig inGamePreviewConfig;        // 0x58
        public System.Single serverFrequency;        // 0x60
        public System.Int32 asrOutputChannels;        // 0x64
        public System.Boolean useRandomSeedWithTime;        // 0x68
        public System.Int32 categoriesPerPlayback;        // 0x6C
        public System.Int32 maxFaders;        // 0x70
        public System.Int32 maxBuses;        // 0x74
        public System.Int32 maxParameterBlocks;        // 0x78
        public System.Boolean vrMode;        // 0x7C
        public System.Boolean keepPlayingSoundOnPause;        // 0x7D
        public CriWare.CriAtomConfig.EditorPcmOutputConfig editorPcmOutputConfig;        // 0x80
        public System.Int32 pcBufferingTime;        // 0x88
        public CriWare.CriAtomConfig.LinuxOutput linuxOutput;        // 0x8C
        public System.Int32 linuxPulseLatencyUsec;        // 0x90
        public System.Boolean iosEnableSonicSync;        // 0x94
        public System.Int32 iosBufferingTime;        // 0x98
        public System.Boolean iosOverrideIPodMusic;        // 0x9C
        public System.Boolean androidEnableSonicSync;        // 0x9D
        public System.Int32 androidBufferingTime;        // 0xA0
        public System.Int32 androidStartBufferingTime;        // 0xA4
        public CriWare.CriAtomConfig.AndroidLowLatencyStandardVoicePoolConfig androidLowLatencyStandardVoicePoolConfig;        // 0xA8
        public System.Boolean androidUsesAndroidFastMixer;        // 0xB0
        public System.Boolean androidForceToUseAsrForDefaultPlayback;        // 0xB1
        public System.Boolean androidUsesAAudio;        // 0xB2
        public System.Int32 androidStreamType;        // 0xB4
        public CriWare.CriAtomConfig.VitaManaVoicePoolConfig vitaManaVoicePoolConfig;        // 0xB8
        public CriWare.CriAtomConfig.VitaAtrac9VoicePoolConfig vitaAtrac9VoicePoolConfig;        // 0xC0
        public CriWare.CriAtomConfig.Ps4Atrac9VoicePoolConfig ps4Atrac9VoicePoolConfig;        // 0xC8
        public CriWare.CriAtomConfig.Ps5PortConfig ps5PortConfig;        // 0xD0
        public System.Boolean switchEnableSonicSync;        // 0xD8
        public CriWare.CriAtomConfig.SwitchOpusVoicePoolConfig switchOpusVoicePoolConfig;        // 0xE0
        public CriWare.CriAtomConfig.Ps4Audio3dConfig ps4Audio3dConfig;        // 0xE8
        public CriWare.CriAtomConfig.WebGLWebAudioVoicePoolConfig webglWebAudioVoicePoolConfig;        // 0xF0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F2
    public class CriManaConfig
    {
        // Fields
        public System.Int32 numberOfDecoders;        // 0x10
        public System.Int32 numberOfMaxEntries;        // 0x14
        public readonly System.Boolean graphicsMultiThreaded;        // 0x18
        public CriWare.CriManaConfig.PCH264PlaybackConfig pcH264PlaybackConfig;        // 0x20
        public CriWare.CriManaConfig.VitaH264PlaybackConfig vitaH264PlaybackConfig;        // 0x28
        public CriWare.CriManaConfig.WebGLConfig webglConfig;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F6
    public class CriWareDecrypterConfig
    {
        // Fields
        public System.String key;        // 0x10
        public System.String authenticationFile;        // 0x18
        public System.Boolean enableAtomDecryption;        // 0x20
        public System.Boolean enableManaDecryption;        // 0x21

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F7
    public class CriWareInitializer : CriMonoBehaviour
    {
        // Fields
        public System.Boolean initializesFileSystem;        // 0x28
        public CriWare.CriFsConfig fileSystemConfig;        // 0x30
        public System.Boolean initializesAtom;        // 0x38
        public CriWare.CriAtomConfig atomConfig;        // 0x40
        public System.Boolean initializesMana;        // 0x48
        public CriWare.CriManaConfig manaConfig;        // 0x50
        public System.Boolean useDecrypter;        // 0x58
        public CriWare.CriWareDecrypterConfig decrypterConfig;        // 0x60
        public System.Boolean dontInitializeOnAwake;        // 0x68
        public System.Boolean dontDestroyOnLoad;        // 0x69
        private static System.Int32 initializationCount;        // 0x0

        // Methods
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }
        private System.Void Initialize() { }
        private System.Void Shutdown() { }
        private System.Boolean IsInitialized() { }
        private System.Void AddAudioEffectInterface(System.IntPtr effect_interface) { }
        private System.Boolean InitializeFileSystem(CriWare.CriFsConfig config) { }
        private System.Boolean InitializeAtom(CriWare.CriAtomConfig config) { }
        private System.Boolean InitializeMana(CriWare.CriManaConfig config) { }
        private System.Boolean InitializeDecrypter(CriWare.CriWareDecrypterConfig config) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F8
    public class CriAtomExDebug
    {
        // Methods
        private System.Void GetResourcesInfo(CriWare.CriAtomExDebug.ResourcesInfo& resourcesInfo) { }
        private System.Void criAtomExDebug_GetResourcesInfo(CriWare.CriAtomExDebug.ResourcesInfo& resourcesInfo) { }

    }

    // TypeToken: 0x20000FA
    public class CriAtomExAcfDebug
    {
        // Methods
        private System.Int32 GetNumCategories() { }
        private System.Boolean GetCategoryInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcfDebug.CategoryInfo& categoryInfo) { }
        private System.Boolean GetCategoryInfoByName(System.String name, CriWare.CriAtomExAcfDebug.CategoryInfo& categoryInfo) { }
        private System.Boolean GetCategoryInfoById(System.UInt32 id, CriWare.CriAtomExAcfDebug.CategoryInfo& categoryInfo) { }
        private System.Int32 GetNumBuses() { }
        private System.Boolean GetDspBusInformation(System.UInt16 index, CriWare.CriAtomExAcfDebug.DspBusInfo& dspBusInfo) { }
        private System.Int32 GetNumAisacControls() { }
        private System.Boolean GetAisacControlInfo(System.UInt16 index, CriWare.CriAtomExAcfDebug.AisacControlInfo& info) { }
        private System.UInt32 GetAisacControlIdByName(System.String name) { }
        private System.String GetAisacControlNameById(System.UInt32 id) { }
        private System.Int32 GetNumGlobalAisacs() { }
        private System.Boolean GetGlobalAisacInfo(System.UInt16 index, CriWare.CriAtomExAcfDebug.GlobalAisacInfo& info) { }
        private System.Boolean GetGlobalAisacInfoByName(System.String name, CriWare.CriAtomExAcfDebug.GlobalAisacInfo& info) { }
        private System.Int32 GetNumSelectors() { }
        private System.Boolean GetSelectorInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcfDebug.SelectorInfo& info) { }
        private System.Boolean GetSelectorInfoByName(System.String name, CriWare.CriAtomExAcfDebug.SelectorInfo& info) { }
        private System.Boolean GetSelectorLabelInfo(CriWare.CriAtomExAcfDebug.SelectorInfo& selectorInfo, System.UInt16 index, CriWare.CriAtomExAcfDebug.SelectorLabelInfo& labelInfo) { }
        private System.Int32 criAtomExAcf_GetNumCategories() { }
        private System.Int32 criAtomExAcf_GetCategoryInfo(System.UInt16 index, CriWare.CriAtomExAcfDebug.CategoryInfoForMarshaling& categoryInfo) { }
        private System.Int32 criAtomExAcf_GetCategoryInfoByName(System.String name, CriWare.CriAtomExAcfDebug.CategoryInfoForMarshaling& categoryInfo) { }
        private System.Int32 criAtomExAcf_GetCategoryInfoById(System.UInt32 id, CriWare.CriAtomExAcfDebug.CategoryInfoForMarshaling& categoryInfo) { }
        private System.Int32 criAtomExAcf_GetNumBuses() { }
        private System.Int32 criAtomExAcf_GetDspBusInformation(System.UInt16 index, CriWare.CriAtomExAcfDebug.DspBusInfoForMarshaling& dspBusInfo) { }
        private System.Int32 criAtomExAcf_GetNumAisacControls() { }
        private System.Int32 criAtomExAcf_GetAisacControlInfo(System.UInt16 index, CriWare.CriAtomExAcfDebug.AisacControlInfoForMarshaling& info) { }
        private System.UInt32 criAtomExAcf_GetAisacControlIdByName(System.String name) { }
        private System.IntPtr criAtomExAcf_GetAisacControlNameById(System.UInt32 id) { }
        private System.Int32 criAtomExAcf_GetNumGlobalAisacs() { }
        private System.Int32 criAtomExAcf_GetGlobalAisacInfo(System.UInt16 index, CriWare.CriAtomExAcfDebug.GlobalAisacInfoForMarshaling& info) { }
        private System.Int32 criAtomExAcf_GetGlobalAisacInfoByName(System.String name, CriWare.CriAtomExAcfDebug.GlobalAisacInfoForMarshaling& info) { }
        private System.Int32 criAtomExAcf_GetNumSelectors() { }
        private System.Int32 criAtomExAcf_GetSelectorInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcfDebug.SelectorInfoForMarshaling& info) { }
        private System.Int32 criAtomExAcf_GetSelectorInfoByName(System.String name, CriWare.CriAtomExAcfDebug.SelectorInfoForMarshaling& info) { }
        private System.Int32 criAtomExAcf_GetSelectorLabelInfo(CriWare.CriAtomExAcfDebug.SelectorInfoForMarshaling& info, System.UInt16 labelIndex, CriWare.CriAtomExAcfDebug.SelectorLabelInfoForMarshaling& label_info) { }

    }

    // TypeToken: 0x2000108
    public class CriAtomExAcbDebug
    {
        // Methods
        private System.Boolean GetAcbInfo(CriWare.CriAtomExAcb acb, CriWare.CriAtomExAcbDebug.AcbInfo& acbInfo) { }
        private System.Int32 criAtomExAcb_GetAcbInfo(System.IntPtr acbHn, CriWare.CriAtomExAcbDebug.AcbInfoForMarshaling& acbInfo) { }

    }

    // TypeToken: 0x200010B
    public class CriAtomExPlaybackDebug
    {
        // Methods
        private System.Boolean GetParameter(CriWare.CriAtomExPlayback playback, CriWare.CriAtomEx.Parameter parameterId, System.Single& value) { }
        private System.Boolean GetParameter(CriWare.CriAtomExPlayback playback, CriWare.CriAtomEx.Parameter parameterId, System.UInt32& value) { }
        private System.Boolean GetParameter(CriWare.CriAtomExPlayback playback, CriWare.CriAtomEx.Parameter parameterId, System.Int32& value) { }
        private System.Boolean GetAisacControl(CriWare.CriAtomExPlayback playback, System.UInt32 controlId, System.Single& value) { }
        private System.Boolean GetAisacControl(CriWare.CriAtomExPlayback playback, System.String controlName, System.Single& value) { }
        private System.Int32 criAtomExPlayback_GetParameterFloat32(System.UInt32 id, System.Int32 parameterId, System.Single& value) { }
        private System.Int32 criAtomExPlayback_GetParameterUint32(System.UInt32 id, System.Int32 parameterId, System.UInt32& value) { }
        private System.Int32 criAtomExPlayback_GetParameterSint32(System.UInt32 id, System.Int32 parameterId, System.Int32& value) { }
        private System.Int32 criAtomExPlayback_GetAisacControlById(System.UInt32 id, System.UInt32 controlId, System.Single& value) { }
        private System.Int32 criAtomExPlayback_GetAisacControlByName(System.UInt32 id, System.String controlName, System.Single& value) { }

    }

    // TypeToken: 0x200010C
    public class CriDisposable, IDisposable
    {
        // Fields
        public System.Guid guid;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200010D
    public class CriDisposableObjectManager
    {
        // Fields
        private static System.Collections.Generic.List<CriWare.CriDisposableObjectManager.ObjectRef> refList;        // 0x0

        // Methods
        private System.Int32 SearchForDisposable(CriWare.CriDisposable disposable) { }
        private System.Void Register(CriWare.CriDisposable disposable, CriWare.CriDisposableObjectManager.ModuleType type) { }
        private System.Boolean Unregister(CriWare.CriDisposable disposable) { }
        private System.Boolean IsDisposed(CriWare.CriDisposable disposable) { }
        private System.Void CallOnModuleFinalization(CriWare.CriDisposableObjectManager.ModuleType type) { }
        private System.Int32 GetNextWithType(CriWare.CriDisposableObjectManager.ModuleType type) { }
        private System.Void DisposeAll(CriWare.CriDisposableObjectManager.ModuleType type) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000110
    public class CriMonoBehaviour : MonoBehaviour
    {
        // Fields
        private System.Guid <guid>k__BackingField;        // 0x18

        // Methods
        private System.Guid get_guid() { }
        private System.Void set_guid(System.Guid value) { }
        private System.Void .ctor() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void CriInternalUpdate() { }
        private System.Void CriInternalLateUpdate() { }

    }

    // TypeToken: 0x2000111
    public class CriMonoBehaviourManager : MonoBehaviour
    {
        // Fields
        private static CriWare.CriMonoBehaviourManager _instance;        // 0x0
        private static System.Collections.Generic.List<CriWare.CriMonoBehaviour> criMonoBehaviourList;        // 0x8

        // Methods
        private CriWare.CriMonoBehaviourManager get_instance() { }
        private System.Void CreateInstance() { }
        private System.Int32 GetIndex(CriWare.CriMonoBehaviour criMonoBehaviour) { }
        private System.Boolean Register(CriWare.CriMonoBehaviour criMonoBehaviour) { }
        private System.Boolean UnRegister(CriWare.CriMonoBehaviour criMonoBehaviour) { }
        private System.Void Awake() { }
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace CriWare.CriAtomDebugDetail
{

    // TypeToken: 0x2000112
    public class Utility
    {
        // Methods
        private System.String PtrToStringAutoOrNull(System.IntPtr stringPtr) { }
        private System.Void .ctor() { }

    }

}

namespace CriWare.CriMana
{

    // TypeToken: 0x2000125
    public struct CodecType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriMana.CodecType Unknown;        // 0x0
        public static CriWare.CriMana.CodecType SofdecPrime;        // 0x0
        public static CriWare.CriMana.CodecType H264;        // 0x0
        public static CriWare.CriMana.CodecType VP9;        // 0x0

    }

    // TypeToken: 0x2000126
    public struct AlphaType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CriWare.CriMana.AlphaType CompoOpaq;        // 0x0
        public static CriWare.CriMana.AlphaType CompoAlphaFull;        // 0x0
        public static CriWare.CriMana.AlphaType CompoAlpha3Step;        // 0x0
        public static CriWare.CriMana.AlphaType CompoAlpha32Bit;        // 0x0

    }

    // TypeToken: 0x2000127
    public struct AudioInfo
    {
        // Fields
        public System.UInt32 samplingRate;        // 0x10
        public System.UInt32 numChannels;        // 0x14
        public System.UInt32 totalSamples;        // 0x18

    }

    // TypeToken: 0x2000128
    public class MovieInfo
    {
        // Fields
        private System.UInt32 _reserved1;        // 0x10
        public System.UInt32 numAlphaStreams;        // 0x14
        public System.UInt32 width;        // 0x18
        public System.UInt32 height;        // 0x1C
        public System.UInt32 dispWidth;        // 0x20
        public System.UInt32 dispHeight;        // 0x24
        public System.UInt32 framerateN;        // 0x28
        public System.UInt32 framerateD;        // 0x2C
        public System.UInt32 totalFrames;        // 0x30
        public CriWare.CriMana.CodecType codecType;        // 0x34
        public CriWare.CriMana.CodecType alphaCodecType;        // 0x38
        public System.UInt32 numAudioStreams;        // 0x3C
        public CriWare.CriMana.AudioInfo[] audioPrm;        // 0x40
        public System.UInt32 numSubtitleChannels;        // 0x48
        public System.UInt32 maxSubtitleSize;        // 0x4C
        public System.UInt32 maxChunkSize;        // 0x50

        // Methods
        private System.Boolean get_hasAlpha() { }
        private System.Void set_hasAlpha(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000129
    public class FrameInfo
    {
        // Fields
        public System.Int32 frameNo;        // 0x10
        public System.Int32 frameNoPerFile;        // 0x14
        public System.UInt32 width;        // 0x18
        public System.UInt32 height;        // 0x1C
        public System.UInt32 dispWidth;        // 0x20
        public System.UInt32 dispHeight;        // 0x24
        public System.UInt32 numImages;        // 0x28
        public System.UInt32 framerateN;        // 0x2C
        public System.UInt32 framerateD;        // 0x30
        private System.UInt32 _reserved1;        // 0x34
        public System.UInt64 time;        // 0x38
        public System.UInt64 tunit;        // 0x40
        public System.UInt32 cntConcatenatedMovie;        // 0x48
        private CriWare.CriMana.AlphaType alphaType;        // 0x4C
        public System.UInt32 cntSkippedFrames;        // 0x50
        public System.UInt32 totalFramesPerFile;        // 0x54

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012A
    public struct EventPoint
    {
        // Fields
        public System.IntPtr cueName;        // 0x10
        public System.UInt32 cueNameSize;        // 0x18
        public System.UInt64 time;        // 0x20
        public System.UInt64 tunit;        // 0x28
        public System.Int32 type;        // 0x30
        public System.IntPtr paramString;        // 0x38
        public System.UInt32 paramStringSize;        // 0x40
        public System.UInt32 cntCallback;        // 0x44

    }

    // TypeToken: 0x200012B
    public class Settings
    {
        // Methods
        private System.Void SetDecodeSkippingEnabled(System.Boolean enabled) { }

    }

    // TypeToken: 0x200012C
    public class Player : CriDisposable
    {
        // Fields
        private static System.Int32 InvalidPlayerId;        // 0x0
        private static CriWare.CriMana.Player updatingPlayer;        // 0x0
        private System.Int32 playerId;        // 0x20
        private System.Boolean isDisposed;        // 0x24
        private CriWare.CriMana.Player.Status internalrequiredStatus;        // 0x28
        private CriWare.CriMana.Player.Status _nativeStatus;        // 0x2C
        private System.Nullable<CriWare.CriMana.Player.Status> lastNativeStatus;        // 0x30
        private System.Nullable<CriWare.CriMana.Player.Status> lastPlayerStatus;        // 0x38
        private System.Boolean wasStopping;        // 0x40
        private System.Boolean isPreparingForRendering;        // 0x41
        private System.Boolean isNativeStartInvoked;        // 0x42
        private System.Boolean isNativeInitialized;        // 0x43
        private CriWare.CriMana.Detail.RendererResource rendererResource;        // 0x48
        private CriWare.CriMana.MovieInfo _movieInfo;        // 0x50
        private CriWare.CriMana.FrameInfo _frameInfo;        // 0x58
        private System.Boolean isMovieInfoAvailable;        // 0x60
        private System.Boolean isFrameInfoAvailable;        // 0x61
        private CriWare.CriMana.Player.ShaderDispatchCallback _shaderDispatchCallback;        // 0x68
        private System.Boolean enableSubtitle;        // 0x70
        private System.Int32 subtitleBufferSize;        // 0x74
        private System.UInt32 droppedFrameCount;        // 0x78
        private CriWare.CriAtomExPlayer _atomExPlayer;        // 0x80
        private CriWare.CriAtomEx3dSource _atomEx3Dsource;        // 0x88
        private CriWare.CriMana.Player.TimerType _timerType;        // 0x90
        private System.Boolean isStoppingForSeek;        // 0x94
        public CriWare.CriMana.Player.CuePointCallback cuePointCallback;        // 0x98
        public CriWare.CriMana.Player.StatusChangeCallback statusChangeCallback;        // 0xA0
        private CriWare.CriMana.Player.SubtitleChangeCallback OnSubtitleChanged;        // 0xA8
        private System.Boolean <additiveMode>k__BackingField;        // 0xB0
        private System.Boolean <useMaterialBlendMode>k__BackingField;        // 0xB1
        private System.Int32 <maxFrameDrop>k__BackingField;        // 0xB4
        private System.Boolean <applyTargetAlpha>k__BackingField;        // 0xB8
        private System.Boolean <uiRenderMode>k__BackingField;        // 0xB9
        private System.IntPtr <subtitleBuffer>k__BackingField;        // 0xC0
        private System.Int32 <subtitleSize>k__BackingField;        // 0xC8
        private CriWare.CriManaMoviePlayerHolder <playerHolder>k__BackingField;        // 0xD0
        protected System.Collections.Generic.Queue<CriWare.CriMana.Player.Operation> operationQueue;        // 0xD8
        protected System.Nullable<CriWare.CriMana.Player.Operation> cntOperation;        // 0xE0

        // Methods
        private CriWare.CriMana.Player.Status get_requiredStatus() { }
        private System.Void set_requiredStatus(CriWare.CriMana.Player.Status value) { }
        private System.Void add_OnSubtitleChanged(CriWare.CriMana.Player.SubtitleChangeCallback value) { }
        private System.Void remove_OnSubtitleChanged(CriWare.CriMana.Player.SubtitleChangeCallback value) { }
        private System.Boolean get_additiveMode() { }
        private System.Void set_additiveMode(System.Boolean value) { }
        private System.Boolean get_useMaterialBlendMode() { }
        private System.Void set_useMaterialBlendMode(System.Boolean value) { }
        private System.Int32 get_maxFrameDrop() { }
        private System.Void set_maxFrameDrop(System.Int32 value) { }
        private System.Boolean get_applyTargetAlpha() { }
        private System.Void set_applyTargetAlpha(System.Boolean value) { }
        private System.Boolean get_uiRenderMode() { }
        private System.Void set_uiRenderMode(System.Boolean value) { }
        private System.Boolean get_isFrameAvailable() { }
        private CriWare.CriMana.MovieInfo get_movieInfo() { }
        private CriWare.CriMana.FrameInfo get_frameInfo() { }
        private CriWare.CriMana.Player.Status get_status() { }
        private CriWare.CriMana.Player.Status get_nativeStatus() { }
        private System.Int32 get_numberOfEntries() { }
        private System.IntPtr get_subtitleBuffer() { }
        private System.Void set_subtitleBuffer(System.IntPtr value) { }
        private System.Int32 get_subtitleSize() { }
        private System.Void set_subtitleSize(System.Int32 value) { }
        private CriWare.CriAtomExPlayer get_atomExPlayer() { }
        private CriWare.CriAtomEx3dSource get_atomEx3DsourceForAmbisonics() { }
        private CriWare.CriMana.Player.TimerType get_timerType() { }
        private CriWare.CriManaMoviePlayerHolder get_playerHolder() { }
        private System.Void set_playerHolder(CriWare.CriManaMoviePlayerHolder value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean advanced_audio_mode, System.Boolean ambisonics_mode, System.UInt32 max_path_length) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void CreateRendererResource(System.Int32 width, System.Int32 height, System.Boolean alpha) { }
        private System.Void DisposeRendererResource() { }
        private System.Void Prepare() { }
        private System.Void PrepareForRendering() { }
        private System.Void Start() { }
        private System.Void Stop() { }
        private System.Void StopForSeek() { }
        private System.Void Pause(System.Boolean sw) { }
        private System.Boolean IsPaused() { }
        private System.Boolean SetFile(CriWare.CriFsBinder binder, System.String moviePath, CriWare.CriMana.Player.SetMode setMode) { }
        private System.Boolean SetData(System.IntPtr data, System.Int64 dataSize, CriWare.CriMana.Player.SetMode setMode) { }
        private System.Boolean SetData(System.Byte[] data, System.Int64 datasize, CriWare.CriMana.Player.SetMode setMode) { }
        private System.Boolean SetContentId(CriWare.CriFsBinder binder, System.Int32 contentId, CriWare.CriMana.Player.SetMode setMode) { }
        private System.Boolean SetFileRange(System.String filePath, System.UInt64 offset, System.Int64 range, CriWare.CriMana.Player.SetMode setMode) { }
        private System.Void Loop(System.Boolean sw) { }
        private System.Void SetMasterTimerType(CriWare.CriMana.Player.TimerType timerType) { }
        private System.Void SetSeekPosition(System.Int32 frameNumber) { }
        private System.Void SetMovieEventSyncMode(CriWare.CriMana.Player.MovieEventSyncMode mode) { }
        private System.Void SetSpeed(System.Single speed) { }
        private System.Void SetMaxPictureDataSize(System.UInt32 maxDataSize) { }
        private System.Void SetBufferingTime(System.Single sec) { }
        private System.Void SetMinBufferSize(System.Int32 min_buffer_size) { }
        private System.Void SetAudioTrack(System.Int32 track) { }
        private System.Void SetAudioTrack(CriWare.CriMana.Player.AudioTrack track) { }
        private System.Void SetSubAudioTrack(System.Int32 track) { }
        private System.Void SetSubAudioTrack(CriWare.CriMana.Player.AudioTrack track) { }
        private System.Void SetExtraAudioTrack(System.Int32 track) { }
        private System.Void SetExtraAudioTrack(CriWare.CriMana.Player.AudioTrack track) { }
        private System.Void SetVolume(System.Single volume) { }
        private System.Single GetVolume() { }
        private System.Void SetSubAudioVolume(System.Single volume) { }
        private System.Single GetSubAudioVolume() { }
        private System.Void SetExtraAudioVolume(System.Single volume) { }
        private System.Single GetExtraAudioVolume() { }
        private System.Void SetBusSendLevel(System.String bus_name, System.Single level) { }
        private System.Void SetSubAudioBusSendLevel(System.String bus_name, System.Single volume) { }
        private System.Void SetExtraAudioBusSendLevel(System.String bus_name, System.Single volume) { }
        private System.Void SetSubtitleChannel(System.Int32 channel) { }
        private System.Void SetShaderDispatchCallback(CriWare.CriMana.Player.ShaderDispatchCallback shaderDispatchCallback) { }
        private System.Int64 GetTime() { }
        private System.Int32 GetDisplayedFrameNo() { }
        private System.Boolean HasRenderedNewFrame() { }
        private System.Void SetAsrRackId(System.Int32 asrRackId) { }
        private System.Void SetUserTimeCorrectionThreshold(System.UInt32 threshold_msec) { }
        private System.Void SetExtraFramePoolSize(System.UInt32 size) { }
        private System.Void UpdateWithUserTime(System.UInt64 timeCount, System.UInt64 timeUnit) { }
        private System.Void SetManualTimerUnit(System.UInt64 timeUnitN, System.UInt64 timeUnitD) { }
        private System.Void UpdateWithManualTimeAdvanced() { }
        private System.Void Update() { }
        private System.Void OnWillRenderObject(CriWare.CriManaMovieMaterialBase sender) { }
        private System.Boolean UpdateMaterial(UnityEngine.Material material) { }
        private System.Boolean get_isAlive() { }
        private System.Void IssuePluginEvent(CriWare.CriMana.Player.CriManaUnityPlayer_RenderEventAction renderEventAction) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void InternalUpdate() { }
        private System.Collections.IEnumerator IssuePluginUpdatesForFrames(System.Int32 frameCount, UnityEngine.MonoBehaviour playerHolder, System.Boolean destroy, System.Int32 playerId) { }
        private System.Void DisableInfos(System.Boolean keepFrameInfo) { }
        private System.Void PrepareNativePlayer() { }
        private System.Void UpdateNativePlayer() { }
        private System.Void InvokePlayerStatusCheck() { }
        private System.Void AllocateSubtitleBuffer(System.Int32 size) { }
        private System.Void DeallocateSubtitleBuffer() { }
        private System.Void PauseOnApplicationPause(System.Boolean sw) { }
        private System.Void CuePointCallbackFromNative(System.IntPtr ptr1, System.IntPtr ptr2, CriWare.CriMana.EventPoint& eventPoint) { }
        private System.Int32 CRIWAREFD186F02() { }
        private System.Int32 CRIWARE72A5B8BF() { }
        private System.Int32 CRIWARE95A85424(System.Boolean useAtomExPlayer, System.UInt32 maxPathLength) { }
        private System.Void CRIWAREABF659EC(System.Int32 player_id) { }
        private System.Void CRIWAREEDB46019(System.Int32 player_id, System.IntPtr binder, System.String path) { }
        private System.Void CRIWAREB28B5D50(System.Int32 player_id, System.IntPtr binder, System.Int32 content_id) { }
        private System.Void CRIWARE65553651(System.Int32 player_id, System.String path, System.UInt64 offset, System.Int64 range) { }
        private System.Void CRIWARE7C753A2E(System.Int32 player_id, System.IntPtr data, System.Int64 datasize) { }
        private System.Void CRIWARE7C753A2E(System.Int32 player_id, System.Byte[] data, System.Int64 datasize) { }
        private System.Boolean CRIWARE328F2911(System.Int32 player_id, System.IntPtr binder, System.String path, System.Boolean repeat) { }
        private System.Boolean CRIWAREDA0693CD(System.Int32 player_id, System.IntPtr binder, System.Int32 content_id, System.Boolean repeat) { }
        private System.Boolean CRIWARE162DD162(System.Int32 player_id, System.String path, System.UInt64 offset, System.Int64 range, System.Boolean repeat) { }
        private System.Boolean CRIWAREC35C3DC3(System.Int32 player_id, System.IntPtr data, System.Int64 datasize, System.Boolean repeat) { }
        private System.Boolean CRIWAREC35C3DC3(System.Int32 player_id, System.Byte[] data, System.Int64 datasize, System.Boolean repeat) { }
        private System.Void CRIWARE66A63134(System.Int32 player_id) { }
        private System.Int32 CRIWARE88D04318(System.Int32 player_id) { }
        private System.Void CRIWARED9F7168D(System.Int32 player_id, CriWare.CriMana.Player.CuePointCallbackFromNativeDelegate cbfunc) { }
        private System.Void CRIWARE1E785A43(System.Int32 player_id, CriWare.CriMana.MovieInfo movie_info) { }
        private System.Int32 CRIWARE3CE8CE6A(System.Int32 player_id, System.IntPtr subtitle_buffer, System.UInt32& subtitle_size) { }
        private System.Void CRIWARE362A826C(System.Int32 player_id) { }
        private System.Void CRIWARE61523A0C(System.Int32 player_id) { }
        private System.Void CRIWAREBB898C91(System.Int32 player_id) { }
        private System.Void CRIWARE705B8C6D(System.Int32 player_id, System.Int32 seek_frame_no) { }
        private System.Void CRIWAREEB32FC73(System.Int32 player_id, CriWare.CriMana.Player.MovieEventSyncMode mode) { }
        private System.Void CRIWARE18BFCB88(System.Int32 player_id, System.Int32 sw) { }
        private System.Boolean CRIWAREEFA5210A(System.Int32 player_id) { }
        private System.Void CRIWARE4331E077(System.Int32 player_id, System.Int32 sw) { }
        private System.Int64 CRIWARE7779586C(System.Int32 player_id) { }
        private System.Int32 CRIWARE33981CC9(System.Int32 player_id) { }
        private System.IntPtr CRIWARE165B6B70(System.Int32 player_id) { }
        private System.Int32 CRIWARE7500F0DD(System.Int32 player_id) { }
        private System.Void CRIWARED99932F6(System.Int32 player_id, System.Int32 track) { }
        private System.Void CRIWARE1FF2F5BE(System.Int32 player_id, System.Single vol) { }
        private System.Single CRIWARED30C9C6F(System.Int32 player_id) { }
        private System.Void CRIWARE0EA59F65(System.Int32 player_id, System.Int32 track) { }
        private System.Void CRIWARE1EBB12C5(System.Int32 player_id, System.Single vol) { }
        private System.Single CRIWARE966C4BA9(System.Int32 player_id) { }
        private System.Void CRIWARE213452EF(System.Int32 player_id, System.Int32 track) { }
        private System.Void CRIWARE0348BF1B(System.Int32 player_id, System.Single vol) { }
        private System.Single CRIWAREC5A3A88D(System.Int32 player_id) { }
        private System.Void CRIWARE31668293(System.Int32 player_id, System.String bus_name, System.Single level) { }
        private System.Void CRIWAREB2460D7A(System.Int32 player_id, System.String bus_name, System.Single level) { }
        private System.Void CRIWAREF4B0CC4E(System.Int32 player_id, System.String bus_name, System.Single level) { }
        private System.Void CRIWARE2C8FF595(System.Int32 player_id, System.Int32 channel) { }
        private System.Void CRIWAREAB576D15(System.Int32 player_id, System.Single speed) { }
        private System.Void CRIWARE3F9C5D06(System.Int32 player_id, System.UInt32 max_data_size) { }
        private System.Void CRIWARE8A87737B(System.Int32 player_id, System.Single sec) { }
        private System.Void CRIWARE6756AE56(System.Int32 player_id, System.Int32 min_buffer_size) { }
        private System.Void CRIWAREA7F6DE6B(System.Int32 player_id, System.Int32 asr_rack_id) { }
        private System.Void CRIWAREE2DF1163(System.Int32 player_id) { }
        private System.Void CRIWAREBD24DE27(System.Int32 player_id, CriWare.CriMana.Player.TimerType timer_type) { }
        private System.Void CRIWAREC7C5CC77(System.Int32 player_id, System.UInt64 user_count, System.UInt64 user_unit) { }
        private System.Void CRIWAREA59E0F01(System.Int32 player_id, System.UInt64 timer_unit_n, System.UInt64 timer_unit_d) { }
        private System.Void CRIWARE55ECC3E4(System.Int32 player_id) { }
        private System.Void CRIWARECEA2FA98(System.Int32 player_id) { }
        private System.IntPtr CRIWARE27ED314F(System.Int32 player_id, System.Int32 bufferSize) { }
        private System.Boolean CRIWARE725ED4B4(System.Int32 player_id) { }
        private System.Void CRIWARE419ECAF8(System.Int32 player_id) { }
        private System.IntPtr criWareUnity_GetRenderEventFunc() { }
        private System.Void criManaUnityPlayer_SetUserTimeCorrectionThreshold(System.Int32 player_id, System.UInt32 threshold_msec) { }
        private System.Void criManaUnityPlayer_SetExtraFramePoolSize(System.Int32 player_id, System.UInt32 size) { }
        private System.Void ClearAllOperation() { }
        private System.Void ExecuteOperation() { }
        private System.Void EasyPrepare() { }
        private System.Void EasyPrepareForRendering() { }
        private System.Void EasyStart() { }
        private System.Void EasyPause(System.Boolean sw) { }
        private System.Void EasyStop() { }
        private System.Void EasyStopForSeek() { }
        private System.Void EasySetFile(CriWare.CriFsBinder binder, System.String moviePath, CriWare.CriMana.Player.SetMode setMode) { }
        private System.Void EasySetSeekTime(System.Single time) { }
        private System.Void EasyStartAtTime(System.Single time) { }
        private System.Single GetVideoLength() { }

    }

}

namespace CriWare.CriMana.Detail
{

    // TypeToken: 0x200013B
    public class AutoResisterRendererResourceFactories
    {
        // Methods
        private System.Void InvokeAutoRegister() { }

    }

    // TypeToken: 0x200013F
    public class RendererResourceH264Yuv : RendererResourceSofdecPrimeYuv
    {
        // Methods
        private System.Void .ctor(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader) { }

    }

    // TypeToken: 0x2000140
    public class RendererResource, IDisposable
    {
        // Fields
        private System.Boolean disposed;        // 0x10
        protected UnityEngine.Shader shader;        // 0x18
        protected UnityEngine.Material currentMaterial;        // 0x20
        protected System.Boolean hasAlpha;        // 0x28
        protected System.Boolean additive;        // 0x29
        protected System.Boolean applyTargetAlpha;        // 0x2A
        protected System.Boolean ui;        // 0x2B
        private System.Boolean _useMaterialBlendMode;        // 0x2C

        // Methods
        private System.Boolean get_useMaterialBlendMode() { }
        private System.Void set_useMaterialBlendMode(System.Boolean value) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Int32 GetNumberOfFrameBeforeDestroy(System.Int32 playerId) { }
        private System.Void SetupStaticMaterialProperties() { }
        private System.Void GetBlendModes(System.Int32& srcBlendMode, System.Int32& dstBlendMode) { }
        private System.Void SetApplyTargetAlpha(System.Boolean flag) { }
        private System.Void SetUiRenderMode(System.Boolean flag) { }
        private System.Void OnDisposeManaged() { }
        private System.Void OnDisposeUnmanaged() { }
        private System.Boolean IsPrepared() { }
        private System.Boolean ContinuePreparing() { }
        private System.Void AttachToPlayer(System.Int32 playerId) { }
        private System.Boolean UpdateFrame(System.Int32 playerId, CriWare.CriMana.FrameInfo frameInfo, System.Boolean& frameDrop) { }
        private System.Boolean UpdateMaterial(UnityEngine.Material material) { }
        private System.Void UpdateTextures() { }
        private System.Boolean IsSuitable(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader) { }
        private System.Void OnPlayerPause(System.Boolean pauseStatus, System.Boolean triggredFromApplciationPause) { }
        private System.Void OnPlayerStop() { }
        private System.Boolean OnPlayerStopForSeek() { }
        private System.Void OnPlayerStart() { }
        private System.Boolean ShouldSkipDestroyOnStopForSeek() { }
        private System.Boolean HasRenderedNewFrame() { }
        private System.UInt32 NextPowerOfTwo(System.UInt32 x) { }
        private System.Int32 NextPowerOfTwo(System.Int32 x) { }
        private System.Int32 CeilingWith(System.Int32 x, System.Int32 ceilingValue) { }
        private System.Int32 Ceiling16(System.Int32 x) { }
        private System.Int32 Ceiling32(System.Int32 x) { }
        private System.Int32 Ceiling64(System.Int32 x) { }
        private System.Int32 Ceiling256(System.Int32 x) { }
        private System.Void DisposeTextures(UnityEngine.Texture[] textures) { }
        private System.Void SetKeyword(UnityEngine.Material material, System.String keyword, System.Boolean flag) { }
        private System.Boolean CRIWARE98318E69(System.Int32 player_id, System.Int32 num_textures, System.IntPtr[] tex_ptrs, CriWare.CriMana.FrameInfo frame_info, System.Boolean& frame_drop) { }
        private System.Boolean CRIWARED618B369(System.Int32 player_id, System.Int32 num_textures, System.IntPtr[] tex_ptrs) { }
        private System.Boolean CRIWARE5267266A(System.Int32 player_id, System.Int32 num_textures, System.IntPtr[] tex_ptrs) { }
        private System.Boolean CRIWAREE519EFD4(System.Int32 player_id, System.Int32 num_textures, System.IntPtr[] tex_ptrs) { }
        private System.SByte CRIWAREF14F77D8(System.Int32 player_id) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000141
    public class RendererResourceFactory, IDisposable
    {
        // Fields
        private static System.Collections.Generic.SortedList<System.Int32,CriWare.CriMana.Detail.RendererResourceFactory> factoryList;        // 0x0
        private System.Boolean disposed;        // 0x10

        // Methods
        private System.Void RegisterFactory(CriWare.CriMana.Detail.RendererResourceFactory factory, System.Int32 priority) { }
        private System.Void DisposeAllFactories() { }
        private CriWare.CriMana.Detail.RendererResource DispatchAndCreate(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void OnDisposeManaged() { }
        private System.Void OnDisposeUnmanaged() { }
        private CriWare.CriMana.Detail.RendererResource CreateRendererResource(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000142
    public class RendererResourceFactoryPriorityAttribute : Attribute
    {
        // Fields
        public readonly System.Int32 priority;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 priority) { }

    }

    // TypeToken: 0x2000143
    public class RendererResourceSofdecPrimeYuv : RendererResource
    {
        // Fields
        private System.Int32 width;        // 0x30
        private System.Int32 height;        // 0x34
        private System.Boolean useUserShader;        // 0x38
        private CriWare.CriMana.CodecType codecType;        // 0x3C
        private UnityEngine.Vector4 movieTextureST;        // 0x40
        private UnityEngine.Vector4 movieChromaTextureST;        // 0x50
        private UnityEngine.Texture2D[] textureY;        // 0x60
        private UnityEngine.Texture2D[] textureU;        // 0x68
        private UnityEngine.Texture2D[] textureV;        // 0x70
        private UnityEngine.Texture2D[] textureA;        // 0x78
        private System.IntPtr[] nativeTextures;        // 0x80
        private System.Int32 currentTextureSet;        // 0x88
        private System.Int32 drawTextureSet;        // 0x8C
        private System.Int32 playerID;        // 0x90
        private System.Boolean hasTextureUpdated;        // 0x94
        private System.Boolean isTextureReady;        // 0x95
        private System.Boolean hasRenderedNewFrame;        // 0x96

        // Methods
        private System.Int32 get_NumTextureSets() { }
        private System.Void .ctor(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader) { }
        private System.Void OnDisposeManaged() { }
        private System.Boolean get_IsEditor() { }
        private System.Void OnDisposeUnmanaged() { }
        private System.Boolean IsPrepared() { }
        private System.Boolean ContinuePreparing() { }
        private System.Boolean IsSuitable(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader) { }
        private System.Boolean OnPlayerStopForSeek() { }
        private System.Boolean HasRenderedNewFrame() { }
        private System.Void AttachToPlayer(System.Int32 playerId) { }
        private System.Boolean UpdateFrame(System.Int32 playerId, CriWare.CriMana.FrameInfo frameInfo, System.Boolean& frameDrop) { }
        private System.Boolean UpdateMaterial(UnityEngine.Material material) { }
        private System.Void UpdateMovieTextureST(System.UInt32 dispWidth, System.UInt32 dispHeight) { }
        private System.Void UpdateTextures() { }

    }

    // TypeToken: 0x2000144
    public class RendererResourceSofdecPrimeYuvRawData : RendererResource
    {
        // Fields
        private System.Int32 width;        // 0x30
        private System.Int32 height;        // 0x34
        private System.Int32 chromaWidth;        // 0x38
        private System.Int32 chromaHeight;        // 0x3C
        private System.Boolean useUserShader;        // 0x40
        private CriWare.CriMana.CodecType codecType;        // 0x44
        private UnityEngine.Vector4 movieTextureST;        // 0x48
        private UnityEngine.Vector4 movieChromaTextureST;        // 0x58
        private UnityEngine.Texture2D[][] textures;        // 0x68
        private System.Int32 currentTextureSet;        // 0x70
        private System.Int32 drawTextureSet;        // 0x74
        private System.IntPtr[] nativePixels;        // 0x78
        private System.Int32 playerID;        // 0x80
        private System.Boolean hasTextureUpdated;        // 0x84
        private System.Boolean isTextureReady;        // 0x85
        private System.Boolean hasRenderedNewFrame;        // 0x86

        // Methods
        private System.Int32 get_NumTextureSets() { }
        private System.Void .ctor(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader) { }
        private System.Void OnDisposeManaged() { }
        private System.Void OnDisposeUnmanaged() { }
        private System.Boolean IsPrepared() { }
        private System.Boolean ContinuePreparing() { }
        private System.Boolean IsSuitable(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader) { }
        private System.Boolean OnPlayerStopForSeek() { }
        private System.Boolean HasRenderedNewFrame() { }
        private System.Void AttachToPlayer(System.Int32 playerId) { }
        private System.Boolean UpdateFrame(System.Int32 playerId, CriWare.CriMana.FrameInfo frameInfo, System.Boolean& frameDrop) { }
        private System.Boolean UpdateMaterial(UnityEngine.Material material) { }
        private System.Void UpdateMovieTextureST(System.UInt32 dispWidth, System.UInt32 dispHeight) { }
        private System.Void UpdateTextures() { }
        private System.Void CalculateTextureSize(System.Int32& w, System.Int32& h, System.Int32 videoWidth, System.Int32 videoHeight, CriWare.CriMana.CodecType type, System.Boolean isChroma) { }

    }

}

namespace CriWare.CriTimeline.Atom
{

    // TypeToken: 0x200011D
    public struct CriAtomClipPlayConfig
    {
        // Fields
        public readonly CriWare.CriTimeline.Atom.CriAtomClipBase clip;        // 0x10
        public readonly System.Int64 startTimeMs;        // 0x18
        public readonly System.Double speedRate;        // 0x20
        public readonly System.Boolean loop;        // 0x28

        // Methods
        private System.Void .ctor(CriWare.CriTimeline.Atom.CriAtomClipBase clip, System.Int64 startTimeMs, System.Double speedRate, System.Boolean loop) { }

    }

    // TypeToken: 0x200011E
    public class CriAtomBehaviour : PlayableBehaviour
    {
        // Fields
        public System.Single volume;        // 0x10
        public System.Single pitch;        // 0x14
        public System.Single AISACValue;        // 0x18
        private static System.Int32 cPreviewStopTimeMs;        // 0x0
        private CriWare.CriAtomExAcb m_acb;        // 0x20
        private System.String m_lastCueSheetPath;        // 0x28
        private CriWare.CriAtomExPlayback <playback>k__BackingField;        // 0x30
        private System.Boolean _IsClipPlaying;        // 0x34
        private System.Double _CueLength;        // 0x38

        // Methods
        private CriWare.CriAtomExPlayback get_playback() { }
        private System.Void set_playback(CriWare.CriAtomExPlayback value) { }
        private System.Boolean get_IsClipPlaying() { }
        private System.Void set_IsClipPlaying(System.Boolean value) { }
        private System.Double get_CueLength() { }
        private System.Void set_CueLength(System.Double value) { }
        private System.Void OnGraphStop(UnityEngine.Playables.Playable playable) { }
        private System.Void Play(CriWare.CriAtomSourceBase atomSource, CriWare.CriTimeline.Atom.CriAtomClipPlayConfig config) { }
        private System.Void PreviewPlay(System.Guid trackId, System.Boolean instantStop, CriWare.CriTimeline.Atom.CriAtomClipPlayConfig config) { }
        private System.Void WaitAndStop() { }
        private System.Void Stop(System.Boolean noReleaseTime) { }
        private System.Double GetCueLengthSec(CriWare.CriAtomExAcb acb, System.String cueName) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <WaitAndStop>b__21_0() { }

    }

    // TypeToken: 0x200011F
    public class CriAtomClip : CriAtomClipBase
    {
        // Fields
        public System.String cueSheet;        // 0x30
        public System.String cueName;        // 0x38

        // Methods
        private System.String get_CueName() { }
        private CriWare.CriAtomExAcb GetAcb() { }
        private CriWare.CriAtomCueSheet GetCueSheet() { }
        private System.String get_AcbPath() { }
        private System.String get_AwbPath() { }
        private System.Void SetCueFromAtomSource(CriWare.CriAtomSourceBase atomSource) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000120
    public class CriAtomClipBase : PlayableAsset, ITimelineClipAsset
    {
        // Fields
        public System.Boolean stopWithoutRelease;        // 0x18
        public System.Boolean muted;        // 0x19
        public System.Boolean ignoreBlend;        // 0x1A
        public System.Boolean loopWithinClip;        // 0x1B
        public System.Boolean stopAtClipEnd;        // 0x1C
        public CriWare.CriTimeline.Atom.CriAtomBehaviour templateBehaviour;        // 0x20
        private System.Double clipDuration;        // 0x28

        // Methods
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Void SetClipDuration(System.Double clipDuration) { }
        private System.Double get_duration() { }
        private System.String get_CueName() { }
        private CriWare.CriAtomExAcb GetAcb() { }
        private System.String get_AcbPath() { }
        private System.String get_AwbPath() { }
        private System.Void SetCueFromAtomSource(CriWare.CriAtomSourceBase atomSource) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000121
    public class CriAtomMixerBehaviour : PlayableBehaviour
    {
        // Fields
        private UnityEngine.Playables.PlayableDirector m_Director;        // 0x10
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> m_Clips;        // 0x18
        private CriWare.CriAtomSourceBase m_Bind;        // 0x20
        private System.String m_AisacControls;        // 0x28
        private System.Boolean m_StopOnWrapping;        // 0x30
        private System.Boolean m_StopAtGraphEnd;        // 0x31
        private System.Guid <m_Guid>k__BackingField;        // 0x34
        private static System.Int32 cScratchTimeIntervalMs;        // 0x0
        private System.DateTime m_lastScrubTime;        // 0x48
        private System.Double m_lastDirectorTime;        // 0x50

        // Methods
        private System.Guid get_m_Guid() { }
        private System.Void set_m_Guid(System.Guid value) { }
        private System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable) { }
        private System.Void OnGraphStop(UnityEngine.Playables.Playable playable) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private System.Boolean get_IsEditor() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000122
    public class CriAtomTimelinePreviewer, IDisposable
    {
        // Fields
        private static CriWare.CriTimeline.Atom.CriAtomTimelinePreviewer instance;        // 0x0
        private CriWare.CriAtom atom;        // 0x10
        private System.String lastAcfFile;        // 0x18
        private System.Collections.Generic.Dictionary<System.String,CriWare.CriAtomExAcb> acbTable;        // 0x20
        private System.Collections.Generic.Dictionary<System.Guid,CriWare.CriTimeline.Atom.CriAtomTimelinePreviewer.PlayerSource> playerTable;        // 0x28
        private CriWare.CriAtomEx3dListener listener3d;        // 0x30

        // Methods
        private CriWare.CriTimeline.Atom.CriAtomTimelinePreviewer get_Instance() { }
        private System.Void InstanceDispose() { }
        private System.Boolean get_IsInitialized() { }
        private System.Void .ctor() { }
        private CriWare.CriAtomExPlayer GetPlayer(System.Guid trackId) { }
        private System.Void SetCue(System.Guid trackId, CriWare.CriAtomExAcb acb, System.String cueName) { }
        private CriWare.CriAtomExAcb GetAcb(System.String acbPath, System.String awbPath) { }
        private CriWare.CriAtomExPlayback Play(System.Guid trackId) { }
        private System.Void StopTrack(System.Guid trackId, System.Boolean stopWithoutRelease) { }
        private System.Void StopAllTracks(System.Boolean stopWithoutRelease) { }
        private System.Void SetStartTime(System.Guid trackId, System.Int64 startTimeMs) { }
        private System.Void SetLoop(System.Guid trackId, System.Boolean sw) { }
        private System.Void SetVolume(System.Guid trackId, System.Single volume) { }
        private System.Void SetPitch(System.Guid trackId, System.Single pitch) { }
        private System.Void SetAISAC(System.Guid trackId, System.String controlName, System.Single value) { }
        private System.Void PlayerUpdateParameter(System.Guid trackId, CriWare.CriAtomExPlayback atomExPlayback) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x2000124
    public class CriAtomTrack : TrackAsset
    {
        // Fields
        public System.String m_AisacControls;        // 0xC0
        public System.Boolean m_StopOnWrapping;        // 0xC8
        public System.Boolean m_StopAtGraphEnd;        // 0xC9

        // Methods
        private UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner, System.Int32 inputCount) { }
        private System.Void .ctor() { }

    }

}

namespace CriWare.CriTimeline.Mana
{

    // TypeToken: 0x2000113
    public class CriManaBehaviour : PlayableBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000114
    public class CriManaClip : CriManaClipBase
    {
        // Fields
        public System.String m_moviePath;        // 0xA8
        public UnityEngine.TextAsset m_movieData;        // 0xB0

        // Methods
        private System.String get_MoviePath() { }
        private System.Byte[] get_MovieData() { }
        private System.String get_MovieName() { }
        private System.Int32 get_DataId() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000115
    public class CriManaClipBase : PlayableAsset, ITimelineClipAsset
    {
        // Fields
        public readonly System.Guid guid;        // 0x18
        public System.Boolean m_loopWithinClip;        // 0x28
        public System.Boolean m_useOnMemoryPlayback;        // 0x29
        public System.Runtime.InteropServices.GCHandle gcHandle;        // 0x30
        private System.Double m_movieFrameRate;        // 0x38
        private System.Double m_clipDuration;        // 0x40
        public System.Single m_fadeinDuration;        // 0x48
        public UnityEngine.AnimationCurve m_fadeinCurve;        // 0x50
        public System.Single m_fadeoutDuration;        // 0x58
        public UnityEngine.AnimationCurve m_fadeoutCurve;        // 0x60
        public System.Boolean m_fadeAudio;        // 0x68
        public UnityEngine.Timeline.TimelineClip m_clip;        // 0x70
        public CriWare.CriTimeline.Mana.CriManaBehaviour m_manaBehaviour;        // 0x78
        private System.Nullable<CriWare.CriTimeline.Mana.CriManaClipBase.MovieInfoStruct> m_movieInfoStruct;        // 0x80

        // Methods
        private System.String get_MoviePath() { }
        private System.Byte[] get_MovieData() { }
        private System.String get_MovieName() { }
        private System.Int32 get_DataId() { }
        private System.Nullable<CriWare.CriTimeline.Mana.CriManaClipBase.MovieInfoStruct> StructToMovieInfo(CriWare.CriMana.MovieInfo movieInfo) { }
        private UnityEngine.Timeline.ClipCaps get_clipCaps() { }
        private UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner) { }
        private System.Void ReplaceMovieInfo(CriWare.CriMana.MovieInfo movieInfo) { }
        private System.Boolean IsSameMovie(CriWare.CriMana.MovieInfo movieInfo) { }
        private System.Boolean get_IsMovieInfoReady() { }
        private System.Int32 GetSeekFrame(System.Double seekTimeSec, System.Boolean loop) { }
        private System.Double get_duration() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000117
    public class CriManaMixerBehaviour : PlayableBehaviour
    {
        // Fields
        private UnityEngine.Playables.PlayableDirector m_PlayableDirector;        // 0x10
        private System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> m_clips;        // 0x18
        private CriWare.CriManaMovieMaterialBase m_boundMovieMaterial;        // 0x20
        private System.Collections.Generic.Dictionary<System.Int32,System.Runtime.InteropServices.GCHandle> m_gcHandleList;        // 0x28
        private System.Boolean m_frameSync;        // 0x30
        private static System.Double cPreloadTimeSec;        // 0x0
        private System.Nullable<System.Guid> m_lastClipId;        // 0x34
        private System.Double startTime;        // 0x48
        private System.Double m_currentSeekingFrameTime;        // 0x50
        private System.Single m_originalAudioVolume;        // 0x58
        private System.Single m_originalSubAudioVolume;        // 0x5C
        private System.Single m_originalExtraAudioVolume;        // 0x60
        private System.Boolean enableTimelineScrubPlayback;        // 0x64
        public System.Boolean IsControllingUI;        // 0x65
        private CriWare.CriManaMovieControllerForUI m_controllerForUI;        // 0x68
        public System.Action<CriWare.CriMana.MovieInfo> MovieReadyToPlay;        // 0x70
        public System.Action<System.Boolean> OnToggleFMVNode;        // 0x78
        private CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerState m_movieMixerState;        // 0x80

        // Methods
        private System.Boolean get_IsEditMode() { }
        private System.Void KeepAudioVolume(System.Boolean fadeAudio) { }
        private System.Boolean PlayMovie(CriWare.CriTimeline.Mana.CriManaClipBase clipAsset, System.Int32 startFrame, System.Double startTime) { }
        private System.Boolean PrepareMovie(CriWare.CriTimeline.Mana.CriManaClipBase clipAsset) { }
        private System.Boolean StopMovie() { }
        private System.Boolean StopForSeekMovie() { }
        private System.Boolean IsPlayerPreparing(CriWare.CriMana.Player player) { }
        private System.Boolean IsPlayerStopped(CriWare.CriMana.Player player) { }
        private System.Boolean IsPlayerError(CriWare.CriMana.Player player) { }
        private System.Boolean IsPlayerReadyOrPlaying(CriWare.CriMana.Player player) { }
        private System.Void ProcessFrameOnSeeking(UnityEngine.Timeline.TimelineClip activeClip, CriWare.CriTimeline.Mana.CriManaClipBase clip, System.Double frameTime) { }
        private System.Void ForceSyncedStop(System.Boolean keepLastFrame) { }
        private System.Void ToggleFMVNode(UnityEngine.Playables.FrameData info, System.Boolean isOn) { }
        private System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) { }
        private System.Collections.IEnumerator seekPlaybackEnumerator() { }
        private System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) { }
        private System.Void PausePlayer(System.Boolean pause) { }
        private System.Void OnGraphStart(UnityEngine.Playables.Playable playable) { }
        private System.Void OnGraphStop(UnityEngine.Playables.Playable playable) { }
        private System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable) { }
        private System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable) { }
        private System.Void InitMovieMixerState() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200011C
    public class CriManaTrack : TrackAsset
    {
        // Fields
        public System.Boolean frameSync;        // 0xC0
        public readonly System.Guid guid;        // 0xC4
        private static System.Collections.Generic.Dictionary<System.Int32,System.Guid> bindDict;        // 0x0
        private CriWare.CriTimeline.Mana.CriManaMixerBehaviour <MixerBehaviour>k__BackingField;        // 0xD8

        // Methods
        private CriWare.CriTimeline.Mana.CriManaMixerBehaviour get_MixerBehaviour() { }
        private System.Void set_MixerBehaviour(CriWare.CriTimeline.Mana.CriManaMixerBehaviour value) { }
        private UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount) { }
        private System.Void BindBehaviourMovieMaterial(UnityEngine.Playables.PlayableDirector director, CriWare.CriManaMovieMaterialBase boundMovieMaterial) { }
        private System.Void OnDestroy() { }
        private System.Void RemoveTrackFromBindDict(CriWare.CriTimeline.Mana.CriManaTrack trackAsset) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

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

