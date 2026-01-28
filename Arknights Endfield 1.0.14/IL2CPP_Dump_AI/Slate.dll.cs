// ========================================================
// Dumped by @desirepro
// Assembly: Slate.dll
// Classes:  273
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SubtitlesGUIDelegate
TYPE:  class
TOKEN: 0x2000004
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String text, UnityEngine.Color color)
  System.IAsyncResult BeginInvoke(System.String text, UnityEngine.Color color, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TextOverlayGUIDelegate
TYPE:  class
TOKEN: 0x2000005
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor alignment, UnityEngine.Vector2 position)
  System.IAsyncResult BeginInvoke(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor alignment, UnityEngine.Vector2 position, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ImageOverlayGUIDelegate
TYPE:  class
TOKEN: 0x2000006
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 position)
  System.IAsyncResult BeginInvoke(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 position, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ScreenFadeGUIDelegate
TYPE:  class
TOKEN: 0x2000007
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Color color)
  System.IAsyncResult BeginInvoke(UnityEngine.Color color, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: LetterboxGUIDelegate
TYPE:  class
TOKEN: 0x2000008
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Single completion)
  System.IAsyncResult BeginInvoke(System.Single completion, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: CameraDissolveDelegate
TYPE:  class
TOKEN: 0x2000009
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Texture texture, System.Single completion)
  System.IAsyncResult BeginInvoke(UnityEngine.Texture texture, System.Single completion, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TrackingMode
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.DynamicCameraController.Transposer.TrackingModeNone  // 0x0
  public    static  Slate.DynamicCameraController.Transposer.TrackingModeOffsetTracking  // 0x0
  public    static  Slate.DynamicCameraController.Transposer.TrackingModeRailTracking  // 0x0
METHODS:
END_CLASS

CLASS: OffsetMode
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.DynamicCameraController.Transposer.OffsetModeLocalSpace  // 0x0
  public    static  Slate.DynamicCameraController.Transposer.OffsetModeWorldSpace  // 0x0
METHODS:
END_CLASS

CLASS: Transposer
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  public            Slate.DynamicCameraController.Transposer.TrackingModetrackingMode  // 0x10
  public            UnityEngine.Transform           target  // 0x18
  public            UnityEngine.Vector3             targetOffset  // 0x20
  public            Slate.DynamicCameraController.Transposer.OffsetModeoffsetMode  // 0x2C
  public            UnityEngine.Vector3             railStart  // 0x30
  public            UnityEngine.Vector3             railEnd  // 0x3C
  public            System.Single                   railOffset  // 0x48
  public            System.Single                   smoothDamping  // 0x4C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TrackingMode
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.DynamicCameraController.Composer.TrackingModeNone  // 0x0
  public    static  Slate.DynamicCameraController.Composer.TrackingModeFrameComposition  // 0x0
METHODS:
END_CLASS

CLASS: Composer
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  public            Slate.DynamicCameraController.Composer.TrackingModetrackingMode  // 0x10
  public            UnityEngine.Transform           target  // 0x18
  public            UnityEngine.Vector3             targetOffset  // 0x20
  public            System.Single                   targetSize  // 0x2C
  public            UnityEngine.Vector2             frameCenter  // 0x30
  public            UnityEngine.Vector2             frameExtends  // 0x38
  public            System.Single                   dutchTilt  // 0x40
  public            System.Boolean                  zoomAtTargetFrame  // 0x44
  public            System.Single                   smoothDamping  // 0x48
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: BlendInEffectType
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.CameraShot.BlendInEffectTypeNone  // 0x0
  public    static  Slate.CameraShot.BlendInEffectTypeFadeFromColor  // 0x0
  public    static  Slate.CameraShot.BlendInEffectTypeCrossDissolve  // 0x0
  public    static  Slate.CameraShot.BlendInEffectTypeEaseIn  // 0x0
METHODS:
END_CLASS

CLASS: BlendOutEffectType
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.CameraShot.BlendOutEffectTypeNone  // 0x0
  public    static  Slate.CameraShot.BlendOutEffectTypeFadeToColor  // 0x0
METHODS:
END_CLASS

CLASS: SerializationMetaData
TYPE:  class
TOKEN: 0x200004E
FIELDS:
  public            System.String                   parameterName  // 0x10
  public            System.String                   declaringTypeName  // 0x18
  public            System.String                   transformHierarchyPath  // 0x20
  public            Slate.AnimatedParameter.ParameterTypeparameterType  // 0x28
  private           System.Type                     <declaringType>k__BackingField  // 0x30
  private           System.Reflection.PropertyInfo  <property>k__BackingField  // 0x38
  private           System.Reflection.FieldInfo     <field>k__BackingField  // 0x40
  private           System.Type                     <animatedType>k__BackingField  // 0x48
METHODS:
  System.Type get_declaringType()
  System.Void set_declaringType(System.Type value)
  System.Reflection.PropertyInfo get_property()
  System.Void set_property(System.Reflection.PropertyInfo value)
  System.Reflection.FieldInfo get_field()
  System.Void set_field(System.Reflection.FieldInfo value)
  System.Type get_animatedType()
  System.Void set_animatedType(System.Type value)
  System.Void Deserialize()
  System.Void .ctor()
END_CLASS

CLASS: ParameterType
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.AnimatedParameter.ParameterTypeNotSet  // 0x0
  public    static  Slate.AnimatedParameter.ParameterTypeProperty  // 0x0
  public    static  Slate.AnimatedParameter.ParameterTypeField  // 0x0
METHODS:
END_CLASS

CLASS: AddParameterDelegate
TYPE:  class
TOKEN: 0x200005D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.Type type, System.String memberPath, System.String transformPath)
  System.IAsyncResult BeginInvoke(System.Type type, System.String memberPath, System.String transformPath, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: WrapMode
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.Cutscene.WrapMode         Once  // 0x0
  public    static  Slate.Cutscene.WrapMode         Loop  // 0x0
  public    static  Slate.Cutscene.WrapMode         PingPong  // 0x0
METHODS:
END_CLASS

CLASS: StopMode
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.Cutscene.StopMode         Skip  // 0x0
  public    static  Slate.Cutscene.StopMode         Rewind  // 0x0
  public    static  Slate.Cutscene.StopMode         Hold  // 0x0
  public    static  Slate.Cutscene.StopMode         SkipRewindNoUndo  // 0x0
METHODS:
END_CLASS

CLASS: UpdateMode
TYPE:  struct
TOKEN: 0x2000067
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.Cutscene.UpdateMode       Normal  // 0x0
  public    static  Slate.Cutscene.UpdateMode       AnimatePhysics  // 0x0
  public    static  Slate.Cutscene.UpdateMode       UnscaledTime  // 0x0
  public    static  Slate.Cutscene.UpdateMode       Manual  // 0x0
METHODS:
END_CLASS

CLASS: PlayingDirection
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.Cutscene.PlayingDirection Forwards  // 0x0
  public    static  Slate.Cutscene.PlayingDirection Backwards  // 0x0
METHODS:
END_CLASS

CLASS: ActorReferenceMode
TYPE:  struct
TOKEN: 0x200006F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.CutsceneGroup.ActorReferenceModeUseOriginal  // 0x0
  public    static  Slate.CutsceneGroup.ActorReferenceModeUseInstanceHideOriginal  // 0x0
METHODS:
END_CLASS

CLASS: ActorInitialTransformation
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.CutsceneGroup.ActorInitialTransformationUseOriginal  // 0x0
  public    static  Slate.CutsceneGroup.ActorInitialTransformationUseLocal  // 0x0
METHODS:
END_CLASS

CLASS: CustomToggleInfo
TYPE:  class
TOKEN: 0x2000071
FIELDS:
  public            System.Int32                    startIndex  // 0x10
  public            System.Int32                    endIndex  // 0x14
  public            System.String                   desc  // 0x18
  public            System.Boolean                  isCollapsed  // 0x20
  private           System.Int32                    <index>k__BackingField  // 0x24
  private           Slate.CutsceneGroup             <group>k__BackingField  // 0x28
METHODS:
  System.Int32 get_index()
  System.Void set_index(System.Int32 value)
  Slate.CutsceneGroup get_group()
  System.Void set_group(Slate.CutsceneGroup value)
  System.Void _OnToggleChanged()
  System.Collections.IEnumerable _GetAllTrackNames()
  System.Void .ctor()
END_CLASS

CLASS: ExitMode
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.Section.ExitMode          Continue  // 0x0
  public    static  Slate.Section.ExitMode          Loop  // 0x0
METHODS:
END_CLASS

CLASS: HandleStyle
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.BezierPoint.HandleStyle   Connected  // 0x0
  public    static  Slate.BezierPoint.HandleStyle   Broken  // 0x0
METHODS:
END_CLASS

CLASS: SampleSettings
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Single                   volume  // 0x10
  public            System.Single                   pitch  // 0x14
  public            System.Single                   pan  // 0x18
  public            System.Single                   spatialBlend  // 0x1C
  public            System.Boolean                  ignoreTimescale  // 0x20
  public            System.Boolean                  bypassReverb  // 0x21
METHODS:
  Slate.AudioSampler.SampleSettings Default()
END_CLASS

CLASS: StoreMode
TYPE:  struct
TOKEN: 0x20000A6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.TransformSnapshot.StoreModeAll  // 0x0
  public    static  Slate.TransformSnapshot.StoreModeRootOnly  // 0x0
  public    static  Slate.TransformSnapshot.StoreModeChildrenOnly  // 0x0
METHODS:
END_CLASS

CLASS: TransformData
TYPE:  struct
TOKEN: 0x20000A7
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            UnityEngine.Transform           parent  // 0x18
  public            UnityEngine.Vector3             pos  // 0x20
  public            UnityEngine.Quaternion          rot  // 0x2C
  public            UnityEngine.Vector3             scale  // 0x3C
METHODS:
  System.Void .ctor(UnityEngine.Transform transform, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 scale)
END_CLASS

CLASS: VideoRenderTarget
TYPE:  struct
TOKEN: 0x20000AB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.VideoSampler.VideoRenderTargetCameraBackground  // 0x0
  public    static  Slate.VideoSampler.VideoRenderTargetCameraForeground  // 0x0
METHODS:
END_CLASS

CLASS: SampleSettings
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  public            Slate.VideoSampler.VideoRenderTargetrenderTarget  // 0x10
  public            System.Single                   playbackSpeed  // 0x14
  public            System.Single                   alpha  // 0x18
  public            UnityEngine.Video.VideoAspectRatioaspectRatio  // 0x1C
  public            System.Single                   audioVolume  // 0x20
METHODS:
  Slate.VideoSampler.SampleSettings Default()
END_CLASS

CLASS: StartingTransformsMode
TYPE:  struct
TOKEN: 0x2000103
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.ActionClips.PlayAnimatorClip.StartingTransformsModeAutoMatchTransforms  // 0x0
  public    static  Slate.ActionClips.PlayAnimatorClip.StartingTransformsModeManualSetTransforms  // 0x0
METHODS:
END_CLASS

CLASS: ClipWrapMode
TYPE:  struct
TOKEN: 0x2000104
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.ActionClips.PlayAnimatorClip.ClipWrapModeLoop  // 0x0
  public    static  Slate.ActionClips.PlayAnimatorClip.ClipWrapModePingPong  // 0x0
METHODS:
END_CLASS

CLASS: Slate.DirectorCamera
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  _matchMainWhenActive  // 0x18
  private           System.Boolean                  _setMainWhenActive  // 0x19
  private           System.Boolean                  _autoHandleActiveState  // 0x1A
  private           System.Boolean                  _ignoreFOVChanges  // 0x1B
  private           System.Boolean                  _dontDestroyOnLoad  // 0x1C
  public    static  System.Single                   MAX_DAMP  // 0x0
  private   static  System.Action<Slate.IDirectableCamera>onCut  // 0x0
  private   static  System.Action                   onActivate  // 0x8
  private   static  System.Action                   onDeactivate  // 0x10
  private   static  Slate.DirectorCamera            _current  // 0x18
  private   static  UnityEngine.Camera              _cam  // 0x20
  private   static  Slate.IDirectableCamera         lastTargetShot  // 0x28
  private           System.Single                   <focalDistance>k__BackingField  // 0x20
  private           System.Single                   <focalLength>k__BackingField  // 0x24
  private           System.Single                   <focalAperture>k__BackingField  // 0x28
  private   static  Slate.GameCamera                <gameCamera>k__BackingField  // 0x30
  private   static  System.Boolean                  <isEnabled>k__BackingField  // 0x38
  private   static  System.Single                   noiseTimer  // 0x3C
  private   static  UnityEngine.Vector3             noisePosOffset  // 0x40
  private   static  UnityEngine.Vector3             noiseRotOffset  // 0x4C
  private   static  UnityEngine.Vector3             noiseTargetPosOffset  // 0x58
  private   static  UnityEngine.Vector3             noiseTargetRotOffset  // 0x64
  private   static  UnityEngine.Vector3             noiseCamPosVel  // 0x70
  private   static  UnityEngine.Vector3             noiseCamRotVel  // 0x7C
METHODS:
  System.Void add_onCut(System.Action<Slate.IDirectableCamera> value)
  System.Void remove_onCut(System.Action<Slate.IDirectableCamera> value)
  System.Void add_onActivate(System.Action value)
  System.Void remove_onActivate(System.Action value)
  System.Void add_onDeactivate(System.Action value)
  System.Void remove_onDeactivate(System.Action value)
  Slate.DirectorCamera get_current()
  UnityEngine.Camera get_cam()
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
  System.Single get_fieldOfView()
  System.Void set_fieldOfView(System.Single value)
  System.Single get_focalDistance()
  System.Void set_focalDistance(System.Single value)
  System.Single get_focalLength()
  System.Void set_focalLength(System.Single value)
  System.Single get_focalAperture()
  System.Void set_focalAperture(System.Single value)
  System.Boolean get_matchMainWhenActive()
  System.Void set_matchMainWhenActive(System.Boolean value)
  System.Boolean get_setMainWhenActive()
  System.Void set_setMainWhenActive(System.Boolean value)
  System.Boolean get_autoHandleActiveState()
  System.Void set_autoHandleActiveState(System.Boolean value)
  System.Boolean get_ignoreFOVChanges()
  System.Void set_ignoreFOVChanges(System.Boolean value)
  System.Boolean get_dontDestroyOnLoad()
  System.Void set_dontDestroyOnLoad(System.Boolean value)
  UnityEngine.Camera get_renderCamera()
  Slate.GameCamera get_gameCamera()
  System.Void set_gameCamera(Slate.GameCamera value)
  System.Boolean get_isEnabled()
  System.Void set_isEnabled(System.Boolean value)
  System.Void Awake()
  UnityEngine.Camera CreateRenderCamera()
  System.Void Enable()
  System.Void Disable()
  System.Void Update(Slate.IDirectableCamera source, Slate.IDirectableCamera target, Slate.EaseType interpolation, System.Single weight, System.Single damping)
  System.Void ApplyNoise(System.Single magnitude, System.Single weight)
  System.Void .ctor()
  UnityEngine.GameObject Slate.IDirectableCamera.get_gameObject()
END_CLASS

CLASS: Slate.DirectorGUI
TYPE:  class
TOKEN: 0x2000003
EXTENDS: MonoBehaviour
FIELDS:
  private   static  Slate.DirectorGUI.SubtitlesGUIDelegateOnSubtitlesGUI  // 0x0
  private   static  Slate.DirectorGUI.TextOverlayGUIDelegateOnTextOverlayGUI  // 0x8
  private   static  Slate.DirectorGUI.ImageOverlayGUIDelegateOnImageOverlayGUI  // 0x10
  private   static  Slate.DirectorGUI.ScreenFadeGUIDelegateOnScreenFadeGUI  // 0x18
  private   static  Slate.DirectorGUI.LetterboxGUIDelegateOnLetterboxGUI  // 0x20
  private   static  Slate.DirectorGUI.CameraDissolveDelegateOnCameraDissolve  // 0x28
  private   static  System.Action                   OnGUIEnable  // 0x30
  private   static  System.Action                   OnGUIDisable  // 0x38
  private   static  Slate.DirectorGUI               _current  // 0x40
  private   static  UnityEngine.Color               <lastFadeColor>k__BackingField  // 0x48
METHODS:
  System.Void add_OnSubtitlesGUI(Slate.DirectorGUI.SubtitlesGUIDelegate value)
  System.Void remove_OnSubtitlesGUI(Slate.DirectorGUI.SubtitlesGUIDelegate value)
  System.Void add_OnTextOverlayGUI(Slate.DirectorGUI.TextOverlayGUIDelegate value)
  System.Void remove_OnTextOverlayGUI(Slate.DirectorGUI.TextOverlayGUIDelegate value)
  System.Void add_OnImageOverlayGUI(Slate.DirectorGUI.ImageOverlayGUIDelegate value)
  System.Void remove_OnImageOverlayGUI(Slate.DirectorGUI.ImageOverlayGUIDelegate value)
  System.Void add_OnScreenFadeGUI(Slate.DirectorGUI.ScreenFadeGUIDelegate value)
  System.Void remove_OnScreenFadeGUI(Slate.DirectorGUI.ScreenFadeGUIDelegate value)
  System.Void add_OnLetterboxGUI(Slate.DirectorGUI.LetterboxGUIDelegate value)
  System.Void remove_OnLetterboxGUI(Slate.DirectorGUI.LetterboxGUIDelegate value)
  System.Void add_OnCameraDissolve(Slate.DirectorGUI.CameraDissolveDelegate value)
  System.Void remove_OnCameraDissolve(Slate.DirectorGUI.CameraDissolveDelegate value)
  System.Void add_OnGUIEnable(System.Action value)
  System.Void remove_OnGUIEnable(System.Action value)
  System.Void add_OnGUIDisable(System.Action value)
  System.Void remove_OnGUIDisable(System.Action value)
  Slate.DirectorGUI get_current()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void UpdateLetterbox(System.Single completion)
  System.Void UpdateDissolve(UnityEngine.Texture texture, System.Single completion)
  UnityEngine.Color get_lastFadeColor()
  System.Void set_lastFadeColor(UnityEngine.Color value)
  System.Void UpdateFade(UnityEngine.Color color)
  System.Void UpdateSubtitles(System.String text, UnityEngine.Color color)
  System.Void UpdateOverlayText(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 pos)
  System.Void UpdateOverlayImage(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 positionOffset)
  System.Void .ctor()
END_CLASS

CLASS: Slate.DynamicCameraController
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   static  System.Single                   MIN_DAMP  // 0x0
  private   static  System.Single                   MAX_DAMP  // 0x0
  private           Slate.DynamicCameraController.Transposer_transposer  // 0x10
  private           Slate.DynamicCameraController.Composer_composer  // 0x18
  private           System.Int32                    lastUpdateFrame  // 0x20
METHODS:
  Slate.DynamicCameraController.Transposer get_transposer()
  Slate.DynamicCameraController.Composer get_composer()
  System.Boolean get_controlsPosition()
  System.Boolean get_controlsRotation()
  System.Boolean get_controlsFieldOfView()
  System.Void UpdateControllerHard(Slate.IDirectableCamera directableCamera, Slate.IDirectable directable)
  System.Void UpdateControllerSoft(Slate.IDirectableCamera directableCamera, Slate.IDirectable directable)
  System.Void UpdateController(Slate.IDirectableCamera directableCamera, Slate.IDirectable directable, System.Boolean isHard)
  System.Void .ctor()
END_CLASS

CLASS: Slate.GameCamera
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Camera              _cam  // 0x18
METHODS:
  UnityEngine.Camera get_cam()
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
  System.Single get_fieldOfView()
  System.Void set_fieldOfView(System.Single value)
  System.Single get_focalDistance()
  System.Void set_focalDistance(System.Single value)
  System.Single get_focalLength()
  System.Void set_focalLength(System.Single value)
  System.Single get_focalAperture()
  System.Void set_focalAperture(System.Single value)
  System.Void .ctor()
  UnityEngine.GameObject Slate.IDirectableCamera.get_gameObject()
END_CLASS

CLASS: Slate.IDirectableCamera
TYPE:  interface
TOKEN: 0x2000011
FIELDS:
METHODS:
  UnityEngine.GameObject get_gameObject()
  UnityEngine.Camera get_cam()
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
  System.Single get_fieldOfView()
  System.Void set_fieldOfView(System.Single value)
  System.Single get_focalDistance()
  System.Void set_focalDistance(System.Single value)
  System.Single get_focalLength()
  System.Void set_focalLength(System.Single value)
  System.Single get_focalAperture()
  System.Void set_focalAperture(System.Single value)
END_CLASS

CLASS: Slate.ShotCamera
TYPE:  class
TOKEN: 0x2000012
EXTENDS: MonoBehaviour
FIELDS:
  public    static  System.String                   DEFAULT_NAME  // 0x0
  private           Slate.DynamicCameraController   _dynamicController  // 0x18
  private           System.Single                   _focalDistance  // 0x20
  private           System.Single                   _focalLength  // 0x24
  private           System.Single                   _focalAperture  // 0x28
  private           UnityEngine.Camera              _cam  // 0x30
METHODS:
  UnityEngine.Camera get_cam()
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
  UnityEngine.Vector3 get_localPosition()
  System.Void set_localPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_localEulerAngles()
  System.Void set_localEulerAngles(UnityEngine.Vector3 value)
  System.Single get_fieldOfView()
  System.Void set_fieldOfView(System.Single value)
  System.Single get_focalDistance()
  System.Void set_focalDistance(System.Single value)
  System.Single get_focalLength()
  System.Void set_focalLength(System.Single value)
  System.Single get_focalAperture()
  System.Void set_focalAperture(System.Single value)
  Slate.DynamicCameraController get_dynamicController()
  System.Boolean get_dynamicControlledPosition()
  System.Boolean get_dynamicControlledRotation()
  System.Boolean get_dynamicControlledFieldOfView()
  System.Void Awake()
  System.Void UpdateDynamicControllerHard(Slate.IDirectable directable)
  System.Void UpdateDynamicControllerSoft(Slate.IDirectable directable)
  System.Void SetDynamicControllerTargets(UnityEngine.Transform target)
  System.Void SetDynamicControllerTargets(UnityEngine.Transform transposerTarget, UnityEngine.Transform composerTarget)
  UnityEngine.RenderTexture GetRenderTexture(System.Int32 width, System.Int32 height)
  Slate.ShotCamera Create(UnityEngine.Transform targetParent)
  Slate.ShotCamera Find(System.String shotName)
  System.Void .ctor()
  UnityEngine.GameObject Slate.IDirectableCamera.get_gameObject()
END_CLASS

CLASS: Slate.BlendShape
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  private           UnityEngine.SkinnedMeshRenderer _skin  // 0x10
  private           System.String                   _name  // 0x18
  private           System.Single                   _weight  // 0x20
METHODS:
  UnityEngine.SkinnedMeshRenderer get_skin()
  System.Void set_skin(UnityEngine.SkinnedMeshRenderer value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.Single get_weight()
  System.Void set_weight(System.Single value)
  System.Void SetRealWeight(System.Single modWeight)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: Slate.BlendShapeGroup
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private           System.String                   _UID  // 0x10
  private           System.String                   _name  // 0x18
  private           System.Single                   _weight  // 0x20
  private           System.Collections.Generic.List<Slate.BlendShape>_blendShapes  // 0x28
METHODS:
  System.String get_UID()
  System.Void set_UID(System.String value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.Single get_weight()
  System.Void set_weight(System.Single value)
  System.Collections.Generic.List<Slate.BlendShape> get_blendShapes()
  System.Void .ctor()
  System.Void SetBlendWeights()
  System.String ToString()
END_CLASS

CLASS: Slate.Character
TYPE:  class
TOKEN: 0x2000016
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<Slate.BlendShapeGroup>_expressions  // 0x18
  private           UnityEngine.Transform           _neckTransform  // 0x20
  private           UnityEngine.Transform           _headTransform  // 0x28
  private           UnityEngine.Vector3             _upVector  // 0x30
  private           UnityEngine.Vector3             _rotationOffset  // 0x3C
METHODS:
  UnityEngine.Transform get_neck()
  System.Void set_neck(UnityEngine.Transform value)
  UnityEngine.Transform get_head()
  System.Void set_head(UnityEngine.Transform value)
  UnityEngine.Vector3 get_upVector()
  System.Void set_upVector(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_rotationOffset()
  System.Void set_rotationOffset(UnityEngine.Vector3 value)
  System.Collections.Generic.List<Slate.BlendShapeGroup> get_expressions()
  Slate.BlendShapeGroup FindExpressionByName(System.String name)
  Slate.BlendShapeGroup FindExpressionByUID(System.String UID)
  System.Void SetExpressionWeightByName(System.String name, System.Single weight)
  System.Void SetExpressionWeightByUID(System.String UID, System.Single weight)
  System.Void ResetExpressions()
  System.Void .ctor()
END_CLASS

CLASS: Slate.NameAttribute
TYPE:  class
TOKEN: 0x2000019
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   name  // 0x10
METHODS:
  System.Void .ctor(System.String name)
END_CLASS

CLASS: Slate.CategoryAttribute
TYPE:  class
TOKEN: 0x200001A
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   category  // 0x10
METHODS:
  System.Void .ctor(System.String category)
END_CLASS

CLASS: Slate.DescriptionAttribute
TYPE:  class
TOKEN: 0x200001B
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   description  // 0x10
METHODS:
  System.Void .ctor(System.String description)
END_CLASS

CLASS: Slate.IconAttribute
TYPE:  class
TOKEN: 0x200001C
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   iconName  // 0x10
  public    readonly System.Type                     fromType  // 0x18
METHODS:
  System.Void .ctor(System.String iconName)
  System.Void .ctor(System.Type fromType)
END_CLASS

CLASS: Slate.AttachableAttribute
TYPE:  class
TOKEN: 0x200001D
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type[]                   types  // 0x10
METHODS:
  System.Void .ctor(System.Type[] types)
END_CLASS

CLASS: Slate.UniqueElementAttribute
TYPE:  class
TOKEN: 0x200001E
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ShowTrajectoryAttribute
TYPE:  class
TOKEN: 0x200001F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.PositionHandleAttribute
TYPE:  class
TOKEN: 0x2000020
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.RotationHandleAttribute
TYPE:  class
TOKEN: 0x2000021
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   positionPropertyName  // 0x10
METHODS:
  System.Void .ctor(System.String positionPropertyName)
END_CLASS

CLASS: Slate.AnimatableParameterAttribute
TYPE:  class
TOKEN: 0x2000022
EXTENDS: PropertyAttribute
FIELDS:
  public            System.String                   link  // 0x10
  public    readonly System.Nullable<System.Single>  min  // 0x18
  public    readonly System.Nullable<System.Single>  max  // 0x20
  public    readonly System.String                   customName  // 0x28
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String customName)
  System.Void .ctor(System.String customName, System.Single min, System.Single max)
  System.Void .ctor(System.Single min, System.Single max)
END_CLASS

CLASS: Slate.ParseAnimatableParametersAttribute
TYPE:  class
TOKEN: 0x2000023
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ShaderPropertyPopupAttribute
TYPE:  class
TOKEN: 0x2000024
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.Type                     propertyType  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Type propertyType)
END_CLASS

CLASS: Slate.LeftToggleAttribute
TYPE:  class
TOKEN: 0x2000025
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.MinAttribute
TYPE:  class
TOKEN: 0x2000026
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.Single                   min  // 0x10
METHODS:
  System.Void .ctor(System.Single min)
END_CLASS

CLASS: Slate.ExampleTextAttribute
TYPE:  class
TOKEN: 0x2000027
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.String                   text  // 0x10
METHODS:
  System.Void .ctor(System.String text)
END_CLASS

CLASS: Slate.HelpBoxAttribute
TYPE:  class
TOKEN: 0x2000028
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.String                   text  // 0x10
METHODS:
  System.Void .ctor(System.String text)
END_CLASS

CLASS: Slate.ShowIfAttribute
TYPE:  class
TOKEN: 0x2000029
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.String                   propertyName  // 0x10
  public    readonly System.Int32                    value  // 0x18
METHODS:
  System.Void .ctor(System.String propertyName, System.Int32 value)
END_CLASS

CLASS: Slate.EnabledIfAttribute
TYPE:  class
TOKEN: 0x200002A
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.String                   propertyName  // 0x10
  public    readonly System.Int32                    value  // 0x18
METHODS:
  System.Void .ctor(System.String propertyName, System.Int32 value)
END_CLASS

CLASS: Slate.CallbackAttribute
TYPE:  class
TOKEN: 0x200002B
EXTENDS: PropertyAttribute
FIELDS:
  public    readonly System.String                   methodName  // 0x10
METHODS:
  System.Void .ctor(System.String methodName)
END_CLASS

CLASS: Slate.RequiredAttribute
TYPE:  class
TOKEN: 0x200002C
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.PlaybackProtectedAttribute
TYPE:  class
TOKEN: 0x200002D
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ReadOnlyAttribute
TYPE:  class
TOKEN: 0x200002E
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.SortingLayerAttribute
TYPE:  class
TOKEN: 0x200002F
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActorGroupPopupAttribute
TYPE:  class
TOKEN: 0x2000030
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.DirectorActionClip
TYPE:  class
TOKEN: 0x2000031
EXTENDS: ActionClip
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.IEvent
TYPE:  interface
TOKEN: 0x2000032
FIELDS:
METHODS:
  System.String get_name()
  System.Void Invoke()
END_CLASS

CLASS: Slate.TransformSpace
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.TransformSpace            CutsceneSpace  // 0x0
  public    static  Slate.TransformSpace            ActorSpace  // 0x0
  public    static  Slate.TransformSpace            WorldSpace  // 0x0
  public    static  Slate.TransformSpace            ParentSpace  // 0x0
METHODS:
END_CLASS

CLASS: Slate.MiniTransformSpace
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.MiniTransformSpace        CutsceneSpace  // 0x0
  public    static  Slate.MiniTransformSpace        WorldSpace  // 0x0
  public    static  Slate.MiniTransformSpace        ParentSpace  // 0x0
METHODS:
END_CLASS

CLASS: Slate.ActiveState
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.ActiveState               Disable  // 0x0
  public    static  Slate.ActiveState               Enable  // 0x0
  public    static  Slate.ActiveState               Toggle  // 0x0
METHODS:
END_CLASS

CLASS: Slate.CameraShot
TYPE:  class
TOKEN: 0x2000036
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  private           Slate.ShotCamera                _targetShot  // 0x50
  public            Slate.CameraShot.BlendInEffectTypeblendInEffect  // 0x58
  public            Slate.CameraShot.BlendOutEffectTypeblendOutEffect  // 0x5C
  public            System.Single                   steadyCamEffect  // 0x60
  public            UnityEngine.Color               fadeToColor  // 0x64
  public            UnityEngine.Color               fadeFromColor  // 0x74
  public            Slate.ActorGroup                overrideShotTargetActorGroup  // 0x88
  private           UnityEngine.Color               lastFadeColor  // 0x90
  private           Slate.CameraShot                <previousShot>k__BackingField  // 0xA0
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Boolean get_canCrossBlend()
  UnityEngine.GameObject get_actor()
  Slate.CameraShot get_previousShot()
  System.Void set_previousShot(Slate.CameraShot value)
  Slate.ShotCamera get_targetShot()
  System.Void set_targetShot(Slate.ShotCamera value)
  Slate.CameraTrack get_track()
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_rotation()
  System.Void set_rotation(UnityEngine.Vector3 value)
  System.Single get_fieldOfView()
  System.Void set_fieldOfView(System.Single value)
  System.Single get_focalPoint()
  System.Void set_focalPoint(System.Single value)
  System.Single get_focalRange()
  System.Void set_focalRange(System.Single value)
  System.Single get_focalAperture()
  System.Void set_focalAperture(System.Single value)
  System.Void OnAfterValidate()
  System.Void OnRootEnabled()
  System.Void OnRootDisabled()
  System.Void OnRootUpdated(System.Single time, System.Single previousTime)
  System.Void TryUpdateShotTargetOverride()
  System.Boolean OnInitialize()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.PlayVideo
TYPE:  class
TOKEN: 0x200003A
EXTENDS: ActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Video.VideoClip     videoClip  // 0x50
  private           Slate.VideoSampler.SampleSettingssettings  // 0x58
METHODS:
  System.Boolean get_isValid()
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  Slate.VideoTrack get_track()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void OnExit()
  System.Void Enable()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void Disable()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActorGroup
TYPE:  class
TOKEN: 0x200003B
EXTENDS: CutsceneGroup
FIELDS:
  private           System.String                   _name  // 0x70
  private           UnityEngine.GameObject          _actor  // 0x78
  private           Slate.CutsceneGroup.ActorReferenceMode_referenceMode  // 0x80
  private           Slate.CutsceneGroup.ActorInitialTransformation_initialCoordinates  // 0x84
  private           UnityEngine.Vector3             _initialLocalPosition  // 0x88
  private           UnityEngine.Vector3             _initialLocalRotation  // 0x94
  private           System.Boolean                  _displayVirtualMeshGizmo  // 0xA0
METHODS:
  System.String get_name()
  System.Void set_name(System.String value)
  UnityEngine.GameObject get_actor()
  System.Void set_actor(UnityEngine.GameObject value)
  Slate.CutsceneGroup.ActorReferenceMode get_referenceMode()
  System.Void set_referenceMode(Slate.CutsceneGroup.ActorReferenceMode value)
  Slate.CutsceneGroup.ActorInitialTransformation get_initialTransformation()
  System.Void set_initialTransformation(Slate.CutsceneGroup.ActorInitialTransformation value)
  UnityEngine.Vector3 get_initialLocalPosition()
  System.Void set_initialLocalPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_initialLocalRotation()
  System.Void set_initialLocalRotation(UnityEngine.Vector3 value)
  System.Boolean get_displayVirtualMeshGizmo()
  System.Void set_displayVirtualMeshGizmo(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: Slate.DirectorGroup
TYPE:  class
TOKEN: 0x200003C
EXTENDS: CutsceneGroup
FIELDS:
METHODS:
  System.String get_name()
  System.Void set_name(System.String value)
  UnityEngine.GameObject get_actor()
  System.Void set_actor(UnityEngine.GameObject value)
  Slate.CutsceneGroup.ActorReferenceMode get_referenceMode()
  System.Void set_referenceMode(Slate.CutsceneGroup.ActorReferenceMode value)
  Slate.CutsceneGroup.ActorInitialTransformation get_initialTransformation()
  System.Void set_initialTransformation(Slate.CutsceneGroup.ActorInitialTransformation value)
  UnityEngine.Vector3 get_initialLocalPosition()
  System.Void set_initialLocalPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_initialLocalRotation()
  System.Void set_initialLocalRotation(UnityEngine.Vector3 value)
  System.Boolean get_displayVirtualMeshGizmo()
  System.Void set_displayVirtualMeshGizmo(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionTrack
TYPE:  class
TOKEN: 0x200003D
EXTENDS: CutsceneTrack
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActorActionTrack
TYPE:  class
TOKEN: 0x200003E
EXTENDS: ActionTrack
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActorAudioTrack
TYPE:  class
TOKEN: 0x200003F
EXTENDS: AudioTrack
FIELDS:
  protected         System.Boolean                  _useAudioSourceOnActor  // 0x90
METHODS:
  System.Boolean get_useAudioSourceOnActor()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActorPropertiesTrack
TYPE:  class
TOKEN: 0x2000040
EXTENDS: PropertiesTrack
FIELDS:
METHODS:
  System.Void OnCreate()
  System.Void .ctor()
END_CLASS

CLASS: Slate.AnimationTrack
TYPE:  class
TOKEN: 0x2000041
EXTENDS: CutsceneTrack
FIELDS:
  private           System.Single                   _weight  // 0x50
  private           System.Single                   _blendIn  // 0x54
  private           System.Single                   _blendOut  // 0x58
  private           UnityEngine.AnimationBlendMode  _animationBlendMode  // 0x5C
  private           System.String                   _mixTransformName  // 0x60
  private           UnityEngine.Animation           anim  // 0x68
  private           UnityEngine.AnimationState      state  // 0x70
METHODS:
  System.String get_info()
  System.Single get_blendIn()
  System.Single get_blendOut()
  System.Single get_weight()
  UnityEngine.AnimationBlendMode get_animationBlendMode()
  System.Void set_animationBlendMode(UnityEngine.AnimationBlendMode value)
  System.String get_mixTransformName()
  System.Void set_mixTransformName(System.String value)
  System.Boolean OnInitialize()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void OnExit()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  UnityEngine.Transform GetMixTransform()
  System.Void .ctor()
  System.Boolean <GetMixTransform>b__27_0(UnityEngine.Transform t)
END_CLASS

CLASS: Slate.AnimatorTrack
TYPE:  class
TOKEN: 0x2000042
EXTENDS: CutsceneTrack
FIELDS:
  private   static  System.Int32                    ROOTMOTION_FRAMERATE  // 0x0
  public            UnityEngine.AvatarMask          mask  // 0x50
  public            UnityEngine.AnimationBlendMode  blendMode  // 0x58
  public            System.Single                   weight  // 0x5C
  public            System.Boolean                  useRootMotion  // 0x60
  public            System.Boolean                  applyFootIK  // 0x61
  public            System.Boolean                  isRootMotionPreBaked  // 0x62
  private           System.Collections.Generic.List<UnityEngine.Vector3>rmPositions  // 0x68
  private           System.Collections.Generic.List<UnityEngine.Quaternion>rmRotations  // 0x70
  private           System.Int32                    activeClips  // 0x78
  private           System.Single                   activeClipsWeight  // 0x7C
  private           System.Collections.Generic.Dictionary<Slate.ActionClips.PlayAnimatorClip,System.Int32>ports  // 0x80
  private           UnityEngine.Playables.PlayableGraphgraph  // 0x88
  private           UnityEngine.Animations.AnimationPlayableOutputanimationOutput  // 0x98
  private           UnityEngine.Animations.AnimationLayerMixerPlayablemasterMixer  // 0xA8
  private           UnityEngine.Animations.AnimationMixerPlayableclipsMixer  // 0xB8
  private           UnityEngine.Animations.AnimatorControllerPlayableanimatorPlayable  // 0xC8
  private           System.Collections.Generic.List<Slate.AnimatorTrack>siblingTracks  // 0xD8
  private           System.Boolean                  wasRootMotion  // 0xE0
  private           UnityEngine.AnimatorCullingMode wasCullingMode  // 0xE4
  private           System.Boolean                  useBakedRootMotion  // 0xE8
  private           UnityEngine.Animator            _animator  // 0xF0
METHODS:
  UnityEngine.Animator get_animator()
  System.String get_info()
  System.Boolean get_isLocked()
  Slate.AnimatorTrack get_masterTrack()
  System.Boolean get_isMasterTrack()
  System.Boolean get_isLastTrack()
  System.Single get_compoundTrackWeight()
  System.Boolean OnInitialize()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void PostUpdateMasterTrack(System.Single time, System.Single previousTime)
  System.Void OnReverseEnter()
  System.Void OnExit()
  System.Void PostExitMasterTrack()
  System.Void OnReverse()
  System.Void EnableClip(Slate.ActionClips.PlayAnimatorClip playAnimClip, System.Single blendWeight, System.Single subClipWeight)
  System.Void UpdateClip(Slate.ActionClips.PlayAnimatorClip playAnimClip, System.Single clipTime, System.Single clipPrevious, System.Single blendWeight, System.Single subClipWeight)
  System.Void DisableClip(Slate.ActionClips.PlayAnimatorClip playAnimClip, System.Single blendWeight, System.Single subClipWeight)
  System.Void CreateAndPlayTree()
  UnityEngine.Playables.Playable CreateClipsMixer(UnityEngine.Playables.PlayableGraph graph)
  System.Void PreBakeRootMotion()
  System.Void ClearPreBakeRootMotion()
  System.Void BakeRootMotion()
  System.Void EvaluateTrackClips(System.Single time, System.Single previousTime, System.Int32& tempActiveClips)
  System.Void ApplyBakedRootMotion(System.Single time)
  System.Void .ctor()
END_CLASS

CLASS: Slate.MecanimTrack
TYPE:  class
TOKEN: 0x2000044
EXTENDS: CutsceneTrack
FIELDS:
  private           UnityEngine.Animator            animator  // 0x50
METHODS:
  System.Boolean OnInitialize()
  System.Void OnReverse()
  System.Void OnExit()
  System.Void DestroyDispatcher()
  System.Void .ctor()
END_CLASS

CLASS: Slate.AudioTrack
TYPE:  class
TOKEN: 0x2000045
EXTENDS: CutsceneTrack
FIELDS:
  protected         UnityEngine.Audio.AudioMixerGroup_outputMixer  // 0x50
  protected         System.Single                   _masterVolume  // 0x58
  protected         System.Single                   _masterPitch  // 0x5C
  protected         System.Single                   _masterStereoPan  // 0x60
  protected         System.Single                   _masterSpatialBlend  // 0x64
  protected         System.Boolean                  _ignoreTimeScale  // 0x68
  protected         System.Boolean                  _bypassReverb  // 0x69
  private           UnityEngine.AudioSource         <source>k__BackingField  // 0x70
  private           Slate.AudioSampler.SampleSettings<sampleSettings>k__BackingField  // 0x78
METHODS:
  System.String get_info()
  UnityEngine.AudioSource get_source()
  System.Void set_source(UnityEngine.AudioSource value)
  Slate.AudioSampler.SampleSettings get_sampleSettings()
  System.Void set_sampleSettings(Slate.AudioSampler.SampleSettings value)
  UnityEngine.Audio.AudioMixerGroup get_mixer()
  System.Boolean get_useAudioSourceOnActor()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void OnExit()
  System.Void OnReverse()
  System.Void Enable()
  System.Void Disable()
  System.Void SetAndApplySettings()
  System.Void SetVolume(System.Single volume)
  System.Void .ctor()
END_CLASS

CLASS: Slate.CameraTrack
TYPE:  class
TOKEN: 0x2000046
EXTENDS: CutsceneTrack
FIELDS:
  private   static  Slate.CameraTrack               activeCameraTrack  // 0x0
  private           System.Single                   _startTimeOffset  // 0x50
  private           System.Single                   _endTimeOffset  // 0x54
  public            System.Single                   _blendIn  // 0x58
  public            System.Single                   _blendOut  // 0x5C
  public            Slate.EaseType                  interpolation  // 0x60
  public            System.Single                   cineBoxFadeTime  // 0x64
  public            System.Single                   appliedSmoothing  // 0x68
  public            UnityEngine.Camera              exitCameraOverride  // 0x70
  private           Slate.GameCamera                entryCamera  // 0x78
  private           Slate.CameraShot                <firstShot>k__BackingField  // 0x80
  private           Slate.CameraShot                <lastShot>k__BackingField  // 0x88
  private           Slate.CameraShot                <currentShot>k__BackingField  // 0x90
METHODS:
  Slate.CameraShot get_firstShot()
  System.Void set_firstShot(Slate.CameraShot value)
  Slate.CameraShot get_lastShot()
  System.Void set_lastShot(Slate.CameraShot value)
  Slate.CameraShot get_currentShot()
  System.Void set_currentShot(Slate.CameraShot value)
  System.String get_info()
  System.Single get_startTime()
  System.Void set_startTime(System.Single value)
  System.Single get_endTime()
  System.Void set_endTime(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void OnExit()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void .ctor()
  System.Boolean <OnEnter>b__36_0(Slate.ActionClip s)
  System.Boolean <OnEnter>b__36_1(Slate.ActionClip s)
END_CLASS

CLASS: Slate.DirectorActionTrack
TYPE:  class
TOKEN: 0x2000047
EXTENDS: ActionTrack
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.DirectorAudioTrack
TYPE:  class
TOKEN: 0x2000048
EXTENDS: AudioTrack
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.DirectorPropertiesTrack
TYPE:  class
TOKEN: 0x2000049
EXTENDS: PropertiesTrack
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.VideoTrack
TYPE:  class
TOKEN: 0x200004A
EXTENDS: CutsceneTrack
FIELDS:
  public            Slate.VideoSampler.VideoRenderTargetrenderTarget  // 0x50
  public            UnityEngine.Video.VideoAspectRatioaspectRatio  // 0x54
  private           UnityEngine.Video.VideoPlayer   <source>k__BackingField  // 0x58
METHODS:
  UnityEngine.Video.VideoPlayer get_source()
  System.Void set_source(UnityEngine.Video.VideoPlayer value)
  System.String get_info()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void OnExit()
  System.Void Enable()
  System.Void Disable()
  System.Void .ctor()
END_CLASS

CLASS: Slate.PropertiesTrack
TYPE:  class
TOKEN: 0x200004B
EXTENDS: CutsceneTrack
FIELDS:
  private           Slate.AnimationDataCollection   _animationData  // 0x50
METHODS:
  Slate.AnimationDataCollection get_animationData()
  System.Object get_animatedParametersTarget()
  System.Void OnAfterValidate()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClip
TYPE:  class
TOKEN: 0x200004C
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Single                   _startTime  // 0x18
  private           Slate.AnimationDataCollection   _animationData  // 0x20
  private           Slate.IDirectable               <parent>k__BackingField  // 0x28
  private           System.Boolean                  <isHighlight>k__BackingField  // 0x30
  private           System.String[]                 _cachedAnimParamPaths  // 0x38
METHODS:
  Slate.IDirector get_root()
  Slate.IDirectable get_parent()
  System.Void set_parent(Slate.IDirectable value)
  UnityEngine.GameObject get_actor()
  System.Collections.Generic.IEnumerable<Slate.IDirectable> Slate.IDirectable.get_children()
  Slate.AnimationDataCollection get_animationData()
  System.Void set_animationData(Slate.AnimationDataCollection value)
  System.Single get_startTime()
  System.Void set_startTime(System.Single value)
  System.Single get_endTime()
  System.Void set_endTime(System.Single value)
  System.Boolean get_isActive()
  System.Boolean get_isCollapsed()
  System.Boolean get_isLocked()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Boolean get_canCrossBlend()
  System.String get_info()
  System.Boolean get_isValid()
  UnityEngine.Color get_color()
  UnityEngine.Color get_textColor()
  System.Int32 get_textSizeInner()
  System.Int32 get_textSizeOuter()
  System.Single get_interval()
  System.String get_url()
  System.Boolean get_isHighlight()
  System.Void set_isHighlight(System.Boolean value)
  System.Boolean get_isReadOnly()
  Slate.TransformSpace get_defaultTransformSpace()
  System.String[] get_animatedParameterPaths()
  System.Boolean get_handleParametersRegistrationManually()
  System.Object get_animatedParametersTarget()
  Slate.EaseType get_animatedParametersInterpolation()
  System.Boolean get_useWeightInParameters()
  System.Boolean get_hasParameters()
  System.Boolean get_hasActiveParameters()
  System.Boolean get_needActor()
  System.Boolean get_canSample()
  System.Int32 get_updateOrder()
  System.Boolean Slate.IDirectable.Initialize()
  System.Void Slate.IDirectable.Enter()
  System.Void Slate.IDirectable.Update(System.Single time, System.Single previousTime)
  System.Void Slate.IDirectable.Exit()
  System.Void Slate.IDirectable.ReverseEnter()
  System.Void Slate.IDirectable.Reverse()
  System.Void Slate.IDirectable.RootEnabled()
  System.Void Slate.IDirectable.RootDisabled()
  System.Void Slate.IDirectable.RootUpdated(System.Single time, System.Single previousTime)
  System.Void Slate.IDirectable.RootDestroyed()
  System.Void PostCreate(Slate.IDirectable parent)
  System.Void Validate()
  System.Void Validate(Slate.IDirector root, Slate.IDirectable parent)
  System.Boolean OnInitialize()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void OnUpdate(System.Single time)
  System.Void OnExit()
  System.Void OnReverse()
  System.Void OnReverseEnter()
  System.Void OnDrawGizmosSelected()
  System.Void OnSceneGUI()
  System.Void OnCreate()
  System.Void OnAfterValidate()
  System.Void OnRootEnabled()
  System.Void OnRootDisabled()
  System.Void OnRootUpdated(System.Single time, System.Single previousTime)
  System.Void OnRootDestroyed()
  System.Boolean RootTimeWithinRange()
  UnityEngine.Vector3 TransformPosition(UnityEngine.Vector3 point, Slate.TransformSpace space)
  UnityEngine.Vector3 InverseTransformPosition(UnityEngine.Vector3 point, Slate.TransformSpace space)
  UnityEngine.Quaternion TransformRotation(UnityEngine.Vector3 euler, Slate.TransformSpace space)
  UnityEngine.Vector3 InverseTransformRotation(UnityEngine.Quaternion rot, Slate.TransformSpace space)
  UnityEngine.Vector3 ActorPositionInSpace(Slate.TransformSpace space)
  UnityEngine.Transform GetSpaceTransform(Slate.TransformSpace space, UnityEngine.GameObject actorOverride)
  Slate.ActionClip GetPreviousClip()
  Slate.ActionClip GetNextClip()
  System.Single GetClipWeight()
  System.Single GetClipWeight(System.Single time)
  System.Single GetClipWeight(System.Single time, System.Single blendInOut)
  System.Single GetClipWeight(System.Single time, System.Single blendIn, System.Single blendOut)
  System.Void TryMatchSubClipLength()
  System.Void TryMatchPreviousSubClipLoop()
  System.Void TryMatchNexSubClipLoop()
  System.String GetParameterName(System.Linq.Expressions.Expression<System.Func<T,TResult>> func)
  Slate.AnimatedParameter GetParameter(System.Linq.Expressions.Expression<System.Func<T,TResult>> func)
  Slate.AnimatedParameter GetParameter(System.String paramName)
  System.Void SetParameterEnabled(System.Linq.Expressions.Expression<System.Func<T,TResult>> func, System.Boolean enabled)
  System.Void SetParameterEnabled(System.String paramName, System.Boolean enabled)
  System.Void ResetAnimatedParameters()
  System.Void CreateAnimationDataCollection()
  System.Void ValidateAnimParams()
  System.Void SetAnimParamsSnapshot()
  System.Void UpdateAnimParams(System.Single time, System.Single previousTime)
  System.Void RestoreAnimParamsSnapshot()
  System.Void .ctor()
  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.AnimatedParameter
TYPE:  class
TOKEN: 0x200004D
FIELDS:
  private   static  System.Action<Slate.IAnimatableData>onParameterChanged  // 0x0
  private           System.String                   _serializedData  // 0x10
  private           System.Boolean                  _isDisabled  // 0x18
  private           UnityEngine.AnimationCurve[]    _curves  // 0x20
  private           System.String                   _scriptExpression  // 0x28
  private           Slate.AnimatedParameter.SerializationMetaData_data  // 0x30
  private           Slate.IAnimatedParameterModel   _parameterModel  // 0x38
  private           Slate.IKeyable                  <keyable>k__BackingField  // 0x40
  private           System.Single[]                 <snapshot>k__BackingField  // 0x48
  private           System.Single[]                 <lastEval>k__BackingField  // 0x50
  private           UnityEngine.Transform           <virtualTransformParent>k__BackingField  // 0x58
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Type>parameterModelsMap  // 0x8
  public    static readonly System.Type[]                   supportedTypes  // 0x10
  private           System.Object                   _animatableAttribute  // 0x60
  private           System.Object                   _resolvedMemberObject  // 0x68
METHODS:
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void add_onParameterChanged(System.Action<Slate.IAnimatableData> value)
  System.Void remove_onParameterChanged(System.Action<Slate.IAnimatableData> value)
  System.Boolean get_enabled()
  System.Void SetEnabled(System.Boolean value, System.Single time)
  System.String get_serializedData()
  System.Void set_serializedData(System.String value)
  Slate.AnimatedParameter.SerializationMetaData get_data()
  Slate.IAnimatedParameterModel get_parameterModel()
  UnityEngine.AnimationCurve[] get_curves()
  System.Void set_curves(UnityEngine.AnimationCurve[] value)
  System.String get_scriptExpression()
  System.Void set_scriptExpression(System.String value)
  System.Boolean get_hasActiveExpression()
  System.String get_parameterName()
  System.Type get_animatedType()
  Slate.AnimatedParameter.ParameterType get_parameterType()
  System.String get_transformHierarchyPath()
  System.Type get_declaringType()
  System.Reflection.PropertyInfo get_property()
  System.Reflection.FieldInfo get_field()
  System.Boolean get_isProperty()
  Slate.IKeyable get_keyable()
  System.Void set_keyable(Slate.IKeyable value)
  System.Single[] get_snapshot()
  System.Void set_snapshot(System.Single[] value)
  System.Single[] get_lastEval()
  System.Void set_lastEval(System.Single[] value)
  UnityEngine.Transform get_virtualTransformParent()
  System.Void set_virtualTransformParent(UnityEngine.Transform value)
  System.Object get_targetObject()
  Slate.AnimatableParameterAttribute get_animatableAttribute()
  System.Boolean get_isExternal()
  System.Boolean get_isValid()
  System.Void .cctor()
  System.Void .ctor(Slate.IKeyable keyable, System.Type type, System.String memberPath, System.String transformPath)
  System.Void ConstructWithField(System.Reflection.FieldInfo targetField, System.Type type, System.String memberPath, System.String transformPath)
  System.Void ConstructWithProperty(System.Reflection.PropertyInfo targetProperty, System.Type type, System.String memberPath, System.String transformPath)
  System.Reflection.MemberInfo GetMemberInfo()
  UnityEngine.AnimationCurve[] GetCurves()
  System.Boolean CompareTo(Slate.AnimatedParameter other)
  System.Void InitializeCurves()
  System.Void Validate(Slate.IKeyable keyable)
  System.Void SetVirtualTransformParent(UnityEngine.Transform virtualTransformParent)
  System.Void SetSnapshot()
  System.Boolean TryAutoKey(System.Single time)
  System.Void Evaluate(System.Single time, System.Single previousTime, System.Single weight)
  System.Void Evaluate_1_Curves(System.Single time, System.Single previousTime, System.Single weight)
  System.Boolean Evaluate_2_Expression(System.Single time, System.Single previousTime, System.Single weight)
  System.Void RestoreSnapshot()
  System.Object GetEvalValue(System.Single time)
  System.Object ResolvedMemberObject()
  System.Object GetCurrentValueAsObject()
  System.Single[] GetCurrentValueAsFloats()
  System.Void SetCurrentValue(System.Object value)
  System.Void SetCurrentValue(System.Single[] floats)
  System.Boolean HasChanged()
  System.Boolean HasAnyKey()
  System.Boolean HasKey(System.Single time)
  System.Single GetKeyNext(System.Single time)
  System.Single GetKeyPrevious(System.Single time)
  System.Boolean TryKeyIdentity(System.Single time)
  System.Void SetKeyCurrent(System.Single time)
  System.Void RemoveKey(System.Single time)
  System.Void SetPreWrapMode(UnityEngine.WrapMode mode)
  System.Void SetPostWrapMode(UnityEngine.WrapMode mode)
  System.Void OffsetValue(System.Object deltaValue)
  System.Void Reset()
  System.Void ChangeMemberType(Slate.AnimatedParameter.ParameterType newType)
  System.String ToString()
  System.String FriendlyName()
  System.String GetKeyLabel(System.Single time)
  System.Void RecordUndo()
  System.Void NotifyChange()
END_CLASS

CLASS: Slate.IAnimatedParameterModel
TYPE:  interface
TOKEN: 0x2000051
FIELDS:
METHODS:
  System.Boolean ForceStepMode()
  System.Int32 RequiredCurvesCount()
  System.Object ConvertToObject(System.Single[] floats)
  System.Single[] ConvertToFloats(System.Object value)
  System.String GetKeyLabel(System.Single[] floats)
  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Bool
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  private           System.Action<System.Object,System.Boolean>setter  // 0x10
METHODS:
  System.Boolean ForceStepMode()
  System.Int32 RequiredCurvesCount()
  System.Object ConvertToObject(System.Single[] floats)
  System.Single[] ConvertToFloats(System.Object value)
  System.String GetKeyLabel(System.Single[] floats)
  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Int
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  private           System.Action<System.Object,System.Int32>setter  // 0x10
METHODS:
  System.Boolean ForceStepMode()
  System.Int32 RequiredCurvesCount()
  System.Object ConvertToObject(System.Single[] floats)
  System.Single[] ConvertToFloats(System.Object value)
  System.String GetKeyLabel(System.Single[] floats)
  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Float
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
  private           System.Action<System.Object,System.Single>setter  // 0x10
METHODS:
  System.Boolean ForceStepMode()
  System.Int32 RequiredCurvesCount()
  System.Object ConvertToObject(System.Single[] floats)
  System.Single[] ConvertToFloats(System.Object value)
  System.String GetKeyLabel(System.Single[] floats)
  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Vector2
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  private           System.Action<System.Object,UnityEngine.Vector2>setter  // 0x10
METHODS:
  System.Boolean ForceStepMode()
  System.Int32 RequiredCurvesCount()
  System.Object ConvertToObject(System.Single[] floats)
  System.Single[] ConvertToFloats(System.Object value)
  System.String GetKeyLabel(System.Single[] floats)
  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Vector3
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  private           System.Action<System.Object,UnityEngine.Vector3>setter  // 0x10
METHODS:
  System.Boolean ForceStepMode()
  System.Int32 RequiredCurvesCount()
  System.Object ConvertToObject(System.Single[] floats)
  System.Single[] ConvertToFloats(System.Object value)
  System.String GetKeyLabel(System.Single[] floats)
  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Color
TYPE:  struct
TOKEN: 0x2000057
FIELDS:
  private           System.Action<System.Object,UnityEngine.Color>setter  // 0x10
METHODS:
  System.Boolean ForceStepMode()
  System.Int32 RequiredCurvesCount()
  System.Object ConvertToObject(System.Single[] floats)
  System.Single[] ConvertToFloats(System.Object value)
  System.String GetKeyLabel(System.Single[] floats)
  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Vector4
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  private           System.Action<System.Object,UnityEngine.Vector4>setter  // 0x10
METHODS:
  System.Boolean ForceStepMode()
  System.Int32 RequiredCurvesCount()
  System.Object ConvertToObject(System.Single[] floats)
  System.Single[] ConvertToFloats(System.Object value)
  System.String GetKeyLabel(System.Single[] floats)
  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Quaternion
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  private           System.Action<System.Object,UnityEngine.Quaternion>setter  // 0x10
METHODS:
  System.Boolean ForceStepMode()
  System.Int32 RequiredCurvesCount()
  System.Object ConvertToObject(System.Single[] floats)
  System.Single[] ConvertToFloats(System.Object value)
  System.String GetKeyLabel(System.Single[] floats)
  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Rect
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  private           System.Action<System.Object,UnityEngine.Rect>setter  // 0x10
METHODS:
  System.Boolean ForceStepMode()
  System.Int32 RequiredCurvesCount()
  System.Object ConvertToObject(System.Single[] floats)
  System.Single[] ConvertToFloats(System.Object value)
  System.String GetKeyLabel(System.Single[] floats)
  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.Animated_Bounds
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  private           System.Action<System.Object,UnityEngine.Bounds>setter  // 0x10
METHODS:
  System.Boolean ForceStepMode()
  System.Int32 RequiredCurvesCount()
  System.Object ConvertToObject(System.Single[] floats)
  System.Single[] ConvertToFloats(System.Object value)
  System.String GetKeyLabel(System.Single[] floats)
  System.Void SetDirect(System.Object target, System.Reflection.MemberInfo info, System.Single[] floats)
  System.Single[] GetDirect(System.Object target, System.Reflection.MemberInfo info)
END_CLASS

CLASS: Slate.AnimationDataCollection
TYPE:  class
TOKEN: 0x200005C
FIELDS:
  private           System.Collections.Generic.List<Slate.AnimatedParameter>_animatedParameters  // 0x10
METHODS:
  System.Collections.Generic.List<Slate.AnimatedParameter> get_animatedParameters()
  System.Boolean get_isValid()
  Slate.AnimatedParameter get_Item(System.Int32 i)
  Slate.AnimatedParameter get_Item(System.String name)
  System.Void .ctor()
  System.Void .ctor(Slate.IKeyable keyable, System.Type type, System.String[] memberPaths, System.String transformPath)
  System.Boolean TryAddParameter(Slate.IKeyable keyable, System.Type type, System.String memberPath, System.String transformPath)
  System.Void RemoveParameter(Slate.AnimatedParameter animParam)
  System.Void ReOrderParameters()
  Slate.AnimatedParameter GetParameterOfName(System.String name)
  UnityEngine.AnimationCurve[] GetCurves()
  UnityEngine.AnimationCurve[] GetCurvesAll()
  UnityEngine.AnimationCurve[] Internal_GetCurves(System.Boolean enabledParamsOnly)
  System.Void Validate(Slate.IKeyable keyable)
  System.Void SetVirtualTransformParent(UnityEngine.Transform virtualTransformParent)
  System.Void SetSnapshot()
  System.Boolean TryAutoKey(System.Single time)
  System.Void Evaluate(System.Single time, System.Single previousTime, System.Single weight)
  System.Void RestoreSnapshot()
  System.Boolean TryKeyIdentity(System.Single time)
  System.Void RemoveKey(System.Single time)
  System.Boolean HasChanged()
  System.Boolean HasKey(System.Single time)
  System.Boolean HasAnyKey()
  System.Void SetKeyCurrent(System.Single time)
  System.Single GetKeyNext(System.Single time)
  System.Single GetKeyPrevious(System.Single time)
  System.String GetKeyLabel(System.Single time)
  System.Void SetPreWrapMode(UnityEngine.WrapMode mode)
  System.Void SetPostWrapMode(UnityEngine.WrapMode mode)
  System.Void Reset()
  System.String ToString()
END_CLASS

CLASS: Slate.Cutscene
TYPE:  class
TOKEN: 0x2000064
EXTENDS: MonoBehaviour
FIELDS:
  public    static  System.Single                   VERSION_NUMBER  // 0x0
  private   static  System.Action<Slate.Cutscene>   OnCutsceneStarted  // 0x0
  private   static  System.Action<Slate.Cutscene>   OnCutsceneStopped  // 0x8
  private           System.Action<Slate.Section>    OnSectionReached  // 0x18
  private           System.Action<System.String,System.Object>OnGlobalMessageSend  // 0x20
  private           System.Action                   OnStop  // 0x28
  private           Slate.Cutscene.UpdateMode       _updateMode  // 0x30
  private           Slate.Cutscene.WrapMode         _defaultWrapMode  // 0x34
  private           Slate.Cutscene.StopMode         _defaultStopMode  // 0x38
  private           System.Single                   _playbackSpeed  // 0x3C
  private           System.Boolean                  _playOnStart  // 0x40
  private           System.Boolean                  _explicitActiveLayers  // 0x41
  private           UnityEngine.LayerMask           _activeLayers  // 0x44
  public            System.Collections.Generic.List<Slate.CutsceneGroup>groups  // 0x48
  private           System.Single                   _length  // 0x50
  private           System.Single                   _viewTimeMin  // 0x54
  private           System.Single                   _viewTimeMax  // 0x58
  private           System.Single                   _currentTime  // 0x5C
  private           System.Single                   _playTimeMin  // 0x60
  private           System.Single                   _playTimeMax  // 0x64
  private           UnityEngine.Transform           _groupsRoot  // 0x68
  private           System.Collections.Generic.List<Slate.IDirectableTimePointer>timePointers  // 0x70
  private           System.Collections.Generic.List<Slate.IDirectableTimePointer>unsortedStartTimePointers  // 0x78
  private           System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean>affectedLayerGOStates  // 0x80
  private   static  System.Collections.Generic.Dictionary<System.String,Slate.Cutscene>allSceneCutscenes  // 0x10
  private           System.Boolean                  preInitialized  // 0x88
  private           System.Boolean                  _isReSampleFrame  // 0x89
  private           System.Boolean                  <isBakingRootMotion>k__BackingField  // 0x8A
  private           Slate.Cutscene.PlayingDirection <playingDirection>k__BackingField  // 0x8C
  private           Slate.Cutscene.WrapMode         <playingWrapMode>k__BackingField  // 0x90
  private           System.Collections.Generic.List<Slate.IDirectable><directables>k__BackingField  // 0x98
  private           System.Boolean                  <isActive>k__BackingField  // 0xA0
  private           System.Boolean                  <isPaused>k__BackingField  // 0xA1
  private           System.Single                   <previousTime>k__BackingField  // 0xA4
METHODS:
  System.Void add_OnCutsceneStarted(System.Action<Slate.Cutscene> value)
  System.Void remove_OnCutsceneStarted(System.Action<Slate.Cutscene> value)
  System.Void add_OnCutsceneStopped(System.Action<Slate.Cutscene> value)
  System.Void remove_OnCutsceneStopped(System.Action<Slate.Cutscene> value)
  System.Void add_OnSectionReached(System.Action<Slate.Section> value)
  System.Void remove_OnSectionReached(System.Action<Slate.Section> value)
  System.Void add_OnGlobalMessageSend(System.Action<System.String,System.Object> value)
  System.Void remove_OnGlobalMessageSend(System.Action<System.String,System.Object> value)
  System.Void add_OnStop(System.Action value)
  System.Void remove_OnStop(System.Action value)
  UnityEngine.Transform get_groupsRoot()
  Slate.Cutscene.UpdateMode get_updateMode()
  System.Void set_updateMode(Slate.Cutscene.UpdateMode value)
  Slate.Cutscene.WrapMode get_defaultWrapMode()
  System.Void set_defaultWrapMode(Slate.Cutscene.WrapMode value)
  Slate.Cutscene.StopMode get_defaultStopMode()
  System.Void set_defaultStopMode(Slate.Cutscene.StopMode value)
  System.Boolean get_playOnStart()
  System.Void set_playOnStart(System.Boolean value)
  System.Boolean get_explicitActiveLayers()
  System.Void set_explicitActiveLayers(System.Boolean value)
  UnityEngine.LayerMask get_activeLayers()
  System.Void set_activeLayers(UnityEngine.LayerMask value)
  Slate.DirectorGroup get_directorGroup()
  Slate.ActorGroup get_actorGroup()
  System.Boolean get_abortDirectorCamera()
  System.Boolean get_multiSelectOverlapCheck()
  System.Boolean get_isBakingRootMotion()
  System.Void set_isBakingRootMotion(System.Boolean value)
  Slate.CameraTrack get_cameraTrack()
  System.Single get_currentTime()
  System.Void set_currentTime(System.Single value)
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_viewTimeMin()
  System.Void set_viewTimeMin(System.Single value)
  System.Single get_viewTimeMax()
  System.Void set_viewTimeMax(System.Single value)
  System.Single get_playTimeMin()
  System.Void set_playTimeMin(System.Single value)
  System.Single get_playTimeMax()
  System.Void set_playTimeMax(System.Single value)
  System.Single get_playbackSpeed()
  System.Void set_playbackSpeed(System.Single value)
  Slate.Cutscene.PlayingDirection get_playingDirection()
  System.Void set_playingDirection(Slate.Cutscene.PlayingDirection value)
  Slate.Cutscene.WrapMode get_playingWrapMode()
  System.Void set_playingWrapMode(Slate.Cutscene.WrapMode value)
  System.Collections.Generic.List<Slate.IDirectable> get_directables()
  System.Void set_directables(System.Collections.Generic.List<Slate.IDirectable> value)
  System.Boolean get_isActive()
  System.Void set_isActive(System.Boolean value)
  System.Boolean get_isPaused()
  System.Void set_isPaused(System.Boolean value)
  System.Single get_previousTime()
  System.Void set_previousTime(System.Single value)
  System.Boolean Slate.IDirector.get_isReSampleFrame()
  UnityEngine.GameObject Slate.IDirector.get_context()
  System.Collections.Generic.IEnumerable<Slate.IDirectable> Slate.IDirector.get_children()
  System.Single get_remainingTime()
  System.Void Awake()
  System.Void Start()
  System.Void OnDestroy()
  System.Void ManualUpdate(System.Single deltaTime)
  System.Void LateUpdate()
  System.Void FixedUpdate()
  System.Void DirectorSectionReached(Slate.Section section)
  System.Collections.Generic.IEnumerable<UnityEngine.GameObject> GetAffectedActors()
  System.Single[] GetPointerTimes()
  System.Void Play()
  System.Void Play(System.Action callback)
  System.Void Play(System.Single startTime)
  System.Void Play(System.Single startTime, System.Action callback)
  System.Void Play(System.Single startTime, System.Single endTime, Slate.Cutscene.WrapMode wrapMode, System.Action callback, Slate.Cutscene.PlayingDirection playDirection)
  System.Void Stop()
  System.Void Stop(Slate.Cutscene.StopMode stopMode)
  System.Void PlayReverse()
  System.Void PlayReverse(System.Single startTime, System.Single endTime)
  System.Void Pause()
  System.Void Resume()
  System.Void SkipAll()
  System.Void Rewind()
  System.Void RewindNoUndo()
  System.Void BreakCutsceneLoop()
  System.Void BreakSectionLoop(System.Boolean alsoSkip)
  System.Void Skip()
  System.Void SkipCurrentSection()
  System.Boolean JumpToSection(System.String name)
  System.Boolean JumpToSection(Slate.Section section)
  System.Boolean PlayFromSection(System.String name)
  System.Boolean PlayFromSection(System.String name, Slate.Cutscene.WrapMode wrap, System.Action callback)
  System.Boolean PlayFromSection(Slate.Section section)
  System.Boolean PlayFromSection(Slate.Section section, Slate.Cutscene.WrapMode wrap, System.Action callback)
  System.Boolean PlaySection(System.String name)
  System.Boolean PlaySection(System.String name, Slate.Cutscene.WrapMode wrap, System.Action callback)
  System.Boolean PlaySection(Slate.Section section)
  System.Boolean PlaySection(Slate.Section section, Slate.Cutscene.WrapMode wrap, System.Action callback)
  System.Void Sample()
  System.Void Sample(System.Single time)
  System.Void Internal_SamplePointers(System.Single currentTime, System.Single previousTime)
  System.Void ReSample()
  System.Void Validate()
  System.Void InitializeTimePointers()
  System.Void OnSampleStarted()
  System.Void OnSampleEnded()
  System.Void SetLayersActive()
  System.Void RestoreLayersActive()
  System.Void UpdateCutscene(System.Single delta)
  Slate.Cutscene Play(System.String name)
  Slate.Cutscene Play(System.String name, System.Action callback)
  Slate.Cutscene FindFromResources(System.String name)
  Slate.Cutscene Find(System.String name)
  System.Void StopAllCutscenes()
  System.Void SendGlobalMessage(System.String message, System.Object value)
  System.Void SetGroupActorOfName(System.String groupName, UnityEngine.GameObject newActor)
  T FindElement(System.String path)
  Slate.IDirectable FindElement(System.String path)
  System.String ToString()
  Slate.Section GetSectionByName(System.String name)
  Slate.Section GetSectionByUID(System.String UID)
  Slate.Section[] GetSections()
  System.Single GetSectionLength(System.String name)
  System.String[] GetSectionNames()
  System.String[] GetDefinedEventNames()
  System.Void PreInitialize()
  System.Void RenderCutscene(System.Int32 width, System.Int32 height, System.Int32 frameRate, System.Action<UnityEngine.Texture2D[]> callback)
  System.Collections.IEnumerator Internal_RenderCutscene(System.Int32 width, System.Int32 height, System.Int32 frameRate, System.Action<UnityEngine.Texture2D[]> callback)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Slate.CutsceneGroup
TYPE:  class
TOKEN: 0x200006E
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Action<Slate.Section>    OnSectionReached  // 0x18
  private           System.Collections.Generic.List<Slate.CutsceneTrack>_tracks  // 0x20
  private           System.Collections.Generic.List<Slate.Section>_sections  // 0x28
  private           System.Boolean                  _isCollapsed  // 0x30
  private           System.Boolean                  _active  // 0x31
  private           System.Boolean                  _isLocked  // 0x32
  private           System.Boolean                  _isReadOnly  // 0x33
  private           Slate.TransformSnapshot         transformSnapshot  // 0x38
  private           Slate.ObjectSnapshot            objectSnapshot  // 0x40
  private           UnityEngine.GameObject          refDuplicateActor  // 0x48
  private   static  System.Int32                    totalCustomToggleNum  // 0x0
  public            System.Collections.Generic.List<Slate.CutsceneGroup.CustomToggleInfo>customToggle  // 0x50
  private           System.Boolean                  m_customToggleValid  // 0x58
  private           System.Boolean                  m_customToggleCheckDirty  // 0x59
  public            System.Collections.Generic.Dictionary<System.Int32,Slate.CutsceneGroup.CustomToggleInfo>customInfoCache  // 0x60
  private           Slate.IDirector                 <root>k__BackingField  // 0x68
METHODS:
  System.Void add_OnSectionReached(System.Action<Slate.Section> value)
  System.Void remove_OnSectionReached(System.Action<Slate.Section> value)
  System.String get_name()
  System.Void set_name(System.String value)
  UnityEngine.GameObject get_actor()
  System.Void set_actor(UnityEngine.GameObject value)
  Slate.CutsceneGroup.ActorReferenceMode get_referenceMode()
  System.Void set_referenceMode(Slate.CutsceneGroup.ActorReferenceMode value)
  Slate.CutsceneGroup.ActorInitialTransformation get_initialTransformation()
  System.Void set_initialTransformation(Slate.CutsceneGroup.ActorInitialTransformation value)
  UnityEngine.Vector3 get_initialLocalPosition()
  System.Void set_initialLocalPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_initialLocalRotation()
  System.Void set_initialLocalRotation(UnityEngine.Vector3 value)
  System.Boolean get_displayVirtualMeshGizmo()
  System.Void set_displayVirtualMeshGizmo(System.Boolean value)
  System.Boolean get_needActor()
  System.Int32 get_updateOrder()
  System.Void SetCustomToggleDirty()
  System.Boolean get_customToggleValid()
  System.Void _OnCustomToggleValueChanged()
  System.Boolean CheckCustomCollapsed(System.Int32 index)
  System.Void _TryRefreshCustomToggleInfo()
  System.Collections.Generic.List<Slate.CutsceneTrack> get_tracks()
  System.Void set_tracks(System.Collections.Generic.List<Slate.CutsceneTrack> value)
  System.Collections.Generic.List<Slate.Section> get_sections()
  System.Void set_sections(System.Collections.Generic.List<Slate.Section> value)
  System.Collections.Generic.IEnumerable<Slate.IDirectable> Slate.IDirectable.get_children()
  System.Single Slate.IDirectable.get_startTime()
  System.Single Slate.IDirectable.get_endTime()
  System.Single Slate.IDirectable.get_blendIn()
  System.Single Slate.IDirectable.get_blendOut()
  System.Boolean Slate.IDirectable.get_canCrossBlend()
  Slate.IDirectable Slate.IDirectable.get_parent()
  Slate.IDirector get_root()
  System.Void set_root(Slate.IDirector value)
  System.Boolean get_isActive()
  System.Void set_isActive(System.Boolean value)
  System.Boolean get_isCollapsed()
  System.Void set_isCollapsed(System.Boolean value)
  System.Boolean get_isLocked()
  System.Void set_isLocked(System.Boolean value)
  System.Boolean get_isReadOnly()
  System.Void set_isReadOnly(System.Boolean value)
  System.String ToString()
  System.Void Validate(Slate.IDirector root, Slate.IDirectable parent)
  Slate.Section GetSectionByName(System.String name)
  Slate.Section GetSectionByUID(System.String UID)
  Slate.Section GetSectionAfter(System.Single time)
  Slate.Section GetSectionBefore(System.Single time)
  System.Boolean Slate.IDirectable.Initialize()
  System.Void Slate.IDirectable.Enter()
  System.Void Slate.IDirectable.Reverse()
  System.Void Slate.IDirectable.Update(System.Single time, System.Single previousTime)
  System.Void Slate.IDirectable.Exit()
  System.Void Slate.IDirectable.ReverseEnter()
  System.Void Slate.IDirectable.RootEnabled()
  System.Void Slate.IDirectable.RootDisabled()
  System.Void Slate.IDirectable.RootUpdated(System.Single time, System.Single previousTime)
  System.Void Slate.IDirectable.RootDestroyed()
  System.Void StoreActorState()
  System.Void RestoreActorState()
  System.Void TryInstantiateLocalActor()
  System.Void ReleaseLocalActorInstance()
  System.Void SetActorLocalCoords()
  UnityEngine.GameObject ResolveActor(UnityEngine.GameObject original)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Slate.CutsceneTrack
TYPE:  class
TOKEN: 0x2000077
EXTENDS: MonoBehaviour
FIELDS:
  private           System.String                   _name  // 0x18
  private           UnityEngine.Color               _color  // 0x20
  private           System.Boolean                  _active  // 0x30
  private           System.Boolean                  _isLocked  // 0x31
  private           System.Collections.Generic.List<Slate.ActionClip>_actionClips  // 0x38
  private           System.Boolean                  _isReadOnly  // 0x40
  private           System.Int32                    <layerOrder>k__BackingField  // 0x44
  private           Slate.IDirectable               <parent>k__BackingField  // 0x48
METHODS:
  UnityEngine.GameObject get_actor()
  System.String get_name()
  System.Void set_name(System.String value)
  UnityEngine.Color get_color()
  System.Collections.Generic.List<Slate.ActionClip> get_clips()
  System.Void set_clips(System.Collections.Generic.List<Slate.ActionClip> value)
  System.String get_info()
  System.Collections.Generic.IEnumerable<Slate.IDirectable> Slate.IDirectable.get_children()
  System.Int32 get_layerOrder()
  System.Void set_layerOrder(System.Int32 value)
  Slate.IDirector get_root()
  Slate.IDirectable get_parent()
  System.Void set_parent(Slate.IDirectable value)
  System.Boolean get_isCollapsed()
  System.Boolean get_isActive()
  System.Void set_isActive(System.Boolean value)
  System.Boolean get_isLocked()
  System.Void set_isLocked(System.Boolean value)
  System.Single get_startTime()
  System.Void set_startTime(System.Single value)
  System.Single get_endTime()
  System.Void set_endTime(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Boolean get_canCrossBlend()
  System.Boolean get_needActor()
  System.Int32 get_updateOrder()
  System.Boolean get_isReadOnly()
  System.Void set_isReadOnly(System.Boolean value)
  System.Boolean Slate.IDirectable.Initialize()
  System.Void Slate.IDirectable.Enter()
  System.Void Slate.IDirectable.Update(System.Single time, System.Single previousTime)
  System.Void Slate.IDirectable.Exit()
  System.Void Slate.IDirectable.ReverseEnter()
  System.Void Slate.IDirectable.Reverse()
  System.Void Slate.IDirectable.RootEnabled()
  System.Void Slate.IDirectable.RootDisabled()
  System.Void Slate.IDirectable.RootUpdated(System.Single time, System.Single previousTime)
  System.Void Slate.IDirectable.RootDestroyed()
  System.Void PostCreate(Slate.IDirectable parent)
  System.Void Validate(Slate.IDirector root, Slate.IDirectable parent)
  System.Void OnCreate()
  System.Void OnAfterValidate()
  System.Boolean OnInitialize()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void OnExit()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void OnDrawGizmosSelected()
  System.Void OnSceneGUI()
  System.Void OnRootEnabled()
  System.Void OnRootDisabled()
  System.Void OnRootUpdated(System.Single time, System.Single previousTime)
  System.Void OnRootDestroyed()
  System.Single GetTrackWeight()
  System.Single GetTrackWeight(System.Single time)
  System.Single GetTrackWeight(System.Single time, System.Single blendInOut)
  System.Single GetTrackWeight(System.Single time, System.Single blendIn, System.Single blendOut)
  T AddAction(System.Single time)
  Slate.ActionClip AddAction(System.Type type, System.Single time)
  System.Void .ctor()
  System.Boolean <Validate>b__70_1(Slate.IDirectable t)
END_CLASS

CLASS: Slate.IAnimatableData
TYPE:  interface
TOKEN: 0x200007A
FIELDS:
METHODS:
  System.Boolean get_isValid()
  UnityEngine.AnimationCurve[] GetCurves()
  System.Void Validate(Slate.IKeyable keyable)
  System.Void SetVirtualTransformParent(UnityEngine.Transform virtualTransformParent)
  System.Void SetSnapshot()
  System.Void Evaluate(System.Single time, System.Single previousTime, System.Single weight)
  System.Void RestoreSnapshot()
  System.Void SetKeyCurrent(System.Single time)
  System.Boolean TryAutoKey(System.Single time)
  System.Boolean TryKeyIdentity(System.Single time)
  System.Void RemoveKey(System.Single time)
  System.Boolean HasKey(System.Single time)
  System.Boolean HasAnyKey()
  System.Boolean HasChanged()
  System.Single GetKeyNext(System.Single time)
  System.Single GetKeyPrevious(System.Single time)
  System.String GetKeyLabel(System.Single time)
  System.Void SetPreWrapMode(UnityEngine.WrapMode mode)
  System.Void SetPostWrapMode(UnityEngine.WrapMode mode)
  System.Void Reset()
END_CLASS

CLASS: Slate.IDirectable
TYPE:  interface
TOKEN: 0x200007B
FIELDS:
METHODS:
  Slate.IDirector get_root()
  Slate.IDirectable get_parent()
  System.Collections.Generic.IEnumerable<Slate.IDirectable> get_children()
  UnityEngine.GameObject get_actor()
  System.String get_name()
  System.Boolean get_isActive()
  System.Boolean get_isCollapsed()
  System.Boolean get_isLocked()
  System.Single get_startTime()
  System.Single get_endTime()
  System.Single get_blendIn()
  System.Single get_blendOut()
  System.Boolean get_canCrossBlend()
  System.Void Validate(Slate.IDirector root, Slate.IDirectable parent)
  System.Boolean Initialize()
  System.Void Enter()
  System.Void Exit()
  System.Void Update(System.Single time, System.Single previousTime)
  System.Void ReverseEnter()
  System.Void Reverse()
  System.Void RootEnabled()
  System.Void RootUpdated(System.Single time, System.Single previousTime)
  System.Void RootDisabled()
  System.Void RootDestroyed()
  System.Boolean get_needActor()
  System.Int32 get_updateOrder()
  System.Boolean get_isReadOnly()
END_CLASS

CLASS: Slate.IKeyable
TYPE:  interface
TOKEN: 0x200007C
FIELDS:
METHODS:
  Slate.AnimationDataCollection get_animationData()
  System.Object get_animatedParametersTarget()
END_CLASS

CLASS: Slate.ISubClipContainable
TYPE:  interface
TOKEN: 0x200007D
FIELDS:
METHODS:
  System.Single get_subClipOffset()
  System.Void set_subClipOffset(System.Single value)
  System.Single get_subClipSpeed()
  System.Single get_subClipLength()
END_CLASS

CLASS: Slate.IDirectableExtensions
TYPE:  class
TOKEN: 0x200007E
FIELDS:
METHODS:
  System.Single GetLength(Slate.IDirectable directable)
  System.Single RootTimeToLocalTime(Slate.IDirectable directable)
  System.Single RootTimeToLocalTimeUnclamped(Slate.IDirectable directable)
  System.Boolean IsRootTimeWithinClip(Slate.IDirectable directable)
  System.Single ToLocalTime(Slate.IDirectable directable, System.Single time)
  System.Single ToLocalTimeUnclamped(Slate.IDirectable directable, System.Single time)
  System.Boolean IsTimeWithinClip(Slate.IDirectable directable, System.Single time)
  System.Boolean CanCrossBlend(Slate.IDirectable directable, Slate.IDirectable other)
  System.Boolean CanBlendIn(Slate.IDirectable directable)
  System.Boolean CanBlendOut(Slate.IDirectable directable)
  System.Boolean CanScale(Slate.IDirectable directable)
  System.Boolean WithinBufferTriggerRange(Slate.IDirectable directable, System.Single time, System.Single previousTime, System.Boolean bypass)
  Slate.IDirectable FindChild(Slate.IDirectable directable, System.String name)
  T GetPreviousSibling(Slate.IDirectable directable)
  Slate.IDirectable GetPreviousSibling(Slate.IDirectable directable)
  T GetNextSibling(Slate.IDirectable directable)
  Slate.IDirectable GetNextSibling(Slate.IDirectable directable)
  T GetFirstParentOfType(Slate.IDirectable directable)
  System.Single GetWeight(Slate.IDirectable directable)
  System.Single GetWeight(Slate.IDirectable directable, System.Single time)
  System.Single GetWeight(Slate.IDirectable directable, System.Single time, System.Single blendInOut)
  System.Single GetWeight(Slate.IDirectable directable, System.Single time, System.Single blendIn, System.Single blendOut)
  UnityEngine.Transform GetSpaceTransform(Slate.IDirectable directable, Slate.TransformSpace space, UnityEngine.GameObject actorOverride)
  UnityEngine.Vector3 TransformPosition(Slate.IDirectable directable, UnityEngine.Vector3 point, Slate.TransformSpace space)
  UnityEngine.Vector3 InverseTransformPosition(Slate.IDirectable directable, UnityEngine.Vector3 point, Slate.TransformSpace space)
  UnityEngine.Quaternion TransformRotation(Slate.IDirectable directable, UnityEngine.Vector3 euler, Slate.TransformSpace space)
  UnityEngine.Vector3 InverseTransformRotation(Slate.IDirectable directable, UnityEngine.Quaternion rot, Slate.TransformSpace space)
  UnityEngine.Vector3 ActorPositionInSpace(Slate.IDirectable directable, Slate.TransformSpace space)
  System.Single GetPreviousLoopLocalTime(Slate.ISubClipContainable clip)
  System.Single GetNextLoopLocalTime(Slate.ISubClipContainable clip)
  UnityEngine.AnimationCurve[] GetCurvesAll(Slate.IKeyable keyable)
END_CLASS

CLASS: Slate.IDirector
TYPE:  interface
TOKEN: 0x2000082
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<Slate.IDirectable> get_children()
  UnityEngine.GameObject get_context()
  System.Single get_length()
  System.Single get_currentTime()
  System.Void set_currentTime(System.Single value)
  System.Single get_previousTime()
  System.Single get_playbackSpeed()
  System.Void set_playbackSpeed(System.Single value)
  System.Boolean get_isActive()
  System.Boolean get_isPaused()
  System.Boolean get_isReSampleFrame()
  System.Collections.Generic.IEnumerable<UnityEngine.GameObject> GetAffectedActors()
  System.Void Play()
  System.Void Pause()
  System.Void Stop()
  System.Void Sample(System.Single time)
  System.Void ReSample()
  System.Void Validate()
  System.Void SendGlobalMessage(System.String message, System.Object value)
END_CLASS

CLASS: Slate.Section
TYPE:  class
TOKEN: 0x2000083
FIELDS:
  public    static readonly UnityEngine.Color               DEFAULT_COLOR  // 0x0
  private           System.String                   _UID  // 0x10
  private           System.String                   _name  // 0x18
  private           System.Single                   _time  // 0x20
  private           Slate.Section.ExitMode          _exitMode  // 0x24
  private           System.Int32                    _loopCount  // 0x28
  private           UnityEngine.Color               _color  // 0x2C
  private           System.Boolean                  _colorizeBackground  // 0x3C
  private           System.Int32                    <currentLoopIteration>k__BackingField  // 0x40
METHODS:
  System.Int32 get_currentLoopIteration()
  System.Void set_currentLoopIteration(System.Int32 value)
  System.String get_UID()
  System.Void set_UID(System.String value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.Single get_time()
  System.Void set_time(System.Single value)
  Slate.Section.ExitMode get_exitMode()
  System.Void set_exitMode(Slate.Section.ExitMode value)
  System.Int32 get_loopCount()
  System.Void set_loopCount(System.Int32 value)
  UnityEngine.Color get_color()
  System.Void set_color(UnityEngine.Color value)
  System.Boolean get_colorizeBackground()
  System.Void set_colorizeBackground(System.Boolean value)
  System.Void .ctor(System.String name, System.Single time)
  System.Void ResetLoops()
  System.Void BreakLoop()
  System.Boolean TryUpdateLoop()
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: Slate.IDirectableTimePointer
TYPE:  interface
TOKEN: 0x2000085
FIELDS:
METHODS:
  Slate.IDirectable get_target()
  System.Single get_time()
  System.Void TriggerForward(System.Single currentTime, System.Single previousTime)
  System.Void TriggerBackward(System.Single currentTime, System.Single previousTime)
  System.Void Update(System.Single currentTime, System.Single previousTime)
END_CLASS

CLASS: Slate.StartTimePointer
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  private           System.Boolean                  triggered  // 0x10
  private           System.Single                   lastTargetStartTime  // 0x14
  private           Slate.IDirectable               <target>k__BackingField  // 0x18
METHODS:
  Slate.IDirectable get_target()
  System.Void set_target(Slate.IDirectable value)
  System.Single Slate.IDirectableTimePointer.get_time()
  System.Void .ctor(Slate.IDirectable target)
  System.Void Slate.IDirectableTimePointer.TriggerForward(System.Single currentTime, System.Single previousTime)
  System.Void Slate.IDirectableTimePointer.Update(System.Single currentTime, System.Single previousTime)
  System.Void Slate.IDirectableTimePointer.TriggerBackward(System.Single currentTime, System.Single previousTime)
END_CLASS

CLASS: Slate.EndTimePointer
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  private           System.Boolean                  triggered  // 0x10
  private           Slate.IDirectable               <target>k__BackingField  // 0x18
METHODS:
  Slate.IDirectable get_target()
  System.Void set_target(Slate.IDirectable value)
  System.Single Slate.IDirectableTimePointer.get_time()
  System.Void .ctor(Slate.IDirectable target)
  System.Void Slate.IDirectableTimePointer.TriggerForward(System.Single currentTime, System.Single previousTime)
  System.Void Slate.IDirectableTimePointer.Update(System.Single currentTime, System.Single previousTime)
  System.Void Slate.IDirectableTimePointer.TriggerBackward(System.Single currentTime, System.Single previousTime)
END_CLASS

CLASS: Slate.BezierPath
TYPE:  class
TOKEN: 0x2000088
EXTENDS: Path
FIELDS:
  public            System.Int32                    resolution  // 0x18
  private           System.Collections.Generic.List<Slate.BezierPoint>_points  // 0x20
  private           UnityEngine.Vector3[]           _sampledPathPoints  // 0x28
  private           System.Single                   _length  // 0x30
METHODS:
  System.Collections.Generic.List<Slate.BezierPoint> get_points()
  Slate.BezierPoint get_Item(System.Int32 index)
  System.Int32 get_pointCount()
  System.Single get_length()
  System.Void Awake()
  System.Void OnValidate()
  System.Void Compute()
  System.Void SetDirty()
  System.Void ComputeLength()
  System.Void ComputeSampledPathPoints()
  Slate.BezierPath Create(UnityEngine.Transform targetParent)
  Slate.BezierPoint AddPointAt(UnityEngine.Vector3 position, System.Int32 index)
  System.Void RemovePoint(Slate.BezierPoint point)
  System.Int32 GetPointIndex(Slate.BezierPoint point)
  UnityEngine.Vector3[] GetSampledPathPositions(Slate.BezierPoint p1, Slate.BezierPoint p2, System.Int32 resolution)
  UnityEngine.Vector3 GetPositionAt(System.Single t)
  UnityEngine.Vector3 GetPositionAt(Slate.BezierPoint p1, Slate.BezierPoint p2, System.Single t)
  System.Void .ctor()
END_CLASS

CLASS: Slate.BezierPoint
TYPE:  class
TOKEN: 0x2000089
FIELDS:
  private           Slate.BezierPath                _path  // 0x10
  public            UnityEngine.Vector3             _position  // 0x18
  private           UnityEngine.Vector3             _handle1  // 0x24
  private           UnityEngine.Vector3             _handle2  // 0x30
  private           Slate.BezierPoint.HandleStyle   _handleStyle  // 0x3C
METHODS:
  System.Void .ctor(Slate.BezierPath path, UnityEngine.Vector3 position)
  Slate.BezierPoint.HandleStyle get_handleStyle()
  System.Void set_handleStyle(Slate.BezierPoint.HandleStyle value)
  Slate.BezierPath get_path()
  System.Void set_path(Slate.BezierPath value)
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_handle1LocalPosition()
  System.Void set_handle1LocalPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_handle2LocalPosition()
  System.Void set_handle2LocalPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_handle1Position()
  System.Void set_handle1Position(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_handle2Position()
  System.Void set_handle2Position(UnityEngine.Vector3 value)
END_CLASS

CLASS: Slate.Path
TYPE:  class
TOKEN: 0x200008B
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Single get_length()
  UnityEngine.Vector3 GetPositionAt(System.Single t)
  System.Void Compute()
  UnityEngine.Vector3 GetPositionAlongCurve(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 fromTangent, UnityEngine.Vector3 toTangent, System.Single t)
  UnityEngine.Vector3 GetPosition(System.Single t, UnityEngine.Vector3[] path)
  System.Single GetLength(UnityEngine.Vector3[] path)
  System.Void .ctor()
END_CLASS

CLASS: Slate.AnimationDataUtility
TYPE:  class
TOKEN: 0x200008C
FIELDS:
METHODS:
  System.String[] GetAnimatableMemberPaths(System.Object root)
  System.String[] Internal_GetAnimatableMemberPaths(System.Type type, System.String path)
END_CLASS

CLASS: Slate.AnimatorDispatcher
TYPE:  class
TOKEN: 0x200008D
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Action<System.Int32>     onAnimatorIK  // 0x18
  private           UnityEngine.Animator            _animator  // 0x20
METHODS:
  System.Void add_onAnimatorIK(System.Action<System.Int32> value)
  System.Void remove_onAnimatorIK(System.Action<System.Int32> value)
  UnityEngine.Animator get_animator()
  System.Void OnAnimatorIK(System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: Slate.AudioSampler
TYPE:  class
TOKEN: 0x200008E
FIELDS:
  private   static  System.String                   ROOT_NAME  // 0x0
  private   static  UnityEngine.GameObject          root  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.Object,UnityEngine.AudioSource>sources  // 0x8
METHODS:
  UnityEngine.AudioSource GetSourceForID(System.Object keyID)
  System.Void ReleaseSourceForID(System.Object keyID)
  System.Void SampleForID(System.Object keyID, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, System.Single volume)
  System.Void SampleForID(System.Object keyID, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, Slate.AudioSampler.SampleSettings settings)
  System.Void Sample(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, System.Single volume)
  System.Void Sample(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, System.Single time, System.Single previousTime, Slate.AudioSampler.SampleSettings settings)
  System.Void .cctor()
END_CLASS

CLASS: Slate.ColorUtility
TYPE:  class
TOKEN: 0x2000090
FIELDS:
METHODS:
  UnityEngine.Color Grey(System.Single value)
  UnityEngine.Color WithAlpha(UnityEngine.Color color, System.Single alpha)
END_CLASS

CLASS: Slate.TangentMode
TYPE:  struct
TOKEN: 0x2000091
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.TangentMode               Editable  // 0x0
  public    static  Slate.TangentMode               Smooth  // 0x0
  public    static  Slate.TangentMode               Linear  // 0x0
  public    static  Slate.TangentMode               Constant  // 0x0
METHODS:
END_CLASS

CLASS: Slate.CurveUtility
TYPE:  class
TOKEN: 0x2000092
FIELDS:
  private   static  System.Single                   KEY_PROXIMITY_TOLERANCE  // 0x0
METHODS:
  System.Single GetKeyNext(System.Single time, UnityEngine.AnimationCurve[] curves)
  System.Single GetKeyPrevious(System.Single time, UnityEngine.AnimationCurve[] curves)
  System.Boolean HasKey(System.Single time, UnityEngine.AnimationCurve[] curves)
  System.Boolean HasAnyKey(UnityEngine.AnimationCurve[] curves)
  System.Void OffsetCurveValue(UnityEngine.AnimationCurve curve, System.Single deltaValue)
  System.Void OffsetCurveTime(UnityEngine.AnimationCurve curve, System.Single deltaTime)
  System.Void RemoveNegativeKeys(UnityEngine.AnimationCurve curve)
  System.Void RemoveKeysOffRange(UnityEngine.AnimationCurve curve, System.Single min, System.Single max)
END_CLASS

CLASS: Slate.DecoratorAttribute
TYPE:  class
TOKEN: 0x2000097
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type                     targetType  // 0x10
METHODS:
  System.Void .ctor(System.Type targetType)
END_CLASS

CLASS: Slate.IDecorator
TYPE:  interface
TOKEN: 0x2000098
FIELDS:
METHODS:
  System.Object get_Target()
  System.Void set_Target(System.Object value)
END_CLASS

CLASS: Slate.DecoratorFactory
TYPE:  class
TOKEN: 0x2000099
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Type>decoratorsTypeMap  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.Object,Slate.IDecorator>decoratorsInstanceMap  // 0x8
METHODS:
  T Decorator(System.Object target)
  T GetDecorator(System.Object target)
  T CreateDecorator(System.Type targetType)
  System.Void .cctor()
END_CLASS

CLASS: Slate.EaseType
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Slate.EaseType                  Linear  // 0x0
  public    static  Slate.EaseType                  QuadraticIn  // 0x0
  public    static  Slate.EaseType                  QuadraticOut  // 0x0
  public    static  Slate.EaseType                  QuadraticInOut  // 0x0
  public    static  Slate.EaseType                  QuarticIn  // 0x0
  public    static  Slate.EaseType                  QuarticOut  // 0x0
  public    static  Slate.EaseType                  QuarticInOut  // 0x0
  public    static  Slate.EaseType                  QuinticIn  // 0x0
  public    static  Slate.EaseType                  QuinticOut  // 0x0
  public    static  Slate.EaseType                  QuinticInOut  // 0x0
  public    static  Slate.EaseType                  CubicIn  // 0x0
  public    static  Slate.EaseType                  CubicOut  // 0x0
  public    static  Slate.EaseType                  CubicInOut  // 0x0
  public    static  Slate.EaseType                  ExponentialIn  // 0x0
  public    static  Slate.EaseType                  ExponentialOut  // 0x0
  public    static  Slate.EaseType                  ExponentialInOut  // 0x0
  public    static  Slate.EaseType                  CircularIn  // 0x0
  public    static  Slate.EaseType                  CircularOut  // 0x0
  public    static  Slate.EaseType                  CircularInOut  // 0x0
  public    static  Slate.EaseType                  SinusoidalIn  // 0x0
  public    static  Slate.EaseType                  SinusoidalOut  // 0x0
  public    static  Slate.EaseType                  SinusoidalInOut  // 0x0
  public    static  Slate.EaseType                  ElasticIn  // 0x0
  public    static  Slate.EaseType                  ElasticOut  // 0x0
  public    static  Slate.EaseType                  ElasticInOut  // 0x0
  public    static  Slate.EaseType                  BounceIn  // 0x0
  public    static  Slate.EaseType                  BounceOut  // 0x0
  public    static  Slate.EaseType                  BounceInOut  // 0x0
  public    static  Slate.EaseType                  BackIn  // 0x0
  public    static  Slate.EaseType                  BackOut  // 0x0
  public    static  Slate.EaseType                  BackInOut  // 0x0
METHODS:
END_CLASS

CLASS: Slate.Easing
TYPE:  class
TOKEN: 0x200009B
FIELDS:
METHODS:
  System.Single Ease(Slate.EaseType type, System.Single from, System.Single to, System.Single t)
  UnityEngine.Vector3 Ease(Slate.EaseType type, UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single t)
  UnityEngine.Quaternion Ease(Slate.EaseType type, UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single t)
  UnityEngine.Color Ease(Slate.EaseType type, UnityEngine.Color from, UnityEngine.Color to, System.Single t)
  System.Func<System.Single,System.Single> Function(Slate.EaseType type)
  System.Single Linear(System.Single t)
  System.Single QuadraticIn(System.Single t)
  System.Single QuadraticOut(System.Single t)
  System.Single QuadraticInOut(System.Single t)
  System.Single QuarticIn(System.Single t)
  System.Single QuarticOut(System.Single t)
  System.Single QuarticInOut(System.Single t)
  System.Single QuinticIn(System.Single t)
  System.Single QuinticOut(System.Single t)
  System.Single QuinticInOut(System.Single t)
  System.Single CubicIn(System.Single t)
  System.Single CubicOut(System.Single t)
  System.Single CubicInOut(System.Single t)
  System.Single SinusoidalIn(System.Single t)
  System.Single SinusoidalOut(System.Single t)
  System.Single SinusoidalInOut(System.Single t)
  System.Single ExponentialIn(System.Single t)
  System.Single ExponentialOut(System.Single t)
  System.Single ExponentialInOut(System.Single t)
  System.Single CircularIn(System.Single t)
  System.Single CircularOut(System.Single t)
  System.Single CircularInOut(System.Single t)
  System.Single ElasticIn(System.Single t)
  System.Single ElasticOut(System.Single t)
  System.Single ElasticInOut(System.Single t)
  System.Single BounceIn(System.Single t)
  System.Single BounceOut(System.Single t)
  System.Single BounceInOut(System.Single t)
  System.Single BackIn(System.Single t)
  System.Single BackOut(System.Single t)
  System.Single BackInOut(System.Single t)
END_CLASS

CLASS: Slate.ITransformRefParameter
TYPE:  interface
TOKEN: 0x200009C
FIELDS:
METHODS:
  UnityEngine.Transform get_transform()
  Slate.TransformSpace get_space()
  System.Boolean get_useAnimation()
END_CLASS

CLASS: Slate.ObjectSnapshot
TYPE:  class
TOKEN: 0x200009D
FIELDS:
  private   static  System.Collections.Generic.List<System.Type>ignoreTypes  // 0x0
  private           System.Collections.Generic.Dictionary<UnityEngine.Object,System.String>serialized  // 0x10
METHODS:
  System.Void AppendIgnoreType(System.Type type)
  System.Void .ctor(UnityEngine.Object target, System.Boolean fullObjectHierarchy)
  System.Void Store(UnityEngine.Object target, System.Boolean fullObjectHierarchy)
  System.Void Restore()
  System.Void .cctor()
END_CLASS

CLASS: Slate.RectUtility
TYPE:  class
TOKEN: 0x200009E
FIELDS:
METHODS:
  UnityEngine.Rect GetBoundRect(UnityEngine.Rect[] rects)
  UnityEngine.Rect GetBoundRect(UnityEngine.Vector2[] positions)
  System.Boolean Encapsulates(UnityEngine.Rect a, UnityEngine.Rect b)
  UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single margin)
  UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single xMargin, System.Single yMargin)
  UnityEngine.Rect TransformSpace(UnityEngine.Rect rect, UnityEngine.Rect oldContainer, UnityEngine.Rect newContainer)
  UnityEngine.Rect ToViewRect(UnityEngine.Bounds b, UnityEngine.Camera cam)
END_CLASS

CLASS: Slate.ReflectionTools
TYPE:  class
TOKEN: 0x200009F
FIELDS:
  private   static  System.Reflection.BindingFlags  flagsEverything  // 0x0
  private   static  System.Collections.Generic.List<System.Reflection.Assembly>_loadedAssemblies  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.String,System.Type>typeMap  // 0x8
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Type[]>subTypesMap  // 0x10
METHODS:
  System.Collections.Generic.List<System.Reflection.Assembly> get_loadedAssemblies()
  System.Type GetType(System.String typeName)
  System.Type[] GetAllTypes()
  System.Type[] GetImplementationsOf(System.Type type)
  System.Type[] RTGetExportedTypes(System.Reflection.Assembly asm)
  System.String FriendlyName(System.Type type)
  System.Boolean RTIsStatic(System.Reflection.PropertyInfo propertyInfo)
  System.Boolean RTIsAbstract(System.Type type)
  System.Boolean RTIsSubclassOf(System.Type type, System.Type other)
  System.Boolean RTIsAssignableFrom(System.Type type, System.Type second)
  System.Reflection.FieldInfo RTGetField(System.Type type, System.String name)
  System.Reflection.PropertyInfo RTGetProperty(System.Type type, System.String name)
  System.Reflection.MethodInfo RTGetMethod(System.Type type, System.String name)
  System.Reflection.FieldInfo[] RTGetFields(System.Type type)
  System.Reflection.PropertyInfo[] RTGetProperties(System.Type type)
  System.Reflection.MethodInfo RTGetGetMethod(System.Reflection.PropertyInfo prop)
  System.Reflection.MethodInfo RTGetSetMethod(System.Reflection.PropertyInfo prop)
  System.Type RTReflectedType(System.Type type)
  System.Type RTReflectedType(System.Reflection.MemberInfo member)
  T RTGetAttribute(System.Type type, System.Boolean inherited)
  T RTGetAttribute(System.Reflection.MemberInfo member, System.Boolean inherited)
  System.Boolean RTIsDefined(System.Reflection.MemberInfo member, System.Boolean inherited)
  T RTCreateDelegate(System.Reflection.MethodInfo method, System.Object instance)
  System.Action<T,TValue> GetFieldOrPropSetter(System.Reflection.MemberInfo info)
  System.Reflection.MemberInfo[] RTGetFieldsAndProps(System.Type type)
  System.Reflection.MemberInfo RTGetFieldOrProp(System.Type type, System.String name)
  System.Object RTGetFieldOrPropValue(System.Reflection.MemberInfo member, System.Object instance, System.Int32 index)
  System.Void RTSetFieldOrPropValue(System.Reflection.MemberInfo member, System.Object instance, System.Object value, System.Int32 index)
  System.Type RTGetFieldOrPropType(System.Reflection.MemberInfo member)
  System.Reflection.MemberInfo GetRelativeMember(System.Object root, System.String path)
  System.Reflection.MemberInfo GetRelativeMember(System.Type type, System.String path)
  System.Object GetRelativeMemberParent(System.Object root, System.String path)
  System.String GetMemberPath(System.Linq.Expressions.Expression<System.Func<T,TResult>> func)
  System.String[] GetMemberPaths(System.Type type, System.Predicate<System.Type> shouldInclude, System.Predicate<System.Type> shouldContinue, System.String currentPath, System.Collections.Generic.List<System.Type> recursionCheck)
  System.Void .cctor()
END_CLASS

CLASS: Slate.StringUtility
TYPE:  class
TOKEN: 0x20000A2
FIELDS:
METHODS:
  System.String SplitCamelCase(System.String s)
  System.String AbsToRelativePath(System.String absolutepath)
END_CLASS

CLASS: Slate.TransformRefPosition
TYPE:  struct
TOKEN: 0x20000A3
FIELDS:
  private           Slate.CutsceneGroup             _group  // 0x10
  private           UnityEngine.Transform           _transform  // 0x18
  private           UnityEngine.Vector3             _vector  // 0x20
  private           Slate.TransformSpace            _space  // 0x2C
METHODS:
  System.Boolean get_useAnimation()
  Slate.CutsceneGroup get_group()
  System.Void set_group(Slate.CutsceneGroup value)
  UnityEngine.Transform get_transform()
  System.Void set_transform(UnityEngine.Transform value)
  UnityEngine.Vector3 get_value()
  System.Void set_value(UnityEngine.Vector3 value)
  Slate.TransformSpace get_space()
  System.Void set_space(Slate.TransformSpace value)
  System.String ToString()
END_CLASS

CLASS: Slate.TransformRefPositionRotation
TYPE:  struct
TOKEN: 0x20000A4
FIELDS:
  private           Slate.CutsceneGroup             _group  // 0x10
  private           UnityEngine.Transform           _transform  // 0x18
  private           UnityEngine.Vector3             _position  // 0x20
  private           UnityEngine.Vector3             _rotation  // 0x2C
  private           Slate.TransformSpace            _space  // 0x38
METHODS:
  System.Boolean get_useAnimation()
  Slate.CutsceneGroup get_group()
  System.Void set_group(Slate.CutsceneGroup value)
  UnityEngine.Transform get_transform()
  System.Void set_transform(UnityEngine.Transform value)
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_rotation()
  System.Void set_rotation(UnityEngine.Vector3 value)
  Slate.TransformSpace get_space()
  System.Void set_space(Slate.TransformSpace value)
  System.String ToString()
END_CLASS

CLASS: Slate.TransformSnapshot
TYPE:  class
TOKEN: 0x20000A5
FIELDS:
  private           System.Collections.Generic.List<Slate.TransformSnapshot.TransformData>data  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.GameObject root, Slate.TransformSnapshot.StoreMode mode)
  System.Void Store(UnityEngine.GameObject root, Slate.TransformSnapshot.StoreMode mode)
  System.Void Restore()
END_CLASS

CLASS: Slate.UnityObjectUtility
TYPE:  class
TOKEN: 0x20000A8
FIELDS:
  private   static  System.Reflection.MethodInfo    _getLocalEulerAngles  // 0x0
  private   static  System.Reflection.MethodInfo    _setLocalEulerAngles  // 0x8
  private   static  System.Reflection.PropertyInfo  _rotationOrder  // 0x10
  private   static  System.Object[]                 _rotationOrderArgGet  // 0x18
  private   static  System.Object[]                 _rotationOrderArgSet  // 0x20
METHODS:
  System.Void .cctor()
  UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.Transform transform)
  System.Void SetLocalEulerAngles(UnityEngine.Transform transform, UnityEngine.Vector3 value)
  System.String CalculateTransformPath(UnityEngine.Transform root, UnityEngine.Transform child)
  UnityEngine.Transform ResolveTransformPath(UnityEngine.Transform root, System.String path)
  UnityEngine.Transform FindInChildren(UnityEngine.Transform root, System.String name, System.Boolean includeHidden)
  System.Void ResetLocalCoords(UnityEngine.Transform transform, System.Boolean includeScale)
  System.Void SetLocalCoordsFrom(UnityEngine.Transform transform, UnityEngine.Transform source)
  UnityEngine.Transform InsertParentInChain(UnityEngine.Transform transform, System.String name)
  T GetAddComponent(UnityEngine.GameObject go)
  T GetAddComponent(UnityEngine.Component comp)
  UnityEngine.Component GetAddComponent(UnityEngine.GameObject go, System.Type type)
  System.Collections.Generic.List<System.String> GetBlendShapeNames(UnityEngine.SkinnedMeshRenderer skinnedMesh)
  System.Int32 GetBlendShapeIndex(UnityEngine.SkinnedMeshRenderer skinnedMesh, System.String shapeName)
END_CLASS

CLASS: Slate.VideoSampler
TYPE:  class
TOKEN: 0x20000AA
FIELDS:
  private   static  System.String                   ROOT_NAME  // 0x0
  private   static  UnityEngine.GameObject          root  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.Object,UnityEngine.Video.VideoPlayer>sources  // 0x8
METHODS:
  UnityEngine.Video.VideoPlayer GetSourceForID(System.Object keyID)
  System.Void ReleaseSourceForID(System.Object keyID)
  System.Void SampleForID(System.Object keyID, UnityEngine.Video.VideoClip clip, System.Single time, System.Single previousTime, Slate.VideoSampler.SampleSettings settings)
  System.Void Sample(UnityEngine.Video.VideoPlayer source, UnityEngine.Video.VideoClip clip, System.Single time, System.Single previousTime, Slate.VideoSampler.SampleSettings settings)
  System.Void .cctor()
END_CLASS

CLASS: Slate.CutsceneSequencePlayer
TYPE:  class
TOKEN: 0x20000AD
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  playOnStart  // 0x18
  public            System.Collections.Generic.List<Slate.Cutscene>cutscenes  // 0x20
  public            UnityEngine.Events.UnityEvent   onFinish  // 0x28
  private           System.Int32                    currentIndex  // 0x30
  private           System.Boolean                  isPlaying  // 0x34
METHODS:
  System.Void Start()
  System.Void Play()
  System.Void Stop()
  System.Void MoveNext()
  UnityEngine.GameObject Create()
  System.Void .ctor()
  System.Void <MoveNext>b__8_0()
END_CLASS

CLASS: Slate.DirectorGUITemplate
TYPE:  class
TOKEN: 0x20000AE
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  dontDestroyOnLoad  // 0x18
  public            UnityEngine.UI.CanvasScaler     absScaler  // 0x20
  public            UnityEngine.UI.CanvasScaler     refScaler  // 0x28
  public            UnityEngine.CanvasGroup         cameraDissolveGroup  // 0x30
  public            UnityEngine.UI.RawImage         dissolverImage  // 0x38
  public            UnityEngine.CanvasGroup         letterboxGroup  // 0x40
  public            UnityEngine.UI.RawImage         letterboxTop  // 0x48
  public            UnityEngine.UI.RawImage         letterboxBottom  // 0x50
  public            UnityEngine.CanvasGroup         screenFadeGroup  // 0x58
  public            UnityEngine.UI.RawImage         screenFadeImage  // 0x60
  public            UnityEngine.CanvasGroup         overlayImageGroup  // 0x68
  public            UnityEngine.UI.RawImage         overlayImage  // 0x70
  public            UnityEngine.CanvasGroup         overlayTextGroup  // 0x78
  public            UnityEngine.UI.Text             overlayText  // 0x80
  public            UnityEngine.CanvasGroup         subtitlesGroup  // 0x88
  public            UnityEngine.UI.Text             subtitlesText  // 0x90
  private   static  Slate.DirectorGUITemplate       _current  // 0x0
METHODS:
  System.Void Awake()
  System.Void ShowAll()
  System.Void HideAll()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void OnCameraDissolve(UnityEngine.Texture texture, System.Single completion)
  System.Void OnImageOverlayGUI(UnityEngine.Texture texture, UnityEngine.Color color, UnityEngine.Vector2 scale, UnityEngine.Vector2 position)
  System.Void OnLetterboxGUI(System.Single completion)
  System.Void OnScreenFadeGUI(UnityEngine.Color color)
  System.Void OnTextOverlayGUI(System.String text, UnityEngine.Color color, System.Single size, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 position)
  System.Void OnSubtitlesGUI(System.String text, UnityEngine.Color color)
  System.Void .ctor()
END_CLASS

CLASS: Slate.PlayCutsceneOnClick
TYPE:  class
TOKEN: 0x20000AF
EXTENDS: MonoBehaviour
FIELDS:
  public            Slate.Cutscene                  cutscene  // 0x18
  public            System.Single                   startTime  // 0x20
  public            UnityEngine.Events.UnityEvent   onFinish  // 0x28
METHODS:
  System.Void OnMouseDown()
  System.Void Reset()
  UnityEngine.GameObject Create()
  System.Void .ctor()
  System.Void <OnMouseDown>b__3_0()
END_CLASS

CLASS: Slate.PlayCutsceneOnStart
TYPE:  class
TOKEN: 0x20000B0
EXTENDS: MonoBehaviour
FIELDS:
  public            Slate.Cutscene                  cutscene  // 0x18
  public            System.Single                   startTime  // 0x20
  public            UnityEngine.Events.UnityEvent   onFinish  // 0x28
METHODS:
  System.Void Start()
  UnityEngine.GameObject Create()
  System.Void .ctor()
  System.Void <Start>b__3_0()
END_CLASS

CLASS: Slate.PlayCutsceneOnTrigger
TYPE:  class
TOKEN: 0x20000B1
EXTENDS: MonoBehaviour
FIELDS:
  public            Slate.Cutscene                  cutscene  // 0x18
  public            System.Single                   startTime  // 0x20
  public            System.Boolean                  checkSpecificTagOnly  // 0x24
  public            System.String                   tagName  // 0x28
  public            System.Boolean                  once  // 0x30
  public            UnityEngine.Events.UnityEvent   onFinish  // 0x38
METHODS:
  System.Void OnTriggerEnter(UnityEngine.Collider other)
  System.Void Reset()
  UnityEngine.GameObject Create()
  System.Void .ctor()
  System.Void <OnTriggerEnter>b__6_0()
END_CLASS

CLASS: Slate.StopCutsceneOnClick
TYPE:  class
TOKEN: 0x20000B2
EXTENDS: MonoBehaviour
FIELDS:
  public            Slate.Cutscene                  cutscene  // 0x18
  public            Slate.Cutscene.StopMode         stopMode  // 0x20
METHODS:
  System.Void OnMouseDown()
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: Slate.StopCutsceneOnTrigger
TYPE:  class
TOKEN: 0x20000B3
EXTENDS: MonoBehaviour
FIELDS:
  public            Slate.Cutscene                  cutscene  // 0x18
  public            System.Boolean                  checkSpecificTagOnly  // 0x20
  public            System.String                   tagName  // 0x28
  public            Slate.Cutscene.StopMode         stopMode  // 0x30
METHODS:
  System.Void OnTriggerEnter(UnityEngine.Collider other)
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ActorActionClip
TYPE:  class
TOKEN: 0x20000B4
EXTENDS: ActionClip
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ActorActionClip`1
TYPE:  class
TOKEN: 0x20000B5
EXTENDS: ActionClip
FIELDS:
  private           T                               _actorComponent  // 0x0
METHODS:
  T get_actor()
  System.Boolean get_isValid()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateProperties
TYPE:  class
TOKEN: 0x20000B6
EXTENDS: ActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  protected         System.String                   _name  // 0x50
  public            Slate.EaseType                  interpolation  // 0x58
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Boolean get_isValid()
  System.String get_info()
  System.Object get_animatedParametersTarget()
  Slate.EaseType get_animatedParametersInterpolation()
  System.Boolean get_useWeightInParameters()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateBlendShape
TYPE:  class
TOKEN: 0x20000B7
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  private           System.String                   _skinName  // 0x50
  private           System.String                   _shapeName  // 0x58
  public            System.Single                   weight  // 0x60
  private           System.Single                   originalWeight  // 0x64
  private           System.Int32                    index  // 0x68
  private           UnityEngine.SkinnedMeshRenderer _skinnedMesh  // 0x70
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Boolean get_canCrossBlend()
  System.String get_skinName()
  System.Void set_skinName(System.String value)
  System.String get_shapeName()
  System.Void set_shapeName(System.String value)
  UnityEngine.SkinnedMeshRenderer get_skinnedMesh()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
  System.Boolean <get_skinnedMesh>b__31_0(UnityEngine.SkinnedMeshRenderer s)
END_CLASS

CLASS: Slate.ActionClips.CharacterExpression
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4C
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   expressionName  // 0x58
  public            System.String                   expressionUID  // 0x60
  public            System.Single                   weight  // 0x68
  private           System.Single                   originalWeight  // 0x6C
  private           Slate.BlendShapeGroup           expression  // 0x70
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Boolean get_canCrossBlend()
  Slate.BlendShapeGroup ResolveExpression()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.CharacterLookAt
TYPE:  class
TOKEN: 0x20000B9
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4C
  private           System.Single                   _blendOut  // 0x50
  public            Slate.EaseType                  interpolation  // 0x54
  public            System.Single                   weight  // 0x58
  public            Slate.TransformRefPosition      targetPosition  // 0x60
  private           UnityEngine.Quaternion          wasNeckRot  // 0x80
  private           UnityEngine.Quaternion          wasHeadRot  // 0x90
METHODS:
  UnityEngine.Vector3 get_targetPositionVector()
  System.Void set_targetPositionVector(UnityEngine.Vector3 value)
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnCreate()
  System.Void OnAfterValidate()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessage`1
TYPE:  class
TOKEN: 0x20000BA
EXTENDS: SendMessage
FIELDS:
  public            T                               value  // 0x0
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Type get_parameterType()
  System.Void OnEnter()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessage
TYPE:  class
TOKEN: 0x20000BB
EXTENDS: ActorActionClip
FIELDS:
  public            System.String                   message  // 0x40
  public            System.Int32                    componentIndex  // 0x48
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Type get_parameterType()
  System.Void OnEnter()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessageBoolean
TYPE:  class
TOKEN: 0x20000BC
EXTENDS: SendMessage`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessageFloat
TYPE:  class
TOKEN: 0x20000BD
EXTENDS: SendMessage`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessageInteger
TYPE:  class
TOKEN: 0x20000BE
EXTENDS: SendMessage`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessageObject
TYPE:  class
TOKEN: 0x20000BF
EXTENDS: SendMessage`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendMessageString
TYPE:  class
TOKEN: 0x20000C0
EXTENDS: SendMessage`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateActorVisibility
TYPE:  class
TOKEN: 0x20000C1
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            System.Boolean                  visible  // 0x44
  private           System.Boolean                  wasVisible  // 0x45
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Void OnCreate()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.MakeCameraTarget
TYPE:  class
TOKEN: 0x20000C2
EXTENDS: ActorActionClip
FIELDS:
  public            System.Boolean                  setTransposerTarget  // 0x40
  public            System.Boolean                  setComposerTarget  // 0x41
  private           UnityEngine.Transform           wasTransposerTarget  // 0x48
  private           UnityEngine.Transform           wasComposerTarget  // 0x50
METHODS:
  System.Void OnEnter()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetActorActiveState
TYPE:  class
TOKEN: 0x20000C3
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            Slate.ActiveState               activeState  // 0x44
  private           System.Boolean                  lastState  // 0x48
  private           System.Boolean                  currentState  // 0x49
  private           System.Boolean                  temporary  // 0x4A
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.String get_info()
  System.Void OnEnter()
  System.Void OnExit()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetActorVisibilityTemporary
TYPE:  class
TOKEN: 0x20000C4
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            Slate.ActiveState               activeState  // 0x44
  private           System.Boolean                  lastState  // 0x48
  private           System.Boolean                  currentState  // 0x49
  private           System.Boolean                  temporary  // 0x4A
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.String get_info()
  System.Void OnEnter()
  System.Void OnExit()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetBehavioursActiveState
TYPE:  class
TOKEN: 0x20000C5
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            System.Collections.Generic.List<System.String>behaviourNames  // 0x48
  public            Slate.ActiveState               activeState  // 0x50
  private           System.Collections.Generic.Dictionary<UnityEngine.Behaviour,System.Boolean>originalStates  // 0x58
  private           System.Collections.Generic.Dictionary<UnityEngine.Behaviour,System.Boolean>currentStates  // 0x60
  private           System.Boolean                  temporary  // 0x68
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Void OnEnter()
  System.Void OnExit()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void .ctor()
  System.Boolean <OnEnter>b__11_0(UnityEngine.Behaviour c)
END_CLASS

CLASS: Slate.ActionClips.AnimateOnPath
TYPE:  class
TOKEN: 0x20000C6
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  public            Slate.Path                      path  // 0x48
  public            System.Single                   positionOnPath  // 0x50
  public            UnityEngine.Vector3             lookAtTargetPosition  // 0x54
  public            Slate.EaseType                  blendInterpolation  // 0x60
  private           UnityEngine.Vector3             wasPosition  // 0x64
  private           UnityEngine.Quaternion          wasRotation  // 0x70
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Boolean get_isValid()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.FollowPath
TYPE:  class
TOKEN: 0x20000C7
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            Slate.Path                      path  // 0x50
  public            System.Boolean                  useSpeed  // 0x58
  public            System.Single                   speed  // 0x5C
  public            System.Single                   lookAhead  // 0x60
  public            UnityEngine.Vector3             upVector  // 0x64
  public            Slate.EaseType                  blendInterpolation  // 0x70
  private           UnityEngine.Vector3             lastPos  // 0x74
  private           UnityEngine.Quaternion          lastRot  // 0x80
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Boolean get_isValid()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.PathfindFromTo
TYPE:  class
TOKEN: 0x20000C8
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _blendIn  // 0x40
  public            System.Single                   speed  // 0x44
  public            Slate.TransformRefPosition      sourcePosition  // 0x48
  public            Slate.TransformRefPosition      targetPosition  // 0x68
  private           UnityEngine.Vector3[]           pathPoints  // 0x88
  private           UnityEngine.Vector3             wasPosition  // 0x90
  private           UnityEngine.Quaternion          wasRotation  // 0x9C
  private           UnityEngine.Vector3             lastFrom  // 0xAC
  private           UnityEngine.Vector3             lastTo  // 0xB8
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void TryCalculatePath()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.PathfindTo
TYPE:  class
TOKEN: 0x20000C9
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _blendIn  // 0x40
  public            System.Single                   speed  // 0x44
  public            Slate.TransformRefPosition      targetPosition  // 0x48
  private           UnityEngine.Vector3[]           pathPoints  // 0x68
  private           UnityEngine.Vector3             wasPosition  // 0x70
  private           UnityEngine.Quaternion          wasRotation  // 0x7C
  private           UnityEngine.Vector3             lastFrom  // 0x8C
  private           UnityEngine.Vector3             lastTo  // 0x98
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void TryCalculatePath()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateMaterialColor
TYPE:  class
TOKEN: 0x20000CA
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4C
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   propertyName  // 0x58
  public            UnityEngine.Color               color  // 0x60
  public            Slate.EaseType                  interpolation  // 0x70
  private           UnityEngine.Color               originalColor  // 0x74
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  UnityEngine.Material get_targetMaterial()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void OnExit()
  System.Void DoSet()
  System.Void DoReset()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateMaterialFloat
TYPE:  class
TOKEN: 0x20000CB
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4C
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   propertyName  // 0x58
  public            System.Single                   value  // 0x60
  public            Slate.EaseType                  interpolation  // 0x64
  private           System.Single                   originalValue  // 0x68
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  UnityEngine.Material get_targetMaterial()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void OnExit()
  System.Void DoSet()
  System.Void DoReset()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateMaterialTexture
TYPE:  class
TOKEN: 0x20000CC
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4C
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   propertyName  // 0x58
  public            UnityEngine.Vector2             offset  // 0x60
  public            UnityEngine.Vector2             scale  // 0x68
  public            Slate.EaseType                  interpolation  // 0x70
  private           UnityEngine.Vector2             originalOffset  // 0x74
  private           UnityEngine.Vector2             originalScale  // 0x7C
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  UnityEngine.Material get_targetMaterial()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void OnExit()
  System.Void DoSet()
  System.Void DoReset()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ScrollMaterialTexture
TYPE:  class
TOKEN: 0x20000CD
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.String                   propertyName  // 0x50
  public            UnityEngine.Vector2             speed  // 0x58
  public            Slate.EaseType                  interpolation  // 0x60
  private           UnityEngine.Vector2             originalOffset  // 0x64
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  UnityEngine.Material get_targetMaterial()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetMaterial
TYPE:  class
TOKEN: 0x20000CE
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  public            UnityEngine.Material            material  // 0x50
  private           UnityEngine.Material            sharedMat  // 0x58
  private           System.Boolean                  temporary  // 0x60
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void OnExit()
  System.Void DoSet()
  System.Void DoReset()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetMaterialTexture
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.String                   propertyName  // 0x50
  public            UnityEngine.Texture             texture  // 0x58
  private           UnityEngine.Texture             originalTexture  // 0x60
  private           System.Boolean                  temporary  // 0x68
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  UnityEngine.Material get_targetMaterial()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void OnExit()
  System.Void DoSet()
  System.Void DoReset()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetSortingLayer
TYPE:  class
TOKEN: 0x20000D0
EXTENDS: ActorActionClip`1
FIELDS:
  public            System.Int32                    sortingOrder  // 0x48
  public            System.Int32                    sortingLayerID  // 0x4C
  private           System.String                   _lastLayer  // 0x50
  private           System.Int32                    _lastOrder  // 0x58
METHODS:
  System.String get_info()
  System.Void OnEnter()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetSprite
TYPE:  class
TOKEN: 0x20000D1
EXTENDS: ActorActionClip`1
FIELDS:
  public            UnityEngine.Sprite              sprite  // 0x48
  public            UnityEngine.Color               color  // 0x50
  public            System.Boolean                  flipX  // 0x60
  public            System.Boolean                  flipY  // 0x61
  public            System.Boolean                  changeSorting  // 0x62
  public            System.Int32                    sortingLayerID  // 0x64
  public            System.Int32                    sortingOrder  // 0x68
  private           UnityEngine.Sprite              lastSprite  // 0x70
  private           UnityEngine.Color               lastColor  // 0x78
  private           System.Boolean                  lastFlipX  // 0x88
  private           System.Boolean                  lastFlipY  // 0x89
  private           System.Int32                    lastSortingLayerID  // 0x8C
  private           System.Int32                    lastSortingOrder  // 0x90
METHODS:
  System.String get_info()
  System.Void OnEnter()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SpriteFlipbook
TYPE:  class
TOKEN: 0x20000D2
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.Int32                    loops  // 0x4C
  public            System.Collections.Generic.List<UnityEngine.Sprite>sprites  // 0x50
  public            System.Boolean                  endWithPrevious  // 0x58
  private           UnityEngine.Sprite              lastSprite  // 0x60
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Boolean get_isValid()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnExit()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AttachObject
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Transform           targetObject  // 0x48
  public            System.String                   childTransformName  // 0x50
  public            UnityEngine.Vector3             localPosition  // 0x58
  public            UnityEngine.Vector3             localRotation  // 0x64
  public            UnityEngine.Vector3             localScale  // 0x70
  private           Slate.TransformSnapshot         snapshot  // 0x80
  private           System.Boolean                  temporary  // 0x88
METHODS:
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnExit()
  System.Void OnReverse()
  System.Void Do()
  System.Void UnDo()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AttachObjectPrefab
TYPE:  class
TOKEN: 0x20000D4
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Transform           targetPrefab  // 0x48
  public            System.String                   childTransformName  // 0x50
  public            UnityEngine.Vector3             localPosition  // 0x58
  public            UnityEngine.Vector3             localRotation  // 0x64
  public            UnityEngine.Vector3             localScale  // 0x70
  private           UnityEngine.Transform           instance  // 0x80
  private           Slate.TransformSnapshot         snapshot  // 0x88
  private           System.Boolean                  temporary  // 0x90
METHODS:
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnExit()
  System.Void OnReverse()
  System.Void Do()
  System.Void UnDo()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.LookAt
TYPE:  class
TOKEN: 0x20000D5
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Boolean                  verticalOnly  // 0x4C
  public            Slate.EaseType                  interpolation  // 0x50
  public            Slate.TransformRefPosition      targetPosition  // 0x58
  private           UnityEngine.Quaternion          wasRotation  // 0x78
METHODS:
  UnityEngine.Vector3 get_targetPositionVector()
  System.Void set_targetPositionVector(UnityEngine.Vector3 value)
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnCreate()
  System.Void OnAfterValidate()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.MatchTransformsToTarget
TYPE:  class
TOKEN: 0x20000D6
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Transform           targetObject  // 0x50
  public            Slate.EaseType                  interpolation  // 0x58
  public            System.Boolean                  matchPosition  // 0x5C
  public            UnityEngine.Vector3             positionOffset  // 0x60
  public            System.Boolean                  matchRotation  // 0x6C
  public            UnityEngine.Vector3             rotationOffset  // 0x70
  public            System.Boolean                  matchScale  // 0x7C
  public            UnityEngine.Vector3             scaleOffset  // 0x80
  private           UnityEngine.Vector3             lastPos  // 0x8C
  private           UnityEngine.Quaternion          lastRot  // 0x98
  private           UnityEngine.Vector3             lastScale  // 0xA8
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Boolean get_isValid()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.Noise
TYPE:  class
TOKEN: 0x20000D7
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Vector3             seed  // 0x4C
  public            UnityEngine.Vector3             amplitude  // 0x58
  public            System.Single                   frequency  // 0x64
  private           UnityEngine.Vector3             wasPosition  // 0x68
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnCreate()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.RotateAround
TYPE:  class
TOKEN: 0x20000D8
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             rotation  // 0x44
  public            System.Boolean                  perSecond  // 0x50
  public            System.Boolean                  lookTarget  // 0x51
  public            Slate.EaseType                  interpolation  // 0x54
  public            Slate.TransformRefPosition      targetPosition  // 0x58
  private           UnityEngine.Vector3             wasPosition  // 0x78
  private           UnityEngine.Quaternion          wasRotation  // 0x84
  private           UnityEngine.Vector3             targetWasPosition  // 0x94
METHODS:
  UnityEngine.Vector3 get_targetPositionVector()
  System.Void set_targetPositionVector(UnityEngine.Vector3 value)
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void OnAfterValidate()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.RotateBy
TYPE:  class
TOKEN: 0x20000D9
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             rotation  // 0x44
  public            System.Boolean                  perSecond  // 0x50
  public            Slate.EaseType                  interpolation  // 0x54
  private           UnityEngine.Vector3             originalRot  // 0x58
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.RotateTo
TYPE:  class
TOKEN: 0x20000DA
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             targetRotation  // 0x44
  public            Slate.EaseType                  interpolation  // 0x50
  private           UnityEngine.Vector3             originalRot  // 0x54
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ScaleBy
TYPE:  class
TOKEN: 0x20000DB
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             scale  // 0x44
  public            System.Boolean                  perSecond  // 0x50
  public            Slate.EaseType                  interpolation  // 0x54
  private           UnityEngine.Vector3             originalScale  // 0x58
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ScaleTo
TYPE:  class
TOKEN: 0x20000DC
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             targetScale  // 0x44
  public            Slate.EaseType                  interpolation  // 0x50
  private           UnityEngine.Vector3             originalPos  // 0x54
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetParentTemporary
TYPE:  class
TOKEN: 0x20000DD
EXTENDS: ActorActionClip
FIELDS:
  public            System.Single                   _length  // 0x40
  public            UnityEngine.Transform           newParent  // 0x48
  public            System.Boolean                  matchPosition  // 0x50
  public            System.Boolean                  matchRotation  // 0x51
  public            System.Boolean                  matchScale  // 0x52
  private           UnityEngine.Transform           originalParent  // 0x58
  private           UnityEngine.Vector3             originalPos  // 0x60
  private           UnityEngine.Quaternion          originalRot  // 0x6C
  private           UnityEngine.Vector3             originalScale  // 0x7C
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetTransformParent
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Transform           newParent  // 0x48
  public            System.Boolean                  resetPosition  // 0x50
  public            System.Boolean                  resetRotation  // 0x51
  public            System.Boolean                  resetScale  // 0x52
  private           UnityEngine.Transform           originalParent  // 0x58
  private           UnityEngine.Vector3             originalPos  // 0x60
  private           UnityEngine.Quaternion          originalRot  // 0x6C
  private           UnityEngine.Vector3             originalScale  // 0x7C
  private           System.Boolean                  temporary  // 0x88
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnExit()
  System.Void OnReverse()
  System.Void Do()
  System.Void UnDo()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SetTransformValues
TYPE:  class
TOKEN: 0x20000DF
EXTENDS: ActorActionClip
FIELDS:
  public            Slate.MiniTransformSpace        space  // 0x40
  public            System.Boolean                  setPosition  // 0x44
  public            UnityEngine.Vector3             position  // 0x48
  public            System.Boolean                  setRotation  // 0x54
  public            UnityEngine.Vector3             rotation  // 0x58
  public            System.Boolean                  setScale  // 0x64
  public            UnityEngine.Vector3             scale  // 0x68
  private           Slate.TransformSnapshot         undo  // 0x78
METHODS:
  System.Void OnEnter()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SimpleGrounder
TYPE:  class
TOKEN: 0x20000E0
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            System.Single                   maxCheckDistance  // 0x44
  public            System.Single                   offset  // 0x48
  private           UnityEngine.RaycastHit          hit  // 0x50
  private           UnityEngine.Vector3             lastPos  // 0x90
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.TranslateBy
TYPE:  class
TOKEN: 0x20000E1
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             translation  // 0x44
  public            System.Boolean                  perSecond  // 0x50
  public            Slate.EaseType                  interpolation  // 0x54
  private           UnityEngine.Vector3             originalPos  // 0x58
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.TranslateTo
TYPE:  class
TOKEN: 0x20000E2
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Vector3             targetPosition  // 0x44
  public            Slate.MiniTransformSpace        space  // 0x50
  public            Slate.EaseType                  interpolation  // 0x54
  private           UnityEngine.Vector3             wasPosition  // 0x58
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AdditiveScene
TYPE:  class
TOKEN: 0x20000E3
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  protected         System.String                   _scenePath  // 0x48
  public            UnityEngine.Vector3             scenePosition  // 0x50
  public            UnityEngine.Vector3             sceneRotation  // 0x5C
  public            Slate.MiniTransformSpace        space  // 0x68
  public            System.Boolean                  updateRootCutscenes  // 0x6C
  public            System.Single                   timeOffset  // 0x70
  private           UnityEngine.SceneManagement.ScenesubScene  // 0x74
  private           System.Collections.Generic.List<Slate.Cutscene>rootCutscenes  // 0x78
  private           System.Boolean                  temporary  // 0x80
  private           System.Boolean                  waitLoad  // 0x81
METHODS:
  System.Single Slate.ISubClipContainable.get_subClipOffset()
  System.Void Slate.ISubClipContainable.set_subClipOffset(System.Single value)
  System.Single Slate.ISubClipContainable.get_subClipLength()
  System.Single Slate.ISubClipContainable.get_subClipSpeed()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnExit()
  System.Void OnReverse()
  System.Void Activate()
  System.Void Deactivate()
  System.String CleanPath(System.String path)
  System.Void InitializeSubSceneCutscenes()
  System.Void DenitializeSubSceneCutscenes(System.Boolean forward)
  System.Void .ctor()
  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.ActionClips.SubCutscene
TYPE:  class
TOKEN: 0x20000E4
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            Slate.Cutscene                  subCutscene  // 0x48
  public            System.Single                   subCutsceneTimeOffset  // 0x50
  private           System.Boolean                  wasCamTrackActive  // 0x54
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  UnityEngine.GameObject get_actor()
  System.Single Slate.ISubClipContainable.get_subClipOffset()
  System.Void Slate.ISubClipContainable.set_subClipOffset(System.Single value)
  System.Single Slate.ISubClipContainable.get_subClipLength()
  System.Single Slate.ISubClipContainable.get_subClipSpeed()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnExit()
  System.Void OnReverse()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void .ctor()
  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.ActionClips.DestroyGameObjects
TYPE:  class
TOKEN: 0x20000E5
EXTENDS: DirectorActionClip
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.GameObject>targetObjects  // 0x40
METHODS:
  System.String get_info()
  System.Void OnEnter()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.DirectorDisableGameObjects
TYPE:  class
TOKEN: 0x20000E6
EXTENDS: DirectorActionClip
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.GameObject>targetObjects  // 0x40
  private           System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean>states  // 0x48
METHODS:
  System.String get_info()
  System.Void OnEnter()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.DirectorEnableGameObjects
TYPE:  class
TOKEN: 0x20000E7
EXTENDS: DirectorActionClip
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.GameObject>targetObjects  // 0x40
  private           System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean>states  // 0x48
METHODS:
  System.String get_info()
  System.Void OnEnter()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.InstantiateObject
TYPE:  class
TOKEN: 0x20000E8
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.GameObject          targetObject  // 0x50
  public            UnityEngine.Transform           optionalParent  // 0x58
  public            UnityEngine.Vector3             targetPosition  // 0x60
  public            UnityEngine.Vector3             targetRotation  // 0x6C
  public            Slate.MiniTransformSpace        space  // 0x78
  public            Slate.EaseType                  popupInterpolation  // 0x7C
  private           UnityEngine.GameObject          instance  // 0x80
  private           UnityEngine.Vector3             wasScale  // 0x88
METHODS:
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.String get_info()
  UnityEngine.GameObject get_actor()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnExit()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SampleParticleSystem
TYPE:  class
TOKEN: 0x20000E9
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.ParticleSystem      particles  // 0x48
  public            System.Boolean                  simulationSync  // 0x50
  private           UnityEngine.ParticleSystem.EmissionModuleem  // 0x58
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendOut()
  System.Boolean get_loop()
  System.Single get_duration()
  System.Single get_startLifetime()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnExit()
  System.Void OnReverse()
  System.Void OnRootEnabled()
  System.Void OnRootDisabled()
  System.Void Play()
  System.Void OnUpdate(System.Single time)
  System.Void Stop()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.TransitAudioMixerSnapshot
TYPE:  class
TOKEN: 0x20000EA
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  public            UnityEngine.Audio.AudioMixer    audioMixer  // 0x48
  public            System.String                   snapshotName  // 0x50
  private           UnityEngine.Audio.AudioMixerSnapshotsnapshot  // 0x58
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Boolean get_isValid()
  System.Void OnReverseEnter()
  System.Void OnEnter()
  System.Void Do()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateAmbientLighting
TYPE:  class
TOKEN: 0x20000EB
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Single                   ambientIntensity  // 0x4C
  public            UnityEngine.Color               ambientColor  // 0x50
  private           System.Single                   wasIntensity  // 0x60
  private           UnityEngine.Color               wasColor  // 0x64
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnCreate()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateFog
TYPE:  class
TOKEN: 0x20000EC
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Color               fogColor  // 0x4C
  public            System.Single                   fogDensity  // 0x5C
  public            System.Single                   linearFogStartDistance  // 0x60
  public            System.Single                   linearFogEndDistance  // 0x64
  private           UnityEngine.Color               wasColor  // 0x68
  private           System.Single                   wasDensity  // 0x78
  private           System.Single                   wasStartDistance  // 0x7C
  private           System.Single                   wasEndDistance  // 0x80
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnCreate()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateGravity
TYPE:  class
TOKEN: 0x20000ED
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Vector3             gravity  // 0x4C
  private           UnityEngine.Vector3             wasGravity  // 0x58
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnCreate()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateTimeScale
TYPE:  class
TOKEN: 0x20000EE
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Single                   timeScale  // 0x4C
  public            Slate.EaseType                  interpolation  // 0x50
  private           System.Single                   wasScale  // 0x54
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnCreate()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.EasySlowMotion
TYPE:  class
TOKEN: 0x20000EF
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Single                   timeScale  // 0x4C
  public            Slate.EaseType                  interpolation  // 0x50
  private           System.Single                   lastTimeScale  // 0x54
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.String get_info()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.RaiseUnityEvent
TYPE:  class
TOKEN: 0x20000F0
EXTENDS: DirectorActionClip
FIELDS:
  public            System.String                   customLabel  // 0x40
  public            UnityEngine.Events.UnityEvent   forwardEvent  // 0x48
  public            UnityEngine.Events.UnityEvent   reverseEvent  // 0x50
METHODS:
  System.String get_info()
  System.Void OnEnter()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessage`1
TYPE:  class
TOKEN: 0x20000F1
EXTENDS: SendGlobalMessage
FIELDS:
  public            T                               value  // 0x0
METHODS:
  System.String get_info()
  System.Void OnEnter()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessage
TYPE:  class
TOKEN: 0x20000F2
EXTENDS: DirectorActionClip
FIELDS:
  public            System.String                   message  // 0x40
METHODS:
  System.String get_info()
  System.Boolean get_isValid()
  System.String Slate.IEvent.get_name()
  System.Void Slate.IEvent.Invoke()
  System.Void OnEnter()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessageBoolean
TYPE:  class
TOKEN: 0x20000F3
EXTENDS: SendGlobalMessage`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessageFloat
TYPE:  class
TOKEN: 0x20000F4
EXTENDS: SendGlobalMessage`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessageInteger
TYPE:  class
TOKEN: 0x20000F5
EXTENDS: SendGlobalMessage`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessageObject
TYPE:  class
TOKEN: 0x20000F6
EXTENDS: SendGlobalMessage`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.SendGlobalMessageString
TYPE:  class
TOKEN: 0x20000F7
EXTENDS: SendGlobalMessage`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.Captions
TYPE:  class
TOKEN: 0x20000F8
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.String                   text  // 0x50
  public            UnityEngine.Color               color  // 0x58
  public            Slate.EaseType                  interpolation  // 0x68
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnUpdate(System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.CineBox
TYPE:  class
TOKEN: 0x20000F9
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnUpdate(System.Single time)
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.OverlayText
TYPE:  class
TOKEN: 0x20000FA
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.String                   text  // 0x50
  public            UnityEngine.TextAnchor          anchor  // 0x58
  public            Slate.EaseType                  interpolation  // 0x5C
  public            UnityEngine.Color               color  // 0x60
  public            System.Single                   size  // 0x70
  public            UnityEngine.Vector2             position  // 0x74
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnUpdate(System.Single time)
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.OverlayTexture
TYPE:  class
TOKEN: 0x20000FB
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.Texture             texture  // 0x50
  public            UnityEngine.Color               color  // 0x58
  public            UnityEngine.Vector2             scale  // 0x68
  public            UnityEngine.Vector2             position  // 0x70
  public            Slate.EaseType                  interpolation  // 0x78
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnUpdate(System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ScreenFader
TYPE:  class
TOKEN: 0x20000FC
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Single                   fade  // 0x4C
  public            UnityEngine.Color               outColor  // 0x50
  public            Slate.EaseType                  interpolation  // 0x60
  private           UnityEngine.Color               lastColor  // 0x64
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimatePlaybackSpeed
TYPE:  class
TOKEN: 0x20000FD
EXTENDS: DirectorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            System.Single                   speed  // 0x4C
  public            Slate.EaseType                  interpolation  // 0x50
  private           System.Single                   wasSpeed  // 0x54
METHODS:
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnCreate()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.DebugLog
TYPE:  class
TOKEN: 0x20000FE
EXTENDS: DirectorActionClip
FIELDS:
  public            System.Boolean                  neverSkip  // 0x40
  public            System.String                   text  // 0x48
METHODS:
  System.String get_info()
  System.Void OnEnter()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.PauseCutscene
TYPE:  class
TOKEN: 0x20000FF
EXTENDS: DirectorActionClip
FIELDS:
METHODS:
  System.Void OnEnter()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.ScreenCapture
TYPE:  class
TOKEN: 0x2000100
EXTENDS: DirectorActionClip
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.PlayAnimationClip
TYPE:  class
TOKEN: 0x2000101
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4C
  private           System.Single                   _blendOut  // 0x50
  public            UnityEngine.AnimationClip       animationClip  // 0x58
  public            System.Single                   clipOffset  // 0x60
  public            System.Single                   playbackSpeed  // 0x64
  private           Slate.TransformSnapshot         snapShot  // 0x68
  private           UnityEngine.Transform           mixTransform  // 0x70
  private           UnityEngine.AnimationState      state  // 0x78
  private           System.Boolean                  isListClip  // 0x80
METHODS:
  System.Single Slate.ISubClipContainable.get_subClipOffset()
  System.Void Slate.ISubClipContainable.set_subClipOffset(System.Single value)
  System.Single Slate.ISubClipContainable.get_subClipLength()
  System.Single Slate.ISubClipContainable.get_subClipSpeed()
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Boolean get_canCrossBlend()
  Slate.AnimationTrack get_track()
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnReverse()
  System.Void OnExit()
  System.Void OnReverseEnter()
  System.Void .ctor()
  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.ActionClips.PlayAnimatorClip
TYPE:  class
TOKEN: 0x2000102
EXTENDS: ActorActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.AnimationClip       animationClip  // 0x50
  public            System.Single                   clipOffset  // 0x58
  public            Slate.ActionClips.PlayAnimatorClip.ClipWrapModeclipWrapMode  // 0x5C
  public            System.Single                   clipWeight  // 0x60
  public            System.Single                   playbackSpeed  // 0x64
  public            Slate.ActionClips.PlayAnimatorClip.StartingTransformsModestartingTransformsMode  // 0x68
  public            Slate.MiniTransformSpace        transformSpace  // 0x6C
  public            UnityEngine.Vector3             startingPosition  // 0x70
  public            UnityEngine.Vector3             startingRotation  // 0x7C
  public            UnityEngine.Vector2             steerLocalRotation  // 0x88
  protected         UnityEngine.Vector3             wasPosition  // 0x90
  protected         UnityEngine.Quaternion          wasRotation  // 0x9C
METHODS:
  System.Boolean get_isMasterAndManualSet()
  System.Single Slate.ISubClipContainable.get_subClipOffset()
  System.Void Slate.ISubClipContainable.set_subClipOffset(System.Single value)
  System.Single Slate.ISubClipContainable.get_subClipLength()
  System.Single Slate.ISubClipContainable.get_subClipSpeed()
  System.String get_info()
  System.Boolean get_isValid()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Boolean get_canCrossBlend()
  Slate.AnimatorTrack get_track()
  UnityEngine.Animator get_animator()
  System.Boolean get_isMasterTrack()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void OnExit()
  System.Void OnReverse()
  System.Void .ctor()
  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.ActionClips.PlayAudio
TYPE:  class
TOKEN: 0x2000105
EXTENDS: ActionClip
FIELDS:
  private           System.Single                   _length  // 0x40
  private           System.Single                   _blendIn  // 0x44
  private           System.Single                   _blendOut  // 0x48
  public            UnityEngine.AudioClip           audioClip  // 0x50
  public            System.Single                   volume  // 0x58
  public            System.Single                   pitch  // 0x5C
  public            System.Single                   stereoPan  // 0x60
  public            System.Single                   clipOffset  // 0x64
  public            System.String                   subtitlesText  // 0x68
  public            UnityEngine.Color               subtitlesColor  // 0x70
METHODS:
  System.Single Slate.ISubClipContainable.get_subClipOffset()
  System.Void Slate.ISubClipContainable.set_subClipOffset(System.Single value)
  System.Single Slate.ISubClipContainable.get_subClipLength()
  System.Single Slate.ISubClipContainable.get_subClipSpeed()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Boolean get_isValid()
  System.String get_info()
  Slate.AudioTrack get_track()
  UnityEngine.AudioSource get_source()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnExit()
  System.Void OnReverse()
  System.Void Do()
  System.Void OnUpdate(System.Single time, System.Single previousTime)
  System.Void Undo()
  System.Void .ctor()
  System.String Slate.IDirectable.get_name()
END_CLASS

CLASS: Slate.ActionClips.AnimateBoolParameter
TYPE:  class
TOKEN: 0x2000106
EXTENDS: MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.String                   parameterName  // 0x50
  public            System.Boolean                  value  // 0x58
  private           System.Boolean                  lastValue  // 0x59
METHODS:
  System.Boolean get_isValid()
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Void OnEnter()
  System.Void OnUpdate(System.Single time)
  System.Void OnExit()
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateFloatParameter
TYPE:  class
TOKEN: 0x2000107
EXTENDS: MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4C
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   parameterName  // 0x58
  public            System.Single                   value  // 0x60
  private           System.Single                   lastValue  // 0x64
METHODS:
  System.Boolean get_isValid()
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateIntegerParameter
TYPE:  class
TOKEN: 0x2000108
EXTENDS: MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4C
  private           System.Single                   _blendOut  // 0x50
  public            System.String                   parameterName  // 0x58
  public            System.Int32                    value  // 0x60
  private           System.Int32                    lastValue  // 0x64
METHODS:
  System.Boolean get_isValid()
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateLayerWeight
TYPE:  class
TOKEN: 0x2000109
EXTENDS: MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4C
  private           System.Single                   _blendOut  // 0x50
  public            System.Int32                    layerIndex  // 0x54
  public            System.Single                   weight  // 0x58
  private           System.Single                   lastValue  // 0x5C
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnEnter()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnReverse()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateLimbIK
TYPE:  class
TOKEN: 0x200010A
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4C
  private           System.Single                   _blendOut  // 0x50
  public            UnityEngine.AvatarIKGoal        IKGoal  // 0x54
  public            System.Single                   weight  // 0x58
  public            Slate.TransformRefPositionRotationIKTarget  // 0x60
  private           Slate.AnimatorDispatcher        dispatcher  // 0x90
METHODS:
  UnityEngine.Vector3 get_targetPosition()
  System.Void set_targetPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_targetRotation()
  System.Void set_targetRotation(UnityEngine.Vector3 value)
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnCreate()
  System.Void OnAfterValidate()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void OnExit()
  System.Void OnRootDisabled()
  System.Void OnAnimatorIK(System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateLookAtIK
TYPE:  class
TOKEN: 0x200010C
EXTENDS: ActorActionClip`1
FIELDS:
  private           System.Single                   _length  // 0x48
  private           System.Single                   _blendIn  // 0x4C
  private           System.Single                   _blendOut  // 0x50
  public            System.Single                   weight  // 0x54
  public            System.Single                   bodyWeight  // 0x58
  public            System.Single                   headWeight  // 0x5C
  public            System.Single                   eyesWeight  // 0x60
  public            Slate.TransformRefPosition      targetPosition  // 0x68
  private           Slate.AnimatorDispatcher        dispatcher  // 0x88
METHODS:
  UnityEngine.Vector3 get_targetPositionVector()
  System.Void set_targetPositionVector(UnityEngine.Vector3 value)
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void set_blendIn(System.Single value)
  System.Single get_blendOut()
  System.Void set_blendOut(System.Single value)
  System.Void OnCreate()
  System.Void OnAfterValidate()
  System.Void OnEnter()
  System.Void OnReverseEnter()
  System.Void OnReverse()
  System.Void OnExit()
  System.Void OnRootDisabled()
  System.Void OnAnimatorIK(System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.AnimateTrigger
TYPE:  class
TOKEN: 0x200010E
EXTENDS: MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.String                   triggerName  // 0x50
  public            System.Boolean                  value  // 0x58
METHODS:
  System.Boolean get_isValid()
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Void OnUpdate(System.Single time)
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.CrossFadeState
TYPE:  class
TOKEN: 0x200010F
EXTENDS: MecanimBaseClip
FIELDS:
  private           System.Single                   _length  // 0x48
  public            System.String                   stateName  // 0x50
METHODS:
  System.String get_info()
  System.Single get_length()
  System.Void set_length(System.Single value)
  System.Single get_blendIn()
  System.Void OnEnter()
  System.Void .ctor()
END_CLASS

CLASS: Slate.ActionClips.MecanimBaseClip
TYPE:  class
TOKEN: 0x2000110
EXTENDS: ActorActionClip`1
FIELDS:
METHODS:
  System.Boolean get_isValid()
  System.Boolean HasParameter(System.String name)
  System.Void .ctor()
END_CLASS

