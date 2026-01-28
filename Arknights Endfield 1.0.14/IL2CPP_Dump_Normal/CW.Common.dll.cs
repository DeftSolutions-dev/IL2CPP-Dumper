// ========================================================
// Dumped by @desirepro
// Assembly: CW.Common.dll
// Classes:  34
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000007
    public struct LinkType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CW.Common.CwDemoButton.LinkType PreviousScene;        // 0x0
        public static CW.Common.CwDemoButton.LinkType NextScene;        // 0x0
        public static CW.Common.CwDemoButton.LinkType Publisher;        // 0x0
        public static CW.Common.CwDemoButton.LinkType URL;        // 0x0
        public static CW.Common.CwDemoButton.LinkType Isolate;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct ToggleType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CW.Common.CwDemoButton.ToggleType KeepSelected;        // 0x0
        public static CW.Common.CwDemoButton.ToggleType ToggleSelection;        // 0x0
        public static CW.Common.CwDemoButton.ToggleType SelectPrevious;        // 0x0

    }

    // TypeToken: 0x200000D
    public interface IHasChildren
    {
        // Methods
        private System.Boolean HasChild(CW.Common.CwChild child) { }

    }

    // TypeToken: 0x2000010
    public struct FollowType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CW.Common.CwFollow.FollowType TargetTransform;        // 0x0
        public static CW.Common.CwFollow.FollowType MainCamera;        // 0x0

    }

    // TypeToken: 0x2000011
    public struct UpdateType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CW.Common.CwFollow.UpdateType Update;        // 0x0
        public static CW.Common.CwFollow.UpdateType LateUpdate;        // 0x0

    }

    // TypeToken: 0x2000013
    public struct AxisGesture
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CW.Common.CwInputManager.AxisGesture HorizontalDrag;        // 0x0
        public static CW.Common.CwInputManager.AxisGesture VerticalDrag;        // 0x0
        public static CW.Common.CwInputManager.AxisGesture Twist;        // 0x0
        public static CW.Common.CwInputManager.AxisGesture HorizontalPull;        // 0x0
        public static CW.Common.CwInputManager.AxisGesture VerticalPull;        // 0x0

    }

    // TypeToken: 0x2000014
    public struct Axis
    {
        // Fields
        public System.Int32 FingerCount;        // 0x10
        public System.Boolean FingerInvert;        // 0x14
        public CW.Common.CwInputManager.AxisGesture FingerGesture;        // 0x18
        public System.Single FingerSensitivity;        // 0x1C
        public UnityEngine.KeyCode KeyNegative;        // 0x20
        public UnityEngine.KeyCode KeyPositive;        // 0x24
        public UnityEngine.KeyCode KeyNegativeAlt;        // 0x28
        public UnityEngine.KeyCode KeyPositiveAlt;        // 0x2C
        public System.Single KeySensitivity;        // 0x30

        // Methods
        private System.Void .ctor(System.Int32 fCount, System.Boolean fInvert, CW.Common.CwInputManager.AxisGesture fGesture, System.Single fSensitivty, UnityEngine.KeyCode kNegative, UnityEngine.KeyCode kPositive, UnityEngine.KeyCode kNegativeAlt, UnityEngine.KeyCode kPositiveAlt, System.Single kSensitivity) { }
        private System.Single GetValue(System.Single delta) { }

    }

    // TypeToken: 0x2000015
    public struct Trigger
    {
        // Fields
        public System.Boolean UseFinger;        // 0x10
        public System.Boolean UseMouse;        // 0x11
        public UnityEngine.KeyCode UseKey;        // 0x14

        // Methods
        private System.Void .ctor(System.Boolean uFinger, System.Boolean uMouse, UnityEngine.KeyCode uKey) { }
        private System.Boolean WentDown(CW.Common.CwInputManager.Finger finger) { }
        private System.Boolean IsDown(CW.Common.CwInputManager.Finger finger) { }
        private System.Boolean WentUp(CW.Common.CwInputManager.Finger finger, System.Boolean useAnyFinger) { }

    }

    // TypeToken: 0x2000016
    public class Link
    {
        // Fields
        public CW.Common.CwInputManager.Finger Finger;        // 0x10

        // Methods
        private T Find(System.Collections.Generic.List<T> links, CW.Common.CwInputManager.Finger finger) { }
        private T Create(System.Collections.Generic.List<T>& links, CW.Common.CwInputManager.Finger finger) { }
        private System.Void ClearAll(System.Collections.Generic.List<T> links) { }
        private System.Void ClearAndRemove(System.Collections.Generic.List<T> links, T link) { }
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public class Finger
    {
        // Fields
        public System.Int32 Index;        // 0x10
        public System.Single Pressure;        // 0x14
        public System.Boolean Down;        // 0x18
        public System.Boolean Up;        // 0x19
        public System.Single Age;        // 0x1C
        public System.Boolean StartedOverGui;        // 0x20
        public UnityEngine.Vector2 StartScreenPosition;        // 0x24
        public UnityEngine.Vector2 ScreenPosition;        // 0x2C
        public UnityEngine.Vector2 ScreenPositionOld;        // 0x34
        public UnityEngine.Vector2 ScreenPositionOldOld;        // 0x3C
        public UnityEngine.Vector2 ScreenPositionOldOldOld;        // 0x44

        // Methods
        private System.Single get_SmoothScreenPositionDelta() { }
        private UnityEngine.Vector2 GetSmoothScreenPosition(System.Single t) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public struct Pipeline
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static CW.Common.CwShaderBundle.Pipeline Invalid;        // 0x0
        public static CW.Common.CwShaderBundle.Pipeline Standard;        // 0x0
        public static CW.Common.CwShaderBundle.Pipeline URP2019;        // 0x0
        public static CW.Common.CwShaderBundle.Pipeline URP2020;        // 0x0
        public static CW.Common.CwShaderBundle.Pipeline URP2021;        // 0x0
        public static CW.Common.CwShaderBundle.Pipeline HDRP2019;        // 0x0
        public static CW.Common.CwShaderBundle.Pipeline HDRP2020;        // 0x0
        public static CW.Common.CwShaderBundle.Pipeline HDRP2021;        // 0x0
        public static CW.Common.CwShaderBundle.Pipeline COUNT;        // 0x0

    }

    // TypeToken: 0x2000022
    public class ShaderVariant
    {
        // Fields
        public CW.Common.CwShaderBundle.Pipeline Pipe;        // 0x10
        public System.String Code;        // 0x18
        public System.Int32 Hash;        // 0x20
        public System.Boolean Dirty;        // 0x24

        // Methods
        private System.String get_HashString() { }
        private System.Void .ctor() { }

    }

namespace CW.Common
{

    // TypeToken: 0x2000002
    public class CwCameraLook : MonoBehaviour
    {
        // Fields
        private System.Boolean listen;        // 0x18
        private System.Single damping;        // 0x1C
        private System.Single sensitivity;        // 0x20
        private CW.Common.CwInputManager.Axis pitchControls;        // 0x24
        private CW.Common.CwInputManager.Axis yawControls;        // 0x48
        private CW.Common.CwInputManager.Axis rollControls;        // 0x6C
        private UnityEngine.Quaternion remainingDelta;        // 0x90

        // Methods
        private System.Void set_Listen(System.Boolean value) { }
        private System.Boolean get_Listen() { }
        private System.Void set_Damping(System.Single value) { }
        private System.Single get_Damping() { }
        private System.Void set_Sensitivity(System.Single value) { }
        private System.Single get_Sensitivity() { }
        private System.Void set_PitchControls(CW.Common.CwInputManager.Axis value) { }
        private CW.Common.CwInputManager.Axis get_PitchControls() { }
        private System.Void set_YawControls(CW.Common.CwInputManager.Axis value) { }
        private CW.Common.CwInputManager.Axis get_YawControls() { }
        private System.Void set_RollControls(CW.Common.CwInputManager.Axis value) { }
        private CW.Common.CwInputManager.Axis get_RollControls() { }
        private System.Void Start() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void OnApplicationFocus(System.Boolean focus) { }
        private System.Void AddToDelta() { }
        private System.Void DampenDelta() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000003
    public class CwCameraMove : MonoBehaviour
    {
        // Fields
        private System.Boolean listen;        // 0x18
        private System.Single damping;        // 0x1C
        private System.Single sensitivity;        // 0x20
        private CW.Common.CwInputManager.Axis horizontalControls;        // 0x24
        private CW.Common.CwInputManager.Axis depthControls;        // 0x48
        private CW.Common.CwInputManager.Axis verticalControls;        // 0x6C
        private UnityEngine.Vector3 remainingDelta;        // 0x90

        // Methods
        private System.Void set_Listen(System.Boolean value) { }
        private System.Boolean get_Listen() { }
        private System.Void set_Damping(System.Single value) { }
        private System.Single get_Damping() { }
        private System.Void set_Sensitivity(System.Single value) { }
        private System.Single get_Sensitivity() { }
        private System.Void set_HorizontalControls(CW.Common.CwInputManager.Axis value) { }
        private CW.Common.CwInputManager.Axis get_HorizontalControls() { }
        private System.Void set_DepthControls(CW.Common.CwInputManager.Axis value) { }
        private CW.Common.CwInputManager.Axis get_DepthControls() { }
        private System.Void set_VerticalControls(CW.Common.CwInputManager.Axis value) { }
        private CW.Common.CwInputManager.Axis get_VerticalControls() { }
        private System.Void Start() { }
        private System.Void Update() { }
        private System.Void AddToDelta() { }
        private System.Void DampenDelta() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class CwCameraPivot : MonoBehaviour
    {
        // Fields
        private System.Boolean listen;        // 0x18
        private System.Single damping;        // 0x1C
        private CW.Common.CwInputManager.Axis pitchControls;        // 0x20
        private CW.Common.CwInputManager.Axis yawControls;        // 0x44
        private UnityEngine.Vector3 remainingDelta;        // 0x68

        // Methods
        private System.Void set_Listen(System.Boolean value) { }
        private System.Boolean get_Listen() { }
        private System.Void set_Damping(System.Single value) { }
        private System.Single get_Damping() { }
        private System.Void set_PitchControls(CW.Common.CwInputManager.Axis value) { }
        private CW.Common.CwInputManager.Axis get_PitchControls() { }
        private System.Void set_YawControls(CW.Common.CwInputManager.Axis value) { }
        private CW.Common.CwInputManager.Axis get_YawControls() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void AddToDelta() { }
        private System.Void DampenDelta() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class CwDemo : MonoBehaviour
    {
        // Fields
        private System.Boolean upgradeInputModule;        // 0x18
        private System.Boolean changeExposureInHDRP;        // 0x19
        private System.Boolean changeVisualEnvironmentInHDRP;        // 0x1A
        private System.Boolean changeFogInHDRP;        // 0x1B
        private System.Boolean changeCloudsInHDRP;        // 0x1C
        private System.Boolean changeMotionBlurInHDRP;        // 0x1D
        private System.Boolean upgradeLightsInHDRP;        // 0x1E
        private System.Boolean upgradeCamerasInHDRP;        // 0x1F

        // Methods
        private System.Void set_UpgradeInputModule(System.Boolean value) { }
        private System.Boolean get_UpgradeInputModule() { }
        private System.Void set_ChangeExposureInHDRP(System.Boolean value) { }
        private System.Boolean get_ChangeExposureInHDRP() { }
        private System.Void set_ChangeVisualEnvironmentInHDRP(System.Boolean value) { }
        private System.Boolean get_ChangeVisualEnvironmentInHDRP() { }
        private System.Void set_ChangeFogInHDRP(System.Boolean value) { }
        private System.Boolean get_ChangeFogInHDRP() { }
        private System.Void set_ChangeCloudsInHDRP(System.Boolean value) { }
        private System.Boolean get_ChangeCloudsInHDRP() { }
        private System.Void set_ChangeMotionBlurInHDRP(System.Boolean value) { }
        private System.Boolean get_ChangeMotionBlurInHDRP() { }
        private System.Void set_UpgradeLightsInHDRP(System.Boolean value) { }
        private System.Boolean get_UpgradeLightsInHDRP() { }
        private System.Void set_UpgradeCamerasInHDRP(System.Boolean value) { }
        private System.Boolean get_UpgradeCamerasInHDRP() { }
        private System.Void OnEnable() { }
        private System.Void TryApplyURP() { }
        private System.Void TryApplyHDRP() { }
        private System.Void TryCreateVolume() { }
        private System.Void TryUpgradeLights() { }
        private System.Void TryUpgradeCameras() { }
        private System.Void TryUpgradeEventSystem() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class CwDemoButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
    {
        // Fields
        private CW.Common.CwDemoButton.LinkType link;        // 0x18
        private System.String urlTarget;        // 0x20
        private UnityEngine.Transform isolateTarget;        // 0x28
        private CW.Common.CwDemoButton.ToggleType isolateToggle;        // 0x30
        private UnityEngine.CanvasGroup cachedCanvasGroup;        // 0x38
        private UnityEngine.Transform previousChild;        // 0x40

        // Methods
        private System.Void set_Link(CW.Common.CwDemoButton.LinkType value) { }
        private CW.Common.CwDemoButton.LinkType get_Link() { }
        private System.Void set_UrlTarget(System.String value) { }
        private System.String get_UrlTarget() { }
        private System.Void set_IsolateTarget(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_IsolateTarget() { }
        private System.Void set_IsolateToggle(CW.Common.CwDemoButton.ToggleType value) { }
        private CW.Common.CwDemoButton.ToggleType get_IsolateToggle() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Int32 GetCurrentLevel() { }
        private System.Int32 GetLevelCount() { }
        private System.Void LoadLevel(System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class CwDemoButtonBuilder : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject buttonPrefab;        // 0x18
        private UnityEngine.RectTransform buttonRoot;        // 0x20
        private UnityEngine.Sprite icon;        // 0x28
        private UnityEngine.Color color;        // 0x30
        private System.String overrideName;        // 0x40
        private UnityEngine.GameObject clone;        // 0x48

        // Methods
        private System.Void set_ButtonPrefab(UnityEngine.GameObject value) { }
        private UnityEngine.GameObject get_ButtonPrefab() { }
        private System.Void set_ButtonRoot(UnityEngine.RectTransform value) { }
        private UnityEngine.RectTransform get_ButtonRoot() { }
        private System.Void set_Icon(UnityEngine.Sprite value) { }
        private UnityEngine.Sprite get_Icon() { }
        private System.Void set_Color(UnityEngine.Color value) { }
        private UnityEngine.Color get_Color() { }
        private System.Void set_OverrideName(System.String value) { }
        private System.String get_OverrideName() { }
        private System.Void Build() { }
        private System.Void BuildAll() { }
        private UnityEngine.GameObject DoInstantiate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class CwLightIntensity : MonoBehaviour
    {
        // Fields
        private System.Single multiplier;        // 0x18
        private System.Single intensityInStandard;        // 0x1C
        private System.Single intensityInURP;        // 0x20
        private System.Single intensityInHDRP;        // 0x24
        private UnityEngine.Light cachedLight;        // 0x28
        private System.Boolean cachedLightSet;        // 0x30

        // Methods
        private System.Void set_Multiplier(System.Single value) { }
        private System.Single get_Multiplier() { }
        private System.Void set_IntensityInStandard(System.Single value) { }
        private System.Single get_IntensityInStandard() { }
        private System.Void set_IntensityInURP(System.Single value) { }
        private System.Single get_IntensityInURP() { }
        private System.Void set_IntensityInHDRP(System.Single value) { }
        private System.Single get_IntensityInHDRP() { }
        private UnityEngine.Light get_CachedLight() { }
        private System.Void Update() { }
        private System.Void ApplyIntensity(System.Single intensity) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class CwRotate : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 angularVelocity;        // 0x18
        private UnityEngine.Space relativeTo;        // 0x24

        // Methods
        private System.Void set_AngularVelocity(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_AngularVelocity() { }
        private System.Void set_RelativeTo(UnityEngine.Space value) { }
        private UnityEngine.Space get_RelativeTo() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class CwChild : MonoBehaviour
    {
        // Methods
        private System.Void DestroyGameObjectIfInvalid() { }
        private CW.Common.CwChild.IHasChildren GetParent() { }
        private System.Void Start() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public class CwDepthTextureMode : MonoBehaviour
    {
        // Fields
        private UnityEngine.DepthTextureMode depthMode;        // 0x18
        private UnityEngine.Camera cachedCamera;        // 0x20

        // Methods
        private System.Void set_DepthMode(UnityEngine.DepthTextureMode value) { }
        private UnityEngine.DepthTextureMode get_DepthMode() { }
        private System.Void UpdateDepthMode() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class CwFollow : MonoBehaviour
    {
        // Fields
        private CW.Common.CwFollow.FollowType follow;        // 0x18
        private UnityEngine.Transform target;        // 0x20
        private System.Single damping;        // 0x28
        private System.Boolean rotate;        // 0x2C
        private System.Boolean ignoreZ;        // 0x2D
        private CW.Common.CwFollow.UpdateType followIn;        // 0x30
        private UnityEngine.Vector3 localPosition;        // 0x34
        private UnityEngine.Vector3 localRotation;        // 0x40

        // Methods
        private System.Void set_Follow(CW.Common.CwFollow.FollowType value) { }
        private CW.Common.CwFollow.FollowType get_Follow() { }
        private System.Void set_Target(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_Target() { }
        private System.Void set_Damping(System.Single value) { }
        private System.Single get_Damping() { }
        private System.Void set_Rotate(System.Boolean value) { }
        private System.Boolean get_Rotate() { }
        private System.Void set_IgnoreZ(System.Boolean value) { }
        private System.Boolean get_IgnoreZ() { }
        private System.Void set_FollowIn(CW.Common.CwFollow.UpdateType value) { }
        private CW.Common.CwFollow.UpdateType get_FollowIn() { }
        private System.Void set_LocalPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_LocalPosition() { }
        private System.Void set_LocalRotation(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_LocalRotation() { }
        private System.Void UpdatePosition() { }
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class CwInputManager : MonoBehaviour
    {
        // Fields
        private UnityEngine.LayerMask guiLayers;        // 0x18
        private static System.Action<CW.Common.CwInputManager.Finger> OnFingerDown;        // 0x0
        private static System.Action<CW.Common.CwInputManager.Finger> OnFingerUpdate;        // 0x8
        private static System.Action<CW.Common.CwInputManager.Finger> OnFingerUp;        // 0x10
        public static System.Int32 MOUSE_FINGER_INDEX;        // 0x0
        public static System.Int32 HOVER_FINGER_INDEX;        // 0x0
        private static System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> tempRaycastResults;        // 0x18
        private static UnityEngine.EventSystems.PointerEventData tempPointerEventData;        // 0x20
        private static UnityEngine.EventSystems.EventSystem tempEventSystem;        // 0x28
        private static System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers;        // 0x30
        private static System.Collections.Generic.List<CW.Common.CwInputManager.Finger> filteredFingers;        // 0x38
        private static System.Collections.Generic.Stack<CW.Common.CwInputManager.Finger> pool;        // 0x40

        // Methods
        private System.Void set_GuiLayers(UnityEngine.LayerMask value) { }
        private UnityEngine.LayerMask get_GuiLayers() { }
        private System.Void add_OnFingerDown(System.Action<CW.Common.CwInputManager.Finger> value) { }
        private System.Void remove_OnFingerDown(System.Action<CW.Common.CwInputManager.Finger> value) { }
        private System.Void add_OnFingerUpdate(System.Action<CW.Common.CwInputManager.Finger> value) { }
        private System.Void remove_OnFingerUpdate(System.Action<CW.Common.CwInputManager.Finger> value) { }
        private System.Void add_OnFingerUp(System.Action<CW.Common.CwInputManager.Finger> value) { }
        private System.Void remove_OnFingerUp(System.Action<CW.Common.CwInputManager.Finger> value) { }
        private System.Collections.Generic.List<CW.Common.CwInputManager.Finger> get_Fingers() { }
        private System.Single get_ScaleFactor() { }
        private System.Collections.Generic.List<CW.Common.CwInputManager.Finger> GetFingers(System.Boolean ignoreStartedOverGui, System.Boolean ignoreHover) { }
        private System.Boolean PointOverGui(UnityEngine.Vector2 screenPosition, System.Int32 guiLayers) { }
        private System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> RaycastGui(UnityEngine.Vector2 screenPosition, System.Int32 guiLayers) { }
        private UnityEngine.Vector2 GetAveragePosition(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers) { }
        private UnityEngine.Vector2 GetAverageOldPosition(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers) { }
        private UnityEngine.Vector2 GetAveragePullScaled(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers) { }
        private UnityEngine.Vector2 GetAverageDeltaScaled(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers) { }
        private System.Single GetAverageTwistRadians(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers) { }
        private System.Void EnsureThisComponentExists() { }
        private System.Void Update() { }
        private CW.Common.CwInputManager.Finger FindFinger(System.Int32 index) { }
        private System.Void AddFinger(System.Int32 index, UnityEngine.Vector2 screenPosition, System.Single pressure, System.Boolean set) { }
        private UnityEngine.Vector2 Hermite(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 d, System.Single t) { }
        private System.Single HermiteInterpolate(System.Single y0, System.Single y1, System.Single y2, System.Single y3, System.Single mu, System.Single mu2, System.Single mu3) { }
        private System.Single GetRadians(UnityEngine.Vector2 screenPosition, UnityEngine.Vector2 referencePoint) { }
        private System.Single GetDeltaRadians(CW.Common.CwInputManager.Finger finger, UnityEngine.Vector2 referencePoint, UnityEngine.Vector2 lastReferencePoint) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000018
    public class CwRenderTextureManager : MonoBehaviour
    {
        // Fields
        private System.Int32 lifetime;        // 0x18

        // Methods
        private System.Void set_Lifetime(System.Int32 value) { }
        private System.Int32 get_Lifetime() { }
        private UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc, System.String title) { }
        private UnityEngine.RenderTexture ReleaseTemporary(UnityEngine.RenderTexture renderTexture) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class CwRoot : MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.List<CW.Common.CwRoot> instances;        // 0x0

        // Methods
        private System.Boolean get_Exists() { }
        private UnityEngine.Transform get_Root() { }
        private UnityEngine.Transform GetRoot() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001A
    public class CwSeedAttribute : PropertyAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public class CwShared
    {
        // Fields
        public static System.String HelpUrlPrefix;        // 0x0
        public static System.String ComponentMenuPrefix;        // 0x0
        public static System.String GameObjectMenuPrefix;        // 0x0

    }

    // TypeToken: 0x200001C
    public class CwGuide : ScriptableObject
    {
        // Fields
        public System.String LongName;        // 0x18
        public System.String ShortName;        // 0x20
        public UnityEngine.TextAsset Documentation;        // 0x28
        private UnityEngine.Texture2D icon;        // 0x30
        private System.String version;        // 0x38

        // Methods
        private UnityEngine.Texture2D get_Icon() { }
        private System.String get_Version() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001D
    public class CwHelper
    {
        // Fields
        private static System.Collections.Generic.Stack<UnityEngine.Random.State> seedStates;        // 0x0
        public static System.Collections.Generic.List<UnityEngine.Material> tempMaterials;        // 0x8
        public static System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> tempProperties;        // 0x10
        private static System.Action<UnityEngine.Camera> OnCameraPreRender;        // 0x18
        private static System.Action<UnityEngine.Camera> OnCameraPostRender;        // 0x20
        private static System.Collections.Generic.Stack<UnityEngine.RenderTexture> actives;        // 0x28
        private static System.Int32 uniqueSeed;        // 0x30
        private static System.Collections.Generic.List<UnityEngine.Material> materials;        // 0x38

        // Methods
        private System.Void add_OnCameraPreRender(System.Action<UnityEngine.Camera> value) { }
        private System.Void remove_OnCameraPreRender(System.Action<UnityEngine.Camera> value) { }
        private System.Void add_OnCameraPostRender(System.Action<UnityEngine.Camera> value) { }
        private System.Void remove_OnCameraPostRender(System.Action<UnityEngine.Camera> value) { }
        private System.Void .cctor() { }
        private T GetOrAddComponent(UnityEngine.GameObject gameObject, System.Boolean recordUndo) { }
        private T AddComponent(UnityEngine.GameObject gameObject, System.Boolean recordUndo) { }
        private System.Boolean IndexInMask(System.Int32 index, System.Int32 mask) { }
        private UnityEngine.Camera GetCamera(UnityEngine.Camera currentCamera, UnityEngine.GameObject gameObject) { }
        private UnityEngine.Vector3 GetObserverPosition(UnityEngine.Transform observer) { }
        private System.Boolean Enabled(UnityEngine.Behaviour b) { }
        private System.Void BeginSeed() { }
        private System.Void BeginSeed(System.Int32 newSeed) { }
        private System.Void EndSeed() { }
        private UnityEngine.Color Brighten(UnityEngine.Color color, System.Single brightness, System.Boolean convertToGamma) { }
        private UnityEngine.Color Premultiply(UnityEngine.Color color) { }
        private System.Single Saturate(System.Single c) { }
        private UnityEngine.Color Saturate(UnityEngine.Color c) { }
        private System.Void Resize(System.Collections.Generic.List<T> list, System.Int32 size) { }
        private System.Single Sharpness(System.Single a, System.Single p) { }
        private UnityEngine.Color ToLinear(UnityEngine.Color gamma) { }
        private System.Single ToLinear(System.Single gamma) { }
        private UnityEngine.Color ToGamma(UnityEngine.Color linear) { }
        private System.Single ToGamma(System.Single linear) { }
        private System.Single UniformScale(UnityEngine.Vector3 scale) { }
        private System.Void BeginActive(UnityEngine.RenderTexture renderTexture) { }
        private System.Void EndActive() { }
        private System.Void SetTempMaterial(UnityEngine.Material material) { }
        private System.Void SetTempMaterial(UnityEngine.Material material1, UnityEngine.Material material2) { }
        private System.Void SetTempMaterial(System.Collections.Generic.List<UnityEngine.Material> materials) { }
        private System.Void SetTempMaterial(UnityEngine.MaterialPropertyBlock properties) { }
        private System.Void AddMaterial(UnityEngine.Renderer r, UnityEngine.Material m) { }
        private System.Void ReplaceMaterial(UnityEngine.Renderer r, UnityEngine.Material m) { }
        private System.Void RemoveMaterial(UnityEngine.Renderer r, UnityEngine.Material m) { }
        private UnityEngine.Texture2D CreateTempTexture2D(System.String name, System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean mips, System.Boolean linear) { }
        private UnityEngine.Material CreateTempMaterial(System.String materialName, System.String shaderName) { }
        private UnityEngine.Material CreateTempMaterial(System.String materialName, UnityEngine.Shader shader) { }
        private UnityEngine.Material CreateTempMaterial(System.String materialName, UnityEngine.Material source) { }
        private T Destroy(T o) { }
        private UnityEngine.GameObject CreateGameObject(System.String name, System.Int32 layer, UnityEngine.Transform parent, System.String recordUndo) { }
        private UnityEngine.GameObject CreateGameObject(System.String name, System.Int32 layer, UnityEngine.Transform parent, UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation, UnityEngine.Vector3 localScale, System.String recordUndo) { }
        private T CreateElement(UnityEngine.Transform parent) { }
        private System.Single Reciprocal(System.Single v) { }
        private System.Double Reciprocal(System.Double v) { }
        private System.Single Divide(System.Single a, System.Single b) { }
        private System.Double Divide(System.Double a, System.Double b) { }
        private System.Single Acos(System.Single v) { }
        private System.Double Acos(System.Double v) { }
        private System.Single DampenFactor(System.Single speed, System.Single elapsed) { }
        private System.Single DampenFactor(System.Single damping, System.Single deltaTime, System.Single linear) { }
        private System.Single Atan2(UnityEngine.Vector2 xy) { }
        private System.Int32 Mod(System.Int32 a, System.Int32 b) { }
        private System.Single Mod(System.Single a, System.Single b) { }
        private UnityEngine.Texture2D GetReadableCopy(UnityEngine.Texture texture, UnityEngine.TextureFormat format, System.Boolean mipMaps, System.Int32 width, System.Int32 height) { }

    }

    // TypeToken: 0x200001F
    public class CwInput
    {
        // Fields
        private static System.Collections.Generic.Dictionary<UnityEngine.KeyCode,UnityEngine.InputSystem.Key> keyMapping;        // 0x0

        // Methods
        private System.Void Enable() { }
        private UnityEngine.InputSystem.Controls.ButtonControl GetMouseButtonControl(System.Int32 index) { }
        private UnityEngine.InputSystem.Controls.ButtonControl GetButtonControl(UnityEngine.KeyCode oldKey) { }
        private System.Int32 GetTouchCount() { }
        private System.Void GetTouch(System.Int32 index, System.Int32& id, UnityEngine.Vector2& position, System.Single& pressure, System.Boolean& set) { }
        private UnityEngine.Vector2 GetMousePosition() { }
        private System.Boolean GetKeyWentDown(UnityEngine.KeyCode oldKey) { }
        private System.Boolean GetKeyIsHeld(UnityEngine.KeyCode oldKey) { }
        private System.Boolean GetKeyWentUp(UnityEngine.KeyCode oldKey) { }
        private System.Boolean GetMouseWentDown(System.Int32 index) { }
        private System.Boolean GetMouseIsHeld(System.Int32 index) { }
        private System.Boolean GetMouseWentUp(System.Int32 index) { }
        private System.Single GetMouseWheelDelta() { }
        private System.Boolean GetMouseExists() { }
        private System.Boolean GetKeyboardExists() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000020
    public class CwShaderBundle : ScriptableObject
    {
        // Fields
        private System.String title;        // 0x18
        private UnityEngine.Shader target;        // 0x20
        private System.Int32 variantHash;        // 0x28
        private System.Int32 projectHash;        // 0x2C
        private System.Collections.Generic.List<CW.Common.CwShaderBundle.ShaderVariant> variants;        // 0x30

        // Methods
        private System.Void set_Title(System.String value) { }
        private System.String get_Title() { }
        private System.Void set_Target(UnityEngine.Shader value) { }
        private UnityEngine.Shader get_Target() { }
        private System.Void set_VariantHash(System.Int32 value) { }
        private System.Int32 get_VariantHash() { }
        private System.Void set_ProjectHash(System.Int32 value) { }
        private System.Int32 get_ProjectHash() { }
        private System.Collections.Generic.List<CW.Common.CwShaderBundle.ShaderVariant> get_Variants() { }
        private System.Boolean get_Dirty() { }
        private System.Int32 GetProjectHash() { }
        private CW.Common.CwShaderBundle.Pipeline DetectProjectPipeline() { }
        private System.Boolean IsStandard(CW.Common.CwShaderBundle.Pipeline pipe) { }
        private System.Boolean IsScriptable(CW.Common.CwShaderBundle.Pipeline pipe) { }
        private System.Boolean IsURP(CW.Common.CwShaderBundle.Pipeline pipe) { }
        private System.Boolean IsHDRP(CW.Common.CwShaderBundle.Pipeline pipe) { }
        private System.Void .ctor() { }

    }

}

