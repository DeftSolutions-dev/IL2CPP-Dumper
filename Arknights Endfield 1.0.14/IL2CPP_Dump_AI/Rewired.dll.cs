// ========================================================
// Dumped by @desirepro
// Assembly: Rewired.dll
// Classes:  55
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: DataStore
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,System.Object>_data  // 0x10
  private   readonly System.String                   _absFilePath  // 0x18
  private           Rewired.Data.UserDataStore_File.IDataHandler_dataHandler  // 0x20
METHODS:
  System.Void .ctor(System.String fileName, System.String absDirectory, Rewired.Data.UserDataStore_File.IDataHandler dataHandler)
  System.Boolean TryGetValue(System.String key, System.Object& value)
  System.Boolean SetValue(System.String key, System.Object value)
  System.Boolean Save()
  System.Boolean Load()
  System.Boolean Clear()
END_CLASS

CLASS: LocalFileDataHandler
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private   readonly System.Func<Rewired.Data.UserDataStore_File.DataFormat>_dataFormatDelegate  // 0x10
  private   readonly Rewired.Data.UserDataStore_File.Codec_codec  // 0x18
METHODS:
  System.Void .ctor(System.Func<Rewired.Data.UserDataStore_File.DataFormat> dataFormatDelegate, Rewired.Data.UserDataStore_File.Codec codec)
  System.Boolean Load(System.String absoluteFilePath, System.String& data)
  System.Boolean Save(System.String absoluteFilePath, System.String data)
  System.Boolean Clear(System.String absoluteFilePath)
END_CLASS

CLASS: Codec
TYPE:  class
TOKEN: 0x2000013
FIELDS:
METHODS:
  System.Byte[] Encode(System.String string)
  System.String Decode(System.Byte[] data)
  System.Void .ctor()
END_CLASS

CLASS: UTF8Text
TYPE:  class
TOKEN: 0x2000014
EXTENDS: Codec
FIELDS:
METHODS:
  System.Byte[] Encode(System.String string)
  System.String Decode(System.Byte[] data)
  System.Void .ctor()
END_CLASS

CLASS: CLZF2
TYPE:  class
TOKEN: 0x2000015
EXTENDS: Codec
FIELDS:
  private   readonly Rewired.Utils.Libraries.CLZF2.CLZF2_cLZF2  // 0x10
METHODS:
  System.Void .ctor()
  System.Byte[] Encode(System.String string)
  System.String Decode(System.Byte[] data)
END_CLASS

CLASS: IDataHandler
TYPE:  interface
TOKEN: 0x2000016
FIELDS:
METHODS:
  System.Boolean Load(System.String absoluteFilePath, System.String& data)
  System.Boolean Save(System.String absoluteFilePath, System.String data)
  System.Boolean Clear(System.String absoluteFilePath)
END_CLASS

CLASS: DataFormat
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Rewired.Data.UserDataStore_File.DataFormatText  // 0x0
  public    static  Rewired.Data.UserDataStore_File.DataFormatBinary  // 0x0
METHODS:
END_CLASS

CLASS: PlayerInfo
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    id  // 0x10
  public            System.Boolean                  hasKeyboard  // 0x14
  public            System.Boolean                  hasMouse  // 0x15
  public            Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo[]joysticks  // 0x18
METHODS:
  System.Int32 get_joystickCount()
  System.Int32 IndexOfJoystick(System.Int32 joystickId)
  System.Boolean ContainsJoystick(System.Int32 joystickId)
  System.Void .ctor()
END_CLASS

CLASS: JoystickInfo
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  public            System.Guid                     instanceGuid  // 0x10
  public            System.String                   hardwareIdentifier  // 0x20
  public            System.Int32                    id  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ControllerAssignmentSaveInfo
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  public            Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.PlayerInfo[]players  // 0x10
METHODS:
  System.Int32 get_playerCount()
  System.Void .ctor()
  System.Void .ctor(System.Int32 playerCount)
  System.Int32 IndexOfPlayer(System.Int32 playerId)
  System.Boolean ContainsPlayer(System.Int32 playerId)
END_CLASS

CLASS: JoystickAssignmentHistoryInfo
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  public    readonly Rewired.Joystick                joystick  // 0x10
  public    readonly System.Int32                    oldJoystickId  // 0x18
METHODS:
  System.Void .ctor(Rewired.Joystick joystick, System.Int32 oldJoystickId)
END_CLASS

CLASS: IDataStore
TYPE:  interface
TOKEN: 0x200001D
FIELDS:
METHODS:
  System.Boolean Save()
  System.Boolean Load()
  System.Boolean Clear()
  System.Boolean TryGetValue(System.String key, System.Object& result)
  System.Boolean SetValue(System.String key, System.Object value)
END_CLASS

CLASS: PlayerInfo
TYPE:  class
TOKEN: 0x2000024
FIELDS:
  public            System.Int32                    id  // 0x10
  public            System.Boolean                  hasKeyboard  // 0x14
  public            System.Boolean                  hasMouse  // 0x15
  public            Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[]joysticks  // 0x18
METHODS:
  System.Int32 get_joystickCount()
  System.Int32 IndexOfJoystick(System.Int32 joystickId)
  System.Boolean ContainsJoystick(System.Int32 joystickId)
  System.Void .ctor()
END_CLASS

CLASS: JoystickInfo
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  public            System.Guid                     instanceGuid  // 0x10
  public            System.String                   hardwareIdentifier  // 0x20
  public            System.Int32                    id  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ControllerAssignmentSaveInfo
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  public            Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[]players  // 0x10
METHODS:
  System.Int32 get_playerCount()
  System.Void .ctor()
  System.Void .ctor(System.Int32 playerCount)
  System.Int32 IndexOfPlayer(System.Int32 playerId)
  System.Boolean ContainsPlayer(System.Int32 playerId)
END_CLASS

CLASS: JoystickAssignmentHistoryInfo
TYPE:  class
TOKEN: 0x2000026
FIELDS:
  public    readonly Rewired.Joystick                joystick  // 0x10
  public    readonly System.Int32                    oldJoystickId  // 0x18
METHODS:
  System.Void .ctor(Rewired.Joystick joystick, System.Int32 oldJoystickId)
END_CLASS

CLASS: MouseState
TYPE:  class
TOKEN: 0x200002F
FIELDS:
  private           System.Collections.Generic.List<Rewired.Integration.UnityUI.RewiredPointerInputModule.ButtonState>m_TrackedButtons  // 0x10
METHODS:
  System.Boolean AnyPressesThisFrame()
  System.Boolean AnyReleasesThisFrame()
  Rewired.Integration.UnityUI.RewiredPointerInputModule.ButtonState GetButtonState(System.Int32 button)
  System.Void SetButtonState(System.Int32 button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, Rewired.Integration.UnityUI.PlayerPointerEventData data)
  System.Void .ctor()
END_CLASS

CLASS: MouseButtonEventData
TYPE:  class
TOKEN: 0x2000030
FIELDS:
  public            UnityEngine.EventSystems.PointerEventData.FramePressStatebuttonState  // 0x10
  public            Rewired.Integration.UnityUI.PlayerPointerEventDatabuttonData  // 0x18
METHODS:
  System.Boolean PressedThisFrame()
  System.Boolean ReleasedThisFrame()
  System.Void .ctor()
END_CLASS

CLASS: ButtonState
TYPE:  class
TOKEN: 0x2000031
FIELDS:
  private           System.Int32                    m_Button  // 0x10
  private           Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseButtonEventDatam_EventData  // 0x18
METHODS:
  Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseButtonEventData get_eventData()
  System.Void set_eventData(Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseButtonEventData value)
  System.Int32 get_button()
  System.Void set_button(System.Int32 value)
  System.Void .ctor()
END_CLASS

CLASS: UnityInputSource
TYPE:  class
TOKEN: 0x2000032
FIELDS:
  private           UnityEngine.Vector2             m_MousePosition  // 0x10
  private           UnityEngine.Vector2             m_MousePositionPrev  // 0x18
  private           System.Int32                    m_LastUpdatedFrame  // 0x20
METHODS:
  System.Int32 Rewired.UI.IMouseInputSource.get_playerId()
  System.Int32 Rewired.UI.ITouchInputSource.get_playerId()
  System.Boolean Rewired.UI.IMouseInputSource.get_enabled()
  System.Boolean Rewired.UI.IMouseInputSource.get_locked()
  System.Int32 Rewired.UI.IMouseInputSource.get_buttonCount()
  System.Boolean Rewired.UI.IMouseInputSource.GetButtonDown(System.Int32 button)
  System.Boolean Rewired.UI.IMouseInputSource.GetButtonUp(System.Int32 button)
  System.Boolean Rewired.UI.IMouseInputSource.GetButton(System.Int32 button)
  UnityEngine.Vector2 Rewired.UI.IMouseInputSource.get_screenPosition()
  UnityEngine.Vector2 Rewired.UI.IMouseInputSource.get_screenPositionDelta()
  UnityEngine.Vector2 Rewired.UI.IMouseInputSource.get_wheelDelta()
  System.Boolean Rewired.UI.ITouchInputSource.get_touchSupported()
  System.Int32 Rewired.UI.ITouchInputSource.get_touchCount()
  UnityEngine.Touch Rewired.UI.ITouchInputSource.GetTouch(System.Int32 index)
  System.Void TryUpdate()
  System.Void .ctor()
END_CLASS

CLASS: PlayerSetting
TYPE:  class
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    playerId  // 0x10
  public            System.Collections.Generic.List<Rewired.Components.PlayerMouse>playerMice  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(Rewired.Integration.UnityUI.RewiredStandaloneInputModule.PlayerSetting other)
  Rewired.Integration.UnityUI.RewiredStandaloneInputModule.PlayerSetting Clone()
END_CLASS

CLASS: Rewired.IGamepadTemplate
TYPE:  interface
TOKEN: 0x2000002
FIELDS:
METHODS:
  Rewired.IControllerTemplateButton get_actionBottomRow1()
  Rewired.IControllerTemplateButton get_a()
  Rewired.IControllerTemplateButton get_actionBottomRow2()
  Rewired.IControllerTemplateButton get_b()
  Rewired.IControllerTemplateButton get_actionBottomRow3()
  Rewired.IControllerTemplateButton get_c()
  Rewired.IControllerTemplateButton get_actionTopRow1()
  Rewired.IControllerTemplateButton get_x()
  Rewired.IControllerTemplateButton get_actionTopRow2()
  Rewired.IControllerTemplateButton get_y()
  Rewired.IControllerTemplateButton get_actionTopRow3()
  Rewired.IControllerTemplateButton get_z()
  Rewired.IControllerTemplateButton get_leftShoulder1()
  Rewired.IControllerTemplateButton get_leftBumper()
  Rewired.IControllerTemplateAxis get_leftShoulder2()
  Rewired.IControllerTemplateAxis get_leftTrigger()
  Rewired.IControllerTemplateButton get_rightShoulder1()
  Rewired.IControllerTemplateButton get_rightBumper()
  Rewired.IControllerTemplateAxis get_rightShoulder2()
  Rewired.IControllerTemplateAxis get_rightTrigger()
  Rewired.IControllerTemplateButton get_center1()
  Rewired.IControllerTemplateButton get_back()
  Rewired.IControllerTemplateButton get_center2()
  Rewired.IControllerTemplateButton get_start()
  Rewired.IControllerTemplateButton get_center3()
  Rewired.IControllerTemplateButton get_guide()
  Rewired.IControllerTemplateThumbStick get_leftStick()
  Rewired.IControllerTemplateThumbStick get_rightStick()
  Rewired.IControllerTemplateDPad get_dPad()
END_CLASS

