// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AnimationModule.dll
// Classes:  101
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Enumerator
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private           UnityEngine.Animation           m_Outer  // 0x10
  private           System.Int32                    m_CurrentIndex  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Animation outer)
  System.Object get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
END_CLASS

CLASS: AnimationEventCallback
TYPE:  class
TOKEN: 0x2000028
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.Animator animator, UnityEngine.FastAnimationEvent fastAnimationEvent)
END_CLASS

CLASS: AnimatorStateChangeCallback
TYPE:  class
TOKEN: 0x2000029
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, System.Int32 layerIndex)
END_CLASS

CLASS: AnimationEventCallbackOpt
TYPE:  class
TOKEN: 0x200002A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.Animator animator, UnityEngine.FastAnimationEventGroup fastAnimationEvent)
END_CLASS

CLASS: AniamtorCommonCallback
TYPE:  class
TOKEN: 0x200002B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Animator animator)
END_CLASS

CLASS: OnOverrideControllerDirtyCallback
TYPE:  class
TOKEN: 0x200002F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: ExecuteJobFunction
TYPE:  class
TOKEN: 0x200004D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T& data, System.IntPtr animationStreamPtr, System.IntPtr unusedPtr, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: UnityEngine.IAnimationClipSource
TYPE:  interface
TOKEN: 0x2000002
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.SharedBetweenAnimatorsAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.StateMachineBehaviour
TYPE:  class
TOKEN: 0x2000004
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  System.Void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  System.Void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  System.Void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  System.Void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  System.Void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  System.Void OnStatePreExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex)
  System.Void OnStateMachineEnter(UnityEngine.Animator animator, System.Int32 stateMachinePathHash)
  System.Void OnStateMachineExit(UnityEngine.Animator animator, System.Int32 stateMachinePathHash)
  System.Void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  System.Void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  System.Void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  System.Void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  System.Void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  System.Void OnStatePreExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
  System.Void OnStateMachineEnter(UnityEngine.Animator animator, System.Int32 stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller)
  System.Void OnStateMachineExit(UnityEngine.Animator animator, System.Int32 stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.PlayMode
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.PlayMode            StopSameLayer  // 0x0
  public    static  UnityEngine.PlayMode            StopAll  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.QueueMode
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.QueueMode           CompleteOthers  // 0x0
  public    static  UnityEngine.QueueMode           PlayNow  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationBlendMode
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimationBlendMode  Blend  // 0x0
  public    static  UnityEngine.AnimationBlendMode  Additive  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationPlayMode
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimationPlayMode   Stop  // 0x0
  public    static  UnityEngine.AnimationPlayMode   Queue  // 0x0
  public    static  UnityEngine.AnimationPlayMode   Mix  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationCullingType
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimationCullingTypeAlwaysAnimate  // 0x0
  public    static  UnityEngine.AnimationCullingTypeBasedOnRenderers  // 0x0
  public    static  UnityEngine.AnimationCullingTypeBasedOnClipBounds  // 0x0
  public    static  UnityEngine.AnimationCullingTypeBasedOnUserBounds  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationEventSource
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimationEventSourceNoSource  // 0x0
  public    static  UnityEngine.AnimationEventSourceLegacy  // 0x0
  public    static  UnityEngine.AnimationEventSourceAnimator  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimEventHashCodeType
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimEventHashCodeTypeNone  // 0x0
  public    static  UnityEngine.AnimEventHashCodeTypeCRC32  // 0x0
  public    static  UnityEngine.AnimEventHashCodeTypeHashCode64  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Animation
TYPE:  class
TOKEN: 0x200000C
EXTENDS: Behaviour
FIELDS:
METHODS:
  UnityEngine.AnimationClip get_clip()
  System.Void set_clip(UnityEngine.AnimationClip value)
  System.Boolean get_playAutomatically()
  System.Void set_playAutomatically(System.Boolean value)
  UnityEngine.WrapMode get_wrapMode()
  System.Void set_wrapMode(UnityEngine.WrapMode value)
  System.Void Stop()
  System.Void Stop(System.String name)
  System.Void StopNamed(System.String name)
  System.Void Rewind()
  System.Void Rewind(System.String name)
  System.Void RewindNamed(System.String name)
  System.Void Sample()
  System.Boolean get_isPlaying()
  System.Boolean IsPlaying(System.String name)
  UnityEngine.AnimationState get_Item(System.String name)
  System.Boolean Play()
  System.Boolean Play(UnityEngine.PlayMode mode)
  System.Boolean PlayDefaultAnimation(UnityEngine.PlayMode mode)
  System.Boolean Play(System.String animation)
  System.Boolean Play(System.String animation, UnityEngine.PlayMode mode)
  System.Void CrossFade(System.String animation)
  System.Void CrossFade(System.String animation, System.Single fadeLength)
  System.Void CrossFade(System.String animation, System.Single fadeLength, UnityEngine.PlayMode mode)
  System.Void Blend(System.String animation)
  System.Void Blend(System.String animation, System.Single targetWeight)
  System.Void Blend(System.String animation, System.Single targetWeight, System.Single fadeLength)
  UnityEngine.AnimationState CrossFadeQueued(System.String animation)
  UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength)
  UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength, UnityEngine.QueueMode queue)
  UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode)
  UnityEngine.AnimationState PlayQueued(System.String animation)
  UnityEngine.AnimationState PlayQueued(System.String animation, UnityEngine.QueueMode queue)
  UnityEngine.AnimationState PlayQueued(System.String animation, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode)
  System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName)
  System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName, System.Int32 firstFrame, System.Int32 lastFrame)
  System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName, System.Int32 firstFrame, System.Int32 lastFrame, System.Boolean addLoopFrame)
  System.Void RemoveClip(UnityEngine.AnimationClip clip)
  System.Void RemoveClip(System.String clipName)
  System.Void RemoveClipNamed(System.String clipName)
  System.Int32 GetClipCount()
  System.Boolean Play(UnityEngine.AnimationPlayMode mode)
  System.Boolean Play(System.String animation, UnityEngine.AnimationPlayMode mode)
  System.Void SyncLayer(System.Int32 layer)
  System.Collections.IEnumerator GetEnumerator()
  UnityEngine.AnimationState GetState(System.String name)
  UnityEngine.AnimationState GetStateAtIndex(System.Int32 index)
  System.Int32 GetStateCount()
  UnityEngine.AnimationClip GetClip(System.String name)
  System.Boolean get_animatePhysics()
  System.Void set_animatePhysics(System.Boolean value)
  System.Boolean get_animateOnlyIfVisible()
  System.Void set_animateOnlyIfVisible(System.Boolean value)
  UnityEngine.AnimationCullingType get_cullingType()
  System.Void set_cullingType(UnityEngine.AnimationCullingType value)
  UnityEngine.Bounds get_localBounds()
  System.Void set_localBounds(UnityEngine.Bounds value)
  System.Void .ctor()
  System.Void get_localBounds_Injected(UnityEngine.Bounds& ret)
  System.Void set_localBounds_Injected(UnityEngine.Bounds& value)
END_CLASS

CLASS: UnityEngine.AnimationState
TYPE:  class
TOKEN: 0x200000E
EXTENDS: TrackedReference
FIELDS:
METHODS:
  System.Boolean get_enabled()
  System.Void set_enabled(System.Boolean value)
  System.Single get_weight()
  System.Void set_weight(System.Single value)
  UnityEngine.WrapMode get_wrapMode()
  System.Void set_wrapMode(UnityEngine.WrapMode value)
  System.Single get_time()
  System.Void set_time(System.Single value)
  System.Single get_normalizedTime()
  System.Void set_normalizedTime(System.Single value)
  System.Single get_speed()
  System.Void set_speed(System.Single value)
  System.Single get_normalizedSpeed()
  System.Void set_normalizedSpeed(System.Single value)
  System.Single get_length()
  System.Int32 get_layer()
  System.Void set_layer(System.Int32 value)
  UnityEngine.AnimationClip get_clip()
  System.String get_name()
  System.Void set_name(System.String value)
  UnityEngine.AnimationBlendMode get_blendMode()
  System.Void set_blendMode(UnityEngine.AnimationBlendMode value)
  System.Void AddMixingTransform(UnityEngine.Transform mix)
  System.Void AddMixingTransform(UnityEngine.Transform mix, System.Boolean recursive)
  System.Void RemoveMixingTransform(UnityEngine.Transform mix)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.FastAnimationEvent
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  private           System.Single                   m_Time  // 0x10
  private           System.Single                   m_ClipWeight  // 0x14
  private           System.String                   m_FunctionName  // 0x18
  private           System.String                   m_StringParameter  // 0x20
  private           UnityEngine.Object              m_ObjectReferenceParameter  // 0x28
  private           System.Single                   m_FloatParameter  // 0x30
  private           System.Int32                    m_IntParameter  // 0x34
  private           UnityEngine.SendMessageOptions  m_MessageOptions  // 0x38
  private           System.Int32                    m_StringParameterHashCode  // 0x3C
  private           System.Int32                    m_FunctionNameHashCode  // 0x40
  private           System.Boolean                  m_IsInTransition  // 0x44
  private           System.Boolean                  m_IsFromMaxWeightClipState  // 0x45
  private           System.Boolean                  m_IsFromNextMaxWeightClipState  // 0x46
METHODS:
  System.String get_stringParameter()
  System.Void set_stringParameter(System.String value)
  System.Single get_floatParameter()
  System.Void set_floatParameter(System.Single value)
  System.Int32 get_intParameter()
  System.Void set_intParameter(System.Int32 value)
  System.String get_functionName()
  System.Void set_time(System.Single value)
  System.Void set_messageOptions(UnityEngine.SendMessageOptions value)
  System.Single get_clipWeight()
  System.Void set_clipWeight(System.Single value)
  System.Boolean get_isInTransition()
  System.Void set_isInTransition(System.Boolean value)
  System.Boolean get_isFromMaxWeightClipState()
  System.Void set_isFromMaxWeightClipState(System.Boolean value)
  System.Boolean get_isFromNextMaxWeightClipState()
  System.Void set_isFromNextMaxWeightClipState(System.Boolean value)
  System.Int32 get_functionNameHashCode()
  System.Void set_functionNameHashCode(System.Int32 value)
END_CLASS

CLASS: UnityEngine.FastAnimationEventGroup
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Int32                    count  // 0x10
  public            System.IntPtr                   times  // 0x18
  public            System.IntPtr                   clipWeights  // 0x20
  public            System.IntPtr                   functionNames  // 0x28
  public            System.IntPtr                   stringParameters  // 0x30
  public            System.IntPtr                   functionNamesHashCode  // 0x38
  public            System.IntPtr                   stringParametersHashCode  // 0x40
  public            System.IntPtr                   floatParameters  // 0x48
  public            System.IntPtr                   intParameters  // 0x50
  public            System.IntPtr                   messageOptions  // 0x58
  public            System.IntPtr                   inTransitions  // 0x60
  public            System.IntPtr                   isFromMaxWeightClipStatus  // 0x68
  public            System.IntPtr                   isFromNextMaxWeightClipStatus  // 0x70
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationEvent
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  private           System.Single                   m_Time  // 0x10
  private           System.String                   m_FunctionName  // 0x18
  private           System.String                   m_StringParameter  // 0x20
  private           UnityEngine.Object              m_ObjectReferenceParameter  // 0x28
  private           System.Single                   m_FloatParameter  // 0x30
  private           System.Int32                    m_IntParameter  // 0x34
  private           System.Int32                    m_MessageOptions  // 0x38
  private           UnityEngine.AnimationEventSourcem_Source  // 0x3C
  private           UnityEngine.AnimationState      m_StateSender  // 0x40
  private           UnityEngine.AnimatorStateInfo   m_AnimatorStateInfo  // 0x48
  private           UnityEngine.AnimatorClipInfo    m_AnimatorClipInfo  // 0x7C
  private           UnityEngine.AnimEventHashCodeTypem_HashCodeType  // 0x84
