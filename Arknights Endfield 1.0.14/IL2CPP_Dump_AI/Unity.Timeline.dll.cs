// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Timeline.dll
// Classes:  180
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: PostPlaybackState
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.ActivationTrack.PostPlaybackStateActive  // 0x0
  public    static  UnityEngine.Timeline.ActivationTrack.PostPlaybackStateInactive  // 0x0
  public    static  UnityEngine.Timeline.ActivationTrack.PostPlaybackStateRevert  // 0x0
  public    static  UnityEngine.Timeline.ActivationTrack.PostPlaybackStateLeaveAsIs  // 0x0
METHODS:
END_CLASS

CLASS: WeightInfo
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            UnityEngine.Playables.Playable  mixer  // 0x10
  public            UnityEngine.Playables.Playable  parentMixer  // 0x20
  public            System.Int32                    port  // 0x30
METHODS:
END_CLASS

CLASS: LoopMode
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.LoopModeUseSourceAsset  // 0x0
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.LoopModeOn  // 0x0
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.LoopModeOff  // 0x0
METHODS:
END_CLASS

CLASS: ClothResetOption
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOptionSoftReset  // 0x0
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOptionUseClothRelativeTeleport  // 0x0
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOptionUseStablizationTime  // 0x0
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOptionDisablePhysics  // 0x0
METHODS:
END_CLASS

CLASS: Versions
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.VersionsInitial  // 0x0
  public    static  UnityEngine.Timeline.AnimationPlayableAsset.VersionsRotationAsEuler  // 0x0
METHODS:
END_CLASS

CLASS: AnimationPlayableAssetUpgrade
TYPE:  class
TOKEN: 0x2000022
FIELDS:
METHODS:
  System.Void ConvertRotationToEuler(UnityEngine.Timeline.AnimationPlayableAsset asset)
END_CLASS

CLASS: AnimationTrackUpgrade
TYPE:  class
TOKEN: 0x200002A
FIELDS:
METHODS:
  System.Void ConvertRotationsToEuler(UnityEngine.Timeline.AnimationTrack track)
  System.Void ConvertRootMotion(UnityEngine.Timeline.AnimationTrack track)
  System.Void ConvertInfiniteTrack(UnityEngine.Timeline.AnimationTrack track)
END_CLASS

CLASS: Versions
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineClip.VersionsInitial  // 0x0
  public    static  UnityEngine.Timeline.TimelineClip.VersionsClipInFromGlobalToLocal  // 0x0
METHODS:
END_CLASS

CLASS: TimelineClipUpgrade
TYPE:  class
TOKEN: 0x200002F
FIELDS:
METHODS:
  System.Void UpgradeClipInFromGlobalToLocal(UnityEngine.Timeline.TimelineClip clip)
END_CLASS

CLASS: ClipExtrapolation
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineClip.ClipExtrapolationNone  // 0x0
  public    static  UnityEngine.Timeline.TimelineClip.ClipExtrapolationHold  // 0x0
  public    static  UnityEngine.Timeline.TimelineClip.ClipExtrapolationLoop  // 0x0
  public    static  UnityEngine.Timeline.TimelineClip.ClipExtrapolationPingPong  // 0x0
  public    static  UnityEngine.Timeline.TimelineClip.ClipExtrapolationContinue  // 0x0
METHODS:
END_CLASS

CLASS: BlendCurveMode
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineClip.BlendCurveModeAuto  // 0x0
  public    static  UnityEngine.Timeline.TimelineClip.BlendCurveModeManual  // 0x0
METHODS:
END_CLASS

CLASS: Versions
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineAsset.VersionsInitial  // 0x0
METHODS:
END_CLASS

CLASS: TimelineAssetUpgrade
TYPE:  class
TOKEN: 0x2000034
FIELDS:
METHODS:
END_CLASS

CLASS: MediaType
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeAnimation  // 0x0
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeAudio  // 0x0
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeTexture  // 0x0
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeVideo  // 0x0
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeScript  // 0x0
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeHybrid  // 0x0
  public    static  UnityEngine.Timeline.TimelineAsset.MediaTypeGroup  // 0x0
METHODS:
END_CLASS

CLASS: DurationMode
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimelineAsset.DurationModeBasedOnClips  // 0x0
  public    static  UnityEngine.Timeline.TimelineAsset.DurationModeFixedLength  // 0x0
METHODS:
END_CLASS

CLASS: EditorSettings
TYPE:  class
TOKEN: 0x2000037
FIELDS:
  private   static readonly System.Double                   kMinFrameRate  // 0x0
  private   static readonly System.Double                   kMaxFrameRate  // 0x8
  private   static readonly System.Double                   kDefaultFrameRate  // 0x10
  private           System.Double                   m_Framerate  // 0x10
  private           System.Boolean                  m_ScenePreview  // 0x18
METHODS:
  System.Double get_frameRate()
  System.Void set_frameRate(System.Double value)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Versions
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TrackAsset.VersionsInitial  // 0x0
  public    static  UnityEngine.Timeline.TrackAsset.VersionsRotationAsEuler  // 0x0
  public    static  UnityEngine.Timeline.TrackAsset.VersionsRootMotionUpgrade  // 0x0
  public    static  UnityEngine.Timeline.TrackAsset.VersionsAnimatedTrackProperties  // 0x0
METHODS:
END_CLASS

CLASS: TrackAssetUpgrade
TYPE:  class
TOKEN: 0x200003B
FIELDS:
METHODS:
END_CLASS

CLASS: TransientBuildData
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset>trackList  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip>clipList  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Timeline.IMarker>markerList  // 0x20
METHODS:
  UnityEngine.Timeline.TrackAsset.TransientBuildData Create()
  System.Void Clear()
END_CLASS

CLASS: DescriptorBlendTreeType
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeTypeDirect  // 0x0
  public    static  UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeTypeSimple1D  // 0x0
  public    static  UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeTypeSimple2D  // 0x0
  public    static  UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeTypeComplex2D  // 0x0
METHODS:
END_CLASS

CLASS: TransformAdditive
TYPE:  class
TOKEN: 0x2000057
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector3             rotationEuler  // 0x1C
  public            UnityEngine.Vector3             scale  // 0x28
METHODS:
  System.Void .ctor()
  System.Void Reset()
  System.Boolean HasChanges()
END_CLASS

CLASS: TransformAdditive
TYPE:  class
TOKEN: 0x2000059
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector3             rotationEular  // 0x1C
  public            UnityEngine.Vector3             scale  // 0x28
METHODS:
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: AnimationCurveInfo
TYPE:  class
TOKEN: 0x200005C
FIELDS:
  public            System.String                   path  // 0x10
  public            System.String                   propertyName  // 0x18
  public            UnityEngine.AnimationCurve      curve  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Entry
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            System.Int64                    intervalStart  // 0x0
  public            System.Int64                    intervalEnd  // 0x0
  public            T                               item  // 0x0
METHODS:
END_CLASS

CLASS: EventKeyValue
TYPE:  class
TOKEN: 0x2000078
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Timeline.SignalAsset>m_Signals  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Events.UnityEvent>m_Events  // 0x18
METHODS:
  System.Boolean TryGetValue(UnityEngine.Timeline.SignalAsset key, UnityEngine.Events.UnityEvent& value)
  System.Void Append(UnityEngine.Timeline.SignalAsset key, UnityEngine.Events.UnityEvent value)
  System.Void Remove(System.Int32 idx)
  System.Void Remove(UnityEngine.Timeline.SignalAsset key)
  System.Collections.Generic.List<UnityEngine.Timeline.SignalAsset> get_signals()
  System.Collections.Generic.List<UnityEngine.Events.UnityEvent> get_events()
  System.Void .ctor()
END_CLASS

CLASS: PostPlaybackState
TYPE:  struct
TOKEN: 0x200007E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackStateActive  // 0x0
  public    static  UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackStateInactive  // 0x0
  public    static  UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackStateRevert  // 0x0
METHODS:
END_CLASS

CLASS: InitialState
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.ActivationControlPlayable.InitialStateUnset  // 0x0
  public    static  UnityEngine.Timeline.ActivationControlPlayable.InitialStateActive  // 0x0
  public    static  UnityEngine.Timeline.ActivationControlPlayable.InitialStateInactive  // 0x0
METHODS:
END_CLASS

CLASS: NotificationEntry
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Double                   time  // 0x10
  public            UnityEngine.Playables.INotificationpayload  // 0x18
  public            System.Boolean                  notificationFired  // 0x20
  public            UnityEngine.Timeline.NotificationFlagsflags  // 0x22
METHODS:
  System.Boolean get_triggerInEditor()
  System.Boolean get_prewarm()
  System.Boolean get_triggerOnce()
END_CLASS

CLASS: UseEditMode
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TimeFieldAttribute.UseEditModeNone  // 0x0
  public    static  UnityEngine.Timeline.TimeFieldAttribute.UseEditModeApplyEditMode  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Core.DontAutoBindAttribute
TYPE:  class
TOKEN: 0x200000E
EXTENDS: DontAutoBindRuntimeAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.DontAutoBindRuntimeAttribute
TYPE:  class
TOKEN: 0x200000F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeJumpBehaviour
TYPE:  class
TOKEN: 0x2000010
EXTENDS: PlayableBehaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeJumpClip
TYPE:  class
TOKEN: 0x2000011
EXTENDS: PlayableAsset
FIELDS:
  public            System.Boolean                  isReverseJump  // 0x18
  public            System.Boolean                  needChangeOptionAfterJump  // 0x19
  public            System.Int32                    optionIndexAfterJump  // 0x1C
  public            System.Double                   crossFadeDurationAfterJump  // 0x20
  public            System.Boolean                  isJumpFirst  // 0x28
METHODS:
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeJumpTrack
TYPE:  class
TOKEN: 0x2000012
EXTENDS: TrackAsset
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeLoopBehaviour
TYPE:  class
TOKEN: 0x2000013
EXTENDS: PlayableBehaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeLoopClip
TYPE:  class
TOKEN: 0x2000014
EXTENDS: PlayableAsset
FIELDS:
  public            System.Double                   crossFadeDuration  // 0x18
METHODS:
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.RuntimeLoopTrack
TYPE:  class
TOKEN: 0x2000015
EXTENDS: TrackAsset
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Core.TimelineNPCLookAtController
TYPE:  class
TOKEN: 0x2000016
EXTENDS: MonoBehaviour
FIELDS:
  private   static readonly System.Collections.Generic.HashSet<Beyond.Gameplay.Core.TimelineNPCLookAtController>s_instances  // 0x0
  public            System.Boolean                  m_lookAtDirty  // 0x18
  public            ScriptAnimation.TimelineNPCLookAtTargetlookAtTarget  // 0x20
  public            ScriptAnimation.TimelineNPCLookAtEyeTargetlookAtEyeTarget  // 0x28
  public            System.Boolean                  lookAtEnabled  // 0x30
  public            System.Boolean                  lookAtEyeEnabled  // 0x31
METHODS:
  System.Collections.Generic.IEnumerable<Beyond.Gameplay.Core.TimelineNPCLookAtController> get_Instances()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean get_lookAtDirty()
  System.Void set_lookAtDirty(System.Boolean value)
  System.Single get_lookAtWeight()
  System.Void set_lookAtWeight(System.Single value)
  System.Single get_lookAtBodyWeight()
  System.Void set_lookAtBodyWeight(System.Single value)
  System.Single get_lookAtRoll()
  System.Void set_lookAtRoll(System.Single value)
  System.Single get_lookAtHorizontal()
  System.Void set_lookAtHorizontal(System.Single value)
  System.Single get_lookAtVertical()
  System.Void set_lookAtVertical(System.Single value)
  System.Single get_lookAtEyeWeight()
  System.Void set_lookAtEyeWeight(System.Single value)
  System.Boolean get_lookAtUseDegree()
  System.Void set_lookAtUseDegree(System.Boolean value)
  System.Boolean get_EyeUseDegree()
  System.Void set_EyeUseDegree(System.Boolean value)
  System.Single get_lookAtEyeUp()
  System.Void set_lookAtEyeUp(System.Single value)
  System.Single get_lookAtEyeDown()
  System.Void set_lookAtEyeDown(System.Single value)
  UnityEngine.Vector3 get_finalPosition()
  System.Void set_finalPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_finalEyePosition()
  System.Void set_finalEyePosition(UnityEngine.Vector3 value)
  System.Void MarkLookAtDirty()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x200000A
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x200000B
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x200000C
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x200000D
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Events.INotificationTrack
TYPE:  interface
TOKEN: 0x2000008
FIELDS:
METHODS:
END_CLASS

CLASS: Events.ITimelineNotification
TYPE:  interface
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Void OnNotify()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ScriptAnimation.TimelineNPCClothWeightController
TYPE:  class
TOKEN: 0x2000003
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  forceSetPhysicsClothWeight  // 0x18
  public            System.Single                   physicsClothWeight  // 0x1C
  public            System.Boolean                  forceSetLoopBodyAddWeight  // 0x20
  public            System.Single                   loopBodyAddWeight  // 0x24
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ScriptAnimation.TimelineNPCLookAtEyeTarget
TYPE:  class
TOKEN: 0x2000004
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Single                   lookAtWeight  // 0x18
  public            System.Boolean                  useDegree  // 0x1C
  public            System.Single                   lookAtUp  // 0x20
  public            System.Single                   lookAtDown  // 0x24