CLASS: Rewired.IRacingWheelTemplate
TYPE:  interface
TOKEN: 0x2000003
FIELDS:
METHODS:
  Rewired.IControllerTemplateAxis get_wheel()
  Rewired.IControllerTemplateAxis get_accelerator()
  Rewired.IControllerTemplateAxis get_brake()
  Rewired.IControllerTemplateAxis get_clutch()
  Rewired.IControllerTemplateButton get_shiftDown()
  Rewired.IControllerTemplateButton get_shiftUp()
  Rewired.IControllerTemplateButton get_wheelButton1()
  Rewired.IControllerTemplateButton get_wheelButton2()
  Rewired.IControllerTemplateButton get_wheelButton3()
  Rewired.IControllerTemplateButton get_wheelButton4()
  Rewired.IControllerTemplateButton get_wheelButton5()
  Rewired.IControllerTemplateButton get_wheelButton6()
  Rewired.IControllerTemplateButton get_wheelButton7()
  Rewired.IControllerTemplateButton get_wheelButton8()
  Rewired.IControllerTemplateButton get_wheelButton9()
  Rewired.IControllerTemplateButton get_wheelButton10()
  Rewired.IControllerTemplateButton get_consoleButton1()
  Rewired.IControllerTemplateButton get_consoleButton2()
  Rewired.IControllerTemplateButton get_consoleButton3()
  Rewired.IControllerTemplateButton get_consoleButton4()
  Rewired.IControllerTemplateButton get_consoleButton5()
  Rewired.IControllerTemplateButton get_consoleButton6()
  Rewired.IControllerTemplateButton get_consoleButton7()
  Rewired.IControllerTemplateButton get_consoleButton8()
  Rewired.IControllerTemplateButton get_consoleButton9()
  Rewired.IControllerTemplateButton get_consoleButton10()
  Rewired.IControllerTemplateButton get_shifter1()
  Rewired.IControllerTemplateButton get_shifter2()
  Rewired.IControllerTemplateButton get_shifter3()
  Rewired.IControllerTemplateButton get_shifter4()
  Rewired.IControllerTemplateButton get_shifter5()
  Rewired.IControllerTemplateButton get_shifter6()
  Rewired.IControllerTemplateButton get_shifter7()
  Rewired.IControllerTemplateButton get_shifter8()
  Rewired.IControllerTemplateButton get_shifter9()
  Rewired.IControllerTemplateButton get_shifter10()
  Rewired.IControllerTemplateButton get_reverseGear()
  Rewired.IControllerTemplateButton get_select()
  Rewired.IControllerTemplateButton get_start()
  Rewired.IControllerTemplateButton get_systemButton()
  Rewired.IControllerTemplateButton get_horn()
  Rewired.IControllerTemplateDPad get_dPad()
END_CLASS

CLASS: Rewired.IHOTASTemplate
TYPE:  interface
TOKEN: 0x2000004
FIELDS:
METHODS:
  Rewired.IControllerTemplateButton get_stickTrigger()
  Rewired.IControllerTemplateButton get_stickTriggerStage2()
  Rewired.IControllerTemplateButton get_stickPinkyButton()
  Rewired.IControllerTemplateButton get_stickPinkyTrigger()
  Rewired.IControllerTemplateButton get_stickButton1()
  Rewired.IControllerTemplateButton get_stickButton2()
  Rewired.IControllerTemplateButton get_stickButton3()
  Rewired.IControllerTemplateButton get_stickButton4()
  Rewired.IControllerTemplateButton get_stickButton5()
  Rewired.IControllerTemplateButton get_stickButton6()
  Rewired.IControllerTemplateButton get_stickButton7()
  Rewired.IControllerTemplateButton get_stickButton8()
  Rewired.IControllerTemplateButton get_stickButton9()
  Rewired.IControllerTemplateButton get_stickButton10()
  Rewired.IControllerTemplateButton get_stickBaseButton1()
  Rewired.IControllerTemplateButton get_stickBaseButton2()
  Rewired.IControllerTemplateButton get_stickBaseButton3()
  Rewired.IControllerTemplateButton get_stickBaseButton4()
  Rewired.IControllerTemplateButton get_stickBaseButton5()
  Rewired.IControllerTemplateButton get_stickBaseButton6()
  Rewired.IControllerTemplateButton get_stickBaseButton7()
  Rewired.IControllerTemplateButton get_stickBaseButton8()
  Rewired.IControllerTemplateButton get_stickBaseButton9()
  Rewired.IControllerTemplateButton get_stickBaseButton10()
  Rewired.IControllerTemplateButton get_stickBaseButton11()
  Rewired.IControllerTemplateButton get_stickBaseButton12()
  Rewired.IControllerTemplateButton get_mode1()
  Rewired.IControllerTemplateButton get_mode2()
  Rewired.IControllerTemplateButton get_mode3()
  Rewired.IControllerTemplateButton get_throttleButton1()
  Rewired.IControllerTemplateButton get_throttleButton2()
  Rewired.IControllerTemplateButton get_throttleButton3()
  Rewired.IControllerTemplateButton get_throttleButton4()
  Rewired.IControllerTemplateButton get_throttleButton5()
  Rewired.IControllerTemplateButton get_throttleButton6()
  Rewired.IControllerTemplateButton get_throttleButton7()
  Rewired.IControllerTemplateButton get_throttleButton8()
  Rewired.IControllerTemplateButton get_throttleButton9()
  Rewired.IControllerTemplateButton get_throttleButton10()
  Rewired.IControllerTemplateButton get_throttleBaseButton1()
  Rewired.IControllerTemplateButton get_throttleBaseButton2()
  Rewired.IControllerTemplateButton get_throttleBaseButton3()
  Rewired.IControllerTemplateButton get_throttleBaseButton4()
  Rewired.IControllerTemplateButton get_throttleBaseButton5()
  Rewired.IControllerTemplateButton get_throttleBaseButton6()
  Rewired.IControllerTemplateButton get_throttleBaseButton7()
  Rewired.IControllerTemplateButton get_throttleBaseButton8()
  Rewired.IControllerTemplateButton get_throttleBaseButton9()
  Rewired.IControllerTemplateButton get_throttleBaseButton10()
  Rewired.IControllerTemplateButton get_throttleBaseButton11()
  Rewired.IControllerTemplateButton get_throttleBaseButton12()
  Rewired.IControllerTemplateButton get_throttleBaseButton13()
  Rewired.IControllerTemplateButton get_throttleBaseButton14()
  Rewired.IControllerTemplateButton get_throttleBaseButton15()
  Rewired.IControllerTemplateAxis get_throttleSlider1()
  Rewired.IControllerTemplateAxis get_throttleSlider2()
  Rewired.IControllerTemplateAxis get_throttleSlider3()
  Rewired.IControllerTemplateAxis get_throttleSlider4()
  Rewired.IControllerTemplateAxis get_throttleDial1()
  Rewired.IControllerTemplateAxis get_throttleDial2()
  Rewired.IControllerTemplateAxis get_throttleDial3()
  Rewired.IControllerTemplateAxis get_throttleDial4()
  Rewired.IControllerTemplateButton get_throttleWheel1Forward()
  Rewired.IControllerTemplateButton get_throttleWheel1Back()
  Rewired.IControllerTemplateButton get_throttleWheel1Press()
  Rewired.IControllerTemplateButton get_throttleWheel2Forward()
  Rewired.IControllerTemplateButton get_throttleWheel2Back()
  Rewired.IControllerTemplateButton get_throttleWheel2Press()
  Rewired.IControllerTemplateButton get_throttleWheel3Forward()
  Rewired.IControllerTemplateButton get_throttleWheel3Back()
  Rewired.IControllerTemplateButton get_throttleWheel3Press()
  Rewired.IControllerTemplateAxis get_leftPedal()
  Rewired.IControllerTemplateAxis get_rightPedal()
  Rewired.IControllerTemplateAxis get_slidePedals()
  Rewired.IControllerTemplateStick get_stick()
  Rewired.IControllerTemplateThumbStick get_stickMiniStick1()
  Rewired.IControllerTemplateThumbStick get_stickMiniStick2()
  Rewired.IControllerTemplateHat get_stickHat1()
  Rewired.IControllerTemplateHat get_stickHat2()
  Rewired.IControllerTemplateHat get_stickHat3()
  Rewired.IControllerTemplateHat get_stickHat4()
  Rewired.IControllerTemplateThrottle get_throttle1()
  Rewired.IControllerTemplateThrottle get_throttle2()
  Rewired.IControllerTemplateThumbStick get_throttleMiniStick()
  Rewired.IControllerTemplateHat get_throttleHat1()
  Rewired.IControllerTemplateHat get_throttleHat2()
  Rewired.IControllerTemplateHat get_throttleHat3()
  Rewired.IControllerTemplateHat get_throttleHat4()
END_CLASS

CLASS: Rewired.IFlightYokeTemplate
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
METHODS:
  Rewired.IControllerTemplateButton get_leftPaddle()
  Rewired.IControllerTemplateButton get_rightPaddle()
  Rewired.IControllerTemplateButton get_leftGripButton1()
  Rewired.IControllerTemplateButton get_leftGripButton2()
  Rewired.IControllerTemplateButton get_leftGripButton3()
  Rewired.IControllerTemplateButton get_leftGripButton4()
  Rewired.IControllerTemplateButton get_leftGripButton5()
  Rewired.IControllerTemplateButton get_leftGripButton6()
  Rewired.IControllerTemplateButton get_rightGripButton1()
  Rewired.IControllerTemplateButton get_rightGripButton2()
  Rewired.IControllerTemplateButton get_rightGripButton3()
  Rewired.IControllerTemplateButton get_rightGripButton4()
  Rewired.IControllerTemplateButton get_rightGripButton5()
  Rewired.IControllerTemplateButton get_rightGripButton6()
  Rewired.IControllerTemplateButton get_centerButton1()
  Rewired.IControllerTemplateButton get_centerButton2()
  Rewired.IControllerTemplateButton get_centerButton3()
  Rewired.IControllerTemplateButton get_centerButton4()
  Rewired.IControllerTemplateButton get_centerButton5()
  Rewired.IControllerTemplateButton get_centerButton6()
  Rewired.IControllerTemplateButton get_centerButton7()
  Rewired.IControllerTemplateButton get_centerButton8()
  Rewired.IControllerTemplateButton get_wheel1Up()
  Rewired.IControllerTemplateButton get_wheel1Down()
  Rewired.IControllerTemplateButton get_wheel1Press()
  Rewired.IControllerTemplateButton get_wheel2Up()
  Rewired.IControllerTemplateButton get_wheel2Down()
  Rewired.IControllerTemplateButton get_wheel2Press()
  Rewired.IControllerTemplateButton get_consoleButton1()
  Rewired.IControllerTemplateButton get_consoleButton2()
  Rewired.IControllerTemplateButton get_consoleButton3()
  Rewired.IControllerTemplateButton get_consoleButton4()
  Rewired.IControllerTemplateButton get_consoleButton5()
  Rewired.IControllerTemplateButton get_consoleButton6()
  Rewired.IControllerTemplateButton get_consoleButton7()
  Rewired.IControllerTemplateButton get_consoleButton8()
  Rewired.IControllerTemplateButton get_consoleButton9()
  Rewired.IControllerTemplateButton get_consoleButton10()
  Rewired.IControllerTemplateButton get_mode1()
  Rewired.IControllerTemplateButton get_mode2()
  Rewired.IControllerTemplateButton get_mode3()
  Rewired.IControllerTemplateYoke get_yoke()
  Rewired.IControllerTemplateThrottle get_lever1()
  Rewired.IControllerTemplateThrottle get_lever2()
  Rewired.IControllerTemplateThrottle get_lever3()
  Rewired.IControllerTemplateThrottle get_lever4()
  Rewired.IControllerTemplateThrottle get_lever5()
  Rewired.IControllerTemplateHat get_leftGripHat()
  Rewired.IControllerTemplateHat get_rightGripHat()
END_CLASS

CLASS: Rewired.IFlightPedalsTemplate
TYPE:  interface
TOKEN: 0x2000006
FIELDS:
METHODS:
  Rewired.IControllerTemplateAxis get_leftPedal()
  Rewired.IControllerTemplateAxis get_rightPedal()
  Rewired.IControllerTemplateAxis get_slide()
END_CLASS

