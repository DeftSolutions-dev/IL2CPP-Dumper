// ========================================================
// Dumped by @desirepro
// Assembly: LibScePad.Runtime.dll
// Classes:  90
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Audio
TYPE:  class
TOKEN: 0x2000003
FIELDS:
METHODS:
  System.Int32 IsSupportAudioFunction(System.Int32 handle)
  System.Int32 SetAudioOutPath(System.Int32 handle, Plugins.LibScePad.ScePadAudioOutPath path)
  System.Int32 SetVolumeGain(System.Int32 handle, System.Byte speakerVol, System.Byte jackVol, System.Byte micGain)
  Plugins.LibScePad.ScePadHeadsetType GetHeadSetType(System.Int32 handle)
END_CLASS

CLASS: Basic
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  System.Int32 Init()
  System.Int32 GetOrOpen(System.Int32 userId, Plugins.LibScePad.ScePadType type)
  System.Int32 GetHandle(System.Int32 userId, Plugins.LibScePad.ScePadType type)
  System.Int32 Close(System.Int32 handle)
  System.Int32 ResetLightBar(System.Int32 handle)
  System.Int32 SetLightBar(System.Int32 handle, UnityEngine.Color color)
  System.Int32 SetLightBar(System.Int32 handle, System.Byte r, System.Byte g, System.Byte b)
  System.Int32 GetControllerInformation(System.Int32 handle, Plugins.LibScePad.ScePadControllerInformation& info)
  System.Int32 ReadState(System.Int32 handle, Plugins.LibScePad.ScePadData& data)
  System.Int32 SetMotionSensorState(System.Int32 handle, System.Boolean enable)
  System.Int32 SetTiltCorrectionState(System.Int32 handle, System.Boolean enable)
  System.Int32 SetAngularVelocityDeadbandState(System.Int32 handle, System.Boolean enable)
  System.Int32 SetAngularVelocityBiasCorrectionState(System.Int32 handle, System.Boolean enable)
  System.Int32 ResetOrientation(System.Int32 handle)
  System.Int32 SetVibrationMode(System.Int32 handle, Plugins.LibScePad.ScePadVibrationMode mode)
  System.Int32 _InitWithBluetooth()
END_CLASS

CLASS: Trigger
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private   static  Plugins.LibScePad.ScePadTriggerEffectOffParamIternal.Command[]s_cachedOffEffectCmdArray  // 0x0
  private   static  Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal.Command[]s_cachedFeedBackEffectCmdArray  // 0x8
  private   static  Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal.Command[]s_cachedVibrationEffectCmdArray  // 0x10
  private   static  Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal.Command[]s_cachedWeaponEffectCmdArray  // 0x18
  private   static  Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal.Command[]s_cachedSlopeEffectCmdArray  // 0x20
  private   static  Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.Command[]s_cachedMulPosEffectCmdArray  // 0x28
  private   static  Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.Command[]s_cachedMulVibEffectCmdArray  // 0x30
METHODS:
  System.Int32 GetTriggerEffectStates(System.Int32 handle, Plugins.LibScePad.ScePadTriggerEffectState& l2, Plugins.LibScePad.ScePadTriggerEffectState& r2)
  System.Int32 SetTriggerEffectOff(System.Int32 handle, Plugins.LibScePad.TriggerMask mask)
  System.Int32 SetTriggerEffect(System.Int32 handle, Plugins.LibScePad.TriggerEffectCommandUnion command)
  System.Int32 _SetTriggerEffectFeedback(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerFeedbackEffect paramL2, Plugins.LibScePad.TriggerFeedbackEffect paramR2)
  System.Int32 _SetTriggerEffectVibration(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerVibrationEffect paramL2, Plugins.LibScePad.TriggerVibrationEffect paramR2)
  System.Int32 _SetTriggerEffectWeapon(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerWeaponEffect paramL2, Plugins.LibScePad.TriggerWeaponEffect paramR2)
  System.Int32 _SetTriggerEffectSlope(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerSlopeFeedbackEffect slopeL2, Plugins.LibScePad.TriggerSlopeFeedbackEffect slopeR2)
  System.Int32 _SetTriggerEffectMultiPosition(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerMultiPositionFeedbackEffect paramL2, Plugins.LibScePad.TriggerMultiPositionFeedbackEffect paramR2)
  System.Int32 _SetTriggerEffectMultiPositionVibration(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerMultiPositionVibrationEffect paramL2, Plugins.LibScePad.TriggerMultiPositionVibrationEffect paramR2)
  System.Void .cctor()