METHODS:
  System.Void .ctor()
  System.String get_stringParameter()
  System.Void set_stringParameter(System.String value)
  System.Single get_floatParameter()
  System.Void set_floatParameter(System.Single value)
  System.Int32 get_intParameter()
  System.Void set_intParameter(System.Int32 value)
  System.Void set_objectReferenceParameter(UnityEngine.Object value)
  System.String get_functionName()
  System.Void set_functionName(System.String value)
  System.Single get_time()
  System.Void set_time(System.Single value)
  System.Void set_messageOptions(UnityEngine.SendMessageOptions value)
  System.Boolean get_isFiredByAnimator()
  UnityEngine.AnimatorClipInfo get_animatorClipInfo()
END_CLASS

CLASS: UnityEngine.AnimationClip
TYPE:  class
TOKEN: 0x2000012
EXTENDS: Motion
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Internal_CreateAnimationClip(UnityEngine.AnimationClip self)
  System.Void SampleAnimation(UnityEngine.GameObject go, System.Single time)
  System.Void SampleAnimationFast(UnityEngine.GameObject go, System.Single time)
  System.Void SampleAnimation(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, System.Single inTime, UnityEngine.WrapMode wrapMode)
  System.Void SampleAnimationFast(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, System.Single inTime, UnityEngine.WrapMode wrapMode)
  System.Single get_length()
  System.Single get_startTime()
  System.Single get_stopTime()
  System.Single get_frameRate()
  System.Void set_frameRate(System.Single value)
  System.UInt16 get_clipTag()
  System.Void set_clipTag(System.UInt16 value)
  System.Void SetCurve(System.String relativePath, System.Type type, System.String propertyName, UnityEngine.AnimationCurve curve)
  System.Boolean GetAnimatorFloatCurve(System.String propertyName, UnityEngine.AnimationCurve curve)
  System.Void EnsureQuaternionContinuity()
  System.Void ClearCurves()
  System.UInt32 GetRuntimeMemorySize()
  UnityEngine.WrapMode get_wrapMode()
  System.Void set_wrapMode(UnityEngine.WrapMode value)
  UnityEngine.Bounds get_localBounds()
  System.Void set_localBounds(UnityEngine.Bounds value)
  System.Boolean get_legacy()
  System.Void set_legacy(System.Boolean value)
  System.Boolean get_humanMotion()
  System.Boolean get_empty()
  System.Boolean get_hasGenericRootTransform()
  System.Boolean get_hasMotionFloatCurves()
  System.Boolean get_hasMotionCurves()
  System.Boolean get_hasRootCurves()
  System.Boolean get_hasRootMotion()
  System.Boolean get_transferRotationCompressed()
  System.Void set_transferRotationCompressed(System.Boolean value)
  System.UInt64 get_uniqueId()
  System.Void AddEvent(UnityEngine.AnimationEvent evt)
  System.Void AddEventInternal(System.Object evt)
  UnityEngine.AnimationEvent[] get_events()
  System.Void set_events(UnityEngine.AnimationEvent[] value)
  System.Void SetEventsInternal(System.Array value)
  System.Array GetEventsInternal()
  System.Void get_localBounds_Injected(UnityEngine.Bounds& ret)
  System.Void set_localBounds_Injected(UnityEngine.Bounds& value)
END_CLASS

CLASS: UnityEngine.AvatarTarget
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AvatarTarget        Root  // 0x0
  public    static  UnityEngine.AvatarTarget        Body  // 0x0
  public    static  UnityEngine.AvatarTarget        LeftFoot  // 0x0
  public    static  UnityEngine.AvatarTarget        RightFoot  // 0x0
  public    static  UnityEngine.AvatarTarget        LeftHand  // 0x0
  public    static  UnityEngine.AvatarTarget        RightHand  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AvatarIKGoal
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AvatarIKGoal        LeftFoot  // 0x0
  public    static  UnityEngine.AvatarIKGoal        RightFoot  // 0x0
  public    static  UnityEngine.AvatarIKGoal        LeftHand  // 0x0
  public    static  UnityEngine.AvatarIKGoal        RightHand  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AvatarIKHint
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AvatarIKHint        LeftKnee  // 0x0
  public    static  UnityEngine.AvatarIKHint        RightKnee  // 0x0
  public    static  UnityEngine.AvatarIKHint        LeftElbow  // 0x0
  public    static  UnityEngine.AvatarIKHint        RightElbow  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorControllerParameterType
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorControllerParameterTypeFloat  // 0x0
  public    static  UnityEngine.AnimatorControllerParameterTypeInt  // 0x0
  public    static  UnityEngine.AnimatorControllerParameterTypeBool  // 0x0
  public    static  UnityEngine.AnimatorControllerParameterTypeTrigger  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.StateInfoIndex
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.StateInfoIndex      CurrentState  // 0x0
  public    static  UnityEngine.StateInfoIndex      NextState  // 0x0
  public    static  UnityEngine.StateInfoIndex      ExitState  // 0x0
  public    static  UnityEngine.StateInfoIndex      InterruptedState  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationBlendStyle
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimationBlendStyle Linear  // 0x0
  public    static  UnityEngine.AnimationBlendStyle CubicIn  // 0x0
  public    static  UnityEngine.AnimationBlendStyle HermiteCubic  // 0x0
  public    static  UnityEngine.AnimationBlendStyle Sinusoidal  // 0x0
  public    static  UnityEngine.AnimationBlendStyle CubicInOut  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorTransitionInterruptionSource
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorTransitionInterruptionSourceNone  // 0x0
  public    static  UnityEngine.AnimatorTransitionInterruptionSourceCurrent  // 0x0
  public    static  UnityEngine.AnimatorTransitionInterruptionSourceNext  // 0x0
  public    static  UnityEngine.AnimatorTransitionInterruptionSourceCurrentThenNext  // 0x0
  public    static  UnityEngine.AnimatorTransitionInterruptionSourceNextThenCurrent  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorRecorderMode
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorRecorderModeOffline  // 0x0
  public    static  UnityEngine.AnimatorRecorderModePlayback  // 0x0
  public    static  UnityEngine.AnimatorRecorderModeRecord  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorUroMode
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorUroMode     Origin  // 0x0
  public    static  UnityEngine.AnimatorUroMode     Predict  // 0x0
  public    static  UnityEngine.AnimatorUroMode     PredictWithTick  // 0x0
  public    static  UnityEngine.AnimatorUroMode     PredictWithTickAndRootMotion  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorCullingMode
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorCullingMode AlwaysAnimate  // 0x0
  public    static  UnityEngine.AnimatorCullingMode CullUpdateTransforms  // 0x0
  public    static  UnityEngine.AnimatorCullingMode CullCompletely  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorUpdateMode
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorUpdateMode  Normal  // 0x0
  public    static  UnityEngine.AnimatorUpdateMode  AnimatePhysics  // 0x0
  public    static  UnityEngine.AnimatorUpdateMode  UnscaledTime  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorJobDispatchMode
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AnimatorJobDispatchModeDefault  // 0x0
  public    static  UnityEngine.AnimatorJobDispatchModeForceMainThread  // 0x0
  public    static  UnityEngine.AnimatorJobDispatchModeCrossFrame  // 0x0
  public    static  UnityEngine.AnimatorJobDispatchModeCrossFrameLateUpdate  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorLOD
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Single                   worldAbsoluteDistance  // 0x10
  public            System.Single                   maxDeltaTime  // 0x14
  public            System.Int32                    framesPerUpdate  // 0x18
  public            System.Single                   maxBlendDeltaTime  // 0x1C
  public            System.Int32                    framesPerWrite  // 0x20
  public            System.Int32                    delayFrame  // 0x24
  public            UnityEngine.AnimatorUroMode     uroMode  // 0x28
METHODS:
  System.Void .ctor(System.Single worldAbsoluteDistance, System.Int32 framesPerUpdate, System.Single maxDeltaTime, System.Int32 framesPerWrite, System.Single maxBlendDeltaTime, UnityEngine.AnimatorUroMode uroMode, System.Int32 delayFrame)
END_CLASS

CLASS: UnityEngine.AnimationTransformRWBufferHandle
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.UInt16                   count  // 0x10
  public            System.UInt16                   invalidCount  // 0x12
  public            System.IntPtr                   validTransformIndexsPtr  // 0x18
  public            System.IntPtr                   invalidTransformIndexsPtr  // 0x20
  public            System.IntPtr                   localPositionsPtr  // 0x28
  public            System.IntPtr                   localRotationsPtr  // 0x30
  public            System.IntPtr                   localScalesPtr  // 0x38
  public            System.IntPtr                   positionsPtr  // 0x40
  public            System.IntPtr                   rotationsPtr  // 0x48
  public            System.IntPtr                   scalesPtr  // 0x50
  public            System.IntPtr                   physicsRatioPtr  // 0x58
  public            System.IntPtr                   writeFlagPtr  // 0x60
  public            System.IntPtr                   relativePostionPtr  // 0x68
  public            System.IntPtr                   relativeRotationPtr  // 0x70
  public            System.IntPtr                   relativeScalePtr  // 0x78
METHODS:
END_CLASS

CLASS: UnityEngine.HGAnimParameterSGHandle
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    errorCode  // 0x10
  public            System.UInt16                   floatParameterCount  // 0x14
  public            System.UInt16                   boolParameterCount  // 0x16
  public            System.UInt16                   intParameterCount  // 0x18
  public            System.UInt16                   layerCount  // 0x1A
  public            System.IntPtr                   floatParameterNamesPtr  // 0x20
  public            System.IntPtr                   floatParameterValuesPtr  // 0x28
  public            System.IntPtr                   boolParameterNamesPtr  // 0x30
  public            System.IntPtr                   boolParameterValuesPtr  // 0x38
  public            System.IntPtr                   intParameterNamesPtr  // 0x40
  public            System.IntPtr                   intParameterValuesPtr  // 0x48
  public            System.IntPtr                   layerWeightPtr  // 0x50
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorClipInfo
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  private           System.Int32                    m_ClipInstanceID  // 0x10
  private           System.Single                   m_Weight  // 0x14
METHODS:
  UnityEngine.AnimationClip get_clip()
  System.Single get_weight()
  UnityEngine.AnimationClip InstanceIDToAnimationClipPPtr(System.Int32 instanceID)
END_CLASS

CLASS: UnityEngine.AnimatorStateInfo
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  private           System.Int32                    m_Name  // 0x10
  private           System.Int32                    m_Path  // 0x14
  private           System.Int32                    m_FullPath  // 0x18
  private           System.Single                   m_NormalizedTime  // 0x1C
  private           System.Single                   m_Length  // 0x20
  private           System.Single                   m_Speed  // 0x24
  private           System.Single                   m_SpeedMultiplier  // 0x28
  private           System.Int32                    m_Tag  // 0x2C
  private           System.Int32                    m_Loop  // 0x30
  private           System.Int32                    m_SyncGroup  // 0x34
  private           System.Int32                    m_SyncGroupRole  // 0x38
  private           System.Int32                    m_CullingMode  // 0x3C
  private           System.Int32                    m_SourceMsg  // 0x40