METHODS:
  System.Void ResetLookAtWeight()
  System.Void .ctor()
END_CLASS

CLASS: ScriptAnimation.TimelineNPCLookAtTarget
TYPE:  class
TOKEN: 0x2000005
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Single                   lookAtWeight  // 0x18
  public            System.Single                   lookAtBodyWeight  // 0x1C
  public            System.Boolean                  useDegree  // 0x20
  public            System.Single                   lookAtHorizontal  // 0x24
  public            System.Single                   lookAtVertical  // 0x28
  public            System.Single                   lookAtRoll  // 0x2C
METHODS:
  System.Void ResetLookAtWeight()
  System.Void .ctor()
END_CLASS

CLASS: ScriptAnimation.ScriptAnimationApply.ScriptAnimationApplyBehaviour
TYPE:  class
TOKEN: 0x2000006
EXTENDS: PlayableBehaviour
FIELDS:
  private           UnityEngine.Timeline.IScriptAnimationJobSyncm_JobSync  // 0x10
METHODS:
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void InitBehaviour(UnityEngine.Timeline.IScriptAnimationJobSync jobSync)
  System.Void .ctor()
END_CLASS

CLASS: ScriptAnimation.ScriptAnimationApply.ScriptAnimationApplyPlayable
TYPE:  class
TOKEN: 0x2000007
EXTENDS: PlayableAsset
FIELDS:
METHODS:
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.PlayerLoopChecker
TYPE:  class
TOKEN: 0x2000017
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.ActivationMixerPlayable
TYPE:  class
TOKEN: 0x2000018
EXTENDS: PlayableBehaviour
FIELDS:
  private           UnityEngine.Timeline.ActivationTrack.PostPlaybackStatem_PostPlaybackState  // 0x10
  private           System.Boolean                  m_BoundGameObjectInitialStateIsActive  // 0x14
  private           UnityEngine.GameObject          m_BoundGameObject  // 0x18
METHODS:
  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ActivationMixerPlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  System.Void set_postPlaybackState(UnityEngine.Timeline.ActivationTrack.PostPlaybackState value)
  System.Void SetBoundGameObject(UnityEngine.GameObject go)
  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void _DoSetActive(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ActivationPlayableAsset
TYPE:  class
TOKEN: 0x2000019
EXTENDS: PlayableAsset
FIELDS:
METHODS:
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ActivationTrack
TYPE:  class
TOKEN: 0x200001A
EXTENDS: TrackAsset
FIELDS:
  private           UnityEngine.Timeline.ActivationTrack.PostPlaybackStatem_PostPlaybackState  // 0xC0
  private           UnityEngine.Timeline.ActivationMixerPlayablem_ActivationMixer  // 0xC8
METHODS:
  System.Boolean CanCompileClips()
  UnityEngine.Timeline.ActivationTrack.PostPlaybackState get_postPlaybackState()
  System.Void set_postPlaybackState(UnityEngine.Timeline.ActivationTrack.PostPlaybackState value)
  UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  UnityEngine.GameObject GetBinding(UnityEngine.Playables.PlayableDirector director)
  System.Void UpdateTrackMode()
  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AnimationOutputWeightProcessor
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  private           UnityEngine.Animator            m_outputAnimator  // 0x10
  private           UnityEngine.Animations.AnimationPlayableOutputm_Output  // 0x18
  private   readonly System.Collections.Generic.List<UnityEngine.Timeline.AnimationOutputWeightProcessor.WeightInfo>m_Mixers  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.Animations.AnimationPlayableOutput output, UnityEngine.Animator animator)
  System.Void FindMixers()
  System.Void FindMixers(UnityEngine.Playables.Playable parent, System.Int32 port, UnityEngine.Playables.Playable node)
  System.Void Evaluate()
END_CLASS

CLASS: UnityEngine.Timeline.AnimationPlayableAsset
TYPE:  class
TOKEN: 0x200001E
EXTENDS: PlayableAsset
FIELDS:
  private           UnityEngine.AnimationClip       m_Clip  // 0x18
  private           UnityEngine.Vector3             m_Position  // 0x20
  private           UnityEngine.Vector3             m_EulerAngles  // 0x2C
  private           System.Boolean                  m_UseTrackMatchFields  // 0x38
  private           UnityEngine.Timeline.MatchTargetFieldsm_MatchTargetFields  // 0x3C
  private           System.Boolean                  m_RemoveStartOffset  // 0x40
  private           System.Boolean                  m_ApplyFootIK  // 0x41
  private           UnityEngine.Timeline.AnimationPlayableAsset.LoopModem_Loop  // 0x44
  private           System.Boolean                  m_IgniteOnce  // 0x48
  private           System.Boolean                  m_OnlyDeltaTime  // 0x49
  private           System.Boolean                  m_DynamicLink  // 0x4A
  private           UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOptionm_ClothResetOption  // 0x4C
  private           UnityEngine.Timeline.AppliedOffsetMode<appliedOffsetMode>k__BackingField  // 0x50
  private   static readonly System.Int32                    k_LatestVersion  // 0x0
  private           System.Int32                    m_Version  // 0x54
  private           UnityEngine.Quaternion          m_Rotation  // 0x58
METHODS:
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
  UnityEngine.Vector3 get_eulerAngles()
  System.Void set_eulerAngles(UnityEngine.Vector3 value)
  System.Boolean get_useTrackMatchFields()
  System.Void set_useTrackMatchFields(System.Boolean value)
  UnityEngine.Timeline.MatchTargetFields get_matchTargetFields()
  System.Void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value)
  System.Boolean get_removeStartOffset()
  System.Void set_removeStartOffset(System.Boolean value)
  System.Boolean get_applyFootIK()
  System.Void set_applyFootIK(System.Boolean value)
  UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_loop()
  System.Void set_loop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value)
  System.Boolean get_IgniteOnce()
  System.Void set_IgniteOnce(System.Boolean value)
  System.Boolean get_OnlyDeltaTime()
  System.Void set_OnlyDeltaTime(System.Boolean value)
  System.Boolean get_DynamicLink()
  System.Void set_DynamicLink(System.Boolean value)
  System.Boolean get_hasRootTransforms()
  UnityEngine.Timeline.AppliedOffsetMode get_appliedOffsetMode()
  System.Void set_appliedOffsetMode(UnityEngine.Timeline.AppliedOffsetMode value)
  UnityEngine.AnimationClip get_clip()
  System.Void set_clip(UnityEngine.AnimationClip value)
  System.Double get_duration()
  UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption get_clothResetOption()
  System.Void set_clothResetOption(UnityEngine.Timeline.AnimationPlayableAsset.ClothResetOption value)
  System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs()
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Vector3 positionOffset, UnityEngine.Vector3 eulerOffset, System.Boolean removeStartOffset, UnityEngine.Timeline.AppliedOffsetMode mode, System.Boolean applyFootIK, UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop)
  System.Boolean ShouldApplyOffset(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.AnimationClip clip)
  System.Boolean ShouldApplyScaleRemove(UnityEngine.Timeline.AppliedOffsetMode mode)
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  System.Void ResetOffsets()
  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  System.Boolean HasRootTransforms(UnityEngine.AnimationClip clip)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void OnUpgradeFromVersion(System.Int32 oldVersion)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.AnimationPreviewUpdateCallback
TYPE:  class
TOKEN: 0x2000024
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.MatchTargetFields
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.MatchTargetFieldsPositionX  // 0x0
  public    static  UnityEngine.Timeline.MatchTargetFieldsPositionY  // 0x0
  public    static  UnityEngine.Timeline.MatchTargetFieldsPositionZ  // 0x0
  public    static  UnityEngine.Timeline.MatchTargetFieldsRotationX  // 0x0
  public    static  UnityEngine.Timeline.MatchTargetFieldsRotationY  // 0x0
  public    static  UnityEngine.Timeline.MatchTargetFieldsRotationZ  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TrackOffset
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TrackOffsetApplyTransformOffsets  // 0x0
  public    static  UnityEngine.Timeline.TrackOffsetApplySceneOffsets  // 0x0
  public    static  UnityEngine.Timeline.TrackOffsetAuto  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.AppliedOffsetMode
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.AppliedOffsetModeNoRootTransform  // 0x0
  public    static  UnityEngine.Timeline.AppliedOffsetModeTransformOffset  // 0x0
  public    static  UnityEngine.Timeline.AppliedOffsetModeSceneOffset  // 0x0
  public    static  UnityEngine.Timeline.AppliedOffsetModeTransformOffsetLegacy  // 0x0
  public    static  UnityEngine.Timeline.AppliedOffsetModeSceneOffsetLegacy  // 0x0
  public    static  UnityEngine.Timeline.AppliedOffsetModeSceneOffsetEditor  // 0x0
  public    static  UnityEngine.Timeline.AppliedOffsetModeSceneOffsetLegacyEditor  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.MatchTargetFieldConstants
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  public    static  UnityEngine.Timeline.MatchTargetFieldsAll  // 0x0
  public    static  UnityEngine.Timeline.MatchTargetFieldsNone  // 0x4
  public    static  UnityEngine.Timeline.MatchTargetFieldsPosition  // 0x8
  public    static  UnityEngine.Timeline.MatchTargetFieldsRotation  // 0xC
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.AnimationTrack
TYPE:  class
TOKEN: 0x2000029
EXTENDS: TrackAsset
FIELDS:
  private   static  System.String                   k_DefaultInfiniteClipName  // 0x0
  private   static  System.String                   k_DefaultRecordableClipName  // 0x0
  private           UnityEngine.Timeline.TimelineClip.ClipExtrapolationm_InfiniteClipPreExtrapolation  // 0xC0
  private           UnityEngine.Timeline.TimelineClip.ClipExtrapolationm_InfiniteClipPostExtrapolation  // 0xC4
  private           UnityEngine.Vector3             m_InfiniteClipOffsetPosition  // 0xC8
  private           UnityEngine.Vector3             m_InfiniteClipOffsetEulerAngles  // 0xD4
  private           System.Double                   m_InfiniteClipTimeOffset  // 0xE0
  private           System.Boolean                  m_InfiniteClipRemoveOffset  // 0xE8
  private           System.Boolean                  m_InfiniteClipApplyFootIK  // 0xE9
  private           UnityEngine.Timeline.AnimationPlayableAsset.LoopModemInfiniteClipLoop  // 0xEC
  private           UnityEngine.Timeline.MatchTargetFieldsm_MatchTargetFields  // 0xF0
  private           UnityEngine.Vector3             m_Position  // 0xF4
  private           UnityEngine.Vector3             m_EulerAngles  // 0x100
  private           UnityEngine.AvatarMask          m_AvatarMask  // 0x110
  private           System.Boolean                  m_ApplyAvatarMask  // 0x118
  private           UnityEngine.Timeline.TrackOffsetm_TrackOffset  // 0x11C
  private           UnityEngine.AnimationClip       m_InfiniteClip  // 0x120
  private           System.Boolean                  m_IsAdditive  // 0x128
  private           System.Boolean                  m_IsAdditiveToLast  // 0x129
  public            System.Boolean                  muteScriptAnimAddon  // 0x12A
  private           System.Boolean                  m_UseScriptAnimAddon  // 0x12B
  private           UnityEngine.ScriptableObject    m_TimelineNPCDescriptor  // 0x130
  private           System.String                   m_LookAtTargetPath  // 0x138
  private           System.Boolean                  m_LookAtUseAdditive  // 0x140
  private           UnityEngine.Transform           m_LookAtTarget  // 0x148
  private           System.Collections.Generic.HashSet<UnityEngine.Timeline.RuntimeElement>m_allRuntimeClipUnderTrack  // 0x150
  private   static readonly System.Collections.Generic.Queue<UnityEngine.Transform>s_CachedQueue  // 0x0
  private           UnityEngine.Quaternion          m_OpenClipOffsetRotation  // 0x158
  private           UnityEngine.Quaternion          m_Rotation  // 0x168
  private           System.Boolean                  m_ApplyOffsets  // 0x178