END_CLASS

CLASS: Command
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            Plugins.LibScePad.ScePadTriggerEffectModemode  // 0x10
  private           Plugins.LibScePad.ScePadTriggerEffectOffParamIternal.Command.<_>e__FixedBuffer_  // 0x14
METHODS:
END_CLASS

CLASS: Command
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            Plugins.LibScePad.ScePadTriggerEffectModemode  // 0x10
  private           Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal.Command.<_1>e__FixedBuffer_1  // 0x14
  public            System.Byte                     position  // 0x18
  public            System.Byte                     strength  // 0x19
  private           Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal.Command.<_2>e__FixedBuffer_2  // 0x1A
METHODS:
END_CLASS

CLASS: Command
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  public            Plugins.LibScePad.ScePadTriggerEffectModemode  // 0x10
  private           Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal.Command.<_1>e__FixedBuffer_1  // 0x14
  public            System.Byte                     startPosition  // 0x18
  public            System.Byte                     endPosition  // 0x19
  public            System.Byte                     strength  // 0x1A
  private           Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal.Command.<_2>e__FixedBuffer_2  // 0x1B
METHODS:
END_CLASS

CLASS: Command
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  public            Plugins.LibScePad.ScePadTriggerEffectModemode  // 0x10
  private           Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal.Command.<_1>e__FixedBuffer_1  // 0x14
  public            System.Byte                     position  // 0x18
  public            System.Byte                     amplitude  // 0x19
  public            System.Byte                     frequency  // 0x1A
  private           Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal.Command.<_2>e__FixedBuffer_2  // 0x1B
METHODS:
END_CLASS

CLASS: Command
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public            Plugins.LibScePad.ScePadTriggerEffectModemode  // 0x10
  private           Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal.Command.<_1>e__FixedBuffer_1  // 0x14
  public            System.Byte                     startPosition  // 0x18
  public            System.Byte                     endPosition  // 0x19
  public            System.Byte                     startStrength  // 0x1A
  public            System.Byte                     endStrength  // 0x1B
  private           Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal.Command.<_2>e__FixedBuffer_2  // 0x1C
METHODS:
END_CLASS

CLASS: Command
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  public            Plugins.LibScePad.ScePadTriggerEffectModemode  // 0x10
  private           Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.Command.<_1>e__FixedBuffer_1  // 0x14
  public            Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.Command.<strength>e__FixedBufferstrength  // 0x18
  private           Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.Command.<_2>e__FixedBuffer_2  // 0x22
METHODS:
END_CLASS

CLASS: Command
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
  public            Plugins.LibScePad.ScePadTriggerEffectModemode  // 0x10
  private           Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.Command.<_1>e__FixedBuffer_1  // 0x14
  public            System.Byte                     frequency  // 0x18
  public            Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.Command.<amplitude>e__FixedBufferamplitude  // 0x19
  private           Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.Command.<_2>e__FixedBuffer_2  // 0x23
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.LibScePad
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static  System.Boolean                  s_available  // 0x0
METHODS:
  System.Boolean get_available()
END_CLASS