CLASS: Rewired.ISixDofControllerTemplate
TYPE:  interface
TOKEN: 0x2000007
FIELDS:
METHODS:
  Rewired.IControllerTemplateAxis get_extraAxis1()
  Rewired.IControllerTemplateAxis get_extraAxis2()
  Rewired.IControllerTemplateAxis get_extraAxis3()
  Rewired.IControllerTemplateAxis get_extraAxis4()
  Rewired.IControllerTemplateButton get_button1()
  Rewired.IControllerTemplateButton get_button2()
  Rewired.IControllerTemplateButton get_button3()
  Rewired.IControllerTemplateButton get_button4()
  Rewired.IControllerTemplateButton get_button5()
  Rewired.IControllerTemplateButton get_button6()
  Rewired.IControllerTemplateButton get_button7()
  Rewired.IControllerTemplateButton get_button8()
  Rewired.IControllerTemplateButton get_button9()
  Rewired.IControllerTemplateButton get_button10()
  Rewired.IControllerTemplateButton get_button11()
  Rewired.IControllerTemplateButton get_button12()
  Rewired.IControllerTemplateButton get_button13()
  Rewired.IControllerTemplateButton get_button14()
  Rewired.IControllerTemplateButton get_button15()
  Rewired.IControllerTemplateButton get_button16()
  Rewired.IControllerTemplateButton get_button17()
  Rewired.IControllerTemplateButton get_button18()
  Rewired.IControllerTemplateButton get_button19()
  Rewired.IControllerTemplateButton get_button20()
  Rewired.IControllerTemplateButton get_button21()
  Rewired.IControllerTemplateButton get_button22()
  Rewired.IControllerTemplateButton get_button23()
  Rewired.IControllerTemplateButton get_button24()
  Rewired.IControllerTemplateButton get_button25()
  Rewired.IControllerTemplateButton get_button26()
  Rewired.IControllerTemplateButton get_button27()
  Rewired.IControllerTemplateButton get_button28()
  Rewired.IControllerTemplateButton get_button29()
  Rewired.IControllerTemplateButton get_button30()
  Rewired.IControllerTemplateButton get_button31()
  Rewired.IControllerTemplateButton get_button32()
  Rewired.IControllerTemplateHat get_hat1()
  Rewired.IControllerTemplateHat get_hat2()
  Rewired.IControllerTemplateThrottle get_throttle1()
  Rewired.IControllerTemplateThrottle get_throttle2()
  Rewired.IControllerTemplateStick6D get_stick()
END_CLASS

CLASS: Rewired.GamepadTemplate
TYPE:  class
TOKEN: 0x2000008
EXTENDS: ControllerTemplate
FIELDS:
  public    static readonly System.Guid                     typeGuid  // 0x0
  public    static  System.Int32                    elementId_leftStickX  // 0x0
  public    static  System.Int32                    elementId_leftStickY  // 0x0
  public    static  System.Int32                    elementId_rightStickX  // 0x0
  public    static  System.Int32                    elementId_rightStickY  // 0x0
  public    static  System.Int32                    elementId_actionBottomRow1  // 0x0
  public    static  System.Int32                    elementId_a  // 0x0
  public    static  System.Int32                    elementId_actionBottomRow2  // 0x0
  public    static  System.Int32                    elementId_b  // 0x0
  public    static  System.Int32                    elementId_actionBottomRow3  // 0x0
  public    static  System.Int32                    elementId_c  // 0x0
  public    static  System.Int32                    elementId_actionTopRow1  // 0x0
  public    static  System.Int32                    elementId_x  // 0x0
  public    static  System.Int32                    elementId_actionTopRow2  // 0x0
  public    static  System.Int32                    elementId_y  // 0x0
  public    static  System.Int32                    elementId_actionTopRow3  // 0x0
  public    static  System.Int32                    elementId_z  // 0x0
  public    static  System.Int32                    elementId_leftShoulder1  // 0x0
  public    static  System.Int32                    elementId_leftBumper  // 0x0
  public    static  System.Int32                    elementId_leftShoulder2  // 0x0
  public    static  System.Int32                    elementId_leftTrigger  // 0x0
  public    static  System.Int32                    elementId_rightShoulder1  // 0x0
  public    static  System.Int32                    elementId_rightBumper  // 0x0
  public    static  System.Int32                    elementId_rightShoulder2  // 0x0
  public    static  System.Int32                    elementId_rightTrigger  // 0x0
  public    static  System.Int32                    elementId_center1  // 0x0
  public    static  System.Int32                    elementId_back  // 0x0
  public    static  System.Int32                    elementId_center2  // 0x0
  public    static  System.Int32                    elementId_start  // 0x0
  public    static  System.Int32                    elementId_center3  // 0x0
  public    static  System.Int32                    elementId_guide  // 0x0
  public    static  System.Int32                    elementId_leftStickButton  // 0x0
  public    static  System.Int32                    elementId_rightStickButton  // 0x0
  public    static  System.Int32                    elementId_dPadUp  // 0x0
  public    static  System.Int32                    elementId_dPadRight  // 0x0
  public    static  System.Int32                    elementId_dPadDown  // 0x0
  public    static  System.Int32                    elementId_dPadLeft  // 0x0
  public    static  System.Int32                    elementId_leftStick  // 0x0
  public    static  System.Int32                    elementId_rightStick  // 0x0
  public    static  System.Int32                    elementId_dPad  // 0x0
METHODS:
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow1()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_a()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow2()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_b()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow3()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_c()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow1()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_x()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow2()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_y()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow3()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_z()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_leftShoulder1()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_leftBumper()
  Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.get_leftShoulder2()
  Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.get_leftTrigger()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_rightShoulder1()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_rightBumper()
  Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.get_rightShoulder2()
  Rewired.IControllerTemplateAxis Rewired.IGamepadTemplate.get_rightTrigger()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_center1()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_back()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_center2()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_start()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_center3()
  Rewired.IControllerTemplateButton Rewired.IGamepadTemplate.get_guide()
  Rewired.IControllerTemplateThumbStick Rewired.IGamepadTemplate.get_leftStick()
  Rewired.IControllerTemplateThumbStick Rewired.IGamepadTemplate.get_rightStick()
  Rewired.IControllerTemplateDPad Rewired.IGamepadTemplate.get_dPad()
  System.Void .ctor(System.Object payload)
  System.Void .cctor()
END_CLASS

CLASS: Rewired.RacingWheelTemplate
TYPE:  class
TOKEN: 0x2000009
EXTENDS: ControllerTemplate
FIELDS:
  public    static readonly System.Guid                     typeGuid  // 0x0
  public    static  System.Int32                    elementId_wheel  // 0x0
  public    static  System.Int32                    elementId_accelerator  // 0x0
  public    static  System.Int32                    elementId_brake  // 0x0
  public    static  System.Int32                    elementId_clutch  // 0x0
  public    static  System.Int32                    elementId_shiftDown  // 0x0
  public    static  System.Int32                    elementId_shiftUp  // 0x0
  public    static  System.Int32                    elementId_wheelButton1  // 0x0
  public    static  System.Int32                    elementId_wheelButton2  // 0x0
  public    static  System.Int32                    elementId_wheelButton3  // 0x0
  public    static  System.Int32                    elementId_wheelButton4  // 0x0
  public    static  System.Int32                    elementId_wheelButton5  // 0x0
  public    static  System.Int32                    elementId_wheelButton6  // 0x0
  public    static  System.Int32                    elementId_wheelButton7  // 0x0
  public    static  System.Int32                    elementId_wheelButton8  // 0x0
  public    static  System.Int32                    elementId_wheelButton9  // 0x0
  public    static  System.Int32                    elementId_wheelButton10  // 0x0
  public    static  System.Int32                    elementId_consoleButton1  // 0x0
  public    static  System.Int32                    elementId_consoleButton2  // 0x0
  public    static  System.Int32                    elementId_consoleButton3  // 0x0
  public    static  System.Int32                    elementId_consoleButton4  // 0x0
  public    static  System.Int32                    elementId_consoleButton5  // 0x0
  public    static  System.Int32                    elementId_consoleButton6  // 0x0
  public    static  System.Int32                    elementId_consoleButton7  // 0x0
  public    static  System.Int32                    elementId_consoleButton8  // 0x0
  public    static  System.Int32                    elementId_consoleButton9  // 0x0
  public    static  System.Int32                    elementId_consoleButton10  // 0x0
  public    static  System.Int32                    elementId_shifter1  // 0x0
  public    static  System.Int32                    elementId_shifter2  // 0x0
  public    static  System.Int32                    elementId_shifter3  // 0x0
  public    static  System.Int32                    elementId_shifter4  // 0x0
  public    static  System.Int32                    elementId_shifter5  // 0x0
  public    static  System.Int32                    elementId_shifter6  // 0x0
  public    static  System.Int32                    elementId_shifter7  // 0x0
  public    static  System.Int32                    elementId_shifter8  // 0x0
  public    static  System.Int32                    elementId_shifter9  // 0x0
  public    static  System.Int32                    elementId_shifter10  // 0x0
  public    static  System.Int32                    elementId_reverseGear  // 0x0
  public    static  System.Int32                    elementId_select  // 0x0
  public    static  System.Int32                    elementId_start  // 0x0
  public    static  System.Int32                    elementId_systemButton  // 0x0
  public    static  System.Int32                    elementId_horn  // 0x0
  public    static  System.Int32                    elementId_dPadUp  // 0x0
  public    static  System.Int32                    elementId_dPadRight  // 0x0
  public    static  System.Int32                    elementId_dPadDown  // 0x0
  public    static  System.Int32                    elementId_dPadLeft  // 0x0
  public    static  System.Int32                    elementId_dPad  // 0x0
METHODS:
  Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_wheel()
  Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_accelerator()
  Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_brake()
  Rewired.IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_clutch()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shiftDown()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shiftUp()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton1()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton2()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton3()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton4()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton5()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton6()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton7()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton8()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton9()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton10()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton1()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton2()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton3()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton4()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton5()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton6()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton7()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton8()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton9()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton10()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter1()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter2()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter3()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter4()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter5()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter6()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter7()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter8()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter9()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter10()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_reverseGear()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_select()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_start()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_systemButton()
  Rewired.IControllerTemplateButton Rewired.IRacingWheelTemplate.get_horn()
  Rewired.IControllerTemplateDPad Rewired.IRacingWheelTemplate.get_dPad()
  System.Void .ctor(System.Object payload)
  System.Void .cctor()
END_CLASS