METHODS:
  System.Boolean IsName(System.String name)
  System.Int32 get_fullPathHash()
  System.Int32 get_shortNameHash()
  System.Single get_normalizedTime()
  System.Single get_length()
  System.Int32 get_tagHash()
  System.Boolean IsTag(System.String tag)
  System.Boolean get_loop()
END_CLASS

CLASS: UnityEngine.AnimatorStateRootMotionInfo
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  private           System.Int32                    m_NameHashLeft  // 0x10
  private           UnityEngine.Vector3             m_DeltaPositionLeft  // 0x14
  private           UnityEngine.Quaternion          m_DeltaRotationLeft  // 0x20
  private           System.Int32                    m_NameHashRight  // 0x30
  private           UnityEngine.Vector3             m_DeltaPositionRight  // 0x34
  private           UnityEngine.Quaternion          m_DeltaRotationRight  // 0x40
  private           System.Single                   m_TransitionWeight  // 0x50
  private           System.Single                   m_DeltaTime  // 0x54
  private           System.Single                   m_InterruptedTransitionWeight  // 0x58
  private           System.Int32                    m_NameHashinterrupted  // 0x5C
  private           UnityEngine.Vector3             m_DeltaPositioninterrupted  // 0x60
  private           UnityEngine.Quaternion          m_DeltaRotationinterrupted  // 0x6C
METHODS:
END_CLASS

CLASS: UnityEngine.AnimatorTransitionInfo
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  private           System.Int32                    m_FullPath  // 0x10
  private           System.Int32                    m_UserName  // 0x14
  private           System.Int32                    m_Name  // 0x18
  private           System.Boolean                  m_HasFixedDuration  // 0x1C
  private           System.Single                   m_Duration  // 0x20
  private           System.Single                   m_NormalizedTime  // 0x24
  private           System.Boolean                  m_AnyState  // 0x28
  private           System.Int32                    m_TransitionType  // 0x2C
METHODS:
  System.Boolean IsUserName(System.String name)
  System.Int32 get_nameHash()
END_CLASS

CLASS: UnityEngine.MatchTargetWeightMask
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  private           UnityEngine.Vector3             m_PositionXYZWeight  // 0x10
  private           System.Single                   m_RotationWeight  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3 positionXYZWeight, System.Single rotationWeight)
END_CLASS

CLASS: UnityEngine.Animator
TYPE:  class
TOKEN: 0x2000027
EXTENDS: Behaviour
FIELDS:
  private           UnityEngine.Animator.AnimationEventCallbackonAnimationEvent  // 0x18
  private           UnityEngine.Animator.AnimationEventCallbackOptonAnimationEventOpt  // 0x20
  private           UnityEngine.Animator.AnimatorStateChangeCallbackonAnimatorStateEnter  // 0x28
  private           UnityEngine.Animator.AnimatorStateChangeCallbackonAnimatorStateExit  // 0x30
  private           UnityEngine.Animator.AnimatorStateChangeCallbackonAnimatorStatePreExit  // 0x38
  private           UnityEngine.Animator.AniamtorCommonCallbackafterAnimatorUpdateGraphCB  // 0x40