CLASS: Plugins.LibScePad.ScePadType
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Plugins.LibScePad.ScePadType    SCE_PAD_PORT_TYPE_STANDARD  // 0x0
  public    static  Plugins.LibScePad.ScePadType    SCE_PAD_PORT_TYPE_SPECIAL  // 0x0
  public    static  Plugins.LibScePad.ScePadType    SCE_PAD_PORT_TYPE_REMOTE_CONTROL  // 0x0
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadSupportBusType
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Plugins.LibScePad.ScePadSupportBusTypeSCE_PAD_SUPPORT_BUS_TYPE_USB  // 0x0
  public    static  Plugins.LibScePad.ScePadSupportBusTypeSCE_PAD_SUPPORT_BUS_TYPE_USB_BT  // 0x0
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadVibrationMode
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Plugins.LibScePad.ScePadVibrationModeSCE_PAD_VIBRATION_MODE_ADVANCED  // 0x0
  public    static  Plugins.LibScePad.ScePadVibrationModeSCE_PAD_VIBRATION_MODE_COMPATIBLE  // 0x0
  public    static  Plugins.LibScePad.ScePadVibrationModeSCE_PAD_VIBRATION_MODE_COMPATIBLE2  // 0x0
  public    static  Plugins.LibScePad.ScePadVibrationModeSCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE  // 0x0
  public    static  Plugins.LibScePad.ScePadVibrationModeSCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE2  // 0x0
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadAudioOutPath
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Plugins.LibScePad.ScePadAudioOutPathSCE_PAD_AUDIO_OUT_PATH_STEREO_HEADSET  // 0x0
  public    static  Plugins.LibScePad.ScePadAudioOutPathSCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET  // 0x0
  public    static  Plugins.LibScePad.ScePadAudioOutPathSCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET_SPEAKER  // 0x0
  public    static  Plugins.LibScePad.ScePadAudioOutPathSCE_PAD_AUDIO_OUT_PATH_SPEAKER  // 0x0
  public    static  Plugins.LibScePad.ScePadAudioOutPathSCE_PAD_AUDIO_OUT_PATH_OFF  // 0x0
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadHeadsetType
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Plugins.LibScePad.ScePadHeadsetTypeSCE_PAD_HEADSET_TYPE_NONE  // 0x0
  public    static  Plugins.LibScePad.ScePadHeadsetTypeSCE_PAD_HEADSET_TYPE_HEADPHONE  // 0x0
  public    static  Plugins.LibScePad.ScePadHeadsetTypeSCE_PAD_HEADSET_TYPE_HEADSET  // 0x0
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTriggerEffectMode
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Plugins.LibScePad.ScePadTriggerEffectModeSCE_PAD_TRIGGER_EFFECT_MODE_OFF  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectModeSCE_PAD_TRIGGER_EFFECT_MODE_FEEDBACK  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectModeSCE_PAD_TRIGGER_EFFECT_MODE_WEAPON  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectModeSCE_PAD_TRIGGER_EFFECT_MODE_VIBRATION  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectModeSCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_FEEDBACK  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectModeSCE_PAD_TRIGGER_EFFECT_MODE_SLOPE_FEEDBACK  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectModeSCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_VIBRATION  // 0x0
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTriggerEffectState
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Plugins.LibScePad.ScePadTriggerEffectStateSCE_PAD_TRIGGER_EFFECT_STATE_OFF  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectStateSCE_PAD_TRIGGER_EFFECT_STATE_FEEDBACK_STANDBY  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectStateSCE_PAD_TRIGGER_EFFECT_STATE_FEEDBACK_ACTIVE  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectStateSCE_PAD_TRIGGER_EFFECT_STATE_WEAPON_STANDBY  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectStateSCE_PAD_TRIGGER_EFFECT_STATE_WEAPON_PULLING  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectStateSCE_PAD_TRIGGER_EFFECT_STATE_WEAPON_FIRED  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectStateSCE_PAD_TRIGGER_EFFECT_STATE_VIBRATION_STANDBY  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectStateSCE_PAD_TRIGGER_EFFECT_STATE_VIBRATION_ACTIVE  // 0x0
  public    static  Plugins.LibScePad.ScePadTriggerEffectStateSCE_PAD_TRIGGER_EFFECT_STATE_INTERCEPTED  // 0x0
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.TriggerMask
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Plugins.LibScePad.TriggerMask   NONE  // 0x0
  public    static  Plugins.LibScePad.TriggerMask   L2  // 0x0
  public    static  Plugins.LibScePad.TriggerMask   R2  // 0x0
  public    static  Plugins.LibScePad.TriggerMask   ALL  // 0x0
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.TriggerEffectCommandUnion
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            Plugins.LibScePad.TriggerFeedbackEffectfeedback  // 0x10
  public            Plugins.LibScePad.TriggerWeaponEffectweapon  // 0x10
  public            Plugins.LibScePad.TriggerVibrationEffectvibration  // 0x10
  public            Plugins.LibScePad.TriggerSlopeFeedbackEffectslopeFeedback  // 0x10
  public            Plugins.LibScePad.TriggerMultiPositionFeedbackEffectmultiPositionFeedback  // 0x10
  public            Plugins.LibScePad.TriggerMultiPositionVibrationEffectmultiPositionVibration  // 0x10
  public            Plugins.LibScePad.TriggerMask   mask  // 0x1B
  public            Plugins.LibScePad.ScePadTriggerEffectModemode  // 0x1C
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.TriggerFeedbackEffect
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Byte                     position  // 0x10
  public            System.Byte                     strength  // 0x11
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.TriggerWeaponEffect
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Byte                     startPosition  // 0x10
  public            System.Byte                     endPosition  // 0x11
  public            System.Byte                     strength  // 0x12
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.TriggerVibrationEffect
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.Byte                     position  // 0x10
  public            System.Byte                     amplitude  // 0x11
  public            System.Byte                     frequency  // 0x12
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.TriggerSlopeFeedbackEffect
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Byte                     startPosition  // 0x10
  public            System.Byte                     endPosition  // 0x11
  public            System.Byte                     startStrength  // 0x12
  public            System.Byte                     endStrength  // 0x13
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.TriggerMultiPositionFeedbackEffect
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Byte                     strength0  // 0x10
  public            System.Byte                     strength1  // 0x11
  public            System.Byte                     strength2  // 0x12
  public            System.Byte                     strength3  // 0x13
  public            System.Byte                     strength4  // 0x14
  public            System.Byte                     strength5  // 0x15
  public            System.Byte                     strength6  // 0x16
  public            System.Byte                     strength7  // 0x17
  public            System.Byte                     strength8  // 0x18
  public            System.Byte                     strength9  // 0x19
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.TriggerMultiPositionVibrationEffect
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Byte                     amplitude0  // 0x10
  public            System.Byte                     amplitude1  // 0x11
  public            System.Byte                     amplitude2  // 0x12
  public            System.Byte                     amplitude3  // 0x13
  public            System.Byte                     amplitude4  // 0x14
  public            System.Byte                     amplitude5  // 0x15
  public            System.Byte                     amplitude6  // 0x16
  public            System.Byte                     amplitude7  // 0x17
  public            System.Byte                     amplitude8  // 0x18
  public            System.Byte                     amplitude9  // 0x19
  public            System.Byte                     frequency  // 0x1A
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTouchPadInformation
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Single                   pixelDensity  // 0x10
  public            System.UInt16                   resolutionX  // 0x14
  public            System.UInt16                   resolutionY  // 0x16
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadStickInformation
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.Byte                     deadZoneLeft  // 0x10
  public            System.Byte                     deadZoneRight  // 0x11
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadAnalogStick
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Byte                     x  // 0x10
  public            System.Byte                     y  // 0x11
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadAnalogButtons
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.Byte                     l2  // 0x10
  public            System.Byte                     r2  // 0x11
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadData
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.UInt32                   buttons  // 0x10
  public            Plugins.LibScePad.ScePadAnalogStickleftStick  // 0x14
  public            Plugins.LibScePad.ScePadAnalogStickrightStick  // 0x16
  public            Plugins.LibScePad.ScePadAnalogButtonsanalogButtons  // 0x18
  public            UnityEngine.Quaternion          orientation  // 0x1C
  public            UnityEngine.Vector3             acceleration  // 0x2C
  public            UnityEngine.Vector3             angularVelocity  // 0x38
  public            System.Boolean                  connected  // 0x44
  public            System.UInt64                   timeStamp  // 0x48
  public            System.Byte                     connectedCount  // 0x50
