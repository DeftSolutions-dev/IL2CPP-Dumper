// ========================================================
// Dumped by @desirepro
// Assembly: LibScePad.Runtime.dll
// Classes:  90
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000003
    public class Audio
    {
        // Methods
        private System.Int32 IsSupportAudioFunction(System.Int32 handle) { }
        private System.Int32 SetAudioOutPath(System.Int32 handle, Plugins.LibScePad.ScePadAudioOutPath path) { }
        private System.Int32 SetVolumeGain(System.Int32 handle, System.Byte speakerVol, System.Byte jackVol, System.Byte micGain) { }
        private Plugins.LibScePad.ScePadHeadsetType GetHeadSetType(System.Int32 handle) { }

    }

    // TypeToken: 0x2000004
    public class Basic
    {
        // Methods
        private System.Int32 Init() { }
        private System.Int32 GetOrOpen(System.Int32 userId, Plugins.LibScePad.ScePadType type) { }
        private System.Int32 GetHandle(System.Int32 userId, Plugins.LibScePad.ScePadType type) { }
        private System.Int32 Close(System.Int32 handle) { }
        private System.Int32 ResetLightBar(System.Int32 handle) { }
        private System.Int32 SetLightBar(System.Int32 handle, UnityEngine.Color color) { }
        private System.Int32 SetLightBar(System.Int32 handle, System.Byte r, System.Byte g, System.Byte b) { }
        private System.Int32 GetControllerInformation(System.Int32 handle, Plugins.LibScePad.ScePadControllerInformation& info) { }
        private System.Int32 ReadState(System.Int32 handle, Plugins.LibScePad.ScePadData& data) { }
        private System.Int32 SetMotionSensorState(System.Int32 handle, System.Boolean enable) { }
        private System.Int32 SetTiltCorrectionState(System.Int32 handle, System.Boolean enable) { }
        private System.Int32 SetAngularVelocityDeadbandState(System.Int32 handle, System.Boolean enable) { }
        private System.Int32 SetAngularVelocityBiasCorrectionState(System.Int32 handle, System.Boolean enable) { }
        private System.Int32 ResetOrientation(System.Int32 handle) { }
        private System.Int32 SetVibrationMode(System.Int32 handle, Plugins.LibScePad.ScePadVibrationMode mode) { }
        private System.Int32 _InitWithBluetooth() { }

    }

    // TypeToken: 0x2000005
    public class Trigger
    {
        // Fields
        private static Plugins.LibScePad.ScePadTriggerEffectOffParamIternal.Command[] s_cachedOffEffectCmdArray;        // 0x0
        private static Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal.Command[] s_cachedFeedBackEffectCmdArray;        // 0x8
        private static Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal.Command[] s_cachedVibrationEffectCmdArray;        // 0x10
        private static Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal.Command[] s_cachedWeaponEffectCmdArray;        // 0x18
        private static Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal.Command[] s_cachedSlopeEffectCmdArray;        // 0x20
        private static Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.Command[] s_cachedMulPosEffectCmdArray;        // 0x28
        private static Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.Command[] s_cachedMulVibEffectCmdArray;        // 0x30

        // Methods
        private System.Int32 GetTriggerEffectStates(System.Int32 handle, Plugins.LibScePad.ScePadTriggerEffectState& l2, Plugins.LibScePad.ScePadTriggerEffectState& r2) { }
        private System.Int32 SetTriggerEffectOff(System.Int32 handle, Plugins.LibScePad.TriggerMask mask) { }
        private System.Int32 SetTriggerEffect(System.Int32 handle, Plugins.LibScePad.TriggerEffectCommandUnion command) { }
        private System.Int32 _SetTriggerEffectFeedback(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerFeedbackEffect paramL2, Plugins.LibScePad.TriggerFeedbackEffect paramR2) { }
        private System.Int32 _SetTriggerEffectVibration(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerVibrationEffect paramL2, Plugins.LibScePad.TriggerVibrationEffect paramR2) { }
        private System.Int32 _SetTriggerEffectWeapon(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerWeaponEffect paramL2, Plugins.LibScePad.TriggerWeaponEffect paramR2) { }
        private System.Int32 _SetTriggerEffectSlope(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerSlopeFeedbackEffect slopeL2, Plugins.LibScePad.TriggerSlopeFeedbackEffect slopeR2) { }
        private System.Int32 _SetTriggerEffectMultiPosition(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerMultiPositionFeedbackEffect paramL2, Plugins.LibScePad.TriggerMultiPositionFeedbackEffect paramR2) { }
        private System.Int32 _SetTriggerEffectMultiPositionVibration(System.Int32 handle, Plugins.LibScePad.TriggerMask mask, Plugins.LibScePad.TriggerMultiPositionVibrationEffect paramL2, Plugins.LibScePad.TriggerMultiPositionVibrationEffect paramR2) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000036
    public struct Command
    {
        // Fields
        public Plugins.LibScePad.ScePadTriggerEffectMode mode;        // 0x10
        private Plugins.LibScePad.ScePadTriggerEffectOffParamIternal.Command.<_>e__FixedBuffer _;        // 0x14

    }

    // TypeToken: 0x200003A
    public struct Command
    {
        // Fields
        public Plugins.LibScePad.ScePadTriggerEffectMode mode;        // 0x10
        private Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal.Command.<_1>e__FixedBuffer _1;        // 0x14
        public System.Byte position;        // 0x18
        public System.Byte strength;        // 0x19
        private Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal.Command.<_2>e__FixedBuffer _2;        // 0x1A

    }

    // TypeToken: 0x200003F
    public struct Command
    {
        // Fields
        public Plugins.LibScePad.ScePadTriggerEffectMode mode;        // 0x10
        private Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal.Command.<_1>e__FixedBuffer _1;        // 0x14
        public System.Byte startPosition;        // 0x18
        public System.Byte endPosition;        // 0x19
        public System.Byte strength;        // 0x1A
        private Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal.Command.<_2>e__FixedBuffer _2;        // 0x1B

    }

    // TypeToken: 0x2000044
    public struct Command
    {
        // Fields
        public Plugins.LibScePad.ScePadTriggerEffectMode mode;        // 0x10
        private Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal.Command.<_1>e__FixedBuffer _1;        // 0x14
        public System.Byte position;        // 0x18
        public System.Byte amplitude;        // 0x19
        public System.Byte frequency;        // 0x1A
        private Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal.Command.<_2>e__FixedBuffer _2;        // 0x1B

    }

    // TypeToken: 0x2000049
    public struct Command
    {
        // Fields
        public Plugins.LibScePad.ScePadTriggerEffectMode mode;        // 0x10
        private Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal.Command.<_1>e__FixedBuffer _1;        // 0x14
        public System.Byte startPosition;        // 0x18
        public System.Byte endPosition;        // 0x19
        public System.Byte startStrength;        // 0x1A
        public System.Byte endStrength;        // 0x1B
        private Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal.Command.<_2>e__FixedBuffer _2;        // 0x1C

    }

    // TypeToken: 0x200004E
    public struct Command
    {
        // Fields
        public Plugins.LibScePad.ScePadTriggerEffectMode mode;        // 0x10
        private Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.Command.<_1>e__FixedBuffer _1;        // 0x14
        public Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.Command.<strength>e__FixedBuffer strength;        // 0x18
        private Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.Command.<_2>e__FixedBuffer _2;        // 0x22

    }

    // TypeToken: 0x2000054
    public struct Command
    {
        // Fields
        public Plugins.LibScePad.ScePadTriggerEffectMode mode;        // 0x10
        private Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.Command.<_1>e__FixedBuffer _1;        // 0x14
        public System.Byte frequency;        // 0x18
        public Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.Command.<amplitude>e__FixedBuffer amplitude;        // 0x19
        private Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.Command.<_2>e__FixedBuffer _2;        // 0x23

    }

namespace Plugins.LibScePad
{

    // TypeToken: 0x2000002
    public class LibScePad
    {
        // Fields
        private static System.Boolean s_available;        // 0x0

        // Methods
        private System.Boolean get_available() { }

    }

    // TypeToken: 0x2000006
    public struct ScePadType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Plugins.LibScePad.ScePadType SCE_PAD_PORT_TYPE_STANDARD;        // 0x0
        public static Plugins.LibScePad.ScePadType SCE_PAD_PORT_TYPE_SPECIAL;        // 0x0
        public static Plugins.LibScePad.ScePadType SCE_PAD_PORT_TYPE_REMOTE_CONTROL;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct ScePadSupportBusType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Plugins.LibScePad.ScePadSupportBusType SCE_PAD_SUPPORT_BUS_TYPE_USB;        // 0x0
        public static Plugins.LibScePad.ScePadSupportBusType SCE_PAD_SUPPORT_BUS_TYPE_USB_BT;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct ScePadVibrationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Plugins.LibScePad.ScePadVibrationMode SCE_PAD_VIBRATION_MODE_ADVANCED;        // 0x0
        public static Plugins.LibScePad.ScePadVibrationMode SCE_PAD_VIBRATION_MODE_COMPATIBLE;        // 0x0
        public static Plugins.LibScePad.ScePadVibrationMode SCE_PAD_VIBRATION_MODE_COMPATIBLE2;        // 0x0
        public static Plugins.LibScePad.ScePadVibrationMode SCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE;        // 0x0
        public static Plugins.LibScePad.ScePadVibrationMode SCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE2;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct ScePadAudioOutPath
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Plugins.LibScePad.ScePadAudioOutPath SCE_PAD_AUDIO_OUT_PATH_STEREO_HEADSET;        // 0x0
        public static Plugins.LibScePad.ScePadAudioOutPath SCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET;        // 0x0
        public static Plugins.LibScePad.ScePadAudioOutPath SCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET_SPEAKER;        // 0x0
        public static Plugins.LibScePad.ScePadAudioOutPath SCE_PAD_AUDIO_OUT_PATH_SPEAKER;        // 0x0
        public static Plugins.LibScePad.ScePadAudioOutPath SCE_PAD_AUDIO_OUT_PATH_OFF;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct ScePadHeadsetType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Plugins.LibScePad.ScePadHeadsetType SCE_PAD_HEADSET_TYPE_NONE;        // 0x0
        public static Plugins.LibScePad.ScePadHeadsetType SCE_PAD_HEADSET_TYPE_HEADPHONE;        // 0x0
        public static Plugins.LibScePad.ScePadHeadsetType SCE_PAD_HEADSET_TYPE_HEADSET;        // 0x0

    }

    // TypeToken: 0x200000B
    public struct ScePadTriggerEffectMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Plugins.LibScePad.ScePadTriggerEffectMode SCE_PAD_TRIGGER_EFFECT_MODE_OFF;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectMode SCE_PAD_TRIGGER_EFFECT_MODE_FEEDBACK;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectMode SCE_PAD_TRIGGER_EFFECT_MODE_WEAPON;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectMode SCE_PAD_TRIGGER_EFFECT_MODE_VIBRATION;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectMode SCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_FEEDBACK;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectMode SCE_PAD_TRIGGER_EFFECT_MODE_SLOPE_FEEDBACK;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectMode SCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_VIBRATION;        // 0x0

    }

    // TypeToken: 0x200000C
    public struct ScePadTriggerEffectState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Plugins.LibScePad.ScePadTriggerEffectState SCE_PAD_TRIGGER_EFFECT_STATE_OFF;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectState SCE_PAD_TRIGGER_EFFECT_STATE_FEEDBACK_STANDBY;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectState SCE_PAD_TRIGGER_EFFECT_STATE_FEEDBACK_ACTIVE;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectState SCE_PAD_TRIGGER_EFFECT_STATE_WEAPON_STANDBY;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectState SCE_PAD_TRIGGER_EFFECT_STATE_WEAPON_PULLING;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectState SCE_PAD_TRIGGER_EFFECT_STATE_WEAPON_FIRED;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectState SCE_PAD_TRIGGER_EFFECT_STATE_VIBRATION_STANDBY;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectState SCE_PAD_TRIGGER_EFFECT_STATE_VIBRATION_ACTIVE;        // 0x0
        public static Plugins.LibScePad.ScePadTriggerEffectState SCE_PAD_TRIGGER_EFFECT_STATE_INTERCEPTED;        // 0x0

    }

    // TypeToken: 0x200000D
    public struct TriggerMask
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Plugins.LibScePad.TriggerMask NONE;        // 0x0
        public static Plugins.LibScePad.TriggerMask L2;        // 0x0
        public static Plugins.LibScePad.TriggerMask R2;        // 0x0
        public static Plugins.LibScePad.TriggerMask ALL;        // 0x0

    }

    // TypeToken: 0x200000E
    public struct TriggerEffectCommandUnion
    {
        // Fields
        public Plugins.LibScePad.TriggerFeedbackEffect feedback;        // 0x10
        public Plugins.LibScePad.TriggerWeaponEffect weapon;        // 0x10
        public Plugins.LibScePad.TriggerVibrationEffect vibration;        // 0x10
        public Plugins.LibScePad.TriggerSlopeFeedbackEffect slopeFeedback;        // 0x10
        public Plugins.LibScePad.TriggerMultiPositionFeedbackEffect multiPositionFeedback;        // 0x10
        public Plugins.LibScePad.TriggerMultiPositionVibrationEffect multiPositionVibration;        // 0x10
        public Plugins.LibScePad.TriggerMask mask;        // 0x1B
        public Plugins.LibScePad.ScePadTriggerEffectMode mode;        // 0x1C

    }

    // TypeToken: 0x200000F
    public struct TriggerFeedbackEffect
    {
        // Fields
        public System.Byte position;        // 0x10
        public System.Byte strength;        // 0x11

    }

    // TypeToken: 0x2000010
    public struct TriggerWeaponEffect
    {
        // Fields
        public System.Byte startPosition;        // 0x10
        public System.Byte endPosition;        // 0x11
        public System.Byte strength;        // 0x12

    }

    // TypeToken: 0x2000011
    public struct TriggerVibrationEffect
    {
        // Fields
        public System.Byte position;        // 0x10
        public System.Byte amplitude;        // 0x11
        public System.Byte frequency;        // 0x12

    }

    // TypeToken: 0x2000012
    public struct TriggerSlopeFeedbackEffect
    {
        // Fields
        public System.Byte startPosition;        // 0x10
        public System.Byte endPosition;        // 0x11
        public System.Byte startStrength;        // 0x12
        public System.Byte endStrength;        // 0x13

    }

    // TypeToken: 0x2000013
    public struct TriggerMultiPositionFeedbackEffect
    {
        // Fields
        public System.Byte strength0;        // 0x10
        public System.Byte strength1;        // 0x11
        public System.Byte strength2;        // 0x12
        public System.Byte strength3;        // 0x13
        public System.Byte strength4;        // 0x14
        public System.Byte strength5;        // 0x15
        public System.Byte strength6;        // 0x16
        public System.Byte strength7;        // 0x17
        public System.Byte strength8;        // 0x18
        public System.Byte strength9;        // 0x19

    }

    // TypeToken: 0x2000014
    public struct TriggerMultiPositionVibrationEffect
    {
        // Fields
        public System.Byte amplitude0;        // 0x10
        public System.Byte amplitude1;        // 0x11
        public System.Byte amplitude2;        // 0x12
        public System.Byte amplitude3;        // 0x13
        public System.Byte amplitude4;        // 0x14
        public System.Byte amplitude5;        // 0x15
        public System.Byte amplitude6;        // 0x16
        public System.Byte amplitude7;        // 0x17
        public System.Byte amplitude8;        // 0x18
        public System.Byte amplitude9;        // 0x19
        public System.Byte frequency;        // 0x1A

    }

    // TypeToken: 0x2000015
    public struct ScePadTouchPadInformation
    {
        // Fields
        public System.Single pixelDensity;        // 0x10
        public System.UInt16 resolutionX;        // 0x14
        public System.UInt16 resolutionY;        // 0x16

    }

    // TypeToken: 0x2000016
    public struct ScePadStickInformation
    {
        // Fields
        public System.Byte deadZoneLeft;        // 0x10
        public System.Byte deadZoneRight;        // 0x11

    }

    // TypeToken: 0x2000017
    public struct ScePadAnalogStick
    {
        // Fields
        public System.Byte x;        // 0x10
        public System.Byte y;        // 0x11

    }

    // TypeToken: 0x2000018
    public struct ScePadAnalogButtons
    {
        // Fields
        public System.Byte l2;        // 0x10
        public System.Byte r2;        // 0x11

    }

    // TypeToken: 0x2000019
    public struct ScePadData
    {
        // Fields
        public System.UInt32 buttons;        // 0x10
        public Plugins.LibScePad.ScePadAnalogStick leftStick;        // 0x14
        public Plugins.LibScePad.ScePadAnalogStick rightStick;        // 0x16
        public Plugins.LibScePad.ScePadAnalogButtons analogButtons;        // 0x18
        public UnityEngine.Quaternion orientation;        // 0x1C
        public UnityEngine.Vector3 acceleration;        // 0x2C
        public UnityEngine.Vector3 angularVelocity;        // 0x38
        public System.Boolean connected;        // 0x44
        public System.UInt64 timeStamp;        // 0x48
        public System.Byte connectedCount;        // 0x50

        // Methods
        private System.Void .ctor(Plugins.LibScePad.ScePadDataInternal data) { }

    }

    // TypeToken: 0x200001A
    public struct ScePadControllerInformation
    {
        // Fields
        public Plugins.LibScePad.ScePadTouchPadInformation touchPadInfo;        // 0x10
        public Plugins.LibScePad.ScePadStickInformation stickInfo;        // 0x18
        public System.Byte connectionType;        // 0x1A
        public System.Byte connectionCount;        // 0x1B
        public System.Boolean connected;        // 0x1C

        // Methods
        private System.Void .ctor(Plugins.LibScePad.ScePadControllerInformationInternal info) { }

    }

    // TypeToken: 0x200001B
    public class LibScePadInvoke
    {
        // Fields
        private static System.String LibName;        // 0x0

        // Methods
        private System.Int32 IsSupportedAudioFunction(System.Int32 handle) { }
        private System.Int32 SetAudioOutPath(System.Int32 handle, Plugins.LibScePad.ScePadAudioOutPath path) { }
        private System.Int32 SetVolumeGain(System.Int32 handle, Plugins.LibScePad.ScePadVolumeGainInternal& gain) { }
        private System.Int32 GetJackState(System.Int32 handle, Plugins.LibScePad.ScePadJackStateInternal& headSetType) { }
        private System.Int32 Init() { }
        private System.Int32 Init3_WindowsOnly(Plugins.LibScePad.ScePadInit3ParamInternal init3Param) { }
        private System.Int32 Close(System.Int32 handle) { }
        private System.Int32 Open(System.Int32 userId, Plugins.LibScePad.ScePadType type, System.Int32 index, System.IntPtr param) { }
        private System.Int32 GetHandle(System.Int32 userId, Plugins.LibScePad.ScePadType type, System.Int32 index) { }
        private System.Int32 ResetLightBar(System.Int32 handle) { }
        private System.Int32 SetLightBar(System.Int32 handle, Plugins.LibScePad.ScePadColorInternal& color) { }
        private System.Int32 ReadState(System.Int32 handle, Plugins.LibScePad.ScePadDataInternal& data) { }
        private System.Int32 Read(System.Int32 handle, Plugins.LibScePad.ScePadDataInternal& data, System.Int32 num) { }
        private System.Int32 GetControllerInformation(System.Int32 handle, Plugins.LibScePad.ScePadControllerInformationInternal& info) { }
        private System.Int32 SetMotionSensorState(System.Int32 handle, System.Boolean enable) { }
        private System.Int32 SetTiltCorrectionState(System.Int32 handle, System.Boolean enable) { }
        private System.Int32 SetAngularVelocityDeadbandState(System.Int32 handle, System.Boolean enable) { }
        private System.Int32 SetAngularVelocityBiasCorrectionState(System.Int32 handle, System.Boolean enable) { }
        private System.Int32 ResetOrientation(System.Int32 handle) { }
        private System.Int32 SetVibrationMode(System.Int32 handle, Plugins.LibScePad.ScePadVibrationMode mode) { }
        private System.Int32 SetVibration(System.Int32 handle, Plugins.LibScePad.ScePadVibrationParamInternal& mode) { }
        private System.Int32 GetTriggerEffectState(System.Int32 handle, Plugins.LibScePad.ScePadTriggerEffectStateInformationInternal& info) { }
        private System.Int32 SetTriggerEffectOff(System.Int32 handle, Plugins.LibScePad.ScePadTriggerEffectOffParamIternal& param) { }
        private System.Int32 SetTriggerEffectFeedback(System.Int32 handle, Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal& param) { }
        private System.Int32 SetTriggerEffectVibration(System.Int32 handle, Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal& param) { }
        private System.Int32 SetTriggerEffectWeapon(System.Int32 handle, Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal& param) { }
        private System.Int32 SetTriggerEffectSlope(System.Int32 handle, Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal& param) { }
        private System.Int32 SetTriggerEffectMultiPosition(System.Int32 handle, Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal& param) { }
        private System.Int32 SetTriggerEffectMultiPositionVibration(System.Int32 handle, Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal& param) { }

    }

    // TypeToken: 0x200001C
    public struct ScePadColorInternal
    {
        // Fields
        public System.Byte r;        // 0x10
        public System.Byte g;        // 0x11
        public System.Byte b;        // 0x12
        public System.Byte reserved;        // 0x13

    }

    // TypeToken: 0x200001D
    public struct ScePadInit3ParamInternal
    {
        // Fields
        public System.IntPtr allocFunc;        // 0x10
        public System.IntPtr freeFunc;        // 0x18
        public Plugins.LibScePad.ScePadSupportBusType supportBusType;        // 0x20
        private Plugins.LibScePad.ScePadInit3ParamInternal.<reserve>e__FixedBuffer reserve;        // 0x24

    }

    // TypeToken: 0x200001F
    public struct ScePadDataInternal
    {
        // Fields
        public System.UInt32 buttons;        // 0x10
        public Plugins.LibScePad.ScePadAnalogStick leftStick;        // 0x14
        public Plugins.LibScePad.ScePadAnalogStick rightStick;        // 0x16
        public Plugins.LibScePad.ScePadAnalogButtonsInternal analogButtons;        // 0x18
        public Plugins.LibScePad.SceFQuaternionInternal orientation;        // 0x1C
        public Plugins.LibScePad.SceFVector3Internal acceleration;        // 0x2C
        public Plugins.LibScePad.SceFVector3Internal angularVelocity;        // 0x38
        public Plugins.LibScePad.ScePadTouchDataInternal touchData;        // 0x44
        public System.Boolean connected;        // 0x5C
        public System.UInt64 timestamp;        // 0x60
        public Plugins.LibScePad.ScePadExtensionUnitDataInternal extennsionnUnitData;        // 0x68
        public System.Byte connectedCount;        // 0x78
        private Plugins.LibScePad.ScePadDataInternal.<reserve>e__FixedBuffer reserve;        // 0x79
        public System.Byte deviceUniqueDataLen;        // 0x7B
        public Plugins.LibScePad.ScePadDataInternal.<deviceUniqueData>e__FixedBuffer deviceUniqueData;        // 0x7C

    }

    // TypeToken: 0x2000022
    public struct ScePadControllerInformationInternal
    {
        // Fields
        public Plugins.LibScePad.ScePadTouchPadInformation touchPadInfo;        // 0x10
        public Plugins.LibScePad.ScePadStickInformation stickInfo;        // 0x18
        public System.Byte connectionType;        // 0x1A
        public System.Byte connectionCount;        // 0x1B
        public System.Boolean connected;        // 0x1C
        private Plugins.LibScePad.ScePadControllerInformationInternal.<_>e__FixedBuffer _;        // 0x1D

    }

    // TypeToken: 0x2000024
    public struct ScePadVibrationParamInternal
    {
        // Fields
        public System.Byte largeMotor;        // 0x10
        public System.Byte smallMotor;        // 0x11

    }

    // TypeToken: 0x2000025
    public struct ScePadAnalogButtonsInternal
    {
        // Fields
        public System.Byte l2;        // 0x10
        public System.Byte r2;        // 0x11
        private Plugins.LibScePad.ScePadAnalogButtonsInternal.<_>e__FixedBuffer _;        // 0x12

    }

    // TypeToken: 0x2000027
    public struct ScePadTouchDataInternal
    {
        // Fields
        public System.Byte touchNum;        // 0x10
        private Plugins.LibScePad.ScePadTouchDataInternal.<reserve>e__FixedBuffer reserve;        // 0x11
        private System.UInt32 reserve1;        // 0x14
        public Plugins.LibScePad.ScePadTouchInternal touch1;        // 0x18
        public Plugins.LibScePad.ScePadTouchInternal touch2;        // 0x20

    }

    // TypeToken: 0x2000029
    public struct ScePadTouchInternal
    {
        // Fields
        public System.UInt16 x;        // 0x10
        public System.UInt16 y;        // 0x12
        public System.Byte id;        // 0x14
        private Plugins.LibScePad.ScePadTouchInternal.<reserve>e__FixedBuffer reserve;        // 0x15

    }

    // TypeToken: 0x200002B
    public struct ScePadOpenParamInternal
    {
        // Fields
        public Plugins.LibScePad.ScePadOpenParamInternal.<reserve>e__FixedBuffer reserve;        // 0x10

    }

    // TypeToken: 0x200002D
    public struct ScePadExtensionUnitDataInternal
    {
        // Fields
        public System.UInt32 extensionUnitId;        // 0x10
        private Plugins.LibScePad.ScePadExtensionUnitDataInternal.<reserve>e__FixedBuffer reserve;        // 0x14
        public System.Byte dateLength;        // 0x15
        public Plugins.LibScePad.ScePadExtensionUnitDataInternal.<data>e__FixedBuffer data;        // 0x16

    }

    // TypeToken: 0x2000030
    public struct ScePadVolumeGainInternal
    {
        // Fields
        public System.Byte speakerVol;        // 0x10
        public System.Byte jackVol;        // 0x11
        private System.Byte reserved;        // 0x12
        public System.Byte micGain;        // 0x13

    }

    // TypeToken: 0x2000031
    public struct ScePadJackStateInternal
    {
        // Fields
        public Plugins.LibScePad.ScePadHeadsetType headsetType;        // 0x10
        private Plugins.LibScePad.ScePadJackStateInternal.<reserve>e__FixedBuffer reserve;        // 0x14

    }

    // TypeToken: 0x2000033
    public struct SceFVector3Internal
    {
        // Fields
        public System.Single x;        // 0x10
        public System.Single y;        // 0x14
        public System.Single z;        // 0x18

    }

    // TypeToken: 0x2000034
    public struct SceFQuaternionInternal
    {
        // Fields
        public System.Single x;        // 0x10
        public System.Single y;        // 0x14
        public System.Single z;        // 0x18
        public System.Single w;        // 0x1C

    }

    // TypeToken: 0x2000035
    public struct ScePadTriggerEffectOffParamIternal
    {
        // Fields
        public System.Byte triggerMask;        // 0x10
        private Plugins.LibScePad.ScePadTriggerEffectOffParamIternal.<_>e__FixedBuffer _;        // 0x11
        public Plugins.LibScePad.ScePadTriggerEffectOffParamIternal.Command[] command;        // 0x18

    }

    // TypeToken: 0x2000039
    public struct ScePadTriggerFeedbackEffectParamInternal
    {
        // Fields
        public System.Byte triggerMask;        // 0x10
        private Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal.<_>e__FixedBuffer _;        // 0x11
        public Plugins.LibScePad.ScePadTriggerFeedbackEffectParamInternal.Command[] command;        // 0x18

    }

    // TypeToken: 0x200003E
    public struct ScePadTriggerWeaponEffectParamInternal
    {
        // Fields
        public System.Byte triggerMask;        // 0x10
        private Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal.<_>e__FixedBuffer _;        // 0x11
        public Plugins.LibScePad.ScePadTriggerWeaponEffectParamInternal.Command[] command;        // 0x18

    }

    // TypeToken: 0x2000043
    public struct ScePadTriggerVibrationEffectParamInternal
    {
        // Fields
        public System.Byte triggerMask;        // 0x10
        private Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal.<_>e__FixedBuffer _;        // 0x11
        public Plugins.LibScePad.ScePadTriggerVibrationEffectParamInternal.Command[] command;        // 0x18

    }

    // TypeToken: 0x2000048
    public struct ScePadTriggerSlopeFeedbackEffectParamInternal
    {
        // Fields
        public System.Byte triggerMask;        // 0x10
        public Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal.<_>e__FixedBuffer _;        // 0x11
        public Plugins.LibScePad.ScePadTriggerSlopeFeedbackEffectParamInternal.Command[] command;        // 0x18

    }

    // TypeToken: 0x200004D
    public struct ScePadTriggerMultiPositionFeedbackEffectParamInternal
    {
        // Fields
        public System.Byte triggerMask;        // 0x10
        public Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.<_>e__FixedBuffer _;        // 0x11
        public Plugins.LibScePad.ScePadTriggerMultiPositionFeedbackEffectParamInternal.Command[] command;        // 0x18

    }

    // TypeToken: 0x2000053
    public struct ScePadTriggerMultiPositionVibrationEffectParamInternal
    {
        // Fields
        public System.Byte triggerMask;        // 0x10
        public Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.<_>e__FixedBuffer _;        // 0x11
        public Plugins.LibScePad.ScePadTriggerMultiPositionVibrationEffectParamInternal.Command[] command;        // 0x18

    }

    // TypeToken: 0x2000059
    public struct ScePadTriggerEffectStateInformationInternal
    {
        // Fields
        public Plugins.LibScePad.ScePadTriggerEffectStateInformationInternal.<state>e__FixedBuffer state;        // 0x10

    }

}