CLASS: Rewired.HOTASTemplate
TYPE:  class
TOKEN: 0x200000A
EXTENDS: ControllerTemplate
FIELDS:
  public    static readonly System.Guid                     typeGuid  // 0x0
  public    static  System.Int32                    elementId_stickX  // 0x0
  public    static  System.Int32                    elementId_stickY  // 0x0
  public    static  System.Int32                    elementId_stickRotate  // 0x0
  public    static  System.Int32                    elementId_stickMiniStick1X  // 0x0
  public    static  System.Int32                    elementId_stickMiniStick1Y  // 0x0
  public    static  System.Int32                    elementId_stickMiniStick1Press  // 0x0
  public    static  System.Int32                    elementId_stickMiniStick2X  // 0x0
  public    static  System.Int32                    elementId_stickMiniStick2Y  // 0x0
  public    static  System.Int32                    elementId_stickMiniStick2Press  // 0x0
  public    static  System.Int32                    elementId_stickTrigger  // 0x0
  public    static  System.Int32                    elementId_stickTriggerStage2  // 0x0
  public    static  System.Int32                    elementId_stickPinkyButton  // 0x0
  public    static  System.Int32                    elementId_stickPinkyTrigger  // 0x0
  public    static  System.Int32                    elementId_stickButton1  // 0x0
  public    static  System.Int32                    elementId_stickButton2  // 0x0
  public    static  System.Int32                    elementId_stickButton3  // 0x0
  public    static  System.Int32                    elementId_stickButton4  // 0x0
  public    static  System.Int32                    elementId_stickButton5  // 0x0
  public    static  System.Int32                    elementId_stickButton6  // 0x0
  public    static  System.Int32                    elementId_stickButton7  // 0x0
  public    static  System.Int32                    elementId_stickButton8  // 0x0
  public    static  System.Int32                    elementId_stickButton9  // 0x0
  public    static  System.Int32                    elementId_stickButton10  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton1  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton2  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton3  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton4  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton5  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton6  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton7  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton8  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton9  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton10  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton11  // 0x0
  public    static  System.Int32                    elementId_stickBaseButton12  // 0x0
  public    static  System.Int32                    elementId_stickHat1Up  // 0x0
  public    static  System.Int32                    elementId_stickHat1UpRight  // 0x0
  public    static  System.Int32                    elementId_stickHat1Right  // 0x0
  public    static  System.Int32                    elementId_stickHat1DownRight  // 0x0
  public    static  System.Int32                    elementId_stickHat1Down  // 0x0
  public    static  System.Int32                    elementId_stickHat1DownLeft  // 0x0
  public    static  System.Int32                    elementId_stickHat1Left  // 0x0
  public    static  System.Int32                    elementId_stickHat1Up_Left  // 0x0
  public    static  System.Int32                    elementId_stickHat2Up  // 0x0
  public    static  System.Int32                    elementId_stickHat2Up_right  // 0x0
  public    static  System.Int32                    elementId_stickHat2Right  // 0x0
  public    static  System.Int32                    elementId_stickHat2Down_Right  // 0x0
  public    static  System.Int32                    elementId_stickHat2Down  // 0x0
  public    static  System.Int32                    elementId_stickHat2Down_Left  // 0x0
  public    static  System.Int32                    elementId_stickHat2Left  // 0x0
  public    static  System.Int32                    elementId_stickHat2Up_Left  // 0x0
  public    static  System.Int32                    elementId_stickHat3Up  // 0x0
  public    static  System.Int32                    elementId_stickHat3Up_Right  // 0x0
  public    static  System.Int32                    elementId_stickHat3Right  // 0x0
  public    static  System.Int32                    elementId_stickHat3Down_Right  // 0x0
  public    static  System.Int32                    elementId_stickHat3Down  // 0x0
  public    static  System.Int32                    elementId_stickHat3Down_Left  // 0x0
  public    static  System.Int32                    elementId_stickHat3Left  // 0x0
  public    static  System.Int32                    elementId_stickHat3Up_Left  // 0x0
  public    static  System.Int32                    elementId_stickHat4Up  // 0x0
  public    static  System.Int32                    elementId_stickHat4Up_Right  // 0x0
  public    static  System.Int32                    elementId_stickHat4Right  // 0x0
  public    static  System.Int32                    elementId_stickHat4Down_Right  // 0x0
  public    static  System.Int32                    elementId_stickHat4Down  // 0x0
  public    static  System.Int32                    elementId_stickHat4Down_Left  // 0x0
  public    static  System.Int32                    elementId_stickHat4Left  // 0x0
  public    static  System.Int32                    elementId_stickHat4Up_Left  // 0x0
  public    static  System.Int32                    elementId_mode1  // 0x0
  public    static  System.Int32                    elementId_mode2  // 0x0
  public    static  System.Int32                    elementId_mode3  // 0x0
  public    static  System.Int32                    elementId_throttle1Axis  // 0x0
  public    static  System.Int32                    elementId_throttle2Axis  // 0x0
  public    static  System.Int32                    elementId_throttle1MinDetent  // 0x0
  public    static  System.Int32                    elementId_throttle2MinDetent  // 0x0
  public    static  System.Int32                    elementId_throttleButton1  // 0x0
  public    static  System.Int32                    elementId_throttleButton2  // 0x0
  public    static  System.Int32                    elementId_throttleButton3  // 0x0
  public    static  System.Int32                    elementId_throttleButton4  // 0x0
  public    static  System.Int32                    elementId_throttleButton5  // 0x0
  public    static  System.Int32                    elementId_throttleButton6  // 0x0
  public    static  System.Int32                    elementId_throttleButton7  // 0x0
  public    static  System.Int32                    elementId_throttleButton8  // 0x0
  public    static  System.Int32                    elementId_throttleButton9  // 0x0
  public    static  System.Int32                    elementId_throttleButton10  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton1  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton2  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton3  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton4  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton5  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton6  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton7  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton8  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton9  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton10  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton11  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton12  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton13  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton14  // 0x0
  public    static  System.Int32                    elementId_throttleBaseButton15  // 0x0
  public    static  System.Int32                    elementId_throttleSlider1  // 0x0
  public    static  System.Int32                    elementId_throttleSlider2  // 0x0
  public    static  System.Int32                    elementId_throttleSlider3  // 0x0
  public    static  System.Int32                    elementId_throttleSlider4  // 0x0
  public    static  System.Int32                    elementId_throttleDial1  // 0x0
  public    static  System.Int32                    elementId_throttleDial2  // 0x0
  public    static  System.Int32                    elementId_throttleDial3  // 0x0
  public    static  System.Int32                    elementId_throttleDial4  // 0x0
  public    static  System.Int32                    elementId_throttleMiniStickX  // 0x0
  public    static  System.Int32                    elementId_throttleMiniStickY  // 0x0
  public    static  System.Int32                    elementId_throttleMiniStickPress  // 0x0
  public    static  System.Int32                    elementId_throttleWheel1Forward  // 0x0
  public    static  System.Int32                    elementId_throttleWheel1Back  // 0x0
  public    static  System.Int32                    elementId_throttleWheel1Press  // 0x0
  public    static  System.Int32                    elementId_throttleWheel2Forward  // 0x0
  public    static  System.Int32                    elementId_throttleWheel2Back  // 0x0
  public    static  System.Int32                    elementId_throttleWheel2Press  // 0x0
  public    static  System.Int32                    elementId_throttleWheel3Forward  // 0x0
  public    static  System.Int32                    elementId_throttleWheel3Back  // 0x0
  public    static  System.Int32                    elementId_throttleWheel3Press  // 0x0
  public    static  System.Int32                    elementId_throttleHat1Up  // 0x0
  public    static  System.Int32                    elementId_throttleHat1Up_Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat1Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat1Down_Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat1Down  // 0x0
  public    static  System.Int32                    elementId_throttleHat1Down_Left  // 0x0
  public    static  System.Int32                    elementId_throttleHat1Left  // 0x0
  public    static  System.Int32                    elementId_throttleHat1Up_Left  // 0x0
  public    static  System.Int32                    elementId_throttleHat2Up  // 0x0
  public    static  System.Int32                    elementId_throttleHat2Up_Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat2Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat2Down_Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat2Down  // 0x0
  public    static  System.Int32                    elementId_throttleHat2Down_Left  // 0x0
  public    static  System.Int32                    elementId_throttleHat2Left  // 0x0
  public    static  System.Int32                    elementId_throttleHat2Up_Left  // 0x0
  public    static  System.Int32                    elementId_throttleHat3Up  // 0x0
  public    static  System.Int32                    elementId_throttleHat3Up_Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat3Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat3Down_Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat3Down  // 0x0
  public    static  System.Int32                    elementId_throttleHat3Down_Left  // 0x0
  public    static  System.Int32                    elementId_throttleHat3Left  // 0x0
  public    static  System.Int32                    elementId_throttleHat3Up_Left  // 0x0
  public    static  System.Int32                    elementId_throttleHat4Up  // 0x0
  public    static  System.Int32                    elementId_throttleHat4Up_Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat4Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat4Down_Right  // 0x0
  public    static  System.Int32                    elementId_throttleHat4Down  // 0x0
  public    static  System.Int32                    elementId_throttleHat4Down_Left  // 0x0
  public    static  System.Int32                    elementId_throttleHat4Left  // 0x0
  public    static  System.Int32                    elementId_throttleHat4Up_Left  // 0x0
  public    static  System.Int32                    elementId_leftPedal  // 0x0
  public    static  System.Int32                    elementId_rightPedal  // 0x0
  public    static  System.Int32                    elementId_slidePedals  // 0x0
  public    static  System.Int32                    elementId_stick  // 0x0
  public    static  System.Int32                    elementId_stickMiniStick1  // 0x0
  public    static  System.Int32                    elementId_stickMiniStick2  // 0x0
  public    static  System.Int32                    elementId_stickHat1  // 0x0
  public    static  System.Int32                    elementId_stickHat2  // 0x0
  public    static  System.Int32                    elementId_stickHat3  // 0x0
  public    static  System.Int32                    elementId_stickHat4  // 0x0
  public    static  System.Int32                    elementId_throttle1  // 0x0
  public    static  System.Int32                    elementId_throttle2  // 0x0
  public    static  System.Int32                    elementId_throttleMiniStick  // 0x0
  public    static  System.Int32                    elementId_throttleHat1  // 0x0
  public    static  System.Int32                    elementId_throttleHat2  // 0x0
  public    static  System.Int32                    elementId_throttleHat3  // 0x0
  public    static  System.Int32                    elementId_throttleHat4  // 0x0
METHODS:
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickTrigger()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickTriggerStage2()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickPinkyButton()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickPinkyTrigger()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton1()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton2()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton3()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton4()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton5()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton6()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton7()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton8()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton9()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton10()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton1()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton2()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton3()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton4()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton5()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton6()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton7()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton8()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton9()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton10()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton11()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton12()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_mode1()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_mode2()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_mode3()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton1()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton2()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton3()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton4()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton5()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton6()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton7()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton8()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton9()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton10()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton1()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton2()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton3()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton4()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton5()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton6()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton7()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton8()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton9()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton10()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton11()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton12()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton13()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton14()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton15()
  Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider1()
  Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider2()
  Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider3()
  Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider4()
  Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial1()
  Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial2()
  Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial3()
  Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial4()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Forward()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Back()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Press()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Forward()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Back()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Press()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Forward()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Back()
  Rewired.IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Press()
  Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_leftPedal()
  Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_rightPedal()
  Rewired.IControllerTemplateAxis Rewired.IHOTASTemplate.get_slidePedals()
  Rewired.IControllerTemplateStick Rewired.IHOTASTemplate.get_stick()
  Rewired.IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_stickMiniStick1()
  Rewired.IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_stickMiniStick2()
  Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat1()
  Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat2()
  Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat3()
  Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat4()
  Rewired.IControllerTemplateThrottle Rewired.IHOTASTemplate.get_throttle1()
  Rewired.IControllerTemplateThrottle Rewired.IHOTASTemplate.get_throttle2()
  Rewired.IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_throttleMiniStick()
  Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat1()
  Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat2()
  Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat3()
  Rewired.IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat4()
  System.Void .ctor(System.Object payload)
  System.Void .cctor()
END_CLASS

