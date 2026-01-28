// ========================================================
// Dumped by @desirepro
// Assembly: Cinemachine.dll
// Classes:  204
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: CinemachineCameraOffset
TYPE:  class
TOKEN: 0x2000002
EXTENDS: CinemachineExtension
FIELDS:
  public            UnityEngine.Vector3             m_Offset  // 0x28
  public            Cinemachine.CinemachineCore.Stagem_ApplyAfter  // 0x34
  public            System.Boolean                  m_PreserveComposition  // 0x38
METHODS:
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: CinemachineRecomposer
TYPE:  class
TOKEN: 0x2000003
EXTENDS: CinemachineExtension
FIELDS:
  public            Cinemachine.CinemachineCore.Stagem_ApplyAfter  // 0x28
  public            System.Single                   m_Tilt  // 0x2C
  public            System.Single                   m_Pan  // 0x30
  public            System.Single                   m_Dutch  // 0x34
  public            System.Single                   m_ZoomScale  // 0x38
  public            System.Single                   m_FollowAttachment  // 0x3C
  public            System.Single                   m_LookAtAttachment  // 0x40
METHODS:
  System.Void Reset()
  System.Void OnValidate()
  System.Void PrePipelineMutateCameraStateCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: CinemachineBeyondCommunicator
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private   static  System.Func<Cinemachine.CinemachineVirtualCameraBase><GetLevelCamera>k__BackingField  // 0x0
METHODS:
  System.Func<Cinemachine.CinemachineVirtualCameraBase> get_GetLevelCamera()
  System.Void set_GetLevelCamera(System.Func<Cinemachine.CinemachineVirtualCameraBase> value)
END_CLASS

CLASS: CinemachineTouchInputMapper
TYPE:  class
TOKEN: 0x2000005
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Single                   TouchSensitivityX  // 0x18
  public            System.Single                   TouchSensitivityY  // 0x1C
  public            System.String                   TouchXInputMapTo  // 0x20
  public            System.String                   TouchYInputMapTo  // 0x28
METHODS:
  System.Void Start()
  System.Single GetInputAxis(System.String axisName)
  System.Void .ctor()
END_CLASS

CLASS: CinemachineMixer
TYPE:  class
TOKEN: 0x2000006
EXTENDS: PlayableBehaviour
FIELDS:
  private           Cinemachine.CinemachineBrain    mBrain  // 0x10
  private           System.Int32                    mBrainOverrideId  // 0x18
  private           System.Boolean                  mPreviewPlay  // 0x1C
