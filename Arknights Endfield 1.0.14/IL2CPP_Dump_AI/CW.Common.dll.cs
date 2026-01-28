// ========================================================
// Dumped by @desirepro
// Assembly: CW.Common.dll
// Classes:  34
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: LinkType
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwDemoButton.LinkType PreviousScene  // 0x0
  public    static  CW.Common.CwDemoButton.LinkType NextScene  // 0x0
  public    static  CW.Common.CwDemoButton.LinkType Publisher  // 0x0
  public    static  CW.Common.CwDemoButton.LinkType URL  // 0x0
  public    static  CW.Common.CwDemoButton.LinkType Isolate  // 0x0
METHODS:
END_CLASS

CLASS: ToggleType
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwDemoButton.ToggleTypeKeepSelected  // 0x0
  public    static  CW.Common.CwDemoButton.ToggleTypeToggleSelection  // 0x0
  public    static  CW.Common.CwDemoButton.ToggleTypeSelectPrevious  // 0x0
METHODS:
END_CLASS

CLASS: IHasChildren
TYPE:  interface
TOKEN: 0x200000D
FIELDS:
METHODS:
  System.Boolean HasChild(CW.Common.CwChild child)
END_CLASS

CLASS: FollowType
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwFollow.FollowType   TargetTransform  // 0x0
  public    static  CW.Common.CwFollow.FollowType   MainCamera  // 0x0
METHODS:
END_CLASS

CLASS: UpdateType
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwFollow.UpdateType   Update  // 0x0
  public    static  CW.Common.CwFollow.UpdateType   LateUpdate  // 0x0
METHODS:
END_CLASS

CLASS: AxisGesture
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwInputManager.AxisGestureHorizontalDrag  // 0x0
  public    static  CW.Common.CwInputManager.AxisGestureVerticalDrag  // 0x0
  public    static  CW.Common.CwInputManager.AxisGestureTwist  // 0x0
  public    static  CW.Common.CwInputManager.AxisGestureHorizontalPull  // 0x0
  public    static  CW.Common.CwInputManager.AxisGestureVerticalPull  // 0x0
METHODS:
END_CLASS

CLASS: Axis
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    FingerCount  // 0x10
  public            System.Boolean                  FingerInvert  // 0x14
  public            CW.Common.CwInputManager.AxisGestureFingerGesture  // 0x18
  public            System.Single                   FingerSensitivity  // 0x1C
  public            UnityEngine.KeyCode             KeyNegative  // 0x20
  public            UnityEngine.KeyCode             KeyPositive  // 0x24
  public            UnityEngine.KeyCode             KeyNegativeAlt  // 0x28
  public            UnityEngine.KeyCode             KeyPositiveAlt  // 0x2C
  public            System.Single                   KeySensitivity  // 0x30
METHODS:
  System.Void .ctor(System.Int32 fCount, System.Boolean fInvert, CW.Common.CwInputManager.AxisGesture fGesture, System.Single fSensitivty, UnityEngine.KeyCode kNegative, UnityEngine.KeyCode kPositive, UnityEngine.KeyCode kNegativeAlt, UnityEngine.KeyCode kPositiveAlt, System.Single kSensitivity)
  System.Single GetValue(System.Single delta)
END_CLASS

CLASS: Trigger
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Boolean                  UseFinger  // 0x10
  public            System.Boolean                  UseMouse  // 0x11
  public            UnityEngine.KeyCode             UseKey  // 0x14
METHODS:
  System.Void .ctor(System.Boolean uFinger, System.Boolean uMouse, UnityEngine.KeyCode uKey)
  System.Boolean WentDown(CW.Common.CwInputManager.Finger finger)
  System.Boolean IsDown(CW.Common.CwInputManager.Finger finger)
  System.Boolean WentUp(CW.Common.CwInputManager.Finger finger, System.Boolean useAnyFinger)
END_CLASS

