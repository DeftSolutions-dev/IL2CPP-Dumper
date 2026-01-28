// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.InputLegacyModule.dll
// Classes:  14
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: HitInfo
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            UnityEngine.GameObject          target  // 0x10
  public            UnityEngine.Camera              camera  // 0x18
METHODS:
  System.Void SendMessage(System.String name)
  System.Boolean op_Implicit(UnityEngine.SendMouseEvents.HitInfo exists)
  System.Boolean Compare(UnityEngine.SendMouseEvents.HitInfo lhs, UnityEngine.SendMouseEvents.HitInfo rhs)
END_CLASS

CLASS: UnityEngine.TouchPhase
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TouchPhase          Began  // 0x0
  public    static  UnityEngine.TouchPhase          Moved  // 0x0
  public    static  UnityEngine.TouchPhase          Stationary  // 0x0
  public    static  UnityEngine.TouchPhase          Ended  // 0x0
  public    static  UnityEngine.TouchPhase          Canceled  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.IMECompositionMode
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.IMECompositionMode  Auto  // 0x0
  public    static  UnityEngine.IMECompositionMode  On  // 0x0
  public    static  UnityEngine.IMECompositionMode  Off  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.TouchType
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.TouchType           Direct  // 0x0
  public    static  UnityEngine.TouchType           Indirect  // 0x0
  public    static  UnityEngine.TouchType           Stylus  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Touch
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  private           System.Int32                    m_FingerId  // 0x10
  private           UnityEngine.Vector2             m_Position  // 0x14
  private           UnityEngine.Vector2             m_RawPosition  // 0x1C
  private           UnityEngine.Vector2             m_PositionDelta  // 0x24
  private           System.Single                   m_TimeDelta  // 0x2C
  private           System.Int32                    m_TapCount  // 0x30
  private           UnityEngine.TouchPhase          m_Phase  // 0x34
  private           UnityEngine.TouchType           m_Type  // 0x38
  private           System.Single                   m_Pressure  // 0x3C
  private           System.Single                   m_maximumPossiblePressure  // 0x40
  private           System.Single                   m_Radius  // 0x44
  private           System.Single                   m_RadiusVariance  // 0x48
  private           System.Single                   m_AltitudeAngle  // 0x4C
  private           System.Single                   m_AzimuthAngle  // 0x50