METHODS:
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
  UnityEngine.Vector3 get_eulerAngles()
  System.Void set_eulerAngles(UnityEngine.Vector3 value)
  System.Boolean get_applyOffsets()
  System.Void set_applyOffsets(System.Boolean value)
  UnityEngine.Timeline.TrackOffset get_trackOffset()
  System.Void set_trackOffset(UnityEngine.Timeline.TrackOffset value)
  UnityEngine.Timeline.MatchTargetFields get_matchTargetFields()
  System.Void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value)
  UnityEngine.AnimationClip get_infiniteClip()
  System.Void set_infiniteClip(UnityEngine.AnimationClip value)
  System.Boolean get_infiniteClipRemoveOffset()
  System.Void set_infiniteClipRemoveOffset(System.Boolean value)
  UnityEngine.AvatarMask get_avatarMask()
  System.Void set_avatarMask(UnityEngine.AvatarMask value)
  System.Boolean get_applyAvatarMask()
  System.Void set_applyAvatarMask(System.Boolean value)
  System.Boolean get_isUsingScriptAnimAddon()
  System.Void set_isUsingScriptAnimAddon(System.Boolean value)
  System.Boolean get_lookAtUseAdditive()
  System.Void set_lookAtUseAdditive(System.Boolean value)
  System.Boolean IsControlByThisTrack(UnityEngine.Timeline.RuntimeElement element)
  System.Boolean CanCompileClips()
  System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs()
  System.Boolean get_inClipMode()
  UnityEngine.Vector3 get_infiniteClipOffsetPosition()
  System.Void set_infiniteClipOffsetPosition(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_infiniteClipOffsetRotation()
  System.Void set_infiniteClipOffsetRotation(UnityEngine.Quaternion value)
  UnityEngine.Vector3 get_infiniteClipOffsetEulerAngles()
  System.Void set_infiniteClipOffsetEulerAngles(UnityEngine.Vector3 value)
  System.Boolean get_infiniteClipApplyFootIK()
  System.Void set_infiniteClipApplyFootIK(System.Boolean value)
  System.Double get_infiniteClipTimeOffset()
  System.Void set_infiniteClipTimeOffset(System.Double value)
  UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPreExtrapolation()
  System.Void set_infiniteClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value)
  UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPostExtrapolation()
  System.Void set_infiniteClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value)
  UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_infiniteClipLoop()
  System.Void set_infiniteClipLoop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value)
  System.Void ResetOffsets()
  UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AnimationClip clip)
  System.Void CreateInfiniteClip(System.String infiniteClipName)
  UnityEngine.Timeline.TimelineClip CreateRecordableClip(System.String animClipName)
  System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip)
  System.Int32 CalculateItemsHash()
  System.Void UpdateClipOffsets()
  UnityEngine.Playables.Playable _CreatePlayableFromClip(UnityEngine.Timeline.TimelineClip c, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode)
  UnityEngine.Playables.Playable CompileTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.AnimationTrack track, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode)
  System.Boolean ShouldLinkWithMainTrackMixer(UnityEngine.Timeline.AnimationTrack animationTrack)
  UnityEngine.Playables.Playable ApplyScriptAnimationPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, UnityEngine.GameObject go)
  UnityEngine.Playables.Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree)
  System.Void AttachCustomBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable layerMixer)
  System.Void AttachLastAdditiveClip(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable layerMixer, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, System.Collections.Generic.List<UnityEngine.Timeline.AnimationTrack> flattenTracks)
  System.Int32 GetDefaultBlendCount()
  System.Void AttachDefaultBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, System.Boolean requireOffset, UnityEngine.Animator animator)
  UnityEngine.Playables.Playable AttachOffsetPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable playable, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
  System.Boolean RequiresMotionXPlayable(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.GameObject gameObject)
  System.Boolean UsesAbsoluteMotion(UnityEngine.Timeline.AppliedOffsetMode mode)
  System.Boolean HasController(UnityEngine.GameObject gameObject)
  UnityEngine.Animator GetBinding(UnityEngine.Playables.PlayableDirector director)
  UnityEngine.Animations.AnimationLayerMixerPlayable CreateGroupMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  UnityEngine.Playables.Playable CreateInfiniteTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode)
  UnityEngine.Playables.Playable ApplyTrackOffset(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable root, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode)
  System.Void _AddClipIntoTree(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.RuntimeClip clip)
  System.Void GetEvaluationTime(System.Double& outStart, System.Double& outDuration)
  System.Void GetSequenceTime(System.Double& outStart, System.Double& outDuration)
  System.Void AssignAnimationClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.AnimationClip animClip)
  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> animClips)
  UnityEngine.Timeline.AppliedOffsetMode GetOffsetMode(UnityEngine.GameObject go, System.Boolean animatesRootTransform)
  System.Boolean IsRootTransformDisabledByMask(UnityEngine.GameObject gameObject, UnityEngine.Transform genericRootNode)
  UnityEngine.Transform GetGenericRootNode(UnityEngine.GameObject gameObject)
  System.Boolean AnimatesRootTransform()
  UnityEngine.Transform FindInHierarchyBreadthFirst(UnityEngine.Transform t, System.String name)
  UnityEngine.Vector3 get_openClipOffsetPosition()
  System.Void set_openClipOffsetPosition(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_openClipOffsetRotation()
  System.Void set_openClipOffsetRotation(UnityEngine.Quaternion value)
  UnityEngine.Vector3 get_openClipOffsetEulerAngles()
  System.Void set_openClipOffsetEulerAngles(UnityEngine.Vector3 value)
  UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPreExtrapolation()
  System.Void set_openClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value)
  UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPostExtrapolation()
  System.Void set_openClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value)
  System.Void OnUpgradeFromVersion(System.Int32 oldVersion)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.ICurvesOwner
TYPE:  interface
TOKEN: 0x200002C
FIELDS:
METHODS:
  System.String get_defaultCurvesName()
  UnityEngine.Object get_asset()
  UnityEngine.Object get_assetOwner()
  UnityEngine.Timeline.TrackAsset get_targetTrack()
END_CLASS

CLASS: UnityEngine.Timeline.TimelineClip
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  private   static  System.Int32                    k_LatestVersion  // 0x0
  private           System.Int32                    m_Version  // 0x10
  public    static readonly UnityEngine.Timeline.ClipCaps   kDefaultClipCaps  // 0x0
  public    static readonly System.Single                   kDefaultClipDurationInSeconds  // 0x4
  public    static readonly System.Double                   kTimeScaleMin  // 0x8
  public    static readonly System.Double                   kTimeScaleMax  // 0x10
  private   static readonly System.String                   kDefaultCurvesName  // 0x18
  private   static readonly System.Double                   kMinDuration  // 0x20
  private   static readonly System.Double                   kMaxTimeValue  // 0x28
  public            System.Int32                    optionIndex  // 0x14
  private           System.Double                   m_Start  // 0x18
  private           System.Double                   m_ClipIn  // 0x20
  private           UnityEngine.Object              m_Asset  // 0x28
  private           System.Double                   m_Duration  // 0x30
  private           System.Double                   m_TimeScale  // 0x38
  private           UnityEngine.Timeline.TrackAsset m_ParentTrack  // 0x40
  private           System.Double                   m_EaseInDuration  // 0x48
  private           System.Double                   m_EaseOutDuration  // 0x50
  private           System.Double                   m_BlendInDuration  // 0x58
  private           System.Double                   m_BlendOutDuration  // 0x60
  private           UnityEngine.AnimationCurve      m_MixInCurve  // 0x68
  private           UnityEngine.AnimationCurve      m_MixOutCurve  // 0x70
  private           UnityEngine.Timeline.TimelineClip.BlendCurveModem_BlendInCurveMode  // 0x78
  private           UnityEngine.Timeline.TimelineClip.BlendCurveModem_BlendOutCurveMode  // 0x7C
  private           System.Collections.Generic.List<System.String>m_ExposedParameterNames  // 0x80
  private           UnityEngine.AnimationClip       m_AnimationCurves  // 0x88
  private           System.Boolean                  m_Recordable  // 0x90
  private           UnityEngine.Timeline.TimelineClip.ClipExtrapolationm_PostExtrapolationMode  // 0x94
  private           UnityEngine.Timeline.TimelineClip.ClipExtrapolationm_PreExtrapolationMode  // 0x98
  private           System.Double                   m_PostExtrapolationTime  // 0xA0
  private           System.Double                   m_PreExtrapolationTime  // 0xA8
  private           System.String                   m_DisplayName  // 0xB0
METHODS:
  System.Void UpgradeToLatestVersion()
  System.Void .ctor(UnityEngine.Timeline.TrackAsset parent)
  System.Double get_timeScale()
  System.Double get_start()
  System.Void set_start(System.Double value)
  System.Double get_duration()
  System.Void set_duration(System.Double value)
  System.Double get_end()
  System.Double get_clipIn()
  System.String get_displayName()
  System.Void set_displayName(System.String value)
  System.Double get_clipAssetDuration()
  UnityEngine.AnimationClip get_curves()
  System.String UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName()
  UnityEngine.Object get_asset()
  System.Void set_asset(UnityEngine.Object value)
  UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner()
  UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack()
  UnityEngine.Timeline.TrackAsset GetParentTrack()
  System.Void SetParentTrack_Internal(UnityEngine.Timeline.TrackAsset newParentTrack)
  System.Double get_easeInDuration()
  System.Void set_easeInDuration(System.Double value)
  System.Double get_easeOutDuration()
  System.Void set_easeOutDuration(System.Double value)
  System.Double get_blendInDuration()
  System.Double get_blendOutDuration()
  System.Boolean get_hasBlendIn()
  System.Boolean get_hasBlendOut()
  UnityEngine.AnimationCurve get_mixInCurve()
  System.Void set_mixInCurve(UnityEngine.AnimationCurve value)
  System.Double get_mixInDuration()
  UnityEngine.AnimationCurve get_mixOutCurve()
  System.Void set_mixOutCurve(UnityEngine.AnimationCurve value)
  System.Double get_mixOutTime()
  System.Double get_mixOutDuration()
  System.Boolean get_recordable()
  System.Void set_recordable(System.Boolean value)
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  System.Int32 Hash()
  System.Single EvaluateMixOut(System.Double time)
  System.Single EvaluateMixOutAtGivenTime(System.Double time, System.Double mixOutTime, System.Double mixOutDuration)
  System.Single EvaluateMixIn(System.Double time)
  System.Single EvaluateMixInAtGivenTime(System.Double time, System.Double runtimeMixInTime, System.Double mixInDuration)
  UnityEngine.AnimationCurve GetDefaultMixInCurve()
  UnityEngine.AnimationCurve GetDefaultMixOutCurve()
  System.Double ToLocalTime(System.Double time)
  System.Double SanitizeTimeValue(System.Double value, System.Double defaultValue)
  UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_postExtrapolationMode()
  System.Void set_postExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value)
  UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_preExtrapolationMode()
  System.Void set_preExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value)
  System.Void SetPostExtrapolationTime(System.Double time)
  System.Void SetPreExtrapolationTime(System.Double time)
  System.Boolean IsPreExtrapolatedTime(System.Double sequenceTime)
  System.Boolean IsPostExtrapolatedTime(System.Double sequenceTime)
  System.Double get_extrapolatedStart()
  System.Double get_extrapolatedDuration()
  System.Double GetExtrapolatedTime(System.Double time, UnityEngine.Timeline.TimelineClip.ClipExtrapolation mode, System.Double duration)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.String ToString()
  System.Void UpdateDirty(System.Double oldValue, System.Double newValue)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimelineAsset
TYPE:  class
TOKEN: 0x2000032
EXTENDS: PlayableAsset
FIELDS:
  private   static  System.Int32                    k_LatestVersion  // 0x0
  private           System.Int32                    m_Version  // 0x18
  private           System.Collections.Generic.List<UnityEngine.ScriptableObject>m_Tracks  // 0x20
  private           System.Double                   m_FixedDuration  // 0x28
  private           UnityEngine.Timeline.TrackAsset[]m_CacheOutputTracks  // 0x30
  private           UnityEngine.Timeline.GroupTrack[]m_CacheGroupTracks  // 0x38
  private           System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset>m_CacheRootTracks  // 0x40
  private           UnityEngine.Timeline.TrackAsset[]m_CacheFlattenedTracks  // 0x48
  private           UnityEngine.Timeline.TimelineAsset.EditorSettingsm_EditorSettings  // 0x50
  private           UnityEngine.Timeline.TimelineAsset.DurationModem_DurationMode  // 0x58
  private           UnityEngine.Timeline.MarkerTrackm_MarkerTrack  // 0x60
