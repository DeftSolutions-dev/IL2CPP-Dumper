// ========================================================
// Dumped by @desirepro
// Assembly: CriMw.CriWare.Runtime.dll
// Classes:  326
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: AudioPortType
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  CriWare.CriWarePS5.AudioPortTypeMain  // 0x0
  public    static  CriWare.CriWarePS5.AudioPortTypeBgm  // 0x0
  public    static  CriWare.CriWarePS5.AudioPortTypeVoice  // 0x0
  public    static  CriWare.CriWarePS5.AudioPortTypePadSpeaker  // 0x0
  public    static  CriWare.CriWarePS5.AudioPortTypePersonal  // 0x0
  public    static  CriWare.CriWarePS5.AudioPortTypeAux  // 0x0
  public    static  CriWare.CriWarePS5.AudioPortTypeVibration  // 0x0
  public    static  CriWare.CriWarePS5.AudioPortTypeObjectMain  // 0x0
  public    static  CriWare.CriWarePS5.AudioPortTypeObjectVoice  // 0x0
  public    static  CriWare.CriWarePS5.AudioPortTypeObjecPersonal  // 0x0
METHODS:
END_CLASS

CLASS: AttributeId
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriWarePS5.AttributeId  Pcm  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  Gain  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  Priority  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  Position  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  Spread  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  Passthrough  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  ResetState  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  ApplicationSpecific  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  Ambisonics  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  Restricted  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  MixToMainGain  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  DebugName  // 0x0
  public    static  CriWare.CriWarePS5.AttributeId  MAX  // 0x0
METHODS:
END_CLASS

CLASS: PortFlag
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  CriWare.CriWarePS5.PortFlag     Restricted  // 0x0
  public    static  CriWare.CriWarePS5.PortFlag     Passthrough  // 0x0
METHODS:
END_CLASS

CLASS: SafeNativeMethods
TYPE:  class
TOKEN: 0x200000B
FIELDS:
METHODS:
  System.Void criFsUnity_Setup_PS5(System.Boolean enable_apr_direct_mode)
END_CLASS

CLASS: CallbackFromNativeDelegate
TYPE:  class
TOKEN: 0x200000D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.UInt64 Invoke(System.IntPtr ptr1)
  System.IAsyncResult BeginInvoke(System.IntPtr ptr1, System.AsyncCallback callback, System.Object object)
  System.UInt64 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: OutputDeviceType
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomOutputDeviceObserver.OutputDeviceTypeBuiltinSpeaker  // 0x0
  public    static  CriWare.CriAtomOutputDeviceObserver.OutputDeviceTypeWiredDevice  // 0x0
  public    static  CriWare.CriAtomOutputDeviceObserver.OutputDeviceTypeWirelessDevice  // 0x0
METHODS:
END_CLASS

