// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.AnimationModule.dll
// Classes:  101
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000D
    public class Enumerator, IEnumerator
    {
        // Fields
        private UnityEngine.Animation m_Outer;        // 0x10
        private System.Int32 m_CurrentIndex;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Animation outer) { }
        private System.Object get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000028
    public class AnimationEventCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(UnityEngine.Animator animator, UnityEngine.FastAnimationEvent fastAnimationEvent) { }

    }

    // TypeToken: 0x2000029
    public class AnimatorStateChangeCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, System.Int32 layerIndex) { }

    }

    // TypeToken: 0x200002A
    public class AnimationEventCallbackOpt : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(UnityEngine.Animator animator, UnityEngine.FastAnimationEventGroup fastAnimationEvent) { }

    }

    // TypeToken: 0x200002B
    public class AniamtorCommonCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Animator animator) { }

    }

    // TypeToken: 0x200002F
    public class OnOverrideControllerDirtyCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x200004D
    public class ExecuteJobFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T& data, System.IntPtr animationStreamPtr, System.IntPtr unusedPtr, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public interface IAnimationClipSource
    {
    }

    // TypeToken: 0x2000003
    public class SharedBetweenAnimatorsAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class StateMachineBehaviour : ScriptableObject
    {
        // Methods
        private System.Void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        private System.Void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        private System.Void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        private System.Void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        private System.Void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        private System.Void OnStatePreExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex) { }
        private System.Void OnStateMachineEnter(UnityEngine.Animator animator, System.Int32 stateMachinePathHash) { }
        private System.Void OnStateMachineExit(UnityEngine.Animator animator, System.Int32 stateMachinePathHash) { }
        private System.Void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        private System.Void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        private System.Void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        private System.Void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        private System.Void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        private System.Void OnStatePreExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        private System.Void OnStateMachineEnter(UnityEngine.Animator animator, System.Int32 stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        private System.Void OnStateMachineExit(UnityEngine.Animator animator, System.Int32 stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public struct PlayMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.PlayMode StopSameLayer;        // 0x0
        public static UnityEngine.PlayMode StopAll;        // 0x0

    }

    // TypeToken: 0x2000006
    public struct QueueMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.QueueMode CompleteOthers;        // 0x0
        public static UnityEngine.QueueMode PlayNow;        // 0x0

    }

    // TypeToken: 0x2000007
    public struct AnimationBlendMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimationBlendMode Blend;        // 0x0
        public static UnityEngine.AnimationBlendMode Additive;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct AnimationPlayMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimationPlayMode Stop;        // 0x0
        public static UnityEngine.AnimationPlayMode Queue;        // 0x0
        public static UnityEngine.AnimationPlayMode Mix;        // 0x0

    }

    // TypeToken: 0x2000009
    public struct AnimationCullingType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimationCullingType AlwaysAnimate;        // 0x0
        public static UnityEngine.AnimationCullingType BasedOnRenderers;        // 0x0
        public static UnityEngine.AnimationCullingType BasedOnClipBounds;        // 0x0
        public static UnityEngine.AnimationCullingType BasedOnUserBounds;        // 0x0

    }

    // TypeToken: 0x200000A
    public struct AnimationEventSource
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimationEventSource NoSource;        // 0x0
        public static UnityEngine.AnimationEventSource Legacy;        // 0x0
        public static UnityEngine.AnimationEventSource Animator;        // 0x0

    }

    // TypeToken: 0x200000B
    public struct AnimEventHashCodeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimEventHashCodeType None;        // 0x0
        public static UnityEngine.AnimEventHashCodeType CRC32;        // 0x0
        public static UnityEngine.AnimEventHashCodeType HashCode64;        // 0x0

    }

    // TypeToken: 0x200000C
    public class Animation : Behaviour, IEnumerable
    {
        // Methods
        private UnityEngine.AnimationClip get_clip() { }
        private System.Void set_clip(UnityEngine.AnimationClip value) { }
        private System.Boolean get_playAutomatically() { }
        private System.Void set_playAutomatically(System.Boolean value) { }
        private UnityEngine.WrapMode get_wrapMode() { }
        private System.Void set_wrapMode(UnityEngine.WrapMode value) { }
        private System.Void Stop() { }
        private System.Void Stop(System.String name) { }
        private System.Void StopNamed(System.String name) { }
        private System.Void Rewind() { }
        private System.Void Rewind(System.String name) { }
        private System.Void RewindNamed(System.String name) { }
        private System.Void Sample() { }
        private System.Boolean get_isPlaying() { }
        private System.Boolean IsPlaying(System.String name) { }
        private UnityEngine.AnimationState get_Item(System.String name) { }
        private System.Boolean Play() { }
        private System.Boolean Play(UnityEngine.PlayMode mode) { }
        private System.Boolean PlayDefaultAnimation(UnityEngine.PlayMode mode) { }
        private System.Boolean Play(System.String animation) { }
        private System.Boolean Play(System.String animation, UnityEngine.PlayMode mode) { }
        private System.Void CrossFade(System.String animation) { }
        private System.Void CrossFade(System.String animation, System.Single fadeLength) { }
        private System.Void CrossFade(System.String animation, System.Single fadeLength, UnityEngine.PlayMode mode) { }
        private System.Void Blend(System.String animation) { }
        private System.Void Blend(System.String animation, System.Single targetWeight) { }
        private System.Void Blend(System.String animation, System.Single targetWeight, System.Single fadeLength) { }
        private UnityEngine.AnimationState CrossFadeQueued(System.String animation) { }
        private UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength) { }
        private UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength, UnityEngine.QueueMode queue) { }
        private UnityEngine.AnimationState CrossFadeQueued(System.String animation, System.Single fadeLength, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode) { }
        private UnityEngine.AnimationState PlayQueued(System.String animation) { }
        private UnityEngine.AnimationState PlayQueued(System.String animation, UnityEngine.QueueMode queue) { }
        private UnityEngine.AnimationState PlayQueued(System.String animation, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode) { }
        private System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName) { }
        private System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName, System.Int32 firstFrame, System.Int32 lastFrame) { }
        private System.Void AddClip(UnityEngine.AnimationClip clip, System.String newName, System.Int32 firstFrame, System.Int32 lastFrame, System.Boolean addLoopFrame) { }
        private System.Void RemoveClip(UnityEngine.AnimationClip clip) { }
        private System.Void RemoveClip(System.String clipName) { }
        private System.Void RemoveClipNamed(System.String clipName) { }
        private System.Int32 GetClipCount() { }
        private System.Boolean Play(UnityEngine.AnimationPlayMode mode) { }
        private System.Boolean Play(System.String animation, UnityEngine.AnimationPlayMode mode) { }
        private System.Void SyncLayer(System.Int32 layer) { }
        private System.Collections.IEnumerator GetEnumerator() { }
        private UnityEngine.AnimationState GetState(System.String name) { }
        private UnityEngine.AnimationState GetStateAtIndex(System.Int32 index) { }
        private System.Int32 GetStateCount() { }
        private UnityEngine.AnimationClip GetClip(System.String name) { }
        private System.Boolean get_animatePhysics() { }
        private System.Void set_animatePhysics(System.Boolean value) { }
        private System.Boolean get_animateOnlyIfVisible() { }
        private System.Void set_animateOnlyIfVisible(System.Boolean value) { }
        private UnityEngine.AnimationCullingType get_cullingType() { }
        private System.Void set_cullingType(UnityEngine.AnimationCullingType value) { }
        private UnityEngine.Bounds get_localBounds() { }
        private System.Void set_localBounds(UnityEngine.Bounds value) { }
        private System.Void .ctor() { }
        private System.Void get_localBounds_Injected(UnityEngine.Bounds& ret) { }
        private System.Void set_localBounds_Injected(UnityEngine.Bounds& value) { }

    }

    // TypeToken: 0x200000E
    public class AnimationState : TrackedReference
    {
        // Methods
        private System.Boolean get_enabled() { }
        private System.Void set_enabled(System.Boolean value) { }
        private System.Single get_weight() { }
        private System.Void set_weight(System.Single value) { }
        private UnityEngine.WrapMode get_wrapMode() { }
        private System.Void set_wrapMode(UnityEngine.WrapMode value) { }
        private System.Single get_time() { }
        private System.Void set_time(System.Single value) { }
        private System.Single get_normalizedTime() { }
        private System.Void set_normalizedTime(System.Single value) { }
        private System.Single get_speed() { }
        private System.Void set_speed(System.Single value) { }
        private System.Single get_normalizedSpeed() { }
        private System.Void set_normalizedSpeed(System.Single value) { }
        private System.Single get_length() { }
        private System.Int32 get_layer() { }
        private System.Void set_layer(System.Int32 value) { }
        private UnityEngine.AnimationClip get_clip() { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private UnityEngine.AnimationBlendMode get_blendMode() { }
        private System.Void set_blendMode(UnityEngine.AnimationBlendMode value) { }
        private System.Void AddMixingTransform(UnityEngine.Transform mix) { }
        private System.Void AddMixingTransform(UnityEngine.Transform mix, System.Boolean recursive) { }
        private System.Void RemoveMixingTransform(UnityEngine.Transform mix) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public struct FastAnimationEvent
    {
        // Fields
        private System.Single m_Time;        // 0x10
        private System.Single m_ClipWeight;        // 0x14
        private System.String m_FunctionName;        // 0x18
        private System.String m_StringParameter;        // 0x20
        private UnityEngine.Object m_ObjectReferenceParameter;        // 0x28
        private System.Single m_FloatParameter;        // 0x30
        private System.Int32 m_IntParameter;        // 0x34
        private UnityEngine.SendMessageOptions m_MessageOptions;        // 0x38
        private System.Int32 m_StringParameterHashCode;        // 0x3C
        private System.Int32 m_FunctionNameHashCode;        // 0x40
        private System.Boolean m_IsInTransition;        // 0x44
        private System.Boolean m_IsFromMaxWeightClipState;        // 0x45
        private System.Boolean m_IsFromNextMaxWeightClipState;        // 0x46

        // Methods
        private System.String get_stringParameter() { }
        private System.Void set_stringParameter(System.String value) { }
        private System.Single get_floatParameter() { }
        private System.Void set_floatParameter(System.Single value) { }
        private System.Int32 get_intParameter() { }
        private System.Void set_intParameter(System.Int32 value) { }
        private System.String get_functionName() { }
        private System.Void set_time(System.Single value) { }
        private System.Void set_messageOptions(UnityEngine.SendMessageOptions value) { }
        private System.Single get_clipWeight() { }
        private System.Void set_clipWeight(System.Single value) { }
        private System.Boolean get_isInTransition() { }
        private System.Void set_isInTransition(System.Boolean value) { }
        private System.Boolean get_isFromMaxWeightClipState() { }
        private System.Void set_isFromMaxWeightClipState(System.Boolean value) { }
        private System.Boolean get_isFromNextMaxWeightClipState() { }
        private System.Void set_isFromNextMaxWeightClipState(System.Boolean value) { }
        private System.Int32 get_functionNameHashCode() { }
        private System.Void set_functionNameHashCode(System.Int32 value) { }

    }

    // TypeToken: 0x2000010
    public struct FastAnimationEventGroup
    {
        // Fields
        public System.Int32 count;        // 0x10
        public System.IntPtr times;        // 0x18
        public System.IntPtr clipWeights;        // 0x20
        public System.IntPtr functionNames;        // 0x28
        public System.IntPtr stringParameters;        // 0x30
        public System.IntPtr functionNamesHashCode;        // 0x38
        public System.IntPtr stringParametersHashCode;        // 0x40
        public System.IntPtr floatParameters;        // 0x48
        public System.IntPtr intParameters;        // 0x50
        public System.IntPtr messageOptions;        // 0x58
        public System.IntPtr inTransitions;        // 0x60
        public System.IntPtr isFromMaxWeightClipStatus;        // 0x68
        public System.IntPtr isFromNextMaxWeightClipStatus;        // 0x70

    }

    // TypeToken: 0x2000011
    public class AnimationEvent
    {
        // Fields
        private System.Single m_Time;        // 0x10
        private System.String m_FunctionName;        // 0x18
        private System.String m_StringParameter;        // 0x20
        private UnityEngine.Object m_ObjectReferenceParameter;        // 0x28
        private System.Single m_FloatParameter;        // 0x30
        private System.Int32 m_IntParameter;        // 0x34
        private System.Int32 m_MessageOptions;        // 0x38
        private UnityEngine.AnimationEventSource m_Source;        // 0x3C
        private UnityEngine.AnimationState m_StateSender;        // 0x40
        private UnityEngine.AnimatorStateInfo m_AnimatorStateInfo;        // 0x48
        private UnityEngine.AnimatorClipInfo m_AnimatorClipInfo;        // 0x7C
        private UnityEngine.AnimEventHashCodeType m_HashCodeType;        // 0x84

        // Methods
        private System.Void .ctor() { }
        private System.String get_stringParameter() { }
        private System.Void set_stringParameter(System.String value) { }
        private System.Single get_floatParameter() { }
        private System.Void set_floatParameter(System.Single value) { }
        private System.Int32 get_intParameter() { }
        private System.Void set_intParameter(System.Int32 value) { }
        private System.Void set_objectReferenceParameter(UnityEngine.Object value) { }
        private System.String get_functionName() { }
        private System.Void set_functionName(System.String value) { }
        private System.Single get_time() { }
        private System.Void set_time(System.Single value) { }
        private System.Void set_messageOptions(UnityEngine.SendMessageOptions value) { }
        private System.Boolean get_isFiredByAnimator() { }
        private UnityEngine.AnimatorClipInfo get_animatorClipInfo() { }

    }

    // TypeToken: 0x2000012
    public class AnimationClip : Motion
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Internal_CreateAnimationClip(UnityEngine.AnimationClip self) { }
        private System.Void SampleAnimation(UnityEngine.GameObject go, System.Single time) { }
        private System.Void SampleAnimationFast(UnityEngine.GameObject go, System.Single time) { }
        private System.Void SampleAnimation(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, System.Single inTime, UnityEngine.WrapMode wrapMode) { }
        private System.Void SampleAnimationFast(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, System.Single inTime, UnityEngine.WrapMode wrapMode) { }
        private System.Single get_length() { }
        private System.Single get_startTime() { }
        private System.Single get_stopTime() { }
        private System.Single get_frameRate() { }
        private System.Void set_frameRate(System.Single value) { }
        private System.UInt16 get_clipTag() { }
        private System.Void set_clipTag(System.UInt16 value) { }
        private System.Void SetCurve(System.String relativePath, System.Type type, System.String propertyName, UnityEngine.AnimationCurve curve) { }
        private System.Boolean GetAnimatorFloatCurve(System.String propertyName, UnityEngine.AnimationCurve curve) { }
        private System.Void EnsureQuaternionContinuity() { }
        private System.Void ClearCurves() { }
        private System.UInt32 GetRuntimeMemorySize() { }
        private UnityEngine.WrapMode get_wrapMode() { }
        private System.Void set_wrapMode(UnityEngine.WrapMode value) { }
        private UnityEngine.Bounds get_localBounds() { }
        private System.Void set_localBounds(UnityEngine.Bounds value) { }
        private System.Boolean get_legacy() { }
        private System.Void set_legacy(System.Boolean value) { }
        private System.Boolean get_humanMotion() { }
        private System.Boolean get_empty() { }
        private System.Boolean get_hasGenericRootTransform() { }
        private System.Boolean get_hasMotionFloatCurves() { }
        private System.Boolean get_hasMotionCurves() { }
        private System.Boolean get_hasRootCurves() { }
        private System.Boolean get_hasRootMotion() { }
        private System.Boolean get_transferRotationCompressed() { }
        private System.Void set_transferRotationCompressed(System.Boolean value) { }
        private System.UInt64 get_uniqueId() { }
        private System.Void AddEvent(UnityEngine.AnimationEvent evt) { }
        private System.Void AddEventInternal(System.Object evt) { }
        private UnityEngine.AnimationEvent[] get_events() { }
        private System.Void set_events(UnityEngine.AnimationEvent[] value) { }
        private System.Void SetEventsInternal(System.Array value) { }
        private System.Array GetEventsInternal() { }
        private System.Void get_localBounds_Injected(UnityEngine.Bounds& ret) { }
        private System.Void set_localBounds_Injected(UnityEngine.Bounds& value) { }

    }

    // TypeToken: 0x2000013
    public struct AvatarTarget
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AvatarTarget Root;        // 0x0
        public static UnityEngine.AvatarTarget Body;        // 0x0
        public static UnityEngine.AvatarTarget LeftFoot;        // 0x0
        public static UnityEngine.AvatarTarget RightFoot;        // 0x0
        public static UnityEngine.AvatarTarget LeftHand;        // 0x0
        public static UnityEngine.AvatarTarget RightHand;        // 0x0

    }

    // TypeToken: 0x2000014
    public struct AvatarIKGoal
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AvatarIKGoal LeftFoot;        // 0x0
        public static UnityEngine.AvatarIKGoal RightFoot;        // 0x0
        public static UnityEngine.AvatarIKGoal LeftHand;        // 0x0
        public static UnityEngine.AvatarIKGoal RightHand;        // 0x0

    }

    // TypeToken: 0x2000015
    public struct AvatarIKHint
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AvatarIKHint LeftKnee;        // 0x0
        public static UnityEngine.AvatarIKHint RightKnee;        // 0x0
        public static UnityEngine.AvatarIKHint LeftElbow;        // 0x0
        public static UnityEngine.AvatarIKHint RightElbow;        // 0x0

    }

    // TypeToken: 0x2000016
    public struct AnimatorControllerParameterType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimatorControllerParameterType Float;        // 0x0
        public static UnityEngine.AnimatorControllerParameterType Int;        // 0x0
        public static UnityEngine.AnimatorControllerParameterType Bool;        // 0x0
        public static UnityEngine.AnimatorControllerParameterType Trigger;        // 0x0

    }

    // TypeToken: 0x2000017
    public struct StateInfoIndex
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.StateInfoIndex CurrentState;        // 0x0
        public static UnityEngine.StateInfoIndex NextState;        // 0x0
        public static UnityEngine.StateInfoIndex ExitState;        // 0x0
        public static UnityEngine.StateInfoIndex InterruptedState;        // 0x0

    }

    // TypeToken: 0x2000018
    public struct AnimationBlendStyle
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimationBlendStyle Linear;        // 0x0
        public static UnityEngine.AnimationBlendStyle CubicIn;        // 0x0
        public static UnityEngine.AnimationBlendStyle HermiteCubic;        // 0x0
        public static UnityEngine.AnimationBlendStyle Sinusoidal;        // 0x0
        public static UnityEngine.AnimationBlendStyle CubicInOut;        // 0x0

    }

    // TypeToken: 0x2000019
    public struct AnimatorTransitionInterruptionSource
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimatorTransitionInterruptionSource None;        // 0x0
        public static UnityEngine.AnimatorTransitionInterruptionSource Current;        // 0x0
        public static UnityEngine.AnimatorTransitionInterruptionSource Next;        // 0x0
        public static UnityEngine.AnimatorTransitionInterruptionSource CurrentThenNext;        // 0x0
        public static UnityEngine.AnimatorTransitionInterruptionSource NextThenCurrent;        // 0x0

    }

    // TypeToken: 0x200001A
    public struct AnimatorRecorderMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimatorRecorderMode Offline;        // 0x0
        public static UnityEngine.AnimatorRecorderMode Playback;        // 0x0
        public static UnityEngine.AnimatorRecorderMode Record;        // 0x0

    }

    // TypeToken: 0x200001B
    public struct AnimatorUroMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimatorUroMode Origin;        // 0x0
        public static UnityEngine.AnimatorUroMode Predict;        // 0x0
        public static UnityEngine.AnimatorUroMode PredictWithTick;        // 0x0
        public static UnityEngine.AnimatorUroMode PredictWithTickAndRootMotion;        // 0x0

    }

    // TypeToken: 0x200001C
    public struct AnimatorCullingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimatorCullingMode AlwaysAnimate;        // 0x0
        public static UnityEngine.AnimatorCullingMode CullUpdateTransforms;        // 0x0
        public static UnityEngine.AnimatorCullingMode CullCompletely;        // 0x0

    }

    // TypeToken: 0x200001D
    public struct AnimatorUpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimatorUpdateMode Normal;        // 0x0
        public static UnityEngine.AnimatorUpdateMode AnimatePhysics;        // 0x0
        public static UnityEngine.AnimatorUpdateMode UnscaledTime;        // 0x0

    }

    // TypeToken: 0x200001E
    public struct AnimatorJobDispatchMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AnimatorJobDispatchMode Default;        // 0x0
        public static UnityEngine.AnimatorJobDispatchMode ForceMainThread;        // 0x0
        public static UnityEngine.AnimatorJobDispatchMode CrossFrame;        // 0x0
        public static UnityEngine.AnimatorJobDispatchMode CrossFrameLateUpdate;        // 0x0

    }

    // TypeToken: 0x200001F
    public struct AnimatorLOD
    {
        // Fields
        public System.Single worldAbsoluteDistance;        // 0x10
        public System.Single maxDeltaTime;        // 0x14
        public System.Int32 framesPerUpdate;        // 0x18
        public System.Single maxBlendDeltaTime;        // 0x1C
        public System.Int32 framesPerWrite;        // 0x20
        public System.Int32 delayFrame;        // 0x24
        public UnityEngine.AnimatorUroMode uroMode;        // 0x28

        // Methods
        private System.Void .ctor(System.Single worldAbsoluteDistance, System.Int32 framesPerUpdate, System.Single maxDeltaTime, System.Int32 framesPerWrite, System.Single maxBlendDeltaTime, UnityEngine.AnimatorUroMode uroMode, System.Int32 delayFrame) { }

    }

    // TypeToken: 0x2000020
    public struct AnimationTransformRWBufferHandle
    {
        // Fields
        public System.UInt16 count;        // 0x10
        public System.UInt16 invalidCount;        // 0x12
        public System.IntPtr validTransformIndexsPtr;        // 0x18
        public System.IntPtr invalidTransformIndexsPtr;        // 0x20
        public System.IntPtr localPositionsPtr;        // 0x28
        public System.IntPtr localRotationsPtr;        // 0x30
        public System.IntPtr localScalesPtr;        // 0x38
        public System.IntPtr positionsPtr;        // 0x40
        public System.IntPtr rotationsPtr;        // 0x48
        public System.IntPtr scalesPtr;        // 0x50
        public System.IntPtr physicsRatioPtr;        // 0x58
        public System.IntPtr writeFlagPtr;        // 0x60
        public System.IntPtr relativePostionPtr;        // 0x68
        public System.IntPtr relativeRotationPtr;        // 0x70
        public System.IntPtr relativeScalePtr;        // 0x78

    }

    // TypeToken: 0x2000021
    public struct HGAnimParameterSGHandle
    {
        // Fields
        public System.Int32 errorCode;        // 0x10
        public System.UInt16 floatParameterCount;        // 0x14
        public System.UInt16 boolParameterCount;        // 0x16
        public System.UInt16 intParameterCount;        // 0x18
        public System.UInt16 layerCount;        // 0x1A
        public System.IntPtr floatParameterNamesPtr;        // 0x20
        public System.IntPtr floatParameterValuesPtr;        // 0x28
        public System.IntPtr boolParameterNamesPtr;        // 0x30
        public System.IntPtr boolParameterValuesPtr;        // 0x38
        public System.IntPtr intParameterNamesPtr;        // 0x40
        public System.IntPtr intParameterValuesPtr;        // 0x48
        public System.IntPtr layerWeightPtr;        // 0x50

    }

    // TypeToken: 0x2000022
    public struct AnimatorClipInfo
    {
        // Fields
        private System.Int32 m_ClipInstanceID;        // 0x10
        private System.Single m_Weight;        // 0x14

        // Methods
        private UnityEngine.AnimationClip get_clip() { }
        private System.Single get_weight() { }
        private UnityEngine.AnimationClip InstanceIDToAnimationClipPPtr(System.Int32 instanceID) { }

    }

    // TypeToken: 0x2000023
    public struct AnimatorStateInfo
    {
        // Fields
        private System.Int32 m_Name;        // 0x10
        private System.Int32 m_Path;        // 0x14
        private System.Int32 m_FullPath;        // 0x18
        private System.Single m_NormalizedTime;        // 0x1C
        private System.Single m_Length;        // 0x20
        private System.Single m_Speed;        // 0x24
        private System.Single m_SpeedMultiplier;        // 0x28
        private System.Int32 m_Tag;        // 0x2C
        private System.Int32 m_Loop;        // 0x30
        private System.Int32 m_SyncGroup;        // 0x34
        private System.Int32 m_SyncGroupRole;        // 0x38
        private System.Int32 m_CullingMode;        // 0x3C
        private System.Int32 m_SourceMsg;        // 0x40

        // Methods
        private System.Boolean IsName(System.String name) { }
        private System.Int32 get_fullPathHash() { }
        private System.Int32 get_shortNameHash() { }
        private System.Single get_normalizedTime() { }
        private System.Single get_length() { }
        private System.Int32 get_tagHash() { }
        private System.Boolean IsTag(System.String tag) { }
        private System.Boolean get_loop() { }

    }

    // TypeToken: 0x2000024
    public struct AnimatorStateRootMotionInfo
    {
        // Fields
        private System.Int32 m_NameHashLeft;        // 0x10
        private UnityEngine.Vector3 m_DeltaPositionLeft;        // 0x14
        private UnityEngine.Quaternion m_DeltaRotationLeft;        // 0x20
        private System.Int32 m_NameHashRight;        // 0x30
        private UnityEngine.Vector3 m_DeltaPositionRight;        // 0x34
        private UnityEngine.Quaternion m_DeltaRotationRight;        // 0x40
        private System.Single m_TransitionWeight;        // 0x50
        private System.Single m_DeltaTime;        // 0x54
        private System.Single m_InterruptedTransitionWeight;        // 0x58
        private System.Int32 m_NameHashinterrupted;        // 0x5C
        private UnityEngine.Vector3 m_DeltaPositioninterrupted;        // 0x60
        private UnityEngine.Quaternion m_DeltaRotationinterrupted;        // 0x6C

    }

    // TypeToken: 0x2000025
    public struct AnimatorTransitionInfo
    {
        // Fields
        private System.Int32 m_FullPath;        // 0x10
        private System.Int32 m_UserName;        // 0x14
        private System.Int32 m_Name;        // 0x18
        private System.Boolean m_HasFixedDuration;        // 0x1C
        private System.Single m_Duration;        // 0x20
        private System.Single m_NormalizedTime;        // 0x24
        private System.Boolean m_AnyState;        // 0x28
        private System.Int32 m_TransitionType;        // 0x2C

        // Methods
        private System.Boolean IsUserName(System.String name) { }
        private System.Int32 get_nameHash() { }

    }

    // TypeToken: 0x2000026
    public struct MatchTargetWeightMask
    {
        // Fields
        private UnityEngine.Vector3 m_PositionXYZWeight;        // 0x10
        private System.Single m_RotationWeight;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 positionXYZWeight, System.Single rotationWeight) { }

    }

    // TypeToken: 0x2000027
    public class Animator : Behaviour
    {
        // Fields
        private UnityEngine.Animator.AnimationEventCallback onAnimationEvent;        // 0x18
        private UnityEngine.Animator.AnimationEventCallbackOpt onAnimationEventOpt;        // 0x20
        private UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateEnter;        // 0x28
        private UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateExit;        // 0x30
        private UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStatePreExit;        // 0x38
        private UnityEngine.Animator.AniamtorCommonCallback afterAnimatorUpdateGraphCB;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private System.Void Internal_CallAnimatorStateChangeCallback(UnityEngine.Animator anim, UnityEngine.AnimatorStateInfo animatorStateInfo, System.Int32 layerIndex, System.Int32 methodIdx) { }
        private System.Void Internal_CallAfterUpdateGraph(UnityEngine.Animator anim) { }
        private System.Boolean Internal_InvokeAnimationEventCallback(UnityEngine.Animator animator, UnityEngine.FastAnimationEvent fastAnimationEvent) { }
        private System.Boolean Internal_InvokeAnimationEventCallbackOpt(UnityEngine.Animator animator, UnityEngine.FastAnimationEventGroup fastAnimationEvent) { }
        private System.Void SetCallbackAfterRootMotionStageCallback(UnityEngine.Animator.AniamtorCommonCallback cb) { }
        private System.Void SetAnimationEventCallback(UnityEngine.Animator.AnimationEventCallback onAnimationEvent) { }
        private System.Void SetAnimationEventCallbackOpt(UnityEngine.Animator.AnimationEventCallbackOpt onAnimationEvent) { }
        private System.Void SetNotifyAnimatorStateEnterAndExitEventCallBack(UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateEnter, UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStateExit) { }
        private System.Void SetNotifyAnimatorStatePreExitEventCallBack(UnityEngine.Animator.AnimatorStateChangeCallback onAnimatorStatePreExit) { }
        private System.Boolean get_fastAnimationEventsOpt() { }
        private System.Void set_fastAnimationEventsOpt(System.Boolean value) { }
        private System.Boolean get_callBackAfterUpdateGraph() { }
        private System.Void set_callBackAfterUpdateGraph(System.Boolean value) { }
        private System.Boolean get_fastAnimationEvents() { }
        private System.Void set_fastAnimationEvents(System.Boolean value) { }
        private System.Boolean get_notifyAnimatorStateEnterAndExitEvent() { }
        private System.Void set_notifyAnimatorStateEnterAndExitEvent(System.Boolean value) { }
        private System.Boolean get_isOptimizable() { }
        private System.Boolean get_isHuman() { }
        private System.Boolean get_hasRootMotion() { }
        private System.Boolean get_isRootPositionOrRotationControlledByCurves() { }
        private System.Single get_humanScale() { }
        private System.Boolean get_isInitialized() { }
        private System.Boolean get_isVisible() { }
        private System.Boolean get_updatedLastFrame() { }
        private System.Boolean get_enableLOD() { }
        private System.Void set_enableLOD(System.Boolean value) { }
        private System.Int32 get_LODLevel() { }
        private System.Boolean SetLODLevel(System.Int32 level) { }
        private System.Int32 GetCurrentLODLevel() { }
        private UnityEngine.AnimatorLOD[] GetLODs() { }
        private System.Void SetLODs(UnityEngine.AnimatorLOD[] lods) { }
        private System.Void SetConstraintEnableImmediately(System.Int32 nameHash) { }
        private System.Void SetConstraintDisableImmediately(System.Int32 nameHash) { }
        private System.Void SetConstraintEnableBlendIn(System.Int32 nameHash, System.Single duration) { }
        private System.Void SetConstraintDisableBlendOut(System.Int32 nameHash, System.Single duration) { }
        private System.Void BecameVisible() { }
        private System.Void SetAnimatorJobOptEnable(System.Boolean enabel) { }
        private System.Void SetAnimatorJobOptFunc(System.Int32 value) { }
        private System.Void SetAnimatorWriteTransformOpt(System.Boolean value) { }
        private System.Void SetGlobalAnimatorClipBindingsOpt(System.Boolean value) { }
        private System.Void SetGlobalAnimatorClipBindingsConstantOpt(System.Boolean value) { }
        private System.Void SetGlobalAnimatorClipBindingsOptByAvatar(System.Boolean value) { }
        private System.Void SetAnimatorUroMaxDeltaTimePerframe(System.Single value) { }
        private System.Void SetGlobalAnimatorCacheClipBindingsOpt(System.Boolean value) { }
        private System.Single GetAnimatorUroMaxDeltaTimePerframe() { }
        private System.Void SetAnimatorMainThreadJobCount(System.Int32 value) { }
        private System.Void SetPrepareFrameJobBatchCountOpt(System.Int32 value) { }
        private System.Void SetProcessAnimJobBatchCountOpt(System.Int32 value) { }
        private System.Void SetAnimatorEnableProcessOneStage(System.Boolean value) { }
        private System.Void SetAnimatorEnableApplyOnMoveInJob(System.Boolean value) { }
        private System.Void SetAnimatorEnableRequireEventsAndBehaviour(System.Boolean value) { }
        private System.Void SetApplyBuildInRootMotionInJob(System.Boolean enable) { }
        private System.Void SetAnimatorForbbidenApplyOnMoveCb(System.Boolean value) { }
        private System.Void SetAnimatorEnableCrossFrameJobs(System.Boolean enabel) { }
        private System.Void SetAbilityLevel(System.Int32 abilityLevel) { }
        private System.Int32 GetAbilityLevel() { }
        private System.Void SetSampleClipCacheCreatePreFrameCount(System.Int32 value) { }
        private System.Void SetSampleClipCacheMaxCount(System.Int32 value) { }
        private System.Void SetLayerMeshSpace(System.Int32 layerIndex, System.Boolean enable) { }
        private System.Boolean GetLayerMeshSpace(System.Int32 layerIndex) { }
        private System.Single GetFloat(System.String name) { }
        private System.Single GetFloat(System.Int32 id) { }
        private System.Single GetFloatFromTransition(System.Int32 layerIndex, System.Int32 id) { }
        private System.Single GetFloatFromTransitionWithDefault(System.Int32 layerIndex, System.Int32 id, System.Single defValue) { }
        private System.Void SetFloat(System.String name, System.Single value) { }
        private System.Void SetFloat(System.String name, System.Single value, System.Single dampTime, System.Single deltaTime) { }
        private System.Void SetFloat(System.Int32 id, System.Single value) { }
        private System.Void SetFloat(System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime) { }
        private System.Boolean GetBool(System.String name) { }
        private System.Boolean GetBool(System.Int32 id) { }
        private System.Void SetBool(System.String name, System.Boolean value) { }
        private System.Void SetBool(System.Int32 id, System.Boolean value) { }
        private System.Int32 GetInteger(System.String name) { }
        private System.Int32 GetInteger(System.Int32 id) { }
        private System.Void SetInteger(System.String name, System.Int32 value) { }
        private System.Void SetInteger(System.Int32 id, System.Int32 value) { }
        private System.Void SetTrigger(System.String name) { }
        private System.Void SetTrigger(System.Int32 id) { }
        private System.Void ResetTrigger(System.String name) { }
        private System.Void ResetTrigger(System.Int32 id) { }
        private System.Boolean IsParameterControlledByCurve(System.String name) { }
        private System.Boolean IsParameterControlledByCurve(System.Int32 id) { }
        private System.Single get_motionDeltaTime() { }
        private UnityEngine.Vector3 get_deltaPosition() { }
        private UnityEngine.Quaternion get_deltaRotation() { }
        private UnityEngine.Vector3 get_velocity() { }
        private UnityEngine.Vector3 get_angularVelocity() { }
        private UnityEngine.Vector3 get_rootPosition() { }
        private System.Void set_rootPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rootRotation() { }
        private System.Void set_rootRotation(UnityEngine.Quaternion value) { }
        private System.Boolean get_applyRootMotion() { }
        private System.Void set_applyRootMotion(System.Boolean value) { }
        private System.Boolean get_linearVelocityBlending() { }
        private System.Void set_linearVelocityBlending(System.Boolean value) { }
        private System.Boolean get_animatePhysics() { }
        private System.Void set_animatePhysics(System.Boolean value) { }
        private UnityEngine.AnimatorUpdateMode get_updateMode() { }
        private System.Void set_updateMode(UnityEngine.AnimatorUpdateMode value) { }
        private System.Boolean get_hasTransformHierarchy() { }
        private System.Boolean get_allowConstantClipSamplingOptimization() { }
        private System.Void set_allowConstantClipSamplingOptimization(System.Boolean value) { }
        private System.Single get_gravityWeight() { }
        private UnityEngine.Vector3 get_bodyPosition() { }
        private System.Void set_bodyPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_bodyPositionInternal() { }
        private System.Void set_bodyPositionInternal(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_bodyRotation() { }
        private System.Void set_bodyRotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Quaternion get_bodyRotationInternal() { }
        private System.Void set_bodyRotationInternal(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal) { }
        private UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal goal) { }
        private System.Void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition) { }
        private System.Void SetGoalPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition) { }
        private UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal) { }
        private UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal goal) { }
        private System.Void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation) { }
        private System.Void SetGoalRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation) { }
        private System.Single GetIKPositionWeight(UnityEngine.AvatarIKGoal goal) { }
        private System.Single GetGoalWeightPosition(UnityEngine.AvatarIKGoal goal) { }
        private System.Void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, System.Single value) { }
        private System.Void SetGoalWeightPosition(UnityEngine.AvatarIKGoal goal, System.Single value) { }
        private System.Single GetIKRotationWeight(UnityEngine.AvatarIKGoal goal) { }
        private System.Single GetGoalWeightRotation(UnityEngine.AvatarIKGoal goal) { }
        private System.Void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, System.Single value) { }
        private System.Void SetGoalWeightRotation(UnityEngine.AvatarIKGoal goal, System.Single value) { }
        private UnityEngine.Vector3 GetIKHintPosition(UnityEngine.AvatarIKHint hint) { }
        private UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint hint) { }
        private System.Void SetIKHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition) { }
        private System.Void SetHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition) { }
        private System.Single GetIKHintPositionWeight(UnityEngine.AvatarIKHint hint) { }
        private System.Single GetHintWeightPosition(UnityEngine.AvatarIKHint hint) { }
        private System.Void SetIKHintPositionWeight(UnityEngine.AvatarIKHint hint, System.Single value) { }
        private System.Void SetHintWeightPosition(UnityEngine.AvatarIKHint hint, System.Single value) { }
        private System.Void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition) { }
        private System.Void SetLookAtPositionInternal(UnityEngine.Vector3 lookAtPosition) { }
        private System.Void SetLookAtWeight(System.Single weight) { }
        private System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight) { }
        private System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight) { }
        private System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight) { }
        private System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight) { }
        private System.Void SetLookAtWeightInternal(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight) { }
        private System.Void SetBoneLocalRotation(UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation) { }
        private System.Void SetBoneLocalRotationInternal(System.Int32 humanBoneId, UnityEngine.Quaternion rotation) { }
        private System.Void SetTransformHierarchy(System.Boolean bHas) { }
        private System.Void SetTransformHierarchyInternal(System.Boolean bHas) { }
        private System.Boolean GetBoneGlobalTRS(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& trs) { }
        private System.Boolean GetBoneGlobalTRSInternal(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& trs) { }
        private UnityEngine.AnimationTransformf GetBoneRootTRS(System.Int32 avatarAssetBoneID) { }
        private UnityEngine.AnimationTransformf GetBoneRootTRSInternal(System.Int32 avatarAssetBoneID) { }
        private UnityEngine.AnimationTransformf GetBoneLocalTRS(System.Int32 avatarAssetBoneID) { }
        private UnityEngine.AnimationTransformf GetBoneLocalTRSInternal(System.Int32 avatarAssetBoneID) { }
        private System.Void SetCorrectiveBoneData(UnityEngine.HGCorrectiveBoneData bindings) { }
        private System.Void SetEnableCorrectiveBoneSystem(System.Boolean enable) { }
        private System.Void SetSequenceLayerSkipTimeThreshold(System.Single value) { }
        private System.Single GetSequenceLayerSkipTimeThreshold() { }
        private System.Void ForceUpdateCorrectiveBoneDataInEditor() { }
        private System.Void SetBakedBindingData(UnityEngine.HGAnimationSetBindings bindings) { }
        private System.Void EnableBakedBindingData(System.Boolean enable) { }
        private System.Boolean SetClipByIndex(UnityEngine.AnimationClip overrideClip, System.Int32 index) { }
        private System.Void UnloadClipsNoRebind(UnityEngine.AnimationClip[] overrideClip, System.Boolean clearCache) { }
        private System.Void ReloadClipsNoRebind(UnityEngine.AnimationClip[] overrideClip) { }
        private System.Void CaptureLastHumanPose() { }
        private System.Void SetWriteTransformDefAsPostProcess(System.Boolean enable) { }
        private System.Void SetWriteTransformDefAsPostProcessSkipOpt(System.Boolean enable) { }
        private System.Void SetAnimatorJobDispatchMode(UnityEngine.AnimatorJobDispatchMode mode) { }
        private UnityEngine.AnimatorJobDispatchMode GetAnimatorJobDispatchMode() { }
        private System.Void SetEnableCollisionConstraintSolver(System.Boolean enable) { }
        private System.Void SetEnableDefaultValuesForceUseDefaultPose(System.Boolean enable) { }
        private System.Boolean IsEnableDefaultValuesForceUseDefaultPose() { }
        private System.Void SetEnableClipBindingOpt(System.Boolean enable) { }
        private System.Void SetEnableOptBindingByAvatar(System.Boolean enable) { }
        private System.Boolean AddClipsToBindingsNoGrown(UnityEngine.AnimationClip[] overrideClip) { }
        private System.Void SetDynamicBindingReserveCount(System.Int32 count) { }
        private System.Void ReCreatePlayableMemory() { }
        private UnityEngine.AnimationTransformRWBufferHandle CreateClothBindings(UnityEngine.Transform[] transformAccessArray) { }
        private UnityEngine.AnimationTransformRWBufferHandle CreateClothBindingsByNameLst(System.String[] transformPathArray) { }
        private System.Void DestroyClothBindings() { }
        private System.Void EnableClothBindings() { }
        private System.Void DisableClothBindings() { }
        private System.Void SetClothBindingsEnableWorldSpace(System.Boolean value) { }
        private System.Boolean CheckClothBindingsEnableWorldSpace() { }
        private System.Void SetMorphBindingsEnableWorldSpace(System.Boolean value) { }
        private System.Boolean CheckMorphBindingsEnableWorldSpace() { }
        private UnityEngine.AnimationTransformRWBufferHandle CreateMorphBindings(UnityEngine.Transform[] transformAccessArray) { }
        private UnityEngine.AnimationTransformRWBufferHandle CreateMorphBindingsByNameLst(System.String[] transformPathArray) { }
        private System.Void EnableMorphBindings() { }
        private System.Void DisableMorphBindings() { }
        private System.Void SetOptimizedAvatarDataSet(System.Boolean optimized) { }
        private System.Void SetEnabelMorphBindingWriteInLateUpdate(System.Boolean enable) { }
        private UnityEngine.ScriptableObject GetBehaviour(System.Type type) { }
        private T GetBehaviour() { }
        private T[] ConvertStateMachineBehaviour(UnityEngine.ScriptableObject[] rawObjects) { }
        private T[] GetBehaviours() { }
        private UnityEngine.ScriptableObject[] InternalGetBehaviours(System.Type type) { }
        private UnityEngine.StateMachineBehaviour[] GetBehaviours(System.Int32 fullPathHash, System.Int32 layerIndex) { }
        private UnityEngine.ScriptableObject[] InternalGetBehavioursByKey(System.Int32 fullPathHash, System.Int32 layerIndex, System.Type type) { }
        private System.Boolean get_stabilizeFeet() { }
        private System.Void set_stabilizeFeet(System.Boolean value) { }
        private System.Int32 get_layerCount() { }
        private System.String GetLayerName(System.Int32 layerIndex) { }
        private System.Int32 GetLayerIndex(System.String layerName) { }
        private System.Single GetLayerWeight(System.Int32 layerIndex) { }
        private System.Void SetLayerWeight(System.Int32 layerIndex, System.Single weight) { }
        private System.Void GetAnimatorStateInfo(System.Int32 layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, UnityEngine.AnimatorStateInfo& info) { }
        private UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(System.Int32 layerIndex) { }
        private UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(System.Int32 layerIndex) { }
        private System.Void GetAnimatorTransitionInfo(System.Int32 layerIndex, UnityEngine.AnimatorTransitionInfo& info) { }
        private UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(System.Int32 layerIndex) { }
        private System.Int32 GetAnimatorClipInfoCount(System.Int32 layerIndex, System.Boolean current) { }
        private System.Int32 GetCurrentAnimatorClipInfoCount(System.Int32 layerIndex) { }
        private System.Int32 GetNextAnimatorClipInfoCount(System.Int32 layerIndex) { }
        private UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(System.Int32 layerIndex) { }
        private UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(System.Int32 layerIndex) { }
        private System.Void GetCurrentAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }
        private System.Void GetAnimatorClipInfoInternal(System.Int32 layerIndex, System.Boolean isCurrent, System.Object clips) { }
        private System.Void GetNextAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }
        private System.Boolean IsInTransition(System.Int32 layerIndex) { }
        private System.Boolean IsPlayingTag(System.Int32 layerIndex, System.Int32 tagHash) { }
        private System.Boolean IsPlayingState(System.Int32 layerIndex, System.Int32 stateNameHash) { }
        private System.Int32 GetAnimatorStateCullMode(System.Int32 layerIndex) { }
        private UnityEngine.AnimatorStateRootMotionInfo GetCurrentAnimatorStateRootmotionInfo(System.Int32 layerIndex) { }
        private System.Void GetAnimatorStateRootMotionInfo(System.Int32 layerIndex, UnityEngine.AnimatorStateRootMotionInfo& output) { }
        private System.Boolean HasTrigger(System.Int32 triggerId) { }
        private UnityEngine.AnimatorControllerParameter[] get_parameters() { }
        private System.Int32 get_parameterCount() { }
        private UnityEngine.AnimatorControllerParameter GetParameterInternal(System.Int32 index) { }
        private UnityEngine.AnimatorControllerParameter GetParameter(System.Int32 index) { }
        private System.Single get_feetPivotActive() { }
        private System.Void set_feetPivotActive(System.Single value) { }
        private System.Single get_pivotWeight() { }
        private UnityEngine.Vector3 get_pivotPosition() { }
        private System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch) { }
        private System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime) { }
        private System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime) { }
        private System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch) { }
        private System.Void InterruptMatchTarget() { }
        private System.Void InterruptMatchTarget(System.Boolean completeMatch) { }
        private System.Boolean get_isMatchingTarget() { }
        private System.Single get_timeScale() { }
        private System.Void set_timeScale(System.Single value) { }
        private System.Single get_speed() { }
        private System.Void set_speed(System.Single value) { }
        private System.Void ForceStateNormalizedTime(System.Single normalizedTime) { }
        private System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration) { }
        private System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer) { }
        private System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset) { }
        private System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion) { }
        private System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime) { }
        private System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset) { }
        private System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer) { }
        private System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration) { }
        private System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion) { }
        private System.Void WriteDefaultValues() { }
        private System.Void WriteDefaultValuesDirty() { }
        private System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime) { }
        private System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset) { }
        private System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer) { }
        private System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration) { }
        private System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion) { }
        private System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource, System.Boolean enableBlendRootMotion) { }
        private System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime) { }
        private System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset) { }
        private System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer) { }
        private System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration) { }
        private System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, UnityEngine.AnimationBlendStyle blendStyle, UnityEngine.AnimatorTransitionInterruptionSource interruptionSource) { }
        private System.Void ResetToDefaultStates() { }
        private System.Void PlayInFixedTime(System.String stateName, System.Int32 layer) { }
        private System.Void PlayInFixedTime(System.String stateName) { }
        private System.Void PlayInFixedTime(System.String stateName, System.Int32 layer, System.Single fixedTime) { }
        private System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer, System.Single fixedTime) { }
        private System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer) { }
        private System.Void PlayInFixedTime(System.Int32 stateNameHash) { }
        private System.Void Play(System.String stateName, System.Int32 layer) { }
        private System.Void Play(System.String stateName) { }
        private System.Void Play(System.String stateName, System.Int32 layer, System.Single normalizedTime) { }
        private System.Void Play(System.Int32 stateNameHash, System.Int32 layer, System.Single normalizedTime) { }
        private System.Void Play(System.Int32 stateNameHash, System.Int32 layer) { }
        private System.Void Play(System.Int32 stateNameHash) { }
        private System.Void SetTarget(UnityEngine.AvatarTarget targetIndex, System.Single targetNormalizedTime) { }
        private UnityEngine.Vector3 get_targetPosition() { }
        private UnityEngine.Quaternion get_targetRotation() { }
        private System.Boolean IsControlled(UnityEngine.Transform transform) { }
        private System.Boolean IsBoneTransform(UnityEngine.Transform transform) { }
        private UnityEngine.Transform get_avatarRoot() { }
        private UnityEngine.Transform GetBoneTransform(UnityEngine.HumanBodyBones humanBoneId) { }
        private UnityEngine.Transform GetBoneTransformInternal(System.Int32 humanBoneId) { }
        private UnityEngine.Transform GetBoneTransformByBoneId(System.Int32 boneID) { }
        private UnityEngine.Transform GetBoneTransformByBoneIdInternal(System.Int32 boneId) { }
        private UnityEngine.AnimatorCullingMode get_cullingMode() { }
        private System.Void set_cullingMode(UnityEngine.AnimatorCullingMode value) { }
        private System.Void StartPlayback() { }
        private System.Void StopPlayback() { }
        private System.Single get_playbackTime() { }
        private System.Void set_playbackTime(System.Single value) { }
        private System.Void StartRecording(System.Int32 frameCount) { }
        private System.Void StopRecording() { }
        private System.Single get_recorderStartTime() { }
        private System.Void set_recorderStartTime(System.Single value) { }
        private System.Single GetRecorderStartTime() { }
        private System.Single get_recorderStopTime() { }
        private System.Void set_recorderStopTime(System.Single value) { }
        private System.Single GetRecorderStopTime() { }
        private UnityEngine.AnimatorRecorderMode get_recorderMode() { }
        private UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController() { }
        private System.Void set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController value) { }
        private System.Boolean get_hasBoundPlayables() { }
        private System.Void ClearInternalControllerPlayable() { }
        private System.Boolean HasState(System.Int32 layerIndex, System.Int32 stateID) { }
        private System.Int32 StringToHash(System.String name) { }
        private System.Int32 StringToHashCRC32(System.IntPtr name) { }
        private UnityEngine.Avatar get_avatar() { }
        private System.Void set_avatar(UnityEngine.Avatar value) { }
        private UnityEngine.HGSkeletalMorphAvatar get_morphAvatar() { }
        private System.Void set_morphAvatar(UnityEngine.HGSkeletalMorphAvatar value) { }
        private UnityEngine.LodBoneMask get_lodBoneMask() { }
        private System.Void set_lodBoneMask(UnityEngine.LodBoneMask value) { }
        private System.UInt32 get_lodBoneMaskLevel() { }
        private System.Void set_lodBoneMaskLevel(System.UInt32 value) { }
        private System.String GetStats() { }
        private UnityEngine.Playables.PlayableGraph get_playableGraph() { }
        private System.Void GetCurrentGraph(UnityEngine.Playables.PlayableGraph& graph) { }
        private System.Void CheckIfInIKPass() { }
        private System.Boolean IsInIKPass() { }
        private System.Void SetFloatString(System.String name, System.Single value) { }
        private System.Void SetFloatID(System.Int32 id, System.Single value) { }
        private System.Single GetFloatString(System.String name) { }
        private System.Single GetFloatID(System.Int32 id) { }
        private System.Single GetFloatFromTransitionByID(System.Int32 layerIndex, System.Int32 id) { }
        private System.Single GetFloatFromTransitionByIDWithDefault(System.Int32 layerIndex, System.Int32 id, System.Single defValue) { }
        private System.Void SetBoolString(System.String name, System.Boolean value) { }
        private System.Void SetBoolID(System.Int32 id, System.Boolean value) { }
        private System.Boolean GetBoolString(System.String name) { }
        private System.Boolean GetBoolID(System.Int32 id) { }
        private System.Void SetIntegerString(System.String name, System.Int32 value) { }
        private System.Void SetIntegerID(System.Int32 id, System.Int32 value) { }
        private System.Int32 GetIntegerString(System.String name) { }
        private System.Int32 GetIntegerID(System.Int32 id) { }
        private System.Void SetTriggerString(System.String name) { }
        private System.Void SetTriggerID(System.Int32 id) { }
        private System.Void ResetTriggerString(System.String name) { }
        private System.Void ResetTriggerID(System.Int32 id) { }
        private System.Boolean IsParameterControlledByCurveString(System.String name) { }
        private System.Boolean IsParameterControlledByCurveID(System.Int32 id) { }
        private System.Void SetFloatStringDamp(System.String name, System.Single value, System.Single dampTime, System.Single deltaTime) { }
        private System.Void SetFloatIDDamp(System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime) { }
        private UnityEngine.HGAnimParameterSGHandle[] GetHGParameterHandles() { }
        private System.Boolean CheckHGParmeterHandleValid() { }
        private System.Boolean get_applyMorphPose() { }
        private System.Void set_applyMorphPose(System.Boolean value) { }
        private System.Int32 GetMorphBoneCount() { }
        private System.Void GetMorphBoneIds(Unity.Collections.NativeArray<System.Int32> arrayToFill) { }
        private System.Void GetMorphBoneIdsUnsafe(System.Int32 count, Unity.Collections.NativeArray<System.Int32> arrayToFill) { }
        private System.Void Internal_GetMorphBoneIds(System.Int32 count, System.IntPtr arrayToFill) { }
        private System.Void SetMorphTransforms(Unity.Collections.NativeArray<System.Int32> boneIds, Unity.Collections.NativeArray<UnityEngine.Vector3> translation, Unity.Collections.NativeArray<UnityEngine.Vector3> euler, Unity.Collections.NativeArray<UnityEngine.Vector3> scale) { }
        private System.Void SetMorphTransformsUnsafe(Unity.Collections.NativeArray<System.Int32> boneIds, Unity.Collections.NativeArray<UnityEngine.Vector3> translation, Unity.Collections.NativeArray<UnityEngine.Vector3> euler, Unity.Collections.NativeArray<UnityEngine.Vector3> scale) { }
        private System.Void Internal_SetMorphTransforms(System.Int32 count, System.IntPtr boneIds, System.IntPtr translation, System.IntPtr euler, System.IntPtr scale) { }
        private System.Boolean get_layersAffectMassCenter() { }
        private System.Void set_layersAffectMassCenter(System.Boolean value) { }
        private System.Single get_leftFeetBottomHeight() { }
        private System.Single get_rightFeetBottomHeight() { }
        private System.Boolean get_supportsOnAnimatorMove() { }
        private System.Void OnUpdateModeChanged() { }
        private System.Void OnCullingModeChanged() { }
        private System.Void WriteDefaultPose() { }
        private System.Void Update(System.Single deltaTime) { }
        private System.Void Rebind() { }
        private System.Void Rebind(System.Boolean writeDefaultValues) { }
        private System.Void ApplyBuiltinRootMotion() { }
        private System.Void EvaluateController() { }
        private System.Void EvaluateController(System.Single deltaTime) { }
        private System.String GetCurrentStateName(System.Int32 layerIndex) { }
        private System.String GetNextStateName(System.Int32 layerIndex) { }
        private System.String GetAnimatorStateName(System.Int32 layerIndex, System.Boolean current) { }
        private System.String ResolveHash(System.Int32 hash) { }
        private System.String GetAnimatorStateName(System.Int32 stateID) { }
        private System.Void GotoState(System.Int32 layer, System.Int32 stateId, System.Single normalizedTime, System.Single transitionDuration, System.Single transitionTime, UnityEngine.AnimationBlendStyle blendStyle) { }
        private System.Void GotoStateInFixedTime(System.Int32 layerIndex, System.Int32 stateId, System.Single fixedTime, System.Single fixedTransitionDuration, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle) { }
        private System.Void SetAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride, System.Boolean rebind) { }
        private System.Void RefreshStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride) { }
        private System.Void SetRuntimeControllerNoRebind(UnityEngine.RuntimeAnimatorController controller) { }
        private System.Void RefreshAnimationStateAsyncCompleteOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride) { }
        private System.Void Internal_GotoState(System.Int32 layer, System.Int32 stateId, System.Single normalizedTime, System.Single transitionDuration, System.Single transitionTime, UnityEngine.AnimationBlendStyle blendStyle) { }
        private System.Void Internal_GotoStateInFixedTime(System.Int32 layerIndex, System.Int32 stateId, System.Single fixedTime, System.Single fixedTransitionDuration, System.Single normalizedTransitionTime, UnityEngine.AnimationBlendStyle blendStyle) { }
        private System.Void Internal_SetAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride, System.Boolean rebind) { }
        private System.Void Internal_RefreshAnimationStateOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride) { }
        private System.Void Internal_SetRuntimeControllerNoRebind(UnityEngine.RuntimeAnimatorController controller) { }
        private System.Void Internal_RefreshAnimationStateAsyncCompleteOverride(UnityEngine.RuntimeAnimatorStateOverride stateOverride) { }
        private System.Void SetAvatarNoBind(UnityEngine.Avatar avatar) { }
        private System.Void Internal_SetAvatarNoBind(UnityEngine.Avatar avatar) { }
        private System.Boolean get_logWarnings() { }
        private System.Void set_logWarnings(System.Boolean value) { }
        private System.Boolean get_fireEvents() { }
        private System.Void set_fireEvents(System.Boolean value) { }
        private System.Boolean get_keepAnimatorControllerStateOnDisable() { }
        private System.Void set_keepAnimatorControllerStateOnDisable(System.Boolean value) { }
        private System.Boolean get_keepAnimatorStateOnDisable() { }
        private System.Void set_keepAnimatorStateOnDisable(System.Boolean value) { }
        private System.Boolean get_writeDefaultValuesOnDisable() { }
        private System.Void set_writeDefaultValuesOnDisable(System.Boolean value) { }
        private UnityEngine.Vector3 GetVector(System.String name) { }
        private UnityEngine.Vector3 GetVector(System.Int32 id) { }
        private System.Void SetVector(System.String name, UnityEngine.Vector3 value) { }
        private System.Void SetVector(System.Int32 id, UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion GetQuaternion(System.String name) { }
        private UnityEngine.Quaternion GetQuaternion(System.Int32 id) { }
        private System.Void SetQuaternion(System.String name, UnityEngine.Quaternion value) { }
        private System.Void SetQuaternion(System.Int32 id, UnityEngine.Quaternion value) { }
        private System.Void get_deltaPosition_Injected(UnityEngine.Vector3& ret) { }
        private System.Void get_deltaRotation_Injected(UnityEngine.Quaternion& ret) { }
        private System.Void get_velocity_Injected(UnityEngine.Vector3& ret) { }
        private System.Void get_angularVelocity_Injected(UnityEngine.Vector3& ret) { }
        private System.Void get_rootPosition_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_rootPosition_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_rootRotation_Injected(UnityEngine.Quaternion& ret) { }
        private System.Void set_rootRotation_Injected(UnityEngine.Quaternion& value) { }
        private System.Void get_bodyPositionInternal_Injected(UnityEngine.Vector3& ret) { }
        private System.Void set_bodyPositionInternal_Injected(UnityEngine.Vector3& value) { }
        private System.Void get_bodyRotationInternal_Injected(UnityEngine.Quaternion& ret) { }
        private System.Void set_bodyRotationInternal_Injected(UnityEngine.Quaternion& value) { }
        private System.Void GetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& ret) { }
        private System.Void SetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& goalPosition) { }
        private System.Void GetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& ret) { }
        private System.Void SetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& goalRotation) { }
        private System.Void GetHintPosition_Injected(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& ret) { }
        private System.Void SetHintPosition_Injected(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& hintPosition) { }
        private System.Void SetLookAtPositionInternal_Injected(UnityEngine.Vector3& lookAtPosition) { }
        private System.Void SetBoneLocalRotationInternal_Injected(System.Int32 humanBoneId, UnityEngine.Quaternion& rotation) { }
        private System.Void GetBoneRootTRSInternal_Injected(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& ret) { }
        private System.Void GetBoneLocalTRSInternal_Injected(System.Int32 avatarAssetBoneID, UnityEngine.AnimationTransformf& ret) { }
        private System.Void CreateClothBindings_Injected(UnityEngine.Transform[] transformAccessArray, UnityEngine.AnimationTransformRWBufferHandle& ret) { }
        private System.Void CreateClothBindingsByNameLst_Injected(System.String[] transformPathArray, UnityEngine.AnimationTransformRWBufferHandle& ret) { }
        private System.Void CreateMorphBindings_Injected(UnityEngine.Transform[] transformAccessArray, UnityEngine.AnimationTransformRWBufferHandle& ret) { }
        private System.Void CreateMorphBindingsByNameLst_Injected(System.String[] transformPathArray, UnityEngine.AnimationTransformRWBufferHandle& ret) { }
        private System.Void get_pivotPosition_Injected(UnityEngine.Vector3& ret) { }
        private System.Void MatchTarget_Injected(UnityEngine.Vector3& matchPosition, UnityEngine.Quaternion& matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask& weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch) { }
        private System.Void get_targetPosition_Injected(UnityEngine.Vector3& ret) { }
        private System.Void get_targetRotation_Injected(UnityEngine.Quaternion& ret) { }

    }

    // TypeToken: 0x200002C
    public class AnimatorControllerParameter
    {
        // Fields
        private System.String m_Name;        // 0x10
        private UnityEngine.AnimatorControllerParameterType m_Type;        // 0x18
        private System.Single m_DefaultFloat;        // 0x1C
        private System.Int32 m_DefaultInt;        // 0x20
        private System.Boolean m_DefaultBool;        // 0x24

        // Methods
        private System.String get_name() { }
        private System.Int32 get_nameHash() { }
        private UnityEngine.AnimatorControllerParameterType get_type() { }
        private System.Boolean Equals(System.Object o) { }
        private System.Int32 GetHashCode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public class AnimationClipPair
    {
        // Fields
        public UnityEngine.AnimationClip originalClip;        // 0x10
        public UnityEngine.AnimationClip overrideClip;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class AnimatorOverrideController : RuntimeAnimatorController
    {
        // Fields
        private UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.RuntimeAnimatorController controller) { }
        private System.Void Internal_Create(UnityEngine.AnimatorOverrideController self, UnityEngine.RuntimeAnimatorController controller) { }
        private UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController() { }
        private System.Void set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController value) { }
        private UnityEngine.AnimationClip get_Item(System.String name) { }
        private System.Void set_Item(System.String name, UnityEngine.AnimationClip value) { }
        private UnityEngine.AnimationClip Internal_GetClipByName(System.String name, System.Boolean returnEffectiveClip) { }
        private System.Void Internal_SetClipByName(System.String name, UnityEngine.AnimationClip clip) { }
        private UnityEngine.AnimationClip get_Item(UnityEngine.AnimationClip clip) { }
        private System.Void set_Item(UnityEngine.AnimationClip clip, UnityEngine.AnimationClip value) { }
        private System.Boolean get_enableBindingOpt() { }
        private System.Void set_enableBindingOpt(System.Boolean value) { }
        private System.Byte get_reserveCount() { }
        private System.Void set_reserveCount(System.Byte value) { }
        private UnityEngine.AnimationClip GetClip(UnityEngine.AnimationClip originalClip, System.Boolean returnEffectiveClip) { }
        private System.Void SetClip(UnityEngine.AnimationClip originalClip, UnityEngine.AnimationClip overrideClip, System.Boolean notify) { }
        private System.Void SendNotification() { }
        private UnityEngine.AnimationClip GetOriginalClip(System.Int32 index) { }
        private UnityEngine.AnimationClip GetOverrideClip(UnityEngine.AnimationClip originalClip) { }
        private System.Int32 get_overridesCount() { }
        private System.Void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }
        private System.Void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }
        private UnityEngine.AnimationClipPair[] get_clips() { }
        private System.Void set_clips(UnityEngine.AnimationClipPair[] value) { }
        private System.Void PerformOverrideClipListCleanup() { }
        private System.Void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller) { }

    }

    // TypeToken: 0x2000030
    public class AnimatorUtility
    {
        // Methods
        private System.Void OptimizeTransformHierarchy(UnityEngine.GameObject go, System.String[] exposedTransforms) { }
        private System.Void DeoptimizeTransformHierarchy(UnityEngine.GameObject go) { }

    }

    // TypeToken: 0x2000031
    public struct HumanBodyBones
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.HumanBodyBones Hips;        // 0x0
        public static UnityEngine.HumanBodyBones LeftUpperLeg;        // 0x0
        public static UnityEngine.HumanBodyBones RightUpperLeg;        // 0x0
        public static UnityEngine.HumanBodyBones LeftLowerLeg;        // 0x0
        public static UnityEngine.HumanBodyBones RightLowerLeg;        // 0x0
        public static UnityEngine.HumanBodyBones LeftFoot;        // 0x0
        public static UnityEngine.HumanBodyBones RightFoot;        // 0x0
        public static UnityEngine.HumanBodyBones Spine;        // 0x0
        public static UnityEngine.HumanBodyBones Chest;        // 0x0
        public static UnityEngine.HumanBodyBones UpperChest;        // 0x0
        public static UnityEngine.HumanBodyBones Neck;        // 0x0
        public static UnityEngine.HumanBodyBones Head;        // 0x0
        public static UnityEngine.HumanBodyBones LeftShoulder;        // 0x0
        public static UnityEngine.HumanBodyBones RightShoulder;        // 0x0
        public static UnityEngine.HumanBodyBones LeftUpperArm;        // 0x0
        public static UnityEngine.HumanBodyBones RightUpperArm;        // 0x0
        public static UnityEngine.HumanBodyBones LeftLowerArm;        // 0x0
        public static UnityEngine.HumanBodyBones RightLowerArm;        // 0x0
        public static UnityEngine.HumanBodyBones LeftHand;        // 0x0
        public static UnityEngine.HumanBodyBones RightHand;        // 0x0
        public static UnityEngine.HumanBodyBones LeftToes;        // 0x0
        public static UnityEngine.HumanBodyBones RightToes;        // 0x0
        public static UnityEngine.HumanBodyBones LeftEye;        // 0x0
        public static UnityEngine.HumanBodyBones RightEye;        // 0x0
        public static UnityEngine.HumanBodyBones Jaw;        // 0x0
        public static UnityEngine.HumanBodyBones LeftThumbProximal;        // 0x0
        public static UnityEngine.HumanBodyBones LeftThumbIntermediate;        // 0x0
        public static UnityEngine.HumanBodyBones LeftThumbDistal;        // 0x0
        public static UnityEngine.HumanBodyBones LeftIndexProximal;        // 0x0
        public static UnityEngine.HumanBodyBones LeftIndexIntermediate;        // 0x0
        public static UnityEngine.HumanBodyBones LeftIndexDistal;        // 0x0
        public static UnityEngine.HumanBodyBones LeftMiddleProximal;        // 0x0
        public static UnityEngine.HumanBodyBones LeftMiddleIntermediate;        // 0x0
        public static UnityEngine.HumanBodyBones LeftMiddleDistal;        // 0x0
        public static UnityEngine.HumanBodyBones LeftRingProximal;        // 0x0
        public static UnityEngine.HumanBodyBones LeftRingIntermediate;        // 0x0
        public static UnityEngine.HumanBodyBones LeftRingDistal;        // 0x0
        public static UnityEngine.HumanBodyBones LeftLittleProximal;        // 0x0
        public static UnityEngine.HumanBodyBones LeftLittleIntermediate;        // 0x0
        public static UnityEngine.HumanBodyBones LeftLittleDistal;        // 0x0
        public static UnityEngine.HumanBodyBones RightThumbProximal;        // 0x0
        public static UnityEngine.HumanBodyBones RightThumbIntermediate;        // 0x0
        public static UnityEngine.HumanBodyBones RightThumbDistal;        // 0x0
        public static UnityEngine.HumanBodyBones RightIndexProximal;        // 0x0
        public static UnityEngine.HumanBodyBones RightIndexIntermediate;        // 0x0
        public static UnityEngine.HumanBodyBones RightIndexDistal;        // 0x0
        public static UnityEngine.HumanBodyBones RightMiddleProximal;        // 0x0
        public static UnityEngine.HumanBodyBones RightMiddleIntermediate;        // 0x0
        public static UnityEngine.HumanBodyBones RightMiddleDistal;        // 0x0
        public static UnityEngine.HumanBodyBones RightRingProximal;        // 0x0
        public static UnityEngine.HumanBodyBones RightRingIntermediate;        // 0x0
        public static UnityEngine.HumanBodyBones RightRingDistal;        // 0x0
        public static UnityEngine.HumanBodyBones RightLittleProximal;        // 0x0
        public static UnityEngine.HumanBodyBones RightLittleIntermediate;        // 0x0
        public static UnityEngine.HumanBodyBones RightLittleDistal;        // 0x0
        public static UnityEngine.HumanBodyBones LastBone;        // 0x0

    }

    // TypeToken: 0x2000032
    public struct AnimationTransformf
    {
        // Fields
        public UnityEngine.Vector3 t;        // 0x10
        public UnityEngine.Quaternion q;        // 0x1C
        public UnityEngine.Vector3 s;        // 0x2C

    }

    // TypeToken: 0x2000033
    public class Avatar
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_isValid() { }
        private System.Boolean get_isHuman() { }
        private UnityEngine.HumanDescription get_humanDescription() { }
        private System.Void SetMuscleMinMax(System.Int32 muscleId, System.Single min, System.Single max) { }
        private System.Void SetParameter(System.Int32 parameterId, System.Single value) { }
        private System.Single GetAxisLength(System.Int32 humanId) { }
        private UnityEngine.Quaternion GetPreRotation(System.Int32 humanId) { }
        private UnityEngine.Quaternion GetPostRotation(System.Int32 humanId) { }
        private UnityEngine.Quaternion GetZYPostQ(System.Int32 humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q) { }
        private UnityEngine.Quaternion GetZYRoll(System.Int32 humanId, UnityEngine.Vector3 uvw) { }
        private UnityEngine.Vector3 GetLimitSign(System.Int32 humanId) { }
        private System.Single Internal_GetAxisLength(System.Int32 humanId) { }
        private UnityEngine.Quaternion Internal_GetPreRotation(System.Int32 humanId) { }
        private UnityEngine.Quaternion Internal_GetPostRotation(System.Int32 humanId) { }
        private UnityEngine.Quaternion Internal_GetZYPostQ(System.Int32 humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q) { }
        private UnityEngine.Quaternion Internal_GetZYRoll(System.Int32 humanId, UnityEngine.Vector3 uvw) { }
        private UnityEngine.Vector3 Internal_GetLimitSign(System.Int32 humanId) { }
        private System.String[] GetBonePaths() { }
        private System.Void get_humanDescription_Injected(UnityEngine.HumanDescription& ret) { }
        private System.Void Internal_GetPreRotation_Injected(System.Int32 humanId, UnityEngine.Quaternion& ret) { }
        private System.Void Internal_GetPostRotation_Injected(System.Int32 humanId, UnityEngine.Quaternion& ret) { }
        private System.Void Internal_GetZYPostQ_Injected(System.Int32 humanId, UnityEngine.Quaternion& parentQ, UnityEngine.Quaternion& q, UnityEngine.Quaternion& ret) { }
        private System.Void Internal_GetZYRoll_Injected(System.Int32 humanId, UnityEngine.Vector3& uvw, UnityEngine.Quaternion& ret) { }
        private System.Void Internal_GetLimitSign_Injected(System.Int32 humanId, UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x2000034
    public struct SkeletonBone
    {
        // Fields
        public System.String name;        // 0x10
        private System.String parentName;        // 0x18
        public UnityEngine.Vector3 position;        // 0x20
        public UnityEngine.Quaternion rotation;        // 0x2C
        public UnityEngine.Vector3 scale;        // 0x3C

    }

    // TypeToken: 0x2000035
    public struct HumanLimit
    {
        // Fields
        private UnityEngine.Vector3 m_Min;        // 0x10
        private UnityEngine.Vector3 m_Max;        // 0x1C
        private UnityEngine.Vector3 m_Center;        // 0x28
        private System.Single m_AxisLength;        // 0x34
        private System.Int32 m_UseDefaultValues;        // 0x38

    }

    // TypeToken: 0x2000036
    public struct HumanBone
    {
        // Fields
        private System.String m_BoneName;        // 0x10
        private System.String m_HumanName;        // 0x18
        public UnityEngine.HumanLimit limit;        // 0x20

    }

    // TypeToken: 0x2000037
    public struct HumanDescription
    {
        // Fields
        public UnityEngine.HumanBone[] human;        // 0x10
        public UnityEngine.SkeletonBone[] skeleton;        // 0x18
        private System.Single m_ArmTwist;        // 0x20
        private System.Single m_ForeArmTwist;        // 0x24
        private System.Single m_UpperLegTwist;        // 0x28
        private System.Single m_LegTwist;        // 0x2C
        private System.Single m_ArmStretch;        // 0x30
        private System.Single m_LegStretch;        // 0x34
        private System.Single m_FeetSpacing;        // 0x38
        private System.Single m_GlobalScale;        // 0x3C
        private System.String m_RootMotionBoneName;        // 0x40
        private System.Boolean m_HasTranslationDoF;        // 0x48
        private System.Boolean m_HasExtraRoot;        // 0x49
        private System.Boolean m_SkeletonHasParents;        // 0x4A

    }

    // TypeToken: 0x2000038
    public struct AvatarMaskBodyPart
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.AvatarMaskBodyPart Root;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart Body;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart Head;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart LeftLeg;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart RightLeg;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart LeftArm;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart RightArm;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart LeftFingers;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart RightFingers;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart LeftFootIK;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart RightFootIK;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart LeftHandIK;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart RightHandIK;        // 0x0
        public static UnityEngine.AvatarMaskBodyPart LastBodyPart;        // 0x0

    }

    // TypeToken: 0x2000039
    public class AvatarMask
    {
        // Methods
        private System.Boolean GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart index) { }
        private System.Int32 get_transformCount() { }
        private System.String GetTransformPath(System.Int32 index) { }
        private System.Single GetTransformWeight(System.Int32 index) { }
        private System.Boolean GetTransformActive(System.Int32 index) { }

    }

    // TypeToken: 0x200003A
    public class HGAnimationSetBindings
    {
    }

    // TypeToken: 0x200003B
    public class HGCorrectiveBoneData
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Internal_Create(UnityEngine.HGCorrectiveBoneData self) { }

    }

    // TypeToken: 0x200003C
    public class HGSkeletalMorphAvatar
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Internal_Create(UnityEngine.HGSkeletalMorphAvatar self) { }

    }

    // TypeToken: 0x200003D
    public struct HumanPose
    {
        // Fields
        public UnityEngine.Vector3 bodyPosition;        // 0x10
        public UnityEngine.Quaternion bodyRotation;        // 0x1C
        public System.Single[] muscles;        // 0x30

        // Methods
        private System.Void Init() { }

    }

    // TypeToken: 0x200003E
    public class HumanPoseHandler, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.IntPtr Internal_CreateFromRoot(UnityEngine.Avatar avatar, UnityEngine.Transform root) { }
        private System.Void Internal_Destroy(System.IntPtr ptr) { }
        private System.Void GetHumanPose(UnityEngine.Vector3& bodyPosition, UnityEngine.Quaternion& bodyRotation, System.Single[] muscles) { }
        private System.Void Dispose() { }
        private System.Void .ctor(UnityEngine.Avatar avatar, UnityEngine.Transform root) { }
        private System.Void GetHumanPose(UnityEngine.HumanPose& humanPose) { }

    }

    // TypeToken: 0x200003F
    public class HumanTrait
    {
        // Methods
        private System.Int32 get_MuscleCount() { }
        private System.Int32 GetBoneIndexFromMono(System.Int32 humanId) { }
        private System.String[] get_MuscleName() { }

    }

    // TypeToken: 0x2000040
    public class LodBoneMask
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Internal_Create(UnityEngine.LodBoneMask self) { }

    }

    // TypeToken: 0x2000041
    public class Motion
    {
        // Fields
        private readonly System.Boolean <isAnimatorMotion>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_isLooping() { }

    }

    // TypeToken: 0x2000042
    public class RuntimeAnimatorController
    {
        // Methods
        private System.Void .ctor() { }
        private UnityEngine.AnimationClip[] get_animationClips() { }

    }

    // TypeToken: 0x2000043
    public class RuntimeAnimatorStateOverride
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void Internal_Create(UnityEngine.RuntimeAnimatorStateOverride self) { }
        private System.Void SetClip(System.Int32 stateID, UnityEngine.AnimationClip overrideClip) { }
        private System.Void SetClipAsync(System.Int32 stateID, System.Single length, System.Boolean isHumanoid) { }
        private System.Void RemoveClip(System.Int32 stateID) { }
        private System.Void ClearClip() { }
        private System.Boolean PreloadClip(UnityEngine.AnimationClip clipB) { }
        private System.Void SetTransition(System.Int32 transUserNameID, System.Single transitionDuration, System.Single transitionOffset, System.Single exitTime) { }
        private System.Void RemoveTransition(System.Int32 transUserNameID) { }
        private System.Void SetSyncGroupCurve(System.UInt32 clipNameID, UnityEngine.AnimationCurve curve) { }
        private System.Void Internal_SetClip(System.UInt32 stateID, UnityEngine.AnimationClip overrideClip) { }
        private System.Void Internal_SetClipAsync(System.UInt32 stateID, System.Single length, System.Boolean isHumanoid) { }
        private System.Void Internal_RemoveClip(System.UInt32 stateID) { }
        private System.Void Internal_ClearClip() { }
        private System.Boolean Internal_PreloadClip(UnityEngine.AnimationClip clipB) { }
        private System.Void Internal_SetTransition(System.UInt32 transUserNameID, System.Single transitionDuration, System.Single transitionOffset, System.Single exitTime) { }
        private System.Void Internal_RemoveTransition(System.UInt32 transUserNameID) { }
        private System.Void Internal_SetSyncGroupCurve(System.UInt32 clipNameID, UnityEngine.AnimationCurve curve) { }

    }

}