CLASS: Link
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  public            CW.Common.CwInputManager.Finger Finger  // 0x10
METHODS:
  T Find(System.Collections.Generic.List<T> links, CW.Common.CwInputManager.Finger finger)
  T Create(System.Collections.Generic.List<T>& links, CW.Common.CwInputManager.Finger finger)
  System.Void ClearAll(System.Collections.Generic.List<T> links)
  System.Void ClearAndRemove(System.Collections.Generic.List<T> links, T link)
  System.Void Clear()
  System.Void .ctor()
END_CLASS

CLASS: Finger
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    Index  // 0x10
  public            System.Single                   Pressure  // 0x14
  public            System.Boolean                  Down  // 0x18
  public            System.Boolean                  Up  // 0x19
  public            System.Single                   Age  // 0x1C
  public            System.Boolean                  StartedOverGui  // 0x20
  public            UnityEngine.Vector2             StartScreenPosition  // 0x24
  public            UnityEngine.Vector2             ScreenPosition  // 0x2C
  public            UnityEngine.Vector2             ScreenPositionOld  // 0x34
  public            UnityEngine.Vector2             ScreenPositionOldOld  // 0x3C
  public            UnityEngine.Vector2             ScreenPositionOldOldOld  // 0x44
METHODS:
  System.Single get_SmoothScreenPositionDelta()
  UnityEngine.Vector2 GetSmoothScreenPosition(System.Single t)
  System.Void .ctor()
END_CLASS

CLASS: Pipeline
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  CW.Common.CwShaderBundle.PipelineInvalid  // 0x0
  public    static  CW.Common.CwShaderBundle.PipelineStandard  // 0x0
  public    static  CW.Common.CwShaderBundle.PipelineURP2019  // 0x0
  public    static  CW.Common.CwShaderBundle.PipelineURP2020  // 0x0
  public    static  CW.Common.CwShaderBundle.PipelineURP2021  // 0x0
  public    static  CW.Common.CwShaderBundle.PipelineHDRP2019  // 0x0
  public    static  CW.Common.CwShaderBundle.PipelineHDRP2020  // 0x0
  public    static  CW.Common.CwShaderBundle.PipelineHDRP2021  // 0x0
  public    static  CW.Common.CwShaderBundle.PipelineCOUNT  // 0x0
METHODS:
END_CLASS

CLASS: ShaderVariant
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  public            CW.Common.CwShaderBundle.PipelinePipe  // 0x10
  public            System.String                   Code  // 0x18
  public            System.Int32                    Hash  // 0x20
  public            System.Boolean                  Dirty  // 0x24
METHODS:
  System.String get_HashString()
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwCameraLook
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  listen  // 0x18
  private           System.Single                   damping  // 0x1C
  private           System.Single                   sensitivity  // 0x20
  private           CW.Common.CwInputManager.Axis   pitchControls  // 0x24
  private           CW.Common.CwInputManager.Axis   yawControls  // 0x48
  private           CW.Common.CwInputManager.Axis   rollControls  // 0x6C
  private           UnityEngine.Quaternion          remainingDelta  // 0x90
METHODS:
  System.Void set_Listen(System.Boolean value)
  System.Boolean get_Listen()
  System.Void set_Damping(System.Single value)
  System.Single get_Damping()
  System.Void set_Sensitivity(System.Single value)
  System.Single get_Sensitivity()
  System.Void set_PitchControls(CW.Common.CwInputManager.Axis value)
  CW.Common.CwInputManager.Axis get_PitchControls()
  System.Void set_YawControls(CW.Common.CwInputManager.Axis value)
  CW.Common.CwInputManager.Axis get_YawControls()
  System.Void set_RollControls(CW.Common.CwInputManager.Axis value)
  CW.Common.CwInputManager.Axis get_RollControls()
  System.Void Start()
  System.Void OnDisable()
  System.Void Update()
  System.Void OnApplicationFocus(System.Boolean focus)
  System.Void AddToDelta()
  System.Void DampenDelta()
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwCameraMove
TYPE:  class
TOKEN: 0x2000003
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  listen  // 0x18
  private           System.Single                   damping  // 0x1C
  private           System.Single                   sensitivity  // 0x20
  private           CW.Common.CwInputManager.Axis   horizontalControls  // 0x24
  private           CW.Common.CwInputManager.Axis   depthControls  // 0x48
  private           CW.Common.CwInputManager.Axis   verticalControls  // 0x6C
  private           UnityEngine.Vector3             remainingDelta  // 0x90