CLASS: Rewired.FlightYokeTemplate
TYPE:  class
TOKEN: 0x200000B
EXTENDS: ControllerTemplate
FIELDS:
  public    static readonly System.Guid                     typeGuid  // 0x0
  public    static  System.Int32                    elementId_rotateYoke  // 0x0
  public    static  System.Int32                    elementId_yokeZ  // 0x0
  public    static  System.Int32                    elementId_leftPaddle  // 0x0
  public    static  System.Int32                    elementId_rightPaddle  // 0x0
  public    static  System.Int32                    elementId_lever1Axis  // 0x0
  public    static  System.Int32                    elementId_lever1MinDetent  // 0x0
  public    static  System.Int32                    elementId_lever2Axis  // 0x0
  public    static  System.Int32                    elementId_lever2MinDetent  // 0x0
  public    static  System.Int32                    elementId_lever3Axis  // 0x0
  public    static  System.Int32                    elementId_lever3MinDetent  // 0x0
  public    static  System.Int32                    elementId_lever4Axis  // 0x0
  public    static  System.Int32                    elementId_lever4MinDetent  // 0x0
  public    static  System.Int32                    elementId_lever5Axis  // 0x0
  public    static  System.Int32                    elementId_lever5MinDetent  // 0x0
  public    static  System.Int32                    elementId_leftGripButton1  // 0x0
  public    static  System.Int32                    elementId_leftGripButton2  // 0x0
  public    static  System.Int32                    elementId_leftGripButton3  // 0x0
  public    static  System.Int32                    elementId_leftGripButton4  // 0x0
  public    static  System.Int32                    elementId_leftGripButton5  // 0x0
  public    static  System.Int32                    elementId_leftGripButton6  // 0x0
  public    static  System.Int32                    elementId_rightGripButton1  // 0x0
  public    static  System.Int32                    elementId_rightGripButton2  // 0x0
  public    static  System.Int32                    elementId_rightGripButton3  // 0x0
  public    static  System.Int32                    elementId_rightGripButton4  // 0x0
  public    static  System.Int32                    elementId_rightGripButton5  // 0x0
  public    static  System.Int32                    elementId_rightGripButton6  // 0x0
  public    static  System.Int32                    elementId_centerButton1  // 0x0
  public    static  System.Int32                    elementId_centerButton2  // 0x0
  public    static  System.Int32                    elementId_centerButton3  // 0x0
  public    static  System.Int32                    elementId_centerButton4  // 0x0
  public    static  System.Int32                    elementId_centerButton5  // 0x0
  public    static  System.Int32                    elementId_centerButton6  // 0x0
  public    static  System.Int32                    elementId_centerButton7  // 0x0
  public    static  System.Int32                    elementId_centerButton8  // 0x0
  public    static  System.Int32                    elementId_wheel1Up  // 0x0
  public    static  System.Int32                    elementId_wheel1Down  // 0x0
  public    static  System.Int32                    elementId_wheel1Press  // 0x0
  public    static  System.Int32                    elementId_wheel2Up  // 0x0
  public    static  System.Int32                    elementId_wheel2Down  // 0x0
  public    static  System.Int32                    elementId_wheel2Press  // 0x0
  public    static  System.Int32                    elementId_leftGripHatUp  // 0x0
  public    static  System.Int32                    elementId_leftGripHatUpRight  // 0x0
  public    static  System.Int32                    elementId_leftGripHatRight  // 0x0
  public    static  System.Int32                    elementId_leftGripHatDownRight  // 0x0
  public    static  System.Int32                    elementId_leftGripHatDown  // 0x0
  public    static  System.Int32                    elementId_leftGripHatDownLeft  // 0x0
  public    static  System.Int32                    elementId_leftGripHatLeft  // 0x0
  public    static  System.Int32                    elementId_leftGripHatUpLeft  // 0x0
  public    static  System.Int32                    elementId_rightGripHatUp  // 0x0
  public    static  System.Int32                    elementId_rightGripHatUpRight  // 0x0
  public    static  System.Int32                    elementId_rightGripHatRight  // 0x0
  public    static  System.Int32                    elementId_rightGripHatDownRight  // 0x0
  public    static  System.Int32                    elementId_rightGripHatDown  // 0x0
  public    static  System.Int32                    elementId_rightGripHatDownLeft  // 0x0
  public    static  System.Int32                    elementId_rightGripHatLeft  // 0x0
  public    static  System.Int32                    elementId_rightGripHatUpLeft  // 0x0
  public    static  System.Int32                    elementId_consoleButton1  // 0x0
  public    static  System.Int32                    elementId_consoleButton2  // 0x0
  public    static  System.Int32                    elementId_consoleButton3  // 0x0
  public    static  System.Int32                    elementId_consoleButton4  // 0x0
  public    static  System.Int32                    elementId_consoleButton5  // 0x0
  public    static  System.Int32                    elementId_consoleButton6  // 0x0
  public    static  System.Int32                    elementId_consoleButton7  // 0x0
  public    static  System.Int32                    elementId_consoleButton8  // 0x0
  public    static  System.Int32                    elementId_consoleButton9  // 0x0
  public    static  System.Int32                    elementId_consoleButton10  // 0x0
  public    static  System.Int32                    elementId_mode1  // 0x0
  public    static  System.Int32                    elementId_mode2  // 0x0
  public    static  System.Int32                    elementId_mode3  // 0x0
  public    static  System.Int32                    elementId_yoke  // 0x0
  public    static  System.Int32                    elementId_lever1  // 0x0
  public    static  System.Int32                    elementId_lever2  // 0x0
  public    static  System.Int32                    elementId_lever3  // 0x0
  public    static  System.Int32                    elementId_lever4  // 0x0
  public    static  System.Int32                    elementId_lever5  // 0x0
  public    static  System.Int32                    elementId_leftGripHat  // 0x0
  public    static  System.Int32                    elementId_rightGripHat  // 0x0
METHODS:
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftPaddle()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightPaddle()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton1()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton2()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton3()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton4()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton5()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton6()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton1()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton2()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton3()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton4()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton5()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton6()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton1()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton2()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton3()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton4()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton5()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton6()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton7()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton8()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Up()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Down()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Press()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Up()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Down()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Press()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton1()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton2()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton3()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton4()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton5()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton6()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton7()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton8()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton9()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton10()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode1()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode2()
  Rewired.IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode3()
  Rewired.IControllerTemplateYoke Rewired.IFlightYokeTemplate.get_yoke()
  Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever1()
  Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever2()
  Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever3()
  Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever4()
  Rewired.IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever5()
  Rewired.IControllerTemplateHat Rewired.IFlightYokeTemplate.get_leftGripHat()
  Rewired.IControllerTemplateHat Rewired.IFlightYokeTemplate.get_rightGripHat()
  System.Void .ctor(System.Object payload)
  System.Void .cctor()
END_CLASS

CLASS: Rewired.FlightPedalsTemplate
TYPE:  class
TOKEN: 0x200000C
EXTENDS: ControllerTemplate
FIELDS:
  public    static readonly System.Guid                     typeGuid  // 0x0
  public    static  System.Int32                    elementId_leftPedal  // 0x0
  public    static  System.Int32                    elementId_rightPedal  // 0x0
  public    static  System.Int32                    elementId_slide  // 0x0
METHODS:
  Rewired.IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_leftPedal()
  Rewired.IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_rightPedal()
  Rewired.IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_slide()
  System.Void .ctor(System.Object payload)
  System.Void .cctor()
END_CLASS

CLASS: Rewired.SixDofControllerTemplate
TYPE:  class
TOKEN: 0x200000D
EXTENDS: ControllerTemplate
FIELDS:
  public    static readonly System.Guid                     typeGuid  // 0x0
  public    static  System.Int32                    elementId_positionX  // 0x0
  public    static  System.Int32                    elementId_positionY  // 0x0
  public    static  System.Int32                    elementId_positionZ  // 0x0
  public    static  System.Int32                    elementId_rotationX  // 0x0
  public    static  System.Int32                    elementId_rotationY  // 0x0
  public    static  System.Int32                    elementId_rotationZ  // 0x0
  public    static  System.Int32                    elementId_throttle1Axis  // 0x0
  public    static  System.Int32                    elementId_throttle1MinDetent  // 0x0
  public    static  System.Int32                    elementId_throttle2Axis  // 0x0
  public    static  System.Int32                    elementId_throttle2MinDetent  // 0x0
  public    static  System.Int32                    elementId_extraAxis1  // 0x0
  public    static  System.Int32                    elementId_extraAxis2  // 0x0
  public    static  System.Int32                    elementId_extraAxis3  // 0x0
  public    static  System.Int32                    elementId_extraAxis4  // 0x0
  public    static  System.Int32                    elementId_button1  // 0x0
  public    static  System.Int32                    elementId_button2  // 0x0
  public    static  System.Int32                    elementId_button3  // 0x0
  public    static  System.Int32                    elementId_button4  // 0x0
  public    static  System.Int32                    elementId_button5  // 0x0
  public    static  System.Int32                    elementId_button6  // 0x0
  public    static  System.Int32                    elementId_button7  // 0x0
  public    static  System.Int32                    elementId_button8  // 0x0
  public    static  System.Int32                    elementId_button9  // 0x0
  public    static  System.Int32                    elementId_button10  // 0x0
  public    static  System.Int32                    elementId_button11  // 0x0
  public    static  System.Int32                    elementId_button12  // 0x0
  public    static  System.Int32                    elementId_button13  // 0x0
  public    static  System.Int32                    elementId_button14  // 0x0
  public    static  System.Int32                    elementId_button15  // 0x0
  public    static  System.Int32                    elementId_button16  // 0x0
  public    static  System.Int32                    elementId_button17  // 0x0
  public    static  System.Int32                    elementId_button18  // 0x0
  public    static  System.Int32                    elementId_button19  // 0x0
  public    static  System.Int32                    elementId_button20  // 0x0
  public    static  System.Int32                    elementId_button21  // 0x0
  public    static  System.Int32                    elementId_button22  // 0x0
  public    static  System.Int32                    elementId_button23  // 0x0
  public    static  System.Int32                    elementId_button24  // 0x0
  public    static  System.Int32                    elementId_button25  // 0x0
  public    static  System.Int32                    elementId_button26  // 0x0
  public    static  System.Int32                    elementId_button27  // 0x0
  public    static  System.Int32                    elementId_button28  // 0x0
  public    static  System.Int32                    elementId_button29  // 0x0
  public    static  System.Int32                    elementId_button30  // 0x0
  public    static  System.Int32                    elementId_button31  // 0x0
  public    static  System.Int32                    elementId_button32  // 0x0
  public    static  System.Int32                    elementId_hat1Up  // 0x0
  public    static  System.Int32                    elementId_hat1UpRight  // 0x0
  public    static  System.Int32                    elementId_hat1Right  // 0x0
  public    static  System.Int32                    elementId_hat1DownRight  // 0x0
  public    static  System.Int32                    elementId_hat1Down  // 0x0
  public    static  System.Int32                    elementId_hat1DownLeft  // 0x0
  public    static  System.Int32                    elementId_hat1Left  // 0x0
  public    static  System.Int32                    elementId_hat1UpLeft  // 0x0
  public    static  System.Int32                    elementId_hat2Up  // 0x0
  public    static  System.Int32                    elementId_hat2UpRight  // 0x0
  public    static  System.Int32                    elementId_hat2Right  // 0x0
  public    static  System.Int32                    elementId_hat2DownRight  // 0x0
  public    static  System.Int32                    elementId_hat2Down  // 0x0
  public    static  System.Int32                    elementId_hat2DownLeft  // 0x0
  public    static  System.Int32                    elementId_hat2Left  // 0x0
  public    static  System.Int32                    elementId_hat2UpLeft  // 0x0
  public    static  System.Int32                    elementId_hat1  // 0x0
  public    static  System.Int32                    elementId_hat2  // 0x0
  public    static  System.Int32                    elementId_throttle1  // 0x0
  public    static  System.Int32                    elementId_throttle2  // 0x0
  public    static  System.Int32                    elementId_stick  // 0x0
METHODS:
  Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis1()
  Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis2()
  Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis3()
  Rewired.IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis4()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button1()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button2()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button3()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button4()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button5()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button6()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button7()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button8()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button9()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button10()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button11()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button12()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button13()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button14()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button15()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button16()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button17()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button18()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button19()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button20()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button21()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button22()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button23()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button24()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button25()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button26()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button27()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button28()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button29()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button30()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button31()
  Rewired.IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button32()
  Rewired.IControllerTemplateHat Rewired.ISixDofControllerTemplate.get_hat1()
  Rewired.IControllerTemplateHat Rewired.ISixDofControllerTemplate.get_hat2()
  Rewired.IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.get_throttle1()
  Rewired.IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.get_throttle2()
  Rewired.IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.get_stick()
  System.Void .ctor(System.Object payload)
  System.Void .cctor()
END_CLASS

CLASS: Rewired.InputManager
TYPE:  class
TOKEN: 0x200000E
EXTENDS: InputManager_Base
FIELDS:
  private           System.Boolean                  ignoreRecompile  // 0x50
METHODS:
  System.Void OnInitialized()
  System.Void OnDeinitialized()
  System.Void DetectPlatform()
  System.Void CheckRecompile()
  Rewired.Utils.Interfaces.IExternalTools GetExternalTools()
  System.Boolean CheckDeviceName(System.String searchPattern, System.String deviceName, System.String deviceModel)
  System.Void SubscribeEvents()
  System.Void UnsubscribeEvents()
  System.Void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
  System.Void .ctor()