METHODS:
  System.Int32 get_fingerId()
  UnityEngine.Vector2 get_position()
  System.Void set_position(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_rawPosition()
  System.Void set_rawPosition(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_deltaPosition()
  System.Void set_deltaPosition(UnityEngine.Vector2 value)
  System.Single get_deltaTime()
  System.Int32 get_tapCount()
  UnityEngine.TouchPhase get_phase()
  System.Single get_pressure()
  System.Single get_maximumPossiblePressure()
  UnityEngine.TouchType get_type()
  System.Single get_altitudeAngle()
  System.Single get_azimuthAngle()
  System.Single get_radius()
  System.Single get_radiusVariance()
END_CLASS

CLASS: UnityEngine.DeviceOrientation
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.DeviceOrientation   Unknown  // 0x0
  public    static  UnityEngine.DeviceOrientation   Portrait  // 0x0
  public    static  UnityEngine.DeviceOrientation   PortraitUpsideDown  // 0x0
  public    static  UnityEngine.DeviceOrientation   LandscapeLeft  // 0x0
  public    static  UnityEngine.DeviceOrientation   LandscapeRight  // 0x0
  public    static  UnityEngine.DeviceOrientation   FaceUp  // 0x0
  public    static  UnityEngine.DeviceOrientation   FaceDown  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AccelerationEvent
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  private           System.Single                   x  // 0x10
  private           System.Single                   y  // 0x14
  private           System.Single                   z  // 0x18
  private           System.Single                   m_TimeDelta  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.Gyroscope
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private           System.Int32                    m_GyroIndex  // 0x10
METHODS:
  System.Void .ctor(System.Int32 index)
END_CLASS

CLASS: UnityEngine.LocationService
TYPE:  class
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Compass
TYPE:  class
TOKEN: 0x200000A
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.CameraRaycastHelper
TYPE:  class
TOKEN: 0x200000B
FIELDS:
METHODS:
  UnityEngine.GameObject RaycastTry(UnityEngine.Camera cam, UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask)
  UnityEngine.GameObject RaycastTry2D(UnityEngine.Camera cam, UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask)
  UnityEngine.GameObject RaycastTry_Injected(UnityEngine.Camera cam, UnityEngine.Ray& ray, System.Single distance, System.Int32 layerMask)
  UnityEngine.GameObject RaycastTry2D_Injected(UnityEngine.Camera cam, UnityEngine.Ray& ray, System.Single distance, System.Int32 layerMask)
END_CLASS

CLASS: UnityEngine.Input
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private   static  UnityEngine.LocationService     locationServiceInstance  // 0x0
  private   static  UnityEngine.Compass             compassInstance  // 0x8
  private   static  UnityEngine.Gyroscope           s_MainGyro  // 0x10
METHODS:
  System.Boolean GetKeyInt(UnityEngine.KeyCode key)
  System.Boolean GetKeyString(System.String name)
  System.Boolean GetKeyUpInt(UnityEngine.KeyCode key)
  System.Boolean GetKeyUpString(System.String name)
  System.Boolean GetKeyDownInt(UnityEngine.KeyCode key)
  System.Boolean GetKeyDownString(System.String name)
  System.Single GetAxis(System.String axisName)
  System.Single GetAxisRaw(System.String axisName)
  System.Boolean GetButton(System.String buttonName)
  System.Boolean GetButtonDown(System.String buttonName)
  System.Boolean GetButtonUp(System.String buttonName)
  System.Boolean GetMouseButton(System.Int32 button)
  System.Boolean GetMouseButtonDown(System.Int32 button)
  System.Boolean GetMouseButtonUp(System.Int32 button)
  System.Void ResetInputAxes()
  System.String[] GetJoystickNames()
  UnityEngine.Touch GetTouch(System.Int32 index)
  UnityEngine.AccelerationEvent GetAccelerationEvent(System.Int32 index)
  System.Boolean GetKey(UnityEngine.KeyCode key)
  System.Boolean GetKey(System.String name)
  System.Boolean GetKeyUp(UnityEngine.KeyCode key)
  System.Boolean GetKeyUp(System.String name)
  System.Boolean GetKeyDown(UnityEngine.KeyCode key)
  System.Boolean GetKeyDown(System.String name)
  System.Void SimulateTouch(UnityEngine.Touch touch)
  System.Void SimulateTouchInternal(UnityEngine.Touch touch, System.Int64 timestamp)
  System.Boolean get_simulateMouseWithTouches()
  System.Void set_simulateMouseWithTouches(System.Boolean value)
  System.Boolean get_anyKey()
  System.Boolean get_anyKeyDown()
  System.String get_inputString()
  UnityEngine.Vector3 get_mousePosition()
  UnityEngine.Vector2 get_mouseScrollDelta()
  UnityEngine.IMECompositionMode get_imeCompositionMode()
  System.Void set_imeCompositionMode(UnityEngine.IMECompositionMode value)
  System.String get_compositionString()
  System.Boolean get_imeIsSelected()
  UnityEngine.Vector2 get_compositionCursorPos()
  System.Void set_compositionCursorPos(UnityEngine.Vector2 value)
  System.Boolean get_eatKeyPressOnTextFieldFocus()
  System.Void set_eatKeyPressOnTextFieldFocus(System.Boolean value)
  System.Boolean get_mousePresent()
  System.Int32 get_touchCount()
  System.Boolean get_touchPressureSupported()
  System.Boolean get_stylusTouchSupported()
  System.Boolean get_touchSupported()
  System.Boolean get_multiTouchEnabled()
  System.Void set_multiTouchEnabled(System.Boolean value)
  System.Boolean get_isGyroAvailable()
  UnityEngine.DeviceOrientation get_deviceOrientation()
  UnityEngine.Vector3 get_acceleration()
  System.Boolean get_compensateSensors()
  System.Void set_compensateSensors(System.Boolean value)
  System.Int32 get_accelerationEventCount()
  System.Boolean get_backButtonLeavesApp()
  System.Void set_backButtonLeavesApp(System.Boolean value)
  UnityEngine.LocationService get_location()
  UnityEngine.Compass get_compass()
  System.Int32 GetGyroInternal()
  UnityEngine.Gyroscope get_gyro()
  UnityEngine.Touch[] get_touches()
  UnityEngine.AccelerationEvent[] get_accelerationEvents()
  System.Boolean CheckDisabled()
  System.Void .ctor()
  System.Void GetTouch_Injected(System.Int32 index, UnityEngine.Touch& ret)
  System.Void GetAccelerationEvent_Injected(System.Int32 index, UnityEngine.AccelerationEvent& ret)
  System.Void SimulateTouchInternal_Injected(UnityEngine.Touch& touch, System.Int64 timestamp)
  System.Void get_mousePosition_Injected(UnityEngine.Vector3& ret)
  System.Void get_mouseScrollDelta_Injected(UnityEngine.Vector2& ret)
  System.Void get_compositionCursorPos_Injected(UnityEngine.Vector2& ret)
  System.Void set_compositionCursorPos_Injected(UnityEngine.Vector2& value)
  System.Void get_acceleration_Injected(UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.SendMouseEvents
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private   static  System.Boolean                  s_MouseUsed  // 0x0
  private   static readonly UnityEngine.SendMouseEvents.HitInfo[]m_LastHit  // 0x8
  private   static readonly UnityEngine.SendMouseEvents.HitInfo[]m_MouseDownHit  // 0x10
  private   static readonly UnityEngine.SendMouseEvents.HitInfo[]m_CurrentHit  // 0x18
  private   static  UnityEngine.Camera[]            m_Cameras  // 0x20
  public    static  System.Func<System.Collections.Generic.KeyValuePair<System.Int32,UnityEngine.Vector2>>s_GetMouseState  // 0x28
  private   static  UnityEngine.Vector2             s_MousePosition  // 0x30
  private   static  System.Boolean                  s_MouseButtonPressedThisFrame  // 0x38
  private   static  System.Boolean                  s_MouseButtonIsPressed  // 0x39
METHODS:
  System.Void UpdateMouse()
  System.Void SetMouseMoved()
  System.Void DoSendMouseEvents(System.Int32 skipRTCameras)
  System.Void SendEvents(System.Int32 i, UnityEngine.SendMouseEvents.HitInfo hit)
  System.Void .cctor()
END_CLASS