METHODS:
  System.Void set_Listen(System.Boolean value)
  System.Boolean get_Listen()
  System.Void set_Damping(System.Single value)
  System.Single get_Damping()
  System.Void set_Sensitivity(System.Single value)
  System.Single get_Sensitivity()
  System.Void set_HorizontalControls(CW.Common.CwInputManager.Axis value)
  CW.Common.CwInputManager.Axis get_HorizontalControls()
  System.Void set_DepthControls(CW.Common.CwInputManager.Axis value)
  CW.Common.CwInputManager.Axis get_DepthControls()
  System.Void set_VerticalControls(CW.Common.CwInputManager.Axis value)
  CW.Common.CwInputManager.Axis get_VerticalControls()
  System.Void Start()
  System.Void Update()
  System.Void AddToDelta()
  System.Void DampenDelta()
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwCameraPivot
TYPE:  class
TOKEN: 0x2000004
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  listen  // 0x18
  private           System.Single                   damping  // 0x1C
  private           CW.Common.CwInputManager.Axis   pitchControls  // 0x20
  private           CW.Common.CwInputManager.Axis   yawControls  // 0x44
  private           UnityEngine.Vector3             remainingDelta  // 0x68
METHODS:
  System.Void set_Listen(System.Boolean value)
  System.Boolean get_Listen()
  System.Void set_Damping(System.Single value)
  System.Single get_Damping()
  System.Void set_PitchControls(CW.Common.CwInputManager.Axis value)
  CW.Common.CwInputManager.Axis get_PitchControls()
  System.Void set_YawControls(CW.Common.CwInputManager.Axis value)
  CW.Common.CwInputManager.Axis get_YawControls()
  System.Void OnEnable()
  System.Void Update()
  System.Void AddToDelta()
  System.Void DampenDelta()
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwDemo
TYPE:  class
TOKEN: 0x2000005
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  upgradeInputModule  // 0x18
  private           System.Boolean                  changeExposureInHDRP  // 0x19
  private           System.Boolean                  changeVisualEnvironmentInHDRP  // 0x1A
  private           System.Boolean                  changeFogInHDRP  // 0x1B
  private           System.Boolean                  changeCloudsInHDRP  // 0x1C
  private           System.Boolean                  changeMotionBlurInHDRP  // 0x1D
  private           System.Boolean                  upgradeLightsInHDRP  // 0x1E
  private           System.Boolean                  upgradeCamerasInHDRP  // 0x1F