METHODS:
  System.Void .ctor()
  System.Void Internal_CallAnimatorStateChangeCallback(UnityEngine.Animator anim, UnityEngine.AnimatorStateInfo animatorStateInfo, System.Int32 layerIndex, System.Int32 methodIdx)
  System.Void Internal_CallAfterUpdateGraph(UnityEngine.Animator anim)
  System.Boolean Internal_InvokeAnimationEventCallback(UnityEngine.Animator animator, UnityEngine.FastAnimationEvent fastAnimationEvent)
  System.Boolean Internal_InvokeAnimationEventCallbackOpt(UnityEngine.Animator animator, UnityEngine.FastAnimationEventGroup fastAnimationEvent)
  System.Void SetCallbackAfterRootMotionStageCallback(UnityEngine.Animator.AniamtorCommonCallback cb)
  System.Void SetAnimationEventCallback(UnityEngine.Animator.AnimationEventCallback onAnimationEvent)
  System.Void SetAnimationEventCallbackOpt(UnityEngine.Animator.AnimationEventCallbackOpt onAnimationEvent)
  System.Void SetNotifyAnimatorStateEnterAndExitEventCallBack(UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateEnter, UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateExit)
  System.Void SetNotifyAnimatorStatePreExitEventCallBack(UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStatePreExit)
  System.Boolean get_fastAnimationEventsOpt()
  System.Void set_fastAnimationEventsOpt(System.Boolean value)
  System.Boolean get_callBackAfterUpdateGraph()
  System.Void set_callBackAfterUpdateGraph(System.Boolean value)
  System.Boolean get_fastAnimationEvents()
  System.Void set_fastAnimationEvents(System.Boolean value)
  System.Boolean get_notifyAnimatorStateEnterAndExitEvent()
  System.Void set_notifyAnimatorStateEnterAndExitEvent(System.Boolean value)
  System.Boolean get_isOptimizable()
  System.Boolean get_isHuman()
  System.Boolean get_hasRootMotion()
  System.Boolean get_isRootPositionOrRotationControlledByCurves()
  System.Single get_humanScale()
  System.Boolean get_isInitialized()
  System.Boolean get_isVisible()
  System.Boolean get_updatedLastFrame()
  System.Boolean get_enableLOD()
  System.Void set_enableLOD(System.Boolean value)
  System.Int32 get_LODLevel()
  System.Boolean SetLODLevel(System.Int32 level)
  System.Int32 GetCurrentLODLevel()
  UnityEngine.AnimatorLOD[] GetLODs()
  System.Void SetLODs(UnityEngine.AnimatorLOD[] lods)
  System.Void SetConstraintEnableImmediately(System.Int32 nameHash)
  System.Void SetConstraintDisableImmediately(System.Int32 nameHash)
  System.Void SetConstraintEnableBlendIn(System.Int32 nameHash, System.Single duration)
  System.Void SetConstraintDisableBlendOut(System.Int32 nameHash, System.Single duration)
  System.Void BecameVisible()
  System.Void SetAnimatorJobOptEnable(System.Boolean enabel)
  System.Void SetAnimatorJobOptFunc(System.Int32 value)
  System.Void SetAnimatorWriteTransformOpt(System.Boolean value)
  System.Void SetGlobalAnimatorClipBindingsOpt(System.Boolean value)
  System.Void SetGlobalAnimatorClipBindingsConstantOpt(System.Boolean value)
  System.Void SetGlobalAnimatorClipBindingsOptByAvatar(System.Boolean value)
  System.Void SetAnimatorUroMaxDeltaTimePerframe(System.Single value)
  System.Void SetGlobalAnimatorCacheClipBindingsOpt(System.Boolean value)
  System.Single GetAnimatorUroMaxDeltaTimePerframe()
  System.Void SetAnimatorMainThreadJobCount(System.Int32 value)
  System.Void SetPrepareFrameJobBatchCountOpt(System.Int32 value)
  System.Void SetProcessAnimJobBatchCountOpt(System.Int32 value)
  System.Void SetAnimatorEnableProcessOneStage(System.Boolean value)
  System.Void SetAnimatorEnableApplyOnMoveInJob(System.Boolean value)
  System.Void SetAnimatorEnableRequireEventsAndBehaviour(System.Boolean value)
  System.Void SetApplyBuildInRootMotionInJob(System.Boolean enable)
  System.Void SetAnimatorForbbidenApplyOnMoveCb(System.Boolean value)
  System.Void SetAnimatorEnableCrossFrameJobs(System.Boolean enabel)
  System.Void SetAbilityLevel(System.Int32 abilityLevel)
  System.Int32 GetAbilityLevel()
  System.Void SetSampleClipCacheCreatePreFrameCount(System.Int32 value)
  System.Void SetSampleClipCacheMaxCount(System.Int32 value)
  System.Void SetLayerMeshSpace(System.Int32 layerIndex, System.Boolean enable)
  System.Boolean GetLayerMeshSpace(System.Int32 layerIndex)
  System.Single GetFloat(System.String name)
  System.Single GetFloat(System.Int32 id)
  System.Single GetFloatFromTransition(System.Int32 layerIndex, System.Int32 id)
  System.Single GetFloatFromTransitionWithDefault(System.Int32 layerIndex, System.Int32 id, System.Single defValue)
  System.Void SetFloat(System.String name, System.Single value)
  System.Void SetFloat(System.String name, System.Single value, System.Single dampTime, System.Single deltaTime)
  System.Void SetFloat(System.Int32 id, System.Single value)
  System.Void SetFloat(System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime)
  System.Boolean GetBool(System.String name)
  System.Boolean GetBool(System.Int32 id)
  System.Void SetBool(System.String name, System.Boolean value)
  System.Void SetBool(System.Int32 id, System.Boolean value)
  System.Int32 GetInteger(System.String name)
  System.Int32 GetInteger(System.Int32 id)
  System.Void SetInteger(System.String name, System.Int32 value)
  System.Void SetInteger(System.Int32 id, System.Int32 value)
  System.Void SetTrigger(System.String name)
  System.Void SetTrigger(System.Int32 id)
  System.Void ResetTrigger(System.String name)
  System.Void ResetTrigger(System.Int32 id)
  System.Boolean IsParameterControlledByCurve(System.String name)
  System.Boolean IsParameterControlledByCurve(System.Int32 id)
  System.Single get_motionDeltaTime()
  UnityEngine.Vector3 get_deltaPosition()
  UnityEngine.Quaternion get_deltaRotation()
  UnityEngine.Vector3 get_velocity()
  UnityEngine.Vector3 get_angularVelocity()
  UnityEngine.Vector3 get_rootPosition()
  System.Void set_rootPosition(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rootRotation()
  System.Void set_rootRotation(UnityEngine.Quaternion value)
  System.Boolean get_applyRootMotion()
  System.Void set_applyRootMotion(System.Boolean value)
  System.Boolean get_linearVelocityBlending()
  System.Void set_linearVelocityBlending(System.Boolean value)
  System.Boolean get_animatePhysics()
  System.Void set_animatePhysics(System.Boolean value)
  UnityEngine.AnimatorUpdateMode get_updateMode()
  System.Void set_updateMode(UnityEngine.AnimatorUpdateMode value)
  System.Boolean get_hasTransformHierarchy()
  System.Boolean get_allowConstantClipSamplingOptimization()
  System.Void set_allowConstantClipSamplingOptimization(System.Boolean value)
  System.Single get_gravityWeight()
  UnityEngine.Vector3 get_bodyPosition()
  System.Void set_bodyPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_bodyPositionInternal()
  System.Void set_bodyPositionInternal(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_bodyRotation()
  System.Void set_bodyRotation(UnityEngine.Quaternion value)
  UnityEngine.Quaternion get_bodyRotationInternal()
  System.Void set_bodyRotationInternal(UnityEngine.Quaternion value)
  UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal)
  UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal goal)
  System.Void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition)
  System.Void SetGoalPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition)
  UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal)
  UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal goal)
  System.Void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation)
  System.Void SetGoalRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation)
  System.Single GetIKPositionWeight(UnityEngine.AvatarIKGoal goal)
  System.Single GetGoalWeightPosition(UnityEngine.AvatarIKGoal goal)
  System.Void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, System.Single value)
  System.Void SetGoalWeightPosition(UnityEngine.AvatarIKGoal goal, System.Single value)
  System.Single GetIKRotationWeight(UnityEngine.AvatarIKGoal goal)
  System.Single GetGoalWeightRotation(UnityEngine.AvatarIKGoal goal)
  System.Void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, System.Single value)
  System.Void SetGoalWeightRotation(UnityEngine.AvatarIKGoal goal, System.Single value)
  UnityEngine.Vector3 GetIKHintPosition(UnityEngine.AvatarIKHint hint)
  UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint hint)
  System.Void SetIKHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition)
  System.Void SetHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition)
  System.Single GetIKHintPositionWeight(UnityEngine.AvatarIKHint hint)
  System.Single GetHintWeightPosition(UnityEngine.AvatarIKHint hint)
  System.Void SetIKHintPositionWeight(UnityEngine.AvatarIKHint hint, System.Single value)
  System.Void SetHintWeightPosition(UnityEngine.AvatarIKHint hint, System.Single value)
  System.Void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition)
  System.Void SetLookAtPositionInternal(UnityEngine.Vector3 lookAtPosition)
  System.Void SetLookAtWeight(System.Single weight)
  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight)
  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight)
  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight)
  System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight)
  System.Void SetLookAtWeightInternal(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight)
  System.Void SetBoneLocalRotation(UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation)
  System.Void SetBoneLocalRotationInternal(System.Int32 humanBoneId, UnityEngine.Quaternion rotation)
  System.Void SetTransformHierarchy(System.Boolean bHas)
  System.Void SetTransformHierarchyInternal(System.Boolean bHas)
  System.Boolean GetBoneGlobalTRS(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& trs)
  System.Boolean GetBoneGlobalTRSInternal(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& trs)
  UnityEngine.AnimationTransformf GetBoneRootTRS(System.Int32 avatarAssetBoneID)
  UnityEngine.AnimationTransformf GetBoneRootTRSInternal(System.Int32 avatarAssetBoneID)
  UnityEngine.AnimationTransformf GetBoneLocalTRS(System.Int32 avatarAssetBoneID)
  UnityEngine.AnimationTransformf GetBoneLocalTRSInternal(System.Int32 avatarAssetBoneID)
  System.Void SetCorrectiveBoneData(UnityEngine.HGCorrectiveBoneData bindings)
  System.Void SetEnableCorrectiveBoneSystem(System.Boolean enable)
  System.Void SetSequenceLayerSkipTimeThreshold(System.Single value)
  System.Single GetSequenceLayerSkipTimeThreshold()
  System.Void ForceUpdateCorrectiveBoneDataInEditor()
  System.Void SetBakedBindingData(UnityEngine.HGAnimationSetBindings bindings)
  System.Void EnableBakedBindingData(System.Boolean enable)
  System.Boolean SetClipByIndex(UnityEngine.AnimationClip overrideClip, System.Int32 index)
  System.Void UnloadClipsNoRebind(UnityEngine.AnimationClip[] overrideClip, System.Boolean clearCache)
  System.Void ReloadClipsNoRebind(UnityEngine.AnimationClip[] overrideClip)
  System.Void CaptureLastHumanPose()
  System.Void SetWriteTransformDefAsPostProcess(System.Boolean enable)
  System.Void SetWriteTransformDefAsPostProcessSkipOpt(System.Boolean enable)
  System.Void SetAnimatorJobDispatchMode(UnityEngine.AnimatorJobDispatchMode mode)
  UnityEngine.AnimatorJobDispatchMode GetAnimatorJobDispatchMode()
  System.Void SetEnableCollisionConstraintSolver(System.Boolean enable)
  System.Void SetEnableDefaultValuesForceUseDefaultPose(System.Boolean enable)
  System.Boolean IsEnableDefaultValuesForceUseDefaultPose()
  System.Void SetEnableClipBindingOpt(System.Boolean enable)
  System.Void SetEnableOptBindingByAvatar(System.Boolean enable)
  System.Boolean AddClipsToBindingsNoGrown(UnityEngine.AnimationClip[] overrideClip)
  System.Void SetDynamicBindingReserveCount(System.Int32 count)
  System.Void ReCreatePlayableMemory()
  UnityEngine.AnimationTransformRWBufferHandle CreateClothBindings(UnityEngine.Transform[] transformAccessArray)
  UnityEngine.AnimationTransformRWBufferHandle CreateClothBindingsByNameLst(System.String[] transformPathArray)
  System.Void DestroyClothBindings()
  System.Void EnableClothBindings()
  System.Void DisableClothBindings()
  System.Void SetClothBindingsEnableWorldSpace(System.Boolean value)
  System.Boolean CheckClothBindingsEnableWorldSpace()
  System.Void SetMorphBindingsEnableWorldSpace(System.Boolean value)
  System.Boolean CheckMorphBindingsEnableWorldSpace()
  UnityEngine.AnimationTransformRWBufferHandle CreateMorphBindings(UnityEngine.Transform[] transformAccessArray)
  UnityEngine.AnimationTransformRWBufferHandle CreateMorphBindingsByNameLst(System.String[] transformPathArray)
  System.Void EnableMorphBindings()
  System.Void DisableMorphBindings()
  System.Void SetOptimizedAvatarDataSet(System.Boolean optimized)
  System.Void SetEnabelMorphBindingWriteInLateUpdate(System.Boolean enable)
  UnityEngine.ScriptableObject GetBehaviour(System.Type type)
  T GetBehaviour()
  T[] ConvertStateMachineBehaviour(UnityEngine.ScriptableObject[] rawObjects)
  T[] GetBehaviours()
  UnityEngine.ScriptableObject[] InternalGetBehaviours(System.Type type)
  UnityEngine.StateMachineBehaviour[] GetBehaviours(System.Int32 fullPathHash, System.Int32 layerIndex)
  UnityEngine.ScriptableObject[] InternalGetBehavioursByKey(System.Int32 fullPathHash, System.Int32 layerIndex, System.Type type)
  System.Boolean get_stabilizeFeet()
  System.Void set_stabilizeFeet(System.Boolean value)
  System.Int32 get_layerCount()
  System.String GetLayerName(System.Int32 layerIndex)
  System.Int32 GetLayerIndex(System.String layerName)
  System.Single GetLayerWeight(System.Int32 layerIndex)
  System.Void SetLayerWeight(System.Int32 layerIndex, System.Single weight)
  System.Void GetAnimatorStateInfo(System.Int32 layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, UnityEngine.AnimatorStateInfo& info)
  UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(System.Int32 layerIndex)
  UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(System.Int32 layerIndex)
  System.Void GetAnimatorTransitionInfo(System.Int32 layerIndex, UnityEngine.AnimatorTransitionInfo& info)
  UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(System.Int32 layerIndex)
  System.Int32 GetAnimatorClipInfoCount(System.Int32 layerIndex, System.Boolean current)
  System.Int32 GetCurrentAnimatorClipInfoCount(System.Int32 layerIndex)
  System.Int32 GetNextAnimatorClipInfoCount(System.Int32 layerIndex)
  UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(System.Int32 layerIndex)
  UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(System.Int32 layerIndex)
  System.Void GetCurrentAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
  System.Void GetAnimatorClipInfoInternal(System.Int32 layerIndex, System.Boolean isCurrent, System.Object clips)
  System.Void GetNextAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
  System.Boolean IsInTransition(System.Int32 layerIndex)
  System.Boolean IsPlayingTag(System.Int32 layerIndex, System.Int32 tagHash)
  System.Boolean IsPlayingState(System.Int32 layerIndex, System.Int32 stateNameHash)
  System.Int32 GetAnimatorStateCullMode(System.Int32 layerIndex)
  UnityEngine.AnimatorStateRootMotionInfo GetCurrentAnimatorStateRootmotionInfo(System.Int32 layerIndex)
  System.Void GetAnimatorStateRootMotionInfo(System.Int32 layerIndex, UnityEngine.AnimatorStateRootMotionInfo& output)
  System.Boolean HasTrigger(System.Int32 triggerId)
  UnityEngine.AnimatorControllerParameter[] get_parameters()
  System.Int32 get_parameterCount()
  UnityEngine.AnimatorControllerParameter GetParameterInternal(System.Int32 index)
  UnityEngine.AnimatorControllerParameter GetParameter(System.Int32 index)
  System.Single get_feetPivotActive()
  System.Void set_feetPivotActive(System.Single value)
  System.Single get_pivotWeight()
  UnityEngine.Vector3 get_pivotPosition()
  System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch)
  System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime)
  System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime)
  System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch)
  System.Void InterruptMatchTarget()
  System.Void InterruptMatchTarget(System.Boolean completeMatch)
  System.Boolean get_isMatchingTarget()
  System.Single get_timeScale()
  System.Void set_timeScale(System.Single value)
  System.Single get_speed()
  System.Void set_speed(System.Single value)
  System.Void ForceStateNormalizedTime(System.Single normalizedTime)
  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration)
  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer)
  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset)
  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion)
  System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime)
  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset)
  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer)
  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration)
  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion)
  System.Void WriteDefaultValues()
  System.Void WriteDefaultValuesDirty()
  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime)
  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset)
  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer)
  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration)
  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion)
  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion)
  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime)
  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset)
  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer)
  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration)
  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource)
  System.Void ResetToDefaultStates()
  System.Void PlayInFixedTime(System.String stateName, System.Int32 layer)
  System.Void PlayInFixedTime(System.String stateName)
  System.Void PlayInFixedTime(System.String stateName, System.Int32 layer, System.Single fixedTime)
  System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer, System.Single fixedTime)
  System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer)
  System.Void PlayInFixedTime(System.Int32 stateNameHash)
  System.Void Play(System.String stateName, System.Int32 layer)
  System.Void Play(System.String stateName)
  System.Void Play(System.String stateName, System.Int32 layer, System.Single normalizedTime)
  System.Void Play(System.Int32 stateNameHash, System.Int32 layer, System.Single normalizedTime)
  System.Void Play(System.Int32 stateNameHash, System.Int32 layer)
  System.Void Play(System.Int32 stateNameHash)
  System.Void SetTarget(UnityEngine.AvatarTarget targetIndex, System.Single targetNormalizedTime)
  UnityEngine.Vector3 get_targetPosition()
  UnityEngine.Quaternion get_targetRotation()
  System.Boolean IsControlled(UnityEngine.Transform transform)
  System.Boolean IsBoneTransform(UnityEngine.Transform transform)
  UnityEngine.Transform get_avatarRoot()
  UnityEngine.Transform GetBoneTransform(UnityEngine.HumanBodyBones humanBoneId)
  UnityEngine.Transform GetBoneTransformInternal(System.Int32 humanBoneId)
  UnityEngine.Transform GetBoneTransformByBoneId(System.Int32 boneID)
  UnityEngine.Transform GetBoneTransformByBoneIdInternal(System.Int32 boneId)
  UnityEngine.AnimatorCullingMode get_cullingMode()
  System.Void set_cullingMode(UnityEngine.AnimatorCullingMode value)
  System.Void StartPlayback()
  System.Void StopPlayback()
  System.Single get_playbackTime()
  System.Void set_playbackTime(System.Single value)
  System.Void StartRecording(System.Int32 frameCount)
  System.Void StopRecording()
  System.Single get_recorderStartTime()
  System.Void set_recorderStartTime(System.Single value)
  System.Single GetRecorderStartTime()
  System.Single get_recorderStopTime()
  System.Void set_recorderStopTime(System.Single value)
  System.Single GetRecorderStopTime()
  UnityEngine.AnimatorRecorderMode get_recorderMode()
  UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController()
  System.Void set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController value)
  System.Boolean get_hasBoundPlayables()
  System.Void ClearInternalControllerPlayable()
  System.Boolean HasState(System.Int32 layerIndex, System.Int32 stateID)
  System.Int32 StringToHash(System.String name)
  System.Int32 StringToHashCRC32(System.IntPtr name)
  UnityEngine.Avatar get_avatar()
  System.Void set_avatar(UnityEngine.Avatar value)
  UnityEngine.HGSkeletalMorphAvatar get_morphAvatar()
  System.Void set_morphAvatar(UnityEngine.HGSkeletalMorphAvatar value)
  UnityEngine.LodBoneMask get_lodBoneMask()
  System.Void set_lodBoneMask(UnityEngine.LodBoneMask value)
  System.UInt32 get_lodBoneMaskLevel()
  System.Void set_lodBoneMaskLevel(System.UInt32 value)
  System.String GetStats()
  UnityEngine.Playables.PlayableGraph get_playableGraph()
  System.Void GetCurrentGraph(UnityEngine.Playables.PlayableGraph& graph)
  System.Void CheckIfInIKPass()
  System.Boolean IsInIKPass()
  System.Void SetFloatString(System.String name, System.Single value)
  System.Void SetFloatID(System.Int32 id, System.Single value)
  System.Single GetFloatString(System.String name)
  System.Single GetFloatID(System.Int32 id)
  System.Single GetFloatFromTransitionByID(System.Int32 layerIndex, System.Int32 id)
  System.Single GetFloatFromTransitionByIDWithDefault(System.Int32 layerIndex, System.Int32 id, System.Single defValue)
  System.Void SetBoolString(System.String name, System.Boolean value)
  System.Void SetBoolID(System.Int32 id, System.Boolean value)
  System.Boolean GetBoolString(System.String name)
  System.Boolean GetBoolID(System.Int32 id)
  System.Void SetIntegerString(System.String name, System.Int32 value)
  System.Void SetIntegerID(System.Int32 id, System.Int32 value)
  System.Int32 GetIntegerString(System.String name)
  System.Int32 GetIntegerID(System.Int32 id)
  System.Void SetTriggerString(System.String name)
  System.Void SetTriggerID(System.Int32 id)
  System.Void ResetTriggerString(System.String name)
  System.Void ResetTriggerID(System.Int32 id)
  System.Boolean IsParameterControlledByCurveString(System.String name)
  System.Boolean IsParameterControlledByCurveID(System.Int32 id)
  System.Void SetFloatStringDamp(System.String name, System.Single value, System.Single dampTime, System.Single deltaTime)
  System.Void SetFloatIDDamp(System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime)
  UnityEngine.HGAnimParameterSGHandle[] GetHGParameterHandles()
  System.Boolean CheckHGParmeterHandleValid()
  System.Boolean get_applyMorphPose()
  System.Void set_applyMorphPose(System.Boolean value)
  System.Int32 GetMorphBoneCount()
  System.Void GetMorphBoneIds(Unity.Collections.NativeArray<System.Int32> arrayToFill)
  System.Void GetMorphBoneIdsUnsafe(System.Int32 count, Unity.Collections.NativeArray<System.Int32> arrayToFill)
  System.Void Internal_GetMorphBoneIds(System.Int32 count, System.IntPtr arrayToFill)
  System.Void SetMorphTransforms(Unity.Collections.NativeArray<System.Int32> boneIds, Unity.Collections.NativeArray<UnityEngine.Vector3> translation, Unity.Collections.NativeArray<UnityEngine.Vector3> euler, Unity.Collections.NativeArray<UnityEngine.Vector3> scale)
  System.Void SetMorphTransformsUnsafe(Unity.Collections.NativeArray<System.Int32> boneIds, Unity.Collections.NativeArray<UnityEngine.Vector3> translation, Unity.Collections.NativeArray<UnityEngine.Vector3> euler, Unity.Collections.NativeArray<UnityEngine.Vector3> scale)
  System.Void Internal_SetMorphTransforms(System.Int32 count, System.IntPtr boneIds, System.IntPtr translation, System.IntPtr euler, System.IntPtr scale)
  System.Boolean get_layersAffectMassCenter()
  System.Void set_layersAffectMassCenter(System.Boolean value)
  System.Single get_leftFeetBottomHeight()
  System.Single get_rightFeetBottomHeight()
  System.Boolean get_supportsOnAnimatorMove()
  System.Void OnUpdateModeChanged()
  System.Void OnCullingModeChanged()
  System.Void WriteDefaultPose()
  System.Void Update(System.Single deltaTime)
  System.Void Rebind()
  System.Void Rebind(System.Boolean writeDefaultValues)
  System.Void ApplyBuiltinRootMotion()
  System.Void EvaluateController()
  System.Void EvaluateController(System.Single deltaTime)
  System.String GetCurrentStateName(System.Int32 layerIndex)
  System.String GetNextStateName(System.Int32 layerIndex)
  System.String GetAnimatorStateName(System.Int32 layerIndex, System.Boolean current)
  System.String ResolveHash(System.Int32 hash)
  System.String GetAnimatorStateName(System.Int32 stateID)
  System.Void GotoState(System.Int32 layer, System.Int32 stateId, System.Single normalizedTime, System.Single transitionDuration, System.Single transitionTime, UnityEngine.AnimationBlendStyle blendStyle)
  System.Void GotoStateInFixedTime(System.Int32 layerIndex, System.Int32 stateId, System.Single fixedTime, System.Single fixedTransitionDuration, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle)
  System.Void SetAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride, System.Boolean rebind)
  System.Void RefreshStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride)
  System.Void SetRuntimeControllerNoRebind(UnityEngine.RuntimeAnimatorController controller)
  System.Void RefreshAnimationStateAsyncCompleteOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride)
  System.Void Internal_GotoState(System.Int32 layer, System.Int32 stateId, System.Single normalizedTime, System.Single transitionDuration, System.Single transitionTime, UnityEngine.AnimationBlendStyle blendStyle)
  System.Void Internal_GotoStateInFixedTime(System.Int32 layerIndex, System.Int32 stateId, System.Single fixedTime, System.Single fixedTransitionDuration, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle)
  System.Void Internal_SetAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride, System.Boolean rebind)
  System.Void Internal_RefreshAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride)
  System.Void Internal_SetRuntimeControllerNoRebind(UnityEngine.RuntimeAnimatorController controller)
  System.Void Internal_RefreshAnimationStateAsyncCompleteOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride)
  System.Void SetAvatarNoBind(UnityEngine.Avatar avatar)
  System.Void Internal_SetAvatarNoBind(UnityEngine.Avatar avatar)
  System.Boolean get_logWarnings()
  System.Void set_logWarnings(System.Boolean value)
  System.Boolean get_fireEvents()
  System.Void set_fireEvents(System.Boolean value)
  System.Boolean get_keepAnimatorControllerStateOnDisable()
  System.Void set_keepAnimatorControllerStateOnDisable(System.Boolean value)
  System.Boolean get_keepAnimatorStateOnDisable()
  System.Void set_keepAnimatorStateOnDisable(System.Boolean value)
  System.Boolean get_writeDefaultValuesOnDisable()
  System.Void set_writeDefaultValuesOnDisable(System.Boolean value)
  UnityEngine.Vector3 GetVector(System.String name)
  UnityEngine.Vector3 GetVector(System.Int32 id)
  System.Void SetVector(System.String name, UnityEngine.Vector3 value)
  System.Void SetVector(System.Int32 id, UnityEngine.Vector3 value)
  UnityEngine.Quaternion GetQuaternion(System.String name)
  UnityEngine.Quaternion GetQuaternion(System.Int32 id)
  System.Void SetQuaternion(System.String name, UnityEngine.Quaternion value)
  System.Void SetQuaternion(System.Int32 id, UnityEngine.Quaternion value)
  System.Void get_deltaPosition_Injected(UnityEngine.Vector3& ret)
  System.Void get_deltaRotation_Injected(UnityEngine.Quaternion& ret)
  System.Void get_velocity_Injected(UnityEngine.Vector3& ret)
  System.Void get_angularVelocity_Injected(UnityEngine.Vector3& ret)
  System.Void get_rootPosition_Injected(UnityEngine.Vector3& ret)
  System.Void set_rootPosition_Injected(UnityEngine.Vector3& value)
  System.Void get_rootRotation_Injected(UnityEngine.Quaternion& ret)
  System.Void set_rootRotation_Injected(UnityEngine.Quaternion& value)
  System.Void get_bodyPositionInternal_Injected(UnityEngine.Vector3& ret)
  System.Void set_bodyPositionInternal_Injected(UnityEngine.Vector3& value)
  System.Void get_bodyRotationInternal_Injected(UnityEngine.Quaternion& ret)
  System.Void set_bodyRotationInternal_Injected(UnityEngine.Quaternion& value)
  System.Void GetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& ret)
  System.Void SetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& goalPosition)
  System.Void GetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& ret)
  System.Void SetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& goalRotation)
  System.Void GetHintPosition_Injected(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& ret)
  System.Void SetHintPosition_Injected(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& hintPosition)
  System.Void SetLookAtPositionInternal_Injected(UnityEngine.Vector3& lookAtPosition)
  System.Void SetBoneLocalRotationInternal_Injected(System.Int32 humanBoneId, UnityEngine.Quaternion& rotation)
  System.Void GetBoneRootTRSInternal_Injected(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& ret)
  System.Void GetBoneLocalTRSInternal_Injected(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& ret)
  System.Void CreateClothBindings_Injected(UnityEngine.Transform[] transformAccessArray, UnityEngine.AnimationTransformRWBufferHandle& ret)
  System.Void CreateClothBindingsByNameLst_Injected(System.String[] transformPathArray, UnityEngine.AnimationTransformRWBufferHandle& ret)
  System.Void CreateMorphBindings_Injected(UnityEngine.Transform[] transformAccessArray, UnityEngine.AnimationTransformRWBufferHandle& ret)
  System.Void CreateMorphBindingsByNameLst_Injected(System.String[] transformPathArray, UnityEngine.AnimationTransformRWBufferHandle& ret)
  System.Void get_pivotPosition_Injected(UnityEngine.Vector3& ret)
  System.Void MatchTarget_Injected(UnityEngine.Vector3& matchPosition, UnityEngine.Quaternion& matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask& weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch)
  System.Void get_targetPosition_Injected(UnityEngine.Vector3& ret)
  System.Void get_targetRotation_Injected(UnityEngine.Quaternion& ret)