CLASS: DeviceConnectionChangeCallback
TYPE:  class
TOKEN: 0x2000016
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Boolean isConnected, CriWare.CriAtomOutputDeviceObserver.OutputDeviceType deviceType)
  System.IAsyncResult BeginInvoke(System.Boolean isConnected, CriWare.CriAtomOutputDeviceObserver.OutputDeviceType deviceType, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: UnsafeNativeMethods
TYPE:  class
TOKEN: 0x2000017
FIELDS:
METHODS:
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomSourceBase.StatusStop  // 0x0
  public    static  CriWare.CriAtomSourceBase.StatusPrep  // 0x0
  public    static  CriWare.CriAtomSourceBase.StatusPlaying  // 0x0
  public    static  CriWare.CriAtomSourceBase.StatusPlayEnd  // 0x0
  public    static  CriWare.CriAtomSourceBase.StatusError  // 0x0
METHODS:
END_CLASS

CLASS: SetControlIdMethod
TYPE:  class
TOKEN: 0x200001F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.UInt16 id)
  System.IAsyncResult BeginInvoke(System.UInt16 id, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: CharacterEncoding
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.CharacterEncodingUtf8  // 0x0
  public    static  CriWare.CriAtomEx.CharacterEncodingSjis  // 0x0
METHODS:
END_CLASS

CLASS: SoundRendererType
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.SoundRendererTypeDefault  // 0x0
  public    static  CriWare.CriAtomEx.SoundRendererTypeNative  // 0x0
  public    static  CriWare.CriAtomEx.SoundRendererTypeAsr  // 0x0
  public    static  CriWare.CriAtomEx.SoundRendererTypeHw1  // 0x0
  public    static  CriWare.CriAtomEx.SoundRendererTypeHw2  // 0x0
  public    static  CriWare.CriAtomEx.SoundRendererTypeHaptic  // 0x0
METHODS:
END_CLASS

CLASS: VoiceAllocationMethod
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.VoiceAllocationMethodOnce  // 0x0
  public    static  CriWare.CriAtomEx.VoiceAllocationMethodRetry  // 0x0
METHODS:
END_CLASS

CLASS: BiquadFilterType
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.BiquadFilterTypeOff  // 0x0
  public    static  CriWare.CriAtomEx.BiquadFilterTypeLowPass  // 0x0
  public    static  CriWare.CriAtomEx.BiquadFilterTypeHighPass  // 0x0
  public    static  CriWare.CriAtomEx.BiquadFilterTypeNotch  // 0x0
  public    static  CriWare.CriAtomEx.BiquadFilterTypeLowShelf  // 0x0
  public    static  CriWare.CriAtomEx.BiquadFilterTypeHighShelf  // 0x0
  public    static  CriWare.CriAtomEx.BiquadFilterTypePeaking  // 0x0
METHODS:
END_CLASS

CLASS: ResumeMode
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.ResumeMode    AllPlayback  // 0x0
  public    static  CriWare.CriAtomEx.ResumeMode    PausedPlayback  // 0x0
  public    static  CriWare.CriAtomEx.ResumeMode    PreparedPlayback  // 0x0
METHODS:
END_CLASS

CLASS: PanType
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.PanType       Unknown  // 0x0
  public    static  CriWare.CriAtomEx.PanType       Pan3d  // 0x0
  public    static  CriWare.CriAtomEx.PanType       Pos3d  // 0x0
  public    static  CriWare.CriAtomEx.PanType       Auto  // 0x0
METHODS:
END_CLASS

CLASS: VoiceControlMethod
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.VoiceControlMethodPreferLast  // 0x0
  public    static  CriWare.CriAtomEx.VoiceControlMethodPreferFirst  // 0x0
METHODS:
END_CLASS

CLASS: Parameter
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.Parameter     Volume  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     Pitch  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     Pan3dAngle  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     Pan3dDistance  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     Pan3dVolume  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BusSendLevel0  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BusSendLevel1  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BusSendLevel2  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BusSendLevel3  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BusSendLevel4  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BusSendLevel5  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BusSendLevel6  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BusSendLevel7  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BandPassFilterCofLow  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BandPassFilterCofHigh  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BiquadFilterType  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BiquadFilterFreq  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BiquadFIlterQ  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     BiquadFilterGain  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     EnvelopeAttackTime  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     EnvelopeHoldTime  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     EnvelopeDecayTime  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     EnvelopeReleaseTime  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     EnvelopeSustainLevel  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     StartTime  // 0x0
  public    static  CriWare.CriAtomEx.Parameter     Priority  // 0x0
METHODS:
END_CLASS

CLASS: Speaker
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.Speaker       FrontLeft  // 0x0
  public    static  CriWare.CriAtomEx.Speaker       FrontRight  // 0x0
  public    static  CriWare.CriAtomEx.Speaker       FrontCenter  // 0x0
  public    static  CriWare.CriAtomEx.Speaker       LowFrequency  // 0x0
  public    static  CriWare.CriAtomEx.Speaker       SurroundLeft  // 0x0
  public    static  CriWare.CriAtomEx.Speaker       SurroundRight  // 0x0
  public    static  CriWare.CriAtomEx.Speaker       SurroundBackLeft  // 0x0
  public    static  CriWare.CriAtomEx.Speaker       SurroundBackRight  // 0x0
METHODS:
END_CLASS

CLASS: Format
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  CriWare.CriAtomEx.Format        ADX  // 0x0
  public    static  CriWare.CriAtomEx.Format        HCA  // 0x0
  public    static  CriWare.CriAtomEx.Format        HCA_MX  // 0x0
  public    static  CriWare.CriAtomEx.Format        WAVE  // 0x0
  public    static  CriWare.CriAtomEx.Format        RAW_PCM  // 0x0
  public    static  CriWare.CriAtomEx.Format        AUDIO_BUFFER  // 0x0
METHODS:
END_CLASS

CLASS: SpeakerSystem
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  CriWare.CriAtomEx.SpeakerSystem Surround_5_1  // 0x0
  public    static  CriWare.CriAtomEx.SpeakerSystem Surround_7_1  // 0x0
METHODS:
END_CLASS

CLASS: SpeakerAngles6ch
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Single                   frontLeft  // 0x10
  public            System.Single                   frontRight  // 0x14
  public            System.Single                   frontCenter  // 0x18
  public            System.Single                   lowFrequency  // 0x1C
  public            System.Single                   surroundLeft  // 0x20
  public            System.Single                   surroundRight  // 0x24
METHODS:
  CriWare.CriAtomEx.SpeakerAngles6ch Default()
END_CLASS

CLASS: SpeakerAngles8ch
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Single                   frontLeft  // 0x10
  public            System.Single                   frontRight  // 0x14
  public            System.Single                   frontCenter  // 0x18
  public            System.Single                   lowFrequency  // 0x1C
  public            System.Single                   surroundLeft  // 0x20
  public            System.Single                   surroundRight  // 0x24
  public            System.Single                   surroundBackLeft  // 0x28
  public            System.Single                   surroundBackRight  // 0x2C
METHODS:
  CriWare.CriAtomEx.SpeakerAngles8ch Default()
END_CLASS

CLASS: FormatInfo
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            CriWare.CriAtomEx.Format        format  // 0x10
  public            System.Int32                    samplingRate  // 0x14
  public            System.Int64                    numSamples  // 0x18
  public            System.Int64                    loopOffset  // 0x20
  public            System.Int64                    loopLength  // 0x28
  public            System.Int32                    numChannels  // 0x30
  public            System.UInt32                   reserved  // 0x34
METHODS:
END_CLASS

CLASS: AisacControlInfo
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public    readonly System.String                   name  // 0x10
  public            System.UInt32                   id  // 0x18
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: Randomize3dCalcType
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.Randomize3dCalcTypeNone  // 0x0
  public    static  CriWare.CriAtomEx.Randomize3dCalcTypeRectangle  // 0x0
  public    static  CriWare.CriAtomEx.Randomize3dCalcTypeCuboid  // 0x0
  public    static  CriWare.CriAtomEx.Randomize3dCalcTypeCircle  // 0x0
  public    static  CriWare.CriAtomEx.Randomize3dCalcTypeCylinder  // 0x0
  public    static  CriWare.CriAtomEx.Randomize3dCalcTypeSphere  // 0x0
  public    static  CriWare.CriAtomEx.Randomize3dCalcTypeList  // 0x0
METHODS:
END_CLASS

CLASS: Randomize3dParamType
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.Randomize3dParamTypeNone  // 0x0
  public    static  CriWare.CriAtomEx.Randomize3dParamTypeWidth  // 0x0
  public    static  CriWare.CriAtomEx.Randomize3dParamTypeDepth  // 0x0
  public    static  CriWare.CriAtomEx.Randomize3dParamTypeHeight  // 0x0
  public    static  CriWare.CriAtomEx.Randomize3dParamTypeRadius  // 0x0
METHODS:
END_CLASS

CLASS: Randomize3dConfig
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public    static  System.Int32                    NumOfCalcParams  // 0x0
  private           System.Boolean                  followsOriginalSource  // 0x10
  private           CriWare.CriAtomEx.Randomize3dCalcTypecalculationType  // 0x14
  private           System.Single[]                 calculationParameters  // 0x18
METHODS:
  System.Boolean get_FollowsOriginalSource()
  CriWare.CriAtomEx.Randomize3dCalcType get_CalculationType()
  System.Single get_CalculationParameter1()
  System.Single get_CalculationParameter2()
  System.Single get_CalculationParameter3()
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
  System.Void .ctor(System.Boolean followsOriginalSource, CriWare.CriAtomEx.Randomize3dCalcType calculationType, System.Single param1, System.Single param2, System.Single param3)
  System.Void .ctor(System.Int32 dummy)
  System.Void ClearCalcParams(System.Single initVal)
  System.Boolean GetParamByType(CriWare.CriAtomEx.Randomize3dParamType paramType, System.Single& paramVal)
  System.Boolean SetParamByType(CriWare.CriAtomEx.Randomize3dParamType paramType, System.Single paramVal)
END_CLASS

CLASS: CuePos3dInfo
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Single                   coneInsideAngle  // 0x10
  public            System.Single                   coneOutsideAngle  // 0x14
  public            System.Single                   minAttenuationDistance  // 0x18
  public            System.Single                   maxAttenuationDistance  // 0x1C
  public            System.Single                   sourceRadius  // 0x20
  public            System.Single                   interiorDistance  // 0x24
  public            System.Single                   dopplerFactor  // 0x28
  public            CriWare.CriAtomEx.Randomize3dConfigrandomPos  // 0x30
  public            System.UInt32                   distanceAisacControl  // 0x40
  public            System.UInt32                   listenerBaseAngleAisacControl  // 0x44
  public            System.UInt32                   sourceBaseAngleAisacControl  // 0x48
  public            System.UInt32                   listenerBaseElevationAisacControl  // 0x4C
  public            System.UInt32                   sourceBaseElevationAisacControl  // 0x50
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: GameVariableInfo
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public    readonly System.String                   name  // 0x10
  public            System.UInt32                   id  // 0x18
  public            System.Single                   gameValue  // 0x1C
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
  System.Void .ctor(System.String name, System.UInt32 id, System.Single gameValue)
END_CLASS

CLASS: CueType
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomEx.CueType       Polyphonic  // 0x0
  public    static  CriWare.CriAtomEx.CueType       Sequential  // 0x0
  public    static  CriWare.CriAtomEx.CueType       Shuffle  // 0x0
  public    static  CriWare.CriAtomEx.CueType       Random  // 0x0
  public    static  CriWare.CriAtomEx.CueType       RandomNoRepeat  // 0x0
  public    static  CriWare.CriAtomEx.CueType       SwitchGameVariable  // 0x0
  public    static  CriWare.CriAtomEx.CueType       ComboSequential  // 0x0
  public    static  CriWare.CriAtomEx.CueType       SwitchSelector  // 0x0
  public    static  CriWare.CriAtomEx.CueType       TrackTransitionBySelector  // 0x0
METHODS:
END_CLASS

CLASS: CueInfo
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.Int32                    id  // 0x10
  public            CriWare.CriAtomEx.CueType       type  // 0x14
  public    readonly System.String                   name  // 0x18
  public    readonly System.String                   userData  // 0x20
  public            System.Int64                    length  // 0x28
  public            System.UInt16[]                 categories  // 0x30
  public            System.Int16                    numLimits  // 0x38
  public            System.UInt16                   numBlocks  // 0x3A
  public            System.UInt16                   numTracks  // 0x3C
  public            System.UInt16                   numRelatedWaveForms  // 0x3E
  public            System.Byte                     priority  // 0x40
  public            System.Byte                     headerVisibility  // 0x41
  public            System.Byte                     ignore_player_parameter  // 0x42
  public            System.Byte                     probability  // 0x43
  public            CriWare.CriAtomEx.PanType       panType  // 0x44
  public            CriWare.CriAtomEx.CuePos3dInfo  pos3dInfo  // 0x48
  public            CriWare.CriAtomEx.GameVariableInfogameVariableInfo  // 0x90
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: WaveformInfo
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.Int32                    waveId  // 0x10
  public            System.UInt32                   format  // 0x14
  public            System.Int32                    samplingRate  // 0x18
  public            System.Int32                    numChannels  // 0x1C
  public            System.Int64                    numSamples  // 0x20
  public            System.Boolean                  streamingFlag  // 0x28
  public            System.UInt32[]                 reserved  // 0x30
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: AisacInfo
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public    readonly System.String                   name  // 0x10
  public            System.Boolean                  defaultControlFlag  // 0x18
  public            System.Single                   defaultControlValue  // 0x1C
  public            System.UInt32                   controlId  // 0x20
  public    readonly System.String                   controlName  // 0x28
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: PerformanceInfo
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            System.UInt32                   serverProcessCount  // 0x10
  public            System.UInt32                   lastServerTime  // 0x14
  public            System.UInt32                   maxServerTime  // 0x18
  public            System.UInt32                   averageServerTime  // 0x1C
  public            System.UInt32                   lastServerInterval  // 0x20
  public            System.UInt32                   maxServerInterval  // 0x24
  public            System.UInt32                   averageServerInterval  // 0x28
METHODS:
END_CLASS

CLASS: ResourceUsage
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  public            System.UInt32                   useCount  // 0x10
  public            System.UInt32                   limit  // 0x14
METHODS:
END_CLASS

CLASS: NativeVector
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   z  // 0x18
METHODS:
  System.Void .ctor(System.Single x, System.Single y, System.Single z)
  System.Void .ctor(UnityEngine.Vector3 vector)
END_CLASS

CLASS: CueLinkInfo
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            System.IntPtr                   nativePlayerHn  // 0x10
  public            System.UInt32                   basePlaybackId  // 0x18
  public            System.UInt32                   targetPlaybackId  // 0x1C
  public            System.Int32                    cueLinkType  // 0x20
METHODS:
END_CLASS

CLASS: CueLinkCbFunc
TYPE:  class
TOKEN: 0x200003E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(CriWare.CriAtomEx.CueLinkInfo& info)
  System.IAsyncResult BeginInvoke(CriWare.CriAtomEx.CueLinkInfo& info, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(CriWare.CriAtomEx.CueLinkInfo& info, System.IAsyncResult result)
END_CLASS

CLASS: ReactType
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExCategory.ReactTypeDucker  // 0x0
  public    static  CriWare.CriAtomExCategory.ReactTypeAisacModulationTrigger  // 0x0
METHODS:
END_CLASS

CLASS: ReactDuckerTargetType
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExCategory.ReactDuckerTargetTypeVolume  // 0x0
  public    static  CriWare.CriAtomExCategory.ReactDuckerTargetTypeAisacControlValue  // 0x0
METHODS:
END_CLASS

CLASS: ReactDuckerCurveType
TYPE:  struct
TOKEN: 0x2000042
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExCategory.ReactDuckerCurveTypeLinear  // 0x0
  public    static  CriWare.CriAtomExCategory.ReactDuckerCurveTypeSquare  // 0x0
  public    static  CriWare.CriAtomExCategory.ReactDuckerCurveTypeSquareReverse  // 0x0
  public    static  CriWare.CriAtomExCategory.ReactDuckerCurveTypeSCurve  // 0x0
  public    static  CriWare.CriAtomExCategory.ReactDuckerCurveTypeFlatAtHalf  // 0x0
METHODS:
END_CLASS

CLASS: ReactFadeParameter
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            CriWare.CriAtomExCategory.ReactDuckerCurveTypecurveType  // 0x10
  public            System.Single                   curveStrength  // 0x14
  public            System.UInt16                   fadeTimeMs  // 0x18
METHODS:
END_CLASS

CLASS: ReactHoldType
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExCategory.ReactHoldTypeWhilePlaying  // 0x0
  public    static  CriWare.CriAtomExCategory.ReactHoldTypeFixedTime  // 0x0
METHODS:
END_CLASS

CLASS: Volume
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            System.Single                   level  // 0x10
METHODS:
END_CLASS

CLASS: AisacControl
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public            System.UInt32                   id  // 0x10
  public            System.Single                   value  // 0x14
METHODS:
END_CLASS

CLASS: Target
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            CriWare.CriAtomExCategory.ReactDuckerParameter.Volumevolume  // 0x10
  public            CriWare.CriAtomExCategory.ReactDuckerParameter.AisacControlaisacControl  // 0x10
METHODS:
END_CLASS

CLASS: ReactDuckerParameter
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            CriWare.CriAtomExCategory.ReactDuckerParameter.Targettarget  // 0x10
  public            CriWare.CriAtomExCategory.ReactDuckerTargetTypetargetType  // 0x18
  public            CriWare.CriAtomExCategory.ReactFadeParameterentry  // 0x1C
  public            CriWare.CriAtomExCategory.ReactFadeParameterexit  // 0x28
  public            CriWare.CriAtomExCategory.ReactHoldTypeholdType  // 0x34
  public            System.UInt16                   holdTimeMs  // 0x38
METHODS:
END_CLASS

CLASS: ReactAisacModulationParameter
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  private           System.Int32                    _enableDecrementAisacModulationKey  // 0x10
  public            System.UInt32                   decrementAisacModulationKey  // 0x14
  private           System.Int32                    _enableIncrementAisacModulationKey  // 0x18
  public            System.UInt32                   incrementAisacModulationKey  // 0x1C
METHODS:
  System.Boolean get_enableDecrementAisacModulationKey()
  System.Boolean get_enableIncrementAisacModulationKey()
END_CLASS

CLASS: Parameter
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            CriWare.CriAtomExCategory.ReactDuckerParameterducker  // 0x10
  public            CriWare.CriAtomExCategory.ReactAisacModulationParameteraisacModulation  // 0x10
METHODS:
END_CLASS

CLASS: ReactParameter
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  public            CriWare.CriAtomExCategory.ReactParameter.Parameterparameter  // 0x10
  public            CriWare.CriAtomExCategory.ReactTypetype  // 0x3C
  public            System.Boolean                  enablePausingCue  // 0x40
METHODS:
END_CLASS

CLASS: ReactStatus
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExCategory.ReactStatusStop  // 0x0
  public    static  CriWare.CriAtomExCategory.ReactStatusFadeOut  // 0x0
  public    static  CriWare.CriAtomExCategory.ReactStatusHold  // 0x0
  public    static  CriWare.CriAtomExCategory.ReactStatusFadeIn  // 0x0
  public    static  CriWare.CriAtomExCategory.ReactStatusError  // 0x0
METHODS:
END_CLASS

CLASS: CriAtomExSequenceEventInfo
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  public            System.UInt64                   position  // 0x10
  public            System.IntPtr                   playerHn  // 0x18
  public    readonly System.String                   tag  // 0x20
  public            System.UInt32                   playbackId  // 0x28
  private           System.Int32                    type  // 0x2C
  public            System.UInt32                   id  // 0x30
  private           System.UInt32                   reserved  // 0x34
METHODS:
END_CLASS

CLASS: EventCbFunc
TYPE:  class
TOKEN: 0x200004F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String eventParamsString)
  System.IAsyncResult BeginInvoke(System.String eventParamsString, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: EventCallback
TYPE:  class
TOKEN: 0x2000050
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(CriWare.CriAtomExSequencer.CriAtomExSequenceEventInfo& criAtomExSequenceInfo)
  System.IAsyncResult BeginInvoke(CriWare.CriAtomExSequencer.CriAtomExSequenceEventInfo& criAtomExSequenceInfo, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(CriWare.CriAtomExSequencer.CriAtomExSequenceEventInfo& criAtomExSequenceInfo, System.IAsyncResult result)
END_CLASS

CLASS: Info
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  public            System.IntPtr                   playerHn  // 0x10
  public            System.UInt32                   playbackId  // 0x18
  public            System.UInt32                   barCount  // 0x1C
  public            System.UInt32                   beatCount  // 0x20
  public            System.Single                   beatProgress  // 0x24
  public            System.Single                   bpm  // 0x28
  public            System.Int32                    offset  // 0x2C
  public            System.UInt32                   numBeats  // 0x30
METHODS:
END_CLASS

CLASS: CbFunc
TYPE:  class
TOKEN: 0x2000053
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(CriWare.CriAtomExBeatSync.Info& info)
  System.IAsyncResult BeginInvoke(CriWare.CriAtomExBeatSync.Info& info, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(CriWare.CriAtomExBeatSync.Info& info, System.IAsyncResult result)
END_CLASS

CLASS: BusAnalyzerConfig
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  public            System.Int32                    interval  // 0x10
  public            System.Int32                    peakHoldTime  // 0x14
METHODS:
END_CLASS

CLASS: BusAnalyzerInfo
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  public            System.Int32                    numChannels  // 0x10
  public            System.Single[]                 rmsLevels  // 0x18
  public            System.Single[]                 peakLevels  // 0x20
  public            System.Single[]                 peakHoldLevels  // 0x28
METHODS:
  System.Void .ctor(System.Byte[] data)
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExLatencyEstimator.StatusStop  // 0x0
  public    static  CriWare.CriAtomExLatencyEstimator.StatusProcessing  // 0x0
  public    static  CriWare.CriAtomExLatencyEstimator.StatusDone  // 0x0
  public    static  CriWare.CriAtomExLatencyEstimator.StatusError  // 0x0
METHODS:
END_CLASS

CLASS: EstimatorInfo
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public            CriWare.CriAtomExLatencyEstimator.Statusstatus  // 0x10
  public            System.UInt32                   estimated_latency  // 0x14
METHODS:
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  public            System.Int32                    reserved  // 0x10
METHODS:
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            System.Boolean                  enableVoicePriorityDecay  // 0x10
  public            System.UInt32                   randomPositionListMaxLength  // 0x14
METHODS:
  System.Void .ctor(System.Boolean enableVoicePriorityDecay, System.UInt32 randomPositionListMaxLength)
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
  public            System.Int32                    reserved  // 0x10
METHODS:
END_CLASS

CLASS: UnsafeNativeMethods
TYPE:  class
TOKEN: 0x2000060
FIELDS:
METHODS:
  System.IntPtr criAtomEx3dTransceiver_Create(CriWare.CriAtomEx3dTransceiver.Config& config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomEx3dTransceiver_Destroy(System.IntPtr ex_3d_transceiver)
  System.Void criAtomEx3dTransceiver_Update(System.IntPtr ex_3d_transceiver)
  System.Void criAtomEx3dTransceiver_SetInputPosition(System.IntPtr ex_3d_transceiver, CriWare.CriAtomEx.NativeVector& position)
  System.Void criAtomEx3dTransceiver_SetOutputPosition(System.IntPtr ex_3d_transceiver, CriWare.CriAtomEx.NativeVector& position)
  System.Void criAtomEx3dTransceiver_SetInputOrientation(System.IntPtr ex_3d_transceiver, CriWare.CriAtomEx.NativeVector& front, CriWare.CriAtomEx.NativeVector& top)
  System.Void criAtomEx3dTransceiver_SetOutputOrientation(System.IntPtr ex_3d_transceiver, CriWare.CriAtomEx.NativeVector& front, CriWare.CriAtomEx.NativeVector& top)
  System.Void criAtomEx3dTransceiver_SetOutputConeParameter(System.IntPtr ex_3d_transceiver, System.Single inside_angle, System.Single outside_angle, System.Single outside_volume)
  System.Void criAtomEx3dTransceiver_SetOutputMinMaxAttenuationDistance(System.IntPtr ex_3d_transceiver, System.Single min_attenuation_distance, System.Single max_attenuation_distance)
  System.Void criAtomEx3dTransceiver_SetOutputInteriorPanField(System.IntPtr ex_3d_transceiver, System.Single transceiver_radius, System.Single interior_distance)
  System.Void criAtomEx3dTransceiver_SetInputCrossFadeField(System.IntPtr ex_3d_transceiver, System.Single direct_audio_radius, System.Single crossfade_distance)
  System.Void criAtomEx3dTransceiver_SetOutputVolume(System.IntPtr ex_3d_transceiver, System.Single volume)
  System.Void criAtomEx3dTransceiver_AttachAisac(System.IntPtr ex_3d_transceiver, System.String global_aisac_name)
  System.Void criAtomEx3dTransceiver_DetachAisac(System.IntPtr ex_3d_transceiver, System.String global_aisac_name)
  System.Void criAtomEx3dTransceiver_SetMaxAngleAisacDelta(System.IntPtr ex_3d_transceiver, System.Single max_delta)
  System.Void criAtomEx3dTransceiver_SetDistanceAisacControlId(System.IntPtr ex_3d_transceiver, System.UInt16 aisac_control_id)
  System.Void criAtomEx3dTransceiver_SetListenerBasedAzimuthAngleAisacControlId(System.IntPtr ex_3d_transceiver, System.UInt16 aisac_control_id)
  System.Void criAtomEx3dTransceiver_SetListenerBasedElevationAngleAisacControlId(System.IntPtr ex_3d_transceiver, System.UInt16 aisac_control_id)
  System.Void criAtomEx3dTransceiver_SetTransceiverOutputBasedAzimuthAngleAisacControlId(System.IntPtr ex_3d_transceiver, System.UInt16 aisac_control_id)
  System.Void criAtomEx3dTransceiver_SetTransceiverOutputBasedElevationAngleAisacControlId(System.IntPtr ex_3d_transceiver, System.UInt16 aisac_control_id)
  System.Void criAtomEx3dTransceiver_Set3dRegionHn(System.IntPtr ex_3d_transceiver, System.IntPtr ex_3d_region)
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x2000062
FIELDS:
  public            System.Int32                    reserved  // 0x10
METHODS:
END_CLASS

CLASS: UnsafeNativeMethods
TYPE:  class
TOKEN: 0x2000063
FIELDS:
METHODS:
  System.IntPtr criAtomEx3dRegion_Create(CriWare.CriAtomEx3dRegion.Config& config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomEx3dRegion_Destroy(System.IntPtr ex_3d_region)
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExAcbLoader.StatusStop  // 0x0
  public    static  CriWare.CriAtomExAcbLoader.StatusLoading  // 0x0
  public    static  CriWare.CriAtomExAcbLoader.StatusComplete  // 0x0
  public    static  CriWare.CriAtomExAcbLoader.StatusError  // 0x0
METHODS:
END_CLASS

CLASS: LoaderConfig
TYPE:  struct
TOKEN: 0x2000067
FIELDS:
  public            System.Boolean                  shouldLoadAwbOnMemory  // 0x10
METHODS:
END_CLASS

CLASS: AcfDspSettingInfo
TYPE:  struct
TOKEN: 0x2000069
FIELDS:
  public            System.String                   name  // 0x10
  public            System.UInt16[]                 busIndexes  // 0x18
  public            System.UInt16[]                 extendBusIndexes  // 0x20
  public            System.UInt16                   snapshotStartIndex  // 0x28
  public            System.Byte                     numBuses  // 0x2A
  public            System.Byte                     numExtendBuses  // 0x2B
  public            System.UInt16                   numSnapshots  // 0x2C
  public            System.UInt16                   snapshotWorkSize  // 0x2E
  public            System.UInt16                   numMixerAisacs  // 0x30
  public            System.UInt16                   mixerAisacStartIndex  // 0x32
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: AcfDspSettingSnapshotInfo
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Byte                     numBuses  // 0x18
  public            System.Byte                     numExtendBuses  // 0x19
  public            System.Byte[]                   reserved  // 0x20
  public            System.UInt16[]                 busIndexes  // 0x28
  public            System.UInt16[]                 extendBusIndexes  // 0x30
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: AcfDspBusInfo
TYPE:  struct
TOKEN: 0x200006B
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Single                   volume  // 0x18
  public            System.Single                   pan3dVolume  // 0x1C
  public            System.Single                   pan3dAngle  // 0x20
  public            System.Single                   pan3dDistance  // 0x24
  public            System.Single                   pan3dSpread  // 0x28
  public            System.UInt16[]                 fxIndexes  // 0x30
  public            System.UInt16[]                 busLinkIndexes  // 0x38
  public            System.UInt16                   busNo  // 0x40
  public            System.Byte                     numFxes  // 0x42
  public            System.Byte                     numBusLinks  // 0x43
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: AcfDspBusLinkType
TYPE:  struct
TOKEN: 0x200006C
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  CriWare.CriAtomExAcf.AcfDspBusLinkTypepreVolume  // 0x0
  public    static  CriWare.CriAtomExAcf.AcfDspBusLinkTypepostVolume  // 0x0
  public    static  CriWare.CriAtomExAcf.AcfDspBusLinkTypepostPan  // 0x0
METHODS:
END_CLASS

CLASS: AcfDspBusLinkInfo
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  public            CriWare.CriAtomExAcf.AcfDspBusLinkTypetype  // 0x10
  public            System.Single                   sendLevel  // 0x14
  public            System.UInt16                   busNo  // 0x18
  public            System.UInt16                   busId  // 0x1A
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: CategoryInfo
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.UInt32                   groupNo  // 0x10
  public            System.UInt32                   id  // 0x14
  public            System.String                   name  // 0x18
  public            System.UInt32                   numCueLimits  // 0x20
  public            System.Single                   volume  // 0x24
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: AcfAisacType
TYPE:  struct
TOKEN: 0x200006F
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  CriWare.CriAtomExAcf.AcfAisacTypenormal  // 0x0
  public    static  CriWare.CriAtomExAcf.AcfAisacTypeautoModulation  // 0x0
METHODS:
END_CLASS

CLASS: GlobalAisacInfo
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            System.String                   name  // 0x10
  public            System.UInt16                   index  // 0x18
  public            System.UInt16                   numGraphs  // 0x1A
  public            CriWare.CriAtomExAcf.AcfAisacTypetype  // 0x1C
  public            System.Single                   randomRange  // 0x20
  public            System.UInt16                   controlId  // 0x24
  public            System.UInt16                   dummy  // 0x26
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: AisacGraphType
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExAcf.AisacGraphTypenone  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypevolume  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypepitch  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebandpassHigh  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebandpassLow  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebiquadFreq  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebiquadQ  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebusSend0  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebusSend1  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebusSend2  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebusSend3  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebusSend4  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebusSend5  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebusSend6  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebusSend7  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypepan3dAngel  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypepan3dVolume  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypepan3dInteriorDistance  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypepan3dCenter  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypepan3dLfe  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac0  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac1  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac2  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac3  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac4  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac5  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac6  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac7  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac8  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac9  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac10  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac11  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac12  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac13  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac14  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeaisac15  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypepriority  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypepreDelayTime  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypebiquadGain  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypepan3dMixdownCenter  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypepan3dMixdownLfe  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeegAttack  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeegRelease  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypeplaybackRatio  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypedrySendL  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypedrySendR  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypedrySendCenter  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypedrySendLfe  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypedrySendSl  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypedrySendSr  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypedrySendEx1  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypedrySendEx2  // 0x0
  public    static  CriWare.CriAtomExAcf.AisacGraphTypepanSpread  // 0x0
METHODS:
END_CLASS

CLASS: AisacGraphInfo
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            CriWare.CriAtomExAcf.AisacGraphTypetype  // 0x10
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: CharacterEncoding
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  CriWare.CriAtomExAcf.CharacterEncodingutf8  // 0x0
  public    static  CriWare.CriAtomExAcf.CharacterEncodingsjis  // 0x0
METHODS:
END_CLASS

CLASS: AcfInfo
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            System.String                   name  // 0x10
  public            System.UInt32                   size  // 0x18
  public            System.UInt32                   version  // 0x1C
  public            CriWare.CriAtomExAcf.CharacterEncodingcharacterEncoding  // 0x20
  public            System.Int32                    numDspSettings  // 0x24
  public            System.Int32                    numCategories  // 0x28
  public            System.Int32                    numCategoriesPerPlayback  // 0x2C
  public            System.Int32                    numReacts  // 0x30
  public            System.Int32                    numAisacControls  // 0x34
  public            System.Int32                    numGlobalAisacs  // 0x38
  public            System.Int32                    numGameVariables  // 0x3C
  public            System.Int32                    maxBusesOfDspBusSettings  // 0x40
  public            System.Int32                    numBuses  // 0x44
  public            System.Int32                    numVoiceLimitGroups  // 0x48
  public            System.Int32                    numOutputPorts  // 0x4C
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: SelectorInfo
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  public            System.String                   name  // 0x10
  public            System.UInt16                   index  // 0x18
  public            System.UInt16                   numLabels  // 0x1A
  public            System.UInt16                   globalLabelIndex  // 0x1C
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: SelectorLabelInfo
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  public            System.String                   selectorName  // 0x10
  public            System.String                   labelName  // 0x18
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: SpeakerMapping
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExAsrRack.SpeakerMappingAuto  // 0x0
  public    static  CriWare.CriAtomExAsrRack.SpeakerMappingMonaural  // 0x0
  public    static  CriWare.CriAtomExAsrRack.SpeakerMappingStereo  // 0x0
  public    static  CriWare.CriAtomExAsrRack.SpeakerMappingCh5_1  // 0x0
  public    static  CriWare.CriAtomExAsrRack.SpeakerMappingCh7_1  // 0x0
  public    static  CriWare.CriAtomExAsrRack.SpeakerMappingCh5_1_2  // 0x0
  public    static  CriWare.CriAtomExAsrRack.SpeakerMappingCh7_1_4  // 0x0
METHODS:
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  public            System.Single                   serverFrequency  // 0x10
  public            System.Int32                    numBuses  // 0x14
  public            System.Int32                    outputChannels  // 0x18
  public            CriWare.CriAtomExAsrRack.SpeakerMappingspeakerMapping  // 0x1C
  public            System.Int32                    outputSamplingRate  // 0x20
  public            CriWare.CriAtomEx.SoundRendererTypesoundRendererType  // 0x24
  public            System.Int32                    outputRackId  // 0x28
  public            System.IntPtr                   context  // 0x30
METHODS:
END_CLASS

CLASS: PlatformConfig
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public            System.Byte                     reserved  // 0x10
METHODS:
END_CLASS

CLASS: PerformanceInfo
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            System.UInt32                   processCount  // 0x10
  public            System.UInt32                   lastProcessTime  // 0x14
  public            System.UInt32                   maxProcessTime  // 0x18
  public            System.UInt32                   averageProcessTime  // 0x1C
  public            System.UInt32                   lastProcessInterval  // 0x20
  public            System.UInt32                   maxProcessInterval  // 0x24
  public            System.UInt32                   averageProcessInterval  // 0x28
  public            System.UInt32                   lastProcessSamples  // 0x2C
  public            System.UInt32                   maxProcessSamples  // 0x30
  public            System.UInt32                   averageProcessSamples  // 0x34
METHODS:
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  public            System.Int32                    maxChannels  // 0x10
  public            System.Int32                    maxSamplingRate  // 0x14
  public            CriWare.CriAtomEx.SoundRendererTypesoundRendererType  // 0x18
METHODS:
  CriWare.CriAtomExAuxIn.Config get_Default()
END_CLASS

CLASS: DeviceInfo
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  public            System.String                   deviceId  // 0x10
  public            System.String                   deviceName  // 0x18
  public            System.UInt32                   deviceFlags  // 0x20
  public            System.Int32                    maxChannels  // 0x24
  public            System.Int32                    maxSamplingRate  // 0x28
METHODS:
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x2000080
FIELDS:
  public            System.String                   deviceId  // 0x10
  public            System.UInt32                   flags  // 0x18
  public            System.Int32                    numChannels  // 0x1C
  public            System.Int32                    samplingRate  // 0x20
  public            System.UInt32                   frameSize  // 0x24
  public            System.UInt32                   bufferingTime  // 0x28
  public            System.IntPtr                   context  // 0x30
METHODS:
  CriWare.CriAtomExMic.Config get_Default()
END_CLASS

CLASS: Effect
TYPE:  class
TOKEN: 0x2000081
FIELDS:
  private           System.IntPtr                   <handle>k__BackingField  // 0x10
  private           System.IntPtr                   <afxInstance>k__BackingField  // 0x18
METHODS:
  System.IntPtr get_handle()
  System.Void set_handle(System.IntPtr value)
  System.IntPtr get_afxInstance()
  System.Void set_afxInstance(System.IntPtr value)
  System.Void .ctor(System.IntPtr handle, System.IntPtr afxInstance)
END_CLASS

CLASS: PcmCaptureCallback
TYPE:  class
TOKEN: 0x2000083
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Single[] dataL, System.Single[] dataR, System.Int32 numChannels, System.Int32 numData)
  System.IAsyncResult BeginInvoke(System.Single[] dataL, System.Single[] dataR, System.Int32 numChannels, System.Int32 numData, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            System.Boolean                  enableLevelmeter  // 0x10
  public            System.Boolean                  enableSpectrumAnalyzer  // 0x11
  public            System.Boolean                  enablePcmCapture  // 0x12
  public            System.Boolean                  enablePcmCaptureCallback  // 0x13
  public            System.Int32                    numSpectrumAnalyzerBands  // 0x14
  public            System.Int32                    numCapturedPcmSamples  // 0x18
METHODS:
END_CLASS

CLASS: InternalPcmCaptureCallback
TYPE:  class
TOKEN: 0x2000085
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.IntPtr dataL, System.IntPtr dataR, System.Int32 numChannels, System.Int32 numData)
  System.IAsyncResult BeginInvoke(System.IntPtr dataL, System.IntPtr dataR, System.Int32 numChannels, System.Int32 numData, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExPlayback.StatusPrep  // 0x0
  public    static  CriWare.CriAtomExPlayback.StatusPlaying  // 0x0
  public    static  CriWare.CriAtomExPlayback.StatusRemoved  // 0x0
METHODS:
END_CLASS

CLASS: TrackInfo
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.UInt32                   id  // 0x10
  public            CriWare.CriAtomEx.CueType       sequenceType  // 0x14
  public            System.IntPtr                   playerHn  // 0x18
  public            System.UInt16                   trackNo  // 0x20
  public            System.UInt16                   reserved  // 0x22
METHODS:
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExPlayer.Status  Stop  // 0x0
  public    static  CriWare.CriAtomExPlayer.Status  Prep  // 0x0
  public    static  CriWare.CriAtomExPlayer.Status  Playing  // 0x0
  public    static  CriWare.CriAtomExPlayer.Status  PlayEnd  // 0x0
  public    static  CriWare.CriAtomExPlayer.Status  Error  // 0x0
METHODS:
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            CriWare.CriAtomEx.VoiceAllocationMethodvoiceAllocationMethod  // 0x10
  public            System.Int32                    maxPathStrings  // 0x14
  public            System.Int32                    maxPath  // 0x18
  public            System.Int32                    maxAisacs  // 0x1C
  public            System.Boolean                  updatesTime  // 0x20
  public            System.Boolean                  enableAudioSyncedTimer  // 0x21
METHODS:
END_CLASS

CLASS: TimeStretchParameterId
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExPlayer.TimeStretchParameterIdRatio  // 0x0
  public    static  CriWare.CriAtomExPlayer.TimeStretchParameterIdFrameTime  // 0x0
  public    static  CriWare.CriAtomExPlayer.TimeStretchParameterIdQuality  // 0x0
METHODS:
END_CLASS

CLASS: PitchShifterParameterId
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExPlayer.PitchShifterParameterIdPitch  // 0x0
  public    static  CriWare.CriAtomExPlayer.PitchShifterParameterIdFormant  // 0x0
  public    static  CriWare.CriAtomExPlayer.PitchShifterParameterIdMode  // 0x0
METHODS:
END_CLASS

CLASS: Type
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExPlayerOutputAnalyzer.TypeLevelMeter  // 0x0
  public    static  CriWare.CriAtomExPlayerOutputAnalyzer.TypeSpectrumAnalyzer  // 0x0
  public    static  CriWare.CriAtomExPlayerOutputAnalyzer.TypePcmCapture  // 0x0
METHODS:
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            System.Int32                    num_spectrum_analyzer_bands  // 0x10
  public            System.Int32                    num_stored_output_data  // 0x14
METHODS:
  System.Void .ctor(System.Int32 num_spectrum_analyzer_bands, System.Int32 num_stored_output_data)
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
  public            System.Boolean                  enableVoiceLimitScope  // 0x10
  public            System.Boolean                  enableCategoryCueLimitScope  // 0x11
METHODS:
END_CLASS

CLASS: ParameterType
TYPE:  struct
TOKEN: 0x2000094
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExTween.ParameterTypeBasic  // 0x0
  public    static  CriWare.CriAtomExTween.ParameterTypeAisac  // 0x0
METHODS:
END_CLASS

CLASS: Target
TYPE:  struct
TOKEN: 0x2000096
FIELDS:
  public            CriWare.CriAtomEx.Parameter     parameterId  // 0x10
  public            System.UInt32                   aisacIds  // 0x10
METHODS:
END_CLASS

CLASS: Config
TYPE:  struct
TOKEN: 0x2000095
FIELDS:
  public            CriWare.CriAtomExTween.Config.Targettarget  // 0x10
  public            CriWare.CriAtomExTween.ParameterTypeparameterType  // 0x14
METHODS:
END_CLASS

CLASS: VoicePoolId
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExVoicePool.VoicePoolIdStandardMemory  // 0x0
  public    static  CriWare.CriAtomExVoicePool.VoicePoolIdStandardStreaming  // 0x0
  public    static  CriWare.CriAtomExVoicePool.VoicePoolIdHcaMxMemory  // 0x0
  public    static  CriWare.CriAtomExVoicePool.VoicePoolIdHcaMxStreaming  // 0x0
METHODS:
END_CLASS

CLASS: PitchShifterMode
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExVoicePool.PitchShifterModeMusic  // 0x0
  public    static  CriWare.CriAtomExVoicePool.PitchShifterModeVocal  // 0x0
  public    static  CriWare.CriAtomExVoicePool.PitchShifterModeSoundEffect  // 0x0
  public    static  CriWare.CriAtomExVoicePool.PitchShifterModeSpeech  // 0x0
METHODS:
END_CLASS

CLASS: UsedVoicesInfo
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            System.Int32                    numUsedVoices  // 0x10
  public            System.Int32                    numPoolVoices  // 0x14
METHODS:
END_CLASS

CLASS: PlayerConfig
TYPE:  struct
TOKEN: 0x200009B
FIELDS:
  public            System.Int32                    maxChannels  // 0x10
  public            System.Int32                    maxSamplingRate  // 0x14
  public            System.Boolean                  streamingFlag  // 0x18
  public            System.Int32                    soundRendererType  // 0x1C
  public            System.Int32                    decodeLatency  // 0x20
  private           System.IntPtr                   context  // 0x28
METHODS:
END_CLASS

CLASS: VoicePoolConfig
TYPE:  struct
TOKEN: 0x200009C
FIELDS:
  public            System.UInt32                   identifier  // 0x10
  public            System.Int32                    numVoices  // 0x14
  public            CriWare.CriAtomExVoicePool.PlayerConfigplayerConfig  // 0x18
METHODS:
END_CLASS

CLASS: PitchShifterConfig
TYPE:  struct
TOKEN: 0x200009D
FIELDS:
  public            System.Int32                    mode  // 0x10
  public            System.Int32                    windowSize  // 0x14
  public            System.Int32                    overlapTimes  // 0x18
METHODS:
END_CLASS

CLASS: ExPitchShifterConfig
TYPE:  struct
TOKEN: 0x200009E
FIELDS:
  public            System.Int32                    numDsp  // 0x10
  public            System.Int32                    maxChannels  // 0x14
  public            System.Int32                    maxSamplingRate  // 0x18
  public            CriWare.CriAtomExVoicePool.PitchShifterConfigconfig  // 0x1C
METHODS:
END_CLASS

CLASS: TimeStretchConfig
TYPE:  struct
TOKEN: 0x200009F
FIELDS:
  public            System.Int32                    reserved  // 0x10
METHODS:
END_CLASS

CLASS: ExTimeStretchConfig
TYPE:  struct
TOKEN: 0x20000A0
FIELDS:
  public            System.Int32                    numDsp  // 0x10
  public            System.Int32                    maxChannels  // 0x14
  public            System.Int32                    maxSamplingRate  // 0x18
  public            CriWare.CriAtomExVoicePool.TimeStretchConfigconfig  // 0x1C
METHODS:
END_CLASS

CLASS: RawPcmFormat
TYPE:  struct
TOKEN: 0x20000A4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExRawPcmVoicePool.RawPcmFormatSint16  // 0x0
  public    static  CriWare.CriAtomExRawPcmVoicePool.RawPcmFormatFloat32  // 0x0
METHODS:
END_CLASS

CLASS: RawPcmPlayerConfig
TYPE:  struct
TOKEN: 0x20000A5
FIELDS:
  public            CriWare.CriAtomExRawPcmVoicePool.RawPcmFormatformat  // 0x10
  public            System.Int32                    maxChannels  // 0x14
  public            System.Int32                    maxSamplingRate  // 0x18
  public            System.Int32                    soundRendererType  // 0x1C
  public            System.Int32                    decodeLatency  // 0x20
  private           System.IntPtr                   context  // 0x28
METHODS:
END_CLASS

CLASS: RawPcmVoicePoolConfig
TYPE:  struct
TOKEN: 0x20000A6
FIELDS:
  public            System.UInt32                   identifier  // 0x10
  public            System.Int32                    numVoices  // 0x14
  public            CriWare.CriAtomExRawPcmVoicePool.RawPcmPlayerConfigplayerConfig  // 0x18
METHODS:
END_CLASS

CLASS: InternalDelegate
TYPE:  class
TOKEN: 0x20000A8
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.UInt32 Invoke(System.IntPtr cbobj, System.IntPtr data, System.UInt32 numSamples)
  System.IAsyncResult BeginInvoke(System.IntPtr cbobj, System.IntPtr data, System.UInt32 numSamples, System.AsyncCallback callback, System.Object object)
  System.UInt32 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Delegate
TYPE:  class
TOKEN: 0x20000A9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.UInt32 Invoke(System.Single[][] buffer, System.UInt32 numSamples)
  System.IAsyncResult BeginInvoke(System.Single[][] buffer, System.UInt32 numSamples, System.AsyncCallback callback, System.Object object)
  System.UInt32 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: InternalDelegate
TYPE:  class
TOKEN: 0x20000AC
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.UInt32 Invoke(System.IntPtr cbobj, System.IntPtr data, System.UInt32 numSamples)
  System.IAsyncResult BeginInvoke(System.IntPtr cbobj, System.IntPtr data, System.UInt32 numSamples, System.AsyncCallback callback, System.Object object)
  System.UInt32 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Delegate
TYPE:  class
TOKEN: 0x20000AD
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.UInt32 Invoke(System.Single[][] buffer, System.UInt32 numSamples)
  System.IAsyncResult BeginInvoke(System.Single[][] buffer, System.UInt32 numSamples, System.AsyncCallback callback, System.Object object)
  System.UInt32 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x20000B0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriFsLoader.Status      Stop  // 0x0
  public    static  CriWare.CriFsLoader.Status      Loading  // 0x0
  public    static  CriWare.CriFsLoader.Status      Complete  // 0x0
  public    static  CriWare.CriFsLoader.Status      Error  // 0x0
METHODS:
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x20000B2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriFsInstaller.Status   Stop  // 0x0
  public    static  CriWare.CriFsInstaller.Status   Busy  // 0x0
  public    static  CriWare.CriFsInstaller.Status   Complete  // 0x0
  public    static  CriWare.CriFsInstaller.Status   Error  // 0x0
METHODS:
END_CLASS

CLASS: CopyPolicy
TYPE:  struct
TOKEN: 0x20000B3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriFsInstaller.CopyPolicyAlways  // 0x0
METHODS:
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x20000B5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriFsBinder.Status      None  // 0x0
  public    static  CriWare.CriFsBinder.Status      Analyze  // 0x0
  public    static  CriWare.CriFsBinder.Status      Complete  // 0x0
  public    static  CriWare.CriFsBinder.Status      Unbind  // 0x0
  public    static  CriWare.CriFsBinder.Status      Removed  // 0x0
  public    static  CriWare.CriFsBinder.Status      Invalid  // 0x0
  public    static  CriWare.CriFsBinder.Status      Error  // 0x0
METHODS:
END_CLASS

CLASS: ContentsFileInfo
TYPE:  struct
TOKEN: 0x20000B6
FIELDS:
  public    readonly System.String                   directory  // 0x10
  public    readonly System.String                   fileName  // 0x18
  public            System.UInt32                   readSize  // 0x20
  public            System.UInt32                   extractSize  // 0x24
  public            System.UInt64                   offset  // 0x28
  public            System.Int32                    fileId  // 0x30
  private           System.String                   userStr  // 0x38
METHODS:
  System.Void .ctor(System.Byte[] data, System.Int32 startIndex)
END_CLASS

CLASS: DoneDelegate
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(CriWare.CriFsRequest request)
  System.IAsyncResult BeginInvoke(CriWare.CriFsRequest request, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Phase
TYPE:  struct
TOKEN: 0x20000BB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriFsLoadFileRequest.PhaseStop  // 0x0
  public    static  CriWare.CriFsLoadFileRequest.PhaseBind  // 0x0
  public    static  CriWare.CriFsLoadFileRequest.PhaseLoad  // 0x0
  public    static  CriWare.CriFsLoadFileRequest.PhaseDone  // 0x0
  public    static  CriWare.CriFsLoadFileRequest.PhaseError  // 0x0
METHODS:
END_CLASS

CLASS: BindType
TYPE:  struct
TOKEN: 0x20000C1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriFsBindRequest.BindTypeCpk  // 0x0
  public    static  CriWare.CriFsBindRequest.BindTypeDirectory  // 0x0
  public    static  CriWare.CriFsBindRequest.BindTypeFile  // 0x0
METHODS:
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x20000C6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriFsWebInstaller.StatusStop  // 0x0
  public    static  CriWare.CriFsWebInstaller.StatusBusy  // 0x0
  public    static  CriWare.CriFsWebInstaller.StatusComplete  // 0x0
  public    static  CriWare.CriFsWebInstaller.StatusError  // 0x0
METHODS:
END_CLASS

CLASS: Error
TYPE:  struct
TOKEN: 0x20000C7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriFsWebInstaller.Error None  // 0x0
  public    static  CriWare.CriFsWebInstaller.Error Timeout  // 0x0
  public    static  CriWare.CriFsWebInstaller.Error Memory  // 0x0
  public    static  CriWare.CriFsWebInstaller.Error LocalFs  // 0x0
  public    static  CriWare.CriFsWebInstaller.Error DNS  // 0x0
  public    static  CriWare.CriFsWebInstaller.Error Connection  // 0x0
  public    static  CriWare.CriFsWebInstaller.Error SSL  // 0x0
  public    static  CriWare.CriFsWebInstaller.Error HTTP  // 0x0
  public    static  CriWare.CriFsWebInstaller.Error Internal  // 0x0
METHODS:
END_CLASS

CLASS: StatusInfo
TYPE:  struct
TOKEN: 0x20000C8
FIELDS:
  public            CriWare.CriFsWebInstaller.Statusstatus  // 0x10
  public            CriWare.CriFsWebInstaller.Error error  // 0x14
  public            System.Int32                    httpStatusCode  // 0x18
  public            System.Int64                    contentsSize  // 0x20
  public            System.Int64                    receivedSize  // 0x28
METHODS:
END_CLASS

CLASS: ModuleConfig
TYPE:  struct
TOKEN: 0x20000C9
FIELDS:
  public            System.UInt32                   numInstallers  // 0x10
  public            System.String                   proxyHost  // 0x18
  public            System.UInt16                   proxyPort  // 0x20
  public            System.String                   userAgent  // 0x28
  public            System.UInt32                   inactiveTimeoutSec  // 0x30
  public            System.Boolean                  allowInsecureSSL  // 0x34
  public            System.Boolean                  crcEnabled  // 0x35
  public            CriWare.CriFsWebInstaller.ModulePlatformConfigplatformConfig  // 0x36
METHODS:
END_CLASS

CLASS: ModulePlatformConfig
TYPE:  struct
TOKEN: 0x20000CA
FIELDS:
  public            System.Byte                     reserved  // 0x10
METHODS:
  CriWare.CriFsWebInstaller.ModulePlatformConfig get_defaultConfig()
END_CLASS

CLASS: MaxFrameDrop
TYPE:  struct
TOKEN: 0x20000D1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropDisabled  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropOne  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropTwo  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropThree  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropFour  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropFive  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropSix  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropSeven  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropEight  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropNine  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropTen  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.MaxFrameDropInfinite  // 0x0
METHODS:
END_CLASS

CLASS: RenderMode
TYPE:  struct
TOKEN: 0x20000D2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriManaMovieMaterialBase.RenderModeAlways  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.RenderModeOnVisibility  // 0x0
  public    static  CriWare.CriManaMovieMaterialBase.RenderModeNever  // 0x0
METHODS:
END_CLASS

CLASS: OnApplicationPauseCallback
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(CriWare.CriManaMovieMaterialBase manaMovieMaterial, System.Boolean appPause)
  System.IAsyncResult BeginInvoke(CriWare.CriManaMovieMaterialBase manaMovieMaterial, System.Boolean appPause, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: CpuUsage
TYPE:  struct
TOKEN: 0x20000D8
FIELDS:
  public            System.Single                   last  // 0x10
  public            System.Single                   average  // 0x14
  public            System.Single                   peak  // 0x18
METHODS:
END_CLASS

CLASS: CallbackFromNativeDelegate
TYPE:  class
TOKEN: 0x20000DA
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.UInt64 Invoke(System.IntPtr ptr1)
  System.IAsyncResult BeginInvoke(System.IntPtr ptr1, System.AsyncCallback callback, System.Object object)
  System.UInt64 EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Callback
TYPE:  class
TOKEN: 0x20000DC
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String message)
  System.IAsyncResult BeginInvoke(System.String message, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Callback
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String message)
  System.IAsyncResult BeginInvoke(System.String message, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ErrorCallbackFunc
TYPE:  class
TOKEN: 0x20000DF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.IntPtr errmsgPtr, System.UInt32 p1, System.UInt32 p2, System.IntPtr parray)
  System.IAsyncResult BeginInvoke(System.IntPtr errmsgPtr, System.UInt32 p1, System.UInt32 p2, System.IntPtr parray, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: NativeMethod
TYPE:  class
TOKEN: 0x20000E0
FIELDS:
METHODS:
  System.Void criErr_SetCallback(CriWare.CriErrorNotifier.ErrorCallbackFunc callback)
  System.IntPtr criErr_ConvertIdToMessage(System.IntPtr errmsgPtr, System.UInt32 p1, System.UInt32 p2)
END_CLASS

CLASS: StandardVoicePoolConfig
TYPE:  class
TOKEN: 0x20000E3
FIELDS:
  public            System.Int32                    memoryVoices  // 0x10
  public            System.Int32                    streamingVoices  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HcaMxVoicePoolConfig
TYPE:  class
TOKEN: 0x20000E4
FIELDS:
  public            System.Int32                    memoryVoices  // 0x10
  public            System.Int32                    streamingVoices  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: InGamePreviewSwitchMode
TYPE:  struct
TOKEN: 0x20000E5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomConfig.InGamePreviewSwitchModeDisable  // 0x0
  public    static  CriWare.CriAtomConfig.InGamePreviewSwitchModeEnable  // 0x0
  public    static  CriWare.CriAtomConfig.InGamePreviewSwitchModeFollowBuildSetting  // 0x0
  public    static  CriWare.CriAtomConfig.InGamePreviewSwitchModeDefault  // 0x0
METHODS:
END_CLASS

CLASS: InGamePreviewConfig
TYPE:  class
TOKEN: 0x20000E6
FIELDS:
  public            System.Int32                    maxPreviewObjects  // 0x10
  public            System.Int32                    communicationBufferSize  // 0x14
  public            System.Int32                    playbackPositionUpdateInterval  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: EditorPcmOutputConfig
TYPE:  class
TOKEN: 0x20000E7
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Int32                    bufferLength  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: LinuxOutput
TYPE:  struct
TOKEN: 0x20000E8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomConfig.LinuxOutputDefault  // 0x0
  public    static  CriWare.CriAtomConfig.LinuxOutputPulseAudio  // 0x0
  public    static  CriWare.CriAtomConfig.LinuxOutputALSA  // 0x0
METHODS:
END_CLASS

CLASS: AndroidLowLatencyStandardVoicePoolConfig
TYPE:  class
TOKEN: 0x20000E9
FIELDS:
  public            System.Int32                    memoryVoices  // 0x10
  public            System.Int32                    streamingVoices  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VitaManaVoicePoolConfig
TYPE:  class
TOKEN: 0x20000EA
FIELDS:
  public            System.Int32                    numberOfManaDecoders  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VitaAtrac9VoicePoolConfig
TYPE:  class
TOKEN: 0x20000EB
FIELDS:
  public            System.Int32                    memoryVoices  // 0x10
  public            System.Int32                    streamingVoices  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Ps4Atrac9VoicePoolConfig
TYPE:  class
TOKEN: 0x20000EC
FIELDS:
  public            System.Int32                    memoryVoices  // 0x10
  public            System.Int32                    streamingVoices  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Ps5PortConfig
TYPE:  class
TOKEN: 0x20000ED
FIELDS:
  public            System.Int32                    maxChannelPorts  // 0x10
  public            System.Int32                    maxObjectPorts  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SwitchOpusVoicePoolConfig
TYPE:  class
TOKEN: 0x20000EE
FIELDS:
  public            System.Int32                    memoryVoices  // 0x10
  public            System.Int32                    streamingVoices  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VoicePoolConfig
TYPE:  class
TOKEN: 0x20000F0
FIELDS:
  public            System.Int32                    memoryVoices  // 0x10
  public            System.Int32                    streamingVoices  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Ps4Audio3dConfig
TYPE:  class
TOKEN: 0x20000EF
FIELDS:
  public            System.Boolean                  useAudio3D  // 0x10
  public            CriWare.CriAtomConfig.Ps4Audio3dConfig.VoicePoolConfigvoicePoolConfig  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: WebGLWebAudioVoicePoolConfig
TYPE:  class
TOKEN: 0x20000F1
FIELDS:
  public            System.Int32                    voices  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PCH264PlaybackConfig
TYPE:  class
TOKEN: 0x20000F3
FIELDS:
  public            System.Boolean                  useH264Playback  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VitaH264PlaybackConfig
TYPE:  class
TOKEN: 0x20000F4
FIELDS:
  public            System.Boolean                  useH264Playback  // 0x10
  public            System.Int32                    maxWidth  // 0x14
  public            System.Int32                    maxHeight  // 0x18
  public            System.Boolean                  getMemoryFromTexture  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: WebGLConfig
TYPE:  class
TOKEN: 0x20000F5
FIELDS:
  public            System.String                   webworkerPath  // 0x10
  public            System.Int32                    heapSize  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ResourcesInfo
TYPE:  struct
TOKEN: 0x20000F9
FIELDS:
  public            CriWare.CriAtomEx.ResourceUsage virtualVoiceUsage  // 0x10
  public            CriWare.CriAtomEx.ResourceUsage sequenceUsage  // 0x18
  public            CriWare.CriAtomEx.ResourceUsage sequenceTrackUsage  // 0x20
  public            CriWare.CriAtomEx.ResourceUsage sequenceTrackItemUsage  // 0x28
METHODS:
END_CLASS

CLASS: CategoryInfo
TYPE:  struct
TOKEN: 0x20000FB
FIELDS:
  public            System.UInt32                   groupNo  // 0x10
  public            System.UInt32                   id  // 0x14
  public            System.String                   name  // 0x18
  public            System.UInt32                   numCueLimits  // 0x20
  public            System.Single                   volume  // 0x24
METHODS:
END_CLASS

CLASS: DspBusInfo
TYPE:  struct
TOKEN: 0x20000FC
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Single                   volume  // 0x18
  public            System.Single                   pan3dVolume  // 0x1C
  public            System.Single                   pan3dAngle  // 0x20
  public            System.Single                   pan3dDistance  // 0x24
  public            System.Single                   pan3dSpread  // 0x28
  public            System.UInt16[]                 fxIndexes  // 0x30
  public            System.UInt16[]                 busLinkIndexes  // 0x38
  public            System.UInt16                   busNo  // 0x40
  public            System.Byte                     numFxes  // 0x42
  public            System.Byte                     numBusLinks  // 0x43
METHODS:
END_CLASS

CLASS: AisacControlInfo
TYPE:  struct
TOKEN: 0x20000FD
FIELDS:
  public            System.String                   name  // 0x10
  public            System.UInt32                   id  // 0x18
METHODS:
END_CLASS

CLASS: AisacType
TYPE:  struct
TOKEN: 0x20000FE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriAtomExAcfDebug.AisacTypeNormal  // 0x0
  public    static  CriWare.CriAtomExAcfDebug.AisacTypeAutoModulation  // 0x0
METHODS:
END_CLASS

CLASS: GlobalAisacInfo
TYPE:  struct
TOKEN: 0x20000FF
FIELDS:
  public            System.String                   name  // 0x10
  public            System.UInt16                   index  // 0x18
  public            System.UInt16                   numGraphs  // 0x1A
  public            CriWare.CriAtomExAcfDebug.AisacTypetype  // 0x1C
  public            System.Single                   randomRange  // 0x20
  public            System.UInt16                   controlId  // 0x24
METHODS:
END_CLASS

CLASS: SelectorInfo
TYPE:  struct
TOKEN: 0x2000100
FIELDS:
  public            System.String                   name  // 0x10
  public            System.UInt16                   index  // 0x18
  public            System.UInt16                   numLabels  // 0x1A
  public            System.UInt16                   globalLabelIndex  // 0x1C
METHODS:
END_CLASS

CLASS: SelectorLabelInfo
TYPE:  struct
TOKEN: 0x2000101
FIELDS:
  public            System.String                   selectorName  // 0x10
  public            System.String                   labelName  // 0x18
METHODS:
END_CLASS

CLASS: CategoryInfoForMarshaling
TYPE:  struct
TOKEN: 0x2000102
FIELDS:
  public            System.UInt32                   groupNo  // 0x10
  public            System.UInt32                   id  // 0x14
  public            System.IntPtr                   namePtr  // 0x18
  public            System.UInt32                   numCueLimits  // 0x20
  public            System.Single                   volume  // 0x24
METHODS:
  System.Void Convert(CriWare.CriAtomExAcfDebug.CategoryInfo& x)
END_CLASS

CLASS: DspBusInfoForMarshaling
TYPE:  struct
TOKEN: 0x2000103
FIELDS:
  public            System.IntPtr                   namePtr  // 0x10
  public            System.Single                   volume  // 0x18
  public            System.Single                   pan3dVolume  // 0x1C
  public            System.Single                   pan3dAngle  // 0x20
  public            System.Single                   pan3dDistance  // 0x24
  public            System.Single                   pan3dSpread  // 0x28
  public            System.UInt16[]                 fxIndexes  // 0x30
  public            System.UInt16[]                 busLinkIndexes  // 0x38
  public            System.UInt16                   busNo  // 0x40
  public            System.Byte                     numFxes  // 0x42
  public            System.Byte                     numBusLinks  // 0x43
METHODS:
  System.Void Convert(CriWare.CriAtomExAcfDebug.DspBusInfo& x)
END_CLASS

CLASS: AisacControlInfoForMarshaling
TYPE:  struct
TOKEN: 0x2000104
FIELDS:
  public            System.IntPtr                   namePtr  // 0x10
  public            System.UInt32                   id  // 0x18
METHODS:
  System.Void Convert(CriWare.CriAtomExAcfDebug.AisacControlInfo& x)
END_CLASS

CLASS: GlobalAisacInfoForMarshaling
TYPE:  struct
TOKEN: 0x2000105
FIELDS:
  public            System.IntPtr                   namePtr  // 0x10
  public            System.UInt16                   index  // 0x18
  public            System.UInt16                   numGraphs  // 0x1A
  public            System.UInt32                   type  // 0x1C
  public            System.Single                   randomRange  // 0x20
  public            System.UInt16                   controlId  // 0x24
  public            System.UInt16                   dummy  // 0x26
METHODS:
  System.Void Convert(CriWare.CriAtomExAcfDebug.GlobalAisacInfo& x)
END_CLASS

CLASS: SelectorInfoForMarshaling
TYPE:  struct
TOKEN: 0x2000106
FIELDS:
  public            System.IntPtr                   namePtr  // 0x10
  public            System.UInt16                   index  // 0x18
  public            System.UInt16                   numLabels  // 0x1A
  public            System.UInt16                   globalLabelIndex  // 0x1C
METHODS:
  System.Void Convert(CriWare.CriAtomExAcfDebug.SelectorInfo& x)
END_CLASS

CLASS: SelectorLabelInfoForMarshaling
TYPE:  struct
TOKEN: 0x2000107
FIELDS:
  public            System.IntPtr                   selectorNamePtr  // 0x10
  public            System.IntPtr                   labelNamePtr  // 0x18
METHODS:
  System.Void Convert(CriWare.CriAtomExAcfDebug.SelectorLabelInfo& x)
END_CLASS

CLASS: AcbInfo
TYPE:  struct
TOKEN: 0x2000109
FIELDS:
  public            System.String                   name  // 0x10
  public            System.UInt32                   size  // 0x18
  public            System.UInt32                   version  // 0x1C
  public            CriWare.CriAtomEx.CharacterEncodingcharacterEncoding  // 0x20
  public            System.Single                   volume  // 0x24
  public            System.Int32                    numCues  // 0x28
METHODS:
END_CLASS

CLASS: AcbInfoForMarshaling
TYPE:  struct
TOKEN: 0x200010A
FIELDS:
  public            System.IntPtr                   namePtr  // 0x10
  public            System.UInt32                   size  // 0x18
  public            System.UInt32                   version  // 0x1C
  public            CriWare.CriAtomEx.CharacterEncodingcharacterEncoding  // 0x20
  public            System.Single                   volume  // 0x24
  public            System.Int32                    numCues  // 0x28
METHODS:
  System.Void Convert(CriWare.CriAtomExAcbDebug.AcbInfo& x)
END_CLASS

CLASS: ModuleType
TYPE:  struct
TOKEN: 0x200010E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriDisposableObjectManager.ModuleTypeAtom  // 0x0
  public    static  CriWare.CriDisposableObjectManager.ModuleTypeAtomMic  // 0x0
  public    static  CriWare.CriDisposableObjectManager.ModuleTypeFs  // 0x0
  public    static  CriWare.CriDisposableObjectManager.ModuleTypeFsWeb  // 0x0
  public    static  CriWare.CriDisposableObjectManager.ModuleTypeMana  // 0x0
  public    static  CriWare.CriDisposableObjectManager.ModuleTypeLips  // 0x0
  public    static  CriWare.CriDisposableObjectManager.ModuleTypeVip  // 0x0
  public    static  CriWare.CriDisposableObjectManager.ModuleTypeRtc  // 0x0
METHODS:
END_CLASS

CLASS: ObjectRef
TYPE:  struct
TOKEN: 0x200010F
FIELDS:
  public            System.Guid                     guid  // 0x10
  public            CriWare.CriDisposableObjectManager.ModuleTypetype  // 0x20
  public            CriWare.CriDisposable           disposable  // 0x28
METHODS:
  System.Void .ctor(System.Guid _guid, CriWare.CriDisposable _disposable, CriWare.CriDisposableObjectManager.ModuleType _type)
END_CLASS

CLASS: MovieInfoStruct
TYPE:  struct
TOKEN: 0x2000116
FIELDS:
  public            System.UInt32                   width  // 0x10
  public            System.UInt32                   height  // 0x14
  public            System.UInt32                   dispWidth  // 0x18
  public            System.UInt32                   dispHeight  // 0x1C
  public            System.UInt32                   framerateN  // 0x20
  public            System.UInt32                   framerateD  // 0x24
  public            System.UInt32                   totalFrames  // 0x28
  public            CriWare.CriMana.CodecType       _codecType  // 0x2C
  public            CriWare.CriMana.CodecType       _alphaCodecType  // 0x30
METHODS:
END_CLASS

CLASS: MovieMixerState
TYPE:  struct
TOKEN: 0x2000118
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerStatePreloading  // 0x0
  public    static  CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerStateReady  // 0x0
  public    static  CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerStatePlaying  // 0x0
  public    static  CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerStateStopping  // 0x0
  public    static  CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerStateStopped  // 0x0
METHODS:
END_CLASS

CLASS: ClipState
TYPE:  struct
TOKEN: 0x2000119
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriTimeline.Mana.CriManaMixerBehaviour.ClipStateIdle  // 0x0
  public    static  CriWare.CriTimeline.Mana.CriManaMixerBehaviour.ClipStatePrepare  // 0x0
  public    static  CriWare.CriTimeline.Mana.CriManaMixerBehaviour.ClipStatePlay  // 0x0
  public    static  CriWare.CriTimeline.Mana.CriManaMixerBehaviour.ClipStateSeek  // 0x0
METHODS:
END_CLASS

CLASS: PlayerSource
TYPE:  struct
TOKEN: 0x2000123
FIELDS:
  public    readonly CriWare.CriAtomExPlayer         player  // 0x10
  public    readonly CriWare.CriAtomEx3dSource       source3d  // 0x18
METHODS:
  System.Void .ctor(CriWare.CriAtomEx3dListener listener)
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x200012D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriMana.Player.Status   Stop  // 0x0
  public    static  CriWare.CriMana.Player.Status   Dechead  // 0x0
  public    static  CriWare.CriMana.Player.Status   WaitPrep  // 0x0
  public    static  CriWare.CriMana.Player.Status   Prep  // 0x0
  public    static  CriWare.CriMana.Player.Status   Ready  // 0x0
  public    static  CriWare.CriMana.Player.Status   Playing  // 0x0
  public    static  CriWare.CriMana.Player.Status   PlayEnd  // 0x0
  public    static  CriWare.CriMana.Player.Status   Error  // 0x0
  public    static  CriWare.CriMana.Player.Status   StopProcessing  // 0x0
  public    static  CriWare.CriMana.Player.Status   ReadyForRendering  // 0x0
METHODS:
END_CLASS

CLASS: SetMode
TYPE:  struct
TOKEN: 0x200012E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriMana.Player.SetMode  New  // 0x0
  public    static  CriWare.CriMana.Player.SetMode  Append  // 0x0
  public    static  CriWare.CriMana.Player.SetMode  AppendRepeatedly  // 0x0
METHODS:
END_CLASS

CLASS: MovieEventSyncMode
TYPE:  struct
TOKEN: 0x200012F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriMana.Player.MovieEventSyncModeFrameTime  // 0x0
  public    static  CriWare.CriMana.Player.MovieEventSyncModePlayBackTime  // 0x0
METHODS:
END_CLASS

CLASS: AudioTrack
TYPE:  struct
TOKEN: 0x2000130
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriMana.Player.AudioTrackOff  // 0x0
  public    static  CriWare.CriMana.Player.AudioTrackAuto  // 0x0
METHODS:
END_CLASS

CLASS: TimerType
TYPE:  struct
TOKEN: 0x2000131
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriMana.Player.TimerTypeNone  // 0x0
  public    static  CriWare.CriMana.Player.TimerTypeSystem  // 0x0
  public    static  CriWare.CriMana.Player.TimerTypeAudio  // 0x0
  public    static  CriWare.CriMana.Player.TimerTypeUser  // 0x0
  public    static  CriWare.CriMana.Player.TimerTypeManual  // 0x0
METHODS:
END_CLASS

CLASS: CuePointCallback
TYPE:  class
TOKEN: 0x2000132
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(CriWare.CriMana.EventPoint& eventPoint)
  System.IAsyncResult BeginInvoke(CriWare.CriMana.EventPoint& eventPoint, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(CriWare.CriMana.EventPoint& eventPoint, System.IAsyncResult result)
END_CLASS

CLASS: StatusChangeCallback
TYPE:  class
TOKEN: 0x2000133
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(CriWare.CriMana.Player.Status status)
  System.IAsyncResult BeginInvoke(CriWare.CriMana.Player.Status status, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: SubtitleChangeCallback
TYPE:  class
TOKEN: 0x2000134
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.IntPtr subtitleBuffer)
  System.IAsyncResult BeginInvoke(System.IntPtr subtitleBuffer, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ShaderDispatchCallback
TYPE:  class
TOKEN: 0x2000135
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.Shader Invoke(CriWare.CriMana.MovieInfo movieInfo, System.Boolean additiveMode)
  System.IAsyncResult BeginInvoke(CriWare.CriMana.MovieInfo movieInfo, System.Boolean additiveMode, System.AsyncCallback callback, System.Object object)
  UnityEngine.Shader EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: CuePointCallbackFromNativeDelegate
TYPE:  class
TOKEN: 0x2000136
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.IntPtr ptr1, System.IntPtr ptr2, CriWare.CriMana.EventPoint& eventPoint)
  System.IAsyncResult BeginInvoke(System.IntPtr ptr1, System.IntPtr ptr2, CriWare.CriMana.EventPoint& eventPoint, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(CriWare.CriMana.EventPoint& eventPoint, System.IAsyncResult result)
END_CLASS

CLASS: CriManaUnityPlayer_RenderEventAction
TYPE:  struct
TOKEN: 0x2000137
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriMana.Player.CriManaUnityPlayer_RenderEventActionUPDATE  // 0x0
  public    static  CriWare.CriMana.Player.CriManaUnityPlayer_RenderEventActionINITIALIZE  // 0x0
  public    static  CriWare.CriMana.Player.CriManaUnityPlayer_RenderEventActionRENDER  // 0x0
  public    static  CriWare.CriMana.Player.CriManaUnityPlayer_RenderEventActionDESTROY  // 0x0
METHODS:
END_CLASS

CLASS: OperationType
TYPE:  struct
TOKEN: 0x2000138
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriMana.Player.OperationTypeNormal  // 0x0
  public    static  CriWare.CriMana.Player.OperationTypeSetFile  // 0x0
  public    static  CriWare.CriMana.Player.OperationTypeSeekToTime  // 0x0
  public    static  CriWare.CriMana.Player.OperationTypePause  // 0x0
METHODS:
END_CLASS

CLASS: Operation
TYPE:  struct
TOKEN: 0x2000139
FIELDS:
  public            CriWare.CriMana.Player.OperationTypeopType  // 0x10
  public            CriWare.CriMana.Player.Status   targetStatus  // 0x14
  public            System.Boolean                  isStopForSeek  // 0x18
  public            CriWare.CriFsBinder             binder  // 0x20
  public            System.String                   moviePath  // 0x28
  public            CriWare.CriMana.Player.SetMode  setMode  // 0x30
  public            System.Single                   timeToSeek  // 0x34
  public            System.Boolean                  sw  // 0x38
METHODS:
  CriWare.CriMana.Player.Operation Start()
  CriWare.CriMana.Player.Operation Pause(System.Boolean sw)
  CriWare.CriMana.Player.Operation Stop()
  CriWare.CriMana.Player.Operation StopForSeek()
  CriWare.CriMana.Player.Operation Prepare()
  CriWare.CriMana.Player.Operation PrepareForRendering()
  CriWare.CriMana.Player.Operation SetFile(CriWare.CriFsBinder binder, System.String moviePath, CriWare.CriMana.Player.SetMode setMode)
  CriWare.CriMana.Player.Operation SeekToTime(System.Single time)
END_CLASS

CLASS: RendererResourceFactoryH264Yuv
TYPE:  class
TOKEN: 0x200013C
EXTENDS: RendererResourceFactory
FIELDS:
METHODS:
  CriWare.CriMana.Detail.RendererResource CreateRendererResource(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader)
  System.Void OnDisposeManaged()
  System.Void OnDisposeUnmanaged()
  System.Void .ctor()
END_CLASS

CLASS: RendererResourceFactorySofdecPrimeYuv
TYPE:  class
TOKEN: 0x200013D
EXTENDS: RendererResourceFactory
FIELDS:
METHODS:
  CriWare.CriMana.Detail.RendererResource CreateRendererResource(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader)
  System.Void OnDisposeManaged()
  System.Void OnDisposeUnmanaged()
  System.Void .ctor()
END_CLASS

CLASS: RendererResourceFactorySofdecPrimeYuvRawData
TYPE:  class
TOKEN: 0x200013E
EXTENDS: RendererResourceFactory
FIELDS:
METHODS:
  CriWare.CriMana.Detail.RendererResource CreateRendererResource(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader)
  System.Void OnDisposeManaged()
  System.Void OnDisposeUnmanaged()
  System.Void .ctor()
END_CLASS

CLASS: __StaticArrayInitTypeSize=12
TYPE:  struct
TOKEN: 0x2000146
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
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

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
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

CLASS: CriWare.CriWarePS5
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  public    static  System.Int32                    SystemUserID  // 0x0
METHODS:
  System.Void SetupFileSystem(System.Boolean enableAprDirectMode)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtomPlugin
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private   static  System.Int32                    initializationCount  // 0x0
  private   static  System.Collections.Generic.List<System.IntPtr>effectInterfaceList  // 0x8
  private   static  System.Boolean                  isConfigured  // 0x10
  private   static  System.Single                   timeSinceStartup  // 0x14
  private   static  CriWare.Common.CpuUsage         cpuUsage  // 0x18
  private   static  System.Int32                    CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT  // 0x24
  private   static  System.UInt16                   CRIATOMPARAMETER2_ID_INVALID  // 0x28
  private   static  System.UInt64                   temporalStorage  // 0x30
METHODS:
  System.Void Log(System.String log)
  System.Boolean get_isInitialized()
  System.Void ExecuteQueuedCueLinkCallbacks()
  System.Void ExecuteQueuedEventCallbacks()
  System.Void ExecuteQueuedBeatSyncCallbacks()
  System.Boolean GetAudioEffectInterfaceList(System.Collections.Generic.List<System.IntPtr>& effect_interface_list)
  System.IntPtr GetSpatializerCoreInterfaceFromAtomOculusAudioBridge()
  System.Void SetConfigParameters(System.Int32 max_virtual_voices, System.Int32 max_voice_limit_groups, System.Int32 max_categories, System.Int32 max_aisacs, System.Int32 max_bus_sends, System.Int32 max_sequence_events_per_frame, System.Int32 max_beatsync_callbacks_per_frame, System.Int32 max_cuelink_callbacks_per_frame, System.Int32 num_standard_memory_voices, System.Int32 num_standard_streaming_voices, System.Int32 num_hca_mx_memory_voices, System.Int32 num_hca_mx_streaming_voices, System.Int32 output_sampling_rate, System.Int32 num_asr_output_channels, System.Boolean uses_in_game_preview, System.Single server_frequency, System.Int32 max_parameter_blocks, System.Int32 categories_per_playback, System.Int32 max_faders, System.Int32 num_buses, System.Boolean vr_mode)
  System.Void SetConfigMonitorParametes(System.Int32 max_preview_objects, System.Int32 communication_buffer_size, System.Int32 playback_position_update_interval)
  System.Void SetConfigAdditionalParameters_EDITOR(System.Boolean enable_user_pcm_output, System.Int32 user_pcm_buffer_length)
  System.Void SetConfigAdditionalParameters_PC(System.Int64 buffering_time_pc)
  System.Void SetConfigAdditionalParameters_LINUX(CriWare.CriAtomConfig.LinuxOutput output, System.Int32 pulse_latency_usec)
  System.Void SetConfigAdditionalParameters_IOS(System.Boolean enable_sonicsync, System.UInt32 buffering_time_ios, System.Boolean override_ipod_music_ios)
  System.Void SetConfigAdditionalParameters_ANDROID(System.Boolean enable_sonicsync, System.Int32 num_low_delay_memory_voices, System.Int32 num_low_delay_streaming_voices, System.Int32 sound_buffering_time, System.Int32 sound_start_buffering_time, System.Boolean use_fast_mixer, System.Boolean use_aaudio, System.Int32 stream_type)
  System.Void SetConfigAdditionalParameters_VITA(System.Int32 num_atrac9_memory_voices, System.Int32 num_atrac9_streaming_voices, System.Int32 num_mana_decoders)
  System.Void SetConfigAdditionalParameters_PS4(System.Int32 num_atrac9_memory_voices, System.Int32 num_atrac9_streaming_voices, System.Boolean use_audio3d, System.Int32 num_audio3d_memory_voices, System.Int32 num_audio3d_streaming_voices)
  System.Void SetConfigAdditionalParameters_PS5(System.Int32 max_channel_ports, System.Int32 max_object_ports)
  System.Void SetConfigAdditionalParameters_SWITCH(System.Boolean enable_sonicsync, System.Int32 num_opus_memory_voices, System.Int32 num_opus_streaming_voices, System.Boolean init_socket)
  System.Void SetConfigAdditionalParameters_WEBGL(System.Int32 num_webaudio_voices)
  System.Void SetMaxSamplingRateForStandardVoicePool(System.Int32 sampling_rate_for_memory, System.Int32 sampling_rate_for_streaming)
  System.Int32 GetRequiredMaxVirtualVoices(CriWare.CriAtomConfig atomConfig)
  System.Void InitializeLibrary()
  System.Boolean IsLibraryInitialized()
  System.Void FinalizeLibrary()
  System.Void Pause(System.Boolean pause)
  CriWare.Common.CpuUsage GetCpuUsage()
  System.Int32 GetOutputSamplingRate()
  System.Int32 GetOutputChannels()
  System.Boolean IsInitializedForPcmOutput()
  System.UInt16 GetLoopCountParameterId()
  System.Void DecryptAcb(System.IntPtr acb_hn, System.UInt64 key, System.UInt64 nonce)
  System.UInt64 CallbackFromNative(System.IntPtr ptr1)
  System.Void CRIWARE009CE561(System.Int32 max_virtual_voices, System.Int32 max_voice_limit_groups, System.Int32 max_categories, System.Int32 max_aisacs, System.Int32 max_bus_sends, System.Int32 max_sequence_events_per_frame, System.Int32 max_beatsync_callbacks_per_frame, System.Int32 max_cuelink_callbacks_per_frame, System.Int32 num_standard_memory_voices, System.Int32 num_standard_streaming_voices, System.Int32 num_hca_mx_memory_voices, System.Int32 num_hca_mx_streaming_voices, System.Int32 output_sampling_rate, System.Int32 num_asr_output_channels, System.Boolean uses_in_game_preview, System.Single server_frequency, System.Int32 max_parameter_blocks, System.Int32 categories_per_playback, System.Int32 max_faders, System.Int32 num_buses, System.Boolean use_ambisonics, System.IntPtr spatializer_core_interface)
  System.Void CRIWARE8384362B(System.UInt32 max_preivew_objects, System.UInt32 communication_buffer_size, System.Int32 playback_position_update_interval)
  System.Void CRIWARE237CA5E3(System.Boolean enable_user_pcm_out_mode)
  System.Void CRIWARE780E6ED2(System.Int64 buffering_time_pc)
  System.Void CRIWAREE996B258(System.Int32 output, System.Int32 pulse_latency_usec)
  System.Void CRIWARE2F034134(System.Boolean enable_sonicsync, System.UInt32 buffering_time_ios, System.Boolean override_ipod_music_ios)
  System.Void CRIWARE70981A20(System.Boolean enable_sonicsync, System.Int32 num_low_delay_memory_voices, System.Int32 num_low_delay_streaming_voices, System.Int32 sound_buffering_time, System.Int32 sound_start_buffering_time, System.Boolean apply_hw_property, System.Int32 stream_type)
  System.Void CRIWARE2626EF5B()
  System.Boolean CRIWAREC176B113()
  System.Void CRIWARE63E1F278()
  System.Void CRIWAREB64E0C3B(System.Boolean pause)
  System.UInt32 CRIWAREA703719E()
  System.Void CRIWAREBF97E87F(System.Int32 code)
  System.Void CRIWARE15B0037A(System.IntPtr cbfunc, System.String separator_string)
  System.Void CRIWARE28E5ABA4(System.IntPtr cbfunc)
  System.Void CRIWARECCA1268B()
  System.Void CRIWARE88175F19(System.IntPtr cbfunc)
  System.Void CRIWARE7581CF8C()
  System.Void CRIWARE15F30D07(System.IntPtr cbfunc)
  System.Void CRIWARED1FD92AA()
  System.Void CRIWARE2CFF30B7(System.Int32 sampling_rate_for_memory, System.Int32 sampling_rate_for_streaming)
  System.Void CRIWARE797E0462()
  System.Void CRIWAREC54D0552()
  System.Void CRIWARE5BC8942D(System.IntPtr acb_hn, CriWare.CriAtomPlugin.CallbackFromNativeDelegate func, System.IntPtr obj)
  System.UInt16 CRIWARE5B1C5B3B(System.Int32 id)
  System.Boolean CRIWAREE097EA6E()
  System.Int32 CRIWAREE320F01B()
  System.Int32 CRIWARE98A6BE5C()
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriAtomCueSheet
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   acbFile  // 0x18
  public            System.String                   awbFile  // 0x20
  public            CriWare.CriAtomExAcb            acb  // 0x28
  public            CriWare.CriAtomExAcbLoader.StatusloaderStatus  // 0x30
METHODS:
  System.Boolean get_IsLoading()
  System.Boolean get_IsError()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtom
TYPE:  class
TOKEN: 0x200000F
EXTENDS: CriMonoBehaviour
FIELDS:
  public            System.String                   acfFile  // 0x28
  private           System.Boolean                  acfIsLoading  // 0x30
  public            CriWare.CriAtomCueSheet[]       cueSheets  // 0x38
  public            System.String                   dspBusSetting  // 0x40
  public            System.Boolean                  dontDestroyOnLoad  // 0x48
  private   static  CriWare.CriAtomExSequencer.EventCallbackeventUserCallback  // 0x0
  private   static  CriWare.CriAtomExSequencer.EventCbFunceventUserCbFunc  // 0x8
  private   static  CriWare.CriAtomExBeatSync.CbFuncbeatsyncUserCbFunc  // 0x10
  private   static  CriWare.CriAtomExBeatSync.CbFuncobsoleteBeatSyncFunc  // 0x18
  private   static  CriWare.CriAtomEx.CueLinkCbFunc cueLinkUserCbFunc  // 0x20
  private   static  CriWare.CriAtom                 <instance>k__BackingField  // 0x28
  private           System.Runtime.InteropServices.GCHandleacfRegisterGCHandle  // 0x50
  public            System.Boolean                  dontRemoveExistsCueSheet  // 0x58
METHODS:
  System.Void add_OnEventSequencerCallback(CriWare.CriAtomExSequencer.EventCallback value)
  System.Void remove_OnEventSequencerCallback(CriWare.CriAtomExSequencer.EventCallback value)
  System.Void add_beatsyncUserCbFunc(CriWare.CriAtomExBeatSync.CbFunc value)
  System.Void remove_beatsyncUserCbFunc(CriWare.CriAtomExBeatSync.CbFunc value)
  System.Void add_OnBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value)
  System.Void remove_OnBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value)
  System.Void add_cueLinkUserCbFunc(CriWare.CriAtomEx.CueLinkCbFunc value)
  System.Void remove_cueLinkUserCbFunc(CriWare.CriAtomEx.CueLinkCbFunc value)
  System.Void add_OnCueLinkCallback(CriWare.CriAtomEx.CueLinkCbFunc value)
  System.Void remove_OnCueLinkCallback(CriWare.CriAtomEx.CueLinkCbFunc value)
  CriWare.CriAtom get_instance()
  System.Void set_instance(CriWare.CriAtom value)
  System.Void AttachDspBusSetting(System.String settingName)
  System.Void DetachDspBusSetting()
  CriWare.CriAtomCueSheet GetCueSheet(System.String name)
  CriWare.CriAtomCueSheet AddCueSheet(System.String name, System.String acbFile, System.String awbFile, CriWare.CriFsBinder binder)
  CriWare.CriAtomCueSheet AddCueSheetAsync(System.String name, System.String acbFile, System.String awbFile, CriWare.CriFsBinder binder, System.Boolean loadAwbOnMemory)
  CriWare.CriAtomCueSheet AddCueSheet(System.String name, System.Byte[] acbData, System.String awbFile, CriWare.CriFsBinder awbBinder)
  CriWare.CriAtomCueSheet AddCueSheetAsync(System.String name, System.Byte[] acbData, System.String awbFile, CriWare.CriFsBinder awbBinder, System.Boolean loadAwbOnMemory)
  System.Void RemoveCueSheet(System.String name)
  System.Boolean get_CueSheetsAreLoading()
  CriWare.CriAtomExAcb GetAcb(System.String cueSheetName)
  System.Void SetCategoryVolume(System.String name, System.Single volume)
  System.Void SetCategoryVolume(System.Int32 id, System.Single volume)
  System.Single GetCategoryVolume(System.String name)
  System.Single GetCategoryVolume(System.Int32 id)
  System.Void SetBusAnalyzer(System.String busName, System.Boolean sw)
  System.Void SetBusAnalyzer(System.Boolean sw)
  CriWare.CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(System.String busName)
  CriWare.CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(System.Int32 busId)
  System.Void Setup()
  System.Void Shutdown()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDestroy()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  CriWare.CriAtomCueSheet GetCueSheetInternal(System.String name)
  CriWare.CriAtomCueSheet AddCueSheetInternal(System.String name, System.String acbFile, System.String awbFile, CriWare.CriFsBinder binder)
  System.Void RemoveCueSheetInternal(System.String name)
  System.Void MargeCueSheet(CriWare.CriAtomCueSheet[] newCueSheets, System.Boolean newDontRemoveExistsCueSheet)
  CriWare.CriAtomExAcb LoadAcbFile(CriWare.CriFsBinder binder, System.String acbFile, System.String awbFile)
  CriWare.CriAtomExAcb LoadAcbData(System.Byte[] acbData, CriWare.CriFsBinder binder, System.String awbFile)
  System.Void LoadAcbFileAsync(CriWare.CriAtomCueSheet cueSheet, CriWare.CriFsBinder binder, System.String acbFile, System.String awbFile, System.Boolean loadAwbOnMemory)
  System.Collections.IEnumerator LoadAcbFileCoroutine(CriWare.CriAtomCueSheet cueSheet, CriWare.CriFsBinder binder, System.String acbPath, System.String awbPath, System.Boolean loadAwbOnMemory)
  System.Void LoadAcbDataAsync(CriWare.CriAtomCueSheet cueSheet, System.Byte[] acbData, CriWare.CriFsBinder awbBinder, System.String awbFile, System.Boolean loadAwbOnMemory)
  System.Collections.IEnumerator LoadAcbDataCoroutine(CriWare.CriAtomCueSheet cueSheet, System.Byte[] acbData, CriWare.CriFsBinder awbBinder, System.String awbPath, System.Boolean loadAwbOnMemory)
  System.Void SequenceEventCallbackFromNative(System.String eventString)
  System.Void SequenceCallbackFromNative(CriWare.CriAtomExSequencer.CriAtomExSequenceEventInfo& criAtomExSequenceInfo)
  System.Void BeatSyncCallbackFromNative(CriWare.CriAtomExBeatSync.Info& info)
  System.Void CueLinkCallbackFromNative(CriWare.CriAtomEx.CueLinkInfo& info)
  System.Void SetEventCallback(CriWare.CriAtomExSequencer.EventCbFunc func, System.String separator)
  System.Void RegisterEventCallbackChain(CriWare.CriAtomExSequencer.EventCallback func)
  System.Void UnregisterEventCallbackChain(CriWare.CriAtomExSequencer.EventCallback func)
  System.Void SetBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc func)
  System.Void RegisterBeatSyncCallbackChain(CriWare.CriAtomExBeatSync.CbFunc func)
  System.Void UnregisterBeatSyncCallbackChain(CriWare.CriAtomExBeatSync.CbFunc func)
  System.Void RegisterCueLinkCallbackChain(CriWare.CriAtomEx.CueLinkCbFunc func)
  System.Void UnregisterCueLinkCallbackChain(CriWare.CriAtomEx.CueLinkCbFunc func)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtomListener
TYPE:  class
TOKEN: 0x2000013
EXTENDS: CriMonoBehaviour
FIELDS:
  private           CriWare.CriAtomEx3dListener     <nativeListener>k__BackingField  // 0x28
  private           CriWare.CriAtomRegion           regionOnStart  // 0x30
  public            System.Boolean                  activateListenerOnEnable  // 0x38
  private   static  System.Collections.Generic.List<CriWare.CriAtomListener>listenersList  // 0x0
  private   static  CriWare.CriAtomEx3dListener     dummyNativeListener  // 0x8
  private           UnityEngine.Vector3             lastPosition  // 0x3C
  private           CriWare.CriAtomRegion           currentRegion  // 0x48
  private           System.Boolean                  _isActive  // 0x50
METHODS:
  System.Void CreateDummyNativeListener()
  System.Void DestroyDummyNativeListener()
  CriWare.CriAtomEx3dListener get_nativeListener()
  System.Void set_nativeListener(CriWare.CriAtomEx3dListener value)
  System.Boolean get_isActive()
  System.Void set_isActive(System.Boolean value)
  CriWare.CriAtomRegion get_region3d()
  System.Void set_region3d(CriWare.CriAtomRegion value)
  System.Void Awake()
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  System.Void UpdatePosition()
  System.Void ActivateListener(System.Boolean exclusive)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriAtomOutputDeviceObserver
TYPE:  class
TOKEN: 0x2000014
EXTENDS: CriMonoBehaviour
FIELDS:
  private           System.Boolean                  dontDestroyOnLoad  // 0x28
  private           System.Boolean                  lastIsConnected  // 0x29
  private           System.Boolean                  isConnected  // 0x2A
  private           CriWare.CriAtomOutputDeviceObserver.OutputDeviceTypelastDeviceType  // 0x2C
  private           CriWare.CriAtomOutputDeviceObserver.OutputDeviceTypedeviceType  // 0x30
  private   static  CriWare.CriAtomOutputDeviceObserverinstance  // 0x0
  private   static  CriWare.CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback_onDeviceConnectionChanged  // 0x8
METHODS:
  System.Void add_OnDeviceConnectionChanged(CriWare.CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback value)
  System.Void remove_OnDeviceConnectionChanged(CriWare.CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback value)
  System.Boolean get_IsDeviceConnected()
  CriWare.CriAtomOutputDeviceObserver.OutputDeviceType get_DeviceType()
  System.Void add__onDeviceConnectionChanged(CriWare.CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback value)
  System.Void remove__onDeviceConnectionChanged(CriWare.CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback value)
  System.Void Awake()
  System.Void OnDestroy()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtomRegion
TYPE:  class
TOKEN: 0x2000018
EXTENDS: CriMonoBehaviour
FIELDS:
  private           CriWare.CriAtomEx3dRegion       <region3dHn>k__BackingField  // 0x28
  private           System.Collections.Generic.List<CriWare.CriAtomSourceBase>referringSources  // 0x30
  private           System.Collections.Generic.List<CriWare.CriAtomListener>referringListeners  // 0x38
  private           System.Collections.Generic.List<CriWare.CriAtomTransceiver>referringTransceivers  // 0x40
METHODS:
  CriWare.CriAtomEx3dRegion get_region3dHn()
  System.Void set_region3dHn(CriWare.CriAtomEx3dRegion value)
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDestroy()
  System.Void InternalInitialize()
  System.Void InternalFinalize()
  System.Void InitializeParameters()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtomServer
TYPE:  class
TOKEN: 0x2000019
EXTENDS: CriMonoBehaviour
FIELDS:
  private   static  CriWare.CriAtomServer           _instance  // 0x0
  public            System.Action<System.Boolean>   onApplicationPausePreProcess  // 0x28
  public            System.Action<System.Boolean>   onApplicationPausePostProcess  // 0x30
  public    static  System.Boolean                  KeepPlayingSoundOnPause  // 0x8
  public    static  System.Boolean                  EnableAutoConsumePcmOutput  // 0x9
METHODS:
  CriWare.CriAtomServer get_instance()
  System.Void CreateInstance()
  System.Void DestroyInstance()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  System.Void ConsumePcmOutput()
  System.Void OnApplicationPause(System.Boolean appPause)
  System.Void ProcessApplicationPause(System.Boolean appPause)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriAtomSource
TYPE:  class
TOKEN: 0x200001A
EXTENDS: CriAtomSourceBase
FIELDS:
  private           System.String                   _cueName  // 0xA0
  private           System.String                   _cueSheet  // 0xA8
METHODS:
  System.String get_cueName()
  System.Void set_cueName(System.String value)
  System.String get_cueSheet()
  System.Void set_cueSheet(System.String value)
  CriWare.CriAtomExPlayback Play()
  CriWare.CriAtomExAcb GetAcb()
  System.Void PlayOnStart()
  System.Collections.IEnumerator PlayAsync(System.String cueName)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtomSourceBase
TYPE:  class
TOKEN: 0x200001C
EXTENDS: CriMonoBehaviour
FIELDS:
  private           CriWare.CriAtomExPlayer         <player>k__BackingField  // 0x28
  private           CriWare.CriAtomEx3dSource       <source>k__BackingField  // 0x30
  protected         System.Boolean                  initialized  // 0x38
  protected         UnityEngine.Vector3             lastPosition  // 0x3C
  protected         System.Boolean                  hasValidPosition  // 0x48
  private           CriWare.CriAtomRegion           currentRegion  // 0x50
  private           CriWare.CriAtomListener         currentListener  // 0x58
  private           System.Boolean                  _playOnStart  // 0x60
  private           CriWare.CriAtomRegion           _regionOnStart  // 0x68
  private           CriWare.CriAtomListener         _listenerOnStart  // 0x70
  private           System.Boolean                  _use3dPositioning  // 0x78
  private           System.Boolean                  _freezeOrientation  // 0x79
  private           System.Boolean                  _loop  // 0x7A
  private           System.Single                   _volume  // 0x7C
  private           System.Single                   _pitch  // 0x80
  private           System.Boolean                  _androidUseLowLatencyVoicePool  // 0x84
  private           System.Boolean                  need_to_player_update_all  // 0x85
  private           System.Boolean                  _use3dRandomization  // 0x86
  private           System.UInt32                   _randomPositionListMaxLength  // 0x88
  private           CriWare.CriAtomEx.Randomize3dConfigrandomize3dConfig  // 0x90
METHODS:
  System.Void set_player(CriWare.CriAtomExPlayer value)
  CriWare.CriAtomExPlayer get_player()
  System.Void set_source(CriWare.CriAtomEx3dSource value)
  CriWare.CriAtomEx3dSource get_source()
  System.Boolean get_playOnStart()
  System.Void set_playOnStart(System.Boolean value)
  System.Void set_use3dPositioning(System.Boolean value)
  System.Boolean get_use3dPositioning()
  System.Boolean get_freezeOrientation()
  System.Void set_freezeOrientation(System.Boolean value)
  System.Void set_use3dRandomization(System.Boolean value)
  System.Boolean get_use3dRandomization()
  System.Void set_randomPositionListMaxLength(System.UInt32 value)
  System.UInt32 get_randomPositionListMaxLength()
  CriWare.CriAtomRegion get_region3d()
  System.Void set_region3d(CriWare.CriAtomRegion value)
  CriWare.CriAtomListener get_listener()
  System.Void set_listener(CriWare.CriAtomListener value)
  CriWare.CriAtomRegion get_regionOnStart()
  System.Void set_regionOnStart(CriWare.CriAtomRegion value)
  CriWare.CriAtomListener get_listenerOnStart()
  System.Void set_listenerOnStart(CriWare.CriAtomListener value)
  System.Void set_loop(System.Boolean value)
  System.Boolean get_loop()
  System.Void set_volume(System.Single value)
  System.Single get_volume()
  System.Void set_pitch(System.Single value)
  System.Single get_pitch()
  System.Void set_pan3dAngle(System.Single value)
  System.Single get_pan3dAngle()
  System.Void set_pan3dDistance(System.Single value)
  System.Single get_pan3dDistance()
  System.Void set_startTime(System.Int32 value)
  System.Int32 get_startTime()
  System.Int64 get_time()
  CriWare.CriAtomSourceBase.Status get_status()
  System.Void set_attenuationDistanceSetting(System.Boolean value)
  System.Boolean get_attenuationDistanceSetting()
  System.Boolean get_androidUseLowLatencyVoicePool()
  System.Void set_androidUseLowLatencyVoicePool(System.Boolean value)
  System.Void SetNeedToPlayerUpdateAll()
  System.Void InternalInitialize()
  System.Void InternalFinalize()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDestroy()
  System.Boolean SetInitialSourcePosition()
  System.Void SetInitialParameters()
  System.Void UpdatePosition()
  System.Void Start()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  CriWare.CriAtomExPlayback Play()
  CriWare.CriAtomExAcb GetAcb()
  System.Void PlayOnStart()
  CriWare.CriAtomExPlayback Play(System.String cueName)
  CriWare.CriAtomExPlayback Play(System.Int32 cueId)
  CriWare.CriAtomExPlayback InternalPlayCue()
  System.Void Stop()
  System.Void Pause(System.Boolean sw)
  System.Boolean IsPaused()
  System.Void SetBusSendLevel(System.String busName, System.Single level)
  System.Void SetBusSendLevel(System.Int32 busId, System.Single level)
  System.Void SetBusSendLevelOffset(System.String busName, System.Single levelOffset)
  System.Void SetBusSendLevelOffset(System.Int32 busId, System.Single levelOffset)
  System.Void SetAisacControl(System.String controlName, System.Single value)
  System.Void SetAisac(System.String controlName, System.Single value)
  System.Void SetAisacControl(System.UInt32 controlId, System.Single value)
  System.Void SetAisac(System.UInt32 controlId, System.Single value)
  System.Void AttachToAnalyzer(CriWare.CriAtomExOutputAnalyzer analyzer)
  System.Void DetachFromAnalyzer(CriWare.CriAtomExOutputAnalyzer analyzer)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtomTransceiver
TYPE:  class
TOKEN: 0x200001E
EXTENDS: CriMonoBehaviour
FIELDS:
  private           CriWare.CriAtomEx3dTransceiver  <transceiverHn>k__BackingField  // 0x28
  private           UnityEngine.Vector3             <inputPos>k__BackingField  // 0x30
  private           UnityEngine.Vector3             <inputFront>k__BackingField  // 0x3C
  private           UnityEngine.Vector3             <inputUp>k__BackingField  // 0x48
  private           CriWare.CriAtomRegion           regionOnStart  // 0x58
  private           System.Boolean                  useDedicatedInput  // 0x60
  private           UnityEngine.GameObject          dedicatedInput  // 0x68
  private           System.Single                   outputVolume  // 0x70
  private           System.Single                   directAudioRadius  // 0x74
  private           System.Single                   crossFadeDistance  // 0x78
  private           System.Single                   coneInsideAngle  // 0x7C
  private           System.Single                   coneOutsideAngle  // 0x80
  private           System.Single                   coneOutsideVolume  // 0x84
  private           System.Single                   transceiverRadius  // 0x88
  private           System.Single                   interiorDistance  // 0x8C
  public            System.Single                   minAttenuation  // 0x90
  public            System.Single                   maxAttenuation  // 0x94
  private           System.String                   globalAisacName  // 0x98
  private           System.Single                   maxAngleAisacDelta  // 0xA0
  private           System.String                   distanceAisacControlId  // 0xA8
  private           System.String                   listenerAzimuthAisacControlId  // 0xB0
  private           System.String                   listenerElevationAisacControlId  // 0xB8
  private           System.String                   outputAzimuthAisacControlId  // 0xC0
  private           System.String                   outputElevationAisacControlId  // 0xC8
  public            System.Boolean                  inspectorAisacSettingFoldout  // 0xD0
  private           System.Boolean                  isInitialized  // 0xD1
  private           System.Boolean                  dedicatedInputNotSetWarned  // 0xD2
  private           CriWare.CriAtomRegion           currentRegion  // 0xD8
METHODS:
  CriWare.CriAtomEx3dTransceiver get_transceiverHn()
  System.Void set_transceiverHn(CriWare.CriAtomEx3dTransceiver value)
  UnityEngine.Vector3 get_inputPos()
  System.Void set_inputPos(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_inputFront()
  System.Void set_inputFront(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_inputUp()
  System.Void set_inputUp(UnityEngine.Vector3 value)
  CriWare.CriAtomRegion get_region3d()
  System.Void set_region3d(CriWare.CriAtomRegion value)
  System.Void Awake()
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDestroy()
  System.Void InternalInitialize()
  System.Void InternalFinalize()
  System.Void InitializeParameters()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  System.Void ApplyCurrentPosition()
  System.Void ApplyParameters()
  System.Void TrySetAisacControlId(System.String strId, CriWare.CriAtomTransceiver.SetControlIdMethod callback)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriStructMemory`1
TYPE:  class
TOKEN: 0x2000020
FIELDS:
  private           System.Byte[]                   <bytes>k__BackingField  // 0x0
  private           System.Runtime.InteropServices.GCHandlegch  // 0x0
METHODS:
  System.Byte[] get_bytes()
  System.Void set_bytes(System.Byte[] value)
  System.IntPtr get_ptr()
  System.Void .ctor()
  System.Void .ctor(System.Int32 num)
  System.Void Dispose()
END_CLASS

CLASS: CriWare.CriAtomEx
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  public    static  System.UInt32                   InvalidAisacControlId  // 0x0
  public    static readonly System.Collections.Generic.Dictionary<CriWare.CriAtomEx.Randomize3dCalcType,CriWare.CriAtomEx.Randomize3dParamType[]>randomize3dParamTable  // 0x0
METHODS:
  System.Void SetSpeakerAngle(CriWare.CriAtomEx.SpeakerAngles6ch speakerAngle)
  System.Void SetSpeakerAngle(CriWare.CriAtomEx.SpeakerAngles8ch speakerAngle)
  System.Void SetVirtualSpeakerAngle(CriWare.CriAtomEx.SpeakerAngles6ch speakerAngle)
  System.Void SetVirtualSpeakerAngle(CriWare.CriAtomEx.SpeakerAngles8ch speakerAngle)
  System.Void ControlVirtualSpeakerSetting(System.Boolean sw)
  System.Void add_OnCueLinkCallback(CriWare.CriAtomEx.CueLinkCbFunc value)
  System.Void remove_OnCueLinkCallback(CriWare.CriAtomEx.CueLinkCbFunc value)
  System.Void RegisterAcf(CriWare.CriFsBinder binder, System.String acfPath)
  System.Void RegisterAcf(System.IntPtr acfData, System.Int32 dataSize)
  System.Void RegisterAcf(System.Byte[] acfData)
  System.Void UnregisterAcf()
  System.String GetAppliedDspBusSnapshotName()
  System.Void AttachDspBusSetting(System.String settingName)
  System.Void DetachDspBusSetting()
  System.Void ApplyDspBusSnapshot(System.String snapshot_name, System.Int32 time_ms)
  System.Int32 GetNumGameVariables()
  System.Boolean GetGameVariableInfo(System.UInt16 index, CriWare.CriAtomEx.GameVariableInfo& info)
  System.Single GetGameVariable(System.UInt32 game_variable_id)
  System.Single GetGameVariable(System.String game_variable_name)
  System.Void SetGameVariable(System.UInt32 game_variable_id, System.Single game_variable_value)
  System.Void SetGameVariable(System.String game_variable_name, System.Single game_variable_value)
  System.Void SetRandomSeed(System.UInt32 seed)
  System.Void ResetPerformanceMonitor()
  System.Void GetPerformanceInfo(CriWare.CriAtomEx.PerformanceInfo& info)
  System.Void SetGlobalLabelToSelectorByIndex(System.UInt16 selector_index, System.UInt16 label_index)
  System.Void SetGlobalLabelToSelectorByName(System.String selector_name, System.String label_name)
  System.Void Lock()
  System.Void Unlock()
  System.Void SetOutputAudioDevice_PC(System.String deviceId)
  System.Boolean LoadAudioDeviceList_PC()
  System.Int32 GetNumAudioDevices_PC()
  System.String GetAudioDeviceName_PC(System.Int32 index)
  System.Void SetOutputAudioDevice_PC(System.Int32 index)
  System.Void SetOutputVolume_VITA(System.Single volume)
  System.Boolean IsBgmPortAcquired_VITA()
  System.Boolean IsSoundStopped_IOS()
  System.Void EnableAudioSessionRestoration_IOS(System.Boolean flag)
  System.Void EnableBusSendOffsetWhenLevelNotExist(System.Boolean enable)
  System.Boolean criAtomEx_RegisterAcfFile(System.IntPtr binder, System.String path, System.IntPtr work, System.Int32 workSize)
  System.Void criAtomEx_RegisterAcfData(System.IntPtr acfData, System.Int32 acfDataSize, System.IntPtr work, System.Int32 workSize)
  System.Void criAtomEx_RegisterAcfData(System.Byte[] acfData, System.Int32 acfDataSize, System.IntPtr work, System.Int32 workSize)
  System.Void criAtomEx_UnregisterAcf()
  System.Void criAtomEx_AttachDspBusSetting(System.String settingName, System.IntPtr work, System.Int32 workSize)
  System.Void criAtomEx_DetachDspBusSetting()
  System.Void criAtomEx_ApplyDspBusSnapshot(System.String snapshot_name, System.Int32 time_ms)
  System.IntPtr criAtomEx_GetAppliedDspBusSnapshotName()
  System.Int32 criAtomEx_GetNumGameVariables()
  System.Boolean criAtomEx_GetGameVariableInfo(System.UInt16 index, System.IntPtr game_variable_info)
  System.Single criAtomEx_GetGameVariableById(System.UInt32 game_variable_id)
  System.Single criAtomEx_GetGameVariableByName(System.String game_variable_name)
  System.Void criAtomEx_SetGameVariableById(System.UInt32 game_variable_id, System.Single game_variable_value)
  System.Void criAtomEx_SetGameVariableByName(System.String game_variable_name, System.Single game_variable_value)
  System.Void criAtomEx_SetRandomSeed(System.UInt32 seed)
  System.Void criAtomEx_Lock()
  System.Void criAtomEx_Unlock()
  System.Void criAtom_ResetPerformanceMonitor()
  System.Void criAtom_GetPerformanceInfo(CriWare.CriAtomEx.PerformanceInfo& info)
  System.Void criAtomExAcf_SetGlobalLabelToSelectorByIndex(System.UInt16 selector_index, System.UInt16 label_index)
  System.Void criAtomExAcf_SetGlobalLabelToSelectorByName(System.String selector_name, System.String label_name)
  System.Void criAtomEx_SetSpeakerAngleArray(CriWare.CriAtomEx.SpeakerSystem speaker_system, CriWare.CriAtomEx.SpeakerAngles6ch& angle_array)
  System.Void criAtomEx_SetSpeakerAngleArray(CriWare.CriAtomEx.SpeakerSystem speaker_system, CriWare.CriAtomEx.SpeakerAngles8ch& angle_array)
  System.Void criAtomEx_SetVirtualSpeakerAngleArray(CriWare.CriAtomEx.SpeakerSystem speaker_system, CriWare.CriAtomEx.SpeakerAngles6ch& angle_array)
  System.Void criAtomEx_SetVirtualSpeakerAngleArray(CriWare.CriAtomEx.SpeakerSystem speaker_system, CriWare.CriAtomEx.SpeakerAngles8ch& angle_array)
  System.Void criAtomEx_ControlVirtualSpeakerSetting(System.Boolean sw)
  System.Void criAtomEx_EnableBusSendOffsetWhenLevelNotExist(System.Boolean enable)
  System.Void criAtom_SetDeviceId_WASAPI(CriWare.CriAtomEx.SoundRendererType soundRendererType, System.String deviceId)
  System.Void criAtom_SetDeviceId_WASAPI(CriWare.CriAtomEx.SoundRendererType type, System.IntPtr deviceId)
  System.Boolean criAtomUnity_LoadAudioDeviceList_PC()
  System.Int32 criAtomUnity_GetNumAudioDevices_PC()
  System.IntPtr criAtomUnity_GetAudioDeviceName_PC(System.Int32 index)
  System.IntPtr criAtomUnity_GetAudioDeviceId_PC(System.Int32 index)
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriAtomExCategory
TYPE:  class
TOKEN: 0x200003F
FIELDS:
METHODS:
  System.Void SetVolume(System.String name, System.Single volume)
  System.Void SetVolume(System.Int32 id, System.Single volume)
  System.Single GetVolume(System.String name)
  System.Single GetVolume(System.Int32 id)
  System.Void Mute(System.String name, System.Boolean mute)
  System.Void Mute(System.Int32 id, System.Boolean mute)
  System.Boolean IsMuted(System.String name)
  System.Boolean IsMuted(System.Int32 id)
  System.Void Solo(System.String name, System.Boolean solo, System.Single muteVolume)
  System.Void Solo(System.Int32 id, System.Boolean solo, System.Single muteVolume)
  System.Boolean IsSoloed(System.String name)
  System.Boolean IsSoloed(System.Int32 id)
  System.Void Pause(System.String name, System.Boolean pause)
  System.Void Pause(System.Int32 id, System.Boolean pause)
  System.Boolean IsPaused(System.String name)
  System.Boolean IsPaused(System.Int32 id)
  System.Void SetAisacControl(System.String name, System.String controlName, System.Single value)
  System.Void SetAisac(System.String name, System.String controlName, System.Single value)
  System.Void SetAisacControl(System.Int32 id, System.Int32 controlId, System.Single value)
  System.Void SetAisac(System.Int32 id, System.Int32 controlId, System.Single value)
  System.Void SetReactParameter(System.String name, CriWare.CriAtomExCategory.ReactParameter parameter)
  System.Boolean GetReactParameter(System.String name, CriWare.CriAtomExCategory.ReactParameter& parameter)
  System.Boolean GetAttachedAisacInfoById(System.UInt32 id, System.Int32 aisacAttachedIndex, CriWare.CriAtomEx.AisacInfo& aisacInfo)
  System.Boolean GetAttachedAisacInfoByName(System.String name, System.Int32 aisacAttachedIndex, CriWare.CriAtomEx.AisacInfo& aisacInfo)
  System.Boolean GetCurrentAisacControlValue(System.String categoryName, System.String aisacControlName, System.Single& controlValue)
  CriWare.CriAtomExCategory.ReactStatus GetReactStatus(System.String reactName)
  System.Void criAtomExCategory_SetVolumeByName(System.String name, System.Single volume)
  System.Single criAtomExCategory_GetVolumeByName(System.String name)
  System.Void criAtomExCategory_SetVolumeById(System.Int32 id, System.Single volume)
  System.Single criAtomExCategory_GetVolumeById(System.Int32 id)
  System.Void criAtomExCategory_MuteById(System.Int32 id, System.Boolean mute)
  System.Boolean criAtomExCategory_IsMutedById(System.Int32 id)
  System.Void criAtomExCategory_MuteByName(System.String name, System.Boolean mute)
  System.Boolean criAtomExCategory_IsMutedByName(System.String name)
  System.Void criAtomExCategory_SoloById(System.Int32 id, System.Boolean solo, System.Single volume)
  System.Boolean criAtomExCategory_IsSoloedById(System.Int32 id)
  System.Void criAtomExCategory_SoloByName(System.String name, System.Boolean solo, System.Single volume)
  System.Boolean criAtomExCategory_IsSoloedByName(System.String name)
  System.Void criAtomExCategory_PauseById(System.Int32 id, System.Boolean pause)
  System.Boolean criAtomExCategory_IsPausedById(System.Int32 id)
  System.Void criAtomExCategory_PauseByName(System.String name, System.Boolean pause)
  System.Boolean criAtomExCategory_IsPausedByName(System.String name)
  System.Void criAtomExCategory_SetAisacControlById(System.Int32 id, System.UInt16 controlId, System.Single value)
  System.Void criAtomExCategory_SetAisacControlByName(System.String name, System.String controlName, System.Single value)
  System.Void criAtomExCategory_SetReactParameter(System.String react_name, CriWare.CriAtomExCategory.ReactParameter& parameter)
  System.Boolean criAtomExCategory_GetReactParameter(System.String react_name, CriWare.CriAtomExCategory.ReactParameter& parameter)
  System.Boolean criAtomExCategory_GetAttachedAisacInfoById(System.UInt32 id, System.Int32 aisacAttachedIndex, System.IntPtr aisacInfo)
  System.Boolean criAtomExCategory_GetAttachedAisacInfoByName(System.String name, System.Int32 aisacAttachedIndex, System.IntPtr aisacInfo)
  System.Boolean criAtomExCategory_GetCurrentAisacControlValueByName(System.String category_name, System.String aisac_control_name, System.Single& control_value)
  CriWare.CriAtomExCategory.ReactStatus criAtomExCategory_GetReactStatus(System.String react_name)
END_CLASS

CLASS: CriWare.CriAtomExSequencer
TYPE:  class
TOKEN: 0x200004D
FIELDS:
METHODS:
  System.Void add_OnCallback(CriWare.CriAtomExSequencer.EventCallback value)
  System.Void remove_OnCallback(CriWare.CriAtomExSequencer.EventCallback value)
  System.Void SetEventCallback(CriWare.CriAtomExSequencer.EventCbFunc func, System.String separator)
END_CLASS

CLASS: CriWare.CriAtomExBeatSync
TYPE:  class
TOKEN: 0x2000051
FIELDS:
METHODS:
  System.Void add_OnCallback(CriWare.CriAtomExBeatSync.CbFunc value)
  System.Void remove_OnCallback(CriWare.CriAtomExBeatSync.CbFunc value)
  System.Void SetCallback(CriWare.CriAtomExBeatSync.CbFunc func)
END_CLASS

CLASS: CriWare.CriAtomExAsr
TYPE:  class
TOKEN: 0x2000054
FIELDS:
METHODS:
  System.Void AttachBusAnalyzer(System.String busName, System.Int32 interval, System.Int32 peakHoldTime)
  System.Void AttachBusAnalyzer(System.Int32 interval, System.Int32 peakHoldTime)
  System.Void DetachBusAnalyzer(System.String busName)
  System.Void DetachBusAnalyzer()
  System.Void GetBusAnalyzerInfo(System.String busName, CriWare.CriAtomExAsr.BusAnalyzerInfo& info)
  System.Void GetBusAnalyzerInfo(System.Int32 busId, CriWare.CriAtomExAsr.BusAnalyzerInfo& info)
  System.Void SetBusVolume(System.String busName, System.Single volume)
  System.Void SetBusVolume(System.Int32 busId, System.Single volume)
  System.Void SetBusSendLevel(System.String busName, System.String sendTo, System.Single level)
  System.Void SetBusSendLevel(System.Int32 busId, System.Int32 sendTo, System.Single level)
  System.Void SetBusMatrix(System.String busName, System.Int32 inputChannels, System.Int32 outputChannels, System.Single[] matrix)
  System.Void SetBusMatrix(System.Int32 busId, System.Int32 inputChannels, System.Int32 outputChannels, System.Single[] matrix)
  System.Void SetEffectBypass(System.String busName, System.String effectName, System.Boolean bypass)
  System.Void SetEffectParameter(System.String busName, System.String effectName, System.UInt32 parameterIndex, System.Single parameterValue)
  System.Single GetEffectParameter(System.String busName, System.String effectName, System.UInt32 parameterIndex)
  System.Boolean RegisterEffectInterface(System.IntPtr afx_interface)
  System.Void UnregisterEffectInterface(System.IntPtr afx_interface)
  System.Void GetBusVolume(System.String busName, System.Single& volume)
  System.Int32 GetPcmOutput(System.Int32 outputChannels, System.Int32 outputSamples, System.Single[][] buffer)
  System.Int32 GetNumBufferedPcmOutputSamples()
  System.Void SetPcmBufferSize(System.Int32 numSamples)
  System.Void criAtomExAsr_AttachBusAnalyzerByName(System.String busName, CriWare.CriAtomExAsr.BusAnalyzerConfig& config)
  System.Void criAtomExAsr_AttachBusAnalyzer(System.Int32 busNo, CriWare.CriAtomExAsr.BusAnalyzerConfig& config)
  System.Void criAtomExAsr_DetachBusAnalyzerByName(System.String busName)
  System.Void criAtomExAsr_DetachBusAnalyzer(System.Int32 busNo)
  System.Void criAtomExAsr_GetBusAnalyzerInfoByName(System.String busName, System.IntPtr info)
  System.Void criAtomExAsr_GetBusAnalyzerInfo(System.Int32 busNo, System.IntPtr info)
  System.Void criAtomExAsr_SetBusVolumeByName(System.String busName, System.Single volume)
  System.Void criAtomExAsr_SetBusVolume(System.Int32 busNo, System.Single volume)
  System.Void criAtomExAsr_SetBusSendLevelByName(System.String busName, System.String sendtoName, System.Single level)
  System.Void criAtomExAsr_SetBusSendLevel(System.Int32 busNo, System.Int32 sendtoNo, System.Single level)
  System.Void criAtomExAsr_SetBusMatrixByName(System.String busName, System.Int32 inputChannels, System.Int32 outputChannels, System.Single[] matrix)
  System.Void criAtomExAsr_SetBusMatrix(System.Int32 busNo, System.Int32 inputChannels, System.Int32 outputChannels, System.Single[] matrix)
  System.Void criAtomExAsr_SetEffectBypass(System.String busName, System.String effectName, System.Boolean bypass)
  System.Void criAtomExAsr_UpdateEffectParameters(System.String busName, System.String effectName)
  System.Void criAtomExAsr_SetEffectParameter(System.String busName, System.String effectName, System.UInt32 parameterIndex, System.Single parameterValue)
  System.Single criAtomExAsr_GetEffectParameter(System.String busName, System.String effectName, System.UInt32 parameterIndex)
  System.Boolean criAtomExAsr_RegisterEffectInterface(System.IntPtr afx_interface)
  System.Void criAtomExAsr_UnregisterEffectInterface(System.IntPtr afx_interface)
  System.Void criAtomExAsr_GetBusVolumeByName(System.String busName, System.Single& volume)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtomExLatencyEstimator
TYPE:  class
TOKEN: 0x2000057
FIELDS:
METHODS:
  System.Void InitializeModule()
  System.Void FinalizeModule()
  CriWare.CriAtomExLatencyEstimator.EstimatorInfo GetCurrentInfo()
END_CLASS

CLASS: CriWare.CriAtomEx3dListener
TYPE:  class
TOKEN: 0x200005A
EXTENDS: CriDisposable
FIELDS:
  private           System.IntPtr                   handle  // 0x20
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.IntPtr get_nativeHandle()
  System.Void Update()
  System.Void ResetParameters()
  System.Void SetPosition(System.Single x, System.Single y, System.Single z)
  System.Void SetVelocity(System.Single x, System.Single y, System.Single z)
  System.Void SetOrientation(System.Single fx, System.Single fy, System.Single fz, System.Single ux, System.Single uy, System.Single uz)
  System.Void SetDistanceFactor(System.Single distanceFactor)
  System.Void SetDopplerMultiplier(System.Single dopplerMultiplier)
  System.Void SetFocusPoint(System.Single x, System.Single y, System.Single z)
  System.Void SetDistanceFocusLevel(System.Single distanceFocusLevel)
  System.Void SetDirectionFocusLevel(System.Single directionFocusLevel)
  System.Void Set3dRegion(CriWare.CriAtomEx3dRegion region3d)
  System.Boolean IsDestroyable()
  System.Void Finalize()
  System.IntPtr criAtomEx3dListener_Create(CriWare.CriAtomEx3dListener.Config& config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomEx3dListener_Destroy(System.IntPtr ex_3d_listener)
  System.Void criAtomEx3dListener_Update(System.IntPtr ex_3d_listener)
  System.Void criAtomEx3dListener_ResetParameters(System.IntPtr ex_3d_listener)
  System.Void criAtomEx3dListener_SetPosition(System.IntPtr ex_3d_listener, CriWare.CriAtomEx.NativeVector& position)
  System.Void criAtomEx3dListener_SetVelocity(System.IntPtr ex_3d_listener, CriWare.CriAtomEx.NativeVector& velocity)
  System.Void criAtomEx3dListener_SetOrientation(System.IntPtr ex_3d_listener, CriWare.CriAtomEx.NativeVector& front, CriWare.CriAtomEx.NativeVector& top)
  System.Void criAtomEx3dListener_SetDistanceFactor(System.IntPtr ex_3d_listener, System.Single distance_factor)
  System.Void criAtomEx3dListener_SetDopplerMultiplier(System.IntPtr ex_3d_listener, System.Single doppler_multiplier)
  System.Void criAtomEx3dListener_SetFocusPoint(System.IntPtr ex_3d_listener, CriWare.CriAtomEx.NativeVector& focus_point)
  System.Void criAtomEx3dListener_SetDistanceFocusLevel(System.IntPtr ex_3d_listener, System.Single distance_focus_level)
  System.Void criAtomEx3dListener_SetDirectionFocusLevel(System.IntPtr ex_3d_listener, System.Single direction_focus_level)
  System.Boolean criAtomEx3dListener_IsDestroyable(System.IntPtr ex_3d_listener)
  System.Void criAtomEx3dListener_Set3dRegionHn(System.IntPtr ex_3d_listener, System.IntPtr ex_3d_region)
END_CLASS

CLASS: CriWare.CriAtomEx3dSource
TYPE:  class
TOKEN: 0x200005C
EXTENDS: CriDisposable
FIELDS:
  private           System.UInt32                   currentRandomPositionListMaxLength  // 0x20
  private           System.IntPtr                   handle  // 0x28
METHODS:
  System.Void .ctor(System.Boolean enableVoicePriorityDecay, System.UInt32 randomPositionListMaxLength)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.IntPtr get_nativeHandle()
  System.Void Update()
  System.Void ResetParameters()
  System.Void SetPosition(System.Single x, System.Single y, System.Single z)
  System.Void SetVelocity(System.Single x, System.Single y, System.Single z)
  System.Void SetOrientation(UnityEngine.Vector3 front, UnityEngine.Vector3 top)
  System.Void SetConeOrientation(System.Single x, System.Single y, System.Single z)
  System.Void SetConeParameter(System.Single insideAngle, System.Single outsideAngle, System.Single outsideVolume)
  System.Void SetMinMaxDistance(System.Single minDistance, System.Single maxDistance)
  System.Void SetInteriorPanField(System.Single sourceRadius, System.Single interiorDistance)
  System.Void SetDopplerFactor(System.Single dopplerFactor)
  System.Void SetVolume(System.Single volume)
  System.Void SetMaxAngleAisacDelta(System.Single maxDelta)
  System.Void SetAttenuationDistanceSetting(System.Boolean flag)
  System.Boolean GetAttenuationDistanceSetting()
  System.Void SetRandomPositionConfig(System.Nullable<CriWare.CriAtomEx.Randomize3dConfig> config)
  System.Void SetRandomPositionList(UnityEngine.Vector3[] positionList)
  System.Void Set3dRegion(CriWare.CriAtomEx3dRegion region3d)
  System.Void SetListenerBasedElevationAngleAisacControlId(System.UInt16 aisacControlId)
  System.Void SetSourceBasedElevationAngleAisacControlId(System.UInt16 aisacControlId)
  System.Void SetDistanceAisacControlId(System.UInt16 aisacControlId)
  System.Boolean IsDestroyable()
  CriWare.CriAtomEx.NativeVector GetPosition()
  System.Void Finalize()
  System.IntPtr criAtomEx3dSource_Create(CriWare.CriAtomEx3dSource.Config& config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomEx3dSource_Destroy(System.IntPtr ex_3d_source)
  System.Void criAtomEx3dSource_Update(System.IntPtr ex_3d_source)
  System.Void criAtomEx3dSource_ResetParameters(System.IntPtr ex_3d_source)
  System.Void criAtomEx3dSource_SetPosition(System.IntPtr ex_3d_source, CriWare.CriAtomEx.NativeVector& position)
  System.Void criAtomEx3dSource_SetVelocity(System.IntPtr ex_3d_source, CriWare.CriAtomEx.NativeVector& velocity)
  System.Void criAtomEx3dSource_SetOrientation(System.IntPtr ex_3d_source, CriWare.CriAtomEx.NativeVector& front, CriWare.CriAtomEx.NativeVector& top)
  System.Void criAtomEx3dSource_SetConeOrientation(System.IntPtr ex_3d_source, CriWare.CriAtomEx.NativeVector& cone_orient)
  System.Void criAtomEx3dSource_SetConeParameter(System.IntPtr ex_3d_source, System.Single inside_angle, System.Single outside_angle, System.Single outside_volume)
  System.Void criAtomEx3dSource_SetMinMaxAttenuationDistance(System.IntPtr ex_3d_source, System.Single min_distance, System.Single max_distance)
  System.Void criAtomEx3dSource_SetInteriorPanField(System.IntPtr ex_3d_source, System.Single source_radius, System.Single interior_distance)
  System.Void criAtomEx3dSource_SetDopplerFactor(System.IntPtr ex_3d_source, System.Single doppler_factor)
  System.Void criAtomEx3dSource_SetVolume(System.IntPtr ex_3d_source, System.Single volume)
  System.Void criAtomEx3dSource_SetMaxAngleAisacDelta(System.IntPtr ex_3d_source, System.Single max_delta)
  System.Void criAtomEx3dSource_SetAttenuationDistanceSetting(System.IntPtr ex_3d_source, System.Boolean flag)
  System.Boolean criAtomEx3dSource_GetAttenuationDistanceSetting(System.IntPtr ex_3d_source)
  System.Void criAtomEx3dSource_SetRandomPositionConfig(System.IntPtr ex_3d_source, CriWare.CriAtomEx.Randomize3dConfig& config)
  System.Void criAtomEx3dSource_SetRandomPositionConfig(System.IntPtr ex_3d_source, System.IntPtr config)
  System.Void criAtomEx3dSource_SetRandomPositionList(System.IntPtr ex_3d_source, CriWare.CriAtomEx.NativeVector[] position_list, System.UInt32 length)
  System.Void criAtomEx3dSource_SetDistanceAisacControlId(System.IntPtr ex_3d_source, System.UInt16 aisac_control_id)
  System.Boolean criAtomEx3dSource_IsDestroyable(System.IntPtr ex_3d_source)
  CriWare.CriAtomEx.NativeVector criAtomEx3dSource_GetPosition(System.IntPtr ex_3d_source)
  System.Void criAtomEx3dSource_Set3dRegionHn(System.IntPtr ex_3d_source, System.IntPtr ex_3d_region)
  System.Void criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId(System.IntPtr ex_3d_source, System.UInt16 aisac_control_id)
  System.Void criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId(System.IntPtr ex_3d_source, System.UInt16 aisac_control_id)
END_CLASS

CLASS: CriWare.CriAtomEx3dTransceiver
TYPE:  class
TOKEN: 0x200005E
EXTENDS: CriDisposable
FIELDS:
  private           System.IntPtr                   handle  // 0x20
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.IntPtr get_nativeHandle()
  System.Void Update()
  System.Void SetInputPosition(UnityEngine.Vector3 position)
  System.Void SetOutputPosition(UnityEngine.Vector3 position)
  System.Void SetInputOrientation(UnityEngine.Vector3 front, UnityEngine.Vector3 top)
  System.Void SetOutputOrientation(UnityEngine.Vector3 front, UnityEngine.Vector3 top)
  System.Void SetOutputConeParameter(System.Single insideAngle, System.Single outsideAngle, System.Single outsideVolume)
  System.Void SetOutputMinMaxDistance(System.Single minDistance, System.Single maxDistance)
  System.Void SetOutputInteriorPanField(System.Single radius, System.Single interiorDistance)
  System.Void SetInputCrossFadeField(System.Single directAudioRadius, System.Single crossfadeDistance)
  System.Void SetOutputVolume(System.Single volume)
  System.Void AttachAisac(System.String globalAisacName)
  System.Void DetachAisac(System.String globalAisacName)
  System.Void SetMaxAngleAisacDelta(System.Single maxDelta)
  System.Void SetDistanceAisacControlId(System.UInt16 aisacControlId)
  System.Void SetListenerBasedAzimuthAngleAisacControlId(System.UInt16 aisacControlId)
  System.Void SetListenerBasedElevationAngleAisacControlId(System.UInt16 aisacControlId)
  System.Void SetTransceiverOutputBasedAzimuthAngleAisacControlId(System.UInt16 aisacControlId)
  System.Void SetTransceiverOutputBasedElevationAngleAisacControlId(System.UInt16 aisacControlId)
  System.Void Set3dRegion(CriWare.CriAtomEx3dRegion region3d)
  System.Void Finalize()
END_CLASS

CLASS: CriWare.CriAtomEx3dRegion
TYPE:  class
TOKEN: 0x2000061
EXTENDS: CriDisposable
FIELDS:
  private           System.IntPtr                   handle  // 0x20
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Finalize()
  System.IntPtr get_nativeHandle()
END_CLASS

CLASS: CriWare.CriAtomExAcb
TYPE:  class
TOKEN: 0x2000064
EXTENDS: CriDisposable
FIELDS:
  private           System.IntPtr                   handle  // 0x20
  private           System.Runtime.InteropServices.GCHandledataHandle  // 0x28
METHODS:
  System.IntPtr get_nativeHandle()
  System.Boolean get_isAvailable()
  CriWare.CriAtomExAcb LoadAcbFile(CriWare.CriFsBinder binder, System.String acbPath, System.String awbPath)
  CriWare.CriAtomExAcb LoadAcbData(System.Byte[] acbData, CriWare.CriFsBinder awbBinder, System.String awbPath)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean Exists(System.String cueName)
  System.Boolean Exists(System.Int32 cueId)
  System.Boolean GetCueInfo(System.String cueName, CriWare.CriAtomEx.CueInfo& info)
  System.Boolean GetCueInfo(System.Int32 cueId, CriWare.CriAtomEx.CueInfo& info)
  System.Boolean GetCueInfoByIndex(System.Int32 index, CriWare.CriAtomEx.CueInfo& info)
  CriWare.CriAtomEx.CueInfo[] GetCueInfoList()
  System.Boolean GetWaveFormInfo(System.String cueName, CriWare.CriAtomEx.WaveformInfo& info)
  System.Boolean GetWaveFormInfo(System.Int32 cueId, CriWare.CriAtomEx.WaveformInfo& info)
  System.Int32 GetNumCuePlaying(System.String name)
  System.Int32 GetNumCuePlaying(System.Int32 id)
  System.Int32 GetBlockIndex(System.String cueName, System.String blockName)
  System.Int32 GetBlockIndex(System.Int32 cueId, System.String blockName)
  System.Int32 GetNumUsableAisacControls(System.String cueName)
  System.Int32 GetNumUsableAisacControls(System.Int32 cueId)
  System.Boolean GetUsableAisacControl(System.String cueName, System.Int32 index, CriWare.CriAtomEx.AisacControlInfo& info)
  System.Boolean GetUsableAisacControl(System.Int32 cueId, System.Int32 index, CriWare.CriAtomEx.AisacControlInfo& info)
  CriWare.CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(System.String cueName)
  CriWare.CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(System.Int32 cueId)
  System.Void ResetCueTypeState(System.String cueName)
  System.Void ResetCueTypeState(System.Int32 cueId)
  System.Void AttachAwbFile(CriWare.CriFsBinder awb_binder, System.String awb_path, System.String awb_name)
  System.Void DetachAwbFile(System.String awb_name)
  System.Boolean IsReadyToRelease()
  System.Single GetLoadProgress()
  System.Void Decrypt(System.UInt64 key, System.UInt64 nonce)
  System.Void .ctor(System.IntPtr handle, System.Nullable<System.Runtime.InteropServices.GCHandle> dataHandle)
  System.Void Finalize()
  System.IntPtr criAtomExAcb_LoadAcbFile(System.IntPtr acb_binder, System.String acb_path, System.IntPtr awb_binder, System.String awb_path, System.IntPtr work, System.Int32 work_size)
  System.IntPtr criAtomExAcb_LoadAcbData(System.IntPtr acb_data, System.Int32 acb_data_size, System.IntPtr awb_binder, System.String awb_path, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomExAcb_Release(System.IntPtr acb_hn)
  System.Int32 criAtomExAcb_GetNumCues(System.IntPtr acb_hn)
  System.Boolean criAtomExAcb_ExistsId(System.IntPtr acb_hn, System.Int32 id)
  System.Boolean criAtomExAcb_ExistsName(System.IntPtr acb_hn, System.String name)
  System.Int32 criAtomExAcb_GetNumUsableAisacControlsById(System.IntPtr acb_hn, System.Int32 id)
  System.Int32 criAtomExAcb_GetNumUsableAisacControlsByName(System.IntPtr acb_hn, System.String name)
  System.Boolean criAtomExAcb_GetUsableAisacControlById(System.IntPtr acb_hn, System.Int32 id, System.UInt16 index, System.IntPtr info)
  System.Boolean criAtomExAcb_GetUsableAisacControlByName(System.IntPtr acb_hn, System.String name, System.UInt16 index, System.IntPtr info)
  System.Boolean criAtomExAcb_GetWaveformInfoById(System.IntPtr acb_hn, System.Int32 id, System.IntPtr waveform_info)
  System.Boolean criAtomExAcb_GetWaveformInfoByName(System.IntPtr acb_hn, System.String name, System.IntPtr waveform_info)
  System.Boolean criAtomExAcb_GetCueInfoByName(System.IntPtr acb_hn, System.String name, System.IntPtr info)
  System.Boolean criAtomExAcb_GetCueInfoById(System.IntPtr acb_hn, System.Int32 id, System.IntPtr info)
  System.Boolean criAtomExAcb_GetCueInfoByIndex(System.IntPtr acb_hn, System.Int32 index, System.IntPtr info)
  System.Int32 criAtomExAcb_GetNumCuePlayingCountByName(System.IntPtr acb_hn, System.String name)
  System.Int32 criAtomExAcb_GetNumCuePlayingCountById(System.IntPtr acb_hn, System.Int32 id)
  System.Int32 criAtomExAcb_GetBlockIndexById(System.IntPtr acb_hn, System.Int32 id, System.String block_name)
  System.Int32 criAtomExAcb_GetBlockIndexByName(System.IntPtr acb_hn, System.String name, System.String block_name)
  System.Void criAtomExAcb_ResetCueTypeStateByName(System.IntPtr acb_hn, System.String name)
  System.Void criAtomExAcb_ResetCueTypeStateById(System.IntPtr acb_hn, System.Int32 id)
  System.Void criAtomExAcb_AttachAwbFile(System.IntPtr acb_hn, System.IntPtr awb_binder, System.String awb_path, System.String awb_name, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomExAcb_DetachAwbFile(System.IntPtr acb_hn, System.String awb_name)
  System.Boolean criAtomExAcb_IsReadyToRelease(System.IntPtr acb_hn)
END_CLASS

CLASS: CriWare.CriAtomExAcbLoader
TYPE:  class
TOKEN: 0x2000065
EXTENDS: CriDisposable
FIELDS:
  private           System.IntPtr                   handle  // 0x20
  private           System.Nullable<System.Runtime.InteropServices.GCHandle>gch  // 0x28
METHODS:
  CriWare.CriAtomExAcbLoader LoadAcbFileAsync(CriWare.CriFsBinder binder, System.String acbPath, System.String awbPath, System.Boolean loadAwbOnMemory)
  CriWare.CriAtomExAcbLoader LoadAcbDataAsync(System.Byte[] acbData, CriWare.CriFsBinder awbBinder, System.String awbPath, System.Boolean loadAwbOnMemory)
  CriWare.CriAtomExAcbLoader.Status GetStatus()
  CriWare.CriAtomExAcb MoveAcb()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor(System.IntPtr handle, System.Nullable<System.Runtime.InteropServices.GCHandle> dataHandle)
  System.Void Finalize()
  System.IntPtr criAtomExAcbLoader_Create(CriWare.CriAtomExAcbLoader.LoaderConfig& config)
  System.Void criAtomExAcbLoader_Destroy(System.IntPtr acb_loader)
  System.Boolean criAtomExAcbLoader_LoadAcbFileAsync(System.IntPtr acb_loader, System.IntPtr acb_binder, System.String acb_path, System.IntPtr awb_binder, System.String awb_path)
  System.Boolean criAtomExAcbLoader_LoadAcbDataAsync(System.IntPtr acb_loader, System.IntPtr acb_data, System.Int32 acb_size, System.IntPtr awb_binder, System.String awb_path)
  CriWare.CriAtomExAcbLoader.Status criAtomExAcbLoader_GetStatus(System.IntPtr acb_loader)
  System.Boolean criAtomExAcbLoader_WaitForCompletion(System.IntPtr acb_loader)
  System.IntPtr criAtomExAcbLoader_MoveAcbHandle(System.IntPtr acb_loader)
END_CLASS

CLASS: CriWare.CriAtomExAcf
TYPE:  class
TOKEN: 0x2000068
FIELDS:
METHODS:
  System.Int32 GetNumAisacControls()
  System.Boolean GetAisacControlInfo(System.UInt16 index, CriWare.CriAtomEx.AisacControlInfo& info)
  System.Int32 GetNumDspSettings()
  System.Int32 GetNumDspSettings(System.IntPtr acfData, System.Int32 size)
  System.String GetDspSettingNameByIndex(System.UInt16 index)
  System.String GetDspSettingNameByIndex(System.IntPtr acfData, System.Int32 size, System.UInt16 index)
  System.Boolean GetDspSettingInformation(System.String name, CriWare.CriAtomExAcf.AcfDspSettingInfo& info)
  System.Boolean GetDspSettingSnapshotInformation(System.UInt16 index, CriWare.CriAtomExAcf.AcfDspSettingSnapshotInfo& info)
  System.Boolean GetDspBusInformation(System.UInt16 index, CriWare.CriAtomExAcf.AcfDspBusInfo& info)
  System.Boolean GetDspBusLinkInformation(System.UInt16 index, CriWare.CriAtomExAcf.AcfDspBusLinkInfo& info)
  System.Int32 GetNumCategories()
  System.Int32 GetNumCategoriesPerPlayback()
  System.Boolean GetCategoryInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcf.CategoryInfo& info)
  System.Boolean GetCategoryInfoByName(System.String name, CriWare.CriAtomExAcf.CategoryInfo& info)
  System.Boolean GetCategoryInfoById(System.UInt32 id, CriWare.CriAtomExAcf.CategoryInfo& info)
  System.Int32 GetNumGlobalAisacs()
  System.Boolean GetGlobalAisacInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcf.GlobalAisacInfo& info)
  System.Boolean GetGlobalAisacInfoByName(System.String name, CriWare.CriAtomExAcf.GlobalAisacInfo& info)
  System.Boolean GetGlobalAisacGraphInfo(CriWare.CriAtomExAcf.GlobalAisacInfo aisacInfo, System.UInt16 graphIndex, CriWare.CriAtomExAcf.AisacGraphInfo& graphInfo)
  System.Boolean GetGlobalAisacValue(CriWare.CriAtomExAcf.GlobalAisacInfo aisacInfo, System.Single control, CriWare.CriAtomExAcf.AisacGraphType type, System.Single& value)
  System.Boolean GetAcfInfo(CriWare.CriAtomExAcf.AcfInfo& acfInfo)
  System.Int32 GetNumSelectors()
  System.Boolean GetSelectorInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcf.SelectorInfo& info)
  System.Boolean GetSelectorInfoByName(System.String name, CriWare.CriAtomExAcf.SelectorInfo& info)
  System.Boolean GetSelectorLabelInfo(CriWare.CriAtomExAcf.SelectorInfo selectorInfo, System.UInt16 labelIndex, CriWare.CriAtomExAcf.SelectorLabelInfo& info)
  System.Int32 GetNumBuses()
  System.Int32 GetMaxBusesOfDspBusSettings()
  System.String FindBusName(System.String busName)
  System.Int32 criAtomExAcf_GetNumAisacControls()
  System.Boolean criAtomExAcf_GetAisacControlInfo(System.UInt16 index, System.IntPtr info)
  System.UInt32 criAtomExAcf_GetAisacControlIdByName(System.String name)
  System.String criAtomExAcf_GetAisacControlNameById(System.UInt32 id)
  System.Int32 criAtomExAcf_GetNumDspSettings()
  System.Int32 criAtomExAcf_GetNumDspSettingsFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size)
  System.IntPtr criAtomExAcf_GetDspSettingNameByIndex(System.UInt16 index)
  System.IntPtr criAtomExAcf_GetDspSettingNameByIndexFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size, System.UInt16 index)
  System.Boolean criAtomExAcf_GetDspSettingInformation(System.String name, System.IntPtr info)
  System.Boolean criAtomExAcf_GetDspSettingSnapshotInformation(System.UInt16 index, System.IntPtr info)
  System.Boolean criAtomExAcf_GetDspBusInformation(System.UInt16 index, System.IntPtr info)
  System.Int32 criAtomExAcf_GetDspFxType(System.UInt16 index)
  System.String criAtomExAcf_GetDspFxName(System.UInt16 index)
  System.Boolean criAtomExAcf_GetDspFxParameters(System.UInt16 index, System.IntPtr parameters, System.Int32 size)
  System.Boolean criAtomExAcf_GetDspBusLinkInformation(System.UInt16 index, System.IntPtr info)
  System.Int32 criAtomExAcf_GetNumCategoriesFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size)
  System.Int32 criAtomExAcf_GetNumCategories()
  System.Int32 criAtomExAcf_GetNumCategoriesPerPlaybackFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size)
  System.Int32 criAtomExAcf_GetNumCategoriesPerPlayback()
  System.Boolean criAtomExAcf_GetCategoryInfo(System.UInt16 index, System.IntPtr info)
  System.Boolean criAtomExAcf_GetCategoryInfoByName(System.String name, System.IntPtr info)
  System.Boolean criAtomExAcf_GetCategoryInfoById(System.UInt32 id, System.IntPtr info)
  System.Int32 criAtomExAcf_GetNumGlobalAisacs()
  System.Boolean criAtomExAcf_GetGlobalAisacInfo(System.UInt16 index, System.IntPtr info)
  System.Boolean criAtomExAcf_GetGlobalAisacInfoByName(System.String name, System.IntPtr info)
  System.Boolean criAtomExAcf_GetGlobalAisacGraphInfo(System.IntPtr aisac_info, System.UInt16 graph_index, System.IntPtr graph_info)
  System.Boolean criAtomExAcf_GetGlobalAisacValue(System.IntPtr aisac_info, System.Single control, CriWare.CriAtomExAcf.AisacGraphType type, System.Single& value)
  System.Boolean criAtomExAcf_GetAcfInfo(System.IntPtr acf_info)
  System.Boolean criAtomExAcf_GetAcfInfoFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size, System.IntPtr acf_info)
  System.Int32 criAtomExAcf_GetNumSelectors()
  System.Boolean criAtomExAcf_GetSelectorInfoByIndex(System.UInt16 index, System.IntPtr info)
  System.Boolean criAtomExAcf_GetSelectorInfoByName(System.String name, System.IntPtr info)
  System.Boolean criAtomExAcf_GetSelectorLabelInfo(System.IntPtr selector_info, System.UInt16 label_index, System.IntPtr info)
  System.Int32 criAtomExAcf_GetNumBusesFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size)
  System.Int32 criAtomExAcf_GetNumBuses()
  System.Int32 criAtomExAcf_GetMaxBusesOfDspBusSettingsFromAcfData(System.IntPtr acf_data, System.Int32 acf_data_size)
  System.Int32 criAtomExAcf_GetMaxBusesOfDspBusSettings()
  System.String criAtomExAcf_FindBusName(System.String bus_name)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtomExAsrRack
TYPE:  class
TOKEN: 0x2000077
EXTENDS: CriDisposable
FIELDS:
  public    static  System.Int32                    defaultRackId  // 0x0
  private           System.Int32                    _rackId  // 0x20
  private           System.Boolean                  hasExistingRackId  // 0x24
METHODS:
  System.Void .ctor(CriWare.CriAtomExAsrRack.Config config, CriWare.CriAtomExAsrRack.PlatformConfig platformConfig)
  System.Void .ctor(System.Int32 existingRackId)
  System.Void AttachDspBusSetting(System.String settingName)
  System.Void DetachDspBusSetting()
  System.Void ApplyDspBusSnapshot(System.String snapshotName, System.Int32 timeMs)
  System.String GetAppliedDspBusSnapshotName(System.Int32 rackId)
  System.String GetAppliedDspBusSnapshotName()
  CriWare.CriAtomExAsrRack.PerformanceInfo GetPerformanceInfo()
  CriWare.CriAtomExAsrRack.PerformanceInfo GetPerformanceInfoByRackId(System.Int32 rackId)
  System.Void ResetPerformanceMonitor()
  System.Void ResetPerformanceMonitorByRackId(System.Int32 rackId)
  System.Void SetAisacControl(System.Int32 rackId, System.String controlName, System.Single value)
  System.Void SetAisacControl(System.Int32 rackId, System.Int32 controlId, System.Single value)
  System.Void Dispose()
  System.Int32 get_rackId()
  CriWare.CriAtomExAsrRack.Config get_defaultConfig()
  System.Void Finalize()
  System.Int32 CRIWARE6158351D(CriWare.CriAtomExAsrRack.Config& config, CriWare.CriAtomExAsrRack.PlatformConfig& platformConfig)
  System.Void criAtomExAsrRack_Destroy(System.Int32 rackId)
  System.Void criAtomExAsrRack_AttachDspBusSetting(System.Int32 rackId, System.String setting, System.IntPtr work, System.Int32 workSize)
  System.Void criAtomExAsrRack_DetachDspBusSetting(System.Int32 rackId)
  System.IntPtr criAtomExAsrRack_GetAppliedDspBusSnapshotName(System.Int32 rackId)
  System.Void criAtomExAsrRack_ApplyDspBusSnapshot(System.Int32 rackId, System.String snapshotName, System.Int32 timeMs)
  System.Void criAtomExAsrRack_GetPerformanceInfo(System.Int32 rackId, CriWare.CriAtomExAsrRack.PerformanceInfo& perfInfo)
  System.Void criAtomExAsrRack_ResetPerformanceMonitor(System.Int32 rackId)
  System.Void criAtomExAsrRack_SetAisacControlById(System.Int32 rackId, System.UInt16 controlId, System.Single value)
  System.Void criAtomExAsrRack_SetAisacControlByName(System.Int32 rackId, System.String controlName, System.Single value)
END_CLASS

CLASS: CriWare.CriAtomExAuxIn
TYPE:  class
TOKEN: 0x200007C
EXTENDS: CriDisposable
FIELDS:
  private   static  System.String                   errorInvalidHandle  // 0x0
  private           System.IntPtr                   handle  // 0x20
  private           CriWare.CriAudioReadStream      inputReadStream  // 0x28
METHODS:
  System.Void .ctor(System.Nullable<CriWare.CriAtomExAuxIn.Config> config)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Start()
  System.Void Stop()
  System.Void SetFormat(System.Int32 numChannels, System.Int32 samplingRate)
  System.Void GetFormat(System.Int32& numChannels, System.Int32& samplingRate)
  System.Void SetVolume(System.Single volume)
  System.Void SetFrequencyRatio(System.Single frequencyRatio)
  System.Void SetBusSendLevel(System.String busName, System.Single level)
  System.Void SetInputReadStream(CriWare.CriAudioReadStream stream)
  System.IntPtr criAtomAuxIn_Create(CriWare.CriAtomExAuxIn.Config& config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomAuxIn_Destroy(System.IntPtr aux_in)
  System.Void criAtomAuxIn_Start(System.IntPtr aux_in)
  System.Void criAtomAuxIn_Stop(System.IntPtr aux_in)
  System.Void criAtomAuxIn_SetVolume(System.IntPtr aux_in, System.Single volume)
  System.Void criAtomAuxIn_SetFrequencyRatio(System.IntPtr aux_in, System.Single ratio)
  System.Void criAtomAuxIn_SetBusSendLevelByName(System.IntPtr aux_in, System.String bus_name, System.Single level)
  System.Void criAtomAuxIn_SetFormat(System.IntPtr aux_in, System.Int32 num_channels, System.Int32 sampling_rate)
  System.Void criAtomAuxIn_GetFormat(System.IntPtr aux_in, System.Int32& num_channels, System.Int32& sampling_rate)
  System.Void criAtomAuxIn_SetInputReadStream(System.IntPtr aux_in, System.IntPtr stream_cbfunc, System.IntPtr stream_ptr)
END_CLASS

CLASS: CriWare.CriAtomExMic
TYPE:  class
TOKEN: 0x200007E
EXTENDS: CriDisposable
FIELDS:
  private   static  System.String                   errorInvalidHandle  // 0x0
  private   static  System.String                   errorInvalidBufferLength  // 0x0
  private   static  System.String                   errorInvalidNumBuffers  // 0x0
  private   static  System.String                   errorAlreadyInitialized  // 0x0
  private   static  System.String                   errorNotInitialized  // 0x0
  private   static  System.Boolean                  <isInitialized>k__BackingField  // 0x0
  private           System.IntPtr                   handle  // 0x20
  private           System.IntPtr[]                 bufferPointers  // 0x28
  private           System.Runtime.InteropServices.GCHandle[]gcHandles  // 0x30
  private           CriWare.CriAudioWriteStream     outputWriteStream  // 0x38
  private   static  System.Int32                    _initializationCount  // 0x4
METHODS:
  System.Boolean get_isInitialized()
  System.Void set_isInitialized(System.Boolean value)
  System.Void InitializeModule()
  System.Void FinalizeModule()
  System.Void SetupOutputCategoryForMic_IOS(System.Boolean enable)
  CriWare.CriAtomExMic.DeviceInfo[] GetDevices()
  System.Int32 GetNumDevices()
  System.Nullable<CriWare.CriAtomExMic.DeviceInfo> GetDefaultDevice()
  System.Boolean IsFormatSupported(CriWare.CriAtomExMic.Config config)
  CriWare.CriAtomExMic Create(System.Nullable<CriWare.CriAtomExMic.Config> config)
  System.Void .ctor(System.IntPtr handle)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Start()
  System.Void Stop()
  System.Int32 GetNumChannels()
  System.Int32 GetSamplingRate()
  System.UInt32 GetNumBufferedSamples()
  System.UInt32 GetNumBufferredSamples()
  System.Boolean IsAvailable()
  System.UInt32 ReadData(System.Single[] bufferMono)
  System.UInt32 ReadData(System.Single[] bufferMono, System.UInt32 numToRead)
  System.UInt32 ReadData(System.Single[] bufferL, System.Single[] bufferR)
  System.UInt32 ReadData(System.Single[] bufferL, System.Single[] bufferR, System.UInt32 numToRead)
  System.UInt32 ReadData(System.Single[][] buffers)
  System.UInt32 ReadData(System.Single[][] buffers, System.UInt32 numToRead)
  System.Void SetOutputWriteStream(CriWare.CriAudioWriteStream stream)
  CriWare.CriAudioReadStream GetOutputReadStream()
  CriWare.CriAtomExMic.Effect AttachEffect(System.IntPtr afxInterface, System.Single[] configParameters)
  System.Void DetachEffect(CriWare.CriAtomExMic.Effect effect)
  System.Void SetEffectParameter(CriWare.CriAtomExMic.Effect effect, System.Int32 parameterIndex, System.Single parameterValue)
  System.Single GetEffectParameter(CriWare.CriAtomExMic.Effect effect, System.Int32 parameterIndex)
  System.Void SetEffectBypass(CriWare.CriAtomExMic.Effect effect, System.Boolean bypass)
  System.Void UpdateEffectParameters(CriWare.CriAtomExMic.Effect effect)
  System.UInt32 InternalReadDataFromBufferPointers(System.UInt32 numToRead)
  System.Void InternalClearBuffers()
  System.Void criAtomMicUnity_Initialize()
  System.Void criAtomMicUnity_Finalize()
  System.Int32 criAtomMic_GetNumDevices()
  System.Boolean criAtomMic_GetDevice(System.Int32 index, CriWare.CriAtomExMic.DeviceInfo& info)
  System.Boolean criAtomMic_GetDefaultDevice(CriWare.CriAtomExMic.DeviceInfo& info)
  System.Boolean criAtomMic_IsFormatSupported(CriWare.CriAtomExMic.Config& config)
  System.IntPtr criAtomMic_Create(CriWare.CriAtomExMic.Config& config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomMic_Destroy(System.IntPtr mic)
  System.Void criAtomMic_Start(System.IntPtr mic)
  System.Void criAtomMic_Stop(System.IntPtr mic)
  System.Int32 criAtomMic_GetNumChannels(System.IntPtr mic)
  System.Int32 criAtomMic_GetSamplingRate(System.IntPtr mic)
  System.UInt32 criAtomMic_GetNumBufferedSamples(System.IntPtr mic)
  System.Boolean criAtomMic_IsAvailable(System.IntPtr mic)
  System.UInt32 criAtomMic_ReadData(System.IntPtr mic, System.IntPtr[] data, System.UInt32 num_samples)
  System.Void criAtomMic_SetOutputWriteStream(System.IntPtr mic, System.IntPtr stream_cbfunc, System.IntPtr stream_ptr)
  System.IntPtr criAtomMic_GetOutputReadStream()
  System.Int32 criAtomMic_CalculateWorkSizeForEffect(System.IntPtr mic, System.IntPtr afx_interface, System.Single[] config_parameters, System.UInt32 num_config_parameters)
  System.IntPtr criAtomMic_AttachEffect(System.IntPtr mic, System.IntPtr afx_interface, System.Single[] config_parameters, System.UInt32 num_config_parameters, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomMic_DetachEffect(System.IntPtr mic, System.IntPtr effect)
  System.IntPtr criAtomMic_GetEffectInstance(System.IntPtr mic, System.IntPtr effect)
  System.Void criAtomMic_SetEffectBypass(System.IntPtr mic, System.IntPtr effect, System.Boolean bypass)
  System.Void criAtomMic_SetEffectParameter(System.IntPtr mic, System.IntPtr effect, System.UInt32 parameter_index, System.Single parameter_value)
  System.Single criAtomMic_GetEffectParameter(System.IntPtr mic, System.IntPtr effect, System.UInt32 parameter_index)
  System.Void criAtomMic_UpdateEffectParameters(System.IntPtr mic, System.IntPtr effect)
END_CLASS

CLASS: CriWare.CriAtomExOutputAnalyzer
TYPE:  class
TOKEN: 0x2000082
EXTENDS: CriDisposable
FIELDS:
  public    static  System.Int32                    MaximumSpectrumBands  // 0x0
  protected         System.IntPtr                   handle  // 0x20
  protected         CriWare.CriAtomExPlayer         player  // 0x28
  protected         System.String                   busName  // 0x30
  protected         System.Int32                    numBands  // 0x38
  protected         System.Int32                    numCapturedPcmSamples  // 0x3C
  protected         CriWare.CriAtomExOutputAnalyzer.PcmCaptureCallbackuserPcmCaptureCallback  // 0x40
  protected         System.Single[]                 dataL  // 0x48
  protected         System.Single[]                 dataR  // 0x50
  protected static  System.Int32                    pcmCapturerNumMaxData  // 0x0
  protected static  System.IntPtr                   InternalCallbackFunctionPointer  // 0x0
  protected static  CriWare.CriAtomExOutputAnalyzer.InternalPcmCaptureCallbackDelegateObject  // 0x8
  protected static  System.Single[]                 DataL  // 0x10
  protected static  System.Single[]                 DataR  // 0x18
  protected static  CriWare.CriAtomExOutputAnalyzer.PcmCaptureCallbackUserPcmCaptureCallback  // 0x20
METHODS:
  System.IntPtr get_nativeHandle()
  System.Void .ctor(CriWare.CriAtomExOutputAnalyzer.Config config)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean AttachExPlayer(CriWare.CriAtomExPlayer player)
  System.Void DetachExPlayer()
  System.Boolean AttachDspBus(System.String busName)
  System.Void DetachDspBus()
  System.Single GetRms(System.Int32 channel)
  System.Void GetSpectrumLevels(System.Single[]& levels)
  System.Void GetPcmData(System.Single[]& data, System.Int32 ch)
  System.Void SetPcmCaptureCallback(CriWare.CriAtomExOutputAnalyzer.PcmCaptureCallback callback)
  System.Void ExecutePcmCaptureCallback()
  System.Void ExecutePcmCaptureCallback(CriWare.CriAtomExOutputAnalyzer.PcmCaptureCallback callback)
  System.Void .ctor()
  System.Void Finalize()
  System.Void InitializeWithConfig(CriWare.CriAtomExOutputAnalyzer.Config config)
  System.Void Callback(System.IntPtr ptrL, System.IntPtr ptrR, System.Int32 numChannels, System.Int32 numData)
  System.IntPtr criAtomExOutputAnalyzer_Create(CriWare.CriAtomExOutputAnalyzer.Config& config)
  System.Void criAtomExOutputAnalyzer_Destroy(System.IntPtr analyzer)
  System.Void criAtomExOutputAnalyzer_AttachExPlayer(System.IntPtr analyzer, System.IntPtr player)
  System.Void criAtomExOutputAnalyzer_DetachExPlayer(System.IntPtr analyzer, System.IntPtr player)
  System.Void criAtomExOutputAnalyzer_AttachDspBusByName(System.IntPtr analyzer, System.String busName)
  System.Void criAtomExOutputAnalyzer_DetachDspBusByName(System.IntPtr analyzer, System.String busName)
  System.Single criAtomExOutputAnalyzer_GetRms(System.IntPtr analyzer, System.Int32 channel)
  System.IntPtr criAtomExOutputAnalyzer_GetSpectrumLevels(System.IntPtr analyzer)
  System.IntPtr criAtomExOutputAnalyzer_GetPcmData(System.IntPtr analyzer, System.Int32 ch)
  System.Void criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks(System.IntPtr analyzer, System.IntPtr callback)
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriAtomExPlayback
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  private           System.UInt32                   <id>k__BackingField  // 0x10
  public    static  System.UInt32                   invalidId  // 0x0
METHODS:
  System.Void .ctor(System.UInt32 id)
  System.Void Stop(System.Boolean ignoresReleaseTime)
  System.Void Pause()
  System.Void Resume(CriWare.CriAtomEx.ResumeMode mode)
  System.Boolean IsPaused()
  System.Boolean GetFormatInfo(CriWare.CriAtomEx.FormatInfo& info)
  CriWare.CriAtomExPlayback.Status GetStatus()
  System.Int64 GetTime()
  System.Int64 GetTimeSyncedWithAudio()
  System.Boolean GetNumPlayedSamples(System.Int64& numSamples, System.Int32& samplingRate)
  System.Int64 GetSequencePosition()
  System.Int32 GetCurrentBlockIndex()
  System.Boolean GetTrackInfo(CriWare.CriAtomExPlayback.TrackInfo& info)
  System.Boolean GetBeatSyncInfo(CriWare.CriAtomExBeatSync.Info& info)
  System.Void SetNextBlockIndex(System.Int32 index)
  System.Boolean SetBeatSyncOffset(System.Int16 timeMs)
  System.UInt32 get_id()
  System.Void set_id(System.UInt32 value)
  CriWare.CriAtomExPlayback.Status get_status()
  System.Int64 get_time()
  System.Int64 get_timeSyncedWithAudio()
  System.Void Stop()
  System.Void StopWithoutReleaseTime()
  System.Void Pause(System.Boolean sw)
  System.Void criAtomExPlayback_Stop(System.UInt32 id)
  System.Void criAtomExPlayback_StopWithoutReleaseTime(System.UInt32 id)
  System.Void criAtomExPlayback_Pause(System.UInt32 id, System.Boolean sw)
  System.Void criAtomExPlayback_Resume(System.UInt32 id, CriWare.CriAtomEx.ResumeMode mode)
  System.Boolean criAtomExPlayback_IsPaused(System.UInt32 id)
  CriWare.CriAtomExPlayback.Status criAtomExPlayback_GetStatus(System.UInt32 id)
  System.Boolean criAtomExPlayback_GetFormatInfo(System.UInt32 id, CriWare.CriAtomEx.FormatInfo& info)
  System.Int64 criAtomExPlayback_GetTime(System.UInt32 id)
  System.Int64 criAtomExPlayback_GetTimeSyncedWithAudio(System.UInt32 id)
  System.Boolean criAtomExPlayback_GetNumPlayedSamples(System.UInt32 id, System.Int64& num_samples, System.Int32& sampling_rate)
  System.Int64 criAtomExPlayback_GetSequencePosition(System.UInt32 id)
  System.Void criAtomExPlayback_SetNextBlockIndex(System.UInt32 id, System.Int32 index)
  System.Int32 criAtomExPlayback_GetCurrentBlockIndex(System.UInt32 id)
  System.Boolean criAtomExPlayback_GetPlaybackTrackInfo(System.UInt32 id, CriWare.CriAtomExPlayback.TrackInfo& info)
  System.Boolean criAtomExPlayback_GetBeatSyncInfo(System.UInt32 id, CriWare.CriAtomExBeatSync.Info& info)
  System.Boolean criAtomExPlayback_SetBeatSyncOffset(System.UInt32 id, System.Int16 timeMs)
END_CLASS

CLASS: CriWare.CriAtomExPlayer
TYPE:  class
TOKEN: 0x2000089
EXTENDS: CriDisposable
FIELDS:
  private           CriWare.CriAtomExBeatSync.CbFunc_onBeatSyncCallback  // 0x20
  private           CriWare.CriAtomExSequencer.EventCallback_onSequenceCallback  // 0x28
  private           System.Boolean                  hasExistingNativeHandle  // 0x30
  private           System.IntPtr                   entryPoolHandle  // 0x38
  private           System.Int32                    _entryPoolCapacity  // 0x40
  private           System.Int32                    max_path  // 0x44
  private           System.IntPtr                   handle  // 0x48
METHODS:
  System.IntPtr get_nativeHandle()
  System.Boolean get_isAvailable()
  System.Void add__onBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value)
  System.Void remove__onBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value)
  System.Void add_OnBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value)
  System.Void remove_OnBeatSyncCallback(CriWare.CriAtomExBeatSync.CbFunc value)
  System.Void add__onSequenceCallback(CriWare.CriAtomExSequencer.EventCallback value)
  System.Void remove__onSequenceCallback(CriWare.CriAtomExSequencer.EventCallback value)
  System.Void add_OnSequenceCallback(CriWare.CriAtomExSequencer.EventCallback value)
  System.Void remove_OnSequenceCallback(CriWare.CriAtomExSequencer.EventCallback value)
  System.Void .ctor()
  System.Void .ctor(System.Int32 maxPath, System.Int32 maxPathStrings)
  System.Void .ctor(System.Boolean enableAudioSyncedTimer)
  System.Void .ctor(System.Int32 maxPath, System.Int32 maxPathStrings, System.Boolean enableAudioSyncedTimer)
  System.Void .ctor(System.IntPtr existingNativeHandle)
  System.Void .ctor(System.Int32 maxPath, System.Int32 maxPathStrings, System.Boolean enableAudioSyncedTimer, System.IntPtr existingNativeHandle)
  System.Void Dispose()
  System.Void SetCue(CriWare.CriAtomExAcb acb, System.String name)
  System.Void SetCue(CriWare.CriAtomExAcb acb, System.Int32 id)
  System.Void SetCueIndex(CriWare.CriAtomExAcb acb, System.Int32 index)
  System.Void SetContentId(CriWare.CriFsBinder binder, System.Int32 contentId)
  System.Void SetFile(CriWare.CriFsBinder binder, System.String path)
  System.Void SetData(System.Byte[] buffer, System.Int32 size)
  System.Void SetData(System.IntPtr buffer, System.Int32 size)
  System.Void SetFormat(CriWare.CriAtomEx.Format format)
  System.Void SetNumChannels(System.Int32 numChannels)
  System.Void SetSamplingRate(System.Int32 samplingRate)
  System.Void PrepareEntryPool(System.Int32 capacity, System.Boolean stopOnEmpty)
  System.Int32 GetNumEntries()
  System.Int32 GetNumConsumedEntries()
  System.Int32 get_entryPoolCapacity()
  System.Boolean EntryFile(CriWare.CriFsBinder binder, System.String path, System.Boolean repeat)
  System.Boolean EntryContentId(CriWare.CriFsBinder binder, System.Int32 contentId, System.Boolean repeat)
  System.Boolean EntryData(System.Byte[] buffer, System.Int32 size, System.Boolean repeat)
  System.Boolean EntryData(System.IntPtr buffer, System.Int32 size, System.Boolean repeat)
  System.Boolean EntryCue(CriWare.CriAtomExAcb acb, System.String name, System.Boolean repeat)
  CriWare.CriAtomExPlayback Start()
  CriWare.CriAtomExPlayback Prepare()
  System.Void Stop(System.Boolean ignoresReleaseTime)
  System.Void Pause()
  System.Void Resume(CriWare.CriAtomEx.ResumeMode mode)
  System.Boolean IsPaused()
  System.Void SetVolume(System.Single volume)
  System.Void SetPitch(System.Single pitch)
  System.Void SetPlaybackRatio(System.Single ratio)
  System.Void SetPan3dAngle(System.Single angle)
  System.Void SetPan3dInteriorDistance(System.Single distance)
  System.Void SetPan3dVolume(System.Single volume)
  System.Void SetPanType(CriWare.CriAtomEx.PanType panType)
  System.Void SetSendLevel(System.Int32 channel, CriWare.CriAtomEx.Speaker id, System.Single level)
  System.Void SetBiquadFilterParameters(CriWare.CriAtomEx.BiquadFilterType type, System.Single frequency, System.Single gain, System.Single q)
  System.Void SetBandpassFilterParameters(System.Single cofLow, System.Single cofHigh)
  System.Void SetBusSendLevel(System.String busName, System.Single level)
  System.Boolean GetBusSendLevel(System.String busName, System.Single& level)
  System.Void SetBusSendLevel(System.Int32 busId, System.Single level)
  System.Void SetBusSendLevelOffset(System.String busName, System.Single levelOffset)
  System.Boolean GetBusSendLevelOffset(System.String busName, System.Single& level)
  System.Void SetBusSendLevelOffset(System.Int32 busId, System.Single levelOffset)
  System.Void AttachAisac(System.String globalAisacName)
  System.Void DetachAisac(System.String globalAisacName)
  System.Void SetAisacControl(System.String controlName, System.Single value)
  System.Void SetAisac(System.String controlName, System.Single value)
  System.Void SetAisacControl(System.UInt32 controlId, System.Single value)
  System.Void SetAisac(System.UInt32 controlId, System.Single value)
  System.Boolean GetAttachedAisacInfo(System.Int32 aisacAttachedIndex, CriWare.CriAtomEx.AisacInfo& aisacInfo)
  System.Void Set3dSource(CriWare.CriAtomEx3dSource source)
  System.Void Set3dListener(CriWare.CriAtomEx3dListener listener)
  System.Void SetStartTime(System.Int64 startTimeMs)
  System.Void SetFirstBlockIndex(System.Int32 index)
  System.Void SetSelectorLabel(System.String selector, System.String label)
  System.Void UnsetSelectorLabel(System.String selector)
  System.Void ClearSelectorLabels()
  System.Void SetCategory(System.Int32 categoryId)
  System.Void SetCategory(System.String categoryName)
  System.Void UnsetCategory()
  System.Void SetCuePriority(System.Int32 priority)
  System.Void SetVoicePriority(System.Int32 priority)
  System.Void SetVoiceControlMethod(CriWare.CriAtomEx.VoiceControlMethod method)
  System.Void SetPreDelayTime(System.Single time)
  System.Void SetEnvelopeAttackTime(System.Single time)
  System.Void SetEnvelopeHoldTime(System.Single time)
  System.Void SetEnvelopeDecayTime(System.Single time)
  System.Void SetEnvelopeReleaseTime(System.Single time)
  System.Void SetEnvelopeSustainLevel(System.Single level)
  System.Void AttachFader()
  System.Void DetachFader()
  System.Void SetFadeOutTime(System.Int32 ms)
  System.Void SetFadeInTime(System.Int32 ms)
  System.Void SetFadeInStartOffset(System.Int32 ms)
  System.Void SetFadeOutEndDelay(System.Int32 ms)
  System.Boolean IsFading()
  System.Void ResetFaderParameters()
  System.Void SetGroupNumber(System.Int32 group_no)
  System.Void Update(CriWare.CriAtomExPlayback playback)
  System.Void UpdateAll()
  System.Void ResetParameters()
  System.Int64 GetTime()
  CriWare.CriAtomExPlayer.Status GetStatus()
  System.Single GetParameterFloat32(CriWare.CriAtomEx.Parameter id)
  System.UInt32 GetParameterUint32(CriWare.CriAtomEx.Parameter id)
  System.Int32 GetParameterSint32(CriWare.CriAtomEx.Parameter id)
  System.Void SetSoundRendererType(CriWare.CriAtomEx.SoundRendererType type)
  System.Void SetRandomSeed(System.UInt32 seed)
  System.Void Loop(System.Boolean sw)
  System.Void SetAsrRackId(System.Int32 asr_rack_id)
  System.Void SetVoicePoolIdentifier(System.UInt32 identifier)
  System.Void SetDspTimeStretchRatio(System.Single ratio)
  System.Void SetDspPitchShifterPitch(System.Single pitch)
  System.Void SetDspParameter(System.Int32 id, System.Single value)
  System.Void SetSequencePrepareTime(System.UInt32 ms)
  System.Void AttachTween(CriWare.CriAtomExTween tween)
  System.Void DetachTween(CriWare.CriAtomExTween tween)
  System.Void DetachTweenAll()
  System.Void Stop()
  System.Void StopWithoutReleaseTime()
  System.Void Pause(System.Boolean sw)
  System.Void Finalize()
  System.Void OnBeatSyncCallbackChainInternal(CriWare.CriAtomExBeatSync.Info& info)
  System.Void OnSequenceCallbackChainInternal(CriWare.CriAtomExSequencer.CriAtomExSequenceEventInfo& info)
  System.IntPtr criAtomExPlayer_Create(CriWare.CriAtomExPlayer.Config& config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomExPlayer_Destroy(System.IntPtr player)
  System.Void criAtomExPlayer_SetCueId(System.IntPtr player, System.IntPtr acb_hn, System.Int32 id)
  System.Void criAtomExPlayer_SetCueName(System.IntPtr player, System.IntPtr acb_hn, System.String cue_name)
  System.Void criAtomExPlayer_SetCueIndex(System.IntPtr player, System.IntPtr acb_hn, System.Int32 index)
  System.Void criAtomExPlayer_SetFile(System.IntPtr player, System.IntPtr binder, System.String path)
  System.Void criAtomExPlayer_SetData(System.IntPtr player, System.Byte[] buffer, System.Int32 size)
  System.Void criAtomExPlayer_SetData(System.IntPtr player, System.IntPtr buffer, System.Int32 size)
  System.Void criAtomExPlayer_SetContentId(System.IntPtr player, System.IntPtr binder, System.Int32 id)
  System.Void criAtomExPlayer_SetVoicePoolIdentifier(System.IntPtr player, System.UInt32 identifier)
  System.UInt32 criAtomExPlayer_Start(System.IntPtr player)
  System.UInt32 criAtomExPlayer_Prepare(System.IntPtr player)
  System.Void criAtomExPlayer_Stop(System.IntPtr player)
  System.Void criAtomExPlayer_StopWithoutReleaseTime(System.IntPtr player)
  System.Void criAtomExPlayer_Pause(System.IntPtr player, System.Boolean sw)
  System.Void criAtomExPlayer_Resume(System.IntPtr player, CriWare.CriAtomEx.ResumeMode mode)
  System.Boolean criAtomExPlayer_IsPaused(System.IntPtr player)
  CriWare.CriAtomExPlayer.Status criAtomExPlayer_GetStatus(System.IntPtr player)
  System.Int64 criAtomExPlayer_GetTime(System.IntPtr player)
  System.Void criAtomExPlayer_SetFormat(System.IntPtr player, CriWare.CriAtomEx.Format format)
  System.Void criAtomExPlayer_SetNumChannels(System.IntPtr player, System.Int32 num_channels)
  System.Void criAtomExPlayer_SetSamplingRate(System.IntPtr player, System.Int32 sampling_rate)
  System.IntPtr CRIWAREF1DB6C3C(System.IntPtr player, System.Int32 capacity, System.Int32 max_path, System.Boolean stopOnEmpty)
  System.Void CRIWARE348B99F2(System.IntPtr pool)
  System.Int32 CRIWAREB0CA8CB3(System.IntPtr pool)
  System.Int32 CRIWAREF2104D05(System.IntPtr pool)
  System.Void CRIWAREBAFBC575(System.IntPtr pool)
  System.Boolean CRIWARE5277731E(System.IntPtr pool, System.IntPtr binder, System.String path, System.Boolean repeat, System.Int32 max_path)
  System.Boolean CRIWARE78E74FE0(System.IntPtr pool, System.IntPtr binder, System.Int32 id, System.Boolean repeat)
  System.Boolean CRIWARE10CB0D07(System.IntPtr pool, System.Byte[] buffer, System.Int32 size, System.Boolean repeat)
  System.Boolean CRIWARE10CB0D07(System.IntPtr pool, System.IntPtr buffer, System.Int32 size, System.Boolean repeat)
  System.Boolean CRIWARE59CCEB17(System.IntPtr pool, System.IntPtr acbhn, System.String name, System.Boolean repeat)
  System.Void CRIWARE94DBB2A3(System.IntPtr pool)
  System.Void criAtomExPlayer_SetStartTime(System.IntPtr player, System.Int64 start_time_ms)
  System.Void criAtomExPlayer_SetSequencePrepareTime(System.IntPtr player, System.UInt32 seq_prep_time_ms)
  System.Void criAtomExPlayer_LimitLoopCount(System.IntPtr player, System.Int32 count)
  System.Void criAtomExPlayer_Update(System.IntPtr player, System.UInt32 id)
  System.Void criAtomExPlayer_UpdateAll(System.IntPtr player)
  System.Void criAtomExPlayer_ResetParameters(System.IntPtr player)
  System.Single criAtomExPlayer_GetParameterFloat32(System.IntPtr player, CriWare.CriAtomEx.Parameter id)
  System.UInt32 criAtomExPlayer_GetParameterUint32(System.IntPtr player, CriWare.CriAtomEx.Parameter id)
  System.Int32 criAtomExPlayer_GetParameterSint32(System.IntPtr player, CriWare.CriAtomEx.Parameter id)
  System.IntPtr criAtomExPlayer_GetPlayerParameter(System.IntPtr player)
  System.Void criAtomExPlayerParameter_RemoveParameter(System.IntPtr player_parameter, System.UInt16 id)
  System.Void criAtomExPlayer_SetVolume(System.IntPtr player, System.Single volume)
  System.Void criAtomExPlayer_SetPitch(System.IntPtr player, System.Single pitch)
  System.Void criAtomExPlayer_SetPlaybackRatio(System.IntPtr player, System.Single playback_ratio)
  System.Void criAtomExPlayer_SetPan3dAngle(System.IntPtr player, System.Single pan3d_angle)
  System.Void criAtomExPlayer_SetPan3dInteriorDistance(System.IntPtr player, System.Single pan3d_interior_distance)
  System.Void criAtomExPlayer_SetPan3dVolume(System.IntPtr player, System.Single pan3d_volume)
  System.Void criAtomExPlayer_SetPanType(System.IntPtr player, CriWare.CriAtomEx.PanType panType)
  System.Void criAtomExPlayer_SetSendLevel(System.IntPtr player, System.Int32 channel, CriWare.CriAtomEx.Speaker id, System.Single level)
  System.Void criAtomExPlayer_SetBusSendLevel(System.IntPtr player, System.Int32 bus_id, System.Single level)
  System.Void criAtomExPlayer_SetBusSendLevelByName(System.IntPtr player, System.String bus_name, System.Single level)
  System.Boolean criAtomExPlayer_GetBusSendLevelByName(System.IntPtr player, System.String bus_name, System.Single& level)
  System.Void criAtomExPlayer_SetBusSendLevelOffset(System.IntPtr player, System.Int32 bus_id, System.Single level_offset)
  System.Void criAtomExPlayer_SetBusSendLevelOffsetByName(System.IntPtr player, System.String bus_name, System.Single level_offset)
  System.Boolean criAtomExPlayer_GetBusSendLevelOffsetByName(System.IntPtr player, System.String bus_name, System.Single& level_offset)
  System.Void criAtomExPlayer_SetBandpassFilterParameters(System.IntPtr player, System.Single cof_low, System.Single cof_high)
  System.Void criAtomExPlayer_SetBiquadFilterParameters(System.IntPtr player, CriWare.CriAtomEx.BiquadFilterType type, System.Single frequency, System.Single gain, System.Single q)
  System.Void criAtomExPlayer_SetVoicePriority(System.IntPtr player, System.Int32 priority)
  System.Void criAtomExPlayer_SetVoiceControlMethod(System.IntPtr player, CriWare.CriAtomEx.VoiceControlMethod method)
  System.Void criAtomExPlayer_SetAisacControlById(System.IntPtr player, System.UInt16 control_id, System.Single control_value)
  System.Void criAtomExPlayer_SetAisacControlByName(System.IntPtr player, System.String control_name, System.Single control_value)
  System.Void criAtomExPlayer_Set3dSourceHn(System.IntPtr player, System.IntPtr source)
  System.Void criAtomExPlayer_Set3dListenerHn(System.IntPtr player, System.IntPtr listener)
  System.Void criAtomExPlayer_SetCategoryById(System.IntPtr player, System.UInt32 category_id)
  System.Void criAtomExPlayer_SetCategoryByName(System.IntPtr player, System.String category_name)
  System.Void criAtomExPlayer_UnsetCategory(System.IntPtr player)
  System.Void criAtomExPlayer_SetCuePriority(System.IntPtr player, System.Int32 cue_priority)
  System.Void criAtomExPlayer_SetPreDelayTime(System.IntPtr player, System.Single predelay_time_ms)
  System.Void criAtomExPlayer_SetEnvelopeAttackTime(System.IntPtr player, System.Single attack_time_ms)
  System.Void criAtomExPlayer_SetEnvelopeHoldTime(System.IntPtr player, System.Single hold_time_ms)
  System.Void criAtomExPlayer_SetEnvelopeDecayTime(System.IntPtr player, System.Single decay_time_ms)
  System.Void criAtomExPlayer_SetEnvelopeReleaseTime(System.IntPtr player, System.Single release_time_ms)
  System.Void criAtomExPlayer_SetEnvelopeSustainLevel(System.IntPtr player, System.Single susutain_level)
  System.Void criAtomExPlayer_AttachFader(System.IntPtr player, System.IntPtr config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomExPlayer_AttachAisac(System.IntPtr player, System.String globalAisacName)
  System.Void criAtomExPlayer_DetachAisac(System.IntPtr player, System.String globalAisacName)
  System.Void criAtomExPlayer_DetachFader(System.IntPtr player)
  System.Void criAtomExPlayer_SetFadeOutTime(System.IntPtr player, System.Int32 ms)
  System.Void criAtomExPlayer_SetFadeInTime(System.IntPtr player, System.Int32 ms)
  System.Void criAtomExPlayer_SetFadeInStartOffset(System.IntPtr player, System.Int32 ms)
  System.Void criAtomExPlayer_SetFadeOutEndDelay(System.IntPtr player, System.Int32 ms)
  System.Boolean criAtomExPlayer_IsFading(System.IntPtr player)
  System.Void criAtomExPlayer_ResetFaderParameters(System.IntPtr player)
  System.Void criAtomExPlayer_SetGroupNumber(System.IntPtr player, System.Int32 group_no)
  System.Boolean criAtomExPlayer_GetAttachedAisacInfo(System.IntPtr player, System.Int32 aisac_attached_index, System.IntPtr aisac_info)
  System.Void criAtomExPlayer_SetFirstBlockIndex(System.IntPtr player, System.Int32 index)
  System.Void criAtomExPlayer_SetSelectorLabel(System.IntPtr player, System.String selector, System.String label)
  System.Void criAtomExPlayer_UnsetSelectorLabel(System.IntPtr player, System.String selector)
  System.Void criAtomExPlayer_ClearSelectorLabels(System.IntPtr player)
  System.Void criAtomExPlayer_SetSoundRendererType(System.IntPtr player, CriWare.CriAtomEx.SoundRendererType type)
  System.Void criAtomExPlayer_SetRandomSeed(System.IntPtr player, System.UInt32 seed)
  System.Void CRIWAREF466419F(System.IntPtr player, System.Boolean sw)
  System.Void criAtomExPlayer_SetAsrRackId(System.IntPtr player, System.Int32 asr_rack_id)
  System.Void criAtomExPlayer_SetDspParameter(System.IntPtr player, System.Int32 id, System.Single value)
  System.Void criAtomExPlayer_AttachTween(System.IntPtr player, System.IntPtr tween)
  System.Void criAtomExPlayer_DetachTween(System.IntPtr player, System.IntPtr tween)
  System.Void criAtomExPlayer_DetachTweenAll(System.IntPtr player)
END_CLASS

CLASS: CriWare.CriAtomExPlayerOutputAnalyzer
TYPE:  class
TOKEN: 0x200008E
EXTENDS: CriAtomExOutputAnalyzer
FIELDS:
METHODS:
  System.Void .ctor(CriWare.CriAtomExPlayerOutputAnalyzer.Type[] types, CriWare.CriAtomExPlayerOutputAnalyzer.Config[] configs)
END_CLASS

CLASS: CriWare.CriAtomExSoundObject
TYPE:  class
TOKEN: 0x2000091
EXTENDS: CriDisposable
FIELDS:
  private           System.IntPtr                   handle  // 0x20
METHODS:
  System.IntPtr get_nativeHandle()
  System.Void .ctor(System.Boolean enableVoiceLimitScope, System.Boolean enableCategoryCueLimitScope)
  System.Void Dispose()
  System.Void AddPlayer(CriWare.CriAtomExPlayer player)
  System.Void DeletePlayer(CriWare.CriAtomExPlayer player)
  System.Void DeleteAllPlayers()
  System.Void Finalize()
  System.IntPtr criAtomExSoundObject_Create(CriWare.CriAtomExSoundObject.Config& config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomExSoundObject_Destroy(System.IntPtr soundObject)
  System.Void criAtomExSoundObject_AddPlayer(System.IntPtr soundObject, System.IntPtr player)
  System.Void criAtomExSoundObject_DeletePlayer(System.IntPtr soundObject, System.IntPtr player)
  System.Void criAtomExSoundObject_DeleteAllPlayers(System.IntPtr soundObject)
END_CLASS

CLASS: CriWare.CriAtomExTween
TYPE:  class
TOKEN: 0x2000093
EXTENDS: CriDisposable
FIELDS:
  private           System.IntPtr                   handle  // 0x20
METHODS:
  System.IntPtr get_nativeHandle()
  System.Void .ctor()
  System.Void .ctor(CriWare.CriAtomEx.Parameter parameterId)
  System.Void .ctor(System.UInt32 aisacId)
  System.Void .ctor(CriWare.CriAtomExTween.ParameterType parameterType, System.UInt32 targetId)
  System.Void Dispose()
  System.Single get_Value()
  System.Boolean get_IsActive()
  System.Void MoveTo(System.UInt16 durationMs, System.Single value)
  System.Void MoveFrom(System.UInt16 durationMs, System.Single value)
  System.Void Stop()
  System.Void Reset()
  System.Void Finalize()
  System.Void Dispose(System.Boolean disposing)
  System.IntPtr criAtomExTween_Create(CriWare.CriAtomExTween.Config& config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomExTween_Destroy(System.IntPtr tween)
  System.Single criAtomExTween_GetValue(System.IntPtr tween)
  System.Void criAtomExTween_MoveTo(System.IntPtr tween, System.UInt16 time_ms, System.Single value)
  System.Void criAtomExTween_MoveFrom(System.IntPtr tween, System.UInt16 time_ms, System.Single value)
  System.Void criAtomExTween_Stop(System.IntPtr tween)
  System.Void criAtomExTween_Reset(System.IntPtr tween)
  System.Boolean criAtomExTween_IsActive(System.IntPtr tween)
END_CLASS

CLASS: CriWare.CriAtomExVoicePool
TYPE:  class
TOKEN: 0x2000097
EXTENDS: CriDisposable
FIELDS:
  public    static  System.Int32                    StandardMemoryAsrVoicePoolId  // 0x0
  public    static  System.Int32                    StandardStreamingAsrVoicePoolId  // 0x0
  public    static  System.Int32                    StandardMemoryNsrVoicePoolId  // 0x0
  public    static  System.Int32                    StandardStreamingNsrVoicePoolId  // 0x0
  protected         System.IntPtr                   _handle  // 0x20
  protected         System.UInt32                   _identifier  // 0x28
  protected         System.Int32                    _numVoices  // 0x2C
  protected         System.Int32                    _maxChannels  // 0x30
  protected         System.Int32                    _maxSamplingRate  // 0x34
METHODS:
  CriWare.CriAtomExVoicePool.UsedVoicesInfo GetNumUsedVoices(CriWare.CriAtomExVoicePool.VoicePoolId voicePoolId)
  System.IntPtr get_nativeHandle()
  System.UInt32 get_identifier()
  System.Int32 get_numVoices()
  System.Int32 get_maxChannels()
  System.Int32 get_maxSamplingRate()
  System.Void Dispose()
  CriWare.CriAtomExVoicePool.UsedVoicesInfo GetNumUsedVoices()
  System.Void AttachDspTimeStretch()
  System.Void AttachDspPitchShifter(CriWare.CriAtomExVoicePool.PitchShifterMode mode, System.Int32 windosSize, System.Int32 overlapTimes)
  System.Void DetachDsp()
  System.Void Finalize()
  System.Void CRIWARED389B244(System.Int32 voice_pool_id, System.Int32& num_used_voices, System.Int32& num_pool_voices)
  System.Void criAtomExVoicePool_GetNumUsedVoices(System.IntPtr pool, System.Int32& num_used_voices, System.Int32& num_pool_voices)
  System.Void criAtomExVoicePool_Free(System.IntPtr pool)
  System.Void criAtomExVoicePool_AttachDspTimeStretch(System.IntPtr pool, CriWare.CriAtomExVoicePool.ExTimeStretchConfig& config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomExVoicePool_AttachDspPitchShifter(System.IntPtr pool, CriWare.CriAtomExVoicePool.ExPitchShifterConfig& config, System.IntPtr work, System.Int32 work_size)
  System.Void criAtomExVoicePool_DetachDsp(System.IntPtr pool)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtomExStandardVoicePool
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: CriAtomExVoicePool
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 numVoices, System.Int32 maxChannels, System.Int32 maxSamplingRate, System.Boolean streamingFlag, System.UInt32 identifier)
  System.IntPtr criAtomExVoicePool_AllocateStandardVoicePool(CriWare.CriAtomExVoicePool.VoicePoolConfig& config, System.IntPtr work, System.Int32 work_size)
END_CLASS

CLASS: CriWare.CriAtomExWaveVoicePool
TYPE:  class
TOKEN: 0x20000A2
EXTENDS: CriAtomExVoicePool
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 numVoices, System.Int32 maxChannels, System.Int32 maxSamplingRate, System.Boolean streamingFlag, System.UInt32 identifier)
  System.IntPtr criAtomExVoicePool_AllocateWaveVoicePool(CriWare.CriAtomExVoicePool.VoicePoolConfig& config, System.IntPtr work, System.Int32 work_size)
END_CLASS

CLASS: CriWare.CriAtomExRawPcmVoicePool
TYPE:  class
TOKEN: 0x20000A3
EXTENDS: CriAtomExVoicePool
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 numVoices, System.Int32 maxChannels, System.Int32 maxSamplingRate, CriWare.CriAtomExRawPcmVoicePool.RawPcmFormat format, System.UInt32 identifier)
  System.IntPtr criAtomExVoicePool_AllocateRawPcmVoicePool(CriWare.CriAtomExRawPcmVoicePool.RawPcmVoicePoolConfig& config, System.IntPtr work, System.Int32 work_size)
END_CLASS

CLASS: CriWare.CriAudioReadStream
TYPE:  class
TOKEN: 0x20000A7
FIELDS:
  private           CriWare.CriAudioReadStream.InternalDelegateinternalDelegate  // 0x10
  private           System.IntPtr                   <callbackFunction>k__BackingField  // 0x18
  private           System.IntPtr                   <callbackPointer>k__BackingField  // 0x20
METHODS:
  System.IntPtr get_callbackFunction()
  System.Void set_callbackFunction(System.IntPtr value)
  System.IntPtr get_callbackPointer()
  System.Void set_callbackPointer(System.IntPtr value)
  System.Void .ctor(System.IntPtr callbackFunction, System.IntPtr callbackPointer)
  System.Void .ctor(CriWare.CriAudioReadStream.Delegate callback, System.Int32 numChannels, System.Int32 bufferSize)
END_CLASS

CLASS: CriWare.CriAudioWriteStream
TYPE:  class
TOKEN: 0x20000AB
FIELDS:
  private           CriWare.CriAudioWriteStream.InternalDelegateinternalDelegate  // 0x10
  private           System.IntPtr                   <callbackFunction>k__BackingField  // 0x18
  private           System.IntPtr                   <callbackPointer>k__BackingField  // 0x20
METHODS:
  System.IntPtr get_callbackFunction()
  System.Void set_callbackFunction(System.IntPtr value)
  System.IntPtr get_callbackPointer()
  System.Void set_callbackPointer(System.IntPtr value)
  System.Void .ctor(System.IntPtr callbackFunction, System.IntPtr callbackPointer)
  System.Void .ctor(CriWare.CriAudioWriteStream.Delegate callback, System.Int32 numChannels, System.Int32 bufferSize)
END_CLASS

CLASS: CriWare.CriFsLoader
TYPE:  class
TOKEN: 0x20000AF
EXTENDS: CriDisposable
FIELDS:
  private           System.IntPtr                   handle  // 0x20
  private           System.Runtime.InteropServices.GCHandledstGch  // 0x28
  private           System.Runtime.InteropServices.GCHandlesrcGch  // 0x30
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Load(CriWare.CriFsBinder binder, System.String path, System.Int64 fileOffset, System.Int64 loadSize, System.Byte[] buffer)
  System.Void LoadById(CriWare.CriFsBinder binder, System.Int32 id, System.Int64 fileOffset, System.Int64 loadSize, System.Byte[] buffer)
  System.Void LoadWithoutDecompression(CriWare.CriFsBinder binder, System.String path, System.Int64 fileOffset, System.Int64 loadSize, System.Byte[] buffer)
  System.Void LoadWithoutDecompressionById(CriWare.CriFsBinder binder, System.Int32 id, System.Int64 fileOffset, System.Int64 loadSize, System.Byte[] buffer)
  System.Void DecompressData(System.Int64 srcSize, System.Byte[] srcBuffer, System.Int64 dstSize, System.Byte[] dstBuffer)
  System.Void Stop()
  CriWare.CriFsLoader.Status GetStatus()
  System.Void SetReadUnitSize(System.Int32 unit_size)
  System.Void Finalize()
  System.Int32 criFsLoader_Create(System.IntPtr& loader)
  System.Int32 criFsLoader_Destroy(System.IntPtr loader)
  System.Int32 criFsLoader_Load(System.IntPtr loader, System.IntPtr binder, System.String path, System.Int64 offset, System.Int64 load_size, System.IntPtr buffer, System.Int64 buffer_size)
  System.Int32 criFsLoader_LoadById(System.IntPtr loader, System.IntPtr binder, System.Int32 id, System.Int64 offset, System.Int64 load_size, System.IntPtr buffer, System.Int64 buffer_size)
  System.Int32 criFsLoader_Stop(System.IntPtr loader)
  System.Int32 criFsLoader_GetStatus(System.IntPtr loader, CriWare.CriFsLoader.Status& status)
  System.Int32 criFsLoader_SetReadUnitSize(System.IntPtr loader, System.Int64 unit_size)
  System.Int32 criFsLoader_LoadWithoutDecompression(System.IntPtr loader, System.IntPtr binder, System.String path, System.Int64 offset, System.Int64 load_size, System.IntPtr buffer, System.Int64 buffer_size)
  System.Int32 criFsLoader_LoadWithoutDecompressionById(System.IntPtr loader, System.IntPtr binder, System.Int32 id, System.Int64 offset, System.Int64 load_size, System.IntPtr buffer, System.Int64 buffer_size)
  System.Int32 criFsLoader_DecompressData(System.IntPtr loader, System.IntPtr src, System.Int64 src_size, System.IntPtr dst, System.Int64 dst_size)
END_CLASS

CLASS: CriWare.CriFsInstaller
TYPE:  class
TOKEN: 0x20000B1
EXTENDS: CriDisposable
FIELDS:
  private           System.Byte[]                   installBuffer  // 0x20
  private           System.Runtime.InteropServices.GCHandleinstallBufferGch  // 0x28
  private           System.IntPtr                   handle  // 0x30
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Copy(CriWare.CriFsBinder binder, System.String srcPath, System.String dstPath, System.Int32 installBufferSize)
  System.Void Stop()
  CriWare.CriFsInstaller.Status GetStatus()
  System.Single GetProgress()
  System.Void ExecuteMain()
  System.Void Finalize()
  System.Int32 criFsInstaller_ExecuteMain()
  System.Int32 criFsInstaller_Create(System.IntPtr& installer, CriWare.CriFsInstaller.CopyPolicy option)
  System.Int32 criFsInstaller_Destroy(System.IntPtr installer)
  System.Int32 criFsInstaller_Copy(System.IntPtr installer, System.IntPtr binder, System.String src_path, System.String dst_path, System.IntPtr buffer, System.Int64 buffer_size)
  System.Int32 criFsInstaller_Stop(System.IntPtr installer)
  System.Int32 criFsInstaller_GetStatus(System.IntPtr installer, CriWare.CriFsInstaller.Status& status)
  System.Int32 criFsInstaller_GetProgress(System.IntPtr installer, System.Single& progress)
END_CLASS

CLASS: CriWare.CriFsBinder
TYPE:  class
TOKEN: 0x20000B4
EXTENDS: CriDisposable
FIELDS:
  private           System.IntPtr                   handle  // 0x20
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.UInt32 BindCpk(CriWare.CriFsBinder srcBinder, System.String path)
  System.UInt32 BindDirectory(CriWare.CriFsBinder srcBinder, System.String path)
  System.UInt32 BindFile(CriWare.CriFsBinder srcBinder, System.String path)
  System.UInt32 BindFileSection(CriWare.CriFsBinder srcBinder, System.String path, System.UInt64 offset, System.Int32 size, System.String sectionName)
  System.Void Unbind(System.UInt32 bindId)
  CriWare.CriFsBinder.Status GetStatus(System.UInt32 bindId)
  System.Int64 GetFileSize(System.String path)
  System.Int64 GetFileSize(System.Int32 id)
  System.Boolean GetContentsFileInfo(System.String path, CriWare.CriFsBinder.ContentsFileInfo& info)
  System.Boolean GetContentsFileInfo(System.Int32 id, CriWare.CriFsBinder.ContentsFileInfo& info)
  System.Boolean GetContentsFileInfoByIndex(System.UInt32 bindId, System.Int32 index, System.Int32 numFiles, CriWare.CriFsBinder.ContentsFileInfo[]& info)
  System.Int32 GetNumContentsFiles(System.UInt32 bindId)
  System.Void SetPriority(System.UInt32 bindId, System.Int32 priority)
  System.IntPtr get_nativeHandle()
  System.Void Finalize()
  System.UInt32 criFsBinder_Create(System.IntPtr& binder)
  System.UInt32 criFsBinder_Destroy(System.IntPtr binder)
  System.UInt32 criFsBinder_BindCpk(System.IntPtr binder, System.IntPtr srcBinder, System.String path, System.IntPtr work, System.Int32 worksize, System.UInt32& bindId)
  System.UInt32 criFsBinder_BindDirectory(System.IntPtr binder, System.IntPtr srcBinder, System.String path, System.IntPtr work, System.Int32 worksize, System.UInt32& bindId)
  System.UInt32 criFsBinder_BindFile(System.IntPtr binder, System.IntPtr srcBinder, System.String path, System.IntPtr work, System.Int32 worksize, System.UInt32& bindId)
  System.UInt32 criFsBinder_BindFileSection(System.IntPtr binder, System.IntPtr srcBinder, System.String path, System.UInt64 offset, System.Int32 size, System.String sectionName, System.IntPtr work, System.Int32 worksize, System.UInt32& bindId)
  System.Int32 criFsBinder_Unbind(System.UInt32 bindId)
  System.Int32 criFsBinder_GetStatus(System.UInt32 bindId, CriWare.CriFsBinder.Status& status)
  System.Int32 criFsBinder_GetFileSize(System.IntPtr binder, System.String path, System.Int64& size)
  System.Int32 criFsBinder_GetFileSizeById(System.IntPtr binder, System.Int32 id, System.Int64& size)
  System.Int32 criFsBinder_SetPriority(System.UInt32 bindId, System.Int32 priority)
  System.Int32 criFsBinder_GetContentsFileInfo(System.IntPtr binder, System.String path, System.IntPtr info)
  System.Int32 criFsBinder_GetContentsFileInfoById(System.IntPtr binder, System.Int32 id, System.IntPtr info)
  System.Int32 criFsBinder_GetContentsFileInfoByIndex(System.UInt32 id, System.Int32 index, System.IntPtr info, System.Int32 num)
  System.Int32 CRIWAREF02BA103(System.UInt32 id)
END_CLASS

CLASS: CriWare.CriFsRequest
TYPE:  class
TOKEN: 0x20000B7
EXTENDS: CriDisposable
FIELDS:
  private           CriWare.CriFsRequest.DoneDelegate<doneDelegate>k__BackingField  // 0x20
  private           System.Boolean                  <isDone>k__BackingField  // 0x28
  private           System.String                   <error>k__BackingField  // 0x30
  private           System.Boolean                  <isDisposed>k__BackingField  // 0x38
METHODS:
  CriWare.CriFsRequest.DoneDelegate get_doneDelegate()
  System.Void set_doneDelegate(CriWare.CriFsRequest.DoneDelegate value)
  System.Boolean get_isDone()
  System.Void set_isDone(System.Boolean value)
  System.String get_error()
  System.Void set_error(System.String value)
  System.Boolean get_isDisposed()
  System.Void set_isDisposed(System.Boolean value)
  System.Void Dispose()
  System.Void Stop()
  UnityEngine.YieldInstruction WaitForDone(UnityEngine.MonoBehaviour mb)
  System.Void Dispose(System.Boolean disposing)
  System.Void Update()
  System.Void Done()
  System.Collections.IEnumerator CheckDone()
  System.Void Finalize()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriFsLoadFileRequest
TYPE:  class
TOKEN: 0x20000BA
EXTENDS: CriFsRequest
FIELDS:
  private           System.String                   <path>k__BackingField  // 0x40
  private           System.Byte[]                   <bytes>k__BackingField  // 0x48
  private           CriWare.CriFsLoadFileRequest.Phasephase  // 0x50
  private           CriWare.CriFsBinder             refBinder  // 0x58
  private           CriWare.CriFsBinder             newBinder  // 0x60
  private           System.UInt32                   bindId  // 0x68
  private           CriWare.CriFsLoader             loader  // 0x70
  private           System.Int32                    readUnitSize  // 0x78
  private           System.Int64                    fileSize  // 0x80
METHODS:
  System.String get_path()
  System.Void set_path(System.String value)
  System.Byte[] get_bytes()
  System.Void set_bytes(System.Byte[] value)
  System.Void .ctor(CriWare.CriFsBinder srcBinder, System.String path, CriWare.CriFsRequest.DoneDelegate doneDelegate, System.Int32 readUnitSize)
  System.Void Dispose(System.Boolean disposing)
  System.Void Stop()
  System.Void Update()
  System.Void UpdateBinder()
  System.Void UpdateLoader()
  System.Void OnError()
END_CLASS

CLASS: CriWare.CriFsLoadAssetBundleRequest
TYPE:  class
TOKEN: 0x20000BC
EXTENDS: CriFsRequest
FIELDS:
  private           System.String                   <path>k__BackingField  // 0x40
  private           UnityEngine.AssetBundle         <assetBundle>k__BackingField  // 0x48
  private           CriWare.CriFsLoadFileRequest    loadFileReq  // 0x50
  private           UnityEngine.AssetBundleCreateRequestassetBundleReq  // 0x58
METHODS:
  System.String get_path()
  System.Void set_path(System.String value)
  UnityEngine.AssetBundle get_assetBundle()
  System.Void set_assetBundle(UnityEngine.AssetBundle value)
  System.Void .ctor(CriWare.CriFsBinder binder, System.String path, System.Int32 readUnitSize)
  System.Void Update()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: CriWare.CriFsInstallRequest
TYPE:  class
TOKEN: 0x20000BD
EXTENDS: CriFsRequest
FIELDS:
  private           System.String                   <sourcePath>k__BackingField  // 0x40
  private           System.String                   <destinationPath>k__BackingField  // 0x48
  private           System.Single                   <progress>k__BackingField  // 0x50
METHODS:
  System.String get_sourcePath()
  System.Void set_sourcePath(System.String value)
  System.String get_destinationPath()
  System.Void set_destinationPath(System.String value)
  System.Single get_progress()
  System.Void set_progress(System.Single value)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriFsInstallRequestLegacy
TYPE:  class
TOKEN: 0x20000BE
EXTENDS: CriFsInstallRequest
FIELDS:
  private           CriWare.CriFsInstaller          installer  // 0x58
METHODS:
  System.Void Stop()
  System.Void .ctor(CriWare.CriFsBinder srcBinder, System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDelegate, System.Int32 installBufferSize)
  System.Void Update()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: CriWare.CriFsWebInstallRequest
TYPE:  class
TOKEN: 0x20000BF
EXTENDS: CriFsInstallRequest
FIELDS:
  private           CriWare.CriFsWebInstaller       installer  // 0x58
  private           System.UInt32                   crc32  // 0x60
  private           System.Boolean                  crc32_set  // 0x64
METHODS:
  System.Void Stop()
  System.Boolean GetCRC32(System.UInt32& ret_val)
  System.Void .ctor(System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDelegate)
  System.Void Update()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: CriWare.CriFsBindRequest
TYPE:  class
TOKEN: 0x20000C0
EXTENDS: CriFsRequest
FIELDS:
  private           System.String                   <path>k__BackingField  // 0x40
  private           System.UInt32                   <bindId>k__BackingField  // 0x48
METHODS:
  System.String get_path()
  System.Void set_path(System.String value)
  System.UInt32 get_bindId()
  System.Void set_bindId(System.UInt32 value)
  System.Void .ctor(CriWare.CriFsBindRequest.BindType type, CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String path)
  System.Void Stop()
  System.Void Update()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: CriWare.CriFsUtility
TYPE:  class
TOKEN: 0x20000C2
FIELDS:
  public    static  System.Int32                    DefaultReadUnitSize  // 0x0
METHODS:
  CriWare.CriFsLoadFileRequest LoadFile(System.String path, System.Int32 readUnitSize)
  CriWare.CriFsLoadFileRequest LoadFile(System.String path, CriWare.CriFsRequest.DoneDelegate doneDelegate, System.Int32 readUnitSize)
  CriWare.CriFsLoadFileRequest LoadFile(CriWare.CriFsBinder binder, System.String path, System.Int32 readUnitSize)
  CriWare.CriFsLoadAssetBundleRequest LoadAssetBundle(System.String path, System.Int32 readUnitSize)
  CriWare.CriFsLoadAssetBundleRequest LoadAssetBundle(CriWare.CriFsBinder binder, System.String path, System.Int32 readUnitSize)
  CriWare.CriFsInstallRequest Install(System.String srcPath, System.String dstPath)
  CriWare.CriFsInstallRequest Install(System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDeleagate)
  CriWare.CriFsInstallRequest Install(CriWare.CriFsBinder srcBinder, System.String srcPath, System.String dstPath)
  CriWare.CriFsInstallRequest Install(CriWare.CriFsBinder srcBinder, System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDeleagate)
  CriWare.CriFsInstallRequest WebInstall(System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDeleagate)
  CriWare.CriFsBindRequest BindCpk(CriWare.CriFsBinder targetBinder, System.String srcPath)
  CriWare.CriFsBindRequest BindCpk(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String srcPath)
  CriWare.CriFsBindRequest BindDirectory(CriWare.CriFsBinder targetBinder, System.String srcPath)
  CriWare.CriFsBindRequest BindDirectory(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String srcPath)
  CriWare.CriFsBindRequest BindFile(CriWare.CriFsBinder targetBinder, System.String srcPath)
  CriWare.CriFsBindRequest BindFile(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String srcPath)
  System.Void SetUserAgentString(System.String userAgentString)
  System.Void SetProxyServer(System.String proxyPath, System.UInt16 proxyPort)
  System.Void SetPathSeparator(System.String filter)
  System.Boolean CRIWARECD0DC04A(System.String userAgentString)
  System.Boolean CRIWARE48E31D64(System.String proxyPath, System.UInt16 proxyPort)
  System.Boolean CRIWARE0C80F382(System.String filter)
END_CLASS

CLASS: CriWare.CriFsPlugin
TYPE:  class
TOKEN: 0x20000C3
FIELDS:
  private   static  System.Int32                    initializationCount  // 0x0
  private   static  System.Boolean                  isConfigured  // 0x4
  public    static  System.Int32                    defaultInstallBufferSize  // 0x8
  public    static  System.Int32                    installBufferSize  // 0xC
METHODS:
  System.Boolean get_isInitialized()
  System.Void SetConfigParameters(System.Int32 num_loaders, System.Int32 num_binders, System.Int32 num_installers, System.Int32 argInstallBufferSize, System.Int32 max_path, System.Boolean minimize_file_descriptor_usage, System.Boolean enable_crc_check)
  System.Void SetReadDeviceEnabled(System.Int32 deviceId, System.Boolean enabled)
  System.Void SetConfigAdditionalParameters_ANDROID(System.Int32 device_read_bps)
  System.Void SetMemoryFileSystemThreadPriorityExperimentalAndroid(System.Int32 prio)
  System.Void SetDataDecompressionThreadPriorityExperimentalAndroid(System.Int32 prio)
  System.Void InitializeLibrary()
  System.Boolean IsLibraryInitialized()
  System.Void FinalizeLibrary()
  System.Void CRIWARE8451156E(System.Int32 num_loaders, System.Int32 num_binders, System.Int32 num_installers, System.Int32 max_path, System.Boolean minimize_file_descriptor_usage, System.Boolean enable_crc_check)
  System.Void CRIWARE601ABE43()
  System.Boolean CRIWARE1012AF20()
  System.Void CRIWARE74A6103A()
  System.UInt32 CRIWARE785081A5()
  System.UInt32 criFsLoader_GetRetryCount()
  System.Int32 criFs_GetNumBinds(System.Int32& cur, System.Int32& max, System.Int32& limit)
  System.Int32 criFs_GetNumUsedLoaders(System.Int32& cur, System.Int32& max, System.Int32& limit)
  System.Int32 criFs_GetNumUsedInstallers(System.Int32& cur, System.Int32& max, System.Int32& limit)
  System.Int32 criFs_SetReadDeviceEnabled(System.Int32 device_id, System.Boolean enabled)
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriFsServer
TYPE:  class
TOKEN: 0x20000C4
EXTENDS: CriMonoBehaviour
FIELDS:
  private   static  CriWare.CriFsServer             _instance  // 0x0
  private           System.Collections.Generic.List<CriWare.CriFsRequest>requestList  // 0x28
  private           System.Int32                    <installBufferSize>k__BackingField  // 0x30
METHODS:
  CriWare.CriFsServer get_instance()
  System.Int32 get_installBufferSize()
  System.Void set_installBufferSize(System.Int32 value)
  System.Void CreateInstance()
  System.Void DestroyInstance()
  System.Void Awake()
  System.Void OnDestroy()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  System.Void AddRequest(CriWare.CriFsRequest request)
  CriWare.CriFsLoadFileRequest LoadFile(CriWare.CriFsBinder binder, System.String path, CriWare.CriFsRequest.DoneDelegate doneDelegate, System.Int32 readUnitSize)
  CriWare.CriFsLoadAssetBundleRequest LoadAssetBundle(CriWare.CriFsBinder binder, System.String path, System.Int32 readUnitSize)
  CriWare.CriFsInstallRequest Install(CriWare.CriFsBinder srcBinder, System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDelegate)
  CriWare.CriFsInstallRequest WebInstall(System.String srcPath, System.String dstPath, CriWare.CriFsRequest.DoneDelegate doneDelegate)
  CriWare.CriFsBindRequest BindCpk(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String path)
  CriWare.CriFsBindRequest BindDirectory(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String path)
  CriWare.CriFsBindRequest BindFile(CriWare.CriFsBinder targetBinder, CriWare.CriFsBinder srcBinder, System.String path)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriFsWebInstaller
TYPE:  class
TOKEN: 0x20000C5
EXTENDS: CriDisposable
FIELDS:
  private   static  System.Boolean                  <isInitialized>k__BackingField  // 0x0
  private   static  System.Boolean                  <isCrcEnabled>k__BackingField  // 0x1
  public    static  System.Int32                    InvalidHttpStatusCode  // 0x0
  public    static  System.Int64                    InvalidContentsSize  // 0x0
  private           System.IntPtr                   handle  // 0x20
METHODS:
  System.Boolean get_isInitialized()
  System.Void set_isInitialized(System.Boolean value)
  System.Boolean get_isCrcEnabled()
  System.Void set_isCrcEnabled(System.Boolean value)
  CriWare.CriFsWebInstaller.ModuleConfig get_defaultModuleConfig()
  System.Void .ctor()
  System.Void Finalize()
  System.Void Dispose()
  System.Void Copy(System.String url, System.String dstPath)
  System.Void Stop()
  CriWare.CriFsWebInstaller.StatusInfo GetStatusInfo()
  System.Boolean GetCRC32(System.UInt32& ret_val)
  System.Void InitializeModule(CriWare.CriFsWebInstaller.ModuleConfig config)
  System.Type GetCriFsWebInstallerCurlExpansionClass()
  System.Void FinalizeModule()
  System.Void ExecuteMain()
  System.Boolean SetRequestHeader(System.String field, System.String value)
  System.Void Dispose(System.Boolean disposing)
  System.Int32 criFsWebInstaller_Initialize(CriWare.CriFsWebInstaller.ModuleConfig& config)
  System.Int32 criFsWebInstaller_Finalize()
  System.Int32 criFsWebInstaller_ExecuteMain()
  System.Int32 criFsWebInstaller_Create(System.IntPtr& installer)
  System.Int32 criFsWebInstaller_Destroy(System.IntPtr installer)
  System.Int32 criFsWebInstaller_Copy(System.IntPtr installer, System.String url, System.String dstPath)
  System.Int32 criFsWebInstaller_Stop(System.IntPtr installer)
  System.Int32 criFsWebInstaller_GetStatusInfo(System.IntPtr installer, CriWare.CriFsWebInstaller.StatusInfo& status)
  System.Int32 criFsWebInstaller_GetCRC32(System.IntPtr installer, System.UInt32& crc32)
  System.Int32 criFsWebInstaller_SetRequestHeader(System.String field, System.String value)
END_CLASS

CLASS: CriWare.CriManaPlugin
TYPE:  class
TOKEN: 0x20000CB
FIELDS:
  private   static  System.Int32                    initializationCount  // 0x0
  private   static  System.Boolean                  isConfigured  // 0x4
  private   static  System.Boolean                  enabledMultithreadedRendering  // 0x5
  public    static  System.Int32                    renderingEventOffset  // 0x8
METHODS:
  System.Boolean get_isInitialized()
  System.Boolean get_isMultithreadedRenderingEnabled()
  System.Void SetConfigParameters(System.Boolean graphicsMultiThreaded, System.Int32 num_decoders, System.Int32 max_num_of_entries)
  System.Void SetupVp9()
  System.Void SetConfigAdditonalParameters_VITA(System.Boolean use_h264_playback, System.Int32 width, System.Int32 height)
  System.Void SetConfigAdditonalParameters_PC(System.Boolean use_h264_playback)
  System.Void SetConfigAdditonalParameters_ANDROID(System.Boolean enable_buffer_output_for_h264, System.Boolean enable_buffer_output_for_vp9)
  System.Void SetConfigAdditonalParameters_WEBGL(System.String webworkerPath, System.UInt32 heapSize)
  System.Void InitializeLibrary()
  System.Boolean IsLibraryInitialized()
  System.Void FinalizeLibrary()
  System.Boolean IsCodecSupported(CriWare.CriMana.CodecType codecType)
  System.Type GetVp9ExpansionClass()
  System.Boolean IsVp9CodecSupported()
  System.Boolean IsH264CodecSupported()
  System.Void SetDecodeThreadPriorityAndroidExperimental(System.Int32 prio)
  System.Boolean ShouldSampleRed(UnityEngine.Rendering.GraphicsDeviceType type, System.IntPtr tex_ptr)
  System.Void Lock()
  System.Void Unlock()
  System.UInt32 GetPrimeBufferAlignmentSize()
  System.Void CRIWARECFA78B41(System.Int32 graphics_api, System.Boolean graphics_multi_threaded, System.Int32 num_decoders, System.Int32 num_of_max_entries)
  System.Void CRIWARE7BFC56AA()
  System.Boolean CRIWARE611B78A5()
  System.Void CRIWARED672C36F()
  System.Void CRIWARE9F182D39(System.Boolean flag)
  System.Void CRIWARE06C87176()
  System.Void CRIWARE46E1A37B()
  System.UInt32 criManaUnity_GetPrimeBufferAlignmentSize()
  System.Void criMana_UseStreamerManager(System.Boolean flag)
  System.Boolean criMana_IsStreamerManagerUsed()
  System.UInt32 CRIWARE257CA763()
  System.Void CRIWARE62B7B053(System.Boolean enable)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriManaAmbisonicSource
TYPE:  class
TOKEN: 0x20000CC
EXTENDS: CriMonoBehaviour
FIELDS:
  private           CriWare.CriAtomEx3dSource       atomEx3DsourceForAmbisonics  // 0x28
  private           UnityEngine.Vector3             ambisonicSourceOrientationFront  // 0x30
  private           UnityEngine.Vector3             ambisonicSourceOrientationTop  // 0x3C
  private           UnityEngine.Vector3             lastEulerOfAmbisonicSource  // 0x48
METHODS:
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  System.Void OnEnable()
  System.Void ForceUpdateAmbisonicSourceOrientation()
  System.Void UpdateAmbisonicSourceOrientation()
  System.Void RoatateAmbisonicSourceOrientationByTransformOfChild(UnityEngine.Vector3& input_euler)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriManaMovieController
TYPE:  class
TOKEN: 0x20000CD
EXTENDS: CriManaMovieMaterial
FIELDS:
  public            UnityEngine.Renderer            target  // 0x98
  public            System.Boolean                  useOriginalMaterial  // 0xA0
  private           UnityEngine.Material            originalMaterial  // 0xA8
METHODS:
  System.Void CriInternalUpdate()
  System.Boolean RenderTargetManualSetup()
  System.Void RenderTargetManualFinalize()
  System.Void OnMaterialAvailableChanged()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriManaMovieControllerForUI
TYPE:  class
TOKEN: 0x20000CE
EXTENDS: CriManaMovieMaterial
FIELDS:
  public            UnityEngine.UI.Graphic          target  // 0x98
  public            System.Boolean                  useOriginalMaterial  // 0xA0
  private           UnityEngine.Material            originalMaterial  // 0xA8
METHODS:
  System.Void Awake()
  System.Void CriInternalUpdate()
  System.Boolean RenderTargetManualSetup()
  System.Void RenderTargetManualFinalize()
  System.Void OnMaterialAvailableChanged()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriManaMovieMaterial
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: CriManaMovieMaterialBase
FIELDS:
  private           System.String                   _moviePath  // 0x80
  private           System.Boolean                  _loop  // 0x88
  private           System.Boolean                  _additiveMode  // 0x89
  private           System.Boolean                  _useMaterialBlendMode  // 0x8A
  private           System.Boolean                  _advancedAudio  // 0x8B
  private           System.Boolean                  _ambisonics  // 0x8C
  private           System.Boolean                  _applyTargetAlpha  // 0x8D
  private           System.Boolean                  _uiRenderMode  // 0x8E
  private           UnityEngine.GameObject          ambisonicSource  // 0x90
METHODS:
  System.String get_moviePath()
  System.Void set_moviePath(System.String value)
  System.Boolean get_loop()
  System.Void set_loop(System.Boolean value)
  System.Boolean get_advancedAudio()
  System.Void set_advancedAudio(System.Boolean value)
  System.Boolean get_ambisonics()
  System.Void set_ambisonics(System.Boolean value)
  System.Boolean get_additiveMode()
  System.Void set_additiveMode(System.Boolean value)
  System.Boolean get_useMaterialBlendMode()
  System.Void set_useMaterialBlendMode(System.Boolean value)
  System.Boolean get_applyTargetAlpha()
  System.Void set_applyTargetAlpha(System.Boolean value)
  System.Boolean get_uiRenderMode()
  System.Void set_uiRenderMode(System.Boolean value)
  System.UInt32 get_FilePathLength()
  System.Boolean get_initializeWithAdvancedAudio()
  System.Boolean get_initializeWithAmbisonics()
  System.Void SetDataToPlayer()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriManaMovieMaterialBase
TYPE:  class
TOKEN: 0x20000D0
EXTENDS: CriMonoBehaviour
FIELDS:
  public            System.Boolean                  playOnStart  // 0x28
  public            System.Boolean                  restartOnEnable  // 0x29
  private           System.Boolean                  <isMaterialAvailable>k__BackingField  // 0x2A
  private           CriWare.CriMana.Player          <player>k__BackingField  // 0x30
  public            CriWare.CriManaMovieMaterialBase.RenderModerenderMode  // 0x38
  public            CriWare.CriManaMovieMaterialBase.OnApplicationPauseCallbackonApplicationPauseCallback  // 0x40
  private           CriWare.CriMana.Player.TimerType_timerType  // 0x48
  private           UnityEngine.Material            _material  // 0x50
  private           CriWare.CriManaMovieMaterialBase.MaxFrameDrop_maxFrameDrop  // 0x58
  private           System.Boolean                  materialOwn  // 0x5C
  protected         System.Boolean                  isMonoBehaviourStartCalled  // 0x5D
  private           System.Boolean                  wasDisabled  // 0x5E
  private           System.Boolean                  wasPausedOnDisable  // 0x5F
  private           System.Boolean                  previousOnApplicationPauseStatus  // 0x60
  private           UnityEngine.WaitForEndOfFrame   frameEnd  // 0x68
  private           System.Boolean                  unpauseOnApplicationUnpause  // 0x70
  private           System.Boolean                  <HaveRendererOwner>k__BackingField  // 0x71
  private           CriWare.CriManaMoviePlayerHolderplayerHolder  // 0x78
METHODS:
  CriWare.CriManaMovieMaterialBase.MaxFrameDrop get_maxFrameDrop()
  System.Void set_maxFrameDrop(CriWare.CriManaMovieMaterialBase.MaxFrameDrop value)
  System.Boolean get_initializeWithAdvancedAudio()
  System.Boolean get_initializeWithAmbisonics()
  System.Boolean get_isMaterialAvailable()
  System.Void set_isMaterialAvailable(System.Boolean value)
  CriWare.CriMana.Player get_player()
  System.Void set_player(CriWare.CriMana.Player value)
  UnityEngine.Material get_material()
  System.Void set_material(UnityEngine.Material value)
  CriWare.CriMana.Player.TimerType get_timerType()
  System.Void set_timerType(CriWare.CriMana.Player.TimerType value)
  System.UInt32 get_FilePathLength()
  System.Void SetDataToPlayer()
  System.Boolean get_HaveRendererOwner()
  System.Void set_HaveRendererOwner(System.Boolean value)
  System.Void Play()
  System.Void Stop()
  System.Void Pause(System.Boolean sw)
  System.Void OnMaterialAvailableChanged()
  System.Void OnMaterialUpdated()
  System.Void PlayerManualInitialize()
  System.Void PlayerManualFinalize()
  System.Void AsyncDispose(CriWare.CriMana.Player player)
  System.Void PlayerManualSetup()
  System.Boolean RenderTargetManualSetup()
  System.Void RenderTargetManualFinalize()
  System.Void PlayerManualUpdate()
  System.Void Awake()
  System.Void OnEnable()
  System.Collections.IEnumerator RestartPlayerRoutine()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void Start()
  System.Void CriInternalUpdate()
  System.Void RenderMovie()
  System.Void CriInternalLateUpdate()
  System.Void OnWillRenderObject()
  System.Void OnApplicationPause(System.Boolean appPause)
  System.Void ProcessApplicationPause(System.Boolean appPause)
  System.Void CreateMaterial()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriManaMoviePlayerHolder
TYPE:  class
TOKEN: 0x20000D6
EXTENDS: CriMonoBehaviour
FIELDS:
  private           CriWare.CriMana.Player          _player  // 0x28
METHODS:
  System.Void set_player(CriWare.CriMana.Player value)
  System.Void Awake()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  System.Void Start()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.Common
TYPE:  class
TOKEN: 0x20000D7
FIELDS:
  private   static  System.String                   scriptVersionString  // 0x0
  public    static  System.Boolean                  supportsCriFsInstaller  // 0x0
  public    static  System.Boolean                  supportsCriFsWebInstaller  // 0x0
  public    static  System.String                   pluginName  // 0x0
  public    static  System.Runtime.InteropServices.CallingConventionpluginCallingConvention  // 0x0
  private   static  UnityEngine.GameObject          _managerObject  // 0x0
METHODS:
  System.String get_streamingAssetsPath()
  System.String get_installTargetPath()
  System.String get_installCachePath()
  System.Boolean IsStreamingAssetsPath(System.String path)
  UnityEngine.GameObject get_managerObject()
  System.String GetScriptVersionString()
  System.Int32 GetBinaryVersionNumber()
  System.Int32 GetRequiredBinaryVersionNumber()
  System.Boolean CheckBinaryVersionCompatibility()
  System.UInt32 GetFsMemoryUsage()
  System.UInt32 GetAtomMemoryUsage()
  System.UInt32 GetManaMemoryUsage()
  CriWare.Common.CpuUsage GetAtomCpuUsage()
  System.Int32 CRIWAREC8077C29()
  System.Void criWareUnity_SetRenderingEventOffsetForMana(System.Int32 offset)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriWareDecrypter
TYPE:  class
TOKEN: 0x20000D9
FIELDS:
  private   static  System.UInt64                   temporalStorage  // 0x0
METHODS:
  System.Boolean Initialize(CriWare.CriWareDecrypterConfig config)
  System.Boolean Initialize(System.String key, System.String authenticationFile, System.Boolean enableAtomDecryption, System.Boolean enableManaDecryption)
  System.UInt64 CallbackFromNative(System.IntPtr ptr1)
  System.Int32 CRIWARE05CA8EB2(System.Boolean enable_atom_decryption, System.Boolean enable_mana_decryption, CriWare.CriWareDecrypter.CallbackFromNativeDelegate func, System.IntPtr obj)
END_CLASS

CLASS: CriWare.CriWareErrorHandler
TYPE:  class
TOKEN: 0x20000DB
EXTENDS: CriMonoBehaviour
FIELDS:
  public            System.Boolean                  enableDebugPrintOnTerminal  // 0x28
  public            System.Boolean                  enableForceCrashOnError  // 0x29
  public            System.Boolean                  dontDestroyOnLoad  // 0x2A
  private   static  System.String                   <errorMessage>k__BackingField  // 0x0
  public    static readonly System.String                   logPrefix  // 0x8
  private   static  CriWare.CriWareErrorHandler.CallbackOnCallback  // 0x10
  public    static  CriWare.CriWareErrorHandler.Callbackcallback  // 0x18
  public            System.UInt32                   messageBufferCounts  // 0x2C
  private           System.Collections.Concurrent.ConcurrentQueue<System.String>unThreadSafeMessages  // 0x30
  private   static  System.Int32                    initializationCount  // 0x20
METHODS:
  System.String get_errorMessage()
  System.Void set_errorMessage(System.String value)
  System.Void add_OnCallback(CriWare.CriWareErrorHandler.Callback value)
  System.Void remove_OnCallback(CriWare.CriWareErrorHandler.Callback value)
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  System.Void OnDestroy()
  System.Void DequeueErrorMessages()
  System.Void HandleMessage(System.String errmsg)
  System.Void OutputDefaultLog(System.String errmsg)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriErrorNotifier
TYPE:  class
TOKEN: 0x20000DD
FIELDS:
  private   static  CriWare.CriErrorNotifier.Callback_onCallbackThreadUnsafe  // 0x0
  private   static  System.Object                   objectLock  // 0x8
METHODS:
  System.Void add__onCallbackThreadUnsafe(CriWare.CriErrorNotifier.Callback value)
  System.Void remove__onCallbackThreadUnsafe(CriWare.CriErrorNotifier.Callback value)
  System.Void add_OnCallbackThreadUnsafe(CriWare.CriErrorNotifier.Callback value)
  System.Void remove_OnCallbackThreadUnsafe(CriWare.CriErrorNotifier.Callback value)
  System.Boolean IsRegistered(CriWare.CriErrorNotifier.Callback target)
  System.Void CallEvent(System.String message)
  System.Void ErrorCallbackFromNative(System.IntPtr errmsgPtr, System.UInt32 p1, System.UInt32 p2, System.IntPtr parray)
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriFsConfig
TYPE:  class
TOKEN: 0x20000E1
FIELDS:
  public    static  System.Int32                    defaultAndroidDeviceReadBitrate  // 0x0
  public            System.Int32                    numberOfLoaders  // 0x10
  public            System.Int32                    numberOfBinders  // 0x14
  public            System.Int32                    numberOfInstallers  // 0x18
  public            System.Int32                    installBufferSize  // 0x1C
  public            System.Int32                    maxPath  // 0x20
  public            System.String                   userAgentString  // 0x28
  public            System.Boolean                  minimizeFileDescriptorUsage  // 0x30
  public            System.Boolean                  enableCrcCheck  // 0x31
  public            System.Int32                    androidDeviceReadBitrate  // 0x34
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtomConfig
TYPE:  class
TOKEN: 0x20000E2
FIELDS:
  public            System.String                   acfFileName  // 0x10
  public            System.Int32                    maxVirtualVoices  // 0x18
  public            System.Int32                    maxVoiceLimitGroups  // 0x1C
  public            System.Int32                    maxCategories  // 0x20
  public            System.Int32                    maxAisacs  // 0x24
  public            System.Int32                    maxBusSends  // 0x28
  public            System.Int32                    maxSequenceEventsPerFrame  // 0x2C
  public            System.Int32                    maxBeatSyncCallbacksPerFrame  // 0x30
  public            System.Int32                    maxCueLinkCallbacksPerFrame  // 0x34
  public            CriWare.CriAtomConfig.StandardVoicePoolConfigstandardVoicePoolConfig  // 0x38
  public            CriWare.CriAtomConfig.HcaMxVoicePoolConfighcaMxVoicePoolConfig  // 0x40
  public            System.Int32                    outputSamplingRate  // 0x48
  public            System.Boolean                  usesInGamePreview  // 0x4C
  public            CriWare.CriAtomConfig.InGamePreviewSwitchModeinGamePreviewMode  // 0x50
  public            System.Boolean                  switchInitializeSocket  // 0x54
  public            CriWare.CriAtomConfig.InGamePreviewConfiginGamePreviewConfig  // 0x58
  public            System.Single                   serverFrequency  // 0x60
  public            System.Int32                    asrOutputChannels  // 0x64
  public            System.Boolean                  useRandomSeedWithTime  // 0x68
  public            System.Int32                    categoriesPerPlayback  // 0x6C
  public            System.Int32                    maxFaders  // 0x70
  public            System.Int32                    maxBuses  // 0x74
  public            System.Int32                    maxParameterBlocks  // 0x78
  public            System.Boolean                  vrMode  // 0x7C
  public            System.Boolean                  keepPlayingSoundOnPause  // 0x7D
  public            CriWare.CriAtomConfig.EditorPcmOutputConfigeditorPcmOutputConfig  // 0x80
  public            System.Int32                    pcBufferingTime  // 0x88
  public            CriWare.CriAtomConfig.LinuxOutputlinuxOutput  // 0x8C
  public            System.Int32                    linuxPulseLatencyUsec  // 0x90
  public            System.Boolean                  iosEnableSonicSync  // 0x94
  public            System.Int32                    iosBufferingTime  // 0x98
  public            System.Boolean                  iosOverrideIPodMusic  // 0x9C
  public            System.Boolean                  androidEnableSonicSync  // 0x9D
  public            System.Int32                    androidBufferingTime  // 0xA0
  public            System.Int32                    androidStartBufferingTime  // 0xA4
  public            CriWare.CriAtomConfig.AndroidLowLatencyStandardVoicePoolConfigandroidLowLatencyStandardVoicePoolConfig  // 0xA8
  public            System.Boolean                  androidUsesAndroidFastMixer  // 0xB0
  public            System.Boolean                  androidForceToUseAsrForDefaultPlayback  // 0xB1
  public            System.Boolean                  androidUsesAAudio  // 0xB2
  public            System.Int32                    androidStreamType  // 0xB4
  public            CriWare.CriAtomConfig.VitaManaVoicePoolConfigvitaManaVoicePoolConfig  // 0xB8
  public            CriWare.CriAtomConfig.VitaAtrac9VoicePoolConfigvitaAtrac9VoicePoolConfig  // 0xC0
  public            CriWare.CriAtomConfig.Ps4Atrac9VoicePoolConfigps4Atrac9VoicePoolConfig  // 0xC8
  public            CriWare.CriAtomConfig.Ps5PortConfigps5PortConfig  // 0xD0
  public            System.Boolean                  switchEnableSonicSync  // 0xD8
  public            CriWare.CriAtomConfig.SwitchOpusVoicePoolConfigswitchOpusVoicePoolConfig  // 0xE0
  public            CriWare.CriAtomConfig.Ps4Audio3dConfigps4Audio3dConfig  // 0xE8
  public            CriWare.CriAtomConfig.WebGLWebAudioVoicePoolConfigwebglWebAudioVoicePoolConfig  // 0xF0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriManaConfig
TYPE:  class
TOKEN: 0x20000F2
FIELDS:
  public            System.Int32                    numberOfDecoders  // 0x10
  public            System.Int32                    numberOfMaxEntries  // 0x14
  public    readonly System.Boolean                  graphicsMultiThreaded  // 0x18
  public            CriWare.CriManaConfig.PCH264PlaybackConfigpcH264PlaybackConfig  // 0x20
  public            CriWare.CriManaConfig.VitaH264PlaybackConfigvitaH264PlaybackConfig  // 0x28
  public            CriWare.CriManaConfig.WebGLConfigwebglConfig  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriWareDecrypterConfig
TYPE:  class
TOKEN: 0x20000F6
FIELDS:
  public            System.String                   key  // 0x10
  public            System.String                   authenticationFile  // 0x18
  public            System.Boolean                  enableAtomDecryption  // 0x20
  public            System.Boolean                  enableManaDecryption  // 0x21
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriWareInitializer
TYPE:  class
TOKEN: 0x20000F7
EXTENDS: CriMonoBehaviour
FIELDS:
  public            System.Boolean                  initializesFileSystem  // 0x28
  public            CriWare.CriFsConfig             fileSystemConfig  // 0x30
  public            System.Boolean                  initializesAtom  // 0x38
  public            CriWare.CriAtomConfig           atomConfig  // 0x40
  public            System.Boolean                  initializesMana  // 0x48
  public            CriWare.CriManaConfig           manaConfig  // 0x50
  public            System.Boolean                  useDecrypter  // 0x58
  public            CriWare.CriWareDecrypterConfig  decrypterConfig  // 0x60
  public            System.Boolean                  dontInitializeOnAwake  // 0x68
  public            System.Boolean                  dontDestroyOnLoad  // 0x69
  private   static  System.Int32                    initializationCount  // 0x0
METHODS:
  System.Void Awake()
  System.Void OnEnable()
  System.Void Start()
  System.Void OnDestroy()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
  System.Void Initialize()
  System.Void Shutdown()
  System.Boolean IsInitialized()
  System.Void AddAudioEffectInterface(System.IntPtr effect_interface)
  System.Boolean InitializeFileSystem(CriWare.CriFsConfig config)
  System.Boolean InitializeAtom(CriWare.CriAtomConfig config)
  System.Boolean InitializeMana(CriWare.CriManaConfig config)
  System.Boolean InitializeDecrypter(CriWare.CriWareDecrypterConfig config)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriAtomExDebug
TYPE:  class
TOKEN: 0x20000F8
FIELDS:
METHODS:
  System.Void GetResourcesInfo(CriWare.CriAtomExDebug.ResourcesInfo& resourcesInfo)
  System.Void criAtomExDebug_GetResourcesInfo(CriWare.CriAtomExDebug.ResourcesInfo& resourcesInfo)
END_CLASS

CLASS: CriWare.CriAtomExAcfDebug
TYPE:  class
TOKEN: 0x20000FA
FIELDS:
METHODS:
  System.Int32 GetNumCategories()
  System.Boolean GetCategoryInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcfDebug.CategoryInfo& categoryInfo)
  System.Boolean GetCategoryInfoByName(System.String name, CriWare.CriAtomExAcfDebug.CategoryInfo& categoryInfo)
  System.Boolean GetCategoryInfoById(System.UInt32 id, CriWare.CriAtomExAcfDebug.CategoryInfo& categoryInfo)
  System.Int32 GetNumBuses()
  System.Boolean GetDspBusInformation(System.UInt16 index, CriWare.CriAtomExAcfDebug.DspBusInfo& dspBusInfo)
  System.Int32 GetNumAisacControls()
  System.Boolean GetAisacControlInfo(System.UInt16 index, CriWare.CriAtomExAcfDebug.AisacControlInfo& info)
  System.UInt32 GetAisacControlIdByName(System.String name)
  System.String GetAisacControlNameById(System.UInt32 id)
  System.Int32 GetNumGlobalAisacs()
  System.Boolean GetGlobalAisacInfo(System.UInt16 index, CriWare.CriAtomExAcfDebug.GlobalAisacInfo& info)
  System.Boolean GetGlobalAisacInfoByName(System.String name, CriWare.CriAtomExAcfDebug.GlobalAisacInfo& info)
  System.Int32 GetNumSelectors()
  System.Boolean GetSelectorInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcfDebug.SelectorInfo& info)
  System.Boolean GetSelectorInfoByName(System.String name, CriWare.CriAtomExAcfDebug.SelectorInfo& info)
  System.Boolean GetSelectorLabelInfo(CriWare.CriAtomExAcfDebug.SelectorInfo& selectorInfo, System.UInt16 index, CriWare.CriAtomExAcfDebug.SelectorLabelInfo& labelInfo)
  System.Int32 criAtomExAcf_GetNumCategories()
  System.Int32 criAtomExAcf_GetCategoryInfo(System.UInt16 index, CriWare.CriAtomExAcfDebug.CategoryInfoForMarshaling& categoryInfo)
  System.Int32 criAtomExAcf_GetCategoryInfoByName(System.String name, CriWare.CriAtomExAcfDebug.CategoryInfoForMarshaling& categoryInfo)
  System.Int32 criAtomExAcf_GetCategoryInfoById(System.UInt32 id, CriWare.CriAtomExAcfDebug.CategoryInfoForMarshaling& categoryInfo)
  System.Int32 criAtomExAcf_GetNumBuses()
  System.Int32 criAtomExAcf_GetDspBusInformation(System.UInt16 index, CriWare.CriAtomExAcfDebug.DspBusInfoForMarshaling& dspBusInfo)
  System.Int32 criAtomExAcf_GetNumAisacControls()
  System.Int32 criAtomExAcf_GetAisacControlInfo(System.UInt16 index, CriWare.CriAtomExAcfDebug.AisacControlInfoForMarshaling& info)
  System.UInt32 criAtomExAcf_GetAisacControlIdByName(System.String name)
  System.IntPtr criAtomExAcf_GetAisacControlNameById(System.UInt32 id)
  System.Int32 criAtomExAcf_GetNumGlobalAisacs()
  System.Int32 criAtomExAcf_GetGlobalAisacInfo(System.UInt16 index, CriWare.CriAtomExAcfDebug.GlobalAisacInfoForMarshaling& info)
  System.Int32 criAtomExAcf_GetGlobalAisacInfoByName(System.String name, CriWare.CriAtomExAcfDebug.GlobalAisacInfoForMarshaling& info)
  System.Int32 criAtomExAcf_GetNumSelectors()
  System.Int32 criAtomExAcf_GetSelectorInfoByIndex(System.UInt16 index, CriWare.CriAtomExAcfDebug.SelectorInfoForMarshaling& info)
  System.Int32 criAtomExAcf_GetSelectorInfoByName(System.String name, CriWare.CriAtomExAcfDebug.SelectorInfoForMarshaling& info)
  System.Int32 criAtomExAcf_GetSelectorLabelInfo(CriWare.CriAtomExAcfDebug.SelectorInfoForMarshaling& info, System.UInt16 labelIndex, CriWare.CriAtomExAcfDebug.SelectorLabelInfoForMarshaling& label_info)
END_CLASS

CLASS: CriWare.CriAtomExAcbDebug
TYPE:  class
TOKEN: 0x2000108
FIELDS:
METHODS:
  System.Boolean GetAcbInfo(CriWare.CriAtomExAcb acb, CriWare.CriAtomExAcbDebug.AcbInfo& acbInfo)
  System.Int32 criAtomExAcb_GetAcbInfo(System.IntPtr acbHn, CriWare.CriAtomExAcbDebug.AcbInfoForMarshaling& acbInfo)
END_CLASS

CLASS: CriWare.CriAtomExPlaybackDebug
TYPE:  class
TOKEN: 0x200010B
FIELDS:
METHODS:
  System.Boolean GetParameter(CriWare.CriAtomExPlayback playback, CriWare.CriAtomEx.Parameter parameterId, System.Single& value)
  System.Boolean GetParameter(CriWare.CriAtomExPlayback playback, CriWare.CriAtomEx.Parameter parameterId, System.UInt32& value)
  System.Boolean GetParameter(CriWare.CriAtomExPlayback playback, CriWare.CriAtomEx.Parameter parameterId, System.Int32& value)
  System.Boolean GetAisacControl(CriWare.CriAtomExPlayback playback, System.UInt32 controlId, System.Single& value)
  System.Boolean GetAisacControl(CriWare.CriAtomExPlayback playback, System.String controlName, System.Single& value)
  System.Int32 criAtomExPlayback_GetParameterFloat32(System.UInt32 id, System.Int32 parameterId, System.Single& value)
  System.Int32 criAtomExPlayback_GetParameterUint32(System.UInt32 id, System.Int32 parameterId, System.UInt32& value)
  System.Int32 criAtomExPlayback_GetParameterSint32(System.UInt32 id, System.Int32 parameterId, System.Int32& value)
  System.Int32 criAtomExPlayback_GetAisacControlById(System.UInt32 id, System.UInt32 controlId, System.Single& value)
  System.Int32 criAtomExPlayback_GetAisacControlByName(System.UInt32 id, System.String controlName, System.Single& value)
END_CLASS

CLASS: CriWare.CriDisposable
TYPE:  class
TOKEN: 0x200010C
FIELDS:
  public            System.Guid                     guid  // 0x10
METHODS:
  System.Void .ctor()
  System.Void Dispose()
END_CLASS

CLASS: CriWare.CriDisposableObjectManager
TYPE:  class
TOKEN: 0x200010D
FIELDS:
  private   static  System.Collections.Generic.List<CriWare.CriDisposableObjectManager.ObjectRef>refList  // 0x0
METHODS:
  System.Int32 SearchForDisposable(CriWare.CriDisposable disposable)
  System.Void Register(CriWare.CriDisposable disposable, CriWare.CriDisposableObjectManager.ModuleType type)
  System.Boolean Unregister(CriWare.CriDisposable disposable)
  System.Boolean IsDisposed(CriWare.CriDisposable disposable)
  System.Void CallOnModuleFinalization(CriWare.CriDisposableObjectManager.ModuleType type)
  System.Int32 GetNextWithType(CriWare.CriDisposableObjectManager.ModuleType type)
  System.Void DisposeAll(CriWare.CriDisposableObjectManager.ModuleType type)
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriMonoBehaviour
TYPE:  class
TOKEN: 0x2000110
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Guid                     <guid>k__BackingField  // 0x18
METHODS:
  System.Guid get_guid()
  System.Void set_guid(System.Guid value)
  System.Void .ctor()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void CriInternalUpdate()
  System.Void CriInternalLateUpdate()
END_CLASS

CLASS: CriWare.CriMonoBehaviourManager
TYPE:  class
TOKEN: 0x2000111
EXTENDS: MonoBehaviour
FIELDS:
  private   static  CriWare.CriMonoBehaviourManager _instance  // 0x0
  private   static  System.Collections.Generic.List<CriWare.CriMonoBehaviour>criMonoBehaviourList  // 0x8
METHODS:
  CriWare.CriMonoBehaviourManager get_instance()
  System.Void CreateInstance()
  System.Int32 GetIndex(CriWare.CriMonoBehaviour criMonoBehaviour)
  System.Boolean Register(CriWare.CriMonoBehaviour criMonoBehaviour)
  System.Boolean UnRegister(CriWare.CriMonoBehaviour criMonoBehaviour)
  System.Void Awake()
  System.Void Update()
  System.Void LateUpdate()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriAtomDebugDetail.Utility
TYPE:  class
TOKEN: 0x2000112
FIELDS:
METHODS:
  System.String PtrToStringAutoOrNull(System.IntPtr stringPtr)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriMana.CodecType
TYPE:  struct
TOKEN: 0x2000125
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriMana.CodecType       Unknown  // 0x0
  public    static  CriWare.CriMana.CodecType       SofdecPrime  // 0x0
  public    static  CriWare.CriMana.CodecType       H264  // 0x0
  public    static  CriWare.CriMana.CodecType       VP9  // 0x0
METHODS:
END_CLASS

CLASS: CriWare.CriMana.AlphaType
TYPE:  struct
TOKEN: 0x2000126
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CriWare.CriMana.AlphaType       CompoOpaq  // 0x0
  public    static  CriWare.CriMana.AlphaType       CompoAlphaFull  // 0x0
  public    static  CriWare.CriMana.AlphaType       CompoAlpha3Step  // 0x0
  public    static  CriWare.CriMana.AlphaType       CompoAlpha32Bit  // 0x0
METHODS:
END_CLASS

CLASS: CriWare.CriMana.AudioInfo
TYPE:  struct
TOKEN: 0x2000127
FIELDS:
  public            System.UInt32                   samplingRate  // 0x10
  public            System.UInt32                   numChannels  // 0x14
  public            System.UInt32                   totalSamples  // 0x18
METHODS:
END_CLASS

CLASS: CriWare.CriMana.MovieInfo
TYPE:  class
TOKEN: 0x2000128
FIELDS:
  private           System.UInt32                   _reserved1  // 0x10
  public            System.UInt32                   numAlphaStreams  // 0x14
  public            System.UInt32                   width  // 0x18
  public            System.UInt32                   height  // 0x1C
  public            System.UInt32                   dispWidth  // 0x20
  public            System.UInt32                   dispHeight  // 0x24
  public            System.UInt32                   framerateN  // 0x28
  public            System.UInt32                   framerateD  // 0x2C
  public            System.UInt32                   totalFrames  // 0x30
  public            CriWare.CriMana.CodecType       codecType  // 0x34
  public            CriWare.CriMana.CodecType       alphaCodecType  // 0x38
  public            System.UInt32                   numAudioStreams  // 0x3C
  public            CriWare.CriMana.AudioInfo[]     audioPrm  // 0x40
  public            System.UInt32                   numSubtitleChannels  // 0x48
  public            System.UInt32                   maxSubtitleSize  // 0x4C
  public            System.UInt32                   maxChunkSize  // 0x50
METHODS:
  System.Boolean get_hasAlpha()
  System.Void set_hasAlpha(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriMana.FrameInfo
TYPE:  class
TOKEN: 0x2000129
FIELDS:
  public            System.Int32                    frameNo  // 0x10
  public            System.Int32                    frameNoPerFile  // 0x14
  public            System.UInt32                   width  // 0x18
  public            System.UInt32                   height  // 0x1C
  public            System.UInt32                   dispWidth  // 0x20
  public            System.UInt32                   dispHeight  // 0x24
  public            System.UInt32                   numImages  // 0x28
  public            System.UInt32                   framerateN  // 0x2C
  public            System.UInt32                   framerateD  // 0x30
  private           System.UInt32                   _reserved1  // 0x34
  public            System.UInt64                   time  // 0x38
  public            System.UInt64                   tunit  // 0x40
  public            System.UInt32                   cntConcatenatedMovie  // 0x48
  private           CriWare.CriMana.AlphaType       alphaType  // 0x4C
  public            System.UInt32                   cntSkippedFrames  // 0x50
  public            System.UInt32                   totalFramesPerFile  // 0x54
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriMana.EventPoint
TYPE:  struct
TOKEN: 0x200012A
FIELDS:
  public            System.IntPtr                   cueName  // 0x10
  public            System.UInt32                   cueNameSize  // 0x18
  public            System.UInt64                   time  // 0x20
  public            System.UInt64                   tunit  // 0x28
  public            System.Int32                    type  // 0x30
  public            System.IntPtr                   paramString  // 0x38
  public            System.UInt32                   paramStringSize  // 0x40
  public            System.UInt32                   cntCallback  // 0x44
METHODS:
END_CLASS

CLASS: CriWare.CriMana.Settings
TYPE:  class
TOKEN: 0x200012B
FIELDS:
METHODS:
  System.Void SetDecodeSkippingEnabled(System.Boolean enabled)
END_CLASS

CLASS: CriWare.CriMana.Player
TYPE:  class
TOKEN: 0x200012C
EXTENDS: CriDisposable
FIELDS:
  private   static  System.Int32                    InvalidPlayerId  // 0x0
  private   static  CriWare.CriMana.Player          updatingPlayer  // 0x0
  private           System.Int32                    playerId  // 0x20
  private           System.Boolean                  isDisposed  // 0x24
  private           CriWare.CriMana.Player.Status   internalrequiredStatus  // 0x28
  private           CriWare.CriMana.Player.Status   _nativeStatus  // 0x2C
  private           System.Nullable<CriWare.CriMana.Player.Status>lastNativeStatus  // 0x30
  private           System.Nullable<CriWare.CriMana.Player.Status>lastPlayerStatus  // 0x38
  private           System.Boolean                  wasStopping  // 0x40
  private           System.Boolean                  isPreparingForRendering  // 0x41
  private           System.Boolean                  isNativeStartInvoked  // 0x42
  private           System.Boolean                  isNativeInitialized  // 0x43
  private           CriWare.CriMana.Detail.RendererResourcerendererResource  // 0x48
  private           CriWare.CriMana.MovieInfo       _movieInfo  // 0x50
  private           CriWare.CriMana.FrameInfo       _frameInfo  // 0x58
  private           System.Boolean                  isMovieInfoAvailable  // 0x60
  private           System.Boolean                  isFrameInfoAvailable  // 0x61
  private           CriWare.CriMana.Player.ShaderDispatchCallback_shaderDispatchCallback  // 0x68
  private           System.Boolean                  enableSubtitle  // 0x70
  private           System.Int32                    subtitleBufferSize  // 0x74
  private           System.UInt32                   droppedFrameCount  // 0x78
  private           CriWare.CriAtomExPlayer         _atomExPlayer  // 0x80
  private           CriWare.CriAtomEx3dSource       _atomEx3Dsource  // 0x88
  private           CriWare.CriMana.Player.TimerType_timerType  // 0x90
  private           System.Boolean                  isStoppingForSeek  // 0x94
  public            CriWare.CriMana.Player.CuePointCallbackcuePointCallback  // 0x98
  public            CriWare.CriMana.Player.StatusChangeCallbackstatusChangeCallback  // 0xA0
  private           CriWare.CriMana.Player.SubtitleChangeCallbackOnSubtitleChanged  // 0xA8
  private           System.Boolean                  <additiveMode>k__BackingField  // 0xB0
  private           System.Boolean                  <useMaterialBlendMode>k__BackingField  // 0xB1
  private           System.Int32                    <maxFrameDrop>k__BackingField  // 0xB4
  private           System.Boolean                  <applyTargetAlpha>k__BackingField  // 0xB8
  private           System.Boolean                  <uiRenderMode>k__BackingField  // 0xB9
  private           System.IntPtr                   <subtitleBuffer>k__BackingField  // 0xC0
  private           System.Int32                    <subtitleSize>k__BackingField  // 0xC8
  private           CriWare.CriManaMoviePlayerHolder<playerHolder>k__BackingField  // 0xD0
  protected         System.Collections.Generic.Queue<CriWare.CriMana.Player.Operation>operationQueue  // 0xD8
  protected         System.Nullable<CriWare.CriMana.Player.Operation>cntOperation  // 0xE0
METHODS:
  CriWare.CriMana.Player.Status get_requiredStatus()
  System.Void set_requiredStatus(CriWare.CriMana.Player.Status value)
  System.Void add_OnSubtitleChanged(CriWare.CriMana.Player.SubtitleChangeCallback value)
  System.Void remove_OnSubtitleChanged(CriWare.CriMana.Player.SubtitleChangeCallback value)
  System.Boolean get_additiveMode()
  System.Void set_additiveMode(System.Boolean value)
  System.Boolean get_useMaterialBlendMode()
  System.Void set_useMaterialBlendMode(System.Boolean value)
  System.Int32 get_maxFrameDrop()
  System.Void set_maxFrameDrop(System.Int32 value)
  System.Boolean get_applyTargetAlpha()
  System.Void set_applyTargetAlpha(System.Boolean value)
  System.Boolean get_uiRenderMode()
  System.Void set_uiRenderMode(System.Boolean value)
  System.Boolean get_isFrameAvailable()
  CriWare.CriMana.MovieInfo get_movieInfo()
  CriWare.CriMana.FrameInfo get_frameInfo()
  CriWare.CriMana.Player.Status get_status()
  CriWare.CriMana.Player.Status get_nativeStatus()
  System.Int32 get_numberOfEntries()
  System.IntPtr get_subtitleBuffer()
  System.Void set_subtitleBuffer(System.IntPtr value)
  System.Int32 get_subtitleSize()
  System.Void set_subtitleSize(System.Int32 value)
  CriWare.CriAtomExPlayer get_atomExPlayer()
  CriWare.CriAtomEx3dSource get_atomEx3DsourceForAmbisonics()
  CriWare.CriMana.Player.TimerType get_timerType()
  CriWare.CriManaMoviePlayerHolder get_playerHolder()
  System.Void set_playerHolder(CriWare.CriManaMoviePlayerHolder value)
  System.Void .ctor()
  System.Void .ctor(System.Boolean advanced_audio_mode, System.Boolean ambisonics_mode, System.UInt32 max_path_length)
  System.Void Finalize()
  System.Void Dispose()
  System.Void CreateRendererResource(System.Int32 width, System.Int32 height, System.Boolean alpha)
  System.Void DisposeRendererResource()
  System.Void Prepare()
  System.Void PrepareForRendering()
  System.Void Start()
  System.Void Stop()
  System.Void StopForSeek()
  System.Void Pause(System.Boolean sw)
  System.Boolean IsPaused()
  System.Boolean SetFile(CriWare.CriFsBinder binder, System.String moviePath, CriWare.CriMana.Player.SetMode setMode)
  System.Boolean SetData(System.IntPtr data, System.Int64 dataSize, CriWare.CriMana.Player.SetMode setMode)
  System.Boolean SetData(System.Byte[] data, System.Int64 datasize, CriWare.CriMana.Player.SetMode setMode)
  System.Boolean SetContentId(CriWare.CriFsBinder binder, System.Int32 contentId, CriWare.CriMana.Player.SetMode setMode)
  System.Boolean SetFileRange(System.String filePath, System.UInt64 offset, System.Int64 range, CriWare.CriMana.Player.SetMode setMode)
  System.Void Loop(System.Boolean sw)
  System.Void SetMasterTimerType(CriWare.CriMana.Player.TimerType timerType)
  System.Void SetSeekPosition(System.Int32 frameNumber)
  System.Void SetMovieEventSyncMode(CriWare.CriMana.Player.MovieEventSyncMode mode)
  System.Void SetSpeed(System.Single speed)
  System.Void SetMaxPictureDataSize(System.UInt32 maxDataSize)
  System.Void SetBufferingTime(System.Single sec)
  System.Void SetMinBufferSize(System.Int32 min_buffer_size)
  System.Void SetAudioTrack(System.Int32 track)
  System.Void SetAudioTrack(CriWare.CriMana.Player.AudioTrack track)
  System.Void SetSubAudioTrack(System.Int32 track)
  System.Void SetSubAudioTrack(CriWare.CriMana.Player.AudioTrack track)
  System.Void SetExtraAudioTrack(System.Int32 track)
  System.Void SetExtraAudioTrack(CriWare.CriMana.Player.AudioTrack track)
  System.Void SetVolume(System.Single volume)
  System.Single GetVolume()
  System.Void SetSubAudioVolume(System.Single volume)
  System.Single GetSubAudioVolume()
  System.Void SetExtraAudioVolume(System.Single volume)
  System.Single GetExtraAudioVolume()
  System.Void SetBusSendLevel(System.String bus_name, System.Single level)
  System.Void SetSubAudioBusSendLevel(System.String bus_name, System.Single volume)
  System.Void SetExtraAudioBusSendLevel(System.String bus_name, System.Single volume)
  System.Void SetSubtitleChannel(System.Int32 channel)
  System.Void SetShaderDispatchCallback(CriWare.CriMana.Player.ShaderDispatchCallback shaderDispatchCallback)
  System.Int64 GetTime()
  System.Int32 GetDisplayedFrameNo()
  System.Boolean HasRenderedNewFrame()
  System.Void SetAsrRackId(System.Int32 asrRackId)
  System.Void SetUserTimeCorrectionThreshold(System.UInt32 threshold_msec)
  System.Void SetExtraFramePoolSize(System.UInt32 size)
  System.Void UpdateWithUserTime(System.UInt64 timeCount, System.UInt64 timeUnit)
  System.Void SetManualTimerUnit(System.UInt64 timeUnitN, System.UInt64 timeUnitD)
  System.Void UpdateWithManualTimeAdvanced()
  System.Void Update()
  System.Void OnWillRenderObject(CriWare.CriManaMovieMaterialBase sender)
  System.Boolean UpdateMaterial(UnityEngine.Material material)
  System.Boolean get_isAlive()
  System.Void IssuePluginEvent(CriWare.CriMana.Player.CriManaUnityPlayer_RenderEventAction renderEventAction)
  System.Void Dispose(System.Boolean disposing)
  System.Void InternalUpdate()
  System.Collections.IEnumerator IssuePluginUpdatesForFrames(System.Int32 frameCount, UnityEngine.MonoBehaviour playerHolder, System.Boolean destroy, System.Int32 playerId)
  System.Void DisableInfos(System.Boolean keepFrameInfo)
  System.Void PrepareNativePlayer()
  System.Void UpdateNativePlayer()
  System.Void InvokePlayerStatusCheck()
  System.Void AllocateSubtitleBuffer(System.Int32 size)
  System.Void DeallocateSubtitleBuffer()
  System.Void PauseOnApplicationPause(System.Boolean sw)
  System.Void CuePointCallbackFromNative(System.IntPtr ptr1, System.IntPtr ptr2, CriWare.CriMana.EventPoint& eventPoint)
  System.Int32 CRIWAREFD186F02()
  System.Int32 CRIWARE72A5B8BF()
  System.Int32 CRIWARE95A85424(System.Boolean useAtomExPlayer, System.UInt32 maxPathLength)
  System.Void CRIWAREABF659EC(System.Int32 player_id)
  System.Void CRIWAREEDB46019(System.Int32 player_id, System.IntPtr binder, System.String path)
  System.Void CRIWAREB28B5D50(System.Int32 player_id, System.IntPtr binder, System.Int32 content_id)
  System.Void CRIWARE65553651(System.Int32 player_id, System.String path, System.UInt64 offset, System.Int64 range)
  System.Void CRIWARE7C753A2E(System.Int32 player_id, System.IntPtr data, System.Int64 datasize)
  System.Void CRIWARE7C753A2E(System.Int32 player_id, System.Byte[] data, System.Int64 datasize)
  System.Boolean CRIWARE328F2911(System.Int32 player_id, System.IntPtr binder, System.String path, System.Boolean repeat)
  System.Boolean CRIWAREDA0693CD(System.Int32 player_id, System.IntPtr binder, System.Int32 content_id, System.Boolean repeat)
  System.Boolean CRIWARE162DD162(System.Int32 player_id, System.String path, System.UInt64 offset, System.Int64 range, System.Boolean repeat)
  System.Boolean CRIWAREC35C3DC3(System.Int32 player_id, System.IntPtr data, System.Int64 datasize, System.Boolean repeat)
  System.Boolean CRIWAREC35C3DC3(System.Int32 player_id, System.Byte[] data, System.Int64 datasize, System.Boolean repeat)
  System.Void CRIWARE66A63134(System.Int32 player_id)
  System.Int32 CRIWARE88D04318(System.Int32 player_id)
  System.Void CRIWARED9F7168D(System.Int32 player_id, CriWare.CriMana.Player.CuePointCallbackFromNativeDelegate cbfunc)
  System.Void CRIWARE1E785A43(System.Int32 player_id, CriWare.CriMana.MovieInfo movie_info)
  System.Int32 CRIWARE3CE8CE6A(System.Int32 player_id, System.IntPtr subtitle_buffer, System.UInt32& subtitle_size)
  System.Void CRIWARE362A826C(System.Int32 player_id)
  System.Void CRIWARE61523A0C(System.Int32 player_id)
  System.Void CRIWAREBB898C91(System.Int32 player_id)
  System.Void CRIWARE705B8C6D(System.Int32 player_id, System.Int32 seek_frame_no)
  System.Void CRIWAREEB32FC73(System.Int32 player_id, CriWare.CriMana.Player.MovieEventSyncMode mode)
  System.Void CRIWARE18BFCB88(System.Int32 player_id, System.Int32 sw)
  System.Boolean CRIWAREEFA5210A(System.Int32 player_id)
  System.Void CRIWARE4331E077(System.Int32 player_id, System.Int32 sw)
  System.Int64 CRIWARE7779586C(System.Int32 player_id)
  System.Int32 CRIWARE33981CC9(System.Int32 player_id)
  System.IntPtr CRIWARE165B6B70(System.Int32 player_id)
  System.Int32 CRIWARE7500F0DD(System.Int32 player_id)
  System.Void CRIWARED99932F6(System.Int32 player_id, System.Int32 track)
  System.Void CRIWARE1FF2F5BE(System.Int32 player_id, System.Single vol)
  System.Single CRIWARED30C9C6F(System.Int32 player_id)
  System.Void CRIWARE0EA59F65(System.Int32 player_id, System.Int32 track)
  System.Void CRIWARE1EBB12C5(System.Int32 player_id, System.Single vol)
  System.Single CRIWARE966C4BA9(System.Int32 player_id)
  System.Void CRIWARE213452EF(System.Int32 player_id, System.Int32 track)
  System.Void CRIWARE0348BF1B(System.Int32 player_id, System.Single vol)
  System.Single CRIWAREC5A3A88D(System.Int32 player_id)
  System.Void CRIWARE31668293(System.Int32 player_id, System.String bus_name, System.Single level)
  System.Void CRIWAREB2460D7A(System.Int32 player_id, System.String bus_name, System.Single level)
  System.Void CRIWAREF4B0CC4E(System.Int32 player_id, System.String bus_name, System.Single level)
  System.Void CRIWARE2C8FF595(System.Int32 player_id, System.Int32 channel)
  System.Void CRIWAREAB576D15(System.Int32 player_id, System.Single speed)
  System.Void CRIWARE3F9C5D06(System.Int32 player_id, System.UInt32 max_data_size)
  System.Void CRIWARE8A87737B(System.Int32 player_id, System.Single sec)
  System.Void CRIWARE6756AE56(System.Int32 player_id, System.Int32 min_buffer_size)
  System.Void CRIWAREA7F6DE6B(System.Int32 player_id, System.Int32 asr_rack_id)
  System.Void CRIWAREE2DF1163(System.Int32 player_id)
  System.Void CRIWAREBD24DE27(System.Int32 player_id, CriWare.CriMana.Player.TimerType timer_type)
  System.Void CRIWAREC7C5CC77(System.Int32 player_id, System.UInt64 user_count, System.UInt64 user_unit)
  System.Void CRIWAREA59E0F01(System.Int32 player_id, System.UInt64 timer_unit_n, System.UInt64 timer_unit_d)
  System.Void CRIWARE55ECC3E4(System.Int32 player_id)
  System.Void CRIWARECEA2FA98(System.Int32 player_id)
  System.IntPtr CRIWARE27ED314F(System.Int32 player_id, System.Int32 bufferSize)
  System.Boolean CRIWARE725ED4B4(System.Int32 player_id)
  System.Void CRIWARE419ECAF8(System.Int32 player_id)
  System.IntPtr criWareUnity_GetRenderEventFunc()
  System.Void criManaUnityPlayer_SetUserTimeCorrectionThreshold(System.Int32 player_id, System.UInt32 threshold_msec)
  System.Void criManaUnityPlayer_SetExtraFramePoolSize(System.Int32 player_id, System.UInt32 size)
  System.Void ClearAllOperation()
  System.Void ExecuteOperation()
  System.Void EasyPrepare()
  System.Void EasyPrepareForRendering()
  System.Void EasyStart()
  System.Void EasyPause(System.Boolean sw)
  System.Void EasyStop()
  System.Void EasyStopForSeek()
  System.Void EasySetFile(CriWare.CriFsBinder binder, System.String moviePath, CriWare.CriMana.Player.SetMode setMode)
  System.Void EasySetSeekTime(System.Single time)
  System.Void EasyStartAtTime(System.Single time)
  System.Single GetVideoLength()
END_CLASS

CLASS: CriWare.CriMana.Detail.AutoResisterRendererResourceFactories
TYPE:  class
TOKEN: 0x200013B
FIELDS:
METHODS:
  System.Void InvokeAutoRegister()
END_CLASS

CLASS: CriWare.CriMana.Detail.RendererResourceH264Yuv
TYPE:  class
TOKEN: 0x200013F
EXTENDS: RendererResourceSofdecPrimeYuv
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader)
END_CLASS

CLASS: CriWare.CriMana.Detail.RendererResource
TYPE:  class
TOKEN: 0x2000140
FIELDS:
  private           System.Boolean                  disposed  // 0x10
  protected         UnityEngine.Shader              shader  // 0x18
  protected         UnityEngine.Material            currentMaterial  // 0x20
  protected         System.Boolean                  hasAlpha  // 0x28
  protected         System.Boolean                  additive  // 0x29
  protected         System.Boolean                  applyTargetAlpha  // 0x2A
  protected         System.Boolean                  ui  // 0x2B
  private           System.Boolean                  _useMaterialBlendMode  // 0x2C
METHODS:
  System.Boolean get_useMaterialBlendMode()
  System.Void set_useMaterialBlendMode(System.Boolean value)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Int32 GetNumberOfFrameBeforeDestroy(System.Int32 playerId)
  System.Void SetupStaticMaterialProperties()
  System.Void GetBlendModes(System.Int32& srcBlendMode, System.Int32& dstBlendMode)
  System.Void SetApplyTargetAlpha(System.Boolean flag)
  System.Void SetUiRenderMode(System.Boolean flag)
  System.Void OnDisposeManaged()
  System.Void OnDisposeUnmanaged()
  System.Boolean IsPrepared()
  System.Boolean ContinuePreparing()
  System.Void AttachToPlayer(System.Int32 playerId)
  System.Boolean UpdateFrame(System.Int32 playerId, CriWare.CriMana.FrameInfo frameInfo, System.Boolean& frameDrop)
  System.Boolean UpdateMaterial(UnityEngine.Material material)
  System.Void UpdateTextures()
  System.Boolean IsSuitable(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader)
  System.Void OnPlayerPause(System.Boolean pauseStatus, System.Boolean triggredFromApplciationPause)
  System.Void OnPlayerStop()
  System.Boolean OnPlayerStopForSeek()
  System.Void OnPlayerStart()
  System.Boolean ShouldSkipDestroyOnStopForSeek()
  System.Boolean HasRenderedNewFrame()
  System.UInt32 NextPowerOfTwo(System.UInt32 x)
  System.Int32 NextPowerOfTwo(System.Int32 x)
  System.Int32 CeilingWith(System.Int32 x, System.Int32 ceilingValue)
  System.Int32 Ceiling16(System.Int32 x)
  System.Int32 Ceiling32(System.Int32 x)
  System.Int32 Ceiling64(System.Int32 x)
  System.Int32 Ceiling256(System.Int32 x)
  System.Void DisposeTextures(UnityEngine.Texture[] textures)
  System.Void SetKeyword(UnityEngine.Material material, System.String keyword, System.Boolean flag)
  System.Boolean CRIWARE98318E69(System.Int32 player_id, System.Int32 num_textures, System.IntPtr[] tex_ptrs, CriWare.CriMana.FrameInfo frame_info, System.Boolean& frame_drop)
  System.Boolean CRIWARED618B369(System.Int32 player_id, System.Int32 num_textures, System.IntPtr[] tex_ptrs)
  System.Boolean CRIWARE5267266A(System.Int32 player_id, System.Int32 num_textures, System.IntPtr[] tex_ptrs)
  System.Boolean CRIWAREE519EFD4(System.Int32 player_id, System.Int32 num_textures, System.IntPtr[] tex_ptrs)
  System.SByte CRIWAREF14F77D8(System.Int32 player_id)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriMana.Detail.RendererResourceFactory
TYPE:  class
TOKEN: 0x2000141
FIELDS:
  private   static  System.Collections.Generic.SortedList<System.Int32,CriWare.CriMana.Detail.RendererResourceFactory>factoryList  // 0x0
  private           System.Boolean                  disposed  // 0x10
METHODS:
  System.Void RegisterFactory(CriWare.CriMana.Detail.RendererResourceFactory factory, System.Int32 priority)
  System.Void DisposeAllFactories()
  CriWare.CriMana.Detail.RendererResource DispatchAndCreate(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void OnDisposeManaged()
  System.Void OnDisposeUnmanaged()
  CriWare.CriMana.Detail.RendererResource CreateRendererResource(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriMana.Detail.RendererResourceFactoryPriorityAttribute
TYPE:  class
TOKEN: 0x2000142
EXTENDS: Attribute
FIELDS:
  public    readonly System.Int32                    priority  // 0x10
METHODS:
  System.Void .ctor(System.Int32 priority)
END_CLASS

CLASS: CriWare.CriMana.Detail.RendererResourceSofdecPrimeYuv
TYPE:  class
TOKEN: 0x2000143
EXTENDS: RendererResource
FIELDS:
  private           System.Int32                    width  // 0x30
  private           System.Int32                    height  // 0x34
  private           System.Boolean                  useUserShader  // 0x38
  private           CriWare.CriMana.CodecType       codecType  // 0x3C
  private           UnityEngine.Vector4             movieTextureST  // 0x40
  private           UnityEngine.Vector4             movieChromaTextureST  // 0x50
  private           UnityEngine.Texture2D[]         textureY  // 0x60
  private           UnityEngine.Texture2D[]         textureU  // 0x68
  private           UnityEngine.Texture2D[]         textureV  // 0x70
  private           UnityEngine.Texture2D[]         textureA  // 0x78
  private           System.IntPtr[]                 nativeTextures  // 0x80
  private           System.Int32                    currentTextureSet  // 0x88
  private           System.Int32                    drawTextureSet  // 0x8C
  private           System.Int32                    playerID  // 0x90
  private           System.Boolean                  hasTextureUpdated  // 0x94
  private           System.Boolean                  isTextureReady  // 0x95
  private           System.Boolean                  hasRenderedNewFrame  // 0x96
METHODS:
  System.Int32 get_NumTextureSets()
  System.Void .ctor(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader)
  System.Void OnDisposeManaged()
  System.Boolean get_IsEditor()
  System.Void OnDisposeUnmanaged()
  System.Boolean IsPrepared()
  System.Boolean ContinuePreparing()
  System.Boolean IsSuitable(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader)
  System.Boolean OnPlayerStopForSeek()
  System.Boolean HasRenderedNewFrame()
  System.Void AttachToPlayer(System.Int32 playerId)
  System.Boolean UpdateFrame(System.Int32 playerId, CriWare.CriMana.FrameInfo frameInfo, System.Boolean& frameDrop)
  System.Boolean UpdateMaterial(UnityEngine.Material material)
  System.Void UpdateMovieTextureST(System.UInt32 dispWidth, System.UInt32 dispHeight)
  System.Void UpdateTextures()
END_CLASS

CLASS: CriWare.CriMana.Detail.RendererResourceSofdecPrimeYuvRawData
TYPE:  class
TOKEN: 0x2000144
EXTENDS: RendererResource
FIELDS:
  private           System.Int32                    width  // 0x30
  private           System.Int32                    height  // 0x34
  private           System.Int32                    chromaWidth  // 0x38
  private           System.Int32                    chromaHeight  // 0x3C
  private           System.Boolean                  useUserShader  // 0x40
  private           CriWare.CriMana.CodecType       codecType  // 0x44
  private           UnityEngine.Vector4             movieTextureST  // 0x48
  private           UnityEngine.Vector4             movieChromaTextureST  // 0x58
  private           UnityEngine.Texture2D[][]       textures  // 0x68
  private           System.Int32                    currentTextureSet  // 0x70
  private           System.Int32                    drawTextureSet  // 0x74
  private           System.IntPtr[]                 nativePixels  // 0x78
  private           System.Int32                    playerID  // 0x80
  private           System.Boolean                  hasTextureUpdated  // 0x84
  private           System.Boolean                  isTextureReady  // 0x85
  private           System.Boolean                  hasRenderedNewFrame  // 0x86
METHODS:
  System.Int32 get_NumTextureSets()
  System.Void .ctor(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader)
  System.Void OnDisposeManaged()
  System.Void OnDisposeUnmanaged()
  System.Boolean IsPrepared()
  System.Boolean ContinuePreparing()
  System.Boolean IsSuitable(System.Int32 playerId, CriWare.CriMana.MovieInfo movieInfo, System.Boolean additive, UnityEngine.Shader userShader)
  System.Boolean OnPlayerStopForSeek()
  System.Boolean HasRenderedNewFrame()
  System.Void AttachToPlayer(System.Int32 playerId)
  System.Boolean UpdateFrame(System.Int32 playerId, CriWare.CriMana.FrameInfo frameInfo, System.Boolean& frameDrop)
  System.Boolean UpdateMaterial(UnityEngine.Material material)
  System.Void UpdateMovieTextureST(System.UInt32 dispWidth, System.UInt32 dispHeight)
  System.Void UpdateTextures()
  System.Void CalculateTextureSize(System.Int32& w, System.Int32& h, System.Int32 videoWidth, System.Int32 videoHeight, CriWare.CriMana.CodecType type, System.Boolean isChroma)
END_CLASS

CLASS: CriWare.CriTimeline.Atom.CriAtomClipPlayConfig
TYPE:  struct
TOKEN: 0x200011D
FIELDS:
  public    readonly CriWare.CriTimeline.Atom.CriAtomClipBaseclip  // 0x10
  public    readonly System.Int64                    startTimeMs  // 0x18
  public    readonly System.Double                   speedRate  // 0x20
  public    readonly System.Boolean                  loop  // 0x28
METHODS:
  System.Void .ctor(CriWare.CriTimeline.Atom.CriAtomClipBase clip, System.Int64 startTimeMs, System.Double speedRate, System.Boolean loop)
END_CLASS

CLASS: CriWare.CriTimeline.Atom.CriAtomBehaviour
TYPE:  class
TOKEN: 0x200011E
EXTENDS: PlayableBehaviour
FIELDS:
  public            System.Single                   volume  // 0x10
  public            System.Single                   pitch  // 0x14
  public            System.Single                   AISACValue  // 0x18
  private   static  System.Int32                    cPreviewStopTimeMs  // 0x0
  private           CriWare.CriAtomExAcb            m_acb  // 0x20
  private           System.String                   m_lastCueSheetPath  // 0x28
  private           CriWare.CriAtomExPlayback       <playback>k__BackingField  // 0x30
  private           System.Boolean                  _IsClipPlaying  // 0x34
  private           System.Double                   _CueLength  // 0x38
METHODS:
  CriWare.CriAtomExPlayback get_playback()
  System.Void set_playback(CriWare.CriAtomExPlayback value)
  System.Boolean get_IsClipPlaying()
  System.Void set_IsClipPlaying(System.Boolean value)
  System.Double get_CueLength()
  System.Void set_CueLength(System.Double value)
  System.Void OnGraphStop(UnityEngine.Playables.Playable playable)
  System.Void Play(CriWare.CriAtomSourceBase atomSource, CriWare.CriTimeline.Atom.CriAtomClipPlayConfig config)
  System.Void PreviewPlay(System.Guid trackId, System.Boolean instantStop, CriWare.CriTimeline.Atom.CriAtomClipPlayConfig config)
  System.Void WaitAndStop()
  System.Void Stop(System.Boolean noReleaseTime)
  System.Double GetCueLengthSec(CriWare.CriAtomExAcb acb, System.String cueName)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <WaitAndStop>b__21_0()
END_CLASS

CLASS: CriWare.CriTimeline.Atom.CriAtomClip
TYPE:  class
TOKEN: 0x200011F
EXTENDS: CriAtomClipBase
FIELDS:
  public            System.String                   cueSheet  // 0x30
  public            System.String                   cueName  // 0x38
METHODS:
  System.String get_CueName()
  CriWare.CriAtomExAcb GetAcb()
  CriWare.CriAtomCueSheet GetCueSheet()
  System.String get_AcbPath()
  System.String get_AwbPath()
  System.Void SetCueFromAtomSource(CriWare.CriAtomSourceBase atomSource)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriTimeline.Atom.CriAtomClipBase
TYPE:  class
TOKEN: 0x2000120
EXTENDS: PlayableAsset
FIELDS:
  public            System.Boolean                  stopWithoutRelease  // 0x18
  public            System.Boolean                  muted  // 0x19
  public            System.Boolean                  ignoreBlend  // 0x1A
  public            System.Boolean                  loopWithinClip  // 0x1B
  public            System.Boolean                  stopAtClipEnd  // 0x1C
  public            CriWare.CriTimeline.Atom.CriAtomBehaviourtemplateBehaviour  // 0x20
  private           System.Double                   clipDuration  // 0x28
METHODS:
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Void SetClipDuration(System.Double clipDuration)
  System.Double get_duration()
  System.String get_CueName()
  CriWare.CriAtomExAcb GetAcb()
  System.String get_AcbPath()
  System.String get_AwbPath()
  System.Void SetCueFromAtomSource(CriWare.CriAtomSourceBase atomSource)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriTimeline.Atom.CriAtomMixerBehaviour
TYPE:  class
TOKEN: 0x2000121
EXTENDS: PlayableBehaviour
FIELDS:
  private           UnityEngine.Playables.PlayableDirectorm_Director  // 0x10
  private           System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip>m_Clips  // 0x18
  private           CriWare.CriAtomSourceBase       m_Bind  // 0x20
  private           System.String                   m_AisacControls  // 0x28
  private           System.Boolean                  m_StopOnWrapping  // 0x30
  private           System.Boolean                  m_StopAtGraphEnd  // 0x31
  private           System.Guid                     <m_Guid>k__BackingField  // 0x34
  private   static  System.Int32                    cScratchTimeIntervalMs  // 0x0
  private           System.DateTime                 m_lastScrubTime  // 0x48
  private           System.Double                   m_lastDirectorTime  // 0x50
METHODS:
  System.Guid get_m_Guid()
  System.Void set_m_Guid(System.Guid value)
  System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable)
  System.Void OnGraphStop(UnityEngine.Playables.Playable playable)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  System.Boolean get_IsEditor()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriTimeline.Atom.CriAtomTimelinePreviewer
TYPE:  class
TOKEN: 0x2000122
FIELDS:
  private   static  CriWare.CriTimeline.Atom.CriAtomTimelinePreviewerinstance  // 0x0
  private           CriWare.CriAtom                 atom  // 0x10
  private           System.String                   lastAcfFile  // 0x18
  private           System.Collections.Generic.Dictionary<System.String,CriWare.CriAtomExAcb>acbTable  // 0x20
  private           System.Collections.Generic.Dictionary<System.Guid,CriWare.CriTimeline.Atom.CriAtomTimelinePreviewer.PlayerSource>playerTable  // 0x28
  private           CriWare.CriAtomEx3dListener     listener3d  // 0x30
METHODS:
  CriWare.CriTimeline.Atom.CriAtomTimelinePreviewer get_Instance()
  System.Void InstanceDispose()
  System.Boolean get_IsInitialized()
  System.Void .ctor()
  CriWare.CriAtomExPlayer GetPlayer(System.Guid trackId)
  System.Void SetCue(System.Guid trackId, CriWare.CriAtomExAcb acb, System.String cueName)
  CriWare.CriAtomExAcb GetAcb(System.String acbPath, System.String awbPath)
  CriWare.CriAtomExPlayback Play(System.Guid trackId)
  System.Void StopTrack(System.Guid trackId, System.Boolean stopWithoutRelease)
  System.Void StopAllTracks(System.Boolean stopWithoutRelease)
  System.Void SetStartTime(System.Guid trackId, System.Int64 startTimeMs)
  System.Void SetLoop(System.Guid trackId, System.Boolean sw)
  System.Void SetVolume(System.Guid trackId, System.Single volume)
  System.Void SetPitch(System.Guid trackId, System.Single pitch)
  System.Void SetAISAC(System.Guid trackId, System.String controlName, System.Single value)
  System.Void PlayerUpdateParameter(System.Guid trackId, CriWare.CriAtomExPlayback atomExPlayback)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: CriWare.CriTimeline.Atom.CriAtomTrack
TYPE:  class
TOKEN: 0x2000124
EXTENDS: TrackAsset
FIELDS:
  public            System.String                   m_AisacControls  // 0xC0
  public            System.Boolean                  m_StopOnWrapping  // 0xC8
  public            System.Boolean                  m_StopAtGraphEnd  // 0xC9
METHODS:
  UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner, System.Int32 inputCount)
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriTimeline.Mana.CriManaBehaviour
TYPE:  class
TOKEN: 0x2000113
EXTENDS: PlayableBehaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriTimeline.Mana.CriManaClip
TYPE:  class
TOKEN: 0x2000114
EXTENDS: CriManaClipBase
FIELDS:
  public            System.String                   m_moviePath  // 0xA8
  public            UnityEngine.TextAsset           m_movieData  // 0xB0
METHODS:
  System.String get_MoviePath()
  System.Byte[] get_MovieData()
  System.String get_MovieName()
  System.Int32 get_DataId()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriTimeline.Mana.CriManaClipBase
TYPE:  class
TOKEN: 0x2000115
EXTENDS: PlayableAsset
FIELDS:
  public    readonly System.Guid                     guid  // 0x18
  public            System.Boolean                  m_loopWithinClip  // 0x28
  public            System.Boolean                  m_useOnMemoryPlayback  // 0x29
  public            System.Runtime.InteropServices.GCHandlegcHandle  // 0x30
  private           System.Double                   m_movieFrameRate  // 0x38
  private           System.Double                   m_clipDuration  // 0x40
  public            System.Single                   m_fadeinDuration  // 0x48
  public            UnityEngine.AnimationCurve      m_fadeinCurve  // 0x50
  public            System.Single                   m_fadeoutDuration  // 0x58
  public            UnityEngine.AnimationCurve      m_fadeoutCurve  // 0x60
  public            System.Boolean                  m_fadeAudio  // 0x68
  public            UnityEngine.Timeline.TimelineClipm_clip  // 0x70
  public            CriWare.CriTimeline.Mana.CriManaBehaviourm_manaBehaviour  // 0x78
  private           System.Nullable<CriWare.CriTimeline.Mana.CriManaClipBase.MovieInfoStruct>m_movieInfoStruct  // 0x80
METHODS:
  System.String get_MoviePath()
  System.Byte[] get_MovieData()
  System.String get_MovieName()
  System.Int32 get_DataId()
  System.Nullable<CriWare.CriTimeline.Mana.CriManaClipBase.MovieInfoStruct> StructToMovieInfo(CriWare.CriMana.MovieInfo movieInfo)
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Void ReplaceMovieInfo(CriWare.CriMana.MovieInfo movieInfo)
  System.Boolean IsSameMovie(CriWare.CriMana.MovieInfo movieInfo)
  System.Boolean get_IsMovieInfoReady()
  System.Int32 GetSeekFrame(System.Double seekTimeSec, System.Boolean loop)
  System.Double get_duration()
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriTimeline.Mana.CriManaMixerBehaviour
TYPE:  class
TOKEN: 0x2000117
EXTENDS: PlayableBehaviour
FIELDS:
  private           UnityEngine.Playables.PlayableDirectorm_PlayableDirector  // 0x10
  private           System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip>m_clips  // 0x18
  private           CriWare.CriManaMovieMaterialBasem_boundMovieMaterial  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,System.Runtime.InteropServices.GCHandle>m_gcHandleList  // 0x28
  private           System.Boolean                  m_frameSync  // 0x30
  private   static  System.Double                   cPreloadTimeSec  // 0x0
  private           System.Nullable<System.Guid>    m_lastClipId  // 0x34
  private           System.Double                   startTime  // 0x48
  private           System.Double                   m_currentSeekingFrameTime  // 0x50
  private           System.Single                   m_originalAudioVolume  // 0x58
  private           System.Single                   m_originalSubAudioVolume  // 0x5C
  private           System.Single                   m_originalExtraAudioVolume  // 0x60
  private           System.Boolean                  enableTimelineScrubPlayback  // 0x64
  public            System.Boolean                  IsControllingUI  // 0x65
  private           CriWare.CriManaMovieControllerForUIm_controllerForUI  // 0x68
  public            System.Action<CriWare.CriMana.MovieInfo>MovieReadyToPlay  // 0x70
  public            System.Action<System.Boolean>   OnToggleFMVNode  // 0x78
  private           CriWare.CriTimeline.Mana.CriManaMixerBehaviour.MovieMixerStatem_movieMixerState  // 0x80
METHODS:
  System.Boolean get_IsEditMode()
  System.Void KeepAudioVolume(System.Boolean fadeAudio)
  System.Boolean PlayMovie(CriWare.CriTimeline.Mana.CriManaClipBase clipAsset, System.Int32 startFrame, System.Double startTime)
  System.Boolean PrepareMovie(CriWare.CriTimeline.Mana.CriManaClipBase clipAsset)
  System.Boolean StopMovie()
  System.Boolean StopForSeekMovie()
  System.Boolean IsPlayerPreparing(CriWare.CriMana.Player player)
  System.Boolean IsPlayerStopped(CriWare.CriMana.Player player)
  System.Boolean IsPlayerError(CriWare.CriMana.Player player)
  System.Boolean IsPlayerReadyOrPlaying(CriWare.CriMana.Player player)
  System.Void ProcessFrameOnSeeking(UnityEngine.Timeline.TimelineClip activeClip, CriWare.CriTimeline.Mana.CriManaClipBase clip, System.Double frameTime)
  System.Void ForceSyncedStop(System.Boolean keepLastFrame)
  System.Void ToggleFMVNode(UnityEngine.Playables.FrameData info, System.Boolean isOn)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  System.Collections.IEnumerator seekPlaybackEnumerator()
  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void PausePlayer(System.Boolean pause)
  System.Void OnGraphStart(UnityEngine.Playables.Playable playable)
  System.Void OnGraphStop(UnityEngine.Playables.Playable playable)
  System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable)
  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  System.Void InitMovieMixerState()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: CriWare.CriTimeline.Mana.CriManaTrack
TYPE:  class
TOKEN: 0x200011C
EXTENDS: TrackAsset
FIELDS:
  public            System.Boolean                  frameSync  // 0xC0
  public    readonly System.Guid                     guid  // 0xC4
  private   static  System.Collections.Generic.Dictionary<System.Int32,System.Guid>bindDict  // 0x0
  private           CriWare.CriTimeline.Mana.CriManaMixerBehaviour<MixerBehaviour>k__BackingField  // 0xD8
METHODS:
  CriWare.CriTimeline.Mana.CriManaMixerBehaviour get_MixerBehaviour()
  System.Void set_MixerBehaviour(CriWare.CriTimeline.Mana.CriManaMixerBehaviour value)
  UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  System.Void BindBehaviourMovieMaterial(UnityEngine.Playables.PlayableDirector director, CriWare.CriManaMovieMaterialBase boundMovieMaterial)
  System.Void OnDestroy()
  System.Void RemoveTrackFromBindDict(CriWare.CriTimeline.Mana.CriManaTrack trackAsset)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