METHODS:
  System.Void .ctor(Plugins.LibScePad.ScePadDataInternal data)
END_CLASS

CLASS: Plugins.LibScePad.ScePadControllerInformation
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            Plugins.LibScePad.ScePadTouchPadInformationtouchPadInfo  // 0x10
  public            Plugins.LibScePad.ScePadStickInformationstickInfo  // 0x18
  public            System.Byte                     connectionType  // 0x1A
  public            System.Byte                     connectionCount  // 0x1B
  public            System.Boolean                  connected  // 0x1C
METHODS:
  System.Void .ctor(Plugins.LibScePad.ScePadControllerInformationInternal info)
END_CLASS

CLASS: Plugins.LibScePad.LibScePadInvoke
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  private   static  System.String                   LibName  // 0x0
METHODS:
  System.Int32 IsSupportedAudioFunction(System.Int32 handle)
  System.Int32 SetAudioOutPath(System.Int32 handle, Plugins.LibScePad.ScePadAudioOutPath path)
  System.Int32 SetVolumeGain(System.Int32 handle, Plugins.LibScePad.ScePadVolumeGainInternal& gain)
  System.Int32 GetJackState(System.Int32 handle, Plugins.LibScePad.ScePadJackStateInternal& headSetType)
  System.Int32 Init()
  System.Int32 Init3_WindowsOnly(Plugins.LibScePad.ScePadInit3ParamInternal init3Param)
  System.Int32 Close(System.Int32 handle)
  System.Int32 Open(System.Int32 userId, Plugins.LibScePad.ScePadType type, System.Int32 index, System.IntPtr param)
  System.Int32 GetHandle(System.Int32 userId, Plugins.LibScePad.ScePadType type, System.Int32 index)
  System.Int32 ResetLightBar(System.Int32 handle)
  System.Int32 SetLightBar(System.Int32 handle, Plugins.LibScePad.ScePadColorInternal& color)
  System.Int32 ReadState(System.Int32 handle, Plugins.LibScePad.ScePadDataInternal& data)
  System.Int32 Read(System.Int32 handle, Plugins.LibScePad.ScePadDataInternal& data, System.Int32 num)
  System.Int32 GetControllerInformation(System.Int32 handle, Plugins.LibScePad.ScePadControllerInformationInternal& info)
  System.Int32 SetMotionSensorState(System.Int32 handle, System.Boolean enable)
  System.Int32 SetTiltCorrectionState(System.Int32 handle, System.Boolean enable)
  System.Int32 SetAngularVelocityDeadbandState(System.Int32 handle, System.Boolean enable)
  System.Int32 SetAngularVelocityBiasCorrectionState(System.Int32 handle, System.Boolean enable)
  System.Int32 ResetOrientation(System.Int32 handle)
  System.Int32 SetVibrationMode(System.Int32 handle, Plugins.LibScePad.ScePadVibrationMode mode)
  System.Int32 SetVibration(System.Int32 handle, Plugins.LibScePad.ScePadVibrationParamInternal& mode)
  System.Int32 GetTriggerEffectState(System.Int32 handle, Plugins.LibScePad.ScePadTriggerEffectStateInformationInternal& info)
  System.Int32 SetTriggerEffectOff(System.Int32 handle, Plugins.LibScePad.ScePadTriggerEffectOffParamIternal& param)
  System.Int32 SetTriggerEffectFeedback(System.Int32 handle, Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal& param)
  System.Int32 SetTriggerEffectVibration(System.Int32 handle, Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal& param)
  System.Int32 SetTriggerEffectWeapon(System.Int32 handle, Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal& param)
  System.Int32 SetTriggerEffectSlope(System.Int32 handle, Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal& param)
  System.Int32 SetTriggerEffectMultiPosition(System.Int32 handle, Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal& param)
  System.Int32 SetTriggerEffectMultiPositionVibration(System.Int32 handle, Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal& param)