METHODS:
  System.Void set_UpgradeInputModule(System.Boolean value)
  System.Boolean get_UpgradeInputModule()
  System.Void set_ChangeExposureInHDRP(System.Boolean value)
  System.Boolean get_ChangeExposureInHDRP()
  System.Void set_ChangeVisualEnvironmentInHDRP(System.Boolean value)
  System.Boolean get_ChangeVisualEnvironmentInHDRP()
  System.Void set_ChangeFogInHDRP(System.Boolean value)
  System.Boolean get_ChangeFogInHDRP()
  System.Void set_ChangeCloudsInHDRP(System.Boolean value)
  System.Boolean get_ChangeCloudsInHDRP()
  System.Void set_ChangeMotionBlurInHDRP(System.Boolean value)
  System.Boolean get_ChangeMotionBlurInHDRP()
  System.Void set_UpgradeLightsInHDRP(System.Boolean value)
  System.Boolean get_UpgradeLightsInHDRP()
  System.Void set_UpgradeCamerasInHDRP(System.Boolean value)
  System.Boolean get_UpgradeCamerasInHDRP()
  System.Void OnEnable()
  System.Void TryApplyURP()
  System.Void TryApplyHDRP()
  System.Void TryCreateVolume()
  System.Void TryUpgradeLights()
  System.Void TryUpgradeCameras()
  System.Void TryUpgradeEventSystem()
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwDemoButton
TYPE:  class
TOKEN: 0x2000006
EXTENDS: MonoBehaviour
FIELDS:
  private           CW.Common.CwDemoButton.LinkType link  // 0x18
  private           System.String                   urlTarget  // 0x20
  private           UnityEngine.Transform           isolateTarget  // 0x28
  private           CW.Common.CwDemoButton.ToggleTypeisolateToggle  // 0x30
  private           UnityEngine.CanvasGroup         cachedCanvasGroup  // 0x38
  private           UnityEngine.Transform           previousChild  // 0x40