END_CLASS

CLASS: UnityEngine.AnimatorControllerParameter
TYPE:  class
TOKEN: 0x200002C
FIELDS:
  private           System.String                   m_Name  // 0x10
  private           UnityEngine.AnimatorControllerParameterTypem_Type  // 0x18
  private           System.Single                   m_DefaultFloat  // 0x1C
  private           System.Int32                    m_DefaultInt  // 0x20
  private           System.Boolean                  m_DefaultBool  // 0x24
METHODS:
  System.String get_name()
  System.Int32 get_nameHash()
  UnityEngine.AnimatorControllerParameterType get_type()
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.AnimationClipPair
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  public            UnityEngine.AnimationClip       originalClip  // 0x10
  public            UnityEngine.AnimationClip       overrideClip  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.AnimatorOverrideController
TYPE:  class
TOKEN: 0x200002E
EXTENDS: RuntimeAnimatorController
FIELDS:
  private           UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallbackOnOverrideControllerDirty  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.RuntimeAnimatorController controller)
  System.Void Internal_Create(UnityEngine.AnimatorOverrideController self, UnityEngine.RuntimeAnimatorController controller)
  UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController()
  System.Void set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController value)
  UnityEngine.AnimationClip get_Item(System.String name)
  System.Void set_Item(System.String name, UnityEngine.AnimationClip value)
  UnityEngine.AnimationClip Internal_GetClipByName(System.String name, System.Boolean returnEffectiveClip)
  System.Void Internal_SetClipByName(System.String name, UnityEngine.AnimationClip clip)
  UnityEngine.AnimationClip get_Item(UnityEngine.AnimationClip clip)
  System.Void set_Item(UnityEngine.AnimationClip clip, UnityEngine.AnimationClip value)
  System.Boolean get_enableBindingOpt()
  System.Void set_enableBindingOpt(System.Boolean value)
  System.Byte get_reserveCount()
  System.Void set_reserveCount(System.Byte value)
  UnityEngine.AnimationClip GetClip(UnityEngine.AnimationClip originalClip, System.Boolean returnEffectiveClip)
  System.Void SetClip(UnityEngine.AnimationClip originalClip, UnityEngine.AnimationClip overrideClip, System.Boolean notify)
  System.Void SendNotification()
  UnityEngine.AnimationClip GetOriginalClip(System.Int32 index)
  UnityEngine.AnimationClip GetOverrideClip(UnityEngine.AnimationClip originalClip)
  System.Int32 get_overridesCount()
  System.Void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides)
  System.Void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides)
  UnityEngine.AnimationClipPair[] get_clips()
  System.Void set_clips(UnityEngine.AnimationClipPair[] value)
  System.Void PerformOverrideClipListCleanup()
  System.Void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller)