END_CLASS

CLASS: Rewired.Data.UserDataStore_File
TYPE:  class
TOKEN: 0x2000010
EXTENDS: UserDataStore_KeyValue
FIELDS:
  private   static readonly System.String                   thisScriptName  // 0x0
  private   static  System.String                   logPrefix  // 0x0
  private   static  System.String                   defaultExtensionText  // 0x0
  private   static  System.String                   defaultExtensionBinary  // 0x0
  private   static  System.String                   defaultFileName  // 0x0
  private           System.String                   _fileName  // 0x38
  private           Rewired.Data.UserDataStore_File.DataFormat_dataFormat  // 0x40
  private           System.String                   __directory  // 0x48
  private           Rewired.Data.UserDataStore_File.DataStore_dataStore  // 0x50
  private           Rewired.Data.UserDataStore_File.IDataHandler__dataHandler  // 0x58
  private           System.Boolean                  _initialized  // 0x60
METHODS:
  System.String get_directory()
  System.Void set_directory(System.String value)
  System.String get_fileName()
  System.Void set_fileName(System.String value)
  Rewired.Data.UserDataStore_File.DataFormat get_dataFormat()
  System.Void set_dataFormat(Rewired.Data.UserDataStore_File.DataFormat value)
  Rewired.Data.UserDataStore_File.IDataHandler get_dataHandler()
  System.Void set_dataHandler(Rewired.Data.UserDataStore_File.IDataHandler value)
  Rewired.Data.UserDataStore_KeyValue.IDataStore get_dataStore()
  System.Void SetInitialValues()
  System.Void OnInitialize()
  System.Void OnDataSourceChanged()
  System.Void .ctor()
  System.Void .cctor()
  Rewired.Data.UserDataStore_File.DataFormat <get_dataHandler>b__17_0()
END_CLASS

CLASS: Rewired.Data.UserDataStore_KeyValue
TYPE:  class
TOKEN: 0x2000018
EXTENDS: UserDataStore
FIELDS:
  private   static readonly System.String                   thisScriptName  // 0x0
  private   static  System.String                   logPrefix  // 0x0
  private   static  System.String                   key_controllerAssignments  // 0x0
  private   static  System.Int32                    controllerMapKeyVersion  // 0x0
  private           System.Boolean                  _isEnabled  // 0x18
  private           System.Boolean                  _loadDataOnStart  // 0x19
  private           System.Boolean                  _loadJoystickAssignments  // 0x1A
  private           System.Boolean                  _loadKeyboardAssignments  // 0x1B
  private           System.Boolean                  _loadMouseAssignments  // 0x1C
  private           System.Boolean                  _allowImpreciseJoystickAssignmentMatching  // 0x1D
  private           System.Boolean                  _deferredJoystickAssignmentLoadPending  // 0x1E
  private           System.Boolean                  _wasJoystickEverDetected  // 0x1F
  private           System.Collections.Generic.List<System.Int32>__allActionIds  // 0x20
  private           System.String                   __allActionIdsString  // 0x28
  private   readonly System.Text.StringBuilder       _sb  // 0x30