METHODS:
  System.Void set_Link(CW.Common.CwDemoButton.LinkType value)
  CW.Common.CwDemoButton.LinkType get_Link()
  System.Void set_UrlTarget(System.String value)
  System.String get_UrlTarget()
  System.Void set_IsolateTarget(UnityEngine.Transform value)
  UnityEngine.Transform get_IsolateTarget()
  System.Void set_IsolateToggle(CW.Common.CwDemoButton.ToggleType value)
  CW.Common.CwDemoButton.ToggleType get_IsolateToggle()
  System.Void OnEnable()
  System.Void Update()
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Int32 GetCurrentLevel()
  System.Int32 GetLevelCount()
  System.Void LoadLevel(System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwDemoButtonBuilder
TYPE:  class
TOKEN: 0x2000009
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.GameObject          buttonPrefab  // 0x18
  private           UnityEngine.RectTransform       buttonRoot  // 0x20
  private           UnityEngine.Sprite              icon  // 0x28
  private           UnityEngine.Color               color  // 0x30
  private           System.String                   overrideName  // 0x40
  private           UnityEngine.GameObject          clone  // 0x48
METHODS:
  System.Void set_ButtonPrefab(UnityEngine.GameObject value)
  UnityEngine.GameObject get_ButtonPrefab()
  System.Void set_ButtonRoot(UnityEngine.RectTransform value)
  UnityEngine.RectTransform get_ButtonRoot()
  System.Void set_Icon(UnityEngine.Sprite value)
  UnityEngine.Sprite get_Icon()
  System.Void set_Color(UnityEngine.Color value)
  UnityEngine.Color get_Color()
  System.Void set_OverrideName(System.String value)
  System.String get_OverrideName()
  System.Void Build()
  System.Void BuildAll()
  UnityEngine.GameObject DoInstantiate()
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwLightIntensity
TYPE:  class
TOKEN: 0x200000A
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Single                   multiplier  // 0x18
  private           System.Single                   intensityInStandard  // 0x1C
  private           System.Single                   intensityInURP  // 0x20
  private           System.Single                   intensityInHDRP  // 0x24
  private           UnityEngine.Light               cachedLight  // 0x28
  private           System.Boolean                  cachedLightSet  // 0x30
METHODS:
  System.Void set_Multiplier(System.Single value)
  System.Single get_Multiplier()
  System.Void set_IntensityInStandard(System.Single value)
  System.Single get_IntensityInStandard()
  System.Void set_IntensityInURP(System.Single value)
  System.Single get_IntensityInURP()
  System.Void set_IntensityInHDRP(System.Single value)
  System.Single get_IntensityInHDRP()
  UnityEngine.Light get_CachedLight()
  System.Void Update()
  System.Void ApplyIntensity(System.Single intensity)
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwRotate
TYPE:  class
TOKEN: 0x200000B
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Vector3             angularVelocity  // 0x18
  private           UnityEngine.Space               relativeTo  // 0x24
METHODS:
  System.Void set_AngularVelocity(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_AngularVelocity()
  System.Void set_RelativeTo(UnityEngine.Space value)
  UnityEngine.Space get_RelativeTo()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwChild
TYPE:  class
TOKEN: 0x200000C
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void DestroyGameObjectIfInvalid()
  CW.Common.CwChild.IHasChildren GetParent()
  System.Void Start()
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwDepthTextureMode
TYPE:  class
TOKEN: 0x200000E
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.DepthTextureMode    depthMode  // 0x18
  private           UnityEngine.Camera              cachedCamera  // 0x20
METHODS:
  System.Void set_DepthMode(UnityEngine.DepthTextureMode value)
  UnityEngine.DepthTextureMode get_DepthMode()
  System.Void UpdateDepthMode()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwFollow
TYPE:  class
TOKEN: 0x200000F
EXTENDS: MonoBehaviour
FIELDS:
  private           CW.Common.CwFollow.FollowType   follow  // 0x18
  private           UnityEngine.Transform           target  // 0x20
  private           System.Single                   damping  // 0x28
  private           System.Boolean                  rotate  // 0x2C
  private           System.Boolean                  ignoreZ  // 0x2D
  private           CW.Common.CwFollow.UpdateType   followIn  // 0x30
  private           UnityEngine.Vector3             localPosition  // 0x34
  private           UnityEngine.Vector3             localRotation  // 0x40
METHODS:
  System.Void set_Follow(CW.Common.CwFollow.FollowType value)
  CW.Common.CwFollow.FollowType get_Follow()
  System.Void set_Target(UnityEngine.Transform value)
  UnityEngine.Transform get_Target()
  System.Void set_Damping(System.Single value)
  System.Single get_Damping()
  System.Void set_Rotate(System.Boolean value)
  System.Boolean get_Rotate()
  System.Void set_IgnoreZ(System.Boolean value)
  System.Boolean get_IgnoreZ()
  System.Void set_FollowIn(CW.Common.CwFollow.UpdateType value)
  CW.Common.CwFollow.UpdateType get_FollowIn()
  System.Void set_LocalPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_LocalPosition()
  System.Void set_LocalRotation(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_LocalRotation()
  System.Void UpdatePosition()
  System.Void Update()
  System.Void LateUpdate()
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwInputManager
TYPE:  class
TOKEN: 0x2000012
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.LayerMask           guiLayers  // 0x18
  private   static  System.Action<CW.Common.CwInputManager.Finger>OnFingerDown  // 0x0
  private   static  System.Action<CW.Common.CwInputManager.Finger>OnFingerUpdate  // 0x8
  private   static  System.Action<CW.Common.CwInputManager.Finger>OnFingerUp  // 0x10
  public    static  System.Int32                    MOUSE_FINGER_INDEX  // 0x0
  public    static  System.Int32                    HOVER_FINGER_INDEX  // 0x0
  private   static  System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>tempRaycastResults  // 0x18
  private   static  UnityEngine.EventSystems.PointerEventDatatempPointerEventData  // 0x20
  private   static  UnityEngine.EventSystems.EventSystemtempEventSystem  // 0x28
  private   static  System.Collections.Generic.List<CW.Common.CwInputManager.Finger>fingers  // 0x30
  private   static  System.Collections.Generic.List<CW.Common.CwInputManager.Finger>filteredFingers  // 0x38
  private   static  System.Collections.Generic.Stack<CW.Common.CwInputManager.Finger>pool  // 0x40
METHODS:
  System.Void set_GuiLayers(UnityEngine.LayerMask value)
  UnityEngine.LayerMask get_GuiLayers()
  System.Void add_OnFingerDown(System.Action<CW.Common.CwInputManager.Finger> value)
  System.Void remove_OnFingerDown(System.Action<CW.Common.CwInputManager.Finger> value)
  System.Void add_OnFingerUpdate(System.Action<CW.Common.CwInputManager.Finger> value)
  System.Void remove_OnFingerUpdate(System.Action<CW.Common.CwInputManager.Finger> value)
  System.Void add_OnFingerUp(System.Action<CW.Common.CwInputManager.Finger> value)
  System.Void remove_OnFingerUp(System.Action<CW.Common.CwInputManager.Finger> value)
  System.Collections.Generic.List<CW.Common.CwInputManager.Finger> get_Fingers()
  System.Single get_ScaleFactor()
  System.Collections.Generic.List<CW.Common.CwInputManager.Finger> GetFingers(System.Boolean ignoreStartedOverGui, System.Boolean ignoreHover)
  System.Boolean PointOverGui(UnityEngine.Vector2 screenPosition, System.Int32 guiLayers)
  System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> RaycastGui(UnityEngine.Vector2 screenPosition, System.Int32 guiLayers)
  UnityEngine.Vector2 GetAveragePosition(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers)
  UnityEngine.Vector2 GetAverageOldPosition(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers)
  UnityEngine.Vector2 GetAveragePullScaled(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers)
  UnityEngine.Vector2 GetAverageDeltaScaled(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers)
  System.Single GetAverageTwistRadians(System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers)
  System.Void EnsureThisComponentExists()
  System.Void Update()
  CW.Common.CwInputManager.Finger FindFinger(System.Int32 index)
  System.Void AddFinger(System.Int32 index, UnityEngine.Vector2 screenPosition, System.Single pressure, System.Boolean set)
  UnityEngine.Vector2 Hermite(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 d, System.Single t)
  System.Single HermiteInterpolate(System.Single y0, System.Single y1, System.Single y2, System.Single y3, System.Single mu, System.Single mu2, System.Single mu3)
  System.Single GetRadians(UnityEngine.Vector2 screenPosition, UnityEngine.Vector2 referencePoint)
  System.Single GetDeltaRadians(CW.Common.CwInputManager.Finger finger, UnityEngine.Vector2 referencePoint, UnityEngine.Vector2 lastReferencePoint)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: CW.Common.CwRenderTextureManager
TYPE:  class
TOKEN: 0x2000018
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Int32                    lifetime  // 0x18
METHODS:
  System.Void set_Lifetime(System.Int32 value)
  System.Int32 get_Lifetime()
  UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc, System.String title)
  UnityEngine.RenderTexture ReleaseTemporary(UnityEngine.RenderTexture renderTexture)
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwRoot
TYPE:  class
TOKEN: 0x2000019
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.Collections.Generic.List<CW.Common.CwRoot>instances  // 0x0
METHODS:
  System.Boolean get_Exists()
  UnityEngine.Transform get_Root()
  UnityEngine.Transform GetRoot()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: CW.Common.CwSeedAttribute
TYPE:  class
TOKEN: 0x200001A
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwShared
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  public    static  System.String                   HelpUrlPrefix  // 0x0
  public    static  System.String                   ComponentMenuPrefix  // 0x0
  public    static  System.String                   GameObjectMenuPrefix  // 0x0
METHODS:
END_CLASS

CLASS: CW.Common.CwGuide
TYPE:  class
TOKEN: 0x200001C
EXTENDS: ScriptableObject
FIELDS:
  public            System.String                   LongName  // 0x18
  public            System.String                   ShortName  // 0x20
  public            UnityEngine.TextAsset           Documentation  // 0x28
  private           UnityEngine.Texture2D           icon  // 0x30
  private           System.String                   version  // 0x38
METHODS:
  UnityEngine.Texture2D get_Icon()
  System.String get_Version()
  System.Void .ctor()
END_CLASS

CLASS: CW.Common.CwHelper
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  private   static  System.Collections.Generic.Stack<UnityEngine.Random.State>seedStates  // 0x0
  public    static  System.Collections.Generic.List<UnityEngine.Material>tempMaterials  // 0x8
  public    static  System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock>tempProperties  // 0x10
  private   static  System.Action<UnityEngine.Camera>OnCameraPreRender  // 0x18
  private   static  System.Action<UnityEngine.Camera>OnCameraPostRender  // 0x20
  private   static  System.Collections.Generic.Stack<UnityEngine.RenderTexture>actives  // 0x28
  private   static  System.Int32                    uniqueSeed  // 0x30
  private   static  System.Collections.Generic.List<UnityEngine.Material>materials  // 0x38
METHODS:
  System.Void add_OnCameraPreRender(System.Action<UnityEngine.Camera> value)
  System.Void remove_OnCameraPreRender(System.Action<UnityEngine.Camera> value)
  System.Void add_OnCameraPostRender(System.Action<UnityEngine.Camera> value)
  System.Void remove_OnCameraPostRender(System.Action<UnityEngine.Camera> value)
  System.Void .cctor()
  T GetOrAddComponent(UnityEngine.GameObject gameObject, System.Boolean recordUndo)
  T AddComponent(UnityEngine.GameObject gameObject, System.Boolean recordUndo)
  System.Boolean IndexInMask(System.Int32 index, System.Int32 mask)
  UnityEngine.Camera GetCamera(UnityEngine.Camera currentCamera, UnityEngine.GameObject gameObject)
  UnityEngine.Vector3 GetObserverPosition(UnityEngine.Transform observer)
  System.Boolean Enabled(UnityEngine.Behaviour b)
  System.Void BeginSeed()
  System.Void BeginSeed(System.Int32 newSeed)
  System.Void EndSeed()
  UnityEngine.Color Brighten(UnityEngine.Color color, System.Single brightness, System.Boolean convertToGamma)
  UnityEngine.Color Premultiply(UnityEngine.Color color)
  System.Single Saturate(System.Single c)
  UnityEngine.Color Saturate(UnityEngine.Color c)
  System.Void Resize(System.Collections.Generic.List<T> list, System.Int32 size)
  System.Single Sharpness(System.Single a, System.Single p)
  UnityEngine.Color ToLinear(UnityEngine.Color gamma)
  System.Single ToLinear(System.Single gamma)
  UnityEngine.Color ToGamma(UnityEngine.Color linear)
  System.Single ToGamma(System.Single linear)
  System.Single UniformScale(UnityEngine.Vector3 scale)
  System.Void BeginActive(UnityEngine.RenderTexture renderTexture)
  System.Void EndActive()
  System.Void SetTempMaterial(UnityEngine.Material material)
  System.Void SetTempMaterial(UnityEngine.Material material1, UnityEngine.Material material2)
  System.Void SetTempMaterial(System.Collections.Generic.List<UnityEngine.Material> materials)
  System.Void SetTempMaterial(UnityEngine.MaterialPropertyBlock properties)
  System.Void AddMaterial(UnityEngine.Renderer r, UnityEngine.Material m)
  System.Void ReplaceMaterial(UnityEngine.Renderer r, UnityEngine.Material m)
  System.Void RemoveMaterial(UnityEngine.Renderer r, UnityEngine.Material m)
  UnityEngine.Texture2D CreateTempTexture2D(System.String name, System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean mips, System.Boolean linear)
  UnityEngine.Material CreateTempMaterial(System.String materialName, System.String shaderName)
  UnityEngine.Material CreateTempMaterial(System.String materialName, UnityEngine.Shader shader)
  UnityEngine.Material CreateTempMaterial(System.String materialName, UnityEngine.Material source)
  T Destroy(T o)
  UnityEngine.GameObject CreateGameObject(System.String name, System.Int32 layer, UnityEngine.Transform parent, System.String recordUndo)
  UnityEngine.GameObject CreateGameObject(System.String name, System.Int32 layer, UnityEngine.Transform parent, UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation, UnityEngine.Vector3 localScale, System.String recordUndo)
  T CreateElement(UnityEngine.Transform parent)
  System.Single Reciprocal(System.Single v)
  System.Double Reciprocal(System.Double v)
  System.Single Divide(System.Single a, System.Single b)
  System.Double Divide(System.Double a, System.Double b)
  System.Single Acos(System.Single v)
  System.Double Acos(System.Double v)
  System.Single DampenFactor(System.Single speed, System.Single elapsed)
  System.Single DampenFactor(System.Single damping, System.Single deltaTime, System.Single linear)
  System.Single Atan2(UnityEngine.Vector2 xy)
  System.Int32 Mod(System.Int32 a, System.Int32 b)
  System.Single Mod(System.Single a, System.Single b)
  UnityEngine.Texture2D GetReadableCopy(UnityEngine.Texture texture, UnityEngine.TextureFormat format, System.Boolean mipMaps, System.Int32 width, System.Int32 height)
END_CLASS

CLASS: CW.Common.CwInput
TYPE:  class
TOKEN: 0x200001F
FIELDS:
  private   static  System.Collections.Generic.Dictionary<UnityEngine.KeyCode,UnityEngine.InputSystem.Key>keyMapping  // 0x0
METHODS:
  System.Void Enable()
  UnityEngine.InputSystem.Controls.ButtonControl GetMouseButtonControl(System.Int32 index)
  UnityEngine.InputSystem.Controls.ButtonControl GetButtonControl(UnityEngine.KeyCode oldKey)
  System.Int32 GetTouchCount()
  System.Void GetTouch(System.Int32 index, System.Int32& id, UnityEngine.Vector2& position, System.Single& pressure, System.Boolean& set)
  UnityEngine.Vector2 GetMousePosition()
  System.Boolean GetKeyWentDown(UnityEngine.KeyCode oldKey)
  System.Boolean GetKeyIsHeld(UnityEngine.KeyCode oldKey)
  System.Boolean GetKeyWentUp(UnityEngine.KeyCode oldKey)
  System.Boolean GetMouseWentDown(System.Int32 index)
  System.Boolean GetMouseIsHeld(System.Int32 index)
  System.Boolean GetMouseWentUp(System.Int32 index)
  System.Single GetMouseWheelDelta()
  System.Boolean GetMouseExists()
  System.Boolean GetKeyboardExists()
  System.Void .cctor()
END_CLASS

CLASS: CW.Common.CwShaderBundle
TYPE:  class
TOKEN: 0x2000020
EXTENDS: ScriptableObject
FIELDS:
  private           System.String                   title  // 0x18
  private           UnityEngine.Shader              target  // 0x20
  private           System.Int32                    variantHash  // 0x28
  private           System.Int32                    projectHash  // 0x2C
  private           System.Collections.Generic.List<CW.Common.CwShaderBundle.ShaderVariant>variants  // 0x30
METHODS:
  System.Void set_Title(System.String value)
  System.String get_Title()
  System.Void set_Target(UnityEngine.Shader value)
  UnityEngine.Shader get_Target()
  System.Void set_VariantHash(System.Int32 value)
  System.Int32 get_VariantHash()
  System.Void set_ProjectHash(System.Int32 value)
  System.Int32 get_ProjectHash()
  System.Collections.Generic.List<CW.Common.CwShaderBundle.ShaderVariant> get_Variants()
  System.Boolean get_Dirty()
  System.Int32 GetProjectHash()
  CW.Common.CwShaderBundle.Pipeline DetectProjectPipeline()
  System.Boolean IsStandard(CW.Common.CwShaderBundle.Pipeline pipe)
  System.Boolean IsScriptable(CW.Common.CwShaderBundle.Pipeline pipe)
  System.Boolean IsURP(CW.Common.CwShaderBundle.Pipeline pipe)
  System.Boolean IsHDRP(CW.Common.CwShaderBundle.Pipeline pipe)
  System.Void .ctor()
END_CLASS

