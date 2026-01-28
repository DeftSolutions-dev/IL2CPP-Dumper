// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.InputLegacyModule.dll
// Classes:  14
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000E
    public struct HitInfo
    {
        // Fields
        public UnityEngine.GameObject target;        // 0x10
        public UnityEngine.Camera camera;        // 0x18

        // Methods
        private System.Void SendMessage(System.String name) { }
        private System.Boolean op_Implicit(UnityEngine.SendMouseEvents.HitInfo exists) { }
        private System.Boolean Compare(UnityEngine.SendMouseEvents.HitInfo lhs, UnityEngine.SendMouseEvents.HitInfo rhs) { }

    }

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public struct TouchPhase
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TouchPhase Began;        // 0x0
        public static UnityEngine.TouchPhase Moved;        // 0x0
        public static UnityEngine.TouchPhase Stationary;        // 0x0
        public static UnityEngine.TouchPhase Ended;        // 0x0
        public static UnityEngine.TouchPhase Canceled;        // 0x0

    }

    // TypeToken: 0x2000003
    public struct IMECompositionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.IMECompositionMode Auto;        // 0x0
        public static UnityEngine.IMECompositionMode On;        // 0x0
        public static UnityEngine.IMECompositionMode Off;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct TouchType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.TouchType Direct;        // 0x0
        public static UnityEngine.TouchType Indirect;        // 0x0
        public static UnityEngine.TouchType Stylus;        // 0x0

    }

    // TypeToken: 0x2000005
    public struct Touch
    {
        // Fields
        private System.Int32 m_FingerId;        // 0x10
        private UnityEngine.Vector2 m_Position;        // 0x14
        private UnityEngine.Vector2 m_RawPosition;        // 0x1C
        private UnityEngine.Vector2 m_PositionDelta;        // 0x24
        private System.Single m_TimeDelta;        // 0x2C
        private System.Int32 m_TapCount;        // 0x30
        private UnityEngine.TouchPhase m_Phase;        // 0x34
        private UnityEngine.TouchType m_Type;        // 0x38
        private System.Single m_Pressure;        // 0x3C
        private System.Single m_maximumPossiblePressure;        // 0x40
        private System.Single m_Radius;        // 0x44
        private System.Single m_RadiusVariance;        // 0x48
        private System.Single m_AltitudeAngle;        // 0x4C
        private System.Single m_AzimuthAngle;        // 0x50

        // Methods
        private System.Int32 get_fingerId() { }
        private UnityEngine.Vector2 get_position() { }
        private System.Void set_position(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_rawPosition() { }
        private System.Void set_rawPosition(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_deltaPosition() { }
        private System.Void set_deltaPosition(UnityEngine.Vector2 value) { }
        private System.Single get_deltaTime() { }
        private System.Int32 get_tapCount() { }
        private UnityEngine.TouchPhase get_phase() { }
        private System.Single get_pressure() { }
        private System.Single get_maximumPossiblePressure() { }
        private UnityEngine.TouchType get_type() { }
        private System.Single get_altitudeAngle() { }
        private System.Single get_azimuthAngle() { }
        private System.Single get_radius() { }
        private System.Single get_radiusVariance() { }

    }

    // TypeToken: 0x2000006
    public struct DeviceOrientation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.DeviceOrientation Unknown;        // 0x0
        public static UnityEngine.DeviceOrientation Portrait;        // 0x0
        public static UnityEngine.DeviceOrientation PortraitUpsideDown;        // 0x0
        public static UnityEngine.DeviceOrientation LandscapeLeft;        // 0x0
        public static UnityEngine.DeviceOrientation LandscapeRight;        // 0x0
        public static UnityEngine.DeviceOrientation FaceUp;        // 0x0
        public static UnityEngine.DeviceOrientation FaceDown;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct AccelerationEvent
    {
        // Fields
        private System.Single x;        // 0x10
        private System.Single y;        // 0x14
        private System.Single z;        // 0x18
        private System.Single m_TimeDelta;        // 0x1C

    }

    // TypeToken: 0x2000008
    public class Gyroscope
    {
        // Fields
        private System.Int32 m_GyroIndex;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 index) { }

    }

    // TypeToken: 0x2000009
    public class LocationService
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class Compass
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class CameraRaycastHelper
    {
        // Methods
        private UnityEngine.GameObject RaycastTry(UnityEngine.Camera cam, UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask) { }
        private UnityEngine.GameObject RaycastTry2D(UnityEngine.Camera cam, UnityEngine.Ray ray, System.Single distance, System.Int32 layerMask) { }
        private UnityEngine.GameObject RaycastTry_Injected(UnityEngine.Camera cam, UnityEngine.Ray& ray, System.Single distance, System.Int32 layerMask) { }
        private UnityEngine.GameObject RaycastTry2D_Injected(UnityEngine.Camera cam, UnityEngine.Ray& ray, System.Single distance, System.Int32 layerMask) { }

    }

    // TypeToken: 0x200000C
    public class Input
    {
        // Fields
        private static UnityEngine.LocationService locationServiceInstance;        // 0x0
        private static UnityEngine.Compass compassInstance;        // 0x8
        private static UnityEngine.Gyroscope s_MainGyro;        // 0x10

        // Methods
        private System.Boolean GetKeyInt(UnityEngine.KeyCode key) { }
        private System.Boolean GetKeyString(System.String name) { }
        private System.Boolean GetKeyUpInt(UnityEngine.KeyCode key) { }
        private System.Boolean GetKeyUpString(System.String name) { }
        private System.Boolean GetKeyDownInt(UnityEngine.KeyCode key) { }
        private System.Boolean GetKeyDownString(System.String name) { }
        private System.Single GetAxis(System.String axisName) { }
        private System.Single GetAxisRaw(System.String axisName) { }
        private System.Boolean GetButton(System.String buttonName) { }
        private System.Boolean GetButtonDown(System.String buttonName) { }
        private System.Boolean GetButtonUp(System.String buttonName) { }
        private System.Boolean GetMouseButton(System.Int32 button) { }
        private System.Boolean GetMouseButtonDown(System.Int32 button) { }
        private System.Boolean GetMouseButtonUp(System.Int32 button) { }
        private System.Void ResetInputAxes() { }
        private System.String[] GetJoystickNames() { }
        private UnityEngine.Touch GetTouch(System.Int32 index) { }
        private UnityEngine.AccelerationEvent GetAccelerationEvent(System.Int32 index) { }
        private System.Boolean GetKey(UnityEngine.KeyCode key) { }
        private System.Boolean GetKey(System.String name) { }
        private System.Boolean GetKeyUp(UnityEngine.KeyCode key) { }
        private System.Boolean GetKeyUp(System.String name) { }
        private System.Boolean GetKeyDown(UnityEngine.KeyCode key) { }
        private System.Boolean GetKeyDown(System.String name) { }
        private System.Void SimulateTouch(UnityEngine.Touch touch) { }
        private System.Void SimulateTouchInternal(UnityEngine.Touch touch, System.Int64 timestamp) { }
        private System.Boolean get_simulateMouseWithTouches() { }
        private System.Void set_simulateMouseWithTouches(System.Boolean value) { }
        private System.Boolean get_anyKey() { }
        private System.Boolean get_anyKeyDown() { }
        private System.String get_inputString() { }
        private UnityEngine.Vector3 get_mousePosition() { }
        private UnityEngine.Vector2 get_mouseScrollDelta() { }
        private UnityEngine.IMECompositionMode get_imeCompositionMode() { }
        private System.Void set_imeCompositionMode(UnityEngine.IMECompositionMode value) { }
        private System.String get_compositionString() { }
        private System.Boolean get_imeIsSelected() { }
        private UnityEngine.Vector2 get_compositionCursorPos() { }
        private System.Void set_compositionCursorPos(UnityEngine.Vector2 value) { }
        private System.Boolean get_eatKeyPressOnTextFieldFocus() { }
        private System.Void set_eatKeyPressOnTextFieldFocus(System.Boolean value) { }
        private System.Boolean get_mousePresent() { }
        private System.Int32 get_touchCount() { }
        private System.Boolean get_touchPressureSupported() { }
        private System.Boolean get_stylusTouchSupported() { }
        private System.Boolean get_touchSupported() { }
        private System.Boolean get_multiTouchEnabled() { }
        private System.Void set_multiTouchEnabled(System.Boolean value) { }
        private System.Boolean get_isGyroAvailable() { }
        private UnityEngine.DeviceOrientation get_deviceOrientation() { }
        private UnityEngine.Vector3 get_acceleration() { }
        private System.Boolean get_compensateSensors() { }
        private System.Void set_compensateSensors(System.Boolean value) { }
        private System.Int32 get_accelerationEventCount() { }
        private System.Boolean get_backButtonLeavesApp() { }
        private System.Void set_backButtonLeavesApp(System.Boolean value) { }
        private UnityEngine.LocationService get_location() { }
        private UnityEngine.Compass get_compass() { }
        private System.Int32 GetGyroInternal() { }
        private UnityEngine.Gyroscope get_gyro() { }
        private UnityEngine.Touch[] get_touches() { }
        private UnityEngine.AccelerationEvent[] get_accelerationEvents() { }
        private System.Boolean CheckDisabled() { }
        private System.Void .ctor() { }
        private System.Void GetTouch_Injected(System.Int32 index, UnityEngine.Touch& ret) { }
        private System.Void GetAccelerationEvent_Injected(System.Int32 index, UnityEngine.AccelerationEvent& ret) { }
        private System.Void SimulateTouchInternal_Injected(UnityEngine.Touch& touch, System.Int64 timestamp) { }
        private System.Void get_mousePosition_Injected(UnityEngine.Vector3& ret) { }
        private System.Void get_mouseScrollDelta_Injected(UnityEngine.Vector2& ret) { }
        private System.Void get_compositionCursorPos_Injected(UnityEngine.Vector2& ret) { }
        private System.Void set_compositionCursorPos_Injected(UnityEngine.Vector2& value) { }
        private System.Void get_acceleration_Injected(UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x200000D
    public class SendMouseEvents
    {
        // Fields
        private static System.Boolean s_MouseUsed;        // 0x0
        private static readonly UnityEngine.SendMouseEvents.HitInfo[] m_LastHit;        // 0x8
        private static readonly UnityEngine.SendMouseEvents.HitInfo[] m_MouseDownHit;        // 0x10
        private static readonly UnityEngine.SendMouseEvents.HitInfo[] m_CurrentHit;        // 0x18
        private static UnityEngine.Camera[] m_Cameras;        // 0x20
        public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,UnityEngine.Vector2>> s_GetMouseState;        // 0x28
        private static UnityEngine.Vector2 s_MousePosition;        // 0x30
        private static System.Boolean s_MouseButtonPressedThisFrame;        // 0x38
        private static System.Boolean s_MouseButtonIsPressed;        // 0x39

        // Methods
        private System.Void UpdateMouse() { }
        private System.Void SetMouseMoved() { }
        private System.Void DoSendMouseEvents(System.Int32 skipRTCameras) { }
        private System.Void SendEvents(System.Int32 i, UnityEngine.SendMouseEvents.HitInfo hit) { }
        private System.Void .cctor() { }

    }

}