METHODS:
  System.Void UpgradeToLatestVersion()
  UnityEngine.Timeline.TimelineAsset.EditorSettings get_editorSettings()
  System.Double get_duration()
  System.Double get_fixedDuration()
  System.Void set_fixedDuration(System.Double value)
  UnityEngine.Timeline.TimelineAsset.DurationMode get_durationMode()
  System.Void set_durationMode(UnityEngine.Timeline.TimelineAsset.DurationMode value)
  System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs()
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  System.Int32 get_outputTrackCount()
  System.Int32 get_rootTrackCount()
  System.Void OnValidate()
  UnityEngine.Timeline.TrackAsset GetRootTrack(System.Int32 index)
  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetRootTracks()
  UnityEngine.Timeline.TrackAsset GetOutputTrack(System.Int32 index)
  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetOutputTracks()
  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.GroupTrack> GetGroupTracks()
  System.Double GetValidFrameRate(System.Double frameRate)
  System.Void UpdateRootTrackCache()
  System.Void UpdateOutputTrackCache()
  UnityEngine.Timeline.TrackAsset[] get_flattenedTracks()
  UnityEngine.Timeline.TrackAsset[] GetAllTracks()
  UnityEngine.Timeline.MarkerTrack get_markerTrack()
  System.Collections.Generic.List<UnityEngine.ScriptableObject> get_trackObjects()
  System.Void AddTrackInternal(UnityEngine.Timeline.TrackAsset track)
  System.Void RemoveTrack(UnityEngine.Timeline.TrackAsset track)
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void __internalAwake()
  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  System.Void CreateMarkerTrack()
  System.Void Invalidate()
  System.Void UpdateFixedDurationWithItemsDuration()
  UnityEngine.Timeline.DiscreteTime CalculateItemsDuration()
  System.Void AddSubTracksRecursive(UnityEngine.Timeline.TrackAsset track, System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset>& allTracks)
  UnityEngine.Timeline.TrackAsset CreateTrack(System.Type type, UnityEngine.Timeline.TrackAsset parent, System.String name)
  T CreateTrack(UnityEngine.Timeline.TrackAsset parent, System.String trackName)
  T CreateTrack(System.String trackName)
  T CreateTrack()
  System.Boolean DeleteClip(UnityEngine.Timeline.TimelineClip clip)
  System.Boolean DeleteTrack(UnityEngine.Timeline.TrackAsset track)
  System.Void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset)
  System.Void MoveTrackAfter(UnityEngine.Timeline.TrackAsset trackToMove, UnityEngine.Timeline.TrackAsset targetTrack)
  UnityEngine.Timeline.TrackAsset AllocateTrack(UnityEngine.Timeline.TrackAsset trackAssetParent, System.String trackName, System.Type trackType)
  System.Void DeleteRecordedAnimation(UnityEngine.Timeline.TrackAsset track)
  System.Void DeleteRecordedAnimation(UnityEngine.Timeline.TimelineClip clip)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TrackAsset
TYPE:  class
TOKEN: 0x2000039
EXTENDS: PlayableAsset
FIELDS:
  private   static  System.Int32                    k_LatestVersion  // 0x0
  private           System.Int32                    m_Version  // 0x18
  private           UnityEngine.AnimationClip       m_AnimClip  // 0x20
  public            System.Boolean                  useAutoBinding  // 0x28
  public            System.String                   autoBindingPath  // 0x30
  public            System.String                   uniqueId  // 0x38
  private   static  UnityEngine.Timeline.TrackAsset.TransientBuildDatas_BuildData  // 0x0
  private   static  System.String                   kDefaultCurvesName  // 0x0
  private   static  System.Action<UnityEngine.Timeline.TimelineClip,UnityEngine.GameObject,UnityEngine.Playables.Playable>OnClipPlayableCreate  // 0x18
  private   static  System.Action<UnityEngine.Timeline.TrackAsset,UnityEngine.GameObject,UnityEngine.Playables.Playable>OnTrackAnimationPlayableCreate  // 0x20
  private           System.Boolean                  m_RuntimeMuted  // 0x40
  private           System.Boolean                  m_Locked  // 0x41
  private           System.Boolean                  m_Muted  // 0x42
  private           System.String                   m_CustomPlayableFullTypename  // 0x48
  private           UnityEngine.AnimationClip       m_Curves  // 0x50
  private           UnityEngine.Playables.PlayableAssetm_Parent  // 0x58
  private           System.Collections.Generic.List<UnityEngine.ScriptableObject>m_Children  // 0x60
  private           System.Int32                    m_ItemsHash  // 0x68
  private           UnityEngine.Timeline.TimelineClip[]m_ClipsCache  // 0x70
  private           UnityEngine.Timeline.DiscreteTimem_Start  // 0x78
  private           UnityEngine.Timeline.DiscreteTimem_End  // 0x80
  private           System.Boolean                  m_CacheSorted  // 0x88
  private           System.Nullable<System.Boolean> m_SupportsNotifications  // 0x89
  private   static  UnityEngine.Timeline.TrackAsset[]s_EmptyCache  // 0x28
  private           System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset>m_ChildTrackCache  // 0x90
  private   static  System.Collections.Generic.Dictionary<System.Type,UnityEngine.Timeline.TrackBindingTypeAttribute>s_TrackBindingTypeAttributeCache  // 0x30
  protected internal        System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip>m_Clips  // 0x98
  private           UnityEngine.Timeline.MarkerList m_Markers  // 0xA0
  public            System.Int32                    OptionIndex  // 0xB8
  public            System.Boolean                  useRuntimeMuted  // 0xBC
METHODS:
  System.Void OnBeforeTrackSerialize()
  System.Void OnAfterTrackDeserialize()
  System.Void OnUpgradeFromVersion(System.Int32 oldVersion)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void UpgradeToLatestVersion()
  System.Void add_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip,UnityEngine.GameObject,UnityEngine.Playables.Playable> value)
  System.Void remove_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip,UnityEngine.GameObject,UnityEngine.Playables.Playable> value)
  System.Void add_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset,UnityEngine.GameObject,UnityEngine.Playables.Playable> value)
  System.Void remove_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset,UnityEngine.GameObject,UnityEngine.Playables.Playable> value)
  System.Double get_start()
  System.Double get_end()
  System.Double get_duration()
  System.Boolean get_muted()
  System.Void set_muted(System.Boolean value)
  System.Boolean get_runtimeMuted()
  System.Void set_runtimeMuted(System.Boolean value)
  System.Boolean get_mutedInHierarchy()
  UnityEngine.Timeline.TimelineAsset get_timelineAsset()
  UnityEngine.Playables.PlayableAsset get_parent()
  System.Void set_parent(UnityEngine.Playables.PlayableAsset value)
  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> GetClips()
  UnityEngine.Timeline.TimelineClip[] get_clips()
  System.Boolean get_isEmpty()
  System.Boolean get_hasClips()
  System.Boolean get_hasCurves()
  System.Boolean get_isSubTrack()
  System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs()
  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetChildTracks()
  System.String get_customPlayableTypename()
  System.Void set_customPlayableTypename(System.String value)
  UnityEngine.AnimationClip get_curves()
  System.Void set_curves(UnityEngine.AnimationClip value)
  System.String UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName()
  UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_asset()
  UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner()
  UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack()
  System.Collections.Generic.List<UnityEngine.ScriptableObject> get_subTracksObjects()
  System.Boolean get_locked()
  System.Void set_locked(System.Boolean value)
  System.Boolean get_lockedInHierarchy()
  System.Boolean get_supportsNotifications()
  System.Void __internalAwake()
  System.Void CreateCurves(System.String curvesClipName)
  UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  UnityEngine.Timeline.TimelineClip CreateDefaultClip()
  UnityEngine.Timeline.TimelineClip CreateClip()
  System.Boolean DeleteClip(UnityEngine.Timeline.TimelineClip clip)
  UnityEngine.Timeline.IMarker CreateMarker(System.Type type, System.Double time)
  T CreateMarker(System.Double time)
  System.Boolean DeleteMarker(UnityEngine.Timeline.IMarker marker)
  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers()
  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetClipMarkers()
  System.Int32 GetMarkerCount()
  UnityEngine.Timeline.IMarker GetMarker(System.Int32 idx)
  UnityEngine.Timeline.TimelineClip CreateClip(System.Type requestedType)
  UnityEngine.Timeline.TimelineClip CreateAndAddNewClipOfType(System.Type requestedType)
  UnityEngine.Timeline.TimelineClip CreateClipOfType(System.Type requestedType)
  UnityEngine.Timeline.TimelineClip CreateClipFromPlayableAsset(UnityEngine.Playables.IPlayableAsset asset)
  UnityEngine.Timeline.TimelineClip CreateClipFromAsset(UnityEngine.ScriptableObject playableAsset)
  System.Collections.Generic.IEnumerable<UnityEngine.ScriptableObject> GetMarkersRaw()
  System.Void ClearMarkers()
  System.Void AddMarker(UnityEngine.ScriptableObject e)
  System.Boolean DeleteMarkerRaw(UnityEngine.ScriptableObject marker)
  System.Int32 GetTimeRangeHash()
  System.Void AddClip(UnityEngine.Timeline.TimelineClip newClip)
  UnityEngine.Playables.Playable CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixerPlayable, UnityEngine.GameObject go, UnityEngine.Playables.Playable timelinePlayable)
  UnityEngine.Playables.Playable CreatePlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Playables.Playable timelinePlayable)
  UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree)
  System.Void GatherCompilableTracks(System.Collections.Generic.IList<UnityEngine.Timeline.TrackAsset> tracks)
  System.Void GatherNotifications(System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markers)
  UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree)
  System.Void ConfigureTrackAnimation(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.GameObject go, UnityEngine.Playables.Playable blend)
  System.Void SortClips()
  System.Void ClearClipsInternal()
  System.Void ClearSubTracksInternal()
  System.Void OnClipMove()
  UnityEngine.Timeline.TimelineClip CreateNewClipContainerInternal()
  System.Void AddChild(UnityEngine.Timeline.TrackAsset child)
  System.Void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset)
  System.Boolean RemoveSubTrack(UnityEngine.Timeline.TrackAsset child)
  System.Void RemoveClip(UnityEngine.Timeline.TimelineClip clip)
  System.Void GetEvaluationTime(System.Double& outStart, System.Double& outDuration)
  System.Void GetSequenceTime(System.Double& outStart, System.Double& outDuration)
  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  UnityEngine.GameObject GetGameObjectBinding(UnityEngine.Playables.PlayableDirector director)
  System.Boolean ValidateClipType(System.Type clipType)
  System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip)
  System.Void UpdateDuration()
  System.Int32 CalculateItemsHash()
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.TimelineClip clip)
  System.Void Invalidate()
  System.Double GetNotificationDuration()
  System.Boolean CanCompileClips()
  System.Boolean HasChildTracks()
  System.Boolean CanCreateTrackMixer()
  System.Boolean IsCompilable()
  System.Void UpdateChildTrackCache()
  System.Int32 Hash()
  System.Int32 GetClipsHash()
  System.Int32 GetAnimationClipHash(UnityEngine.AnimationClip clip)
  System.Boolean HasNotifications()
  System.Boolean CanCompileNotifications()
  System.Boolean CanCreateMixerRecursive()
  UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimelineHelpURLAttribute
TYPE:  class
TOKEN: 0x200003F
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TrackColorAttribute
TYPE:  class
TOKEN: 0x2000040
EXTENDS: Attribute
FIELDS:
  private           UnityEngine.Color               m_Color  // 0x10
METHODS:
  System.Void .ctor(System.Single r, System.Single g, System.Single b)
END_CLASS

CLASS: UnityEngine.Timeline.AudioClipProperties
TYPE:  class
TOKEN: 0x2000041
EXTENDS: PlayableBehaviour
FIELDS:
  public            System.Single                   volume  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AudioMixerProperties
TYPE:  class
TOKEN: 0x2000042
EXTENDS: PlayableBehaviour
FIELDS:
  public            System.Single                   volume  // 0x10
  public            System.Single                   stereoPan  // 0x14
  public            System.Single                   spatialBlend  // 0x18
METHODS:
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AudioPlayableAsset
TYPE:  class
TOKEN: 0x2000043
EXTENDS: PlayableAsset
FIELDS:
  private           UnityEngine.AudioClip           m_Clip  // 0x18
  private           System.Boolean                  m_Loop  // 0x20
  private           System.Single                   m_bufferingTime  // 0x24
  private           UnityEngine.Timeline.AudioClipPropertiesm_ClipProperties  // 0x28
METHODS:
  System.Single get_bufferingTime()
  System.Void set_bufferingTime(System.Single value)
  UnityEngine.AudioClip get_clip()
  System.Void set_clip(UnityEngine.AudioClip value)
  System.Boolean get_loop()
  System.Void set_loop(System.Boolean value)
  System.Double get_duration()
  System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs()
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AudioTrack
TYPE:  class
TOKEN: 0x2000045
EXTENDS: TrackAsset
FIELDS:
  private           UnityEngine.Timeline.AudioMixerPropertiesm_TrackProperties  // 0xC0
METHODS:
  UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AudioClip clip)
  UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree)
  System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs()
  System.Void OnValidate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ACConditionDescriptor
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  private           System.Int32                    m_ConditionMode  // 0x10
  private           System.String                   m_ConditionEvent  // 0x18
  private           System.Single                   m_EventTreshold  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.ACTransitionDescriptor
TYPE:  class
TOKEN: 0x2000048
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.BeyondCommunicator
TYPE:  class
TOKEN: 0x2000049
FIELDS:
  public    static  System.Boolean                  setAddonLayerAdditive  // 0x0
  private   static  System.Action<UnityEngine.Animator,UnityEngine.Animations.AnimationLayerMixerPlayable,UnityEngine.Timeline.AnimationTrack,UnityEngine.ScriptableObject,UnityEngine.Transform,UnityEngine.Timeline.CommunicatorParam><ConnectToJobSync>k__BackingField  // 0x8
METHODS:
  System.Action<UnityEngine.Animator,UnityEngine.Animations.AnimationLayerMixerPlayable,UnityEngine.Timeline.AnimationTrack,UnityEngine.ScriptableObject,UnityEngine.Transform,UnityEngine.Timeline.CommunicatorParam> get_ConnectToJobSync()
  System.Void set_ConnectToJobSync(System.Action<UnityEngine.Animator,UnityEngine.Animations.AnimationLayerMixerPlayable,UnityEngine.Timeline.AnimationTrack,UnityEngine.ScriptableObject,UnityEngine.Transform,UnityEngine.Timeline.CommunicatorParam> value)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.BlendMotionDescriptor