METHODS:
  System.Boolean get_isEnabled()
  System.Void set_isEnabled(System.Boolean value)
  System.Boolean get_loadDataOnStart()
  System.Void set_loadDataOnStart(System.Boolean value)
  System.Boolean get_loadJoystickAssignments()
  System.Void set_loadJoystickAssignments(System.Boolean value)
  System.Boolean get_loadKeyboardAssignments()
  System.Void set_loadKeyboardAssignments(System.Boolean value)
  System.Boolean get_loadMouseAssignments()
  System.Void set_loadMouseAssignments(System.Boolean value)
  Rewired.Data.UserDataStore_KeyValue.IDataStore get_dataStore()
  System.Boolean get_loadControllerAssignments()
  System.Collections.Generic.List<System.Int32> get_allActionIds()
  System.String get_allActionIdsString()
  System.Void Save()
  System.Void SaveControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void SaveControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void SavePlayerData(System.Int32 playerId)
  System.Void SaveInputBehavior(System.Int32 playerId, System.Int32 behaviorId)
  System.Void Load()
  System.Void LoadControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void LoadControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void LoadPlayerData(System.Int32 playerId)
  System.Void LoadInputBehavior(System.Int32 playerId, System.Int32 behaviorId)
  System.Void OnInitialize()
  System.Void OnControllerConnected(Rewired.ControllerStatusChangedEventArgs args)
  System.Void OnControllerPreDisconnect(Rewired.ControllerStatusChangedEventArgs args)
  System.Void OnControllerDisconnected(Rewired.ControllerStatusChangedEventArgs args)
  System.Void SaveControllerMap(System.Int32 playerId, Rewired.ControllerMap controllerMap)
  Rewired.ControllerMap LoadControllerMap(System.Int32 playerId, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId)
  System.Void ClearSaveData()
  System.Int32 LoadAll()
  System.Int32 LoadPlayerDataNow(System.Int32 playerId)
  System.Int32 LoadPlayerDataNow(Rewired.Player player)
  System.Int32 LoadAllJoystickCalibrationData()
  System.Int32 LoadJoystickCalibrationData(Rewired.Joystick joystick)
  System.Int32 LoadJoystickCalibrationData(System.Int32 joystickId)
  System.Int32 LoadJoystickData(System.Int32 joystickId)
  System.Int32 LoadControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Int32 LoadControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Int32 LoadControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  Rewired.ControllerMap LoadControllerMap(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId)
  System.Int32 LoadInputBehaviors(System.Int32 playerId)
  System.Int32 LoadInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId)
  System.Int32 LoadInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior)
  System.Boolean LoadControllerAssignmentsNow()
  System.Boolean LoadKeyboardAndMouseAssignmentsNow(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo data)
  System.Boolean LoadJoystickAssignmentsNow(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo data)
  Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo LoadControllerAssignmentData()
  System.Collections.IEnumerator LoadJoystickAssignmentsDeferred()
  System.Void SaveAll()
  System.Void SavePlayerDataNow(System.Int32 playerId)
  System.Void SavePlayerDataNow(Rewired.Player player)
  System.Void SaveAllJoystickCalibrationData()
  System.Void SaveJoystickCalibrationData(System.Int32 joystickId)
  System.Void SaveJoystickCalibrationData(Rewired.Joystick joystick)
  System.Void SaveJoystickData(System.Int32 joystickId)
  System.Void SaveControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void SaveControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void SaveControllerMaps(Rewired.Player player, Rewired.PlayerSaveData playerSaveData)
  System.Void SaveControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void SaveControllerMap(Rewired.Player player, Rewired.ControllerMap controllerMap)
  System.Void SaveInputBehaviors(Rewired.Player player, Rewired.PlayerSaveData playerSaveData)
  System.Void SaveInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId)
  System.Void SaveInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior)
  System.Boolean SaveControllerAssignments()
  System.Void AppendBaseKey(System.Text.StringBuilder sb, Rewired.Player player)
  System.String GetControllerMapKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion)
  System.String GetControllerMapKnownActionIdsKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion)
  System.Void AppendControllerMapKeyCommonSuffix(System.Text.StringBuilder sb, Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 keyVersion)
  System.String GetJoystickCalibrationMapKey(Rewired.Joystick joystick)
  System.String GetInputBehaviorKey(Rewired.Player player, System.Int32 inputBehaviorId)
  System.String GetControllerMapJson(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId)
  System.Collections.Generic.List<System.Int32> GetControllerMapKnownActionIds(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId)
  System.String GetJoystickCalibrationMapJson(Rewired.Joystick joystick)
  System.String GetInputBehaviorJson(Rewired.Player player, System.Int32 id)
  System.Void AddDefaultMappingsForNewActions(Rewired.ControllerIdentifier controllerIdentifier, Rewired.ControllerMap controllerMap, System.Collections.Generic.List<System.Int32> knownActionIds)
  Rewired.Joystick FindJoystickPrecise(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
  System.Boolean TryFindJoysticksImprecise(Rewired.Data.UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, System.Collections.Generic.List<Rewired.Joystick>& matches)
  System.Void RefreshLayoutManager(System.Int32 playerId)
  System.Int32 GetDuplicateIndex(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier)
  System.Boolean TryGetString(Rewired.Data.UserDataStore_KeyValue.IDataStore store, System.String key, System.String& result)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Rewired.Data.UserDataStore_PlayerPrefs
TYPE:  class
TOKEN: 0x2000022
EXTENDS: UserDataStore
FIELDS:
  private   static  System.String                   thisScriptName  // 0x0
  private   static  System.String                   logPrefix  // 0x0
  private   static  System.String                   editorLoadedMessage  // 0x0
  private   static  System.String                   playerPrefsKeySuffix_controllerAssignments  // 0x0
  private   static  System.Int32                    controllerMapPPKeyVersion_original  // 0x0
  private   static  System.Int32                    controllerMapPPKeyVersion_includeDuplicateJoystickIndex  // 0x0
  private   static  System.Int32                    controllerMapPPKeyVersion_supportDisconnectedControllers  // 0x0
  private   static  System.Int32                    controllerMapPPKeyVersion_includeFormatVersion  // 0x0
  private   static  System.Int32                    controllerMapPPKeyVersion  // 0x0
  private           System.Boolean                  isEnabled  // 0x18
  private           System.Boolean                  loadDataOnStart  // 0x19
  private           System.Boolean                  loadJoystickAssignments  // 0x1A
  private           System.Boolean                  loadKeyboardAssignments  // 0x1B
  private           System.Boolean                  loadMouseAssignments  // 0x1C
  private           System.String                   playerPrefsKeyPrefix  // 0x20
  private           System.Boolean                  allowImpreciseJoystickAssignmentMatching  // 0x28
  private           System.Boolean                  deferredJoystickAssignmentLoadPending  // 0x29
  private           System.Boolean                  wasJoystickEverDetected  // 0x2A
  private           System.Collections.Generic.List<System.Int32>__allActionIds  // 0x30
  private           System.String                   __allActionIdsString  // 0x38
METHODS:
  System.Boolean get_IsEnabled()
  System.Void set_IsEnabled(System.Boolean value)
  System.Boolean get_LoadDataOnStart()
  System.Void set_LoadDataOnStart(System.Boolean value)
  System.Boolean get_LoadJoystickAssignments()
  System.Void set_LoadJoystickAssignments(System.Boolean value)
  System.Boolean get_LoadKeyboardAssignments()
  System.Void set_LoadKeyboardAssignments(System.Boolean value)
  System.Boolean get_LoadMouseAssignments()
  System.Void set_LoadMouseAssignments(System.Boolean value)
  System.String get_PlayerPrefsKeyPrefix()
  System.Void set_PlayerPrefsKeyPrefix(System.String value)
  System.String get_playerPrefsKey_controllerAssignments()
  System.Boolean get_loadControllerAssignments()
  System.Collections.Generic.List<System.Int32> get_allActionIds()
  System.String get_allActionIdsString()
  System.Void Save()
  System.Void SaveControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void SaveControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void SavePlayerData(System.Int32 playerId)
  System.Void SaveInputBehavior(System.Int32 playerId, System.Int32 behaviorId)
  System.Void Load()
  System.Void LoadControllerData(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void LoadControllerData(Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void LoadPlayerData(System.Int32 playerId)
  System.Void LoadInputBehavior(System.Int32 playerId, System.Int32 behaviorId)
  System.Void OnInitialize()
  System.Void OnControllerConnected(Rewired.ControllerStatusChangedEventArgs args)
  System.Void OnControllerPreDisconnect(Rewired.ControllerStatusChangedEventArgs args)
  System.Void OnControllerDisconnected(Rewired.ControllerStatusChangedEventArgs args)
  System.Void SaveControllerMap(System.Int32 playerId, Rewired.ControllerMap controllerMap)
  Rewired.ControllerMap LoadControllerMap(System.Int32 playerId, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId)
  System.Int32 LoadAll()
  System.Int32 LoadPlayerDataNow(System.Int32 playerId)
  System.Int32 LoadPlayerDataNow(Rewired.Player player)
  System.Int32 LoadAllJoystickCalibrationData()
  System.Int32 LoadJoystickCalibrationData(Rewired.Joystick joystick)
  System.Int32 LoadJoystickCalibrationData(System.Int32 joystickId)
  System.Int32 LoadJoystickData(System.Int32 joystickId)
  System.Int32 LoadControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Int32 LoadControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Int32 LoadControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  Rewired.ControllerMap LoadControllerMap(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId)
  System.Int32 LoadInputBehaviors(System.Int32 playerId)
  System.Int32 LoadInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId)
  System.Int32 LoadInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior)
  System.Boolean LoadControllerAssignmentsNow()
  System.Boolean LoadKeyboardAndMouseAssignmentsNow(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
  System.Boolean LoadJoystickAssignmentsNow(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
  Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData()
  System.Collections.IEnumerator LoadJoystickAssignmentsDeferred()
  System.Void SaveAll()
  System.Void SavePlayerDataNow(System.Int32 playerId)
  System.Void SavePlayerDataNow(Rewired.Player player)
  System.Void SaveAllJoystickCalibrationData()
  System.Void SaveJoystickCalibrationData(System.Int32 joystickId)
  System.Void SaveJoystickCalibrationData(Rewired.Joystick joystick)
  System.Void SaveJoystickData(System.Int32 joystickId)
  System.Void SaveControllerDataNow(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void SaveControllerDataNow(Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void SaveControllerMaps(Rewired.Player player, Rewired.PlayerSaveData playerSaveData)
  System.Void SaveControllerMaps(System.Int32 playerId, Rewired.ControllerType controllerType, System.Int32 controllerId)
  System.Void SaveControllerMap(Rewired.Player player, Rewired.ControllerMap controllerMap)
  System.Void SaveInputBehaviors(Rewired.Player player, Rewired.PlayerSaveData playerSaveData)
  System.Void SaveInputBehaviorNow(System.Int32 playerId, System.Int32 behaviorId)
  System.Void SaveInputBehaviorNow(Rewired.Player player, Rewired.InputBehavior inputBehavior)
  System.Boolean SaveControllerAssignments()
  System.Boolean ControllerAssignmentSaveDataExists()
  System.String GetBasePlayerPrefsKey(Rewired.Player player)
  System.String GetControllerMapPlayerPrefsKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion)
  System.String GetControllerMapKnownActionIdsPlayerPrefsKey(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion)
  System.String GetControllerMapPlayerPrefsKeyCommonSuffix(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId, System.Int32 ppKeyVersion)
  System.String GetJoystickCalibrationMapPlayerPrefsKey(Rewired.Joystick joystick)
  System.String GetInputBehaviorPlayerPrefsKey(Rewired.Player player, System.Int32 inputBehaviorId)
  System.String GetControllerMapXml(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId)
  System.Collections.Generic.List<System.Int32> GetControllerMapKnownActionIds(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier, System.Int32 categoryId, System.Int32 layoutId)
  System.String GetJoystickCalibrationMapXml(Rewired.Joystick joystick)
  System.String GetInputBehaviorXml(Rewired.Player player, System.Int32 id)
  System.Void AddDefaultMappingsForNewActions(Rewired.ControllerIdentifier controllerIdentifier, Rewired.ControllerMap controllerMap, System.Collections.Generic.List<System.Int32> knownActionIds)
  Rewired.Joystick FindJoystickPrecise(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
  System.Boolean TryFindJoysticksImprecise(Rewired.Data.UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, System.Collections.Generic.List<Rewired.Joystick>& matches)
  System.Int32 GetDuplicateIndex(Rewired.Player player, Rewired.ControllerIdentifier controllerIdentifier)
  System.Void RefreshLayoutManager(System.Int32 playerId)
  System.Type GetControllerMapType(Rewired.ControllerType controllerType)
  System.Void .ctor()
END_CLASS

CLASS: Rewired.Integration.UnityUI.PlayerPointerEventData
TYPE:  class
TOKEN: 0x200002C
EXTENDS: PointerEventData
FIELDS:
  private           System.Int32                    <playerId>k__BackingField  // 0x160
  private           System.Int32                    <inputSourceIndex>k__BackingField  // 0x164
  private           Rewired.UI.IMouseInputSource    <mouseSource>k__BackingField  // 0x168
  private           Rewired.UI.ITouchInputSource    <touchSource>k__BackingField  // 0x170
  private           Rewired.Integration.UnityUI.PointerEventType<sourceType>k__BackingField  // 0x178
  private           System.Int32                    <buttonIndex>k__BackingField  // 0x17C
METHODS:
  System.Int32 get_playerId()
  System.Void set_playerId(System.Int32 value)
  System.Int32 get_inputSourceIndex()
  System.Void set_inputSourceIndex(System.Int32 value)
  Rewired.UI.IMouseInputSource get_mouseSource()
  System.Void set_mouseSource(Rewired.UI.IMouseInputSource value)
  Rewired.UI.ITouchInputSource get_touchSource()
  System.Void set_touchSource(Rewired.UI.ITouchInputSource value)
  Rewired.Integration.UnityUI.PointerEventType get_sourceType()
  System.Void set_sourceType(Rewired.Integration.UnityUI.PointerEventType value)
  System.Int32 get_buttonIndex()
  System.Void set_buttonIndex(System.Int32 value)
  System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem)
  System.String ToString()
END_CLASS

CLASS: Rewired.Integration.UnityUI.RewiredEventSystem
TYPE:  class
TOKEN: 0x200002D
EXTENDS: EventSystem
FIELDS:
  private           System.Boolean                  _alwaysUpdate  // 0x50
METHODS:
  System.Boolean get_alwaysUpdate()
  System.Void set_alwaysUpdate(System.Boolean value)
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: Rewired.Integration.UnityUI.RewiredPointerInputModule
TYPE:  class
TOKEN: 0x200002E
EXTENDS: BaseInputModule
FIELDS:
  public    static  System.Int32                    kMouseLeftId  // 0x0
  public    static  System.Int32                    kMouseRightId  // 0x0
  public    static  System.Int32                    kMouseMiddleId  // 0x0
  public    static  System.Int32                    kFakeTouchesId  // 0x0
  private   static  System.Int32                    customButtonsStartingId  // 0x0
  private   static  System.Int32                    customButtonsMaxCount  // 0x0
  private   static  System.Int32                    customButtonsLastId  // 0x0
  private   readonly System.Collections.Generic.List<Rewired.UI.IMouseInputSource>m_MouseInputSourcesList  // 0x48
  private           System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,Rewired.Integration.UnityUI.PlayerPointerEventData>[]>m_PlayerPointerData  // 0x50
  private           Rewired.UI.ITouchInputSource    m_UserDefaultTouchInputSource  // 0x58
  private           Rewired.Integration.UnityUI.RewiredPointerInputModule.UnityInputSource__m_DefaultInputSource  // 0x60
  private   readonly Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseStatem_MouseState  // 0x68
METHODS:
  Rewired.Integration.UnityUI.RewiredPointerInputModule.UnityInputSource get_defaultInputSource()
  Rewired.UI.IMouseInputSource get_defaultMouseInputSource()
  Rewired.UI.ITouchInputSource get_defaultTouchInputSource()
  System.Boolean IsDefaultMouse(Rewired.UI.IMouseInputSource mouse)
  Rewired.UI.IMouseInputSource GetMouseInputSource(System.Int32 playerId, System.Int32 mouseIndex)
  System.Void RemoveMouseInputSource(Rewired.UI.IMouseInputSource source)
  System.Void AddMouseInputSource(Rewired.UI.IMouseInputSource source)
  System.Int32 GetMouseInputSourceCount(System.Int32 playerId)
  Rewired.UI.ITouchInputSource GetTouchInputSource(System.Int32 playerId, System.Int32 sourceIndex)
  System.Void RemoveTouchInputSource(Rewired.UI.ITouchInputSource source)
  System.Void AddTouchInputSource(Rewired.UI.ITouchInputSource source)
  System.Int32 GetTouchInputSourceCount(System.Int32 playerId)
  System.Void ClearMouseInputSources()
  System.Boolean get_isMouseSupported()
  System.Boolean IsDefaultPlayer(System.Int32 playerId)
  System.Boolean GetPointerData(System.Int32 playerId, System.Int32 pointerIndex, System.Int32 pointerTypeId, Rewired.Integration.UnityUI.PlayerPointerEventData& data, System.Boolean create, Rewired.Integration.UnityUI.PointerEventType pointerEventType)
  Rewired.Integration.UnityUI.PlayerPointerEventData CreatePointerEventData(System.Int32 playerId, System.Int32 pointerIndex, System.Int32 pointerTypeId, Rewired.Integration.UnityUI.PointerEventType pointerEventType)
  System.Void RemovePointerData(Rewired.Integration.UnityUI.PlayerPointerEventData data)
  Rewired.Integration.UnityUI.PlayerPointerEventData GetTouchPointerEventData(System.Int32 playerId, System.Int32 touchDeviceIndex, UnityEngine.Touch input, System.Boolean& pressed, System.Boolean& released)
  Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseState GetMousePointerEventData(System.Int32 playerId, System.Int32 mouseIndex)
  Rewired.Integration.UnityUI.PlayerPointerEventData GetLastPointerEventData(System.Int32 playerId, System.Int32 pointerIndex, System.Int32 pointerTypeId, System.Boolean ignorePointerTypeId, Rewired.Integration.UnityUI.PointerEventType pointerEventType)
  System.Boolean ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, System.Single threshold, System.Boolean useDragThreshold)
  System.Void ProcessMove(Rewired.Integration.UnityUI.PlayerPointerEventData pointerEvent)
  System.Void ProcessDrag(Rewired.Integration.UnityUI.PlayerPointerEventData pointerEvent)
  System.Boolean IsPointerOverGameObject(System.Int32 pointerTypeId)
  System.Void ClearSelection()
  System.String ToString()
  System.Void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent)
  System.Void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to)
  UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(System.Int32 playerId, System.Int32 mouseIndex, System.Int32 buttonId)
  System.Void .ctor()
END_CLASS

CLASS: Rewired.Integration.UnityUI.PointerEventType
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Rewired.Integration.UnityUI.PointerEventTypeMouse  // 0x0
  public    static  Rewired.Integration.UnityUI.PointerEventTypeTouch  // 0x0
METHODS:
END_CLASS

CLASS: Rewired.Integration.UnityUI.RewiredStandaloneInputModule
TYPE:  class
TOKEN: 0x2000034
EXTENDS: RewiredPointerInputModule
FIELDS:
  private   static  System.String                   DEFAULT_ACTION_MOVE_HORIZONTAL  // 0x0
  private   static  System.String                   DEFAULT_ACTION_MOVE_VERTICAL  // 0x0
  private   static  System.String                   DEFAULT_ACTION_SUBMIT  // 0x0
  private   static  System.String                   DEFAULT_ACTION_CANCEL  // 0x0
  private           Rewired.InputManager_Base       rewiredInputManager  // 0x70
  private           System.Boolean                  useAllRewiredGamePlayers  // 0x78
  private           System.Boolean                  useRewiredSystemPlayer  // 0x79
  private           System.Int32[]                  rewiredPlayerIds  // 0x80
  private           System.Boolean                  usePlayingPlayersOnly  // 0x88
  private           System.Collections.Generic.List<Rewired.Components.PlayerMouse>playerMice  // 0x90
  private           System.Boolean                  moveOneElementPerAxisPress  // 0x98
  private           System.Boolean                  setActionsById  // 0x99
  private           System.Int32                    horizontalActionId  // 0x9C
  private           System.Int32                    verticalActionId  // 0xA0
  private           System.Int32                    submitActionId  // 0xA4
  private           System.Int32                    cancelActionId  // 0xA8
  private           System.String                   m_HorizontalAxis  // 0xB0
  private           System.String                   m_VerticalAxis  // 0xB8
  private           System.String                   m_SubmitButton  // 0xC0
  private           System.String                   m_CancelButton  // 0xC8
  private           System.Single                   m_InputActionsPerSecond  // 0xD0
  private           System.Single                   m_RepeatDelay  // 0xD4
  private           System.Boolean                  m_allowMouseInput  // 0xD8
  private           System.Boolean                  m_allowMouseInputIfTouchSupported  // 0xD9
  private           System.Boolean                  m_allowTouchInput  // 0xDA
  private           System.Boolean                  m_deselectIfBackgroundClicked  // 0xDB
  private           System.Boolean                  m_deselectBeforeSelecting  // 0xDC
  private           System.Boolean                  m_ForceModuleActive  // 0xDD
  private           System.Int32[]                  playerIds  // 0xE0
  private           System.Boolean                  recompiling  // 0xE8
  private           System.Boolean                  isTouchSupported  // 0xE9
  private           System.Double                   m_PrevActionTime  // 0xF0
  private           UnityEngine.Vector2             m_LastMoveVector  // 0xF8
  private           System.Int32                    m_ConsecutiveMoveCount  // 0x100
  private           System.Boolean                  m_HasFocus  // 0x104
METHODS:
  Rewired.InputManager_Base get_RewiredInputManager()
  System.Void set_RewiredInputManager(Rewired.InputManager_Base value)
  System.Boolean get_UseAllRewiredGamePlayers()
  System.Void set_UseAllRewiredGamePlayers(System.Boolean value)
  System.Boolean get_UseRewiredSystemPlayer()
  System.Void set_UseRewiredSystemPlayer(System.Boolean value)
  System.Int32[] get_RewiredPlayerIds()
  System.Void set_RewiredPlayerIds(System.Int32[] value)
  System.Boolean get_UsePlayingPlayersOnly()
  System.Void set_UsePlayingPlayersOnly(System.Boolean value)
  System.Collections.Generic.List<Rewired.Components.PlayerMouse> get_PlayerMice()
  System.Void set_PlayerMice(System.Collections.Generic.List<Rewired.Components.PlayerMouse> value)
  System.Boolean get_MoveOneElementPerAxisPress()
  System.Void set_MoveOneElementPerAxisPress(System.Boolean value)
  System.Boolean get_allowMouseInput()
  System.Void set_allowMouseInput(System.Boolean value)
  System.Boolean get_allowMouseInputIfTouchSupported()
  System.Void set_allowMouseInputIfTouchSupported(System.Boolean value)
  System.Boolean get_allowTouchInput()
  System.Void set_allowTouchInput(System.Boolean value)
  System.Boolean get_deselectIfBackgroundClicked()
  System.Void set_deselectIfBackgroundClicked(System.Boolean value)
  System.Boolean get_deselectBeforeSelecting()
  System.Void set_deselectBeforeSelecting(System.Boolean value)
  System.Boolean get_SetActionsById()
  System.Void set_SetActionsById(System.Boolean value)
  System.Int32 get_HorizontalActionId()
  System.Void set_HorizontalActionId(System.Int32 value)
  System.Int32 get_VerticalActionId()
  System.Void set_VerticalActionId(System.Int32 value)
  System.Int32 get_SubmitActionId()
  System.Void set_SubmitActionId(System.Int32 value)
  System.Int32 get_CancelActionId()
  System.Void set_CancelActionId(System.Int32 value)
  System.Boolean get_isMouseSupported()
  System.Boolean get_isTouchAllowed()
  System.Boolean get_allowActivationOnMobileDevice()
  System.Void set_allowActivationOnMobileDevice(System.Boolean value)
  System.Boolean get_forceModuleActive()
  System.Void set_forceModuleActive(System.Boolean value)
  System.Single get_inputActionsPerSecond()
  System.Void set_inputActionsPerSecond(System.Single value)
  System.Single get_repeatDelay()
  System.Void set_repeatDelay(System.Single value)
  System.String get_horizontalAxis()
  System.Void set_horizontalAxis(System.String value)
  System.String get_verticalAxis()
  System.Void set_verticalAxis(System.String value)
  System.String get_submitButton()
  System.Void set_submitButton(System.String value)
  System.String get_cancelButton()
  System.Void set_cancelButton(System.String value)
  System.Void .ctor()
  System.Void Awake()
  System.Void UpdateModule()
  System.Boolean IsModuleSupported()
  System.Boolean ShouldActivateModule()
  System.Void ActivateModule()
  System.Void DeactivateModule()
  System.Void Process()
  System.Boolean ProcessTouchEvents()
  System.Void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, System.Boolean pressed, System.Boolean released)
  System.Boolean SendSubmitEventToSelectedObject()
  UnityEngine.Vector2 GetRawMoveVector()
  System.Boolean SendMoveEventToSelectedObject()
  System.Void CheckButtonOrKeyMovement(System.Boolean& downHorizontal, System.Boolean& downVertical)
  System.Void ProcessMouseEvents()
  System.Void ProcessMouseEvent(System.Int32 playerId, System.Int32 pointerIndex)
  System.Boolean SendUpdateEventToSelectedObject()
  System.Void ProcessMousePress(Rewired.Integration.UnityUI.RewiredPointerInputModule.MouseButtonEventData data)
  System.Void HandleMouseTouchDeselectionOnSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent)
  System.Void OnApplicationFocus(System.Boolean hasFocus)
  System.Boolean ShouldIgnoreEventsOnNoFocus()
  System.Void OnDestroy()
  System.Boolean IsDefaultPlayer(System.Int32 playerId)
  System.Void InitializeRewired()
  System.Void SetupRewiredVars()
  System.Void SetUpRewiredPlayerMice()
  System.Void SetUpRewiredActions()
  System.Boolean GetButton(Rewired.Player player, System.Int32 actionId)
  System.Boolean GetButtonDown(Rewired.Player player, System.Int32 actionId)
  System.Boolean GetNegativeButton(Rewired.Player player, System.Int32 actionId)
  System.Boolean GetNegativeButtonDown(Rewired.Player player, System.Int32 actionId)
  System.Single GetAxis(Rewired.Player player, System.Int32 actionId)
  System.Void CheckEditorRecompile()
  System.Void OnEditorRecompile()
  System.Void ClearRewiredVars()
  System.Boolean DidAnyMouseMove()
  System.Boolean GetMouseButtonDownOnAnyMouse(System.Int32 buttonIndex)
  System.Void OnRewiredInitialized()
  System.Void OnRewiredShutDown()