END_CLASS

CLASS: UnityEngine.AnimatorUtility
TYPE:  class
TOKEN: 0x2000030
FIELDS:
METHODS:
  System.Void OptimizeTransformHierarchy(UnityEngine.GameObject go, System.String[] exposedTransforms)
  System.Void DeoptimizeTransformHierarchy(UnityEngine.GameObject go)
END_CLASS

CLASS: UnityEngine.HumanBodyBones
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HumanBodyBones      Hips  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftUpperLeg  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightUpperLeg  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftLowerLeg  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightLowerLeg  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftFoot  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightFoot  // 0x0
  public    static  UnityEngine.HumanBodyBones      Spine  // 0x0
  public    static  UnityEngine.HumanBodyBones      Chest  // 0x0
  public    static  UnityEngine.HumanBodyBones      UpperChest  // 0x0
  public    static  UnityEngine.HumanBodyBones      Neck  // 0x0
  public    static  UnityEngine.HumanBodyBones      Head  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftShoulder  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightShoulder  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftUpperArm  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightUpperArm  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftLowerArm  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightLowerArm  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftHand  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightHand  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftToes  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightToes  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftEye  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightEye  // 0x0
  public    static  UnityEngine.HumanBodyBones      Jaw  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftThumbProximal  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftThumbIntermediate  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftThumbDistal  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftIndexProximal  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftIndexIntermediate  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftIndexDistal  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftMiddleProximal  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftMiddleIntermediate  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftMiddleDistal  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftRingProximal  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftRingIntermediate  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftRingDistal  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftLittleProximal  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftLittleIntermediate  // 0x0
  public    static  UnityEngine.HumanBodyBones      LeftLittleDistal  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightThumbProximal  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightThumbIntermediate  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightThumbDistal  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightIndexProximal  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightIndexIntermediate  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightIndexDistal  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightMiddleProximal  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightMiddleIntermediate  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightMiddleDistal  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightRingProximal  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightRingIntermediate  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightRingDistal  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightLittleProximal  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightLittleIntermediate  // 0x0
  public    static  UnityEngine.HumanBodyBones      RightLittleDistal  // 0x0
  public    static  UnityEngine.HumanBodyBones      LastBone  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AnimationTransformf
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            UnityEngine.Vector3             t  // 0x10
  public            UnityEngine.Quaternion          q  // 0x1C
  public            UnityEngine.Vector3             s  // 0x2C
METHODS:
END_CLASS

CLASS: UnityEngine.Avatar
TYPE:  class
TOKEN: 0x2000033
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean get_isValid()
  System.Boolean get_isHuman()
  UnityEngine.HumanDescription get_humanDescription()
  System.Void SetMuscleMinMax(System.Int32 muscleId, System.Single min, System.Single max)
  System.Void SetParameter(System.Int32 parameterId, System.Single value)
  System.Single GetAxisLength(System.Int32 humanId)
  UnityEngine.Quaternion GetPreRotation(System.Int32 humanId)
  UnityEngine.Quaternion GetPostRotation(System.Int32 humanId)
  UnityEngine.Quaternion GetZYPostQ(System.Int32 humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q)
  UnityEngine.Quaternion GetZYRoll(System.Int32 humanId, UnityEngine.Vector3 uvw)
  UnityEngine.Vector3 GetLimitSign(System.Int32 humanId)
  System.Single Internal_GetAxisLength(System.Int32 humanId)
  UnityEngine.Quaternion Internal_GetPreRotation(System.Int32 humanId)
  UnityEngine.Quaternion Internal_GetPostRotation(System.Int32 humanId)
  UnityEngine.Quaternion Internal_GetZYPostQ(System.Int32 humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q)
  UnityEngine.Quaternion Internal_GetZYRoll(System.Int32 humanId, UnityEngine.Vector3 uvw)
  UnityEngine.Vector3 Internal_GetLimitSign(System.Int32 humanId)
  System.String[] GetBonePaths()
  System.Void get_humanDescription_Injected(UnityEngine.HumanDescription& ret)
  System.Void Internal_GetPreRotation_Injected(System.Int32 humanId, UnityEngine.Quaternion& ret)
  System.Void Internal_GetPostRotation_Injected(System.Int32 humanId, UnityEngine.Quaternion& ret)
  System.Void Internal_GetZYPostQ_Injected(System.Int32 humanId, UnityEngine.Quaternion& parentQ, UnityEngine.Quaternion& q, UnityEngine.Quaternion& ret)
  System.Void Internal_GetZYRoll_Injected(System.Int32 humanId, UnityEngine.Vector3& uvw, UnityEngine.Quaternion& ret)
  System.Void Internal_GetLimitSign_Injected(System.Int32 humanId, UnityEngine.Vector3& ret)
END_CLASS

CLASS: UnityEngine.SkeletonBone
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.String                   name  // 0x10
  private           System.String                   parentName  // 0x18
  public            UnityEngine.Vector3             position  // 0x20
  public            UnityEngine.Quaternion          rotation  // 0x2C
  public            UnityEngine.Vector3             scale  // 0x3C
METHODS:
END_CLASS

CLASS: UnityEngine.HumanLimit
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  private           UnityEngine.Vector3             m_Min  // 0x10
  private           UnityEngine.Vector3             m_Max  // 0x1C
  private           UnityEngine.Vector3             m_Center  // 0x28
  private           System.Single                   m_AxisLength  // 0x34
  private           System.Int32                    m_UseDefaultValues  // 0x38
METHODS:
END_CLASS

CLASS: UnityEngine.HumanBone
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  private           System.String                   m_BoneName  // 0x10
  private           System.String                   m_HumanName  // 0x18
  public            UnityEngine.HumanLimit          limit  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.HumanDescription
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            UnityEngine.HumanBone[]         human  // 0x10
  public            UnityEngine.SkeletonBone[]      skeleton  // 0x18
  private           System.Single                   m_ArmTwist  // 0x20
  private           System.Single                   m_ForeArmTwist  // 0x24
  private           System.Single                   m_UpperLegTwist  // 0x28
  private           System.Single                   m_LegTwist  // 0x2C
  private           System.Single                   m_ArmStretch  // 0x30
  private           System.Single                   m_LegStretch  // 0x34
  private           System.Single                   m_FeetSpacing  // 0x38
  private           System.Single                   m_GlobalScale  // 0x3C
  private           System.String                   m_RootMotionBoneName  // 0x40
  private           System.Boolean                  m_HasTranslationDoF  // 0x48
  private           System.Boolean                  m_HasExtraRoot  // 0x49
  private           System.Boolean                  m_SkeletonHasParents  // 0x4A
METHODS:
END_CLASS

CLASS: UnityEngine.AvatarMaskBodyPart
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.AvatarMaskBodyPart  Root  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  Body  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  Head  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  LeftLeg  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  RightLeg  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  LeftArm  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  RightArm  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  LeftFingers  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  RightFingers  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  LeftFootIK  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  RightFootIK  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  LeftHandIK  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  RightHandIK  // 0x0
  public    static  UnityEngine.AvatarMaskBodyPart  LastBodyPart  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.AvatarMask
TYPE:  class
TOKEN: 0x2000039
FIELDS:
METHODS:
  System.Boolean GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart index)
  System.Int32 get_transformCount()
  System.String GetTransformPath(System.Int32 index)
  System.Single GetTransformWeight(System.Int32 index)
  System.Boolean GetTransformActive(System.Int32 index)
END_CLASS

CLASS: UnityEngine.HGAnimationSetBindings
TYPE:  class
TOKEN: 0x200003A
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.HGCorrectiveBoneData
TYPE:  class
TOKEN: 0x200003B
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Internal_Create(UnityEngine.HGCorrectiveBoneData self)
END_CLASS

CLASS: UnityEngine.HGSkeletalMorphAvatar
TYPE:  class
TOKEN: 0x200003C
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Internal_Create(UnityEngine.HGSkeletalMorphAvatar self)
END_CLASS

CLASS: UnityEngine.HumanPose
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            UnityEngine.Vector3             bodyPosition  // 0x10
  public            UnityEngine.Quaternion          bodyRotation  // 0x1C
  public            System.Single[]                 muscles  // 0x30
METHODS:
  System.Void Init()
END_CLASS

CLASS: UnityEngine.HumanPoseHandler
TYPE:  class
TOKEN: 0x200003E
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.IntPtr Internal_CreateFromRoot(UnityEngine.Avatar avatar, UnityEngine.Transform root)
  System.Void Internal_Destroy(System.IntPtr ptr)
  System.Void GetHumanPose(UnityEngine.Vector3& bodyPosition, UnityEngine.Quaternion& bodyRotation, System.Single[] muscles)
  System.Void Dispose()
  System.Void .ctor(UnityEngine.Avatar avatar, UnityEngine.Transform root)
  System.Void GetHumanPose(UnityEngine.HumanPose& humanPose)
END_CLASS

CLASS: UnityEngine.HumanTrait
TYPE:  class
TOKEN: 0x200003F
FIELDS:
METHODS:
  System.Int32 get_MuscleCount()
  System.Int32 GetBoneIndexFromMono(System.Int32 humanId)
  System.String[] get_MuscleName()
END_CLASS

CLASS: UnityEngine.LodBoneMask
TYPE:  class
TOKEN: 0x2000040
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Internal_Create(UnityEngine.LodBoneMask self)
END_CLASS

CLASS: UnityEngine.Motion
TYPE:  class
TOKEN: 0x2000041
FIELDS:
  private   readonly System.Boolean                  <isAnimatorMotion>k__BackingField  // 0x18
METHODS:
  System.Void .ctor()
  System.Boolean get_isLooping()
END_CLASS

CLASS: UnityEngine.RuntimeAnimatorController
TYPE:  class
TOKEN: 0x2000042
FIELDS:
METHODS:
  System.Void .ctor()
  UnityEngine.AnimationClip[] get_animationClips()
END_CLASS