METHODS:
  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  System.Single GetDeltaTime(System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: CinemachineShot
TYPE:  class
TOKEN: 0x2000007
EXTENDS: PlayableAsset
FIELDS:
  public            System.Boolean                  DisableEvaluateTwiceWhenEnabled  // 0x18
  public            System.Boolean                  UseVcamBeforeTimeline  // 0x19
  public            System.Boolean                  UseLevelCamera  // 0x1A
  public            System.String                   DisplayName  // 0x20
  public            UnityEngine.ExposedReference<Cinemachine.CinemachineVirtualCameraBase>VirtualCamera  // 0x28
METHODS:
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  System.Void .ctor()
END_CLASS

CLASS: CinemachineShotPlayable
TYPE:  class
TOKEN: 0x2000008
EXTENDS: PlayableBehaviour
FIELDS:
  public            Cinemachine.CinemachineVirtualCameraBaseVirtualCamera  // 0x10
METHODS:
  System.Boolean get_IsValid()
  System.Void .ctor()
END_CLASS

CLASS: CinemachineTrack
TYPE:  class
TOKEN: 0x2000009
EXTENDS: TrackAsset
FIELDS:
METHODS:
  UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  System.Void .ctor()
END_CLASS

CLASS: Instruction
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            Cinemachine.CinemachineVirtualCameraBasem_VirtualCamera  // 0x10
  public            System.Single                   m_Hold  // 0x18
  public            Cinemachine.CinemachineBlendDefinitionm_Blend  // 0x20
METHODS:
END_CLASS

CLASS: UpdateMethod
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineBrain.UpdateMethodFixedUpdate  // 0x0
  public    static  Cinemachine.CinemachineBrain.UpdateMethodLateUpdate  // 0x0
  public    static  Cinemachine.CinemachineBrain.UpdateMethodSmartUpdate  // 0x0
  public    static  Cinemachine.CinemachineBrain.UpdateMethodManualUpdate  // 0x0
METHODS:
END_CLASS

CLASS: BrainUpdateMethod
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineBrain.BrainUpdateMethodFixedUpdate  // 0x0
  public    static  Cinemachine.CinemachineBrain.BrainUpdateMethodLateUpdate  // 0x0
METHODS:
END_CLASS

CLASS: BrainEvent
TYPE:  class
TOKEN: 0x2000010
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VcamActivatedEvent
TYPE:  class
TOKEN: 0x2000011
EXTENDS: UnityEvent`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: BrainFrame
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  public            System.Int32                    id  // 0x10
  public            Cinemachine.CinemachineBlend    blend  // 0x18
  public            Cinemachine.CinemachineBlend    workingBlend  // 0x20
  public            Cinemachine.BlendSourceVirtualCameraworkingBlendSource  // 0x28
  public            System.Single                   deltaTimeOverride  // 0x30
METHODS:
  System.Boolean get_Active()
  System.Void .ctor()
END_CLASS

CLASS: Pair
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int32                    a  // 0x10
  public            System.Single                   b  // 0x14
METHODS:
END_CLASS

CLASS: ResolutionStrategy
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineCollider.ResolutionStrategyPullCameraForward  // 0x0
  public    static  Cinemachine.CinemachineCollider.ResolutionStrategyPreserveCameraHeight  // 0x0
  public    static  Cinemachine.CinemachineCollider.ResolutionStrategyPreserveCameraDistance  // 0x0
METHODS:
END_CLASS

CLASS: VcamExtraState
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  public            UnityEngine.Vector3             previousDisplacement  // 0x10
  public            System.Single                   previousLookAt2DisplacedPosLen  // 0x1C
  public            System.Boolean                  shouldPerformCollisionDamping  // 0x20
  public            System.Boolean                  previousHitSomething  // 0x21
  public            System.Boolean                  targetObscured  // 0x22
  public            System.Single                   occlusionStartTime  // 0x24
  public            System.Collections.Generic.List<UnityEngine.Vector3>debugResolutionPath  // 0x28
  private           System.Single                   m_SmoothedDistance  // 0x30
  private           System.Single                   m_SmoothedTime  // 0x34
METHODS:
  System.Void AddPointToDebugPath(UnityEngine.Vector3 p)
  System.Single ApplyDistanceSmoothing(System.Single distance, System.Single smoothingTime)
  System.Void UpdateDistanceSmoothing(System.Single distance)
  System.Void ResetDistanceSmoothing(System.Single smoothingTime)
  System.Void .ctor()
END_CLASS

CLASS: Mode
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineConfiner.ModeConfine2D  // 0x0
  public    static  Cinemachine.CinemachineConfiner.ModeConfine3D  // 0x0
METHODS:
END_CLASS

CLASS: VcamExtraState
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  public            UnityEngine.Vector3             m_previousDisplacement  // 0x10
  public            System.Single                   confinerDisplacement  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: VcamExtraState
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  public            UnityEngine.Vector3             m_PreviousDisplacement  // 0x10
  public            UnityEngine.Vector3             m_DampedDisplacement  // 0x1C
  public            Cinemachine.ConfinerOven.BakedSolutionm_BakedSolution  // 0x28
  public            Cinemachine.CinemachineVirtualCameraBasem_vcam  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ShapeCache
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            Cinemachine.ConfinerOven        m_confinerOven  // 0x10
  public            System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>m_OriginalPath  // 0x18
  public            UnityEngine.Matrix4x4           m_DeltaWorldToBaked  // 0x20
  public            UnityEngine.Matrix4x4           m_DeltaBakedToWorld  // 0x60
  private           System.Single                   m_aspectRatio  // 0xA0
  private           System.Single                   m_maxWindowSize  // 0xA4
  private           System.Single                   m_maxComputationTimePerFrameInSeconds  // 0xA8
  private           UnityEngine.Matrix4x4           m_bakedToWorld  // 0xAC
  private           UnityEngine.Collider2D          m_boundingShape2D  // 0xF0
METHODS:
  System.Void Invalidate()
  System.Boolean ValidateCache(UnityEngine.Collider2D boundingShape2D, System.Single maxWindowSize, System.Single aspectRatio, System.Boolean& confinerStateChanged)
  System.Boolean IsValid(UnityEngine.Collider2D& boundingShape2D, System.Single& aspectRatio, System.Single& maxOrthoSize)
  System.Void CalculateDeltaTransformationMatrix()
END_CLASS

CLASS: UpdateMethod
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineDollyCart.UpdateMethodUpdate  // 0x0
  public    static  Cinemachine.CinemachineDollyCart.UpdateMethodFixedUpdate  // 0x0
  public    static  Cinemachine.CinemachineDollyCart.UpdateMethodLateUpdate  // 0x0
METHODS:
END_CLASS

CLASS: VcamExtraState
TYPE:  class
TOKEN: 0x2000024
FIELDS:
  public            System.Single                   m_previousFrameZoom  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Orbit
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Single                   m_Height  // 0x10
  public            System.Single                   m_Radius  // 0x14
METHODS:
  System.Void .ctor(System.Single h, System.Single r)
END_CLASS

CLASS: CreateRigDelegate
TYPE:  class
TOKEN: 0x2000027
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Cinemachine.CinemachineVirtualCamera Invoke(Cinemachine.CinemachineFreeLook vcam, System.String name, Cinemachine.CinemachineVirtualCamera copyFrom)
END_CLASS

CLASS: DestroyRigDelegate
TYPE:  class
TOKEN: 0x2000028
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.GameObject rig)
END_CLASS

CLASS: Waypoint
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector3             tangent  // 0x1C
  public            System.Single                   roll  // 0x28
METHODS:
END_CLASS

CLASS: Waypoint
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            System.Single                   roll  // 0x1C
METHODS:
  UnityEngine.Vector4 get_AsVector4()
  Cinemachine.CinemachineSmoothPath.Waypoint FromVector4(UnityEngine.Vector4 v)
END_CLASS

CLASS: Instruction
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Int32                    m_FullHash  // 0x10
  public            Cinemachine.CinemachineVirtualCameraBasem_VirtualCamera  // 0x18
  public            System.Single                   m_ActivateAfter  // 0x20
  public            System.Single                   m_MinDuration  // 0x24
METHODS:
END_CLASS

CLASS: ParentHash
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            System.Int32                    m_Hash  // 0x10
  public            System.Int32                    m_ParentHash  // 0x14
METHODS:
END_CLASS

CLASS: HashPair
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    parentHash  // 0x10
  public            System.Int32                    hash  // 0x14
METHODS:
END_CLASS

CLASS: FillStrategy
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineStoryboard.FillStrategyBestFit  // 0x0
  public    static  Cinemachine.CinemachineStoryboard.FillStrategyCropImageToFit  // 0x0
  public    static  Cinemachine.CinemachineStoryboard.FillStrategyStretchToFit  // 0x0
METHODS:
END_CLASS

CLASS: CanvasInfo
TYPE:  class
TOKEN: 0x2000036
FIELDS:
  public            UnityEngine.GameObject          mCanvas  // 0x10
  public            UnityEngine.Canvas              mCanvasComponent  // 0x18
  public            Cinemachine.CinemachineBrain    mCanvasParent  // 0x20
  public            UnityEngine.RectTransform       mViewport  // 0x28
  public            UnityEngine.UI.RawImage         mRawImage  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: StoryboardRenderMode
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineStoryboard.StoryboardRenderModeScreenSpaceOverlay  // 0x0
  public    static  Cinemachine.CinemachineStoryboard.StoryboardRenderModeScreenSpaceCamera  // 0x0
METHODS:
END_CLASS

CLASS: Target
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            UnityEngine.Transform           target  // 0x10
  public            System.Single                   weight  // 0x18
  public            System.Single                   radius  // 0x1C
METHODS:
END_CLASS

CLASS: PositionMode
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineTargetGroup.PositionModeGroupCenter  // 0x0
  public    static  Cinemachine.CinemachineTargetGroup.PositionModeGroupAverage  // 0x0
METHODS:
END_CLASS

CLASS: RotationMode
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineTargetGroup.RotationModeManual  // 0x0
  public    static  Cinemachine.CinemachineTargetGroup.RotationModeGroupAverage  // 0x0
METHODS:
END_CLASS

CLASS: UpdateMethod
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineTargetGroup.UpdateMethodUpdate  // 0x0
  public    static  Cinemachine.CinemachineTargetGroup.UpdateMethodFixedUpdate  // 0x0
  public    static  Cinemachine.CinemachineTargetGroup.UpdateMethodLateUpdate  // 0x0
METHODS:
END_CLASS

CLASS: CreatePipelineDelegate
TYPE:  class
TOKEN: 0x200003F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.Transform Invoke(Cinemachine.CinemachineVirtualCamera vcam, System.String name, Cinemachine.CinemachineComponentBase[] copyFrom)
END_CLASS

CLASS: DestroyPipelineDelegate
TYPE:  class
TOKEN: 0x2000040
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.GameObject pipeline)
END_CLASS

CLASS: FovCache
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            UnityEngine.Rect                mFovSoftGuideRect  // 0x10
  public            UnityEngine.Rect                mFovHardGuideRect  // 0x20
  public            System.Single                   mFovH  // 0x30
  public            System.Single                   mFov  // 0x34
  private           System.Single                   mOrthoSizeOverDistance  // 0x38
  private           System.Single                   mAspect  // 0x3C
  private           UnityEngine.Rect                mSoftGuideRect  // 0x40
  private           UnityEngine.Rect                mHardGuideRect  // 0x50
METHODS:
  System.Void UpdateCache(Cinemachine.LensSettings lens, UnityEngine.Rect softGuide, UnityEngine.Rect hardGuide, System.Single targetDistance)
  UnityEngine.Rect ScreenToFOV(UnityEngine.Rect rScreen, System.Single fov, System.Single fovH, System.Single aspect)
END_CLASS

CLASS: FramingMode
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineFramingTransposer.FramingModeHorizontal  // 0x0
  public    static  Cinemachine.CinemachineFramingTransposer.FramingModeVertical  // 0x0
  public    static  Cinemachine.CinemachineFramingTransposer.FramingModeHorizontalAndVertical  // 0x0
  public    static  Cinemachine.CinemachineFramingTransposer.FramingModeNone  // 0x0
METHODS:
END_CLASS

CLASS: AdjustmentMode
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineFramingTransposer.AdjustmentModeZoomOnly  // 0x0
  public    static  Cinemachine.CinemachineFramingTransposer.AdjustmentModeDollyOnly  // 0x0
  public    static  Cinemachine.CinemachineFramingTransposer.AdjustmentModeDollyThenZoom  // 0x0
METHODS:
END_CLASS

CLASS: FramingMode
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineGroupComposer.FramingModeHorizontal  // 0x0
  public    static  Cinemachine.CinemachineGroupComposer.FramingModeVertical  // 0x0
  public    static  Cinemachine.CinemachineGroupComposer.FramingModeHorizontalAndVertical  // 0x0
METHODS:
END_CLASS

CLASS: AdjustmentMode
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineGroupComposer.AdjustmentModeZoomOnly  // 0x0
  public    static  Cinemachine.CinemachineGroupComposer.AdjustmentModeDollyOnly  // 0x0
  public    static  Cinemachine.CinemachineGroupComposer.AdjustmentModeDollyThenZoom  // 0x0
METHODS:
END_CLASS

CLASS: HeadingDefinition
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinitionPositionDelta  // 0x0
  public    static  Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinitionVelocity  // 0x0
  public    static  Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinitionTargetForward  // 0x0
  public    static  Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinitionWorldForward  // 0x0
METHODS:
END_CLASS

CLASS: Heading
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public            Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinitionm_Definition  // 0x10
  public            System.Int32                    m_VelocityFilterStrength  // 0x14
  public            System.Single                   m_Bias  // 0x18
METHODS:
  System.Void .ctor(Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition def, System.Int32 filterStrength, System.Single bias)
END_CLASS

CLASS: UpdateHeadingDelegate
TYPE:  class
TOKEN: 0x2000051
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Single Invoke(Cinemachine.CinemachineOrbitalTransposer orbital, System.Single deltaTime, UnityEngine.Vector3 up)
END_CLASS

CLASS: RecenterTargetMode
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachinePOV.RecenterTargetModeNone  // 0x0
  public    static  Cinemachine.CinemachinePOV.RecenterTargetModeFollowTargetForward  // 0x0
  public    static  Cinemachine.CinemachinePOV.RecenterTargetModeLookAtTargetForward  // 0x0
METHODS:
END_CLASS

CLASS: CameraUpMode
TYPE:  struct
TOKEN: 0x2000057
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineTrackedDolly.CameraUpModeDefault  // 0x0
  public    static  Cinemachine.CinemachineTrackedDolly.CameraUpModePath  // 0x0
  public    static  Cinemachine.CinemachineTrackedDolly.CameraUpModePathNoRoll  // 0x0
  public    static  Cinemachine.CinemachineTrackedDolly.CameraUpModeFollowTarget  // 0x0
  public    static  Cinemachine.CinemachineTrackedDolly.CameraUpModeFollowTargetNoRoll  // 0x0
METHODS:
END_CLASS

CLASS: AutoDolly
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public            System.Boolean                  m_Enabled  // 0x10
  public            System.Single                   m_PositionOffset  // 0x14
  public            System.Int32                    m_SearchRadius  // 0x18
  public            System.Int32                    m_SearchResolution  // 0x1C
METHODS:
  System.Void .ctor(System.Boolean enabled, System.Single positionOffset, System.Int32 searchRadius, System.Int32 stepsPerSegment)
END_CLASS

CLASS: BindingMode
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineTransposer.BindingModeLockToTargetOnAssign  // 0x0
  public    static  Cinemachine.CinemachineTransposer.BindingModeLockToTargetWithWorldUp  // 0x0
  public    static  Cinemachine.CinemachineTransposer.BindingModeLockToTargetNoRoll  // 0x0
  public    static  Cinemachine.CinemachineTransposer.BindingModeLockToTarget  // 0x0
  public    static  Cinemachine.CinemachineTransposer.BindingModeWorldSpace  // 0x0
  public    static  Cinemachine.CinemachineTransposer.BindingModeSimpleFollowWithWorldUp  // 0x0
METHODS:
END_CLASS

CLASS: AngularDampingMode
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineTransposer.AngularDampingModeEuler  // 0x0
  public    static  Cinemachine.CinemachineTransposer.AngularDampingModeQuaternion  // 0x0
METHODS:
END_CLASS

CLASS: SpeedMode
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.AxisState.SpeedMode MaxSpeed  // 0x0
  public    static  Cinemachine.AxisState.SpeedMode InputValueGain  // 0x0
METHODS:
END_CLASS

CLASS: IInputAxisProvider
TYPE:  interface
TOKEN: 0x200005E
FIELDS:
METHODS:
  System.Single GetAxisValue(System.Int32 axis)
END_CLASS

CLASS: Recentering
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
  public            System.Boolean                  m_enabled  // 0x10
  public            System.Single                   m_WaitTime  // 0x14
  public            System.Single                   m_RecenteringTime  // 0x18
  private           System.Single                   mLastAxisInputTime  // 0x1C
  private           System.Single                   mRecenteringVelocity  // 0x20
  private           System.Int32                    m_LegacyHeadingDefinition  // 0x24
  private           System.Int32                    m_LegacyVelocityFilterStrength  // 0x28
METHODS:
  System.Void .ctor(System.Boolean enabled, System.Single waitTime, System.Single recenteringTime)
  System.Void Validate()
  System.Void CancelRecentering()
  System.Void DoRecentering(Cinemachine.AxisState& axis, System.Single deltaTime, System.Single recenterTarget)
  System.Boolean LegacyUpgrade(System.Int32& heading, System.Int32& velocityFilter)
END_CLASS

CLASS: HGDOFParams
TYPE:  struct
TOKEN: 0x2000061
FIELDS:
  public            System.Boolean                  enabledForVirtualCamera  // 0x10
  public            System.Boolean                  enable  // 0x11
  public            System.Single                   nearRadius  // 0x14
  public            System.Single                   nearFocusStart  // 0x18
  public            System.Single                   nearFocusEnd  // 0x1C
  public            System.Single                   farRadius  // 0x20
  public            System.Single                   farFocusStart  // 0x24
  public            System.Single                   farFocusEnd  // 0x28
  public            System.Single                   temporalFactor  // 0x2C
METHODS:
END_CLASS

CLASS: BlendHintValue
TYPE:  struct
TOKEN: 0x2000062
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CameraState.BlendHintValueNothing  // 0x0
  public    static  Cinemachine.CameraState.BlendHintValueNoPosition  // 0x0
  public    static  Cinemachine.CameraState.BlendHintValueNoOrientation  // 0x0
  public    static  Cinemachine.CameraState.BlendHintValueNoTransform  // 0x0
  public    static  Cinemachine.CameraState.BlendHintValueSphericalPositionBlend  // 0x0
  public    static  Cinemachine.CameraState.BlendHintValueCylindricalPositionBlend  // 0x0
  public    static  Cinemachine.CameraState.BlendHintValueRadialAimBlend  // 0x0
  public    static  Cinemachine.CameraState.BlendHintValueIgnoreLookAtTarget  // 0x0
  public    static  Cinemachine.CameraState.BlendHintValueNoLens  // 0x0
METHODS:
END_CLASS

CLASS: CustomBlendable
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  public            UnityEngine.Object              m_Custom  // 0x10
  public            System.Single                   m_Weight  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Object custom, System.Single weight)
END_CLASS

CLASS: Style
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineBlendDefinition.StyleCut  // 0x0
  public    static  Cinemachine.CinemachineBlendDefinition.StyleEaseInOut  // 0x0
  public    static  Cinemachine.CinemachineBlendDefinition.StyleEaseIn  // 0x0
  public    static  Cinemachine.CinemachineBlendDefinition.StyleEaseOut  // 0x0
  public    static  Cinemachine.CinemachineBlendDefinition.StyleHardIn  // 0x0
  public    static  Cinemachine.CinemachineBlendDefinition.StyleHardOut  // 0x0
  public    static  Cinemachine.CinemachineBlendDefinition.StyleLinear  // 0x0
  public    static  Cinemachine.CinemachineBlendDefinition.StyleCustom  // 0x0
METHODS:
END_CLASS

CLASS: CustomBlend
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            System.String                   m_From  // 0x10
  public            System.String                   m_To  // 0x18
  public            Cinemachine.CinemachineBlendDefinitionm_Blend  // 0x20
METHODS:
END_CLASS

CLASS: CustomBlendGroup
TYPE:  class
TOKEN: 0x200006B
FIELDS:
  public            System.Collections.Generic.List<System.String>cameras  // 0x10
  public            Cinemachine.CinemachineBlendDefinitionfromSameCamera  // 0x18
  public            Cinemachine.CinemachineBlendDefinitioninsideGroup  // 0x30
  public            Cinemachine.CinemachineBlendDefinitiontoGroup  // 0x48
  public            Cinemachine.CinemachineBlendDefinitionfromGroup  // 0x60
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Stage
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineCore.StageBody  // 0x0
  public    static  Cinemachine.CinemachineCore.StageAim  // 0x0
  public    static  Cinemachine.CinemachineCore.StageNoise  // 0x0
  public    static  Cinemachine.CinemachineCore.StageFinalize  // 0x0
METHODS:
END_CLASS

CLASS: AxisInputDelegate
TYPE:  class
TOKEN: 0x200006F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Single Invoke(System.String axisName)
END_CLASS

CLASS: GetBlendOverrideDelegate
TYPE:  class
TOKEN: 0x2000070
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Cinemachine.CinemachineBlendDefinition Invoke(Cinemachine.ICinemachineCamera fromVcam, Cinemachine.ICinemachineCamera toVcam, Cinemachine.CinemachineBlendDefinition defaultBlend, UnityEngine.MonoBehaviour owner)
END_CLASS

CLASS: UpdateStatus
TYPE:  class
TOKEN: 0x2000071
FIELDS:
  public            System.Int32                    lastUpdateFrame  // 0x10
  public            System.Int32                    lastUpdateFixedFrame  // 0x14
  public            Cinemachine.UpdateTracker.UpdateClocklastUpdateMode  // 0x18
  public            System.Single                   lastUpdateDeltaTime  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UpdateFilter
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineCore.UpdateFilterFixed  // 0x0
  public    static  Cinemachine.CinemachineCore.UpdateFilterLate  // 0x0
  public    static  Cinemachine.CinemachineCore.UpdateFilterSmart  // 0x0
  public    static  Cinemachine.CinemachineCore.UpdateFilterSmartFixed  // 0x0
  public    static  Cinemachine.CinemachineCore.UpdateFilterSmartLate  // 0x0
METHODS:
END_CLASS

CLASS: Appearance
TYPE:  class
TOKEN: 0x2000076
FIELDS:
  public            UnityEngine.Color               pathColor  // 0x10
  public            UnityEngine.Color               inactivePathColor  // 0x20
  public            System.Single                   width  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PositionUnits
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachinePathBase.PositionUnitsPathUnits  // 0x0
  public    static  Cinemachine.CinemachinePathBase.PositionUnitsDistance  // 0x0
  public    static  Cinemachine.CinemachinePathBase.PositionUnitsNormalized  // 0x0
METHODS:
END_CLASS

CLASS: Level
TYPE:  struct
TOKEN: 0x2000082
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.DocumentationSortingAttribute.LevelUndoc  // 0x0
  public    static  Cinemachine.DocumentationSortingAttribute.LevelAPI  // 0x0
  public    static  Cinemachine.DocumentationSortingAttribute.LevelUserRef  // 0x0
METHODS:
END_CLASS

CLASS: StandbyUpdateMode
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateModeNever  // 0x0
  public    static  Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateModeAlways  // 0x0
  public    static  Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateModeRoundRobin  // 0x0
METHODS:
END_CLASS

CLASS: BlendHint
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineVirtualCameraBase.BlendHintNone  // 0x0
  public    static  Cinemachine.CinemachineVirtualCameraBase.BlendHintSphericalPosition  // 0x0
  public    static  Cinemachine.CinemachineVirtualCameraBase.BlendHintCylindricalPosition  // 0x0
  public    static  Cinemachine.CinemachineVirtualCameraBase.BlendHintScreenSpaceAimWhenTargetsDiffer  // 0x0
METHODS:
END_CLASS

CLASS: TransitionParams
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  public            Cinemachine.CinemachineVirtualCameraBase.BlendHintm_BlendHint  // 0x10
  public            System.Boolean                  m_InheritPosition  // 0x14
  public            Cinemachine.CinemachineBrain.VcamActivatedEventm_OnCameraLive  // 0x18
METHODS:
END_CLASS

CLASS: BakedSolution
TYPE:  class
TOKEN: 0x2000089
FIELDS:
  private   readonly System.Single                   <FrustumHeight>k__BackingField  // 0x10
  private           System.Single                   m_frustumSizeIntSpace  // 0x14
  private   readonly Cinemachine.ConfinerOven.AspectStretcherm_AspectStretcher  // 0x18
  private   readonly System.Boolean                  m_HasBones  // 0x24
  private   readonly System.Double                   m_SqrPolygonDiagonal  // 0x28
  private           System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>m_OriginalPolygon  // 0x30
  public            System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>m_Solution  // 0x38
METHODS:
  System.Single get_FrustumHeight()
  System.Void .ctor(System.Single aspectRatio, System.Single frustumHeight, System.Boolean hasBones, UnityEngine.Rect polygonBounds, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> originalPolygon, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>> solution)
  System.Boolean IsValid(System.Single frustumHeight)
  UnityEngine.Vector2 ConfinePoint(UnityEngine.Vector2& pointToConfine)
  System.Boolean IsInsideOriginal(ClipperLib.IntPoint p)
  System.Single ClosestPointOnSegment(ClipperLib.IntPoint p, ClipperLib.IntPoint s0, ClipperLib.IntPoint s1)
  ClipperLib.IntPoint IntPointLerp(ClipperLib.IntPoint a, ClipperLib.IntPoint b, System.Single lerp)
  System.Boolean DoesIntersectOriginal(ClipperLib.IntPoint l1, ClipperLib.IntPoint l2)
  System.Int32 FindIntersection(ClipperLib.IntPoint& p1, ClipperLib.IntPoint& p2, ClipperLib.IntPoint& p3, ClipperLib.IntPoint& p4)
  System.Double IntPointDiffSqrMagnitude(ClipperLib.IntPoint p1, ClipperLib.IntPoint p2)
END_CLASS

CLASS: AspectStretcher
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  private   readonly System.Single                   <Aspect>k__BackingField  // 0x10
  private   readonly System.Single                   m_InverseAspect  // 0x14
  private   readonly System.Single                   m_CenterX  // 0x18
METHODS:
  System.Single get_Aspect()
  System.Void .ctor(System.Single aspect, System.Single centerX)
  UnityEngine.Vector2 Stretch(UnityEngine.Vector2 p)
  UnityEngine.Vector2 Unstretch(UnityEngine.Vector2 p)
END_CLASS

CLASS: PolygonSolution
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>m_Polygons  // 0x10
  public            System.Single                   m_FrustumHeight  // 0x18
METHODS:
  System.Boolean StateChanged(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>& paths)
  System.Boolean get_IsEmpty()
END_CLASS

CLASS: BakingState
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.ConfinerOven.BakingStateBAKING  // 0x0
  public    static  Cinemachine.ConfinerOven.BakingStateBAKED  // 0x0
  public    static  Cinemachine.ConfinerOven.BakingStateTIMEOUT  // 0x0
METHODS:
END_CLASS

CLASS: BakingStateCache
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            ClipperLib.ClipperOffset        offsetter  // 0x10
  public            System.Collections.Generic.List<Cinemachine.ConfinerOven.PolygonSolution>solutions  // 0x18
  public            Cinemachine.ConfinerOven.PolygonSolutionrightCandidate  // 0x20
  public            Cinemachine.ConfinerOven.PolygonSolutionleftCandidate  // 0x30
  public            System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>maxCandidate  // 0x40
  public            System.Single                   stepSize  // 0x48
  public            System.Single                   maxFrustumHeight  // 0x4C
  public            System.Single                   currentFrustumHeight  // 0x50
  public            System.Single                   bakeTime  // 0x54
METHODS:
END_CLASS

CLASS: OverrideModes
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.LensSettings.OverrideModesNone  // 0x0
  public    static  Cinemachine.LensSettings.OverrideModesOrthographic  // 0x0
  public    static  Cinemachine.LensSettings.OverrideModesPerspective  // 0x0
  public    static  Cinemachine.LensSettings.OverrideModesPhysical  // 0x0
METHODS:
END_CLASS

CLASS: NoiseParams
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
  public            System.Single                   Frequency  // 0x10
  public            System.Single                   Amplitude  // 0x14
  public            System.Boolean                  Constant  // 0x18
METHODS:
  System.Single GetValueAt(System.Single time, System.Single timeOffset)
END_CLASS

CLASS: TransformNoiseParams
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  public            Cinemachine.NoiseSettings.NoiseParamsX  // 0x10
  public            Cinemachine.NoiseSettings.NoiseParamsY  // 0x1C
  public            Cinemachine.NoiseSettings.NoiseParamsZ  // 0x28
METHODS:
  UnityEngine.Vector3 GetValueAt(System.Single time, UnityEngine.Vector3 timeOffsets)
END_CLASS

CLASS: OverlapSphereNonAllocDelegate
TYPE:  class
TOKEN: 0x2000095
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(UnityEngine.Vector3 position, System.Single radius, UnityEngine.ECSColliderResultProxy[] results, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
END_CLASS

CLASS: RaycastDelegate
TYPE:  class
TOKEN: 0x2000096
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
END_CLASS

CLASS: RaycastNonAllocDelegate
TYPE:  class
TOKEN: 0x2000097
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
END_CLASS

CLASS: SphereCastNonAllocDelegate
TYPE:  class
TOKEN: 0x2000098
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(UnityEngine.Vector3 origin, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
END_CLASS

CLASS: ComputePenetrationDelegate
TYPE:  class
TOKEN: 0x2000099
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.ECSColliderResultProxy colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.ECSColliderResultProxy colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, UnityEngine.Vector3& direction, System.Single& distance)
END_CLASS

CLASS: Mode
TYPE:  struct
TOKEN: 0x200009D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.TargetPositionCache.ModeDisabled  // 0x0
  public    static  Cinemachine.TargetPositionCache.ModeRecord  // 0x0
  public    static  Cinemachine.TargetPositionCache.ModePlayback  // 0x0
METHODS:
END_CLASS

CLASS: Item
TYPE:  struct
TOKEN: 0x200009F
FIELDS:
  public            UnityEngine.Vector3             Pos  // 0x10
  public            UnityEngine.Quaternion          Rot  // 0x1C
METHODS:
  Cinemachine.TargetPositionCache.CacheCurve.Item Lerp(Cinemachine.TargetPositionCache.CacheCurve.Item a, Cinemachine.TargetPositionCache.CacheCurve.Item b, System.Single t)
  Cinemachine.TargetPositionCache.CacheCurve.Item get_Empty()
END_CLASS

CLASS: CacheCurve
TYPE:  class
TOKEN: 0x200009E
FIELDS:
  public            System.Single                   StartTime  // 0x10
  public            System.Single                   StepSize  // 0x14
  private           System.Collections.Generic.List<Cinemachine.TargetPositionCache.CacheCurve.Item>m_Cache  // 0x18
METHODS:
  Cinemachine.TargetPositionCache.CacheCurve.Item Evaluate(System.Single time)
END_CLASS

CLASS: RecordingItem
TYPE:  struct
TOKEN: 0x20000A1
FIELDS:
  public            System.Single                   Time  // 0x10
  public            System.Boolean                  IsCut  // 0x14
  public            Cinemachine.TargetPositionCache.CacheCurve.ItemItem  // 0x18
METHODS:
END_CLASS

CLASS: CacheEntry
TYPE:  class
TOKEN: 0x20000A0
FIELDS:
  public            Cinemachine.TargetPositionCache.CacheCurveCurve  // 0x10
  private           System.Collections.Generic.List<Cinemachine.TargetPositionCache.CacheEntry.RecordingItem>RawItems  // 0x18
METHODS:
  System.Void AddRawItem(System.Single time, System.Boolean isCut, UnityEngine.Transform target)
  System.Void .ctor()
END_CLASS

CLASS: TimeRange
TYPE:  struct
TOKEN: 0x20000A2
FIELDS:
  public            System.Single                   Start  // 0x10
  public            System.Single                   End  // 0x14
METHODS:
  System.Boolean get_IsEmpty()
  System.Boolean Contains(System.Single time)
  Cinemachine.TargetPositionCache.TimeRange get_Empty()
  System.Void Include(System.Single time)
END_CLASS

CLASS: UpdateClock
TYPE:  struct
TOKEN: 0x20000A4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.UpdateTracker.UpdateClockFixed  // 0x0
  public    static  Cinemachine.UpdateTracker.UpdateClockLate  // 0x0
METHODS:
END_CLASS

CLASS: UpdateStatus
TYPE:  class
TOKEN: 0x20000A5
FIELDS:
  private           System.Int32                    windowStart  // 0x10
  private           System.Int32                    numWindowLateUpdateMoves  // 0x14
  private           System.Int32                    numWindowFixedUpdateMoves  // 0x18
  private           System.Int32                    numWindows  // 0x1C
  private           System.Int32                    lastFrameUpdated  // 0x20
  private           UnityEngine.Matrix4x4           lastPos  // 0x24
  private           Cinemachine.UpdateTracker.UpdateClock<PreferredUpdate>k__BackingField  // 0x64
METHODS:
  Cinemachine.UpdateTracker.UpdateClock get_PreferredUpdate()
  System.Void set_PreferredUpdate(Cinemachine.UpdateTracker.UpdateClock value)
  System.Void .ctor(System.Int32 currentFrame, UnityEngine.Matrix4x4 pos)
  System.Void OnUpdate(System.Int32 currentFrame, Cinemachine.UpdateTracker.UpdateClock currentClock, UnityEngine.Matrix4x4 pos)
END_CLASS

CLASS: Mode
TYPE:  struct
TOKEN: 0x20000AA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.ModeCustom  // 0x0
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.ModePriorityBoost  // 0x0
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.ModeActivate  // 0x0
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.ModeDeactivate  // 0x0
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.ModeEnable  // 0x0
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.ModeDisable  // 0x0
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.ModePlay  // 0x0
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.ModeStop  // 0x0
METHODS:
END_CLASS

CLASS: TriggerEvent
TYPE:  class
TOKEN: 0x20000AB
EXTENDS: UnityEvent
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TimeMode
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.TimeModeFromStart  // 0x0
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.TimeModeFromEnd  // 0x0
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.TimeModeBeforeNow  // 0x0
  public    static  Cinemachine.CinemachineTriggerAction.ActionSettings.TimeModeAfterNow  // 0x0
METHODS:
END_CLASS

CLASS: ActionSettings
TYPE:  struct
TOKEN: 0x20000A9
FIELDS:
  public            Cinemachine.CinemachineTriggerAction.ActionSettings.Modem_Action  // 0x10
  public            UnityEngine.Object              m_Target  // 0x18
  public            System.Int32                    m_BoostAmount  // 0x20
  public            System.Single                   m_StartTime  // 0x24
  public            Cinemachine.CinemachineTriggerAction.ActionSettings.TimeModem_Mode  // 0x28
  public            Cinemachine.CinemachineTriggerAction.ActionSettings.TriggerEventm_Event  // 0x30
METHODS:
  System.Void .ctor(Cinemachine.CinemachineTriggerAction.ActionSettings.Mode action)
  System.Void Invoke()
END_CLASS

CLASS: ImpulseShapes
TYPE:  struct
TOKEN: 0x20000B1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineImpulseDefinition.ImpulseShapesCustom  // 0x0
  public    static  Cinemachine.CinemachineImpulseDefinition.ImpulseShapesRecoil  // 0x0
  public    static  Cinemachine.CinemachineImpulseDefinition.ImpulseShapesBump  // 0x0
  public    static  Cinemachine.CinemachineImpulseDefinition.ImpulseShapesExplosion  // 0x0
  public    static  Cinemachine.CinemachineImpulseDefinition.ImpulseShapesRumble  // 0x0
METHODS:
END_CLASS

CLASS: ImpulseTypes
TYPE:  struct
TOKEN: 0x20000B2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineImpulseDefinition.ImpulseTypesUniform  // 0x0
  public    static  Cinemachine.CinemachineImpulseDefinition.ImpulseTypesDissipating  // 0x0
  public    static  Cinemachine.CinemachineImpulseDefinition.ImpulseTypesPropagating  // 0x0
  public    static  Cinemachine.CinemachineImpulseDefinition.ImpulseTypesLegacy  // 0x0
METHODS:
END_CLASS

CLASS: RepeatMode
TYPE:  struct
TOKEN: 0x20000B3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineImpulseDefinition.RepeatModeStretch  // 0x0
  public    static  Cinemachine.CinemachineImpulseDefinition.RepeatModeLoop  // 0x0
METHODS:
END_CLASS

CLASS: SignalSource
TYPE:  class
TOKEN: 0x20000B4
FIELDS:
  private           Cinemachine.CinemachineImpulseDefinitionm_Def  // 0x10
  private           UnityEngine.Vector3             m_Velocity  // 0x18
METHODS:
  System.Void .ctor(Cinemachine.CinemachineImpulseDefinition def, UnityEngine.Vector3 velocity)
  System.Single get_SignalDuration()
  System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
END_CLASS

CLASS: LegacySignalSource
TYPE:  class
TOKEN: 0x20000B5
FIELDS:
  private           Cinemachine.CinemachineImpulseDefinitionm_Def  // 0x10
  private           UnityEngine.Vector3             m_Velocity  // 0x18
  private           System.Single                   m_StartTimeOffset  // 0x24
METHODS:
  System.Void .ctor(Cinemachine.CinemachineImpulseDefinition def, UnityEngine.Vector3 velocity)
  System.Single get_SignalDuration()
  System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
END_CLASS

CLASS: ImpulseReaction
TYPE:  struct
TOKEN: 0x20000B7
FIELDS:
  public            Cinemachine.NoiseSettings       m_SecondaryNoise  // 0x10
  public            System.Single                   m_AmplitudeGain  // 0x18
  public            System.Single                   m_FrequencyGain  // 0x1C
  public            System.Single                   m_Duration  // 0x20
  private           System.Single                   m_CurrentAmount  // 0x24
  private           System.Single                   m_CurrentTime  // 0x28
  private           System.Single                   m_CurrentDamping  // 0x2C
  private           System.Boolean                  m_Initialized  // 0x30
  private           UnityEngine.Vector3             m_NoiseOffsets  // 0x34
METHODS:
  System.Void ReSeed()
  System.Boolean GetReaction(System.Single deltaTime, UnityEngine.Vector3 impulsePos, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
END_CLASS

CLASS: EnvelopeDefinition
TYPE:  struct
TOKEN: 0x20000BA
FIELDS:
  public            UnityEngine.AnimationCurve      m_AttackShape  // 0x10
  public            UnityEngine.AnimationCurve      m_DecayShape  // 0x18
  public            System.Single                   m_AttackTime  // 0x20
  public            System.Single                   m_SustainTime  // 0x24
  public            System.Single                   m_DecayTime  // 0x28
  public            System.Boolean                  m_ScaleWithImpact  // 0x2C
  public            System.Boolean                  m_HoldForever  // 0x2D
METHODS:
  Cinemachine.CinemachineImpulseManager.EnvelopeDefinition Default()
  System.Single get_Duration()
  System.Single GetValueAt(System.Single offset)
  System.Void ChangeStopTime(System.Single offset, System.Boolean forceNoDecay)
  System.Void Clear()
  System.Void Validate()
END_CLASS

CLASS: DirectionMode
TYPE:  struct
TOKEN: 0x20000BC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionModeFixed  // 0x0
  public    static  Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionModeRotateTowardSource  // 0x0
METHODS:
END_CLASS

CLASS: DissipationMode
TYPE:  struct
TOKEN: 0x20000BD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationModeLinearDecay  // 0x0
  public    static  Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationModeSoftDecay  // 0x0
  public    static  Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationModeExponentialDecay  // 0x0
METHODS:
END_CLASS

CLASS: ImpulseEvent
TYPE:  class
TOKEN: 0x20000BB
FIELDS:
  public            System.Single                   m_StartTime  // 0x10
  public            Cinemachine.CinemachineImpulseManager.EnvelopeDefinitionm_Envelope  // 0x18
  public            Cinemachine.ISignalSource6D     m_SignalSource  // 0x38
  public            UnityEngine.Vector3             m_Position  // 0x40
  public            System.Single                   m_Radius  // 0x4C
  public            Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionModem_DirectionMode  // 0x50
  public            System.Int32                    m_Channel  // 0x54
  public            Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationModem_DissipationMode  // 0x58
  public            System.Single                   m_DissipationDistance  // 0x5C
  public            System.Single                   m_CustomDissipation  // 0x60
  public            System.Single                   m_PropagationSpeed  // 0x64
  public            System.Boolean                  m_IgnoreDistance  // 0x68
METHODS:
  System.Boolean get_Expired()
  System.Void Cancel(System.Single time, System.Boolean forceNoDecay)
  System.Single DistanceDecay(System.Single distance)
  System.Boolean GetDecayedSignal(UnityEngine.Vector3 listenerPosition, System.Boolean use2D, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
  System.Void Clear()
  System.Void .ctor()
END_CLASS

CLASS: OnGUIDelegate
TYPE:  class
TOKEN: 0x20000C3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: Item
TYPE:  struct
TOKEN: 0x20000C7
FIELDS:
  public            UnityEngine.Vector3             velocity  // 0x10
  public            System.Single                   weight  // 0x1C
  public            System.Single                   time  // 0x20
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=12
TYPE:  struct
TOKEN: 0x20000CC
FIELDS:
METHODS:
END_CLASS

CLASS: Cinemachine.Cinemachine3rdPersonAim
TYPE:  class
TOKEN: 0x200000A
EXTENDS: CinemachineExtension
FIELDS:
  public            UnityEngine.LayerMask           AimCollisionFilter  // 0x28
  public            System.String                   IgnoreTag  // 0x30
  public            System.Single                   AimDistance  // 0x38
  public            UnityEngine.RectTransform       AimTargetReticle  // 0x40
  private           UnityEngine.Vector3             <AimTarget>k__BackingField  // 0x48
METHODS:
  UnityEngine.Vector3 get_AimTarget()
  System.Void set_AimTarget(UnityEngine.Vector3 value)
  System.Void OnValidate()
  System.Void Reset()
  System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void DrawReticle(Cinemachine.CinemachineBrain brain)
  UnityEngine.Vector3 ComputeLookAtPoint(UnityEngine.Vector3 camPos, UnityEngine.Transform player)
  UnityEngine.Vector3 ComputeAimTarget(UnityEngine.Vector3 cameraLookAt, UnityEngine.Transform player)
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineBlendListCamera
TYPE:  class
TOKEN: 0x200000B
EXTENDS: CinemachineVirtualCameraBase
FIELDS:
  public            UnityEngine.Transform           m_LookAt  // 0xA8
  public            UnityEngine.Transform           m_Follow  // 0xB0
  public            System.Boolean                  m_ShowDebugText  // 0xB8
  public            System.Boolean                  m_Loop  // 0xB9
  private           Cinemachine.CinemachineVirtualCameraBase[]m_ChildCameras  // 0xC0
  public            Cinemachine.CinemachineBlendListCamera.Instruction[]m_Instructions  // 0xC8
  private           Cinemachine.ICinemachineCamera  <LiveChild>k__BackingField  // 0xD0
  private           Cinemachine.ICinemachineCamera  m_TransitioningFrom  // 0xD8
  private           Cinemachine.CameraState         m_State  // 0xE0
  private           System.Single                   mActivationTime  // 0x1F0
  private           System.Int32                    mCurrentInstruction  // 0x1F4
  private           Cinemachine.CinemachineBlend    mActiveBlend  // 0x1F8
METHODS:
  System.String get_Description()
  System.Void Reset()
  Cinemachine.ICinemachineCamera get_LiveChild()
  System.Void set_LiveChild(Cinemachine.ICinemachineCamera value)
  System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly)
  Cinemachine.CameraState get_State()
  UnityEngine.Transform get_LookAt()
  System.Void set_LookAt(UnityEngine.Transform value)
  UnityEngine.Transform get_Follow()
  System.Void set_Follow(UnityEngine.Transform value)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnTransformChildrenChanged()
  System.Void OnGuiHandler()
  Cinemachine.CinemachineVirtualCameraBase[] get_ChildCameras()
  System.Boolean get_IsBlending()
  System.Void InvalidateListOfChildren()
  System.Void UpdateListOfChildren()
  System.Void ValidateInstructions()
  System.Void AdvanceCurrentInstruction(System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineBrain
TYPE:  class
TOKEN: 0x200000D
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  m_ShowDebugText  // 0x18
  public            System.Boolean                  m_ShowCameraFrustum  // 0x19
  public            System.Boolean                  m_IgnoreTimeScale  // 0x1A
  public            UnityEngine.Transform           m_WorldUpOverride  // 0x20
  public            Cinemachine.CinemachineBrain.UpdateMethodm_UpdateMethod  // 0x28
  public            Cinemachine.CinemachineBrain.BrainUpdateMethodm_BlendUpdateMethod  // 0x2C
  public            Cinemachine.CinemachineBlendDefinitionm_DefaultBlend  // 0x30
  public            Cinemachine.CinemachineBlenderSettingsm_CustomBlends  // 0x48
  private           UnityEngine.Camera              m_OutputCamera  // 0x50
  private           HG.Rendering.Runtime.HGDepthOfFieldm_OutputDOF  // 0x58
  public            Cinemachine.CinemachineBrain.BrainEventm_CameraCutEvent  // 0x60
  public            Cinemachine.CinemachineBrain.VcamActivatedEventm_CameraActivatedEvent  // 0x68
  private   static  Cinemachine.ICinemachineCamera  mSoloCamera  // 0x0
  private           UnityEngine.Coroutine           mPhysicsCoroutine  // 0x70
  private           System.Int32                    m_LastFrameUpdated  // 0x78
  private           UnityEngine.WaitForFixedUpdate  mWaitForFixedUpdate  // 0x80
  private           System.Collections.Generic.List<Cinemachine.CinemachineBrain.BrainFrame>mFrameStack  // 0x88
  private           System.Int32                    mNextFrameId  // 0x90
  private           Cinemachine.CinemachineBlend    mCurrentLiveCameras  // 0x98
  private   static readonly UnityEngine.AnimationCurve      mDefaultLinearAnimationCurve  // 0x8
  private           Cinemachine.ICinemachineCamera  mActiveCameraPreviousFrame  // 0xA0
  private           UnityEngine.GameObject          mActiveCameraPreviousFrameGameObject  // 0xA8
  private           Cinemachine.CameraState         <CurrentCameraState>k__BackingField  // 0xB0
METHODS:
  UnityEngine.Camera get_OutputCamera()
  HG.Rendering.Runtime.HGDepthOfField get_OutputDOF()
  Cinemachine.ICinemachineCamera get_SoloCamera()
  System.Void set_SoloCamera(Cinemachine.ICinemachineCamera value)
  UnityEngine.Color GetSoloGUIColor()
  UnityEngine.Vector3 get_DefaultWorldUp()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
  System.Void OnSceneUnloaded(UnityEngine.SceneManagement.Scene scene)
  System.Void Start()
  System.Void OnGuiHandler()
  System.Collections.IEnumerator AfterPhysics()
  System.Void LateUpdate()
  System.Void ManualUpdate(System.Single deltaTime)
  System.Single GetEffectiveDeltaTime(System.Boolean fixedDelta)
  System.Void UpdateVirtualCameras(Cinemachine.CinemachineCore.UpdateFilter updateFilter, System.Single deltaTime)
  Cinemachine.ICinemachineCamera get_ActiveVirtualCamera()
  Cinemachine.ICinemachineCamera DeepCamBFromBlend(Cinemachine.CinemachineBlend blend)
  System.Boolean IsLiveInBlend(Cinemachine.ICinemachineCamera vcam)
  System.Boolean get_IsBlending()
  Cinemachine.CinemachineBlend get_ActiveBlend()
  System.Int32 GetBrainFrame(System.Int32 withId)
  System.Int32 SetCameraOverride(System.Int32 overrideId, Cinemachine.ICinemachineCamera camA, Cinemachine.ICinemachineCamera camB, System.Single weightB, System.Single deltaTime)
  System.Void ReleaseCameraOverride(System.Int32 overrideId)
  System.Void ProcessActiveCamera(System.Single deltaTime)
  System.Void UpdateFrame0(System.Single deltaTime)
  System.Void ComputeCurrentBlend(Cinemachine.CinemachineBlend& outputBlend, System.Int32 numTopLayersToExclude)
  System.Boolean IsLive(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly)
  Cinemachine.CameraState get_CurrentCameraState()
  System.Void set_CurrentCameraState(Cinemachine.CameraState value)
  Cinemachine.ICinemachineCamera TopCameraFromPriorityQueue()
  Cinemachine.CinemachineBlendDefinition LookupBlend(Cinemachine.ICinemachineCamera fromKey, Cinemachine.ICinemachineCamera toKey)
  System.Void PushStateToUnityCamera(Cinemachine.CameraState& state)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Cinemachine.CinemachineClearShot
TYPE:  class
TOKEN: 0x2000014
EXTENDS: CinemachineVirtualCameraBase
FIELDS:
  public            UnityEngine.Transform           m_LookAt  // 0xA8
  public            UnityEngine.Transform           m_Follow  // 0xB0
  public            System.Boolean                  m_ShowDebugText  // 0xB8
  private           Cinemachine.CinemachineVirtualCameraBase[]m_ChildCameras  // 0xC0
  public            System.Single                   m_ActivateAfter  // 0xC8
  public            System.Single                   m_MinDuration  // 0xCC
  public            System.Boolean                  m_RandomizeChoice  // 0xD0
  public            Cinemachine.CinemachineBlendDefinitionm_DefaultBlend  // 0xD8
  public            Cinemachine.CinemachineBlenderSettingsm_CustomBlends  // 0xF0
  private           Cinemachine.ICinemachineCamera  <LiveChild>k__BackingField  // 0xF8
  private           Cinemachine.CameraState         m_State  // 0x100
  private           System.Single                   mActivationTime  // 0x210
  private           System.Single                   mPendingActivationTime  // 0x214
  private           Cinemachine.ICinemachineCamera  mPendingCamera  // 0x218
  private           Cinemachine.CinemachineBlend    mActiveBlend  // 0x220
  private           System.Boolean                  mRandomizeNow  // 0x228
  private           Cinemachine.CinemachineVirtualCameraBase[]m_RandomizedChilden  // 0x230
  private           Cinemachine.ICinemachineCamera  m_TransitioningFrom  // 0x238
METHODS:
  System.String get_Description()
  Cinemachine.ICinemachineCamera get_LiveChild()
  System.Void set_LiveChild(Cinemachine.ICinemachineCamera value)
  Cinemachine.CameraState get_State()
  System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly)
  UnityEngine.Transform get_LookAt()
  System.Void set_LookAt(UnityEngine.Transform value)
  UnityEngine.Transform get_Follow()
  System.Void set_Follow(UnityEngine.Transform value)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnTransformChildrenChanged()
  System.Void OnGuiHandler()
  System.Boolean get_IsBlending()
  Cinemachine.CinemachineVirtualCameraBase[] get_ChildCameras()
  System.Void InvalidateListOfChildren()
  System.Void ResetRandomization()
  System.Void UpdateListOfChildren()
  Cinemachine.ICinemachineCamera ChooseCurrentCamera(UnityEngine.Vector3 worldUp)
  Cinemachine.CinemachineVirtualCameraBase[] Randomize(Cinemachine.CinemachineVirtualCameraBase[] src)
  Cinemachine.CinemachineBlendDefinition LookupBlend(Cinemachine.ICinemachineCamera fromKey, Cinemachine.ICinemachineCamera toKey)
  System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineCollider
TYPE:  class
TOKEN: 0x2000017
EXTENDS: CinemachineExtension
FIELDS:
  public            UnityEngine.LayerMask           m_CollideAgainst  // 0x28
  public            System.String                   m_IgnoreTag  // 0x30
  public            UnityEngine.LayerMask           m_TransparentLayers  // 0x38
  public            System.Single                   m_MinimumDistanceFromTarget  // 0x3C
  public            System.Boolean                  m_AvoidObstacles  // 0x40
  public            System.Single                   m_DistanceLimit  // 0x44
  public            System.Single                   m_MinimumOcclusionTime  // 0x48
  public            System.Single                   m_CameraRadius  // 0x4C
  public            Cinemachine.CinemachineCollider.ResolutionStrategym_Strategy  // 0x50
  public            System.Boolean                  m_UseFollowInsteadOfLookAt  // 0x54
  public            System.Int32                    m_MaximumEffort  // 0x58
  public            System.Single                   m_SmoothingTime  // 0x5C
  public            System.Single                   m_Damping  // 0x60
  public            System.Single                   m_DampingWhenOccluded  // 0x64
  public            System.Single                   m_OptimalTargetDistance  // 0x68
  private   static  System.Single                   k_PrecisionSlush  // 0x0
  private           UnityEngine.RaycastHit[]        m_CornerBuffer  // 0x70
  private   static  System.Single                   k_AngleThreshold  // 0x0
  private   static  UnityEngine.ECSColliderResultProxy[]s_ColliderBuffer  // 0x0
METHODS:
  System.Boolean IsTargetObscured(Cinemachine.ICinemachineCamera vcam)
  System.Boolean CameraWasDisplaced(Cinemachine.ICinemachineCamera vcam)
  System.Single GetCameraDisplacementDistance(Cinemachine.ICinemachineCamera vcam)
  System.Void OnValidate()
  System.Void OnDestroy()
  System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> get_DebugPaths()
  System.Single GetMaxDampTime()
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void ResetExtraData(Cinemachine.ICinemachineCamera vcam)
  System.Void GuardedPostPipelineStageCallback(Cinemachine.ICinemachineCamera vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  UnityEngine.Vector3 PreserveLineOfSight(Cinemachine.CameraState& state, Cinemachine.CinemachineCollider.VcamExtraState& extra)
  UnityEngine.Vector3 PullCameraInFrontOfNearestObstacle(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos, System.Int32 layerMask, UnityEngine.RaycastHit& hitInfo)
  UnityEngine.Vector3 PushCameraBack(UnityEngine.Vector3 currentPos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, UnityEngine.Vector3 lookAtPos, UnityEngine.Plane startPlane, System.Single targetDistance, System.Int32 iterations, Cinemachine.CinemachineCollider.VcamExtraState& extra)
  System.Boolean GetWalkingDirection(UnityEngine.Vector3 pos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, UnityEngine.Vector3& outDir)
  System.Single GetPushBackDistance(UnityEngine.Ray ray, UnityEngine.Plane startPlane, System.Single targetDistance, UnityEngine.Vector3 lookAtPos)
  System.Single ClampRayToBounds(UnityEngine.Ray ray, System.Single distance, UnityEngine.Bounds bounds)
  UnityEngine.Vector3 RespectCameraRadius(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos)
  System.Boolean CheckForTargetObstructions(Cinemachine.CameraState& state)
  System.Boolean IsTargetOffscreen(Cinemachine.CameraState& state)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Cinemachine.CinemachineConfiner
TYPE:  class
TOKEN: 0x200001A
EXTENDS: CinemachineExtension
FIELDS:
  public            Cinemachine.CinemachineConfiner.Modem_ConfineMode  // 0x28
  public            UnityEngine.Collider            m_BoundingVolume  // 0x30
  public            UnityEngine.Collider2D          m_BoundingShape2D  // 0x38
  private           UnityEngine.Collider2D          m_BoundingShape2DCache  // 0x40
  public            System.Boolean                  m_ConfineScreenEdges  // 0x48
  public            System.Single                   m_Damping  // 0x4C
  private           System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>m_pathCache  // 0x50
  private           System.Int32                    m_pathTotalPointCount  // 0x58
METHODS:
  System.Boolean CameraWasDisplaced(Cinemachine.CinemachineVirtualCameraBase vcam)
  System.Single GetCameraDisplacementDistance(Cinemachine.CinemachineVirtualCameraBase vcam)
  System.Void OnValidate()
  System.Void ConnectToVcam(System.Boolean connect)
  System.Boolean get_IsValid()
  System.Single GetMaxDampTime()
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void InvalidatePathCache()
  System.Boolean ValidatePathCache()
  UnityEngine.Vector3 ConfinePoint(UnityEngine.Vector3 camPos)
  UnityEngine.Vector3 ConfineScreenEdges(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& state)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineConfiner2D
TYPE:  class
TOKEN: 0x200001D
EXTENDS: CinemachineExtension
FIELDS:
  public            UnityEngine.Collider2D          m_BoundingShape2D  // 0x28
  public            System.Single                   m_Damping  // 0x30
  public            System.Single                   m_MaxWindowSize  // 0x34
  private           System.Single                   m_MaxComputationTimePerFrameInSeconds  // 0x38
  private   static  System.Single                   k_cornerAngleTreshold  // 0x0
  private           Cinemachine.CinemachineConfiner2D.ShapeCachem_shapeCache  // 0x40
METHODS:
  System.Void InvalidateCache()
  System.Boolean ValidateCache(System.Single cameraAspectRatio)
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Single CalculateHalfFrustumHeight(Cinemachine.CameraState& state, System.Single& cameraPosLocalZ)
  System.Void OnValidate()
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineDollyCart
TYPE:  class
TOKEN: 0x2000020
EXTENDS: MonoBehaviour
FIELDS:
  public            Cinemachine.CinemachinePathBase m_Path  // 0x18
  public            System.Boolean                  forbidRotation  // 0x20
  public            Cinemachine.CinemachineDollyCart.UpdateMethodm_UpdateMethod  // 0x24
  public            Cinemachine.CinemachinePathBase.PositionUnitsm_PositionUnits  // 0x28
  public            System.Single                   m_Speed  // 0x2C
  public            System.Single                   m_Position  // 0x30
METHODS:
  System.Void FixedUpdate()
  System.Void Update()
  System.Void LateUpdate()
  System.Void SetCartPosition(System.Single distanceAlongPath)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineExternalCamera
TYPE:  class
TOKEN: 0x2000022
EXTENDS: CinemachineVirtualCameraBase
FIELDS:
  public            UnityEngine.Transform           m_LookAt  // 0xA8
  private           UnityEngine.Camera              m_Camera  // 0xB0
  private           Cinemachine.CameraState         m_State  // 0xB8
  private           UnityEngine.Transform           <Follow>k__BackingField  // 0x1C8
  public            Cinemachine.CinemachineVirtualCameraBase.BlendHintm_BlendHint  // 0x1D0
METHODS:
  Cinemachine.CameraState get_State()
  UnityEngine.Transform get_LookAt()
  System.Void set_LookAt(UnityEngine.Transform value)
  UnityEngine.Transform get_Follow()
  System.Void set_Follow(UnityEngine.Transform value)
  System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineFollowZoom
TYPE:  class
TOKEN: 0x2000023
EXTENDS: CinemachineExtension
FIELDS:
  public            System.Single                   m_Width  // 0x28
  public            System.Single                   m_Damping  // 0x2C
  public            System.Single                   m_MinFOV  // 0x30
  public            System.Single                   m_MaxFOV  // 0x34
METHODS:
  System.Void OnValidate()
  System.Single GetMaxDampTime()
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineFreeLook
TYPE:  class
TOKEN: 0x2000025
EXTENDS: CinemachineVirtualCameraBase
FIELDS:
  public            UnityEngine.Transform           m_LookAt  // 0xA8
  public            UnityEngine.Transform           m_Follow  // 0xB0
  public            System.Boolean                  m_CommonLens  // 0xB8
  public            Cinemachine.LensSettings        m_Lens  // 0xBC
  public            Cinemachine.CinemachineVirtualCameraBase.TransitionParamsm_Transitions  // 0xF0
  private           Cinemachine.CinemachineVirtualCameraBase.BlendHintm_LegacyBlendHint  // 0x100
  public            Cinemachine.AxisState           m_YAxis  // 0x108
  public            Cinemachine.AxisState.Recenteringm_YAxisRecentering  // 0x178
  public            Cinemachine.AxisState           m_XAxis  // 0x198
  public            Cinemachine.CinemachineOrbitalTransposer.Headingm_Heading  // 0x208
  public            Cinemachine.AxisState.Recenteringm_RecenterToTargetHeading  // 0x214
  public            Cinemachine.CinemachineTransposer.BindingModem_BindingMode  // 0x230
  public            System.Single                   m_SplineCurvature  // 0x234
  public            Cinemachine.CinemachineFreeLook.Orbit[]m_Orbits  // 0x238
  private           System.Single                   m_LegacyHeadingBias  // 0x240
  private           System.Boolean                  mUseLegacyRigDefinitions  // 0x244
  private           System.Boolean                  mIsDestroyed  // 0x245
  private           Cinemachine.CameraState         m_State  // 0x248
  private           Cinemachine.CinemachineVirtualCamera[]m_Rigs  // 0x358
  private           Cinemachine.CinemachineOrbitalTransposer[]mOrbitals  // 0x360
  private           Cinemachine.CinemachineBlend    mBlendA  // 0x368
  private           Cinemachine.CinemachineBlend    mBlendB  // 0x370
  public    static  Cinemachine.CinemachineFreeLook.CreateRigDelegateCreateRigOverride  // 0x0
  public    static  Cinemachine.CinemachineFreeLook.DestroyRigDelegateDestroyRigOverride  // 0x8
  private           System.Single                   m_CachedXAxisHeading  // 0x378
  private           Cinemachine.CinemachineFreeLook.Orbit[]m_CachedOrbits  // 0x380
  private           System.Single                   m_CachedTension  // 0x388
  private           UnityEngine.Vector4[]           m_CachedKnots  // 0x390
  private           UnityEngine.Vector4[]           m_CachedCtrl1  // 0x398
  private           UnityEngine.Vector4[]           m_CachedCtrl2  // 0x3A0
METHODS:
  System.Void OnValidate()
  Cinemachine.CinemachineVirtualCamera GetRig(System.Int32 i)
  System.String[] get_RigNames()
  System.Void OnEnable()
  System.Void UpdateInputAxisProvider()
  System.Void OnDestroy()
  System.Void OnTransformChildrenChanged()
  System.Void Reset()
  System.Boolean get_PreviousStateIsValid()
  System.Void set_PreviousStateIsValid(System.Boolean value)
  Cinemachine.CameraState get_State()
  UnityEngine.Transform get_LookAt()
  System.Void set_LookAt(UnityEngine.Transform value)
  UnityEngine.Transform get_Follow()
  System.Void set_Follow(UnityEngine.Transform value)
  System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Boolean RequiresUserInput()
  System.Single GetYAxisClosestValue(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 up)
  System.Void InvalidateRigCache()
  System.Void DestroyRigs()
  Cinemachine.CinemachineVirtualCamera[] CreateRigs(Cinemachine.CinemachineVirtualCamera[] copyFrom)
  System.Void UpdateRigCache()
  System.Int32 LocateExistingRigs(System.String[] rigNames, System.Boolean forceOrbital)
  System.Single UpdateXAxisHeading(Cinemachine.CinemachineOrbitalTransposer orbital, System.Single deltaTime, UnityEngine.Vector3 up)
  System.Void PushSettingsToRigs()
  System.Single GetYAxisValue()
  Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  UnityEngine.Vector3 GetLocalPositionForCameraFromInput(System.Single t)
  System.Void UpdateCachedSpline()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineMixingCamera
TYPE:  class
TOKEN: 0x2000029
EXTENDS: CinemachineVirtualCameraBase
FIELDS:
  public    static  System.Int32                    MaxCameras  // 0x0
  public            System.Single                   m_Weight0  // 0xA8
  public            System.Single                   m_Weight1  // 0xAC
  public            System.Single                   m_Weight2  // 0xB0
  public            System.Single                   m_Weight3  // 0xB4
  public            System.Single                   m_Weight4  // 0xB8
  public            System.Single                   m_Weight5  // 0xBC
  public            System.Single                   m_Weight6  // 0xC0
  public            System.Single                   m_Weight7  // 0xC4
  private           Cinemachine.CameraState         m_State  // 0xC8
  private           Cinemachine.ICinemachineCamera  <LiveChild>k__BackingField  // 0x1D8
  private           UnityEngine.Transform           <LookAt>k__BackingField  // 0x1E0
  private           UnityEngine.Transform           <Follow>k__BackingField  // 0x1E8
  private           Cinemachine.CinemachineVirtualCameraBase[]m_ChildCameras  // 0x1F0
  private           System.Collections.Generic.Dictionary<Cinemachine.CinemachineVirtualCameraBase,System.Int32>m_indexMap  // 0x1F8
METHODS:
  System.Single GetWeight(System.Int32 index)
  System.Void SetWeight(System.Int32 index, System.Single w)
  System.Single GetWeight(Cinemachine.CinemachineVirtualCameraBase vcam)
  System.Void SetWeight(Cinemachine.CinemachineVirtualCameraBase vcam, System.Single w)
  Cinemachine.ICinemachineCamera get_LiveChild()
  System.Void set_LiveChild(Cinemachine.ICinemachineCamera value)
  Cinemachine.CameraState get_State()
  UnityEngine.Transform get_LookAt()
  System.Void set_LookAt(UnityEngine.Transform value)
  UnityEngine.Transform get_Follow()
  System.Void set_Follow(UnityEngine.Transform value)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Void OnEnable()
  System.Void OnTransformChildrenChanged()
  System.Void OnValidate()
  System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly)
  Cinemachine.CinemachineVirtualCameraBase[] get_ChildCameras()
  System.Void InvalidateListOfChildren()
  System.Void ValidateListOfChildren()
  System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachinePath
TYPE:  class
TOKEN: 0x200002A
EXTENDS: CinemachinePathBase
FIELDS:
  public            System.Boolean                  m_Looped  // 0x48
  public            Cinemachine.CinemachinePath.Waypoint[]m_Waypoints  // 0x50
METHODS:
  System.Single get_MinPos()
  System.Single get_MaxPos()
  System.Boolean get_Looped()
  System.Void Reset()
  System.Int32 get_DistanceCacheSampleStepsPerSegment()
  System.Single GetBoundingIndices(System.Single pos, System.Int32& indexA, System.Int32& indexB)
  UnityEngine.Vector3 EvaluatePosition(System.Single pos)
  UnityEngine.Vector3 EvaluateTangent(System.Single pos)
  UnityEngine.Quaternion EvaluateOrientation(System.Single pos)
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachinePipeline
TYPE:  class
TOKEN: 0x200002C
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachinePixelPerfect
TYPE:  class
TOKEN: 0x200002D
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineSmoothPath
TYPE:  class
TOKEN: 0x200002E
EXTENDS: CinemachinePathBase
FIELDS:
  public            System.Boolean                  m_Looped  // 0x48
  public            Cinemachine.CinemachineSmoothPath.Waypoint[]m_Waypoints  // 0x50
  private           Cinemachine.CinemachineSmoothPath.Waypoint[]m_ControlPoints1  // 0x58
  private           Cinemachine.CinemachineSmoothPath.Waypoint[]m_ControlPoints2  // 0x60
  private           System.Boolean                  m_IsLoopedCache  // 0x68
METHODS:
  System.Single get_MinPos()
  System.Single get_MaxPos()
  System.Boolean get_Looped()
  System.Int32 get_DistanceCacheSampleStepsPerSegment()
  System.Void OnValidate()
  System.Void Reset()
  System.Void InvalidateDistanceCache()
  System.Void UpdateControlPoints()
  System.Single GetBoundingIndices(System.Single pos, System.Int32& indexA, System.Int32& indexB)
  UnityEngine.Vector3 EvaluatePosition(System.Single pos)
  UnityEngine.Vector3 EvaluateTangent(System.Single pos)
  UnityEngine.Quaternion EvaluateOrientation(System.Single pos)
  UnityEngine.Quaternion RollAroundForward(System.Single angle)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineStateDrivenCamera
TYPE:  class
TOKEN: 0x2000030
EXTENDS: CinemachineVirtualCameraBase
FIELDS:
  public            UnityEngine.Transform           m_LookAt  // 0xA8
  public            UnityEngine.Transform           m_Follow  // 0xB0
  public            UnityEngine.Animator            m_AnimatedTarget  // 0xB8
  public            System.Int32                    m_LayerIndex  // 0xC0
  public            System.Boolean                  m_ShowDebugText  // 0xC4
  private           Cinemachine.CinemachineVirtualCameraBase[]m_ChildCameras  // 0xC8
  public            Cinemachine.CinemachineStateDrivenCamera.Instruction[]m_Instructions  // 0xD0
  public            Cinemachine.CinemachineBlendDefinitionm_DefaultBlend  // 0xD8
  public            Cinemachine.CinemachineBlenderSettingsm_CustomBlends  // 0xF0
  private           Cinemachine.CinemachineStateDrivenCamera.ParentHash[]m_ParentHash  // 0xF8
  private           Cinemachine.ICinemachineCamera  <LiveChild>k__BackingField  // 0x100
  private           Cinemachine.ICinemachineCamera  m_TransitioningFrom  // 0x108
  private           Cinemachine.CameraState         m_State  // 0x110
  private           System.Collections.Generic.Dictionary<UnityEngine.AnimationClip,System.Collections.Generic.List<Cinemachine.CinemachineStateDrivenCamera.HashPair>>mHashCache  // 0x220
  private           System.Single                   mActivationTime  // 0x228
  private           Cinemachine.CinemachineStateDrivenCamera.InstructionmActiveInstruction  // 0x230
  private           System.Single                   mPendingActivationTime  // 0x248
  private           Cinemachine.CinemachineStateDrivenCamera.InstructionmPendingInstruction  // 0x250
  private           Cinemachine.CinemachineBlend    mActiveBlend  // 0x268
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>mInstructionDictionary  // 0x270
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>mStateParentLookup  // 0x278
  private           System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>m_clipInfoList  // 0x280
METHODS:
  System.String get_Description()
  Cinemachine.ICinemachineCamera get_LiveChild()
  System.Void set_LiveChild(Cinemachine.ICinemachineCamera value)
  System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly)
  Cinemachine.CameraState get_State()
  UnityEngine.Transform get_LookAt()
  System.Void set_LookAt(UnityEngine.Transform value)
  UnityEngine.Transform get_Follow()
  System.Void set_Follow(UnityEngine.Transform value)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnTransformChildrenChanged()
  System.Void OnGuiHandler()
  Cinemachine.CinemachineVirtualCameraBase[] get_ChildCameras()
  System.Boolean get_IsBlending()
  System.Int32 CreateFakeHash(System.Int32 parentHash, UnityEngine.AnimationClip clip)
  System.Int32 LookupFakeHash(System.Int32 parentHash, UnityEngine.AnimationClip clip)
  System.Void InvalidateListOfChildren()
  System.Void UpdateListOfChildren()
  System.Void ValidateInstructions()
  Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera()
  System.Int32 GetClipHash(System.Int32 hash, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
  Cinemachine.CinemachineBlendDefinition LookupBlend(Cinemachine.ICinemachineCamera fromKey, Cinemachine.ICinemachineCamera toKey)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineStoryboard
TYPE:  class
TOKEN: 0x2000034
EXTENDS: CinemachineExtension
FIELDS:
  public    static  System.Boolean                  s_StoryboardGlobalMute  // 0x0
  public            System.Boolean                  m_ShowImage  // 0x28
  public            UnityEngine.Texture             m_Image  // 0x30
  public            Cinemachine.CinemachineStoryboard.FillStrategym_Aspect  // 0x38
  public            System.Single                   m_Alpha  // 0x3C
  public            UnityEngine.Vector2             m_Center  // 0x40
  public            UnityEngine.Vector3             m_Rotation  // 0x48
  public            UnityEngine.Vector2             m_Scale  // 0x54
  public            System.Boolean                  m_SyncScale  // 0x5C
  public            System.Boolean                  m_MuteCamera  // 0x5D
  public            System.Single                   m_SplitView  // 0x60
  public            Cinemachine.CinemachineStoryboard.StoryboardRenderModem_RenderMode  // 0x64
  public            System.Int32                    m_SortingOrder  // 0x68
  public            System.Single                   m_PlaneDistance  // 0x6C
  private           System.Collections.Generic.List<Cinemachine.CinemachineStoryboard.CanvasInfo>mCanvasInfo  // 0x70
METHODS:
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void UpdateRenderCanvas()
  System.Void ConnectToVcam(System.Boolean connect)
  System.String get_CanvasName()
  System.Void CameraUpdatedCallback(Cinemachine.CinemachineBrain brain)
  Cinemachine.CinemachineStoryboard.CanvasInfo LocateMyCanvas(Cinemachine.CinemachineBrain parent, System.Boolean createIfNotFound)
  System.Void CreateCanvas(Cinemachine.CinemachineStoryboard.CanvasInfo ci)
  System.Void DestroyCanvas()
  System.Void PlaceImage(Cinemachine.CinemachineStoryboard.CanvasInfo ci, System.Single alpha)
  System.Void StaticBlendingHandler(Cinemachine.CinemachineBrain brain)
  System.Void InitializeModule()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.ICinemachineTargetGroup
TYPE:  interface
TOKEN: 0x2000038
FIELDS:
METHODS:
  UnityEngine.BoundingSphere get_Sphere()
  System.Boolean get_IsEmpty()
  UnityEngine.Bounds GetViewSpaceBoundingBox(UnityEngine.Matrix4x4 observer)
  System.Void GetViewSpaceAngularBounds(UnityEngine.Matrix4x4 observer, UnityEngine.Vector2& minAngles, UnityEngine.Vector2& maxAngles, UnityEngine.Vector2& zRange)
END_CLASS

CLASS: Cinemachine.CinemachineTargetGroup
TYPE:  class
TOKEN: 0x2000039
EXTENDS: MonoBehaviour
FIELDS:
  public            Cinemachine.CinemachineTargetGroup.PositionModem_PositionMode  // 0x18
  public            Cinemachine.CinemachineTargetGroup.RotationModem_RotationMode  // 0x1C
  public            Cinemachine.CinemachineTargetGroup.UpdateMethodm_UpdateMethod  // 0x20
  public            Cinemachine.CinemachineTargetGroup.Target[]m_Targets  // 0x28
  private           UnityEngine.Bounds              <BoundingBox>k__BackingField  // 0x30
  private           System.Single                   m_MaxWeight  // 0x48
  private           UnityEngine.Vector3             m_AveragePos  // 0x4C
  private           UnityEngine.BoundingSphere      m_BoundingSphere  // 0x58
METHODS:
  UnityEngine.Transform get_Transform()
  UnityEngine.Bounds get_BoundingBox()
  System.Void set_BoundingBox(UnityEngine.Bounds value)
  UnityEngine.BoundingSphere get_Sphere()
  System.Boolean get_IsEmpty()
  System.Void AddMember(UnityEngine.Transform t, System.Single weight, System.Single radius)
  System.Void RemoveMember(UnityEngine.Transform t)
  System.Int32 FindMember(UnityEngine.Transform t)
  UnityEngine.BoundingSphere GetWeightedBoundsForMember(System.Int32 index)
  UnityEngine.Bounds GetViewSpaceBoundingBox(UnityEngine.Matrix4x4 observer)
  UnityEngine.BoundingSphere WeightedMemberBounds(Cinemachine.CinemachineTargetGroup.Target t, UnityEngine.Vector3 avgPos, System.Single maxWeight)
  System.Void DoUpdate()
  UnityEngine.BoundingSphere CalculateBoundingSphere(System.Single maxWeight)
  UnityEngine.Vector3 CalculateAveragePosition(System.Single& maxWeight)
  UnityEngine.Quaternion CalculateAverageOrientation()
  UnityEngine.Bounds CalculateBoundingBox(UnityEngine.Vector3 avgPos, System.Single maxWeight)
  System.Void OnValidate()
  System.Void FixedUpdate()
  System.Void Update()
  System.Void LateUpdate()
  System.Void GetViewSpaceAngularBounds(UnityEngine.Matrix4x4 observer, UnityEngine.Vector2& minAngles, UnityEngine.Vector2& maxAngles, UnityEngine.Vector2& zRange)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineVirtualCamera
TYPE:  class
TOKEN: 0x200003E
EXTENDS: CinemachineVirtualCameraBase
FIELDS:
  public            UnityEngine.Transform           m_LookAt  // 0xA8
  public            UnityEngine.Transform           m_Follow  // 0xB0
  public            Cinemachine.LensSettings        m_Lens  // 0xB8
  public            Cinemachine.CinemachineVirtualCameraBase.TransitionParamsm_Transitions  // 0xE8
  private           Cinemachine.CinemachineVirtualCameraBase.BlendHintm_LegacyBlendHint  // 0xF8
  public    static  System.String                   PipelineName  // 0x0
  public    static  Cinemachine.CinemachineVirtualCamera.CreatePipelineDelegateCreatePipelineOverride  // 0x0
  public    static  Cinemachine.CinemachineVirtualCamera.DestroyPipelineDelegateDestroyPipelineOverride  // 0x8
  private           System.Boolean                  m_UserIsDragging  // 0xFC
  private           Cinemachine.CameraState         m_State  // 0x100
  private           Cinemachine.CinemachineComponentBase[]m_ComponentPipeline  // 0x210
  private           UnityEngine.Transform           m_ComponentOwner  // 0x218
  private           UnityEngine.Transform           mCachedLookAtTarget  // 0x220
  private           Cinemachine.CinemachineVirtualCameraBasemCachedLookAtTargetVcam  // 0x228
METHODS:
  Cinemachine.CameraState get_State()
  UnityEngine.Transform get_LookAt()
  System.Void set_LookAt(UnityEngine.Transform value)
  UnityEngine.Transform get_Follow()
  System.Void set_Follow(UnityEngine.Transform value)
  System.Void SetFieldOfView(System.Single fov)
  System.Single GetMaxDampTime()
  System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void OnEnable()
  System.Void OnDestroy()
  System.Void OnValidate()
  System.Void OnTransformChildrenChanged()
  System.Void Reset()
  System.Void DestroyPipeline()
  UnityEngine.Transform CreatePipeline(Cinemachine.CinemachineVirtualCamera copyFrom)
  System.Void InvalidateComponentPipeline()
  UnityEngine.Transform GetComponentOwner()
  Cinemachine.CinemachineComponentBase[] GetComponentPipeline()
  Cinemachine.CinemachineComponentBase GetCinemachineComponent(Cinemachine.CinemachineCore.Stage stage)
  T GetCinemachineComponent()
  T AddCinemachineComponent()
  System.Void DestroyCinemachineComponent()
  System.Void UpdateComponentPipeline()
  System.Void SetFlagsForHiddenChild(UnityEngine.GameObject child)
  Cinemachine.CameraState CalculateNewState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Void SetStateRawPosition(UnityEngine.Vector3 pos)
  System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Boolean RequiresUserInput()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.Cinemachine3rdPersonFollow
TYPE:  class
TOKEN: 0x2000042
EXTENDS: CinemachineComponentBase
FIELDS:
  public            UnityEngine.Vector3             Damping  // 0x20
  public            UnityEngine.Vector3             ShoulderOffset  // 0x2C
  public            System.Single                   VerticalArmLength  // 0x38
  public            System.Single                   CameraSide  // 0x3C
  public            System.Single                   CameraDistance  // 0x40
  public            UnityEngine.LayerMask           CameraCollisionFilter  // 0x44
  public            System.String                   IgnoreTag  // 0x48
  public            System.Single                   CameraRadius  // 0x50
  public            System.Single                   DampingIntoCollision  // 0x54
  public            System.Single                   DampingFromCollision  // 0x58
  public            System.Boolean                  DisableDampingCorrection  // 0x5C
  private           UnityEngine.Vector3             m_PreviousFollowTargetPosition  // 0x60
  private           UnityEngine.Vector3             m_DampingCorrection  // 0x6C
  private           System.Single                   m_CamPosCollisionCorrection  // 0x78
METHODS:
  System.Void OnValidate()
  System.Void Reset()
  System.Void OnDestroy()
  System.Boolean get_IsValid()
  Cinemachine.CinemachineCore.Stage get_Stage()
  System.Single GetMaxDampTime()
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void PositionCamera(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Void GetRigPositions(UnityEngine.Vector3& root, UnityEngine.Vector3& shoulder, UnityEngine.Vector3& hand)
  UnityEngine.Quaternion GetHeading(UnityEngine.Quaternion targetRot, UnityEngine.Vector3 up)
  System.Void GetRawRigPositions(UnityEngine.Vector3 root, UnityEngine.Quaternion targetRot, UnityEngine.Quaternion heading, UnityEngine.Vector3& shoulder, UnityEngine.Vector3& hand)
  UnityEngine.Vector3 BeyondResolveCollisions(UnityEngine.Vector3 root, UnityEngine.Vector3 tip, System.Single cameraRadius)
  UnityEngine.Vector3 ResolveCollisions(UnityEngine.Vector3 root, UnityEngine.Vector3 tip, System.Single deltaTime, System.Single cameraRadius, System.Single& collisionCorrection)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineBasicMultiChannelPerlin
TYPE:  class
TOKEN: 0x2000043
EXTENDS: CinemachineComponentBase
FIELDS:
  public            Cinemachine.NoiseSettings       m_NoiseProfile  // 0x20
  public            UnityEngine.Vector3             m_PivotOffset  // 0x28
  public            System.Single                   m_AmplitudeGain  // 0x34
  public            System.Single                   m_FrequencyGain  // 0x38
  private           System.Boolean                  mInitialized  // 0x3C
  private           System.Single                   mNoiseTime  // 0x40
  private           UnityEngine.Vector3             mNoiseOffsets  // 0x44
METHODS:
  System.Boolean get_IsValid()
  Cinemachine.CinemachineCore.Stage get_Stage()
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Void ReSeed()
  System.Void Initialize()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineComposer
TYPE:  class
TOKEN: 0x2000044
EXTENDS: CinemachineComponentBase
FIELDS:
  public            UnityEngine.Vector3             m_TrackedObjectOffset  // 0x20
  public            System.Single                   m_LookaheadTime  // 0x2C
  public            System.Single                   m_LookaheadSmoothing  // 0x30
  public            System.Boolean                  m_LookaheadIgnoreY  // 0x34
  public            System.Single                   m_HorizontalDamping  // 0x38
  public            System.Single                   m_VerticalDamping  // 0x3C
  public            System.Single                   m_ScreenX  // 0x40
  public            System.Single                   m_ScreenY  // 0x44
  public            System.Single                   m_DeadZoneWidth  // 0x48
  public            System.Single                   m_DeadZoneHeight  // 0x4C
  public            System.Single                   m_SoftZoneWidth  // 0x50
  public            System.Single                   m_SoftZoneHeight  // 0x54
  public            System.Single                   m_BiasX  // 0x58
  public            System.Single                   m_BiasY  // 0x5C
  public            System.Boolean                  m_CenterOnActivate  // 0x60
  private           UnityEngine.Vector3             <TrackedPoint>k__BackingField  // 0x64
  private           UnityEngine.Vector3             m_CameraPosPrevFrame  // 0x70
  private           UnityEngine.Vector3             m_LookAtPrevFrame  // 0x7C
  private           UnityEngine.Vector2             m_ScreenOffsetPrevFrame  // 0x88
  private           UnityEngine.Quaternion          m_CameraOrientationPrevFrame  // 0x90
  private           Cinemachine.Utility.PositionPredictorm_Predictor  // 0xA0
  private           Cinemachine.CinemachineComposer.FovCachemCache  // 0xA8
  private           UnityEngine.Vector2             _lastExtra  // 0xF8
  private           UnityEngine.Vector2             _lastOriginalRotToRect  // 0x100
  public            UnityEngine.Vector2             deadZoneDampFactor  // 0x108
METHODS:
  System.Boolean get_IsValid()
  Cinemachine.CinemachineCore.Stage get_Stage()
  UnityEngine.Vector3 get_TrackedPoint()
  System.Void set_TrackedPoint(UnityEngine.Vector3 value)
  UnityEngine.Vector3 GetLookAtPointAndSetTrackedPoint(UnityEngine.Vector3 lookAt, UnityEngine.Vector3 up, System.Single deltaTime)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Single GetMaxDampTime()
  System.Void PrePipelineMutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  UnityEngine.Rect get_SoftGuideRect()
  System.Void set_SoftGuideRect(UnityEngine.Rect value)
  UnityEngine.Rect get_HardGuideRect()
  System.Void set_HardGuideRect(UnityEngine.Rect value)
  System.Void ClearOriginalRotToRect()
  System.Void RotateToScreenBounds(Cinemachine.CameraState& state, UnityEngine.Rect screenRect, UnityEngine.Vector3 trackedPoint, UnityEngine.Quaternion& rigOrientation, System.Single fov, System.Single fovH, System.Single deltaTime)
  System.Boolean ClampVerticalBounds(UnityEngine.Rect& r, UnityEngine.Vector3 dir, UnityEngine.Vector3 up, System.Single fov)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineFramingTransposer
TYPE:  class
TOKEN: 0x2000046
EXTENDS: CinemachineComponentBase
FIELDS:
  public            UnityEngine.Vector3             m_TrackedObjectOffset  // 0x20
  public            System.Single                   m_LookaheadTime  // 0x2C
  public            System.Single                   m_LookaheadSmoothing  // 0x30
  public            System.Boolean                  m_LookaheadIgnoreY  // 0x34
  public            System.Single                   m_XDamping  // 0x38
  public            System.Single                   m_YDamping  // 0x3C
  public            System.Single                   m_ZDamping  // 0x40
  public            System.Boolean                  m_TargetMovementOnly  // 0x44
  public            System.Single                   m_ScreenX  // 0x48
  public            System.Single                   m_ScreenY  // 0x4C
  public            System.Single                   m_CameraDistance  // 0x50
  public            System.Single                   m_DeadZoneWidth  // 0x54
  public            System.Single                   m_DeadZoneHeight  // 0x58
  public            System.Single                   m_DeadZoneDepth  // 0x5C
  public            System.Boolean                  m_UnlimitedSoftZone  // 0x60
  public            System.Single                   m_SoftZoneWidth  // 0x64
  public            System.Single                   m_SoftZoneHeight  // 0x68
  public            System.Single                   m_BiasX  // 0x6C
  public            System.Single                   m_BiasY  // 0x70
  public            System.Boolean                  m_CenterOnActivate  // 0x74
  public            Cinemachine.CinemachineFramingTransposer.FramingModem_GroupFramingMode  // 0x78
  public            Cinemachine.CinemachineFramingTransposer.AdjustmentModem_AdjustmentMode  // 0x7C
  public            System.Single                   m_GroupFramingSize  // 0x80
  public            System.Single                   m_MaxDollyIn  // 0x84
  public            System.Single                   m_MaxDollyOut  // 0x88
  public            System.Single                   m_MinimumDistance  // 0x8C
  public            System.Single                   m_MaximumDistance  // 0x90
  public            System.Single                   m_MinimumFOV  // 0x94
  public            System.Single                   m_MaximumFOV  // 0x98
  public            System.Single                   m_MinimumOrthoSize  // 0x9C
  public            System.Single                   m_MaximumOrthoSize  // 0xA0
  private   static  System.Single                   kMinimumCameraDistance  // 0x0
  private   static  System.Single                   kMinimumGroupSize  // 0x0
  private           UnityEngine.Vector3             m_PreviousCameraPosition  // 0xA4
  private           Cinemachine.Utility.PositionPredictorm_Predictor  // 0xB0
  private           UnityEngine.Vector3             <TrackedPoint>k__BackingField  // 0xB8
  private           System.Boolean                  m_InheritingPosition  // 0xC4
  private           System.Single                   m_prevFOV  // 0xC8
  private           UnityEngine.Quaternion          m_prevRotation  // 0xCC
  private           UnityEngine.Bounds              <LastBounds>k__BackingField  // 0xDC
  private           UnityEngine.Matrix4x4           <LastBoundsMatrix>k__BackingField  // 0xF4
METHODS:
  UnityEngine.Rect get_SoftGuideRect()
  System.Void set_SoftGuideRect(UnityEngine.Rect value)
  UnityEngine.Rect get_HardGuideRect()
  System.Void set_HardGuideRect(UnityEngine.Rect value)
  System.Void OnValidate()
  System.Boolean get_IsValid()
  Cinemachine.CinemachineCore.Stage get_Stage()
  System.Boolean get_BodyAppliesAfterAim()
  UnityEngine.Vector3 get_TrackedPoint()
  System.Void set_TrackedPoint(UnityEngine.Vector3 value)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Single GetMaxDampTime()
  System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams)
  UnityEngine.Rect ScreenToOrtho(UnityEngine.Rect rScreen, System.Single orthoSize, System.Single aspect)
  UnityEngine.Vector3 OrthoOffsetToScreenBounds(UnityEngine.Vector3 targetPos2D, UnityEngine.Rect screenRect)
  UnityEngine.Bounds get_LastBounds()
  System.Void set_LastBounds(UnityEngine.Bounds value)
  UnityEngine.Matrix4x4 get_LastBoundsMatrix()
  System.Void set_LastBoundsMatrix(UnityEngine.Matrix4x4 value)
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Single GetTargetHeight(UnityEngine.Vector2 boundsSize)
  UnityEngine.Vector3 ComputeGroupBounds(Cinemachine.ICinemachineTargetGroup group, Cinemachine.CameraState& curState)
  UnityEngine.Bounds GetScreenSpaceGroupBoundingBox(Cinemachine.ICinemachineTargetGroup group, UnityEngine.Vector3& pos, UnityEngine.Quaternion orientation)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineGroupComposer
TYPE:  class
TOKEN: 0x2000049
EXTENDS: CinemachineComposer
FIELDS:
  public            System.Single                   m_GroupFramingSize  // 0x110
  public            Cinemachine.CinemachineGroupComposer.FramingModem_FramingMode  // 0x114
  public            System.Single                   m_FrameDamping  // 0x118
  public            Cinemachine.CinemachineGroupComposer.AdjustmentModem_AdjustmentMode  // 0x11C
  public            System.Single                   m_MaxDollyIn  // 0x120
  public            System.Single                   m_MaxDollyOut  // 0x124
  public            System.Single                   m_MinimumDistance  // 0x128
  public            System.Single                   m_MaximumDistance  // 0x12C
  public            System.Single                   m_MinimumFOV  // 0x130
  public            System.Single                   m_MaximumFOV  // 0x134
  public            System.Single                   m_MinimumOrthoSize  // 0x138
  public            System.Single                   m_MaximumOrthoSize  // 0x13C
  private           System.Single                   m_prevFramingDistance  // 0x140
  private           System.Single                   m_prevFOV  // 0x144
  private           UnityEngine.Bounds              <LastBounds>k__BackingField  // 0x148
  private           UnityEngine.Matrix4x4           <LastBoundsMatrix>k__BackingField  // 0x160
METHODS:
  System.Void OnValidate()
  UnityEngine.Bounds get_LastBounds()
  System.Void set_LastBounds(UnityEngine.Bounds value)
  UnityEngine.Matrix4x4 get_LastBoundsMatrix()
  System.Void set_LastBoundsMatrix(UnityEngine.Matrix4x4 value)
  System.Single GetMaxDampTime()
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Single GetTargetHeight(UnityEngine.Vector2 boundsSize)
  UnityEngine.Bounds GetScreenSpaceGroupBoundingBox(Cinemachine.ICinemachineTargetGroup group, UnityEngine.Matrix4x4 observer, UnityEngine.Vector3& newFwd)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineHardLockToTarget
TYPE:  class
TOKEN: 0x200004C
EXTENDS: CinemachineComponentBase
FIELDS:
  public            System.Single                   m_Damping  // 0x20
  private           UnityEngine.Vector3             m_PreviousTargetPosition  // 0x24
METHODS:
  System.Boolean get_IsValid()
  Cinemachine.CinemachineCore.Stage get_Stage()
  System.Single GetMaxDampTime()
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineHardLookAt
TYPE:  class
TOKEN: 0x200004D
EXTENDS: CinemachineComponentBase
FIELDS:
METHODS:
  System.Boolean get_IsValid()
  Cinemachine.CinemachineCore.Stage get_Stage()
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineOrbitalTransposer
TYPE:  class
TOKEN: 0x200004E
EXTENDS: CinemachineTransposer
FIELDS:
  public            Cinemachine.CinemachineOrbitalTransposer.Headingm_Heading  // 0x98
  public            Cinemachine.AxisState.Recenteringm_RecenterToTargetHeading  // 0xA4
  public            Cinemachine.AxisState           m_XAxis  // 0xC0
  private           System.Single                   m_LegacyRadius  // 0x130
  private           System.Single                   m_LegacyHeightOffset  // 0x134
  private           System.Single                   m_LegacyHeadingBias  // 0x138
  public            System.Boolean                  m_HeadingIsSlave  // 0x13C
  private           Cinemachine.CinemachineOrbitalTransposer.UpdateHeadingDelegateHeadingUpdater  // 0x140
  private           UnityEngine.Vector3             m_LastTargetPosition  // 0x148
  private           Cinemachine.Utility.HeadingTrackermHeadingTracker  // 0x158
  private           UnityEngine.Rigidbody           m_TargetRigidBody  // 0x160
  private           UnityEngine.Transform           m_PreviousTarget  // 0x168
  private           UnityEngine.Vector3             m_LastCameraPosition  // 0x170
  private           System.Single                   m_LastHeading  // 0x17C
METHODS:
  System.Void OnValidate()
  System.Single UpdateHeading(System.Single deltaTime, UnityEngine.Vector3 up, Cinemachine.AxisState& axis)
  System.Single UpdateHeading(System.Single deltaTime, UnityEngine.Vector3 up, Cinemachine.AxisState& axis, Cinemachine.AxisState.Recentering& recentering, System.Boolean isLive)
  System.Void OnEnable()
  System.Void UpdateInputAxisProvider()
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams)
  System.Single GetAxisClosestValue(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 up)
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  UnityEngine.Vector3 GetTargetCameraPosition(UnityEngine.Vector3 worldUp)
  System.Boolean get_RequiresUserInput()
  System.Single GetTargetHeading(System.Single currentHeading, UnityEngine.Quaternion targetOrientation)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachinePOV
TYPE:  class
TOKEN: 0x2000053
EXTENDS: CinemachineComponentBase
FIELDS:
  public            Cinemachine.CinemachinePOV.RecenterTargetModem_RecenterTarget  // 0x20
  public            Cinemachine.AxisState           m_VerticalAxis  // 0x28
  public            Cinemachine.AxisState.Recenteringm_VerticalRecentering  // 0x98
  public            Cinemachine.AxisState           m_HorizontalAxis  // 0xB8
  public            Cinemachine.AxisState.Recenteringm_HorizontalRecentering  // 0x128
  public            System.Boolean                  m_ApplyBeforeBody  // 0x144
METHODS:
  System.Boolean get_IsValid()
  Cinemachine.CinemachineCore.Stage get_Stage()
  System.Void OnValidate()
  System.Void OnEnable()
  System.Void UpdateInputAxisProvider()
  System.Void PrePipelineMutateCameraState(Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  UnityEngine.Vector2 GetRecenterTarget()
  System.Single NormalizeAngle(System.Single angle)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams)
  System.Boolean get_RequiresUserInput()
  System.Void SetAxesForRotation(UnityEngine.Quaternion targetRot)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineSameAsFollowTarget
TYPE:  class
TOKEN: 0x2000055
EXTENDS: CinemachineComponentBase
FIELDS:
  public            System.Single                   m_Damping  // 0x20
  private           UnityEngine.Quaternion          m_PreviousReferenceOrientation  // 0x24
METHODS:
  System.Boolean get_IsValid()
  Cinemachine.CinemachineCore.Stage get_Stage()
  System.Single GetMaxDampTime()
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineTrackedDolly
TYPE:  class
TOKEN: 0x2000056
EXTENDS: CinemachineComponentBase
FIELDS:
  public            Cinemachine.CinemachinePathBase m_Path  // 0x20
  public            System.Single                   m_PathPosition  // 0x28
  public            Cinemachine.CinemachinePathBase.PositionUnitsm_PositionUnits  // 0x2C
  public            UnityEngine.Vector3             m_PathOffset  // 0x30
  public            System.Single                   m_XDamping  // 0x3C
  public            System.Single                   m_YDamping  // 0x40
  public            System.Single                   m_ZDamping  // 0x44
  public            Cinemachine.CinemachineTrackedDolly.CameraUpModem_CameraUp  // 0x48
  public            System.Single                   m_PitchDamping  // 0x4C
  public            System.Single                   m_YawDamping  // 0x50
  public            System.Single                   m_RollDamping  // 0x54
  public            Cinemachine.CinemachineTrackedDolly.AutoDollym_AutoDolly  // 0x58
  private           System.Single                   m_PreviousPathPosition  // 0x68
  private           UnityEngine.Quaternion          m_PreviousOrientation  // 0x6C
  private           UnityEngine.Vector3             m_PreviousCameraPosition  // 0x7C
METHODS:
  System.Boolean get_IsValid()
  Cinemachine.CinemachineCore.Stage get_Stage()
  System.Single GetMaxDampTime()
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  UnityEngine.Quaternion GetCameraOrientationAtPathPoint(UnityEngine.Quaternion pathOrientation, UnityEngine.Vector3 up)
  UnityEngine.Vector3 get_AngularDamping()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineTransposer
TYPE:  class
TOKEN: 0x2000059
EXTENDS: CinemachineComponentBase
FIELDS:
  public            Cinemachine.CinemachineTransposer.BindingModem_BindingMode  // 0x20
  public            UnityEngine.Vector3             m_FollowOffset  // 0x24
  public            System.Single                   m_XDamping  // 0x30
  public            System.Single                   m_YDamping  // 0x34
  public            System.Single                   m_ZDamping  // 0x38
  public            Cinemachine.CinemachineTransposer.AngularDampingModem_AngularDampingMode  // 0x3C
  public            System.Single                   m_PitchDamping  // 0x40
  public            System.Single                   m_YawDamping  // 0x44
  public            System.Single                   m_RollDamping  // 0x48
  public            System.Single                   m_AngularDamping  // 0x4C
  private           System.Boolean                  <HideOffsetInInspector>k__BackingField  // 0x50
  private           UnityEngine.Vector3             m_PreviousTargetPosition  // 0x54
  private           UnityEngine.Quaternion          m_PreviousReferenceOrientation  // 0x60
  private           UnityEngine.Quaternion          m_targetOrientationOnAssign  // 0x70
  private           UnityEngine.Vector3             m_PreviousOffset  // 0x80
  private           UnityEngine.Transform           m_previousTarget  // 0x90
METHODS:
  System.Void OnValidate()
  System.Boolean get_HideOffsetInInspector()
  System.Void set_HideOffsetInInspector(System.Boolean value)
  UnityEngine.Vector3 get_EffectiveOffset()
  System.Boolean get_IsValid()
  Cinemachine.CinemachineCore.Stage get_Stage()
  System.Single GetMaxDampTime()
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Void InitPrevFrameStateInfo(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Void TrackTarget(System.Single deltaTime, UnityEngine.Vector3 up, UnityEngine.Vector3 desiredCameraOffset, UnityEngine.Vector3& outTargetPosition, UnityEngine.Quaternion& outTargetOrient)
  UnityEngine.Vector3 GetOffsetForMinimumTargetDistance(UnityEngine.Vector3 dampedTargetPos, UnityEngine.Vector3 cameraOffset, UnityEngine.Vector3 cameraFwd, UnityEngine.Vector3 up, UnityEngine.Vector3 actualTargetPos)
  UnityEngine.Vector3 get_Damping()
  UnityEngine.Vector3 get_AngularDamping()
  UnityEngine.Vector3 GetTargetCameraPosition(UnityEngine.Vector3 worldUp)
  UnityEngine.Quaternion GetReferenceOrientation(UnityEngine.Vector3 worldUp)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.AxisState
TYPE:  struct
TOKEN: 0x200005C
FIELDS:
  public            System.Single                   Value  // 0x10
  public            Cinemachine.AxisState.SpeedMode m_SpeedMode  // 0x14
  public            System.Single                   m_MaxSpeed  // 0x18
  public            System.Single                   m_AccelTime  // 0x1C
  public            System.Single                   m_DecelTime  // 0x20
  public            System.String                   m_InputAxisName  // 0x28
  public            System.Single                   m_InputAxisValue  // 0x30
  public            System.Boolean                  m_InvertInput  // 0x34
  public            System.Single                   m_MinValue  // 0x38
  public            System.Single                   m_MaxValue  // 0x3C
  public            System.Boolean                  m_Wrap  // 0x40
  public            Cinemachine.AxisState.Recenteringm_Recentering  // 0x44
  private           System.Single                   m_CurrentSpeed  // 0x60
  private           System.Single                   m_LastUpdateTime  // 0x64
  private           System.Int32                    m_LastUpdateFrame  // 0x68
  private   static  System.Single                   Epsilon  // 0x0
  private           Cinemachine.AxisState.IInputAxisProviderm_InputAxisProvider  // 0x70
  private           System.Int32                    m_InputAxisIndex  // 0x78
  private           System.Boolean                  <ValueRangeLocked>k__BackingField  // 0x7C
  private           System.Boolean                  <HasRecentering>k__BackingField  // 0x7D
METHODS:
  System.Void .ctor(System.Single minValue, System.Single maxValue, System.Boolean wrap, System.Boolean rangeLocked, System.Single maxSpeed, System.Single accelTime, System.Single decelTime, System.String name, System.Boolean invert)
  System.Void Validate()
  System.Void Reset()
  System.Void SetInputAxisProvider(System.Int32 axis, Cinemachine.AxisState.IInputAxisProvider provider)
  System.Boolean Update(System.Single deltaTime)
  System.Single ClampValue(System.Single v)
  System.Boolean MaxSpeedUpdate(System.Single input, System.Single deltaTime)
  System.Single GetMaxSpeed()
  System.Void set_ValueRangeLocked(System.Boolean value)
  System.Void set_HasRecentering(System.Boolean value)
END_CLASS

CLASS: Cinemachine.CameraState
TYPE:  struct
TOKEN: 0x2000060
FIELDS:
  public            Cinemachine.CameraState.HGDOFParamsDofParams  // 0x10
  public            Cinemachine.LensSettings        Lens  // 0x30
  public            UnityEngine.Vector3             ReferenceUp  // 0x60
  public            UnityEngine.Vector3             ReferenceLookAt  // 0x6C
  public            UnityEngine.Vector3             Pivot  // 0x78
  public    static  UnityEngine.Vector3             kNoPoint  // 0x0
  public            UnityEngine.Vector3             RawPosition  // 0x84
  public            UnityEngine.Quaternion          RawOrientation  // 0x90
  public            UnityEngine.Vector3             PositionDampingBypass  // 0xA0
  public            System.Single                   ShotQuality  // 0xAC
  public            UnityEngine.Vector3             PositionCorrection  // 0xB0
  public            UnityEngine.Quaternion          OrientationCorrection  // 0xBC
  public            Cinemachine.CameraState.BlendHintValueBlendHint  // 0xCC
  private           Cinemachine.CameraState.CustomBlendablemCustom0  // 0xD0
  private           Cinemachine.CameraState.CustomBlendablemCustom1  // 0xE0
  private           Cinemachine.CameraState.CustomBlendablemCustom2  // 0xF0
  private           Cinemachine.CameraState.CustomBlendablemCustom3  // 0x100
  private           System.Collections.Generic.List<Cinemachine.CameraState.CustomBlendable>m_CustomOverflow  // 0x110
  private           System.Int32                    <NumCustomBlendables>k__BackingField  // 0x118
METHODS:
  System.Boolean get_HasLookAt()
  UnityEngine.Vector3 get_CorrectedPosition()
  UnityEngine.Quaternion get_CorrectedOrientation()
  UnityEngine.Vector3 get_FinalPosition()
  UnityEngine.Quaternion get_FinalOrientation()
  Cinemachine.CameraState get_Default()
  System.Int32 get_NumCustomBlendables()
  System.Void set_NumCustomBlendables(System.Int32 value)
  Cinemachine.CameraState.CustomBlendable GetCustomBlendable(System.Int32 index)
  System.Int32 FindCustomBlendable(UnityEngine.Object custom)
  System.Void AddCustomBlendable(Cinemachine.CameraState.CustomBlendable b)
  Cinemachine.CameraState Lerp(Cinemachine.CameraState& stateA, Cinemachine.CameraState& stateB, System.Single t)
  System.Single InterpolateFOV(System.Single fovA, System.Single fovB, System.Single dA, System.Single dB, System.Single t)
  UnityEngine.Vector3 ApplyPosBlendHint(UnityEngine.Vector3 posA, Cinemachine.CameraState.BlendHintValue hintA, UnityEngine.Vector3 posB, Cinemachine.CameraState.BlendHintValue hintB, UnityEngine.Vector3 original, UnityEngine.Vector3 blended)
  UnityEngine.Quaternion ApplyRotBlendHint(UnityEngine.Quaternion rotA, Cinemachine.CameraState.BlendHintValue hintA, UnityEngine.Quaternion rotB, Cinemachine.CameraState.BlendHintValue hintB, UnityEngine.Quaternion original, UnityEngine.Quaternion blended)
  UnityEngine.Vector3 InterpolatePosition(UnityEngine.Vector3 posA, UnityEngine.Vector3 pivotA, UnityEngine.Vector3 posB, UnityEngine.Vector3 pivotB, System.Single t)
  System.Void .cctor()
END_CLASS

CLASS: Cinemachine.CinemachineBlend
TYPE:  class
TOKEN: 0x2000064
FIELDS:
  private           Cinemachine.ICinemachineCamera  m_CamA  // 0x10
  public            Cinemachine.ICinemachineCamera  CamB  // 0x18
  public            System.Boolean                  useSimpleInertialization  // 0x20
  public            System.Boolean                  InitStateGot  // 0x21
  public            Cinemachine.CameraState         InitStateA  // 0x28
  public            Cinemachine.CameraState         CurrStateA  // 0x138
  public            Cinemachine.CameraState         InitStateB  // 0x248
  public            UnityEngine.AnimationCurve      BlendCurve  // 0x358
  public            System.Single                   TimeInBlend  // 0x360
  public            System.Single                   Duration  // 0x364
METHODS:
  Cinemachine.ICinemachineCamera get_CamA()
  System.Void set_CamA(Cinemachine.ICinemachineCamera value)
  System.Void StartSimpleInertialization()
  System.Single get_BlendWeight()
  System.Boolean get_IsValid()
  System.Boolean get_IsComplete()
  System.String get_Description()
  System.Boolean Uses(Cinemachine.ICinemachineCamera cam)
  System.Void .ctor(Cinemachine.ICinemachineCamera a, Cinemachine.ICinemachineCamera b, UnityEngine.AnimationCurve curve, System.Single duration, System.Single t)
  System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  Cinemachine.CameraState get_State()
END_CLASS

CLASS: Cinemachine.CinemachineBlendDefinition
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            Cinemachine.CinemachineBlendDefinition.Stylem_Style  // 0x10
  public            System.Single                   m_Time  // 0x14
  public            UnityEngine.AnimationCurve      m_CustomCurve  // 0x18
  private   static  UnityEngine.AnimationCurve[]    sStandardCurves  // 0x0
  public            System.Boolean                  m_UseSimpleInertialization  // 0x20
METHODS:
  System.Single get_BlendTime()
  System.Void .ctor(Cinemachine.CinemachineBlendDefinition.Style style, System.Single time)
  System.Void CreateStandardCurves()
  UnityEngine.AnimationCurve get_BlendCurve()
END_CLASS

CLASS: Cinemachine.StaticPointVirtualCamera
TYPE:  class
TOKEN: 0x2000067
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           System.Int32                    <Priority>k__BackingField  // 0x18
  private           UnityEngine.Transform           <LookAt>k__BackingField  // 0x20
  private           UnityEngine.Transform           <Follow>k__BackingField  // 0x28
  private           Cinemachine.CameraState         <State>k__BackingField  // 0x30
METHODS:
  System.Void .ctor(Cinemachine.CameraState& state, System.String name)
  System.String get_Name()
  System.Void set_Name(System.String value)
  System.Int32 get_Priority()
  UnityEngine.Transform get_LookAt()
  UnityEngine.Transform get_Follow()
  Cinemachine.CameraState get_State()
  System.Void set_State(Cinemachine.CameraState value)
  UnityEngine.GameObject get_VirtualCameraGameObject()
  System.Boolean get_IsValid()
  Cinemachine.ICinemachineCamera get_ParentCamera()
  System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly)
  System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
END_CLASS

CLASS: Cinemachine.BlendSourceVirtualCamera
TYPE:  class
TOKEN: 0x2000068
FIELDS:
  private           Cinemachine.CinemachineBlend    <Blend>k__BackingField  // 0x10
  private           System.Int32                    <Priority>k__BackingField  // 0x18
  private           UnityEngine.Transform           <LookAt>k__BackingField  // 0x20
  private           UnityEngine.Transform           <Follow>k__BackingField  // 0x28
  private           Cinemachine.CameraState         <State>k__BackingField  // 0x30
METHODS:
  System.Void .ctor(Cinemachine.CinemachineBlend blend)
  Cinemachine.CinemachineBlend get_Blend()
  System.Void set_Blend(Cinemachine.CinemachineBlend value)
  System.String get_Name()
  System.Int32 get_Priority()
  UnityEngine.Transform get_LookAt()
  UnityEngine.Transform get_Follow()
  Cinemachine.CameraState get_State()
  System.Void set_State(Cinemachine.CameraState value)
  UnityEngine.GameObject get_VirtualCameraGameObject()
  System.Boolean get_IsValid()
  Cinemachine.ICinemachineCamera get_ParentCamera()
  System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly)
  System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
END_CLASS

CLASS: Cinemachine.CinemachineBlenderSettings
TYPE:  class
TOKEN: 0x2000069
EXTENDS: ScriptableObject
FIELDS:
  public            Cinemachine.CinemachineBlenderSettings.CustomBlend[]m_CustomBlends  // 0x18
  public            Cinemachine.CinemachineBlenderSettings.CustomBlendGroup[]m_CustomBlendGroups  // 0x20
  public    static  System.String                   kBlendFromAnyCameraLabel  // 0x0
METHODS:
  Cinemachine.CinemachineBlendDefinition GetBlendForVirtualCameras(System.String fromCameraName, System.String toCameraName, Cinemachine.CinemachineBlendDefinition defaultBlend)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineComponentBase
TYPE:  class
TOKEN: 0x200006C
EXTENDS: MonoBehaviour
FIELDS:
  protected static  System.Single                   Epsilon  // 0x0
  private           Cinemachine.CinemachineVirtualCameraBasem_vcamOwner  // 0x18
METHODS:
  Cinemachine.CinemachineVirtualCameraBase get_VirtualCamera()
  UnityEngine.Transform get_FollowTarget()
  UnityEngine.Transform get_LookAtTarget()
  Cinemachine.ICinemachineTargetGroup get_AbstractFollowTargetGroup()
  Cinemachine.CinemachineTargetGroup get_FollowTargetGroup()
  UnityEngine.Vector3 get_FollowTargetPosition()
  UnityEngine.Quaternion get_FollowTargetRotation()
  Cinemachine.ICinemachineTargetGroup get_AbstractLookAtTargetGroup()
  Cinemachine.CinemachineTargetGroup get_LookAtTargetGroup()
  UnityEngine.Vector3 get_LookAtTargetPosition()
  UnityEngine.Quaternion get_LookAtTargetRotation()
  Cinemachine.CameraState get_VcamState()
  System.Boolean get_IsValid()
  System.Void PrePipelineMutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  Cinemachine.CinemachineCore.Stage get_Stage()
  System.Boolean get_BodyAppliesAfterAim()
  System.Void MutateCameraState(Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime, Cinemachine.CinemachineVirtualCameraBase.TransitionParams& transitionParams)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Single GetMaxDampTime()
  System.Boolean get_RequiresUserInput()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineCore
TYPE:  class
TOKEN: 0x200006D
FIELDS:
  public    static readonly System.Int32                    kStreamingVersion  // 0x0
  public    static readonly System.String                   kVersionString  // 0x8
  private   static  Cinemachine.CinemachineCore     sInstance  // 0x10
  public    static  System.Boolean                  sShowHiddenObjects  // 0x18
  public    static  Cinemachine.CinemachineCore.AxisInputDelegateGetInputAxis  // 0x20
  public    static  System.Single                   UniformDeltaTimeOverride  // 0x28
  public    static  System.Single                   CurrentTimeOverride  // 0x2C
  public    static  Cinemachine.CinemachineCore.GetBlendOverrideDelegateGetBlendOverride  // 0x30
  public    static  Cinemachine.CinemachineBrain.BrainEventCameraUpdatedEvent  // 0x38
  public    static  Cinemachine.CinemachineBrain.BrainEventCameraCutEvent  // 0x40
  private           System.Collections.Generic.List<Cinemachine.CinemachineBrain>mActiveBrains  // 0x10
  private           System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase>mActiveCameras  // 0x18
  private           System.Boolean                  m_ActiveCamerasAreSorted  // 0x20
  private           System.Int32                    m_ActivationSequence  // 0x24
  private           System.Collections.Generic.List<System.Collections.Generic.List<Cinemachine.CinemachineVirtualCameraBase>>mAllCameras  // 0x28
  private           Cinemachine.CinemachineVirtualCameraBasemRoundRobinVcamLastFrame  // 0x30
  private   static  System.Single                   s_LastUpdateTime  // 0x48
  private   static  System.Int32                    s_FixedFrameCount  // 0x4C
  private           System.Collections.Generic.Dictionary<Cinemachine.CinemachineVirtualCameraBase,Cinemachine.CinemachineCore.UpdateStatus>mUpdateStatus  // 0x38
  private           Cinemachine.CinemachineCore.UpdateFilterm_CurrentUpdateFilter  // 0x40
METHODS:
  Cinemachine.CinemachineCore get_Instance()
  System.Single get_DeltaTime()
  System.Single get_CurrentTime()
  System.Int32 get_BrainCount()
  Cinemachine.CinemachineBrain GetActiveBrain(System.Int32 index)
  System.Void AddActiveBrain(Cinemachine.CinemachineBrain brain)
  System.Void RemoveActiveBrain(Cinemachine.CinemachineBrain brain)
  System.Int32 get_VirtualCameraCount()
  Cinemachine.CinemachineVirtualCameraBase GetVirtualCamera(System.Int32 index)
  System.Void AddActiveCamera(Cinemachine.CinemachineVirtualCameraBase vcam)
  System.Void RemoveActiveCamera(Cinemachine.CinemachineVirtualCameraBase vcam)
  System.Void CameraDestroyed(Cinemachine.CinemachineVirtualCameraBase vcam)
  System.Void CameraEnabled(Cinemachine.CinemachineVirtualCameraBase vcam)
  System.Void CameraDisabled(Cinemachine.CinemachineVirtualCameraBase vcam)
  System.Void UpdateAllActiveVirtualCameras(System.Int32 layerMask, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void UpdateVirtualCamera(Cinemachine.CinemachineVirtualCameraBase vcam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void InitializeModule()
  UnityEngine.Transform GetUpdateTarget(Cinemachine.CinemachineVirtualCameraBase vcam)
  Cinemachine.UpdateTracker.UpdateClock GetVcamUpdateStatus(Cinemachine.CinemachineVirtualCameraBase vcam)
  System.Boolean IsLive(Cinemachine.ICinemachineCamera vcam)
  System.Boolean IsLiveInBlend(Cinemachine.ICinemachineCamera vcam)
  System.Void GenerateCameraActivationEvent(Cinemachine.ICinemachineCamera vcam, Cinemachine.ICinemachineCamera vcamFrom)
  System.Void GenerateCameraCutEvent(Cinemachine.ICinemachineCamera vcam)
  Cinemachine.CinemachineBrain FindPotentialTargetBrain(Cinemachine.CinemachineVirtualCameraBase vcam)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Cinemachine.CinemachineExtension
TYPE:  class
TOKEN: 0x2000074
EXTENDS: MonoBehaviour
FIELDS:
  protected static  System.Single                   Epsilon  // 0x0
  private           Cinemachine.CinemachineVirtualCameraBasem_vcamOwner  // 0x18
  private           System.Collections.Generic.Dictionary<Cinemachine.ICinemachineCamera,System.Object>mExtraState  // 0x20
METHODS:
  Cinemachine.CinemachineVirtualCameraBase get_VirtualCamera()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDestroy()
  System.Void EnsureStarted()
  System.Void ConnectToVcam(System.Boolean connect)
  System.Void PrePipelineMutateCameraStateCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& curState, System.Single deltaTime)
  System.Void InvokePostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Boolean OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Single GetMaxDampTime()
  System.Boolean get_RequiresUserInput()
  T GetExtraState(Cinemachine.ICinemachineCamera vcam)
  System.Collections.Generic.List<T> GetAllExtraStates()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachinePathBase
TYPE:  class
TOKEN: 0x2000075
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Int32                    m_Resolution  // 0x18
  public            Cinemachine.CinemachinePathBase.Appearancem_Appearance  // 0x20
  private           System.Single[]                 m_DistanceToPos  // 0x28
  private           System.Single[]                 m_PosToDistance  // 0x30
  private           System.Int32                    m_CachedSampleSteps  // 0x38
  private           System.Single                   m_PathLength  // 0x3C
  private           System.Single                   m_cachedPosStepSize  // 0x40
  private           System.Single                   m_cachedDistanceStepSize  // 0x44
METHODS:
  System.Single get_MinPos()
  System.Single get_MaxPos()
  System.Boolean get_Looped()
  System.Single StandardizePos(System.Single pos)
  UnityEngine.Vector3 EvaluatePosition(System.Single pos)
  UnityEngine.Vector3 EvaluateTangent(System.Single pos)
  UnityEngine.Quaternion EvaluateOrientation(System.Single pos)
  System.Single FindClosestPoint(UnityEngine.Vector3 p, System.Int32 startSegment, System.Int32 searchRadius, System.Int32 stepsPerSegment)
  System.Single MinUnit(Cinemachine.CinemachinePathBase.PositionUnits units)
  System.Single MaxUnit(Cinemachine.CinemachinePathBase.PositionUnits units)
  System.Single StandardizeUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units)
  UnityEngine.Vector3 EvaluatePositionAtUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units)
  UnityEngine.Vector3 EvaluateTangentAtUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units)
  UnityEngine.Quaternion EvaluateOrientationAtUnit(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units)
  System.Int32 get_DistanceCacheSampleStepsPerSegment()
  System.Void InvalidateDistanceCache()
  System.Boolean DistanceCacheIsValid()
  System.Single get_PathLength()
  System.Single StandardizePathDistance(System.Single distance)
  System.Single ToNativePathUnits(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units)
  System.Single FromPathNativeUnits(System.Single pos, Cinemachine.CinemachinePathBase.PositionUnits units)
  System.Void ResamplePath(System.Int32 stepsPerSegment)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.AxisStatePropertyAttribute
TYPE:  class
TOKEN: 0x2000078
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.OrbitalTransposerHeadingPropertyAttribute
TYPE:  class
TOKEN: 0x2000079
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.VcamTargetPropertyAttribute
TYPE:  class
TOKEN: 0x200007A
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineBlendDefinitionPropertyAttribute
TYPE:  class
TOKEN: 0x200007B
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.SaveDuringPlayAttribute
TYPE:  class
TOKEN: 0x200007C
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.NoSaveDuringPlayAttribute
TYPE:  class
TOKEN: 0x200007D
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.TagFieldAttribute
TYPE:  class
TOKEN: 0x200007E
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.NoiseSettingsPropertyAttribute
TYPE:  class
TOKEN: 0x200007F
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineEmbeddedAssetPropertyAttribute
TYPE:  class
TOKEN: 0x2000080
EXTENDS: PropertyAttribute
FIELDS:
  public            System.Boolean                  WarnIfNull  // 0x10
METHODS:
  System.Void .ctor(System.Boolean warnIfNull)
END_CLASS

CLASS: Cinemachine.DocumentationSortingAttribute
TYPE:  class
TOKEN: 0x2000081
EXTENDS: Attribute
FIELDS:
  private           Cinemachine.DocumentationSortingAttribute.Level<Category>k__BackingField  // 0x10
METHODS:
  System.Void set_Category(Cinemachine.DocumentationSortingAttribute.Level value)
  System.Void .ctor(Cinemachine.DocumentationSortingAttribute.Level category)
END_CLASS

CLASS: Cinemachine.CinemachineVirtualCameraBase
TYPE:  class
TOKEN: 0x2000083
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String[]                 m_ExcludedPropertiesInInspector  // 0x18
  public            Cinemachine.CinemachineCore.Stage[]m_LockStageInInspector  // 0x20
  private           System.Int32                    m_ValidatingStreamVersion  // 0x28
  private           System.Boolean                  m_OnValidateCalled  // 0x2C
  private           System.Int32                    m_StreamingVersion  // 0x30
  public            System.Int32                    m_Priority  // 0x34
  private           System.Int32                    m_ActivationId  // 0x38
  public            System.Single                   FollowTargetAttachment  // 0x3C
  public            System.Single                   LookAtTargetAttachment  // 0x40
  protected         System.Boolean                  _ignoreLookAtBlend  // 0x44
  public            Cinemachine.CinemachineVirtualCameraBase.StandbyUpdateModem_StandbyUpdate  // 0x48
  private           System.Collections.Generic.List<Cinemachine.CinemachineExtension><mExtensions>k__BackingField  // 0x50
  private           System.Boolean                  <PreviousStateIsValid>k__BackingField  // 0x58
  private           System.Boolean                  m_WasStarted  // 0x59
  private           System.Boolean                  mSlaveStatusUpdated  // 0x5A
  private           Cinemachine.CinemachineVirtualCameraBasem_parentVcam  // 0x60
  private           System.Int32                    m_QueuePriority  // 0x68
  private           UnityEngine.Transform           m_CachedFollowTarget  // 0x70
  private           Cinemachine.CinemachineVirtualCameraBasem_CachedFollowTargetVcam  // 0x78
  private           Cinemachine.ICinemachineTargetGroupm_CachedFollowTargetGroup  // 0x80
  private           UnityEngine.Transform           m_CachedLookAtTarget  // 0x88
  private           Cinemachine.CinemachineVirtualCameraBasem_CachedLookAtTargetVcam  // 0x90
  private           Cinemachine.ICinemachineTargetGroupm_CachedLookAtTargetGroup  // 0x98
  private           System.Boolean                  <FollowTargetChanged>k__BackingField  // 0xA0
  private           System.Boolean                  <LookAtTargetChanged>k__BackingField  // 0xA1
METHODS:
  System.Int32 get_ValidatingStreamVersion()
  System.Void set_ValidatingStreamVersion(System.Int32 value)
  System.Single GetMaxDampTime()
  System.Single DetachedFollowTargetDamp(System.Single initial, System.Single dampTime, System.Single deltaTime)
  UnityEngine.Vector3 DetachedFollowTargetDamp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, System.Single deltaTime)
  UnityEngine.Vector3 DetachedFollowTargetDamp(UnityEngine.Vector3 initial, System.Single dampTime, System.Single deltaTime)
  System.Single DetachedLookAtTargetDamp(System.Single initial, System.Single dampTime, System.Single deltaTime)
  UnityEngine.Vector3 DetachedLookAtTargetDamp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, System.Single deltaTime)
  UnityEngine.Vector3 DetachedLookAtTargetDamp(UnityEngine.Vector3 initial, System.Single dampTime, System.Single deltaTime)
  System.Void AddExtension(Cinemachine.CinemachineExtension extension)
  System.Void RemoveExtension(Cinemachine.CinemachineExtension extension)
  System.Collections.Generic.List<Cinemachine.CinemachineExtension> get_mExtensions()
  System.Void set_mExtensions(System.Collections.Generic.List<Cinemachine.CinemachineExtension> value)
  System.Void InvokePostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& newState, System.Single deltaTime)
  System.Void InvokePrePipelineMutateCameraStateCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CameraState& newState, System.Single deltaTime)
  System.Boolean InvokeOnTransitionInExtensions(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.String get_Name()
  System.String get_Description()
  System.Int32 get_Priority()
  System.Void set_Priority(System.Int32 value)
  System.Void ApplyPositionBlendMethod(Cinemachine.CameraState& state, Cinemachine.CinemachineVirtualCameraBase.BlendHint hint)
  UnityEngine.GameObject get_VirtualCameraGameObject()
  System.Boolean get_IsValid()
  Cinemachine.CameraState get_State()
  Cinemachine.ICinemachineCamera get_ParentCamera()
  System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly)
  UnityEngine.Transform get_LookAt()
  System.Void set_LookAt(UnityEngine.Transform value)
  UnityEngine.Transform get_Follow()
  System.Void set_Follow(UnityEngine.Transform value)
  System.Boolean get_PreviousStateIsValid()
  System.Void set_PreviousStateIsValid(System.Boolean value)
  System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void InternalUpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void OnDestroy()
  System.Void OnTransformParentChanged()
  System.Void Start()
  System.Boolean RequiresUserInput()
  System.Void EnsureStarted()
  Cinemachine.AxisState.IInputAxisProvider GetInputAxisProvider()
  System.Void OnValidate()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void UpdateSlaveStatus()
  UnityEngine.Transform ResolveLookAt(UnityEngine.Transform localLookAt)
  UnityEngine.Transform ResolveFollow(UnityEngine.Transform localFollow)
  System.Void UpdateVcamPoolStatus()
  System.Void MoveToTopOfPrioritySubqueue()
  System.Void OnTargetObjectWarped(UnityEngine.Transform target, UnityEngine.Vector3 positionDelta)
  System.Void ForceCameraPosition(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  Cinemachine.CinemachineBlend CreateBlend(Cinemachine.ICinemachineCamera camA, Cinemachine.ICinemachineCamera camB, Cinemachine.CinemachineBlendDefinition blendDef, Cinemachine.CinemachineBlend activeBlend)
  Cinemachine.CameraState PullStateFromVirtualCamera(UnityEngine.Vector3 worldUp, Cinemachine.LensSettings& lens)
  System.Void InvalidateCachedTargets()
  System.Boolean get_FollowTargetChanged()
  System.Void set_FollowTargetChanged(System.Boolean value)
  System.Boolean get_LookAtTargetChanged()
  System.Void set_LookAtTargetChanged(System.Boolean value)
  System.Void UpdateTargetCache()
  Cinemachine.ICinemachineTargetGroup get_AbstractFollowTargetGroup()
  Cinemachine.CinemachineVirtualCameraBase get_FollowTargetAsVcam()
  Cinemachine.ICinemachineTargetGroup get_AbstractLookAtTargetGroup()
  Cinemachine.CinemachineVirtualCameraBase get_LookAtTargetAsVcam()
  System.Object GetCinemachineComponent()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.ConfinerOven
TYPE:  class
TOKEN: 0x2000088
FIELDS:
  private           System.Single                   m_MinFrustumHeightWithBones  // 0x10
  private           System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>m_OriginalPolygon  // 0x18
  private           System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>m_Skeleton  // 0x20
  private   static  System.Int64                    k_FloatToIntScaler  // 0x0
  private   static  System.Single                   k_IntToFloatScaler  // 0x0
  private   static  System.Single                   k_MinStepSize  // 0x0
  private           UnityEngine.Rect                m_PolygonRect  // 0x28
  private           Cinemachine.ConfinerOven.AspectStretcherm_AspectStretcher  // 0x38
  private           System.Single                   m_maxComputationTimeForFullSkeletonBakeInSeconds  // 0x44
  private           Cinemachine.ConfinerOven.BakingState<State>k__BackingField  // 0x48
  public            System.Single                   m_BakeProgress  // 0x4C
  private           Cinemachine.ConfinerOven.BakingStateCachem_Cache  // 0x50
METHODS:
  System.Void .ctor(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>& inputPath, System.Single& aspectRatio, System.Single maxFrustumHeight)
  Cinemachine.ConfinerOven.BakedSolution GetBakedSolution(System.Single frustumHeight)
  Cinemachine.ConfinerOven.BakingState get_State()
  System.Void set_State(Cinemachine.ConfinerOven.BakingState value)
  System.Void Initialize(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>& inputPath, System.Single& aspectRatio, System.Single maxFrustumHeight)
  System.Void BakeConfiner(System.Single maxComputationTimePerFrameInSeconds)
  UnityEngine.Rect GetPolygonBoundingBox(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>& polygons)
  System.Void ComputeSkeleton(System.Collections.Generic.List<Cinemachine.ConfinerOven.PolygonSolution>& solutions)
END_CLASS

CLASS: Cinemachine.ICinemachineCamera
TYPE:  interface
TOKEN: 0x200008E
FIELDS:
METHODS:
  System.String get_Name()
  System.Int32 get_Priority()
  UnityEngine.Transform get_LookAt()
  UnityEngine.Transform get_Follow()
  Cinemachine.CameraState get_State()
  UnityEngine.GameObject get_VirtualCameraGameObject()
  System.Boolean get_IsValid()
  Cinemachine.ICinemachineCamera get_ParentCamera()
  System.Boolean IsLiveChild(Cinemachine.ICinemachineCamera vcam, System.Boolean dominantChildOnly)
  System.Void UpdateCameraState(UnityEngine.Vector3 worldUp, System.Single deltaTime)
  System.Void OnTransitionFromCamera(Cinemachine.ICinemachineCamera fromCam, UnityEngine.Vector3 worldUp, System.Single deltaTime)
END_CLASS

CLASS: Cinemachine.LensSettings
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public    static  Cinemachine.LensSettings        Default  // 0x0
  public            System.Single                   FieldOfView  // 0x10
  public            System.Single                   OrthographicSize  // 0x14
  public            System.Single                   NearClipPlane  // 0x18
  public            System.Single                   FarClipPlane  // 0x1C
  public            System.Single                   Dutch  // 0x20
  public            Cinemachine.LensSettings.OverrideModesModeOverride  // 0x24
  public            UnityEngine.Vector2             LensShift  // 0x28
  public            UnityEngine.Camera.GateFitMode  GateFit  // 0x30
  private           UnityEngine.Vector2             m_SensorSize  // 0x34
  private           System.Boolean                  m_OrthoFromCamera  // 0x3C
  private           System.Boolean                  m_PhysicalFromCamera  // 0x3D
METHODS:
  System.Boolean get_Orthographic()
  UnityEngine.Vector2 get_SensorSize()
  System.Single get_Aspect()
  System.Boolean get_IsPhysicalCamera()
  Cinemachine.LensSettings FromCamera(UnityEngine.Camera fromCamera)
  System.Void SnapshotCameraReadOnlyProperties(UnityEngine.Camera camera)
  System.Void .ctor(System.Single verticalFOV, System.Single orthographicSize, System.Single nearClip, System.Single farClip, System.Single dutch)
  Cinemachine.LensSettings Lerp(Cinemachine.LensSettings lensA, Cinemachine.LensSettings lensB, System.Single t)
  System.Void Validate()
  System.Void .cctor()
END_CLASS

CLASS: Cinemachine.NoiseSettings
TYPE:  class
TOKEN: 0x2000091
EXTENDS: SignalSourceAsset
FIELDS:
  public            Cinemachine.NoiseSettings.TransformNoiseParams[]PositionNoise  // 0x18
  public            Cinemachine.NoiseSettings.TransformNoiseParams[]OrientationNoise  // 0x20
METHODS:
  UnityEngine.Vector3 GetCombinedFilterResults(Cinemachine.NoiseSettings.TransformNoiseParams[] noiseParams, System.Single time, UnityEngine.Vector3 timeOffsets)
  System.Single get_SignalDuration()
  System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.RuntimeUtility
TYPE:  class
TOKEN: 0x2000094
FIELDS:
  public    static  Cinemachine.RuntimeUtility.OverlapSphereNonAllocDelegateOverlapSphereNonAlloc  // 0x0
  public    static  Cinemachine.RuntimeUtility.RaycastDelegateRaycast  // 0x8
  public    static  Cinemachine.RuntimeUtility.RaycastNonAllocDelegateRaycastNonAlloc  // 0x10
  public    static  Cinemachine.RuntimeUtility.SphereCastNonAllocDelegateSphereCastNonAlloc  // 0x18
  public    static  Cinemachine.RuntimeUtility.ComputePenetrationDelegateComputePenetration  // 0x20
  public    static  System.Int32                    ignoreColliderOption  // 0x28
  private   static  UnityEngine.RaycastHit[]        s_HitBuffer  // 0x30
  private   static  System.Int32[]                  s_PenetrationIndexBuffer  // 0x38
  private   static  UnityEngine.SphereCollider      s_ScratchCollider  // 0x40
  private   static  UnityEngine.GameObject          s_ScratchColliderGameObject  // 0x48
METHODS:
  System.Void DestroyObject(UnityEngine.Object obj)
  System.Boolean IsPrefab(UnityEngine.GameObject gameObject)
  System.Boolean RaycastIgnoreTag(UnityEngine.Ray ray, UnityEngine.RaycastHit& hitInfo, System.Single rayLength, System.Int32 layerMask, System.String& ignoreTag)
  System.Int32 GetColliderOptionsFromHit(UnityEngine.RaycastHit hit)
  System.Boolean HasIgnoreColliderOptionFromHit(UnityEngine.RaycastHit hit)
  System.Boolean HasIgnoreColliderOptionFromCollider(UnityEngine.ECSColliderResultProxy collider)
  System.Boolean SphereCastIgnoreTag(UnityEngine.Vector3 rayStart, System.Single radius, UnityEngine.Vector3 dir, UnityEngine.RaycastHit& hitInfo, System.Single rayLength, System.Int32 layerMask, System.String& ignoreTag)
  UnityEngine.SphereCollider GetScratchCollider()
  System.Void DestroyScratchCollider()
  UnityEngine.AnimationCurve NormalizeCurve(UnityEngine.AnimationCurve curve, System.Boolean normalizeX, System.Boolean normalizeY)
  System.Void .cctor()
END_CLASS

CLASS: Cinemachine.ISignalSource6D
TYPE:  interface
TOKEN: 0x200009A
FIELDS:
METHODS:
  System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
END_CLASS

CLASS: Cinemachine.SignalSourceAsset
TYPE:  class
TOKEN: 0x200009B
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  System.Single get_SignalDuration()
  System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.TargetPositionCache
TYPE:  class
TOKEN: 0x200009C
FIELDS:
  public    static  System.Boolean                  UseCache  // 0x0
  private   static  Cinemachine.TargetPositionCache.Modem_CacheMode  // 0x4
  public    static  System.Single                   CurrentTime  // 0x8
  public    static  System.Int32                    CurrentFrame  // 0xC
  public    static  System.Boolean                  IsCameraCut  // 0x10
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Transform,Cinemachine.TargetPositionCache.CacheEntry>m_Cache  // 0x18
  private   static  Cinemachine.TargetPositionCache.TimeRangem_CacheTimeRange  // 0x20
METHODS:
  Cinemachine.TargetPositionCache.Mode get_CacheMode()
  System.Boolean get_HasCurrentTime()
  System.Void ClearCache()
  UnityEngine.Vector3 GetTargetPosition(UnityEngine.Transform target)
  UnityEngine.Quaternion GetTargetRotation(UnityEngine.Transform target)
END_CLASS

CLASS: Cinemachine.UpdateTracker
TYPE:  class
TOKEN: 0x20000A3
FIELDS:
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Transform,Cinemachine.UpdateTracker.UpdateStatus>mUpdateStatus  // 0x0
  private   static  System.Collections.Generic.List<UnityEngine.Transform>sToDelete  // 0x8
  private   static  System.Single                   mLastUpdateTime  // 0x10
METHODS:
  System.Void InitializeModule()
  System.Void UpdateTargets(Cinemachine.UpdateTracker.UpdateClock currentClock)
  Cinemachine.UpdateTracker.UpdateClock GetPreferredUpdate(UnityEngine.Transform target)
  System.Void OnUpdate(Cinemachine.UpdateTracker.UpdateClock currentClock)
  System.Void .cctor()
END_CLASS

CLASS: Cinemachine.CinemachineInputProvider
TYPE:  class
TOKEN: 0x20000A6
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Int32                    PlayerIndex  // 0x18
  public            System.Boolean                  AutoEnableInputs  // 0x1C
  public            UnityEngine.InputSystem.InputActionReferenceXYAxis  // 0x20
  public            UnityEngine.InputSystem.InputActionReferenceZAxis  // 0x28
  private   static  System.Int32                    NUM_AXES  // 0x0
  private           UnityEngine.InputSystem.InputAction[]m_cachedActions  // 0x30
METHODS:
  System.Single GetAxisValue(System.Int32 axis)
  UnityEngine.InputSystem.InputAction ResolveForPlayer(System.Int32 axis, UnityEngine.InputSystem.InputActionReference actionRef)
  System.Void OnDisable()
  System.Void .ctor()
  UnityEngine.InputSystem.InputAction <ResolveForPlayer>g__GetFirstMatch|7_0(UnityEngine.InputSystem.Users.InputUser& user, UnityEngine.InputSystem.InputActionReference aRef)
END_CLASS

CLASS: Cinemachine.CinemachineTriggerAction
TYPE:  class
TOKEN: 0x20000A8
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.LayerMask           m_LayerMask  // 0x18
  public            System.String                   m_WithTag  // 0x20
  public            System.String                   m_WithoutTag  // 0x28
  public            System.Int32                    m_SkipFirst  // 0x30
  public            System.Boolean                  m_Repeating  // 0x34
  public            Cinemachine.CinemachineTriggerAction.ActionSettingsm_OnObjectEnter  // 0x38
  public            Cinemachine.CinemachineTriggerAction.ActionSettingsm_OnObjectExit  // 0x60
  private           System.Collections.Generic.HashSet<UnityEngine.GameObject>m_ActiveTriggerObjects  // 0x88
METHODS:
  System.Boolean Filter(UnityEngine.GameObject other)
  System.Void InternalDoTriggerEnter(UnityEngine.GameObject other)
  System.Void InternalDoTriggerExit(UnityEngine.GameObject other)
  System.Void OnTriggerEnter(UnityEngine.Collider other)
  System.Void OnTriggerExit(UnityEngine.Collider other)
  System.Void OnCollisionEnter(UnityEngine.Collision other)
  System.Void OnCollisionExit(UnityEngine.Collision other)
  System.Void OnTriggerEnter2D(UnityEngine.Collider2D other)
  System.Void OnTriggerExit2D(UnityEngine.Collider2D other)
  System.Void OnCollisionEnter2D(UnityEngine.Collision2D other)
  System.Void OnCollisionExit2D(UnityEngine.Collision2D other)
  System.Void OnEnable()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.GroupWeightManipulator
TYPE:  class
TOKEN: 0x20000AD
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Single                   m_Weight0  // 0x18
  public            System.Single                   m_Weight1  // 0x1C
  public            System.Single                   m_Weight2  // 0x20
  public            System.Single                   m_Weight3  // 0x24
  public            System.Single                   m_Weight4  // 0x28
  public            System.Single                   m_Weight5  // 0x2C
  public            System.Single                   m_Weight6  // 0x30
  public            System.Single                   m_Weight7  // 0x34
  private           Cinemachine.CinemachineTargetGroupm_group  // 0x38
METHODS:
  System.Void Start()
  System.Void OnValidate()
  System.Void Update()
  System.Void UpdateWeights()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineCollisionImpulseSource
TYPE:  class
TOKEN: 0x20000AE
EXTENDS: CinemachineImpulseSource
FIELDS:
  public            UnityEngine.LayerMask           m_LayerMask  // 0x30
  public            System.String                   m_IgnoreTag  // 0x38
  public            System.Boolean                  m_UseImpactDirection  // 0x40
  public            System.Boolean                  m_ScaleImpactWithMass  // 0x41
  public            System.Boolean                  m_ScaleImpactWithSpeed  // 0x42
  private           UnityEngine.Rigidbody           mRigidBody  // 0x48
  private           UnityEngine.Rigidbody2D         mRigidBody2D  // 0x50
METHODS:
  System.Void Start()
  System.Void OnEnable()
  System.Void OnCollisionEnter(UnityEngine.Collision c)
  System.Void OnTriggerEnter(UnityEngine.Collider c)
  System.Single GetMassAndVelocity(UnityEngine.Collider other, UnityEngine.Vector3& vel)
  System.Void GenerateImpactEvent(UnityEngine.Collider other, UnityEngine.Vector3 vel)
  System.Void OnCollisionEnter2D(UnityEngine.Collision2D c)
  System.Void OnTriggerEnter2D(UnityEngine.Collider2D c)
  System.Single GetMassAndVelocity2D(UnityEngine.Collider2D other2d, UnityEngine.Vector3& vel)
  System.Void GenerateImpactEvent2D(UnityEngine.Collider2D other2d, UnityEngine.Vector3 vel)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineFixedSignal
TYPE:  class
TOKEN: 0x20000AF
EXTENDS: SignalSourceAsset
FIELDS:
  public            UnityEngine.AnimationCurve      m_XCurve  // 0x18
  public            UnityEngine.AnimationCurve      m_YCurve  // 0x20
  public            UnityEngine.AnimationCurve      m_ZCurve  // 0x28
METHODS:
  System.Single get_SignalDuration()
  System.Single AxisDuration(UnityEngine.AnimationCurve axis)
  System.Void GetSignal(System.Single timeSinceSignalStart, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
  System.Single AxisValue(UnityEngine.AnimationCurve axis, System.Single time)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineImpulseDefinition
TYPE:  class
TOKEN: 0x20000B0
FIELDS:
  public            System.Int32                    m_ImpulseChannel  // 0x10
  public            Cinemachine.CinemachineImpulseDefinition.ImpulseShapesm_ImpulseShape  // 0x14
  public            UnityEngine.AnimationCurve      m_CustomImpulseShape  // 0x18
  public            System.Single                   m_ImpulseDuration  // 0x20
  public            Cinemachine.CinemachineImpulseDefinition.ImpulseTypesm_ImpulseType  // 0x24
  public            System.Single                   m_DissipationRate  // 0x28
  public            Cinemachine.SignalSourceAsset   m_RawSignal  // 0x30
  public            System.Single                   m_AmplitudeGain  // 0x38
  public            System.Single                   m_FrequencyGain  // 0x3C
  public            Cinemachine.CinemachineImpulseDefinition.RepeatModem_RepeatMode  // 0x40
  public            System.Boolean                  m_Randomize  // 0x44
  public            Cinemachine.CinemachineImpulseManager.EnvelopeDefinitionm_TimeEnvelope  // 0x48
  public            System.Single                   m_ImpactRadius  // 0x68
  public            Cinemachine.CinemachineImpulseManager.ImpulseEvent.DirectionModem_DirectionMode  // 0x6C
  public            Cinemachine.CinemachineImpulseManager.ImpulseEvent.DissipationModem_DissipationMode  // 0x70
  public            System.Single                   m_DissipationDistance  // 0x74
  public            System.Single                   m_PropagationSpeed  // 0x78
  private   static  UnityEngine.AnimationCurve[]    sStandardShapes  // 0x0
METHODS:
  System.Void OnValidate()
  System.Void CreateStandardShapes()
  UnityEngine.AnimationCurve GetStandardCurve(Cinemachine.CinemachineImpulseDefinition.ImpulseShapes shape)
  UnityEngine.AnimationCurve get_ImpulseCurve()
  System.Void CreateEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity)
  Cinemachine.CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity)
  Cinemachine.CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineImpulseListener
TYPE:  class
TOKEN: 0x20000B6
EXTENDS: CinemachineExtension
FIELDS:
  public            Cinemachine.CinemachineCore.Stagem_ApplyAfter  // 0x28
  public            System.Int32                    m_ChannelMask  // 0x2C
  public            System.Single                   m_Gain  // 0x30
  public            System.Boolean                  m_Use2DDistance  // 0x34
  public            System.Boolean                  m_UseCameraSpace  // 0x35
  public            Cinemachine.CinemachineImpulseListener.ImpulseReactionm_ReactionSettings  // 0x38
METHODS:
  System.Void Reset()
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineImpulseChannelPropertyAttribute
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineImpulseManager
TYPE:  class
TOKEN: 0x20000B9
FIELDS:
  private   static  Cinemachine.CinemachineImpulseManagersInstance  // 0x0
  private           System.Collections.Generic.List<Cinemachine.CinemachineImpulseManager.ImpulseEvent>m_ExpiredEvents  // 0x10
  private           System.Collections.Generic.List<Cinemachine.CinemachineImpulseManager.ImpulseEvent>m_ActiveEvents  // 0x18
  public            System.Boolean                  IgnoreTimeScale  // 0x20
METHODS:
  System.Void .ctor()
  Cinemachine.CinemachineImpulseManager get_Instance()
  System.Void InitializeModule()
  System.Single EvaluateDissipationScale(System.Single spread, System.Single normalizedDistance)
  System.Boolean GetImpulseAt(UnityEngine.Vector3 listenerLocation, System.Boolean distance2D, System.Int32 channelMask, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
  System.Single get_CurrentTime()
  Cinemachine.CinemachineImpulseManager.ImpulseEvent NewImpulseEvent()
  System.Void AddImpulseEvent(Cinemachine.CinemachineImpulseManager.ImpulseEvent e)
  System.Void Clear()
END_CLASS

CLASS: Cinemachine.CinemachineImpulseSource
TYPE:  class
TOKEN: 0x20000BE
EXTENDS: MonoBehaviour
FIELDS:
  public            Cinemachine.CinemachineImpulseDefinitionm_ImpulseDefinition  // 0x18
  public            UnityEngine.Vector3             m_DefaultVelocity  // 0x20
METHODS:
  System.Void OnValidate()
  System.Void Reset()
  System.Void GenerateImpulseAtPositionWithVelocity(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity)
  System.Void GenerateImpulseWithVelocity(UnityEngine.Vector3 velocity)
  System.Void GenerateImpulseWithForce(System.Single force)
  System.Void GenerateImpulse()
  System.Void GenerateImpulseAt(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity)
  System.Void GenerateImpulse(UnityEngine.Vector3 velocity)
  System.Void GenerateImpulse(System.Single force)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.CinemachineIndependentImpulseListener
TYPE:  class
TOKEN: 0x20000BF
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Vector3             impulsePosLastFrame  // 0x18
  private           UnityEngine.Quaternion          impulseRotLastFrame  // 0x24
  public            System.Int32                    m_ChannelMask  // 0x34
  public            System.Single                   m_Gain  // 0x38
  public            System.Boolean                  m_Use2DDistance  // 0x3C
  public            System.Boolean                  m_UseLocalSpace  // 0x3D
  public            Cinemachine.CinemachineImpulseListener.ImpulseReactionm_ReactionSettings  // 0x40
METHODS:
  System.Void Reset()
  System.Void OnEnable()
  System.Void Update()
  System.Void LateUpdate()
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.PostFX.CinemachinePostProcessing
TYPE:  class
TOKEN: 0x20000C0
EXTENDS: CinemachineExtension
FIELDS:
METHODS:
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.PostFX.CinemachineVolumeSettings
TYPE:  class
TOKEN: 0x20000C1
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.Utility.CinemachineDebug
TYPE:  class
TOKEN: 0x20000C2
FIELDS:
  private   static  System.Collections.Generic.HashSet<UnityEngine.Object>mClients  // 0x0
  public    static  Cinemachine.Utility.CinemachineDebug.OnGUIDelegateOnGUIHandlers  // 0x8
  private   static  System.Collections.Generic.List<System.Text.StringBuilder>mAvailableStringBuilders  // 0x10
METHODS:
  System.Void ReleaseScreenPos(UnityEngine.Object client)
  UnityEngine.Rect GetScreenPos(UnityEngine.Object client, System.String text, UnityEngine.GUIStyle style)
  System.Text.StringBuilder SBFromPool()
  System.Void ReturnToPool(System.Text.StringBuilder sb)
END_CLASS

CLASS: Cinemachine.Utility.PositionPredictor
TYPE:  class
TOKEN: 0x20000C4
FIELDS:
  private           UnityEngine.Vector3             m_Velocity  // 0x10
  private           UnityEngine.Vector3             m_SmoothDampVelocity  // 0x1C
  private           UnityEngine.Vector3             m_Pos  // 0x28
  private           System.Boolean                  m_HavePos  // 0x34
  public            System.Single                   Smoothing  // 0x38
METHODS:
  System.Void ApplyTransformDelta(UnityEngine.Vector3 positionDelta)
  System.Void Reset()
  System.Void AddPosition(UnityEngine.Vector3 pos, System.Single deltaTime, System.Single lookaheadTime)
  UnityEngine.Vector3 PredictPositionDelta(System.Single lookaheadTime)
  System.Void .ctor()
END_CLASS

CLASS: Cinemachine.Utility.Damper
TYPE:  class
TOKEN: 0x20000C5
FIELDS:
METHODS:
  System.Single Damp(System.Single initial, System.Single dampTime, System.Single deltaTime)
  UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, System.Single deltaTime)
  UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, System.Single dampTime, System.Single deltaTime)
END_CLASS

CLASS: Cinemachine.Utility.HeadingTracker
TYPE:  class
TOKEN: 0x20000C6
FIELDS:
  private           Cinemachine.Utility.HeadingTracker.Item[]mHistory  // 0x10
  private           System.Int32                    mTop  // 0x18
  private           System.Int32                    mBottom  // 0x1C
  private           System.Int32                    mCount  // 0x20
  private           UnityEngine.Vector3             mHeadingSum  // 0x24
  private           System.Single                   mWeightSum  // 0x30
  private           System.Single                   mWeightTime  // 0x34
  private           UnityEngine.Vector3             mLastGoodHeading  // 0x38
  private   static  System.Single                   mDecayExponent  // 0x0
METHODS:
  System.Void .ctor(System.Int32 filterSize)
  System.Int32 get_FilterSize()
  System.Void ClearHistory()
  System.Single Decay(System.Single time)
  System.Void Add(UnityEngine.Vector3 velocity)
  System.Void PopBottom()
  System.Void DecayHistory()
  UnityEngine.Vector3 GetReliableHeading()
END_CLASS

CLASS: Cinemachine.Utility.SplineHelpers
TYPE:  class
TOKEN: 0x20000C8
FIELDS:
METHODS:
  UnityEngine.Vector3 Bezier3(System.Single t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
  UnityEngine.Vector3 BezierTangent3(System.Single t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
  System.Single Bezier1(System.Single t, System.Single p0, System.Single p1, System.Single p2, System.Single p3)
  System.Void ComputeSmoothControlPoints(UnityEngine.Vector4[]& knot, UnityEngine.Vector4[]& ctrl1, UnityEngine.Vector4[]& ctrl2)
  System.Void ComputeSmoothControlPointsLooped(UnityEngine.Vector4[]& knot, UnityEngine.Vector4[]& ctrl1, UnityEngine.Vector4[]& ctrl2)
END_CLASS

CLASS: Cinemachine.Utility.UnityVectorExtensions
TYPE:  class
TOKEN: 0x20000C9
FIELDS:
METHODS:
  System.Boolean IsNaN(UnityEngine.Vector3 v)
  System.Single ClosestPointOnSegment(UnityEngine.Vector3 p, UnityEngine.Vector3 s0, UnityEngine.Vector3 s1)
  System.Single ClosestPointOnSegment(UnityEngine.Vector2 p, UnityEngine.Vector2 s0, UnityEngine.Vector2 s1)
  UnityEngine.Vector3 ProjectOntoPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal)
  UnityEngine.Vector2 Abs(UnityEngine.Vector2 v)
  System.Boolean IsUniform(UnityEngine.Vector2 v)
  System.Boolean AlmostZero(UnityEngine.Vector3 v)
  System.Single Angle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
  System.Single SignedAngle(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 up)
  UnityEngine.Quaternion SafeFromToRotation(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 up)
END_CLASS

CLASS: Cinemachine.Utility.UnityQuaternionExtensions
TYPE:  class
TOKEN: 0x20000CA
FIELDS:
METHODS:
  UnityEngine.Quaternion SlerpWithReferenceUp(UnityEngine.Quaternion qA, UnityEngine.Quaternion qB, System.Single t, UnityEngine.Vector3 up)
  UnityEngine.Quaternion Normalized(UnityEngine.Quaternion q)
  UnityEngine.Vector2 GetCameraRotationToTarget(UnityEngine.Quaternion orient, UnityEngine.Vector3 lookAtDir, UnityEngine.Vector3 worldUp)
  UnityEngine.Quaternion ApplyCameraRotation(UnityEngine.Quaternion orient, UnityEngine.Vector2 rot, UnityEngine.Vector3 worldUp)
END_CLASS