TYPE:  class
TOKEN: 0x200004A
FIELDS:
  public            UnityEngine.AnimationClip       motion  // 0x10
  public            System.String                   poseTimerParam  // 0x18
  public            System.String                   blendParam  // 0x20
  public            System.Single                   threshold  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.BlendTreeDescriptor
TYPE:  class
TOKEN: 0x200004B
FIELDS:
  public            UnityEngine.Timeline.BlendTreeDescriptor.DescriptorBlendTreeTypeblendType  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Timeline.BlendMotionDescriptor>motionDescriptorList  // 0x18
  private           System.String                   <speedParameter>k__BackingField  // 0x20
  private           System.Boolean                  <speedParameterActive>k__BackingField  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ITimelineRootMarker
TYPE:  interface
TOKEN: 0x200004D
FIELDS:
METHODS:
  UnityEngine.Playables.PlayableDirector get_topDirector()
  UnityEngine.GameObject get_rootGo()
  System.Boolean get_useEarlyUpdate()
  System.Void RegisterLoopSegmentRuntimeClip(System.String key, UnityEngine.Timeline.RuntimeClip runtimeClip)
  System.Void UpdateAllVFXFollowBoneTools()
  System.Boolean get_enableLoop()
  System.Boolean get_isOptimizingHolding()
  System.Boolean get_onlyEvaluateTopDirector()
  System.Collections.Generic.Dictionary<UnityEngine.Playables.PlayableDirector,UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.DirectorControlPlayable>> get_director2ControlPlayable()
  System.Void set_director2ControlPlayable(System.Collections.Generic.Dictionary<UnityEngine.Playables.PlayableDirector,UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.DirectorControlPlayable>> value)
END_CLASS

CLASS: UnityEngine.Timeline.LayerDescriptor
TYPE:  class
TOKEN: 0x200004E
EXTENDS: ScriptableObject
FIELDS:
  public            System.String                   layerName  // 0x18
  public            UnityEngine.AvatarMask          avatarMask  // 0x20
  public            System.Boolean                  isAdditive  // 0x28
  public            System.Collections.Generic.List<UnityEngine.Timeline.StateDescriptor>stateDescriptors  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.MotionDescriptor
TYPE:  class
TOKEN: 0x200004F
FIELDS:
  public            System.String                   stateName  // 0x10
  public            UnityEngine.AnimationClip       motion  // 0x18
  public            System.Single                   speed  // 0x20
  public            System.String                   speedParameter  // 0x28
  public            System.Boolean                  speedParameterActive  // 0x30
  public            System.String                   mirrorParameter  // 0x38
  public            System.Boolean                  mirrorParameterActive  // 0x40
  public            System.String                   timeParameter  // 0x48
  public            System.Boolean                  timeParameterActive  // 0x50
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.StateDescriptor
TYPE:  class
TOKEN: 0x2000050
FIELDS:
  public            System.String                   stateName  // 0x10
  public            System.Boolean                  isDefaultState  // 0x18
  public            System.String                   stateWeightParameter  // 0x20
  public            System.Boolean                  stateWeightParameterActive  // 0x28
  public            System.Boolean                  isBlendTree  // 0x29
  public            UnityEngine.Timeline.MotionDescriptormotionDescriptor  // 0x30
  public            UnityEngine.Timeline.BlendTreeDescriptorblendTreeDescriptor  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ClipCaps
TYPE:  struct
TOKEN: 0x2000051
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.ClipCaps   None  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   Looping  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   Extrapolation  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   ClipIn  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   SpeedMultiplier  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   Blending  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   AutoScale  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   ClipMarker  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   DialogLoopSegment  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   IgniteOnce  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   OnlyDeltaTime  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   DialogJumpSegment  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   EvaluateTwiceWhenEnabled  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   DynamicLink  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   ConditionBlend  // 0x0
  public    static  UnityEngine.Timeline.ClipCaps   All  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TimelineClipCapsExtensions
TYPE:  class
TOKEN: 0x2000052
FIELDS:
METHODS:
  System.Boolean SupportsExtrapolation(UnityEngine.Timeline.TimelineClip clip)
  System.Boolean HasAny(UnityEngine.Timeline.ClipCaps caps, UnityEngine.Timeline.ClipCaps flags)
END_CLASS

CLASS: UnityEngine.Timeline.ControlPlayableAsset
TYPE:  class
TOKEN: 0x2000053
EXTENDS: PlayableAsset
FIELDS:
  private   static  System.Int32                    k_MaxRandInt  // 0x0
  private   static readonly System.Collections.Generic.List<UnityEngine.Playables.PlayableDirector>k_EmptyDirectorsList  // 0x0
  private   static readonly System.Collections.Generic.List<UnityEngine.ParticleSystem>k_EmptyParticlesList  // 0x8
  private   static readonly System.Collections.Generic.HashSet<UnityEngine.ParticleSystem>s_SubEmitterCollector  // 0x10
  public            UnityEngine.ExposedReference<UnityEngine.GameObject>sourceGameObject  // 0x18
  public            UnityEngine.GameObject          prefabGameObject  // 0x28
  public            System.Boolean                  updateParticle  // 0x30
  public            System.UInt32                   particleRandomSeed  // 0x34
  public            System.Boolean                  forceRuntimeSimulate  // 0x38
  public            System.Boolean                  updateDirector  // 0x39
  public            System.Boolean                  updateITimeControl  // 0x3A
  public            System.Boolean                  searchHierarchy  // 0x3B
  public            System.Boolean                  active  // 0x3C
  public            UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackStatepostPlayback  // 0x40
  private           System.Boolean                  m_OnlyDeltaTime  // 0x44
  private           System.Boolean                  m_IgniteOnce  // 0x45
  private           UnityEngine.Playables.PlayableAssetm_ControlDirectorAsset  // 0x48
  private           System.Double                   m_Duration  // 0x50
  private           System.Boolean                  m_SupportLoop  // 0x58
  private   static  System.Collections.Generic.HashSet<UnityEngine.Playables.PlayableDirector>s_ProcessedDirectors  // 0x18
  private   static  System.Collections.Generic.HashSet<UnityEngine.GameObject>s_CreatedPrefabs  // 0x20
  private           System.Boolean                  <controllingDirectors>k__BackingField  // 0x59
  private           System.Boolean                  <controllingParticles>k__BackingField  // 0x5A
METHODS:
  System.Boolean get_showBaseParam()
  System.Boolean get_controllingDirectors()
  System.Void set_controllingDirectors(System.Boolean value)
  System.Boolean get_controllingParticles()
  System.Void set_controllingParticles(System.Boolean value)
  System.Boolean get_OnlyDeltaTime()
  System.Void set_OnlyDeltaTime(System.Boolean value)
  System.Boolean get_IgniteOnce()
  System.Void set_IgniteOnce(System.Boolean value)
  System.Void OnEnable()
  System.Double get_duration()
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
  UnityEngine.Playables.Playable ConnectPlayablesToMixer(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> playables)
  System.Void CreateActivationPlayable(UnityEngine.GameObject root, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables)
  System.Void SearchHierarchyAndConnectParticleSystem(System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particleSystems, System.Single clipIn, System.Single speedMultiplier, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables)
  System.Void SearchHierarchyAndConnectDirector(System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables, System.Boolean disableSelfReferences)
  System.Void SearchHierarchyAndConnectControlableScripts(System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> controlableScripts, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables)
  System.Void ConnectMixerAndPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixer, UnityEngine.Playables.Playable playable, System.Int32 portIndex)
  System.Collections.Generic.IList<T> GetComponent(UnityEngine.GameObject gameObject)
  System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> GetControlableScripts(UnityEngine.GameObject root)
  System.Void UpdateDurationAndLoopFlag(System.Collections.Generic.IList<UnityEngine.Playables.PlayableDirector> directors, System.Collections.Generic.IList<UnityEngine.ParticleSystem> particleSystems)
  System.Collections.Generic.IList<UnityEngine.ParticleSystem> GetControllableParticleSystems(UnityEngine.GameObject go)
  System.Void GetControllableParticleSystems(UnityEngine.Transform t, System.Collections.Generic.ICollection<UnityEngine.ParticleSystem> roots, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters)
  System.Void CacheSubEmitters(UnityEngine.ParticleSystem ps, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters)
  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  System.Void PreviewParticles(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particles)
  System.Void PreviewActivation(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.GameObject> objects)
  System.Void PreviewTimeControl(UnityEngine.Timeline.IPropertyCollector driver, UnityEngine.Playables.PlayableDirector director, System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> scripts)
  System.Void PreviewDirectors(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.ControlTrack
TYPE:  class
TOKEN: 0x2000055
EXTENDS: TrackAsset
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AdditiveAnimApplyMono
TYPE:  class
TOKEN: 0x2000056
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Timeline.AdditiveAnimApplyMono.TransformAdditive>pendingAdditives  // 0x18
  private           System.Boolean                  hasnewPendingUpdates  // 0x20
  private           UnityEngine.Timeline.ITimelineRootMarker_parentTimelineRoot  // 0x28
METHODS:
  System.Void Awake()
  System.Void RecordAdditiveTransform(UnityEngine.Transform bone, UnityEngine.Vector3 position, UnityEngine.Vector3 rotationEuler, UnityEngine.Vector3 scale)
  System.Void LateUpdate()
  System.Void ApplyPendingTransforms()
  System.Void ClearPendingTransforms()
  System.Void NotifyCutsceneRootToUpdateVFXTools()
  System.Void RegisterRootComponent()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AdditiveAnimMixer
TYPE:  class
TOKEN: 0x2000058
EXTENDS: PlayableBehaviour
FIELDS:
  public            UnityEngine.Timeline.AdditiveAnimTracktrack  // 0x10
  private           UnityEngine.GameObject          bindingGo  // 0x18
  private           System.Boolean                  thisFrameAlreadyCalcualted  // 0x20
  private           System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Timeline.AdditiveAnimMixer.TransformAdditive>additiveCache  // 0x28
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform>bonePaths  // 0x30
  private           System.Collections.Generic.HashSet<System.String>notFoundBonePaths  // 0x38
METHODS:
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  System.Void _AddToAdditiveCache(UnityEngine.Timeline.AdditiveAnimPlayable additiveAnimPlayable, System.Single clipTime, System.Single weight)
  System.Void _ApplyAdditive()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AdditiveAnimPlayable
TYPE:  class
TOKEN: 0x200005A
EXTENDS: PlayableBehaviour
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo>extractedCurves  // 0x10
  private           System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo>>_curveCache  // 0x18
METHODS:
  System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable)
  System.Void InitializeCurveCache()
  UnityEngine.AnimationCurve GetCurve(System.String path, System.String propertyName)
  System.Single EvaluateCurve(System.String path, System.String propertyName, System.Single time)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AdditiveAnimPlayableAsset
TYPE:  class
TOKEN: 0x200005B
EXTENDS: PlayableAsset
FIELDS:
  public            UnityEngine.AnimationClip       additiveClip  // 0x18
  private           UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.AdditiveAnimPlayable>additiveAnimPlayable  // 0x20
  public            System.Collections.Generic.List<UnityEngine.Timeline.AdditiveAnimPlayableAsset.AnimationCurveInfo>extractedCurves  // 0x30
  private           System.Boolean                  m_OnlyDeltaTime  // 0x38
  private           System.Boolean                  m_IgniteOnce  // 0x39
  private           UnityEngine.AnimationClip       _lastProcessedClip  // 0x40
METHODS:
  System.Boolean get_OnlyDeltaTime()
  System.Void set_OnlyDeltaTime(System.Boolean value)
  System.Boolean get_IgniteOnce()
  System.Void set_IgniteOnce(System.Boolean value)
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Void _InitializeBehaviourCurveCache()
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.AdditiveAnimTrack
TYPE:  class
TOKEN: 0x200005D
EXTENDS: TrackAsset
FIELDS:
  private   static  System.String                   k_DefaultRecordableClipName  // 0x0
  private           System.Boolean                  m_InfiniteClip  // 0xC0
  private           UnityEngine.AnimationClip       m_RecordableClip  // 0xC8
METHODS:
  UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
  UnityEngine.Timeline.TimelineClip CreateRecordableClip(System.String animClipName)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.CombineToTopPlayableAttribute
TYPE:  class
TOKEN: 0x200005E
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.IDynamicBinding
TYPE:  interface
TOKEN: 0x200005F
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.SegmentLoopPlayableBehaviour
TYPE:  class
TOKEN: 0x2000060
EXTENDS: PlayableBehaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SegmentLoopPlayableClip
TYPE:  class
TOKEN: 0x2000061
EXTENDS: PlayableAsset
FIELDS:
  public            System.String                   loopSegmentKey  // 0x18
METHODS:
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  UnityEngine.Timeline.ClipCaps get_clipCaps()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SegmentLoopTrack
TYPE:  class
TOKEN: 0x2000062
EXTENDS: TrackAsset
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.DiscreteTime
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  private   static  System.Double                   k_Tick  // 0x0
  public    static readonly UnityEngine.Timeline.DiscreteTimekMaxTime  // 0x0
  private   readonly System.Int64                    m_DiscreteTime  // 0x10