END_CLASS

CLASS: Rewired.Internal.ControllerTemplateFactory
TYPE:  class
TOKEN: 0x200002B
FIELDS:
  private   static readonly System.Type[]                   _defaultTemplateTypes  // 0x0
  private   static readonly System.Type[]                   _defaultTemplateInterfaceTypes  // 0x8
METHODS:
  System.Type[] get_templateTypes()
  System.Type[] get_templateInterfaceTypes()
  Rewired.IControllerTemplate Create(System.Guid typeGuid, System.Object payload)
  System.Void .cctor()
END_CLASS

CLASS: Rewired.Localization.LocalizedStringProvider
TYPE:  class
TOKEN: 0x2000036
EXTENDS: LocalizedStringProviderBase
FIELDS:
  private           UnityEngine.TextAsset           _localizedStringsFile  // 0x20
  private           System.Collections.Generic.Dictionary<System.String,System.String>_dictionary  // 0x28
  private           System.Boolean                  _initialized  // 0x30
METHODS:
  System.Collections.Generic.Dictionary<System.String,System.String> get_dictionary()
  System.Void set_dictionary(System.Collections.Generic.Dictionary<System.String,System.String> value)
  UnityEngine.TextAsset get_localizedStringsFile()
  System.Void set_localizedStringsFile(UnityEngine.TextAsset value)
  System.Boolean get_initialized()
  System.Boolean Initialize()
  System.Boolean TryLoadLocalizedStringData()
  System.Boolean TryGetLocalizedString(System.String key, System.String& result)
  System.Void .ctor()
END_CLASS

CLASS: Rewired.Localization.LocalizedStringProviderBase
TYPE:  class
TOKEN: 0x2000037
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  _prefetch  // 0x18
METHODS:
  System.Boolean get_prefetch()
  System.Void set_prefetch(System.Boolean value)
  System.Boolean get_initialized()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void TrySetLocalizedStringProvider()
  System.Boolean Initialize()
  System.Void Reload()
  System.Boolean TryGetLocalizedString(System.String key, System.String& result)
  System.Boolean Rewired.Interfaces.ILocalizedStringProvider.TryGetLocalizedString(System.String key, System.String& result)
  System.Void .ctor()
END_CLASS

CLASS: Rewired.Utils.ExternalTools
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  private   static  System.Func<System.Object>      _getPlatformInitializerDelegate  // 0x0
  private           System.Boolean                  _isEditorPaused  // 0x10
  private           System.Action<System.Boolean>   _EditorPausedStateChangedEvent  // 0x18
  private           System.Action<System.UInt32,System.Boolean>XboxOneInput_OnGamepadStateChange  // 0x20
METHODS:
  System.Func<System.Object> get_getPlatformInitializerDelegate()
  System.Void set_getPlatformInitializerDelegate(System.Func<System.Object> value)
  System.Void .ctor()
  System.Void Destroy()
  System.Boolean get_isEditorPaused()
  System.Void add_EditorPausedStateChangedEvent(System.Action<System.Boolean> value)
  System.Void remove_EditorPausedStateChangedEvent(System.Action<System.Boolean> value)
  System.Object GetPlatformInitializer()
  System.String GetFocusedEditorWindowTitle()
  System.Boolean IsEditorSceneViewFocused()
  System.Boolean LinuxInput_IsJoystickPreconfigured(System.String name)
  System.Void add_XboxOneInput_OnGamepadStateChange(System.Action<System.UInt32,System.Boolean> value)
  System.Void remove_XboxOneInput_OnGamepadStateChange(System.Action<System.UInt32,System.Boolean> value)
  System.Int32 XboxOneInput_GetUserIdForGamepad(System.UInt32 id)
  System.UInt64 XboxOneInput_GetControllerId(System.UInt32 unityJoystickId)
  System.Boolean XboxOneInput_IsGamepadActive(System.UInt32 unityJoystickId)
  System.String XboxOneInput_GetControllerType(System.UInt64 xboxControllerId)
  System.UInt32 XboxOneInput_GetJoystickId(System.UInt64 xboxControllerId)
  System.Void XboxOne_Gamepad_UpdatePlugin()
  System.Boolean XboxOne_Gamepad_SetGamepadVibration(System.UInt64 xboxOneJoystickId, System.Single leftMotor, System.Single rightMotor, System.Single leftTriggerLevel, System.Single rightTriggerLevel)
  System.Void XboxOne_Gamepad_PulseVibrateMotor(System.UInt64 xboxOneJoystickId, System.Int32 motorInt, System.Single startLevel, System.Single endLevel, System.UInt64 durationMS)
  System.Void GetDeviceVIDPIDs(System.Collections.Generic.List<System.Int32>& vids, System.Collections.Generic.List<System.Int32>& pids)
  System.Int32 GetAndroidAPILevel()
  System.Void WindowsStandalone_ForwardRawInput(System.IntPtr rawInputHeaderIndices, System.IntPtr rawInputDataIndices, System.UInt32 indicesCount, System.IntPtr rawInputData, System.UInt32 rawInputDataSize)
  System.Boolean UnityUI_Graphic_GetRaycastTarget(System.Object graphic)
  System.Void UnityUI_Graphic_SetRaycastTarget(System.Object graphic, System.Boolean value)
  System.Boolean get_UnityInput_IsTouchPressureSupported()
  System.Single UnityInput_GetTouchPressure(UnityEngine.Touch& touch)
  System.Single UnityInput_GetTouchMaximumPossiblePressure(UnityEngine.Touch& touch)
  Rewired.IControllerTemplate CreateControllerTemplate(System.Guid typeGuid, System.Object payload)
  System.Type[] GetControllerTemplateTypes()
  System.Type[] GetControllerTemplateInterfaceTypes()
END_CLASS

