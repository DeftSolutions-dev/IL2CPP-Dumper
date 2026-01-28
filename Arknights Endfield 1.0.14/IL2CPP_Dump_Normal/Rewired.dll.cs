// ========================================================
// Dumped by @desirepro
// Assembly: Rewired.dll
// Classes:  55
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000011
    public class DataStore, IDataStore
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,System.Object> _data;        // 0x10
        private readonly System.String _absFilePath;        // 0x18
        private Rewired.Data.UserDataStore_File.IDataHandler _dataHandler;        // 0x20

        // Methods
        private System.Void .ctor(System.String fileName, System.String absDirectory, Rewired.Data.UserDataStore_File.IDataHandler dataHandler) { }
        private System.Boolean TryGetValue(System.String key, System.Object& value) { }
        private System.Boolean SetValue(System.String key, System.Object value) { }
        private System.Boolean Save() { }
        private System.Boolean Load() { }
        private System.Boolean Clear() { }

    }

    // TypeToken: 0x2000012
    public class LocalFileDataHandler, IDataHandler
    {
        // Fields
        private readonly System.Func<Rewired.Data.UserDataStore_File.DataFormat> _dataFormatDelegate;        // 0x10
        private readonly Rewired.Data.UserDataStore_File.Codec _codec;        // 0x18

        // Methods
        private System.Void .ctor(System.Func<Rewired.Data.UserDataStore_File.DataFormat> dataFormatDelegate, Rewired.Data.UserDataStore_File.Codec codec) { }
        private System.Boolean Load(System.String absoluteFilePath, System.String& data) { }
        private System.Boolean Save(System.String absoluteFilePath, System.String data) { }
        private System.Boolean Clear(System.String absoluteFilePath) { }

    }

    // TypeToken: 0x2000013
    public class Codec
    {
        // Methods
        private System.Byte[] Encode(System.String string) { }
        private System.String Decode(System.Byte[] data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class UTF8Text : Codec
    {
        // Methods
        private System.Byte[] Encode(System.String string) { }
        private System.String Decode(System.Byte[] data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000015
    public class CLZF2 : Codec
    {
        // Fields
        private readonly Rewired.Utils.Libraries.CLZF2.CLZF2 _cLZF2;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Byte[] Encode(System.String string) { }
        private System.String Decode(System.Byte[] data) { }

    }

    // TypeToken: 0x2000016
    public interface IDataHandler
    {
        // Methods
        private System.Boolean Load(System.String absoluteFilePath, System.String& data) { }
        private System.Boolean Save(System.String absoluteFilePath, System.String data) { }
        private System.Boolean Clear(System.String absoluteFilePath) { }

    }

    // TypeToken: 0x2000017
    public struct DataFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Rewired.Data.UserDataStore_File.DataFormat Text;        // 0x0
        public static Rewired.Data.UserDataStore_File.DataFormat Binary;        // 0x0

    }

    // TypeToken: 0x200001A
    public class PlayerInfo
    {
        // Fields
        public System.Int32 id;        // 0x10
        public System.Boolean hasKeyboard;        // 0x14
        public System.Boolean hasMouse;        // 0x15
        public Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks;        // 0x18

        // Methods
        private System.Int32 get_joystickCount() { }
        private System.Int32 IndexOfJoystick(System.Int32 joystickId) { }
        private System.Boolean ContainsJoystick(System.Int32 joystickId) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public class JoystickInfo
    {
        // Fields
        public System.Guid instanceGuid;        // 0x10
        public System.String hardwareIdentifier;        // 0x20
        public System.Int32 id;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class ControllerAssignmentSaveInfo
    {
        // Fields
        public Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.PlayerInfo[] players;        // 0x10

        // Methods
        private System.Int32 get_playerCount() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 playerCount) { }
        private System.Int32 IndexOfPlayer(System.Int32 playerId) { }
        private System.Boolean ContainsPlayer(System.Int32 playerId) { }

    }

    // TypeToken: 0x200001C
    public class JoystickAssignmentHistoryInfo
    {
        // Fields
        public readonly Rewired.Joystick joystick;        // 0x10
        public readonly System.Int32 oldJoystickId;        // 0x18

        // Methods
        private System.Void .ctor(Rewired.Joystick joystick, System.Int32 oldJoystickId) { }

    }

    // TypeToken: 0x200001D
    public interface IDataStore
    {
        // Methods
        private System.Boolean Save() { }
        private System.Boolean Load() { }
        private System.Boolean Clear() { }
        private System.Boolean TryGetValue(System.String key, System.Object& result) { }
        private System.Boolean SetValue(System.String key, System.Object value) { }

    }

    // TypeToken: 0x2000024
    public class PlayerInfo
    {
        // Fields
        public System.Int32 id;        // 0x10
        public System.Boolean hasKeyboard;        // 0x14
        public System.Boolean hasMouse;        // 0x15
        public Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks;        // 0x18

        // Methods
        private System.Int32 get_joystickCount() { }
        private System.Int32 IndexOfJoystick(System.Int32 joystickId) { }
        private System.Boolean ContainsJoystick(System.Int32 joystickId) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class JoystickInfo
    {
        // Fields
        public System.Guid instanceGuid;        // 0x10
        public System.String hardwareIdentifier;        // 0x20
        public System.Int32 id;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public class ControllerAssignmentSaveInfo
    {
        // Fields
        public Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[] players;        // 0x10

        // Methods
        private System.Int32 get_playerCount() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 playerCount) { }
        private System.Int32 IndexOfPlayer(System.Int32 playerId) { }
        private System.Boolean ContainsPlayer(System.Int32 playerId) { }

    }

    // TypeToken: 0x2000026
    public class JoystickAssignmentHistoryInfo
    {
        // Fields
        public readonly Rewired.Joystick joystick;        // 0x10
        public readonly System.Int32 oldJoystickId;        // 0x18

        // Methods
        private System.Void .ctor(Rewired.Joystick joystick, System.Int32 oldJoystickId) { }

    }

    // TypeToken: 0x200002F
    public class MouseState
    {
        // Fields
        private System.Collections.Generic.List<Rewired.Integration.UnityUI.RewiredPointerInputModule.ButtonState> m_TrackedButtons;        // 0x10

        // Methods
        private System.Boolean AnyPressesThisFrame() { }
        private System.Boolean AnyReleasesThisFrame() { }
        private Rewired.Integration.UnityUI.RewiredPointerInputModule.ButtonState GetButtonState(System.Int32 button) { }
        private System.Void SetButtonState(System.Int32 button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, Rewired.Integration.UnityUI.PlayerPointerEventData data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000030
    public class MouseButtonEventData
    {
        // Fields
        public UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;        // 0x10
        public Rewired.Integration.UnityUI.PlayerPointerEventData buttonData;        // 0x18

        // Methods
        private System.Boolean PressedThisFrame() { }
        private System.Boolean ReleasedThisFrame() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000031
    public class ButtonState
    {
        // Fields
        private System.Int32 m_Button;        // 0x10
        private Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseButtonEventData m_EventData;        // 0x18

        // Methods
        private Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseButtonEventData get_eventData() { }
        private System.Void set_eventData(Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseButtonEventData value) { }
        private System.Int32 get_button() { }
        private System.Void set_button(System.Int32 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000032
    public class UnityInputSource, IMouseInputSource, ITouchInputSource
    {
        // Fields
        private UnityEngine.Vector2 m_MousePosition;        // 0x10
        private UnityEngine.Vector2 m_MousePositionPrev;        // 0x18
        private System.Int32 m_LastUpdatedFrame;        // 0x20

        // Methods
        private System.Int32 Rewired.UI.IMouseInputSource.get_playerId() { }
        private System.Int32 Rewired.UI.ITouchInputSource.get_playerId() { }
        private System.Boolean Rewired.UI.IMouseInputSource.get_enabled() { }
        private System.Boolean Rewired.UI.IMouseInputSource.get_locked() { }
        private System.Int32 Rewired.UI.IMouseInputSource.get_buttonCount() { }
        private System.Boolean Rewired.UI.IMouseInputSource.GetButtonDown(System.Int32 button) { }
        private System.Boolean Rewired.UI.IMouseInputSource.GetButtonUp(System.Int32 button) { }
        private System.Boolean Rewired.UI.IMouseInputSource.GetButton(System.Int32 button) { }
        private UnityEngine.Vector2 Rewired.UI.IMouseInputSource.get_screenPosition() { }
        private UnityEngine.Vector2 Rewired.UI.IMouseInputSource.get_screenPositionDelta() { }
        private UnityEngine.Vector2 Rewired.UI.IMouseInputSource.get_wheelDelta() { }
        private System.Boolean Rewired.UI.ITouchInputSource.get_touchSupported() { }
        private System.Int32 Rewired.UI.ITouchInputSource.get_touchCount() { }
        private UnityEngine.Touch Rewired.UI.ITouchInputSource.GetTouch(System.Int32 index) { }
        private System.Void TryUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000035
    public class PlayerSetting
    {
        // Fields
        public System.Int32 playerId;        // 0x10
        public System.Collections.Generic.List<Rewired.Components.PlayerMouse> playerMice;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(Rewired.Integration.UnityUI.RewiredStandaloneInputModule.PlayerSetting other) { }
        private Rewired.Integration.UnityUI.RewiredStandaloneInputModule.PlayerSetting Clone() { }

    }

namespace Rewired
{

    // TypeToken: 0x2000002
    public interface IGamepadTemplate : IControllerTemplate
    {
        // Methods
        private Rewired.IControllerTemplateButton get_actionBottomRow1() { }
        private Rewired.IControllerTemplateButton get_a() { }
        private Rewired.IControllerTemplateButton get_actionBottomRow2() { }
        private Rewired.IControllerTemplateButton get_b() { }
        private Rewired.IControllerTemplateButton get_actionBottomRow3() { }
        private Rewired.IControllerTemplateButton get_c() { }
        private Rewired.IControllerTemplateButton get_actionTopRow1() { }
        private Rewired.IControllerTemplateButton get_x() { }
        private Rewired.IControllerTemplateButton get_actionTopRow2() { }
        private Rewired.IControllerTemplateButton get_y() { }
        private Rewired.IControllerTemplateButton get_actionTopRow3() { }
        private Rewired.IControllerTemplateButton get_z() { }
        private Rewired.IControllerTemplateButton get_leftShoulder1() { }
        private Rewired.IControllerTemplateButton get_leftBumper() { }
        private Rewired.IControllerTemplateAxis get_leftShoulder2() { }
        private Rewired.IControllerTemplateAxis get_leftTrigger() { }
        private Rewired.IControllerTemplateButton get_rightShoulder1() { }
        private Rewired.IControllerTemplateButton get_rightBumper() { }
        private Rewired.IControllerTemplateAxis get_rightShoulder2() { }
        private Rewired.IControllerTemplateAxis get_rightTrigger() { }
        private Rewired.IControllerTemplateButton get_center1() { }
        private Rewired.IControllerTemplateButton get_back() { }
        private Rewired.IControllerTemplateButton get_center2() { }
        private Rewired.IControllerTemplateButton get_start() { }
        private Rewired.IControllerTemplateButton get_center3() { }
        private Rewired.IControllerTemplateButton get_guide() { }
        private Rewired.IControllerTemplateThumbStick get_leftStick() { }
        private Rewired.IControllerTemplateThumbStick get_rightStick() { }
        private Rewired.IControllerTemplateDPad get_dPad() { }

    }

    // TypeToken: 0x2000003
    public interface IRacingWheelTemplate : IControllerTemplate
    {
        // Methods
        private Rewired.IControllerTemplateAxis get_wheel() { }
        private Rewired.IControllerTemplateAxis get_accelerator() { }
        private Rewired.IControllerTemplateAxis get_brake() { }
        private Rewired.IControllerTemplateAxis get_clutch() { }
        private Rewired.IControllerTemplateButton get_shiftDown() { }
        private Rewired.IControllerTemplateButton get_shiftUp() { }
        private Rewired.IControllerTemplateButton get_wheelButton1() { }
        private Rewired.IControllerTemplateButton get_wheelButton2() { }
        private Rewired.IControllerTemplateButton get_wheelButton3() { }
        private Rewired.IControllerTemplateButton get_wheelButton4() { }
        private Rewired.IControllerTemplateButton get_wheelButton5() { }
        private Rewired.IControllerTemplateButton get_wheelButton6() { }
        private Rewired.IControllerTemplateButton get_wheelButton7() { }
        private Rewired.IControllerTemplateButton get_wheelButton8() { }
        private Rewired.IControllerTemplateButton get_wheelButton9() { }
        private Rewired.IControllerTemplateButton get_wheelButton10() { }
        private Rewired.IControllerTemplateButton get_consoleButton1() { }
        private Rewired.IControllerTemplateButton get_consoleButton2() { }
        private Rewired.IControllerTemplateButton get_consoleButton3() { }
        private Rewired.IControllerTemplateButton get_consoleButton4() { }
        private Rewired.IControllerTemplateButton get_consoleButton5() { }
        private Rewired.IControllerTemplateButton get_consoleButton6() { }
        private Rewired.IControllerTemplateButton get_consoleButton7() { }
        private Rewired.IControllerTemplateButton get_consoleButton8() { }
        private Rewired.IControllerTemplateButton get_consoleButton9() { }
        private Rewired.IControllerTemplateButton get_consoleButton10() { }
        private Rewired.IControllerTemplateButton get_shifter1() { }
        private Rewired.IControllerTemplateButton get_shifter2() { }
        private Rewired.IControllerTemplateButton get_shifter3() { }
        private Rewired.IControllerTemplateButton get_shifter4() { }
        private Rewired.IControllerTemplateButton get_shifter5() { }
        private Rewired.IControllerTemplateButton get_shifter6() { }
        private Rewired.IControllerTemplateButton get_shifter7() { }
        private Rewired.IControllerTemplateButton get_shifter8() { }
        private Rewired.IControllerTemplateButton get_shifter9() { }
        private Rewired.IControllerTemplateButton get_shifter10() { }
        private Rewired.IControllerTemplateButton get_reverseGear() { }
        private Rewired.IControllerTemplateButton get_select() { }
        private Rewired.IControllerTemplateButton get_start() { }
        private Rewired.IControllerTemplateButton get_systemButton() { }
        private Rewired.IControllerTemplateButton get_horn() { }
        private Rewired.IControllerTemplateDPad get_dPad() { }

    }

    // TypeToken: 0x2000004
    public interface IHOTASTemplate : IControllerTemplate
    {
        // Methods
        private Rewired.IControllerTemplateButton get_stickTrigger() { }
        private Rewired.IControllerTemplateButton get_stickTriggerStage2() { }
        private Rewired.IControllerTemplateButton get_stickPinkyButton() { }
        private Rewired.IControllerTemplateButton get_stickPinkyTrigger() { }
        private Rewired.IControllerTemplateButton get_stickButton1() { }
        private Rewired.IControllerTemplateButton get_stickButton2() { }
        private Rewired.IControllerTemplateButton get_stickButton3() { }
        private Rewired.IControllerTemplateButton get_stickButton4() { }
        private Rewired.IControllerTemplateButton get_stickButton5() { }
        private Rewired.IControllerTemplateButton get_stickButton6() { }
        private Rewired.IControllerTemplateButton get_stickButton7() { }
        private Rewired.IControllerTemplateButton get_stickButton8() { }
        private Rewired.IControllerTemplateButton get_stickButton9() { }
        private Rewired.IControllerTemplateButton get_stickButton10() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton1() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton2() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton3() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton4() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton5() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton6() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton7() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton8() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton9() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton10() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton11() { }
        private Rewired.IControllerTemplateButton get_stickBaseButton12() { }
        private Rewired.IControllerTemplateButton get_mode1() { }
        private Rewired.IControllerTemplateButton get_mode2() { }
        private Rewired.IControllerTemplateButton get_mode3() { }
        private Rewired.IControllerTemplateButton get_throttleButton1() { }
        private Rewired.IControllerTemplateButton get_throttleButton2() { }
        private Rewired.IControllerTemplateButton get_throttleButton3() { }
        private Rewired.IControllerTemplateButton get_throttleButton4() { }
        private Rewired.IControllerTemplateButton get_throttleButton5() { }
        private Rewired.IControllerTemplateButton get_throttleButton6() { }
        private Rewired.IControllerTemplateButton get_throttleButton7() { }
        private Rewired.IControllerTemplateButton get_throttleButton8() { }
        private Rewired.IControllerTemplateButton get_throttleButton9() { }
        private Rewired.IControllerTemplateButton get_throttleButton10() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton1() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton2() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton3() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton4() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton5() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton6() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton7() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton8() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton9() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton10() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton11() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton12() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton13() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton14() { }
        private Rewired.IControllerTemplateButton get_throttleBaseButton15() { }
        private Rewired.IControllerTemplateAxis get_throttleSlider1() { }
        private Rewired.IControllerTemplateAxis get_throttleSlider2() { }
        private Rewired.IControllerTemplateAxis get_throttleSlider3() { }
        private Rewired.IControllerTemplateAxis get_throttleSlider4() { }
        private Rewired.IControllerTemplateAxis get_throttleDial1() { }
        private Rewired.IControllerTemplateAxis get_throttleDial2() { }
        private Rewired.IControllerTemplateAxis get_throttleDial3() { }
        private Rewired.IControllerTemplateAxis get_throttleDial4() { }
        private Rewired.IControllerTemplateButton get_throttleWheel1Forward() { }
        private Rewired.IControllerTemplateButton get_throttleWheel1Back() { }
        private Rewired.IControllerTemplateButton get_throttleWheel1Press() { }
        private Rewired.IControllerTemplateButton get_throttleWheel2Forward() { }
        private Rewired.IControllerTemplateButton get_throttleWheel2Back() { }
        private Rewired.IControllerTemplateButton get_throttleWheel2Press() { }
        private Rewired.IControllerTemplateButton get_throttleWheel3Forward() { }
        private Rewired.IControllerTemplateButton get_throttleWheel3Back() { }
        private Rewired.IControllerTemplateButton get_throttleWheel3Press() { }
        private Rewired.IControllerTemplateAxis get_leftPedal() { }
        private Rewired.IControllerTemplateAxis get_rightPedal() { }
        private Rewired.IControllerTemplateAxis get_slidePedals() { }
        private Rewired.IControllerTemplateStick get_stick() { }
        private Rewired.IControllerTemplateThumbStick get_stickMiniStick1() { }
        private Rewired.IControllerTemplateThumbStick get_stickMiniStick2() { }
        private Rewired.IControllerTemplateHat get_stickHat1() { }
        private Rewired.IControllerTemplateHat get_stickHat2() { }
        private Rewired.IControllerTemplateHat get_stickHat3() { }
        private Rewired.IControllerTemplateHat get_stickHat4() { }
        private Rewired.IControllerTemplateThrottle get_throttle1() { }
        private Rewired.IControllerTemplateThrottle get_throttle2() { }
        private Rewired.IControllerTemplateThumbStick get_throttleMiniStick() { }
        private Rewired.IControllerTemplateHat get_throttleHat1() { }
        private Rewired.IControllerTemplateHat get_throttleHat2() { }
        private Rewired.IControllerTemplateHat get_throttleHat3() { }
        private Rewired.IControllerTemplateHat get_throttleHat4() { }

    }

    // TypeToken: 0x2000005
    public interface IFlightYokeTemplate : IControllerTemplate
    {
        // Methods
        private Rewired.IControllerTemplateButton get_leftPaddle() { }
        private Rewired.IControllerTemplateButton get_rightPaddle() { }
        private Rewired.IControllerTemplateButton get_leftGripButton1() { }
        private Rewired.IControllerTemplateButton get_leftGripButton2() { }
        private Rewired.IControllerTemplateButton get_leftGripButton3() { }
        private Rewired.IControllerTemplateButton get_leftGripButton4() { }
        private Rewired.IControllerTemplateButton get_leftGripButton5() { }
        private Rewired.IControllerTemplateButton get_leftGripButton6() { }
        private Rewired.IControllerTemplateButton get_rightGripButton1() { }
        private Rewired.IControllerTemplateButton get_rightGripButton2() { }
        private Rewired.IControllerTemplateButton get_rightGripButton3() { }
        private Rewired.IControllerTemplateButton get_rightGripButton4() { }
        private Rewired.IControllerTemplateButton get_rightGripButton5() { }
        private Rewired.IControllerTemplateButton get_rightGripButton6() { }
        private Rewired.IControllerTemplateButton get_centerButton1() { }
        private Rewired.IControllerTemplateButton get_centerButton2() { }
        private Rewired.IControllerTemplateButton get_centerButton3() { }
        private Rewired.IControllerTemplateButton get_centerButton4() { }
        private Rewired.IControllerTemplateButton get_centerButton5() { }
        private Rewired.IControllerTemplateButton get_centerButton6() { }
        private Rewired.IControllerTemplateButton get_centerButton7() { }
        private Rewired.IControllerTemplateButton get_centerButton8() { }
        private Rewired.IControllerTemplateButton get_wheel1Up() { }
        private Rewired.IControllerTemplateButton get_wheel1Down() { }
        private Rewired.IControllerTemplateButton get_wheel1Press() { }
        private Rewired.IControllerTemplateButton get_wheel2Up() { }
        private Rewired.IControllerTemplateButton get_wheel2Down() { }
        private Rewired.IControllerTemplateButton get_wheel2Press() { }
        private Rewired.IControllerTemplateButton get_consoleButton1() { }
        private Rewired.IControllerTemplateButton get_consoleButton2() { }
        private Rewired.IControllerTemplateButton get_consoleButton3() { }
        private Rewired.IControllerTemplateButton get_consoleButton4() { }
        private Rewired.IControllerTemplateButton get_consoleButton5() { }
        private Rewired.IControllerTemplateButton get_consoleButton6() { }
        private Rewired.IControllerTemplateButton get_consoleButton7() { }
        private Rewired.IControllerTemplateButton get_consoleButton8() { }
        private Rewired.IControllerTemplateButton get_consoleButton9() { }
        private Rewired.IControllerTemplateButton get_consoleButton10() { }
        private Rewired.IControllerTemplateButton get_mode1() { }
        private Rewired.IControllerTemplateButton get_mode2() { }
        private Rewired.IControllerTemplateButton get_mode3() { }
        private Rewired.IControllerTemplateYoke get_yoke() { }
        private Rewired.IControllerTemplateThrottle get_lever1() { }
        private Rewired.IControllerTemplateThrottle get_lever2() { }
        private Rewired.IControllerTemplateThrottle get_lever3() { }
        private Rewired.IControllerTemplateThrottle get_lever4() { }
        private Rewired.IControllerTemplateThrottle get_lever5() { }
        private Rewired.IControllerTemplateHat get_leftGripHat() { }
        private Rewired.IControllerTemplateHat get_rightGripHat() { }

    }

    // TypeToken: 0x2000006
    public interface IFlightPedalsTemplate : IControllerTemplate
    {
        // Methods
        private Rewired.IControllerTemplateAxis get_leftPedal() { }
        private Rewired.IControllerTemplateAxis get_rightPedal() { }
        private Rewired.IControllerTemplateAxis get_slide() { }

    }

    // TypeToken: 0x2000007
    public interface ISixDofControllerTemplate : IControllerTemplate
    {
        // Methods
        private Rewired.IControllerTemplateAxis get_extraAxis1() { }
        private Rewired.IControllerTemplateAxis get_extraAxis2() { }
        private Rewired.IControllerTemplateAxis get_extraAxis3() { }
        private Rewired.IControllerTemplateAxis get_extraAxis4() { }
        private Rewired.IControllerTemplateButton get_button1() { }
        private Rewired.IControllerTemplateButton get_button2() { }
        private Rewired.IControllerTemplateButton get_button3() { }
        private Rewired.IControllerTemplateButton get_button4() { }
        private Rewired.IControllerTemplateButton get_button5() { }
        private Rewired.IControllerTemplateButton get_button6() { }
        private Rewired.IControllerTemplateButton get_button7() { }
        private Rewired.IControllerTemplateButton get_button8() { }
        private Rewired.IControllerTemplateButton get_button9() { }
        private Rewired.IControllerTemplateButton get_button10() { }
        private Rewired.IControllerTemplateButton get_button11() { }
        private Rewired.IControllerTemplateButton get_button12() { }
        private Rewired.IControllerTemplateButton get_button13() { }
        private Rewired.IControllerTemplateButton get_button14() { }
        private Rewired.IControllerTemplateButton get_button15() { }
        private Rewired.IControllerTemplateButton get_button16() { }
        private Rewired.IControllerTemplateButton get_button17() { }
        private Rewired.IControllerTemplateButton get_button18() { }
        private Rewired.IControllerTemplateButton get_button19() { }
        private Rewired.IControllerTemplateButton get_button20() { }
        private Rewired.IControllerTemplateButton get_button21() { }
        private Rewired.IControllerTemplateButton get_button22() { }
        private Rewired.IControllerTemplateButton get_button23() { }
        private Rewired.IControllerTemplateButton get_button24() { }
        private Rewired.IControllerTemplateButton get_button25() { }
        private Rewired.IControllerTemplateButton get_button26() { }
        private Rewired.IControllerTemplateButton get_button27() { }
        private Rewired.IControllerTemplateButton get_button28() { }
        private Rewired.IControllerTemplateButton get_button29() { }
        private Rewired.IControllerTemplateButton get_button30() { }
        private Rewired.IControllerTemplateButton get_button31() { }
        private Rewired.IControllerTemplateButton get_button32() { }
        private Rewired.IControllerTemplateHat get_hat1() { }
        private Rewired.IControllerTemplateHat get_hat2() { }
        private Rewired.IControllerTemplateThrottle get_throttle1() { }
        private Rewired.IControllerTemplateThrottle get_throttle2() { }
        private Rewired.IControllerTemplateStick6D get_stick() { }

    }

    // TypeToken: 0x2000008
    public class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;        // 0x0
        public static System.Int32 elementId_leftStickX;        // 0x0
        public static System.Int32 elementId_leftStickY;        // 0x0
        public static System.Int32 elementId_rightStickX;        // 0x0
        public static System.Int32 elementId_rightStickY;        // 0x0
        public static System.Int32 elementId_actionBottomRow1;        // 0x0
        public static System.Int32 elementId_a;        // 0x0
        public static System.Int32 elementId_actionBottomRow2;        // 0x0
        public static System.Int32 elementId_b;        // 0x0
        public static System.Int32 elementId_actionBottomRow3;        // 0x0
        public static System.Int32 elementId_c;        // 0x0
        public static System.Int32 elementId_actionTopRow1;        // 0x0
        public static System.Int32 elementId_x;        // 0x0
        public static System.Int32 elementId_actionTopRow2;        // 0x0
        public static System.Int32 elementId_y;        // 0x0
        public static System.Int32 elementId_actionTopRow3;        // 0x0
        public static System.Int32 elementId_z;        // 0x0
        public static System.Int32 elementId_leftShoulder1;        // 0x0
        public static System.Int32 elementId_leftBumper;        // 0x0
        public static System.Int32 elementId_leftShoulder2;        // 0x0
        public static System.Int32 elementId_leftTrigger;        // 0x0
        public static System.Int32 elementId_rightShoulder1;        // 0x0
        public static System.Int32 elementId_rightBumper;        // 0x0
        public static System.Int32 elementId_rightShoulder2;        // 0x0
        public static System.Int32 elementId_rightTrigger;        // 0x0
        public static System.Int32 elementId_center1;        // 0x0
        public static System.Int32 elementId_back;        // 0x0
        public static System.Int32 elementId_center2;        // 0x0
        public static System.Int32 elementId_start;        // 0x0
        public static System.Int32 elementId_center3;        // 0x0
        public static System.Int32 elementId_guide;        // 0x0
        public static System.Int32 elementId_leftStickButton;        // 0x0
        public static System.Int32 elementId_rightStickButton;        // 0x0
        public static System.Int32 elementId_dPadUp;        // 0x0
        public static System.Int32 elementId_dPadRight;        // 0x0
        public static System.Int32 elementId_dPadDown;        // 0x0
        public static System.Int32 elementId_dPadLeft;        // 0x0
        public static System.Int32 elementId_leftStick;        // 0x0
        public static System.Int32 elementId_rightStick;        // 0x0
        public static System.Int32 elementId_dPad;        // 0x0

        // Methods
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow1() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_a() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow2() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_b() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow3() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_c() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow1() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_x() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow2() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_y() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow3() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_z() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_leftShoulder1() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_leftBumper() { }
        private Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.get_leftShoulder2() { }
        private Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.get_leftTrigger() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_rightShoulder1() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_rightBumper() { }
        private Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.get_rightShoulder2() { }
        private Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.get_rightTrigger() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_center1() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_back() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_center2() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_start() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_center3() { }
        private Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_guide() { }
        private Rewired.IControllerTemplateThumbStick Rewired.IGamepadTemplate.get_leftStick() { }
        private Rewired.IControllerTemplateThumbStick Rewired.IGamepadTemplate.get_rightStick() { }
        private Rewired.IControllerTemplateDPad Rewired.IGamepadTemplate.get_dPad() { }
        private System.Void .ctor(System.Object payload) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000009
    public class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;        // 0x0
        public static System.Int32 elementId_wheel;        // 0x0
        public static System.Int32 elementId_accelerator;        // 0x0
        public static System.Int32 elementId_brake;        // 0x0
        public static System.Int32 elementId_clutch;        // 0x0
        public static System.Int32 elementId_shiftDown;        // 0x0
        public static System.Int32 elementId_shiftUp;        // 0x0
        public static System.Int32 elementId_wheelButton1;        // 0x0
        public static System.Int32 elementId_wheelButton2;        // 0x0
        public static System.Int32 elementId_wheelButton3;        // 0x0
        public static System.Int32 elementId_wheelButton4;        // 0x0
        public static System.Int32 elementId_wheelButton5;        // 0x0
        public static System.Int32 elementId_wheelButton6;        // 0x0
        public static System.Int32 elementId_wheelButton7;        // 0x0
        public static System.Int32 elementId_wheelButton8;        // 0x0
        public static System.Int32 elementId_wheelButton9;        // 0x0
        public static System.Int32 elementId_wheelButton10;        // 0x0
        public static System.Int32 elementId_consoleButton1;        // 0x0
        public static System.Int32 elementId_consoleButton2;        // 0x0
        public static System.Int32 elementId_consoleButton3;        // 0x0
        public static System.Int32 elementId_consoleButton4;        // 0x0
        public static System.Int32 elementId_consoleButton5;        // 0x0
        public static System.Int32 elementId_consoleButton6;        // 0x0
        public static System.Int32 elementId_consoleButton7;        // 0x0
        public static System.Int32 elementId_consoleButton8;        // 0x0
        public static System.Int32 elementId_consoleButton9;        // 0x0
        public static System.Int32 elementId_consoleButton10;        // 0x0
        public static System.Int32 elementId_shifter1;        // 0x0
        public static System.Int32 elementId_shifter2;        // 0x0
        public static System.Int32 elementId_shifter3;        // 0x0
        public static System.Int32 elementId_shifter4;        // 0x0
        public static System.Int32 elementId_shifter5;        // 0x0
        public static System.Int32 elementId_shifter6;        // 0x0
        public static System.Int32 elementId_shifter7;        // 0x0
        public static System.Int32 elementId_shifter8;        // 0x0
        public static System.Int32 elementId_shifter9;        // 0x0
        public static System.Int32 elementId_shifter10;        // 0x0
        public static System.Int32 elementId_reverseGear;        // 0x0
        public static System.Int32 elementId_select;        // 0x0
        public static System.Int32 elementId_start;        // 0x0
        public static System.Int32 elementId_systemButton;        // 0x0
        public static System.Int32 elementId_horn;        // 0x0
        public static System.Int32 elementId_dPadUp;        // 0x0
        public static System.Int32 elementId_dPadRight;        // 0x0
        public static System.Int32 elementId_dPadDown;        // 0x0
        public static System.Int32 elementId_dPadLeft;        // 0x0
        public static System.Int32 elementId_dPad;        // 0x0

        // Methods
        private Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_wheel() { }
        private Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_accelerator() { }
        private Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_brake() { }
        private Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_clutch() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shiftDown() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shiftUp() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton1() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton2() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton3() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton4() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton5() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton6() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton7() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton8() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton9() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton10() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton1() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton2() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton3() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton4() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton5() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton6() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton7() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton8() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton9() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton10() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter1() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter2() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter3() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter4() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter5() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter6() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter7() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter8() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter9() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter10() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_reverseGear() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_select() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_start() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_systemButton() { }
        private Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_horn() { }
        private Rewired.IControllerTemplateDPad Rewired.IRacingWheelTemplate.get_dPad() { }
        private System.Void .ctor(System.Object payload) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000A
    public class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;        // 0x0
        public static System.Int32 elementId_stickX;        // 0x0
        public static System.Int32 elementId_stickY;        // 0x0
        public static System.Int32 elementId_stickRotate;        // 0x0
        public static System.Int32 elementId_stickMiniStick1X;        // 0x0
        public static System.Int32 elementId_stickMiniStick1Y;        // 0x0
        public static System.Int32 elementId_stickMiniStick1Press;        // 0x0
        public static System.Int32 elementId_stickMiniStick2X;        // 0x0
        public static System.Int32 elementId_stickMiniStick2Y;        // 0x0
        public static System.Int32 elementId_stickMiniStick2Press;        // 0x0
        public static System.Int32 elementId_stickTrigger;        // 0x0
        public static System.Int32 elementId_stickTriggerStage2;        // 0x0
        public static System.Int32 elementId_stickPinkyButton;        // 0x0
        public static System.Int32 elementId_stickPinkyTrigger;        // 0x0
        public static System.Int32 elementId_stickButton1;        // 0x0
        public static System.Int32 elementId_stickButton2;        // 0x0
        public static System.Int32 elementId_stickButton3;        // 0x0
        public static System.Int32 elementId_stickButton4;        // 0x0
        public static System.Int32 elementId_stickButton5;        // 0x0
        public static System.Int32 elementId_stickButton6;        // 0x0
        public static System.Int32 elementId_stickButton7;        // 0x0
        public static System.Int32 elementId_stickButton8;        // 0x0
        public static System.Int32 elementId_stickButton9;        // 0x0
        public static System.Int32 elementId_stickButton10;        // 0x0
        public static System.Int32 elementId_stickBaseButton1;        // 0x0
        public static System.Int32 elementId_stickBaseButton2;        // 0x0
        public static System.Int32 elementId_stickBaseButton3;        // 0x0
        public static System.Int32 elementId_stickBaseButton4;        // 0x0
        public static System.Int32 elementId_stickBaseButton5;        // 0x0
        public static System.Int32 elementId_stickBaseButton6;        // 0x0
        public static System.Int32 elementId_stickBaseButton7;        // 0x0
        public static System.Int32 elementId_stickBaseButton8;        // 0x0
        public static System.Int32 elementId_stickBaseButton9;        // 0x0
        public static System.Int32 elementId_stickBaseButton10;        // 0x0
        public static System.Int32 elementId_stickBaseButton11;        // 0x0
        public static System.Int32 elementId_stickBaseButton12;        // 0x0
        public static System.Int32 elementId_stickHat1Up;        // 0x0
        public static System.Int32 elementId_stickHat1UpRight;        // 0x0
        public static System.Int32 elementId_stickHat1Right;        // 0x0
        public static System.Int32 elementId_stickHat1DownRight;        // 0x0
        public static System.Int32 elementId_stickHat1Down;        // 0x0
        public static System.Int32 elementId_stickHat1DownLeft;        // 0x0
        public static System.Int32 elementId_stickHat1Left;        // 0x0
        public static System.Int32 elementId_stickHat1Up_Left;        // 0x0
        public static System.Int32 elementId_stickHat2Up;        // 0x0
        public static System.Int32 elementId_stickHat2Up_right;        // 0x0
        public static System.Int32 elementId_stickHat2Right;        // 0x0
        public static System.Int32 elementId_stickHat2Down_Right;        // 0x0
        public static System.Int32 elementId_stickHat2Down;        // 0x0
        public static System.Int32 elementId_stickHat2Down_Left;        // 0x0
        public static System.Int32 elementId_stickHat2Left;        // 0x0
        public static System.Int32 elementId_stickHat2Up_Left;        // 0x0
        public static System.Int32 elementId_stickHat3Up;        // 0x0
        public static System.Int32 elementId_stickHat3Up_Right;        // 0x0
        public static System.Int32 elementId_stickHat3Right;        // 0x0
        public static System.Int32 elementId_stickHat3Down_Right;        // 0x0
        public static System.Int32 elementId_stickHat3Down;        // 0x0
        public static System.Int32 elementId_stickHat3Down_Left;        // 0x0
        public static System.Int32 elementId_stickHat3Left;        // 0x0
        public static System.Int32 elementId_stickHat3Up_Left;        // 0x0
        public static System.Int32 elementId_stickHat4Up;        // 0x0
        public static System.Int32 elementId_stickHat4Up_Right;        // 0x0
        public static System.Int32 elementId_stickHat4Right;        // 0x0
        public static System.Int32 elementId_stickHat4Down_Right;        // 0x0
        public static System.Int32 elementId_stickHat4Down;        // 0x0
        public static System.Int32 elementId_stickHat4Down_Left;        // 0x0
        public static System.Int32 elementId_stickHat4Left;        // 0x0
        public static System.Int32 elementId_stickHat4Up_Left;        // 0x0
        public static System.Int32 elementId_mode1;        // 0x0
        public static System.Int32 elementId_mode2;        // 0x0
        public static System.Int32 elementId_mode3;        // 0x0
        public static System.Int32 elementId_throttle1Axis;        // 0x0
        public static System.Int32 elementId_throttle2Axis;        // 0x0
        public static System.Int32 elementId_throttle1MinDetent;        // 0x0
        public static System.Int32 elementId_throttle2MinDetent;        // 0x0
        public static System.Int32 elementId_throttleButton1;        // 0x0
        public static System.Int32 elementId_throttleButton2;        // 0x0
        public static System.Int32 elementId_throttleButton3;        // 0x0
        public static System.Int32 elementId_throttleButton4;        // 0x0
        public static System.Int32 elementId_throttleButton5;        // 0x0
        public static System.Int32 elementId_throttleButton6;        // 0x0
        public static System.Int32 elementId_throttleButton7;        // 0x0
        public static System.Int32 elementId_throttleButton8;        // 0x0
        public static System.Int32 elementId_throttleButton9;        // 0x0
        public static System.Int32 elementId_throttleButton10;        // 0x0
        public static System.Int32 elementId_throttleBaseButton1;        // 0x0
        public static System.Int32 elementId_throttleBaseButton2;        // 0x0
        public static System.Int32 elementId_throttleBaseButton3;        // 0x0
        public static System.Int32 elementId_throttleBaseButton4;        // 0x0
        public static System.Int32 elementId_throttleBaseButton5;        // 0x0
        public static System.Int32 elementId_throttleBaseButton6;        // 0x0
        public static System.Int32 elementId_throttleBaseButton7;        // 0x0
        public static System.Int32 elementId_throttleBaseButton8;        // 0x0
        public static System.Int32 elementId_throttleBaseButton9;        // 0x0
        public static System.Int32 elementId_throttleBaseButton10;        // 0x0
        public static System.Int32 elementId_throttleBaseButton11;        // 0x0
        public static System.Int32 elementId_throttleBaseButton12;        // 0x0
        public static System.Int32 elementId_throttleBaseButton13;        // 0x0
        public static System.Int32 elementId_throttleBaseButton14;        // 0x0
        public static System.Int32 elementId_throttleBaseButton15;        // 0x0
        public static System.Int32 elementId_throttleSlider1;        // 0x0
        public static System.Int32 elementId_throttleSlider2;        // 0x0
        public static System.Int32 elementId_throttleSlider3;        // 0x0
        public static System.Int32 elementId_throttleSlider4;        // 0x0
        public static System.Int32 elementId_throttleDial1;        // 0x0
        public static System.Int32 elementId_throttleDial2;        // 0x0
        public static System.Int32 elementId_throttleDial3;        // 0x0
        public static System.Int32 elementId_throttleDial4;        // 0x0
        public static System.Int32 elementId_throttleMiniStickX;        // 0x0
        public static System.Int32 elementId_throttleMiniStickY;        // 0x0
        public static System.Int32 elementId_throttleMiniStickPress;        // 0x0
        public static System.Int32 elementId_throttleWheel1Forward;        // 0x0
        public static System.Int32 elementId_throttleWheel1Back;        // 0x0
        public static System.Int32 elementId_throttleWheel1Press;        // 0x0
        public static System.Int32 elementId_throttleWheel2Forward;        // 0x0
        public static System.Int32 elementId_throttleWheel2Back;        // 0x0
        public static System.Int32 elementId_throttleWheel2Press;        // 0x0
        public static System.Int32 elementId_throttleWheel3Forward;        // 0x0
        public static System.Int32 elementId_throttleWheel3Back;        // 0x0
        public static System.Int32 elementId_throttleWheel3Press;        // 0x0
        public static System.Int32 elementId_throttleHat1Up;        // 0x0
        public static System.Int32 elementId_throttleHat1Up_Right;        // 0x0
        public static System.Int32 elementId_throttleHat1Right;        // 0x0
        public static System.Int32 elementId_throttleHat1Down_Right;        // 0x0
        public static System.Int32 elementId_throttleHat1Down;        // 0x0
        public static System.Int32 elementId_throttleHat1Down_Left;        // 0x0
        public static System.Int32 elementId_throttleHat1Left;        // 0x0
        public static System.Int32 elementId_throttleHat1Up_Left;        // 0x0
        public static System.Int32 elementId_throttleHat2Up;        // 0x0
        public static System.Int32 elementId_throttleHat2Up_Right;        // 0x0
        public static System.Int32 elementId_throttleHat2Right;        // 0x0
        public static System.Int32 elementId_throttleHat2Down_Right;        // 0x0
        public static System.Int32 elementId_throttleHat2Down;        // 0x0
        public static System.Int32 elementId_throttleHat2Down_Left;        // 0x0
        public static System.Int32 elementId_throttleHat2Left;        // 0x0
        public static System.Int32 elementId_throttleHat2Up_Left;        // 0x0
        public static System.Int32 elementId_throttleHat3Up;        // 0x0
        public static System.Int32 elementId_throttleHat3Up_Right;        // 0x0
        public static System.Int32 elementId_throttleHat3Right;        // 0x0
        public static System.Int32 elementId_throttleHat3Down_Right;        // 0x0
        public static System.Int32 elementId_throttleHat3Down;        // 0x0
        public static System.Int32 elementId_throttleHat3Down_Left;        // 0x0
        public static System.Int32 elementId_throttleHat3Left;        // 0x0
        public static System.Int32 elementId_throttleHat3Up_Left;        // 0x0
        public static System.Int32 elementId_throttleHat4Up;        // 0x0
        public static System.Int32 elementId_throttleHat4Up_Right;        // 0x0
        public static System.Int32 elementId_throttleHat4Right;        // 0x0
        public static System.Int32 elementId_throttleHat4Down_Right;        // 0x0
        public static System.Int32 elementId_throttleHat4Down;        // 0x0
        public static System.Int32 elementId_throttleHat4Down_Left;        // 0x0
        public static System.Int32 elementId_throttleHat4Left;        // 0x0
        public static System.Int32 elementId_throttleHat4Up_Left;        // 0x0
        public static System.Int32 elementId_leftPedal;        // 0x0
        public static System.Int32 elementId_rightPedal;        // 0x0
        public static System.Int32 elementId_slidePedals;        // 0x0
        public static System.Int32 elementId_stick;        // 0x0
        public static System.Int32 elementId_stickMiniStick1;        // 0x0
        public static System.Int32 elementId_stickMiniStick2;        // 0x0
        public static System.Int32 elementId_stickHat1;        // 0x0
        public static System.Int32 elementId_stickHat2;        // 0x0
        public static System.Int32 elementId_stickHat3;        // 0x0
        public static System.Int32 elementId_stickHat4;        // 0x0
        public static System.Int32 elementId_throttle1;        // 0x0
        public static System.Int32 elementId_throttle2;        // 0x0
        public static System.Int32 elementId_throttleMiniStick;        // 0x0
        public static System.Int32 elementId_throttleHat1;        // 0x0
        public static System.Int32 elementId_throttleHat2;        // 0x0
        public static System.Int32 elementId_throttleHat3;        // 0x0
        public static System.Int32 elementId_throttleHat4;        // 0x0

        // Methods
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickTrigger() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickTriggerStage2() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickPinkyButton() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickPinkyTrigger() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton1() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton2() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton3() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton4() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton5() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton6() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton7() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton8() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton9() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton10() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton1() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton2() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton3() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton4() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton5() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton6() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton7() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton8() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton9() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton10() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton11() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton12() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_mode1() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_mode2() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_mode3() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton1() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton2() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton3() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton4() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton5() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton6() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton7() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton8() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton9() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton10() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton1() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton2() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton3() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton4() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton5() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton6() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton7() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton8() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton9() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton10() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton11() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton12() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton13() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton14() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton15() { }
        private Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider1() { }
        private Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider2() { }
        private Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider3() { }
        private Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider4() { }
        private Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial1() { }
        private Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial2() { }
        private Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial3() { }
        private Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial4() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Forward() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Back() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Press() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Forward() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Back() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Press() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Forward() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Back() { }
        private Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Press() { }
        private Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_leftPedal() { }
        private Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_rightPedal() { }
        private Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_slidePedals() { }
        private Rewired.IControllerTemplateStick Rewired.IHOTASTemplate.get_stick() { }
        private Rewired.IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_stickMiniStick1() { }
        private Rewired.IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_stickMiniStick2() { }
        private Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat1() { }
        private Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat2() { }
        private Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat3() { }
        private Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat4() { }
        private Rewired.IControllerTemplateThrottle Rewired.IHOTASTemplate.get_throttle1() { }
        private Rewired.IControllerTemplateThrottle Rewired.IHOTASTemplate.get_throttle2() { }
        private Rewired.IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_throttleMiniStick() { }
        private Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat1() { }
        private Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat2() { }
        private Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat3() { }
        private Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat4() { }
        private System.Void .ctor(System.Object payload) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000B
    public class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;        // 0x0
        public static System.Int32 elementId_rotateYoke;        // 0x0
        public static System.Int32 elementId_yokeZ;        // 0x0
        public static System.Int32 elementId_leftPaddle;        // 0x0
        public static System.Int32 elementId_rightPaddle;        // 0x0
        public static System.Int32 elementId_lever1Axis;        // 0x0
        public static System.Int32 elementId_lever1MinDetent;        // 0x0
        public static System.Int32 elementId_lever2Axis;        // 0x0
        public static System.Int32 elementId_lever2MinDetent;        // 0x0
        public static System.Int32 elementId_lever3Axis;        // 0x0
        public static System.Int32 elementId_lever3MinDetent;        // 0x0
        public static System.Int32 elementId_lever4Axis;        // 0x0
        public static System.Int32 elementId_lever4MinDetent;        // 0x0
        public static System.Int32 elementId_lever5Axis;        // 0x0
        public static System.Int32 elementId_lever5MinDetent;        // 0x0
        public static System.Int32 elementId_leftGripButton1;        // 0x0
        public static System.Int32 elementId_leftGripButton2;        // 0x0
        public static System.Int32 elementId_leftGripButton3;        // 0x0
        public static System.Int32 elementId_leftGripButton4;        // 0x0
        public static System.Int32 elementId_leftGripButton5;        // 0x0
        public static System.Int32 elementId_leftGripButton6;        // 0x0
        public static System.Int32 elementId_rightGripButton1;        // 0x0
        public static System.Int32 elementId_rightGripButton2;        // 0x0
        public static System.Int32 elementId_rightGripButton3;        // 0x0
        public static System.Int32 elementId_rightGripButton4;        // 0x0
        public static System.Int32 elementId_rightGripButton5;        // 0x0
        public static System.Int32 elementId_rightGripButton6;        // 0x0
        public static System.Int32 elementId_centerButton1;        // 0x0
        public static System.Int32 elementId_centerButton2;        // 0x0
        public static System.Int32 elementId_centerButton3;        // 0x0
        public static System.Int32 elementId_centerButton4;        // 0x0
        public static System.Int32 elementId_centerButton5;        // 0x0
        public static System.Int32 elementId_centerButton6;        // 0x0
        public static System.Int32 elementId_centerButton7;        // 0x0
        public static System.Int32 elementId_centerButton8;        // 0x0
        public static System.Int32 elementId_wheel1Up;        // 0x0
        public static System.Int32 elementId_wheel1Down;        // 0x0
        public static System.Int32 elementId_wheel1Press;        // 0x0
        public static System.Int32 elementId_wheel2Up;        // 0x0
        public static System.Int32 elementId_wheel2Down;        // 0x0
        public static System.Int32 elementId_wheel2Press;        // 0x0
        public static System.Int32 elementId_leftGripHatUp;        // 0x0
        public static System.Int32 elementId_leftGripHatUpRight;        // 0x0
        public static System.Int32 elementId_leftGripHatRight;        // 0x0
        public static System.Int32 elementId_leftGripHatDownRight;        // 0x0
        public static System.Int32 elementId_leftGripHatDown;        // 0x0
        public static System.Int32 elementId_leftGripHatDownLeft;        // 0x0
        public static System.Int32 elementId_leftGripHatLeft;        // 0x0
        public static System.Int32 elementId_leftGripHatUpLeft;        // 0x0
        public static System.Int32 elementId_rightGripHatUp;        // 0x0
        public static System.Int32 elementId_rightGripHatUpRight;        // 0x0
        public static System.Int32 elementId_rightGripHatRight;        // 0x0
        public static System.Int32 elementId_rightGripHatDownRight;        // 0x0
        public static System.Int32 elementId_rightGripHatDown;        // 0x0
        public static System.Int32 elementId_rightGripHatDownLeft;        // 0x0
        public static System.Int32 elementId_rightGripHatLeft;        // 0x0
        public static System.Int32 elementId_rightGripHatUpLeft;        // 0x0
        public static System.Int32 elementId_consoleButton1;        // 0x0
        public static System.Int32 elementId_consoleButton2;        // 0x0
        public static System.Int32 elementId_consoleButton3;        // 0x0
        public static System.Int32 elementId_consoleButton4;        // 0x0
        public static System.Int32 elementId_consoleButton5;        // 0x0
        public static System.Int32 elementId_consoleButton6;        // 0x0
        public static System.Int32 elementId_consoleButton7;        // 0x0
        public static System.Int32 elementId_consoleButton8;        // 0x0
        public static System.Int32 elementId_consoleButton9;        // 0x0
        public static System.Int32 elementId_consoleButton10;        // 0x0
        public static System.Int32 elementId_mode1;        // 0x0
        public static System.Int32 elementId_mode2;        // 0x0
        public static System.Int32 elementId_mode3;        // 0x0
        public static System.Int32 elementId_yoke;        // 0x0
        public static System.Int32 elementId_lever1;        // 0x0
        public static System.Int32 elementId_lever2;        // 0x0
        public static System.Int32 elementId_lever3;        // 0x0
        public static System.Int32 elementId_lever4;        // 0x0
        public static System.Int32 elementId_lever5;        // 0x0
        public static System.Int32 elementId_leftGripHat;        // 0x0
        public static System.Int32 elementId_rightGripHat;        // 0x0

        // Methods
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftPaddle() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightPaddle() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton1() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton2() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton3() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton4() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton5() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton6() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton1() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton2() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton3() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton4() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton5() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton6() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton1() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton2() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton3() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton4() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton5() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton6() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton7() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton8() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Up() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Down() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Press() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Up() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Down() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Press() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton1() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton2() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton3() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton4() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton5() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton6() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton7() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton8() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton9() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton10() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode1() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode2() { }
        private Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode3() { }
        private Rewired.IControllerTemplateYoke Rewired.IFlightYokeTemplate.get_yoke() { }
        private Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever1() { }
        private Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever2() { }
        private Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever3() { }
        private Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever4() { }
        private Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever5() { }
        private Rewired.IControllerTemplateHat Rewired.IFlightYokeTemplate.get_leftGripHat() { }
        private Rewired.IControllerTemplateHat Rewired.IFlightYokeTemplate.get_rightGripHat() { }
        private System.Void .ctor(System.Object payload) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000C
    public class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;        // 0x0
        public static System.Int32 elementId_leftPedal;        // 0x0
        public static System.Int32 elementId_rightPedal;        // 0x0
        public static System.Int32 elementId_slide;        // 0x0

        // Methods
        private Rewired.IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_leftPedal() { }
        private Rewired.IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_rightPedal() { }
        private Rewired.IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_slide() { }
        private System.Void .ctor(System.Object payload) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate
    {
        // Fields
        public static readonly System.Guid typeGuid;        // 0x0
        public static System.Int32 elementId_positionX;        // 0x0
        public static System.Int32 elementId_positionY;        // 0x0
        public static System.Int32 elementId_positionZ;        // 0x0
        public static System.Int32 elementId_rotationX;        // 0x0
        public static System.Int32 elementId_rotationY;        // 0x0
        public static System.Int32 elementId_rotationZ;        // 0x0
        public static System.Int32 elementId_throttle1Axis;        // 0x0
        public static System.Int32 elementId_throttle1MinDetent;        // 0x0
        public static System.Int32 elementId_throttle2Axis;        // 0x0
        public static System.Int32 elementId_throttle2MinDetent;        // 0x0
        public static System.Int32 elementId_extraAxis1;        // 0x0
        public static System.Int32 elementId_extraAxis2;        // 0x0
        public static System.Int32 elementId_extraAxis3;        // 0x0
        public static System.Int32 elementId_extraAxis4;        // 0x0
        public static System.Int32 elementId_button1;        // 0x0
        public static System.Int32 elementId_button2;        // 0x0
        public static System.Int32 elementId_button3;        // 0x0
        public static System.Int32 elementId_button4;        // 0x0
        public static System.Int32 elementId_button5;        // 0x0
        public static System.Int32 elementId_button6;        // 0x0
        public static System.Int32 elementId_button7;        // 0x0
        public static System.Int32 elementId_button8;        // 0x0
        public static System.Int32 elementId_button9;        // 0x0
        public static System.Int32 elementId_button10;        // 0x0
        public static System.Int32 elementId_button11;        // 0x0
        public static System.Int32 elementId_button12;        // 0x0
        public static System.Int32 elementId_button13;        // 0x0
        public static System.Int32 elementId_button14;        // 0x0
        public static System.Int32 elementId_button15;        // 0x0
        public static System.Int32 elementId_button16;        // 0x0
        public static System.Int32 elementId_button17;        // 0x0
        public static System.Int32 elementId_button18;        // 0x0
        public static System.Int32 elementId_button19;        // 0x0
        public static System.Int32 elementId_button20;        // 0x0
        public static System.Int32 elementId_button21;        // 0x0
        public static System.Int32 elementId_button22;        // 0x0
        public static System.Int32 elementId_button23;        // 0x0
        public static System.Int32 elementId_button24;        // 0x0
        public static System.Int32 elementId_button25;        // 0x0
        public static System.Int32 elementId_button26;        // 0x0
        public static System.Int32 elementId_button27;        // 0x0
        public static System.Int32 elementId_button28;        // 0x0
        public static System.Int32 elementId_button29;        // 0x0
        public static System.Int32 elementId_button30;        // 0x0
        public static System.Int32 elementId_button31;        // 0x0
        public static System.Int32 elementId_button32;        // 0x0
        public static System.Int32 elementId_hat1Up;        // 0x0
        public static System.Int32 elementId_hat1UpRight;        // 0x0
        public static System.Int32 elementId_hat1Right;        // 0x0
        public static System.Int32 elementId_hat1DownRight;        // 0x0
        public static System.Int32 elementId_hat1Down;        // 0x0
        public static System.Int32 elementId_hat1DownLeft;        // 0x0
        public static System.Int32 elementId_hat1Left;        // 0x0
        public static System.Int32 elementId_hat1UpLeft;        // 0x0
        public static System.Int32 elementId_hat2Up;        // 0x0
        public static System.Int32 elementId_hat2UpRight;        // 0x0
        public static System.Int32 elementId_hat2Right;        // 0x0
        public static System.Int32 elementId_hat2DownRight;        // 0x0
        public static System.Int32 elementId_hat2Down;        // 0x0
        public static System.Int32 elementId_hat2DownLeft;        // 0x0
        public static System.Int32 elementId_hat2Left;        // 0x0
        public static System.Int32 elementId_hat2UpLeft;        // 0x0
        public static System.Int32 elementId_hat1;        // 0x0
        public static System.Int32 elementId_hat2;        // 0x0
        public static System.Int32 elementId_throttle1;        // 0x0
        public static System.Int32 elementId_throttle2;        // 0x0
        public static System.Int32 elementId_stick;        // 0x0

        // Methods
        private Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis1() { }
        private Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis2() { }
        private Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis3() { }
        private Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis4() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button1() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button2() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button3() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button4() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button5() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button6() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button7() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button8() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button9() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button10() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button11() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button12() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button13() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button14() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button15() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button16() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button17() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button18() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button19() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button20() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button21() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button22() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button23() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button24() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button25() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button26() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button27() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button28() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button29() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button30() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button31() { }
        private Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button32() { }
        private Rewired.IControllerTemplateHat Rewired.ISixDofControllerTemplate.get_hat1() { }
        private Rewired.IControllerTemplateHat Rewired.ISixDofControllerTemplate.get_hat2() { }
        private Rewired.IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.get_throttle1() { }
        private Rewired.IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.get_throttle2() { }
        private Rewired.IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.get_stick() { }
        private System.Void .ctor(System.Object payload) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000E
    public class InputManager : InputManager_Base
    {
        // Fields
        private System.Boolean ignoreRecompile;        // 0x50

        // Methods
        private System.Void OnInitialized() { }
        private System.Void OnDeinitialized() { }
        private System.Void DetectPlatform() { }
        private System.Void CheckRecompile() { }
        private Rewired.Utils.Interfaces.IExternalTools GetExternalTools() { }
        private System.Boolean CheckDeviceName(System.String searchPattern, System.String deviceName, System.String deviceModel) { }
        private System.Void SubscribeEvents() { }
        private System.Void UnsubscribeEvents() { }
        private System.Void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode) { }
        private System.Void .ctor() { }

    }

}

namespace Rewired.Data
{

    // TypeToken: 0x2000010
    public class UserDataStore_File : UserDataStore_KeyValue
    {
        // Fields
        private static readonly System.String thisScriptName;        // 0x0
        private static System.String logPrefix;        // 0x0
        private static System.String defaultExtensionText;        // 0x0
        private static System.String defaultExtensionBinary;        // 0x0
        private static System.String defaultFileName;        // 0x0
        private System.String _fileName;        // 0x38
        private Rewired.Data.UserDataStore_File.DataFormat _dataFormat;        // 0x40
        private System.String __directory;        // 0x48
        private Rewired.Data.UserDataStore_File.DataStore _dataStore;        // 0x50
        private Rewired.Data.UserDataStore_File.IDataHandler __dataHandler;        // 0x58
        private System.Boolean _initialized;        // 0x60

        // Methods
        private System.String get_directory() { }
        private System.Void set_directory(System.String value) { }
        private System.String get_fileName() { }
        private System.Void set_fileName(System.String value) { }
        private Rewired.Data.UserDataStore_File.DataFormat get_dataFormat() { }
        private System.Void set_dataFormat(Rewired.Data.UserDataStore_File.DataFormat value) { }
        private Rewired.Data.UserDataStore_File.IDataHandler get_dataHandler() { }
        private System.Void set_dataHandler(Rewired.Data.UserDataStore_File.IDataHandler value) { }
        private Rewired.Data.UserDataStore_KeyValue.IDataStore get_dataStore() { }
        private System.Void SetInitialValues() { }
        private System.Void OnInitialize() { }
        private System.Void OnDataSourceChanged() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private Rewired.Data.UserDataStore_File.DataFormat <get_dataHandler>b__17_0() { }

    }

    // TypeToken: 0x2000018
    public class UserDataStore_KeyValue : UserDataStore
    {
        // Fields
        private static readonly System.String thisScriptName;        // 0x0
        private static System.String logPrefix;        // 0x0
        private static System.String key_controllerAssignments;        // 0x0
        private static System.Int32 controllerMapKeyVersion;        // 0x0
        private System.Boolean _isEnabled;        // 0x18
        private System.Boolean _loadDataOnStart;        // 0x19
        private System.Boolean _loadJoystickAssignments;        // 0x1A
        private System.Boolean _loadKeyboardAssignments;        // 0x1B
        private System.Boolean _loadMouseAssignments;        // 0x1C
        private System.Boolean _allowImpreciseJoystickAssignmentMatching;        // 0x1D
        private System.Boolean _deferredJoystickAssignmentLoadPending;        // 0x1E
        private System.Boolean _wasJoystickEverDetected;        // 0x1F
        private System.Collections.Generic.List<System.Int32> __allActionIds;        // 0x20
        private System.String __allActionIdsString;        // 0x28
        private readonly System.Text.StringBuilder _sb;        // 0x30

        // Methods
        private System.Boolean get_isEnabled() { }
        private System.Void set_isEnabled(System.Boolean value) { }
        private System.Boolean get_loadDataOnStart() { }
        private System.Void set_loadDataOnStart(System.Boolean value) { }
        private System.Boolean get_loadJoystickAssignments() { }
        private System.Void set_loadJoystickAssignments(System.Boolean value) { }
        private System.Boolean get_loadKeyboardAssignments() { }
        private System.Void set_loadKeyboardAssignments(System.Boolean value) { }
        private System.Boolean get_loadMouseAssignments() { }
        private System.Void set_loadMouseAssignments(System.Boolean value) { }
        private Rewired.Data.UserDataStore_KeyValue.IDataStore get_dataStore() { }
        private System.Boolean get_loadControllerAssignments() { }
        private System.Collections.Generic.List<System.Int32> get_allActionIds() { }
        private System.String get_allActionIdsString() { }
        private System.Void Save() { }
        private System.Void SaveControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void SaveControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void SavePlayerData(System.Int32 playerId) { }
        private System.Void SaveInputBehavior(System.Int32 playerId, System.Int32 behaviorId) { }
        private System.Void Load() { }
        private System.Void LoadControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void LoadControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void LoadPlayerData(System.Int32 playerId) { }
        private System.Void LoadInputBehavior(System.Int32 playerId, System.Int32 behaviorId) { }
        private System.Void OnInitialize() { }
        private System.Void OnControllerConnected(Rewired.ControllerStatusChangedEventArgs args) { }
        private System.Void OnControllerPreDisconnect(Rewired.ControllerStatusChangedEventArgs args) { }
        private System.Void OnControllerDisconnected(Rewired.ControllerStatusChangedEventArgs args) { }
        private System.Void SaveControllerMap(System.Int32 playerId, Rewired.ControllerMap controllerMap) { }
        private Rewired.ControllerMap LoadControllerMap(System.Int32 playerId, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        private System.Void ClearSaveData() { }
        private System.Int32 LoadAll() { }
        private System.Int32 LoadPlayerDataNow(System.Int32 playerId) { }
        private System.Int32 LoadPlayerDataNow(Rewired.Player player) { }
        private System.Int32 LoadAllJoystickCalibrationData() { }
        private System.Int32 LoadJoystickCalibrationData(Rewired.Joystick joystick) { }
        private System.Int32 LoadJoystickCalibrationData(System.Int32 joystickId) { }
        private System.Int32 LoadJoystickData(System.Int32 joystickId) { }
        private System.Int32 LoadControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Int32 LoadControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Int32 LoadControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private Rewired.ControllerMap LoadControllerMap(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        private System.Int32 LoadInputBehaviors(System.Int32 playerId) { }
        private System.Int32 LoadInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId) { }
        private System.Int32 LoadInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior) { }
        private System.Boolean LoadControllerAssignmentsNow() { }
        private System.Boolean LoadKeyboardAndMouseAssignmentsNow(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo data) { }
        private System.Boolean LoadJoystickAssignmentsNow(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo data) { }
        private Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo LoadControllerAssignmentData() { }
        private System.Collections.IEnumerator LoadJoystickAssignmentsDeferred() { }
        private System.Void SaveAll() { }
        private System.Void SavePlayerDataNow(System.Int32 playerId) { }
        private System.Void SavePlayerDataNow(Rewired.Player player) { }
        private System.Void SaveAllJoystickCalibrationData() { }
        private System.Void SaveJoystickCalibrationData(System.Int32 joystickId) { }
        private System.Void SaveJoystickCalibrationData(Rewired.Joystick joystick) { }
        private System.Void SaveJoystickData(System.Int32 joystickId) { }
        private System.Void SaveControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void SaveControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void SaveControllerMaps(Rewired.Player player, Rewired.PlayerSaveData playerSaveData) { }
        private System.Void SaveControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void SaveControllerMap(Rewired.Player player, Rewired.ControllerMap controllerMap) { }
        private System.Void SaveInputBehaviors(Rewired.Player player, Rewired.PlayerSaveData playerSaveData) { }
        private System.Void SaveInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId) { }
        private System.Void SaveInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior) { }
        private System.Boolean SaveControllerAssignments() { }
        private System.Void AppendBaseKey(System.Text.StringBuilder sb, Rewired.Player player) { }
        private System.String GetControllerMapKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion) { }
        private System.String GetControllerMapKnownActionIdsKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion) { }
        private System.Void AppendControllerMapKeyCommonSuffix(System.Text.StringBuilder sb, Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 keyVersion) { }
        private System.String GetJoystickCalibrationMapKey(Rewired.Joystick joystick) { }
        private System.String GetInputBehaviorKey(Rewired.Player player, System.Int32 inputBehaviorId) { }
        private System.String GetControllerMapJson(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        private System.Collections.Generic.List<System.Int32> GetControllerMapKnownActionIds(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        private System.String GetJoystickCalibrationMapJson(Rewired.Joystick joystick) { }
        private System.String GetInputBehaviorJson(Rewired.Player player, System.Int32 id) { }
        private System.Void AddDefaultMappingsForNewActions(Rewired.ControllerIdentifier controllerIdentifier, Rewired.ControllerMap controllerMap, System.Collections.Generic.List<System.Int32> knownActionIds) { }
        private Rewired.Joystick FindJoystickPrecise(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) { }
        private System.Boolean TryFindJoysticksImprecise(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, System.Collections.Generic.List<Rewired.Joystick>& matches) { }
        private System.Void RefreshLayoutManager(System.Int32 playerId) { }
        private System.Int32 GetDuplicateIndex(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier) { }
        private System.Boolean TryGetString(Rewired.Data.UserDataStore_KeyValue.IDataStore store, System.String key, System.String& result) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000022
    public class UserDataStore_PlayerPrefs : UserDataStore
    {
        // Fields
        private static System.String thisScriptName;        // 0x0
        private static System.String logPrefix;        // 0x0
        private static System.String editorLoadedMessage;        // 0x0
        private static System.String playerPrefsKeySuffix_controllerAssignments;        // 0x0
        private static System.Int32 controllerMapPPKeyVersion_original;        // 0x0
        private static System.Int32 controllerMapPPKeyVersion_includeDuplicateJoystickIndex;        // 0x0
        private static System.Int32 controllerMapPPKeyVersion_supportDisconnectedControllers;        // 0x0
        private static System.Int32 controllerMapPPKeyVersion_includeFormatVersion;        // 0x0
        private static System.Int32 controllerMapPPKeyVersion;        // 0x0
        private System.Boolean isEnabled;        // 0x18
        private System.Boolean loadDataOnStart;        // 0x19
        private System.Boolean loadJoystickAssignments;        // 0x1A
        private System.Boolean loadKeyboardAssignments;        // 0x1B
        private System.Boolean loadMouseAssignments;        // 0x1C
        private System.String playerPrefsKeyPrefix;        // 0x20
        private System.Boolean allowImpreciseJoystickAssignmentMatching;        // 0x28
        private System.Boolean deferredJoystickAssignmentLoadPending;        // 0x29
        private System.Boolean wasJoystickEverDetected;        // 0x2A
        private System.Collections.Generic.List<System.Int32> __allActionIds;        // 0x30
        private System.String __allActionIdsString;        // 0x38

        // Methods
        private System.Boolean get_IsEnabled() { }
        private System.Void set_IsEnabled(System.Boolean value) { }
        private System.Boolean get_LoadDataOnStart() { }
        private System.Void set_LoadDataOnStart(System.Boolean value) { }
        private System.Boolean get_LoadJoystickAssignments() { }
        private System.Void set_LoadJoystickAssignments(System.Boolean value) { }
        private System.Boolean get_LoadKeyboardAssignments() { }
        private System.Void set_LoadKeyboardAssignments(System.Boolean value) { }
        private System.Boolean get_LoadMouseAssignments() { }
        private System.Void set_LoadMouseAssignments(System.Boolean value) { }
        private System.String get_PlayerPrefsKeyPrefix() { }
        private System.Void set_PlayerPrefsKeyPrefix(System.String value) { }
        private System.String get_playerPrefsKey_controllerAssignments() { }
        private System.Boolean get_loadControllerAssignments() { }
        private System.Collections.Generic.List<System.Int32> get_allActionIds() { }
        private System.String get_allActionIdsString() { }
        private System.Void Save() { }
        private System.Void SaveControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void SaveControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void SavePlayerData(System.Int32 playerId) { }
        private System.Void SaveInputBehavior(System.Int32 playerId, System.Int32 behaviorId) { }
        private System.Void Load() { }
        private System.Void LoadControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void LoadControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void LoadPlayerData(System.Int32 playerId) { }
        private System.Void LoadInputBehavior(System.Int32 playerId, System.Int32 behaviorId) { }
        private System.Void OnInitialize() { }
        private System.Void OnControllerConnected(Rewired.ControllerStatusChangedEventArgs args) { }
        private System.Void OnControllerPreDisconnect(Rewired.ControllerStatusChangedEventArgs args) { }
        private System.Void OnControllerDisconnected(Rewired.ControllerStatusChangedEventArgs args) { }
        private System.Void SaveControllerMap(System.Int32 playerId, Rewired.ControllerMap controllerMap) { }
        private Rewired.ControllerMap LoadControllerMap(System.Int32 playerId, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        private System.Int32 LoadAll() { }
        private System.Int32 LoadPlayerDataNow(System.Int32 playerId) { }
        private System.Int32 LoadPlayerDataNow(Rewired.Player player) { }
        private System.Int32 LoadAllJoystickCalibrationData() { }
        private System.Int32 LoadJoystickCalibrationData(Rewired.Joystick joystick) { }
        private System.Int32 LoadJoystickCalibrationData(System.Int32 joystickId) { }
        private System.Int32 LoadJoystickData(System.Int32 joystickId) { }
        private System.Int32 LoadControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Int32 LoadControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Int32 LoadControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private Rewired.ControllerMap LoadControllerMap(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        private System.Int32 LoadInputBehaviors(System.Int32 playerId) { }
        private System.Int32 LoadInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId) { }
        private System.Int32 LoadInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior) { }
        private System.Boolean LoadControllerAssignmentsNow() { }
        private System.Boolean LoadKeyboardAndMouseAssignmentsNow(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data) { }
        private System.Boolean LoadJoystickAssignmentsNow(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data) { }
        private Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData() { }
        private System.Collections.IEnumerator LoadJoystickAssignmentsDeferred() { }
        private System.Void SaveAll() { }
        private System.Void SavePlayerDataNow(System.Int32 playerId) { }
        private System.Void SavePlayerDataNow(Rewired.Player player) { }
        private System.Void SaveAllJoystickCalibrationData() { }
        private System.Void SaveJoystickCalibrationData(System.Int32 joystickId) { }
        private System.Void SaveJoystickCalibrationData(Rewired.Joystick joystick) { }
        private System.Void SaveJoystickData(System.Int32 joystickId) { }
        private System.Void SaveControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void SaveControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void SaveControllerMaps(Rewired.Player player, Rewired.PlayerSaveData playerSaveData) { }
        private System.Void SaveControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId) { }
        private System.Void SaveControllerMap(Rewired.Player player, Rewired.ControllerMap controllerMap) { }
        private System.Void SaveInputBehaviors(Rewired.Player player, Rewired.PlayerSaveData playerSaveData) { }
        private System.Void SaveInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId) { }
        private System.Void SaveInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior) { }
        private System.Boolean SaveControllerAssignments() { }
        private System.Boolean ControllerAssignmentSaveDataExists() { }
        private System.String GetBasePlayerPrefsKey(Rewired.Player player) { }
        private System.String GetControllerMapPlayerPrefsKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion) { }
        private System.String GetControllerMapKnownActionIdsPlayerPrefsKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion) { }
        private System.String GetControllerMapPlayerPrefsKeyCommonSuffix(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion) { }
        private System.String GetJoystickCalibrationMapPlayerPrefsKey(Rewired.Joystick joystick) { }
        private System.String GetInputBehaviorPlayerPrefsKey(Rewired.Player player, System.Int32 inputBehaviorId) { }
        private System.String GetControllerMapXml(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        private System.Collections.Generic.List<System.Int32> GetControllerMapKnownActionIds(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId) { }
        private System.String GetJoystickCalibrationMapXml(Rewired.Joystick joystick) { }
        private System.String GetInputBehaviorXml(Rewired.Player player, System.Int32 id) { }
        private System.Void AddDefaultMappingsForNewActions(Rewired.ControllerIdentifier controllerIdentifier, Rewired.ControllerMap controllerMap, System.Collections.Generic.List<System.Int32> knownActionIds) { }
        private Rewired.Joystick FindJoystickPrecise(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) { }
        private System.Boolean TryFindJoysticksImprecise(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, System.Collections.Generic.List<Rewired.Joystick>& matches) { }
        private System.Int32 GetDuplicateIndex(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier) { }
        private System.Void RefreshLayoutManager(System.Int32 playerId) { }
        private System.Type GetControllerMapType(Rewired.ControllerType controllerType) { }
        private System.Void .ctor() { }

    }

}

namespace Rewired.Integration.UnityUI
{

    // TypeToken: 0x200002C
    public class PlayerPointerEventData : PointerEventData
    {
        // Fields
        private System.Int32 <playerId>k__BackingField;        // 0x160
        private System.Int32 <inputSourceIndex>k__BackingField;        // 0x164
        private Rewired.UI.IMouseInputSource <mouseSource>k__BackingField;        // 0x168
        private Rewired.UI.ITouchInputSource <touchSource>k__BackingField;        // 0x170
        private Rewired.Integration.UnityUI.PointerEventType <sourceType>k__BackingField;        // 0x178
        private System.Int32 <buttonIndex>k__BackingField;        // 0x17C

        // Methods
        private System.Int32 get_playerId() { }
        private System.Void set_playerId(System.Int32 value) { }
        private System.Int32 get_inputSourceIndex() { }
        private System.Void set_inputSourceIndex(System.Int32 value) { }
        private Rewired.UI.IMouseInputSource get_mouseSource() { }
        private System.Void set_mouseSource(Rewired.UI.IMouseInputSource value) { }
        private Rewired.UI.ITouchInputSource get_touchSource() { }
        private System.Void set_touchSource(Rewired.UI.ITouchInputSource value) { }
        private Rewired.Integration.UnityUI.PointerEventType get_sourceType() { }
        private System.Void set_sourceType(Rewired.Integration.UnityUI.PointerEventType value) { }
        private System.Int32 get_buttonIndex() { }
        private System.Void set_buttonIndex(System.Int32 value) { }
        private System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200002D
    public class RewiredEventSystem : EventSystem
    {
        // Fields
        private System.Boolean _alwaysUpdate;        // 0x50

        // Methods
        private System.Boolean get_alwaysUpdate() { }
        private System.Void set_alwaysUpdate(System.Boolean value) { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class RewiredPointerInputModule : BaseInputModule
    {
        // Fields
        public static System.Int32 kMouseLeftId;        // 0x0
        public static System.Int32 kMouseRightId;        // 0x0
        public static System.Int32 kMouseMiddleId;        // 0x0
        public static System.Int32 kFakeTouchesId;        // 0x0
        private static System.Int32 customButtonsStartingId;        // 0x0
        private static System.Int32 customButtonsMaxCount;        // 0x0
        private static System.Int32 customButtonsLastId;        // 0x0
        private readonly System.Collections.Generic.List<Rewired.UI.IMouseInputSource> m_MouseInputSourcesList;        // 0x48
        private System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,Rewired.Integration.UnityUI.PlayerPointerEventData>[]> m_PlayerPointerData;        // 0x50
        private Rewired.UI.ITouchInputSource m_UserDefaultTouchInputSource;        // 0x58
        private Rewired.Integration.UnityUI.RewiredPointerInputModule.UnityInputSource __m_DefaultInputSource;        // 0x60
        private readonly Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseState m_MouseState;        // 0x68

        // Methods
        private Rewired.Integration.UnityUI.RewiredPointerInputModule.UnityInputSource get_defaultInputSource() { }
        private Rewired.UI.IMouseInputSource get_defaultMouseInputSource() { }
        private Rewired.UI.ITouchInputSource get_defaultTouchInputSource() { }
        private System.Boolean IsDefaultMouse(Rewired.UI.IMouseInputSource mouse) { }
        private Rewired.UI.IMouseInputSource GetMouseInputSource(System.Int32 playerId, System.Int32 mouseIndex) { }
        private System.Void RemoveMouseInputSource(Rewired.UI.IMouseInputSource source) { }
        private System.Void AddMouseInputSource(Rewired.UI.IMouseInputSource source) { }
        private System.Int32 GetMouseInputSourceCount(System.Int32 playerId) { }
        private Rewired.UI.ITouchInputSource GetTouchInputSource(System.Int32 playerId, System.Int32 sourceIndex) { }
        private System.Void RemoveTouchInputSource(Rewired.UI.ITouchInputSource source) { }
        private System.Void AddTouchInputSource(Rewired.UI.ITouchInputSource source) { }
        private System.Int32 GetTouchInputSourceCount(System.Int32 playerId) { }
        private System.Void ClearMouseInputSources() { }
        private System.Boolean get_isMouseSupported() { }
        private System.Boolean IsDefaultPlayer(System.Int32 playerId) { }
        private System.Boolean GetPointerData(System.Int32 playerId, System.Int32 pointerIndex, System.Int32 pointerTypeId, Rewired.Integration.UnityUI.PlayerPointerEventData& data, System.Boolean create, Rewired.Integration.UnityUI.PointerEventType pointerEventType) { }
        private Rewired.Integration.UnityUI.PlayerPointerEventData CreatePointerEventData(System.Int32 playerId, System.Int32 pointerIndex, System.Int32 pointerTypeId, Rewired.Integration.UnityUI.PointerEventType pointerEventType) { }
        private System.Void RemovePointerData(Rewired.Integration.UnityUI.PlayerPointerEventData data) { }
        private Rewired.Integration.UnityUI.PlayerPointerEventData GetTouchPointerEventData(System.Int32 playerId, System.Int32 touchDeviceIndex, UnityEngine.Touch input, System.Boolean& pressed, System.Boolean& released) { }
        private Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseState GetMousePointerEventData(System.Int32 playerId, System.Int32 mouseIndex) { }
        private Rewired.Integration.UnityUI.PlayerPointerEventData GetLastPointerEventData(System.Int32 playerId, System.Int32 pointerIndex, System.Int32 pointerTypeId, System.Boolean ignorePointerTypeId, Rewired.Integration.UnityUI.PointerEventType pointerEventType) { }
        private System.Boolean ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, System.Single threshold, System.Boolean useDragThreshold) { }
        private System.Void ProcessMove(Rewired.Integration.UnityUI.PlayerPointerEventData pointerEvent) { }
        private System.Void ProcessDrag(Rewired.Integration.UnityUI.PlayerPointerEventData pointerEvent) { }
        private System.Boolean IsPointerOverGameObject(System.Int32 pointerTypeId) { }
        private System.Void ClearSelection() { }
        private System.String ToString() { }
        private System.Void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent) { }
        private System.Void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to) { }
        private UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(System.Int32 playerId, System.Int32 mouseIndex, System.Int32 buttonId) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000033
    public struct PointerEventType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Rewired.Integration.UnityUI.PointerEventType Mouse;        // 0x0
        public static Rewired.Integration.UnityUI.PointerEventType Touch;        // 0x0

    }

    // TypeToken: 0x2000034
    public class RewiredStandaloneInputModule : RewiredPointerInputModule
    {
        // Fields
        private static System.String DEFAULT_ACTION_MOVE_HORIZONTAL;        // 0x0
        private static System.String DEFAULT_ACTION_MOVE_VERTICAL;        // 0x0
        private static System.String DEFAULT_ACTION_SUBMIT;        // 0x0
        private static System.String DEFAULT_ACTION_CANCEL;        // 0x0
        private Rewired.InputManager_Base rewiredInputManager;        // 0x70
        private System.Boolean useAllRewiredGamePlayers;        // 0x78
        private System.Boolean useRewiredSystemPlayer;        // 0x79
        private System.Int32[] rewiredPlayerIds;        // 0x80
        private System.Boolean usePlayingPlayersOnly;        // 0x88
        private System.Collections.Generic.List<Rewired.Components.PlayerMouse> playerMice;        // 0x90
        private System.Boolean moveOneElementPerAxisPress;        // 0x98
        private System.Boolean setActionsById;        // 0x99
        private System.Int32 horizontalActionId;        // 0x9C
        private System.Int32 verticalActionId;        // 0xA0
        private System.Int32 submitActionId;        // 0xA4
        private System.Int32 cancelActionId;        // 0xA8
        private System.String m_HorizontalAxis;        // 0xB0
        private System.String m_VerticalAxis;        // 0xB8
        private System.String m_SubmitButton;        // 0xC0
        private System.String m_CancelButton;        // 0xC8
        private System.Single m_InputActionsPerSecond;        // 0xD0
        private System.Single m_RepeatDelay;        // 0xD4
        private System.Boolean m_allowMouseInput;        // 0xD8
        private System.Boolean m_allowMouseInputIfTouchSupported;        // 0xD9
        private System.Boolean m_allowTouchInput;        // 0xDA
        private System.Boolean m_deselectIfBackgroundClicked;        // 0xDB
        private System.Boolean m_deselectBeforeSelecting;        // 0xDC
        private System.Boolean m_ForceModuleActive;        // 0xDD
        private System.Int32[] playerIds;        // 0xE0
        private System.Boolean recompiling;        // 0xE8
        private System.Boolean isTouchSupported;        // 0xE9
        private System.Double m_PrevActionTime;        // 0xF0
        private UnityEngine.Vector2 m_LastMoveVector;        // 0xF8
        private System.Int32 m_ConsecutiveMoveCount;        // 0x100
        private System.Boolean m_HasFocus;        // 0x104

        // Methods
        private Rewired.InputManager_Base get_RewiredInputManager() { }
        private System.Void set_RewiredInputManager(Rewired.InputManager_Base value) { }
        private System.Boolean get_UseAllRewiredGamePlayers() { }
        private System.Void set_UseAllRewiredGamePlayers(System.Boolean value) { }
        private System.Boolean get_UseRewiredSystemPlayer() { }
        private System.Void set_UseRewiredSystemPlayer(System.Boolean value) { }
        private System.Int32[] get_RewiredPlayerIds() { }
        private System.Void set_RewiredPlayerIds(System.Int32[] value) { }
        private System.Boolean get_UsePlayingPlayersOnly() { }
        private System.Void set_UsePlayingPlayersOnly(System.Boolean value) { }
        private System.Collections.Generic.List<Rewired.Components.PlayerMouse> get_PlayerMice() { }
        private System.Void set_PlayerMice(System.Collections.Generic.List<Rewired.Components.PlayerMouse> value) { }
        private System.Boolean get_MoveOneElementPerAxisPress() { }
        private System.Void set_MoveOneElementPerAxisPress(System.Boolean value) { }
        private System.Boolean get_allowMouseInput() { }
        private System.Void set_allowMouseInput(System.Boolean value) { }
        private System.Boolean get_allowMouseInputIfTouchSupported() { }
        private System.Void set_allowMouseInputIfTouchSupported(System.Boolean value) { }
        private System.Boolean get_allowTouchInput() { }
        private System.Void set_allowTouchInput(System.Boolean value) { }
        private System.Boolean get_deselectIfBackgroundClicked() { }
        private System.Void set_deselectIfBackgroundClicked(System.Boolean value) { }
        private System.Boolean get_deselectBeforeSelecting() { }
        private System.Void set_deselectBeforeSelecting(System.Boolean value) { }
        private System.Boolean get_SetActionsById() { }
        private System.Void set_SetActionsById(System.Boolean value) { }
        private System.Int32 get_HorizontalActionId() { }
        private System.Void set_HorizontalActionId(System.Int32 value) { }
        private System.Int32 get_VerticalActionId() { }
        private System.Void set_VerticalActionId(System.Int32 value) { }
        private System.Int32 get_SubmitActionId() { }
        private System.Void set_SubmitActionId(System.Int32 value) { }
        private System.Int32 get_CancelActionId() { }
        private System.Void set_CancelActionId(System.Int32 value) { }
        private System.Boolean get_isMouseSupported() { }
        private System.Boolean get_isTouchAllowed() { }
        private System.Boolean get_allowActivationOnMobileDevice() { }
        private System.Void set_allowActivationOnMobileDevice(System.Boolean value) { }
        private System.Boolean get_forceModuleActive() { }
        private System.Void set_forceModuleActive(System.Boolean value) { }
        private System.Single get_inputActionsPerSecond() { }
        private System.Void set_inputActionsPerSecond(System.Single value) { }
        private System.Single get_repeatDelay() { }
        private System.Void set_repeatDelay(System.Single value) { }
        private System.String get_horizontalAxis() { }
        private System.Void set_horizontalAxis(System.String value) { }
        private System.String get_verticalAxis() { }
        private System.Void set_verticalAxis(System.String value) { }
        private System.String get_submitButton() { }
        private System.Void set_submitButton(System.String value) { }
        private System.String get_cancelButton() { }
        private System.Void set_cancelButton(System.String value) { }
        private System.Void .ctor() { }
        private System.Void Awake() { }
        private System.Void UpdateModule() { }
        private System.Boolean IsModuleSupported() { }
        private System.Boolean ShouldActivateModule() { }
        private System.Void ActivateModule() { }
        private System.Void DeactivateModule() { }
        private System.Void Process() { }
        private System.Boolean ProcessTouchEvents() { }
        private System.Void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, System.Boolean pressed, System.Boolean released) { }
        private System.Boolean SendSubmitEventToSelectedObject() { }
        private UnityEngine.Vector2 GetRawMoveVector() { }
        private System.Boolean SendMoveEventToSelectedObject() { }
        private System.Void CheckButtonOrKeyMovement(System.Boolean& downHorizontal, System.Boolean& downVertical) { }
        private System.Void ProcessMouseEvents() { }
        private System.Void ProcessMouseEvent(System.Int32 playerId, System.Int32 pointerIndex) { }
        private System.Boolean SendUpdateEventToSelectedObject() { }
        private System.Void ProcessMousePress(Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseButtonEventData data) { }
        private System.Void HandleMouseTouchDeselectionOnSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent) { }
        private System.Void OnApplicationFocus(System.Boolean hasFocus) { }
        private System.Boolean ShouldIgnoreEventsOnNoFocus() { }
        private System.Void OnDestroy() { }
        private System.Boolean IsDefaultPlayer(System.Int32 playerId) { }
        private System.Void InitializeRewired() { }
        private System.Void SetupRewiredVars() { }
        private System.Void SetUpRewiredPlayerMice() { }
        private System.Void SetUpRewiredActions() { }
        private System.Boolean GetButton(Rewired.Player player, System.Int32 actionId) { }
        private System.Boolean GetButtonDown(Rewired.Player player, System.Int32 actionId) { }
        private System.Boolean GetNegativeButton(Rewired.Player player, System.Int32 actionId) { }
        private System.Boolean GetNegativeButtonDown(Rewired.Player player, System.Int32 actionId) { }
        private System.Single GetAxis(Rewired.Player player, System.Int32 actionId) { }
        private System.Void CheckEditorRecompile() { }
        private System.Void OnEditorRecompile() { }
        private System.Void ClearRewiredVars() { }
        private System.Boolean DidAnyMouseMove() { }
        private System.Boolean GetMouseButtonDownOnAnyMouse(System.Int32 buttonIndex) { }
        private System.Void OnRewiredInitialized() { }
        private System.Void OnRewiredShutDown() { }

    }

}

namespace Rewired.Internal
{

    // TypeToken: 0x200002B
    public class ControllerTemplateFactory
    {
        // Fields
        private static readonly System.Type[] _defaultTemplateTypes;        // 0x0
        private static readonly System.Type[] _defaultTemplateInterfaceTypes;        // 0x8

        // Methods
        private System.Type[] get_templateTypes() { }
        private System.Type[] get_templateInterfaceTypes() { }
        private Rewired.IControllerTemplate Create(System.Guid typeGuid, System.Object payload) { }
        private System.Void .cctor() { }

    }

}

namespace Rewired.Localization
{

    // TypeToken: 0x2000036
    public class LocalizedStringProvider : LocalizedStringProviderBase
    {
        // Fields
        private UnityEngine.TextAsset _localizedStringsFile;        // 0x20
        private System.Collections.Generic.Dictionary<System.String,System.String> _dictionary;        // 0x28
        private System.Boolean _initialized;        // 0x30

        // Methods
        private System.Collections.Generic.Dictionary<System.String,System.String> get_dictionary() { }
        private System.Void set_dictionary(System.Collections.Generic.Dictionary<System.String,System.String> value) { }
        private UnityEngine.TextAsset get_localizedStringsFile() { }
        private System.Void set_localizedStringsFile(UnityEngine.TextAsset value) { }
        private System.Boolean get_initialized() { }
        private System.Boolean Initialize() { }
        private System.Boolean TryLoadLocalizedStringData() { }
        private System.Boolean TryGetLocalizedString(System.String key, System.String& result) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public class LocalizedStringProviderBase : MonoBehaviour, ILocalizedStringProvider
    {
        // Fields
        private System.Boolean _prefetch;        // 0x18

        // Methods
        private System.Boolean get_prefetch() { }
        private System.Void set_prefetch(System.Boolean value) { }
        private System.Boolean get_initialized() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void TrySetLocalizedStringProvider() { }
        private System.Boolean Initialize() { }
        private System.Void Reload() { }
        private System.Boolean TryGetLocalizedString(System.String key, System.String& result) { }
        private System.Boolean Rewired.Interfaces.ILocalizedStringProvider.TryGetLocalizedString(System.String key, System.String& result) { }
        private System.Void .ctor() { }

    }

}

namespace Rewired.Utils
{

    // TypeToken: 0x200000F
    public class ExternalTools, IExternalTools
    {
        // Fields
        private static System.Func<System.Object> _getPlatformInitializerDelegate;        // 0x0
        private System.Boolean _isEditorPaused;        // 0x10
        private System.Action<System.Boolean> _EditorPausedStateChangedEvent;        // 0x18
        private System.Action<System.UInt32,System.Boolean> XboxOneInput_OnGamepadStateChange;        // 0x20

        // Methods
        private System.Func<System.Object> get_getPlatformInitializerDelegate() { }
        private System.Void set_getPlatformInitializerDelegate(System.Func<System.Object> value) { }
        private System.Void .ctor() { }
        private System.Void Destroy() { }
        private System.Boolean get_isEditorPaused() { }
        private System.Void add_EditorPausedStateChangedEvent(System.Action<System.Boolean> value) { }
        private System.Void remove_EditorPausedStateChangedEvent(System.Action<System.Boolean> value) { }
        private System.Object GetPlatformInitializer() { }
        private System.String GetFocusedEditorWindowTitle() { }
        private System.Boolean IsEditorSceneViewFocused() { }
        private System.Boolean LinuxInput_IsJoystickPreconfigured(System.String name) { }
        private System.Void add_XboxOneInput_OnGamepadStateChange(System.Action<System.UInt32,System.Boolean> value) { }
        private System.Void remove_XboxOneInput_OnGamepadStateChange(System.Action<System.UInt32,System.Boolean> value) { }
        private System.Int32 XboxOneInput_GetUserIdForGamepad(System.UInt32 id) { }
        private System.UInt64 XboxOneInput_GetControllerId(System.UInt32 unityJoystickId) { }
        private System.Boolean XboxOneInput_IsGamepadActive(System.UInt32 unityJoystickId) { }
        private System.String XboxOneInput_GetControllerType(System.UInt64 xboxControllerId) { }
        private System.UInt32 XboxOneInput_GetJoystickId(System.UInt64 xboxControllerId) { }
        private System.Void XboxOne_Gamepad_UpdatePlugin() { }
        private System.Boolean XboxOne_Gamepad_SetGamepadVibration(System.UInt64 xboxOneJoystickId, System.Single leftMotor, System.Single rightMotor, System.Single leftTriggerLevel, System.Single rightTriggerLevel) { }
        private System.Void XboxOne_Gamepad_PulseVibrateMotor(System.UInt64 xboxOneJoystickId, System.Int32 motorInt, System.Single startLevel, System.Single endLevel, System.UInt64 durationMS) { }
        private System.Void GetDeviceVIDPIDs(System.Collections.Generic.List<System.Int32>& vids, System.Collections.Generic.List<System.Int32>& pids) { }
        private System.Int32 GetAndroidAPILevel() { }
        private System.Void WindowsStandalone_ForwardRawInput(System.IntPtr rawInputHeaderIndices, System.IntPtr rawInputDataIndices, System.UInt32 indicesCount, System.IntPtr rawInputData, System.UInt32 rawInputDataSize) { }
        private System.Boolean UnityUI_Graphic_GetRaycastTarget(System.Object graphic) { }
        private System.Void UnityUI_Graphic_SetRaycastTarget(System.Object graphic, System.Boolean value) { }
        private System.Boolean get_UnityInput_IsTouchPressureSupported() { }
        private System.Single UnityInput_GetTouchPressure(UnityEngine.Touch& touch) { }
        private System.Single UnityInput_GetTouchMaximumPossiblePressure(UnityEngine.Touch& touch) { }
        private Rewired.IControllerTemplate CreateControllerTemplate(System.Guid typeGuid, System.Object payload) { }
        private System.Type[] GetControllerTemplateTypes() { }
        private System.Type[] GetControllerTemplateInterfaceTypes() { }

    }

}