CLASS: UnityEngine.RuntimeAnimatorStateOverride
TYPE:  class
TOKEN: 0x2000043
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void Internal_Create(UnityEngine.RuntimeAnimatorStateOverride self)
  System.Void SetClip(System.Int32 stateID, UnityEngine.AnimationClip overrideClip)
  System.Void SetClipAsync(System.Int32 stateID, System.Single length, System.Boolean isHumanoid)
  System.Void RemoveClip(System.Int32 stateID)
  System.Void ClearClip()
  System.Boolean PreloadClip(UnityEngine.AnimationClip clipB)
  System.Void SetTransition(System.Int32 transUserNameID, System.Single transitionDuration, System.Single transitionOffset, System.Single exitTime)
  System.Void RemoveTransition(System.Int32 transUserNameID)
  System.Void SetSyncGroupCurve(System.UInt32 clipNameID, UnityEngine.AnimationCurve curve)
  System.Void Internal_SetClip(System.UInt32 stateID, UnityEngine.AnimationClip overrideClip)
  System.Void Internal_SetClipAsync(System.UInt32 stateID, System.Single length, System.Boolean isHumanoid)
  System.Void Internal_RemoveClip(System.UInt32 stateID)
  System.Void Internal_ClearClip()
  System.Boolean Internal_PreloadClip(UnityEngine.AnimationClip clipB)
  System.Void Internal_SetTransition(System.UInt32 transUserNameID, System.Single transitionDuration, System.Single transitionOffset, System.Single exitTime)
  System.Void Internal_RemoveTransition(System.UInt32 transUserNameID)
  System.Void Internal_SetSyncGroupCurve(System.UInt32 clipNameID, UnityEngine.AnimationCurve curve)
END_CLASS

CLASS: UnityEngine.Animations.AnimationPlayableBinding
TYPE:  class
TOKEN: 0x2000046
FIELDS:
METHODS:
  UnityEngine.Playables.PlayableBinding Create(System.String name, UnityEngine.Object key)
  UnityEngine.Playables.PlayableOutput CreateAnimationOutput(UnityEngine.Playables.PlayableGraph graph, System.String name)
END_CLASS

CLASS: UnityEngine.Animations.DiscreteEvaluationAttribute
TYPE:  class
TOKEN: 0x2000047
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.IAnimationJob
TYPE:  interface
TOKEN: 0x2000048
FIELDS:
METHODS:
  System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
  System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)
END_CLASS