END_CLASS

CLASS: Plugins.LibScePad.ScePadColorInternal
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Byte                     r  // 0x10
  public            System.Byte                     g  // 0x11
  public            System.Byte                     b  // 0x12
  public            System.Byte                     reserved  // 0x13
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadInit3ParamInternal
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.IntPtr                   allocFunc  // 0x10
  public            System.IntPtr                   freeFunc  // 0x18
  public            Plugins.LibScePad.ScePadSupportBusTypesupportBusType  // 0x20
  private           Plugins.LibScePad.ScePadInit3ParamInternal.<reserve>e__FixedBufferreserve  // 0x24
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadDataInternal
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.UInt32                   buttons  // 0x10
  public            Plugins.LibScePad.ScePadAnalogStickleftStick  // 0x14
  public            Plugins.LibScePad.ScePadAnalogStickrightStick  // 0x16
  public            Plugins.LibScePad.ScePadAnalogButtonsInternalanalogButtons  // 0x18
  public            Plugins.LibScePad.SceFQuaternionInternalorientation  // 0x1C
  public            Plugins.LibScePad.SceFVector3Internalacceleration  // 0x2C
  public            Plugins.LibScePad.SceFVector3InternalangularVelocity  // 0x38
  public            Plugins.LibScePad.ScePadTouchDataInternaltouchData  // 0x44
  public            System.Boolean                  connected  // 0x5C
  public            System.UInt64                   timestamp  // 0x60
  public            Plugins.LibScePad.ScePadExtensionUnitDataInternalextennsionnUnitData  // 0x68
  public            System.Byte                     connectedCount  // 0x78
  private           Plugins.LibScePad.ScePadDataInternal.<reserve>e__FixedBufferreserve  // 0x79
  public            System.Byte                     deviceUniqueDataLen  // 0x7B
  public            Plugins.LibScePad.ScePadDataInternal.<deviceUniqueData>e__FixedBufferdeviceUniqueData  // 0x7C
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadControllerInformationInternal
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  public            Plugins.LibScePad.ScePadTouchPadInformationtouchPadInfo  // 0x10
  public            Plugins.LibScePad.ScePadStickInformationstickInfo  // 0x18
  public            System.Byte                     connectionType  // 0x1A
  public            System.Byte                     connectionCount  // 0x1B
  public            System.Boolean                  connected  // 0x1C
  private           Plugins.LibScePad.ScePadControllerInformationInternal.<_>e__FixedBuffer_  // 0x1D
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadVibrationParamInternal
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  public            System.Byte                     largeMotor  // 0x10
  public            System.Byte                     smallMotor  // 0x11
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadAnalogButtonsInternal
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Byte                     l2  // 0x10
  public            System.Byte                     r2  // 0x11
  private           Plugins.LibScePad.ScePadAnalogButtonsInternal.<_>e__FixedBuffer_  // 0x12
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTouchDataInternal
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Byte                     touchNum  // 0x10
  private           Plugins.LibScePad.ScePadTouchDataInternal.<reserve>e__FixedBufferreserve  // 0x11
  private           System.UInt32                   reserve1  // 0x14
  public            Plugins.LibScePad.ScePadTouchInternaltouch1  // 0x18
  public            Plugins.LibScePad.ScePadTouchInternaltouch2  // 0x20
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTouchInternal
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.UInt16                   x  // 0x10
  public            System.UInt16                   y  // 0x12
  public            System.Byte                     id  // 0x14
  private           Plugins.LibScePad.ScePadTouchInternal.<reserve>e__FixedBufferreserve  // 0x15
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadOpenParamInternal
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            Plugins.LibScePad.ScePadOpenParamInternal.<reserve>e__FixedBufferreserve  // 0x10
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadExtensionUnitDataInternal
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.UInt32                   extensionUnitId  // 0x10
  private           Plugins.LibScePad.ScePadExtensionUnitDataInternal.<reserve>e__FixedBufferreserve  // 0x14
  public            System.Byte                     dateLength  // 0x15
  public            Plugins.LibScePad.ScePadExtensionUnitDataInternal.<data>e__FixedBufferdata  // 0x16
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadVolumeGainInternal
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Byte                     speakerVol  // 0x10
  public            System.Byte                     jackVol  // 0x11
  private           System.Byte                     reserved  // 0x12
  public            System.Byte                     micGain  // 0x13
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadJackStateInternal
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            Plugins.LibScePad.ScePadHeadsetTypeheadsetType  // 0x10
  private           Plugins.LibScePad.ScePadJackStateInternal.<reserve>e__FixedBufferreserve  // 0x14
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.SceFVector3Internal
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   z  // 0x18
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.SceFQuaternionInternal
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   z  // 0x18
  public            System.Single                   w  // 0x1C
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTriggerEffectOffParamIternal
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Byte                     triggerMask  // 0x10
  private           Plugins.LibScePad.ScePadTriggerEffectOffParamIternal.<_>e__FixedBuffer_  // 0x11
  public            Plugins.LibScePad.ScePadTriggerEffectOffParamIternal.Command[]command  // 0x18
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            System.Byte                     triggerMask  // 0x10
  private           Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal.<_>e__FixedBuffer_  // 0x11
  public            Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal.Command[]command  // 0x18
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            System.Byte                     triggerMask  // 0x10
  private           Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal.<_>e__FixedBuffer_  // 0x11
  public            Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal.Command[]command  // 0x18
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            System.Byte                     triggerMask  // 0x10
  private           Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal.<_>e__FixedBuffer_  // 0x11
  public            Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal.Command[]command  // 0x18
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            System.Byte                     triggerMask  // 0x10
  public            Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal.<_>e__FixedBuffer_  // 0x11
  public            Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal.Command[]command  // 0x18
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            System.Byte                     triggerMask  // 0x10
  public            Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.<_>e__FixedBuffer_  // 0x11
  public            Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.Command[]command  // 0x18
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            System.Byte                     triggerMask  // 0x10
  public            Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.<_>e__FixedBuffer_  // 0x11
  public            Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.Command[]command  // 0x18
METHODS:
END_CLASS

CLASS: Plugins.LibScePad.ScePadTriggerEffectStateInformationInternal
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public            Plugins.LibScePad.ScePadTriggerEffectStateInformationInternal.<state>e__FixedBufferstate  // 0x10
METHODS:
END_CLASS