namespace UnityEngine.Animations
{

    // TypeToken: 0x2000046
    public class AnimationPlayableBinding
    {
        // Methods
        private UnityEngine.Playables.PlayableBinding Create(System.String name, UnityEngine.Object key) { }
        private UnityEngine.Playables.PlayableOutput CreateAnimationOutput(UnityEngine.Playables.PlayableGraph graph, System.String name) { }

    }

    // TypeToken: 0x2000047
    public class DiscreteEvaluationAttribute : Attribute
    {
    }

    // TypeToken: 0x2000048
    public interface IAnimationJob
    {
        // Methods
        private System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream) { }

    }

    // TypeToken: 0x2000049
    public interface IAnimationWindowPreview
    {
    }

    // TypeToken: 0x200004A
    public class NotKeyableAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public struct JobMethodIndex
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Animations.JobMethodIndex ProcessRootMotionMethodIndex;        // 0x0
        public static UnityEngine.Animations.JobMethodIndex ProcessAnimationMethodIndex;        // 0x0
        public static UnityEngine.Animations.JobMethodIndex MethodIndexCount;        // 0x0

    }

    // TypeToken: 0x200004C
    public struct ProcessAnimationJobStruct`1
    {
        // Fields
        private static System.IntPtr jobReflectionData;        // 0x0

        // Methods
        private System.IntPtr GetJobReflectionData() { }
        private System.Void Execute(T& data, System.IntPtr animationStreamPtr, System.IntPtr methodIndex, Unity.Jobs.LowLevel.Unsafe.JobRanges& ranges, System.Int32 jobIndex) { }

    }

    // TypeToken: 0x200004E
    public struct AdvancedAnimationMixerPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10
        private static readonly UnityEngine.Animations.AdvancedAnimationMixerPlayable m_NullPlayable;        // 0x0

        // Methods
        private UnityEngine.Animations.AdvancedAnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private System.Boolean Equals(UnityEngine.Animations.AdvancedAnimationMixerPlayable other) { }
        private System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle) { }
        private System.Void .cctor() { }
        private System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x200004F
    public struct AnimationClipPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Animations.AnimationClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationClipPlayable playable) { }
        private UnityEngine.Animations.AnimationClipPlayable op_Explicit(UnityEngine.Playables.Playable playable) { }
        private System.Boolean Equals(UnityEngine.Animations.AnimationClipPlayable other) { }
        private UnityEngine.AnimationClip GetAnimationClip() { }
        private System.Single GetAnimationClipPlayableLengthUncheck() { }
        private System.Void SetAnimationClip(UnityEngine.AnimationClip clip) { }
        private System.Void SetAnimationClipAsync(System.Single length, System.Boolean isHumanoid) { }
        private System.Void SetApplyFootIK(System.Boolean value) { }
        private System.Void SetApplyPlayableIK(System.Boolean value) { }
        private System.Void SetRemoveStartOffset(System.Boolean value) { }
        private System.Void SetOverrideLoopTime(System.Boolean value) { }
        private System.Void SetLoopTime(System.Boolean value) { }
        private System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableHandle& handle) { }
        private UnityEngine.AnimationClip GetAnimationClipInternal(UnityEngine.Playables.PlayableHandle& handle) { }
        private System.Void SetAnimationClipInternal(UnityEngine.Playables.PlayableHandle& handle, UnityEngine.AnimationClip clip) { }
        private System.Void SetAnimationClipAsyncInternal(UnityEngine.Playables.PlayableHandle& handle, System.Single length, System.Boolean isHumanoid) { }
        private System.Void SetApplyFootIKInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        private System.Void SetApplyPlayableIKInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        private System.Void SetRemoveStartOffsetInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        private System.Void SetOverrideLoopTimeInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        private System.Void SetLoopTimeInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        private System.Single GetAnimationClipPlayableLengthInternalUncheck(UnityEngine.Playables.PlayableHandle& handle) { }
        private System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000050
    public struct AnimationHumanStream
    {
        // Fields
        private System.IntPtr stream;        // 0x10

    }

    // TypeToken: 0x2000051
    public struct AnimationLayerMixerPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10
        private static readonly UnityEngine.Animations.AnimationLayerMixerPlayable m_NullPlayable;        // 0x0

        // Methods
        private UnityEngine.Animations.AnimationLayerMixerPlayable get_Null() { }
        private UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean singleLayerOptimization) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle, System.Boolean singleLayerOptimization) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationLayerMixerPlayable playable) { }
        private UnityEngine.Animations.AnimationLayerMixerPlayable op_Explicit(UnityEngine.Playables.Playable playable) { }
        private System.Boolean Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other) { }
        private System.Void SetLayerAdditive(System.UInt32 layerIndex, System.Boolean value) { }
        private System.Void SetLayerMaskFromAvatarMask(System.UInt32 layerIndex, UnityEngine.AvatarMask mask) { }
        private System.Void SetLayerRootMotionDisable(System.UInt32 layerIndex, System.Boolean value) { }
        private System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle) { }
        private System.Void SetLayerAdditiveInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, System.Boolean value) { }
        private System.Void SetSingleLayerOptimizationInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        private System.Void SetLayerMaskFromAvatarMaskInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, UnityEngine.AvatarMask mask) { }
        private System.Void SetLayerRootMotionDisableInternal(UnityEngine.Playables.PlayableHandle& handle, System.UInt32 layerIndex, System.Boolean value) { }
        private System.Void .cctor() { }
        private System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000052
    public struct AnimationMixerPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10
        private static readonly UnityEngine.Animations.AnimationMixerPlayable m_NullPlayable;        // 0x0

        // Methods
        private UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount, System.Boolean normalizeWeights) { }
        private UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMixerPlayable playable) { }
        private System.Boolean Equals(UnityEngine.Animations.AnimationMixerPlayable other) { }
        private System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle) { }
        private System.Void .cctor() { }
        private System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000053
    public struct AnimationMotionXToDeltaPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10
        private static readonly UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_NullPlayable;        // 0x0

        // Methods
        private UnityEngine.Animations.AnimationMotionXToDeltaPlayable Create(UnityEngine.Playables.PlayableGraph graph) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMotionXToDeltaPlayable playable) { }
        private System.Boolean Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other) { }
        private System.Void SetAbsoluteMotion(System.Boolean value) { }
        private System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle) { }
        private System.Void SetAbsoluteMotionInternal(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        private System.Void .cctor() { }
        private System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000054
    public struct AnimationOffsetPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10
        private static readonly UnityEngine.Animations.AnimationOffsetPlayable m_NullPlayable;        // 0x0

        // Methods
        private UnityEngine.Animations.AnimationOffsetPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 inputCount) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 inputCount) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationOffsetPlayable playable) { }
        private System.Boolean Equals(UnityEngine.Animations.AnimationOffsetPlayable other) { }
        private System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Playables.PlayableHandle& handle) { }
        private System.Void .cctor() { }
        private System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000055
    public class AnimationPlayableExtensions
    {
        // Methods
        private System.Void SetAnimatedProperties(U playable, UnityEngine.AnimationClip clip) { }
        private System.Void SetAnimatedPropertiesInternal(UnityEngine.Playables.PlayableHandle& playable, UnityEngine.AnimationClip animatedProperties) { }

    }

    // TypeToken: 0x2000056
    public class AnimationPlayableGraphExtensions
    {
        // Methods
        private System.Boolean InternalCreateAnimationOutput(UnityEngine.Playables.PlayableGraph& graph, System.String name, UnityEngine.Playables.PlayableOutputHandle& handle) { }

    }

    // TypeToken: 0x2000057
    public struct AnimationPlayableOutput, IPlayableOutput
    {
        // Fields
        private UnityEngine.Playables.PlayableOutputHandle m_Handle;        // 0x10

        // Methods
        private UnityEngine.Animations.AnimationPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, System.String name, UnityEngine.Animator target) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableOutputHandle handle) { }
        private UnityEngine.Animations.AnimationPlayableOutput get_Null() { }
        private UnityEngine.Playables.PlayableOutputHandle GetHandle() { }
        private UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Animations.AnimationPlayableOutput output) { }
        private UnityEngine.Animations.AnimationPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output) { }
        private UnityEngine.Animator GetTarget() { }
        private System.Void SetTarget(UnityEngine.Animator value) { }
        private System.Void SetNeedRebindOnChanged(System.Boolean value) { }
        private UnityEngine.Animator InternalGetTarget(UnityEngine.Playables.PlayableOutputHandle& handle) { }
        private System.Void InternalSetTarget(UnityEngine.Playables.PlayableOutputHandle& handle, UnityEngine.Animator target) { }
        private System.Void InternalSetNeedRebindOnChanged(UnityEngine.Playables.PlayableOutputHandle& handle, System.Boolean value) { }

    }

    // TypeToken: 0x2000058
    public struct AnimationPosePlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10
        private static readonly UnityEngine.Animations.AnimationPosePlayable m_NullPlayable;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private System.Boolean Equals(UnityEngine.Animations.AnimationPosePlayable other) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000059
    public struct AnimationRemoveScalePlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10
        private static readonly UnityEngine.Animations.AnimationRemoveScalePlayable m_NullPlayable;        // 0x0

        // Methods
        private UnityEngine.Animations.AnimationRemoveScalePlayable Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationRemoveScalePlayable playable) { }
        private System.Boolean Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other) { }
        private System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle) { }
        private System.Void .cctor() { }
        private System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x200005A
    public struct AnimationScriptPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10
        private static readonly UnityEngine.Animations.AnimationScriptPlayable m_NullPlayable;        // 0x0

        // Methods
        private UnityEngine.Animations.AnimationScriptPlayable Create(UnityEngine.Playables.PlayableGraph graph, T jobData, System.Int32 inputCount) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, System.Int32 inputCount) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private System.Void CheckJobTypeValidity() { }
        private System.Void SetJobData(T jobData) { }
        private UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationScriptPlayable playable) { }
        private System.Boolean Equals(UnityEngine.Animations.AnimationScriptPlayable other) { }
        private System.Void SetForceWriteRootMotionParam(System.Boolean value) { }
        private System.Void SetForceResetParam(System.Boolean value) { }
        private System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableHandle& handle, System.IntPtr jobReflectionData) { }
        private System.Void SetForceWriteRootMotionParamInternal(UnityEngine.Playables.PlayableHandle handle, System.Boolean value) { }
        private System.Void SetForceResetParamInternal(UnityEngine.Playables.PlayableHandle handle, System.Boolean value) { }
        private System.Void .cctor() { }
        private System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.Playables.PlayableHandle& handle, System.IntPtr jobReflectionData) { }
        private System.Void SetForceWriteRootMotionParamInternal_Injected(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }
        private System.Void SetForceResetParamInternal_Injected(UnityEngine.Playables.PlayableHandle& handle, System.Boolean value) { }

    }

    // TypeToken: 0x200005B
    public struct AnimationStream
    {
        // Fields
        private System.UInt32 m_AnimatorBindingsVersion;        // 0x10
        private System.IntPtr constant;        // 0x18
        private System.IntPtr input;        // 0x20
        private System.IntPtr output;        // 0x28
        private System.IntPtr workspace;        // 0x30
        private System.IntPtr inputStreamAccessor;        // 0x38
        private System.IntPtr animationHandleBinder;        // 0x40

        // Methods
        private System.UInt32 get_animatorBindingsVersion() { }
        private System.Boolean get_isValid() { }
        private System.Void CheckIsValid() { }
        private System.Single get_deltaTime() { }
        private System.Single GetDeltaTime() { }
        private System.Single GetDeltaTime_Injected(UnityEngine.Animations.AnimationStream& _unity_self) { }

    }

    // TypeToken: 0x200005C
    public struct TransformStreamHandle
    {
        // Fields
        private System.UInt32 m_AnimatorBindingsVersion;        // 0x10
        private System.Int32 handleIndex;        // 0x14
        private System.Int32 skeletonIndex;        // 0x18

        // Methods
        private System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream) { }
        private System.Boolean IsValidInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Boolean get_createdByNative() { }
        private System.Boolean IsSameVersionAsStream(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Boolean get_hasHandleIndex() { }
        private System.Boolean get_hasSkeletonIndex() { }
        private System.UInt32 get_animatorBindingsVersion() { }
        private System.Void Resolve(UnityEngine.Animations.AnimationStream stream) { }
        private System.Boolean IsResolved(UnityEngine.Animations.AnimationStream stream) { }
        private System.Boolean IsResolvedInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream& stream) { }
        private UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void SetPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position) { }
        private UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void SetRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void SetLocalPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position) { }
        private UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void SetLocalRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void SetLocalScale(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale) { }
        private System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private System.Void SetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Boolean useMask) { }
        private System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Void SetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useMask) { }
        private System.Void ResolveInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private UnityEngine.Vector3 GetPositionInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void SetPositionInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position) { }
        private UnityEngine.Quaternion GetRotationInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void SetRotationInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Vector3 GetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void SetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position) { }
        private UnityEngine.Quaternion GetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void SetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Vector3 GetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void SetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 scale) { }
        private System.Void GetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private System.Void SetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Boolean useMask) { }
        private System.Void GetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Void SetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Boolean useMask) { }
        private System.Void ResolveInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void GetPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        private System.Void SetPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position) { }
        private System.Void GetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret) { }
        private System.Void SetRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& rotation) { }
        private System.Void GetLocalPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        private System.Void SetLocalPositionInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position) { }
        private System.Void GetLocalRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret) { }
        private System.Void SetLocalRotationInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& rotation) { }
        private System.Void GetLocalScaleInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        private System.Void SetLocalScaleInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& scale) { }
        private System.Void GetLocalTRSInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private System.Void SetLocalTRSInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale, System.Boolean useMask) { }
        private System.Void GetGlobalTRInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Void SetGlobalTRInternal_Injected(UnityEngine.Animations.TransformStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, System.Boolean useMask) { }

    }

    // TypeToken: 0x200005D
    public struct PropertyStreamHandle
    {
        // Fields
        private System.UInt32 m_AnimatorBindingsVersion;        // 0x10
        private System.Int32 handleIndex;        // 0x14
        private System.Int32 valueArrayIndex;        // 0x18
        private System.Int32 bindType;        // 0x1C

        // Methods
        private System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream) { }
        private System.Boolean IsValidInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Boolean get_createdByNative() { }
        private System.Boolean IsSameVersionAsStream(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Boolean get_hasHandleIndex() { }
        private System.Boolean get_hasValueArrayIndex() { }
        private System.Boolean get_hasBindType() { }
        private System.UInt32 get_animatorBindingsVersion() { }
        private System.Boolean IsResolvedInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void CheckIsValidAndResolve(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Single GetFloat(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void SetFloat(UnityEngine.Animations.AnimationStream stream, System.Single value) { }
        private System.Int32 GetInt(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void SetInt(UnityEngine.Animations.AnimationStream stream, System.Int32 value) { }
        private System.Boolean GetBool(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void SetBool(UnityEngine.Animations.AnimationStream stream, System.Boolean value) { }
        private System.Void ResolveInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Single GetFloatInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void SetFloatInternal(UnityEngine.Animations.AnimationStream& stream, System.Single value) { }
        private System.Int32 GetIntInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void SetIntInternal(UnityEngine.Animations.AnimationStream& stream, System.Int32 value) { }
        private System.Boolean GetBoolInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void SetBoolInternal(UnityEngine.Animations.AnimationStream& stream, System.Boolean value) { }
        private System.Void ResolveInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        private System.Single GetFloatInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void SetFloatInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Single value) { }
        private System.Int32 GetIntInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void SetIntInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Int32 value) { }
        private System.Boolean GetBoolInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void SetBoolInternal_Injected(UnityEngine.Animations.PropertyStreamHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, System.Boolean value) { }

    }

    // TypeToken: 0x200005E
    public struct TransformSceneHandle
    {
        // Fields
        private System.UInt32 valid;        // 0x10
        private System.Int32 transformSceneHandleDefinitionIndex;        // 0x14

        // Methods
        private System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream) { }
        private System.Boolean get_createdByNative() { }
        private System.Boolean get_hasTransformSceneHandleDefinitionIndex() { }
        private System.Void CheckIsValid(UnityEngine.Animations.AnimationStream& stream) { }
        private UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream) { }
        private UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream) { }
        private System.Void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private System.Void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Boolean HasValidTransform(UnityEngine.Animations.AnimationStream& stream) { }
        private UnityEngine.Vector3 GetPositionInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private UnityEngine.Vector3 GetLocalPositionInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private UnityEngine.Quaternion GetRotationInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private UnityEngine.Quaternion GetLocalRotationInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private UnityEngine.Vector3 GetLocalScaleInternal(UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void GetLocalTRSInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private System.Void GetGlobalTRInternal(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }
        private System.Boolean HasValidTransform_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream) { }
        private System.Void GetPositionInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        private System.Void GetLocalPositionInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        private System.Void GetRotationInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret) { }
        private System.Void GetLocalRotationInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion& ret) { }
        private System.Void GetLocalScaleInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& ret) { }
        private System.Void GetLocalTRSInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale) { }
        private System.Void GetGlobalTRInternal_Injected(UnityEngine.Animations.TransformSceneHandle& _unity_self, UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation) { }

    }

    // TypeToken: 0x200005F
    public struct PropertySceneHandle
    {
        // Fields
        private System.UInt32 valid;        // 0x10
        private System.Int32 handleIndex;        // 0x14

    }

    // TypeToken: 0x2000060
    public class AnimationSceneHandleUtility
    {
        // Methods
        private System.Void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<System.Single> buffer) { }
        private System.Int32 ValidateAndGetArrayCount(UnityEngine.Animations.AnimationStream& stream, Unity.Collections.NativeArray<T0> handles, Unity.Collections.NativeArray<T1> buffer) { }
        private System.Void ReadSceneFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertySceneHandles, System.Void* floatBuffer, System.Int32 count) { }

    }

    // TypeToken: 0x2000061
    public class AnimationStreamHandleUtility
    {
        // Methods
        private System.Void WriteFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<System.Single> buffer, System.Boolean useMask) { }
        private System.Void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<System.Single> buffer) { }
        private System.Void ReadStreamFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertyStreamHandles, System.Void* floatBuffer, System.Int32 count) { }
        private System.Void WriteStreamFloatsInternal(UnityEngine.Animations.AnimationStream& stream, System.Void* propertyStreamHandles, System.Void* floatBuffer, System.Int32 count, System.Boolean useMask) { }

    }

    // TypeToken: 0x2000062
    public struct AnimatorControllerPlayable, IPlayable, IEquatable`1
    {
        // Fields
        private UnityEngine.Playables.PlayableHandle m_Handle;        // 0x10
        private static readonly UnityEngine.Animations.AnimatorControllerPlayable m_NullPlayable;        // 0x0

        // Methods
        private UnityEngine.Animations.AnimatorControllerPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller) { }
        private UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller) { }
        private System.Void .ctor(UnityEngine.Playables.PlayableHandle handle) { }
        private UnityEngine.Playables.PlayableHandle GetHandle() { }
        private System.Void SetHandle(UnityEngine.Playables.PlayableHandle handle) { }
        private System.Boolean Equals(UnityEngine.Animations.AnimatorControllerPlayable other) { }
        private System.Boolean IsInTransition(System.Int32 layerIndex) { }
        private System.Boolean CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller, UnityEngine.Playables.PlayableHandle& handle) { }
        private System.Boolean IsInTransitionInternal(UnityEngine.Playables.PlayableHandle& handle, System.Int32 layerIndex) { }
        private System.Void .cctor() { }
        private System.Boolean CreateHandleInternal_Injected(UnityEngine.Playables.PlayableGraph& graph, UnityEngine.RuntimeAnimatorController controller, UnityEngine.Playables.PlayableHandle& handle) { }

    }

    // TypeToken: 0x2000063
    public struct CustomStreamPropertyType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Animations.CustomStreamPropertyType Float;        // 0x0
        public static UnityEngine.Animations.CustomStreamPropertyType Bool;        // 0x0
        public static UnityEngine.Animations.CustomStreamPropertyType Int;        // 0x0

    }

    // TypeToken: 0x2000064
    public class AnimatorJobExtensions
    {
        // Methods
        private UnityEngine.Animations.TransformStreamHandle BindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform) { }
        private UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property) { }
        private UnityEngine.Animations.PropertyStreamHandle BindCustomStreamProperty(UnityEngine.Animator animator, System.String property, UnityEngine.Animations.CustomStreamPropertyType type) { }
        private UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference) { }
        private UnityEngine.Animations.TransformSceneHandle BindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform) { }
        private UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property) { }
        private UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference) { }
        private System.Void InternalBindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, UnityEngine.Animations.TransformStreamHandle& transformStreamHandle) { }
        private System.Void InternalBindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference, UnityEngine.Animations.PropertyStreamHandle& propertyStreamHandle) { }
        private System.Void InternalBindCustomStreamProperty(UnityEngine.Animator animator, System.String property, UnityEngine.Animations.CustomStreamPropertyType propertyType, UnityEngine.Animations.PropertyStreamHandle& propertyStreamHandle) { }
        private System.Void InternalBindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, UnityEngine.Animations.TransformSceneHandle& transformSceneHandle) { }
        private System.Void InternalBindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, System.String property, System.Boolean isObjectReference, UnityEngine.Animations.PropertySceneHandle& propertySceneHandle) { }

    }

    // TypeToken: 0x2000065
    public struct Axis
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Animations.Axis None;        // 0x0
        public static UnityEngine.Animations.Axis X;        // 0x0
        public static UnityEngine.Animations.Axis Y;        // 0x0
        public static UnityEngine.Animations.Axis Z;        // 0x0

    }

}

namespace UnityEngine.Experimental.Animations
{

    // TypeToken: 0x2000044
    public struct AnimationStreamSource
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Experimental.Animations.AnimationStreamSource DefaultValues;        // 0x0
        public static UnityEngine.Experimental.Animations.AnimationStreamSource PreviousInputs;        // 0x0

    }

    // TypeToken: 0x2000045
    public class AnimationPlayableOutputExtensions
    {
        // Methods
        private System.Void SetAnimationStreamSource(UnityEngine.Animations.AnimationPlayableOutput output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource) { }
        private System.Void SetSortingOrder(UnityEngine.Animations.AnimationPlayableOutput output, System.UInt16 sortingOrder) { }
        private System.Void InternalSetAnimationStreamSource(UnityEngine.Playables.PlayableOutputHandle output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource) { }
        private System.Void InternalSetSortingOrder(UnityEngine.Playables.PlayableOutputHandle output, System.Int32 sortingOrder) { }
        private System.Void InternalSetAnimationStreamSource_Injected(UnityEngine.Playables.PlayableOutputHandle& output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource) { }
        private System.Void InternalSetSortingOrder_Injected(UnityEngine.Playables.PlayableOutputHandle& output, System.Int32 sortingOrder) { }

    }

}