CLASS: UnityEngine.Animations.IAnimationWindowPreview
TYPE:  interface
TOKEN: 0x2000049
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.NotKeyableAttribute
TYPE:  class
TOKEN: 0x200004A
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Animations.JobMethodIndex
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.JobMethodIndexProcessRootMotionMethodIndex  // 0x0
  public    static  UnityEngine.Animations.JobMethodIndexProcessAnimationMethodIndex  // 0x0
  public    static  UnityEngine.Animations.JobMethodIndexMethodIndexCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.ProcessAnimationJobStruct`1
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  private   static  System.IntPtr                   jobReflectionData  // 0x0
METHODS:
  System.IntPtr GetJobReflectionData()
  System.Void Execute(T& data, System.IntPtr animationStreamPtr, System.IntPtr methodIndex, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex)
END_CLASS

CLASS: UnityEngine.Animations.AdvancedAnimationMixerPlayable
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AdvancedAnimationMixerPlayablem_NullPlayable  // 0x0
METHODS:
  UnityEngine.Animations.AdvancedAnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  System.Boolean Equals(UnityEngine.Animations.AdvancedAnimationMixerPlayable other)
  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle)
  System.Void .cctor()
  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationClipPlayable
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Animations.AnimationClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationClipPlayable playable)
  UnityEngine.Animations.AnimationClipPlayable op_Explicit(UnityEngine.Playables.Playable playable)
  System.Boolean Equals(UnityEngine.Animations.AnimationClipPlayable other)
  UnityEngine.AnimationClip GetAnimationClip()
  System.Single GetAnimationClipPlayableLengthUncheck()
  System.Void SetAnimationClip(UnityEngine.AnimationClip clip)
  System.Void SetAnimationClipAsync(System.Single length, System.Boolean isHumanoid)
  System.Void SetApplyFootIK(System.Boolean value)
  System.Void SetApplyPlayableIK(System.Boolean value)
  System.Void SetRemoveStartOffset(System.Boolean value)
  System.Void SetOverrideLoopTime(System.Boolean value)
  System.Void SetLoopTime(System.Boolean value)
  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableHandle& handle)
  UnityEngine.AnimationClip GetAnimationClipInternal(UnityEngine.Playables.PlayableHandle& handle)
  System.Void SetAnimationClipInternal(UnityEngine.Playables.PlayableHandle& handle, UnityEngine.AnimationClip clip)
  System.Void SetAnimationClipAsyncInternal(UnityEngine.Playables.PlayableHandle& handle, System.Single length, System.Boolean isHumanoid)
  System.Void SetApplyFootIKInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  System.Void SetApplyPlayableIKInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  System.Void SetRemoveStartOffsetInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  System.Void SetOverrideLoopTimeInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  System.Void SetLoopTimeInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  System.Single GetAnimationClipPlayableLengthInternalUncheck(UnityEngine.Playables.PlayableHandle& handle)
  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationHumanStream
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  private           System.IntPtr                   stream  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.AnimationLayerMixerPlayable
TYPE:  struct
TOKEN: 0x2000051
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationLayerMixerPlayablem_NullPlayable  // 0x0
METHODS:
  UnityEngine.Animations.AnimationLayerMixerPlayable get_Null()
  UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean singleLayerOptimization)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle, System.Boolean singleLayerOptimization)
  UnityEngine.Playables.PlayableHandle GetHandle()
  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationLayerMixerPlayable playable)
  UnityEngine.Animations.AnimationLayerMixerPlayable op_Explicit(UnityEngine.Playables.Playable playable)
  System.Boolean Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other)
  System.Void SetLayerAdditive(System.UInt32 layerIndex, System.Boolean value)
  System.Void SetLayerMaskFromAvatarMask(System.UInt32 layerIndex, UnityEngine.AvatarMask mask)
  System.Void SetLayerRootMotionDisable(System.UInt32 layerIndex, System.Boolean value)
  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle)
  System.Void SetLayerAdditiveInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, System.Boolean value)
  System.Void SetSingleLayerOptimizationInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  System.Void SetLayerMaskFromAvatarMaskInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, UnityEngine.AvatarMask mask)
  System.Void SetLayerRootMotionDisableInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, System.Boolean value)
  System.Void .cctor()
  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationMixerPlayable
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationMixerPlayablem_NullPlayable  // 0x0
METHODS:
  UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean normalizeWeights)
  UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMixerPlayable playable)
  System.Boolean Equals(UnityEngine.Animations.AnimationMixerPlayable other)
  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle)
  System.Void .cctor()
  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationMotionXToDeltaPlayable
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationMotionXToDeltaPlayablem_NullPlayable  // 0x0
METHODS:
  UnityEngine.Animations.AnimationMotionXToDeltaPlayable Create(UnityEngine.Playables.PlayableGraph graph)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMotionXToDeltaPlayable playable)
  System.Boolean Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other)
  System.Void SetAbsoluteMotion(System.Boolean value)
  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle)
  System.Void SetAbsoluteMotionInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  System.Void .cctor()
  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationOffsetPlayable
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationOffsetPlayablem_NullPlayable  // 0x0
METHODS:
  UnityEngine.Animations.AnimationOffsetPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 inputCount)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 inputCount)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationOffsetPlayable playable)
  System.Boolean Equals(UnityEngine.Animations.AnimationOffsetPlayable other)
  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Playables.PlayableHandle& handle)
  System.Void .cctor()
  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationPlayableExtensions
TYPE:  class
TOKEN: 0x2000055
FIELDS:
METHODS:
  System.Void SetAnimatedProperties(U playable, UnityEngine.AnimationClip clip)
  System.Void SetAnimatedPropertiesInternal(UnityEngine.Playables.PlayableHandle& playable, UnityEngine.AnimationClip animatedProperties)
END_CLASS

CLASS: UnityEngine.Animations.AnimationPlayableGraphExtensions
TYPE:  class
TOKEN: 0x2000056
FIELDS:
METHODS:
  System.Boolean InternalCreateAnimationOutput(UnityEngine.Playables.PlayableGraph& graph, System.String name, UnityEngine.Playables.PlayableOutputHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationPlayableOutput
TYPE:  struct
TOKEN: 0x2000057
FIELDS:
  private           UnityEngine.Playables.PlayableOutputHandlem_Handle  // 0x10
METHODS:
  UnityEngine.Animations.AnimationPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, System.String name, UnityEngine.Animator target)
  System.Void .ctor(UnityEngine.Playables.PlayableOutputHandle handle)
  UnityEngine.Animations.AnimationPlayableOutput get_Null()
  UnityEngine.Playables.PlayableOutputHandle GetHandle()
  UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Animations.AnimationPlayableOutput output)
  UnityEngine.Animations.AnimationPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output)
  UnityEngine.Animator GetTarget()
  System.Void SetTarget(UnityEngine.Animator value)
  System.Void SetNeedRebindOnChanged(System.Boolean value)
  UnityEngine.Animator InternalGetTarget(UnityEngine.Playables.PlayableOutputHandle& handle)
  System.Void InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle& handle, UnityEngine.Animator target)
  System.Void InternalSetNeedRebindOnChanged(UnityEngine.Playables.PlayableOutputHandle& handle, System.Boolean value)
END_CLASS

CLASS: UnityEngine.Animations.AnimationPosePlayable
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationPosePlayablem_NullPlayable  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  System.Boolean Equals(UnityEngine.Animations.AnimationPosePlayable other)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.Animations.AnimationRemoveScalePlayable
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationRemoveScalePlayablem_NullPlayable  // 0x0
METHODS:
  UnityEngine.Animations.AnimationRemoveScalePlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationRemoveScalePlayable playable)
  System.Boolean Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other)
  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle)
  System.Void .cctor()
  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.AnimationScriptPlayable
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimationScriptPlayablem_NullPlayable  // 0x0
METHODS:
  UnityEngine.Animations.AnimationScriptPlayable Create(UnityEngine.Playables.PlayableGraph graph, T jobData, System.Int32 inputCount)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  System.Void CheckJobTypeValidity()
  System.Void SetJobData(T jobData)
  UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationScriptPlayable playable)
  System.Boolean Equals(UnityEngine.Animations.AnimationScriptPlayable other)
  System.Void SetForceWriteRootMotionParam(System.Boolean value)
  System.Void SetForceResetParam(System.Boolean value)
  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle, System.IntPtr jobReflectionData)
  System.Void SetForceWriteRootMotionParamInternal(UnityEngine.Playables.PlayableHandle handle, System.Boolean value)
  System.Void SetForceResetParamInternal(UnityEngine.Playables.PlayableHandle handle, System.Boolean value)
  System.Void .cctor()
  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle, System.IntPtr jobReflectionData)
  System.Void SetForceWriteRootMotionParamInternal_Injected(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
  System.Void SetForceResetParamInternal_Injected(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value)
END_CLASS

CLASS: UnityEngine.Animations.AnimationStream
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  private           System.UInt32                   m_AnimatorBindingsVersion  // 0x10
  private           System.IntPtr                   constant  // 0x18
  private           System.IntPtr                   input  // 0x20
  private           System.IntPtr                   output  // 0x28
  private           System.IntPtr                   workspace  // 0x30
  private           System.IntPtr                   inputStreamAccessor  // 0x38
  private           System.IntPtr                   animationHandleBinder  // 0x40
METHODS:
  System.UInt32 get_animatorBindingsVersion()
  System.Boolean get_isValid()
  System.Void CheckIsValid()
  System.Single get_deltaTime()
  System.Single GetDeltaTime()
  System.Single GetDeltaTime_Injected(UnityEngine.Animations.AnimationStream& _unity_self)
END_CLASS

CLASS: UnityEngine.Animations.TransformStreamHandle
TYPE:  struct
TOKEN: 0x200005C
FIELDS:
  private           System.UInt32                   m_AnimatorBindingsVersion  // 0x10
  private           System.Int32                    handleIndex  // 0x14
  private           System.Int32                    skeletonIndex  // 0x18
METHODS:
  System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream)
  System.Boolean IsValidInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Boolean get_createdByNative()
  System.Boolean IsSameVersionAsStream(UnityEngine.Animations.AnimationStream& stream)
  System.Boolean get_hasHandleIndex()
  System.Boolean get_hasSkeletonIndex()
  System.UInt32 get_animatorBindingsVersion()
  System.Void Resolve(UnityEngine.Animations.AnimationStream stream)
  System.Boolean IsResolved(UnityEngine.Animations.AnimationStream stream)
  System.Boolean IsResolvedInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Void CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream& stream)
  UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream)
  System.Void SetPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
  UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream)
  System.Void SetRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)
  UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream)
  System.Void SetLocalPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
  UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream)
  System.Void SetLocalRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)
  UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream)
  System.Void SetLocalScale(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale)
  System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  System.Void SetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Boolean useMask)
  System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Void SetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useMask)
  System.Void ResolveInternal(UnityEngine.Animations.AnimationStream& stream)
  UnityEngine.Vector3 GetPositionInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Void SetPositionInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position)
  UnityEngine.Quaternion GetRotationInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Void SetRotationInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion rotation)
  UnityEngine.Vector3 GetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Void SetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position)
  UnityEngine.Quaternion GetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Void SetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion rotation)
  UnityEngine.Vector3 GetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Void SetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 scale)
  System.Void GetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  System.Void SetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Boolean useMask)
  System.Void GetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Void SetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useMask)
  System.Void ResolveInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  System.Void GetPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  System.Void SetPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position)
  System.Void GetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret)
  System.Void SetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& rotation)
  System.Void GetLocalPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  System.Void SetLocalPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position)
  System.Void GetLocalRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret)
  System.Void SetLocalRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& rotation)
  System.Void GetLocalScaleInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  System.Void SetLocalScaleInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& scale)
  System.Void GetLocalTRSInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  System.Void SetLocalTRSInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale, System.Boolean useMask)
  System.Void GetGlobalTRInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Void SetGlobalTRInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, System.Boolean useMask)
END_CLASS

CLASS: UnityEngine.Animations.PropertyStreamHandle
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  private           System.UInt32                   m_AnimatorBindingsVersion  // 0x10
  private           System.Int32                    handleIndex  // 0x14
  private           System.Int32                    valueArrayIndex  // 0x18
  private           System.Int32                    bindType  // 0x1C
METHODS:
  System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream)
  System.Boolean IsValidInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Boolean get_createdByNative()
  System.Boolean IsSameVersionAsStream(UnityEngine.Animations.AnimationStream& stream)
  System.Boolean get_hasHandleIndex()
  System.Boolean get_hasValueArrayIndex()
  System.Boolean get_hasBindType()
  System.UInt32 get_animatorBindingsVersion()
  System.Boolean IsResolvedInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Void CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream& stream)
  System.Single GetFloat(UnityEngine.Animations.AnimationStream stream)
  System.Void SetFloat(UnityEngine.Animations.AnimationStream stream, System.Single value)
  System.Int32 GetInt(UnityEngine.Animations.AnimationStream stream)
  System.Void SetInt(UnityEngine.Animations.AnimationStream stream, System.Int32 value)
  System.Boolean GetBool(UnityEngine.Animations.AnimationStream stream)
  System.Void SetBool(UnityEngine.Animations.AnimationStream stream, System.Boolean value)
  System.Void ResolveInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Single GetFloatInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Void SetFloatInternal(UnityEngine.Animations.AnimationStream& stream, System.Single value)
  System.Int32 GetIntInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Void SetIntInternal(UnityEngine.Animations.AnimationStream& stream, System.Int32 value)
  System.Boolean GetBoolInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Void SetBoolInternal(UnityEngine.Animations.AnimationStream& stream, System.Boolean value)
  System.Void ResolveInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  System.Single GetFloatInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  System.Void SetFloatInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Single value)
  System.Int32 GetIntInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  System.Void SetIntInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Int32 value)
  System.Boolean GetBoolInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  System.Void SetBoolInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Boolean value)
END_CLASS

CLASS: UnityEngine.Animations.TransformSceneHandle
TYPE:  struct
TOKEN: 0x200005E
FIELDS:
  private           System.UInt32                   valid  // 0x10
  private           System.Int32                    transformSceneHandleDefinitionIndex  // 0x14
METHODS:
  System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream)
  System.Boolean get_createdByNative()
  System.Boolean get_hasTransformSceneHandleDefinitionIndex()
  System.Void CheckIsValid(UnityEngine.Animations.AnimationStream& stream)
  UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream)
  UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream)
  System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Boolean HasValidTransform(UnityEngine.Animations.AnimationStream& stream)
  UnityEngine.Vector3 GetPositionInternal(UnityEngine.Animations.AnimationStream& stream)
  UnityEngine.Vector3 GetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream)
  UnityEngine.Quaternion GetRotationInternal(UnityEngine.Animations.AnimationStream& stream)
  UnityEngine.Quaternion GetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream)
  UnityEngine.Vector3 GetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream)
  System.Void GetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  System.Void GetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
  System.Boolean HasValidTransform_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream)
  System.Void GetPositionInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  System.Void GetLocalPositionInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  System.Void GetRotationInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret)
  System.Void GetLocalRotationInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret)
  System.Void GetLocalScaleInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret)
  System.Void GetLocalTRSInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale)
  System.Void GetGlobalTRInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
END_CLASS

CLASS: UnityEngine.Animations.PropertySceneHandle
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
  private           System.UInt32                   valid  // 0x10
  private           System.Int32                    handleIndex  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.AnimationSceneHandleUtility
TYPE:  class
TOKEN: 0x2000060
FIELDS:
METHODS:
  System.Void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<System.Single> buffer)
  System.Int32 ValidateAndGetArrayCount(UnityEngine.Animations.AnimationStream& stream, Unity.Collections.NativeArray<T0> handles, Unity.Collections.NativeArray<T1> buffer)
  System.Void ReadSceneFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertySceneHandles, System.Void* floatBuffer, System.Int32 count)
END_CLASS

CLASS: UnityEngine.Animations.AnimationStreamHandleUtility
TYPE:  class
TOKEN: 0x2000061
FIELDS:
METHODS:
  System.Void WriteFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<System.Single> buffer, System.Boolean useMask)
  System.Void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<System.Single> buffer)
  System.Void ReadStreamFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertyStreamHandles, System.Void* floatBuffer, System.Int32 count)
  System.Void WriteStreamFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertyStreamHandles, System.Void* floatBuffer, System.Int32 count, System.Boolean useMask)
END_CLASS

CLASS: UnityEngine.Animations.AnimatorControllerPlayable
TYPE:  struct
TOKEN: 0x2000062
FIELDS:
  private           UnityEngine.Playables.PlayableHandlem_Handle  // 0x10
  private   static readonly UnityEngine.Animations.AnimatorControllerPlayablem_NullPlayable  // 0x0
METHODS:
  UnityEngine.Animations.AnimatorControllerPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller)
  UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller)
  System.Void .ctor(UnityEngine.Playables.PlayableHandle handle)
  UnityEngine.Playables.PlayableHandle GetHandle()
  System.Void SetHandle(UnityEngine.Playables.PlayableHandle handle)
  System.Boolean Equals(UnityEngine.Animations.AnimatorControllerPlayable other)
  System.Boolean IsInTransition(System.Int32 layerIndex)
  System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller, UnityEngine.Playables.PlayableHandle& handle)
  System.Boolean IsInTransitionInternal(UnityEngine.Playables.PlayableHandle& handle, System.Int32 layerIndex)
  System.Void .cctor()
  System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.RuntimeAnimatorController controller, UnityEngine.Playables.PlayableHandle& handle)
END_CLASS

CLASS: UnityEngine.Animations.CustomStreamPropertyType
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.CustomStreamPropertyTypeFloat  // 0x0
  public    static  UnityEngine.Animations.CustomStreamPropertyTypeBool  // 0x0
  public    static  UnityEngine.Animations.CustomStreamPropertyTypeInt  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Animations.AnimatorJobExtensions
TYPE:  class
TOKEN: 0x2000064
FIELDS:
METHODS:
  UnityEngine.Animations.TransformStreamHandle BindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform)
  UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property)
  UnityEngine.Animations.PropertyStreamHandle BindCustomStreamProperty(UnityEngine.Animator animator, System.String property, UnityEngine.Animations.CustomStreamPropertyType type)
  UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference)
  UnityEngine.Animations.TransformSceneHandle BindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform)
  UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property)
  UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference)
  System.Void InternalBindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, UnityEngine.Animations.TransformStreamHandle& transformStreamHandle)
  System.Void InternalBindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference, UnityEngine.Animations.PropertyStreamHandle& propertyStreamHandle)
  System.Void InternalBindCustomStreamProperty(UnityEngine.Animator animator, System.String property, UnityEngine.Animations.CustomStreamPropertyType propertyType, UnityEngine.Animations.PropertyStreamHandle& propertyStreamHandle)
  System.Void InternalBindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, UnityEngine.Animations.TransformSceneHandle& transformSceneHandle)
  System.Void InternalBindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference, UnityEngine.Animations.PropertySceneHandle& propertySceneHandle)
END_CLASS

CLASS: UnityEngine.Animations.Axis
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Animations.Axis     None  // 0x0
  public    static  UnityEngine.Animations.Axis     X  // 0x0
  public    static  UnityEngine.Animations.Axis     Y  // 0x0
  public    static  UnityEngine.Animations.Axis     Z  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Animations.AnimationStreamSource
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Experimental.Animations.AnimationStreamSourceDefaultValues  // 0x0
  public    static  UnityEngine.Experimental.Animations.AnimationStreamSourcePreviousInputs  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions
TYPE:  class
TOKEN: 0x2000045
FIELDS:
METHODS:
  System.Void SetAnimationStreamSource(UnityEngine.Animations.AnimationPlayableOutput output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource)
  System.Void SetSortingOrder(UnityEngine.Animations.AnimationPlayableOutput output, System.UInt16 sortingOrder)
  System.Void InternalSetAnimationStreamSource(UnityEngine.Playables.PlayableOutputHandle output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource)
  System.Void InternalSetSortingOrder(UnityEngine.Playables.PlayableOutputHandle output, System.Int32 sortingOrder)
  System.Void InternalSetAnimationStreamSource_Injected(UnityEngine.Playables.PlayableOutputHandle& output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource)
  System.Void InternalSetSortingOrder_Injected(UnityEngine.Playables.PlayableOutputHandle& output, System.Int32 sortingOrder)
END_CLASS