METHODS:
  System.Double get_tickValue()
  System.Void .ctor(System.Int64 time)
  System.Void .ctor(System.Double time)
  System.Void .ctor(System.Int32 time)
  UnityEngine.Timeline.DiscreteTime OneTickBefore()
  UnityEngine.Timeline.DiscreteTime OneTickAfter()
  UnityEngine.Timeline.DiscreteTime FromTicks(System.Int64 ticks)
  System.Int32 CompareTo(System.Object obj)
  System.Boolean Equals(UnityEngine.Timeline.DiscreteTime other)
  System.Boolean Equals(System.Object obj)
  System.Int64 DoubleToDiscreteTime(System.Double time)
  System.Int64 IntToDiscreteTime(System.Int32 time)
  System.Double ToDouble(System.Int64 time)
  System.Double op_Explicit(UnityEngine.Timeline.DiscreteTime b)
  UnityEngine.Timeline.DiscreteTime op_Explicit(System.Double time)
  UnityEngine.Timeline.DiscreteTime op_Implicit(System.Int32 time)
  System.Boolean op_Equality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  System.Boolean op_Inequality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  System.Boolean op_LessThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  System.Boolean op_GreaterThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  UnityEngine.Timeline.DiscreteTime op_Subtraction(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  System.String ToString()
  System.Int32 GetHashCode()
  UnityEngine.Timeline.DiscreteTime Max(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs)
  System.Int64 GetNearestTick(System.Double time)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.InfiniteRuntimeClip
TYPE:  class
TOKEN: 0x2000064
EXTENDS: RuntimeElement
FIELDS:
  private           UnityEngine.Playables.Playable  m_Playable  // 0x18
  private   static readonly System.Int64                    kIntervalEnd  // 0x0
  private           System.Int32                    <optionIndex>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.Playables.Playable playable)
  System.Int64 get_intervalStart()
  System.Int64 get_intervalEnd()
  System.Int32 get_optionIndex()
  System.Void set_optionIndex(System.Int32 value)
  System.Void set_enable(System.Boolean value)
  System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData)
  System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.IInterval
TYPE:  interface
TOKEN: 0x2000065
FIELDS:
METHODS:
  System.Int64 get_intervalStart()
  System.Int64 get_intervalEnd()
END_CLASS

CLASS: UnityEngine.Timeline.IRuntimeReset
TYPE:  interface
TOKEN: 0x2000066
FIELDS:
METHODS:
  System.Void RuntimeReset()
END_CLASS

CLASS: UnityEngine.Timeline.IOption
TYPE:  interface
TOKEN: 0x2000067
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.IntervalTreeNode
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  public            System.Int64                    center  // 0x10
  public            System.Int32                    first  // 0x18
  public            System.Int32                    last  // 0x1C
  public            System.Int32                    left  // 0x20
  public            System.Int32                    right  // 0x24
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.IntervalTree`1
TYPE:  class
TOKEN: 0x2000069
FIELDS:
  private   static  System.Int32                    kMinNodeSize  // 0x0
  private   static  System.Int32                    kInvalidNode  // 0x0
  private   static  System.Int64                    kCenterUnknown  // 0x0
  private   readonly System.Collections.Generic.List<UnityEngine.Timeline.IntervalTree.Entry<T>>m_Entries  // 0x0
  private   readonly System.Collections.Generic.List<UnityEngine.Timeline.IntervalTreeNode>m_Nodes  // 0x0
  private           System.Boolean                  <dirty>k__BackingField  // 0x0
METHODS:
  System.Boolean get_dirty()
  System.Void set_dirty(System.Boolean value)
  System.Void Add(T item)
  System.Void IntersectsWith(System.Int64 value, System.Collections.Generic.List<T> results)
  System.Void IntersectsWithRange(System.Int64 start, System.Int64 end, System.Collections.Generic.List<T> results)
  System.Void UpdateIntervals()
  System.Void RuntimeReset()
  System.Void Query(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, System.Int64 value, System.Collections.Generic.List<T> results)
  System.Void QueryRange(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, System.Int64 start, System.Int64 end, System.Collections.Generic.List<T> results)
  System.Void Rebuild()
  System.Int32 Rebuild(System.Int32 start, System.Int32 end)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.RuntimeClip
TYPE:  class
TOKEN: 0x200006B
EXTENDS: RuntimeClipBase
FIELDS:
  public            System.Double                   runtimeLocalTimeOffset  // 0x20
  public            System.Double                   runtimeMixOutTime  // 0x28
  public            System.Double                   runtimeMixOutDuration  // 0x30
  public            System.Double                   runtimeMixInTime  // 0x38
  public            System.Double                   runtimeMixInDuration  // 0x40
  public            System.Boolean                  runtimeLooping  // 0x48
  public            System.Boolean                  runtimeLoopingMute  // 0x49
  private           System.Boolean                  _isInMixIn  // 0x4A
  private           System.Boolean                  _isMixIn  // 0x4B
  private           System.Boolean                  _hadIgniteOnce  // 0x4C
  private           System.Double                   lastTickTime  // 0x50
  private           System.Int32                    <optionIndex>k__BackingField  // 0x58
  private           System.Int32                    m_originalPort  // 0x5C
  public            System.Boolean                  isRuntimeJumpExhaust  // 0x60
  private           UnityEngine.Timeline.TimelineClipm_Clip  // 0x68
  private           UnityEngine.Playables.Playable  m_Playable  // 0x70
  private           UnityEngine.Playables.Playable  m_ParentMixer  // 0x80
  private           UnityEngine.Playables.Playable  m_RootPlayable  // 0x90
  private           System.Boolean                  m_enabled  // 0xA0
METHODS:
  System.Int32 get_optionIndex()
  System.Void set_optionIndex(System.Int32 value)
  System.Boolean get_dynamicLink()
  System.Double get_start()
  System.Double get_end()
  System.Double get_duration()
  System.Void .ctor(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Int32 originalPort)
  System.Void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Int32 originalPort)
  UnityEngine.Timeline.TimelineClip get_clip()
  UnityEngine.Playables.Playable get_mixer()
  UnityEngine.Playables.Playable get_playable()
  System.Int64 get_intervalStart()
  System.Int64 get_intervalEnd()
  System.Void set_enable(System.Boolean value)
  System.Boolean get_isEnabling()
  System.Void SetTime(System.Double time)
  System.Void SetDuration(System.Double duration)
  System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData)
  System.Single EvaluateMixIn(System.Single localTime)
  System.Single EvaluateMixOut(System.Single localTime)
  System.Double ToLocalTime(System.Double localTime, UnityEngine.Playables.FrameData frameData)
  System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData)
  System.Boolean CheckIfRuntimeTimeLoop(System.Boolean& canSkip, System.Double& reverseTime)
  System.Boolean CheckIfRuntimeTimeJump(System.Double& jumpTime, System.Boolean& isReverseJump)
  System.Void RuntimeLoopOver()
  System.Void GetRuntimeCrossFadeDuration(System.Double& duration, System.Double& jumpTargetTime)
  System.Void RecalculateRuntimeCrossFadeMixIn(System.Double mixInTime, System.Double mixInDuration)
  System.Void RecalculateRuntimeCrossFadeMixOut(System.Double curTime, System.Double mixStartTime, System.Double mixDuration)
  System.Boolean TryGetJumpClip(Beyond.Gameplay.Core.RuntimeJumpClip& jumpClip)
  System.Void RuntimeReset()
END_CLASS

CLASS: UnityEngine.Timeline.RuntimeClipBase
TYPE:  class
TOKEN: 0x200006C
EXTENDS: RuntimeElement
FIELDS:
  private           System.Int32                    <optionIndex>k__BackingField  // 0x18
METHODS:
  System.Double get_start()
  System.Double get_duration()
  System.Double get_end()
  System.Int32 get_optionIndex()
  System.Void set_optionIndex(System.Int32 value)
  System.Int64 get_intervalStart()
  System.Int64 get_intervalEnd()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.RuntimeElement
TYPE:  class
TOKEN: 0x200006D
FIELDS:
  private           System.Int32                    <intervalBit>k__BackingField  // 0x10
  private           System.Boolean                  <isLooping>k__BackingField  // 0x14
METHODS:
  System.Int64 get_intervalStart()
  System.Int64 get_intervalEnd()
  System.Int32 get_optionIndex()
  System.Void set_optionIndex(System.Int32 value)
  System.Int32 get_intervalBit()
  System.Void set_intervalBit(System.Int32 value)
  System.Boolean get_isLooping()
  System.Void set_isLooping(System.Boolean value)
  System.Void set_enable(System.Boolean value)
  System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData)
  System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData)
  System.Boolean CheckIfRuntimeTimeLoop(System.Boolean& canSkip, System.Double& reverseTime)
  System.Boolean CheckIfRuntimeTimeJump(System.Double& jumpTime, System.Boolean& isReverseJump)
  System.Void RuntimeLoopOver()
  System.Void GetRuntimeCrossFadeDuration(System.Double& duration, System.Double& jumpTargetTime)
  System.Void RecalculateRuntimeCrossFadeMixIn(System.Double mixInTime, System.Double mixDuration)
  System.Void RecalculateRuntimeCrossFadeMixOut(System.Double curTime, System.Double mixStartTime, System.Double mixDuration)
  System.Void RuntimeReset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ScheduleRuntimeClip
TYPE:  class
TOKEN: 0x200006E
EXTENDS: RuntimeClipBase
FIELDS:
  private           UnityEngine.Timeline.TimelineClipm_Clip  // 0x20
  private           UnityEngine.Playables.Playable  m_Playable  // 0x28
  private           UnityEngine.Playables.Playable  m_ParentMixer  // 0x38
  private           System.Double                   m_StartDelay  // 0x48
  private           System.Double                   m_FinishTail  // 0x50
  private           System.Boolean                  m_Started  // 0x58
METHODS:
  System.Double get_start()
  System.Double get_duration()
  System.Double get_end()
  UnityEngine.Timeline.TimelineClip get_clip()
  UnityEngine.Playables.Playable get_mixer()
  UnityEngine.Playables.Playable get_playable()
  System.Void .ctor(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Double startDelay, System.Double finishTail)
  System.Void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, System.Double startDelay, System.Double finishTail)
  System.Void set_enable(System.Boolean value)
  System.Void EvaluateAt(System.Double localTime, UnityEngine.Playables.FrameData frameData)
  System.Void DisableAt(System.Double localTime, System.Double rootDuration, UnityEngine.Playables.FrameData frameData)
END_CLASS

CLASS: UnityEngine.Timeline.IMarker
TYPE:  interface
TOKEN: 0x200006F
FIELDS:
METHODS:
  System.Double get_time()
  System.Void set_time(System.Double value)
  UnityEngine.Timeline.TrackAsset get_parent()
  System.Void Initialize(UnityEngine.Timeline.TrackAsset parent)
END_CLASS

CLASS: UnityEngine.Timeline.INotificationOptionProvider
TYPE:  interface
TOKEN: 0x2000070
FIELDS:
METHODS:
  UnityEngine.Timeline.NotificationFlags get_flags()
END_CLASS

CLASS: UnityEngine.Timeline.Marker
TYPE:  class
TOKEN: 0x2000071
EXTENDS: ScriptableObject
FIELDS:
  private           System.Double                   m_Time  // 0x18
  private           UnityEngine.Timeline.TrackAsset <parent>k__BackingField  // 0x20
METHODS:
  UnityEngine.Timeline.TrackAsset get_parent()
  System.Void set_parent(UnityEngine.Timeline.TrackAsset value)
  System.Double get_time()
  System.Void set_time(System.Double value)
  System.Void UnityEngine.Timeline.IMarker.Initialize(UnityEngine.Timeline.TrackAsset parentTrack)
  System.Void OnInitialize(UnityEngine.Timeline.TrackAsset aPent)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.MarkerList
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.ScriptableObject>m_Objects  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Timeline.IMarker>m_Cache  // 0x18
  private           System.Boolean                  m_CacheDirty  // 0x20
  private           System.Boolean                  m_HasNotifications  // 0x21
METHODS:
  System.Collections.Generic.List<UnityEngine.Timeline.IMarker> get_markers()
  System.Void .ctor(System.Int32 capacity)
  System.Void Add(UnityEngine.ScriptableObject item)
  System.Boolean Remove(UnityEngine.Timeline.IMarker item)
  System.Boolean Remove(UnityEngine.ScriptableObject item, UnityEngine.Timeline.TimelineAsset timelineAsset, UnityEngine.Playables.PlayableAsset thingToDirty)
  System.Void Clear()
  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers()
  System.Int32 get_Count()
  UnityEngine.Timeline.IMarker get_Item(System.Int32 idx)
  System.Collections.Generic.List<UnityEngine.ScriptableObject> GetRawMarkerList()
  UnityEngine.Timeline.IMarker CreateMarker(System.Type type, System.Double time, UnityEngine.Timeline.TrackAsset owner)
  System.Boolean HasNotifications()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void BuildCache()
END_CLASS

CLASS: UnityEngine.Timeline.MarkerTrack
TYPE:  class
TOKEN: 0x2000073
EXTENDS: TrackAsset
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.CustomSignalEventDrawer
TYPE:  class
TOKEN: 0x2000074
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SignalAsset
TYPE:  class
TOKEN: 0x2000075
EXTENDS: ScriptableObject
FIELDS:
  private   static  System.Action<UnityEngine.Timeline.SignalAsset>OnEnableCallback  // 0x0
METHODS:
  System.Void add_OnEnableCallback(System.Action<UnityEngine.Timeline.SignalAsset> value)
  System.Void remove_OnEnableCallback(System.Action<UnityEngine.Timeline.SignalAsset> value)
  System.Void OnEnable()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SignalEmitter
TYPE:  class
TOKEN: 0x2000076
EXTENDS: Marker
FIELDS:
  private           System.Boolean                  m_Retroactive  // 0x28
  private           System.Boolean                  m_EmitOnce  // 0x29
  private           UnityEngine.Timeline.SignalAssetm_Asset  // 0x30
METHODS:
  System.Boolean get_retroactive()
  System.Void set_retroactive(System.Boolean value)
  System.Boolean get_emitOnce()
  System.Void set_emitOnce(System.Boolean value)
  UnityEngine.Timeline.SignalAsset get_asset()
  System.Void set_asset(UnityEngine.Timeline.SignalAsset value)
  UnityEngine.PropertyName UnityEngine.Playables.INotification.get_id()
  UnityEngine.Timeline.NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.get_flags()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SignalReceiver
TYPE:  class
TOKEN: 0x2000077
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Timeline.SignalReceiver.EventKeyValuem_Events  // 0x18
METHODS:
  System.Void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, System.Object context)
  System.Void AddReaction(UnityEngine.Timeline.SignalAsset asset, UnityEngine.Events.UnityEvent reaction)
  System.Int32 AddEmptyReaction(UnityEngine.Events.UnityEvent reaction)
  System.Void Remove(UnityEngine.Timeline.SignalAsset asset)
  System.Collections.Generic.IEnumerable<UnityEngine.Timeline.SignalAsset> GetRegisteredSignals()
  UnityEngine.Events.UnityEvent GetReaction(UnityEngine.Timeline.SignalAsset key)
  System.Int32 Count()
  System.Void ChangeSignalAtIndex(System.Int32 idx, UnityEngine.Timeline.SignalAsset newKey)
  System.Void RemoveAtIndex(System.Int32 idx)
  System.Void ChangeReactionAtIndex(System.Int32 idx, UnityEngine.Events.UnityEvent reaction)
  UnityEngine.Events.UnityEvent GetReactionAtIndex(System.Int32 idx)
  UnityEngine.Timeline.SignalAsset GetSignalAssetAtIndex(System.Int32 idx)
  System.Void OnEnable()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.SignalTrack
TYPE:  class
TOKEN: 0x2000079
EXTENDS: MarkerTrack
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TrackAssetExtensions
TYPE:  class
TOKEN: 0x200007A
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.GroupTrack
TYPE:  class
TOKEN: 0x200007B
EXTENDS: TrackAsset
FIELDS:
  public            Beyond.PackageBridge.Timeline.TimelineConditionBaseenableOnCondition  // 0xC0
METHODS:
  System.Void CalculateRuntimeMuted()
  System.Boolean CanCompileClips()
  System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ILayerable
TYPE:  interface
TOKEN: 0x200007C
FIELDS:
METHODS:
  UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount)
END_CLASS

CLASS: UnityEngine.Timeline.ActivationControlPlayable
TYPE:  class
TOKEN: 0x200007D
EXTENDS: ControlPlayableBehaviour
FIELDS:
  public            UnityEngine.GameObject          gameObject  // 0x10
  public            UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackStatepostPlayback  // 0x18
  private           UnityEngine.Timeline.ActivationControlPlayable.InitialStatem_InitialState  // 0x1C
METHODS:
  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ActivationControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlaybackState)
  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object userData)
  System.Void OnGraphStart(UnityEngine.Playables.Playable playable)
  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  System.Void RuntimeReset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.BasicPlayableBehaviour
TYPE:  class
TOKEN: 0x2000080
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  System.Double get_duration()
  System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs()
  System.Void OnGraphStart(UnityEngine.Playables.Playable playable)
  System.Void OnGraphStop(UnityEngine.Playables.Playable playable)
  System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable)
  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ControlPlayableBehaviour
TYPE:  class
TOKEN: 0x2000081
EXTENDS: PlayableBehaviour
FIELDS:
METHODS:
  System.Void RuntimeReset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.DirectorControlPlayable
TYPE:  class
TOKEN: 0x2000082
EXTENDS: ControlPlayableBehaviour
FIELDS:
  public            UnityEngine.Playables.PlayableDirectordirector  // 0x10
  public            UnityEngine.Timeline.ITimelineRootMarkerrootMarker  // 0x18
  private   static  System.Single                   SYNC_START_FORBID_THRESHOLD  // 0x0
  private           System.Boolean                  m_SyncTime  // 0x20
  private           System.Double                   m_AssetDuration  // 0x28
  private           UnityEngine.Timeline.TimelinePlayablem_TimelinePlayable  // 0x30
METHODS:
  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.DirectorControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableDirector director)
  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData)
  System.Void SyncSpeed(System.Double speed)
  System.Void SyncStart(UnityEngine.Playables.PlayableGraph graph, System.Double time)
  System.Void SyncStop(UnityEngine.Playables.PlayableGraph graph, System.Double time)
  System.Void RuntimeReset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.ITimeControl
TYPE:  interface
TOKEN: 0x2000083
FIELDS:
METHODS:
  System.Void SetTime(System.Double time)
  System.Void OnControlTimeStart()
  System.Void OnControlTimeStop()
END_CLASS

CLASS: UnityEngine.Timeline.NotificationFlags
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            System.Int16                    value__  // 0x10
  public    static  UnityEngine.Timeline.NotificationFlagsTriggerInEditMode  // 0x0
  public    static  UnityEngine.Timeline.NotificationFlagsRetroactive  // 0x0
  public    static  UnityEngine.Timeline.NotificationFlagsTriggerOnce  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.ParticleControlPlayable
TYPE:  class
TOKEN: 0x2000085
EXTENDS: ControlPlayableBehaviour
FIELDS:
  private           System.Single                   m_LastPlayableTime  // 0x10
  private           System.Single                   m_LastParticleTime  // 0x14
  private           System.UInt32                   m_RandomSeed  // 0x18
  private           System.Boolean                  m_forceRuntimeSimulate  // 0x1C
  private           System.Single                   m_clipIn  // 0x20
  private           System.Boolean                  m_hadInitialized  // 0x24
  private           UnityEngine.ParticleSystem      <particleSystem>k__BackingField  // 0x28
  private           System.Boolean                  m_hadIgnite  // 0x30
  private           System.Boolean                  m_hadSimulate  // 0x31
METHODS:
  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ParticleControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.ParticleSystem component, System.UInt32 randomSeed, System.Single clipIn, System.Single speedMultiplier, System.Boolean forceRuntimeSimulate)
  UnityEngine.ParticleSystem get_particleSystem()
  System.Void set_particleSystem(UnityEngine.ParticleSystem value)
  System.Boolean get_shouldSimulate()
  System.Void Initialize(UnityEngine.ParticleSystem ps, System.UInt32 randomSeed, System.Single clipIn, System.Single simulateSpeed, System.Boolean forceRuntimeSimulate)
  System.Void SetSimulateSpeed(UnityEngine.ParticleSystem particleSystem, System.Double simulateSpeed)
  System.Void SetRandomSeed(UnityEngine.ParticleSystem particleSystem, System.UInt32 randomSeed)
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data)
  System.Void _SimulateParticle(System.Single time, System.Single particleTime, System.Boolean previewMode)
  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void _PlayOrQueuedParticleSystem()
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void Simulate(System.Single time, System.Boolean restart)
  System.Void RuntimeReset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.PrefabControlPlayable
TYPE:  class
TOKEN: 0x2000086
EXTENDS: PlayableBehaviour
FIELDS:
  private           UnityEngine.GameObject          m_Instance  // 0x10
METHODS:
  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.PrefabControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform)
  UnityEngine.GameObject get_prefabInstance()
  UnityEngine.GameObject Initialize(UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform)
  System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable)
  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void SetHideFlagsRecursive(UnityEngine.GameObject gameObject)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimeControlPlayable
TYPE:  class
TOKEN: 0x2000087
EXTENDS: ControlPlayableBehaviour
FIELDS:
  private           UnityEngine.Timeline.ITimeControlm_timeControl  // 0x10
  private           System.Boolean                  m_started  // 0x18
METHODS:
  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.ITimeControl timeControl)
  System.Void Initialize(UnityEngine.Timeline.ITimeControl timeControl)
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void RuntimeReset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimeNotificationBehaviour
TYPE:  class
TOKEN: 0x2000088
EXTENDS: PlayableBehaviour
FIELDS:
  private   readonly System.Collections.Generic.List<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry>m_Notifications  // 0x10
  private           System.Double                   m_PreviousTime  // 0x18
  private           System.Boolean                  m_NeedSortNotifications  // 0x20
  private           UnityEngine.Playables.Playable  m_TimeSource  // 0x28
METHODS:
  System.Void set_timeSource(UnityEngine.Playables.Playable value)
  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, System.Double duration, UnityEngine.Playables.DirectorWrapMode loopMode)
  System.Void AddNotification(System.Double time, UnityEngine.Playables.INotification payload, UnityEngine.Timeline.NotificationFlags flags)
  System.Void OnGraphStart(UnityEngine.Playables.Playable playable)
  System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void SortNotifications()
  System.Boolean CanRestoreNotification(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e, UnityEngine.Playables.FrameData info, System.Double currentTime, System.Double previousTime)
  System.Void TriggerNotificationsInRange(System.Double start, System.Double end, UnityEngine.Playables.FrameData info, UnityEngine.Playables.Playable playable, System.Boolean checkState)
  System.Void SyncDurationWithExternalSource(UnityEngine.Playables.Playable playable)
  System.Void Trigger_internal(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableOutput output, UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry& e)
  System.Void Restore_internal(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry& e)
  System.Double _GetPlayableTime(UnityEngine.Playables.Playable playable)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.CommunicatorParam
TYPE:  class
TOKEN: 0x200008B
FIELDS:
  public            UnityEngine.Timeline.IScriptAnimationJobSyncjobSync  // 0x10
  public            System.String                   uniqueId  // 0x18
  public            System.Boolean                  lookAtUseAdditive  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.IAutoGenMono
TYPE:  interface
TOKEN: 0x200008C
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.IBehaviourRuntimeReset
TYPE:  interface
TOKEN: 0x200008D
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.IScriptAnimationJobSync
TYPE:  interface
TOKEN: 0x200008E
FIELDS:
METHODS:
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
  System.Void CalcLayerMainStream(System.Single deltaTime)
  System.Void ResetCloth(System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeRuntimeElements, System.Boolean useSoftReset, System.Boolean keepPose, System.Boolean useRelativeTeleport)
END_CLASS

CLASS: UnityEngine.Timeline.TimelineScriptAnimationJob
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            UnityEngine.Timeline.IScriptAnimationJobSyncbindedScriptAnimationJobSync  // 0x10
  public            UnityEngine.Animator            bindedAnimator  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Timeline.IScriptAnimationJobSync job, UnityEngine.Animator animator)
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Timeline.PlayableTrack
TYPE:  class
TOKEN: 0x2000090
EXTENDS: TrackAsset
FIELDS:
METHODS:
  System.Void OnCreateClip(UnityEngine.Timeline.TimelineClip clip)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TrackMediaType
TYPE:  class
TOKEN: 0x2000091
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TrackClipTypeAttribute
TYPE:  class
TOKEN: 0x2000092
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type                     inspectedType  // 0x10
  public    readonly System.Boolean                  allowAutoCreate  // 0x18
METHODS:
  System.Void .ctor(System.Type clipClass)
  System.Void .ctor(System.Type clipClass, System.Boolean allowAutoCreate)
END_CLASS

CLASS: UnityEngine.Timeline.NotKeyableAttribute
TYPE:  class
TOKEN: 0x2000093
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TrackBindingFlags
TYPE:  struct
TOKEN: 0x2000094
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.TrackBindingFlagsNone  // 0x0
  public    static  UnityEngine.Timeline.TrackBindingFlagsAllowCreateComponent  // 0x0
  public    static  UnityEngine.Timeline.TrackBindingFlagsAll  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TrackBindingTypeAttribute
TYPE:  class
TOKEN: 0x2000095
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type                     type  // 0x10
  public    readonly UnityEngine.Timeline.TrackBindingFlagsflags  // 0x18
METHODS:
  System.Void .ctor(System.Type type)
  System.Void .ctor(System.Type type, UnityEngine.Timeline.TrackBindingFlags flags)
END_CLASS

CLASS: UnityEngine.Timeline.SupportsChildTracksAttribute
TYPE:  class
TOKEN: 0x2000096
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type                     childType  // 0x10
  public    readonly System.Int32                    levels  // 0x18
METHODS:
  System.Void .ctor(System.Type childType, System.Int32 levels)
END_CLASS

CLASS: UnityEngine.Timeline.IgnoreOnPlayableTrackAttribute
TYPE:  class
TOKEN: 0x2000097
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimeFieldAttribute
TYPE:  class
TOKEN: 0x2000098
EXTENDS: PropertyAttribute
FIELDS:
  private   readonly UnityEngine.Timeline.TimeFieldAttribute.UseEditMode<useEditMode>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Timeline.TimeFieldAttribute.UseEditMode useEditMode)
END_CLASS

CLASS: UnityEngine.Timeline.FrameRateFieldAttribute
TYPE:  class
TOKEN: 0x200009A
EXTENDS: PropertyAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.HideInMenuAttribute
TYPE:  class
TOKEN: 0x200009B
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.CustomStyleAttribute
TYPE:  class
TOKEN: 0x200009C
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   ussStyle  // 0x10
METHODS:
  System.Void .ctor(System.String ussStyle)
END_CLASS

CLASS: UnityEngine.Timeline.MenuCategoryAttribute
TYPE:  class
TOKEN: 0x200009D
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.ITimelineClipAsset
TYPE:  interface
TOKEN: 0x200009E
FIELDS:
METHODS:
  UnityEngine.Timeline.ClipCaps get_clipCaps()
END_CLASS

CLASS: UnityEngine.Timeline.ITimelineEvaluateCallback
TYPE:  interface
TOKEN: 0x200009F
FIELDS:
METHODS:
  System.Void Evaluate()
END_CLASS

CLASS: UnityEngine.Timeline.TimelinePlayable
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: PlayableBehaviour
FIELDS:
  public            System.Double                   timeOffset  // 0x10
  public            System.Int32                    newOptionIndex  // 0x18
  public            System.Int32                    curOptionIndex  // 0x1C
  public            System.Int32                    lastOptionIndex  // 0x20
  public            System.Boolean                  checkTimeJumpForNextSeek  // 0x24
  private           UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement>m_IntervalTree  // 0x28
  private           System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement>m_ActiveClips  // 0x30
  private           System.Collections.Generic.HashSet<UnityEngine.Timeline.RuntimeElement>m_ActiveClipsSet  // 0x38
  private           System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement>m_CurrentListOfActiveClips  // 0x40
  private           System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement>m_ActiveClipsCalcCache  // 0x48
  private           System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement>m_RuntimeResetClipCache  // 0x50
  private           System.Int32                    m_ActiveBit  // 0x58
  private           System.Boolean                  m_needEvaluateTwice  // 0x5C
  private           System.Boolean                  m_isTimelineEnded  // 0x5D
  private           System.Collections.Generic.List<UnityEngine.Timeline.ITimelineEvaluateCallback>m_EvaluateCallbacks  // 0x60
  private           System.Collections.Generic.Dictionary<UnityEngine.Timeline.TrackAsset,UnityEngine.Playables.Playable>m_PlayableCache  // 0x68
  private           UnityEngine.Playables.PlayableDirectorm_TopDirector  // 0x70
  private           System.Collections.Generic.List<UnityEngine.Playables.PlayableDirector>m_AllDirectorUnderRoot  // 0x78
  private           UnityEngine.Playables.PlayableDirectorm_DirectorHoldingThisPlayable  // 0x80
  private           UnityEngine.Timeline.ITimelineRootMarkerm_RootMarker  // 0x88
  private           System.Collections.Generic.List<UnityEngine.Timeline.IScriptAnimationJobSync>m_ScriptAnimationJobSyncs  // 0x90
  private   static  System.Boolean                  muteAudioScrubbing  // 0x0
  private           System.Double                   m_timeForNextFrame  // 0x98
METHODS:
  System.Double get_timeForNextFrame()
  UnityEngine.Timeline.ITimelineRootMarker get_timelineRootMarker()
  System.Boolean get_enableLoop()
  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimelinePlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean autoRebalance, System.Boolean createOutputs)
  System.Void Compile(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean autoRebalance, System.Boolean createOutputs)
  System.Void MarkTimelineEnd()
  System.Boolean IsTimelineEnded()
  System.Void CompileCombineTopTopTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Boolean createOutputs)
  System.Void CollectCombineToTopTracksRecursive(UnityEngine.Timeline.TrackAsset track, System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> combineTracks)
  System.Void CompileTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, System.Boolean createOutputs, System.Boolean isCompilingCombineToTopTracks)
  System.Void CreateTrackOutput(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, UnityEngine.Playables.Playable playable, System.Int32 port)
  System.Void EvaluateWeightsForAnimationPlayableOutput(UnityEngine.Timeline.TrackAsset track, UnityEngine.Animations.AnimationPlayableOutput animOutput, UnityEngine.Animator animator)
  UnityEngine.Playables.Playable CreateTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, System.Boolean createOutputs)
  System.Void UpdateIntervalTree()
  System.Void RuntimeResetIntervalTree()
  System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
  System.Void _ResetScriptAnimationJobySyncs()
  System.Void _EvaluateTwice()
  System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetCurrentActiveClips()
  System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetActiveClipsAtGivenTime(System.Double givenTime, System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeClips)
  System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> GetActiveClipsAtGivenTimeRange(System.Double startTime, System.Double endTime, System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> activeClips)
  System.Void Evaluate(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData frameData)
  System.Boolean DoReverseLoop(System.Double reverseTime)
  System.Boolean DoReverseJump(UnityEngine.Timeline.RuntimeClip runtimeClip, System.Double jumpTime)
  System.Boolean DoJump(UnityEngine.Timeline.RuntimeClip runtimeClip, System.Double localTime, System.Double jumpTime)
  System.Boolean _CheckIfTimeJumping(UnityEngine.Playables.FrameData frameData, System.Double localTime)
  System.Void CacheTrack(UnityEngine.Timeline.TrackAsset track, UnityEngine.Playables.Playable playable, System.Int32 port, UnityEngine.Playables.Playable parent)
  System.Void SetTimeForNextFrame(System.Double newTime)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.AnimationPreviewUtilities
TYPE:  class
TOKEN: 0x20000A1
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.Extrapolation
TYPE:  class
TOKEN: 0x20000A2
FIELDS:
  private   static readonly System.Double                   kMinExtrapolationTime  // 0x0
METHODS:
  System.Void CalculateExtrapolationTimes(UnityEngine.Timeline.TrackAsset asset)
  UnityEngine.Timeline.TimelineClip[] SortClipsByStartTime(UnityEngine.Timeline.TimelineClip[] clips)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.HashUtility
TYPE:  class
TOKEN: 0x20000A4
FIELDS:
METHODS:
  System.Int32 CombineHash(System.Int32 h1, System.Int32 h2)
  System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3)
  System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4)
  System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4, System.Int32 h5)
  System.Int32 CombineHash(System.Int32 h1, System.Int32 h2, System.Int32 h3, System.Int32 h4, System.Int32 h5, System.Int32 h6)
END_CLASS

CLASS: UnityEngine.Timeline.IPropertyCollector
TYPE:  interface
TOKEN: 0x20000A5
FIELDS:
METHODS:
  System.Void PushActiveGameObject(UnityEngine.GameObject gameObject)
  System.Void PopActiveGameObject()
  System.Void AddFromClip(UnityEngine.AnimationClip clip)
  System.Void AddFromName(System.String name)
  System.Void AddFromName(UnityEngine.GameObject obj, System.String name)
  System.Void AddFromName(UnityEngine.GameObject obj, System.String name)
  System.Void AddFromComponent(UnityEngine.GameObject obj, UnityEngine.Component component)
  System.Void AddObjectProperties(UnityEngine.Object obj, UnityEngine.AnimationClip clip)
END_CLASS

CLASS: UnityEngine.Timeline.IPropertyPreview
TYPE:  interface
TOKEN: 0x20000A6
FIELDS:
METHODS:
  System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
END_CLASS

CLASS: UnityEngine.Timeline.NotificationUtilities
TYPE:  class
TOKEN: 0x20000A7
FIELDS:
METHODS:
  UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, System.Double duration, UnityEngine.Playables.DirectorWrapMode extrapolationMode)
  System.Boolean TrackTypeSupportsNotifications(System.Type type)
END_CLASS

CLASS: UnityEngine.Timeline.PlayableDirectorUtility
TYPE:  class
TOKEN: 0x20000A8
FIELDS:
METHODS:
  System.Void SetOptionIndexSingleDirector(UnityEngine.Playables.PlayableDirector director, System.Int32 curOptionIndex, System.Int32 lastOptionIndex)
  UnityEngine.Timeline.TimelinePlayable GetTimelinePlayable(UnityEngine.Playables.PlayableDirector director)
  UnityEngine.Timeline.TimelinePlayable GetTimelinePlayable(UnityEngine.Playables.PlayableGraph graph)
  UnityEngine.Timeline.TimelinePlayable GetTimelinePlayableFromChildPlayable(UnityEngine.Playables.Playable playable)
  System.Boolean CheckIfTimelineFunctional(UnityEngine.Playables.Playable playable)
END_CLASS

CLASS: UnityEngine.Timeline.TimelineClipExtensions
TYPE:  class
TOKEN: 0x20000A9
FIELDS:
  private   static readonly System.String                   k_UndoSetParentTrackText  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimelineCreateUtilities
TYPE:  class
TOKEN: 0x20000AA
FIELDS:
METHODS:
  System.String GenerateUniqueActorName(System.Collections.Generic.List<UnityEngine.ScriptableObject> tracks, System.String name)
  System.Void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset)
  UnityEngine.AnimationClip CreateAnimationClipForTrack(System.String name, UnityEngine.Timeline.TrackAsset track, System.Boolean isLegacy)
  System.Boolean ValidateParentTrack(UnityEngine.Timeline.TrackAsset parent, System.Type childType)
END_CLASS

CLASS: UnityEngine.Timeline.TimelineRuntimeUtils
TYPE:  class
TOKEN: 0x20000AD
FIELDS:
METHODS:
  System.Boolean CheckWillRuntimeElementEnabled(UnityEngine.Timeline.RuntimeElement element, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Int64 curDiscreteTime)
  System.Void DoReverseJump(UnityEngine.Timeline.RuntimeClip jumpClip, UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double curTime, System.Double jumpTime, System.Double mixDuration, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Boolean needChangeOptionAfterJump, System.Int32 newOptionIndex)
  System.Void DoJump(UnityEngine.Timeline.RuntimeClip jumpClip, UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double curTime, System.Double jumpTime, System.Double mixDuration, System.Int32 curOptionIndex, System.Int32 lastOptionIndex, System.Boolean needChangeOptionAfterJump, System.Int32 optionIndexChangingTo)
  System.Double GetSubDirectorTimeForDirectorControl(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableDirector director)
  System.Void SetNewTimeForCutsceneRoot(UnityEngine.Timeline.ITimelineRootMarker timelineRoot, System.Double newTime, System.Boolean useThisTimeNextFrame)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Timeline.TimelineUndo
TYPE:  class
TOKEN: 0x20000AE
FIELDS:
METHODS:
  System.Void PushDestroyUndo(UnityEngine.Timeline.TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy)
END_CLASS

CLASS: UnityEngine.Timeline.StandardFrameRates
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Timeline.StandardFrameRatesFps24  // 0x0
  public    static  UnityEngine.Timeline.StandardFrameRatesFps23_97  // 0x0
  public    static  UnityEngine.Timeline.StandardFrameRatesFps25  // 0x0
  public    static  UnityEngine.Timeline.StandardFrameRatesFps30  // 0x0
  public    static  UnityEngine.Timeline.StandardFrameRatesFps29_97  // 0x0
  public    static  UnityEngine.Timeline.StandardFrameRatesFps50  // 0x0
  public    static  UnityEngine.Timeline.StandardFrameRatesFps60  // 0x0
  public    static  UnityEngine.Timeline.StandardFrameRatesFps59_94  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Timeline.TimeUtility
TYPE:  class
TOKEN: 0x20000B0
FIELDS:
  public    static readonly System.Double                   kTimeEpsilon  // 0x0
  public    static readonly System.Double                   kFrameRateEpsilon  // 0x8
  public    static readonly System.Double                   k_MaxTimelineDurationInSeconds  // 0x10
  public    static readonly System.Double                   kFrameRateRounding  // 0x18
METHODS:
  System.Double GetAnimationClipLength(UnityEngine.AnimationClip clip)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Timeline.WeightUtility
TYPE:  class
TOKEN: 0x20000B2
FIELDS:
METHODS:
  System.Single NormalizeMixer(UnityEngine.Playables.Playable mixer)
END_CLASS

CLASS: UnityEngine.Timeline.Condition.TimelineConditionControlMono
TYPE:  class
TOKEN: 0x20000B3
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.PackageBridge.Timeline.TimelineConditionBasecondition  // 0x18
METHODS:
  System.Void RefreshOnCondition()
  System.Void .ctor()
END_CLASS

